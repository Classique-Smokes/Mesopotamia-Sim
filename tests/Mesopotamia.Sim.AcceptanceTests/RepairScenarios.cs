using System.Collections.Immutable;
using System.Text.Json;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed partial class Scenarios
{
    private IEnumerable<Scenario> RepairCases()
    {
        yield return new("RepairResidenceDestinationDependency", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool rename in new[] { false, true })
                foreach (bool reverse in new[] { false, true })
                {
                    Proposal[] proposals = [P(rename ? 20 : 10, 1, new MoveResidence(new(2), new(2))),
                        P(rename ? 10 : 20, 2, new MoveResidence(new(3), new(3)))];
                    CycleResult result = Create(World(30, 30, 30)).RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                    Equal(rename ? new DwellingId(1) : new DwellingId(2), result.State.HomeOf(new(1)));
                    Equal(new DwellingId(3), result.State.HomeOf(new(2)));
                    Equal(rename ? OutcomeKind.InvalidatedAtResolution : OutcomeKind.Committed,
                        result.Outcomes.Single(o => o.Actor == new PersonId(1)).Kind);
                    if (rename) Equal("ResidenceDestinationChanged", result.Outcomes.Single(o => o.Actor == new PersonId(1)).Reason);
                    Equal(2, result.Events.Count(e => e.TechnicalFallback));
                }
        });
        yield return new("RepairCallCancellationDependency", ["S1-081", "S1-META-02", "S1-GLOBAL-FALLBACK"], () =>
        {
            foreach (bool rename in new[] { false, true })
                foreach (bool reverse in new[] { false, true })
                {
                    Simulation sim = Create(World(30, 30, 30));
                    sim.RunCycle(new([P(100, 1, new OfferBenefitForFavor(new(2), 1))]));
                    sim.RunCycle(new([P(200, 2, new OfferBenefitForFavor(new(1), 1))]));
                    RelationId owed = sim.Snapshot.Favours.Values.Single(f => f.Holder == new PersonId(1)).Id;
                    Proposal[] proposals = [P(rename ? 400 : 300, 1, new CallFavor(owed, new Farm())),
                        P(rename ? 300 : 400, 2, new CancelReciprocalFavours(new(1)))];
                    CycleResult result = sim.RunCycle(new([.. reverse ? proposals.Reverse() : proposals]));
                    Equal(rename ? 27L : 31L, Grain(result, 2));
                    Equal(rename ? 0 : 1, result.State.Favours.Values.Count(f => f.Outstanding));
                    Equal(1, result.Outcomes.Count(o => o.Kind == OutcomeKind.Committed));
                    Equal(rename ? "FavourUnavailable" : "ReciprocalFavoursUnavailable",
                        result.Outcomes.Single(o => o.Kind == OutcomeKind.InvalidatedAtResolution).Reason);
                    Equal(2, result.Events.Count(e => e.TechnicalFallback));
                }
        });
        yield return new("RepairNeedyReciprocalRequestRefusal", ["S1-097-EVENTS", "S1-MUT-18"], () =>
        {
            foreach (ActionTerms request in new ActionTerms[] { new RequestGiftOrHelp(new(2), 1), new RequestLoan(new(2), 1), new RelationshipMediatedReciprocalHelp(new(2), 1, Request: true) })
                foreach (bool needy in new[] { false, true })
                {
                    CycleResult result = Create(World(needy ? 0 : 8, 30, 30, 75)).RunCycle(new([P(1, 1, request)])
                    { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
                    Equal(OutcomeKind.Declined, result.Outcomes.Single().Kind);
                    Equal(needy ? 70 : 75, result.State.AttitudeOf(new(1), new(2)));
                    Equal(needy ? 1 : 0, result.Events.SelectMany(e => e.Contributions).Count());
                }
            CycleResult unable = Create(World(0, 0, 30, 75)).RunCycle(new([P(1, 1, new RelationshipMediatedReciprocalHelp(new(2), 1, Request: true))]));
            Equal(OutcomeKind.Unable, unable.Outcomes.Single().Kind);
            Equal(75, unable.State.AttitudeOf(new(1), new(2)));
            CycleResult invalidated = Create(World(0, 2, 0, 75)).RunCycle(new([
                P(10, 3, new RequestGiftOrHelp(new(2), 1)), P(20, 1, new RelationshipMediatedReciprocalHelp(new(2), 1, Request: true))]));
            Equal(OutcomeKind.InvalidatedAtResolution, invalidated.Outcomes.Single(o => o.Actor == new PersonId(1)).Kind);
            Equal(75, invalidated.State.AttitudeOf(new(1), new(2)));
            CycleResult offered = Create(World(30, 0, 30, 75)).RunCycle(new([P(1, 1, new RelationshipMediatedReciprocalHelp(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            Equal(OutcomeKind.Declined, offered.Outcomes.Single().Kind);
            Equal(75, offered.State.AttitudeOf(new(1), new(2)));
            Equal(0, offered.Events.SelectMany(e => e.Contributions).Count());
        });
        yield return new("RepairMissingMandatoryAttitudeCause", ["S1-097-EVENTS", "S1-GLOBAL-ORACLE"], () =>
        {
            InitialWorld initial = World(0, 30, 30, 75);
            Simulation sim = Create(initial);
            CycleResult result = sim.RunCycle(new([P(1, 1, new RequestGiftOrHelp(new(2), 1))])
            { ResponseProfiles = ImmutableDictionary<PersonId, string>.Empty.Add(new(2), "SCORE-RP-002") });
            WorldSnapshot corrupt = result.State with
            {
                Attitudes = result.State.Attitudes.ToImmutableDictionary(p => p.Key,
                p => p.Value.From == new PersonId(1) && p.Value.To == new PersonId(2) ? p.Value with { Value = 75 } : p.Value)
            };
            SemanticEvent[] history = [.. sim.History.Select(e => e.Kind == "AttitudeComposition" ? e with { Contributions = [], Detail = "75->75" } : e)];
            Assert.ThrowsExactly<AssertFailedException>(() => InvariantOracle.Verify(initial, corrupt, history, sim.DecisionHistory));
            Assert.ThrowsExactly<AssertFailedException>(() => InvariantOracle.Verify(initial, corrupt,
                sim.History.Where(e => e.Kind != "AttitudeComposition"), sim.DecisionHistory));
            FaultEvidence.Add(new { Id = "S1-097-EVENTS", Route = "Detached omitted mandatory-cause witness with consistent final attitude", Outcome = "detected", Detector = "Independently derived required cause set" });
        });
        yield return new("RepairHiddenCounterpartyGrain", ["S1-086", "S1-META-07"], () =>
        {
            List<DecisionTrace> traces = [];
            foreach (long stock in new[] { 0L, 8L })
            {
                CycleResult result = Create(World(0, stock, 0)).RunCycle(new([])
                { PersonalPolicies = ImmutableDictionary<PersonId, PersonalPolicy>.Empty.Add(new(1), new()) });
                DecisionTrace personal = result.Decisions.Single(d => d.Context == "Personal");
                Equal("RequestGiftOrHelp", personal.Candidates.Single(c => c.Selected).Meaning);
                Equal(stock == 0 ? OutcomeKind.Unable : OutcomeKind.Committed, result.Outcomes.Single().Kind);
                traces.Add(personal);
            }
            Equal(JsonSerializer.Serialize(traces[0]), JsonSerializer.Serialize(traces[1]));
        });
    }
}
