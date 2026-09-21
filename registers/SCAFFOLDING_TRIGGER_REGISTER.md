# Scaffolding Trigger Register

**Purpose:** Preserve deferred AI-development scaffolding without loading it into routine project context.

Consult this register only when work changes agent workflow, tooling, CI, verification, delegation, or interoperability.

## Lifecycle

When a trigger fires, **implement, reject, or explicitly defer** the item. Once implemented, remove the reminder and let the actual configuration/test/policy become the durable authority. Git preserves the history.

## Triggers

### SCF-001 — Root verification sensors
- **Status:** ARMED — fire on IMP-0001 dispatch
- **Trigger:** First persistent prototype implementation.
- **Action:** Establish canonical root build/test/analyzer commands and CI that executes them. Required by `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`; dispatch is currently blocked by TRES-0010.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`

### SCF-002 — Protected acceptance verification
- **Status:** ARMED — fire on IMP-0001 dispatch
- **Trigger:** First executable Social Fabric Laboratory acceptance scenarios.
- **Action:** Prevent implementation agents from silently weakening the tests/graders/invariants that define completion; use independent or protected checks where consequence warrants. Required by `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`; dispatch is currently blocked by TRES-0010.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`

### SCF-003 — Concurrent workspace isolation
- **Status:** DEFERRED
- **Trigger:** Two or more agents need to mutate repository files concurrently.
- **Action:** Use isolated branches/worktrees/workspaces and explicit reconciliation plus verification before integration.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`

### SCF-004 — Behavioral agent evals
- **Status:** DEFERRED
- **Trigger:** Prompt/model/tool/harness behavior becomes a meaningful regression surface.
- **Action:** Add versioned behavioral scenarios for the specific failure classes that matter; do not create an eval platform preemptively.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`

### SCF-005 — Interoperability adapters
- **Status:** DEFERRED
- **Trigger:** First real MCP/A2A/external-harness or comparable integration boundary.
- **Action:** Keep protocol details behind a replaceable adapter/port and verify version/deprecation assumptions.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`

### SCF-006 — Scaffolding expiry review
- **Status:** DEFERRED
- **Trigger:** Major model/harness upgrade, or evidence that a recurrent agent failure has disappeared or become mechanically prevented.
- **Action:** Review affected AI-specific rules/process for consolidation or removal.
- **Evidence:** `governance/MASTER_ARCHITECT_GUIDE.md`

### SCF-007 — Automated learning/promotion controls
- **Status:** DEFERRED
- **Trigger:** The project considers automated extraction of reusable skills, rules, or project guidance.
- **Action:** Separate extraction from promotion authority; isolate curation/write paths and define rejection, provenance, supersession, and retirement rules before activation.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`
