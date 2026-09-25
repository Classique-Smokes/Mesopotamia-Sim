using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4KnowledgeBoundaryTests
{
    [TestMethod]
    public void KnownVacancyIsDistinctFromUnknownAndCorrectsAfterAppointment()
    {
        Slice4Lab lab = new(); lab.Appoint(); HouseholdHeadRoleId role = lab.Role.Id;
        Assert.IsEmpty(lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions);
        lab.Step(1, new EndHouseholdParticipation(lab.H));
        Assert.AreEqual(lab.Id(1), lab.Sim.EpistemicStateOf(lab.Id(2)).HeadRecognitions.Single().Occupant);
        lab.Step(1, new CommunicateClaim(lab.Id(4), new HeldHeadRecognition(lab.H)));
        HeadRecognition vacancy = lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single();
        Assert.AreEqual(RecognitionStatus.Recognized, vacancy.Status); Assert.IsNull(vacancy.Occupant); Assert.AreEqual(role, vacancy.Role);
        Assert.AreEqual(OutcomeKind.Committed, lab.Step(2, new NominateHouseholdHead(lab.H, lab.Id(2), true, true)).Outcomes.Single().Kind);
        Assert.IsNull(lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single().Occupant);
        lab.Step(2, new CommunicateClaim(lab.Id(4), new HeldHeadRecognition(lab.H)));
        Assert.AreEqual(lab.Id(2), lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single().Occupant);
        Assert.AreEqual(role, lab.Role.Id); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void AcceptedMediationRevalidatesActorHeldAuthorityAfterCommunication()
    {
        Slice4Lab lab = new(count: 5); lab.Appoint(); lab.Commit(); lab.InformGroom();
        lab.SupplyHeadReport(lab.Id(5), new(lab.H, lab.Role.Id, lab.Id(2), lab.Role.LastTransition), new(null, null, null, "F-S4-CONTRARY-REPORT"));
        KnownFact report = lab.Sim.EpistemicStateOf(lab.Id(5)).Facts.Single(f => f.Proposition is HeadRoleFact);
        Proposal message = lab.Proposal(5, new CommunicateClaim(lab.Id(4), new HeldFact(report.Id)));
        Proposal marriage = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        CycleResult result = lab.Run(new([marriage, message]));
        Outcome outcome = result.Outcomes.Single(o => o.Proposal == marriage.Id);
        Assert.AreEqual(OutcomeKind.InvalidatedAtResolution, outcome.Kind); Assert.AreEqual("HeadNotRecognized", outcome.Reason);
        Assert.AreEqual(RecognitionStatus.Contested, lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single().Status);
        Assert.IsEmpty(result.State.Marriages); Assert.IsFalse(result.Events.Any(e => e.Funding is not null));
        Assert.AreEqual(lab.Id(1), lab.Role.Occupant); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void OlderLateHeadReportCannotReplaceNewerTransition()
    {
        Slice4Lab lab = new(count: 5); lab.Appoint();
        lab.Step(1, new CommunicateClaim(lab.Id(5), new HeldHeadRecognition(lab.H)));
        lab.Step(1, new NominateHouseholdHead(lab.H, lab.Id(2), true), true);
        lab.Step(2, new CommunicateClaim(lab.Id(4), new HeldHeadRecognition(lab.H)));
        HeadRecognition newer = lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single();
        lab.Step(5, new CommunicateClaim(lab.Id(4), new HeldHeadRecognition(lab.H)));
        HeadRecognition current = lab.Sim.EpistemicStateOf(lab.Id(4)).HeadRecognitions.Single();
        Assert.AreEqual(newer.Occupant, current.Occupant);
        CollectionAssert.AreEqual(newer.Evidence.ToArray(), current.Evidence.ToArray());
        Slice4Oracle.Verify(lab);
        var actor = lab.Sim.EpistemicStateOf(lab.Id(4));
        KnownFact original = current.Evidence.Single(), forged = original with { Id = new(long.MaxValue) };
        var corruptedActor = actor with
        {
            Facts = actor.Facts.Replace(original, forged),
            HeadRecognitions = [current with { Evidence = [forged] }]
        };
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.VerifyHeadKnowledge(lab,
            lab.Sim.EpistemicSnapshot with { Actors = lab.Sim.EpistemicSnapshot.Actors.SetItem(actor.Actor, corruptedActor) }));
    }

    [TestMethod]
    public void IsomorphicPersonRenamingPreservesRoleAndMaterialSemantics()
    {
        string? expected = null;
        foreach (int offset in new[] { 0, 100 })
        {
            Slice4Lab lab = new(offset: offset); lab.Appoint(); lab.Commit(); lab.InformGroom();
            CycleResult result = lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
            Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
            var funding = result.Events.Single(e => e.Funding is not null).Funding!;
            string actual = JsonSerializer.Serialize(new
            {
                Head = lab.Role.Occupant!.Value.Value - offset,
                People = result.State.People.Values.OrderBy(p => p.Id.Value).Select(p => new { Person = p.Id.Value - offset, p.Grain, p.NeedsGrain }),
                Legs = funding.Commitments.Select(l => new { Person = l.Person.Value - offset, l.Capacity, l.Debit }),
                funding.Cost,
                funding.Residual,
                funding.ContributorTie,
                Fallback = result.Events.Where(e => e.Funding is not null).Select(e => e.TechnicalFallback)
            });
            if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
            Slice4Oracle.Verify(lab);
        }
    }
}
