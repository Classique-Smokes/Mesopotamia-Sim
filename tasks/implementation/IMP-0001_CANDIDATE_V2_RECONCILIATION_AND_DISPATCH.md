# IMP-0001 — Candidate-v2 Master Architect Reconciliation and K4 Dispatch

**Status:** RELEASED TO FRESH INDEPENDENT CONFORMANCE REVIEW
**Candidate-v2:** `imp-0001-slice1-conformance-candidate-v2` @ `ba16829e240950f1f3c648107cf3b8b36f996971`
**Previous failed candidate:** `imp-0001-slice1-conformance-candidate-v1` @ `7e11dab7697121eb0dbb169ba46210d81b80586e`
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1` / blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`

## 1. Identity and publication

- repair branch: `implementation/imp-0001-slice1-repair-v2`;
- repair PR: #16, draft/unmerged;
- exact normalized repair head: `ba16829e240950f1f3c648107cf3b8b36f996971`;
- exact-head canonical PR CI: run `35772625856`, SUCCESS;
- exact-head acceptance artifact: `10714762656`, `slice1-acceptance-evidence`;
- artifact digest: `sha256:6e0f87e00005b0bc946eec02684955616964b192c4b2ba4f6fcf3c5d5f8ab0f7`;
- frozen manifest blob on candidate-v2 remains exactly `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- PR #7 remains draft/unmerged at candidate-v1 SHA.

Candidate-v2 is nine commits ahead of candidate-v1 and contains only the accepted F1–F3 repair implementation/tests/evidence plus documentation and the post-return CI-trigger normalization. No SPEC/ADR/frozen-manifest change is present.

## 2. Master Architect repair reconciliation

### F1 — proposal-ID / same-cycle dependency disclosure

Repair-v2 adds a bounded accepted-proposal dependency analysis before resolution while retaining immediate current-state revalidation and atomic commit/failure. It does not introduce a new social/domain priority. The repair explicitly audits all current Slice-1 action shapes and classifies potentially interacting pairs/aggregate capacities; new regressions cover residence read/write dependencies, favour lifecycle/creation, marriage cardinality, debt remaining, grain/reserve and enabling-credit/Farm interactions, plus commuting/asymmetric controls.

The implementation still uses stable ProposalId order only as the existing technical fallback. The new analysis marks accepted proposals whose result can depend on that unresolved technical ordering. This is consistent with the accepted quarantine/disclosure contract and does not itself select a new social winner.

### F2 — missing needy reciprocal-request refusal consequence

Repair-v2 applies the already accepted requester→refuser `-5` cause to feasible voluntary refusal of `RelationshipMediatedReciprocalHelp(Request: true)` while preserving zero-effect Unable/Invalidated/no-need controls and called-favour-specific semantics.

The independent invariant oracle now derives mandatory attitude-cause membership from consequential history rather than accepting only whatever contributions production happened to record. Negative controls explicitly remove an expected cause and verify the checker rejects the witness.

### F3 — personal-agency subjective input boundary

Repair-v2 removes the objective `WorldSnapshot` from personal generation/gating/scoring. A single capture boundary builds immutable `PersonalDecisionInputs` from own state, direct-party facts/claims, and explicitly supplied bounded policy observations. Decision traces expose those inputs/provenance. Objective-only counterparty facts remain available to response/resolution/revalidation but no longer silently control personal deliberation.

The added observation bindings are a bounded Slice-1 laboratory input seam, not a persistent knowledge store, communication system, or recognition engine. Fresh K4 review must independently judge whether their use remains subordinate to accepted §6.4 semantics.

## 3. Evidence claims from repair author

The repair author reports:

- regression-first red evidence for all three original BLOCK classes;
- 57 named scenarios / 344 audited worlds;
- all 127 coder-owned REQUIRED rows PASS;
- no reclassification of DEFERRED/N-A/UNEXERCISED rows;
- no new social priority;
- exact SDK 10.0.401 canonical local command PASS;
- remote CI/artifact PASS.

These remain implementation claims, not independent conformance evidence.

## 4. Administrative normalization after repair return

The repair author temporarily added the repair branch to CI push triggers while publication access was being resolved. After draft PR #16 existed, the Master Architect removed that branch-specific trigger so the workflow returned to candidate-v1's canonical `pull_request` plus `push: main` shape.

That normalization and accompanying documentation edits changed no production source, tests, evidence mappings or frozen authority. Candidate-v2 was frozen only after the normalized exact head passed PR CI.

## 5. Release decision

**MASTER ARCHITECT RESULT: RELEASE TO FRESH INDEPENDENT K4 CONFORMANCE REVIEW.**

This is not VERIFIED COMPLETE and is not merge authorization.

`S1-GLOBAL-CONFORMANCE` remains REQUIRED and pending.

Candidate-v2 ref must not move. Any production/test/evidence-mapping change after this SHA invalidates candidate-v2 and requires a new candidate identity/review.

PR #16 and PR #7 remain draft/unmerged during review.
