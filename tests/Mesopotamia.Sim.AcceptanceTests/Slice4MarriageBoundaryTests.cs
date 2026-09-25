using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4MarriageBoundaryTests
{
    [TestMethod]
    public void DirectStrongLikeBypassRemainsIndependentOfHouseholdAuthority()
    {
        Slice4Lab lab = new(strongMarriage: true); lab.Appoint();
        Assert.IsEmpty(lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions);
        CycleResult result = lab.Step(4, new ProposeMarriage(lab.Id(2), 3));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        Assert.AreEqual(1, result.State.Marriages.Count); Assert.IsEmpty(result.State.Favours);
        Assert.IsFalse(result.Events.Any(e => e.Funding is not null || e.Material.Any(m => m.Meaning == "HouseholdMaterialEffect")));
        Assert.AreEqual(lab.Id(2), result.Decisions.Single().Actor); Slice4Oracle.Verify(lab);
        Slice4Lab weak = new(); weak.Appoint(); weak.Commit(); weak.InformGroom();
        Assert.AreEqual(OutcomeKind.Unable, weak.Step(4, new ProposeMarriage(weak.Id(2), 3)).Outcomes.Single().Kind);
        Assert.IsEmpty(weak.Sim.Snapshot.Marriages); Assert.IsEmpty(weak.Sim.Snapshot.Favours); Slice4Oracle.Verify(weak);
    }

    [TestMethod]
    public void FavourCapacityRaceHasNoBlanketHeadFirstPriority()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.Commit(); lab.InformGroom();
        Proposal bargain = lab.Proposal(1, new OfferBenefitForFavor(lab.Id(4), 1));
        Proposal marriage = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        CycleResult result = lab.Run(new([marriage, bargain]));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == bargain.Id).Kind);
        Outcome rejected = result.Outcomes.Single(o => o.Proposal == marriage.Id);
        Assert.AreEqual(OutcomeKind.InvalidatedAtResolution, rejected.Kind); Assert.AreEqual("FavourCapacityFull", rejected.Reason);
        Assert.IsTrue(result.Events.Single(e => e.Id == rejected.Event).TechnicalFallback);
        Assert.IsEmpty(result.State.Marriages); Assert.AreEqual(1, result.State.Favours.Count); Assert.IsFalse(result.Events.Any(e => e.Funding is not null));
        CycleResult occupied = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        Assert.AreEqual(OutcomeKind.Unable, occupied.Outcomes.Single().Kind); Assert.IsEmpty(occupied.Decisions);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void GroomHeadAliasAndNonparticipantSupportAreRejected()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.Commit();
        Assert.AreEqual(OutcomeKind.InvalidTerms, lab.Step(1, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3)).Outcomes.Single().Kind);
        Assert.AreEqual("SupportRecipientNotParticipant", lab.Step(1, new HouseholdSupport(lab.H, lab.Id(4)), true).Outcomes.Single().Reason);
        Assert.IsEmpty(lab.Sim.Snapshot.Marriages); Assert.IsEmpty(lab.Sim.Snapshot.Favours); Slice4Oracle.Verify(lab);
    }
}
