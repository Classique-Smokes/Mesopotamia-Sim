# TRES-0010 B2 Task 2 — Lower-Level Action / Favour Closure Options

**Task ID:** TRES-0010B2-SEM-A  
**Status:** COMPLETE / ADVISORY DECISION SUPPORT  
**Frozen B2 baseline ref:** `tres-0010-b2-baseline`  
**Resolved B2 baseline SHA:** `0729e460af35668e5b911fa561bf8cec53204142`  
**Return branch / workspace:** `tres-0010/b2-sem-a`  
**Model / configuration:** GPT-5.6 Sol  
**Tools used:** GitHub repository connector only  
**External research:** no  
**Assigned Wave-A reports read:** none directly in B2; inherited findings were taken only through the required Wave-B adjudication material  
**Assigned Wave-B reports read:** `TRES-0010B-A-PROSECUTION_ACTION_CLOSURE_REPORT.md`; `TRES-0010B-A-DEFENSE_ACTION_CLOSURE_REPORT.md`; `TRES-0010B_SENTINEL_SEMANTIC_REACHABILITY_REPORT.md` only for F02/F04/F05, as instructed  
**Other required/non-authoritative map read:** `WAVE_B_ADJUDICATION_SYNTHESIS.md`  
**Sibling B2 returns read before completion:** **no**  
**Canonical files modified:** **no**; this advisory return is the only repository write

## 1. Director-facing decision summary

Three narrow Slice-1 semantic decisions remain.

1. **Called favour:** adopt a **response-closed callable-action class**, not a recursive action framework and not an arbitrary permanent whitelist. A called-favour payload is valid only when the called actor's Fulfil/Refuse choice is the last new voluntary choice needed for the requested action to terminate. The requested action is response-scoped, does not consume/grant the called actor's personal initiative, cannot open another response context, and consumes the favour only on successful requested-action commit.

2. **Grain-valued action quantities:** use **strictly positive integer v0 grain units** for action parameters. Zero, negative, and non-integral values are categorically invalid proposal terms. `RepayDebt(amount)` is valid only for `1 <= amount <= remainingDebt` and is never silently clamped. Valid terms that exceed current material capacity are feasibility failures (`Unable`); valid terms accepted from the common snapshot but made impossible before commit become `InvalidatedAtResolution`.

3. **Explicit benefit-for-favour at full pair capacity:** make the explicit bargain **atomic**. If the promised new favour cannot exist because the ordered-pair slot is full, the explicit bargain is infeasible and no material benefit commits. If capacity is lost after acceptance but before commit, the whole bargain is invalidated. This rule is deliberately distinct from relationship-mediated reciprocal help, whose material help may still commit while additional favour creation is suppressed.

All three recommendations are semantic amendments to accepted `SPEC-SFL-0001` and therefore require **Director approval** before promotion.

---

## 2. Issue inventory

| Issue | Surviving gap | Slice-1 consequence if left open |
|---|---|---|
| S1-SEM-03 — called-favour requested-action closure | `ordinary action` has no closed positive membership/completion rule; nested response, initiative treatment, and favour-consumption timing can diverge | Two implementations can disagree on callable payloads, response recursion, initiative accounting, and whether a failed downstream action consumes the favour |
| S1-SEM-04 — grain-valued parameter domain | no accepted positivity/integrality rule; no normative over-repayment disposition | Zero/negative/fractional transfers or over-repayment can reach different social/material outcomes while satisfying some global invariants |
| S1-SEM-05 — explicit benefit-for-favour at full capacity | pair cardinality is fixed, but explicit bargain atomicity is not | One engine can reject the bargain; another can transfer the benefit without creating the promised favour |

No broader action-framework, candidate-generation, or architecture repair is justified by this task.

---

## 3. Accepted constraints

The recommendations below preserve the following accepted constraints.

### 3.1 Favour and transfer meaning

From `SPEC-SFL-0001` §§3.4–3.5:

- at most one outstanding favour per ordered person-pair;
- a favour is a qualitative action-oriented claim, not a point/currency system;
- a favour may request one otherwise-feasible ordinary action;
- impossible action remains impossible;
- marriage/kinship cannot be compelled;
- favours cannot create/demand/transfer another favour;
- fulfilment satisfies the favour; refusal leaves it outstanding;
- Gift, Loan, ExplicitBenefitForFavor, and RelationshipMediatedReciprocalHelp remain semantically distinct even if material-transfer implementation is shared.

### 3.2 Agency and response authority

From `SPEC-SFL-0001` §5 and §5.1 plus ADR-0002:

- each person normally receives one voluntary personal initiative per cycle;
- responses to incoming proposals do not consume or grant that initiative;
- infeasibility precedes voluntary response scoring;
- multiple response contexts may occur from the common committed snapshot;
- accepted responses do not bypass central resolution/revalidation;
- actor/counterparty autonomy remains explicit.

### 3.3 Deterministic resolution

From `SPEC-SFL-0001` §§9.1–9.3 and ADR-0004:

- one deterministic single-threaded reference kernel;
- response precedes central resolution;
- every proposal is revalidated immediately before commit;
- accepted but incompatible proposals may become `InvalidatedAtResolution`;
- no same-cycle voluntary reactivation after commit;
- completed cycle state is published only after reaction closure.

### 3.4 Failure semantics

From `SPEC-SFL-0001` §6.7:

- `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)` are distinct;
- feasibility failure is not voluntary refusal;
- proposed-but-uncommitted effects never become objective fact;
- refusal attitude penalties do not fire for feasibility failures.

### 3.5 Material/cardinality invariants

From `SPEC-SFL-0001` §10 and the cross-cutting verification contract:

- grain never negative;
- every grain delta has an explicit source/sink or zero-sum transfer;
- at most one outstanding favour per ordered pair;
- every immediate proposal reaches a terminal outcome in the same cycle;
- hard thresholds/cardinality rules require boundary coverage.

---

# PART I — S1-SEM-03: CALLED-FAVOUR CLOSURE

## 4. Option set

### Option A — narrow named whitelist

Define an explicit Slice-1 list of callable action types that never need a new counterpart response, for example a small subset such as direct `Farm` / `RepayDebt`-class transitions.

**Advantages**

- maximally deterministic;
- simplest implementation and verification;
- no response recursion.

**Costs**

- the list is partly arbitrary because accepted authority uses the semantic category “ordinary action,” not a named fixed subset;
- every later action addition requires a semantic whitelist amendment;
- a too-small list can prove only a degenerate favour mechanism and can undercut the accepted action-oriented meaning.

### Option B — broad ordinary-action domain with nested response closure

Allow any otherwise-feasible ordinary action, including actions that create new proposals and additional response contexts.

**Advantages**

- most literal broad reading of “ordinary action”;
- preserves future expressive reach.

**Costs**

- requires a response-generated proposal/decision closure rule;
- requires explicit recursion/queue ordering and same-cycle termination semantics;
- compounds initiative and favour-satisfaction questions;
- expands IMP-0001 into a generic action-composition framework expressly disfavoured by the B2 brief.

### Option C — response-closed semantic class

Define callable actions by a completion property:

> after the holder issues `CallFavor`, the called actor's `FulfilCalledFavor` / `RefuseCalledFavor` choice must be the **last new voluntary actor choice** required for the requested action to reach a terminal commit/failure.

A payload may reuse ordinary lower-level transition semantics, but it may not open another `ResponseDecisionContext`, require a third actor's new voluntary choice, create/demand/transfer/cancel another favour, establish marriage/kinship, or require household/role authority.

**Advantages**

- closes the actual composition gap with one small rule;
- preserves the accepted “ordinary action” abstraction better than a hard-coded permanent list;
- prevents recursive response infrastructure;
- keeps actor/world authority boundaries explicit;
- future actions can join only if they satisfy the same local completion property.

**Costs**

- it introduces one new semantic classification predicate;
- some otherwise ordinary actions are intentionally not callable in Slice 1;
- implementers still need an explicit applicability table for the current action repertoire.

## 5. Option-by-option consequence matrix — called favour

| Criterion | A — whitelist | B — broad/nested | C — response-closed class |
|---|---|---|---|
| Semantic fidelity | medium | high in breadth, low in unresolved composition | **high**: preserves ordinary action meaning while closing composition |
| Determinism | high | medium-low until recursion/order is specified | **high** |
| Actor/world authority | high | high only with substantial nested-response rules | **high** |
| Smallest faithful v0 rule | high but arbitrary | low | **highest** |
| Verification clarity | high | low-medium | **high** |
| Future-slice compatibility | medium | high but framework-heavy | **high** |
| Reversibility | medium | low | **high** |
| Implementation simplicity | high | low | **high** |

## 6. Recommended called-favour rule

**Recommend Option C — response-closed semantic class.**

### 6.1 Initiative accounting

- The holder's voluntary `CallFavor` initiation uses the holder's normal personal initiative when generated by personal agency.
- The called actor's `FulfilCalledFavor` / `RefuseCalledFavor` choice is a response and does not consume or grant the called actor's personal initiative.
- The requested action executes **inside that response scope** and therefore does not separately consume the called actor's personal initiative.
- A called actor may therefore retain/execute the personal initiative selected from the ordinary personal context subject to ordinary compatibility/revalidation rules.

This is the smallest interpretation that keeps §5.1's response accounting meaningful and avoids treating fulfilment as a hidden second voluntary initiative.

### 6.2 Nested response contexts

**Not allowed for Slice 1.**

If requested action completion would require another voluntary response context after the called actor chooses Fulfil, the payload is outside the v0 callable domain.

This deliberately avoids a generic recursive response graph.

### 6.3 Favour consumption and attitude effects

- The favour is consumed **only when the requested action commits successfully**.
- Successful commit: favour satisfied; holder -> fulfiller attitude +10.
- Voluntary `RefuseCalledFavor`: outcome `Declined`; favour remains; holder -> refuser -20.
- `Unable(reason)`: favour remains; no +10/-20 called-favour attitude effect.
- `InvalidatedAtResolution(reason)`: favour remains; no +10/-20 called-favour attitude effect.
- Categorically invalid payload/parameter: no valid CallFavor proposal is created; no response scoring and no social/material effect.

### 6.4 Why this is preferable to a whitelist

The implementation still needs an explicit Slice-1 applicability table, but the **semantic authority is the closure predicate**, not an arbitrary list. The table answers whether each currently commissioned action shape satisfies the predicate and prevents coding-agent interpretation.

---

# PART II — S1-SEM-04: GRAIN-VALUED PARAMETER DOMAIN

## 7. Option set

### Option A — strictly positive integer grain units

- grain-valued action parameters are integers;
- every transfer/loan/help/benefit/repayment/dowry amount must be > 0;
- action-specific semantic bounds remain explicit;
- no clamping of invalid terms.

### Option B — any exact positive numeric quantity

Allow positive fixed-point/rational quantities with no integer restriction.

**Benefit:** avoids committing to indivisible units.

**Cost:** adds representation/conversion/verification complexity with no current semantic need; every accepted v0 example, maintenance rule, reserve, and capacity boundary is already unit-like.

### Option C — permissive numeric inputs normalized/clamped by implementation

Allow zero/negative/excess terms and let implementation reject, clamp, reverse, or normalize.

**Rejected.** This is exactly the ambiguity identified by Wave B and would let representation code decide social semantics.

## 8. Option-by-option consequence matrix — grain domain

| Criterion | A — positive integer | B — exact positive numeric | C — permissive/normalized |
|---|---|---|---|
| Semantic fidelity | **high for current v0 unit model** | medium-high | low |
| Determinism | **high** | high if exact type fixed | low-medium |
| Smallest faithful v0 | **highest** | medium | low |
| Verification clarity | **highest** | medium | low |
| Future economics flexibility | medium | high | medium |
| Migration/reversibility | **high if documented as v0 granularity assumption** | medium | low |
| Implementation simplicity | **highest** | medium | low |

## 9. Recommended grain-domain rule

**Recommend Option A — strictly positive integer action quantities.**

### 9.1 General domain

- personal grain stock is a nonnegative integer number of v0 grain units;
- every action parameter denominated in grain is a strictly positive integer;
- zero, negative, and non-integral quantities are **categorically invalid proposal terms**;
- categorical invalidity is checked before response activation and does not become `Declined`, `Unable`, or `InvalidatedAtResolution`.

### 9.2 Repayment

`RepayDebt(amount)` is semantically valid only when:

- `amount >= 1`; and
- `amount <= debt.remaining`.

Over-repayment is invalid, not clamped and not converted to another transfer meaning.

The debt's remaining amount may validly become zero after full repayment.

### 9.3 Capacity versus validity

Keep parameter validity separate from world-state feasibility.

Example: `OfferGift(amount=3)` is a valid action term even if the giver currently has only 2 permissible grain.

- if insufficient capacity is already true at feasibility/response evaluation: `Unable(InsufficientGrainOrCapacity)`;
- if capacity was sufficient at response selection but is lost before commit because of another accepted same-cycle effect: `InvalidatedAtResolution(InsufficientGrainOrCapacity)`;
- if target voluntarily rejects an otherwise valid and feasible proposal: `Declined`.

### 9.4 Dowry

Mediated dowry remains later-slice/outside IMP-0001, but its grain amount should inherit the same **positive integer** domain when that route is implemented. Funding/provision-capacity rules remain separate feasibility rules.

---

# PART III — S1-SEM-05: EXPLICIT BENEFIT-FOR-FAVOUR AT FULL CAPACITY

## 10. Option set

### Option A — atomic explicit bargain

The promised material benefit and creation of one new favour are one semantic bargain.

If the ordered-pair favour slot cannot accept a new favour:

- the explicit bargain is infeasible;
- no material benefit commits.

If pair capacity is lost after acceptance but before commit:

- the entire bargain becomes `InvalidatedAtResolution`;
- neither leg commits.

### Option B — non-atomic conditional effect

The material benefit may commit even though the promised favour cannot be created.

**Benefit:** aligns with the broadest reading of the current verification phrase “underlying benefit may still commit if independently valid.”

**Cost:** an action explicitly accepted as a benefit-for-one-favour bargain can silently become a benefit-without-favour transfer, weakening actor understanding and collapsing the semantic distinction from Gift/Help unless additional conversion semantics are invented.

### Option C — replace/refresh/merge the existing favour

Use the new bargain to replace, refresh, merge, or otherwise mutate the existing token.

**Rejected by accepted meaning.** v0 has at most one outstanding favour per ordered pair, no partial balances, no point value, no trading, and no generic social-currency interpretation. Nothing in accepted authority supports token replacement/aggregation semantics.

## 11. Option-by-option consequence matrix — full favour capacity

| Criterion | A — atomic bargain | B — benefit survives | C — replace/merge |
|---|---|---|---|
| Explicit-term fidelity | **highest** | medium-low | low |
| Semantic distinctness from Gift/Help | **highest** | low-medium | low |
| Cardinality clarity | **high** | high | low |
| Determinism | **high** | high if specified | medium |
| Verification clarity | **highest** | medium | low |
| Smallest faithful v0 | **highest** | medium | low |
| Additional framework needed | none | may require “independently valid leg” semantics | substantial |

## 12. Recommended full-capacity rule

**Recommend Option A — atomic explicit bargain.**

### 12.1 Pre-response full capacity

When B already owes A one outstanding favour and A submits `OfferBenefitForFavor(A -> B, benefit)` whose successful meaning requires a new B -> A favour:

- the action is semantically well-formed but world-state infeasible;
- production candidate generation should gate it out;
- if deliberately submitted through the public mechanism-isolation boundary, outcome is `Unable(FavourCapacityFull)`;
- B does not receive a scored Accept/Decline choice;
- no material benefit moves;
- no new favour appears;
- no Gift/Help relabeling occurs.

### 12.2 Capacity lost after acceptance

If the pair slot is free at response selection, B accepts, but another same-cycle compatible-priority event fills B -> A favour capacity before this proposal commits:

- precommit revalidation fails;
- outcome is `InvalidatedAtResolution(FavourCapacityFull)`;
- no material benefit commits;
- no second favour appears.

### 12.3 Successful explicit bargain

If terms are valid, capacity exists, target accepts, and revalidation passes:

- specified material benefit and exactly one new B -> A favour commit atomically;
- history meaning remains `ExplicitBenefitForFavor`.

### 12.4 Relationship-mediated reciprocal help remains different

For independently meaningful `RelationshipMediatedReciprocalHelp`:

- the help itself may commit if valid/feasible/accepted;
- if the B -> A favour slot is already full, no second favour token is created;
- the event remains RelationshipMediatedReciprocalHelp;
- ordinary accepted-help attitude consequences remain those already defined by SPEC.

This is where the current verification phrase “underlying benefit may still commit if independently valid” belongs most clearly.

---

## 13. Unified response / failure classification

| Condition | Classification | Response scoring? | Material effect? | Favour effect | Attitude effect |
|---|---|---:|---:|---|---|
| zero / negative / non-integral grain amount | categorical `InvalidProposal(reason)` validation rejection | no | no | none | none |
| `RepayDebt(amount > remaining)` | categorical `InvalidProposal(AmountExceedsRemainingDebt)` | no | no | none | none |
| CallFavor payload outside response-closed domain | categorical `InvalidProposal(NonCallableAction)` | no | no | original favour unchanged | none |
| valid terms but requested effect infeasible at response/feasibility stage | `Unable(reason)` | no voluntary scoring | no | original favour unchanged | no refusal/fulfilment attitude effect |
| valid explicit benefit-for-favour but pair already full | `Unable(FavourCapacityFull)` | no | no | existing favour unchanged | none |
| valid feasible proposal, target voluntarily rejects | `Declined` | yes | no | called favour remains if this is CallFavor | called-favour refusal -20; otherwise existing action-specific refusal rule |
| target selects fulfil/accept but precondition/capacity is lost before commit | `InvalidatedAtResolution(reason)` | already occurred | no | called favour remains; explicit bargain creates no favour | no refusal/fulfilment effect |
| called-favour requested action commits | committed | yes (Fulfil selected) | yes | called favour consumed | holder -> fulfiller +10 |
| explicit benefit-for-favour commits | committed | yes (Accept selected) | yes, atomically with relation effect | exactly one new favour | only already-defined action-specific effects; do not relabel as Gift |
| relationship-mediated help commits with pair already full | committed | yes where required | yes | no second favour | existing accepted-help attitude effect |

### 13.1 About `InvalidProposal`

This report recommends `InvalidProposal(reason)` as a **validation result**, not a fourth social failed-attempt outcome under §6.7.

A categorically invalid term never becomes a valid proposal/interaction, so it should not be represented as target refusal or physical inability. Diagnostic history/tooling may record the rejection, but no participant response, world effect, or social consequence occurs.

---

## 14. Exact proposed SPEC wording

The following text is proposed for Director-approved promotion. Wording may be editorially integrated without changing its semantic content.

### 14.1 `SPEC-SFL-0001` §2.2 — append

> **v0 grain quantity domain.** Grain is counted in integral v0 units. Personal grain stock is a nonnegative integer. Every action parameter denominated in grain must be a strictly positive integer. Zero, negative, and non-integral action quantities are categorically invalid terms and are rejected before any counterparty response is activated. Invalid terms produce no material or social effect and are not `Declined`, `Unable`, or `InvalidatedAtResolution`. Action-specific semantic bounds may further narrow this domain.

### 14.2 `SPEC-SFL-0001` §3.3 — append after repayment rules

> `RepayDebt(amount)` is valid only when `1 <= amount <= remaining debt`. An amount greater than the remaining debt is invalid rather than clamped, credited, or converted into another transfer meaning. A valid repayment amount may still be infeasible because of the debtor's current grain/reserve state; such world-state failure follows the ordinary `Unable` / revalidation rules.

### 14.3 `SPEC-SFL-0001` §3.4 — append called-favour closure

> **Slice-1 callable-action closure.** A `CallFavor(holder, debtor, requestedAction)` is valid only when the requested action is **response-closed**: after the holder issues the call, the debtor's `FulfilCalledFavor` / `RefuseCalledFavor` choice is the last new voluntary actor choice required for the requested action to reach terminal commit/failure. Any other consent required by the requested action must already be expressed by the holder's call terms. The requested action may not activate another `ResponseDecisionContext`, require a third actor's new voluntary choice, create/demand/transfer/cancel another favour, establish marriage/kinship, or invoke household/role authority.
>
> A fulfilled requested action executes within the debtor's response scope and does not consume or grant the debtor's personal initiative. The holder's voluntary `CallFavor` initiation remains an ordinary personal initiative when generated by personal agency.
>
> The outstanding favour is consumed only when the requested action commits successfully. Successful commit applies holder -> fulfiller attitude +10. `RefuseCalledFavor` yields voluntary `Declined`, leaves the favour outstanding, and applies holder -> refuser -20. `Unable(reason)` or `InvalidatedAtResolution(reason)` leaves the favour outstanding and applies neither fulfilment nor refusal attitude consequence.

### 14.4 `SPEC-SFL-0001` §§3.4–3.5 — append explicit bargain capacity rule

> **Explicit benefit-for-favour atomicity.** `OfferBenefitForFavor` is an atomic explicit bargain between the specified material benefit and creation of exactly one new favour. Pair capacity for that new favour is an action-relevant feasibility/precommit condition. If the ordered-pair favour slot is already occupied, the explicit bargain is infeasible and its material benefit does not commit. If pair capacity is lost after acceptance but before commit, the whole proposal becomes `InvalidatedAtResolution(FavourCapacityFull)`; neither leg commits. On successful commit, the material benefit and new favour commit atomically and history meaning remains `ExplicitBenefitForFavor`.
>
> This atomicity rule does not convert independently meaningful relationship-mediated reciprocal help into a bargain. Such help may commit when otherwise valid even if favour pair-capacity is already full; in that case no additional favour is created and history meaning remains `RelationshipMediatedReciprocalHelp`.

### 14.5 `SPEC-SFL-0001` §5.1 — append validity/feasibility distinction

> Categorical term/domain validity is checked before response activation. An invalid action term is rejected as `InvalidProposal(reason)` for validation/diagnostic purposes and creates no response context. For valid terms, world-state infeasibility yields `Unable(reason)` before voluntary scoring. A valid proposal that was feasible/accepted from the common snapshot but loses an action-relevant precondition before commit yields `InvalidatedAtResolution(reason)`.

### 14.6 `SPEC-SFL-0001` §6.7 — prepend clarification

> `InvalidProposal(reason)` is a pre-interaction validation result for categorically invalid terms and is not a social failed-attempt outcome. The failed-attempt outcomes below apply only after a semantically valid proposal enters the interaction boundary.

### 14.7 `SPEC-SFL-0001` §10 — add invariants

- all grain stocks are nonnegative integers;
- every grain-valued action parameter is a strictly positive integer;
- repayment amount never exceeds remaining debt;
- a categorically invalid proposal never reaches response scoring or produces social/material effects;
- a called-favour payload never opens another voluntary response context in Slice 1;
- called favour is consumed only on successful requested-action commit;
- explicit benefit-for-favour material benefit and new favour commit atomically;
- full favour pair-capacity never converts ExplicitBenefitForFavor into Gift/Help.

---

## 15. Exact verification additions / changes

### 15.1 `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` — VS-SFL-094

Replace/extend the card so it proves the full called-favour lifecycle.

Add subcases:

1. **Response-closed positive payload**
   - use one declared current action shape that satisfies the response-closed rule;
   - called actor has already exercised or selected an ordinary personal initiative in the same cycle;
   - called actor chooses Fulfil;
   - requested effect can still commit because fulfilment is response-scoped;
   - no extra personal initiative is consumed/granted;
   - favour consumes only on commit;
   - holder -> fulfiller +10.

2. **Non-callable nested target**
   - construct a requested action that would require a new third-party response context;
   - `CallFavor` is rejected as `InvalidProposal(NonCallableAction)`;
   - no response scoring; no favour/attitude/material change.

3. **Unable**
   - valid response-closed payload whose world-state feasibility fails before response scoring;
   - outcome `Unable(reason)`;
   - favour remains; no -20/+10.

4. **Voluntary refusal**
   - valid feasible payload;
   - called actor selects Refuse;
   - `Declined`; favour remains; holder -> refuser -20.

5. **Resolution invalidation**
   - valid feasible payload;
   - called actor selects Fulfil;
   - another same-cycle effect removes required capacity before commit;
   - `InvalidatedAtResolution(reason)`;
   - favour remains; requested effect does not commit; no -20/+10.

Add mutants:
- nested response payload allowed;
- fulfil selection consumes favour before requested action commit;
- Unable treated as refusal;
- invalidation consumes favour;
- response-scoped requested action consumes/grants a second personal initiative.

### 15.2 `RESPONSE_DECISION_FAMILY.md` — VS-SFL-102

Amend shared setup and assertions:

- state that the payload satisfies the response-closed callable-action rule;
- assert feasibility of the payload before response scoring;
- assert Fulfil/Refuse does not consume/grant personal initiative;
- assert favour consumption occurs only after requested-action commit;
- add one `Unable` and one `InvalidatedAtResolution` companion run;
- explicitly assert those failure modes are not rewritten as Refuse/Declined.

### 15.3 `CROSS_CUTTING_VERIFICATION_CONTRACT.md` — grain/action boundary matrix

Under Grain / provision / need, add:

- action amount categorical validity: `-1 / 0 / 1`;
- if numeric ingress can express fractions: non-integral / integral boundary;
- repayment semantic bound: `remaining-1 / remaining / remaining+1`;
- valid positive amount with capacity insufficient at response evaluation -> `Unable`;
- same valid accepted amount with capacity lost before commit -> `InvalidatedAtResolution`.

Add always-on invariant checks:

- invalid action terms do not enter response scoring;
- no invalid/zero material action can trigger Gift/Help/Loan/repayment social consequences;
- no over-repayment clamping.

Add semantic mutants:

- zero Gift/Loan creates social consequences;
- negative transfer reverses material direction;
- over-repayment is silently clamped;
- invalid amount is represented as target Decline.

### 15.4 `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` — VS-SFL-091 and VS-SFL-093

For explicit bargain:

1. **capacity available**
   - accepted `OfferBenefitForFavor`;
   - material benefit + exactly one favour commit atomically.

2. **capacity already full**
   - submit through mechanism-isolation boundary;
   - `Unable(FavourCapacityFull)` before response scoring;
   - no material benefit; no second favour; meaning not rewritten to Gift.

3. **capacity lost after acceptance**
   - pair free at response selection;
   - target accepts;
   - another same-cycle transition fills pair slot first;
   - `InvalidatedAtResolution(FavourCapacityFull)`;
   - neither material benefit nor second favour commits.

For relationship-mediated reciprocity:

4. **full slot but independently valid help**
   - qualifying help commits;
   - no second favour;
   - history remains RelationshipMediatedReciprocalHelp;
   - existing help attitude consequence applies.

Replace the ambiguous VS-SFL-093 sentence:

> “The underlying benefit may still commit if independently valid”

with wording that explicitly distinguishes:

- atomic ExplicitBenefitForFavor; and
- independently valid RelationshipMediatedReciprocalHelp.

Add mutants:

- explicit bargain transfers benefit despite full pair slot;
- explicit bargain silently relabels as Gift;
- relationship-mediated help is incorrectly blocked solely because favour slot is full;
- second favour stacks.

---

## 16. New assumption entries

### Recommended: one new assumption entry for grain granularity only

A new assumption is appropriate for the **integer granularity** of v0 grain because that is a controlled laboratory discretization, not a historical claim.

Proposed entry:

### ASM-0014 — Integral v0 grain unit

- **Status:** ACTIVE
- **Assumption:** v0 material grain stock and grain-valued action quantities use integral grain units; action quantities are strictly positive while stock/debt remaining may be zero.
- **Why temporarily needed:** The reference laboratory needs one exact, deterministic, easily verified material unit without a price/weight/fractional economic subsystem.
- **Scope / impact:** SFL v0 grain stock, transfer, loan, repayment, benefit, and later dowry parameter representation.
- **Not authoritative for:** historical Mesopotamian metrology, ration fractions, prices, exchange, later economic simulation granularity.
- **Review / replacement trigger:** introduction of a historically grounded/economic quantity system requiring fractional or typed metrological units.
- **Introduced by:** Director / Master Architect B2 semantic closure, if approved.
- **Related artifacts:** `SPEC-SFL-0001`; lower-level/cross-cutting verification; IMP-0001.

If added, the SPEC header's “Known assumptions” range should become ASM-0001 through ASM-0014.

### Not recommended as assumptions

Do **not** hide the following in the assumptions register:

- called-favour response closure;
- favour-consumption timing;
- explicit bargain atomicity;
- invalid/Unable/Declined/Invalidated classification.

Those are normative mechanics required for deterministic interpretation of accepted action meanings.

---

## 17. Effect on IMP-0001 action scope

If approved, amend `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` without expanding the overall slice.

### §3.4 Personal and response agency

Add:

- categorical proposal-term validity before response activation;
- response-scoped called-favour requested action does not consume/grant called actor personal initiative;
- no nested response contexts from CallFavor payloads in Slice 1.

### §3.5 In-scope action / relation transitions

Clarify:

- `CallFavor` supports only requested actions satisfying the response-closed v0 callable predicate;
- `OfferBenefitForFavor` uses atomic benefit+new-favour semantics;
- relationship-mediated reciprocal help remains independently valid at full pair capacity but cannot stack a favour;
- all in-scope grain-valued parameters use the accepted positive-integer domain;
- `RepayDebt(amount)` may not exceed remaining debt.

### §3.6 Proposal / resolution / commit

Add:

- `InvalidProposal(reason)` is pre-interaction validation, not a social failed-attempt;
- full pair capacity for explicit bargain is feasibility/revalidation state;
- called favour is consumed only with successful requested-action commit.

### §5 Required invariants

Add the invariants listed in §14.7 of this report.

### §6 Acceptance criteria / canonical coverage

Require the amended VS-SFL-091/093/094, VS-SFL-102, and new cross-cutting amount boundaries described above.

### §8 Local decisions permitted

Explicitly state that implementation may choose internal data structures/types, but **may not choose**:

- callable-action membership/completion semantics;
- grain amount validity or over-repayment normalization;
- explicit benefit-for-favour atomicity.

These are now accepted semantic authority if approved.

No generic recursive action framework, negotiation system, command framework, or additional household scope is required.

---

## 18. Exact canonical artifacts / sections requiring amendment if approved

1. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
   - header “Known assumptions” if ASM-0014 is added;
   - §2.2 Grain;
   - §3.3 Debt;
   - §3.4 Favour / obligation;
   - §3.5 Transfer meanings;
   - §5.1 Response decision contexts;
   - §6.7 Failed attempts;
   - §10 Invariants.

2. `registers/ASSUMPTIONS_REGISTER.md`
   - add ASM-0014 only if Director approves integer granularity as a replaceable lab assumption.

3. `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
   - VS-SFL-091;
   - VS-SFL-093;
   - VS-SFL-094;
   - family semantic mutants.

4. `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
   - VS-SFL-102;
   - family semantic mutants if needed.

5. `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
   - §1 Always-on invariants;
   - §2 Boundary matrices;
   - generated-operation validity rules / semantic mutants as applicable.

6. `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
   - §§3.4–3.6;
   - §5;
   - §6;
   - §8.

No ADR amendment is required: ADR-0002 and ADR-0004 already permit these bounded domain rules and preserve the required actor/resolution architecture.

---

## 19. Strongest disconfirmation of the recommendations

### 19.1 Called favour — strongest challenge

The strongest challenge is that “one otherwise-feasible ordinary action” may have been intended to include ordinary actions that require additional target responses; the response-closed rule narrows that surface.

Why the recommendation still wins for v0:

- accepted authority does not define response-generated response closure;
- B2 expressly directs the smallest faithful rule rather than a generic action framework;
- the narrowing is explicit, reversible, and local to v0;
- it preserves actor autonomy rather than bypassing downstream consent;
- later expansion can add nested-response composition only when a concrete use case requires it.

### 19.2 Grain integers — strongest challenge

The strongest challenge is premature discretization: future economic/metrological work may require fractional quantities.

Why the recommendation still wins for v0:

- all current accepted material rules are unit-like and exact;
- positive integer quantities minimize representation and oracle ambiguity;
- the rule is explicitly scoped to v0 and can be recorded as a replaceable lab assumption;
- it avoids floating/fixed-point complexity before any semantic need exists.

### 19.3 Atomic explicit bargain — strongest challenge

The strongest challenge is the current verification sentence that the underlying benefit “may still commit if independently valid,” which supports a non-atomic reading.

Why the recommendation still wins:

- verification artifacts are subordinate to accepted SPEC semantics;
- the action is explicitly named BenefitForFavor and the target knowingly accepts those terms;
- silently dropping the promised favour while retaining the benefit changes the accepted bargain's meaning and risks collapsing it into Gift/Help;
- the independently-valid-benefit idea remains useful and coherent for RelationshipMediatedReciprocalHelp, where the help has independent semantic meaning.

---

## 20. Director approval

**Required: YES.**

Each recommendation selects among multiple still-plausible observable semantics in accepted `SPEC-SFL-0001`:

- what actions a favour can call and how fulfilment composes with initiative/response semantics;
- the admissible grain-quantity domain and over-repayment rule;
- whether an explicit benefit-for-favour bargain is atomic at pair capacity.

These are not implementation-local choices and should be approved before canonical promotion or release of IMP-0001.

---

## 21. Residual risks / deferred questions

1. **Future nested called actions:** If later slices require a favour to compel an action toward a third actor, a separate design must define response-generated proposal closure and termination. This report intentionally does not build that framework now.

2. **Current action applicability table:** After approval, the Master Architect should enumerate each current Slice-1 action shape against the response-closed predicate so the implementation packet does not leave membership implicit. That table is mechanical application of the approved rule, not a new semantic choice.

3. **Fractional historical quantities:** Integer grain units are a v0 abstraction only. A later economic/metrological subsystem may replace the quantity representation while preserving positivity and action-specific semantic bounds.

4. **Explicit-benefit attitude detail:** This B2 repair does not add a new attitude increment for `ExplicitBenefitForFavor`. Canonical promotion should preserve only already-defined action-specific attitude effects and must not inherit Gift's effect merely because transfer code is shared.

5. **InvalidProposal observability:** The implementation should expose categorical rejection to fixtures/diagnostics without turning invalid terms into participant-visible social events. Exact API shape remains implementation-local.

6. **Later dowry:** The positive-integer amount rule can be shared now, but mediated dowry funding/authority remains later-slice and should not be pulled into IMP-0001.

---

## 22. Final recommendation

Approve the three-rule package as a single minimal Slice-1 closure:

1. **response-closed CallFavor payloads, no nested response contexts, response-scoped requested execution, consume favour only on successful commit;**
2. **strictly positive integer grain-valued action quantities, no over-repayment/clamping, categorical validity distinct from feasibility and later invalidation;**
3. **atomic ExplicitBenefitForFavor at favour pair capacity, while independently meaningful relationship-mediated help may still commit without stacking another favour.**

This package closes S1-SEM-03/04/05 without reopening architecture, inventing a generic action/command framework, or expanding IMP-0001 beyond the already commissioned lower-level slice.
