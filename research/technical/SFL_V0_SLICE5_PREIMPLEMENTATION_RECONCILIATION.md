# SFL v0 Slice 5 — Preimplementation Reconciliation

**Status:** MASTER ARCHITECT RECONCILED / READY FOR ACCEPTANCE CANDIDATE REVIEW  
**Date:** 2026-09-25  
**Canonical discovery baseline:** `664311fffbc4475e3924221f58633b3a4f63a8a9`  
**Authority:** Master Architect reconciliation; does not create semantics beyond accepted SPEC/ADRs/decisions  
**Coding status:** NOT AUTHORIZED

## 1. Inputs

Independent Slice-5 discovery returns:

- A — `research/technical/SFL_V0_SLICE5_AUTHORITY_AND_GAP_INVENTORY.md`
- B — `research/technical/SFL_V0_SLICE5_IMPLEMENTATION_SURFACE_MAP.md`
- C — `research/technical/SFL_V0_SLICE5_VERIFICATION_TRIGGER_MAP.md`

All three were produced from the same canonical Slice-5 dispatch baseline and each return branch added only its assigned report.

Parallel inherited-assurance thread:

- `tasks/research/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`
- immutable dispatch ref `sfl-v0-slice1-retro-sid-passb-dispatch-v1`
- **return not yet present at this reconciliation**

The retro-SID thread does not block acceptance drafting/review, but any material inherited Slice-1 semantic/acceptance repair must be reconciled before Slice-5 acceptance freeze or coding authorization.

## 2. Reconciled verdict

### Semantic readiness

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

Discovery A and C independently found no consequential Slice-5 semantic gap. Discovery B found substantial engineering pressure but no architecture redesign requirement and no missing social rule.

The accepted SFL v0 semantics already determine:

- safe checkpoint boundary;
- exact-continuation requirement;
- future-causal state criterion;
- subjective-state continuation;
- Household/role/provision continuation;
- debt/cooldown/scheduled-input timing;
- identifier/order/configuration continuity;
- derived-cache nonauthority;
- exact consequential history suffix;
- same-configuration continuation boundary.

### Architecture classification

**SUBSTANTIAL KERNEL EXTENSION — NOT ARCHITECTURE REDESIGN.**

Slice 5 is cross-cutting because checkpoint capture/restore spans all current authority owners and hidden frontiers, but the accepted reference-kernel architecture already anticipates this capability.

Do not introduce:

- event sourcing as current authority;
- database/storage architecture;
- generic process/workflow ontology;
- distributed snapshotting;
- rollback/time travel;
- cross-version migration semantics.

## 3. Exact Slice-5 semantic boundary

Slice 5 implements and verifies:

> **stable-boundary exact continuation of the accepted SFL-v0 simulation, including all future-influencing authoritative state and already-accepted future-timed causal state.**

A valid checkpoint represents the already-published completion frontier of a cycle after:

1. all immediate proposals/responses have terminal results;
2. central resolution/revalidation is complete;
3. all automatic semantic reactions have closed;
4. lifecycle/cycle-level publication is complete;
5. no fresh same-cycle voluntary activation remains.

A restore resumes from that same semantic frontier.

Current-cycle proposal/response/resolution/reaction transients are not legitimate checkpoint-pending state.

## 4. Delayed-process reconciliation

Current accepted future-timed causal mechanisms are sufficient for Slice 5:

- debt due/review timing;
- provision refusal/reconsideration cooldown and DEC-0014 historical material-need baseline;
- scheduled future exogenous GrainInput;
- recurring cycle maintenance determined by semantic time + current state/rules.

No current Household/head transition crosses stable closure as unfinished work.

Therefore:

> **No generic PendingProcess/workflow primitive is required or authorized.**

If implementation discovers an actually accepted future-causal mechanism not representable by the current typed state/input boundary, that discovery is an escalation before generalizing process semantics.

## 5. Future-causal authority census

The following categories are authoritative continuation state or require an exactly sufficient persisted equivalent.

### 5.1 World/material/social

- People, including identity/name/sex/grain/NeedsGrain;
- dwellings;
- residence;
- attitudes;
- kinship;
- marriage + origin;
- debts, including timing/review/origin;
- favours + origin;
- RelationId allocation frontier.

### 5.2 Subjective/epistemic

- actor-held KnownFacts;
- EvidenceId;
- proposition;
- acquisition route;
- source event/actor;
- EvidenceOrder;
- fixture provenance;
- communication hops;
- live CandidateReferents;
- evidence allocation frontier.

Derived CandidateRecognition / HouseholdRecognition / HeadRecognition projections remain rebuildable from accepted underlying evidence/referents and are not independent recovery authority.

### 5.3 Household / lineage / provision / head

Persist or exactly reconstruct:

- Household identities/lifecycle;
- formation, participation, end, continuation and lineage warrants;
- sustaining associations;
- ordinary support history that remains future-causal;
- provision commitments + typed provenance;
- persistent head roles;
- head transition provenance;
- provision refusal/reconsideration baseline;
- eligible-support cohort baseline;
- DEC-0014 material-need occurrence provenance;
- all Household/warrant/association/commitment/head-role allocation frontiers.

### 5.4 Kernel / temporal / ordering

Persist or exactly reconstruct:

- current Cycle;
- consequential semantic event/provenance graph needed by live references and exact suffix;
- EventId frontier;
- ProposalId frontier;
- exact used-ProposalId set or exactly equivalent duplicate-prevention authority;
- not-yet-consumed future input schedule / exact equivalent;
- active configuration identity/version;
- active accepted rule identity compatibility.

At a safe boundary the live in-cycle ReactionIndex field may be reset/rebuilt as ordinary next-cycle state if and only if post-restore consequential ReactionIndex suffix remains exactly identical. The already-emitted historical indices remain semantic history.

### 5.5 Explicit nonauthority

Do not persist as a second authority merely for convenience:

- published snapshots;
- lineage projections;
- MobilizableCapacity;
- current-head/action-availability projections;
- Recognition lookup caches;
- funding-plan caches;
- dependency indexes;
- candidate/feasibility indexes;
- dictionary/hash iteration layout;
- diagnostic stacks/cursors;
- decision trace buffers as behavioral authority.

## 6. Exact continuation reconciliation

Under the same checkpoint, same future inputs and identical rules/configuration, uninterrupted and restored runs must preserve exactly:

- authoritative semantic state at each compared stable boundary;
- existing semantic identities;
- newly generated semantic identities/order;
- Cycle;
- consequential ReactionIndex ordering;
- commit/failure/invalidation outcomes and reasons;
- causal predecessor references;
- fallback markers and fallback-sensitive winner under unchanged IDs;
- actor-held KnownFact/Recognition evidence/provenance;
- debt due timing;
- provision reconsideration timing/context;
- scheduled future input execution;
- active rule/configuration identity;
- consequential history suffix.

No pre-checkpoint semantic effect or automatic reaction may execute twice.

Serialization bytes, object addresses, DTO decomposition, dictionary bucket layout, compression and property order are not required to match.

## 7. Configuration / version reconciliation

Accepted exact continuation requires **identical configuration/rules**.

A restore under different/unknown/unavailable configuration does not satisfy the exact-continuation precondition.

Slice 5 need not invent:

- migrations;
- upgrades/downgrades;
- compatibility transforms;
- best-effort continuation under changed semantics.

Rejection/compatibility-report representation is engineering-local so long as mismatched rules cannot silently masquerade as valid exact continuation.

## 8. Verification trigger reconciliation

Previously deferred checkpoint obligations now fire through new Slice-5 completion rows while frozen lower-slice manifests remain unchanged.

Explicitly activated obligations include:

- S1-082;
- S1-083;
- S1-META-06;
- S1-MUT-25;
- S2-D07-CHECKPOINT-SUBJECTIVE-STATE;
- S3-D10-CHECKPOINT-RESTORE;
- S4-D01-CHECKPOINT-RESTORE;
- VS-SFL-082;
- VS-SFL-083;
- TRES-0010 VH-04.

Already-live inherited obligations must also be re-exercised against the fully populated Slice-5 state, especially:

- S1-084 / S1-META-05 / S1-MUT-24;
- S3-089 / S3-093;
- Slice-4 structural/capacity/provenance/derived-state constraints.

Frozen lower-slice statuses are never rewritten. Slice 5 activates later capability through new S5 AcceptanceIds.

## 9. Required completion witness families

Acceptance candidate1 must make omission-detectable at least:

### W1 — cross-domain exact continuation

A runtime-produced checkpoint carrying:

- objective world state;
- stale/Contested subjective state;
- Household/lifecycle/participation;
- role/occupancy/head Recognition;
- commitments;
- DEC-0014 reconsideration baseline;
- active debt;
- outstanding favour;
- future GrainInput;
- pre-checkpoint causal refs;
- explicit configuration identity.

The suffix must actually exercise those states.

### W2 — ID/order/frontier continuation

A checkpoint with multiple independently advanced ID domains, at least one real gap, and a used ProposalId that is re-submitted after restore.

Continuation must preserve exact next identities/order and duplicate-proposal behavior.

### W3 — full derived rebuild equivalence

Discard/rebuild every declared derived cache/index/projection at a safe boundary, compare queries, then continue and compare the exact suffix.

### W4 — safe-boundary enforcement

Positive stable-boundary capture plus negative mid-resolution, mid-reaction and faulted/truncated-cycle capture challenges.

## 10. Omission / corruption requirements

At minimum independently challenge omission/corruption of:

- subjective evidence/Recognition;
- provision/refusal/material-need baseline;
- Household/role/provision state;
- pending future input;
- identifier/order/frontier/used-ProposalId state;
- configuration/rules identity;
- debt due state;
- favour state;
- live causal/provenance refs;
- derived/cache state trusted as authority.

Every semantic omission mutant must have a suffix that actually uses the omitted state.

Parse failure alone is robustness evidence, not proof of the intended semantic omission detector.

## 11. Hidden-state implementation risks

Discovery B established concrete future-causal state that current public snapshots omit, including:

- WorldState.nextRelation;
- EpistemicState.candidates;
- EpistemicState.nextEvidence;
- HouseholdState.Supports;
- Household allocation frontiers;
- Simulation.nextEvent;
- Simulation.nextProposal;
- Simulation.usedProposals;
- future InitialWorld.Inputs;
- Configuration.Version;
- retained semantic-event provenance.

This is expected Slice-5 implementation work, not a new semantic gap.

The acceptance candidate must make these *semantic invariants* omission-detectable without requiring those current field names or layouts.

## 12. Inherited-verification adaptation gate

No unconditional adaptation is required before acceptance drafting.

A separately reviewed lossless inherited-verification adaptation **must** fire before the triggering coding/test edit if implementation:

- changes an exact audited WorldState/HouseholdState authority inventory;
- replaces/weakens NoDerivedAuthorityStructuralAudit or its Household counterpart;
- adds a new live hidden/stale authority seam;
- serializes a derived cache/index/projection and then trusts it as independent current authority;
- otherwise invalidates S1-084/S1-META-05/S1-MUT-24, S3-093 or the approved Slice-4 structural enforcement form.

If fired, adaptation must include a critical-seam hidden/stale-authority mutant. A generic unrelated extra-field mutant is insufficient.

## 13. Parallel retrospective Slice-1 SID gate

The retrospective Slice-1 SID Pass-B return is still outstanding.

Disposition:

- does **not** block Slice-5 acceptance drafting or independent pre-code review;
- **does block final Slice-5 acceptance freeze/coding authorization** until reconciled if still outstanding;
- if it establishes a material inherited semantic/acceptance repair, reconcile/promote that repair before freezing Slice-5 completion authority.

## 14. Director-decision status

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

No accepted Slice-5 semantic gap remains after A/B/C reconciliation.

## 15. Acceptance-readiness judgment

**READY FOR SLICE-5 ACCEPTANCE CANDIDATE DRAFTING AND FRESH PRE-CODE REVIEW.**

Not yet authorized:

- Slice-5 acceptance freeze;
- Slice-5 coding bārû;
- generic persistence/process architecture.

Freeze requires:

1. fresh candidate review PASS;
2. retrospective Slice-1 SID Pass-B consequence reconciled;
3. any resulting inherited repair promoted before freeze if necessary.
