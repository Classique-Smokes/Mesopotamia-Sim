using System.Collections.Immutable;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private static IEnumerable<int[]> V3Permutations(int[] values)
    {
        if (values.Length == 0) { yield return []; yield break; }
        foreach (int value in values)
            foreach (int[] tail in V3Permutations(values.Where(v => v != value).ToArray()))
                yield return [value, .. tail];
    }

    private static bool V3Fallback(CycleResult result, ProposalId proposal) =>
        result.Events.Single(e => e.Id == result.Outcomes.Single(o => o.Proposal == proposal).Event).TechnicalFallback;

    private IEnumerable<Scenario> RepairV3Cases()
    {
        yield return new("RepairV3FutureMaterialRecovery", ["S1-080", "S1-META-01", "S1-META-04"], () =>
        {
            // Input deltas are signed fixture facts, not voluntary action terms.
            (GrainInput[] Inputs, bool Resolves)[] cases =
            [
                ([], false),
                ([new(1, 2, new(1), 1)], true),
                ([new(1, 2, new(1), 1), new(2, 2, new(1), -1)], false),
                ([new(1, 2, new(1), 2), new(2, 2, new(1), -1)], true),
                ([new(1, 2, new(1), 1), new(2, 2, new(2), 2), new(3, 2, new(1), -1), new(4, 2, new(2), -2)], false),
                ([new(1, 2, new(1), 2), new(2, 2, new(1), -2), new(3, 4, new(2), 1), new(4, 4, new(2), -1)], false),
                ([new(1, 2, new(1), 1), new(2, 2, new(1), -1), new(3, 4, new(2), 1)], true),
                // Recovery is at the first available decision boundary, even if
                // a subsequent scheduled batch removes its own incoming grain.
                ([new(1, 2, new(1), 1), new(2, 3, new(2), 1), new(3, 3, new(2), -1)], true)
            ];
            foreach (var test in cases)
            {
                string? replay = null;
                foreach (bool reverse in new[] { false, true })
                {
                    InitialWorld initial = World(0, 0, 0) with { Inputs = [.. reverse ? test.Inputs.Reverse() : test.Inputs] };
                    Simulation sim = Create(initial);
                    WorldSnapshot before = sim.Snapshot;
                    CycleResult first = sim.RunCycle(CycleInput.Empty);
                    Equal(!test.Resolves, first.MaterialDeadlock);
                    True(first.State.People.Values.All(p => p.Grain == 0 && p.NeedsGrain));
                    Equal(3, first.Events.Length);
                    True(first.Events.All(e => e.Kind == "MissedConsumption"));
                    Equal(0L, before.Cycle);
                    long end = test.Inputs.Select(i => i.Cycle).DefaultIfEmpty(2).Max();
                    bool recovered = false;
                    for (long at = 2; at <= end; at++)
                    {
                        // Independent replay: all previous blocked cycles have
                        // zero stock; each complete batch must survive consumption.
                        CycleResult actual = sim.RunCycle(CycleInput.Empty);
                        recovered |= actual.State.People.Values.Any(p => !p.NeedsGrain);
                        _ = sim.Snapshot;
                        _ = sim.History;
                    }
                    Equal(test.Resolves, recovered);
                    if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                }
            }
        });
        yield return new("RepairV3DebtLimitedCommutingFarm", ["S1-081", "S1-GLOBAL-FALLBACK", "S1-092-PARTIAL", "S1-092-RESERVE", "S1-094-INVALIDATED", "S1-META-01", "S1-META-02"], () =>
        {
            foreach (int[] order in V3Permutations([1, 2, 3, 4]))
            {
                string? replay = null;
                foreach (bool reverse in new[] { false, true })
                {
                    InitialWorld initial = World(20, 0, 20) with
                    {
                        People = [.. World(20, 0, 20).People, new(new(4), "D", Sex.Male, 20), new(new(5), "E", Sex.Male, 20)],
                        Residences = [.. World().Residences, new(new(6), new(4), new(3)), new(new(7), new(5), new(3))]
                    };
                    Simulation sim = Create(initial);
                    sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferBenefitForFavor(new(2), 1)),
                        P(3, 4, new OfferBenefitForFavor(new(2), 1)), P(4, 5, new OfferLoan(new(2), 5))]));
                    sim.RunCycle(CycleInput.Empty);
                    Debt debt = sim.Snapshot.Debts.Values.Single();
                    Favour[] favours = sim.Snapshot.Favours.Values.ToArray();
                    Proposal[] proposals = order.Select((actor, index) => P(100 + index, actor, actor == 2 ? new Farm() :
                        new CallFavor(favours.Single(f => f.Holder == new PersonId(actor)).Id, new RepayDebt(debt.Id, 2)))).ToArray();
                    CycleResult result = sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                    Equal(3, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                    Outcome loser = result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution);
                    Equal(new PersonId(order.Last(a => a != 2)), loser.Actor);
                    Equal("RepaymentExceedsRemaining", loser.Reason);
                    Equal(1L, result.State.Debts[debt.Id].Remaining);
                    Equal(6L, Grain(result, 2));
                    foreach (Proposal proposal in proposals)
                        Equal(proposal.Actor != new PersonId(2), V3Fallback(result, proposal.Id));
                    foreach (Favour favour in favours)
                        Equal(favour.Holder == loser.Actor, result.State.Favours[favour.Id].Outstanding);
                    if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                }
            }
        });
    }
}
