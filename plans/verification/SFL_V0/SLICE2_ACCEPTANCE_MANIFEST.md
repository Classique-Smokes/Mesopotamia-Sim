# SFL v0 Slice 2 — Acceptance Manifest

**Status:** FROZEN ACCEPTANCE AUTHORITY  
**Manifest version:** `SFL-V0-S2-ACCEPTANCE-v1`  
**Owner:** Master Architect  
**Scope:** Roadmap Stage 4 / Slice 2 — subjective recognition + minimal individual agency integration  
**Semantic authority:** `SPEC-SFL-0001` + accepted ADRs only  
**Completion authority:** this frozen manifest  
**Slice-1 authority:** `SFL-V0-S1-ACCEPTANCE-v1` remains immutable and is referenced, not edited  
**Previous candidates:** v1 blob `cc9ec48fc844645bcf8b7c44cc3660074b512245` — **BLOCK**; v2 blob `18c77a27903cb148e087437bb43fc27dc998af77` — **BLOCK**  
**Reviewed candidate commit:** `7068efc853ddc163311b603649ba845111a91765`  
**Reviewed candidate blob:** `d7963f6138daa3a0c311dfb11def843ef5ed760f`  
**Final pre-code review:** `research/technical/SFL_V0_SLICE2_ACCEPTANCE_PRECODE_REVIEW_FINAL.md` — **PASS — MAY FREEZE UNCHANGED**  
**Previous reviews:** `research/technical/SFL_V0_SLICE2_ACCEPTANCE_PRECODE_REVIEW_V1.md`; `research/technical/SFL_V0_SLICE2_ACCEPTANCE_PRECODE_REVIEW_V2.md`; `research/technical/SFL_V0_SLICE2_ACCEPTANCE_PRECODE_REVIEW_V3.md`

## 1. Purpose

Define omission-detectable completion authority for Slice 2 without inventing new social semantics or pulling later slices forward.

This frozen authority carries forward the reviewed v1/v2 repairs and the final authorized clerical correction. It may instantiate accepted semantics with bounded laboratory witnesses; it may not create new proposition meaning, perception rules, trust/rumor/reputation, household/head semantics, checkpoint semantics, or richer agency.

## 2. Controlling accepted contract

Slice 2 must make executable:

1. objective truth distinct from actor-specific subjective state;
2. actor-held provenance-bearing `KnownFact`;
3. `Recognition` distinct from KnownFact, objective truth, scalar confidence, attitude, approval, and obedience;
4. Recognition states `Unknown / Recognized / Contested`;
5. accepted automatic acquisition routes: own state, direct-party relations/claims, direct participation;
6. no passive synchronization or global knowledge broadcast;
7. `CommunicateClaim/Inform` for factual **and Recognition** propositions the sender currently holds;
8. sender plus underlying source/event provenance where available;
9. ordinary successful communication consumes one personal initiative;
10. stale subjective state persists until accepted evidence changes it;
11. underlying event/observation order outranks message arrival;
12. newer accepted direct evidence supersedes older incompatible information where SPEC says so;
13. newer event-backed communication may supersede older reports where SPEC says so;
14. unresolved incompatible Recognition evidence becomes `Contested`, never an arbitrary ID/arrival winner;
15. subjective state can causally affect candidate availability;
16. categorical gates precede scoring;
17. objective commit-time revalidation remains authoritative;
18. decision/history traces expose subjective inputs actually used;
19. observer/debug epistemic reads remain noninterfering;
20. Recognition does not decay merely because attitude is negative or an unrelated request is refused.

## 3. Exact Slice-2 boundary

### REQUIRED now

Only the epistemic substrate needed for the contract above:

- actor-specific factual knowledge;
- actor-specific Recognition with lifetime-scoped retention;
- provenance sufficient for accepted evidence ordering;
- direct acquisition routes already fixed by SPEC;
- voluntary communication;
- stale-state retention;
- accepted precedence relations;
- `Contested`;
- integration with personal candidate generation/gating and traces;
- read-only verification inspection.

### Explicitly outside this slice

Do not implement for Slice 2:

- persistent Household identity/lifecycle;
- HouseholdHeadRole, office occupancy, succession;
- mediated marriage through household authority;
- household provision or lineage;
- checkpoint/restore;
- generic nonparticipant perception/visibility;
- trust/reliability scoring;
- deliberate lying/invented claims;
- rumor mutation or reputation;
- brokerage power;
- rich memory decay;
- role-conditioned salience;
- strategic multi-step planning;
- stochastic behavior;
- universal proposition ontology;
- universal evidence-strength/conflict algebra.

## 4. Bounded completion proposition census

Completion evidence is limited to the following semantic categories. The implementation may choose representation.

### KnownFact categories

- **KF-OWN:** own objective-state fact, with at least one concrete own-state witness.
- **KF-DIRECT-CLAIM:** direct-party Debt or Favour fact, with at least one concrete claim witness.
- **KF-PARTICIPATION:** proposal/event participation or accepted direct-participant outcome fact.
- **KF-REPORT:** communicated report/copy of one of the above or of an accepted lower-level event-backed fact used only for communication/order tests.

`S2-003` must cover every category above. This is the bounded completion census; no universal arbitrary predicate language is required.

### Recognition category

For Slice-2-native completion evidence, use only:

- **RC-CANDIDATE:** accepted `CandidateRecognition(C)` for one pre-Household candidate referent C.

No Household/head Recognition proposition is REQUIRED in Slice 2.

`CandidateRecognition(C)` remains explicitly **ephemeral**. Recognition state is required to persist only while the accepted proposition/referent remains live and no accepted evidence displaces or contests it.

## 5. Acquisition and communication boundary

### Automatic direct acquisition

An actor must acquire/retain accepted knowledge of:

- own objective state;
- direct-party relations/claims;
- proposals/events in which the actor directly participates;
- direct-participant failed-attempt outcomes/reasons already accepted in Slice 1.

### No passive synchronization

A nonparticipant does not learn a changed fact merely because:

- it exists in objective state;
- the actor shares a dwelling;
- observer History contains it;
- another actor knows it;
- a cycle closes.

No REQUIRED witness may use unspecified nonparticipant observation.

### Communication

For ordinary Slice-2 `CommunicateClaim/Inform`:

- sender must currently hold the transmitted factual or Recognition proposition;
- successful ordinary initiation consumes the sender's one personal initiative;
- sender provenance is retained;
- underlying source/event provenance is retained where available;
- recipient acquisition is limited to intended recipient(s);
- the engine does not invent the claim;
- receipt alone creates neither a fresh same-cycle personal activation nor a response decision context;
- communication does not create a free broadcast or same-cycle voluntary reactivation.

## 6. Accepted evidence ordering — exact required subcases

No universal evidence algebra is required.

The acceptance suite must exercise these separately:

1. **Direct evidence precedence:** newer direct-participation evidence is not overwritten by a later-delivered older incompatible report.
2. **Event-backed report precedence:** a report grounded in newer underlying event evidence supersedes an older event-backed report independently of delivery order, where SPEC §6.5 applies.
3. **Arrival permutation:** permuting delivery order while holding underlying semantic event order fixed yields the same accepted final result.
4. **Unresolved Recognition conflict:** incompatible evidence with no accepted provenance/order dominance yields `Contested`.
5. Stable IDs, actor IDs, sender IDs, container order, and arrival order never become Recognition winner rules.

## 7. RG-01 frozen witness contract — Contested CandidateRecognition

This candidate pins the Slice-2 witness rather than leaving it to implementer choice.

### Referent

- Use exactly one inert pre-Household candidate referent `C`.
- `C` is only the referent of accepted `CandidateRecognition(C)`.
- No Household, HouseholdHeadRole, FormationWarrant, succession, mediated marriage, household action, or persistent collective identity is created.
- No second candidate label exists; candidate equivalence/convergence is not exercised.
- The label/ID of C is not evidence for recognition.

### Controlled starting epistemic evidence

This row does **not** claim to prove the senders' acquisition, so bounded starting epistemic state is allowed.

Use:

- sender `S+`: a fixture-originated, provenance-bearing Recognition/evidence bundle sufficient for `CandidateRecognition(C)=Recognized`;
- sender `S-`: a fixture-originated, provenance-bearing lower-level factual report incompatible with one required formation-predicate fact for C, using the already-accepted single-valued Residence domain;
- all other formation-predicate evidence is held fixed/uncontested;
- neither fixture provenance dominates the other under any precedence relation accepted by SPEC;
- no new evidence-strength rule is invented.

Concrete contradiction boundary:

- the fixed founding core for C includes person P;
- S+'s supporting bundle includes `Residence(P,D1)` as part of shared-residence evidence;
- S-'s factual report is `Residence(P,D2)`, D2 != D1;
- because Residence is single-valued, these reports are incompatible;
- fixture provenance is explicitly tagged as inherited/controlled epistemic pre-state with no underlying semantic-order dominance. This fixture establishes the conflict input only; it does not write the recipient's final Recognition state.

### Execution

1. Recipient R begins without accepted Recognition of C.
2. S+ communicates the held Recognition/evidence bundle through ordinary `CommunicateClaim/Inform`.
3. S- communicates the incompatible Residence report through ordinary `CommunicateClaim/Inform`.
4. Production epistemic update derives R's `Recognition(C)=Contested`.
5. Advance at least one stable cycle with no accepted displacing evidence while C remains live; `Contested` remains retained.
6. Repeat paired runs with sender order, delivery order, and consistent nonsemantic ID renaming permuted. Final Recognition remains `Contested`.

### What this witness does not prove

It does not prove:

- CandidateOrganization equivalence;
- formation;
- household identity;
- authority;
- a universal KnownFact conflict state machine;
- a universal contradiction/evidence-strength algebra.

### RG-01 oracle

Independent oracle may inspect:

- public/read-only Recognition state;
- preserved provenance;
- paired-run equality/metamorphic relations.

It may not call production:

- Recognition conflict resolver;
- evidence-precedence helper;
- CandidateRecognition derivation helper whose output is under judgment.

If fresh review finds this concrete witness still requires an unaccepted semantic distinction, this candidate BLOCKS and that exact distinction is escalated.

## 8. Applicability table

### A. Core epistemic state

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION` | REQUIRED | Same objective world may coexist with different actor subjective states; objective existence alone does not synchronize them. |
| `S2-002-KNOWNFACT-RETENTION` | REQUIRED | Actor-held factual knowledge remains across stable cycles until an accepted update/displacement rule applies. |
| `S2-003-KNOWNFACT-PROVENANCE-CENSUS` | REQUIRED | Each bounded completion KnownFact category KF-OWN / KF-DIRECT-CLAIM / KF-PARTICIPATION / KF-REPORT exposes provenance sufficient to distinguish route/source and underlying event where available. |
| `S2-004-RECOGNITION-DISTINCT` | REQUIRED | Recognition remains distinct from KnownFact, objective truth, scalar confidence, Attitude, approval, and obedience. |
| `S2-005-RECOGNITION-TRISTATE-LIFETIME` | REQUIRED | Unknown / Recognized / Contested are representable for RC-CANDIDATE; Recognized/Contested retain across stable cycles only while C remains live and accepted evidence does not change them. |
| `S2-006-NO-PASSIVE-SYNC` | REQUIRED | Objective change without an accepted acquisition route leaves an uninformed actor stale/unchanged. |
| `S2-007-NO-HISTORY-OMNISCIENCE` | REQUIRED | Observer semantic history is not actor policy knowledge. |
| `S2-008-LOCALITY` | REQUIRED | Epistemically disconnected actors remain unchanged by unrelated events/communications. |
| `S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE` | REQUIRED | With C/evidence held fixed, changing unrelated attitude and/or an independent voluntary refusal does not by itself change Recognition(C). |

### B. Automatic acquisition

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-010-OWN-STATE-KNOWLEDGE` | REQUIRED | Accepted own-state fact is acquired/available without communication. |
| `S2-011-DIRECT-CLAIM-KNOWLEDGE` | REQUIRED | Direct-party Debt/Favour claim fact is acquired/available to the direct party. |
| `S2-012-DIRECT-PARTICIPATION-KNOWLEDGE` | REQUIRED | Direct participants learn accepted proposal/event facts and valid failed-attempt outcomes. |
| `S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION` | REQUIRED | Expanded epistemic machinery does not leak unrelated resolver-private state in failure reasons. |

### C. Communication — factual and Recognition subcases are independently mandatory

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-020F-FACT-COMMUNICATION-ACTION` | REQUIRED | Factual CommunicateClaim/Inform executes through the ordinary personal-action pipeline. |
| `S2-020R-RECOGNITION-COMMUNICATION-ACTION` | REQUIRED | Recognition CommunicateClaim/Inform executes through the same ordinary personal-action pipeline. |
| `S2-021F-COMMUNICATE-HELD-FACT` | REQUIRED | Sender can communicate a factual proposition currently held. |
| `S2-021R-COMMUNICATE-HELD-RECOGNITION` | REQUIRED | Sender can communicate held CandidateRecognition(C) with its supporting provenance. |
| `S2-022F-NO-INVENTED-FACT` | REQUIRED | Factual communication candidate/commit is unavailable or invalid when sender lacks the fact. |
| `S2-022R-NO-INVENTED-RECOGNITION` | REQUIRED | Recognition communication candidate/commit is unavailable or invalid when sender does not hold that Recognition proposition. |
| `S2-023F-FACT-COMMUNICATION-PROVENANCE` | REQUIRED | Recipient-visible communicated fact retains sender and underlying source/event provenance where available. |
| `S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE` | REQUIRED | Recipient-visible communicated Recognition/evidence retains sender and underlying supporting provenance. |
| `S2-024F-FACT-COMMUNICATION-INITIATIVE-COST` | REQUIRED | A successful ordinary pinned-policy factual communication consumes the sender's personal initiative and prevents a second ordinary voluntary personal initiation that cycle. |
| `S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST` | REQUIRED | A successful ordinary pinned-policy Recognition communication consumes the sender's personal initiative and prevents a second ordinary voluntary personal initiation that cycle. |
| `S2-025F-FACT-NO-FREE-BROADCAST` | REQUIRED | For factual communication, only declared intended recipient(s) acquire the communication; no global propagation occurs. |
| `S2-025R-RECOGNITION-NO-FREE-BROADCAST` | REQUIRED | For Recognition communication, only declared intended recipient(s) acquire the communication; no global propagation occurs. |
| `S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE` | REQUIRED | Factual receipt alone creates neither fresh same-cycle personal activation nor a ResponseDecisionContext. |
| `S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE` | REQUIRED | Recognition receipt alone creates neither fresh same-cycle personal activation nor a ResponseDecisionContext. |
| `S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE` | REQUIRED | Directly acquired and communicated versions of the same semantic fact remain provenance-distinguishable. |

### D. Staleness / precedence / contest

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-030-STALE-FACT-PERSISTS` | REQUIRED | Previously acquired fact remains stale after objective change when no accepted update reaches the actor. |
| `S2-031A-DIRECT-EVIDENCE-PRECEDENCE` | REQUIRED | Newer direct-participation evidence is not overwritten by a later-delivered older incompatible report. |
| `S2-031B-REPORT-EVENT-PRECEDENCE` | REQUIRED | Newer event-backed communication supersedes an older report where SPEC §6.5 applies, independent of delivery order. |
| `S2-032-MESSAGE-ARRIVAL-PERMUTATION` | REQUIRED | Permuting delivery order while preserving underlying evidence order does not change final accepted result for the bounded precedence cases. |
| `S2-033-CANDIDATE-RECOGNITION-CONTESTED` | REQUIRED | Exact RG-01 witness derives Contested and no actor/sender/stable-ID/arrival-order winner. |

### E. Agency and trace

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-040F-KNOWNFACT-CANDIDATE-GATE` | REQUIRED | Holding the relevant fact makes its corresponding communication candidate available; absence suppresses it with objective world held equal. |
| `S2-040R-RECOGNITION-CANDIDATE-GATE` | REQUIRED | Holding Recognized CandidateRecognition(C) makes communication of that Recognition proposition available; Unknown suppresses it with objective world held equal. |
| `S2-041-GATES-BEFORE-SCORING` | REQUIRED | Subjectively inaccessible communication candidate is excluded before scoring and cannot win through numeric coefficients. |
| `S2-042-SUBJECTIVE-TRACE` | REQUIRED | DecisionTrace records actual KnownFact and, in a separate mandatory subcase, Recognition/provenance basis used for candidate generation/gating/scoring. |
| `S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION` | REQUIRED | Changing unrelated subjective facts does not alter the bounded candidate outcome. |
| `S2-044-OBJECTIVE-REVALIDATION-PRESERVED` | REQUIRED | Subjective candidate availability does not bypass ordinary objective validity/feasibility/precommit checks. |
| `S2-045-PINNED-POLICY-NONCLAIM` | REQUIRED structural/report | Completion labels communication-selection coefficients as laboratory policy, not accepted autonomous social motivation. |

### F. Inspection / determinism / technical quarantine

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S2-050-EPISTEMIC-READ-NONINTERFERENCE` | REQUIRED | Epistemic/provenance reads do not change later behavior, IDs, ordering, or history. |
| `S2-051-DETERMINISTIC-REPLAY` | REQUIRED | With identical declared objective+epistemic initial state, config, exogenous inputs, communication schedule and deterministic seed/boundary, bounded authoritative objective state, subjective state and semantic history are identical. |
| `S2-052-NONSEMANTIC-ITERATION-METAMORPHIC` | REQUIRED | Explicit permutations of nonsemantic container/input enumeration yield the same bounded semantic result. |
| `S2-053-ISOMORPHIC-ID-RENAMING` | REQUIRED | Consistent isomorphic renaming of nonsemantic IDs preserves semantic result; inconsistent substitutions are not claimed invariant. |
| `S2-054-CACHE-NONAUTHORITY` | REQUIRED | If no behavior-affecting epistemic cache exists, structural absence suffices; if one exists, stale/rebuild metamorphic evidence proves it cannot alter behavior. |
| `S2-055-CONFIGURATION-PROVENANCE` | REQUIRED | Semantic and decision history truthfully identify active Slice-2 rule/configuration version. |

## 9. Imported prior obligations

Frozen Slice-1 statuses never change. Slice 2 provides new evidence for the accepted properties.

| Prior AcceptanceId | Required Slice-2 evidence |
|---|---|
| `S1-098-COMMUNICATION` | S2-020F/R, S2-021F/R, S2-022F/R, S2-023F/R, S2-024F/R, S2-025F/R, S2-026F/R, and S2-027 |
| `S1-META-08` | S2-032 |
| `S1-MUT-27` | S2-031A / S2-031B / S2-032 |
| `S1-MUT-28` | S2-033 |
| `S1-076` | communication truthfulness/provenance + bounded precedence + Contested + initiative cost; later-slice fixture shapes are not imported |

## 10. Exact Slice-1 regression bindings

All listed frozen rows remain historically REQUIRED/PASS under Slice 1 and must be regression-protected during Slice-2 completion:

- `S1-070`, `S1-GLOBAL-KNOWLEDGE`;
- `S1-073`;
- `S1-098-CORE`, `S1-105`;
- `S1-085`, `S1-META-04`, `S1-MUT-26`;
- `S1-086`, `S1-MUT-29`;
- `S1-META-07`;
- `S1-084`, `S1-META-05`, `S1-MUT-24`;
- `S1-META-03`;
- `S1-META-02`, `S1-GLOBAL-FALLBACK`;
- `S1-GLOBAL-MANIFEST-INTEGRITY`.

Slice-2 completion must report each exact regression ID/bundle rather than a prose subset.

## 11. Explicit deferrals

| AcceptanceId | Status | Trigger |
|---|---|---|
| `S2-D01-GENERAL-NONPARTICIPANT-OBSERVATION` | DEFERRED | Re-open only for a concrete accepted event-specific indirect-observation need. No REQUIRED witness may use unspecified nonparticipant observation. |
| `S2-D02-GENERAL-KNOWNFACT-CONFLICT-ALGEBRA` | DEFERRED | Future need for general incompatible factual-belief reconciliation. |
| `S2-D03-AUTONOMOUS-COMMUNICATION-MOTIVATION` | DEFERRED | Richer agency work; pinned policy is sufficient here. |
| `S2-D04-TRUST-LYING-RUMOR-REPUTATION` | DEFERRED | Later Social Epistemic Dynamics / post-v0. |
| `S2-D05-HOUSEHOLD-RECOGNITION-ACTION-GATES` | DEFERRED | Slice 3/4 objective household/head substrate. |
| `S2-D06-ROLE-SUCCESSION-RECOGNITION` | DEFERRED | Slice 4. |
| `S2-D07-CHECKPOINT-SUBJECTIVE-STATE` | DEFERRED | Slice 5. |
| `S2-D08-RICH-MEMORY-DECAY` | DEFERRED | Future epistemic/agency research. |
| `S2-D09-ROLE-CONDITIONED-SALIENCE` | DEFERRED | Future richer agency/attention work. |

## 12. Fixture classes

Every REQUIRED row maps to one class in §14. Fixture-originated epistemic state must be visible as fixture provenance.

| FixtureClass | Allowed pre-state | Forbidden result write |
|---|---|---|
| `F-STRUCT` | ordinary objective setup only | any epistemic postcondition under judgment |
| `F-ACQUIRE` | ordinary objective setup; unrelated epistemic state | the specific KnownFact/Recognition acquisition being claimed |
| `F-COMM-FACT` | sender-held fact/provenance; recipient lacks it | recipient communicated fact/postcondition |
| `F-COMM-REC` | sender-held CandidateRecognition(C)/supporting provenance; recipient lacks it | recipient Recognition result/communication postcondition |
| `F-STALE` | starting actor-held fact allowed when acquisition is not under test | retained stale postcondition or later correction |
| `F-RG01` | exact single-C sender/evidence starting state from §7 | recipient final Contested; Household/head/formation result |
| `F-GATE` | declared held/absent subjective inputs; objective world paired equal | production candidate set, chosen action, score/gate output, trace |
| `F-META` | baseline plus exactly declared permutation/renaming/read perturbation | hidden semantic state changes between paired runs |

Every executable acceptance report must expose the resolved write set, not merely the class name.

## 13. Oracle classes

| OracleClass | Independent basis | Forbidden production dependency |
|---|---|---|
| `O-PUBLIC` | public/read-only objective+epistemic state, semantic/decision history, frozen expected-case assertions | production helper/classifier whose output is asserted |
| `O-PROV` | independently compare source/sender/event IDs/order metadata in public evidence | production provenance classifier/precedence helper |
| `O-META` | paired-run equality under one declared metamorphic perturbation | production semantic normalizer used as expected oracle |
| `O-STRUCT` | structural/source audit of absence/presence of behavior-affecting cache/API path | production runtime classifier as sole evidence |
| `O-RG01` | public Recognition/provenance + paired sender/order/ID permutations | production Recognition conflict resolver, evidence-precedence or CandidateRecognition derivation helper under judgment |

## 14. Per-row fixture/oracle binding

This table is normative. A row may use stronger independent evidence, but may not weaken these boundaries.

| AcceptanceId | Fixture | Oracle | Forbidden helper/output shortcut |
|---|---|---|---|
| S2-001 | F-GATE | O-PUBLIC | objective snapshot as actor-knowledge oracle |
| S2-002 | F-STALE | O-PUBLIC | production retention classifier |
| S2-003 | F-ACQUIRE/F-COMM-FACT | O-PROV | production provenance summarizer as expected answer |
| S2-004 | F-STRUCT | O-PUBLIC | production Recognition classifier as sole distinction proof |
| S2-005 | F-RG01 | O-RG01 | conflict resolver / CandidateRecognition derivation helper |
| S2-006 | F-STALE | O-PUBLIC | hidden objective-world read by checker/policy |
| S2-007 | F-STRUCT | O-STRUCT/O-PUBLIC | History-fed production policy path |
| S2-008 | F-META | O-META | production locality classifier |
| S2-009 | F-META | O-META/O-PUBLIC | production Recognition updater as oracle |
| S2-010 | F-ACQUIRE | O-PUBLIC | fixture writing own KnownFact result |
| S2-011 | F-ACQUIRE | O-PUBLIC | fixture writing direct-claim KnownFact result |
| S2-012 | F-ACQUIRE | O-PUBLIC | fixture writing participation outcome result |
| S2-013 | F-ACQUIRE | O-PUBLIC | resolver-private state used as expected participant reason |
| S2-020F | F-COMM-FACT | O-PUBLIC | direct epistemic mutation instead of action pipeline |
| S2-020R | F-COMM-REC | O-PUBLIC | separate Recognition-only bypass instead of ordinary action pipeline |
| S2-021F | F-COMM-FACT | O-PUBLIC | fixture writing recipient fact |
| S2-021R | F-COMM-REC | O-PUBLIC/O-PROV | fixture writing recipient Recognition |
| S2-022F | F-GATE | O-PUBLIC | production candidate generator as oracle |
| S2-022R | F-GATE | O-PUBLIC | production candidate generator as oracle |
| S2-023F | F-COMM-FACT | O-PROV | production provenance helper as expected result |
| S2-023R | F-COMM-REC | O-PROV | production provenance helper as expected result |
| S2-024F | F-GATE/F-COMM-FACT | O-PUBLIC | production initiative counter helper as sole oracle |
| S2-024R | F-GATE/F-COMM-REC | O-PUBLIC | production initiative counter helper as sole oracle |
| S2-025F | F-COMM-FACT | O-META/O-PUBLIC | population-wide factual delivery inferred from one sampled nonrecipient |
| S2-025R | F-COMM-REC | O-META/O-PUBLIC | population-wide Recognition delivery inferred from one sampled nonrecipient |
| S2-026F | F-COMM-FACT | O-PUBLIC | response/personal scheduler helper as expected answer |
| S2-026R | F-COMM-REC | O-PUBLIC | response/personal scheduler helper as expected answer |
| S2-027 | F-COMM-FACT | O-PROV | provenance collapsing helper |
| S2-030 | F-STALE | O-PUBLIC | fixture writing retained stale result |
| S2-031A | F-STALE | O-PROV/O-PUBLIC | production evidence-precedence helper |
| S2-031B | F-STALE | O-PROV/O-PUBLIC | production evidence-precedence helper |
| S2-032 | F-META | O-META/O-PROV | production sorting/precedence helper |
| S2-033 | F-RG01 | O-RG01 | conflict resolver / precedence helper |
| S2-040F | F-GATE | O-PUBLIC | production candidate generator as oracle |
| S2-040R | F-GATE | O-PUBLIC/O-PROV | production candidate generator as oracle |
| S2-041 | F-GATE | O-PUBLIC | scorer selecting an inaccessible injected candidate |
| S2-042 | F-GATE | O-PUBLIC/O-PROV | production trace builder grading itself |
| S2-043 | F-META | O-META | production dependency classifier |
| S2-044 | F-GATE | O-PUBLIC | production revalidation helper as sole oracle |
| S2-045 | F-STRUCT | O-STRUCT | policy coefficient treated as semantic evidence |
| S2-050 | F-META | O-META | observer read with hidden writes |
| S2-051 | F-META | O-META | partial equality that omits subjective/history state |
| S2-052 | F-META | O-META | arbitrary global permutation claim beyond declared permutations |
| S2-053 | F-META | O-META | inconsistent/non-isomorphic rename |
| S2-054 | F-STRUCT/F-META | O-STRUCT/O-META | production cache classifier as sole evidence |
| S2-055 | F-STRUCT | O-PUBLIC | hard-coded expected config detached from emitted history |

## 15. Evidence-shape notes

### S2-025F / S2-025R population scope

For both factual and Recognition communication, the scenario's entire declared population is the bounded domain. Assert intended recipient(s) acquire and every other fixture actor does not. Do not infer a no-broadcast claim from sampling one nonrecipient.

### S2-031A direct precedence witness

Use a lower-level claim with accepted direct participation, e.g. a Debt state transition. Actor X directly participates in newer event E2 and learns the newer claim state. A delayed communication grounded in older E1 arrives later. X must retain the accepted newer state.

### S2-031B / S2-032 report precedence witness

Use two event-backed reports E1<E2 about the same bounded lower-level fact. Recipient is seeded only with sender-held report provenance as needed; acquisition of sender knowledge is not under test. Run both delivery orders. Final accepted state follows E2, not arrival order.

### S2-009 attitude/compliance witness

Start with live Recognized CandidateRecognition(C). Run **both mandatory paired perturbations** independently:

1. move an unrelated directed Attitude into a negative band;
2. execute an otherwise independent ordinary voluntary Decline/refusal through an accepted lower-level request path.

In each paired comparison, hold C and its supporting evidence fixed. Recognition(C) must remain unchanged solely because of the attitude perturbation or the refusal/compliance outcome. The refusal witness must not introduce Household/head authority or any new obedience/compliance state.

## 16. Completion evidence

A candidate implementation may claim Slice-2 completion only when:

1. every REQUIRED S2 row in §8 executes and passes;
2. all exact Slice-1 regression bindings in §10 pass;
3. all DEFERRED rows remain visible with triggers;
4. frozen Slice-1 manifest integrity passes;
5. root restore/format/build/test commands pass;
6. acceptance output lists every S2 AcceptanceId and executed/pass/fail/skip state;
7. per-row fixture write-set audit passes using §§12/14;
8. per-row oracle-independence audit passes using §§13/14;
9. no REQUIRED witness uses unspecified nonparticipant observation;
10. exact RG-01 witness passes and remains within one-C lifetime boundary;
11. fresh independent post-implementation conformance review passes the exact frozen candidate.

## 17. Pre-code review provenance

The pre-code review sequence is complete. Candidate v1 and v2 were BLOCKED for verification-authority defects; candidate v3 was BLOCKED only for a stale candidate-version sentence; the one-line version-neutral repair at reviewed commit `7068efc853ddc163311b603649ba845111a91765` received final **PASS — MAY FREEZE UNCHANGED**. No Director-level semantic decision was required.

## 18. Freeze mechanics

This manifest is frozen as `SFL-V0-S2-ACCEPTANCE-v1`. The reviewed candidate commit/blob is recorded above. The final frozen commit/content identity and frozen ref are recorded externally in `SLICE2_ACCEPTANCE_FREEZE_RECORD.md`. Any semantic/applicability edit after freeze requires a new version and review.

## 19. Director escalation map

### No Director decision currently required

Already accepted or ordinary engineering/verification:

- objective vs subjective separation;
- KnownFact/provenance;
- Recognition tri-state/lifetime-scoped retention;
- factual and Recognition communication;
- ordinary initiative cost;
- bounded precedence relations;
- actor-specific gating/traces;
- schema/API/storage choices.

### Escalate only if triggered

1. RG-01 cannot be instantiated without a new negative/opposite Recognition meaning, candidate-equivalence rule, universal contradiction algebra, new evidence-strength rule, or nonparticipant observation rule.
2. A REQUIRED witness truly requires event-specific nonparticipant observation not already accepted.
3. Project scope changes to require socially meaningful autonomous communication selection.
4. Implementation discovery changes proposition meaning, knowledge entitlement, or precedence beyond accepted cases.

## 20. Release judgment

**SLICE 2 ACCEPTANCE FROZEN / IMPLEMENTATION PACKET AUTHORIZED.**

Implementation remains subordinate to this manifest, accepted SPEC/ADRs, and the eventual implementation packet. The implementation agent may not weaken, delete, reclassify, or bypass REQUIRED rows or deliberate deferrals.
