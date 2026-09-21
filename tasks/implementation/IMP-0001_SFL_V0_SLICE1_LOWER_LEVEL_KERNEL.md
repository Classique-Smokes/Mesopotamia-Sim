# Implementation Task Packet — SFL v0 Reference Slice 1: Lower-Level Social Fabric Kernel

**Task ID:** IMP-0001  
**Commissioned by:** Master Architect  
**Status:** PREPARED / DISPATCH BLOCKED PENDING TRES-0010  
**Context mode:** PROJECT-CONTEXT

## Pre-dispatch gate

Do not dispatch this implementation task until the Master Architect closes `TRES-0010 — Pre-Implementation Architecture / Semantics / Verification Red Team` and records that no unresolved blocker remains.

Commission pack:

- `tasks/research/TRES-0010_PRE_IMPLEMENTATION_RED_TEAM/00_PROGRAM_README.md`

TRES-0010 findings may amend this packet or higher-authority artifacts before implementation begins.

## 1. Objective

Create the first runnable, deterministic C# 14 / .NET 10 LTS vertical slice of the Social Fabric Laboratory.

This slice must implement enough authoritative state, lower-level social relations, agency/response selection, proposal-resolution-commit mechanics, maintenance, and semantic history to execute the Stage-3 lower-level acceptance cards **without implementing household identity/recognition yet**.

The result must leave the repository with:

- a buildable/testable .NET solution;
- canonical root build/test/analyzer commands;
- CI executing those commands;
- a protected acceptance-test surface;
- a deterministic lower-level simulation slice that passes the in-scope canonical scenarios.

## 2. Authoritative inputs

### Accepted simulation / architecture authority

- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `architecture/accepted/ADR-0005_HOST_RUNTIME.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `registers/ASSUMPTIONS_REGISTER.md`

### Canonical verification requirements for this slice

- `plans/verification/SFL_V0/README.md`
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`
- relevant non-household cases in `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`
- relevant determinism/fallback/trace requirements in `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`

### Required engineering context

- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`
- `AGENTS.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`

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
- nonsemantic collection iteration order is never semantic order.

## 6. Acceptance criteria

### Tooling / repository

- solution builds from repository root with the documented canonical command;
- all tests execute from repository root with the documented canonical command;
- analyzer/static-quality command is documented and passes;
- CI runs the same commands;
- nullable analysis is enabled;
- warnings/analyzer policy is strict enough that accepted CI failures are not silently ignored;
- `AGENTS.md` contains the actual canonical commands rather than the bootstrap placeholder.

### Canonical scenario coverage

Executable acceptance coverage exists for, at minimum:

- `VS-SFL-090` through `VS-SFL-099`;
- `VS-SFL-100` through `VS-SFL-105`;
- `VS-SFL-070`, `071`, `073`, `074` where their required substrate is available;
- applicable boundary/metamorphic/mutant checks from `CROSS_CUTTING_VERIFICATION_CONTRACT.md`.

Cards that explicitly require household semantics remain unimplemented and must not be faked.

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

Create a clearly separated canonical acceptance-test surface for SFL scenario IDs.

Once established:

- implementation tasks may not weaken/delete/rewrite expected semantics merely to pass;
- changes to canonical acceptance expectations require explicit specification/verification scope;
- CI must run the acceptance surface.

If a stronger repository protection mechanism is available without requiring disproportionate administration, use it; otherwise enforce the boundary through repository instructions, task scope, test separation, and CI.

## 7. Verification expectations

Completion evidence must include:

- exact root commands run;
- build/test/analyzer results;
- list of implemented scenario IDs;
- invariant-check results;
- deterministic repeated-run evidence;
- at least one nonsemantic iteration-order permutation check;
- at least one stable-ID fallback sensitivity check;
- acceptance fixture write-set audit result;
- no-surviving relevant semantic mutant where the slice claims coverage;
- explanation of any deliberately deferred canonical card because it belongs to later slices.

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
- a test would need to be weakened rather than the implementation corrected.

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
9. final slice acceptance run.

If multiple agents mutate files concurrently, use isolated branches/worktrees/workspaces and reconcile explicitly before integration.

Any delegated child task remains within IMP-0001 authority/scope.

## 11. Required completion report

Return:

- terminal status: VERIFIED COMPLETE / BLOCKED / ESCALATED / INCOMPLETE;
- files/projects added or changed;
- exact canonical root commands;
- scenario IDs implemented and results;
- invariant/metamorphic/mutant evidence;
- assumptions encountered;
- architectural conflict/escalation, if any;
- deviations;
- new unresolved issues;
- follow-up work that is genuinely required for Slice 2.

A completion claim without executable verification evidence is not accepted.
