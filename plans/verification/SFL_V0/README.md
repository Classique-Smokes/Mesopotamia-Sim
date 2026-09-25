# SFL v0 Verification Package

**Status:** COMPLETE / ROADMAP STAGE 3  
**Authority:** Verification design only. Scenario cards test `SPEC-SFL-0001`; they do not redefine it.

## Card levels

- `mechanism-isolation` — fixture may submit valid proposals through the public proposal/resolution boundary; it may not write endogenous results.
- `closed-loop` — actual decision contexts must generate the actions under a pinned deterministic decision profile.
- `boundary`, `metamorphic`, `mutant` — adversarial companions.

## Card requirements

Every canonical card states:

- claim and authoritative clauses;
- initial objective/subjective state;
- allowed fixture writes;
- stimulus/proposal schedule;
- observation horizon;
- required semantic/causal ordering;
- terminal assertions;
- always-on invariants;
- independent oracle basis;
- adversarial companions;
- nonclaims/allowed variation.

Completed-cycle assertions are made only at stable cycle closure. Intermediate commits/reactions may be inspected as causal history.

## Current families

- `FORMATION_FAMILY.md`
- `CONTINUITY_TURNOVER_FAMILY.md`
- `LINEAGE_FAMILY.md`
- `RECOGNITION_INFORMATION_FAMILY.md`

- `PROVISION_GROUNDING_FAMILY.md`
- `NO_SELF_CONFIRMATION_FAMILY.md`
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`
- `RESOLUTION_REACTION_FAMILY.md`
- `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- `REFERENCE_SCORING_PROFILES.md`
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
- `RESPONSE_DECISION_FAMILY.md`

## Closure

TRES-0009 found no remaining semantic or architectural blocker in the Stage-3 package. These artifacts are the canonical implementation-facing verification design for SFL v0.

Implementation may translate them into executable tests/harness code but may not weaken or reinterpret their semantic assertions without returning through the specification/authority process.

## Slice-1 acceptance applicability

- `SLICE1_ACCEPTANCE_MANIFEST.md` — **FROZEN Slice-1 verification/completion authority**, version `SFL-V0-S1-ACCEPTANCE-v1`, subordinate to accepted semantics/architecture. Frozen ref: `sfl-v0-slice1-acceptance-v1`.
- `SLICE1_ACCEPTANCE_FREEZE_RECORD.md` — freeze commit/SHA identity, R2 PASS provenance, and immutability rule.
- Supporting CallFavor applicability derivation: `research/technical/TRES-0010/CALLFAVOR_SLICE1_APPLICABILITY_RECONCILIATION.md`.


## Slice-2 acceptance applicability

- `SLICE2_ACCEPTANCE_MANIFEST.md` — **FROZEN Slice-2 verification/completion authority**, version `SFL-V0-S2-ACCEPTANCE-v1`, frozen ref `sfl-v0-slice2-acceptance-v1`.
- `SLICE2_ACCEPTANCE_FREEZE_RECORD.md` — exact freeze commit/SHA identity, final PASS provenance, and immutability rule.

## Slice-3 acceptance applicability

- `SLICE3_ACCEPTANCE_MANIFEST.md` — **FROZEN Slice-3 verification/completion authority**, version `SFL-V0-S3-ACCEPTANCE-v1`, frozen ref `sfl-v0-slice3-acceptance-v1`.
- `SLICE3_ACCEPTANCE_FREEZE_RECORD.md` — reviewed candidate/frozen SHA identities, final `PASS — MAY FREEZE UNCHANGED`, review lineage, immutability rule, and the conditional S1-084 adaptation trigger.
- Final fresh review: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_V3_FINAL.md`.


## Slice-4 acceptance applicability

- `SLICE4_ACCEPTANCE_MANIFEST.md` — **FROZEN Slice-4 verification/completion authority**, version `SFL-V0-S4-ACCEPTANCE-v1`, frozen ref `sfl-v0-slice4-acceptance-v1`.
- `SLICE4_ACCEPTANCE_FREEZE_RECORD.md` — reviewed candidate/frozen identities, final `PASS — MAY FREEZE UNCHANGED`, census, immutability rule, and inherited-verification adaptation gate.
- Final fresh review: `research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE2.md`.
- Frozen census: **161 unique AcceptanceIds = 150 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.
- Exact inherited expansion: **270 REQUIRED = 128 Slice 1 + 46 Slice 2 + 96 Slice 3**.
- Implementation remains blocked until independent approval of the inherited verification adaptation plan.


## Successor Slice-4 v2 candidates after DEC-0011 / DEC-0013

- Frozen `SLICE4_ACCEPTANCE_MANIFEST.md` / `sfl-v0-slice4-acceptance-v1` remains immutable historical acceptance evidence.
- Candidate1: `sfl-v0-slice4-acceptance-v2-candidate1` @ `473e521e1d64b3e001c386bf186eafba71c20f5f`, blob `67008d03a943e6cd6a9a9e269be7c6efeefc229b`, census **173 = 162 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.
- Candidate1 independent review: `../../research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE1.md` — **BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT** because accepted DEC-0011 exact private-X semantics lacked completion-gating AcceptanceIds.
- Candidate2: `SLICE4_ACCEPTANCE_MANIFEST_V2_CANDIDATE.md`, version `SFL-V0-S4-ACCEPTANCE-v2-candidate2`.
- Immutable candidate2 ref: `sfl-v0-slice4-acceptance-v2-candidate2` @ `f14868c7382f2d132ad6636851bd621613785018`.
- Candidate2 blob: `ea5eb3b3a46f20a53a6e10131524d0e6c12b313d`.
- Candidate2 census: **176 unique = 165 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.
- All 173 candidate1 status-bearing rows remain unchanged; candidate2 adds exactly S4-188..190 for DEC-0011.
- Fresh independent pre-code review task: `../../tasks/research/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE2.md`.
- Candidate2 is not implementation authority. Freeze only on fresh **PASS — MAY FREEZE UNCHANGED**.
- After successor freeze, reassess the inherited-verification adaptation plan before running a fresh independent adaptation review.


## Frozen Slice-4 successor acceptance v2

- Frozen successor manifest: `SLICE4_ACCEPTANCE_MANIFEST_V2.md`.
- Version/ref: `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`.
- Freeze commit: `66fe54c385f42eeb01308f19b63fff7c670b9bbe`.
- Frozen manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`.
- Freeze record: `SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`.
- Frozen census: **176 unique = 165 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.
- Final review: `../../research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**.
- All 176 status-bearing rows are byte-for-byte identical to reviewed candidate2.
- Frozen v1 remains immutable historical evidence.
- Implementation remains blocked pending reassessed inherited-verification adaptation + fresh independent approval.


## Reassessed inherited-verification adaptation candidate

- Historical pre-DEC-0013 candidate: `sfl-v0-slice4-inherited-verification-adaptation-v1-candidate1` — retained only for provenance.
- Reassessment: `../../../research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REASSESSMENT.md`.
- Current candidate ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-candidate1` @ `4f12c30b0f16531fd1e82ac08c2b71e53934ba28`.
- Current plan blob: `43e27cb6fed1086ffcc687002f7fffd494b528b5`.
- Plan path: `../../../research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_PLAN.md`.
- Fresh review task: `../../../tasks/research/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2.md`.
- Candidate preserves the four known inherited literal breakpoints but corrects commitment-provenance adaptation for accepted head self-commitment and strengthens DEC-0011/0013 funding/dependency guardrails.
- No coding authorization exists until independent **PASS — ADAPTATION PLAN APPROVED** and explicit gate closure.
