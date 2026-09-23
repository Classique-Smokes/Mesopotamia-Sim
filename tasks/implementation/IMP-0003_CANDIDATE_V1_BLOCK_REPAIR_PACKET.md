# IMP-0003 Candidate-v1 BLOCK Repair Packet

**Task ID:** IMP-0003-REPAIR-V2  
**Commissioned by:** Master Architect  
**Status:** READY FOR DISPATCH  
**Parent failed candidate:** `imp-0003-slice3-conformance-candidate-v1`  
**Exact failed candidate SHA:** `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`  
**Repair branch:** `implementation/imp-0003-slice3-repair-v2`  
**Frozen Slice-3 authority:** `SFL-V0-S3-ACCEPTANCE-v1`  
**BLOCK review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_FRESH.md`  
**Master Architect reconciliation:** `research/technical/IMP-0003/IMP-0003_CANDIDATE_V1_BLOCK_RECONCILIATION.md`

## 1. Objective

Repair only the bounded candidate-v1 defects established by fresh independent conformance:

1. make the participation-warrant independent oracle materially adequate;
2. decouple truthful active semantic-rule provenance from arbitrary scenario configuration-label spelling;
3. stop Household continuation Recognition from broadcasting merely because an actor is a current sustaining participant.

Do not redesign Slice 3 or reopen frozen semantics.

The failed candidate remains immutable evidence.

## 2. Authority and precedence

Retrieve and obey:

1. accepted SPEC/ADRs;
2. frozen `SFL-V0-S3-ACCEPTANCE-v1`;
3. this repair packet;
4. the BLOCK review/reconciliation as defect evidence;
5. implementation-local convenience last.

Do not edit/reclassify any frozen manifest.

## 3. Repair A — participation oracle adequacy

### Defect

`HouseholdOracle.Verify` currently validates participation warrant fields too shallowly.

Fresh reviewer probes showed it accepts:

- empty recognition array;
- fabricated/nonexistent/future support evidence;
- support with wrong endpoint/current-participant relationship;
- an unrelated earlier `Response: Accept` event as the participation acceptance.

### Required outcome

The independent oracle must reconstruct the participation claim strongly enough to reject materially false detached warrant snapshots while remaining independent from production validators/classifiers.

At minimum bind:

- `ParticipationWarrant.Proposal` to the actual Request/Invite proposal;
- correct newcomer;
- correct named bridge/counterpart;
- correct response/acceptance event caused by that proposal and produced by the named counterpart;
- newcomer + bridge recognized-H evidence with valid referenced provenance;
- real qualifying ordinary person-person support event(s);
- support endpoints satisfying the newcomer/current-participant relation;
- support time strictly after H formation and before participation commit;
- relevant residence and durable-tie facts at the applicable precommit state;
- association/continuation outputs to the correct warrant.

No fabricated/nonexistent event ID may satisfy the checker.

### Required corrupt controls

Add detached corruption cases equivalent to:

- **P17:** delete participation Recognition evidence -> checker must fail;
- **P18:** replace support with nonexistent/future/wrong-endpoint event -> checker must fail;
- **P19:** replace participation acceptance with unrelated earlier `Response: Accept` -> checker must fail.

The corrupt controls must exercise the independent checker itself, not merely be rejected by production validation before reaching it.

### Forbidden shortcut

Do not make `HouseholdOracle` call:

- `HouseholdRules`;
- production participation feasibility/validity;
- production continuity classifier;

for the expected answer under judgment.

## 4. Repair B — truthful active semantic-rule provenance

### Defect

Candidate-v1 uses the literal scenario configuration label to decide whether response/decision traces report `SFL-S3-v1` or inherited `SFL-S2-v1`.

Valid Household participation can execute under a custom scenario label while its response trace claims the wrong active rules.

### Required outcome

Separate:

- semantic rule-set identity;
- scenario/configuration label.

For any Household/Slice-3 behavior:

- response decision trace;
- semantic event;
- Household warrant/stamp;

must truthfully identify the Slice-3 rules actually exercised even when caller configuration label is arbitrary.

Existing genuine Slice-2 scenarios must retain truthful Slice-2 provenance.

Do **not** solve by globally stamping every event/decision in the binary as S3.

### Required regression

Add a custom scenario/config label that is not exactly `SFL-S3-v1`.

Exercise valid Household participation and assert that:

- response decision RulesVersion is truthful for the Household rule path;
- resulting Household semantic event/warrant RulesVersion is consistent;
- scenario configuration identity remains separately visible;
- inherited Slice-2 trace/configuration regressions remain green.

## 5. Repair C — no continuation-recognition broadcast

### Defect

Candidate-v1 constructs `HouseholdContinued` with every current sustaining participant in the event-participant list and refreshes Household Recognition for all of them.

Accepted authority does not make current sustaining status alone a direct-observation entitlement.

### Required outcome

Household continuation evidence acquisition must follow accepted direct-participation / communication routes.

- current `SustainingParticipant` status alone must not refresh Recognition;
- actors explicitly participating in the causal transition may acquire/update according to accepted direct-participation semantics;
- bridge Recognition used by the ContinuationWarrant remains explicit/provenance-bearing;
- remote bearers not participating in the transition remain stale absent accepted communication/other direct evidence;
- no engine-wide or H-wide broadcast path is introduced.

### Required regression

Construct a Household with a remote current bearer B who:

- recognizes H from older evidence;
- does not submit/respond to the newcomer entry;
- is not the named bridge/counterpart;
- receives no communication about the entry/continuation.

After another actor bridges newcomer entry and H continues:

- B must not receive the newer continuation evidence solely because B remains a current sustaining participant;
- B's prior Recognition/provenance remains stale until a valid accepted update route occurs.

The test must distinguish stale retained Recognition from automatic updated Recognition.

## 6. Preserve cleared behavior

Do not regress the candidate-v1 surfaces already independently supported, including:

- canonical three-founder formation;
- both Request/Invite participation routes;
- immediate participation revalidation;
- residence/admission dependency grouping;
- same-cycle bridge handoff semantic priority;
- full founder turnover;
- dissolution/no resurrection;
- continuity-over-duplicate-formation;
- H Recognition Contested gating;
- controlled lineage + negative controls;
- provision reserve/NeedsGrain/no-pooling/no-spending;
- reaction closure/idempotence;
- S1-084 exact old structural evidence remaining unchanged unless the conditional gate newly fires.

## 7. S1-084 trigger

Candidate-v1 left the S1-084 conditional adaptation gate unfired.

Keep it unfired if possible.

If this bounded repair would now alter:

- `WorldState` exact private-field inventory; or
- existing `NoDerivedAuthorityStructuralAudit`;

stop that triggering change and dispatch:

`tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

before proceeding.

## 8. Scope exclusions

Do not introduce:

- general CandidateOrganization convergence;
- generic perception/observation;
- new Recognition enum/state;
- trust/reputation/evidence-strength algebra;
- head/office;
- HouseholdDecisionContext;
- provision acquisition/spending;
- mediated marriage authority;
- checkpoint/restore;
- generalized lineage;
- new scheduler architecture.

No new social semantics are required for this repair.

## 9. Verification

Run exactly:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Required repair evidence:

- P17/P18/P19-equivalent corrupt oracle controls fail the checker as intended;
- custom-label Household participation provenance regression passes;
- remote-bearer continuation Recognition regression passes;
- all **96 Slice-3 REQUIRED** rows green;
- all **11 DEFERRED + 2 UNEXERCISED** remain unchanged;
- all **128 Slice-1 + 46 Slice-2 REQUIRED** inherited results remain green;
- frozen manifests unchanged;
- exact-head CI PASS.

## 10. Candidate lifecycle

Do not move or rewrite:

`imp-0003-slice3-conformance-candidate-v1`.

After repair:

1. report exact repair branch head SHA;
2. Master Architect freezes a new immutable ref, normally:
   `imp-0003-slice3-conformance-candidate-v2`;
3. fresh independent conformance reviews that exact candidate;
4. promotion requires **PASS — PROMOTE**.

## 11. Required return

Update/create:

`tasks/implementation/IMP-0003_REPAIR_V2_REPORT.md`

Return:

- terminal status: COMPLETE CANDIDATE / BLOCKED / ESCALATED / INCOMPLETE;
- exact branch/head SHA;
- file-by-file repair summary;
- B1/B2/C1 repair evidence;
- all root command results;
- acceptance/regression census;
- exact-head CI/artifact identity;
- whether S1-084 gate fired;
- any unexpected issue;
- proposed candidate-v2 ref/SHA.

Do not self-promote.
