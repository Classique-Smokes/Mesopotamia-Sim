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
- verified candidate-v3: `imp-0001-slice1-conformance-candidate-v3` @ `06e25644879dd8505e24fcaeb43256f69c29c15f`
- independent K4: `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V3.md` — **PASS**
- canonical promotion: `262dc6e1d846761110fcd6a063bf8b4aa267b3dc`; post-promotion CI `35800043322` PASS
- final completion record: `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`
- **next substantive activity:** `plans/SFL_V0_SLICE1_BIRTH_OBSERVATION_PLAN.md` before Slice 2
- frozen Slice-1 acceptance authority remains `SFL-V0-S1-ACCEPTANCE-v1`
- failed candidate-v1/v2 refs remain historical evidence pending branch-hygiene reconciliation
- TRES-0010 pre-implementation gate: **CLOSED / PASS**
- GOV-0001 rulebook restructuring: **PROMOTED / DEC-0009 ACCEPTED**

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
