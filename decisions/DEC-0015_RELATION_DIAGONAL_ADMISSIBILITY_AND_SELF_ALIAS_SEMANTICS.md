# DEC-0015 — Relation Diagonal Admissibility and Self-Alias Semantics

**Status:** ACCEPTED  
**Authority level:** Architectural / social-semantic / architecture-governance  
**Date opened:** 2026-09-25  
**Date resolved:** 2026-09-25  
**Approver:** Human Project Director

## Problem

The retrospective Slice-1 Semantic Interaction Delta audit found that the project had no general accepted rule for two related but distinct questions:

1. when multiple person-valued semantic positions inside one interaction may collapse to the same PersonId;
2. when both endpoints of one typed social relation may be the same entity.

Earlier accepted work already established that one person may legitimately occupy several semantic capacities in the same broader history and that fake self-negotiation should not be manufactured merely because capacities are represented separately. At the same time, some relation/action meanings intrinsically require another person while others may have useful diagonal/self-directed forms.

A universal `A != B` rule would erase valid future semantics. A universal self-alias permission would silently invent semantics for actions and relation types that do not yet define them.

## Decision

### D1 — Interaction-role aliasing is meaning-specific

There is **no project-wide rule that all person-valued semantic positions must be distinct**.

For every interaction/action meaning, participant-position aliasing is owned by that meaning.

Already accepted multi-capacity and cross-action/cross-claim aliases remain valid, including:

- one person taking a personal action while separately answering incoming proposals;
- one person answering multiple proposal contexts from the common snapshot;
- one scarce material source participating in multiple attempts that later conflict at central resolution;
- one person occupying compatible capacities across separate claims/actions;
- outer `CallFavor` holder = inner `RepayDebt` creditor in an otherwise valid two-party repayment;
- several distinct direct causes converging on the same directed attitude edge;
- accepted Slice-4 multi-capacity cases under DEC-0013, including self-nomination and head/private-resource dual capacity.

For the **current bounded Slice-1 interpersonal proposal meanings**, self-counterparty interaction is **not enabled** unless separately and explicitly authorized. This includes:

- `OfferGift`;
- `RequestGiftOrHelp`;
- `OfferLoan`;
- `RequestLoan`;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help;
- `CallFavor` holder versus called actor.

For those current meanings:

- initiator/authorizer and named counterparty must be distinct PersonIds;
- an invalid self-counterparty term is rejected before any counterparty `ResponseDecisionContext`;
- no artificial self-Accept/Decline/Fulfil/Refuse context is created;
- no same-identity debit/credit is treated as a valid interpersonal transfer;
- no social success/refusal/failed-attempt consequence is created from the categorically invalid self-counterparty term.

This is a bounded current-semantic rule, not a claim that future self-interactions are generally meaningless. A future interaction may explicitly authorize a collapsed/self form and define its cognition, initiative, material, knowledge, and provenance semantics.

### D2 — Typed-relation diagonal admissibility is type-specific

There is **no project-wide rule that both endpoints of every typed relation must be distinct**.

Every typed relation/claim introduced or materially reconceptualized must explicitly classify diagonal/self-endpoint admissibility as part of that relation's semantics.

The owning semantic authority must establish one of the following substantive outcomes, using equivalent wording if clearer:

1. **diagonal allowed** — same-entity endpoints are meaningful and their behavior is defined;
2. **diagonal not enabled in current semantics** — the architecture should preserve representational room, but current valid state/transitions may not create or accept the diagonal;
3. **diagonal inapplicable / structurally excluded** — endpoint typing or the relation's accepted meaning makes self-identity nonsensical or impossible.

The classification belongs in the owning relation's decision/specification. It is **not** a global runtime policy table and does not require a global registry.

Generic relation storage/index/schema machinery must not impose a universal endpoint-inequality invariant merely for convenience. Type-specific validators may enforce the owning relation's accepted rule.

Relation-diagonal admissibility does not automatically authorize a self-addressed interaction that could create such a relation. Interaction-role aliasing and relation-state admissibility remain separate semantic questions.

## Current v0 classifications

### Attitude — diagonal allowed

`Attitude(P,P)` is valid typed state.

- it uses the ordinary bounded integer domain [-100,+100];
- ordinary attitude maintenance/decay applies;
- causal history for any explicit future/self-directed cause remains ordinary attitude history;
- its existence does not make P a valid counterparty for an interaction whose own participant-alias rule forbids self-counterparty use;
- no new current-v0 action, scorer meaning, psychological interpretation, or historical claim is created merely by allowing the state.

This deliberately preserves room for future self-directed social/cognitive interpretation without defining that later meaning now.

### Debt — diagonal not enabled in current v0

Current v0 Debt requires distinct creditor and debtor PersonIds.

- a diagonal Debt is not a valid current claim;
- initialization/import/fixtures and current transitions may not introduce it;
- generic relation architecture must not make future diagonal Debt support impossible;
- future support would require a separate semantic decision defining material, repayment, due-review, attitude, history, and knowledge behavior.

### Favour — diagonal not enabled in current v0

Current v0 Favour requires distinct holder and debtor PersonIds.

- a diagonal Favour is not a valid current claim;
- initialization/import/fixtures and current transitions may not introduce it;
- generic relation architecture must preserve the future seam;
- future support would require explicit call/fulfil/refuse, consumption, attitude, history, and cognition semantics.

### Kinship — diagonal structurally excluded in current meaning

Parent/child and sibling relations require distinct people.

### Marriage — diagonal structurally excluded in current bounded meaning

Current groom/bride roles require distinct people. This decision does not generalize future marriage semantics.

### Residence — diagonal classification not applicable to the stored relation

Residence is Person -> Dwelling, so same-typed endpoint diagonal identity is not applicable. The separate Residence proposal semantics already require another person as the named counterpart.

## Governance consequence

The diagonal-admissibility classification duty is institutionalized as a semantic-development rule.

When a new typed relation/claim is conceptualized, or an existing one is materially reconceptualized:

- classify endpoint identity domains;
- explicitly decide diagonal admissibility or record why it is inapplicable;
- keep the rule local to the owning semantics;
- do not let generic representation or implementation convenience silently decide it;
- where diagonal behavior is deliberately left for later, preserve a future seam without implementing future semantics.

The Architecture Development Policy owns the early design rule.

The Specification-to-Implementation Assurance Protocol rechecks it before consequential implementation.

The Semantic Interaction Delta checklist continues to own cross-action participant-alias challenge where materially triggered.

## Rationale

This preserves the project's typed, causally explicit social-fabric philosophy while avoiding two opposite errors:

- prematurely forbidding future self-directed relation types through a generic `A != B` infrastructure assumption;
- prematurely inventing self-interaction behavior for every relation/action merely because the representation could encode it.

It also generalizes the useful principle already accepted in DEC-0013:

> When one person legitimately occupies multiple semantic capacities, preserve the meaningful predicates without manufacturing redundant self-negotiation.

The correct unit of decision is the owning semantic meaning, not a universal technical identity rule.

## Explicit exclusions

This decision does not:

- create a generic self-relation framework;
- create a global relation-type registry;
- create a runtime diagonal-policy engine;
- authorize every relation to be self-directed;
- authorize current self-gift, self-loan, self-favour-call, or other self-counterparty interactions;
- define psychological semantics for self-attitude;
- define future self-debt or self-favour behavior;
- rewrite frozen Slice-1 v1 historical acceptance evidence;
- weaken accepted valid cross-action/cross-claim aliasing.

## Promotion consequences

1. Promote the rule into current `SPEC-SFL-0001`.
2. Add omission-detectable canonical verification for:
   - current self-counterparty rejection before response;
   - valid diagonal Attitude;
   - current diagonal Debt/Favour rejection;
   - preservation of valid cross-action/cross-claim aliases.
3. Amend architecture/assurance governance so future relation conceptualization cannot omit diagonal classification.
4. Close the retrospective Slice-1 SID semantic gap.
5. Create a successor Slice-1 acceptance authority; frozen v1 remains immutable historical evidence.
6. Reconcile current implementation against the successor authority.
7. Because inherited authority materially changes, issue a corrected Slice-5 acceptance candidate and fresh whole-candidate review before Slice-5 freeze/coding.

## Lineage

- `tasks/research/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`
- `research/technical/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`
- `research/technical/SID_RETRO_SLICE1_PASSB_RECONCILIATION.md`
- `proposals/SFL_V0_SLICE1_RETRO_SID_OPEN_SEMANTIC_DECISIONS.md`
- DEC-0012 / `SID-ASSURANCE-v1`
- DEC-0013 multi-capacity semantic precedent

## Director disposition

**APPROVED — 2026-09-25.**

The Project Director explicitly approved the meaning-specific self-alias approach and the relation-specific diagonal-admissibility model, emphasizing that future typed relations must be classified when conceptualized and that this instinct must be institutionalized at the correct governance level.
