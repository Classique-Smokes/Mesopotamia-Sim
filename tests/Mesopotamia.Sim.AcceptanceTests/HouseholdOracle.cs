using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

/// <summary>Independent warrant/history checker. No production classifiers or transition helpers.</summary>
internal static class HouseholdOracle
{
    internal static void Verify(InitialWorld initial, Simulation simulation, IReadOnlyList<CycleResult> cycles, HouseholdSnapshot? evidence = null)
    {
        HouseholdSnapshot h = evidence ?? simulation.HouseholdSnapshot;
        SemanticEvent[] history = [.. simulation.History];
        Assert.AreEqual(simulation.Snapshot.Cycle, h.Cycle);
        Assert.AreEqual(history.Length, history.Select(e => e.Id).Distinct().Count());
        foreach (var cycle in history.GroupBy(e => e.Cycle))
        {
            int[] indices = cycle.Select(e => e.ReactionIndex).ToArray();
            Assert.IsTrue(indices.SequenceEqual(indices.Order()));
            Assert.AreEqual(indices.Length, indices.Distinct().Count());
        }
        foreach (SemanticEvent e in history)
            foreach (EventId cause in e.Causes)
            {
                SemanticEvent prior = history.Single(x => x.Id == cause);
                Assert.IsTrue(prior.Cycle < e.Cycle || prior.Cycle == e.Cycle && prior.ReactionIndex < e.ReactionIndex);
            }
        if (!simulation.IsFaulted)
        {
            Dictionary<PersonId, long> grain = initial.People.ToDictionary(p => p.Id, p => p.Grain);
            foreach (SemanticEvent e in history)
            {
                if (e.Kind.StartsWith("Household", StringComparison.Ordinal) || e.Kind.StartsWith("Sustaining", StringComparison.Ordinal))
                    Assert.IsEmpty(e.Material);
                foreach (MaterialChange change in e.Material)
                {
                    Assert.AreEqual(grain[change.Person], change.Before);
                    grain[change.Person] = change.After;
                }
            }
            Assert.IsTrue(grain.All(p => simulation.Snapshot.People[p.Key].Grain == p.Value));
        }
        foreach (FormationWarrant f in h.Formations.Values)
        {
            Assert.IsGreaterThanOrEqualTo(2, f.Founders.Length);
            Assert.AreEqual(f.Founders.Length, f.Founders.Distinct().Count());
            WorldSnapshot world = cycles.Single(c => c.State.Cycle == f.Stamp.Time.Cycle).State;
            Assert.IsTrue(f.Founders.All(p => world.Residences.Values.Single(r => r.Person == p).Dwelling == f.Dwelling));
            Assert.IsTrue(Connected(f.Founders, (a, b) => Tied(world, a, b)));
            Assert.IsGreaterThanOrEqualTo(2, f.Supports.Select(s => s.Cycle).Distinct().Count());
            foreach (SupportFact s in f.Supports)
            {
                SemanticEvent support = history.Single(e => e.Id == s.Event);
                Assert.Contains(support.Kind, new[] { "Gift", "Help", "RelationshipMediatedReciprocalHelp", "Loan", "CalledFavourFulfilled" });
                Assert.AreEqual(s.Cycle, support.Cycle);
                Assert.IsTrue(f.Founders.Contains(s.First) && f.Founders.Contains(s.Second));
                Assert.IsTrue(s.Cycle < f.Stamp.Time.Cycle || s.Cycle == f.Stamp.Time.Cycle && support.ReactionIndex < f.Stamp.Time.ReactionIndex);
            }
            Assert.AreEqual(f.Founders.Length, f.Recognition.Length);
            foreach (CandidateRecognition r in f.Recognition)
            {
                Assert.AreEqual(RecognitionStatus.Recognized, r.Status);
                Assert.IsTrue(CandidatePredicate(f.Founders, r.Evidence));
            }
            Assert.IsTrue(f.EarliestEvidence.CompareTo(f.Stamp.Time) < 0);
            Assert.AreEqual("SFL-S3-v1", f.Stamp.RulesVersion);
            Assert.AreEqual(initial.Configuration.Version, f.Stamp.ConfigurationVersion);
            Assert.AreEqual(f.Founders.Length, h.Associations.Values.Count(a => a.Origin == f.Id));
        }
        foreach (ParticipationWarrant e in h.Entries.Values)
        {
            FormationWarrant formation = h.Formations[h.Households[e.Household].Formation];
            Assert.IsTrue(e.Prior.Select(a => h.Associations[a]).Any(a => a.Person == e.Bridge));
            Assert.IsFalse(e.Prior.Select(a => h.Associations[a]).Any(a => a.Person == e.Newcomer));
            Assert.AreEqual("Response", history.Single(x => x.Id == e.Acceptance).Kind);
            Assert.AreEqual("Accept", history.Single(x => x.Id == e.Acceptance).Detail);
            Assert.IsTrue(e.Recognition.All(r => r.Household == e.Household && r.Status == RecognitionStatus.Recognized));
            Assert.IsTrue(e.Supports.Any(s => s.Order!.CompareTo(formation.Stamp.Time) > 0 &&
                (s.First == e.Newcomer || s.Second == e.Newcomer)));
            Assert.IsTrue(e.Ties.Any(t => t.First == e.Newcomer || t.Second == e.Newcomer));
            DwellingId home = e.Residences.Single(r => r.Person == e.Newcomer).Dwelling;
            Assert.IsTrue(e.Residences.Any(r => r.Person != e.Newcomer && r.Dwelling == home));
            Assert.AreEqual(1, h.Associations.Values.Count(a => a.Origin == e.Id));
            Assert.AreEqual(1, h.Continuations.Values.Count(c => c.Transition == e.Id));
        }
        foreach (ParticipationEndWarrant e in h.Exits.Values)
        {
            SustainingParticipant association = h.Associations[e.Association];
            Assert.AreEqual(e.Id, association.End);
            Assert.AreEqual(e.Person, association.Person);
            Assert.AreEqual(e.Household, association.Household);
            Assert.AreEqual("HouseholdParticipationEnded", history.Single(x => x.Id == e.Stamp.Event).Kind);
        }
        foreach (Household household in h.Households.Values)
        {
            HashSet<AssociationId> live = [.. h.Associations.Values.Where(a => a.Household == household.Id && a.Origin == household.Formation).Select(a => a.Id)];
            WarrantId previous = household.Formation;
            foreach (var transition in h.Entries.Values.Where(e => e.Household == household.Id).Select(e => (e.Id, e.Stamp, Entry: true))
                .Concat(h.Exits.Values.Where(e => e.Household == household.Id).Select(e => (e.Id, e.Stamp, Entry: false))).OrderBy(e => e.Stamp.Time))
            {
                HashSet<AssociationId> prior = [.. live];
                if (transition.Entry) live.Add(h.Associations.Values.Single(a => a.Origin == transition.Id).Id);
                else live.Remove(h.Exits[transition.Id].Association);
                ContinuationWarrant? continuation = h.Continuations.Values.SingleOrDefault(c => c.Transition == transition.Id);
                if (live.Count > 0)
                {
                    Assert.IsNotNull(continuation);
                    Assert.AreEqual(previous, continuation.Previous);
                    Assert.IsTrue(prior.SetEquals(continuation.Prior));
                    Assert.IsTrue(live.SetEquals(continuation.Successor));
                    Assert.IsNotEmpty(continuation.Bridges);
                    Assert.IsTrue(continuation.Bridges.All(p => prior.Intersect(live).Any(a => h.Associations[a].Person == p)));
                    Assert.IsTrue(continuation.Recognition.All(r => r.Status == RecognitionStatus.Recognized));
                    previous = continuation.Id;
                }
                else Assert.IsNull(continuation);
            }
            Assert.IsTrue(live.SetEquals(h.Associations.Values.Where(a => a.Household == household.Id && a.End is null).Select(a => a.Id)));
            Assert.AreEqual(live.Count switch { 0 => HouseholdLifecycle.Dissolved, 1 => HouseholdLifecycle.Inactive, _ => HouseholdLifecycle.Active }, household.Lifecycle);
            if (household.Lifecycle == HouseholdLifecycle.Dissolved)
                Assert.IsTrue(h.Commitments.Values.Where(c => c.Household == household.Id).All(c => c.TerminatedBy is not null));
        }
        foreach (LineageWarrant l in h.Lineages.Values)
        {
            FormationWarrant f = h.Formations[l.Formation];
            HouseholdSnapshot atFormation = cycles.Single(c => c.State.Cycle == f.Stamp.Time.Cycle).Households!;
            Assert.AreEqual(l.Kind == HouseholdLineageKind.DivisionDescendant ? 1 : 2, l.Predecessors.Count);
            Assert.IsTrue(l.Predecessors.All(p => l.Kind == HouseholdLineageKind.DivisionDescendant
                ? atFormation.Households[p].Lifecycle != HouseholdLifecycle.Dissolved
                : atFormation.Households[p].Lifecycle == HouseholdLifecycle.Dissolved));
            Assert.AreEqual(1, h.Lineages.Values.Count(x => x.Formation == l.Formation));
            Assert.IsFalse(l.Predecessors.Contains(l.Successor));
            Assert.IsTrue(l.Sources.Select(s => s.Founder).ToHashSet().SetEquals(f.Founders));
            Assert.IsTrue(l.Sources.Select(s => s.Predecessor).ToHashSet().SetEquals(l.Predecessors));
            foreach (FounderLineageSource source in l.Sources)
            {
                ParticipationEndWarrant exit = h.Exits[source.ParticipationEnd];
                Assert.AreEqual(source.Founder, exit.Person); Assert.AreEqual(source.Predecessor, exit.Household);
                Assert.IsTrue(exit.Stamp.Time.CompareTo(f.Stamp.Time) < 0);
                Assert.IsTrue(h.Formations[h.Households[source.Predecessor].Formation].Stamp.Time.CompareTo(f.Stamp.Time) < 0);
            }
            Assert.IsNotEmpty(l.FreshEvidence);
            foreach (EventId fresh in l.FreshEvidence)
            {
                SemanticEvent support = history.Single(e => e.Id == fresh);
                if (l.Kind == HouseholdLineageKind.DivisionDescendant)
                    Assert.IsTrue(l.Sources.All(s => Before(h.Exits[s.ParticipationEnd].Stamp.Time, support)));
                else
                {
                    Assert.AreNotEqual(l.Sources.Single(s => s.Founder == support.Participants[0]).Predecessor,
                        l.Sources.Single(s => s.Founder == support.Participants[1]).Predecessor);
                    Assert.IsTrue(l.Predecessors.All(p => history.Any(e => e.Kind == "HouseholdLifecycle" && e.Detail == $"Household:{p.Value};Dissolved" &&
                        Before(new(e.Cycle, e.ReactionIndex), support))));
                }
            }
        }
        foreach (HouseholdProvisionCommitment commitment in h.Commitments.Values)
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(commitment.Provenance.Fixture));
            Assert.AreEqual(commitment.Person, h.Associations[commitment.Association].Person);
            if (h.Associations[commitment.Association].End is not null) Assert.IsNotNull(commitment.TerminatedBy);
        }
    }
    private static bool Before(EvidenceOrder order, SemanticEvent e) => order.Cycle < e.Cycle || order.Cycle == e.Cycle && order.ReactionIndex < e.ReactionIndex;
    internal static bool Tied(WorldSnapshot w, PersonId a, PersonId b) =>
        w.Kinships.Values.Any(k => Pair(k.First, k.Second, a, b)) || w.Marriages.Values.Any(m => Pair(m.Groom, m.Bride, a, b)) ||
        w.Attitudes.Values.Any(t => t.From == a && t.To == b && t.Value >= 75) && w.Attitudes.Values.Any(t => t.From == b && t.To == a && t.Value >= 75);
    private static bool Pair(PersonId a, PersonId b, PersonId x, PersonId y) => a == x && b == y || a == y && b == x;
    private static bool Connected(ImmutableArray<PersonId> people, Func<PersonId, PersonId, bool> tied)
    {
        HashSet<PersonId> seen = [people[0]];
        for (int pass = 0; pass < people.Length; pass++)
            foreach (PersonId p in people)
                if (people.Any(other => seen.Contains(other) && tied(other, p))) seen.Add(p);
        return people.All(seen.Contains);
    }
    private static bool CandidatePredicate(ImmutableArray<PersonId> core, ImmutableArray<KnownFact> facts)
    {
        FactualProposition[] f = [.. facts.Select(x => x.Proposition)];
        ResidenceFact[] residences = [.. f.OfType<ResidenceFact>()];
        return residences.Select(r => r.Dwelling).Distinct().Any(d => core.All(p => residences.Any(r => r.Person == p && r.Dwelling == d))) &&
            !residences.GroupBy(r => r.Person).Any(g => g.Select(r => r.Dwelling).Distinct().Count() > 1) &&
            f.OfType<SupportFact>().Select(s => s.Cycle).Distinct().Count() >= 2 &&
            Connected(core, (a, b) => f.OfType<KinshipFact>().Any(k => Pair(k.Kinship.First, k.Kinship.Second, a, b)) ||
                f.OfType<MarriageFact>().Any(m => Pair(m.Marriage.Groom, m.Marriage.Bride, a, b)) ||
                f.OfType<AttitudeFact>().Any(t => t.Attitude.From == a && t.Attitude.To == b && t.Attitude.Value >= 75) &&
                f.OfType<AttitudeFact>().Any(t => t.Attitude.From == b && t.Attitude.To == a && t.Attitude.Value >= 75));
    }
}
