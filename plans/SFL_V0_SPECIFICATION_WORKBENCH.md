# Social Fabric Laboratory v0 — Specification Workbench

**Status:** ACTIVE WORKING PLAN / NON-AUTHORITATIVE  
**Owner:** Master Architect  
**Purpose:** Structure Step 2 of the First-Prototype Development Roadmap: specify the smallest faithful Social Fabric Laboratory v0 before implementation.

This document organizes questions and decision work. It is **not** the v0 specification and creates no simulation authority.

---

## 1. Target

Produce one bounded specification that an implementation agent can build without inventing foundational social semantics.

SFL v0 must exercise:

- persistent individuals;
- meaningful relationships / obligations;
- subjective recognition;
- household formation and persistent identity;
- one grounded collective capability;
- one representative / broker role;
- limited constituent turnover;
- representative succession;
- **basic controlled household division and consolidation** sufficient to test identity/lineage semantics;
- explicit processes, semantic history, and continuation.

The laboratory is a **reference social-mechanism experiment**, not yet a complete historical population simulator.

## Progress

| Pass | Status | Current result |
|---|---|---|
| A — Laboratory boundary | **WORKING-CONVERGED** | Small synthetic controlled world; grain + dwelling/place; minimal kinship present; future-system events may be injected by scenarios; basic persistence/succession/division/consolidation are target behaviors. |
| B — Lower-level social fabric + minimal agency | **ACTIVE** | Initial relation palette selected; action repertoire and person-state semantics still open. |
| C — Subjective recognition | NOT STARTED | — |
| D — Household identity / continuity | NOT STARTED | — |
| E — Collective capability / representative | NOT STARTED | — |
| F — Time / history / continuation | NOT STARTED | — |
| G — Verification closure | NOT STARTED | — |

A pass result remains working/non-authoritative until the final SFL specification is explicitly accepted.

---

## 2. Fixed constraints — do not reopen during v0 specification

Unless a genuine conflict is discovered, v0 must preserve:

1. **Households are not primitive membership containers.**
2. Kinship, residence, ownership/use, support, labor/service, obligation, and institutional affiliation remain distinguishable.
3. Simulation-relevant entities/relations that need independent history use stable identity and explicit references.
4. A household may have persistent identity, but its state/action remains explainable through lower-level people, relations, resources, recognition, rules, and history.
5. Objective world state and actor subjective knowledge/recognition are distinct.
6. An engine-only household label must not become evidence for itself or directly grant unexplained causal power.
7. Household continuity is historical/transmitted, not constituent-set equality or snapshot similarity.
8. Collective capacity must be grounded in lower-level support/resources and must not double-count the same scarce capacity.
9. A representative/broker is a role occupied by a person; changing occupant does not automatically destroy the collective.
10. Individual/collective actions enter shared reality as proposals/attempts resolved through the deterministic commit boundary.
11. Simulated time, pending processes, semantic history/provenance, and continuation state are explicit.
12. C#/.NET and concrete runtime layout must implement these semantics rather than redefine them.

---

## 3. Evidence posture

### What we have

- accepted foundational social and architecture decisions;
- household-organization WIP;
- TRES-0001 technical reconnaissance for state/relations, agency, time/history, household emergence, and verification;
- RES-0001 historical research program design and the historically bounded Old Babylonian Nippur frame.

### Evidence archive status

The original RES-0001 A–H return archives remain recoverable in the project workspace, but their intended durable GitHub archive is **not yet verified present on `main`**. The planned RES-0001R reconciliation is also not complete.

Therefore:

- do **not** manufacture historically specific rules from memory;
- structural/mechanism work may proceed from already accepted decisions and working synthesis;
- before a v0 rule is promoted as historically grounded, retrieve the relevant original return(s), reconcile provenance where necessary, and record the supporting evidence;
- where history cannot determine an algorithm/threshold, use an explicit controlled lab assumption rather than presenting a parameter as historical fact.

The historical evidence lane should answer only questions that can change v0 semantics.

---

## 4. What the specification must contain

For every in-scope mechanism, the final spec must identify:

- authoritative entities / records;
- objective state versus subjective state;
- derived state;
- relevant relationships/arrangements and their meanings;
- allowed proposals/actions;
- transition/resolution rules;
- process/time conditions where relevant;
- causal dependencies;
- semantic history/provenance required for explanation;
- continuation state required for exact resume;
- invariants;
- assumptions and their replacement triggers;
- explicit exclusions;
- observable verification obligations.

Implementation details belong only where semantics cannot otherwise be stated unambiguously.

---

# 5. Seven specification passes

## Pass A — Laboratory boundary and controlled world

**Question:** What exactly exists in the smallest world capable of testing the accepted social foundation?

### Must answer

A1. What lower-level phenomena are initialized directly as scenario inputs rather than generated by future systems?

A2. Which material resource/place concepts are actually needed to ground v0 social behavior?

A3. Which relationship/arrangement types are minimally necessary to produce organization without collapsing distinct social dimensions?

A4. Which transitions may be injected by the scenario harness as controlled stimuli (for example arrival/departure or external resource change) rather than generated by demography/economy?

A5. What does the lab intentionally *not* claim about Old Babylonian frequencies, population structure, wealth, demography, or household prevalence?

### Current design constraint

The world must be rich enough for different proxies to disagree: co-residence alone, kinship alone, or property association alone must not automatically define a household.

### Deliverable

**v0 World Boundary**: entities, initial-state dimensions, controlled external inputs, exclusions.

---

## Pass B — Lower-level social fabric and minimal individual agency

**Status:** WORKING-CONVERGED.

**v0 result:**

- Person objective state: stable identity, male/female sex, grain, NeedsGrain, residence, marriage status/history, and explicit relation references.
- Directed attitude: -100..+100; kinship (parent/child, sibling only) amplifies ordinary attitude-based choice by 1.5x but is excluded from marriage.
- Marriage: groom-proposed, proposal carries dowry; household-mediated route pays dowry from bride household to groom and creates groom -> household-head favour; mutual strong-like bypass avoids household settlement; no-household bride cannot marry without bypass; close kin ineligible.
- Grain: Farm +4; consume 1/cycle; typical start 4-8; missed consumption creates NeedsGrain; NeedsGrain actors cannot Farm.
- Debt: quantified grain claim; no interest/due date; partial repayment allowed; keep 2-grain reserve before repayment.
- Favour: one discrete action-oriented claim per ordered pair; explicit bargain or strong-like reciprocity; call-in cannot compel marriage/impossible acts; favour fulfilment cannot create another favour; reciprocal favours may cancel.
- Transfers remain semantically distinct: gift, loan, explicit benefit-for-favour, reciprocal help.
- Attitude events use fixed +5/+10/-5/-10/-20 magnitudes; positive natural decay is twice negative repair (2 vs 1 toward zero per decay event).
- Residence change is proposal-based; strong positive relation gives weak co-residence incentive, marriage stronger; counterpart consent is sufficient in v0.
- One voluntary initiative per actor per decision cycle; responses do not consume it; deterministic context-sensitive candidate generation and transparent scoring; no v0 randomness.
- No Pass-B subjective state beyond attitude. Information/recognition begins in Pass C.

**Cross-pass dependencies:** household authority/resource grounding for mediated marriage -> D/E; decay cadence -> F.

---

## Pass C — Subjective recognition and information

**Status:** WORKING-CONVERGED at semantic level.

**v0 result:**

- factual knowledge and social recognition are separate subjective layers;
- recognition propositions cover continuing household identity and representative/head role + authority scope; no universal membership proposition;
- recognition state is discrete: Unknown / Recognized / Contested, with evidence provenance;
- recognition is independent of attitude, approval, and compliance;
- own state, direct-party relations, and participated events are automatically known; other observation requires explicit witness/affected-observer rules;
- `CommunicateClaim/Inform` transmits only propositions the sender currently holds, with source/event provenance; no lying, trust score, rumor mutation, or reputation in v0;
- stale information persists; underlying event/observation time outranks message arrival time; unresolved incompatible evidence becomes Contested;
- direct participants learn failed-attempt outcomes and bounded causal reasons (Declined / Unable / InvalidatedAtResolution), without resolver omniscience leaking unrelated private state;
- engine-side household existence never grants universal actor recognition;
- household-specific candidate actions require the actor to recognize the household and, where relevant, its representative/scope;
- household-mediated marriage therefore depends on the groom's subjective recognition of the applicable household/representative route;
- recognition does not decay with attitude;
- structural proxies may supply evidence but do not individually create household recognition.

**Negative control:** same objective household state, different actor recognition -> different availability of household-specific actions.

**Delegated locks before implementation:** event-specific witness rules -> D/E/F; formation/continuity evidence -> D; representative scope/succession evidence -> E; total event ordering -> F; concrete data representation -> final implementation contract.

---

## Pass D — Household formation, persistent identity, and continuity

**Status:** WORKING-CONVERGED.

**v0 result:**

- Non-authoritative `CandidateOrganization` may collect evidence but has no causal powers.
- Formation requires a connected founding core with shared residence, kinship/marriage/mutual-strong-like durable tie, two qualifying support events on separate cycles, and recognition by every required founder.
- Formation creates one persistent household identity plus a provenance-bearing `FormationWarrant`; no universal `Members` set.
- Current household association is `SustainingParticipant`.
- Continuity requires explicit historical transmission through at least one sustaining participant plus recognition of the successor configuration as the same household; similarity alone never preserves identity.
- Lifecycle: Active / Inactive / Dissolved. Inactive may reactivate through continuity; Dissolved cannot.
- Controlled division: both branches may be descendants, but only one retains the old identity through an explicit continuity warrant; v0 uses representative-role continuity + sustaining-participant transmission.
- Controlled consolidation: two active households form a new identity with `DerivedFrom(H1,H2)`.
- Founders directly recognize the formed household; outsiders do not.
- Preserve organization-start time separately from household-recognition/formation time.
- Division/descendant behavior is a scenario-only v0 proof and must be revisited when mortality/lifecycle systems are introduced.

**Dependencies:** representative-role chain -> E; exact event/witness ordering -> F.

---

## Pass E — Grounded collective capability and representative role

**Status:** WORKING-CONVERGED.

**v0 result:**

- Household capability is derived from explicit optional `HouseholdProvisionCommitment` relations; grain stays personal until collective spend commits.
- Capacity per contributor is `max(0, grain - 2)`; `NeedsGrain` contributes zero; expenditure debits real personal grain once, largest surplus first / stable ID tie-break.
- Head may request a non-contributor to reconsider provision; refusal starts a cooldown before another request.
- Provision capacity may fund only 1-grain NeedsGrain support or mediated-marriage dowry.
- One persistent `HouseholdHeadRole`; new household begins vacant; appointment/succession requires nominee acceptance + unanimous sustaining-participant acceptance.
- Role scope: provision requests, the two collective material uses, mediated marriage, succession. No general command authority.
- Occupied role activates separate `HouseholdDecisionContext`: one household initiative through the head in addition to the head's personal initiative; household concerns are evaluated separately from personal concerns.
- Vacancy suspends household-mode spending/marriage mediation but does not destroy household or provision commitments.
- Mediated marriage debits backing grain once, pays groom directly, creates groom -> head favour; groom cannot already owe head a favour or self-authorize as head; female head may mediate own marriage.
- Household support is grounded downward causation and cannot count as independent evidence of household formation/continuity.
- Dissolution simply terminates provision commitments; no collective treasury requires inheritance cleanup.

**Dependencies:** reconsideration cooldown, personal/household activation order, witness/order/history semantics -> F.

---

## Pass F — Temporal execution, processes, history, and continuation

**Status:** WORKING-CONVERGED after `research/technical/TRES-0003/PASS_F_TEMPORAL_RESOLUTION_ADVERSARIAL_REVIEW.md`.

**v0 result:**

- integer `Cycle` plus same-cycle `ReactionIndex`; common post-maintenance decision snapshot;
- personal and household contexts deliberate from same snapshot; no same-cycle voluntary reactivation;
- proposal response -> priority/conflict resolution -> commit-time revalidation -> commit/failure -> automatic reaction closure;
- failure outcomes: Declined / Unable(reason) / InvalidatedAtResolution(reason); participants learn bounded reasons; feasibility failure is not social refusal;
- consumption every cycle; attitude decay every 5 cycles; provision reconsideration cooldown 3 full cycles plus relevant context change;
- only commitments that explicitly authorize/reserve current material capacity gain commitment priority; household NeedsGrain support outranks dowry, which outranks ordinary voluntary personal transfer for competing provision capacity;
- equal-priority unresolved symmetry uses disclosed stable-ID technical fallback and is permutation-tested in G;
- automatic reactions are cause-keyed/idempotent;
- full v0 candidate/gate/score traces retained for diagnostics;
- unrecoverable universal grain shortage is explicit `MaterialDeadlock`;
- checkpoints only at stable cycle boundaries and include all future-influencing authoritative state; rebuildable derived indexes excluded;
- exact restore must reproduce subsequent semantic state/history suffix.

---

## Pass G — Verification closure and spec acceptance

**Question:** Can every important v0 claim be falsified by an observable scenario?

This pass prepares the separate verification-scenario phase but must close semantic ambiguity before implementation.

### Proof obligations

G1. **Formation:** lower-level relations/activity/recognition produce a persistent household identity without a “form household” command.

G2. **Non-formation:** superficial structural similarity or engine-only classification does not produce household effects.

G3. **Continuity:** limited constituent turnover preserves identity only through the specified historical bridge.

G4. **Discontinuity:** removal/termination of the sustaining basis changes/inactivates the collective rather than allowing unlimited identity drift.

G5. **Recognition causality:** two actors with different subjective recognition can face different household-related action possibilities while objective world state is otherwise compatible.

G6. **Grounding:** household capability changes when backing commitments/resources change and never creates/double-spends unbacked resources.

G7. **Representation:** representative occupant can change while role/household identity remain continuous under the defined succession process.

G8. **Proposal/commit:** competing or invalid social actions are resolved by explicit rules, not iteration order.

G9. **Causal legibility:** consequential outcomes can be traced to lower-level facts, actor recognition, proposals/processes, and resolution.

G10. **Continuation:** save/load at a safe boundary produces the same subsequent semantic behavior as uninterrupted execution.

### Final acceptance test for the specification

The spec is ready for approval when:

- every in-scope entity and state distinction has a defined meaning;
- every consequential transition has trigger/validation/effect semantics;
- every collective effect has an explicit lower-level causal path;
- no implementation agent needs to invent household or recognition semantics;
- every temporary arbitrary choice is declared as a controlled assumption with a review trigger;
- deferred questions are explicitly out of scope;
- the proof obligations above can be converted into executable scenarios without changing the model.

---

# 6. Decision classification

Use three buckets while working through the passes.

## A — Must decide before v0 can be specified

Examples:
- exact recognition state used in v0;
- formation criterion;
- v0 continuity bridge;
- one collective capability and its grounding;
- broker authority/succession semantics;
- v0 action repertoire;
- process/revalidation semantics required by these rules.

These are simulation semantics and require Director approval in the final accepted specification.

## B — Controlled lab assumption

Use when implementation/testing needs a value but evidence does not justify project truth.

Examples may include:
- scenario thresholds/quorums;
- synthetic resource amounts;
- number of recurrence episodes;
- abstract time durations;
- initial actor dispositions.

Each assumption must state:
- why v0 needs it;
- what it is *not* claiming historically;
- what evidence/experiment would replace it.

## C — Defer

Do not decide merely to make the model feel complete.

Examples:
- full kinship system;
- demographics/ageing/reproduction/death;
- full property law/economy;
- household fission/consolidation generality;
- contested household identity;
- deep nested organizations;
- administrative specialization;
- general offices/status;
- information diffusion/reputation system;
- strategic multi-step planning;
- production storage/database;
- scaling optimizations.

---

# 7. Working order with the Director

Do not present all questions at once.

For each pass:

1. Master Architect retrieves only relevant evidence.
2. State what is already fixed.
3. Present the **smallest real design fork(s)**.
4. Explain consequences in simulation terms.
5. Recommend one v0 choice.
6. Director discusses/adjusts naturally.
7. Keep the result working/non-authoritative until the pass is coherent.
8. Record controlled assumptions separately.
9. Move to the next pass only when unresolved points no longer infect it.

At the end, synthesize all passes into one concise `SPEC-SFL-0001` proposal for explicit approval.

---

# 8. Research triggers during specification

Commission new research only if it can change one of the A-class decisions.

Likely targeted historical evidence needs:

- which lower-level support/obligation/co-residence/resource distinctions are defensible for the reference lab;
- historically plausible continuity/transmission mechanisms beyond simple membership persistence;
- evidence for household-linked representative/head/broker authority and its limits;
- evidence for resource/support coordination that can ground a minimal collective capability.

Likely technical follow-up needs only if a concrete semantic rule exposes uncertainty:
- minimal subjective-belief representation;
- exact deterministic conflict resolution for an identified v0 conflict;
- checkpoint representation needed for a chosen persistent process.

Do not reopen broad architecture research.

---

# 9. Expected artifacts

During the work:
- this workbench;
- targeted advisory research only when triggered;
- explicit temporary assumptions in `registers/ASSUMPTIONS_REGISTER.md` once adopted for the draft;
- working specification draft.

At closure:
- one concise accepted `SPEC-SFL-0001`;
- synchronized open-question/assumption references;
- a clean handoff into the verification-scenario phase.

Raw debate and discarded alternatives remain in working history/Git rather than bloating the accepted specification.
