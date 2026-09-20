# ADR-0003 — Progressive Derived-State Specialization

**Status:** ACCEPTED  
**Decision Register:** DEC-0006  
**Authority:** Architectural  
**Accepted:** 2026-09-19  
**Approver:** Human Project Director

## Decision

The simulator begins with a **simple authoritative semantic kernel**. Derived values are maintained using the least complex mechanism that is sufficient for their actual workload.

Different subsystems may simultaneously use different strategies, including:

- direct recomputation;
- direct delta maintenance;
- cached/dirty recomputation;
- explicit dependency tracking;
- stronger incremental relational/dataflow machinery when justified.

Derived-state access must remain behind stable semantic/query boundaries so a subsystem can change maintenance strategy without changing what the derived value means.

A subsystem moves to stronger dependency machinery only when measured update/query patterns, fan-out, nesting, memory cost, or correctness risk justify it.

## Consequences

- Systematic incremental machinery is not universal infrastructure from day one.
- Later B-style dependency management remains an intentional migration path, not a rewrite contingency.
- Reference recomputation should remain available where practical for correctness checks.
- Organizational size alone does not determine maintenance strategy; workload shape does.

## Not decided

No dependency framework, incremental engine, cache policy, threshold, benchmark target, language/runtime, or concrete household-derived value is selected.
