# Pre-Rule Semantic Compression Audit — 2026-09-21

**Status:** COMPLETE REVIEW RECORD  
**Authority:** Audit evidence only; it records repairs to already-approved material and does not create new simulation semantics.

## Purpose

Review the small set of repository artifacts a current/future AI is actually instructed to retrieve, looking specifically for operative decisions/constraints that were lost when richer working/proposal material was compressed before the project's semantic-preservation rule was established.

This is a damage-minimization audit, not a claim that every historical chat/research return was exhaustively reconstructed.

## Scope reviewed

### Root retrieval / governance

- `AGENTS.md`
- `00_START_HERE.md`
- `plans/CURRENT_PHASE.md`
- `governance/WORKING_CONSTITUTION.md`
- `governance/MASTER_ARCHITECT_GUIDE.md`
- `governance/AUTHORITY_AND_DECISION_PROMOTION.md`
- `governance/REVIEW_AND_DRIFT_AUDIT.md`
- `decisions/DECISION_REGISTER.md`
- `registers/OPEN_ISSUES_REGISTER.md`
- `registers/ASSUMPTIONS_REGISTER.md`
- `plans/FIRST_PROTOTYPE_DEVELOPMENT_ROADMAP.md`

### Foundational / accepted architecture

- `DEC-0001`
- `DEC-0002`
- `ADR-0001` through `ADR-0005`
- `DEC-0007` / `DEC-0008`
- relevant archived proposals and technical research used to check whether a compact accepted record had dropped a binding qualifier

### SFL v0

- accepted `SPEC-SFL-0001`
- closed `specifications/working/SFL_V0_WORKING_SPEC.md`
- resolved Stage-3 errata/reconciliation records
- active Stage-3 verification workbench/cards

## Findings and repairs

### A. Retrieval/navigation drift — repaired

**Problem:** `00_START_HERE.md` still described TRES-0002 Stage II and old household/architecture-selection WIPs as current. `CURRENT_PHASE.md` did not reflect later adversarial reviews or completed scenario families.

**Risk:** a fresh agent could retrieve obsolete working material instead of accepted SFL semantics and current verification work.

**Repair:**

- refreshed `00_START_HERE.md` to Stage 3;
- made `SPEC-SFL-0001`, assumptions, verification workbench/cards, and future C# engineering guardrails directly discoverable;
- refreshed `CURRENT_PHASE.md`;
- made `MASTER_ARCHITECT_GUIDE.md` an explicit root-read when the agent is acting as Master Architect.

### B. Stale open questions — repaired

`OQ-0002` household identity/continuity and `OQ-0003` subjective recognition remained marked OPEN after SFL v0 had resolved them.

**Repair:** both are now RESOLVED with links to `SPEC-SFL-0001` and relevant verification artifacts.

### C. Foundational DEC-0001 compression loss — repaired

The approved proposal contained a future-facing constraint that did not survive into the compact accepted decision:

> social position is multidimensional; one scalar status hierarchy must not silently replace distinguishable kinship, dependency, labor/service, property/claim, institutional affiliation, residence, etc.

**Repair:** restored as an explicit DEC-0001 consequence.

### D. ADR-0001 identity compression loss — repaired

The source research/decision intent required stable semantic identity not to be derived from mutable content/runtime allocation.

**Repair:** ADR-0001 now explicitly forbids deriving semantic identity from names, current participants/holders, addresses, or runtime allocation/container position.

### E. SFL Pass A/B compression losses — repaired

Restored already-approved/converged rules that were present in the closed working record but absent or under-specified in the accepted compression:

- no semantic fixed actor count;
- declared scenario-harness authority for bounded lower-level/exogenous inputs;
- fixture may not directly write endogenous household/warrant/role results;
- cross-household relations/actions remain possible;
- no household=dwelling/kinship/marriage/co-residence/graph-cluster shortcut;
- no hidden primitive membership ground truth;
- attitude is not generic relationship strength;
- kinship multiplier affects scoring only and cannot satisfy stored-attitude categorical gates;
- completed debt remains historical after satisfaction;
- favours are not tradable/inheritable/partial/generic social currency;
- marriage never auto-moves residence;
- reference v0 policy chooses the highest-scoring generated candidate with semantic deterministic tie-break;
- reference actor policy remains replaceable/separable from social/world semantics.

### F. SFL Pass C compression losses — repaired

Restored:

- evidence-backed meanings of Unknown / Recognized / Contested;
- recognition provenance rather than scalar confidence;
- communication initiative cost;
- communication may transmit only a proposition the sender holds;
- underlying event order outranks message-arrival order;
- newer event-backed evidence can supersede older evidence;
- unresolved incompatible evidence becomes Contested;
- general household/role recognition gating for household-specific actions;
- outsider non-omniscience;
- mediated-marriage bride-to-household subjective route requirement;
- proposed-but-uncommitted world effects do not become objective facts.

### G. SFL Pass E compression losses — repaired

Restored:

- explicit head-role prohibitions: no seizure of personal grain, commanding residence/personal action, arbitrary relation creation, attitude mutation, or general sovereignty;
- collective action requires Active H + occupied valid head + in-scope authority + valid backing/capacity;
- head appointment/succession participants directly recognize the role result; outsiders require ordinary evidence;
- participant-request/head-proactive household support route;
- formation history distinguishes lower-level organization development from later household reification.

### H. SFL Pass F compression losses — repaired

Restored:

- commit-time revalidation against all action-relevant preconditions;
- automatic reactions must consume/change enabling state or become a no-op;
- repeated already-processed reaction cause is an engine/spec error;
- stable-cycle publication rule promoted to ADR-0004, preventing intermediate mutation order from masquerading as completed cycle state.

### I. C# engineering guardrails — retrieval repaired, authority intentionally unchanged

TRES-0002's C# adversarial review produced important implementation cautions (explicit ordering, simulation-owned randomness, versioned persistence, pinned toolchain/analyzers, numeric determinism, etc.).

These remain **engineering context**, not silently promoted architectural decisions.

**Repair:** the root map/current phase now points future Stage-4 agents to:

`architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`

ADR-0003/0004/0005 remain the binding architectural constraints.

## Reviewed with no additional material loss found

Within this audit's scope, no additional operative compression loss requiring repair was found in:

- current `MASTER_ARCHITECT_GUIDE.md` (after the previously approved lossless-promotion amendment);
- `WORKING_CONSTITUTION.md`;
- ADR-0002 Hierarchical Individual Agency;
- ADR-0003 Progressive Derived-State Specialization;
- ADR-0004 after the stable-cycle amendment;
- ADR-0005's accepted host/runtime choice itself;
- the approved first-prototype roadmap.

Research recommendations not explicitly promoted/approved were **not** converted into authority merely because they appeared useful.

## Deliberately not reconstructed/promoted

- raw historical/research debate not present in the active retrieval chain;
- advisory research recommendations that never became accepted decisions;
- obsolete working semantics superseded by later explicit Director decisions (for example the original no-due-date debt rule);
- implementation details that remain within engineering/implementation discretion.

## Residual uncertainty

This audit reduces risk; it cannot prove absence of every historical compression loss.

Remaining possible failure classes include:

- a decision that existed only in conversation and was never captured in any reviewed artifact;
- an operative nuance buried in advisory research that was intended but never explicitly approved;
- a future task retrieving a noncanonical/stale artifact outside the root navigation path.

The durable mitigation is now in place:

1. pre-compression operative inventory;
2. preserved/superseded/deferred/open-erratum reconciliation;
3. drift-audit check for semantic loss;
4. root retrieval paths that point at current authority.

## Result

The current AI-facing canonical path is materially safer and internally aligned enough to continue Stage 3.

Future compression audits should be targeted at promotion events or drift symptoms rather than repeatedly re-reading the entire historical corpus.
