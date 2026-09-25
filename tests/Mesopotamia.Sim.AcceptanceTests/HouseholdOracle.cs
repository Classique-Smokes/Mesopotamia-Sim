using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

/// <summary>Independent warrant/history checker. No production classifiers or transition helpers.</summary>
internal static partial class HouseholdOracle
{
    internal static void Verify(InitialWorld initial, Simulation simulation, IReadOnlyList<CycleResult> cycles, HouseholdSnapshot? evidence = null,
        IReadOnlyList<CandidateReferent>? declarations = null)
    {
        HouseholdSnapshot h = evidence ?? simulation.HouseholdSnapshot;
        SemanticEvent[] history = [.. simulation.History];
        Assert.AreEqual(simulation.Snapshot.Cycle, h.Cycle);
        Assert.AreEqual(history.Length, history.Select(e => e.Id).Distinct().Count());
        Assert.AreEqual(history.Count(e => e.Kind == "HouseholdFormation"), h.Formations.Count);
        Assert.AreEqual(history.Count(e => e.Kind == "HouseholdContinued"), h.Continuations.Count);
        Assert.AreEqual(history.Count(e => e.Kind == "HouseholdLineage"), h.Lineages.Count);
        VerifyAcquisitionReceipts(h, history, cycles);
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
            VerifyFormation(initial, h, f, history, cycles, declarations ?? []);
        }
        foreach (ParticipationWarrant e in h.Entries.Values)
            VerifyParticipation(initial, h, e, history, cycles);
        foreach (ParticipationEndWarrant e in h.Exits.Values)
        {
            SustainingParticipant association = h.Associations[e.Association];
            Assert.AreEqual(e.Id, association.End);
            Assert.AreEqual(e.Person, association.Person);
            Assert.AreEqual(e.Household, association.Household);
            SemanticEvent ended = VerifyStamp(initial, e.Stamp, "HouseholdParticipationEnded", history);
            Assert.AreEqual($"Household:{e.Household.Value};Warrant:{e.Id.Value};Association:{e.Association.Value}", ended.Detail);
            CollectionAssert.AreEqual(new[] { e.Person }, ended.Participants.ToArray());
            Assert.AreEqual(e.Proposal, ended.Proposal);
            Assert.AreEqual(new EndHouseholdParticipation(e.Household), ended.Action);
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
                    previous = continuation.Id;
                }
                else Assert.IsNull(continuation);
            }
            Assert.IsTrue(live.SetEquals(h.Associations.Values.Where(a => a.Household == household.Id && a.End is null).Select(a => a.Id)));
            Assert.AreEqual(live.Count switch { 0 => HouseholdLifecycle.Dissolved, 1 => HouseholdLifecycle.Inactive, _ => HouseholdLifecycle.Active }, household.Lifecycle);
            VerifyLifecycle(initial, h, household, history);
            if (household.Lifecycle == HouseholdLifecycle.Dissolved)
                Assert.IsTrue(h.Commitments.Values.Where(c => c.Household == household.Id).All(c => c.TerminatedBy is not null));
        }
        foreach (ContinuationWarrant continuation in h.Continuations.Values)
            VerifyContinuation(initial, h, continuation, history, cycles);
        foreach (LineageWarrant l in h.Lineages.Values)
        {
            VerifyLineage(initial, h, l, history);
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
            // Historical Slice-3 producer contexts retain their exact fixture restriction.
            Assert.IsInstanceOfType<ProvisionFixtureProvenance>(commitment.Provenance);
            Assert.IsFalse(string.IsNullOrWhiteSpace(((ProvisionFixtureProvenance)commitment.Provenance).Fixture));
            Assert.AreEqual(commitment.Person, h.Associations[commitment.Association].Person);
            if (h.Associations[commitment.Association].End is not null) Assert.IsNotNull(commitment.TerminatedBy);
        }
    }
    private static SemanticEvent Referenced(SemanticEvent[] history, EventId id)
    {
        SemanticEvent? result = history.SingleOrDefault(e => e.Id == id);
        Assert.IsNotNull(result, $"Nonexistent event {id.Value}.");
        return result;
    }

    private static void VerifyParticipation(InitialWorld initial, HouseholdSnapshot h, ParticipationWarrant entry,
        SemanticEvent[] history, IReadOnlyList<CycleResult> cycles)
    {
        SemanticEvent commit = Referenced(history, entry.Stamp.Event);
        Assert.AreEqual("HouseholdParticipation", commit.Kind);
        Assert.AreEqual(new EvidenceOrder(commit.Cycle, commit.ReactionIndex), entry.Stamp.Time);
        Assert.AreEqual(entry.Proposal, commit.Proposal);
        Assert.AreEqual($"Household:{entry.Household.Value};Warrant:{entry.Id.Value}", commit.Detail);
        CollectionAssert.AreEqual(new[] { entry.Newcomer, entry.Bridge }, commit.Participants.ToArray());
        Assert.AreEqual("SFL-S3-v1", entry.Stamp.RulesVersion);
        Assert.AreEqual(entry.Stamp.RulesVersion, commit.RulesVersion);
        Assert.AreEqual(initial.Configuration.Version, entry.Stamp.ConfigurationVersion);
        Assert.AreEqual(initial.Configuration.Version, commit.ConfigurationVersion);

        SemanticEvent? proposal = history.SingleOrDefault(e => e.Kind == "Proposal" && e.Proposal == entry.Proposal);
        Assert.IsNotNull(proposal, "Entry must reference an actual proposal.");
        Assert.AreEqual(1, proposal.Participants.Length);
        Assert.AreEqual(proposal.Action, commit.Action);
        PersonId counterpart;
        if (proposal.Action is RequestHouseholdParticipation request)
        {
            Assert.AreEqual(entry.Household, request.Household);
            Assert.AreEqual(entry.Newcomer, proposal.Participants[0]);
            Assert.AreEqual(entry.Bridge, request.Bridge);
            counterpart = entry.Bridge;
        }
        else
        {
            Assert.IsInstanceOfType<InviteHouseholdParticipation>(proposal.Action);
            InviteHouseholdParticipation invite = (InviteHouseholdParticipation)proposal.Action;
            Assert.AreEqual(entry.Household, invite.Household);
            Assert.AreEqual(entry.Bridge, proposal.Participants[0]);
            Assert.AreEqual(entry.Newcomer, invite.Newcomer);
            counterpart = entry.Newcomer;
        }
        SemanticEvent acceptance = Referenced(history, entry.Acceptance);
        Assert.AreEqual("Response", acceptance.Kind);
        Assert.AreEqual("Accept", acceptance.Detail);
        Assert.AreEqual(entry.Proposal, acceptance.Proposal);
        CollectionAssert.AreEqual(new[] { counterpart }, acceptance.Participants.ToArray());
        CollectionAssert.AreEqual(new[] { proposal.Id }, acceptance.Causes.ToArray());
        Assert.Contains(acceptance.Id, commit.Causes);
        Assert.IsTrue(Before(new(proposal.Cycle, proposal.ReactionIndex), acceptance));
        Assert.IsTrue(Before(new(acceptance.Cycle, acceptance.ReactionIndex), commit));
        Assert.AreEqual(commit.RulesVersion, proposal.RulesVersion);
        Assert.AreEqual(commit.RulesVersion, acceptance.RulesVersion);

        FormationWarrant formation = h.Formations[h.Households[entry.Household].Formation];
        EvidenceOrder Origin(SustainingParticipant a) => h.Formations.TryGetValue(a.Origin, out FormationWarrant? f)
            ? f.Stamp.Time : h.Entries[a.Origin].Stamp.Time;
        SustainingParticipant[] prior = [.. h.Associations.Values.Where(a => a.Household == entry.Household &&
            Origin(a).CompareTo(entry.Stamp.Time) < 0 && (a.End is null || h.Exits[a.End.Value].Stamp.Time.CompareTo(entry.Stamp.Time) >= 0))];
        CollectionAssert.AreEquivalent(prior.Select(a => a.Id).ToArray(), entry.Prior.ToArray());
        HashSet<PersonId> people = [.. prior.Select(a => a.Person)];
        Assert.Contains(entry.Bridge, people);
        Assert.DoesNotContain(entry.Newcomer, people);
        Assert.IsTrue(formation.Stamp.Time.CompareTo(entry.Stamp.Time) < 0);

        Assert.IsNotEmpty(entry.Supports);
        Assert.AreEqual(entry.Supports.Length, entry.Supports.Select(s => s.Event).Distinct().Count());
        foreach (SupportFact support in entry.Supports)
        {
            SemanticEvent real = Referenced(history, support.Event);
            SupportKind? kind = real.Kind switch
            {
                "Gift" => SupportKind.Gift,
                "Help" or "RelationshipMediatedReciprocalHelp" => SupportKind.Help,
                "Loan" => SupportKind.Loan,
                "CalledFavourFulfilled" => SupportKind.FavourFulfilment,
                _ => null
            };
            Assert.IsNotNull(kind, "Only ordinary committed person-person support qualifies.");
            Assert.AreEqual(kind.Value, support.Kind);
            Assert.AreEqual(real.Cycle, support.Cycle);
            Assert.AreEqual(new EvidenceOrder(real.Cycle, real.ReactionIndex), support.Order);
            CollectionAssert.AreEqual(new[] { support.First, support.Second }, real.Participants.ToArray());
            Assert.IsTrue(support.First == entry.Newcomer && people.Contains(support.Second) ||
                support.Second == entry.Newcomer && people.Contains(support.First));
            Assert.IsTrue(Before(formation.Stamp.Time, real));
            Assert.IsTrue(new EvidenceOrder(real.Cycle, real.ReactionIndex).CompareTo(entry.Stamp.Time) < 0);
            Assert.Contains(real.Id, commit.Causes);
        }

        // Start at the preceding stable boundary; replay only earlier microsteps in this cycle.
        // A later move/marriage/decay must never certify an earlier admission.
        WorldSnapshot world = PrecommitWorld(initial, cycles, history, entry.Stamp.Time);
        Residence[] residences = [.. world.Residences.Values.Where(r => r.Person == entry.Newcomer || people.Contains(r.Person))];
        CollectionAssert.AreEquivalent(residences, entry.Residences.ToArray());
        DwellingId home = residences.Single(r => r.Person == entry.Newcomer).Dwelling;
        Assert.IsTrue(residences.Any(r => people.Contains(r.Person) && r.Dwelling == home));
        Assert.IsNotEmpty(entry.Ties);
        foreach (DurableTieEvidence tie in entry.Ties)
        {
            Assert.AreNotEqual(tie.First, tie.Second);
            Assert.IsTrue((people.Contains(tie.First) || tie.First == entry.Newcomer) &&
                (people.Contains(tie.Second) || tie.Second == entry.Newcomer));
            RelationId[] expected = [.. world.Kinships.Values.Where(k => Pair(k.First, k.Second, tie.First, tie.Second)).Select(k => k.Id),
                .. world.Marriages.Values.Where(m => Pair(m.Groom, m.Bride, tie.First, tie.Second)).Select(m => m.Id),
                .. world.AttitudeOf(tie.First, tie.Second) >= 75 && world.AttitudeOf(tie.Second, tie.First) >= 75
                    ? world.Attitudes.Values.Where(a => Pair(a.From, a.To, tie.First, tie.Second)).Select(a => a.Id) : []];
            Assert.IsNotEmpty(expected);
            CollectionAssert.AreEquivalent(expected, tie.Relations.ToArray());
        }
        Assert.IsTrue(entry.Ties.Any(t => t.First == entry.Newcomer || t.Second == entry.Newcomer));
        Assert.AreEqual(2, entry.Recognition.Length, "Both newcomer and bridge evidence are mandatory.");
        VerifyRecognition(entry.Recognition[0], entry.Newcomer, entry.Household, entry.Stamp, h, history, cycles);
        VerifyRecognition(entry.Recognition[1], entry.Bridge, entry.Household, entry.Stamp, h, history, cycles);

        SustainingParticipant[] added = [.. h.Associations.Values.Where(a => a.Origin == entry.Id)];
        Assert.AreEqual(1, added.Length);
        Assert.AreEqual(entry.Newcomer, added[0].Person);
        Assert.AreEqual(entry.Household, added[0].Household);
        ContinuationWarrant[] continued = [.. h.Continuations.Values.Where(c => c.Transition == entry.Id)];
        Assert.AreEqual(1, continued.Length);
        ContinuationWarrant continuation = continued[0];
        Assert.AreEqual(entry.Household, continuation.Household);
        CollectionAssert.AreEquivalent(entry.Prior.ToArray(), continuation.Prior.ToArray());
        CollectionAssert.AreEquivalent(entry.Prior.Append(added[0].Id).ToArray(), continuation.Successor.ToArray());
        Assert.Contains(entry.Bridge, continuation.Bridges);
        SemanticEvent continuedEvent = Referenced(history, continuation.Stamp.Event);
        Assert.AreEqual("HouseholdContinued", continuedEvent.Kind);
        Assert.Contains(commit.Id, continuedEvent.Causes);
        Assert.IsTrue(Before(entry.Stamp.Time, continuedEvent));
    }

    private static WorldSnapshot PrecommitWorld(InitialWorld initial, IReadOnlyList<CycleResult> cycles, SemanticEvent[] history, EvidenceOrder time)
    {
        WorldSnapshot world = cycles.SingleOrDefault(c => c.State.Cycle == time.Cycle - 1)?.State ??
            new(0, initial.People.ToImmutableDictionary(p => p.Id), initial.Dwellings.ToImmutableDictionary(d => d.Id),
                initial.Residences.ToImmutableDictionary(r => r.Id), initial.Attitudes.ToImmutableDictionary(a => a.Id),
                initial.Kinships.ToImmutableDictionary(k => k.Id), initial.Marriages.ToImmutableDictionary(m => m.Id),
                ImmutableDictionary<RelationId, Debt>.Empty, ImmutableDictionary<RelationId, Favour>.Empty);
        WorldSnapshot closed = cycles.Single(c => c.State.Cycle == time.Cycle).State;
        foreach (SemanticEvent e in history.Where(e => e.Cycle == time.Cycle && e.ReactionIndex < time.ReactionIndex))
        {
            if (e.Kind == "ResidenceTransition")
            {
                PersonId mover = e.Action is InviteResidence invite ? invite.Target : e.Participants[0];
                DwellingId destination = e.Action is MoveResidence move ? move.Destination : ((InviteResidence)e.Action!).Destination;
                Residence old = world.Residences.Values.Single(r => r.Person == mover);
                world = world with { Residences = world.Residences.SetItem(old.Id, old with { Dwelling = destination }) };
            }
            if (e.Kind == "DirectMarriage")
            {
                Marriage marriage = closed.Marriages.Values.Single(m => m.Origin == e.Id);
                Assert.IsTrue(Pair(marriage.Groom, marriage.Bride, e.Participants[0], e.Participants[1]));
                world = world with { Marriages = world.Marriages.Add(marriage.Id, marriage) };
            }
            if (e.Kind is "AttitudeDecay" or "AttitudeComposition")
            {
                Attitude identity = closed.Attitudes.Values.Single(a => a.From == e.Participants[0] && a.To == e.Participants[1]);
                int before = world.AttitudeOf(identity.From, identity.To);
                int after = e.Kind == "AttitudeDecay" ? before > 0 ? Math.Max(0, before - 2) : Math.Min(0, before + 1) :
                    (int)Math.Clamp(before + e.Contributions.Sum(c => (long)c.Delta), -100, 100);
                world = world with { Attitudes = world.Attitudes.SetItem(identity.Id, identity with { Value = after }) };
            }
        }
        return world;
    }

    private static bool SameEvidence(KnownFact a, KnownFact b) => a.Id == b.Id && SameEvidenceContent(a, b);

    private static bool SameEvidenceContent(KnownFact a, KnownFact b) => a.Proposition == b.Proposition &&
        a.Provenance.Route == b.Provenance.Route && a.Provenance.Origin == b.Provenance.Origin &&
        a.Provenance.Hops.SequenceEqual(b.Provenance.Hops);

    private static void VerifyRecognition(HouseholdRecognition recognition, PersonId actor, HouseholdId household, WarrantStamp stamp,
        HouseholdSnapshot h, SemanticEvent[] history, IReadOnlyList<CycleResult> cycles)
    {
        Assert.AreEqual(household, recognition.Household);
        Assert.AreEqual(RecognitionStatus.Recognized, recognition.Status);
        Assert.IsNotEmpty(recognition.Evidence);
        List<KnownFact> held = [.. cycles.Single(c => c.State.Cycle == stamp.Time.Cycle - 1).Epistemic!.Actors[actor].Facts
            .Where(f => f.Proposition is HouseholdExistenceFact fact && fact.Household == household)];
        HashSet<EvidenceId> consumedReceipts = [];
        foreach (SemanticEvent e in history.Where(e => e.Cycle == stamp.Time.Cycle && e.ReactionIndex < stamp.Time.ReactionIndex))
        {
            if (e.Kind == "Communication" && e.Participants[1] == actor)
                foreach (KnownFact sent in e.TransmittedEvidence.Where(f => f.Proposition is HouseholdExistenceFact fact && fact.Household == household &&
                    !e.TransmittedEvidence.Any(other => other.Proposition is HouseholdExistenceFact newer && newer.Household == household &&
                        other.Provenance.Origin.Event is not null && other.Provenance.Origin.Order is { } x && f.Provenance.Origin.Order is { } y && x.CompareTo(y) > 0)))
                    Acquire(new(new(0), sent.Proposition, new(AcquisitionRoute.Communication, sent.Provenance.Origin,
                        [.. sent.Provenance.Hops, new(e.Participants[0], actor, e.Id, new(e.Cycle, e.ReactionIndex))])), e);
            if (e.Kind is "HouseholdRecognitionAcquired" or "HouseholdDissolutionEvidenceAcquired" && e.Participants.Contains(actor))
            {
                SemanticEvent origin = Referenced(history, e.Causes.Single());
                WarrantId? warrant = h.Formations.Values.SingleOrDefault(f => f.Household == household && f.Stamp.Event == origin.Id)?.Id ??
                    h.Continuations.Values.SingleOrDefault(c => c.Household == household && c.Stamp.Event == origin.Id)?.Id;
                if (warrant is { } id)
                    Acquire(new(new(0), new HouseholdExistenceFact(household, true, id),
                        new(AcquisitionRoute.Participation, new(actor, origin.Id, new(origin.Cycle, origin.ReactionIndex)), [])), e);
            }
        }
        Assert.IsNotEmpty(held);
        Assert.IsTrue(held.All(f => f.Proposition is HouseholdExistenceFact { Continues: true }));
        Assert.AreEqual(held.Count, recognition.Evidence.Length);
        foreach (KnownFact fact in recognition.Evidence)
        {
            int index = held.FindIndex(f => SameEvidence(f, fact));
            Assert.IsTrue(index >= 0, "Warrant Recognition must be the named actor's actual precommit basis.");
            held.RemoveAt(index);
            VerifyProvenance(fact, actor, stamp.Time, h, history);
        }

        void Acquire(KnownFact incoming, SemanticEvent acquisition)
        {
            bool Newer(KnownFact a, KnownFact b) => a.Provenance.Origin.Order is { } x && b.Provenance.Origin.Order is { } y && x.CompareTo(y) > 0 &&
                (a.Provenance.Route == AcquisitionRoute.Participation || a.Provenance.Route == AcquisitionRoute.Communication &&
                    a.Provenance.Origin.Event is not null && b.Provenance.Route is AcquisitionRoute.Communication or AcquisitionRoute.Fixture);
            if (held.Any(f => Newer(f, incoming))) return;
            // Reconstruct content/provenance first, then bind its exact identity to
            // the observer receipt from that acquisition, never another warrant.
            AcquiredFact[] receipts = [.. acquisition.AcquiredEvidence.Where(r => r.Actor == actor &&
                !consumedReceipts.Contains(r.Fact.Id) && SameEvidenceContent(r.Fact, incoming)).OrderBy(r => r.Fact.Id.Value)];
            Assert.IsNotEmpty(receipts, "Acquisition must identify the exact resulting actor-held fact.");
            incoming = receipts[0].Fact;
            consumedReceipts.Add(incoming.Id);
            Assert.IsGreaterThan(0L, incoming.Id.Value);
            Assert.IsFalse(held.Any(f => f.Id == incoming.Id), "New acquisition cannot reuse a retained EvidenceId.");
            held.RemoveAll(f => Newer(incoming, f));
            held.Add(incoming);
        }
    }

    private static void VerifyProvenance(KnownFact fact, PersonId actor, EvidenceOrder before, HouseholdSnapshot h, SemanticEvent[] history)
    {
        Assert.IsInstanceOfType<HouseholdExistenceFact>(fact.Proposition);
        HouseholdExistenceFact proposition = (HouseholdExistenceFact)fact.Proposition;
        Assert.IsTrue(proposition.Continues);
        EvidenceOrigin origin = fact.Provenance.Origin;
        Assert.IsNotNull(origin.Event, "Participation recognition must reference actual household evidence.");
        SemanticEvent source = Referenced(history, origin.Event.Value);
        Assert.IsNotNull(origin.Order);
        Assert.AreEqual(new EvidenceOrder(source.Cycle, source.ReactionIndex), origin.Order);
        Assert.IsTrue(origin.Order.CompareTo(before) < 0);
        Assert.IsNotNull(origin.Source);
        Assert.Contains(origin.Source.Value, source.Participants);
        WarrantStamp stamp;
        if (h.Formations.TryGetValue(proposition.Warrant, out FormationWarrant? formation))
        {
            Assert.AreEqual(proposition.Household, formation.Household);
            Assert.AreEqual("HouseholdFormation", source.Kind);
            stamp = formation.Stamp;
        }
        else
        {
            Assert.IsTrue(h.Continuations.TryGetValue(proposition.Warrant, out ContinuationWarrant? continuation));
            Assert.IsNotNull(continuation);
            Assert.AreEqual(proposition.Household, continuation.Household);
            Assert.AreEqual("HouseholdContinued", source.Kind);
            stamp = continuation.Stamp;
        }
        Assert.AreEqual(stamp.Event, source.Id);
        PersonId holder = origin.Source.Value;
        EvidenceOrder previous = origin.Order;
        List<CommunicationHop> prefix = [];
        foreach (CommunicationHop hop in fact.Provenance.Hops)
        {
            SemanticEvent delivery = Referenced(history, hop.Event);
            Assert.AreEqual("Communication", delivery.Kind);
            Assert.AreEqual(holder, hop.Sender);
            CollectionAssert.AreEqual(new[] { hop.Sender, hop.Recipient }, delivery.Participants.ToArray());
            Assert.AreEqual(new EvidenceOrder(delivery.Cycle, delivery.ReactionIndex), hop.Delivered);
            Assert.IsTrue(previous.CompareTo(hop.Delivered) < 0 && hop.Delivered.CompareTo(before) < 0);
            Assert.IsTrue(delivery.TransmittedEvidence.Any(f => f.Proposition == proposition && f.Provenance.Origin == origin &&
                f.Provenance.Hops.SequenceEqual(prefix)), "Communication must actually carry the cited evidence.");
            prefix.Add(hop); holder = hop.Recipient; previous = hop.Delivered;
        }
        Assert.AreEqual(actor, holder);
        Assert.AreEqual(prefix.Count == 0 ? AcquisitionRoute.Participation : AcquisitionRoute.Communication, fact.Provenance.Route);
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
