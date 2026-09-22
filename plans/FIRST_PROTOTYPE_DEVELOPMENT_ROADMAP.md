# First-Prototype Development Roadmap

**Status:** APPROVED OPERATIONAL ROADMAP  
**Role:** Operational plan; does not create simulation or architectural authority.

## Objective

Reach a verified first Social Fabric Laboratory that demonstrates the accepted individual → relationship → household foundation and can then be iterated and scaled without bypassing architectural governance.

## 1. Complete implementation-architecture selection

- Finish the host/runtime bake-off.
- Reconcile project-specific evidence.
- Run independent adversarial review.
- Accept the host/runtime and remaining implementation-architecture choices.

**Complete when:**
- host/runtime is explicitly accepted;
- implementation architecture is sufficient to issue bounded coding tasks;
- remaining open technical questions do not block the first prototype;
- adversarial review has no unresolved architecture-level blocker.

## 2. Specify Social Fabric Laboratory v0

Define the smallest model that can exercise:

- persistent individuals;
- meaningful relationships/obligations;
- subjective recognition;
- household formation and persistent identity;
- one grounded collective capability;
- one representative/broker role;
- limited constituent turnover;
- explicit processes, history, and continuation.

Future systems may supply controlled scenario inputs rather than being implemented.

**Complete when:**
- every in-scope entity, state distinction, transition, and causal dependency required by v0 is specified;
- in-scope and out-of-scope behavior are explicit;
- implementation agents do not need to invent foundational social semantics;
- unresolved matters are either non-blocking or explicitly represented as controlled assumptions.

## 3. Define verification scenarios

Before implementation, specify observable scenarios covering at least:

- organization formation;
- household continuity through turnover;
- representative-role succession;
- recognition failure / absence of engine-only institutional effects;
- grounded collective capability and support changes;
- proposal/conflict resolution;
- deterministic continuation after save/load.

**Complete when:**
- every consequential v0 behavior has at least one observable acceptance scenario;
- relevant architectural invariants have mechanical checks where practical;
- expected outcomes are defined without depending on manual code inspection;
- save/load and determinism requirements are testable.

## 4. Build the reference prototype in vertical slices

Implement and verify:

1. individuals + relationships + proposal/commit + semantic history;
2. subjective recognition + minimal individual agency;
3. persistent household identity + one grounded collective capability;
4. representative role + turnover/succession;
5. delayed processes + checkpoint/restore continuation.

Each slice must leave a runnable, verified system.

### Early observational checkpoint after Slice 1

After the first lower-level slice is independently verified, the project may pause before Slice 2 to run a small autonomous world and inspect its generated history directly.

For the current planned checkpoint, see:

- `SFL_V0_SLICE1_BIRTH_OBSERVATION_PLAN.md`

This early run is **not** Roadmap Stage 5 model iteration and does not replace the five-slice prototype objective. It exists to expose the actual behavior and observability of the first causal substrate before additional layers make interpretation harder.

Findings from the early run may inform later work, but one lower-level reference world must not be overinterpreted as evidence about historical calibration, household dynamics, or the completed simulation.

### Slice-linked discovery prompts

Before planning Slices 2–5, retrieve `SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`. It points each slice toward the larger conceptual questions that its accepted machinery may make observable, while explicitly preventing those questions from becoming new requirements by implication.

The deeper conceptual source is `../research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md`. Retrieve it only when the relevant slice or observation makes the question timely.

**Complete when:**
- all five slices execute together as one reference simulation;
- all required verification scenarios pass;
- authoritative state, history, derived state, and checkpoint restoration satisfy accepted architecture;
- deterministic reference runs can be reproduced;
- no known defect invalidates the demonstrated social behavior;
- no unresolved implementation shortcut silently changes accepted semantics.

## 5. Begin model iteration

Run small controlled worlds and inspect causal behavior.

Observed failures or unrealistic dynamics become bounded design, historical-research, or technical questions as appropriate.

Change the model through the existing authority process; do not redesign architecture merely because an experiment behaves poorly.

**Complete when:**
- the prototype can run repeated controlled experiments without structural intervention;
- causal inspection can explain important outcomes;
- discovered problems can be classified as model, evidence, parameter, implementation, or architecture issues;
- at least one iteration cycle has changed the model and passed regression verification without compromising prior accepted behavior.

This marks completion of the **first functional Social Fabric Laboratory**.

## 6. Scale progressively

After the reference behavior is stable enough to serve as an oracle:

**small worlds → larger worlds → measured stress tests**

Track activation density, candidate-set size, relation density/churn, dependency fan-out, history volume, memory, and runtime cost.

Apply ADR-0003 per subsystem: introduce stronger indexing, caching, dependency tracking, batching, compiled paths, parallelism, or other specialization only where measured evidence justifies it.

**Complete when:**
- representative scaling measurements exist across increasing world sizes;
- material bottlenecks are identified rather than assumed;
- any adopted optimization has been verified against reference semantics;
- the project has an evidence-based next scaling target rather than an unresolved foundational architecture problem.

## First-prototype milestone

The roadmap's first-prototype objective is complete when the project has a **runnable, deterministic, inspectable Social Fabric Laboratory** in which:

- individuals and relationships generate a household-like collective through modeled processes;
- that collective persists through limited constituent change;
- one grounded collective capability influences individual possibilities;
- one representative role can change occupant without automatically destroying collective identity;
- subjective recognition materially affects organization without engine-only self-confirmation;
- consequential state can be causally inspected;
- continuation save/load preserves future behavior;
- required scenarios and invariants pass automatically;
- the implementation remains a trustworthy reference path for later model iteration and optimization.

## Persistent rule

At every stage, prefer the smallest faithful next step that produces new evidence about the simulation.

Future capability should remain possible without becoming present implementation work.
