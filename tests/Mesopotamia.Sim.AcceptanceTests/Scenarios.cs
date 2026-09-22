using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record Scenario(string Name, string[] Ids, Action Run,
    string FixtureWrites = "Initial people/grain/residence/attitude/kinship/marriage; declared exogenous grain; public proposals/responses",
    string Oracle = "Hand-authored expected state, arithmetic, and recorded provenance");

internal static partial class Scenarios
{
    internal static InitialWorld World(long a = 8, long b = 8, long c = 8, int ab = 0, int ba = 0) => new(
        [new(new(1), "A", Sex.Male, a), new(new(2), "B", Sex.Female, b), new(new(3), "C", Sex.Male, c)],
        [new(new(1)), new(new(2)), new(new(3))],
        [new(new(1), new(1), new(1)), new(new(2), new(2), new(2)), new(new(3), new(3), new(3))],
        [new(new(4), new(1), new(2), ab), new(new(5), new(2), new(1), ba)], [], [], [], new());
    internal static void Equal<T>(T expected, T actual) => Assert.AreEqual(expected, actual);
    internal static void True(bool actual) => Assert.IsTrue(actual);
    internal static long Grain(CycleResult result, long person) => result.State.People[new(person)].Grain;
    internal static Proposal P(long id, long actor, ActionTerms terms) => new(new(id), new(actor), terms);

    internal static IEnumerable<Scenario> All()
    {
        foreach (Scenario scenario in Pipeline()) yield return scenario;
        foreach (Scenario scenario in DebtCases()) yield return scenario;
        foreach (Scenario scenario in FavourCases()) yield return scenario;
        yield return new("ConsumptionAndFarm", ["S1-090-A", "S1-090-B", "S1-090-C", "S1-090-E"], () =>
        {
            Simulation sim = new(World(1));
            WorldSnapshot before = sim.Snapshot;
            CycleResult first = sim.RunCycle(CycleInput.Empty);
            Equal(0L, Grain(first, 1));
            True(!first.State.People[new(1)].NeedsGrain);
            CycleResult second = sim.RunCycle(new([P(1, 1, new Farm())]));
            True(second.State.People[new(1)].NeedsGrain);
            Equal(OutcomeKind.Unable, second.Outcomes.Single().Kind);
            Equal(0, second.Events.Count(e => e.Kind == "Farm"));
            Equal(1L, before.People[new(1)].Grain);
            Simulation farmer = new(World(1));
            CycleResult farmed = farmer.RunCycle(new([P(1, 1, new Farm())]));
            Equal(4L, Grain(farmed, 1));
            MaterialChange source = farmed.Events.Single(e => e.Kind == "Farm").Material.Single();
            Equal(4L, source.After - source.Before);
            Equal("FarmSource", source.Meaning);
        });
        yield return new("DecayBoundaries", ["S1-097-DECAY", "S1-BND-DECAY"], () =>
        {
            foreach (int attitude in new[] { -100, -2, -1, 0, 1, 2, 100 })
            {
                Simulation sim = new(World(20, 20, 20, attitude));
                for (int i = 0; i < 4; i++) sim.RunCycle(CycleInput.Empty);
                Equal(attitude, sim.Snapshot.AttitudeOf(new(1), new(2)));
                sim.RunCycle(CycleInput.Empty);
                int expected = attitude > 0 ? Math.Max(0, attitude - 2) : Math.Min(0, attitude + 1);
                Equal(expected, sim.Snapshot.AttitudeOf(new(1), new(2)));
                sim.RunCycle(CycleInput.Empty);
                Equal(expected, sim.Snapshot.AttitudeOf(new(1), new(2)));
            }
        });
    }
}
