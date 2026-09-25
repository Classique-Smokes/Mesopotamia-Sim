using System.Collections.Immutable;
using System.Reflection;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    private IEnumerable<HouseholdCase> StructuralCases()
    {
        yield return new("ExplicitAuthorityAndInertCandidateBoundary", ["007", "008", "009", "093"], () =>
        {
            Lab lab = Create(); lab.Step(); lab.Step();
            Assert.IsEmpty(lab.Sim.HouseholdSnapshot.Households);
            Assert.IsFalse(typeof(InitialWorld).GetProperties().Any(p => p.PropertyType.Name.Contains("Household", StringComparison.Ordinal)));
            Type[] types = typeof(Simulation).Assembly.GetTypes();
            Assert.IsFalse(types.Any(t => t.Name is "FormHousehold" or "MemberOf" or "DivisionTransformation" or "ConsolidationTransformation"));
            string[] world = typeof(WorldState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order(StringComparer.Ordinal).ToArray();
            string[] expected = new[] { "<People>k__BackingField", "<Dwellings>k__BackingField", "<Residences>k__BackingField", "<Attitudes>k__BackingField", "<Kinships>k__BackingField", "<Marriages>k__BackingField", "<Debts>k__BackingField", "<Favours>k__BackingField", "nextRelation" }.Order(StringComparer.Ordinal).ToArray();
            Assert.IsTrue(world.SequenceEqual(expected));
            string[] fields = typeof(HouseholdState).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Select(f => f.Name).Order(StringComparer.Ordinal).ToArray();
            string[] authoritative = new[] { "<Households>k__BackingField", "<Formations>k__BackingField", "<Associations>k__BackingField", "<Entries>k__BackingField", "<Exits>k__BackingField", "<Continuations>k__BackingField", "<Lineages>k__BackingField", "<Commitments>k__BackingField", "<Supports>k__BackingField", "nextHousehold", "nextWarrant", "nextAssociation", "nextCommitment" }.Order(StringComparer.Ordinal).ToArray();
            // Approved adaptation B: enumerate each new typed authority field explicitly.
            authoritative = [.. authoritative.Concat(["<HeadRoles>k__BackingField", "<HeadTransitions>k__BackingField", "<ProvisionRefusals>k__BackingField", "nextHeadRole"]).Order(StringComparer.Ordinal)];
            Assert.IsTrue(fields.SequenceEqual(authoritative));
            Assert.IsTrue(typeof(HouseholdSnapshot).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).All(f => f.IsInitOnly));
            foreach (string file in new[] { "Agency.cs", "PersonalDecisionInputs.cs", "Decisions.cs" })
                Assert.IsFalse(File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "src/Mesopotamia.Sim", file)).Contains(".Lineages", StringComparison.Ordinal));
        });
        yield return new("DuplicateCauseClosureAndSnapshotIsolation", ["081", "083", "084", "089", "091"], () =>
        {
            Lab lab = Form(challenge: Simulation.ReactionChallenge.DuplicateCauses);
            HouseholdSnapshot old = lab.Sim.HouseholdSnapshot;
            HouseholdId h = H(lab); PrepareEntry(lab, h); Entry(lab, h, false);
            Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Formations.Count);
            Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Entries.Count);
            Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Continuations.Count);
            Assert.AreEqual(3, old.Participants(h).Length); Assert.AreEqual(4, lab.Sim.HouseholdSnapshot.Participants(h).Length);
            Assert.IsTrue(ProducerEvidence.Count > 0);
            Lab failed = Create(challenge: Simulation.ReactionChallenge.SkipClosure);
            Assert.Throws<InvalidOperationException>(() => failed.Step((1, new OfferGift(P(3), 1))));
            Assert.AreEqual(0L, failed.Sim.HouseholdSnapshot.Cycle); Assert.IsEmpty(failed.Sim.HouseholdSnapshot.Households);
        });
        yield return new("IterationLocalityObserverAndIrrelevantAttributes", ["085", "087", "088", "094"], () =>
        {
            string? expected = null;
            foreach (string variant in new[] { "base", "reverse", "unrelated", "observe", "names" })
            {
                InitialWorld w = World(variant == "unrelated" ? 8 : 6, reverse: variant == "reverse");
                if (variant == "unrelated")
                    w = WithKnowledge(w with
                    {
                        Kinships = [.. w.Kinships.Where(k => k.First.Value <= 6 && k.Second.Value <= 6)],
                        Residences = [.. w.Residences.Select(r => r.Person.Value > 6 ? r with { Dwelling = new(2) } : r)]
                    });
                if (variant == "names") w = w with { People = [.. w.People.Select(p => p with { Name = "Irrelevant " + p.Id.Value })] };
                Lab lab = Form(w); HouseholdId h = H(lab);
                PrepareEntry(lab, h); SoleBearer(lab, h);
                if (variant == "observe")
                    for (int i = 0; i < 20; i++)
                    {
                        _ = lab.Sim.HouseholdSnapshot.Participants(h); _ = lab.Sim.HouseholdSnapshot.AncestorOf(h, h);
                        _ = lab.Sim.HouseholdSnapshot.MobilizableCapacity(h, lab.Sim.Snapshot); _ = lab.Sim.EpistemicStateOf(P(4)); _ = lab.Sim.History;
                    }
                lab.Step((1, new EndHouseholdParticipation(h)), (4, new RequestHouseholdParticipation(h, P(1))));
                string actual = JsonSerializer.Serialize(new
                {
                    Lifecycle = lab.Sim.HouseholdSnapshot.Households[h].Lifecycle,
                    Participants = lab.Sim.HouseholdSnapshot.Participants(h).Select(a => a.Person.Value),
                    Formation = lab.Sim.HouseholdSnapshot.Formations.Values.Select(f => new { f.Candidate, f.Founders, f.Stamp.Time.Cycle }),
                    Continuations = lab.Sim.HouseholdSnapshot.Continuations.Values.Select(c => new { c.Bridges, c.Stamp.Time.Cycle }),
                    People = lab.Sim.Snapshot.People.Values.Where(p => p.Id.Value <= 6).OrderBy(p => p.Id.Value).Select(p => new { p.Id, p.Grain, p.NeedsGrain }),
                    Recognition = lab.Sim.EpistemicSnapshot.Actors.Where(a => a.Key.Value <= 6).OrderBy(a => a.Key.Value).Select(a => new { a.Key, State = a.Value.HouseholdRecognitionOf(h) })
                });
                if (expected is null) expected = actual; else Assert.AreEqual(expected, actual, variant);
            }
        });
        yield return new("IsomorphicSemanticIdentityRenaming", ["086"], () =>
        {
            string? expected = null;
            foreach (int offset in new[] { 0, 100 })
            {
                InitialWorld w = World(3, grain: 12);
                PersonId Rename(PersonId p) => new(p.Value + offset);
                w = WithKnowledge(w with
                {
                    People = [.. w.People.Select(p => p with { Id = Rename(p.Id) })],
                    Residences = [.. w.Residences.Select(r => r with { Person = Rename(r.Person), Id = new(r.Id.Value + offset) })],
                    Kinships = [.. w.Kinships.Select(k => k with { First = Rename(k.First), Second = Rename(k.Second), Id = new(k.Id.Value + offset) })],
                    Candidates = [new(new(1 + offset), [.. w.Candidates[0].Core.Select(Rename)])]
                });
                Lab lab = Create(w);
                lab.Step((1 + offset, new OfferGift(P(3 + offset), 1)));
                lab.Step((3 + offset, new OfferGift(P(2 + offset), 1)));
                lab.SendSupport(3 + offset, 1 + offset, 2); lab.SendSupport(3 + offset, 2 + offset, 1);
                FormationWarrant f = lab.Sim.HouseholdSnapshot.Formations.Values.Single();
                string actual = JsonSerializer.Serialize(new
                {
                    Founders = f.Founders.Select(p => p.Value - offset),
                    f.Stamp.Time,
                    Support = f.Supports.Select(s => new { A = s.First.Value - offset, B = s.Second.Value - offset, s.Kind, s.Cycle }),
                    Recognized = lab.Sim.EpistemicSnapshot.Actors.OrderBy(a => a.Key.Value).Select(a => a.Value.HouseholdRecognitionOf(f.Household))
                });
                if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
            }
        });
    }
}
