namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private Proposal[] OrderAccepted(Proposal[] accepted)
    {
        List<Proposal> remaining = [.. accepted.OrderBy(p => p.Id.Value)], result = [];
        while (remaining.Count > 0)
        {
            Proposal next = remaining.FirstOrDefault(p => !remaining.Any(a => BeforeAccepted(a, p, accepted)))
                ?? throw new InvalidOperationException("UnresolvedHouseholdSemanticPriority");
            result.Add(next); remaining.Remove(next);
        }
        return [.. result];
    }

    private bool BeforeAccepted(Proposal a, Proposal b, Proposal[] accepted)
    {
        if (a.Id == b.Id) return false;
        if (HouseholdRules.Before(a, b)) return true;
        WorldSnapshot world = state.Snapshot(cycle);
        int rankA = MaterialRank(a), rankB = MaterialRank(b);
        if (rankA < rankB && SpendingSources(a).Intersect(SpendingSources(b)).Any()) return true;
        if (a.HeadAttempt is { } transition && b.Terms is EndHouseholdParticipation exit &&
            exit.Household == transition.Role.Household && transition.Cohort.Any(p => p.Person == b.Actor)) return true;
        if (a.CollectiveAttempt is not { } act) return false;
        if (b.HeadAttempt is { } successor && successor.Role.Id == act.Authority.Role) return true;
        if (b.Terms is not EndHouseholdParticipation end || end.Household != act.Authority.Household) return false;
        if (b.Actor == act.Authority.Head) return true;
        int exits = accepted.Count(p => p.Terms is EndHouseholdParticipation e && e.Household == end.Household);
        return households.Current(end.Household).Length - exits < 2;

        IEnumerable<PersonId> SpendingSources(Proposal p) => p.CollectiveAttempt is { Cost: > 0 } spending
            ? HouseholdFunding.Sources(households.Snapshot(cycle), spending.Authority.Household, spending.Private?.Owner)
            : Transfer(p, world) is { } transfer ? [transfer.Giver] : [];
    }

    private static int MaterialRank(Proposal p) => p.CollectiveAttempt is { Cost: > 0 }
        ? p.Terms is HouseholdSupport or RequestHouseholdSupport ? 0 : 1 : 2;
}
