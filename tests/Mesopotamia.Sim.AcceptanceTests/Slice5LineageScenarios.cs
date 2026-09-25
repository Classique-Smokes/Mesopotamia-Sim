using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    internal static void CheckpointLineage(Slice5Scenarios evidence)
    {
        HouseholdScenarios suite = new();
        Lab lab = suite.Create(LineageWorld());
        HouseholdId predecessor = suite.FormGroup(lab, 1, [1, 2, 3, 4]);
        Exit(lab, predecessor, 1); Exit(lab, predecessor, 2);
        lab.Step((1, new OfferGift(P(2), 1))); lab.Step((2, new OfferGift(P(1), 1)));
        ShareSupports(lab, [1, 2]);
        lab.Declare(2, [1, 2]);
        Simulation restored = evidence.Capture(lab.Sim, "LineageProducer", new
        {
            lab.Initial,
            lab.Declarations,
            Producer = "FormGroup plus exits, fresh ordinary support, communication and late referent",
            History = lab.Sim.History
        });
        SimulationCheckpoint checkpoint = CheckpointCodec.Decode(lab.Sim.CaptureCheckpoint());
        CycleResult formation = Slice5Scenarios.Pair(lab.Sim, restored, CycleInput.Empty); lab.Cycles.Add(formation);
        HouseholdId child = H(lab, 2);
        Assert.AreNotEqual(predecessor, child);
        Assert.IsTrue(restored.HouseholdSnapshot.DerivedFrom(child, predecessor));
        Assert.AreEqual(HouseholdLineageKind.DivisionDescendant, restored.HouseholdSnapshot.Lineages.Values.Single().Kind);
        Assert.IsTrue(restored.HouseholdSnapshot.HeadRoles.Values.Any(r => r.Household == child && r.Occupant is null));
        var mutants = new[]
        {
            ("candidate-referent", checkpoint with { Epistemic = checkpoint.Epistemic with { Candidates = [.. checkpoint.Epistemic.Candidates.Where(c => c.Id.Value != 2)] } }),
            ("ordinary-supports", checkpoint with { Households = checkpoint.Households with { Supports = [] } }),
            ("household-frontier", checkpoint with { Households = checkpoint.Households with { NextHousehold = checkpoint.Households.NextHousehold + 10 } }),
            ("warrant-frontier", checkpoint with { Households = checkpoint.Households with { NextWarrant = checkpoint.Households.NextWarrant + 10 } }),
            ("association-frontier", checkpoint with { Households = checkpoint.Households with { NextAssociation = checkpoint.Households.NextAssociation + 10 } }),
            ("head-role-frontier", checkpoint with { Households = checkpoint.Households with { NextHeadRole = checkpoint.Households.NextHeadRole + 10 } })
        };
        foreach (var (name, mutant) in mutants)
        {
            Simulation bad = Simulation.RestoreCheckpoint(CheckpointCodec.Encode(mutant), lab.Initial.Configuration);
            CycleResult suffix = bad.RunCycle(CycleInput.Empty);
            Assert.IsFalse(bad.IsFaulted);
            Assert.ThrowsExactly<AssertFailedException>(() => Slice5Oracle.Same(formation.Households, suffix.Households, name + " dependent formation"));
            evidence.Mutations.Add(new
            {
                Name = name,
                Classification = "semantic-mismatch",
                Continuable = true,
                CaptureCycle = checkpoint.Cycle,
                ReachedCycle = suffix.State.Cycle,
                Original = checkpoint,
                Mutant = mutant,
                IntendedAssertion = "Uninterrupted future division formation and generated identities"
            });
        }
        foreach (int person in new[] { 1, 2 })
        {
            CycleResult ended = Slice5Scenarios.Pair(lab.Sim, restored,
                new([new(new(10000 + person), P(person), new EndHouseholdParticipation(child))]));
            lab.Cycles.Add(ended);
        }
        Assert.AreEqual(HouseholdLifecycle.Dissolved, restored.HouseholdSnapshot.Households[child].Lifecycle);
        Assert.IsTrue(restored.HouseholdSnapshot.DerivedFrom(child, predecessor));
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, declarations: lab.Declarations);
        _ = evidence.Capture(restored, "RetainedLineage", "Verified division and dissolution history");
    }
}
