using System.Collections.Immutable;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private static InitialWorld Dec0015World(int selfAttitude = 0, int outbound = 0, int inbound = 0)
    {
        InitialWorld world = World(30, 30, 30, outbound, inbound);
        return world with
        {
            Attitudes =
            [
                new(new(4), new(1), new(2), outbound),
                new(new(5), new(2), new(1), inbound),
                new(new(6), new(1), new(1), selfAttitude)
            ]
        };
    }

    private IEnumerable<Scenario> Dec0015Cases()
    {
        yield return new("Dec0015SelfCounterpartyBoundary", ["S1-107-SELF-COUNTERPARTY"], () =>
        {
            ActionTerms[] directTerms =
            [
                new OfferGift(new(1), 1),
                new RequestGiftOrHelp(new(1), 1),
                new OfferLoan(new(1), 1),
                new RequestLoan(new(1), 1),
                new OfferBenefitForFavor(new(1), 1),
                new RelationshipMediatedReciprocalHelp(new(1), 1),
                new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true)
            ];

            foreach (ActionTerms terms in directTerms)
            {
                InitialWorld initial = Dec0015World(25);
                CycleResult baseline = Create(initial).RunCycle(CycleInput.Empty);
                Simulation sim = Create(initial);
                CycleResult result = sim.RunCycle(new([P(1, 1, terms)]));
                Outcome outcome = result.Outcomes.Single();

                Equal(OutcomeKind.InvalidTerms, outcome.Kind);
                Equal("InvalidCounterparty", outcome.Reason);
                Equal(0, result.Decisions.Length);
                Equal(0, result.State.Debts.Count);
                Equal(0, result.State.Favours.Count);
                Equal(25, result.State.AttitudeOf(new(1), new(1)));
                Equal(0, sim.KnowledgeOf(new(1)).Length);
                foreach (PersonId person in result.State.People.Keys)
                    Equal(baseline.State.People[person].Grain, result.State.People[person].Grain);

                SemanticEvent[] proposalEvents = result.Events.Where(e => e.Proposal == new ProposalId(1)).ToArray();
                Equal(2, proposalEvents.Length);
                True(proposalEvents.Select(e => e.Kind).SequenceEqual(new[] { "Proposal", "InvalidTerms" }));
                True(proposalEvents.All(e => e.Material.IsEmpty));
                True(result.Events.All(e => e.Kind is not ("Response" or "Declined" or "Unable" or "InvalidatedAtResolution" or "AttitudeComposition")));
            }

            // A diagonal Favour cannot be valid current state, so isolate CallFavor's
            // D1 participant-alias rule at the public action validator boundary.
            Simulation callControl = Create(Dec0015World(25));
            RelationId favourId = new(99);
            WorldSnapshot selfCallSnapshot = callControl.Snapshot with
            {
                Favours = callControl.Snapshot.Favours.Add(
                    favourId, new(favourId, new(1), new(1), true, new(900)))
            };
            Proposal selfCall = P(99, 1, new CallFavor(favourId, new Farm()));
            Equal(new PersonId(1), ActionRules.Target(selfCall.Terms, selfCallSnapshot));
            Equal("InvalidCounterparty", ActionRules.Invalid(selfCall, selfCallSnapshot));
            Equal(0, callControl.Snapshot.Favours.Count);
            Equal(0, callControl.History.Length);
            Equal(0, callControl.DecisionHistory.Length);
            Equal(0, callControl.KnowledgeOf(new(1)).Length);
        });

        yield return new("Dec0015AttitudeDiagonal", ["S1-107-ATTITUDE-DIAGONAL"], () =>
        {
            Simulation upper = Create(Dec0015World(100));
            Equal(100, upper.Snapshot.AttitudeOf(new(1), new(1)));
            Simulation lower = Create(Dec0015World(-100));
            Equal(-100, lower.Snapshot.AttitudeOf(new(1), new(1)));

            ArgumentException high = Assert.ThrowsExactly<ArgumentException>(() => new Simulation(Dec0015World(101)));
            Equal("Attitude outside bounds.", high.Message);
            ArgumentException low = Assert.ThrowsExactly<ArgumentException>(() => new Simulation(Dec0015World(-101)));
            Equal("Attitude outside bounds.", low.Message);

            Simulation positive = Create(Dec0015World(5, 9, -8));
            for (int cycle = 1; cycle <= 4; cycle++)
            {
                positive.RunCycle(CycleInput.Empty);
                Equal(5, positive.Snapshot.AttitudeOf(new(1), new(1)));
            }
            positive.RunCycle(CycleInput.Empty);
            Equal(3, positive.Snapshot.AttitudeOf(new(1), new(1)));
            Equal(7, positive.Snapshot.AttitudeOf(new(1), new(2)));
            Equal(-7, positive.Snapshot.AttitudeOf(new(2), new(1)));
            SemanticEvent selfDecay = positive.History.Single(e =>
                e.Kind == "AttitudeDecay" && e.Participants.SequenceEqual(new[] { new PersonId(1), new PersonId(1) }));
            Equal("5->3", selfDecay.Detail);

            Simulation negative = Create(Dec0015World(-5));
            for (int cycle = 1; cycle <= 5; cycle++) negative.RunCycle(CycleInput.Empty);
            Equal(-4, negative.Snapshot.AttitudeOf(new(1), new(1)));

            Simulation actionControl = Create(Dec0015World(25));
            CycleResult invalid = actionControl.RunCycle(new([P(1, 1, new OfferGift(new(1), 1))]));
            Equal(OutcomeKind.InvalidTerms, invalid.Outcomes.Single().Kind);
            Equal(25, invalid.State.AttitudeOf(new(1), new(1)));

            FaultEvidence.Add(new
            {
                Id = "S1-107-GENERIC-RELATION-SEAM",
                Route = "Critical universal-endpoint-inequality mutant against valid Attitude(P,P)",
                Outcome = "detected",
                Detector = "Simulation construction and ordinary decay must accept the diagonal Attitude fixture"
            });
        });

        yield return new("Dec0015DebtDiagonal", ["S1-107-DEBT-DIAGONAL"], () =>
        {
            Simulation ingress = Create(Dec0015World(20));
            CycleResult rejected = ingress.RunCycle(new([P(1, 1, new OfferLoan(new(1), 1))]));
            Equal(OutcomeKind.InvalidTerms, rejected.Outcomes.Single().Kind);
            Equal("InvalidCounterparty", rejected.Outcomes.Single().Reason);
            Equal(0, rejected.Decisions.Length);
            Equal(0, rejected.State.Debts.Count);
            Equal(0, ingress.KnowledgeOf(new(1)).Length);
            True(rejected.Events.Where(e => e.Proposal == new ProposalId(1)).All(e => e.Material.IsEmpty));
            for (int cycle = 0; cycle < 3; cycle++) ingress.RunCycle(CycleInput.Empty);
            Equal(0, ingress.Snapshot.Debts.Count);
            True(ingress.History.All(e => e.Kind is not ("Repayment" or "DebtSocialDueReview")));

            WorldState diagonal = new(Dec0015World(10));
            RelationId diagonalId = diagonal.AllocateRelation();
            diagonal.Debts.Add(diagonalId, new(
                diagonalId, new(1), new(1), 1, 1, 0, false, new(901)));
            ArgumentException diagonalFailure = Assert.ThrowsExactly<ArgumentException>(diagonal.Validate);
            Equal("Debt requires distinct people.", diagonalFailure.Message);

            WorldState ordinary = new(Dec0015World(10));
            RelationId ordinaryId = ordinary.AllocateRelation();
            ordinary.Debts.Add(ordinaryId, new(
                ordinaryId, new(1), new(2), 1, 1, 0, false, new(902)));
            ordinary.Validate();
        });

        yield return new("Dec0015FavourDiagonal", ["S1-107-FAVOUR-DIAGONAL"], () =>
        {
            Simulation ingress = Create(Dec0015World(20));
            CycleResult rejected = ingress.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(1), 1))]));
            Equal(OutcomeKind.InvalidTerms, rejected.Outcomes.Single().Kind);
            Equal("InvalidCounterparty", rejected.Outcomes.Single().Reason);
            Equal(0, rejected.Decisions.Length);
            Equal(0, rejected.State.Favours.Count);
            Equal(0, ingress.KnowledgeOf(new(1)).Length);
            True(rejected.Events.Where(e => e.Proposal == new ProposalId(1)).All(e => e.Material.IsEmpty));
            True(rejected.Events.All(e => e.Kind is not ("CalledFavourFulfilled" or "Declined" or "AttitudeComposition")));

            WorldState diagonal = new(Dec0015World(10));
            RelationId diagonalId = diagonal.AllocateRelation();
            diagonal.Favours.Add(diagonalId, new(
                diagonalId, new(1), new(1), true, new(903)));
            ArgumentException diagonalFailure = Assert.ThrowsExactly<ArgumentException>(diagonal.Validate);
            Equal("Favour requires distinct people.", diagonalFailure.Message);

            WorldState ordinary = new(Dec0015World(10));
            RelationId ordinaryId = ordinary.AllocateRelation();
            ordinary.Favours.Add(ordinaryId, new(
                ordinaryId, new(2), new(1), true, new(904)));
            ordinary.Validate();
        });

        yield return new("Dec0015ValidAliasControls", ["S1-107-VALID-ALIAS-CONTROLS"], () =>
        {
            InitialWorld personalWorld = World(0, 6, 8) with
            {
                Marriages = [new(new(6), new(3), new(2))]
            };
            Simulation personal = Create(personalWorld);
            CycleResult personalAndResponse = personal.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
            {
                PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(
                    new(2), new("SCORE-VP-006")
                    {
                        ObservedResidences = ImmutableDictionary<PersonId, DwellingId>.Empty.Add(new(3), new(3))
                    })
            });
            Equal(1, personalAndResponse.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Personal"));
            Equal(1, personalAndResponse.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Response"));
            Equal(2, personalAndResponse.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));

            Simulation shared = Create(World(0, 2, 0));
            CycleResult sharedResponses = shared.RunCycle(new(
            [
                P(10, 1, new RequestGiftOrHelp(new(2), 1)),
                P(20, 3, new RequestGiftOrHelp(new(2), 1))
            ]));
            Equal(2, sharedResponses.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Response"));
            True(sharedResponses.Decisions.All(d => d.Candidates.Single(c => c.Selected).Meaning == "Accept"));
            Equal(1, sharedResponses.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
            Equal(1, sharedResponses.Outcomes.Count(o => o.Kind == OutcomeKind.InvalidatedAtResolution));

            // Holder 1 is also the inner Debt creditor. The valid two-party call
            // therefore collapses compatible outer/inner capacities without creating
            // self-negotiation. Repayment (+5) and fulfilment (+10) converge on 1->2.
            Simulation alias = Create(World(40, 40, 40));
            alias.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
            alias.RunCycle(new([P(2, 1, new OfferLoan(new(2), 1))]));
            Favour favour = alias.Snapshot.Favours.Values.Single();
            Debt debt = alias.Snapshot.Debts.Values.Single();
            Equal(favour.Holder, debt.Creditor);
            Equal(favour.Debtor, debt.Debtor);

            CycleResult called = alias.RunCycle(new(
            [
                P(3, 1, new CallFavor(favour.Id, new RepayDebt(debt.Id, 1)))
            ]));
            Equal(OutcomeKind.Committed, called.Outcomes.Single().Kind);
            True(!called.State.Favours[favour.Id].Outstanding);
            Equal(0L, called.State.Debts[debt.Id].Remaining);
            Equal(1, called.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Response"));
            Equal(15, called.State.AttitudeOf(new(1), new(2)));
            SemanticEvent composition = called.Events.Single(e =>
                e.Kind == "AttitudeComposition" &&
                e.Participants.SequenceEqual(new[] { new PersonId(1), new PersonId(2) }));
            Equal(2, composition.Contributions.Length);
            True(composition.Contributions.Select(c => c.Delta).Order().SequenceEqual(new[] { 5, 10 }));
        });

        yield return new("Dec0015GenericRelationSeam", ["S1-107-GENERIC-RELATION-SEAM"], () =>
        {
            Simulation diagonalAttitude = Create(Dec0015World(12));
            Equal(12, diagonalAttitude.Snapshot.AttitudeOf(new(1), new(1)));

            InitialWorld kinship = Dec0015World() with
            {
                Kinships = [new(new(7), new(1), new(1), KinshipKind.Sibling)]
            };
            ArgumentException kinshipFailure = Assert.ThrowsExactly<ArgumentException>(() => new Simulation(kinship));
            Equal("Kinship requires distinct people.", kinshipFailure.Message);

            InitialWorld marriage = Dec0015World() with
            {
                Marriages = [new(new(7), new(1), new(1))]
            };
            ArgumentException marriageFailure = Assert.ThrowsExactly<ArgumentException>(() => new Simulation(marriage));
            Equal("Marriage requires distinct people.", marriageFailure.Message);

            InitialWorld unresolved = Dec0015World() with
            {
                Attitudes =
                [
                    .. Dec0015World().Attitudes,
                    new(new(7), new(1), new(99), 0)
                ]
            };
            ArgumentException unresolvedFailure = Assert.ThrowsExactly<ArgumentException>(() => new Simulation(unresolved));
            Equal("Unresolved relation participants.", unresolvedFailure.Message);

            string source = File.ReadAllText(Path.Combine(
                AcceptanceCatalog.Root, "src/Mesopotamia.Sim/State.cs"));
            True(source.Contains("CheckPeopleExist(attitude.From, attitude.To);", StringComparison.Ordinal));
            True(!source.Contains("CheckPair(", StringComparison.Ordinal));
            True(source.Contains("Kinship requires distinct people.", StringComparison.Ordinal));
            True(source.Contains("Marriage requires distinct people.", StringComparison.Ordinal));
            True(source.Contains("Debt requires distinct people.", StringComparison.Ordinal));
            True(source.Contains("Favour requires distinct people.", StringComparison.Ordinal));
            True(!source.Contains("DiagonalPolicy", StringComparison.Ordinal));
            True(!source.Contains("RelationTypeRegistry", StringComparison.Ordinal));

            int helperStart = source.IndexOf("private void CheckPeopleExist", StringComparison.Ordinal);
            True(helperStart >= 0);
            string helper = source[helperStart..];
            True(!helper.Contains("a == b", StringComparison.Ordinal));
            True(!helper.Contains("a != b", StringComparison.Ordinal));

            CycleResult invalidAction = diagonalAttitude.RunCycle(new(
            [
                P(1, 1, new OfferGift(new(1), 1))
            ]));
            Equal(OutcomeKind.InvalidTerms, invalidAction.Outcomes.Single().Kind);
            Equal("InvalidCounterparty", invalidAction.Outcomes.Single().Reason);
            Equal(12, invalidAction.State.AttitudeOf(new(1), new(1)));

            bool universalDistinctEndpointMutantWouldAccept = diagonalAttitude.Snapshot.Attitudes.Values
                .All(a => a.From != a.To);
            True(!universalDistinctEndpointMutantWouldAccept);
            FaultEvidence.Add(new
            {
                Id = "S1-107-GENERIC-RELATION-SEAM",
                Route = "Equivalent fault injection: universal relation endpoint inequality",
                Outcome = "detected",
                Detector = "Accepted Attitude(P,P) snapshot violates the injected universal-distinct predicate while type-specific invalid relations remain rejected"
            });
        });
    }
}
