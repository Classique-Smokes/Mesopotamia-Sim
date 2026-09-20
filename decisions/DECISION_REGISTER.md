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
| DEC-0005 | Adopt the Architecture Development Policy | PROPOSED | Architectural process governance | 2026-09-19 | — | `DEC-0005_ARCHITECTURE_DEVELOPMENT_POLICY_PROPOSAL.md` |

## Accepted decision summaries

### DEC-0001 — Foundational Social-Fabric Model

- **Decision:** Begin from persistent individuals, resources/places, meaningful relationships/claims/obligations, and the events/processes that change them. Households emerge from this lower-level social fabric and may become persistent causal actors; they are not primitive containers.
- **Key constraint:** Household association does not automatically imply kinship, residence, ownership, labor/service, support, dependency, institutional affiliation, or exclusivity.
- **Rationale:** Required by the Seed's bottom-up/recursive philosophy and reinforced by RES-0001's evidence that these social dimensions must remain distinguishable.
- **Approver:** Human Project Director.
- **Full accepted record:** `DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`

## Additional accepted decisions

### DEC-0002 — Master Architect Operating Guide

- **Decision:** Adopt `governance/MASTER_ARCHITECT_GUIDE.md` as canonical operating policy for the Master Architect.
- **Full accepted record:** `DEC-0002_MASTER_ARCHITECT_GUIDE.md`

### DEC-0003 — Active Social-State Representation

- **Decision:** Independently identified typed records with explicit references; prototype active state begins in indexed in-memory structures.
- **Full accepted record:** `../architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`

### DEC-0004 — Hierarchical Individual Agency

- **Decision:** Hierarchical soft-gated concern selection, contextual candidate generation, local component scoring, separate persistent goals, and later bounded planning.
- **Full accepted record:** `../architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`

## Proposed decisions

### DEC-0005 — Architecture Development Policy

- **Proposal:** Adopt `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md` as the durable policy for progressive, evidence-driven architecture evolution.
- **Status:** PROPOSED; not yet binding.
- **Full proposal:** `DEC-0005_ARCHITECTURE_DEVELOPMENT_POLICY_PROPOSAL.md`

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
