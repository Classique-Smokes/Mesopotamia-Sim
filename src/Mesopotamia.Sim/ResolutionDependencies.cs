using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    // Potential overlap partitions the search; only a witnessed noncommuting
    // exchange authorizes a consequential fallback marker. Actual execution still
    // uses stable IDs and the same immediate revalidation/transaction boundary.
    private HashSet<ProposalId> ResolutionFallbacks(Proposal[] accepted, WorldSnapshot snapshot,
        IReadOnlyDictionary<ProposalId, ImmutableArray<KnownFact>> communicationPayloads)
    {
        if (households.Households.Count > 0 || accepted.Any(p => HouseholdRules.Target(p.Terms) is not null))
            return HouseholdResolutionFallbacks(accepted, communicationPayloads);
        return OrdinaryResolutionFallbacks(accepted, snapshot, communicationPayloads);
    }

    private HashSet<ProposalId> OrdinaryResolutionFallbacks(Proposal[] accepted, WorldSnapshot snapshot,
        IReadOnlyDictionary<ProposalId, ImmutableArray<KnownFact>> communicationPayloads)
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
            Search(new(state.Copy(), [], "", false, component.Any(p => p.Terms is CommunicateClaim) ? epistemic.Copy() : null), [.. component.OrderBy(p => p.Id.Value)]);

            void Search(ResolutionProjection prefix, Proposal[] remaining)
            {
                string key = string.Join(",", remaining.Select(p => p.Id.Value)) + ":" + ProjectionKey(prefix, snapshot);
                if (!visited.Add(key)) return;
                for (int i = 0; i < remaining.Length; i++)
                    for (int j = i + 1; j < remaining.Length; j++)
                    {
                        Proposal a = remaining[i], b = remaining[j];
                        ResolutionProjection firstA = Project(prefix, a, communicationPayloads);
                        ResolutionProjection thenB = Project(firstA, b, communicationPayloads);
                        ResolutionProjection firstB = Project(prefix, b, communicationPayloads);
                        ResolutionProjection thenA = Project(firstB, a, communicationPayloads);
                        if (firstA.Outcome != thenA.Outcome || firstB.Outcome != thenB.Outcome ||
                            ProjectionKey(thenB, snapshot) != ProjectionKey(thenA, snapshot))
                        {
                            fallback.Add(a.Id);
                            fallback.Add(b.Id);
                        }
                    }
                foreach (Proposal proposal in remaining)
                {
                    ResolutionProjection next = Project(prefix, proposal, communicationPayloads);
                    if (!next.Faulted) Search(next, remaining.Where(p => p.Id != proposal.Id).ToArray());
                }
            }
        }
        return fallback;
    }

    private sealed record ResolutionProjection(WorldState State, HashSet<PersonId> Moved, string Outcome, bool Faulted,
        EpistemicState? Epistemic, int Steps = 0);

    private ResolutionProjection Project(ResolutionProjection prefix, Proposal proposal,
        IReadOnlyDictionary<ProposalId, ImmutableArray<KnownFact>> communicationPayloads)
    {
        if (prefix.Faulted) return prefix with { Outcome = "NotReached" };
        string? loss = ResolutionLoss(proposal, prefix.State.Snapshot(cycle), prefix.Moved);
        if (loss is null && proposal.Terms is CommunicateClaim check &&
            !CommunicationRules.StillHolds(prefix.Epistemic!.Of(proposal.Actor), check.Claim, communicationPayloads[proposal.Id]))
            loss = "PropositionNoLongerHeld";
        if (loss is not null) return prefix with { Outcome = "InvalidatedAtResolution:" + loss };
        try
        {
            EpistemicState? projected = prefix.Epistemic?.Copy();
            if (proposal.Terms is CommunicateClaim communication)
            {
                SemanticEvent delivery = new(new(-proposal.Id.Value), cycle, reactionIndex + prefix.Steps, "Communication", proposal.Id,
                    [proposal.Actor, communication.Recipient], [], [], "", initial.Configuration.Version);
                projected!.Receive(proposal.Actor, communication.Recipient, communicationPayloads[proposal.Id], delivery);
                return prefix with { Epistemic = projected, Outcome = "Committed:Communication", Steps = prefix.Steps + 1 };
            }
            // Synthetic origins are private to this detached projection, bound to
            // proposal identity, and never consume live event/relation sequences.
            EvaluatedTransaction evaluated = EvaluateTransaction(prefix.State, proposal, cycle, new(-proposal.Id.Value));
            if (projected is not null)
            {
                AcquireCommittedFacts(projected, evaluated.State, new(new(-proposal.Id.Value), cycle, reactionIndex + prefix.Steps,
                    evaluated.Meaning, proposal.Id, [.. evaluated.Participants], [], [], "", initial.Configuration.Version));
                if (evaluated.CalledFavour is { } called)
                    AcquireCommittedFacts(projected, evaluated.State, new(new(-proposal.Id.Value), cycle, reactionIndex + prefix.Steps + 1,
                        "CalledFavourFulfilled", proposal.Id, [called.Holder, called.Debtor], [], [], "", initial.Configuration.Version));
            }
            HashSet<PersonId> moved = [.. prefix.Moved];
            if (ActionRules.Mover(proposal) is { } mover) moved.Add(mover);
            return new(evaluated.State, moved, "Committed:" + evaluated.Meaning, false, projected, prefix.Steps + 1);
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

    private bool PotentialDependency(Proposal a, Proposal b, WorldSnapshot snapshot) =>
        SharesEpistemicDependency(a, b, snapshot) ||
        SharesResidenceDependency(a, b) || SharesMarriageCapacity(a, b) || SharesFavourDependency(a, b, snapshot) ||
        MaterialPeople(a, snapshot).Intersect(MaterialPeople(b, snapshot)).Any();

    private PersonId[] MaterialPeople(Proposal proposal, WorldSnapshot snapshot) =>
        proposal.CollectiveAttempt is { Cost: > 0 } a ? [.. HouseholdFunding.Participants(households.Snapshot(cycle), a.Authority.Household, a.Authority.Head, a.Recipient)] :
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
            Moved = projection.Moved.OrderBy(p => p.Value),
            Epistemic = projection.Epistemic?.Snapshot(0).Actors.OrderBy(p => p.Key.Value).Select(p => new
            {
                p.Key,
                Facts = p.Value.Facts.Select(f => System.Text.Json.JsonSerializer.Serialize(new
                {
                    f.Proposition,
                    f.Provenance.Route,
                    f.Provenance.Origin.Source,
                    f.Provenance.Origin.Event,
                    f.Provenance.Origin.Fixture,
                    Hops = f.Provenance.Hops.Select(h => new { h.Sender, h.Recipient })
                })).Order(StringComparer.Ordinal),
                Recognition = p.Value.Recognitions.Select(r => new { r.Candidate, r.Status })
            })
        });
    }

    private static ActionTerms EffectiveTerms(Proposal proposal) => proposal.Terms is CallFavor call ? call.Requested : proposal.Terms;
    private static bool SharesEpistemicDependency(Proposal a, Proposal b, WorldSnapshot snapshot)
    {
        if (a.Terms is not CommunicateClaim && b.Terms is not CommunicateClaim) return false;
        if (a.Terms is CommunicateClaim left && b.Terms is CommunicateClaim right)
            return left.Recipient == b.Actor || right.Recipient == a.Actor || left.Recipient == right.Recipient;
        Proposal message = a.Terms is CommunicateClaim ? a : b;
        Proposal action = a.Terms is CommunicateClaim ? b : a;
        PersonId recipient = ((CommunicateClaim)message.Terms).Recipient;
        // Direct-party updates can displace a captured sender fact or supersede
        // recipient evidence. The detached projection decides actual commutativity.
        HashSet<PersonId> participants = [action.Actor];
        if (ActionRules.Target(action.Terms, snapshot) is { } target) participants.Add(target);
        if (action.Terms is RepayDebt repay) participants.Add(snapshot.Debts[repay.Debt].Creditor);
        if (action.Terms is CallFavor { Requested: RepayDebt repayment }) participants.Add(snapshot.Debts[repayment.Debt].Creditor);
        return participants.Contains(message.Actor) || participants.Contains(recipient);
    }
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
