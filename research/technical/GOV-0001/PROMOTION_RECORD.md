# GOV-0001 — Constitutional Promotion Record

**Status:** FINAL / PROMOTED  
**Authority:** Supporting promotion evidence; accepted authority resides in DEC-0009 and the promoted governance artifacts  
**Date:** 2026-09-22

## 1. Decision and provenance

- constitutional decision: `DEC-0009 — Layered Master Architect Rulebook Refactor`
- accepted by: Project Director
- accepted date: 2026-09-22
- frozen pre-refactor baseline: `governance-rulebook-refactor-baseline` @ `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b`
- evaluated candidate: `governance-rulebook-refactor-candidate` @ `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`
- promotion branch: `governance/gov-0001-promotion`
- promotion PR: #5 — `Promote DEC-0009 layered Master Architect rulebook`
- canonical promotion merge: `339d8ea5173b0c5d1891899f30d20f76fb1edca6`

The candidate branch was not mutated during promotion. Promotion was transplanted onto current `main` state so later operational-state work was preserved.

## 2. Evaluation gate

Fresh-agent evaluation against the same frozen candidate:

- GOV-0001-A / root routing: **PASS**
- GOV-0001-B / delegation-research-architecture-drift: **PASS**
- GOV-0001-C / assurance-escalation: **PASS**

Central reconciliation:

- `research/technical/GOV-0001/FRESH_AGENT_EVALUATION_RECONCILIATION.md`
- result: **PASS / no candidate repair required / no rerun required**

Advisory returns are retained under:

`research/technical/GOV-0001/returns/`

## 3. Evaluated-content preservation

The 19 candidate-controlled files were compared against canonical `main` after merge.

Result:

- **15 / 19** are byte-identical to the evaluated candidate;
- **4 / 19** differ only by explicit administrative acceptance metadata;
- no evaluated operative rule, trigger, checklist step, template obligation, or research/evaluation control content changed.

Administrative-only differences:

| File | Candidate blob | Promoted blob | Allowed difference |
|---|---|---|---|
| `governance/MASTER_ARCHITECT_GUIDE.md` | `a9c0096856fb0f6c4524e97f1d4e8717ad9e817d` | `ff9bc6f72a33ca3ee0bb5609dfb667769918ed0b` | status + authority header |
| `governance/AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md` | `de24bf8f313de7750d494f27af01a7d4663fa9dd` | `437edee0b4b1aa4f9f8e66d02f140e7ea30c6f14` | status + authority header |
| `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md` | `462e41445c9865c172784973e562d4002ad1995f` | `05db7cdf1de3eaf5e53c12e7ea769a21325d70e4` | status + authority header |
| `governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md` | `5410dd3f91ef76b9f2d60a0be409b4d88da74d4f` | `07ba70ab889705bcd62165e6b12d4b6940e457d0` | status header |

The four-file textual comparison found exactly **7 changed lines total**, all administrative status/authority metadata.

## 4. Promotion integration

The promotion also completed the required constitutional/navigation integration:

- DEC-0009 recorded as **ACCEPTED**;
- DEC-0002 records DEC-0009 amendment/lineage without being silently superseded;
- Decision Register records DEC-0009 and its accepted summary;
- `00_START_HERE.md` exposes DEC-0009 and the two new work-mode protocol owners;
- `plans/CURRENT_PHASE.md` preserves Stage-4 / IMP-0001 readiness;
- fresh-agent evaluation returns are retained on the canonical path;
- `AGENTS.md` was intentionally unchanged because the root retrieval contract itself did not change: it already routes Master Architects through START_HERE → CURRENT_PHASE → MASTER_ARCHITECT_GUIDE.

## 5. Retrieval verification

Required path:

`AGENTS.md → 00_START_HERE.md → plans/CURRENT_PHASE.md → governance/MASTER_ARCHITECT_GUIDE.md → triggered owner`

### Pre-merge

Promotion branch head `08ff5db5fc694b7afda9c9510c4708996f34dc22`:

- **23 / 23 checks PASS**

### Post-merge

Canonical `main` at promotion merge `339d8ea5173b0c5d1891899f30d20f76fb1edca6`:

- **23 / 23 checks PASS**

The checks confirmed discoverability/routing for:

- DEC-0009 constitutional authority;
- interpretation;
- authority/promotion;
- delegation/research;
- architecture development;
- specification→implementation assurance;
- architecture escalation;
- drift review;
- routine low-risk work without blanket protocol loading;
- retained GOV-0001 evaluation evidence;
- unchanged Slice-1 / IMP-0001 dispatch readiness.

## 6. Final state

**GOV-0001 is CLOSED / PROMOTED.**

Current authority is the governance on `main`, not the frozen candidate branch.

The baseline, candidate, evaluation branches, and promotion branch are retained as historical/reproducibility evidence and must not be treated as competing current governance.

Any later operative governance change requires the appropriate authority process; consequential constitutional change requires a new explicit Project Director decision.

## 7. Separation from implementation

This promotion did not alter SFL v0 semantics, architecture, Slice-1 acceptance authority, or IMP-0001 scope.

`IMP-0001` remains cleared and ready for intentional dispatch.
