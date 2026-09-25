# SFL v0 Slice 4 — Successor Acceptance v2 Candidate1 Fresh Independent Pre-Code Review

**Review role:** independent assurance reviewer  
**Review date:** 2026-09-24  
**Authority:** advisory verdict only; accepted semantics, frozen manifests, candidate manifest and production code were not edited

## Exact review target

- candidate ref: `sfl-v0-slice4-acceptance-v2-candidate1`
- exact candidate commit: `473e521e1d64b3e001c386bf186eafba71c20f5f`
- exact candidate path: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2_CANDIDATE.md`
- exact candidate blob: `67008d03a943e6cd6a9a9e269be7c6efeefc229b`
- candidate version: `SFL-V0-S4-ACCEPTANCE-v2-candidate1`

The candidate ref resolves to the same reviewed blob above.

# Verdict

**BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT**

Candidate1 is mechanically clean, preserves frozen v1 exactly, preserves the inherited Slice-1/2/3 REQUIRED member sets exactly, and correctly adds omission-detectable coverage for DEC-0013 D1–D6 plus the current resource-scaffold architecture/nonclaim guardrails.

It is **not safe to freeze unchanged** because the successor manifest names accepted **DEC-0011** as current semantic authority but does not add omission-detectable REQUIRED acceptance coverage for DEC-0011's exact transaction-specific current-head private contribution `X` semantics.

This is not a new semantic question and not a reason to reopen DEC-0011. The missing behavior is already accepted in DEC-0011 and SPEC §8.1.1, and is already encoded in canonical verification cards `VS-SFL-047..049` plus cross-cutting mutant controls 36–42. The defect is that those semantics are not completion-gating through any status-bearing AcceptanceId in candidate1.

A successor candidate is required before freeze.

## 1. Independence and source discipline

This review was performed from the exact candidate commit, not from later `main` state or a future repair candidate.

Within this review task/context, I did not author candidate1, DEC-0013 promotion text, a future Slice-4 implementation, or the inherited-verification adaptation candidate/review. I did not edit accepted semantics, frozen manifests, candidate1, verification families, or production code.

Sources independently retrieved from the exact candidate state included:

- `AGENTS.md`
- `00_START_HERE.md`
- `governance/MASTER_ARCHITECT_GUIDE.md`
- accepted `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted DEC-0010, DEC-0011, DEC-0012 and DEC-0013
- frozen Slice-1/2/3 acceptance manifests and freeze records
- frozen Slice-4 v1 manifest and freeze record
- `research/technical/SFL_V0_SLICE4_SID_PASSB_RECONCILIATION.md`
- `research/technical/SFL_V0_SLICE4_SID_CLOSURE_REVALIDATION.md`
- `research/technical/TRES-0011/TRES-0011_MASTER_ARCHITECT_RECONCILIATION.md`
- preserved TRES-0011 A/B/C/D returns as needed for the v0/nonclaim boundary
- canonical verification families, especially `PROVISION_GROUNDING_FAMILY.md`, `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`, `RESOLUTION_REACTION_FAMILY.md`, and `CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- the exact candidate manifest

Research/reconciliation material was treated as advisory/contextual where applicable. Accepted SPEC/decisions and frozen acceptance authority controlled.

## 2. A — Mechanical manifest integrity: PASS

Mechanical parsing of the exact candidate produced:

- **173 total unique AcceptanceIds**
- **162 REQUIRED**
- **9 DEFERRED**
- **2 UNEXERCISED**
- **0 duplicate AcceptanceIds**

The candidate contains exactly 12 status-bearing rows not present in frozen v1:

- `S4-176` through `S4-187`

The exact inherited frozen REQUIRED expansion matches the frozen manifests one-for-one:

- Slice 1: **128 / 128**
- Slice 2: **46 / 46**
- Slice 3: **96 / 96**
- total: **270**

The manifest blobs present at the exact candidate commit are identical to their immutable frozen refs:

- Slice 1: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- Slice 2: `e4872531cf780d51fa1863f2a0b87e2424a71b69`
- Slice 3: `1aae13dc27572361fe99c31ef8aee0444d39364a`
- Slice-4 v1: `7edff7a0507d68037979b3b5e458864f1f8d6518`

No frozen Slice-1/2/3 status/text has been edited or reclassified.

**A result: PASS.**

## 3. B — Frozen v1 preservation: PASS

Frozen v1 contains **161** status-bearing Slice-4 rows.

Every frozen-v1 AcceptanceId exists in candidate1 with the same status and the same full status-bearing row bytes. Mechanical comparison found:

- dropped v1 rows: **0**
- changed/reworded v1 rows: **0**
- reclassified v1 rows: **0**

Candidate1 therefore preserves the complete historical v1 acceptance row set exactly while adding its 12 successor rows.

**B result: PASS.**

## 4. C — DEC-0013 D1–D6 fidelity: PASS, subject to the separate DEC-0011 acceptance blocker in §7

The six accepted DEC-0013 choices are represented without semantic escalation.

### D1 — Household provision versus RepayDebt

`S4-176-REPAYDEBT-LOWER-MATERIAL-PRIORITY` preserves:

- eligible NeedsGrain Household support above other valid Household provision expenditure;
- both above `RepayDebt` in the bounded shared-personal-grain conflict;
- ordinary repayment revalidation afterward;
- debt claim/due-cycle meaning preserved;
- explicit non-historical/legal/moral boundary.

This is compatible with the existing `S4-089` and inherited repayment semantics rather than replacing them.

### D2 — snapshot-bound appointment/succession cohort

`S4-177-SNAPSHOT-BOUND-SUCCESSION-COHORT` binds the unanimity cohort to the common committed decision snapshot, excludes later same-cycle entrants from retroactive membership, and retains live eligibility revalidation for captured members.

The associated no-automatic-recognition negative space remains covered by existing `S4-038`, `S4-031`, `S4-141`, and the Recognition acquisition rules: becoming a participant later does not itself grant knowledge/Recognition of the role transition.

### D3 — head as eligible Household-support recipient

`S4-178-HEAD-SUPPORT-RECIPIENT` correctly permits the current head to be the eligible needy support recipient through the proactive Household topology while forbidding P→P support request/response theatre, keeping authorizer and beneficiary capacities distinct, and preserving the non-organizational-evidence rule.

The current `NeedsGrain` resource restrictions are accepted semantics. Their private-`X` aspect is not separately acceptance-gating in this candidate because of the broader DEC-0011 omission identified in §7; the repair there must include this alias negative.

### D4 — head own persistent v0 provision commitment

`S4-179-HEAD-SELF-PROVISION-COMMITMENT` preserves:

- otherwise-eligible current head may explicitly authorize their own persistent v0 commitment;
- private-resource consent remains distinct from office;
- office occupancy alone creates nothing;
- no P→P response theatre;
- no extra initiative merely to represent the second capacity;
- ordinary cooldown/termination/provenance semantics remain.

### D5 — self-nomination

`S4-180-SELF-NOMINATION-MULTICAPACITY` omission-detectably preserves the three aliased predicates:

1. nomination;
2. nominee willingness;
3. that actor's participant acceptance.

Other participants remain separately required. Existing `S4-004`, `S4-006`, `S4-009`, and `S4-010` preserve their acceptance/recognition and evidence requirements.

### D6 — inert Inactive-H role fill

`S4-181-INACTIVE-ROLE-FILL-INERT` permits the sole sustaining participant of an Inactive H to fill the vacant persistent role without reactivation or Household-mode initiative, and preserves the occupied role through later reactivation.

Existing nonparticipant-nominee and no-Inactive-H-context rows prevent an unsupported different-person/operational path.

**C result: PASS for DEC-0013 D1–D6 choice coverage.**

## 5. D — Resource-scaffold guardrail fidelity: PASS

Candidate1 makes the current Slice-4 guardrails omission-detectable:

- `S4-182` — synthetic v0 / non-historical/future-economy boundary;
- `S4-183` — one authoritative live funding-resolution result used by precommit/commit/history;
- `S4-184` — typed source/authority/debit funding provenance;
- `S4-185` — dependency/resolver material-participation consistency without allocator rediscovery;
- `S4-186` — `MobilizableCapacity(H)` derived/rebuildable/non-authoritative and excluding transaction-specific private `X`;
- `S4-187` — resource state does not define Household identity, sustaining participation, role identity/occupancy, or Recognition identity.

These rows match DEC-0013/TRES-0011 guardrails without requiring a future asset/property/ledger architecture.

**D result: PASS.**

## 6. E — No overpromotion of TRES-0011: PASS

The candidate does not promote the future scientific/resource-redesign gates into current Slice-4 implementation obligations.

In particular it does **not** require current implementation of:

- the later resource-regime sensitivity/structural-variant package;
- a mature historical/economic Household resource redesign;
- generic asset/property/ledger/settlement architecture.

Instead, it keeps the present resource mechanism explicitly synthetic and v0-scoped and places generic economy/property architecture outside current Slice 4.

This matches DEC-0013's distinction between current implementation guardrails and later observation-driven hardening/redesign gates.

**E result: PASS.**

## 7. F — Existing Slice-4 whole-candidate completeness: BLOCK on DEC-0011 exact private-X semantics

The inherited v1 domains remain present and internally coherent:

- role identity/vacancy/succession;
- head Recognition and objective/subjective separation;
- dual personal/Household contexts;
- provision acquisition/reconsideration;
- Household support/dowry/mediated marriage;
- DEC-0010 authority-use precedence;
- material invariants/provenance;
- stable closure/fallback/locality/observer controls;
- deliberate deferrals/exclusions.

The blocking problem is a **post-v1 accepted semantic layer that v1 could not have contained**.

### 7.1 Why frozen v1 cannot supply DEC-0011 coverage

Frozen v1's semantic-authority header names DEC-0010 but not DEC-0011. Candidate1 correctly updates its own semantic-authority header to include DEC-0011 and DEC-0013.

Candidate1 also says it inherits every v1 AcceptanceId unchanged and adds only post-v1 obligations required by DEC-0013.

Mechanically, that is what happened: the only new status-bearing rows are `S4-176..187`, comprising the six DEC-0013 choices and six resource-scaffold guardrail rows.

Therefore exact DEC-0011 transaction semantics are neither inherited from v1 nor newly mapped as REQUIRED acceptance obligations.

### 7.2 What accepted DEC-0011 / SPEC §8.1.1 requires

Accepted semantics require, among other things:

- an optional transaction-specific current-head private contribution term `X`;
- absent term means no contribution;
- present `X` is an exact strictly positive integer with `X <= C`;
- current role authority and private-resource authorization remain distinct;
- current disposable private capacity must support `X`;
- exact residual requirement `R = C - X`;
- valid commitments fund exactly `R` under the existing fixed-rank allocator;
- partial `X`, shortfall supplementation, and full private funding are valid where their ordinary gates hold;
- `X` is a fixed transaction term, not a global source-priority contest;
- `X` creates no persistent commitment or standing `MobilizableCapacity`;
- if the same head also has a standing commitment, that person's commitment-side effective capacity is reduced by `X` before allocating `R`;
- no grain unit may be double-counted across the private and commitment-backed channels;
- the agreed split revalidates exactly at commit and is not silently shrunk, increased, auto-rebalanced, rebound to a successor, or renegotiated in-cycle;
- protected reserve / `NeedsGrain` still limit private-`X` capacity;
- no extra personal initiative, self-response context, Gift/Help/Loan/favour-bearing personal action, ordinary-transfer attitude effect, or independent organizational evidence is created by the supplement;
- funding/history preserves the distinct private and commitment-backed provenance legs.

The canonical verification design already expresses these accepted semantics in:

- `VS-SFL-047 — Transaction-specific holder funding plan`;
- `VS-SFL-048 — Same holder commitment plus private contribution cannot double-count grain`;
- `VS-SFL-049 — Private supplementation provenance is not a second personal transfer`;
- cross-cutting mutant controls 36–42.

### 7.3 Why candidate1's new resource rows are insufficient

The candidate mentions private `X` in guardrail/provenance rows, but those rows do not require the exact DEC-0011 behavior above.

Examples:

- `S4-184` requires typed provenance sufficient to distinguish a private current-holder leg, but it does not require the accepted no-`X` / partial-`X` / shortfall / full-`X` funding-plan cases or exact `R=C-X`.
- `S4-186` correctly says transaction-specific `X` is excluded from standing `MobilizableCapacity`, but it does not require a valid transaction-specific `X` path at all.
- `S4-183` ensures one authoritative funding-resolution point, but it does not define the accepted funding arithmetic that point must implement.
- `S4-160` prohibits double debit, but DEC-0011 additionally requires that the same head grain not be **double-counted for feasibility/allocation** through unreduced commitment capacity.
- `S4-060` prevents office seizure of personal grain, but it does not prove the accepted explicit private-consent route or its exact transaction behavior.

Consequently, an implementation could reject all explicit `X` terms, support only one subset such as full-private funding, silently rebalance the agreed `X`/commitment split, or evaluate same-head commitment capacity without the required transaction-local `X` reduction, while still satisfying the manifest's current status-bearing rows unless a non-manifest canonical card happened to be enforced independently.

That is exactly the omission-detectability failure this successor manifest exists to prevent.

### 7.4 D3 alias consequence

The same omission leaves one important D3 negative insufficiently acceptance-gated: when the current head is the `NeedsGrain` support recipient, accepted semantics say that person exposes neither private-`X` capacity nor commitment-side exposed capacity under the current scaffold.

`S4-081` covers zero exposed commitment capacity for `NeedsGrain`; the missing DEC-0011 acceptance coverage must also bind the private-`X` half.

**F result: BLOCK.**

## 8. G — Inherited-verification adaptation gate: PASS

`S4-170..175` are byte-for-byte unchanged from frozen v1 and remain a separate mandatory pre-implementation gate.

Candidate1 does not prematurely approve the adaptation plan. Its handoff sequence correctly requires:

1. successor acceptance review/freeze first;
2. then adaptation reassessment against accepted DEC-0013 + frozen successor acceptance;
3. then fresh independent adaptation review;
4. only after adaptation closure may the implementation block be closed.

**G result: PASS.**

## 9. H — Implementation handoff safety: PASS

Candidate1 correctly states that:

- it is a candidate, not frozen authority;
- implementation remains blocked;
- fresh whole-candidate PASS must precede successor freeze;
- inherited adaptation is reassessed only after successor acceptance freeze;
- fresh independent adaptation review remains required;
- no coding bārû is authorized by this review alone.

Because this review is BLOCK, candidate1 must be preserved and a repaired successor candidate reviewed afresh.

**H result: PASS.**

## 10. Smallest exact repair

No new Director semantic decision is required.

Preserve candidate1 and all frozen v1 rows unchanged. Create a new successor candidate that adds **REQUIRED AcceptanceId coverage for the already-accepted DEC-0011 exact transaction-specific private-`X` semantics**.

The smallest non-inventive repair should bind the existing canonical semantics represented by `VS-SFL-047..049` and cross-cutting mutants 36–42, including at minimum:

1. **Exact transaction funding plan** — absent/valid/invalid `X`, partial/shortfall/full-private cases, distinct role/private consent, exact `R=C-X`, protected-reserve/`NeedsGrain` boundary, no persistent standing capacity/commitment from `X`.
2. **Same-head commitment + X arithmetic** — transaction-local reduction of the head's commitment-side capacity by exact `X`, no feasibility double-count, correct fixed-rank allocation over residual capacities, and atomic failure when combined live capacity is insufficient.
3. **Exact-term / non-transfer semantics** — no silent shrink/increase/auto-rebalance, no successor rebinding, no extra personal initiative or self-response, no Gift/Help/Loan/favour/ordinary-transfer side meaning, no formation/participation/continuity/lineage evidence, and preserved distinct funding provenance.

The repair should also update the candidate's controlling prose so it no longer implies that DEC-0013 is the only post-v1 acceptance addition, and update the census accordingly.

Then run a new fresh whole-candidate pre-code review against the exact repaired candidate.

No accepted semantic artifact, frozen v1 row, frozen prior-slice manifest, production code, or adaptation plan needs to change for this repair.
