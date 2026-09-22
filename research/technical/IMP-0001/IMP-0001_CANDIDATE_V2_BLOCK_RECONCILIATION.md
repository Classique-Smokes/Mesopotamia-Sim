# IMP-0001 — Candidate-v2 Independent Conformance BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION — BLOCK ACCEPTED / REPAIR-v3 REQUIRED  
**Candidate-v2:** `imp-0001-slice1-conformance-candidate-v2` @ `ba16829e240950f1f3c648107cf3b8b36f996971`  
**Independent v2 review:** `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`  
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1` / blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`

## 1. Independent result

Fresh K4 review returned **BLOCK** for candidate-v2 with:

- **124 REQUIRED satisfied**
- **4 REQUIRED unsatisfied**
- all **33 DEFERRED / 3 N-A / 3 UNEXERCISED** classifications preserved
- baseline valid; no candidate or authority drift.

Unsatisfied obligations are:

- `S1-080` — material-deadlock semantics;
- `S1-081` — precise technical-fallback disclosure;
- `S1-GLOBAL-FALLBACK`;
- `S1-GLOBAL-CONFORMANCE`.

The Master Architect accepts both substantive findings.

## 2. B1 — future input exists but cannot resolve MaterialDeadlock

### Accepted authority

SPEC §9.5 requires MaterialDeadlock when:

- all grain producers are blocked by `NeedsGrain`;
- no available transfer can clear need;
- no scheduled exogenous grain input **can resolve the condition**.

The accepted cycle order applies exogenous inputs before maintenance and then before voluntary decision contexts.

### Observed defect

Candidate-v2 suppresses MaterialDeadlock whenever **any** future scheduled input has `Delta > 0`.

That is weaker than the accepted predicate.

Reviewer counterexample:

- current world has all actors blocked and no grain;
- cycle 2 schedules `+1` then `-1` for the same person;
- the future batch executes entirely before maintenance;
- net stock remains zero;
- nobody ever reaches a decision context with need resolved;
- candidate-v2 nevertheless reports cycle-1 `MaterialDeadlock = false`.

A `+2, -1` control correctly represents a resolving future input because one unit survives to maintenance and permits the actor to emerge from the blocked condition.

### Classification

**Implementation semantic defect + verification coverage gap.**

No new social semantics are required.

Repair must implement the accepted **can resolve** predicate rather than an “exists positive entry” shortcut.

The implementation may use a bounded deterministic projection of future scheduled exogenous inputs and mandatory maintenance under the already accepted cycle order. It must not invent rescue grain, stochastic assumptions, or future voluntary choices.

If implementation discovers that accepted authority is insufficient to decide what “can resolve” means for a concrete scheduled-input shape, stop and escalate. Do not choose a new rule locally.

## 3. B2 — commuting Farm falsely marked as technical fallback

### Accepted authority

SPEC §§9.2/9.4 and `S1-081`/ `S1-GLOBAL-FALLBACK` treat `TechnicalFallback` as disclosure that unresolved technical ordering actually determined a consequential alternative.

It is not a generic “this proposal was near a resource dependency” warning.

### Observed defect

Candidate-v2 correctly marks three called repayments competing over one debt.

But when those repayments coexist with the debtor's Farm:

- the debt can accept at most 4 of the proposed 6 repayment units;
- the debtor already has enough grain to fund those 4 units while respecting reserve;
- Farm's +4 cannot make the third 2-unit repayment fit the remaining 1 unit of debt;
- moving Farm anywhere among all 24 proposal-ID orderings changes neither repayment winners nor any material/relation result attributable to Farm.

Yet candidate-v2 marks Farm `TechnicalFallback = true` in every run.

The cause is an intentionally conservative aggregate grain analysis that ignores the independently tighter debt cap, then marks possible credits/Farm as enablers.

### Classification

**Implementation observability/precision defect + verification interaction gap.**

No new social priority is required.

Repair must distinguish:

- genuine unresolved alternatives whose outcome/effects depend on technical ordering; from
- proposals that merely share a conservatively approximated dependency but commute under all feasible outcomes of the tighter semantic constraints.

The existing debt callers remain legitimate fallback participants. The commuting Farm must not be falsely attributed technical fallback.

Repair should preserve positive controls where Farm/credit ordering genuinely changes which spend can commit.

## 4. What v2 successfully established

The v2 reviewer independently cleared the v1 repair areas:

- subjective/objective personal-decision boundary;
- needy reciprocal-request refusal consequence;
- mandatory attitude-cause oracle completeness;
- broad F1 interaction coverage except the newly discovered over-marking intersection;
- oracle independence;
- fixture discipline;
- later-slice boundaries;
- manifest integrity;
- canonical reproducibility.

Do not reopen those areas without new evidence.

## 5. Process/governance disposition

**No further governance expansion is warranted from this BLOCK.**

The existing post-v1 assurance refinement explicitly asked fresh reviewers to:

- test broad/global claims rather than only mapped examples;
- attack over-marked asymmetric/commuting fallback cases;
- use reviewer-owned public-API counterexamples.

The Elamite did exactly that and found B1/B2.

This is evidence that the revised assurance layer is functioning as intended.

The durable lesson is therefore **use the existing K4 mechanism**, not add another pre-code ceremony or standing review layer.

## 6. Repair-v3 boundary

Candidate-v2 remains immutable:

`imp-0001-slice1-conformance-candidate-v2` @ `ba16829e240950f1f3c648107cf3b8b36f996971`

Repair branch:

`implementation/imp-0001-slice1-repair-v3`

Repairs may alter production/test/evidence mapping only as needed for B1/B2 and regression preservation.

Do not:

- edit/reclassify the frozen manifest;
- change accepted SPEC/ADRs;
- invent new social/domain priorities;
- weaken v1/v2 regressions;
- implement later-slice systems.

After repair, a new candidate-v3 identity and **fresh independent K4 review** are required.

PR #7 and PR #16 remain historical draft lineages; do not merge them as substitutes for candidate-v3 promotion.
