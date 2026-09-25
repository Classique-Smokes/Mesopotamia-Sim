using System.Collections.Immutable;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record Slice5Case(string Name, string[] Codes, Action Run);

internal sealed partial class Slice5Scenarios
{
    internal List<object> Producers { get; } = [];
    internal List<object> Mutations { get; } = [];
    private static PersonId P(int n) => new(n);
    private static Proposal Proposal(long id, int actor, ActionTerms terms, HouseholdDecisionContext? context = null) =>
        new(new(id), P(actor), terms) { HouseholdContext = context };
    internal static InitialWorld World(long grain = 40, ImmutableArray<GrainInput> inputs = default) =>
        new([new(P(1), "A", Sex.Male, grain), new(P(2), "B", Sex.Female, grain), new(P(3), "C", Sex.Male, grain)],
            [new(new(1))], [new(new(1), P(1), new(1)), new(new(2), P(2), new(1)), new(new(3), P(3), new(1))],
            [new(new(4), P(1), P(1), 9), new(new(5), P(1), P(2), 80), new(new(6), P(2), P(1), 80)],
            [], [], inputs.IsDefault ? [] : inputs, new("IMP-0005-nondefault-v1"));

    internal Simulation Capture(Simulation sim, string scenario, object producer)
    {
        byte[] bytes = sim.CaptureCheckpoint();
        Simulation restored = Simulation.RestoreCheckpoint(bytes, sim.Configuration);
        Slice5Oracle.EqualBoundary(sim, restored);
        Producers.Add(new
        {
            Scenario = scenario,
            CaptureCycle = sim.Snapshot.Cycle,
            Producer = producer,
            ProducerPass = true,
            FixtureWrites = "Declared lower-level initial prerequisites and recorded public runtime inputs only",
            CheckpointDigest = Convert.ToHexStringLower(SHA256.HashData(bytes)),
            Configuration = sim.Configuration.Version,
            Rules = new[] { "SFL-S2-v1", "SFL-S3-v1", "SFL-S4-v1" },
            History = sim.History.Select(e => new { e.Id, e.Cycle, e.ReactionIndex, e.Kind })
        });
        return restored;
    }

    internal static CycleResult Pair(Simulation original, Simulation restored, CycleInput input)
    {
        CycleResult a = original.RunCycle(input), b = restored.RunCycle(input);
        Slice5Oracle.Same(a, b, "cycle result");
        Slice5Oracle.EqualBoundary(original, restored);
        return a;
    }

    internal IEnumerable<Slice5Case> All()
    {
        yield return new("SafeBoundariesAndFaults", ["001", "002", "003", "004", "005", "006", "032", "080", "R04"], Boundaries);
        yield return new("WorldTimingHistoryAndDiagonal", ["010", "011", "015", "016", "017", "019", "020", "021", "030", "031", "032", "033", "034", "035", "036", "040", "041", "050", "051", "052", "054", "R01", "R08"], WorldContinuation);
        yield return new("HouseholdRoleProvisionAndFunding", ["012", "013", "019", "030", "031", "034", "040", "041", "R02", "R03", "R09"], HouseholdContinuation);
        yield return new("HistoricalNeedCooldownAndReset", ["014", "053", "R03"], Reconsideration);
        yield return new("CandidateSupportsAndLineageContinuation", ["012", "018", "041", "042", "093", "R02"], () => HouseholdScenarios.CheckpointLineage(this));
        yield return new("EvidenceGapAndConsumedProposal", ["035", "041", "042", "043", "044", "045", "093"], EvidenceGap);
        yield return new("RepresentationRebuildAndObserver", ["037", "046", "070", "071", "072", "074", "092", "124", "R05", "R06", "R07"], Representation);
        yield return new("StructuralAndOracleIndependence", ["055", "081", "082", "083", "084", "090", "091", "092", "093", "125", "126"], Structural);
        yield return new("CompatibilityAndInvalidStructure", ["065", "068", "123"], InvalidStructure);
        yield return new("DependentOmissionCampaign", ["060", "061", "062", "063", "064", "066", "067", "085"], OmissionCampaign);
        yield return new("StaleDerivedBehaviorChallenge", ["069", "073", "074"], StaleDerived);
        yield return new("FixtureDiagonalValidation", ["021", "090"], FixtureDiagonalValidation);
    }

    private void Boundaries()
    {
        Simulation sim = new(World());
        Assert.ThrowsExactly<InvalidOperationException>(() => sim.CaptureCheckpoint());
        sim.RunCycle(CycleInput.Empty);
        List<string> observed = [];
        sim.RunCycle(new([Proposal(10, 1, new OfferGift(P(2), 1))]), phase =>
        {
            observed.Add(phase);
            Assert.ThrowsExactly<InvalidOperationException>(() => sim.CaptureCheckpoint());
        });
        CollectionAssert.AreEqual(new[] { "Resolution", "Reactions" }, observed);
        Simulation restored = Capture(sim, "Boundary", "Runtime gift and completed automatic attitude closure");
        long cycle = sim.Snapshot.Cycle;
        SemanticEvent[] prefix = [.. sim.History];
        Pair(sim, restored, CycleInput.Empty);
        Assert.AreEqual(cycle + 1, restored.Snapshot.Cycle);
        Slice5Oracle.PrefixAndOrder(restored, prefix);
        Simulation failed = new(World()) { Challenge = Simulation.ReactionChallenge.SkipClosure };
        Assert.ThrowsExactly<InvalidOperationException>(() => failed.RunCycle(new([Proposal(1, 1, new OfferGift(P(2), 1))])));
        Assert.IsTrue(failed.IsFaulted); Assert.AreEqual(0L, failed.Snapshot.Cycle);
        Assert.ThrowsExactly<InvalidOperationException>(() => failed.CaptureCheckpoint());
        Simulation overflow = new(World(long.MaxValue));
        Assert.ThrowsExactly<OverflowException>(() => overflow.RunCycle(new([Proposal(1, 1, new Farm())])));
        Assert.ThrowsExactly<InvalidOperationException>(() => overflow.CaptureCheckpoint());
        Simulation challenge = new(World()) { Challenge = Simulation.ReactionChallenge.ReverseCauses };
        challenge.RunCycle(CycleInput.Empty);
        Assert.ThrowsExactly<InvalidOperationException>(() => challenge.CaptureCheckpoint());
    }

    private void WorldContinuation()
    {
        InitialWorld initial = World(inputs: [new(2, 5, P(1), 3), new(1, 1, P(1), 1), new(3, 5, P(1), -1)]);
        Simulation sim = new(initial);
        CycleInput loan = new([Proposal(41, 1, new OfferLoan(P(2), 3))]);
        sim.RunCycle(loan);
        CycleInput favour = new([Proposal(87, 1, new OfferBenefitForFavor(P(3), 1))]);
        sim.RunCycle(favour);
        Debt debt = sim.Snapshot.Debts.Values.Single(); Favour obligation = sim.Snapshot.Favours.Values.Single();
        Simulation restored = Capture(sim, "World", new { Initial = initial, Inputs = new[] { loan, favour } });
        SemanticEvent[] prefix = [.. sim.History];
        Pair(sim, restored, new([Proposal(100, 1, new CallFavor(obligation.Id, new Farm()))]));
        CycleResult due = Pair(sim, restored, new([Proposal(101, 2, new RepayDebt(debt.Id, 1))]));
        SemanticEvent review = due.Events.Single(e => e.Kind == "DebtSocialDueReview");
        Assert.AreEqual(4L, review.Cycle); Assert.AreEqual("UnpaidBalance", review.Detail);
        Assert.AreEqual(debt.Origin, review.Causes.Single());
        Assert.AreEqual(2L, sim.Snapshot.Debts[debt.Id].Remaining);
        CycleResult fifth = Pair(sim, restored, new([Proposal(102, 1, new OfferGift(P(1), 1))]));
        Assert.AreEqual(OutcomeKind.InvalidTerms, fifth.Outcomes.Single().Kind);
        Assert.AreEqual("InvalidCounterparty", fifth.Outcomes.Single().Reason);
        CollectionAssert.AreEqual(new[] { "Input:2", "Input:3" }, fifth.Events.Where(e => e.Kind == "ExogenousGrain").Select(e => e.Detail).ToArray());
        Assert.AreEqual(7, sim.Snapshot.Attitudes[new(4)].Value);
        Assert.IsTrue(sim.EpistemicStateOf(P(1)).Facts.Any(f => f.Proposition is AttitudeFact a && a.Attitude.Id == new RelationId(4) && a.Attitude.Value == 7));
        Pair(sim, restored, new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(P(1), new()) });
        Assert.AreEqual(1, sim.History.Count(e => e.Kind == "DebtSocialDueReview"));
        Assert.AreEqual(1, sim.History.Count(e => e.Detail == "Input:1"));
        Assert.IsFalse(sim.Snapshot.Favours[obligation.Id].Outstanding);
        Slice5Oracle.PrefixAndOrder(restored, prefix);
        foreach (int sign in new[] { 0, 1 })
        {
            Simulation zero = new(World(0, [new(1, 4, P(1), sign * 3)]));
            zero.RunCycle(CycleInput.Empty);
            Simulation copy = Capture(zero, "InputDeadlock", new { Grain = 0, Delta = sign * 3 });
            bool deadlock = Pair(zero, copy, CycleInput.Empty).MaterialDeadlock;
            Assert.AreEqual(sign == 0, deadlock);
            Pair(zero, copy, CycleInput.Empty);
            CycleResult arrival = Pair(zero, copy, CycleInput.Empty);
            Assert.AreEqual(1, arrival.Events.Count(e => e.Kind == "ExogenousGrain"));
        }
    }

    private void HouseholdContinuation()
    {
        Slice4Lab lab = new(bridge: true);
        lab.Appoint(); lab.Commit(); lab.Commit(1); lab.InformGroom();
        Simulation restored = Capture(lab.Sim, "Household", new { lab.Initial, Inputs = lab.Inputs.Select(i => i.Proposals), lab.FormationProducerVerified });
        HouseholdDecisionContext context = lab.Context;
        Proposal marriage = Proposal(1000, 4, new ProposeMediatedMarriage(lab.H, P(1), P(2), 3));
        CycleResult funded = Pair(lab.Sim, restored, new([marriage])
        {
            FundingPolicies = ImmutableDictionary<ProposalId, HouseholdFundingPolicy>.Empty.Add(marriage.Id, new(1, true))
        });
        Assert.AreEqual(OutcomeKind.Committed, funded.Outcomes.Single().Kind);
        HouseholdFundingResult funding = funded.Events.Single(e => e.Funding is not null).Funding!;
        Assert.AreEqual(1L, funding.Private!.Amount); Assert.AreEqual(2L, funding.Residual);
        Assert.AreEqual(2L, funding.Commitments.Sum(c => c.Debit));
        Pair(lab.Sim, restored, new([Proposal(1001, 1, new EndHouseholdParticipation(lab.H))]));
        Assert.IsNull(lab.Sim.HouseholdSnapshot.HeadRoles[context.Role].Occupant);
        Assert.IsTrue(lab.Sim.HouseholdSnapshot.Commitments.Values.Single(c => c.Person == P(1)).TerminatedBy is not null);
        CycleResult succession = Pair(lab.Sim, restored, new([Proposal(1002, 2, new NominateHouseholdHead(lab.H, P(2), true, true))]));
        Assert.AreEqual(OutcomeKind.Committed, succession.Outcomes.Single().Kind);
        Assert.AreEqual(P(2), restored.HouseholdSnapshot.HeadRoles[context.Role].Occupant);
        Pair(lab.Sim, restored, new([Proposal(1003, 2, new EndHouseholdParticipation(lab.H))]));
        Assert.AreEqual(HouseholdLifecycle.Inactive, restored.HouseholdSnapshot.Households[lab.H].Lifecycle);
        Pair(lab.Sim, restored, new([Proposal(1004, 3, new EndHouseholdParticipation(lab.H))]));
        Assert.AreEqual(HouseholdLifecycle.Dissolved, restored.HouseholdSnapshot.Households[lab.H].Lifecycle);
        Assert.IsTrue(restored.HouseholdSnapshot.Commitments.Values.All(c => c.TerminatedBy is not null));
    }

    private static ImmutableArray<GrainInput> StableTargetInputs() =>
        [.. Enumerable.Range(10, 12).Select(c => new GrainInput(c, c, P(2), 1))];

    private Slice4Lab HistoricalNeedLab()
    {
        Slice4Lab lab = new(inputs: [.. StableTargetInputs(), new(100, 10, P(1), -87),
            .. Enumerable.Range(11, 11).Select(c => new GrainInput(c + 100, c, P(1), 1))]);
        lab.Appoint(); lab.InformGroom();
        Proposal request = lab.Proposal(1, new RequestProvisionCommitment(lab.H, P(2)), true);
        lab.Run(new([request]) { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(request.Id, ResponseChoice.Decline) });
        lab.Step(4, new ProposeMediatedMarriage(lab.H, P(1), P(2), 3));
        Assert.IsNotNull(lab.Sim.HouseholdSnapshot.ProvisionRefusals[new(lab.H, P(2))].MaterialNeedChange);
        return lab;
    }

    private void Reconsideration()
    {
        Slice4Lab lab = HistoricalNeedLab();
        Simulation restored = Capture(lab.Sim, "DEC0014", new { lab.Initial, Inputs = lab.Inputs.Select(i => i.Proposals) });
        for (int i = 0; i < 2; i++)
            Assert.AreEqual("ProvisionCooldown", Pair(lab.Sim, restored, new([Proposal(1000 + i, 1,
                new RequestProvisionCommitment(lab.H, P(2)), lab.Context)])).Outcomes.Single().Reason);
        Proposal refusal = Proposal(1002, 1, new RequestProvisionCommitment(lab.H, P(2)), lab.Context);
        Assert.AreEqual(OutcomeKind.Declined, Pair(lab.Sim, restored, new([refusal])
        { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(refusal.Id, ResponseChoice.Decline) }).Outcomes.Single().Kind);
        Assert.IsNull(restored.HouseholdSnapshot.ProvisionRefusals[new(lab.H, P(2))].MaterialNeedChange);
        for (int i = 0; i < 3; i++) Pair(lab.Sim, restored, CycleInput.Empty);
        Assert.AreEqual("ProvisionContextUnchanged", Pair(lab.Sim, restored, new([Proposal(1003, 1,
            new RequestProvisionCommitment(lab.H, P(2)), lab.Context)])).Outcomes.Single().Reason);
    }

    private void EvidenceGap()
    {
        // A stale fixture fact held by A is reported after B has newer direct evidence.
        // Receive allocates an ID, then supersession discards the incoming fact.
        InitialWorld initial = World() with
        {
            Knowledge = [new(P(1), [new(new(100), new OwnStateFact(new(P(2), "B", Sex.Female, 99)),
                new(AcquisitionRoute.Fixture, new(null, null, new(0, 0), "stale-report"), []))])]
        };
        Simulation sim = new(initial);
        sim.RunCycle(CycleInput.Empty);
        KnownFact stale = sim.EpistemicStateOf(P(1)).Facts.Single(f => f.Id == new EvidenceId(100));
        long before = (long)Slice5Oracle.Field(Slice5Oracle.Field(sim, "epistemic"), "nextEvidence");
        sim.RunCycle(new([Proposal(77, 1, new CommunicateClaim(P(2), new HeldFact(stale.Id)))]));
        long next = (long)Slice5Oracle.Field(Slice5Oracle.Field(sim, "epistemic"), "nextEvidence");
        // A final direct test of the actual reachable gap is kept separate from the
        // general frontier equality check; no fixture writes an allocator.
        Assert.IsTrue(next > sim.EpistemicSnapshot.Actors.Values.SelectMany(a => a.Facts).Max(f => f.Id.Value));
        HashSet<long> held = [.. sim.EpistemicSnapshot.Actors.Values.SelectMany(a => a.Facts).Select(f => f.Id.Value)];
        Assert.IsTrue(Enumerable.Range(checked((int)before), checked((int)(next - before))).Any(id => !held.Contains(id)),
            "Runtime allocation must contain an actual discarded evidence gap.");
        Simulation restored = Capture(sim, "EvidenceGap", new { Initial = initial, UsedProposal = 77 });
        Assert.ThrowsExactly<ArgumentException>(() => restored.RunCycle(new([Proposal(77, 1, new Farm())])));
        Pair(sim, restored, new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(P(1), new()) });
        Assert.AreEqual(78L, sim.History.Last(e => e.Kind == "Proposal").Proposal!.Value.Value);
        Assert.IsTrue(sim.EpistemicSnapshot.Actors.Values.SelectMany(a => a.Facts).Any(f => f.Id.Value >= next));
    }

    private void Representation()
    {
        Simulation sim = new(World(5));
        sim.RunCycle(CycleInput.Empty);
        byte[] bytes = sim.CaptureCheckpoint();
        JsonObject envelope = JsonNode.Parse(bytes)!.AsObject();
        foreach (string key in new[] { "People", "Dwellings", "Residences", "Attitudes", "Kinships", "Marriages", "Debts", "Favours" })
        {
            JsonArray values = envelope["World"]![key]!.AsArray();
            envelope["World"]![key] = new JsonArray(values.Reverse().Select(v => v!.DeepClone()).ToArray());
        }
        JsonObject reversed = new();
        foreach (string key in new[] { "Actors", "Candidates" })
        {
            JsonArray values = envelope["Epistemic"]![key]!.AsArray();
            envelope["Epistemic"]![key] = new JsonArray(values.Reverse().Select(v => v!.DeepClone()).ToArray());
        }
        foreach (var property in envelope.Reverse()) reversed.Add(property.Key, property.Value?.DeepClone());
        Simulation restored = Simulation.RestoreCheckpoint(JsonSerializer.SerializeToUtf8Bytes(reversed), sim.Configuration);
        Slice5Oracle.EqualBoundary(sim, restored);
        restored.RebuildPublishedState();
        Slice5Oracle.EqualBoundary(sim, restored);
        for (int i = 0; i < 4; i++)
        {
            _ = restored.CaptureCheckpoint(); _ = restored.History; _ = restored.EpistemicStateOf(P(1));
            Pair(sim, restored, new([Proposal(100 + i * 2, 1, new OfferGift(P(3), 2)), Proposal(101 + i * 2, 2, new RequestGiftOrHelp(P(1), 2))]));
        }
        Simulation again = Capture(restored, "RepeatedRestore", "Runtime conflict suffix after representation permutation");
        Pair(restored, again, CycleInput.Empty);
        Assert.IsTrue(restored.History.Any(e => e.TechnicalFallback), "Fixture must exercise actual fallback.");
        Assert.IsTrue(restored.History.Any(e => e.Kind == "InvalidatedAtResolution"), "Fixture must exercise a resolution invalidation.");
        long originalCycle = sim.Snapshot.Cycle;
        again.RunCycle(CycleInput.Empty);
        Assert.AreEqual(originalCycle, sim.Snapshot.Cycle);
    }

    private static void Structural()
    {
        new Slice4AssuranceTests().TypedAuthorityAndPhaseCarriedStateHaveExactInventories();
        string[] world = typeof(WorldState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order().ToArray();
        CollectionAssert.AreEqual(new[] { "People", "Dwellings", "Residences", "Attitudes", "Kinships", "Marriages", "Debts", "Favours" }
            .Select(n => "<" + n + ">k__BackingField").Append("nextRelation").Order().ToArray(), world);
        string[] h = "HeadRoles HeadTransitions ProvisionRefusals Households Formations Associations Entries Exits Continuations Lineages Commitments Supports".Split(' ');
        CollectionAssert.AreEqual(h.Select(n => "<" + n + ">k__BackingField")
            .Concat("nextHeadRole nextHousehold nextWarrant nextAssociation nextCommitment".Split(' ')).Order().ToArray(),
            typeof(HouseholdState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order().ToArray());
        foreach (Type owner in new[] { typeof(WorldState), typeof(EpistemicState), typeof(HouseholdState), typeof(Simulation) })
            Assert.IsFalse(owner.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Any(f => f.FieldType.Name.EndsWith("Checkpoint", StringComparison.Ordinal)));
        string oracle = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/Slice5Oracle.cs"));
        foreach (string forbidden in new[] { "CheckpointCodec.", "RestoreCheckpoint(", "CaptureCheckpoint(", "HouseholdProjectionKey(", "EpistemicRules.", "HouseholdFunding.", "ReferenceScorer." })
            Assert.IsFalse(oracle.Contains(forbidden, StringComparison.Ordinal), forbidden);
        Assert.IsFalse(typeof(Simulation).Assembly.GetTypes().Any(t => t.Name is "PendingProcess" or "Workflow" or "EventStore"));
        CollectionAssert.AreEqual("facts candidates nextEvidence".Split(' ').Order().ToArray(),
            typeof(EpistemicState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order().ToArray());
        CollectionAssert.AreEqual("state initial cycle published epistemic publishedEpistemic events nextEvent reactionIndex faulted usedProposals knowledge decisionHistory nextProposal households publishedHouseholds <Challenge>k__BackingField"
            .Split(' ').Order().ToArray(), typeof(Simulation).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order().ToArray());
    }

    private void FixtureDiagonalValidation()
    {
        InitialWorld Seed(FactualProposition proposition) => World() with
        {
            Knowledge = [new(P(1), [new(new(100), proposition, new(AcquisitionRoute.Fixture, new(null, null, new(0, 0), "diagonal-seed"), []))])]
        };
        Simulation sim = new(Seed(new AttitudeFact(new(new(4), P(1), P(1), 9))));
        sim.RunCycle(CycleInput.Empty);
        _ = Capture(sim, "FixtureDiagonal", "Valid fixture AttitudeFact plus runtime-acquired direct fact and completed cycle");
        foreach (FactualProposition invalid in new FactualProposition[]
        {
            new KinshipFact(new(new(100), P(1), P(1), KinshipKind.Sibling)),
            new MarriageFact(new(new(100), P(1), P(1))),
            new DebtFact(new(new(100), P(1), P(1), 1, 1, 0, false, new(1))),
            new FavourFact(new(new(100), P(1), P(1), true, new(1))),
            new SupportFact(new(1), 1, P(1), P(1), SupportKind.Gift)
        }) Assert.ThrowsExactly<ArgumentException>(() => new Simulation(Seed(invalid)));
    }

    private void InvalidStructure()
    {
        Simulation sim = new(World()); sim.RunCycle(CycleInput.Empty);
        byte[] bytes = sim.CaptureCheckpoint();
        Assert.ThrowsExactly<InvalidDataException>(() => Simulation.RestoreCheckpoint(bytes, new("different")));
        foreach (string field in new[] { "Rules", "World", "Epistemic", "Households", "NextProposal", "UsedProposals" })
        {
            JsonObject node = JsonNode.Parse(bytes)!.AsObject(); node.Remove(field);
            Assert.ThrowsExactly<InvalidDataException>(() => Simulation.RestoreCheckpoint(JsonSerializer.SerializeToUtf8Bytes(node), sim.Configuration), field);
        }
        SimulationCheckpoint c = CheckpointCodec.Decode(bytes);
        foreach (SimulationCheckpoint bad in new[] { c with { Format = 2 }, c with { Rules = ["wrong"] },
            c with { Bootstrap = c.Bootstrap with { Configuration = new("different") } },
            c with { Events = [c.Events[0] with { Causes = [new(999999)] }, .. c.Events.Skip(1)] } })
            Assert.ThrowsExactly<InvalidDataException>(() => Simulation.RestoreCheckpoint(CheckpointCodec.Encode(bad), sim.Configuration));
        Mutations.Add(new { Name = "MissingConfigRulesAndSeveredOrigin", Classification = "required-structural-rejection", IntendedAssertion = "InvalidDataException" });
    }
}
