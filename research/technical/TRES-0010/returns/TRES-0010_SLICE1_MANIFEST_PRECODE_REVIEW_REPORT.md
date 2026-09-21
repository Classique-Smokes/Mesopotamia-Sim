# TRES-0010 Slice-1 Acceptance Manifest Pre-Code Review Report

**Terminal result:** **BLOCK**  
**Review type:** independent pre-code adversarial review  
**Frozen baseline ref:** `tres-0010-manifest-review-baseline`  
**Frozen baseline SHA:** `3c3b58d95ef479fcbe93eb08a406388c119feab6`  
**Assigned return branch:** `tres-0010/manifest-precode-review`  
**Manifest path:** `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`  
**Manifest Git blob SHA:** `d3918bd616fa6f880d7621a62b4d7a073914e69f`

The named frozen baseline resolves to the supplied SHA. This review used the repository sources required by the packet at that frozen baseline and did not use chat history as semantic authority.

## 1. Decision

The candidate is close, but it is **not yet safe to freeze as IMP-0001 acceptance/applicability authority**.

Three defects remain blocking:

1. the cross-cutting provision-reconsideration cooldown boundary has no explicit Slice-1 status;
2. the protected-reserve wording in two manifest rows is broad enough to invent a general lower-level transfer reserve that is not present in accepted SPEC;
3. the D4 grain-term boundary is not frozen across the current in-scope grain-denominated action/proposal ingress routes, so an implementation can satisfy the row through one easy route while other invalid grain terms still reach response/effects.

The CallFavor applicability table itself is correct.

## 2. Manifest mechanics

Current manifest row audit:

| Item | Result |
|---|---:|
| Total AcceptanceIds | 158 |
| REQUIRED | 120 |
| DEFERRED | 32 |
| N-A | 3 |
| UNEXERCISED | 3 |
| Duplicate AcceptanceIds | 0 |
| Rows without an explicit status | 0 |

The manifest correctly keeps REQUIRED, DEFERRED, N-A, and UNEXERCISED visible as separate states. It also correctly requires zero missing/skipped REQUIRED rows, an immutable dispatch baseline, and a fresh post-implementation conformance review.

The Part L freeze fields exist but are intentionally unfilled in the pre-review candidate. That is not an independent blocker: they must remain unfilled while this review is BLOCK and be populated only after a corrected candidate passes a fresh rerun.

## 3. Missing / duplicate / mis-scoped rows

### BLOCK-1 — missing provision-reconsideration cooldown boundary classification

`CROSS_CUTTING_VERIFICATION_CONTRACT.md` has an explicit cooldown/periodic-timing boundary for provision reconsideration:

- before three full cycles;
- exactly three full cycles with no relevant context change;
- exactly three full cycles plus relevant context change.

The manifest has REQUIRED rows for attitude decay and debt due timing, and it has a DEFERRED household-provision boundary row, but that row is limited to “provision capacity/needs contributor boundaries.” It does not freeze the reconsideration-cooldown boundary.

This violates the packet requirement that every cross-cutting boundary group have an explicit frozen classification.

**Required repair:** add a distinct DEFERRED row, for example `S1-BND-PROVISION-RECONSIDERATION`, whose SourceClause explicitly contains the three accepted cooldown cases above and whose rationale states that provision reconsideration/head/household substrate is outside IMP-0001.

### BLOCK-2 — protected reserve is over-broadened beyond accepted semantics

Two rows are semantically overbroad:

- `S1-BND-RESERVE`: rationale = “Debt/transfer reserve”
- `S1-MUT-13A`: “penetrate protected personal reserve in Slice-1 debt/transfer feasibility”

Accepted SPEC does **not** define a general 2-grain reserve for ordinary Gift/Help/Loan/ExplicitBenefitForFavor/RelationshipMediatedReciprocalHelp transfers.

For Slice 1, the accepted lower-level 2-grain reserve is specifically the `RepayDebt` rule: repayment must leave the debtor with at least 2 grain. A separate protected reserve exists for later household provision through exposed capacity `max(0, grain - 2)`.

The current wording can lead a fresh implementation agent to impose a new reserve gate on ordinary transfers. The manifest’s general “SPEC wins” disclaimer does not cure an implementation-facing row that itself broadens expected behavior.

**Required repair:**

- rewrite `S1-BND-RESERVE` to state **RepayDebt debtor reserve only** for the REQUIRED Slice-1 boundary;
- rewrite `S1-MUT-13A` to “RepayDebt penetrates the accepted debtor reserve” (REQUIRED);
- rewrite `S1-MUT-13B` so the DEFERRED household-provision side explicitly covers both protected contributor reserve penetration and drawing from a `NeedsGrain` contributor;
- ensure no Slice-1 row implies a generic reserve on ordinary interpersonal transfers.

No social-semantic change is needed; this is a manifest narrowing to accepted SPEC.

### BLOCK-3 — D4 invalid-grain coverage is self-selectable by ingress route

`S1-BND-GRAIN-ACTION` currently says:

> negative / 0 / 1 / representative non-integral grain action amount

That freezes the numeric boundary but not the current action/proposal ingress routes to which the accepted SPEC invariant applies. SPEC says **every action parameter denominated in grain** is a strictly positive integer and invalid terms are rejected before target response.

As written, one easy action route can exercise the boundary and the AcceptanceId can be reported passed while another in-scope route accepts an invalid term. This is the packet’s “canonical name / one easy subcase” cheat in cross-cutting form.

**Required repair:** expand `S1-BND-GRAIN-ACTION` (or split it into stable companion AcceptanceIds) so the frozen matrix enumerates every current IMP-0001 grain-denominated semantic ingress, including:

- `OfferGift`;
- `RequestGiftOrHelp`;
- `OfferLoan`;
- `RequestLoan`;
- `RepayDebt`;
- the grain-denominated benefit term used by `OfferBenefitForFavor`;
- the grain-denominated benefit term used by `RelationshipMediatedReciprocalHelp`;
- `ProposeMarriage`’s proposed dowry term even on the direct bypass action shape, without implementing household-mediated marriage;
- `CallFavor(RepayDebt(...))`, proving an invalid inner repayment term is rejected before the called actor’s Fulfil/Refuse response.

For each route, zero/negative/non-integral terms must be rejected before target response/effects, while positive integral terms remain subject to their separate semantic/world-state gates. If the concrete C# boundary makes non-integral values unrepresentable by construction, the evidence may be structural at that typed boundary, but the ingress must still be explicitly classified and audited rather than silently omitted.

## 4. Semantic-authority review

Apart from BLOCK-2, the manifest remains subordinate to accepted semantic authority.

Confirmed:

- same-cycle direct attitude composition matches accepted D1 sum-then-clamp semantics;
- same-person Residence conflict matches accepted D2 central conflict/fallback semantics;
- called-favour failure/initiative/response closure matches accepted D3;
- repayment amount validity and invalid-term taxonomy match accepted D4;
- ExplicitBenefitForFavor atomicity and distinction from Gift/Help/RMRH match accepted D5;
- invalid proposal terms remain pre-interaction validation rejections, not a fourth social failed-attempt outcome;
- verification text does not override SPEC to let an explicit benefit-for-favour partially commit or silently become Gift/Help.

No other manifest row was found to invent, broaden, or replace accepted social semantics.

## 5. CallFavor table verdict

**CONFIRMED.**

Independent re-derivation from accepted SPEC yields exactly these current Slice-1 CALLABLE payload shapes:

1. `Farm`
2. `RepayDebt(debt, amount)`

Reasoning:

- `Farm` is self-contained after the called actor’s Fulfil/Refuse choice and does not require another voluntary response, manipulate another favour, establish marriage/kinship, or require household/role authority.
- `RepayDebt` is an ordinary unilateral action. It may affect a creditor, including a third party, but creditor acceptance is not a required new voluntary choice. Its grain term and debt/world-state preconditions still apply.

The current NON-CALLABLE classifications are also correct:

- Gift/help offer/request, loan offer/request, and Residence proposals require a further target response;
- `OfferBenefitForFavor` requires response and creates another favour;
- RMRH requires knowing acceptance and may create another favour;
- `CallFavor` would recurse into another favour response;
- reciprocal favour cancellation manipulates another favour;
- direct `ProposeMarriage` establishes marriage and preserves counterparty autonomy;
- response meanings/results are not payload actions;
- low-level `TransferGrain`/relation/effect helpers are not semantic action meanings.

General communication and household/role actions remain outside IMP-0001 and require no Slice-1 callable classification.

## 6. Scope-discipline findings

The candidate correctly keeps these out of the REQUIRED implementation path:

- household formation/identity/participation/head/provision/lineage;
- household-mediated marriage;
- general communication/recognition propagation;
- checkpoint/save-load;
- rendered explanation infrastructure;
- hidden-test service;
- generalized mutation platform;
- generated-history/shrinking infrastructure;
- generalized action/effect framework.

`VS-SFL-104` is correctly DEFERRED. Checkpoint cards `082`/`083` and rendered explanation card `087` are correctly DEFERRED. Generated/shrinking/held-out materialization is correctly visible as UNEXERCISED rather than converted into Slice-1 completion work.

Negative controls such as “Residence change creates no household identity/participation” must be satisfied without building household stubs; the manifest’s K2 rule correctly forbids faking later-slice semantics.

No separate scope-creep blocker was found.

## 7. Oracle-independence findings

**PASS, subject to the BLOCK-3 coverage repair.**

Part I correctly forbids production logic whose result is under judgment, including:

- candidate recognizers/generators;
- decision scorer/selector;
- target transition helper;
- CallFavor payload classifier;
- derived-capacity helper when capacity arithmetic is the assertion target;
- semantic classifier whose result is asserted.

The scoring oracle is correctly based on independently summing recorded named integer components. The CallFavor applicability oracle is correctly the frozen source-derived table rather than production `IsCallable(...)`.

Stable-ID fallback evidence is appropriately metamorphic/behavioral: repeatability, insertion-order permutation, disclosed fallback marker, and allowed ID-renaming sensitivity in explicit symmetric fallback cases. It does not need to call the production tie selector to predict a socially preferred winner.

The repaired D4 grain matrix must preserve the same independence rule: expected invalid/valid classifications come from SPEC, not from a production term validator reused as the oracle.

## 8. Adversarial cheat attempts

| # | Attack | Outcome |
|---|---|---|
| 1 | One test with canonical card name but only one easy subcase | **PARTIAL CHEAT SUCCEEDS.** Canonical 090–099 subcases are mostly protected by stable subcase IDs, but `S1-BND-GRAIN-ACTION` can currently be satisfied through one easy grain-term ingress. This is BLOCK-3. |
| 2 | Mark hard cross-cutting rows N-A without changing manifest | **BLOCKED.** Frozen statuses plus manifest-integrity/completion reporting prevent runtime reclassification. |
| 3 | Call production `IsCallable` from the CallFavor oracle | **BLOCKED.** Part I expressly forbids the production payload classifier under judgment. |
| 4 | Use low-level `TransferGrain` as a callable semantic action | **BLOCKED.** CallFavor source table and `S1-094-NONPAYLOAD-MATRIX` exclude implementation helpers/effect primitives. |
| 5 | Fake `VS-SFL-104` with household stubs | **BLOCKED.** `S1-104` is DEFERRED and K2 forbids faking later-slice semantics. |
| 6 | Make generated/held-out infrastructure mandatory | **BLOCKED.** generated/shrinking/held-out materialization rows are UNEXERCISED and explicitly off the Slice-1 completion path. |
| 7 | Let a REQUIRED row be skipped while CI stays green | **BLOCKED.** `S1-GLOBAL-REQUIRED-COVERAGE`, K3, and the completion rule make missing/skipped REQUIRED evidence a completion failure. |
| 8 | Change the manifest after dispatch to fit implementation | **BLOCKED.** `S1-GLOBAL-MANIFEST-INTEGRITY`, K1, K3, and post-implementation conformance require byte/version identity with the frozen dispatch baseline. |
| 9 | Make `InvalidProposal` a fourth social failed-attempt outcome | **BLOCKED.** Invalid terms/non-callable payloads are pre-interaction validation rejection; accepted failed-attempt outcomes remain Declined / Unable / InvalidatedAtResolution. A diagnostic label may not become a fourth social outcome. |
| 10 | Let verification prose override SPEC for explicit benefit-for-favour | **BLOCKED for BFF.** Required rows preserve SPEC atomicity, pre-response full-capacity Unable, post-acceptance capacity-loss Invalidated, and no Gift/Help relabel/effect. |

A separate semantic-authority attack did succeed outside the ten named probes: the current reserve wording can be read as adding a generic ordinary-transfer reserve. That is BLOCK-2.

## 9. Exact repair set before rerun

A corrected candidate must do all of the following and no more:

1. Add explicit DEFERRED classification for the provision-reconsideration cooldown boundary: before three full cycles; exactly three with no relevant context change; exactly three plus relevant context change.
2. Narrow `S1-BND-RESERVE` to the accepted Slice-1 `RepayDebt` debtor reserve. Do not impose a generic ordinary-transfer reserve.
3. Narrow `S1-MUT-13A` to debt-repayment reserve penetration, and make the DEFERRED household-provision mutant coverage explicitly include both contributor-reserve penetration and drawing from a `NeedsGrain` contributor.
4. Freeze the D4 invalid-grain matrix over every current in-scope grain-denominated semantic ingress listed in BLOCK-3, including malformed `RepayDebt` inside `CallFavor`, so no route can be silently omitted.
5. Re-run this independent pre-code review from a newly frozen corrected baseline. Do not fill freeze/acceptance metadata or dispatch IMP-0001 until that rerun returns PASS.

No SPEC/ADR semantic change is required by these repairs.

## 10. IMP-0001 progression statement

**IMP-0001 may not proceed to task hardening after this review.**

The manifest must be repaired only for the demonstrated defects above and the pre-code review must be rerun from a corrected frozen baseline. A later PASS may then authorize manifest freeze metadata/versioning and the next task-hardening step; this BLOCK does not authorize implementation dispatch.
