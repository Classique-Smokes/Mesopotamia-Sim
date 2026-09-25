using System.Collections.Immutable;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4ContextTests
{
    [TestMethod]
    public void DecisionTieIsSeparateFromCentralResolutionFallback()
    {
        Slice4Lab lab = new(); lab.Appoint();
        CycleResult result = lab.Run(new([]) { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new("SFL-HOUSEHOLD-REFERENCE-v1")) });
        Assert.IsTrue(result.Decisions.Single(d => d.Context == "Household").TechnicalFallback);
        Assert.IsFalse(result.Events.Any(e => e.TechnicalFallback));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind); Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void NegativeAttitudeAndVoluntaryRefusalDoNotEraseHeadRecognition()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Empty();
        Proposal request = lab.Proposal(2, new RequestGiftOrHelp(lab.Id(1), 1));
        CycleResult result = lab.Run(new([request]) { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(request.Id, ResponseChoice.Decline) });
        Assert.IsTrue(result.State.AttitudeOf(lab.Id(2), lab.Id(1)) < 0);
        Assert.AreEqual(RecognitionStatus.Recognized, lab.Sim.EpistemicStateOf(lab.Id(2)).HeadRecognitions.Single().Status);
        Assert.AreEqual(lab.Id(1), lab.Sim.EpistemicStateOf(lab.Id(2)).HeadRecognitions.Single().Occupant);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void OnePersonCarriesSeparateContextsForTwoProducedHouseholds()
    {
        Slice4Lab lab = new(count: 6, secondHousehold: true); HouseholdId first = lab.H; lab.Appoint();
        lab.Step(4, new OfferGift(lab.Id(6), 1)); lab.Step(6, new OfferGift(lab.Id(5), 1));
        lab.SendFact(6, 4, f => f is SupportFact { Cycle: 7 }); lab.SendFact(6, 5, f => f is SupportFact { Cycle: 6 });
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles);
        HouseholdId second = lab.Sim.HouseholdSnapshot.Households.Keys.Single(h => h != first);
        lab.Step(4, new NominateHouseholdHead(second, lab.Id(4), true, true));
        lab.Step(4, new CommunicateClaim(lab.Id(1), new HeldHouseholdRecognition(second)));
        lab.Step(4, new OfferGift(lab.Id(1), 1));
        Assert.AreEqual(OutcomeKind.Committed, lab.Step(1, new RequestHouseholdParticipation(second, lab.Id(4))).Outcomes.Single().Kind);
        Assert.AreEqual(OutcomeKind.Committed, lab.Step(4, new NominateHouseholdHead(second, lab.Id(1), true)).Outcomes.Single().Kind);
        CycleResult result = lab.Run(new([lab.Proposal(1, new Farm())])
        { HouseholdPolicies = new[] { first, second }.ToImmutableDictionary(h => h, _ => new HouseholdPolicy() { ProvisionTarget = lab.Id(1) }) });
        Assert.AreEqual(3, result.Outcomes.Length); Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
        Assert.AreEqual(2, result.Decisions.Count(d => d.Context == "Household"));
        Assert.AreEqual(2, result.Decisions.Select(d => d.HouseholdContext?.Role).OfType<HouseholdHeadRoleId>().Distinct().Count());
        Assert.IsTrue(result.Decisions.All(d => d.Actor == lab.Id(1) && d.Cycle == result.State.Cycle));
        Assert.IsFalse(result.Events.Any(e => e.Kind == "Response"));
        Assert.AreEqual(2, lab.Sim.HouseholdSnapshot.Commitments.Count); Slice4Oracle.Verify(lab);
        Assert.AreEqual(lab.Initial.People.Length, lab.Sim.EpistemicSnapshot.Actors.Count);
        Assert.IsTrue(result.Decisions.Where(d => d.Context == "Household").All(d => d.Actor == lab.Id(1)));
    }

    [TestMethod]
    public void ResponsesAndPersonalInitiativeCoexistWithHouseholdInitiative()
    {
        Slice4Lab lab = new(); lab.Appoint();
        CycleResult result = lab.Run(new([lab.Proposal(1, new Farm()), lab.Proposal(4, new OfferGift(lab.Id(1), 1)), lab.Proposal(3, new OfferGift(lab.Id(2), 1))])
        { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { ProvisionTarget = lab.Id(3) }) });
        Assert.AreEqual(4, result.Outcomes.Length); Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
        Assert.AreEqual(3, result.Decisions.Count(d => d.Context == "Response"));
        Assert.AreEqual(1, result.Decisions.Count(d => d.Context == "Household"));
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void HouseholdProfileComponentsAndFallbackDomainsAreExact()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit();
        CycleResult result = lab.Run(new([lab.Proposal(1, new Farm())])
        { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { NeedRecipient = lab.Id(2) }) });
        DecisionTrace trace = result.Decisions.Single(d => d.Context == "Household");
        Assert.AreEqual("SCORE-VP-003", trace.Profile); Assert.AreEqual("SFL-S4-v1", trace.RulesVersion);
        Assert.AreEqual(lab.Initial.Configuration.Version, trace.ConfigurationVersion); Assert.AreEqual(lab.Context, trace.HouseholdContext);
        CandidateTrace candidate = trace.Candidates.Single(); Assert.AreEqual(100L, candidate.FinalScore);
        Assert.AreEqual(3, candidate.Components.Count); Assert.AreEqual(100L, candidate.Components["NeedReliefConcern"]);
        Assert.AreEqual(0L, candidate.Components["MarriageConcern"]); Assert.AreEqual(0L, candidate.Components["ProvisionBackingConcern"]);
        Assert.IsFalse(trace.TechnicalFallback); Assert.IsFalse(result.Events.Any(e => e.TechnicalFallback));
        Assert.IsTrue(trace.SubjectiveInputs.Any(e => e.Contains("Snapshot:" + result.State.Cycle, StringComparison.Ordinal)));
        CycleResult invalid = lab.Run(new([])
        { HouseholdPolicies = ImmutableDictionary<HouseholdId, HouseholdPolicy>.Empty.Add(lab.H, new() { NeedRecipient = lab.Id(4) }) });
        Assert.IsEmpty(invalid.Outcomes); Assert.AreEqual(0L, invalid.Decisions.Single().Candidates.Single().Components["NeedReliefConcern"]);
        Slice4Oracle.Verify(lab);
    }

    [TestMethod]
    public void PositiveIntegerTermsRejectLossyNumericIngress()
    {
        foreach (string token in new[] { "1.5", "9223372036854775808", "1e100" })
        {
            Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<ProposeMediatedMarriage>("{\"Household\":{\"Value\":1},\"Head\":{\"Value\":1},\"Bride\":{\"Value\":2},\"Dowry\":" + token + "}"));
            Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<PrivateGrainAuthorization>("{\"Owner\":{\"Value\":1},\"Amount\":" + token + "}"));
        }
        foreach (long amount in new[] { 0L, -1L, 4L })
        {
            Slice4Lab lab = new(); lab.Appoint(); lab.InformGroom();
            Proposal p = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
            CycleResult result = lab.Run(new([p]) { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(p.Id, new(amount, true)) });
            Assert.AreEqual(OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind); Assert.IsEmpty(result.Decisions);
            Assert.IsEmpty(lab.Sim.KnowledgeOf(lab.Id(4)).Where(k => k.Proposal == p.Id));
            Assert.IsEmpty(result.State.Marriages); Assert.IsEmpty(result.State.Favours); Slice4Oracle.Verify(lab);
        }
    }
}
