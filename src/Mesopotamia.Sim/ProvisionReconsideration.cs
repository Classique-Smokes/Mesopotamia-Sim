using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    // DEC-0014: bounded state inside each refusal baseline, not a pending-demand system.
    private ImmutableArray<AssociationId> EligibleSupportCohort(HouseholdId h)
    {
        if (households.Households[h].Lifecycle != HouseholdLifecycle.Active ||
            !households.HeadRoles.Values.Any(r => r.Household == h && r.Occupant is not null)) return [];
        return [.. households.Current(h).Where(a => state.People[a.Person].NeedsGrain).Select(a => a.Id).OrderBy(id => id.Value)];
    }

    private void ObserveSupportNeedTransitions(SemanticEvent cause)
    {
        foreach (var pair in households.ProvisionRefusals.ToArray())
        {
            ProvisionRefusal refusal = pair.Value;
            ImmutableArray<AssociationId> current = EligibleSupportCohort(pair.Key.Household);
            AssociationId? onset = current.Except(refusal.EligibleSupportCohort).Select(id => (AssociationId?)id).FirstOrDefault();
            HouseholdMaterialNeedOccurrence? occurrence = refusal.MaterialNeedChange;
            if (occurrence is null && onset is { } association)
            {
                HouseholdHeadRole role = households.HeadRoles.Values.Single(r => r.Household == pair.Key.Household);
                occurrence = new(HouseholdMaterialNeedKind.SupportOnset, new(role.Household, role.Id, role.Occupant!.Value),
                    households.Associations[association].Person, association, cause.Id, new(cause.Cycle, cause.ReactionIndex), null, []);
            }
            households.ProvisionRefusals[pair.Key] = refusal with { EligibleSupportCohort = current, MaterialNeedChange = occurrence };
            if (refusal.MaterialNeedChange is null && occurrence is not null) RecordNeedChange(refusal, occurrence);
        }
    }

    private void ObserveDowryNeeds(IEnumerable<HouseholdMaterialNeedOccurrence> occurrences,
        IReadOnlyDictionary<ProvisionProcessKey, EventId> decisionBaselines)
    {
        foreach (var occurrence in occurrences)
            foreach (var pair in households.ProvisionRefusals.Where(p => p.Key.Household == occurrence.Authority.Household).ToArray())
                if (pair.Value.MaterialNeedChange is null && decisionBaselines.TryGetValue(pair.Key, out EventId baseline) && baseline == pair.Value.Event)
                {
                    households.ProvisionRefusals[pair.Key] = pair.Value with { MaterialNeedChange = occurrence };
                    RecordNeedChange(pair.Value, occurrence);
                }
    }

    private void RecordNeedChange(ProvisionRefusal refusal, HouseholdMaterialNeedOccurrence occurrence)
    {
        SemanticEvent e = Record("HouseholdProvisionContextChanged", null, [], [refusal.Event, occurrence.Cause], [],
            occurrence.Kind.ToString(), rulesVersion: HeadRulesVersion);
        events[^1] = e with { ProvisionNeedUpdate = new(refusal.Key, refusal.Event, occurrence) };
    }
}
