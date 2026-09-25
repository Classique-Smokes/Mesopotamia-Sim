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
  - next gate: inherited-verification adaptation reassessment + fresh independent review
- Slice-4 implementation boundary: **DIRECTOR BLOCK STILL ACTIVE**
  - immutable original boundary: `sfl-v0-slice4-implementation-boundary-blocked-v1` @ `7ce569456c87297e7349b3ca7d7917c5e30b1b88`
  - current remaining gates: successor acceptance v2 PASS/freeze, then inherited-verification adaptation reassessment + fresh independent review
- Slice-4 inherited verification adaptation: **CANDIDATE2 FRESH REVIEW READY**
  - candidate1 review: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2.md` — **BLOCK — LOSSLESSNESS / ENFORCEMENT DEFECT**
  - candidate2 ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-candidate2` @ `68fddec788b5cf41db5934c8719a6fd1ce474d32`
  - candidate2 plan blob: `00c3e64a128fa00e91b99117e321a0e379dd61c5`
  - reassessment: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REASSESSMENT.md`
  - review task: `tasks/research/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2_CANDIDATE2.md`
  - reviewer status: **NO REVIEWER ACTIVE YET**
- Slice-4 implementation: **NOT AUTHORIZED**. No implementation packet or coding bārû may proceed until adaptation PASS + explicit gate closure.
- checkpoint/restore remains Slice 5.

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
