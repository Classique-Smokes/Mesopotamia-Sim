# SFL v0 Slice 2 Discovery B — Implementation Surfaces

**Artifact:** `SFL_V0_SLICE2_DISCOVERY_B_IMPLEMENTATION_SURFACES.md`  
**Status:** DISCOVERY / IMPLEMENTATION SURVEY / NON-AUTHORITATIVE  
**Scope:** Map what verified Slice 1 already supplies in code and where Slice 2 creates bounded implementation pressure.  
**Explicit non-goal:** This survey does **not** design the Slice 2 extensions, choose schemas/APIs/algorithms, decide verification applicability, or promote new simulation semantics.

---

## 1. Baseline and authority boundary

This survey reads the canonical repository after verified Slice 1 promotion.

- Repository: `Classique-Smokes/Mesopotamia-Sim`
- Slice 1 verified candidate: `06e25644879dd8505e24fcaeb43256f69c29c15f`
- Canonical promotion merge: `262dc6e1d846761110fcd6a063bf8b4aa267b3dc`
- Frozen Slice 1 acceptance authority: `SFL-V0-S1-ACCEPTANCE-v1`
- Slice 1 completion status: **VERIFIED COMPLETE**
- Current project state: Slice 1 complete, Birth Run checkpoint closed, Slice 2 pre-implementation discovery ready.

Primary semantic/architectural authority consulted:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`

Slice-relevant planning/verification context consulted:

- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`
- `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
- `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`
- `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` — question-generation aid only; not authority.

### Relationship to the parallel verification-trigger survey

This document does **not** decide which frozen deferred verification obligations fire in Slice 2. In particular, household/head-dependent recognition cards may depend on later-slice substrate. Their applicability belongs in the verification-trigger discovery work. Here, deferred rows are used only as evidence that particular implementation capabilities were intentionally absent from Slice 1.

---

## 2. Executive finding

Slice 1 already provides most of the **execution architecture** Slice 2 needs:

1. an immutable committed objective-state view;
2. a narrow actor-specific decision-input boundary that prevents policy code from reading the objective world directly;
3. deterministic proposal / response / resolution / commit sequencing;
4. stable event identity, cycle/reaction ordering, causal predecessor references, and semantic history;
5. participant-only failed-attempt/outcome knowledge with bounded reasons;
6. full decision traces that record the subjective inputs used by policy;
7. a deterministic acceptance harness with observer-noninterference and provenance-oriented assertions.

What Slice 1 intentionally does **not** provide is the persistent epistemic substrate named by accepted SFL §6:

- persistent provenance-bearing `KnownFact` state;
- persistent `Recognition` state with `Unknown / Recognized / Contested` semantics;
- event-specific observation acquisition beyond direct participation;
- general `CommunicateClaim/Inform` propagation;
- staleness/conflict handling based on underlying evidence order;
- recognition-aware access/candidate gating backed by persistent actor-held evidence.

The implementation implication is therefore **bounded extension, not kernel replacement**. The highest-pressure surfaces are `State.cs`, `PersonalDecisionInputs.cs`, `Execution.cs`, `Decisions.cs`, `Agency.cs`, and `Simulation.cs`, plus the acceptance-test surface. `ResolutionDependencies.cs` is a conditional watch surface rather than a demonstrated Slice 2 redesign target. `MaterialRecovery.cs` has no direct Slice 2 pressure in the authority reviewed here.

---

## 3. Classification used in this survey

| Classification | Meaning |
| --- | --- |
| **REUSE** | Slice 1 already contains a suitable architectural seam or capability. |
| **BOUNDED EXTENSION PRESSURE** | Accepted Slice 2 semantics cannot be represented fully by the current code; this surface will need some extension, without this survey selecting its form. |
| **CONDITIONAL WATCH** | The surface may need adjustment depending on later applicability/interaction details, but the reviewed authority does not yet establish that change as necessary. |
| **PRESERVE** | Existing behavior/boundary is valuable to Slice 2 and should not be erased merely to add epistemic state. |
| **LATER-SLICE** | The capability belongs to household/office/etc. substrate and should not be pulled into Slice 2 merely for implementation convenience. |

---

## 4. Slice 1 implementation substrate already available

### 4.1 Objective committed state is already explicit and isolated — **REUSE / PRESERVE**

**Primary surface:** `src/Mesopotamia.Sim/State.cs`

Slice 1 has a clear objective-world representation:

- stable typed IDs: `PersonId`, `DwellingId`, `RelationId`, `ProposalId`, `EventId`;
- typed objective records for people, residence, attitude, kinship, marriage, debt, and favour;
- mutable authoritative `WorldState` internal to the kernel;
- immutable `WorldSnapshot` published at the stable cycle boundary;
- validation and transactional copying around authoritative mutations.

This directly supports the accepted Slice 2 distinction between **objective state** and **actor-specific subjective state**. The current objective snapshot does not pretend to be an actor's knowledge.

The important existing boundary is not the exact list of fields. It is the fact that objective state has a single authoritative committed representation and is published immutably. Slice 2 should preserve that distinction; subjective state must not become an alias for “whatever is in `WorldSnapshot`.”

### 4.2 Actor decision code already reads a bounded subjective view, not `WorldSnapshot` — **REUSE / PRESERVE**

**Primary surface:** `src/Mesopotamia.Sim/PersonalDecisionInputs.cs`  
**Related surface:** `src/Mesopotamia.Sim/Agency.cs`

`PersonalDecisionInputs` is explicitly described as a bounded Slice 1 policy input rather than a general knowledge store. `PersonalInputCapture.Capture(...)` is the one boundary that reads objective committed state; `PersonalAgency` receives the resulting immutable view.

Existing useful properties:

- own state is separated from counterparty facts;
- direct-party relations/claims are selectively included;
- explicit policy observations are separately marked;
- unobserved counterparty facts remain unknown to personal gates;
- trace strings retain basis labels such as `OwnState`, `DirectPartyRelations`, and `ExplicitPolicyObservation`;
- candidate generation/gating/scoring do not receive the objective snapshot directly.

This is one of the strongest Slice 1 seams for Slice 2. The current source of subjective inputs is temporary and fixture/policy-bound, but the **decision membrane** already exists.

### 4.3 Semantic history already carries stable provenance anchors — **REUSE / PRESERVE**

**Primary surface:** `src/Mesopotamia.Sim/Execution.cs`

`SemanticEvent` already records:

- stable `EventId`;
- `Cycle`;
- monotone `ReactionIndex` within the cycle;
- semantic event kind;
- proposal identity where applicable;
- participants;
- causal predecessor event IDs through `Causes`;
- material changes;
- semantic detail;
- configuration version;
- technical-fallback disclosure;
- action terms and attitude contributions where applicable.

`Simulation.Record(...)` centralizes creation of this history.

Accepted Slice 2 semantics require evidence/provenance and require underlying event/observation ordering to outrank message-arrival order. Slice 1 therefore already contains the event identity and semantic ordering substrate from which evidence may be grounded. What it does not yet contain is persistent actor-held epistemic state referring to that substrate.

### 4.4 Direct-participant outcome knowledge already exists — **REUSE, BUT NOT SUFFICIENT**

**Primary surface:** `src/Mesopotamia.Sim/Execution.cs`

Slice 1 maintains:

- `Dictionary<PersonId, List<ParticipantOutcome>> knowledge`;
- `KnowledgeOf(PersonId)` as an immutable query;
- `Learn(...)`, which adds committed/failed attempt outcomes only to direct participants;
- special participant handling for repayment, reciprocal-favour cancellation, and called repayment;
- no participant knowledge for categorically invalid terms.

This already enforces part of accepted §6.7:

- direct participants learn valid failed-attempt outcomes;
- invalid terms do not become social knowledge merely because the engine diagnosed them;
- failure reasons can remain bounded rather than leaking arbitrary resolver state.

However, this is **not** the accepted `KnownFact` model. `ParticipantOutcome` stores only event/proposal outcome data, is not a general factual proposition with provenance semantics, is not used as a source for `PersonalDecisionInputs`, and has no recognition layer.

The existing `knowledge` member is therefore a useful lower-level seam and evidence of privacy discipline, but it cannot simply be equated with Slice 2 knowledge.

### 4.5 Proposal / response / resolution / commit is already centralized — **REUSE / PRESERVE**

**Primary surface:** `src/Mesopotamia.Sim/Execution.cs`  
**Rules surface:** `src/Mesopotamia.Sim/Decisions.cs`

The cycle already follows the ADR-0004 shape:

1. maintenance;
2. immutable decision snapshot;
3. personal deliberation/proposal;
4. proposal validation and feasibility;
5. response contexts where required;
6. central resolution and immediate revalidation;
7. atomic commit/failure;
8. automatic reactions;
9. stable publication and semantic history.

Slice 2 communication, if applicable to the slice under the eventual scope/freeze, has an existing personal-action pipeline in which initiative consumption, proposal identity, semantic history, and stable commit semantics already live. No separate execution architecture is needed merely because the action affects subjective rather than material state.

That observation is architectural only; this survey does not define how a communication action is represented or committed.

### 4.6 Personal initiative and response separation is already enforced — **REUSE / PRESERVE**

**Primary surfaces:** `Execution.cs`, `Agency.cs`, `Decisions.cs`

Slice 1 already enforces:

- at most one personal initiative per actor/cycle;
- incoming responses do not consume or grant personal initiative;
- personal and response decision traces remain distinct;
- deterministic response profiles and candidate selection.

Accepted §6.4 states that ordinary `CommunicateClaim/Inform` normally consumes the sender's personal voluntary initiative. Slice 1 therefore already owns the relevant initiative budget and need not invent a new scheduling concept for communication.

### 4.7 Decision traces already expose subjective inputs — **REUSE / PRESERVE**

**Primary surfaces:** `Decisions.cs`, `PersonalDecisionInputs.cs`, `Agency.cs`

`DecisionTrace` already contains `SubjectiveInputs`. Slice 1 tests verify that traces preserve the inputs and bases actually used for policy decisions.

Slice 2 requires inspectable epistemic provenance and action availability that can differ across actors facing the same objective world. The trace surface is therefore already positioned to demonstrate what information a decision actually depended on. It will need Slice 2-relevant content, but not a new concept of “decision trace.”

### 4.8 Deterministic verification and observer noninterference already exist — **REUSE / PRESERVE**

**Primary surfaces:** `tests/Mesopotamia.Sim.AcceptanceTests/*`

Slice 1's acceptance harness already supports:

- explicit typed proposals and bounded policy inputs;
- manifest-indexed evidence;
- fixture write-set auditing;
- oracle-independence auditing;
- deterministic replay;
- storage/input permutation checks;
- observer-read noninterference over `Snapshot`, `History`, `DecisionHistory`, and `KnowledgeOf`;
- provenance/cause replay for selected invariants.

This is a strong testing substrate for Slice 2. The frozen Slice 1 manifest itself must remain unchanged; Slice 2 applicability/freeze is separate authority work.

---

## 5. Implementation surface map

| Surface | What Slice 1 gives us now | Slice 2 pressure | Classification |
| --- | --- | --- | --- |
| `State.cs` — `WorldState` / `WorldSnapshot` | Authoritative committed objective state; immutable published snapshot | Persistent actor-specific epistemic state is absent. Accepted `KnownFact` / `Recognition` cannot be represented as authoritative future-influencing state today. | **BOUNDED EXTENSION PRESSURE** |
| `State.cs` — typed IDs/records | Stable semantic identity and explicit references | Slice 2 introduces additional independently referable epistemic propositions/evidence concepts, but exact record/ID choices are not selected here. | **BOUNDED EXTENSION PRESSURE** |
| `PersonalDecisionInputs.cs` — `PersonalInputCapture` | Single membrane from committed world to actor-specific policy view | Current view is built from own/direct-party state plus explicit policy observations, not persistent actor-held knowledge/recognition. Slice 2 must be able to supply accepted subjective state without exposing the whole objective snapshot. | **BOUNDED EXTENSION PRESSURE / PRESERVE BOUNDARY** |
| `PersonalDecisionInputs.cs` — `TraceInputs()` | Provenance-like basis labels for decision inputs | Slice 2 decisions need inspectable factual/recognition evidence provenance rather than only Slice 1 basis strings. | **BOUNDED EXTENSION PRESSURE** |
| `Agency.cs` — `PersonalAgency` | Context-sensitive candidate generation/gates/scoring over bounded inputs | Recognition must be able to affect action availability where accepted. Exact Slice 2 candidate applicability is not decided by this survey. | **BOUNDED EXTENSION PRESSURE, APPLICABILITY CONDITIONAL** |
| `Agency.cs` — `PersonalPolicy.Observed*` | Explicit fixture/policy-bound observations used by Slice 1 | README expressly says these are not a persistent observation/communication system. They cannot stand in for accepted Slice 2 knowledge. | **PRESERVE AS SLICE-1 INPUT; DO NOT MISCLASSIFY AS SLICE-2 MODEL** |
| `Decisions.cs` — `ActionTerms` / `ActionRules` | Typed lower-level action vocabulary and centralized validity/feasibility/target semantics | `CommunicateClaim/Inform` is absent. If it fires for Slice 2, the normal action/rule surface must accommodate it. No representation is selected here. | **BOUNDED EXTENSION PRESSURE, SUBJECT TO SLICE APPLICABILITY** |
| `Execution.cs` — `SemanticEvent` / `Record` | Stable event IDs, cycle/reaction order, participants, causes, semantic detail | Strong provenance substrate already exists; actor-held evidence needs a durable link to semantic sources/reports without turning the event log itself into actor knowledge. | **REUSE + BOUNDED EXTENSION PRESSURE** |
| `Execution.cs` — `knowledge` / `Learn` / `KnowledgeOf` | Direct-participant outcome knowledge with bounded reasons | Not a general `KnownFact` store; not recognition; not fed into policy. Knowledge acquisition must broaden in the accepted ways while retaining privacy discipline. | **BOUNDED EXTENSION PRESSURE** |
| `Execution.cs` — cycle pipeline | Central deterministic mutation and stable closure | Subjective changes caused by participation/observation/communication need to fit the same authoritative-cycle discipline. No separate scheduler is indicated. | **REUSE / PRESERVE** |
| `Simulation.cs` — public simulation boundary | Published objective `Snapshot` and configuration | Slice 2 verification needs inspectable actor-specific epistemic state/provenance. Current public query surface exposes only `KnowledgeOf` participant outcomes. Exact query API is not selected here. | **BOUNDED EXTENSION PRESSURE** |
| `ResolutionDependencies.cs` | Detects noncommuting accepted lower-level effects and discloses fallback | Whether any Slice 2 subjective effects introduce same-cycle noncommutativity requiring participation in this analysis depends on accepted action/evidence semantics and applicability. | **CONDITIONAL WATCH** |
| `MaterialRecovery.cs` | Grain-input/consumption/deadlock helpers | No direct Slice 2 epistemic responsibility identified. | **PRESERVE / NO DIRECT PRESSURE** |
| Acceptance tests | Determinism, fixture discipline, trace/history observation, observer noninterference | New Slice 2 scenarios/probes will need to inspect subjective divergence, provenance, staleness/conflict, and any fired communication/gating obligations. | **BOUNDED EXTENSION PRESSURE TO TEST SURFACE** |
| Frozen Slice 1 manifest | Immutable completion authority for IMP-0001 | Must not be edited/reclassified to absorb Slice 2. | **PRESERVE** |

---

## 6. Bounded extension pressures, without implementation design

### 6.1 Persistent actor-held subjective state

**Why current code is insufficient**

Accepted SFL §6 defines `KnownFact` and `Recognition` as actor-held, provenance-bearing state that can affect future action. Slice 1 has no persistent authoritative representation for either. Its `PersonalPolicy.Observed*` values are supplied observations, and `KnowledgeOf` exposes only direct participant outcomes.

**Existing code ownership/seams**

- `State.cs` owns authoritative future-influencing state.
- `Simulation.cs` owns the published/query boundary.
- `PersonalInputCapture` owns the membrane from committed state into actor decision inputs.

**Boundary that must remain true**

Objective truth and actor-held subjective state must remain distinguishable. Adding subjective state must not make `WorldSnapshot` equivalent to “what every actor knows.”

**Not decided here**

Record shapes, collection layout, proposition identity, indexing, persistence representation, or public API.

### 6.2 Knowledge acquisition from accepted routes

**Why current code is insufficient**

`Learn(...)` currently captures outcomes for direct participants. Accepted §6.4 additionally distinguishes:

- own objective state;
- relations/claims in which an actor is a direct party;
- proposals/events in which the actor directly participates;
- other facts acquired through valid event-specific observation or communication.

The current code implements only a narrow subset of that space.

**Existing code ownership/seams**

- `Execution.cs` already knows event participants, outcomes, event identity, and causal history.
- `PersonalInputCapture` already prevents policy from bypassing actor-specific inputs.

**Boundary that must remain true**

Acquisition must not degrade into global synchronization, co-residence omniscience, or unrestricted reads from engine truth.

**Not decided here**

Observation API, observation eligibility representation, ingestion pipeline shape, or exact proposition model.

### 6.3 Evidence and provenance retention

**Why current code is only partially sufficient**

Slice 1 semantic events already have event identity, causal predecessors, cycle, and reaction index. Accepted recognition/knowledge semantics require actor-held facts/interpretations to retain evidence provenance, including source/report lineage where applicable.

**Existing code ownership/seams**

- `SemanticEvent.Id`
- `SemanticEvent.Causes`
- `Cycle` / `ReactionIndex`
- `Record(...)`
- decision trace subjective-input reporting.

**Boundary that must remain true**

Semantic history can ground evidence, but observer history itself must not become an omniscient actor-facing knowledge channel.

**Not decided here**

How evidence links are encoded, how much provenance is copied versus referenced, or how evidence is queried.

### 6.4 Staleness and incompatible evidence

**Why current code is insufficient**

There is no persistent evidence comparison or recognition-conflict state today. Accepted §6.5 requires:

- stale information to persist until displaced/contested;
- underlying event/observation order to outrank later message arrival;
- newer direct evidence to supersede older incompatible evidence;
- unresolved incompatible evidence to become `Contested` rather than being arbitrarily tie-broken.

**Existing code ownership/seams**

Slice 1 already has deterministic underlying semantic order through `Cycle` and `ReactionIndex`, plus stable event IDs and causes.

**Boundary that must remain true**

The engine's ordinary stable-ID technical fallback must not silently become a semantic winner-selection rule for contested recognition. The recognition verification family explicitly treats arbitrary-ID resolution as a mutant.

**Not decided here**

Evidence-comparison algorithm, recognition update algorithm, conflict data structure, or cache strategy.

### 6.5 Communication as an ordinary voluntary personal action

**Why current code is insufficient**

`CommunicateClaim/Inform` is named by accepted SFL §5/§6 but is absent from the Slice 1 action vocabulary. The frozen Slice 1 manifest explicitly deferred `S1-098-COMMUNICATION` and communication-provenance/message-order obligations.

**Existing code ownership/seams**

- `ActionTerms` / `ActionRules` already define typed personal action meanings.
- `RunCycle` already owns the one-personal-initiative budget.
- `SemanticEvent` already records proposal/action provenance.
- the commit path already centralizes consequential changes.

**Boundary that must remain true**

If communication is in the Slice 2 applicability set, it must remain an actor action under the accepted initiative rule rather than a free engine broadcast; it must not invent a proposition the sender does not hold.

**Not decided here**

Message/action record shape, recipient model, report representation, delivery mechanics, or same-cycle timing beyond accepted semantics.

### 6.6 Recognition as distinct from fact, attitude, and objective state

**Why current code is insufficient**

Slice 1 has objective relations and directed `Attitude`, but no `Recognition` layer. Accepted semantics explicitly forbid treating recognition as attitude, approval, obedience, or engine truth.

**Existing code ownership/seams**

- state representation already favors typed, independently identified records;
- decision inputs already separate actor-visible facts from objective checks;
- candidate gates already exist as a concept.

**Boundary that must remain true**

Recognition must remain separately inspectable and causal where applicable, while ordinary person-to-person actions remain independent of household recognition.

**Not decided here**

Recognition record shape, derivation mechanics, proposition encoding, or which higher-order recognition propositions become executable in Slice 2 versus later slices.

### 6.7 Recognition/knowledge entering candidate generation without opening objective-state access

**Why current code is partially ready**

`PersonalAgency` already generates candidates from an immutable actor-specific view, and gates run before scoring. This is structurally compatible with recognition-dependent availability.

The current inputs, however, cannot express persistent `KnownFact`/`Recognition` semantics.

**Existing code ownership/seams**

- `PersonalInputCapture`
- `PersonalDecisionInputs`
- `PersonalAgency.Decide`
- `DecisionTrace.SubjectiveInputs`

**Boundary that must remain true**

A later candidate must not become available merely because the corresponding objective engine state exists. The actor-specific route remains the gate.

**Applicability caveat**

The reviewed recognition verification family includes household/head-mediated examples. This survey does not assert that those higher-order candidates themselves belong to Slice 2; it only identifies the already-existing decision seam they would eventually use.

### 6.8 Inspectable subjective state for verification

**Why current code is insufficient**

Slice 2 discovery explicitly calls for inspecting actors with different knowledge of the same objective world, stale facts, contested recognition, recognition-caused action differences, and epistemic provenance. `KnowledgeOf` currently returns only `ParticipantOutcome` rows.

**Existing code ownership/seams**

- immutable public observation style already exists;
- tests already assert observer reads do not alter behavior;
- `History` and `DecisionHistory` are stable diagnostic surfaces.

**Boundary that must remain true**

Verification visibility must not become behavior-affecting state or a policy backdoor into omniscient history.

**Not decided here**

Public query names, DTO shapes, diagnostic projection format, or whether all inspection remains test-only versus public.

---

## 7. Slice 1 surfaces that encode Slice-1-only assumptions

These are not defects. They are places where a verified Slice 1 constraint will need to be consciously re-scoped rather than accidentally treated as permanent architecture.

### 7.1 `WorldState` exact-field structural audit

`CrossCuttingScenarios.NoDerivedAuthorityStructuralAudit` reflects over the exact Slice 1 `WorldState` field inventory and expects only people/dwellings/residences/attitudes/kinships/marriages/debts/favours plus `nextRelation`.

That was valid evidence for Slice 1's claim that no hidden derived authority existed. Once accepted future-influencing subjective state is added, this exact inventory cannot remain a universal invariant. The broader invariant—no hidden/stale derived authority—remains relevant.

This is a **test-scope pressure**, not an argument for any particular Slice 2 state layout.

### 7.2 `PersonalPolicy.Observed*` is explicitly temporary Slice 1 observation plumbing

`src/Mesopotamia.Sim/README.md` states that the observed identity/sex/residence/debt inputs are supplied observations for the bounded laboratory and **not a persistent observation or communication system**.

Slice 2 should not quietly relabel those fixtures as the accepted epistemic model. The useful part to preserve is the actor-specific decision boundary, not the temporary source of its observations.

### 7.3 `KnowledgeOf` becomes semantically ambiguous once accepted `KnownFact` exists

Today, `KnowledgeOf(person)` means “direct participant outcome records known under Slice 1's bounded failure/outcome rules.” It is not a general knowledge graph or fact store.

Once `KnownFact` is executable, this existing name/surface becomes a potential interpretation hazard. This survey does not prescribe a rename or API change; it only records the collision so implementation does not accidentally treat `ParticipantOutcome` as the complete epistemic model.

### 7.4 Default configuration identity is Slice-1-specific

`Configuration` currently defaults to `SFL-S1-v1`, and semantic events stamp the configuration version. A Slice 2 implementation will need to preserve truthful configuration/version provenance. Exact versioning mechanics remain an implementation-planning choice.

### 7.5 Source README explicitly declares recognition/communication absent

The implementation README correctly says the Slice 1 kernel introduces no general communication or recognition. That statement is part of the current code contract/documentation and will become stale when the accepted Slice 2 capability is implemented. Documentation change is therefore a predictable bounded follow-up, not new semantics.

---

## 8. Conditional watch surfaces

### 8.1 `ResolutionDependencies.cs`

Current dependency analysis asks whether accepted objective effects can commute and marks stable-ID fallback only where a consequential noncommuting exchange is witnessed.

Slice 2 does not automatically require this subsystem to change. It becomes relevant only if accepted Slice 2 subjective-state commits can participate in same-cycle interactions whose result depends on ordering and cannot be handled by the already-accepted evidence ordering semantics.

Until that is established, classify this file as **conditional watch**, not a mandatory extension point.

### 8.2 Response decision inputs

Current response traces use a much thinner subjective input surface than personal decisions. Accepted §5.1 says response contexts read the target's subjective state from the common committed snapshot.

Whether Slice 2 requires response-choice behavior to depend on newly represented knowledge/recognition is action-specific and should be established by the eventual Slice 2 applicability set. The response path is therefore a likely integration surface, but no additional response semantics are inferred here.

### 8.3 Initial-world fixture ingress

`InitialWorld` currently initializes objective lower-level state but no persistent subjective facts/recognition. Some Slice 2 verification may require controlled epistemic starting conditions; other cases may require acquisition only through executable events.

Fixture authority and allowed write-sets need to be defined by Slice 2 verification/implementation planning. This survey does not decide which subjective facts, if any, may be directly initialized.

---

## 9. Surfaces with no demonstrated need for broadening in Slice 2

The reviewed authority gives no reason for Slice 2 to expand these areas merely to make knowledge/recognition work:

- grain maintenance/deadlock logic in `MaterialRecovery.cs`;
- debt/favour/material-transfer meanings beyond their existing role as objective events/evidence sources;
- the single-threaded deterministic execution model;
- concurrency, parallelism, distributed execution, or event-sourced authority;
- checkpoint/save-load format (Slice 5 concern, aside from keeping future-influencing state explicit in principle);
- household formation, `CandidateOrganization`, formation/participation/continuity warrants (Slice 3 substrate);
- head/representative office occupancy/succession mechanics (Slice 4 substrate);
- trust scores, rumor mutation, deliberate lying, reputation, or generic messaging infrastructure not required by accepted v0 semantics;
- a generic graph database or generalized ontology layer;
- a replacement scorer/planner architecture.

The important restraint is to avoid implementing later-slice objective institutions merely to have convenient objects for Slice 2 recognition tests. Verification applicability should determine what concrete recognition propositions are executable now.

---

## 10. File-by-file touchpoint inventory

### High-confidence bounded extension surfaces

| File | Existing responsibility | Why Slice 2 reaches it |
| --- | --- | --- |
| `src/Mesopotamia.Sim/State.cs` | Authoritative typed state and immutable snapshots | No persistent `KnownFact`/`Recognition` state exists. |
| `src/Mesopotamia.Sim/PersonalDecisionInputs.cs` | Actor-specific immutable decision view and input capture | Current observations are Slice 1 fixture/policy inputs, not persistent epistemic state. |
| `src/Mesopotamia.Sim/Execution.cs` | Cycle orchestration, semantic events, participant outcome knowledge, commit/history | Knowledge acquisition, provenance-bearing subjective effects, and communication execution must connect to the authoritative pipeline. |
| `src/Mesopotamia.Sim/Decisions.cs` | Typed action vocabulary, validity/feasibility/target rules, decision traces | Communication action semantics are absent; traces need Slice 2-relevant subjective evidence. |
| `src/Mesopotamia.Sim/Agency.cs` | Candidate generation, gates, scoring | Accepted subjective/recognition state must be able to affect accessible candidates where applicable. |
| `src/Mesopotamia.Sim/Simulation.cs` | Public simulation/snapshot boundary | Slice 2 needs inspectable actor-specific epistemic state beyond current outcome-only `KnowledgeOf`. |
| `tests/Mesopotamia.Sim.AcceptanceTests/*` | Frozen-row evidence, scenario harness, independent checks | Slice 2 needs new executable evidence while preserving determinism, fixture discipline, and observer noninterference. |

### Conditional or documentation touchpoints

| File | Classification | Reason |
| --- | --- | --- |
| `src/Mesopotamia.Sim/ResolutionDependencies.cs` | **CONDITIONAL WATCH** | Only if Slice 2 subjective commits create order-sensitive resolution interactions not already covered by accepted evidence order. |
| `src/Mesopotamia.Sim/README.md` | **DOCUMENTATION FOLLOW-UP** | It currently and correctly declares persistent observation/communication/recognition absent. |
| `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` | **TEST RE-SCOPE** | Exact `WorldState` field inventory is Slice-1-specific; broad no-hidden-authority invariant remains useful. |
| `src/Mesopotamia.Sim/VerificationAccess.cs` | **LIKELY REUSE** | Existing internal test visibility can continue unless Slice 2 verification establishes a different boundary. |

### No direct Slice 2 pressure identified

| File | Reason |
| --- | --- |
| `src/Mesopotamia.Sim/MaterialRecovery.cs` | Grain recovery/deadlock projection is orthogonal to accepted subjective-information semantics. |

---

## 11. Architectural invariants Slice 2 can inherit rather than reinvent

The following Slice 1/ADR boundaries should carry forward unless separately escalated:

- **Current typed in-memory state remains authoritative.** Semantic history is provenance/diagnostic history, not event-sourced authority.
- **Agents read committed state through bounded inputs and emit attempts/proposals.** Behavioral code does not directly mutate another actor's authoritative state.
- **Authoritative change occurs through validation/resolution/commit.**
- **Completed cycle state is published only at stable closure.**
- **Objective state and actor-specific subjective inputs are separable.**
- **Stable semantic identity is explicit and does not derive from mutable names/content/container positions.**
- **Candidate generation is context-sensitive and gates precede scoring.**
- **Decision traces are transparent and deterministic.**
- **Observer/trace collection does not alter outcomes.**
- **Stable-ID fallback is a disclosed technical mechanism, not a license to resolve contested social meaning.**
- **Frozen Slice 1 acceptance authority remains frozen.** Slice 2 does not retroactively redefine what IMP-0001 proved.

These inherited boundaries sharply reduce the amount of architecture Slice 2 needs to invent.

---

## 12. Implementation hazards visible from Slice 1

This section records hazards exposed by the current code. It does not prescribe fixes.

### Hazard A — treating `WorldSnapshot` as universal knowledge

Because objective facts are easy to query from `WorldSnapshot`, a new Slice 2 gate could accidentally read engine truth directly. That would violate the explicit no-passive-synchronization semantics and bypass the existing `PersonalInputCapture` membrane.

### Hazard B — treating `PersonalPolicy.Observed*` as the persistent epistemic model

Those inputs are explicitly temporary Slice 1 observation bindings. Reusing them as the authoritative Slice 2 knowledge store would erase persistence, acquisition history, staleness, and conflict provenance.

### Hazard C — treating `ParticipantOutcome` as `KnownFact`

The current `knowledge` dictionary is narrower than accepted §6. It has useful privacy properties but cannot express arbitrary factual propositions, recognition interpretations, stale evidence, or contested recognition.

### Hazard D — resolving recognition conflict with the normal stable-ID fallback

Slice 1 correctly uses disclosed stable-ID fallback for technical ties in policy/resolution. The recognition family explicitly says incomparable incompatible recognition evidence becomes `Contested`; arbitrary actor/message/ID choice is a semantic mutant.

### Hazard E — letting history become an omniscient actor API

`History` is intentionally an observer diagnostic surface. Feeding it directly into policy would defeat actor-specific knowledge and make communication/observation meaningless.

### Hazard F — importing household/head mechanics early to make recognition convenient

Accepted SFL contains household/head recognition propositions, but Slice 1 deliberately has no household/head substrate and the slice applicability boundary has not been decided by this survey. Pulling Slice 3/4 mechanics into Slice 2 for convenience would expand scope rather than implement the epistemic seam cleanly.

### Hazard G — weakening existing observer-noninterference

Slice 2 will need richer epistemic inspection. Those queries must remain observational; test/debug inspection cannot become behavior-affecting authority.

---

## 13. Questions intentionally left for implementation planning / verification applicability

This implementation survey does **not** answer:

- the concrete type/schema for factual propositions;
- the concrete type/schema for recognition propositions;
- how actor-held evidence references underlying semantic events/reports;
- how subjective state is indexed internally;
- exact update/conflict-resolution algorithms beyond the accepted semantic outcomes;
- the public or test-only query API for subjective state;
- which kinds of event-specific observation are executable in Slice 2;
- what fixture ingress, if any, is allowed for initial subjective state;
- whether every communication semantic row fires in Slice 2 or remains deferred;
- whether household/head-dependent recognition cards fire before household/head substrate exists;
- whether any Slice 2 subjective-state writes participate in the existing same-cycle dependency analysis;
- exact configuration/version naming;
- persistence/checkpoint encoding.

Those are deliberately outside this artifact's mandate.

---

## 14. Survey conclusion

The verified Slice 1 implementation is already shaped around the core distinction Slice 2 needs: **objective committed world state is not the same thing as an actor's decision inputs**.

The main reusable seams are:

- authoritative typed state and immutable snapshots;
- `PersonalInputCapture` as an epistemic membrane;
- semantic events with stable causal provenance and ordering;
- direct-participant outcome learning with bounded failure reasons;
- a central deterministic action/commit path;
- transparent decision traces;
- a deterministic, observer-noninterfering acceptance harness.

Slice 2's bounded implementation pressure is concentrated in making subjective information **persistent, provenance-bearing, actor-specific, stale/contestable, communicable where applicable, and causal for action availability** without erasing those existing boundaries.

Nothing reviewed here indicates a need to replace the reference kernel, rewrite the lower-level social substrate, broaden material systems, or pre-implement household/office mechanics. The implementation task that follows discovery should be able to start from the existing Slice 1 seams and add only the epistemic capabilities that the accepted Slice 2 scope and verification-trigger analysis actually require.

---

## Appendix A — source/code evidence index

### Accepted semantic / architecture authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` — repository blob `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` — blob `66cfd55f8b960ff5664638c41c0e731257902be5`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` — blob `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md` — blob `43eedd7eb49e1eae035010332883ed2d8726d451`

### Slice planning / verification context

- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md` — blob `6dd411d9a6bfd7f882418f107a3557d8ab4e3059`
- `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md` — blob `d8f87dea9569d41481850c7327a025c44d6c3358`
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` — blob `4ded3f3c3f5a47c497ab0a26dcdb50054896c4b8`
- `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md` — blob `cf7f7061b31c3323cfade6fac2632fba9c5c1feb`
- `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` — blob `8b35261ed22ddb6cd8429577dc6fd80ac1f54789` (non-authoritative)

### Production implementation inspected

- `src/Mesopotamia.Sim/State.cs` — blob `516fd42397e426568330c61c74db76e5609b81cb`
- `src/Mesopotamia.Sim/PersonalDecisionInputs.cs` — blob `43dace0bba7dfde0bf978250a13e86d2edee1440`
- `src/Mesopotamia.Sim/Agency.cs` — blob `14e6191e953f36f7009830f1bdb2d186881d206f`
- `src/Mesopotamia.Sim/Decisions.cs` — blob `7a44c517c8c82cc148e75878f0f72a6004ffcc8b`
- `src/Mesopotamia.Sim/Execution.cs` — blob `e24d00e4ae5be49af44f70c437c56cb542dea689`
- `src/Mesopotamia.Sim/ResolutionDependencies.cs` — blob `7e119a042d6c0fe3bdcdd59ddbd3c0b900811638`
- `src/Mesopotamia.Sim/Simulation.cs` — blob `8b74e297863bf246cabfacf1ff0b5f58f00e75a1`
- `src/Mesopotamia.Sim/MaterialRecovery.cs` — blob `f83b80bc0e2e8fd76559bfeaec85ce3e9532b86f`
- `src/Mesopotamia.Sim/VerificationAccess.cs` — blob `c378090058205bed18ed04b7ece083ba71ad818c`
- `src/Mesopotamia.Sim/README.md` — blob `c79bbb19305f4bc99b1199f8fced2843222a3149`

### Acceptance implementation inspected

- `tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceTests.cs` — blob `fe446a70464d3b075d19ca2d067196f1d5a6bac3`
- `tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs` — blob `e9366dc02d8448364c2c114fd01f058de2dce4ed`
- `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` — blob `a2204947dc1c7704a90af1efa44170e0b39296e0`
