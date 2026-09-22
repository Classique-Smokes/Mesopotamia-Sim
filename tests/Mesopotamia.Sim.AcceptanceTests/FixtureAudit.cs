using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private readonly List<(InitialWorld Initial, Simulation Simulation)> worlds = [];
    internal List<object> FixtureEvidence { get; } = [];
    internal void BeginCase() => worlds.Clear();
    private Simulation Create(InitialWorld initial, Simulation.ReactionChallenge challenge = Simulation.ReactionChallenge.None)
    {
        Simulation simulation = new(initial) { Challenge = challenge };
        worlds.Add((initial, simulation));
        return simulation;
    }
    internal void AuditCase(string name)
    {
        foreach (var world in worlds)
        {
            InvariantOracle.Verify(world.Initial, world.Simulation.Snapshot, world.Simulation.History, world.Simulation.DecisionHistory);
            FixtureEvidence.Add(new
            {
                Scenario = name,
                InitialPeople = world.Initial.People,
                InitialDwellings = world.Initial.Dwellings,
                InitialResidences = world.Initial.Residences,
                InitialAttitudes = world.Initial.Attitudes,
                InitialKinships = world.Initial.Kinships,
                InitialMarriages = world.Initial.Marriages,
                ScheduledGrainInputs = world.Initial.Inputs,
                EndogenousDebtFavourWrites = 0,
                ProposalIngress = "Simulation.RunCycle; no direct transition-result writes",
                InitialFactOrigin = "Declared fixture",
                CommittedEventOrigin = "Production simulation",
                StableCycles = world.Simulation.Snapshot.Cycle,
                Invariants = "PASS",
                DeliberateFaultChallenge = world.Simulation.IsFaulted,
                Subcase = FixtureEvidence.Count + 1,
                Configuration = world.Initial.Configuration.Version,
                Profiles = world.Simulation.DecisionHistory.Select(d => d.Profile).Distinct().Order(StringComparer.Ordinal),
                SubmittedTerms = world.Simulation.History.Where(e => e.Kind == "Proposal").Select(e => new { e.Cycle, e.Proposal, Actor = e.Participants[0], Terms = e.Detail }),
                Fallbacks = world.Simulation.History.Where(e => e.TechnicalFallback).Select(e => new { e.Id, e.Kind, e.Cycle, e.Proposal }),
                DecisionFallbacks = world.Simulation.DecisionHistory.Where(d => d.TechnicalFallback).Select(d => new { d.Cycle, d.Actor, d.Proposal, d.Profile })
            });
        }
    }
}
