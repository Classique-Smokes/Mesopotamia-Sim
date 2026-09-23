using System.Collections.Immutable;
using System.Text.Json;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private static ImmutableArray<string> HouseholdDecisionEvidence(Proposal proposal, EpistemicSnapshot snapshot)
    {
        if (HouseholdRules.Target(proposal.Terms) is not { } h) return [];
        PersonId[] people = HouseholdRules.Entry(proposal) is { } entry ? [entry.Newcomer, entry.Bridge] : [proposal.Actor];
        return [.. people.SelectMany(p => new[] { $"Household:{h.Value};Actor:{p.Value};Recognition:{snapshot.Actors[p].HouseholdRecognitionOf(h)};Basis:ActorEpistemicState" }
            .Concat(snapshot.Actors[p].HouseholdRecognitions.Where(r => r.Household == h).SelectMany(r => r.Evidence).Select(f => "EpistemicEvidence:" + JsonSerializer.Serialize(f))))];
    }

    // Household dependencies include closure, warrants and subjective updates. Replay
    // the bounded component in detached partitions using the same commit semantics.
    // Allocation in these copies never touches any live authoritative sequence.
    private HashSet<ProposalId> HouseholdResolutionFallbacks(Proposal[] accepted,
        IReadOnlyDictionary<ProposalId, ImmutableArray<KnownFact>> payloads)
    {
        HashSet<ProposalId> result = [];
        WorldSnapshot world = state.Snapshot(cycle);
        List<Proposal> unassigned = [.. accepted.OrderBy(p => p.Id.Value)];
        while (unassigned.Count > 0)
        {
            List<Proposal> component = [unassigned[0]];
            unassigned.RemoveAt(0);
            for (int i = 0; i < component.Count; i++)
                for (int j = unassigned.Count - 1; j >= 0; j--)
                    if (PotentialDependency(component[i], unassigned[j], world) || Scope(component[i]).Overlaps(Scope(unassigned[j])))
                    { component.Add(unassigned[j]); unassigned.RemoveAt(j); }
            if (component.Count > 1)
            {
                // Components with no Household/candidate contact retain the inherited
                // ordinary resolver, whose synthetic origins are proposal-bound. A
                // disconnected Household must not turn allocation order into conflict.
                bool householdDependent = component.SelectMany(Scope).Any(s => !s.StartsWith("P:", StringComparison.Ordinal));
                result.UnionWith(householdDependent ? HouseholdResolutionComponent([.. component], payloads) :
                    OrdinaryResolutionFallbacks([.. component], world, payloads));
            }
        }
        return result;

        HashSet<string> Scope(Proposal proposal)
        {
            HashSet<PersonId> people = [proposal.Actor];
            if (ActionRules.Target(proposal.Terms, world) is { } target) people.Add(target);
            people.UnionWith(MaterialPeople(proposal, world));
            HashSet<string> scope = [.. people.Select(p => "P:" + p.Value),
                .. households.Associations.Values.Where(a => people.Contains(a.Person)).Select(a => "H:" + a.Household.Value),
                .. epistemic.Candidates.Where(c => c.Core.Any(people.Contains)).Select(c => "C:" + c.Id.Value)];
            if (HouseholdRules.Target(proposal.Terms) is { } h) scope.Add("H:" + h.Value);
            if (proposal.Terms is CommunicateClaim && payloads.TryGetValue(proposal.Id, out var payload))
                scope.UnionWith(payload.Select(f => f.Proposition).OfType<HouseholdExistenceFact>().Select(f => "H:" + f.Household.Value));
            return scope;
        }
    }

    private HashSet<ProposalId> HouseholdResolutionComponent(Proposal[] accepted,
        IReadOnlyDictionary<ProposalId, ImmutableArray<KnownFact>> payloads)
    {
        HashSet<ProposalId> fallback = [];
        Dictionary<string, (Dictionary<ProposalId, string> Outcomes, string State)> evaluated = new(StringComparer.Ordinal);
        List<Proposal[]> orders = [];
        Enumerate([], [.. accepted.OrderBy(p => p.Id.Value)]);
        foreach (Proposal[] order in orders)
        {
            var first = Evaluate(order);
            for (int i = 0; i + 1 < order.Length; i++)
            {
                if (HouseholdRules.Before(order[i], order[i + 1])) continue;
                Proposal[] swapped = [.. order];
                (swapped[i], swapped[i + 1]) = (swapped[i + 1], swapped[i]);
                var second = Evaluate(swapped);
                if (first.State != second.State || first.Outcomes.Any(o => second.Outcomes[o.Key] != o.Value))
                {
                    fallback.Add(order[i].Id); fallback.Add(order[i + 1].Id);
                }
            }
        }
        return fallback;

        void Enumerate(List<Proposal> prefix, List<Proposal> remaining)
        {
            if (remaining.Count == 0) { orders.Add([.. prefix]); return; }
            foreach (Proposal p in remaining.Where(p => !remaining.Any(other => HouseholdRules.Before(other, p))))
                Enumerate([.. prefix, p], [.. remaining.Where(other => other.Id != p.Id)]);
        }

        (Dictionary<ProposalId, string> Outcomes, string State) Evaluate(Proposal[] order)
        {
            string key = string.Join(',', order.Select(p => p.Id.Value));
            if (evaluated.TryGetValue(key, out var cached)) return cached;
            Simulation projection = new(initial)
            {
                state = state.Copy(),
                epistemic = epistemic.Copy(),
                households = households.Copy(),
                cycle = cycle,
                nextEvent = nextEvent,
                reactionIndex = reactionIndex
            };
            projection.events.AddRange(events);
            Dictionary<ProposalId, string> outcomes = [];
            HashSet<PersonId> moved = [];
            AttitudeBatch batch = new();
            bool arithmeticFault = false;
            foreach (Proposal p in order)
            {
                if (arithmeticFault) { outcomes[p.Id] = "NotReached"; continue; }
                string? loss = ResolutionLoss(p, projection.state.Snapshot(cycle), moved) ?? HouseholdRules.Invalid(p, projection.households) ??
                    HouseholdRules.Infeasible(p, projection.state.Snapshot(cycle), projection.households, projection.epistemic);
                if (loss is null && p.Terms is CommunicateClaim claim && !CommunicationRules.StillHolds(projection.epistemic.Of(p.Actor), claim.Claim, payloads[p.Id]))
                    loss = "PropositionNoLongerHeld";
                if (loss is not null) { outcomes[p.Id] = "InvalidatedAtResolution:" + loss; continue; }
                try
                {
                    EventId cause = events.Last(e => e.Proposal == p.Id).Id;
                    SemanticEvent commit = projection.Commit(p, cause, false, batch, payloads.GetValueOrDefault(p.Id));
                    projection.Learn(p, new(p.Id, p.Actor, OutcomeKind.Committed, "", commit.Id), commit);
                    if (ActionRules.Mover(p) is { } mover) moved.Add(mover);
                    outcomes[p.Id] = "Committed";
                }
                catch (OverflowException) { arithmeticFault = true; outcomes[p.Id] = "ArithmeticFault"; }
            }
            if (!arithmeticFault)
            {
                projection.ReviewDebts(batch); projection.CloseAttitudes(batch); projection.CloseHouseholds();
            }
            var result = (outcomes, HouseholdProjectionKey(projection, arithmeticFault));
            evaluated.Add(key, result);
            return result;
        }
    }

    private static string HouseholdProjectionKey(Simulation projection, bool faulted)
    {
        // Normalize allocated identities through causal origins. Event ordering is
        // retained only where it changes actual accepted evidence or outcomes.
        string EventKey(EventId id)
        {
            SemanticEvent? e = projection.events.SingleOrDefault(e => e.Id == id);
            return e is null ? $"External:{id.Value}" : $"{e.Cycle}:{e.Kind}:{e.Proposal?.Value}:{string.Join(',', e.Participants.Select(p => p.Value).Order())}";
        }
        string HouseholdKey(HouseholdId h) => $"Candidate:{projection.households.Formations[projection.households.Households[h].Formation].Candidate.Value}";
        string Fact(KnownFact f) => f.Proposition switch
        {
            HouseholdExistenceFact h => $"H:{HouseholdKey(h.Household)}:{h.Continues}",
            ParticipationFact p => $"P:{p.Outcome.Proposal.Value}:{p.Outcome.Kind}:{p.Outcome.Reason}",
            SupportFact s => $"S:{EventKey(s.Event)}:{s.Kind}",
            _ => JsonSerializer.Serialize(f.Proposition)
        };
        return JsonSerializer.Serialize(new
        {
            faulted,
            World = ProjectionKey(new(projection.state, [], "", faulted, null), projection.initialSnapshotForProjection()),
            Households = projection.households.Households.Values.Select(h => new
            {
                Key = HouseholdKey(h.Id),
                h.Lifecycle,
                Participants = projection.households.Current(h.Id).Select(a => a.Person.Value).Order(),
                Commitments = projection.households.Commitments.Values.Where(c => c.Household == h.Id).Select(c => new { c.Person, Ended = c.TerminatedBy is not null }).OrderBy(c => c.Person.Value),
                Lineage = projection.households.Lineages.Values.Where(l => l.Successor == h.Id).Select(l => new { l.Kind, Sources = l.Predecessors.Select(HouseholdKey).Order(StringComparer.Ordinal) })
            }).OrderBy(h => h.Key, StringComparer.Ordinal),
            Evidence = projection.epistemic.Snapshot(0).Actors.OrderBy(a => a.Key.Value).Select(a => new
            {
                a.Key,
                Facts = a.Value.Facts.Select(f => $"{Fact(f)}:{f.Provenance.Route}:{f.Provenance.Origin.Source}:{(f.Provenance.Origin.Event is { } e ? EventKey(e) : f.Provenance.Origin.Fixture)}").Order(StringComparer.Ordinal),
                Recognition = a.Value.HouseholdRecognitions.Select(r => new { H = HouseholdKey(r.Household), r.Status }).OrderBy(r => r.H, StringComparer.Ordinal)
            })
        });
    }
    private WorldSnapshot initialSnapshotForProjection() => new WorldState(initial).Snapshot(0);
}
