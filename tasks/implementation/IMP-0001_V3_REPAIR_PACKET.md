# IMP-0001 — Candidate-v2 BLOCK Repair-v3 Packet

**Status:** READY FOR IMPLEMENTATION  
**Base:** frozen candidate-v2 `ba16829e240950f1f3c648107cf3b8b36f996971`  
**Required branch:** `implementation/imp-0001-slice1-repair-v3`  
**Authority:** existing accepted SPEC/ADRs + frozen `SFL-V0-S1-ACCEPTANCE-v1` + candidate-v2 BLOCK reconciliation  
**Scope:** B1 MaterialDeadlock future-input resolution + B2 fallback-attribution precision only

## Read first

- `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`
- `research/technical/IMP-0001/IMP-0001_CANDIDATE_V2_BLOCK_RECONCILIATION.md`
- original IMP-0001 task;
- candidate-v1 BLOCK repair packet;
- accepted SPEC/ADRs;
- frozen manifest and cited verification sources.

Treat both independent reports as defect evidence, not semantic authority above the accepted sources.

## R1 — implement the accepted MaterialDeadlock “can resolve” predicate

Candidate-v2 currently suppresses deadlock if any future scheduled input has a positive delta.

Replace that shortcut with an evaluation that respects accepted cycle semantics.

### Required behavior

When the current stable cycle otherwise meets MaterialDeadlock conditions, future exogenous input prevents the diagnostic **only if the declared future schedule can actually produce a later decision-phase material state that escapes the blocked condition** under deterministic exogenous-input + mandatory-maintenance processing.

Use the existing accepted phase order.

Do not assume future voluntary rescue actions while the system remains blocked.

### Required counterexamples / controls

At minimum cover:

1. no future input -> deadlock;
2. one future positive input that genuinely resolves need -> not deadlock;
3. same future cycle `+1, -1` on blocked person -> still deadlock now;
4. same future cycle `+2, -1` -> not deadlock now when the surviving unit clears the maintenance block;
5. equivalent cancelling batches split across people where no producer can become unblocked;
6. future withdrawals must never count as recovery merely because another positive input appears elsewhere in the schedule;
7. existing transfer/current-state negative controls remain valid.

Do not weaken the signed exogenous-input schema merely to make the deadlock check easier.

If exact future projection would require a semantic assumption absent from authority, escalate.

## R2 — make TechnicalFallback attribution precise under intersecting constraints

Candidate-v2's dependency analysis may over-approximate potential resource interactions, but consequential `TechnicalFallback` history must identify actual technical-order participation.

### Required behavior

A proposal may be marked `TechnicalFallback` only when the unresolved technical ordering can affect:

- its own terminal outcome/effect; or
- a consequential competing alternative for which that proposal's position/order is causally relevant.

Do not mark a proposal merely because a coarse resource analysis includes it as a possible enabler.

### Required debt/Farm regression

Reproduce the Elamite's scenario:

- three distinct called repayments of 2 against remaining debt 5;
- debtor has sufficient grain to fund the maximum 4 repayment units while retaining reserve;
- debtor also Farms.

Across all proposal-ID/order placements:

- exactly two repayments commit;
- one repayment invalidates `RepaymentExceedsRemaining`;
- the three repayment contenders remain appropriately marked;
- Farm commits;
- Farm is **not** marked technical fallback;
- final debt/material/favour state remains correct.

### Positive controls

Preserve cases where Farm or an incoming credit **does** participate in a real aggregate grain-order dependency and therefore must be marked.

Add intersection cases where:

- debt cap is tighter than grain cap;
- grain/reserve cap is tighter than debt cap;
- both constraints can independently matter;
- an enabler genuinely changes a spender outcome;
- an apparent enabler commutes because another semantic cap already fixes the outcome.

### Audit requirement

Reconcile the aggregate dependency analyzer so separate semantic constraints do not produce false fallback attribution when combined.

You may use structural reasoning plus bounded permutation probes; do not invent a new domain priority.

## Regression preservation

All candidate-v2 repairs remain mandatory:

- original F1 missing-fallback cases;
- full interaction-surface controls;
- F2 refusal consequence and mandatory-cause oracle;
- F3 personal subjective-input isolation;
- D1–D5;
- initiative accounting;
- deterministic replay/metamorphics;
- fixture/oracle audits.

No previously satisfied REQUIRED row may be weakened to obtain green results.

## Canonical verification

Run:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Completion requires:

- all coder-owned REQUIRED rows PASS;
- B1/B2 reviewer probes or equivalent stronger regressions PASS;
- frozen manifest byte-identical;
- no non-required reclassification;
- complete repair report explaining implementation and evidence;
- no new semantic/architecture authority chosen.

## Return / candidate-v3

Do not move candidate-v1 or candidate-v2 refs.

When repair-v3 is complete:

1. push `implementation/imp-0001-slice1-repair-v3`;
2. use its dedicated draft PR for normal CI;
3. report exact head SHA, CI run and evidence artifact;
4. Master Architect reconciles and freezes `imp-0001-slice1-conformance-candidate-v3`;
5. a **fresh reviewer who authored neither v2 nor v3 repair** performs K4.

Green implementation evidence is not `VERIFIED COMPLETE` until fresh independent PASS.
