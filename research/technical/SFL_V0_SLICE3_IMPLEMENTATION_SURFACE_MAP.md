# SFL v0 Slice 3 Discovery B — Implementation Surface Map

**Status:** DISCOVERY / IMPLEMENTATION ARCHAEOLOGY / NON-AUTHORITATIVE  
**Task:** `tasks/research/SFL_V0_SLICE3_DISCOVERY_B_IMPLEMENTATION_SURFACES.md`  
**Repository:** `Classique-Smokes/Mesopotamia-Sim`  
**Branch:** `research/slice3-implementation-surface-return`  
**Exact canonical-main base:** `7deb43a7c2d40403f0a9cd6c600fba9db5cebf26`  
**Scope:** map the verified Slice-2 kernel against accepted Slice-3 household identity / grounded-capability semantics.  
**Explicit non-goal:** this return does not select concrete schemas, algorithms, candidate-convergence semantics, Slice-3 acceptance applicability, or any new social rule. It does not modify production code.

---

## 1. Authority and baseline

The repository at the exact base above records:

- IMP-0001 / Slice 1: **VERIFIED COMPLETE**;
- IMP-0002 / Slice 2: **VERIFIED COMPLETE / PROMOTED**;
- Slice-2 epistemic observation pause: **CLOSED / PROCEED TO SLICE 3 DISCOVERY**;
- current phase: **SLICE 3 PRE-IMPLEMENTATION DISCOVERY ACTIVE**.

Primary authority consulted:

- `AGENTS.md` and `00_START_HERE.md`;
- `plans/CURRENT_PHASE.md`;
- accepted `SPEC-SFL-0001`;
- accepted ADR-0001 through ADR-0005;
- all current canonical `src/Mesopotamia.Sim/*` surfaces;
- current Slice-1 / Slice-2 acceptance-test structure;
- Slice-1 and Slice-2 final completion records;
- canonical Formation, Continuity/Turnover, Lineage, Provision Grounding, No Self-Confirmation, and Resolution/Reaction verification families;
- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`;
- Slice-2 observation reconciliation.

The operational inter-slice prompt and `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` were also consulted only as non-authoritative question-generation aids, as directed by the current roadmap.

### Important pre-implementation facts

Two repository facts materially constrain implementation planning:

1. `LATER-01` — CandidateOrganization same-candidate equivalence / convergence — is now a **fired trigger**. The present implementation supports only one inert fixed-core candidate referent. Implementation must not invent the missing equivalence/convergence rule.
2. The current roadmap requires a deliberate Slice-3/Slice-4 boundary for grounded collective capability. Household head / representative-role mechanics must **not** be pulled into Slice 3 merely to make capability convenient.

---

## 2. Executive finding

Slice 3 appears to be a **substantial kernel extension within the existing architecture**, not an architecture redesign.

The verified Slice-2 kernel already supplies the architecture Slice 3 should continue to use:

- explicit stable lower-level identities;
- authoritative current typed state separated from semantic history;
- actor-specific provenance-bearing epistemic state;
- CandidateRecognition derived from actor-held evidence rather than objective omniscience;
- ordinary personal communication through the normal proposal/commit path;
- deterministic proposal / response / revalidation / commit;
- same-cycle counterfactual dependency analysis;
- stable-cycle publication only after automatic reaction closure;
- explicit event identity, Cycle / ReactionIndex, causal predecessors, and technical-fallback disclosure;
- immutable inspection surfaces and independent acceptance-oracle infrastructure.

What is missing is not a new simulation architecture. What is missing is the first persistent higher-order social substrate:

- household numerical identity;
- formation / participation / continuity warrants;
- sustaining-participant associations;
- lifecycle;
- household recognition;
- automatic formation / continuity reactions;
- same-cycle bridge handoff and continuity-over-duplicate-formation ordering;
- conditional lineage and provision/capacity substrate if the eventual Slice-3 acceptance authority fires them.

The largest implementation pressure is therefore **reaction/state expansion**, not replacement of the reference kernel.

A narrow "add a Household record" patch would be insufficient. Formation and continuity must become causally downstream of lower-level history and actor-held recognition, while preserving stable-cycle closure, no-self-confirmation, no hidden membership authority, and no pooled household resource.

---

## 3. Classification used in this map

| Classification | Meaning |
| --- | --- |
| **HIGH-CONFIDENCE CHANGE** | Accepted Slice-3 semantics cannot be represented/executed correctly without extending this surface or its logical responsibility. |
| **CONDITIONAL / WATCH** | Change depends on the eventual Slice-3 acceptance boundary or on an implementation choice that must preserve the listed invariant. |
| **NO EXPECTED PRESSURE** | Existing surface can remain as-is for Slice 3 unless another fired requirement establishes otherwise. |
| **REUSE / PRESERVE** | Existing mechanism is a useful architectural seam that Slice 3 should retain rather than bypass. |
| **ESCALATE BEFORE CODE** | A required semantic/architectural choice is not coder discretion. |

---

# A. Existing reusable substrate

## A1. Stable identities — **REUSE / PRESERVE**

`State.cs` already has explicit typed stable IDs for people, dwellings, relations, proposals, and semantic events. `WorldState` allocates relation IDs deterministically and validates referential integrity.

This is directly compatible with ADR-0001. Slice 3 needs additional independently referable social records, but the architectural rule is already established:

- Household identity must be explicit and stable;
- warrants/associations that must be independently referenced need stable identity or an equivalently stable semantic reference;
- Household identity must not be derived from residence, participant enumeration, names, graph shape, or mutable content.

The exact ID/record layout is engineering-local. The semantic requirement is not.

## A2. Semantic-event provenance — **REUSE / PRESERVE**

`Execution.cs` already records `SemanticEvent` with:

- `EventId`;
- `Cycle` and monotone `ReactionIndex`;
- proposal identity;
- participants;
- causal predecessor event IDs;
- committed material deltas;
- action terms;
- rule/configuration version;
- technical-fallback marker.

This is a strong substrate for FormationWarrant, ParticipationWarrant, ParticipationEndWarrant, ContinuationWarrant, and optional LineageWarrant provenance. Slice 3 should reference lower-level causes through explicit semantic evidence rather than reconstructing causality from a final snapshot.

Semantic history is evidence/provenance, not authoritative current state.

## A3. Actor-specific KnownFact / Recognition — **REUSE + EXTEND**

`EpistemicState.cs` already separates objective state from actor-held evidence:

- `KnownFact` retains acquisition route and original source/event/order;
- communication retains the underlying origin while appending delivery hops;
- stale information persists;
- accepted precedence can supersede older evidence;
- incompatible retained residence evidence can produce `Contested`;
- actor state is immutable at the public boundary.

This is the exact architectural direction Slice 3 needs. What is absent is Household-level recognition.

Important preservation rule: objective Household existence must not automatically appear in every actor's epistemic state.

## A4. Candidate recognition — **REUSE, BUT CURRENTLY BOUNDED BELOW SLICE-3 NEED**

`CandidateReferent` is explicitly inert. `EpistemicRules.Recognize(...)` derives CandidateRecognition from the actor's own held evidence for:

- shared residence of the fixed core;
- connected durable ties;
- qualifying support evidence on at least two distinct cycles;
- unresolved conflict handling.

Candidate label/existence is not used as evidence for itself. That is a useful anti-cheat property.

However, current `EpistemicState` rejects more than one candidate referent. It also assumes a fixed candidate core supplied at initialization. That is exactly where `LATER-01` now bites: implementation cannot simply admit multiple candidate labels and use ID ordering to decide which label "wins."

## A5. Communication — **REUSE / PRESERVE**

`CommunicateClaim` already:

- consumes the sender's ordinary personal initiative;
- transmits only a proposition/evidence the sender actually holds;
- preserves origin provenance;
- targets only the recipient;
- can be invalidated if the captured proposition no longer holds before commit;
- does not grant the recipient a fresh same-cycle voluntary activation.

This supplies the accepted sparse route for outsiders to learn Household / continuity evidence later, without introducing global synchronization.

The current `HeldRecognition` supports CandidateRecognition only. Household recognition will require a bounded extension if it becomes a transmissible recognition proposition in Slice 3.

## A6. Proposal / response / resolution / commit — **REUSE / PRESERVE**

`RunCycle` already provides the ADR-0004 execution skeleton:

1. maintenance;
2. common committed decision snapshot;
3. personal deliberation/proposal;
4. validity and feasibility;
5. deterministic response contexts;
6. accepted-attempt collection;
7. central dependency analysis and immediate revalidation;
8. atomic commit/failure;
9. automatic reactions;
10. stable publication.

Participation request/invitation/end and provision-commitment interaction, where in scope, should use this architecture. Slice 3 does not need a parallel "household mutation API."

Most importantly, accepted formation semantics explicitly forbid a privileged `FormHousehold` command.

## A7. Stable-cycle closure — **REUSE, BUT REACTION MACHINERY MUST GROW**

The kernel already does not publish a new `Snapshot` until closure succeeds. The duplicate-cause and skipped-closure challenges prove that incomplete reaction closure cannot masquerade as a completed cycle.

This is the right architecture for Slice 3, because:

- CandidateRecognition may become satisfied by committed lower-level events/communications;
- formation must then happen as an automatic causal consequence;
- founding participant associations and direct founder recognition follow;
- lifecycle is published only after participation/continuity reactions close.

Current automatic closure is narrow: debt review plus direct-attitude batching. Slice 3 introduces a materially richer reaction chain.

## A8. Same-cycle dependency analysis — **REUSE + HIGH-CONFIDENCE EXTENSION**

`ResolutionDependencies.cs` already builds detached counterfactual projections, detects actual noncommutativity, and distinguishes semantic execution from technical fallback disclosure.

Useful existing properties:

- the projection uses copied authoritative state;
- communication may project copied epistemic state;
- synthetic projection events do not consume live event IDs;
- allocation-order artifacts are normalized in the projection key for current relation types.

But the current dependency domain knows only current lower-level state and epistemic effects. It knows nothing about:

- Household identity;
- SustainingParticipant;
- participation/continuity warrants;
- lifecycle;
- formation reactions;
- provision commitments/capacity;
- lineage.

Same-cycle bridge handoff is also not just a fallback-marking problem: the accepted spec gives a **semantic causal priority** to the valid bridged entry/continuity reaction before the bridge's accepted exit.

## A9. Deterministic IDs / order — **REUSE / PRESERVE**

The kernel already has explicit deterministic counters for relation, proposal, and event identities, stable ordering by semantic IDs, and disclosed technical fallback.

Slice 3 may introduce additional ID classes/counters. Two constraints matter:

- projection-only evaluation must not consume live authoritative ID sequences;
- stable ID may break a disclosed technical symmetry only where authority permits it.

Stable ID must **not** decide CandidateOrganization equivalence/convergence, continuity identity, lineage ambiguity, or other social meaning.

## A10. Read-only verification inspection — **REUSE / PRESERVE**

Current public/test inspection includes:

- immutable objective `Snapshot`;
- immutable `EpistemicSnapshot` / `EpistemicStateOf(actor)`;
- `History`;
- `DecisionHistory`;
- retained direct-participant `KnowledgeOf`;
- `InternalsVisibleTo` for acceptance/unit tests.

The acceptance harness separately records fixture writes and runs independent replay/oracle logic without calling production recognizers, scorers, validators, or transition helpers.

Slice 3 therefore already has the correct verification philosophy: expose immutable evidence; do not give tests a secret mutation path.

---

# B. Missing Slice-3 state/types

The table below identifies semantic pressure only. It does not select collection shapes, class/file layout, indexing strategy, or whether some derived values are recomputed versus cached.

| Required concept | Current state | Slice-3 pressure / semantic constraint |
| --- | --- | --- |
| CandidateOrganization beyond inert referent | One `CandidateReferent`, fixed core, at most one, inert `IsLive` flag | **HIGH-CONFIDENCE CHANGE / ESCALATE BEFORE MULTI-CANDIDATE CODE.** A candidate may collect/identify formation evidence but gains no authority/resources. Same-candidate equivalence/convergence is unresolved by `LATER-01` and cannot be supplied by IDs, label equality, or graph similarity. |
| Household numerical identity | Absent | **HIGH-CONFIDENCE CHANGE.** Stable identity must be independent of mutable participants/residence/assets and remain separately queryable from lifecycle. |
| FormationWarrant | Absent | **HIGH-CONFIDENCE CHANGE.** Must reference founding core, dwelling, supporting ties/events, founder recognition evidence, earliest retained sustaining evidence, and formation/reification time. |
| SustainingParticipant | Absent | **HIGH-CONFIDENCE CHANGE.** Provenance-bearing typed association; never equivalent to residence or a hidden Members set. Founders receive it from FormationWarrant. |
| ParticipationWarrant | Absent | **HIGH-CONFIDENCE CHANGE.** Must prove recognized same H, current continuity bridge, shared residence, durable tie, post-H support, and bilateral recognition/acceptance. |
| ParticipationEndWarrant | Absent | **HIGH-CONFIDENCE CHANGE.** Ends only the typed association and remains historical; residence/kinship/marriage/debt/favour/history remain. |
| ContinuationWarrant | Absent | **HIGH-CONFIDENCE CHANGE.** Explicit bridge + same-H recognition + transition evidence; snapshot similarity/overlap cannot substitute. |
| Lifecycle | Absent | **HIGH-CONFIDENCE CHANGE.** Active/Inactive/Dissolved is operational state, not identity. Publication only at stable closure. Dissolved cannot reactivate as same identity. |
| Household existence/continuity Recognition | Candidate-only Recognition exists | **HIGH-CONFIDENCE EPISTEMIC EXTENSION.** Founders directly recognize the newly formed H; outsiders remain sparse and require accepted evidence routes. No global engine truth injection. |
| LineageWarrant / DerivedFrom / AncestorOf | Absent | **CONDITIONAL ON SLICE-3 ACCEPTANCE AUTHORITY.** Full accepted SFL defines controlled lineage as downstream, behaviorally inert historical derivation. If Slice 3 requires it, state/history/query surfaces must grow. If it does not, implementation must not pre-build a generalized lineage engine. |
| HouseholdProvisionCommitment | Absent | **CONDITIONAL / LIKELY SLICE-3 CAPABILITY PRESSURE.** If grounded capability fires in Slice 3, commitment remains a Person→Household conditional backing relation; grain stays personal until spend. |
| Derived mobilizable capacity | Absent | **CONDITIONAL / LIKELY.** Must derive from currently valid commitments and personal grain/NeedsGrain, not store a household treasury. ADR-0003 permits recomputation. |
| HouseholdHeadRole / HouseholdDecisionContext | Absent | **LATER-SLICE BOUNDARY / DO NOT PULL FORWARD.** Current roadmap explicitly requires resolving Slice3/Slice4 capability boundary before implementation. |

### B1. Current state partition creates a verification constraint, not a mandated design

Current frozen Slice-1 regression `S1-084` reflects the exact private-field inventory of `WorldState` to prove no hidden derived authority exists. Slice 2 preserved that test by keeping `EpistemicState` as a separate authoritative state partition rather than adding epistemic fields to `WorldState`.

Slice 3 must preserve the **meaning** of that frozen regression: no hidden behavior-affecting derived authority. This return does not prescribe whether household state lives in `WorldState`, a separate authoritative state object, or another bounded partition.

However, adding private fields to `WorldState` would fail the current executable structural regression exactly as written. Any change to that frozen evidence path is not something an implementer should silently weaken for convenience. The implementation plan must either preserve the regression mechanically or reconcile any necessary lossless verification adaptation through the project's verification authority.

---

# C. Execution / reaction surfaces

## C1. Formation must be downstream of lower-level evidence + founder recognition

Current candidate recognition is computed from each actor's held evidence, which is good. The formation family requires a stronger chain:

`lower-level committed support/history → actor-held evidence → every required founder CandidateRecognition → FormationWarrant → Household → founding SustainingParticipant → founder Household recognition`

The existing kernel has no automatic formation reaction.

Implementation pressure:

- after accepted commits/communications change actor-held evidence, reaction closure must be able to inspect the now-current founder recognition state;
- formation must cite the actual lower-level events/evidence and founder recognition basis;
- no fresh voluntary activation is allowed merely because recognition became satisfied;
- final Household/lifecycle state becomes visible only after closure.

The Slice-2 observation pause is an important guardrail: objective co-residence + ties + support did **not** imply recognition. Slice 3 must not replace that with an objective graph scan that creates a Household anyway.

## C2. CandidateOrganization must not self-confirm

The current recognizer appropriately ignores the candidate label as evidence. Slice 3 must preserve that property while moving beyond one inert referent.

Forbidden implementation shortcuts include:

- "candidate exists" counted as evidence that the organization exists;
- Candidate ID equality used as the social equivalence rule for multiple evidence paths;
- a Candidate object accumulating its own prior recognition as new independent lower-level evidence;
- Household-originated effects fed back into the formation predicate.

The no-self-confirmation family makes this a causal requirement, not merely a modeling preference.

## C3. Household creation is an automatic causal reaction, not an action command

Accepted authority explicitly forbids a privileged `FormHousehold` action.

The current action pipeline is therefore reusable for the lower-level causes and participation proposals, but **not** as a place to add "FormHousehold" to `ActionTerms`.

Formation belongs in automatic semantic reaction/closure logic with explicit causal predecessors and idempotence.

Current `AttitudeBatch` demonstrates cause-keyed/idempotent reaction discipline, but it is too specialized to carry the entire household chain unchanged. The implementation can extend or add bounded reaction machinery; this return does not choose its form.

## C4. Participation entry / exit fit the proposal-response model but require new semantics

Accepted participation after formation is explicitly bilateral:

- RequestHouseholdParticipation(H) through a current sustaining participant; or
- InviteHouseholdParticipation(P) from a current sustaining participant;
- named counterpart accepts;
- end participation is a voluntary action by the current participant.

Current `ActionTerms`, `ActionRules.Target`, response handling, and immediate revalidation are usable seams, but none of these action meanings or Household preconditions exist today.

Action-relevant precommit checks must include the accepted Household/bridge/recognition/warrant conditions without granting a head general admission power.

## C5. Same-cycle bridge handoff requires semantic ordering, not generic fallback

The accepted rule is explicit:

If entry depends on P as continuity bridge and P also has an accepted same-cycle participation exit, resolve the bridged entry and its continuity reaction before P's exit.

Current execution commits accepted proposals in proposal-ID order after dependency analysis. `ResolutionFallbacks` only detects/marks consequential noncommutativity; it does not reorder attempts according to a domain semantic priority.

Therefore Slice 3 creates **high-confidence pressure** in resolution/closure:

- the entry/bridge/exit dependency must be recognized;
- the causal handoff priority must win over proposal/container/stable-ID order;
- the ContinuationWarrant reaction must close before the bridge exit;
- stable lifecycle evaluation comes after compatible participation changes/reactions.

## C6. Lifecycle is stable-cycle state, not a microstep identity heuristic

The current architecture already withholds published snapshots until closure, which is the right base.

Slice 3 must additionally prevent implementation from treating transient participant count as completed lifecycle truth. During a same-cycle handoff, temporary counts may appear in microstate/history but cannot cause a false Dissolved state that then blocks the accepted continuation path.

Participant count determines only the accepted operational lifecycle **at stable closure**. It never defines Household numerical identity.

## C7. Dissolved must be terminal for numerical identity

The current kernel has no concept with "historically queryable but cannot reactivate" semantics.

Slice 3 needs an explicit enough state/history distinction that:

- a Dissolved H remains queryable;
- it emits no Household-mode action;
- later similar people/residence/ties cannot reactivate H;
- a later independently warranted organization forms a new Household identity.

This cannot be implemented by deleting the Household record when count reaches zero.

## C8. Continuity must outrank duplicate formation for the same evidence bundle

Accepted `7.5 gives a semantic precedence rule:

When the same evidence/history supports both valid participation/continuity to an existing non-Dissolved H and fresh formation of H2, the continuity/participation interpretation takes precedence for that evidence; the same causal bundle cannot do both.

This creates pressure on both reaction closure and dependency reasoning. A naïve "scan every recognized candidate and form if predicate true" pass can create a duplicate before/after participation depending on enumeration order.

The implementation must make the accepted precedence causal and deterministic without converting stable ID into the social rule.

## C9. Grounded capacity must not become pooled grain

If provision/capability is in Slice-3 acceptance scope:

- `HouseholdProvisionCommitment(Person → H)` is authoritative;
- personal grain remains authoritative personal grain;
- exposed capacity is derived `max(0, grain - 2)` and zero under NeedsGrain;
- Household capacity is derived from current valid commitments;
- no persistent Household treasury balance is created merely by commitment.

The current personal grain state and checked transfer transactions are reusable. `MaterialRecovery.cs` does not need a new Household grain concept.

If Slice 3 is required to execute an actual Household support/dowry spend, the current roadmap boundary becomes decisive because accepted collective expenditure also requires an Active H, occupied valid head, in-scope authority, and backing. That is an escalation/scope question, not permission to smuggle head mechanics into Slice 3.

## C10. Subjective Household recognition must remain sparse

Current epistemic acquisition is local:

- direct parties receive direct facts;
- communication targets a recipient;
- observer history is not a policy input.

Slice 3 should extend that pattern:

- founders directly recognize H from the formation event;
- participants learn the relevant participation/continuity events through accepted routes;
- outsiders do not become aware merely because `WorldSnapshot` contains H;
- communication may propagate accepted evidence/recognition;
- co-residence remains non-omniscient.

No "publish Household → add recognition to all actors" reaction is allowed.

## C11. Household-originated support must stay out of formation/lineage evidence

Current `AcquireCommittedFacts` turns current event kinds `Gift` / `Help` / `Loan` / `CalledFavourFulfilled` into `SupportFact`.

When Household support exists, it must remain semantically distinguishable from ordinary qualifying person-person support. Otherwise generic transfer reuse could accidentally make Household output become fresh evidence of its own formation, duplicate formation, continuity, or lineage.

This is a **high-confidence EpistemicExecution/history pressure** if household material action is executable in Slice 3; otherwise it remains a near-term guardrail for Slice 4.

---

# D. Likely source pressure

## D1. Production files

| Surface | Classification | Why |
| --- | --- | --- |
| `State.cs` | **HIGH-CONFIDENCE CHANGE / ownership pressure** | No Household IDs/records, warrants, participation associations, lifecycle, lineage, or provision commitments exist. Current lower-level state validation cannot express their reference/provenance invariants. Exact physical placement is engineering-local because of frozen structural regression pressure. |
| `EpistemicState.cs` | **HIGH-CONFIDENCE CHANGE** | Candidate model is at most one inert fixed-core referent; Recognition is Candidate-only; no Household/continuity recognition proposition exists; `LATER-01` directly reaches this surface. |
| `EpistemicExecution.cs` | **HIGH-CONFIDENCE CHANGE** | Must acquire/propagate Household-relevant evidence without global sync; founder/participant learning and Household recognition provenance need an executable route; support-event qualification must not admit Household self-feedback. |
| `Simulation.cs` | **HIGH-CONFIDENCE INTEGRATION PRESSURE** | Owns authoritative partitions and published stable-cycle snapshots. New Household state must be initialized, retained, and published/queried without breaking objective/epistemic separation. Exact code may live in new partial files. |
| `Execution.cs` | **HIGH-CONFIDENCE CHANGE** | Current closure only handles lower-level commits, debt review, and direct-attitude batch. Slice 3 needs formation/participation/continuity/lifecycle reactions and their causal history. This is the core kernel pressure. |
| `Decisions.cs` | **HIGH-CONFIDENCE CHANGE** | No household participation/provision action meanings or validation/target semantics exist. Do not add `FormHousehold` or head actions for convenience. Household recognition gating may require bounded actor-epistemic validation beyond current world-only `ActionRules` signatures. |
| `PersonalDecisionInputs.cs` | **CONDITIONAL / WATCH; PRESERVE MEMBRANE** | If Slice-3 acceptance requires autonomous generation of participation/provision candidates, actor inputs must expose only held Household recognition/relevant evidence, never objective Household truth. Scripted mechanism-isolation evidence could reduce direct changes here. Do not broaden to `WorldSnapshot` access. |
| `ResolutionDependencies.cs` | **HIGH-CONFIDENCE CHANGE** | Detached projection currently has only `WorldState` + optional `EpistemicState` and its projection key excludes all Household state/reactions. Same-cycle bridge handoff and continuity-vs-duplicate-formation introduce accepted semantic dependencies/priority. |
| `Agency.cs` | **CONDITIONAL / WATCH** | No richer personal-agency redesign is authorized. Only bounded candidate generation/gating may be needed if participation/provision is exercised autonomously. The rustic reference policy is not a reason to expand scope. |
| `VerificationAccess.cs` | **NO EXPECTED PRESSURE / REUSE** | Existing internal read access for test assemblies is adequate unless future acceptance authority establishes a different inspection boundary. It must remain read-only in semantic effect. |
| `MaterialRecovery.cs` | **NO EXPECTED PRESSURE** | Current grain recovery/deadlock projection is personal-material logic. Grounded household capacity must not introduce a pooled balance here. |
| `src/Mesopotamia.Sim/README.md` | **DOCUMENTATION FOLLOW-UP** | It correctly states Household lifecycle/later authority are absent. Any Slice-3 implementation would need documentation aligned to actual bounded capability. |

### D1a. Special pressure in `ResolutionDependencies.cs`

This file deserves more than a generic "update projection" note.

Current `ResolutionProjection` carries:

- copied `WorldState`;
- moved-person set;
- projected outcome/fault;
- optional copied `EpistemicState`.

Current `ProjectionKey` compares lower-level people, residences, marriages, debts, favours, mover state, and epistemic facts/recognition.

If authoritative Household state lives outside `WorldState`, the detached projection must carry it too for any same-cycle proposal whose commit/reaction can affect Household semantics. If Household state lives inside `WorldState`, the projection key still has to include the semantic Household/warrant/lifecycle consequences.

Otherwise the dependency analyser can falsely classify two orders as commuting even when one order forms/continues/dissolves a Household or changes which warrant exists.

Projection-only Household/warrant/event IDs must remain synthetic/private or semantically normalized so the analysis itself does not consume live ID sequences or report allocation order as social difference.

## D2. Acceptance-test structure

### Existing reusable test infrastructure

Current acceptance infrastructure already provides:

- frozen-manifest integrity checking;
- exact regression bindings;
- public-boundary scenario execution;
- explicit fixture auditing;
- independent oracle source auditing;
- immutable state/history capture;
- deterministic permutation/metamorphic comparisons;
- focused fault controls;
- observer noninterference.

This should be reused rather than replaced.

### High-confidence Slice-3 verification pressure

A Slice-3 acceptance surface will need independent evidence for at least the fired household families:

- formation positive + ablations;
- no Candidate self-confirmation;
- complete founder turnover;
- broken bridge / similar endpoint;
- Inactive reactivation;
- same-cycle bridge handoff;
- Dissolved no-resurrection;
- continuity-over-duplicate-formation;
- lineage family if Slice-3 scope fires lineage;
- provision grounding if Slice-3 scope fires capability;
- reaction closure including `support → knowledge → CandidateRecognition → formation → SustainingParticipant → Household recognition`.

`InvariantOracle.cs` currently reconstructs lower-level material, attitude, residence, debt/favour, cause, and score facts only. Slice 3 needs either an independently extended oracle or a separate independent Household oracle that reconstructs warrants/lifecycle/identity from explicit fixture + history without calling production formation/continuity classifiers.

`FixtureAudit.cs` currently records objective initial fields, scheduled inputs, submitted actions, and Slice-1/2 epistemic inputs. Slice 3 fixture evidence must make it mechanically visible that the fixture did **not** directly write:

- Household;
- FormationWarrant;
- SustainingParticipant;
- CandidateRecognition result;
- Household recognition result;
- Participation/Continuation/Lineage warrant result;
- lifecycle;
- head/office state.

### Frozen-regression pressure: `S1-084`

`CrossCuttingScenarios.NoDerivedAuthorityStructuralAudit` asserts the exact private field names of `WorldState`. That is real current executable evidence, not a theoretical concern.

Slice 3 implementation planning must account for this before code. Do not "fix" the test by loosening the field assertion simply because new state is inconvenient. Preserve the frozen invariant or obtain a separately reviewed lossless adaptation.

### Slice-2 regression surface

`Slice2AcceptanceTests` and `Slice2Scenarios` must continue to demonstrate:

- actor-specific objective/subjective separation;
- sparse communication;
- CandidateRecognition evidence adequacy;
- stale/contested recognition;
- no history-as-policy-input;
- same-cycle communication revalidation;
- observer/read/enumeration noninterference.

Household state must not retroactively make Slice-2 candidate recognition or disconnected actors globally knowledgeable.

---

# E. Cheat / architecture hazards

| Hazard | Why tempting in current code | Why it is wrong / what must remain true |
| --- | --- | --- |
| **Household = co-resident graph cluster** | `WorldSnapshot` can cheaply scan residences/kinship/attitudes | Accepted formation also requires distinct-cycle support + every founder's subjective CandidateRecognition. Residence/tie topology is evidence, not identity. |
| **Hidden Members set** | Convenient for queries/lifecycle | No universal MemberOf(H) authority exists. Use provenance-bearing SustainingParticipant associations; any index must be rebuildable/non-authoritative. |
| **Candidate label as self-evidence** | Current `CandidateReferent` gives a ready label/core | Candidate existence/label grants no authority and cannot count toward its own recognition/formation. |
| **Stable ID chooses candidate convergence** | Kernel already uses stable IDs for technical fallback | `LATER-01` is an unresolved social/semantic equivalence problem. IDs may not decide "same emerging organization." |
| **Household pooled grain** | Easier spending/accounting | Provision exposes personal backing only; ownership stays personal until spend. Capacity is derived. |
| **Snapshot similarity as identity** | Final participants/residence/ties are easy to compare | Continuity requires explicit bridge + same-H recognition + ContinuationWarrant. Similarity alone never preserves H. |
| **Residence change edits participation** | Residence already has a dedicated transition | Residence and SustainingParticipant are independent. Residence change alone cannot add/end participation. |
| **Participant count defines identity** | Active/Inactive/Dissolved thresholds are numeric | Count defines operational lifecycle at stable closure only. Numerical Household identity is historical/warranted. |
| **Generic engine omniscience for Household recognition** | Engine will know all Household records | Actors recognize H only through accepted participant/observation/communication evidence routes. Outsiders do not auto-sync. |
| **Fixture writes Household/warrants/head** | Easy to get later scenarios started | Formation family explicitly forbids endogenous-result fixture writes. Downstream checkpoint reuse must carry verifiable producer/pass/fixture provenance. |
| **Event-history replay becomes authority** | Warrant derivation is history-heavy | Current typed state remains authoritative. History supports provenance/oracles; behavior must not reconstruct current Household state from arbitrary observer logs each decision. |
| **`FormHousehold` action** | Fits existing `ActionTerms` pattern | Explicitly prohibited. Household formation is an automatic causal consequence after prerequisites/recognition. |
| **Household support counted as formation evidence** | Current `AcquireCommittedFacts` maps generic support event kinds to `SupportFact` | No-self-confirmation family forbids Household feedback from supplying independent formation/fresh-lineage evidence. |
| **Bridge exit wins by proposal ID** | Current accepted attempts commit in proposal-ID order | Same-cycle bridge handoff has an explicit semantic causal priority; technical order cannot dissolve H first. |
| **Formation and continuity both consume same evidence** | Independent scanners/reactions could both succeed | Accepted continuity/participation precedence forbids the same evidence bundle from both continuing H and founding duplicate H2. |
| **Dissolved record deleted then "recreated" with same ID** | Simplifies live collections | Dissolved identity remains historical and cannot reactivate. Later organization needs a new ID/warrant. |
| **Lineage ambiguity resolved by stable ID** | Stable-ID fallback already exists elsewhere | Accepted lineage rule says ambiguity withholds lineage; formation remains. No arbitrary predecessor selection. |
| **Head/office pulled into Slice 3** | Accepted household support/dowry routes use head authority | Current roadmap explicitly separates Slice 4 head/representative work. Resolve capability boundary rather than implementing office mechanics early. |
| **Rustic policy triggers agency redesign** | Observation pause shows narrow Farm/Gift behavior | Reconciliation explicitly classifies this as known reference-policy limitation, not a Slice-3 permission to redesign personal agency. |
| **Derived/cached Household projection becomes authority** | Lifecycle/capacity queries invite caching | ADR-0003 allows derived-state optimization, but semantic/query boundaries and reference recomputation must preserve authoritative warrant/commitment state. |

---

# F. Escalation triggers

The following discoveries are **not** coder discretion.

## F1. Candidate equivalence / convergence — already fired

Before implementation can create/reconcile multiple candidate labels/evidence paths, `LATER-01` must be resolved through the normal authority path.

Escalate if implementation needs to answer any question like:

- Are these two candidate labels the same prospective organization?
- Does one founder's candidate referent converge with another's?
- Can two overlapping cores merge evidence before formation?
- Which candidate survives when both satisfy local evidence?

Do not use lowest ID, first-created label, graph overlap, or shared core equality as the answer unless accepted authority explicitly defines that rule.

## F2. Slice-3 / Slice-4 capability boundary

If Slice-3 completion is interpreted to require executing Household support or mediated-marriage spending through an occupied head, stop and reconcile scope.

Accepted material use semantics require head authority. Current roadmap says do not pull `HouseholdHeadRole` / `HouseholdDecisionContext` forward merely for convenience.

A Slice-3 witness limited to commitment/backing/derived capacity may be possible under accepted semantics, but the acceptance authority must say what actually fires.

## F3. Lineage applicability and repeated participation histories

Full SFL v0 has accepted controlled lineage semantics, but this discovery return does not decide whether every lineage card is Slice-3 completion authority.

If Slice 3 fires lineage and implementation/test histories admit repeated join/exit from the same predecessor, `LATER-03` must be resolved before the classifier accepts such histories.

Do not invent a "latest exit wins" or "lowest warrant ID wins" rule.

## F4. Missing observation route for Household recognition

If a required Slice-3 scenario needs an outsider to recognize H without direct participation and without communication, and no accepted event-specific observation route covers it, stop.

`S2-D01-GENERAL-NONPARTICIPANT-OBSERVATION` remains deferred. Do not create proximity/co-residence omniscience.

## F5. Formation/continuity needs semantics beyond accepted closure rules

If implementing automatic formation/continuity appears to require:

- event-sourced current authority;
- same-cycle fresh voluntary reactivation;
- mid-cycle checkpoint publication;
- parallel/non-deterministic execution;
- hidden global organization inference;
- a generic graph database/dependency engine;

that is an architectural escalation, not a routine refactor.

The accepted single-threaded deterministic reference kernel already has the necessary broad shape. A need to abandon it would require explicit architectural justification.

## F6. Ambiguous continuity / duplicate-formation cases beyond accepted precedence

The accepted rule covers the same-evidence case: valid continuation/participation to non-Dissolved H takes precedence over duplicate formation.

If implementation encounters a materially different ambiguity not determined by accepted warrants/evidence — for example several independently valid existing-H continuity interpretations for one causal bundle — do not pick by container/ID order. Escalate the missing semantic rule.

## F7. Provision state requires new ownership or resource semantics

If grounded capability cannot be implemented while keeping grain personal until a permitted collective spend, do not create:

- Household treasury grain;
- ownership transfer on commitment;
- fractional/reserved shadow balances not authorized by accepted semantics;
- generic spending authority.

Escalate the requirement conflict instead.

## F8. Head/authority races become executable

`LATER-04` covers authority-destroying transitions versus already accepted authority-dependent actions. It remains later unless Slice 3 pulls such actions into executable scope.

If that happens, the trigger has fired and must be resolved before coding the race.

## F9. Mediated marriage requires expanded response topology

`LATER-05` remains deferred until household-mediated marriage is executable. If Slice-3 capability scope makes it executable, stop before inventing nested response/authority ordering.

## F10. Verification hardening that has now reached its trigger

These are not new social semantics, but they are pre-completion engineering/verification obligations once their subject becomes executable:

- `VH-01` — exit-side ContinuationWarrant proof must explicitly cover the semantic requirement from both entry/exit directions;
- `VH-06` — Household/reaction-chain derived-state refresh timing needs targeted verification;
- `VH-03` — reused verified checkpoints must carry producer/pass/fixture-audit provenance if Slice-3 acceptance reuses them.

They should be handled in the acceptance-authority/reconciliation work, not silently weakened in implementation.

---

## 4. Architecture pressure points in more detail

### 4.1 The current reaction closure is narrower than Slice 3

Current closure has a specialized `AttitudeBatch` and a debt-review hook. Slice 3 requires a chain in which one automatic consequence can enable another:

`support/communication commit`  
→ `epistemic acquisition`  
→ `CandidateRecognition now satisfied`  
→ `FormationWarrant / Household`  
→ `founding SustainingParticipant associations`  
→ `founder Household recognition`  
→ optional downstream lineage evaluation  
→ stable lifecycle publication

The implementation must guarantee termination/idempotence and monotone causal ordering without opening personal/household deliberation again.

This is why the classification is **substantial kernel extension** rather than merely adding records.

### 4.2 CandidateRecognition is currently derived on read

`EpistemicState.Of(actor)` computes CandidateRecognition from held facts each time. There is no separate authoritative CandidateRecognition record stored in the mutable epistemic state.

That can remain an implementation choice: accepted semantics require evidence-backed Recognition behavior, not a particular cache.

But a formation reaction must consume the accepted recognition meaning at the correct causal point. It cannot wait for an arbitrary observer read, and it cannot use objective facts as a substitute.

If implementation introduces caching for recognition, ADR-0003 requires the cache not to become hidden semantic authority.

### 4.3 Current action validation is world-centric

`ActionRules.Invalid/Infeasible` take `WorldSnapshot`. Communication is the one current action whose "sender holds this proposition" validity is checked separately against `decisionEpistemic` in `RunCycle`.

Household-specific actions add another accepted subjective gate: intentionally acting toward H requires recognizing H, and authority-channel use requires appropriate role recognition when that later slice exists.

That means there is an existing precedent for bounded epistemic validation outside generic world-only rules. Do not solve this by making `ActionRules` or policy code omniscient.

### 4.4 Formation evidence qualification must be semantic, not stringly generic

Current support acquisition is keyed from event `Kind` strings for current person-person support meanings. Slice 3 adds events whose material shape can resemble support but whose semantic origin is Household feedback.

The implementation needs a robust enough semantic distinction that a shared transfer helper cannot erase the difference between:

- ordinary qualifying person-person support;
- Household-originated support;
- other nonqualifying material movement.

Exact type/enum representation is engineering-local; the qualification distinction is semantic authority.

### 4.5 New state must participate in revalidation and detached projection

Every accepted proposal is revalidated against all action-relevant preconditions immediately before commit.

For Slice 3, those may include:

- H still non-Dissolved;
- actor/counterpart still has the required SustainingParticipant status;
- designated continuity bridge still exists;
- actor still recognizes H as required;
- support/relationship/residence prerequisites still hold;
- provision commitment/capacity still valid where applicable.

If detached dependency analysis omits these new state dimensions, technical-fallback disclosure and permutation sensitivity can become incorrect even if the direct commit path is correct.

---

## 5. What should *not* broaden in Slice 3

Nothing reviewed here establishes a need to add:

- Household head/office occupancy/succession before the boundary is resolved;
- `HouseholdDecisionContext` or a second initiative merely because Household identity now exists;
- generic organizational sovereignty;
- generic membership;
- pooled Household resources;
- trust, lying, rumor, reputation, or generalized social epistemics;
- a generic organization ontology;
- event-sourced current state;
- persistence/checkpoint format (Slice 5);
- stochastic policy;
- strategic multi-step planning;
- concurrency/distributed execution;
- a universal lineage/genealogy subsystem;
- richer autonomous communication motivation;
- a redesign of the existing reference scorer.

Slice 3 should extend the verified kernel only as far as accepted Household formation/continuity/capability authority requires.

---

## 6. Recommended implementation-planning decomposition after authority reconciliation

This is a surface decomposition, not a design prescription.

1. **Close semantic/scope triggers first**
   - `LATER-01` candidate convergence;
   - exact Slice-3 lineage applicability;
   - exact provision/capability versus head-role boundary;
   - verification-hardening triggers that now fire.

2. **Add the minimum authoritative Household substrate**
   - stable H identity;
   - required warrants/associations/lifecycle;
   - immutable published/query view;
   - reference validation.

3. **Extend the epistemic model only for fired Household propositions**
   - founder direct recognition;
   - Household existence/continuity evidence;
   - communication of held evidence/recognition;
   - no general new observation system.

4. **Add automatic formation/continuity closure**
   - evidence + founder recognition preconditions;
   - cause-key/idempotence discipline;
   - no `FormHousehold` action;
   - stable closure only.

5. **Add participation actions and same-cycle handoff ordering**
   - bilateral request/invite/accept/end;
   - immediate revalidation;
   - semantic bridge priority;
   - no residence shortcut.

6. **Add optional fired Slice-3 capability/lineage substrate**
   - only after the acceptance boundary says it is required;
   - no head/office preimplementation.

7. **Extend independent verification**
   - fixture write-set auditing;
   - independent warrant/lifecycle reconstruction;
   - permutation/ablation/no-self-confirmation controls;
   - preserve Slice-1 / Slice-2 regressions unchanged in meaning.

---

## 7. Conclusion

**Classification: SUBSTANTIAL KERNEL EXTENSION.**

Slice 3 is larger than Slice 2 because it adds the first persistent higher-order identity and the first automatic reaction chain whose correctness depends on historical warrants, subjective founder recognition, participation transitions, continuity precedence, and stable-cycle lifecycle publication.

It is nevertheless **not an architecture redesign**.

The current verified architecture already provides the required foundations:

- explicit typed authority;
- immutable stable snapshots;
- actor-specific epistemic state;
- causal semantic history;
- deterministic proposal/response/revalidation/commit;
- automatic reaction closure;
- detached same-cycle dependency analysis;
- deterministic ordering and disclosed fallback;
- independent acceptance verification.

The key implementation discipline is to extend those seams without collapsing distinctions the accepted model deliberately preserves:

**objective state ≠ actor recognition; candidate ≠ Household; Household identity ≠ participant set; lifecycle ≠ identity; residence ≠ participation; continuity ≠ similarity; capability ≠ pooled ownership; technical ID order ≠ social convergence.**

No production code should begin until the fired candidate-convergence trigger and the Slice3/Slice4 capability boundary have been reconciled into implementation-facing authority.

---

## Appendix A — exact source evidence index at base `7deb43a7c2d40403f0a9cd6c600fba9db5cebf26`

### Accepted authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` — blob `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` — blob `66cfd55f8b960ff5664638c41c0e731257902be5`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` — blob `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md` — blob `9ce78a311f006215a2afe3575065005e74c4e916`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md` — blob `43eedd7eb49e1eae035010332883ed2d8726d451`
- `architecture/accepted/ADR-0005_HOST_RUNTIME.md` — blob `7e6732a928656da28d299a4d78bf27d1ffc139f5`

### Required verification / project evidence

- `plans/verification/SFL_V0/FORMATION_FAMILY.md` — blob `d3280e441f1bc273474c5a5b453a88e48aa41394`
- `plans/verification/SFL_V0/CONTINUITY_TURNOVER_FAMILY.md` — blob `30e596a44df4eea868829c24b2fd4c3744d2a3c2`
- `plans/verification/SFL_V0/LINEAGE_FAMILY.md` — blob `352669d3ef647fb13b518bc613aafa81605a47a1`
- `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md` — blob `cb979360e3a61239b5e918979dd01f48e0b3867e`
- `plans/verification/SFL_V0/NO_SELF_CONFIRMATION_FAMILY.md` — blob `c29647fa5404a6f4c7c0e3ceb7226645c2fb5eb5`
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md` — blob `7d765988330146ddedd5e9849108eaf10831717d`
- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md` — blob `4bdd96c7f9cec13e8210c5a97de7b04a41a2ddf2`
- `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md` — blob `cf7f7061b31c3323cfade6fac2632fba9c5c1feb`
- `research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md` — blob `7948bf38bfebfde146939ec16550afb777a99ac0`
- `research/technical/SFL_V0_OBSERVATIONS/RUN-0002_EPISTEMIC_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md` — blob `5afdce550b2682c671a072fad559b7af8abdac59`

### Production implementation inspected

- `src/Mesopotamia.Sim/State.cs` — blob `a55bd0e73292a9c96450e8dc74e3337b5587b28e`
- `src/Mesopotamia.Sim/EpistemicState.cs` — blob `299a77d83757277de4d72de641f1a44b947b12d8`
- `src/Mesopotamia.Sim/EpistemicExecution.cs` — blob `90dd7b256b2b5735b5e07a1658071dbdf99c9bac`
- `src/Mesopotamia.Sim/Simulation.cs` — blob `7286cfad351424627bb37a18fabc86390e88d7d6`
- `src/Mesopotamia.Sim/Execution.cs` — blob `03c2a398ac58fb7f2af7024d0d0a52796c266850`
- `src/Mesopotamia.Sim/Decisions.cs` — blob `21677563e640cdde46e3c95229416a473263a159`
- `src/Mesopotamia.Sim/PersonalDecisionInputs.cs` — blob `5dd6b1cbbc84bcf3c7469cfa5d17e10862d80f3a`
- `src/Mesopotamia.Sim/ResolutionDependencies.cs` — blob `f2d46623bd142760bf4f3170539ff66573f5ba78`
- `src/Mesopotamia.Sim/Agency.cs` — blob `50504860e5ee5558a5d6e738af654f24833008dd`
- `src/Mesopotamia.Sim/MaterialRecovery.cs` — blob `f83b80bc0e2e8fd76559bfeaec85ce3e9532b86f`
- `src/Mesopotamia.Sim/VerificationAccess.cs` — blob `c378090058205bed18ed04b7ece083ba71ad818c`

### Acceptance implementation inspected

- `tests/Mesopotamia.Sim.AcceptanceTests/README.md`
- `tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceCatalog.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceTests.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` — blob `a2204947dc1c7704a90af1efa44170e0b39296e0`
- `tests/Mesopotamia.Sim.AcceptanceTests/FixtureAudit.cs` — blob `7de2230ac18db7b741157e967a4603bd4284054a`
- `tests/Mesopotamia.Sim.AcceptanceTests/InvariantOracle.cs` — blob `e754486681e9a1300f0c14363b52966a6b23d6eb`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice2AcceptanceTests.cs` — blob `2e9429f091b5eebfc87cf7d4cfdf5a812391cb35`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice2Scenarios.cs` — blob `cc01d67c0c42ce1ff051ec0dd341c7d1a527b131`

The remaining Slice-1 scenario files were inspected as part of the current acceptance-test inventory; their role is preserved regression evidence rather than a new Slice-3 semantic source.
