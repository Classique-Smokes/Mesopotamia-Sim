# SFL v0 Slice 5 Discovery C — Verification Trigger and Acceptance Applicability Map

**Task type:** fresh regular chat / clean context  
**Role:** verification authority mapper  
**Authority:** advisory return only; do not edit frozen manifests  
**Status:** ARCHITECT-DISPATCHED / READY

## Purpose

Determine exactly which accepted Stage-3 verification obligations become live for Slice 5 and what a separate Slice-5 acceptance/applicability authority must make omission-detectable.

This is the final SFL-v0 slice. It must prove exact continuation without allowing checkpoint implementation to redefine what counts as authoritative state.

## Required sources

Retrieve independently:

- accepted SPEC/ADRs/decisions;
- all canonical `plans/verification/SFL_V0/*` families;
- frozen Slice-1/2/3/4 manifests + freeze records;
- IMP-0001 through IMP-0004 final completion records;
- current promoted production/test boundary;
- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`;
- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`.

## Mandatory work

### A. Fired deferred checkpoint obligations

Inventory and classify every previously deferred checkpoint/restore obligation now triggered, including at minimum:

- `S1-082` checkpoint exact suffix;
- `S1-083` omitted checkpoint state detected;
- `S1-META-06` checkpoint metamorphism;
- `S1-MUT-25` omit future-influencing checkpoint state;
- `S2-D07-CHECKPOINT-SUBJECTIVE-STATE`;
- `S3-D10-CHECKPOINT-RESTORE`;
- `S4-D01-CHECKPOINT-RESTORE`;
- VS-SFL-082;
- VS-SFL-083;
- VS-SFL-084 rebuild equivalence;
- VH-04 omission-mutant suffix requirement.

Identify any other deferred row that genuinely fires because delayed processes become executable.

### B. Minimum exact-continuation witnesses

Specify the minimum independently observable checkpoint pair(s) needed to exercise, in one or a bounded set of scenarios:

- objective material/social state;
- subjective knowledge/Recognition including stale/Contested state;
- Household identity/lifecycle/participation;
- head role/occupancy/Recognition;
- provision commitments;
- DEC-0014 refusal/material-need baseline;
- active debt with future due behavior;
- outstanding favour;
- scheduled exogenous input;
- technical fallback state where relevant;
- generated ID/counter frontier;
- rule/configuration identity;
- semantic history suffix.

Require uninterrupted vs restored comparison at each subsequent stable boundary.

### C. Omission mutants

Design omission-detectable mutants that remove one future-causal class at a time.

At minimum:

- subjective knowledge/Recognition;
- provision/reconsideration baseline;
- Household/role state;
- pending future input/process;
- identifier/order/counter state;
- configuration/rules version.

For each mutant specify a **continuation suffix that actually exercises the omitted state**.

A mutant that crashes before semantic continuation does not automatically count as detecting the intended omission.

### D. Safe-boundary enforcement

Require executable negative controls proving:

- checkpoint at stable post-closure boundary succeeds;
- checkpoint request during resolution/reaction closure cannot yield a valid safe checkpoint;
- restore never publishes or resumes from a partially closed cycle;
- no same-cycle voluntary reactivation is introduced through checkpoint machinery.

### E. Exact history suffix

Specify what comparison must include:

- Cycle;
- ReactionIndex;
- EventId / ProposalId / evidence/role/etc. identities where accepted;
- event meanings/results;
- causal predecessor references;
- failures/invalidation reasons;
- fallback markers;
- decision-trace linkage;
- actor-held evidence/provenance;
- rule/config version.

Identify where normalization is legitimate only for **derived comparison tooling** and must not weaken exact engine-continuation obligations.

### F. ID/order continuity

Require witnesses proving restore preserves future generated identities/order exactly.

Include cases where:

- IDs have gaps;
- multiple ID domains advance independently;
- later actions allocate relations/events/evidence/Household/role/proposal identities;
- technical fallback depends on stable semantic IDs only where accepted.

Prevent “reconstruct next ID as max+1” from silently passing if the actual authoritative frontier differs.

### G. Scheduled input / delayed-process continuation

Require evidence that:

- already-consumed future input is not re-applied;
- not-yet-due input executes at the same semantic time after restore;
- debt due/review behavior occurs at the same cycle;
- provision cooldown/reconsideration unlocks at the same cycle;
- any explicit new delayed-process state retains provenance and revalidates correctly.

If delayed-process semantics are not fully determined, identify an acceptance blocker rather than inventing a test expectation.

### H. Cache/derived rebuild equivalence

Re-evaluate inherited S1-084/S1-META-05 and VS-SFL-084 in the fully populated Slice-5 state.

Require:

- discard/rebuild of every declared derived cache/index/projection;
- identical query answers;
- identical future state/history suffix under same inputs;
- stale-cache mutant cannot influence behavior.

Identify any inherited structural witness whose enforcement form necessarily changes when checkpoint state is added. If so, flag a required inherited-verification adaptation review before coding.

### I. Fixture / producer authority

Define how checkpoint test fixtures are produced.

A checkpoint under test must come from a verified runtime producer, not direct fixture-writing of final serialized authority.

Require producer provenance:

- base scenario;
- exact runtime checkpoint cycle;
- fixture write audit;
- authority/config version;
- output identity/pass state.

Directly editing serialized bytes is allowed only for explicit corruption/mutation tests.

### J. Oracle independence

Define what independent continuation checking may share versus must reconstruct independently.

Do not let production restore code serve as its own oracle for:

- omitted-state detection;
- cache rebuild equivalence;
- ID/counter continuity;
- semantic suffix comparison.

### K. Inherited regressions

Identify exact prior-slice obligations most vulnerable to checkpoint work, including:

- objective/subjective separation;
- no passive knowledge sync;
- Household/role identity continuity;
- provision/private-X provenance;
- DEC-0014 refusal baseline;
- stable closure;
- fallback quarantine;
- observer noninterference;
- locality;
- cache/derived nonauthority;
- exact rule/configuration truth;
- no treasury/general economy leakage.

### L. Acceptance-authority readiness

Return whether Slice-5 acceptance can be drafted immediately after discovery reconciliation.

Identify blockers as one of:

- semantic gap;
- inherited-verification adaptation required;
- implementation-local issue only;
- no blocker.

## Required return

Create:

`research/technical/SFL_V0_SLICE5_VERIFICATION_TRIGGER_MAP.md`

on:

`research/slice5-verification-trigger-return`

Record exact base SHA.

End with:

- fired deferred rows;
- new Slice-5 completion witnesses;
- omission mutants;
- exact inherited regressions;
- fixture/oracle rules;
- any inherited-adaptation trigger;
- acceptance-manifest blocker status.
