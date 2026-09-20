# DEC-0006 — Progressive Derived-State Specialization

**Status:** ACCEPTED  
**Authority level:** Architectural  
**Accepted:** 2026-09-19  
**Approver:** Human Project Director

## Decision

Adopt `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`.

Derived state begins with the simplest sufficient maintenance strategy and may graduate per subsystem to stronger dependency/incremental machinery behind stable semantic boundaries when project-specific evidence justifies it.

## Rationale

TRES-0002 showed that simple recomputation, manual deltas, caches, dependency tracking, and stronger incremental systems are complementary techniques with workload-dependent break-even points. The project should preserve the migration path without paying the complexity cost universally from the start.

## Not decided

No specific incremental technology, threshold, language/runtime, or benchmark target is selected.
