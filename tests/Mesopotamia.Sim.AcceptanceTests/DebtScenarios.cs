using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private IEnumerable<Scenario> DebtCases()
    {
        yield return new("LoanRoutesAndRepaymentHistory", ["S1-091-LOAN-OFFER", "S1-091-LOAN-REQUEST", "S1-092-PARTIAL", "S1-092-FULL"], () =>
        {
            foreach (bool request in new[] { false, true })
            {
                Simulation sim = Create(World(30, 30));
                CycleResult loan = sim.RunCycle(new([request ? P(1, 2, new RequestLoan(new(1), 4)) : P(1, 1, new OfferLoan(new(2), 4))]));
                Debt debt = loan.State.Debts.Values.Single();
                Equal(new PersonId(1), debt.Creditor);
                Equal(new PersonId(2), debt.Debtor);
                Equal(4L, debt.Remaining);
                Equal(4L, debt.Original);
                Equal(25L, Grain(loan, 1));
                Equal(33L, Grain(loan, 2));
                Equal(5, loan.State.AttitudeOf(new(2), new(1)));
                Equal(0, loan.State.Favours.Count);
                Equal("Loan", sim.History.Single(e => e.Id == debt.Origin).Kind);
                CycleResult partial = sim.RunCycle(new([P(2, 2, new RepayDebt(debt.Id, 1))]));
                Equal(3L, partial.State.Debts[debt.Id].Remaining);
                Equal(31L, Grain(partial, 2));
                Equal(25L, Grain(partial, 1));
                Equal(5, partial.State.AttitudeOf(new(1), new(2)));
                Equal(0, partial.Decisions.Length);
                Equal(OutcomeKind.Committed, sim.KnowledgeOf(new(1))[^1].Kind);
                CycleResult full = sim.RunCycle(new([P(3, 2, new RepayDebt(debt.Id, 3))]));
                Equal(0L, full.State.Debts[debt.Id].Remaining);
                Equal(debt.Origin, full.State.Debts[debt.Id].Origin);
                Equal(2, sim.History.Count(e => e.Kind == "Repayment"));
            }
        });
        yield return new("RepaymentAmountAndReserve", ["S1-092-AMOUNT-VALIDITY", "S1-092-RESERVE", "S1-BND-RESERVE", "S1-MUT-13A", "S1-D4-GRAIN-REPAY-DIRECT"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 3L, 4L, 5L })
            {
                Simulation sim = Create(World(30, 30));
                sim.RunCycle(new([P(1, 1, new OfferLoan(new(2), 4))]));
                Debt debt = sim.Snapshot.Debts.Values.Single();
                CycleResult result = sim.RunCycle(new([P(2, 2, new RepayDebt(debt.Id, amount))]));
                bool valid = amount is > 0 and <= 4;
                Equal(valid ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                Equal(valid ? 4L - amount : 4L, result.State.Debts[debt.Id].Remaining);
                Equal(0, result.Decisions.Length);
                if (!valid) Equal(1, sim.KnowledgeOf(new(2)).Length);
            }
            foreach (long remainingStock in new[] { 1L, 2L, 3L })
            {
                Simulation sim = Create(World(20, remainingStock + 2));
                sim.RunCycle(new([P(1, 1, new OfferLoan(new(2), 1))]));
                Debt debt = sim.Snapshot.Debts.Values.Single();
                CycleResult result = sim.RunCycle(new([P(2, 2, new RepayDebt(debt.Id, 1))]));
                Equal(remainingStock < 2 ? OutcomeKind.Unable : OutcomeKind.Committed, result.Outcomes.Single().Kind);
                Equal(remainingStock < 2 ? 1L : 0L, result.State.Debts[debt.Id].Remaining);
                Equal(remainingStock < 2 ? 0 : 5, result.State.AttitudeOf(new(1), new(2)));
            }
            Equal(typeof(long), typeof(RepayDebt).GetProperty(nameof(RepayDebt.Amount))!.PropertyType);
        });
        yield return new("DebtDueAfterThirdFullCycle", ["S1-092-DUE", "S1-BND-DEBT-DUE"], () =>
        {
            foreach (long debtorGrain in new[] { 0L, 30L })
            {
                Simulation sim = Create(World(30, debtorGrain));
                sim.RunCycle(new([P(1, 1, new OfferLoan(new(2), 4))]));
                sim.RunCycle(CycleInput.Empty);
                sim.RunCycle(CycleInput.Empty);
                Equal(0, sim.Snapshot.AttitudeOf(new(1), new(2)));
                CycleResult due = sim.RunCycle(CycleInput.Empty);
                Equal(-10, due.State.AttitudeOf(new(1), new(2)));
                sim.RunCycle(CycleInput.Empty);
                sim.RunCycle(CycleInput.Empty);
                Equal(1, sim.History.Count(e => e.Kind == "DebtSocialDueReview"));
                Equal(4L, sim.Snapshot.Debts.Values.Single().Remaining);
            }
            Simulation repaid = Create(World(30, 30));
            repaid.RunCycle(new([P(1, 1, new OfferLoan(new(2), 4))]));
            Debt debt = repaid.Snapshot.Debts.Values.Single();
            repaid.RunCycle(CycleInput.Empty);
            repaid.RunCycle(CycleInput.Empty);
            CycleResult onTime = repaid.RunCycle(new([P(4, 2, new RepayDebt(debt.Id, 4))]));
            Equal(5, onTime.State.AttitudeOf(new(1), new(2)));
            Equal("Satisfied", onTime.Events.Single(e => e.Kind == "DebtSocialDueReview").Detail);
        });
        yield return new("LoanGrainIngress", ["S1-D4-GRAIN-LOAN-OFFER", "S1-D4-GRAIN-LOAN-REQUEST"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 1L })
                foreach (bool request in new[] { false, true })
                {
                    Simulation sim = Create(World());
                    CycleResult result = sim.RunCycle(new([P(1, 1, request ? new RequestLoan(new(2), amount) : new OfferLoan(new(2), amount))]));
                    Equal(amount > 0 ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                    if (amount <= 0)
                    {
                        Equal(0, result.Decisions.Length);
                        Equal(0, sim.KnowledgeOf(new(1)).Length);
                        Equal(0, result.State.Debts.Count);
                        Equal(7L, Grain(result, 1));
                        Equal(7L, Grain(result, 2));
                    }
                }
            Equal(typeof(long), typeof(OfferLoan).GetProperty(nameof(OfferLoan.Amount))!.PropertyType);
            Equal(typeof(long), typeof(RequestLoan).GetProperty(nameof(RequestLoan.Amount))!.PropertyType);
        });
    }
}
