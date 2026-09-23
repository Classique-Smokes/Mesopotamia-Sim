using System.Collections.Immutable;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private IEnumerable<Scenario> AttitudeEventCases()
    {
        yield return new("FixedAttitudeEventMatrix", ["S1-097-EVENTS"], () =>
        {
            foreach (bool request in new[] { false, true })
            {
                CycleResult gift = Create(World()).RunCycle(new([request ? P(1, 2, new RequestGiftOrHelp(new(1), 1)) : P(1, 1, new OfferGift(new(2), 1))]));
                Equal(10, gift.State.AttitudeOf(new(2), new(1)));
                Equal(10, gift.Events.Single(e => e.Kind == "AttitudeComposition").Contributions.Single().Delta);
            }
            Simulation loan = Create(World(30, 30, 30));
            loan.RunCycle(new([P(1, 1, new OfferLoan(new(2), 2))]));
            Equal(5, loan.Snapshot.AttitudeOf(new(2), new(1)));
            Debt debt = loan.Snapshot.Debts.Values.Single();
            loan.RunCycle(new([P(2, 2, new RepayDebt(debt.Id, 1))]));
            Equal(5, loan.Snapshot.AttitudeOf(new(1), new(2)));
            loan.RunCycle(CycleInput.Empty);
            Equal(5, loan.Snapshot.AttitudeOf(new(1), new(2)));
            // Due review and a gift are distinct same-cycle causes, composed in one transition.
            CycleResult due = loan.RunCycle(new([P(4, 2, new OfferGift(new(1), 1))]));
            Equal(5, due.State.AttitudeOf(new(1), new(2)));
            True(due.Events.Single(e => e.Kind == "AttitudeComposition").Contributions.Select(c => c.Delta).Order().SequenceEqual(new[] { -10, 10 }));
            loan.RunCycle(CycleInput.Empty);
            loan.RunCycle(CycleInput.Empty);
            Equal(1, loan.History.Count(e => e.Kind == "DebtSocialDueReview"));
            foreach (bool need in new[] { false, true })
            {
                Simulation refused = Create(World(need ? 0 : 8));
                CycleResult result = refused.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
                { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
                Equal(need ? -5 : 0, result.State.AttitudeOf(new(1), new(2)));
            }
            foreach (bool fulfil in new[] { false, true })
            {
                Simulation favour = WithFavour();
                CycleResult result = favour.RunCycle(new([P(2, 1, new CallFavor(favour.Snapshot.Favours.Values.Single().Id, new Farm()))])
                { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), fulfil ? "SCORE-RP-003" : "SCORE-RP-004") });
                Equal(fulfil ? 10 : -20, result.State.AttitudeOf(new(1), new(2)));
            }
            CycleResult marriage = Create(World(8, 8, 8, 75, 75)).RunCycle(new([P(1, 1, new ProposeMarriage(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            Equal(75, marriage.State.AttitudeOf(new(1), new(2)));
            Equal(75, marriage.State.AttitudeOf(new(2), new(1)));
            True(marriage.Events.All(e => e.Contributions.IsEmpty));
        });
        yield return new("AggregateCapacityAndIndependentLedgerFault", ["S1-MUT-16", "S1-MUT-21"], () =>
        {
            InitialWorld initial = World(0, 3, 0);
            initial = initial with { People = [.. initial.People, new(new(4), "D", Sex.Female, 0)], Dwellings = [.. initial.Dwellings, new(new(4))], Residences = [.. initial.Residences, new(new(6), new(4), new(4))] };
            foreach (bool reverse in new[] { false, true })
            {
                Simulation sim = Create(initial);
                Proposal[] proposals = [P(1, 1, new RequestGiftOrHelp(new(2), 1)), P(2, 3, new RequestGiftOrHelp(new(2), 1)), P(3, 4, new RequestGiftOrHelp(new(2), 1))];
                CycleResult result = sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                Equal(2, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                Equal(OutcomeKind.InvalidatedAtResolution, result.Outcomes.Single(o => o.Actor.Value == 4).Kind);
                Equal(3, result.Events.Count(e => e.TechnicalFallback));
                Person donor = result.State.People[new(2)];
                WorldSnapshot corrupt = result.State with { People = result.State.People.SetItem(donor.Id, donor with { Grain = 1 }) };
                Assert.ThrowsExactly<AssertFailedException>(() => InvariantOracle.Verify(initial, corrupt, sim.History, sim.DecisionHistory));
            }
        });
    }
}
