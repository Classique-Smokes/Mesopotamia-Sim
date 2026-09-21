# Research Task Packet — Verification-System Cheat Red Team

**Task ID:** TRES-0010D  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT  
**Return:** `research/technical/TRES-0010/returns/TRES-0010D_VERIFICATION_CHEAT_REPORT.md`

## 1. Question

How could a defective or semantically wrong implementation still pass the completed Stage-3 verification design?

## 2. Why it matters now

The verification package is about to become executable acceptance authority. It must be difficult for an implementation agent to satisfy by coding to fixtures or reusing production logic as the oracle.

## 3. Objective / success condition

Act like a hostile implementer trying to pass while violating the spec.

Attack:

- oracle reuse/circularity;
- fixtures that write endogenous outcomes;
- test helpers that share production transition logic;
- hard-coded scenario IDs/actors;
- canonical-card overfitting;
- weak negative controls;
- fake held-outs;
- mutants that crash rather than detect semantics;
- untested boundary combinations;
- ID-sensitive expected results;
- instrumentation changing behavior;
- tests asserting final snapshots but not causal history;
- profile configuration that bypasses candidate gates;
- checkpoint/rebuild tests that compare the same faulty serializer/rebuilder to itself.

## 4. Required context

Read:

- full `plans/verification/SFL_V0/`;
- `SPEC-SFL-0001` only as the semantic oracle;
- IMP-0001 acceptance criteria.

Do not propose social-model changes unless a verification gap exposes actual semantic ambiguity.

## 5. Evidence standards

For each serious finding, describe a concrete defective implementation that could pass the current stated tests.

## 6. Boundaries

Do not write tests/code. Do not optimize test-framework choice. Do not weaken scenario semantics.

## 7. Required output

Include:

- exploitable verification holes;
- already-robust areas;
- minimum additional assertion/independence guard needed for each real gap;
- common-schema severity.

## 8. Authority reminder

Advisory only.
