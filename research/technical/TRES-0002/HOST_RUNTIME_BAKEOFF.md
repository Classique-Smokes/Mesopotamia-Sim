# TRES-0002 — Host / Runtime Bake-off

**Status:** WORKING RESEARCH SPEC  
**Authority:** Advisory evidence only

## Objective

Compare credible host/runtime stacks for the **same simple semantic kernel** before selecting the implementation platform.

The bake-off tests project-shaped workloads, not generic language speed.

## Initial finalists

- .NET / C#
- JVM / Kotlin or Java
- Rust
- Python
- Julia

C++ is a contingency/performance reference only if the finalists leave an unresolved native-performance question.

## Common constraints

Each implementation must:

- use stable IDs and independently identified typed records;
- keep active state in memory with explicit indexes;
- remain single-process and single-threaded for the baseline;
- use deterministic seeded/keyed randomness;
- emit proposals rather than cross-entity direct mutation;
- commit changes through one controlled transition path;
- use only simple derived-state maintenance consistent with ADR-0003;
- produce identical canonical semantic results for the supplied fixtures;
- avoid databases, distributed runtimes, GPU code, and heavyweight simulation frameworks.

Runtime-specific optimizations may be explored only after the baseline is correct and must remain separately reported.

## Workloads

### 1. Active-state access

Synthetic populations at increasing sizes with 1%, 5%, and 20% active subsets.

Measure indexed lookup, active-set traversal, memory, allocation/GC behavior, and hidden inactive work.

### 2. Dynamic relationships

Identity-bearing relations with attached state and heavy-tailed degree distribution.

Measure neighborhood lookup plus relation create/update/remove churn.

### 3. Local decision loop

For active agents:

- retrieve local subjective/relation context;
- generate bounded candidate sets;
- score branch-heavy alternatives;
- use deterministic randomness where required;
- emit one proposal.

Use at least two candidate-set sizes.

### 4. Proposal / commit

Validate and commit multi-record proposals with deterministic conflict ordering and invariant checks.

### 5. Pending processes

Schedule, pop, cancel/reschedule, and continue explicit timestamped process records with deterministic tie-breaking.

### 6. Semantic history and continuation

Emit compact semantic transition records, create a continuation checkpoint, reload, and verify that subsequent semantic results match uninterrupted execution.

## Required measurements

On one common evaluation machine/runtime environment where possible:

- wall-clock throughput/latency by workload;
- peak memory / RSS;
- bytes per representative entity/relation/process where measurable;
- allocation and GC evidence where applicable;
- build/startup/test latency;
- checkpoint size/time and restore time;
- semantic-result hash/equality.

Also record:

- source/build complexity;
- dependency/toolchain burden;
- profiling/debugging quality;
- difficulty of expressing stable IDs, explicit processes, narrow mutation boundaries, and deterministic tests.

## Fairness rules

- Correctness precedes performance.
- Do not change the workload semantics to suit a language.
- Do not compare results from different hardware as if directly equivalent.
- Report warm-up/JIT effects separately where relevant.
- Avoid micro-optimizations that destroy readability unless reported as a separate optimized variant.
- Preserve idiomatic implementations; this is not a code-golf contest.
- A slower stack may remain preferable if it materially improves maintainability, inspection, or migration.

## Decision use

The bake-off informs the host/runtime choice; it does not choose the full future production architecture.

Results should preserve Pareto tradeoffs rather than collapse into one score.

The Master Architect will reconcile performance with:

- semantic fit;
- AI-assisted maintainability;
- ecosystem maturity;
- profiling/testing quality;
- migration/optimization path;
- long-horizon project risk.
