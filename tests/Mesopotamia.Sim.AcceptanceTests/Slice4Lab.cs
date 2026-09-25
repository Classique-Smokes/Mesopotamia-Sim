using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed class Slice4Lab
{
    internal InitialWorld Initial { get; }
    internal Simulation Sim { get; }
    internal List<CycleResult> Cycles { get; } = [];
    private long nextProposal = 1;
    internal static PersonId P(int n) => new(n);
    internal HouseholdId H => Sim.HouseholdSnapshot.Households.Keys.Single();
    internal HouseholdHeadRole Role => Sim.HouseholdSnapshot.HeadRoles.Values.Single();
    internal HouseholdDecisionContext Context => new(H, Role.Id, Role.Occupant!.Value);

    internal Slice4Lab(bool need = false, bool reverse = false, int count = 4)
    {
        Person[] people = [.. Enumerable.Range(1, count).Select(i => new Person(P(i), $"P{i}", i == 2 ? Sex.Female : Sex.Male, 100))];
        Residence[] homes = [.. people.Select(p => new Residence(new(100 + p.Id.Value), p.Id, new(1)))];
        Kinship[] ties = [new(new(201), P(1), P(2), KinshipKind.Sibling), new(new(202), P(2), P(3), KinshipKind.Sibling)];
        long evidence = 1000;
        FactualProposition[] lower = [.. homes.Select(r => new ResidenceFact(r.Person, r.Dwelling)), .. ties.Select(k => new KinshipFact(k))];
        Initial = new([.. reverse ? people.Reverse() : people], [new(new(1))], [.. reverse ? homes.Reverse() : homes], [], [.. ties], [],
            need ? [new(1, 7, P(2), -95)] : [], new("IMP-0004-LAB-v1"))
        {
            Candidates = [new(new(1), [P(1), P(2), P(3)])],
            Knowledge = [.. people.Select(p => new InitialKnowledge(p.Id, [.. lower.Select(f =>
                new KnownFact(new(evidence++), f, new(AcquisitionRoute.Fixture, new(null, null, new(0, 0), "F-S4-LOWER"), [])))]))]
        };
        Sim = new(Initial);
        Step(1, new OfferGift(P(3), 1));
        Step(3, new OfferGift(P(2), 1));
        SendFact(3, 1, f => f is SupportFact { Cycle: 2 });
        SendFact(3, 2, f => f is SupportFact { Cycle: 1 });
        HouseholdOracle.Verify(Initial, Sim, Cycles);
        Assert.AreEqual(1, Sim.HouseholdSnapshot.Households.Count);
        Assert.IsNull(Role.Occupant);
    }

    internal Proposal Proposal(int actor, ActionTerms terms, bool household = false) => new(new(nextProposal++), P(actor), terms)
    { HouseholdContext = household ? Context : null };
    internal CycleResult Run(CycleInput input)
    {
        CycleResult result = Sim.RunCycle(input); Cycles.Add(result); return result;
    }
    internal CycleResult Step(int actor, ActionTerms terms, bool household = false) => Run(new([Proposal(actor, terms, household)]));
    internal void Empty() => Run(CycleInput.Empty);
    internal void SendFact(int sender, int recipient, Func<FactualProposition, bool> predicate)
    {
        KnownFact fact = Sim.EpistemicStateOf(P(sender)).Facts.First(f => predicate(f.Proposition));
        Step(sender, new CommunicateClaim(P(recipient), new HeldFact(fact.Id)));
    }
    internal void Appoint(int nominee = 1)
    {
        CycleResult result = Step(1, new NominateHouseholdHead(H, P(nominee), true, nominee == 1));
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
        Assert.AreEqual(P(nominee), Role.Occupant);
    }
    internal void Commit(int contributor = 3)
    {
        int head = checked((int)Role.Occupant!.Value.Value);
        CycleResult result = Step(head, contributor == head ? new AuthorizeOwnProvisionCommitment(H, true, true) : new RequestProvisionCommitment(H, P(contributor)), true);
        Assert.AreEqual(OutcomeKind.Committed, result.Outcomes.Single().Kind);
    }
    internal void InformGroom()
    {
        Step(1, new CommunicateClaim(P(4), new HeldHouseholdRecognition(H)));
        Step(1, new CommunicateClaim(P(4), new HeldHeadRecognition(H)));
        SendFact(2, 4, f => f is SustainingParticipationFact { Person.Value: 2, Current: true });
    }
}
