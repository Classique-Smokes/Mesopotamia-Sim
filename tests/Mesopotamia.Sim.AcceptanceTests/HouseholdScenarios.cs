using System.Collections.Immutable;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record HouseholdCase(string Name, string[] Ids, Action Run);
internal sealed partial class HouseholdScenarios
{
    private readonly List<Lab> labs = [];
    internal List<object> FixtureEvidence { get; } = [];
    internal List<object> ProducerEvidence { get; } = [];
    internal void Begin() => labs.Clear();
    internal void Audit(string scenario)
    {
        foreach (Lab lab in labs)
        {
            HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, declarations: lab.Declarations);
            FixtureEvidence.Add(new
            {
                Scenario = scenario,
                lab.Initial.People,
                lab.Initial.Dwellings,
                lab.Initial.Residences,
                lab.Initial.Kinships,
                lab.Initial.Marriages,
                lab.Initial.Attitudes,
                lab.Initial.Knowledge,
                lab.Initial.Candidates,
                lab.Initial.Inputs,
                lab.Initial.Configuration,
                CandidateDeclarations = lab.Declarations,
                AdditionalControlledWrites = lab.Fixtures,
                EndogenousHouseholdWrites = 0,
                ProposalSchedule = lab.Sim.History.Where(e => e.Kind == "Proposal").Select(e => new { e.Cycle, e.Proposal, e.Participants, e.Detail }),
                OutputIdentity = Digest(lab),
                IndependentWarrantAudit = "PASS",
                StableCycles = lab.Cycles.Count
            });
        }
    }
    private Lab Create(InitialWorld? initial = null, Simulation.ReactionChallenge challenge = Simulation.ReactionChallenge.None)
    {
        Lab lab = new(initial ?? World(), challenge); labs.Add(lab); return lab;
    }
    private static PersonId P(int i) => new(i);
    private static InitialWorld World(int count = 6, int[]? core = null, long grain = 100, bool reverse = false)
    {
        core ??= [1, 2, 3];
        Person[] people = [.. Enumerable.Range(1, count).Select(i => new Person(P(i), $"Person{i}", i % 2 == 1 ? Sex.Male : Sex.Female, grain))];
        Residence[] homes = [.. people.Select(p => new Residence(new(100 + p.Id.Value), p.Id, new(1)))];
        // Declared lower-level ties cover the canonical A-B-C chain and the D/E/F bridges.
        List<Kinship> kin = [];
        for (int i = 2; i <= count; i++) kin.Add(new(new(200 + i), P(i <= 3 ? i - 1 : i - 3), P(i), KinshipKind.Sibling));
        InitialWorld world = new([.. reverse ? people.Reverse() : people], [new(new(1)), new(new(2))], [.. reverse ? homes.Reverse() : homes], [], [.. kin], [], [], new("SFL-S3-v1"))
        { Candidates = core.Length == 0 ? [] : [new(new(1), [.. core.Select(P)])] };
        return WithKnowledge(world);
    }
    private static InitialWorld WithKnowledge(InitialWorld world)
    {
        long evidence = 1000;
        FactualProposition[] lower = [.. world.Residences.Select(r => new ResidenceFact(r.Person, r.Dwelling)),
            .. world.Kinships.Select(k => new KinshipFact(k)), .. world.Marriages.Select(m => new MarriageFact(m)), .. world.Attitudes.Select(a => new AttitudeFact(a))];
        return world with
        {
            Knowledge = [.. world.People.Select(p => new InitialKnowledge(p.Id,
                [.. lower.Select(f => new KnownFact(new(evidence++), f, new(AcquisitionRoute.Fixture, new(null, null, new(0, 0), "F-S3-LOWER-LEVEL"), [])))]))]
        };
    }
    private Lab Form(InitialWorld? world = null, Simulation.ReactionChallenge challenge = Simulation.ReactionChallenge.None)
    {
        Lab lab = Create(world, challenge);
        CanonicalFormation(lab);
        Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Households.Count);
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, declarations: lab.Declarations);
        ProducerEvidence.Add(new
        {
            Producer = "VS-SFL-001",
            AcceptanceId = "S3-001-FORMATION-POSITIVE",
            Result = "PASS",
            FixtureAudit = "lower-level-only",
            Configuration = lab.Initial.Configuration.Version,
            OutputIdentity = Digest(lab)
        });
        return lab;
    }
    private static void CanonicalFormation(Lab lab, bool communicate = true)
    {
        lab.Step((1, new OfferGift(P(3), 1)));
        lab.Step((3, new OfferGift(P(2), 1)));
        if (communicate)
        {
            lab.SendSupport(3, 1, 2);
            lab.SendSupport(3, 2, 1);
        }
    }
    private static string Digest(Lab lab) => Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new
    {
        Cycle = lab.Sim.Snapshot.Cycle,
        Events = lab.Sim.History,
        People = lab.Sim.Snapshot.People.Values.OrderBy(p => p.Id.Value),
        Residences = lab.Sim.Snapshot.Residences.Values.OrderBy(r => r.Id.Value),
        Attitudes = lab.Sim.Snapshot.Attitudes.Values.OrderBy(a => a.Id.Value),
        Debts = lab.Sim.Snapshot.Debts.Values.OrderBy(d => d.Id.Value),
        Favours = lab.Sim.Snapshot.Favours.Values.OrderBy(f => f.Id.Value),
        Actors = lab.Sim.EpistemicSnapshot.Actors.Values.OrderBy(a => a.Actor.Value),
        Households = lab.Sim.HouseholdSnapshot.Households.Values.OrderBy(h => h.Id.Value),
        Formations = lab.Sim.HouseholdSnapshot.Formations.Values.OrderBy(f => f.Id.Value),
        Associations = lab.Sim.HouseholdSnapshot.Associations.Values.OrderBy(a => a.Id.Value),
        Entries = lab.Sim.HouseholdSnapshot.Entries.Values.OrderBy(e => e.Id.Value),
        Exits = lab.Sim.HouseholdSnapshot.Exits.Values.OrderBy(e => e.Id.Value),
        Continuations = lab.Sim.HouseholdSnapshot.Continuations.Values.OrderBy(c => c.Id.Value),
        Lineages = lab.Sim.HouseholdSnapshot.Lineages.Values.OrderBy(l => l.Id.Value),
        Commitments = lab.Sim.HouseholdSnapshot.Commitments.Values.OrderBy(c => c.Id.Value)
    }))));
    private static HouseholdId H(Lab lab, long candidate = 1) => lab.Sim.HouseholdSnapshot.Formations.Values.Single(f => f.Candidate.Value == candidate).Household;
    private static void PrepareEntry(Lab lab, HouseholdId h, int newcomer = 4, int bridge = 1, bool recognize = true, bool support = true)
    {
        if (recognize) lab.Step((bridge, new CommunicateClaim(P(newcomer), new HeldHouseholdRecognition(h))));
        if (support) lab.Step((bridge, new OfferGift(P(newcomer), 1)));
    }
    private static OutcomeKind Entry(Lab lab, HouseholdId h, bool invite, int newcomer = 4, int bridge = 1) =>
        lab.Step((invite ? bridge : newcomer, invite ? new InviteHouseholdParticipation(h, P(newcomer)) : new RequestHouseholdParticipation(h, P(bridge)))).Outcomes.Single().Kind;
    private static void Exit(Lab lab, HouseholdId h, int person) => lab.Step((person, new EndHouseholdParticipation(h)));
    private static void SoleBearer(Lab lab, HouseholdId h) { Exit(lab, h, 2); Exit(lab, h, 3); }

    internal IEnumerable<HouseholdCase> All()
    {
        yield return new("CanonicalThreeFounderCausalFormation", ["001", "010", "011", "012", "013", "014", "080", "082"], () =>
        {
            Lab lab = Form(World(3, grain: 12));
            HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
            Assert.AreEqual(HouseholdLifecycle.Active, h.Households.Values.Single().Lifecycle);
            Assert.AreEqual(3, h.Associations.Count);
            Assert.AreEqual(4L, h.Formations.Values.Single().Stamp.Time.Cycle);
            Assert.IsTrue(lab.Sim.History.Where(e => e.Kind == "CandidateRecognitionEstablished").All(e => e.Cycle == 4));
            EventId lastDelivery = lab.Sim.History.Last(e => e.Kind == "Communication").Id;
            Assert.IsTrue(lab.Sim.History.Any(e => e.Kind == "CandidateRecognitionEstablished" && e.Causes.Contains(lastDelivery)));
            Assert.IsTrue(lab.Sim.EpistemicSnapshot.Actors.Values.All(a => a.HouseholdRecognitionOf(H(lab)) == RecognitionStatus.Recognized));
            string[] names = typeof(Simulation).Assembly.GetTypes().Select(t => t.Name).ToArray();
            Assert.IsFalse(names.Any(n => n.Contains("HeadRole", StringComparison.Ordinal) || n.Contains("HouseholdDecisionContext", StringComparison.Ordinal)));
        });
        yield return new("FoundingCardinalityAndPredicateAblations", ["002", "003", "004", "005", "006"], () =>
        {
            Lab one = Create(World(2, [1])); one.Step((1, new OfferGift(P(2), 1))); one.Step((2, new OfferGift(P(1), 1)));
            Assert.IsEmpty(one.Sim.HouseholdSnapshot.Households);
            Lab two = Create(World(2, [1, 2])); two.Step((1, new OfferGift(P(2), 1))); two.Step((2, new OfferGift(P(1), 1)));
            Assert.AreEqual(1, two.Sim.HouseholdSnapshot.Households.Count);
            InitialWorld residence = World();
            residence = WithKnowledge(residence with { Residences = [.. residence.Residences.Select(r => r.Person == P(3) ? r with { Dwelling = new(2) } : r)] });
            Lab noResidence = Create(residence); CanonicalFormation(noResidence); Assert.IsEmpty(noResidence.Sim.HouseholdSnapshot.Households);
            Lab noTie = Create(WithKnowledge(World() with { Kinships = [] })); CanonicalFormation(noTie); Assert.IsEmpty(noTie.Sim.HouseholdSnapshot.Households);
            Lab oneSupport = Create(World(2, [1, 2])); oneSupport.Step((1, new OfferGift(P(2), 1))); oneSupport.Step(); Assert.IsEmpty(oneSupport.Sim.HouseholdSnapshot.Households);
            Lab sameCycle = Create(World(2, [1, 2])); sameCycle.Step((1, new OfferGift(P(2), 1)), (2, new OfferGift(P(1), 1))); Assert.IsEmpty(sameCycle.Sim.HouseholdSnapshot.Households);
            Lab noRecognition = Create(); CanonicalFormation(noRecognition, false); Assert.IsEmpty(noRecognition.Sim.HouseholdSnapshot.Households);
            Assert.AreEqual(RecognitionStatus.Recognized, noRecognition.Sim.EpistemicStateOf(P(3)).RecognitionOf(new CandidateId(1)));
        });
        yield return new("SupportMeaningClosedCensus", ["015"], () =>
        {
            foreach (ActionTerms terms in new ActionTerms[] { new OfferGift(P(2), 1), new RequestGiftOrHelp(P(2), 1), new OfferLoan(P(2), 1), new RequestLoan(P(2), 1), new RelationshipMediatedReciprocalHelp(P(2), 1) })
            {
                Lab lab = Create(World(2, [1, 2])); lab.Step((1, new OfferGift(P(2), 1))); lab.Step((1, terms));
                Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Households.Count);
            }
            Lab favour = Create(World(2, [1, 2]));
            favour.Step((1, new OfferBenefitForFavor(P(2), 1)));
            RelationId f = favour.Sim.Snapshot.Favours.Values.Single().Id;
            favour.Step((1, new CallFavor(f, new Farm())));
            favour.Step((2, new OfferGift(P(1), 1)));
            Assert.IsTrue(favour.Sim.HouseholdSnapshot.Formations.Values.Single().Supports.Any(s => s.Kind == SupportKind.FavourFulfilment));
            foreach (string forbidden in new[] { "HouseholdSupport", "Repayment", "ExplicitBenefitForFavor", "Farm", "ExogenousGrain" })
                Assert.IsNull(OrdinarySupport.From(new(new(1), 1, 1, forbidden, null, [P(1), P(2)], [], [], "", "test")));
        });
        yield return new("BothParticipationDirectionsAndPrerequisiteAblations", ["020", "021", "022", "023", "024", "025", "026", "042", "092"], () =>
        {
            foreach (bool invite in new[] { false, true })
                foreach (string missing in new[] { "none", "recognition", "bridge", "acceptance", "residence", "tie", "support" })
                {
                    InitialWorld world = World();
                    if (missing == "residence") world = WithKnowledge(world with { Residences = [.. world.Residences.Select(r => r.Person == P(4) ? r with { Dwelling = new(2) } : r)] });
                    if (missing == "tie") world = WithKnowledge(world with { Kinships = [.. world.Kinships.Where(k => k.First != P(4) && k.Second != P(4))] });
                    Lab lab = Form(world); HouseholdId h = H(lab);
                    PrepareEntry(lab, h, recognize: missing != "recognition", support: missing != "support");
                    if (missing == "bridge") Exit(lab, h, 1);
                    ActionTerms action = invite ? new InviteHouseholdParticipation(h, P(4)) : new RequestHouseholdParticipation(h, P(1));
                    CycleResult result = lab.StepWithResponse(invite ? 1 : 4, action, missing == "acceptance" ? ResponseChoice.Decline : ResponseChoice.Accept);
                    Assert.AreEqual(missing == "none", result.Outcomes.Single().Kind == OutcomeKind.Committed, $"{invite}/{missing}");
                    Assert.AreEqual(missing == "none" ? 1 : 0, lab.Sim.HouseholdSnapshot.Entries.Count);
                    if (missing == "none") Assert.IsTrue(result.Decisions.Single(d => d.Context == "Response").SubjectiveInputs.Any(s => s.Contains("Basis:ActorEpistemicState", StringComparison.Ordinal)));
                }
        });
        yield return new("CompleteTurnoverAndNonErasure", ["027", "028", "030", "031", "064"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab);
            lab.Step((1, new OfferLoan(P(2), 1)));
            lab.Step((1, new OfferBenefitForFavor(P(3), 1)));
            var debt = lab.Sim.Snapshot.Debts.Keys.ToArray(); var favours = lab.Sim.Snapshot.Favours.Keys.ToArray();
            for (int founder = 1; founder <= 3; founder++)
            {
                PrepareEntry(lab, h, founder + 3, founder);
                Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, founder % 2 == 0, founder + 3, founder));
                Exit(lab, h, founder);
            }
            Assert.IsTrue(lab.Sim.HouseholdSnapshot.Participants(h).Select(a => a.Person.Value).ToHashSet().SetEquals(new long[] { 4, 5, 6 }));
            Assert.AreEqual(6, lab.Sim.HouseholdSnapshot.Continuations.Count);
            Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Households.Count);
            Assert.IsTrue(debt.All(lab.Sim.Snapshot.Debts.ContainsKey)); Assert.IsTrue(favours.All(lab.Sim.Snapshot.Favours.ContainsKey));
            Assert.IsTrue(lab.Initial.Residences.SequenceEqual(lab.Sim.Snapshot.Residences.Values.OrderBy(r => r.Id.Value)));
            Assert.AreEqual(lab.Initial.Kinships.Length, lab.Sim.Snapshot.Kinships.Count);
        });
        yield return new("ResidenceDoesNotChangeParticipation", ["029"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab);
            lab.Step((4, new MoveResidence(P(6), new(1)))); // Already at destination: no association write.
            InitialWorld w = World();
            w = WithKnowledge(w with { Residences = [.. w.Residences.Select(r => r.Person == P(6) ? r with { Dwelling = new(2) } : r)] });
            Lab moved = Form(w); HouseholdId hm = H(moved);
            moved.Step((1, new MoveResidence(P(6), new(2))));
            Assert.AreEqual(new DwellingId(2), moved.Sim.Snapshot.HomeOf(P(1)));
            Assert.AreEqual(3, moved.Sim.HouseholdSnapshot.Participants(hm).Length);
            Assert.IsEmpty(moved.Sim.HouseholdSnapshot.Exits);
            Assert.AreEqual(3, lab.Sim.HouseholdSnapshot.Participants(h).Length);
        });
        yield return new("InactiveReactivationAndSameCycleHandoff", ["033", "034", "035", "084", "090"], () =>
        {
            foreach (bool handoff in new[] { false, true })
                foreach (bool exitFirst in new[] { false, true })
                {
                    Lab lab = Form(); HouseholdId h = H(lab); SoleBearer(lab, h);
                    Assert.AreEqual(HouseholdLifecycle.Inactive, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle);
                    PrepareEntry(lab, h);
                    if (handoff)
                    {
                        var entry = (4, (ActionTerms)new RequestHouseholdParticipation(h, P(1)));
                        var exit = (1, (ActionTerms)new EndHouseholdParticipation(h));
                        CycleResult cycle = lab.Step(exitFirst ? [exit, entry] : [entry, exit]);
                        Assert.IsTrue(cycle.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
                        Assert.IsTrue(cycle.Events.Single(e => e.Kind == "HouseholdParticipation").ReactionIndex < cycle.Events.Single(e => e.Kind == "HouseholdParticipationEnded").ReactionIndex);
                        Assert.IsFalse(cycle.Events.Any(e => e.TechnicalFallback));
                        Assert.AreEqual(P(4), lab.Sim.HouseholdSnapshot.Participants(h).Single().Person);
                        Assert.AreEqual(HouseholdLifecycle.Inactive, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle);
                    }
                    else { Assert.AreEqual(OutcomeKind.Committed, Entry(lab, h, false)); Assert.AreEqual(HouseholdLifecycle.Active, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle); }
                    Assert.AreEqual(1, lab.Sim.HouseholdSnapshot.Households.Count);
                }
        });
        yield return new("BrokenBridgeDissolutionAndNewIdentity", ["032", "036", "037"], () =>
        {
            Lab lab = Form(); HouseholdId h = H(lab); PrepareEntry(lab, h); SoleBearer(lab, h); Exit(lab, h, 1);
            Assert.AreEqual(HouseholdLifecycle.Dissolved, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle);
            Assert.AreNotEqual(OutcomeKind.Committed, Entry(lab, h, false));
            lab.Declare(2, [1, 2]);
            lab.Step((1, new OfferGift(P(2), 1))); lab.Step((2, new OfferGift(P(1), 1)));
            Assert.AreNotEqual(h, H(lab, 2));
            Assert.AreEqual(HouseholdLifecycle.Dissolved, lab.Sim.HouseholdSnapshot.Households[h].Lifecycle);
        });
        foreach (HouseholdCase c in EpistemicCases()) yield return c;
        foreach (HouseholdCase c in LineageCases()) yield return c;
        foreach (HouseholdCase c in StructuralCases()) yield return c;
        foreach (HouseholdCase c in AdversarialCases()) yield return c;
        foreach (HouseholdCase c in RepairV2Cases()) yield return c;
        foreach (HouseholdCase c in RepairV3Cases()) yield return c;
    }

    private sealed class Lab(InitialWorld initial, Simulation.ReactionChallenge challenge)
    {
        internal InitialWorld Initial { get; } = initial;
        internal Simulation Sim { get; } = new(initial) { Challenge = challenge };
        internal List<CycleResult> Cycles { get; } = [];
        internal List<object> Fixtures { get; } = [];
        internal List<CandidateReferent> Declarations { get; } = [];
        private long nextProposal = 1;
        internal CycleResult Step(params (int Actor, ActionTerms Terms)[] proposals)
        {
            CycleResult result = Sim.RunCycle(new([.. proposals.Select(p => new Proposal(new(nextProposal++), P(p.Actor), p.Terms))]));
            Cycles.Add(result); return result;
        }
        internal CycleResult StepWithResponse(int actor, ActionTerms terms, ResponseChoice response)
        {
            Proposal p = new(new(nextProposal++), P(actor), terms);
            CycleResult result = Sim.RunCycle(new([p]) { Responses = ImmutableDictionary<ProposalId, ResponseChoice>.Empty.Add(p.Id, response) });
            Cycles.Add(result); return result;
        }
        internal void SendSupport(int sender, int recipient, long supportCycle)
        {
            KnownFact evidence = Sim.EpistemicStateOf(P(sender)).Facts.First(f => f.Proposition is SupportFact s && s.Cycle == supportCycle);
            Step((sender, new CommunicateClaim(P(recipient), new HeldFact(evidence.Id))));
        }
        internal void Declare(long candidate, int[] core)
        {
            CandidateReferent c = new(new(candidate), [.. core.Select(P)]); Declarations.Add(c); Sim.DeclareCandidate(c);
        }
    }
}
