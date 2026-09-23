using System.Collections.Immutable;
using System.Text.Json;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record Slice2Case(string Name, string[] Ids, string Fixture, string Oracle, Action Run);

// This suite uses the public boundary and explicit expected values. No production
// acquisition, recognition, precedence, candidate or provenance helper is an oracle.
internal sealed class Slice2Scenarios
{
    private readonly List<object> audit = [];
    private readonly List<(InitialWorld Initial, Simulation Sim, List<CycleInput> Inputs)> worlds = [];
    internal IReadOnlyList<object> Audit => audit;
    internal void Begin() => worlds.Clear();
    internal void AuditCase(Slice2Case scenario)
    {
        foreach (var w in worlds)
        {
            InvariantOracle.Verify(w.Initial, w.Sim.Snapshot, w.Sim.History, w.Sim.DecisionHistory);
            audit.Add(new
            {
                scenario.Name,
                scenario.Ids,
                scenario.Fixture,
                scenario.Oracle,
                InitialWorld = w.Initial,
                EpistemicPrestate = w.Initial.Knowledge,
                CandidateReferents = w.Initial.Candidates,
                CycleInputs = w.Inputs.Select(i => new
                {
                    Proposals = i.Proposals.Select(p => new { p.Id, p.Actor, Terms = p.Terms.ToString() }),
                    Responses = i.Responses.ToArray(),
                    ResponseProfiles = i.ResponseProfiles.ToArray(),
                    PersonalPolicies = i.PersonalPolicies.Select(p => new
                    {
                        p.Key,
                        p.Value.Profile,
                        Communication = p.Value.Communication?.ToString(),
                        p.Value.Amount,
                        p.Value.GiftTarget,
                        p.Value.ObservedPeople,
                        p.Value.ObservedDebts,
                        Sexes = p.Value.ObservedSexes.ToArray(),
                        Residences = p.Value.ObservedResidences.ToArray()
                    })
                }),
                Writes = "Initial constructor inputs and public RunCycle only; no recipient-result writes",
                FinalObjective = new
                {
                    w.Sim.Snapshot.Cycle,
                    People = w.Sim.Snapshot.People.Values.ToArray(),
                    Residences = w.Sim.Snapshot.Residences.Values.ToArray(),
                    Debts = w.Sim.Snapshot.Debts.Values.ToArray(),
                    Favours = w.Sim.Snapshot.Favours.Values.ToArray(),
                    Attitudes = w.Sim.Snapshot.Attitudes.Values.ToArray()
                },
                FinalEpistemic = w.Sim.EpistemicSnapshot.Actors.Values.ToArray(),
                History = w.Sim.History,
                Decisions = w.Sim.DecisionHistory,
                InvariantAudit = "PASS"
            });
        }
    }
    private Simulation Create(InitialWorld initial)
    {
        Simulation sim = new(initial);
        worlds.Add((initial, sim, []));
        return sim;
    }
    private CycleResult Run(Simulation sim, CycleInput input)
    {
        worlds.Single(w => w.Sim == sim).Inputs.Add(input);
        return sim.RunCycle(input);
    }
    private CycleResult Send(Simulation sim, long sender, long recipient, HeldClaim claim) => Run(sim, new([])
    {
        PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(sender),
            new("SFL-COMMUNICATION-LAB-v1") { Communication = new(new(recipient), claim) })
    });
    private static InitialWorld World(long offset = 0) => new(
        [.. Enumerable.Range(1, 6).Select(i => new Person(new(offset + i), "P" + i, i % 2 == 0 ? Sex.Female : Sex.Male, 100))],
        [new(new(offset + 1)), new(new(offset + 2))],
        [.. Enumerable.Range(1, 6).Select(i => new Residence(new(offset + i), new(offset + i), new(offset + 1)))],
        [], [], [], [], new());
    private static KnownFact Seed(long id, FactualProposition proposition, EvidenceOrder? order = null, EventId? source = null) =>
        new(new(id), proposition, new(AcquisitionRoute.Fixture, new(null, source, order, "controlled-prestate"), []));
    private static InitialWorld RecognitionWorld(long offset = 0, bool reverse = false, bool live = true)
    {
        KnownFact[] positive = [
            Seed(offset + 101, new ResidenceFact(new(offset + 4), new(offset + 1))),
            Seed(offset + 102, new ResidenceFact(new(offset + 5), new(offset + 1))),
            Seed(offset + 103, new KinshipFact(new(new(offset + 90), new(offset + 4), new(offset + 5), KinshipKind.Sibling))),
            Seed(offset + 104, new SupportFact(new(offset + 901), 1, new(offset + 4), new(offset + 5), SupportKind.Gift)),
            Seed(offset + 105, new SupportFact(new(offset + 902), 2, new(offset + 4), new(offset + 5), SupportKind.Loan))];
        InitialWorld world = World(offset) with
        {
            Candidates = [new(new(offset + 1), [new(offset + 4), new(offset + 5)], live)],
            Knowledge = [new(new(offset + 1), [.. reverse ? positive.Reverse() : positive]),
                new(new(offset + 2), [Seed(offset + 106, new ResidenceFact(new(offset + 4), new(offset + 2)))])]
        };
        return reverse ? world with { People = [.. world.People.Reverse()], Residences = [.. world.Residences.Reverse()], Knowledge = [.. world.Knowledge.Reverse()] } : world;
    }
    private static KnownFact Fact<T>(Simulation sim, long actor, Func<T, bool>? predicate = null) where T : FactualProposition =>
        sim.EpistemicStateOf(new(actor)).Facts.Single(f => f.Proposition is T t && (predicate is null || predicate(t)));
    private static bool Has<T>(Simulation sim, long actor, Func<T, bool>? predicate = null) where T : FactualProposition =>
        sim.EpistemicStateOf(new(actor)).Facts.Any(f => f.Proposition is T t && (predicate is null || predicate(t)));
    private static void Equal<T>(T expected, T actual) => Assert.AreEqual(expected, actual);
    private static void True(bool value) => Assert.IsTrue(value);
    private static string Json<T>(T value) => JsonSerializer.Serialize(value);
    private static string Canonical(Simulation sim) => Json(new
    {
        People = sim.Snapshot.People.OrderBy(p => p.Key.Value),
        Residences = sim.Snapshot.Residences.OrderBy(p => p.Key.Value),
        Debts = sim.Snapshot.Debts.OrderBy(p => p.Key.Value),
        Epistemic = sim.EpistemicSnapshot.Actors.OrderBy(p => p.Key.Value),
        sim.History,
        sim.DecisionHistory
    });

    internal IEnumerable<Slice2Case> All()
    {
        yield return new("AutomaticAcquisition", ["S2-003", "S2-010", "S2-011", "S2-012", "S2-013"], "F-ACQUIRE", "O-PUBLIC/O-PROV", () =>
        {
            Simulation sim = Create(World());
            KnownFact own = Fact<OwnStateFact>(sim, 1);
            Equal(AcquisitionRoute.OwnState, own.Provenance.Route);
            Equal(100L, ((OwnStateFact)own.Proposition).Person.Grain);
            Run(sim, new([new(new(1), new(1), new OfferLoan(new(2), 8))]));
            foreach (long actor in new[] { 1L, 2L })
            {
                KnownFact debt = Fact<DebtFact>(sim, actor);
                Equal(8L, ((DebtFact)debt.Proposition).Debt.Remaining);
                Equal(AcquisitionRoute.DirectParty, debt.Provenance.Route);
                Equal(sim.History.Single(e => e.Kind == "Loan").Id, debt.Provenance.Origin.Event);
                True(Has<ParticipationFact>(sim, actor, f => f.Outcome.Kind == OutcomeKind.Committed));
                Equal(AcquisitionRoute.Participation, Fact<ParticipationFact>(sim, actor).Provenance.Route);
            }
            for (long actor = 3; actor <= 6; actor++) True(!Has<DebtFact>(sim, actor));
            Send(sim, 1, 3, new HeldFact(Fact<DebtFact>(sim, 1).Id));
            Equal(AcquisitionRoute.Communication, Fact<DebtFact>(sim, 3).Provenance.Route);
            Run(sim, new([new(new(10), new(1), new RequestGiftOrHelp(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            foreach (long actor in new[] { 1L, 2L })
                True(Has<ParticipationFact>(sim, actor, f => f.Outcome.Kind == OutcomeKind.Declined && f.Outcome.Reason == "VoluntaryRefusal"));
            Run(sim, new([new(new(11), new(1), new OfferGift(new(2), 1000))]));
            foreach (long actor in new[] { 1L, 2L })
                True(Has<ParticipationFact>(sim, actor, f => f.Outcome.Kind == OutcomeKind.Unable && f.Outcome.Reason == "InsufficientAvailableGrain"));
            int known = sim.KnowledgeOf(new(1)).Length;
            Run(sim, new([new(new(12), new(1), new OfferGift(new(2), -1))]));
            Equal(known, sim.KnowledgeOf(new(1)).Length);
            True(!Has<ParticipationFact>(sim, 3, f => f.Outcome.Proposal.Value is 10 or 11 or 12));
        });
        foreach (bool recognition in new[] { false, true })
        {
            string suffix = recognition ? "R" : "F";
            yield return new("Communication" + suffix, ["S2-020" + suffix, "S2-021" + suffix, "S2-023" + suffix,
                "S2-024" + suffix, "S2-025" + suffix, "S2-026" + suffix],
                recognition ? "F-COMM-REC/F-GATE" : "F-COMM-FACT/F-GATE", "O-PUBLIC/O-PROV/O-META", () =>
            {
                Simulation sim = Create(RecognitionWorld());
                HeldClaim claim = recognition ? new HeldRecognition(new(1)) : new HeldFact(new(101));
                ActorEpistemicState before = sim.EpistemicStateOf(new(3));
                CycleResult result = Send(sim, 1, 3, claim);
                Equal(OutcomeKind.Committed, result.Outcomes.Single().Kind);
                Equal(1, result.Decisions.Count(d => d.Actor == new PersonId(1) && d.Context == "Personal"));
                True(result.Decisions.All(d => d.Context != "Response" && d.Actor != new PersonId(3)));
                Equal(1, result.Events.Count(e => e.Kind == "Proposal" && e.Participants[0] == new PersonId(1)));
                True(result.Decisions.Single().Candidates.Single(c => c.Selected).Terms is CommunicateClaim);
                Equal(0, before.Facts.Count(f => f.Provenance.Route == AcquisitionRoute.Communication));
                KnownFact received = Fact<ResidenceFact>(sim, 3, r => r.Person == new PersonId(4));
                Equal(new PersonId(1), received.Provenance.Hops.Single().Sender);
                Equal(new PersonId(3), received.Provenance.Hops.Single().Recipient);
                Equal("controlled-prestate", received.Provenance.Origin.Fixture);
                Equal(result.Events.Single(e => e.Kind == "Communication").Id, received.Provenance.Hops.Single().Event);
                Equal(recognition ? RecognitionStatus.Recognized : RecognitionStatus.Unknown, sim.EpistemicStateOf(new(3)).RecognitionOf(new(1)));
                for (long actor = 1; actor <= 6; actor++)
                    if (actor != 3) True(sim.EpistemicStateOf(new(actor)).Facts.All(f => f.Provenance.Route != AcquisitionRoute.Communication));
                Assert.ThrowsExactly<ArgumentException>(() => sim.RunCycle(new([
                    new(new(90), new(1), new CommunicateClaim(new(3), claim)), new(new(91), new(1), new Farm())])));
            });
        }
        yield return new("StaleResidenceAndLocality", ["S2-002", "S2-006", "S2-008", "S2-027", "S2-030"], "F-STALE/F-COMM-FACT/F-META", "O-PUBLIC/O-PROV/O-META", () =>
        {
            InitialWorld initial = World() with { Residences = [.. World().Residences.Select(r => r.Person == new PersonId(2) ? r with { Dwelling = new(2) } : r)] };
            Simulation sim = Create(initial);
            KnownFact original = Fact<ResidenceFact>(sim, 1);
            Send(sim, 1, 3, new HeldFact(original.Id));
            KnownFact report = Fact<ResidenceFact>(sim, 3, r => r.Person == new PersonId(1));
            Equal(original.Provenance.Origin, report.Provenance.Origin);
            True(original.Provenance.Route != report.Provenance.Route);
            Run(sim, new([new(new(20), new(1), new MoveResidence(new(2), new(2)))]));
            Equal(new DwellingId(2), sim.Snapshot.HomeOf(new(1)));
            Equal(new DwellingId(1), ((ResidenceFact)Fact<ResidenceFact>(sim, 3, r => r.Person == new PersonId(1)).Proposition).Dwelling);
            Run(sim, CycleInput.Empty);
            Equal(report, Fact<ResidenceFact>(sim, 3, r => r.Person == new PersonId(1)));
            Simulation disconnected = Create(initial);
            for (int i = 0; i < 3; i++) Run(disconnected, CycleInput.Empty);
            // Compare the disconnected actor's propositions and provenance, excluding
            // technical evidence IDs and event ordinals shifted by unrelated events.
            Equal(Json(disconnected.EpistemicStateOf(new(6)).Facts.Select(f => new { f.Proposition, f.Provenance.Route })),
                Json(sim.EpistemicStateOf(new(6)).Facts.Select(f => new { f.Proposition, f.Provenance.Route })));
        });
        yield return new("DebtDirectPrecedence", ["S2-031A"], "F-STALE", "O-PROV/O-PUBLIC", () =>
        {
            Simulation sim = Create(World());
            Run(sim, new([new(new(1), new(1), new OfferLoan(new(2), 8))]));
            RelationId debt = sim.Snapshot.Debts.Keys.Single();
            Send(sim, 1, 3, new HeldFact(Fact<DebtFact>(sim, 1).Id));
            KnownFact old = Fact<DebtFact>(sim, 3);
            Run(sim, CycleInput.Empty);
            Run(sim, CycleInput.Empty);
            Run(sim, new([new(new(30), new(2), new RepayDebt(debt, 2))]));
            KnownFact direct = Fact<DebtFact>(sim, 1);
            Send(sim, 3, 1, new HeldFact(old.Id));
            KnownFact retained = Fact<DebtFact>(sim, 1);
            Equal(6L, ((DebtFact)retained.Proposition).Debt.Remaining);
            Equal(direct, retained);
            True(direct.Provenance.Origin.Order!.CompareTo(old.Provenance.Origin.Order) > 0);
        });
        yield return new("ReportEventPrecedence", ["S2-031B", "S2-032"], "F-STALE/F-META", "O-PROV/O-PUBLIC/O-META", () =>
        {
            foreach (bool reverse in new[] { false, true })
            {
                Debt earlier = new(new(80), new(4), new(5), 8, 8, 1, false, new(700));
                Debt later = earlier with { Remaining = 6 };
                Simulation sim = Create(World() with
                {
                    Knowledge = [
                    new(new(1), [Seed(100, new DebtFact(earlier), new(1, 4), new(700))]),
                    new(new(2), [Seed(101, new DebtFact(later), new(2, 3), new(701))])]
                });
                foreach (long sender in reverse ? new[] { 2L, 1L } : [1L, 2L])
                    Send(sim, sender, 3, new HeldFact(new(sender == 1 ? 100 : 101)));
                KnownFact accepted = Fact<DebtFact>(sim, 3);
                Equal(6L, ((DebtFact)accepted.Proposition).Debt.Remaining);
                Equal(new EventId(701), accepted.Provenance.Origin.Event);
                Equal(new EvidenceOrder(2, 3), accepted.Provenance.Origin.Order);
            }
        });
        yield return new("ExactRG01", ["S2-005", "S2-033", "S2-053"], "F-RG01/F-META", "O-RG01/O-META", () =>
        {
            foreach (long offset in new[] { 0L, 1000L })
                foreach (bool reverse in new[] { false, true })
                {
                    Simulation sim = Create(RecognitionWorld(offset));
                    Equal(RecognitionStatus.Recognized, sim.EpistemicStateOf(new(offset + 1)).RecognitionOf(new(offset + 1)));
                    Equal(RecognitionStatus.Unknown, sim.EpistemicStateOf(new(offset + 3)).RecognitionOf(new(offset + 1)));
                    foreach (long sender in reverse ? new[] { 2L, 1L } : [1L, 2L])
                        Send(sim, offset + sender, offset + 3, sender == 1 ? new HeldRecognition(new(offset + 1)) : new HeldFact(new(offset + 106)));
                    CandidateRecognition result = sim.EpistemicStateOf(new(offset + 3)).Recognitions.Single();
                    Equal(RecognitionStatus.Contested, result.Status);
                    Equal(2, result.Evidence.Count(f => f.Proposition is ResidenceFact r && r.Person == new PersonId(offset + 4)));
                    True(result.Evidence.All(f => f.Provenance.Origin.Order is null));
                    Run(sim, CycleInput.Empty);
                    Equal(RecognitionStatus.Contested, sim.EpistemicStateOf(new(offset + 3)).RecognitionOf(new(offset + 1)));
                }
            Simulation inactive = Create(RecognitionWorld(live: false));
            Equal(RecognitionStatus.Unknown, inactive.EpistemicStateOf(new(1)).RecognitionOf(new(1)));
        });
        yield return new("RecognitionIndependentAttitudeAndRefusal", ["S2-009"], "F-META", "O-META/O-PUBLIC", () =>
        {
            foreach (bool negative in new[] { false, true })
                foreach (bool refuse in new[] { false, true })
                {
                    InitialWorld initial = RecognitionWorld();
                    if (negative) initial = initial with { Attitudes = [new(new(70), new(1), new(6), -90)] };
                    Simulation sim = Create(initial);
                    CandidateRecognition before = sim.EpistemicStateOf(new(1)).Recognitions.Single();
                    Run(sim, new([new(new(1), new(6), new RequestGiftOrHelp(new(1), 1))])
                    { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(1), refuse ? "SCORE-RP-002" : "SCORE-RP-001") });
                    Equal(refuse ? OutcomeKind.Declined : OutcomeKind.Committed, sim.KnowledgeOf(new(1)).Single().Kind);
                    Equal(Json(before), Json(sim.EpistemicStateOf(new(1)).Recognitions.Single()));
                }
        });
        yield return new("SubjectiveGatesAndTraces", ["S2-001", "S2-022F", "S2-022R", "S2-040F", "S2-040R", "S2-041", "S2-042", "S2-043", "S2-044"],
            "F-GATE/F-META", "O-PUBLIC/O-PROV/O-META", () =>
        {
            foreach (bool recognition in new[] { false, true })
            {
                string? selected = null;
                foreach (bool held in new[] { false, true })
                    foreach (bool irrelevant in new[] { false, true })
                    {
                        InitialWorld initial = RecognitionWorld();
                        if (!held) initial = initial with { Knowledge = [.. initial.Knowledge.Where(k => k.Actor != new PersonId(1))] };
                        if (irrelevant) initial = initial with
                        {
                            Knowledge = [.. initial.Knowledge,
                            new(new(1), [Seed(9000, new ResidenceFact(new(6), new(2)))])]
                        };
                        Simulation sim = Create(initial);
                        HeldClaim claim = recognition ? new HeldRecognition(new(1)) : new HeldFact(new(101));
                        CycleResult result = Send(sim, 1, 3, claim);
                        DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
                        CandidateTrace candidate = trace.Candidates.Single(c => c.Terms is CommunicateClaim);
                        Equal(held, candidate.Eligible);
                        Equal(held, candidate.Selected);
                        Equal(held ? 100L : null, candidate.FinalScore);
                        if (!held) Equal(0, candidate.Components.Count);
                        Equal(held, trace.SubjectiveInputs.Any(s => s.StartsWith("EpistemicEvidence:", StringComparison.Ordinal)));
                        if (held)
                        {
                            True(trace.SubjectiveInputs.Any(s => s.Contains("controlled-prestate", StringComparison.Ordinal)));
                            if (!irrelevant) selected = Json(candidate); else Equal(selected, Json(candidate));
                        }
                        Simulation scripted = Create(initial);
                        CycleResult submitted = Run(scripted, new([new(new(1), new(1), new CommunicateClaim(new(3), claim))]));
                        Equal(held ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, submitted.Outcomes.Single().Kind);
                        True(submitted.Decisions.All(d => d.Context != "Response"));
                    }
                Simulation invalidRecipient = Create(RecognitionWorld());
                CycleResult invalid = Send(invalidRecipient, 1, 999, recognition ? new HeldRecognition(new(1)) : new HeldFact(new(101)));
                Equal(OutcomeKind.InvalidTerms, invalid.Outcomes.Single().Kind);
                True(invalid.Decisions.All(d => d.Context != "Response"));
            }
        });
        yield return new("ReplayReadAndEnumeration", ["S2-050", "S2-051", "S2-052"], "F-META", "O-META", () =>
        {
            string? expected = null;
            foreach (bool reads in new[] { false, true })
                foreach (bool reverse in new[] { false, true })
                {
                    Simulation sim = Create(RecognitionWorld(reverse: reverse));
                    for (int i = 0; i < 2; i++)
                    {
                        if (reads)
                        {
                            string immutable = Json(sim.EpistemicStateOf(new(3)));
                            for (int j = 0; j < 10; j++)
                            {
                                _ = sim.History; _ = sim.DecisionHistory; _ = sim.Snapshot;
                                Equal(immutable, Json(sim.EpistemicStateOf(new(3))));
                            }
                        }
                        Send(sim, i + 1, 3, i == 0 ? new HeldRecognition(new(1)) : new HeldFact(new(106)));
                    }
                    if (expected is null) expected = Canonical(sim); else Equal(expected, Canonical(sim));
                }
        });
        yield return new("StructuralBoundaryAndConfiguration", ["S2-004", "S2-007", "S2-045", "S2-054", "S2-055"], "F-STRUCT", "O-STRUCT/O-PUBLIC", () =>
        {
            Simulation sim = Create(World());
            Run(sim, new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new()) });
            Equal("SFL-S2-v1", sim.Configuration.Version);
            True(sim.History.All(e => e.RulesVersion == "SFL-S2-v1"));
            True(sim.DecisionHistory.All(d => d.RulesVersion == "SFL-S2-v1"));
            True(typeof(CandidateRecognition).GetProperties().All(p => p.PropertyType != typeof(double) && p.PropertyType != typeof(Attitude)));
            True(!typeof(FactualProposition).IsAssignableFrom(typeof(CandidateRecognition)));
            string agency = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim/Agency.cs"));
            True(!agency.Contains("WorldSnapshot", StringComparison.Ordinal) && !agency.Contains(".History", StringComparison.Ordinal));
            string epistemic = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim/EpistemicState.cs"));
            True(!epistemic.Contains("static readonly Dictionary", StringComparison.Ordinal));
            True(!epistemic.Contains("cache", StringComparison.OrdinalIgnoreCase));
            True(agency.Contains("SFL-COMMUNICATION-LAB-v1", StringComparison.Ordinal));
        });
        yield return new("SameCycleCommunicationBoundary", ["S2-026F", "S2-026R", "S2-044", "S2-052"], "F-COMM-FACT/F-COMM-REC/F-GATE/F-META", "O-PUBLIC/O-META", () =>
        {
            foreach (bool reverse in new[] { false, true })
            {
                Simulation sim = Create(RecognitionWorld());
                Proposal[] messages = [new(new(reverse ? 2 : 1), new(1), new CommunicateClaim(new(3), new HeldRecognition(new(1)))),
                    new(new(reverse ? 1 : 2), new(2), new CommunicateClaim(new(3), new HeldFact(new(106))))];
                CycleResult result = Run(sim, new([.. messages.Reverse()]));
                Equal(2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                Equal(RecognitionStatus.Contested, sim.EpistemicStateOf(new(3)).RecognitionOf(new(1)));
                True(result.Events.All(e => !e.TechnicalFallback));
                True(result.Decisions.All(d => d.Context != "Response"));

                Simulation gated = Create(RecognitionWorld());
                CycleResult activation = Run(gated, new([])
                {
                    PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty
                        .Add(new(1), new("SFL-COMMUNICATION-LAB-v1") { Communication = new(new(3), new HeldRecognition(new(1))) })
                        .Add(new(3), new("SFL-COMMUNICATION-LAB-v1") { Communication = new(new(6), new HeldRecognition(new(1))) })
                });
                Equal(2, activation.Decisions.Length);
                True(!activation.Decisions.Single(d => d.Actor == new PersonId(3)).Candidates.Single(c => c.Terms is CommunicateClaim).Eligible);
                Equal(RecognitionStatus.Unknown, gated.EpistemicStateOf(new(6)).RecognitionOf(new(1)));

                Simulation loan = Create(World());
                Run(loan, new([new(new(1), new(1), new OfferLoan(new(2), 8))]));
                KnownFact held = Fact<DebtFact>(loan, 1);
                RelationId debt = ((DebtFact)held.Proposition).Debt.Id;
                ProposalId messageId = new(reverse ? 11 : 10);
                CycleResult changed = Run(loan, new([
                    new(messageId, new(1), new CommunicateClaim(new(3), new HeldFact(held.Id))),
                    new(new(reverse ? 10 : 11), new(2), new RepayDebt(debt, 2))]));
                Equal(reverse ? OutcomeKind.InvalidatedAtResolution : OutcomeKind.Committed, changed.Outcomes.Single(o => o.Proposal == messageId).Kind);
                foreach (Outcome outcome in changed.Outcomes)
                    True(changed.Events.Single(e => e.Id == outcome.Event).TechnicalFallback);
                Equal(!reverse, Has<DebtFact>(loan, 3));
                if (reverse) True(Has<ParticipationFact>(loan, 1, f => f.Outcome.Kind == OutcomeKind.InvalidatedAtResolution && f.Outcome.Reason == "PropositionNoLongerHeld"));
                Equal(6L, ((DebtFact)Fact<DebtFact>(loan, 1).Proposition).Debt.Remaining);
            }
        });
        yield return new("RecognitionEvidenceAdequacy", ["S2-005", "S2-040R", "S2-042"], "F-RG01/F-GATE", "O-RG01/O-PUBLIC/O-PROV", () =>
        {
            for (long omitted = 101; omitted <= 105; omitted++)
            {
                InitialWorld initial = RecognitionWorld();
                initial = initial with
                {
                    Knowledge = [.. initial.Knowledge.Select(k => k.Actor == new PersonId(1) ?
                    k with { Facts = [.. k.Facts.Where(f => f.Id != new EvidenceId(omitted))] } : k)]
                };
                Simulation sim = Create(initial);
                Equal(RecognitionStatus.Unknown, sim.EpistemicStateOf(new(1)).RecognitionOf(new(1)));
            }
            InitialWorld sameCycle = RecognitionWorld();
            sameCycle = sameCycle with
            {
                Knowledge = [.. sameCycle.Knowledge.Select(k => k with
                { Facts = [.. k.Facts.Select(f => f.Proposition is SupportFact support ? f with { Proposition = support with { Cycle = 1 } } : f)] })]
            };
            Equal(RecognitionStatus.Unknown, Create(sameCycle).EpistemicStateOf(new(1)).RecognitionOf(new(1)));
            Simulation contested = Create(RecognitionWorld());
            Send(contested, 1, 3, new HeldRecognition(new(1)));
            Send(contested, 2, 3, new HeldFact(new(106)));
            CycleResult gated = Send(contested, 3, 6, new HeldRecognition(new(1)));
            DecisionTrace trace = gated.Decisions.Single(d => d.Actor == new PersonId(3));
            True(!trace.Candidates.Single(c => c.Terms is CommunicateClaim).Eligible);
            True(trace.SubjectiveInputs.Contains("RecognitionStatus:Contested;Candidate:1"));
            Equal(2, trace.SubjectiveInputs.Count(s => s.StartsWith("EpistemicEvidence:", StringComparison.Ordinal) &&
                s.Contains("\"kind\":\"residence\",\"Person\":{\"Value\":4}", StringComparison.Ordinal)));
        });
    }
}
