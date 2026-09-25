# SFL v0 Slice 5 Discovery B — Implementation Surface and Future-Causal State Map

**Task type:** fresh regular chat / clean context  
**Role:** implementation archaeologist / authoritative-state mapper  
**Authority:** advisory return only; do not modify production code  
**Status:** COMPLETE / RETURN PRESERVED  
**Return:** `research/technical/SFL_V0_SLICE5_IMPLEMENTATION_SURFACE_MAP.md`  
**Return head:** `22df93d168bfe9050664f64898b1d2b368cf7d1c`

## Purpose

Map the verified promoted Slice-4 kernel against the accepted Slice-5 continuation requirements.

Answer:

> What exact current state can influence the future, what is merely derived/rebuildable, what new bounded checkpoint/delayed-process surfaces are required, and where could implementation accidentally turn runtime mechanics into simulation authority?

This is an exhaustive state/architecture inventory, not a design exercise.

## Required sources

Read independently:

- `AGENTS.md`
- accepted SPEC/ADRs/decisions
- current canonical `src/Mesopotamia.Sim/*`
- current canonical acceptance tests/oracles
- IMP-0001 through IMP-0004 final completion records
- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`
- `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- all four frozen acceptance manifests
- current deferred-gap ledger.

Conceptual material may be consulted only as a non-authoritative distinction lens.

## Mandatory mapping

### A. Exhaustive authoritative-state census

Inventory every current field/partition whose value can affect any future authoritative behavior.

At minimum inspect:

#### World/material/social substrate

- people / grain / NeedsGrain;
- dwellings/residence;
- attitudes;
- kinship/marriage;
- debts/favours;
- relation-ID frontier.

#### Epistemic state

- KnownFacts;
- Recognition;
- evidence identities;
- evidence precedence/order/provenance;
- any counters.

#### Household substrate

- Household identities;
- sustaining associations;
- formation/participation/end/continuation/lineage warrants;
- lifecycle;
- candidate referents if they can affect future behavior;
- commitments;
- refusal/cooldown/material-need history;
- Household/role counters.

#### Head/role state

- persistent role identities;
- occupancy;
- transitions;
- actor-held head Recognition/evidence;
- succession/appointment provenance.

#### Simulation/kernel state

- current cycle;
- ReactionIndex or next reaction/order frontier;
- proposal/event/evidence/relation/Household/role IDs/counters;
- initial configuration/rule version;
- scheduled future inputs;
- any pending future work/input/process;
- any deterministic ordering state;
- any future-causal random state if one exists;
- any stored decision/policy state that influences future actor behavior.

For every item classify:

- authoritative / must persist;
- derived / rebuild;
- diagnostic only;
- transient in-cycle only and impossible at safe checkpoint;
- unclear / escalation.

### B. Hidden future-causal state search

Look specifically for mutable fields/counters/statics/closures whose omission could change the future but which are not visible in public semantic snapshots.

Inspect all partial `Simulation` declarations and all mutable state-owning classes.

Flag:

- static mutable state;
- process-global counters;
- collection iteration order relied on semantically;
- random seeds/state;
- implicit current configuration;
- caches with behavior-affecting stale values;
- generated-ID frontiers;
- “initial” inputs used later but not held in authoritative continuation state;
- runtime queues or lists not represented in semantic state.

### C. Existing copy/replay machinery

Map reusable infrastructure already used by:

- detached resolution/replay;
- `WorldState.Copy()`;
- Household/Epistemic copies/snapshots/projections;
- oracle reconstruction;
- stable-boundary publication.

State clearly what these mechanisms **do not** prove about full checkpoint/restore.

### D. Scheduled inputs and delayed work

Trace how future `GrainInput` schedule is currently stored/read.

Identify all other time-based conditions currently evaluated from:

- committed cycle;
- current cycle;
- refusal cycle/baseline;
- debt due cycle;
- future event schedule.

Determine whether exact continuation requires persisting:

- remaining schedule only;
- full original schedule + current cycle;
- explicit consumed-input set;
- additional process identity/provenance.

Do not choose semantics if accepted authority does not determine them.

### E. ID/order/config frontier

Inventory every ID/counter/order mechanism that must continue identically after restore.

Examples:

- RelationId;
- ProposalId;
- EventId;
- EvidenceId;
- Candidate/Household/association/warrant/role IDs;
- ReactionIndex;
- any fallback ordering inputs.

Determine whether these are centralized or distributed across state owners.

Flag any current counter that can only be reconstructed heuristically from “max existing ID” and whether that is semantically safe for exact suffix reproduction.

### F. Cache/index/projection inventory

Identify every current derived or cached surface, including:

- published snapshots;
- HouseholdProjection;
- lineage/ancestor projections;
- mobilizable capacity;
- dependency components;
- candidate/feasibility indexes;
- any precomputed lookup.

For each answer:

- can it be discarded/rebuilt exactly?
- from what authoritative state?
- can stale value affect future behavior?
- is there already executable rebuild evidence?

### G. Likely implementation pressure

Classify files as:

- high-confidence change;
- conditional/watch;
- no expected change.

Inspect at minimum:

- `Simulation.cs` and all partials;
- `State.cs`;
- `EpistemicState.cs`;
- `HouseholdState.cs`;
- `HouseholdHeadState.cs`;
- `Execution.cs`;
- `HouseholdExecution.cs`;
- `HouseholdProjection.cs`;
- `ResolutionDependencies.cs`;
- configuration/rule-version code;
- history/event storage;
- test-access/verification APIs.

### H. Checkpoint representation hazards

Look for temptation to:

- serialize snapshots but omit private authority/counters;
- serialize caches and then trust them as current authority;
- reconstruct IDs from current max values when historical gaps matter;
- ignore consumed future input state;
- checkpoint mid-cycle;
- restore by replaying pre-checkpoint history and accidentally re-executing side effects;
- store only objective state and omit subjective knowledge/Recognition;
- store current role occupant but omit transition/provenance needed by future behavior;
- omit refusal/material-need baselines;
- omit exact configuration/rules identity;
- let file/JSON collection order create semantic order;
- introduce event sourcing as a new current-authority architecture.

### I. Delayed-process architecture pressure

Determine whether accepted Slice-5 behavior appears to require:

- a new bounded process partition;
- extension of existing typed state only;
- scheduled-input generalization;
- or no generic process abstraction at all.

Classify the slice as:

- bounded continuation extension;
- substantial kernel extension;
- architecture redesign.

Do not code.

## Required return

Create:

`research/technical/SFL_V0_SLICE5_IMPLEMENTATION_SURFACE_MAP.md`

on:

`research/slice5-implementation-surface-return`

Record exact base SHA.

End with:

- exhaustive future-causal state table;
- rebuildable-state table;
- delayed-work inventory;
- ID/order/config inventory;
- source pressure;
- architecture hazards;
- escalation triggers;
- slice-size classification.
