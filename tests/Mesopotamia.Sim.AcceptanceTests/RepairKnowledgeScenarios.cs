using System.Collections.Immutable;
using System.Reflection;
using System.Text.Json;
using Mesopotamia.Sim;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private static CycleResult PersonalCycle(Simulation sim, PersonalPolicy policy) => sim.RunCycle(new([])
    { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), policy) });
    private IEnumerable<Scenario> RepairKnowledgeCases()
    {
        yield return new("RepairHiddenWorldFacts", ["S1-086", "S1-META-07"], () =>
        {
            InitialWorld baseline = World(30, 30, 30, 80, 80);
            InitialWorld[] variants = [baseline,
                baseline with { People = [.. baseline.People.Select(p => p.Id == new PersonId(2) ? p with { Grain = 0, NeedsGrain = true } : p)] },
                baseline with { People = [.. baseline.People.Select(p => p.Id == new PersonId(2) ? p with { Sex = Sex.Male, Name = "Unobserved" } : p)] },
                baseline with { Residences = [.. baseline.Residences.Select(r => r.Person == new PersonId(2) ? r with { Dwelling = new(3) } : r)] },
                baseline with { Marriages = [new(new(6), new(3), new(2))] },
                baseline with { Kinships = [new(new(6), new(2), new(3), KinshipKind.Sibling)] },
                baseline with { Attitudes = [.. baseline.Attitudes, new(new(6), new(2), new(3), -100)] }];
            string? expected = null;
            foreach (InitialWorld initial in variants)
            {
                DecisionTrace trace = PersonalCycle(Create(initial), new("SCORE-VP-005")).Decisions.Single(d => d.Context == "Personal");
                Equal("Farm", trace.Candidates.Single(c => c.Selected).Meaning);
                True(trace.Candidates.All(c => c.Terms is not ProposeMarriage and not MoveResidence));
                True(trace.SubjectiveInputs.Contains("KnownPeople:2"));
                if (expected is null) expected = JsonSerializer.Serialize(trace); else Equal(expected, JsonSerializer.Serialize(trace));
            }
        });
        yield return new("RepairExplicitSexAndResidenceObservations", ["S1-086", "S1-099-CORES", "S1-META-07"], () =>
        {
            foreach (bool sex in new[] { false, true })
                foreach (bool residence in new[] { false, true })
                {
                    PersonalPolicy policy = new("SCORE-VP-006")
                    {
                        ObservedPeople = [new(2)],
                        ObservedSexes = sex ? ImmutableDictionary<PersonId, Sex>.Empty.Add(new(2), Sex.Female) : ImmutableDictionary<PersonId, Sex>.Empty,
                        ObservedResidences = residence ? ImmutableDictionary<PersonId, DwellingId>.Empty.Add(new(2), new(2)) : ImmutableDictionary<PersonId, DwellingId>.Empty
                    };
                    CycleResult result = PersonalCycle(Create(World(30, 30, 30, 80, 80)), policy);
                    DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
                    Equal(sex, trace.Candidates.Any(c => c.Terms is ProposeMarriage && c.Eligible));
                    Equal(residence, trace.Candidates.Any(c => c.Terms is MoveResidence && c.Eligible));
                    Equal(residence ? "MoveResidence" : "InviteResidence", trace.Candidates.Single(c => c.Selected).Meaning);
                    Equal(20L, trace.Candidates.Single(c => c.Selected).FinalScore);
                    Equal(sex, trace.SubjectiveInputs.Any(i => i == "ObservedSex:2:Female;Basis:ExplicitPolicyObservation"));
                    Equal(residence, trace.SubjectiveInputs.Any(i => i == "ObservedResidence:2:2;Basis:ExplicitPolicyObservation"));
                    True(trace.SubjectiveInputs.Contains("ObservedPeople:2;Basis:PolicyIdentityBindingsOnly"));
                    Equal(OutcomeKind.Committed, result.Outcomes.Single().Kind);
                }
            // Same supplied observation, different unobserved current world fact:
            // personal deliberation stays fixed; response feasibility may differ.
            PersonalPolicy observed = new("SCORE-VP-006") { ObservedResidences = ImmutableDictionary<PersonId, DwellingId>.Empty.Add(new(2), new(2)) };
            string? expected = null;
            foreach (bool changed in new[] { false, true })
            {
                InitialWorld world = World(30, 30, 30, 80, 80);
                if (changed) world = world with { Residences = [.. world.Residences.Select(r => r.Person == new PersonId(2) ? r with { Dwelling = new(3) } : r)] };
                CycleResult result = PersonalCycle(Create(world), observed);
                DecisionTrace trace = result.Decisions.Single(d => d.Context == "Personal");
                Equal(changed ? OutcomeKind.Unable : OutcomeKind.Committed, result.Outcomes.Single().Kind);
                if (changed) Equal("ResidenceDestinationChanged", result.Outcomes.Single().Reason);
                if (expected is null) expected = JsonSerializer.Serialize(trace); else Equal(expected, JsonSerializer.Serialize(trace));
            }
        });
        yield return new("RepairObservedDebtBoundary", ["S1-086", "S1-094-REPAY-CALLABLE", "S1-META-07"], () =>
        {
            string? hiddenTrace = null;
            foreach (bool observe in new[] { false, true })
                foreach (long amount in new[] { 2L, 4L })
                {
                    Simulation sim = Create(World(30, 30, 30));
                    sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferLoan(new(2), amount)), P(3, 2, new OfferLoan(new(3), 1))]));
                    Debt relevant = sim.Snapshot.Debts.Values.Single(d => d.Debtor == new PersonId(2));
                    DecisionTrace trace = PersonalCycle(sim, new("SCORE-VP-005") { ObservedDebts = observe ? [relevant.Id] : [] }).Decisions.Single(d => d.Context == "Personal");
                    Equal(observe ? 1 : 0, trace.Candidates.Count(c => c.Terms is CallFavor { Requested: RepayDebt }));
                    Equal(observe ? 1 : 0, trace.SubjectiveInputs.Count(i => i.StartsWith("Debt:", StringComparison.Ordinal)));
                    True(trace.SubjectiveInputs.Contains(observe ? "KnownPeople:2,3" : "KnownPeople:2"));
                    if (observe)
                    {
                        string input = trace.SubjectiveInputs.Single(i => i.StartsWith("Debt:", StringComparison.Ordinal));
                        True(input.Contains($"Remaining:{amount};", StringComparison.Ordinal));
                        True(input.Contains($"Origin:{relevant.Origin.Value};Basis:ExplicitPolicyObservation", StringComparison.Ordinal));
                        True(trace.Candidates.Single(c => c.Terms is CallFavor { Requested: RepayDebt }).Eligible);
                    }
                    else if (hiddenTrace is null) hiddenTrace = JsonSerializer.Serialize(trace); else Equal(hiddenTrace, JsonSerializer.Serialize(trace));
                }
        });
        yield return new("RepairCalledPayloadPrivateFeasibility", ["S1-086", "S1-094-FARM-CALLABLE", "S1-094-REPAY-CALLABLE", "S1-META-07"], () =>
        {
            foreach (bool repay in new[] { false, true })
            {
                string? expected = null;
                foreach (long privateStock in new[] { 0L, 20L })
                {
                    Simulation sim = Create(World(30, privateStock, 30));
                    sim.RunCycle(new([P(1, 1, new OfferBenefitForFavor(new(2), 1)), P(2, 3, new OfferLoan(new(2), 2))]));
                    for (int i = 0; i < 4; i++) sim.RunCycle(CycleInput.Empty);
                    Debt debt = sim.Snapshot.Debts.Values.Single();
                    Favour favour = sim.Snapshot.Favours.Values.Single();
                    DecisionTrace trace = PersonalCycle(sim, new("SCORE-VP-005") { ObservedDebts = [debt.Id] }).Decisions.Single(d => d.Context == "Personal");
                    Equal(2, trace.Candidates.Count(c => c.Terms is CallFavor && c.Eligible));
                    if (expected is null) expected = JsonSerializer.Serialize(trace); else Equal(expected, JsonSerializer.Serialize(trace));
                    CycleResult attempted = sim.RunCycle(new([P(100, 1, new CallFavor(favour.Id, repay ? new RepayDebt(debt.Id, 1) : new Farm()))]));
                    Equal(privateStock == 0 ? OutcomeKind.Unable : OutcomeKind.Committed, attempted.Outcomes.Single().Kind);
                    Equal(privateStock == 0, attempted.State.Favours[favour.Id].Outstanding);
                }
            }
        });
        yield return new("RepairPersonalInputIsolationAndTrace", ["S1-086", "S1-085", "S1-GLOBAL-ORACLE"], () =>
        {
            Simulation sim = Create(World(30, 30, 30, 80, 80));
            sim.RunCycle(new([P(1, 1, new OfferLoan(new(2), 2)), P(2, 2, new OfferBenefitForFavor(new(1), 1))]));
            PersonalPolicy policy = new("SCORE-VP-004")
            {
                Amount = 2,
                GiftTarget = new(2),
                ObservedPeople = [new(2)],
                ObservedSexes = ImmutableDictionary<PersonId, Sex>.Empty.Add(new(2), Sex.Female),
                ObservedResidences = ImmutableDictionary<PersonId, DwellingId>.Empty.Add(new(2), new(2))
            };
            PersonalDecisionInputs captured = PersonalInputCapture.Capture(new(1), policy, sim.Snapshot);
            string trace = JsonSerializer.Serialize(captured.TraceInputs());
            True(captured.TraceInputs().Any(i => i.Contains("Amount:2;GiftTarget:2;", StringComparison.Ordinal)));
            True(captured.TraceInputs().Any(i => i.StartsWith("Debt:", StringComparison.Ordinal) && i.EndsWith("Basis:DirectPartyClaim", StringComparison.Ordinal)));
            True(captured.TraceInputs().Any(i => i.StartsWith("Favour:", StringComparison.Ordinal) && i.EndsWith("Basis:DirectPartyClaim", StringComparison.Ordinal)));
            sim.RunCycle(new([P(3, 2, new RepayDebt(sim.Snapshot.Debts.Values.Single().Id, 1))]));
            Equal(trace, JsonSerializer.Serialize(captured.TraceInputs()));
            True(typeof(PersonalAgency).GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
                .SelectMany(m => m.GetParameters()).All(p => p.ParameterType != typeof(WorldSnapshot)));
            True(typeof(PersonalDecisionInputs).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .All(p => p.PropertyType != typeof(WorldSnapshot) && p.PropertyType != typeof(WorldState)));
        });
    }
}
