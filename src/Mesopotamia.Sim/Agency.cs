using System.Collections.Immutable;
using System.Globalization;

namespace Mesopotamia.Sim;

/// <summary>Versioned laboratory configuration; target bindings supply observations, never scores or gate results.</summary>
public sealed record PersonalPolicy(string Profile = "SFL-PERSONAL-REFERENCE-v1")
{
    public ImmutableArray<PersonId> ObservedPeople { get; init; } = [];
    public ImmutableArray<RelationId> ObservedDebts { get; init; } = [];
    public PersonId? GiftTarget { get; init; }
    public long Amount { get; init; } = 1;
}

internal static class ReferenceScorer
{
    internal static long Sum(IEnumerable<long> components)
    {
        long sum = 0;
        foreach (long component in components) sum = checked(sum + component);
        return sum;
    }

    internal static (string? Key, bool Fallback) Select(IEnumerable<CandidateTrace> candidates)
    {
        CandidateTrace[] eligible = candidates.Where(c => c.Eligible).ToArray();
        if (eligible.Length == 0) return (null, false);
        long maximum = eligible.Max(c => c.FinalScore ?? throw new InvalidOperationException("Eligible candidate lacks score."));
        CandidateTrace[] tied = eligible.Where(c => c.FinalScore == maximum).OrderBy(c => c.Key, StringComparer.Ordinal).ToArray();
        return (tied[0].Key, tied.Length > 1);
    }
}

internal static class PersonalAgency
{
    internal static (ActionTerms? Terms, DecisionTrace Trace) Decide(PersonId actor, PersonalPolicy policy, WorldSnapshot snapshot)
    {
        if (policy.Amount <= 0) throw new ArgumentException("Policy amount must be positive.", nameof(policy));
        if (policy.Profile is not ("SCORE-VP-002" or "SCORE-VP-004" or "SCORE-VP-005" or "SCORE-VP-006" or "SFL-PERSONAL-REFERENCE-v1"))
            throw new ArgumentException("Unsupported personal profile.", nameof(policy));
        HashSet<PersonId> known = [.. policy.ObservedPeople];
        if (policy.GiftTarget is { } giftTarget) known.Add(giftTarget);
        foreach (Attitude attitude in snapshot.Attitudes.Values)
            if (attitude.From == actor || attitude.To == actor) known.Add(attitude.From == actor ? attitude.To : attitude.From);
        foreach (Kinship kinship in snapshot.Kinships.Values)
            if (kinship.First == actor || kinship.Second == actor) known.Add(kinship.First == actor ? kinship.Second : kinship.First);
        foreach (Marriage marriage in snapshot.Marriages.Values)
            if (marriage.Groom == actor || marriage.Bride == actor) known.Add(marriage.Groom == actor ? marriage.Bride : marriage.Groom);
        foreach (Debt debt in snapshot.Debts.Values)
            if (debt.Creditor == actor || debt.Debtor == actor) known.Add(debt.Creditor == actor ? debt.Debtor : debt.Creditor);
        foreach (Favour favour in snapshot.Favours.Values)
            if (favour.Holder == actor || favour.Debtor == actor) known.Add(favour.Holder == actor ? favour.Debtor : favour.Holder);
        if (known.Any(p => p == actor || !snapshot.People.ContainsKey(p))) throw new ArgumentException("Invalid observed actor.", nameof(policy));
        List<(string Key, ActionTerms Terms)> generated = [("00", new Farm())];
        foreach (PersonId target in known.OrderBy(p => p.Value))
        {
            string suffix = target.Value.ToString("D20", CultureInfo.InvariantCulture);
            generated.Add(($"01:{suffix}", new OfferGift(target, policy.Amount)));
            generated.Add(($"02:{suffix}", new RequestGiftOrHelp(target, policy.Amount)));
            generated.Add(($"03:{suffix}", new OfferLoan(target, policy.Amount)));
            generated.Add(($"04:{suffix}", new RequestLoan(target, policy.Amount)));
            generated.Add(($"05:{suffix}", new OfferBenefitForFavor(target, policy.Amount)));
            generated.Add(($"06:{suffix}", new RelationshipMediatedReciprocalHelp(target, policy.Amount)));
            generated.Add(($"07:{suffix}", new RelationshipMediatedReciprocalHelp(target, policy.Amount, Request: true)));
            if (snapshot.People[actor].Sex == Sex.Male && snapshot.People[target].Sex == Sex.Female)
                generated.Add(($"08:{suffix}", new ProposeMarriage(target, policy.Amount)));
            if (snapshot.AreMarried(actor, target) || (snapshot.AttitudeOf(actor, target) >= 75 && snapshot.AttitudeOf(target, actor) >= 75))
            {
                generated.Add(($"10:{suffix}", new MoveResidence(target, snapshot.HomeOf(target))));
                generated.Add(($"11:{suffix}", new InviteResidence(target, snapshot.HomeOf(actor))));
            }
            if (snapshot.HasFavour(actor, target) && snapshot.HasFavour(target, actor))
                generated.Add(($"12:{suffix}", new CancelReciprocalFavours(target)));
        }
        foreach (Debt debt in snapshot.Debts.Values.Where(d => d.Debtor == actor && d.Remaining > 0).OrderBy(d => d.Id.Value))
            generated.Add(($"09:{debt.Id.Value.ToString("D20", CultureInfo.InvariantCulture)}", new RepayDebt(debt.Id, Math.Min(policy.Amount, debt.Remaining))));
        foreach (Favour favour in snapshot.Favours.Values.Where(f => f.Holder == actor && f.Outstanding).OrderBy(f => f.Id.Value))
        {
            string suffix = favour.Id.Value.ToString("D20", CultureInfo.InvariantCulture);
            generated.Add(($"13:{suffix}", new CallFavor(favour.Id, new Farm())));
            foreach (Debt debt in snapshot.Debts.Values.Where(d => d.Debtor == favour.Debtor && d.Remaining > 0 &&
                (d.Creditor == actor || policy.ObservedDebts.Contains(d.Id))).OrderBy(d => d.Id.Value))
                generated.Add(($"14:{suffix}:{debt.Id.Value.ToString("D20", CultureInfo.InvariantCulture)}", new CallFavor(favour.Id, new RepayDebt(debt.Id, Math.Min(policy.Amount, debt.Remaining)))));
        }
        List<CandidateTrace> traces = [];
        foreach (var candidate in generated)
        {
            Proposal proposal = new(new(1), actor, candidate.Terms);
            string? gate = ActionRules.Invalid(proposal, snapshot) ?? ActionRules.Infeasible(proposal, snapshot);
            ImmutableDictionary<string, long> components = gate is null ? Components(actor, candidate.Terms, policy, snapshot) : ImmutableDictionary<string, long>.Empty;
            traces.Add(new(candidate.Key, candidate.Terms.GetType().Name, gate is null, gate ?? "", components,
                gate is null ? ReferenceScorer.Sum(components.Values) : null, false)
            { Terms = candidate.Terms });
        }
        var selection = ReferenceScorer.Select(traces);
        DecisionTrace trace = new(actor, null, "Personal", policy.Profile,
            traces.Select(c => c with { Selected = c.Key == selection.Key }).ToImmutableArray(),
            [$"OwnGrain:{snapshot.People[actor].Grain}", $"NeedsGrain:{snapshot.People[actor].NeedsGrain}",
                $"KnownPeople:{string.Join(',', known.OrderBy(p => p.Value).Select(p => p.Value))}",
                $"OwnResidence:{snapshot.HomeOf(actor).Value}",
                .. known.OrderBy(p => p.Value).Select(p => $"DirectedAttitude:{p.Value}:{snapshot.AttitudeOf(actor, p)};CounterpartAttitude:{snapshot.AttitudeOf(p, actor)};Kin:{snapshot.AreKin(actor, p)};Marriage:{snapshot.AreMarried(actor, p)};Residence:{snapshot.HomeOf(p).Value}")], selection.Fallback);
        return (selection.Key is null ? null : generated.Single(c => c.Key == selection.Key).Terms, trace);
    }

    private static ImmutableDictionary<string, long> Components(PersonId actor, ActionTerms terms, PersonalPolicy policy, WorldSnapshot snapshot)
    {
        // An interpersonal scoring target need not require a new response (repayment/cancellation).
        PersonId? target = terms switch
        {
            RepayDebt repay => snapshot.Debts[repay.Debt].Creditor,
            CancelReciprocalFavours cancel => cancel.Target,
            _ => ActionRules.Target(terms, snapshot)
        };
        var values = ImmutableDictionary.CreateBuilder<string, long>(StringComparer.Ordinal);
        switch (policy.Profile)
        {
            case "SCORE-VP-002":
                values.Add("RelationConcern", terms is OfferGift gift && gift.Target == policy.GiftTarget && gift.Amount == 1 ? 100 : 0);
                values.Add("OtherConcern", 0);
                break;
            case "SCORE-VP-004":
                values.Add("AttitudeComponent", target is { } person && terms is not ProposeMarriage ?
                    checked((snapshot.AreKin(actor, person) ? 3L : 2L) * snapshot.AttitudeOf(actor, person)) : 0);
                values.Add("OtherConcern", 0);
                break;
            case "SCORE-VP-005": values.Add("SymmetryComponent", 0); break;
            case "SCORE-VP-006":
                bool residence = terms is MoveResidence or InviteResidence;
                bool marriage = residence && target is { } partner && snapshot.AreMarried(actor, partner);
                values.Add("CoResidenceMarriageConcern", marriage ? 40 : 0);
                values.Add("CoResidenceRelationshipConcern", residence && !marriage ? 20 : 0);
                break;
            default:
                // Replaceable laboratory preferences, not additional social rules.
                values.Add("NeedReliefConcern", snapshot.People[actor].NeedsGrain && terms is RequestGiftOrHelp ? 100 : 0);
                values.Add("GrainConcern", terms is Farm && snapshot.People[actor].Grain < 4 ? 60 : 0);
                values.Add("DebtConcern", terms is RepayDebt ? 30 : 0);
                values.Add("RelationConcern", target is { } other && terms is OfferGift ? checked((snapshot.AreKin(actor, other) ? 3L : 2L) * snapshot.AttitudeOf(actor, other)) : 0);
                values.Add("MarriageConcern", terms is ProposeMarriage ? 40 : 0);
                values.Add("CoResidenceConcern", terms is MoveResidence or InviteResidence && target is { } resident ? snapshot.AreMarried(actor, resident) ? 40 : 20 : 0);
                break;
        }
        return values.ToImmutable();
    }
}
