namespace Mesopotamia.Sim;

// Structural validity is separate from proving that a checkpoint faithfully captured its producer.
// Semantically plausible omissions are detected by paired future execution, not guessed from history.
internal static class CheckpointValidation
{
    internal static void Validate(SimulationCheckpoint c)
    {
        Require(c.Cycle > 0 && !string.IsNullOrWhiteSpace(c.Bootstrap.Configuration.Version), "Completed cycle/configuration required.");
        WorldState world = new(c.World);
        HouseholdState households = new(c.Households);
        Dictionary<EventId, SemanticEvent> history = c.Events.ToDictionary(e => e.Id);
        Frontier(c.NextEvent, c.Events.Select(e => e.Id.Value));
        Frontier(c.NextProposal, c.UsedProposals.Select(p => p.Value));
        Unique(c.UsedProposals.Select(p => p.Value));
        Frontier(c.World.NextRelation, c.World.Residences.Select(r => r.Id.Value)
            .Concat(c.World.Attitudes.Select(r => r.Id.Value)).Concat(c.World.Kinships.Select(r => r.Id.Value))
            .Concat(c.World.Marriages.Select(r => r.Id.Value)).Concat(c.World.Debts.Select(r => r.Id.Value))
            .Concat(c.World.Favours.Select(r => r.Id.Value)));
        Unique(c.World.Residences.Select(r => r.Id.Value).Concat(c.World.Attitudes.Select(r => r.Id.Value))
            .Concat(c.World.Kinships.Select(r => r.Id.Value)).Concat(c.World.Marriages.Select(r => r.Id.Value))
            .Concat(c.World.Debts.Select(r => r.Id.Value)).Concat(c.World.Favours.Select(r => r.Id.Value)));
        Unique(c.Events.Select(e => e.Id.Value));
        long previousCycle = 0;
        int previousReaction = -1;
        HashSet<EventId> preceding = [];
        foreach (SemanticEvent e in c.Events)
        {
            Require(e.Cycle > 0 && e.Cycle <= c.Cycle && e.Cycle >= previousCycle &&
                e.ReactionIndex >= 0 && (e.Cycle != previousCycle || e.ReactionIndex > previousReaction), "Invalid history order.");
            Require(e.Causes.All(preceding.Contains) && e.Participants.All(world.People.ContainsKey), "Unresolved event reference.");
            Require(e.ConfigurationVersion == c.Bootstrap.Configuration.Version && c.Rules.Contains(e.RulesVersion), "Invalid event provenance.");
            previousCycle = e.Cycle; previousReaction = e.ReactionIndex; preceding.Add(e.Id);
        }
        void Event(EventId id) => Require(history.ContainsKey(id), "Unresolved runtime event.");
        void Stamp(WarrantStamp stamp)
        {
            Event(stamp.Event);
            SemanticEvent e = history[stamp.Event];
            Require(stamp.Time == new EvidenceOrder(e.Cycle, e.ReactionIndex) &&
                stamp.ConfigurationVersion == c.Bootstrap.Configuration.Version && c.Rules.Contains(stamp.RulesVersion), "Invalid warrant stamp.");
        }
        foreach (Debt d in c.World.Debts) { Event(d.Origin); Require(d.CommittedCycle > 0 && d.CommittedCycle <= c.Cycle, "Invalid debt time."); }
        foreach (Favour f in c.World.Favours) Event(f.Origin);
        foreach (Marriage m in c.World.Marriages) if (m.Origin is { } origin) Event(origin);
        Unique(c.Bootstrap.Inputs.Select(i => i.Id));
        Require(c.Bootstrap.Inputs.All(i => i.Cycle > 0 && world.People.ContainsKey(i.Person)), "Invalid schedule.");
        Require(c.Epistemic.Actors.Select(a => a.Actor).ToHashSet().SetEquals(world.People.Keys) &&
            c.Epistemic.Actors.Length == world.People.Count, "Invalid epistemic owners.");
        KnownFact[] held = [.. c.Epistemic.Actors.SelectMany(a => a.Facts)];
        Unique(held.Select(f => f.Id.Value));
        Frontier(c.Epistemic.NextEvidence, held.Select(f => f.Id.Value));
        Unique(c.Epistemic.Candidates.Select(p => p.Id.Value));
        foreach (CandidateReferent candidate in c.Epistemic.Candidates)
            Require(!candidate.Core.IsDefaultOrEmpty && candidate.Core.Distinct().Count() == candidate.Core.Length &&
                candidate.Core.All(world.People.ContainsKey), "Invalid candidate referent.");
        foreach (KnownFact f in held)
        {
            Require(Enum.IsDefined(f.Provenance.Route), "Unknown evidence route.");
            if (f.Provenance.Origin.Source is { } source) Require(world.People.ContainsKey(source), "Unknown evidence source.");
            if (f.Provenance.Origin.Event is { } origin && f.Provenance.Origin.Fixture is null)
            {
                Event(origin);
                Require(f.Provenance.Origin.Order == new EvidenceOrder(history[origin].Cycle, history[origin].ReactionIndex), "Invalid evidence time.");
            }
            foreach (CommunicationHop hop in f.Provenance.Hops)
            {
                Event(hop.Event);
                Require(world.People.ContainsKey(hop.Sender) && world.People.ContainsKey(hop.Recipient) &&
                    hop.Delivered == new EvidenceOrder(history[hop.Event].Cycle, history[hop.Event].ReactionIndex), "Invalid evidence hop.");
            }
        }
        Frontier(c.Households.NextHousehold, households.Households.Keys.Select(x => x.Value));
        Frontier(c.Households.NextWarrant, households.Formations.Keys.Concat(households.Entries.Keys).Concat(households.Exits.Keys)
            .Concat(households.Continuations.Keys).Concat(households.Lineages.Keys).Select(x => x.Value));
        Frontier(c.Households.NextAssociation, households.Associations.Keys.Select(x => x.Value));
        Frontier(c.Households.NextCommitment, households.Commitments.Keys.Select(x => x.Value));
        Frontier(c.Households.NextHeadRole, households.HeadRoles.Keys.Select(x => x.Value));
        HashSet<WarrantId> warrants = [.. households.Formations.Keys, .. households.Entries.Keys, .. households.Exits.Keys,
            .. households.Continuations.Keys, .. households.Lineages.Keys];
        Require(warrants.Count == households.Formations.Count + households.Entries.Count + households.Exits.Count +
            households.Continuations.Count + households.Lineages.Count, "Duplicate warrant identity.");
        foreach (Household h in c.Households.Households)
        {
            Require(Enum.IsDefined(h.Lifecycle) && households.Formations.ContainsKey(h.Formation), "Invalid household.");
            Event(h.LifecycleEvent);
        }
        foreach (FormationWarrant f in c.Households.Formations) { Stamp(f.Stamp); Require(households.Households.ContainsKey(f.Household), "Missing formation household."); }
        foreach (SustainingParticipant a in c.Households.Associations)
            Require(world.People.ContainsKey(a.Person) && households.Households.ContainsKey(a.Household) && warrants.Contains(a.Origin) &&
                (a.End is null || households.Exits.ContainsKey(a.End.Value)), "Invalid association.");
        foreach (ParticipationWarrant w in c.Households.Entries) { Stamp(w.Stamp); Event(w.Acceptance); }
        foreach (ParticipationEndWarrant w in c.Households.Exits) Stamp(w.Stamp);
        foreach (ContinuationWarrant w in c.Households.Continuations)
        {
            Stamp(w.Stamp);
            Require(warrants.Contains(w.Previous) && warrants.Contains(w.Transition) &&
                w.Prior.Concat(w.Successor).All(households.Associations.ContainsKey), "Invalid continuity reference.");
        }
        foreach (LineageWarrant w in c.Households.Lineages)
        {
            Stamp(w.Stamp);
            Require(households.Households.ContainsKey(w.Successor) && w.Predecessors.All(households.Households.ContainsKey), "Invalid lineage.");
            foreach (EventId e in w.FreshEvidence) Event(e);
        }
        foreach (HouseholdProvisionCommitment p in c.Households.Commitments)
        {
            Require(households.Associations.TryGetValue(p.Association, out var a) && a.Person == p.Person && a.Household == p.Household, "Invalid commitment.");
            if (p.TerminatedBy is { } end) Event(end);
            switch (p.Provenance)
            {
                case EndogenousProvisionOrigin o: Event(o.Request); Event(o.Acceptance); Event(o.Created); break;
                case SelfProvisionOrigin o: Event(o.Authorization); Event(o.Created); break;
                case ProvisionFixtureProvenance o: Require(!string.IsNullOrWhiteSpace(o.Fixture) && !string.IsNullOrWhiteSpace(o.Producer) && !string.IsNullOrWhiteSpace(o.OutputIdentity), "Invalid provision fixture."); break;
                default: throw new InvalidDataException("Unknown provision origin.");
            }
        }
        foreach (SupportFact s in c.Households.Supports) Event(s.Event);
        foreach (HouseholdHeadRole r in c.Households.HeadRoles)
        {
            Require(households.Households.ContainsKey(r.Household) && (r.Occupant is null || world.People.ContainsKey(r.Occupant.Value)), "Invalid role.");
            Event(r.Origin); Event(r.LastTransition);
        }
        foreach (HeadTransition t in c.Households.HeadTransitions) { Stamp(t.Stamp); Event(t.Event); }
        foreach (ProvisionRefusal r in c.Households.ProvisionRefusals)
        {
            Event(r.Event);
            Require(r.Cycle == history[r.Event].Cycle && households.Households.ContainsKey(r.Key.Household) &&
                world.People.ContainsKey(r.Key.Contributor) && r.EligibleSupportCohort.All(households.Associations.ContainsKey), "Invalid refusal.");
            if (r.MaterialNeedChange is { } need) Event(need.Cause);
        }
        Require(c.Observers.Select(o => o.Actor).Distinct().Count() == c.Observers.Length &&
            c.Observers.All(o => world.People.ContainsKey(o.Actor)), "Invalid observer owners.");
    }

    private static void Unique(IEnumerable<long> ids)
    {
        long[] values = [.. ids];
        Require(values.All(i => i > 0) && values.Distinct().Count() == values.Length, "Invalid or duplicate identity.");
    }
    private static void Frontier(long next, IEnumerable<long> ids) =>
        Require(next > 0 && ids.All(id => id > 0 && id < next), "Invalid allocator frontier.");
    private static void Require(bool condition, string reason)
    {
        if (!condition) throw new InvalidDataException(reason);
    }
}

