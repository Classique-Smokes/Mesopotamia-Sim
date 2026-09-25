using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

internal static class Slice4FixtureAudit
{
    private static List<Slice4Lab>? current;
    internal static void Begin() => current = [];
    internal static void Register(Slice4Lab lab) => current?.Add(lab);
    internal static object[] Complete(string scenario)
    {
        List<Slice4Lab> labs = current ?? []; current = null;
        return [.. labs.Select((lab, index) =>
        {
            Assert.IsTrue(lab.FormationProducerVerified);
            Assert.IsTrue(lab.Initial.Knowledge.SelectMany(k => k.Facts).All(f => f.Proposition is ResidenceFact or KinshipFact));
            if (!lab.Sim.IsFaulted) Slice4Oracle.Verify(lab);
            HouseholdSnapshot h = lab.Sim.HouseholdSnapshot;
            return (object)new
            {
                Scenario = scenario, Subcase = index, Fixture = "F-S4-LOWER", ExactInitialWrites = lab.Initial,
                ExplicitReportPrerequisites = lab.FixtureHeadReports,
                lab.BoundaryChallenges,
                Producer = "Slice4Lab ordinary gifts plus communicated evidence; HouseholdOracle independently verifies formation before role work",
                ProducerPass = lab.FormationProducerVerified, ProducerCycles = lab.Cycles.Take(4).Select(c => c.Events),
                ProducerOutput = h.Formations.Values.Select(f => new { f.Id, f.Household, f.Stamp }),
                Inputs = lab.Inputs.Select(i => new
                {
                    i.Proposals, HeadConsents = i.HeadConsents.ToArray(), FundingPolicies = i.FundingPolicies.ToArray(),
                    HouseholdPolicies = i.HouseholdPolicies.ToArray(), Responses = i.Responses.ToArray(),
                    ResponseProfiles = i.ResponseProfiles.ToArray(), ProposalResponseProfiles = i.ProposalResponseProfiles.ToArray(),
                    PersonalPolicies = i.PersonalPolicies.Select(p => new { p.Key, p.Value.Profile, p.Value.Amount, p.Value.GiftTarget })
                }),
                History = lab.Sim.History, Decisions = lab.Sim.DecisionHistory, lab.Sim.IsFaulted,
                Final = new
                {
                    People = lab.Sim.Snapshot.People.Values, Marriages = lab.Sim.Snapshot.Marriages.Values, Favours = lab.Sim.Snapshot.Favours.Values,
                    Roles = h.HeadRoles.Values, Transitions = h.HeadTransitions.Values, Commitments = h.Commitments.Values, Refusals = h.ProvisionRefusals.Values,
                    Actors = lab.Sim.EpistemicSnapshot.Actors.Values
                }
            };
        })];
    }
}
