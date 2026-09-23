using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.Tests;

[TestClass]
public sealed class MaintenanceTests
{
    private static InitialWorld World(long grain = 1) => new(
        [new(new(1), "A", Sex.Male, grain), new(new(2), "B", Sex.Female, 20)],
        [new(new(1))], [new(new(1), new(1), new(1)), new(new(2), new(2), new(1))],
        [new(new(3), new(1), new(2), 1), new(new(4), new(2), new(1), -1)], [], [], [], new());

    [TestMethod]
    public void ConsumptionToZeroDoesNotCreateNeedUntilNextMissedConsumption()
    {
        Simulation sim = new(World());
        WorldSnapshot before = sim.Snapshot;
        CycleResult first = sim.RunCycle(CycleInput.Empty);
        Assert.AreEqual(0L, first.State.People[new(1)].Grain);
        Assert.IsFalse(first.State.People[new(1)].NeedsGrain);
        CycleResult second = sim.RunCycle(new([new(new(1), new(1), new Farm())]));
        Assert.IsTrue(second.State.People[new(1)].NeedsGrain);
        Assert.AreEqual(OutcomeKind.Unable, second.Outcomes.Single().Kind);
        Assert.AreEqual(1L, before.People[new(1)].Grain);
    }

    [TestMethod]
    public void FarmHasExplicitSourceAndExogenousGrainClearsNeed()
    {
        Simulation sim = new(World(0) with { Inputs = [new(1, 2, new(1), 1)] });
        sim.RunCycle(CycleInput.Empty);
        CycleResult result = sim.RunCycle(new([new(new(1), new(1), new Farm())]));
        Assert.AreEqual(4L, result.State.People[new(1)].Grain);
        Assert.IsFalse(result.State.People[new(1)].NeedsGrain);
        MaterialChange farm = result.Events.Single(e => e.Kind == "Farm").Material.Single();
        Assert.AreEqual(4L, farm.After - farm.Before);
        Assert.AreEqual("FarmSource", farm.Meaning);
    }

    [TestMethod]
    public void DecayRunsOnlyAtFiveCycleCadenceWithoutCrossingZero()
    {
        Simulation sim = new(World(20));
        for (int i = 0; i < 4; i++) sim.RunCycle(CycleInput.Empty);
        Assert.AreEqual(1, sim.Snapshot.AttitudeOf(new(1), new(2)));
        sim.RunCycle(CycleInput.Empty);
        Assert.AreEqual(0, sim.Snapshot.AttitudeOf(new(1), new(2)));
        Assert.AreEqual(0, sim.Snapshot.AttitudeOf(new(2), new(1)));
        Assert.AreEqual(0, sim.RunCycle(CycleInput.Empty).Events.Count(e => e.Kind == "AttitudeDecay"));
    }
}
