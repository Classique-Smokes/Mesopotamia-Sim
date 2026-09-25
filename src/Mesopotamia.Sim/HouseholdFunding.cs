using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Mesopotamia.Sim;

public sealed record PrivateGrainAuthorization(PersonId Owner, long Amount);
public sealed record RequestProvisionCommitment(HouseholdId Household, PersonId Contributor) : ActionTerms;
public sealed record AuthorizeOwnProvisionCommitment(HouseholdId Household, bool InstitutionalRequest,
    bool PrivateAuthorization) : ActionTerms;
public sealed record HouseholdSupport(HouseholdId Household, PersonId Recipient,
    PrivateGrainAuthorization? Private = null) : ActionTerms;
public sealed record RequestHouseholdSupport(HouseholdId Household, PersonId Head) : ActionTerms;
public sealed record ProposeMediatedMarriage(HouseholdId Household, PersonId Head, PersonId Bride, long Dowry) : ActionTerms;
public sealed record ProvisionProcessKey(HouseholdId Household, PersonId Contributor);
public sealed record ProvisionContext(long Grain, bool NeedsGrain, int AttitudeTowardHead, PersonId Head,
    ImmutableArray<PersonId> NeedyParticipants);
public enum HouseholdMaterialNeedKind { SupportOnset, MediatedDowry }
public sealed record HouseholdMaterialNeedOccurrence(HouseholdMaterialNeedKind Kind, HouseholdDecisionContext Authority,
    PersonId Person, AssociationId? Association, EventId Cause, EvidenceOrder Time, ProposeMediatedMarriage? Dowry,
    ImmutableArray<KnownFact> Evidence);
public sealed record ProvisionNeedUpdate(ProvisionProcessKey Process, EventId Refusal, HouseholdMaterialNeedOccurrence Occurrence);
public sealed record ProvisionRefusal(ProvisionProcessKey Key, long Cycle, EventId Event, ProvisionContext Context)
{
    public ImmutableArray<AssociationId> EligibleSupportCohort { get; init; } = [];
    public HouseholdMaterialNeedOccurrence? MaterialNeedChange { get; init; }
}
[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(ProvisionFixtureProvenance), "controlled-fixture")]
[JsonDerivedType(typeof(EndogenousProvisionOrigin), "endogenous-response")]
[JsonDerivedType(typeof(SelfProvisionOrigin), "head-private-consent")]
public abstract record ProvisionOrigin;
public sealed record EndogenousProvisionOrigin(HouseholdDecisionContext Authority, ProposalId Proposal,
    EventId Request, EventId Acceptance, EventId Created, PersonId Contributor) : ProvisionOrigin;
public sealed record SelfProvisionOrigin(HouseholdDecisionContext Authority, ProposalId Proposal,
    EventId Authorization, EventId Created, bool InstitutionalRequest, bool PrivateAuthorization) : ProvisionOrigin;
public sealed record CommitmentFundingLeg(PersonId Person, CommitmentId Commitment, long Capacity, long Debit);
public sealed record HouseholdFundingResult(HouseholdDecisionContext Authority, long Cost,
    PrivateGrainAuthorization? Private, long Residual, ImmutableArray<CommitmentFundingLeg> Commitments,
    ImmutableArray<PersonId> PossibleParticipants, PersonId Recipient, bool ContributorTie);
public sealed record HouseholdFundingPolicy(long? ExactPrivate = null, bool PreferPrivate = false, bool Decline = false);
public sealed record HouseholdPolicy(string Profile = "SCORE-VP-003")
{
    public PersonId? NeedRecipient { get; init; }
    public PersonId? ProvisionTarget { get; init; }
    public PrivateGrainAuthorization? Private { get; init; }
}

/// <summary>Synthetic v0 personal-grain scaffold. This is not a general economic model.</summary>
internal static class HouseholdFunding
{
    private static IEnumerable<HouseholdProvisionCommitment> ValidCommitments(HouseholdSnapshot households, HouseholdId household) =>
        households.Commitments.Values.Where(c => c.Household == household && c.TerminatedBy is null &&
            households.Associations.TryGetValue(c.Association, out var a) && a.End is null && a.Person == c.Person && a.Household == household);

    internal static ImmutableArray<PersonId> Sources(HouseholdSnapshot households, HouseholdId household, PersonId? privateOwner) =>
        [.. ValidCommitments(households, household).Select(c => c.Person).Concat(privateOwner is { } owner ? [owner] : []).Distinct().OrderBy(p => p.Value)];

    internal static ImmutableArray<PersonId> Participants(HouseholdSnapshot households, HouseholdId household,
        PersonId? privateOwner, PersonId recipient) => [.. Sources(households, household, privateOwner).Append(recipient).Distinct().OrderBy(p => p.Value)];

    internal static (HouseholdFundingResult? Result, string? Failure) Evaluate(WorldSnapshot world,
        HouseholdSnapshot households, HouseholdDecisionContext authority, long cost, PrivateGrainAuthorization? supplement, PersonId recipient)
    {
        if (cost <= 0 || supplement is { Amount: <= 0 } || supplement is not null && supplement.Amount > cost)
            return (null, "PositiveIntegralFundingRequired");
        if (!households.HeadRoles.TryGetValue(authority.Role, out var role) || role.Household != authority.Household ||
            role.Occupant != authority.Head || households.Households[authority.Household].Lifecycle != HouseholdLifecycle.Active)
            return (null, "HouseholdAuthorityUnavailable");
        long x = supplement?.Amount ?? 0;
        if (supplement is not null && supplement.Owner != authority.Head) return (null, "PrivateOwnerNotCurrentHead");
        if (HouseholdSnapshot.ExposedCapacity(world.People[authority.Head]) < x) return (null, "AgreedPrivateFundingUnavailable");
        var capacities = ValidCommitments(households, authority.Household)
            .Select(c => (Commitment: c, Capacity: Math.Max(0, HouseholdSnapshot.ExposedCapacity(world.People[c.Person]) - (c.Person == authority.Head ? x : 0))))
            .OrderByDescending(c => c.Capacity).ThenBy(c => c.Commitment.Person.Value).ToArray();
        if (capacities.Select(c => c.Commitment.Person).Distinct().Count() != capacities.Length)
            throw new InvalidOperationException("DuplicateStandingProvisionAuthority");
        long residual = cost - x, remaining = residual;
        List<CommitmentFundingLeg> legs = [];
        foreach (var item in capacities)
        {
            long debit = Math.Min(remaining, item.Capacity);
            if (debit > 0) legs.Add(new(item.Commitment.Person, item.Commitment.Id, item.Capacity, debit));
            remaining -= debit;
        }
        if (remaining != 0) return (null, "AgreedCommitmentFundingUnavailable");
        bool tie = capacities.Where(c => c.Capacity > 0).GroupBy(c => c.Capacity).Any(g => g.Count() > 1 &&
            legs.Any(l => g.Any(c => c.Commitment.Id == l.Commitment)));
        return (new(authority, cost, supplement, residual, [.. legs],
            Participants(households, authority.Household, supplement?.Owner, recipient), recipient, tie), null);
    }
}
