# Implementation Task Packet — SFL v0 Reference Slice 3: Persistent Household Identity and Grounded Capability

**Task ID:** IMP-0003  
**Commissioned by:** Master Architect  
**Status:** READY FOR DISPATCH AFTER CANONICAL FREEZE PROMOTION  
**Context mode:** CODING-PRIEST / PROJECT-CONTEXT — repository authority controls  
**Planned implementation branch:** `implementation/imp-0003-slice3-household`

## Dispatch gate

Slice-3 discovery is reconciled and Slice-3 completion authority is frozen.

Frozen acceptance authority:

- manifest: `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
- version: `SFL-V0-S3-ACCEPTANCE-v1`
- frozen ref: `sfl-v0-slice3-acceptance-v1`
- freeze commit: `25160f33c994fd5f3e277ae98f03e55d37c878dd`
- frozen manifest SHA: `1aae13dc27572361fe99c31ef8aee0444d39364a`
- reviewed candidate commit: `c7865e0a7daba4b22ada96156c08cd53faf40e7c`
- reviewed candidate SHA: `47715e6724229fc53e8d667ac49d21c6df862a77`
- final pre-code review: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_V3_FINAL.md` — **PASS — MAY FREEZE UNCHANGED**
- freeze record: `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_FREEZE_RECORD.md`

This packet becomes dispatchable only after the promotion carrying this frozen authority and this task packet is canonical on `main`.

No implementation work may weaken, edit, reinterpret, or reclassify the frozen manifest.

## 1. Objective

Extend the verified Slice-2 deterministic reference kernel with the bounded SFL v0 Slice-3 Household substrate:

- formation of persistent Household identity from accepted lower-level history plus founder-specific CandidateRecognition;
- provenance-bearing FormationWarrant and founding SustainingParticipant associations;
- bilateral participation entry through both Request and Invite directions;
- explicit participation end;
- explicit historical continuity through ContinuationWarrant;
- stable-cycle Active / Inactive / Dissolved lifecycle;
- complete founder turnover without identity-by-snapshot;
- same-cycle bridge handoff and continuity-over-duplicate-formation precedence;
- actor-specific Household existence/continuity Recognition over the verified Slice-2 epistemic substrate;
- controlled v0 division/consolidation lineage and rebuildable direct/transitive lineage queries;
- HouseholdProvisionCommitment backing state and derived mobilizable capacity, without pooled grain or household spending;
- deterministic reaction closure, provenance, independent verification, and exact preservation of all prior frozen REQUIRED contracts.

The result must be a runnable deterministic vertical slice.

This is a **substantial kernel extension within the accepted architecture**, not an architecture redesign.

## 2. Required inputs by authority class

### Accepted semantic / architectural authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted ADRs under `architecture/accepted/`, especially:
  - ADR-0001 — active social-state representation;
  - ADR-0002 — hierarchical individual agency;
  - ADR-0003 — progressive derived-state specialization;
  - ADR-0004 — reference simulation kernel;
  - ADR-0005 — host runtime.

These control meaning and architecture.

### Frozen verification / completion authority

- `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_FREEZE_RECORD.md`
- frozen ref/commit/SHA listed in the dispatch gate.

This defines exact Slice-3 completion applicability. It does not create social semantics.

Prior frozen authorities remain independently in force:

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`
- `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_FREEZE_RECORD.md`

### Required non-authoritative supporting / engineering context

- `research/technical/SFL_V0_SLICE3_AUTHORITY_AND_GAP_INVENTORY.md`
- `research/technical/SFL_V0_SLICE3_IMPLEMENTATION_SURFACE_MAP.md`
- `research/technical/SFL_V0_SLICE3_VERIFICATION_TRIGGER_MAP.md`
- `research/technical/SFL_V0_SLICE3_PREIMPLEMENTATION_RECONCILIATION.md`
- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`
- `AGENTS.md`

Review reports/reconciliations are provenance and may clarify why completion authority has its current shape, but they do not override accepted semantics or the frozen manifest.

### Precedence

1. accepted SPEC/ADRs;
2. frozen Slice-3 completion authority;
3. frozen Slice-1/Slice-2 regression authority;
4. supporting/engineering context;
5. current implementation convenience.

If lower layers conflict with higher layers, stop and escalate.

## 3. Mandatory S1-084 trigger gate

Before changing the exact private-field inventory of `WorldState`, or before editing/replacing the existing `NoDerivedAuthorityStructuralAudit` evidence path, retrieve:

`tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

Then stop the triggering change until that task returns:

**PASS — LOSSLESS S1-084 ADAPTATION AUTHORIZED FOR THIS EXACT DIFF**

If the implementation preserves the exact current `WorldState` private-field inventory and leaves the S1-084 structural evidence unchanged, this conditional review does not fire.

The coder may not self-authorize weakening/deleting/replacing S1-084.

## 4. Scope

### 4.1 Authoritative Household substrate

Add the minimum explicit, referentially stable state required to represent:

- Household numerical identity;
- FormationWarrant;
- SustainingParticipant association;
- ParticipationWarrant;
- ParticipationEndWarrant;
- ContinuationWarrant;
- operational lifecycle state;
- controlled LineageWarrant;
- authoritative HouseholdProvisionCommitment.

Representation is engineering-local provided:

- identity is not derived from residence, participant enumeration, names, assets, graph shape, collection position, or stable-ID fallback;
- warrants retain explicit provenance/reference identities required by frozen authority;
- current typed state remains authoritative;
- semantic history remains provenance/history, not an event-sourced substitute for current authority;
- no hidden universal Members set becomes causal ground truth.

Do not add a privileged `FormHousehold` action.

### 4.2 CandidateOrganization boundary

Support only what frozen Slice-3 authority requires:

- one stable inert CandidateOrganization referent per bounded formation episode;
- candidate label/ID has no causal authority, resources, identity continuity, or self-evidentiary force;
- every required founder's CandidateRecognition remains actor-specific and evidence-backed.

Do not implement general multi-label convergence/equivalence.

If correct implementation requires reconciling two distinct candidate referents/evidence paths as one prospective organization, stop and escalate `LATER-01`.

Do not use ID order, shared founder set, label equality, residence similarity, or graph similarity as a hidden convergence rule.

### 4.3 Formation as automatic causal reaction

Implement formation through automatic semantic closure:

`lower-level accepted evidence/history`
→ actor-held founder evidence
→ CandidateRecognition for every required founder
→ FormationWarrant
→ one persistent H
→ founding SustainingParticipant associations
→ direct founder Household Recognition
→ stable lifecycle publication.

Preserve:

- canonical three-founder `VS-SFL-001` witness;
- 1/2/3 founding-cardinality boundaries;
- shared-residence and durable-connectivity gates;
- two qualifying supports on distinct cycles;
- exact qualifying ordinary support-kind census:
  - accepted gift/help;
  - loan provision;
  - favour fulfilment;
- Household-originated support is not independent formation/continuity/fresh-lineage evidence;
- earliest sustaining evidence time remains distinguishable from reification/formation time.

Formation must be cause-keyed/idempotent and must not reopen voluntary same-cycle deliberation.

### 4.4 Participation entry and exit

Implement both accepted entry directions as ordinary proposal/response semantics:

- newcomer `RequestHouseholdParticipation(H)` through a current sustaining participant;
- current sustaining participant `InviteHouseholdParticipation(P)`.

Each must independently enforce frozen prerequisites, including:

- target H non-Dissolved and valid lifecycle boundary;
- newcomer Household Recognition;
- current recognizing continuity bridge;
- shared residence;
- durable tie;
- qualifying post-formation support;
- named-counterpart acceptance;
- immediate precommit revalidation.

Successful entry produces:

- ParticipationWarrant;
- SustainingParticipant;
- required ContinuationWarrant reaction.

Implement voluntary `EndHouseholdParticipation(H)`:

- creates ParticipationEndWarrant;
- ends only the typed sustaining association;
- does not erase residence/kinship/marriage/debt/favour/attitude/history;
- terminates that participant's provision commitment if present;
- triggers continuity/lifecycle reevaluation.

Residence change alone never edits sustaining participation.

### 4.5 Continuity and lifecycle

Household continuity is historical transmission, never snapshot similarity.

Implement:

- explicit bridge + same-H Recognition + ContinuationWarrant;
- complete founder turnover;
- broken-bridge negative control;
- Inactive state at exactly one sustaining participant;
- Inactive reactivation only through its sole bearer;
- Dissolved at zero sustaining participants only at stable closure;
- Dissolved no-resurrection as the same identity;
- same-cycle bridge handoff semantic priority:
  - valid bridged entry;
  - continuity reaction;
  - bridge exit;
  - stable lifecycle publication;
- continuity/participation precedence over duplicate formation when the same evidence bundle would otherwise be consumed both ways;
- separate distinct evidence may still form a separate overlapping organization where independently warranted.

Transient participant counts are microstate/history, not completed lifecycle truth.

Do not delete a Dissolved Household merely to simplify live state; historical identity remains queryable.

### 4.6 Household existence / continuity Recognition

Extend the verified Slice-2 epistemic model only as far as frozen Slice-3 authority requires.

Support actor-specific, provenance-bearing Household Recognition:

- founders directly recognize newly formed H;
- unrelated outsiders remain Unknown absent an accepted route;
- sender-held provenance-bearing communication can produce outsider/newcomer Unknown → Recognized;
- current continuation evidence may refresh positive Household-recognition provenance;
- decisive dissolution evidence affects stale positive reliance only through accepted direct-participation/communication evidence;
- incompatible nondominated H evidence yields `Contested`;
- `Contested` does not safely satisfy the participation Household-recognition gate;
- IDs, message arrival, engine-side H state, observer history, and diagnostic reads never choose a Recognition winner.

Do not invent:

- a negative/opposite Recognition enum;
- generic nonparticipant observation;
- co-residence omniscience;
- trust/reliability/reputation;
- a universal evidence algebra.

Preserve ordinary person-person actions independently of Household Recognition.

### 4.7 Controlled lineage

Implement only the frozen controlled-v0 classifier.

#### Division

Require:

- ordinary successor formation independently succeeds;
- predecessor H remains non-Dissolved at successor formation;
- every successor founder source is explicit ended participation in H;
- fresh qualifying ordinary person-person support occurs after all cited exits;
- one `DivisionDescendant` LineageWarrant at most;
- direct predecessor set exactly `{H}`;
- predecessor continuity remains ordinary continuity, not lineage identity.

Negative controls must include:

- stale/no fresh support -> H2 may form, no division lineage;
- predecessor H Dissolved before H2 forms -> H2 may form, no division lineage;
- ambiguous predecessor-source mapping -> no lineage warrant;
- branch size/assets/residence/overlap do not decide continuation/lineage.

#### Consolidation

Require:

- both predecessor households Dissolved first;
- successor ordinary formation independently succeeds;
- founders map unambiguously through explicit ParticipationEndWarrant sources;
- at least one founder source from each predecessor;
- fresh post-dissolution cross-predecessor ordinary support;
- unordered predecessor set exactly `{H1,H2}`;
- successor is a new numerical identity.

Negative controls must include:

- one predecessor survives -> no controlled consolidation;
- no fresh cross-predecessor support -> no controlled consolidation;
- unrelated H4 history that does not satisfy controlled source conditions -> H4 excluded from predecessor set;
- true source ambiguity -> no warrant, never ID/order selection.

#### General lineage invariants

- zero or one LineageWarrant per successor FormationWarrant;
- direct lineage irreflexive, acyclic, temporally forward;
- `DerivedFrom` is rebuildable from warrants;
- `AncestorOf` is a distinct transitive query;
- predecessor enumeration order is nonsemantic;
- lineage remains historically queryable;
- lineage transfers no grain, claims, relations, authority, Recognition, roles, residence, attitudes, lifecycle, pending work, or numerical identity;
- lineage has no independent behavioral power.

Do not build a general genealogy/fission/merger/reconsolidation engine.

Repeated predecessor rejoin/re-exit source selection remains deferred. If implementation/test history requires it, stop and escalate `LATER-03`.

### 4.8 Grounded provision backing / capacity substrate

Implement authoritative `HouseholdProvisionCommitment(Person -> H)` state and derived mobilizable capacity without implementing its later head-scoped acquisition producer.

Frozen verification permits a **declared controlled pre-existing valid commitment fixture** solely when acquisition itself is not the assertion target.

That controlled setup:

- must retain explicit fixture provenance;
- must not claim or expose a runtime headless solicitation/acceptance action;
- must not create head/office state;
- must not transfer grain;
- must not fixture-write the derived capacity result;
- must not count as formation/continuity evidence.

Required state semantics:

- personal grain remains personal;
- exposed capacity = `max(0, grain - 2)`;
- grain 1 / 2 / 3 => capacity 0 / 0 / 1 for a non-`NeedsGrain` committed contributor;
- at the same otherwise-positive grain, `NeedsGrain=true` exposes zero;
- Household mobilizable capacity derives from current valid commitments and current personal state;
- no persistent Household treasury exists;
- participation end terminates that person's commitment without confiscation;
- dissolution terminates H's commitments without confiscation.

Do not implement:

- provision solicitation/reconsideration;
- Household support;
- dowry spending;
- contributor debit ordering/execution;
- provision priority;
- Household initiative.

Those remain Slice 4.

### 4.9 Reaction closure and resolution dependencies

Extend the accepted deterministic kernel rather than replacing it.

Reaction closure must support causally downstream automatic transitions with:

- explicit causal predecessors;
- cause-key idempotence;
- monotone ReactionIndex;
- termination;
- no completed-cycle publication before closure;
- no same-cycle fresh voluntary activation after automatic consequences.

Extend central revalidation/dependency logic so relevant new state participates in correctness, including where applicable:

- H lifecycle / Dissolved status;
- sustaining association;
- continuity bridge;
- Household Recognition;
- residence/tie/support prerequisites;
- provision-commitment validity;
- same-cycle bridge priority;
- continuity-over-duplicate-formation precedence.

Detached/counterfactual dependency projections must include enough Slice-3 authoritative state/reactions to avoid false commuting/fallback conclusions.

Projection-only work must not consume live authoritative IDs.

Stable-ID fallback must never decide:

- candidate equivalence;
- continuity identity;
- Household Recognition conflict;
- lineage ambiguity;
- similar-endpoint identity.

### 4.10 Read-only inspection and verification support

Expose immutable/read-only evidence sufficient to test frozen authority:

- Household identity/lifecycle;
- warrant provenance;
- current sustaining associations;
- Household Recognition/provenance;
- direct lineage and ancestry queries;
- provision commitments and independently checkable capacity inputs/results;
- reaction/history causal references.

Inspection must remain observer-noninterfering.

Do not create test-only mutation paths that can directly write outcomes under test.

Reused produced Household states must carry producer/pass/fixture/configuration/output provenance as required by `S3-091`.

## 5. Primary implementation surfaces

Expected high-pressure surfaces include:

- `src/Mesopotamia.Sim/State.cs` or an explicitly separate authoritative Household-state partition;
- `src/Mesopotamia.Sim/EpistemicState.cs`;
- `src/Mesopotamia.Sim/EpistemicExecution.cs`;
- `src/Mesopotamia.Sim/Simulation.cs`;
- `src/Mesopotamia.Sim/Execution.cs`;
- `src/Mesopotamia.Sim/Decisions.cs`;
- `src/Mesopotamia.Sim/ResolutionDependencies.cs`;
- `src/Mesopotamia.Sim/VerificationAccess.cs`;
- `src/Mesopotamia.Sim/README.md`;
- `tests/Mesopotamia.Sim.AcceptanceTests/*`.

Conditional/watch:

- `src/Mesopotamia.Sim/PersonalDecisionInputs.cs` — extend only if accepted Slice-3 candidate generation needs actor-held Household inputs; never broaden to objective-world omniscience.
- `src/Mesopotamia.Sim/Agency.cs` — avoid redesigning reference personal policy merely because autonomous behavior remains rustic.
- `src/Mesopotamia.Sim/MaterialRecovery.cs` — no new Household grain/treasury concept is expected.

Exact file/class layout is local engineering discretion.

## 6. Explicitly out of scope

Do not implement or stub for IMP-0003:

- general CandidateOrganization equivalence/convergence;
- general “MemberOf(H)” authority;
- privileged `FormHousehold` action;
- HouseholdHeadRole;
- head appointment/vacancy/succession mechanics beyond any negative assertion that a new H begins without an occupied head;
- head Recognition;
- HouseholdDecisionContext;
- separate Household initiative;
- endogenous provision solicitation/reconsideration;
- Household-originated support;
- mediated-marriage dowry spending;
- provision expenditure ranking/debit execution;
- authority-destroying head/action races;
- mediated-marriage authority topology;
- checkpoint/save-load;
- executable actor departure merely for test convenience;
- general nonparticipant observation/perception;
- trust, lying, rumor, reputation, brokerage;
- general organizational ontology;
- generalized fission/merger/reconsolidation;
- repeated predecessor rejoin/re-exit lineage classifier;
- event-sourced current authority;
- pooled Household resources;
- concurrency/parallel/distributed execution;
- strategic/multi-step planning;
- stochastic behavior;
- generic graph database/dependency engine;
- rendered causal-explanation UI.

Do not redesign Slice-1/Slice-2 semantics to make Household implementation easier.

## 7. Required invariants

Preserve:

- typed current state is authoritative; history is provenance/diagnostic history;
- objective state and actor-specific subjective state remain distinct;
- stable semantic identity never derives from mutable content/runtime slot;
- Household identity is not participant set or lifecycle;
- residence is not participation;
- lifecycle is published only at stable closure;
- Dissolved identity does not reactivate;
- CandidateOrganization is inert/non-authoritative;
- no hidden Members authority;
- actor Recognition never passively synchronizes from engine state;
- no Household self-confirmation through its own outputs;
- every proposal revalidates all action-relevant preconditions immediately before commit;
- semantic bridge priority outranks technical proposal/container order;
- one causal bundle cannot both continue H and found duplicate H2;
- cause-key idempotence;
- monotone ReactionIndex;
- no same-cycle voluntary reactivation;
- provision backing never creates pooled grain;
- lineage never transfers causal state;
- ambiguity withholds lineage rather than selecting by ID/order;
- derived/cache state is rebuildable/non-authoritative;
- observer/diagnostic reads are noninterfering;
- technical fallback remains disclosed and quarantined;
- all frozen Slice-1/Slice-2 semantics and evidence remain valid.

### Future seams / deferred gaps

Preserve without implementing:

- `LATER-01` — general CandidateOrganization convergence;
- `LATER-02` — actor departure semantics;
- `LATER-03` — repeated predecessor participation source selection;
- `LATER-04` — authority-destroying head/action race;
- `LATER-05` — mediated-marriage authority topology;
- Slice-4 head/office/collective-action seam;
- Slice-5 checkpoint/recovery seam.

## 8. Acceptance criteria

Completion is controlled by `SFL-V0-S3-ACCEPTANCE-v1`.

Exact frozen Slice-3 census:

- **109 total AcceptanceIds**;
- **96 REQUIRED**;
- **11 DEFERRED**;
- **2 UNEXERCISED**.

Every REQUIRED Slice-3 AcceptanceId must:

- appear individually in completion output;
- execute where executable evidence is required;
- pass;
- have substantive evidence matching the breadth of its wording;
- satisfy declared fixture/write-set restrictions;
- use an acceptable independent oracle/evidence basis;
- not be skipped, silently grouped, or satisfied by a production helper certifying itself.

All Slice-3 DEFERRED/UNEXERCISED rows remain individually visible with their frozen classification.

Exact inherited completion authority also remains mandatory:

- **128 / 128 Slice-1 REQUIRED AcceptanceIds** individually reported green;
- **46 / 46 Slice-2 REQUIRED AcceptanceIds** individually reported green.

The frozen Slice-3 identity must match:

- ref `sfl-v0-slice3-acceptance-v1`;
- freeze commit `25160f33c994fd5f3e277ae98f03e55d37c878dd`;
- manifest SHA `1aae13dc27572361fe99c31ef8aee0444d39364a`.

No implementation/test code may edit/reclassify the frozen manifests.

## 9. Verification expectations

Run exactly from repository root:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Completion evidence must expose:

- exact implementation head SHA;
- frozen Slice-3 manifest version/ref/freeze commit/SHA;
- all 96 REQUIRED Slice-3 row results;
- all 11 DEFERRED + 2 UNEXERCISED rows visibly classified;
- all 128 inherited Slice-1 REQUIRED row results;
- all 46 inherited Slice-2 REQUIRED row results;
- fixture write-set audit;
- independent-oracle audit;
- deterministic/metamorphic results;
- qualifying-support-kind census;
- Household Recognition provenance/conflict evidence;
- lineage positive and negative controls;
- provision reserve/NeedsGrain matrix;
- derived/cache rebuild or structural-nonauthority evidence;
- S1-084 adaptation review result if the trigger fired;
- rule/configuration provenance;
- root command outputs;
- exact-head remote CI/evidence artifact identity where available.

Before promotion:

1. freeze an immutable implementation candidate, normally:
   `imp-0003-slice3-conformance-candidate-v1`;
2. record its exact SHA and CI/evidence identity;
3. commission a **fresh independent post-implementation conformance reviewer** who did not author the implementation or candidate repair;
4. reviewer evaluates the exact frozen candidate against frozen acceptance authority and may use reviewer-owned scratch probes against unchanged public boundaries;
5. only a conformance **PASS — PROMOTE** permits canonical promotion;
6. after promotion, run canonical post-merge CI and write a final completion/promotion record.

IMP-0003 may not self-declare VERIFIED COMPLETE before that process closes.

## 10. Local decisions permitted

The implementation agent may choose ordinary reversible details such as:

- concrete C# record/class/enum names;
- explicit authoritative state partition shape;
- collection/index layout;
- stable ID types/counters;
- warrant storage representation;
- direct versus recomputed derived projections;
- read-only DTO/query names;
- internal reaction-engine factoring;
- test helper organization;
- controlled fixture plumbing that stays outside runtime social acquisition semantics;
- cache/index presence if demonstrably non-authoritative;
- configuration/profile naming.

These choices may not:

- change Household identity meaning;
- invent CandidateOrganization convergence;
- invent observation/Recognition routes;
- invent lineage source-selection semantics;
- create head/office/spending behavior;
- expose objective H truth to actor policy;
- pool grain;
- weaken frozen acceptance;
- weaken prior Slice-1/Slice-2 evidence;
- change the deterministic execution architecture.

## 11. Escalation conditions

Stop and report rather than improvise if implementation appears to require:

1. reconciling multiple candidate referents/evidence paths as one prospective organization;
2. choosing continuity among several existing H interpretations not determined by accepted warrants/precedence;
3. repeated predecessor rejoin/re-exit lineage-source selection;
4. an outsider Household-recognition route beyond accepted direct-participation/communication;
5. a new negative Recognition state or generic evidence-strength algebra;
6. HouseholdHeadRole / HouseholdDecisionContext to satisfy a REQUIRED Slice-3 row;
7. actual Household spending/dowry/debit execution;
8. head/authority-destroying same-cycle race semantics;
9. mediated-marriage authority topology;
10. actor departure semantics;
11. event-sourced current Household authority;
12. a pooled Household treasury or ownership transfer on commitment;
13. parallel/nondeterministic execution;
14. a redesign of proposal/response/revalidation/commit architecture;
15. changing/reclassifying frozen Slice-3 authority;
16. changing the `WorldState` exact private-field inventory or S1-084 structural evidence **without first passing the conditional adaptation review**;
17. a REQUIRED row whose expected result is not uniquely supported by accepted authority.

These are not implementation discretion.

## 12. Work-state discipline

After the freeze/promotion commit containing this packet reaches canonical `main`:

1. create `implementation/imp-0003-slice3-household` from that exact canonical main;
2. keep implementation mutations isolated to that branch/workspace;
3. do not edit frozen acceptance manifests;
4. preserve recoverable increments;
5. if the S1-084 trigger fires, stop the triggering diff and dispatch:
   `tasks/research/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`;
6. if repair iterations become necessary after a frozen implementation candidate, preserve failed candidates and use a bounded repair packet/branch rather than moving an immutable candidate ref.

Do not coordinate concurrent writers through one shared working tree.

## 13. Required completion report

Return:

- terminal status: COMPLETE CANDIDATE / BLOCKED / ESCALATED / INCOMPLETE;
- exact implementation branch/head SHA;
- production/test files changed and why;
- all 96 Slice-3 REQUIRED results;
- all 11 Slice-3 DEFERRED + 2 UNEXERCISED classifications;
- all 128 Slice-1 REQUIRED regression results;
- all 46 Slice-2 REQUIRED regression results;
- fixture/write-set audit;
- independent-oracle audit;
- metamorphic/mutant evidence summary;
- S1-084 adaptation review result if fired;
- root command results;
- exact-head CI/evidence identity;
- local engineering decisions made;
- any escalation/conflict;
- any deviation from this packet;
- unresolved items;
- proposed immutable conformance-candidate ref/SHA.

Do **not** self-declare VERIFIED COMPLETE. The Master Architect freezes the exact implementation candidate and commissions the fresh independent conformance review.

## 14. Delegation boundary

Any child task the implementation agent creates must remain inside this packet's authority, scope, and tool permissions.

No delegate may change accepted semantics or frozen acceptance authority.
