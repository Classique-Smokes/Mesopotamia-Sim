# SFL v0 Slice 2 — Acceptance / Applicability Authority Candidate v1

**Status:** CANDIDATE / PRE-CODE REVIEW REQUIRED / NOT FROZEN  
**Candidate version:** `SFL-V0-S2-ACCEPTANCE-CANDIDATE-v1`  
**Owner:** Master Architect  
**Scope:** Roadmap Stage 4 / Slice 2 — subjective recognition + minimal individual agency integration  
**Semantic authority:** `SPEC-SFL-0001` + accepted ADRs only  
**Completion authority:** this file only after independent pre-code review and freeze  
**Slice-1 authority:** `SFL-V0-S1-ACCEPTANCE-v1` remains immutable and is referenced, not edited

## 1. Purpose

Define exactly what Slice 2 must make executable before implementation is allowed to claim completion.

This artifact is subordinate to accepted semantics/architecture.

It may:

- select Slice-2 applicability;
- define omission-detectable completion rows;
- instantiate accepted semantics with bounded laboratory witnesses;
- preserve explicit deferrals;
- require independent conformance evidence.

It may not:

- invent new social semantics;
- expand Slice 2 into household/head/checkpoint mechanics;
- turn the new conceptual tablets into authority;
- decide a general trust, rumor, reputation, perception, planning, or motivation system;
- retroactively alter what Slice 1 proved.

## 2. Controlling accepted contract

Slice 2 must make executable, at minimum:

1. objective world truth remains distinct from actor-specific subjective state;
2. `KnownFact` is actor-relative, persistent, provenance-bearing factual state;
3. `Recognition` remains distinct from `KnownFact`, attitude, approval, obedience, and objective truth;
4. Recognition supports `Unknown / Recognized / Contested`;
5. own objective state, direct-party relations/claims, and directly participated proposals/events are valid automatic knowledge routes;
6. other facts are not globally synchronized and require an accepted acquisition route;
7. `CommunicateClaim/Inform` transmits only a proposition the sender actually holds;
8. communication carries sender and underlying source/event provenance where available;
9. communication normally consumes the sender's one personal voluntary initiative;
10. stale subjective state persists until accepted evidence displaces or contests it;
11. underlying semantic event/observation order outranks message-arrival order;
12. unresolved incompatible Recognition evidence becomes `Contested`, not an arbitrary ID-selected winner;
13. subjective state can causally affect candidate availability;
14. actor decisions still operate through the bounded actor-specific input membrane;
15. commit-time objective revalidation remains authoritative;
16. decision/history traces expose the subjective inputs actually used;
17. observer/debug inspection of epistemic state does not alter behavior.

## 3. Exact Slice-2 implementation boundary

### REQUIRED now

Slice 2 implements only the epistemic substrate needed to exercise the accepted contract above:

- persistent actor-specific factual knowledge;
- persistent Recognition state;
- provenance identity/order sufficient for accepted update rules;
- direct acquisition routes already fixed by SPEC;
- ordinary voluntary communication;
- stale-state retention;
- accepted evidence-order precedence;
- Contested representation;
- integration with personal candidate generation/gating and decision traces;
- read-only inspection sufficient for verification.

### Explicitly outside this slice

Do not implement merely for Slice 2:

- persistent Household identity or lifecycle;
- HouseholdHeadRole / office occupancy / succession;
- mediated marriage through household authority;
- household provision;
- lineage;
- checkpoint/restore;
- generic nonparticipant perception/visibility;
- trust/reliability scores;
- deliberate lying or invented claims;
- rumor mutation;
- reputation;
- brokerage power;
- rich memory decay;
- role-conditioned salience;
- strategic multi-step planning;
- stochastic behavior;
- a universal proposition ontology;
- a universal evidence-strength algebra.

## 4. Bounded proposition vocabulary

Implementation is free to choose representation, but completion evidence may rely only on proposition meanings already grounded in accepted Slice-1 state/events or accepted Slice-2 Recognition semantics.

### Factual witness meanings allowed for Slice-2 completion

At least the following semantic categories must be representable as actor-held factual knowledge where the corresponding accepted acquisition route exists:

- actor's own objective state fact;
- direct-party Debt fact;
- direct-party Favour fact;
- direct-party Residence relation fact where applicable to that actor;
- proposal/event participation fact;
- committed/failed-attempt outcome fact already exposed to direct participants;
- communicated copy/report of one of the above facts.

The completion authority does **not** require a universal arbitrary predicate language.

### Recognition witness meanings

Recognition implementation must support the accepted tri-state model and provenance.

Pre-code review must approve one Slice-2-valid witness for `Contested` that does not require executable Household/head mechanics.

Until that witness is approved, this candidate **may not freeze**.

See Review Gate RG-01.

## 5. Acquisition and communication boundary

### Automatic direct acquisition

An actor must acquire/retain accepted knowledge of:

- own objective state;
- relations/claims where the actor is a direct party;
- proposals/events where the actor directly participates;
- accepted direct-participant failed-attempt outcomes/reasons from Slice 1.

### No passive synchronization

A nonparticipant actor does not learn a changed objective fact merely because:

- the fact exists in `WorldSnapshot`;
- the actor shares a dwelling;
- the event exists in observer `History`;
- another actor knows it;
- a later cycle closes.

### Communication

`CommunicateClaim/Inform`:

- is a personal voluntary action;
- requires the sender to hold the transmitted factual/recognition proposition in their subjective state;
- consumes the sender's one personal initiative on successful ordinary initiation;
- carries sender provenance;
- carries underlying source/event provenance where available;
- does not create a proposition ex nihilo;
- does not become a free engine broadcast;
- does not create a response initiative;
- does not grant same-cycle new voluntary activation to the recipient.

## 6. Evidence ordering boundary

The implementation must preserve these accepted relations and **no broader universal ordering is required**:

1. semantic event/observation order outranks later message arrival;
2. newer accepted direct participation/observation supersedes older incompatible information where SPEC says so;
3. newer event-backed communication may supersede older reports;
4. unresolved incompatible Recognition evidence becomes `Contested`;
5. stable semantic IDs, actor IDs, sender IDs, container order, and arrival order are not semantic recognition winner rules.

## 7. Applicability table

### A. Core epistemic-state rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION` | REQUIRED | Two actors may face the same objective world while holding different subjective state; objective existence alone does not synchronize them. |
| `S2-002-KNOWNFACT-PERSISTENCE` | REQUIRED | Actor-held factual knowledge persists across stable cycles until an accepted update/displacement rule applies. |
| `S2-003-KNOWNFACT-PROVENANCE` | REQUIRED | Every completion-relevant KnownFact exposes provenance sufficient to distinguish direct acquisition from communication and identify underlying event/source where available. |
| `S2-004-RECOGNITION-DISTINCT` | REQUIRED | Recognition is separately inspectable from KnownFact, Attitude, and objective state. |
| `S2-005-RECOGNITION-TRISTATE` | REQUIRED, RG-01 gated | `Unknown / Recognized / Contested` are representable persistent Recognition states. |
| `S2-006-NO-PASSIVE-SYNC` | REQUIRED | Objective change with no accepted acquisition route leaves an uninformed actor stale/unchanged. |
| `S2-007-NO-HISTORY-OMNISCIENCE` | REQUIRED | Observer semantic history cannot be read by actor policy as universal subjective knowledge. |
| `S2-008-LOCALITY` | REQUIRED | Epistemically disconnected actors are unchanged by unrelated events/communications. |

### B. Accepted automatic-acquisition rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-010-OWN-STATE-KNOWLEDGE` | REQUIRED | Actor knows accepted own objective-state facts. |
| `S2-011-DIRECT-CLAIM-KNOWLEDGE` | REQUIRED | Direct parties know the accepted relation/claim facts relevant to them. |
| `S2-012-DIRECT-PARTICIPATION-KNOWLEDGE` | REQUIRED | Direct participants learn accepted proposal/event facts and valid failed-attempt outcomes. |
| `S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION` | REQUIRED | Slice-1 bounded failure reasons remain non-omniscient after epistemic expansion. |

### C. Communication rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-020-COMMUNICATION-ACTION` | REQUIRED | `CommunicateClaim/Inform` is executable through the normal personal-action pipeline. |
| `S2-021-COMMUNICATE-HELD-FACT` | REQUIRED | Sender can communicate a factual proposition currently held. |
| `S2-022-COMMUNICATION-NO-INVENTION` | REQUIRED | Candidate/commit is unavailable or invalid if sender does not hold the transmitted proposition. |
| `S2-023-COMMUNICATION-PROVENANCE` | REQUIRED | Recipient-visible communicated fact retains sender plus source/event provenance where available. |
| `S2-024-COMMUNICATION-INITIATIVE-COST` | REQUIRED | Communication consumes the sender's personal initiative; no second ordinary voluntary initiative occurs that cycle. |
| `S2-025-COMMUNICATION-NO-FREE-BROADCAST` | REQUIRED | Only intended recipient(s) under the chosen bounded action meaning acquire the communication; no global propagation occurs. |
| `S2-026-COMMUNICATION-NO-SAME-CYCLE-REACTIVATION` | REQUIRED | Receiving communication does not create a fresh same-cycle personal initiative/decision snapshot for the recipient. |
| `S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE` | REQUIRED | Directly acquired and communicated versions of the same semantic fact remain provenance-distinguishable. |

### D. Staleness / ordering rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-030-STALE-FACT-PERSISTS` | REQUIRED | Actor retains a previously acquired fact after objective change when no accepted update route reaches them. |
| `S2-031-NEWER-EVENT-BEATS-LATE-OLD-MESSAGE` | REQUIRED | A later-arriving report grounded in an older underlying event cannot overwrite newer accepted evidence merely by arrival time. |
| `S2-032-MESSAGE-ARRIVAL-PERMUTATION` | REQUIRED | Permuting delivery order while preserving underlying evidence order does not change final accepted subjective result where SPEC fixes precedence. |
| `S2-033-RECOGNITION-CONTESTED-NO-ID-WINNER` | REQUIRED, RG-01 gated | Incomparable incompatible Recognition evidence yields `Contested`; actor/sender/stable-ID/arrival order does not select a winner. |

### E. Agency / trace rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-040-SUBJECTIVE-CANDIDATE-GATE` | REQUIRED | Holding the relevant communicable proposition can make the corresponding communication candidate available; absence suppresses that candidate without changing objective world state. |
| `S2-041-GATES-BEFORE-SCORING` | REQUIRED | A subjectively inaccessible candidate is excluded before scoring and cannot win through numeric policy coefficients. |
| `S2-042-SUBJECTIVE-TRACE` | REQUIRED | DecisionTrace records the actual KnownFact/Recognition/provenance basis used for Slice-2 candidate generation/gating/scoring. |
| `S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION` | REQUIRED | Changing unrelated subjective facts does not change candidate outcome where no accepted dependency exists. |
| `S2-044-OBJECTIVE-REVALIDATION-PRESERVED` | REQUIRED | Subjective candidate availability does not bypass normal validity/feasibility/commit-time objective checks. |
| `S2-045-REFERENCE-POLICY-NONCLAIM` | REQUIRED structural/report check | Slice-2 completion does not claim historically meaningful autonomous communication motivation; pinned laboratory policy is allowed. |

### F. Observation / inspection / determinism rows

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-050-EPISTEMIC-READ-NONINTERFERENCE` | REQUIRED | Querying actor epistemic state/provenance does not change later behavior, ordering, IDs, or history. |
| `S2-051-DETERMINISTIC-REPLAY` | REQUIRED | Same initial state/configuration/epistemic inputs produce identical objective and subjective results/history. |
| `S2-052-NONSEMANTIC-ITERATION-INVARIANCE` | REQUIRED | Collection/input iteration order does not become epistemic meaning where no accepted ordering exists. |
| `S2-053-NONSEMANTIC-ID-RENAMING` | REQUIRED | Renaming nonsemantic IDs does not change recognition/knowledge outcome except where the already-disclosed technical fallback is legitimately in play outside recognition conflict. |
| `S2-054-CACHE-NONAUTHORITY` | REQUIRED | Any derived epistemic index/cache is reconstructable/non-authoritative; stale cache cannot alter behavior. |
| `S2-055-CONFIGURATION-PROVENANCE` | REQUIRED | Semantic/decision history truthfully identifies the active Slice-2 rule/configuration version. |

### G. Imported prior obligations

These remain historically DEFERRED in the frozen Slice-1 manifest. Slice-2 completion must provide new Slice-2 evidence for the accepted property; it does not edit the old manifest.

| Prior AcceptanceId | Slice-2 obligation |
|---|---|
| `S1-098-COMMUNICATION` | exercised by S2-020..027 |
| `S1-META-08` | exercised by S2-032 |
| `S1-MUT-27` | exercised by S2-031/032 |
| `S1-MUT-28` | exercised by S2-033, subject to RG-01 |
| `S1-076` | satisfied only if its communication/provenance/contest properties are all substantively evidenced without later-slice fixture fraud |

### H. Regression-protected Slice-1 contracts

Slice 2 must not regress already-passed Slice-1 obligations including:

- bounded participant failure knowledge/privacy;
- one-personal-initiative accounting;
- response/personal-initiative separation;
- observer noninterference;
- full decision traces;
- disconnected-population locality;
- derived-cache nonauthority;
- fallback disclosure/quarantine;
- deterministic commit/reaction closure;
- manifest/frozen Slice-1 authority integrity.

## 8. Explicit deferrals

| AcceptanceId | Status | Trigger |
|---|---|---|
| `S2-D01-GENERAL-NONPARTICIPANT-OBSERVATION` | DEFERRED | Re-open only when a concrete event-specific indirect-observation rule is required by accepted scope. |
| `S2-D02-GENERAL-KNOWNFACT-CONFLICT-ALGEBRA` | DEFERRED | Re-open when a future slice requires general incompatible factual-belief reconciliation beyond accepted Recognition rules. |
| `S2-D03-AUTONOMOUS-COMMUNICATION-MOTIVATION` | DEFERRED | Re-open with richer individual-agency work; Slice 2 may use pinned laboratory policy. |
| `S2-D04-TRUST-LYING-RUMOR-REPUTATION` | DEFERRED | Post-v0 / later Social Epistemic Dynamics research/design. |
| `S2-D05-HOUSEHOLD-RECOGNITION-ACTION-GATES` | DEFERRED | Slice 3/4 objective household/head substrate. |
| `S2-D06-ROLE-SUCCESSION-RECOGNITION` | DEFERRED | Slice 4. |
| `S2-D07-CHECKPOINT-SUBJECTIVE-STATE` | DEFERRED | Slice 5. |
| `S2-D08-RICH-MEMORY-DECAY` | DEFERRED | Future epistemic/agency research. |
| `S2-D09-ROLE-CONDITIONED-SALIENCE` | DEFERRED | Future richer agency/attention work. |

## 9. Fixture policy

### Allowed

- ordinary objective lower-level fixture state already permitted by SPEC §1.1;
- pinned laboratory policy/profile inputs;
- deterministic delivery schedule for communication tests;
- explicitly tagged epistemic starting state **only when the row does not claim to prove acquisition of that same state**;
- fixture provenance records used to isolate update/communication behavior.

### Forbidden

- fixture-writing the recipient postcondition that the row claims communication produced;
- fixture-writing the final Recognition state for a row claiming to prove conflict derivation;
- synthetic Household/head/office state merely to make a recognition card executable;
- direct mutation of production epistemic state after cycle start except through an accepted fixture/exogenous ingress explicitly declared by the scenario;
- hidden observer history reads by actor policy.

Every executable row must declare its fixture write-set.

## 10. Oracle independence

Independent checks may use:

- public/read-only objective and epistemic snapshots;
- semantic/decision history;
- stable IDs and accepted configuration constants;
- independent comparison of provenance/order metadata;
- frozen expected-case tables.

Independent checks must not call the production helper whose result they judge for:

- proposition availability;
- communication candidate generation;
- Recognition conflict resolution;
- evidence precedence;
- subjective candidate gating;
- epistemic cache classification.

Where full independent recomputation is disproportionate, use metamorphic, structural, or public-boundary counterexample evidence.

## 11. Review Gate RG-01 — Contested Recognition witness

Before this candidate can freeze, a fresh pre-code reviewer must independently re-derive and approve a Slice-2-valid executable witness for:

- persistent `Contested` Recognition;
- incomparable incompatible evidence;
- no arbitrary stable-ID/sender-ID/arrival-order winner.

The witness must **not** require:

- persistent Household identity;
- head/office occupancy;
- succession;
- mediated marriage;
- fake later-slice objective state;
- a new universal proposition ontology.

Preferred route, if semantically supportable without invention:

- a bounded accepted `CandidateRecognition(C)` fixture with provenance-bearing incompatible recognition evidence, without exercising candidate equivalence/formation.

If the reviewer concludes no such witness is semantically supportable from accepted authority, RG-01 becomes a **semantic escalation** rather than an implementation choice.

Owner of any such escalation: Master Architect → Project Director only if a consequential new semantic distinction is actually required.

## 12. Review Gate RG-02 — Event-specific observation

No general nonparticipant-observation system is required for Slice 2.

If any REQUIRED row cannot be evidenced using:

- automatic direct acquisition;
- direct participation;
- communication;
- declared epistemic starting state for non-acquisition-specific rows;

then the exact event-specific observation question must be surfaced before freeze.

Do not invent a generic perception rule in tests or production.

## 13. Review Gate RG-03 — Autonomous communication choice

Slice 2 acceptance does not require historically meaningful autonomous decisions about when/whom/what to tell.

Pinned laboratory policy may select a communication action/recipient/proposition.

If the project later decides that autonomous communication motivation is required **for Slice-2 completion**, that is a consequential agency decision and should be escalated rather than hidden in score coefficients.

Current candidate position: **do not require it.**

## 14. Completion evidence

A Slice-2 implementation candidate may claim completion only when:

1. every REQUIRED S2 row is present and substantively evidenced;
2. RG-01 and RG-02 are closed;
3. all DEFERRED rows remain visibly deferred with their triggers;
4. the frozen Slice-1 manifest remains byte-identical to its accepted baseline;
5. canonical root restore/format/build/test commands pass;
6. acceptance output exposes every S2 AcceptanceId with executed/pass/fail/skip status;
7. fixture write-set audit passes;
8. oracle-independence audit passes;
9. regression-protected Slice-1 contracts pass;
10. a fresh independent post-implementation conformance reviewer passes the exact frozen candidate.

## 15. Pre-code review requirements

This candidate must receive independent pre-code review before freeze.

The reviewer must re-derive from accepted sources and inspect at minimum:

- completeness of Slice-2 applicability;
- whether any row invents semantics;
- RG-01 witness validity;
- communication initiative/provenance coverage;
- stale/message-order coverage;
- anti-omniscience;
- fixture authority;
- no accidental Household/head/checkpoint pull-forward;
- representation neutrality;
- global/broad claims backed by structural or bounded-domain evidence.

Review result is PASS/BLOCK.

A BLOCK does not reopen accepted SFL semantics automatically.

## 16. Freeze mechanics

After independent PASS:

- promote a reviewed candidate version `SFL-V0-S2-ACCEPTANCE-v1`;
- record reviewed candidate SHA;
- create immutable freeze ref;
- write a separate freeze record with final frozen commit/content identity;
- semantic/applicability edits after freeze require a new version and review.

## 17. Director decision / escalation map

### No Director decision currently required

The following are already accepted or ordinary architecture/verification choices:

- objective vs subjective separation;
- KnownFact persistence/provenance;
- Recognition tri-state;
- communication truthfulness/provenance/initiative cost;
- stale state;
- message-order precedence;
- actor-specific candidate gating;
- trace/inspection requirements;
- bounded typed representation;
- storage/API/schema choices.

### Bring back to Director only if triggered

1. **Contested witness semantic gap:** accepted Recognition cannot be exercised in Slice 2 without inventing later-slice entities or new recognition meaning.
2. **Observation semantic gap:** a required current-slice behavior truly needs a nonparticipant observation rule not fixed by accepted authority.
3. **Agency-scope decision:** Slice 2 is required to have socially meaningful autonomous communication selection rather than laboratory-pinned exercise.
4. **Any implementation discovery that changes what a proposition means, who may know it, or which evidence outranks which beyond accepted cases.**

## 18. Current release judgment

**NO RELEASE TO IMPLEMENTATION YET.**

Reason:

- acceptance authority is still a candidate;
- RG-01 requires independent pre-code closure;
- independent pre-code acceptance review has not yet passed;
- no freeze exists.

If pre-code review passes without semantic escalation, the expected next state is:

**SLICE 2 ACCEPTANCE FROZEN / IMPLEMENTATION PACKET AUTHORIZED.**
