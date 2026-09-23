# Implementation Task Packet — SFL v0 Reference Slice 2: Subjective Knowledge and Recognition

**Task ID:** IMP-0002  
**Commissioned by:** Master Architect  
**Status:** VERIFIED COMPLETE  
**Frozen candidate:** `imp-0002-slice2-conformance-candidate-v1` @ `5a452078c845b8aa4cc2756f5638517dce87e6e8`  
**Fresh independent conformance:** **PASS — PROMOTE**  
**Canonical promotion:** `3887d1d9984f5606c816afb84365cc3f455f52b4`  
**Post-promotion CI:** `35833252462` — **PASS**  
**Completion record:** `../../research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`  
**Context mode:** CODING-PRIEST CONTEXT / repository authority controls  
**Planned implementation branch:** `implementation/imp-0002-slice2-epistemic`

## Dispatch gate

Slice-2 pre-implementation discovery is reconciled and the completion authority is frozen.

Frozen acceptance authority:

- manifest: `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md`
- version: `SFL-V0-S2-ACCEPTANCE-v1`
- frozen ref: `sfl-v0-slice2-acceptance-v1`
- freeze commit: `88f876298852553d6afca76e743a5a811ff9f0fd`
- frozen manifest SHA: `e4872531cf780d51fa1863f2a0b87e2424a71b69`
- final pre-code review: **PASS — MAY FREEZE UNCHANGED**
- freeze record: `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_FREEZE_RECORD.md`

No implementation work may weaken or reinterpret that authority.

## 1. Objective

Extend the verified Slice-1 reference kernel with the bounded SFL v0 Slice-2 epistemic substrate:

- persistent actor-specific `KnownFact`;
- actor-specific `Recognition` with `Unknown / Recognized / Contested`;
- provenance-bearing factual and Recognition communication;
- stale subjective state;
- accepted evidence-order precedence;
- the exact bounded `CandidateRecognition(C)` conflict witness needed for `Contested`;
- subjective candidate gating and trace integration;
- read-only epistemic inspection.

The result must remain a deterministic vertical slice and preserve all frozen Slice-1 contracts.

This is a **bounded extension of the existing kernel**, not a redesign.

## 2. Required inputs by authority class

### Accepted semantic / architectural authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted ADRs under `architecture/accepted/`, especially:
  - ADR-0001 active social state representation;
  - ADR-0002 hierarchical individual agency;
  - ADR-0004 reference simulation kernel;
  - ADR-0005 host runtime.

These control meaning and architecture.

### Frozen verification / completion authority

- `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_FREEZE_RECORD.md`
- version/ref/commit/SHA listed in the dispatch gate above.

This defines completion applicability. It does not create social semantics.

Slice-1 frozen authority remains in force for exact regression bindings:

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`.

### Required non-authoritative supporting / engineering context

- `research/technical/SFL_V0_SLICE2_AUTHORITY_INVENTORY.md`
- `research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md`
- `research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md`
- `research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md`
- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- `AGENTS.md`

Conceptual tablet artifacts are **not** implementation authority.

Precedence:

1. accepted SPEC/ADRs;
2. frozen Slice-2 acceptance authority;
3. frozen Slice-1 regression authority;
4. engineering/supporting context.

## 3. Scope

### 3.1 Persistent epistemic state

Extend authoritative future-influencing state so actor-specific subjective state is explicit and inspectable.

Support only the frozen manifest's bounded completion proposition census:

- KF-OWN;
- KF-DIRECT-CLAIM;
- KF-PARTICIPATION;
- KF-REPORT;
- RC-CANDIDATE.

Representation is implementation-local provided:

- objective state and subjective state remain distinct;
- provenance is retained;
- actor policy cannot read objective truth as universal knowledge;
- no hidden behavior-affecting cache becomes authority;
- stable semantic identity/order is explicit.

Do not turn `ParticipantOutcome` into the entire `KnownFact` model merely because it already exists. Preserve its Slice-1 privacy/outcome semantics while integrating or adapting it coherently.

### 3.2 Acquisition

Implement accepted automatic acquisition routes:

- own objective state;
- direct-party relation/claim facts;
- direct proposal/event participation;
- already-accepted direct-participant failed-attempt outcomes.

Do not implement generic nonparticipant perception.

### 3.3 Recognition

Implement the accepted Recognition layer separately from:

- objective truth;
- KnownFact;
- Attitude;
- approval;
- obedience/compliance.

Support `Unknown / Recognized / Contested` for the bounded Slice-2 `CandidateRecognition(C)` completion case.

Preserve CandidateRecognition ephemerality and provenance.

Implement the exact frozen RG-01 boundary; do not generalize it into:

- CandidateOrganization equivalence;
- Household formation;
- universal factual-conflict algebra;
- universal evidence-strength rules.

### 3.4 Communication

Add `CommunicateClaim/Inform` to the ordinary personal-action pipeline.

Both factual and Recognition communication must independently obey:

- sender-held proposition gate;
- no invention;
- provenance retention;
- ordinary personal initiative cost;
- intended-recipient-only delivery;
- no free broadcast;
- receipt creates no fresh same-cycle personal activation;
- receipt creates no `ResponseDecisionContext` merely because a message arrived;
- normal stable-cycle visibility.

Pinned laboratory policy may choose action/recipient/proposition for tests. Do not invent historically meaningful autonomous communication motivation.

### 3.5 Evidence ordering and staleness

Implement only accepted bounded precedence:

- no passive synchronization;
- stale state retained absent an accepted update;
- newer direct-participation evidence beats later-delivered older incompatible reports where SPEC says so;
- newer event-backed communication may supersede older reports where SPEC says so;
- delivery order does not replace underlying semantic event order;
- unresolved incompatible Recognition evidence yields `Contested`;
- stable IDs/sender IDs/container order/arrival order are never Recognition winner rules.

### 3.6 Agency / decision membrane

Preserve `PersonalInputCapture` or an equivalently bounded actor-specific membrane.

Integrate KnownFact/Recognition into candidate generation/gating without exposing the full objective snapshot.

Required causal cases include:

- KnownFact-gated factual communication;
- Recognition-gated Recognition communication.

Gates precede scoring.

Full traces must expose the actual subjective/provenance basis used.

### 3.7 Public / verification inspection

Expose immutable/read-only actor-specific epistemic state and provenance sufficient for the frozen acceptance authority and fresh conformance review.

Inspection must be observer-noninterfering and must not become a policy backdoor into omniscient history.

### 3.8 Documentation / configuration

Update implementation documentation that currently correctly says general recognition/communication are absent.

Semantic/decision history must truthfully identify the active Slice-2 configuration/profile version.

Exact naming/layout is local implementation discretion.

## 4. Primary implementation surfaces

High-confidence bounded extension surfaces from discovery:

- `src/Mesopotamia.Sim/State.cs`
- `src/Mesopotamia.Sim/PersonalDecisionInputs.cs`
- `src/Mesopotamia.Sim/Execution.cs`
- `src/Mesopotamia.Sim/Decisions.cs`
- `src/Mesopotamia.Sim/Agency.cs`
- `src/Mesopotamia.Sim/Simulation.cs`
- `src/Mesopotamia.Sim/VerificationAccess.cs` where useful
- `src/Mesopotamia.Sim/README.md`
- `tests/Mesopotamia.Sim.AcceptanceTests/*`

Conditional watch only:

- `src/Mesopotamia.Sim/ResolutionDependencies.cs`

Change that subsystem only if actual accepted Slice-2 writes create same-cycle noncommutativity not already resolved by accepted evidence-order semantics. If a semantic ordering choice is required, escalate.

No direct Slice-2 pressure:

- `src/Mesopotamia.Sim/MaterialRecovery.cs`

## 5. Explicitly out of scope

Do not implement or stub for IMP-0002:

- persistent Household / CandidateOrganization lifecycle beyond the inert bounded RC-CANDIDATE referent required by frozen acceptance;
- FormationWarrant / ParticipationWarrant;
- SustainingParticipant / household participation mechanics;
- Household provision/capability;
- HouseholdHeadRole / office occupancy / succession;
- household-mediated marriage;
- lineage;
- actor arrival/departure rules merely as convenient observation fixtures;
- checkpoint/save-load;
- generic perception radius/visibility;
- trust/reliability scoring;
- deliberate lying / invented claims;
- rumor mutation;
- reputation;
- brokerage/effective centrality;
- role-conditioned salience;
- richer memory degradation;
- strategic/multi-step planning;
- stochastic behavior;
- generic graph database / ontology framework;
- event-sourced authority;
- concurrency/parallel execution;
- a universal proposition language;
- a universal evidence/conflict algebra.

Do not use `WorldSnapshot` or `History` as universal actor knowledge.

## 6. Required inherited invariants

Preserve:

- current typed in-memory state is authoritative; history is provenance/diagnostic history, not event-sourced authority;
- completed cycle state is published only at stable closure;
- agents read through bounded subjective inputs;
- authoritative change occurs through validation/resolution/commit;
- objective state and actor-specific subjective state remain separable;
- stable semantic identity does not derive from mutable names/content/container positions;
- one personal initiative per actor/cycle;
- responses remain separate from personal initiative;
- candidate gates precede scoring;
- commit-time objective revalidation remains authoritative;
- decision traces remain deterministic and complete;
- observer/trace reads remain noninterfering;
- stable-ID fallback remains a disclosed technical mechanism and never resolves Recognition conflict;
- frozen Slice-1 authority remains immutable.

All exact Slice-1 regression IDs in frozen Slice-2 manifest §10 are mandatory regression evidence.

## 7. Acceptance criteria

Completion is controlled by `SFL-V0-S2-ACCEPTANCE-v1`.

Every REQUIRED Slice-2 AcceptanceId must:

- exist in completion output;
- execute;
- pass;
- have substantive evidence;
- have the declared fixture/write-set evidence;
- have an acceptable independent oracle basis;
- not be skipped or silently grouped away.

All explicit Slice-2 deferrals remain visible.

All exact Slice-1 regression bindings pass.

The frozen Slice-2 manifest identity must match:

- ref `sfl-v0-slice2-acceptance-v1`;
- freeze commit `88f876298852553d6afca76e743a5a811ff9f0fd`;
- manifest SHA `e4872531cf780d51fa1863f2a0b87e2424a71b69`.

No implementation/test code may edit/reclassify the frozen manifest.

## 8. Verification expectations

Run exactly:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Acceptance/completion output must expose:

- frozen manifest version/ref/SHA;
- every REQUIRED S2 AcceptanceId and pass/fail/skip state;
- explicit DEFERRED rows;
- exact Slice-1 regression IDs/results;
- fixture write-set audit;
- oracle-independence audit;
- deterministic/metamorphic results;
- configuration provenance.

Before promotion, freeze an exact implementation candidate and commission a **fresh regular post-implementation conformance review**.

That reviewer may run independent scratch probes against the unchanged public boundary but may not modify the candidate.

IMP-0002 is not VERIFIED COMPLETE until fresh conformance returns PASS.

## 9. Local decisions permitted

Astra/coder may choose ordinary reversible implementation details including:

- concrete C# record/class names;
- storage collections/indexes;
- internal proposition/reference representation;
- copied-vs-referenced provenance layout;
- public read-only query DTO names;
- test helper organization;
- configuration/profile naming;
- cache/index presence if demonstrably non-authoritative;
- bounded pinned communication policy coefficients used only as laboratory configuration.

These choices may not:

- alter proposition meaning;
- broaden knowledge acquisition;
- invent evidence precedence;
- expose objective truth to policy;
- weaken frozen acceptance;
- create later-slice semantics.

## 10. Escalation conditions

Stop and report rather than improvise if implementation appears to require:

1. a new negative/opposite Recognition proposition;
2. a CandidateOrganization equivalence/convergence rule;
3. a general contradiction or evidence-strength algebra;
4. a nonparticipant observation eligibility rule;
5. socially meaningful autonomous communication motivation as a completion requirement;
6. changing who is entitled to know a fact;
7. changing accepted evidence precedence;
8. household/head/checkpoint substrate to satisfy a REQUIRED row;
9. a redesign of the execution scheduler/resolution model;
10. changing/reclassifying the frozen Slice-2 manifest.

Also escalate any material contradiction between production constraints and accepted SPEC/ADR semantics.

These are not implementation discretion.

## 11. Work-state discipline

Work on:

`implementation/imp-0002-slice2-epistemic`

from canonical main after this packet is merged.

Keep changes recoverable and auditable.

Do not edit the frozen manifest.

Do not weaken existing Slice-1 tests or acceptance evidence to make Slice 2 pass.

If repair iterations become necessary, freeze exact candidates and use separate repair branches/packets rather than mutating a reviewed candidate under review.

## 12. Required completion report

Return:

- terminal status: COMPLETE CANDIDATE / BLOCKED / ESCALATED / INCOMPLETE;
- exact implementation head SHA;
- what changed by production/test file;
- complete REQUIRED S2 row result table;
- exact Slice-1 regression result table;
- deferral summary;
- fixture audit;
- oracle audit;
- root command results;
- CI run/evidence artifact identity where applicable;
- architecture/local decisions made;
- any unresolved issue;
- any deviation from packet;
- whether a semantic escalation occurred.

Do **not** self-declare VERIFIED COMPLETE before the fresh independent conformance review.
