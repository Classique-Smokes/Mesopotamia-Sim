using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4MechanismTests
{
    [TestMethod]
    public void RoleConsentVacancyAndIdentity()
    {
        Slice4Lab lab = new();
        var roleId = lab.Role.Id; var h = lab.H;
        lab.Appoint();
        Assert.AreEqual(4, lab.Sim.HouseholdSnapshot.HeadTransitions.Values.Single().Consents.Length);
        Assert.IsFalse(lab.Sim.DecisionHistory.Any(d => d.Actor == Slice4Lab.P(1) && d.Context == "HeadConsentResponse"));
        lab.Step(1, new NominateHouseholdHead(h, Slice4Lab.P(2), true), true);
        Assert.AreEqual(Slice4Lab.P(2), lab.Role.Occupant);
        Assert.AreEqual(roleId, lab.Role.Id);
        lab.Step(2, new EndHouseholdParticipation(h));
        Assert.IsNull(lab.Role.Occupant); Assert.AreEqual(roleId, lab.Role.Id); Assert.AreEqual(h, lab.H);
    }

    [TestMethod]
    public void ExplicitConsentAblations()
    {
        foreach (int missing in Enumerable.Range(0, 4))
        {
            Slice4Lab lab = new();
            Proposal p = lab.Proposal(1, new NominateHouseholdHead(lab.H, Slice4Lab.P(1), missing != 0, missing != 1));
            var overrides = ImmutableDictionary<HeadConsentKey, bool>.Empty;
            if (missing >= 2) overrides = overrides.Add(new(p.Id, Slice4Lab.P(missing), HeadConsentCapacity.Participant), false);
            Assert.AreEqual(OutcomeKind.Declined, lab.Run(new([p]) { HeadConsents = overrides }).Outcomes.Single().Kind);
            Assert.IsNull(lab.Role.Occupant);
        }
    }

    [TestMethod]
    public void SupportAndIndependentPersonalInitiative()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit();
        Proposal farm = lab.Proposal(1, new Farm());
        CycleResult result = lab.Run(new([farm])
        { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { NeedRecipient = Slice4Lab.P(2) }) });
        Assert.AreEqual(2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
        SemanticEvent support = result.Events.Single(e => e.Kind == "HouseholdSupport");
        Assert.AreEqual(1L, support.Funding!.Cost);
        Assert.AreEqual(Slice4Lab.P(3), support.Funding.Commitments.Single().Person);
        Assert.IsFalse(result.State.People[Slice4Lab.P(2)].NeedsGrain);
        Assert.AreEqual(1L, result.State.People[Slice4Lab.P(2)].Grain);
    }

    [TestMethod]
    public void MediatedMarriageFundingVariants()
    {
        foreach (long? x in new long?[] { null, 1, 2, 3 })
        {
            Slice4Lab lab = new(); lab.Appoint(); lab.Commit(); lab.InformGroom();
            Proposal p = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), 3));
            CycleResult result = lab.Run(new([p]) { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(p.Id, new(x, x is not null)) });
            Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
            SemanticEvent committed = result.Events.Single(e => e.Kind == "HouseholdMediatedMarriage");
            Assert.AreEqual(x, committed.Funding!.Private?.Amount);
            Assert.AreEqual(3 - (x ?? 0), committed.Funding.Residual);
            Assert.AreEqual(3 - (x ?? 0), committed.Funding.Commitments.Sum(l => l.Debit));
            Assert.AreEqual(1, result.State.Marriages.Count); Assert.AreEqual(1, result.State.Favours.Count);
            Assert.AreEqual(Slice4Lab.P(1), result.State.Favours.Values.Single().Holder);
        }
    }

    [TestMethod]
    public void LastActBeforeHeadExit()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit();
        Proposal exit = lab.Proposal(1, new EndHouseholdParticipation(lab.H));
        Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, Slice4Lab.P(2)), true);
        CycleResult result = lab.Run(new([exit, support]));
        Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
        Assert.IsNull(lab.Role.Occupant);
        Assert.IsTrue(result.Events.Single(e => e.Kind == "HouseholdSupport").ReactionIndex < result.Events.Single(e => e.Kind == "HouseholdParticipationEnded").ReactionIndex);
    }
}
