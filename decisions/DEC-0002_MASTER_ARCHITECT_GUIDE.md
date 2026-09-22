# DEC-0002 — Adopt Master Architect Operating Guide

**Status:** ACCEPTED  
**Authority:** Constitutional  
**Accepted by:** Project Director  
**Date:** 2026-09-19

## Decision

Adopt `governance/MASTER_ARCHITECT_GUIDE.md` as the canonical operating reference for the Master Architect role.

The Guide governs how the Master Architect interprets conversational input, manages authority, retrieves context, delegates work, reconciles specialist returns, frames and promotes decisions, protects the critical path, verifies implementation, and maintains recoverable long-horizon project state.

## Rationale

The Project Seed establishes the role and authority model but leaves important operating behavior implicit. The Guide makes those behaviors explicit so the Project Director can communicate naturally without repeatedly managing AI workflow discipline.

## Consequences

- The Master Architect carries process discipline by default.
- Proposals may be explanatory; accepted records should be concise.
- Delegations must distinguish `PROJECT-CONTEXT` from `INDEPENDENT-CONTEXT` work.
- Exploratory agents receive objectives and genuine constraints without unnecessary solution anchoring.
- The Master Architect retains synthesis, reconciliation, authority handling, and canonical promotion while delegating bounded volume work.
- Verification must not rely on the Project Director's ability to inspect generated code manually.
- Long-horizon work must leave recoverable artifacts and clean handoffs.

## Amendment / lineage

DEC-0009 (accepted 2026-09-22) reorganizes the operating doctrine established here without superseding this decision's role split or intent.

The canonical operating structure is now:

- `governance/MASTER_ARCHITECT_GUIDE.md` — compact constitutional core and work-mode routing;
- `governance/AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md` — delegated research/review/adversarial procedure;
- `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md` — consequential specification→implementation assurance;
- existing specialized governance protocols for interpretation, promotion, architecture development, escalation, and drift remain their procedural owners.

See `DEC-0009_MASTER_ARCHITECT_RULEBOOK_REFACTOR.md` for the amendment and promotion evidence.

## Unaffected / Undecided

This decision does not select any simulation mechanic, software architecture, language, engine, database, framework, agent model, or implementation technology.

## Canonical Reference

`governance/MASTER_ARCHITECT_GUIDE.md`
