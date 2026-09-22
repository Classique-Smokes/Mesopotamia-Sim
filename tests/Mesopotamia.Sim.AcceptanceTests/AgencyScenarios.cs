using System.Collections.Immutable;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private IEnumerable<Scenario> AgencyCases()
    {
        yield return new("GeneratedActionVocabularyAndRepaymentTarget", ["S1-099-KIN", "S1-086"], () =>
        {
            InitialWorld world = World(40, 40, 40, 80, 80) with { Kinships = [new(new(6), new(1), new(3), KinshipKind.Sibling)], Attitudes = [new(new(4), new(1), new(2), 80), new(new(5), new(2), new(1), 80), new(new(7), new(1), new(3), 20)] };
            Simulation sim = Create(world);
            sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferLoan(new(1), 2))]));
            sim.RunCycle(new([P(3, 2, new OfferBenefitForFavor(new(1), 1)), P(4, 1, new OfferLoan(new(2), 2))]));
            CycleResult result = sim.RunCycle(new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new("SCORE-VP-004")) });
            DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
            string[] expected = ["Farm", "OfferGift", "RequestGiftOrHelp", "OfferLoan", "RequestLoan", "RepayDebt", "OfferBenefitForFavor", "RelationshipMediatedReciprocalHelp", "CallFavor", "CancelReciprocalFavours", "ProposeMarriage", "MoveResidence", "InviteResidence"];
            foreach (string meaning in expected) True(trace.Candidates.Any(c => c.Meaning == meaning));
            True(trace.Candidates.Any(c => c.Terms is CallFavor { Requested: Farm }));
            True(trace.Candidates.Any(c => c.Terms is CallFavor { Requested: RepayDebt }));
            // Initial 20 plus loan-received +5, exact sibling multiplier: 3 * 25 = 75.
            Equal(75L, trace.Candidates.Single(c => c.Terms is RepayDebt).Components["AttitudeComponent"]);
            True(trace.Candidates.Where(c => c.Meaning == "OfferBenefitForFavor").Any(c => !c.Eligible && c.Gate == "FavourCapacityFull"));
        });
        yield return new("ExactKinScoringAndFullTrace", ["S1-099-KIN", "S1-086", "S1-MUT-29"], () =>
        {
            InitialWorld world = World(8, 8, 8, 20, 0);
            world = world with
            {
                Attitudes = [.. world.Attitudes, new(new(6), new(1), new(3), 20)],
                Kinships = [new(new(7), new(1), new(3), KinshipKind.ParentChild)]
            };
            Simulation sim = Create(world);
            CycleResult result = sim.RunCycle(new([])
            { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new("SCORE-VP-004")) });
            DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
            CandidateTrace nonKin = trace.Candidates.Single(c => c.Terms is OfferGift gift && gift.Target == new PersonId(2));
            CandidateTrace kin = trace.Candidates.Single(c => c.Terms is OfferGift gift && gift.Target == new PersonId(3));
            Equal(40L, nonKin.Components["AttitudeComponent"]);
            Equal(60L, kin.Components["AttitudeComponent"]);
            Equal(20, result.State.Attitudes.Values.Single(a => a.From == new PersonId(1) && a.To == new PersonId(3)).Value);
            True(trace.Candidates.Any(c => !c.Eligible && c.Gate.Length > 0));
            True(trace.Candidates.Count(c => c.Eligible) >= 2);
            True(trace.SubjectiveInputs.Any(i => i.Contains("Kin:True", StringComparison.Ordinal)));
            foreach (CandidateTrace candidate in trace.Candidates.Where(c => c.Eligible))
                Equal(candidate.FinalScore, candidate.Components.Values.Aggregate(0L, (sum, v) => checked(sum + v)));
            Equal("SCORE-VP-004", trace.Profile);
            Equal(1L, trace.Cycle);
            Equal(1, trace.Candidates.Count(c => c.Selected));
            True(trace.Proposal is not null && result.Outcomes.Any(o => o.Proposal == trace.Proposal));
            True(sim.DecisionHistory.Contains(trace));
            sim.RunCycle(CycleInput.Empty);
            True(sim.DecisionHistory.Contains(trace));
        });
        yield return new("CoResidenceMotivationWithoutCompulsion", ["S1-099-CORES"], () =>
        {
            foreach (bool married in new[] { false, true })
            {
                InitialWorld world = World(8, 8, 8, 80, 80);
                if (married) world = world with { Marriages = [new(new(6), new(1), new(2))] };
                CycleResult result = Create(world).RunCycle(new([])
                {
                    PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new("SCORE-VP-006")),
                    ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002")
                });
                DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
                CandidateTrace chosen = trace.Candidates.Single(c => c.Selected);
                Equal("MoveResidence", chosen.Meaning);
                Equal(married ? 40L : 20L, chosen.FinalScore);
                Equal(married ? 0L : 20L, chosen.Components["CoResidenceRelationshipConcern"]);
                Equal(married ? 40L : 0L, chosen.Components["CoResidenceMarriageConcern"]);
                Equal(OutcomeKind.Declined, result.Outcomes.Single().Kind);
                Equal(new DwellingId(1), result.State.HomeOf(new(1)));
            }
        });
        yield return new("PersonalResidenceAndIncomingResponse", ["S1-105"], () =>
        {
            InitialWorld world = World(0, 6, 8) with { Marriages = [new(new(6), new(3), new(2))] };
            Simulation sim = Create(world);
            CycleResult result = sim.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
            { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(2), new("SCORE-VP-006")) });
            Equal(1, result.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Personal"));
            Equal(1, result.Decisions.Count(d => d.Actor == new PersonId(2) && d.Context == "Response"));
            Equal(new DwellingId(3), result.State.HomeOf(new(2)));
            Equal(1L, Grain(result, 1));
            Equal(4L, Grain(result, 2));
            Equal(10, result.State.AttitudeOf(new(1), new(2)));
            Equal(2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
        });
        yield return new("ReferenceProfilesAndAutonomousCycle", ["S1-GLOBAL-FALLBACK"], () =>
        {
            Simulation gift = Create(World());
            CycleResult selected = gift.RunCycle(new([])
            { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new("SCORE-VP-002") { GiftTarget = new(2) }) });
            DecisionTrace decision = selected.Decisions.Single(d => d.Context == "Personal");
            Equal("OfferGift", decision.Candidates.Single(c => c.Selected).Meaning);
            Equal(100L, decision.Candidates.Single(c => c.Selected).FinalScore);
            True(!decision.TechnicalFallback);
            Simulation tied = Create(World());
            CycleResult symmetry = tied.RunCycle(new([])
            { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new("SCORE-VP-005")) });
            True(symmetry.Decisions.Single(d => d.Context == "Personal").TechnicalFallback);
            True(symmetry.Decisions.Single(d => d.Context == "Personal").Candidates.Where(c => c.Eligible).All(c => c.FinalScore == 0));
            CycleResult automatic = Create(World()).RunAutonomousCycle();
            Equal(3, automatic.Decisions.Count(d => d.Context == "Personal"));
            True(automatic.Outcomes.GroupBy(o => o.Actor).All(g => g.Count() == 1));
        });
    }
}
