# Current Phase — SFL v0 Reference Prototype Implementation

**Status:** Operational plan; not simulation authority.

## Goal

Execute Roadmap Stage 4 in verified vertical slices, beginning with the lower-level social-fabric reference kernel, while preserving the accepted SFL v0 semantics and completed Stage-3 verification contract.

## Completed

- Roadmap Stage 1 — implementation architecture selection.
- Roadmap Stage 2 — SFL v0 semantic specification.
- Roadmap Stage 3 — executable verification design.
- TRES-0008 final package adversarial review.
- Director-approved response-policy / orphan-breach closure repairs.
- TRES-0009 post-repair closure review: no remaining Stage-3 semantic or architectural blocker.
- Complete canonical verification package: `plans/verification/SFL_V0/`.
- TRES-0010 Wave A / Wave B / B2 research and adjudication completed.
- Director-approved TRES-0010 B2 Slice-1 semantic repairs promoted losslessly into `SPEC-SFL-0001`, assumptions, and canonical verification; promotion audit passed 30/30 checks.
- CallFavor Slice-1 action applicability mechanically derived and closed: current callable payloads are `Farm` and `RepayDebt`; no new semantic decision required.
- Slice-1 acceptance manifest candidate authored and repository-audited: 158 unique AcceptanceIds; 120 REQUIRED / 32 DEFERRED / 3 N-A / 3 UNEXERCISED; no duplicate IDs.
- First independent manifest pre-code review returned **BLOCK**; no canonical semantics were reopened.
- Manifest repair review commissioned as three mutually blind source-grounded audits: boundary completeness, semantic subordination/wording scope, and grain-ingress exhaustiveness.

## Active

**Roadmap Stage 4 — Pre-implementation assurance gate before Slice 1 dispatch.**

Prepared implementation packet — dispatch blocked:

- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`

Active pre-implementation closure gate:

- `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/00_PROGRAM_README.md`
- `research/technical/TRES-0010/README.md`
- Wave-B adjudication: `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/WAVE_B/00_WAVE_B_README.md`
- B2 targeted resolution: `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/WAVE_B/B2/00_B2_README.md`
- semantic promotion reconciliation/audit: `research/technical/TRES-0010/SEMANTIC_PROMOTION_RECONCILIATION.md`, `research/technical/TRES-0010/SEMANTIC_PROMOTION_LOSSLESS_AUDIT.md`

Slice 1 objective:

- individuals + lower-level relationships;
- personal/response agency sufficient for the slice;
- proposal / resolution / commit;
- semantic history / deterministic cycle closure;
- executable lower-level acceptance scenarios.

Primary authority:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted ADRs under `architecture/accepted/`

Implementation-facing verification:

- `plans/verification/SFL_V0/`

Required C# engineering context:

- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`

Armed implementation scaffolding for first code dispatch:

- SCF-001 root verification sensors;
- SCF-002 protected acceptance verification;
- tracked in `registers/SCAFFOLDING_TRIGGER_REGISTER.md`.

## Stage-4 slice order

1. **IMP-0001 / Slice 1:** individuals + relationships + proposal/response/commit + semantic history.
2. Slice 2: subjective recognition + minimal individual agency integration.
3. Slice 3: persistent household identity + grounded collective capability.
4. Slice 4: representative role + turnover/succession.
5. Slice 5: delayed processes + checkpoint/restore continuation.

Each slice must leave a runnable verified system. Do not begin a later slice by silently stubbing or inventing unresolved semantics in an earlier slice.

## Next

1. Run the three TRES-0010 Manifest Repair Review tasks from `tres-0010-manifest-repair-review-baseline`.
2. Reconcile the three independent returns with the original manifest BLOCK report; do not edit the manifest before this synthesis.
3. Draft the smallest source-faithful manifest correction set and freeze a new corrected review baseline.
4. Re-run the independent pre-code manifest review. Only a PASS may authorize manifest freeze metadata/versioning.
5. Amend IMP-0001 authority taxonomy, applicability/completion evidence, and local C# guardrails against the passed frozen manifest.
6. Carry confirmed later-slice semantic/verification gaps into an explicit deferred ledger.
7. Run one final TRES-0010 closure audit.
8. Reassess provisional process lessons and prepare the separate Master Architect rulebook refactor only after TRES-0010 closure.
9. Record dispatch/no-dispatch conclusion; only then release IMP-0001.

Historical model refinement/calibration remains a separate Director-led concern and does not block reference implementation.
