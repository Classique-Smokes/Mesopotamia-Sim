# TRES-0010 Wave B2 — Targeted Resolution Design

**Status:** PREPARED / DECISION-SUPPORT ONLY  
**Authority:** Advisory research only  
**Implementation gate:** IMP-0001 remains blocked.

## 1. Purpose

Wave A discovered candidate defects. Wave B adjudicated them.

B2 now exists only to turn the **confirmed surviving Slice-1 issues** into decision-ready, minimal repair options.

B2 is not another broad review and must not reopen findings already rejected or deferred.

## 2. Tasks

Run exactly three fresh-chat tasks:

1. `TRES-0010B2-SEM-T_TEMPORAL_COMPOSITION_OPTIONS.md`
2. `TRES-0010B2-SEM-A_ACTION_FAVOUR_CLOSURE_OPTIONS.md`
3. `TRES-0010B2-ASR_SLICE1_ACCEPTANCE_AUTHORITY_DESIGN.md`

Each task has a separate issue cluster and should not read sibling B2 returns before completing its own report.

## 3. Common AI-use rules

- one fresh chat per task;
- one frozen B2 canonical baseline;
- one isolated return branch per task;
- do not read sibling B2 returns before finalizing;
- use accepted authority as the source of truth;
- use `WAVE_B_ADJUDICATION_SYNTHESIS.md` only as a finding/disposition map, not as semantic authority;
- do not inherit Wave-A/Wave-B preferred fixes as assumptions;
- compare at least two credible minimal options for every unresolved semantic decision unless only one option survives accepted authority;
- explicitly test each option against determinism, causal meaning, implementation simplicity, verification clarity, and future-slice compatibility;
- avoid speculative frameworks/generalization;
- recommend the smallest faithful rule;
- preserve uncertainty when evidence does not decide;
- no canonical edits;
- no code.

## 4. Required output shape

Each report must contain:

1. issue inventory;
2. accepted constraints;
3. option set;
4. option-by-option consequences;
5. strongest disconfirmation of the recommended option;
6. recommendation;
7. exact canonical artifacts/sections that would need amendment if approved;
8. exact verification additions/changes;
9. whether Director approval is required;
10. residual risks/deferred questions.

Recommendations are advisory.

## 5. Decision criteria

Use, in order:

1. semantic fidelity to accepted model;
2. determinism / unambiguous execution;
3. preservation of actor/world authority boundaries;
4. smallest faithful v0 rule;
5. verification simplicity/independence;
6. compatibility with accepted later slices;
7. reversibility / low migration cost;
8. implementation simplicity.

Do not optimize for elegance or generality over those criteria.

## 6. Stop conditions

Stop and flag rather than inventing a fix if:

- every plausible option changes a founding/architectural principle;
- resolving the issue requires choosing historical calibration rather than v0 mechanics;
- a proposed rule would require broad new framework infrastructure;
- accepted artifacts conflict in a way not captured by the adjudication;
- a new consequential issue appears outside the assigned cluster.

## 7. After B2

The Master Architect will:

1. reconcile the three reports;
2. present consequential semantic choices to the Director;
3. promote approved semantics losslessly;
4. materialize the Slice-1 acceptance/applicability authority;
5. amend IMP-0001 and related templates/guardrails;
6. carry later-slice gaps into an explicit ledger;
7. run one final TRES-0010 closure audit before releasing code.