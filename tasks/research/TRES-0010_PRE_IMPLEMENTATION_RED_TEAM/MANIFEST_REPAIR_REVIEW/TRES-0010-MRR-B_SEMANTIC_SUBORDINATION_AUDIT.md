# Research Task Packet — Manifest Semantic-Subordination / Wording-Scope Audit

**Task ID:** TRES-0010-MRR-B  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / independent semantic-subordination audit  
**Return:** `research/technical/TRES-0010/returns/TRES-0010_MRR_B_SEMANTIC_SUBORDINATION_REPORT.md`

## 1. Question

Does any wording in the candidate Slice-1 acceptance manifest broaden, narrow, merge, or invent simulation/social semantics relative to accepted `SPEC-SFL-0001`?

## 2. Why this matters

The manifest is implementation-facing. Even with a global “SPEC wins” disclaimer, an overbroad row can teach a coding agent a rule that the accepted model never adopted.

The review must therefore check **manifest wording itself**, not merely whether an expert could reconcile it correctly.

## 3. Required sources

Read from the frozen baseline:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted ADRs only where the manifest invokes an architectural invariant;
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`;
- canonical SFL verification family/cross-cutting files as supporting verification context;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` only for Slice-1 scope.

Do **not** read:
- the prior manifest pre-code BLOCK report;
- sibling MRR returns.

## 4. Method

### Pass 1 — semantic vocabulary scan

Independently identify terms in the manifest that are especially capable of semantic overreach, including but not limited to:

- reserve;
- capacity;
- validity / feasibility;
- response / acceptance;
- membership / participation;
- authority;
- favour creation/capacity;
- material transfer;
- NeedsGrain;
- conflict/priority;
- knowledge / participant knowledge;
- stable-ID fallback;
- action meaning vs implementation helper.

This list is a search aid, not a presumption that any term is defective.

### Pass 2 — row-by-row source check

For every REQUIRED manifest row, and every DEFERRED/N-A row whose wording could constrain implementation, determine:

- exact accepted semantic source;
- whether manifest wording is equivalent in scope;
- whether it is broader;
- whether it is narrower;
- whether it merges two distinct mechanics;
- whether it accidentally creates a new negative control or precondition.

### Pass 3 — subsystem-confusion scan

Look specifically for wording that conflates:

- debt repayment reserve with household provision reserve;
- generic transfer feasibility with repayment-specific rules;
- explicit benefit-for-favour with gift/help;
- relationship-mediated reciprocal help with explicit bargain;
- called-favour invalid payload with social failed attempts;
- residence conflict with actor preference;
- verification convenience with domain semantics.

Also scan for **other** conflations not named above.

## 5. Required output

Return a table of every suspect row with:

- AcceptanceId;
- manifest wording;
- accepted source clause;
- verdict:
  - EXACT;
  - BROADER_THAN_SPEC;
  - NARROWER_THAN_SPEC;
  - MERGES_DISTINCT_SEMANTICS;
  - AMBIGUOUS_IMPLEMENTATION_GUIDANCE;
- consequence if implemented literally;
- minimal source-faithful wording repair.

Then state:

- whether any manifest wording would currently teach a fresh implementer semantics that the SPEC does not contain;
- whether the defect set is limited to wording/manifest repair or requires SPEC/Director action;
- final verdict:
  - `SEMANTIC_SUBORDINATION_CLEAN`, or
  - `MANIFEST_WORDING_REPAIR_REQUIRED`.

## 6. Negative authority rule

Verification artifacts may not be used to override or expand SPEC. If verification wording is broader than SPEC, identify it as a verification-quality issue rather than silently importing it into the manifest.

## 7. Escalation

If two accepted semantic clauses genuinely conflict, report the conflict instead of resolving it.
