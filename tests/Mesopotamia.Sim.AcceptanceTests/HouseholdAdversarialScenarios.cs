using System.Collections.Immutable;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    private IEnumerable<HouseholdCase> AdversarialCases()
    {
        yield return new("ImmediateRevalidationAndDisclosedTechnicalConflict", ["020", "024", "090", "092"], () =>
        {
            foreach (bool moveFirst in new[] { false, true })
            {
                InitialWorld w = World();
                w = WithKnowledge(w with { Residences = [.. w.Residences.Select(r => r.Person == P(6) ? r with { Dwelling = new(2) } : r)] });
                Lab lab = Form(w); HouseholdId h = H(lab); PrepareEntry(lab, h);
                var move = (6, (ActionTerms)new InviteResidence(P(4), new(2)));
                var entry = (4, (ActionTerms)new RequestHouseholdParticipation(h, P(1)));
                CycleResult result = lab.Step(moveFirst ? [move, entry] : [entry, move]);
                Outcome admission = result.Outcomes.Single(o => o.Actor == P(4));
                Assert.AreEqual(moveFirst ? OutcomeKind.InvalidatedAtResolution : OutcomeKind.Committed, admission.Kind);
                Assert.AreEqual(moveFirst ? 0 : 1, lab.Sim.HouseholdSnapshot.Entries.Count);
                Assert.IsTrue(result.Outcomes.All(o => result.Events.Single(e => e.Id == o.Event).TechnicalFallback));
                Assert.IsTrue(result.Decisions.Where(d => d.Context == "Response").All(d => d.RulesVersion == "SFL-S3-v1"));
            }
        });
        yield return new("DisconnectedHouseholdDoesNotChangeContinuity", ["087", "088", "085"], () =>
        {
            string? expected = null;
            foreach (bool unrelated in new[] { false, true })
            {
                InitialWorld w = World(8);
                w = WithKnowledge(w with
                {
                    Kinships = [.. w.Kinships.Where(k => k.First.Value <= 6 && k.Second.Value <= 6), new(new(999), P(7), P(8), KinshipKind.Sibling)],
                    Residences = [.. w.Residences.Select(r => r.Person.Value > 6 ? r with { Dwelling = new(2) } : r)]
                });
                Lab lab = Create(w);
                if (unrelated) lab.Declare(2, [7, 8]);
                lab.Step(unrelated ? [(1, new OfferGift(P(3), 1)), (7, new OfferGift(P(8), 1))] : [(1, new OfferGift(P(3), 1))]);
                lab.Step(unrelated ? [(3, new OfferGift(P(2), 1)), (8, new OfferGift(P(7), 1))] : [(3, new OfferGift(P(2), 1))]);
                lab.SendSupport(3, 1, 2); lab.SendSupport(3, 2, 1);
                HouseholdId h = H(lab); PrepareEntry(lab, h); SoleBearer(lab, h);
                lab.Step((1, new EndHouseholdParticipation(h)), (4, new RequestHouseholdParticipation(h, P(1))));
                string actual = JsonSerializer.Serialize(new
                {
                    Participants = lab.Sim.HouseholdSnapshot.Participants(h).Select(a => a.Person),
                    lab.Sim.HouseholdSnapshot.Households[h].Lifecycle,
                    Continuation = lab.Sim.HouseholdSnapshot.Continuations.Values.Where(c => c.Household == h).Select(c => new { c.Bridges, c.Stamp.Time.Cycle }),
                    People = lab.Sim.Snapshot.People.Values.Where(p => p.Id.Value <= 6).OrderBy(p => p.Id.Value).Select(p => new { p.Id, p.Grain }),
                    Recognitions = lab.Sim.EpistemicSnapshot.Actors.Where(a => a.Key.Value <= 6).OrderBy(a => a.Key.Value).Select(a => a.Value.HouseholdRecognitionOf(h))
                });
                if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
            }
        });
        yield return new("RenamedTurnoverAndLineageTrajectories", ["086", "094", "081"], () =>
        {
            string? expected = null;
            foreach (int offset in new[] { 0, 100 })
            {
                InitialWorld w = LineageWorld(6);
                int Map(int person) => offset == 0 ? person : 107 - person;
                long Normalize(long person) => offset == 0 ? person : 107 - person;
                PersonId Rename(PersonId p) => new(Map((int)p.Value));
                w = WithKnowledge(w with
                {
                    People = [.. w.People.Select(p => p with { Id = Rename(p.Id), Name = offset == 0 ? p.Name : "IrrelevantName" })],
                    Residences = [.. w.Residences.Select(r => r with { Person = Rename(r.Person), Id = new(r.Id.Value + offset) })],
                    Kinships = [.. w.Kinships.Select(k => k with { First = Rename(k.First), Second = Rename(k.Second), Id = new(k.Id.Value + offset) })]
                });
                Lab lab = Create(w, Simulation.ReactionChallenge.DuplicateCauses);
                HouseholdId h = FormGroup(lab, 10 + offset, [Map(1), Map(2), Map(3)]);
                PrepareEntry(lab, h, Map(4), Map(1));
                Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, false, Map(4), Map(1)));
                Exit(lab, h, Map(1)); Exit(lab, h, Map(2));
                HouseholdId descendant = FormGroup(lab, 20 + offset, [Map(1), Map(2)]);
                LineageWarrant lineage = lab.Sim.HouseholdSnapshot.Lineages.Values.Single(l => l.Successor == descendant);
                string actual = JsonSerializer.Serialize(new
                {
                    lifecycle = lab.Sim.HouseholdSnapshot.Households[h].Lifecycle,
                    Participants = lab.Sim.HouseholdSnapshot.Participants(h).Select(a => Normalize(a.Person.Value)).Order(),
                    lineage.Kind,
                    Sources = lineage.Sources.Select(s => Normalize(s.Founder.Value)).Order(),
                    PredecessorCandidates = lineage.Predecessors.Select(p => lab.Sim.HouseholdSnapshot.Formations[lab.Sim.HouseholdSnapshot.Households[p].Formation].Candidate.Value - offset),
                    Recognition = lab.Sim.EpistemicSnapshot.Actors.OrderBy(a => Normalize(a.Key.Value)).Select(a => new { Existing = a.Value.HouseholdRecognitionOf(h), Descendant = a.Value.HouseholdRecognitionOf(descendant) }),
                    Counts = new[] { lab.Sim.HouseholdSnapshot.Formations.Count, lab.Sim.HouseholdSnapshot.Entries.Count, lab.Sim.HouseholdSnapshot.Continuations.Count, lab.Sim.HouseholdSnapshot.Lineages.Count }
                });
                if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
            }
        });
        yield return new("IndependentOracleRejectsCorruptedWitness", ["010", "030"], () =>
        {
            // Oracle adequacy: mutate only detached public evidence, never production state.
            Lab lab = Form(); HouseholdId h = H(lab); PrepareEntry(lab, h); Entry(lab, h, false);
            FormationWarrant f = lab.Sim.HouseholdSnapshot.Formations.Values.Single();
            Assert.IsTrue(f.Supports.Select(s => s.Cycle).Distinct().Count() >= 2);
            var bad = f with { Supports = [f.Supports[0]] };
            HouseholdSnapshot badFormation = lab.Sim.HouseholdSnapshot with { Formations = lab.Sim.HouseholdSnapshot.Formations.SetItem(bad.Id, bad) };
            Assert.Throws<AssertFailedException>(() => HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, badFormation));
            ContinuationWarrant c = lab.Sim.HouseholdSnapshot.Continuations.Values.Single();
            var broken = c with { Bridges = [] };
            HouseholdSnapshot badContinuation = lab.Sim.HouseholdSnapshot with { Continuations = lab.Sim.HouseholdSnapshot.Continuations.SetItem(broken.Id, broken) };
            Assert.Throws<AssertFailedException>(() => HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, badContinuation));
        });
    }
}
