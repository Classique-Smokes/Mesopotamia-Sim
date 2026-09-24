using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using Mesopotamia.Sim;

internal static class Program
{
    private const string SourceRevision = "f7ca9525d17ed20758058df7aff97b2f47e5a01a";
    private const string ObservationId = "IMP-0003-OBS-001";
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    private static int Main(string[] args)
    {
        string output = Arg(args, "--output") ??
            "research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE";
        Directory.CreateDirectory(output);
        string harnessRevision = Environment.GetEnvironmentVariable("GITHUB_SHA") ?? "LOCAL-UNKNOWN";
        string executedAt = DateTimeOffset.UtcNow.ToString("O");

        RunModeA(Path.Combine(output, "MODE_A_AUTONOMOUS_REACHABILITY"));
        RunModeB1(Path.Combine(output, "MODE_B1_CONTINUITY_RECOGNITION_PROVISION"));
        RunModeB2(Path.Combine(output, "MODE_B2_CONTROLLED_LINEAGE"));

        WriteJson(Path.Combine(output, "RUN_METADATA.json"), new
        {
            observation = ObservationId,
            sourceRevision = SourceRevision,
            harnessRevision,
            executedAtUtc = executedAt,
            configurationVersion = "SFL-S3-v1",
            dotnetFramework = RuntimeInformation.FrameworkDescription,
            runtimeVersion = Environment.Version.ToString(),
            os = RuntimeInformation.OSDescription,
            interpretation = "RAW_ONLY",
            modes = new[]
            {
                "MODE_A_AUTONOMOUS_REACHABILITY",
                "MODE_B1_CONTINUITY_RECOGNITION_PROVISION",
                "MODE_B2_CONTROLLED_LINEAGE"
            }
        });

        File.WriteAllText(Path.Combine(output, "RAW_README.md"), $"""
# Slice-3 Post-Implementation Observation — Raw Mechanical Package

Observation: {ObservationId}
Production source revision: {SourceRevision}
Harness revision: {harnessRevision}
Executed UTC: {executedAt}
Interpretation: RAW ONLY

The files below were generated mechanically from production simulation surfaces at the declared promoted source revision. No Master Architect interpretation or classification is embedded in this package.

Mode B1 uses exactly one manifest-authorized controlled pre-existing provision commitment through the production fixture prerequisite. It does not write derived capacity or any Household formation, participation, lifecycle, Recognition, or lineage result.
""");
        return 0;
    }

    private static void RunModeA(string directory)
    {
        InitialWorld initial = BuildWorld(p6AtDwelling2: false);
        RunRecorder run = new(directory, initial, "Mode A — Autonomous Reachability");
        const int horizon = 12;
        for (int i = 0; i < horizon; i++)
        {
            CycleResult result = run.Sim.RunAutonomousCycle();
            run.CaptureCycle($"autonomous-{i + 1}", result);
            if (result.MaterialDeadlock) break;
        }
        run.Save();

        CandidateId candidate = new(1);
        WriteJson(Path.Combine(directory, "REACHABILITY_COUNTS.json"), new
        {
            declaredHorizonCycles = horizon,
            completedStableCycles = run.Sim.Snapshot.Cycle,
            simulationFaulted = run.Sim.IsFaulted,
            finalCandidateRecognition = run.Sim.EpistemicSnapshot.Actors.Values.OrderBy(a => a.Actor.Value)
                .Select(a => new { actor = a.Actor.Value, status = a.RecognitionOf(candidate).ToString() }),
            householdCount = run.Sim.HouseholdSnapshot.Households.Count,
            formationCount = run.Sim.History.Count(e => e.Kind == "HouseholdFormation"),
            participationStartCount = run.Sim.History.Count(e => e.Kind is "HouseholdParticipation" or "SustainingParticipationStarted" or "SustainingParticipationFounded"),
            participationEndCount = run.Sim.History.Count(e => e.Kind == "HouseholdParticipationEnded"),
            lifecycleChangeCount = run.Sim.History.Count(e => e.Kind == "HouseholdLifecycle"),
            lineageCount = run.Sim.History.Count(e => e.Kind == "HouseholdLineage"),
            commitmentCount = run.Sim.HouseholdSnapshot.Commitments.Count,
            communicationCount = run.Sim.History.Count(e => e.Kind == "Communication"),
            qualifyingSupportCount = run.Sim.History.Count(e => e.Kind is "Gift" or "Help" or "Loan" or "CalledFavourFulfilled"),
            proposalActionCounts = run.Sim.History.Where(e => e.Kind == "Proposal")
                .GroupBy(e => ActionKind(e.Action)).OrderBy(g => g.Key, StringComparer.Ordinal)
                .ToDictionary(g => g.Key, g => g.Count()),
            selectedPersonalDecisionCounts = run.Sim.DecisionHistory.Where(d => d.Context == "Personal")
                .Select(d => d.Candidates.SingleOrDefault(c => c.Selected)?.Meaning ?? "None")
                .GroupBy(x => x).OrderBy(g => g.Key, StringComparer.Ordinal)
                .ToDictionary(g => g.Key, g => g.Count()),
            personalDecisionTieFallbackCount = run.Sim.DecisionHistory.Count(d => d.Context == "Personal" && d.TechnicalFallback),
            semanticTechnicalFallbackEventCount = run.Sim.History.Count(e => e.TechnicalFallback)
        });
    }

    private static void RunModeB1(string directory)
    {
        InitialWorld initial = BuildWorld(p6AtDwelling2: true);
        RunRecorder run = new(directory, initial, "Mode B1 — Continuity / Recognition / Provision");

        run.Step("ordinary-support-p1-p3", (1, new OfferGift(P(3), 1)));
        run.Step("ordinary-support-p3-p2", (3, new OfferGift(P(2), 1)));
        run.SendSupport("communicate-cycle2-support-to-p1", 3, 1, 2);
        run.SendSupport("communicate-cycle1-support-to-p2", 3, 2, 1);

        HouseholdId h = run.Sim.HouseholdSnapshot.Formations.Values.Single(f => f.Candidate.Value == 1).Household;

        run.Step("communicate-household-recognition-to-p4",
            (1, new CommunicateClaim(P(4), new HeldHouseholdRecognition(h))));
        run.Step("postformation-support-p1-p4", (1, new OfferGift(P(4), 1)));
        run.Step("p4-requests-participation-via-p1",
            (4, new RequestHouseholdParticipation(h, P(1))));

        run.SupplyProvisionFixture("controlled-provision-prerequisite-p1", P(1), h,
            new("F-S3-PREEXISTING-COMMITMENT", "IMP-0003-OBS-001", "RUN-0003-B1-H1-P1"));
        run.RecordCapacity("after-controlled-provision-prerequisite", h, P(1));

        run.Step("personal-gift-changes-capacity", (1, new OfferGift(P(6), 1)));
        run.RecordCapacity("after-personal-gift", h, P(1));

        run.Step("connected-compatible-loans",
            (1, new OfferLoan(P(3), 1)),
            (2, new OfferLoan(P(3), 1)));
        run.RecordCapacity("after-connected-compatible-loan", h, P(1));

        run.Step("communicate-household-recognition-to-p5",
            (2, new CommunicateClaim(P(5), new HeldHouseholdRecognition(h))));
        run.Step("postformation-support-p2-p5", (2, new OfferGift(P(5), 1)));

        run.Step("residence-admission-dependency",
            (6, new InviteResidence(P(5), new DwellingId(2))),
            (5, new RequestHouseholdParticipation(h, P(2))));

        run.Step("p5-returns-to-dwelling1",
            (5, new MoveResidence(P(2), new DwellingId(1))));

        run.Step("founder-p1-exits", (1, new EndHouseholdParticipation(h)));
        run.RecordCapacity("after-p1-exit", h, P(1));
        run.Step("founder-p2-exits", (2, new EndHouseholdParticipation(h)));
        run.Step("founder-p3-exits", (3, new EndHouseholdParticipation(h)));

        run.Step("latest-continuation-report-p3-to-p4",
            (3, new CommunicateClaim(P(4), new HeldHouseholdRecognition(h))));
        run.Step("updated-household-report-p4-to-p5",
            (4, new CommunicateClaim(P(5), new HeldHouseholdRecognition(h))));
        run.Step("fresh-support-p4-p5", (4, new OfferGift(P(5), 1)));
        run.Step("p5-requests-reactivation-entry-via-p4",
            (5, new RequestHouseholdParticipation(h, P(4))));

        run.Step("p4-exits", (4, new EndHouseholdParticipation(h)));
        run.Step("p5-terminal-exit", (5, new EndHouseholdParticipation(h)));

        KnownFact? dissolved = run.Sim.EpistemicStateOf(P(5)).Facts
            .LastOrDefault(f => f.Proposition is HouseholdExistenceFact fact && fact.Household == h && !fact.Continues);
        if (dissolved is not null)
            run.Step("communicate-dissolution-fact-p5-to-p4",
                (5, new CommunicateClaim(P(4), new HeldFact(dissolved.Id))));
        else
            run.RecordUnavailable("communicate-dissolution-fact-p5-to-p4", "P5HeldNoDissolutionFactAtDeclaredStep");

        run.Save();
        WriteJson(Path.Combine(directory, "NARRATIVE_IDENTIFIERS.json"), new
        {
            household = h.Value,
            formationWarrant = run.Sim.HouseholdSnapshot.Households[h].Formation.Value,
            finalLifecycle = run.Sim.HouseholdSnapshot.Households[h].Lifecycle.ToString()
        });
    }

    private static void RunModeB2(string directory)
    {
        InitialWorld initial = BuildWorld(p6AtDwelling2: false);
        RunRecorder run = new(directory, initial, "Mode B2 — Controlled Lineage");

        run.Step("predecessor-support-p1-p3", (1, new OfferGift(P(3), 1)));
        run.Step("predecessor-support-p3-p2", (3, new OfferGift(P(2), 1)));
        run.SendSupport("predecessor-communicate-cycle2-support-to-p1", 3, 1, 2);
        run.SendSupport("predecessor-communicate-cycle1-support-to-p2", 3, 2, 1);

        HouseholdId predecessor = run.Sim.HouseholdSnapshot.Formations.Values.Single(f => f.Candidate.Value == 1).Household;
        run.Step("p1-exits-predecessor", (1, new EndHouseholdParticipation(predecessor)));
        run.Step("p2-exits-predecessor", (2, new EndHouseholdParticipation(predecessor)));
        run.Step("fresh-postexit-support-p1-p2", (1, new OfferGift(P(2), 1)));
        run.Step("fresh-postexit-support-p2-p1", (2, new OfferGift(P(1), 1)));

        run.DeclareCandidate("declare-successor-candidate", new CandidateReferent(new CandidateId(2), [P(1), P(2)]));
        run.StepEmpty("close-successor-formation");

        HouseholdId successor = run.Sim.HouseholdSnapshot.Formations.Values.Single(f => f.Candidate.Value == 2).Household;
        run.Save();
        WriteJson(Path.Combine(directory, "NARRATIVE_IDENTIFIERS.json"), new
        {
            predecessor = predecessor.Value,
            predecessorLifecycle = run.Sim.HouseholdSnapshot.Households[predecessor].Lifecycle.ToString(),
            successor = successor.Value,
            lineage = run.Sim.HouseholdSnapshot.Lineages.Values.Where(l => l.Successor == successor)
                .Select(l => new
                {
                    id = l.Id.Value,
                    kind = l.Kind.ToString(),
                    predecessors = l.Predecessors.Select(p => p.Value).OrderBy(x => x)
                })
        });
    }

    private static InitialWorld BuildWorld(bool p6AtDwelling2)
    {
        Person[] people =
        [
            new(P(1), "Person1", Sex.Male, 12),
            new(P(2), "Person2", Sex.Female, 12),
            new(P(3), "Person3", Sex.Male, 12),
            new(P(4), "Person4", Sex.Female, 12),
            new(P(5), "Person5", Sex.Male, 12),
            new(P(6), "Person6", Sex.Female, 12)
        ];
        Dwelling[] dwellings = [new(new(1)), new(new(2))];
        Residence[] residences =
        [
            new(new(101), P(1), new(1)),
            new(new(102), P(2), new(1)),
            new(new(103), P(3), new(1)),
            new(new(104), P(4), new(1)),
            new(new(105), P(5), new(1)),
            new(new(106), P(6), new(p6AtDwelling2 ? 2 : 1))
        ];
        Kinship[] kinships =
        [
            new(new(201), P(1), P(2), KinshipKind.Sibling),
            new(new(202), P(2), P(3), KinshipKind.Sibling),
            new(new(203), P(1), P(4), KinshipKind.Sibling),
            new(new(204), P(2), P(5), KinshipKind.Sibling),
            new(new(205), P(3), P(6), KinshipKind.Sibling),
            new(new(206), P(4), P(5), KinshipKind.Sibling)
        ];
        InitialWorld world = new(
            [.. people], [.. dwellings], [.. residences], [], [.. kinships], [], [],
            new Configuration("SFL-S3-v1"))
        {
            Candidates = [new(new CandidateId(1), [P(1), P(2), P(3)])]
        };
        return WithLowerLevelKnowledge(world);
    }

    private static InitialWorld WithLowerLevelKnowledge(InitialWorld world)
    {
        long evidence = 1000;
        FactualProposition[] lower =
        [
            .. world.Residences.Select(r => (FactualProposition)new ResidenceFact(r.Person, r.Dwelling)),
            .. world.Kinships.Select(k => (FactualProposition)new KinshipFact(k)),
            .. world.Marriages.Select(m => (FactualProposition)new MarriageFact(m)),
            .. world.Attitudes.Select(a => (FactualProposition)new AttitudeFact(a))
        ];
        return world with
        {
            Knowledge =
            [
                .. world.People.Select(p => new InitialKnowledge(p.Id,
                    [.. lower.Select(f => new KnownFact(new EvidenceId(evidence++), f,
                        new EvidenceProvenance(AcquisitionRoute.Fixture,
                            new EvidenceOrigin(null, null, new EvidenceOrder(0, 0), "OBS-S3-LOWER-LEVEL"),
                            [])))])
                )
            ]
        };
    }

    private static PersonId P(int value) => new(value);

    private sealed class RunRecorder
    {
        private readonly string directory;
        private readonly string title;
        private readonly List<object> cycles = [];
        private readonly List<object> schedule = [];
        private readonly List<object> epistemicSnapshots = [];
        private readonly List<object> householdSnapshots = [];
        private readonly List<object> capacityCheckpoints = [];
        private readonly StringBuilder transcript = new();
        private long nextProposal = 1;

        internal RunRecorder(string directory, InitialWorld initial, string title)
        {
            this.directory = directory;
            this.title = title;
            Directory.CreateDirectory(directory);
            Sim = new Simulation(initial);
            WriteJson(Path.Combine(directory, "INITIAL_WORLD.json"), initial);
            epistemicSnapshots.Add(new { label = "initial", cycle = 0, actors = EpistemicActors(Sim.EpistemicSnapshot) });
            householdSnapshots.Add(new { label = "initial", cycle = 0, snapshot = HouseholdDto(Sim.HouseholdSnapshot, Sim.Snapshot) });
            transcript.AppendLine($"# {title} — Mechanical Transcript");
            transcript.AppendLine();
            transcript.AppendLine("Generated mechanically from production simulation surfaces. No interpretation is included.");
            transcript.AppendLine();
            AppendStableState("Initial");
        }

        internal Simulation Sim { get; }

        internal CycleResult Step(string label, params (int Actor, ActionTerms Terms)[] actions)
        {
            Proposal[] proposals = [.. actions.Select(a => new Proposal(new ProposalId(nextProposal++), P(a.Actor), a.Terms))];
            schedule.Add(new
            {
                label,
                cycle = Sim.Snapshot.Cycle + 1,
                kind = "ScriptedCycle",
                proposals = proposals.Select(p => new { id = p.Id.Value, actor = p.Actor.Value, action = ActionDto(p.Terms) })
            });
            CycleResult result = Sim.RunCycle(new CycleInput([.. proposals]));
            CaptureCycle(label, result);
            return result;
        }

        internal CycleResult StepEmpty(string label)
        {
            schedule.Add(new { label, cycle = Sim.Snapshot.Cycle + 1, kind = "EmptyPublicCycle" });
            CycleResult result = Sim.RunCycle(CycleInput.Empty);
            CaptureCycle(label, result);
            return result;
        }

        internal void SendSupport(string label, int sender, int recipient, long supportCycle)
        {
            KnownFact held = Sim.EpistemicStateOf(P(sender)).Facts
                .First(f => f.Proposition is SupportFact s && s.Cycle == supportCycle);
            Step(label, (sender, new CommunicateClaim(P(recipient), new HeldFact(held.Id))));
        }

        internal void DeclareCandidate(string label, CandidateReferent candidate)
        {
            schedule.Add(new
            {
                label,
                cycle = Sim.Snapshot.Cycle,
                kind = "InertCandidateDeclaration",
                candidate = candidate.Id.Value,
                core = candidate.Core.Select(p => p.Value)
            });
            Sim.DeclareCandidate(candidate);
            CaptureCheckpoint(label);
        }

        internal void RecordUnavailable(string label, string reason)
        {
            schedule.Add(new
            {
                label,
                cycle = Sim.Snapshot.Cycle,
                kind = "DeclaredActionUnavailable",
                reason
            });
            CaptureCheckpoint(label + "-unavailable");
        }

        internal void SupplyProvisionFixture(string label, PersonId person, HouseholdId household, ProvisionFixtureProvenance provenance)
        {
            schedule.Add(new
            {
                label,
                cycle = Sim.Snapshot.Cycle,
                kind = "ManifestAuthorizedControlledPrerequisite",
                authority = "SFL-V0-S3-ACCEPTANCE-v1 §3.1",
                method = "Simulation.SupplyProvisionFixture",
                person = person.Value,
                household = household.Value,
                provenance
            });
            MethodInfo method = typeof(Simulation).GetMethod("SupplyProvisionFixture",
                BindingFlags.Instance | BindingFlags.NonPublic)
                ?? throw new InvalidOperationException("Controlled provision fixture surface not found.");
            try
            {
                method.Invoke(Sim, [person, household, provenance]);
            }
            catch (TargetInvocationException e) when (e.InnerException is not null)
            {
                throw e.InnerException;
            }
            CaptureCheckpoint(label);
        }

        internal void RecordCapacity(string label, HouseholdId household, PersonId person)
        {
            HouseholdSnapshot h = Sim.HouseholdSnapshot;
            WorldSnapshot w = Sim.Snapshot;
            capacityCheckpoints.Add(new
            {
                label,
                cycle = w.Cycle,
                household = household.Value,
                householdLifecycle = h.Households[household].Lifecycle.ToString(),
                person = person.Value,
                personalGrain = w.People[person].Grain,
                needsGrain = w.People[person].NeedsGrain,
                personExposedCapacity = HouseholdSnapshot.ExposedCapacity(w.People[person]),
                activeCommitment = h.Commitments.Values.Any(c => c.Household == household && c.Person == person && c.TerminatedBy is null),
                householdMobilizableCapacity = h.MobilizableCapacity(household, w)
            });
        }

        internal void CaptureCycle(string label, CycleResult result)
        {
            HouseholdSnapshot publishedHouseholds = result.Households ?? throw new InvalidOperationException("Missing published household snapshot.");
            cycles.Add(new
            {
                label,
                cycle = result.State.Cycle,
                result.MaterialDeadlock,
                outcomes = result.Outcomes.Select(o => new
                {
                    proposal = o.Proposal.Value,
                    actor = o.Actor.Value,
                    kind = o.Kind.ToString(),
                    o.Reason,
                    eventId = o.Event.Value
                }),
                eventKinds = result.Events.GroupBy(e => e.Kind).OrderBy(g => g.Key, StringComparer.Ordinal)
                    .ToDictionary(g => g.Key, g => g.Count()),
                technicalFallbackEvents = result.Events.Where(e => e.TechnicalFallback).Select(e => e.Id.Value),
                people = result.State.People.Values.OrderBy(p => p.Id.Value)
                    .Select(p => new { id = p.Id.Value, p.Grain, p.NeedsGrain, dwelling = result.State.HomeOf(p.Id).Value }),
                households = publishedHouseholds.Households.Values.OrderBy(h => h.Id.Value)
                    .Select(h => new { id = h.Id.Value, lifecycle = h.Lifecycle.ToString(), participants = publishedHouseholds.Participants(h.Id).Select(a => a.Person.Value) })
            });
            EpistemicSnapshot epistemic = result.Epistemic ?? throw new InvalidOperationException("Missing published epistemic snapshot.");
            epistemicSnapshots.Add(new { label, cycle = result.State.Cycle, actors = EpistemicActors(epistemic) });
            householdSnapshots.Add(new { label, cycle = result.State.Cycle, snapshot = HouseholdDto(publishedHouseholds, result.State) });
            AppendCycle(label, result);
        }

        private void CaptureCheckpoint(string label)
        {
            epistemicSnapshots.Add(new { label, cycle = Sim.Snapshot.Cycle, actors = EpistemicActors(Sim.EpistemicSnapshot), checkpoint = true });
            householdSnapshots.Add(new { label, cycle = Sim.Snapshot.Cycle, snapshot = HouseholdDto(Sim.HouseholdSnapshot, Sim.Snapshot), checkpoint = true });
            transcript.AppendLine($"## Checkpoint — {label}");
            transcript.AppendLine();
            AppendStableState(label);
        }

        internal void Save()
        {
            WriteJson(Path.Combine(directory, "ACTIVATION_SCHEDULE.json"), schedule);
            WriteJson(Path.Combine(directory, "CYCLE_SUMMARY.json"), cycles);
            WriteJson(Path.Combine(directory, "SEMANTIC_HISTORY.json"), Sim.History.Select(EventDto));
            WriteJson(Path.Combine(directory, "DECISION_HISTORY.json"), Sim.DecisionHistory.Select(DecisionDto));
            WriteJson(Path.Combine(directory, "EPISTEMIC_SNAPSHOTS.json"), epistemicSnapshots);
            WriteJson(Path.Combine(directory, "HOUSEHOLD_SNAPSHOTS.json"), householdSnapshots);
            WriteJson(Path.Combine(directory, "CAPACITY_CHECKPOINTS.json"), capacityCheckpoints);
            WriteJson(Path.Combine(directory, "FINAL_SNAPSHOT.json"), new
            {
                world = WorldDto(Sim.Snapshot),
                epistemic = EpistemicActors(Sim.EpistemicSnapshot),
                households = HouseholdDto(Sim.HouseholdSnapshot, Sim.Snapshot)
            });
            WriteJson(Path.Combine(directory, "RUN_SUMMARY.json"), new
            {
                title,
                stableCycles = Sim.Snapshot.Cycle,
                simulationFaulted = Sim.IsFaulted,
                semanticEvents = Sim.History.Length,
                decisions = Sim.DecisionHistory.Length,
                households = Sim.HouseholdSnapshot.Households.Count,
                formations = Sim.HouseholdSnapshot.Formations.Count,
                entries = Sim.HouseholdSnapshot.Entries.Count,
                exits = Sim.HouseholdSnapshot.Exits.Count,
                continuations = Sim.HouseholdSnapshot.Continuations.Count,
                lineages = Sim.HouseholdSnapshot.Lineages.Count,
                commitments = Sim.HouseholdSnapshot.Commitments.Count,
                eventKinds = Sim.History.GroupBy(e => e.Kind).OrderBy(g => g.Key, StringComparer.Ordinal)
                    .ToDictionary(g => g.Key, g => g.Count()),
                semanticTechnicalFallbackEvents = Sim.History.Count(e => e.TechnicalFallback)
            });
            File.WriteAllText(Path.Combine(directory, "HUMAN_TRANSCRIPT.md"), transcript.ToString());
        }

        private void AppendCycle(string label, CycleResult result)
        {
            transcript.AppendLine($"## Cycle {result.State.Cycle} — {label}");
            transcript.AppendLine();
            transcript.AppendLine("### Decisions");
            foreach (DecisionTrace d in result.Decisions.OrderBy(d => d.Actor.Value).ThenBy(d => d.Context, StringComparer.Ordinal))
            {
                CandidateTrace? selected = d.Candidates.SingleOrDefault(c => c.Selected);
                transcript.AppendLine($"- P{d.Actor.Value} {d.Context}/{d.Profile}: selected={selected?.Meaning ?? "none"}; rules={d.RulesVersion}; config={d.ConfigurationVersion}; fallback={d.TechnicalFallback}");
            }
            transcript.AppendLine();
            transcript.AppendLine("### Outcomes");
            if (result.Outcomes.IsEmpty) transcript.AppendLine("- none");
            foreach (Outcome o in result.Outcomes.OrderBy(o => o.Proposal.Value))
                transcript.AppendLine($"- proposal={o.Proposal.Value}; actor=P{o.Actor.Value}; kind={o.Kind}; reason={o.Reason}; event=E{o.Event.Value}");
            transcript.AppendLine();
            transcript.AppendLine("### Semantic events");
            foreach (SemanticEvent e in result.Events.OrderBy(e => e.ReactionIndex))
            {
                string participants = string.Join(",", e.Participants.Select(p => $"P{p.Value}"));
                string causes = string.Join(",", e.Causes.Select(c => $"E{c.Value}"));
                transcript.AppendLine($"- E{e.Id.Value} r{e.ReactionIndex}: {e.Kind}; participants=[{participants}]; causes=[{causes}]; fallback={e.TechnicalFallback}; detail={e.Detail}");
            }
            transcript.AppendLine();
            AppendStableState(label);
        }

        private void AppendStableState(string label)
        {
            transcript.AppendLine($"### Stable state — {label}");
            foreach (Person p in Sim.Snapshot.People.Values.OrderBy(p => p.Id.Value))
                transcript.AppendLine($"- P{p.Id.Value}: grain={p.Grain}; need={p.NeedsGrain}; dwelling=D{Sim.Snapshot.HomeOf(p.Id).Value}");
            if (Sim.HouseholdSnapshot.Households.Count == 0) transcript.AppendLine("- Households: none");
            foreach (Household h in Sim.HouseholdSnapshot.Households.Values.OrderBy(h => h.Id.Value))
            {
                string participants = string.Join(",", Sim.HouseholdSnapshot.Participants(h.Id).Select(a => $"P{a.Person.Value}"));
                transcript.AppendLine($"- H{h.Id.Value}: lifecycle={h.Lifecycle}; participants=[{participants}]; capacity={Sim.HouseholdSnapshot.MobilizableCapacity(h.Id, Sim.Snapshot)}");
            }
            foreach (ActorEpistemicState actor in Sim.EpistemicSnapshot.Actors.Values.OrderBy(a => a.Actor.Value))
            {
                string candidate = string.Join(",", actor.Recognitions.OrderBy(r => r.Candidate.Value).Select(r => $"C{r.Candidate.Value}:{r.Status}"));
                string household = string.Join(",", actor.HouseholdRecognitions.OrderBy(r => r.Household.Value).Select(r => $"H{r.Household.Value}:{r.Status}"));
                transcript.AppendLine($"- P{actor.Actor.Value} epistemic: candidates=[{candidate}]; households=[{household}]");
            }
            transcript.AppendLine();
        }
    }

    private static object WorldDto(WorldSnapshot s) => new
    {
        s.Cycle,
        people = s.People.Values.OrderBy(p => p.Id.Value),
        dwellings = s.Dwellings.Values.OrderBy(d => d.Id.Value),
        residences = s.Residences.Values.OrderBy(r => r.Id.Value),
        attitudes = s.Attitudes.Values.OrderBy(a => a.Id.Value),
        kinships = s.Kinships.Values.OrderBy(k => k.Id.Value),
        marriages = s.Marriages.Values.OrderBy(m => m.Id.Value),
        debts = s.Debts.Values.OrderBy(d => d.Id.Value),
        favours = s.Favours.Values.OrderBy(f => f.Id.Value)
    };

    private static object EpistemicActors(EpistemicSnapshot s) =>
        s.Actors.Values.OrderBy(a => a.Actor.Value).Select(a => new
        {
            actor = a.Actor.Value,
            facts = a.Facts.Select(FactDto),
            candidates = a.Recognitions.OrderBy(r => r.Candidate.Value).Select(r => new
            {
                candidate = r.Candidate.Value,
                status = r.Status.ToString(),
                evidence = r.Evidence.Select(FactDto)
            }),
            households = a.HouseholdRecognitions.OrderBy(r => r.Household.Value).Select(r => new
            {
                household = r.Household.Value,
                status = r.Status.ToString(),
                evidence = r.Evidence.Select(FactDto)
            })
        });

    private static object HouseholdDto(HouseholdSnapshot h, WorldSnapshot world) => new
    {
        cycle = h.Cycle,
        households = h.Households.Values.OrderBy(x => x.Id.Value).Select(x => new
        {
            x.Id,
            x.Formation,
            lifecycle = x.Lifecycle.ToString(),
            x.LifecycleEvent,
            x.LifecycleTime,
            participants = h.Participants(x.Id),
            mobilizableCapacity = h.MobilizableCapacity(x.Id, world)
        }),
        formations = h.Formations.Values.OrderBy(x => x.Id.Value),
        associations = h.Associations.Values.OrderBy(x => x.Id.Value),
        entries = h.Entries.Values.OrderBy(x => x.Id.Value),
        exits = h.Exits.Values.OrderBy(x => x.Id.Value),
        continuations = h.Continuations.Values.OrderBy(x => x.Id.Value),
        lineages = h.Lineages.Values.OrderBy(x => x.Id.Value),
        commitments = h.Commitments.Values.OrderBy(x => x.Id.Value)
    };

    private static object EventDto(SemanticEvent e) => new
    {
        id = e.Id.Value,
        e.Cycle,
        e.ReactionIndex,
        e.Kind,
        proposal = e.Proposal?.Value,
        participants = e.Participants.Select(p => p.Value),
        causes = e.Causes.Select(c => c.Value),
        material = e.Material.Select(m => new { person = m.Person.Value, m.Before, m.After, m.Meaning }),
        e.Detail,
        e.ConfigurationVersion,
        e.RulesVersion,
        e.TechnicalFallback,
        action = ActionDto(e.Action),
        contributions = e.Contributions.Select(c => new
        {
            c.Key.Rule,
            trigger = c.Key.Trigger.Value,
            from = c.Key.From.Value,
            to = c.Key.To.Value,
            c.Delta
        }),
        transmittedEvidence = e.TransmittedEvidence.Select(FactDto),
        acquiredEvidence = e.AcquiredEvidence.Select(a => new { actor = a.Actor.Value, fact = FactDto(a.Fact) })
    };

    private static object DecisionDto(DecisionTrace d) => new
    {
        d.Cycle,
        actor = d.Actor.Value,
        proposal = d.Proposal?.Value,
        d.Context,
        d.Profile,
        d.SubjectiveInputs,
        d.TechnicalFallback,
        d.RulesVersion,
        d.ConfigurationVersion,
        candidates = d.Candidates.Select(c => new
        {
            c.Key,
            c.Meaning,
            c.Eligible,
            c.Gate,
            c.Components,
            c.FinalScore,
            c.Selected,
            terms = ActionDto(c.Terms)
        })
    };

    private static object FactDto(KnownFact f) => new
    {
        id = f.Id.Value,
        proposition = PropositionDto(f.Proposition),
        route = f.Provenance.Route.ToString(),
        origin = new
        {
            source = f.Provenance.Origin.Source?.Value,
            eventId = f.Provenance.Origin.Event?.Value,
            cycle = f.Provenance.Origin.Order?.Cycle,
            reactionIndex = f.Provenance.Origin.Order?.ReactionIndex,
            f.Provenance.Origin.Fixture
        },
        hops = f.Provenance.Hops.Select(h => new
        {
            sender = h.Sender.Value,
            recipient = h.Recipient.Value,
            eventId = h.Event.Value,
            cycle = h.Delivered.Cycle,
            reactionIndex = h.Delivered.ReactionIndex
        })
    };

    private static object PropositionDto(FactualProposition proposition) => proposition switch
    {
        OwnStateFact x => new { kind = "OwnState", person = x.Person.Id.Value, x.Person.Grain, x.Person.NeedsGrain },
        ResidenceFact x => new { kind = "Residence", person = x.Person.Value, dwelling = x.Dwelling.Value },
        AttitudeFact x => new { kind = "Attitude", id = x.Attitude.Id.Value, from = x.Attitude.From.Value, to = x.Attitude.To.Value, x.Attitude.Value },
        KinshipFact x => new { kind = "Kinship", id = x.Kinship.Id.Value, first = x.Kinship.First.Value, second = x.Kinship.Second.Value, relation = x.Kinship.Kind.ToString() },
        MarriageFact x => new { kind = "Marriage", id = x.Marriage.Id.Value, groom = x.Marriage.Groom.Value, bride = x.Marriage.Bride.Value },
        DebtFact x => new { kind = "Debt", id = x.Debt.Id.Value, creditor = x.Debt.Creditor.Value, debtor = x.Debt.Debtor.Value, x.Debt.Original, x.Debt.Remaining },
        FavourFact x => new { kind = "Favour", id = x.Favour.Id.Value, debtor = x.Favour.Debtor.Value, holder = x.Favour.Holder.Value, x.Favour.Outstanding },
        ParticipationFact x => new { kind = "Participation", eventId = x.Outcome.Event.Value, proposal = x.Outcome.Proposal.Value, outcome = x.Outcome.Kind.ToString(), x.Outcome.Reason },
        SupportFact x => new { kind = "Support", eventId = x.Event.Value, x.Cycle, first = x.First.Value, second = x.Second.Value, supportKind = x.Kind.ToString(), x.Order },
        HouseholdExistenceFact x => new { kind = "HouseholdExistence", household = x.Household.Value, x.Continues, warrant = x.Warrant.Value },
        _ => new { kind = proposition.GetType().Name, text = proposition.ToString() }
    };

    private static string ActionKind(ActionTerms? terms) => terms?.GetType().Name ?? "None";

    private static object? ActionDto(ActionTerms? terms) => terms switch
    {
        null => null,
        Farm => new { kind = "Farm" },
        OfferGift x => new { kind = "OfferGift", target = x.Target.Value, x.Amount },
        RequestGiftOrHelp x => new { kind = "RequestGiftOrHelp", target = x.Target.Value, x.Amount },
        OfferLoan x => new { kind = "OfferLoan", target = x.Target.Value, x.Amount },
        RequestLoan x => new { kind = "RequestLoan", target = x.Target.Value, x.Amount },
        RepayDebt x => new { kind = "RepayDebt", debt = x.Debt.Value, x.Amount },
        OfferBenefitForFavor x => new { kind = "OfferBenefitForFavor", target = x.Target.Value, x.Amount },
        RelationshipMediatedReciprocalHelp x => new { kind = "RelationshipMediatedReciprocalHelp", target = x.Target.Value, x.Amount, x.Request },
        CallFavor x => new { kind = "CallFavor", favour = x.Favour.Value, requested = ActionDto(x.Requested) },
        CancelReciprocalFavours x => new { kind = "CancelReciprocalFavours", target = x.Target.Value },
        ProposeMarriage x => new { kind = "ProposeMarriage", bride = x.Bride.Value, x.ProposedDowry },
        MoveResidence x => new { kind = "MoveResidence", target = x.Target.Value, destination = x.Destination.Value },
        InviteResidence x => new { kind = "InviteResidence", target = x.Target.Value, destination = x.Destination.Value },
        CommunicateClaim x => new { kind = "CommunicateClaim", recipient = x.Recipient.Value, claim = ClaimDto(x.Claim) },
        RequestHouseholdParticipation x => new { kind = "RequestHouseholdParticipation", household = x.Household.Value, bridge = x.Bridge.Value },
        InviteHouseholdParticipation x => new { kind = "InviteHouseholdParticipation", household = x.Household.Value, newcomer = x.Newcomer.Value },
        EndHouseholdParticipation x => new { kind = "EndHouseholdParticipation", household = x.Household.Value },
        _ => new { kind = terms.GetType().Name, text = terms.ToString() }
    };

    private static object ClaimDto(HeldClaim claim) => claim switch
    {
        HeldFact x => new { kind = "HeldFact", evidence = x.Evidence.Value },
        HeldRecognition x => new { kind = "HeldRecognition", candidate = x.Candidate.Value },
        HeldHouseholdRecognition x => new { kind = "HeldHouseholdRecognition", household = x.Household.Value },
        _ => new { kind = claim.GetType().Name, text = claim.ToString() }
    };

    private static void WriteJson(string path, object value) =>
        File.WriteAllText(path, JsonSerializer.Serialize(value, JsonOptions));

    private static string? Arg(string[] args, string name)
    {
        for (int i = 0; i < args.Length - 1; i++)
            if (string.Equals(args[i], name, StringComparison.Ordinal))
                return args[i + 1];
        return null;
    }
}
