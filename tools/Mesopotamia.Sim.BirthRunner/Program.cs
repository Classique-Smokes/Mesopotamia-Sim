using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using Mesopotamia.Sim;

internal static class Program
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    private static int Main(string[] args)
    {
        string initialPath = Arg(args, "--initial-world")
            ?? "research/technical/SFL_V0_OBSERVATIONS/RUN-0001_BIRTH/INITIAL_WORLD.json";
        string output = Arg(args, "--output") ?? "artifacts/birth-run-001";
        string revision = Arg(args, "--revision")
            ?? Environment.GetEnvironmentVariable("GITHUB_SHA")
            ?? "UNKNOWN";

        Directory.CreateDirectory(output);
        string initialJson = File.ReadAllText(initialPath);
        InitialWorldDefinition definition = JsonSerializer.Deserialize<InitialWorldDefinition>(initialJson, JsonOptions)
            ?? throw new InvalidOperationException("Unable to deserialize initial world.");

        InitialWorld initial = Build(definition);
        Simulation simulation = new(initial);
        Dictionary<long, string> names = initial.People.ToDictionary(p => p.Id.Value, p => p.Name);
        List<object> cycleSummaries = [];
        StringBuilder transcript = new();
        transcript.AppendLine("# Birth Run 001 — Mechanical Transcript");
        transcript.AppendLine();
        transcript.AppendLine("Generated mechanically from production public simulation surfaces. No interpretation is included.");
        transcript.AppendLine();
        transcript.AppendLine("## Declared initial state");
        foreach (Person p in initial.People.OrderBy(p => p.Id.Value))
        {
            DwellingId home = initial.Residences.Single(r => r.Person == p.Id).Dwelling;
            transcript.AppendLine($"- P{p.Id.Value} {p.Name}: sex={p.Sex}; grain={p.Grain}; NeedsGrain={p.NeedsGrain}; dwelling=D{home.Value}");
        }
        transcript.AppendLine();

        string stopReason = $"Horizon:{definition.HorizonCycles}";
        string? fault = null;

        for (int i = 0; i < definition.HorizonCycles; i++)
        {
            CycleResult result;
            try
            {
                result = simulation.RunAutonomousCycle();
            }
            catch (Exception error)
            {
                stopReason = $"Fault:{error.GetType().Name}:{error.Message}";
                fault = error.ToString();
                break;
            }

            cycleSummaries.Add(CycleSummary(result, names));
            AppendTranscript(transcript, result, names);
            if (result.MaterialDeadlock)
            {
                stopReason = $"MaterialDeadlock:Cycle:{result.State.Cycle}";
                break;
            }
        }

        string executedAt = DateTimeOffset.UtcNow.ToString("O");
        object metadata = new
        {
            runId = definition.RunId,
            revision,
            executedAtUtc = executedAt,
            declaredHorizonCycles = definition.HorizonCycles,
            completedStableCycles = simulation.Snapshot.Cycle,
            stopReason,
            simulationFaulted = simulation.IsFaulted,
            fault,
            configurationVersion = simulation.Configuration.Version,
            dotnetFramework = RuntimeInformation.FrameworkDescription,
            runtimeVersion = Environment.Version.ToString(),
            os = RuntimeInformation.OSDescription,
            runnerProject = "tools/Mesopotamia.Sim.BirthRunner/Mesopotamia.Sim.BirthRunner.csproj"
        };

        WriteJson(Path.Combine(output, "RUN_METADATA.json"), metadata);
        File.WriteAllText(Path.Combine(output, "INITIAL_WORLD.json"), initialJson);
        WriteJson(Path.Combine(output, "CYCLE_SUMMARY.json"), cycleSummaries);
        WriteJson(Path.Combine(output, "SEMANTIC_HISTORY.json"), simulation.History.Select(EventDto));
        WriteJson(Path.Combine(output, "DECISION_HISTORY.json"), simulation.DecisionHistory.Select(DecisionDto));
        WriteJson(Path.Combine(output, "FINAL_SNAPSHOT.json"), SnapshotDto(simulation.Snapshot));

        transcript.AppendLine("## Stop");
        transcript.AppendLine();
        transcript.AppendLine($"- {stopReason}");
        File.WriteAllText(Path.Combine(output, "HUMAN_TRANSCRIPT.md"), transcript.ToString());

        string readme = $"""# SFL v0 Slice-1 Birth Run 001

**Run:** {definition.RunId}  
**Revision:** `{revision}`  
**Executed UTC:** {executedAt}  
**Configuration:** `{simulation.Configuration.Version}`  
**Declared horizon:** {definition.HorizonCycles} cycles  
**Stable cycles completed:** {simulation.Snapshot.Cycle}  
**Stop reason:** `{stopReason}`  
**Simulation faulted:** {simulation.IsFaulted}

## Runner

- production public simulation path only;
- repeated `Simulation.RunAutonomousCycle()`;
- no per-cycle proposal injection;
- no response injection;
- no candidate/score/winner injection;
- no verification-only `ReactionChallenge` access.

Runtime: `{RuntimeInformation.FrameworkDescription}` / `{RuntimeInformation.OSDescription}`.

## Raw package

- `INITIAL_WORLD.json`
- `RUN_METADATA.json`
- `CYCLE_SUMMARY.json`
- `SEMANTIC_HISTORY.json`
- `DECISION_HISTORY.json`
- `FINAL_SNAPSHOT.json`
- `HUMAN_TRANSCRIPT.md`

This package is raw observational evidence. It is not historical calibration and contains no Master Architect interpretation.
""";
        File.WriteAllText(Path.Combine(output, "README.md"), readme);
        return 0;
    }

    private static InitialWorld Build(InitialWorldDefinition d) => new(
        d.People.Select(p => new Person(new(p.Id), p.Name, Enum.Parse<Sex>(p.Sex, true), p.Grain, p.NeedsGrain)).ToImmutableArray(),
        d.Dwellings.Select(x => new Dwelling(new(x.Id))).ToImmutableArray(),
        d.Residences.Select(x => new Residence(new(x.Id), new(x.Person), new(x.Dwelling))).ToImmutableArray(),
        d.Attitudes.Select(x => new Attitude(new(x.Id), new(x.From), new(x.To), x.Value)).ToImmutableArray(),
        d.Kinships.Select(x => new Kinship(new(x.Id), new(x.First), new(x.Second), Enum.Parse<KinshipKind>(x.Kind, true))).ToImmutableArray(),
        d.Marriages.Select(x => new Marriage(new(x.Id), new(x.Groom), new(x.Bride))).ToImmutableArray(),
        d.Inputs.Select(x => new GrainInput(x.Id, x.Cycle, new(x.Person), x.Delta)).ToImmutableArray(),
        new Configuration(d.Configuration.Version));

    private static object CycleSummary(CycleResult result, IReadOnlyDictionary<long, string> names) => new
    {
        cycle = result.State.Cycle,
        materialDeadlock = result.MaterialDeadlock,
        people = result.State.People.Values.OrderBy(p => p.Id.Value).Select(p => new
        {
            id = p.Id.Value, p.Name, p.Grain, p.NeedsGrain, dwelling = result.State.HomeOf(p.Id).Value
        }),
        attitudes = result.State.Attitudes.Values.OrderBy(a => a.Id.Value).Select(a => new
        {
            id = a.Id.Value, from = a.From.Value, to = a.To.Value, a.Value
        }),
        debts = result.State.Debts.Values.OrderBy(d => d.Id.Value).Select(DebtDto),
        favours = result.State.Favours.Values.OrderBy(f => f.Id.Value).Select(FavourDto),
        marriages = result.State.Marriages.Values.OrderBy(m => m.Id.Value).Select(m => new
        {
            id = m.Id.Value, groom = m.Groom.Value, bride = m.Bride.Value, origin = m.Origin?.Value
        }),
        selectedDecisions = result.Decisions.OrderBy(d => d.Actor.Value).ThenBy(d => d.Context, StringComparer.Ordinal).Select(d =>
        {
            CandidateTrace? selected = d.Candidates.SingleOrDefault(c => c.Selected);
            return new
            {
                actor = d.Actor.Value,
                actorName = names[d.Actor.Value],
                d.Context,
                d.Profile,
                d.TechnicalFallback,
                selected = selected is null ? null : new { selected.Meaning, selected.FinalScore, terms = ActionDto(selected.Terms) }
            };
        }),
        outcomes = result.Outcomes.OrderBy(o => o.Proposal.Value).Select(o => new
        {
            proposal = o.Proposal.Value, actor = o.Actor.Value, actorName = names[o.Actor.Value],
            kind = o.Kind.ToString(), o.Reason, eventId = o.Event.Value
        }),
        eventKinds = result.Events.GroupBy(e => e.Kind).OrderBy(g => g.Key, StringComparer.Ordinal).ToDictionary(g => g.Key, g => g.Count())
    };

    private static object SnapshotDto(WorldSnapshot s) => new
    {
        cycle = s.Cycle,
        people = s.People.Values.OrderBy(p => p.Id.Value).Select(p => new { id = p.Id.Value, p.Name, sex = p.Sex.ToString(), p.Grain, p.NeedsGrain }),
        dwellings = s.Dwellings.Values.OrderBy(d => d.Id.Value).Select(d => new { id = d.Id.Value }),
        residences = s.Residences.Values.OrderBy(r => r.Id.Value).Select(r => new { id = r.Id.Value, person = r.Person.Value, dwelling = r.Dwelling.Value }),
        attitudes = s.Attitudes.Values.OrderBy(a => a.Id.Value).Select(a => new { id = a.Id.Value, from = a.From.Value, to = a.To.Value, a.Value }),
        kinships = s.Kinships.Values.OrderBy(k => k.Id.Value).Select(k => new { id = k.Id.Value, first = k.First.Value, second = k.Second.Value, kind = k.Kind.ToString() }),
        marriages = s.Marriages.Values.OrderBy(m => m.Id.Value).Select(m => new { id = m.Id.Value, groom = m.Groom.Value, bride = m.Bride.Value, origin = m.Origin?.Value }),
        debts = s.Debts.Values.OrderBy(d => d.Id.Value).Select(DebtDto),
        favours = s.Favours.Values.OrderBy(f => f.Id.Value).Select(FavourDto)
    };

    private static object DebtDto(Debt d) => new
    {
        id = d.Id.Value, creditor = d.Creditor.Value, debtor = d.Debtor.Value, d.Original, d.Remaining,
        d.CommittedCycle, d.DueReviewed, origin = d.Origin.Value
    };

    private static object FavourDto(Favour f) => new
    {
        id = f.Id.Value, debtor = f.Debtor.Value, holder = f.Holder.Value, f.Outstanding, origin = f.Origin.Value
    };

    private static object EventDto(SemanticEvent e) => new
    {
        id = e.Id.Value, e.Cycle, e.ReactionIndex, e.Kind, proposal = e.Proposal?.Value,
        participants = e.Participants.Select(p => p.Value),
        causes = e.Causes.Select(c => c.Value),
        material = e.Material.Select(m => new { person = m.Person.Value, m.Before, m.After, m.Meaning }),
        e.Detail, e.ConfigurationVersion, e.TechnicalFallback,
        action = ActionDto(e.Action),
        contributions = e.Contributions.Select(c => new
        {
            c.Key.Rule, trigger = c.Key.Trigger.Value, from = c.Key.From.Value, to = c.Key.To.Value, c.Delta
        })
    };

    private static object DecisionDto(DecisionTrace d) => new
    {
        d.Cycle, actor = d.Actor.Value, proposal = d.Proposal?.Value, d.Context, d.Profile, d.TechnicalFallback,
        subjectiveInputs = d.SubjectiveInputs,
        candidates = d.Candidates.Select(c => new
        {
            c.Key, c.Meaning, c.Eligible, c.Gate,
            components = c.Components.OrderBy(x => x.Key, StringComparer.Ordinal).ToDictionary(x => x.Key, x => x.Value),
            c.FinalScore, c.Selected, terms = ActionDto(c.Terms)
        })
    };

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
        _ => new { kind = terms.GetType().Name, text = terms.ToString() }
    };

    private static void AppendTranscript(StringBuilder text, CycleResult result, IReadOnlyDictionary<long, string> names)
    {
        text.AppendLine($"## Cycle {result.State.Cycle}");
        text.AppendLine();
        text.AppendLine("### Decisions");
        foreach (DecisionTrace d in result.Decisions.OrderBy(d => d.Actor.Value).ThenBy(d => d.Context, StringComparer.Ordinal))
        {
            CandidateTrace? selected = d.Candidates.SingleOrDefault(c => c.Selected);
            string choice = selected is null ? "none" : $"{selected.Meaning} score={selected.FinalScore?.ToString() ?? "n/a"} terms={selected.Terms}";
            text.AppendLine($"- {names[d.Actor.Value]} [P{d.Actor.Value}] {d.Context}/{d.Profile}: {choice}; TechnicalFallback={d.TechnicalFallback}");
        }

        text.AppendLine();
        text.AppendLine("### Outcomes");
        if (result.Outcomes.Length == 0) text.AppendLine("- none");
        foreach (Outcome o in result.Outcomes.OrderBy(o => o.Proposal.Value))
            text.AppendLine($"- Proposal P{o.Proposal.Value}: actor={names[o.Actor.Value]} [P{o.Actor.Value}]; {o.Kind}; reason={o.Reason}; event=E{o.Event.Value}");

        text.AppendLine();
        text.AppendLine("### Semantic events");
        foreach (SemanticEvent e in result.Events.OrderBy(e => e.ReactionIndex))
        {
            string participants = string.Join(",", e.Participants.Select(p => $"P{p.Value}"));
            string material = e.Material.Length == 0 ? "" :
                " material=[" + string.Join("; ", e.Material.Select(m => $"P{m.Person.Value}:{m.Before}->{m.After}:{m.Meaning}")) + "]";
            text.AppendLine($"- E{e.Id.Value} r{e.ReactionIndex}: {e.Kind}; participants=[{participants}]; detail={e.Detail}; fallback={e.TechnicalFallback}{material}");
        }

        text.AppendLine();
        text.AppendLine("### Stable state");
        foreach (Person p in result.State.People.Values.OrderBy(p => p.Id.Value))
            text.AppendLine($"- {p.Name} [P{p.Id.Value}]: grain={p.Grain}; NeedsGrain={p.NeedsGrain}; dwelling=D{result.State.HomeOf(p.Id).Value}");
        text.AppendLine($"- MaterialDeadlock={result.MaterialDeadlock}");
        text.AppendLine();
    }

    private static void WriteJson(string path, object value) =>
        File.WriteAllText(path, JsonSerializer.Serialize(value, JsonOptions));

    private static string? Arg(string[] args, string name)
    {
        for (int i = 0; i < args.Length - 1; i++)
            if (string.Equals(args[i], name, StringComparison.Ordinal))
                return args[i + 1];
        return null;
    }

    private sealed record InitialWorldDefinition(string RunId, int HorizonCycles, ConfigurationDefinition Configuration,
        PersonDefinition[] People, DwellingDefinition[] Dwellings, ResidenceDefinition[] Residences,
        AttitudeDefinition[] Attitudes, KinshipDefinition[] Kinships, MarriageDefinition[] Marriages,
        GrainInputDefinition[] Inputs);
    private sealed record ConfigurationDefinition(string Version);
    private sealed record PersonDefinition(long Id, string Name, string Sex, long Grain, bool NeedsGrain);
    private sealed record DwellingDefinition(long Id);
    private sealed record ResidenceDefinition(long Id, long Person, long Dwelling);
    private sealed record AttitudeDefinition(long Id, long From, long To, int Value);
    private sealed record KinshipDefinition(long Id, long First, long Second, string Kind);
    private sealed record MarriageDefinition(long Id, long Groom, long Bride);
    private sealed record GrainInputDefinition(long Id, long Cycle, long Person, long Delta);
}
