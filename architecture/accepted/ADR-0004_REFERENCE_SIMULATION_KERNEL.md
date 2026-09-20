# ADR-0004 — Reference Simulation Kernel

**Status:** ACCEPTED  
**Decision Register:** DEC-0007  
**Authority:** Architectural  
**Accepted:** 2026-09-20  
**Approver:** Human Project Director

## Decision

The first Social Fabric Laboratory uses a **single-process, single-threaded deterministic reference kernel**.

- Current typed in-memory records are authoritative execution state.
- Agents/roles read committed state and emit attempts/proposals; authoritative mutation occurs only through validation/resolution/commit.
- Ordinary execution follows explicit visibility phases: **read/activate → deliberate/propose → resolve → commit → refresh derived/index state → record semantic history → schedule future work**.
- Simulated time is explicit. Delayed/interruptible work is represented by serializable process state with deterministic ordering and condition revalidation.
- Randomness is accessed through an explicit simulation boundary sufficient for reproducible experiments and continuation.
- Current state remains authoritative; consequential commits emit semantic history/provenance.
- Continuation checkpoints at simulation-safe boundaries capture all future-influencing state. Rebuildable indexes/caches need not be authoritative persistence.
- State/query, agency, resolution, time/process, domain, history, persistence, and verification remain separate logical responsibilities.

## Consequences

- Runtime iteration order, coroutine/task stacks, caches, and event logs do not silently become simulation authority.
- Parallelism, GPU/distributed execution, event-sourced authority, and heavyweight simulation frameworks are deferred unless later evidence justifies architectural change.
- Future optimizations must preserve these semantics or escalate explicitly.

## Not decided

Host language/runtime, concrete record/layout choices, scheduler data structure, RNG implementation, checkpoint encoding, database/archive technology, domain rules, and production-scale optimization.
