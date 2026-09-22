# Architecture Escalation Rules

**Status / authority:** ACCEPTED operational escalation protocol  
**Purpose:** Define when implementation evidence must return to architectural/project review rather than being silently absorbed into code.  
**Load when:** implementation or design work encounters a change with persistent, semantic, cross-system, compatibility, execution-model, or similarly consequential effects.  
**Do not load merely because:** a local reversible engineering choice is inconvenient.  
**Expected output:** a bounded escalation containing the conflict, affected authority, evidence, realistic options, consequences, and safe continuing work.  
**Escalation / stop:** the protocol itself is the stop path; do not implement the consequential change first and seek approval afterward.


**Principle:** Implementation may expose architectural evidence; it may not silently convert that evidence into architecture.

## Escalate when a proposed implementation change would materially affect

- core simulation semantics or causal meaning;
- entity identity, lifetime, or persistent representation;
- subsystem boundaries, ownership, or responsibilities;
- major dependencies, frameworks, engines, or runtime foundations;
- persistent schemas, save/load compatibility, or external compatibility;
- abstraction level or fidelity, especially where individual-driven causality may be weakened;
- global state, shared mutable state, or substantial cross-system coupling;
- concurrency, scheduling, execution model, or determinism/reproducibility strategy;
- accepted public/internal interfaces that other accepted systems rely on;
- architectural invariants;
- significant performance strategy or optimization that changes behavior/meaning;
- an accepted requirement, ADR, specification, or higher-authority principle.

This list is a floor, not a loophole: a change with comparable persistence or cross-system consequence should also be escalated.

## What an escalation should contain

1. What the implementation task was trying to do.
2. What conflict or limitation was discovered.
3. Which accepted artifact(s) are affected.
4. Why a local workaround is unsafe or misleading.
5. Realistic options, including retaining current architecture where possible.
6. Evidence from tests, measurements, prototypes, or code where relevant.
7. Consequences and reversibility.
8. What work can safely continue while the issue remains open.

## What not to do

Do not:

- change architecture first and ask for approval afterward;
- redefine a requirement because the current code makes it difficult;
- let a prototype assumption become a permanent contract invisibly;
- treat performance speculation as proof that abstraction is required;
- copy an external framework's preferred architecture into the project without a project-specific decision.
