# SFL v0 — Slice 1 Successor Acceptance Manifest v2

**Status:** FROZEN SUCCESSOR ACCEPTANCE AUTHORITY  
**Authority class:** Verification/completion authority subordinate to accepted simulation semantics and architecture  
**Owner:** Master Architect / independent verification authority, not IMP-0001 implementer  
**Semantic authority:** current `SPEC-SFL-0001`, accepted ADRs/decisions through DEC-0015  
**Verification sources:** canonical Stage-3 SFL v0 verification package  
**Scope:** IMP-0001 — lower-level social-fabric reference kernel only  
**Manifest version:** `SFL-V0-S1-ACCEPTANCE-v2`  
**Historical predecessor:** `SFL-V0-S1-ACCEPTANCE-v1` / `sfl-v0-slice1-acceptance-v1` remains immutable evidence

> This manifest identifies which accepted verification obligations count for Slice 1 and what evidence is required. It does **not** create or restate social semantics. If a manifest row appears to conflict with accepted semantic authority, the semantic authority wins and the manifest must be corrected before code is dispatched.

## 1. Successor freeze prerequisites — satisfied

This frozen successor exists because DEC-0015 materially extends current inherited Slice-1 authority after historical v1 completion.

Prerequisites:

1. frozen v1 remains byte-identical and immutable at `sfl-v0-slice1-acceptance-v1`;
2. DEC-0015 is accepted and promoted into current SPEC + canonical verification;
3. `research/technical/DEC-0015_PROMOTION_RECONCILIATION.md` is COMPLETE / PASS;
4. `research/technical/SID_RETRO_SLICE1_CLOSURE_REVALIDATION.md` records 0 consequential semantic unresolved / 0 accidental semantic gaps;
5. the reviewed candidate preserves every frozen-v1 status-bearing row byte-for-byte and adds only omission-detectable DEC-0015 completion authority;
6. fresh independent whole-candidate review returned **PASS — MAY FREEZE UNCHANGED**.

This frozen successor does not alter the historical IMP-0001 completion claim.

## 2. Status meanings

- **REQUIRED** — IMP-0001 cannot be `VERIFIED COMPLETE` without accepted evidence for this row; required rows may not be missing or skipped.
- **DEFERRED** — accepted project obligation deliberately assigned to a later slice because required substrate is outside IMP-0001.
- **N-A** — no applicable Slice-1 claim. Rationale required.
- **UNEXERCISED** — recognized verification-hardening item not required for Slice-1 completion; must remain visibly unexercised rather than reported as passed.

## 3. Evidence rules

For every REQUIRED row, completion evidence must identify:

- `AcceptanceId`;
- executable test/audit/report reference;
- pass/fail/skip state;
- manifest version/SHA;
- relevant configuration/profile version where applicable.

A test name containing a scenario ID is not sufficient evidence by itself. The independent conformance review must verify that the executable evidence actually covers the cited source clause/subcase and uses an admissible oracle.

## 4. Manifest schema

| Field | Meaning |
|---|---|
| AcceptanceId | Stable Slice-1 completion ID independent of test method/class name |
| Source | Canonical verification artifact/card/section |
| SourceClause | Exact subcase/assertion/boundary covered |
| SliceStatus | REQUIRED / DEFERRED / N-A / UNEXERCISED |
| EvidenceKind | Executable card, boundary pair/matrix, metamorphic pair, mutant control, structural audit, fixture audit, dependency audit, completion-report check |
| OracleBasis | Hand-authored fact, simple arithmetic, recorded event/provenance, metamorphic equality, structural rule |
| ForbiddenProductionDependencies | Production helpers the oracle may not call when their output is under judgment |
| CompanionRefs | Other manifest rows that must accompany this claim |
| Rationale | Why this status applies to Slice 1 |
| EvidenceRef | Filled by IMP/completion process; blank before implementation |

### 4.1 Inherited row fields

To keep the manifest readable without weakening specificity:

- **OracleBasis** defaults to the cited canonical card's hand-authored expected fact, simple arithmetic, recorded semantic event/provenance, or declared metamorphic relation.
- **ForbiddenProductionDependencies** inherit Part I and narrow automatically to the helper/classifier/scorer/transition output under judgment.
- **FixturePolicy** inherits Part J unless a source card narrows it further.
- **EvidenceRef** is intentionally blank before implementation and must be populated in the completion report.
- **CompanionRefs** are frozen in Part H1 below for the cross-cutting semantic repair bundles; ordinary card rows inherit their source family's existing companion controls.

# PART A — Canonical lower-level cards

## VS-SFL-090 — Consumption / Need / Farm

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-090-A | successful consumption | REQUIRED | executable card | Slice-1 maintenance |
| S1-090-B | missed consumption creates NeedsGrain | REQUIRED | executable card | Slice-1 maintenance |
| S1-090-C | NeedsGrain blocks Farm | REQUIRED | executable card | Slice-1 Farm gate |
| S1-090-D | need clearing at next 1-grain unit; no same-cycle reactivation | REQUIRED | executable card | Slice-1 maintenance/activation |
| S1-090-E | Farm commits +4 with explicit source/history | REQUIRED | executable card | Slice-1 action |

## VS-SFL-091 — Explicit transfer meanings

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-091-GIFT | OfferGift accepted route | REQUIRED | executable card | Slice-1 transfer meaning |
| S1-091-HELP | RequestGiftOrHelp accepted route | REQUIRED | executable card | Slice-1 transfer meaning |
| S1-091-LOAN-OFFER | OfferLoan accepted route | REQUIRED | executable card | Slice-1 debt creation |
| S1-091-LOAN-REQUEST | RequestLoan accepted route | REQUIRED | executable card | Slice-1 debt creation |
| S1-091-BFF-POS | ExplicitBenefitForFavor positive-capacity atomic commit | REQUIRED | executable card | Director-approved D5 |
| S1-091-RMRH | RelationshipMediatedReciprocalHelp positive route and explicit history meaning | REQUIRED | executable card | Slice-1 transfer/favour semantics |
| S1-091-MEANING-SEPARATION | material path sharing never collapses Gift/Loan/BFF/RMRH meanings | REQUIRED | structural + executable audit | Core lower-level invariant |

## VS-SFL-092 — Debt

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-092-PARTIAL | partial repayment | REQUIRED | executable card | Slice-1 debt |
| S1-092-AMOUNT-VALIDITY | repayment 0/negative/non-integral/over-remaining rejected before response; remaining amount valid | REQUIRED | boundary matrix | Director-approved D4 |
| S1-092-RESERVE | semantically valid repayment that penetrates reserve is Unable and has no social refusal effect | REQUIRED | boundary card | Slice-1 debt feasibility |
| S1-092-FULL | full repayment satisfies claim and retains history | REQUIRED | executable card | Slice-1 debt |
| S1-092-DUE | N+3 before/at/later social-due one-shot penalty | REQUIRED | temporal boundary | Slice-1 debt timing |

## VS-SFL-093 — Favour creation/cardinality

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-093-BFF-POS | explicit bargain positive-capacity creation | REQUIRED | executable card | Slice-1 favour |
| S1-093-RECIP-74 | reciprocal-help stored attitude +74 no favour | REQUIRED | boundary matrix | ASM-0001 gate |
| S1-093-RECIP-75 | reciprocal-help stored attitude +75 may create favour | REQUIRED | boundary matrix | ASM-0001 gate |
| S1-093-RECIP-76 | reciprocal-help stored attitude +76 may create favour | REQUIRED | boundary matrix | ASM-0001 gate |
| S1-093-KIN-GATE | kinship amplification cannot satisfy +75 stored-attitude gate | REQUIRED | boundary/control | Lower-level invariant |
| S1-093-GIFT-CONTROL | genuine Gift creates no favour | REQUIRED | causal control | Meaning separation |
| S1-093-BFF-FULL | explicit BFF at already-full pair capacity -> Unable; no response/material/new favour | REQUIRED | boundary card | Director-approved D5 |
| S1-093-BFF-RACE | BFF capacity free at acceptance then lost before commit -> Invalidated; no partial commit | REQUIRED | conflict card | Director-approved D5 |
| S1-093-RMRH-FULL | RMRH may commit at full pair capacity while no second favour is created | REQUIRED | contrast card | Director-approved D5 distinction |

## VS-SFL-094 — Called favour

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-094-FARM-CALLABLE | Farm is a valid response-closed payload when otherwise feasible | REQUIRED | executable card | Mechanical CallFavor applicability |
| S1-094-REPAY-CALLABLE | RepayDebt is a valid response-closed payload when terms/world state are valid | REQUIRED | executable card | Mechanical CallFavor applicability |
| S1-094-PERSONAL-COEXIST | callable fulfilment coexists with already selected ordinary personal initiative without a second personal-initiative charge | REQUIRED | process card | Director-approved D3 |
| S1-094-NONCALLABLE-MATRIX | every current NON-CALLABLE Slice-1 semantic action shape is rejected before called-actor response | REQUIRED | table-driven boundary test | Prevent coding-agent payload interpretation |
| S1-094-NONPAYLOAD-MATRIX | response/result/internal-effect helper shapes cannot be used as payload types | REQUIRED | structural/table-driven test | Protect semantic action boundary |
| S1-094-UNABLE | valid callable payload world-infeasible -> Unable; favour remains; no +/- called-favour effect | REQUIRED | failure contrast | Director-approved D3 |
| S1-094-DECLINE | valid feasible payload voluntarily refused -> Declined; favour remains; -20 | REQUIRED | executable card | Director-approved D3 |
| S1-094-INVALIDATED | fulfil selected then action-relevant precondition lost -> Invalidated; favour remains; no +/- called-favour effect | REQUIRED | conflict card | Director-approved D3 |
| S1-094-SUCCESS | requested action commit consumes favour and applies +10 exactly then | REQUIRED | executable card | Director-approved D3 |
| S1-094-NESTED-GUARD | no accepted callable payload opens another ResponseDecisionContext | REQUIRED | structural + executable audit | Director-approved D3 |
| S1-094-RECIP-CANCEL | reciprocal outstanding favours may cancel atomically | REQUIRED | executable card | Existing favour lifecycle |

### CallFavor applicability source table

Current Slice-1 **CALLABLE** payload shapes:

- `Farm`
- `RepayDebt(debt, amount)`

Current Slice-1 **NON-CALLABLE** semantic action shapes:

- `OfferGift`
- `RequestGiftOrHelp`
- `OfferLoan`
- `RequestLoan`
- `OfferBenefitForFavor`
- `RelationshipMediatedReciprocalHelp`
- `CallFavor`
- reciprocal favour cancellation
- direct mutual-strong-like `ProposeMarriage`
- Residence move proposal
- Residence invite proposal

Response meanings/results and internal mutation/effect helpers are not payload actions. General communication and household/role actions are outside Slice 1.

## VS-SFL-095 — Direct marriage bypass

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-095-POS | mutual strong-like direct marriage positive route | REQUIRED | executable card | Slice-1 direct marriage |
| S1-095-74 | one direction +74 blocks bypass | REQUIRED | boundary card | Stored attitude gate |
| S1-095-KIN | parent/child or siblings never marry | REQUIRED | categorical control | Slice-1 invariant |
| S1-095-LIFETIME | established v0 marriage blocks second establishment; rejection does not consume eligibility | REQUIRED | cardinality boundary | Slice-1 invariant |
| S1-095-NO-RESIDENCE | direct marriage alone does not move residence | REQUIRED | causal control | Relation separation |

## VS-SFL-096 — Residence

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-096-MOVE | accepted move proposal changes only Residence relation as specified | REQUIRED | executable card | Slice-1 residence |
| S1-096-INVITE | accepted invite route | REQUIRED | executable card | Slice-1 residence |
| S1-096-COMPETE | two independently accepted same-person Residence changes -> exactly one commit + explicit invalidation | REQUIRED | conflict card | Director-approved D2 |
| S1-096-NO-HH | residence change alone creates/removes no household participation/identity | REQUIRED | causal control | Foundational invariant |
| S1-096-MARRIAGE-CONTROL | marriage alone does not move residence | REQUIRED | causal control | Relation separation |

## VS-SFL-097 — Attitude

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-097-EVENTS | every fixed v0 event update independently exercised | REQUIRED | executable matrix | Slice-1 relation dynamics |
| S1-097-SAT | single direct update saturates at +/-100 | REQUIRED | boundary card | Attitude bound |
| S1-097-DIRECT-BATCH-POS | +95 with +10 and -20 -> one sum-then-clamp result +85; both causes retained | REQUIRED | causal arithmetic card | Director-approved D1 |
| S1-097-DIRECT-BATCH-NEG | equivalent mixed-sign negative-bound case | REQUIRED | causal arithmetic card | Director-approved D1 |
| S1-097-DECAY | before/at/after 5-cycle decay; no zero crossing | REQUIRED | temporal boundary | ASM-0002/0007 |

## VS-SFL-098 — Initiative accounting

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-098-CORE | one personal voluntary initiative; responses do not consume/grant; multiple responses allowed | REQUIRED | process card | Core Slice-1 agency |
| S1-098-CALLFAVOR-INIT | voluntary CallFavor initiation consumes holder's normal personal initiative | REQUIRED | process card | Director-approved D3 explicit wording |
| S1-098-COMMUNICATION | Communication-specific initiative example | DEFERRED | — | General communication/claim propagation explicitly outside IMP-0001 |

## VS-SFL-099 — Scoring-domain relationship checks

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-099-KIN | exact 1.5x kin attitude-component amplification; stored attitude/gates unchanged | REQUIRED | closed-loop scoring | Slice-1 scorer |
| S1-099-CORES | marriage co-residence incentive > strong mutual positive incentive; no forced move | REQUIRED | closed-loop scoring | Slice-1 co-residence motivation |


## VS-SFL-107 — Participant self-alias and relation-diagonal classification

| AcceptanceId | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-107-SELF-COUNTERPARTY | current Gift/Help/Loan/BFF/RMRH self-counterparty proposals + CallFavor self-call reject before response with no social/material effect | REQUIRED | table-driven boundary matrix | DEC-0015 D1 current interaction boundary |
| S1-107-ATTITUDE-DIAGONAL | Attitude(P,P) valid, addressable, bounded and maintained/decayed normally without authorizing self-counterparty actions | REQUIRED | executable relation boundary | DEC-0015 D2 allowed diagonal |
| S1-107-DEBT-DIAGONAL | diagonal Debt rejected at current semantic ingress; no due/repay/social effects | REQUIRED | boundary + structural audit | DEC-0015 D2 current non-enabled diagonal |
| S1-107-FAVOUR-DIAGONAL | diagonal Favour rejected at current semantic ingress; no call/consume/social effects | REQUIRED | boundary + structural audit | DEC-0015 D2 current non-enabled diagonal |
| S1-107-VALID-ALIAS-CONTROLS | personal-action+response, multiple-response/shared-source, and valid CallFavor/RepayDebt cross-claim aliases remain supported | REQUIRED | contrast/regression matrix | Prevent over-broad all-roles-distinct repair |
| S1-107-GENERIC-RELATION-SEAM | generic relation substrate imposes no universal endpoint inequality; type-specific rules distinguish Attitude from Debt/Favour | REQUIRED | structural + executable mutant audit | Preserve future typed-relation diagonal seam |

# PART B — Response cards

| AcceptanceId | Source | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|---|
| S1-100 | VS-SFL-100 | feasible Accept vs Decline is target policy | REQUIRED | paired closed-loop run | Slice-1 response autonomy |
| S1-101 | VS-SFL-101 | infeasibility precedes Accept preference | REQUIRED | failure control | Slice-1 response semantics |
| S1-102 | VS-SFL-102 | called-favour fulfil/refusal + invalid payload + Unable/Invalidated controls | REQUIRED | closed-loop response | Director-approved D3 |
| S1-103-GRAIN | VS-SFL-103 | two accepted scarce-grain responses, one commit/one invalidation | REQUIRED | conflict card | Central resolution |
| S1-103-RESIDENCE | VS-SFL-103 companion | two accepted same-person Residence contenders | REQUIRED | conflict card | Director-approved D2 |
| S1-104 | VS-SFL-104 | role-scoped household-mediated response | DEFERRED | — | Requires Active Household/head/mediated-marriage substrate outside Slice 1 |
| S1-105 | VS-SFL-105 | personal initiative plus incoming response | REQUIRED | closed-loop process | Response does not consume personal initiative |

# PART C — Resolution / failure / reaction cards

| AcceptanceId | Source | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|---|
| S1-070 | VS-SFL-070 | Declined vs Unable paired contrast + participant knowledge | REQUIRED | paired failure card | Slice-1 failure semantics |
| S1-071 | VS-SFL-071 | accepted then invalidated at central resolution | REQUIRED | conflict card | Slice-1 resolution |
| S1-072 | VS-SFL-072 | household provision priority | DEFERRED | — | Household provision outside Slice 1 |
| S1-073 | VS-SFL-073 | bounded failure reason/no private-state leak | REQUIRED | information-safety card | Lower-level failure knowledge |
| S1-074-IDEMP | VS-SFL-074 | same automatic cause contributes exactly once | REQUIRED | mutant control | Slice-1 reaction idempotence |
| S1-074-DIRECT-BATCH | VS-SFL-074 companion | mixed direct attitude causes batch once / order-independent | REQUIRED | reaction + permutation card | Director-approved D1 |
| S1-075 | VS-SFL-075 | household formation reaction chain | DEFERRED | — | Card as written requires formation/recognition/Household substrate |
| S1-076 | VS-SFL-076 | communication provenance regression | DEFERRED | — | General communication/recognition propagation outside Slice 1 |

# PART D — Determinism / recovery / explainability

| AcceptanceId | Source | SourceClause | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|---|
| S1-080 | VS-SFL-080 | MaterialDeadlock diagnosed, no rescue grain | REQUIRED | terminal-condition card | Lower-level material system |
| S1-081 | VS-SFL-081 | stable-ID fallback quarantined/disclosed, including Residence conflict exercise | REQUIRED | metamorphic/fallback card | Slice-1 deterministic conflict closure |
| S1-082 | VS-SFL-082 | checkpoint exact suffix | DEFERRED | — | Checkpoint/save-load explicitly outside Slice 1 |
| S1-083 | VS-SFL-083 | omitted checkpoint state detected | DEFERRED | — | Checkpoint outside Slice 1 |
| S1-084 | VS-SFL-084 | derived rebuild equivalence / stale-cache authority | REQUIRED | structural audit **or** rebuild challenge | If Slice 1 has behavior-affecting derived caches/indexes, execute rebuild/stale challenge; otherwise provide structural evidence that no such derived authority exists |
| S1-085 | VS-SFL-085 | observer/diagnostic noninterference | REQUIRED | metamorphic pair | Slice-1 observability |
| S1-086 | VS-SFL-086 | decision trace completeness for personal/response contexts | REQUIRED | explainability audit | IMP-0001 history contract |
| S1-087 | VS-SFL-087 | rendered causal explanation surface | DEFERRED | — | No rendered explanation surface required in Slice 1; causal predecessor truth remains required through history/086 |

# PART E — Boundary matrices

| AcceptanceId | Boundary | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-BND-ATT-STRONGLIKE | +74/+75/+76 | REQUIRED | boundary matrix | Favour reciprocity and direct marriage gates |
| S1-BND-ATT-STRONGDISLIKE | -76/-75/-74 | N-A | — | No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-DISLIKE-NEUTRAL | -27/-26/-25 | N-A | — | No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-NEUTRAL-LIKE | +25/+26/+27 | N-A | — | No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-SAT | beyond +/-100 | REQUIRED | boundary card | Attitude invariant |
| S1-BND-ATT-MIXED | mixed-sign direct causes near both bounds | REQUIRED | boundary/permutation | Director-approved D1 |
| S1-D4-GRAIN-GIFT-OFFER | OfferGift grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | REQUIRED | validation matrix | Director-approved D4; explicit ingress coverage |
| S1-D4-GRAIN-GIFT-REQUEST | RequestGiftOrHelp grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | REQUIRED | validation matrix | Director-approved D4; distinct request ingress |
| S1-D4-GRAIN-LOAN-OFFER | OfferLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | REQUIRED | validation matrix | Director-approved D4; explicit ingress coverage |
| S1-D4-GRAIN-LOAN-REQUEST | RequestLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | REQUIRED | validation matrix | Director-approved D4; distinct request ingress |
| S1-D4-GRAIN-REPAY-DIRECT | direct RepayDebt amount: D4-invalid terms rejected before feasibility/commit; positive integer reaches repayment-specific gates | REQUIRED | validation matrix | Director-approved D4; direct repayment ingress |
| S1-D4-GRAIN-BFF-BENEFIT | required Slice-1 BFF grain-transfer instantiation: every grain quantity in/referenced by the specified material-benefit term obeys D4 before target response; raw scalar amount field not required | REQUIRED | executable or structural validation audit | D4 applied schema-neutrally to canonical 1-grain BFF instantiation |
| S1-D4-GRAIN-RMRH-BENEFIT | required Slice-1 RMRH grain-transfer instantiation: every grain quantity in/referenced by the help/material-benefit term obeys D4 before target response; raw scalar amount field not required | REQUIRED | executable or structural validation audit | D4 applied schema-neutrally to canonical 1-grain RMRH instantiation |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | ProposeMarriage proposed-dowry term on direct-bypass proposal shape: invalid grain term rejected before bride response; positive integer may proceed; no dowry transfer on bypass | REQUIRED | validation matrix | D4 term validity without implementing household-mediated dowry |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | CallFavor(RepayDebt(...)) inner amount: zero/negative/non-integral/over-remaining rejects outer call before Fulfil/Refuse response; valid term may proceed | REQUIRED | nested validation matrix | D4 + repayment bound at distinct wrapped ingress |
| S1-BND-REPAY-AMOUNT | remaining-1 / remaining / remaining+1 (where remaining>1), evidenced for direct and nested called-favour repayment ingresses | REQUIRED | validation matrix | Director-approved D4 repayment-specific bound |
| S1-BND-RESERVE | RepayDebt debtor resulting grain 1 / 2 / 3 | REQUIRED | feasibility boundary | Debt repayment reserve only (§3.3); no generic interpersonal-transfer reserve |
| S1-BND-NEED | NeedsGrain clearing grain 0 / 1 | REQUIRED | maintenance boundary | Slice-1 need |
| S1-BND-DECAY | immediately before / at / after 5-cycle cadence | REQUIRED | temporal boundary | ASM-0002/0007 |
| S1-BND-DEBT-DUE | before N+3 / after N+3 decisions / later | REQUIRED | temporal boundary | ASM-0008 |
| S1-BND-MARRIAGE-CARD | first establishment / second after establishment | REQUIRED | cardinality | Slice-1 marriage |
| S1-BND-FAVOUR-CARD | first favour / additional same ordered pair | REQUIRED | cardinality | Favour invariant |
| S1-BND-FAVOUR-MEANING | full pair slot: ExplicitBenefitForFavor vs RMRH | REQUIRED | causal contrast | Director-approved D5 |
| S1-BND-RESIDENCE-CARD | one vs multiple accepted same-person Residence changes | REQUIRED | conflict boundary | Director-approved D2 |
| S1-BND-HOUSEHOLD-PROVISION | household-provision contributor reserve / NeedsGrain contributor / collective capacity boundaries | DEFERRED | — | Household provision outside Slice 1 |
| S1-BND-PROVISION-RECONSIDERATION | before 3 full cycles / exactly 3 with no relevant context change / exactly 3 plus relevant context change | DEFERRED | — | Household provision/head reconsideration outside Slice 1 |
| S1-BND-FORMATION | formation/participation/lifecycle boundaries | DEFERRED | — | Household formation outside Slice 1 |
| S1-BND-LINEAGE | lineage freshness / predecessor lifecycle-state (one survives vs both Dissolved) / predecessor-source ambiguity boundaries | DEFERRED | — | Lineage outside Slice 1 |

# PART F — Metamorphic obligations

| AcceptanceId | Relation | SliceStatus | EvidenceKind | Rationale |
|---|---|---|---|---|
| S1-META-01 | storage/input iteration permutation | REQUIRED | metamorphic pair | Nonsemantic iteration never causal order |
| S1-META-02 | nonsemantic ID renaming | REQUIRED | metamorphic pair | Isomorphic semantics, except explicitly tested fallback sensitivity |
| S1-META-03 | disconnected-population locality | REQUIRED | metamorphic pair | No hidden global coupling |
| S1-META-04 | observer/diagnostic noninterference | REQUIRED | metamorphic pair | Observability cannot change semantics |
| S1-META-05 | derived rebuild equivalence | REQUIRED | structural-or-executable evidence | Same alternative route as S1-084 |
| S1-META-06 | checkpoint metamorphism | DEFERRED | — | Checkpoint outside Slice 1 |
| S1-META-07 | irrelevant-attribute perturbation | REQUIRED | metamorphic pair | Decision/result causal specificity |
| S1-META-08 | message-arrival permutation | DEFERRED | — | Communication/recognition outside Slice 1 |
| S1-META-09 | lineage predecessor-set ordering | DEFERRED | — | Lineage outside Slice 1 |
| S1-META-10 | direct-attitude cause permutation | REQUIRED | metamorphic pair | Director-approved D1 |
| S1-META-11 | Residence contender permutation | REQUIRED | metamorphic pair | Director-approved D2 |

# PART G — Semantic mutant / fault-control applicability

`REQUIRED` does not require a general mutation-testing framework. A focused negative test, explicit fault injection, structural audit, or other independently reviewable evidence may satisfy the row if the manifest identifies the evidence route.

| AcceptanceId | Mutant/fault class | SliceStatus | Rationale |
|---|---|---|---|
| S1-MUT-01 | form H from co-residence alone | DEFERRED | Household formation absent |
| S1-MUT-02 | form H from insufficient/same-cycle support | DEFERRED | Household formation absent |
| S1-MUT-03 | global household/head recognition | DEFERRED | Household recognition absent |
| S1-MUT-04 | kinship multiplier satisfies stored-attitude gate | REQUIRED | Direct lower-level gate |
| S1-MUT-05 | identity by overlap/similarity | DEFERRED | Household continuity absent |
| S1-MUT-06 | Inactive/Dissolved H emits household action | DEFERRED | Household action absent |
| S1-MUT-07 | participation entry without acceptance/warrant | DEFERRED | Participation absent |
| S1-MUT-08 | household self-feedback clone | DEFERRED | Formation absent |
| S1-MUT-09 | inherit causal state through lineage | DEFERRED | Lineage absent |
| S1-MUT-10 | count household support as fresh lineage evidence | DEFERRED | Lineage absent |
| S1-MUT-11 | household expenditure without backing | DEFERRED | Provision absent |
| S1-MUT-12 | pool/duplicate provision grain or double-debit contributor | DEFERRED | Household provision absent |
| S1-MUT-13A | RepayDebt commits while leaving debtor below the accepted §3.3 two-grain floor | REQUIRED | Debt-repayment-specific reserve; no generic transfer reserve |
| S1-MUT-13B | household provision penetrates contributor protected reserve or draws from a NeedsGrain contributor | DEFERRED | Household provision absent |
| S1-MUT-14 | head commands out-of-scope personal action | DEFERRED | Head role absent |
| S1-MUT-15 | majority instead of unanimous head appointment | DEFERRED | Head appointment absent |
| S1-MUT-16 | skip commit-time revalidation | REQUIRED | Central resolver Slice 1 |
| S1-MUT-17 | collapse Declined/Unable/Invalidated | REQUIRED | Lower-level failure semantics |
| S1-MUT-18 | penalize Unable/Invalidated as voluntary refusal | REQUIRED | Lower-level attitude/failure semantics |
| S1-MUT-19 | leak exact/unrelated private state in failure reason | REQUIRED | Lower-level subjective failure knowledge |
| S1-MUT-20 | same-cycle retry after invalidation | REQUIRED | Cycle/initiative contract |
| S1-MUT-21 | resolve scarce capacity by collection order | REQUIRED | Gift/help conflict + deterministic resolver |
| S1-MUT-22 | fire same reaction cause twice | REQUIRED | Reaction idempotence |
| S1-MUT-23 | truncate reaction closure and report success | REQUIRED | Stable-cycle contract |
| S1-MUT-24 | stale derived cache influences behavior | REQUIRED | Structural evidence if no behavior-affecting cache; focused stale/rebuild fault challenge otherwise |
| S1-MUT-25 | omit future-influencing checkpoint state | DEFERRED | Checkpoint outside Slice 1 |
| S1-MUT-26 | instrumentation mutates semantics | REQUIRED | Observer noninterference |
| S1-MUT-27 | later-arriving older message overwrites newer event evidence | DEFERRED | Communication/recognition absent |
| S1-MUT-28 | Contested recognition resolved by arbitrary ID | DEFERRED | Recognition absent |
| S1-MUT-29 | record only chosen action instead of full decision trace | REQUIRED | Slice-1 trace authority |
| S1-MUT-30 | rendered explanation cites unsupported cause | DEFERRED | Rendered explanation surface outside Slice 1 |
| S1-MUT-31 | clamp independent direct attitude causes contribution-by-contribution | REQUIRED | Director-approved D1 |
| S1-MUT-32 | multiple same-person Residence commits or container-order winner | REQUIRED | Director-approved D2 |
| S1-MUT-33 | invalid grain term reaches response/effects or over-repayment is clamped | REQUIRED | Director-approved D4 |
| S1-MUT-34 | called favour opens nested response, consumes favour on Unable/Invalidated, or fires +/- effect on non-voluntary failure | REQUIRED | Director-approved D3 |
| S1-MUT-35 | ExplicitBenefitForFavor partially commits when favour capacity unavailable / relabels as Gift/Help | REQUIRED | Director-approved D5 |

Crash/timeout never automatically count as semantic detection.

# PART G2 — Supplemental Stage-3 evidence not required for Slice-1 completion

| AcceptanceId | Verification category | SliceStatus | Rationale |
|---|---|---|---|
| S1-SUP-GENERATED | bounded generated histories | UNEXERCISED | Useful later for interaction breadth; B2 explicitly keeps generated-history infrastructure off the Slice-1 completion path |
| S1-SUP-SHRINK | generated-failure shrinking/minimization | UNEXERCISED | Only relevant once generated histories are in use |
| S1-SUP-HELDOUT | concrete held-out variant materialization | UNEXERCISED | Canonical/metamorphic/boundary evidence is sufficient for Slice 1; held-out materialization may occur after implementation path exists |

These rows must not be reported as passed. If later exercised during Slice 1 voluntarily, report them separately without making them retroactive completion requirements.

# PART H — Global completion obligations

| AcceptanceId | Obligation | SliceStatus | EvidenceKind |
|---|---|---|---|
| S1-GLOBAL-FIXTURE | fixture write-set audit for every executable canonical subcase | REQUIRED | fixture audit |
| S1-GLOBAL-KNOWLEDGE | direct-participant knowledge of Declined/Unable/Invalidated and bounded reasons where accepted semantics require it | REQUIRED | executable + state/history audit |
| S1-GLOBAL-ORACLE | independent-oracle restrictions are obeyed for every row using an independent checker | REQUIRED | dependency/source audit |
| S1-GLOBAL-FALLBACK | stable-ID fallback use is logged and sensitivity is confined to explicit fallback cases | REQUIRED | metamorphic/fallback report |
| S1-GLOBAL-ITERATION | nonsemantic collection/input iteration does not determine semantic outcome | REQUIRED | metamorphic run |
| S1-GLOBAL-CALLFAVOR-MAP | executable payload validation matches the frozen Slice-1 CallFavor action applicability table | REQUIRED | table-driven + structural audit |
| S1-GLOBAL-REQUIRED-COVERAGE | zero REQUIRED manifest rows are missing or skipped | REQUIRED | completion-report check |
| S1-GLOBAL-MANIFEST-INTEGRITY | manifest bytes/version match the frozen dispatch baseline | REQUIRED | immutable-baseline/diff check |
| S1-GLOBAL-CONFORMANCE | fresh independent conformance review passes | REQUIRED | independent review report |

## H1. Required companion bundles

The following bundles are conjunctive completion evidence; passing only one row in the bundle is insufficient:

- **D1 direct attitude composition:** `S1-097-DIRECT-BATCH-POS`, `S1-097-DIRECT-BATCH-NEG`, `S1-074-DIRECT-BATCH`, `S1-META-10`, `S1-MUT-31`.
- **D2 Residence conflict:** `S1-096-COMPETE`, `S1-103-RESIDENCE`, `S1-081`, `S1-META-11`, `S1-MUT-32`.
- **D3 CallFavor closure:** all `S1-094-*` rows, `S1-102`, `S1-098-CALLFAVOR-INIT`, `S1-MUT-34`, `S1-GLOBAL-CALLFAVOR-MAP`.
- **D4 grain domain:** `S1-092-AMOUNT-VALIDITY`, all `S1-D4-GRAIN-*` ingress rows, `S1-BND-REPAY-AMOUNT`, and `S1-MUT-33`. The BFF/RMRH ingress rows are schema-neutral: they test the required grain-transfer instantiation without requiring a raw scalar action-field shape.
- **D5 explicit bargain atomicity:** `S1-091-BFF-POS`, `S1-093-BFF-POS`, `S1-093-BFF-FULL`, `S1-093-BFF-RACE`, `S1-093-RMRH-FULL`, `S1-BND-FAVOUR-MEANING`, `S1-MUT-35`.
- **DEC-0015 endpoint identity:** all `S1-107-*` rows together with `S1-105`, `S1-103-GRAIN`, `S1-098-CORE`, and the current CallFavor/debt controls. Positive alias controls are mandatory so the repair cannot collapse into a global all-roles-distinct rule.

# PART I — Oracle independence

Independent checkers may share:

- stable domain IDs/schema;
- recorded committed events/history;
- simple arithmetic;
- accepted SPEC constants and pinned configuration.

When their output is the assertion target, independent checkers must not call production:

- candidate recognizers/generators;
- decision scorer/selector;
- target transition helper;
- CallFavor payload-classification helper;
- derived-capacity helper when capacity arithmetic is under test;
- semantic classifier whose result is being asserted.

For scoring, the oracle sums recorded named components independently rather than calling the production scorer.

For the CallFavor applicability matrix, the independent expectation is this frozen manifest/source-derived table, not production `IsCallable(...)` logic.

# PART J — Fixture policy

Every canonical executable subcase must declare or map to allowed fixture writes.

Generally allowed controlled setup remains as defined in the cross-cutting contract. Mechanism-isolation tests must enter through the public proposal/response/resolution boundary and must not fixture-write the transition result they claim to test.

Fixture-originated and endogenous semantic facts/events remain distinguishable in history.

# PART K — Ownership / editability / CI flow

## K1. Pre-code ownership

- Manifest author: Master Architect or separately commissioned verification author, not the production repair/conformance implementer.
- Pre-code reviewer: fresh independent reviewer checks the frozen candidate against accepted SPEC, verification cards, IMP-0001 scope, and semantic promotion audit.
- After freeze, implementation/conformance work may not edit/reclassify this manifest.

## K2. Implementation/conformance translation

The implementation/conformance agent may choose ordinary test framework/helper/project layout and map executable test/report identifiers to `AcceptanceId`s.

It may not:

- edit this manifest to make production pass;
- silently downgrade REQUIRED rows;
- move semantic expected results into production helpers used by independent oracles;
- fake later-slice semantics to satisfy a deferred row.

## K3. CI report

CI/completion output must expose:

- manifest version/SHA;
- every REQUIRED `AcceptanceId` and executed/pass/fail/skip state;
- DEFERRED/N-A/UNEXERCISED rows separately;
- fixture-audit result;
- mutant/fault-control classifications;
- fallback/metamorphic results where required.

A missing or skipped REQUIRED row fails completion.

## K4. Independent successor-conformance review

A fresh reviewer who did not author production code verifies:

1. manifest unchanged from dispatch baseline;
2. every REQUIRED row has substantive evidence, not label-only coverage;
3. executable assertions match cited source clauses;
4. oracle dependencies obey Part I;
5. fixture writes obey Part J;
6. deferred/later-slice cards were not faked;
7. no unresolved semantic choice was made by test code.

The reviewer reruns canonical root commands or verifies reproducible output.

# PART L — Freeze metadata

- **Manifest version:** `SFL-V0-S1-ACCEPTANCE-v2`
- **Historical frozen predecessor ref:** `sfl-v0-slice1-acceptance-v1`
- **Historical frozen predecessor manifest blob:** `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- **DEC-0015 semantic promotion merge:** `73e4e660ac18b9c094bf22d4dbf6337ee62de0cf`
- **Current SPEC blob at candidate authoring:** `d34d0268bc243efaf741b3d4b4dddc63e755bbbd`
- **DEC-0015 lower-level verification family blob:** `ad18e9027c1f7fdc0aa1535ae458effb35970801`
- **DEC-0015 response verification family blob:** `197281b402580dc9e9c7d4d5e78e79db7d1e2542`
- **DEC-0015 promotion audit:** `research/technical/DEC-0015_PROMOTION_RECONCILIATION.md`
- **Retro-SID closure:** `research/technical/SID_RETRO_SLICE1_CLOSURE_REVALIDATION.md`
- **Reviewed candidate ref:** `sfl-v0-slice1-acceptance-v2-candidate1`
- **Reviewed candidate commit:** `8ba59585d1a97f7a55968d6980c9110b5af33c7f`
- **Reviewed candidate blob:** `de06f0c8523a49b0e248c5012015622936808eaf`
- **Final fresh review:** `research/technical/SFL_V0_SLICE1_ACCEPTANCE_PRECODE_REVIEW_V2_CANDIDATE1.md` — **PASS — MAY FREEZE UNCHANGED**
- **Final review blob:** `e49c41ad949251dac5b86d926c4d88829794af12`
- **Frozen ref:** `sfl-v0-slice1-acceptance-v2`
- **Frozen census:** 173 unique AcceptanceIds — 134 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED
- **Final frozen manifest blob / freeze commit:** recorded externally in `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_V2_FREEZE_RECORD.md` to avoid self-referential hashing.

## Completion rule

Current Slice-1 implementation may be declared conformant to successor v2 authority only when:

- canonical build/test/analyzer commands pass;
- every REQUIRED row has accepted evidence;
- zero REQUIRED rows are missing or skipped;
- manifest integrity check passes;
- independent post-implementation conformance review passes;
- all deliberate deferrals remain visible and match this frozen successor manifest.

Historical IMP-0001 remains VERIFIED COMPLETE relative to frozen v1; successor v2 conformance is a new inherited-assurance obligation created by DEC-0015.
