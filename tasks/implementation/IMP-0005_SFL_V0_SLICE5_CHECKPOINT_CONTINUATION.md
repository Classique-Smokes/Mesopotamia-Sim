# Implementation Task Packet — IMP-0005 SFL v0 Slice 5 Exact Checkpoint / Restore Continuation

**Task ID:** IMP-0005  
**Commissioned by:** Master Architect  
**Status:** ARCHITECT-DISPATCH READY / IMPLEMENTATION NOT YET ACTIVE  
**Context mode:** CODING-BĀRÛ / PROJECT-CONTEXT — repository authority controls  
**Implementation agent:** Astra  
**Recommended effort:** **HIGH**  
**Implementation branch:** `implementation/imp-0005-slice5-checkpoint-continuation`

## Dispatch authority

Frozen completion authority:

- `plans/verification/SFL_V0/SLICE5_ACCEPTANCE_MANIFEST.md`
- version/ref: `SFL-V0-S5-ACCEPTANCE-v1` / `sfl-v0-slice5-acceptance-v1`
- freeze commit: `f0f32f06cdd607b04df4f14c4bc49bcde4d056bf`
- manifest blob: `1834a1a49203c07af01618066a7e09b25e7e6238`
- native census: **96 = 82 REQUIRED / 12 DEFERRED / 2 UNEXERCISED**
- inherited REQUIRED: **441 = 134 Slice 1 v2 + 46 Slice 2 + 96 Slice 3 + 165 Slice 4 v2**

Final pre-code review:

`research/technical/SFL_V0_SLICE5_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**

Implementation design/adaptation closure:

`research/technical/SFL_V0_SLICE5_IMPLEMENTATION_DESIGN_AND_ADAPTATION_GATE.md`

Release record:

`plans/verification/SFL_V0/SLICE5_IMPLEMENTATION_RELEASE_RECORD.md`

## 1. Objective

Implement the final bounded SFL-v0 slice:

**stable-boundary exact checkpoint/restore continuation plus already-accepted future-timed causal state.**

Under identical future inputs/configuration, restored execution must reproduce exact authoritative semantic state, generated identities/order and consequential history/provenance suffix.

Do not broaden this into a general persistence or workflow subsystem.

## 2. Required implementation shape

Follow the approved design record.

### Live authority

Do not add new authoritative fields to `WorldState` or `HouseholdState`.

Use owner-local methods/constructors/factories and immutable transport DTOs as needed.

Checkpoint DTOs are never ordinary live authority.

### Capture all current future-causal authority

Capture/restore at minimum:

#### WorldState
- People;
- Dwellings;
- Residences;
- Attitudes;
- Kinships;
- Marriages;
- Debts;
- Favours;
- exact `nextRelation`.

#### EpistemicState
- all held KnownFacts/provenance/order/hops;
- CandidateReferents;
- exact `nextEvidence`.

#### HouseholdState
- all current typed Household/lifecycle/warrant/association/commitment/support/head/provision-refusal records;
- exact allocator frontiers:
  `nextHousehold`, `nextWarrant`, `nextAssociation`, `nextCommitment`, `nextHeadRole`.

#### Simulation
- stable Cycle;
- consequential SemanticEvent history/provenance required for exact history/live refs;
- exact `nextEvent`;
- exact `usedProposals`;
- exact `nextProposal`;
- future scheduled GrainInput identity/payload/time/order;
- exact active configuration identity;
- current rules identity compatibility.

Rebuild published snapshots/derived projections after restore.

Do not use semantic-event replay to reconstruct current state.

## 3. DEC-0015 diagonal seam repair

The accepted current code contains a stale fixture-seed helper in `EpistemicState` that applies one generic `a != b` predicate to `AttitudeFact`.

Repair it type-specifically:

- AttitudeFact: endpoints must exist; equality allowed;
- KinshipFact: endpoints exist + distinct;
- MarriageFact: endpoints exist + distinct;
- DebtFact: endpoints exist + distinct;
- FavourFact: endpoints exist + distinct;
- SupportFact: retain its current distinct-party meaning.

Do not generalize this into a global self-relation framework.

Required checkpoint evidence includes a runtime-produced stable-boundary state containing valid `Attitude(P,P)` and corresponding runtime-acquired subjective fact where applicable.

## 4. Stable-boundary API

Expose the smallest useful bounded checkpoint API.

Requirements:

- capture succeeds only at a completed non-faulted stable boundary;
- a faulted/truncated instance cannot produce a valid checkpoint;
- current-cycle unresolved transients are not serialized as pending work;
- restore exposes the exact already-published stable boundary;
- restore does not reactivate the same cycle.

Exact API names, serializer and file format are engineering-local.

## 5. Exact continuation

Required paired execution:

1. produce runtime state through ordinary simulation;
2. capture checkpoint at a safe boundary;
3. continue uninterrupted with a declared future suffix;
4. restore the checkpoint into a separate simulation;
5. apply the identical future suffix;
6. compare each required stable boundary.

Require exact semantic state/history/identity where frozen acceptance says exact.

Do not normalize generated IDs.

## 6. Hidden frontier proof

Exercise real gaps / hidden state, especially:

- EvidenceId supersession gap;
- used ProposalId not inferable from live proposal objects;
- Relation/Event/Proposal/Household/Warrant/Association/Commitment/HeadRole frontiers;
- CandidateReferents declared after construction;
- Household Supports omitted from public HouseholdSnapshot;
- future GrainInput schedule;
- configuration identity.

Do not replace stored frontiers with max-live-ID+1 unless the frozen acceptance's derivability burden is actually satisfied. The expected design is exact frontier capture.

## 7. Delayed/future-timed causal evidence

Require paired uninterrupted/restored suffixes for:

- future scheduled GrainInput;
- Debt due review crossing the post-checkpoint due point;
- DEC-0014 provision reconsideration after checkpoint;
- ordinary recurring maintenance including attitude decay/consumption.

Do not create a generic scheduler/workflow ontology.

## 8. Omission / corruption campaign

Implement semantic omission/corruption controls for S5-060..069 and S5-085.

A credited omission mutant must:

- remain continuable where the intended semantic fault permits;
- reach a suffix that depends on the omitted/corrupted class;
- fail through the intended semantic/history assertion.

Parse failure, crash, timeout or unrelated failure is not sufficient unless the row explicitly concerns invalid checkpoint structure.

Include the DEC-0015 diagonal-Attitude persistence failure direction.

## 9. Derived/cache nonauthority

Declare all materialized derived surfaces actually present.

Prove discard/rebuild equivalence and exact future continuation.

Include at least one behavior-changing stale-derived challenge.

Serialized derived material, if any, must be ignored/rebuilt and cannot become restore authority.

## 10. Structural authority / adaptation STOP

The approved design does **not** trigger inherited-verification adaptation.

STOP before any edit that:

- changes the exact `WorldState` or `HouseholdState` field inventory;
- changes/weakens the exact structural authority checker;
- introduces new hidden future-causal live authority;
- requires serialized derived state to become authoritative;
- requires a new semantic ordering/identity/delayed-process rule.

Return an escalation rather than making that edit.

## 11. Verification and completion reporting

Every **82 native REQUIRED** Slice-5 AcceptanceId must receive substantive evidence.

Every **441 inherited REQUIRED** lower-slice AcceptanceId must execute/report individually green.

All **12 DEFERRED / 2 UNEXERCISED** native Slice-5 rows remain visible and must not be self-promoted.

Required report:

`research/technical/IMP-0005/IMP-0005_COMPLETION_REPORT.md`

The report must include:

- exact frozen manifest/ref/blob;
- exact implementation head;
- changed-file list;
- canonical restore/format/build/test results;
- mapping for all native REQUIRED rows;
- inherited 441-row regression result;
- checkpoint fixture/producer identities;
- mutation/corruption classifications;
- derived-state inventory;
- structural authority inventory check;
- any STOP/escalation encountered.

## 12. Candidate return

Do not merge to `main`.

Return **COMPLETE CANDIDATE** only when all coder-owned REQUIRED obligations are green and the sole external independent-conformance row remains explicitly pending if applicable.

Provide:

- exact branch head SHA;
- canonical CI run identity on that exact head;
- evidence artifact identity/digest where used;
- completion report path;
- changed-file list.

The Master Architect will pin the exact candidate and commission a fresh independent post-implementation conformance review before promotion.

## 13. Explicit exclusions

Do not implement:

- cross-version migration;
- distributed/concurrent snapshots;
- rollback/time travel;
- alternate-history branching;
- event-sourced current authority;
- generic workflow/task/process engine;
- generic persistence framework/database;
- actor departure;
- mature economy/property/accounting;
- new Household/head delayed semantics;
- stochastic-policy redesign.
