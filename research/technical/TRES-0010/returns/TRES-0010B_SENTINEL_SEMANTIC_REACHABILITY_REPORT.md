# TRES-0010B Sentinel — Semantic Reachability / State-Machine Report

**Status:** ADVISORY / INDEPENDENT REPLICATION RETURN  
**Task ID:** TRES-0010B-SENTINEL  
**Role:** blind semantic-reachability replication  
**Authority:** advisory research only

## Run provenance

- **Canonical input baseline:** `tres-0010-review-baseline`
- **Resolved canonical input SHA:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Wave-B control baseline used to read the Wave-B packet/dispatch:** `tres-0010-wave-b-baseline` @ `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Return branch/workspace:** `tres-0010/wb-sentinel-b`
- **Model/configuration visible to reviewer:** GPT-5.6 Sol; exact hidden reasoning-effort setting not exposed
- **Tools used:** repository/branch metadata retrieval, exact-ref file retrieval, and isolated GitHub branch write through the connected GitHub repository tool
- **External web research:** no
- **Assigned Wave-A reports read:** none
- **Original TRES-0010B return read:** no
- **Prior TRES-0003–0009 reports read:** no
- **Sibling Wave-A returns read before initial report:** no
- **Opposing Wave-B return read before completion:** no
- **Any Wave-B finding packet/return read:** no
- **Unrelated Wave-A returns read:** no
- **Canonical project artifacts modified:** no
- **Repository mutation:** this return only

### Blindness note

The operator instruction required reading the Wave-B README and dispatch guide before the assigned packet. The required Wave-B README itself contains short labels/summaries of findings being challenged elsewhere in Wave B. I did not open any underlying Wave-A report, any opposing Wave-B packet/return, or any Master Architect synthesis. The findings below were re-derived from the frozen canonical specification/ADRs/verification package and are supported only by those accepted artifacts.

## 1. Executive finding summary

The accepted SFL v0 semantics are unusually complete across ordinary lower-level relation lifecycles, subjective recognition, household operational lifecycle, provision accounting, response/failure outcomes, deterministic reaction closure, and checkpoint continuation. Several aggressive reachability attacks therefore closed without a defect.

Seven gaps survived source-level disconfirmation:

| ID | Semantic object / edge | Classification | Severity | Immediate Slice-1 relevance |
|---|---|---|---|---|
| TRES-0010B-S-F01 | CandidateOrganization creation/equivalence/retirement | missing semantic rule | HIGH_REPAIR_BEFORE_CODE | No; repair before formation implementation |
| TRES-0010B-S-F02 | Grain-valued action quantity domain | missing semantic rule | HIGH_REPAIR_BEFORE_CODE | **Yes** |
| TRES-0010B-S-F03 | Exogenous actor departure transition | missing semantic rule / verification weakness | MEDIUM_AMEND_OR_GUARD | Not necessarily; generated-input guard needed |
| TRES-0010B-S-F04 | Called-favour callable-action closure | missing semantic rule | HIGH_REPAIR_BEFORE_CODE | **Yes** |
| TRES-0010B-S-F05 | Explicit benefit-for-favour at favour-capacity limit | missing semantic rule | HIGH_REPAIR_BEFORE_CODE | **Yes** |
| TRES-0010B-S-F06 | Exit-side ContinuationWarrant production/provenance | missing semantic rule | MEDIUM_AMEND_OR_GUARD | No; repair before turnover/continuity implementation |
| TRES-0010B-S-F07 | Rejoin/re-exit lineage-source selection | missing semantic rule | MEDIUM_AMEND_OR_GUARD | No; repair before controlled-lineage implementation |

The lower-level gaps F02, F04, and F05 make more than one implementation behavior consistent with the current accepted prose. Because the first implementation slice includes the lower-level relationship/action substrate, my recommendation is **AMEND BEFORE IMPLEMENTATION** rather than silently choosing implementation semantics.

## 2. Compact semantic reachability inventory

Legend: **closed** = accepted authority gives a creation/update/terminal path and verification exercises it; **gap** = at least one required transition still needs an invented choice.

| Object / state | Creation / entry | Mutation / progress | Terminal / satisfaction | Visibility / failure | Verification | Reachability result |
|---|---|---|---|---|---|---|
| Grain / NeedsGrain / Farm | fixture stock; consumption; Farm | transfers, consumption, production | NeedsGrain clears at >= next 1-grain unit | explicit source/sink history | VS-SFL-090; provision cards | **closed**, except quantity-domain F02 |
| Attitude | initialized or relation event | bounded event deltas; 5-cycle decay | no terminal state required | subjective relation state | VS-SFL-097 + boundaries | **closed** |
| Kinship | initialized | immutable in v0 | n/a | direct relation | scoring/gate cards | **closed** |
| Debt | accepted loan | partial repayment; due review | remaining=0 satisfies claim, history retained | direct parties; explicit due consequence | VS-SFL-092 | **closed**, except action quantity-domain F02 |
| Favour | explicit bargain or qualifying reciprocal help | call/refuse/fulfil; reciprocal cancellation | fulfil/cancellation satisfies; refusal retains | direct parties; explicit attitude effects | VS-SFL-093/094; response family | **gap** F04/F05 |
| Transfer meanings | proposal/acceptance | central revalidation | commit or terminal failure | explicit semantic history | VS-SFL-091 | **closed**, except F02/F05 |
| Residence | bilateral move/invite | accepted residence change | current relation replaces prior residence | direct participants | VS-SFL-096 | **closed** |
| Marriage | direct bypass or mediated route | established relation is persistent | no divorce/remarriage in v0 | participants/route evidence | VS-SFL-095; provision/recognition cards | **closed** |
| KnownFact / Recognition | direct participation/observation/communication | provenance precedence; stale/contested update | no forced decay; can remain stale/contested | actor-specific | VS-SFL-030..035 | **closed** |
| CandidateOrganization / CandidateRecognition | evidence can justify CandidateRecognition | may collect formation evidence | formation should consume/reify candidate context | subjective recognition | VS-SFL-001/002 | **gap** F01 |
| FormationWarrant / Household | full formation predicate + all founder recognition | immutable identity with later warrants | household may later dissolve, history remains | founders recognize directly | formation family | **closed once candidate identity is supplied; F01 blocks clean entry** |
| SustainingParticipant entry | FormationWarrant or ParticipationWarrant | explicit entry/exit | ParticipationEndWarrant ends association | direct participants / recognition gates | continuity family | **closed** |
| ContinuationWarrant / identity | existing bridge + recognition + transition evidence | chain through turnover | zero participants -> Dissolved; no resurrection | historical warrant chain | VS-SFL-010..014 | **gap on pure exit provenance** F06 |
| Lifecycle Active/Inactive/Dissolved | derived at stable closure from participant count | reactivation from Inactive through sole bearer | Dissolved cannot reactivate | stable-cycle only | VS-SFL-012/014 + boundaries | **closed** |
| LineageWarrant | automatic after independently valid successor formation | immutable historical provenance | no behavioral power | objective history only | VS-SFL-020..026 | **gap on repeated same-predecessor exits** F07 |
| Provision commitment/capacity | explicit accepted commitment | derived capacity; reconsideration cooldown | participation end/dissolution terminates | scoped household/head context | VS-SFL-040..046 | **closed** |
| Household head role | role exists vacant; unanimous appointment | succession or vacancy on participant exit | vacancy is valid persistent role state | participant recognition; outsiders via evidence | VS-SFL-060..066 | **closed** |
| Personal/household/response contexts | activation from stable snapshot | scored proposals/responses | commit, Declined, Unable, InvalidatedAtResolution | diagnostic traces + bounded participant knowledge | response/resolution families | **closed**, except called-favour nested closure F04 |
| Automatic reactions | cause-keyed trigger | monotone ReactionIndex, idempotent/no-op closure | stable cycle boundary | semantic history | VS-SFL-074/075 | **closed** |
| MaterialDeadlock | stable condition predicate | removed by valid future material path | explicit diagnosed stuck state | verifier-visible | VS-SFL-080 | **closed** |
| Checkpoint/restore | stable cycle boundary only | exact future continuation | next stable checkpoints | full future-influencing state | VS-SFL-082..084 | **closed** |
| Exogenous actor departure | fixture authority says it may be injected | **no accepted transition semantics** | **undefined** | **undefined** | only generic generated-operation vocabulary | **gap** F03 |

## 3. Detailed findings

### TRES-0010B-S-F01 — CandidateOrganization creation/equivalence/retirement is not semantically closed

- **Classification:** missing semantic rule
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Primary evidence:**
  - `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §6.2 requires recognition that candidate organization C is the same prospective founding organization.
  - §6.3 defines `CandidateRecognition(C)` as ephemeral and evidence-backed, keyed to a proposed founding core.
  - §7.1 says a `CandidateOrganization` may collect formation evidence but grants no powers.
  - §7.2 requires recognition of *the candidate* by every required founder before one FormationWarrant/H can form.
  - `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` requires independently identified typed records and stable semantic identity.
  - `plans/verification/SFL_V0/FORMATION_FAMILY.md` VS-SFL-001 refers to `CandidateABC`, forbids fixture-writing CandidateRecognition, and does not authorize a fixture write of CandidateOrganization in its declared allowed write set.
- **Smallest counterexample / failure trace:**
  1. A and B are the two-person founding core and satisfy residence, durable tie, two distinct-cycle support events, and subjective evidence.
  2. A's candidate discovery creates candidate record C1; B's discovery creates C2 for the same core/history.
  3. A validly reaches `CandidateRecognition(C1)`; B validly reaches `CandidateRecognition(C2)`.
  4. The formation rule requires all required founders to recognize *the candidate*, but no accepted rule says C1=C2, merges them, selects a canonical record, or prevents duplicate candidates.
  5. Treating C1/C2 as the same requires an invented equivalence/identity rule; treating them as different can leave formation permanently stuck despite every substantive formation predicate being satisfied.
- **Why accepted authority does not already answer it:** ADR-0001 constrains how semantic identity must behave once represented, but does not define the creation trigger, equivalence key, merge rule, or retirement of prospective CandidateOrganization records. The formation card assumes a candidate label but does not supply the missing semantic transition.
- **Consequence if ignored:** formation can be implementation-dependent, permanently unreachable, or duplicative; CandidateRecognition may become keyed to arbitrary engine record creation rather than accepted lower-level evidence.
- **Recommended disposition:** close CandidateOrganization lifecycle/equivalence in accepted authority, then add a test that independently discovered evidence converges on one prospective candidate without fixture-writing the result. This finding does **not** by itself require blocking lower-level Slice 1, but it must be resolved before formation code.
- **Confidence:** high.
- **Disconfirmation attempted:** I tested whether ADR-0001's stable-identity rule plus §7.2 implicitly yields a unique candidate. It does not: those rules constrain record identity and final formation but provide no canonical prospective-candidate construction/equivalence transition.

### TRES-0010B-S-F02 — Grain-valued action quantities have no explicit validity domain

- **Classification:** missing semantic rule
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Primary evidence:**
  - `SPEC-SFL-0001` §2.2 defines grain effects in units but does not state the numeric domain of grain stock or action quantities.
  - §3.3 defines Debt as a quantitative grain claim and repayment as partial/complete, without an admissible amount predicate.
  - §§3.5 and 5.1 require Gift/Help/Loan/Repay action meanings but do not state `amount > 0`, integer-only, or equivalent validity rules.
  - §10 requires nonnegative personal grain and explicit source/sink/zero-sum accounting, but those invariants do not reject zero or negative transfer *requests*.
  - `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` exercises positive quantities (mostly 1) and repayment reserve boundaries, but has no zero/negative/non-integral action-domain boundary.
- **Smallest counterexample / failure trace:**
  1. Submit `OfferLoan(A -> B, 0)`, `OfferGift(A -> B, -1)`, or `RepayDebt(-1)` through a mechanism-isolation boundary.
  2. The accepted artifacts do not tell the validator whether the proposal is invalid, Unable, or a valid zero-sum transfer.
  3. A naive arithmetic implementation of a negative transfer can reverse material direction while still satisfying the global zero-sum and nonnegative-stock invariants in some states.
  4. A zero loan can create a Debt record with no positive claim unless an implementation invents a positivity gate.
- **Why accepted authority does not already answer it:** ordinary-language words such as “amount” and “transfer” suggest positive quantities, but the executable semantic contract never states that admissibility rule. Verification's use of 1-grain examples is not authority for all valid proposals.
- **Consequence if ignored:** lower-level validators, candidate generators, fixture-validity checks, debt creation, and independent oracles can disagree while each claims conformance.
- **Recommended disposition:** state the admissible domain for grain stock and every grain-valued action parameter in accepted semantics, with explicit invalid-boundary tests. Do not let the implementation choose this silently.
- **Confidence:** high.
- **Disconfirmation attempted:** I checked whether nonnegative grain and zero-sum transfer invariants imply positive proposal quantities. They do not; they constrain resulting balances/accounting, not parameter validity.

### TRES-0010B-S-F03 — Exogenous actor departure is authorized as an input but has no state transition

- **Classification:** missing semantic rule / verification weakness
- **Severity:** MEDIUM_AMEND_OR_GUARD
- **Primary evidence:**
  - `SPEC-SFL-0001` §1.1 authorizes the scenario harness to initialize/inject bounded exogenous events including “actor arrival/departure.”
  - §2.1 gives stable person identity but no present/absent/alive/departed state.
  - §7.4 requires household participation exit to be explicit and warrant-bearing.
  - §8 ties head/provision behavior to persistent person/participation state.
  - §9.4 and ADR-0001 require historical references to remain resolvable.
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §5 includes controlled exogenous actor arrival/departure in generated histories.
- **Smallest counterexample / failure trace:**
  1. A is a person with a live Debt/Favour and is a SustainingParticipant, current head, and provision contributor.
  2. The harness injects the explicitly permitted exogenous “A departs” event.
  3. Deleting A breaks or complicates live/historical references; retaining A unchanged means A still consumes, deliberates, responds, and occupies roles; silently ending participation/head/provision invents a transition that §7.4 normally requires explicit warrants for.
  4. No accepted artifact selects among these behaviors or even defines the minimal meaning of “departure.”
- **Why accepted authority does not already answer it:** arrival/departure is named as a legal exogenous input category, but no corresponding person-lifecycle state machine exists in v0. Death is explicitly out of scope, so it cannot be borrowed as the semantics.
- **Consequence if ignored:** generated histories either cannot validly use a declared operation or must embed hidden lifecycle policy in the harness/engine, potentially bypassing warrants and reference invariants.
- **Recommended disposition:** before using departure in Stage-4 verification, either define its bounded semantic effect in accepted authority or explicitly narrow it out of valid generated operations for v0. No particular departure policy is recommended here.
- **Confidence:** high.
- **Disconfirmation attempted:** I tested whether “departure” could safely mean only a residence change. §2.3/§3.6 explicitly separate residence from other relationships and household participation, so that interpretation does not implement an actor departure.

### TRES-0010B-S-F04 — Called-favour fulfilment is not closed over actions that themselves require proposal/response semantics

- **Classification:** missing semantic rule
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Primary evidence:**
  - `SPEC-SFL-0001` §3.4 says a favour may request “one otherwise-feasible ordinary action”; fulfilment satisfies the favour and refusal leaves it outstanding.
  - §5.1 makes responses a distinct `ResponseDecisionContext`, permits multiple responses, and keeps all accepted responses subject to central resolution.
  - §5.1's required action meanings include actions that themselves can require another target response (gift/help/loan/residence/participation, etc.) as well as `CallFavor / fulfil / refuse`.
  - §9.1 gives one response phase but no response-generated-proposal closure loop.
  - `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` VS-SFL-094 states that on fulfilment the requested action commits through ordinary proposal/resolution semantics.
  - `RESPONSE_DECISION_FAMILY.md` VS-SFL-102 verifies FulfilCalledFavor/RefuseCalledFavor choice but does not exercise a requested action that creates a second target decision.
- **Smallest counterexample / failure trace:**
  1. B owes A a favour.
  2. A calls the favour asking B to perform the otherwise-feasible ordinary action `RequestGiftOrHelp(B -> C, 1)`.
  3. B's response context selects `FulfilCalledFavor`.
  4. The requested action is not authoritative until C gets its own response and central resolution commits it.
  5. The cycle contract does not say whether B's response may spawn a new same-phase proposal and a nested/new `ResponseDecisionContext(C,...)`, whether that response phase iterates to closure, or whether the favour becomes satisfied when B attempts the request versus only when the downstream action commits.
  6. If C declines or the downstream action is invalidated, the accepted artifacts do not uniquely state whether B fulfilled A's favour.
- **Additional initiative edge:** if the requested ordinary action is one normally initiated through B's personal context, §5 says B normally has one personal voluntary initiative while §5.1 says responses consume no personal initiative. The accepted text does not explicitly state whether a called-favour action is exempt from ordinary initiative accounting or must still satisfy an unused-initiative precondition.
- **Why accepted authority does not already answer it:** central revalidation determines whether proposed effects can commit; it does not supply missing target consent or define when a compound/nested called-favour obligation is satisfied. “Otherwise-feasible ordinary action” is not given a closed callable-action grammar.
- **Consequence if ignored:** two conforming-looking engines can differ on response recursion, target autonomy, initiative consumption, and favour satisfaction; some valid-looking called favours can be unreachable.
- **Recommended disposition:** close the callable-action and fulfilment lifecycle in accepted semantics and add at least one nested-target and one initiative-accounting boundary case before implementing general CallFavor.
- **Confidence:** high.
- **Disconfirmation attempted:** I tested whether “multiple response contexts may activate” supplies the missing recursion. It only states that a target can process multiple incoming proposals from the common snapshot; it does not define proposals created by a response or their ordering/satisfaction semantics.

### TRES-0010B-S-F05 — Explicit benefit-for-favour has no authoritative terminal rule when the ordered-pair favour slot is already full

- **Classification:** missing semantic rule
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Primary evidence:**
  - `SPEC-SFL-0001` §3.4 imposes at most one outstanding favour per ordered person-pair.
  - The same section allows a favour to arise from an explicit benefit-for-favour bargain and prohibits trading/partial/generic social-currency interpretations.
  - §5.1 includes `OfferBenefitForFavor` as a required action meaning.
  - `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` VS-SFL-093 says a second favour cannot stack and that the underlying benefit “may still commit if independently valid”; as verification design, that sentence cannot silently define the missing social semantics and does not state when such independent validity applies to the explicitly bargained action.
  - By contrast, mediated marriage explicitly gates out a groom who already owes the mediating head a favour (§4.2), showing that favour-capacity preconditions are stated when intended.
- **Smallest counterexample / failure trace:**
  1. B already owes A one outstanding favour.
  2. A submits `OfferBenefitForFavor(A -> B, benefit)`; B knowingly accepts the named bargain.
  3. A second B->A favour cannot be created.
  4. The accepted semantics do not say whether the entire bargain is infeasible, whether the benefit transfers without a new favour, or whether acceptance is unavailable before scoring.
  5. Replacement/stacking is excluded, but at least the first two terminal interpretations remain possible.
- **Why accepted authority does not already answer it:** the cardinality invariant says what state may not exist; it does not state the atomicity/failure behavior of the compound bargain when its favour consequence cannot be created.
- **Consequence if ignored:** material state, favour history, response outcome, and attitude consequences can diverge on a basic lower-level action.
- **Recommended disposition:** record an explicit semantic terminal rule for `OfferBenefitForFavor` at pair capacity and verify the exact response/failure/history outcome.
- **Confidence:** high.
- **Disconfirmation attempted:** I checked whether “at most one favour” makes the action simply invalid. That is a plausible implementation, but the accepted artifacts never state it, and the verification text explicitly leaves open an independently valid benefit commit.

### TRES-0010B-S-F06 — Pure participation exit does not fully specify ContinuationWarrant production/provenance

- **Classification:** missing semantic rule
- **Severity:** MEDIUM_AMEND_OR_GUARD
- **Primary evidence:**
  - `SPEC-SFL-0001` §7.4 says `EndHouseholdParticipation(H)` creates a ParticipationEndWarrant, ends the association, and triggers household lifecycle/continuity reevaluation.
  - §7.5 says household continuity **requires** an explicit historical transmission chain, at least one existing SustainingParticipant bridge that recognizes the successor as the same household, and a `ContinuationWarrant` linking prior state, transition evidence, and successor state.
  - §7.6 says an Active H with 2+ participants remains Active at stable closure after an ordinary exit if at least two remain.
  - `CONTINUITY_TURNOVER_FAMILY.md` VS-SFL-010 requires an auditable Formation/ParticipationEnd/Continuation chain, while its stepwise positive sequence explicitly calls out the ContinuationWarrant on entry but not the exact exit-side warrant reaction.
- **Smallest counterexample / failure trace:**
  1. Active H has A/B/C as recognized SustainingParticipants.
  2. A validly ends participation.
  3. B and C remain, so lifecycle outcome is unambiguously Active and the intended numerical identity is H.
  4. Merely mutating H's participant-derived view preserves the in-memory ID but does not satisfy §7.5's explicit warrant-chain requirement.
  5. Automatically creating an exit-side ContinuationWarrant is the obvious route, but accepted authority does not state its exact trigger/contents or how bridge provenance is represented when B and C are both valid bridges.
- **Why accepted authority does not already answer it:** §7.4 says reevaluate and §7.5 states what valid continuity needs, so the endpoint is strongly constrained; however the actual required automatic warrant transition and provenance selection/aggregation are not specified. That leaves semantic history non-unique even if identity/lifecycle outcome is predictable.
- **Consequence if ignored:** an implementation may preserve household identity by object persistence without the required historical chain, or two implementations may emit materially different continuity provenance.
- **Recommended disposition:** close the exit-side ContinuationWarrant rule before turnover/continuity implementation and add a direct pure-exit warrant assertion. This is not a lower-level Slice-1 blocker.
- **Confidence:** medium-high.
- **Disconfirmation attempted:** I treated §7.4 “triggers continuity reevaluation” plus §7.5 as an implicit automatic-reaction rule. That is enough to infer that some continuity proof is required, but not enough to derive one unique warrant/provenance representation without adding a rule.

### TRES-0010B-S-F07 — Rejoin/re-exit histories make the lineage source event non-unique

- **Classification:** missing semantic rule
- **Severity:** MEDIUM_AMEND_OR_GUARD
- **Primary evidence:**
  - `SPEC-SFL-0001` §7.7.1 requires each founder-lineage source to contain founder ID, predecessor Household ID, and a supporting ParticipationEndWarrant ID.
  - §7.7.2 says a successor founder must have a **relevant** ParticipationEndWarrant for the claimed predecessor.
  - §7.7.3 defines fresh division evidence relative to **all ParticipationEndWarrant events used as lineage sources**.
  - The ambiguity rules withhold lineage when predecessor-set/kind or predecessor-source mapping is ambiguous, but do not explicitly define which of multiple end warrants to the *same predecessor* is “relevant.”
  - `LINEAGE_FAMILY.md` covers ambiguous predecessor histories but not exit -> rejoin -> re-exit of one founder to the same predecessor.
- **Smallest counterexample / failure trace:**
  1. C is a SustainingParticipant of H and exits at e1, creating ParticipationEndWarrant W1.
  2. C later validly rejoins H.
  3. A qualifying person-person support event s occurs after e1.
  4. C exits H again at e2, creating W2, with e1 < s < e2.
  5. C later becomes a founder of independently valid H2.
  6. If W1 is the lineage source, s is post-exit fresh evidence; if W2 is the source, s is not.
  7. Both W1 and W2 point from the same founder to the same predecessor, so predecessor-set/kind is unchanged; accepted authority does not say whether the newest unmatched exit is required, whether either may be cited, or whether this same-predecessor multiplicity itself forces no lineage.
- **Why accepted authority does not already answer it:** the existing ambiguity guard is clear for competing predecessor interpretations, but the warrant itself records a specific ParticipationEndWarrant ID and freshness depends on that choice. “Relevant” is not operationally closed for repeated participation in one predecessor.
- **Consequence if ignored:** the same authoritative history can either receive or fail to receive `DivisionDescendant` depending on implementation-local source-event selection.
- **Recommended disposition:** close source-event selection/ambiguity for repeated same-predecessor participation before implementing controlled lineage and add one rejoin/re-exit adversarial card.
- **Confidence:** high.
- **Disconfirmation attempted:** I tested whether the general “ambiguous predecessor-source mapping -> no lineage” rule necessarily covers W1 versus W2. Because both map C to the same predecessor H while only the supporting event ID differs, the prose does not uniquely compel that interpretation.

## 4. Falsification routes that did not expose a defect

These attacks were performed before deciding that amendment is required.

### A. NeedsGrain / Farm / clearing lifecycle

I tried to construct a stuck or circular path around consumption and need clearing. `SPEC-SFL-0001` §2.2 plus VS-SFL-090 closes it: missed consumption creates NeedsGrain, NeedsGrain gates Farm, a valid transfer to at least the next 1-grain unit clears need, and same-cycle voluntary reactivation is explicitly forbidden. No self-confirming result is needed.

### B. Debt due-review repetition or claim-history loss

I tried to make the social due consequence repeat forever or erase the debt after repayment. §§3.3/9 and VS-SFL-092 explicitly specify one review after N+3 decisions, a one-time -10 consequence if a balance remains, and retained debt/repayment history after full satisfaction. The cause-key/idempotence contract closes the reaction path.

### C. Subjective recognition becoming engine omniscience

I tried objective succession, late-old-message delivery, and incomparable evidence. §§6.4–6.6 plus VS-SFL-031/032/033 make stale evidence persist, order by underlying event provenance, and produce Contested when incompatible evidence cannot be ordered. Household/head engine state does not automatically broadcast recognition.

### D. Active -> Inactive -> Active -> Dissolved operational lifecycle

I tried to resurrect a zero-participant H by resemblance or to give an Inactive H household-mode action. §§7.5–7.6 plus VS-SFL-012/014 explicitly distinguish identity from participant count, permit reactivation only from Inactive through the sole continuity bearer, forbid same-identity resurrection after Dissolved, and suspend household initiative while Inactive.

### E. Provision accounting and simultaneous material conflicts

I tried to produce a pooled treasury, double debit, reserve penetration, or order-dependent contributor re-ranking. §8 plus VS-SFL-040..046 close these attacks with personal ownership until spend, exact exposed capacity, fixed precommit ranking, single debit vector, and stable-ID tie fallback. VS-SFL-065/072 also preserve central revalidation and priority under same-snapshot conflicts.

### F. Head vacancy/succession as an identity shortcut

I tried to make head vacancy dissolve H or let succession replace the role object. §8.4–8.5 and VS-SFL-060..063 keep one persistent head role, make new H headless, require unanimous appointment/succession, preserve H/role identity, and allow vacancy without destroying H.

### G. Automatic reaction self-confirmation / infinite closure

I tried duplicate cause application and a reaction loop that repeatedly re-enables itself. §9.3 plus VS-SFL-074/075 require cause-keyed idempotence, enabling-condition consumption/no-op behavior, monotone ReactionIndex, explicit error on repeated production, and no stable boundary until closure. No semantic “success by arbitrary truncation” is allowed.

## 5. Undetermined points after this review

The seven findings above are the points for which accepted artifacts did not uniquely determine an answer. I found no additional unresolved contradiction in:

- ordinary attitude/kinship behavior;
- debt due timing;
- residence independence;
- direct and mediated marriage gates apart from the general favour-capacity issue already captured in F05;
- recognition staleness/conflict;
- provision allocation;
- head appointment/succession;
- response outcome distinctions;
- automatic-reaction idempotence;
- MaterialDeadlock;
- checkpoint/restore and derived-state rebuild.

I did not inspect prior TRES conclusions to resolve uncertainty; doing so would defeat the sentinel's independent source audit.

## 6. Recommendation

**AMEND BEFORE IMPLEMENTATION**

Reason: F02, F04, and F05 affect the lower-level action/relationship substrate directly. Implementing them now would require choosing a quantity-validity rule, called-favour closure behavior, and benefit-for-favour capacity behavior that are not uniquely authorized by the frozen accepted semantics. Those are semantic choices, not merely reversible code organization.

F01, F06, and F07 can be repaired before their later formation/continuity/lineage slices rather than being treated as independent blockers to the lower-level kernel, provided Slice 1 does not prematurely encode their missing choices. F03 can be guarded by not exercising undefined departure events until the accepted v0 boundary is clarified.

No fix design is promoted by this report; all dispositions remain advisory.
