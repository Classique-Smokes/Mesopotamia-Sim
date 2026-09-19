# ADR-0001 — Active Social-State Representation

**Status:** ACCEPTED  
**Decision Register:** DEC-0003  
**Authority:** Architectural  
**Accepted:** 2026-09-19  
**Approver:** Human Project Director

## Decision

Represent simulation-relevant things as **independently identified, typed records connected by explicit references**.

Relationships and continuing arrangements receive their own identity when their terms, participants, state, or history must be referenced independently. Collective records refer to constituents and sustaining relationships/arrangements rather than copying or owning those entities.

The prototype's active state begins in **indexed in-memory structures**, accessed through narrow domain operations rather than storage-specific lookups scattered through behavioral logic.

## Consequences

- One entity may participate in multiple structures without being cloned.
- Changing collective association does not move or duplicate the underlying entity.
- Explicit index/reference consistency and save/load verification are required.
- A graph-shaped model does not imply a graph database.

## Not decided

Exact schema, programming language, OOP/data-oriented/ECS/functional style, persistence/history datastore, serialization, and production storage architecture remain open.

## Evidence

- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`
- TRES-0001B technical research (to be archived under `research/technical/TRES-0001/`).
