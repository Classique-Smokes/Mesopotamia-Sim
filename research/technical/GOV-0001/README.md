# GOV-0001 — Master Architect Rulebook Refactor State

**Status:** CLOSED / PROMOTED  
**Authority:** Operational continuity record; accepted authority resides in DEC-0009 and the promoted governance artifacts  
**Date:** 2026-09-22

## 1. Final result

DEC-0009 — Layered Master Architect Rulebook Refactor — was explicitly accepted by the Project Director and promoted to canonical `main`.

Canonical promotion merge:

`339d8ea5173b0c5d1891899f30d20f76fb1edca6`

Promotion record:

`research/technical/GOV-0001/PROMOTION_RECORD.md`

## 2. Historical provenance

- pre-refactor baseline: `governance-rulebook-refactor-baseline` @ `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b`
- evaluated candidate: `governance-rulebook-refactor-candidate` @ `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`
- promotion branch: `governance/gov-0001-promotion`
- promotion PR: #5

These refs are historical/reproducibility evidence, not competing current governance.

## 3. Evaluation

- GOV-0001-A: **PASS**
- GOV-0001-B: **PASS**
- GOV-0001-C: **PASS**
- central reconciliation: **PASS / no repair / no rerun**

Canonical advisory returns:

`research/technical/GOV-0001/returns/`

Central reconciliation:

`research/technical/GOV-0001/FRESH_AGENT_EVALUATION_RECONCILIATION.md`

## 4. Promotion integrity

Compared with the frozen evaluated candidate:

- 15 / 19 candidate-controlled files are byte-identical;
- the remaining four differ only by accepted status/authority headers;
- exactly 7 textual lines changed across those four files;
- no evaluated operative rule changed.

Post-merge root retrieval verification on canonical `main` passed **23 / 23** checks.

## 5. Canonical rulebook

Current governance is discovered through:

`AGENTS.md → 00_START_HERE.md → plans/CURRENT_PHASE.md → governance/MASTER_ARCHITECT_GUIDE.md → triggered owner`

The compact Guide routes recurring work to:

- `INTERPRETATION_PROTOCOL.md`
- `AUTHORITY_AND_DECISION_PROMOTION.md`
- `AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`
- `ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`
- `ARCHITECTURE_ESCALATION_RULES.md`
- `REVIEW_AND_DRIFT_AUDIT.md`

Routine local/reversible work does not load every protocol.

## 6. Separation from implementation

GOV-0001 did not alter SFL semantics, accepted simulation/software architecture, Slice-1 acceptance authority, or IMP-0001 scope.

`IMP-0001` remains TRES-cleared and ready for dispatch.

## 7. Recovery rule

A future Master Architect should use canonical `main`, not the candidate/evaluation branches.

For GOV-0001 history, read this file and `PROMOTION_RECORD.md`; branch archaeology is not required for normal operation.
