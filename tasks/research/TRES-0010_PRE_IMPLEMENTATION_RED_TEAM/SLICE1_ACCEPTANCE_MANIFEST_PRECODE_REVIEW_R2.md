# Review Task Packet — TRES-0010 Slice-1 Acceptance Manifest Pre-Code Review R2

**Status:** OPEN / CORRECTED-CANDIDATE RERUN  
**Context mode:** INDEPENDENT PROJECT-CONTEXT REVIEW  
**Mutation permission:** return report only; do not edit canonical files  
**Frozen baseline ref:** `tres-0010-manifest-review-r2-baseline`  
**Assigned return branch:** `tres-0010/manifest-precode-review-r2`  
**Return path:** `research/technical/TRES-0010/returns/TRES-0010_SLICE1_MANIFEST_PRECODE_REVIEW_R2_REPORT.md`

## 1. Objective

Determine whether the corrected `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` is now a complete, semantically subordinate, implementation-ready acceptance/applicability authority for IMP-0001.

Return **PASS** only if a fresh implementation agent can use the manifest without:

- inventing Slice-1 semantics;
- self-selecting verification obligations away;
- implementing explicitly deferred subsystem semantics;
- mistaking verification examples for social-semantic authority;
- using production oracle logic to certify itself.

## 2. Required sources

Read from the frozen baseline:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted ADRs relevant to Slice 1;
- `plans/verification/SFL_V0/README.md`;
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`;
- `RESPONSE_DECISION_FAMILY.md`;
- `RESOLUTION_REACTION_FAMILY.md`;
- `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`;
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`;
- `REFERENCE_SCORING_PROFILES.md`;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`;
- `research/technical/TRES-0010/SEMANTIC_PROMOTION_RECONCILIATION.md`;
- `research/technical/TRES-0010/SEMANTIC_PROMOTION_LOSSLESS_AUDIT.md`;
- `research/technical/TRES-0010/CALLFAVOR_SLICE1_APPLICABILITY_RECONCILIATION.md`;
- corrected `SLICE1_ACCEPTANCE_MANIFEST.md`.

Do **not** read:
- the first BLOCK report;
- MRR-A/B/C returns;
- manifest-repair reconciliation/audit summaries;
- chat history.

Re-derive from accepted sources.

## 3. Required checks

### A. Complete applicability

Verify explicit status exists for:

- every 090–099 relevant subcase;
- 100–105 with 104 deferred;
- 070–076 with exact Slice-1/deferred treatment;
- 080–087;
- every cross-cutting boundary family/sub-boundary;
- every metamorphic relation;
- every semantic mutant/fault class;
- fixture, knowledge, fallback, iteration, oracle, manifest-integrity and conformance-review obligations.

No open “relevant/applicable” selector may remain completion-authoritative.

### B. Semantic subordination

Check every REQUIRED row and constraining deferred/N-A wording against SPEC.

Explicitly verify:

- RepayDebt reserve remains repayment-specific;
- household-provision reserve remains deferred;
- no generic interpersonal transfer reserve is implied;
- D4 ingress rows do not invent BFF/RMRH raw parameter schemas;
- BFF/RMRH schema-neutral grain-transfer instantiation is compatible with accepted semantics and canonical Slice-1 verification;
- invalid proposal terms remain pre-interaction rejection, not a fourth social failure outcome;
- Residence/favour/attitude repairs remain faithful to promoted semantics.

### C. Grain ingress completeness

Re-derive the D4 ingress set and test whether the corrected manifest prevents omission of:

- Gift offer;
- Gift/help request;
- Loan offer;
- Loan request;
- direct repayment;
- BFF grain-transfer instantiation;
- RMRH grain-transfer instantiation;
- direct-marriage proposed dowry term;
- CallFavor nested repayment.

Confirm that positive/invalid evidence can be structural when a public typed semantic boundary makes malformed quantity unrepresentable, without using production validation as its own oracle.

### D. Boundary repair regression

Specifically verify:

- provision-reconsideration timing boundary has explicit DEFERRED classification;
- lineage predecessor lifecycle-state boundary is named;
- household provision capacity/reserve and repayment reserve are no longer merged.

### E. Completeness mechanics / cheating

Attempt at least:

1. pass D4 with only one grain ingress;
2. impose 2-grain reserve on Gift/Loan;
3. omit provision-reconsideration boundary;
4. omit lineage predecessor-state boundary;
5. pass BFF/RMRH by assuming a raw scalar schema unsupported by SPEC;
6. skip a REQUIRED ID while CI stays green;
7. reuse production validator/classifier as independent oracle;
8. fake later-slice household semantics;
9. use low-level TransferGrain as semantic action;
10. alter manifest after dispatch.

## 4. Return

Return:

- `PASS` or `BLOCK`;
- baseline SHA and manifest blob SHA;
- manifest ID/status counts and duplicate check;
- any missing/misclassified rows;
- semantic-authority violations;
- grain-ingress verdict;
- boundary-regression verdict;
- oracle-independence verdict;
- cheat attempts/outcomes;
- exact required repairs if blocked;
- explicit statement whether manifest may now be frozen as IMP-0001 acceptance authority.

Do not propose unrelated architecture or social semantics.
