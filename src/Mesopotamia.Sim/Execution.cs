using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public abstract record ActionTerms;
public sealed record Farm : ActionTerms;
public sealed record Proposal(ProposalId Id, PersonId Actor, ActionTerms Terms);
public sealed record CycleInput(ImmutableArray<Proposal> Proposals)
{
    public static CycleInput Empty => new([]);
}
public enum OutcomeKind { Committed, Declined, Unable, InvalidatedAtResolution, InvalidTerms }
public sealed record Outcome(ProposalId Proposal, PersonId Actor, OutcomeKind Kind, string Reason, EventId Event);
public sealed record MaterialChange(PersonId Person, long Before, long After, string Meaning);
public sealed record SemanticEvent(EventId Id, long Cycle, int ReactionIndex, string Kind,
    ProposalId? Proposal, ImmutableArray<PersonId> Participants, ImmutableArray<EventId> Causes,
    ImmutableArray<MaterialChange> Material, string Detail, string ConfigurationVersion, bool TechnicalFallback = false);
public sealed record CycleResult(WorldSnapshot State, ImmutableArray<Outcome> Outcomes,
    ImmutableArray<SemanticEvent> Events, bool MaterialDeadlock);

public sealed partial class Simulation
{
    private readonly List<SemanticEvent> events = [];
    private long nextEvent = 1;
    private int reactionIndex;
    private bool faulted;
    private readonly HashSet<ProposalId> usedProposals = [];
    public ImmutableArray<SemanticEvent> History => events.ToImmutableArray();

    public CycleResult RunCycle(CycleInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (faulted) throw new InvalidOperationException("A failed cycle cannot be resumed.");
        if (input.Proposals.Select(p => p.Actor).Distinct().Count() != input.Proposals.Length)
            throw new ArgumentException("At most one personal initiative per person/cycle.", nameof(input));
        if (input.Proposals.Any(p => p.Id.Value <= 0 || usedProposals.Contains(p.Id) || !state.People.ContainsKey(p.Actor)) ||
            input.Proposals.Select(p => p.Id).Distinct().Count() != input.Proposals.Length)
            throw new ArgumentException("Invalid or reused proposal identity.", nameof(input));
        int start = events.Count;
        cycle = checked(cycle + 1);
        reactionIndex = 0;
        try
        {
            Maintenance();
            List<Outcome> outcomes = [];
            foreach (Proposal proposal in input.Proposals.OrderBy(p => p.Id.Value))
            {
                usedProposals.Add(proposal.Id);
                Person person = state.People[proposal.Actor];
                if (proposal.Terms is not Farm) throw new ArgumentException("Unknown action meaning.", nameof(input));
                if (person.NeedsGrain)
                {
                    SemanticEvent unable = Record("Unable", proposal.Id, [person.Id], [], [], "NeedsGrain");
                    outcomes.Add(new(proposal.Id, person.Id, OutcomeKind.Unable, "NeedsGrain", unable.Id));
                }
                else
                {
                    long after = checked(person.Grain + 4);
                    state.People[person.Id] = person with { Grain = after };
                    SemanticEvent farm = Record("Farm", proposal.Id, [person.Id], [], [new(person.Id, person.Grain, after, "FarmSource")], "Farm");
                    outcomes.Add(new(proposal.Id, person.Id, OutcomeKind.Committed, "", farm.Id));
                    state.Validate();
                }
            }
            published = state.Snapshot(cycle);
            bool deadlock = state.People.Count > 0 && state.People.Values.All(p => p.NeedsGrain && p.Grain == 0) &&
                !initial.Inputs.Any(i => i.Cycle > cycle && i.Delta > 0);
            return new(published, outcomes.ToImmutableArray(), events.Skip(start).ToImmutableArray(), deadlock);
        }
        catch
        {
            faulted = true;
            throw;
        }
    }

    private void Maintenance()
    {
        foreach (GrainInput input in initial.Inputs.Where(i => i.Cycle == cycle).OrderBy(i => i.Id))
        {
            Person person = state.People[input.Person];
            long after = checked(person.Grain + input.Delta);
            if (after < 0) throw new InvalidOperationException("Exogenous debit exceeds stock.");
            state.People[person.Id] = person with { Grain = after, NeedsGrain = person.NeedsGrain && after == 0 };
            Record("ExogenousGrain", null, [person.Id], [], [new(person.Id, person.Grain, after, "FixtureInput")], $"Input:{input.Id}");
            state.Validate();
        }
        foreach (Person person in state.People.Values.OrderBy(p => p.Id.Value).ToArray())
        {
            if (person.Grain > 0)
            {
                state.People[person.Id] = person with { Grain = person.Grain - 1 };
                Record("Consumption", null, [person.Id], [], [new(person.Id, person.Grain, person.Grain - 1, "ConsumptionSink")], "Paid");
            }
            else
            {
                state.People[person.Id] = person with { NeedsGrain = true };
                Record("MissedConsumption", null, [person.Id], [], [], "NeedsGrain");
            }
            state.Validate();
        }
        if (cycle % 5 == 0)
            foreach (Attitude attitude in state.Attitudes.Values.OrderBy(a => a.Id.Value).ToArray())
            {
                int after = attitude.Value > 0 ? Math.Max(0, attitude.Value - 2) : Math.Min(0, attitude.Value + 1);
                state.Attitudes[attitude.Id] = attitude with { Value = after };
                Record("AttitudeDecay", null, [attitude.From, attitude.To], [], [], $"{attitude.Value}->{after}");
                state.Validate();
            }
    }

    private SemanticEvent Record(string kind, ProposalId? proposal, ImmutableArray<PersonId> participants,
        ImmutableArray<EventId> causes, ImmutableArray<MaterialChange> material, string detail, bool fallback = false)
    {
        SemanticEvent entry = new(new(checked(nextEvent++)), cycle, checked(reactionIndex++), kind, proposal,
            participants, causes, material, detail, initial.Configuration.Version, fallback);
        events.Add(entry);
        return entry;
    }
}
