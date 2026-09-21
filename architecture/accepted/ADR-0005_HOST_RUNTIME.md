# ADR-0005 — Host Runtime

**Status:** ACCEPTED  
**Decision Register:** DEC-0008  
**Authority:** Architectural  
**Accepted:** 2026-09-21  
**Approver:** Human Project Director

## Decision

Use **C# 14 on .NET 10 LTS** as the host language/runtime for the first Social Fabric Laboratory.

## Rationale

Project-specific bake-off and adversarial review showed sufficient performance headroom with a strong development-risk, diagnostics, static-analysis, and AI-assisted maintainability profile.

## Constraints

- No preview language features.
- Runtime-specific implementation must preserve ADR-0004 reference-kernel semantics.
- Performance specialization remains evidence-gated under ADR-0003.
- Host/runtime upgrades are deliberate and regression-verified.

## Not decided

Concrete record/layout choices, scheduler structure, RNG implementation, checkpoint encoding, dependencies/frameworks, or production-scale optimization.
