# SFL v0 Slice 4 — Acceptance Manifest

**Status:** FROZEN ACCEPTANCE AUTHORITY  
**Manifest version:** `SFL-V0-S4-ACCEPTANCE-v1`  
**Owner:** Master Architect  
**Scope:** Roadmap Stage 4 / Slice 4 — persistent HouseholdHeadRole + occupancy/Recognition + dual-mode Household agency + scoped provision/spending/mediated-marriage authority  
**Semantic authority:** accepted SPEC-SFL-0001 + accepted ADRs/decisions, including `DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md`  
**Canonical authority base:** `5396b41f3b23e2833ad223d7e4eb93ed37c0eb64`  
**Prior frozen completion authority:** SFL-V0-S1-ACCEPTANCE-v1, SFL-V0-S2-ACCEPTANCE-v1, SFL-V0-S3-ACCEPTANCE-v1 remain immutable and are referenced, not edited  
**Primary reconciliation:** `research/technical/SFL_V0_SLICE4_PREIMPLEMENTATION_RECONCILIATION.md`  
**Reviewed candidate:** `sfl-v0-slice4-acceptance-v1-candidate2` @ `5aaf3c131e36a9139ddfa9d225c04f6fc6e86dce`  
**Reviewed candidate blob:** `1ea19ec6c65f2031de920791334b32eaa10f398e`  
**Final pre-code review:** `research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE2.md` — **PASS — MAY FREEZE UNCHANGED**  
**Coding status:** NOT YET AUTHORIZED — inherited verification adaptation gate must close first

## 1. Purpose

Define omission-detectable Slice-4 completion authority without inventing office, legitimacy, observation, sovereignty, checkpoint, or contested-succession semantics beyond accepted SFL v0.

Slice 4 makes executable the already-accepted representative/head layer:

- one persistent `HouseholdHeadRole(H)`, initially vacant;
- appointment/succession from current SustainingParticipant nomination + nominee consent + unanimity;
- vacancy without Household identity loss;
- actor-specific head-role Recognition and stale/corrected/Contested authority evidence;
- one separate Household initiative through the current head while the person retains one personal initiative;
- endogenous provision solicitation/reconsideration;
- grounded Household support and mediated-marriage expenditure;
- fixed-rank multi-contributor debit and accepted provision priority;
- scoped role authority, not sovereignty;
- DEC-0010 authority-use-before-authority-destruction same-cycle precedence;
- exact prior-slice regression protection and lossless inherited verification adaptation.

This frozen manifest is verification/completion authority subordinate to accepted semantics. It cannot create or amend social rules.

## 2. Controlling boundary

### 2.1 Required now

Slice 4 must make executable and omission-detectable:

1. persistent role identity separate from H and holder;
2. initial vacancy and no implicit election;
3. initial appointment, vacancy, succession and exact role/H identity preservation;
4. nominee consent + unanimity + current participant eligibility;
5. actor-specific head Recognition, stale predecessor evidence, correction and Contested gating;
6. separate personal and Household decision contexts from one common committed snapshot;
7. scoped role authority and negative sovereignty census;
8. endogenous provision commitment acquisition and reconsideration;
9. Household support, fixed-rank contributor debit, dowry and provision priority;
10. mediated marriage under the accepted groom→current-head role-scoped response topology;
11. DEC-0010 valid-last-act-before-authority/status-destruction precedence;
12. stable closure, exact provenance, locality, observer noninterference, cache nonauthority, fallback quarantine and metamorphic controls;
13. exact inherited frozen REQUIRED regression reporting;
14. lossless adaptation of inherited literal Slice-3 verification witnesses before coding where later accepted types/state make those literals obsolete.

### 2.2 Explicitly outside Slice 4

Do not require or implement:

- exact engine checkpoint/restore continuation;
- generic actor departure;
- general CandidateOrganization convergence;
- repeated-predecessor lineage-source generalization;
- general contested succession / multiple simultaneous claimants / usurpation;
- a separate resignation action while remaining a sustaining participant;
- generic nonparticipant perception/observation;
- trust, lying, rumor, reputation;
- general Household sovereignty/deep administration;
- strategic/stochastic policy redesign;
- rendered explanation UI;
- generic generated-history framework as a completion gate.

### 2.3 DEC-0010 boundary

The accepted precedence is narrow:

`otherwise-valid authority/status-dependent accepted attempt -> authority/status-destroying accepted transition`.

It does not:

- rescue an attempt invalid at the common snapshot;
- waive unrelated preconditions;
- override a more-specific semantic priority;
- rebind an old-head action to a successor;
- authorize technical-ID authority.

## 3. Fixture / producer authority

Fixtures may seed bounded lower-level facts and may reuse produced verified Slice-3 Household state with producer/pass/fixture-audit/rule/output identity.

They may not direct-write an endogenous result under test.

Never fixture-write as the expected conclusion:

- occupied head;
- appointment/succession/vacancy result;
- final head Recognition;
- HouseholdDecisionContext selection/result;
- endogenous provision commitment when acquisition is under test;
- contributor debit vector or Household spend result;
- mediated marriage/favour result;
- DEC-0010 race winner/result.

For downstream spend cases where commitment acquisition is not the target, a commitment may be reused only from a verified Slice-4 provision-acquisition producer or from an explicitly declared controlled prerequisite whose use cannot prove acquisition.

## 4. Oracle independence / adequacy

Independent verification must reconstruct expected role/authority/material results from accepted public state/history rather than production classifiers under judgment.

At minimum independently bind:

- H and persistent role identity;
- pre/post occupant;
- exact nomination and nominator/nominee eligibility;
- exact nominee acceptance;
- complete distinct required participant acceptance/unanimity set;
- exact role-transition event and causal predecessor references;
- actor-held head Recognition EvidenceIds/provenance/event order;
- provision request/refusal/cooldown/context baseline;
- contributor set, live exposed capacities, fixed rank and exact debit vector;
- mediated bride/groom/head gates and atomic effects;
- DEC-0010 paired attempts and semantic order;
- stable closure and rule/configuration provenance.

Detached corruptions must reach the actual independent checker and reject materially false but well-formed snapshots.

## 5. Applicability table


### A. Persistent role / appointment / vacancy / succession

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-001-PERSISTENT-HEAD-ROLE | REQUIRED | Every produced Household has one persistent HouseholdHeadRole(H) identity distinct from H and any occupant PersonId; role identity survives vacancy and succession. |
| S4-002-NEW-HOUSEHOLD-ROLE-VACANT | REQUIRED | Newly formed H creates/contains its persistent head role in vacant state; H formation does not install an occupant. |
| S4-003-NO-AUTOELECTION | REQUIRED | No founder, participant, stable ID, sex, grain, kinship, residence, fixture order, or score tie automatically installs a head. |
| S4-004-INITIAL-APPOINTMENT-POSITIVE | REQUIRED | Current SustainingParticipant nominates a current SustainingParticipant; nominee accepts; every current SustainingParticipant accepts/recognizes; one occupant is installed in the existing persistent role. |
| S4-005-NOMINEE-DECLINE | REQUIRED | Nominee decline prevents appointment and leaves role vacant. |
| S4-006-MISSING-UNANIMITY | REQUIRED | One missing/negative required current-participant acceptance prevents appointment; majority support is insufficient. |
| S4-007-NONPARTICIPANT-NOMINATOR | REQUIRED | A nonparticipant cannot validly nominate. |
| S4-008-NONPARTICIPANT-NOMINEE | REQUIRED | A nonparticipant cannot validly occupy the role through nomination/appointment. |
| S4-009-APPOINTMENT-PRECOMMIT-ELIGIBILITY | REQUIRED | Nominator, nominee, H, role, and required current-participant set are revalidated immediately before appointment commit. |
| S4-010-APPOINTMENT-EVIDENCE-PROVENANCE | REQUIRED | Appointment history independently binds H/role, nominator, nominee, nominee acceptance, every required distinct participant acceptance/recognition, semantic time, and rule/configuration version. |
| S4-011-VACANCY-ON-HEAD-PARTICIPATION-END | REQUIRED | If the current head ends Household participation, the same persistent role becomes vacant as a causal consequence of the accepted participation-end transition. |
| S4-012-VACANCY-PRESERVES-H | REQUIRED | Head vacancy does not destroy, recreate, split, or otherwise change Household numerical identity. |
| S4-013-VACANCY-PRESERVES-OTHER-BACKING | REQUIRED | Head exit terminates only that person's own provision commitment under ordinary participation-end semantics; other valid commitments remain unless another accepted rule terminates them. |
| S4-014-VACANCY-SUSPENDS-HOUSEHOLD-INITIATIVE | REQUIRED | Vacant H emits no HouseholdDecisionContext and no head-scoped Household action while ordinary personal actions remain independently available. |
| S4-015-SUCCESSION-POSITIVE | REQUIRED | Valid outgoing-head nomination + nominee acceptance + unanimity changes occupant A→B under the same persistent role. |
| S4-016-SUCCESSION-PRESERVES-H-ID | REQUIRED | Succession does not change Household ID. |
| S4-017-SUCCESSION-PRESERVES-ROLE-ID | REQUIRED | Succession does not allocate a new role identity; only occupant changes. |
| S4-018-SUCCESSION-NO-AUTO-FALLBACK | REQUIRED | Missing nominee consent/unanimity never falls through to stable-ID/container/proposal-order selection. |
| S4-019-INACTIVE-NO-HOUSEHOLD-INITIATIVE | REQUIRED | Inactive H has no Household initiative even if its persistent role remains represented. |
| S4-020-DISSOLVED-NO-HOUSEHOLD-INITIATIVE | REQUIRED | Dissolved H has no Household initiative and no valid head-scoped Household action. |
| S4-021-NO-GENERAL-RESIGNATION-ACTION | REQUIRED | Slice 4 does not invent a separate voluntary resign-office-while-remaining-participant action; executable vacancy/succession paths are only those already accepted. |
| S4-022-ROLE-IDENTITY-NOT-HOLDER-IDENTITY | REQUIRED | Role identity/occupancy remains separately inspectable; holder PersonId cannot substitute for role identity in authority/history/oracles. |

### B. Head Recognition / evidence / staleness

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-030-HEAD-RECOGNITION-DISTINCT | REQUIRED | Actor-specific Recognition of P as H head/scope remains distinct from objective occupancy, Household Recognition, KnownFact, attitude, approval, obedience, and capability. |
| S4-031-TRANSITION-PARTICIPANTS-DIRECT-RECOGNITION | REQUIRED | Appointment/succession participants directly acquire the resulting head-role evidence through participation in that role transition. |
| S4-032-OUTSIDER-STALE-PREDECESSOR | REQUIRED | Uninvolved outsider may retain predecessor A recognition after objective succession A→B; objective role state does not passively synchronize the outsider. |
| S4-033-HEAD-RECOGNITION-CORRECTION | REQUIRED | Newer accepted direct/event-backed communicated evidence can correct stale predecessor recognition to current successor with provenance to the actual transition. |
| S4-034-EVENT-ORDER-BEATS-MESSAGE-ARRIVAL | REQUIRED | Later-arriving older head report cannot overwrite newer event-backed evidence; underlying semantic event order controls accepted precedence. |
| S4-035-HEAD-RECOGNITION-CONTESTED | REQUIRED | Incompatible incomparable current-head evidence produces Contested rather than an ID/arrival-order winner. |
| S4-036-CONTESTED-HEAD-AUTHORITY-GATE | REQUIRED | Contested head Recognition cannot safely satisfy an authority-channel gate requiring current recognized head/scope. |
| S4-037-HEAD-RECOGNITION-INDEPENDENT-ATTITUDE | REQUIRED | Negative attitude/refusal does not erase valid head Recognition absent accepted contrary authority evidence. |
| S4-038-STRUCTURAL-STATUS-NOT-INFORMATION-ENTITLEMENT | REQUIRED | Current SustainingParticipant status, current head occupancy, co-residence, provision backing, or access to H state does not by itself grant knowledge of role transitions. |
| S4-039-VACANCY-EVIDENCE-LOCALITY | REQUIRED | Vacancy evidence reaches actors only through accepted direct participation/observation/communication routes; no participant-wide or world-wide broadcast is introduced. |
| S4-040-HEAD-EVIDENCE-EXACT-ID-PROVENANCE | REQUIRED | Independent verification binds exact held EvidenceId/event/provenance for head Recognition and rejects fabricated IDs with copied content/provenance. |
| S4-041-HEAD-SCOPE-RECOGNITION | REQUIRED | Authority-channel actions requiring head/scope Recognition are available only with the accepted actor-held proposition for the current H/role scope. |
| S4-042-NO-ROLE-OMNISCIENT-MIND | REQUIRED | Role/H context does not create a separate omniscient subjective state; non-office cognition/knowledge remains tied to the person carrying the role. |

### C. Dual personal / Household decision mode and scoped authority

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-050-PERSONAL-INITIATIVE-RETAINED | REQUIRED | Head P retains exactly one ordinary personal voluntary initiative under the inherited personal-agency rules. |
| S4-051-SEPARATE-HOUSEHOLD-INITIATIVE | REQUIRED | Active H with occupied valid head gets one separate Household initiative through P; it is not counted as P's second personal initiative. |
| S4-052-DUAL-MODE-COMMON-SNAPSHOT | REQUIRED | P personal context and H HouseholdDecisionContext read the same committed decision snapshot and do not observe one another's uncommitted effects. |
| S4-053-HOUSEHOLD-SCORING-SEPARATE | REQUIRED | Household candidates/components use Household concerns/capability and pinned Household profile rather than reusing P's personal-action score. |
| S4-054-HOUSEHOLD-CONTEXT-USES-PERSON-Cognition | REQUIRED | P is cognitive carrier for the H context; no separate Household mind or duplicated personal subjective state is created. |
| S4-055-RESPONSES-DO-NOT-CONSUME-EITHER-INITIATIVE | REQUIRED | Incoming personal/role-scoped responses remain separate from personal and Household initiative accounting. |
| S4-056-DUAL-MODE-COMPATIBLE-BOTH-COMMIT | REQUIRED | Compatible personal and Household actions selected from the common snapshot may both commit; neither context suppresses the other merely by existing. |
| S4-057-DUAL-MODE-SHARED-RESOURCE-CONFLICT | REQUIRED | When personal and Household actions compete for the same current backing/resource, central semantic priority/revalidation determines commit/invalidation without retroactive refusal or retry. |
| S4-058-VACANT-NO-HOUSEHOLD-CONTEXT | REQUIRED | Vacant role yields no HouseholdDecisionContext, not a semantic Wait action. |
| S4-059-INACTIVE-NO-HOUSEHOLD-CONTEXT | REQUIRED | Inactive H yields no HouseholdDecisionContext even if role occupancy is otherwise represented. |
| S4-060-SCOPED-AUTHORITY-NEGATIVE-CENSUS | REQUIRED | Head role cannot seize personal grain, command residence/gift/loan/favour, create kinship/debt/favour by fiat, directly alter attitude, or exercise generic sovereignty. |
| S4-061-PERSON-LEVEL-ACTIONS-INDEPENDENT-OF-OFFICE | REQUIRED | A person who is head still uses ordinary personal action/response semantics for person-person actions; office status creates no shortcut or compulsion. |
| S4-062-ROLE-TRACE-CONTEXT-TRUTH | REQUIRED | Household decision traces identify H, persistent role, current occupant/cognitive carrier, relevant authority/Recognition evidence, profile/rules, candidates/components/result, and fallback domain. |
| S4-063-FALLBACK-DOMAIN-DISTINCTION | REQUIRED | Human/machine evidence distinguishes decision/scoring tie fallback from central-resolution technical fallback; one generic marker may not erase the domain distinction. |
| S4-064-NO-HOUSEHOLD-ACTION-FROM-EXISTENCE-ALONE | REQUIRED | H existence without Active lifecycle + occupied valid role + in-scope authority never generates Household action. |

### D. Endogenous provision acquisition / reconsideration / spending

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-070-PROVISION-REQUEST-ENDOGENOUS | REQUIRED | Valid head may request provision commitment from a noncontributing current SustainingParticipant through a real proposal/response path. |
| S4-071-PROVISION-ACCEPTANCE-CREATES-COMMITMENT | REQUIRED | Target acceptance plus current-valid head/participant preconditions creates exactly one provenance-bearing HouseholdProvisionCommitment. |
| S4-072-PROVISION-ACQUISITION-NO-GRAIN-MOVE | REQUIRED | Commitment creation does not transfer personal grain; mobilizable capacity remains derived. |
| S4-073-PROVISION-DECLINE-NO-COMMITMENT | REQUIRED | Voluntary refusal creates no commitment and retains explicit refusal history. |
| S4-074-RECONSIDERATION-COOLDOWN | REQUIRED | After refusal, repeat request is ineligible until three full cycles have elapsed. |
| S4-075-RECONSIDERATION-CONTEXT-CHANGE | REQUIRED | Cooldown completion alone is insufficient; at least one accepted relevant context dimension must have changed since refusal. |
| S4-076-RECONSIDERATION-IRRELEVANT-CHANGE | REQUIRED | Changing an attribute outside the accepted closed context-change list does not unlock reconsideration. |
| S4-077-HOUSEHOLD-SUPPORT-POSITIVE | REQUIRED | Active H + occupied valid head + eligible needy SustainingParticipant + sufficient current backing commits 1-grain support with exact contributor debit/recipient credit and need clearing. |
| S4-078-SUPPORT-VACANCY-NEGATIVE | REQUIRED | Vacant H cannot generate/commit Household support. |
| S4-079-SUPPORT-INACTIVE-NEGATIVE | REQUIRED | Inactive H cannot generate/commit Household support. |
| S4-080-SUPPORT-NONPARTICIPANT-NEGATIVE | REQUIRED | Household support route is unavailable for a recipient who is not a current SustainingParticipant. |
| S4-081-PROTECTED-RESERVE-BOUNDARY | REQUIRED | Contributor exposed capacity preserves reserve 2 and is zero for NeedsGrain; spend cannot penetrate reserve. |
| S4-082-MULTI-CONTRIBUTOR-FIXED-RANK | REQUIRED | One expenditure ranks currently valid contributors once by exposed capacity descending and exhausts them in that fixed order without reranking. |
| S4-083-MULTI-CONTRIBUTOR-EXACT-TIE | REQUIRED | Exact exposed-capacity ties use stable semantic PersonId only as the disclosed accepted technical fallback inside the contributor ranking domain. |
| S4-084-MULTI-CONTRIBUTOR-INSUFFICIENT-ATOMIC | REQUIRED | If validated total capacity is insufficient, no partial contributor debit becomes authoritative and no Household treasury/negative balance appears. |
| S4-085-EXACT-DEBIT-VECTOR-HISTORY | REQUIRED | Committed collective expenditure history records the exact contributor debit vector and backing commitments. |
| S4-086-LIVE-CAPACITY-REVALIDATION | REQUIRED | Provision capacity/backing is recomputed/revalidated at precommit; stale derived capacity cannot authorize spend. |
| S4-087-EXIT-TERMINATES-CONTRIBUTOR-BACKING-REGRESSION | REQUIRED | Participant exit terminates that person's commitment before later spends while leaving unspent grain personal. |
| S4-088-DISSOLUTION-TERMINATES-BACKING-REGRESSION | REQUIRED | Household dissolution terminates remaining provision commitments and exposes zero future collective capacity. |
| S4-089-PROVISION-PRIORITY | REQUIRED | Central resolution applies eligible NeedsGrain support > other valid Household provision expenditure > ordinary voluntary personal transfer; each lower-priority attempt revalidates after higher-priority commits. |
| S4-090-NO-POOLED-TREASURY | REQUIRED | All collective spend debits personal backing directly; no persistent Household grain balance is created. |
| S4-091-HOUSEHOLD-SUPPORT-NOT-ORGANIZATIONAL-EVIDENCE | REQUIRED | Household-originated support cannot count as independent formation, continuity, or fresh-lineage support evidence. |

### E. Household-mediated marriage

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-100-MEDIATED-MARRIAGE-POSITIVE | REQUIRED | When bypass is unavailable, bride is current female SustainingParticipant, groom knows bride→H fact and recognizes H/current head/scope, current head accepts, capacity suffices, and other gates hold, mediated marriage may commit. |
| S4-101-MEDIATED-BRIDE-PARTICIPATION-FACT-GATE | REQUIRED | Removing groom's accepted bride→H participation fact suppresses only the mediated route. |
| S4-102-MEDIATED-HOUSEHOLD-RECOGNITION-GATE | REQUIRED | Removing groom's H Recognition suppresses the mediated route. |
| S4-103-MEDIATED-HEAD-SCOPE-RECOGNITION-GATE | REQUIRED | Removing groom's current head/scope Recognition suppresses the mediated route. |
| S4-104-ROLE-SCOPED-HEAD-RESPONSE | REQUIRED | Current valid head receives the mediated role-scoped response context; response profile cannot manufacture authority when P is not current valid head. |
| S4-105-HEAD-ACCEPTANCE-SUFFICIENT | REQUIRED | The bounded mediated route requires the current head's role-scoped acceptance and does not introduce an additional bride ResponseDecisionContext. |
| S4-106-DOWRY-DIRECT-TO-GROOM | REQUIRED | Collective dowry debits current valid personal backing atomically and credits groom directly; no intermediate Household-owned grain appears. |
| S4-107-GROOM-FAVOUR-TO-HEAD | REQUIRED | Successful mediated commit creates exactly one groom→mediating-head favour together with marriage/dowry effects. |
| S4-108-EXISTING-GROOM-TO-HEAD-FAVOUR-BLOCKS | REQUIRED | If groom already owes mediating head a favour, mediated route cannot commit. |
| S4-109-GROOM-CANNOT-SELF-AUTHORIZE | REQUIRED | Groom equal to mediating head invalidates the mediated route. |
| S4-110-FEMALE-HEAD-SELF-MEDIATION | REQUIRED | Female bride who is the valid head may receive/resolve groom's mediated proposal in her head role; this is not groom self-authorization. |
| S4-111-DIRECT-STRONG-LIKE-BYPASS-INDEPENDENT | REQUIRED | Mutual-strong-like direct marriage bypass remains independent of Household mediation and produces no dowry spend or groom→head favour. |
| S4-112-MEDIATED-EFFECTS-ATOMIC | REQUIRED | Contributor debits, groom credit, marriage, and groom→head favour commit atomically or not at all. |
| S4-113-MEDIATED-AUTHORITY-REVALIDATION | REQUIRED | Current H/head authority, bride participation, groom subjective gates, marriage eligibility, favour slot, and live provision capacity revalidate before commit. |
| S4-114-DIRECT-MARRIAGE-ROUTE-NOT-WEAKENED | REQUIRED | Existing direct ProposeMarriage semantics are not broadened to consult objective H state or silently choose mediated authority. |
| S4-115-MEDIATED-DOWRY-TERM-VALIDITY | REQUIRED | On the Household-mediated ProposeMarriage route, proposedDowry obeys the global grain-term validity rule: zero, negative, and non-integral/unrepresentable-without-coercion terms are categorically rejected before the head's role-scoped ResponseDecisionContext, create no valid social failed-attempt outcome or material/social effect, and do not reach role-scoped response scoring; a valid positive integer may proceed to ordinary mediated-route gates. |

### F. DEC-0010 same-cycle authority/status precedence and resolution

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-120-LAST-ACT-BEFORE-HEAD-EXIT | REQUIRED | Otherwise-valid accepted head/Household action resolves before the same-cycle accepted participation end that would vacate the current head. |
| S4-121-LAST-ACT-BEFORE-SUCCESSION | REQUIRED | Otherwise-valid accepted old-head action resolves before accepted same-cycle A→B succession; action remains attributed to old head and never rebinds. |
| S4-122-LAST-ACT-BEFORE-H-INACTIVE-DISSOLVED | REQUIRED | Otherwise-valid accepted Household action resolves before accepted same-cycle status transitions whose commit would remove the Active/authority status it depends upon. |
| S4-123-STATUS-DEPENDENT-ROLE-TRANSITION-LAST-ACT | REQUIRED | An otherwise-valid accepted role/authority transition depending on current institutional status resolves before the paired accepted transition that would destroy that exact required status. |
| S4-124-OTHER-PRECONDITIONS-STILL-REVALIDATE | REQUIRED | DEC-0010 protects only the paired authority/status from the later destructive transition; all other action-relevant preconditions still revalidate normally. |
| S4-125-MORE-SPECIFIC-PRIORITY-PRESERVED | REQUIRED | DEC-0010 does not override a more-specific accepted semantic/domain priority that independently prevents or orders the protected attempt. |
| S4-126-NO-REBIND-TO-SUCCESSOR | REQUIRED | Pending old-head action never rebinds to new head/role occupant. |
| S4-127-INVALID-AT-SNAPSHOT-NOT-REVIVED | REQUIRED | DEC-0010 does not revive an action/transition whose required authority/status was already invalid at the common decision snapshot. |
| S4-128-NO-TECHNICAL-ID-AUTHORITY-PRECEDENCE | REQUIRED | Proposal/container/stable/raw allocation IDs and generic fallback do not choose between authority-use and authority destruction. |
| S4-129-AUTHORITY-RACE-ENUMERATION-METAMORPHIC | REQUIRED | Reversing nonsemantic proposal/input/world enumeration preserves the DEC-0010 semantic ordering/result modulo technical identities. |
| S4-130-DESTRUCTIVE-TRANSITION-STILL-RESOLVES | REQUIRED | After the protected last act resolves, the authority/status-destroying transition resolves normally and takes effect. |
| S4-131-OTHER-FAILURE-REMAINS-FAILURE | REQUIRED | If another independent precondition is lost, protected attempt terminates under the ordinary Unable/Invalidated taxonomy rather than committing by office privilege. |
| S4-132-HEAD-RECOGNITION-REVALIDATION | REQUIRED | Authority-dependent use requiring actor-recognized current head/scope cannot commit on stale/Contested authority evidence when that subjective gate is action-relevant at precommit. |
| S4-133-PROVISION-LOSS-REVALIDATION | REQUIRED | Live backing/capacity loss still invalidates or prevents material commit despite DEC-0010; authority precedence does not reserve grain. |
| S4-134-SEMANTIC-PRIORITY-NOT-GENERAL-OFFICE-SOVEREIGNTY | REQUIRED | No other same-cycle interaction acquires head-first precedence merely because a head is involved; DEC-0010 applies only to the accepted authority/status-destruction shape. |

### G. Cross-cutting assurance / nonauthority / determinism

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-140-HOUSEHOLD-FEEDBACK-NONAUTHORITY | REQUIRED | Actual Household-originated support/spend cannot satisfy independent formation/continuity/fresh-lineage evidence or clone H. |
| S4-141-OCCUPANCY-NOT-GLOBAL-RECOGNITION | REQUIRED | Objective role occupancy never becomes global actor Recognition or a hidden authority shortcut. |
| S4-142-CAPACITY-NOT-AUTHORITY | REQUIRED | Provision backing/mobilizable capacity never substitutes for valid occupied role/scope/Recognition. |
| S4-143-ROLE-NOT-GENERAL-SOVEREIGNTY | REQUIRED | No representation or helper provides out-of-scope office powers beyond accepted v0 role scope. |
| S4-144-LOCALITY | REQUIRED | Adding disconnected actors/Households/roles does not alter local appointment, succession, provision, mediated-marriage, or authority-race results. |
| S4-145-OBSERVER-NONINTERFERENCE | REQUIRED | Role/head/Household readers, diagnostics, oracle inspection, and trace access do not alter behavior, IDs, ordering, evidence, or semantic history. |
| S4-146-DERIVED-CACHE-NONAUTHORITY | REQUIRED | Current-head/action-availability/capacity/role-recognition indexes or caches are rebuildable/non-authoritative and cannot change behavior when stale/discarded. |
| S4-147-DERIVED-REBUILD-EQUIVALENCE | REQUIRED | Discard/rebuild of permitted derived role/authority/capacity projections at stable boundary reproduces identical authoritative queries/outcomes. |
| S4-148-NONSEMANTIC-ITERATION-METAMORPHIC | REQUIRED | Representative appointment/succession/dual-mode/provision histories are invariant under nonsemantic storage/input enumeration changes except explicitly accepted fallback domains. |
| S4-149-ISOMORPHIC-ID-RENAMING | REQUIRED | Consistent nonsemantic ID renaming preserves role/Recognition/material outcomes modulo isomorphism except in scenarios deliberately exercising an accepted disclosed stable-ID fallback domain. In such a fallback domain, only the accepted fallback-sensitive assignment may change; legitimacy, authority, total material effect, invariants, and fallback disclosure remain unchanged. |
| S4-150-STRUCTURAL-AUTHORITY-EXPLICIT | REQUIRED | New role/occupancy/cooldown/commitment authority is explicit, typed, inspectable, and not hidden in derived/cache/diagnostic state. |
| S4-151-FIXTURE-WRITE-SET-AUDIT | REQUIRED | Every Slice-4 witness declares fixture/producer writes; fixtures never direct-write the role/Recognition/commitment/spend/marriage result under judgment. |
| S4-152-INDEPENDENT-ORACLE-DEPENDENCY | REQUIRED | Acceptance checkers do not call production role/appointment/Recognition/provision/spend/mediated classifiers as expected-answer oracles when those outputs are under judgment. |
| S4-153-INDEPENDENT-ORACLE-ADEQUACY-CORRUPTIONS | REQUIRED | Detached/public-boundary corruptions for role identity, H-role link, nomination/acceptances, participant set, EvidenceIds, debit vectors, mediated effects and fallback are rejected by the actual independent checker. |
| S4-154-VERIFIED-PRODUCER-PROVENANCE | REQUIRED | Reused produced H/role/commitment checkpoints carry producer identity, pass state, fixture audit, rule/config version, and output identity. |
| S4-155-TRACE-CONFIGURATION-TRUTH | REQUIRED | Personal, response, Household, role, provision and mediated traces identify the actual rule set exercised independently of arbitrary scenario-label spelling. |
| S4-156-STABLE-CLOSURE | REQUIRED | Role/Recognition/material automatic consequences close before completed-cycle publication; no same-cycle voluntary reactivation or safe checkpoint appears mid-closure. |
| S4-157-CAUSE-IDEMPOTENCE | REQUIRED | Role/vacancy/Recognition/provision automatic consequences are cause-keyed/idempotent; one cause key cannot apply the same transition twice. |
| S4-158-REACTIONINDEX-MONOTONE | REQUIRED | ReactionIndex remains monotone across consequential Slice-4 reaction chains without creating social priority among unrelated causes. |
| S4-159-FALLBACK-QUARANTINE | REQUIRED | Technical fallback is confined to accepted unresolved technical symmetry and cannot decide appointment legitimacy, unanimity, current authority, Recognition, role identity, or DEC-0010 precedence. |
| S4-160-MATERIAL-INVARIANTS | REQUIRED | Collective material effects preserve nonnegative personal grain, reserve/NeedsGrain rules, exact zero-sum debit/credit accounting, no double debit, marriage/favour cardinality and atomicity. |
| S4-161-RESPONSE-AUTONOMY | REQUIRED | Role-scoped and provision responses remain target policy decisions; initiator/head scoring cannot silently choose another actor's response and responses consume no personal initiative. |
| S4-162-PERSON-LEVEL-SEMANTICS-REGRESSION | REQUIRED | Ordinary gifts/loans/favours/residence/direct-marriage/communication remain person-level semantics even when actor is head. |
| S4-163-FROZEN-AUTHORITY-INTEGRITY | REQUIRED | Frozen Slice-1/2/3 manifest refs/blobs/statuses remain immutable; completion reports every prior REQUIRED AcceptanceId individually green. |
| S4-164-ROLE-CAUSAL-INTERVENTION | REQUIRED | Removing one critical authority/Recognition/provision cause while holding irrelevant facts fixed removes/changes the claimed candidate/result; irrelevant perturbation preserves it. |
| S4-165-DECISION-SCORING-FALLBACK-VS-RESOLUTION-FALLBACK | REQUIRED | Acceptance evidence separately audits scorer-tie fallback and central-resolution fallback so one does not masquerade as the other. |

### H. Lossless inherited verification adaptations required before coding

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-170-S3-014-HEADLESS-BOUNDARY-ADAPTATION | REQUIRED | Losslessly adapt the inherited S3-014 executable witness from literal HeadRole/HouseholdDecisionContext type absence to its frozen semantic claim: Slice-3 formation itself installed no occupied head or Household initiative. Do not weaken or edit the frozen S3 manifest. |
| S4-171-S3-093-STRUCTURAL-AUTHORITY-ADAPTATION | REQUIRED | If Slice-4 authoritative role state changes a previously exact private-field inventory, perform separate reviewed lossless adaptation preserving 'no hidden behavior-affecting derived authority'; do not delete/loosen S3-093/S1-084. |
| S4-172-S3-ORACLE-MATERIAL-EVENT-ADAPTATION | REQUIRED | Adapt any Slice-3 oracle assumption that all Household events are non-material so it remains valid for the historical Slice-3 boundary while permitting accepted Slice-4 Household material events; no camouflage by renaming. |
| S4-173-S3-COMMITMENT-PROVENANCE-ADAPTATION | REQUIRED | Adapt Slice-3 fixture-only commitment provenance checks losslessly so frozen Slice-3 fixture claims remain provable while Slice 4 adds endogenous accepted commitment acquisition. |
| S4-174-ADAPTATION-REVIEW-BEFORE-IMPLEMENTATION | REQUIRED | All triggered inherited structural/literal-witness adaptations are independently reviewed and recorded before the implementation task may alter those surfaces. |
| S4-175-NO-FROZEN-MANIFEST-RECLASSIFICATION | REQUIRED | Later-slice capability is added by new Slice-4 rows; frozen Slice-3 REQUIRED/DEFERRED/UNEXERCISED statuses are never rewritten. |

### I. Exact inherited regression bundles

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-R00-ALL-PRIOR-REQUIRED | REQUIRED | Every frozen REQUIRED AcceptanceId from Slices 1–3 is executed/reported individually green against immutable prior manifest identity; exact member set appears in Appendix A. |
| S4-R01-HOUSEHOLD-IDENTITY-CONTINUITY | REQUIRED | High-risk Slice-3 participation/continuity/lifecycle obligations remain green; role occupancy never redefines H identity. |
| S4-R02-OBJECTIVE-SUBJECTIVE-SEPARATION | REQUIRED | Inherited Slice-2/Slice-3 objective-vs-subjective, Recognition distinctness, no-passive-sync and no-history-omniscience obligations remain green. |
| S4-R03-COMMUNICATION-PROVENANCE-STALENESS | REQUIRED | Inherited communication held-content/provenance, initiative cost, staleness, event-order, message-arrival and Contested obligations remain green. |
| S4-R04-INITIATIVE-RESPONSE-ACCOUNTING | REQUIRED | Inherited one-personal-initiative and response-accounting obligations remain green while Slice 4 adds one separate H initiative. |
| S4-R05-LOCALITY-OBSERVER | REQUIRED | Inherited locality and observer noninterference remain green with role/head/provision readers added. |
| S4-R06-FALLBACK-ID-QUARANTINE | REQUIRED | Inherited fallback quarantine and ID-renaming/permutation obligations remain green; office validity never becomes a technical tie domain. |
| S4-R07-CACHE-DERIVED-NONAUTHORITY | REQUIRED | Inherited cache/derived nonauthority and rebuildability remain green with current-head/role/capacity projections. |
| S4-R08-STABLE-CLOSURE | REQUIRED | Inherited reaction closure/idempotence/no-mid-cycle-publication obligations remain green. |
| S4-R09-PROVISION-SUBSTRATE | REQUIRED | Slice-3 person-backed commitment/capacity/no-treasury/termination semantics remain green while Slice 4 adds acquisition and spend. |
| S4-R10-PERSON-LEVEL-SEMANTICS | REQUIRED | Inherited lower-level meanings/responses/residence/direct marriage remain green and independent of office. |
| S4-R11-TRACE-CONFIGURATION | REQUIRED | Inherited trace/configuration truth remains green across mixed S1/S2/S3/S4 actions in one run. |
| S4-R12-FIXTURE-ORACLE-INTEGRITY | REQUIRED | Inherited fixture write-set and independent-oracle guarantees remain green; Slice-4 checkers add rather than weaken them. |
| S4-R13-HOUSEHOLD-RECOGNITION | REQUIRED | Inherited Household Recognition acquisition, staleness, Contested gating and no passive broadcast remain green alongside new head Recognition. |
| S4-R14-LINEAGE-NONAUTHORITY | REQUIRED | Controlled lineage remains behaviorally inert and does not transfer office, role Recognition, provision authority or occupant state. |

### J. Deliberate deferrals

| AcceptanceId | Status | Obligation |
|---|---|---|
| S4-D01-CHECKPOINT-RESTORE | DEFERRED | Exact save/load continuation and omission-state recovery remain Slice 5. |
| S4-D02-ACTOR-DEPARTURE | DEFERRED | World-level actor departure remains LATER-02; participation end is not actor departure. |
| S4-D03-CANDIDATE-CONVERGENCE | DEFERRED | General CandidateOrganization multi-referent convergence remains LATER-01. |
| S4-D04-REPEATED-PREDECESSOR-LINEAGE | DEFERRED | Repeated predecessor rejoin/re-exit lineage source selection remains LATER-03. |
| S4-D05-CONTESTED-SUCCESSION-MULTIPLE-CLAIMANTS | DEFERRED | General simultaneous claimants/usurpation/contested succession remain explicit v0 exclusions. |
| S4-D06-RESIGN-WHILE-REMAINING-PARTICIPANT | DEFERRED | No separate resignation action is accepted in v0; do not invent one. |
| S4-D07-GENERIC-NONPARTICIPANT-PERCEPTION | DEFERRED | Generic perception/observer entitlement beyond accepted participation/communication routes remains outside v0. |
| S4-D08-GENERAL-INSTITUTIONAL-SOVEREIGNTY | DEFERRED | General Household/office sovereignty, administration and command remain outside bounded v0. |
| S4-D09-TRUST-RUMOR-REPUTATION | DEFERRED | Trust/reliability/lying/rumor/reputation remain outside v0. |
| S4-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED | General generated-history/shrinking infrastructure remains non-gating; if activated as completion evidence, fire VH-02 first. |
| S4-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED | Rendered human explanation UI remains future; machine-readable causal history/explainability is required. |

## 6. Exact inherited frozen REQUIRED expansion

Slice-4 completion must execute/report every prior frozen REQUIRED ID individually green. This appendix mechanically enumerates the exact expected member set from the immutable prior manifests. It does not modify prior statuses.

**Prior frozen REQUIRED total:** 270 = 128 Slice 1 + 46 Slice 2 + 96 Slice 3.

### Slice 1 — 128 REQUIRED

`S1-090-A`; `S1-090-B`; `S1-090-C`; `S1-090-D`; `S1-090-E`; `S1-091-GIFT`; `S1-091-HELP`; `S1-091-LOAN-OFFER`; `S1-091-LOAN-REQUEST`; `S1-091-BFF-POS`; `S1-091-RMRH`; `S1-091-MEANING-SEPARATION`; `S1-092-PARTIAL`; `S1-092-AMOUNT-VALIDITY`; `S1-092-RESERVE`; `S1-092-FULL`; `S1-092-DUE`; `S1-093-BFF-POS`; `S1-093-RECIP-74`; `S1-093-RECIP-75`; `S1-093-RECIP-76`; `S1-093-KIN-GATE`; `S1-093-GIFT-CONTROL`; `S1-093-BFF-FULL`; `S1-093-BFF-RACE`; `S1-093-RMRH-FULL`; `S1-094-FARM-CALLABLE`; `S1-094-REPAY-CALLABLE`; `S1-094-PERSONAL-COEXIST`; `S1-094-NONCALLABLE-MATRIX`; `S1-094-NONPAYLOAD-MATRIX`; `S1-094-UNABLE`; `S1-094-DECLINE`; `S1-094-INVALIDATED`; `S1-094-SUCCESS`; `S1-094-NESTED-GUARD`; `S1-094-RECIP-CANCEL`; `S1-095-POS`; `S1-095-74`; `S1-095-KIN`; `S1-095-LIFETIME`; `S1-095-NO-RESIDENCE`; `S1-096-MOVE`; `S1-096-INVITE`; `S1-096-COMPETE`; `S1-096-NO-HH`; `S1-096-MARRIAGE-CONTROL`; `S1-097-EVENTS`; `S1-097-SAT`; `S1-097-DIRECT-BATCH-POS`; `S1-097-DIRECT-BATCH-NEG`; `S1-097-DECAY`; `S1-098-CORE`; `S1-098-CALLFAVOR-INIT`; `S1-099-KIN`; `S1-099-CORES`; `S1-100`; `S1-101`; `S1-102`; `S1-103-GRAIN`; `S1-103-RESIDENCE`; `S1-105`; `S1-070`; `S1-071`; `S1-073`; `S1-074-IDEMP`; `S1-074-DIRECT-BATCH`; `S1-080`; `S1-081`; `S1-084`; `S1-085`; `S1-086`; `S1-BND-ATT-STRONGLIKE`; `S1-BND-ATT-SAT`; `S1-BND-ATT-MIXED`; `S1-D4-GRAIN-GIFT-OFFER`; `S1-D4-GRAIN-GIFT-REQUEST`; `S1-D4-GRAIN-LOAN-OFFER`; `S1-D4-GRAIN-LOAN-REQUEST`; `S1-D4-GRAIN-REPAY-DIRECT`; `S1-D4-GRAIN-BFF-BENEFIT`; `S1-D4-GRAIN-RMRH-BENEFIT`; `S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT`; `S1-D4-GRAIN-CALLFAVOR-REPAY-INNER`; `S1-BND-REPAY-AMOUNT`; `S1-BND-RESERVE`; `S1-BND-NEED`; `S1-BND-DECAY`; `S1-BND-DEBT-DUE`; `S1-BND-MARRIAGE-CARD`; `S1-BND-FAVOUR-CARD`; `S1-BND-FAVOUR-MEANING`; `S1-BND-RESIDENCE-CARD`; `S1-META-01`; `S1-META-02`; `S1-META-03`; `S1-META-04`; `S1-META-05`; `S1-META-07`; `S1-META-10`; `S1-META-11`; `S1-MUT-04`; `S1-MUT-13A`; `S1-MUT-16`; `S1-MUT-17`; `S1-MUT-18`; `S1-MUT-19`; `S1-MUT-20`; `S1-MUT-21`; `S1-MUT-22`; `S1-MUT-23`; `S1-MUT-24`; `S1-MUT-26`; `S1-MUT-29`; `S1-MUT-31`; `S1-MUT-32`; `S1-MUT-33`; `S1-MUT-34`; `S1-MUT-35`; `S1-GLOBAL-FIXTURE`; `S1-GLOBAL-KNOWLEDGE`; `S1-GLOBAL-ORACLE`; `S1-GLOBAL-FALLBACK`; `S1-GLOBAL-ITERATION`; `S1-GLOBAL-CALLFAVOR-MAP`; `S1-GLOBAL-REQUIRED-COVERAGE`; `S1-GLOBAL-MANIFEST-INTEGRITY`; `S1-GLOBAL-CONFORMANCE`

### Slice 2 — 46 REQUIRED

`S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION`; `S2-002-KNOWNFACT-RETENTION`; `S2-003-KNOWNFACT-PROVENANCE-CENSUS`; `S2-004-RECOGNITION-DISTINCT`; `S2-005-RECOGNITION-TRISTATE-LIFETIME`; `S2-006-NO-PASSIVE-SYNC`; `S2-007-NO-HISTORY-OMNISCIENCE`; `S2-008-LOCALITY`; `S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE`; `S2-010-OWN-STATE-KNOWLEDGE`; `S2-011-DIRECT-CLAIM-KNOWLEDGE`; `S2-012-DIRECT-PARTICIPATION-KNOWLEDGE`; `S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION`; `S2-020F-FACT-COMMUNICATION-ACTION`; `S2-020R-RECOGNITION-COMMUNICATION-ACTION`; `S2-021F-COMMUNICATE-HELD-FACT`; `S2-021R-COMMUNICATE-HELD-RECOGNITION`; `S2-022F-NO-INVENTED-FACT`; `S2-022R-NO-INVENTED-RECOGNITION`; `S2-023F-FACT-COMMUNICATION-PROVENANCE`; `S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE`; `S2-024F-FACT-COMMUNICATION-INITIATIVE-COST`; `S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST`; `S2-025F-FACT-NO-FREE-BROADCAST`; `S2-025R-RECOGNITION-NO-FREE-BROADCAST`; `S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE`; `S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE`; `S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE`; `S2-030-STALE-FACT-PERSISTS`; `S2-031A-DIRECT-EVIDENCE-PRECEDENCE`; `S2-031B-REPORT-EVENT-PRECEDENCE`; `S2-032-MESSAGE-ARRIVAL-PERMUTATION`; `S2-033-CANDIDATE-RECOGNITION-CONTESTED`; `S2-040F-KNOWNFACT-CANDIDATE-GATE`; `S2-040R-RECOGNITION-CANDIDATE-GATE`; `S2-041-GATES-BEFORE-SCORING`; `S2-042-SUBJECTIVE-TRACE`; `S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION`; `S2-044-OBJECTIVE-REVALIDATION-PRESERVED`; `S2-045-PINNED-POLICY-NONCLAIM`; `S2-050-EPISTEMIC-READ-NONINTERFERENCE`; `S2-051-DETERMINISTIC-REPLAY`; `S2-052-NONSEMANTIC-ITERATION-METAMORPHIC`; `S2-053-ISOMORPHIC-ID-RENAMING`; `S2-054-CACHE-NONAUTHORITY`; `S2-055-CONFIGURATION-PROVENANCE`

### Slice 3 — 96 REQUIRED

`S3-001-FORMATION-POSITIVE`; `S3-002-FOUNDING-CARDINALITY`; `S3-003-FORMATION-RESIDENCE-ABLATION`; `S3-004-FORMATION-DURABLE-TIE-ABLATION`; `S3-005-FORMATION-SUPPORT-COUNT-ORDER`; `S3-006-FORMATION-RECOGNITION-ABLATION`; `S3-007-CANDIDATE-NONAUTHORITY`; `S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS`; `S3-009-NO-HIDDEN-MEMBERS-AUTHORITY`; `S3-010-FORMATION-WARRANT-PROVENANCE`; `S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME`; `S3-012-FOUNDING-PARTICIPATION-PROVENANCE`; `S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H`; `S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY`; `S3-015-QUALIFYING-SUPPORT-KIND-CENSUS`; `S3-020-PARTICIPATION-ENTRY-POSITIVE`; `S3-021-PARTICIPATION-RECOGNITION-ABLATION`; `S3-022-PARTICIPATION-BRIDGE-ABLATION`; `S3-023-PARTICIPATION-BILATERAL-ABLATION`; `S3-024-PARTICIPATION-RESIDENCE-ABLATION`; `S3-025-PARTICIPATION-DURABLE-TIE-ABLATION`; `S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION`; `S3-027-PARTICIPATION-END-WARRANT`; `S3-028-PARTICIPATION-END-NONERASURE`; `S3-029-RESIDENCE-NOT-PARTICIPATION`; `S3-030-EXIT-SIDE-CONTINUATION`; `S3-031-COMPLETE-FOUNDER-TURNOVER`; `S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT`; `S3-033-INACTIVE-STATE`; `S3-034-INACTIVE-REACTIVATION`; `S3-035-SAME-CYCLE-BRIDGE-HANDOFF`; `S3-036-DISSOLUTION-STABLE-CLOSURE`; `S3-037-DISSOLVED-NO-RESURRECTION`; `S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION`; `S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP`; `S3-040-HOUSEHOLD-RECOGNITION-DISTINCT`; `S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION`; `S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE`; `S3-043-H-RECOGNITION-STALE-RETENTION`; `S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE`; `S3-045-DISSOLUTION-RECOGNITION-ROUTE`; `S3-046-H-RECOGNITION-NO-ID-WINNER`; `S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE`; `S3-048-H-RECOGNITION-CONTESTED`; `S3-049-H-RECOGNITION-CONTESTED-GATE`; `S3-050-DIVISION-DESCENDANT`; `S3-051-DIVISION-FRESHNESS-ABLATION`; `S3-052-DIVISION-PREDECESSOR-CONTINUITY`; `S3-053-CONSOLIDATION-DESCENDANT`; `S3-054-CONSOLIDATION-SURVIVOR-ABLATION`; `S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION`; `S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT`; `S3-057-LINEAGE-SOURCE-PROVENANCE`; `S3-058-LINEAGE-ZERO-OR-ONE`; `S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS`; `S3-060-LINEAGE-NONAUTHORITY`; `S3-061-DERIVEDFROM-REBUILD`; `S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY`; `S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC`; `S3-064-LINEAGE-PERSISTENCE-HISTORY`; `S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION`; `S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION`; `S3-070-PROVISION-COMMITMENT-BACKING-STATE`; `S3-071-PROVISION-EXPOSED-CAPACITY`; `S3-072-PROVISION-NEEDSGRAIN-ZERO`; `S3-073-NO-POOLED-HOUSEHOLD-TREASURY`; `S3-074-MOBILIZABLE-CAPACITY-DERIVED`; `S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT`; `S3-076-DISSOLUTION-TERMINATES-COMMITMENTS`; `S3-077-NO-SPENDING-AUTHORITY`; `S3-080-FORMATION-REACTION-CHAIN`; `S3-081-CAUSE-IDEMPOTENCE`; `S3-082-REACTIONINDEX-MONOTONE`; `S3-083-DERIVED-REFRESH-CLOSURE`; `S3-084-NO-MID-CLOSURE-PUBLICATION`; `S3-085-NONSEMANTIC-ITERATION-METAMORPHIC`; `S3-086-ISOMORPHIC-ID-RENAMING`; `S3-087-LOCALITY`; `S3-088-OBSERVER-NONINTERFERENCE`; `S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE`; `S3-090-FALLBACK-QUARANTINE`; `S3-091-VERIFIED-PRODUCER-PROVENANCE`; `S3-092-TRACE-CONFIGURATION-TRUTH`; `S3-093-STRUCTURAL-AUTHORITY-NONHIDING`; `S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION`; `S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION`; `S3-R02-COMMUNICATION-PROVENANCE-STALENESS`; `S3-R03-INITIATIVE-RESPONSE-ACCOUNTING`; `S3-R04-OBSERVER-NONINTERFERENCE`; `S3-R05-LOCALITY`; `S3-R06-FALLBACK-ID-QUARANTINE`; `S3-R07-CACHE-DERIVED-NONAUTHORITY`; `S3-R08-STABLE-CLOSURE`; `S3-R09-PERSON-LEVEL-SEMANTICS`; `S3-R10-TRACE-CONFIGURATION`; `S3-R11-FROZEN-AUTHORITY-INTEGRITY`

## 7. Inherited verification adaptation gate

Slice 4 necessarily introduces accepted later-slice types/state/material effects that can falsify **literal implementation-era assertions** used to prove narrower Slice-3 boundaries.

Before implementation mutates any affected surface:

1. identify every literal witness whose source-level form becomes false while its semantic invariant remains required;
2. author a lossless adaptation mapping old literal assertion -> preserved semantic invariant -> new executable witness;
3. obtain independent review of the adaptation;
4. do not modify frozen Slice-1/2/3 manifest content/ref/status;
5. do not hide authority outside typed state or rename events/types merely to keep an obsolete literal test green.

Known minimum adaptation set is S4-170..175.

If another inherited literal witness fires during coding, stop and route it through the same adaptation process before changing production.

## 8. Completion evidence contract

For every REQUIRED Slice-4 row report:

- AcceptanceId;
- executable test/audit/report reference;
- PASS/FAIL/SKIP state;
- candidate/frozen manifest version + blob/ref;
- relevant configuration/rule version;
- producer/fixture identity where state is reused.

No REQUIRED row may be skipped or collapsed behind an aggregate suite result.

Fresh independent post-implementation conformance must review an exact immutable implementation candidate and must include reviewer-owned public-boundary corruptions/metamorphics. Generated PASS tables alone are corroboration, not proof.

## 9. Frozen census

Frozen census: **161 unique AcceptanceIds = 150 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.

Inherited frozen REQUIRED obligations additionally preserved one-by-one: **270 = 128 Slice 1 + 46 Slice 2 + 96 Slice 3**.

The external freeze record pins:

- exact reviewed candidate commit/blob;
- exact frozen manifest commit/blob;
- immutable version/ref;
- independent pre-code review verdict;
- census and inherited set identities.

## 10. Frozen implementation handoff rule

This manifest is **frozen Slice-4 acceptance authority**.

Implementation remains blocked until the inherited verification adaptation gate in §7 is independently approved and closed.

After adaptation closure:

1. issue the bounded Slice-4 implementation packet citing the immutable frozen ref/blob;
2. implementation agents may not edit, weaken, delete, reclassify, or replace this manifest;
3. complete evidence must report every REQUIRED Slice-4 row and all 270 inherited frozen REQUIRED rows individually;
4. freeze an exact implementation candidate and run fresh independent post-implementation conformance before promotion.

If implementation later requires inventing a consequential result not uniquely determined by accepted authority, stop and escalate rather than changing this manifest or guessing in code.

Any later operative change to Slice-4 acceptance authority requires a separately reviewed new manifest version/ref; do not move the frozen ref.
