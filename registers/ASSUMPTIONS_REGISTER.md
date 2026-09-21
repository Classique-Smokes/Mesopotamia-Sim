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
| ASM-0002 | ACTIVE | v0 attitude events use fixed increments and natural drift of +attitude by 2 toward zero versus -attitude by 1 toward zero per decay event. | SFL v0 relationship dynamics. | Verification or historical/behavioral evidence showing the magnitudes distort the laboratory. |
| ASM-0003 | ACTIVE | Farm yields 4 grain; consumption is 1 per cycle; typical initial stock is 4-8; debt repayment preserves a 2-grain reserve. | SFL v0 scarcity/debt behavior. | Verification, balance testing, or later economic subsystem. |
| ASM-0004 | ACTIVE | Parent/child and sibling kinship both multiply the attitude-derived component of ordinary interpersonal choice by 1.5x. | SFL v0 kinship effect. | Historical evidence or verification showing type-specific/different treatment is required. |
| ASM-0005 | ACTIVE | Initial v0 household formation requires shared residence plus a durable tie, two qualifying support events on separate cycles, and founding-core recognition. | SFL v0 household formation recognizer. | Historical evidence, verification, or later household model showing the gate is too narrow/broad. |
| ASM-0006 | ACTIVE | Head appointment/succession requires unanimous sustaining-participant acceptance; provision spending uses 2-grain contributor reserve and largest-surplus-first allocation. | SFL v0 collective authority/resource mobilization. | Verification, historical evidence, or richer governance/accounting rules. |

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

### ASM-0002 — Attitude dynamics parameters

- **Status:** ACTIVE
- **Assumption:** v0 uses fixed attitude increments (+5/+10/-5/-10/-20 by event) and, on each later-scheduled decay event, positive attitude moves 2 toward zero while negative attitude moves 1 toward zero.
- **Why temporarily needed:** Deterministic inspectable relationship dynamics are required without claiming a psychological calibration.
- **Scope / impact:** Actor social evaluation and long-run relationship persistence.
- **Not authoritative for:** Historical psychology, real-world relationship rates, or later personality systems.
- **Review / replacement trigger:** Verification/balance testing or relevant research.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0003 — Grain laboratory parameters

- **Status:** ACTIVE
- **Assumption:** Farm yields 4 grain; consumption costs 1 per cycle; typical scenario start is 4-8 grain; debt repayment preserves 2 grain.
- **Why temporarily needed:** v0 needs renewable scarcity and material tradeoffs.
- **Scope / impact:** Farming, subsistence, lending, repayment, gifts, and later household resource coordination.
- **Not authoritative for:** Historical yields, rations, prices, household wealth, or economic calibration.
- **Review / replacement trigger:** Verification/balance testing or introduction of a historical economic subsystem.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0004 — Kinship attitude amplification

- **Status:** ACTIVE
- **Assumption:** Parent/child and sibling relations both multiply the attitude-derived component of ordinary interpersonal decision evaluation by 1.5x; marriage is excluded.
- **Why temporarily needed:** Kinship must matter behaviorally in v0 without becoming household membership or a second attitude variable.
- **Scope / impact:** Ordinary interpersonal action scoring.
- **Not authoritative for:** Historical kin obligations, marriage rules beyond the explicit v0 exclusion, or relative strengths of kin categories.
- **Review / replacement trigger:** Recovered historical research or verification showing the factor/type uniformity is inadequate.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0005 — Household formation gate

- **Status:** ACTIVE
- **Assumption:** Initial v0 formation requires shared residence, a kinship/marriage/mutual-strong-like durable tie, two qualifying support events on separate cycles, and recognition by every required founding-core actor.
- **Why temporarily needed:** v0 needs a falsifiable formation gate without claiming a universal or historical household definition.
- **Scope / impact:** Candidate-to-household formation only; later continuity uses a different historical rule.
- **Not authoritative for:** Old Babylonian household prevalence, universal household formation, later institutional or lifecycle models.
- **Review / replacement trigger:** Historical evidence, verification results, or expansion beyond the first household laboratory.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0006 — v0 household governance and allocation

- **Status:** ACTIVE
- **Assumption:** Head appointment/succession uses unanimous sustaining-participant acceptance. Provision commitments expose grain above the existing 2-grain personal reserve; collective expenditure draws largest available surplus first with stable-ID tie-break.
- **Why temporarily needed:** v0 needs deterministic, inspectable authority and resource-allocation rules without a broader governance/accounting system.
- **Scope / impact:** Household head legitimacy, collective support, dowry funding, and double-spend prevention.
- **Not authoritative for:** Historical household governance, contribution shares, taxation, property, inheritance, or later office/accounting systems.
- **Review / replacement trigger:** Verification, recovered historical evidence, or expansion to richer governance/resource systems.
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
