using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public readonly record struct HouseholdId(long Value);
public readonly record struct WarrantId(long Value);
public readonly record struct AssociationId(long Value);
public readonly record struct CommitmentId(long Value);
public enum HouseholdLifecycle { Active, Inactive, Dissolved }
public enum HouseholdLineageKind { DivisionDescendant, ConsolidationDescendant }
public sealed record Household(HouseholdId Id, WarrantId Formation, HouseholdLifecycle Lifecycle, EventId LifecycleEvent, EvidenceOrder LifecycleTime);
public sealed record WarrantStamp(EventId Event, EvidenceOrder Time, string RulesVersion, string ConfigurationVersion);
public sealed record DurableTieEvidence(PersonId First, PersonId Second, ImmutableArray<RelationId> Relations);
public sealed record FormationWarrant(WarrantId Id, HouseholdId Household, CandidateId Candidate,
    ImmutableArray<PersonId> Founders, DwellingId Dwelling, ImmutableArray<DurableTieEvidence> Ties,
    ImmutableArray<SupportFact> Supports, ImmutableArray<CandidateRecognition> Recognition,
    EvidenceOrder EarliestEvidence, WarrantStamp Stamp);
public sealed record SustainingParticipant(AssociationId Id, PersonId Person, HouseholdId Household,
    WarrantId Origin, WarrantId? End);
public sealed record ParticipationWarrant(WarrantId Id, HouseholdId Household, PersonId Newcomer, PersonId Bridge,
    ProposalId Proposal, EventId Acceptance, ImmutableArray<AssociationId> Prior,
    ImmutableArray<Residence> Residences, ImmutableArray<DurableTieEvidence> Ties,
    ImmutableArray<SupportFact> Supports, ImmutableArray<HouseholdRecognition> Recognition, WarrantStamp Stamp);
public sealed record ParticipationEndWarrant(WarrantId Id, HouseholdId Household, PersonId Person,
    AssociationId Association, ProposalId Proposal, WarrantStamp Stamp);
public sealed record ContinuationWarrant(WarrantId Id, HouseholdId Household, WarrantId Previous,
    WarrantId Transition, ImmutableArray<AssociationId> Prior, ImmutableArray<AssociationId> Successor,
    ImmutableArray<PersonId> Bridges, ImmutableArray<HouseholdRecognition> Recognition, WarrantStamp Stamp);
public sealed record FounderLineageSource(PersonId Founder, HouseholdId Predecessor, WarrantId ParticipationEnd);
public sealed record LineageWarrant(WarrantId Id, HouseholdId Successor, WarrantId Formation,
    HouseholdLineageKind Kind, ImmutableHashSet<HouseholdId> Predecessors,
    ImmutableArray<FounderLineageSource> Sources, ImmutableArray<EventId> FreshEvidence, WarrantStamp Stamp);
public sealed record ProvisionFixtureProvenance(string Fixture, string Producer, string OutputIdentity) : ProvisionOrigin;
public sealed record HouseholdProvisionCommitment(CommitmentId Id, PersonId Person, HouseholdId Household,
    AssociationId Association, ProvisionOrigin Provenance, EventId? TerminatedBy);
public sealed record HouseholdRecognition(HouseholdId Household, RecognitionStatus Status, ImmutableArray<KnownFact> Evidence);
public sealed record HouseholdExistenceFact(HouseholdId Household, bool Continues, WarrantId Warrant) : FactualProposition;
public sealed record HeldHouseholdRecognition(HouseholdId Household) : HeldClaim;
public sealed record RequestHouseholdParticipation(HouseholdId Household, PersonId Bridge) : ActionTerms;
public sealed record InviteHouseholdParticipation(HouseholdId Household, PersonId Newcomer) : ActionTerms;
public sealed record EndHouseholdParticipation(HouseholdId Household) : ActionTerms;

/// <summary>Immutable copies of typed authority; all aggregate queries recompute from these records.</summary>
public sealed record HouseholdSnapshot(long Cycle,
    ImmutableDictionary<HouseholdId, Household> Households,
    ImmutableDictionary<WarrantId, FormationWarrant> Formations,
    ImmutableDictionary<AssociationId, SustainingParticipant> Associations,
    ImmutableDictionary<WarrantId, ParticipationWarrant> Entries,
    ImmutableDictionary<WarrantId, ParticipationEndWarrant> Exits,
    ImmutableDictionary<WarrantId, ContinuationWarrant> Continuations,
    ImmutableDictionary<WarrantId, LineageWarrant> Lineages,
    ImmutableDictionary<CommitmentId, HouseholdProvisionCommitment> Commitments)
{
    public ImmutableDictionary<HouseholdHeadRoleId, HouseholdHeadRole> HeadRoles { get; init; } = ImmutableDictionary<HouseholdHeadRoleId, HouseholdHeadRole>.Empty;
    public ImmutableDictionary<EventId, HeadTransition> HeadTransitions { get; init; } = ImmutableDictionary<EventId, HeadTransition>.Empty;
    public ImmutableDictionary<ProvisionProcessKey, ProvisionRefusal> ProvisionRefusals { get; init; } = ImmutableDictionary<ProvisionProcessKey, ProvisionRefusal>.Empty;
    public ImmutableArray<SustainingParticipant> Participants(HouseholdId household) =>
        [.. Associations.Values.Where(a => a.Household == household && a.End is null).OrderBy(a => a.Id.Value)];
    public bool DerivedFrom(HouseholdId successor, HouseholdId predecessor) =>
        Lineages.Values.Any(l => l.Successor == successor && l.Predecessors.Contains(predecessor));
    public bool AncestorOf(HouseholdId ancestor, HouseholdId descendant)
    {
        HashSet<HouseholdId> seen = [];
        Queue<HouseholdId> pending = new([descendant]);
        while (pending.TryDequeue(out HouseholdId next))
            foreach (HouseholdId predecessor in Lineages.Values.Where(l => l.Successor == next).SelectMany(l => l.Predecessors))
            {
                if (predecessor == ancestor) return true;
                if (seen.Add(predecessor)) pending.Enqueue(predecessor);
            }
        return false;
    }
    public static long ExposedCapacity(Person person) => person.NeedsGrain || person.Grain <= 2 ? 0 : person.Grain - 2;
    public long MobilizableCapacity(HouseholdId household, WorldSnapshot world)
    {
        if (!Households.TryGetValue(household, out Household? h) || h.Lifecycle == HouseholdLifecycle.Dissolved) return 0;
        long sum = 0;
        foreach (HouseholdProvisionCommitment commitment in Commitments.Values.Where(c => c.Household == household && c.TerminatedBy is null))
            if (Associations.TryGetValue(commitment.Association, out SustainingParticipant? a) && a.End is null &&
                a.Person == commitment.Person && a.Household == household)
                sum = checked(sum + ExposedCapacity(world.People[commitment.Person]));
        return sum;
    }
}

internal sealed class HouseholdState
{
    internal Dictionary<HouseholdHeadRoleId, HouseholdHeadRole> HeadRoles { get; } = [];
    internal Dictionary<EventId, HeadTransition> HeadTransitions { get; } = [];
    internal Dictionary<ProvisionProcessKey, ProvisionRefusal> ProvisionRefusals { get; } = [];
    private long nextHeadRole = 1;
    internal Dictionary<HouseholdId, Household> Households { get; } = [];
    internal Dictionary<WarrantId, FormationWarrant> Formations { get; } = [];
    internal Dictionary<AssociationId, SustainingParticipant> Associations { get; } = [];
    internal Dictionary<WarrantId, ParticipationWarrant> Entries { get; } = [];
    internal Dictionary<WarrantId, ParticipationEndWarrant> Exits { get; } = [];
    internal Dictionary<WarrantId, ContinuationWarrant> Continuations { get; } = [];
    internal Dictionary<WarrantId, LineageWarrant> Lineages { get; } = [];
    internal Dictionary<CommitmentId, HouseholdProvisionCommitment> Commitments { get; } = [];
    // Committed ordinary support evidence, not reconstructed from observer history or actor reports.
    internal Dictionary<EventId, SupportFact> Supports { get; } = [];
    private long nextHousehold = 1;
    private long nextWarrant = 1;
    private long nextAssociation = 1;
    private long nextCommitment = 1;

    internal HouseholdState() { }
    private HouseholdState(HouseholdState source)
    {
        HeadRoles = new(source.HeadRoles); HeadTransitions = new(source.HeadTransitions); nextHeadRole = source.nextHeadRole;
        ProvisionRefusals = new(source.ProvisionRefusals);
        Households = new(source.Households); Formations = new(source.Formations);
        Associations = new(source.Associations); Entries = new(source.Entries);
        Exits = new(source.Exits); Continuations = new(source.Continuations);
        Lineages = new(source.Lineages); Commitments = new(source.Commitments); Supports = new(source.Supports);
        nextHousehold = source.nextHousehold; nextWarrant = source.nextWarrant;
        nextAssociation = source.nextAssociation; nextCommitment = source.nextCommitment;
    }
    internal HouseholdState Copy() => new(this);
    internal HouseholdHeadRoleId AllocateHeadRole() => new(checked(nextHeadRole++));
    internal HouseholdId AllocateHousehold() => new(checked(nextHousehold++));
    internal WarrantId AllocateWarrant() => new(checked(nextWarrant++));
    internal AssociationId AllocateAssociation() => new(checked(nextAssociation++));
    internal CommitmentId AllocateCommitment() => new(checked(nextCommitment++));
    internal SustainingParticipant[] Current(HouseholdId h) =>
        [.. Associations.Values.Where(a => a.Household == h && a.End is null).OrderBy(a => a.Id.Value)];
    internal HouseholdSnapshot Snapshot(long cycle) => new(cycle, Households.ToImmutableDictionary(), Formations.ToImmutableDictionary(),
        Associations.ToImmutableDictionary(), Entries.ToImmutableDictionary(), Exits.ToImmutableDictionary(),
        Continuations.ToImmutableDictionary(), Lineages.ToImmutableDictionary(), Commitments.ToImmutableDictionary())
    { HeadRoles = HeadRoles.ToImmutableDictionary(), HeadTransitions = HeadTransitions.ToImmutableDictionary(), ProvisionRefusals = ProvisionRefusals.ToImmutableDictionary() };
}

internal static class OrdinarySupport
{
    internal static SupportKind? Kind(string meaning) => meaning switch
    {
        "Gift" => SupportKind.Gift,
        "Help" or "RelationshipMediatedReciprocalHelp" => SupportKind.Help,
        "Loan" => SupportKind.Loan,
        "CalledFavourFulfilled" => SupportKind.FavourFulfilment,
        _ => null
    };
    internal static SupportFact? From(SemanticEvent entry) => Kind(entry.Kind) is { } kind && entry.Participants.Length == 2
        ? new SupportFact(entry.Id, entry.Cycle, entry.Participants[0], entry.Participants[1], kind) { Order = new(entry.Cycle, entry.ReactionIndex) } : null;
}
