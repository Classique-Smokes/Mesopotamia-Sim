# Implementation Task Packet — [Title]

**Task ID:** IMP-XXXX  
**Commissioned by:** Master Architect  
**Status:** OPEN / IN PROGRESS / COMPLETE  
**Context mode:** PROJECT-CONTEXT unless explicitly justified otherwise

## 1. Objective

[Concrete implementation outcome stated in observable terms.]

## 2. Authoritative inputs

- **Accepted specification(s):**
- **Accepted decision(s) / ADR(s):**
- **Applicable invariants:**
- **Other canonical constraints:**

Implementation must retrieve and obey these artifacts rather than infer authority from conversation.

## 3. Scope

[Files/modules/behavior the task may change.]

## 4. Explicitly out of scope

[Adjacent behavior, architecture, refactors, dependencies, schemas, or abstractions the task must not change.]

## 5. Required invariants

[List invariants that must remain true.]

## 6. Acceptance criteria

[Observable, testable completion conditions.]

## 7. Verification expectations

[Required tests, scenario checks, invariant checks, reproducibility checks, benchmarks, inspections, or other evidence appropriate to the task.]

The completion claim must be supported by verification evidence. Agent confidence or code review by the Project Director is not sufficient verification.

## 8. Local decisions permitted

[Ordinary, reversible implementation choices the agent may make without escalation.]

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

## 10. Work-state discipline

Work in recoverable increments. Do not leave the project in an ambiguous half-migrated state if the task must stop. Record any incomplete transition explicitly.

## 11. Required completion report

Return:

- what changed;
- acceptance criteria met / unmet;
- verification performed and results;
- assumptions encountered;
- any architectural conflict or escalation;
- any deviation from the requested task;
- any new unresolved issue discovered;
- any follow-up work that is genuinely required rather than merely desirable.
