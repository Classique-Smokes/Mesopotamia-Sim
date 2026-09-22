using System.Collections.Immutable;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal static partial class Scenarios
{
    private static Simulation WithFavour(long b = 30, int ab = 0)
    {
        Simulation sim = new(World(30, b, 30, ab));
        sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1))]));
        return sim;
    }
    private static IEnumerable<Scenario> FavourCases()
    {
        yield return new("ExplicitBargainAndReciprocalHelp", ["S1-091-BFF-POS", "S1-093-BFF-POS", "S1-091-RMRH", "S1-093-RECIP-74", "S1-093-RECIP-75", "S1-093-RECIP-76", "S1-093-KIN-GATE", "S1-MUT-04"], () =>
        {
            Simulation explicitBargain = WithFavour();
            Equal(1, explicitBargain.Snapshot.Favours.Count);
            Favour favour = explicitBargain.Snapshot.Favours.Values.Single();
            Equal(new PersonId(2), favour.Debtor);
            Equal(new PersonId(1), favour.Holder);
            Equal("ExplicitBenefitForFavor", explicitBargain.History.Single(e => e.Id == favour.Origin).Kind);
            Equal(0, explicitBargain.Snapshot.AttitudeOf(new(2), new(1)));
            foreach (int attitude in new[] { 74, 75, 76 })
                foreach (bool kin in new[] { false, true })
                {
                    InitialWorld world = World(8, 8, 8, 0, attitude);
                    if (kin) world = world with { Kinships = [new(new(6), new(1), new(2), KinshipKind.Sibling)] };
                    Simulation sim = new(world);
                    CycleResult result = sim.RunCycle(new([P(1, 1, new RelationshipMediatedReciprocalHelp(new(2), 1))]));
                    Equal(attitude >= 75 ? 1 : 0, result.State.Favours.Count);
                    Equal(8L, Grain(result, 2));
                    Equal("RelationshipMediatedReciprocalHelp", result.Events.Single(e => e.Material.Length == 2).Kind);
                }
        });
        yield return new("FullFavourSlotDistinguishesBargainFromHelp", ["S1-093-BFF-FULL", "S1-093-RMRH-FULL", "S1-BND-FAVOUR-CARD", "S1-BND-FAVOUR-MEANING", "S1-MUT-35"], () =>
        {
            foreach (bool help in new[] { false, true })
            {
                Simulation sim = WithFavour();
                long before = sim.Snapshot.People[new(2)].Grain;
                CycleResult result = sim.RunCycle(new([P(2, 1, help ? new RelationshipMediatedReciprocalHelp(new(2), 1) : new OfferBenefitForFavor(new(2), 1))]));
                Equal(help ? OutcomeKind.Committed : OutcomeKind.Unable, result.Outcomes.Single().Kind);
                Equal(help ? before : before - 1, Grain(result, 2));
                Equal(1, result.State.Favours.Values.Count(f => f.Outstanding));
                Equal(help ? 1 : 0, result.Decisions.Count(d => d.Candidates.Length > 0));
                Equal(help ? 10 : 0, result.State.AttitudeOf(new(2), new(1)));
                if (!help) Equal("FavourCapacityFull", result.Outcomes.Single().Reason);
            }
        });
        yield return new("BargainCapacityRace", ["S1-093-BFF-RACE", "S1-MUT-35"], () =>
        {
            Simulation sim = new(World(20, 20, 20, 0, 75));
            CycleResult result = sim.RunCycle(new([
                P(10, 2, new RelationshipMediatedReciprocalHelp(new(1), 1, Request: true)),
                P(20, 1, new OfferBenefitForFavor(new(2), 1))]));
            Equal(2, result.Decisions.Length);
            True(result.Decisions.All(d => d.Candidates.Single(c => c.Selected).Meaning == "Accept"));
            Equal(OutcomeKind.Committed, result.Outcomes.Single(o => o.Proposal.Value == 10).Kind);
            Outcome lost = result.Outcomes.Single(o => o.Proposal.Value == 20);
            Equal(OutcomeKind.InvalidatedAtResolution, lost.Kind);
            Equal("FavourCapacityFull", lost.Reason);
            Equal(18L, Grain(result, 1));
            Equal(20L, Grain(result, 2));
            Equal(1, result.State.Favours.Count);
            Equal(0, result.Events.Count(e => e.Kind == "ExplicitBenefitForFavor"));
            Equal(85, result.State.AttitudeOf(new(2), new(1)));
        });
        yield return new("CalledFarmSuccessRefusalAndInability", ["S1-094-FARM-CALLABLE", "S1-094-SUCCESS", "S1-094-DECLINE", "S1-094-UNABLE", "S1-102", "S1-098-CALLFAVOR-INIT", "S1-094-NESTED-GUARD"], () =>
        {
            foreach (string profile in new[] { "SCORE-RP-003", "SCORE-RP-004" })
            {
                Simulation sim = WithFavour();
                Favour favour = sim.Snapshot.Favours.Values.Single();
                CycleResult result = sim.RunCycle(new([P(2, 1, new CallFavor(favour.Id, new Farm()))])
                { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), profile) });
                bool fulfilled = profile == "SCORE-RP-003";
                Equal(fulfilled ? OutcomeKind.Committed : OutcomeKind.Declined, result.Outcomes.Single().Kind);
                Equal(!fulfilled, result.State.Favours[favour.Id].Outstanding);
                Equal(fulfilled ? 10 : -20, result.State.AttitudeOf(new(1), new(2)));
                Equal(fulfilled ? 33L : 29L, Grain(result, 2));
                Equal(1, result.Decisions.Length);
                Equal(2, result.Decisions.Single().Candidates.Length);
                Equal(100L, result.Decisions.Single().Candidates.Single(c => c.Selected).FinalScore);
            }
            Simulation unable = WithFavour(0);
            Favour owed = unable.Snapshot.Favours.Values.Single();
            unable.RunCycle(CycleInput.Empty);
            CycleResult failed = unable.RunCycle(new([P(3, 1, new CallFavor(owed.Id, new Farm()))]));
            Equal(OutcomeKind.Unable, failed.Outcomes.Single().Kind);
            Equal(0, failed.Decisions.Single().Candidates.Length);
            True(failed.State.Favours[owed.Id].Outstanding);
            Equal(0, failed.State.AttitudeOf(new(1), new(2)));
        });
        yield return new("CalledFarmPersonalCoexistence", ["S1-094-PERSONAL-COEXIST"], () =>
        {
            Simulation sim = WithFavour();
            Favour favour = sim.Snapshot.Favours.Values.Single();
            CycleResult result = sim.RunCycle(new([P(2, 1, new CallFavor(favour.Id, new Farm())), P(3, 2, new Farm())]));
            Equal(37L, Grain(result, 2));
            Equal(2, result.Events.Count(e => e.Kind == "Farm"));
            Equal(1, result.Decisions.Length);
            Equal(2, result.Outcomes.Length);
        });
        yield return new("CalledRepaymentThirdPartyAndInvalidation", ["S1-094-REPAY-CALLABLE", "S1-094-INVALIDATED", "S1-MUT-34"], () =>
        {
            foreach (bool race in new[] { false, true })
            {
                Simulation sim = WithFavour(8);
                sim.RunCycle(new([P(2, 3, new OfferLoan(new(2), 4))]));
                Favour favour = sim.Snapshot.Favours.Values.Single();
                Debt debt = sim.Snapshot.Debts.Values.Single();
                Proposal call = P(20, 1, new CallFavor(favour.Id, new RepayDebt(debt.Id, 4)));
                long before = sim.Snapshot.People[new(2)].Grain;
                CycleResult result = sim.RunCycle(new(race ? [P(10, 2, new OfferGift(new(3), before - 1)), call] : [call]));
                Outcome outcome = result.Outcomes.Single(o => o.Proposal.Value == 20);
                Equal(race ? OutcomeKind.InvalidatedAtResolution : OutcomeKind.Committed, outcome.Kind);
                Equal(race, result.State.Favours[favour.Id].Outstanding);
                Equal(race ? 4L : 0L, result.State.Debts[debt.Id].Remaining);
                Equal(race ? 0 : 10, result.State.AttitudeOf(new(1), new(2)));
                Equal(race ? 10 : 5, result.State.AttitudeOf(new(3), new(2)));
                Equal(1, result.Decisions.Count(d => d.Actor == new PersonId(2)));
            }
        });
        yield return new("ReciprocalCancellation", ["S1-094-RECIP-CANCEL"], () =>
        {
            Simulation sim = WithFavour();
            sim.RunCycle(new([P(2, 2, new OfferBenefitForFavor(new(1), 1))]));
            CycleResult result = sim.RunCycle(new([P(3, 2, new CancelReciprocalFavours(new(1)))]));
            Equal(2, result.State.Favours.Count);
            Equal(0, result.State.Favours.Values.Count(f => f.Outstanding));
            Equal(0, result.Decisions.Length);
            Equal(0, result.Events.Single(e => e.Kind == "ReciprocalFavourCancellation").Material.Length);
        });
        yield return new("BenefitGrainIngress", ["S1-D4-GRAIN-BFF-BENEFIT", "S1-D4-GRAIN-RMRH-BENEFIT"], () =>
        {
            foreach (long amount in new[] { -1L, 0L, 1L })
                foreach (bool reciprocal in new[] { false, true })
                {
                    Simulation sim = new(World());
                    CycleResult result = sim.RunCycle(new([P(1, 1, reciprocal ? new RelationshipMediatedReciprocalHelp(new(2), amount) : new OfferBenefitForFavor(new(2), amount))]));
                    Equal(amount > 0 ? OutcomeKind.Committed : OutcomeKind.InvalidTerms, result.Outcomes.Single().Kind);
                    if (amount <= 0)
                    {
                        Equal(0, result.Decisions.Length);
                        Equal(0, result.State.Favours.Count);
                        Equal(7L, Grain(result, 1));
                        Equal(7L, Grain(result, 2));
                    }
                }
            Equal(typeof(long), typeof(OfferBenefitForFavor).GetProperty(nameof(OfferBenefitForFavor.Amount))!.PropertyType);
            Equal(typeof(long), typeof(RelationshipMediatedReciprocalHelp).GetProperty(nameof(RelationshipMediatedReciprocalHelp.Amount))!.PropertyType);
        });
    }
}
