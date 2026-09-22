# IMP-0001 — Repair-v2 execution handoff

**IMPLEMENTATION CANDIDATE COMPLETE / AWAITING INDEPENDENT CONFORMANCE**

**Branch:** `implementation/imp-0001-slice1-repair-v2`

**Base / preserved candidate-v1:** `7e11dab7697121eb0dbb169ba46210d81b80586e`

**Date:** 2026-09-22

**Authority:** Operational branch-local note, subordinate to accepted SPEC/ADRs, frozen acceptance and the accepted BLOCK repair packet/reconciliation.

Begin with `AGENTS.md`, `00_START_HERE.md` and current `origin/main:plans/CURRENT_PHASE.md`. The current repair packet and reconciliation were retrieved from `origin/main` at `a414e0f40615113db783538d2c7b8b0a384f5c87`; this branch intentionally starts at failed candidate-v1 and does not merge the later governance-only main commits.

Read the [repair implementation report](IMP-0001_IMPLEMENTATION_REPORT.md) for authority identities, all action-pair interactions, personal-input classification, red/green regression results, source/evidence hashes and the frozen AcceptanceId index. Original independent review reference: `8e56d6b2d4abe95febf7f0ccb37ccc316b879482`. The original report hash validates; its later compressed archive does not. Archive repair was not performed.

F1 adds accepted-proposal dependency and aggregate capacity analysis with disclosed stable-ID fallback, retaining immediate revalidation and compatible commits. F2 restores the needy reciprocal-request refusal cause and independently checks complete cause membership. F3 confines personal generation/gating/scoring to immutable own/direct-party/explicitly observed inputs and complete provenance traces. Existing score profiles and D1–D5 obligations remain intact.

Canonical local commands all pass with SDK 10.0.401: restore, format verification, Release build and tests. The acceptance surface executes 57 named scenarios / 344 audited worlds; 127 coder-owned REQUIRED rows PASS. The frozen manifest remains blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` at freeze `55377cc34b8bc3ccbf9cdf5029e9791dae965987`, with 167 IDs: 128 REQUIRED, 33 DEFERRED, 3 N-A, 3 UNEXERCISED. `S1-GLOBAL-CONFORMANCE` is still awaiting a fresh independent reviewer.

Publication is authorized directly to this repair branch, fast-forward only, without a new PR. It is currently blocked: native Git authentication cannot use the Windows credential store, and the GitHub connector rejects blob creation because approval is required while this session's policy is `never`. The remote repair branch remains at v1; there is no repaired-head CI run/artifact yet. See the report's publication receipt and task output delivery record. The workflow's only change is adding this branch to its existing push triggers.

Resume by pushing the existing local repair branch when authenticated Git or approved connector writes are available. Preserve any intervening remote work; never force-push. Wait for canonical CI on the exact resulting SHA, inspect logs and acceptance artifact, and verify 127 coder-owned REQUIRED passes plus the unchanged manifest classifications. A report/evidence copy and Git bundle are available in the task outputs; no implementation repair remains outstanding from the accepted F1–F3 plan.

Do not move candidate-v1, merge or modify PR #7, edit acceptance/specification authority, or infer `VERIFIED COMPLETE` from green implementation checks. The Master Architect must reconcile this return and freeze candidate-v2. Another reviewer must perform its independent K4 review. The implementing agent cannot award that PASS. SCF-002 remains active.
