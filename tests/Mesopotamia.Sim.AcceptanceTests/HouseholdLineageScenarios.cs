using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    private static InitialWorld LineageWorld(int count = 8, bool reverse = false)
    {
        InitialWorld w = World(count, [], grain: 1000, reverse: reverse);
        List<Kinship> kin = [];
        for (int a = 1; a <= count; a++)
            for (int b = a + 1; b <= count; b++) kin.Add(new(new(1000 + a * 100 + b), P(a), P(b), KinshipKind.Sibling));
        return WithKnowledge(w with { Kinships = [.. reverse ? kin.AsEnumerable().Reverse() : kin] });
    }
    private static void ShareSupports(Lab lab, int[] core)
    {
        SemanticEvent[] supports = [.. lab.Sim.History.Where(e => e.Kind is "Gift" or "Loan" or "Help" or "CalledFavourFulfilled" &&
            e.Participants.All(p => core.Contains((int)p.Value)))];
        foreach (SemanticEvent support in supports)
            foreach (int recipient in core)
            {
                if (lab.Sim.EpistemicStateOf(P(recipient)).Facts.Any(f => f.Proposition is SupportFact s && s.Event == support.Id)) continue;
                int sender = (int)support.Participants[0].Value;
                KnownFact held = lab.Sim.EpistemicStateOf(P(sender)).Facts.First(f => f.Proposition is SupportFact s && s.Event == support.Id);
                lab.Step((sender, new CommunicateClaim(P(recipient), new HeldFact(held.Id))));
            }
    }
    private HouseholdId FormGroup(Lab lab, long candidate, int[] core, bool fresh = true)
    {
        if (fresh)
        {
            lab.Step((core[0], new OfferGift(P(core[1]), 1)));
            lab.Step((core[1], new OfferGift(P(core[0]), 1)));
        }
        ShareSupports(lab, core);
        lab.Declare(candidate, core); lab.Step();
        HouseholdId h = H(lab, candidate);
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, declarations: lab.Declarations);
        ProducerEvidence.Add(new
        {
            Producer = "BoundedOrdinaryFormation",
            Candidate = candidate,
            Result = "PASS",
            FixtureAudit = "lower-level-only",
            Configuration = lab.Initial.Configuration.Version,
            OutputIdentity = Digest(lab)
        });
        return h;
    }

    private IEnumerable<HouseholdCase> LineageCases()
    {
        yield return new("DivisionPositiveFreshnessAndDissolvedExclusion", ["050", "051", "052", "058", "059", "060", "061", "066"], () =>
        {
            foreach (string variant in new[] { "positive", "stale", "dissolved" })
            {
                Lab lab = Create(LineageWorld()); HouseholdId predecessor = FormGroup(lab, 1, [1, 2, 3]);
                Exit(lab, predecessor, 1); Exit(lab, predecessor, 2);
                if (variant == "dissolved") Exit(lab, predecessor, 3);
                var beforeRelations = lab.Sim.Snapshot.Kinships.Values.ToArray();
                HouseholdId successor = FormGroup(lab, 2, [1, 2], fresh: variant != "stale");
                Assert.AreNotEqual(predecessor, successor);
                LineageWarrant? lineage = lab.Sim.HouseholdSnapshot.Lineages.Values.SingleOrDefault(l => l.Successor == successor);
                if (variant == "positive")
                {
                    Assert.IsNotNull(lineage); Assert.AreEqual(HouseholdLineageKind.DivisionDescendant, lineage.Kind);
                    Assert.IsTrue(lineage.Predecessors.SetEquals([predecessor]));
                    Assert.IsTrue(lab.Sim.HouseholdSnapshot.DerivedFrom(successor, predecessor));
                    Assert.AreEqual(HouseholdLifecycle.Inactive, lab.Sim.HouseholdSnapshot.Households[predecessor].Lifecycle);
                }
                else Assert.IsNull(lineage);
                Assert.IsFalse(lab.Sim.HouseholdSnapshot.DerivedFrom(predecessor, predecessor));
                Assert.IsEmpty(lab.Sim.HouseholdSnapshot.Commitments);
                Assert.AreEqual(RecognitionStatus.Unknown, lab.Sim.EpistemicStateOf(P(3)).HouseholdRecognitionOf(successor));
                Assert.IsTrue(beforeRelations.ToHashSet().SetEquals(lab.Sim.Snapshot.Kinships.Values));
                Assert.IsTrue(lab.Sim.History.Where(e => e.Kind == "HouseholdLineage").All(e => e.Material.IsEmpty));
            }
        });
        yield return new("ConsolidationPositiveAndPredecessorControls", ["053", "054", "055", "063", "067"], () =>
        {
            foreach (string variant in new[] { "positive", "survivor", "stale", "unrelated", "reverse" })
            {
                Lab lab = Create(LineageWorld(reverse: variant == "reverse"));
                HouseholdId first, second;
                if (variant == "reverse") { second = FormGroup(lab, 2, [3, 4]); first = FormGroup(lab, 1, [1, 2]); }
                else { first = FormGroup(lab, 1, [1, 2]); second = FormGroup(lab, 2, [3, 4]); }
                HouseholdId? unrelated = null;
                if (variant == "unrelated")
                {
                    unrelated = FormGroup(lab, 4, [1, 5]);
                    // Contact/current participation alone is not an ended source.
                }
                if (variant == "stale") { lab.Step((1, new OfferGift(P(3), 1))); lab.Step((3, new OfferGift(P(1), 1))); }
                Exit(lab, first, 1); Exit(lab, first, 2); Exit(lab, second, 3);
                if (variant != "survivor") Exit(lab, second, 4);
                HouseholdId successor = FormGroup(lab, 3, [1, 3], fresh: variant != "stale");
                LineageWarrant? lineage = lab.Sim.HouseholdSnapshot.Lineages.Values.SingleOrDefault(l => l.Successor == successor);
                if (variant is "survivor" or "stale") Assert.IsNull(lineage);
                else
                {
                    Assert.IsNotNull(lineage); Assert.AreEqual(HouseholdLineageKind.ConsolidationDescendant, lineage.Kind);
                    Assert.IsTrue(lineage.Predecessors.SetEquals([first, second]));
                    if (unrelated is { } other) Assert.IsFalse(lineage.Predecessors.Contains(other));
                }
                Assert.AreNotEqual(first, successor); Assert.AreNotEqual(second, successor);
            }
        });
        yield return new("AmbiguousDivisionAndConsolidationWithholdLineage", ["056", "057"], () =>
        {
            foreach (bool consolidation in new[] { false, true })
            {
                Lab lab = Create(LineageWorld());
                if (!consolidation)
                {
                    HouseholdId a = FormGroup(lab, 1, [1, 2, 3]); HouseholdId b = FormGroup(lab, 2, [1, 2, 4]);
                    Exit(lab, a, 1); Exit(lab, a, 2); Exit(lab, b, 1); Exit(lab, b, 2);
                    HouseholdId h = FormGroup(lab, 3, [1, 2]);
                    Assert.IsFalse(lab.Sim.HouseholdSnapshot.Lineages.Values.Any(l => l.Successor == h));
                }
                else
                {
                    HouseholdId a = FormGroup(lab, 1, [1, 2]); HouseholdId b = FormGroup(lab, 2, [3, 4]);
                    HouseholdId c = FormGroup(lab, 4, [1, 5]); HouseholdId d = FormGroup(lab, 5, [3, 6]);
                    foreach (var pair in new[] { (a, 1, 2), (b, 3, 4), (c, 1, 5), (d, 3, 6) })
                    { Exit(lab, pair.Item1, pair.Item2); Exit(lab, pair.Item1, pair.Item3); }
                    HouseholdId h = FormGroup(lab, 3, [1, 3]);
                    Assert.IsFalse(lab.Sim.HouseholdSnapshot.Lineages.Values.Any(l => l.Successor == h));
                }
            }
        });
        yield return new("TransitiveLineageRebuildPersistenceAndNoninterference", ["059", "060", "061", "062", "064", "089"], () =>
        {
            Lab lab = Create(LineageWorld()); HouseholdId h1 = FormGroup(lab, 1, [1, 2, 3, 4]);
            Exit(lab, h1, 1); Exit(lab, h1, 2); Exit(lab, h1, 3);
            HouseholdId h2 = FormGroup(lab, 2, [1, 2, 3]);
            Exit(lab, h1, 4); // Remove the older live division interpretation before the next successor forms.
            Exit(lab, h2, 1); Exit(lab, h2, 2);
            HouseholdId h3 = FormGroup(lab, 3, [1, 2]);
            HouseholdSnapshot snapshot = lab.Sim.HouseholdSnapshot;
            Assert.IsTrue(snapshot.DerivedFrom(h2, h1)); Assert.IsTrue(snapshot.DerivedFrom(h3, h2));
            Assert.IsFalse(snapshot.DerivedFrom(h3, h1)); Assert.IsTrue(snapshot.AncestorOf(h1, h3));
            var edges = snapshot.Lineages.Values.SelectMany(l => l.Predecessors.Select(p => (l.Successor, Predecessor: p))).ToHashSet();
            foreach (HouseholdId from in snapshot.Households.Keys)
                foreach (HouseholdId to in snapshot.Households.Keys)
                    Assert.AreEqual(edges.Contains((to, from)), snapshot.DerivedFrom(to, from));
            LineageWarrant[] retained = [.. snapshot.Lineages.Values];
            Exit(lab, h2, 3); Exit(lab, h3, 1); Exit(lab, h3, 2);
            Assert.IsTrue(retained.ToHashSet().SetEquals(lab.Sim.HouseholdSnapshot.Lineages.Values));
            Assert.IsTrue(lab.Sim.HouseholdSnapshot.AncestorOf(h1, h3));
        });
    }
}
