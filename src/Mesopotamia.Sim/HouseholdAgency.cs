using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private void DeliberateHouseholds(CycleInput input, WorldSnapshot world, EpistemicSnapshot knowledgeSnapshot,
        List<Proposal> proposals, List<DecisionTrace> decisions)
    {
        foreach (var binding in input.HouseholdPolicies.OrderBy(p => p.Key.Value))
        {
            HouseholdId h = binding.Key; HouseholdPolicy policy = binding.Value;
            if (policy.Profile is not ("SCORE-VP-003" or "SFL-HOUSEHOLD-REFERENCE-v1")) throw new ArgumentException("Unsupported Household profile.", nameof(input));
            if (!households.Households.TryGetValue(h, out Household? household)) throw new ArgumentException("Unknown Household policy binding.", nameof(input));
            HouseholdHeadRole role = households.HeadRoles.Values.Single(r => r.Household == h);
            if (household.Lifecycle != HouseholdLifecycle.Active || role.Occupant is not { } head) continue;
            HouseholdDecisionContext context = new(h, role.Id, head);
            if (proposals.Any(p => p.HouseholdContext?.Household == h)) throw new ArgumentException("Household context already has an initiative.", nameof(input));
            List<ActionTerms> terms = [];
            if (policy.Profile == "SFL-HOUSEHOLD-REFERENCE-v1")
                foreach (PersonId participant in households.Current(h).Select(a => a.Person).OrderBy(p => p.Value))
                {
                    if (world.People[participant].NeedsGrain) terms.Add(new HouseholdSupport(h, participant));
                    if (!households.Commitments.Values.Any(c => c.Household == h && c.Person == participant && c.TerminatedBy is null))
                        terms.Add(participant == head ? new AuthorizeOwnProvisionCommitment(h, true, true) : new RequestProvisionCommitment(h, participant));
                }
            if (policy.NeedRecipient is { } recipient) terms.Add(new HouseholdSupport(h, recipient, policy.Private));
            if (policy.ProvisionTarget is { } target)
                terms.Add(target == head ? new AuthorizeOwnProvisionCommitment(h, true, true) : new RequestProvisionCommitment(h, target));
            List<CandidateTrace> candidates = [];
            foreach (ActionTerms candidate in terms)
            {
                Proposal preview = new(new(0), head, candidate) { HouseholdContext = context };
                string? gate = ActionRules.Invalid(preview, world) ?? HouseholdRules.Infeasible(preview, world, households, epistemic);
                if (gate is null && candidate is HouseholdSupport support)
                    gate = HouseholdFunding.Evaluate(world, households.Snapshot(cycle), context, 1, support.Private, support.Recipient).Failure;
                var components = ImmutableDictionary<string, long>.Empty.Add("NeedReliefConcern", candidate is HouseholdSupport ? 100 : 0)
                    .Add("MarriageConcern", 0).Add("ProvisionBackingConcern", 0);
                candidates.Add(new(ActionRules.Describe(candidate), ActionRules.Describe(candidate), gate is null, gate ?? "", components,
                    gate is null ? ReferenceScorer.Sum(components.Values) : null, false)
                { Terms = candidate });
            }
            var selected = ReferenceScorer.Select(candidates);
            ProposalId? id = null;
            if (selected.Key is not null)
            {
                id = new(checked(nextProposal++));
                proposals.Add(new(id.Value, head, candidates.Single(c => c.Key == selected.Key).Terms!) { HouseholdContext = context });
            }
            decisions.Add(new(head, id, "Household", policy.Profile, [.. candidates.Select(c => c with { Selected = c.Key == selected.Key })],
                [$"Household:{h.Value};Role:{role.Id.Value};Head:{head.Value};Snapshot:{world.Cycle}",
                    .. knowledgeSnapshot.Actors[head].Facts.Where(f => f.Proposition is HeadRoleFact).Select(f => $"HeadEvidence:{f.Id.Value}")], selected.Fallback)
            { HouseholdContext = context });
        }
    }
}
