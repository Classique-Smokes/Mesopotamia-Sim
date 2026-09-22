using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed record OfferGift(PersonId Target, long Amount) : ActionTerms;
public sealed record RequestGiftOrHelp(PersonId Target, long Amount) : ActionTerms;
public enum ResponseChoice { Accept, Decline, FulfilCalledFavor, RefuseCalledFavor }
public sealed record CandidateTrace(string Key, string Meaning, bool Eligible, string Gate,
    ImmutableDictionary<string, long> Components, long? FinalScore, bool Selected);
public sealed record DecisionTrace(PersonId Actor, ProposalId? Proposal, string Context,
    string Profile, ImmutableArray<CandidateTrace> Candidates, ImmutableArray<string> SubjectiveInputs,
    bool TechnicalFallback);
public sealed record ParticipantOutcome(EventId Event, ProposalId Proposal, OutcomeKind Kind, string Reason);
public sealed record CauseKey(string Rule, EventId Trigger, PersonId From, PersonId To);
public sealed record AttitudeContribution(CauseKey Key, int Delta);

internal sealed class AttitudeBatch
{
    private readonly Dictionary<CauseKey, AttitudeContribution> contributions = [];
    private bool sealedBatch;
    internal int DuplicateCount { get; private set; }
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
    internal static PersonId? Target(ActionTerms terms) => terms switch
    {
        OfferGift gift => gift.Target,
        RequestGiftOrHelp help => help.Target,
        _ => null
    };
    internal static string? Invalid(Proposal proposal, WorldSnapshot snapshot)
    {
        PersonId? target = Target(proposal.Terms);
        if (target is { } person && (person == proposal.Actor || !snapshot.People.ContainsKey(person)))
            return "InvalidCounterparty";
        return proposal.Terms switch
        {
            Farm => null,
            OfferGift gift => gift.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            RequestGiftOrHelp help => help.Amount > 0 ? null : "PositiveIntegralGrainRequired",
            _ => "UnknownActionMeaning"
        };
    }
    internal static string? Infeasible(Proposal proposal, WorldSnapshot snapshot) => proposal.Terms switch
    {
        Farm => snapshot.People[proposal.Actor].NeedsGrain ? "NeedsGrain" : null,
        OfferGift gift => snapshot.People[proposal.Actor].Grain < gift.Amount ? "InsufficientAvailableGrain" : null,
        RequestGiftOrHelp help => snapshot.People[help.Target].Grain < help.Amount ? "InsufficientAvailableGrain" : null,
        _ => "UnsupportedAction"
    };
}
