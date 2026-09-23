using System.Collections.Immutable;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private IEnumerable<Scenario> MarriageResidenceCases()
    {
        yield return new("DirectMarriageBoundaries", ["S1-095-POS", "S1-095-74", "S1-095-KIN", "S1-095-NO-RESIDENCE", "S1-096-MARRIAGE-CONTROL", "S1-BND-ATT-STRONGLIKE"], () =>
        {
            foreach (int a in new[] { 74, 75, 76 })
                foreach (int b in new[] { 74, 75, 76 })
                    foreach (int kin in new[] { 0, 1, 2 })
                    {
                        InitialWorld world = World(20, 20, 20, a, b);
                        if (kin != 0) world = world with { Kinships = [new(new(6), new(1), new(2), kin == 1 ? KinshipKind.ParentChild : KinshipKind.Sibling)] };
                        Simulation sim = Create(world);
                        CycleResult result = sim.RunCycle(new([P(1, 1, new ProposeMarriage(new(2), 1))]));
                        bool eligible = a >= 75 && b >= 75 && kin == 0;
                        Equal(eligible ? OutcomeKind.Committed : OutcomeKind.Unable, result.Outcomes.Single().Kind);
                        Equal(eligible ? 1 : 0, result.State.Marriages.Count);
                        Equal(new DwellingId(1), result.State.HomeOf(new(1)));
                        Equal(new DwellingId(2), result.State.HomeOf(new(2)));
                        Equal(19L, Grain(result, 1));
                        Equal(19L, Grain(result, 2));
                        Equal(0, result.State.Favours.Count);
                        if (eligible) Equal(0, result.Events.Single(e => e.Kind == "DirectMarriage").Material.Length);
                    }
        });
        yield return new("MarriageDeclineAndLifetime", ["S1-095-LIFETIME", "S1-BND-MARRIAGE-CARD"], () =>
        {
            Simulation sim = Create(World(30, 30, 30, 80, 80));
            CycleResult refused = sim.RunCycle(new([P(1, 1, new ProposeMarriage(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            Equal(OutcomeKind.Declined, refused.Outcomes.Single().Kind);
            Equal(0, refused.State.Marriages.Count);
            Equal(80, refused.State.AttitudeOf(new(1), new(2)));
            CycleResult first = sim.RunCycle(new([P(2, 1, new ProposeMarriage(new(2), 1))]));
            Equal(1, first.State.Marriages.Count);
            CycleResult repeated = sim.RunCycle(new([P(3, 1, new ProposeMarriage(new(2), 1))]));
            Equal(OutcomeKind.Unable, repeated.Outcomes.Single().Kind);
            Equal(1, repeated.State.Marriages.Count);
            CycleResult other = sim.RunCycle(new([P(4, 3, new ProposeMarriage(new(2), 1))]));
            Equal(OutcomeKind.Unable, other.Outcomes.Single().Kind);
        });
        yield return new("ResidenceMoveInviteAndConflict", ["S1-096-MOVE", "S1-096-INVITE", "S1-096-COMPETE", "S1-103-RESIDENCE", "S1-BND-RESIDENCE-CARD", "S1-META-11", "S1-MUT-32", "S1-096-NO-HH"], () =>
        {
            foreach (bool invite in new[] { false, true })
            {
                Simulation sim = Create(World());
                CycleResult result = sim.RunCycle(new([P(1, 1, invite ? new InviteResidence(new(2), new(1)) : new MoveResidence(new(2), new(2)))]));
                Equal(new DwellingId(invite ? 1 : 2), result.State.HomeOf(new(invite ? 2 : 1)));
                Equal(1, result.Events.Count(e => e.Kind == "ResidenceTransition"));
                Equal(0, result.State.Marriages.Count);
                Equal(0, result.State.Debts.Count);
                Equal(0, result.State.Favours.Count);
                Equal(7L, Grain(result, 1));
            }
            foreach (bool reverse in new[] { false, true })
            {
                Proposal[] proposals = [P(10, 1, new InviteResidence(new(2), new(1))), P(20, 3, new InviteResidence(new(2), new(3)))];
                CycleResult result = Create(World()).RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                Equal(new DwellingId(1), result.State.HomeOf(new(2)));
                Equal(2, result.Decisions.Length);
                True(result.Decisions.All(d => d.Candidates.Single(c => c.Selected).Meaning == "Accept"));
                Equal(1, result.Events.Count(e => e.Kind == "ResidenceTransition"));
                Outcome lost = result.Outcomes.Single(o => o.Proposal.Value == 20);
                Equal(OutcomeKind.InvalidatedAtResolution, lost.Kind);
                Equal("CompetingResidenceTransition", lost.Reason);
                Equal(2, result.Events.Count(e => e.TechnicalFallback));
            }
            True(!typeof(WorldSnapshot).GetProperties().Any(p => p.Name.Contains("Household", StringComparison.Ordinal)));
        });
        yield return new("MarriageDowryIngress", ["S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 1L })
            {
                Simulation sim = Create(World(8, 8, 8, 75, 75));
                CycleResult result = sim.RunCycle(new([P(1, 1, new ProposeMarriage(new(2), amount))]));
                Equal(amount > 0 ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                Equal(amount > 0 ? 1 : 0, result.Decisions.Length);
                Equal(7L, Grain(result, 1));
                Equal(7L, Grain(result, 2));
                if (amount <= 0) Equal(0, sim.KnowledgeOf(new(2)).Length);
            }
            Equal(typeof(long), typeof(ProposeMarriage).GetProperty(nameof(ProposeMarriage.ProposedDowry))!.PropertyType);
        });
        yield return new("CompleteCallFavorPayloadMatrix", ["S1-094-NONCALLABLE-MATRIX", "S1-094-NONPAYLOAD-MATRIX", "S1-GLOBAL-CALLFAVOR-MAP"], () =>
        {
            ActionTerms[] noncallable = [new OfferGift(new(1), 1), new RequestGiftOrHelp(new(1), 1), new OfferLoan(new(1), 1),
                new RequestLoan(new(1), 1), new OfferBenefitForFavor(new(1), 1), new RelationshipMediatedReciprocalHelp(new(1), 1),
                new CallFavor(new(1), new Farm()), new CancelReciprocalFavours(new(1)), new ProposeMarriage(new(1), 1),
                new MoveResidence(new(1), new(1)), new InviteResidence(new(1), new(2))];
            foreach (ActionTerms payload in noncallable)
            {
                Simulation sim = WithFavour();
                Favour favour = sim.Snapshot.Favours.Values.Single();
                CycleResult result = sim.RunCycle(new([P(2, 1, new CallFavor(favour.Id, payload))]));
                Equal(OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                Equal(0, result.Decisions.Length);
                True(result.State.Favours[favour.Id].Outstanding);
                Equal(0, result.State.AttitudeOf(new(1), new(2)));
                Equal(0, result.Events.Count(e => e.Kind == "CalledFavourFulfilled"));
                Equal(1, sim.KnowledgeOf(new(2)).Length);
            }
            foreach (Type nonAction in new[] { typeof(ResponseChoice), typeof(OutcomeKind), typeof(MaterialChange), typeof(SemanticEvent) })
                True(!typeof(ActionTerms).IsAssignableFrom(nonAction));
            Equal(typeof(ActionTerms), typeof(CallFavor).GetProperty(nameof(CallFavor.Requested))!.PropertyType);
        });
        yield return new("NestedRepaymentIngress", ["S1-D4-GRAIN-CALLFAVOR-REPAY-INNER", "S1-BND-REPAY-AMOUNT", "S1-MUT-33"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 3L, 4L, 5L })
                foreach (bool nested in new[] { false, true })
                {
                    Simulation sim = WithFavour();
                    sim.RunCycle(new([P(2, 3, new OfferLoan(new(2), 4))]));
                    Debt debt = sim.Snapshot.Debts.Values.Single();
                    Favour favour = sim.Snapshot.Favours.Values.Single();
                    ActionTerms repay = new RepayDebt(debt.Id, amount);
                    CycleResult result = sim.RunCycle(new([P(3, nested ? 1 : 2, nested ? new CallFavor(favour.Id, repay) : repay)]));
                    bool valid = amount is > 0 and <= 4;
                    Equal(valid ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                    Equal(valid ? 4 - amount : 4L, result.State.Debts[debt.Id].Remaining);
                    if (!valid)
                    {
                        Equal(0, result.Decisions.Length);
                        True(result.State.Favours[favour.Id].Outstanding);
                        Equal(0, result.State.AttitudeOf(new(1), new(2)));
                    }
                }
        });
    }
}
