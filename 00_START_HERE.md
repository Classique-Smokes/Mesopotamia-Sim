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
- Slice-3 acceptance authority: **FROZEN / PASS**
  - manifest: `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
  - version/ref: `SFL-V0-S3-ACCEPTANCE-v1` / `sfl-v0-slice3-acceptance-v1`
  - freeze commit: `25160f33c994fd5f3e277ae98f03e55d37c878dd`
  - frozen manifest SHA: `1aae13dc27572361fe99c31ef8aee0444d39364a`
  - final pre-code review: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_V3_FINAL.md` — **PASS — MAY FREEZE UNCHANGED**
- IMP-0003 / Slice 3: **READY FOR DISPATCH**
  - task: `tasks/implementation/IMP-0003_SFL_V0_SLICE3_HOUSEHOLD_SUBSTRATE.md`
  - planned branch: `implementation/imp-0003-slice3-household`
- conditional S1-084 implementation gate:
  - `tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`
  - fires before any change to the exact `WorldState` private-field inventory or current S1-084 structural evidence path.
- head/office, endogenous provision solicitation/spending, mediated marriage authority, and checkpoint/restore remain later-slice work.

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
- Frozen Slice-3 acceptance authority: `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
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
