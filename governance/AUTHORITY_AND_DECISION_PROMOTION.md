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
7. **Semantic-preservation check** — before compressing approved working material, enumerate its binding commitments, preconditions, edge cases, exclusions, and deliberate delegated/open locks. After drafting the canonical rewrite, reconcile each item as **preserved**, **explicitly superseded/deferred**, or **recorded as an open erratum**. Rationale/examples may be dropped; operative meaning may not.
8. **Canonical update** — mark the decision `ACCEPTED`; update affected specifications and links. Do not erase replaced rationale; use `SUPERSEDED` with references.
9. **AI-retrieval / navigation closure** — decide whether the committed artifact is expected to constrain or materially inform future AI work. If yes, update the smallest relevant navigation surfaces so a fresh agent following the root retrieval path can find the artifact without prior conversation or Git history. Promotion is incomplete until this retrieval path is coherent.
10. **Implementation delegation** — create bounded tasks from accepted specifications/decisions.
11. **Verification** — implementation reports changes, tests, assumptions, conflicts, and deviations.
12. **Drift review** — compare Seed/Constitution → Accepted Decisions → Specifications → Implementation.

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


## AI-retrieval / navigation closure

An artifact requires navigation closure when it is expected to be consulted by future AI as one of:

- **authority** — constitutional decision, accepted ADR/decision, accepted subsystem specification, or other binding project rule;
- **active operational context** — current phase/workbench, canonical verification package, implementation packet, or other artifact needed to continue the current critical path;
- **required supporting context** — an assumption/register entry, engineering guardrail, verification rule, migration note, or other non-authoritative artifact that future work is explicitly expected to consult.

Research returns, superseded working notes, archived proposals, raw experiments, and explanatory rationale do **not** require root navigation merely because they are committed. They should be linked from the authoritative/active artifact that uses them when relevant.

### Navigation surfaces and when to update them

Use the smallest sufficient set:

- `AGENTS.md` — change only when the repository-wide agent retrieval/workflow contract itself changes; never use it as a project-artifact catalog.
- `00_START_HERE.md` — update when the accepted foundation, primary current authority, current phase, or durable "where to look" entrypoints materially change.
- `plans/CURRENT_PHASE.md` — update when active/completed/next work or the artifacts required for the active critical path change.
- `decisions/DECISION_REGISTER.md` — update whenever a consequential decision is opened, accepted, rejected, or superseded.
- local indexes such as `specifications/README.md`, package `README.md` files, or equivalent — update when an accepted/canonical artifact is added, removed, renamed, or superseded inside that family.
- `registers/ASSUMPTIONS_REGISTER.md` and `registers/OPEN_ISSUES_REGISTER.md` — keep status/linkage synchronized when promotion creates, retires, resolves, or materially changes an assumption/question.

Do **not** mechanically touch every navigation file. The completion test is:

> Starting only from `AGENTS.md` and the repository's documented retrieval path, can a fresh qualified AI discover the newly relevant source of truth or required context at the point it would need it?

If no, the promotion/commit is not cleanly complete.
