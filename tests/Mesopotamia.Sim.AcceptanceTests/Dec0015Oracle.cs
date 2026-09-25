using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

// Expected values come from DEC-0015, raw observations and independent arithmetic.
internal static class Dec0015Oracle
{
    internal static void InvalidInteraction(Simulation sim, CycleResult result, ProposalId proposal)
    {
        Outcome outcome = result.Outcomes.Single(o => o.Proposal == proposal);
        Assert.AreEqual(OutcomeKind.InvalidTerms, outcome.Kind);
        Assert.AreEqual(0, result.Decisions.Count(d => d.Proposal == proposal), "Invalid term reached response activation.");
        SemanticEvent[] events = [.. result.Events.Where(e => e.Proposal == proposal)];
        CollectionAssert.AreEqual(new[] { "Proposal", "InvalidTerms" }, events.Select(e => e.Kind).ToArray());
        Assert.IsTrue(events.All(e => e.Material.IsEmpty && e.Contributions.IsEmpty));
        Assert.IsFalse(result.Events.Any(e => e.Contributions.Any(c => events.Any(p => p.Id == c.Key.Trigger))));
        foreach (PersonId person in result.State.People.Keys)
        {
            Assert.IsFalse(sim.KnowledgeOf(person).Any(k => k.Proposal == proposal));
            Assert.IsFalse(sim.EpistemicStateOf(person).Facts.Any(f =>
                f.Proposition is ParticipationFact p && p.Outcome.Proposal == proposal));
        }
    }

    internal static void NoClaimsOrConsequences(Simulation sim)
    {
        Assert.AreEqual(0, sim.Snapshot.Debts.Count);
        Assert.AreEqual(0, sim.Snapshot.Favours.Count);
        foreach (PersonId person in sim.Snapshot.People.Keys)
        {
            Assert.AreEqual(0, sim.KnowledgeOf(person).Length);
            Assert.IsFalse(sim.EpistemicStateOf(person).Facts.Any(f => f.Proposition is
                DebtFact or FavourFact or ParticipationFact or SupportFact));
        }
        Assert.IsFalse(sim.History.Any(e => e.Kind is "Loan" or "Repayment" or "DebtSocialDueReview" or
            "ExplicitBenefitForFavor" or "RelationshipMediatedReciprocalHelp" or "CalledFavourFulfilled" or
            "Declined" or "Unable" or "InvalidatedAtResolution" or "AttitudeComposition"));
    }

    internal static void SameMaterialAndAttitudes(WorldSnapshot expected, WorldSnapshot actual)
    {
        CollectionAssert.AreEqual(expected.People.OrderBy(p => p.Key.Value).ToArray(),
            actual.People.OrderBy(p => p.Key.Value).ToArray());
        CollectionAssert.AreEqual(expected.Attitudes.OrderBy(p => p.Key.Value).ToArray(),
            actual.Attitudes.OrderBy(p => p.Key.Value).ToArray());
        CollectionAssert.AreEqual(expected.Debts.OrderBy(p => p.Key.Value).ToArray(),
            actual.Debts.OrderBy(p => p.Key.Value).ToArray());
        CollectionAssert.AreEqual(expected.Favours.OrderBy(p => p.Key.Value).ToArray(),
            actual.Favours.OrderBy(p => p.Key.Value).ToArray());
    }
}

