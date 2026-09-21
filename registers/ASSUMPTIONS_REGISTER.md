# Assumptions Register

**Purpose:** Keep temporary assumptions visible so prototypes, tests, research, or incomplete systems do not fossilize into project truth.

## Statuses

`ACTIVE / UNDER_REVIEW / RETIRED`

## Required fields

| Field | Meaning |
|---|---|
| Assumption ID | Stable ID, e.g. `ASM-0001` |
| Status | ACTIVE / UNDER_REVIEW / RETIRED |
| Assumption | What is temporarily being assumed |
| Why needed | Why work cannot currently proceed without it |
| Scope / impact | Where it affects behavior, evidence interpretation, testing, or architecture |
| Authority boundary | What this assumption is explicitly **not** allowed to decide |
| Review / replacement trigger | Evidence, decision, experiment, or milestone that would allow replacement/review |
| Introduced by / date | Provenance |
| Related artifacts | Tasks, specs, evidence, or decisions |

## Current register

Working specification has now introduced controlled laboratory assumptions. They remain non-historical and replaceable.

| Assumption ID | Status | Assumption | Scope / impact | Review trigger |
|---|---|---|---|---|
| ASM-0001 | ACTIVE | Relationship-mediated reciprocity may create a favour only when the recipient's directed attitude toward the benefactor is >= +75 (strong-like). | SFL v0 favour creation and actor evaluation. | Historical evidence, scenario testing, or Pass B/G verification showing the threshold is misleading or unnecessary. |

### ASM-0001 — Reciprocity attitude gate

- **Status:** ACTIVE
- **Assumption:** For SFL v0, an accepted beneficial action may create a relationship-mediated favour only when the recipient's directed attitude toward the benefactor is at least +75, corresponding to the current strong-like band.
- **Why temporarily needed:** The laboratory needs a simple, inspectable gate distinguishing ordinary accepted benefits from socially obligation-bearing reciprocity without yet implementing norms, reputation, or richer relational context.
- **Scope / impact:** Favour creation and the decision consequences of accepting beneficial actions.
- **Not authoritative for:** Old Babylonian reciprocity thresholds, historical psychology, universal social behavior, or later project-wide norm mechanics.
- **Review / replacement trigger:** Recovery of relevant RES-0001 evidence; a later norm/reputation/recognition model; or verification scenarios showing the threshold produces poor or degenerate behavior.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

## Entry template

### ASM-XXXX — [Short title]

- **Status:** ACTIVE
- **Assumption:**
- **Why temporarily needed:**
- **Scope / impact:**
- **Not authoritative for:**
- **Review / replacement trigger:**
- **Introduced by:**
- **Date:** YYYY-MM-DD
- **Related artifacts:**
