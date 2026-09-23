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
