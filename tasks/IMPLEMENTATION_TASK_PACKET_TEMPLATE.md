# Implementation Task Packet — [Title]

**Task ID:** IMP-XXXX  
**Commissioned by:** Master Architect  
**Status:** OPEN / IN PROGRESS / BLOCKED / ESCALATED / VERIFIED COMPLETE  
**Context mode:** PROJECT-CONTEXT unless explicitly justified otherwise

## 1. Objective

[Concrete implementation outcome stated in observable terms.]

## 2. Required inputs by authority class

- **Accepted semantic / architectural authority:**
- **Verification / completion authority:** [if a separately owned frozen manifest/evaluator exists]
- **Required non-authoritative supporting / engineering context:**
- **Applicable invariants:**
- **Other canonical constraints:**

State precedence explicitly where more than one class is present: accepted semantic/architectural authority controls meaning; verification authority defines completion obligations but does not create semantics; supporting/engineering context cannot silently override either.

Implementation must retrieve and obey these artifacts rather than infer authority from conversation.

## 3. Scope

[Files/modules/behavior the task may change.]

## 4. Explicitly out of scope

[Adjacent behavior, architecture, refactors, dependencies, schemas, or abstractions the task must not change.]

## 5. Required invariants

[List invariants that must remain true.]

### Future seams / deferred gaps, if relevant

[List only accepted/high-cost seams the task must preserve without implementing later features, plus any explicitly deferred semantics the implementation must not invent. Omit this subsection when no such seam matters.]

## 6. Acceptance criteria

[Observable, testable completion conditions.]

If this task has a separately owned frozen acceptance/applicability manifest or equivalent completion authority:

- identify its version/ref/SHA;
- make every REQUIRED row explicit completion authority;
- keep DEFERRED / N-A / UNEXERCISED rows visibly classified;
- do not replace exact applicability with open-ended “relevant/applicable” self-selection.

## 7. Verification expectations

[Required tests, scenario checks, invariant checks, reproducibility checks, benchmarks, inspections, or other evidence appropriate to the task.]

The completion claim must be supported by verification evidence. Agent confidence or code review by the Project Director is not sufficient verification.

Acceptance tests, graders, invariants, and other completion checks must not be weakened or rewritten to make the task pass unless changing that verification surface is explicitly in scope.

When a frozen external acceptance/applicability authority exists, completion evidence should identify its version/ref/SHA, report every REQUIRED row separately, keep deliberate deferrals visible, and include any independent conformance review required by that authority.

## 8. Local decisions permitted

[Ordinary, reversible implementation choices the agent may make without escalation.]

Local test-framework/helper choices may not edit/reclassify a separately owned frozen acceptance authority or make an assertion-target production helper serve as its own independent oracle.

## 9. Escalation conditions

Stop and report rather than silently changing project architecture if implementation appears to require material changes to:

- core simulation semantics;
- entity identity or persistent representation;
- subsystem boundaries or ownership;
- major dependencies or frameworks;
- persistent schemas or compatibility;
- abstraction fidelity;
- global state or cross-system coupling;
- concurrency or execution model;
- accepted public interfaces;
- architectural invariants;
- significant performance strategy;
- any accepted requirement or higher-authority project principle.

Also escalate when the task cannot meet its acceptance criteria without altering an accepted assumption or when observed behavior materially contradicts the specification.

If a frozen acceptance/applicability authority exists, also escalate when a REQUIRED row cannot be translated without adding/choosing semantics, when its expected result appears unsupported by accepted authority, or when implementation would require changing/reclassifying that frozen authority.

## 10. Work-state discipline

Work in recoverable increments. Do not leave the project in an ambiguous half-migrated state if the task must stop. Record any incomplete transition explicitly.

If multiple agents mutate files concurrently, use isolated branches/worktrees/workspaces. Reconcile and verify before integration; do not coordinate concurrent edits through a shared working tree.

Any delegated child task must remain within the parent task's authority, scope, and permitted capabilities.

## 11. Required completion report

Return:

- terminal status: VERIFIED COMPLETE / BLOCKED / ESCALATED / INCOMPLETE;
- what changed;
- acceptance criteria met / unmet;
- verification performed and results;
- assumptions encountered;
- any architectural conflict or escalation;
- any deviation from the requested task;
- any new unresolved issue discovered;
- any follow-up work that is genuinely required rather than merely desirable;
- when applicable, frozen acceptance-authority version/ref/SHA, complete REQUIRED-row result summary, visible deferral summary, and independent conformance-review reference/result.
