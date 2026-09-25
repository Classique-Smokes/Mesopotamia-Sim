using System.Collections.Immutable;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

// Named detectors for executed production mutants. They deliberately continue before
// comparing, so an early round-trip/counter inequality cannot earn mutation credit.
[TestClass]
[DoNotParallelize]
public sealed class Slice5FaultDetectors
{
    [TestMethod]
    public void FutureInputAndIdentitySuffix()
    {
        Simulation original = new(Slice5Scenarios.World(inputs: [new(1, 3, new(1), 7)]));
        original.RunCycle(new([new(new(50), new(1), new OfferLoan(new(2), 2))]));
        Simulation restored = Simulation.RestoreCheckpoint(original.CaptureCheckpoint(), original.Configuration);
        for (int cycle = 2; cycle <= 4; cycle++)
        {
            CycleInput input = cycle == 2 ? new([new(new(51), new(1), new OfferLoan(new(3), 1))]) :
                cycle == 3 ? new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new()) } : CycleInput.Empty;
            CycleResult expected = original.RunCycle(input), actual = restored.RunCycle(input);
            Slice5Oracle.Same(expected, actual, "S5 dependent future input/allocation suffix");
        }
    }

    [TestMethod]
    public void SubjectiveAndRefusalSuffix()
    {
        // Public-path producer creates a claim whose held identity is needed later.
        Simulation original = new(Slice5Scenarios.World());
        original.RunCycle(new([new(new(1), new(1), new OfferGift(new(2), 1))]));
        KnownFact support = original.EpistemicStateOf(new(1)).Facts.First(f => f.Proposition is SupportFact);
        Simulation restored = Simulation.RestoreCheckpoint(original.CaptureCheckpoint(), original.Configuration);
        CycleInput input = new([new(new(2), new(1), new CommunicateClaim(new(3), new HeldFact(support.Id)))]);
        CycleResult expected = original.RunCycle(input), actual = restored.RunCycle(input);
        Assert.AreEqual(OutcomeKind.Committed, expected.Outcomes.Single().Kind);
        Slice5Oracle.Same(expected, actual, "S5 dependent held claim suffix");
    }

    [TestMethod]
    public void ConsumedProposalSuffix()
    {
        Simulation original = new(Slice5Scenarios.World());
        original.RunCycle(new([new(new(77), new(1), new OfferGift(new(1), 1))]));
        Simulation restored = Simulation.RestoreCheckpoint(original.CaptureCheckpoint(), original.Configuration);
        CycleInput reused = new([new(new(77), new(1), new OfferGift(new(1), 1))]);
        Assert.ThrowsExactly<ArgumentException>(() => original.RunCycle(reused));
        Assert.ThrowsExactly<ArgumentException>(() => restored.RunCycle(reused), "S5 dependent duplicate prevention");
    }

    [TestMethod]
    public void StalePublishedRecognitionSuffix()
    {
        Slice4Lab lab = new(); lab.Appoint();
        Simulation restored = Simulation.RestoreCheckpoint(lab.Sim.CaptureCheckpoint(), lab.Initial.Configuration);
        EpistemicSnapshot stale = restored.EpistemicSnapshot with
        {
            Actors = restored.EpistemicSnapshot.Actors.SetItem(new(1), restored.EpistemicStateOf(new(1)) with
            {
                Facts = [.. restored.EpistemicStateOf(new(1)).Facts.Where(f => f.Proposition is not HeadRoleFact)],
                HeadRecognitions = []
            })
        };
        typeof(Simulation).GetField("publishedEpistemic", BindingFlags.Instance | BindingFlags.NonPublic)!.SetValue(restored, stale);
        CycleInput input = new([new(new(1000), new(1), new CommunicateClaim(new(4), new HeldHeadRecognition(lab.H)))]);
        CycleResult expected = lab.Sim.RunCycle(input), actual = restored.RunCycle(input);
        Assert.AreEqual(OutcomeKind.Committed, expected.Outcomes.Single().Kind);
        Slice5Oracle.Same(expected, actual, "S5 dependent stale Recognition suffix");
    }

    [TestMethod]
    public void DiagonalMaintenanceSuffix()
    {
        Simulation original = new(Slice5Scenarios.World());
        for (int i = 0; i < 4; i++) original.RunCycle(CycleInput.Empty);
        Simulation restored = Simulation.RestoreCheckpoint(original.CaptureCheckpoint(), original.Configuration);
        CycleResult expected = original.RunCycle(CycleInput.Empty), actual = restored.RunCycle(CycleInput.Empty);
        Assert.AreEqual(7, expected.State.Attitudes[new(4)].Value);
        Slice5Oracle.Same(expected, actual, "S5 dependent diagonal decay suffix");
    }
}
