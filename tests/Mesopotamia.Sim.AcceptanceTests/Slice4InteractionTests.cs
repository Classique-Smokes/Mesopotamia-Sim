using System.Collections.Immutable;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4InteractionTests
{
    [TestMethod]
    public void HeadMayReceiveProactiveSupportWithoutSelfResponse()
    {
        foreach (bool privateTerm in new[] { false, true })
        {
            Slice4Lab lab = new(inputs: [new(1, 7, Slice4Lab.P(1), -93)]); lab.Appoint(); lab.Commit();
            CycleResult result = lab.Step(1, new HouseholdSupport(lab.H, Slice4Lab.P(1), privateTerm ? new(Slice4Lab.P(1), 1) : null), true);
            Assert.AreEqual(privateTerm ? OutcomeKind.Unable : OutcomeKind.Committed, result.Outcomes.Single().Kind);
            Assert.IsEmpty(result.Decisions); Assert.IsFalse(result.Events.Any(e => e.Kind == "Response"));
            if (!privateTerm) Assert.AreEqual(Slice4Lab.P(3), result.Events.Single(e => e.Funding is not null).Funding!.Commitments.Single().Person);
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void AcceptedSharedCapacityLossIsInvalidationWithoutPartialDebit()
    {
        Slice4Lab lab = new(inputs: [new(1, 7, Slice4Lab.P(1), -93), new(2, 7, Slice4Lab.P(3), -94), new(3, 7, Slice4Lab.P(2), -91)]);
        lab.Appoint(); lab.Commit(2);
        Proposal selfSupport = lab.Proposal(1, new HouseholdSupport(lab.H, Slice4Lab.P(1)), true);
        Proposal requested = lab.Proposal(3, new RequestHouseholdSupport(lab.H, Slice4Lab.P(1)));
        CycleResult result = lab.Run(new([selfSupport, requested]));
        Assert.AreEqual(1, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
        Assert.AreEqual(1, result.Outcomes.Count(o => o.Kind == OutcomeKind.InvalidatedAtResolution));
        Assert.AreEqual(1, result.Events.Count(e => e.Funding is not null));
        Assert.AreEqual(2L, result.State.People[Slice4Lab.P(2)].Grain);
        Assert.IsFalse(result.Events.Any(e => e.Kind == "Declined")); Slice4Oracle.Verify(lab);
        Assert.IsTrue(result.Events.Any(e => e.TechnicalFallback));
        Assert.IsFalse(result.Decisions.Any(d => d.TechnicalFallback));
    }

    [TestMethod]
    public void SuccessionBridgeEntryAndExitKeepSnapshotCohort()
    {
        foreach (bool reverse in new[] { false, true })
        {
            Slice4Lab lab = new(bridge: true); lab.Appoint();
            lab.Step(1, new CommunicateClaim(Slice4Lab.P(4), new HeldHouseholdRecognition(lab.H)));
            lab.Step(1, new OfferGift(Slice4Lab.P(4), 1));
            Proposal succession = lab.Proposal(1, new NominateHouseholdHead(lab.H, Slice4Lab.P(2), true), true);
            Proposal exit = lab.Proposal(1, new EndHouseholdParticipation(lab.H));
            Proposal entry = lab.Proposal(4, new RequestHouseholdParticipation(lab.H, Slice4Lab.P(1)));
            Proposal[] proposals = [succession, exit, entry];
            CycleResult result = lab.Run(new([.. reverse ? proposals.Reverse() : proposals]));
            Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
            HeadTransition transition = result.Events.Single(e => e.HeadTransition?.Occupant == Slice4Lab.P(2)).HeadTransition!;
            CollectionAssert.AreEquivalent(new[] { Slice4Lab.P(1), Slice4Lab.P(2), Slice4Lab.P(3) }, transition.Cohort.Select(c => c.Person).ToArray());
            Assert.IsEmpty(lab.Sim.EpistemicStateOf(Slice4Lab.P(4)).HeadRecognitions);
            Assert.AreEqual(Slice4Lab.P(2), lab.Role.Occupant); Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void FemaleHeadMediatesOwnMarriage()
    {
        Slice4Lab lab = new(); lab.Appoint(2); lab.Commit(3);
        lab.Step(2, new CommunicateClaim(Slice4Lab.P(4), new HeldHouseholdRecognition(lab.H)));
        lab.Step(2, new CommunicateClaim(Slice4Lab.P(4), new HeldHeadRecognition(lab.H)));
        lab.SendFact(2, 4, f => f is SustainingParticipationFact { Person.Value: 2, Current: true });
        CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(2), Slice4Lab.P(2), 3));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        Assert.AreEqual(1, result.Decisions.Count(d => d.Context == "Response"));
        Assert.AreEqual(Slice4Lab.P(2), result.Decisions.Single().Actor);
        Assert.AreEqual(Slice4Lab.P(2), result.State.Favours.Values.Single().Holder); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void MediatedKnowledgeGatesAndMalformedAmounts()
    {
        foreach (int omitted in new[] { 0, 1, 2 })
        {
            Slice4Lab lab = new(); lab.Appoint(); lab.Commit();
            if (omitted != 0) lab.Step(1, new CommunicateClaim(Slice4Lab.P(4), new HeldHouseholdRecognition(lab.H)));
            if (omitted != 1) lab.Step(1, new CommunicateClaim(Slice4Lab.P(4), new HeldHeadRecognition(lab.H)));
            if (omitted != 2) lab.SendFact(2, 4, f => f is SustainingParticipationFact { Person.Value: 2, Current: true });
            CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), 3));
            Assert.AreEqual(OutcomeKind.Unable, result.Outcomes.Single().Kind); Assert.IsEmpty(result.State.Marriages); Assert.IsEmpty(result.State.Favours);
            Slice4Oracle.Verify(lab);
        }
        foreach (long amount in new[] { 0L, -1L, long.MinValue })
        {
            Slice4Lab lab = new(); lab.Appoint();
            int known = lab.Sim.KnowledgeOf(Slice4Lab.P(4)).Length;
            CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), amount));
            Assert.AreEqual(OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind); Assert.IsEmpty(result.Decisions);
            Assert.AreEqual(known, lab.Sim.KnowledgeOf(Slice4Lab.P(4)).Length);
        }
    }

    [TestMethod]
    public void DeclinedSupplementCannotSeizePrivateGrain()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.Empty(); lab.InformGroom();
        Proposal proposal = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, Slice4Lab.P(1), Slice4Lab.P(2), 3));
        long before = lab.Sim.Snapshot.People[Slice4Lab.P(1)].Grain;
        CycleResult result = lab.Run(new([proposal]) { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(proposal.Id, new(3, true, true)) });
        Assert.AreEqual(OutcomeKind.Declined, result.Outcomes.Single().Kind); Assert.AreEqual(before - 1, result.State.People[Slice4Lab.P(1)].Grain);
        Assert.IsEmpty(result.State.Marriages); Assert.IsEmpty(lab.Sim.HouseholdSnapshot.Commitments); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void HouseholdOutputIsNotIndependentOrganizationalSupport()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit();
        CycleResult result = lab.Step(1, new HouseholdSupport(lab.H, Slice4Lab.P(2), new(Slice4Lab.P(1), 1)), true);
        EventId material = result.Events.Single(e => e.Funding is not null).Id;
        Assert.IsFalse(lab.Sim.EpistemicSnapshot.Actors.Values.SelectMany(a => a.Facts).Any(f => f.Proposition is SupportFact s && s.Event == material));
        Assert.IsFalse(result.Events.Any(e => e.Kind is "Gift" or "Help" or "Loan" || e.Contributions.Any(c => c.Key.Trigger == material)));
        Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Households.Count); Assert.IsEmpty(result.State.Favours);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void DisconnectedActorsObserversAndEnumerationDoNotChangeLastAct()
    {
        string? expected = null;
        foreach (int mode in Enumerable.Range(0, 4))
        {
            Slice4Lab lab = new(need: true, reverse: mode == 1, count: mode == 2 ? 6 : 4); lab.Appoint(); lab.Commit();
            if (mode == 3)
                for (int i = 0; i < 10; i++)
                { _ = lab.Sim.HouseholdSnapshot; _ = lab.Sim.EpistemicSnapshot; _ = lab.Sim.DecisionHistory; _ = lab.Sim.History; }
            Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, Slice4Lab.P(2)), true);
            Proposal succession = lab.Proposal(1, new NominateHouseholdHead(lab.H, Slice4Lab.P(2), true));
            CycleResult result = lab.Run(new(mode == 1 ? [succession, support] : [support, succession]));
            Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
            string actual = JsonSerializer.Serialize(new
            {
                lab.Role.Occupant,
                People = result.State.People.Values.Where(p => p.Id.Value <= 4).OrderBy(p => p.Id.Value),
                Material = result.Events.Where(e => e.Funding is not null).Select(e => new { e.Kind, e.Funding, e.TechnicalFallback })
            });
            if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
            Slice4Oracle.Verify(lab);
        }
    }
}
