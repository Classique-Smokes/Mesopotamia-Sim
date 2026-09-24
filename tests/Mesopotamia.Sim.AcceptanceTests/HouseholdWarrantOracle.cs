using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal static partial class HouseholdOracle
{
    private static void VerifyAcquisitionReceipts(HouseholdSnapshot h, SemanticEvent[] history, IReadOnlyList<CycleResult> cycles)
    {
        Dictionary<PersonId, List<KnownFact>> held = [];
        HashSet<EvidenceId> acquiredIds = [];
        foreach (CycleResult cycle in cycles)
        {
            // Controlled nondominated-report fixtures are explicitly marked and
            // are inputs to these laboratory scenarios, not endogenous receipts.
            foreach (ActorEpistemicState actor in cycle.Epistemic!.Actors.Values)
                foreach (KnownFact fixture in actor.Facts.Where(f => f.Proposition is HouseholdExistenceFact && f.Provenance.Route == AcquisitionRoute.Fixture))
                {
                    Assert.IsFalse(string.IsNullOrWhiteSpace(fixture.Provenance.Origin.Fixture));
                    if (!held.TryGetValue(actor.Actor, out List<KnownFact>? facts)) held.Add(actor.Actor, facts = []);
                    if (!facts.Any(f => f.Id == fixture.Id)) facts.Add(fixture);
                }
            foreach (SemanticEvent e in history.Where(e => e.Cycle == cycle.State.Cycle))
            {
                List<(PersonId Actor, KnownFact Fact)> incoming = [];
                if (e.Kind == "Communication")
                    incoming.AddRange(e.TransmittedEvidence.Where(f => f.Proposition is HouseholdExistenceFact).Select(f =>
                        (e.Participants[1], new KnownFact(new(0), f.Proposition, new(AcquisitionRoute.Communication, f.Provenance.Origin,
                        [.. f.Provenance.Hops, new(e.Participants[0], e.Participants[1], e.Id, new(e.Cycle, e.ReactionIndex))])))));
                if (e.Kind is "HouseholdRecognitionAcquired" or "HouseholdDissolutionEvidenceAcquired")
                {
                    SemanticEvent origin = Referenced(history, e.Causes.Single());
                    WarrantStamp stamp;
                    HouseholdId household;
                    WarrantId warrant;
                    bool continues = e.Kind == "HouseholdRecognitionAcquired";
                    if (origin.Kind == "HouseholdFormation")
                    {
                        FormationWarrant? f = h.Formations.Values.SingleOrDefault(f => f.Stamp.Event == origin.Id);
                        Assert.IsNotNull(f, "Formation acquisition requires its actual warrant.");
                        household = f.Household; warrant = f.Id; stamp = f.Stamp;
                    }
                    else if (origin.Kind == "HouseholdContinued")
                    {
                        ContinuationWarrant? c = h.Continuations.Values.SingleOrDefault(c => c.Stamp.Event == origin.Id);
                        Assert.IsNotNull(c, "Continuation acquisition requires its actual warrant.");
                        household = c.Household; warrant = c.Id; stamp = c.Stamp;
                    }
                    else
                    {
                        Assert.IsFalse(continues);
                        Assert.AreEqual("HouseholdLifecycle", origin.Kind);
                        Household value = h.Households.Values.Single(x => origin.Detail == $"Household:{x.Id.Value};Dissolved");
                        household = value.Id; warrant = value.Formation;
                        stamp = new(origin.Id, new(origin.Cycle, origin.ReactionIndex), origin.RulesVersion, origin.ConfigurationVersion);
                    }
                    Assert.AreEqual($"Household:{household.Value};Warrant:{warrant.Value}", e.Detail);
                    CollectionAssert.AreEqual(origin.Participants.ToArray(), e.Participants.ToArray());
                    foreach (PersonId actor in e.Participants.Distinct().OrderBy(p => p.Value))
                        incoming.Add((actor, new(new(0), new HouseholdExistenceFact(household, continues, warrant),
                            new(AcquisitionRoute.Participation, new(actor, stamp.Event, stamp.Time), []))));
                }
                List<AcquiredFact> receipts = [.. e.AcquiredEvidence.Where(r => r.Fact.Proposition is HouseholdExistenceFact)];
                // Only facts retained after the complete delivery have receipts;
                // a later payload member can supersede an earlier report.
                foreach (var acquisition in incoming.Where(a => !incoming.Any(b => b.Actor == a.Actor && Newer(b.Fact, a.Fact))))
                {
                    if (!held.TryGetValue(acquisition.Actor, out List<KnownFact>? facts)) held.Add(acquisition.Actor, facts = []);
                    if (facts.Any(f => Newer(f, acquisition.Fact))) continue;
                    int index = receipts.FindIndex(r => r.Actor == acquisition.Actor && SameEvidenceContent(r.Fact, acquisition.Fact));
                    Assert.IsTrue(index >= 0, $"Every retained acquisition needs an exact identity receipt: event={e.Id.Value}/{e.Kind}, actor={acquisition.Actor.Value}, incoming={acquisition.Fact}.");
                    KnownFact fact = receipts[index].Fact; receipts.RemoveAt(index);
                    Assert.IsGreaterThan(0L, fact.Id.Value);
                    Assert.IsTrue(acquiredIds.Add(fact.Id), "Acquisition identities cannot be reused across actors/events.");
                    facts.RemoveAll(f => Newer(fact, f)); facts.Add(fact);
                }
                Assert.IsEmpty(receipts, "Receipt must be justified by the actual acquisition/communication.");
            }
            foreach (ActorEpistemicState actor in cycle.Epistemic!.Actors.Values)
            {
                KnownFact[] actual = [.. actor.Facts.Where(f => f.Proposition is HouseholdExistenceFact).OrderBy(f => f.Id.Value)];
                KnownFact[] expected = [.. held.GetValueOrDefault(actor.Actor, []).OrderBy(f => f.Id.Value)];
                Assert.AreEqual(expected.Length, actual.Length);
                Assert.IsTrue(expected.Zip(actual).All(pair => SameEvidence(pair.First, pair.Second)),
                    "Acquisition replay must match exact stable actor-held identities and contents.");
            }
        }
        static bool Newer(KnownFact a, KnownFact b) => a.Proposition is HouseholdExistenceFact x && b.Proposition is HouseholdExistenceFact y &&
            x.Household == y.Household && a.Provenance.Origin.Order is { } left && b.Provenance.Origin.Order is { } right && left.CompareTo(right) > 0 &&
            (a.Provenance.Route == AcquisitionRoute.Participation || a.Provenance.Route == AcquisitionRoute.Communication &&
                a.Provenance.Origin.Event is not null && b.Provenance.Route is AcquisitionRoute.Communication or AcquisitionRoute.Fixture);
    }

    private static void VerifyLifecycle(InitialWorld initial, HouseholdSnapshot h, Household household, SemanticEvent[] history)
    {
        FormationWarrant formation = h.Formations[household.Formation];
        SemanticEvent expected = VerifyStamp(initial, formation.Stamp, "HouseholdFormation", history);
        HouseholdLifecycle state = HouseholdLifecycle.Active;
        HashSet<AssociationId> live = [.. h.Associations.Values.Where(a => a.Origin == formation.Id).Select(a => a.Id)];
        HashSet<EventId> publications = [];
        var transitions = h.Entries.Values.Where(e => e.Household == household.Id).Select(e => (e.Id, e.Stamp, Entry: true))
            .Concat(h.Exits.Values.Where(e => e.Household == household.Id).Select(e => (e.Id, e.Stamp, Entry: false))).OrderBy(e => e.Stamp.Time);
        foreach (var cycle in transitions.GroupBy(t => t.Stamp.Time.Cycle))
        {
            Assert.AreNotEqual(HouseholdLifecycle.Dissolved, state, "No resurrection after stable dissolution.");
            foreach (var transition in cycle)
            {
                if (transition.Entry) live.Add(h.Associations.Values.Single(a => a.Origin == transition.Id).Id);
                else Assert.IsTrue(live.Remove(h.Exits[transition.Id].Association));
            }
            HouseholdLifecycle next = live.Count switch { 0 => HouseholdLifecycle.Dissolved, 1 => HouseholdLifecycle.Inactive, _ => HouseholdLifecycle.Active };
            SemanticEvent[] events = [.. history.Where(e => e.Cycle == cycle.Key && e.Kind == "HouseholdLifecycle" &&
                e.Detail.StartsWith($"Household:{household.Id.Value};", StringComparison.Ordinal))];
            if (state == next) { Assert.IsEmpty(events, "Transient microstates must not publish lifecycle changes."); continue; }
            Assert.AreEqual(1, events.Length);
            SemanticEvent published = events[0];
            Assert.AreEqual($"Household:{household.Id.Value};{next}", published.Detail);
            Assert.AreEqual("SFL-S3-v1", published.RulesVersion);
            Assert.AreEqual(initial.Configuration.Version, published.ConfigurationVersion);
            EventId[] causes = [.. h.Exits.Values.Where(e => e.Household == household.Id && e.Stamp.Time.Cycle == cycle.Key).Select(e => e.Stamp.Event),
                .. h.Continuations.Values.Where(c => c.Household == household.Id && c.Stamp.Time.Cycle == cycle.Key).Select(c => c.Stamp.Event)];
            Assert.IsNotEmpty(causes);
            CollectionAssert.AreEquivalent(causes, published.Causes.ToArray());
            Assert.IsTrue(history.Where(e => e.Cycle == cycle.Key && e.Kind is "HouseholdParticipation" or "HouseholdParticipationEnded" or "HouseholdContinued")
                .All(e => e.ReactionIndex < published.ReactionIndex), "Lifecycle must follow voluntary transitions and immediate continuity at stable closure.");
            PersonId[] participants = next == HouseholdLifecycle.Dissolved ? [h.Exits[cycle.Last().Id].Person] : [.. live.Select(a => h.Associations[a].Person)];
            CollectionAssert.AreEquivalent(participants, published.Participants.ToArray());
            publications.Add(published.Id);
            expected = published; state = next;
        }
        CollectionAssert.AreEquivalent(publications.ToArray(), history.Where(e => e.Kind == "HouseholdLifecycle" &&
            e.Detail.StartsWith($"Household:{household.Id.Value};", StringComparison.Ordinal)).Select(e => e.Id).ToArray());
        SemanticEvent actual = Referenced(history, household.LifecycleEvent);
        Assert.AreEqual(expected.Id, actual.Id, "Lifecycle reference must name the latest justified stable publication.");
        Assert.AreEqual(new EvidenceOrder(actual.Cycle, actual.ReactionIndex), household.LifecycleTime);
        Assert.AreEqual(state, household.Lifecycle);
    }

    private static SemanticEvent VerifyStamp(InitialWorld initial, WarrantStamp stamp, string kind, SemanticEvent[] history)
    {
        SemanticEvent actual = Referenced(history, stamp.Event);
        Assert.AreEqual(kind, actual.Kind);
        Assert.AreEqual(new EvidenceOrder(actual.Cycle, actual.ReactionIndex), stamp.Time);
        Assert.AreEqual("SFL-S3-v1", stamp.RulesVersion);
        Assert.AreEqual(stamp.RulesVersion, actual.RulesVersion);
        Assert.AreEqual(initial.Configuration.Version, stamp.ConfigurationVersion);
        Assert.AreEqual(stamp.ConfigurationVersion, actual.ConfigurationVersion);
        return actual;
    }

    private static SupportKind SupportMeaning(SemanticEvent actual)
    {
        SupportKind? kind = actual.Kind switch
        {
            "Gift" => SupportKind.Gift,
            "Help" or "RelationshipMediatedReciprocalHelp" => SupportKind.Help,
            "Loan" => SupportKind.Loan,
            "CalledFavourFulfilled" => SupportKind.FavourFulfilment,
            _ => null
        };
        Assert.IsNotNull(kind, "Fresh/support evidence must be ordinary committed person-person support.");
        Assert.AreEqual(2, actual.Participants.Length);
        Assert.AreNotEqual(actual.Participants[0], actual.Participants[1]);
        return kind.Value;
    }

    private static SemanticEvent VerifySupport(SupportFact support, EvidenceOrder before, SemanticEvent[] history)
    {
        SemanticEvent actual = Referenced(history, support.Event);
        Assert.AreEqual(SupportMeaning(actual), support.Kind);
        Assert.AreEqual(actual.Cycle, support.Cycle);
        Assert.AreEqual(new EvidenceOrder(actual.Cycle, actual.ReactionIndex), support.Order);
        CollectionAssert.AreEqual(actual.Participants.ToArray(), new[] { support.First, support.Second });
        Assert.IsTrue(new EvidenceOrder(actual.Cycle, actual.ReactionIndex).CompareTo(before) < 0);
        return actual;
    }

    private static void VerifyFormation(InitialWorld initial, HouseholdSnapshot h, FormationWarrant f,
        SemanticEvent[] history, IReadOnlyList<CycleResult> cycles, IReadOnlyList<CandidateReferent> declarations)
    {
        SemanticEvent formed = VerifyStamp(initial, f.Stamp, "HouseholdFormation", history);
        Assert.AreEqual($"Household:{f.Household.Value};Warrant:{f.Id.Value};Candidate:{f.Candidate.Value}", formed.Detail);
        CollectionAssert.AreEqual(formed.Participants.ToArray(), f.Founders.ToArray());
        Assert.IsTrue(h.Households.TryGetValue(f.Household, out Household? household));
        Assert.IsNotNull(household);
        Assert.AreEqual(f.Id, household.Formation);
        CandidateReferent? candidate = initial.Candidates.Concat(declarations).SingleOrDefault(c => c.Id == f.Candidate);
        Assert.IsNotNull(candidate, "Formation must reference a declared bounded candidate.");
        Assert.IsTrue(candidate.IsLive);
        CollectionAssert.AreEquivalent(candidate.Core.ToArray(), f.Founders.ToArray());
        Assert.IsGreaterThanOrEqualTo(2, f.Founders.Length);
        Assert.AreEqual(f.Founders.Length, f.Founders.Distinct().Count());
        WorldSnapshot world = PrecommitWorld(initial, cycles, history, f.Stamp.Time);
        Assert.IsTrue(f.Founders.All(p => world.Residences.Values.Single(r => r.Person == p).Dwelling == f.Dwelling));
        Assert.IsNotEmpty(f.Ties);
        foreach (DurableTieEvidence tie in f.Ties)
        {
            Assert.AreNotEqual(tie.First, tie.Second);
            Assert.Contains(tie.First, f.Founders); Assert.Contains(tie.Second, f.Founders);
            RelationId[] expected = [.. world.Kinships.Values.Where(k => Pair(k.First, k.Second, tie.First, tie.Second)).Select(k => k.Id),
                .. world.Marriages.Values.Where(m => Pair(m.Groom, m.Bride, tie.First, tie.Second)).Select(m => m.Id),
                .. world.AttitudeOf(tie.First, tie.Second) >= 75 && world.AttitudeOf(tie.Second, tie.First) >= 75
                    ? world.Attitudes.Values.Where(a => Pair(a.From, a.To, tie.First, tie.Second)).Select(a => a.Id) : []];
            Assert.IsNotEmpty(expected);
            CollectionAssert.AreEquivalent(expected, tie.Relations.ToArray());
        }
        Assert.IsTrue(Connected(f.Founders, (a, b) => f.Ties.Any(t => Pair(t.First, t.Second, a, b))),
            "Only the recorded, validated ties may connect the founder graph.");
        Assert.AreEqual(f.Supports.Length, f.Supports.Select(s => s.Event).Distinct().Count());
        Assert.IsGreaterThanOrEqualTo(2, f.Supports.Select(s => s.Cycle).Distinct().Count());
        foreach (SupportFact support in f.Supports)
        {
            VerifySupport(support, f.Stamp.Time, history);
            Assert.Contains(support.First, f.Founders); Assert.Contains(support.Second, f.Founders);
            Assert.Contains(support.Event, formed.Causes);
        }
        Assert.AreEqual(f.Founders.Length, f.Recognition.Length);
        // Formation occurs after ordinary evidence updates in closure. Read retained
        // facts at that boundary, never the production CandidateRecognition verdict.
        EpistemicSnapshot held = cycles.Single(c => c.State.Cycle == f.Stamp.Time.Cycle).Epistemic!;
        for (int i = 0; i < f.Founders.Length; i++)
        {
            PersonId founder = f.Founders[i];
            CandidateRecognition recognition = f.Recognition[i];
            Assert.AreEqual(f.Candidate, recognition.Candidate);
            Assert.AreEqual(RecognitionStatus.Recognized, recognition.Status);
            KnownFact[] basis = [.. held.Actors[founder].Facts.Where(fact => Relevant(fact.Proposition))];
            Assert.IsNotEmpty(basis);
            Assert.AreEqual(basis.Length, recognition.Evidence.Length);
            Assert.AreEqual(recognition.Evidence.Length, recognition.Evidence.Select(e => e.Id).Distinct().Count());
            foreach (KnownFact fact in recognition.Evidence)
            {
                Assert.IsTrue(basis.Any(actual => actual.Id == fact.Id && SameEvidence(actual, fact)),
                    "Each founder must supply their own actual retained evidence.");
                VerifyCandidateProvenance(initial, fact, founder, f.Stamp.Time, history, cycles);
            }
            Assert.IsTrue(CandidatePredicate(f.Founders, recognition.Evidence));
            SemanticEvent[] established = [.. formed.Causes.Select(id => Referenced(history, id)).Where(e =>
                e.Kind == "CandidateRecognitionEstablished" && e.Participants.SequenceEqual(new[] { founder }))];
            Assert.AreEqual(1, established.Length);
            Assert.AreEqual($"Candidate:{f.Candidate.Value}", established[0].Detail);
            foreach (EventId cause in recognition.Evidence.Select(e => e.Provenance.Origin.Event).OfType<EventId>()
                .Concat(recognition.Evidence.SelectMany(e => e.Provenance.Hops).Select(hop => hop.Event)))
                Assert.Contains(cause, established[0].Causes);
        }
        EvidenceOrder? earliest = f.Recognition.SelectMany(r => r.Evidence).Select(e => e.Provenance.Origin.Order).OfType<EvidenceOrder>().Min();
        Assert.IsNotNull(earliest);
        Assert.AreEqual(earliest, f.EarliestEvidence);
        Assert.IsTrue(earliest.CompareTo(f.Stamp.Time) < 0);
        SustainingParticipant[] founded = [.. h.Associations.Values.Where(a => a.Origin == f.Id)];
        CollectionAssert.AreEquivalent(f.Founders.ToArray(), founded.Select(a => a.Person).ToArray());
        foreach (SustainingParticipant association in founded)
        {
            Assert.AreEqual(f.Household, association.Household);
            SemanticEvent[] starts = [.. history.Where(e => e.Kind == "SustainingParticipationFounded" &&
                e.Detail == $"Household:{f.Household.Value};Association:{association.Id.Value};Warrant:{f.Id.Value}")];
            Assert.AreEqual(1, starts.Length);
            CollectionAssert.AreEqual(new[] { association.Person }, starts[0].Participants.ToArray());
            CollectionAssert.AreEqual(new[] { formed.Id }, starts[0].Causes.ToArray());
        }

        bool Relevant(FactualProposition fact) => fact switch
        {
            ResidenceFact r => f.Founders.Contains(r.Person),
            KinshipFact k => f.Founders.Contains(k.Kinship.First) && f.Founders.Contains(k.Kinship.Second),
            MarriageFact m => f.Founders.Contains(m.Marriage.Groom) && f.Founders.Contains(m.Marriage.Bride),
            AttitudeFact a => f.Founders.Contains(a.Attitude.From) && f.Founders.Contains(a.Attitude.To),
            SupportFact s => f.Founders.Contains(s.First) && f.Founders.Contains(s.Second),
            _ => false
        };
    }

    private static void VerifyCandidateProvenance(InitialWorld initial, KnownFact fact, PersonId actor, EvidenceOrder before,
        SemanticEvent[] history, IReadOnlyList<CycleResult> cycles)
    {
        EvidenceOrigin origin = fact.Provenance.Origin;
        Assert.IsNotNull(origin.Order);
        Assert.IsTrue(origin.Order.CompareTo(before) < 0);
        PersonId holder = fact.Provenance.Hops.IsEmpty ? actor : fact.Provenance.Hops[0].Sender;
        if (origin.Fixture is not null)
            Assert.IsTrue(initial.Knowledge.Any(k => k.Actor == holder && k.Facts.Any(seed =>
                seed.Proposition == fact.Proposition && seed.Provenance.Origin == origin)), "Fixture evidence must come from a declared seed.");
        else
        {
            Assert.AreEqual(holder, origin.Source);
            WorldSnapshot world;
            if (origin.Event is { } id)
            {
                SemanticEvent source = Referenced(history, id);
                Assert.AreEqual(new EvidenceOrder(source.Cycle, source.ReactionIndex), origin.Order);
                Assert.Contains(holder, source.Participants);
                world = PrecommitWorld(initial, cycles, history, new(source.Cycle, source.ReactionIndex + 1));
            }
            else
            {
                Assert.AreEqual(new EvidenceOrder(0, 0), origin.Order);
                world = PrecommitWorld(initial, cycles, history, new(1, 0));
            }
            bool grounded = fact.Proposition switch
            {
                ResidenceFact r => r.Person == holder && world.HomeOf(r.Person) == r.Dwelling,
                KinshipFact k => world.Kinships.Values.Contains(k.Kinship) && (k.Kinship.First == holder || k.Kinship.Second == holder),
                MarriageFact m => world.Marriages.Values.Contains(m.Marriage) && (m.Marriage.Groom == holder || m.Marriage.Bride == holder),
                AttitudeFact a => world.Attitudes.Values.Contains(a.Attitude) && (a.Attitude.From == holder || a.Attitude.To == holder),
                SupportFact s => VerifySupport(s, before, history).Id == origin.Event && (s.First == holder || s.Second == holder),
                _ => false
            };
            Assert.IsTrue(grounded, "Candidate evidence must have an actual direct acquisition basis.");
        }
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
            Assert.IsTrue(delivery.TransmittedEvidence.Any(sent => sent.Proposition == fact.Proposition &&
                sent.Provenance.Origin == origin && sent.Provenance.Hops.SequenceEqual(prefix)));
            prefix.Add(hop); holder = hop.Recipient; previous = hop.Delivered;
        }
        Assert.AreEqual(actor, holder);
        AcquisitionRoute expected = !prefix.Any() ? origin.Fixture is not null ? AcquisitionRoute.Fixture :
            fact.Proposition is ResidenceFact ? AcquisitionRoute.OwnState : fact.Proposition is SupportFact ? AcquisitionRoute.Participation : AcquisitionRoute.DirectParty :
            AcquisitionRoute.Communication;
        Assert.AreEqual(expected, fact.Provenance.Route);
    }

    private static void VerifyContinuation(InitialWorld initial, HouseholdSnapshot h, ContinuationWarrant c,
        SemanticEvent[] history, IReadOnlyList<CycleResult> cycles)
    {
        SemanticEvent continued = VerifyStamp(initial, c.Stamp, "HouseholdContinued", history);
        Assert.AreEqual($"Household:{c.Household.Value};Warrant:{c.Id.Value};Previous:{c.Previous.Value};Transition:{c.Transition.Value}", continued.Detail);
        WarrantStamp transition;
        if (h.Entries.TryGetValue(c.Transition, out ParticipationWarrant? entry))
        { Assert.AreEqual(c.Household, entry.Household); transition = entry.Stamp; }
        else
        {
            Assert.IsTrue(h.Exits.TryGetValue(c.Transition, out ParticipationEndWarrant? exit));
            Assert.IsNotNull(exit); Assert.AreEqual(c.Household, exit.Household);
            transition = exit.Stamp;
            SemanticEvent ended = VerifyStamp(initial, exit.Stamp, "HouseholdParticipationEnded", history);
            Assert.AreEqual($"Household:{exit.Household.Value};Warrant:{exit.Id.Value};Association:{exit.Association.Value}", ended.Detail);
            CollectionAssert.AreEqual(new[] { exit.Person }, ended.Participants.ToArray());
            Assert.AreEqual(exit.Proposal, ended.Proposal);
        }
        WarrantStamp previous;
        if (h.Formations.TryGetValue(c.Previous, out FormationWarrant? formation))
        { Assert.AreEqual(c.Household, formation.Household); previous = formation.Stamp; }
        else
        {
            Assert.IsTrue(h.Continuations.TryGetValue(c.Previous, out ContinuationWarrant? prior));
            Assert.IsNotNull(prior); Assert.AreEqual(c.Household, prior.Household); previous = prior.Stamp;
        }
        Assert.IsTrue(previous.Time.CompareTo(transition.Time) < 0 && transition.Time.CompareTo(c.Stamp.Time) < 0);
        CollectionAssert.AreEquivalent(new[] { transition.Event, previous.Event }, continued.Causes.ToArray());
        CollectionAssert.AreEqual(Referenced(history, transition.Event).Participants.ToArray(), continued.Participants.ToArray());
        Assert.AreEqual(c.Prior.Length, c.Prior.Distinct().Count());
        Assert.AreEqual(c.Successor.Length, c.Successor.Distinct().Count());
        Assert.IsNotEmpty(c.Bridges);
        Assert.AreEqual(c.Bridges.Length, c.Bridges.Distinct().Count());
        Assert.AreEqual(c.Bridges.Length, c.Recognition.Length);
        for (int i = 0; i < c.Bridges.Length; i++)
        {
            PersonId bridge = c.Bridges[i];
            Assert.IsTrue(c.Prior.Intersect(c.Successor).Any(id => h.Associations[id].Person == bridge && h.Associations[id].Household == c.Household));
            VerifyRecognition(c.Recognition[i], bridge, c.Household, c.Stamp, h, history, cycles);
        }
    }

    private static void VerifyLineage(InitialWorld initial, HouseholdSnapshot h, LineageWarrant l, SemanticEvent[] history)
    {
        SemanticEvent actual = VerifyStamp(initial, l.Stamp, "HouseholdLineage", history);
        Assert.IsTrue(Enum.IsDefined(l.Kind));
        Assert.AreEqual($"Successor:{l.Successor.Value};Warrant:{l.Id.Value};Kind:{l.Kind}", actual.Detail);
        Assert.IsTrue(h.Formations.TryGetValue(l.Formation, out FormationWarrant? f));
        Assert.IsNotNull(f);
        Assert.AreEqual(f.Household, l.Successor);
        Assert.AreEqual(l.Formation, h.Households[l.Successor].Formation);
        CollectionAssert.AreEqual(f.Founders.ToArray(), actual.Participants.ToArray());
        Assert.IsTrue(f.Stamp.Time.CompareTo(l.Stamp.Time) < 0);
        Assert.AreEqual(f.Founders.Length, l.Sources.Length);
        CollectionAssert.AreEquivalent(f.Founders.ToArray(), l.Sources.Select(s => s.Founder).ToArray());
        Assert.AreEqual(l.FreshEvidence.Length, l.FreshEvidence.Distinct().Count());
        Assert.IsNotEmpty(l.FreshEvidence);
        foreach (EventId fresh in l.FreshEvidence)
        {
            SemanticEvent support = Referenced(history, fresh);
            SupportMeaning(support);
            Assert.IsTrue(support.Participants.All(f.Founders.Contains));
            Assert.IsTrue(new EvidenceOrder(support.Cycle, support.ReactionIndex).CompareTo(f.Stamp.Time) < 0);
            Assert.IsTrue(f.Supports.Any(s => s.Event == fresh));
        }
        foreach (FounderLineageSource source in l.Sources)
        {
            Assert.IsTrue(h.Exits.TryGetValue(source.ParticipationEnd, out ParticipationEndWarrant? exit));
            Assert.IsNotNull(exit);
            VerifyStamp(initial, exit.Stamp, "HouseholdParticipationEnded", history);
            Assert.AreEqual(source.Founder, exit.Person);
            Assert.AreEqual(source.Predecessor, exit.Household);
        }
        CollectionAssert.AreEquivalent(new[] { f.Stamp.Event }.Concat(l.Sources.Select(s => h.Exits[s.ParticipationEnd].Stamp.Event))
            .Concat(l.FreshEvidence).Distinct().ToArray(), actual.Causes.ToArray());
    }
}
