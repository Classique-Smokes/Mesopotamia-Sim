using System.Collections.Immutable;

namespace Mesopotamia.Sim;

internal sealed record AcceptedCollectiveAttempt(HouseholdDecisionContext Authority, long Cost, PersonId Recipient,
    PrivateGrainAuthorization? Private, EventId Request, EventId Acceptance);

internal static class HouseholdCollectiveRules
{
    internal static bool IsCollective(ActionTerms terms) => terms is RequestProvisionCommitment or AuthorizeOwnProvisionCommitment or
        HouseholdSupport or RequestHouseholdSupport or ProposeMediatedMarriage;

    internal static PersonId? Respondent(Proposal proposal) => proposal.Terms switch
    {
        RequestProvisionCommitment t => t.Contributor,
        RequestHouseholdSupport t => t.Head,
        ProposeMediatedMarriage t => t.Head,
        _ => null
    };

    internal static string? Invalid(Proposal proposal, WorldSnapshot world)
    {
        if (Respondent(proposal) is { } target && (target == proposal.Actor || !world.People.ContainsKey(target))) return "InvalidCounterparty";
        if (proposal.Terms is HouseholdSupport support && (!world.People.ContainsKey(support.Recipient) ||
            support.Private is { } x && (x.Amount <= 0 || x.Amount > 1 || x.Owner != proposal.Actor))) return "InvalidSupportTerms";
        if (proposal.Terms is ProposeMediatedMarriage marriage && (marriage.Dowry <= 0 || !world.People.ContainsKey(marriage.Bride))) return "PositiveIntegralDowryRequired";
        return null;
    }

    internal static HouseholdDecisionContext? Authority(Proposal proposal, HouseholdState households)
    {
        HouseholdId household = HouseholdRules.Target(proposal.Terms)!.Value;
        HouseholdHeadRole? role = households.HeadRoles.Values.SingleOrDefault(r => r.Household == household);
        if (role?.Occupant is not { } head) return null;
        return new(household, role.Id, head);
    }

    internal static ProvisionContext Context(WorldSnapshot world, HouseholdState households, HouseholdId household, PersonId contributor, PersonId head) =>
        new(world.People[contributor].Grain, world.People[contributor].NeedsGrain, world.AttitudeOf(contributor, head), head,
            [.. households.Current(household).Select(a => a.Person).Where(p => world.People[p].NeedsGrain).OrderBy(p => p.Value)]);

    internal static string? Infeasible(Proposal proposal, WorldSnapshot world, HouseholdState households, EpistemicState epistemic)
    {
        HouseholdId household = HouseholdRules.Target(proposal.Terms)!.Value;
        HouseholdDecisionContext? authority = Authority(proposal, households);
        if (authority is null || households.Households[household].Lifecycle != HouseholdLifecycle.Active) return "HouseholdAuthorityUnavailable";
        if (proposal.CollectiveAttempt is { } attempt && attempt.Authority != authority) return "OriginalHeadAuthorityLost";
        if (proposal.Terms is RequestProvisionCommitment or AuthorizeOwnProvisionCommitment or HouseholdSupport)
        {
            if (proposal.HouseholdContext != authority || proposal.Actor != authority.Head) return "HouseholdContextRequired";
        }
        else
        {
            PersonId expected = Respondent(proposal)!.Value;
            if (expected != authority.Head) return "RecognizedHeadNoLongerCurrent";
            HeadRecognition? recognition = epistemic.Of(proposal.Actor).HeadRecognitions.SingleOrDefault(r => r.Household == household);
            if (recognition is null || recognition.Status != RecognitionStatus.Recognized || recognition.Occupant != authority.Head ||
                recognition.Role != authority.Role || recognition.Evidence.Any(f => f.Proposition is not HeadRoleFact { Scope: "SFL-v0-Household" })) return "HeadNotRecognized";
        }
        if (proposal.Terms is RequestProvisionCommitment or AuthorizeOwnProvisionCommitment)
        {
            PersonId contributor = proposal.Terms is RequestProvisionCommitment request ? request.Contributor : proposal.Actor;
            if (!households.Current(household).Any(a => a.Person == contributor)) return "ContributorNotParticipant";
            if (households.Commitments.Values.Any(c => c.Household == household && c.Person == contributor && c.TerminatedBy is null)) return "AlreadyCommitted";
            if (proposal.Terms is AuthorizeOwnProvisionCommitment self && (!self.InstitutionalRequest || !self.PrivateAuthorization)) return "SeparateProvisionAuthorizationRequired";
            if (households.ProvisionRefusals.TryGetValue(new(household, contributor), out var refusal))
            {
                if (world.Cycle - refusal.Cycle <= 3) return "ProvisionCooldown";
                ProvisionContext now = Context(world, households, household, contributor, authority.Head);
                if (now.Grain == refusal.Context.Grain && now.NeedsGrain == refusal.Context.NeedsGrain &&
                    now.Head == refusal.Context.Head && now.AttitudeTowardHead == refusal.Context.AttitudeTowardHead &&
                    refusal.MaterialNeedChange is null) return "ProvisionContextUnchanged";
            }
        }
        if (proposal.Terms is HouseholdSupport or RequestHouseholdSupport)
        {
            PersonId recipient = proposal.Terms is HouseholdSupport support ? support.Recipient : proposal.Actor;
            if (!households.Current(household).Any(a => a.Person == recipient)) return "SupportRecipientNotParticipant";
            if (!world.People[recipient].NeedsGrain) return "SupportRecipientNotNeedy";
        }
        if (proposal.Terms is ProposeMediatedMarriage marriage)
        {
            if (world.People[proposal.Actor].Sex != Sex.Male || world.People[marriage.Bride].Sex != Sex.Female ||
                world.AreKin(proposal.Actor, marriage.Bride) || world.HasMarriage(proposal.Actor) || world.HasMarriage(marriage.Bride)) return "MarriageEligibilityUnavailable";
            if (world.AttitudeOf(proposal.Actor, marriage.Bride) >= 75 && world.AttitudeOf(marriage.Bride, proposal.Actor) >= 75) return "DirectMarriageBypassApplies";
            if (!households.Current(household).Any(a => a.Person == marriage.Bride)) return "BrideParticipationUnavailable";
            var held = epistemic.Of(proposal.Actor).Facts.Where(f => f.Proposition is SustainingParticipationFact p && p.Household == household && p.Person == marriage.Bride).ToArray();
            if (held.Length == 0 || held.Any(f => f.Proposition is not SustainingParticipationFact { Current: true })) return "BrideParticipationNotKnown";
            if (world.HasFavour(proposal.Actor, authority.Head)) return "FavourCapacityFull";
        }
        return null;
    }
}
