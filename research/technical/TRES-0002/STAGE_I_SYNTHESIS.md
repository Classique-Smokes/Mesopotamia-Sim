# TRES-0002 — Stage I Synthesis

**Status:** RECONCILED ADVISORY EVIDENCE  
**Authority:** Not architecture authority

## What converged

Six independent workstreams support a common architecture direction without selecting one implementation:

1. **Keep a simple semantic authority.** The strongest whole-system baseline is explicit current state plus a controlled proposal/validation/commit boundary. Process/event scheduling can organize time without becoming the social ontology.
2. **Treat sophisticated machinery as selective.** Incremental computation, graph-specialized storage, data-oriented layouts, GPU/parallel execution, rule engines, BDI/cognitive frameworks, planners, and event sourcing each solve narrower problems; none earned universal adoption.
3. **Scale primarily by avoiding irrelevant work.** Important variables are activation density, candidate selectivity, graph/relation locality, dependency fan-out, batch size, conflict density, and history volume—not nominal population alone.
4. **Separate canonical facts from derived acceleration.** Relationships/collectives need stable semantic identities. Indexes, cached aggregates, graph projections, dependency structures, and other performance state should normally remain rebuildable.
5. **Incremental derived state is the most important newly surfaced architecture family.** It may fit nested household/institutional accounting particularly well, but only if update sparsity and repeated queries justify its memory/complexity cost.
6. **Cognition should be layered and bounded.** Established BDI/planning/cognitive systems provide useful mechanisms and comparison points, but the research does not justify placing a heavyweight universal cognition framework inside every agent.
7. **History is several problems.** Current truth, semantic history, provenance, continuation saves, experiment identity, branch lineage, and analytical archives should not be collapsed into one store.
8. **No host language won.** .NET/C#, JVM/Kotlin/Java, Rust, Python with coarse native hot paths, and Julia remain credible; C++ remains a control/performance reference. Project-specific kernels are required before selection.

## Where the evidence can mislead us

### Shared framing

All agents received the same semantic target. Convergence shows that the requirements map to credible engineering mechanisms; it is not six independent proofs that one architecture is optimal.

### Unknown workload

The project still lacks representative measurements for activation rates, candidate counts, relation churn, fan-out, planning use, conflict rates, memory density, and history volume. These can reverse performance conclusions.

### Seam complexity

The hardest failures may occur where individually reasonable subsystems meet: cognition → proposal → commit → relation mutation → collective invalidation → activation → history → checkpoint.

Whole-system candidates must therefore be evaluated as compositions, not as collections of best-in-class components.

### Kitchen-sink risk

Research identified many mature technologies. Combining them all would create an unmaintainable architecture. Each added mechanism must solve a demonstrated problem.

### Benchmark mismatch

Large graph, GPU ABM, distributed simulation, BDI, and LLM-agent results come from materially different workloads and hardware. They demonstrate technical headroom, not expected Social Fabric performance.

### Observability cost

Causal legibility can itself become a major memory/I/O workload. Durable semantic history, debugging traces, runtime telemetry, and deep decision traces need different retention policies.

### Migration optimism

“Optimize later” is only safe when boundaries actually isolate domain semantics from storage/execution details. Replaceability must be designed and tested, not assumed.

## Decision implication

Stage II should not choose among every technology named by Stage I.

It should construct a small number of coherent candidates that differ only on architecture choices capable of materially changing implementation risk or scaling trajectory, then use targeted project-specific evidence to discriminate them.

The central current comparison is likely between:

- a **conservative semantic kernel** using simple indexed state and selective lightweight derived-state maintenance; and
- an **incremental relational kernel** that adopts more systematic dependency/query maintenance earlier.

Scheduling style, cognition tools, history storage, and hot-path acceleration can often be compared as components inside those candidates rather than separate whole architectures.
