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

## Active

**Roadmap Stage 4 — Pre-implementation assurance gate before Slice 1 dispatch.**

Prepared implementation packet — dispatch blocked:

- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`

Active pre-implementation research gate:

- `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/00_PROGRAM_README.md`
- `research/technical/TRES-0010/README.md`

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

1. Dispatch TRES-0010 Wave-A adversarial review tasks.
2. Reconcile/deduplicate Wave-A findings.
3. Commission Wave-B prosecution/defense/experiment tasks only for serious unresolved findings.
4. Repair/escalate any real pre-code blocker and update IMP-0001 if needed.
5. Record the TRES-0010 dispatch/no-dispatch conclusion.
6. Only then dispatch IMP-0001 and fire the first-code scaffolding requirements.

Historical model refinement/calibration remains a separate Director-led concern and does not block reference implementation.
