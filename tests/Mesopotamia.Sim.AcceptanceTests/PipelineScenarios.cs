using System.Collections.Immutable;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal static partial class Scenarios
{
    private static IEnumerable<Scenario> Pipeline()
    {
        yield return new("GiftHelpMeaningsAndNeedClearing", ["S1-090-D", "S1-BND-NEED", "S1-091-GIFT", "S1-091-HELP", "S1-093-GIFT-CONTROL"], () =>
        {
            foreach (bool requested in new[] { false, true })
            {
                Simulation sim = new(World(0, 8));
                CycleResult result = sim.RunCycle(new([requested ? P(1, 1, new RequestGiftOrHelp(new(2), 1)) : P(1, 2, new OfferGift(new(1), 1))]));
                Equal(1L, Grain(result, 1));
                True(!result.State.People[new(1)].NeedsGrain);
                Equal(6L, Grain(result, 2));
                Equal(10, result.State.AttitudeOf(new(1), new(2)));
                Equal(0, result.State.Debts.Count);
                Equal(0, result.State.Favours.Count);
                Equal(0, result.Events.Count(e => e.Kind == "Farm"));
                Equal(1, result.Events.Count(e => e.Kind == (requested ? "Help" : "Gift")));
                CycleResult next = sim.RunCycle(new([P(2, 1, new Farm())]));
                Equal(4L, Grain(next, 1));
            }
        });
        yield return new("ResponseAutonomyAndBoundedFailureKnowledge", ["S1-100", "S1-101", "S1-070", "S1-073", "S1-GLOBAL-KNOWLEDGE", "S1-MUT-17", "S1-MUT-18", "S1-MUT-19"], () =>
        {
            foreach (var item in new[] { (8L, "SCORE-RP-001", OutcomeKind.Committed, 10), (8L, "SCORE-RP-002", OutcomeKind.Declined, -5), (0L, "SCORE-RP-001", OutcomeKind.Unable, 0) })
            {
                Simulation sim = new(World(0, item.Item1));
                CycleResult result = sim.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
                { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), item.Item2) });
                Equal(item.Item3, result.Outcomes.Single().Kind);
                Equal(item.Item4, result.State.AttitudeOf(new(1), new(2)));
                Equal(item.Item3 == OutcomeKind.Committed ? 1L : 0L, Grain(result, 1));
                Equal(item.Item3, sim.KnowledgeOf(new(1)).Single().Kind);
                Equal(item.Item3, sim.KnowledgeOf(new(2)).Single().Kind);
                Equal(0, sim.KnowledgeOf(new(3)).Length);
                True(!sim.KnowledgeOf(new(1)).Single().Reason.Contains("Grain:", StringComparison.Ordinal));
                DecisionTrace trace = result.Decisions.Single();
                if (item.Item3 == OutcomeKind.Unable) Equal(0, trace.Candidates.Length);
                else
                {
                    Equal(2, trace.Candidates.Length);
                    Equal(100L, trace.Candidates.Single(c => c.Selected).FinalScore);
                    Equal(0L, trace.Candidates.Single(c => !c.Selected).FinalScore);
                    foreach (CandidateTrace candidate in trace.Candidates)
                        Equal(candidate.FinalScore, candidate.Components.Values.Sum());
                }
            }
            Simulation noNeed = new(World());
            CycleResult declined = noNeed.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            Equal(0, declined.State.AttitudeOf(new(1), new(2)));
        });
        yield return new("SharedSnapshotScarceGrain", ["S1-103-GRAIN", "S1-071", "S1-098-CORE", "S1-MUT-16", "S1-MUT-20", "S1-MUT-21"], () =>
        {
            foreach (bool reverse in new[] { false, true })
            {
                Proposal[] proposals = [P(10, 1, new RequestGiftOrHelp(new(2), 1)), P(20, 3, new RequestGiftOrHelp(new(2), 1))];
                Simulation sim = new(World(0, 2, 0));
                CycleResult result = sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                Equal(2, result.Decisions.Count(d => d.Actor == new PersonId(2)));
                True(result.Decisions.All(d => d.Candidates.Single(c => c.Selected).Meaning == "Accept"));
                Equal(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal.Value == 10).Kind);
                Equal(OutcomeKind.InvalidatedAtResolution, result.Outcomes.Single(o => o.Proposal.Value == 20).Kind);
                Equal(1L, Grain(result, 1));
                Equal(0L, Grain(result, 2));
                Equal(0L, Grain(result, 3));
                Equal(0, result.State.AttitudeOf(new(3), new(2)));
                Equal(2, result.Events.Count(e => e.TechnicalFallback));
                Equal(0, result.Events.Count(e => e.Kind == "Farm"));
                Equal(2, sim.KnowledgeOf(new(2)).Length);
            }
            Simulation combined = new(World(0, 8));
            CycleResult together = combined.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1)), P(2, 2, new Farm())]));
            Equal(10L, Grain(together, 2));
            Equal(2, together.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
        });
        yield return new("GiftGrainIngress", ["S1-D4-GRAIN-GIFT-OFFER", "S1-D4-GRAIN-GIFT-REQUEST"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 1L })
                foreach (bool request in new[] { false, true })
                {
                    Simulation sim = new(World());
                    CycleResult result = sim.RunCycle(new([P(1, 1, request ? new RequestGiftOrHelp(new(2), amount) : new OfferGift(new(2), amount))]));
                    Equal(amount > 0 ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                    if (amount <= 0)
                    {
                        Equal(0, result.Decisions.Length);
                        Equal(0, sim.KnowledgeOf(new(1)).Length);
                        Equal(7L, Grain(result, 1));
                        Equal(7L, Grain(result, 2));
                        Equal(0, result.State.AttitudeOf(new(2), new(1)));
                    }
                }
            Equal(typeof(long), typeof(OfferGift).GetProperty(nameof(OfferGift.Amount))!.PropertyType);
            Equal(typeof(long), typeof(RequestGiftOrHelp).GetProperty(nameof(RequestGiftOrHelp.Amount))!.PropertyType);
        });
    }
}
