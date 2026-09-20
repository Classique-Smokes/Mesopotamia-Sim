# TRES-0002 — Whole-System Candidate Architectures

**Status:** WORKING / NON-AUTHORITATIVE  
**Stage:** TRES-0002 Stage II

The candidates share the accepted semantic architecture. They differ only where Stage-I evidence identified a consequential implementation fork.

## Shared semantic spine

Both candidates use:

- authoritative indexed in-memory typed records with stable IDs and explicit references;
- agents/roles producing attempts or proposals rather than arbitrary cross-entity mutation;
- one controlled validation/resolution/commit boundary for authoritative state change;
- explicit serializable pending processes and deterministic simulated-time ordering;
- sparse activation / active sets rather than mandatory population-wide cognitive polling;
- layered individual cognition: subjective knowledge, soft concern gates, local candidate generation, local scoring, persistent goals, optional bounded planning;
- persistent household/organizational records distinct from constituents;
- current state as execution authority;
- semantic history emitted from committed transitions;
- explicit continuation checkpoints and run/reproducibility metadata;
- a simple deterministic reference execution path before parallel/distributed optimization.

Event sourcing, GPU execution, distributed simulation, actor-per-entity runtimes, and heavyweight universal cognition frameworks are not foundational requirements in either candidate.

---

## Candidate A — Conservative Semantic Kernel

### Core idea

Keep derived social/collective computation simple until profiling proves that stronger incremental machinery is necessary.

### Derived-state strategy

Use, in increasing order of need:

1. direct recomputation for cheap/local values;
2. explicit local deltas for simple aggregates;
3. ordinary indexes and dirty/active sets;
4. small dependency-tracked caches only for measured expensive values.

No general incremental relational/dataflow/rule engine is part of the initial architecture.

### Strengths

- smallest conceptual and operational surface;
- easiest causal inspection and AI-assisted maintenance;
- fewer hidden auxiliary structures;
- fastest path to a trustworthy reference implementation;
- preserves later migration to stronger incremental machinery behind domain/query boundaries.

### Main risks

- hand-maintained invalidation/delta logic may spread as households and institutions become richer;
- repeated joins/traversals may become expensive;
- bespoke indexes/caches can accumulate into an implicit incremental system without one coherent model;
- later migration becomes costly if domain code depends directly on cache/storage details.

### Best fit if

Derived collective values are relatively local/cheap, dependency fan-out is modest, and the first prototype can expose workload shape before systematic incremental maintenance is justified.

---

## Candidate B — Incremental Relational Kernel

### Core idea

Keep the same authoritative semantic state and commit boundary, but adopt a first-class derivation subsystem early for changing relationship/knowledge/collective facts.

### Derived-state strategy

Represent query-shaped facts and dependencies in a systematic incremental layer capable of maintaining selected:

- household/organizational capacities;
- candidate/action indexes;
- subjective-knowledge/recognition views;
- role/support relationships;
- nested collective derivations where later justified.

The exact technology is not yet selected. Possible implementation families include dependency-tracked computation, incremental view maintenance, Datalog/rule materialization, or differential/dataflow techniques.

Canonical entity/relation/process state remains distinct from the incremental accelerator.

### Strengths

- directly addresses the project's nested changing-organizations problem;
- reduces scattered cache invalidation logic;
- provides an explicit home for dependency tracking and derived-state support;
- may scale much better when derived views are repeatedly queried and updates are sparse/local;
- can support richer provenance of derived collective facts.

### Main risks

- higher conceptual and memory cost from the beginning;
- difficult invalidation/recursive cases can become architecture-wide concerns;
- incremental machinery may be slower than recomputation under dense updates or high fan-out;
- specialist tooling/mental models may be disproportionate to the project;
- temptation to encode agent cognition and social semantics as opaque rules/dataflows.

### Best fit if

Representative workloads show frequent reads of nontrivial derived social state, localized updates, manageable dependency fan-out, and substantial repeated recomputation under Candidate A.

---

## What is not a separate whole-system candidate

Stage-I evidence does not justify treating these as rival full architectures:

- **process/DES scheduling:** usable inside A or B;
- **data-oriented/ECS layouts:** possible physical optimization inside A or B;
- **event sourcing:** may be selectively adopted for bounded domains/history, not required globally;
- **BDI/HTN/GOAP:** cognition/planning mechanisms behind accepted agency boundaries;
- **graph engines:** optional relation/index acceleration;
- **GPU/parallel/distributed execution:** later hot-path/scaling strategies.

## Discriminating questions

Only evidence capable of changing A vs B should block selection:

1. **Derived-state break-even** — How expensive are recomputation/manual deltas versus dependency/incremental maintenance under expected update/query ratios?
2. **Fan-out and nesting** — Do local relation changes usually affect a small bounded neighborhood, or frequently invalidate broad collective state?
3. **Memory cost** — How much auxiliary dependency/index state does systematic incrementality require per relation/collective?
4. **Maintainability** — Can the project reliably inspect, test, migrate, and debug the incremental layer with AI-assisted development?
5. **Migration cost** — Can A introduce B later behind stable query/domain boundaries without major semantic rewrites?

## Emerging progressive-hybrid hypothesis

**Working / non-authoritative.**

Director input currently favors starting from Candidate A's simple semantic implementation while preserving a deliberate promotion path for selected derived-state problems to Candidate B-style managed dependencies.

This is technically plausible because A and B can coexist within one program:

- one derived value may be recomputed on demand;
- another may use a direct maintained delta;
- another may use a dirty cache;
- another may use explicit dependency tracking;
- only sufficiently complex/high-value domains may justify stronger incremental relational/dataflow machinery.

The architectural requirement is that these strategies sit behind stable semantic/query boundaries so promotion changes *how a derived result is maintained*, not what the result means.

The next evidence should therefore test the **promotion seam and break-even surface**, not build two unrelated complete simulators.

## Next evidence

Do not build the Social Fabric prototype to answer these questions.

Use synthetic architecture-neutral kernels that model:

- identity-bearing relationships and churn;
- overlapping lower-level supports;
- derived household-like aggregates;
- repeated queries;
- additions/removals/quantity changes;
- 2–5 levels of synthetic nesting;
- low/medium/high invalidation fan-out.

Compare:

1. reference recomputation;
2. direct delta maintenance;
3. lightweight dependency tracking;
4. stronger incremental relational/dataflow mechanism only when representative.

Measure CPU, memory, affected work, p95/p99 update-to-consistent-view latency, and correctness against the reference result.

## Host/runtime decision

Language/runtime selection remains a separate but interacting discriminator.

Do not benchmark every architecture in every language. First determine whether Candidate B's additional derivation machinery earns its complexity. Then run a common host/runtime bake-off using the surviving architecture's representative kernels.
