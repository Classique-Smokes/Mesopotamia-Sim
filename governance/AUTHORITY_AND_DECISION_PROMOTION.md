# Authority and Decision Promotion

**Purpose:** Define how project thought becomes authoritative project state.

## Authority levels

### Constitutional
Changes to project identity, historical philosophy, simulation philosophy, foundational causal model, or AI-governance principles. **Requires explicit Human Project Director approval.**

### Architectural
Consequential software or simulation architecture with persistent or cross-system effects. **Requires explicit Human Project Director approval** after an accessible proposal with alternatives, recommendation, tradeoffs, consequences, and reversibility.

### Engineering
Local, reasonably reversible technical choices that remain within accepted architecture. The Master Architect may decide and record them.

### Implementation
Ordinary coding choices inside accepted specifications. Implementation agents may decide locally unless an escalation trigger is reached.

When classification is uncertain, judge by **scope, reversibility, persistence, and cross-system consequences**, not by how technical the subject sounds.

## Promotion path

1. **Conversation / observation** — non-authoritative input enters the workspace.
2. **Interpretation pass** — classify only what is actually present: durable intent, requested outcome, possible requirement, example, speculation, historical claim, temporary assumption, decision candidate, or unresolved issue.
3. **Evidence / analysis if needed** — commission bounded research or technical review. Research remains advisory.
4. **Proposal** — if a consequential choice is timely, record it as `PROPOSED` in the Decision Register and create an ADR when architectural.
5. **Authority check** — identify the level that may accept it.
6. **Explicit acceptance** — constitutional/architectural approval must be clear and deliberate. Silence never counts. Engineering decisions may be accepted by the Master Architect within delegated bounds.
7. **Canonical update** — mark the decision `ACCEPTED`; update affected specifications and links. Do not erase replaced rationale; use `SUPERSEDED` with references.
8. **Implementation delegation** — create bounded tasks from accepted specifications/decisions.
9. **Verification** — implementation reports changes, tests, assumptions, conflicts, and deviations.
10. **Drift review** — compare Seed/Constitution → Accepted Decisions → Specifications → Implementation.

## Non-authoritative states

These do not become project truth by persistence:

- chat statements;
- examples or analogies;
- research findings;
- proposals;
- temporary assumptions;
- code that deviates from accepted state;
- an implementation shortcut;
- repeated mention without explicit promotion.
