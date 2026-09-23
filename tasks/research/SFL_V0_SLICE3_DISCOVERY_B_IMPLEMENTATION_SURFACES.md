# SFL v0 Slice 3 Discovery B — Implementation Surface Map

**Task type:** fresh regular chat / clean context  
**Role:** implementation archaeologist / architecture mapper  
**Authority:** advisory return only; do not modify production code

## Purpose

Map the verified Slice-2 kernel against the accepted Slice-3 household-identity/capability requirements.

Answer:

> What already exists, what bounded production surfaces must change, and where are the architectural pressure points or implementation-cheat risks?

Do not design beyond accepted semantics.

## Required sources

Read independently:

- `AGENTS.md`
- accepted SPEC/ADRs
- current canonical `src/Mesopotamia.Sim/*`
- current acceptance tests
- Slice-1 / Slice-2 completion records
- `plans/verification/SFL_V0/FORMATION_FAMILY.md`
- `CONTINUITY_TURNOVER_FAMILY.md`
- `LINEAGE_FAMILY.md`
- `PROVISION_GROUNDING_FAMILY.md`
- `NO_SELF_CONFIRMATION_FAMILY.md`
- `RESOLUTION_REACTION_FAMILY.md`
- current deferred gap ledger
- Slice-2 observation reconciliation.

## Mandatory mapping

### A. Existing reusable substrate

Identify what current production code already supplies for:

- stable identities;
- semantic event provenance;
- actor-specific KnownFact/Recognition;
- candidate recognition;
- communication;
- proposal/response/resolution/commit;
- stable-cycle closure;
- same-cycle dependency analysis;
- deterministic IDs/order;
- read-only verification inspection.

### B. Missing Slice-3 state/types

Map likely pressure for:

- CandidateOrganization representation beyond the current inert candidate referent;
- Household identity;
- FormationWarrant;
- SustainingParticipant;
- participation/end/continuation warrants;
- lifecycle state;
- household existence/continuity Recognition;
- lineage state if Slice 3 authority requires it;
- provision commitments / derived capacity if Slice 3 authority requires them.

Representation choices are engineering-local; flag only semantic constraints.

### C. Execution/reaction surfaces

Identify where production logic would need to:

- detect formation only after lower-level evidence + founder recognition;
- avoid CandidateOrganization self-confirmation;
- create Household as automatic causal reaction rather than privileged FormHousehold command;
- process participation entry/exit;
- perform continuity handoff before same-cycle bridge exit;
- publish lifecycle only at stable closure;
- prevent Dissolved resurrection;
- prevent one evidence bundle from both continuing H and forming duplicate H2;
- integrate derived capacity without pooled household grain;
- preserve subjective recognition sparsity.

### D. Likely source pressure

Classify current files as:

- high-confidence change;
- conditional/watch;
- no expected pressure.

Explicitly inspect:

- `State.cs`
- `EpistemicState.cs`
- `EpistemicExecution.cs`
- `Simulation.cs`
- `Execution.cs`
- `Decisions.cs`
- `PersonalDecisionInputs.cs`
- `ResolutionDependencies.cs`
- `Agency.cs`
- `VerificationAccess.cs`
- acceptance-test structure.

### E. Cheat / architecture hazards

Look specifically for temptation to implement:

- Household = co-resident graph cluster;
- hidden Members set;
- Candidate label as self-evidence;
- household pooled grain;
- snapshot similarity as identity;
- residence change as implicit participation change;
- participant count as identity;
- generic engine omniscience for Household recognition;
- fake Household/head fixtures;
- event-history replay as authoritative current state;
- head/office mechanics pulled into Slice 3 merely for convenience;
- stable ID as social household/convergence rule.

### F. Escalation triggers

Identify implementation discoveries that would be semantic/architectural escalation rather than coder discretion.

## Required return

Create:

`research/technical/SFL_V0_SLICE3_IMPLEMENTATION_SURFACE_MAP.md`

on branch:

`research/slice3-implementation-surface-return`

from canonical main and record exact base SHA.

Conclude whether Slice 3 appears to be:

- bounded extension;
- substantial kernel extension;
- architecture redesign.

Do not code.
