# TRES-0010F — Future-Slice Compatibility / Irreversibility Report

## Run provenance

- **Task ID:** TRES-0010F
- **Frozen baseline ref:** tres-0010-review-baseline
- **Resolved baseline commit:** 8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac
- **Model/configuration:** GPT-5.6 Sol; reasoning configuration not exposed in the chat UI
- **Dedicated branch/workspace:** tres-0010/f
- **Tools used:** GitHub repository connector for branch/ref resolution and baseline file retrieval; no local code execution
- **External web research:** no
- **Prior TRES-0003–0009 read:** no; accepted SPEC/ADR/verification artifacts were used instead
- **Sibling Wave-A returns read before initial report:** no

## 1. Executive finding summary

The accepted architecture is broadly future-compatible, and this review found **no genuine architectural blocker** requiring a redesign of ADR-0001 through ADR-0004 or SPEC-SFL-0001.

However, IMP-0001 leaves four locally reasonable Slice-1 implementation choices insufficiently constrained. Each choice could pass the in-scope Slice-1 acceptance cards while making Slices 2–5 require a central substrate rewrite:

| Finding | Risk | Classification | Severity | Disposition |
|---|---|---|---|---|
| F-01 | Slice-1 behavioral code can become coupled to omniscient objective state instead of an actor-scoped subjective/query boundary | future-slice coupling / implementation hazard | HIGH_REPAIR_BEFORE_CODE | Add IMP-0001 guardrail |
| F-02 | Initiative/proposal identity can collapse “acting context” into PersonId, blocking later personal + household dual mode | future-slice coupling | HIGH_REPAIR_BEFORE_CODE | Add IMP-0001 guardrail |
| F-03 | Central resolution can be implemented as pairwise proposer/target mutation, too narrow for atomic multi-contributor household provision | future-slice coupling / implementation hazard | HIGH_REPAIR_BEFORE_CODE | Add IMP-0001 guardrail |
| F-04 | Semantic history can be implemented as explanatory logging rather than first-class addressable evidence needed by formation/recognition/warrants | future-slice coupling | HIGH_REPAIR_BEFORE_CODE | Clarify IMP-0001 history contract |

These are **handoff/implementation-guardrail defects**, not new social semantics. None requires implementing household identity, recognition, provision, head roles, lineage, generic delayed processes, or checkpointing in Slice 1.

**Recommendation:** AMEND BEFORE IMPLEMENTATION.

## 2. Must preserve now / safe to defer

| Seam | Must preserve now | Safe to defer | Assessment |
|---|---|---|---|
| Stable identity and relation history | Stable semantic IDs; historical references remain resolvable; completed relations/events are not erased when later semantics may cite them | Production persistence/database/archive layout | Mostly protected by ADR-0001, SPEC §9.4, IMP-0001 invariants; F-04 clarifies semantic-event accessibility |
| Objective vs subjective state | Behavioral/decision logic must cross an actor-scoped semantic query/view boundary rather than retain an omniscient world-store dependency | Full KnownFact / Recognition implementation and evidence-resolution rules | **Missing IMP guardrail — F-01** |
| Causal provenance/history references | Consequential committed events need stable IDs, typed meaning/origin, Cycle/ReactionIndex, causal refs, and semantic queryability | Household/participation/continuation/lineage warrant types | **Missing IMP clarification — F-04** |
| Personal / response / household decision contexts | Proposal/trace/initiative ownership must distinguish semantic decision context from the human person carrying cognition | HouseholdDecisionContext behavior and household scoring profiles | **Missing IMP guardrail — F-02** |
| Pending/delayed process compatibility | Future-influencing time/order state explicit; no coroutine/task-stack authority; stable closure boundaries | Generic delayed-process scheduler and checkpoint codec | Already protected by ADR-0004, IMP-0001 §3.3, engineering guardrails |
| Derived-state rebuilding | Authoritative-vs-derived distinction; semantic/query boundaries; caches/indexes rebuildable | Dependency framework, caching strategy, incremental engine | Already protected by ADR-0003, ADR-0004, Architecture Development Policy |
| Eventual checkpoint completeness | No ambient/static future-influencing state; ID/order/config/time state explicit and serializable in principle | Save/load implementation and encoding | Already protected by SPEC §9.6, ADR-0004, IMP-0001 §3.3 |
| Household warrants / lineage references | Lower-level evidence must remain independently addressable after later state changes | Warrant classifiers and lineage projections | **F-04 is the relevant preservation seam** |
| Future provision / head-role integration | Central commit contract must not assume a two-person write set; conflict/priority mechanism must be extensible | Provision commitments, allocation algorithm, head semantics | **Missing IMP guardrail — F-03** |
| Migration behind semantic/query boundaries | Behavioral code does not scatter storage-specific lookups; derived access remains semantic | Scale-specialized data structures | Already protected by ADR-0001 / ADR-0003 |
| ADR-0003 scale specialization | Reference behavior remains simple and substitutable; optimization does not redefine meaning | Incremental/dataflow/GPU/distributed strategies | Safely deferred |

## 3. Detailed findings

### F-01 — Actor decision code can accidentally bind to omniscient objective state

- **Classification:** future-slice coupling / implementation hazard
- **Severity:** HIGH_REPAIR_BEFORE_CODE

**Evidence**

- SPEC-SFL-0001 §6 requires objective world state, KnownFact, and Recognition to remain distinct; §6.6 makes recognition causally gate household-specific actions.
- SPEC-SFL-0001 §5.1 says ResponseDecisionContext reads the target's subjective state from the common committed snapshot.
- RECOGNITION_INFORMATION_FAMILY VS-SFL-030 requires two actors in the same objective world to receive different candidate sets solely because their subjective evidence differs.
- VS-SFL-031 requires stale outsider head recognition to survive an unwitnessed objective succession.
- IMP-0001 §3.4 requires personal/response agency and traces, but does not explicitly prohibit candidate generators/scorers from holding or querying the authoritative world store directly.
- ADR-0004 separates state/query and agency as logical responsibilities, but it does not by itself specify the implementation-facing actor-view boundary.

**Smallest plausible Slice-1 choice**

Implement PersonalDecisionContext and ResponseDecisionContext with a reference to WorldState/StateStore and let candidate generators read any current relation/material fact directly. This is locally convenient in Slice 1 because most exercised information is self-state, direct-party relations, or resolver feasibility, and the Slice-1 card set does not yet require stale household recognition.

**Failure trace in Slice 2**

1. H objectively exists with head B.
2. Outsider X still holds older evidence that A is head and has not observed succession.
3. Candidate generation calls world.GetCurrentHead(H) and exposes the mediated-household route through B.
4. X behaves as if it knew the succession.
5. VS-SFL-031 fails; repairing it requires rewiring candidate generation/scoring away from the raw world store and through per-actor subjective state.

**Why existing authority does not fully answer it**

The semantic answer is clear: subjective state must differ from objective state. The handoff gap is that IMP-0001 does not state the narrow Slice-1 implementation constraint that preserves this future boundary while recognition itself remains out of scope.

**Consequence if ignored**

The first behavioral APIs can fossilize an omniscient-read assumption. Slice 2 then becomes a cross-cutting rewrite of personal candidate generation, response generation, trace capture, and possibly test fixtures rather than an additive subjective-state layer.

**Recommended disposition**

Amend IMP-0001 with a guardrail equivalent to:

> Behavioral decision code must obtain semantic inputs through an actor/context-scoped read/query surface distinct from the authoritative resolver/commit surface. Slice 1 need only expose the minimal self/direct-party facts required by in-scope actions; it must not implement general KnownFact/Recognition early, and decision code must not retain an omniscient mutable WorldState handle.

The exact interface/type remains a local implementation choice.

**Confidence / uncertainty:** high. The future semantic requirement is explicit; uncertainty is only the cheapest concrete API shape.

---

### F-02 — Person identity can be accidentally made synonymous with decision-context / proposal-source identity

- **Classification:** future-slice coupling
- **Severity:** HIGH_REPAIR_BEFORE_CODE

**Evidence**

- SPEC-SFL-0001 §8.5 requires one head person P to retain one personal initiative while H receives a separate HouseholdDecisionContext(H, head=P).
- HEAD_ROLE_AND_DUAL_MODE_FAMILY VS-SFL-064 requires two separate decision traces from the same committed snapshot.
- VS-SFL-065 requires P's personal proposal and H's household proposal to coexist and conflict in central resolution.
- RECOGNITION_INFORMATION_FAMILY VS-SFL-034 explicitly says household initiative remains a different context even when the same person is the head.
- Slice-1 verification already requires multiple ResponseDecisionContexts per target, but IMP-0001 does not explicitly require initiative/proposal/history identity to be context-scoped rather than keyed only by PersonId.
- IMP-0001 §3.7 mentions proposer/target/role context in history, which is helpful but not sufficient to prevent a one-person/one-proposal-source scheduler.

**Smallest plausible Slice-1 choice**

Use Dictionary<PersonId, PersonalProposal> (or equivalent) as the cycle's initiative plan and model Proposal.Proposer as PersonId. Responses live in a separate incoming-response list. This satisfies one personal initiative per person and can pass Slice-1 response cards.

**Failure trace in Slice 4**

1. P is head of Active H.
2. P's personal context selects Gift(P -> C).
3. H's HouseholdDecisionContext through P selects HouseholdSupport(H -> B).
4. The proposal collection keyed by P either overwrites one proposal, rejects the second as “extra initiative,” or attributes both to the same personal actor/context.
5. VS-SFL-064/065 fail; history cannot correctly separate personal cognition/action from household-scoped action.

**Why existing authority does not fully answer it**

SPEC-SFL-0001 fully defines the future semantic distinction, but IMP-0001 permits the internal proposal/transition structure as a local decision and does not say that “actor/person” and “decision context / semantic action origin” must remain separable in Slice 1.

**Consequence if ignored**

The scheduler, proposal schema, initiative accounting, trace keys, and resolver inputs can all need coordinated change when household action arrives. That is exactly the kind of code inertia TRES-0010 is meant to prevent.

**Recommended disposition**

Amend IMP-0001 to require that initiative accounting, proposal origin, and decision traces can distinguish at least:

- personal context carried by person P;
- response context for target P and proposal Q;
- future role/household context carried by P but semantically owned/scoped by H/role.

Do not implement HouseholdDecisionContext in Slice 1. Merely prohibit PersonId from being the only semantic key for every decision/proposal source.

**Confidence / uncertainty:** high.

---

### F-03 — Pairwise transition assumptions can make future household provision a central resolver rewrite

- **Classification:** future-slice coupling / implementation hazard
- **Severity:** HIGH_REPAIR_BEFORE_CODE

**Evidence**

- IMP-0001's in-scope lower-level material actions are naturally pairwise: gifts/help, loans/repayment, benefit-for-favour, residence, and direct marriage.
- SPEC-SFL-0001 §8.1 requires one household expenditure to validate and atomically debit an ordered vector of multiple personal contributors.
- PROVISION_GROUNDING_FAMILY VS-SFL-046 requires fixed precommit ranking, multi-contributor debit, all-or-nothing failure on insufficient total capacity, and exact debit-vector history.
- SPEC §9.2 plus RESOLUTION_REACTION_FAMILY VS-SFL-072 and HEAD_ROLE_AND_DUAL_MODE_FAMILY VS-SFL-065 require semantic priority across household support, other household provision expenditure, and ordinary personal transfer.
- ADR-0004 requires authoritative mutation through central validation/resolution/commit, but does not constrain the arity/shape of a transition write set.
- IMP-0001 §3.6 requires a “narrow central transition path” while leaving the internal proposal/transition structure local.

**Smallest plausible Slice-1 choice**

Represent every accepted attempt as one source actor + one target actor + one relation/resource effect. Conflict detection keys only proposer/target grain, and commit helpers mutate those two records atomically.

**Failure trace in Slice 3/4**

1. Household H has contributors A and B with exposed capacities 5 and 3.
2. H proposes one 6-grain expenditure.
3. Correct semantics require one precommit calculation, rank A then B, debit vector {A:5, B:1}, and a single atomic commit.
4. A pairwise engine must split the expenditure into mini-transfers or special-case a new path outside the normal transition contract.
5. Splitting permits partial authoritative debit and/or reranking, violating VS-SFL-046; a separate household path violates the “central resolution” architecture and complicates conflict priority with personal proposals.

**Why existing authority does not fully answer it**

The future semantics and central-resolution rule are explicit, but Slice 1 does not need a multi-contributor action. Without an implementation guardrail, a pairwise transition contract is a reasonable local design and is not rejected by current in-scope cards.

**Consequence if ignored**

Slice 3 requires changing the core proposal/effect/validation/commit representation precisely when household semantics are being introduced, increasing the risk that special household code bypasses ordinary revalidation, failure meanings, or history.

**Recommended disposition**

Amend IMP-0001 with a guardrail equivalent to:

> The central transition contract must not assume that every future action affects only proposer and target or only one resource owner. Validation/conflict representation and atomic commit must admit an extensible semantic write/effect set and semantic priority class, even though Slice 1 only instantiates the narrower pairwise cases.

This does not require implementing multi-contributor provision now.

**Confidence / uncertainty:** high.

---

### F-04 — Slice-1 semantic history can be mistaken for diagnostics even though later slices consume lower-level history as causal evidence

- **Classification:** future-slice coupling
- **Severity:** HIGH_REPAIR_BEFORE_CODE

**Evidence**

- DEC-0001 says households emerge from durable configurations of lower-level social reality and history; causal observability/historical legibility are architectural concerns.
- ADR-0004 says consequential commits emit semantic history/provenance while current state remains authoritative.
- SPEC-SFL-0001 §6 requires KnownFact/Recognition provenance to underlying source/events.
- SPEC §7.2 requires FormationWarrant to reference durable ties, support events, recognition evidence, earliest sustaining evidence, and formation time.
- FORMATION_FAMILY VS-SFL-001 requires two lower-level committed support events on distinct cycles and direct FormationWarrant references to them.
- NO_SELF_CONFIRMATION_FAMILY requires household-originated support to remain distinguishable from ordinary person-person support so it cannot self-confirm formation/lineage.
- LINEAGE_FAMILY later requires direct historical warrant/event references and rebuildable lineage projections.
- IMP-0001 §3.2 requires explicit semantic transfer/action records and §3.7 requires retained history with IDs and causal predecessor references, but §3.7 frames the history primarily as “needed to explain,” leaving room for an implementation that treats it as a diagnostic log rather than a semantic evidence/query substrate.

**Smallest plausible Slice-1 choice**

Emit immutable JSON/text diagnostics for committed Gift/Loan/Favour/Residence events and keep only current relation/material records in the domain store. IDs exist in log entries, satisfying explainability, but there is no typed semantic-event lookup/query boundary and no guarantee referenced records remain available to domain rules.

**Failure trace in Slice 2/3**

1. Two qualifying support commits occur on different cycles.
2. Later actors communicate event-backed propositions and acquire sufficient CandidateRecognition evidence.
3. Formation logic needs to ask which committed semantic events satisfy the recurrence predicate and create a FormationWarrant that directly references them.
4. The only source is diagnostic log parsing, or the implementation introduces a second duplicate “formation evidence” store.
5. Either history has become accidental execution authority through logging infrastructure, or Slice 1's history model must be redesigned into first-class semantic records.

**Why existing authority does not fully answer it**

The accepted semantics clearly require historical evidence and stable references, so this is not a semantic ambiguity. The ambiguity is implementation-facing: “semantic history/provenance” versus optional diagnostics/traces is not sharply separated in IMP-0001.

**Consequence if ignored**

Recognition, formation, continuity, lineage, explanation, and checkpoint/reference integrity all converge on an event/provenance substrate that may not exist in usable form. Retrofitting it later touches IDs, storage, event types, causal refs, tests, and decision traces.

**Recommended disposition**

Clarify IMP-0001 that:

- consequential committed semantic events are typed, independently addressable records with stable IDs and semantic query access;
- causal references target those records, not runtime object identity or rendered log text;
- retention of those records is part of the semantic substrate when future rules may cite them;
- diagnostic candidate/score traces remain distinguishishable from semantic event/provenance records;
- current world state remains authoritative for current material/relation state — this is **not** a request for event-sourced reconstruction.

No future household/warrant types need to be implemented in Slice 1.

**Confidence / uncertainty:** high on the seam; medium-high on severity because a careful implementer could infer the intended distinction from the full SPEC, but the current packet does not force it.

## 4. Attempted attacks that did not expose a defect

### A. Stable identity / historical relation survivability

**Attack:** Assume mutable names, participants, collection positions, or runtime allocation identity are used as semantic identity.

**Result:** rejected by existing authority. ADR-0001 explicitly forbids semantic identity from mutable content/container/runtime position. IMP-0001 repeats stable-ID requirements, and cross-cutting verification requires live/historical reference resolution. No additional blocker.

### B. Hidden primitive household-membership shortcut

**Attack:** Seed a convenience Person.HouseholdId or hidden membership set in Slice 1 “for later.”

**Result:** explicitly blocked. IMP-0001 says not to implement a hidden household-membership container for later convenience; DEC-0001/SPEC-SFL-0001 prohibit household-as-container semantics. No additional blocker.

### C. Delayed-process / debt-timing dead end

**Attack:** Require Slice 1 to implement a generic delayed-process scheduler immediately because Slice 5 will need serializable pending work.

**Result:** false positive. ADR-0004 already fixes the semantic contract for serializable delayed/interruptible work and deterministic ordering/revalidation. IMP-0001 §3.3 explicitly says the generic system is out of scope while requiring all future-influencing Slice-1 state to be explicit/serializable in principle. Debt due review and periodic maintenance can remain simple reference logic now.

### D. Checkpoint implementation required in Slice 1

**Attack:** Claim checkpoint/save-load must be implemented now to avoid later incompatibility.

**Result:** false positive. SPEC §9.6 and ADR-0004 already define completeness/safe-boundary semantics; engineering guardrails prohibit CLR object-graph persistence as continuation authority; IMP-0001 requires future-influencing state to remain explicit/serializable in principle. The codec/storage mechanism is safely deferred.

### E. Derived-state framework needed now

**Attack:** Require a dependency graph/incremental engine in Slice 1 because later household provision/lineage/recognition will add derived queries.

**Result:** false positive. ADR-0003 and Architecture Development Policy explicitly require progressive specialization behind stable semantic/query boundaries, rebuildable derived state, and reference recomputation where practical. A generic framework now would violate the accepted simplicity policy.

### F. Production-scale optimization needed before future slices

**Attack:** Preemptively choose ECS/graph DB/dataflow/GPU/distributed machinery so later household graphs scale.

**Result:** false positive. ADR-0003 and Architecture Development Policy deliberately defer stronger machinery until measured workload justifies it. The correct preservation seam is semantic/query boundaries, not speculative optimization.

### G. Household/lineage semantic types must exist in Slice 1

**Attack:** Require CandidateOrganization, Household, ParticipationWarrant, ContinuationWarrant, LineageWarrant, provision commitments, and head roles to be stubbed now so references compile later.

**Result:** false positive. IMP-0001 correctly excludes these features, and early stubs would risk creating primitive/incorrect semantics. The required preservation is lower-level IDs/history/query/transition seams, not future domain objects.

## 5. Places this review could not determine from accepted artifacts

1. **Exact C# API/type shape** for actor-scoped query views, decision-context identity, transition effect sets, and semantic event storage is intentionally not decided. This report therefore recommends constraints, not concrete class hierarchies.
2. **Performance cost** of keeping typed semantic history addressable through the first five slices is not quantified. ADR-0003 already supplies the migration rule if history indexes later become expensive.
3. **Checkpoint encoding/version migration** remains deliberately undecided and was not treated as a blocker.
4. **Generic pending-process scheduler representation** remains deliberately undecided; only the ADR-0004 semantic boundary is required now.

None of these unknowns prevents the four packet-level guardrails above from being stated before code.

## 6. Prior TRES findings read

- TRES-0003: not read.
- TRES-0004: not read.
- TRES-0005: not read.
- TRES-0006: not read.
- TRES-0007: not read.
- TRES-0008: not read.
- TRES-0009: not read.

Accepted artifacts sometimes cite or summarize earlier TRES resolutions; this review used those accepted artifacts as authority and did not inspect the prior review returns themselves.

Sibling TRES-0010 Wave-A returns were not read before finalizing this report.

## 7. Recommendation

**AMEND BEFORE IMPLEMENTATION**

No accepted architectural decision needs reversal. Before releasing IMP-0001, add narrow guardrails that preserve four seams:

1. actor-scoped subjective/query access separate from resolver/objective access;
2. decision-context/proposal-source identity separate from PersonId;
3. central transition/commit representation not limited to pairwise proposer-target write sets;
4. consequential semantic history as typed, stable, queryable evidence distinct from diagnostic logging.

These amendments keep Slice 1 minimal while preventing locally attractive implementations from consuming the architectural room required by Slices 2–5.
