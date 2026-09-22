using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public abstract record ActionTerms;
public sealed record Farm : ActionTerms;
public sealed record Proposal(ProposalId Id, PersonId Actor, ActionTerms Terms);
public sealed record CycleInput(ImmutableArray<Proposal> Proposals)
{
    public static CycleInput Empty => new([]);
    public ImmutableDictionary<PersonId, string> ResponseProfiles { get; init; } = ImmutableDictionary<PersonId, string>.Empty;
    public ImmutableDictionary<ProposalId, ResponseChoice> Responses { get; init; } = ImmutableDictionary<ProposalId, ResponseChoice>.Empty;
}
public enum OutcomeKind { Committed, Declined, Unable, InvalidatedAtResolution, InvalidTerms }
public sealed record Outcome(ProposalId Proposal, PersonId Actor, OutcomeKind Kind, string Reason, EventId Event);
public sealed record MaterialChange(PersonId Person, long Before, long After, string Meaning);
public sealed record SemanticEvent(EventId Id, long Cycle, int ReactionIndex, string Kind,
    ProposalId? Proposal, ImmutableArray<PersonId> Participants, ImmutableArray<EventId> Causes,
    ImmutableArray<MaterialChange> Material, string Detail, string ConfigurationVersion, bool TechnicalFallback = false)
{
    public ImmutableArray<AttitudeContribution> Contributions { get; init; } = [];
}
public sealed record CycleResult(WorldSnapshot State, ImmutableArray<Outcome> Outcomes,
    ImmutableArray<SemanticEvent> Events, bool MaterialDeadlock)
{
    public ImmutableArray<DecisionTrace> Decisions { get; init; } = [];
}

public sealed partial class Simulation
{
    private readonly List<SemanticEvent> events = [];
    private long nextEvent = 1;
    private int reactionIndex;
    private bool faulted;
    private readonly HashSet<ProposalId> usedProposals = [];
    private readonly Dictionary<PersonId, List<ParticipantOutcome>> knowledge = [];
    public ImmutableArray<SemanticEvent> History => events.ToImmutableArray();
    public ImmutableArray<ParticipantOutcome> KnowledgeOf(PersonId person) =>
        knowledge.TryGetValue(person, out var facts) ? facts.ToImmutableArray() : [];

    public CycleResult RunCycle(CycleInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (faulted) throw new InvalidOperationException("A failed cycle cannot be resumed.");
        if (input.Proposals.Select(p => p.Actor).Distinct().Count() != input.Proposals.Length)
            throw new ArgumentException("At most one personal initiative per person/cycle.", nameof(input));
        if (input.Proposals.Any(p => p.Id.Value <= 0 || usedProposals.Contains(p.Id) || !state.People.ContainsKey(p.Actor)) ||
            input.Proposals.Select(p => p.Id).Distinct().Count() != input.Proposals.Length)
            throw new ArgumentException("Invalid or reused proposal identity.", nameof(input));
        int start = events.Count;
        cycle = checked(cycle + 1);
        reactionIndex = 0;
        try
        {
            Maintenance();
            WorldSnapshot decisionSnapshot = state.Snapshot(cycle);
            List<Outcome> outcomes = [];
            List<DecisionTrace> decisions = [];
            List<(Proposal Proposal, EventId Cause)> accepted = [];
            AttitudeBatch batch = new();
            foreach (Proposal proposal in input.Proposals.OrderBy(p => p.Id.Value))
            {
                usedProposals.Add(proposal.Id);
                string? invalid = ActionRules.Invalid(proposal, decisionSnapshot);
                SemanticEvent proposed = Record("Proposal", proposal.Id, [proposal.Actor], [], [], proposal.Terms.ToString() ?? "");
                if (invalid is not null)
                {
                    Finish(proposal, OutcomeKind.InvalidTerms, invalid, proposed.Id, outcomes);
                    continue;
                }
                string? inability = ActionRules.Infeasible(proposal, decisionSnapshot);
                PersonId? target = ActionRules.Target(proposal.Terms);
                if (inability is not null)
                {
                    if (target is { } unableTarget)
                        decisions.Add(new(unableTarget, proposal.Id, "Response", "Feasibility", [], [inability], false));
                    Finish(proposal, OutcomeKind.Unable, inability, proposed.Id, outcomes);
                    continue;
                }
                EventId cause = proposed.Id;
                if (target is { } respondent)
                {
                    string profile = input.ResponseProfiles.GetValueOrDefault(respondent, "SCORE-RP-001");
                    if (profile is not ("SCORE-RP-001" or "SCORE-RP-002"))
                        throw new ArgumentException("Unsupported ordinary response profile.", nameof(input));
                    ResponseChoice choice = input.Responses.GetValueOrDefault(proposal.Id,
                        profile == "SCORE-RP-002" ? ResponseChoice.Decline : ResponseChoice.Accept);
                    if (choice is not (ResponseChoice.Accept or ResponseChoice.Decline))
                        throw new ArgumentException("Response meaning does not belong to proposal.", nameof(input));
                    bool scripted = input.Responses.ContainsKey(proposal.Id);
                    CandidateTrace[] candidates = [ResponseCandidate(ResponseChoice.Accept), ResponseCandidate(ResponseChoice.Decline)];
                    CandidateTrace ResponseCandidate(ResponseChoice response) => new(response.ToString(), response.ToString(), true, "",
                        scripted ? ImmutableDictionary<string, long>.Empty : ImmutableDictionary<string, long>.Empty.Add("ResponsePreference",
                            (profile == "SCORE-RP-001") == (response == ResponseChoice.Accept) ? 100 : 0),
                        scripted ? null : (profile == "SCORE-RP-001") == (response == ResponseChoice.Accept) ? 100 : 0, response == choice);
                    decisions.Add(new(respondent, proposal.Id, "Response", scripted ? "MECHANISM-RESPONSE-v1" : profile,
                        [.. candidates], [$"OwnGrain:{decisionSnapshot.People[respondent].Grain}", $"Proposal:{proposal.Id.Value}"], false));
                    cause = Record("Response", proposal.Id, [respondent], [proposed.Id], [], choice.ToString()).Id;
                    if (choice == ResponseChoice.Decline)
                    {
                        Outcome declined = Finish(proposal, OutcomeKind.Declined, "VoluntaryRefusal", cause, outcomes);
                        if (proposal.Terms is RequestGiftOrHelp or RequestLoan && decisionSnapshot.People[proposal.Actor].NeedsGrain)
                            batch.Add(new(new("GenuineNeedRefusal", declined.Event, proposal.Actor, respondent), -5));
                        continue;
                    }
                }
                accepted.Add((proposal, cause));
            }
            foreach (var attempt in accepted)
            {
                Proposal proposal = attempt.Proposal;
                string? loss = ActionRules.Invalid(proposal, state.Snapshot(cycle)) ?? ActionRules.Infeasible(proposal, state.Snapshot(cycle));
                bool fallback = accepted.Any(other => other.Proposal.Id != proposal.Id && Competes(proposal, other.Proposal, decisionSnapshot));
                if (loss is not null)
                    Finish(proposal, OutcomeKind.InvalidatedAtResolution, loss, attempt.Cause, outcomes, fallback);
                else
                {
                    SemanticEvent committed = Commit(proposal, attempt.Cause, fallback, batch);
                    outcomes.Add(new(proposal.Id, proposal.Actor, OutcomeKind.Committed, "", committed.Id));
                    Learn(proposal, outcomes[^1]);
                }
            }
            ReviewDebts(batch);
            CloseAttitudes(batch);
            published = state.Snapshot(cycle);
            bool deadlock = state.People.Count > 0 && state.People.Values.All(p => p.NeedsGrain && p.Grain == 0) &&
                !initial.Inputs.Any(i => i.Cycle > cycle && i.Delta > 0);
            return new(published, outcomes.ToImmutableArray(), events.Skip(start).ToImmutableArray(), deadlock) { Decisions = decisions.ToImmutableArray() };
        }
        catch
        {
            faulted = true;
            throw;
        }
    }

    private Outcome Finish(Proposal proposal, OutcomeKind kind, string reason, EventId cause, List<Outcome> outcomes, bool fallback = false)
    {
        PersonId? target = ActionRules.Target(proposal.Terms);
        SemanticEvent entry = Record(kind.ToString(), proposal.Id, target is { } t ? [proposal.Actor, t] : [proposal.Actor], [cause], [], reason, fallback);
        Outcome outcome = new(proposal.Id, proposal.Actor, kind, reason, entry.Id);
        outcomes.Add(outcome);
        if (kind != OutcomeKind.InvalidTerms) Learn(proposal, outcome);
        return outcome;
    }

    private void Learn(Proposal proposal, Outcome outcome)
    {
        PersonId? target = ActionRules.Target(proposal.Terms);
        PersonId[] participants = target is { } t ? [proposal.Actor, t] : [proposal.Actor];
        if (proposal.Terms is RepayDebt repay && state.Debts.TryGetValue(repay.Debt, out Debt? debt))
            participants = [proposal.Actor, debt.Creditor];
        foreach (PersonId participant in participants)
        {
            if (!knowledge.TryGetValue(participant, out var facts)) knowledge.Add(participant, facts = []);
            facts.Add(new(outcome.Event, outcome.Proposal, outcome.Kind, outcome.Reason));
        }
    }

    private static (PersonId Giver, PersonId Recipient, long Amount)? Transfer(Proposal proposal, WorldSnapshot snapshot) => proposal.Terms switch
    {
        OfferGift gift => (proposal.Actor, gift.Target, gift.Amount),
        RequestGiftOrHelp help => (help.Target, proposal.Actor, help.Amount),
        OfferLoan loan => (proposal.Actor, loan.Target, loan.Amount),
        RequestLoan loan => (loan.Target, proposal.Actor, loan.Amount),
        RepayDebt repay => (proposal.Actor, snapshot.Debts[repay.Debt].Creditor, repay.Amount),
        _ => null
    };
    private static bool Competes(Proposal a, Proposal b, WorldSnapshot snapshot)
    {
        var left = Transfer(a, snapshot);
        var right = Transfer(b, snapshot);
        return left is { } l && right is { } r && l.Giver == r.Giver &&
            (System.Numerics.BigInteger)l.Amount + r.Amount > snapshot.People[l.Giver].Grain;
    }

    private SemanticEvent Commit(Proposal proposal, EventId cause, bool fallback, AttitudeBatch batch)
    {
        WorldState transaction = state.Copy();
        List<MaterialChange> material = [];
        string meaning;
        PersonId[] participants;
        if (proposal.Terms is Farm)
        {
            Person person = transaction.People[proposal.Actor];
            long after = checked(person.Grain + 4);
            transaction.People[person.Id] = person with { Grain = after };
            material.Add(new(person.Id, person.Grain, after, "FarmSource"));
            meaning = "Farm";
            participants = [person.Id];
        }
        else if (Transfer(proposal, state.Snapshot(cycle)) is { } transfer)
        {
            Person giver = transaction.People[transfer.Giver];
            Person recipient = transaction.People[transfer.Recipient];
            long received = checked(recipient.Grain + transfer.Amount);
            transaction.People[giver.Id] = giver with { Grain = checked(giver.Grain - transfer.Amount) };
            transaction.People[recipient.Id] = recipient with { Grain = received, NeedsGrain = false };
            meaning = proposal.Terms switch { OfferGift => "Gift", RequestGiftOrHelp => "Help", RepayDebt => "Repayment", _ => "Loan" };
            material.Add(new(giver.Id, giver.Grain, giver.Grain - transfer.Amount, meaning));
            material.Add(new(recipient.Id, recipient.Grain, received, meaning));
            participants = [giver.Id, recipient.Id];
            if (proposal.Terms is OfferLoan or RequestLoan)
            {
                RelationId id = transaction.AllocateRelation();
                transaction.Debts.Add(id, new(id, giver.Id, recipient.Id, transfer.Amount, transfer.Amount, cycle, false, new(nextEvent)));
            }
            if (proposal.Terms is RepayDebt repay)
            {
                Debt debt = transaction.Debts[repay.Debt];
                transaction.Debts[debt.Id] = debt with { Remaining = debt.Remaining - repay.Amount };
            }
        }
        else throw new InvalidOperationException("Unimplemented commit meaning.");
        transaction.Validate();
        state = transaction;
        SemanticEvent entry = Record(meaning, proposal.Id, [.. participants], [cause], [.. material], proposal.Terms.ToString() ?? "", fallback);
        if (Transfer(proposal, state.Snapshot(cycle)) is { } helpTransfer)
            batch.Add(new(new(meaning, entry.Id, helpTransfer.Recipient, helpTransfer.Giver), meaning is "Loan" or "Repayment" ? 5 : 10));
        return entry;
    }

    private void ReviewDebts(AttitudeBatch batch)
    {
        foreach (Debt debt in state.Debts.Values.Where(d => !d.DueReviewed && cycle >= checked(d.CommittedCycle + 3)).OrderBy(d => d.Id.Value).ToArray())
        {
            state.Debts[debt.Id] = debt with { DueReviewed = true };
            SemanticEvent review = Record("DebtSocialDueReview", null, [debt.Creditor, debt.Debtor], [debt.Origin], [],
                debt.Remaining > 0 ? "UnpaidBalance" : "Satisfied");
            if (debt.Remaining > 0) batch.Add(new(new("UnpaidDebt", review.Id, debt.Creditor, debt.Debtor), -10));
            state.Validate();
        }
    }

    private void CloseAttitudes(AttitudeBatch batch)
    {
        foreach (var group in batch.Close().GroupBy(c => (c.Key.From, c.Key.To)))
        {
            Attitude? current = state.Attitudes.Values.SingleOrDefault(a => a.From == group.Key.From && a.To == group.Key.To);
            long sum = current?.Value ?? 0;
            foreach (var contribution in group) sum = checked(sum + contribution.Delta);
            int after = (int)Math.Clamp(sum, -100, 100);
            RelationId id = current?.Id ?? state.AllocateRelation();
            state.Attitudes[id] = new(id, group.Key.From, group.Key.To, after);
            SemanticEvent entry = Record("AttitudeComposition", null, [group.Key.From, group.Key.To],
                group.Select(c => c.Key.Trigger).Distinct().ToImmutableArray(), [], $"{current?.Value ?? 0}->{after}");
            events[^1] = entry with { Contributions = group.ToImmutableArray() };
            state.Validate();
        }
    }

    private void Maintenance()
    {
        foreach (GrainInput input in initial.Inputs.Where(i => i.Cycle == cycle).OrderBy(i => i.Id))
        {
            Person person = state.People[input.Person];
            long after = checked(person.Grain + input.Delta);
            if (after < 0) throw new InvalidOperationException("Exogenous debit exceeds stock.");
            state.People[person.Id] = person with { Grain = after, NeedsGrain = person.NeedsGrain && after == 0 };
            Record("ExogenousGrain", null, [person.Id], [], [new(person.Id, person.Grain, after, "FixtureInput")], $"Input:{input.Id}");
            state.Validate();
        }
        foreach (Person person in state.People.Values.OrderBy(p => p.Id.Value).ToArray())
        {
            if (person.Grain > 0)
            {
                state.People[person.Id] = person with { Grain = person.Grain - 1 };
                Record("Consumption", null, [person.Id], [], [new(person.Id, person.Grain, person.Grain - 1, "ConsumptionSink")], "Paid");
            }
            else
            {
                state.People[person.Id] = person with { NeedsGrain = true };
                Record("MissedConsumption", null, [person.Id], [], [], "NeedsGrain");
            }
            state.Validate();
        }
        if (cycle % 5 == 0)
            foreach (Attitude attitude in state.Attitudes.Values.OrderBy(a => a.Id.Value).ToArray())
            {
                int after = attitude.Value > 0 ? Math.Max(0, attitude.Value - 2) : Math.Min(0, attitude.Value + 1);
                state.Attitudes[attitude.Id] = attitude with { Value = after };
                Record("AttitudeDecay", null, [attitude.From, attitude.To], [], [], $"{attitude.Value}->{after}");
                state.Validate();
            }
    }

    private SemanticEvent Record(string kind, ProposalId? proposal, ImmutableArray<PersonId> participants,
        ImmutableArray<EventId> causes, ImmutableArray<MaterialChange> material, string detail, bool fallback = false)
    {
        SemanticEvent entry = new(new(checked(nextEvent++)), cycle, checked(reactionIndex++), kind, proposal,
            participants, causes, material, detail, initial.Configuration.Version, fallback);
        events.Add(entry);
        return entry;
    }
}
