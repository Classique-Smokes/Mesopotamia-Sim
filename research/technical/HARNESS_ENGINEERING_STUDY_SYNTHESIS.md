# Harness Engineering Study — Reconciled Synthesis

**Status:** ADVISORY RESEARCH  
**Source:** Six independent study reports derived from *Engenharia de Harness* v0.78.0  
**Purpose:** Identify durable AI-assisted engineering practices worth carrying into this project without importing vendor-specific or unnecessary scaffolding.

## Already covered strongly

Current project governance already provides:

- repository as durable project memory and progressive context retrieval;
- explicit authority/promotion rather than conversation or agent output becoming binding;
- bounded research and implementation task contracts;
- context-isolated delegation and anti-anchoring;
- verification independent of agent confidence and Director code-reading;
- recoverable work-state expectations across agent/session replacement;
- escalation instead of silent architectural drift;
- evidence-gated complexity and mechanical guardrails for repeated failures.

Do not duplicate these as new policies.

## Gaps worth systematizing

### 1. Machine-discoverable root agent entrypoint

Add a small root `AGENTS.md` that points agents to current authority, active phase, task contracts, and verification rules. It should not duplicate project documentation and should grow only from recurrent failure evidence.

### 2. Stronger implementation-task completion semantics

Implementation work should distinguish verified completion from blocked/incomplete/escalated termination.

An implementation agent must not weaken or rewrite the acceptance mechanism that judges its work unless the task explicitly authorizes a specification/test change.

### 3. Isolation for concurrent mutation

Concurrent implementation agents should not edit the same working tree. Use isolated branches/worktrees/workspaces and an explicit reconciliation/verification step before integration.

Delegation must never increase authority beyond the parent task.

### 4. Executable repository sensors before substantive coding

Once implementation begins, root-discoverable build/test/static-analysis/verification commands and CI should turn important rules into executable facts.

Verification should cover three distinct surfaces as they become relevant:
- implementation/harness correctness;
- accepted simulation behavior/scenarios;
- runtime/final-state correctness of a particular task.

### 5. Expiry and garbage collection for AI-specific scaffolding

AI-specific process added to compensate for an observed model/tool limitation should identify:
- the failure it prevents;
- evidence that justified it;
- the condition under which it should be reconsidered or removed.

Obsolete or mechanically superseded instructions should be consolidated or retired rather than accumulating indefinitely.

This point requires governance-level approval before promotion.

## Deliberately not adopted now

Do not prebuild:

- custom compaction or memory infrastructure;
- agent graphs, persistent teams, mailboxes, or deep delegation;
- MCP/A2A infrastructure without an actual interoperability boundary;
- plugin/marketplace systems;
- self-learning or automatic policy/skill promotion;
- harness maturity scoring as a project target;
- full event sourcing/tombstones for agent work;
- elaborate behavioral-eval infrastructure before meaningful agent behavior exists.

Introduce these only when a concrete failure mode or workload earns their cost.

## Implementation-phase triggers

Before the first persistent coding packet:
1. accepted host/runtime and prototype specification exist;
2. root verification command(s) exist;
3. CI executes the canonical checks;
4. acceptance scenarios are protected from silent weakening;
5. mutating parallel agents, if used, are workspace-isolated;
6. completion reports include mechanical evidence.

## Source limits

The book and study reports are advisory evidence from a fast-moving 2026 agent-engineering ecosystem. Concrete vendor mechanisms, protocol versions, thresholds, filenames, and model-specific workarounds are not project rules unless independently justified here.
