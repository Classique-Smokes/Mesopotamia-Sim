using System.Collections.Immutable;
using System.Text;
using System.Text.Json;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.ObservationRunner;

internal static class Program
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true
    };

    private static readonly PersonId Aru = new(1);
    private static readonly PersonId Bela = new(2);
    private static readonly PersonId Dagan = new(3);
    private static readonly PersonId Iltani = new(4);
    private static readonly PersonId Samu = new(5);
    private static readonly PersonId Enna = new(6);
    private static readonly DwellingId D1 = new(1);
    private static readonly DwellingId D2 = new(2);
    private static readonly DwellingId D3 = new(3);
    private static readonly CandidateId Candidate = new(1);
    private static readonly EvidenceId SamuStaleResidence = new(5000);

    public static int Main(string[] args)
    {
        string output = GetOutput(args);
        Directory.CreateDirectory(output);
        string revision = Environment.GetEnvironmentVariable("OBSERVATION_REVISION") ?? "local-unpinned";
        string sdk = Environment.GetEnvironmentVariable("OBSERVATION_DOTNET_SDK") ?? "unknown";

        WriteJson(Path.Combine(output, "RUN_METADATA.json"), new
        {
            observation = "SFL_V0_SLICE2_PAUSE_001",
            sourceRevision = revision,
            dotnetSdk = sdk,
            rulesVersion = Configuration.RulesVersion,
            plan = "plans/SFL_V0_SLICE2_EPISTEMIC_OBSERVATION_PAUSE_001.md",
            horizons = new { autonomousBaseline = 12, relayStaleContest = 12 },
            interpretation = "RAW_ONLY"
        });

        File.WriteAllText(Path.Combine(output, "README.md"), $"""
# SFL v0 Slice 2 — Epistemic Observational Pause 001 Raw Package

**Source revision:** `{revision}`  
**.NET SDK:** `{sdk}`  
**Rules version:** `{Configuration.RulesVersion}`  
**Plan:** `plans/SFL_V0_SLICE2_EPISTEMIC_OBSERVATION_PAUSE_001.md`

This package is mechanically generated observation output.

It contains **no model evaluation, calibration judgment, Director interpretation, or Master Architect synthesis**.

World A is fully autonomous. World B follows the predeclared pulse schedule frozen in the plan.
""");

        Exception? failure = null;
        try
        {
            RunWorld(Path.Combine(output, "WORLD_A_AUTONOMOUS_BASELINE"), SharedWorld(staleReport: false),
                "AUTONOMOUS-BASELINE", 12, static (simulation, _) => simulation.RunAutonomousCycle());
        }
        catch (Exception ex)
        {
            failure = ex;
        }

        try
        {
            RunWorld(Path.Combine(output, "WORLD_B_RELAY_STALE_CONTEST"), SharedWorld(staleReport: true),
                "RELAY-STALE-CONTEST", 12, RelayCycle);
        }
        catch (Exception ex)
        {
            failure ??= ex;
        }

        if (failure is not null)
        {
            File.WriteAllText(Path.Combine(output, "RUN_FAILURE.txt"), failure.ToString());
            return 1;
        }

        return 0;
    }

    private static void RunWorld(string directory, InitialWorld initial, string name, int horizon,
        Func<Simulation, int, CycleResult> step)
    {
        Directory.CreateDirectory(directory);
        WriteJson(Path.Combine(directory, "INITIAL_WORLD.json"), InitialView(initial));
        Simulation simulation = new(initial);
        List<object> cycles = [];
        StringBuilder transcript = new();
        transcript.AppendLine($"# {name} — Mechanical Transcript");
        transcript.AppendLine();
        AppendBoundary(transcript, simulation, 0);

        string stopReason = $"Horizon:{horizon}";
        Exception? failure = null;

        for (int cycle = 1; cycle <= horizon; cycle++)
        {
            try
            {
                CycleResult result = step(simulation, cycle);
                cycles.Add(CycleView(result));
                AppendCycle(transcript, simulation, result);
                if (result.MaterialDeadlock)
                {
                    stopReason = $"MaterialDeadlock:{cycle}";
                    break;
                }

                if (simulation.IsFaulted)
                {
                    stopReason = $"Fault:{cycle}";
                    break;
                }
            }
            catch (Exception ex)
            {
                stopReason = $"Exception:{cycle}:{ex.GetType().Name}";
                failure = ex;
                transcript.AppendLine();
                transcript.AppendLine($"## Cycle {cycle} — EXCEPTION");
                transcript.AppendLine();
                transcript.AppendLine(ex.ToString());
                break;
            }
        }

        WriteJson(Path.Combine(directory, "CYCLES.json"), cycles);
        WriteJson(Path.Combine(directory, "SEMANTIC_HISTORY.json"), simulation.History.Select(EventView).ToArray());
        WriteJson(Path.Combine(directory, "DECISION_HISTORY.json"), simulation.DecisionHistory.Select(DecisionView).ToArray());
        WriteJson(Path.Combine(directory, "FINAL_SNAPSHOT.json"), WorldView(simulation.Snapshot));
        WriteJson(Path.Combine(directory, "FINAL_EPISTEMIC.json"), EpistemicView(simulation.EpistemicSnapshot));
        File.WriteAllText(Path.Combine(directory, "HUMAN_TRANSCRIPT.md"), transcript.ToString());
        WriteJson(Path.Combine(directory, "RUN_SUMMARY.json"), new
        {
            name,
            stopReason,
            finalCycle = simulation.Snapshot.Cycle,
            faulted = simulation.IsFaulted,
            semanticEvents = simulation.History.Length,
            decisions = simulation.DecisionHistory.Length,
            failure = failure?.ToString()
        });

        if (failure is not null)
            throw new InvalidOperationException($"{name} observation failed.", failure);
    }

    private static CycleResult RelayCycle(Simulation simulation, int cycle) => cycle switch
    {
        1 => RunPolicies(simulation, Aru, CommunicateFact(simulation, Aru, Aru, Bela)),
        2 => RunPolicies(simulation, Bela, CommunicateFact(simulation, Bela, Bela, Aru)),
        3 => simulation.RunAutonomousCycle(),
        4 => RunPolicies(simulation, Aru, CommunicationPolicy(Dagan, new HeldRecognition(Candidate))),
        5 => simulation.RunAutonomousCycle(),
        6 => RunScriptedMove(simulation),
        7 => simulation.RunAutonomousCycle(),
        8 => RunPolicies(simulation, Bela, CommunicateFact(simulation, Bela, Bela, Dagan)),
        9 => RunPolicies(simulation, Samu, CommunicationPolicy(Dagan, new HeldFact(SamuStaleResidence))),
        10 => RunPolicies(simulation, Dagan, CommunicationPolicy(Enna, new HeldRecognition(Candidate))),
        11 => RunPolicies(simulation, Bela, CommunicateFact(simulation, Bela, Bela, Aru)),
        12 => simulation.RunAutonomousCycle(),
        _ => throw new ArgumentOutOfRangeException(nameof(cycle))
    };

    private static CycleResult RunPolicies(Simulation simulation, PersonId special, PersonalPolicy policy)
    {
        ImmutableDictionary<PersonId, PersonalPolicy> policies = simulation.Snapshot.People.Keys
            .OrderBy(p => p.Value)
            .ToImmutableDictionary(p => p, p => p == special ? policy : new PersonalPolicy());
        return simulation.RunCycle(CycleInput.Empty with { PersonalPolicies = policies });
    }

    private static CycleResult RunScriptedMove(Simulation simulation)
    {
        Proposal move = new(new ProposalId(6000), Bela, new MoveResidence(Iltani, D2));
        ImmutableDictionary<PersonId, PersonalPolicy> policies = simulation.Snapshot.People.Keys
            .Where(p => p != Bela)
            .OrderBy(p => p.Value)
            .ToImmutableDictionary(p => p, _ => new PersonalPolicy());
        return simulation.RunCycle(new([move]) { PersonalPolicies = policies });
    }

    private static PersonalPolicy CommunicateFact(Simulation simulation, PersonId holder, PersonId subject, PersonId recipient)
    {
        DwellingId objectiveHome = simulation.Snapshot.HomeOf(subject);
        KnownFact fact = simulation.EpistemicStateOf(holder).Facts
            .Where(f => f.Proposition is ResidenceFact residence &&
                residence.Person == subject && residence.Dwelling == objectiveHome)
            .OrderByDescending(f => f.Provenance.Origin.Order?.Cycle ?? long.MinValue)
            .ThenByDescending(f => f.Id.Value)
            .First();
        return CommunicationPolicy(recipient, new HeldFact(fact.Id));
    }

    private static PersonalPolicy CommunicationPolicy(PersonId recipient, HeldClaim claim) =>
        new("SFL-COMMUNICATION-LAB-v1") { Communication = new(recipient, claim) };

    private static InitialWorld SharedWorld(bool staleReport)
    {
        InitialWorld world = new(
            [
                new(Aru, "Aru", Sex.Male, 18),
                new(Bela, "Bela", Sex.Female, 18),
                new(Dagan, "Dagan", Sex.Male, 8),
                new(Iltani, "Iltani", Sex.Female, 8),
                new(Samu, "Samu", Sex.Male, 8),
                new(Enna, "Enna", Sex.Female, 8)
            ],
            [new(D1), new(D2), new(D3)],
            [
                new(new RelationId(1), Aru, D1),
                new(new RelationId(2), Bela, D1),
                new(new RelationId(3), Dagan, D3),
                new(new RelationId(4), Iltani, D2),
                new(new RelationId(5), Samu, D2),
                new(new RelationId(6), Enna, D3)
            ],
            [
                new(new RelationId(10), Aru, Bela, 80),
                new(new RelationId(11), Bela, Aru, 80)
            ],
            [new(new RelationId(12), Aru, Bela, KinshipKind.Sibling)],
            [],
            [],
            new Configuration("SFL-S2-OBS-001"))
        {
            Candidates = [new(Candidate, [Aru, Bela])],
            Knowledge = staleReport
                ?
                [
                    new(Samu,
                    [
                        new(SamuStaleResidence, new ResidenceFact(Bela, D1),
                            new(AcquisitionRoute.Fixture,
                                new(Bela, null, null, "predeclared-stale-report"), []))
                    ])
                ]
                : []
        };
        return world;
    }

    private static void AppendCycle(StringBuilder text, Simulation simulation, CycleResult result)
    {
        text.AppendLine();
        text.AppendLine($"## Cycle {result.State.Cycle}");
        text.AppendLine();

        foreach (DecisionTrace decision in result.Decisions.OrderBy(d => d.Actor.Value).ThenBy(d => d.Context, StringComparer.Ordinal))
        {
            CandidateTrace? selected = decision.Candidates.SingleOrDefault(c => c.Selected);
            CandidateTrace? communication = decision.Candidates.SingleOrDefault(c => c.Terms is CommunicateClaim);
            text.Append("- Decision actor ").Append(decision.Actor.Value).Append(' ')
                .Append(decision.Context).Append(": selected=")
                .Append(selected is null ? "none" : Describe(selected.Terms))
                .Append("; fallback=").Append(decision.TechnicalFallback);
            if (communication is not null)
                text.Append("; communication[eligible=").Append(communication.Eligible)
                    .Append(",gate=").Append(string.IsNullOrEmpty(communication.Gate) ? "<none>" : communication.Gate)
                    .Append(",selected=").Append(communication.Selected).Append(']');
            text.AppendLine();
        }

        foreach (Outcome outcome in result.Outcomes.OrderBy(o => o.Proposal.Value))
            text.AppendLine($"- Outcome proposal {outcome.Proposal.Value}: {outcome.Kind} {outcome.Reason}");

        foreach (SemanticEvent entry in result.Events.Where(e => e.Kind == "Communication").OrderBy(e => e.ReactionIndex))
            text.AppendLine($"- Communication: {entry.Participants[0].Value}->{entry.Participants[1].Value}; " +
                $"evidence={entry.TransmittedEvidence.Length}; fallback={entry.TechnicalFallback}");

        AppendBoundary(text, simulation, result.State.Cycle);
    }

    private static void AppendBoundary(StringBuilder text, Simulation simulation, long cycle)
    {
        text.AppendLine($"- Stable boundary {cycle}:");
        foreach (Person person in simulation.Snapshot.People.Values.OrderBy(p => p.Id.Value))
            text.AppendLine($"  - P{person.Id.Value} {person.Name}: grain={person.Grain}; needs={person.NeedsGrain}; " +
                $"home=D{simulation.Snapshot.HomeOf(person.Id).Value}; recognition(C1)={simulation.EpistemicStateOf(person.Id).RecognitionOf(Candidate)}");

        foreach (PersonId actor in simulation.Snapshot.People.Keys.OrderBy(p => p.Value))
        {
            string beliefs = string.Join(", ", simulation.EpistemicStateOf(actor).Facts
                .Where(f => f.Proposition is ResidenceFact residence && residence.Person == Bela)
                .Select(f =>
                {
                    ResidenceFact residence = (ResidenceFact)f.Proposition;
                    return $"D{residence.Dwelling.Value}/{f.Provenance.Route}/" +
                        $"{(f.Provenance.Origin.Order is null ? "unordered" : $"{f.Provenance.Origin.Order.Cycle}:{f.Provenance.Origin.Order.ReactionIndex}")}";
                }));
            text.AppendLine($"  - P{actor.Value} beliefs about Bela residence: {(beliefs.Length == 0 ? "<none>" : beliefs)}");
        }
    }

    private static object CycleView(CycleResult result) => new
    {
        cycle = result.State.Cycle,
        materialDeadlock = result.MaterialDeadlock,
        state = WorldView(result.State),
        epistemic = result.Epistemic is null ? null : EpistemicView(result.Epistemic),
        outcomes = result.Outcomes,
        events = result.Events.Select(EventView).ToArray(),
        decisions = result.Decisions.Select(DecisionView).ToArray()
    };

    private static object InitialView(InitialWorld initial) => new
    {
        people = initial.People,
        dwellings = initial.Dwellings,
        residences = initial.Residences,
        attitudes = initial.Attitudes,
        kinships = initial.Kinships,
        marriages = initial.Marriages,
        inputs = initial.Inputs,
        configuration = initial.Configuration,
        candidates = initial.Candidates,
        knowledge = initial.Knowledge
    };

    private static object WorldView(WorldSnapshot state) => new
    {
        state.Cycle,
        people = state.People.Values.OrderBy(p => p.Id.Value).ToArray(),
        dwellings = state.Dwellings.Values.OrderBy(d => d.Id.Value).ToArray(),
        residences = state.Residences.Values.OrderBy(r => r.Id.Value).ToArray(),
        attitudes = state.Attitudes.Values.OrderBy(a => a.Id.Value).ToArray(),
        kinships = state.Kinships.Values.OrderBy(k => k.Id.Value).ToArray(),
        marriages = state.Marriages.Values.OrderBy(m => m.Id.Value).ToArray(),
        debts = state.Debts.Values.OrderBy(d => d.Id.Value).ToArray(),
        favours = state.Favours.Values.OrderBy(f => f.Id.Value).ToArray()
    };

    private static object EpistemicView(EpistemicSnapshot state) => new
    {
        state.Cycle,
        actors = state.Actors.OrderBy(a => a.Key.Value).Select(a => new
        {
            actor = a.Key,
            facts = a.Value.Facts,
            recognitions = a.Value.Recognitions
        }).ToArray()
    };

    private static object EventView(SemanticEvent entry) => new
    {
        entry.Id,
        entry.Cycle,
        entry.ReactionIndex,
        entry.Kind,
        entry.Proposal,
        entry.Participants,
        entry.Causes,
        entry.Material,
        entry.Detail,
        entry.ConfigurationVersion,
        entry.RulesVersion,
        entry.TechnicalFallback,
        action = Describe(entry.Action),
        entry.TransmittedEvidence
    };

    private static object DecisionView(DecisionTrace decision) => new
    {
        decision.Actor,
        decision.Proposal,
        decision.Context,
        decision.Profile,
        decision.Cycle,
        decision.RulesVersion,
        decision.SubjectiveInputs,
        decision.TechnicalFallback,
        candidates = decision.Candidates.Select(c => new
        {
            c.Key,
            c.Meaning,
            c.Eligible,
            c.Gate,
            c.Components,
            c.FinalScore,
            c.Selected,
            terms = Describe(c.Terms)
        }).ToArray()
    };

    private static string Describe(ActionTerms? terms) => terms switch
    {
        null => "<none>",
        Farm => "Farm",
        CommunicateClaim c => $"CommunicateClaim(P{c.Recipient.Value},{DescribeClaim(c.Claim)})",
        OfferGift g => $"OfferGift(P{g.Target.Value},{g.Amount})",
        RequestGiftOrHelp g => $"RequestGiftOrHelp(P{g.Target.Value},{g.Amount})",
        OfferLoan l => $"OfferLoan(P{l.Target.Value},{l.Amount})",
        RequestLoan l => $"RequestLoan(P{l.Target.Value},{l.Amount})",
        RepayDebt r => $"RepayDebt(R{r.Debt.Value},{r.Amount})",
        OfferBenefitForFavor b => $"OfferBenefitForFavor(P{b.Target.Value},{b.Amount})",
        RelationshipMediatedReciprocalHelp h => $"ReciprocalHelp(P{h.Target.Value},{h.Amount},request={h.Request})",
        CallFavor f => $"CallFavor(R{f.Favour.Value},{Describe(f.Requested)})",
        CancelReciprocalFavours f => $"CancelReciprocalFavours(P{f.Target.Value})",
        ProposeMarriage m => $"ProposeMarriage(P{m.Bride.Value},{m.ProposedDowry})",
        MoveResidence m => $"MoveResidence(P{m.Target.Value},D{m.Destination.Value})",
        InviteResidence i => $"InviteResidence(P{i.Target.Value},D{i.Destination.Value})",
        _ => terms.GetType().Name
    };

    private static string DescribeClaim(HeldClaim claim) => claim switch
    {
        HeldFact f => $"HeldFact(E{f.Evidence.Value})",
        HeldRecognition r => $"HeldRecognition(C{r.Candidate.Value})",
        _ => claim.GetType().Name
    };

    private static void WriteJson(string path, object value) =>
        File.WriteAllText(path, JsonSerializer.Serialize(value, JsonOptions));

    private static string GetOutput(string[] args)
    {
        for (int i = 0; i < args.Length - 1; i++)
            if (args[i] == "--output")
                return Path.GetFullPath(args[i + 1]);
        return Path.GetFullPath("artifacts/observation/SFL_V0_SLICE2_PAUSE_001");
    }
}
