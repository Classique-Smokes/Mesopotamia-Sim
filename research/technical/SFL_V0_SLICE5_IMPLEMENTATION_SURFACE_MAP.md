# SFL v0 Slice 5 — Implementation Surface and Future-Causal State Map

**Status:** ADVISORY RESEARCH RETURN / DISCOVERY B  
**Task:** tasks/research/SFL_V0_SLICE5_DISCOVERY_B_IMPLEMENTATION_SURFACES.md  
**Return branch:** research/slice5-implementation-surface-return  
**Exact base SHA:** 664311fffbc4475e3924221f58633b3a4f63a8a9  
**Repository:** Classique-Smokes/Mesopotamia-Sim  
**Production-code changes:** none

## 1. Scope and authority

This return maps the promoted Slice-4 reference kernel against the already accepted continuation, determinism, recovery, and derived-state constraints. It is an implementation archaeology/state-census return, not a checkpoint-format design and not new simulation authority.

The controlling constraints are consistent across SPEC-SFL-0001, ADR-0003, ADR-0004, the cross-cutting verification contract, VS-SFL-082 through VS-SFL-085, the frozen Slice-1 through Slice-4 acceptance manifests, accepted DEC-0013/DEC-0014 boundaries, and the TRES-0010 deferred-gap ledger:

- completed simulation state exists only at a stable cycle boundary after resolution and reaction closure;
- current typed semantic state remains authoritative;
- a checkpoint must contain every future-influencing authoritative value;
- rebuildable caches/indexes are not persistence authority;
- uninterrupted and restored execution under identical future inputs/configuration must reproduce the authoritative state/history suffix exactly;
- delayed work must preserve deterministic ordering, provenance, and live revalidation;
- runtime iteration order, task/coroutine stacks, caches, and event-log replay must not silently become simulation authority;
- checkpoint omission mutants must causally exercise the omitted class, per VH-04;
- accepted v0 resource machinery remains a bounded synthetic scaffold and does not authorize a generic budget, obligation, demand, asset, or economic framework.

Sources reviewed at the pinned base include AGENTS.md; SPEC-SFL-0001; ADR-0003/0004 and relevant accepted Slice-4 decisions; all canonical src/Mesopotamia.Sim source files; current acceptance oracles/structural tests; IMP-0001 through IMP-0004 final completion records; the inter-slice discovery prompt; the determinism/recovery/explainability and cross-cutting verification families; frozen Slice-1, Slice-2, Slice-3, and current frozen Slice-4-v2 manifests; and registers/TRES-0010_DEFERRED_GAP_LEDGER.md. Conceptual material was not needed to reach the findings below.

## 2. Executive findings

1. **The public snapshots are observation-complete for their existing APIs but not checkpoint-complete.** WorldSnapshot omits WorldState.nextRelation. EpistemicSnapshot omits EpistemicState.candidates and nextEvidence. HouseholdSnapshot omits HouseholdState.Supports and all Household/role allocator frontiers. Serializing the three public snapshots alone would therefore fail exact continuation.

2. **Authoritative state is distributed, not centralized.** The live continuation boundary spans WorldState, EpistemicState, HouseholdState, and Simulation-level cycle/history/schedule/identity state. Exact restore must preserve the distributed frontier rather than pretending one snapshot owns it.

3. **The strongest hidden future-causal omissions are identity/frontier state and retained process baselines.** These include nextEvidence, usedProposals, nextProposal, nextEvent, nextRelation, all Household allocator counters, candidate referents, provision-refusal baselines/material-need occurrence, and the pending GrainInput schedule.

4. **Evidence identity cannot safely be reconstructed from the maximum currently held EvidenceId.** Supersession removes older KnownFacts from actor-held fact lists while nextEvidence continues to advance. This is a concrete case where max-existing reconstruction can reuse a historical ID and break exact suffix identity.

5. **Other allocators happen to look max+1-reconstructible under today's retention invariants, but that is not a safe persistence contract.** Relations, events, households, warrants, associations, commitments, head roles, and used proposals are currently retained rather than deleted at safe boundaries. Even so, accepted checkpoint authority explicitly requires identifier/order state, and current structural tests treat the allocator fields as explicit authority. Persist the exact frontier; do not substitute a heuristic without separately proving and accepting it.

6. **Current delayed behavior does not require a generic process scheduler.** Debt due review is represented by Debt.CommittedCycle plus DueReviewed; provision reconsideration by ProvisionRefusal plus its historical material-need occurrence; periodic decay by current Cycle; and exogenous future work by InitialWorld.Inputs. These are already typed, serializable causal forms. DEC-0014 explicitly rejects a generic pending-demand subsystem for the current provision rule.

7. **The current event list is consequential semantic history/provenance, but it must not become current-state authority.** Many live records retain EventId causal references, and some runtime code consults the history prefix while constructing later causal records/projections. Exact restore therefore needs enough retained semantic-history prefix to preserve reference resolution and public history continuity. Restore must not replay that prefix to regenerate current state, because that would re-execute side effects and violate ADR-0004's current-state-authoritative boundary.

8. **Existing copy/projection machinery is useful but not a checkpoint proof.** WorldState.Copy, EpistemicState.Copy, and HouseholdState.Copy preserve their private counters and typed state. Detached resolution intentionally copies only the subset required for counterfactual evaluation and normalizes newly allocated identities. That proves local isolation/commutativity machinery, not full continuation.

9. **There is no current random-state surface and no mutable static/process-global semantic counter.** ADR-0004 leaves an explicit reproducible randomness boundary open for future work, but the promoted Slice-4 kernel does not implement an RNG. Adding one during Slice 5 would create a new future-causal state class and must be treated as an explicit trigger, not smuggled into checkpoint work.

10. **Slice-size classification: substantial kernel extension, not architecture redesign.** The accepted architecture already anticipates safe-boundary checkpoints and serializable delayed state, and the existing typed partitions/copy semantics are compatible with that direction. The work is nevertheless cross-cutting because exact capture/restore must span all state owners, causal history, pending schedule, configuration/rule identity, and distributed ID frontiers, with omission and rebuild mutants. No generic scheduler, event-sourced rewrite, database, or new social semantics is justified.

## 3. A — Authoritative-state census

### 3.1 World/material/social substrate

WorldState is an authoritative mutable partition. Its dictionaries are not caches.

- People: PersonId, Sex, Grain, and NeedsGrain are future-causal. Name is not currently used by decision rules, but it is part of authoritative Person/OwnStateFact content and public state and therefore belongs in an exact semantic checkpoint.
- Dwellings: the set of DwellingId values remains future-causal through residence validation and destination references.
- Residences: future decision gates, co-residence formation evidence, and movement feasibility read them.
- Attitudes: future gates/scoring, formation durable ties, decay, and provision-context comparison read them.
- Kinships: marriage gates and durable-tie formation/participation read them.
- Marriages: future eligibility, agency inputs, durable ties, and mediated/direct marriage rules read them. Origin EventId is retained provenance.
- Debts: Remaining, CommittedCycle, DueReviewed, parties, and Origin are directly future-causal. Original is also retained semantic claim/history content.
- Favours: ordered parties, Outstanding, and Origin are future-causal for capacity, calls, cancellation, and causal history.
- nextRelation: hidden authoritative allocation frontier; copied by WorldState.Copy but omitted from WorldSnapshot.

WorldSnapshot is an immutable materialized view of those dictionaries. It is not sufficient persistence because it omits nextRelation.

### 3.2 Epistemic state

EpistemicState owns actor-held subjective state.

- facts: Dictionary<PersonId,List<KnownFact>> is authoritative subjective state. KnownFact identity, proposition, acquisition route, source event/source actor, EvidenceOrder, fixture provenance, and communication hops all matter to staleness, supersession, held-claim validation, communication, Recognition, warrant evidence, and exact history.
- candidates: ImmutableArray<CandidateReferent> is authoritative/inert declared referent state. Candidate Id, fixed Core, and IsLive affect future CandidateRecognition and automatic Household formation. Simulation.DeclareCandidate can add referents after construction, so InitialWorld.Candidates is not an adequate restore source.
- nextEvidence: hidden authoritative evidence allocator frontier. It is copied exactly but omitted from EpistemicSnapshot.

CandidateRecognition, HouseholdRecognition, and HeadRecognition exposed in ActorEpistemicState are derived from held facts plus candidate referents. They should be rebuilt, not separately trusted as checkpoint authority. Their evidence basis, however, is authoritative because it is the KnownFact set/provenance they derive from.

The max-current-EvidenceId shortcut is specifically unsafe: superseded KnownFacts are removed from current held lists while nextEvidence remains advanced.

### 3.3 Household substrate

HouseholdState is a separate authoritative partition. Current structural acceptance explicitly enumerates its typed authority fields.

- Households: HouseholdId, Formation warrant link, Lifecycle, LifecycleEvent, and LifecycleTime.
- Formations: complete FormationWarrant, including CandidateId, founders, dwelling, durable ties, support evidence, founder Recognition basis, earliest evidence, and WarrantStamp.
- Associations: each SustainingParticipant AssociationId, Person, Household, Origin warrant, and End warrant.
- Entries: ParticipationWarrant including proposal/acceptance identity, prior associations, residence/tie/support evidence, Recognition basis, and stamp.
- Exits: ParticipationEndWarrant.
- Continuations: previous/transition warrant links, prior/successor association identities, bridge actors, Recognition basis, and stamp.
- Lineages: LineageWarrant, predecessor set, founder source mapping, fresh evidence, and stamp.
- Commitments: HouseholdProvisionCommitment including exact association binding, typed provenance, and termination event.
- Supports: committed ordinary SupportFact store used by future formation/entry/lineage logic. It is intentionally not reconstructed ad hoc from observer history in current code. HouseholdSnapshot omits it.
- HeadRoles: persistent role identity, Household link, current Occupant, Origin, and LastTransition.
- HeadTransitions: typed appointment/vacancy transition records and their consent/warrant provenance.
- ProvisionRefusals: the bounded reconsideration baseline, including Key, refusal Cycle/Event, ProvisionContext, EligibleSupportCohort, and optional HouseholdMaterialNeedOccurrence.
- nextHousehold, nextWarrant, nextAssociation, nextCommitment, nextHeadRole: distributed hidden ID frontiers.

HouseholdSnapshot publishes nearly all typed records but omits Supports and every allocator frontier. Its query helpers Participants, DerivedFrom, AncestorOf, ExposedCapacity, and MobilizableCapacity are derived.

### 3.4 Head/role and reconsideration state

Persistent role identity is not reducible to current occupant. Exact state includes the role record, its origin/last transition, the HeadTransition provenance history, and actor-held HeadRoleFacts in EpistemicState.

ProvisionRefusal is already the current bounded delayed/context process state:

- refusal Cycle establishes the elapsed-time baseline;
- Context captures grain, NeedsGrain, attitude toward head, head identity, and needy participants at refusal;
- EligibleSupportCohort preserves association-identity baseline needed to distinguish a later new/re-entered support need;
- MaterialNeedChange preserves the first qualifying post-refusal semantic occurrence and its causal evidence;
- a later refusal replaces the baseline.

DEC-0014 makes this state historical and provenance-bearing and explicitly rejects replacing it with a generic pending-demand/requisition/budget/obligation system.

### 3.5 Simulation/kernel state

Simulation itself owns continuation-critical state outside the three domain partitions.

- state: authoritative WorldState.
- epistemic: authoritative EpistemicState.
- households: authoritative HouseholdState.
- cycle: future-causal simulated time. It controls scheduled input application, consumption/decay cadence, debt due review, cooldown elapsed time, and new EvidenceOrder/Event timestamps.
- events: retained consequential SemanticEvent history/provenance. Live records contain EventId references into this namespace and later events append causal predecessors. Treat it as authoritative history, not as the source from which current state is replayed.
- nextEvent: exact EventId frontier.
- usedProposals: exact set of all consumed ProposalIds. Future explicit proposal validation rejects any reused ID, including an old low ID; a single max value is not a substitute for this set.
- nextProposal: autonomous/generated ProposalId frontier.
- initial.Inputs: current storage for the immutable exogenous GrainInput schedule; future-cycle entries are future-causal.
- initial.Configuration.Version: emitted into future SemanticEvents, DecisionTraces, WarrantStamps, and provenance. It is not a rules selector, but omission changes exact history suffix.
- per-domain rule constants/routing: Configuration.RulesVersion plus HouseholdRulesVersion and HeadRulesVersion select the rule-version label emitted for the meaning exercised. These are code identity rather than mutable state, but accepted restore requires rule/configuration identity compatibility.
- reactionIndex: authoritative ordering while a cycle is executing; at a valid safe checkpoint the cycle is closed and the next RunCycle unconditionally resets it to 0. The closed-cycle ReactionIndex values live in SemanticEvent history. It is therefore not a separate future-causal safe-boundary frontier under current code, but a restore must validate that the captured boundary is closed. Any future resumable mid-cycle process would change this classification.
- faulted: terminal runtime status after an exception. A faulted/mid-cycle instance is not a valid safe checkpoint and must not be normalized into a successful continuation.
- Challenge: internal verification-only ReactionChallenge fault-injection setting. It can alter behavior if non-None, so it is hidden behavior-affecting test state, not social-semantic authority. Slice-5 verification must explicitly decide whether checkpoint tests require Challenge=None or carry challenge mode in harness metadata. It must not silently become production checkpoint semantics.

No persistent personal/Household policy is stored between cycles. CycleInput, PersonalPolicy, HouseholdPolicy, response maps, funding policies, and head-consent maps are caller inputs scoped to one cycle. RunAutonomousCycle reconstructs current policies each call.

### 3.6 Diagnostic / observer state

- published, publishedEpistemic, publishedHouseholds: immutable stable-boundary views derived from authoritative partitions and current cycle. Rebuild.
- decisionHistory: retained diagnostic/explainability history. It is not read to determine future behavior. If a checkpoint product promises pre-checkpoint diagnostic continuity it must be retained or separately persisted, but it is not future-causal simulation authority.
- knowledge: legacy ParticipantOutcome observer store behind KnowledgeOf. Existing entries are not consulted by future decisions; Learn only appends the new outcome and mirrors it into an authoritative ParticipationFact. It is rebuildable from retained participation facts/history for observer continuity.
- CycleResult objects are returned views, not stored engine authority.

## 4. B — Hidden future-causal state search

### 4.1 Hidden fields found

The principal hidden fields absent from public semantic snapshots are:

- WorldState.nextRelation;
- EpistemicState.candidates;
- EpistemicState.nextEvidence;
- HouseholdState.Supports;
- HouseholdState.nextHousehold;
- HouseholdState.nextWarrant;
- HouseholdState.nextAssociation;
- HouseholdState.nextCommitment;
- HouseholdState.nextHeadRole;
- Simulation.nextEvent;
- Simulation.nextProposal;
- Simulation.usedProposals;
- the future portion of Simulation.initial.Inputs;
- Simulation.initial.Configuration.Version;
- retained SemanticEvent prefix and its EventId namespace;
- verification-only Simulation.Challenge.

These are exactly the kinds of omissions VS-SFL-083 is intended to detect.

### 4.2 Static/global/random state

The canonical source scan found:

- no mutable static semantic collection;
- no process-global ID counter;
- no Random/Guid/time-of-day/environment-based semantic source;
- no current RNG seed/state.

Static state is limited to rule/scoring helpers and constants. ADR-0004's explicit randomness boundary remains architectural future capacity, not current implementation state.

### 4.3 Container-order dependence

The implementation generally quarantines order explicitly:

- proposals are seeded/processed by ProposalId;
- maintenance people/attitudes and scheduled inputs are explicitly ordered;
- evidence snapshots order facts by EvidenceId;
- candidates are iterated by CandidateId for formation closure;
- funding ranking orders capacity then PersonId;
- attitude-batch closure sorts CauseKeys;
- stable-ID fallback is separately disclosed and metamorphically tested.

Current acceptance tests reverse initial arrays/proposal order and repeatedly query readers to prove noninterference.

Risk remains whenever checkpoint serialization emits dictionaries/hash sets: JSON/property/container order must not become an implicit restore order. Restore must reconstruct typed mappings/sets and let semantic sort/fallback rules decide behavior.

### 4.4 InitialWorld as a mixed-authority object

Simulation retains the entire InitialWorld, but only parts are future-causal after construction:

- Inputs remains actively read for maintenance and deadlock lookahead;
- Configuration.Version remains actively emitted;
- original people/dwellings/relations/knowledge/candidates have already been materialized into live partitions.

Detached Household resolution constructs new Simulation(initial) as a convenience before overwriting state, epistemic, households, cycle, nextEvent, reactionIndex, and events. That constructor dependency must not be mistaken for proof that the whole original fixture is current authority. A restore design may retain it for implementation convenience, but doing so must not elevate historical fixture inputs above restored live state.

## 5. C — Existing copy/replay infrastructure and its limits

### WorldState.Copy

Strengths:

- copies every authoritative world dictionary;
- preserves nextRelation exactly;
- supports atomic transaction evaluation and detached projections.

Does not provide:

- a public serializable checkpoint representation;
- schedule/configuration/history/Simulation counters;
- version compatibility validation.

### EpistemicState.Copy

Strengths:

- copies actor-held facts;
- preserves candidate referents;
- preserves nextEvidence exactly.

This is particularly valuable because EpistemicSnapshot cannot reconstruct nextEvidence or candidate definitions.

Does not provide:

- serialized type/version handling;
- Simulation schedule/history/counters;
- proof of cross-partition consistency after restore.

### HouseholdState.Copy

Strengths:

- copies Households, all warrant/association/lineage/commitment stores, Supports, HeadRoles, HeadTransitions, ProvisionRefusals;
- preserves every Household/role allocator counter.

This is much closer to the actual persistence boundary than HouseholdSnapshot.

Does not provide:

- cross-partition reference validation against restored world/epistemic/history;
- serialization/versioning;
- Simulation-level identity/schedule/history.

### Detached ordinary resolution

ResolutionDependencies uses WorldState.Copy and, when epistemic interaction matters, EpistemicState.Copy. It intentionally uses synthetic negative EventIds tied to proposal identity and does not consume live allocation sequences.

This proves counterfactual isolation and commutativity checking, not checkpoint restoration.

### Detached Household resolution

HouseholdResolution constructs a temporary Simulation(initial), then overwrites only the state needed by same-cycle counterfactual evaluation: WorldState.Copy, EpistemicState.Copy, HouseholdState.Copy, cycle, nextEvent, reactionIndex, and current event prefix.

It deliberately does not copy usedProposals, nextProposal, decisionHistory, knowledge, published snapshots, or other future-cycle engine state because the projection never resumes as a normal simulation. Therefore it must not be promoted wholesale as a restore mechanism.

### HouseholdProjection

HouseholdProjectionKey intentionally normalizes newly allocated EventId/RelationId/EvidenceId/Household-related identities so two counterfactual execution orders can be compared for semantic equivalence. That is the opposite of an exact checkpoint encoding, which must preserve real live identity frontiers. HouseholdProjection is useful verification logic, not persistence format.

### Oracle reconstruction

InvariantOracle, HouseholdOracle, HouseholdWarrantOracle, and Slice4Oracle independently reconstruct material transitions, warrants, causal references, funding, recognition/provenance, lifecycle, and head/commitment state. These are strong independent correctness oracles.

They do not prove:

- save/load bytes round-trip;
- private allocator/frontier preservation;
- used ProposalId preservation;
- pending GrainInput preservation;
- exact post-restore suffix under identical future inputs;
- rejection of a mid-cycle/faulted checkpoint;
- configuration/rule compatibility.

### Stable publication

The kernel already has the right safe-boundary shape: published world/epistemic/household snapshots are refreshed only after automatic closure. That provides a natural capture gate. The snapshots themselves remain incomplete persistence representations.

## 6. D — Scheduled inputs and delayed work

### 6.1 GrainInput schedule

Current storage: immutable InitialWorld.Inputs retained by Simulation.initial.

Current reads:

- Maintenance selects inputs whose Cycle equals current cycle and orders same-cycle entries by GrainInput.Id.
- FutureInputsResolveMaterialBlock scans inputs with Cycle greater than current cycle, orders/group them by cycle, and applies each batch ordered by Id.

There is no consumed-input set. Consumption is implicit from current Cycle because the schedule is immutable and entries are cycle-addressed.

For today's closed schedule, either of the following can reproduce future behavior:

1. full original schedule plus restored current Cycle; or
2. exact remaining entries with original GrainInput Id/Cycle/Person/Delta plus restored current Cycle.

Accepted authority does not select one encoding. Do not turn the implementation convenience of InitialWorld retention into semantic preference.

An explicit consumed-input set is not needed for current behavior because inputs cannot be appended/reused after construction. If Slice 5 adds mutable scheduling, cancellation, or external insertion, that conclusion becomes invalid and requires explicit process identity/ordering semantics.

### 6.2 Debt due review

No queue exists. Debt itself stores:

- CommittedCycle;
- DueReviewed;
- Remaining;
- Origin EventId.

Review executes after ordinary resolution when current cycle is at least CommittedCycle+3. Persisting the exact Debt record plus Cycle is sufficient current delayed-work state. Reconstructing a separate due queue would be derived and must not become authority.

### 6.3 Provision reconsideration

No generic queue exists. ProvisionRefusal is the process baseline. Exact continuation requires its Cycle/Event/Context/EligibleSupportCohort/MaterialNeedChange. The optional HouseholdMaterialNeedOccurrence includes semantic kind, authority, person/association, cause, EvidenceOrder, dowry terms where applicable, and evidence.

This is already a bounded typed delayed/context process partition. DEC-0014 explicitly says no generic pending-demand, requisition, budget, obligation, or adoption state is introduced.

### 6.4 Periodic maintenance

- consumption occurs each cycle and needs no pending record;
- attitude decay derives from Cycle % 5 and current attitudes;
- Household lifecycle/formation/lineage reactions close in the same cycle and leave no valid pending closure at a safe boundary.

### 6.5 External future CycleInput

Future CycleInput/response/policy choices supplied by the caller are not stored in Simulation. VS-SFL-082 requires the same future inputs/configuration to be applied to both runs; it does not require a checkpoint to predict unknown caller choices.

## 7. E — ID, order, and configuration frontier

The frontier is distributed.

### Allocated/generated IDs

- PersonId — fixture/external; no runtime allocator.
- DwellingId — fixture/external; no runtime allocator.
- GrainInput.Id — fixture/external schedule identity; no runtime allocator.
- CandidateId — caller/fixture declared; no runtime allocator. Existing candidate set must be retained to enforce uniqueness and preserve formation semantics.
- RelationId — WorldState.nextRelation.
- EvidenceId — EpistemicState.nextEvidence.
- ProposalId — external proposals plus Simulation.nextProposal for generated proposals; Simulation.usedProposals is also required because old arbitrary IDs remain invalid even below the current frontier.
- EventId — Simulation.nextEvent.
- HouseholdId — HouseholdState.nextHousehold.
- WarrantId — HouseholdState.nextWarrant.
- AssociationId — HouseholdState.nextAssociation.
- CommitmentId — HouseholdState.nextCommitment.
- HouseholdHeadRoleId — HouseholdState.nextHeadRole.

### Order

- Cycle is the primary semantic time coordinate.
- ReactionIndex orders consequential transitions inside a cycle and is stored on events/evidence orders.
- At a valid checkpoint, reaction closure has completed. next RunCycle resets the mutable reactionIndex to zero; the closed prefix's order survives in history.
- ProposalId is used as the deterministic technical seed order where no stronger semantic priority decides.
- Stable-ID fallback use must remain disclosed, and renaming sensitivity is accepted only inside those explicit fallback domains.

### Configuration/rules

- Configuration.Version is a caller-supplied configuration label and is emitted in history.
- Configuration.RulesVersion currently names inherited S1/S2-level rules.
- HouseholdRulesVersion and HeadRulesVersion are implementation constants used by routing to label S3/S4 meanings.
- Scenario configuration labels do not select semantics.
- There is no single persisted composite kernel-ruleset identifier today.

Slice-5 persistence therefore needs an exact compatibility story for both the configuration label and the active rule implementation identity. The accepted contract requires rule/configuration version, but it does not prescribe one serialization field or upgrade policy.

### Max-ID reconstruction judgment

| Frontier | Max-existing reconstruction today | Exact-continuation judgment |
|---|---|---|
| EvidenceId | Unsafe: superseded held facts are removed while frontier advances | Persist nextEvidence exactly |
| ProposalId reuse | Max alone is insufficient because arbitrary old IDs in usedProposals remain forbidden | Persist usedProposals and exact/generated frontier |
| Relation/Event/Household/Warrant/Association/Commitment/HeadRole | Current safe-boundary retention makes max+1 appear equivalent in ordinary promoted code | Do not adopt heuristic as persistence authority; persist exact frontier required by accepted checkpoint contract |
| CandidateId | No allocator; caller declares IDs and uniqueness is against retained set | Persist candidate referent set |
| GrainInput.Id | No allocator; identity/order is part of pending schedule | Preserve exact pending IDs |

## 8. F — Cache/index/projection inventory

There is currently little actual cached derived state; most projections recompute.

- WorldSnapshot: discard/rebuild from WorldState + cycle.
- EpistemicSnapshot/ActorEpistemicState: discard/rebuild from EpistemicState facts + candidate referents + cycle. Candidate/Household/Head Recognition is derived.
- HouseholdSnapshot: discard/rebuild from HouseholdState + cycle.
- Participants(H): recompute from Associations where End is null.
- DerivedFrom/AncestorOf: recompute from LineageWarrant records.
- ExposedCapacity/MobilizableCapacity: recompute from current people + active commitments/associations; DEC-0013 and S4-186 explicitly forbid treating capacity as authoritative wealth.
- HouseholdFundingResult: transaction-scoped evaluation result; recompute at precommit from live state. A committed event may retain the final funding provenance as history.
- resolution dependency components/fallback projections: transient recomputation from current accepted attempts and state.
- HouseholdProjectionKey: transient normalized comparison projection; not retained authority.
- PersonalDecisionInputs and feasible/generated candidate sets: per-cycle captured/derived inputs, not persistent indexes.
- CandidateRecognition: recompute from candidate referent + actor-held facts.
- Provision Context "now": recompute from world/household/head state; the historical refusal Context itself is authoritative baseline and is not a cache.
- decisionSnapshot/decisionEpistemic and decisionBaselines inside RunCycle: transient same-cycle captures, impossible at a valid safe checkpoint.

Executable rebuild evidence already exists for immutable snapshot isolation, noninterfering readers, detached HouseholdState.Copy replacement, derived lineage/capacity queries, and structural absence of hidden behavior-affecting caches. Slice-5 still needs the stronger VS-SFL-084 stable-boundary discard/rebuild continuation witness across every declared derived surface.

## 9. G — Source pressure

### High-confidence change

| Source | Why pressure is high |
|---|---|
| Simulation.cs and/or a new Simulation checkpoint partial | Capture/restore entry point, safe-boundary gate, configuration/schedule ownership, reconstruction without treating original fixture as current authority |
| Execution.cs and/or checkpoint partial with access to its fields | cycle, semantic event prefix, nextEvent, nextProposal, usedProposals, boundary/fault validation |
| State.cs | exact WorldState capture/restore including nextRelation; pending schedule/config records currently also live here as public types |
| EpistemicState.cs | exact facts, candidate referents, and nextEvidence restore; public EpistemicSnapshot is insufficient |
| HouseholdState.cs | Supports plus all typed Household state and allocator frontiers are required; public HouseholdSnapshot is insufficient |
| new Slice-5 checkpoint/continuation acceptance tests and independent oracle(s) | VS-SFL-082/083/084 need true round-trip, omission mutants, exact suffix, safe-boundary rejection, and rebuild equivalence |
| acceptance structural audit/adaptation surface | Any changed private-authority inventory must preserve S1-084/S3-093/S4-171 semantics through reviewed lossless adaptation rather than weakening the frozen witness |

A dedicated checkpoint record/codec/source file is likely cleaner than overloading observation snapshots, but exact file layout is implementation-local and this report does not prescribe it.

### Conditional / watch

| Source | Watch condition |
|---|---|
| MaterialRecovery.cs | if pending GrainInput representation moves away from InitialWorld full-schedule retention |
| HouseholdExecution.cs | if stable-boundary capture hooks or candidate/Supports restoration require a bounded integration seam; no social rule change expected |
| ProvisionReconsideration.cs | if round-trip tests expose missing typed baseline/provenance; do not add a generic demand process |
| HouseholdHeadState.cs | record shapes already contain the needed role/transition provenance; change only if serialization needs a lossless explicit representation |
| HouseholdFunding.cs | ProvisionRefusal/HMNO/ProvisionOrigin are checkpoint content; no funding semantics should change |
| Decisions.cs / EpistemicState polymorphic declarations | serializer support for ActionTerms/FactualProposition may need auditing; semantic type set must remain closed/explicit |
| HouseholdProjection.cs | useful reference for semantic normalization, but should not be repurposed as checkpoint encoding |
| ResolutionDependencies.cs / HouseholdResolution.cs | verify detached replay still behaves identically after restore; do not turn projection copies into restore authority |
| VerificationAccess.cs | only if independent omission/rebuild mutants need narrowly scoped internal access |
| README/docs | describe the eventual public continuation boundary after implementation, not before authority/acceptance freezes it |

### No expected semantic change

- Agency.cs scoring/selection rules;
- PersonalDecisionInputs.cs semantic observation boundary;
- HouseholdRules.cs formation/participation rules;
- HouseholdPriorities.cs accepted ordering;
- HouseholdCollectiveRules.cs eligibility semantics;
- HouseholdFunding allocation semantics;
- Head appointment/succession semantics;
- ordinary transaction meanings;
- accepted resource scaffold.

A checkpoint implementation that needs to change these to make save/load pass has crossed out of Discovery B's expected architecture and should escalate.

## 10. H — Checkpoint representation hazards

1. **Snapshot-only persistence.** Serializing WorldSnapshot + EpistemicSnapshot + HouseholdSnapshot loses multiple authoritative counters, candidate referents, Supports, and proposal/event frontier state.

2. **Max-ID reconstruction.** It is concretely wrong for EvidenceId and semantically unjustified for other frontiers even where current retention happens to make max+1 equivalent.

3. **Omitting usedProposals.** nextProposal alone does not preserve the rule that an arbitrary previously consumed external ProposalId can never be reused.

4. **Treating InitialWorld as current truth.** Current world/epistemic/Household state supersedes fixture construction state. Only still-future schedule/configuration portions remain future-causal.

5. **Ignoring pending schedule identity/order.** GrainInput Id determines same-cycle deterministic application order and must survive.

6. **Omitting subjective state.** Objective world state without held KnownFacts/provenance/candidate referents changes future Recognition, communication, formation, and mediated action gates.

7. **Omitting refusal context.** ProvisionRefusal Context, EligibleSupportCohort, and MaterialNeedChange are exactly the historical state DEC-0014 made future-causal.

8. **Role-as-occupant shortcut.** Current occupant without persistent role identity, LastTransition, HeadTransitions, and actor-held HeadRoleFacts loses causal/Recognition state.

9. **Persisting derived capacity/Recognition as authority.** MobilizableCapacity and Recognition must rebuild from authoritative backing. A stale serialized value must never override backing records.

10. **Checkpointing mid-cycle.** accepted proposals, captured response payloads, moved-person conflict state, live funding, decision baselines, AttitudeBatch, automatic-reaction work, and reactionIndex are transient. There is no accepted resumable microstep semantics. VS-SFL-082 requires rejection.

11. **Restoring a faulted instance as valid.** A failed cycle leaves only the previously published stable snapshot plus partial diagnostic history; the live instance is explicitly non-resumable.

12. **Replay-to-restore.** Replaying pre-checkpoint history risks consuming IDs twice, reapplying material effects, reacquiring evidence, repeating due reviews, and duplicating automatic reactions. Current typed state is authoritative; semantic history is provenance.

13. **Event-sourced architecture creep.** Retaining SemanticEvent history does not authorize making the event log the sole current-state representation. ADR-0004 explicitly rejects that silent shift.

14. **Collection-order serialization.** Dictionary/hash-set JSON order must not become tie-breaking or evidence precedence.

15. **Configuration/rule conflation.** Configuration.Version is not the rules selector. A checkpoint that stores only the scenario label cannot prove code/rule compatibility.

16. **Using HouseholdProjectionKey as serialization.** It intentionally normalizes fresh identities, which would destroy exact suffix identity.

17. **Persisting verification Challenge as social state.** ReactionChallenge is a mutant seam. Either constrain normal checkpoint tests to None or carry it explicitly in test harness state; do not let it become production simulation authority.

18. **History pruning without reference analysis.** live debts/favours/warrants/roles/evidence/provision baselines retain EventId references. Removing historical events without an accepted equivalent reference/provenance representation can break causal resolvability and suffix/history equivalence.

## 11. I — Delayed-process architecture pressure

### What exists now

Current future work is represented by four bounded patterns:

1. immutable scheduled exogenous input: GrainInput;
2. typed time-conditional relation state: Debt.CommittedCycle + DueReviewed;
3. typed historical reconsideration baseline: ProvisionRefusal + HouseholdMaterialNeedOccurrence;
4. periodic rules derived from Cycle: consumption and attitude decay.

No stable boundary retains an executable closure, task stack, response queue, unresolved proposal, automatic-reaction queue, or coroutine.

### What Slice 5 appears to require

The accepted continuation contract requires a serializable future-work boundary, but the current v0 mechanics can be represented losslessly with existing typed state plus the pending input schedule and exact ID/config frontiers.

There is no accepted need for:

- a generic scheduler;
- a universal Process base class;
- a pending-demand/obligation queue;
- an event-sourced current-state model;
- a general economic workflow engine.

If a future Slice-5 acceptance candidate introduces one specifically named delayed process with identity/cancellation/revalidation semantics not expressible by the existing records, a new bounded typed process partition may be justified. That is a conditional pressure, not authority supplied by the current task.

### Slice-size classification

**SUBSTANTIAL KERNEL EXTENSION — NOT ARCHITECTURE REDESIGN.**

Reasons:

- checkpoint/restore is already anticipated by ADR-0004 and SPEC §9.6;
- existing typed partitions and exact Copy methods align with capture/restore;
- current delayed mechanics already have serializable typed causal state;
- no new social semantics or generic scheduling architecture is necessary.

It is still substantial because correctness spans every promoted slice, three authoritative domain partitions, semantic-history continuity, schedule state, seven-plus identity families, proposal reuse state, configuration/rule compatibility, safe-boundary validation, omission mutants, and cache-rebuild equivalence.

---

# 12. Required final inventories

## 12.1 Exhaustive future-causal state table

| Owner / item | Classification | Why it matters / restore note |
|---|---|---|
| WorldState.People | Authoritative / must persist | Id/Sex/Grain/NeedsGrain future-causal; Name part of exact semantic/knowledge content |
| WorldState.Dwellings | Authoritative / must persist | destination/reference domain |
| WorldState.Residences | Authoritative / must persist | movement, formation, agency gates |
| WorldState.Attitudes | Authoritative / must persist | scoring/gates/ties/decay/cooldown context |
| WorldState.Kinships | Authoritative / must persist | marriage/tie gates |
| WorldState.Marriages | Authoritative / must persist | eligibility/ties plus Origin provenance |
| WorldState.Debts | Authoritative / must persist | balance, due timing/review, origin |
| WorldState.Favours | Authoritative / must persist | capacity/call/cancellation, origin |
| WorldState.nextRelation | Authoritative / must persist | hidden RelationId frontier |
| EpistemicState.facts | Authoritative / must persist | subjective future behavior, staleness, communication, Recognition |
| KnownFact EvidenceId/proposition/provenance/order/hops | Authoritative / must persist | evidence identity and precedence are causal |
| EpistemicState.candidates | Authoritative / must persist | candidate core/live state affects Recognition/formation; may be declared after init |
| EpistemicState.nextEvidence | Authoritative / must persist | hidden frontier; max-held reconstruction unsafe |
| HouseholdState.Households | Authoritative / must persist | identity/lifecycle and timing |
| FormationWarrants | Authoritative / must persist | formation provenance and future lineage/entry basis |
| SustainingParticipant Associations | Authoritative / must persist | current participation and exact historical transmission |
| ParticipationWarrants | Authoritative / must persist | entry provenance |
| ParticipationEndWarrants | Authoritative / must persist | exit/lineage provenance |
| ContinuationWarrants | Authoritative / must persist | identity continuity chain |
| LineageWarrants | Authoritative / must persist | accepted lineage state/query backing |
| HouseholdProvisionCommitments | Authoritative / must persist | future funding/capacity and provenance |
| HouseholdState.Supports | Authoritative / must persist | future formation/entry/lineage evidence; omitted from snapshot |
| HeadRoles | Authoritative / must persist | persistent role identity/occupancy/origin/LastTransition |
| HeadTransitions | Authoritative / must persist | transition/consent/provenance history |
| ProvisionRefusals | Authoritative / must persist | cooldown/context delayed state |
| ProvisionRefusal.EligibleSupportCohort | Authoritative / must persist | detects new/re-entered support need relative to refusal |
| ProvisionRefusal.MaterialNeedChange | Authoritative / must persist | historical context-change fact and provenance |
| nextHousehold | Authoritative / must persist | HouseholdId frontier |
| nextWarrant | Authoritative / must persist | WarrantId frontier |
| nextAssociation | Authoritative / must persist | AssociationId frontier |
| nextCommitment | Authoritative / must persist | CommitmentId frontier |
| nextHeadRole | Authoritative / must persist | HouseholdHeadRoleId frontier |
| Simulation.cycle | Authoritative / must persist | all temporal rules/order timestamps |
| SemanticEvent history prefix | Authoritative semantic history / persist | causal references/public history/exact continuation; never replay as current-state authority |
| Simulation.nextEvent | Authoritative / must persist | EventId frontier |
| Simulation.usedProposals | Authoritative / must persist | exact proposal-reuse prohibition |
| Simulation.nextProposal | Authoritative / must persist | generated ProposalId frontier |
| pending GrainInput schedule | Authoritative / must persist | future exogenous work and deterministic same-cycle order |
| Configuration.Version | Authoritative continuation metadata / must persist | exact future history/provenance label |
| active rule identity/compatibility | Authoritative continuation metadata / must verify | per-domain rules are code constants/routing; accepted checkpoint contract requires rule identity |
| CandidateId existing set | Authoritative / must persist | no allocator, uniqueness and formation referents depend on retained declarations |
| ReactionIndex live field | Transient in-cycle; not a separate safe-boundary future frontier | next cycle resets to 0; historical indices remain on events |
| faulted | Invalid checkpoint state | faulted cycle is non-resumable; do not serialize as successful checkpoint |
| ReactionChallenge | Unclear/test-only escalation | behavior-affecting mutant seam; must be explicitly excluded from production semantics |
| CycleInput and policy/response maps | External/transient | caller supplies each cycle; no persistent actor-policy memory in current kernel |
| accepted proposals/response payloads/live funding/moved set/AttitudeBatch | Transient in-cycle only | cannot exist in a valid safe checkpoint |

## 12.2 Rebuildable-state table

| Surface | Rebuild from | Stale influence allowed? | Existing evidence |
|---|---|---|---|
| WorldSnapshot | WorldState + cycle | No | immutable snapshot isolation tests |
| EpistemicSnapshot | facts + candidate referents + cycle | No | EpistemicState.Of/Snapshot; observer noninterference |
| CandidateRecognition | candidate referent + held facts | No | Recognition tests/metamorphics |
| HouseholdRecognition | held HouseholdExistenceFacts | No | household epistemic tests/oracle |
| HeadRecognition | held HeadRoleFacts | No | Slice4 knowledge/oracle tests |
| HouseholdSnapshot | HouseholdState + cycle | No | Snapshot method; detached-copy assurance |
| Participants(H) | Associations | No | direct query + structural/oracle checks |
| MobilizableCapacity | world people + active commitments/associations | No | S3/S4 derived-capacity requirements; Slice4 oracle |
| ExposedCapacity | Person grain/NeedsGrain | No | funding oracle |
| DerivedFrom | LineageWarrants | No | S3 rebuild requirements |
| AncestorOf | transitive traversal of LineageWarrants | No | S3 direct-vs-transitive checks |
| funding plan before commit | live world + HouseholdSnapshot + authority + explicit private term | No | precommit revalidation/oracle |
| dependency components/fallback probes | current accepted attempts + authoritative state | No | detached resolution machinery |
| HouseholdProjectionKey | detached authoritative projection | Not stored | commutativity/fallback verification only |
| decision candidate/feasibility sets | stable decision snapshot + declared policy/epistemic inputs | No | trace/oracle tests |
| KnowledgeOf legacy store | ParticipationFacts/history for observer continuity | Must not affect behavior | current implementation never reads old entries for decisions |
| published snapshots | live partitions after stable closure | No | stable-publication architecture and tests |

## 12.3 Delayed-work inventory

| Delayed/time-based item | Current representation | Persistence requirement | Generic process needed? |
|---|---|---|---|
| future exogenous grain | InitialWorld.Inputs with Id/Cycle/Person/Delta | preserve exact remaining work/order plus cycle, or full schedule + cycle | No |
| debt social-due review | Debt.CommittedCycle, DueReviewed, Remaining, Origin | persist Debt + cycle | No |
| provision reconsideration cooldown | ProvisionRefusal.Cycle/Event/Context | persist baseline | No |
| new Household material-need context | ProvisionRefusal.EligibleSupportCohort + MaterialNeedChange | persist occurrence/provenance | No; DEC-0014 rejects generic demand queue |
| attitude decay cadence | cycle modulo 5 | persist cycle + attitudes | No |
| consumption | next cycle step | persist cycle + people | No |
| Household/reaction closure | same-cycle transient only | checkpoint forbidden until closed | No |
| future caller CycleInput | external input to paired run | apply identically after restore | No stored process under current API |
| future RNG work | none implemented | none today; new state class if introduced | Escalation if added |

## 12.4 ID/order/config inventory

| Identity/order | Owner | Current source | Restore requirement |
|---|---|---|---|
| PersonId | fixture/live world | InitialWorld then WorldState | exact set/value |
| DwellingId | fixture/live world | InitialWorld then WorldState | exact set/value |
| RelationId frontier | WorldState | nextRelation | exact frontier |
| EvidenceId frontier | EpistemicState | nextEvidence | exact frontier; never max-current |
| CandidateId | declared referent | candidates | exact set; no allocator |
| ProposalId used set | Simulation | usedProposals | exact set |
| ProposalId generated frontier | Simulation | nextProposal | exact frontier |
| EventId frontier | Simulation | nextEvent | exact frontier |
| HouseholdId frontier | HouseholdState | nextHousehold | exact frontier |
| WarrantId frontier | HouseholdState | nextWarrant | exact frontier |
| AssociationId frontier | HouseholdState | nextAssociation | exact frontier |
| CommitmentId frontier | HouseholdState | nextCommitment | exact frontier |
| HouseholdHeadRoleId frontier | HouseholdState | nextHeadRole | exact frontier |
| GrainInput.Id | pending schedule | InitialWorld.Inputs | exact identity/order |
| Cycle | Simulation | cycle | exact |
| ReactionIndex | SemanticEvent history / live in-cycle field | per-event plus reactionIndex | checkpoint only after closure; future cycle restarts 0 |
| fallback ordering | semantic priorities then stable technical IDs | ProposalId/candidate keys/person IDs where accepted | preserve all relevant identities and markers |
| Configuration.Version | Simulation.initial.Configuration | caller label | exact suffix metadata |
| S2/S3/S4 rule labels | code constants + RulesVersionFor routing | implementation identity | checkpoint compatibility must verify correct rule set |

## 12.5 Source pressure summary

| Classification | Sources |
|---|---|
| High-confidence change | Simulation checkpoint surface; Execution/Simulation-level state capture; State.cs; EpistemicState.cs; HouseholdState.cs; Slice-5 acceptance/omission/rebuild tests and independent oracle; any required reviewed structural-audit adaptation |
| Conditional/watch | MaterialRecovery.cs; HouseholdExecution.cs; ProvisionReconsideration.cs; HouseholdHeadState.cs; HouseholdFunding.cs; polymorphic semantic record serialization in Decisions/Epistemic state; HouseholdProjection.cs; ResolutionDependencies.cs; VerificationAccess.cs; docs |
| No expected semantic change | agency/scoring, personal observation semantics, formation/participation rules, accepted priorities, funding algorithm, head/succession rules, lower-level transaction meanings |

## 12.6 Architecture hazards

- public snapshots mistaken for persistence authority;
- hidden allocator/frontier omission;
- max-ID reconstruction, especially EvidenceId;
- used ProposalId set loss;
- candidate referent loss;
- Supports loss;
- subjective state/provenance loss;
- refusal/material-need baseline loss;
- role identity/transition reduced to occupant;
- pending GrainInput loss/reordering;
- mid-cycle or faulted checkpoint;
- replaying history to rebuild current state;
- event-sourced current-authority drift;
- derived Recognition/capacity serialized and trusted when stale;
- JSON/dictionary order becoming semantic;
- configuration label mistaken for rules identity;
- HouseholdProjection identity normalization reused as checkpoint encoding;
- verification ReactionChallenge leaking into production semantics;
- historical event compaction that leaves live EventId references unresolved;
- broad process/scheduler framework added without an accepted delayed-mechanic need.

## 12.7 Escalation triggers

Stop and route through the appropriate semantic/verification/architecture authority if any implementation requires:

1. a checkpoint before stable reaction closure or resumable mid-cycle execution;
2. changing social/domain rules, scoring, priorities, Recognition, funding, role, or Household semantics to make restore work;
3. a new generic scheduler/process/obligation/demand framework;
4. event-log replay as the sole source of current state;
5. persisting a cache/projection as authoritative rather than rebuilding it;
6. dropping/renumbering causal EventIds or compacting history without a lossless accepted reference scheme;
7. reconstructing identity frontiers from max values instead of preserving exact state;
8. mutable insertion/cancellation of future schedule entries, which would require explicit consumed/pending identity and ordering semantics;
9. introducing RNG/random state;
10. changing Configuration.Version from a provenance label into a semantic rules selector;
11. adding/removing private authoritative fields in a way that fires the S1-084 / S3-093 / S4-171 structural-authority adaptation gate;
12. treating ReactionChallenge or another verification seam as normal simulation state;
13. relying on original fixture objects instead of restored live state;
14. any delayed process whose identity, due ordering, cancellation, revalidation, or provenance is not uniquely determined by accepted authority.

## 12.8 Final slice-size classification

**SUBSTANTIAL KERNEL EXTENSION.**

The work fits the accepted reference-kernel architecture and does not justify an architecture redesign. It is larger than a narrow bounded feature because exact continuation is a cross-cutting kernel property: all authoritative partitions, semantic history references, pending schedule, configuration/rule identity, and distributed identity frontiers must round-trip together, while all derived views must remain discardable and every mid-cycle/runtime-mechanics shortcut must remain non-authoritative.

No generic delayed-process abstraction is presently required. The safest reading of current accepted authority is: extend the existing typed state with an explicit safe-boundary continuation representation and independent verification, preserving current semantic partitions and rebuilding derived views.