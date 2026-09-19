# ADR-0002 — Hierarchical Individual Agency

**Status:** ACCEPTED  
**Decision Register:** DEC-0004  
**Authority:** Architectural  
**Accepted:** 2026-09-19  
**Approver:** Human Project Director

## Decision

Individual decision-making uses a **hierarchical, context-sensitive architecture**:

1. active concerns are prioritized through **soft/conditional tiers or gates**;
2. only contextually relevant and accessible candidate actions are generated;
3. alternatives inside the narrowed candidate set are evaluated through transparent component scoring;
4. persistent goals/intentions are separate from immediate choice;
5. a later planning layer supports multi-step goals when needed rather than planning every ordinary action;
6. interpersonal/collective actions are attempts or proposals whose effects remain subject to other actors and world-resolution rules.

## Performance constraint

Before scalable implementation, measure and budget **agent activation frequency** and **candidate-set size**. Exhaustive global option evaluation is excluded.

## Not decided

Tier content/count, exact soft-gate semantics, scoring formula, action repertoire, subjective information model, planner algorithm, reconsideration timing, office-specific behavior, scheduler, and historical parameters remain open.

## Evidence

- TRES-0001D technical research (to be archived under `research/technical/TRES-0001/`).
