# IMP-0001 — Candidate-v3 Master Architect Reconciliation and K4 Dispatch

**Status:** RELEASED TO FRESH INDEPENDENT CONFORMANCE REVIEW  
**Candidate-v3:** `imp-0001-slice1-conformance-candidate-v3` @ `06e25644879dd8505e24fcaeb43256f69c29c15f`  
**Previous failed candidates:** candidate-v1 `7e11dab7697121eb0dbb169ba46210d81b80586e`; candidate-v2 `ba16829e240950f1f3c648107cf3b8b36f996971`  
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1` / blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`

## 1. Identity and preservation

- repair branch: `implementation/imp-0001-slice1-repair-v3`;
- repair PR: #23, draft/unmerged;
- frozen candidate-v3 head: `06e25644879dd8505e24fcaeb43256f69c29c15f`;
- candidate-v3 is seven commits ahead of frozen candidate-v2;
- candidate-v1 and candidate-v2 refs remain unchanged;
- frozen acceptance ref remains `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- manifest blob on candidate-v3 remains exactly `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- PR #7, PR #16 and PR #23 remain draft/unmerged historical/current implementation lineages.

Candidate-v3 changes production only in the two repair-v3 seams: future material-recovery projection and technical-fallback dependency analysis. Additional changes are dedicated regressions and implementation evidence/documentation. No SPEC, ADR, frozen-manifest, public-schema, CI-trigger, dependency, or later-slice semantic change is present.

## 2. Remote verification identity

Candidate-v3 head is associated with canonical PR CI run `35787127702`, SUCCESS.

- workflow head SHA: `06e25644879dd8505e24fcaeb43256f69c29c15f`;
- actual PR checkout: synthetic merge `1f3f54cb750696d0bab26d2de2811e181700aead` with current main `34989ee91d293971dcecf9837c76ddc3ad751424`;
- all canonical restore → static-quality → build → test steps PASS;
- acceptance artifact: `10719823413`, `slice1-acceptance-evidence`;
- artifact digest: `sha256:031f21dc553dcf0bfff4b73f3bff764ff5a8dc1856d20493b164cc164c1268ca`;
- implementation evidence reports 62 scenarios / 1,948 audited worlds / all 127 coder-owned REQUIRED rows PASS.

The final candidate-v3 commit is documentation-only relative to the prior verified repair head. Production/test/toolchain content did not change after the repair evidence run; the final PR run also passed with the current main integration state.

The repair report's embedded publication receipt names the immediately preceding verified head `d7e28471705c3056eb11a3e0c9eb2a1267b5c158`. That is historical receipt metadata, not the final frozen candidate identity. This reconciliation record is the authoritative operational identity for candidate-v3 review.

## 3. B1 reconciliation — MaterialDeadlock recovery projection

Repair-v3 replaces the candidate-v2 “any future positive input exists” shortcut with deterministic projection of complete scheduled input batches through mandatory maintenance. Recovery is demonstrated only when the projected executable schedule reaches a later decision boundary with a producer no longer blocked by `NeedsGrain`.

The implementation preserves ordinary execution timing for future invalid inputs:

- projection is non-authoritative and emits no simulation events/state;
- an impossible future debit or checked overflow before recovery does not demonstrate recovery;
- the current cycle does not fault merely because the diagnostic discovers that future fault;
- actual execution still faults only when the offending scheduled cycle is reached.

This is consistent with accepted cycle ordering and diagnostic noninterference. Dedicated regressions cover cancelling batches, true recovery, split/cancelling batches, distant boundaries, impossible debit timing and overflow timing.

No rescue grain, future voluntary choice, or new future-validation subsystem was introduced.

## 4. B2 reconciliation — TechnicalFallback precision

Repair-v3 no longer turns coarse potential interaction into a fallback marker. It evaluates proposal-order participation inside bounded interacting components and marks a proposal only when order can change its own terminal result/effect or a consequential competing alternative for which it is causally relevant.

The candidate includes the exact debt-limited Farm counterexample from candidate-v2 review and broader constraint-intersection controls:

- debt cap tighter than grain/reserve;
- grain/reserve tighter than debt;
- both constraints independently relevant;
- genuine enabling credit/Farm participation;
- apparent enablers that commute because another semantic cap fixes the result;
- mixed ordinary/called repayment cases;
- proposal-ID permutations and reversed storage order.

The accepted stable-ID technical fallback remains the execution fallback where no semantic/domain priority distinguishes alternatives. Repair-v3 changes attribution/diagnosis, not social priority.

## 5. Regression and authority reconciliation

The candidate-v2 reviewer independently cleared the candidate-v1 repair areas. Repair-v3 retains and reruns those regressions rather than reopening their semantics.

The repair author reports:

- all coder-owned REQUIRED rows PASS;
- all frozen non-required classifications preserved;
- independent-oracle restrictions extended to cover new projection/transaction helpers;
- fixture/oracle audits retained;
- no weakened acceptance row;
- no new architecture or domain authority.

These remain implementation claims. Fresh K4 must independently re-derive conformance against the frozen authority and may use reviewer-owned public-boundary probes.

## 6. Release decision

**MASTER ARCHITECT RESULT: RELEASE TO FRESH INDEPENDENT K4 CONFORMANCE REVIEW.**

This is not `VERIFIED COMPLETE` and is not merge authorization.

`S1-GLOBAL-CONFORMANCE` remains REQUIRED and pending. Candidate-v3 ref must not move. Any production/test/evidence-mapping change after `06e25644879dd8505e24fcaeb43256f69c29c15f` requires a new candidate identity and new review.

PR #23 remains draft/unmerged during review.
