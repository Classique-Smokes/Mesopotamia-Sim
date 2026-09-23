# IMP-0003 Candidate-v3 — Fresh Independent Post-Implementation Conformance Review

**Review type:** fresh regular chat / clean-context exact-candidate conformance  
**Authority:** read-only PASS/BLOCK conformance review  
**Implementation candidate ref:** `imp-0003-slice3-conformance-candidate-v3`  
**Exact candidate SHA:** `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`  
**Failed parent candidate:** `imp-0003-slice3-conformance-candidate-v2` @ `69ae753da2e05450766a9042ac6958fa7aa0b3e7`  
**Canonical implementation base:** `77f3d1dd9630401ff6bba0b38283a823e26d2a01`  
**Implementation PR:** #59  
**Frozen Slice-3 authority:** `SFL-V0-S3-ACCEPTANCE-v1`  
**Frozen Slice-3 ref:** `sfl-v0-slice3-acceptance-v1`  
**Frozen Slice-3 manifest SHA:** `1aae13dc27572361fe99c31ef8aee0444d39364a`  
**Exact-head CI:** run `35935734998` — PASS  
**Evidence artifact:** `10781904631`, `sfl-slice1-slice2-slice3-acceptance-evidence`, digest `sha256:75df9d8d266c5e81fd3a1c87bcfa7a6e955628d29298a1f59b301256234786f8`  
**Required return path:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`

## 1. Purpose

Independently determine whether exact candidate `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048` conforms to:

1. accepted SFL semantics;
2. accepted architecture;
3. frozen `SFL-V0-S3-ACCEPTANCE-v1`;
4. all exact inherited Slice-1 and Slice-2 REQUIRED obligations;
5. the explicit Slice-3 later-slice boundary.

This must be a fresh independent judgment.

Do not modify the candidate.

Do not treat coder-generated PASS tables, PR prose, or the implementation report as proof.

## 2. Independence / anti-anchoring rule

Before forming your own provisional judgment, do **not** rely on:

- any IMP-0003 implementation or repair report;
- PR #59 narrative claims;
- any prior IMP-0003 conformance review or Master Architect BLOCK reconciliation;
- CI-generated row summaries as proof of semantics.

You may inspect those only **after** independently reviewing frozen authority, the whole candidate diff, relevant source, tests, and reviewer-owned probes. Then use them only as corroboration or discrepancy targets.

You must not be an IMP-0003 implementation/repair author.

For stronger independence, do not use either the candidate-v1 or candidate-v2 conformance reviewer as this candidate-v3 reviewer.

If you cannot establish a sufficiently independent context, return without awarding PASS.

## 3. Required authority to retrieve

Retrieve independently:

1. `AGENTS.md`
2. `00_START_HERE.md`
3. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
4. relevant accepted ADRs under `architecture/accepted/`, especially ADR-0001 through ADR-0005
5. `tasks/implementation/IMP-0003_SFL_V0_SLICE3_HOUSEHOLD_SUBSTRATE.md`
6. `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
7. `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_FREEZE_RECORD.md`
8. frozen Slice-1 manifest + freeze record
9. frozen Slice-2 manifest + freeze record
10. relevant canonical verification families:
   - `FORMATION_FAMILY.md`
   - `CONTINUITY_TURNOVER_FAMILY.md`
   - `LINEAGE_FAMILY.md`
   - `RECOGNITION_INFORMATION_FAMILY.md`
   - `PROVISION_GROUNDING_FAMILY.md`
   - `NO_SELF_CONFIRMATION_FAMILY.md`
   - `RESOLUTION_REACTION_FAMILY.md`
   - `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
   - `CROSS_CUTTING_VERIFICATION_CONTRACT.md`
11. exact whole-candidate diff against canonical implementation base `77f3d1dd9630401ff6bba0b38283a823e26d2a01`;
12. exact repair-only diff from failed candidate-v1 `6b9d40e33b94d9094c02fe3d9f026914dd7986ec` to candidate-v2.

Supporting discovery/reconciliation material may be consulted if useful, but it is not semantic authority.

## 4. Candidate identity / immutability

Before substantive review:

- verify `imp-0003-slice3-conformance-candidate-v3` resolves exactly to `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`;
- verify frozen Slice-3 ref resolves to its recorded freeze commit/content;
- verify Slice-1 and Slice-2 frozen manifests remain unchanged;
- verify the candidate diff contains no edits to frozen manifests, SPEC, or accepted ADRs;
- verify the candidate is not moving while under review.

If identity differs, BLOCK immediately.

## 5. Canonical commands

Run exactly from the unchanged candidate root:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Record SDK version, results, warnings/errors, failures/skips.

Green commands are necessary but not sufficient.

## 6. Mandatory source review

Inspect every modified production file and every new/modified Slice-3 acceptance surface.

At minimum inspect:

### Production

- `src/Mesopotamia.Sim/Decisions.cs`
- `src/Mesopotamia.Sim/EpistemicExecution.cs`
- `src/Mesopotamia.Sim/EpistemicState.cs`
- `src/Mesopotamia.Sim/Execution.cs`
- `src/Mesopotamia.Sim/HouseholdExecution.cs`
- `src/Mesopotamia.Sim/HouseholdResolution.cs`
- `src/Mesopotamia.Sim/HouseholdRules.cs`
- `src/Mesopotamia.Sim/HouseholdState.cs`
- `src/Mesopotamia.Sim/ResolutionDependencies.cs`
- `src/Mesopotamia.Sim/Simulation.cs`
- modified runtime documentation;
- CI change.

### Verification

- `tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs`
- `HouseholdScenarios.cs`
- `HouseholdAdversarialScenarios.cs`
- `HouseholdEpistemicScenarios.cs`
- `HouseholdLineageScenarios.cs`
- `HouseholdStructuralScenarios.cs`
- `HouseholdOracle.cs`
- any existing inherited helper/oracle the new tests rely on.

Inspect the actual assertions behind row labels. A table claiming PASS is not itself evidence.

## 7. Frozen Slice-3 conformance

Independently audit all **96 REQUIRED Slice-3 AcceptanceIds**.

For every REQUIRED row verify:

- substantive evidence exists;
- the implementation meaning matches accepted SPEC/ADR semantics;
- fixture writes cannot inject the result under test;
- oracle/checker logic is independent enough;
- grouped rows do not hide missing mandatory subcases;
- broad claims have evidence broad enough to support them;
- no frozen requirement was weakened or silently reinterpreted.

Also verify all:

- **11 DEFERRED** rows remain deferred;
- **2 UNEXERCISED** rows remain unexercised;
- no deferred semantics are implemented as hidden assumptions.

## 8. Exact inherited regressions

Independently verify candidate completion still preserves:

- **128 / 128 Slice-1 REQUIRED** AcceptanceIds;
- **46 / 46 Slice-2 REQUIRED** AcceptanceIds.

Do not merely accept the generated inherited PASS table.

For representative/high-risk inherited surfaces, inspect executable evidence and source directly.

High-priority inherited checks include:

- objective vs subjective separation;
- no passive knowledge sync;
- communication provenance and initiative accounting;
- stable closure / no same-cycle voluntary reactivation;
- residence semantics;
- no pre-Slice3 hidden Household semantics;
- fallback quarantine;
- observer noninterference;
- derived/cache nonauthority;
- exact trace/configuration truth;
- frozen authority integrity.

## 9. High-priority semantic probes

### A. Formation is genuinely downstream

Attempt to establish a path where H forms from:

- objective co-residence alone;
- durable ties without qualifying support recurrence;
- support history without every founder's CandidateRecognition;
- candidate label/ID existence;
- a fixture-written Household/warrant;
- Household-generated feedback.

Any such path is a BLOCK.

Confirm the canonical three-founder formation chain is real production behavior, not a test reconstruction.

### B. No primitive hidden membership

Seek:

- authoritative `Members`-style causal set;
- graph-cluster shortcut;
- residence-derived membership;
- participant-count-derived identity;
- history replay acting as current Household authority.

A read-only/derived projection is allowed only if demonstrably non-authoritative.

### C. Participation both directions

Independently probe:

- newcomer request path;
- participant invite path.

For each challenge missing:

- H Recognition;
- valid bridge;
- shared residence;
- durable tie;
- qualifying post-formation support;
- bilateral acceptance.

Confirm commit-time revalidation can invalidate stale accepted entry.

### D. Participation end / non-erasure

Verify exit ends only `SustainingParticipant` and any applicable provision commitment.

Challenge accidental deletion of:

- residence;
- marriage;
- kinship;
- debt/favour;
- attitude;
- historical records.

### E. Continuity / founder turnover

Review full-turnover history.

Confirm identity survives **only** through explicit historical bridge/warrant transmission.

Then challenge a similar final endpoint with broken bridge: old identity must not persist.

### F. Same-cycle bridge handoff

This is a critical scheduler probe.

Construct/review the case where sole bearer A is required as the newcomer bridge while A also exits that cycle.

Confirm semantic order is:

1. valid entry;
2. continuity reaction;
3. A exit;
4. stable lifecycle publication.

Proposal ID, input order, container iteration, or stable-ID fallback must not dissolve/recreate H.

### G. Continuity vs duplicate formation

Seek a case where the same causal bundle could superficially satisfy fresh formation while validly continuing non-Dissolved H.

Confirm:

- continuity/participation consumes the interpretation;
- duplicate H2 is not formed from the same evidence;
- separately warranted distinct evidence remains able to form overlap.

### H. Dissolution / no resurrection

Confirm:

- Dissolved only at stable closure;
- history remains queryable;
- later similar conditions cannot reactivate same H;
- later valid organization receives a new H identity.

### I. Household Recognition

In addition to the whole-candidate checks below, independently challenge continuation evidence entitlement:
- a current sustaining participant who is not the entry/exit actor, named bridge/counterpart, or communication recipient must not gain a newer continuation basis merely because H continued;
- retained bridge evidence in a ContinuationWarrant must not itself grant observation of the new transition;
- stale Recognition may remain validly held until an accepted update route occurs.

Probe:

- founders direct recognition;
- outsider remains Unknown absent accepted route;
- communication Unknown → Recognized with provenance;
- stale outsider through unwitnessed change;
- accepted newer continuation/dissolution evidence;
- H-specific incomparable evidence → `Contested`;
- `Contested` fails participation Recognition gate;
- IDs/arrival/global-state/history cannot pick a Recognition winner.

Seek any global-engine-to-actor sync path.

### J. Controlled lineage

#### Division

Verify:

- successor forms independently;
- predecessor remains non-Dissolved for positive classification;
- explicit founder exit sources;
- fresh post-exit ordinary support;
- no inherited identity/state.

Negative probes:

- no fresh support;
- predecessor Dissolved before H2 forms;
- ambiguous source.

All must allow ordinary formation where otherwise valid while withholding lineage.

#### Consolidation

Verify:

- both predecessors Dissolved before classification;
- explicit founder source mapping;
- fresh post-dissolution cross-predecessor support;
- unordered predecessor set.

Negative probes:

- one predecessor survives;
- no fresh cross support;
- unrelated H4 history does not pollute predecessor set;
- ambiguity does not resolve by ID/order.

### K. Lineage nonauthority

Seek any path where lineage changes:

- resources;
- claims;
- authority;
- Recognition;
- roles;
- residence;
- lifecycle;
- candidate generation;
- future commits.

Only lineage/ancestry inspection may differ.

### L. Provision backing / capacity

Confirm:

- no Household treasury exists;
- personal grain remains personal;
- capacity is derived;
- reserve boundary grain 1/2/3 => 0/0/1;
- `NeedsGrain` forces zero at same grain;
- participation end/dissolution terminate commitments without confiscation.

Seek any runtime headless commitment-acquisition action. That would be a scope violation.

### M. Reaction closure / idempotence

Challenge:

- duplicate automatic causes;
- skipped reaction closure;
- stale derived projection;
- early lifecycle publication;
- same-cycle voluntary reactivation;
- projection/replay consuming live IDs.

## 10. ResolutionDependencies / HouseholdResolution audit

This is a high-priority code-review area.

Determine whether:

- dependency grouping includes all new action-relevant state;
- affected-person/Household grouping is semantically sufficient;
- residence/admission races are correctly grouped;
- same-cycle handoff uses accepted semantic priority rather than technical order;
- detached replay uses real commit/closure semantics but cannot mutate live authoritative identity counters;
- technical fallback remains disclosed only where accepted;
- nonsemantic iteration/ID renaming remains invariant where required.

Seek hidden semantic priority encoded by proposal IDs or collection order.

## 11. S1-084 trigger verification

The coder reports the S1-084 conditional gate remained unfired.

Independently verify:

- `WorldState` exact private-field inventory is unchanged from canonical parent;
- existing `NoDerivedAuthorityStructuralAudit` is unchanged;
- new Household authoritative state is in a separately explicit partition;
- the new structural audit does not weaken inherited S1-084/S1-META-05/S1-MUT-24 meaning;
- no behavior-affecting derived/cache authority is hidden in the Household partition.

If the old field inventory or old S1-084 evidence was changed without an authorized adaptation review, BLOCK.

## 12. Fixture / producer audit

For each major witness family inspect concrete fixture write sets.

Particularly challenge:

- fixture-written Household/warrants;
- fixture-written final Household Recognition;
- fixture-written derived provision capacity;
- reused produced H state without producer/pass/fixture/config/output provenance;
- lineage fixtures writing predecessor classification;
- negative ablations that accidentally recreate the removed condition through another path.

The controlled pre-existing provision commitment fixture is allowed only within the frozen manifest's narrow boundary and must remain visibly fixture-originated.

## 13. Oracle independence audit

Independently challenge the warrant checker across **formation, participation entry, exit/continuation, and lineage**, not only one family.

Use detached corruptions that successfully construct a public snapshot and then reach the independent checker itself. At minimum try materially false variants involving:

- missing/duplicated/fabricated Recognition evidence;
- nonexistent or wrong stamp/support/source event references;
- wrong support kind/endpoints/order;
- missing/wrong durable ties or participant/association references;
- wrong proposal/acceptance/bridge/newcomer binding;
- false rule/configuration provenance;
- nonqualifying events substituted as lineage fresh evidence.

Valid uncorrupted controls must still pass.

`HouseholdOracle` and other independent checkers must not call production:

- formation classifier;
- participation validator;
- continuity classifier;
- lifecycle classifier;
- Recognition conflict resolver;
- lineage classifier;
- provision-capacity helper

as their expected answer for the rule under judgment.

Simple shared domain IDs/schema/constants are allowed.

Corrupt witness challenges must genuinely falsify checker inputs rather than merely hit production validation first.

## 14. Reviewer-owned scratch probes

Create scratch probes **outside the candidate** against unchanged public/test-access boundaries.

At minimum probe:

1. co-residence + ties + supports but one founder lacking recognition => no H;
2. both participation directions independently work;
3. residence/admission race invalidates correctly regardless of input order;
4. broken bridge cannot preserve old identity;
5. same-cycle sole-bearer handoff preserves identity;
6. Dissolved H cannot reactivate;
7. outsider does not auto-recognize H;
8. incompatible H evidence yields Contested and blocks participation;
9. division from already-Dissolved predecessor does not classify;
10. unrelated H4 history is excluded from consolidation predecessors;
11. lineage projection removal/rebuild does not change behavior;
12. provision reserve/NeedsGrain boundaries;
13. observer/read operations do not alter trajectory/IDs;
14. nonsemantic ID renaming preserves representative Household result;
15. no head/office/household-spending action is available;
16. under a custom scenario configuration label, Household Request/Invite response/event/warrant provenance still truthfully reports Slice-3 rules while ordinary Slice-2 actions in the same run retain Slice-2 rules;
17. a remote current bearer uninvolved in a continuation transition retains its prior Household Recognition basis until accepted communication/direct evidence updates it;
18. detached corruptions across formation, participation, exit-continuation and lineage are independently rejected while valid controls pass;
19. a disconnected Household does not cause two compatible ordinary loans in another component to gain technical-fallback labels under proposal-ID/input/world-order permutations;
20. genuine noncommuting capacity, communication and favour/debt cases still disclose fallback.

Document setup and assertion count.

Do not commit scratch probes to the candidate.

## 15. Scope / later-slice leakage audit

BLOCK if candidate implements or depends on:

- general CandidateOrganization convergence/equivalence;
- general universal membership;
- HouseholdHeadRole appointment/succession;
- head Recognition;
- HouseholdDecisionContext / separate Household initiative;
- endogenous provision solicitation/reconsideration;
- Household support or dowry spending;
- contributor debit/ranking execution;
- authority-destroying head races;
- mediated-marriage authority topology;
- checkpoint/save-load;
- general nonparticipant observation;
- repeated predecessor rejoin/re-exit lineage source algorithm;
- general fission/merger/reconsolidation engine;
- trust/rumor/reputation;
- strategic/stochastic policy redesign.

## 16. CI / delivery evidence audit

Independently verify exact-head CI:

- run `35935734998` belongs to exact candidate SHA;
- run conclusion is success;
- artifact `10781904631` exists, is unexpired, and has digest:
  `sha256:75df9d8d266c5e81fd3a1c87bcfa7a6e955628d29298a1f59b301256234786f8`;
- canonical root command steps completed successfully;
- evidence artifact contains the expected Slice-1/2/3 evidence surfaces.

CI success does not replace semantic review.

Also verify the candidate-v3 evidence artifact records `ImplementationHead=35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`, `WorkingTreeDirty=false`, and the frozen 96/11/2 Slice-3 classifications plus 128+46 inherited REQUIRED sets. Verify the repair-v3 control evidence independently rather than accepting its counts as proof.

## 17. Review prior claims — only after independent judgment

Only after fixing your own provisional result may you inspect:

- `tasks/implementation/IMP-0003_IMPLEMENTATION_REPORT.md`;
- `tasks/implementation/IMP-0003_REPAIR_V2_REPORT.md`;
- `tasks/implementation/IMP-0003_REPAIR_V3_REPORT.md`;
- prior IMP-0003 conformance reviews/reconciliations;
- PR #59 prose;
- CI/evidence metadata.

Use them only to corroborate or identify discrepancies. Confirm that prior repaired defects remain repaired, but do not limit the review to those repairs. This is a **whole-candidate** conformance judgment.

## 18. Result classification

Return exactly one:

### PASS — PROMOTE

No material semantic, architectural, acceptance-coverage, fixture, oracle, inherited-regression, or scope defect established.

### BLOCK — IMPLEMENTATION / VERIFICATION DEFECT

Accepted semantics are clear but candidate fails them or evidence is insufficient.

Identify exact defect and bounded repair scope.

### BLOCK — SEMANTIC ESCALATION

Candidate cannot satisfy frozen authority without a genuinely missing consequential semantic/architectural rule.

State the exact missing decision. Do not invent it.

## 19. Return artifact

Create review branch:

`review/imp-0003-conformance-v3-independent-return`

from exact candidate SHA:

`35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`

Add only:

`research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`

The report must include:

- exact candidate SHA/ref;
- exact frozen authority identities;
- verdict;
- explicit **PROMOTE / DO NOT PROMOTE** recommendation;
- canonical command results;
- 96-row Slice-3 REQUIRED audit summary;
- 11 DEFERRED / 2 UNEXERCISED audit;
- 128 Slice-1 / 46 Slice-2 inherited audit;
- fixture/producer findings;
- oracle-independence findings;
- scheduler/dependency findings;
- S1-084 trigger finding;
- scratch-probe summary;
- scope-leakage finding;
- CI/artifact identity verification;
- semantic-escalation status;
- contamination/provenance disclosure.

Do not modify the candidate.
