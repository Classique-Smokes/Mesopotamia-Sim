# Architecture Decision Record (ADR) Process

**Purpose:** Lightweight process for consequential software and simulation architecture choices.

## When an ADR is required

Create an ADR when a proposed decision materially affects architecture or crosses an escalation boundary, including persistent representation, major subsystem boundaries, significant abstraction strategy, cross-system interfaces, dependencies/frameworks, concurrency/execution model, persistence/compatibility, or major performance strategy.

Do not create ADRs merely to populate the repository.

## ADR states

Use: `PROPOSED / ACCEPTED / REJECTED / SUPERSEDED`.

An ADR requiring Architectural authority remains `PROPOSED` until the Human Project Director gives explicit approval. Silence or lack of objection is not acceptance.

## Required proposal content

Every architectural proposal should explain, in accessible language:

1. **Problem** — what problem is being solved.
2. **Why now** — why a decision is needed at this point rather than remaining open.
3. **Realistic alternatives** — viable options, including deferral where realistic.
4. **Recommendation** — the Master Architect's recommended option.
5. **Tradeoffs** — major benefits, costs, and risks.
6. **Consequences** — effects on scale, maintainability, simulation fidelity, and future work where relevant.
7. **Reversibility** — migration difficulty, lock-in, and cost of changing later.
8. **Unaffected / undecided matters** — what the ADR deliberately does not decide.

## Workflow

1. Identify a decision-relevant architectural problem.
2. Gather only the evidence needed to compare realistic options.
3. Add a `PROPOSED` entry to the Decision Register.
4. Write the ADR using `ADR_TEMPLATE.md`.
5. Present the proposal to the Human Project Director in accessible language.
6. On explicit approval, mark both ADR and register entry `ACCEPTED` and update affected specifications.
7. On rejection, record `REJECTED`; preserve the rationale.
8. If later replaced, mark the old ADR `SUPERSEDED` and link the replacement. Never rewrite history to make the old decision disappear.

## Scope discipline

An ADR decides only what its scope states. Adjacent unresolved matters remain unresolved unless separately promoted and accepted.
