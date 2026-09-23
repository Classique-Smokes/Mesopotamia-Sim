# SFL v0 Slice 3 — Acceptance / Applicability Authority Candidate v1

**Status:** CANDIDATE / PRE-CODE REVIEW REQUIRED / NOT FROZEN  
**Candidate version:** `SFL-V0-S3-ACCEPTANCE-CANDIDATE-v1`  
**Owner:** Master Architect  
**Scope:** Roadmap Stage 4 / Slice 3 — persistent household identity + grounded collective capability substrate  
**Semantic authority:** accepted `SPEC-SFL-0001` + accepted ADRs only  
**Completion authority:** this file only after independent pre-code PASS and freeze  
**Slice-1 / Slice-2 authority:** frozen manifests remain immutable and are referenced, not edited  
**Discovery reconciliation:** `research/technical/SFL_V0_SLICE3_PREIMPLEMENTATION_RECONCILIATION.md`

## 1. Purpose

Define omission-detectable completion authority for Slice 3 without inventing new household semantics, weakening prior slices, or pulling the Slice-4 representative/head system forward.

This candidate is subordinate to accepted semantics and architecture.

It may:

- select Slice-3 applicability from already accepted SFL v0 semantics;
- define independently observable completion witnesses;
- bind fixture and oracle discipline;
- exercise controlled v0 lineage;
- exercise provision-backing/capacity state without spending authority;
- preserve explicit later-slice deferrals.

It may not:

- define a general organization-equivalence/convergence theory;
- create Household by command/fixture;
- treat residence/kinship/marriage/graph clusters as Household identity;
- create a hidden universal Members set;
- introduce HouseholdHeadRole / HouseholdDecisionContext;
- create headless provision solicitation or household spending;
- invent generic nonparticipant observation;
- redesign personal agency because the reference policy is behaviorally rustic.

## 2. Controlling Slice-3 contract

Slice 3 must make executable, at minimum:

1. CandidateOrganization is inert and non-authoritative;
2. CandidateRecognition remains actor-relative and evidence-backed;
3. formation requires a founding core of at least two distinct people;
4. the founding core satisfies shared residence;
5. the core has a connected durable tie structure;
6. at least two qualifying committed person-person support events occur on distinct cycles;
7. every required founder recognizes the same bounded candidate referent from their own uncontested evidence;
8. formation is an automatic semantic reaction, never a privileged personal action or fixture write;
9. formation creates one persistent Household identity plus FormationWarrant;
10. FormationWarrant records accepted causal/provenance fields, including earliest sustaining evidence and formation/reification time;
11. founders receive provenance-bearing SustainingParticipant associations;
12. founders directly recognize the produced Household;
13. newly formed Household is headless;
14. Household identity is distinct from residence, participants, lifecycle, resources, graph shape, labels and future office occupancy;
15. participation entry is bilateral and warrant-backed;
16. participation exit is explicit and warrant-backed;
17. residence change alone never adds or ends household participation;
18. continuity requires explicit historical transmission through a current sustaining-participant bridge plus ContinuationWarrant;
19. complete founder turnover can preserve the same numerical H through the warrant chain;
20. endpoint similarity cannot substitute for continuity;
21. Active / Inactive / Dissolved is operational lifecycle only and is published at stable closure;
22. Inactive H can reactivate through its sole live bearer under accepted participation rules;
23. Dissolved H cannot reactivate as the same numerical identity;
24. valid same-cycle bridge handoff resolves entry/continuity before the bridge exits;
25. one causal evidence bundle cannot both continue non-Dissolved H and found duplicate H2;
26. Household existence/continuity Recognition remains actor-specific and sparse;
27. objective Household/lifecycle state does not passively synchronize outsiders;
28. controlled lineage is downstream historical classification, not identity;
29. ambiguous controlled-lineage interpretation yields no LineageWarrant rather than arbitrary ID choice;
30. lineage transfers no material/social/authority/recognition state;
31. HouseholdProvisionCommitment is explicit backing state, not pooled ownership;
32. personal grain remains personal while commitment exists;
33. exposed capacity is `max(0, grain - 2)`, except NeedsGrain exposes zero;
34. Household mobilizable capacity is derived from current valid commitments;
35. Slice 3 exposes backing/capacity but has no Household spending authority;
36. reaction closure is idempotent, causally ordered and stable-cycle bounded;
37. prior objective/subjective, communication, initiative, locality, cache, fallback and lower-level relation semantics remain intact.

## 3. Exact Slice-3 implementation boundary

### REQUIRED now

- inert bounded CandidateOrganization referents;
- CandidateRecognition integration into actual formation;
- FormationWarrant and Household identity;
- SustainingParticipant;
- ParticipationWarrant;
- ParticipationEndWarrant;
- ContinuationWarrant;
- Active / Inactive / Dissolved lifecycle;
- Household existence/continuity Recognition;
- controlled v0 LineageWarrant + rebuildable DerivedFrom / transitive ancestry query;
- HouseholdProvisionCommitment state;
- derived provision capacity;
- automatic household reaction closure;
- read-only inspection sufficient for independent conformance.

### Explicitly outside Slice 3

- general multi-label CandidateOrganization convergence/equivalence;
- actor departure from the simulated world;
- repeated predecessor rejoin/re-exit lineage-source resolution;
- HouseholdHeadRole;
- head appointment/succession/vacancy mechanics;
- head/scope Recognition;
- HouseholdDecisionContext;
- separate household initiative;
- endogenous provision solicitation/reconsideration;
- household-originated support spending;
- mediated-marriage dowry spending;
- expenditure contributor debit ordering;
- authority-destroying transition races;
- generic nonparticipant observation;
- trust / lying / rumor / reputation / brokerage;
- strategic planning / richer autonomous communication motivation;
- checkpoint/restore;
- universal lineage/genealogy engine.

## 4. CandidateOrganization / LATER-01 boundary

General candidate convergence is deliberately **not** solved in Slice 3.

Completion evidence may use:

- one stable inert CandidateOrganization referent per prospective formation episode;
- multiple separate formation episodes only when no semantic decision requires interpreting two candidate referents as the same prospective organization.

The candidate referent:

- has no authority;
- owns no resources;
- creates no action;
- cannot support its own evidence;
- is not Household identity;
- is not evidence merely because its ID/label exists.

No REQUIRED row may need:

- merging two candidate IDs;
- selecting one candidate label as winner;
- treating founder overlap/residence similarity as candidate identity;
- stable-ID resolution of candidate equivalence.

If implementation requires those, Slice 3 blocks and LATER-01 returns for semantic authority.

## 5. Formation evidence boundary

Qualifying formation support remains accepted ordinary person-person support:

- accepted gift/help;
- loan provision;
- favour fulfilment.

Requirements:

- at least two qualifying committed support events;
- on distinct cycles;
- actual lower-level events with causal identity;
- actor-held evidence for required founders;
- Household-originated support is not available in Slice 3 and can never serve as self-supporting formation evidence.

Debt/favour existence alone is insufficient.

## 6. Grounded capability boundary

### Required state semantics

Slice 3 implements:

- `HouseholdProvisionCommitment(Person -> H)`;
- personal ownership retained until a later permitted collective spend;
- exposed capacity `max(0, grain - 2)`;
- NeedsGrain exposes zero;
- total mobilizable capacity derived from currently valid commitments;
- termination of the departing participant's commitment when participation ends;
- termination of all commitments on H dissolution;
- no treasury balance.

### Acquisition / action boundary

The accepted endogenous solicitation/reconsideration route is head-scoped and belongs to Slice 4.

Slice 3 acceptance therefore does **not** claim that a headless H can solicit/accept new backing through a new action meaning.

For capacity-state witnesses only, a declared pre-existing valid provision commitment may be supplied as controlled prerequisite state if and only if Review Gate RG-01 approves that fixture interpretation.

The fixture may not:

- write derived capacity;
- move personal grain;
- create Household;
- create head/role state;
- prove commitment acquisition;
- serve as formation/continuity evidence.

### No spending

No REQUIRED Slice-3 row executes household support or dowry spending.

## 7. Household Recognition boundary

Slice 3 adds only Household existence/continuity Recognition.

Required properties:

- founders directly recognize produced H;
- outsiders remain Unknown absent accepted route;
- newcomer participation can require recognition of H;
- turnover/lifecycle does not globally synchronize outsiders;
- stale recognition may persist absent new evidence;
- accepted direct-participation/communication evidence can update the actor's relevant Household/lifecycle understanding;
- Household Recognition remains distinct from attitude, approval, compliance and future head Recognition.

No REQUIRED row uses a new generic observer entitlement.

Review Gate RG-02 must confirm the exact lifecycle-recognition witness wording does not invent an unsupported negative-recognition transition.

## 8. Controlled lineage boundary

Controlled lineage is REQUIRED in Slice 3.

### Division descendant

- predecessor H remains non-Dissolved/continuing through ordinary continuity;
- successor H2 forms independently;
- every H2 founder maps unambiguously to ended participation in H;
- fresh qualifying person-person support occurs after all cited predecessor exits;
- exactly one DivisionDescendant LineageWarrant may issue.

### Consolidation descendant

- both H1 and H2 are Dissolved before H3 forms;
- H3 forms independently;
- every H3 founder maps unambiguously to ended participation in H1 or H2;
- at least one founder maps to each predecessor;
- fresh post-dissolution cross-predecessor person-person support exists;
- predecessor set is unordered.

### Ambiguity

If the bounded classifier has more than one equally valid predecessor-set/kind interpretation:

- no LineageWarrant is issued;
- ordinary Household formation remains valid.

### Nonauthority

Lineage:

- does not create the successor;
- does not preserve predecessor numerical identity;
- transfers no resource, claim, obligation, role, authority, recognition, residence, attitude, lifecycle or pending process;
- remains historical/queryable;
- has no independent behavioral power in v0.

## 9. Applicability table

### A. Formation / identity

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-001-CANDIDATE-INERT` | REQUIRED | CandidateOrganization referent has no authority/resources/actions and cannot be Household identity. |
| `S3-002-FORMATION-LOWER-LEVEL` | REQUIRED | Formation is grounded in accepted shared residence + durable connectivity + two distinct-cycle qualifying support events. |
| `S3-003-FORMATION-RECOGNITION-GATE` | REQUIRED | Every required founder must independently hold Recognized CandidateRecognition for the same bounded candidate referent. |
| `S3-004-FORMATION-AUTOMATIC-REACTION` | REQUIRED | Formation occurs as automatic causal reaction after prerequisites/recognition; no FormHousehold action or fixture write exists. |
| `S3-005-FORMATION-WARRANT` | REQUIRED | FormationWarrant is produced and is authoritative provenance for the new H. |
| `S3-006-FORMATION-WARRANT-PROVENANCE` | REQUIRED | Warrant references founders, dwelling, durable ties, qualifying events, recognition evidence, earliest sustaining evidence, formation time and rules/config version. |
| `S3-007-HOUSEHOLD-STABLE-IDENTITY` | REQUIRED | Produced H has stable numerical identity independent of mutable content. |
| `S3-008-FOUNDING-PARTICIPANTS` | REQUIRED | Every founder receives provenance-bearing SustainingParticipant from the FormationWarrant. |
| `S3-009-FOUNDER-HOUSEHOLD-RECOGNITION` | REQUIRED | Founders directly recognize produced H from the formation event. |
| `S3-010-HEADLESS-FORMATION` | REQUIRED | New H begins with no head/office occupant and no HouseholdDecisionContext. |
| `S3-011-ACTIVE-AT-STABLE-CLOSURE` | REQUIRED | A valid founding core of 2+ sustaining participants publishes H Active only at stable closure. |
| `S3-012-NO-PRIMITIVE-HOUSEHOLD-CREATION` | REQUIRED | No public/fixture mechanism directly writes Household or FormationWarrant. |
| `S3-013-NO-HIDDEN-MEMBERS-AUTHORITY` | REQUIRED | No authoritative universal Members set or graph-cluster projection determines H. |
| `S3-014-NO-SHARED-RESIDENCE-ABLATION` | REQUIRED | Removing shared residence prevents formation while other required conditions remain controlled. |
| `S3-015-NO-DURABLE-CONNECTION-ABLATION` | REQUIRED | Breaking durable connectivity prevents formation. |
| `S3-016-RECURRENT-SUPPORT-ABLATION` | REQUIRED | One support event or same-cycle-only support cannot satisfy two-distinct-cycle recurrence. |
| `S3-017-FOUNDER-RECOGNITION-ABLATION` | REQUIRED | Withholding one required founder's CandidateRecognition prevents formation. |
| `S3-018-CANDIDATE-LABEL-NO-EVIDENCE` | REQUIRED | Candidate ID/label/existence contributes no formation evidence. |
| `S3-019-SNAPSHOT-SIMILARITY-NOT-IDENTITY` | REQUIRED | Residence/kinship/marriage/participant snapshot similarity cannot itself create/preserve H. |

### B. Participation entry / end

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-020-PARTICIPATION-REQUEST` | REQUIRED | Nonparticipant may request participation through a current sustaining participant under accepted rules. |
| `S3-021-PARTICIPATION-INVITE` | REQUIRED | Current sustaining participant may invite a nonparticipant under accepted rules. |
| `S3-022-BILATERAL-ACCEPTANCE` | REQUIRED | Entry requires named counterpart acceptance; no head/general admission authority exists. |
| `S3-023-PARTICIPATION-WARRANT` | REQUIRED | Valid entry creates ParticipationWarrant before/with SustainingParticipant. |
| `S3-024-NEWCOMER-H-RECOGNITION-GATE` | REQUIRED | Missing newcomer recognition of H blocks entry. |
| `S3-025-LIVE-BRIDGE-GATE` | REQUIRED | Missing current sustaining-participant continuity bridge blocks entry. |
| `S3-026-SHARED-RESIDENCE-ENTRY-GATE` | REQUIRED | Missing shared residence with a current sustaining participant blocks entry. |
| `S3-027-DURABLE-TIE-ENTRY-GATE` | REQUIRED | Missing durable tie to a current sustaining participant blocks entry. |
| `S3-028-POST-FORMATION-SUPPORT-GATE` | REQUIRED | Missing qualifying post-H support event blocks entry. |
| `S3-029-PARTICIPATION-END-ACTION` | REQUIRED | Current sustaining participant may explicitly end H participation. |
| `S3-030-PARTICIPATION-END-WARRANT` | REQUIRED | Valid end creates ParticipationEndWarrant and ends only the typed association. |
| `S3-031-END-PRESERVES-LOWER-LEVEL-STATE` | REQUIRED | Participation end does not erase residence/kinship/marriage/debt/favour/attitude/history. |
| `S3-032-RESIDENCE-INDEPENDENT-OF-PARTICIPATION` | REQUIRED | Residence change alone neither creates nor ends SustainingParticipant. |

### C. Continuity / lifecycle

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-040-CONTINUATION-WARRANT` | REQUIRED | Continuing H after participation transition is justified by explicit bridge + same-H recognition + ContinuationWarrant. |
| `S3-041-EXIT-SIDE-CONTINUITY` | REQUIRED | Participation-end paths explicitly preserve or fail continuity from the exit side; satisfies VH-01. |
| `S3-042-COMPLETE-FOUNDER-TURNOVER` | REQUIRED | All founders may exit after valid sequential handoffs while H numerical identity remains unchanged. |
| `S3-043-BROKEN-BRIDGE-SIMILAR-ENDPOINT` | REQUIRED | Comparable final snapshot without required bridge cannot inherit old H identity. |
| `S3-044-INACTIVE-ONE-BEARER` | REQUIRED | Exactly one current SustainingParticipant publishes H Inactive, same identity. |
| `S3-045-INACTIVE-REACTIVATION` | REQUIRED | Valid newcomer entry through sole bearer reactivates same H as Active. |
| `S3-046-SAME-CYCLE-BRIDGE-HANDOFF` | REQUIRED | Valid entry/continuity handoff resolves before sole bridge's accepted same-cycle exit. |
| `S3-047-DISSOLVED-ZERO-BEARER` | REQUIRED | Zero current sustaining participants publishes H Dissolved at stable closure. |
| `S3-048-DISSOLVED-NO-RESURRECTION` | REQUIRED | Later similar configuration cannot reactivate Dissolved H; independently formed organization gets new identity. |
| `S3-049-CONTINUITY-OVER-DUPLICATE-FORMATION` | REQUIRED | Same evidence bundle validly continuing non-Dissolved H cannot also form duplicate H2. |
| `S3-050-LIFECYCLE-STABLE-CLOSURE-ONLY` | REQUIRED | Transient within-cycle participant counts never publish completed lifecycle state. |
| `S3-051-PARTICIPANT-COUNT-NOT-IDENTITY` | REQUIRED | Lifecycle count affects operation only, never numerical identity. |

### D. Household Recognition

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-060-HOUSEHOLD-RECOGNITION-DISTINCT` | REQUIRED | H Recognition is separate from objective H state, factual KnownFact, attitude, approval/compliance and future head Recognition. |
| `S3-061-OUTSIDER-NO-PASSIVE-H-RECOGNITION` | REQUIRED | Outsider remains Unknown absent accepted direct/communication evidence even though H objectively exists. |
| `S3-062-HOUSEHOLD-RECOGNITION-PROVENANCE` | REQUIRED | H Recognition exposes supporting actor-held evidence/provenance. |
| `S3-063-HOUSEHOLD-RECOGNITION-COMMUNICATION` | REQUIRED | Held H Recognition/evidence can be communicated through ordinary Slice-2 communication semantics without invention/broadcast. |
| `S3-064-HOUSEHOLD-RECOGNITION-STALE` | REQUIRED | Objective continuity/lifecycle change without accepted route does not passively rewrite outsider Recognition. |
| `S3-065-LIFECYCLE-EVIDENCE-UPDATES-H-UNDERSTANDING` | REQUIRED, RG-02 gated | Accepted newer decisive lifecycle/continuity evidence updates the actor's relevant H understanding without generic observation. |
| `S3-066-H-RECOGNITION-INDEPENDENT-ATTITUDE` | REQUIRED | Negative attitude/refusal alone does not erase correctly evidenced H Recognition. |
| `S3-067-HOUSEHOLD-ID-NOT-EPISTEMIC-EVIDENCE` | REQUIRED | Engine-side H ID/existence/history is not itself actor evidence. |

### E. Controlled lineage

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-070-DIVISION-LINEAGE` | REQUIRED | Independently formed successor H2 receives DivisionDescendant LineageWarrant only under accepted controlled rule. |
| `S3-071-DIVISION-FRESH-EVIDENCE` | REQUIRED | Fresh qualifying person-person support occurs after all cited predecessor participation ends. |
| `S3-072-DIVISION-AMBIGUITY-WITHHOLDS-LINEAGE` | REQUIRED | Ambiguous predecessor-source/classifier case forms normally but gets no lineage warrant. |
| `S3-073-CONSOLIDATION-LINEAGE` | REQUIRED | Independently formed H3 receives ConsolidationDescendant warrant only under accepted controlled rule. |
| `S3-074-CONSOLIDATION-PREDECESSORS-DISSOLVED` | REQUIRED | Both direct predecessors must already be Dissolved before H3 formation. |
| `S3-075-CROSS-PREDECESSOR-FRESH-SUPPORT` | REQUIRED | Fresh post-dissolution support crosses predecessor sources. |
| `S3-076-PREDECESSOR-SET-ORDER-INVARIANT` | REQUIRED | Reversing predecessor enumeration does not change consolidation meaning. |
| `S3-077-LINEAGE-NONAUTHORITY` | REQUIRED | Lineage state has no independent behavioral/material/social/recognition/authority effect. |
| `S3-078-DERIVEDFROM-REBUILD` | REQUIRED | Direct DerivedFrom is rebuildable from authoritative LineageWarrant. |
| `S3-079-DIRECT-VS-TRANSITIVE-ANCESTRY` | REQUIRED | Direct derivation and transitive ancestry remain distinct queries. |
| `S3-080-LINEAGE-NO-CAUSAL-STATE-TRANSFER` | REQUIRED | Lineage transfers no resources, claims, obligations, roles, recognition, residence, attitudes, lifecycle or identity. |

### F. Grounded provision backing / capacity

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-090-PROVISION-COMMITMENT-STATE` | REQUIRED, RG-01 gated | Valid pre-existing provision commitment is representable as Person→H backing state without head/office implementation. |
| `S3-091-PROVISION-NO-GRAIN-TRANSFER` | REQUIRED | Creating/holding commitment state does not move personal grain. |
| `S3-092-PROVISION-CAPACITY-ARITHMETIC` | REQUIRED | Exposed capacity independently equals max(0, grain-2). |
| `S3-093-PROVISION-NEED-ZERO` | REQUIRED | NeedsGrain exposes zero regardless of otherwise positive reserve capacity. |
| `S3-094-NO-HOUSEHOLD-TREASURY` | REQUIRED | No persistent pooled Household grain balance is created by commitments/capacity. |
| `S3-095-PROVISION-CAPACITY-REBUILD` | REQUIRED | Derived mobilizable capacity rebuilds from authoritative commitments + personal state. |
| `S3-096-PROVISION-END-ON-PARTICIPATION-EXIT` | REQUIRED | Departing participant's provision commitment terminates with participation end. |
| `S3-097-PROVISION-END-ON-DISSOLUTION` | REQUIRED | Dissolution terminates all H provision commitments; unspent grain remains personal. |
| `S3-098-OTHER-BACKING-PERSISTS` | REQUIRED | One participant's exit does not silently erase other still-valid commitments while H remains non-Dissolved. |
| `S3-099-NO-SLICE3-HOUSEHOLD-SPEND` | REQUIRED structural/report | Slice 3 exposes backing/capacity only; no household support/dowry spend or headless spending path exists. |

### G. Reaction closure / determinism / hardening

| AcceptanceId | Status | Obligation |
|---|---|---|
| `S3-100-REACTION-IDEMPOTENCE` | REQUIRED | One cause cannot produce duplicate formation/participation/continuity/lifecycle/lineage transition. |
| `S3-101-REACTION-ORDER-PROVENANCE` | REQUIRED | Automatic causal chain has explicit monotone Cycle/ReactionIndex/provenance. |
| `S3-102-DERIVED-REFRESH-WITHIN-CLOSURE` | REQUIRED | Later automatic rules see required earlier authoritative transitions; stale derived state cannot change result. |
| `S3-103-NO-SAME-CYCLE-VOLUNTARY-REACTIVATION` | REQUIRED | Formation/recognition/participation reactions do not grant a fresh voluntary decision within same cycle. |
| `S3-104-NONSEMANTIC-ITERATION-INVARIANCE` | REQUIRED | Declared storage/input permutations preserve representative formation/continuity/lineage results. |
| `S3-105-ISOMORPHIC-ID-RENAMING` | REQUIRED | Consistent nonsemantic ID renaming preserves semantics outside explicitly accepted fallback cases. |
| `S3-106-DISCONNECTED-LOCALITY` | REQUIRED | Adding unrelated disconnected actors/households does not alter bounded result. |
| `S3-107-OBSERVER-NONINTERFERENCE` | REQUIRED | Reading H/warrant/lifecycle/lineage/epistemic inspection surfaces changes no later behavior/order/IDs/history. |
| `S3-108-DERIVED-CACHE-NONAUTHORITY` | REQUIRED | New indexes/projections/caches are absent or rebuildable/non-authoritative. |
| `S3-109-FALLBACK-QUARANTINE` | REQUIRED | Stable ID/fallback never decides candidate convergence, continuity identity, H Recognition or lineage ambiguity. |
| `S3-110-CONFIGURATION-PROVENANCE` | REQUIRED | H/warrant/decision/history output truthfully identifies active rules/config version. |
| `S3-111-PRODUCED-CHECKPOINT-PROVENANCE` | REQUIRED | Reused produced H state records producer scenario, pass status, fixture audit, authority version and output identity; satisfies VH-03. |
| `S3-112-S1-084-STRUCTURAL-INVARIANT` | REQUIRED, RG-03 gated | Slice 3 preserves the frozen no-hidden-derived-authority invariant and does not weaken the existing S1-084 evidence path for convenience. |
| `S3-113-FIXTURE-WRITESET-AUDIT` | REQUIRED | Every executable Slice-3 row reports actual fixture writes and proves forbidden result writes absent. |
| `S3-114-ORACLE-INDEPENDENCE-AUDIT` | REQUIRED | Production recognizers/warrant/lifecycle/lineage/capacity helpers do not grade themselves. |
| `S3-115-FROZEN-PRIOR-AUTHORITY-INTEGRITY` | REQUIRED | Slice-1 and Slice-2 frozen manifest identities remain unchanged. |

## 10. Prior Stage-3 obligations newly triggered

Frozen historical Slice-1 statuses are not edited.

Slice 3 must provide new evidence for these previously deferred Stage-3 properties:

- `S1-075` — household formation reaction chain;
- `S1-BND-FORMATION`;
- `S1-BND-LINEAGE`;
- `S1-META-09` — lineage predecessor-set ordering;
- `S1-MUT-01` — co-residence-only formation;
- `S1-MUT-02` — insufficient/same-cycle support formation;
- `S1-MUT-05` — identity by overlap/similarity;
- `S1-MUT-07` — participation entry without accepted warrant;
- `S1-MUT-09` — inherited causal state through lineage.

`S1-MUT-03` remains one frozen historical row spanning Household/head global recognition. Slice 3 adds Household-only no-global-recognition evidence; the head-specific portion remains Slice 4.

## 11. Exact inherited regression bindings

### Objective / subjective separation

- `S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION`
- `S2-002-KNOWNFACT-RETENTION`
- `S2-003-KNOWNFACT-PROVENANCE-CENSUS`
- `S2-004-RECOGNITION-DISTINCT`
- `S2-005-RECOGNITION-TRISTATE-LIFETIME`
- `S2-006-NO-PASSIVE-SYNC`
- `S2-007-NO-HISTORY-OMNISCIENCE`
- `S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE`

### Communication / provenance / staleness

- `S2-020F-FACT-COMMUNICATION-ACTION`
- `S2-020R-RECOGNITION-COMMUNICATION-ACTION`
- `S2-021F-COMMUNICATE-HELD-FACT`
- `S2-021R-COMMUNICATE-HELD-RECOGNITION`
- `S2-022F-NO-INVENTED-FACT`
- `S2-022R-NO-INVENTED-RECOGNITION`
- `S2-023F-FACT-COMMUNICATION-PROVENANCE`
- `S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE`
- `S2-024F-FACT-COMMUNICATION-INITIATIVE-COST`
- `S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST`
- `S2-025F-FACT-NO-FREE-BROADCAST`
- `S2-025R-RECOGNITION-NO-FREE-BROADCAST`
- `S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE`
- `S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE`
- `S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE`
- `S2-030-STALE-FACT-PERSISTS`
- `S2-031A-DIRECT-EVIDENCE-PRECEDENCE`
- `S2-031B-REPORT-EVENT-PRECEDENCE`
- `S2-032-MESSAGE-ARRIVAL-PERMUTATION`
- `S2-033-CANDIDATE-RECOGNITION-CONTESTED`

### Initiative / response

- `S1-098-CORE`
- `S1-105`
- `S2-044-OBJECTIVE-REVALIDATION-PRESERVED`

### Observer / locality / fallback / cache

- `S1-085`
- `S1-META-04`
- `S1-MUT-26`
- `S2-050-EPISTEMIC-READ-NONINTERFERENCE`
- `S1-META-03`
- `S2-008-LOCALITY`
- `S1-081`
- `S1-META-02`
- `S1-GLOBAL-FALLBACK`
- `S2-052-NONSEMANTIC-ITERATION-METAMORPHIC`
- `S2-053-ISOMORPHIC-ID-RENAMING`
- `S1-084`
- `S1-META-05`
- `S1-MUT-24`
- `S2-054-CACHE-NONAUTHORITY`

### Stable-cycle / reaction closure

- `S1-074-IDEMP`
- `S1-MUT-22`
- `S1-MUT-23`
- `S1-090-D`
- `S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE`
- `S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE`

### Lower-level relation meaning

- `S1-091-MEANING-SEPARATION`
- `S1-093-GIFT-CONTROL`
- `S1-093-KIN-GATE`
- `S1-095-NO-RESIDENCE`
- `S1-096-NO-HH`
- `S1-096-MARRIAGE-CONTROL`
- `S1-097-EVENTS`
- `S1-MUT-04`
- `S1-MUT-16`
- `S1-MUT-17`
- `S1-MUT-18`
- `S1-MUT-19`
- `S1-MUT-20`
- `S1-MUT-21`

### Trace / configuration

- `S1-086`
- `S1-MUT-29`
- `S2-042-SUBJECTIVE-TRACE`
- `S2-045-PINNED-POLICY-NONCLAIM`
- `S2-055-CONFIGURATION-PROVENANCE`

Completion output must report these bindings explicitly rather than only “prior tests passed.”

## 12. Explicit deferrals

| AcceptanceId | Status | Trigger |
|---|---|---|
| `S3-D01-GENERAL-CANDIDATE-CONVERGENCE` | DEFERRED | Before implementation merges/reconciles distinct candidate referents as one prospective organization. |
| `S3-D02-ACTOR-DEPARTURE` | DEFERRED | Before world-level actor departure becomes executable. |
| `S3-D03-REPEATED-PREDECESSOR-PARTICIPATION` | DEFERRED | Before controlled lineage admits repeated rejoin/re-exit histories for one predecessor. |
| `S3-D04-HEAD-ROLE` | DEFERRED | Slice 4. |
| `S3-D05-HOUSEHOLD-DECISION-CONTEXT` | DEFERRED | Slice 4. |
| `S3-D06-PROVISION-SOLICITATION-RECONSIDERATION` | DEFERRED | Slice 4 head scope. |
| `S3-D07-HOUSEHOLD-SPENDING` | DEFERRED | Slice 4. |
| `S3-D08-MEDIATED-MARRIAGE` | DEFERRED | Slice 4. |
| `S3-D09-GENERIC-NONPARTICIPANT-OBSERVATION` | DEFERRED | Future event-specific accepted rule if needed. |
| `S3-D10-CHECKPOINT-RESTORE` | DEFERRED | Slice 5. |
| `S3-D11-GENERATED-HISTORY-FRAMEWORK` | DEFERRED | Re-open only if made required completion evidence; then VH-02 fires. |
| `S3-D12-RENDERED-CAUSAL-EXPLANATION` | DEFERRED | Future/unexercised unless separately activated. |

## 13. Fixture classes

| FixtureClass | Allowed pre-state | Forbidden result write |
|---|---|---|
| `F3-FORM` | lower-level people/grain/residence/tie facts; declared lower-level subjective observations; scheduled ordinary support/communication | Household, FormationWarrant, SustainingParticipant, final CandidateRecognition when derivation under test, H Recognition, lifecycle, lineage |
| `F3-PRODUCED-H` | H state produced by a previously passing producer with recorded authority/version/fixture/output identity | hand-authored H/warrant/participant/lifecycle state |
| `F3-ENTRY` | F3-PRODUCED-H + newcomer lower-level setup + controlled actor-held evidence not under acquisition test | ParticipationWarrant, SustainingParticipant result, ContinuationWarrant, lifecycle result |
| `F3-END` | F3-PRODUCED-H + public EndHouseholdParticipation action | ParticipationEndWarrant, ended association, ContinuationWarrant, lifecycle result |
| `F3-RECOG` | produced H + controlled sender-held evidence when sender acquisition is not the row under test | recipient final H Recognition, generic observer entitlement |
| `F3-LINEAGE` | produced predecessor histories + ordinary lower-level successor setup | LineageWarrant, DerivedFrom, predecessor classification |
| `F3-PROVISION` | produced H + declared pre-existing valid provision commitment only if RG-01 approves | commitment acquisition result, capacity result, grain transfer, treasury, head state |
| `F3-META` | baseline + exactly declared permutation/read/rebuild/irrelevant perturbation | hidden semantic changes between paired runs |
| `F3-STRUCT` | repository/source/public-state inspection only | runtime result mutation |

Every executable row must report its actual fixture write set.

## 14. Oracle classes

| OracleClass | Independent basis | Forbidden production dependency |
|---|---|---|
| `O3-FORM` | hand reconstruction from lower-level events + founder actor evidence | production candidate/formation recognizer |
| `O3-WARRANT` | public warrant references checked directly against public history/evidence | production warrant validator/classifier |
| `O3-CONT` | explicit Formation→Participation/End→Continuation chain | production same-H/continuity classifier |
| `O3-LIFE` | reconstruct current SustainingParticipant transitions then apply 2+/1/0 only at stable closure | production lifecycle classifier |
| `O3-RECOG` | paired public actor epistemic/provenance states | production H-recognition updater/conflict helper |
| `O3-LINEAGE` | independently check exits, predecessor lifecycle, fresh support order, source mapping | production lineage classifier |
| `O3-CAP` | arithmetic over personal grain/NeedsGrain + valid commitment state | production capacity helper |
| `O3-META` | paired semantic equality under declared perturbation | production normalizer as expected answer |
| `O3-STRUCT` | source/public structural audit | production runtime classifier as sole proof |

## 15. Review Gate RG-01 — Provision prerequisite fixture authority

Fresh pre-code review must independently determine whether the accepted fixture boundary permits a declared pre-existing valid HouseholdProvisionCommitment as prerequisite setup for rows that test only backing-state/capacity semantics.

The review must verify that this does not:

- invent a headless acquisition route;
- claim commitment formation was implemented;
- fixture-write capacity;
- transfer grain;
- create Household/head state;
- make the commitment formation/continuity evidence.

Return:

- **SUPPORTED**;
- **SUPPORTED ONLY WITH VERIFICATION-AUTHORITY REPAIR**;
- **NOT SUPPORTED / SEMANTIC ESCALATION**.

If NOT SUPPORTED, do not invent an alternative commitment-acquisition semantic.

## 16. Review Gate RG-02 — Lifecycle / Household Recognition witness

Fresh pre-code review must pin a bounded accepted witness satisfying VH-05 for lifecycle/continuity Recognition without generic observation.

Preferred shape:

1. outsider X recognizes a non-Dissolved H from accepted older evidence;
2. H undergoes accepted participation/lifecycle transition without X as participant or recipient;
3. X remains stale rather than passively synchronizing;
4. a direct participant later communicates decisive event-backed lifecycle/continuity evidence;
5. X's actor-held factual/Recognition basis updates under accepted evidence-order rules;
6. no head/authority proposition is involved.

The reviewer must decide whether the completion authority may safely require a particular resulting Recognition status for current continuation, or whether only the factual/provenance update and removal of safe reliance can be asserted from accepted authority.

Do not invent negative recognition semantics.

## 17. Review Gate RG-03 — S1-084 structural evidence preservation

Frozen Slice-1 `S1-084` currently uses a structural audit that is sensitive to authoritative-state field layout.

Slice 3 must preserve its semantic invariant:

> no hidden behavior-affecting derived state is authoritative.

The implementer may not weaken/delete/reclassify `S1-084` because new Household state is inconvenient.

Fresh pre-code review must determine whether candidate authority should require:

- exact existing evidence to remain mechanically green unchanged; or
- a separately reviewed lossless adaptation path if higher-order authoritative state cannot fit without changing the exact structural assertion.

No adaptation is authorized by this candidate itself.

## 18. Review Gate RG-04 — Candidate convergence boundary

Fresh pre-code review must confirm that all REQUIRED witnesses can execute without reconciling two distinct candidate referents as the same prospective organization.

If any REQUIRED formation/lineage witness inherently requires multi-label convergence, LATER-01 becomes a semantic blocker before freeze.

## 19. Completion evidence

A Slice-3 implementation candidate may claim completion only when:

1. every REQUIRED S3 row executes and passes;
2. all explicit deferrals remain visible;
3. all newly triggered prior Stage-3 obligations in §10 have substantive Slice-3 evidence;
4. all exact inherited regression bindings in §11 pass;
5. frozen Slice-1 and Slice-2 manifest identities remain unchanged;
6. root restore/format/build/test commands pass;
7. acceptance output lists every S3 AcceptanceId and status;
8. fixture write-set audit passes;
9. oracle-independence audit passes;
10. no REQUIRED witness uses generic nonparticipant observation;
11. no REQUIRED witness requires candidate convergence;
12. no Household/head/spending path has been pulled forward;
13. VH-01 / VH-03 / lifecycle-side VH-05 / VH-06 are substantively closed;
14. a fresh independent post-implementation conformance reviewer passes the exact frozen candidate.

## 20. Pre-code review requirements

This candidate must receive a fresh regular clean-context pre-code review before freeze.

The reviewer must independently re-derive from accepted sources and inspect:

- completeness of Slice-3 applicability;
- semantic subordination;
- formation/continuity/lineage omission-detectability;
- LATER-01 bounded avoidance;
- Slice3/Slice4 capability boundary;
- RG-01 provision fixture authority;
- RG-02 lifecycle Recognition witness;
- RG-03 frozen structural-regression handling;
- fixture producer provenance / VH-03;
- oracle independence;
- reaction-chain / VH-06 coverage;
- exact prior-slice regressions;
- later-slice leakage;
- broad/global claims and bounded metamorphic domains.

Return PASS/BLOCK.

A BLOCK does not reopen accepted SFL semantics automatically.

## 21. Freeze mechanics

After independent **PASS — MAY FREEZE UNCHANGED**:

- promote reviewed bytes as `SFL-V0-S3-ACCEPTANCE-v1`;
- record reviewed candidate commit/blob;
- create immutable freeze ref;
- write external freeze record;
- semantic/applicability edits after freeze require new version/review.

## 22. Director escalation map

### No Director decision currently required

Already accepted or bounded:

- formation predicate;
- persistent H identity;
- warrant-based participation/continuity;
- lifecycle;
- controlled lineage;
- H Recognition scope;
- provision backing/capacity without spending;
- no-convergence Slice-3 path.

### Escalate only if triggered

1. REQUIRED behavior needs two candidate referents interpreted as one prospective organization;
2. provision backing cannot be tested/represented without inventing a new commitment-acquisition semantic;
3. lifecycle Recognition requires a new observation entitlement or unsupported negative-recognition rule;
4. controlled lineage requires repeated predecessor rejoin/re-exit source selection;
5. head/authority actions become necessary for Slice-3 completion;
6. a new continuity ambiguity is not determined by accepted warrants/precedence.

## 23. Current release judgment

**NO RELEASE TO IMPLEMENTATION YET.**

Candidate-v1 requires fresh independent pre-code review.

Expected state after PASS and freeze:

**SLICE 3 ACCEPTANCE FROZEN / IMP-0003 IMPLEMENTATION PACKET AUTHORIZED.**
