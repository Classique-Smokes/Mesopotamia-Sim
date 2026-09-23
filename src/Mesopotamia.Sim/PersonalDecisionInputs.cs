using System.Collections.Immutable;

namespace Mesopotamia.Sim;

/// <summary>A bounded, immutable Slice-1 policy input, not a general knowledge store.</summary>
internal sealed record PersonalDecisionInputs(
    Person Own, DwellingId OwnResidence, PersonalPolicy Policy,
    ImmutableArray<PersonId> KnownPeople, ImmutableArray<Attitude> Attitudes,
    ImmutableArray<Kinship> Kinships, ImmutableArray<Marriage> Marriages,
    ImmutableArray<Debt> Debts, ImmutableArray<Favour> Favours)
{
    internal int AttitudeOf(PersonId from, PersonId to) => Attitudes.SingleOrDefault(a => a.From == from && a.To == to)?.Value ?? 0;
    internal bool AreKin(PersonId person) => Kinships.Any(k => k.First == person || k.Second == person);
    internal bool AreMarried(PersonId person) => Marriages.Any(m => m.Groom == person || m.Bride == person);
    internal bool HasFavour(PersonId debtor, PersonId holder) => Favours.Any(f => f.Debtor == debtor && f.Holder == holder && f.Outstanding);

    internal PersonId? Target(ActionTerms terms) => terms switch
    {
        OfferGift a => a.Target,
        RequestGiftOrHelp a => a.Target,
        OfferLoan a => a.Target,
        RequestLoan a => a.Target,
        OfferBenefitForFavor a => a.Target,
        RelationshipMediatedReciprocalHelp a => a.Target,
        RepayDebt a => Debts.Single(d => d.Id == a.Debt).Creditor,
        CallFavor a => Favours.Single(f => f.Id == a.Favour).Debtor,
        CancelReciprocalFavours a => a.Target,
        ProposeMarriage a => a.Bride,
        MoveResidence a => a.Target,
        InviteResidence a => a.Target,
        _ => null
    };

    // Personal gates consider justified inputs only. Unknown counterpart stock,
    // need, unrelated marriage, and unobserved residence are world-stage checks.
    internal string? Gate(ActionTerms terms) => terms switch
    {
        Farm => Own.NeedsGrain ? "NeedsGrain" : null,
        OfferGift a => Own.Grain < a.Amount ? "InsufficientAvailableGrain" : null,
        OfferLoan a => Own.Grain < a.Amount ? "InsufficientAvailableGrain" : null,
        OfferBenefitForFavor a => HasFavour(a.Target, Own.Id) ? "FavourCapacityFull" :
            Own.Grain < a.Amount ? "InsufficientAvailableGrain" : null,
        RelationshipMediatedReciprocalHelp { Request: false } a => Own.Grain < a.Amount ? "InsufficientAvailableGrain" : null,
        RepayDebt a => Own.Grain - 2 < a.Amount ? "RepaymentReserveUnavailable" : null,
        ProposeMarriage a => Marriages.Length > 0 || AreKin(a.Bride) ? "NoLongerEligibleForMarriage" :
            AttitudeOf(Own.Id, a.Bride) < 75 || AttitudeOf(a.Bride, Own.Id) < 75 ? "DirectMarriageGateUnavailable" : null,
        MoveResidence a => OwnResidence == a.Destination ? "AlreadyAtDestination" : null,
        InviteResidence a => Policy.ObservedResidences.TryGetValue(a.Target, out DwellingId home) && home == a.Destination ? "AlreadyAtDestination" : null,
        RequestGiftOrHelp or RequestLoan or RelationshipMediatedReciprocalHelp or CallFavor or CancelReciprocalFavours => null,
        _ => throw new InvalidOperationException("Unexpected generated action.")
    };

    internal ImmutableArray<string> TraceInputs() =>
    [
        "InputBoundary:OwnState+DirectPartyRelations+ExplicitPolicyObservations",
        $"OwnId:{Own.Id.Value};OwnSex:{Own.Sex};OwnGrain:{Own.Grain};NeedsGrain:{Own.NeedsGrain};OwnResidence:{OwnResidence.Value};Basis:OwnState",
        $"PolicyProfile:{Policy.Profile};Amount:{Policy.Amount};GiftTarget:{Policy.GiftTarget?.Value};Basis:PolicyParameters",
        $"ObservedPeople:{string.Join(',', Policy.ObservedPeople.OrderBy(p => p.Value).Select(p => p.Value))};Basis:PolicyIdentityBindingsOnly",
        $"ObservedDebts:{string.Join(',', Policy.ObservedDebts.OrderBy(d => d.Value).Select(d => d.Value))};Basis:ExplicitPolicyObservation",
        $"KnownPeople:{string.Join(',', KnownPeople.Select(p => p.Value))}",
        "AbsentDirectPartyRelation:None;AbsentDirectedAttitude:0;UnobservedCounterpartyFact:Unknown",
        .. KnownPeople.Select(p => $"DirectedAttitude:{p.Value}:{AttitudeOf(Own.Id, p)};CounterpartAttitude:{AttitudeOf(p, Own.Id)};Kin:{AreKin(p)};Marriage:{AreMarried(p)};Basis:DirectPartyRelations"),
        .. Attitudes.Select(a => $"Attitude:{a.Id.Value};From:{a.From.Value};To:{a.To.Value};Value:{a.Value};Basis:DirectPartyRelation"),
        .. Kinships.Select(k => $"Kinship:{k.Id.Value};First:{k.First.Value};Second:{k.Second.Value};Kind:{k.Kind};Basis:DirectPartyRelation"),
        .. Marriages.Select(m => $"Marriage:{m.Id.Value};Groom:{m.Groom.Value};Bride:{m.Bride.Value};Origin:{m.Origin?.Value};Basis:DirectPartyRelation"),
        .. Debts.Select(d => $"Debt:{d.Id.Value};Creditor:{d.Creditor.Value};Debtor:{d.Debtor.Value};Original:{d.Original};Remaining:{d.Remaining};CommittedCycle:{d.CommittedCycle};DueReviewed:{d.DueReviewed};Origin:{d.Origin.Value};Basis:{(d.Creditor == Own.Id || d.Debtor == Own.Id ? "DirectPartyClaim" : "ExplicitPolicyObservation")}"),
        .. Favours.Select(f => $"Favour:{f.Id.Value};Debtor:{f.Debtor.Value};Holder:{f.Holder.Value};Outstanding:{f.Outstanding};Origin:{f.Origin.Value};Basis:DirectPartyClaim"),
        .. Policy.ObservedSexes.OrderBy(p => p.Key.Value).Select(p => $"ObservedSex:{p.Key.Value}:{p.Value};Basis:ExplicitPolicyObservation"),
        .. Policy.ObservedResidences.OrderBy(p => p.Key.Value).Select(p => $"ObservedResidence:{p.Key.Value}:{p.Value.Value};Basis:ExplicitPolicyObservation")
    ];
}

// Only this boundary reads world state. The generator, personal gates, scoring,
// and trace receive the resulting immutable view, never the objective snapshot.
internal static class PersonalInputCapture
{
    internal static PersonalDecisionInputs Capture(PersonId actor, PersonalPolicy policy, WorldSnapshot snapshot)
    {
        if (policy.Amount <= 0) throw new ArgumentException("Policy amount must be positive.", nameof(policy));
        if (policy.Profile is not ("SCORE-VP-002" or "SCORE-VP-004" or "SCORE-VP-005" or "SCORE-VP-006" or "SFL-PERSONAL-REFERENCE-v1"))
            throw new ArgumentException("Unsupported personal profile.", nameof(policy));
        if (policy.ObservedDebts.Any(id => !snapshot.Debts.ContainsKey(id)) ||
            policy.ObservedSexes.Values.Any(sex => !Enum.IsDefined(sex)) ||
            policy.ObservedResidences.Values.Any(id => !snapshot.Dwellings.ContainsKey(id)))
            throw new ArgumentException("Invalid policy observation binding.", nameof(policy));
        ImmutableArray<Attitude> attitudes = [.. snapshot.Attitudes.Values.Where(a => a.From == actor || a.To == actor).OrderBy(a => a.Id.Value)];
        ImmutableArray<Kinship> kinships = [.. snapshot.Kinships.Values.Where(k => k.First == actor || k.Second == actor).OrderBy(k => k.Id.Value)];
        ImmutableArray<Marriage> marriages = [.. snapshot.Marriages.Values.Where(m => m.Groom == actor || m.Bride == actor).OrderBy(m => m.Id.Value)];
        ImmutableArray<Debt> debts = [.. snapshot.Debts.Values.Where(d => d.Creditor == actor || d.Debtor == actor || policy.ObservedDebts.Contains(d.Id)).OrderBy(d => d.Id.Value)];
        ImmutableArray<Favour> favours = [.. snapshot.Favours.Values.Where(f => f.Holder == actor || f.Debtor == actor).OrderBy(f => f.Id.Value)];
        HashSet<PersonId> known = [.. policy.ObservedPeople, .. policy.ObservedSexes.Keys, .. policy.ObservedResidences.Keys];
        if (policy.GiftTarget is { } gift) known.Add(gift);
        if (known.Contains(actor)) throw new ArgumentException("Invalid observed actor.", nameof(policy));
        foreach (Attitude a in attitudes) known.UnionWith([a.From, a.To]);
        foreach (Kinship k in kinships) known.UnionWith([k.First, k.Second]);
        foreach (Marriage m in marriages) known.UnionWith([m.Groom, m.Bride]);
        foreach (Debt d in debts) known.UnionWith([d.Creditor, d.Debtor]);
        foreach (Favour f in favours) known.UnionWith([f.Holder, f.Debtor]);
        known.Remove(actor);
        if (known.Any(p => !snapshot.People.ContainsKey(p))) throw new ArgumentException("Invalid observed actor.", nameof(policy));
        return new(snapshot.People[actor], snapshot.HomeOf(actor), policy, [.. known.OrderBy(p => p.Value)],
            attitudes, kinships, marriages, debts, favours);
    }
}
