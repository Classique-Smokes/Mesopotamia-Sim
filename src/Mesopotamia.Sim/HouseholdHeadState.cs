using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public readonly record struct HouseholdHeadRoleId(long Value);
public sealed record HouseholdHeadRole(HouseholdHeadRoleId Id, HouseholdId Household,
    PersonId? Occupant, EventId Origin, EventId LastTransition);
public sealed record HouseholdDecisionContext(HouseholdId Household, HouseholdHeadRoleId Role, PersonId Head);
public enum HeadConsentCapacity { Nominee, Participant }
public sealed record HeadConsentKey(ProposalId Proposal, PersonId Actor, HeadConsentCapacity Capacity);
public sealed record HeadConsent(PersonId Actor, HeadConsentCapacity Capacity, bool Accepted,
    EventId Event, ImmutableArray<KnownFact> RecognitionEvidence);
public sealed record HeadTransition(EventId Event, HouseholdHeadRoleId Role, HouseholdId Household,
    PersonId? Previous, PersonId? Occupant, ProposalId? Proposal, PersonId? Nominator,
    ImmutableArray<SustainingParticipant> Cohort, ImmutableArray<HeadConsent> Consents, WarrantStamp Stamp);
public sealed record HeadRoleFact(HouseholdId Household, HouseholdHeadRoleId Role, PersonId? Occupant,
    EventId Transition, string Scope = "SFL-v0-Household") : FactualProposition;
public sealed record SustainingParticipationFact(HouseholdId Household, AssociationId Association,
    PersonId Person, bool Current, EventId Transition) : FactualProposition;
public sealed record HeadRecognition(HouseholdId Household, HouseholdHeadRoleId? Role, PersonId? Occupant,
    RecognitionStatus Status, ImmutableArray<KnownFact> Evidence);
public sealed record HeldHeadRecognition(HouseholdId Household) : HeldClaim;
public sealed record NominateHouseholdHead(HouseholdId Household, PersonId Nominee,
    bool ParticipantAcceptance, bool NomineeWillingness = false) : ActionTerms;

internal static class HeadRecognitionRules
{
    internal static ImmutableArray<HeadRecognition> Recognize(ImmutableArray<KnownFact> held) =>
        [.. held.Where(f => f.Proposition is HeadRoleFact).GroupBy(f => ((HeadRoleFact)f.Proposition).Household)
            .OrderBy(g => g.Key.Value).Select(g =>
            {
                HeadRoleFact first = (HeadRoleFact)g.First().Proposition;
                bool compatible = g.All(f => f.Proposition is HeadRoleFact h &&
                    h.Role == first.Role && h.Occupant == first.Occupant && h.Scope == first.Scope);
                return new HeadRecognition(g.Key, compatible ? first.Role : null, compatible ? first.Occupant : null,
                    compatible ? RecognitionStatus.Recognized : RecognitionStatus.Contested, [.. g]);
            })];
}
