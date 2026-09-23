using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private HouseholdState households = new();
    private HouseholdSnapshot publishedHouseholds;
    public HouseholdSnapshot HouseholdSnapshot => publishedHouseholds;
    private const string HouseholdRulesVersion = "SFL-S3-v1";
    private WarrantStamp Stamp(SemanticEvent e) => new(e.Id, new(e.Cycle, e.ReactionIndex), HouseholdRulesVersion, initial.Configuration.Version);

    private SemanticEvent HouseholdEvent(string kind, ImmutableArray<PersonId> participants, ImmutableArray<EventId> causes,
        string detail, ProposalId? proposal = null, bool fallback = false)
    {
        SemanticEvent e = Record(kind, proposal, participants, causes.Distinct().ToImmutableArray(), [], detail, fallback);
        events[^1] = e with { RulesVersion = HouseholdRulesVersion };
        return events[^1];
    }

    private SemanticEvent CommitHousehold(Proposal proposal, EventId acceptance, bool fallback)
    {
        households = households.Copy();
        epistemic = epistemic.Copy();
        HouseholdId h = HouseholdRules.Target(proposal.Terms)!.Value;
        ImmutableArray<AssociationId> prior = [.. households.Current(h).Select(a => a.Id)];
        WarrantId transition = households.AllocateWarrant();
        SemanticEvent committed;
        if (HouseholdRules.Entry(proposal) is { } entry)
        {
            ImmutableArray<SupportFact> supports = HouseholdRules.EntrySupports(households, h, entry.Newcomer);
            ImmutableArray<HouseholdRecognition> recognition = [epistemic.Of(entry.Newcomer).HouseholdRecognitions.Single(r => r.Household == h),
                epistemic.Of(entry.Bridge).HouseholdRecognitions.Single(r => r.Household == h)];
            committed = HouseholdEvent("HouseholdParticipation", [entry.Newcomer, entry.Bridge],
                [acceptance, .. supports.Select(s => s.Event), .. recognition.SelectMany(r => r.Evidence).Select(f => f.Provenance.Origin.Event).OfType<EventId>(),
                    .. recognition.SelectMany(r => r.Evidence).SelectMany(f => f.Provenance.Hops).Select(hop => hop.Event)],
                $"Household:{h.Value};Warrant:{transition.Value}", proposal.Id, fallback);
            WorldSnapshot world = state.Snapshot(cycle);
            households.Entries.Add(transition, new(transition, h, entry.Newcomer, entry.Bridge, proposal.Id, acceptance, prior,
                [.. world.Residences.Values.Where(r => r.Person == entry.Newcomer || households.Current(h).Any(a => a.Person == r.Person)).OrderBy(r => r.Id.Value)],
                HouseholdRules.Ties(world, [entry.Newcomer, .. households.Current(h).Select(a => a.Person)]), supports, recognition, Stamp(committed)));
            AssociationId association = households.AllocateAssociation();
            households.Associations.Add(association, new(association, entry.Newcomer, h, transition, null));
            HouseholdEvent("SustainingParticipationStarted", [entry.Newcomer], [committed.Id], $"Association:{association.Value};Household:{h.Value}");
        }
        else
        {
            SustainingParticipant association = households.Current(h).Single(a => a.Person == proposal.Actor);
            committed = HouseholdEvent("HouseholdParticipationEnded", [proposal.Actor], [acceptance],
                $"Household:{h.Value};Warrant:{transition.Value};Association:{association.Id.Value}", proposal.Id, fallback);
            households.Exits.Add(transition, new(transition, h, proposal.Actor, association.Id, proposal.Id, Stamp(committed)));
            households.Associations[association.Id] = association with { End = transition };
            TerminateCommitments(h, proposal.Actor, committed.Id);
        }
        events[events.FindIndex(e => e.Id == committed.Id)] = committed with { Action = proposal.Terms };
        ContinueHousehold(h, transition, prior, committed);
        if (Challenge == ReactionChallenge.DuplicateCauses) ContinueHousehold(h, transition, prior, committed);
        return committed;
    }

    private void ContinueHousehold(HouseholdId h, WarrantId transition, ImmutableArray<AssociationId> prior, SemanticEvent cause)
    {
        if (households.Continuations.Values.Any(c => c.Transition == transition)) return;
        SustainingParticipant[] current = households.Current(h);
        if (current.Length == 0) return;
        ImmutableArray<PersonId> bridges = [.. current.Where(a => prior.Contains(a.Id) &&
            epistemic.Of(a.Person).HouseholdRecognitionOf(h) == RecognitionStatus.Recognized).Select(a => a.Person).OrderBy(p => p.Value)];
        if (bridges.IsEmpty) throw new InvalidOperationException("UnresolvedHouseholdContinuity: no recognizing historical bridge.");
        ContinuationWarrant? previous = households.Continuations.Values.Where(c => c.Household == h).MaxBy(c => c.Stamp.Time);
        WarrantId previousId = previous?.Id ?? households.Households[h].Formation;
        EventId previousEvent = previous?.Stamp.Event ?? households.Formations[previousId].Stamp.Event;
        ImmutableArray<HouseholdRecognition> recognition = [.. bridges.Select(b => epistemic.Of(b).HouseholdRecognitions.Single(r => r.Household == h))];
        WarrantId id = households.AllocateWarrant();
        SemanticEvent e = HouseholdEvent("HouseholdContinued", cause.Participants, [cause.Id, previousEvent],
            $"Household:{h.Value};Warrant:{id.Value};Previous:{previousId.Value};Transition:{transition.Value}");
        households.Continuations.Add(id, new(id, h, previousId, transition, prior, [.. current.Select(a => a.Id)], bridges, recognition, Stamp(e)));
        // A retained bridge basis is evidence for continuity, not an observation entitlement.
        // Only direct parties to the causal transition acquire its new evidence.
        RecognizeHousehold(h, id, true, cause.Participants, e);
    }

    private void RecognizeHousehold(HouseholdId h, WarrantId warrant, bool continues, ImmutableArray<PersonId> participants, SemanticEvent cause)
    {
        HouseholdEvent(continues ? "HouseholdRecognitionAcquired" : "HouseholdDissolutionEvidenceAcquired",
            participants, [cause.Id], $"Household:{h.Value};Warrant:{warrant.Value}");
        foreach (PersonId person in participants.Distinct().OrderBy(p => p.Value))
            epistemic.Acquire(person, new HouseholdExistenceFact(h, continues, warrant), AcquisitionRoute.Participation,
                new(person, cause.Id, new(cause.Cycle, cause.ReactionIndex)));
        // The acquisition event is observer evidence; actor provenance identifies the underlying household event.
    }

    private void TerminateCommitments(HouseholdId h, PersonId? person, EventId cause)
    {
        foreach (HouseholdProvisionCommitment commitment in households.Commitments.Values.Where(c => c.Household == h &&
            (person is null || c.Person == person) && c.TerminatedBy is null).ToArray())
            households.Commitments[commitment.Id] = commitment with { TerminatedBy = cause };
    }

    private void CloseHouseholds()
    {
        // Lifecycle is committed only here, after all compatible voluntary transitions and their immediate continuity reactions.
        foreach (Household h in households.Households.Values.OrderBy(h => h.Id.Value).ToArray())
        {
            if (h.Lifecycle == HouseholdLifecycle.Dissolved) continue;
            SustainingParticipant[] current = households.Current(h.Id);
            HouseholdLifecycle lifecycle = current.Length switch { 0 => HouseholdLifecycle.Dissolved, 1 => HouseholdLifecycle.Inactive, _ => HouseholdLifecycle.Active };
            if (lifecycle == h.Lifecycle) continue;
            ImmutableArray<EventId> causes = [.. households.Exits.Values.Where(e => e.Household == h.Id && e.Stamp.Time.Cycle == cycle).Select(e => e.Stamp.Event),
                .. households.Continuations.Values.Where(c => c.Household == h.Id && c.Stamp.Time.Cycle == cycle).Select(c => c.Stamp.Event)];
            // Only the terminal exit directly participates in dissolution. Earlier
            // leavers do not learn later exits merely because they share a cycle.
            ImmutableArray<PersonId> participants = lifecycle == HouseholdLifecycle.Dissolved
                ? [households.Exits.Values.Where(x => x.Household == h.Id).MaxBy(x => x.Stamp.Time)!.Person]
                : [.. current.Select(a => a.Person)];
            SemanticEvent e = HouseholdEvent("HouseholdLifecycle", participants, causes, $"Household:{h.Id.Value};{lifecycle}");
            households.Households[h.Id] = h with { Lifecycle = lifecycle, LifecycleEvent = e.Id, LifecycleTime = new(e.Cycle, e.ReactionIndex) };
            if (lifecycle == HouseholdLifecycle.Dissolved)
            {
                TerminateCommitments(h.Id, null, e.Id);
                RecognizeHousehold(h.Id, h.Formation, false, participants, e);
            }
        }
        foreach (CandidateReferent candidate in epistemic.Candidates.OrderBy(c => c.Id.Value)) TryForm(candidate);
    }

    private void TryForm(CandidateReferent candidate)
    {
        if (!candidate.IsLive || candidate.Core.Length < 2 || households.Formations.Values.Any(f => f.Candidate == candidate.Id)) return;
        WorldSnapshot world = state.Snapshot(cycle);
        ImmutableArray<PersonId> founders = [.. candidate.Core.OrderBy(p => p.Value)];
        if (founders.Select(world.HomeOf).Distinct().Count() != 1) return;
        ImmutableArray<DurableTieEvidence> ties = HouseholdRules.Ties(world, founders);
        if (!HouseholdRules.Connected(founders, ties)) return;
        ImmutableArray<SupportFact> supports = [.. households.Supports.Values.Where(s => founders.Contains(s.First) && founders.Contains(s.Second)).OrderBy(s => s.Event.Value)];
        if (supports.Select(s => s.Cycle).Distinct().Count() < 2) return;
        ImmutableArray<CandidateRecognition> recognition = [.. founders.Select(p => epistemic.Of(p).Recognitions.Single(r => r.Candidate == candidate.Id))];
        if (recognition.Any(r => r.Status != RecognitionStatus.Recognized)) return;
        // A participation warrant records the actual evidence it consumed. No core/label/graph equivalence rule is inferred.
        if (households.Entries.Values.Any(e => households.Households[e.Household].Lifecycle != HouseholdLifecycle.Dissolved &&
            founders.Contains(e.Newcomer) && founders.Contains(e.Bridge) && supports.All(s => e.Supports.Any(used => used.Event == s.Event)))) return;

        List<EventId> recognitionEvents = [];
        for (int i = 0; i < founders.Length; i++)
            recognitionEvents.Add(HouseholdEvent("CandidateRecognitionEstablished", [founders[i]],
                [.. recognition[i].Evidence.Select(f => f.Provenance.Origin.Event).OfType<EventId>().Where(id => events.Any(e => e.Id == id)),
                    .. recognition[i].Evidence.SelectMany(f => f.Provenance.Hops).Select(hop => hop.Event)],
                $"Candidate:{candidate.Id.Value}").Id);
        WarrantId id = households.AllocateWarrant();
        HouseholdId h = households.AllocateHousehold();
        SemanticEvent formed = HouseholdEvent("HouseholdFormation", founders, [.. recognitionEvents, .. supports.Select(s => s.Event)],
            $"Household:{h.Value};Warrant:{id.Value};Candidate:{candidate.Id.Value}");
        EvidenceOrder earliest = recognition.SelectMany(r => r.Evidence).Select(f => f.Provenance.Origin.Order).OfType<EvidenceOrder>()
            .Append(new(cycle, formed.ReactionIndex)).Min()!;
        FormationWarrant warrant = new(id, h, candidate.Id, founders, world.HomeOf(founders[0]), ties, supports, recognition, earliest, Stamp(formed));
        households.Formations.Add(id, warrant);
        households.Households.Add(h, new(h, id, HouseholdLifecycle.Active, formed.Id, new(formed.Cycle, formed.ReactionIndex)));
        foreach (PersonId founder in founders)
        {
            AssociationId a = households.AllocateAssociation();
            households.Associations.Add(a, new(a, founder, h, id, null));
            HouseholdEvent("SustainingParticipationFounded", [founder], [formed.Id], $"Household:{h.Value};Association:{a.Value};Warrant:{id.Value}");
        }
        RecognizeHousehold(h, id, true, founders, formed);
        TryLineage(warrant);
        if (Challenge == ReactionChallenge.DuplicateCauses) TryLineage(warrant);
    }

    private void TryLineage(FormationWarrant formation)
    {
        if (households.Lineages.Values.Any(l => l.Formation == formation.Id)) return;
        // Enumerate complete interpretations; never let first/lowest predecessor decide source ambiguity.
        var interpretations = new List<(HouseholdLineageKind Kind, HouseholdId[] Predecessors, FounderLineageSource[] Sources, EventId[] Fresh)>();
        Household[] predecessors = households.Households.Values.Where(h => h.Id != formation.Household &&
            households.Formations[h.Formation].Stamp.Time.CompareTo(formation.Stamp.Time) < 0).ToArray();
        foreach (Household predecessor in predecessors.Where(h => h.Lifecycle != HouseholdLifecycle.Dissolved))
            Consider(HouseholdLineageKind.DivisionDescendant, [predecessor]);
        Household[] dissolved = predecessors.Where(h => h.Lifecycle == HouseholdLifecycle.Dissolved).ToArray();
        for (int i = 0; i < dissolved.Length; i++)
            for (int j = i + 1; j < dissolved.Length; j++) Consider(HouseholdLineageKind.ConsolidationDescendant, [dissolved[i], dissolved[j]]);
        if (interpretations.Count != 1) return;
        var interpretation = interpretations[0];
        WarrantId id = households.AllocateWarrant();
        SemanticEvent e = HouseholdEvent("HouseholdLineage", formation.Founders,
            [formation.Stamp.Event, .. interpretation.Sources.Select(s => households.Exits[s.ParticipationEnd].Stamp.Event), .. interpretation.Fresh],
            $"Successor:{formation.Household.Value};Warrant:{id.Value};Kind:{interpretation.Kind}");
        households.Lineages.Add(id, new(id, formation.Household, formation.Id, interpretation.Kind,
            interpretation.Predecessors.ToImmutableHashSet(), [.. interpretation.Sources], [.. interpretation.Fresh], Stamp(e)));

        void Consider(HouseholdLineageKind kind, Household[] sources)
        {
            List<FounderLineageSource> mapped = [];
            foreach (PersonId founder in formation.Founders)
            {
                ParticipationEndWarrant[] exits = households.Exits.Values.Where(x => x.Person == founder && sources.Any(h => h.Id == x.Household) &&
                    x.Stamp.Time.CompareTo(formation.Stamp.Time) < 0).ToArray();
                if (exits.GroupBy(x => x.Household).Any(g => g.Count() > 1))
                    throw new InvalidOperationException("LATER-03: repeated predecessor participation requires semantic review.");
                if (exits.Length != 1) return;
                mapped.Add(new(founder, exits[0].Household, exits[0].Id));
            }
            if (sources.Any(h => !mapped.Any(s => s.Predecessor == h.Id))) return;
            EvidenceOrder after = mapped.Select(m => households.Exits[m.ParticipationEnd].Stamp.Time).Max()!;
            if (kind == HouseholdLineageKind.ConsolidationDescendant)
                after = sources.Select(h => h.LifecycleTime).Max()!;
            EventId[] fresh = formation.Supports.Where(s => s.Order is { } order && order.CompareTo(after) > 0 &&
                (kind == HouseholdLineageKind.DivisionDescendant || mapped.Single(m => m.Founder == s.First).Predecessor != mapped.Single(m => m.Founder == s.Second).Predecessor))
                .Select(s => s.Event).ToArray();
            if (fresh.Length > 0) interpretations.Add((kind, [.. sources.Select(h => h.Id)], [.. mapped], fresh));
        }
    }

    // Verification-only prerequisite, admitted by frozen S3 §3.1. No runtime acquisition action exists.
    public void DeclareCandidate(CandidateReferent candidate)
    {
        if (faulted) throw new InvalidOperationException("A failed cycle cannot be resumed.");
        epistemic.DeclareCandidate(candidate);
        publishedEpistemic = epistemic.Snapshot(cycle);
    }

    internal void SupplyProvisionFixture(PersonId person, HouseholdId h, ProvisionFixtureProvenance provenance)
    {
        if (faulted || string.IsNullOrWhiteSpace(provenance.Fixture) || string.IsNullOrWhiteSpace(provenance.Producer) || string.IsNullOrWhiteSpace(provenance.OutputIdentity))
            throw new ArgumentException("Explicit verified producer and fixture provenance required.", nameof(provenance));
        SustainingParticipant association = households.Current(h).Single(a => a.Person == person);
        if (households.Households[h].Lifecycle == HouseholdLifecycle.Dissolved || households.Commitments.Values.Any(c => c.Household == h && c.Person == person && c.TerminatedBy is null))
            throw new InvalidOperationException("Invalid controlled provision prerequisite.");
        CommitmentId id = households.AllocateCommitment();
        households.Commitments.Add(id, new(id, person, h, association.Id, provenance, null));
        publishedHouseholds = households.Snapshot(cycle);
    }

    internal void SupplyHouseholdEvidenceFixture(PersonId actor, HouseholdExistenceFact fact, EvidenceOrigin origin)
    {
        if (faulted || !households.Households.ContainsKey(fact.Household) || string.IsNullOrWhiteSpace(origin.Fixture))
            throw new ArgumentException("Declared household evidence prerequisite required.", nameof(origin));
        epistemic.Acquire(actor, fact, AcquisitionRoute.Fixture, origin);
        publishedEpistemic = epistemic.Snapshot(cycle);
    }
}
