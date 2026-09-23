# IMP-0003 Candidate-v2 BLOCK Repair Packet

**Task ID:** IMP-0003-REPAIR-V3  
**Commissioned by:** Master Architect  
**Status:** READY FOR DISPATCH  
**Failed candidate:** `imp-0003-slice3-conformance-candidate-v2`  
**Exact failed candidate SHA:** `69ae753da2e05450766a9042ac6958fa7aa0b3e7`  
**Repair branch:** `implementation/imp-0003-slice3-repair-v3`  
**Frozen authority:** `SFL-V0-S3-ACCEPTANCE-v1`  
**BLOCK review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`  
**Reconciliation:** `research/technical/IMP-0003/IMP-0003_CANDIDATE_V2_BLOCK_RECONCILIATION.md`

## 1. Objective

Repair exactly two candidate-v2 defect families:

1. complete independent warrant verification for FormationWarrant, exit-side ContinuationWarrant, and LineageWarrant;
2. eliminate false technical-fallback labeling caused only by nonsemantic allocation/provenance IDs in Household-aware counterfactual comparison.

Preserve all candidate-v2 repairs and previously independently supported Slice-3 behavior.

No new social semantics are required.

## 2. Repair A — complete independent warrant reconstruction

### A1. FormationWarrant

The checker must independently reconstruct and validate at least:

- actual formation stamp event exists;
- stamp kind/Household/candidate/warrant identity matches the produced FormationWarrant;
- Candidate reference exists and matches the bounded formation episode;
- founders are the actual founding actors;
- recorded dwelling corresponds to founder residence at formation;
- every recorded supporting tie is real, correctly referenced, and joins the recorded pair;
- the founder graph is connected from those **recorded warrant ties**, not from unrelated world-state ties;
- each cited support fact matches the actual committed event:
  - event exists;
  - qualifying support kind;
  - recorded kind equals event kind/semantic support meaning;
  - endpoints equal actual event participants;
  - cycle/order is truthful;
  - event is before formation;
- every founder has exactly one valid CandidateRecognition basis for the same candidate;
- each Recognition basis belongs to the correct founder and is supported by actual held evidence/provenance;
- `EarliestEvidence` equals the earliest qualifying retained evidence actually used by the warrant;
- founding SustainingParticipant associations bind correct founders/Household/origin warrant;
- rule/configuration provenance is truthful.

Required detached corruptions include at minimum:

- ties = [];
- duplicate one founder's Recognition across founders;
- nonexistent Candidate ID;
- fabricated EarliestEvidence;
- nonexistent formation stamp event;
- support fact endpoints/kind altered while retaining real support event ID.

All must reach the checker and fail there.

### A2. Exit-side ContinuationWarrant

For each continuation, independently reconstruct:

- actual continuation stamp event;
- actual transition warrant/event;
- actual previous Formation/Continuation warrant;
- prior and successor association sets around that transition;
- at least one true historical bridge in prior ∩ successor;
- each bridge's Household Recognition evidence is present, Recognized, and validly grounded;
- empty Recognition cannot satisfy the checker;
- continuation causal predecessor event references are real;
- rule/configuration provenance is truthful.

Required corruptions include:

- empty Recognition;
- Recognized bridge with empty evidence;
- nonexistent continuation event;
- invented RulesVersion.

### A3. LineageWarrant

Independently validate:

- actual lineage stamp event;
- successor Household / FormationWarrant binding;
- predecessor Household set;
- founder source mapping to real ParticipationEndWarrants;
- source actor/predecessor identity;
- fresh evidence is **actual qualifying ordinary person-person support**, never successor formation or another nonqualifying event;
- division freshness occurs after all cited exits;
- consolidation freshness occurs after both predecessor dissolutions and crosses predecessor source groups;
- direct predecessor count/kind rules;
- rule/configuration provenance.

Required corruptions include:

- successor formation event substituted as fresh evidence;
- nonexistent lineage stamp event;
- invented RulesVersion.

Do not use production formation/continuity/lineage classifiers as expected-answer oracles.

## 3. Repair B — false technical fallback under disconnected Household

### Defect

When any Household exists, the Household resolver currently evaluates unrelated ordinary action components too.

Two compatible loans in a disconnected component can commit identically in both orders yet receive `TechnicalFallback=true` because detached projection compares nonsemantic allocated IDs/provenance identities.

### Required outcome

Counterfactual equivalence must ignore purely allocation-order identities while retaining genuinely semantic differences.

Allowed implementation approaches include:

- normalize newly allocated debt/favour/marriage/event/evidence identities through causal proposal origins;
- normalize nested epistemic provenance identities similarly;
- retain the inherited resolver for action components structurally independent of Household state;
- another bounded equivalent approach preserving accepted semantics.

### Forbidden shortcut

Do not simply suppress fallback when balances/outcomes happen to match.

The resolver must still flag genuine noncommutativity where order changes authoritative/accepted semantics, including:

- communication invalidation;
- residence/admission races;
- limited capacity;
- favour/debt conflicts;
- Household participation/lifecycle/continuity;
- other action-relevant evidence state.

### Required regression

Add disconnected-Household compatible-loan paired runs:

- Household on one unrelated actor component;
- two compatible ordinary loans on a disconnected actor component;
- original and exchanged proposal IDs / relevant input permutations.

Require:

- both loans commit;
- normalized semantic state equal;
- `TechnicalFallback=false` for both.

Retain and rerun positive fallback controls that must remain flagged.

## 4. Preserve candidate-v2 fixes

Do not regress:

- strengthened participation-entry oracle;
- custom-label S2/S3 semantic-rule provenance separation;
- remote-bearer continuation staleness;
- residence/admission dependency grouping;
- same-cycle bridge priority;
- dissolution evidence locality.

## 5. Preserve frozen boundaries

Do not alter:

- frozen Slice-1/2/3 manifests;
- accepted SPEC or ADR semantics;
- CandidateOrganization convergence deferral;
- head/office deferral;
- provision acquisition/spending deferral;
- mediated marriage authority deferral;
- checkpoint/restore deferral;
- repeated predecessor source generalization deferral.

## 6. S1-084

Keep the S1-084 adaptation trigger unfired if possible.

If repair requires modifying the exact `WorldState` private-field inventory or existing `NoDerivedAuthorityStructuralAudit`, stop and dispatch:

`tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

before making that triggering change.

## 7. Verification

Run exactly:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Required evidence:

- all new detached warrant-corruption controls rejected by independent checker;
- valid uncorrupted formation/continuation/lineage controls still pass;
- disconnected-H compatible loans produce no false fallback;
- genuine fallback controls remain positive;
- 96/96 Slice-3 REQUIRED green;
- 11 DEFERRED + 2 UNEXERCISED unchanged;
- 128/128 Slice-1 + 46/46 Slice-2 inherited REQUIRED green;
- frozen manifest identities unchanged;
- S1-084 gate status explicit;
- exact-head CI PASS and evidence artifact identity recorded.

## 8. Candidate lifecycle

Do not move:

- candidate-v1 ref;
- candidate-v2 ref.

After repair, report exact repair head. The Master Architect will freeze:

`imp-0003-slice3-conformance-candidate-v3`

only after checking the bounded return.

Promotion still requires fresh whole-candidate **PASS — PROMOTE**.

## 9. Required return

Create/update:

`tasks/implementation/IMP-0003_REPAIR_V3_REPORT.md`

Return:

- terminal status;
- exact branch/head SHA;
- files changed;
- warrant-oracle hardening summary;
- corrupt-control counts/results;
- fallback normalization approach;
- disconnected-loan regression result;
- positive fallback regression results;
- complete acceptance/regression census;
- root command results;
- exact-head CI/artifact identity;
- S1-084 trigger status;
- unexpected issue/escalation;
- proposed candidate-v3 SHA.

Do not self-promote.
