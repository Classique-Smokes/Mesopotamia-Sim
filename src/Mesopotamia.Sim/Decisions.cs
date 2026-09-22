using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed record OfferGift(PersonId Target, long Amount) : ActionTerms;
public sealed record RequestGiftOrHelp(PersonId Target, long Amount) : ActionTerms;
public sealed record OfferLoan(PersonId Target, long Amount) : ActionTerms;
public sealed record RequestLoan(PersonId Target, long Amount) : ActionTerms;
public sealed record RepayDebt(RelationId Debt, long Amount) : ActionTerms;
public sealed record OfferBenefitForFavor(PersonId Target, long Amount) : ActionTerms;
public sealed record RelationshipMediatedReciprocalHelp(PersonId Target, long Amount, bool Request = false) : ActionTerms;
public sealed record CallFavor(RelationId Favour, ActionTerms Requested) : ActionTerms;
public sealed record CancelReciprocalFavours(PersonId Target) : ActionTerms;
public sealed record ProposeMarriage(PersonId Bride, long ProposedDowry) : ActionTerms;
public sealed record MoveResidence(PersonId Target, DwellingId Destination) : ActionTerms;
public sealed record InviteResidence(PersonId Target, DwellingId Destination) : ActionTerms;
public enum ResponseChoice { Accept, Decline, FulfilCalledFavor, RefuseCalledFavor }
public sealed record CandidateTrace(string Key, string Meaning, bool Eligible, string Gate,
    ImmutableDictionary<string, long> Components, long? FinalScore, bool Selected)
{
    public ActionTerms? Terms { get; init; }
}
public sealed record DecisionTrace(PersonId Actor, ProposalId? Proposal, string Context,
    string Profile, ImmutableArray<CandidateTrace> Candidates, ImmutableArray<string> SubjectiveInputs,
    bool TechnicalFallback)
{
    public long Cycle { get; init; }
}
public sealed record ParticipantOutcome(EventId Event, ProposalId Proposal, OutcomeKind Kind, string Reason);
public sealed record CauseKey(string Rule, EventId Trigger, PersonId From, PersonId To);
public sealed record AttitudeContribution(CauseKey Key, int Delta);

internal sealed class AttitudeBatch
{
    private readonly Dictionary<CauseKey, AttitudeContribution> contributions = [];
    private bool sealedBatch;
    internal int DuplicateCount { get; private set; }
    internal bool IsClosed => sealedBatch;
    internal ImmutableArray<AttitudeContribution> Pending => contributions.Values.ToImmutableArray();
    internal bool Add(AttitudeContribution contribution)
    {
        if (sealedBatch) throw new InvalidOperationException("Reaction batch is already closed.");
        if (contributions.TryAdd(contribution.Key, contribution)) return true;
        if (contributions[contribution.Key] != contribution)
            throw new InvalidOperationException("A cause key was reused with a different consequence.");
        DuplicateCount++;
        return false;
    }
    internal ImmutableArray<AttitudeContribution> Close()
    {
        if (sealedBatch) throw new InvalidOperationException("Reaction batch was already closed.");
        sealedBatch = true;
        return contributions.Values.OrderBy(c => c.Key.From.Value).ThenBy(c => c.Key.To.Value)
            .ThenBy(c => c.Key.Trigger.Value).ThenBy(c => c.Key.Rule, StringComparer.Ordinal).ToImmutableArray();
    }
}

internal static class ActionRules
{
    internal static string Describe(ActionTerms terms) => terms switch
    {
        Farm => "Farm",
        OfferGift a => FormattableString.Invariant($"OfferGift({a.Target.Value},{a.Amount})"),
        RequestGiftOrHelp a => FormattableString.Invariant($"RequestGiftOrHelp({a.Target.Value},{a.Amount})"),
        OfferLoan a => FormattableString.Invariant($"OfferLoan({a.Target.Value},{a.Amount})"),
        RequestLoan a => FormattableString.Invariant($"RequestLoan({a.Target.Value},{a.Amount})"),
        RepayDebt a => FormattableString.Invariant($"RepayDebt({a.Debt.Value},{a.Amount})"),
        OfferBenefitForFavor a => FormattableString.Invariant($"OfferBenefitForFavor({a.Target.Value},{a.Amount})"),
        RelationshipMediatedReciprocalHelp a => FormattableString.Invariant($"ReciprocalHelp({a.Target.Value},{a.Amount},{a.Request})"),
        CallFavor a => FormattableString.Invariant($"CallFavor({a.Favour.Value},{Describe(a.Requested)})"),
        CancelReciprocalFavours a => FormattableString.Invariant($"CancelReciprocalFavours({a.Target.Value})"),
        ProposeMarriage a => FormattableString.Invariant($"ProposeMarriage({a.Bride.Value},{a.ProposedDowry})"),
        MoveResidence a => FormattableString.Invariant($"MoveResidence({a.Target.Value},{a.Destination.Value})"),
        InviteResidence a => FormattableString.Invariant($"InviteResidence({a.Target.Value},{a.Destination.Value})"),
        _ => "UnknownActionMeaning"
    };
    internal static PersonId? Target(ActionTerms terms, WorldSnapshot snapshot) => terms switch
    {
        OfferGift gift => gift.Target,
        RequestGiftOrHelp help => help.Target,
        OfferLoan loan => loan.Target,
        RequestLoan loan => loan.Target,
        OfferBenefitForFavor benefit => benefit.Target,
        RelationshipMediatedReciprocalHelp help => help.Target,
        CallFavor call => snapshot.Favours.TryGetValue(call.Favour, out Favour? favour) ? favour.Debtor : null,
        ProposeMarriage marriage => marriage.Bride,
        MoveResidence move => move.Target,
        InviteResidence invite => invite.Target,
        _ => null
    };
    internal static string? Invalid(Proposal proposal, WorldSnapshot snapshot)
    {
        PersonId? target = Target(proposal.Terms, snapshot);
        if (target is { } person && (person == proposal.Actor || !snapshot.People.ContainsKey(person)))
            return "InvalidCounterparty";
        return proposal.Terms switch
        {
            Farm => null,
            OfferGift gift => gift.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            RequestGiftOrHelp help => help.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            OfferLoan loan => loan.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            RequestLoan loan => loan.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            OfferBenefitForFavor benefit => benefit.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            RelationshipMediatedReciprocalHelp help => help.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            CallFavor call => !snapshot.Favours.TryGetValue(call.Favour, out Favour? favour) ? "UnknownFavour" :
                call.Requested is not (Farm or RepayDebt) ? "NonCallablePayload" :
                Invalid(new(proposal.Id, favour.Debtor, call.Requested), snapshot),
            CancelReciprocalFavours cancel => cancel.Target == proposal.Actor || !snapshot.People.ContainsKey(cancel.Target) ? "InvalidCounterparty" : null,
            ProposeMarriage marriage => marriage.ProposedDowry > 0 ? null : "PositiveIntegralGrainRequired",
            MoveResidence move => snapshot.Dwellings.ContainsKey(move.Destination) ? null : "UnknownDwelling",
            InviteResidence invite => snapshot.Dwellings.ContainsKey(invite.Destination) ? null : "UnknownDwelling",
            RepayDebt repay => repay.Amount <= 0 ? "PositiveIntegralGrainRequired" :
                !snapshot.Debts.TryGetValue(repay.Debt, out Debt? debt) ? "UnknownDebt" :
                repay.Amount > debt.Remaining ? "RepaymentExceedsRemaining" : null,
            _ => "UnknownActionMeaning"
        };
    }
    internal static string? Infeasible(Proposal proposal, WorldSnapshot snapshot) => proposal.Terms switch
    {
        Farm => snapshot.People[proposal.Actor].NeedsGrain ? "NeedsGrain" : null,
        OfferGift gift => snapshot.People[proposal.Actor].Grain < gift.Amount ? "InsufficientAvailableGrain" : null,
        RequestGiftOrHelp help => snapshot.People[help.Target].Grain < help.Amount ? "InsufficientAvailableGrain" : null,
        OfferLoan loan => snapshot.People[proposal.Actor].Grain < loan.Amount ? "InsufficientAvailableGrain" : null,
        RequestLoan loan => snapshot.People[loan.Target].Grain < loan.Amount ? "InsufficientAvailableGrain" : null,
        RepayDebt repay => snapshot.Debts[repay.Debt].Debtor != proposal.Actor ? "NotDebtParty" :
            snapshot.People[proposal.Actor].Grain - 2 < repay.Amount ? "RepaymentReserveUnavailable" : null,
        OfferBenefitForFavor benefit => snapshot.HasFavour(benefit.Target, proposal.Actor) ? "FavourCapacityFull" :
            snapshot.People[proposal.Actor].Grain < benefit.Amount ? "InsufficientAvailableGrain" : null,
        RelationshipMediatedReciprocalHelp help => snapshot.People[help.Request ? help.Target : proposal.Actor].Grain < help.Amount ? "InsufficientAvailableGrain" : null,
        CallFavor call => !snapshot.Favours[call.Favour].Outstanding || snapshot.Favours[call.Favour].Holder != proposal.Actor ? "FavourUnavailable" :
            Infeasible(new(proposal.Id, snapshot.Favours[call.Favour].Debtor, call.Requested), snapshot),
        CancelReciprocalFavours cancel => snapshot.HasFavour(proposal.Actor, cancel.Target) && snapshot.HasFavour(cancel.Target, proposal.Actor) ? null : "ReciprocalFavoursUnavailable",
        ProposeMarriage marriage => snapshot.People[proposal.Actor].Sex != Sex.Male || snapshot.People[marriage.Bride].Sex != Sex.Female ||
            snapshot.AreKin(proposal.Actor, marriage.Bride) || snapshot.HasMarriage(proposal.Actor) || snapshot.HasMarriage(marriage.Bride) ? "NoLongerEligibleForMarriage" :
            snapshot.AttitudeOf(proposal.Actor, marriage.Bride) < 75 || snapshot.AttitudeOf(marriage.Bride, proposal.Actor) < 75 ? "DirectMarriageGateUnavailable" : null,
        MoveResidence move => snapshot.HomeOf(move.Target) != move.Destination ? "ResidenceDestinationChanged" :
            snapshot.HomeOf(proposal.Actor) == move.Destination ? "AlreadyAtDestination" : null,
        InviteResidence invite => snapshot.HomeOf(proposal.Actor) != invite.Destination ? "ResidenceDestinationChanged" :
            snapshot.HomeOf(invite.Target) == invite.Destination ? "AlreadyAtDestination" : null,
        _ => "UnsupportedAction"
    };
    internal static PersonId? Mover(Proposal proposal) => proposal.Terms switch
    {
        MoveResidence => proposal.Actor,
        InviteResidence invite => invite.Target,
        _ => null
    };
}
