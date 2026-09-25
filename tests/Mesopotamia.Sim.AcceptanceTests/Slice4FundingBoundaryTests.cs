using System.Collections.Immutable;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4FundingBoundaryTests
{
    [TestMethod]
    public void ContributorRecipientOverlapAggregatesNetDeltaButRetainsFundingLeg()
    {
        Slice4Lab lab = new(bridge: true); lab.Appoint();
        lab.Step(1, new CommunicateClaim(lab.Id(4), new HeldHouseholdRecognition(lab.H)));
        lab.Step(1, new OfferGift(lab.Id(4), 1)); lab.Step(4, new RequestHouseholdParticipation(lab.H, lab.Id(1)));
        lab.Step(1, new CommunicateClaim(lab.Id(4), new HeldHeadRecognition(lab.H)));
        lab.SendFact(2, 4, f => f is SustainingParticipationFact { Person.Value: 2, Current: true }); lab.Commit(4);
        long before = lab.Sim.Snapshot.People[lab.Id(4)].Grain;
        CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        SemanticEvent effect = result.Events.Single(e => e.Funding is not null);
        Assert.AreEqual(lab.Id(4), effect.Funding!.Commitments.Single().Person); Assert.AreEqual(3L, effect.Funding.Commitments.Single().Debit);
        Assert.AreEqual(lab.Id(4), effect.Funding.Recipient); Assert.AreEqual(1, effect.Material.Length);
        Assert.AreEqual(effect.Material[0].Before, effect.Material[0].After); Assert.AreEqual(before - 1, result.State.People[lab.Id(4)].Grain);
        Assert.AreEqual(1, result.State.Marriages.Count); Assert.AreEqual(1, result.State.Favours.Count); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void FundingFailureDisclosesNoUnrelatedPrivateStock()
    {
        string? expected = null;
        foreach (long loss in new[] { -89L, -91L })
        {
            Slice4Lab lab = new(inputs: [new(1, 10, Slice4Lab.P(1), -87), new(2, 10, Slice4Lab.P(3), loss)]);
            lab.Appoint(); lab.Commit(); lab.InformGroom();
            CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
            Assert.AreEqual(OutcomeKind.Unable, result.Outcomes.Single().Kind);
            string reason = lab.Sim.KnowledgeOf(lab.Id(4)).Last().Reason;
            if (expected is null) expected = reason; else Assert.AreEqual(expected, reason);
            Assert.AreEqual("AgreedFundingUnavailable", reason); Assert.IsEmpty(result.Decisions);
            Assert.IsTrue(lab.Sim.EpistemicStateOf(lab.Id(4)).Facts.Select(f => f.Proposition).OfType<OwnStateFact>().All(f => f.Person.Id == lab.Id(4)));
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void SupportPrecedesCalledRepaymentWithoutChangingDebtDueMeaning()
    {
        Slice4Lab lab = new(inputs: [new(1, 9, Slice4Lab.P(2), -93), new(2, 9, Slice4Lab.P(3), -92)]);
        lab.Appoint(); lab.Commit(); lab.Step(4, new OfferLoan(lab.Id(3), 3)); lab.Step(1, new OfferBenefitForFavor(lab.Id(3), 1));
        RelationId debt = lab.Sim.Snapshot.Debts.Keys.Single(), favour = lab.Sim.Snapshot.Favours.Keys.Single();
        Proposal call = lab.Proposal(1, new CallFavor(favour, new RepayDebt(debt, 1)));
        Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, lab.Id(2)), true);
        CycleResult result = lab.Run(new([call, support]));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == support.Id).Kind);
        Assert.AreEqual(OutcomeKind.InvalidatedAtResolution, result.Outcomes.Single(o => o.Proposal == call.Id).Kind);
        Assert.IsTrue(result.State.Favours[favour].Outstanding); Assert.AreEqual(3L, result.State.Debts[debt].Remaining);
        Assert.IsFalse(result.State.Debts[debt].DueReviewed); Assert.IsFalse(result.Events.Any(e => e.Kind == "Declined"));
        lab.Empty();
        Assert.IsTrue(lab.Sim.Snapshot.Debts[debt].DueReviewed);
        SemanticEvent due = lab.Cycles.Last().Events.Single(e => e.Kind == "DebtSocialDueReview");
        Assert.AreEqual(10L, due.Cycle); Assert.AreEqual("UnpaidBalance", due.Detail);
        Assert.IsTrue(lab.Sim.History.SelectMany(e => e.Contributions).Any(c => c.Key.Trigger == due.Id && c.Key.Rule == "UnpaidDebt" && c.Delta == -10));
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void OverflowCannotPartiallyPublishCollectiveEffects()
    {
        Slice4Lab lab = new(groomGrain: long.MaxValue); lab.Appoint(); lab.Commit(); lab.InformGroom();
        WorldSnapshot before = lab.Sim.Snapshot; HouseholdSnapshot institutions = lab.Sim.HouseholdSnapshot;
        Assert.Throws<OverflowException>(() => lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 20)));
        Assert.IsTrue(lab.Sim.IsFaulted); Assert.AreSame(before, lab.Sim.Snapshot); Assert.AreSame(institutions, lab.Sim.HouseholdSnapshot);
        WorldState live = (WorldState)typeof(Simulation).GetField("state", BindingFlags.NonPublic | BindingFlags.Instance)!.GetValue(lab.Sim)!;
        Assert.AreEqual(before.People[lab.Id(3)].Grain - 1, live.People[lab.Id(3)].Grain);
        Assert.AreEqual(before.People[lab.Id(4)].Grain - 1, live.People[lab.Id(4)].Grain);
        Assert.IsEmpty(live.Marriages); Assert.IsEmpty(live.Favours); Assert.IsFalse(lab.Sim.History.Any(e => e.Funding is not null));
        Assert.Throws<InvalidOperationException>(() => lab.Sim.RunCycle(CycleInput.Empty));
    }

    [TestMethod]
    public void FixedRankIncludesEffectiveHeadCapacityAfterPrivateDebit()
    {
        foreach (bool headContributor in new[] { false, true })
        {
            Slice4Lab lab = new(inputs: headContributor
                ? [new(1, 11, Slice4Lab.P(1), -81), new(2, 11, Slice4Lab.P(3), -84)]
                : [new(1, 11, Slice4Lab.P(2), -85), new(2, 11, Slice4Lab.P(3), -84)]);
            lab.Appoint(); lab.Commit(headContributor ? 1 : 2); lab.Commit(3); lab.InformGroom();
            Proposal proposal = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), headContributor ? 7 : 5));
            CycleResult result = lab.Run(new([proposal])
            {
                FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(proposal.Id,
                headContributor ? new(2, true) : new())
            });
            Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
            HouseholdFundingResult funding = result.Events.Single(e => e.Funding is not null).Funding!;
            Assert.IsTrue(funding.ContributorTie);
            CollectionAssert.AreEqual(new[] { 3L, 2L }, funding.Commitments.Select(l => l.Debit).ToArray());
            CollectionAssert.AreEqual(new[] { Slice4Lab.P(headContributor ? 1 : 2), Slice4Lab.P(3) }, funding.Commitments.Select(l => l.Person).ToArray());
            Assert.AreEqual(2L, result.State.People[Slice4Lab.P(headContributor ? 1 : 2)].Grain);
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void FullPrivateFundingWorksWithoutStandingCommitments()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.InformGroom();
        Proposal proposal = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), 3));
        CycleResult result = lab.Run(new([proposal]));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        HouseholdFundingResult funding = result.Events.Single(e => e.Funding is not null).Funding!;
        Assert.AreEqual(new PrivateGrainAuthorization(Slice4Lab.P(1), 3), funding.Private);
        Assert.AreEqual(0L, funding.Residual); Assert.IsEmpty(funding.Commitments); Assert.IsEmpty(lab.Sim.HouseholdSnapshot.Commitments);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void SupportPrecedesRepaymentAndOrdinaryTransfer()
    {
        foreach (bool repay in new[] { false, true })
        {
            Slice4Lab lab = new(inputs: [new(1, 8, Slice4Lab.P(2), -94), new(2, 8, Slice4Lab.P(3), repay ? -92 : -89)]);
            lab.Appoint(); lab.Commit();
            if (repay) lab.Step(4, new OfferLoan(Slice4Lab.P(3), 3)); else lab.Empty();
            ActionTerms terms = repay ? new RepayDebt(lab.Sim.Snapshot.Debts.Keys.Single(), 1) : new OfferGift(Slice4Lab.P(4), 3);
            Proposal personal = lab.Proposal(3, terms);
            Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, Slice4Lab.P(2)), true);
            CycleResult result = lab.Run(new([personal, support]));
            Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == support.Id).Kind);
            Assert.AreEqual(OutcomeKind.InvalidatedAtResolution, result.Outcomes.Single(o => o.Proposal == personal.Id).Kind);
            if (repay) Assert.AreEqual(3L, result.State.Debts.Values.Single().Remaining);
            Assert.AreEqual(2L, result.State.People[Slice4Lab.P(3)].Grain);
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void AcceptedPrivateAmountCannotRebalanceOrRebindAfterSupport()
    {
        Slice4Lab lab = new(inputs: [new(1, 10, Slice4Lab.P(2), -92), new(2, 10, Slice4Lab.P(1), -86)]);
        lab.Appoint(); lab.Commit(); lab.InformGroom();
        Proposal marriage = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 2));
        Proposal succession = lab.Proposal(1, new NominateHouseholdHead(lab.H, lab.Id(2), true));
        Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, lab.Id(2), new(lab.Id(1), 1)), true);
        CycleResult result = lab.Run(new([marriage, succession, support])
        { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(marriage.Id, new(1, true)) });
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == support.Id).Kind);
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == succession.Id).Kind);
        Outcome failed = result.Outcomes.Single(o => o.Proposal == marriage.Id);
        Assert.AreEqual(OutcomeKind.InvalidatedAtResolution, failed.Kind);
        Assert.AreEqual("AgreedPrivateFundingUnavailable", failed.Reason);
        Assert.IsEmpty(result.State.Marriages); Assert.IsEmpty(result.State.Favours);
        Assert.AreEqual(1, result.Events.Count(e => e.Funding is not null));
        Assert.AreEqual(lab.Id(2), lab.Role.Occupant);
        Slice4Oracle.Verify(lab);
    }
}
