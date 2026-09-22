using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private static InitialWorld FourPeople(long b = 30) => World(30, b, 30) with
    {
        People = [.. World(30, b, 30).People, new(new(4), "D", Sex.Male, 30)],
        Residences = [.. World().Residences, new(new(6), new(4), new(3))]
    };
    private static CycleResult RepairPair(Simulation sim, long firstActor, ActionTerms first, long secondActor, ActionTerms second, bool rename, bool reverse)
    {
        Proposal[] proposals = [P(rename ? 2000 : 1000, firstActor, first), P(rename ? 1000 : 2000, secondActor, second)];
        return sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
    }
    private static void CheckFallbacks(CycleResult result, int expected)
    {
        Equal(expected, result.Events.Count(e => e.TechnicalFallback));
        foreach (Outcome outcome in result.Outcomes.Where(o => o.Kind is OutcomeKind.Committed or OutcomeKind.InvalidatedAtResolution))
            Equal(expected > 0, result.Events.Single(e => e.Id == outcome.Event).TechnicalFallback);
    }
    private IEnumerable<Scenario> RepairResolutionCases()
    {
        yield return new("RepairResidenceReadWriteMatrix", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            // Invite/Move on the middle person would require two initiatives from
            // that person. The three other owner/mover combinations are reachable.
            foreach (int shape in new[] { 0, 1, 2 })
                foreach (bool rename in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(World(30, 30, 30));
                        CycleResult result = RepairPair(sim, shape == 2 ? 2 : 1,
                            shape == 2 ? new InviteResidence(new(1), new(2)) : new MoveResidence(new(2), new(2)),
                            shape == 0 ? 2 : 3, shape == 0 ? new MoveResidence(new(3), new(3)) : new InviteResidence(new(2), new(3)), rename, reverse);
                        Equal(new DwellingId(rename ? 1 : 2), result.State.HomeOf(new(1)));
                        Equal(new DwellingId(3), result.State.HomeOf(new(2)));
                        Equal(rename ? 1 : 2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        if (rename) Equal("ResidenceDestinationChanged", result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Reason);
                        CheckFallbacks(result, 2);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
            // Sharing a destination owner, with distinct movers, commutes.
            CycleResult compatible = RepairPair(Create(World()), 1, new MoveResidence(new(2), new(2)), 3, new MoveResidence(new(2), new(2)), false, true);
            Equal(2, compatible.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
            CheckFallbacks(compatible, 0);
        });
        yield return new("RepairMarriageCapacityPermutation", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool rename in new[] { false, true })
            {
                string? replay = null;
                foreach (bool reverse in new[] { false, true })
                {
                    InitialWorld initial = World(30, 30, 30, 80, 80) with
                    { Attitudes = [.. World(30, 30, 30, 80, 80).Attitudes, new(new(6), new(3), new(2), 80), new(new(7), new(2), new(3), 80)] };
                    Simulation sim = Create(initial);
                    CycleResult result = RepairPair(sim, 1, new ProposeMarriage(new(2), 1), 3, new ProposeMarriage(new(2), 1), rename, reverse);
                    Equal(new PersonId(rename ? 3 : 1), result.State.Marriages.Values.Single().Groom);
                    Equal("NoLongerEligibleForMarriage", result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Reason);
                    True(result.Events.Where(e => e.Kind == "DirectMarriage").All(e => e.Material.IsEmpty));
                    CheckFallbacks(result, 2);
                    if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                }
            }
        });
        yield return new("RepairFavourCreationProvenance", ["S1-081", "S1-093-BFF-RACE", "S1-093-RMRH-FULL", "S1-META-02"], () =>
        {
            foreach (string mode in new[] { "Empty", "Full", "BelowGate", "Bargain" })
                foreach (bool rename in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(World(30, 30, 30, 0, mode == "BelowGate" ? 60 : 80));
                        if (mode == "Full") sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
                        EventId? existing = sim.Snapshot.Favours.Values.SingleOrDefault()?.Origin;
                        CycleResult result = RepairPair(sim, 1, mode == "Bargain" ? new OfferBenefitForFavor(new(2), 1) : new RelationshipMediatedReciprocalHelp(new(2), 1),
                            2, new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true), rename, reverse);
                        bool lost = mode == "Bargain" && rename;
                        Equal(lost ? 1 : 2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        Equal(mode == "BelowGate" ? 0 : 1, result.State.Favours.Count);
                        if (mode != "BelowGate")
                        {
                            Favour favour = result.State.Favours.Values.Single();
                            Equal(new PersonId(2), favour.Debtor); Equal(new PersonId(1), favour.Holder);
                            if (existing is { } origin) Equal(origin, favour.Origin);
                            else Equal(new ProposalId(1000), result.Events.Single(e => e.Id == favour.Origin).Proposal);
                            if (mode == "Empty")
                                Equal(rename, ((RelationshipMediatedReciprocalHelp)result.Events.Single(e => e.Id == favour.Origin).Action!).Request);
                        }
                        if (lost) Equal("FavourCapacityFull", result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Reason);
                        Equal(mode == "Full" ? 25L : lost ? 28L : 27L, Grain(result, 1));
                        Equal(mode == "Full" ? 31L : lost ? 30L : 31L, Grain(result, 2));
                        CheckFallbacks(result, mode is "Empty" or "Bargain" ? 2 : 0);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
        });
        yield return new("RepairFavourRetirementDependencies", ["S1-081", "S1-094-RECIP-CANCEL", "S1-094-REPAY-CALLABLE", "S1-META-02"], () =>
        {
            foreach (string mode in new[] { "CancelCancel", "CallFarmCancel", "CallRepayCancel", "CallFarmCreate", "CallRepayCreate", "CancelCreate" })
                foreach (bool rename in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(World(30, 30, 30, 80, 80));
                        sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferLoan(new(2), 2))]));
                        sim.RunCycle(new([P(3, 2, new OfferBenefitForFavor(new(1), 1))]));
                        Favour owed = sim.Snapshot.Favours.Values.Single(f => f.Holder == new PersonId(1));
                        Debt debt = sim.Snapshot.Debts.Values.Single();
                        bool creation = mode.EndsWith("Create", StringComparison.Ordinal);
                        bool cancel = mode.StartsWith("Cancel", StringComparison.Ordinal);
                        bool repayment = mode.Contains("Repay", StringComparison.Ordinal);
                        CycleResult result = RepairPair(sim, 1, cancel ? new CancelReciprocalFavours(new(2)) : new CallFavor(owed.Id, repayment ? new RepayDebt(debt.Id, 1) : new Farm()),
                            2, creation ? new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true) : new CancelReciprocalFavours(new(1)), rename, reverse);
                        Equal(creation ? 2 : 1, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        True(!result.State.Favours[owed.Id].Outstanding);
                        int otherOutstanding = cancel || !creation && rename ? 0 : 1;
                        Equal(otherOutstanding + (creation && !rename ? 1 : 0), result.State.Favours.Values.Count(f => f.Outstanding));
                        Equal(repayment && (creation || !rename) ? 1L : 2L, result.State.Debts[debt.Id].Remaining);
                        Favour[] recreated = result.State.Favours.Values.Where(f => f.Id != owed.Id && f.Holder == new PersonId(1)).ToArray();
                        Equal(creation && !rename ? 1 : 0, recreated.Length);
                        if (recreated.Length > 0) Equal("RelationshipMediatedReciprocalHelp", result.Events.Single(e => e.Id == recreated[0].Origin).Kind);
                        CheckFallbacks(result, 2);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
        });
        yield return new("RepairAggregateDebtCapacity", ["S1-081", "S1-092-PARTIAL", "S1-094-INVALIDATED", "S1-META-02"], () =>
        {
            foreach (int last in new[] { 1, 2, 4 })
            {
                string? replay = null;
                foreach (bool reverse in new[] { false, true })
                {
                    Simulation sim = Create(FourPeople());
                    sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferLoan(new(2), 5)), P(3, 4, new OfferBenefitForFavor(new(2), 1))]));
                    Debt debt = sim.Snapshot.Debts.Values.Single();
                    Proposal[] proposals = [.. new[] { 1, 2, 4 }.Select(actor => P(actor == last ? 3000 : 1000 + actor, actor,
                        actor == 2 ? new RepayDebt(debt.Id, 2) : new CallFavor(sim.Snapshot.Favours.Values.Single(f => f.Holder == new PersonId(actor)).Id, new RepayDebt(debt.Id, 2))))];
                    CycleResult result = sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                    Equal(2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                    Outcome loser = result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution);
                    Equal(new PersonId(last), loser.Actor); Equal("RepaymentExceedsRemaining", loser.Reason);
                    Equal(1L, result.State.Debts[debt.Id].Remaining);
                    Equal(last == 2 ? 0 : 1, result.State.Favours.Values.Count(f => f.Outstanding));
                    Equal(31L, Grain(result, 2)); Equal(27L, Grain(result, 3));
                    CheckFallbacks(result, 3);
                    if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                }
            }
        });
        yield return new("RepairAggregateGrainAndEnablers", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool fits in new[] { false, true })
                foreach (bool rename in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(FourPeople(fits ? 7 : 6));
                        Proposal[] requests = [P(rename ? 30 : 10, 1, new RequestGiftOrHelp(new(2), 2)), P(20, 3, new RequestGiftOrHelp(new(2), 2)), P(rename ? 10 : 30, 4, new RequestGiftOrHelp(new(2), 2))];
                        CycleResult result = sim.RunCycle(new([.. reverse ? requests.Reverse() : requests]));
                        Equal(fits ? 3 : 2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        Equal(fits ? 0L : 1L, Grain(result, 2));
                        if (!fits) Equal(new PersonId(rename ? 1 : 4), result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Actor);
                        CheckFallbacks(result, fits ? 0 : 3);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
            foreach (string credit in new[] { "Gift", "Farm", "CalledFarm" })
                foreach (bool creditFirst in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(FourPeople(3));
                        if (credit == "CalledFarm") sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
                        Proposal enabler = P(creditFirst ? 10 : 40, credit == "Gift" ? 1 : credit == "Farm" ? 2 : 1,
                            credit == "Gift" ? new OfferGift(new(2), 2) : credit == "Farm" ? new Farm() : new CallFavor(sim.Snapshot.Favours.Values.Single().Id, new Farm()));
                        Proposal[] requests = [P(20, 3, new RequestGiftOrHelp(new(2), 2)), P(30, 4, new RequestGiftOrHelp(new(2), 2)), enabler];
                        CycleResult result = sim.RunCycle(new([.. reverse ? requests.Reverse() : requests]));
                        Equal(creditFirst ? 3 : 2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        Equal((credit == "Gift" ? 2L : 4L) - (creditFirst ? 2 : 0), Grain(result, 2));
                        CheckFallbacks(result, 3);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
        });
        yield return new("RepairTransferShapesAndReserve", ["S1-081", "S1-092-RESERVE", "S1-094-INVALIDATED", "S1-META-02"], () =>
        {
            foreach (string shape in new[] { "Gift", "Help", "LoanOffer", "LoanRequest", "Bargain", "ReciprocalOffer", "ReciprocalRequest", "Repay", "CalledRepay" })
                foreach (bool rename in new[] { false, true })
                {
                    string? replay = null;
                    foreach (bool reverse in new[] { false, true })
                    {
                        Simulation sim = Create(FourPeople(5));
                        sim.RunCycle(new([P(1, 3, new OfferLoan(new(2), 4)), P(2, 4, new OfferBenefitForFavor(new(2), 1))]));
                        Debt debt = sim.Snapshot.Debts.Values.Single();
                        Favour favour = sim.Snapshot.Favours.Values.Single();
                        ActionTerms terms = shape switch
                        {
                            "Gift" => new OfferGift(new(3), 2),
                            "Help" => new RequestGiftOrHelp(new(2), 2),
                            "LoanOffer" => new OfferLoan(new(3), 2),
                            "LoanRequest" => new RequestLoan(new(2), 2),
                            "Bargain" => new OfferBenefitForFavor(new(3), 2),
                            "ReciprocalOffer" => new RelationshipMediatedReciprocalHelp(new(3), 2),
                            "ReciprocalRequest" => new RelationshipMediatedReciprocalHelp(new(2), 2, Request: true),
                            "Repay" => new RepayDebt(debt.Id, 2),
                            _ => new CallFavor(favour.Id, new RepayDebt(debt.Id, 2))
                        };
                        bool repay = shape is "Repay" or "CalledRepay";
                        long actor = shape is "Help" or "LoanRequest" or "ReciprocalRequest" ? 3 : shape == "CalledRepay" ? 4 : 2;
                        // Snapshot stock is eight; reserve contention occurs even
                        // when total material spending fits the actual grain stock.
                        CycleResult result = RepairPair(sim, actor, terms, 1, new RequestGiftOrHelp(new(2), repay ? 6 : 8), rename, reverse);
                        Equal(repay && !rename ? 2 : 1, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                        Equal(rename ? repay ? 2L : 0L : repay ? 0L : 6L, Grain(result, 2));
                        Equal(repay && !rename ? 2L : 4L, result.State.Debts[debt.Id].Remaining);
                        if (shape == "CalledRepay") Equal(rename, result.State.Favours[favour.Id].Outstanding);
                        CheckFallbacks(result, 2);
                        if (replay is null) replay = Canonical(sim); else Equal(replay, Canonical(sim));
                    }
                }
        });
        yield return new("RepairCommutingAndAsymmetricControls", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool rename in new[] { false, true })
                foreach (bool reverse in new[] { false, true })
                {
                    CycleResult opposing = RepairPair(Create(World(30, 30, 30)), 1, new OfferGift(new(2), 2), 2, new OfferGift(new(1), 1), rename, reverse);
                    Equal(28L, Grain(opposing, 1)); Equal(30L, Grain(opposing, 2));
                    Equal(2, opposing.Outcomes.Count(o => o.Kind == OutcomeKind.Committed)); CheckFallbacks(opposing, 0);
                    InitialWorld initial = FourPeople() with
                    {
                        People = [.. FourPeople().People.Select(p => p.Id == new PersonId(4) ? p with { Sex = Sex.Female } : p)],
                        Attitudes = [new(new(7), new(1), new(2), 80), new(new(8), new(2), new(1), 80), new(new(9), new(3), new(4), 80), new(new(10), new(4), new(3), 80)]
                    };
                    CycleResult marriages = RepairPair(Create(initial), 1, new ProposeMarriage(new(2), 1), 3, new ProposeMarriage(new(4), 1), rename, reverse);
                    Equal(2, marriages.State.Marriages.Count); CheckFallbacks(marriages, 0);
                    Simulation sim = Create(FourPeople(5));
                    Proposal[] sufficient = [P(rename ? 30 : 10, 1, new RequestGiftOrHelp(new(2), 2)), P(20, 3, new RequestGiftOrHelp(new(2), 2)), P(rename ? 10 : 30, 2, new Farm())];
                    CycleResult funded = sim.RunCycle(new([.. reverse ? sufficient.Reverse() : sufficient]));
                    Equal(3, funded.Outcomes.Count(o => o.Kind == OutcomeKind.Committed)); Equal(4L, Grain(funded, 2)); CheckFallbacks(funded, 0);
                    // A request too large even at the common snapshot is Unable,
                    // not an accepted contender entitled to a fallback marker.
                    CycleResult asymmetric = RepairPair(Create(World(30, 3, 30)), 1, new RequestGiftOrHelp(new(2), 2), 3, new RequestGiftOrHelp(new(2), 3), rename, reverse);
                    Equal(1, asymmetric.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                    Equal(1, asymmetric.Outcomes.Count(o => o.Kind == OutcomeKind.Unable)); CheckFallbacks(asymmetric, 0);
                }
        });
    }
}
