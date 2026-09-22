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
- Manifest Repair Review reconciliation completed; corrected manifest now has 167 unique AcceptanceIds (128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED) and passed 20/20 targeted repair checks.
- Corrected-manifest R2 independently returned **PASS**; `SFL-V0-S1-ACCEPTANCE-v1` frozen at `sfl-v0-slice1-acceptance-v1`.
- IMP-0001/task-template/C# handoff hardening completed; deferred later-slice gaps durably registered.
- TRES-0010 final closure audit passed 34/34 checks; TRES-0010 CLOSED / PASS; IMP-0001 cleared for dispatch.
- GOV-0001 fresh-agent evaluations A/B/C returned **PASS** from the frozen candidate; central reconciliation found no material rule loss, owner conflict, routing defect, or repair requirement.

## Active

**Roadmap Stage 4 — Slice 1 ready for implementation dispatch.**

Ready implementation packet:

- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`

Frozen Slice-1 acceptance authority:

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- version `SFL-V0-S1-ACCEPTANCE-v1`
- frozen ref `sfl-v0-slice1-acceptance-v1`
- freeze record `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`

TRES-0010 closure evidence:

- `research/technical/TRES-0010/FINAL_CLOSURE_AUDIT_AND_DISPATCH_DECISION.md`

The Master Architect rulebook restructuring is active as separate post-TRES governance work. It is **not** a semantic/verification prerequisite for IMP-0001 dispatch.

Governance-refactor continuity:

- accepted governance remains on `main`;
- sole evaluated candidate: `governance-rulebook-refactor-candidate` @ `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`;
- frozen pre-refactor baseline: `governance-rulebook-refactor-baseline` @ `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b`;
- GOV-0001 A/B/C: **PASS / PASS / PASS**;
- central reconciliation: `research/technical/GOV-0001/FRESH_AGENT_EVALUATION_RECONCILIATION.md`;
- constitutional decision now pending: `DEC-0009` — Layered Master Architect Rulebook Refactor;
- promotion proposal: `proposals/GOV-0001_MASTER_ARCHITECT_RULEBOOK_PROMOTION.md`;
- state/recovery map: `research/technical/GOV-0001/README.md`.

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

1. Obtain the explicit Project Director decision on `DEC-0009`.
2. If DEC-0009 is approved, promote the evaluated GOV-0001 candidate with status/decision/navigation integration and run the required post-promotion fresh-retrieval verification.
3. When implementation is intentionally begun, dispatch `IMP-0001` against `SFL-V0-S1-ACCEPTANCE-v1`; SCF-001 and the remaining executable/CI portion of SCF-002 fire at dispatch.
4. Do not treat the governance refactor as a coding gate: IMP-0001 is already TRES-cleared and may be dispatched independently if project priority changes.

Historical model refinement/calibration remains a separate Director-led concern and does not block reference implementation.
