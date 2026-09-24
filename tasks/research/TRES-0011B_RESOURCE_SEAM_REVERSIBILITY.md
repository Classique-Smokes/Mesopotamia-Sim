# TRES-0011B — Household Resource Scaffold Reversibility / Blast-Radius Audit

**Task type:** independent architecture + implementation-surface audit  
**Context mode:** PROJECT-CONTEXT  
**Role:** senior software/simulation architect  
**Authority:** advisory only; do not redesign the final economy or edit production code

## Question

If the current `HouseholdProvisionCommitment` / mobilizable-capacity / Household-spend semantics are substantially redesigned later, how difficult will that be?

Has v0 preserved a replaceable semantic/implementation seam, or are provisional resource assumptions already becoming architectural lock-in?

## Director concern

The Director expects the Household resource model may change substantially after historical/economic research.

The goal is not to pre-build that future model.

The goal is to detect whether today's scaffold is creating hidden coupling that makes future replacement expensive or semantically dangerous.

## Required sources

Read at minimum:

- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md`
- current canonical Slice-3 implementation and tests
- planned/frozen Slice-4 verification surfaces, but treat frozen Slice-4 v1 as historical/blocked rather than sufficient authority

Inspect code directly.

## Required audit

### A. Current dependency map

Locate every current or planned surface that assumes:

- grain is personally owned;
- reserve = 2 / NeedsGrain capacity rule;
- provision commitments expose personal grain;
- Household has no pooled treasury;
- mobilizable capacity is derived from commitments;
- fixed-rank allocation;
- commitment termination on participation end/dissolution;
- material priority;
- private X;
- provenance distinguishes funding legs.

Separate:

- domain-semantic coupling;
- verification-only coupling;
- implementation representation;
- test-fixture assumptions;
- derived/cache/query assumptions.

### B. Hypothetical replacement exercise

Without designing the future economy, mentally replace the current scaffold with three intentionally different families:

1. Household-owned pooled store;
2. mixed personal + jointly controlled assets/claims;
3. no stock pool at all — transaction authorization against obligations/contributions/production flows.

Ask what breaks.

For each family, identify whether change would require:

- new semantic decisions only;
- new verification but stable architecture;
- local subsystem rewrite;
- resolver/history rewrite;
- Household identity/role rewrite;
- cross-cutting kernel redesign.

### C. Stable seam test

Identify the narrowest durable interface that current architecture appears to rely on, such as:

- "Household material action produces an explicit funding plan";
- "funding legs have owner/provenance";
- "precommit validates live material authority/capacity";
- "commit is atomic";
- "history records sources/effects."

Judge whether those abstractions are genuinely present or whether code/tests are instead tied to the exact commitment algorithm.

Do not invent a framework merely to improve the answer.

### D. Premature-generalization test

Would adding an abstraction layer now:

- reduce future migration cost materially; or
- merely create speculative architecture for an economy not yet understood?

Prefer no new mechanism unless a current hard coupling is demonstrated.

### E. D1–D6 blast radius

Assess whether the Director's current working inclinations:

- stay local to v0 semantics;
- increase future coupling to current resource mechanics;
- or preserve general role/agency principles independent of the resource model.

Pay special attention to:

- D1 material priority with RepayDebt;
- D4 head self-commitment;
- D3 support recipient alias;
- D6 inert office while Household inactive.

## Required output

Create:

`research/technical/TRES-0011/TRES-0011B_RESOURCE_SEAM_REVERSIBILITY.md`

Use exactly one verdict:

- **LOW-COST REPLACEABLE**
- **REPLACEABLE WITH PREPARATORY GUARDRAILS**
- **ENTANGLED — REDESIGN BEFORE FURTHER RESOURCE DEPENDENCIES**

If recommending guardrails, limit them to the smallest changes necessary now and identify which can wait until actual redesign.

Include a concise "future redesign blast radius" table.

## Return discipline

Return branch:

`review/tres-0011b-resource-seam-reversibility-return`

Begin from:

`tres-0011-v0-resource-scaffold-wave-v1`

Add only the report.
