# SFL v0 Slice 3 — Acceptance Applicability Pre-Code Review V1

**Status:** RETURN / **BLOCK — VERIFICATION-AUTHORITY REPAIR**  
**Review authority:** fresh read-only pre-code acceptance review  
**Reviewed candidate:** `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_APPLICABILITY_CANDIDATE.md`  
**Reviewed candidate branch:** `verification/sfl-v0-slice3-acceptance-candidate-v1`  
**Reviewed candidate commit:** `56f52c0b86d286fee2e076f9ff445ab1059d0d75`  
**Reviewed candidate blob:** `e73fab00d779985fc0f96613d14503ed8144fb5d`  
**Return branch:** `review/sfl-v0-slice3-acceptance-precode-v1-return`  
**Implementation authority exercised:** none  
**Semantic promotion authority exercised:** none

## 1. Judgment

**BLOCK — VERIFICATION-AUTHORITY REPAIR.**

Candidate v1 is strongly subordinate to accepted SFL semantics and gets the main Slice-3 boundary right:

- persistent Household identity is downstream of lower-level history and founder Recognition;
- participation/continuity/lifecycle are warrant-based rather than snapshot-derived;
- controlled lineage is historical provenance only;
- Household Recognition remains actor-specific and non-omniscient;
- provision in Slice 3 is backing/capacity substrate only, not head authority or spending;
- candidate convergence remains bounded away;
- head/office/HouseholdDecisionContext/spending stay in Slice 4;
- checkpoint/restore stays later;
- reaction closure, fixture audits, independent oracles, and frozen prior authority remain explicit.

The exact reviewed blob nevertheless cannot freeze unchanged because four completion obligations remain self-selectable or omitted:

1. the canonical three-founder formation witness is not pinned;
2. the VH-05 Household-Recognition witness does not require the decisive-dissolution subcase or its safe assertion boundary;
3. the exact inherited regression list omits five frozen Slice-1 IDs explicitly retained by Slice-2/Slice-3 verification authority;
4. the minimum cross-cutting metamorphic set does not make irrelevant-attribute perturbation a REQUIRED executable obligation.

These are verification-authority defects only. No reviewed defect requires a new social rule.

**RG-01 — provision prerequisite fixture authority:** **SUPPORTED.**  
**RG-02 — lifecycle / Household Recognition:** **SEMANTICALLY SUPPORTED, CANDIDATE REPAIR REQUIRED.**  
**RG-03 — S1-084 structural evidence:** **EXACT EXISTING PATH CAN REMAIN MECHANICALLY GREEN; NO ADAPTATION IS REQUIRED BY AUTHORITY.**  
**RG-04 — candidate convergence:** **PASS / NO REQUIRED WITNESS NEEDS MULTI-REFERENT CONVERGENCE.**  
**Director-level semantic decision required now:** **NO.**

The candidate **MUST NOT FREEZE UNCHANGED**.

## 2. Exact source set independently reviewed

All repository sources below were retrieved at exact candidate commit `56f52c0b86d286fee2e076f9ff445ab1059d0d75`.

| Source | Blob |
|---|---|
| `AGENTS.md` | `ee9f27664b912e07eb0a8fedc819a6f5a05ed257` |
| `00_START_HERE.md` | `cf11d0ce07b72fbe97577575d419df8f3e3a8ccf` |
| `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` | `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52` |
| `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` | `66cfd55f8b960ff5664638c41c0e731257902be5` |
| `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` | `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229` |
| `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md` | `9ce78a311f006215a2afe3575065005e74c4e916` |
| `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md` | `43eedd7eb49e1eae035010332883ed2d8726d451` |
| `architecture/accepted/ADR-0005_HOST_RUNTIME.md` | `7e6732a928656da28d299a4d78bf27d1ffc139f5` |
| `plans/verification/SFL_V0/FORMATION_FAMILY.md` | `d3280e441f1bc273474c5a5b453a88e48aa41394` |
| `plans/verification/SFL_V0/CONTINUITY_TURNOVER_FAMILY.md` | `30e596a44df4eea868829c24b2fd4c3744d2a3c2` |
| `plans/verification/SFL_V0/LINEAGE_FAMILY.md` | `352669d3ef647fb13b518bc613aafa81605a47a1` |
| `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md` | `cb979360e3a61239b5e918979dd01f48e0b3867e` |
| `plans/verification/SFL_V0/NO_SELF_CONFIRMATION_FAMILY.md` | `c29647fa5404a6f4c7c0e3ceb7226645c2fb5eb5` |
| `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md` | `d8f87dea9569d41481850c7327a025c44d6c3358` |
| `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md` | `7d765988330146ddedd5e9849108eaf10831717d` |
| `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md` | `f20d9ae857e4e87271f1f48603bd7b244968e04c` |
| `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md` | `e4872531cf780d51fa1863f2a0b87e2424a71b69` |
| `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_FREEZE_RECORD.md` | `7dcdefaefb49927c33c029c31a79d84eddf532d7` |
| `registers/TRES-0010_DEFERRED_GAP_LEDGER.md` | `2dece4f8b9f33b0c46f384b7bd75f58bcfaac101` |
| `research/technical/SFL_V0_SLICE3_AUTHORITY_AND_GAP_INVENTORY.md` | `ac5d3d8826b9ed2a7c3ceb9efe8582e37b761160` |
| `research/technical/SFL_V0_SLICE3_IMPLEMENTATION_SURFACE_MAP.md` | `0bb9b8980baa1f2427d93808b70e9bf816a4c85b` |
| `research/technical/SFL_V0_SLICE3_VERIFICATION_TRIGGER_MAP.md` | `acc9bd2d22bc61cf69ade81529ece078053ee7e3` |
| `research/technical/SFL_V0_SLICE3_PREIMPLEMENTATION_RECONCILIATION.md` | `904eb3b63e2a8b232227cb8e0b76452989578299` |
| exact reviewed candidate | `e73fab00d779985fc0f96613d14503ed8144fb5d` |

For RG-03 I also inspected the current executable `S1-084` evidence in `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` at blob `a2204947dc1c7704a90af1efa44170e0b39296e0`.

No conceptual tablet material or implementation convenience was treated as semantic authority.

## 3. Independent semantic/subordination re-derivation

Accepted authority fixes the following Slice-3 boundaries.

1. A Household is not primitive residence, kinship, marriage, graph clustering, participant overlap, a hidden Members set, or a privileged `FormHousehold` command.
2. Formation requires a founding core of at least two people, shared residence, connected durable ties, two qualifying support commits on different cycles, and CandidateRecognition by every required founder.
3. CandidateRecognition is actor-specific, provenance-bearing, ephemeral pre-Household Recognition. Candidate identity/label cannot prove itself.
4. Valid formation automatically creates a persistent H, FormationWarrant, founding SustainingParticipant associations, and direct founder H Recognition. New H begins headless.
5. Later participation requires the accepted bilateral request/invite path plus a ParticipationWarrant. Participation end is explicit and creates a ParticipationEndWarrant.
6. Numerical continuity requires historical transmission through a live bridge, same-H Recognition, and ContinuationWarrant. Endpoint similarity never substitutes.
7. Lifecycle is operational only: 2+ Active, 1 Inactive, 0 Dissolved, published only at stable closure. Dissolved H cannot reactivate as the same identity.
8. Same-cycle bridge handoff has semantic causal priority over the bridge's accepted exit when the entry depends on that bridge.
9. Household Recognition is separate from objective H state and from head Recognition. Subjective state does not passively synchronize.
10. Controlled lineage is downstream of ordinary formation, behaviorally inert, and transfers no causal state. Ambiguity withholds lineage rather than selecting by ID.
11. HouseholdProvisionCommitment leaves grain personal; capacity is derived from valid commitments and personal state. The accepted endogenous acquisition/reconsideration and all actual spending are head-scoped later behavior.
12. ADR-0004 requires authoritative same-cycle reactions to close before completed-cycle publication or fresh voluntary activation.
13. ADR-0003 allows new authoritative state partitions and rebuildable projections without prescribing one concrete field layout. Derived caches/indexes cannot silently become authority.
14. Frozen Slice-1/Slice-2 acceptance remains immutable; Slice 3 adds evidence, not retroactive reclassification.

Candidate v1 is semantically subordinate on these points. The blockers below concern what the completion authority forces an implementation to demonstrate.

## 4. RG-01 — provision prerequisite fixture authority

### Classification

**SUPPORTED.**

A declared pre-existing valid `HouseholdProvisionCommitment(Person -> H)` may be used as prerequisite test state when commitment acquisition itself is explicitly not the claim under test.

This does **not** create a headless in-world acquisition route. It is a controlled verification pre-state, analogous in verification role to the frozen Slice-2 fixture classes that permit actor-held epistemic state when acquisition is not under test.

The candidate's existing restrictions are necessary and sufficient:

- the produced H itself must come from a verifiably passing producer;
- fixture provenance must be explicit;
- the fixture may seed the valid commitment relation only;
- it may not write derived capacity;
- it may not transfer grain;
- it may not create head/office state;
- it may not be formation/continuity evidence;
- it may not be reported as proof that endogenous provision solicitation/acceptance is implemented.

`S3-090` therefore proves the bounded state/backing representation, not endogenous reachability of the acquisition action. `S3-D06` correctly leaves endogenous solicitation/reconsideration in Slice 4.

No Director semantic decision is required for RG-01.

## 5. RG-02 — lifecycle / Household Recognition

### Semantic result

**SUPPORTED, but the current candidate is not omission-detectable enough.**

Accepted authority supports all of the following:

- outsider X may retain stale H Recognition across an unwitnessed objective lifecycle/continuity change;
- no passive engine synchronization may rewrite X;
- a direct participant may later communicate event-backed evidence they actually hold;
- underlying event/provenance order, not message arrival, controls the accepted update;
- no generic nonparticipant observation entitlement is needed.

For a **positive current-continuation** case, where newer accepted evidence establishes that the same non-Dissolved H continues, the completion authority may require `Recognized(H exists/continues)` with current accepted provenance.

For a **decisive dissolution** case, accepted authority does **not** define a separate negative Recognition proposition or a mandatory enum transition such as `Unknown` versus `Contested`. The safe assertion is narrower:

- X retains the old state until accepted evidence reaches X;
- the last/decisive participant's newer event-backed evidence is received through ordinary communication;
- X's current factual/provenance basis is updated;
- the stale positive continuation basis is no longer treated as a safe current basis for relying on H continuation;
- the test must **not** require a specific negative Recognition enum unless separately accepted semantics later define one.

This is enough to close the Slice-3 side of VH-05 without inventing negative-recognition semantics.

### Blocking defect

The candidate's `S3-065-LIFECYCLE-EVIDENCE-UPDATES-H-UNDERSTANDING` and §16 permit a generic lifecycle/continuity transition. The minimum witness authority specifically requires the **decisive-dissolution subcase** for VH-05. An implementation could satisfy the current wording only with a benign Active→Inactive or other continuing-H update and never exercise dissolution evidence.

### Required repair R2

Pin two bounded subcases in §16 / `S3-065`:

1. **current-continuation update:** newer accepted same-H continuation evidence yields current `Recognized(H exists/continues)` provenance;
2. **decisive-dissolution update:** last-bearer/decisive participation-end evidence reaches X through accepted direct-participation + communication provenance; require factual/provenance update and loss of safe reliance on the stale continuation basis, but require no specific negative Recognition enum.

No generic observer rule, head proposition, or new Recognition meaning may be added.

## 6. RG-03 — frozen S1-084 structural evidence

### Result

**The exact existing S1-084 path can remain mechanically green unchanged.**

Current `S1-084` executable evidence asserts an exact private-field inventory for `WorldState`, plus immutable snapshot isolation. Adding a private field to `WorldState` would fail that exact test.

That does **not** create an architectural blocker:

- ADR-0001 does not require every authoritative typed record to live as a private field on `WorldState`;
- ADR-0003 explicitly preserves flexible authoritative/derived state organization behind stable semantic boundaries;
- ADR-0004 separates logical responsibilities;
- the verified Slice-2 kernel already demonstrates a separate authoritative epistemic-state partition while keeping the exact `WorldState` inventory unchanged.

Therefore a separate authoritative Household/warrant state partition is available without architecture redesign, and the exact frozen S1-084 evidence can remain green.

Candidate §17 is correct to authorize **no** adaptation. If an implementation voluntarily chooses a design that changes the exact `WorldState` structural assertion, that implementation must stop and obtain a separately reviewed lossless verification adaptation. The coder may not weaken the frozen test.

No candidate repair is required for RG-03.

## 7. RG-04 — CandidateOrganization convergence

**PASS / NONBLOCKING.**

Every REQUIRED witness can execute with one stable inert CandidateOrganization referent per prospective formation episode.

- ordinary H formation needs one referent;
- continuity/participation refers to already-formed H, not candidate equivalence;
- a division successor H2 can use its own single candidate referent;
- a consolidation successor H3 can use its own single candidate referent;
- continuity-over-duplicate-formation can use one prospective duplicate referent and does not require reconciling two candidate labels;
- predecessor Household identity is not CandidateOrganization equivalence.

No REQUIRED witness needs merging, ranking, converging, or deciding equivalence between two distinct pre-Household referents. `LATER-01` / `S3-D01` may remain deferred.

## 8. Applicability completeness — blocking omissions

### R1 — canonical three-founder formation witness is not pinned

Canonical `VS-SFL-001` is the architectural formation witness. `VS-SFL-002` explicitly describes the two-person case as smoke/debugging evidence only.

Candidate `S3-002` says only that formation is grounded in shared residence, durable connectivity, and two distinct-cycle support events. `S3-011` allows any 2+ core. Those rows can be satisfied solely with the two-person smoke topology.

That leaves multi-person connected-durable-tie structure and the canonical three-founder evidence/Recognition chain unforced.

**Required repair R1:** make the positive formation witness explicitly `VS-SFL-001`-shaped with three founders A/B/C, including:

- connected durable-tie structure over all three;
- two distinct-cycle qualifying support commits;
- independent sufficient founder evidence;
- CandidateRecognition by all three for the same bounded candidate;
- automatic FormationWarrant → H → three founding SustainingParticipants → direct founder H Recognition;
- H Active only at stable closure;
- independently reconstructed warrant provenance;
- earliest retained sustaining-evidence time and formation/reification time both correct and observably distinct.

The 2-person case may remain a smoke companion but may not substitute for the canonical positive witness.

### R3 — exact inherited regression list omits five frozen IDs

A mechanical comparison of candidate §11 against `research/technical/SFL_V0_SLICE3_VERIFICATION_TRIGGER_MAP.md` §9 found 69 candidate IDs versus 74 required prior-protection IDs. Every listed candidate ID is valid against the frozen Slice-1/Slice-2 manifests. The only omissions are:

- `S1-098-COMMUNICATION`
- `S1-META-08`
- `S1-MUT-27`
- `S1-MUT-28`
- `S1-076`

These are the prior Slice-1 obligations explicitly imported/bound by frozen Slice-2 communication/provenance evidence and explicitly retained by the Slice-3 trigger map.

**Required repair R3:** add those five exact IDs to §11's inherited regression bindings and require completion output to report them, without changing their frozen historical status.

### R4 — irrelevant-attribute metamorphic is allowed but not required

The Slice-3 minimum cross-cutting witness set requires an irrelevant-attribute perturbation on representative higher-order histories.

Candidate `F3-META` permits an irrelevant perturbation, but no REQUIRED AcceptanceId obliges execution of one. `S3-104` covers storage/input permutation; `S3-105` ID renaming; `S3-106` locality; `S3-107` observer noninterference; `S3-108` rebuild/cache; `S3-109` fallback quarantine. An implementation can pass all of those and omit the irrelevant-attribute dependency check.

**Required repair R4:** make irrelevant-attribute perturbation an explicit REQUIRED Slice-3 metamorphic obligation, either as a new AcceptanceId or by normatively expanding a current cross-cutting row. It must hold the authoritative causal inputs fixed and vary a declared semantically irrelevant attribute, with `O3-META` as the oracle basis.

## 9. Slice-3 / Slice-4 boundary

**PASS.**

Candidate v1 does not pull the representative-role slice forward.

Slice 3 may implement and prove:

- Household identity/warrants/lifecycle;
- Household Recognition;
- controlled lineage;
- provision commitment state as declared prerequisite setup;
- derived mobilizable capacity;
- termination/persistence semantics for backing state;
- absence of a pooled treasury.

It may not claim:

- endogenous head-scoped provision solicitation/reconsideration;
- head appointment/vacancy/succession;
- head Recognition;
- HouseholdDecisionContext;
- separate Household initiative;
- household-originated support;
- mediated-marriage dowry spending;
- expenditure debit ranking/execution;
- headless collective spending.

`S3-099` and the explicit deferrals correctly preserve this boundary.

## 10. Controlled lineage

**PASS.**

The candidate stays within the accepted narrow classifier:

- successor formation remains independently required;
- division requires predecessor continuation, explicit ended-participation sources, and fresh post-exit person-person support;
- consolidation requires both predecessors Dissolved, unambiguous founder source mapping, and fresh post-dissolution cross-predecessor support;
- ambiguity withholds classification rather than selecting by stable ID;
- `DerivedFrom` is rebuildable from the authoritative LineageWarrant and direct derivation remains distinct from transitive ancestry;
- lineage has no independent behavioral/material/social/Recognition/authority effect and transfers no causal state;
- repeated predecessor rejoin/re-exit histories remain deferred under `LATER-03` / `S3-D03`.

No Director decision is required for the bounded controlled-lineage set.

## 11. Fixture authority and producer provenance

**PASS, subject to RG-01's bounded interpretation above.**

The candidate properly distinguishes:

- formation fixtures that may write lower-level setup but not H/warrants/participants/final Recognition/lifecycle/lineage;
- produced-H fixtures whose H state must come from a previously passing producer rather than hand-authored state;
- entry/end fixtures that may not write their own warrants/continuity/lifecycle results;
- Recognition fixtures that may seed sender-held evidence when sender acquisition is not under test but may not write recipient result or generic observer entitlement;
- lineage fixtures that may not write LineageWarrant/classification;
- provision prerequisite state that may not write capacity or claim acquisition;
- metamorphic/structural fixtures that may not mutate hidden semantic results.

`S3-111-PRODUCED-CHECKPOINT-PROVENANCE` closes VH-03 at the verification-fixture level by requiring producer scenario, pass status, fixture audit, authority version, and output identity.

## 12. Oracle independence

**PASS.**

The `O3-*` classes are independent enough for the candidate claims:

- formation is reconstructed from lower-level history + founder evidence;
- warrant fields are checked against public history/evidence;
- continuity is reconstructed from explicit warrant/event chains;
- lifecycle is independently computed from participation transitions at stable closure;
- H Recognition uses paired public actor epistemic/provenance state;
- lineage independently checks predecessor exits/lifecycle/fresh evidence/source mapping;
- provision capacity uses simple arithmetic over personal state + valid commitment state;
- metamorphics compare paired semantic outputs;
- structural audits inspect source/public structure rather than production classifiers.

The forbidden-production-dependency language is adequate. No production recognizer/classifier/helper may grade its own result.

## 13. Reaction closure / VH-06

**PASS.**

The candidate makes the important closure properties REQUIRED:

- `S3-100` cause-key idempotence;
- `S3-101` monotone Cycle/ReactionIndex/provenance;
- `S3-102` same-cycle derived refresh so later automatic rules see earlier authoritative transitions;
- `S3-103` no fresh same-cycle voluntary activation;
- `S3-108` derived cache/index nonauthority;
- `S3-046` same-cycle bridge handoff semantic priority;
- `S3-050` stable-cycle lifecycle publication only.

This is sufficient to keep formation/participation/continuity/lifecycle/lineage reactions inside ADR-0004's stable-closure contract. A stale/rebuild challenge is naturally required if a behavior-affecting higher-order derived cache exists.

## 14. Prior-regression protection

**BLOCK only for R3; otherwise sound.**

The candidate correctly binds the high-risk inherited sets for:

- objective/subjective separation and no passive synchronization;
- factual and Recognition communication/provenance/staleness;
- initiative/response accounting;
- observer noninterference;
- locality;
- technical fallback/ID quarantine;
- derived-cache nonauthority;
- stable-cycle/reaction closure;
- lower-level relation meaning and no-residence/no-H shortcuts;
- trace/configuration truth;
- frozen Slice-1/Slice-2 authority integrity.

A mechanical validity check found no invalid §11 IDs. R3 is an omission-only repair: add the five exact imported Slice-1 IDs; do not reclassify anything.

## 15. Later-slice leakage audit

**PASS.**

No REQUIRED Slice-3 witness inherently requires:

- multiple candidate-label convergence;
- world actor departure;
- repeated predecessor rejoin/re-exit source selection;
- HouseholdHeadRole or representative succession;
- head Recognition;
- HouseholdDecisionContext / separate Household initiative;
- endogenous provision solicitation/reconsideration;
- actual household material spending;
- mediated-marriage authority topology;
- generic nonparticipant observation;
- checkpoint/restore;
- trust/lying/rumor/reputation;
- a generalized lineage/fission/merger engine.

The four required repairs remain within verification authority and do not pull any of those later substrates forward.

## 16. Director decision

**NO DIRECTOR DECISION REQUIRED.**

All current blockers are already determined by accepted semantics plus frozen/canonical verification authority:

- R1 pins the canonical existing formation witness;
- R2 pins the already-required VH-05 dissolution evidence boundary without inventing negative Recognition semantics;
- R3 restores exact already-frozen regression IDs;
- R4 makes an already-required metamorphic control omission-detectable.

Escalate only if a repaired candidate later discovers that:

1. a REQUIRED path truly needs two CandidateOrganization referents treated as the same candidate;
2. provision capacity cannot be tested without claiming a new headless acquisition semantic;
3. a decisive lifecycle witness cannot be executed through accepted direct-participation/communication provenance;
4. controlled lineage must admit repeated predecessor participation histories;
5. head/authority action becomes necessary for Slice-3 completion;
6. a new continuity-identity ambiguity is discovered beyond accepted warrant rules.

None of those conditions is established by this review.

## 17. Exact repair set before re-review

Apply only verification-authority repairs:

- **R1:** pin the positive formation completion witness to canonical `VS-SFL-001` three-founder shape and require correct/distinct earliest-sustaining versus reification time.
- **R2:** make the decisive-dissolution VH-05 subcase mandatory; allow a specific `Recognized(H continues)` result only for positive current-continuation evidence, while the dissolution subcase asserts factual/provenance update + no safe reliance on stale continuation without inventing a mandatory negative Recognition enum.
- **R3:** add `S1-098-COMMUNICATION`, `S1-META-08`, `S1-MUT-27`, `S1-MUT-28`, and `S1-076` to exact inherited regression bindings.
- **R4:** make irrelevant-attribute perturbation an explicit REQUIRED cross-cutting Slice-3 metamorphic witness.

Do not change RG-01's provision boundary, RG-03's no-adaptation rule, RG-04's no-convergence boundary, controlled lineage semantics, or Slice-3/Slice-4 scope unless separately justified.

After those repairs, submit the exact new candidate bytes to another fresh pre-code review.

## 18. Final disposition

**BLOCK — VERIFICATION-AUTHORITY REPAIR.**

Exact reviewed candidate identity:

- commit: `56f52c0b86d286fee2e076f9ff445ab1059d0d75`
- blob: `e73fab00d779985fc0f96613d14503ed8144fb5d`

**DO NOT FREEZE THIS BLOB UNCHANGED.**

No implementation authority or semantic-promotion authority is granted by this review.
