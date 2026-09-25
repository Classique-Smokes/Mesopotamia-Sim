using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4LifecycleTests
{
    [TestMethod]
    public void EveryOtherNomineeConsentIsNecessaryBeforeAndAfterAppointment()
    {
        foreach (bool succession in new[] { false, true })
            foreach (int omitted in Enumerable.Range(0, 4))
            {
                Slice4Lab lab = new(); if (succession) lab.Appoint();
                HouseholdHeadRole before = lab.Role;
                Proposal p = lab.Proposal(1, new NominateHouseholdHead(lab.H, lab.Id(2), omitted != 0), succession);
                var responses = ImmutableDictionary<HeadConsentKey, bool>.Empty;
                if (omitted != 0) responses = responses.Add(new(p.Id, lab.Id(omitted == 3 ? 3 : 2),
                    omitted == 1 ? HeadConsentCapacity.Nominee : HeadConsentCapacity.Participant), false);
                CycleResult result = lab.Run(new([p, lab.Proposal(2, new Farm())]) { HeadConsents = responses });
                Assert.AreEqual(OutcomeKind.Declined, result.Outcomes.Single(o => o.Proposal == p.Id).Kind);
                Assert.AreEqual(before, lab.Role); Assert.AreEqual(1, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                Slice4Oracle.Verify(lab);
            }
    }

    [TestMethod]
    public void VacancyAndDissolutionSuppressOnlyHouseholdContexts()
    {
        foreach (bool dissolved in new[] { false, true })
        {
            Slice4Lab lab = new(); lab.Appoint(); lab.Commit(1); lab.Commit(3);
            HouseholdHeadRoleId role = lab.Role.Id;
            lab.Step(1, new EndHouseholdParticipation(lab.H));
            Assert.IsNull(lab.Role.Occupant); Assert.AreEqual(role, lab.Role.Id);
            Assert.IsNotNull(lab.Sim.HouseholdSnapshot.Commitments.Values.Single(c => c.Person == lab.Id(1)).TerminatedBy);
            Assert.IsNull(lab.Sim.HouseholdSnapshot.Commitments.Values.Single(c => c.Person == lab.Id(3)).TerminatedBy);
            if (dissolved)
            {
                lab.Step(2, new EndHouseholdParticipation(lab.H)); lab.Step(3, new EndHouseholdParticipation(lab.H));
                Assert.AreEqual(HouseholdLifecycle.Dissolved, lab.Sim.HouseholdSnapshot.Households[lab.H].Lifecycle);
                Assert.IsTrue(lab.Sim.HouseholdSnapshot.Commitments.Values.All(c => c.TerminatedBy is not null));
            }
            CycleResult result = lab.Run(new([lab.Proposal(1, new Farm())])
            { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { NeedRecipient = lab.Id(2) }) });
            Assert.AreEqual(1, result.Outcomes.Length); Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
            Assert.IsFalse(result.Decisions.Any(d => d.HouseholdContext is not null));
            Proposal forged = lab.Proposal(1, new HouseholdSupport(lab.H, lab.Id(2))) with { HouseholdContext = new(lab.H, role, lab.Id(1)) };
            Assert.AreEqual(OutcomeKind.Unable, lab.Run(new([forged])).Outcomes.Single().Kind);
            Slice4Oracle.Verify(lab);
        }
    }

    [TestMethod]
    public void InactiveRoleSurvivesPublicReactivationWithoutFreshInitiative()
    {
        Slice4Lab lab = new(bridge: true);
        lab.Step(2, new EndHouseholdParticipation(lab.H)); lab.Step(3, new EndHouseholdParticipation(lab.H)); lab.Appoint();
        HouseholdHeadRole original = lab.Role;
        lab.Step(1, new CommunicateClaim(lab.Id(4), new HeldHouseholdRecognition(lab.H)));
        lab.Step(1, new OfferGift(lab.Id(4), 1));
        CycleResult entry = lab.Run(new([lab.Proposal(4, new RequestHouseholdParticipation(lab.H, lab.Id(1)))])
        { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { ProvisionTarget = lab.Id(4) }) });
        Assert.AreEqual(OutcomeKind.Committed, entry.Outcomes.Single().Kind); Assert.AreEqual(original, lab.Role);
        Assert.AreEqual(HouseholdLifecycle.Active, lab.Sim.HouseholdSnapshot.Households[lab.H].Lifecycle);
        Assert.IsFalse(entry.Decisions.Any(d => d.Context == "Household"));
        Assert.IsEmpty(lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions);
        CycleResult later = lab.Run(new([]) { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { ProvisionTarget = lab.Id(4) }) });
        Assert.AreEqual(OutcomeKind.Committed, later.Outcomes.Single().Kind); Assert.AreEqual(1, later.Decisions.Count(d => d.Context == "Household"));
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void SnapshotInvalidAuthorityCannotBeRevivedByAppointment()
    {
        Slice4Lab lab = new();
        Proposal appointment = lab.Proposal(1, new NominateHouseholdHead(lab.H, lab.Id(1), true, true));
        Proposal provision = lab.Proposal(1, new AuthorizeOwnProvisionCommitment(lab.H, true, true)) with { HouseholdContext = new(lab.H, lab.Role.Id, lab.Id(1)) };
        CycleResult result = lab.Run(new([provision, appointment]));
        Assert.AreEqual(OutcomeKind.Unable, result.Outcomes.Single(o => o.Proposal == provision.Id).Kind);
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal == appointment.Id).Kind);
        Assert.IsEmpty(lab.Sim.HouseholdSnapshot.Commitments); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void SupportLastActPrecedesLossOfActiveStatus()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit(1);
        Proposal support = lab.Proposal(1, new HouseholdSupport(lab.H, lab.Id(2)), true);
        CycleResult result = lab.Run(new([lab.Proposal(2, new EndHouseholdParticipation(lab.H)), lab.Proposal(3, new EndHouseholdParticipation(lab.H)), support]));
        Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
        Assert.AreEqual(HouseholdLifecycle.Inactive, lab.Sim.HouseholdSnapshot.Households[lab.H].Lifecycle);
        Assert.IsTrue(result.Events.Single(e => e.Funding is not null).ReactionIndex < result.Events.First(e => e.Kind == "HouseholdParticipationEnded").ReactionIndex);
        Assert.AreEqual(lab.Id(1), lab.Role.Occupant); Slice4Oracle.Verify(lab);
    }
}
