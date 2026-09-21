# Research Task Packet — Slice-1 Boundary Completeness Audit

**Task ID:** TRES-0010-MRR-A  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / independent verification audit  
**Return:** `research/technical/TRES-0010/returns/TRES-0010_MRR_A_BOUNDARY_COMPLETENESS_REPORT.md`

## 1. Question

Does the candidate Slice-1 acceptance manifest give every canonical cross-cutting boundary family an explicit and correct Slice-1 status, or are any boundary obligations missing, merged too broadly, or misclassified?

## 2. Why this matters

The manifest must eliminate implementation-agent self-selection. A boundary that exists in canonical verification but has no frozen Slice-1 status can disappear from implementation evidence even if every manifest row that does exist passes.

This task is **not** limited to any known suspected boundary. Re-derive the complete boundary inventory from source.

## 3. Required sources

Read from the frozen baseline:

- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`;
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`;
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- canonical SFL v0 family files only where needed to determine whether a boundary's substrate is in Slice 1 or deferred.

Do **not** read:
- the prior manifest pre-code BLOCK report;
- sibling MRR returns;
- proposed fixes outside the frozen candidate.

## 4. Method

### Pass 1 — independent source inventory

From `CROSS_CUTTING_VERIFICATION_CONTRACT.md`, enumerate every boundary group and each materially distinct sub-boundary.

Do not begin by reading manifest rows and working backward.

### Pass 2 — scope classification

For each source boundary, classify its Slice-1 status from SPEC + IMP scope:

- REQUIRED;
- DEFERRED;
- N-A;
- or, only if justified by canonical verification policy, UNEXERCISED.

State the exact substrate/scope reason.

### Pass 3 — manifest reconciliation

Map every source boundary to one or more manifest AcceptanceIds.

Classify the manifest treatment as:

- EXACT;
- PRESENT_BUT_TOO_BROAD;
- PRESENT_BUT_TOO_NARROW;
- PRESENT_BUT_WRONG_STATUS;
- MISSING;
- DUPLICATED/CONFLICTING.

### Pass 4 — anti-whack-a-mole check

Look for source boundary families that were collapsed into one vague manifest row even though their Slice-1 statuses differ.

Also inspect whether one row's wording could make an implementation infer a boundary outside the actual source scope.

## 5. Required output

Return:

1. complete boundary inventory table;
2. source clause/path for every boundary;
3. independently derived Slice-1 status;
4. current manifest mapping;
5. defects, if any, with severity;
6. minimal wording/status repair for each defect;
7. explicit statement whether **any boundary defect exists beyond the currently obvious ones**, without reading the prior blocker;
8. a final verdict:
   - `BOUNDARY_SURFACE_CLOSED`, or
   - `BOUNDARY_REPAIR_REQUIRED`.

Do not propose new social semantics or edit the manifest.

## 6. Disconfirmation requirement

Try to prove that every source boundary is already represented correctly. A missing row is a finding only if you can show the source boundary is materially distinct and not already covered by another row with the same status and scope.

## 7. Escalation

If correct Slice-1 status depends on a semantic choice not present in accepted SPEC, report `SEMANTIC_ESCALATION_REQUIRED` for that row and stop short of choosing semantics.
