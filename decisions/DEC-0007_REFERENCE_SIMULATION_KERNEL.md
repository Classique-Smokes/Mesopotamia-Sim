# DEC-0007 — Reference Simulation Kernel

**Status:** ACCEPTED  
**Authority level:** Architectural  
**Accepted:** 2026-09-20  
**Approver:** Human Project Director

## Decision

Adopt `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`.

The first prototype uses a single-process deterministic semantic kernel with authoritative current state, proposal/commit mutation, explicit execution visibility, serializable pending processes, controlled randomness, semantic history, and complete safe-point continuation state.

## Not decided

Host/runtime and concrete implementation details remain open.
