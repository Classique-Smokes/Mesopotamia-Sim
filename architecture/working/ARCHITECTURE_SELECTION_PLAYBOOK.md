# Architecture Selection Playbook

**Status:** WORKING / NON-AUTHORITATIVE  
**Applies to:** TRES-0002 Stage II–IV

## Objective

Turn the accepted semantic foundation and TRES-0002 evidence into one implementation-architecture decision without widening into an open-ended technology survey.

## Stage II — Candidate synthesis

The Master Architect produces **2–3 coherent whole-system candidates**, not a technology shopping list.

Each candidate must explain:

- authoritative current state;
- proposal/commit boundary;
- time, activation, and persistent-process model;
- subjective knowledge / cognition integration;
- relationship and collective-state representation;
- derived-state maintenance;
- history/provenance and continuation saves;
- reproducibility contract;
- host language/runtime/toolchain assumptions;
- scaling path;
- migration/escape paths;
- main failure modes and complexity burden.

A candidate may combine mechanisms from different research families only when the seams are explicit.

## Candidate construction rule

Prefer the least sophisticated mechanism that satisfies current semantic requirements **and** leaves credible migration paths.

Do not include a technology because it appeared in a research report. Include it only if it solves a stated problem in the candidate.

## Stage II — Discriminating unknowns

Commission follow-up work only when the answer could reverse the candidate choice.

Current likely discriminators:

1. **Derived-state break-even:** direct/recomputed values vs dependency tracking vs stronger incremental relational/dataflow machinery.
2. **Workload shape:** activation density, candidate counts, graph/relation churn, dependency fan-out, conflicts, and history volume.
3. **Host/runtime fit:** memory, branch-heavy local decisions, dynamic relations, event/process scheduling, instrumentation, checkpointing, and AI-assisted maintainability.
4. **History/reproducibility contract:** how much exact replay, continuation, causal detail, and cross-version compatibility the first architecture must promise.

## Validation rule

Use small architecture-neutral kernels and synthetic workloads before building the Social Fabric prototype when the evidence can discriminate architecture.

Keep semantic scenarios separate from performance kernels until the architecture is chosen.

Where practical, require a simple reference result and compare optimized alternatives against it.

## Stage III — Adversarial review

Fresh independent reviewers receive the candidate architectures and accepted project constraints.

They should attack:

- semantic drift;
- hidden sources of truth;
- coupling between domain semantics and performance representation;
- determinism/reproducibility weakness;
- cache/incremental consistency failure;
- double-counting/conservation hazards;
- migration traps;
- versioning/recovery burden;
- scaling assumptions;
- dependency/framework maturity;
- debugging/observability difficulty;
- complexity disproportionate to project capability.

Reviewers do not select the architecture.

## Stage IV — Decision

The Master Architect reconciles evidence and presents the Project Director with:

- viable candidates;
- project-specific evidence;
- recommendation;
- important tradeoffs;
- measured/known uncertainties;
- migration/reversibility;
- what remains explicitly deferred.

Approval creates concise ADR(s). Research reports and this playbook remain supporting material rather than implementation authority.

## Anti-loop stop rule

Do not commission additional architecture research unless at least one condition holds:

- a candidate cannot be compared responsibly with current evidence;
- a newly discovered technique could materially change the shortlist;
- a benchmark exposes a previously hidden bottleneck or contradiction;
- adversarial review finds a consequential unresolved risk;
- implementation conditions change materially.

Otherwise proceed to decision.
