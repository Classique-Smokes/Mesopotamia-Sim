# Mesopotamian Social Simulation — START HERE

**Role:** Canonical project orientation map  
**Keep this file short. Do not turn it into a second specification.**

## Project

A historically grounded autonomous simulation of ancient Mesopotamian society, built from persistent individuals → relationships → households → larger formations. Higher layers may become persistent causal actors but must not erase the lower-level reality through which they exist.

## Authority

1. `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
2. Explicitly approved constitutional decisions
3. `governance/WORKING_CONSTITUTION.md`
4. Accepted decisions / ADRs
5. Accepted subsystem specifications
6. Implementation constrained by the above

Conversation, brainstorming, research returns, proposals, roadmaps, working notes, and existing code are not authoritative merely because they exist.

## Current phase

**ROADMAP STAGE 4 — SFL v0 REFERENCE PROTOTYPE IMPLEMENTATION**

Accepted foundation:

- `DEC-0001` — Foundational Social-Fabric Model
- `DEC-0002` — Master Architect Operating Guide
- `DEC-0009` — Layered Master Architect Rulebook Refactor
- `ADR-0001 / DEC-0003` — Active Social-State Representation
- `ADR-0002 / DEC-0004` — Hierarchical Individual Agency
- `DEC-0005` — Architecture Development Policy
- `DEC-0015` — Relation-specific diagonal admissibility + self-alias semantics; future typed relations classify diagonal admissibility when conceptualized
- `ADR-0003 / DEC-0006` — Progressive Derived-State Specialization
- `ADR-0004 / DEC-0007` — Reference Simulation Kernel
- `ADR-0005 / DEC-0008` — C# 14 / .NET 10 LTS Host Runtime
- `SPEC-SFL-0001` — accepted Social Fabric Laboratory v0 semantics

Active work:

- IMP-0001 / Slice 1: **VERIFIED COMPLETE**
- IMP-0002 / Slice 2: **VERIFIED COMPLETE**
- IMP-0003 / Slice 3: **VERIFIED COMPLETE**
- Slice-4 SID pilot: **CLOSED / PASS**
  - accepted semantic closure: `decisions/DEC-0013_SLICE4_SID_CLOSURE_AND_V0_RESOURCE_SCAFFOLD_BOUNDARIES.md`
  - closure revalidation: `research/technical/SFL_V0_SLICE4_SID_CLOSURE_REVALIDATION.md` — **0 consequential unresolved / 0 accidental gaps**
  - TRES-0011 synthesis: `research/technical/TRES-0011/TRES-0011_MASTER_ARCHITECT_RECONCILIATION.md` — **PROCEED WITH EXPLICIT V0 / REDESIGN GUARDRAILS**
- Frozen Slice-4 v1 acceptance: **IMMUTABLE HISTORICAL EVIDENCE**
  - manifest/ref: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST.md` / `sfl-v0-slice4-acceptance-v1`
  - frozen manifest blob: `7edff7a0507d68037979b3b5e458864f1f8d6518`
- Successor Slice-4 acceptance v2: **FROZEN / PASS**
  - manifest/ref: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md` / `sfl-v0-slice4-acceptance-v2`
  - frozen blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`
  - freeze record: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`
  - final review: `research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**
  - successor acceptance gate: **CLOSED / PASS**
- Slice-4 inherited verification adaptation: **APPROVED / GATE CLOSED**
  - approved ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`
  - exact plan commit/blob: `68fddec788b5cf41db5934c8719a6fd1ce474d32` / `00c3e64a128fa00e91b99117e321a0e379dd61c5`
  - final review: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2_CANDIDATE2.md` — **PASS — ADAPTATION PLAN APPROVED**
  - approval record: `plans/verification/SFL_V0/SLICE4_INHERITED_VERIFICATION_ADAPTATION_V2_APPROVAL_RECORD.md`
- Slice-4 implementation boundary: **RELEASED FOR BOUNDED IMPLEMENTATION**
  - historical blocked boundary remains immutable: `sfl-v0-slice4-implementation-boundary-blocked-v1`
  - release record: `plans/verification/SFL_V0/SLICE4_IMPLEMENTATION_RELEASE_RECORD.md`
- IMP-0004 / Slice 4: **VERIFIED COMPLETE / PROMOTED**
  - task: `tasks/implementation/IMP-0004_SFL_V0_SLICE4_HOUSEHOLD_HEAD_AND_COLLECTIVE_ACTION.md`
  - reviewed candidate: `imp-0004-slice4-conformance-candidate-v1` @ `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`
  - independent conformance: `research/technical/IMP-0004/IMP-0004_INDEPENDENT_CONFORMANCE_REVIEW_V1.md` — **PASS — PROMOTE**
  - promotion merge: `c72ae67dc76ac091331fcd5494c6657eec57f703`
  - post-promotion CI: `36098636634` — **PASS**
  - final record: `research/technical/IMP-0004/IMP-0004_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`
- Slice 5: **FROZEN ACCEPTANCE / BOUNDED IMPLEMENTATION ACTIVE**
  - frozen manifest/ref: `plans/verification/SFL_V0/SLICE5_ACCEPTANCE_MANIFEST.md` / `sfl-v0-slice5-acceptance-v1`
  - freeze commit/blob: `f0f32f06cdd607b04df4f14c4bc49bcde4d056bf` / `1834a1a49203c07af01618066a7e09b25e7e6238`
  - final review: `research/technical/SFL_V0_SLICE5_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**
  - adaptation gate: **NOT TRIGGERED** for approved no-new-live-authority-field design
  - task: `tasks/implementation/IMP-0005_SFL_V0_SLICE5_CHECKPOINT_CONTINUATION.md`
  - implementation branch: `implementation/imp-0005-slice5-checkpoint-continuation`
  - implementation status: **DISPATCHED / ACTIVE**
  - candidate1/R2 retained as immutable historical evidence
- Slice-1 retro-SID: **SEMANTIC GAP CLOSED / DEC-0015 ACCEPTED / SUCCESSOR ACCEPTANCE V2 FROZEN / CONFORMANCE PENDING**
  - task: `tasks/research/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`
  - preserved return: `research/technical/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`
  - MA reconciliation: `research/technical/SID_RETRO_SLICE1_PASSB_RECONCILIATION.md`
  - accepted decision: `decisions/DEC-0015_RELATION_DIAGONAL_ADMISSIBILITY_AND_SELF_ALIAS_SEMANTICS.md`
  - promotion audit: `research/technical/DEC-0015_PROMOTION_RECONCILIATION.md`
  - closure: `research/technical/SID_RETRO_SLICE1_CLOSURE_REVALIDATION.md` — **0 consequential semantic unresolved**
  - frozen successor: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST_V2.md` / `sfl-v0-slice1-acceptance-v2`
  - freeze commit/blob: `bf77bb38a8a7bc964159188b7359cb8e9af2b483` / `174ccbae57a64f06bd88de233b11a011b4a2b115`
  - fresh review: `research/technical/SFL_V0_SLICE1_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE1.md` — **PASS — MAY FREEZE UNCHANGED**
  - frozen census: **173 = 134 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED**
  - freeze record: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_V2_FREEZE_RECORD.md`
  - conformance task: `tasks/implementation/SFL_V0_SLICE1_SUCCESSOR_V2_DEC0015_CONFORMANCE.md`
  - implementation candidate: `imp-0001-slice1-successor-v2-dec0015-conformance-candidate-v1` @ `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`
  - final-head CI: `36124403519` — **PASS**
  - independent review: `research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_INDEPENDENT_CONFORMANCE_REVIEW_V1.md` — **PASS — PROMOTE**
  - promotion merge: `ad87ec0bd04f689a60dc4d743a6c609e9645e3a7`
  - post-promotion CI: `36132006829` — **PASS**
  - final record: `research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`
  - implementation status: **VERIFIED CONFORMANT / PROMOTED**

Conceptual archive systematization: **COMPLETE / PASS**
- ingestion register: `research/conceptual/CONCEPTUAL_INGESTION_REGISTER.md`
- coverage audit: `research/conceptual/CONCEPTUAL_ESSENCE_COVERAGE_AUDIT_2026-09-24.md`
- final integration merge: `03bd1a4566de99d77b30fee0ae21ef4fc796ba00`
- coverage: **81/81 baseline files, 17/17 restored files, 66/66 checked source-family blobs unchanged**

Master Architect succession / chat retirement:
- handoff: `plans/MASTER_ARCHITECT_HANDOFF_2026-09-25.md`
- current successor responsibility: inspect and reconcile the exact Slice-5 acceptance candidate1 review return supplied by the Project Director
- do not infer a review verdict from branch existence; verify exact ancestry/return contents first

Current operational truth is maintained in `plans/CURRENT_PHASE.md`.

## Where to look

- Founding intent: `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- Master Architect behavior: `governance/MASTER_ARCHITECT_GUIDE.md`
- Authority/promotion: `governance/AUTHORITY_AND_DECISION_PROMOTION.md`
- Delegation/research protocol: `governance/AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`
- Specification→implementation assurance: `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`
- Architecture development rules: `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- Drift audit: `governance/REVIEW_AND_DRIFT_AUDIT.md`
- Decision register: `decisions/DECISION_REGISTER.md`
- Accepted architecture: `architecture/accepted/`
- Accepted SFL specification: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- Slice-4 verification package / successor candidate: `plans/verification/SFL_V0/README.md`
- Active assumptions: `registers/ASSUMPTIONS_REGISTER.md`
- Open/resolved design questions: `registers/OPEN_ISSUES_REGISTER.md`
- Current phase: `plans/CURRENT_PHASE.md`
- Active Master Architect succession handoff: `plans/MASTER_ARCHITECT_SUCCESSION_HANDOFF_2026-09-22.md`
- Verification workbench: `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`
- Canonical verification cards: `plans/verification/SFL_V0/`
- C# implementation-risk guardrails for Stage 4: `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- Pre-implementation red team: `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/`
- Active/prepared implementation tasks: `tasks/implementation/README.md`
- Task templates: `tasks/`

## Repository discipline

This Git repository is the canonical working location. Git preserves history; current canonical artifacts remain current. Working design stays explicitly non-authoritative until promoted.
