using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.Tests;

[TestClass]
public sealed class StateTests
{
    private static InitialWorld World(long grain = 4) => new(
        [new(new(1), "A", Sex.Male, grain)], [new(new(1))],
        [new(new(1), new(1), new(1))], [], [], [], [], new());

    [TestMethod]
    public void StateUsesIndependentStableIdentity()
    {
        Simulation sim = new(World());
        WorldSnapshot snapshot = sim.Snapshot;
        Person renamed = snapshot.People[new(1)] with { Name = "Renamed" };
        Assert.AreEqual(new PersonId(1), renamed.Id);
        Assert.AreEqual("A", sim.Snapshot.People[new(1)].Name);
        Assert.AreEqual(4L, snapshot.People[new(1)].Grain);
    }

    [TestMethod]
    public void InvalidReferencesAndMaterialStateAreRejected()
    {
        Assert.ThrowsExactly<ArgumentException>(() => new Simulation(World(-1)));
        Assert.ThrowsExactly<ArgumentException>(() => new Simulation(World() with
        { Residences = [new(new(1), new(1), new(99))] }));
        Assert.ThrowsExactly<ArgumentException>(() => new Simulation(World() with
        { People = [new(new(1), "A", Sex.Male, 4, true)] }));
    }
}
