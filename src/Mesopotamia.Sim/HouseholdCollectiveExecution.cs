using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private (HouseholdFundingResult? Result, string? Failure) EvaluateFunding(Proposal proposal)
    {
        AcceptedCollectiveAttempt attempt = proposal.CollectiveAttempt ?? throw new InvalidOperationException("CollectiveAcceptanceMissing");
        return HouseholdFunding.Evaluate(state.Snapshot(cycle), households.Snapshot(cycle), attempt.Authority, attempt.Cost, attempt.Private, attempt.Recipient);
    }

    private (Proposal Proposal, EventId Cause)? AcceptCollective(Proposal proposal, EventId request, CycleInput input,
        WorldSnapshot world, EpistemicSnapshot knowledgeSnapshot, List<DecisionTrace> decisions, List<Outcome> outcomes)
    {
        string? failure = HouseholdRules.Infeasible(proposal, world, households, epistemic);
        HouseholdFundingPolicy policy = input.FundingPolicies.GetValueOrDefault(proposal.Id, new());
        long cost = proposal.Terms is ProposeMediatedMarriage marriage ? marriage.Dowry : proposal.Terms is HouseholdSupport or RequestHouseholdSupport ? 1 : 0;
        if (policy.ExactPrivate is { } invalidX && (invalidX <= 0 || invalidX > cost))
        { Finish(proposal, OutcomeKind.InvalidTerms, "InvalidPrivateFundingTerm", request, outcomes); return null; }
        if (failure is not null)
        { Finish(proposal, OutcomeKind.Unable, failure, request, outcomes); return null; }
        HouseholdDecisionContext authority = HouseholdCollectiveRules.Authority(proposal, households)!;
        PersonId recipient = proposal.Terms is HouseholdSupport support ? support.Recipient : proposal.Actor;
        PersonId? respondent = HouseholdCollectiveRules.Respondent(proposal);
        PrivateGrainAuthorization? selected = proposal.Terms is HouseholdSupport s ? s.Private : null;
        List<CandidateTrace> candidates = [];
        Dictionary<string, PrivateGrainAuthorization?> plans = [];
        if (cost > 0)
        {
            List<long?> variants = respondent is null ? [selected?.Amount] : [null];
            if (respondent is not null)
            {
                if (policy.ExactPrivate is { } exact) variants.Add(exact);
                long shortfall = Math.Max(1, cost - households.Snapshot(cycle).MobilizableCapacity(authority.Household, world));
                variants.Add(shortfall); variants.Add(cost);
            }
            foreach (long? x in variants.Distinct())
            {
                PrivateGrainAuthorization? privateTerm = x is { } amount ? new(authority.Head, amount) : null;
                var evaluated = HouseholdFunding.Evaluate(world, households.Snapshot(cycle), authority, cost, privateTerm, recipient);
                string key = x is null ? "Accept:None" : $"Accept:X:{x.Value:D20}";
                long preference = policy.PreferPrivate ? x == policy.ExactPrivate && x is not null ? 30 : x is not null ? 20 : 0 : x is null ? 30 : 10;
                var components = ImmutableDictionary<string, long>.Empty.Add("ResponsePreference", policy.Decline ? 0 : 100).Add("FundingPreference", preference);
                candidates.Add(new(key, "Accept", evaluated.Failure is null, evaluated.Failure ?? "", components,
                    evaluated.Failure is null ? ReferenceScorer.Sum(components.Values) : null, false));
                plans.Add(key, privateTerm);
            }
            if (!candidates.Any(c => c.Eligible))
            { Finish(proposal, OutcomeKind.Unable, "AgreedFundingUnavailable", request, outcomes); return null; }
        }
        EventId acceptance = request;
        if (respondent is { } actor)
        {
            string profile = input.ProposalResponseProfiles.GetValueOrDefault(proposal.Id, input.ResponseProfiles.GetValueOrDefault(actor, "SCORE-RP-001"));
            if (profile is not ("SCORE-RP-001" or "SCORE-RP-002")) throw new ArgumentException("Unsupported collective response profile.", nameof(input));
            bool decline = policy.Decline || profile == "SCORE-RP-002" || input.Responses.GetValueOrDefault(proposal.Id, ResponseChoice.Accept) == ResponseChoice.Decline;
            bool scripted = policy.Decline || input.Responses.ContainsKey(proposal.Id);
            if (input.Responses.TryGetValue(proposal.Id, out var response) && response is not (ResponseChoice.Accept or ResponseChoice.Decline))
                throw new ArgumentException("Response meaning does not belong to collective proposal.", nameof(input));
            if (scripted) decline = policy.Decline || input.Responses.GetValueOrDefault(proposal.Id, ResponseChoice.Accept) == ResponseChoice.Decline;
            if (cost == 0) candidates.Add(new("Accept", "Accept", true, "", ImmutableDictionary<string, long>.Empty.Add("ResponsePreference", 100), 100, false));
            candidates = [.. candidates.Select(c => c with
            {
                Components = c.Components.SetItem("ResponsePreference", decline ? 0 : 100),
                FinalScore = c.Eligible ? ReferenceScorer.Sum(c.Components.SetItem("ResponsePreference", decline ? 0 : 100).Values) : null
            })];
            candidates.Add(new("Decline", "Decline", true, "", ImmutableDictionary<string, long>.Empty.Add("ResponsePreference", decline ? 100 : 0), decline ? 100 : 0, false));
            var choice = ReferenceScorer.Select(candidates);
            candidates = [.. candidates.Select(c => c with { Selected = c.Key == choice.Key })];
            if (choice.Key is not null && plans.TryGetValue(choice.Key, out var chosen)) selected = chosen;
            if (scripted) candidates = [.. candidates.Select(c => c with { Components = ImmutableDictionary<string, long>.Empty, FinalScore = null })];
            decisions.Add(new(actor, proposal.Id, "Response", scripted ? "MECHANISM-RESPONSE-v1" : profile, [.. candidates],
                [$"OwnGrain:{world.People[actor].Grain}", .. knowledgeSnapshot.Actors[actor].Facts.Where(f => f.Proposition is HeadRoleFact).Select(f => $"HeadEvidence:{f.Id.Value}")], choice.Fallback)
            { HouseholdContext = cost > 0 ? authority : null });
            acceptance = Record("Response", proposal.Id, [actor], [request], [], choice.Key!, rulesVersion: HeadRulesVersion).Id;
            if (choice.Key == "Decline")
            {
                Outcome outcome = Finish(proposal, OutcomeKind.Declined, "VoluntaryRefusal", acceptance, outcomes);
                if (proposal.Terms is RequestProvisionCommitment provision)
                    households.ProvisionRefusals[new(authority.Household, provision.Contributor)] = new(new(authority.Household, provision.Contributor), cycle,
                        outcome.Event, HouseholdCollectiveRules.Context(world, households, authority.Household, provision.Contributor, authority.Head));
                return null;
            }
        }
        return (proposal with { CollectiveAttempt = new(authority, cost, recipient, selected, request, acceptance) }, acceptance);
    }

    private SemanticEvent CommitCollective(Proposal proposal, EventId cause, bool fallback)
    {
        AcceptedCollectiveAttempt attempt = proposal.CollectiveAttempt ?? throw new InvalidOperationException("CollectiveAcceptanceMissing");
        WorldState world = state.Copy(); HouseholdState institutional = households.Copy(); EpistemicState information = epistemic.Copy();
        EventId eventId = new(nextEvent);
        List<MaterialChange> material = [];
        string meaning;
        PersonId[] participants;
        if (attempt.Cost == 0)
        {
            PersonId contributor = proposal.Terms is RequestProvisionCommitment t ? t.Contributor : proposal.Actor;
            SustainingParticipant association = institutional.Current(attempt.Authority.Household).Single(a => a.Person == contributor);
            CommitmentId id = institutional.AllocateCommitment();
            ProvisionOrigin origin = proposal.Terms is AuthorizeOwnProvisionCommitment self
                ? new SelfProvisionOrigin(attempt.Authority, proposal.Id, attempt.Request, eventId, self.InstitutionalRequest, self.PrivateAuthorization)
                : new EndogenousProvisionOrigin(attempt.Authority, proposal.Id, attempt.Request, attempt.Acceptance, eventId, contributor);
            institutional.Commitments.Add(id, new(id, contributor, attempt.Authority.Household, association.Id, origin, null));
            meaning = "HouseholdProvisionCommitted"; participants = [.. new[] { attempt.Authority.Head, contributor }.Distinct()];
        }
        else
        {
            HouseholdFundingResult funding = proposal.LiveFunding ?? throw new InvalidOperationException("LiveFundingNotEvaluated");
            Dictionary<PersonId, long> deltas = [];
            foreach (var leg in funding.Commitments) deltas[leg.Person] = checked(deltas.GetValueOrDefault(leg.Person) - leg.Debit);
            if (funding.Private is { } x) deltas[x.Owner] = checked(deltas.GetValueOrDefault(x.Owner) - x.Amount);
            deltas[funding.Recipient] = checked(deltas.GetValueOrDefault(funding.Recipient) + funding.Cost);
            foreach (var delta in deltas.OrderBy(p => p.Key.Value))
            {
                Person before = world.People[delta.Key];
                long after = checked(before.Grain + delta.Value);
                world.People[delta.Key] = before with { Grain = after, NeedsGrain = delta.Key == funding.Recipient ? false : before.NeedsGrain };
                material.Add(new(delta.Key, before.Grain, after, "HouseholdMaterialEffect"));
            }
            if (proposal.Terms is ProposeMediatedMarriage marriage)
            {
                RelationId marriageId = world.AllocateRelation(), favourId = world.AllocateRelation();
                world.Marriages.Add(marriageId, new(marriageId, proposal.Actor, marriage.Bride, eventId));
                world.Favours.Add(favourId, new(favourId, proposal.Actor, attempt.Authority.Head, true, eventId));
                meaning = "HouseholdMediatedMarriage";
                participants = [.. funding.Commitments.Select(l => l.Person).Append(attempt.Authority.Head).Append(proposal.Actor).Append(marriage.Bride).Distinct()];
            }
            else
            { meaning = "HouseholdSupport"; participants = [.. funding.Commitments.Select(l => l.Person).Append(attempt.Authority.Head).Append(funding.Recipient).Distinct()]; }
        }
        world.Validate();
        SemanticEvent e = new(eventId, cycle, reactionIndex, meaning, proposal.Id, [.. participants],
            [.. new[] { attempt.Request, cause }.Distinct()], [.. material], ActionRules.Describe(proposal.Terms), initial.Configuration.Version, fallback)
        { Action = proposal.Terms, HouseholdContext = attempt.Authority, Funding = proposal.LiveFunding, RulesVersion = HeadRulesVersion };
        AcquireCommittedFacts(information, world, e);
        Record(meaning, proposal.Id, e.Participants, e.Causes, e.Material, e.Detail, fallback, HeadRulesVersion);
        events[^1] = e;
        state = world; households = institutional; epistemic = information;
        return e;
    }
}
