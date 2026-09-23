using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    private IEnumerable<HouseholdCase> RepairV2Cases()
    {
        yield return new("RepairB1DetachedParticipationCorruptionsP17P18P19", ["020", "021", "023", "026", "030"], () =>
        {
            foreach (bool invite in new[] { false, true })
            {
                Lab lab = Form(World(8)); HouseholdId h = H(lab);
                PrepareEntry(lab, h);
                // A real post-formation support event with unrelated endpoints is also inadmissible.
                lab.Step((7, new OfferGift(P(8), 1)));
                Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, invite));
                HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
                ParticipationWarrant entry = good.Entries.Values.Single();
                HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
                void Reject(ParticipationWarrant bad) => Assert.Throws<AssertFailedException>(() =>
                    HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good with { Entries = good.Entries.SetItem(entry.Id, bad) }));

                Reject(entry with { Recognition = [] }); // P17: vacuous All must not pass.
                Reject(entry with { Recognition = [entry.Recognition[0], entry.Recognition[0]] });
                KnownFact basis = entry.Recognition[0].Evidence[0];
                HouseholdRecognition fabricated = entry.Recognition[0] with
                {
                    Evidence = [basis with { Provenance = basis.Provenance with { Origin = basis.Provenance.Origin with { Event = new(999999) } } }]
                };
                Reject(entry with { Recognition = [fabricated, entry.Recognition[1]] });
                Reject(entry with { Supports = [] });
                SupportFact support = entry.Supports[0];
                Reject(entry with { Supports = [support with { Event = new(999999), Cycle = 999, Second = P(8), Order = new(999, 0) }] }); // P18 combined.
                Reject(entry with { Supports = [support with { Event = new(999999) }] });
                Reject(entry with { Supports = [support with { Cycle = 999, Order = new(999, 0) }] });
                Reject(entry with { Supports = [support with { Second = P(8) }] });
                SemanticEvent unrelated = lab.Sim.History.Single(e => e.Kind == "Gift" && e.Participants[0] == P(7));
                Reject(entry with { Supports = [new(unrelated.Id, unrelated.Cycle, P(7), P(8), SupportKind.Gift) { Order = new(unrelated.Cycle, unrelated.ReactionIndex) }] });
                SemanticEvent unrelatedAcceptance = lab.Sim.History.First(e => e.Kind == "Response" && e.Detail == "Accept");
                Reject(entry with { Acceptance = unrelatedAcceptance.Id }); // P19.
                Reject(entry with { Proposal = unrelatedAcceptance.Proposal!.Value });
                Reject(entry with { Bridge = P(2) });
                Reject(entry with { Newcomer = P(5) });
                Reject(entry with { Prior = [] });
                Reject(entry with { Residences = [.. entry.Residences.Select(r => r.Person == entry.Newcomer ? r with { Dwelling = new(2) } : r)] });
                Reject(entry with { Ties = [new(entry.Newcomer, entry.Bridge, [new(999999)])] });
                SustainingParticipant added = good.Associations.Values.Single(a => a.Origin == entry.Id);
                Assert.Throws<AssertFailedException>(() => HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles,
                    good with { Associations = good.Associations.SetItem(added.Id, added with { Person = P(5) }) }));
                // Real future support is rejected even if it exists in the final history.
                lab.Step((1, new OfferGift(P(4), 1)));
                SemanticEvent future = lab.Sim.History.Last(e => e.Kind == "Gift");
                good = lab.Sim.HouseholdSnapshot;
                Reject(entry with { Supports = [new(future.Id, future.Cycle, P(1), P(4), SupportKind.Gift) { Order = new(future.Cycle, future.ReactionIndex) }] });
                HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
            }
        });
        yield return new("RepairB2CustomLabelHouseholdProvenance", ["020", "021", "042", "092"], () =>
        {
            foreach (bool invite in new[] { false, true })
                foreach (string label in new[] { "review-custom-config", "SFL-S2-v1", "SFL-S3-v1" })
                {
                    Lab lab = Form(World() with { Configuration = new(label) }); HouseholdId h = H(lab);
                    PrepareEntry(lab, h);
                    // Mixed cycle demonstrates per-action attribution in a single run.
                    CycleResult result = lab.Step((invite ? 1 : 4, invite ? new InviteHouseholdParticipation(h, P(4)) : new RequestHouseholdParticipation(h, P(1))),
                        (5, new OfferGift(P(6), 1)));
                    ParticipationWarrant entry = lab.Sim.HouseholdSnapshot.Entries.Values.Single();
                    DecisionTrace response = result.Decisions.Single(d => d.Context == "Response" && d.Proposal == entry.Proposal);
                    Assert.AreEqual("SFL-S3-v1", response.RulesVersion);
                    Assert.AreEqual(label, response.ConfigurationVersion);
                    Assert.AreEqual(response.RulesVersion, entry.Stamp.RulesVersion);
                    Assert.AreEqual(label, entry.Stamp.ConfigurationVersion);
                    Assert.IsTrue(result.Events.Where(e => e.Proposal == entry.Proposal).All(e => e.RulesVersion == "SFL-S3-v1" && e.ConfigurationVersion == label));
                    DecisionTrace ordinary = result.Decisions.Single(d => d.Actor == P(6));
                    Assert.AreEqual("SFL-S2-v1", ordinary.RulesVersion);
                    Assert.AreEqual(label, ordinary.ConfigurationVersion);
                    Assert.IsTrue(result.Events.Where(e => e.Proposal == ordinary.Proposal).All(e => e.RulesVersion == "SFL-S2-v1"));
                    CycleResult communicated = lab.Step((1, new CommunicateClaim(P(5), new HeldHouseholdRecognition(h))));
                    Assert.AreEqual("SFL-S3-v1", communicated.Events.Single(e => e.Kind == "Communication").RulesVersion);
                    KnownFact fact = lab.Sim.EpistemicStateOf(P(1)).Facts.Single(f => f.Proposition is HouseholdExistenceFact { Continues: true });
                    CycleResult factual = lab.Step((1, new CommunicateClaim(P(6), new HeldFact(fact.Id))));
                    Assert.AreEqual("SFL-S3-v1", factual.Events.Single(e => e.Kind == "Communication").RulesVersion);
                }
        });
        yield return new("RepairC1RemoteBearerRetainsStaleRecognition", ["030", "043", "044", "045"], () =>
        {
            foreach (bool invite in new[] { false, true })
            {
                InitialWorld world = World();
                world = WithKnowledge(world with { Residences = [.. world.Residences.Select(r => r.Person == P(6) ? r with { Dwelling = new(2) } : r)] });
                Lab lab = Form(world); HouseholdId h = H(lab);
                lab.Step((2, new MoveResidence(P(6), new(2))));
                HouseholdRecognition old = lab.Sim.EpistemicStateOf(P(2)).HouseholdRecognitions.Single();
                PrepareEntry(lab, h);
                Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, invite));
                HouseholdSnapshot state = lab.Sim.HouseholdSnapshot;
                Assert.IsTrue(state.Participants(h).Any(a => a.Person == P(2)));
                HouseholdRecognition stale = lab.Sim.EpistemicStateOf(P(2)).HouseholdRecognitions.Single();
                Assert.AreEqual(RecognitionStatus.Recognized, stale.Status);
                Assert.IsTrue(old.Evidence.SequenceEqual(stale.Evidence));
                ContinuationWarrant continuation = state.Continuations.Values.Single();
                SemanticEvent continued = lab.Sim.History.Single(e => e.Id == continuation.Stamp.Event);
                CollectionAssert.AreEquivalent(new[] { P(1), P(4) }, continued.Participants.ToArray());
                Assert.DoesNotContain(P(2), continued.Participants);
                foreach (int actor in new[] { 1, 4 })
                    Assert.IsTrue(lab.Sim.EpistemicStateOf(P(actor)).HouseholdRecognitions.Single().Evidence.All(f => f.Provenance.Origin.Event == continued.Id));
                Assert.IsTrue(continuation.Recognition.SelectMany(r => r.Evidence).All(f => f.Provenance.Origin.Order!.CompareTo(continuation.Stamp.Time) < 0));
                lab.Step((1, new CommunicateClaim(P(2), new HeldHouseholdRecognition(h))));
                HouseholdRecognition updated = lab.Sim.EpistemicStateOf(P(2)).HouseholdRecognitions.Single();
                Assert.AreEqual(RecognitionStatus.Recognized, updated.Status);
                Assert.IsTrue(updated.Evidence.Any(f => f.Provenance.Origin.Event == continued.Id && f.Provenance.Route == AcquisitionRoute.Communication &&
                    f.Provenance.Hops.Last().Recipient == P(2)));
                // A newer report adds evidence; inherited precedence retains older direct knowledge.
                Assert.IsTrue(old.Evidence.All(updated.Evidence.Contains));
                Assert.IsFalse(old.Evidence.SequenceEqual(updated.Evidence));
            }
        });
    }
}
