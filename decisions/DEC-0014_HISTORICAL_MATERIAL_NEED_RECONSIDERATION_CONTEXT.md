# DEC-0014 — Historical Material-Need Context for Provision Reconsideration

**Status:** ACCEPTED  
**Authority:** Architectural / social-semantic  
**Opened:** 2026-09-25  
**Resolved:** 2026-09-25  
**Accepted by:** Project Director  
**Scope:** bounded SFL v0 interpretation of the existing `new household material need` reconsideration-context dimension

## Problem

SPEC-SFL-0001 §8.2 already requires both:

1. three full cycles after a provision refusal; and
2. at least one relevant context change since that refusal.

The accepted closed context-change list includes:

- the target person's grain / `NeedsGrain`;
- attitude toward the head;
- head occupant;
- a **new Household material need**.

IMP-0004 exposed that the final item was under-specified.

The implementation cannot determine, without inventing social semantics, whether a transient but qualifying support/dowry need that occurred after refusal must still be current when the head later re-asks for provision, whether funding failure prevents a dowry need from counting, or whether some additional head-level “adoption” action is required.

## Decision

### D1 — the cooldown is a deliberately crude v0 anti-badgering proxy

The three-cycle + relevant-context-change rule is intentionally a lightweight v0 approximation of:

> **Do not repeatedly ask someone who already refused unless enough time has passed and circumstances have meaningfully changed.**

It is not a historical claim, psychological model, bargaining theory, demand-management system, or mature theory of Household consent.

The literal three-cycle interval remains an arbitrary v0 laboratory constant.

Later richer behavior/negotiation machinery may replace this rule rather than inheriting it as permanent social ontology.

### D2 — material-need change is historical since the latest refusal

For the `new Household material need` limb, context change is **historical relative to the latest refusal baseline**.

A qualifying Household material-need occurrence after the refusal satisfies that context-change limb for that refusal even if the particular need is no longer current when reconsideration later becomes eligible.

The material need therefore does **not** have to coincide with the cycle in which the head asks again.

Cooldown and context change remain separate requirements:

- a need occurring immediately after refusal does not bypass the three full cycles;
- cooldown completion without any qualifying context change remains insufficient.

### D3 — a later refusal resets the baseline

If a later reconsideration request occurs and the target refuses again:

- that refusal becomes the new baseline;
- material-need occurrences before that new refusal cannot satisfy the context-change limb for a still later request;
- another accepted relevant context change must occur after the new refusal.

Thus one old dowry/support episode does not permanently authorize repeated future solicitation.

### D4 — qualifying support-need occurrence

Under the current v0 support route, a qualifying material-need occurrence includes a current sustaining participant **newly entering or re-entering** the accepted eligible Household-support need state after the refusal.

A support need that already existed at the refusal and merely remains continuously unchanged does not itself become “new” merely because additional cycles pass.

If that need clears and a later eligible support need occurs again after the refusal, the later occurrence qualifies.

### D5 — qualifying dowry-need occurrence

Under the current v0 mediated-marriage route, a qualifying material-need occurrence exists when, after the refusal:

- an otherwise-valid mediated-marriage route presents a positive dowry requirement to the Household/current-head authority path;
- all non-funding semantic gates required to make the request a legitimate mediated-marriage material demand are satisfied.

**Funding sufficiency is not required for the need to occur.**

Therefore a valid mediated-marriage request that becomes `Unable` because no valid funding plan exists may still establish the new-material-need context change.

This is intentional: lack of provision backing is exactly the circumstance in which a newly arising material demand can make later provision reconsideration meaningful.

No additional head “adopt need,” pending-demand, requisition, budget, or obligation action/state is introduced in v0.

The eventual response/commit result does not erase the fact that the qualifying material demand occurred.

### D6 — semantic occurrence, not technical proposal identity

A new technical ProposalId, container slot, retry object, or replay allocation identity cannot manufacture context change by itself.

The implementation must record/reconstruct the qualifying **semantic occurrence** and its causal provenance.

For the bounded v0 rule, once a qualifying new-material-need occurrence has been recorded for a refusal baseline, later duplicate/repeated occurrences do not add anything further to that baseline because the context-change predicate is already satisfied.

The current v0 does not attempt to model a general persistent demand lifecycle or decide whether temporally separated identical dowry requests belong to one long-lived real-world obligation. That richer distinction is deferred with the future resource/institution redesign seam.

## Distinguishing witness

Given:

1. cycle N: target A refuses H's provision request;
2. A's own grain/`NeedsGrain`, attitude toward head, head occupant, and support context otherwise remain unchanged;
3. cycle N+1: an otherwise-valid positive-dowry mediated-marriage request reaches the accepted H/head route but has no feasible funding plan and is therefore `Unable`;
4. the particular marriage demand need not remain active through N+4;
5. cycle N+4: H seeks provision from A again;

the expected result is:

> **A is eligible for reconsideration at N+4**, because the three-cycle cooldown has elapsed and the N+1 qualifying dowry material-need occurrence changed the historical reconsideration context after A's refusal.

If A then refuses again at N+4, the N+1 occurrence cannot satisfy the context-change limb for a later request after that new refusal.

## Binding consequences

- no persistent general Household-demand subsystem is added;
- no new head-adoption action is added;
- no Household treasury/budget/obligation model is implied;
- the existing context-change list remains closed;
- material-need occurrence must be authoritative/provenance-bearing enough for reconsideration and must not be reconstructed ad hoc from observer history;
- support and mediated-marriage are currently the only v0 material-use families capable of supplying this material-need dimension;
- technical proposal identity is non-authoritative;
- future richer individual behavior, bargaining, demand persistence, obligation management, or historically grounded economic design may supersede this crude cooldown mechanism.

## Acceptance / SID disposition

This decision defines one already-listed context dimension; it does not add a new Slice-4 acceptance category.

Frozen `SFL-V0-S4-ACCEPTANCE-v2` rows:

- `S4-074-RECONSIDERATION-COOLDOWN`;
- `S4-075-RECONSIDERATION-CONTEXT-CHANGE`;
- `S4-076-RECONSIDERATION-IRRELEVANT-CHANGE`;

remain sufficient and are not edited/reclassified.

The Slice-4 SID frontier is revalidated separately as **REVALIDATED — NO FRONTIER CHANGE** because this closes semantics inside the already-known provision-reconsideration/material-use frontier rather than introducing a new semantic surface.

## Explicit exclusions

This decision does not settle:

- general pending Household needs;
- formal adoption/prioritization of demands;
- obligation queues;
- budgets/treasuries;
- persistence/cancellation of generalized demands;
- bargaining/harassment psychology;
- historical Mesopotamian provision/dowry practice;
- general future Household economic ontology.

## Lineage

Implementation escalation:

`research/technical/IMP-0004/IMP-0004_IMPLEMENTATION_ESCALATION_01.md`

Project Director disposition:

- preferred historical-context interpretation over current-state-only gating;
- explicitly rejected solving the current v0 need through a larger persistent-demand subsystem;
- confirmed the cooldown is crude and should be remembered as a lightweight anti-repeated-solicitation proxy rather than a mature behavioral model.
