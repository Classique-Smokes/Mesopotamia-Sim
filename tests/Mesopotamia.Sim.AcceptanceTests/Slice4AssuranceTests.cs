using System.Collections.Immutable;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4AssuranceTests
{
    [TestMethod]
    public void MaterialAndOriginCorruptionMatrixReachesIndependentChecker()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.Commit(); lab.InformGroom();
        Proposal marriage = lab.Proposal(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3));
        lab.Run(new([marriage]) { FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(marriage.Id, new(1, true)) });
        Slice4Oracle.Verify(lab);
        HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
        SemanticEvent effect = lab.Sim.History.Single(e => e.Funding is not null);
        HouseholdFundingResult f = effect.Funding!;
        foreach (HouseholdFundingResult bad in new[] { f with { ContributorTie = !f.ContributorTie },
            f with { Private = new(lab.Id(3), 1) }, f with { Private = new(lab.Id(1), 2) },
            f with { PossibleParticipants = [] }, f with { Commitments = [] } })
            Reject(effect with { Funding = bad });
        Reject(effect with { Kind = "HouseholdArbitraryPayment" });
        Reject(effect with { Contributions = [new(new("Gift", effect.Id, lab.Id(4), lab.Id(1)), 10)] });
        Reject(effect with { Material = effect.Material.SetItem(0, effect.Material[0] with { After = effect.Material[0].After + 1 }) });
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
            h with { HeadRoles = h.HeadRoles.SetItem(lab.Role.Id, lab.Role with { Id = new(999) }) }));
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
            h with { HeadRoles = h.HeadRoles.SetItem(lab.Role.Id, lab.Role with { Household = new(999) }) }));
        HouseholdProvisionCommitment commitment = h.Commitments.Values.Single();
        EndogenousProvisionOrigin origin = (EndogenousProvisionOrigin)commitment.Provenance;
        foreach (ProvisionOrigin bad in new ProvisionOrigin[] { origin with { Contributor = lab.Id(2) },
            origin with { Authority = origin.Authority with { Role = new(999) } }, origin with { Request = origin.Created },
            new SelfProvisionOrigin(origin.Authority, origin.Proposal, origin.Request, origin.Created, true, true) })
            Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
                h with { Commitments = h.Commitments.SetItem(commitment.Id, commitment with { Provenance = bad }) }));
        Slice4Lab selfLab = new(); selfLab.Appoint(); selfLab.Commit(1); Slice4Oracle.Verify(selfLab);
        HouseholdSnapshot sh = selfLab.Sim.HouseholdSnapshot;
        HouseholdProvisionCommitment sc = sh.Commitments.Values.Single(); SelfProvisionOrigin so = (SelfProvisionOrigin)sc.Provenance;
        foreach (ProvisionOrigin bad in new ProvisionOrigin[] { so with { PrivateAuthorization = false }, so with { InstitutionalRequest = false },
            so with { Proposal = new(999) }, new EndogenousProvisionOrigin(so.Authority, so.Proposal, so.Authorization, so.Authorization, so.Created, sc.Person) })
            Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(selfLab,
                sh with { Commitments = sh.Commitments.SetItem(sc.Id, sc with { Provenance = bad }) }));
        void Reject(SemanticEvent bad) => Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
            suppliedEvents: [.. lab.Sim.History.Select(e => e.Id == effect.Id ? bad : e)]));
    }

    [TestMethod]
    public void TypedAuthorityAndPhaseCarriedStateHaveExactInventories()
    {
        Fields(typeof(HouseholdHeadRole), "Id Household Occupant Origin LastTransition");
        Fields(typeof(HouseholdDecisionContext), "Household Role Head");
        Fields(typeof(HeadTransition), "Event Role Household Previous Occupant Proposal Nominator Cohort Consents Stamp");
        Fields(typeof(HeadConsent), "Actor Capacity Accepted Event RecognitionEvidence");
        Fields(typeof(AcceptedHeadAttempt), "Role Cohort Consents");
        Fields(typeof(AcceptedCollectiveAttempt), "Authority Cost Recipient Private Request Acceptance");
        Fields(typeof(HouseholdFundingResult), "Authority Cost Private Residual Commitments PossibleParticipants Recipient ContributorTie");
        Fields(typeof(CommitmentFundingLeg), "Person Commitment Capacity Debit");
        Fields(typeof(PrivateGrainAuthorization), "Owner Amount");
        Fields(typeof(ProvisionContext), "Grain NeedsGrain AttitudeTowardHead Head NeedyParticipants");
        Fields(typeof(ProvisionRefusal), "Key Cycle Event Context EligibleSupportCohort MaterialNeedChange");
        Fields(typeof(HouseholdMaterialNeedOccurrence), "Kind Authority Person Association Cause Time Dowry Evidence");
        Fields(typeof(ProvisionNeedUpdate), "Process Refusal Occurrence");
        Fields(typeof(EndogenousProvisionOrigin), "Authority Proposal Request Acceptance Created Contributor");
        Fields(typeof(SelfProvisionOrigin), "Authority Proposal Authorization Created InstitutionalRequest PrivateAuthorization");
        Fields(typeof(Proposal), "Id Actor Terms HouseholdContext HeadAttempt CollectiveAttempt LiveFunding");
        string[] actual = typeof(ActionTerms).Assembly.GetTypes().Where(t => t.BaseType == typeof(ActionTerms)).Select(t => t.Name).Order(StringComparer.Ordinal).ToArray();
        string[] expected = "Farm OfferGift RequestGiftOrHelp OfferLoan RequestLoan RepayDebt OfferBenefitForFavor RelationshipMediatedReciprocalHelp CallFavor CancelReciprocalFavours ProposeMarriage MoveResidence InviteResidence CommunicateClaim RequestHouseholdParticipation InviteHouseholdParticipation EndHouseholdParticipation NominateHouseholdHead RequestProvisionCommitment AuthorizeOwnProvisionCommitment HouseholdSupport RequestHouseholdSupport ProposeMediatedMarriage".Split(' ').Order(StringComparer.Ordinal).ToArray();
        CollectionAssert.AreEqual(expected, actual);
        Assert.AreNotEqual(typeof(HouseholdHeadRoleId), typeof(PersonId)); Assert.AreNotEqual(typeof(HouseholdHeadRoleId), typeof(HouseholdId));
        string oracle = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/Slice4Oracle.cs"));
        foreach (string forbidden in new[] { "HouseholdRules.", "HouseholdHeadRules.", "HeadRecognitionRules.", "HouseholdFunding.", "HouseholdCollectiveRules.", "ReferenceScorer.", "ResolutionFallbacks(", "RunCycle(", "new Simulation", "MobilizableCapacity(" })
            Assert.IsFalse(oracle.Contains(forbidden, StringComparison.Ordinal), forbidden);
        string allocator = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim/HouseholdCollectiveExecution.cs"));
        string commit = allocator[allocator.IndexOf("private SemanticEvent CommitCollective", StringComparison.Ordinal)..];
        Assert.Contains("proposal.LiveFunding", commit); Assert.IsFalse(commit.Contains("HouseholdFunding.Evaluate", StringComparison.Ordinal));
        string dependency = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim/ResolutionDependencies.cs"));
        Assert.Contains("HouseholdFunding.Participants", dependency); Assert.IsFalse(dependency.Contains("ExposedCapacity", StringComparison.Ordinal));

        static void Fields(Type type, string names)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            CollectionAssert.AreEqual(names.Split(' ').Select(n => "<" + n + ">k__BackingField").Order(StringComparer.Ordinal).ToArray(),
                fields.Select(f => f.Name).Order(StringComparer.Ordinal).ToArray(), type.Name);
            Assert.IsTrue(fields.All(f => f.IsInitOnly), type.Name);
        }
    }

    [TestMethod]
    public void ConsentOriginAndMediatedEffectCorruptionsAreRejected()
    {
        Slice4Lab lab = new(); lab.Appoint(); lab.Commit(); lab.InformGroom();
        lab.Step(4, new ProposeMediatedMarriage(lab.H, lab.Id(1), lab.Id(2), 3)); Slice4Oracle.Verify(lab);
        HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
        HeadTransition t = h.HeadTransitions.Values.Single();
        foreach (HeadTransition bad in new[] { t with { Consents = t.Consents.RemoveAt(0) }, t with { Cohort = t.Cohort.RemoveAt(0) },
            t with { Nominator = lab.Id(4) }, t with { Stamp = t.Stamp with { Time = new(0, 0) } } })
            Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, h with { HeadTransitions = h.HeadTransitions.SetItem(t.Event, bad) },
                [.. lab.Sim.History.Select(e => e.Id == t.Event ? e with { HeadTransition = bad } : e)]));
        HouseholdProvisionCommitment c = h.Commitments.Values.Single();
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
            h with { Commitments = h.Commitments.SetItem(c.Id, c with { Provenance = new ProvisionFixtureProvenance("fake", "fake", "fake") }) }));
        var origin = (EndogenousProvisionOrigin)c.Provenance;
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab,
            h with { Commitments = h.Commitments.SetItem(c.Id, c with { Provenance = origin with { Acceptance = origin.Request } }) }));
        WorldSnapshot world = lab.Sim.Snapshot;
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, suppliedWorld: world with { Marriages = ImmutableDictionary<RelationId, Marriage>.Empty }));
        Favour favour = world.Favours.Values.Single();
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, suppliedWorld: world with { Favours = world.Favours.SetItem(favour.Id, favour with { Holder = lab.Id(3) }) }));
        Assert.Throws<AssertFailedException>(() => Slice4Oracle.Verify(lab, suppliedWorld: world with { Favours = ImmutableDictionary<RelationId, Favour>.Empty }));
    }

    [TestMethod]
    public void ImmutableQueriesRebuildAndDuplicateClosureAreInert()
    {
        Slice4Lab lab = new(need: true); lab.Appoint(); lab.Commit();
        lab.BoundaryChallenges.Add("Replace HouseholdState with its detached identical copy; inject inherited DuplicateCauses reaction challenge. No expected role, commitment or material result is written.");
        HouseholdSnapshot before = lab.Sim.HouseholdSnapshot;
        var stateField = typeof(Simulation).GetField("households", BindingFlags.NonPublic | BindingFlags.Instance)!;
        var authoritative = (HouseholdState)stateField.GetValue(lab.Sim)!;
        HouseholdState detached = authoritative.Copy();
        stateField.SetValue(lab.Sim, detached);
        for (int i = 0; i < 5; i++)
        {
            Assert.AreEqual(before.HeadRoles.Values.Single(), detached.Snapshot(lab.Sim.Snapshot.Cycle).HeadRoles.Values.Single());
            Assert.AreEqual(before.MobilizableCapacity(lab.H, lab.Sim.Snapshot), detached.Snapshot(lab.Sim.Snapshot.Cycle).MobilizableCapacity(lab.H, lab.Sim.Snapshot));
            _ = lab.Sim.EpistemicStateOf(lab.Id(1)); _ = lab.Sim.History; _ = lab.Sim.DecisionHistory;
        }
        typeof(Simulation).GetProperty("Challenge", BindingFlags.NonPublic | BindingFlags.Instance)!.SetValue(lab.Sim, Simulation.ReactionChallenge.DuplicateCauses);
        lab.Step(1, new HouseholdSupport(lab.H, lab.Id(2)), true);
        Assert.IsTrue(before.HeadRoles.Values.Single().Occupant == lab.Id(1)); Assert.AreEqual(1, lab.Sim.History.Count(e => e.Funding is not null));
        Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.HeadTransitions.Count);
        Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Commitments.Count);
        foreach (var cycle in lab.Sim.History.GroupBy(e => e.Cycle))
            Assert.IsTrue(cycle.Select(e => e.ReactionIndex).SequenceEqual(Enumerable.Range(0, cycle.Count())));
        Slice4Oracle.Verify(lab);
    }
}
