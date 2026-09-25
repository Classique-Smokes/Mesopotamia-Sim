using System.Collections.Immutable;

namespace Mesopotamia.Sim;

internal static class HouseholdRules
{
    internal static HouseholdId? Target(ActionTerms terms) => terms switch
    {
        NominateHouseholdHead a => a.Household,
        RequestProvisionCommitment a => a.Household,
        AuthorizeOwnProvisionCommitment a => a.Household,
        HouseholdSupport a => a.Household,
        RequestHouseholdSupport a => a.Household,
        ProposeMediatedMarriage a => a.Household,
        RequestHouseholdParticipation a => a.Household,
        InviteHouseholdParticipation a => a.Household,
        EndHouseholdParticipation a => a.Household,
        _ => null
    };
    internal static (HouseholdId Household, PersonId Newcomer, PersonId Bridge)? Entry(Proposal proposal) => proposal.Terms switch
    {
        RequestHouseholdParticipation a => (a.Household, proposal.Actor, a.Bridge),
        InviteHouseholdParticipation a => (a.Household, a.Newcomer, proposal.Actor),
        _ => null
    };
    internal static ImmutableArray<DurableTieEvidence> Ties(WorldSnapshot world, IEnumerable<PersonId> people)
    {
        PersonId[] core = people.OrderBy(p => p.Value).ToArray();
        List<DurableTieEvidence> ties = [];
        for (int i = 0; i < core.Length; i++)
            for (int j = i + 1; j < core.Length; j++)
            {
                PersonId a = core[i], b = core[j];
                List<RelationId> ids = [.. world.Kinships.Values.Where(k => Pair(k.First, k.Second, a, b)).Select(k => k.Id),
                    .. world.Marriages.Values.Where(m => Pair(m.Groom, m.Bride, a, b)).Select(m => m.Id)];
                if (world.AttitudeOf(a, b) >= 75 && world.AttitudeOf(b, a) >= 75)
                    ids.AddRange(world.Attitudes.Values.Where(t => Pair(t.From, t.To, a, b)).Select(t => t.Id));
                if (ids.Count > 0) ties.Add(new(a, b, [.. ids.OrderBy(id => id.Value)]));
            }
        return [.. ties];
    }
    internal static bool Pair(PersonId a, PersonId b, PersonId x, PersonId y) => a == x && b == y || a == y && b == x;
    internal static bool Connected(ImmutableArray<PersonId> core, ImmutableArray<DurableTieEvidence> ties)
    {
        if (core.Length < 2) return false;
        HashSet<PersonId> reached = [core[0]];
        bool changed;
        do
        {
            changed = false;
            foreach (DurableTieEvidence tie in ties)
                if (reached.Contains(tie.First) || reached.Contains(tie.Second))
                {
                    changed |= reached.Add(tie.First);
                    changed |= reached.Add(tie.Second);
                }
        } while (changed);
        return core.All(reached.Contains);
    }
    internal static string? Invalid(Proposal proposal, HouseholdState households)
    {
        if (Target(proposal.Terms) is not { } h) return null;
        return h.Value <= 0 || !households.Households.ContainsKey(h) ? "UnknownHousehold" : null;
    }
    internal static string? Infeasible(Proposal proposal, WorldSnapshot world, HouseholdState households, EpistemicState epistemic)
    {
        if (Target(proposal.Terms) is not { } h) return null;
        if (households.Households[h].Lifecycle == HouseholdLifecycle.Dissolved) return "HouseholdDissolved";
        if (epistemic.Of(proposal.Actor).HouseholdRecognitionOf(h) != RecognitionStatus.Recognized) return "HouseholdNotRecognized";
        if (proposal.Terms is NominateHouseholdHead) return HouseholdHeadRules.Infeasible(proposal, households, epistemic);
        if (HouseholdCollectiveRules.IsCollective(proposal.Terms)) return HouseholdCollectiveRules.Infeasible(proposal, world, households, epistemic);
        SustainingParticipant[] current = households.Current(h);
        if (proposal.Terms is EndHouseholdParticipation)
            return current.Any(a => a.Person == proposal.Actor) ? null : "NotSustainingParticipant";
        var entry = Entry(proposal)!.Value;
        if (current.Any(a => a.Person == entry.Newcomer)) return "AlreadySustainingParticipant";
        if (!current.Any(a => a.Person == entry.Bridge)) return "ContinuityBridgeUnavailable";
        if (epistemic.Of(entry.Newcomer).HouseholdRecognitionOf(h) != RecognitionStatus.Recognized ||
            epistemic.Of(entry.Bridge).HouseholdRecognitionOf(h) != RecognitionStatus.Recognized) return "HouseholdNotRecognized";
        if (!current.Any(a => world.HomeOf(a.Person) == world.HomeOf(entry.Newcomer))) return "HouseholdResidenceUnavailable";
        if (!Ties(world, [entry.Newcomer, .. current.Select(a => a.Person)]).Any(t => t.First == entry.Newcomer || t.Second == entry.Newcomer))
            return "HouseholdDurableTieUnavailable";
        return EntrySupports(households, entry.Household, entry.Newcomer).IsEmpty ? "PostFormationSupportUnavailable" : null;
    }
    internal static ImmutableArray<SupportFact> EntrySupports(HouseholdState state, HouseholdId h, PersonId newcomer)
    {
        HashSet<PersonId> current = [.. state.Current(h).Select(a => a.Person)];
        FormationWarrant formation = state.Formations[state.Households[h].Formation];
        return [.. state.Supports.Values.Where(s => s.Order is { } order && order.CompareTo(formation.Stamp.Time) > 0 &&
            (s.First == newcomer && current.Contains(s.Second) || s.Second == newcomer && current.Contains(s.First)))
            .OrderBy(s => s.Event.Value)];
    }
    // Semantic precedence is a partial order. Only the named bridge exit is delayed;
    // unrelated actions retain the existing deterministic resolution behavior.
    internal static Proposal[] Order(IEnumerable<Proposal> proposals)
    {
        List<Proposal> pending = [.. proposals];
        List<Proposal> ordered = [];
        while (pending.Count > 0)
        {
            Proposal? next = pending.FirstOrDefault(p => !pending.Any(other => Before(other, p)));
            if (next is null) throw new InvalidOperationException("UnresolvedHouseholdSemanticPriority");
            ordered.Add(next); pending.Remove(next);
        }
        return [.. ordered];
    }
    internal static bool Before(Proposal entry, Proposal exit) => Entry(entry) is { } e &&
        exit.Terms is EndHouseholdParticipation end && e.Household == end.Household && e.Bridge == exit.Actor;
}
