# Research Task Packet — Scope / Minimality Red Team

**Task ID:** TRES-0010I  
**Status:** OPEN  
**Context mode:** INDEPENDENT-CONTEXT with repository access / minimally anchored  
**Return:** `research/technical/TRES-0010/returns/TRES-0010I_SCOPE_MINIMALITY_REPORT.md`

## 1. Question

Have SFL v0, Stage-3 verification, or IMP-0001 accumulated complexity that is not actually needed to prove the project's first individual→relationship→household foundation?

## 2. Why it matters now

The project deliberately prefers the smallest faithful next step. Pre-code review must attack overdesign as hard as underspecification.

## 3. Objective

Identify:

- mechanics that do not materially contribute to the first laboratory's proof goals;
- verification machinery whose cost exceeds the defect class it protects against;
- configuration/profile detail that can safely remain fixture-local;
- Slice-1 requirements that belong to later slices;
- abstractions likely to invite framework-building;
- premature persistence/scaling/generalization concerns.

For each candidate simplification, prove that removing/deferring it would **not** weaken an accepted Stage-3 claim or architectural seam.

Also identify complexity that appears unnecessary but is actually justified—do not recommend deletion merely for aesthetic simplicity.

## 4. First-pass source restriction

Read:

- DEC-0001;
- first-prototype roadmap;
- SPEC purpose/exclusions;
- completed verification README + cross-cutting contract;
- IMP-0001.

Do not read previous TRES conclusions before drafting initial findings.

## 5. Evidence standards

A removal recommendation must point to the proof obligation it does not affect. “Seems complex” is insufficient.

## 6. Boundaries

Do not weaken accepted semantics/verification. Do not redesign historical scope. Do not choose code structure.

## 7. Required output

Provide:

- safe simplifications/deferments;
- complexity that must remain and why;
- any IMP-0001 scope cuts worth considering;
- common-schema severity.

## 8. Authority reminder

Advisory only.
