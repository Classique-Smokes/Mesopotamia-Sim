# SFL v0 — Verification Scenario Workbench

**Status:** ACTIVE / ROADMAP STAGE 3  
**Authority:** Operational planning; verification scenarios do not redefine `SPEC-SFL-0001`.

## Goal

Translate every consequential SFL v0 semantic claim into observable executable scenarios and invariant checks before implementation begins.

Authoritative semantic source:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

Adversarial verification input:

- `research/technical/TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`

## Required outputs

Stage 3 must produce:

1. canonical scenario cards with complete initial state, controlled inputs, expected semantic outcomes, and assertion set;
2. always-on mechanical invariants;
3. boundary-value matrices for hard gates/limits;
4. metamorphic paired-run checks;
5. semantic mutation/fault-injection set;
6. bounded stateful/generated-history strategy and regression capture;
7. held-out scenario variants;
8. checkpoint/restore determinism scenario;
9. fixture write-set audit rules.

## Verification rules

- Test oracles/checkers must not call production recognizer/transition/decision logic being judged.
- Fixtures may initialize allowed lower-level state and controlled exogenous inputs but may not write desired endogenous household/continuity/role outcomes.
- Causal claims require controlled contrasts/interventions, not provenance text alone.
- Failure results must distinguish semantic detection, survivor, unexercised, invalid/equivalent, crash, and timeout where applicable.
- Stable-ID fallback is accepted v0 technical behavior but must be isolated through ID-permutation sensitivity tests.
- Historical validation/calibration is outside Stage 3.

## Scenario families to specify

1. household formation + four formation ablations;
2. proxy-only non-formation;
3. continuity through full founder turnover;
4. similar snapshot without continuity warrant;
5. Active/Inactive/reactivation/Dissolved;
6. controlled division and consolidation lineage;
7. recognition causality + stale-head knowledge;
8. provision-backed support/dowry grounding and accounting;
9. no household self-confirmation;
10. head appointment/vacancy/succession;
11. personal vs household-mode central resolution;
12. conflicting accepted attempts + failure knowledge;
13. provision-priority ordering;
14. reaction closure/idempotence;
15. communication provenance ordering/Contested state;
16. MaterialDeadlock;
17. stable-ID fallback determinism/sensitivity;
18. safe-boundary checkpoint continuation;
19. derived-state rebuild equivalence;
20. decision explainability.

## Completion condition

Stage 3 closes when:

- every consequential v0 behavior has at least one observable acceptance scenario;
- relevant invariants have mechanical checks;
- expected outcomes are defined independently enough to catch production defects;
- checkpoint/determinism requirements are executable;
- the suite contains adversarial/metamorphic/held-out evidence sufficient to proceed to implementation without redefining model semantics.
