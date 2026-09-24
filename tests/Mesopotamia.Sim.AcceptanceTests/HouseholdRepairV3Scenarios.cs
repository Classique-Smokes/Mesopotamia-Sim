using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class HouseholdScenarios
{
    internal List<object> RepairV3Evidence { get; } = [];

    private void RejectWarrant(Lab lab, string family, string corruption, HouseholdSnapshot detached)
    {
        // Construction succeeds outside the assertion. Only the independent checker
        // may reject the detached output, and only an assertion counts as rejection.
        Assert.Throws<AssertFailedException>(() => HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, detached, lab.Declarations), corruption);
        RepairV3Evidence.Add(new { Family = family, Corruption = corruption, Result = "REJECTED_BY_CHECKER" });
    }

    private IEnumerable<HouseholdCase> RepairV3Cases()
    {
        yield return new("RepairV3DetachedFormationCorruptions", ["001", "010", "011", "012", "013", "014", "080", "091"], () =>
        {
            Lab lab = Form();
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            FormationWarrant f = good.Formations.Values.Single();
            void Reject(string name, FormationWarrant bad) => RejectWarrant(lab, "Formation", name, good with { Formations = good.Formations.SetItem(f.Id, bad) });
            Reject("empty-recorded-ties", f with { Ties = [] });
            Reject("disconnected-recorded-ties", f with { Ties = [f.Ties[0]] });
            Reject("invented-tie-relation", f with { Ties = [f.Ties[0] with { Relations = [new(999999)] }, .. f.Ties.Skip(1)] });
            Reject("wrong-tie-pair", f with { Ties = [f.Ties[0] with { Second = P(6) }, .. f.Ties.Skip(1)] });
            Reject("duplicate-founder-recognition", f with { Recognition = [f.Recognition[0], f.Recognition[0], f.Recognition[2]] });
            Reject("empty-recognition-evidence", f with { Recognition = [f.Recognition[0] with { Evidence = [] }, .. f.Recognition.Skip(1)] });
            Reject("wrong-recognition-candidate", f with { Recognition = [f.Recognition[0] with { Candidate = new(999999) }, .. f.Recognition.Skip(1)] });
            Reject("nonexistent-candidate", f with { Candidate = new(999999) });
            Reject("fabricated-earliest-evidence", f with { EarliestEvidence = new(-99, 0) });
            Reject("nonexistent-formation-stamp", f with { Stamp = f.Stamp with { Event = new(999999) } });
            Reject("wrong-formation-time", f with { Stamp = f.Stamp with { Time = new(1, 0) } });
            Reject("invented-rules", f with { Stamp = f.Stamp with { RulesVersion = "invented" } });
            Reject("invented-configuration", f with { Stamp = f.Stamp with { ConfigurationVersion = "invented" } });
            Reject("wrong-founders", f with { Founders = [P(1), P(2), P(6)] });
            Reject("wrong-dwelling", f with { Dwelling = new(2) });
            SupportFact s = f.Supports[0];
            Reject("real-support-wrong-endpoints", f with { Supports = [s with { First = s.Second, Second = s.First }, .. f.Supports.Skip(1)] });
            Reject("real-support-wrong-kind", f with { Supports = [s with { Kind = SupportKind.Loan }, .. f.Supports.Skip(1)] });
            Reject("real-support-wrong-cycle", f with { Supports = [s with { Cycle = 99 }, .. f.Supports.Skip(1)] });
            Reject("real-support-wrong-order", f with { Supports = [s with { Order = new(99, 0) }, .. f.Supports.Skip(1)] });
            KnownFact fact = f.Recognition[0].Evidence[0];
            Reject("fabricated-evidence-origin", f with
            {
                Recognition = [f.Recognition[0] with
            { Evidence = [fact with { Provenance = fact.Provenance with { Origin = fact.Provenance.Origin with { Event = new(999999) } } }, .. f.Recognition[0].Evidence.Skip(1)] }, .. f.Recognition.Skip(1)]
            });
            SustainingParticipant a = good.Associations.Values.First();
            RejectWarrant(lab, "Formation", "wrong-association-founder", good with { Associations = good.Associations.SetItem(a.Id, a with { Person = P(6) }) });
            RejectWarrant(lab, "Formation", "wrong-association-household", good with { Associations = good.Associations.SetItem(a.Id, a with { Household = new(999999) }) });
            RejectWarrant(lab, "Formation", "wrong-association-origin", good with { Associations = good.Associations.SetItem(a.Id, a with { Origin = new(999999) }) });
            HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
            RepairV3Evidence.Add(new { Family = "Formation", Control = "uncorrupted", Result = "PASS" });
        });
        yield return new("RepairV3DetachedExitContinuationCorruptions", ["028", "030", "031", "064", "091"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab); Exit(lab, h, 1);
            HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
            ContinuationWarrant c = good.Continuations.Values.Single();
            void Reject(string name, ContinuationWarrant bad) => RejectWarrant(lab, "Continuation", name, good with { Continuations = good.Continuations.SetItem(c.Id, bad) });
            Reject("empty-recognition", c with { Recognition = [] });
            Reject("recognized-empty-evidence", c with { Recognition = [c.Recognition[0] with { Evidence = [] }, .. c.Recognition.Skip(1)] });
            Reject("duplicate-bridge-recognition", c with { Recognition = [c.Recognition[0], c.Recognition[0]] });
            Reject("nonexistent-continuation-stamp", c with { Stamp = c.Stamp with { Event = new(999999) } });
            Reject("invented-rules", c with { Stamp = c.Stamp with { RulesVersion = "invented" } });
            Reject("invented-configuration", c with { Stamp = c.Stamp with { ConfigurationVersion = "invented" } });
            Reject("wrong-continuation-time", c with { Stamp = c.Stamp with { Time = new(1, 0) } });
            Reject("nonexistent-previous", c with { Previous = new(999999) });
            Reject("nonexistent-transition", c with { Transition = new(999999) });
            Reject("empty-prior", c with { Prior = [] });
            Reject("empty-successor", c with { Successor = [] });
            Reject("false-historical-bridge", c with { Bridges = [P(1)] });
            Reject("wrong-household", c with { Household = new(999999) });
            HouseholdRecognition r = c.Recognition[0]; KnownFact fact = r.Evidence[0];
            Reject("invented-bridge-evidence-origin", c with
            {
                Recognition = [r with { Evidence = [fact with
            { Provenance = fact.Provenance with { Origin = fact.Provenance.Origin with { Event = new(999999) } } }] }, .. c.Recognition.Skip(1)]
            });
            HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
            RepairV3Evidence.Add(new { Family = "Continuation", Control = "uncorrupted", Result = "PASS" });
        });
        yield return new("RepairV3DetachedLineageCorruptions", ["050", "053", "057", "059", "064", "091"], () =>
        {
            foreach (bool consolidation in new[] { false, true })
            {
                Lab lab = Create(LineageWorld());
                HouseholdId first = FormGroup(lab, 1, consolidation ? [1, 2] : [1, 2, 3]);
                HouseholdId? second = consolidation ? FormGroup(lab, 2, [3, 4]) : null;
                Exit(lab, first, 1); Exit(lab, first, 2);
                if (second is { } other) { Exit(lab, other, 3); Exit(lab, other, 4); }
                HouseholdId successor = FormGroup(lab, 3, consolidation ? [1, 3] : [1, 2]);
                HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
                LineageWarrant l = good.Lineages.Values.Single(x => x.Successor == successor);
                FormationWarrant f = good.Formations[l.Formation];
                string family = consolidation ? "Consolidation" : "Division";
                void Reject(string name, LineageWarrant bad) => RejectWarrant(lab, family, name, good with { Lineages = good.Lineages.SetItem(l.Id, bad) });
                Reject("successor-formation-as-fresh-support", l with { FreshEvidence = [f.Stamp.Event] });
                Reject("nonexistent-lineage-stamp", l with { Stamp = l.Stamp with { Event = new(999999) } });
                Reject("invented-rules", l with { Stamp = l.Stamp with { RulesVersion = "invented" } });
                Reject("invented-configuration", l with { Stamp = l.Stamp with { ConfigurationVersion = "invented" } });
                Reject("wrong-lineage-time", l with { Stamp = l.Stamp with { Time = new(1, 0) } });
                Reject("wrong-successor", l with { Successor = first });
                Reject("wrong-formation", l with { Formation = good.Households[first].Formation });
                Reject("wrong-predecessors", l with { Predecessors = [successor] });
                Reject("wrong-source-actor", l with { Sources = [l.Sources[0] with { Founder = P(8) }, .. l.Sources.Skip(1)] });
                Reject("wrong-source-predecessor", l with { Sources = [l.Sources[0] with { Predecessor = successor }, .. l.Sources.Skip(1)] });
                Reject("nonexistent-source-exit", l with { Sources = [l.Sources[0] with { ParticipationEnd = new(999999) }, .. l.Sources.Skip(1)] });
                Reject("duplicate-source", l with { Sources = [l.Sources[0], l.Sources[0]] });
                Reject("stale-support", l with { FreshEvidence = [good.Formations[good.Households[first].Formation].Supports[0].Event] });
                HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good, lab.Declarations);
                RepairV3Evidence.Add(new { Family = family, Control = "uncorrupted", Result = "PASS" });
            }
        });
        yield return new("RepairV3DisconnectedHouseholdCompatibleLoans", ["085", "087", "090"], () =>
        {
            string? expected = null;
            foreach (bool swapIds in new[] { false, true })
                foreach (bool reverseInputs in new[] { false, true })
                    foreach (bool reverseWorld in new[] { false, true })
                    {
                        InitialWorld world = World(6, reverse: reverseWorld);
                        world = WithKnowledge(world with
                        {
                            Kinships = [.. world.Kinships.Where(k => k.First.Value <= 3 && k.Second.Value <= 3)],
                            Residences = [.. world.Residences.Select(r => r.Person.Value > 3 ? r with { Dwelling = new(2) } : r)]
                        });
                        Lab lab = Form(world);
                        Proposal[] proposals = [new(new(swapIds ? 102 : 101), P(4), new OfferLoan(P(6), 2)),
                            new(new(swapIds ? 101 : 102), P(5), new OfferLoan(P(6), 3))];
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
                        RepairV3Evidence.Add(new { Family = "DisconnectedLoans", swapIds, reverseInputs, reverseWorld, Result = "BOTH_COMMITTED_NO_FALLBACK_SEMANTIC_STATE_EQUAL" });
                    }
        });
        yield return new("RepairV3DisconnectedHouseholdPositiveFallbackControls", ["090"], () =>
        {
            foreach (bool swapped in new[] { false, true })
                foreach (string control in new[] { "capacity", "communication", "favour-debt" })
                {
                    Lab lab = Form();
                    (int, ActionTerms)[] actions;
                    if (control == "capacity")
                    {
                        long available = lab.Sim.Snapshot.People[P(4)].Grain / 2 + 1;
                        actions = [(5, new RequestLoan(P(4), available)), (6, new RequestLoan(P(4), available))];
                    }
                    else if (control == "communication")
                    {
                        lab.Step((4, new OfferLoan(P(5), 2)));
                        Debt debt = lab.Sim.Snapshot.Debts.Values.Single();
                        KnownFact held = lab.Sim.EpistemicStateOf(P(4)).Facts.Single(f => f.Proposition is DebtFact);
                        actions = [(4, new CommunicateClaim(P(6), new HeldFact(held.Id))), (5, new RepayDebt(debt.Id, 1))];
                    }
                    else
                    {
                        lab.Step((4, new OfferBenefitForFavor(P(5), 1)), (6, new OfferLoan(P(5), 2)));
                        lab.Step((5, new OfferBenefitForFavor(P(4), 1)));
                        Favour favour = lab.Sim.Snapshot.Favours.Values.Single(f => f.Holder == P(4));
                        Debt debt = lab.Sim.Snapshot.Debts.Values.Single();
                        actions = [(4, new CallFavor(favour.Id, new RepayDebt(debt.Id, 1))), (5, new CancelReciprocalFavours(P(4)))];
                    }
                    CycleResult result = lab.Step([.. swapped ? actions.Reverse() : actions]);
                    Assert.AreEqual(2, result.Outcomes.Length);
                    Assert.IsTrue(result.Outcomes.All(o => o.Kind is OutcomeKind.Committed or OutcomeKind.InvalidatedAtResolution), control);
                    Assert.IsTrue(result.Outcomes.All(o => result.Events.Single(e => e.Id == o.Event).TechnicalFallback), control);
                    RepairV3Evidence.Add(new { Family = "PositiveFallback", control, swapped, Result = "FALLBACK_RETAINED" });
                }
        });
    }

    private static FactualProposition NormalizeLoanEvidence(FactualProposition fact) => fact switch
    {
        // Compare accepted factual contents without allocation identities or the
        // microstep numbers exchanged by the two compatible loan commits.
        AttitudeFact a => new AttitudeFact(a.Attitude with { Id = new(0) }),
        KinshipFact k => new KinshipFact(k.Kinship with { Id = new(0) }),
        DebtFact d => new DebtFact(d.Debt with { Id = new(0), Origin = new(0) }),
        SupportFact s => s with { Event = new(0), Order = new(s.Cycle, 0) },
        ParticipationFact p => new ParticipationFact(p.Outcome with { Event = new(0), Proposal = new(0) }),
        _ => fact
    };
}
