# IMP-0003 Candidate-v3 BLOCK Repair Packet

**Task ID:** IMP-0003-REPAIR-V4  
**Commissioned by:** Master Architect  
**Status:** READY FOR DISPATCH  
**Failed candidate:** `imp-0003-slice3-conformance-candidate-v3`  
**Exact failed candidate SHA:** `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`  
**Repair branch:** `implementation/imp-0003-slice3-repair-v4`  
**Frozen authority:** `SFL-V0-S3-ACCEPTANCE-v1`  
**BLOCK review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`  
**Reconciliation:** `research/technical/IMP-0003/IMP-0003_CANDIDATE_V3_BLOCK_RECONCILIATION.md`

## 1. Objective

Repair exactly two candidate-v3 defect families:

1. eliminate false technical-fallback attribution for semantically compatible ordinary transactions that are Household-connected;
2. complete independent validation of Household lifecycle event/time provenance and exact Recognition evidence identities.

Preserve all earlier candidate-v1/v2/v3 repairs and frozen semantics.

## 2. Repair A — Household-connected compatible ordinary transactions must commute truthfully

### Defect

Candidate-v3 correctly fixed the disconnected-Household reproducer by routing Household-independent components through the inherited ordinary resolver.

It still falsely marks compatible ordinary loans as `TechnicalFallback=true` when the actors are Household/candidate-connected because the Household projection comparison retains allocation-sensitive identities from detached real-commit replay.

### Required outcome

Household-connected projection comparison must normalize nonsemantic allocation identities through causal origins while preserving semantically meaningful differences.

At minimum normalize consistently:

- newly allocated Debt IDs and origins;
- newly allocated Favour IDs and origins;
- newly allocated Marriage/relation IDs where applicable;
- SemanticEvent IDs whose identity is purely allocation order;
- KnownFact proposition payloads that embed allocated relation/event IDs;
- epistemic provenance references to those normalized events/relations.

Do not erase:

- proposal identity when it is the causal origin;
- event semantic kind/participants/causes/order where meaning depends on it;
- evidence ordering;
- Household/warrant/association identity and causal chain;
- action outcomes / invalidation reasons;
- actual resource/claim/lifecycle differences.

### Required regression

Construct current-Household-connected actors with two independently feasible compatible ordinary loans.

Run at least:

- proposal ID swap;
- proposal input reversal;
- relevant initial-world enumeration reversal.

Require in every variant:

- both loans commit;
- normalized semantic endpoint equal;
- no `TechnicalFallback` on either loan.

Retain candidate-v3 disconnected compatible-loan controls.

Retain positive fallback controls for:

- jointly infeasible material capacity;
- communication invalidated by repayment;
- favour/debt conflict;
- residence/admission race;
- any accepted Household transition noncommutativity.

Do not solve by blanket fallback suppression.

## 3. Repair B — exact lifecycle provenance verification

### Defect

The independent oracle currently reconstructs lifecycle enum from participant count but does not bind `LifecycleEvent` / `LifecycleTime` to actual stable-closure history.

### Required outcome

For each Household:

- lifecycle enum must match the reconstructed stable participant count;
- `LifecycleEvent` must resolve to an actual history event;
- that event must name the same Household and published lifecycle;
- `LifecycleTime` must equal that event's actual `Cycle, ReactionIndex`;
- initial Active lifecycle must be causally grounded in formation closure;
- later Active / Inactive / Dissolved lifecycle publications must be causally grounded in the relevant participation/continuity transition and stable closure;
- impossible/stale/fabricated lifecycle event/time references must fail;
- Dissolved commitment termination and no-resurrection behavior remain unchanged.

### Required detached corruptions

At minimum reject:

- nonexistent lifecycle event ID;
- fabricated negative/otherwise false lifecycle time;
- lifecycle event referencing another Household;
- lifecycle event detail/state mismatching published lifecycle.

Valid Active, Inactive, reactivated Active, and Dissolved controls must pass.

## 4. Repair C — exact Recognition KnownFact identity verification

### Defect

`SameEvidence` compares proposition/provenance but ignores `KnownFact.Id`. A detached warrant can replace a real retained basis with a nonexistent EvidenceId while retaining identical content/provenance and still pass.

### Required outcome

For every warrant Recognition basis under verification:

- exact `KnownFact.Id` must correspond to an actual fact held by that actor at the applicable precommit/stable boundary;
- proposition and provenance must still match;
- valid stale retained Recognition remains admissible;
- same-cycle acquired evidence must be reconstructed through its actual acquisition event/communication hop and exact resulting held identity;
- fabricated identity with copied content/provenance must fail.

Do not weaken identity checks globally to accommodate same-cycle acquisition.

### Required detached corruption

Replace a valid Recognition basis fact ID with a nonexistent `EvidenceId`, keeping proposition/provenance unchanged.

Require independent checker rejection.

Retain all prior formation/participation/continuation/lineage corruption controls.

## 5. Preserve all confirmed repairs

Do not regress:

- participation-entry oracle hardening;
- custom-label rule/configuration provenance;
- continuation-recognition locality;
- formation/continuation/lineage warrant reconstruction;
- disconnected compatible-loan no-fallback behavior;
- positive fallback controls;
- residence/admission dependency grouping;
- same-cycle bridge handoff;
- dissolution evidence locality;
- S1-084 old structural evidence.

## 6. Frozen / deferred boundaries

Do not edit frozen manifests, SPEC, or accepted ADRs.

Keep deferred:

- candidate convergence;
- actor departure;
- repeated predecessor-source generalization;
- head/office;
- Household initiative;
- endogenous provision acquisition/spending;
- mediated marriage authority;
- checkpoint/restore.

## 7. S1-084

Keep the S1-084 conditional adaptation gate unfired if possible.

If repair requires modifying the exact `WorldState` private-field inventory or existing `NoDerivedAuthorityStructuralAudit`, stop and dispatch:

`tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

before making that triggering change.

## 8. Verification

Run exactly:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Required evidence:

- Household-connected compatible-loan permutations: all commit, no false fallback, normalized endpoint equal;
- disconnected compatible-loan controls remain no-fallback;
- all positive fallback controls remain flagged;
- lifecycle event/time corruptions rejected;
- valid Active/Inactive/reactivated/Dissolved lifecycle controls pass;
- fabricated Recognition EvidenceId rejected;
- all previous warrant corruption controls remain green;
- 96/96 Slice-3 REQUIRED green;
- 11 DEFERRED / 2 UNEXERCISED unchanged;
- 128/128 Slice-1 + 46/46 Slice-2 inherited REQUIRED green;
- frozen manifests unchanged;
- S1-084 trigger status explicit;
- exact-head CI PASS and artifact identity recorded.

## 9. Candidate lifecycle

Do not move candidate-v1, candidate-v2, or candidate-v3 refs.

After repair, report the exact head SHA. Master Architect will freeze:

`imp-0003-slice3-conformance-candidate-v4`

only after checking the return.

Promotion still requires fresh whole-candidate **PASS — PROMOTE**.

## 10. Required return

Create/update:

`tasks/implementation/IMP-0003_REPAIR_V4_REPORT.md`

Return:

- terminal status;
- exact branch/head SHA;
- file-by-file repair summary;
- connected-loan normalization strategy and regressions;
- lifecycle provenance checker changes/corruption controls;
- Recognition EvidenceId checker changes/control;
- previous repair regressions;
- full acceptance/inherited census;
- root command results;
- exact-head CI/artifact identity;
- S1-084 gate status;
- unexpected issue/escalation;
- proposed candidate-v4 SHA.

Do not self-promote.
