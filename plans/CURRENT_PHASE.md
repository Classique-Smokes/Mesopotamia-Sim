# Current Phase — SFL v0 Verification Design

**Status:** Operational plan; not simulation authority.

## Goal

Complete Roadmap Stage 3: define executable verification scenarios, invariants, adversarial controls, and continuation checks for the accepted SFL v0 semantic contract.

## Completed

- Roadmap Stage 1 implementation architecture selection.
- Reference simulation kernel accepted.
- C# 14 / .NET 10 LTS host/runtime accepted.
- Roadmap Stage 2 SFL v0 semantic specification.
- Passes A-G completed.
- Targeted adversarial reviews through TRES-0007.
- Accepted specification: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`.
- Canonical verification families completed so far:
  - formation;
  - continuity/turnover;
  - controlled lineage;
  - recognition/subjective information.
- Pre-rule semantic-compression audit run across the root retrieval chain and core accepted artifacts; restorative losses repaired.

## Active

**Roadmap Stage 3 — Define verification scenarios.**

Primary authority:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

Active workbench:

- `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`

Canonical verification package:

- `plans/verification/SFL_V0/`

Supporting adversarial reviews:

- `research/technical/TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0006/CONTINUITY_LIFECYCLE_SCENARIO_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0007/LINEAGE_WARRANT_ADVERSARIAL_REVIEW.md`

Future Stage-4 engineering context:

- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`

## Next

1. Define grounded household provision/support/dowry accounting scenarios.
2. Define no-self-confirmation and head-role/provision interaction controls.
3. Continue through conflict/invalidation, reaction closure, communication provenance, deadlock, deterministic fallback, checkpoint/rebuild, and explainability families.
4. Consolidate always-on invariants, boundary matrices, semantic mutants, and held-out/generated variants.
5. Review the full verification package without changing accepted semantics.
6. Prepare the PROJECT-CONTEXT implementation packet.
7. Begin Roadmap Stage 4 vertical-slice implementation.

Historical model refinement/calibration remains a separate Director-led model-development concern and does not block the foundational v0 verification contract.
