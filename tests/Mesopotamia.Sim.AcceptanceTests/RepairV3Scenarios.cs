using System.Collections.Immutable;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    private IEnumerable<Scenario> RepairV3IntersectionCases()
    {
        yield return new("RepairV3IntersectingCapacities", ["S1-081", "S1-GLOBAL-FALLBACK", "S1-092-PARTIAL", "S1-092-RESERVE", "S1-094-INVALIDATED", "S1-META-01", "S1-META-02"], () =>
        {
            // Expected participation is a source-derived fact for each complete
            // matrix row; the production dependency classifier is never called.
            (long Debt, long Grain, int[] Amounts, bool Mixed, bool[] Flags)[] cases =
            [
                (5, 6, [2, 2, 2], false, [true, true, true, false]),
                (8, 6, [2, 2, 2], false, [true, true, true, true]),
                (5, 4, [2, 2, 2], false, [true, true, true, true]),
                (5, 7, [1, 2, 3], false, [true, true, true, false]),
                (5, 6, [1, 2, 3], false, [true, true, true, true]),
                (3, 6, [2, 2, 2], true, [true, true, false, false]),
                (3, 4, [2, 2, 2], true, [true, true, true, true]),
                (8, 10, [2, 2, 2], false, [false, false, false, false])
            ];
            foreach (var test in cases)
                foreach (string enabler in new[] { "Farm", "Gift", "Loan", "Reciprocal" })
                    foreach (int[] order in V3Permutations([0, 1, 2, 3]))
                    {
                        string? replay = null;
                        foreach (bool reverse in new[] { false, true })
                        {
                            InitialWorld initial = World(20, 0, 20) with
                            {
                                People = [.. World(20, 0, 20).People, new(new(4), "D", Sex.Male, 20), new(new(5), "E", Sex.Male, 20)],
                                Residences = [.. World().Residences, new(new(6), new(4), new(3)), new(new(7), new(5), new(3))],
                                Inputs = [new(1, 3, new(2), test.Grain - (test.Debt + 1))]
                            };
                            Simulation sim = Create(initial);
                            sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferBenefitForFavor(new(2), 1)),
                                P(3, 4, new OfferBenefitForFavor(new(2), 1)), P(4, 5, new OfferLoan(new(2), test.Debt))]));
                            sim.RunCycle(CycleInput.Empty);
                            Debt debt = sim.Snapshot.Debts.Values.Single();
                            Favour[] favours = sim.Snapshot.Favours.Values.OrderBy(f => f.Holder.Value).ToArray();
                            Proposal[] operations = [.. order.Select((index, rank) => index == 3
                                ? P(100 + rank, enabler == "Farm" ? 2 : 5, enabler switch
                                {
                                    "Farm" => new Farm(),
                                    "Gift" => new OfferGift(new(2), 4),
                                    "Loan" => new OfferLoan(new(2), 4),
                                    _ => new RelationshipMediatedReciprocalHelp(new(2), 4)
                                })
                                : P(100 + rank, favours[index].Holder.Value, test.Mixed && index == 2
                                    ? new RequestGiftOrHelp(new(2), test.Amounts[index])
                                    : new CallFavor(favours[index].Id, new RepayDebt(debt.Id, test.Amounts[index]))))];
                            CycleResult result = sim.RunCycle(new([.. reverse ? operations.Reverse() : operations]));
                            long grain = test.Grain, remaining = test.Debt;
                            for (int rank = 0; rank < order.Length; rank++)
                            {
                                int index = order[rank];
                                Proposal proposal = operations[rank];
                                Outcome outcome = result.Outcomes.Single(o => o.Proposal == proposal.Id);
                                string reason = "";
                                if (index == 3) grain += 4;
                                else
                                {
                                    long amount = test.Amounts[index];
                                    bool repay = !(test.Mixed && index == 2);
                                    if (repay && remaining < amount) reason = "RepaymentExceedsRemaining";
                                    else if (grain < amount + (repay ? 2 : 0)) reason = repay ? "RepaymentReserveUnavailable" : "InsufficientAvailableGrain";
                                    else { grain -= amount; if (repay) remaining -= amount; }
                                    Equal(!repay || reason.Length > 0, result.State.Favours[favours[index].Id].Outstanding);
                                }
                                Equal(reason, outcome.Reason);
                                Equal(reason.Length == 0 ? OutcomeKind.Committed : OutcomeKind.InvalidatedAtResolution, outcome.Kind);
                                Equal(test.Flags[index], V3Fallback(result, proposal.Id));
                            }
                            Equal(grain, Grain(result, 2));
                            Equal(remaining, result.State.Debts[debt.Id].Remaining);
                            Equal(enabler == "Loan" ? 2 : 1, result.State.Debts.Count);
                            if (enabler == "Loan")
                            {
                                Debt created = result.State.Debts.Values.Single(d => d.Id != debt.Id);
                                Equal(4L, created.Original);
                                Equal(operations[Array.IndexOf(order, 3)].Id, result.Events.Single(e => e.Id == created.Origin).Proposal!.Value);
                            }
                            if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                        }
                    }
        });
    }

    private IEnumerable<Scenario> RepairV3Cases()
    {
        yield return new("RepairV3FutureFaultTiming", ["S1-080", "S1-META-04"], () =>
        {
            foreach (bool overflow in new[] { false, true })
            {
                Simulation sim = Create(World(0, 0, 0) with
                {
                    Inputs = overflow
                        ? [new(1, 2, new(1), long.MaxValue), new(2, 2, new(1), 1), new(3, 3, new(2), 1)]
                        : [new(1, 2, new(1), -1), new(2, 3, new(2), 1)]
                });
                CycleResult first = sim.RunCycle(CycleInput.Empty);
                True(first.MaterialDeadlock);
                True(!sim.IsFaulted);
                Equal(3, first.Events.Length);
                if (overflow) Assert.ThrowsExactly<OverflowException>(() => sim.RunCycle(CycleInput.Empty));
                else Assert.ThrowsExactly<InvalidOperationException>(() => sim.RunCycle(CycleInput.Empty));
                True(sim.IsFaulted);
                // Stable publication is still cycle 1; the failed cycle cannot
                // become a completed state. Fault history is audited separately.
                Equal(1L, sim.Snapshot.Cycle);
                Equal(0L, sim.Snapshot.People[new(1)].Grain);
                Equal(first.State, sim.Snapshot);
            }
        }, Oracle: "Director ruling: non-executing projection preserves scheduled fault timing; explicit overflow/debit checks");
        yield return new("RepairV3DistantInputBoundary", ["S1-080", "S1-META-04"], () =>
        {
            foreach (long credit in new long[] { 1, 2 })
            {
                Simulation sim = Create(World(0, 0, 0) with
                {
                    Inputs = [new(1, long.MaxValue, new(1), credit), new(2, long.MaxValue, new(1), -1)]
                });
                CycleResult result = sim.RunCycle(CycleInput.Empty);
                Equal(credit == 1, result.MaterialDeadlock);
                Equal(3, result.Events.Length);
                Equal(1L, result.State.Cycle);
                True(!sim.IsFaulted);
            }
        });
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
