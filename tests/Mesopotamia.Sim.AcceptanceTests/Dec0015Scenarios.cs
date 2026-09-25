using System.Collections.Immutable;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    internal List<object> Dec0015ProbeEvidence { get; } = [];

    private static InitialWorld Dec0015World(int selfAttitude = 0, int outbound = 0, int inbound = 0)
    {
        InitialWorld world = World(40, 40, 40, outbound, inbound);
        return world with { Attitudes = [.. world.Attitudes, new(new(6), new(1), new(1), selfAttitude)] };
    }

    internal IEnumerable<Scenario> Dec0015Cases()
    {
        yield return new("Dec0015SelfCounterpartyBoundary", ["S1-107-SELF-COUNTERPARTY"], () =>
        {
            ActionTerms[] terms =
            [
                new OfferGift(new(1), 1), new RequestGiftOrHelp(new(1), 1),
                new OfferLoan(new(1), 1), new RequestLoan(new(1), 1),
                new OfferBenefitForFavor(new(1), 1),
                new RelationshipMediatedReciprocalHelp(new(1), 1),
                new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true)
            ];
            foreach (ActionTerms term in terms)
                foreach (bool diagonal in new[] { false, true })
                    foreach (string profile in new[] { "SCORE-RP-001", "SCORE-RP-002" })
                    {
                        InitialWorld initial = diagonal ? Dec0015World(75) : World(40, 40, 40);
                        Simulation baseline = Create(initial);
                        Simulation sim = Create(initial);
                        CycleResult result;
                        try
                        {
                            result = sim.RunCycle(new([P(1, 1, term)])
                            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(1), profile) });
                        }
                        catch (ArgumentException error)
                        {
                            Assert.Fail("Self-counterparty must return InvalidTerms before execution, not fault during execution: " + error.Message);
                            throw;
                        }
                        Equal("InvalidCounterparty", result.Outcomes.Single().Reason);
                        Dec0015Oracle.InvalidInteraction(sim, result, new(1));
                        Dec0015Oracle.NoClaimsOrConsequences(sim);
                        Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                    }

            // Invalid detached state is a validator target, never a live simulation fixture.
            Simulation control = Create(Dec0015World(75));
            RelationId id = new(99);
            Favour invalid = new(id, new(1), new(1), true, new(900));
            WorldSnapshot detached = control.Snapshot with { Favours = control.Snapshot.Favours.Add(id, invalid) };
            string? rejection = ActionRules.Invalid(P(99, 1, new CallFavor(id, new Farm())), detached);
            Equal("InvalidCounterparty", rejection);
            Dec0015ProbeEvidence.Add(new
            {
                Probe = "DetachedSelfCall",
                Target = "ActionRules.Invalid",
                WrittenFavour = invalid,
                Expected = "InvalidCounterparty",
                Actual = rejection,
                LiveSimulationWrite = false,
                Limit = "Validator boundary only; response suppression is separately exercised through a public call."
            });

            foreach (string profile in new[] { "SCORE-RP-003", "SCORE-RP-004" })
            {
                Simulation sim = WithFavour();
                Simulation baseline = WithFavour();
                Favour ordinary = sim.Snapshot.Favours.Values.Single();
                // The debtor attempts a call targeting themselves. Holder/debtor equality
                // cannot be constructed through public ingress under current semantics.
                CycleResult result = sim.RunCycle(new([P(2, 2, new CallFavor(ordinary.Id, new Farm()))])
                { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), profile) });
                Equal("InvalidCounterparty", result.Outcomes.Single().Reason);
                Dec0015Oracle.InvalidInteraction(sim, result, new(2));
                Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                True(result.State.Favours[ordinary.Id].Outstanding);
                True(!result.Events.Any(e => e.Kind is "CalledFavourFulfilled" or "AttitudeComposition"));
            }
        }, "Declared initial state; endogenous ordinary favour; one explicitly recorded detached invalid snapshot for validator-only evidence");

        yield return new("Dec0015AttitudeDiagonal", ["S1-107-ATTITUDE-DIAGONAL"], () =>
        {
            foreach (int value in new[] { -100, -5, -2, -1, 0, 1, 2, 5, 100 })
            {
                Simulation sim;
                try { sim = Create(Dec0015World(value, 9, -8)); }
                catch (ArgumentException error) { Assert.Fail("Valid diagonal Attitude construction rejected: " + error.Message); throw; }
                Equal(value, sim.Snapshot.AttitudeOf(new(1), new(1)));
                Attitude self = sim.Snapshot.Attitudes[new(6)];
                Equal(new PersonId(1), self.From); Equal(new PersonId(1), self.To);
                Equal(value, self.Value);
                for (int cycle = 1; cycle <= 6; cycle++)
                {
                    CycleResult result = sim.RunCycle(CycleInput.Empty);
                    int expected = cycle < 5 ? value : value > 0 ? Math.Max(0, value - 2) : Math.Min(0, value + 1);
                    Equal(expected, result.State.Attitudes[self.Id].Value);
                    Equal(expected, result.State.AttitudeOf(new(1), new(1)));
                    Equal(cycle < 5 ? 9 : 7, result.State.AttitudeOf(new(1), new(2)));
                    Equal(cycle < 5 ? -8 : -7, result.State.AttitudeOf(new(2), new(1)));
                    SemanticEvent[] decay = [.. result.Events.Where(e => e.Kind == "AttitudeDecay" &&
                        e.Participants.SequenceEqual(new[] { new PersonId(1), new PersonId(1) }))];
                    Equal(cycle == 5 ? 1 : 0, decay.Length);
                    if (decay.Length != 0) Equal($"{value}->{expected}", decay[0].Detail);
                }
            }
            foreach (int value in new[] { -101, 101 })
                Equal("Attitude outside bounds.", Assert.ThrowsExactly<ArgumentException>(() => new Simulation(Dec0015World(value))).Message);
            Simulation action = Create(Dec0015World(25));
            CycleResult invalid = action.RunCycle(new([P(1, 1, new OfferGift(new(1), 1))]));
            Dec0015Oracle.InvalidInteraction(action, invalid, new(1));
            Equal(25, invalid.State.AttitudeOf(new(1), new(1)));
        });

        yield return new("Dec0015DebtDiagonal", ["S1-107-DEBT-DIAGONAL"], () =>
        {
            foreach (bool request in new[] { false, true })
            {
                InitialWorld initial = Dec0015World(20);
                Simulation sim = Create(initial);
                Simulation baseline = Create(initial);
                CycleResult result = sim.RunCycle(new([P(1, 1, request ? new RequestLoan(new(1), 1) : new OfferLoan(new(1), 1))]));
                Dec0015Oracle.InvalidInteraction(sim, result, new(1));
                Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                // No claim exists at the would-be commitment+3 due boundary.
                for (int i = 0; i < 3; i++)
                    Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, sim.RunCycle(CycleInput.Empty).State);
                result = sim.RunCycle(new([P(2, 1, new RepayDebt(new(99), 1))]));
                Equal("UnknownDebt", result.Outcomes.Single().Reason);
                Dec0015Oracle.InvalidInteraction(sim, result, new(2));
                Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                Dec0015Oracle.NoClaimsOrConsequences(sim);
            }
            foreach (bool diagonal in new[] { false, true })
            {
                WorldState state = new(Dec0015World(10));
                RelationId id = state.AllocateRelation();
                Debt debt = new(id, new(1), new(diagonal ? 1 : 2), 1, 1, 0, false, new(901));
                state.Debts.Add(id, debt);
                string result = "Accepted";
                if (diagonal) result = Assert.ThrowsExactly<ArgumentException>(state.Validate).Message;
                else state.Validate();
                Equal(diagonal ? "Debt requires distinct people." : "Accepted", result);
                Dec0015ProbeEvidence.Add(new
                {
                    Probe = "DebtValidator",
                    WrittenDebt = debt,
                    WrittenAttitude = state.Attitudes[new(6)],
                    Actual = result,
                    LiveSimulationWrite = false
                });
            }
        }, "Public proposals and empty-cycle controls; detached WorldState Debt insertion recorded separately");

        yield return new("Dec0015FavourDiagonal", ["S1-107-FAVOUR-DIAGONAL"], () =>
        {
            foreach (ActionTerms term in new ActionTerms[] { new OfferBenefitForFavor(new(1), 1),
                new RelationshipMediatedReciprocalHelp(new(1), 1), new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true) })
            {
                InitialWorld initial = Dec0015World(75);
                Simulation sim = Create(initial);
                Simulation baseline = Create(initial);
                CycleResult result = sim.RunCycle(new([P(1, 1, term)]));
                Dec0015Oracle.InvalidInteraction(sim, result, new(1));
                Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                result = sim.RunCycle(new([P(2, 1, new CallFavor(new(99), new Farm()))]));
                Equal("UnknownFavour", result.Outcomes.Single().Reason);
                Dec0015Oracle.InvalidInteraction(sim, result, new(2));
                Dec0015Oracle.SameMaterialAndAttitudes(baseline.RunCycle(CycleInput.Empty).State, result.State);
                Dec0015Oracle.NoClaimsOrConsequences(sim);
            }
            foreach (bool outstanding in new[] { false, true })
                foreach (bool diagonal in new[] { false, true })
                {
                    WorldState state = new(Dec0015World(10));
                    RelationId id = state.AllocateRelation();
                    Favour favour = new(id, new(diagonal ? 1 : 2), new(1), outstanding, new(902));
                    state.Favours.Add(id, favour);
                    string result = "Accepted";
                    if (diagonal) result = Assert.ThrowsExactly<ArgumentException>(state.Validate).Message;
                    else state.Validate();
                    Equal(diagonal ? "Favour requires distinct people." : "Accepted", result);
                    Dec0015ProbeEvidence.Add(new
                    {
                        Probe = "FavourValidator",
                        WrittenFavour = favour,
                        WrittenAttitude = state.Attitudes[new(6)],
                        Actual = result,
                        LiveSimulationWrite = false
                    });
                }
        }, "Public proposals and empty-cycle controls; detached WorldState Favour insertion recorded separately");

        yield return new("Dec0015ValidAliasControls", ["S1-107-VALID-ALIAS-CONTROLS"], () =>
        {
            Simulation sim = Create(World(40, 40, 40));
            sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
            sim.RunCycle(new([P(2, 1, new OfferLoan(new(2), 1))]));
            Favour favour = sim.Snapshot.Favours.Values.Single();
            Debt debt = sim.Snapshot.Debts.Values.Single();
            Equal(favour.Holder, debt.Creditor); Equal(favour.Debtor, debt.Debtor);
            long a = sim.Snapshot.People[new(1)].Grain, b = sim.Snapshot.People[new(2)].Grain;
            CycleResult result = sim.RunCycle(new([P(3, 1, new CallFavor(favour.Id, new RepayDebt(debt.Id, 1)))]));
            Equal(OutcomeKind.Committed, result.Outcomes.Single().Kind);
            Equal(a, Grain(result, 1)); Equal(b - 2, Grain(result, 2)); // consumption, then one-grain repayment
            True(!result.State.Favours[favour.Id].Outstanding);
            Equal(0L, result.State.Debts[debt.Id].Remaining);
            Equal(1, result.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Response"));
            Equal(15, result.State.AttitudeOf(new(1), new(2)));
            SemanticEvent repayment = result.Events.Single(e => e.Kind == "Repayment");
            SemanticEvent fulfilment = result.Events.Single(e => e.Kind == "CalledFavourFulfilled");
            True(fulfilment.Causes.Contains(repayment.Id) && fulfilment.Causes.Contains(favour.Origin));
            SemanticEvent composition = result.Events.Single(e => e.Kind == "AttitudeComposition");
            CollectionAssert.AreEquivalent(new[] { 5, 10 }, composition.Contributions.Select(c => c.Delta).ToArray());
            True(composition.Contributions.Any(c => c.Key.Trigger == repayment.Id && c.Delta == 5));
            True(composition.Contributions.Any(c => c.Key.Trigger == fulfilment.Id && c.Delta == 10));
        });

        string[] aliases = ["PersonalResidenceAndIncomingResponse", "SharedSnapshotScarceGrain", "DirectAttitudeCompositionAndPermutation"];
        foreach (string name in aliases)
        {
            Scenario inherited = All().Single(s => s.Name == name);
            yield return inherited with { Name = "Dec0015Inherited" + name, Ids = ["S1-107-VALID-ALIAS-CONTROLS"] };
        }

        yield return new("Dec0015GenericRelationSeam", ["S1-107-GENERIC-RELATION-SEAM"], () =>
        {
            Simulation control = Create(Dec0015World(12));
            Equal(12, control.Snapshot.AttitudeOf(new(1), new(1)));
            foreach (KinshipKind kind in new[] { KinshipKind.ParentChild, KinshipKind.Sibling })
            {
                InitialWorld invalid = Dec0015World() with { Kinships = [new(new(7), new(1), new(1), kind)] };
                Equal("Kinship requires distinct people.", Assert.ThrowsExactly<ArgumentException>(() => new Simulation(invalid)).Message);
                Create(Dec0015World() with { Kinships = [new(new(7), new(1), new(2), kind)] });
            }
            Equal("Marriage requires distinct people.", Assert.ThrowsExactly<ArgumentException>(() =>
                new Simulation(Dec0015World() with { Marriages = [new(new(7), new(1), new(1))] })).Message);
            Create(Dec0015World() with { Marriages = [new(new(7), new(1), new(2))] });
            Equal(typeof(PersonId), typeof(Residence).GetProperty(nameof(Residence.Person))!.PropertyType);
            Equal(typeof(DwellingId), typeof(Residence).GetProperty(nameof(Residence.Dwelling))!.PropertyType);
            Equal(1L, control.Snapshot.Residences[new(1)].Person.Value);
            Equal(1L, control.Snapshot.Residences[new(1)].Dwelling.Value);
            foreach (ActionTerms term in new ActionTerms[] { new MoveResidence(new(1), new(2)), new InviteResidence(new(1), new(1)) })
            {
                Simulation residence = Create(Dec0015World());
                Dec0015Oracle.InvalidInteraction(residence, residence.RunCycle(new([P(1, 1, term)])), new(1));
            }
            foreach (string relation in new[] { "Attitude", "Kinship", "Marriage", "Debt", "Favour" })
                foreach (bool firstMissing in new[] { false, true })
                {
                    WorldState detached = new(Dec0015World());
                    PersonId first = new(firstMissing ? 99 : 1), second = new(firstMissing ? 2 : 99);
                    RelationId id = detached.AllocateRelation();
                    switch (relation)
                    {
                        case "Attitude": detached.Attitudes.Add(id, new(id, first, second, 0)); break;
                        case "Kinship": detached.Kinships.Add(id, new(id, first, second, KinshipKind.Sibling)); break;
                        case "Marriage": detached.Marriages.Add(id, new(id, first, second)); break;
                        case "Debt": detached.Debts.Add(id, new(id, first, second, 1, 1, 0, false, new(903))); break;
                        case "Favour": detached.Favours.Add(id, new(id, first, second, true, new(904))); break;
                    }
                    Equal("Unresolved relation participants.", Assert.ThrowsExactly<ArgumentException>(detached.Validate).Message);
                    Dec0015ProbeEvidence.Add(new
                    {
                        Probe = "EndpointExistence",
                        Relation = relation,
                        Id = id,
                        First = first,
                        Second = second,
                        LiveSimulationWrite = false,
                        OtherFields = "Attitude=0; Kinship=Sibling; Debt=1 original/remaining, cycle=0, unreviewed, origin=903; Favour=outstanding, origin=904"
                    });
                }
            InitialWorld duplicate = Dec0015World() with { Attitudes = [.. Dec0015World().Attitudes, new(new(7), new(1), new(1), 0)] };
            Equal("Duplicate directed attitude.", Assert.ThrowsExactly<ArgumentException>(() => new Simulation(duplicate)).Message);

            string source = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim/State.cs"));
            True(source.Contains("CheckPeopleExist(attitude.From, attitude.To);", StringComparison.Ordinal));
            True(!source.Contains("CheckPair(", StringComparison.Ordinal));
            foreach (string owner in new[] { "Kinship", "Marriage", "Debt", "Favour" })
                True(source.Contains(owner + " requires distinct people.", StringComparison.Ordinal));
            int start = source.IndexOf("private void CheckPeopleExist", StringComparison.Ordinal);
            True(start >= 0);
            True(!source[start..].Contains("a == b", StringComparison.Ordinal));
            True(!source[start..].Contains("a != b", StringComparison.Ordinal));
            // The executable positive/negative controls and unchanged inherited exact
            // authority inventory complement this bounded helper source audit.
            Dec0015Oracle.InvalidInteraction(control, control.RunCycle(new([P(1, 1, new OfferGift(new(1), 1))])), new(1));
        }, "Initial relation boundary controls and explicitly recorded detached endpoint-resolution probes");
    }
}
