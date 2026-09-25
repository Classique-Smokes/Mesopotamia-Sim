using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mesopotamia.Sim;

// Transport only: no live owner retains a reference to these envelopes.
internal sealed record WorldCheckpoint(ImmutableArray<Person> People, ImmutableArray<Dwelling> Dwellings,
    ImmutableArray<Residence> Residences, ImmutableArray<Attitude> Attitudes, ImmutableArray<Kinship> Kinships,
    ImmutableArray<Marriage> Marriages, ImmutableArray<Debt> Debts, ImmutableArray<Favour> Favours, long NextRelation);
internal sealed record ActorFactsCheckpoint(PersonId Actor, ImmutableArray<KnownFact> Facts);
internal sealed record EpistemicCheckpoint(ImmutableArray<ActorFactsCheckpoint> Actors,
    ImmutableArray<CandidateReferent> Candidates, long NextEvidence);
internal sealed record HouseholdCheckpoint(ImmutableArray<Household> Households,
    ImmutableArray<FormationWarrant> Formations, ImmutableArray<SustainingParticipant> Associations,
    ImmutableArray<ParticipationWarrant> Entries, ImmutableArray<ParticipationEndWarrant> Exits,
    ImmutableArray<ContinuationWarrant> Continuations, ImmutableArray<LineageWarrant> Lineages,
    ImmutableArray<HouseholdProvisionCommitment> Commitments, ImmutableArray<SupportFact> Supports,
    ImmutableArray<HouseholdHeadRole> HeadRoles, ImmutableArray<HeadTransition> HeadTransitions,
    ImmutableArray<ProvisionRefusal> ProvisionRefusals, long NextHousehold, long NextWarrant,
    long NextAssociation, long NextCommitment, long NextHeadRole);
internal sealed record ObserverCheckpoint(PersonId Actor, ImmutableArray<ParticipantOutcome> Outcomes);
internal sealed record SimulationCheckpoint(int Format, ImmutableArray<string> Rules, InitialWorld Bootstrap,
    long Cycle, WorldCheckpoint World, EpistemicCheckpoint Epistemic, HouseholdCheckpoint Households,
    ImmutableArray<SemanticEvent> Events, long NextEvent, ImmutableArray<ProposalId> UsedProposals,
    long NextProposal, ImmutableArray<DecisionTrace> Decisions, ImmutableArray<ObserverCheckpoint> Observers);

internal static class CheckpointCodec
{
    internal static readonly JsonSerializerOptions Options = new()
    {
        RespectRequiredConstructorParameters = true,
        RespectNullableAnnotations = true,
        AllowOutOfOrderMetadataProperties = true,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
    };

    internal static byte[] Encode(SimulationCheckpoint checkpoint) => JsonSerializer.SerializeToUtf8Bytes(checkpoint, Options);
    internal static SimulationCheckpoint Decode(ReadOnlySpan<byte> bytes) =>
        JsonSerializer.Deserialize<SimulationCheckpoint>(bytes, Options) ?? throw new InvalidDataException("Missing checkpoint.");
}

public sealed partial class Simulation
{
    /// <summary>Capture a completed, non-faulted runtime cycle. The returned bytes own no live state.</summary>
    public byte[] CaptureCheckpoint()
    {
        if (faulted || cycle <= 0 || published.Cycle != cycle || publishedEpistemic.Cycle != cycle ||
            publishedHouseholds.Cycle != cycle || Challenge != ReactionChallenge.None)
            throw new InvalidOperationException("Checkpoint requires a completed non-faulted stable runtime boundary.");
        return CheckpointCodec.Encode(new(1, [Configuration.RulesVersion, HouseholdRulesVersion, HeadRulesVersion],
            initial, cycle, state.Capture(), epistemic.Capture(), households.Capture(),
            [.. events], nextEvent, [.. usedProposals.OrderBy(p => p.Value)], nextProposal,
            [.. decisionHistory], [.. knowledge.OrderBy(p => p.Key.Value).Select(p => new ObserverCheckpoint(p.Key, [.. p.Value]))]));
    }

    /// <summary>Restore current typed authority without replay, under the identical configuration and rules.</summary>
    public static Simulation RestoreCheckpoint(ReadOnlySpan<byte> checkpoint, Configuration expectedConfiguration)
    {
        ArgumentNullException.ThrowIfNull(expectedConfiguration);
        try
        {
            SimulationCheckpoint value = CheckpointCodec.Decode(checkpoint);
            if (value.Format != 1 || !value.Rules.SequenceEqual(new[] { Configuration.RulesVersion, HouseholdRulesVersion, HeadRulesVersion }) ||
                value.Bootstrap.Configuration != expectedConfiguration)
                throw new InvalidDataException("Checkpoint format, rules or configuration mismatch.");
            CheckpointValidation.Validate(value);
            return new(value);
        }
        catch (Exception error) when (error is JsonException or ArgumentException or OverflowException or NullReferenceException or KeyNotFoundException)
        {
            throw new InvalidDataException("Invalid checkpoint structure or typed state.", error);
        }
    }

    private Simulation(SimulationCheckpoint value)
    {
        initial = value.Bootstrap;
        cycle = value.Cycle;
        state = new(value.World);
        epistemic = new(value.Epistemic);
        households = new(value.Households);
        events.AddRange(value.Events);
        nextEvent = value.NextEvent;
        usedProposals.UnionWith(value.UsedProposals);
        nextProposal = value.NextProposal;
        decisionHistory.AddRange(value.Decisions);
        foreach (ObserverCheckpoint observer in value.Observers) knowledge.Add(observer.Actor, [.. observer.Outcomes]);
        // These are views of the restored partitions, never serialized current authority.
        published = state.Snapshot(cycle);
        publishedEpistemic = epistemic.Snapshot(cycle);
        publishedHouseholds = households.Snapshot(cycle);
    }

    internal void RebuildPublishedState()
    {
        WorldSnapshot world = state.Snapshot(cycle);
        EpistemicSnapshot subjective = epistemic.Snapshot(cycle);
        HouseholdSnapshot household = households.Snapshot(cycle);
        published = world;
        publishedEpistemic = subjective;
        publishedHouseholds = household;
    }
}

internal sealed partial class WorldState
{
    internal WorldCheckpoint Capture() => new([.. People.Values], [.. Dwellings.Values], [.. Residences.Values],
        [.. Attitudes.Values], [.. Kinships.Values], [.. Marriages.Values], [.. Debts.Values], [.. Favours.Values], nextRelation);

    internal WorldState(WorldCheckpoint value)
    {
        People = value.People.ToDictionary(p => p.Id);
        Dwellings = value.Dwellings.ToDictionary(p => p.Id);
        Residences = value.Residences.ToDictionary(p => p.Id);
        Attitudes = value.Attitudes.ToDictionary(p => p.Id);
        Kinships = value.Kinships.ToDictionary(p => p.Id);
        Marriages = value.Marriages.ToDictionary(p => p.Id);
        Debts = value.Debts.ToDictionary(p => p.Id);
        Favours = value.Favours.ToDictionary(p => p.Id);
        nextRelation = value.NextRelation;
        Validate();
    }
}

internal sealed partial class EpistemicState
{
    internal EpistemicCheckpoint Capture() => new([.. facts.Select(p => new ActorFactsCheckpoint(p.Key, [.. p.Value]))],
        candidates, nextEvidence);
    internal EpistemicState(EpistemicCheckpoint value)
    {
        facts = value.Actors.ToDictionary(p => p.Actor, p => p.Facts.ToList());
        candidates = value.Candidates;
        nextEvidence = value.NextEvidence;
    }
}

internal sealed partial class HouseholdState
{
    internal HouseholdCheckpoint Capture() => new([.. Households.Values], [.. Formations.Values], [.. Associations.Values],
        [.. Entries.Values], [.. Exits.Values], [.. Continuations.Values], [.. Lineages.Values], [.. Commitments.Values],
        [.. Supports.Values], [.. HeadRoles.Values], [.. HeadTransitions.Values], [.. ProvisionRefusals.Values],
        nextHousehold, nextWarrant, nextAssociation, nextCommitment, nextHeadRole);

    internal HouseholdState(HouseholdCheckpoint value)
    {
        Households = value.Households.ToDictionary(p => p.Id);
        Formations = value.Formations.ToDictionary(p => p.Id);
        Associations = value.Associations.ToDictionary(p => p.Id);
        Entries = value.Entries.ToDictionary(p => p.Id);
        Exits = value.Exits.ToDictionary(p => p.Id);
        Continuations = value.Continuations.ToDictionary(p => p.Id);
        Lineages = value.Lineages.ToDictionary(p => p.Id);
        Commitments = value.Commitments.ToDictionary(p => p.Id);
        Supports = value.Supports.ToDictionary(p => p.Event);
        HeadRoles = value.HeadRoles.ToDictionary(p => p.Id);
        HeadTransitions = value.HeadTransitions.ToDictionary(p => p.Event);
        ProvisionRefusals = value.ProvisionRefusals.ToDictionary(p => p.Key);
        nextHousehold = value.NextHousehold;
        nextWarrant = value.NextWarrant;
        nextAssociation = value.NextAssociation;
        nextCommitment = value.NextCommitment;
        nextHeadRole = value.NextHeadRole;
    }
}
