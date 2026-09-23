# SFL v0 Slice 2 — Accepted Authority Inventory

**Status:** DISCOVERY RETURN — READ-ONLY AUTHORITY INVENTORY  
**Commission:** tasks/research/SFL_V0_SLICE2_DISCOVERY_A_AUTHORITY.md  
**Implementation authority:** none  
**Semantic/design authority:** none  
**Synthesis owner:** Master Architect  
**Return branch:** research/slice2-authority-inventory-return  
**Exact base SHA:** ece7d45f48512f9ddf3c0dc82034e0317265b36e  
**Base:** current main at execution start  
**Date:** 2026-09-23

## 1. Scope and authority discipline

This report answers one question only:

> What subjective-knowledge, communication, and recognition semantics are already accepted for Slice 2?

It does not design Slice 2, choose data structures, reclassify verification rows, infer mechanics from the Birth Run, or promote conceptual research.

Repository authority was applied in the order stated by 00_START_HERE.md. The controlling semantic source for this inventory is the accepted SFL v0 specification:

- specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md
- status: ACCEPTED
- content SHA: a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52

Accepted architectural constraints used where they govern interpretation:

- decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md — c57a1efaa3deb93d2dcdab17e61541d68d2b1502
- architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md — 66cfd55f8b960ff5664638c41c0e731257902be5
- architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md — aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229
- architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md — 9ce78a311f006215a2afe3575065005e74c4e916
- architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md — 43eedd7eb49e1eae035010332883ed2d8726d451

Accepted verification design was consulted only to clarify already-accepted distinctions:

- plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md — d8f87dea9569d41481850c7327a025c44d6c3358
- plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md — efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766

Operational/context artifacts retrieved as instructed but not treated as simulation authority:

- AGENTS.md — ee9f27664b912e07eb0a8fedc819a6f5a05ed257
- 00_START_HERE.md — cf11d0ce07b72fbe97577575d419df8f3e3a8ccf
- plans/CURRENT_PHASE.md — d5410e4da141322c2f7f1c60d43262ce880e3be4
- tasks/research/SFL_V0_SLICE2_PREIMPLEMENTATION_DISCOVERY.md — 6ec8796f56b38607b03c95ba76d335f3eb4c33b7
- plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md — 6dd411d9a6bfd7f882418f107a3557d8ab4e3059

The new conceptual tablet collections were not used as authority.

A chronological caution matters. DEC-0001 and ADR-0002 originally left household-recognition algorithms and the subjective-information model undecided. SPEC-SFL-0001 was accepted later and supplies the bounded v0 semantics inventoried below. The older “not decided” clauses therefore do not erase the later accepted v0 specification.

## 2. Executive authority map

Accepted SFL v0 already fixes all of the following:

1. **Objective state and subjective state are different semantic layers.** Engine truth does not automatically become actor knowledge.
2. **KnownFact is actor-relative.** It is a factual proposition held by an actor and it carries provenance.
3. **Recognition is not KnownFact.** Recognition is a social interpretation of a collective/authority proposition, with discrete evidence-backed states Unknown, Recognized, and Contested.
4. **Recognition is not confidence, attitude, approval, or obedience.** It does not decay with attitude.
5. **Knowledge is sparse by route.** Actors automatically know their own objective state, relations/claims to which they are direct parties, and proposals/events in which they directly participate. Other facts require valid event-specific observation or communication.
6. **Co-residence is not omniscience.** Engine-side household/head state is not globally exposed to actors.
7. **Communication transmits only a proposition the sender currently holds.** It carries sender provenance and underlying source/event provenance where available.
8. **Communication normally costs the sender's one voluntary personal initiative for the cycle.**
9. **Stale subjective state persists.** It does not passively synchronize to objective state.
10. **Evidence precedence is based on underlying event/observation order, not message arrival time.**
11. **Unresolved incompatible recognition evidence becomes Contested.** Arbitrary actor/message/stable-ID winner selection is not an accepted substitute.
12. **Subjective state is causal.** Recognition and known participation facts can determine whether household-specific candidates are available.
13. **Subjective gating does not replace authoritative revalidation.** Actors deliberate from an actor-visible committed snapshot; proposals are centrally revalidated against objective action-relevant preconditions before commit.
14. **Resolver omniscience is bounded at the epistemic interface.** Direct participants learn Declined, Unable(reason), and InvalidatedAtResolution(reason), but reasons must not leak unrelated private state.
15. **An uncommitted proposal effect is not an objective fact.** The proposal/refusal/failure event itself may nevertheless become known to direct participants.
16. **Cycle visibility is fixed.** Authoritative within-cycle commits may affect central revalidation and automatic reactions immediately, but they do not create a fresh actor-visible completed-cycle state or a new same-cycle voluntary activation before stable closure.
17. **Decision/history provenance must expose relevant subjective inputs.** Consequential histories also retain causal predecessors and rule/configuration version.
18. **Trust, deliberate lying, invented claims, rumor mutation, reputation, strategic multi-step planning, and stochastic behavior are not part of v0.**

Those are semantic constraints. They do not by themselves select a concrete class layout, storage scheme, index, serialization format, or generalized epistemic logic.

## 3. Concept-by-concept accepted semantics

| Concept | Accepted meaning / rule | Exact authority |
|---|---|---|
| Objective state / engine truth | Material/institutional truth is authoritative execution state, distinct from what any actor knows. Current typed in-memory records are authoritative in the reference kernel. | SPEC §1; ADR-0004 Decision |
| Actor-visible state | Agents/roles read committed state through the cycle's common decision snapshot. A completed actor-visible cycle state is published only after resolution/reaction closure. | SPEC §5.1, §9.1; ADR-0004 |
| KnownFact | “Factual proposition held by an actor, with provenance.” It is subjective state, not a live alias to engine truth. | SPEC §6.1 |
| Recognition | “Social interpretation of a collective/authority proposition.” Discrete, evidence-backed, provenance-bearing; not scalar confidence, attitude, approval, or obedience. | SPEC §6.1 |
| Recognition.Unknown | Actor has no accepted recognition basis for the proposition. | SPEC §6.1 |
| Recognition.Recognized | Actor has sufficient currently accepted evidence for the proposition. | SPEC §6.1 |
| Recognition.Contested | Actor holds incompatible evidence that prevents safe reliance on the proposition for authority-dependent action. | SPEC §6.1 |
| Required recognition propositions | Candidate organization C is the same prospective founding organization; household H exists/continues; P occupies H's head/representative role within scope. | SPEC §6.2 |
| CandidateRecognition | Ephemeral, provenance-bearing recognition proposition for a pre-household candidate. Grants no household powers and is not household identity. | SPEC §6.3 |
| Automatic acquisition | Actor automatically knows own objective state; relations/claims where actor is a direct party; proposals/events where actor directly participates. | SPEC §6.4 |
| Other acquisition | Other facts require valid event-specific observation or communication. Co-residence is insufficient for omniscience. | SPEC §6.4 |
| Communication | CommunicateClaim/Inform transmits a factual or recognition proposition the sender currently holds. | SPEC §5 required action meanings; §6.4 |
| Communication provenance | Carries sender plus underlying source/event provenance where available. Event-backed reports can support recognition if not defeated by stronger/newer contradiction. | SPEC §6.4 |
| Communication cost | Normally consumes the sender's one voluntary personal initiative. | SPEC §5; §6.4 |
| Passive synchronization | Forbidden by accepted semantics: subjective state does not passively synchronize. | SPEC §6.5 |
| Stale state | Stale information persists until displaced or contested. | SPEC §6.5 |
| Evidence time | Underlying event/observation order outranks later message-arrival time. | SPEC §6.5 |
| Direct evidence precedence | Newer direct participation/observation supersedes older incompatible information. | SPEC §6.5 |
| Report precedence | Newer event-backed communication may supersede older reports. | SPEC §6.5 |
| Unresolved conflict | Incompatible evidence not resolvable by provenance/order becomes Contested rather than silently selecting a claim. | SPEC §6.5 |
| Recognition vs attitude | Recognition does not decay with attitude; dislike or refusal does not semantically erase recognition. | SPEC §6.1, §6.5, §6.6; verification family VS-SFL-035 clarifies |
| Household action gate | Engine-side H does not expose household-specific actions globally. Intentional action toward H as household requires recognizing H. Using P as H authority channel requires recognizing P in relevant role/scope. | SPEC §6.6 |
| Ordinary person-person actions | Remain available independently of household recognition. | SPEC §6.6 |
| Mediated marriage subjective route | Groom must know bride-to-H participation fact and recognize H plus current head/scope; absent that route, mediated candidate is unavailable. | SPEC §4.2, §6.6 |
| Response subjective inputs | ResponseDecisionContext reads target subjective state from the same committed cycle snapshot used by personal/household deliberation. | SPEC §5.1 |
| Failed-attempt knowledge | Direct participants learn Declined, Unable(reason), InvalidatedAtResolution(reason). | SPEC §6.7 |
| Bounded failure reasons | Reasons expose only what the interaction makes knowable; resolver omniscience must not leak unrelated private state. | SPEC §6.7 |
| Proposed vs objective fact | Proposed-but-uncommitted effect never becomes objective fact. Proposal/refusal/failure event may still be known to direct participants. | SPEC §6.7 |
| Candidate accessibility | ADR-0002 requires generation of only contextually relevant and accessible candidates; SPEC then supplies concrete subjective gates. | ADR-0002; SPEC §5, §6.6 |
| Proposal semantics | Interpersonal/collective actions are attempts/proposals, not unilateral mutation. | ADR-0002; ADR-0004 |
| Commit authority | Every proposal is revalidated immediately before commit against all action-relevant preconditions. | SPEC §9.2; ADR-0004 |
| Decision provenance | Decision trace records candidates, gates/exclusions, named score components, selection, and relevant subjective inputs. | SPEC §5, §9.4 |
| Semantic history | Consequential records retain IDs, time, participants/context, failure/validation, effects, causal predecessors, rule/config version, and fallback marker where used. | SPEC §9.4 |
| Stable-cycle visibility | Within-cycle commits are authoritative for resolver/reactions but not a fresh actor-visible completed cycle state; no same-cycle voluntary reactivation before stable closure. | SPEC §9.1; ADR-0004 |
| Checkpoint relevance | When checkpoints arrive, all future-influencing subjective knowledge/recognition must be checkpointed; caches/indexes remain rebuildable/non-authoritative. | SPEC §9.6; this execution mechanism belongs to later Slice 5 |

## 4. Distinctions that Slice 2 must not collapse

### 4.1 Objective truth is not KnownFact

SPEC-SFL-0001 begins by requiring “subjective knowledge/recognition distinct from objective state.” ADR-0004 separately declares the current typed in-memory records authoritative execution state.

Therefore an objective record may exist without an actor knowing it. The converse is also possible in the temporal sense: an actor may retain stale subjective information after objective state has changed.

The accepted model does not authorize behavioral code to query the whole authoritative world and call the result actor knowledge.

### 4.2 KnownFact is not Recognition

KnownFact is a factual proposition held by one actor, with provenance.

Recognition is a social interpretation of a collective/authority proposition. It has the explicit Unknown / Recognized / Contested state model and is used where authority-dependent action must be safely available.

The spec does not assign the Recognition tri-state to KnownFact. Treating every KnownFact as Recognized/Contested would invent a rule not present in §6.1.

### 4.3 Recognition is not objective collective identity

A Household or head-role record can be objectively true while an outsider remains stale, unknown, or contested about it.

Conversely, an actor's Recognition record is not allowed to create the household, office, or authoritative state it describes.

CandidateRecognition makes the separation especially explicit: it is ephemeral evidence-backed subjective recognition, grants no household powers, and is not household identity.

### 4.4 Recognition is not attitude or compliance

The spec expressly says Recognition is not a scalar confidence score, attitude, approval, or obedience.

An actor may recognize H/head while disliking them or refusing a request. Recognition does not decay with attitude.

### 4.5 Provenance is semantic, not merely diagnostic

Provenance is required in the definitions and update rules, not just in logging:

- KnownFact carries provenance.
- Recognition retains provenance to supporting evidence/reports.
- CandidateRecognition is provenance-bearing.
- CommunicateClaim/Inform carries sender and underlying source/event provenance where available.
- Evidence ordering uses underlying semantic event/observation order rather than arrival order.
- Decision traces record relevant subjective inputs.
- Later warrants retain supporting event references.

A storage design may vary, but it must preserve enough identity/order/source information for those accepted semantics to be evaluated and audited.

### 4.6 Subjective gating and objective revalidation are complementary

The accepted architecture has two different jobs:

**Deliberation / candidate access**
- actor reads the common committed snapshot;
- only contextually relevant and accessible candidates are generated;
- accepted subjective prerequisites can suppress candidates before scoring.

**Resolution / commit**
- authoritative resolver revalidates all action-relevant preconditions against engine truth immediately before commit;
- accepted-but-now-incompatible proposals may become InvalidatedAtResolution.

Slice 2 therefore must not turn subjective knowledge into authoritative world truth, and it must not let the central resolver's omniscience leak backward into actor deliberation.

## 5. Accepted acquisition and update routes

### 5.1 Automatic direct knowledge

An actor automatically knows:

1. the actor's own objective state;
2. relations/claims in which the actor is a direct party;
3. proposals/events in which the actor directly participates.

This route is accepted and does not require communication.

Slice 1 already exercised the narrow failed-attempt subset: direct participants learn Declined, Unable(reason), and InvalidatedAtResolution(reason). That existing rule remains part of the accepted epistemic boundary.

### 5.2 Observation

For facts outside the automatic direct routes, the spec permits “valid event-specific observation.”

That phrase establishes observation as an accepted acquisition route, but the spec does not define a general perception/visibility system. This is recorded as a genuine accepted-authority gap below rather than filled here.

### 5.3 Communication

CommunicateClaim/Inform is an accepted action meaning.

It may transmit:
- a factual proposition; or
- a recognition proposition;

but only one the sender currently holds.

The message preserves:
- sender provenance; and
- underlying source/event provenance where available.

A communicated event-backed proposition may become sufficient recognition evidence when no stronger/newer contradiction exists.

Communication normally consumes the sender's one voluntary personal initiative. Responses remain a separate decision context and do not consume that initiative.

The spec explicitly excludes deliberate lying, invented claims, trust scoring, rumor mutation, and reputation from v0.

### 5.4 Staleness, supersession, and contest

There is no global synchronization pass that refreshes everyone's knowledge after an objective change.

Accepted ordering rules are:

1. stale information remains until displaced or contested;
2. semantic event/observation order beats message-arrival time;
3. newer direct participation/observation supersedes older incompatible information;
4. newer event-backed communication may supersede older reports;
5. incompatible evidence that cannot be resolved by provenance/order yields Contested rather than an arbitrary winner.

The canonical recognition verification family illustrates these exact accepted distinctions with stale head recognition, delayed old messages, and incomparable evidence. It is verification design, not a source of additional social semantics.

## 6. Accepted causal uses of subjective state

The spec already makes subjective state behaviorally causal.

### 6.1 General agency boundary

ADR-0002 requires only contextually relevant and accessible candidates to be generated. SPEC §5 requires categorical gates before scoring and records relevant subjective inputs in the decision trace.

### 6.2 Household-directed action

An engine-side household record does not globally expose household actions.

To intentionally act toward H as a household, an actor must recognize H.

To use P as H's authority channel, the actor must recognize P in the relevant head/representative role and scope.

Ordinary person-person actions are independent of household recognition.

### 6.3 Mediated marriage

The groom needs the bride-to-household participation fact plus Recognition of H and the current head/scope. Without that subjective route the mediated candidate is unavailable even if the objective household state would otherwise support it.

### 6.4 Formation recognition

For CandidateRecognition, a founder's own subjective state must contain uncontested evidence sufficient to establish the objective formation predicate for the proposed core. The founder does not need to know that the other founders also recognize C. The candidate label may not serve as evidence for itself.

### 6.5 Failure knowledge

Direct participants learn accepted failure outcomes, but only bounded reasons. This is the strongest already-executable example of the rule that the resolver may know more than the actor is allowed to learn.

## 7. Timing and visibility

The accepted cycle order is:

1. exogenous inputs;
2. maintenance;
3. derived refresh;
4. common committed decision snapshot;
5. personal/household deliberation;
6. responses;
7. priority/conflict resolution plus revalidation;
8. commit/failure;
9. automatic semantic reactions to closure;
10. publish/evaluate stable cycle-level state, record/refresh, advance.

Consequences for Slice-2 subjective state are already fixed at the architectural level:

- personal and response deliberation read the common committed snapshot;
- response contexts do not observe uncommitted effects of other proposals/responses;
- authoritative commits may immediately affect central revalidation and automatic reactions;
- those commits do not publish a fresh actor-visible completed-cycle state;
- no fresh same-cycle voluntary activation occurs before stable closure;
- next actor-visible completed-cycle state appears only after resolution/reaction closure.

This prevents message/knowledge update order inside one resolution pass from silently becoming a second voluntary-action opportunity.

## 8. Accepted exclusions and later-slice boundaries

The following are explicitly not v0 semantics and must not be invented by Slice 2:

- generic trust;
- deliberate lying or invented claims;
- rumor mutation;
- reputation;
- strategic multi-step planning;
- stochastic behavior.

The following accepted SFL v0 semantics exist, but their objective substrate/execution belongs to later Stage-4 slices under CURRENT_PHASE:

- household formation/continuity/capability — Slice 3;
- head/representative role turnover/succession — Slice 4;
- checkpoint/restore continuation — Slice 5.

Slice 2 may need epistemic machinery capable of representing the already-accepted propositions and provenance without pulling those later objective mechanics forward. This report does not choose how that staging is implemented.

Lineage has accepted objective provenance semantics, but SPEC §7.7.6 explicitly introduces no separate subjective RecognizesLineage state because no current v0 action depends on it.

## 9. Gap classification

Per the commission packet, apparent gaps are classified only as:
1. answered by accepted authority;
2. genuinely absent/ambiguous in accepted authority;
3. outside Slice 2.

No preferred repair is proposed.

### 9.1 Answered by accepted authority

| Question | Classification | Answer |
|---|---|---|
| Is objective state identical to actor knowledge? | 1 | No. They are explicitly distinct. |
| Does objective household/head state broadcast to all actors? | 1 | No. Subjective state does not passively synchronize. |
| What is KnownFact? | 1 | Actor-held factual proposition with provenance. |
| What is Recognition? | 1 | Evidence-backed social interpretation of collective/authority proposition. |
| What are Recognition states? | 1 | Unknown, Recognized, Contested with exact §6.1 meanings. |
| Is Recognition confidence/attitude/obedience? | 1 | No. |
| What does an actor know automatically? | 1 | Own objective state, direct-party relations/claims, directly participated proposals/events. |
| Can co-residence create omniscience? | 1 | No. |
| Can a sender invent a claim in communication? | 1 | No; sender transmits a proposition currently held. |
| Does communication retain provenance? | 1 | Yes, sender and underlying source/event where available. |
| Does communication cost initiative? | 1 | Normally one voluntary personal initiative. |
| Can an old late-arriving message overwrite a newer semantic event merely due to arrival time? | 1 | No. Underlying event/observation order governs. |
| What happens to unresolved incompatible recognition evidence? | 1 | Contested. |
| Does stale information auto-refresh? | 1 | No; it persists until displaced/contested. |
| Can Recognition gate action? | 1 | Yes; explicit household/authority and mediated-marriage gates exist. |
| Does subjective feasibility replace commit-time truth? | 1 | No; central revalidation remains authoritative. |
| Can failure reasons expose arbitrary resolver-private facts? | 1 | No; participant reasons are bounded to interaction-knowable information. |
| Is an uncommitted proposed effect an objective fact? | 1 | No. |
| When are fresh completed-cycle actor-visible states published? | 1 | Only after stable resolution/reaction closure. |

### 9.2 Genuinely absent or ambiguous in accepted authority

#### GAP-A1 — General KnownFact conflict/state model

The spec defines KnownFact as an actor-held factual proposition with provenance, but it does not give KnownFact the explicit Unknown / Recognized / Contested state model used by Recognition.

It also does not define a general-purpose state machine for incompatible factual propositions outside the places where such evidence feeds Recognition.

**Classification:** 2 — genuinely absent/ambiguous.

#### GAP-A2 — General nonparticipant observation eligibility

SPEC §6.4 says other facts require valid event-specific observation or communication, but it does not define a general perception/visibility model or enumerate which nonparticipant events are observable to whom.

**Classification:** 2 — genuinely absent/ambiguous.

#### GAP-A3 — Exhaustive evidence-strength ordering

The accepted rules define several precedence relations: semantic event order over message arrival, newer direct evidence over older incompatible information, newer event-backed communication over older reports, and Contested when provenance/order cannot resolve incompatibility.

They do not define a universal total order over every possible combination of direct observation, participation, reports, and recognition interpretations. The phrase “stronger/newer contradiction” is not expanded into a complete general evidence algebra.

**Classification:** 2 — genuinely absent/ambiguous beyond the explicitly accepted cases.

#### GAP-A4 — Autonomous communication choice policy

The action meaning, transmission constraint, provenance, and initiative cost are accepted. The spec does not provide a social-semantic rule saying when an actor chooses to communicate, which recipient is selected, or which held proposition is chosen for communication.

The reference scorer permits rule/configuration profiles, but numeric coefficients are laboratory configuration rather than independent social semantics.

**Classification:** 2 — genuinely absent/ambiguous if Slice 2 requires autonomous communication selection rather than explicitly exercised communication.

#### GAP-A5 — General proposition identity / contradiction vocabulary

The spec requires factual and recognition propositions and provenance-bearing comparison, but it does not define a complete general proposition ontology or universal contradiction/equivalence system.

ADR-0001 intentionally leaves exact schema open.

**Classification:** 2 — genuinely absent/ambiguous beyond the bounded propositions/rules already named by SPEC-SFL-0001.

#### GAP-A6 — Exact storage shape for epistemic provenance

The semantic requirement is answered: provenance must be retained. The exact record layout, index, serialization shape, or persistence representation is not accepted social semantics and is intentionally left to architecture/engineering within ADR-0001/ADR-0004 constraints.

**Classification:** 1 at the semantic level; not a missing social rule.

### 9.3 Outside Slice 2

| Topic | Classification | Reason |
|---|---|---|
| Generic trust model | 3 | Explicit v0 exclusion. |
| Deliberate lying / invented claims | 3 | Explicitly absent from v0 communication semantics. |
| Rumor mutation | 3 | Explicitly absent from v0. |
| Reputation system | 3 | Explicit v0 exclusion. |
| Rich episodic memory / forgetting model | 3 | No v0 subsystem; stale information persistence is already sufficient for the accepted v0 rule. |
| Strategic multi-step planning | 3 | Explicit v0 exclusion and later agency concern. |
| Stochastic cognition | 3 | Explicit v0 exclusion. |
| Household formation/continuity objective machinery | 3 | Stage-4 Slice 3. |
| Grounded household provision/capability | 3 | Stage-4 Slice 3. |
| Head office objective succession mechanics | 3 | Stage-4 Slice 4. |
| Checkpoint/restore implementation | 3 | Stage-4 Slice 5, though subjective state is already named as future-influencing checkpoint state. |
| General institutional recognition beyond the bounded SFL v0 household/authority propositions | 3 | Not selected by accepted v0 semantics. |
| Subjective lineage-recognition state | 3 | SPEC explicitly says v0 introduces none because no current action depends on it. |

## 10. Constraints to carry into Master Architect synthesis

These are not new requirements; they are the minimum lossless reading of accepted authority:

1. Do not implement KnownFact as a transparent reference to current engine truth.
2. Do not collapse KnownFact and Recognition.
3. Do not give KnownFact the Recognition tri-state unless separately promoted; the accepted spec does not say that.
4. Do not globally refresh actor knowledge after objective changes.
5. Do not infer knowledge from co-residence alone.
6. Do not discard source/event provenance needed to compare evidence.
7. Do not use message arrival time as semantic evidence time.
8. Do not resolve Contested recognition through arbitrary stable IDs or collection order.
9. Do not make Recognition a confidence score, attitude alias, approval flag, or obedience flag.
10. Do not expose household/authority candidates solely because the engine knows the objective record exists.
11. Do not let subjective gating bypass central authoritative revalidation.
12. Do not leak resolver-private facts through failure reasons.
13. Do not make communication a free broadcast action; the accepted default cost is one voluntary personal initiative.
14. Do not add lying, trust, rumor, reputation, rich memory, strategic planning, or stochastic behavior to close implementation gaps.
15. Do not pull household, office, or checkpoint objective mechanics forward solely to make Slice 2 easier to demonstrate.
16. Where the accepted authority is silent, preserve the silence for Master Architect synthesis rather than filling it with an implementation convenience.

## 11. Bottom line

Slice 2 is not starting from a vague instruction to “add knowledge.”

Accepted SFL v0 already specifies a bounded epistemic contract:

**authoritative world truth → actor-specific acquisition routes → provenance-bearing KnownFact / Recognition → stale/conflict ordering → subjective candidate/action gates → proposal → authoritative revalidation/commit → bounded participant learning → stable-cycle publication.**

The principal remaining authority gaps are not the existence of subjective knowledge, provenance, stale state, contested Recognition, communication cost, or subjective action gating; those are already accepted. The genuine gaps are narrower: general KnownFact conflict representation, general nonparticipant observation eligibility, exhaustive evidence-strength ordering beyond the named cases, autonomous communication selection, and a fully general proposition/contradiction vocabulary.

Those gaps should remain gaps until the Master Architect determines whether Slice 2 actually requires them to be resolved.
