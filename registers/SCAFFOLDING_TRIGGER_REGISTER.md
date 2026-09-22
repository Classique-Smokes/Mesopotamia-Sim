# Scaffolding Trigger Register

**Purpose:** Preserve deferred AI-development scaffolding without loading it into routine project context.

Consult this register only when work changes agent workflow, tooling, CI, verification, delegation, or interoperability.

## Lifecycle

When a trigger fires, **implement, reject, or explicitly defer** the item. Once implemented, remove the reminder and let the actual configuration/test/policy become the durable authority. Git preserves the history.

## Triggers

### SCF-002 — Protected acceptance verification
- **Status:** FIRED / ACTIVE UNDER IMP-0001
- **Trigger fired:** 2026-09-22 — first executable Social Fabric Laboratory implementation dispatch.
- **Already protected:** `SFL-V0-S1-ACCEPTANCE-v1` remains frozen outside IMP-0001 at ref `sfl-v0-slice1-acceptance-v1`, with independent pre-code R2 PASS and a separate freeze record. IMP-0001 cannot edit/reclassify it.
- **Active completion obligation:** Build substantive executable/structural evidence mapped to every REQUIRED AcceptanceId, expose the manifest-indexed result report through canonical CI, preserve oracle/fixture restrictions, and obtain fresh independent post-implementation conformance PASS.
- **Bootstrap warning:** The dispatch scaffold acceptance smoke test is tooling evidence only and is deliberately not mapped to any AcceptanceId.
- **Retirement trigger:** Remove this reminder only after IMP-0001 completion evidence and independent conformance PASS make the executable acceptance configuration/report the durable authority.
- **Evidence:** `research/technical/HARNESS_ENGINEERING_STUDY_SYNTHESIS.md`; `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`; TRES-0010 R2 PASS report.

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
