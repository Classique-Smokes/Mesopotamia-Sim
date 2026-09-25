# SFL v0 Slice 5 Discovery A — Authority Boundary and Semantic Gaps

**Task type:** fresh regular chat / clean context  
**Role:** source-grounded authority analyst  
**Authority:** advisory return only; no semantic promotion authority  
**Status:** COMPLETE / RETURN PRESERVED  
**Return:** `research/technical/SFL_V0_SLICE5_AUTHORITY_AND_GAP_INVENTORY.md`  
**Return head:** `779d3fafaeffb2ba2e91667a46b02a02f548d97b`

## Purpose

Determine the exact accepted semantic boundary of planned **Slice 5 — delayed processes + checkpoint/restore exact continuation** before any Slice-5 acceptance manifest or implementation packet is drafted.

The core question is not “design save/load.”

It is:

> What must be semantically preserved across interruption, what delayed causal state is actually part of SFL v0, and which questions—if any—remain genuinely unresolved before implementation?

## Required sources

Retrieve independently:

1. `AGENTS.md`
2. `00_START_HERE.md`
3. accepted `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
4. all accepted ADRs
5. `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`
6. `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
7. `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
8. frozen Slice-1/2/3/4 manifests + freeze records
9. final completion records for IMP-0001 through IMP-0004
10. `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`
11. `registers/ASSUMPTIONS_REGISTER.md`
12. current accepted decisions, especially DEC-0010 through DEC-0014
13. current `plans/CURRENT_PHASE.md`

Retrieve `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` only as a non-authoritative question/distinction lens.

## Mandatory analysis

### A. Exact checkpoint semantic census

Inventory every accepted statement governing:

- safe checkpoint boundary;
- stable cycle / reaction closure;
- future-influencing authoritative state;
- subjective knowledge/Recognition;
- Household identity/lifecycle/participation;
- role identity/occupancy/Recognition;
- provision commitments;
- refusal/cooldown/material-need baselines;
- debts/favours/marriage/residence/attitudes/resources;
- scheduled exogenous inputs;
- pending work/process;
- generated identifiers/counters/order state;
- rule/configuration version;
- semantic history/provenance;
- rebuildable caches/indexes/projections;
- exact restored history suffix.

Classify each as:

- REQUIRED Slice-5 semantics;
- inherited regression;
- engineering-local representation;
- explicitly deferred beyond v0;
- semantically unresolved.

### B. Stable-boundary meaning

Determine exactly what accepted authority means by:

> checkpoint only at stable cycle boundaries after reaction closure.

Clarify whether any accepted state may remain “pending” at such a boundary.

Separate:

- accepted future process state;
- queued future input;
- same-cycle proposal/response/resolution transient state;
- diagnostic/runtime scratch state;
- derived cache state.

If accepted authority is insufficient to classify a state category, identify the smallest exact question.

### C. Delayed-process boundary

Inventory every currently accepted future-timed or multi-cycle causal phenomenon, including at minimum:

- debt due/review timing;
- provision reconsideration cooldown/history baseline;
- scheduled exogenous grain input;
- any future work/input already accepted in the spec;
- any role/Household transition whose effect is delayed rather than immediate, if applicable.

Determine whether Slice 5 requires:

- one explicit generic delayed-process primitive;
- bounded typed pending-process records;
- no new generic process type because the accepted v0 uses only existing typed future state/inputs;
- or a consequential semantic decision.

Do not generalize to journeys/construction/legal procedure merely because the conceptual lens mentions them.

### D. Exact continuation semantics

Determine whether “exact subsequent authoritative semantic state and history suffix” requires equality of:

- stable semantic state;
- EventIds / ProposalIds / RelationIds / Household/role/evidence IDs;
- Cycle / ReactionIndex;
- causal predecessor references;
- failures/invalidation outcomes;
- technical fallback markers;
- decision traces;
- subjective evidence identity/provenance;
- rule/config version;
- scheduled future input execution;
- generated ID/counter sequence.

Identify any place where accepted wording permits semantic equivalence rather than byte/identity equality.

### E. Configuration/version boundary

Clarify accepted restore behavior when:

- configuration is identical;
- configuration/version differs;
- rules version differs;
- serialized state references an unknown/unavailable configuration.

Do not invent migration/version-upgrade semantics unless accepted authority already requires them.

### F. Caches and derived state

State the accepted distinction between:

- authoritative state that must be checkpointed;
- derived/rebuildable state that must not become recovery authority.

Explicitly include:

- lineage/DerivedFrom projections;
- Household mobilizable-capacity summaries;
- candidate/feasible-action indexes;
- dependency indexes;
- any cached Recognition/projection if present.

### G. Slice-5 boundary / out-of-scope

Identify everything that remains outside bounded Slice 5, especially:

- general persistence/version-migration framework;
- distributed/concurrent snapshots;
- rollback/time travel;
- branchable alternate histories;
- archival compression;
- generic event sourcing as current authority;
- mature process/workflow engine;
- actor departure unless separately authorized;
- richer delayed institutional/economic processes not already accepted.

### H. Director decision map

Return exactly one:

- **NO DIRECTOR DECISION CURRENTLY REQUIRED**, or
- a concise list of exact consequential questions not derivable from accepted authority.

Do not ask the Director to choose serialization formats, DTO layouts, file formats, codecs, compression, or implementation-local engineering.

## Required return

Create:

`research/technical/SFL_V0_SLICE5_AUTHORITY_AND_GAP_INVENTORY.md`

on:

`research/slice5-authority-gap-return`

Record exact base SHA.

End with:

- exact Slice-5 semantic boundary;
- accepted delayed-process set/boundary;
- checkpoint equality requirements;
- safe-boundary rule;
- cache/derived-state boundary;
- post-v0 exclusions;
- Director-decision status;
- recommendation: **READY FOR ACCEPTANCE PLANNING** or **BLOCKED PENDING DECISION**.
