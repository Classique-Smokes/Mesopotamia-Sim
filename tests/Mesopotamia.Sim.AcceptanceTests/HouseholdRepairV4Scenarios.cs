using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    internal List<object> RepairV4Evidence { get; } = [];
    private IEnumerable<HouseholdCase> RepairV4Cases()
    {
        yield return new("RepairV4ConnectedHouseholdCompatibleLoans", ["085", "087", "090"], () =>
        {
            string? expected = null;
            foreach (bool swapIds in new[] { false, true })
                foreach (bool reverseInputs in new[] { false, true })
                    foreach (bool reverseWorld in new[] { false, true })
                    {
                        InitialWorld world = World(6, reverse: reverseWorld);
                        Lab lab = Form(world);
                        Proposal[] proposals = [new(new(swapIds ? 102 : 101), P(1), new OfferLoan(P(3), 2)),
                            new(new(swapIds ? 101 : 102), P(2), new OfferLoan(P(3), 3))];
                        CycleResult result = lab.Sim.RunCycle(new([.. reverseInputs ? proposals.Reverse() : proposals])); lab.Cycles.Add(result);
                        Assert.AreEqual(2, result.Outcomes.Length);
                        Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
                        Assert.IsTrue(result.Events.All(e => !e.TechnicalFallback));
                        string actual = JsonSerializer.Serialize(new
                        {
                            People = result.State.People.Values.OrderBy(p => p.Id.Value),
                            Homes = result.State.Residences.Values.OrderBy(r => r.Person.Value),
                            Attitudes = result.State.Attitudes.Values.OrderBy(a => a.From.Value).ThenBy(a => a.To.Value).Select(a => new { a.From, a.To, a.Value }),
                            Debts = result.State.Debts.Values.OrderBy(d => d.Creditor.Value).Select(d => new { d.Creditor, d.Debtor, d.Original, d.Remaining, d.CommittedCycle, d.DueReviewed }),
                            Households = result.Households!.Households.Values.OrderBy(h => h.Id.Value),
                            Evidence = result.Epistemic!.Actors.OrderBy(a => a.Key.Value).Select(a => new
                            {
                                a.Key,
                                Facts = a.Value.Facts.Select(f => JsonSerializer.Serialize(new
                                {
                                    Proposition = NormalizeLoanEvidence(f.Proposition),
                                    f.Provenance.Route,
                                    f.Provenance.Origin.Source,
                                    f.Provenance.Origin.Fixture,
                                    Cycle = f.Provenance.Origin.Order?.Cycle,
                                    Hops = f.Provenance.Hops.Select(hop => new { hop.Sender, hop.Recipient, hop.Delivered.Cycle })
                                })).Order(StringComparer.Ordinal),
                                CandidateRecognition = a.Value.Recognitions.Select(r => new { r.Candidate, r.Status }),
                                HouseholdRecognition = a.Value.HouseholdRecognitions.Select(r => new { r.Household, r.Status })
                            })
                        });
                        if (expected is null) expected = actual; else Assert.AreEqual(expected, actual);
                        RepairV4Evidence.Add(new { Family = "ConnectedLoans", swapIds, reverseInputs, reverseWorld, Result = "BOTH_COMMITTED_NO_FALLBACK_SEMANTIC_STATE_EQUAL" });
                    }
        });
        yield return new("RepairV4LifecycleReferences", ["035", "091"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab);
            Check("Active");
            SoleBearer(lab, h); Check("Inactive");
            PrepareEntry(lab, h); Entry(lab, h, false); Check("Reactivated");
            Exit(lab, h, 4); Exit(lab, h, 1); Check("Dissolved");
            void Check(string control)
            {
                HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
                Household value = good.Households[h];
                HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
                RepairV4Evidence.Add(new { Family = "Lifecycle", control, Result = "PASS" });
                Reject("nonexistent-event", value with { LifecycleEvent = new(888888) });
                Reject("negative-time", value with { LifecycleTime = new(-17, 0) });
                Reject("wrong-microstep", value with { LifecycleTime = value.LifecycleTime with { ReactionIndex = value.LifecycleTime.ReactionIndex + 1 } });
                Reject("wrong-event-kind", value with { LifecycleEvent = lab.Sim.History.First().Id });
                if (control != "Active") Reject("stale-formation-event", value with { LifecycleEvent = good.Formations[value.Formation].Stamp.Event, LifecycleTime = good.Formations[value.Formation].Stamp.Time });
                void Reject(string name, Household bad) => RejectV4(lab, "Lifecycle-" + control, name, good with { Households = good.Households.SetItem(h, bad) });
            }
        });
        yield return new("RepairV4ConnectedHouseholdPositiveFallbackControls", ["090"], () =>
        {
            foreach (bool swapped in new[] { false, true })
                foreach (string control in new[] { "capacity", "communication", "favour-debt" })
                {
                    Lab lab = Form();
                    (int, ActionTerms)[] actions;
                    if (control == "capacity")
                    {
                        long available = lab.Sim.Snapshot.People[P(1)].Grain / 2 + 1;
                        actions = [(2, new RequestLoan(P(1), available)), (3, new RequestLoan(P(1), available))];
                    }
                    else if (control == "communication")
                    {
                        lab.Step((1, new OfferLoan(P(2), 2)));
                        Debt debt = lab.Sim.Snapshot.Debts.Values.Single();
                        KnownFact held = lab.Sim.EpistemicStateOf(P(1)).Facts.Single(f => f.Proposition is DebtFact);
                        actions = [(1, new CommunicateClaim(P(3), new HeldFact(held.Id))), (2, new RepayDebt(debt.Id, 1))];
                    }
                    else
                    {
                        lab.Step((1, new OfferBenefitForFavor(P(2), 1)), (3, new OfferLoan(P(2), 2)));
                        lab.Step((2, new OfferBenefitForFavor(P(1), 1)));
                        Favour favour = lab.Sim.Snapshot.Favours.Values.Single(f => f.Holder == P(1));
                        Debt debt = lab.Sim.Snapshot.Debts.Values.Single();
                        actions = [(1, new CallFavor(favour.Id, new RepayDebt(debt.Id, 1))), (2, new CancelReciprocalFavours(P(1)))];
                    }
                    CycleResult result = lab.Step([.. swapped ? actions.Reverse() : actions]);
                    Assert.AreEqual(2, result.Outcomes.Length);
                    Assert.IsTrue(result.Outcomes.All(o => o.Kind is OutcomeKind.Committed or OutcomeKind.InvalidatedAtResolution), control);
                    Assert.IsTrue(result.Outcomes.All(o => result.Events.Single(e => e.Id == o.Event).TechnicalFallback), control);
                    RepairV4Evidence.Add(new { Family = "PositiveFallback", control, swapped, Result = "FALLBACK_RETAINED" });
                }
        });
        yield return new("RepairV4LifecycleWrongHousehold", ["035", "091"], () =>
        {
            Lab lab = Create(LineageWorld());
            HouseholdId first = FormGroup(lab, 1, [1, 2]);
            HouseholdId second = FormGroup(lab, 2, [3, 4]);
            Exit(lab, first, 1); Exit(lab, second, 3);
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            Household source = good.Households[first], other = good.Households[second];
            RejectV4(lab, "Lifecycle", "another-household-event", good with
            {
                Households = good.Households.SetItem(first,
                source with { LifecycleEvent = other.LifecycleEvent, LifecycleTime = other.LifecycleTime })
            });
            RejectV4(lab, "Lifecycle", "published-state-mismatch", good with
            {
                Households = good.Households.SetItem(first,
                source with { Lifecycle = HouseholdLifecycle.Active })
            });
        });
        yield return new("RepairV4SameCycleRecognitionIdentity", ["030", "034", "091"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab); SoleBearer(lab, h); PrepareEntry(lab, h);
            lab.Step((4, new RequestHouseholdParticipation(h, P(1))), (1, new EndHouseholdParticipation(h)));
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            ContinuationWarrant c = good.Continuations.Values.MaxBy(c => c.Stamp.Time)!;
            Assert.IsTrue(c.Recognition.SelectMany(r => r.Evidence).All(f => f.Provenance.Origin.Order!.Cycle == c.Stamp.Time.Cycle));
            HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
            ContinuationWarrant bad = c with
            {
                Recognition = [c.Recognition[0] with
            { Evidence = [.. c.Recognition[0].Evidence.Select(f => f with { Id = new(888888) })] }]
            };
            RejectV4(lab, "Recognition", "fabricated-same-cycle-id", good with { Continuations = good.Continuations.SetItem(c.Id, bad) });
            RepairV4Evidence.Add(new { Family = "Recognition", Control = "same-cycle-handoff", Result = "PASS" });
        });
        yield return new("RepairV4SameCycleCommunicatedIdentity", ["020", "030", "091"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab); PrepareEntry(lab, h); Exit(lab, h, 2);
            CycleResult cycle = lab.Step((2, new CommunicateClaim(P(4), new HeldHouseholdRecognition(h))),
                (4, new RequestHouseholdParticipation(h, P(1))));
            Assert.IsTrue(cycle.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            ParticipationWarrant entry = good.Entries.Values.Single();
            Assert.IsTrue(entry.Recognition[0].Evidence.Any(f => f.Provenance.Hops.Last().Delivered.Cycle == cycle.State.Cycle));
            HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
            ParticipationWarrant bad = entry with
            {
                Recognition = [entry.Recognition[0] with
            { Evidence = [.. entry.Recognition[0].Evidence.Select(f => f with { Id = new(888888) })] }, entry.Recognition[1]]
            };
            RejectV4(lab, "Recognition", "fabricated-same-cycle-communication-id", good with { Entries = good.Entries.SetItem(entry.Id, bad) });
            RepairV4Evidence.Add(new { Family = "Recognition", Control = "same-cycle-communication", Result = "PASS" });
        });
        yield return new("RepairV4OtherOrdinaryAllocations", ["085", "087", "090"], () =>
        {
            foreach (bool swapped in new[] { false, true })
                foreach (string kind in new[] { "favours", "marriages" })
                {
                    InitialWorld world = World();
                    if (kind == "marriages") world = WithKnowledge(world with
                    {
                        Kinships = [.. world.Kinships.Where(k => k.Second != P(4) && k.Second != P(6))],
                        Attitudes = [new(new(301), P(1), P(4), 100), new(new(302), P(4), P(1), 100),
                            new(new(303), P(3), P(6), 100), new(new(304), P(6), P(3), 100)]
                    });
                    Lab lab = Form(world);
                    (int, ActionTerms)[] actions = kind == "favours" ? [(1, new OfferBenefitForFavor(P(3), 2)), (2, new OfferBenefitForFavor(P(3), 3))] :
                        [(1, new ProposeMarriage(P(4), 2)), (3, new ProposeMarriage(P(6), 3))];
                    CycleResult result = lab.Step([.. swapped ? actions.Reverse() : actions]);
                    Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed), kind);
                    Assert.IsTrue(result.Events.All(e => !e.TechnicalFallback), kind);
                    RepairV4Evidence.Add(new { Family = "OtherAllocations", kind, swapped, Result = "BOTH_COMMITTED_NO_FALLBACK" });
                }
        });
        yield return new("RepairV4RecognitionIdentity", ["020", "030", "091"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab);
            PrepareEntry(lab, h); Entry(lab, h, false);
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            ParticipationWarrant entry = good.Entries.Values.Single();
            ParticipationWarrant bad = entry with
            {
                Recognition = [entry.Recognition[0] with
            { Evidence = [.. entry.Recognition[0].Evidence.Select(f => f with { Id = new(888888) })] }, entry.Recognition[1]]
            };
            RejectV4(lab, "Recognition", "fabricated-held-id", good with { Entries = good.Entries.SetItem(entry.Id, bad) });
        });
    }
    private void RejectV4(Lab lab, string family, string corruption, HouseholdSnapshot detached)
    {
        Assert.Throws<AssertFailedException>(() => HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, detached, lab.Declarations), corruption);
        RepairV4Evidence.Add(new { Family = family, Corruption = corruption, Result = "REJECTED_BY_CHECKER" });
    }
}
