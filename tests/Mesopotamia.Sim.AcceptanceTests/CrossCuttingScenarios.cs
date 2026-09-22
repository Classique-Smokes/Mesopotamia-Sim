using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    internal List<object> FaultEvidence { get; } = [];
    private IEnumerable<Scenario> CrossCuttingCases()
    {
        yield return new("DirectAttitudeCompositionAndPermutation", ["S1-097-SAT", "S1-097-DIRECT-BATCH-POS", "S1-097-DIRECT-BATCH-NEG", "S1-074-DIRECT-BATCH", "S1-BND-ATT-SAT", "S1-BND-ATT-MIXED", "S1-META-10", "S1-MUT-31"], () =>
        {
            foreach (int baseline in new[] { -95, 95 })
            {
                string? expectedHistory = null;
                foreach (Simulation.ReactionChallenge order in new[] { Simulation.ReactionChallenge.None, Simulation.ReactionChallenge.ReverseCauses })
                {
                    Simulation sim = Create(World(30, 30, 30, baseline), order);
                    sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
                    Favour favour = sim.Snapshot.Favours.Values.Single();
                    CycleResult result = sim.RunCycle(new([P(2, 1, new CallFavor(favour.Id, new Farm())), P(3, 2, new OfferGift(new(1), 1))])
                    { ProposalResponseProfiles = ImmutableDictionary<ProposalId, string>.Empty.Add(new(2), "SCORE-RP-004") });
                    Equal(baseline == 95 ? 85 : -100, result.State.AttitudeOf(new(1), new(2)));
                    SemanticEvent composition = result.Events.Single(e => e.Kind == "AttitudeComposition");
                    Equal(2, composition.Contributions.Length);
                    True(composition.Contributions.Select(c => c.Delta).Order().SequenceEqual(new[] { -20, 10 }));
                    string history = Canonical(sim);
                    if (expectedHistory is null) expectedHistory = history;
                    else Equal(expectedHistory, history);
                    // Deliberately corrupt only the witness, retaining the independently recorded causes.
                    Attitude attitude = result.State.Attitudes.Values.Single(a => a.From == new PersonId(1) && a.To == new PersonId(2));
                    int wrongSequential = baseline == 95 ? 80 : -90;
                    WorldSnapshot corrupted = result.State with { Attitudes = result.State.Attitudes.SetItem(attitude.Id, attitude with { Value = wrongSequential }) };
                    Assert.ThrowsExactly<AssertFailedException>(() => InvariantOracle.Verify(World(30, 30, 30, baseline), corrupted, sim.History, sim.DecisionHistory));
                }
            }
            Simulation saturated = Create(World(ab: 95));
            Equal(100, saturated.RunCycle(new([P(1, 2, new OfferGift(new(1), 1))])).State.AttitudeOf(new(1), new(2)));
            Simulation negative = WithFavour(ab: -95);
            Equal(-100, negative.RunCycle(new([P(2, 1, new CallFavor(negative.Snapshot.Favours.Values.Single().Id, new Farm()))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-004") }).State.AttitudeOf(new(1), new(2)));
            FaultEvidence.Add(new { Id = "S1-MUT-31", Route = "Corrupted result witness plus signed-cause permutation", Outcome = "detected", Detector = "Independent sum-then-clamp replay", Positive = 85, Negative = -100 });
        });
        yield return new("DuplicateReactionAndPrematureClosure", ["S1-074-IDEMP", "S1-MUT-22", "S1-MUT-23"], () =>
        {
            Simulation duplicate = Create(World(), Simulation.ReactionChallenge.DuplicateCauses);
            CycleResult result = duplicate.RunCycle(new([P(1, 1, new OfferGift(new(2), 1))]));
            Equal(10, result.State.AttitudeOf(new(2), new(1)));
            Equal(1, result.Events.Single(e => e.Kind == "AttitudeComposition").Contributions.Length);
            Equal("Duplicates:1", result.Events.Single(e => e.Kind == "DuplicateReactionRejected").Detail);
            Simulation truncated = Create(World(), Simulation.ReactionChallenge.SkipClosure);
            InvalidOperationException failure = Assert.ThrowsExactly<InvalidOperationException>(() => truncated.RunCycle(new([P(1, 1, new OfferGift(new(2), 1))])));
            Equal("PendingAutomaticReactions", failure.Message);
            Equal(0L, truncated.Snapshot.Cycle);
            Equal(8L, truncated.Snapshot.People[new(1)].Grain);
            True(truncated.IsFaulted);
            Equal("A failed cycle cannot be resumed.", Assert.ThrowsExactly<InvalidOperationException>(() => truncated.RunCycle(CycleInput.Empty)).Message);
            FaultEvidence.Add(new { Id = "S1-MUT-22", Route = "Actual duplicate injection at automatic closure", Outcome = "detected", Detector = "One cause, one contribution; duplicate diagnostic" });
            FaultEvidence.Add(new { Id = "S1-MUT-23", Route = "Actual closure suppression", Outcome = "detected", Detector = "Specific PendingAutomaticReactions guard; no stable publication or resumption", CrashCredited = false });
        });
        yield return new("MaterialDeadlockAndNegativeControls", ["S1-080"], () =>
        {
            Simulation stuck = Create(World(0, 0, 0));
            CycleResult result = stuck.RunCycle(new([P(1, 1, new Farm())]));
            True(result.MaterialDeadlock);
            True(result.State.People.Values.All(p => p.NeedsGrain && p.Grain == 0));
            Equal(OutcomeKind.Unable, result.Outcomes.Single().Kind);
            True(result.Events.All(e => e.Kind != "Farm" && e.Material.IsEmpty));
            Simulation transfer = Create(World(0, 2, 0));
            CycleResult rescued = transfer.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))]));
            True(!rescued.MaterialDeadlock);
            Equal(1L, Grain(rescued, 1));
            Simulation future = Create(World(0, 0, 0) with { Inputs = [new(1, 2, new(1), 2)] });
            True(!future.RunCycle(CycleInput.Empty).MaterialDeadlock);
            Equal(0L, future.Snapshot.People[new(1)].Grain);
            Equal(1L, Grain(future.RunCycle(CycleInput.Empty), 1));
        });
        yield return new("StableFallbackSensitivityAndSemanticAsymmetry", ["S1-081", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool renamed in new[] { false, true })
            {
                CycleResult result = Create(World()).RunCycle(new([P(renamed ? 20 : 10, 1, new InviteResidence(new(2), new(1))), P(renamed ? 10 : 20, 3, new InviteResidence(new(2), new(3)))]));
                Equal(new DwellingId(renamed ? 3 : 1), result.State.HomeOf(new(2)));
                Equal(1, result.Events.Count(e => e.Kind == "ResidenceTransition"));
                Equal("CompetingResidenceTransition", result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Reason);
                Equal(2, result.Events.Count(e => e.TechnicalFallback));
            }
            // Domain feasibility removes the competing invitation before resolution.
            InitialWorld asymmetry = World() with { Residences = [new(new(1), new(1), new(1)), new(new(2), new(2), new(1)), new(new(3), new(3), new(3))] };
            CycleResult distinguished = Create(asymmetry).RunCycle(new([P(10, 1, new InviteResidence(new(2), new(1))), P(20, 3, new InviteResidence(new(2), new(3)))]));
            Equal(new DwellingId(3), distinguished.State.HomeOf(new(2)));
            True(distinguished.Events.All(e => !e.TechnicalFallback));
            Equal(OutcomeKind.Unable, distinguished.Outcomes.Single(o => o.Proposal.Value == 10).Kind);
        });
        yield return new("ReplayStorageInputObserverAndAttributePairs", ["S1-META-01", "S1-META-04", "S1-META-07", "S1-085", "S1-MUT-26", "S1-GLOBAL-ITERATION"], () =>
        {
            string? expected = null;
            foreach (int variant in Enumerable.Range(0, 5))
            {
                InitialWorld initial = World(30, 30, 30, 75, 75) with { Inputs = [new(1, 3, new(1), 2), new(2, 3, new(2), 3)] };
                if (variant == 1) initial = initial with { People = [.. initial.People.Reverse()], Dwellings = [.. initial.Dwellings.Reverse()], Residences = [.. initial.Residences.Reverse()], Attitudes = [.. initial.Attitudes.Reverse()], Inputs = [.. initial.Inputs.Reverse()] };
                if (variant == 3) initial = initial with { People = [.. initial.People.Select(p => p with { Name = "Unrelated display text" })] };
                Simulation sim = Create(initial);
                CultureInfo saved = CultureInfo.CurrentCulture;
                try
                {
                    if (variant == 4) CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
                    for (int cycle = 1; cycle <= 6; cycle++)
                    {
                        Proposal[] proposals = [P(cycle * 10, 1, cycle == 1 ? new OfferLoan(new(2), 2) : new OfferGift(new(2), 1)), P(cycle * 10 + 1, 3, new Farm())];
                        if (variant == 2)
                        {
                            _ = Canonical(sim);
                            foreach (PersonId person in sim.Snapshot.People.Keys.Reverse()) { _ = sim.KnowledgeOf(person); _ = sim.Snapshot.HomeOf(person); }
                            _ = sim.DecisionHistory.ToArray();
                        }
                        sim.RunCycle(new([.. variant == 1 ? proposals.Reverse() : proposals]));
                    }
                }
                finally { CultureInfo.CurrentCulture = saved; }
                string actual = Canonical(sim);
                if (expected is null) expected = actual; else Equal(expected, actual);
            }
            FaultEvidence.Add(new { Id = "S1-MUT-26", Route = "Focused enabled/disabled reader pair, including reversed inspection order", Outcome = "detected", Detector = "Exact state/history/decisions/knowledge equality", MutationExecution = "unexercised; focused negative route" });
        });
        yield return new("IdentityIsomorphismAndDisconnectedLocality", ["S1-META-02", "S1-META-03"], () =>
        {
            string? expected = null;
            foreach (int variant in Enumerable.Range(0, 3))
            {
                PersonId Map(PersonId id) => variant == 1 ? new(id.Value switch { 1 => 33, 2 => 11, _ => 22 }) : id;
                InitialWorld initial = World() with { Attitudes = [] };
                initial = initial with { People = [.. initial.People.Select(p => p with { Id = Map(p.Id) })], Residences = [.. initial.Residences.Select(r => r with { Person = Map(r.Person) })] };
                if (variant == 2) initial = initial with { People = [.. initial.People, new(new(4), "Disconnected", Sex.Female, 40)], Dwellings = [.. initial.Dwellings, new(new(4))], Residences = [.. initial.Residences, new(new(9), new(4), new(4))] };
                Simulation sim = Create(initial);
                for (int cycle = 1; cycle <= 3; cycle++) sim.RunCycle(new([P(cycle, Map(new(1)).Value, new OfferGift(Map(new(2)), 1))]));
                string Name(PersonId id) => sim.Snapshot.People[id].Name;
                string projection = JsonSerializer.Serialize(new
                {
                    People = sim.Snapshot.People.Values.Where(p => p.Name != "Disconnected").OrderBy(p => p.Name, StringComparer.Ordinal).Select(p => new { p.Name, p.Grain, p.NeedsGrain, Home = sim.Snapshot.HomeOf(p.Id).Value }),
                    Attitudes = sim.Snapshot.Attitudes.Values.Select(a => new { From = Name(a.From), To = Name(a.To), a.Value }).OrderBy(a => a.From, StringComparer.Ordinal),
                    Events = sim.History.Where(e => e.Proposal is not null || e.Kind == "AttitudeComposition").Select(e => new { e.Cycle, e.Kind, Participants = e.Participants.Select(Name), Material = e.Material.Select(m => new { Person = Name(m.Person), m.Before, m.After, m.Meaning }), Deltas = e.Contributions.Select(c => c.Delta), e.TechnicalFallback }),
                    Knowledge = new[] { sim.KnowledgeOf(Map(new(1))).Select(k => new { k.Kind, k.Reason }), sim.KnowledgeOf(Map(new(2))).Select(k => new { k.Kind, k.Reason }) }
                });
                True(sim.History.All(e => !e.TechnicalFallback));
                if (expected is null) expected = projection; else Equal(expected, projection);
            }
        });
        yield return new("NoDerivedAuthorityStructuralAudit", ["S1-084", "S1-META-05", "S1-MUT-24"], () =>
        {
            string[] worldFields = typeof(WorldState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order(StringComparer.Ordinal).ToArray();
            string[] expectedFields = new[] { "<People>k__BackingField", "<Dwellings>k__BackingField", "<Residences>k__BackingField", "<Attitudes>k__BackingField", "<Kinships>k__BackingField", "<Marriages>k__BackingField", "<Debts>k__BackingField", "<Favours>k__BackingField", "nextRelation" }.Order(StringComparer.Ordinal).ToArray();
            True(worldFields.SequenceEqual(expectedFields));
            True(typeof(WorldSnapshot).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).All(f => f.IsInitOnly));
            Simulation sim = Create(World());
            WorldSnapshot prior = sim.Snapshot;
            sim.RunCycle(new([P(1, 1, new OfferGift(new(2), 1))]));
            Equal(0, prior.AttitudeOf(new(2), new(1)));
            Equal(10, sim.Snapshot.AttitudeOf(new(2), new(1)));
            Equal(8L, prior.People[new(1)].Grain);
            FaultEvidence.Add(new { Id = "S1-MUT-24", Route = "Structural alternative authorized by frozen manifest", Outcome = "invalid/equivalent", Detector = "No behavior-affecting derived cache exists; authoritative dictionary inventory and immutable snapshot isolation", StaleCacheInjection = "not applicable" });
        });
        yield return new("DistinctTransferMeanings", ["S1-091-MEANING-SEPARATION"], () =>
        {
            ActionTerms[] terms = [new OfferGift(new(2), 1), new OfferLoan(new(2), 1), new OfferBenefitForFavor(new(2), 1), new RelationshipMediatedReciprocalHelp(new(2), 1)];
            string[] meanings = ["Gift", "Loan", "ExplicitBenefitForFavor", "RelationshipMediatedReciprocalHelp"];
            int[] deltas = [10, 5, 0, 10];
            for (int i = 0; i < terms.Length; i++)
            {
                CycleResult result = Create(World(8, 8, 8, 0, 75)).RunCycle(new([P(1, 1, terms[i])]));
                SemanticEvent transfer = result.Events.Single(e => e.Material.Length == 2);
                Equal(meanings[i], transfer.Kind);
                True(transfer.Material.All(m => m.Meaning == meanings[i]));
                Equal(6L, Grain(result, 1)); Equal(8L, Grain(result, 2));
                Equal(75 + deltas[i], result.State.AttitudeOf(new(2), new(1)));
                Equal(i == 1 ? 1 : 0, result.State.Debts.Count);
                Equal(i >= 2 ? 1 : 0, result.State.Favours.Count);
            }
        });
    }

    private static string Canonical(Simulation sim) => JsonSerializer.Serialize(new
    {
        sim.Snapshot.Cycle,
        People = sim.Snapshot.People.Values.OrderBy(p => p.Id.Value).Select(p => new { p.Id, p.Sex, p.Grain, p.NeedsGrain }),
        Residences = sim.Snapshot.Residences.Values.OrderBy(r => r.Id.Value),
        Attitudes = sim.Snapshot.Attitudes.Values.OrderBy(a => a.Id.Value),
        Debts = sim.Snapshot.Debts.Values.OrderBy(d => d.Id.Value),
        Favours = sim.Snapshot.Favours.Values.OrderBy(f => f.Id.Value),
        Marriages = sim.Snapshot.Marriages.Values.OrderBy(m => m.Id.Value),
        History = sim.History,
        Decisions = sim.DecisionHistory,
        Knowledge = sim.Snapshot.People.Keys.OrderBy(p => p.Value).Select(sim.KnowledgeOf)
    });
}
