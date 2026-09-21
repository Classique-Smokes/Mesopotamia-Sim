# Research Task Packet — Slice-1 Grain-Ingress Exhaustiveness Audit

**Task ID:** TRES-0010-MRR-C  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / independent semantic-ingress audit  
**Return:** `research/technical/TRES-0010/returns/TRES-0010_MRR_C_GRAIN_INGRESS_REPORT.md`

## 1. Question

Exactly which current Slice-1 semantic action/proposal ingress routes contain a grain-denominated parameter that must obey the accepted D4 positive-integer validation rule, and what evidence is required so no ingress can escape validation?

## 2. Why this matters

The accepted SPEC says every action parameter denominated in grain is a strictly positive integer and invalid terms are rejected before counterparty response.

A generic numeric-boundary test is insufficient if multiple action schemas/constructors/validation paths can independently accept malformed terms.

This task must determine the **actual source-grounded ingress set**, not inherit anyone else's list.

## 3. Required sources

Read from the frozen baseline:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`;
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`;
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`;
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`;
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`;
- `research/technical/TRES-0010/CALLFAVOR_SLICE1_APPLICABILITY_RECONCILIATION.md`.

Do **not** read:
- the prior manifest pre-code BLOCK report;
- sibling MRR returns.

## 4. Method

### Pass 1 — semantic action inventory

List every action/proposal meaning that IMP-0001 must support.

For each, determine from accepted SPEC whether it contains:

- a grain-denominated term;
- a grain effect with no actor-supplied grain parameter;
- no grain term.

Do not infer a parameter merely because verification examples use 1 grain.

### Pass 2 — ingress classification

For every grain-denominated term, identify every distinct semantic ingress shape that could reach validation.

Classify each as:

- REQUIRED executable Slice-1 ingress;
- REQUIRED syntax/term validation but later semantic effect deferred;
- DEFERRED entirely;
- N-A.

Pay special attention to:

- Offer vs Request variants;
- RepayDebt;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help;
- direct-marriage proposal and its proposed dowry term;
- CallFavor carrying a callable action with an inner grain term.

### Pass 3 — dowry/direct-bypass question

Independently determine whether a malformed proposed dowry on a direct mutual-strong-like marriage proposal must be rejected under the global grain-term validity rule even though the bypass performs no dowry transfer.

State the exact source reasoning.

Do **not** implement or require household-mediated marriage to test a term-validity rule unless accepted authority actually requires that substrate.

### Pass 4 — evidence design

For each required ingress, specify the minimum evidence that proves:

- zero rejected;
- negative rejected;
- representative non-integral rejected, or structurally unrepresentable at the typed boundary;
- valid positive integer continues to ordinary action-specific gates;
- invalid term is rejected before target response/social failed-attempt semantics.

Determine whether one table-driven test can cover multiple ingress routes without allowing a route to be silently omitted.

## 5. Required output

Return:

1. exhaustive action/proposal inventory;
2. grain-parameter matrix with source citations;
3. exact required ingress set;
4. explicit verdict on proposed-dowry validation in the direct bypass route;
5. exact treatment of `CallFavor(RepayDebt(...))`;
6. any ingress that appears in current manifest but is not actually source-supported;
7. any source-supported ingress current manifest fails to freeze;
8. recommended manifest row structure (single row with frozen per-ingress matrix vs separate stable IDs), with rationale;
9. final verdict:
   - `GRAIN_INGRESS_SURFACE_CLOSED`, or
   - `GRAIN_INGRESS_REPAIR_REQUIRED`.

## 6. Anti-overreach rule

Do not:

- invent a generic transfer reserve;
- require household-mediated marriage implementation merely to validate a proposal term;
- assume BFF/RMRH has a grain parameter unless accepted semantics or the actual Slice-1 action schema requires one;
- turn invalid terms into Declined/Unable/Invalidated;
- use production validation code as the independent oracle.

## 7. Escalation

If accepted sources do not uniquely establish whether an action meaning is grain-denominated, report that ambiguity explicitly. Do not resolve it by assuming the verification example's amount shape is permanent semantics.
