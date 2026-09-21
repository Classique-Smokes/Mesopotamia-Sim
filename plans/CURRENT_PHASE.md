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
  - recognition/subjective information;
  - grounded provision/support/dowry (except exact multi-contributor debit trace);
  - no-self-confirmation;
  - head appointment/vacancy/succession and personal-vs-household dual mode;
  - central invalidation/failure knowledge, provision priority, and reaction closure.
- Pre-rule semantic-compression audit run across the root retrieval chain and core accepted artifacts; restorative losses repaired: `governance/audits/2026-09-21_PRE_RULE_COMPRESSION_AUDIT.md`.

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

1. Resolve the narrow multi-contributor provision-allocation erratum.
2. Resolve the reference-scoring aggregation/configuration contract and pin the required closed-loop scoring profiles.
3. Complete the blocked multi-contributor provision card from the resolved allocation rule.
4. Run final Stage-3 completeness/adversarial review over the full canonical verification package.
5. Prepare the PROJECT-CONTEXT implementation packet.
6. Begin Roadmap Stage 4 vertical-slice implementation.

Historical model refinement/calibration remains a separate Director-led model-development concern and does not block the foundational v0 verification contract.
