using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

/// <summary>Independent reconstruction from initial records and public causal history.</summary>
internal static class Slice4Oracle
{
    internal static void Verify(Slice4Lab lab, HouseholdSnapshot? supplied = null, SemanticEvent[]? suppliedEvents = null)
    {
        HouseholdSnapshot h = supplied ?? lab.Sim.HouseholdSnapshot;
        SemanticEvent[] history = suppliedEvents ?? [.. lab.Sim.History];
        Dictionary<PersonId, Person> people = lab.Initial.People.ToDictionary(p => p.Id);
        Dictionary<HouseholdHeadRoleId, PersonId?> occupants = [];
        Dictionary<EventId, SemanticEvent> events = history.ToDictionary(e => e.Id);
        Assert.AreEqual(h.Households.Count, h.HeadRoles.Count);
        Assert.AreEqual(h.HeadRoles.Count, h.HeadRoles.Values.Select(r => r.Household).Distinct().Count());
        foreach (HouseholdHeadRole role in h.HeadRoles.Values)
        {
            Assert.AreEqual(role.Id, h.HeadRoles[role.Id].Id);
            Assert.AreEqual(h.Formations[h.Households[role.Household].Formation].Stamp.Event, role.Origin);
            occupants.Add(role.Id, null);
        }
        foreach (SemanticEvent e in history)
        {
            foreach (EventId cause in e.Causes) Assert.IsTrue(events.TryGetValue(cause, out var parent) && Before(parent, e));
            if (e.HeadTransition is { } transition)
            {
                Assert.AreEqual(transition, h.HeadTransitions[e.Id]);
                Assert.AreEqual(e.Id, transition.Event); Assert.AreEqual(e.Id, transition.Stamp.Event);
                Assert.AreEqual(e.Cycle, transition.Stamp.Time.Cycle); Assert.AreEqual(e.ReactionIndex, transition.Stamp.Time.ReactionIndex);
                Assert.AreEqual(e.RulesVersion, transition.Stamp.RulesVersion); Assert.AreEqual(e.ConfigurationVersion, transition.Stamp.ConfigurationVersion);
                Assert.AreEqual(transition.Household, h.HeadRoles[transition.Role].Household);
                Assert.AreEqual(occupants[transition.Role], transition.Previous);
                if (transition.Occupant is { } nominee)
                {
                    Assert.AreEqual("HouseholdHeadAppointed", e.Kind);
                    SemanticEvent nomination = events.Values.Single(x => x.Kind == "Proposal" && x.Proposal == e.Proposal);
                    Assert.IsInstanceOfType<NominateHouseholdHead>(nomination.Action);
                    var terms = (NominateHouseholdHead)nomination.Action;
                    Assert.AreEqual(terms.Nominee, nominee); Assert.AreEqual(terms.Household, transition.Household);
                    Assert.AreEqual(nomination.Participants.Single(), transition.Nominator);
                    var expected = h.Associations.Values.Where(a => a.Household == transition.Household && Started(a).Cycle < e.Cycle &&
                        (a.End is null || h.Exits[a.End.Value].Stamp.Time.Cycle >= e.Cycle)).Select(a => a.Id).OrderBy(i => i.Value).ToArray();
                    CollectionAssert.AreEqual(expected, transition.Cohort.Select(a => a.Id).OrderBy(i => i.Value).ToArray());
                    Assert.Contains(nominee, transition.Cohort.Select(a => a.Person).ToArray());
                    Assert.Contains(transition.Nominator!.Value, transition.Cohort.Select(a => a.Person).ToArray());
                    Assert.AreEqual(transition.Cohort.Length + 1, transition.Consents.Length);
                    Assert.AreEqual(transition.Consents.Length, transition.Consents.Select(c => (c.Actor, c.Capacity)).Distinct().Count());
                    foreach (SustainingParticipant participant in transition.Cohort)
                    {
                        Assert.IsTrue(Active(participant, e));
                        Assert.IsTrue(transition.Consents.Single(c => c.Actor == participant.Person && c.Capacity == HeadConsentCapacity.Participant).Accepted);
                    }
                    Assert.IsTrue(transition.Consents.Single(c => c.Actor == nominee && c.Capacity == HeadConsentCapacity.Nominee).Accepted);
                    foreach (HeadConsent consent in transition.Consents)
                    {
                        Assert.IsTrue(consent.Accepted); Assert.Contains(consent.Event, e.Causes);
                        SemanticEvent source = events[consent.Event]; Assert.IsTrue(Before(source, e));
                        Assert.AreEqual(e.Proposal, source.Proposal);
                        if (consent.Actor == transition.Nominator)
                        {
                            Assert.AreEqual(nomination.Id, consent.Event);
                            Assert.IsTrue(consent.Capacity == HeadConsentCapacity.Nominee ? terms.NomineeWillingness : terms.ParticipantAcceptance);
                        }
                        else
                        {
                            Assert.AreEqual("HeadConsent", source.Kind); Assert.AreEqual(consent.Actor, source.Participants.Single());
                            Assert.Contains(consent.Capacity == HeadConsentCapacity.Nominee ? "Nominee:True" : "Participant:True", source.Detail);
                        }
                        Assert.IsNotEmpty(consent.RecognitionEvidence);
                        foreach (KnownFact fact in consent.RecognitionEvidence)
                        {
                            Assert.IsTrue(fact.Proposition is HouseholdExistenceFact { Continues: true } hf && hf.Household == transition.Household);
                            Assert.IsTrue(history.Where(x => Before(x, e)).SelectMany(x => x.AcquiredEvidence)
                                .Any(r => r.Actor == consent.Actor && r.Fact == fact));
                        }
                    }
                }
                else
                {
                    Assert.AreEqual("HouseholdHeadVacated", e.Kind);
                    Assert.IsTrue(e.Causes.Select(c => events[c]).Any(c => c.Kind == "HouseholdParticipationEnded" && c.Participants.Single() == transition.Previous));
                }
                occupants[transition.Role] = transition.Occupant;
            }
            if (e.Funding is { } funding)
            {
                Assert.IsTrue(e.Kind is "HouseholdSupport" or "HouseholdMediatedMarriage");
                Assert.AreEqual("SFL-S4-v1", e.RulesVersion);
                Assert.AreEqual(funding.Authority, e.HouseholdContext);
                Assert.AreEqual(funding.Authority.Household, h.HeadRoles[funding.Authority.Role].Household);
                Assert.AreEqual(funding.Authority.Head, occupants[funding.Authority.Role]);
                Assert.IsTrue(funding.Cost > 0);
                long x = funding.Private?.Amount ?? 0;
                Assert.IsTrue(x >= 0 && x <= funding.Cost);
                if (funding.Private is { } privateTerm)
                {
                    Assert.IsTrue(x > 0); Assert.AreEqual(funding.Authority.Head, privateTerm.Owner);
                    Assert.IsTrue(Capacity(people[privateTerm.Owner]) >= x);
                    if (e.Action is HouseholdSupport support) Assert.AreEqual(support.Private, privateTerm);
                    else Assert.IsTrue(e.Causes.Select(c => events[c]).Any(c => c.Kind == "Response" && c.Participants.Single() == privateTerm.Owner &&
                        c.Detail == $"Accept:X:{x:D20}"));
                }
                Assert.AreEqual(funding.Cost - x, funding.Residual);
                var contributors = h.Commitments.Values.Where(c => c.Household == funding.Authority.Household && Active(h.Associations[c.Association], e) &&
                    (c.TerminatedBy is null || !Before(events[c.TerminatedBy.Value], e)) && Created(c, e))
                    .Select(c => (Commitment: c, Capacity: Math.Max(0, Capacity(people[c.Person]) - (c.Person == funding.Authority.Head ? x : 0))))
                    .OrderByDescending(c => c.Capacity).ThenBy(c => c.Commitment.Person.Value).ToArray();
                long remaining = funding.Residual;
                List<CommitmentFundingLeg> expected = [];
                foreach (var c in contributors)
                {
                    long debit = Math.Min(remaining, c.Capacity); remaining -= debit;
                    if (debit > 0) expected.Add(new(c.Commitment.Person, c.Commitment.Id, c.Capacity, debit));
                }
                Assert.AreEqual(0L, remaining);
                CollectionAssert.AreEqual(expected.ToArray(), funding.Commitments.ToArray());
                Dictionary<PersonId, long> deltas = [];
                foreach (var leg in expected) deltas[leg.Person] = checked(deltas.GetValueOrDefault(leg.Person) - leg.Debit);
                if (funding.Private is { } p) deltas[p.Owner] = checked(deltas.GetValueOrDefault(p.Owner) - p.Amount);
                deltas[funding.Recipient] = checked(deltas.GetValueOrDefault(funding.Recipient) + funding.Cost);
                Assert.AreEqual(deltas.Count, e.Material.Length);
                foreach (MaterialChange change in e.Material) Assert.AreEqual(deltas[change.Person], change.After - change.Before);
                Assert.AreEqual(0L, e.Material.Sum(m => m.After - m.Before));
                if (e.Kind == "HouseholdSupport")
                {
                    Assert.AreEqual(1L, funding.Cost); Assert.IsTrue(people[funding.Recipient].NeedsGrain);
                    Assert.IsTrue(h.Associations.Values.Any(a => a.Household == funding.Authority.Household && a.Person == funding.Recipient && Active(a, e)));
                    Assert.IsFalse(lab.Sim.Snapshot.Marriages.Values.Any(m => m.Origin == e.Id));
                    Assert.IsFalse(lab.Sim.Snapshot.Favours.Values.Any(f => f.Origin == e.Id));
                }
                else
                {
                    Assert.IsInstanceOfType<ProposeMediatedMarriage>(e.Action);
                    var terms = (ProposeMediatedMarriage)e.Action;
                    Marriage marriage = lab.Sim.Snapshot.Marriages.Values.Single(m => m.Origin == e.Id);
                    Favour favour = lab.Sim.Snapshot.Favours.Values.Single(f => f.Origin == e.Id);
                    Assert.AreEqual(funding.Recipient, marriage.Groom); Assert.AreEqual(terms.Bride, marriage.Bride);
                    Assert.AreEqual(marriage.Groom, favour.Debtor); Assert.AreEqual(funding.Authority.Head, favour.Holder);
                    Assert.AreNotEqual(marriage.Groom, favour.Holder);
                }
            }
            else if (e.Kind.StartsWith("Household", StringComparison.Ordinal) || e.Kind.StartsWith("Sustaining", StringComparison.Ordinal)) Assert.IsEmpty(e.Material);
            foreach (MaterialChange material in e.Material)
            {
                Assert.AreEqual(people[material.Person].Grain, material.Before); Assert.IsTrue(material.After >= 0);
                people[material.Person] = people[material.Person] with
                {
                    Grain = material.After,
                    NeedsGrain = e.Kind == "Consumption" ? false : material.After > 0 ? false : people[material.Person].NeedsGrain
                };
            }
            if (e.Kind == "MissedConsumption") people[e.Participants.Single()] = people[e.Participants.Single()] with { NeedsGrain = true };
        }
        foreach (var role in h.HeadRoles.Values) Assert.AreEqual(occupants[role.Id], role.Occupant);
        foreach (var p in people) Assert.AreEqual(lab.Sim.Snapshot.People[p.Key].Grain, p.Value.Grain);
        foreach (var commitment in h.Commitments.Values) VerifyOrigin(commitment, events, h);
        VerifyHeadKnowledge(lab, lab.Sim.EpistemicSnapshot);

        SemanticEvent Started(SustainingParticipant a) => events[h.Formations.TryGetValue(a.Origin, out var f) ? f.Stamp.Event : h.Entries[a.Origin].Stamp.Event];
        bool Active(SustainingParticipant a, SemanticEvent e) => Before(Started(a), e) && (a.End is null || !Before(events[h.Exits[a.End.Value].Stamp.Event], e));
        bool Created(HouseholdProvisionCommitment c, SemanticEvent e) => c.Provenance switch
        {
            EndogenousProvisionOrigin o => Before(events[o.Created], e),
            SelfProvisionOrigin o => Before(events[o.Created], e),
            ProvisionFixtureProvenance => true,
            _ => false
        };
    }

    internal static void VerifyHeadKnowledge(Slice4Lab lab, EpistemicSnapshot snapshot)
    {
        var history = lab.Sim.History.ToDictionary(e => e.Id);
        foreach (var actor in snapshot.Actors.Values)
        {
            var groups = actor.Facts.Where(f => f.Proposition is HeadRoleFact).GroupBy(f => ((HeadRoleFact)f.Proposition).Household).ToArray();
            Assert.AreEqual(groups.Length, actor.HeadRecognitions.Length);
            foreach (var group in groups)
            {
                HeadRecognition result = actor.HeadRecognitions.Single(r => r.Household == group.Key);
                var facts = group.Select(f => (HeadRoleFact)f.Proposition).ToArray();
                bool compatible = facts.Select(f => (f.Role, f.Occupant, f.Scope)).Distinct().Count() == 1;
                Assert.AreEqual(compatible ? RecognitionStatus.Recognized : RecognitionStatus.Contested, result.Status);
                Assert.AreEqual(compatible ? facts[0].Role : (HouseholdHeadRoleId?)null, result.Role);
                Assert.AreEqual(compatible ? facts[0].Occupant : null, result.Occupant);
                CollectionAssert.AreEquivalent(group.ToArray(), result.Evidence.ToArray());
                foreach (KnownFact fact in group)
                {
                    Assert.IsTrue(history.Values.SelectMany(e => e.AcquiredEvidence).Any(r => r.Actor == actor.Actor && r.Fact == fact), "Exact head EvidenceId lacks acquisition receipt.");
                    HeadRoleFact proposition = (HeadRoleFact)fact.Proposition;
                    SemanticEvent origin = history[proposition.Transition];
                    Assert.AreEqual(proposition.Transition, fact.Provenance.Origin.Event);
                    Assert.AreEqual(new EvidenceOrder(origin.Cycle, origin.ReactionIndex), fact.Provenance.Origin.Order);
                    Assert.IsNotNull(origin.HeadTransition);
                    Assert.AreEqual(origin.HeadTransition.Role, proposition.Role);
                    Assert.AreEqual(origin.HeadTransition.Household, proposition.Household);
                    Assert.AreEqual(origin.HeadTransition.Occupant, proposition.Occupant);
                    if (fact.Provenance.Route == AcquisitionRoute.Participation) Assert.Contains(actor.Actor, origin.Participants);
                    else
                    {
                        Assert.AreEqual(AcquisitionRoute.Communication, fact.Provenance.Route);
                        Assert.AreEqual(actor.Actor, fact.Provenance.Hops.Last().Recipient);
                        foreach (var hop in fact.Provenance.Hops)
                            Assert.IsTrue(history[hop.Event].TransmittedEvidence.Any(f => f.Proposition == proposition && f.Provenance.Origin == fact.Provenance.Origin));
                    }
                }
            }
        }
    }

    private static long Capacity(Person p) => p.NeedsGrain || p.Grain <= 2 ? 0 : p.Grain - 2;
    private static bool Before(SemanticEvent a, SemanticEvent b) => a.Cycle < b.Cycle || a.Cycle == b.Cycle && a.ReactionIndex < b.ReactionIndex;

    private static void VerifyOrigin(HouseholdProvisionCommitment c, Dictionary<EventId, SemanticEvent> history, HouseholdSnapshot h)
    {
        Assert.AreEqual(c.Person, h.Associations[c.Association].Person); Assert.AreEqual(c.Household, h.Associations[c.Association].Household);
        switch (c.Provenance)
        {
            case ProvisionFixtureProvenance fixture:
                Assert.IsFalse(string.IsNullOrWhiteSpace(fixture.Fixture)); Assert.IsFalse(string.IsNullOrWhiteSpace(fixture.Producer));
                Assert.IsFalse(string.IsNullOrWhiteSpace(fixture.OutputIdentity)); break;
            case EndogenousProvisionOrigin origin:
                SemanticEvent request = history[origin.Request], response = history[origin.Acceptance], created = history[origin.Created];
                Assert.AreEqual("Proposal", request.Kind); Assert.AreEqual("Response", response.Kind); Assert.AreEqual("HouseholdProvisionCommitted", created.Kind);
                Assert.AreEqual(new RequestProvisionCommitment(c.Household, c.Person), request.Action);
                Assert.AreEqual(origin.Authority.Head, request.Participants.Single()); Assert.AreEqual(c.Person, response.Participants.Single());
                Assert.AreEqual("Accept", response.Detail); Assert.AreEqual(origin.Proposal, request.Proposal);
                Assert.AreEqual(request.Proposal, response.Proposal); Assert.AreEqual(response.Proposal, created.Proposal);
                Assert.IsTrue(Before(request, response) && Before(response, created)); Assert.IsEmpty(created.Material);
                Assert.AreEqual(c.Household, origin.Authority.Household); Assert.AreEqual(origin.Authority, created.HouseholdContext); break;
            case SelfProvisionOrigin self:
                SemanticEvent authorization = history[self.Authorization], creation = history[self.Created];
                Assert.IsTrue(self.InstitutionalRequest && self.PrivateAuthorization); Assert.AreEqual(c.Person, self.Authority.Head);
                Assert.AreEqual(c.Household, self.Authority.Household); Assert.AreEqual(self.Authority, creation.HouseholdContext);
                Assert.AreEqual(new AuthorizeOwnProvisionCommitment(c.Household, true, true), authorization.Action);
                Assert.IsTrue(Before(authorization, creation)); Assert.IsEmpty(creation.Material);
                Assert.IsFalse(history.Values.Any(e => e.Proposal == self.Proposal && e.Kind == "Response")); break;
            default: Assert.Fail("Unknown commitment provenance"); break;
        }
    }
}
