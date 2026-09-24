# Decision Register

**Purpose:** Canonical register of consequential project decisions and their status.

## Status lifecycle

`OPEN` — decision need identified, no preferred option established.  
`PROPOSED` — a specific option has been formally proposed but not accepted.  
`ACCEPTED` — accepted by the authority required for its level.  
`REJECTED` — explicitly declined.  
`SUPERSEDED` — once accepted, later replaced by another accepted decision.

Silence, lack of objection, repetition, implementation momentum, or code existence never changes status to `ACCEPTED`.

## Current register

| Decision ID | Title | Status | Authority | Opened | Resolved | Reference |
|---|---|---|---|---|---|---|
| DEC-0001 | Foundational Social-Fabric Model | ACCEPTED | Constitutional | 2026-09-19 | 2026-09-19 | `DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md` |
| DEC-0002 | Adopt the Master Architect Operating Guide | ACCEPTED | Constitutional | 2026-09-19 | 2026-09-19 | `DEC-0002_MASTER_ARCHITECT_GUIDE.md` |
| DEC-0003 | Active Social-State Representation | ACCEPTED | Architectural | 2026-09-19 | 2026-09-19 | `../architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` |
| DEC-0004 | Hierarchical Individual Agency | ACCEPTED | Architectural | 2026-09-19 | 2026-09-19 | `../architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` |
| DEC-0005 | Architecture Development Policy | ACCEPTED | Architectural process governance | 2026-09-19 | 2026-09-19 | `DEC-0005_ARCHITECTURE_DEVELOPMENT_POLICY.md` |
| DEC-0006 | Progressive Derived-State Specialization | ACCEPTED | Architectural | 2026-09-19 | 2026-09-19 | `../architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md` |
| DEC-0007 | Reference Simulation Kernel | ACCEPTED | Architectural | 2026-09-20 | 2026-09-20 | `DEC-0007_REFERENCE_SIMULATION_KERNEL.md` |
| DEC-0008 | Host Runtime | ACCEPTED | Architectural | 2026-09-21 | 2026-09-21 | `DEC-0008_HOST_RUNTIME.md` |
| DEC-0009 | Layered Master Architect Rulebook Refactor | ACCEPTED | Constitutional | 2026-09-21 | 2026-09-22 | `DEC-0009_MASTER_ARCHITECT_RULEBOOK_REFACTOR.md` |
| DEC-0010 | Slice-4 Authority Use Before Authority Destruction | ACCEPTED | Architectural / social-semantic | 2026-09-24 | 2026-09-24 | `DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md` |
| DEC-0011 | Transaction-Specific Office-Holder Private Supplementation | ACCEPTED | Architectural / social-semantic | 2026-09-24 | 2026-09-24 | `DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md` |
| DEC-0012 | Semantic Interaction Delta Failsafe | ACCEPTED | Constitutional / process governance | 2026-09-24 | 2026-09-24 | `DEC-0012_SEMANTIC_INTERACTION_DELTA_FAILSAFE.md` |
| DEC-0013 | Slice-4 SID Closure and V0 Resource-Scaffold Boundaries | PROPOSED | Architectural / social-semantic | 2026-09-24 | — | `DEC-0013_SLICE4_SID_CLOSURE_AND_V0_RESOURCE_SCAFFOLD_BOUNDARIES.md` |

## Accepted summaries

- **DEC-0001:** social reality begins with persistent individuals, typed relations/claims, resources/places, and processes; households emerge without becoming primitive containers; social position remains multidimensional rather than one scalar status.
- **DEC-0002:** the Master Architect carries process discipline, synthesis, delegation, authority, verification, and continuity.
- **DEC-0003:** simulation-relevant things use independently identified typed records with explicit references; prototype active state begins indexed in memory.
- **DEC-0004:** individual agency uses soft hierarchical concerns, contextual candidate generation, local scoring, persistent goals, and later bounded planning.
- **DEC-0005:** architecture evolves through semantic authority, simplest sufficient implementation, measured progressive specialization, and evidence-gated complexity.
- **DEC-0006:** derived state uses the simplest sufficient maintenance strategy per subsystem and may graduate behind stable semantic boundaries when measured need justifies it.
- **DEC-0007:** the first laboratory uses a single-process deterministic reference kernel with proposal/commit mutation, stable cycle-state publication after reaction closure, explicit process state, simulation-owned randomness boundaries, semantic history, and complete continuation checkpoints.
- **DEC-0008:** the first laboratory uses C# 14 / .NET 10 LTS as its host runtime.
- **DEC-0009:** the Master Architect rulebook uses a compact constitutional core that routes consequence-triggered work to single-owner protocols, templates/checklists, and mechanical enforcement where mature.
- **DEC-0010:** in bounded Slice-4 same-cycle races, an otherwise-valid accepted action/role transition may perform its valid last act before an accepted transition destroys the head/Household authority or institutional status it depends on; no rebinding or technical-ID authority is introduced.
- **DEC-0011:** a current valid office-holder may explicitly contribute an exact transaction-specific amount of privately owned disposable grain to one authorized Household material action; the remaining cost is funded through ordinary persistent commitment backing, with no extra personal initiative/response, no standing-capacity inflation, no double counting, and exact source provenance.
- **DEC-0012:** consequential new semantic layers use the trigger-based `SID-ASSURANCE-v1` Semantic Interaction Delta Failsafe before acceptance freeze: bounded new↔old frontier analysis, independently frozen fresh-reviewer Pass A before MA-frontier reveal, Pass-B negative-space challenge over the reconciled union, authority-bearing dispositions, semantic-base freshness/revalidation, implementation stop-on-unclassified-interaction, and evidence-based sunset after 2–3 triggered slices.

## Entry template

### DEC-XXXX — [Title]

- **Status:** OPEN / PROPOSED / ACCEPTED / REJECTED / SUPERSEDED
- **Authority level:** Constitutional / Architectural / Engineering
- **Date opened:** YYYY-MM-DD
- **Date resolved:** —
- **Problem / question:**
- **Decision:** —
- **Rationale:** —
- **Binding consequences / constraints:** —
- **Unresolved / explicitly excluded:** —
- **Approver:** —
- **References / lineage:** —
