using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4FundingBoundaryTests
{
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
