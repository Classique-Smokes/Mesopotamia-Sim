using System.Collections.Immutable;
using System.Globalization;

namespace Mesopotamia.Sim;

/// <summary>Versioned laboratory configuration; target bindings supply observations, never scores or gate results.</summary>
public sealed record PersonalPolicy(string Profile = "SFL-PERSONAL-REFERENCE-v1")
{
    public ImmutableArray<PersonId> ObservedPeople { get; init; } = [];
    public ImmutableArray<RelationId> ObservedDebts { get; init; } = [];
    public ImmutableDictionary<PersonId, Sex> ObservedSexes { get; init; } = ImmutableDictionary<PersonId, Sex>.Empty;
    public ImmutableDictionary<PersonId, DwellingId> ObservedResidences { get; init; } = ImmutableDictionary<PersonId, DwellingId>.Empty;
    public PersonId? GiftTarget { get; init; }
    public long Amount { get; init; } = 1;
    public CommunicateClaim? Communication { get; init; }
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
    internal static (ActionTerms? Terms, DecisionTrace Trace) Decide(PersonalDecisionInputs inputs)
    {
        PersonId actor = inputs.Own.Id;
        PersonalPolicy policy = inputs.Policy;
        List<(string Key, ActionTerms Terms)> generated = [("00", new Farm())];
        if (policy.Communication is { } communication)
            generated.Add(("15:Communication", communication));
        foreach (PersonId target in inputs.KnownPeople)
        {
            string suffix = target.Value.ToString("D20", CultureInfo.InvariantCulture);
            generated.Add(($"01:{suffix}", new OfferGift(target, policy.Amount)));
            generated.Add(($"02:{suffix}", new RequestGiftOrHelp(target, policy.Amount)));
            generated.Add(($"03:{suffix}", new OfferLoan(target, policy.Amount)));
            generated.Add(($"04:{suffix}", new RequestLoan(target, policy.Amount)));
            generated.Add(($"05:{suffix}", new OfferBenefitForFavor(target, policy.Amount)));
            generated.Add(($"06:{suffix}", new RelationshipMediatedReciprocalHelp(target, policy.Amount)));
            generated.Add(($"07:{suffix}", new RelationshipMediatedReciprocalHelp(target, policy.Amount, Request: true)));
            if (inputs.Own.Sex == Sex.Male && policy.ObservedSexes.TryGetValue(target, out Sex sex) && sex == Sex.Female)
                generated.Add(($"08:{suffix}", new ProposeMarriage(target, policy.Amount)));
            if (inputs.AreMarried(target) || (inputs.AttitudeOf(actor, target) >= 75 && inputs.AttitudeOf(target, actor) >= 75))
            {
                if (policy.ObservedResidences.TryGetValue(target, out DwellingId home))
                    generated.Add(($"10:{suffix}", new MoveResidence(target, home)));
                generated.Add(($"11:{suffix}", new InviteResidence(target, inputs.OwnResidence)));
            }
            if (inputs.HasFavour(actor, target) && inputs.HasFavour(target, actor))
                generated.Add(($"12:{suffix}", new CancelReciprocalFavours(target)));
        }
        foreach (Debt debt in inputs.Debts.Where(d => d.Debtor == actor && d.Remaining > 0))
            generated.Add(($"09:{debt.Id.Value.ToString("D20", CultureInfo.InvariantCulture)}", new RepayDebt(debt.Id, Math.Min(policy.Amount, debt.Remaining))));
        foreach (Favour favour in inputs.Favours.Where(f => f.Holder == actor && f.Outstanding))
        {
            string suffix = favour.Id.Value.ToString("D20", CultureInfo.InvariantCulture);
            generated.Add(($"13:{suffix}", new CallFavor(favour.Id, new Farm())));
            foreach (Debt debt in inputs.Debts.Where(d => d.Debtor == favour.Debtor && d.Remaining > 0))
                generated.Add(($"14:{suffix}:{debt.Id.Value.ToString("D20", CultureInfo.InvariantCulture)}", new CallFavor(favour.Id, new RepayDebt(debt.Id, Math.Min(policy.Amount, debt.Remaining)))));
        }
        List<CandidateTrace> traces = [];
        foreach (var candidate in generated)
        {
            string? gate = inputs.Gate(candidate.Terms);
            ImmutableDictionary<string, long> components = gate is null ? Components(candidate.Terms, inputs) : ImmutableDictionary<string, long>.Empty;
            traces.Add(new(candidate.Key, candidate.Terms.GetType().Name, gate is null, gate ?? "", components,
                gate is null ? ReferenceScorer.Sum(components.Values) : null, false)
            { Terms = candidate.Terms });
        }
        var selection = ReferenceScorer.Select(traces);
        DecisionTrace trace = new(actor, null, "Personal", policy.Profile,
            traces.Select(c => c with { Selected = c.Key == selection.Key }).ToImmutableArray(),
            inputs.TraceInputs(), selection.Fallback);
        return (selection.Key is null ? null : generated.Single(c => c.Key == selection.Key).Terms, trace);
    }

    private static ImmutableDictionary<string, long> Components(ActionTerms terms, PersonalDecisionInputs inputs)
    {
        PersonId actor = inputs.Own.Id;
        PersonalPolicy policy = inputs.Policy;
        PersonId? target = inputs.Target(terms);
        var values = ImmutableDictionary.CreateBuilder<string, long>(StringComparer.Ordinal);
        switch (policy.Profile)
        {
            case "SFL-COMMUNICATION-LAB-v1":
                values.Add("PinnedCommunication", terms is CommunicateClaim ? 100 : 0);
                break;
            case "SCORE-VP-002":
                values.Add("RelationConcern", terms is OfferGift gift && gift.Target == policy.GiftTarget && gift.Amount == 1 ? 100 : 0);
                values.Add("OtherConcern", 0);
                break;
            case "SCORE-VP-004":
                values.Add("AttitudeComponent", target is { } person && terms is not ProposeMarriage ?
                    checked((inputs.AreKin(person) ? 3L : 2L) * inputs.AttitudeOf(actor, person)) : 0);
                values.Add("OtherConcern", 0);
                break;
            case "SCORE-VP-005": values.Add("SymmetryComponent", 0); break;
            case "SCORE-VP-006":
                bool residence = terms is MoveResidence or InviteResidence;
                bool marriage = residence && target is { } partner && inputs.AreMarried(partner);
                values.Add("CoResidenceMarriageConcern", marriage ? 40 : 0);
                values.Add("CoResidenceRelationshipConcern", residence && !marriage ? 20 : 0);
                break;
            default:
                // Replaceable laboratory preferences, not additional social rules.
                values.Add("NeedReliefConcern", inputs.Own.NeedsGrain && terms is RequestGiftOrHelp ? 100 : 0);
                values.Add("GrainConcern", terms is Farm && inputs.Own.Grain < 4 ? 60 : 0);
                values.Add("DebtConcern", terms is RepayDebt ? 30 : 0);
                values.Add("RelationConcern", target is { } other && terms is OfferGift ? checked((inputs.AreKin(other) ? 3L : 2L) * inputs.AttitudeOf(actor, other)) : 0);
                values.Add("MarriageConcern", terms is ProposeMarriage ? 40 : 0);
                values.Add("CoResidenceConcern", terms is MoveResidence or InviteResidence && target is { } resident ? inputs.AreMarried(resident) ? 40 : 20 : 0);
                break;
        }
        return values.ToImmutable();
    }
}
