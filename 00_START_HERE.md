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

**ROADMAP STAGE 3 — SFL v0 VERIFICATION DESIGN**

Accepted foundation:

- `DEC-0001` — Foundational Social-Fabric Model
- `DEC-0002` — Master Architect Operating Guide
- `ADR-0001 / DEC-0003` — Active Social-State Representation
- `ADR-0002 / DEC-0004` — Hierarchical Individual Agency
- `DEC-0005` — Architecture Development Policy
- `ADR-0003 / DEC-0006` — Progressive Derived-State Specialization
- `ADR-0004 / DEC-0007` — Reference Simulation Kernel
- `ADR-0005 / DEC-0008` — C# 14 / .NET 10 LTS Host Runtime
- `SPEC-SFL-0001` — accepted Social Fabric Laboratory v0 semantics

Active work:

- `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`
- `plans/verification/SFL_V0/`
- current verification focus: conflict/invalidation, reaction closure, and communication provenance; one narrow multi-contributor provision-allocation erratum remains open

No production implementation has started.

## Where to look

- Founding intent: `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- Master Architect behavior: `governance/MASTER_ARCHITECT_GUIDE.md`
- Authority/promotion: `governance/AUTHORITY_AND_DECISION_PROMOTION.md`
- Architecture development rules: `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- Drift audit: `governance/REVIEW_AND_DRIFT_AUDIT.md`
- Decision register: `decisions/DECISION_REGISTER.md`
- Accepted architecture: `architecture/accepted/`
- Accepted SFL specification: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- Active assumptions: `registers/ASSUMPTIONS_REGISTER.md`
- Open/resolved design questions: `registers/OPEN_ISSUES_REGISTER.md`
- Current phase: `plans/CURRENT_PHASE.md`
- Verification workbench: `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`
- Canonical verification cards: `plans/verification/SFL_V0/`
- C# implementation-risk guardrails for Stage 4: `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- Task templates: `tasks/`

## Repository discipline

This Git repository is the canonical working location. Git preserves history; current canonical artifacts remain current. Working design stays explicitly non-authoritative until promoted.
