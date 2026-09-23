namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    // Potential overlap partitions the search; only a witnessed noncommuting
    // exchange authorizes a consequential fallback marker. Actual execution still
    // uses stable IDs and the same immediate revalidation/transaction boundary.
    private HashSet<ProposalId> ResolutionFallbacks(Proposal[] accepted, WorldSnapshot snapshot)
    {
        HashSet<ProposalId> fallback = [];
        List<Proposal> unassigned = [.. accepted.OrderBy(p => p.Id.Value)];
        while (unassigned.Count > 0)
        {
            List<Proposal> component = [unassigned[0]];
            unassigned.RemoveAt(0);
            for (int i = 0; i < component.Count; i++)
                for (int j = unassigned.Count - 1; j >= 0; j--)
                    if (PotentialDependency(component[i], unassigned[j], snapshot))
                    {
                        component.Add(unassigned[j]);
                        unassigned.RemoveAt(j);
                    }
            if (component.Count < 2) continue;
            HashSet<string> visited = new(StringComparer.Ordinal);
            Search(new(state.Copy(), [], "", false), [.. component.OrderBy(p => p.Id.Value)]);

            void Search(ResolutionProjection prefix, Proposal[] remaining)
            {
                string key = string.Join(",", remaining.Select(p => p.Id.Value)) + ":" + ProjectionKey(prefix, snapshot);
                if (!visited.Add(key)) return;
                for (int i = 0; i < remaining.Length; i++)
                    for (int j = i + 1; j < remaining.Length; j++)
                    {
                        Proposal a = remaining[i], b = remaining[j];
                        ResolutionProjection firstA = Project(prefix, a);
                        ResolutionProjection thenB = Project(firstA, b);
                        ResolutionProjection firstB = Project(prefix, b);
                        ResolutionProjection thenA = Project(firstB, a);
                        if (firstA.Outcome != thenA.Outcome || firstB.Outcome != thenB.Outcome ||
                            ProjectionKey(thenB, snapshot) != ProjectionKey(thenA, snapshot))
                        {
                            fallback.Add(a.Id);
                            fallback.Add(b.Id);
                        }
                    }
                foreach (Proposal proposal in remaining)
                {
                    ResolutionProjection next = Project(prefix, proposal);
                    if (!next.Faulted) Search(next, remaining.Where(p => p.Id != proposal.Id).ToArray());
                }
            }
        }
        return fallback;
    }

    private sealed record ResolutionProjection(WorldState State, HashSet<PersonId> Moved, string Outcome, bool Faulted);

    private ResolutionProjection Project(ResolutionProjection prefix, Proposal proposal)
    {
        if (prefix.Faulted) return prefix with { Outcome = "NotReached" };
        string? loss = ResolutionLoss(proposal, prefix.State.Snapshot(cycle), prefix.Moved);
        if (loss is not null) return prefix with { Outcome = "InvalidatedAtResolution:" + loss };
        try
        {
            // Synthetic origins are private to this detached projection, bound to
            // proposal identity, and never consume live event/relation sequences.
            EvaluatedTransaction evaluated = EvaluateTransaction(prefix.State, proposal, cycle, new(-proposal.Id.Value));
            HashSet<PersonId> moved = [.. prefix.Moved];
            if (ActionRules.Mover(proposal) is { } mover) moved.Add(mover);
            return new(evaluated.State, moved, "Committed:" + evaluated.Meaning, false);
        }
        catch (OverflowException)
        {
            // A counterfactual arithmetic fault is not published or executed.
            // The actual selected order retains the existing fail-stop behavior.
            return prefix with { Outcome = "ArithmeticFault", Faulted = true };
        }
    }

    private static string? ResolutionLoss(Proposal proposal, WorldSnapshot snapshot, HashSet<PersonId> moved)
    {
        string? loss = ActionRules.Invalid(proposal, snapshot) ?? ActionRules.Infeasible(proposal, snapshot);
        return ActionRules.Mover(proposal) is { } mover && moved.Contains(mover) ? "CompetingResidenceTransition" : loss;
    }

    private static bool PotentialDependency(Proposal a, Proposal b, WorldSnapshot snapshot) =>
        SharesResidenceDependency(a, b) || SharesMarriageCapacity(a, b) || SharesFavourDependency(a, b, snapshot) ||
        MaterialPeople(a, snapshot).Intersect(MaterialPeople(b, snapshot)).Any();

    private static PersonId[] MaterialPeople(Proposal proposal, WorldSnapshot snapshot) =>
        Transfer(proposal, snapshot) is { } transfer ? [transfer.Giver, transfer.Recipient] :
        EffectiveTerms(proposal) is Farm ? [EffectiveActor(proposal, snapshot)] : [];

    private static string ProjectionKey(ResolutionProjection projection, WorldSnapshot initialSnapshot)
    {
        WorldState value = projection.State;
        // Unchanged facts are omitted. New relation allocation order is not a
        // semantic difference; origin proposal + relation kind identifies them.
        return System.Text.Json.JsonSerializer.Serialize(new
        {
            projection.Faulted,
            People = value.People.Values.OrderBy(p => p.Id.Value).Select(p => new { p.Id, p.Grain, p.NeedsGrain }),
            Residences = value.Residences.Values.OrderBy(r => r.Id.Value),
            Marriages = value.Marriages.Values.Select(m => new
            {
                Key = initialSnapshot.Marriages.ContainsKey(m.Id) ? "existing:" + m.Id.Value : "created:" + m.Origin?.Value,
                m.Groom,
                m.Bride,
                m.Origin
            }).OrderBy(m => m.Key, StringComparer.Ordinal),
            Debts = value.Debts.Values.Select(d => new
            {
                Key = initialSnapshot.Debts.ContainsKey(d.Id) ? "existing:" + d.Id.Value : "created:" + d.Origin.Value,
                d.Creditor,
                d.Debtor,
                d.Original,
                d.Remaining,
                d.CommittedCycle,
                d.DueReviewed,
                d.Origin
            }).OrderBy(d => d.Key, StringComparer.Ordinal),
            Favours = value.Favours.Values.Select(f => new
            {
                Key = initialSnapshot.Favours.ContainsKey(f.Id) ? "existing:" + f.Id.Value : "created:" + f.Origin.Value,
                f.Debtor,
                f.Holder,
                f.Outstanding,
                f.Origin
            }).OrderBy(f => f.Key, StringComparer.Ordinal),
            Moved = projection.Moved.OrderBy(p => p.Value)
        });
    }

    private static ActionTerms EffectiveTerms(Proposal proposal) => proposal.Terms is CallFavor call ? call.Requested : proposal.Terms;
    private static PersonId EffectiveActor(Proposal proposal, WorldSnapshot snapshot) =>
        proposal.Terms is CallFavor call ? snapshot.Favours[call.Favour].Debtor : proposal.Actor;

    private static bool SharesResidenceDependency(Proposal left, Proposal right)
    {
        PersonId? a = ActionRules.Mover(left);
        PersonId? b = ActionRules.Mover(right);
        return a is not null && b is not null && (a == b || a == DestinationOwner(right) || b == DestinationOwner(left));

        static PersonId? DestinationOwner(Proposal proposal) => proposal.Terms switch
        {
            MoveResidence move => move.Target,
            InviteResidence => proposal.Actor,
            _ => null
        };
    }

    private static bool SharesMarriageCapacity(Proposal left, Proposal right) =>
        left.Terms is ProposeMarriage a && right.Terms is ProposeMarriage b &&
        (left.Actor == right.Actor || left.Actor == b.Bride || a.Bride == right.Actor || a.Bride == b.Bride);

    private static bool SharesFavourDependency(Proposal left, Proposal right, WorldSnapshot snapshot)
    {
        Favour[] retiredLeft = Retired(left);
        Favour[] retiredRight = Retired(right);
        var createdLeft = CreatedPair(left);
        var createdRight = CreatedPair(right);
        return retiredLeft.Any(a => retiredRight.Any(b => a.Id == b.Id)) ||
            createdLeft is { } a && retiredRight.Any(f => (f.Debtor, f.Holder) == a) ||
            createdRight is { } b && retiredLeft.Any(f => (f.Debtor, f.Holder) == b) ||
            createdLeft is { } pair && createdRight == pair && !snapshot.HasFavour(pair.Debtor, pair.Holder);

        Favour[] Retired(Proposal proposal) => proposal.Terms switch
        {
            CallFavor call => [snapshot.Favours[call.Favour]],
            CancelReciprocalFavours cancel => [.. snapshot.Favours.Values.Where(f => f.Outstanding &&
                (f.Debtor == proposal.Actor && f.Holder == cancel.Target || f.Holder == proposal.Actor && f.Debtor == cancel.Target))],
            _ => []
        };
        (PersonId Debtor, PersonId Holder)? CreatedPair(Proposal proposal) =>
            Transfer(proposal, snapshot) is { } transfer && (proposal.Terms is OfferBenefitForFavor ||
                proposal.Terms is RelationshipMediatedReciprocalHelp && snapshot.AttitudeOf(transfer.Recipient, transfer.Giver) >= 75)
                ? (transfer.Recipient, transfer.Giver) : null;
    }
}
