using System.Collections.Immutable;

namespace Mesopotamia.Sim;

internal sealed record AcceptedHeadAttempt(HouseholdHeadRole Role,
    ImmutableArray<SustainingParticipant> Cohort, ImmutableArray<HeadConsent> Consents);

internal static class HouseholdHeadRules
{
    internal static string? Infeasible(Proposal proposal, HouseholdState households, EpistemicState epistemic)
    {
        NominateHouseholdHead terms = (NominateHouseholdHead)proposal.Terms;
        HouseholdHeadRole role = households.HeadRoles.Values.Single(r => r.Household == terms.Household);
        SustainingParticipant[] current = households.Current(terms.Household);
        if (!current.Any(a => a.Person == proposal.Actor)) return "NominatorNotParticipant";
        if (!current.Any(a => a.Person == terms.Nominee)) return "NomineeNotParticipant";
        if (role.Occupant is { } occupant && occupant != proposal.Actor) return "NotOutgoingHead";
        if (role.Occupant == terms.Nominee) return "AlreadyHead";
        if (proposal.HouseholdContext is { } context && (context.Household != terms.Household ||
            context.Role != role.Id || context.Head != proposal.Actor || role.Occupant != context.Head ||
            households.Households[terms.Household].Lifecycle != HouseholdLifecycle.Active)) return "HouseholdAuthorityUnavailable";
        if (proposal.HeadAttempt is { } captured)
        {
            if (captured.Role != role) return "RoleAuthorityChanged";
            foreach (SustainingParticipant participant in captured.Cohort)
                if (!households.Associations.TryGetValue(participant.Id, out var live) || live != participant || live.End is not null)
                    return "CapturedParticipantIneligible";
        }
        IEnumerable<SustainingParticipant> cohort = proposal.HeadAttempt?.Cohort ?? [.. current];
        return cohort.Any(a => epistemic.Of(a.Person).HouseholdRecognitionOf(terms.Household) != RecognitionStatus.Recognized)
            ? "ParticipantHouseholdNotRecognized" : null;
    }
}

public sealed partial class Simulation
{
    private const string HeadRulesVersion = "SFL-S4-v1";

    private (Proposal Proposal, EventId Cause)? AcceptHeadNomination(Proposal proposal, EventId nomination,
        CycleInput input, EpistemicSnapshot snapshot, List<DecisionTrace> decisions, List<Outcome> outcomes)
    {
        NominateHouseholdHead terms = (NominateHouseholdHead)proposal.Terms;
        HouseholdHeadRole role = households.HeadRoles.Values.Single(r => r.Household == terms.Household);
        ImmutableArray<SustainingParticipant> cohort = [.. households.Current(terms.Household).OrderBy(a => a.Person.Value)];
        List<HeadConsent> consents = [];
        foreach (SustainingParticipant participant in cohort)
        {
            PersonId actor = participant.Person;
            ImmutableArray<KnownFact> evidence = snapshot.Actors[actor].HouseholdRecognitions.Single(r => r.Household == terms.Household).Evidence;
            if (actor == proposal.Actor)
            {
                consents.Add(new(actor, HeadConsentCapacity.Participant, terms.ParticipantAcceptance, nomination, evidence));
                if (actor == terms.Nominee) consents.Add(new(actor, HeadConsentCapacity.Nominee, terms.NomineeWillingness, nomination, evidence));
                continue;
            }
            string profile = input.ProposalResponseProfiles.GetValueOrDefault(proposal.Id,
                input.ResponseProfiles.GetValueOrDefault(actor, "SCORE-RP-001"));
            if (profile is not ("SCORE-RP-001" or "SCORE-RP-002")) throw new ArgumentException("Unsupported head consent profile.", nameof(input));
            bool participantAccepts = Choice(HeadConsentCapacity.Participant);
            bool nomineeAccepts = actor != terms.Nominee || Choice(HeadConsentCapacity.Nominee);
            SemanticEvent response = Record("HeadConsent", proposal.Id, [actor], [nomination], [],
                $"Participant:{participantAccepts};Nominee:{(actor == terms.Nominee ? nomineeAccepts : null)}", rulesVersion: HeadRulesVersion);
            consents.Add(new(actor, HeadConsentCapacity.Participant, participantAccepts, response.Id, evidence));
            if (actor == terms.Nominee) consents.Add(new(actor, HeadConsentCapacity.Nominee, nomineeAccepts, response.Id, evidence));
            decisions.Add(new(actor, proposal.Id, "HeadConsentResponse", profile,
                [Candidate("Accept", participantAccepts && nomineeAccepts, profile == "SCORE-RP-001" ? 100 : 0),
                    Candidate("Decline", !participantAccepts || !nomineeAccepts, profile == "SCORE-RP-002" ? 100 : 0)],
                [.. evidence.Select(f => $"HouseholdEvidence:{f.Id.Value}")], false));
            bool Choice(HeadConsentCapacity capacity) => input.HeadConsents.GetValueOrDefault(new(proposal.Id, actor, capacity), profile == "SCORE-RP-001");
            static CandidateTrace Candidate(string meaning, bool selected, long score) => new(meaning, meaning, true, "",
                ImmutableDictionary<string, long>.Empty.Add("ResponsePreference", score), score, selected);
        }
        Proposal accepted = proposal with { HeadAttempt = new(role, cohort, [.. consents]) };
        if (consents.Any(c => !c.Accepted))
        {
            Finish(accepted, OutcomeKind.Declined, "RequiredHeadConsentMissing", consents.Last().Event, outcomes);
            return null;
        }
        return (accepted, consents.Last().Event);
    }

    private SemanticEvent CommitHead(Proposal proposal, EventId cause, bool fallback)
    {
        NominateHouseholdHead terms = (NominateHouseholdHead)proposal.Terms;
        AcceptedHeadAttempt attempt = proposal.HeadAttempt ?? throw new InvalidOperationException("HeadConsentNotCaptured");
        HouseholdState transaction = households.Copy();
        EpistemicState information = epistemic.Copy();
        SemanticEvent e = new(new(nextEvent), cycle, reactionIndex, "HouseholdHeadAppointed", proposal.Id,
            [.. attempt.Cohort.Select(a => a.Person)], [.. attempt.Consents.Select(c => c.Event).Append(cause).Distinct()], [],
            $"Household:{terms.Household.Value};Role:{attempt.Role.Id.Value};Head:{terms.Nominee.Value}", initial.Configuration.Version, fallback)
        { Action = terms, HouseholdContext = proposal.HouseholdContext, RulesVersion = HeadRulesVersion };
        HeadTransition transition = new(e.Id, attempt.Role.Id, terms.Household, attempt.Role.Occupant, terms.Nominee,
            proposal.Id, proposal.Actor, attempt.Cohort, attempt.Consents,
            new(e.Id, new(cycle, reactionIndex), HeadRulesVersion, initial.Configuration.Version));
        transaction.HeadRoles[attempt.Role.Id] = attempt.Role with { Occupant = terms.Nominee, LastTransition = e.Id };
        transaction.HeadTransitions.Add(e.Id, transition);
        List<AcquiredFact> receipts = [];
        foreach (PersonId person in e.Participants)
        {
            information.Acquire(person, new HeadRoleFact(terms.Household, attempt.Role.Id, terms.Nominee, e.Id), AcquisitionRoute.Participation,
                new(person, e.Id, new(cycle, reactionIndex)));
            receipts.AddRange(information.Of(person).Facts.Where(f => f.Proposition is HeadRoleFact fact && fact.Transition == e.Id).Select(f => new AcquiredFact(person, f)));
        }
        Record(e.Kind, proposal.Id, e.Participants, e.Causes, [], e.Detail, fallback, HeadRulesVersion);
        events[^1] = e with { HeadTransition = transition, AcquiredEvidence = [.. receipts] };
        households = transaction; epistemic = information;
        return events[^1];
    }

    private void VacateHead(HouseholdId household, PersonId person, SemanticEvent cause)
    {
        HouseholdHeadRole role = households.HeadRoles.Values.Single(r => r.Household == household);
        if (role.Occupant != person) return;
        SemanticEvent e = Record("HouseholdHeadVacated", cause.Proposal, [person], [cause.Id, role.LastTransition], [],
            $"Household:{household.Value};Role:{role.Id.Value}", rulesVersion: HeadRulesVersion);
        HeadTransition transition = new(e.Id, role.Id, household, person, null, cause.Proposal, null, [], [],
            new(e.Id, new(cycle, e.ReactionIndex), HeadRulesVersion, initial.Configuration.Version));
        households.HeadRoles[role.Id] = role with { Occupant = null, LastTransition = e.Id };
        households.HeadTransitions.Add(e.Id, transition);
        epistemic.Acquire(person, new HeadRoleFact(household, role.Id, null, e.Id), AcquisitionRoute.Participation,
            new(person, e.Id, new(cycle, e.ReactionIndex)));
        events[^1] = e with
        {
            HeadTransition = transition,
            AcquiredEvidence = [.. epistemic.Of(person).Facts
            .Where(f => f.Proposition is HeadRoleFact fact && fact.Transition == e.Id).Select(f => new AcquiredFact(person, f))]
        };
    }
}
