# SFL v0 Slice 5 — Authority Boundary and Gap Inventory

**Status:** SOURCE-GROUNDED DISCOVERY RETURN / ADVISORY ONLY  
**Task:** `tasks/research/SFL_V0_SLICE5_DISCOVERY_A_AUTHORITY_GAPS.md`  
**Return branch:** `research/slice5-authority-gap-return`  
**Canonical semantic base SHA used:** `26277ed211baaaa9a1dcfaebf98c4fd00a9b4181`  
**Authority boundary:** This report does not create, promote, or modify simulation semantics, acceptance authority, or implementation authority.

> The commissioned return branch was pre-created after the dispatch material was added. Its merge-base with the requested canonical semantic baseline is the exact SHA above. All task-required semantic/verification authority inspected for this analysis was read at that exact baseline; the accepted SPEC/ADRs/decisions, frozen manifests/freeze records, completion records, assumptions, deferred-gap ledger, and canonical verification contracts checked for this task are content-identical to their current copies. Post-base navigation/dispatch edits are not treated as semantic authority.

## 1. Executive conclusion

Slice 5 is semantically bounded tightly enough to proceed to acceptance planning.

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

The controlling accepted rules already determine the important continuation semantics:

- a safe checkpoint exists **only at a stable cycle boundary after resolution and automatic reaction closure**;
- all immediate proposals and response-driven interactions terminate in the same cycle, so no same-cycle proposal/response/resolution transient is allowed to survive as pending work at a safe boundary;
- every future-influencing authoritative fact must survive interruption, including subjective state, Household/role/provision state, temporal baselines, pending future inputs/work, semantic identity/order state, and rule/configuration identity;
- delayed or interruptible work, when the accepted model actually has such work, must be represented by serializable semantic process state with deterministic ordering and condition revalidation;
- the current accepted SFL v0 domain does **not** require a new universal delayed-process/workflow abstraction: its actual future-timed causal obligations can remain bounded typed state and scheduled input;
- under identical future inputs and identical configuration/rules, restore must reproduce the subsequent authoritative semantic state and consequential history suffix **exactly**, including identity/order-sensitive outcomes;
- rebuildable indexes, caches, summaries, and projections are non-authoritative and must remain replaceable by reconstruction from authoritative state;
- migration across rule/configuration versions, generic persistence infrastructure, event-sourced authority, rollback/time travel, concurrent snapshots, branchable histories, and a mature workflow engine are not part of bounded Slice 5.

The strongest current delayed/future-timed semantic cases are:

1. debt social-due review at the third subsequent full cycle, with one-time consequence;
2. provision-reconsideration refusal/cooldown/context baselines, including DEC-0014's historical post-refusal material-need occurrence;
3. scheduled exogenous input, explicitly including future exogenous grain used by the MaterialDeadlock rule;
4. ordinary recurring cycle maintenance whose timing follows `Cycle` plus accepted rules/configuration rather than requiring a separately authoritative work item;
5. any accepted delayed/interruptible work that is actually introduced within the already-authorized SFL v0 semantic envelope, which must obey ADR-0004's serializable-state / deterministic-order / revalidation contract rather than gaining invented domain meaning.

No accepted Household/role transition currently remains delayed across stable boundaries. Appointment, succession, participation, resource conflicts, authority-use-before-destruction, and their automatic reactions are same-cycle resolution/closure semantics.

The principal fired deferred verification item is TRES-0010 `VH-04`: checkpoint omission mutants now require a continuation suffix that causally exercises the omitted state. The prior frozen manifests also deliberately defer checkpoint/restore coverage to Slice 5. Those are acceptance-planning obligations, not semantic gaps.

**Recommendation: READY FOR ACCEPTANCE PLANNING.**

## 2. Source corpus retrieved

This analysis used the exact canonical semantic base SHA above and independently retrieved the task-required corpus.

### Root / phase orientation

- `AGENTS.md`;
- `00_START_HERE.md` at the canonical baseline;
- `plans/CURRENT_PHASE.md` at the canonical baseline.

The post-base versions of the two navigation files contain later dispatch/navigation updates; they were not used to revise the baseline semantic reading.

### Accepted semantic and architectural authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- all accepted ADRs:
  - `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`;
  - `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`;
  - `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`;
  - `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`;
  - `architecture/accepted/ADR-0005_HOST_RUNTIME.md`;
- accepted decisions current at the base, including:
  - `DEC-0001` through `DEC-0009` as applicable;
  - `DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md`;
  - `DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`;
  - `DEC-0012_SEMANTIC_INTERACTION_DELTA_FAILSAFE.md`;
  - `DEC-0013_SLICE4_SID_CLOSURE_AND_V0_RESOURCE_SCAFFOLD_BOUNDARIES.md`;
  - `DEC-0014_HISTORICAL_MATERIAL_NEED_RECONSIDERATION_CONTEXT.md`;
- `decisions/DECISION_REGISTER.md`.

### Canonical planning / verification contracts

- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
- `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`;
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`.

### Frozen inherited acceptance authority

- Slice 1 manifest + freeze record;
- Slice 2 manifest + freeze record;
- Slice 3 manifest + freeze record;
- frozen Slice-4 v1 manifest + freeze record;
- frozen successor Slice-4 v2 manifest + freeze record.

The frozen v2 Slice-4 manifest is current completion authority; frozen v1 remains immutable historical acceptance evidence.

### Verified completion records

- `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`;
- `research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`;
- `research/technical/IMP-0003/IMP-0003_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`;
- `research/technical/IMP-0004/IMP-0004_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`.

### Durable deferred / assumption records

- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`;
- `registers/ASSUMPTIONS_REGISTER.md`;
- `registers/OPEN_ISSUES_REGISTER.md` as a supplemental check for any separately recorded Slice-5 semantic question. It points back to the deferred-gap ledger and does not add a distinct checkpoint/delayed-process semantic gap.

### Non-authoritative lens

- `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md`.

That document was used only to ask omission/casual-sufficiency questions. Its suggestions about journeys, construction, legal/administrative work, and richer institutional routines are not imported into v0.

## 3. Controlling authority anchors

### 3.1 Stable closure is the only checkpoint-safe publication boundary

ADR-0004 and SPEC §9 jointly establish the semantic execution boundary.

The reference kernel runs deterministic cycles through proposal, response, central resolution, commit/failure, automatic semantic reactions, stable publication, and advance. Authoritative intermediate commits may affect same-cycle revalidation and reactions, but intermediate microstates are not a completed cycle state.

Therefore a checkpoint may not be made valid by merely serializing more implementation objects in the middle of a cycle.

A safe checkpoint exists only after:

1. all immediate proposals/responses selected from the common committed decision snapshot have reached terminal resolution;
2. all required same-cycle automatic reactions have closed;
3. stable cycle-level lifecycle/classification state has been evaluated/published;
4. the next actor-visible cycle state is the authoritative continuation frontier.

This is already accepted semantics, not a Slice-5 design choice.

### 3.2 Immediate interaction state must not become cross-boundary pending state

The cross-cutting verification contract requires all immediate proposals to reach a terminal outcome in the same cycle.

SPEC further forbids same-cycle voluntary reactivation after commit and prohibits checkpointing before stable closure.

Consequently, at a safe boundary there is no accepted semantic category of:

- unresolved current-cycle proposal;
- unprocessed response choice;
- partially committed atomic interaction;
- unresolved current-cycle material conflict;
- pending same-cycle authority race;
- unfinished automatic reaction chain.

Such objects may exist as runtime machinery while a cycle is executing, but they cannot be serialized as legitimate future work at a stable checkpoint.

DEC-0010 does not change this. Its “pending old-head action” language refers to an already-accepted same-cycle action awaiting central resolution; the action resolves before the authority-destroying transition or terminates in the same cycle. It never rebinds to a successor and never crosses stable closure.

### 3.3 Future-influencing authority is semantic, not container-shaped

ADR-0001 makes independently identified typed records and explicit references the semantic model. ADR-0004 says current typed state is authoritative and checkpoints capture every future-influencing authoritative fact.

The criterion is therefore causal:

> If omission or alteration of a state item can change a valid future semantic trajectory under otherwise identical future inputs/configuration, that item or an exactly sufficient authoritative equivalent belongs to continuation state.

This does not imply that every current runtime field must be serialized. It also does not allow a future-affecting field to escape merely because the implementation calls it a cache, scheduler detail, counter, helper, or diagnostic.

### 3.4 Derived state remains subordinate to reconstructable authority

ADR-0003 requires derived values behind stable semantic/query boundaries and permits recomputation, delta maintenance, caching, or stronger dependency machinery without changing meaning.

ADR-0004 explicitly states rebuildable indexes/caches need not be authoritative persistence.

Therefore Slice 5 is a direct causal-authority audit:

- a value that can be thrown away and rebuilt from authoritative semantic state with identical queries and future trajectory is derived;
- a value that cannot be reconstructed without changing the future is not safely “just a cache,” regardless of its implementation label.

### 3.5 Exact continuation is stronger than semantic-isomorphism testing

The cross-cutting contract contains two different obligations that must not be collapsed.

General ID-renaming metamorphic tests may compare semantically isomorphic outputs when deliberately renaming nonsemantic IDs, except where accepted stable-ID fallback is under test.

Checkpoint continuation is different. VS-SFL-082 requires the same checkpoint, same future input schedule, and same configuration to produce:

- identical authoritative state at every compared stable boundary;
- identical consequential history suffix;
- identical generated IDs/order;
- identical timing and causal references.

Thus a restore is not permitted to arbitrarily regenerate new semantic identities and claim “equivalence.” Exact continuation preserves the existing identity world and its generation frontier.

### 3.6 Configuration identity is part of continuation authority, but migration is not

SPEC §9.6 explicitly checkpoints rule/configuration version and conditions exact continuation on **identical inputs/configuration**.

That closes the semantic boundary for Slice 5:

- identical rule/configuration is the valid exact-continuation case;
- a different rules/configuration version is outside the exact-continuation contract;
- a checkpoint whose required configuration is unknown/unavailable cannot satisfy the accepted precondition for exact continuation.

Nothing in accepted authority requires version migration, upgrade transforms, backward compatibility across changed semantics, or “best effort” continuation under different rules.

Exact failure/reporting API, manifest format, embedded-vs-referenced configuration payload, and compatibility metadata layout remain engineering choices so long as mismatch cannot silently pass as valid exact continuation.

## 4. Exact checkpoint semantic census

The following classification uses the task's requested categories.

| Surface | Classification | Accepted Slice-5 consequence |
|---|---|---|
| Safe checkpoint boundary | **REQUIRED Slice-5 semantics** + inherited stable-closure regression | Only stable cycle boundary after resolution/reaction closure is valid. |
| `Cycle` / semantic time frontier | **REQUIRED Slice-5 semantics** | Future maintenance, debt timing, cooldowns, history time and generated suffix must continue from the same semantic point. |
| `ReactionIndex` frontier | **REQUIRED Slice-5 semantics** | Consequential suffix ordering must remain exact and monotone; no pre-checkpoint reaction may replay. |
| Person identity/objective state | **REQUIRED Slice-5 semantics** | Stable Person identity, grain, `NeedsGrain`, residence, marriage and other accepted objective facts persist exactly. |
| Typed relations/claims | **REQUIRED Slice-5 semantics** | Kinship, debt, favour, marriage, residence and accepted typed relations retain identity/terms/history needed for future behavior. |
| Debt due/review timing | **REQUIRED Slice-5 semantics** | Each live debt retains enough authoritative timing/processed state to review once at the accepted N+3 semantic point. Representation may be relation-local or scheduled. |
| Attitude + decay timing basis | **REQUIRED Slice-5 semantics** | Stored attitude and the cycle/rule basis needed for deterministic five-cycle maintenance survive. A separate “decay job” is not semantically required. |
| Subjective `KnownFact` | **REQUIRED Slice-5 semantics** | Actor-held fact identity/content and provenance needed for future evidence comparison/gating survive. |
| `Recognition` | **REQUIRED Slice-5 semantics** | Unknown/Recognized/Contested state and supporting/conflicting evidence identity/provenance survive; no passive synchronization on restore. |
| CandidateOrganization / CandidateRecognition that remains live | **REQUIRED Slice-5 semantics** | Persistent future-relevant candidate/evidence state survives if live at checkpoint; candidate labels remain non-authoritative as Household identity. |
| Household identity/lifecycle | **REQUIRED Slice-5 semantics** | Household ID and stable Active/Inactive/Dissolved state, grounded by accepted warrant history, continue exactly. |
| Sustaining participation | **REQUIRED Slice-5 semantics** | Current associations and their provenance remain authoritative; no hidden membership container may replace them. |
| Formation / participation / continuation warrants | **REQUIRED Slice-5 semantics** | Stable IDs and direct supporting refs remain resolvable where they ground current/future identity or queries. |
| LineageWarrant | **REQUIRED Slice-5 semantics** | Authoritative warrant and provenance persist. |
| `DerivedFrom` / transitive ancestry projection | **Inherited regression — rebuildable derived** | Must be reconstructable from LineageWarrant authority; checkpoint must not make projection data the recovery authority. |
| Persistent HouseholdHeadRole identity | **REQUIRED Slice-5 semantics** | Role ID, H linkage and current vacancy/occupancy survive independently of holder identity. |
| Actor-specific head/Household Recognition | **REQUIRED Slice-5 semantics** | Stale/correct/Contested subjective authority knowledge and evidence survive independently of objective occupancy. |
| HouseholdProvisionCommitment | **REQUIRED Slice-5 semantics** | Persistent accepted commitment relations and history survive; exit/dissolution termination remains exact. |
| Transaction-specific private `X` after its transaction is terminal | **Not pending at safe boundary** | `X` is one transaction term/provenance. It is not standing capacity or future work. Its committed historical provenance remains queryable as required. |
| Provision refusal / reconsideration baseline | **REQUIRED Slice-5 semantics** | Latest refusal timing plus relevant context baseline/accepted equivalent must continue so three-cycle eligibility is unchanged. |
| DEC-0014 historical post-refusal material-need occurrence | **REQUIRED Slice-5 semantics** | Once a qualifying occurrence has changed the baseline context, that authoritative/provenance-bearing fact must survive even if the need is no longer current. |
| General pending Household demand | **Explicitly deferred / excluded from v0** | DEC-0014 explicitly rejects inventing a generic pending-demand/adoption/requisition/budget/obligation lifecycle. |
| Scheduled exogenous input | **REQUIRED Slice-5 semantics** | Future input identity/semantic payload/timing/order needed for deterministic execution survives. |
| Other accepted delayed/interruptible work, if present | **REQUIRED Slice-5 semantics** | Must be explicit serializable semantic process state with deterministic ordering and condition revalidation. |
| Same-cycle proposals/responses/resolution objects | **Inherited regression — must be absent as pending state at safe boundary** | All immediate interactions terminate before checkpoint. Runtime objects may be discarded after their consequential records are committed. |
| Automatic-reaction runtime queue/stack | **Engineering-local representation** at safe boundary | Reaction closure is complete before checkpoint. Any still-live queue means the boundary is unsafe. |
| Cause-idempotence / processed frontier | **REQUIRED to the extent future-influencing** | Restore may not repeat already-applied automatic effects. The semantic “already processed” truth may be reconstructed from authoritative committed history or stored explicitly. |
| Generated entity/event/proposal/evidence/warrant identifiers | **REQUIRED Slice-5 semantics** | Existing semantic identities remain stable and future generated suffix IDs must match uninterrupted execution. |
| Identifier/counter/order frontier | **REQUIRED Slice-5 semantics** | Whatever semantic allocator/order state is necessary for exact future IDs/order survives; concrete counter structure is engineering-local. |
| Stable-ID fallback-relevant identity | **REQUIRED Slice-5 semantics** | Restore cannot rename IDs that may affect accepted fallback outcomes. |
| Rule/configuration identity/version | **REQUIRED Slice-5 semantics** | Exact continuation requires the identical active rules/configuration. |
| Scoring coefficients/profile | **REQUIRED as active configuration**, representation engineering-local | Restore must apply the same profile/configuration; embedding the full profile versus resolving a stable version is an implementation decision. |
| Consequential semantic history/provenance | **REQUIRED where needed for exact suffix / resolvable causal state** | Existing referenced provenance remains resolvable; future suffix is exact and no old side effect re-executes. |
| Complete observer/diagnostic archive | **Not recovery authority unless future-influencing** | Diagnostics cannot alter behavior. Historical trace retention obligations remain observability requirements, but a diagnostic buffer cannot be required to recover semantic behavior. |
| Decision traces | **Inherited explainability requirement; non-authoritative for recovery** | New decision contexts after restore must be generated under identical rules/inputs. Trace storage cannot be used as hidden simulation state. |
| MobilizableCapacity summary | **Inherited regression — rebuildable derived** | Recompute from live valid commitments; never restore it as independent Household wealth authority. |
| Candidate/neighborhood/feasible-action indexes | **Inherited regression — rebuildable derived** | May be discarded/rebuilt; stale values cannot influence semantics. |
| Current-head/action-availability/capacity/role-recognition indexes | **Inherited regression — rebuildable derived** | Underlying objective/subjective records are authority; indexes are not. |
| Dependency indexes | **Inherited regression — rebuildable derived unless proven otherwise** | Dependency discovery may be optimized, but a rebuild must recover the same semantic dependencies. |
| Cache of Recognition/provenance | **Inherited regression — rebuildable derived** | Recognition/evidence records are authority; a lookup/cache over them is not. |
| Serializer/DTO/file format/codec/compression | **Engineering-local representation** | No accepted semantic authority selects them. |
| Generic persistence/storage architecture | **Explicitly deferred beyond v0** | ADR-0001/4 and SPEC exclude production persistence/storage selection. |
| Migration between semantic/config versions | **Explicitly deferred beyond v0** | Not required by exact same-config continuation. |
| Distributed/concurrent snapshot semantics | **Explicitly deferred beyond v0** | Reference kernel is single-process/single-threaded. |
| Actor departure | **Explicitly deferred unless separately authorized** | TRES-0010 `LATER-02` still controls. |
| Generic workflow/process engine | **Explicitly deferred / not authorized by v0** | ADR-0004 requires serializable process state where needed, not a universal mature workflow framework. |
| Semantically unresolved Slice-5 item | **NONE FOUND** | No Director-level semantic choice is required before acceptance planning. |

## 5. Stable-boundary meaning

### 5.1 What “after reaction closure” means

A valid Slice-5 checkpoint represents the already-published end of one semantic cycle, not an arbitrary stop-the-world image of runtime memory.

At that boundary:

- every immediate proposal has a terminal result;
- every response-driven action has a terminal result;
- every accepted atomic transaction has either committed completely or failed completely;
- conflict resolution and precommit revalidation are finished;
- all required same-cycle automatic reactions have reached semantic closure;
- lifecycle and other cycle-level classifications have been published from the closed state;
- there is no fresh same-cycle voluntary activation waiting to run.

A restore resumes from that same published semantic frontier.

### 5.2 What may remain “pending”

“Pending” is valid at a stable boundary only for **future semantic causation**, not unfinished current-cycle causation.

Accepted examples include:

- a debt whose social due review lies in a future cycle;
- a provision-refusal reconsideration baseline whose cooldown/context condition may become eligible later;
- a scheduled exogenous input for a future cycle;
- any explicit accepted delayed/interruptible process state whose continuation point lies after the checkpoint.

Those items have future meaning even though the current cycle is complete.

### 5.3 What must not remain pending

The following are not legitimate stable-boundary pending state:

- uncommitted selected personal/Household action;
- unprocessed target response;
- accepted proposal waiting for same-cycle conflict resolution;
- half-applied material allocation;
- same-cycle role/participation transition awaiting DEC-0010/other precedence;
- automatic reaction awaiting closure.

If one of these remains, the engine has not reached an accepted safe boundary.

### 5.4 Runtime scratch and derived state

Diagnostic stacks, enumerators, collection cursors, resolver scratch, temporary candidate sets, coroutine/task stacks, and derived cache internals are not semantic continuation state merely because they exist in memory.

At a safe boundary they may be destroyed and reconstructed, provided reconstruction does not change authoritative state, queries, generated identities/order, or future history.

## 6. Delayed-process boundary

### 6.1 Debt social-due review

A loan committed in cycle N is reviewed after ordinary decisions/commits in cycle N+3.

The future-causal semantics that must survive are:

- the debt identity and parties;
- original/remaining amount;
- the semantic loan commitment time or equivalent exact due time;
- whether the one-time due consequence has already been processed, if that fact is not derivable without ambiguity from authoritative history;
- the causal reference necessary for the due reaction/history.

The specification does not require one particular scheduler representation.

Valid implementations could, for example, derive the due review from debt state + cycle, or place a typed due-review item in a deterministic future schedule. What matters is identical timing, one-shot behavior, revalidation against remaining balance, and exact history.

### 6.2 Provision reconsideration cooldown/history baseline

After refusal, re-asking requires three full cycles **and** accepted relevant context change.

The checkpoint must preserve enough authority to answer the same question after restore.

That includes the latest refusal baseline and the accepted context dimensions. DEC-0014 is especially important because its material-need limb is historical:

- the qualifying need may have ended before the later reconsideration;
- an otherwise-valid but funding-infeasible dowry need may still count;
- a later refusal resets the baseline;
- an old qualifying occurrence cannot satisfy a later post-refusal baseline.

This means the qualifying semantic occurrence/provenance is future-influencing even when there is no current pending demand.

It does **not** justify inventing a generic demand queue.

### 6.3 Scheduled exogenous input

SPEC's MaterialDeadlock definition distinguishes an unrecoverable deadlock from a state that has a scheduled future exogenous grain input capable of resolving it.

Therefore scheduled exogenous input is accepted future-causal state.

Checkpoint continuity must preserve at least the input's semantic payload, timing, identity/order/provenance needed for deterministic application. A scenario harness may supply future inputs externally, but Run A and restored Run B must receive the exact same schedule and must not double-apply an input already consumed before the checkpoint.

### 6.4 Recurring cycle maintenance

Consumption, due attitude decay, cooldown eligibility checks, and similar accepted maintenance are future behavior, but they do not by themselves require individually serialized “jobs.”

For the current accepted v0 semantics, `Cycle` plus current authoritative domain state and rule/configuration identity is sufficient to determine when recurring maintenance is due unless an implementation adds another genuinely future-influencing frontier.

If an implementation introduces such a frontier, it becomes checkpoint-relevant by causality; implementation convenience cannot hide it.

### 6.5 Household / role transitions

No current accepted Household or role transition is a multi-cycle pending process.

Participation entry/end, continuity reactions, lifecycle publication, nomination/appointment/succession, authority-dependent Household action, provision spend, and mediated-marriage effects resolve through the same-cycle proposal/resolution/reaction contract.

Role occupancy may persist across cycles. That is persistent state, not unfinished process.

### 6.6 Generic delayed-process primitive is not required

Accepted authority does **not** currently justify a single generic v0 `PendingProcess`, workflow DAG, task engine, legal-procedure engine, work-order system, or universal process ontology.

ADR-0004's requirement is semantic and conditional:

> delayed/interruptible work is represented by serializable process state with deterministic ordering and condition revalidation.

The smallest authority-preserving interpretation is therefore:

- represent each actually accepted future-timed causal mechanism with bounded typed state;
- if several types share scheduler infrastructure, that scheduler remains an implementation mechanism unless its ordering/frontier is itself future-influencing;
- do not add generalized process meaning beyond the accepted v0 cases.

**Delayed-process disposition: no consequential semantic decision is required; bounded typed future state/inputs are sufficient for current SFL v0.**

## 7. Exact continuation semantics

### 7.1 Required equality

For uninterrupted Run A and restored Run B under the same checkpoint, same future inputs, and same configuration/rules, the following must match.

| Item | Equality requirement |
|---|---|
| Stable authoritative semantic state | **Exact** at every compared stable boundary. |
| Existing Person / relation / Household / role / warrant / evidence identity | **Preserved exactly**; restore does not mint replacement semantic identities. |
| EventIds / ProposalIds generated after restore | **Exact suffix identity/order**, as required by VS-SFL-082. |
| RelationIds / HouseholdIds / role IDs / evidence IDs generated after restore | **Exact suffix identity/order** where generated. |
| `Cycle` | **Exact** semantic continuation. |
| `ReactionIndex` | **Exact** consequential suffix ordering; no pre-checkpoint reaction replay. |
| Causal predecessor references | **Exact** references in the compared consequential suffix. |
| Commit/failure/invalidation outcomes | **Exact**. |
| Failure reasons | **Exact semantic reasons**. |
| Technical fallback markers | **Exact** where the same fallback is exercised. |
| Fallback-sensitive winner under unchanged identities | **Exact**. |
| Subjective KnownFact/Recognition state | **Exact** actor-relative evolution. |
| Subjective evidence/provenance identity | **Preserved/exact** wherever it supports state or later evidence resolution. |
| Debt due timing / one-shot consequence | **Exact** semantic cycle and causal effect. |
| Provision cooldown/context eligibility | **Exact** semantic cycle/result. |
| Scheduled future input execution | **Exact** timing/order/effect under the identical future schedule. |
| Generated ID/counter/order sequence | **Exact**. |
| Rule/configuration version used by decisions/history | **Identical**. |
| Consequential history suffix | **Exact**, including `Cycle, ReactionIndex`, failures, causal refs and fallback markers. |
| Pre-checkpoint semantic effects | **Must not replay**. |

### 7.2 Decision traces

Decision traces are required explainability/observability output for activated contexts and must truthfully record the actual candidates, gates, scores, selection, subjective inputs, and active rule/configuration.

However, accepted recovery authority is **current semantic state + future-influencing state**, not the diagnostic trace buffer.

Therefore:

- a pre-checkpoint diagnostic buffer is not allowed to control post-restore behavior;
- the checkpoint does not need to make arbitrary diagnostic storage into simulation authority merely to preserve it;
- post-restore decisions under identical state/inputs/configuration must be capable of producing the same truthful decision evidence for the same activated contexts;
- consequential commit/failure history and any provenance referenced by authoritative state remain subject to the stronger exact-history requirements.

### 7.3 Semantic exactness does not imply byte-identical serialization

Accepted authority requires exact semantic continuation, not identical checkpoint-file bytes.

The following may vary if and only if semantic continuation remains exact:

- object allocation addresses;
- dictionary/hash-table bucket layout;
- in-memory collection capacity;
- serializer property ordering where nonsemantic;
- compression;
- DTO decomposition;
- cache/index materialization;
- file/container format.

Conversely, a serializer cannot excuse changed semantic identity/order/history merely because the deserialized domain looks “equivalent.”

### 7.4 Pre-checkpoint history and provenance

Current state is authoritative, not event-sourced authority. Still, accepted semantics require live and historical references to remain resolvable and many current facts are grounded by specific warrants/evidence/events.

Slice 5 therefore must preserve the **semantic provenance graph needed by authoritative state and future rules**, not necessarily force the entire observer archive into one checkpoint blob.

Authority can be satisfied by any engineering representation that keeps required references resolvable, for example:

- self-contained checkpoint records;
- checkpoint plus immutable referenced semantic-history store;
- another bounded representation with equivalent authoritative guarantees.

What is forbidden is restoring a Household/Recognition/warrant/cooldown state while silently severing the evidence/event identity its accepted semantics require.

## 8. Configuration and version boundary

### 8.1 Identical configuration

This is the accepted exact-continuation case.

Restore must:

- apply the same active rule/configuration profile;
- preserve its semantic identity/version;
- use the same future input schedule;
- reproduce exact state/history suffix.

Whether the checkpoint embeds the entire immutable configuration or stores a resolvable version/content identity is engineering-local.

### 8.2 Different configuration or rule version

Accepted authority does not define “continue exactly but under new rules.”

A different configuration/rules version breaks the stated precondition of the exact-continuation contract.

The implementation must therefore not silently classify such a run as a valid exact restore.

It may reject the operation or route it to some separately authorized future migration/import capability. Slice 5 need not invent that capability.

### 8.3 Unknown or unavailable referenced configuration

If the checkpoint requires configuration/version X and the restore environment cannot supply the identical X, the accepted exact-continuation precondition is unsatisfied.

The safe semantic disposition is **not a valid exact continuation**.

Exact exception type, error text, file compatibility marker, lookup mechanism, and user-facing recovery path are engineering choices.

### 8.4 No migration authority

Nothing in current accepted SFL v0 authorizes:

- schema evolution as simulation semantics;
- cross-version state transformation;
- replaying old state under new rules and calling it continuation;
- best-effort downgrade/upgrade;
- automated conflict resolution between historical and current configuration.

Those are future persistence/versioning questions.

## 9. Semantic history and provenance boundary

History serves two distinct roles that Slice 5 must keep separate.

### 9.1 Semantic causal/provenance history

This includes stable identities and references that accepted state/history depends upon, such as:

- proposal/event outcomes;
- debt creation/repayment/due consequences;
- KnownFact and Recognition evidence;
- FormationWarrant support events/evidence;
- ParticipationWarrant / ParticipationEndWarrant refs;
- ContinuationWarrant transition evidence;
- role appointment/succession evidence;
- provision commitment/refusal/reconsideration provenance;
- transaction funding source/debit provenance;
- LineageWarrant predecessor/source/fresh-event refs;
- cause-keyed automatic reactions and causal predecessors.

Where current/future semantics refer to these records, restore must keep the references valid and their meaning unchanged.

### 9.2 Observer/diagnostic history

Diagnostic traces and reporting surfaces must be truthful and noninterfering, but they do not become hidden causal authority merely because they are useful to humans or tests.

If deleting an alleged diagnostic record changes future semantic behavior, then it was not purely diagnostic; the future-influencing semantic fact it carried must be identified and promoted to the authoritative continuation census rather than relying on the diagnostic buffer accidentally.

## 10. Caches, indexes, projections, and derived state

### 10.1 Authoritative state that must survive

Examples include:

- current typed domain records;
- stable identities and explicit references;
- actor subjective KnownFact/Recognition plus evidence/provenance;
- Household identity/lifecycle and sustaining-participation/warrant substrate;
- role identity/current occupancy;
- provision commitment state;
- debt/favour/marriage/residence/attitude/resources;
- cooldown/context baselines;
- scheduled future input and any real pending semantic work;
- rule/configuration identity;
- identifier/order/time frontier;
- causal/provenance state required for current/future semantics.

### 10.2 Rebuildable state that must not become recovery authority

Explicitly:

- `DerivedFrom(successor, predecessor)`, which SPEC declares a rebuildable projection of `LineageWarrant`;
- transitive `AncestorOf` query materialization;
- `MobilizableCapacity(H)`, which is derived from valid current provision commitments;
- neighborhood/candidate lookup indexes;
- feasible-action indexes;
- dependency indexes that can be rebuilt from declared semantic dependencies/state;
- current-head lookup indexes;
- action-availability indexes;
- capacity summaries;
- role-Recognition lookup/index caches;
- any cache of KnownFact/Recognition/provenance where the underlying actor-held records remain authoritative.

### 10.3 The representation caveat

An implementation may use an indexed collection to *store* authoritative records.

“Index is rebuildable” does not mean the authoritative records inside a container may be lost. It means the lookup topology/materialized projection is not a second source of truth.

Acceptance should judge the semantic records and the rebuild behavior, not class names.

## 11. Inherited verification / fired deferral map

Slice 5 does not start from zero. Earlier frozen manifests intentionally deferred checkpoint-specific rows while already locking the surrounding closure/cache invariants.

### Slice 1

Deferred to later checkpoint work:

- `S1-082` — VS-SFL-082 checkpoint exact suffix;
- `S1-083` — VS-SFL-083 omitted checkpoint state;
- `S1-META-06` — checkpoint metamorphism;
- `S1-MUT-25` — omission of future-influencing checkpoint state.

Already inherited as non-negotiable context:

- stable reaction closure;
- deterministic fallback disclosure;
- derived rebuild/nonhidden-authority requirements;
- observer noninterference;
- causal/decision history.

### Slice 2

- `S2-D07-CHECKPOINT-SUBJECTIVE-STATE` was explicitly deferred to Slice 5.

The now-fired obligation is to prove actor-specific KnownFact/Recognition/provenance and staleness survive restore without passive synchronization or evidence-identity drift.

### Slice 3

- `S3-D10-CHECKPOINT-RESTORE` was explicitly deferred to Slice 5.

Already required and inherited:

- no mid-closure stable publication/checkpoint;
- derived-state rebuild equivalence;
- `DerivedFrom` nonauthority;
- structural nonhidden authority;
- configuration provenance.

### Slice 4

Frozen successor v2 retains:

- `S4-D01-CHECKPOINT-RESTORE` — exact save/load continuation / omission recovery deferred to Slice 5.

Already required and inherited:

- `S4-146` cache nonauthority;
- `S4-156` stable closure;
- `S4-186` MobilizableCapacity nonauthority;
- explicit typed role/provision/cooldown authority;
- DEC-0010/0011/0013/0014 causal/provenance constraints.

### TRES-0010 hardening trigger

`VH-04` is now **FIRED for Slice-5 acceptance planning**:

> checkpoint omission mutants need a continuation suffix that causally exercises the omitted state.

The intended proof cannot merely delete a field and observe that deserialization fails. Each omission mutant intended to establish causal sufficiency must continue far enough for the omitted semantic fact to matter and must detect the resulting semantic/history divergence.

This is verification-hardening authority, not a request for new semantics.

## 12. Slice-5 boundary and out-of-scope

### 12.1 In bounded Slice 5

Slice 5 may implement and verify:

- safe-boundary checkpoint capture/restore;
- explicit capture of all accepted future-influencing authoritative state;
- bounded typed scheduled-input / future-state representation needed by accepted v0;
- any currently accepted delayed/interruptible state required by the bounded v0 implementation, with deterministic ordering and condition revalidation;
- exact identifier/order/time continuation;
- exact consequential suffix continuation;
- rule/configuration identity validation;
- rebuild of declared caches/indexes/projections;
- omission mutants and rebuild metamorphisms;
- recovery APIs, DTOs, codecs, serialization formats, and scheduler structures as implementation-local mechanisms.

### 12.2 Explicitly outside bounded Slice 5

Do not expand this slice into:

- a production/general persistence framework;
- arbitrary save-file compatibility across future semantic versions;
- schema/rule/config migration;
- distributed or concurrent snapshots;
- lock-free/multi-thread snapshot protocols;
- rollback/time travel;
- branchable alternate histories;
- replay-as-primary-authority / generic event sourcing;
- archival compression as semantic design;
- a generic workflow/process orchestration engine;
- journeys, construction, legal procedure, administration, production chains, or other richer delayed institutional/economic processes merely suggested by conceptual research;
- generic Household pending-demand/obligation/budget queues;
- a mature Household economy, treasury, asset, accounting, or property system;
- actor departure unless separately authorized under `LATER-02`;
- richer candidate convergence or lineage cases still governed by their own deferred triggers;
- stochastic behavior redesign;
- production-scale storage/scaling optimization.

## 13. Engineering choices that do not require Director decision

The following must not be escalated as social-semantic choices unless implementation uncovers a genuine causal difference:

- checkpoint file format;
- JSON/binary/other codec;
- DTO shape;
- schema names;
- file extension;
- compression;
- embedding versus stable lookup of immutable configuration, provided identity is exact and availability is enforced;
- scheduler data structure;
- priority queue versus sorted list versus relation-local timing derivation;
- counter representation;
- serialization library;
- cache rebuild strategy;
- error/exception type for invalid restore;
- persistence service interfaces;
- whether required semantic history is embedded in the checkpoint or referenced through a guaranteed immutable/resolvable store.

Implementation must stop/escalate only if one of those choices forces a new semantic answer, for example:

- two supposedly valid scheduler representations produce different accepted semantic ordering;
- exact ID continuation cannot be achieved without defining a new semantic identity rule;
- a “cache” proves irreducibly future-influencing but has no accepted semantic interpretation;
- a restore under identical configuration still requires choosing among non-equivalent social outcomes;
- newly introduced delayed work requires domain rules about cancellation, interruption, priority, ownership, or effects that accepted authority does not supply.

No such consequential semantic question is present in the accepted corpus today.

## 14. Director decision map

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

The tempting questions are already classifiable without new Director semantics:

- **“Do we need one generic delayed-process type?”** No semantic requirement says so. Current v0 may use bounded typed future state/inputs; shared scheduler shape is engineering-local.
- **“What if restore uses a different rules/config version?”** Exact continuation is accepted only under identical inputs/configuration. Migration is outside bounded Slice 5.
- **“Must every cache be serialized?”** No. Rebuildable caches/indexes/projections are explicitly non-authoritative.
- **“May an unfinished same-cycle action be checkpointed as pending work?”** No. A safe checkpoint cannot exist before same-cycle resolution/reaction closure.
- **“Must the checkpoint byte stream be identical?”** No accepted authority requires byte identity; it requires exact authoritative continuation/history.
- **“Must every historical diagnostic line be inside the checkpoint?”** Not merely because it was logged. Required semantic provenance/references must remain resolvable, while diagnostics must remain noninterfering.
- **“Should journeys/construction/legal/work processes be added to exercise delayed state?”** No. The conceptual lens expressly lacks authority to create those v0 commitments.

If implementation or acceptance design discovers a future-causal category that cannot be classified under this boundary, DEC-0012's stop-on-unclassified-interaction discipline remains applicable. That possibility does not make the present boundary unresolved.

---

## Exact Slice-5 semantic boundary

Slice 5 is the bounded implementation and verification of **stable-boundary exact continuation plus the already-accepted future-timed causal state needed by SFL v0**.

It must capture or exactly reconstruct every authoritative fact that can affect the future, preserve semantic identity/order/configuration/provenance, resume only from a stable post-reaction-closure boundary, and reproduce the subsequent authoritative semantic state and consequential history suffix exactly under identical future inputs/configuration.

It may choose local serialization/scheduler/data-layout mechanisms, but it may not create new social meaning, make runtime scratch/caches authoritative, or broaden v0 into a general persistence/process system.

## Accepted delayed-process set / boundary

Current accepted future-timed causal state consists of:

- debt social-due timing / one-time due review;
- provision refusal/reconsideration cooldown + historical context baseline, including DEC-0014 material-need occurrence provenance;
- scheduled future exogenous input;
- cycle-driven recurring maintenance determined by semantic time + rules;
- any genuinely accepted delayed/interruptible work actually present in the bounded v0, which must use explicit serializable semantic state, deterministic ordering and condition revalidation.

There is **no accepted requirement for a new generic delayed-process/workflow primitive** and no accepted delayed Household/role transition crossing a stable boundary.

## Checkpoint equality requirements

Under the same checkpoint, same future inputs and identical configuration/rules:

- authoritative state is exact at every compared stable boundary;
- existing semantic IDs are preserved;
- generated IDs/order are exact;
- `Cycle / ReactionIndex` and consequential causal ordering are exact;
- failures/invalidation results and reasons are exact;
- technical fallback markers/outcomes under unchanged identity are exact;
- subjective evidence/Recognition evolution is exact;
- scheduled future input execution is exact;
- rule/config version is identical;
- consequential history suffix and causal predecessor references are exact;
- no pre-checkpoint semantic side effect/reaction is re-executed.

Exactness is semantic/history/identity exactness, not checkpoint-byte or runtime-layout identity.

## Safe-boundary rule

A checkpoint is valid **only at a stable cycle boundary after all immediate proposal/response resolution and automatic semantic reaction closure**.

Future scheduled work may remain pending. Current-cycle proposal/response/resolution/reaction transients may not.

## Cache / derived-state boundary

Authoritative domain/subjective/provenance/future-schedule state must survive.

Rebuildable state must remain non-authoritative, including at minimum:

- lineage / `DerivedFrom` and ancestry projections;
- `MobilizableCapacity(H)`;
- candidate/neighborhood/feasible-action indexes;
- current-head/action-availability/capacity/role-recognition indexes;
- dependency indexes when reconstructable;
- caches over Recognition/KnownFact/provenance.

Discard/rebuild at a safe boundary must preserve query results and future state/history.

## Post-v0 exclusions

Outside bounded Slice 5 remain:

- general persistence/version-migration architecture;
- cross-version semantic continuation;
- distributed/concurrent snapshots;
- rollback/time travel;
- branchable alternate histories;
- event-sourced authority;
- archival/compression design as semantics;
- mature generic workflow/process engines;
- richer delayed journeys/construction/legal/administrative/economic processes;
- generic Household demand/obligation/budget queues;
- mature economy/property/asset systems;
- actor departure unless separately authorized;
- other deferred convergence/lineage expansions;
- stochastic-policy redesign and production-scale storage/scaling.

## Director-decision status

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

No consequential accepted-semantic gap was found that must be decided before Slice-5 completion authority can be drafted.

## Recommendation

**READY FOR ACCEPTANCE PLANNING.**
