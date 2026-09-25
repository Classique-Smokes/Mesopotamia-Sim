using System.Collections.Immutable;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4AdversarialTests
{
    [TestMethod]
    public void NonparticipantCannotNominateOrOccupyRole()
    {
        foreach (bool outsiderNominates in new[] { false, true })
        {
            Slice4Lab lab = new();
            lab.Step(1, new CommunicateClaim(Slice4Lab.P(4), new HeldHouseholdRecognition(lab.H)));
            CycleResult result = lab.Step(outsiderNominates ? 4 : 1,
                new NominateHouseholdHead(lab.H, Slice4Lab.P(outsiderNominates ? 1 : 4), true));
            Assert.AreEqual(OutcomeKind.Unable, result.Outcomes.Single().Kind);
            Assert.IsNull(lab.Role.Occupant); Slice4Oracle.Verify(lab);
        }
    }
    [TestMethod]
    public void InactiveAppointmentAndHeadlessActionRejection()
    {
        Slice4Lab lab = new();
        lab.Step(2, new EndHouseholdParticipation(lab.H)); lab.Step(3, new EndHouseholdParticipation(lab.H));
        Assert.AreEqual(HouseholdLifecycle.Inactive, lab.Sim.HouseholdSnapshot.Households[lab.H].Lifecycle);
        lab.Appoint();
        CycleResult result = lab.Run(new([]) { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { NeedRecipient = Slice4Lab.P(1) }) });
        Assert.IsEmpty(result.Decisions); Assert.IsEmpty(result.Outcomes); Assert.AreEqual(Slice4Lab.P(1), lab.Role.Occupant);
        Assert.AreEqual(OutcomeKind.Unable, lab.Step(1, new AuthorizeOwnProvisionCommitment(lab.H, true, true), true).Outcomes.Single().Kind);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void HeadEvidenceStaysLocalAndCorrectsByCommunication()
    {
        Slice4Lab lab = new(); lab.Appoint();
        Assert.IsEmpty(lab.Sim.EpistemicStateOf(Slice4Lab.P(4)).HeadRecognitions);
        lab.Step(1, new CommunicateClaim(Slice4Lab.P(4), new HeldHeadRecognition(lab.H)));
        lab.Step(1, new NominateHouseholdHead(lab.H, Slice4Lab.P(2), true), true);
        Assert.AreEqual(Slice4Lab.P(1), lab.Sim.EpistemicStateOf(Slice4Lab.P(4)).HeadRecognitions.Single().Occupant);
        lab.Step(2, new CommunicateClaim(Slice4Lab.P(4), new HeldHeadRecognition(lab.H)));
        HeadRecognition recognition = lab.Sim.EpistemicStateOf(Slice4Lab.P(4)).HeadRecognitions.Single();
        Assert.AreEqual(Slice4Lab.P(2), recognition.Occupant); Assert.AreEqual(RecognitionStatus.Recognized, recognition.Status);
        Assert.AreEqual(lab.Role.LastTransition, recognition.Evidence.Single().Provenance.Origin.Event);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void IncomparableHeadEvidenceCannotChooseAuthority()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.InformGroom();
        foreach (int head in new[] { 1, 2 })
            lab.SupplyHeadReport(Slice4Lab.P(4), new(lab.H, lab.Role.Id, Slice4Lab.P(head), lab.Role.LastTransition),
                new(null, null, null, "F-S4-INCOMPARABLE-REPORTS"));
        HeadRecognition recognition = lab.Sim.EpistemicStateOf(Slice4Lab.P(4)).HeadRecognitions.Single();
        Assert.AreEqual(RecognitionStatus.Contested, recognition.Status); Assert.IsNull(recognition.Occupant); Assert.IsNull(recognition.Role);
        Assert.AreEqual(OutcomeKind.InvalidTerms, lab.Step(4, new CommunicateClaim(Slice4Lab.P(3), new HeldHeadRecognition(lab.H))).Outcomes.Single().Kind);
        Assert.AreEqual("HeadNotRecognized", lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3)).Outcomes.Single().Reason);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void SelfCommitmentPreservesPrivateAuthorization()
    {
        foreach (bool institutional in new[] { false, true })
            foreach (bool personal in new[] { false, true })
            {
                Slice4Lab lab = new(); lab.Appoint();
                CycleResult result = lab.Step(1, new AuthorizeOwnProvisionCommitment(lab.H, institutional, personal), true);
                Assert.AreEqual(institutional && personal ? OutcomeKind.Committed : OutcomeKind.Unable, result.Outcomes.Single().Kind);
                Assert.IsFalse(result.Decisions.Any(d => d.Context == "Response"));
                Assert.IsTrue(result.Events.Where(e => e.Kind == "HouseholdProvisionCommitted").All(e => e.Material.IsEmpty));
                Slice4Oracle.Verify(lab);
            }
    }

    [TestMethod]
    public void RefusalCooldownSurvivesSuccession()
    {
        Slice4Lab lab = new(); lab.Appoint();
        Proposal request = lab.Proposal(1, new RequestProvisionCommitment(lab.H, Slice4Lab.P(3)), true);
        Assert.AreEqual(OutcomeKind.Declined, lab.Run(new([request]) { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(request.Id, ResponseChoice.Decline) }).Outcomes.Single().Kind);
        long refused = lab.Sim.Snapshot.Cycle;
        lab.Step(1, new NominateHouseholdHead(lab.H, Slice4Lab.P(2), true), true);
        for (int i = 0; i < 2; i++) Assert.AreEqual("ProvisionCooldown", lab.Step(2, new RequestProvisionCommitment(lab.H, Slice4Lab.P(3)), true).Outcomes.Single().Reason);
        Assert.AreEqual(refused + 3, lab.Sim.Snapshot.Cycle);
        Assert.AreEqual(OutcomeKind.Committed, lab.Step(2, new RequestProvisionCommitment(lab.H, Slice4Lab.P(3)), true).Outcomes.Single().Kind);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void ScopeCannotCommandOrdinaryActions()
    {
        Slice4Lab lab = new(); lab.Appoint();
        foreach (ActionTerms terms in new ActionTerms[] { new Farm(), new OfferGift(Slice4Lab.P(2), 1), new OfferLoan(Slice4Lab.P(2), 1),
            new MoveResidence(Slice4Lab.P(2), new(1)), new OfferBenefitForFavor(Slice4Lab.P(2), 1), new ProposeMarriage(Slice4Lab.P(2), 1) })
        {
            CycleResult result = lab.Step(1, terms, true);
            Assert.AreEqual(OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind); Assert.IsEmpty(result.Decisions);
        }
        Assert.AreEqual(OutcomeKind.Committed, lab.Step(1, new OfferGift(Slice4Lab.P(2), 1)).Outcomes.Single().Kind);
    }

    [TestMethod]
    public void PrivateFundingCannotDoubleCountHeadCommitment()
    {
        Slice4Lab lab = new(inputs: [new(1, 10, Slice4Lab.P(1), -84)]); lab.Appoint(); lab.Commit(1); lab.InformGroom();
        Proposal proposal = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), 4));
        CycleResult result = lab.Run(new([proposal]) { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(proposal.Id, new(2, true)) });
        Assert.AreEqual(OutcomeKind.Unable, result.Outcomes.Single().Kind);
        Assert.AreEqual(5L, result.State.People[Slice4Lab.P(1)].Grain); Assert.IsEmpty(result.State.Marriages); Assert.IsEmpty(result.State.Favours);
        Assert.IsFalse(result.Events.Any(e => e.Funding is not null)); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void FundingAndRoleCorruptionsReachIndependentChecker()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit(); lab.Step(1, new HouseholdSupport(lab.H, Slice4Lab.P(2)), true);
        Slice4Oracle.Verify(lab);
        HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, h with { HeadRoles = h.HeadRoles.SetItem(lab.Role.Id, lab.Role with { Occupant = Slice4Lab.P(3) }) }));
        SemanticEvent[] history = [.. lab.Sim.History];
        SemanticEvent support = history.Single(e => e.Funding is not null);
        foreach (HouseholdFundingResult bad in new[] { support.Funding! with { Cost = 2 }, support.Funding! with { Residual = 0 },
            support.Funding! with { Commitments = [support.Funding!.Commitments.Single() with { Debit = 2 }] },
            support.Funding! with { Authority = support.Funding!.Authority with { Head = Slice4Lab.P(3) } } })
            Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, suppliedEvents: [.. history.Select(e => e.Id == support.Id ? e with { Funding = bad } : e)]));
        HeadTransition transition = h.HeadTransitions.Values.Single();
        HeadConsent original = transition.Consents[0];
        var corrupt = transition with { Consents = transition.Consents.SetItem(0, original with { RecognitionEvidence = [original.RecognitionEvidence[0] with { Id = new(999999) }] }) };
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, h with { HeadTransitions = h.HeadTransitions.SetItem(transition.Event, corrupt) },
            [.. history.Select(e => e.Id == transition.Event ? e with { HeadTransition = corrupt } : e)]));
    }

    [TestMethod]
    public void FormationOracleRejectsAutomaticOccupancy()
    {
        Slice4Lab lab = new(); HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, h with { HeadRoles = h.HeadRoles.SetItem(lab.Role.Id, lab.Role with { Occupant = Slice4Lab.P(1) }) }));
        Assert.IsTrue(typeof(HouseholdSnapshot).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).All(f => f.IsInitOnly));
    }
}
