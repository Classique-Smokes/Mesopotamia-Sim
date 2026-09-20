# DEC-0007 — Reference Simulation Kernel

**Status:** PROPOSED  
**Authority level:** Architectural  
**Opened:** 2026-09-20

## Problem

The host/runtime bake-off is still active, but most of the first implementation architecture is independent of language and should be fixed before stack-specific implementation choices begin to shape semantics.

## Proposal

Adopt `architecture/working/ADR-0004_REFERENCE_SIMULATION_KERNEL_PROPOSAL.md`.

The first prototype would use a single-process deterministic semantic kernel with authoritative current state, proposal/commit mutation, explicit phased visibility, serializable pending processes, controlled randomness, semantic history, safe-point continuation checkpoints, and clear logical subsystem boundaries.

## Not decided

Host/runtime and the concrete implementation choices listed in ADR-0004 remain open.
