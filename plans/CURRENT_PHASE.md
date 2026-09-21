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
- Targeted adversarial reviews TRES-0003 (temporal/resolution) and TRES-0004 (verification closure).
- Accepted specification: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`.

## Active

**Roadmap Stage 3 — Define verification scenarios.**

Active workbench:

- `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`

Primary authority:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

Supporting verification research:

- `research/technical/TRES-0001/returns/TRES-0001F_RESEARCH_REPORT.md`
- `research/technical/TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`

## Next

1. Convert the Stage-2 proof obligations into canonical executable scenario cards.
2. Define always-on invariants and independent checker/oracle rules.
3. Define boundary matrices, metamorphic pairs, semantic mutants, and held-out variants.
4. Define exact checkpoint/restore and decision-explainability scenarios.
5. Review the verification package for completeness without changing accepted semantics.
6. Prepare the PROJECT-CONTEXT implementation packet.
7. Begin Roadmap Stage 4 vertical-slice implementation.

Historical model refinement/calibration remains a separate Director-led model-development concern and does not block the foundational v0 verification contract.
