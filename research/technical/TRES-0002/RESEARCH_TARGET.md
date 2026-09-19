# TRES-0002 — Research Target

**Status:** Working research input; not architecture authority.

## Accepted foundation

Candidate architectures must preserve the following accepted project semantics:

- persistent individuals, material resources/places, independently meaningful relationships/claims/obligations, and processes/events that change them;
- households emerge from lower-level social reality rather than acting as primitive containers, yet may acquire persistent identity, history, coordinated behavior, and causal influence;
- collective action must remain explainable through the lower-level reality that sustains it;
- household association does not automatically imply kinship, residence, ownership, labor/service, support, dependency, institutional affiliation, or exclusive membership;
- simulation-relevant things are independently identified typed records connected by explicit references; the first prototype uses indexed in-memory active state behind narrow domain operations;
- individual agency uses soft hierarchical concerns, contextual candidate generation, transparent local scoring, persistent goals separate from immediate choice, later bounded planning, and actions as attempts/proposals rather than unilateral mutation of other actors;
- exhaustive global option evaluation is excluded;
- causal observability and historical legibility are architectural concerns.

## Working target capabilities

These are current research targets rather than accepted implementation architecture. Candidate designs should show whether and how they can support:

- sparse subjective actor knowledge/recognition that can differ from objective world state;
- household identity surviving limited constituent turnover through historical continuity rather than fixed membership;
- persistent organizational roles occupied by changing individuals;
- collective capabilities feeding back into individuals without erasing or double-counting lower-level support;
- explicit semantics for simulated time, activation, observation/visibility, conflicting proposals, delayed/interruptible processes, and reproducible experiments;
- semantic history/provenance sufficient to explain consequential state;
- continuation saves sufficient to resume unfinished processes rather than merely restore visible values.

A researcher should flag any target that appears technically contradictory or disproportionately expensive rather than silently weakening it.

## Scale and development conditions

- The first implementation is a small headless laboratory.
- Long-horizon ambition is at least hundreds of thousands of agents, potentially more.
- The architecture should favor sparse/local work and progressive optimization rather than requiring production-scale infrastructure before the foundation is validated.
- Development is heavily AI-assisted and directed by a non-specialist programmer. Maintainability, inspectability, deterministic testing, bounded operational complexity, and clear verification surfaces matter alongside raw performance.
- The project expects long-horizon iteration. Migration cost, versioning, recoverability, and the ability to optimize/replace hot paths later are decision criteria.

## Explicitly unresolved

No programming language, runtime, framework, database, scheduling model, concurrency model, OOP/ECS/data-oriented/functional style, graph technology, cognitive framework, persistence strategy, rule engine, or production performance architecture is selected.

The current architecture discussion has surfaced examples from several of these families, but they are not the researcher's solution set.
