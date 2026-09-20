# ADR-0004 — Reference Simulation Kernel

**Status:** PROPOSED  
**Decision Register:** DEC-0007  
**Authority:** Architectural

## Decision

The first Social Fabric Laboratory uses a **single-process, single-threaded reference kernel** with explicit semantic state and deterministic execution.

### State and mutation

- Current typed in-memory records are authoritative execution state.
- Behavioral/domain code reads through narrow query/domain interfaces.
- Agents and roles emit **attempts/proposals**; they do not directly mutate other entities.
- All authoritative changes pass through one validation/resolution/commit boundary.
- Indexes and derived state update from committed changes and remain rebuildable unless explicitly promoted by later architecture.

### Execution cycle

The reference kernel uses explicit phases:

**activate/read committed state → deliberate/propose → resolve conflicts/validate → commit → update derived/index state → emit semantic history → schedule reactions/future work**

A reasoning phase does not observe another actor's uncommitted mutation. Any intentionally sequential interaction must be represented explicitly rather than arise from program iteration order.

### Time and pending work

- Simulated time is explicit and independent of CPU/update count.
- Delayed or interruptible activities are explicit serializable process records/state machines.
- Pending work has deterministic total ordering using simulated time plus explicit tie-breaking metadata.
- Future work revalidates relevant conditions when it executes.
- Runtime coroutine/task stacks are not simulation authority.

### Randomness

Randomness is accessed through a simulation randomness boundary with explicit semantic stream/draw identity sufficient for deterministic experiments and continuation.

The exact generator and key scheme remain host/engineering decisions, but random outcomes must not depend accidentally on container iteration or worker execution order.

### History and recovery

- Current state, not the event log, is the execution authority.
- Consequential committed transitions emit compact semantic history/provenance.
- Operational telemetry and debug traces are separate from durable semantic history.
- Continuation checkpoints occur at explicit simulation-safe boundaries and capture all future-influencing state: authoritative records, time/order state, pending processes/work, randomness continuation identity, and version/config metadata.
- Derived indexes/caches may be rebuilt on restore.

### Kernel boundaries

The reference implementation separates at least these responsibilities:

- authoritative state and indexes/queries;
- agency / subjective-state access;
- proposal generation and resolution;
- time / scheduler / persistent processes;
- domain modules such as household organization;
- semantic history/provenance;
- checkpoint/persistence;
- inspection and verification.

These are logical module boundaries, not services or processes.

## Consequences

- The first implementation is intentionally optimized for semantic clarity, inspection, testing, and later specialization.
- Parallelism, GPU execution, distribution, event-sourced authority, opaque coroutine persistence, and heavyweight simulation frameworks are excluded from the reference kernel unless later evidence justifies an architectural change.
- Optimized future paths must preserve the accepted kernel semantics or explicitly escalate the difference.

## Not decided

Programming language/runtime, concrete schemas/classes, container/layout choices, scheduler data structure, exact execution phase names/priority values, RNG algorithm/key format, checkpoint encoding, archive/database technology, household rules, or production-scale optimization.
