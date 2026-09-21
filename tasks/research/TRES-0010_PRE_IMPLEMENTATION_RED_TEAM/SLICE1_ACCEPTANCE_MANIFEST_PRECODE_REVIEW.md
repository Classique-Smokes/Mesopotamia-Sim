# Review Task Packet — TRES-0010 Slice-1 Acceptance Manifest Pre-Code Review

**Status:** OPEN / RUN ONLY AFTER MANIFEST CANDIDATE IS COMMITTED  
**Context mode:** INDEPENDENT PROJECT-CONTEXT REVIEW  
**Mutation permission:** return report only; do not edit canonical files

## 1. Objective

Determine whether the proposed `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` is a complete, semantically subordinate, implementation-ready acceptance/applicability authority for IMP-0001.

Return **PASS** only if a fresh implementation agent can use the manifest without:

- inventing Slice-1 semantics;
- self-selecting difficult verification obligations away;
- implementing out-of-scope household/communication/checkpoint behavior;
- mistaking verification text for social-semantic authority;
- using production oracle logic to certify itself.

## 2. Required sources

Read from one frozen review baseline:

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
- proposed `SLICE1_ACCEPTANCE_MANIFEST.md`.

Do not use chat history as authority.

## 3. Review checks

### A. Semantic subordination

For every manifest row that implies an expected behavior:

- identify its accepted SPEC/ADR source;
- fail review if the manifest invents, broadens, or changes social semantics;
- fail review if verification prose is used to resolve an ambiguity not already closed in SPEC.

### B. Complete applicability

Prove explicit status exists for:

- every VS-SFL-090..099 subcase relevant to Slice 1;
- VS-SFL-100..105 with VS-SFL-104 explicitly deferred;
- VS-SFL-070..076 with exact lower-level/deferred treatment;
- VS-SFL-080..087 with exact checkpoint/explanation deferrals;
- every cross-cutting boundary group;
- every cross-cutting metamorphic relation including TRES-0010 additions;
- every semantic mutant/fault class including TRES-0010 additions;
- fixture write-set, participant knowledge, fallback, iteration-order, oracle-independence, manifest-integrity, and conformance-review obligations.

No row may rely on words such as “relevant” or “applicable” without a frozen classification.

### C. Scope discipline

Fail if REQUIRED rows force:

- household formation/identity/participation/head/provision/lineage;
- mediated marriage;
- general communication/recognition propagation;
- checkpoint/save-load;
- rendered explanation infrastructure;
- hidden-test service;
- generalized mutation/generated-history/shrinking framework;
- a generalized effect/action system.

### D. CallFavor applicability

Re-derive every current Slice-1 action shape from SPEC, independently of production code.

Confirm or refute the candidate table's conclusion that current callable shapes are exactly:

- Farm;
- RepayDebt(debt, amount).

For any disagreement, identify the exact accepted clause that changes the classification. Do not create an exception by policy preference.

### E. Oracle independence

Check that each independent-oracle class has an accepted non-production basis and that the manifest forbids the production helper whose output is under judgment.

Particularly inspect:

- scorer/selector;
- candidate/callability gates;
- transition helper;
- capacity arithmetic;
- stable-ID fallback evidence.

### F. Completeness mechanics

Check:

- every AcceptanceId unique;
- REQUIRED rows cannot be skipped/missing and still claim completion;
- DEFERRED/N-A/UNEXERCISED remain separately visible;
- stable source/freeze metadata exists;
- implementation task cannot edit/reclassify manifest;
- post-implementation conformance review is required.

## 4. Adversarial attacks

Attempt at least these cheats:

1. one test with a canonical card name but only one easy subcase;
2. mark hard cross-cutting rows N-A without changing the manifest;
3. call production `IsCallable` from the CallFavor oracle;
4. use a low-level `TransferGrain` helper as a callable semantic action;
5. fake VS-SFL-104 with household stubs;
6. make generated/held-out infrastructure mandatory despite explicit deferral;
7. let a REQUIRED row be skipped while CI stays green;
8. change the manifest after dispatch to fit implementation;
9. make `InvalidProposal` a fourth social failed-attempt outcome;
10. let verification prose override SPEC for explicit benefit-for-favour.

## 5. Return format

Return:

- `PASS` or `BLOCK`;
- baseline SHA and manifest SHA;
- count of manifest AcceptanceIds/statuses;
- missing/duplicate/misclassified rows;
- semantic-authority violations;
- CallFavor table verdict;
- scope-creep findings;
- oracle-independence findings;
- cheat attempts and outcomes;
- exact required repairs if blocked;
- explicit statement whether IMP-0001 may proceed to task hardening after review.

Do not propose unrelated architecture or social semantics.
