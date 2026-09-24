# SFL v0 Slice 4 — Authority Boundary and Deferred-Gap Inventory

**Status:** SOURCE-GROUNDED DISCOVERY RETURN / ADVISORY ONLY  
**Task:** `tasks/research/SFL_V0_SLICE4_DISCOVERY_A_AUTHORITY_GAPS.md`  
**Return branch:** `research/slice4-authority-gap-return`  
**Canonical base SHA used:** `a7a9bbcdc86d4684762efd203b20225b64b001b7`  
**Base commit message:** `Close Slice-3 learning pause and open Slice-4 discovery`  
**Authority boundary:** This report does not promote or modify simulation semantics.

## 1. Executive conclusion

Slice 4 has a sharply bounded accepted semantic core, but it is **BLOCKED PENDING ONE DIRECTOR-LEVEL SEMANTIC DECISION** before acceptance authority may be frozen and implementation dispatched.

Accepted authority already determines the office model itself:

- every Household H has one persistent `HouseholdHeadRole(H)`;
- the role may be vacant or occupied by exactly one person;
- a new Household begins headless;
- only current `SustainingParticipant`s may nominate or be nominated;
- appointment/succession requires nominee acceptance plus unanimous acceptance/recognition by the current sustaining participants;
- succession changes the holder without changing Household identity or role identity;
- head authority is strictly scoped;
- head occupancy, actor Recognition, and material backing/capacity remain separate facts;
- occupied Active H gets one separate `HouseholdDecisionContext(H, head=P)` while P retains one personal initiative;
- vacancy and Inactive state suspend household-mode action without erasing H;
- outsiders do not passively synchronize to a new head;
- stale predecessor Recognition persists until displaced or contested through an accepted evidence route;
- provision solicitation/reconsideration, household support, and mediated-marriage handling are head-scoped Slice-4 actions;
- every accepted action is revalidated immediately before commit against current action-relevant preconditions.

The remaining blocker is the fired `LATER-04` race.

The specification says what happens **if** authority/eligibility/backing has already been lost when a proposal reaches precommit revalidation: the dependent action cannot commit and may terminate as `InvalidatedAtResolution`. It also defines several real semantic priorities and a technical fallback for genuinely unresolved equal-priority symmetry.

It does **not** determine the ordering when, from the same committed decision snapshot, both of the following are already accepted and otherwise valid:

1. a transition that destroys the head/participant/status/authority precondition; and
2. an action whose commit still depends on that precondition.

For the canonical shape, if the authority-dependent action commits first, both effects may be able to commit; if the destructive transition commits first, the dependent action is invalidated. This is not merely a symmetric winner-selection problem. Ordering changes causal reachability and therefore changes authoritative history. The accepted stable-ID fallback cannot be silently promoted into an authority-precedence rule.

`LATER-05`, by contrast, is now closed by accepted semantics. The mediated-marriage route is sufficiently specified for bounded Slice-4 implementation: groom initiates; the route is gated by the bride's current participation fact and the groom's H/head Recognition; the current head receives/resolves the mediated proposal; **head acceptance is sufficient**; dowry funding and groom-to-head favour are commit effects; and the female-head self-mediation companion is explicitly accepted. No additional bride-response or nested voluntary response is required by the accepted mediated route.

## 2. Source corpus retrieved

This analysis used the exact repository state at the canonical base SHA above and independently retrieved the task-required corpus:

1. `AGENTS.md`;
2. `00_START_HERE.md`;
3. `plans/CURRENT_PHASE.md`, as required by the root agent instructions;
4. accepted `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
5. all accepted ADRs current at the base:
   - `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`;
   - `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`;
   - `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`;
   - `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`;
   - `architecture/accepted/ADR-0005_HOST_RUNTIME.md`;
6. `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
7. `plans/verification/SFL_V0/HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`;
8. `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md`;
9. `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`;
10. `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`;
11. `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`;
12. `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`;
13. `registers/ASSUMPTIONS_REGISTER.md`;
14. `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`;
15. frozen Slice-1/2/3 acceptance manifests and freeze records;
16. Slice-1/2/3 final completion/promotion records;
17. `research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md`;
18. `research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md`.

Additional controlling verification material was retrieved where needed, especially `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md` for the accepted role-scoped mediated-marriage response shape.

The TRES-0010 Wave-A second-pass audit, Wave-B adjudication, and B2 synthesis were consulted only to recover why `LATER-04` / `LATER-05` were durably deferred. They are research/tracking evidence, not simulation authority.

`research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` was used only as the instructed question/distinction lens. It has no authority here.

## 3. Controlling authority anchors

Several accepted rules control almost the entire Slice-4 boundary.

### 3.1 Persistent identity is not current-holder identity

ADR-0001 requires independently identified typed records and forbids deriving stable semantic identity from mutable content such as current participants/holders.

Therefore:

- Household H identity is not head-holder identity;
- `HouseholdHeadRole(H)` identity is not holder identity;
- holder turnover cannot create a new H or a new role merely because P changes;
- vacancy is a state of the persistent role, not destruction of the role.

### 3.2 Proposals are not effects until central commit

ADR-0004 and SPEC §9 establish the deterministic reference-kernel flow:

`read/activate -> deliberate/propose -> respond -> resolve/revalidate -> commit/failure -> automatic reactions -> stable closure`.

Personal and role contexts read the common committed snapshot. Accepted responses do not guarantee commit. Intermediate authoritative commits are immediately available to central revalidation and causal reactions even though a completed cycle is not published until reaction closure.

### 3.3 Recognition is actor-relative, not engine truth

SPEC §6 makes `Recognition` provenance-bearing and actor-specific.

Objective facts and subjective interpretation remain separate:

- H may objectively exist while X does not recognize H;
- P may objectively occupy the role while X still recognizes predecessor A;
- X may hold incompatible authority evidence and be `Contested`;
- negative attitude or refusal does not erase valid Recognition;
- objective succession does not broadcast a new recognition state to outsiders.

### 3.4 Head authority is scoped

SPEC §8.4 permits the role to:

- request provision commitment/reconsideration;
- authorize the two permitted Household material uses;
- receive/resolve Household-mediated marriage proposals;
- participate in succession.

It does not permit:

- seizure of personal grain;
- commands over residence or ordinary personal action;
- arbitrary creation of kinship, debt, or favour;
- direct attitude modification;
- generic sovereignty or generic spending.

### 3.5 Capability is grounded separately from authority

Provision commitments leave grain personal. Mobilizable capacity is derived from currently valid commitments and current personal grain/need state.

An occupied role does not create material backing. Material backing does not create head authority. H existence does not create either.

### 3.6 Revalidation is mandatory, but precedence is not thereby invented

SPEC §9.2 requires every proposal to be revalidated immediately before commit against all action-relevant preconditions, including:

- participant/status eligibility;
- relations/claims;
- Household/head validity;
- provision/capacity;
- grain;
- cooldown state.

That rule determines validity at the moment of attempted commit. It does not, by itself, choose the semantic order of two accepted same-snapshot effects when one effect destroys the other's precondition.

## 4. Slice-4 semantic census

| Semantic item | Classification | Slice-4 consequence |
|---|---|---|
| Persistent `HouseholdHeadRole(H)` | **REQUIRED in Slice 4** | Every H has one stable role identity independent of the holder. |
| Initial vacancy | **REQUIRED in Slice 4** | New H begins headless; no auto-election by age/sex/ID/grain/kinship/fixture order. Existing Slice-3 H state must acquire/represent the accepted persistent vacant role without inventing a holder. |
| Nomination eligibility | **REQUIRED in Slice 4** | Only a current `SustainingParticipant` may nominate, and only a current `SustainingParticipant` may be nominated. |
| Nominee acceptance | **REQUIRED in Slice 4** | No appointment/succession without the nominee's acceptance. |
| Unanimity of current sustaining participants | **REQUIRED in Slice 4** | Every current sustaining participant must accept/recognize the appointment/succession; no majority or stable-ID legitimacy fallback. |
| Initial appointment | **REQUIRED in Slice 4** | Valid nomination + nominee consent + unanimity fills the same persistent role. |
| Vacancy | **REQUIRED in Slice 4** | Head departure through accepted participation end vacates the role; vacancy preserves H and other valid backing but disables household-mode action. |
| Succession under same role identity | **REQUIRED in Slice 4** | Occupant A -> B changes under the same H and same role identity. |
| Head-role Recognition | **REQUIRED in Slice 4** | Objective occupancy and actor Recognition are distinct. Appointment/succession participants directly recognize the resulting role state. |
| Stale predecessor Recognition | **REQUIRED in Slice 4** | An outsider without accepted newer evidence may continue to recognize A after objective A -> B succession. |
| Accepted correction route | **REQUIRED in Slice 4** | Newer direct participation/observation where accepted, or provenance-bearing communication, may displace older evidence. No passive global synchronization. |
| Scope of head authority | **REQUIRED in Slice 4** | Only accepted provision, support/dowry, mediated-marriage, and succession scopes. |
| Scoped authority prohibitions | **REQUIRED in Slice 4** | No generic sovereignty, confiscation, residence command, ordinary personal command, relation creation, or attitude write. |
| Provision solicitation/reconsideration | **REQUIRED in Slice 4** | The accepted endogenous route is head-scoped; cooldown/context-change rule applies after refusal. |
| Household support | **REQUIRED in Slice 4** | Active H + valid occupied head + in-scope authority + current backing; 1-grain support only to eligible needy sustaining participant. |
| Mediated-marriage authority | **REQUIRED in Slice 4** | Groom route through current recognized head; head acceptance sufficient; dowry/favour effects remain centrally revalidated. |
| `HouseholdDecisionContext(H, head=P)` | **REQUIRED in Slice 4** | Occupied role activates one separate Household deliberation context. |
| Separate personal vs Household initiative | **REQUIRED in Slice 4** | P keeps one personal initiative; H gets one separate Household initiative through P; scoring/concerns remain distinct. |
| Active/vacant/Inactive gating | **REQUIRED in Slice 4** | Household collective action requires Active H and occupied valid role; vacant or Inactive H has no Household initiative. |
| Central revalidation | **Inherited cross-cutting semantics + REQUIRED Slice-4 integration** | Head/status/eligibility/Recognition/capacity gates must be rechecked at precommit. |
| Authority-dependent invalidation | **Inherited cross-cutting semantics + REQUIRED Slice-4 integration** | An accepted action whose action-relevant authority/precondition is already gone at its precommit point cannot commit and is not retroactively a voluntary refusal. |
| Household identity/participation/continuity/lifecycle | **Inherited/regression only** | Slice 3 remains authoritative substrate; Slice 4 must not redefine H or membership. |
| Household provision commitment/capacity substrate | **Inherited/regression + Slice-4 consumption** | Slice 4 now uses the already-grounded backing state for real expenditure. |
| General subjective information/communication rules | **Inherited/regression only** | Slice 4 instantiates head propositions but does not create a new epistemology. |
| Exact checkpoint/restore of role/head state | **Deferred to Slice 5** | §9.6 already says future-influencing role/head state belongs in a checkpoint, but executable exact continuation remains Slice 5. |
| Rendered causal explanation UI | **Accepted verification direction but may remain unexercised** | Machine-readable causal/provenance history remains required; a separate rendered explanation surface is not intrinsically needed for Slice 4. |
| General nonparticipant perception model | **Not required / do not invent** | Bounded head-recognition correction can use accepted direct participation and communication routes. |
| Same-cycle authority/precondition-destroying precedence | **BLOCKED BY LATER-04** | Requires one consequential semantic precedence decision before Slice-4 acceptance freeze. |

## 5. Office / holder / authority / Recognition / capability boundary

The following facts are semantically distinct and must remain independently representable.

### 5.1 H exists

This is Household identity/continuity state established by Slice 3. It survives head vacancy and holder turnover.

### 5.2 Role R exists

Each H has one persistent `HouseholdHeadRole`. Its identity survives vacancy and succession.

### 5.3 P occupies R

Occupancy is an objective current-world fact. It can change A -> B without changing H or R.

### 5.4 P has accepted authority in scope S

Occupancy is necessary but not a universal power bit.

For Household-mode action the accepted effective authority gate also depends on the relevant scope and Household operational state. An occupied role in an Inactive H does not create a Household initiative.

### 5.5 Actor X recognizes P as current holder in scope

This is X's subjective evidence-backed Recognition proposition, not an engine-global copy of occupancy.

X can:

- recognize the current holder;
- be Unknown;
- be Contested;
- still hold stale predecessor evidence.

### 5.6 X may recognize predecessor A after objective succession to B

Accepted stale information persists until an accepted newer basis displaces or contests it. Objective succession alone does not rewrite X.

### 5.7 H has current material backing/capacity

This is derived from current valid personal commitments and current personal grain/need state. It is neither head authority nor Household-owned grain.

### 5.8 Collapse hazards

Implementation wording that should be treated as dangerous shorthand rather than one state variable includes:

- `CurrentHead` used simultaneously as objective holder, recognized holder, and authorized channel;
- `HasHead = true` used as a substitute for role existence + occupancy + scope + lifecycle eligibility;
- `RecognizedHead` stored globally on H rather than actor-relative;
- `HouseholdCanSpend` used to collapse Active status, valid head, in-scope authority, provision commitments, and current capacity;
- `HeadChanged` used to overwrite every actor's Recognition;
- using role holder ID as role identity;
- using available provision capacity as proof of authority;
- using head occupancy as proof that the holder knows all Household events.

The accepted Slice-4 office is therefore not one boolean and not one engine-global `head` fact.

## 6. Appointment / succession / vacancy boundary

### 6.1 Initial appointment into a vacant role

Accepted sequence:

1. H already exists and is headless.
2. A current sustaining participant nominates a current sustaining participant N.
3. N accepts.
4. every current sustaining participant accepts/recognizes N's appointment.
5. central resolution revalidates all action-relevant current preconditions.
6. appointment commits into the existing persistent role.

No majority, automatic seniority, sex rule, grain rule, fixture order, or stable-ID tie break can substitute for unanimity.

### 6.2 Succession before the outgoing head vacates

An outgoing head may nominate a successor before vacating.

Valid succession requires the same nominee consent and unanimous current-participant acceptance/recognition. On commit:

- H ID is unchanged;
- role ID is unchanged;
- occupant changes A -> B;
- the succession event records the turnover;
- direct participants recognize the resulting B-held role state.

No intermediate new role identity is created.

### 6.3 Head exit without a valid successor

The accepted executable exit path already specified is `EndHouseholdParticipation(H)`.

If the current head ends participation:

- that person's sustaining association ends;
- that person's provision commitment, if any, terminates;
- the head role becomes vacant;
- H identity is not destroyed merely by the vacancy;
- remaining valid provision commitments are not destroyed merely by the vacancy;
- lifecycle/continuity is reevaluated from the remaining sustaining organization;
- Household-mode initiative/spending/marriage mediation is suspended while vacant.

A separate voluntary “resign office but remain sustaining participant” action is not specified by accepted v0 semantics and must not be invented merely for implementation convenience. Slice 4 does not need such an action to implement the accepted appointment/succession/vacancy path.

### 6.4 Eligibility at precommit

The nomination and appointment/succession rules refer to **current** sustaining participants.

Combined with §9.2, current nominee/nominator/participant eligibility is an action-relevant precondition at precommit.

What is not yet fixed is the semantic order when a same-cycle accepted participation/status transition is itself the event that would remove that eligibility. That is part of fired `LATER-04`.

### 6.5 Direct Recognition acquisition

Appointment/succession participants directly recognize the resulting head-role state through participation in the role event.

This does not imply:

- every current participant observes every later role event automatically;
- every co-resident knows the current head;
- every outsider updates.

The Slice-3 lesson remains controlling as a risk: institutional status is not information entitlement.

### 6.6 Outsider correction

Outsiders update only through accepted evidence routes.

For a bounded Slice-4 witness, the safe already-accepted route is:

`succession/vacancy event -> direct participant/witness evidence -> provenance-bearing CommunicateClaim/Inform -> recipient Recognition update`.

A generic nonparticipant perception model is not needed and must not be invented to make the test convenient.

## 7. LATER-04 — same-cycle authority/precondition races

**Trigger status:** **FIRED NOW.**  
**Disposition:** **UNRESOLVED CONSEQUENTIAL SEMANTIC PRECEDENCE.**

### 7.1 What §9.2 already fixes

No Director decision is needed for the following general rule:

> Immediately before commit, every proposal must still satisfy all action-relevant preconditions.

Therefore, once a relevant earlier authoritative commit has already removed:

- current head validity;
- participant eligibility;
- Active/status eligibility where applicable;
- provision backing/capacity;
- required Recognition;
- marriage eligibility;
- other explicit scope conditions,

the dependent action cannot commit merely because it was selected/accepted earlier from the common decision snapshot.

The resulting failure is central invalidation, not retroactive voluntary refusal.

### 7.2 What accepted semantic priority already fixes

Some races are already ordered by accepted domain semantics:

- eligible `NeedsGrain` Household support precedes other valid Household provision expenditure;
- other valid Household provision expenditure precedes ordinary voluntary personal transfer;
- the narrow continuity handoff rule resolves a valid bridged participation entry and its continuity reaction before the specific bridge participant's accepted exit when that entry explicitly depends on that bridge;
- categorical proposal validity precedes response;
- feasibility precedes voluntary response scoring;
- causal automatic reactions follow their committed cause;
- exogenous inputs and maintenance occur before the common decision snapshot.

Those rules should be applied before considering any fallback or new authority precedence.

### 7.3 What the technical fallback may resolve

After every accepted semantic/domain priority is exhausted, equal-priority **unresolved symmetric alternatives** may use the disclosed stable-semantic-ID technical fallback, with fallback use recorded.

Examples already accepted include genuinely symmetric competing Residence transitions and exact capacity-rank ties.

The fallback is not a social preference and cannot be used to resolve actor Recognition evidence itself. `Contested` Recognition remains Contested when no accepted evidence ordering resolves it.

### 7.4 Why the fired Slice-4 race is not closed by that fallback

The core LATER-04 pattern is asymmetric in causal consequence.

Suppose, from the same committed snapshot:

- A is the valid head;
- H has an accepted authority-dependent Household action Q through A;
- A also has an accepted transition T that will destroy A's relevant authority or eligibility.

If Q commits first, Q may validly commit and T may still commit afterward.

If T commits first, Q fails precommit revalidation.

Thus the alternatives are not simply two contenders for one indivisible outcome. Different ordering changes whether the authoritative history contains one successful effect or two.

Using proposal/event IDs to choose that order would silently create a substantive authority-precedence rule from a technical fallback.

### 7.5 Required race inspection

| Race | Already fixed | Remaining status |
|---|---|---|
| Head exits participation while H has accepted Household action | Exit, once committed, vacates role; later dependent action must fail head-validity revalidation. Action, if committed first, may be valid. | **Missing precedence between accepted exit and accepted dependent action.** |
| Head succession A -> B versus accepted old-head-authorized action | Succession changes occupant under same role; after succession an A-authorized role action no longer has current-head validity. | **Missing precedence between succession and old-head action.** |
| Nominee/current-participant eligibility changes in same cycle | Appointment/succession requires current participant eligibility and unanimity; precommit revalidation is mandatory. | **Missing precedence when the eligibility-destroying transition and appointment/succession are both accepted from the common snapshot.** |
| H is headed toward Inactive/Dissolved while Household action is pending | Lifecycle publication waits for stable closure; underlying committed participation/role/commitment changes are immediately authoritative for revalidation/reactions. Vacant/Inactive/Dissolved H cannot produce the later Household-mode capability described by §8.5. | **Stable-cycle publication does not itself supply conflict precedence. The ordering between accepted status-destroying transitions and the dependent action remains part of LATER-04.** |
| Provision capacity changes before authorized spend | Precommit capacity is recomputed; support > other Household spend > ordinary personal transfer; equal-priority true material symmetry may use logged fallback. | **Pure material competition is largely determined. If capacity disappears because of a separate participation/commitment-destroying transition, the ordering question inherits LATER-04 rather than material-priority rules.** |
| Head Recognition becomes stale/Contested before commit | Objective succession does not passively update outsiders. New accepted evidence may supersede/contest older evidence; authority-dependent action requires safe Recognition; revalidation applies. | **Evidence precedence is fixed where provenance/order dominates. If an independent same-cycle accepted transition/evidence update destroys the recognition gate before commit, revalidation outcome is fixed but the unresolved ordering remains the same LATER-04 shape. No ID fallback may pick a Recognition winner.** |
| Mediated-marriage authority is lost before commit | Head response/acceptance does not bypass final authority/provision/marriage revalidation; invalid current head cannot commit mediated route. | **Missing precedence when authority-loss and already-accepted mediated commit are both same-snapshot accepted effects.** |

### 7.6 Exact Director-level question

The smallest consequential semantic question is:

> **When an already-accepted Slice-4 transition would destroy a head/participant/status/authority precondition required by another already-accepted same-snapshot action, and no existing accepted domain priority orders them, what is the semantic precedence between the destructive transition and the dependent action?**

The decision must determine the bounded Slice-4 outcome class for cases where:

- destructive transition first => dependent action is `InvalidatedAtResolution`; but
- dependent action first => the action may commit and the destructive transition may still commit afterward.

The decision does **not** need to create a general constitutional theory, generalized transaction scheduler, fairness model, or new office doctrine.

It should be expressed narrowly enough to cover the head/vacancy/succession/eligibility/authority cases that Slice 4 necessarily makes executable and to state whether any truly symmetric residue may then use the already-accepted technical fallback.

Until that precedence is accepted, an implementation would have to choose behavior by scheduler/container order, by technical ID, or by an unpromoted policy. All three would exceed implementation authority.

## 8. LATER-05 — mediated-marriage topology

**Trigger status:** **FIRED NOW.**  
**Disposition:** **CLOSED BY ACCEPTED SEMANTICS; NO NEW DIRECTOR DECISION REQUIRED.**

### 8.1 Bride participation fact

The bride must be a female current `SustainingParticipant` of H.

The groom must hold sufficient subjective factual evidence of that current association.

This is a factual/eligibility gate. It is not a separate authority role.

### 8.2 H and head Recognition

The groom must:

- recognize H; and
- recognize the current head in the relevant scope.

Without that subjective route, the mediated candidate is unavailable.

### 8.3 Who receives and resolves the proposal

The accepted role scope says the head may receive/resolve Household-mediated marriage proposals.

The canonical response family further fixes the role-scoped response shape:

- groom submits the mediated proposal through valid head P;
- role/scope validity is checked before response scoring;
- P's role-scoped response context selects Accept/Decline where applicable;
- a response profile cannot manufacture authority for a non-head.

### 8.4 Is a separate bride response required?

No additional bride response is required by the accepted mediated route.

SPEC §4.2 explicitly states:

> head acceptance is sufficient for the mediated route.

That closes the nested-response question for bounded v0.

The bride's participation fact is a route prerequisite; the head's role-scoped response is the accepted mediated authority response. The implementation must not add a second voluntary bride-acceptance context merely because the direct mutual-strong-like route involves the prospective spouse directly.

### 8.5 Dowry funding

If the mediated route proceeds:

- current provision capacity must cover the proposed dowry;
- allocation is recomputed atomically at precommit from currently valid backing;
- contributor grain remains personal until commit;
- the dowry transfers directly to the groom;
- no Household treasury is created.

### 8.6 Groom -> head favour

On successful mediated commit, groom receives exactly one favour owed to the mediating head.

The groom cannot already owe that head a favour.

The favour is a commit consequence of the mediated route, not a substitute for head authority.

### 8.7 Self-authorization boundaries

- groom cannot self-authorize as the mediating head;
- a female head may mediate her own marriage.

The female-head companion therefore intentionally allows one person to be both bride and valid Household head. Her accepted head-role resolution is sufficient under the mediated route. No recursive or second response context is needed merely because the bride and head are the same person.

### 8.8 Remaining revalidation

Closing LATER-05 does not bypass LATER-04.

A mediated proposal accepted by the head still revalidates:

- current head/authority;
- bride participation/eligibility;
- groom eligibility;
- favour-slot constraint;
- current provision capacity;
- other action-relevant marriage preconditions.

If authority is destroyed in the same cycle, the unresolved **ordering** question is LATER-04, not a missing marriage-response topology.

## 9. Observation-derived verification prompts

RUN-0003 is implementation-risk evidence only. It does not create semantics.

Its lessons map cleanly onto already-accepted Slice-4 rules.

### 9.1 Prospective nominee/holder dependencies before occupancy

A prospective nominee can matter to appointment validity before becoming holder.

Verification/dependency analysis must therefore include:

- nominee participation status;
- same-cycle participation changes;
- nominee response/consent;
- current participant set used for unanimity;
- transitions capable of destroying those conditions.

A current-holder-only dependency scan is insufficient.

### 9.2 Structural status does not imply observation

Current sustaining participation and head occupancy must not be treated as automatic knowledge of every role transition.

Direct information entitlement remains event-specific.

### 9.3 Stale predecessor Recognition

Verification should show:

1. objective A -> B succession;
2. outsider X remains stale on A without accepted newer evidence;
3. X does not magically recognize B;
4. accepted provenance-bearing correction reaches X;
5. authority-dependent routing then uses B.

### 9.4 Explicit correction routes

For bounded Slice-4 acceptance, direct participation plus communication is sufficient.

Do not create a generic “everyone nearby observed succession” rule.

### 9.5 Resource backing remains separate from authority

Verification should independently perturb:

- head occupancy/validity;
- H Active/vacant/Inactive status;
- provision commitments;
- personal grain / `NeedsGrain`;
- actor Recognition.

A change in one must not silently rewrite the others.

### 9.6 Scoring fallback versus central-resolution fallback

Human-facing traces should distinguish:

- scorer/tie fallback selecting a candidate inside a decision context; and
- central-resolution technical fallback resolving true semantic symmetry.

Neither may be confused with the unresolved LATER-04 precedence.

## 10. Slice-4 / Slice-5 boundary

### 10.1 Slice 4

Slice 4 should make executable:

- persistent head role;
- initial vacancy;
- nomination/appointment;
- succession;
- vacancy through accepted head participation exit;
- head-role Recognition and stale predecessor behavior;
- scoped head authority;
- provision solicitation/reconsideration;
- Household support;
- mediated marriage;
- separate personal and Household decision contexts;
- central revalidation of authority/capability;
- role/holder history/provenance.

### 10.2 Slice 5

Slice 5 retains:

- exact checkpoint/restore;
- omission mutants for future-influencing state;
- delayed/pending serializable processes beyond current immediate same-cycle proposal closure;
- exact continuation suffix equivalence.

SPEC §9.6 already requires any future checkpoint to include Household/head/provision and subjective state. That accepted future requirement does not move executable checkpoint/restore into Slice 4.

### 10.3 No silent delayed-process expansion

If a proposed Slice-4 implementation design would solve LATER-04 by turning head transitions or Household actions into delayed multi-cycle reservations/processes, that would pull Slice-5 machinery and new semantics forward. The accepted Slice-4 path should remain within immediate same-cycle proposal/response/resolution unless separately promoted.

## 11. Semantic decisions versus engineering / verification choices

### 11.1 Semantic decision required

Exactly one unresolved consequential semantic choice is established:

1. **LATER-04 precedence:** ordering of an accepted authority/precondition-destroying transition relative to an accepted same-snapshot dependent action when no existing semantic priority determines the order.

### 11.2 No semantic decision required for

Accepted authority already determines:

- persistent role vs holder separation;
- initial vacancy;
- nomination and nominee eligibility;
- nominee consent;
- unanimity;
- appointment;
- same-role succession;
- vacancy on head participation end;
- scoped authority;
- direct participant head Recognition;
- stale outsider Recognition;
- accepted evidence-based correction;
- provision solicitation/reconsideration scope;
- support and dowry use limits;
- separate personal/Household initiatives;
- Active/vacant/Inactive gating;
- precommit revalidation;
- invalidation once a precondition is already gone;
- mediated-marriage response topology under LATER-05.

### 11.3 Engineering / verification choices left open

Without semantic promotion, later planning may choose:

- concrete role/occupancy record layout;
- indexes and derived-query strategy under ADR-0003;
- command/event type names;
- exact test populations and stable IDs;
- independent oracle implementation;
- how to migrate/instantiate the accepted vacant role for already-existing Slice-3 Household fixtures;
- dependency graph representation, provided prospective nominees/holders are included;
- trace/rendering terminology;
- acceptance scenario construction using already-verified H producers;
- whether optional generated-history infrastructure is activated.

None of those choices may decide LATER-04 implicitly.

## 12. Director decision map

**DIRECTOR DECISION REQUIRED — ONE EXACT CONSEQUENTIAL CHOICE**

1. **Same-cycle destructive-transition precedence (LATER-04):** decide the semantic precedence when an accepted transition destroys a head/participant/status/authority precondition of another already-accepted same-snapshot action and no existing accepted domain priority orders them. The accepted decision must make clear whether the destructive transition resolves first, the dependent action resolves first, or a specifically bounded conflict treatment applies before any residual true symmetry can use the already-accepted logged technical fallback.

No additional Director decision is currently required for mediated-marriage topology, office/holder separation, Recognition acquisition/staleness, scope of authority, provision grounding, or dual-mode initiative.

---

## Slice-4 semantic boundary

**REQUIRED:** persistent `HouseholdHeadRole(H)`; initial vacancy; participant-only nomination/nominee eligibility; nominee consent; unanimous current sustaining-participant acceptance/recognition; initial appointment; same-role succession; vacancy on accepted head participation exit; head-role Recognition; stale predecessor Recognition and accepted correction; scoped authority and explicit prohibitions; endogenous provision solicitation/reconsideration; 1-grain Household support; mediated-marriage authority; occupied `HouseholdDecisionContext(H, head=P)`; separate personal and Household initiatives; Active/vacant/Inactive gating; central revalidation and authority-dependent invalidation.

**INHERITED / REGRESSION:** Household identity/continuity/lifecycle substrate; `SustainingParticipant`; subjective knowledge/Recognition evidence rules; communication provenance; provision commitments/capacity grounding; common-snapshot proposal/response semantics; deterministic reaction closure; no hidden derived authority.

**NOT SLICE 4:** exact checkpoint/restore and delayed-process continuation machinery remain Slice 5.

## Fired deferred gaps

- **LATER-04:** **FIRED / UNRESOLVED / DIRECTOR DECISION REQUIRED**.
- **LATER-05:** **FIRED / CLOSED BY ACCEPTED SEMANTICS**.
- **VH-05 head-vacancy side:** now fired as a verification-hardening concern; use accepted direct-participation/communication evidence routes rather than inventing generic observation.
- checkpoint omission hardening remains Slice 5.

## LATER-04 disposition

General precommit revalidation is already fixed. Existing domain priorities remain controlling. True equal-priority symmetry may use the disclosed logged technical fallback.

The distinct one-way race where a destructive transition can invalidate a dependent action only if it resolves first is not closed by those rules. Accepted authority does not currently define that precedence.

**Director decision required before Slice-4 acceptance freeze.**

## LATER-05 disposition

Accepted mediated-marriage semantics are sufficient:

- bride participation is a route fact/gate;
- groom must know that fact and recognize H/current head/scope;
- current head receives/resolves the mediated proposal;
- head acceptance is sufficient;
- successful commit funds dowry from current valid provision backing and creates groom -> head favour;
- groom cannot self-authorize;
- female head may mediate her own marriage.

No additional nested bride response or authority topology rule is required.

## Slice4/Slice5 boundary

Slice 4 owns office/holder turnover, scoped authority, head Recognition, Household dual-mode action, provision solicitation/spending, and mediated marriage. Slice 5 owns exact checkpoint/restore and delayed-process continuation. Future checkpoint semantics must eventually preserve Slice-4 role/head state, but that does not make checkpoint execution a Slice-4 requirement.

## Director-decision status

**ONE DIRECTOR DECISION REQUIRED: LATER-04 same-cycle destructive-transition precedence.**

## Recommendation

**BLOCKED PENDING DECISION.**
