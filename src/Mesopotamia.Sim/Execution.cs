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
    public ImmutableDictionary<PersonId, PersonalPolicy> PersonalPolicies { get; init; } = ImmutableDictionary<PersonId, PersonalPolicy>.Empty;
    public ImmutableDictionary<ProposalId, string> ProposalResponseProfiles { get; init; } = ImmutableDictionary<ProposalId, string>.Empty;
}
public enum OutcomeKind { Committed, Declined, Unable, InvalidatedAtResolution, InvalidTerms }
public sealed record Outcome(ProposalId Proposal, PersonId Actor, OutcomeKind Kind, string Reason, EventId Event);
public sealed record MaterialChange(PersonId Person, long Before, long After, string Meaning);
public sealed record SemanticEvent(EventId Id, long Cycle, int ReactionIndex, string Kind,
    ProposalId? Proposal, ImmutableArray<PersonId> Participants, ImmutableArray<EventId> Causes,
    ImmutableArray<MaterialChange> Material, string Detail, string ConfigurationVersion, bool TechnicalFallback = false)
{
    public ImmutableArray<AttitudeContribution> Contributions { get; init; } = [];
    public ActionTerms? Action { get; init; }
}
public sealed record CycleResult(WorldSnapshot State, ImmutableArray<Outcome> Outcomes,
    ImmutableArray<SemanticEvent> Events, bool MaterialDeadlock)
{
    public ImmutableArray<DecisionTrace> Decisions { get; init; } = [];
}

public sealed partial class Simulation
{
    internal enum ReactionChallenge { None, DuplicateCauses, ReverseCauses, SkipClosure }
    internal ReactionChallenge Challenge { get; init; }
    public bool IsFaulted => faulted;
    private readonly List<SemanticEvent> events = [];
    private long nextEvent = 1;
    private int reactionIndex;
    private bool faulted;
    private readonly HashSet<ProposalId> usedProposals = [];
    private readonly Dictionary<PersonId, List<ParticipantOutcome>> knowledge = [];
    private readonly List<DecisionTrace> decisionHistory = [];
    private long nextProposal = 1;
    public ImmutableArray<SemanticEvent> History => events.ToImmutableArray();
    public ImmutableArray<DecisionTrace> DecisionHistory => decisionHistory.ToImmutableArray();
    public CycleResult RunAutonomousCycle() => RunCycle(new([])
    { PersonalPolicies = state.People.Keys.ToImmutableDictionary(p => p, _ => new PersonalPolicy()) });
    public ImmutableArray<ParticipantOutcome> KnowledgeOf(PersonId person) =>
        knowledge.TryGetValue(person, out var facts) ? facts.ToImmutableArray() : [];

    public CycleResult RunCycle(CycleInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (faulted) throw new InvalidOperationException("A failed cycle cannot be resumed.");
        if (input.Proposals.Select(p => p.Actor).Distinct().Count() != input.Proposals.Length)
            throw new ArgumentException("At most one personal initiative per person/cycle.", nameof(input));
        if (input.PersonalPolicies.Keys.Any(p => !state.People.ContainsKey(p) || input.Proposals.Any(proposal => proposal.Actor == p)))
            throw new ArgumentException("A context cannot receive a scripted and autonomous initiative.", nameof(input));
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
            List<Proposal> proposals = [.. input.Proposals];
            nextProposal = Math.Max(nextProposal, checked(proposals.Select(p => p.Id.Value).DefaultIfEmpty(0).Max() + 1));
            foreach (var policy in input.PersonalPolicies.OrderBy(p => p.Key.Value))
            {
                var decision = PersonalAgency.Decide(PersonalInputCapture.Capture(policy.Key, policy.Value, decisionSnapshot));
                ProposalId? id = null;
                if (decision.Terms is not null)
                {
                    id = new ProposalId(checked(nextProposal++));
                    proposals.Add(new(id.Value, policy.Key, decision.Terms));
                }
                decisions.Add(decision.Trace with { Proposal = id });
            }
            List<(Proposal Proposal, EventId Cause)> accepted = [];
            AttitudeBatch batch = new();
            foreach (Proposal proposal in proposals.OrderBy(p => p.Id.Value))
            {
                usedProposals.Add(proposal.Id);
                string? invalid = ActionRules.Invalid(proposal, decisionSnapshot);
                SemanticEvent proposed = Record("Proposal", proposal.Id, [proposal.Actor], [], [], ActionRules.Describe(proposal.Terms));
                events[^1] = proposed with { Action = proposal.Terms };
                if (invalid is not null)
                {
                    Finish(proposal, OutcomeKind.InvalidTerms, invalid, proposed.Id, outcomes);
                    continue;
                }
                string? inability = ActionRules.Infeasible(proposal, decisionSnapshot);
                PersonId? target = ActionRules.Target(proposal.Terms, decisionSnapshot);
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
                    bool called = proposal.Terms is CallFavor;
                    ResponseChoice accept = called ? ResponseChoice.FulfilCalledFavor : ResponseChoice.Accept;
                    ResponseChoice refuse = called ? ResponseChoice.RefuseCalledFavor : ResponseChoice.Decline;
                    string profile = input.ProposalResponseProfiles.GetValueOrDefault(proposal.Id,
                        input.ResponseProfiles.GetValueOrDefault(respondent, called ? "SCORE-RP-003" : "SCORE-RP-001"));
                    if (called ? profile is not ("SCORE-RP-003" or "SCORE-RP-004") : profile is not ("SCORE-RP-001" or "SCORE-RP-002"))
                        throw new ArgumentException("Unsupported response profile for this meaning.", nameof(input));
                    bool prefersAccept = profile is "SCORE-RP-001" or "SCORE-RP-003";
                    ResponseChoice choice = input.Responses.GetValueOrDefault(proposal.Id,
                        prefersAccept ? accept : refuse);
                    if (choice != accept && choice != refuse)
                        throw new ArgumentException("Response meaning does not belong to proposal.", nameof(input));
                    bool scripted = input.Responses.ContainsKey(proposal.Id);
                    CandidateTrace[] candidates = [ResponseCandidate(accept), ResponseCandidate(refuse)];
                    if (!scripted)
                    {
                        candidates = candidates.Select(c => c with { FinalScore = ReferenceScorer.Sum(c.Components.Values), Selected = false }).ToArray();
                        var selected = ReferenceScorer.Select(candidates);
                        choice = selected.Key == accept.ToString() ? accept : refuse;
                        candidates = candidates.Select(c => c with { Selected = c.Key == selected.Key }).ToArray();
                    }
                    CandidateTrace ResponseCandidate(ResponseChoice response) => new(response.ToString(), response.ToString(), true, "",
                        scripted ? ImmutableDictionary<string, long>.Empty : ImmutableDictionary<string, long>.Empty.Add(called ? "ObligationResponse" : "ResponsePreference",
                            prefersAccept == (response == accept) ? 100 : 0),
                        scripted ? null : prefersAccept == (response == accept) ? 100 : 0, response == choice);
                    decisions.Add(new(respondent, proposal.Id, "Response", scripted ? "MECHANISM-RESPONSE-v1" : profile,
                        [.. candidates], [$"OwnGrain:{decisionSnapshot.People[respondent].Grain}", $"Proposal:{proposal.Id.Value}"], false));
                    cause = Record("Response", proposal.Id, [respondent], [proposed.Id], [], choice.ToString()).Id;
                    if (choice == refuse)
                    {
                        Outcome declined = Finish(proposal, OutcomeKind.Declined, "VoluntaryRefusal", cause, outcomes);
                        if (proposal.Terms is RequestGiftOrHelp or RequestLoan or RelationshipMediatedReciprocalHelp { Request: true } &&
                            decisionSnapshot.People[proposal.Actor].NeedsGrain)
                            batch.Add(new(new("GenuineNeedRefusal", declined.Event, proposal.Actor, respondent), -5));
                        if (called) batch.Add(new(new("CalledFavourRefusal", declined.Event, proposal.Actor, respondent), -20));
                        continue;
                    }
                }
                accepted.Add((proposal, cause));
            }
            HashSet<PersonId> moved = [];
            HashSet<ProposalId> resolutionFallbacks = ResolutionFallbacks([.. accepted.Select(a => a.Proposal)], decisionSnapshot);
            foreach (var attempt in accepted)
            {
                Proposal proposal = attempt.Proposal;
                string? loss = ResolutionLoss(proposal, state.Snapshot(cycle), moved);
                bool fallback = resolutionFallbacks.Contains(proposal.Id);
                if (loss is not null)
                    Finish(proposal, OutcomeKind.InvalidatedAtResolution, loss, attempt.Cause, outcomes, fallback);
                else
                {
                    SemanticEvent committed = Commit(proposal, attempt.Cause, fallback, batch);
                    if (ActionRules.Mover(proposal) is { } movedPerson) moved.Add(movedPerson);
                    outcomes.Add(new(proposal.Id, proposal.Actor, OutcomeKind.Committed, "", committed.Id));
                    Learn(proposal, outcomes[^1]);
                }
            }
            ReviewDebts(batch);
            if (Challenge == ReactionChallenge.DuplicateCauses)
                foreach (AttitudeContribution contribution in batch.Pending) batch.Add(contribution);
            if (Challenge == ReactionChallenge.ReverseCauses)
            {
                AttitudeBatch reversed = new();
                foreach (AttitudeContribution contribution in batch.Pending.Reverse()) reversed.Add(contribution);
                batch = reversed;
            }
            if (Challenge != ReactionChallenge.SkipClosure) CloseAttitudes(batch);
            if (!batch.IsClosed) throw new InvalidOperationException("PendingAutomaticReactions");
            if (batch.DuplicateCount > 0) Record("DuplicateReactionRejected", null, [], [], [], FormattableString.Invariant($"Duplicates:{batch.DuplicateCount}"));
            published = state.Snapshot(cycle);
            bool deadlock = state.People.Count > 0 && state.People.Values.All(p => p.NeedsGrain && p.Grain == 0) &&
                !FutureInputsResolveMaterialBlock();
            ImmutableArray<DecisionTrace> completedDecisions = decisions.Select(d => d with { Cycle = cycle }).ToImmutableArray();
            decisionHistory.AddRange(completedDecisions);
            return new(published, outcomes.ToImmutableArray(), events.Skip(start).ToImmutableArray(), deadlock) { Decisions = completedDecisions };
        }
        catch
        {
            faulted = true;
            throw;
        }
    }

    private Outcome Finish(Proposal proposal, OutcomeKind kind, string reason, EventId cause, List<Outcome> outcomes, bool fallback = false)
    {
        PersonId? target = ActionRules.Target(proposal.Terms, state.Snapshot(cycle));
        SemanticEvent entry = Record(kind.ToString(), proposal.Id, target is { } t ? [proposal.Actor, t] : [proposal.Actor], [cause], [], reason, fallback);
        events[^1] = entry with { Action = proposal.Terms };
        Outcome outcome = new(proposal.Id, proposal.Actor, kind, reason, entry.Id);
        outcomes.Add(outcome);
        if (kind != OutcomeKind.InvalidTerms) Learn(proposal, outcome);
        return outcome;
    }

    private void Learn(Proposal proposal, Outcome outcome)
    {
        PersonId? target = ActionRules.Target(proposal.Terms, state.Snapshot(cycle));
        PersonId[] participants = target is { } t ? [proposal.Actor, t] : [proposal.Actor];
        if (proposal.Terms is RepayDebt repay && state.Debts.TryGetValue(repay.Debt, out Debt? debt))
            participants = [proposal.Actor, debt.Creditor];
        if (proposal.Terms is CancelReciprocalFavours cancel) participants = [proposal.Actor, cancel.Target];
        if (outcome.Kind == OutcomeKind.Committed && proposal.Terms is CallFavor { Requested: RepayDebt repayment } call)
            participants = [proposal.Actor, state.Favours[call.Favour].Debtor, state.Debts[repayment.Debt].Creditor];
        foreach (PersonId participant in participants.Distinct())
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
        OfferBenefitForFavor benefit => (proposal.Actor, benefit.Target, benefit.Amount),
        RelationshipMediatedReciprocalHelp help => help.Request ? (help.Target, proposal.Actor, help.Amount) : (proposal.Actor, help.Target, help.Amount),
        CallFavor call => Transfer(new(proposal.Id, snapshot.Favours[call.Favour].Debtor, call.Requested), snapshot),
        _ => null
    };
    private sealed record EvaluatedTransaction(WorldState State, Proposal EffectiveProposal, Favour? CalledFavour,
        string Meaning, PersonId[] Participants, List<MaterialChange> Material);

    private static EvaluatedTransaction EvaluateTransaction(WorldState source, Proposal proposal, long atCycle, EventId origin)
    {
        Favour? calledFavour = null;
        if (proposal.Terms is CallFavor call)
        {
            calledFavour = source.Favours[call.Favour];
            proposal = new(proposal.Id, calledFavour.Debtor, call.Requested);
        }
        WorldState transaction = source.Copy();
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
        else if (Transfer(proposal, source.Snapshot(atCycle)) is { } transfer)
        {
            Person giver = transaction.People[transfer.Giver];
            Person recipient = transaction.People[transfer.Recipient];
            long received = checked(recipient.Grain + transfer.Amount);
            transaction.People[giver.Id] = giver with { Grain = checked(giver.Grain - transfer.Amount) };
            transaction.People[recipient.Id] = recipient with { Grain = received, NeedsGrain = false };
            meaning = proposal.Terms switch
            {
                OfferGift => "Gift",
                RequestGiftOrHelp => "Help",
                RepayDebt => "Repayment",
                OfferBenefitForFavor => "ExplicitBenefitForFavor",
                RelationshipMediatedReciprocalHelp => "RelationshipMediatedReciprocalHelp",
                _ => "Loan"
            };
            material.Add(new(giver.Id, giver.Grain, giver.Grain - transfer.Amount, meaning));
            material.Add(new(recipient.Id, recipient.Grain, received, meaning));
            participants = [giver.Id, recipient.Id];
            if (proposal.Terms is OfferLoan or RequestLoan)
            {
                RelationId id = transaction.AllocateRelation();
                transaction.Debts.Add(id, new(id, giver.Id, recipient.Id, transfer.Amount, transfer.Amount, atCycle, false, origin));
            }
            if (proposal.Terms is RepayDebt repay)
            {
                Debt debt = transaction.Debts[repay.Debt];
                transaction.Debts[debt.Id] = debt with { Remaining = debt.Remaining - repay.Amount };
            }
            if (proposal.Terms is OfferBenefitForFavor ||
                (proposal.Terms is RelationshipMediatedReciprocalHelp &&
                source.Snapshot(atCycle).AttitudeOf(recipient.Id, giver.Id) >= 75 && !source.Snapshot(atCycle).HasFavour(recipient.Id, giver.Id)))
            {
                RelationId id = transaction.AllocateRelation();
                transaction.Favours.Add(id, new(id, recipient.Id, giver.Id, true, origin));
            }
        }
        else if (proposal.Terms is ProposeMarriage marriage)
        {
            RelationId id = transaction.AllocateRelation();
            transaction.Marriages.Add(id, new(id, proposal.Actor, marriage.Bride, origin));
            meaning = "DirectMarriage";
            participants = [proposal.Actor, marriage.Bride];
        }
        else if (ActionRules.Mover(proposal) is { } mover)
        {
            DwellingId destination = proposal.Terms is MoveResidence move ? move.Destination : ((InviteResidence)proposal.Terms).Destination;
            Residence residence = transaction.Residences.Values.Single(r => r.Person == mover);
            transaction.Residences[residence.Id] = residence with { Dwelling = destination };
            meaning = "ResidenceTransition";
            participants = [proposal.Actor, ActionRules.Target(proposal.Terms, source.Snapshot(atCycle))!.Value];
        }
        else if (proposal.Terms is CancelReciprocalFavours cancel)
        {
            foreach (Favour favour in transaction.Favours.Values.Where(f => f.Outstanding &&
                ((f.Debtor == proposal.Actor && f.Holder == cancel.Target) || (f.Holder == proposal.Actor && f.Debtor == cancel.Target))).ToArray())
                transaction.Favours[favour.Id] = favour with { Outstanding = false };
            meaning = "ReciprocalFavourCancellation";
            participants = [proposal.Actor, cancel.Target];
        }
        else throw new InvalidOperationException("Unimplemented commit meaning.");
        if (calledFavour is not null) transaction.Favours[calledFavour.Id] = calledFavour with { Outstanding = false };
        transaction.Validate();
        return new(transaction, proposal, calledFavour, meaning, participants, material);
    }

    private SemanticEvent Commit(Proposal proposal, EventId cause, bool fallback, AttitudeBatch batch)
    {
        Proposal outer = proposal;
        EvaluatedTransaction evaluated = EvaluateTransaction(state, proposal, cycle, new(nextEvent));
        state = evaluated.State;
        proposal = evaluated.EffectiveProposal;
        Favour? calledFavour = evaluated.CalledFavour;
        string meaning = evaluated.Meaning;
        PersonId[] participants = evaluated.Participants;
        List<MaterialChange> material = evaluated.Material;
        SemanticEvent entry = Record(meaning, proposal.Id, [.. participants], [cause], [.. material], ActionRules.Describe(proposal.Terms), fallback);
        events[^1] = entry with { Action = proposal.Terms };
        if (Transfer(proposal, state.Snapshot(cycle)) is { } helpTransfer && meaning != "ExplicitBenefitForFavor")
            batch.Add(new(new(meaning, entry.Id, helpTransfer.Recipient, helpTransfer.Giver), meaning is "Loan" or "Repayment" ? 5 : 10));
        if (calledFavour is not null)
        {
            SemanticEvent fulfilled = Record("CalledFavourFulfilled", outer.Id, [calledFavour.Holder, calledFavour.Debtor], [entry.Id, calledFavour.Origin], [], $"Favour:{calledFavour.Id.Value}");
            batch.Add(new(new("CalledFavourFulfilled", fulfilled.Id, calledFavour.Holder, calledFavour.Debtor), 10));
        }
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
            state.People[person.Id] = ApplyGrainInput(person, input.Delta);
            long after = state.People[person.Id].Grain;
            Record("ExogenousGrain", null, [person.Id], [], [new(person.Id, person.Grain, after, "FixtureInput")], $"Input:{input.Id}");
            state.Validate();
        }
        foreach (Person person in state.People.Values.OrderBy(p => p.Id.Value).ToArray())
        {
            if (person.Grain > 0)
            {
                state.People[person.Id] = ConsumeGrain(person);
                Record("Consumption", null, [person.Id], [], [new(person.Id, person.Grain, person.Grain - 1, "ConsumptionSink")], "Paid");
            }
            else
            {
                state.People[person.Id] = ConsumeGrain(person);
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
