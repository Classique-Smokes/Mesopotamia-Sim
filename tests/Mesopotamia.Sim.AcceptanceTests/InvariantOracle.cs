using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

/// <summary>Independent replay from initial facts and recorded effects; no production scorer/validator/transition calls.</summary>
internal static class InvariantOracle
{
    internal static void Verify(InitialWorld initial, WorldSnapshot final, IEnumerable<SemanticEvent> history, IEnumerable<DecisionTrace> decisions)
    {
        Dictionary<PersonId, long> grain = initial.People.ToDictionary(p => p.Id, p => p.Grain);
        Dictionary<PersonId, bool> need = initial.People.ToDictionary(p => p.Id, p => p.NeedsGrain);
        Dictionary<(PersonId, PersonId), int> attitudes = initial.Attitudes.ToDictionary(a => (a.From, a.To), a => a.Value);
        Dictionary<PersonId, DwellingId> residences = initial.Residences.ToDictionary(r => r.Person, r => r.Dwelling);
        Dictionary<EventId, SemanticEvent> seen = [];
        HashSet<CauseKey> causes = [];
        Dictionary<CauseKey, int> requiredCauses = [];
        long currentCycle = 0;
        Dictionary<long, int> indexes = [];
        HashSet<(long, PersonId)> moves = [];
        Dictionary<RelationId, long> repaid = [];
        foreach (SemanticEvent entry in history.Where(e => e.Cycle <= final.Cycle))
        {
            if (entry.Cycle != currentCycle)
            {
                Assert.IsEmpty(requiredCauses, "A stable cycle omitted a mandatory attitude cause.");
                currentCycle = entry.Cycle;
            }
            Assert.IsTrue(seen.TryAdd(entry.Id, entry), "Repeated semantic event identity.");
            Assert.IsTrue(entry.ReactionIndex > indexes.GetValueOrDefault(entry.Cycle, -1), "Non-monotone reaction index.");
            indexes[entry.Cycle] = entry.ReactionIndex;
            foreach (EventId predecessor in entry.Causes)
                Assert.IsTrue(seen.ContainsKey(predecessor) && predecessor != entry.Id, "Unresolved or future cause.");
            long net = 0;
            foreach (MaterialChange delta in entry.Material)
            {
                Assert.AreEqual(grain[delta.Person], delta.Before, "Material history does not connect.");
                Assert.IsTrue(delta.After >= 0, "Negative grain.");
                net = checked(net + delta.After - delta.Before);
                grain[delta.Person] = delta.After;
            }
            if (entry.Kind == "Farm") Assert.AreEqual(4L, net);
            else if (entry.Kind == "Consumption") Assert.AreEqual(-1L, net);
            else if (entry.Kind == "ExogenousGrain")
                Assert.AreEqual(initial.Inputs.Single(i => entry.Detail == $"Input:{i.Id}").Delta, net);
            else Assert.AreEqual(0L, net, "Unexplained grain source/sink.");
            // Need is reconstructed from initial facts and maintenance, not inferred from
            // attitude history. In particular, paying the last grain is not unmet need.
            if (entry.Kind == "MissedConsumption") need[entry.Participants[0]] = true;
            if (entry.Kind == "ExogenousGrain" && grain[entry.Participants[0]] > 0) need[entry.Participants[0]] = false;
            if (entry.Kind is "Gift" or "Help" or "Loan" or "Repayment" or "ExplicitBenefitForFavor" or "RelationshipMediatedReciprocalHelp")
                need[entry.Participants[1]] = false;
            // Derive the complete expected set from consequential outcomes, independently
            // of the recorded contribution set and production consequence helpers.
            (string Rule, PersonId From, PersonId To, int Delta)? required = entry.Kind switch
            {
                "Gift" or "Help" or "RelationshipMediatedReciprocalHelp" =>
                    (entry.Kind, entry.Participants[1], entry.Participants[0], 10),
                "Loan" or "Repayment" => (entry.Kind, entry.Participants[1], entry.Participants[0], 5),
                "CalledFavourFulfilled" => (entry.Kind, entry.Participants[0], entry.Participants[1], 10),
                "DebtSocialDueReview" when entry.Detail == "UnpaidBalance" =>
                    ("UnpaidDebt", entry.Participants[0], entry.Participants[1], -10),
                "Declined" when entry.Action is CallFavor =>
                    ("CalledFavourRefusal", entry.Participants[0], entry.Participants[1], -20),
                "Declined" when entry.Action is RequestGiftOrHelp or RequestLoan or RelationshipMediatedReciprocalHelp { Request: true }
                    && need[entry.Participants[0]] => ("GenuineNeedRefusal", entry.Participants[0], entry.Participants[1], -5),
                _ => null
            };
            if (required is { } cause) requiredCauses.Add(new(cause.Rule, entry.Id, cause.From, cause.To), cause.Delta);
            if (entry.Action is RepayDebt repayment && entry.Kind == "Repayment")
            {
                repaid[repayment.Debt] = checked(repaid.GetValueOrDefault(repayment.Debt) + repayment.Amount);
                Assert.IsTrue(entry.Material[0].After >= 2, "Repayment penetrated reserve.");
            }
            if (entry.Kind == "AttitudeDecay")
            {
                var pair = (entry.Participants[0], entry.Participants[1]);
                int before = attitudes.GetValueOrDefault(pair);
                attitudes[pair] = before > 0 ? Math.Max(0, before - 2) : Math.Min(0, before + 1);
                Assert.AreEqual(0L, entry.Cycle % 5);
            }
            if (entry.Kind == "AttitudeComposition")
            {
                var pair = (entry.Participants[0], entry.Participants[1]);
                CauseKey[] expectedKeys = requiredCauses.Keys.Where(k => (k.From, k.To) == pair).ToArray();
                CollectionAssert.AreEquivalent(expectedKeys, entry.Contributions.Select(c => c.Key).ToArray(),
                    "Recorded contributions omit or invent mandatory causes.");
                long sum = attitudes.GetValueOrDefault(pair);
                foreach (AttitudeContribution contribution in entry.Contributions)
                {
                    Assert.IsTrue(causes.Add(contribution.Key), "Repeated automatic cause.");
                    Assert.AreEqual(pair, (contribution.Key.From, contribution.Key.To));
                    Assert.IsTrue(entry.Causes.Contains(contribution.Key.Trigger));
                    Assert.AreEqual(requiredCauses[contribution.Key], contribution.Delta);
                    requiredCauses.Remove(contribution.Key);
                    sum = checked(sum + contribution.Delta);
                }
                attitudes[pair] = (int)Math.Clamp(sum, -100, 100);
            }
            if (entry.Kind == "ResidenceTransition")
            {
                PersonId mover = entry.Action is InviteResidence invite ? invite.Target : entry.Participants[0];
                DwellingId destination = entry.Action is MoveResidence move ? move.Destination : ((InviteResidence)entry.Action!).Destination;
                Assert.IsTrue(moves.Add((entry.Cycle, mover)), "Two residence commits in one cycle.");
                residences[mover] = destination;
            }
            if (entry.Kind is "Unable" or "InvalidatedAtResolution" or "InvalidTerms")
                Assert.IsEmpty(entry.Material);
        }
        Assert.IsEmpty(requiredCauses, "Published history omitted mandatory attitude consequences.");
        foreach (Person person in final.People.Values)
        {
            Assert.AreEqual(grain[person.Id], person.Grain, "State differs from material ledger.");
            Assert.IsFalse(person.NeedsGrain && person.Grain > 0);
        }
        foreach (Attitude attitude in final.Attitudes.Values)
            Assert.AreEqual(attitudes.GetValueOrDefault((attitude.From, attitude.To)), attitude.Value, "Attitude differs from independent sum-then-clamp replay.");
        foreach (var pair in attitudes)
            Assert.AreEqual(pair.Value, final.Attitudes.Values.Single(a => (a.From, a.To) == pair.Key).Value);
        foreach (Residence residence in final.Residences.Values)
            Assert.AreEqual(residences[residence.Person], residence.Dwelling);
        foreach (Debt debt in final.Debts.Values)
        {
            Assert.AreEqual("Loan", seen[debt.Origin].Kind);
            Assert.AreEqual(debt.Original - repaid.GetValueOrDefault(debt.Id), debt.Remaining);
            Assert.IsTrue(debt.Remaining >= 0);
            Assert.IsTrue(final.People.ContainsKey(debt.Creditor) && final.People.ContainsKey(debt.Debtor));
        }
        foreach (Favour favour in final.Favours.Values)
        {
            Assert.IsTrue(seen[favour.Origin].Kind is "ExplicitBenefitForFavor" or "RelationshipMediatedReciprocalHelp");
            Assert.IsTrue(final.People.ContainsKey(favour.Debtor) && final.People.ContainsKey(favour.Holder));
        }
        Assert.IsTrue(final.Favours.Values.Where(f => f.Outstanding).GroupBy(f => (f.Debtor, f.Holder)).All(g => g.Count() == 1));
        Assert.IsTrue(final.Marriages.Values.SelectMany(m => new[] { m.Groom, m.Bride }).GroupBy(p => p).All(g => g.Count() == 1));
        foreach (Marriage marriage in final.Marriages.Values)
            Assert.IsFalse(final.Kinships.Values.Any(k => (k.First == marriage.Groom && k.Second == marriage.Bride) || (k.Second == marriage.Groom && k.First == marriage.Bride)));
        foreach (DecisionTrace decision in decisions.Where(d => d.Cycle <= final.Cycle))
        {
            CandidateTrace[] eligible = decision.Candidates.Where(c => c.Eligible).ToArray();
            foreach (CandidateTrace candidate in decision.Candidates)
            {
                if (!candidate.Eligible)
                {
                    Assert.IsNull(candidate.FinalScore);
                    Assert.IsFalse(candidate.Selected);
                    Assert.IsFalse(string.IsNullOrEmpty(candidate.Gate));
                }
                else if (candidate.FinalScore is { } score)
                    Assert.AreEqual(candidate.Components.Values.Aggregate(0L, (sum, v) => checked(sum + v)), score);
            }
            if (eligible.Length > 0 && !decision.Profile.StartsWith("MECHANISM", StringComparison.Ordinal))
            {
                long? max = eligible.Max(c => c.FinalScore);
                Assert.AreEqual(max, eligible.Single(c => c.Selected).FinalScore);
                Assert.AreEqual(eligible.Count(c => c.FinalScore == max) > 1, decision.TechnicalFallback);
            }
        }
    }
}
