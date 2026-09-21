# SFL v0 — Verification Scenario Workbench

**Status:** ACTIVE / ROADMAP STAGE 3  
**Authority:** Operational planning; verification scenarios do not redefine `SPEC-SFL-0001`.

## Goal

Translate every consequential SFL v0 semantic claim into observable executable scenarios and invariant checks before implementation begins.

Authoritative semantic source:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

Adversarial verification input:

- `research/technical/TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0006/CONTINUITY_LIFECYCLE_SCENARIO_ADVERSARIAL_REVIEW.md`

Resolved semantic errata record:

- `specifications/working/SPEC-SFL-0001_STAGE3_ERRATA.md`

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

## Scenario-card conventions

Each canonical card records:

- ID, level, claim, and authoritative spec clauses;
- initial objective and subjective state;
- pinned decision profile only where policy behavior is under test;
- explicit fixture-write whitelist;
- scripted stimulus/proposal schedule;
- observation horizon;
- required semantic trace / causal partial-order constraints;
- terminal assertions;
- always-on invariants;
- independent oracle basis;
- adversarial/metamorphic companions;
- nonclaims / allowed implementation variation.

Card levels:

- **mechanism-isolation:** exercises the public proposal/resolution boundary without requiring the actor scorer to choose the action;
- **closed-loop:** actual personal/household decision contexts must generate actions from a pinned deterministic policy;
- **metamorphic / boundary / mutant:** specialized adversarial companions.

Mechanism-isolation fixtures may submit semantically valid proposals but may not directly mutate endogenous household/continuity/role outcomes.

## Formation-family baseline

The canonical formation witness uses three founders with a stable connected kinship structure, two qualifying support events on different pairs and different cycles, and explicit communication sufficient for each founder to reach `CandidateRecognition`.

A two-founder card is retained only as a simpler smoke/mechanism-isolation case.

Formation ablations must control alternate paths so the removed condition cannot regenerate during the observation horizon.

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
