# Architecture Development Policy

**Status:** PROPOSED  
**Authority:** Architecture-governance policy; subordinate to the Project Seed, Working Constitution, Master Architect Guide, and accepted architectural decisions  
**Decision:** DEC-0005

## Purpose

Govern how software architecture is selected and evolved so the project can pursue ambitious simulation fidelity without committing prematurely to complexity that has not earned its cost.

This policy does not select a language, framework, scheduler, database, persistence model, concurrency model, cognitive framework, or optimization technology.

## 1. Preserve semantic truth before optimizing its representation

Architecture must keep the accepted simulation meaning explicit.

Performance structures—indexes, caches, materialized views, graph projections, batched layouts, compiled kernels, parallel workers, analytical stores—should normally derive from or operate behind stable semantic boundaries rather than become accidental authorities over the model.

A performance optimization may change representation. It must not silently change simulation semantics.

## 2. Start with the simplest architecture that can test the accepted model

The first implementation of a mechanism should prefer clarity, deterministic inspection, and bounded operational complexity over speculative maximum scale.

Do not build production-scale distributed, GPU, recursive-dataflow, or similarly specialized infrastructure merely because future scale might eventually benefit from it.

A more sophisticated mechanism may be selected early when evidence shows that a simpler one would create a costly dead end. The burden is evidence, not novelty.

## 3. Optimize measured work, not nominal population

Architecture decisions should be driven by the shape of actual work, including as relevant:

- activation density;
- candidate-set size/selectivity;
- relationship degree and churn;
- dependency fan-out;
- conflict density;
- batchability/locality;
- history/provenance volume;
- checkpoint/restore cost;
- memory per entity/relation/index.

“Hundreds of thousands of agents” is not itself a sufficient performance requirement.

## 4. Use progressive specialization

Default evolution is left-to-right:

**clear reference behavior → indexes/locality → active sets/batching → selective incremental maintenance → compiled/parallel hot paths → GPU/distributed execution when measured need justifies it**

This is a default progression, not a mandatory sequence. Evidence may justify skipping a step.

Each specialization should solve an observed problem while preserving an escape path back to the accepted semantics.

## 5. Maintain a trustworthy reference path where practical

For consequential optimized mechanisms, preserve a small, deterministic, inspectable implementation or reference recomputation that can act as a semantic oracle where practical.

Optimized paths should be checked against the reference path using bounded scenarios, invariants, state/event comparisons, or other appropriate equivalence tests.

The reference path may be too slow for production-scale runs; its purpose is semantic verification.

## 6. Derived performance state should be rebuildable unless explicitly promoted

Indexes, caches, materialized views, dependency graphs, graph projections, summaries, and similar accelerators should normally be reconstructible from authoritative semantic state.

If a derived structure must become persistent autonomous state, that is an architectural decision and must be made explicitly.

Do not let cached state become hidden authority through convenience.

## 7. Compose mechanisms by concern; avoid architecture-by-collection

Different problems may justify different techniques. No technology earns project-wide adoption merely because it solves one problem elegantly.

Do not build a kitchen-sink architecture by combining every credible technique discovered by research.

For each added mechanism ask:

- What specific measured or semantic problem does it solve?
- What new state, coupling, failure modes, and maintenance burden does it introduce?
- Can a simpler mechanism meet the present requirement?
- Can it be replaced later without changing domain meaning?

## 8. Determinism, observability, and recovery are design constraints

Concurrency and optimization must preserve an explicit reproducibility contract appropriate to the project phase.

Consequential transitions must remain inspectable enough to explain accepted simulation behavior.

Continuation saves must preserve future-influencing simulation state, not merely visible entity fields.

Operational telemetry, debug traces, semantic history, causal provenance, and analytical archives are different concerns and may use different retention policies.

## 9. Parallelism and distribution follow evidence

Single-process execution is a valid architectural advantage while it remains sufficient.

Introduce multithreading, GPU execution, process distribution, optimistic rollback, or other concurrency machinery only when profiling demonstrates a problem they can plausibly solve and the semantic/reproducibility cost is understood.

Logical decentralization in the simulated society does not require distributed software architecture.

## 10. Architecture must fit the project operating conditions

A theoretically powerful design is a poor project choice if it requires operational expertise, debugging discipline, tooling maturity, or maintenance capacity disproportionate to this AI-assisted, non-specialist-directed project.

Candidate architectures must be evaluated for:

- semantic fidelity;
- inspectability and verification;
- implementation complexity;
- AI-assisted maintainability;
- ecosystem/tool maturity;
- migration/versioning burden;
- scaling trajectory;
- reversibility;
- failure recovery;
- performance under representative workloads.

Raw throughput alone does not determine suitability.

## 11. Generic benchmarks do not decide project architecture

Use external benchmarks to understand mechanisms and likely tradeoffs.

Architecture selection should rely on project-specific or workload-representative evidence when performance materially affects the choice.

When benchmarking alternatives, preserve workload shape, hardware/environment, memory cost, tail behavior, and semantic verification—not only average throughput.

## 12. Technical research discovers; architecture decides

Open technical research should receive the accepted semantic problem and genuine constraints without being anchored to unaccepted preferred technologies.

Research returns remain advisory.

The Master Architect reconciles them into a small number of coherent whole-system candidates. Consequential architecture is selected only after comparison, targeted validation where needed, and explicit human approval.

## Architecture decision test

Before recommending a consequential architecture, the Master Architect should be able to explain:

1. what state is authoritative;
2. where authoritative transitions occur;
3. how time/pending processes are represented;
4. how derived state is kept consistent;
5. how history/recovery/reproducibility work;
6. how the design scales from the reference implementation;
7. which complexity is being accepted now and why;
8. which future optimization paths remain open;
9. how correctness will be verified;
10. what evidence would cause the decision to be revisited.

## Not decided by this policy

The policy does not decide the current TRES-0002 candidate architecture, implementation language/runtime, exact performance targets, prototype social rules, or final production-scale strategy.
