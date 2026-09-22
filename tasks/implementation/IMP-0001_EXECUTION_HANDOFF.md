# IMP-0001 — Repair-v3 execution handoff

**LOCAL IMPLEMENTATION EVIDENCE COMPLETE / REMOTE RECEIPT REQUIRED / FRESH K4 REQUIRED**

Branch: `implementation/imp-0001-slice1-repair-v3`; draft [PR #23](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/23).

Base frozen candidate-v2: `ba16829e240950f1f3c648107cf3b8b36f996971`. Current-authority retrieval: origin/main `34989ee91d293971dcecf9837c76ddc3ad751424`. Start with current main's entry instructions and v3 packet; this repair branch does not merge unrelated governance updates.

Read [the v3 implementation report](IMP-0001_IMPLEMENTATION_REPORT.md) for B1/B2 mechanisms, Director ruling on future faults, interaction matrix, red/green evidence, authority identities and all 167 rows.

B1 projects full future input batches through maintenance without authoritative mutation or premature faults. B2 marks only witnessed consequential order participation, retaining actual stable-ID revalidation and atomic commit. Private transaction evaluation is shared with execution; independent oracles are separate.

Verified source checkpoint: `6b05b3c465925c06e92a6e696013cb504bb1f46c`; source/test/toolchain fingerprint `8c964599ccaf360bd0f389367e58745c3c02c0dd0f3b414d3932cdd85cc6a18e`. Local canonical commands pass: 62 scenarios / 1948 audited worlds / 127 coder-owned REQUIRED. Frozen acceptance remains byte-identical; S1-GLOBAL-CONFORMANCE is not satisfied by this report.

Final delivery must include the actual pushed head, its PR CI run/checkout and verified artifact. That receipt is generated after publication; do not infer it from historical v2 receipts below. If delivery is unavailable, the task report must state the specific access failure and retain the local commits.

After remote verification: **IMPLEMENTATION CANDIDATE COMPLETE / AWAITING INDEPENDENT CONFORMANCE**. Master Architect reconciles/freezes candidate-v3; another reviewer authored neither v2 nor v3 must perform K4. Keep PR #23 draft/unmerged. Preserve candidate-v1/v2, PR #7/#16, frozen authority and later-slice boundaries.

## Historical candidate-v2 handoff (retained verbatim)

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

Publication is complete through normal fast-forward Git push, following the Director's full-access permission change. Source checkpoint `c68d7d2c1721479a948d2ee11e1e20071949235c` passed canonical CI run `35771068979`; acceptance artifact `10713842986` was downloaded, its archive digest verified, and its evidence compared with the local run. All 127 coder-owned REQUIRED rows pass; classifications remain frozen. See the implementation report's publication receipt for links and digest. During implementation publication, the coder temporarily added this repair branch to the workflow's push triggers because no repair PR yet existed. The Master Architect subsequently opened draft PR #16 and removed that temporary branch-specific trigger before candidate-v2 freezing. Canonical CI therefore returns to the accepted `pull_request` plus `push: main` shape; PR #16 supplies exact-head remote CI.

This receipt updates only documentation. The final pushed receipt head, its exact-head CI and artifact are recorded in the task output delivery JSON after verification. Source identity remains `dda7edcbbf1951ac14dec1fb4d842a69da0c6bc4f201693e0941b3ffc5c8e573`. A report/evidence copy and Git bundle are available in the task outputs. The prior session access block is resolved; no implementation repair remains outstanding from the accepted F1–F3 plan.

Do not move candidate-v1, merge or modify PR #7, edit acceptance/specification authority, or infer `VERIFIED COMPLETE` from green implementation checks. The Master Architect must reconcile this return and freeze candidate-v2. Another reviewer must perform its independent K4 review. The implementing agent cannot award that PASS. SCF-002 remains active.


## Master Architect administrative normalization

After this implementation return, the Master Architect removed only the temporary repair-branch push trigger and corrected this handoff/report provenance. No production source, test semantics, acceptance mapping, frozen authority, or repair evidence was changed by that normalization. The final candidate-v2 SHA and exact-head PR CI are recorded by the later Master Architect freeze/reconciliation record; use that record rather than the coder publication receipt as the final candidate identity.
