# Implementation Task Packet — SFL v0 Reference Slice 4: Household Head, Dual-Mode Agency and Grounded Collective Action

**Task ID:** IMP-0004  
**Commissioned by:** Master Architect  
**Status:** READY FOR DISPATCH / NO CODING BĀRÛ ACTIVE YET  
**Context mode:** CODING-PRIEST / PROJECT-CONTEXT — repository authority controls  
**Planned implementation branch:** `implementation/imp-0004-slice4-household-head-collective-action`

## Dispatch gate

All pre-code Slice-4 gates are closed.

### Frozen completion authority

- manifest: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`
- version/ref: `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`
- frozen manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`
- freeze record: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`
- census: **176 unique = 165 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**
- final pre-code review: **PASS — MAY FREEZE UNCHANGED**

### Approved inherited-verification adaptation authority

- approved ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`
- exact commit: `68fddec788b5cf41db5934c8719a6fd1ce474d32`
- plan path: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_PLAN.md`
- exact plan blob: `00c3e64a128fa00e91b99117e321a0e379dd61c5`
- independent review: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2_CANDIDATE2.md`
- verdict: **PASS — ADAPTATION PLAN APPROVED**
- approval record: `plans/verification/SFL_V0/SLICE4_INHERITED_VERIFICATION_ADAPTATION_V2_APPROVAL_RECORD.md`

### Implementation release

- release record: `plans/verification/SFL_V0/SLICE4_IMPLEMENTATION_RELEASE_RECORD.md`
- historical blocked boundary remains immutable at `sfl-v0-slice4-implementation-boundary-blocked-v1`.

No implementation work may weaken, reinterpret, edit, move, or replace the frozen completion authority or the approved adaptation authority.

## 1. Objective

Extend the verified Slice-3 reference kernel with the bounded accepted Slice-4 Household representative/collective-action layer.

Implement, omission-detectably and without architectural redesign:

- one persistent `HouseholdHeadRole(H)` identity distinct from H and occupant;
- explicit vacancy/occupancy, appointment and succession;
- actor-specific head-role Recognition with stale/corrected/Contested evidence behavior;
- one separate `HouseholdDecisionContext(H, head=P)` initiative while P retains one ordinary personal initiative;
- endogenous provision-commitment solicitation/reconsideration;
- accepted current-head self-commitment topology;
- grounded Household support and mediated-marriage material effects;
- exact fixed-rank multi-contributor funding and live revalidation;
- DEC-0011 transaction-specific private contribution `X` with exact `R=C-X` funding semantics and provenance;
- DEC-0010 authority-use-before-authority-destruction;
- DEC-0013 D1–D6 interaction closures;
- required resource-seam/provenance/nonidentity guardrails;
- only the approved lossless inherited-verification adaptations when their actual implementation trigger fires.

The result must remain a deterministic reference-kernel extension within accepted architecture.

## 2. Required inputs by authority class

### Accepted semantic / architectural authority

Read and obey at minimum:

- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`;
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted ADRs under `architecture/accepted/`, especially:
  - ADR-0001 active social state representation;
  - ADR-0002 hierarchical individual agency;
  - ADR-0003 progressive derived-state specialization;
  - ADR-0004 reference simulation kernel;
  - ADR-0005 host runtime;
- `decisions/DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md`;
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`;
- `decisions/DEC-0012_SEMANTIC_INTERACTION_DELTA_FAILSAFE.md`;
- `decisions/DEC-0013_SLICE4_SID_CLOSURE_AND_V0_RESOURCE_SCAFFOLD_BOUNDARIES.md`.

These control meaning and architecture.

### Frozen verification / completion authority

- `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`;
- `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`;
- exact ref/blob in the dispatch gate above.

Every **165 REQUIRED** row is mandatory completion authority.

All **9 DEFERRED** and **2 UNEXERCISED** rows remain visibly classified and must not be silently implemented/reclassified merely for convenience.

Frozen Slice-1/2/3 authority remains mandatory through the exact inherited set embedded in v2:

- **128 Slice-1 REQUIRED**;
- **46 Slice-2 REQUIRED**;
- **96 Slice-3 REQUIRED**;
- **270 inherited REQUIRED total**.

Verification authority defines completion obligations but does not create semantics.

### Approved inherited-verification adaptation authority

Read the exact approved plan from:

`sfl-v0-slice4-inherited-verification-adaptation-v2-approved`

at commit:

`68fddec788b5cf41db5934c8719a6fd1ce474d32`

Only that plan authorizes changes to the mapped inherited literal verification witnesses.

A newly discovered inherited literal witness outside that plan is **STOP / escalation before modification**.

### Semantic-interaction-delta closure

`SID-ASSURANCE-v1` **FIRED and is CLOSED / CURRENT**.

Required closure sources:

- `research/technical/SFL_V0_SLICE4_SID_FRONTIER_COMPARISON_AND_PASSB_UNION.md`;
- `research/technical/SFL_V0_SLICE4_SID_PASSB_RECONCILIATION.md`;
- `research/technical/SFL_V0_SLICE4_SID_CLOSURE_REVALIDATION.md`.

Closure markers:

- consequential unresolved: **0**;
- accidental gaps outstanding: **0**.

**STOP and escalate** if implementation exposes a consequential new↔old interaction, alias, resource/authority dependency, transition carryover, suppression/narrowing, retargeting, or shared-capacity case not classified by that closure.

Do not repeat the whole SID audit; do not invent the answer.

### Required non-authoritative supporting / engineering context

Use as implementation archaeology / risk maps, subordinate to accepted authority:

- `research/technical/SFL_V0_SLICE4_IMPLEMENTATION_SURFACE_MAP.md`;
- `research/technical/SFL_V0_SLICE4_PREIMPLEMENTATION_RECONCILIATION.md`;
- `research/technical/SFL_V0_SLICE4_VERIFICATION_TRIGGER_MAP.md`;
- `research/technical/TRES-0011/TRES-0011_MASTER_ARCHITECT_RECONCILIATION.md`;
- `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REASSESSMENT.md`;
- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`;
- `AGENTS.md`.

### Authority precedence

Accepted semantic/architectural authority controls meaning.

Frozen acceptance v2 controls completion applicability.

The approved adaptation plan controls only the explicitly mapped verification-form changes.

Supporting/research/engineering context cannot silently override any of those.

## 3. Scope

Implement the accepted Slice-4 behavior through the smallest sufficient extension of the current kernel.

Expected high-pressure production surfaces include:

- `src/Mesopotamia.Sim/HouseholdState.cs`;
- `src/Mesopotamia.Sim/HouseholdExecution.cs`;
- `src/Mesopotamia.Sim/HouseholdProjection.cs`;
- `src/Mesopotamia.Sim/HouseholdResolution.cs`;
- `src/Mesopotamia.Sim/ResolutionDependencies.cs`;
- `src/Mesopotamia.Sim/EpistemicState.cs`;
- `src/Mesopotamia.Sim/EpistemicExecution.cs`;
- `src/Mesopotamia.Sim/Decisions.cs`;
- `src/Mesopotamia.Sim/Execution.cs`;
- `src/Mesopotamia.Sim/Simulation.cs`;
- `src/Mesopotamia.Sim/State.cs` where accepted authority genuinely requires it;
- `src/Mesopotamia.Sim/VerificationAccess.cs`;
- `src/Mesopotamia.Sim/README.md`;
- `tests/Mesopotamia.Sim.AcceptanceTests/*`.

Conditional/watch surfaces:

- `PersonalDecisionInputs.cs` — only where accepted head/Household decision inputs require it;
- `Agency.cs` — do not redesign the reference personal policy merely to make Household behavior look richer;
- `MaterialRecovery.cs` — do not introduce a Household treasury/pool or future-economy abstraction.

Exact files, records, enums, collection shapes, and helper factoring are implementation-local where authority leaves representation open.

### Required feature groups

#### A. Persistent role / appointment / succession

Implement:

- one continuing role identity per H;
- formation-time vacancy;
- valid nomination/appointment/succession;
- nominee and participant acceptance predicates;
- self-nomination multi-capacity semantics;
- snapshot-bound consent cohort with live captured-member revalidation;
- vacancy on occupant participation end where accepted;
- Inactive-H inert role fill;
- H and role identity preservation across succession/reactivation.

#### B. Head Recognition

Extend the existing actor-specific epistemic system for:

- transition-participant direct role evidence;
- outsider staleness;
- correction through accepted routes;
- incompatible evidence / Contested behavior;
- no passive objective-state synchronization.

#### C. Dual-mode agency

Implement:

- one personal initiative for P;
- one separate Household initiative for valid Active H through current head P;
- same committed decision snapshot;
- separate concern scoring/trace;
- no use of Household authority to command ordinary personal action;
- no Household context for vacant/Inactive H.

#### D. Provision acquisition / reconsideration

Implement:

- ordinary endogenous commitment acquisition;
- refusal/reconsideration cooldown and context-change rule;
- accepted current-head self-commitment with explicit dual-capacity private-resource authorization and no fake P→P response;
- strict provenance distinctions required by the approved adaptation plan.

#### E. Grounded material action

Implement accepted Household:

- 1-grain support;
- mediated-marriage dowry;
- fixed-rank contribution allocation;
- live capacity/revalidation;
- exact debit/effect history;
- no pooled treasury;
- resource state remaining separate from Household/role/Recognition identity.

#### F. DEC-0011 private X

For a permitted Household material action with total cost C:

- optional exact current-head private contribution X;
- absent X = no private contribution;
- valid X is exact positive integral and X <= C;
- distinct role authority and private-resource authorization;
- residual commitment requirement exactly R = C-X;
- partial, shortfall-supplement and full-private X=C cases;
- protected reserve / NeedsGrain limits;
- same-head commitment-side capacity reduced by X;
- no feasibility/allocation/debit double count;
- exact plan revalidation at commit;
- no silent X change/rebalance/renegotiation;
- no successor rebinding;
- no extra personal initiative/self-response;
- no Gift/Help/Loan/favour/ordinary-transfer side meaning;
- no organizational evidence from X;
- typed distinct funding provenance.

#### G. Resolution / interaction closure

Implement the already accepted bounded cases, including:

- Household provision above `RepayDebt` in the current v0 shared-grain conflict;
- DEC-0010 valid last act before authority/status destruction;
- bridge-entry + snapshot-bound succession cohort composition;
- head as support recipient;
- head self-commitment;
- self-nomination;
- Inactive inert role occupancy;
- existing stable closure/fallback quarantine.

#### H. Approved inherited verification adaptations

When implementation actually fires a mapped trigger, apply only the approved lossless adaptation:

1. S3-014 type-absence witness -> state/history formation-headlessness evidence;
2. S3-093/S1-084 structural inventory -> equivalent-or-stronger explicit authority/nonhidden-state enforcement, including mandatory critical-seam fault control;
3. global no-Household-material-event literal -> historical Slice-3 boundary + positive bounded Slice-4 material allowance;
4. fixture-only provision provenance -> closed fixture / ordinary endogenous / head-self-commitment provenance distinction.

Do not pre-edit still-green inherited tests before the production change fires the trigger merely to “prepare.”

## 4. Explicitly out of scope

Do not implement, stub, or generalize for IMP-0004:

- exact checkpoint/save-load continuation — Slice 5;
- generic actor departure;
- general CandidateOrganization convergence;
- repeated-predecessor rejoin/re-exit lineage-source generalization;
- general contested succession / simultaneous rival claimants / usurpation;
- a separate resignation action while remaining a sustaining participant;
- generic nonparticipant perception/observation;
- trust, lying, rumor, reputation;
- generic friendship/status extensions;
- general Household sovereignty or deep administration;
- arbitrary participant private supplementation beyond accepted current-head X;
- reimbursement/prestige/political leverage from private X;
- sacrifice below protected reserve;
- generic split-tender/payment framework;
- pooled/common Household treasury merely to “future-proof”;
- mature ownership/property/land/livestock/production/accounting/budget economy;
- generic asset/property/ledger/settlement framework;
- historical calibration of resource quantities, priorities, ownership, debt hierarchy, support frequency or economic behavior;
- strategic/multi-step planning;
- stochastic behavior redesign;
- concurrency/parallel/distributed execution;
- generalized event-sourced current authority;
- rendered causal-explanation UI;
- generic generated-history/shrinking framework as a completion dependency.

Do not redesign Slices 1–3 semantics to make Slice 4 easier.

## 5. Required invariants

Preserve at minimum:

- typed current state is authoritative; history is causal/provenance evidence, not hidden current authority;
- stable semantic identity never derives from mutable content/runtime slot;
- Household identity remains distinct from participants, role, occupant, current capacity and resource balance;
- one persistent role identity remains distinct from H and PersonId;
- objective role/Household state never passively synchronizes subjective Recognition;
- one person may carry role/private/beneficiary/nominator/nominee/participant capacities without collapsing required predicates;
- no artificial self-negotiation context is introduced where accepted alias semantics collapse it;
- P retains exactly one ordinary personal initiative while H has its separate accepted initiative;
- accepted responses do not consume personal initiative;
- all action-relevant preconditions revalidate immediately before commit;
- technical/container/ID order does not create social authority except explicit accepted fallback domains;
- DEC-0010 never revives an invalid-at-snapshot action or rebinds an old-head action;
- bridge continuity rules remain intact;
- lifecycle remains published at stable closure;
- Dissolved H does not reactivate;
- Household output/private X cannot self-confirm formation/continuity/lineage;
- no pooled Household treasury;
- `MobilizableCapacity(H)` remains derived/rebuildable/non-authoritative;
- one authoritative live funding-resolution result controls the transaction;
- dependency discovery consumes declared/evaluated material participation rather than maintaining a second allocator;
- funding provenance remains typed and reconstructable;
- same personal grain cannot be double-counted across private X and commitment capacity;
- resource mechanics do not define H/participation/role/Recognition identity;
- instrumentation/verification reads remain observer-noninterfering;
- frozen prior acceptance authority remains immutable.

### Future seams / deferred gaps

Preserve without implementing:

- Slice-5 exact continuation/checkpoint recovery;
- richer Household economy/resource model;
- generic institutional/property authority;
- general contested succession;
- future historical calibration.

## 6. Acceptance criteria

Completion is controlled by frozen `SFL-V0-S4-ACCEPTANCE-v2`.

The implementation agent does **not** choose what is “applicable.”

### Exact Slice-4 census

- **176 total AcceptanceIds**
- **165 REQUIRED**
- **9 DEFERRED**
- **2 UNEXERCISED**

Every one of the **165 REQUIRED** rows must:

- be reported individually;
- have substantive evidence matching its full wording;
- pass;
- satisfy fixture/producer/oracle restrictions;
- not be silently grouped, skipped, weakened, or self-certified through an assertion-target production helper.

Every DEFERRED/UNEXERCISED row remains individually visible with its frozen classification.

### Exact inherited regression authority

Also report individually green:

- **128 / 128 Slice-1 REQUIRED**;
- **46 / 46 Slice-2 REQUIRED**;
- **96 / 96 Slice-3 REQUIRED**.

Total inherited REQUIRED: **270 / 270**.

### Adaptation evidence

For every inherited verification adaptation actually triggered:

- identify the frozen historical row/witness;
- identify the approved adaptation-plan section;
- show the exact test/oracle diff;
- show that the historical semantic invariant remains enforced;
- execute the required negative/corruption control;
- report any mapped adaptation not triggered and why.

A newly discovered inherited literal witness outside the approved plan blocks completion until escalated/reviewed.

### Authority integrity

Completion evidence must prove:

- frozen v2 ref/blob unchanged;
- approved adaptation ref/blob unchanged;
- frozen prior manifests unchanged.

## 7. Verification expectations

Run from repository root:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Completion evidence must include:

- exact implementation branch/head SHA;
- frozen Slice-4 v2 version/ref/blob;
- approved adaptation version/ref/commit/blob;
- all 165 Slice-4 REQUIRED row results;
- all 9 DEFERRED + 2 UNEXERCISED rows visibly classified;
- all 270 inherited REQUIRED row results;
- fixture/write-set audit;
- independent-oracle audit;
- critical-seam structural hidden/stale-authority mutant result;
- Household material-event corruption controls;
- commitment-provenance corruption controls;
- deterministic/permutation/metamorphic results;
- role/H identity continuity evidence;
- head Recognition stale/corrected/Contested evidence;
- dual-mode initiative/accounting evidence;
- fixed-rank funding/debit-vector evidence;
- exact private-X funding-plan cases;
- RepayDebt conflict evidence;
- authority-destruction race evidence;
- stable closure/fallback quarantine evidence;
- rules/configuration/provenance truth;
- root command outputs;
- exact-head remote CI/evidence identity where available.

### Post-implementation conformance gate

IMP-0004 may not self-declare VERIFIED COMPLETE.

Before promotion:

1. coding bārû returns a **COMPLETE CANDIDATE**, not final completion;
2. Master Architect freezes an exact immutable implementation candidate, normally beginning with:
   `imp-0004-slice4-conformance-candidate-v1`;
3. record exact candidate SHA and CI/evidence identity;
4. commission a fresh independent post-implementation conformance reviewer who did not author implementation/candidate repair;
5. reviewer evaluates exact frozen candidate against frozen acceptance v2 + approved adaptation authority and may use reviewer-owned probes/metamorphics against unchanged public boundaries;
6. only **PASS — PROMOTE** permits canonical promotion;
7. after promotion, run post-merge CI and write final completion/promotion record.

## 8. Local decisions permitted

The coding bārû may choose ordinary reversible engineering details including:

- concrete C# record/class/enum names;
- authoritative role-state partition layout;
- collection/index layout;
- stable ID/counter representation;
- proposal/action record factoring;
- response-record representation where accepted semantic predicates remain omission-detectable;
- closed provenance representation for fixture / ordinary endogenous / self-commitment origins;
- transaction funding-plan internal record shape;
- query/helper factoring;
- deterministic contributor allocator implementation details that preserve accepted result;
- derived cache/index presence if demonstrably rebuildable/nonauthoritative;
- test helper organization;
- explicit structural-audit mechanism if equivalent-or-stronger than the inherited exact inventory check;
- read-only verification DTO/query names.

These choices may not:

- change role/H identity meaning;
- choose new conflict priority;
- invent new authority/Recognition route;
- turn technical ordering into social meaning;
- make office occupancy expose private resources;
- generalize X beyond accepted scope;
- create a treasury/economy framework;
- weaken frozen acceptance;
- weaken inherited verification outside approved adaptation;
- redesign the deterministic execution architecture.

## 9. Escalation conditions

Stop and report rather than improvise if implementation appears to require:

1. any semantic outcome not uniquely determined by accepted authority;
2. any consequential interaction not classified by current SID closure;
3. a new inherited literal verification witness outside the approved adaptation plan;
4. editing/reclassifying frozen v2 or prior frozen manifests;
5. weakening an inherited test beyond an approved mapping;
6. a generic resource/asset/property/ledger architecture;
7. a pooled Household treasury;
8. arbitrary participant supplementation beyond current-head X;
9. a new current-head funding priority or silent X rebalance;
10. a new Recognition/perception route;
11. general contested succession or rival-claim semantics;
12. actor departure semantics;
13. checkpoint/save-load semantics;
14. generic resignation while remaining participant;
15. parallel/nondeterministic execution;
16. event-sourced current authority;
17. changing the single authoritative funding/dependency seam into duplicated sources of truth;
18. an acceptance row whose expected result appears unsupported by accepted authority;
19. an implementation architecture change with persistent cross-system consequence not already accepted.

These are not implementation discretion.

## 10. Work-state discipline

After the dispatch/release commit containing this packet reaches canonical `main`:

1. work only on isolated branch `implementation/imp-0004-slice4-household-head-collective-action` created from that exact canonical release state;
2. preserve recoverable increments;
3. do not edit frozen acceptance/ref records;
4. do not move approved adaptation refs;
5. adapt inherited tests only when an actual implementation trigger fires and only under the approved plan;
6. if a new inherited witness is discovered, stop before modifying it;
7. if a frozen implementation candidate later fails conformance, preserve it and use a new candidate/repair branch rather than moving the immutable ref.

Any delegated child task must remain inside this packet's authority and scope.

## 11. Required completion report

Return:

- terminal status: **COMPLETE CANDIDATE / BLOCKED / ESCALATED / INCOMPLETE**;
- exact implementation branch/head SHA;
- production/test files changed and why;
- local engineering decisions made;
- all **165 Slice-4 REQUIRED** results individually;
- all **9 DEFERRED + 2 UNEXERCISED** classifications;
- all **270 inherited REQUIRED** results individually;
- exact adaptation triggers fired/not fired;
- mapped inherited test/oracle diffs;
- structural critical-seam mutant evidence;
- material/provenance corruption evidence;
- fixture/write-set and independent-oracle audits;
- root command results;
- exact-head CI/evidence identity;
- any semantic/architectural conflict or escalation;
- any deviation from this packet;
- any new unresolved issue;
- proposed immutable conformance-candidate ref/SHA.

Do **not** self-declare VERIFIED COMPLETE.

## 12. Delegation boundary

Any child task must remain inside this packet's authority, scope, and permitted capabilities.

No delegate may:

- change accepted semantics;
- change frozen acceptance authority;
- broaden the approved verification adaptation;
- self-authorize a new inherited-test weakening;
- redesign the architecture.

The Master Architect remains the reconciliation/promotional owner after the coding return.
