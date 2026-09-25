# SFL v0 Slice 5 — Fresh Independent Acceptance Candidate1 Pre-Code Review

**Review role:** independent assurance reviewer  
**Review date:** 2026-09-25  
**Authority:** advisory verdict only; accepted semantics, frozen manifests, candidate manifest, implementation and verification authority were not edited

## Exact review target

- candidate ref: `sfl-v0-slice5-acceptance-v1-candidate1`
- exact candidate commit: `1dcfdac9a27679496b1484d5bf183a3f77ba9afc`
- exact manifest path: `plans/verification/SFL_V0/SLICE5_ACCEPTANCE_MANIFEST_CANDIDATE.md`
- exact manifest blob: `97b53dcc6f0e03b7c405b79e6fbc1c885662f8ea`
- candidate version: `SFL-V0-S5-ACCEPTANCE-v1-candidate1`

# Verdict

**BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT**

The block is a **mechanical inherited-authority identity failure**, not a missing Slice-5 semantic decision and not a substantive defect found in candidate1's Slice-5 obligation wording.

The candidate ref, candidate commit, candidate manifest blob, candidate census and exact 435-row inherited REQUIRED expansion all verify correctly. The frozen Slice-1, Slice-2 and Slice-3 refs also resolve exactly to their freeze-record commits.

However, the current ref `sfl-v0-slice4-acceptance-v2` resolves to:

`9d7b93b05d1527303e3d8765df31ace79ebdb196`

while the active Slice-4 v2 freeze record names:

`66fe54c385f42eeb01308f19b63fff7c670b9bbe`

as the freeze commit for that frozen ref and explicitly says not to move `sfl-v0-slice4-acceptance-v2`.

The manifest itself is unchanged: the current ref still carries exact frozen manifest blob `b0bc79e46f82630ab78cd2f0d0414b748212a411`. Comparing the recorded freeze commit to the current ref target shows exactly one later commit, `9d7b93b...`, whose only file change is addition of `SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`. That makes this an administrative/ref-identity defect rather than evidence of changed Slice-4 semantics. But this review packet's identity gate is explicit: frozen prior manifests/refs must remain unchanged, and **if identity differs, BLOCK**. Candidate1 itself also carries `S5-R10-FROZEN-AUTHORITY-INTEGRITY`, which requires frozen Slice-1/2/3/4 manifests/refs/statuses to remain unchanged.

No candidate wording change can legitimately paper over that identity mismatch.

Subject to repair of that inherited ref identity and a fresh rerun of the exact identity gate, I found no additional candidate1 acceptance-coverage, semantic-subordination, omission-detectability or wording defect.

## 1. Independence and source discipline

Before using the Slice-5 discovery/reconciliation returns as corroboration, I independently retrieved and checked the controlling accepted authority and current implementation surfaces at exact candidate commit `1dcfdac...`, including:

- accepted `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted ADR-0004 / DEC-0007 reference-kernel authority;
- accepted DEC-0010 through DEC-0014 where relevant;
- canonical determinism/recovery/explainability and cross-cutting verification contracts;
- frozen Slice-1/2/3 manifests and freeze records;
- frozen Slice-4 v2 manifest and freeze record;
- approved Slice-4 inherited-verification adaptation record;
- current production state, epistemic, Household, role, provision-reconsideration and execution surfaces;
- the TRES-0010 deferred-gap ledger.

Only after forming the provisional semantic/state-census judgment did I use:

- `SFL_V0_SLICE5_AUTHORITY_AND_GAP_INVENTORY.md`;
- `SFL_V0_SLICE5_IMPLEMENTATION_SURFACE_MAP.md`;
- `SFL_V0_SLICE5_VERIFICATION_TRIGGER_MAP.md`;
- `SFL_V0_SLICE5_PREIMPLEMENTATION_RECONCILIATION.md`

as cross-checks.

Accepted SPEC/ADRs/decisions were treated as controlling semantic authority. Current code was used to discover present implementation state/frontiers, never to invent missing social semantics.

## 2. Identity / census / frozen-authority gate: FAIL

### 2.1 Candidate identity: PASS

The candidate branch resolves exactly to:

`1dcfdac9a27679496b1484d5bf183a3f77ba9afc`.

The candidate manifest at that commit resolves exactly to blob:

`97b53dcc6f0e03b7c405b79e6fbc1c885662f8ea`.

### 2.2 Candidate census: PASS

Mechanical parsing gives exactly:

- **95** unique Slice-5 status-bearing AcceptanceIds;
- **81 REQUIRED**;
- **12 DEFERRED**;
- **2 UNEXERCISED**;
- no duplicate Slice-5 AcceptanceIds.

### 2.3 Inherited REQUIRED expansion: PASS

Mechanical comparison against the actual frozen manifest rows gives:

- Slice 1: **128 / 128** REQUIRED IDs, 0 missing, 0 extra;
- Slice 2: **46 / 46** REQUIRED IDs, 0 missing, 0 extra;
- Slice 3: **96 / 96** REQUIRED IDs, 0 missing, 0 extra;
- Slice 4 v2: **165 / 165** REQUIRED IDs, 0 missing, 0 extra;
- total: **435 / 435**.

The qualified frozen Slice-2 status `REQUIRED structural/report` on `S2-045-PINNED-POLICY-NONCLAIM` is correctly part of the 46-member REQUIRED set.

No frozen DEFERRED or UNEXERCISED row is silently promoted through the inherited appendix.

### 2.4 Frozen manifest blobs: PASS

At the exact candidate commit, the prior frozen manifest blobs match their freeze records:

- Slice 1: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- Slice 2: `e4872531cf780d51fa1863f2a0b87e2424a71b69`;
- Slice 3: `1aae13dc27572361fe99c31ef8aee0444d39364a`;
- Slice 4 v2: `b0bc79e46f82630ab78cd2f0d0414b748212a411`.

### 2.5 Frozen refs: FAIL on Slice 4 v2

Current frozen-ref resolution:

- `sfl-v0-slice1-acceptance-v1` -> `55377cc34b8bc3ccbf9cdf5029e9791dae965987` — exact freeze-record commit;
- `sfl-v0-slice2-acceptance-v1` -> `88f876298852553d6afca76e743a5a811ff9f0fd` — exact freeze-record commit;
- `sfl-v0-slice3-acceptance-v1` -> `25160f33c994fd5f3e277ae98f03e55d37c878dd` — exact freeze-record commit;
- `sfl-v0-slice4-acceptance-v2` -> `9d7b93b05d1527303e3d8765df31ace79ebdb196` — **not** the freeze-record commit `66fe54c385f42eeb01308f19b63fff7c670b9bbe`.

The compare is one commit ahead, and that commit adds only the Slice-4 v2 freeze record. The semantic manifest blob is unchanged, but the ref identity does not match the recorded frozen target and the active freeze record says not to move the ref.

The review dispatch makes this identity condition mandatory, so the whole-candidate verdict cannot be PASS.

**Identity/census result: FAIL solely on frozen Slice-4-v2 ref identity.**

## 3. Semantic-subordination review: PASS

I found no candidate1 row that promotes an implementation convenience into new simulation semantics.

The candidate correctly does **not** require:

- a generic pending-process/workflow ontology;
- event-sourced current authority;
- byte-identical checkpoint files or in-memory layout;
- cross-version migration;
- distributed/concurrent snapshot semantics;
- rollback/time travel/alternate-history branching;
- new delayed Household/role transitions;
- actor departure;
- persistence/database architecture;
- a stronger checkpoint exactness claim than accepted SPEC/VS-SFL-082.

This matches accepted ADR-0004: current typed state remains authoritative; consequential commits emit semantic history; safe-point continuation captures all future-influencing state; concrete encoding/storage is engineering-local.

The candidate's `S5-124`, `S5-125`, `S5-126`, `S5-D09`, `S5-D10`, `S5-D11` and `S5-D12` keep those nonclaims explicit.

**Semantic-subordination result: PASS.**

## 4. Future-causal completeness review: PASS

The current kernel's future-causal authority is distributed across multiple partitions rather than fully visible in public snapshots.

Independent current-code census found, among other things:

- `WorldState` objective state plus private RelationId frontier;
- `EpistemicState` actor-held KnownFacts/evidence/provenance, live CandidateReferents and EvidenceId frontier;
- `HouseholdState` Household/lifecycle/warrants/associations/commitments, head roles/transitions, provision-refusal baselines, future-causal ordinary support history, and Household/Warrant/Association/Commitment/HeadRole frontiers;
- Simulation-level `Cycle`, semantic event history, EventId frontier, ProposalId frontier and used-ProposalId duplicate-prevention state;
- scheduled `GrainInput` schedule and active configuration identity.

Candidate1 covers those classes through `S5-010..020`, `S5-040..046`, `S5-093` and the related omission rows.

In particular, public snapshots currently omit several future-causal private values; `S5-093-HIDDEN-FUTURE-STATE-CENSUS` prevents an implementation from treating snapshot serialization alone as evidence of completeness.

I found no additional current allocator/frontier domain missing from the candidate's representation-neutral census. CandidateId and scheduled-input identities are currently supplied externally rather than minted through an internal allocator, while their live semantic state/order is still covered.

**Future-causal completeness result: PASS.**

## 5. Stable-boundary review: PASS

Accepted SPEC §9 establishes the cycle sequence and states that a completed actor-visible cycle exists only after resolution and automatic-reaction closure.

`S5-001..006` correctly require:

- positive checkpoint only at a completed published stable boundary;
- rejection during unresolved proposal/response/central resolution;
- rejection while automatic semantic reactions remain open;
- no normalization of a faulted/truncated cycle into a valid checkpoint;
- restore to the already-published boundary;
- no restore-created same-cycle voluntary activation or replay.

These rows do not prohibit legitimate future-timed state. `S5-017` and `S5-050..054` expressly preserve future scheduled input, debt timing, reconsideration baselines and recurring maintenance.

**Stable-boundary result: PASS.**

## 6. Exact continuation / semantic history / ReactionIndex review: PASS

`S5-030..037` correctly keep checkpoint continuation stronger than the separate inherited isomorphic-ID metamorphic property.

Under identical future inputs/configuration, the candidate requires exact:

- authoritative stable state;
- semantic identities;
- consequential event/history suffix;
- failure/invalidation classification and reason;
- causal predecessor refs;
- evidence IDs/provenance/order;
- technical-fallback candidate/winner/marker;
- consequential `ReactionIndex` ordering.

It does not permit arbitrary restored ID renaming followed by normalized comparison.

### ReactionIndex nuance

The current implementation resets the live in-cycle `reactionIndex` to zero when a new cycle begins. At a safe boundary, the terminal private counter value is therefore not necessarily future-causal by itself.

`S5-036` handles this correctly: the consequential suffix ordering must be exact and monotone, but a terminal private field need not be serialized when the next-cycle frontier is exactly reconstructable. This is appropriately representation-neutral.

### Semantic-history scope

`S5-019`, `S5-031`, `S5-034`, `S5-068` and `S5-125` collectively require enough retained pre-checkpoint semantic provenance to keep live references resolvable and future causal refs exact without forcing event sourcing as current authority or one packaging strategy.

This leaves diagnostic/report-only buffers non-authoritative. Current decision-history style diagnostics need not become recovery state merely because they exist; authoritative semantic provenance that live/future rules reference must remain resolvable.

**Exact-suffix/history result: PASS.**

## 7. ID / frontier completeness: PASS

`S5-040..046` are strong enough to detect the current hidden frontier classes.

The current mutable domains include:

- RelationId;
- EventId;
- ProposalId;
- EvidenceId;
- HouseholdId;
- WarrantId;
- AssociationId;
- CommitmentId;
- HouseholdHeadRoleId.

The candidate requires exact future generated-ID suffix, independent-domain preservation, a real gap/frontier witness, explicit used-ProposalId duplicate prevention, and a prohibition on silently reconstructing an independent frontier by `max(live)+1` without proving exact derivability for every reachable state.

`S5-046` correctly quarantines dictionary/hash/serializer/container enumeration order from semantic ordering and fallback behavior.

**ID/frontier result: PASS.**

## 8. Delayed-state boundary: PASS

The bounded accepted future-timed mechanisms are correctly represented without generic process invention:

- future scheduled exogenous input;
- debt due review;
- provision reconsideration under the latest-refusal baseline and DEC-0014 historical material-need occurrence/provenance;
- recurring cycle maintenance.

`S5-050..055` require exact timing/one-shot behavior and explicitly prohibit promoting this bounded set into generic social PendingProcess/workflow semantics.

No additional accepted current future-timed process requiring a new Slice-5 row was found.

Actor departure remains semantically deferred under ledger item LATER-02 until executable departure is enabled, so `S5-D01` is not an improper deferral.

**Delayed-state result: PASS.**

## 9. Omission-mutant / VH-04 review: PASS

`S5-060..069` plus `S5-085` satisfy the fired VH-04 hardening rule.

Each semantic omission class requires a post-restore suffix that causally depends on the omitted/corrupted state. Parse failure, malformed data, crash, or dead code cannot be credited as proof of the intended semantic omission detector.

The candidate covers the minimum current classes:

- subjective state/evidence;
- provision/reconsideration baseline;
- Household/role/commitment authority;
- future input schedule;
- ID/order/frontier/used ProposalId;
- configuration;
- debt due state;
- favour state;
- required provenance;
- stale derived authority.

Together with `S5-093`, this is sufficiently open to any current private future-causal field not named by representation.

**Omission-mutant result: PASS.**

## 10. Derived/cache nonauthority: PASS

`S5-070..074` preserve the accepted invariant behind `S1-084`, `S1-META-05`, `S1-MUT-24`, `S3-089`, `S3-093` and Slice-4 structural authority controls.

The candidate requires:

- inventory of materialized cache/index/projection surfaces and authoritative rebuild source;
- bounded query equality after discard/rebuild;
- exact future continuation after full rebuild;
- a critical behavior-changing stale-derived challenge;
- no serialized cache/DTO value becoming a second live source of truth.

This is stronger than round-trip equality and does not prescribe a cache implementation.

**Cache/rebuild result: PASS.**

## 11. Conditional inherited-verification adaptation gate: PASS

Candidate1 is correct not to require an unconditional inherited-verification adaptation before Slice-5 coding.

The approved precedent is conditional:

- if a later implementation changes an exact audited private-field inventory or structural checker;
- replaces/invalidates the inherited enforcement form; or
- introduces a new live hidden/stale authority seam not equivalently policed,

then coding must stop before that triggering edit and a separately reviewed lossless adaptation must be approved.

A bounded checkpoint layer can in principle capture/restore existing authority and private frontiers through added checkpoint/verification surfaces without changing the exact inherited `WorldState`/`HouseholdState` field inventories.

`S5-090..093` and §8 of candidate1 therefore match the Slice-3/Slice-4 precedent. The STOP rule is strong enough, and any newly discovered literal witness remains escalation-before-modification.

**Inherited-adaptation gate result: PASS.**

## 12. Fixture / producer / oracle review: PASS

`S5-080..085` correctly require:

- positive checkpoints from real runtime execution at a verified stable boundary;
- producer/pass/fixture/config/output/checkpoint identity;
- direct checkpoint editing only for corruption/mutation;
- production restore/checkpoint machinery not serving as its own sole correctness oracle;
- independent expected state/history/timing/frontier checks based on accepted authority, public semantic state/history and simple arithmetic;
- causal exercise of every semantic omission mutant.

This prevents a serializer/restore round trip from certifying its own completeness.

**Fixture/oracle result: PASS.**

## 13. Inherited regression expansion: PASS mechanically

The candidate's inherited appendix exactly matches every frozen REQUIRED member:

- 128 Slice-1;
- 46 Slice-2;
- 96 Slice-3;
- 165 Slice-4-v2;
- **435 total**.

No frozen checkpoint DEFERRED row is historically reclassified. Slice 5 fires the accepted later capability through new `S5-...` rows and keeps the prior manifest statuses immutable.

This section's **member expansion** is correct even though the separate frozen-ref identity gate fails for Slice-4-v2.

**Inherited expansion result: PASS mechanically.**

## 14. Deliberate DEFERRED / UNEXERCISED review: PASS

The 12 DEFERRED rows remain outside bounded v0 and are not smuggling accepted Slice-5 requirements out of completion:

- actor departure;
- candidate convergence;
- repeated-predecessor lineage;
- contested succession;
- resign-while-participant;
- generic nonparticipant perception;
- general institutional sovereignty;
- trust/rumor/reputation;
- cross-version migration;
- distributed/concurrent snapshots;
- generic workflow/process;
- rollback/time travel/branching.

The two UNEXERCISED rows are also correctly non-gating:

- generated-history/shrinking infrastructure remains non-gating unless VH-02 is separately resolved;
- rendered human causal explanation remains future while machine-readable semantic history remains required.

**Deferral result: PASS.**

## 15. Retrospective Slice-1 SID gate: PASS as procedure; still outstanding

At the candidate baseline, retrospective Slice-1 SID Pass-B has not returned substantive closure. The reconciled frontier says no semantic closure yet, and the Pass-B alias challenge task remains the outstanding negative-space review.

Candidate1 handles this correctly:

- pre-code candidate review may proceed;
- final Slice-5 freeze/coding authorization may not proceed while that material consequence remains unreconciled;
- if retro-SID requires inherited semantic/acceptance repair, that repair must be promoted first and candidate1 must then be checked again for continued exactness.

This review does not decide the retro-SID substantive question.

**Retro-SID gate result: procedurally PASS; gate remains open.**

## 16. Semantic-escalation status: NONE

Accepted authority is sufficient to determine the Slice-5 expected results reviewed here.

I found no required candidate1 result that needs a new Director semantic decision.

The current block is mechanical inherited-authority identity, not semantic escalation.

## 17. Smallest exact repair

The smallest repair is **not** a candidate1 wording change.

1. Reconcile the frozen Slice-4-v2 ref identity so `sfl-v0-slice4-acceptance-v2` again has one unambiguous immutable target consistent with its active freeze authority. Under the present record, that target is the recorded freeze commit `66fe54c385f42eeb01308f19b63fff7c670b9bbe`.
2. Do not edit or reclassify the frozen Slice-4-v2 manifest to accommodate the ref mismatch.
3. Do not edit candidate1 merely to waive the identity gate.
4. Rerun a fresh exact identity/whole-candidate review against unchanged candidate1 after the ref repair.
5. Separately, continue to withhold final freeze/coding authorization until the retrospective Slice-1 SID Pass-B consequence is reconciled.

If project authority instead intends `9d7b93b...` to be the canonical immutable Slice-4-v2 ref target because the freeze-record commit itself is deliberately part of the frozen ref, that intent must first be made explicit and internally consistent in the frozen-authority record/process; this reviewer cannot silently reinterpret the current record's freeze identity.

## Freeze recommendation

**DO NOT FREEZE candidate1 yet.**

Candidate1's substantive Slice-5 completion contract otherwise passed this review and appears suitable to be reconsidered **unchanged** after the inherited Slice-4-v2 ref-identity defect is repaired/reconciled.

Even after that repair, actual freeze/coding authorization still waits for the separate retrospective Slice-1 SID consequence gate required by candidate1.
