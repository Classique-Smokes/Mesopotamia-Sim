# Research Task Packet — B2 Slice-1 Acceptance Authority Design

**Task ID:** TRES-0010B2-ASR  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / technical assurance design  
**Return:** `research/technical/TRES-0010/returns/TRES-0010B2-ASR_SLICE1_ACCEPTANCE_AUTHORITY_DESIGN_REPORT.md`

## 1. Question

What is the **smallest effective** pre-code acceptance-authority mechanism that closes:

- S1-ASR-01 — the implementation task would otherwise author the first executable acceptance translation;
- S1-ASR-02 — Slice-1 verification applicability/completeness is not frozen;
- related task-scope contradictions such as VS-SFL-104 being outside Slice 1?

## 2. Why it matters now

The project wants independent-enough verification without building a general grader/eval platform before the first kernel.

Wave B explicitly rejects excessive infrastructure.

## 3. Required context

Read:

- `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`;
- Stage-3 verification README;
- CROSS_CUTTING verification contract;
- lower-level, response, resolution/reaction, determinism/explainability families;
- reference scoring profiles;
- IMP-0001;
- SCF-002;
- implementation task template;
- Wave-B implementation assurance prosecution/defense;
- D-sentinel report.

You may use current external software/AI-evaluation sources if they materially help, but distinguish them from project authority.

Do not read sibling B2 returns.

## 4. Design constraints

The solution must:

- leave social semantics in SPEC, not in the evaluator;
- prevent the implementation agent from being the sole author/editor of the acceptance authority that certifies its work;
- freeze exact Slice-1 applicability before coding;
- make missing/skipped required items visible;
- preserve independent-oracle rules;
- allow implementation agent to choose ordinary test framework/helper structure;
- not require secret tests;
- not require a general mutation-testing platform;
- not require generated-history/shrinking infrastructure for Slice-1 completion;
- not require organization-scale repository administration;
- remain easy for future AI agents to retrieve and obey.

## 5. Compare candidate mechanisms

At minimum compare:

1. frozen machine-readable or Markdown acceptance manifest + independent pre-code review;
2. separate protected acceptance project/files authored before implementation;
3. post-implementation independent verification agent comparing executable tests against frozen manifest/prose;
4. combinations of the above that remain minimal.

Evaluate:

- independence strength;
- authoring burden;
- CI integration;
- mutation/oracle auditability;
- ease of cheating/under-translation;
- maintenance cost;
- suitability for future slices;
- repository/tooling complexity.

Do not assume maximum protection is optimal.

## 6. Required Slice-1 applicability output

Produce a concrete proposed manifest/table covering at minimum:

- VS-SFL-090–099;
- VS-SFL-100–105 with explicit treatment of VS-SFL-104;
- relevant 070/071/073/074 subcases;
- relevant determinism/explainability cases;
- cross-cutting metamorphic relations;
- semantic mutant ledger items as REQUIRED / DEFERRED / N-A / UNEXERCISED with rationale;
- fixture write-set audit;
- observer noninterference;
- stable-ID fallback sensitivity;
- iteration-order permutation;
- direct-participant knowledge assertions where required by accepted semantics.

The manifest should define completion evidence, not re-specify social behavior.

## 7. Oracle independence

Specify the minimum practical way to make the existing oracle-independence rule auditable.

Possible tools may include:

- project dependency boundaries;
- static reference checks;
- reviewer checklist;
- generated report of dependencies;
- separate evaluator ownership.

Do not require a new architectural layer unless justified.

## 8. Required output

Return:

1. recommended mechanism;
2. rejected overengineered alternatives;
3. proposed manifest schema;
4. populated Slice-1 applicability table;
5. ownership/editability rules;
6. CI/completion flow;
7. oracle-independence audit method;
8. exact IMP-0001 changes needed;
9. exact implementation-template changes worth carrying forward;
10. residual risk.

Do not implement the mechanism yet and do not edit canonical files.