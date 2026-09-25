using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed class Slice4Lab
{
    internal InitialWorld Initial { get; }
    internal Simulation Sim { get; }
    internal List<CycleResult> Cycles { get; } = [];
    internal List<CycleInput> Inputs { get; } = [];
    internal List<AcquiredFact> FixtureHeadReports { get; } = [];
    internal List<string> BoundaryChallenges { get; } = [];
    internal bool FormationProducerVerified { get; private set; }
    private long nextProposal = 1;
    private readonly int personOffset;
    internal static PersonId P(int n) => new(n);
    internal PersonId Id(int n) => new(n + personOffset);
    internal HouseholdId H => Sim.HouseholdSnapshot.Households.Keys.Single();
    internal HouseholdHeadRole Role => Sim.HouseholdSnapshot.HeadRoles.Values.Single();
    internal HouseholdDecisionContext Context => new(H, Role.Id, Role.Occupant!.Value);

    internal Slice4Lab(bool need = false, bool reverse = false, int count = 4, ImmutableArray<GrainInput> inputs = default, bool bridge = false, int offset = 0,
        bool secondHousehold = false, bool strongMarriage = false, long groomGrain = 100)
    {
        personOffset = offset;
        PersonId P(int n) => Id(n);
        Person[] people = [.. Enumerable.Range(1, count).Select(i => new Person(P(i), $"P{i}", i == 2 ? Sex.Female : Sex.Male, i == 4 ? groomGrain : 100))];
        Residence[] homes = [.. people.Select(p => new Residence(new(100 + p.Id.Value), p.Id, new(1)))];
        Kinship[] ties = [new(new(201 + offset), P(1), P(2), KinshipKind.Sibling), new(new(202 + offset), P(2), P(3), KinshipKind.Sibling)];
        if (bridge) ties = [.. ties, new(new(203 + offset), P(1), P(4), KinshipKind.Sibling)];
        if (secondHousehold) ties = [.. ties, new(new(204 + offset), P(4), P(5), KinshipKind.Sibling),
            new(new(205 + offset), P(5), P(6), KinshipKind.Sibling), new(new(206 + offset), P(1), P(4), KinshipKind.Sibling)];
        long evidence = 1000;
        FactualProposition[] lower = [.. homes.Select(r => new ResidenceFact(r.Person, r.Dwelling)), .. ties.Select(k => new KinshipFact(k))];
        Initial = new([.. reverse ? people.Reverse() : people], [new(new(1))], [.. reverse ? homes.Reverse() : homes],
            strongMarriage ? [new(new(401), P(2), P(4), 100), new(new(402), P(4), P(2), 100)] : [], [.. ties], [],
            !inputs.IsDefault ? inputs : need ? [new(1, 7, P(2), -95)] : [], new("IMP-0004-LAB-v1"))
        {
            Candidates = secondHousehold ? [new(new(1), [P(1), P(2), P(3)]), new(new(2), [P(4), P(5), P(6)])] : [new(new(1), [P(1), P(2), P(3)])],
            Knowledge = [.. people.Select(p => new InitialKnowledge(p.Id, [.. lower.Select(f =>
                new KnownFact(new(evidence++), f, new(AcquisitionRoute.Fixture, new(null, null, new(0, 0), "F-S4-LOWER"), [])))]))]
        };
        Sim = new(Initial);
        Slice4FixtureAudit.Register(this);
        Step(1, new OfferGift(P(3), 1));
        Step(3, new OfferGift(P(2), 1));
        SendFact(3, 1, f => f is SupportFact { Cycle: 2 });
        SendFact(3, 2, f => f is SupportFact { Cycle: 1 });
        HouseholdOracle.Verify(Initial, Sim, Cycles);
        Assert.AreEqual(1, Sim.HouseholdSnapshot.Households.Count);
        Assert.IsNull(Role.Occupant);
        FormationProducerVerified = true;
    }

    internal Proposal Proposal(int actor, ActionTerms terms, bool household = false) => new(new(nextProposal++), Id(actor), terms)
    { HouseholdContext = household ? Context : null };
    internal CycleResult Run(CycleInput input)
    {
        Inputs.Add(input);
        CycleResult result = Sim.RunCycle(input); Cycles.Add(result); return result;
    }
    internal void SupplyHeadReport(PersonId actor, HeadRoleFact fact, EvidenceOrigin origin)
    {
        Sim.SupplyHeadEvidenceFixture(actor, fact, origin);
        FixtureHeadReports.AddRange(Sim.EpistemicStateOf(actor).Facts.Where(f => f.Proposition == fact && f.Provenance.Origin == origin)
            .Select(f => new AcquiredFact(actor, f)));
    }
    internal CycleResult Step(int actor, ActionTerms terms, bool household = false) => Run(new([Proposal(actor, terms, household)]));
    internal void Empty() => Run(CycleInput.Empty);
    internal void SendFact(int sender, int recipient, Func<FactualProposition, bool> predicate)
    {
        KnownFact fact = Sim.EpistemicStateOf(Id(sender)).Facts.First(f => predicate(f.Proposition));
        Step(sender, new CommunicateClaim(Id(recipient), new HeldFact(fact.Id)));
    }
    internal void Appoint(int nominee = 1)
    {
        CycleResult result = Step(1, new NominateHouseholdHead(H, Id(nominee), true, nominee == 1));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        Assert.AreEqual(Id(nominee), Role.Occupant);
    }
    internal void Commit(int contributor = 3)
    {
        int head = checked((int)Role.Occupant!.Value.Value - personOffset);
        CycleResult result = Step(head, contributor == head ? new AuthorizeOwnProvisionCommitment(H, true, true) : new RequestProvisionCommitment(H, Id(contributor)), true);
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
    }
    internal void InformGroom()
    {
        Step(1, new CommunicateClaim(Id(4), new HeldHouseholdRecognition(H)));
        Step(1, new CommunicateClaim(Id(4), new HeldHeadRecognition(H)));
        SendFact(2, 4, f => f is SustainingParticipationFact { Current: true } p && p.Person == Id(2));
    }
}
