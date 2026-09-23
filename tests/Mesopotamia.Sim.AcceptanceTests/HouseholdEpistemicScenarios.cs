using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    private IEnumerable<HouseholdCase> EpistemicCases()
    {
        yield return new("HouseholdRecognitionRoutesAndStaleness", ["040", "041", "043", "044", "045", "047"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab);
            Assert.AreEqual(RecognitionStatus.Unknown, lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitionOf(h));
            lab.Step((1, new CommunicateClaim(P(4), new HeldHouseholdRecognition(h))));
            HouseholdRecognition old = lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitions.Single();
            Assert.AreEqual(RecognitionStatus.Recognized, old.Status);
            Assert.IsTrue(old.Evidence.All(f => f.Provenance.Route == AcquisitionRoute.Communication && f.Provenance.Hops.Single().Sender == P(1)));
            lab.Step((4, new OfferGift(P(1), 1))); // Ordinary action changes attitude, not recognition.
            Assert.IsTrue(old.Evidence.SequenceEqual(lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitions.Single().Evidence));
            Exit(lab, h, 2);
            Assert.IsTrue(old.Evidence.SequenceEqual(lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitions.Single().Evidence));
            lab.Step((1, new CommunicateClaim(P(4), new HeldHouseholdRecognition(h))));
            HouseholdRecognition refreshed = lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitions.Single();
            Assert.AreEqual(RecognitionStatus.Recognized, refreshed.Status);
            Assert.IsTrue(refreshed.Evidence.All(f => f.Provenance.Origin.Order!.CompareTo(old.Evidence[0].Provenance.Origin.Order) > 0));
            Exit(lab, h, 3); Exit(lab, h, 1);
            Assert.AreEqual(RecognitionStatus.Recognized, lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitionOf(h));
            Assert.AreEqual(RecognitionStatus.Unknown, lab.Sim.EpistemicStateOf(P(1)).HouseholdRecognitionOf(h));
            KnownFact dissolved = lab.Sim.EpistemicStateOf(P(1)).Facts.Single(f => f.Proposition is HouseholdExistenceFact { Continues: false });
            lab.Step((1, new CommunicateClaim(P(4), new HeldFact(dissolved.Id))));
            Assert.AreEqual(RecognitionStatus.Unknown, lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitionOf(h));
            Assert.AreEqual(RecognitionStatus.Unknown, lab.Sim.EpistemicStateOf(P(6)).HouseholdRecognitionOf(h));
            Assert.IsFalse(typeof(FactualProposition).IsAssignableFrom(typeof(HouseholdRecognition)));
            Assert.IsFalse(typeof(HouseholdRecognition).GetProperties().Any(p => p.PropertyType == typeof(Attitude) || p.PropertyType == typeof(double)));
        });
        yield return new("ContestedRecognitionAndArrivalPermutation", ["046", "048", "049"], () =>
        {
            foreach (bool reverse in new[] { false, true })
            {
                Lab lab = Form(); HouseholdId h = H(lab); PrepareEntry(lab, h, recognize: false);
                WarrantId formation = lab.Sim.HouseholdSnapshot.Households[h].Formation;
                // Acquisition is not this fixture's assertion target: two held, nondominated reports.
                // The target recipient still acquires both through ordinary communication.
                EvidenceOrigin origin = new(P(6), null, null, "F-S3-NONDOMINATED-REPORT");
                lab.Sim.SupplyHouseholdEvidenceFixture(P(6), new(h, false, formation), origin);
                lab.Fixtures.Add(new { Actor = P(6), Proposition = new HouseholdExistenceFact(h, false, formation), Origin = origin });
                KnownFact contrary = lab.Sim.EpistemicStateOf(P(6)).Facts.Single(f => f.Proposition is HouseholdExistenceFact);
                var positive = (1, (ActionTerms)new CommunicateClaim(P(4), new HeldHouseholdRecognition(h)));
                var negative = (6, (ActionTerms)new CommunicateClaim(P(4), new HeldFact(contrary.Id)));
                lab.Step(reverse ? [negative, positive] : [positive, negative]);
                Assert.AreEqual(RecognitionStatus.Contested, lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitionOf(h));
                Assert.AreEqual(OutcomeKind.Unable, Entry(lab, h, false));
                Assert.AreEqual(RecognitionStatus.Contested, lab.Sim.EpistemicStateOf(P(4)).HouseholdRecognitionOf(h));
                Assert.AreEqual(OutcomeKind.Committed, lab.Step((4, new OfferGift(P(5), 1))).Outcomes.Single().Kind);
            }
            Lab positiveControl = Form(); HouseholdId positiveH = H(positiveControl); PrepareEntry(positiveControl, positiveH);
            Assert.AreEqual(OutcomeKind.Committed, Entry(positiveControl, positiveH, false));
        });
        yield return new("ContinuityEvidencePrecedenceAndIndependentOverlap", ["038", "039"], () =>
        {
            foreach (bool distinct in new[] { false, true })
            {
                Lab lab = Form(); HouseholdId h = H(lab); PrepareEntry(lab, h);
                lab.Step((4, new OfferGift(P(1), 1)));
                Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, false));
                if (distinct) lab.Step((1, new OfferGift(P(4), 1)));
                lab.Declare(2, [1, 4]); lab.Step();
                Assert.AreEqual(distinct ? 2 : 1, lab.Sim.HouseholdSnapshot.Households.Count);
                Assert.AreEqual(HouseholdLifecycle.Active, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle);
            }
        });
        yield return new("ProvisionBackingReserveNeedAndTermination", ["070", "071", "072", "073", "074", "075", "076", "077"], () =>
        {
            foreach ((long grain, long expected) in new[] { (1L, 0L), (2L, 0L), (3L, 1L), (8L, 6L) })
            {
                Assert.AreEqual(expected, HouseholdSnapshot.ExposedCapacity(new(P(1), "reserve", Sex.Male, grain)));
                Assert.AreEqual(0, HouseholdSnapshot.ExposedCapacity(new(P(1), "reserve", Sex.Male, grain, true)));
            }
            Lab lab = Form(); HouseholdId h = H(lab);
            var before = lab.Sim.Snapshot.People.ToDictionary(p => p.Key, p => p.Value.Grain);
            string producedIdentity = Digest(lab);
            foreach (int person in new[] { 1, 2, 3 })
            {
                ProvisionFixtureProvenance provenance = new("F-S3-PREEXISTING-COMMITMENT", "VS-SFL-001:PASS", producedIdentity);
                lab.Sim.SupplyProvisionFixture(P(person), h, provenance);
                lab.Fixtures.Add(new { Person = P(person), Household = h, Provision = provenance });
            }
            Assert.IsTrue(before.All(p => lab.Sim.Snapshot.People[p.Key].Grain == p.Value));
            Assert.AreEqual(new[] { 1, 2, 3 }.Sum(i => Math.Max(0, lab.Sim.Snapshot.People[P(i)].Grain - 2)), lab.Sim.HouseholdSnapshot.MobilizableCapacity(h, lab.Sim.Snapshot));
            HouseholdSnapshot old = lab.Sim.HouseholdSnapshot;
            Exit(lab, h, 2);
            Assert.AreEqual(2, lab.Sim.HouseholdSnapshot.Commitments.Values.Count(c => c.TerminatedBy is null));
            Assert.AreEqual(3, old.Commitments.Values.Count(c => c.TerminatedBy is null));
            Assert.AreEqual(before[P(2)] - 1, lab.Sim.Snapshot.People[P(2)].Grain);
            Exit(lab, h, 3); Exit(lab, h, 1);
            Assert.IsTrue(lab.Sim.HouseholdSnapshot.Commitments.Values.All(c => c.TerminatedBy is not null));
            Assert.AreEqual(0, lab.Sim.HouseholdSnapshot.MobilizableCapacity(h, lab.Sim.Snapshot));
            Assert.IsFalse(lab.Sim.History.Any(e => e.Material.Any(m => m.Meaning.Contains("Household", StringComparison.Ordinal))));
            Assert.IsFalse(typeof(Household).GetProperties().Any(p => p.Name.Contains("Grain", StringComparison.Ordinal) || p.Name.Contains("Treasury", StringComparison.Ordinal)));
        });
    }
}
