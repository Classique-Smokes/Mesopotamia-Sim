using System.Collections.Immutable;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Slice5Scenarios
{
    private void Detect(SimulationCheckpoint original, SimulationCheckpoint mutant, string name, CycleInput[] suffix,
        Action<Simulation, Simulation> dependentAssertion, Func<Simulation>? producer = null)
    {
        Simulation control = producer?.Invoke() ?? OmissionWorld();
        Slice5Oracle.Same(original.Events, control.History, "uninterrupted producer history");
        Simulation changed = Simulation.RestoreCheckpoint(CheckpointCodec.Encode(mutant), original.Bootstrap.Configuration);
        foreach (CycleInput input in suffix)
        {
            control.RunCycle(input); changed.RunCycle(input);
        }
        Assert.IsFalse(control.IsFaulted || changed.IsFaulted, name);
        Assert.ThrowsExactly<AssertFailedException>(() => dependentAssertion(control, changed), name + " must reach its intended dependent assertion");
        Mutations.Add(new
        {
            Name = name,
            Classification = "semantic-mismatch",
            CaptureCycle = original.Cycle,
            ReachedCycle = control.Snapshot.Cycle,
            Suffix = suffix.Select(i => i.Proposals),
            IntendedAssertion = "test-owned causal outcome/history equality",
            ControlPassed = true,
            Continuable = true,
            Original = original,
            Mutant = mutant
        });
    }

    private static Simulation OmissionWorld()
    {
        Simulation sim = new(World(inputs: [new(1, 5, P(1), 7)]));
        sim.RunCycle(new([Proposal(10, 1, new OfferLoan(P(2), 3))]));
        sim.RunCycle(new([Proposal(11, 1, new OfferBenefitForFavor(P(3), 1))]));
        sim.RunCycle(new([Proposal(12, 1, new OfferGift(P(2), 1))]));
        return sim;
    }

    private void OmissionCampaign()
    {
        Simulation sim = OmissionWorld();
        _ = Capture(sim, "OmissionProducer", "Public loan, favour and gift, future input at cycle 5");
        SimulationCheckpoint c = CheckpointCodec.Decode(sim.CaptureCheckpoint());
        KnownFact fact = sim.EpistemicStateOf(P(1)).Facts.First(f => f.Proposition is SupportFact);
        Detect(c, c with
        {
            Epistemic = c.Epistemic with
            {
                Actors = [.. c.Epistemic.Actors.Select(a => a.Actor == P(1) ? a with { Facts = [.. a.Facts.Where(f => f.Id != fact.Id)] } : a)]
            }
        }, "omit-held-subjective", [new([Proposal(100, 1, new CommunicateClaim(P(3), new HeldFact(fact.Id)))])],
            (a, b) => Slice5Oracle.Same(a.History.Where(e => e.Proposal == new ProposalId(100)).ToArray(),
                b.History.Where(e => e.Proposal == new ProposalId(100)).ToArray(), "held claim outcome"));
        Detect(c, c with { Bootstrap = c.Bootstrap with { Inputs = [] } }, "omit-future-input",
            [CycleInput.Empty, CycleInput.Empty], (a, b) => Assert.AreEqual(a.Snapshot.People[P(1)].Grain, b.Snapshot.People[P(1)].Grain, "due input material"));
        Detect(c, c with { World = c.World with { Debts = [.. c.World.Debts.Select(d => d with { DueReviewed = true })] } },
            "omit-debt-review", [CycleInput.Empty], (a, b) => Assert.AreEqual(
                a.History.Count(e => e.Kind == "DebtSocialDueReview"), b.History.Count(e => e.Kind == "DebtSocialDueReview"), "due review count"));
        Favour favour = c.World.Favours.Single();
        Detect(c, c with { World = c.World with { Favours = [favour with { Outstanding = false }] } }, "omit-outstanding-favour",
            [new([Proposal(100, 1, new CallFavor(favour.Id, new Farm()))])],
            (a, b) => Assert.AreEqual(a.Snapshot.People[P(3)].Grain, b.Snapshot.People[P(3)].Grain, "called favour farm"));
        Detect(c, c with { NextEvent = c.NextEvent + 10 }, "event-frontier",
            [CycleInput.Empty], (a, b) => Assert.AreEqual(a.History.Last().Id, b.History.Last().Id, "generated event"));
        Detect(c, c with { NextProposal = c.NextProposal + 10 }, "proposal-frontier",
            [new([]) { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(P(1), new()) }],
            (a, b) => Assert.AreEqual(a.History.Last(e => e.Kind == "Proposal").Proposal, b.History.Last(e => e.Kind == "Proposal").Proposal, "generated proposal"));
        Detect(c, c with { Epistemic = c.Epistemic with { NextEvidence = c.Epistemic.NextEvidence + 10 } }, "evidence-frontier",
            [CycleInput.Empty], (a, b) => Slice5Oracle.Same(a.EpistemicStateOf(P(1)).Facts, b.EpistemicStateOf(P(1)).Facts, "generated evidence"));
        Detect(c, c with { World = c.World with { NextRelation = c.World.NextRelation + 10 } }, "relation-frontier",
            [new([Proposal(100, 1, new OfferLoan(P(3), 1))])],
            (a, b) => Slice5Oracle.Same(a.Snapshot.Debts, b.Snapshot.Debts, "generated relation"));
        Detect(c, c with { World = c.World with { Attitudes = [.. c.World.Attitudes.Where(a => a.From != a.To)] } }, "omit-diagonal-attitude",
            [CycleInput.Empty, CycleInput.Empty], (a, b) => Slice5Oracle.Same(a.History.Where(e => e.Kind == "AttitudeDecay").ToArray(),
                b.History.Where(e => e.Kind == "AttitudeDecay").ToArray(), "diagonal decay history"));
        Simulation forgot = Simulation.RestoreCheckpoint(CheckpointCodec.Encode(c with { UsedProposals = [.. c.UsedProposals.Where(p => p.Value != 10)] }), sim.Configuration);
        Assert.ThrowsExactly<ArgumentException>(() => sim.RunCycle(new([Proposal(10, 1, new OfferGift(P(1), 1))])));
        Assert.AreEqual(OutcomeKind.InvalidTerms, forgot.RunCycle(new([Proposal(10, 1, new OfferGift(P(1), 1))])).Outcomes.Single().Kind);
        Mutations.Add(new { Name = "omit-used-proposal", Classification = "semantic-mismatch", Continuable = true, IntendedAssertion = "duplicate proposal rejected by uninterrupted control, accepted by mutant" });

        Slice4Lab need = HistoricalNeedLab();
        SimulationCheckpoint baseline = CheckpointCodec.Decode(need.Sim.CaptureCheckpoint());
        _ = Capture(need.Sim, "RefusalOmissionProducer", "Verified historical unfunded dowry after refusal");
        Detect(baseline, baseline with
        {
            Households = baseline.Households with
            { ProvisionRefusals = [.. baseline.Households.ProvisionRefusals.Select(r => r with { MaterialNeedChange = null })] }
        },
            "omit-historical-need", [CycleInput.Empty, CycleInput.Empty,
                new([Proposal(1000, 1, new RequestProvisionCommitment(need.H, P(2)), need.Context)])],
            (a, b) => Assert.AreEqual(a.HouseholdSnapshot.Commitments.Count, b.HouseholdSnapshot.Commitments.Count, "reconsideration commitment"),
            () => HistoricalNeedLab().Sim);

        Slice4Lab household = new(); household.Appoint();
        SimulationCheckpoint h = CheckpointCodec.Decode(household.Sim.CaptureCheckpoint());
        CycleInput acquire = new([Proposal(1000, 1, new RequestProvisionCommitment(household.H, P(3)), household.Context)]);
        _ = Capture(household.Sim, "RoleOmissionProducer", "Verified formation and unanimous appointment");
        Detect(h, h with
        {
            Households = h.Households with
            { HeadRoles = [.. h.Households.HeadRoles.Select(r => r with { Occupant = null })] }
        }, "omit-role-occupant", [acquire],
            (a, b) => Assert.AreEqual(a.HouseholdSnapshot.Commitments.Count, b.HouseholdSnapshot.Commitments.Count, "role-dependent acquisition"), Appointed);
        Detect(h, h with { Households = h.Households with { NextCommitment = h.Households.NextCommitment + 10 } }, "commitment-frontier", [acquire],
            (a, b) => Slice5Oracle.Same(a.HouseholdSnapshot.Commitments.Keys.ToArray(), b.HouseholdSnapshot.Commitments.Keys.ToArray(), "commitment allocation"), Appointed);
        static Simulation Appointed() { Slice4Lab fresh = new(); fresh.Appoint(); return fresh.Sim; }
    }

    private void StaleDerived()
    {
        Slice4Lab lab = new(); lab.Appoint();
        Simulation restored = Capture(lab.Sim, "StaleDerivedProducer", new { lab.Initial, lab.Inputs.Count });
        EpistemicSnapshot stale = restored.EpistemicSnapshot with
        {
            Actors = restored.EpistemicSnapshot.Actors.SetItem(P(1), restored.EpistemicStateOf(P(1)) with
            {
                Facts = [.. restored.EpistemicStateOf(P(1)).Facts.Where(f => f.Proposition is not HeadRoleFact)],
                HeadRecognitions = []
            })
        };
        typeof(Simulation).GetField("publishedEpistemic", BindingFlags.Instance | BindingFlags.NonPublic)!.SetValue(restored, stale);
        CycleInput input = new([Proposal(1000, 1, new CommunicateClaim(P(4), new HeldHeadRecognition(lab.H)))]);
        CycleResult result = Pair(lab.Sim, restored, input);
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        // Show that the stale material is consequential if promoted to held authority.
        SimulationCheckpoint current = CheckpointCodec.Decode(lab.Sim.CaptureCheckpoint());
        Assert.IsNotEmpty(current.Epistemic.Actors.Single(a => a.Actor == P(1)).Facts.Where(f => f.Proposition is HeadRoleFact));
        Mutations.Add(new
        {
            Name = "stale-head-recognition",
            Classification = "stale-derived-ignored",
            Continuable = true,
            IntendedAssertion = "same head-Recognition communication gate and delivery despite stale published Recognition"
        });
    }
}
