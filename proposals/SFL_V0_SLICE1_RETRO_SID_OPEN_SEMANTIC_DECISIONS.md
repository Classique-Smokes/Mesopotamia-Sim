# Slice 1 Retrospective SID — Open Semantic Decisions

**Status:** RESOLVED / SUPERSEDED BY DEC-0015  
**Date:** 2026-09-25  
**Source:** `research/technical/SID_RETRO_SLICE1_PASSB_RECONCILIATION.md`  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Authority:** historical proposal only; operative authority is DEC-0015

## Purpose

The retrospective Slice-1 SID sequence is complete through:

- screening;
- independent Pass A;
- Master Architect frontier;
- reconciled frontier union;
- independent Pass B;
- Master Architect authority reconciliation.

The audit found no broad need to redesign Slice 1.

Two tightly related identity questions remain genuinely unresolved. They concern **within-one-interaction self-aliasing and diagonal social state only**.

Already accepted cross-action/cross-claim reuse must remain legal.

## D1 — Must current Slice-1 interpersonal action counterparties be distinct people?

### Question

For current Slice-1 lower-level interpersonal action meanings, may the initiating/authorizing person and the named counterparty be the same `PersonId` within one interaction?

Affected current meanings include:

- `OfferGift`;
- `RequestGiftOrHelp`;
- `OfferLoan`;
- `RequestLoan`;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help;
- `CallFavor` holder versus called actor.

Residence and direct marriage are already independently closed by existing authority and are not being reopened.

### Option A — require distinct people within each interpersonal interaction

For the affected current Slice-1 meanings:

- initiating/authorizing person and named counterparty must be distinct `PersonId` values;
- invalid self-counterparty terms are rejected before any counterparty response context;
- no self-addressed Accept/Decline/Fulfil/Refuse decision is created;
- no same-identity material debit/credit is treated as an interpersonal transfer;
- no direct social consequence is created merely from an invalid self-counterparty attempt.

This is **not** a global all-roles-distinct rule.

It must continue to permit:

- one person acting personally while separately responding to another interaction;
- one person responding to multiple proposals;
- one person serving as a material source in multiple attempts;
- role recurrence across distinct claims/actions;
- outer CallFavor holder = inner debt creditor in an otherwise valid two-party repayment;
- multiple direct causes converging on one directed attitude edge.

### Option B — permit at least some self-counterparty interactions

Each permitted meaning must then explicitly define:

- how self-response cognition works;
- whether response remains separate from personal initiative;
- whether same-owner debit/credit is a material transfer or no-op;
- whether social success/failure consequences apply;
- participant-knowledge cardinality;
- semantic history/provenance;
- whether the interaction may create diagonal Debt/Favour state.

This is a larger semantic addition and cannot be inferred from current implementation.

### Master Architect recommendation

**Approve Option A.**

It is the smallest rule consistent with the accepted description of these meanings as interpersonal attempts/proposals subject to other actors, while preserving every positively supported cross-action and cross-claim alias found by the audit.

It closes the gap without inventing redundant self-negotiation mechanics.

---

## D2 — May Slice-1 typed social state be diagonal?

### Question

May a person occupy both semantic endpoints of the same typed Slice-1 social state?

Specifically:

- `Attitude(P,P)`;
- `Debt(creditor=P, debtor=P)`;
- `Favour(holder=P, debtor=P)`.

### Option A — prohibit diagonal typed interpersonal state

For bounded Slice 1:

- directed Attitude requires two distinct people;
- Debt creditor and debtor must be distinct;
- Favour holder and debtor must be distinct;
- initialization/import/test fixtures may not introduce those diagonal states;
- ordinary state-transition authority may not create them;
- validation must preserve the distinction without prohibiting legitimate role reuse across separate interactions/claims.

Combined with D1 Option A, all current endogenous creation routes remain coherent and no self-directed social consequence is needed.

### Option B — permit one or more diagonal state types

Each permitted diagonal must receive explicit semantics for:

- identity/cardinality;
- creation and termination;
- material consequences;
- attitude updates;
- due/review behavior for self-debt;
- call/fulfil/refuse behavior for self-favour;
- causal history;
- participant knowledge;
- verification and initialization validity.

This would be a substantive expansion of bounded Slice-1 semantics.

### Master Architect recommendation

**Approve Option A.**

Attitude, Debt and Favour are all accepted as directed/interpersonal social meanings. Allowing a single person to occupy both ends creates new behavior not specified by the existing Slice-1 contract.

Explicitly excluding the diagonal is narrower than defining a new class of self-social relations.

## Already closed / must not be changed by this decision

The decision should not alter:

- valid same-person reuse across separate actions;
- multiple response contexts for one target;
- common-snapshot conflict over one person's scarce resource;
- reciprocal claims between two distinct people;
- nested CallFavor repayment where the favour holder is also the debt creditor;
- direct-cause sum-then-clamp behavior on the same directed edge;
- Residence's existing **another person** requirement;
- direct-marriage and kinship structural endpoint constraints.

## Combined recommended package

The Master Architect recommends:

- **D1 A** — current Slice-1 interpersonal action counterparties must be distinct people;
- **D2 A** — Attitude, Debt and Favour typed state may not be diagonal.

Scoped principle:

> Within one bounded Slice-1 interpersonal relation or counterparty interaction, the two interpersonal endpoints are distinct people. This does not prohibit one person from legitimately occupying multiple capacities across separate actions, claims, responses, or nested compositions.

## Consequence of approval

If either D1 or D2 creates new explicit current authority:

1. record the Director decision;
2. promote the exact bounded rule into current SPEC/canonical verification without rewriting frozen Slice-1 v1 historical evidence;
3. create a successor Slice-1 acceptance candidate containing omission-detectable identity-boundary rows;
4. run fresh independent whole-candidate acceptance review and freeze the successor only on PASS;
5. reconcile current implementation against the successor authority, including explicit boundary evidence;
6. only after inherited authority is current, issue a corrected Slice-5 acceptance candidate;
7. run a fresh whole-candidate Slice-5 review before freeze/coding.

Slice-5 candidate1 and its R2 PASS remain immutable historical evidence; they are not silently reinterpreted as covering the new inherited authority.


## Director disposition / supersession

**RESOLVED — 2026-09-25.**

The Project Director did not adopt the proposal's original blanket D1-A/D2-A framing unchanged.

The approved refinement is recorded in:

`decisions/DEC-0015_RELATION_DIAGONAL_ADMISSIBILITY_AND_SELF_ALIAS_SEMANTICS.md`

Key refinement:

- participant aliasing is meaning-specific rather than globally prohibited;
- current bounded Slice-1 self-counterparty proposal forms remain unenabled;
- diagonal admissibility is owned by each typed relation;
- `Attitude(P,P)` is valid current state;
- diagonal Debt/Favour remain future-preserved but not current-v0 valid claims;
- future typed relations must classify diagonal admissibility when conceptualized.

This proposal is retained for decision lineage only.
