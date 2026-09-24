# DEC-0012 — Adopt Semantic Interaction Delta Failsafe

**Status:** ACCEPTED  
**Authority level:** Constitutional / process governance  
**Date opened:** 2026-09-24  
**Date resolved:** 2026-09-24  
**Approver:** Human Project Director  
**Adopted policy label:** `SID-ASSURANCE-v1`

## Problem

The project can have complete conformance, acceptance, oracle, and implementation assurance relative to accepted semantics while still omitting an ordinary causal possibility that never entered the semantic vocabulary.

The protected failure class is:

> a newly introduced semantic layer changes the possibility space of the already-existing world in a consequential but unclassified way.

This may appear as:

- a newly possible history;
- an old capability becoming impossible, narrower, or newly conditional;
- a new dependency/coupling/causal route;
- a transition carryover hole;
- participant aliasing;
- another material new↔old semantic interaction.

## Decision

Adopt the **Semantic Interaction Delta Failsafe**, version `SID-ASSURANCE-v1`, as a conditional extension of the existing specification→implementation assurance process.

The failsafe does not create a new governance layer or global register.

Its normative owner is:

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Its operational checklist is:

`governance/checklists/SEMANTIC_INTERACTION_DELTA_CHECKLIST.md`

## Trigger

Consequential preimplementation work records:

`Semantic-interaction-delta trigger: FIRED|NOT FIRED — reason`

The trigger FIRES when newly introduced or materially changed semantics can materially interact with an existing capability/path through resources, authority, knowledge, lifecycle/transition, topology/time/space, ownership/control, higher-order institutional mediation, participant aliasing, or another consequential new↔old causal connection.

NOT FIRED ends the branch cheaply; routine/local work does not receive the full audit.

## Interaction frontier and bounded lenses

When FIRED, the Master Architect identifies the bounded **interaction frontier**: the prior semantic surfaces the new layer can materially touch.

The audit considers, where relevant:

1. newly possible / compositional affordances;
2. old capabilities suppressed, narrowed, or newly conditional;
3. new dependency/coupling/causal retargeting;
4. transition carryover/path closure;
5. participant aliasing.

Old-world projection is a diagnostic where meaningful, not a universal requirement that new semantics conservatively preserve every old behavior.

## Two-pass frontier-independent challenge

One fresh reviewer is used by default.

### Pass A — independent frontier discovery

Before seeing the Master Architect frontier, the reviewer receives:

- the new semantic layer;
- a compact subsystem/domain-oriented canonical map of adjacent existing semantics and retrieval entrypoints;
- real invariants/exclusions.

The reviewer independently identifies prior semantic surfaces that may materially interact.

Pass A must be durably fixed before the Master Architect frontier is revealed.

The compact map must not be mechanically pruned from the Master Architect frontier.

### Pass B — frontier comparison + negative-space challenge

After Pass A is fixed:

- reveal the Master Architect frontier;
- compare reviewer-only / MA-only / overlap;
- reconcile the justified union;
- generate a small bounded set of ordinary concrete histories/questions challenging the possibility-space delta.

Reviewer output is advisory questions/counterexamples, not semantics.

## Authority-bearing closure

Classification alone does not create closure.

- `DERIVED CONSEQUENCE` must cite controlling accepted authority.
- `DEFERRED` clears the current freeze gate only if:
  1. the deferral itself is authorized at the required authority level;
  2. an owner/trigger is durable;
  3. the current slice remains semantically complete and implementable without deciding it;
  4. implementation cannot accidentally choose the deferred meaning.
- `PROHIBITED / INTENDED CHANGE` must trace to actual authority.
- `IRRELEVANT` must state why the interaction has no consequential effect.

Consequential `UNRESOLVED` or `ACCIDENTAL GAP / REGRESSION` blocks acceptance freeze.

## Closure freshness

A semantic-delta closure is bound to an exact semantic base.

Any material semantic change after closure makes that closure stale until explicitly re-evaluated.

Re-evaluation may conclude:

- `REVALIDATED — NO FRONTIER CHANGE`; or
- `REOPENED — AFFECTED FRONTIER`.

A stale closure cannot authorize acceptance freeze.

## Acceptance and implementation gates

When the trigger FIRES, consequential acceptance freeze requires:

- current delta closure;
- independently fixed Pass A;
- Pass B challenge over the reconciled frontier;
- authority-bearing dispositions;
- `Consequential unresolved: 0`;
- `Accidental gaps outstanding: 0`.

Acceptance review remains subordinate to accepted semantics; it verifies the closure rather than creating it.

If implementation later exposes a consequential unclassified new↔old semantic interaction, suppression/narrowing, transition carryover, causal dependency/retargeting, shared-capacity interaction, or participant alias, the coding agent must STOP and escalate rather than infer support, prohibition, or implementation discretion.

## Scaling

The mechanism is delta-based, not cumulative.

A new slice audits:

- its new/changed semantics; and
- the prior surfaces they can materially touch.

Previously closed interactions are reopened only when affected, while any later material semantic change still requires explicit closure-freshness re-evaluation.

One fresh reviewer and a small number of challenge histories are the default.

## Pilot and evidence discipline

The currently blocked Slice 4 is the first mandatory pilot before successor Slice-4 acceptance.

Slice 4 tests policy wiring/adequacy, not unbiased prospective efficacy.

Effectiveness reporting distinguishes:

- `KNOWN CASE PROCESSED`;
- `PREVIOUSLY UNKNOWN MATERIAL FINDING`;
- `DUPLICATE FINDING`;
- `NOISE / FALSE POSITIVE`;
- `NO NEW FINDING`.

The founding private-supplementation incident is motivating evidence, not prospective discovery evidence.

## Sunset / revision

After the failsafe FIRES on 2–3 consequential slices, run an effectiveness review.

Allowed outcomes include:

- RETAIN;
- NARROW;
- SIMPLIFY;
- ADD LIGHTWEIGHT LINT;
- RETIRE.

The mechanism does not gain permanent status merely because it once prevented a failure.

## Explicit exclusions

This decision does not authorize:

- automated semantic classification;
- exhaustive action-pair enumeration;
- a global affordance/interactions register;
- a new standing review board;
- a second general governance protocol;
- universal preservation of all old behavior;
- routine full-audit ceremony for local changes.

## Review lineage

Reviewed rollout candidate:

- ref: `governance-semantic-interaction-delta-rollout-v1-candidate2`
- commit: `dbd8f2f5b81c79b69973463010011fdd7b0e785a`
- policy blob: `510ed36a15eb2912b50b0c9eda43953b1b6779bd`
- implementation-plan blob: `f7e22b372ebb1b805fba3ec6ecb84d7852b0329d`

Independent governance review:

`research/technical/GOV-0002_SEMANTIC_INTERACTION_DELTA_FAILSAFE_REVIEW_CANDIDATE2.md`

Verdict:

**PASS — POLICY READY FOR DIRECTOR PROMOTION**

The Human Project Director explicitly approved promotion on 2026-09-24.
