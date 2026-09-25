using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4ReconsiderationTests
{
    private static CycleResult Refuse(Slice4Lab lab)
    {
        Proposal p = lab.Proposal(1, new RequestProvisionCommitment(lab.H, lab.Id(2)), true);
        return lab.Run(new([p]) { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(p.Id, ResponseChoice.Decline) });
    }

    private static ImmutableArray<GrainInput> StableTargetInputs() =>
        [.. Enumerable.Range(10, 10).Select(c => new GrainInput(c, c, Slice4Lab.P(2), 1))];

    [TestMethod]
    public void HistoricalUnfundedDowrySurvivesAndLaterRefusalResets()
    {
        Slice4Lab lab = new(inputs: [.. StableTargetInputs(), new(100, 10, Slice4Lab.P(1), -87),
            .. Enumerable.Range(11, 9).Select(c => new GrainInput(c + 100, c, Slice4Lab.P(1), 1))]);
        lab.Appoint(); lab.InformGroom();
        Assert.AreEqual(OutcomeKind.Declined, Refuse(lab).Outcomes.Single().Kind);
        Assert.AreEqual(9L, lab.Sim.Snapshot.Cycle);
        ProvisionProcessKey key = new(lab.H, lab.Id(2));
        ProvisionRefusal baseline = lab.Sim.HouseholdSnapshot.ProvisionRefusals[key];
        Assert.IsNull(baseline.MaterialNeedChange);
        CycleResult demand = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        Assert.AreEqual(OutcomeKind.Unable, demand.Outcomes.Single().Kind);
        Assert.AreEqual("AgreedFundingUnavailable", demand.Outcomes.Single().Reason); Assert.IsEmpty(demand.Decisions);
        HouseholdMaterialNeedOccurrence need = lab.Sim.HouseholdSnapshot.ProvisionRefusals[key].MaterialNeedChange!;
        Assert.IsNotNull(need); Assert.AreEqual(HouseholdMaterialNeedKind.MediatedDowry, need.Kind);
        SemanticEvent origin = demand.Events.Single(e => e.Kind == "Proposal");
        Assert.AreEqual(origin.Id, need.Cause); Assert.AreEqual(new EvidenceOrder(origin.Cycle, origin.ReactionIndex), need.Time);
        Assert.AreEqual(origin.Action, need.Dowry); Assert.AreEqual(lab.Id(4), need.Person);
        Assert.IsNotEmpty(need.Evidence); Assert.IsEmpty(lab.Sim.Snapshot.Marriages);
        for (int i = 0; i < 2; i++)
            Assert.AreEqual("ProvisionCooldown", lab.Step(1, new RequestProvisionCommitment(lab.H, lab.Id(2)), true).Outcomes.Single().Reason);
        Assert.AreEqual(OutcomeKind.Declined, Refuse(lab).Outcomes.Single().Kind);
        Assert.AreEqual(13L, lab.Sim.Snapshot.Cycle);
        ProvisionRefusal reset = lab.Sim.HouseholdSnapshot.ProvisionRefusals[key];
        Assert.IsNull(reset.MaterialNeedChange); Assert.AreNotEqual(baseline.Event, reset.Event);
        Assert.AreEqual(baseline.Context.Grain, reset.Context.Grain);
        Assert.AreEqual(baseline.Context.NeedsGrain, reset.Context.NeedsGrain);
        Assert.AreEqual(baseline.Context.AttitudeTowardHead, reset.Context.AttitudeTowardHead);
        for (int i = 0; i < 3; i++) lab.Empty();
        Assert.AreEqual("ProvisionContextUnchanged", lab.Step(1, new RequestProvisionCommitment(lab.H, lab.Id(2)), true).Outcomes.Single().Reason);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void SupportOnsetReentryAndUninterruptedNeedAreDistinct()
    {
        foreach (string mode in new[] { "onset-cleared", "reentry", "continuous" })
        {
            GrainInput[] need = mode == "onset-cleared" ? [new(100, 10, Slice4Lab.P(3), -91), new(101, 11, Slice4Lab.P(3), 3)] :
                mode == "reentry" ? [new(100, 8, Slice4Lab.P(3), -93), new(101, 10, Slice4Lab.P(3), 2)] :
                [new(100, 8, Slice4Lab.P(3), -93)];
            Slice4Lab lab = new(inputs: [.. StableTargetInputs(), .. need]); lab.Appoint(); lab.InformGroom(); Refuse(lab);
            ProvisionProcessKey key = new(lab.H, lab.Id(2));
            for (int i = 0; i < 3; i++) lab.Empty();
            HouseholdMaterialNeedOccurrence? occurrence = lab.Sim.HouseholdSnapshot.ProvisionRefusals[key].MaterialNeedChange;
            if (mode == "continuous") Assert.IsNull(occurrence);
            else
            {
                Assert.IsNotNull(occurrence); Assert.AreEqual(HouseholdMaterialNeedKind.SupportOnset, occurrence.Kind);
                SemanticEvent cause = lab.Sim.History.Single(e => e.Id == occurrence.Cause);
                Assert.AreEqual("MissedConsumption", cause.Kind); Assert.AreEqual(lab.Id(3), cause.Participants.Single());
                Assert.AreEqual(mode == "reentry" ? 12L : 10L, cause.Cycle);
                Assert.AreEqual(lab.Sim.HouseholdSnapshot.Participants(lab.H).Single(a => a.Person == lab.Id(3)).Id, occurrence.Association);
            }
            Outcome outcome = lab.Step(1, new RequestProvisionCommitment(lab.H, lab.Id(2)), true).Outcomes.Single();
            Assert.AreEqual(mode == "continuous" ? OutcomeKind.Unable : OutcomeKind.Committed, outcome.Kind, mode);
            if (mode == "continuous") Assert.AreEqual("ProvisionContextUnchanged", outcome.Reason);
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void ProposalIdentityAndInvalidDowryCannotCreateNeed()
    {
        foreach (bool malformed in new[] { false, true })
        {
            Slice4Lab lab = new(inputs: StableTargetInputs()); lab.Appoint(); lab.Empty(); lab.Empty(); lab.Empty(); Refuse(lab);
            for (int i = 0; i < 3; i++)
            {
                CycleResult invalid = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), malformed ? 0 : 3));
                Assert.AreEqual(malformed ? OutcomeKind.InvalidTerms : OutcomeKind.Unable, invalid.Outcomes.Single().Kind);
                Assert.IsNull(lab.Sim.HouseholdSnapshot.ProvisionRefusals[new(lab.H, lab.Id(2))].MaterialNeedChange);
            }
            Assert.AreEqual("ProvisionContextUnchanged", lab.Step(1, new RequestProvisionCommitment(lab.H, lab.Id(2)), true).Outcomes.Single().Reason);
            Slice4Oracle.Verify(lab);
        }
    }
}
