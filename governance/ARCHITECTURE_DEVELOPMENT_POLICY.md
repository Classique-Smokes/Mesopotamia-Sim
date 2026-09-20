# Architecture Development Policy

**Status:** ACCEPTED  
**Authority:** Architecture-governance policy  
**Decision:** DEC-0005

## Purpose

Keep future software architecture faithful to accepted simulation semantics while avoiding complexity that has not earned its cost.

## Governing rules

### 1. Semantic authority comes first

Accepted simulation meaning must remain explicit and authoritative.

Indexes, caches, materialized views, graph projections, optimized layouts, compiled kernels, parallel workers, and analytical stores may accelerate the model but must not silently redefine it.

### 2. Start with the simplest sufficient implementation

Prefer clarity, deterministic inspection, and bounded operational complexity for the first working form of a mechanism.

Adopt more sophisticated machinery early only when evidence shows that a simpler design would create a material dead end or unacceptable cost.

### 3. Optimize measured work

Performance decisions must respond to representative workload properties such as activation density, candidate-set size, relation churn, dependency fan-out, conflict density, locality/batchability, history volume, checkpoint cost, and memory footprint.

Nominal population size alone is not a sufficient basis for architecture.

### 4. Specialize progressively and locally

Default progression:

**clear reference behavior → indexes/locality → active sets/batching → selective incremental maintenance → compiled/parallel hot paths → GPU/distributed execution when justified**

This progression applies **per subsystem or workload**, not uniformly to the whole simulator. Different derived values may legitimately use different maintenance strategies at the same time.

Promote a mechanism only when measured complexity or workload justifies the added machinery. Evidence may justify skipping steps.

### 5. Preserve a reference path where practical

Consequential optimized mechanisms should retain a small deterministic reference implementation or recomputation where practical.

Optimized paths should be checked against it with scenarios, invariants, state/event comparisons, or equivalent verification.

### 6. Keep performance state rebuildable by default

Indexes, caches, dependency graphs, projections, summaries, and similar accelerators should normally be reconstructible from authoritative semantic state.

Derived-state implementations should sit behind stable semantic/query boundaries so a subsystem can move from recomputation to caching, dependency tracking, or stronger incremental maintenance without changing domain meaning.

Making derived state independently authoritative requires an explicit architectural decision.

### 7. Add mechanisms by problem, not by fashion

No framework or technique earns project-wide adoption because it solves one problem elegantly.

Every added mechanism must justify:
- the specific problem it solves;
- the new state/coupling/failure modes it introduces;
- why a simpler mechanism is insufficient now;
- how it can be replaced or evolved without changing domain meaning.

### 8. Concurrency and distribution follow evidence

Single-process execution is preferred while sufficient.

Multithreading, GPU execution, process distribution, rollback-based simulation, or comparable complexity require measured need and an understood determinism/observability cost.

Simulation decentralization does not imply distributed software architecture.

### 9. Architecture must fit the project

Evaluate candidates on:
- semantic fidelity;
- inspectability and verification;
- implementation/operational complexity;
- AI-assisted maintainability;
- ecosystem maturity;
- migration/versioning burden;
- scaling trajectory;
- reversibility and recovery;
- representative performance.

Raw throughput alone does not determine suitability.

### 10. Project-specific evidence decides

External research and benchmarks establish possibilities and likely tradeoffs.

Consequential performance or stack choices should rely on project-specific or workload-representative evidence when that evidence can materially change the decision.

### 11. Accepted architecture artifacts constrain; working artifacts explain

Working proposals and research may contain alternatives, rationale, examples, and exploration.

Accepted architecture records should contain only:
- the decision;
- binding invariants/consequences;
- essential rationale needed to preserve intent;
- explicit exclusions or unresolved points;
- references to supporting evidence when useful.

Do not carry debate history, illustrative examples, speculative future possibilities, implementation trivia, or duplicated context into accepted architecture. If supporting explanation is still useful, keep it in working/research material and link to it rather than bloating authority.

## Decision gate

Before recommending a consequential implementation architecture, the Master Architect must be able to explain:

1. authoritative state and transition boundary;
2. time/pending-process model;
3. derived-state consistency strategy;
4. history, recovery, and reproducibility contract;
5. scaling path and accepted complexity;
6. verification strategy and evidence that would trigger reconsideration.

## Not decided here

This policy does not select the implementation architecture, language/runtime, scheduler, database, persistence mechanism, cognitive framework, concurrency model, or production-scale strategy.
