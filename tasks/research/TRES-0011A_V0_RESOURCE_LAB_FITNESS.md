# TRES-0011A — V0 Resource Scaffold / Laboratory-Fitness Audit

**Task type:** independent internal design/research audit  
**Context mode:** PROJECT-CONTEXT  
**Role:** senior simulation-model reviewer  
**Authority:** advisory only; do not change accepted semantics, architecture, or Slice-4 decision status

## Question

Does the current crude Household resource/provision scaffold — including the existing `HouseholdProvisionCommitment` model, DEC-0011 private transaction supplementation, and the Director's current working inclinations on the six SID decisions — remain fit for **SFL v0's stated purpose as a social-mechanism laboratory**, or has the resource model become so specific/distorting that v0's goals should be reconsidered before Slice 4 proceeds?

This is not a request to design the final Household economy.

## Director concern to preserve faithfully

The Director's current working view is:

- Household spending/provision is deliberately crude;
- the future Household resource system may be redesigned substantially;
- exact future ownership/pooling/commitment/accounting mechanisms are not yet known and require later research;
- current D1–D6 inclinations are useful for bounded v0 behavior, but should not accidentally harden this placeholder into future architecture;
- the concern is whether a more experienced modeler would say the project has already crossed from "useful scaffold" into "misleading laboratory."

Treat these as non-authoritative research context, not accepted decisions.

## Required internal sources

Read at minimum:

- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- `plans/FIRST_PROTOTYPE_DEVELOPMENT_ROADMAP.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `decisions/DEC-0005_ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `decisions/DEC-0006_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `decisions/DEC-0007_REFERENCE_SIMULATION_KERNEL.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md`
- `research/technical/SFL_V0_SLICE4_SID_PASSB_RECONCILIATION.md`

Use accepted authority over proposal text where they differ.

## Core tests

### A. Purpose fit

Reconstruct, from authority, what SFL v0 actually has to demonstrate.

Distinguish:

- laboratory purpose;
- historical-calibration purpose;
- future production-simulation purpose.

Ask whether the resource scaffold is required to be historically final, merely causally grounded, or something in between.

### B. Minimal sufficient mechanism

For each current resource mechanism, identify what laboratory question it exists to test:

- personal grain;
- protected reserve / NeedsGrain;
- persistent provision commitment;
- derived mobilizable capacity;
- actual Household material spend;
- head/private dual-capacity funding;
- resource conflict/revalidation;
- provenance/history.

Classify each as:

- essential to v0 purpose;
- replaceable implementation/mechanism choice;
- assumption used only to expose a causal seam;
- premature semantic commitment;
- unnecessary complexity.

### C. Distortion test

Ask whether current resource semantics could cause the laboratory to give a false answer about its actual target questions, especially:

- can a Household act through people/resources without becoming an unexplained abstract actor?
- can institutional authority remain separate from private ownership?
- can collective capability affect individual possibility?
- can one person occupy office and private-owner capacities without collapse?
- can material conflicts be causally inspected?
- can Household identity/role persist independently of the exact resource mechanism?

If the scaffold changes quantitative outcomes but still correctly tests these structural questions, say so.

If it changes the **structural conclusion**, identify exactly how.

### D. Future redesign compatibility

Assume a future resource model might introduce some combination of:

- pooled/common Household property;
- differentiated ownership/use/control;
- household-owned stores;
- contributions/taxes/dues;
- labor/service obligations;
- land/livestock/production;
- accounting/budgets;
- in-kind versus fungible goods;
- unequal authority over assets;
- dependents and consumption claims;
- external institutional transfers.

Do not design these.

Ask which current v0 conclusions should survive such redesign and which are explicitly provisional.

### E. Six SID decisions

Evaluate D1–D6 only for **laboratory safety/reversibility**, not for substantive approval.

For each, classify:

- resource-model-independent;
- resource-model-coupled but safely local;
- dangerous because it hardens the placeholder;
- should be reworded as v0-only;
- should be deferred pending future economic research.

Pay special attention to D1 and D4.

### F. Red lines

Define concrete conditions that would mean the current scaffold has stopped being a healthy laboratory mechanism and must be redesigned before more layers depend on it.

## Required output

Create:

`research/technical/TRES-0011/TRES-0011A_V0_RESOURCE_LAB_FITNESS.md`

Use exactly one verdict:

- **LAB PURPOSE PRESERVED**
- **LAB PURPOSE PRESERVED WITH GUARDRAILS**
- **V0 GOAL CONFLICT — REOPEN RESOURCE SEMANTICS**
- **RESOURCE MODEL MUST PRECEDE SLICE 4**

If guardrails are needed, keep them minimal and state whether they are semantic wording, verification, architecture/seam, or research triggers.

## Return discipline

Return branch:

`review/tres-0011a-v0-resource-lab-fitness-return`

Begin from:

`tres-0011-v0-resource-scaffold-wave-v1`

Add only the report.
