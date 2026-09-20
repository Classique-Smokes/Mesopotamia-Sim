# Architecture Selection Playbook

**Status:** WORKING / NON-AUTHORITATIVE  
**Applies to:** TRES-0002 Stage II–IV

## Objective

Turn the accepted semantic foundation and TRES-0002 evidence into one implementation-architecture decision without widening into an open-ended technology survey.

## Current architecture rule

ADR-0003 resolves the earlier derived-state fork: begin with the simplest sufficient maintenance strategy per subsystem and promote selected workloads to stronger dependency/incremental machinery only when measured need justifies it.

This is no longer a global A-vs-B architecture choice.

## Stage II — remaining selection

The remaining consequential decision is the **host/runtime and concrete whole-system implementation structure**.

A candidate must explain:

- authoritative state and proposal/commit boundary;
- time, activation, and serializable pending-process model;
- cognition/subjective-state integration;
- relation/collective-state representation;
- semantic history and continuation saves;
- reproducibility contract;
- host language/runtime/toolchain;
- scaling and optimization path;
- migration/escape paths;
- main failure modes and operational burden.

## Evidence rule

Commission follow-up evidence only when it can change the selection.

Current discriminator:

**host/runtime fit on the same language-neutral workload**, including memory, branch-heavy local decisions, dynamic relations, scheduling/process churn, semantic-history emission, checkpoint/restore, deterministic verification, tooling, and AI-assisted maintainability.

Do not multiply every language by every possible scheduler, cache, history model, or framework.

## Stage III — adversarial review

Fresh independent reviewers attack the surviving architecture for:

- semantic drift or hidden sources of truth;
- coupling between domain semantics and runtime representation;
- determinism/recovery weaknesses;
- migration/versioning traps;
- scaling assumptions;
- dependency/framework maturity;
- debugging and observability difficulty;
- complexity disproportionate to project conditions.

Reviewers do not select the architecture.

## Stage IV — decision

The Master Architect presents:

- viable implementation candidate(s);
- project-specific evidence;
- recommendation and tradeoffs;
- known uncertainties;
- migration/reversibility;
- explicitly deferred work.

Approval creates concise ADR(s).

## Anti-loop stop rule

Do not commission more architecture research unless new evidence could materially change the shortlist, expose a hidden contradiction, or resolve an adversarial-review blocker. Otherwise proceed.
