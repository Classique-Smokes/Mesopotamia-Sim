# TRES-0010B2-ASR — Slice-1 Acceptance Authority / Applicability Design

## Run provenance

- **Task ID:** TRES-0010B2-ASR
- **Role:** B2 technical assurance design / decision support
- **Frozen B2 baseline ref:** tres-0010-b2-baseline
- **Resolved frozen baseline SHA:** 0729e460af35668e5b911fa561bf8cec53204142
- **Assigned return branch/workspace:** tres-0010/b2-asr
- **Return branch starting state:** verified identical to the frozen B2 baseline before this report
- **Model/configuration:** GPT-5.6 Sol; exact hidden reasoning-effort configuration is not exposed
- **Tools used:** GitHub repository connector for repository/ref verification, bounded canonical retrieval, assigned prior-report retrieval, comparison, and isolated return write
- **External research:** no. Project authority was sufficient; no external source was used to decide project assurance or social semantics.
- **Assigned Wave-A reports read directly:** none; the B2-ASR packet did not require direct Wave-A return retrieval
- **Assigned Wave-B reports read:** TRES-0010B-I-PROSECUTION_IMPLEMENTATION_ASSURANCE_REPORT.md; TRES-0010B-I-DEFENSE_IMPLEMENTATION_ASSURANCE_REPORT.md; TRES-0010D-SENTINEL_VERIFICATION_CHEAT_REPORT.md
- **B2 sibling returns read before completion:** **no**
- **Canonical files modified:** **no**
- **This return modifies:** this advisory report only

## 1. Executive recommendation

Adopt a **two-boundary, minimal assurance mechanism**:

1. **Before IMP-0001 is dispatched**, materialize and freeze one small, human-readable Slice-1 acceptance/applicability manifest under independent verification ownership. The manifest enumerates the exact required/deferred/N-A/unexercised verification surface and the evidence type expected for every required item. It does **not** restate social semantics.
2. **After the implementation agent has translated that manifest into ordinary executable tests**, require one fresh independent conformance review that compares the executable acceptance surface and its oracle dependencies against the frozen manifest plus the canonical Stage-3 source cards. Completion is rejected if a required manifest entry is missing, skipped, merely name-matched, or implemented with an oracle that violates the accepted independence rule.

The implementation agent remains free to choose the normal test framework, test helper APIs, project layout, and harness plumbing. It may translate the already-frozen acceptance authority into executable tests, but it is not the sole author/editor of the authority that determines whether the translation is complete.

This is smaller than a protected acceptance project, hidden-test service, general grader, mutation-testing platform, generated-history framework, or organization-scale repository protection. It closes both confirmed assurance gaps:

- **S1-ASR-01:** the candidate implementation no longer authors the first and only statement of executable completion authority;
- **S1-ASR-02:** Slice-1 applicability is closed before coding, including the VS-SFL-104 conflict and cross-cutting obligations.

The manifest should be Markdown with stable row IDs. A later implementation may use a tiny ordinary test/report helper to emit those IDs and fail when a REQUIRED ID is missing or skipped, but the manifest itself is not authored by IMP-0001 and no new evaluator architecture is required.

## 2. Issue inventory

### S1-ASR-01 — first executable acceptance translation is candidate-authored

**Confirmed problem:** IMP-0001 currently commissions the same task to build production code, canonical acceptance tests, and the deterministic harness. The cross-cutting contract correctly forbids direct production-oracle reuse, but that rule does not prevent **translation circularity**: production and test-side expectation code can independently embody the same mistaken reading.

**Minimum closure needed:** the implementation task must receive a pre-existing, independently controlled definition of exactly what evidence is required, and its executable translation must receive an independent conformance pass before acceptance.

### S1-ASR-02 — Slice-1 applicability/completeness is not frozen

**Confirmed problem:** IMP-0001 names broad ranges and open selectors such as “relevant,” “applicable,” and “where their required substrate is available.” It simultaneously requires VS-SFL-100 through VS-SFL-105 and excludes the household/head substrate needed by VS-SFL-104.

**Minimum closure needed:** an exact card/subcase/cross-cutting manifest with no candidate-controlled applicability selection. Missing and skipped REQUIRED items must be visible as failure.

### Related scope contradiction — VS-SFL-104

VS-SFL-104 is a household/head/household-mediated-marriage response card. Those semantics are explicitly outside IMP-0001. It must therefore be **DEFERRED** for Slice 1 rather than silently implemented, stubbed, or omitted despite the current literal 100–105 range.

### Related assurance concerns that do not require a new platform

The accepted cross-cutting contract already supplies:

- fixture-write restrictions;
- independent-oracle dependency restrictions;
- mutant result classifications;
- deterministic/metamorphic relations;
- causal-history expectations;
- stable-ID fallback disclosure;
- observer noninterference.

B2-ASR should make those obligations selectable only by the frozen manifest, not redesign them.

## 3. Accepted constraints

The mechanism must preserve all of the following:

1. **Social semantics remain in accepted semantic authority.** The manifest may cite SPEC/card clauses and identify required evidence, but may not invent or narrow behavior.
2. **Stage-3 cards remain verification design, not semantic authority.** A verification sentence cannot resolve a SPEC ambiguity.
3. **The implementation agent may choose ordinary test technology.** No prescribed xUnit/NUnit/custom framework, project layout, helper shape, or generalized evaluator is justified here.
4. **No secret tests are required.** “Held-out” in the accepted package is not a secrecy guarantee, and Wave B rejected secret-eval infrastructure as a Slice-1 prerequisite.
5. **No general mutation-testing platform is required.** Required mutant claims may be evidenced by targeted hand-authored fault controls, focused negative tests, structural review, or a small local mechanism appropriate to the fault.
6. **Generated histories/shrinking are not Slice-1 completion prerequisites.** They remain later verification-hardening work unless separately commissioned.
7. **No checkpoint system is required in IMP-0001.** Checkpoint-specific verification remains later-slice work.
8. **No household/head/lineage/recognition substrate may be added merely to satisfy later cards.**
9. **Oracle independence is already normatively defined** in CROSS_CUTTING_VERIFICATION_CONTRACT §9 and REFERENCE_SCORING_PROFILES; B2-ASR should make compliance auditable, not redefine it.
10. **The final manifest cannot be frozen until the five confirmed Slice-1 semantic repairs are promoted into accepted authority.** B2-ASR may reserve required coverage hooks for them, but may not choose their semantics.

## 4. Candidate mechanism comparison

| Option | Independence strength | Completeness/applicability | CI integration | Authoring burden | Cheating / under-translation resistance | Future-slice fit | Repository complexity | Disposition |
|---|---|---|---|---|---|---|---|---|
| A. Frozen Markdown manifest + independent pre-code review only | Medium | High | Easy | Low | Medium: prevents silent omission but does not independently inspect executable translation | High | Very low | Useful but insufficient alone for S1-ASR-01 |
| B. Separate protected acceptance project/files authored before implementation | High | High | Medium | High before production API exists | High | Medium-high | Medium-high | Reject for Slice 1 as disproportionate |
| C. Post-implementation independent verification review only | Medium-high | Low before coding | Easy | Low | Medium-high after the fact, but candidate still self-selects applicability while building | High | Very low | Insufficient alone for S1-ASR-02 |
| D. Frozen manifest + ordinary implementation-authored tests + independent post-implementation conformance review | High enough for first kernel | High | Easy | Low-medium | High against both omission and mistranslation without separate grader infrastructure | High | Low | **Recommended** |
| E. Hidden tests / general grader / generalized mutation or generated-history platform | Potentially very high | High | Complex | Very high | High in some dimensions | Unknown | High | Reject as unearned infrastructure |

### Determinism

All four minimal candidates can preserve deterministic execution. Option D is strongest because deterministic obligations are frozen as named evidence rows before implementation and independently checked afterward.

### Causal meaning

Option D keeps causal meaning in the cards/SPEC and requires the implementation to expose the already-required causal history. It does not create a parallel semantic language.

### Implementation simplicity

Option A is simplest but leaves first-author translation risk. Option D adds only one independent review step and a small completion ledger; it avoids a new runtime or test platform.

### Verification clarity

Option D produces an explicit answer to “what exactly must execute for Slice 1?” and a separate answer to “did the executable tests faithfully implement that authority?”

### Future-slice compatibility

The manifest schema is reusable per slice without becoming a global framework. Future slices can add their own manifests or replace this mechanism if stronger evidence becomes warranted.

## 5. Recommended mechanism in detail

### 5.1 Artifact

Create one new canonical verification artifact after B2 reconciliation:

**plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md**

It is a verification/completion authority subordinate to accepted semantic authority and the Stage-3 canonical verification design.

It should be added to the Stage-3 verification README index and referenced by immutable commit SHA/content state in the final IMP-0001 dispatch baseline.

### 5.2 Ownership and editability

**Author before code:** Master Architect or separately commissioned verification author, not the IMP-0001 production implementer.

**Pre-code review:** one fresh independent reviewer checks the manifest against the accepted cards, cross-cutting contract, IMP-0001 scope, and final promoted semantic repairs.

**Implementation task:** may read the manifest and build adapters/tests/harnesses that satisfy it. The manifest path is outside IMP-0001 edit scope.

**Changes after freeze:** require a separately scoped verification/authority change with rationale and source clause. A failing implementation is not a reason to edit the manifest.

**Independent completion review:** a fresh reviewer who did not author the production implementation checks:
- all REQUIRED rows have real executable/structural evidence;
- no REQUIRED row is skipped or silently downgraded;
- test assertions correspond to cited canonical source clauses;
- oracle dependencies obey the accepted independence rule;
- the manifest itself is unchanged from the frozen dispatch version.

Repository-admin branch protection is optional. The minimum protection is ownership/scope separation plus immutable baseline comparison and independent diff review.

### 5.3 Proposed manifest schema

The manifest should use stable rows rather than prose-only headings.

| Field | Purpose |
|---|---|
| AcceptanceId | Stable completion identifier, independent of test method/class names |
| Source | Canonical verification artifact and card/section |
| SourceClause | Exact subcase/assertion/boundary being evidenced |
| SliceStatus | REQUIRED / DEFERRED / N-A / UNEXERCISED |
| EvidenceKind | Executable card, boundary pair/matrix, metamorphic pair, mutant control, structural audit, fixture audit, dependency audit, completion-report check |
| RequiredEvidence | What must be observed for completion; points back to source rather than restating social semantics |
| OracleBasis | Hand-authored fact, simple arithmetic, recorded event/provenance, metamorphic equality, structural rule |
| ForbiddenProductionDependencies | Which production helper categories may not be called by the oracle for this row |
| FixturePolicy | Allowed setup and forbidden outcome writes |
| CompanionRefs | Boundary/metamorphic/mutant rows that must accompany this claim |
| Rationale | Why status is REQUIRED/DEFERRED/N-A/UNEXERCISED for Slice 1 |
| SemanticSourceVersion | Accepted SPEC/ADR/verification source commit/version used when frozen |
| EvidenceRef | Filled by implementation/completion report with test/report identifier; blank before implementation |

The manifest should not contain alternate descriptions of expected social outcomes where the source card already provides them. Its job is to identify the obligation and required evidence surface.

### 5.4 Completion semantics for statuses

- **REQUIRED:** Slice 1 cannot be VERIFIED COMPLETE unless evidence exists and executed successfully.
- **DEFERRED:** accepted project obligation, deliberately assigned to a later slice because its required substrate is outside IMP-0001.
- **N-A:** not an applicable claim for this slice and not being carried as a later obligation by this row; rationale required.
- **UNEXERCISED:** recognized verification-hardening category not required for Slice-1 completion; it must remain visibly unexercised rather than being reported as passed.

A REQUIRED row may define more than one acceptable evidence route when the implementation choice is legitimately local. Example: stale-cache authority can be closed either by a structural proof that no behavior-affecting derived cache exists, or by a focused cache invalidation/rebuild challenge if one does exist. This freezes the obligation without forcing a cache architecture.

## 6. Populated Slice-1 applicability table

### 6.1 Canonical lower-level cards

| Manifest scope | Status | Required Slice-1 treatment |
|---|---|---|
| VS-SFL-090 A–E | REQUIRED | All consumption, missed-consumption, Farm gate, need-clearing, and Farm-effect subcases execute |
| VS-SFL-091 Gift/help | REQUIRED | Both offer-gift and request-help accepted routes; explicit meaning/history preserved |
| VS-SFL-091 Loan | REQUIRED | Both offer-loan and request-loan accepted routes with debt roles/provenance |
| VS-SFL-091 ExplicitBenefitForFavor positive case | REQUIRED | Execute where pair capacity permits; do not use verification prose to resolve the full-capacity ambiguity |
| VS-SFL-091 relationship-mediated reciprocal help | REQUIRED | Execute accepted qualifying-help meaning and distinct history |
| VS-SFL-092 partial repayment | REQUIRED | Execute material, debt, attitude, provenance assertions |
| VS-SFL-092 reserve boundary | REQUIRED | Execute leave-at/penetrate protected reserve boundary |
| VS-SFL-092 full repayment | REQUIRED | Execute satisfaction plus retained provenance |
| VS-SFL-092 due-cycle penalty | REQUIRED | Execute before/at/after N+3 and one-shot penalty behavior |
| VS-SFL-093 explicit bargain positive | REQUIRED | Favour creation and target knowledge when capacity is available |
| VS-SFL-093 +74/+75/+76 reciprocity | REQUIRED | Exact stored-attitude boundary plus kinship non-substitution |
| VS-SFL-093 genuine gift control | REQUIRED | Beneficial Gift must remain semantically distinct from favour creation |
| VS-SFL-093 one-per-pair cardinality | REQUIRED | No second favour token. The material-leg result when an explicit bargain starts at full favour capacity must be sourced from the approved S1-SEM-05 repair before final manifest freeze |
| VS-SFL-094 fulfilment | REQUIRED | Must use one positive callable-action fixture selected only after S1-SEM-03 is promoted; no manifest-authored action grammar |
| VS-SFL-094 voluntary refusal | REQUIRED | Execute lifecycle/attitude/no-world-effect assertions |
| VS-SFL-094 impossible requested action | REQUIRED | Include intrinsically excluded marriage and feasibility/refusal distinction |
| VS-SFL-094 reciprocal cancellation | REQUIRED | Execute atomic two-favour cancellation |
| VS-SFL-095 positive direct marriage | REQUIRED | Execute direct route without household/dowry/favour/residence side effects |
| VS-SFL-095 +74 boundary | REQUIRED | Direct route unavailable |
| VS-SFL-095 kinship exclusion | REQUIRED | Parent/child and sibling exclusion |
| VS-SFL-095 lifetime cardinality | REQUIRED | First establishment versus second establishment |
| VS-SFL-096 move proposal | REQUIRED | Accepted move changes Residence only |
| VS-SFL-096 invite proposal | REQUIRED | Symmetric accepted invite behavior |
| VS-SFL-096 marriage control | REQUIRED | Marriage does not automatically move residence |
| S1-SEM-02 competing accepted same-cycle Residence case | REQUIRED BEFORE DISPATCH | New acceptance row must be populated from the finally approved semantic repair; B2-ASR does not choose its expected outcome |
| VS-SFL-097 individual event updates | REQUIRED | Exercise every listed lower-level event consequence independently |
| VS-SFL-097 bounds | REQUIRED | Positive and negative saturation |
| VS-SFL-097 decay cadence | REQUIRED | Immediately before/at/after due cadence and no crossing zero |
| S1-SEM-01 mixed same-cycle attitude composition case | REQUIRED BEFORE DISPATCH | New acceptance row must be populated from the finally approved semantic repair; B2-ASR does not choose composition semantics |
| VS-SFL-098 initiative accounting excluding Communication example | REQUIRED | Personal initiative versus responses, multiple responses, no second initiative, no required Wait |
| VS-SFL-098 Communication-specific initiative example | DEFERRED | General communication/claim propagation is outside IMP-0001 |
| VS-SFL-099 kinship scoring-domain check | REQUIRED | SCORE-VP-004 exact integer amplification while stored gate remains stored |
| VS-SFL-099 co-residence motivation ordering | REQUIRED | SCORE-VP-006 relative ordering without forcing residence |

### 6.2 Response cards

| Manifest scope | Status | Required Slice-1 treatment |
|---|---|---|
| VS-SFL-100 accept profile | REQUIRED | Production generation, RP-001 component totals, target autonomy, compatible commit, initiative unchanged |
| VS-SFL-100 decline profile | REQUIRED | RP-002 genuine Declined path, no transfer, genuine-need refusal consequence |
| VS-SFL-101 infeasibility-before-scoring | REQUIRED | Unable(reason), bounded reason, no refusal penalty, no Accept-preference bypass |
| VS-SFL-102 fulfil profile | REQUIRED | RP-003 path; final expected callable-action behavior must follow promoted S1-SEM-03 |
| VS-SFL-102 refusal profile | REQUIRED | RP-004 path, outstanding favour, refusal consequence, no initiative debit |
| VS-SFL-103 dual accepted responses / central conflict | REQUIRED | Both response contexts from common snapshot; one commit, one InvalidatedAtResolution; no retroactive Decline |
| VS-SFL-104 role-scoped household-mediated response | DEFERRED | Requires Active Household, valid head, role authority, mediated-marriage substrate explicitly outside Slice 1 |
| VS-SFL-105 personal initiative plus incoming response | REQUIRED | One personal residence decision plus independent response decision; compatible commits; no extra initiative |

### 6.3 Resolution / failure / reaction cards

| Manifest scope | Status | Required Slice-1 treatment |
|---|---|---|
| VS-SFL-070 Declined versus Unable paired contrast | REQUIRED | Both runs; participant knowledge; bounded reason; refusal consequence only for voluntary decline |
| VS-SFL-071 accepted then invalidated at resolution | REQUIRED | Common-snapshot conflict; distinct Invalidated result; bounded participant knowledge; no penalty/retry |
| VS-SFL-072 household provision priority | DEFERRED | Household provision/dowry substrate outside Slice 1 |
| VS-SFL-073 bounded failure information | REQUIRED | Interaction-relevant reason only; no unrelated private state leakage |
| VS-SFL-074 one automatic cause applies once | REQUIRED | Duplicate cause-key challenge and one causal automatic transition |
| VS-SFL-075 household formation reaction chain | DEFERRED | Card as written requires formation/recognition/Household substrate; Slice-1 reaction-closure guard is supplied separately by VS-SFL-074 and required mutant controls |
| VS-SFL-076 communication provenance regression | DEFERRED | General communication/recognition propagation outside Slice 1 |

### 6.4 Determinism / recovery / explainability cards

| Manifest scope | Status | Required Slice-1 treatment |
|---|---|---|
| VS-SFL-080 MaterialDeadlock | REQUIRED | Lower-level no-grain/no-transfer/no-Farm deadlock and negative controls |
| VS-SFL-081 stable-ID fallback | REQUIRED | Repeated deterministic result, iteration permutation, fallback marker, ID-renaming sensitivity in symmetric case, semantic asymmetry negative control |
| VS-SFL-082 checkpoint exact suffix | DEFERRED | Checkpoint/save-load is explicitly outside IMP-0001 |
| VS-SFL-083 omitted checkpoint state | DEFERRED | Depends on checkpoint implementation |
| VS-SFL-084 derived-state rebuild equivalence | REQUIRED ASSURANCE ROW | Satisfy by structural evidence that no behavior-affecting derived cache exists, or by focused discard/rebuild/stale-cache challenge if one is introduced; no generic cache framework required |
| VS-SFL-085 observer/diagnostic noninterference | REQUIRED | Same Slice-1 scenario with diagnostics on/off; authoritative state/history identical |
| VS-SFL-086 decision trace completeness | REQUIRED | Use personal/response context only; prove generated/gated/scored/selected/failed-or-committed distinctions and subjective inputs used |
| VS-SFL-087 rendered causal explanation intervention | DEFERRED | No rendered explanation surface is required in Slice 1; causal predecessor truth remains required through semantic history and VS-SFL-086 |

### 6.5 Required semantic-repair hooks before final manifest freeze

The final Slice-1 manifest must contain REQUIRED rows sourced from the final promoted authority for all five confirmed semantic repairs:

| Repair | Freeze requirement |
|---|---|
| S1-SEM-01 mixed same-cycle attitude effects | Add exact composition acceptance case after semantic rule is approved |
| S1-SEM-02 competing accepted Residence changes | Add exact competing-move acceptance case after semantic rule is approved |
| S1-SEM-03 callable-favour positive action domain/completion | Freeze at least one positive and the required negative/closure cases from the approved callable-action rule |
| S1-SEM-04 grain-valued action amount domain | Add explicit zero/negative/boundary/over-repayment/capacity cases required by the approved rule |
| S1-SEM-05 explicit benefit-for-favour at full favour capacity | Add exact full-capacity bargain acceptance/failure/material-leg case from the approved rule |

These are **applicability commitments**, not semantic recommendations. If any row lacks an accepted semantic source clause at the moment of proposed IMP-0001 dispatch, the acceptance manifest is not ready to freeze and IMP-0001 remains blocked.

## 7. Cross-cutting boundary applicability

| Boundary group | Status | Slice-1 treatment |
|---|---|---|
| Strong-like +74/+75/+76 | REQUIRED | Favour reciprocity and direct-marriage gates |
| Strong-dislike -76/-75/-74 | N-A | No named Slice-1 card/profile uses this band as a categorical lower-level gate |
| Dislike/neutral -27/-26/-25 | N-A | No named Slice-1 card/profile uses this band as a categorical lower-level gate |
| Neutral/like +25/+26/+27 | N-A | No named Slice-1 card/profile uses this band as a categorical lower-level gate |
| Attitude saturation beyond -100/+100 | REQUIRED | VS-SFL-097 |
| Grain reserve 1/2/3 | REQUIRED | Repayment/transfer feasibility boundary |
| NeedsGrain 0/1 | REQUIRED | VS-SFL-090 |
| Provision contributor NeedsGrain false/true | DEFERRED | Household provision |
| Collective capacity insufficient/equal/greater | DEFERRED | Household provision |
| Formation/participation/lifecycle boundaries | DEFERRED | Household/formation slices |
| Provision reconsideration cooldown | DEFERRED | Household provision |
| Attitude decay before/at/after cadence | REQUIRED | VS-SFL-097 |
| Debt due before/at/after N+3 | REQUIRED | VS-SFL-092 |
| First/second established marriage | REQUIRED | VS-SFL-095 |
| First/additional favour same ordered pair | REQUIRED | VS-SFL-093 |
| Lineage boundaries | DEFERRED | Later lineage slice |

## 8. Cross-cutting metamorphic applicability

| Relation | Status | Slice-1 evidence |
|---|---|---|
| 1. Storage/input iteration permutation | REQUIRED | At least one conflict-bearing Slice-1 scenario plus no semantic/history change |
| 2. Nonsemantic ID renaming | REQUIRED | At least one non-fallback lower-level scenario remains isomorphic; VS-SFL-081 separately records permitted fallback sensitivity |
| 3. Disconnected-population locality | REQUIRED | Add unrelated actors/dwellings with no modeled causal link; local lower-level result unchanged |
| 4. Observer/diagnostic noninterference | REQUIRED | VS-SFL-085 |
| 5. Derived rebuild equivalence | REQUIRED ASSURANCE ROW | Structural no-cache evidence or focused rebuild challenge, as described above |
| 6. Checkpoint metamorphism | DEFERRED | Checkpoint out of scope |
| 7. Irrelevant-attribute perturbation | REQUIRED | One decision/response case with a spec-declared irrelevant attribute changed |
| 8. Message-arrival permutation | DEFERRED | General communication/provenance propagation out of scope |
| 9. Lineage predecessor-set ordering | DEFERRED | Lineage out of scope |

## 9. Semantic mutant ledger

No generalized mutation-testing framework is required. “REQUIRED” means the completion evidence must demonstrate detection/rejection of that fault class using a targeted negative test, focused fault injection, independent structural audit, or another explicit evidence route named by the manifest.

| # | Mutant | Slice status | Rationale / evidence expectation |
|---:|---|---|---|
| 1 | form Household from co-residence alone | DEFERRED | Household formation absent |
| 2 | form Household from one support or two same-cycle supports | DEFERRED | Household formation absent |
| 3 | give all actors global household/head recognition | DEFERRED | Household/head recognition absent |
| 4 | let kinship multiplier satisfy stored-attitude gates | REQUIRED | Direct lower-level favour/marriage/scoring concern |
| 5 | preserve household identity by overlap/similarity without continuity | DEFERRED | Household continuity absent |
| 6 | allow Inactive/Dissolved H household-mode action | DEFERRED | Household-mode action absent |
| 7 | participation entry without bilateral acceptance/warrant | DEFERRED | Participation absent |
| 8 | clone H through self-feedback formation evidence | DEFERRED | Formation absent |
| 9 | inherit causal state through DerivedFrom | DEFERRED | Lineage absent |
| 10 | count household support as fresh lineage evidence | DEFERRED | Household support/lineage absent |
| 11 | household expenditure without provision backing | DEFERRED | Household provision absent |
| 12 | pool/duplicate grain or debit contributor twice | REQUIRED | Lower-level grain conservation/zero-sum transfer aspect is in scope; household contributor-double-debit manifestation remains later |
| 13 | penetrate reserve or draw from NeedsGrain contributor | REQUIRED | Reserve penetration is directly in Slice 1; household NeedsGrain-contributor manifestation remains later |
| 14 | head commands out-of-scope personal action | DEFERRED | Head/household mode absent |
| 15 | majority instead of unanimous head appointment | DEFERRED | Head appointment absent |
| 16 | skip commit-time revalidation | REQUIRED | Central revalidation is Slice-1 core |
| 17 | collapse Declined/Unable/Invalidated | REQUIRED | Slice-1 failure semantics |
| 18 | penalize Unable/Invalidated as voluntary refusal | REQUIRED | Slice-1 social/failure distinction |
| 19 | leak exact/unrelated private state in failure reasons | REQUIRED | VS-SFL-070/071/073 |
| 20 | same-cycle retry after invalidation | REQUIRED | Slice-1 initiative/closure rule |
| 21 | material conflict resolved by collection iteration order | REQUIRED | VS-SFL-103/071 plus permutation evidence |
| 22 | one automatic reaction cause fires twice | REQUIRED | VS-SFL-074 |
| 23 | truncate a reaction loop and report successful closure | REQUIRED | Slice-1 automatic reaction closure exists; targeted lower-level closure guard suffices |
| 24 | stale derived cache influences behavior | REQUIRED | Close by structural no-authoritative-cache evidence or focused stale-cache challenge; no cache framework required |
| 25 | omit future-influencing checkpoint state | DEFERRED | Checkpoint excluded |
| 26 | instrumentation mutates semantics | REQUIRED | VS-SFL-085 |
| 27 | later-arriving older message overwrites newer event evidence | DEFERRED | General communication/recognition propagation excluded |
| 28 | Contested recognition resolved by arbitrary ID | DEFERRED | Recognition excluded |
| 29 | record only chosen action rather than complete decision trace | REQUIRED | VS-SFL-086 / IMP history requirements |
| 30 | rendered explanation cites unsupported cause | DEFERRED | Rendered explanation surface not required in Slice 1 |

For REQUIRED mutants, crash/timeout is not automatically credited as semantic detection; retain the existing cross-cutting classification rule.

## 10. Fixture write-set audit

Fixture discipline is a **REQUIRED global completion row**, not a discretionary per-test nicety.

Minimum evidence:

1. Every executable canonical card/subcase declares or is mapped to its allowed fixture writes.
2. Mechanism-isolation tests enter through the public proposal/response/resolution boundary.
3. A test does not fixture-write the transition result it claims to verify.
4. Fixture-originated and endogenous semantic events remain distinguishable in history.
5. The independent conformance reviewer samples the actual fixture construction for every major family and explicitly reports violations/no violations.

No new fixture DSL is required. A Markdown/table mapping or conventional test metadata is sufficient.

## 11. Direct-participant knowledge assertions

The manifest must not let global resolver/history visibility substitute for actor knowledge.

The following are REQUIRED:

- VS-SFL-070: A/B distinguish and know Declined versus Unable(reason);
- VS-SFL-071: direct participants learn InvalidatedAtResolution(reason) without same-cycle retry;
- VS-SFL-073: bounded failure explanation does not leak unrelated private state;
- VS-SFL-100/101: response outcomes and feasibility/failure remain visible to the direct parties under the accepted lower-level knowledge rules;
- VS-SFL-102: called-favour fulfil/refusal outcome is represented for the direct parties.

Evidence may use an actor-scoped derived query over provenance-bearing semantic history; B2-ASR does not require a dedicated persisted KnownFact store.

## 12. Stable-ID fallback and iteration-order assurance

The manifest should contain separate REQUIRED rows for:

1. **ordinary storage/input permutation:** nonsemantic collection/insertion order changes must not change authoritative Slice-1 state/history;
2. **non-fallback ID renaming:** a nonsemantic stable-ID renaming preserves isomorphic results where IDs have no accepted tie-break role;
3. **fallback sensitivity:** VS-SFL-081 permits a symmetric winner to change after relevant ID renaming only when all semantic/domain priorities are exhausted and the technical fallback marker is present;
4. **asymmetry control:** adding a meaningful domain asymmetry must remove reliance on the fallback.

This prevents “stable ID” from silently becoming a general social preference.

## 13. Oracle-independence audit method

The existing oracle rule is sufficient as authority. Make it auditable with a small conformance checklist rather than a new architectural layer.

For every REQUIRED row with an independent expected-value computation, the implementation evidence must record an **OracleBasis** and the independent reviewer must check:

### Allowed shared dependencies

- stable domain IDs/schema;
- recorded committed semantic events/history;
- simple arithmetic;
- accepted constants and pinned verification configuration.

### Forbidden dependencies when they are the assertion target

- production candidate recognizer/generator;
- production scorer/selector;
- production response selector;
- production transition helper whose result is being asserted;
- production derived-capacity helper when capacity arithmetic is under test;
- any helper that simply returns the production result being “independently” checked.

### Specific checks

- scoring oracles sum recorded integer components themselves;
- expected boundary arithmetic is hand-authored from cited constants, not delegated to the production gate;
- fixture builders do not call production candidate/feasibility logic to decide which required canonical case exists;
- metamorphic comparisons compare authoritative outputs/history rather than the production function’s own “expected” projection;
- the test source/dependency graph is inspected for forbidden references.

A separate compiler-enforced project boundary is **optional local hardening**, not a Slice-1 prerequisite. If the chosen solution layout makes a one-way project-reference boundary trivial, it is welcome, but the acceptance mechanism does not depend on it.

## 14. CI and completion flow

### Gate 0 — semantic reconciliation

Before the manifest is frozen, the Master Architect must promote the approved resolutions for S1-SEM-01 through S1-SEM-05. Every required semantic-repair hook in §6.5 must have an authoritative source clause.

### Gate 1 — pre-code manifest freeze

A non-IMP author materializes the manifest, fills every Slice-1 row, and records:
- manifest version;
- accepted source baseline;
- required/deferred/N-A/unexercised status;
- evidence type;
- oracle basis/restrictions.

A fresh reviewer validates the manifest against the canonical source set.

### Gate 2 — IMP-0001 dispatch

IMP-0001 is dispatched against a baseline that already contains the frozen manifest. The implementation agent:
- may create ordinary acceptance tests/harness code;
- may map test/report identifiers to AcceptanceIds;
- may not edit the manifest or change a row’s status/semantic source.

### Gate 3 — ordinary CI

CI runs the canonical root build/test/analyzer commands plus the acceptance suite.

The acceptance reporting surface must make visible:
- manifest version/SHA;
- every REQUIRED AcceptanceId;
- executed/pass/fail/skip state;
- every DEFERRED/N-A/UNEXERCISED row separately;
- fixture-audit result;
- mutant classification;
- fallback markers and metamorphic outcomes where required.

Missing or skipped REQUIRED IDs fail completion. This may be implemented as a very small test/report check; it is not a general grader service.

### Gate 4 — independent conformance review

A fresh reviewer checks:
- manifest unchanged from dispatch baseline;
- each REQUIRED ID is backed by a substantive test/audit rather than a label-only stub;
- executable assertions match the cited source card/subcase;
- oracle dependencies obey §13;
- fixture writes obey §10;
- no later-slice card was faked to make a range pass;
- no semantic ambiguity was resolved by test code.

The reviewer reruns the canonical commands or verifies their reproducible output.

### Gate 5 — completion decision

IMP-0001 can be VERIFIED COMPLETE only when:
- ordinary build/test/analyzer CI passes;
- every REQUIRED manifest row has accepted evidence;
- zero REQUIRED rows are missing or skipped;
- the independent conformance review passes;
- all deliberate deferrals remain visible and match the frozen manifest.

## 15. Exact IMP-0001 changes needed if approved

### IMP-0001 §2 — authority taxonomy

Rename the parent concept from undifferentiated “Authoritative inputs” to **Required inputs by authority class** and separate:

1. **Accepted simulation/architecture authority** — accepted DEC/ADRs/SPEC.
2. **Canonical verification authority for this slice** — Stage-3 verification artifacts plus the frozen Slice-1 acceptance manifest. State explicitly that verification artifacts test but do not create social semantics.
3. **Required non-authoritative supporting/engineering context** — assumptions register, working C# guardrails, AGENTS.md, architecture-development policy.

Add one precedence sentence: accepted semantic/architectural authority controls; verification/supporting context cannot silently override it.

### IMP-0001 §3.1 — acceptance translation

Replace language that lets the task create the first completion authority with language equivalent to:

- implement ordinary executable tests/harnesses that translate the pre-existing frozen Slice-1 acceptance manifest;
- test framework/helper design remains local;
- the manifest itself is not editable within IMP-0001.

### IMP-0001 §6 — canonical scenario coverage

Replace the open card ranges and “applicable/relevant/where substrate exists” completion selector with:

- every manifest row marked REQUIRED must execute and pass;
- no REQUIRED row may be skipped, omitted, or silently reclassified;
- DEFERRED/N-A/UNEXERCISED rows must remain visible with the manifest’s rationale;
- VS-SFL-104 is explicitly DEFERRED from Slice 1;
- VS-SFL-098 Communication-specific coverage is explicitly DEFERRED while the lower-level initiative claim remains REQUIRED.

### IMP-0001 §6 — protected acceptance surface

State that:
- the acceptance manifest predates the implementation baseline and is separately owned;
- IMP-0001 may author executable translations/adapters but not edit the manifest to make production pass;
- changes to acceptance authority require separately scoped verification/authority work.

### IMP-0001 §7 — verification expectations

Add required completion evidence:
- manifest version and frozen SHA;
- complete REQUIRED-row execution table with zero missing/skipped rows;
- explicit status list for DEFERRED/N-A/UNEXERCISED rows;
- oracle-independence audit;
- fixture write-set audit;
- required metamorphic outcomes;
- required mutant classifications;
- independent conformance-review result.

Remove ambiguity in “no-surviving relevant mutant” by pointing to the exact mutant statuses in the frozen manifest.

### IMP-0001 §8 — local decisions permitted

Retain freedom over test framework/helper APIs, but add:
- local test/helper choices may not edit/reclassify the external acceptance manifest or move expected semantic authority into production helpers.

### IMP-0001 §9 — escalation

Add:
- if a REQUIRED manifest row cannot be translated without adding or choosing social semantics, stop and escalate;
- if a cited semantic-repair row lacks accepted authority, do not invent an expected result in the test.

### IMP-0001 §11 — completion report

Require:
- manifest version/SHA;
- per-AcceptanceId result summary;
- independent conformance-review reference/status.

## 16. Exact implementation-task-template changes worth carrying forward

The generic template should not force every future implementation task to use a manifest. It should support one when a separately owned acceptance authority exists.

### Template §2 — Required inputs

Split:
- accepted authority;
- verification/acceptance authority;
- required non-authoritative supporting context.

Add precedence wording.

### Template §6 — Acceptance criteria

Add optional field:

**External acceptance authority (if any):** path + immutable baseline/version + owner.

If present:
- implementation may not change the authority unless explicitly in scope;
- REQUIRED/deferred applicability is taken from that authority rather than self-selected.

### Template §7 — Verification expectations

Add:
- when a frozen applicability manifest exists, completion evidence must show every REQUIRED item and skipped/missing REQUIRED items are failure;
- oracle/dependency restrictions from the acceptance authority must be audited;
- implementation-authored test names alone are not evidence of complete translation.

### Template §8 — Local decisions

Clarify that test framework/helpers remain local but cannot redefine externally owned completion semantics.

### Template §11 — Completion report

Add optional:
- acceptance-manifest version/SHA;
- independent conformance-review status;
- unresolved/deferred manifest rows.

No generic evaluator, secret-test, mutation-platform, or protected-project requirement should be added to the template.

## 17. Exact canonical artifacts/sections to amend if approved

1. **New:** plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md
   - Populate from §§6–13 of this report after the five semantic repairs are promoted.
2. **Amend:** plans/verification/SFL_V0/README.md
   - Add the frozen Slice-1 manifest to the implementation-facing verification index and state that it is the Slice-1 applicability/completion map, subordinate to semantic authority.
3. **Amend:** tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md
   - §§2, 3.1, 6, 7, 8, 9, 11 as specified above.
4. **Amend:** tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md
   - §§2, 6, 7, 8, 11 as specified above.
5. **Resolve/retire trigger reminder:** registers/SCAFFOLDING_TRIGGER_REGISTER.md, SCF-002
   - Once the manifest/independent conformance mechanism is actually materialized, follow the register lifecycle: let the durable verification/task artifacts replace the reminder rather than keeping SCF-002 as a second competing authority.

### Artifacts that do not need ASR-specific semantic amendment

- CROSS_CUTTING_VERIFICATION_CONTRACT.md §9 already states the necessary oracle-independence rule.
- REFERENCE_SCORING_PROFILES.md already states the independent score-summing rule.
- The family cards remain the source of verification claims; B2-ASR should not rewrite their social semantics except where the separately approved semantic B2 repairs require canonical changes.

## 18. Exact verification additions / changes

### Add

- one Slice-1 acceptance/applicability manifest;
- one independent pre-code manifest review;
- one post-implementation conformance review;
- explicit REQUIRED coverage for:
  - VS-SFL-090–099 as decomposed above;
  - VS-SFL-100–103 and 105;
  - VS-SFL-070/071/073/074;
  - VS-SFL-080/081/084/085/086;
  - required Slice-1 cross-cutting boundaries/metamorphics/mutants;
  - fixture write-set audit;
  - observer noninterference;
  - stable-ID fallback sensitivity;
  - iteration-order permutation;
  - direct-participant knowledge assertions;
  - all five finally promoted semantic-repair acceptance hooks.

### Explicitly defer

- VS-SFL-104;
- the Communication-specific example inside VS-SFL-098;
- household provision/formation/continuity/lineage cards and mutants;
- checkpoint/save-load cards and mutants;
- general communication/recognition propagation;
- rendered explanation intervention;
- generated-history/shrinking infrastructure;
- secret held-out infrastructure.

### Do not add

- a second semantic specification inside the manifest;
- a general grader service;
- mandatory secret tests;
- mandatory separate acceptance executable/project;
- mandatory organization-level branch protection;
- a generic mutation engine.

## 19. Rejected overengineered alternatives

### Separate acceptance executable/project authored before production

This gives stronger mechanical separation, but it forces API/adaptor choices before the first implementation exists and creates a second project boundary whose cost is not yet justified. The accepted oracle rules plus frozen manifest and independent conformance review close the demonstrated risk more cheaply.

### Secret/hidden held-out service

The accepted verification package does not define held-out as secret. Wave-B adjudication explicitly rejects making secret tests an IMP-0001 prerequisite. Secrecy would add operational complexity without fixing the more basic translation/completeness problem.

### General mutation-testing platform

The current mutant ledger is semantic, not a requirement to adopt a mutation tool. Targeted fault controls and explicit classifications are sufficient for the first kernel.

### Generated-history/shrinking infrastructure

Useful later, but explicitly not required for Slice-1 completion. Pulling it into the critical path would widen the task without closing S1-ASR-01/02 more directly.

### Organization-scale protected-branch / reviewer administration

May become useful later, but the demonstrated first-code risk can be closed with isolated ownership, frozen baseline identity, diff review, and a fresh conformance reviewer.

## 20. Strongest disconfirmation of the recommendation

The strongest case against the recommended mechanism is that a Markdown manifest plus independent review is **not cryptographically independent** and does not prevent a coordinated or correlated mistake:

- the manifest author can omit a requirement;
- the implementation agent can attach a REQUIRED ID to a weak test;
- the independent reviewer can repeat the same misreading;
- repository write permissions may technically allow an implementation agent to modify the manifest even when task scope forbids it.

A separately authored executable acceptance project with stronger repository permissions would reduce some of those risks.

That stronger mechanism is not justified yet because:

1. the accepted Stage-3 cards are already detailed and immutable semantic references;
2. the confirmed defect is specifically first-author/completeness control, not lack of a general evaluator;
3. the independent post-implementation review directly checks for label-only/weak translations;
4. immutable baseline/diff comparison makes manifest edits visible without organization-scale administration;
5. B2 explicitly prioritizes smallest faithful assurance and rejects broad unearned infrastructure.

If later evidence shows repeated manifest tampering, repeated mistranslation, or inability of fresh reviewers to detect weak executable mappings, SCF-004-style behavioral/eval scaffolding can be reconsidered with concrete evidence.

## 21. Director approval

**The assurance mechanism itself does not require a new social-semantic Director choice.** It is a verification/handoff control that makes already-accepted obligations retrievable and independently checkable.

The Master Architect can materialize the mechanism within existing verification/task-governance authority **provided it does not add or choose social semantics**.

However:

- the five S1-SEM repairs remain semantic choices and must receive whatever Director approval the final TRES-0010 reconciliation requires;
- the Slice-1 manifest must not freeze their expected outcomes until those semantic changes are accepted;
- if implementing the assurance mechanism would require changing an accepted architectural/governance principle rather than merely enforcing it, escalate before promotion.

## 22. Residual risks and deferred questions

1. **Correlated reviewer error:** fresh AI reviewers can share model-family errors. The manifest/source cross-reference and explicit disconfirmation step reduce but do not eliminate this.
2. **Manifest omission:** an independent pre-code review is still a human/agent review process. A future repeated failure may justify a stronger generated index or schema validator.
3. **Label-only cheating:** a candidate can emit an AcceptanceId without a meaningful assertion. The independent conformance review must inspect substance, not just the execution ledger.
4. **Optional cache structure:** Slice 1 does not require a cache framework. The manifest therefore freezes the stale-cache obligation with alternative evidence routes rather than dictating storage design.
5. **Generated-history validity independence:** D-SENT-004 remains a useful later hardening item. It is not a Slice-1 completion prerequisite because generated histories themselves are not.
6. **Verified-checkpoint producer provenance:** D-SENT-005 is a later-slice issue and should be closed before a later slice consumes endogenous verified checkpoints.
7. **Held-out strength:** visible held-out recipes are weaker against deliberate overfit than secret cases, but secrecy is not currently accepted as necessary. Metamorphics, mutants, independent conformance, and future generated histories remain the chosen defense.
8. **Semantic B2 coupling:** the final manifest cannot be sealed until the five semantic repair rows cite promoted authority. This is an intentional dependency on final TRES-0010 reconciliation, not a reason for B2-ASR to inspect sibling B2 returns.

## 23. Final decision-support summary

The project does not need a verifier platform before its first kernel.

It needs one small, durable separation of responsibilities:

- **semantic authority says what the model means;**
- **the frozen Slice-1 manifest says exactly which accepted verification obligations count for this implementation slice;**
- **the implementation agent writes ordinary code/tests against that frozen surface;**
- **a fresh reviewer checks that the executable translation is complete and non-circular.**

This is sufficient to prevent IMP-0001 from being the sole author of its own acceptance standard, closes the VS-SFL-104/applicability contradiction, preserves the existing oracle-independence contract, and keeps later verification infrastructure off the Slice-1 critical path.

**Recommendation: approve Option D and keep IMP-0001 blocked until the final promoted semantic repairs are reflected in a frozen Slice-1 manifest.**

This report is advisory only and modifies no canonical project artifact.
