# SFL v0 Slice 5 — Implementation Design / Conditional Adaptation Gate Closure

**Status:** MASTER ARCHITECT ENGINEERING DESIGN / ADAPTATION GATE NOT TRIGGERED  
**Date:** 2026-09-25  
**Frozen acceptance:** `SFL-V0-S5-ACCEPTANCE-v1` / `sfl-v0-slice5-acceptance-v1`  
**Freeze commit/blob:** `f0f32f06cdd607b04df4f14c4bc49bcde4d056bf` / `1834a1a49203c07af01618066a7e09b25e7e6238`  
**Final acceptance review:** `research/technical/SFL_V0_SLICE5_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**

## 1. Decision scope

This record selects the simplest sufficient engineering shape for bounded Slice-5 checkpoint/restore.

It does not create new simulation semantics or persistence architecture.

Accepted authority already determines:

- stable-boundary-only checkpointing;
- exact same-version semantic continuation;
- exact future-causal identity/frontier/time/provenance continuation;
- current typed state as authority rather than event replay;
- derived/cache nonauthority;
- configuration/rule identity compatibility;
- no generic workflow/process ontology;
- no cross-version migration.

DTO names, API shape, serialization format and owner-local capture methods are engineering-local.

## 2. Approved implementation shape

### 2.1 Transport DTOs are not live authority

Introduce bounded immutable checkpoint/capture records outside the live state classes.

They may contain exact copies of authoritative records and hidden allocation/frontier state, but ordinary simulation behavior must never read them after restore construction.

Do not create a generic persistence framework, repository, database, event store or workflow engine.

### 2.2 Existing owners capture/restore their own authority

Add methods/constructors/factories as needed to the existing owners:

- `WorldState`;
- `EpistemicState`;
- `HouseholdState`;
- `Simulation`.

Do not add new live authoritative fields merely to support checkpointing.

The exact existing `WorldState` and `HouseholdState` authoritative field inventories remain unchanged.

### 2.3 World capture

Capture/restore exactly:

- People;
- Dwellings;
- Residences;
- Attitudes, including valid `Attitude(P,P)`;
- Kinships;
- Marriages;
- Debts;
- Favours;
- `nextRelation`.

Type-specific DEC-0015 validation remains authoritative.

### 2.4 Epistemic capture

Capture/restore exactly:

- actor-held `KnownFact` records and provenance/order/hops;
- CandidateReferents;
- `nextEvidence`.

Recognition projections are rebuilt from backing facts/referents rather than independently trusted.

Repair the current fixture-seed proposition validator so `AttitudeFact(P,P)` follows DEC-0015 while Kinship/Marriage/Debt/Favour/Support distinct-party rules remain type-specific.

This repair changes no state field inventory.

### 2.5 Household capture

Capture/restore all existing typed Household authority exactly, including:

- Households;
- Formations;
- Associations;
- Entries;
- Exits;
- Continuations;
- Lineages;
- Commitments;
- Supports;
- HeadRoles;
- HeadTransitions;
- ProvisionRefusals;
- `nextHousehold`;
- `nextWarrant`;
- `nextAssociation`;
- `nextCommitment`;
- `nextHeadRole`.

Derived queries/projections remain rebuildable.

### 2.6 Simulation/kernel capture

Capture/restore future-causal engine authority including:

- current stable `cycle`;
- consequential `SemanticEvent` history/provenance required for exact history and live references;
- `nextEvent`;
- `usedProposals`;
- `nextProposal`;
- scheduled `GrainInput` state/order required for future execution;
- active configuration version;
- compatible current rule identities.

The public/diagnostic published snapshots must be rebuilt from restored authority rather than trusted as checkpoint authority.

Diagnostic `decisionHistory` and legacy observer `knowledge` must not become future-causal authority. If retained for observer continuity, they remain explicitly nonauthoritative.

### 2.7 Stable-boundary ownership

Checkpoint capture is valid only when the synchronous single-process kernel is at a completed, non-faulted stable cycle boundary.

Do not serialize an unfinished proposal/response/resolution/reaction stack as pending work.

No new live pending-process field is authorized.

### 2.8 Restore construction

Restore constructs current typed state directly from checkpoint authority.

Do not replay pre-checkpoint semantic events to reconstruct current state.

After construction:

- validate exact configuration/rule compatibility;
- rebuild published snapshots/projections;
- preserve exact future ID/frontier behavior;
- continue from the next accepted cycle boundary.

## 3. Conditional inherited-verification adaptation result

**NOT TRIGGERED for the approved design.**

Reasons:

1. The exact audited `WorldState` field inventory remains unchanged.
2. The exact audited `HouseholdState` field inventory remains unchanged.
3. Owner-local methods/constructors/factories do not change those inventories.
4. New checkpoint DTO types are not live state authority.
5. Existing structural authority checks remain valid and are not weakened.
6. The EpistemicState DEC-0015 validation repair changes local validation semantics already fixed by accepted authority; it does not add hidden authority or change an audited field inventory.
7. Derived snapshots/caches remain rebuilt/non-authoritative.
8. No new hidden/stale live authority seam is introduced by the design.

Therefore a separate inherited-verification adaptation review is not required **before coding this approved shape**.

## 4. Mandatory implementation stop triggers

The coding bārû must STOP before any edit that would:

- add/remove/change an authoritative `WorldState` or `HouseholdState` field and require changing the exact field-inventory witness;
- weaken or replace the inherited structural authority checker;
- make a checkpoint DTO, serialized cache, projection or event replay a second/current live source of truth;
- introduce a new behavior-affecting hidden field not covered by frozen acceptance;
- reconstruct an ID frontier heuristically where exact capture is required;
- add generic pending-process/workflow semantics;
- require a new social/temporal rule not uniquely fixed by accepted authority.

If any trigger fires, create an escalation before making the triggering edit.

## 5. Verification consequences

Implementation must satisfy the frozen 82 native REQUIRED rows plus all 441 inherited REQUIRED rows.

Particular high-risk proof obligations include:

- runtime-produced checkpoint carrying `Attitude(P,P)`;
- exact hidden frontier capture;
- EvidenceId gap continuation;
- used-ProposalId duplicate prevention;
- exact future GrainInput timing;
- Debt due timing;
- DEC-0014 provision reconsideration history;
- omission mutants with causally dependent suffixes;
- derived-state discard/rebuild equivalence;
- critical stale-derived fault control;
- no replay of pre-checkpoint effects;
- exact consequential history/provenance suffix.

## 6. Release judgment

**BOUNDED SLICE-5 IMPLEMENTATION MAY BE COMMISSIONED** under the exact frozen acceptance and this design.

This is not permission for broader persistence/process architecture.
