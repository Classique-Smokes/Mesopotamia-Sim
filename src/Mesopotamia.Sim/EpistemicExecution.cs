using System.Collections.Immutable;
using System.Text.Json;

namespace Mesopotamia.Sim;

internal static class CommunicationRules
{
    internal static bool Holds(ActorEpistemicState state, HeldClaim claim) => claim switch
    {
        HeldHeadRecognition r => state.HeadRecognitions.Any(h => h.Household == r.Household && h.Status == RecognitionStatus.Recognized),
        HeldFact fact => state.Facts.Any(f => f.Id == fact.Evidence),
        HeldRecognition recognition => state.RecognitionOf(recognition.Candidate) == RecognitionStatus.Recognized,
        HeldHouseholdRecognition recognition => state.HouseholdRecognitionOf(recognition.Household) == RecognitionStatus.Recognized,
        _ => false
    };
    internal static ImmutableArray<KnownFact> Payload(ActorEpistemicState state, HeldClaim claim) => claim switch
    {
        HeldHeadRecognition r => state.HeadRecognitions.Single(h => h.Household == r.Household && h.Status == RecognitionStatus.Recognized).Evidence,
        HeldFact fact => [state.Facts.Single(f => f.Id == fact.Evidence)],
        HeldRecognition recognition => state.Recognitions.Single(r => r.Candidate == recognition.Candidate && r.Status == RecognitionStatus.Recognized).Evidence,
        HeldHouseholdRecognition recognition => state.HouseholdRecognitions.Single(r => r.Household == recognition.Household && r.Status == RecognitionStatus.Recognized).Evidence,
        _ => throw new InvalidOperationException("Unsupported held proposition.")
    };
    internal static bool StillHolds(ActorEpistemicState state, HeldClaim claim, ImmutableArray<KnownFact> captured) =>
        Holds(state, claim) && captured.All(f => state.Facts.Any(current => current.Id == f.Id));
    internal static ImmutableArray<string> Trace(ActorEpistemicState? state, CommunicateClaim? communication)
    {
        if (communication is null) return [];
        bool holds = state is not null && Holds(state, communication.Claim);
        if (communication.Claim is HeldRecognition recognition)
        {
            CandidateRecognition? basis = state?.Recognitions.SingleOrDefault(r => r.Candidate == recognition.Candidate);
            return [$"CommunicationRecipient:{communication.Recipient.Value};Claim:{communication.Claim};Held:{holds};Basis:ActorEpistemicState",
                $"RecognitionStatus:{basis?.Status ?? RecognitionStatus.Unknown};Candidate:{recognition.Candidate.Value}",
                .. basis?.Evidence.Select(f => "EpistemicEvidence:" + JsonSerializer.Serialize(f)) ?? []];
        }
        return [$"CommunicationRecipient:{communication.Recipient.Value};Claim:{communication.Claim};Held:{holds};Basis:ActorEpistemicState",
            .. holds ? Payload(state!, communication.Claim).Select(f => "EpistemicEvidence:" + JsonSerializer.Serialize(f)) : []];
    }
}

public sealed partial class Simulation
{
    private void AcquireInitialFacts()
    {
        foreach (PersonId actor in state.People.Keys.OrderBy(p => p.Value))
            AcquireDirectFacts(epistemic, state, actor, new(actor, null, new(0, 0)));
    }

    private static void AcquireDirectFacts(EpistemicState epistemic, WorldState state, PersonId actor, EvidenceOrigin origin)
    {
        epistemic.Acquire(actor, new OwnStateFact(state.People[actor]), AcquisitionRoute.OwnState, origin);
        Residence residence = state.Residences.Values.Single(r => r.Person == actor);
        epistemic.Acquire(actor, new ResidenceFact(actor, residence.Dwelling), AcquisitionRoute.OwnState, origin);
        foreach (Attitude a in state.Attitudes.Values.Where(a => a.From == actor || a.To == actor).OrderBy(a => a.Id.Value))
            epistemic.Acquire(actor, new AttitudeFact(a), AcquisitionRoute.DirectParty, origin);
        foreach (Kinship k in state.Kinships.Values.Where(k => k.First == actor || k.Second == actor).OrderBy(k => k.Id.Value))
            epistemic.Acquire(actor, new KinshipFact(k), AcquisitionRoute.DirectParty, origin);
        foreach (Marriage m in state.Marriages.Values.Where(m => m.Groom == actor || m.Bride == actor).OrderBy(m => m.Id.Value))
            epistemic.Acquire(actor, new MarriageFact(m), AcquisitionRoute.DirectParty, origin);
        foreach (Debt d in state.Debts.Values.Where(d => d.Creditor == actor || d.Debtor == actor).OrderBy(d => d.Id.Value))
            epistemic.Acquire(actor, new DebtFact(d), AcquisitionRoute.DirectParty, origin);
        foreach (Favour f in state.Favours.Values.Where(f => f.Holder == actor || f.Debtor == actor).OrderBy(f => f.Id.Value))
            epistemic.Acquire(actor, new FavourFact(f), AcquisitionRoute.DirectParty, origin);
    }

    private void AcquireCommittedFacts(SemanticEvent entry)
    {
        AcquireCommittedFacts(epistemic, state, entry);
        if (OrdinarySupport.From(entry) is { } support) households.Supports.TryAdd(entry.Id, support);
        ObserveSupportNeedTransitions(entry);
    }

    private static void AcquireCommittedFacts(EpistemicState epistemic, WorldState state, SemanticEvent entry)
    {
        foreach (PersonId participant in entry.Participants.Distinct().OrderBy(p => p.Value))
        {
            EvidenceOrigin origin = new(participant, entry.Id, new(entry.Cycle, entry.ReactionIndex));
            AcquireDirectFacts(epistemic, state, participant, origin);
            if (OrdinarySupport.From(entry) is { } support)
                epistemic.Acquire(participant, support,
                    AcquisitionRoute.Participation, origin);
        }
    }

    private SemanticEvent CommitCommunication(Proposal proposal, EventId cause, bool fallback, ImmutableArray<KnownFact> payload)
    {
        CommunicateClaim communication = (CommunicateClaim)proposal.Terms;
        // Prepare the recipient's authoritative state before publication; no observer
        // history lookup is used to recover the transmitted proposition or its origin.
        SemanticEvent delivery = new(new(nextEvent), cycle, reactionIndex, "Communication", proposal.Id,
            [proposal.Actor, communication.Recipient], [cause], [], ActionRules.Describe(communication),
            initial.Configuration.Version, fallback)
        { Action = communication, TransmittedEvidence = payload };
        EpistemicState transaction = epistemic.Copy();
        transaction.Receive(proposal.Actor, communication.Recipient, payload, delivery);
        SemanticEvent recorded = Record(delivery.Kind, proposal.Id, delivery.Participants, delivery.Causes, [], delivery.Detail, fallback);
        events[^1] = recorded with
        {
            Action = communication,
            TransmittedEvidence = payload,
            AcquiredEvidence = [.. transaction.Of(communication.Recipient).Facts.Where(f =>
                f.Provenance.Hops.LastOrDefault()?.Event == delivery.Id).Select(f => new AcquiredFact(communication.Recipient, f))]
        };
        epistemic = transaction;
        return events[^1];
    }
}
