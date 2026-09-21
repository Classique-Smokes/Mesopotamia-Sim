# SPEC-SFL-0001 — Stage-3 Errata / Director Decisions

**Status:** RESOLVED / HISTORICAL WORKING RECORD  
**Date:** 2026-09-21  
**Authority:** Working errata proposal only. This file does not alter accepted semantics until approved and promoted into `SPEC-SFL-0001`.

Triggered by:

- `research/technical/TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`

## Already restored without new decision

Two corrections were restored directly into the accepted spec because they are consequences/details already approved in the closed working record rather than new social rules:

1. successful formation creates provenance-bearing `SustainingParticipant` associations for every founding-core person;
2. any current sustaining participant may nominate a current sustaining participant for head; an outgoing head may nominate a successor before vacancy.

## Decision ERR-SFL-001 — Candidate recognition sufficiency

### Gap

Formation requires every required founder to recognize a pre-household candidate, but the accepted spec does not define when that subjective recognition becomes `Recognized`.

### Recommended v0 rule

Introduce ephemeral/provenance-bearing `CandidateRecognition(C)`.

A founder recognizes candidate C when that actor's own subjective state contains **uncontested evidence sufficient to establish the objective formation predicate for the proposed founding core**:

- shared residence of the core;
- connected durable-tie structure;
- two qualifying committed support events on distinct cycles.

The actor does **not** need evidence that other founders also recognize C.

`CandidateRecognition`:

- grants no household powers;
- is not household identity;
- cannot count as evidence for itself;
- may be reached through direct participation/observation/communication under ordinary knowledge rules.

### Rationale

This keeps objective warrant and subjective recognition aligned without higher-order-belief recursion or global knowledge.

## Decision ERR-SFL-002 — Sustaining-participant entry/exit after formation

### Gap

The accepted spec requires continuity through changing sustaining participants but does not define how a non-founder becomes, or an existing participant ceases to be, a `SustainingParticipant`.

### Recommended v0 direction

Represent changes through explicit provenance-bearing `ParticipationWarrant` / `ParticipationEndWarrant`, not raw association writes.

#### Entry recommendation

A nonparticipant becomes a sustaining participant of active H only when:

- they recognize H;
- at least one current sustaining participant recognizes the same continuing H and serves as continuity bridge;
- they share residence with at least one current sustaining participant;
- they have a durable tie to at least one current sustaining participant;
- at least one qualifying committed support event has occurred between them and a current sustaining participant after H exists;
- the newcomer and bridging participant both accept/recognize that the newcomer is participating in H's sustaining organization.

The resulting `ParticipationWarrant` creates the association.

This is deliberately less demanding than re-forming H, because H already exists and continuity is supplied by the bridging participant.

#### Exit recommendation

A sustaining participant may explicitly cease participation through a `ParticipationEnd` proposal/commit.

- it ends only that typed association;
- it does not erase lower-level kinship/marriage/debt/favour/residence/history;
- it does not by itself dissolve H;
- household lifecycle/continuity is recomputed from the remaining sustaining organization;
- the historical association remains queryable.

This explicit end action is scoped to the typed sustaining relation; it is not a universal household-membership primitive.

### Rationale

A purely snapshot-derived exit condition would require an arbitrary inactivity timer or would make residence/property proxies silently control household structure. A provenance-bearing end event is more inspectable and keeps the household's reaction distinct from the individual's association change.

## Decision ERR-SFL-003 — Knowledge condition for the debt nonpayment attitude penalty

### Gap

The accepted rule gives creditor -> debtor -10 for knowingly retaining repayable debt while able, but no rule says how the creditor can know the debtor was materially able.

### Recommended v0 rule

Do **not** add `RequestRepayment` in v0.

Apply the -10 event only when:

- debt remains outstanding after the debtor's personal initiative for that cycle;
- debtor objectively had repayable surplus under the 2-grain reserve rule at the relevant decision snapshot; and
- creditor's subjective state contains valid current evidence sufficient to know that repayable surplus existed.

The creditor knows whether repayment was actually received because they are a direct party to the debt.

If the creditor lacks current evidence of debtor ability, no automatic -10 attitude event occurs.

### Rationale

This preserves the already accepted debt concern without introducing a new creditor-initiated action or engine omniscience.

## Resolution

Director approved the candidate-recognition rule and the participation-warrant direction, with explicit bilateral invitation/request added so established-household participation is conscious rather than engine-imposed.

Director replaced the proposed knowledge-conditioned debt penalty with a social due cycle: review after the third subsequent full cycle; if any balance remains, creditor -> debtor attitude changes -10 once regardless of debtor ability.

These changes are incorporated into `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`.

`RequestRepayment` was not added.
