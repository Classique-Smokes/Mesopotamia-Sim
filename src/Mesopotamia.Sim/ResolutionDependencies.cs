using System.Numerics;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    // This analysis discloses dependencies; it does not choose a social priority or
    // predict winners. Every accepted proposal still undergoes immediate revalidation.
    private static HashSet<ProposalId> ResolutionFallbacks(Proposal[] accepted, WorldSnapshot snapshot)
    {
        HashSet<ProposalId> fallback = [];
        for (int i = 0; i < accepted.Length; i++)
            for (int j = i + 1; j < accepted.Length; j++)
                if (SharesResidenceDependency(accepted[i], accepted[j]) ||
                    SharesMarriageCapacity(accepted[i], accepted[j]) ||
                    SharesFavourDependency(accepted[i], accepted[j], snapshot))
                {
                    fallback.Add(accepted[i].Id);
                    fallback.Add(accepted[j].Id);
                }

        // Capacity is aggregate, not just pairwise: three valid payments may exceed
        // a debt or grain stock even when every pair fits it.
        foreach (var group in accepted.Where(p => EffectiveTerms(p) is RepayDebt)
            .GroupBy(p => ((RepayDebt)EffectiveTerms(p)).Debt))
        {
            BigInteger requested = 0;
            foreach (Proposal proposal in group) requested += ((RepayDebt)EffectiveTerms(proposal)).Amount;
            if (requested > snapshot.Debts[group.Key].Remaining)
                fallback.UnionWith(group.Select(p => p.Id));
        }
        foreach (var group in accepted.Where(p => Transfer(p, snapshot) is not null)
            .GroupBy(p => Transfer(p, snapshot)!.Value.Giver))
        {
            BigInteger requested = 0;
            foreach (Proposal proposal in group) requested += Transfer(proposal, snapshot)!.Value.Amount;
            long reserve = group.Any(p => EffectiveTerms(p) is RepayDebt) ? 2 : 0;
            if (requested <= snapshot.People[group.Key].Grain - reserve) continue;
            fallback.UnionWith(group.Select(p => p.Id));
            // Credits can restore capacity only in some orders. Include both the
            // spenders and their potential enablers, including called Farm effects.
            fallback.UnionWith(accepted.Where(p => Transfer(p, snapshot)?.Recipient == group.Key ||
                EffectiveTerms(p) is Farm && EffectiveActor(p, snapshot) == group.Key).Select(p => p.Id));
        }
        return fallback;
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
