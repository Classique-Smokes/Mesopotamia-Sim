# Implementation Task Packet — SFL v0 Reference Slice 1: Lower-Level Social Fabric Kernel

**Task ID:** IMP-0001  
**Commissioned by:** Master Architect  
**Status:** CANDIDATE-v1 BLOCKED / REPAIR-v2 ACTIVE  
**Dispatched:** 2026-09-22  
**Implementation branch:** `implementation/imp-0001-slice1`  
**Frozen failed candidate:** `imp-0001-slice1-conformance-candidate-v1` @ `7e11dab7697121eb0dbb169ba46210d81b80586e`  
**Active repair branch:** `implementation/imp-0001-slice1-repair-v2`  
**Repair packet:** `tasks/implementation/IMP-0001_BLOCK_REPAIR_PACKET.md`  
**Context mode:** PROJECT-CONTEXT

## Dispatch gate — released

TRES-0010 is closed with a PASS. The Project Director intentionally dispatched this task on 2026-09-22.

Closure evidence:

- `research/technical/TRES-0010/FINAL_CLOSURE_AUDIT_AND_DISPATCH_DECISION.md`
- frozen Slice-1 acceptance authority `SFL-V0-S1-ACCEPTANCE-v1`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`

SCF-001 fired and is implemented by the canonical root toolchain/CI scaffold. SCF-002 fired: the frozen external acceptance authority remains immutable, and executable/CI mapping to every REQUIRED AcceptanceId is now an active IMP-0001 completion obligation.

Any newly discovered conflict with accepted semantics/architecture still triggers the escalation rules in this packet; closure is not permission to improvise new project meaning.

## 1. Objective

Create the first runnable, deterministic C# 14 / .NET 10 LTS vertical slice of the Social Fabric Laboratory.

This slice must implement enough authoritative state, lower-level social relations, agency/response selection, proposal-resolution-commit mechanics, maintenance, and semantic history to execute the Stage-3 lower-level acceptance cards **without implementing household identity/recognition yet**.

The result must leave the repository with:

- a buildable/testable .NET solution;
- canonical root build/test/analyzer commands;
- CI executing those commands;
- a protected acceptance-test surface;
- a deterministic lower-level simulation slice that passes the in-scope canonical scenarios.

## 2. Required inputs by authority class

### Accepted simulation / architecture authority

- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `architecture/accepted/ADR-0005_HOST_RUNTIME.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

These artifacts define simulation/social meaning and architecture.

### Frozen Slice-1 verification / completion authority

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- manifest version: `SFL-V0-S1-ACCEPTANCE-v1`
- frozen ref: `sfl-v0-slice1-acceptance-v1`
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`
- frozen manifest SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- freeze record: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`

The frozen manifest defines **which accepted verification obligations count for IMP-0001 completion**. It does not create social semantics and is subordinate to the accepted simulation/architecture authority above.

Canonical verification sources referenced by the manifest include:

- `plans/verification/SFL_V0/README.md`
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`
- `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`

### Required non-authoritative supporting / engineering context

- `registers/ASSUMPTIONS_REGISTER.md`
- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- `AGENTS.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `research/technical/TRES-0010/CALLFAVOR_SLICE1_APPLICABILITY_RECONCILIATION.md`

Precedence is explicit: accepted semantic/architectural authority controls meaning; the frozen manifest controls Slice-1 completion applicability; assumptions/supporting/engineering context may constrain the laboratory or engineering approach but may not silently override either.

Implementation must retrieve and obey these artifacts rather than infer authority from conversation.

## 3. Scope

### 3.1 Repository / tooling foundation

Create the minimal .NET solution/project structure required for:

- production/reference-kernel code under `src/`;
- unit/mechanism tests;
- canonical SFL acceptance tests;
- deterministic test fixtures/harness;
- analyzers/nullable/static diagnostics appropriate to the accepted C# guardrails.

Establish exact root commands for:

- build;
- tests/acceptance;
- analyzer/static-quality verification.

Update `AGENTS.md` Command section to those exact commands before claiming completion.

Add CI that executes the same canonical commands.

### 3.2 Authoritative lower-level state

Implement typed stable identities/records sufficient for the in-scope semantics, including:

- Person;
- Dwelling / residence;
- directed Attitude;
- parent/child and sibling Kinship;
- Marriage;
- Debt;
- Favour;
- explicit semantic transfer/action records;
- future-influencing cycle/configuration state required by this slice.

Stable semantic identity must not derive from mutable names/content, current participants, collection positions, or runtime allocation handles.

### 3.3 Time / maintenance required by this slice

Implement deterministic integer `Cycle` plus `ReactionIndex` sufficient for:

- consumption;
- NeedsGrain;
- Farm;
- attitude decay cadence;
- debt social-due review;
- proposal/response/resolution/commit;
- automatic attitude/semantic reactions;
- stable cycle closure.

A full generic delayed-process/checkpoint system is **not** required in this slice, but any state introduced now that affects future cycles must be explicit/serializable in principle and compatible with ADR-0004.

### 3.4 Personal and response agency

Implement:

- one personal voluntary initiative per person/cycle;
- context-sensitive candidate generation/gates;
- exact named-integer component scoring;
- `FinalScore = sum(components)`;
- deterministic tie handling;
- the in-scope personal scoring profiles from `REFERENCE_SCORING_PROFILES.md`;
- `ResponseDecisionContext(target, proposal)`;
- response feasibility before voluntary scoring;
- in-scope response profiles;
- response decisions not consuming personal initiative;
- full personal/response decision traces.

### 3.5 In-scope action / relation transitions

Implement the lower-level meanings required by Slice 1:

- Farm;
- OfferGift / RequestGiftOrHelp;
- OfferLoan / RequestLoan / RepayDebt;
- OfferBenefitForFavor;
- relationship-mediated reciprocal help;
- CallFavor / fulfil / refuse / reciprocal cancellation;
  - current frozen Slice-1 CallFavor applicability is mechanically closed: only `Farm` and `RepayDebt(debt, amount)` are callable payload shapes;
  - do not expose response meanings, failure results, transfer/effect helpers, or other nonsemantic primitives as called-favour payloads;
- direct mutual-strong-like marriage route;
- residence move/invite proposal and response.

Implement response/attempt outcomes:

- Declined;
- Unable(reason);
- InvalidatedAtResolution(reason).

### 3.6 Proposal / resolution / commit

Implement a narrow central transition path satisfying ADR-0004:

- read committed snapshot;
- personal proposals;
- response decisions;
- priority/conflict resolution where relevant to this slice;
- immediate precommit revalidation;
- atomic commit/failure;
- automatic same-cycle semantic reactions to closure;
- stable-cycle publication.

Behavioral code must not directly mutate another actor's authoritative state.

### 3.7 Semantic history / observability

Retain the accepted Slice-1 history needed to explain:

- generated candidates and excluded gates;
- named score components/final scores;
- selected personal/response decisions;
- proposal terms and counterpart response;
- validation/conflict result;
- failure reason;
- committed material/relation effects;
- automatic attitude effects;
- Cycle/ReactionIndex;
- causal predecessor references;
- configuration/profile version;
- technical fallback marker.

## 4. Explicitly out of scope

Do not implement in IMP-0001:

- CandidateOrganization / household formation;
- Household / SustainingParticipant / participation warrants;
- household recognition or head recognition;
- household provision/head role/household-mode action;
- household lineage/division/consolidation;
- household-mediated marriage;
- general subjective communication/claim propagation beyond lower-level state needed for this slice;
- actor departure as an executable Slice-1 fixture/generated/runtime transition; use a fixed Slice-1 population unless a separately accepted departure rule is promoted later;
- checkpoint/save-load continuation;
- production database/storage architecture;
- parallelism/concurrency;
- stochastic behavior;
- demographics/reproduction/death;
- generic property/economy;
- generic commitment/breach subsystem;
- optimization beyond obvious local engineering hygiene;
- broad frameworks/dependencies not required by the slice.

Do not implement a primitive hidden household-membership container "for later convenience."

## 5. Required invariants

At minimum, mechanically enforce applicable cross-cutting Slice-1 invariants:

- stable/resolvable IDs/references;
- attitude within [-100,+100];
- grain never negative;
- every grain change has explicit source/sink/zero-sum transfer;
- NeedsGrain actor cannot Farm;
- kinship scoring never mutates/satisfies stored-attitude gates;
- at most one established v0 marriage per person;
- parent/child and siblings never marry;
- at most one outstanding favour per ordered pair;
- completed debt retains historical provenance;
- one cause key cannot apply the same automatic transition twice;
- ReactionIndex monotone within cycle;
- no proposed-but-uncommitted effect becomes objective state;
- one personal initiative maximum per actor/cycle;
- response decisions do not consume/grant personal initiative;
- stable-ID fallback is logged when exercised;
- nonsemantic collection iteration order is never semantic order;
- every grain-denominated Slice-1 semantic ingress obeys the accepted positive-integer term domain before target response;
- same-cycle direct attitude causes compose by net signed delta followed by one clamp, independent of member-cause enumeration;
- at most one Residence transition per person commits in one cycle;
- called favour is consumed only on successful requested-action commit;
- ExplicitBenefitForFavor material benefit + new favour commit atomically; failed explicit bargains do not degrade into Gift/Help;
- the accepted 2-grain lower-level reserve is RepayDebt-specific; do not apply a generic two-grain reserve to ordinary interpersonal transfers.

## 6. Acceptance criteria

### Tooling / repository

- solution builds from repository root with the documented canonical command;
- all tests execute from repository root with the documented canonical command;
- analyzer/static-quality command is documented and passes;
- CI runs the same commands;
- nullable analysis is enabled;
- warnings/analyzer policy is strict enough that accepted CI failures are not silently ignored;
- `AGENTS.md` contains the actual canonical commands rather than the bootstrap placeholder.

### Frozen manifest coverage

Executable acceptance evidence must cover **every row marked REQUIRED** in `SFL-V0-S1-ACCEPTANCE-v1`.

- no REQUIRED AcceptanceId may be omitted, skipped, or silently reclassified;
- DEFERRED, N-A, and UNEXERCISED rows remain separately visible with the frozen manifest rationale;
- `VS-SFL-104` is explicitly DEFERRED because household/head/mediated-marriage substrate is outside Slice 1;
- communication-specific `S1-098-COMMUNICATION` is explicitly DEFERRED;
- household/provision/formation/lineage/checkpoint/rendered-explanation rows remain deferred exactly where the manifest says so;
- one executable parameterized/table-driven test may satisfy multiple IDs only when completion reporting still exposes every required AcceptanceId separately.

Do not replace the manifest with open-ended ranges such as “090–105” or self-selected “applicable/relevant” subsets.

Cards that explicitly require later-slice semantics remain unimplemented and must not be faked.

### Determinism / ordering

- repeated identical runs produce identical authoritative semantic results/history for this slice;
- nonsemantic storage/input permutation does not change results;
- stable-ID sensitivity appears only in explicit fallback cases and is marked;
- observer/trace collection does not alter outcomes.

### Fixture discipline

- acceptance fixtures declare their write-set;
- fixtures do not write transition results they are intended to test;
- mechanism-isolation tests enter through the public proposal/response/resolution boundary.

### Protected acceptance surface

Create the executable Slice-1 acceptance-test/harness surface as a translation of the **already frozen** manifest.

- IMP-0001 may choose test framework, helper APIs, project layout, and executable test names;
- IMP-0001 may map executable evidence to AcceptanceIds;
- IMP-0001 may **not** edit, weaken, delete, reclassify, or replace `SFL-V0-S1-ACCEPTANCE-v1`;
- changes to frozen acceptance authority require separately scoped verification/authority work and a new manifest version/ref;
- CI must run the executable acceptance surface and emit the required manifest-indexed result report.

The implementation task is not the sole author/editor of its own completion standard.

## 7. Verification expectations

Completion evidence must include:

- exact root commands run;
- build/test/analyzer results;
- manifest version `SFL-V0-S1-ACCEPTANCE-v1`, freeze commit, and frozen manifest SHA;
- a complete per-AcceptanceId result table for all REQUIRED rows with zero missing/skipped REQUIRED IDs;
- a separately visible status list for DEFERRED / N-A / UNEXERCISED rows;
- invariant-check results;
- deterministic repeated-run evidence required by the manifest;
- required nonsemantic iteration-order / stable-ID-fallback / observer-noninterference metamorphic evidence;
- acceptance fixture write-set audit result;
- oracle-independence/dependency audit proving assertion-target production helpers were not reused as independent oracles;
- required semantic mutant/fault-control classifications, with crash/timeout not automatically credited as semantic detection;
- any structural-evidence result used instead of executable mutation/rebuild coverage where the frozen manifest explicitly permits it;
- **fresh independent post-implementation conformance-review PASS** against the frozen manifest.

Do not claim full SFL completion; this is Slice 1 only.

## 8. Local decisions permitted

The implementation agent may choose, without escalation:

- solution/project names and namespace layout;
- test framework;
- ordinary C# record/class/struct choices inside ADR-0001 semantics;
- internal index/cache data structures;
- serialization representation for test fixtures/config only;
- file/module boundaries;
- exact analyzer package/configuration where compatible with guardrails;
- CI workflow syntax;
- deterministic semantic ID concrete type;
- internal proposal/transition implementation structure;
- test helper APIs.

These local choices may not edit/reclassify the frozen manifest, bypass a frozen REQUIRED AcceptanceId, or move an expected semantic result into the same production helper/classifier/validator used as the independent oracle.

Prefer standard library / SDK facilities and minimal dependencies.

Any local choice that starts changing accepted semantics, persistence authority, execution/concurrency model, or public architectural boundaries requires escalation.

## 9. Escalation conditions

Stop and report rather than silently changing project architecture if implementation appears to require material changes to:

- core simulation semantics;
- entity identity or persistent representation;
- subsystem boundaries or ownership;
- major dependencies or frameworks;
- persistent schemas or compatibility;
- abstraction fidelity;
- global state or cross-system coupling;
- concurrency or execution model;
- accepted public interfaces;
- architectural invariants;
- significant performance strategy;
- any accepted requirement or higher-authority project principle.

Also escalate when:

- a canonical scenario cannot be made executable without adding social semantics;
- two accepted artifacts appear to conflict;
- a response/action transition is underspecified;
- the deterministic history/checkpoint future path would be made impossible by the chosen representation;
- a test would need to be weakened rather than the implementation corrected;
- a REQUIRED manifest row cannot be translated into executable/structural evidence without adding or choosing social semantics;
- a cited expected result appears unsupported by accepted semantic authority;
- implementation would require changing/reclassifying the frozen acceptance manifest;
- production and independent-oracle logic cannot be separated for a REQUIRED assertion target.

## 10. Work-state discipline

Work in recoverable increments.

Suggested internal milestones:

1. solution/tooling/CI + typed IDs/state;
2. material maintenance + Farm/NeedsGrain;
3. proposal/response/commit skeleton + semantic history;
4. gift/help/loan/debt;
5. favour;
6. direct marriage/residence;
7. scorer/response profiles;
8. cross-cutting deterministic/mutation/fixture checks;
9. complete frozen-manifest AcceptanceId coverage report;
10. independent post-implementation conformance review.

If multiple agents mutate files concurrently, use isolated branches/worktrees/workspaces and reconcile explicitly before integration.

Any delegated child task remains within IMP-0001 authority/scope.

## 11. Required completion report

Return:

- terminal status: VERIFIED COMPLETE / BLOCKED / ESCALATED / INCOMPLETE;
- files/projects added or changed;
- exact canonical root commands;
- frozen manifest version / freeze commit / final manifest SHA;
- complete REQUIRED AcceptanceId result summary with zero missing/skipped rows for VERIFIED COMPLETE;
- separate DEFERRED / N-A / UNEXERCISED status summary;
- invariant / metamorphic / mutant-fault-control evidence;
- oracle-independence audit;
- fixture write-set audit;
- independent post-implementation conformance-review reference and result;
- assumptions encountered;
- architectural conflict/escalation, if any;
- deviations;
- new unresolved issues;
- follow-up work that is genuinely required for Slice 2.

A completion claim without the frozen-manifest evidence and independent conformance PASS is not accepted.
