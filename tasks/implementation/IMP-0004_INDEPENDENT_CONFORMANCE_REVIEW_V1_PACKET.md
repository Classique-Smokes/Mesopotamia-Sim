# IMP-0004 Candidate-v1 — Fresh Independent Post-Implementation Conformance Review

**Review type:** fresh regular chat / clean-context exact-candidate whole-conformance review  
**Authority:** read-only PASS/BLOCK conformance judgment  
**Status:** ARCHITECT-DISPATCHED / READY / NO REVIEWER ACTIVE YET  
**Implementation candidate ref:** `imp-0004-slice4-conformance-candidate-v1`  
**Exact candidate SHA:** `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`  
**Implementation PR:** #109 — draft / must remain unmerged during review  
**Frozen Slice-4 authority:** `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`  
**Frozen manifest blob:** `b0bc79e46f82630ab78cd2f0d0414b748212a411`  
**Approved inherited-adaptation ref:** `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`  
**Approved adaptation commit/blob:** `68fddec788b5cf41db5934c8719a6fd1ce474d32` / `00c3e64a128fa00e91b99117e321a0e379dd61c5`  
**Exact-head CI:** run **36094176584** — PASS  
**Evidence artifact:** **10846019591**, digest `sha256:22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6`  
**Freeze record:** `research/technical/IMP-0004/IMP-0004_CANDIDATE_V1_FREEZE_RECORD.md`  
**Required return branch:** `review/imp-0004-conformance-v1-independent-return`  
**Required return path:** `research/technical/IMP-0004/IMP-0004_INDEPENDENT_CONFORMANCE_REVIEW_V1.md`

## 1. Purpose

Independently determine whether exact candidate:

`bac53decaafb5edf4c5879be0f695f6a52ccc1ce`

conforms to:

1. accepted SFL semantics and architecture;
2. DEC-0010 / DEC-0011 / DEC-0013 / DEC-0014;
3. frozen `SFL-V0-S4-ACCEPTANCE-v2`;
4. all exact inherited Slice-1/2/3 REQUIRED obligations;
5. the approved inherited-verification adaptation plan;
6. explicit Slice-4 scope/deferred boundaries.

This must be a **fresh whole-candidate judgment**.

Do not modify the candidate.

Do not merge PR #109.

Do not treat coder PASS tables, implementation-report prose, CI success, or artifact existence as sufficient proof.

## 2. Independence / anti-anchoring

Before fixing your own provisional judgment, do not rely on:

- `IMP-0004_CANDIDATE_IMPLEMENTATION_REPORT.md`;
- `IMP-0004_ADAPTATION_LEDGER.md`;
- PR #109 prose;
- generated acceptance PASS summaries;
- the coding bārû's reasoning or self-evaluation.

You may inspect those **after** independently reading the controlling authority, the whole candidate diff/source/tests and your own probes. Use them only as corroboration/discrepancy targets.

You must not be:

- an IMP-0004 implementation author;
- author of DEC-0014 implementation changes;
- author of the candidate assurance package;
- a prior reviewer who materially authored the implementation repair.

If fresh independence cannot be established, do not award PASS.

## 3. Authority hierarchy

Retrieve independently:

### Semantic / architectural authority

- `AGENTS.md`
- `00_START_HERE.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted ADRs / architecture, especially active social state, hierarchical individual agency, progressive derived-state specialization, reference kernel, host runtime
- `decisions/DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `decisions/DEC-0013_SLICE4_SID_CLOSURE_AND_V0_RESOURCE_SCAFFOLD_BOUNDARIES.md`
- `decisions/DEC-0014_HISTORICAL_MATERIAL_NEED_RECONSIDERATION_CONTEXT.md`

### Completion authority

- `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`
- `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`
- frozen Slice-1/2/3 manifests and freeze records
- all relevant canonical verification families, especially:
  - `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`
  - `PROVISION_GROUNDING_FAMILY.md`
  - `RECOGNITION_INFORMATION_FAMILY.md`
  - `RESOLUTION_REACTION_FAMILY.md`
  - `CONTINUITY_TURNOVER_FAMILY.md`
  - `NO_SELF_CONFIRMATION_FAMILY.md`
  - `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md`

### Approved inherited-verification adaptation authority

- `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_PLAN.md` at approved ref `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`
- `plans/verification/SFL_V0/SLICE4_INHERITED_VERIFICATION_ADAPTATION_V2_APPROVAL_RECORD.md`

### DEC-0014 freshness/closure

- `research/technical/IMP-0004/DEC-0014_ACCEPTANCE_AND_SID_FRESHNESS_REVALIDATION.md`
- `research/technical/IMP-0004/IMP-0004_IMPLEMENTATION_ESCALATION_01_CLOSURE.md`

Semantic authority controls meaning. Frozen acceptance controls applicability/completion. Approved adaptation authority only permits the four mapped inherited-witness transformations. Coder/report convenience controls nothing.

## 4. Candidate identity / immutability

Before substantive review:

- verify `imp-0004-slice4-conformance-candidate-v1` resolves exactly to `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`;
- verify PR #109 head resolves to that same SHA;
- verify the candidate ref does not move during review;
- verify frozen acceptance/adaptation refs/blobs remain exact;
- verify candidate did not rewrite/reclassify frozen manifests;
- distinguish candidate implementation changes from later unrelated conceptual-library commits on canonical `main`.

If identity differs, BLOCK immediately.

## 5. Canonical commands

From an unchanged checkout of exact candidate:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Record SDK version, exit codes, warnings/errors/failures/skips.

Green commands are necessary, not sufficient.

## 6. Whole-candidate source review

Inspect **all** modified production and verification files in PR #109.

High-pressure production surfaces include:

- `Decisions.cs`
- `EpistemicExecution.cs`
- `EpistemicState.cs`
- `Execution.cs`
- `HouseholdAgency.cs`
- `HouseholdCollectiveExecution.cs`
- `HouseholdCollectiveRules.cs`
- `HouseholdExecution.cs`
- `HouseholdFunding.cs`
- `HouseholdHeadExecution.cs`
- `HouseholdHeadState.cs`
- `HouseholdParticipationKnowledge.cs`
- `HouseholdPriorities.cs`
- `HouseholdProjection.cs`
- `HouseholdResolution.cs`
- `HouseholdRules.cs`
- `HouseholdState.cs`
- `ProvisionReconsideration.cs`
- `ResolutionDependencies.cs`
- `Simulation.cs`

Verification surfaces include all new `Slice4*` acceptance/test/oracle files plus modified inherited Household witnesses and `Run-Slice4Mutants.ps1`.

Inspect actual semantics/assertions, not row labels.

## 7. Frozen Slice-4 acceptance audit

Independently audit all **165 REQUIRED Slice-4 AcceptanceIds**.

For each REQUIRED row establish:

- executable/substantive evidence exists;
- evidence matches the full frozen wording;
- implementation meaning agrees with accepted semantics;
- fixture/setup cannot write the result under test;
- the checker/oracle is independent enough;
- grouped/table-driven evidence does not hide a mandatory subcase;
- rule/configuration/provenance identity is truthful;
- no broader claim is inferred from a narrow witness.

Also verify individually:

- **9 DEFERRED** remain deferred;
- **2 UNEXERCISED** remain unexercised;
- no deferred semantics have leaked into the candidate.

Do not accept generated 165/165 output as sufficient by itself.

## 8. Exact inherited audit

Independently verify all inherited REQUIRED sets remain green and semantically intact:

- Slice 1: **128 / 128**
- Slice 2: **46 / 46**
- Slice 3: **96 / 96**

Total inherited REQUIRED: **270 / 270**.

Directly inspect high-risk inherited areas whose enforcement form changed or which Slice 4 composes with:

- objective/subjective separation;
- no passive knowledge synchronization;
- Household formation headlessness;
- exact structural authority/nonhidden-derived-state constraints;
- fixture-only Slice-3 provision acquisition boundary;
- Slice-3 no-Household-material-effect boundary;
- participation/lifecycle/continuity;
- fallback quarantine;
- observer noninterference;
- semantic identity vs allocation/ID order;
- deterministic detached replay.

## 9. Approved adaptation A — formation headlessness

Confirm the inherited S3-014 implementation-era type-absence witness changed **only** under approved adaptation A.

Independently prove:

- formation creates one persistent role if accepted representation does so, but no occupant;
- no Household initiative appears from formation;
- no head-mediated effect appears merely because H exists;
- self-nomination does not become formation-time self-installation;
- Inactive-H role fill remains later lifecycle behavior.

Require a corruption/mutant that silently installs an occupant or emits Household initiative and ensure replacement evidence detects it.

## 10. Approved adaptation B — structural authority / hidden-state detection

This is a critical area.

Verify all new behavior-affecting authoritative state is explicit/typed/inspectable.

Challenge hidden/stale authority influencing:

- current head;
- captured appointment/succession cohort;
- refusal/reconsideration baseline;
- private X;
- funding result/participation;
- dependency grouping.

The mandatory critical-seam mutant must actually alter or be capable of altering semantic behavior through hidden/stale:

- current-head / role state; or
- authoritative funding state; or
- material-dependency participation.

A generic unrelated hidden field is insufficient.

Verify derived/cache/index state is rebuildable/nonauthoritative and cannot become a second source of truth.

## 11. Approved adaptation C — Household material-event boundary

Verify historical Slice-3 no-spending/no-treasury meaning remains exact.

For Slice 4, permit material change only through accepted Household material meanings with valid authority/funding.

Challenge:

- arbitrary Household material event;
- accepted-looking event with invalid authority;
- wrong cost/residual/debits;
- hidden treasury/pool source;
- private X emitted as a separate Gift/Help/Loan;
- aggregate deltas that erase typed funding provenance.

Private X is a funding leg inside the Household action, not an independent material meaning.

## 12. Approved adaptation D — commitment provenance

Independently verify strict distinction between:

1. controlled Slice-3 fixture commitment;
2. ordinary Slice-4 endogenous commitment with actual target acceptance;
3. current-head self-commitment with distinct institutional predicate + explicit private-resource authorization and **no fake P→P response**.

Challenge cross-labeling, wrong actor/role, missing request/acceptance, causal-order corruption, office-only self-commitment, missing private authorization, fake self-response, grain movement on commitment creation, and transaction-specific X masquerading as persistent commitment acquisition.

## 13. Role identity / appointment / succession

Independently probe:

- one persistent role identity per H;
- vacancy at formation;
- valid nomination/appointment;
- exact unanimity predicates;
- self-nomination preserves nomination + nominee willingness + own participant acceptance;
- other participants accept separately;
- no self-response theatre;
- role/H/person identities remain distinct;
- succession preserves role identity;
- predecessor action cannot silently rebind to successor;
- participant exit can create vacancy only through accepted semantics.

### Snapshot-bound cohort

Construct same-cycle participant-entry / succession interactions.

Verify:

- cohort captured from the common committed decision snapshot;
- later entrant does not retroactively enter cohort;
- captured members still live-revalidate;
- later entry does not passively create head Recognition.

## 14. Head Recognition / subjective authority information

Verify actor-held head-role Recognition remains distinct from objective occupancy.

Probe:

- direct transition participant evidence;
- outsider Unknown/stale;
- accepted communication correction;
- incomparable/incompatible evidence -> Contested where required;
- no passive objective-state sync;
- no ID/arrival-order winner;
- action availability changes causally with actor-held Recognition;
- head/H/role facts are not inferred from unrelated attitude/wealth/resource state.

## 15. Dual-mode agency / initiative accounting

Independently prove:

- person P retains exactly one ordinary personal initiative;
- valid Active H through P has one separate Household initiative;
- both use the same committed decision snapshot;
- candidate/scoring spaces remain context-specific;
- accepted response contexts consume no personal initiative;
- vacant or Inactive H exposes no Household initiative;
- Household authority cannot command arbitrary personal action;
- alias cases do not manufacture extra personal response/initiative.

Challenge same-person multi-capacity cases aggressively.

## 16. Provision acquisition / reconsideration

### Ordinary acquisition

Verify:

- valid head request;
- target current sustaining participant;
- separate voluntary response;
- live authority/status revalidation;
- commitment creation grain-neutral;
- correct endogenous provenance.

### Head self-commitment

Verify:

- explicit institutional predicate;
- explicit private-resource authorization;
- office occupancy alone insufficient;
- no P→P response context;
- no extra personal initiative;
- ordinary cooldown/termination/provenance rules retained.

### DEC-0014 reconsideration

Independently exercise the exact historical-context rule.

Required cases:

1. refusal + <3 cycles + qualifying need -> still ineligible;
2. refusal + 3 cycles + no relevant change -> ineligible;
3. refusal + valid unfunded positive-dowry need after refusal + N+4 re-ask -> eligible even if need ended;
4. later refusal resets baseline; old need cannot unlock another later re-ask;
5. eligible support-need onset after refusal -> qualifying context change;
6. support need already continuously present at refusal -> not new solely from time;
7. need clears and later eligible need re-enters -> new occurrence;
8. ProposalId/replay/container retry alone -> not semantic newness.

Challenge mutants 53–56 independently; do not merely accept their script output.

## 17. Grounded material effects / one authoritative funding result

High-priority review.

Verify one authoritative live funding evaluation controls:

- feasibility;
- contributor participation;
- exact debit vector;
- dependency declaration;
- commit/history provenance.

Dependency discovery must consume the authoritative/evaluated participation result or declared equivalent and must not implement a second allocator.

Verify no Household treasury/pool exists.

### Fixed-rank commitment allocation

Challenge:

- exposed capacity computation;
- NeedsGrain zero capacity;
- reserve protection;
- descending capacity ranking;
- stable semantic PersonId only for exact ties;
- ranking fixed for transaction;
- no rerank during debit;
- insufficient total capacity -> no partial commit;
- checked arithmetic / overflow atomicity.

## 18. DEC-0011 exact private-X semantics

Exercise:

- absent X;
- valid partial X;
- shortfall supplement;
- full-private X=C;
- invalid zero/negative/nonintegral/over-cost term;
- protected reserve / NeedsGrain;
- same head also has commitment;
- head commitment capacity reduced after accounting for X;
- exact R=C-X;
- no double-counting;
- plan revalidation at commit;
- no silent X shrink/increase;
- no automatic funding rebalance;
- no successor substitution/rebinding;
- no extra initiative/self-response;
- no Gift/Help/Loan/favour/ordinary-transfer side meaning;
- no formation/continuity/lineage evidence;
- distinct funding provenance survives aggregate material delta.

The head's optional private capacity must not become standing `MobilizableCapacity(H)`.

## 19. Support and mediated marriage

### Support

Verify:

- Active H + valid head;
- current needy sustaining participant;
- Recognition conditions;
- 1-grain exact effect;
- head may be recipient;
- head-recipient uses proactive topology;
- no P→P support request/response;
- NeedsGrain clears only through accepted ordinary effect;
- no contributor below reserve.

### Mediated marriage

Verify:

- all route Recognition/eligibility conditions;
- positive dowry;
- exact Household funding;
- marriage effect;
- exactly accepted groom→mediating-head favour;
- female-head self-mediation companion;
- groom==head invalid where specified;
- mutual-strong-like bypass does not produce dowry/favour side effects;
- Unable/funding failure remains atomic.

## 20. Bounded priority / same-cycle interactions

Verify DEC-0013 bounded material ordering:

> eligible NeedsGrain Household support > other valid Household provision expenditure > RepayDebt

This is not a generic moral/economic hierarchy.

Challenge shared-grain conflicts involving:

- support vs RepayDebt;
- dowry vs RepayDebt;
- called-favour repayment composition/due-cycle behavior;
- head private-X plus debt/commitment use;
- multiple Households competing over contributor grain.

No debt reservation or technical order may silently preempt accepted Household priority.

## 21. DEC-0010 authority-use-before-destruction

Independently construct valid last-act races.

Confirm:

- otherwise-valid accepted old-head action can resolve before accepted authority-destroying transition where DEC-0010 requires;
- action must be valid at its own snapshot/accepted predicates;
- unrelated preconditions still revalidate;
- old action never rebinds to successor;
- invalid-at-snapshot action is not revived;
- technical proposal IDs/container order do not become authority priority.

Include Household Active→Inactive/Dissolved interactions where relevant.

## 22. Inactive H / self-nomination / head-as-recipient alias cases

Independently challenge DEC-0013 D3–D6:

- current head may be support recipient;
- current head may self-commit under dual-capacity consent;
- self-nomination allowed with all aliased predicates retained;
- sole sustaining participant in Inactive H may fill vacant persistent role;
- role fill does not reactivate H;
- occupied Inactive role grants no Household initiative;
- role survives later accepted reactivation.

## 23. ResolutionDependencies / central resolver

Inspect for duplicated semantic policy.

Verify dependency grouping captures all prospective shared resources/authority needed for correct conflict grouping, including:

- P personal + H-through-P proposals;
- multiple Household carriers;
- contributor grain;
- role transition/occupancy;
- participation/lifecycle changes;
- response contexts;
- debt/favour interactions;
- epistemic changes where commit-time Recognition matters.

Challenge disconnected/permuted/isomorphic cases.

Technical ordering/fallback must not create hidden social priority.

## 24. Detached replay / projection / determinism

Verify all future-influencing Slice-4 authority is represented in detached semantic projection where required:

- role identity/occupancy;
- transitions;
- refusal baselines / material-need provenance;
- commitments;
- funding/material effects;
- head-role evidence/Recognition;
- relevant exact provenance.

Challenge:

- raw allocation identities;
- proposal enumeration;
- PersonId renaming where nonsemantic;
- disconnected world additions;
- replay allocation order;
- duplicated closure causes.

Detached exploration must not mutate live identity counters.

## 25. Fixture / producer audit

Audit exact fixture writes.

Reject candidate evidence if it:

- fixture-writes final role occupancy when occupancy is under test;
- fixture-writes endogenous commitment acquisition when acquisition is under test;
- fixture-writes final funding plan/debit result;
- fixture-writes final head Recognition where derivation is under test;
- uses coder assertion-target helper as both producer and oracle.

Controlled historical Slice-3 commitment fixtures remain allowed only under their frozen narrow boundary and must remain explicitly fixture-originated.

## 26. Oracle independence

Inspect `Slice4Oracle` and related checkers.

They may share stable IDs/schema/history and simple arithmetic but must not call production:

- role classifier/eligibility;
- candidate generator/selector;
- funding evaluator under test;
- allocation helper under test;
- dependency policy under test;
- transition helper whose output is the assertion target.

Submit detached corruptions to the **actual** checker.

Require valid controls and specific rejection for:

- wrong role/authority;
- wrong consent cohort;
- wrong EvidenceId/provenance;
- wrong cost/X/R;
- wrong contributor/debit/rank;
- omitted participant/source;
- fabricated Household material event;
- provenance cross-label;
- false retry-based material need.

## 27. Mutation / negative-proof audit

Do not award adequacy merely because a patch fails to compile.

Verify relevant mutants:

- compile;
- execute real kernel;
- fail semantically for the intended reason.

High priority:

- approved adaptation B critical-seam hidden/stale-authority mutant;
- DEC-0011 mutants 36–42;
- DEC-0013 mutants 43–52;
- DEC-0014 mutants 53–56.

Classify detected/survived/unexercised/invalid-equivalent/crash/timeout truthfully.

Any survived material mutant is a BLOCK unless independently shown equivalent/invalid.

## 28. Reviewer-owned scratch probes

Create probes outside the candidate against public/test-access boundaries.

At minimum independently probe these categories:

1. formation creates vacant role but no occupant/initiative;
2. appointment unanimity and one missing acceptance;
3. same-snapshot newcomer does not join captured succession cohort;
4. self-nomination preserves all aliased predicates;
5. Inactive sole bearer may fill role without reactivation/initiative;
6. outsider head Recognition remains Unknown/stale absent route;
7. Contested head Recognition blocks authority-dependent route;
8. personal initiative and Household initiative coexist without double personal initiative;
9. ordinary endogenous provision refusal/acceptance provenance;
10. head self-commitment without fake response;
11. refusal cooldown + DEC-0014 exact N/N+1/N+4 case;
12. later-refusal reset;
13. support need already present vs newly appearing/reappearing;
14. fixed-rank multi-contributor funding;
15. same-head X + commitment no-double-count;
16. invalidated X plan does not silently rebalance;
17. support to current head through proactive topology;
18. mediated marriage + exact dowry + favour;
19. support/dowry versus RepayDebt conflict;
20. old-head valid last act before succession/vacancy;
21. action does not rebind to successor;
22. same person in multiple capacities does not collapse predicates;
23. multi-Household contributor conflict grouped correctly;
24. dependency grouping changes when declared funding participation changes;
25. hidden/stale critical-seam authority mutant detected;
26. arbitrary Household material event rejected;
27. commitment provenance cross-label rejected;
28. isomorphic renaming / enumeration invariance;
29. detached replay reproduces role/funding/reconsideration semantics;
30. no treasury/general ledger/generic economy state introduced.

Document setup, assertion counts and failures.

Do not commit reviewer probes to the candidate.

## 29. Scope / deferred-boundary audit

BLOCK if candidate silently implements or depends on:

- Slice-5 checkpoint/save-load continuation;
- general actor departure;
- general CandidateOrganization convergence;
- arbitrary participant private supplementation;
- reimbursement/prestige/political leverage from X;
- generic split-tender/payment framework;
- pooled Household treasury;
- mature assets/property/production/inheritance/tax/accounting economy;
- trust/rumor/reputation;
- general nonparticipant perception;
- general contested succession/rival claimants/usurpation;
- generic resignation while remaining participant;
- strategic/multi-step planning redesign;
- stochastic policy redesign;
- parallel/distributed execution;
- event-sourced current authority.

## 30. Exact-head CI / evidence audit

Verify:

- run **36094176584** belongs to exact candidate SHA;
- workflow conclusion is success;
- checkout used exact `bac53de...`;
- canonical restore/format/build/test steps all succeeded;
- reported test summary is **67 succeeded / 0 failed / 0 skipped**;
- artifact **10846019591** exists and is unexpired;
- artifact digest is exactly:
  `sha256:22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6`;
- artifact records exact implementation head and clean tracked tree;
- artifact contains the expected Slice-4 and inherited evidence surfaces.

CI/artifact success corroborates review but does not replace it.

## 31. Prior/coder claims — only after provisional judgment

After fixing your own provisional verdict, inspect:

- `research/technical/IMP-0004/IMP-0004_CANDIDATE_IMPLEMENTATION_REPORT.md`;
- `research/technical/IMP-0004/IMP-0004_ADAPTATION_LEDGER.md`;
- escalation/closure history;
- PR #109 prose;
- CI-generated PASS/evidence tables.

Use only for corroboration/discrepancy.

## 32. Verdicts

Return exactly one:

### PASS — PROMOTE

No material semantic, architectural, acceptance-coverage, adaptation-losslessness, fixture, oracle, inherited-regression, determinism, scope, or evidence defect established.

Recommendation: **PROMOTE exact candidate**.

### BLOCK — IMPLEMENTATION / VERIFICATION DEFECT

Accepted authority is sufficient, but implementation/evidence is defective or incomplete.

Identify the smallest concrete repair scope.

### BLOCK — SEMANTIC ESCALATION

Candidate cannot conform without a genuinely missing consequential semantic/architectural decision.

Identify exact missing decision. Do not invent it.

## 33. Required return

Create branch:

`review/imp-0004-conformance-v1-independent-return`

from exact candidate:

`bac53decaafb5edf4c5879be0f695f6a52ccc1ce`

Add **only**:

`research/technical/IMP-0004/IMP-0004_INDEPENDENT_CONFORMANCE_REVIEW_V1.md`

The report must include:

- exact candidate ref/SHA;
- exact frozen authority/adaptation identities;
- independence/provenance disclosure;
- canonical command results;
- 165-row Slice-4 REQUIRED audit summary;
- 9 DEFERRED / 2 UNEXERCISED audit;
- 270 inherited REQUIRED audit;
- adaptation A–D losslessness findings;
- role/succession findings;
- head Recognition findings;
- dual-mode agency findings;
- provision/reconsideration findings;
- DEC-0011/0013/0014 findings;
- funding/dependency/resolution findings;
- fixture/producer findings;
- oracle-independence findings;
- mutation findings;
- reviewer-owned scratch-probe summary;
- scope leakage finding;
- exact-head CI/artifact identity verification;
- semantic-escalation status;
- final verdict;
- explicit **PROMOTE / DO NOT PROMOTE** recommendation.

Do not modify or move the candidate.
