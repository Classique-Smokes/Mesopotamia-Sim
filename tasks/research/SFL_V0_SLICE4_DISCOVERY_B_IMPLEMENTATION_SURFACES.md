# SFL v0 Slice 4 Discovery B — Implementation Surface Map

**Task type:** fresh regular chat / clean context  
**Role:** implementation archaeologist / architecture mapper  
**Authority:** advisory return only; do not modify production code

## Purpose

Map the verified promoted Slice-3 kernel against the accepted Slice-4 representative/head-role requirements.

Answer:

> What current production substrate can be reused, what bounded production surfaces must change, and where are the main architecture/cheat risks for adding a persistent office, occupant turnover, scoped authority, and dual personal/Household decision mode?

Do not design beyond accepted semantics.

## Required sources

Read independently:

- `AGENTS.md`
- accepted SPEC/ADRs
- current canonical `src/Mesopotamia.Sim/*`
- current acceptance tests
- Slice-1/2/3 final completion records
- `research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md`
- RUN-0003 Master Architect reconciliation
- `plans/verification/SFL_V0/HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`
- `PROVISION_GROUNDING_FAMILY.md`
- `RECOGNITION_INFORMATION_FAMILY.md`
- `RESOLUTION_REACTION_FAMILY.md`
- `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
- current deferred-gap ledger.

Conceptual material may be consulted only as a non-authoritative distinction lens.

## Mandatory mapping

### A. Reusable Slice-3 substrate

Identify what production code already supplies for:

- stable Household identity and lifecycle;
- SustainingParticipant current/historical associations;
- actor-specific Household Recognition and communication;
- exact evidence identity/provenance;
- semantic event history / WarrantStamp / causal references;
- proposal / response / resolution / revalidation;
- same-cycle dependency grouping and counterfactual fallback;
- rule/configuration provenance;
- provision commitment state and derived mobilizable capacity;
- stable closure and lifecycle publication;
- read-only verification/observation access.

State which of these are clean extension seams and which already carry substantial complexity.

### B. Missing Slice-4 state/types

Map likely pressure for:

- persistent `HouseholdHeadRole` identity;
- role vacancy/occupancy state;
- appointment/succession warrant or equivalent provenance-bearing state required by accepted semantics;
- actor-specific head-role Recognition;
- HouseholdDecisionContext;
- Household initiative trace/context;
- provision request/reconsideration state/cooldown baselines;
- collective material-use proposal types;
- mediated-marriage authority state/proposals;
- role-specific history/provenance.

Representation choices remain engineering-local. Flag only semantic constraints.

### C. Decision-generation / dual-mode surfaces

Identify where production logic would need to:

- preserve one personal initiative for head P;
- add one separate H initiative through P;
- score Household concerns separately from personal concerns;
- keep P's non-office subjective knowledge personal rather than creating an omniscient role mind;
- prevent Household initiative while role vacant or H Inactive;
- preserve ordinary personal actions independently of office authority;
- generate only in-scope head actions.

Inspect likely pressure in:

- `Agency.cs`
- `Decisions.cs`
- `PersonalDecisionInputs.cs`
- response contexts/scoring profiles
- trace structures.

### D. Role transition / recognition surfaces

Identify where implementation must:

- create one persistent role with new H while leaving it vacant;
- process nomination;
- validate current-participant nominator and nominee;
- collect nominee acceptance + unanimity;
- appoint occupant without changing H identity;
- vacate on occupant participation end;
- succeed A→B under same role identity;
- grant direct Recognition to transition participants only;
- leave outsiders stale absent evidence route.

Highlight risks from RUN-0003 actor-causal Recognition lessons.

### E. Resolution / dependency pressure

Inspect current `ResolutionDependencies.cs`, `HouseholdResolution.cs`, `HouseholdProjection.cs`, `Execution.cs`, `HouseholdExecution.cs` and related code.

Map how Slice 4 would need to account for:

- prospective nominee/holder state before occupancy;
- old-head/new-head authority races;
- vacancy/succession and accepted Household actions;
- H Active→Inactive/Dissolved changes;
- provision capacity and contributor debit;
- personal vs Household initiative sharing the same persons/resources;
- mediated-marriage scope/eligibility changes;
- stale/Contested head Recognition;
- semantic priority vs technical fallback.

Identify any current resolver assumption that would become invalid once a separate Household initiative exists.

### F. Provision / material-use surfaces

Map what Slice 3 already has versus what Slice 4 must add for:

- head requests for provision commitment;
- reconsideration cooldown + context-change baseline;
- 1-grain support to eligible NeedsGrain participant;
- fixed-rank multi-contributor expenditure;
- household-mediated dowry;
- exact contributor debit vector;
- priority support > other household provision spend > personal transfer;
- no treasury / no double debit.

### G. Likely source pressure

Classify current files as:

- high-confidence change;
- conditional/watch;
- no expected pressure.

Explicitly inspect at minimum:

- `HouseholdState.cs`
- `HouseholdExecution.cs`
- `HouseholdRules.cs`
- `HouseholdResolution.cs`
- `HouseholdProjection.cs`
- `EpistemicState.cs`
- `EpistemicExecution.cs`
- `Simulation.cs`
- `Execution.cs`
- `Decisions.cs`
- `PersonalDecisionInputs.cs`
- `Agency.cs`
- `ResolutionDependencies.cs`
- `VerificationAccess.cs`
- Slice-3 acceptance-test helpers/oracles.

### H. Cheat / architecture hazards

Look specifically for temptation to implement:

- head occupant as a field on Person with no persistent role identity;
- auto-selecting head by stable ID, age, sex, grain, founder order, etc.;
- majority rule instead of unanimity;
- role occupancy implying global recognition;
- current participant set as information entitlement;
- office authority = personal authority;
- Household initiative consuming the head's personal initiative;
- separate omniscient Household mind;
- vacancy dissolving H;
- role turnover creating new H or new role identity;
- head authority creating general sovereignty;
- provision backing becoming treasury;
- stored/derived capacity becoming authority;
- role action bypassing central resolution/revalidation;
- current-role-only dependency grouping that misses prospective nominees;
- raw allocation IDs deciding authority conflicts.

### I. Escalation triggers

Identify implementation discoveries that would be semantic/architectural escalation rather than coder discretion.

Pay particular attention to any same-cycle authority/precondition race not uniquely determined by accepted semantics.

## Required return

Create:

`research/technical/SFL_V0_SLICE4_IMPLEMENTATION_SURFACE_MAP.md`

on branch:

`research/slice4-implementation-surface-return`

from canonical main and record exact base SHA.

Conclude whether Slice 4 appears to be:

- bounded extension;
- substantial kernel extension;
- architecture redesign.

Do not code.
