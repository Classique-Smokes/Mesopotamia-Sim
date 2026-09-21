# TRES-0010 Wave B Task 5 — A-PROSECUTION Action / Favour Closure

**Task ID / role:** TRES-0010B-A-PROSECUTION / prosecution-falsification  
**Status:** COMPLETE  
**Canonical baseline ref:** `tres-0010-wave-b-baseline`  
**Resolved baseline SHA:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`  
**Return branch / workspace:** `tres-0010/wb-a-prosecution`  
**Model / configuration:** GPT-5.6 Sol  
**Tools used:** GitHub repository connector only  
**External research:** no  
**Assigned Wave-A reports read:** TRES-0010B, TRES-0010E, TRES-0010H only  
**Opposing Wave-B return read before completion:** **no**  
**Unrelated Wave-A returns read:** **no**  
**Canonical project files modified:** no; this report is the only write

## 1. Scope and method

This review adjudicates only the four action/favour-closure findings assigned by the Wave-B packet:

1. H-001 / E-F03 — called-favour payload and nested response/initiative semantics;
2. E-F02 — general personal candidate-generation policy versus transition semantics;
3. E-F05 — explicit benefit-for-favour at the one-favour ordered-pair limit;
4. B-002 — validity domain for grain-valued action quantities.

For each finding I first reconstructed the smallest inherited counterexample, then attempted to defeat it using the frozen accepted authority. I did not treat Wave-A severity labels as evidence.

Primary canonical artifacts used:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §§2.2, 3.3–3.6, 5, 5.1, 9.1–9.2, 10;
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` §§3.4–3.6, 5–9;
- `plans/verification/SFL_V0/README.md`;
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` VS-SFL-091 through VS-SFL-094 and VS-SFL-098;
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md` VS-SFL-102 and VS-SFL-105;
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`;
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` §§1–2, 5.

## 2. Result matrix

| Challenged finding | Verdict | Slice scope | Confidence |
|---|---|---|---|
| H-001 / E-F03 — CallFavor payload / nested action semantics | **CONFIRMED_REPAIR_BEFORE_SLICE1** | Slice 1 | medium-high |
| E-F02 — general personal candidate generation | **ALREADY_RESOLVED_BY_AUTHORITY** | Slice 1 handoff; no surviving semantic gap | high |
| E-F05 — explicit benefit-for-favour at full pair capacity | **ALREADY_RESOLVED_BY_AUTHORITY** | Slice 1 | high |
| B-002 — grain-valued quantity validity domain | **CONFIRMED_REPAIR_BEFORE_SLICE1** | Slice 1 | high |

The prosecution case therefore does **not** sustain the inherited broad claim that action/favour closure contains a demonstrated Slice-1 blocker. Two narrower pre-code repairs survive; two findings are closed by already-accepted authority.

---

## 3. H-001 / E-F03 — called-favour payload and nested action semantics

### Verdict

**CONFIRMED_REPAIR_BEFORE_SLICE1**

The inherited **blocker** thesis is too broad. Accepted authority already determines more of the composition than H-001 credited. However, one real Slice-1 semantic boundary remains unspecified: the positive membership of the `ordinary action` payload domain accepted by `CallFavor`.

### Inherited claim

Wave A argued that a valid called favour can require a second ordinary action whose normal path either:

- uses the fulfiller's personal initiative; or
- creates a new proposal requiring a third party's response;

and that the accepted artifacts therefore leave multiple incompatible completion models.

### Serious disconfirmation route

The strongest defense is obtained by composing the accepted response and process rules literally.

1. SPEC §3.4 allows a favour to request one **otherwise-feasible ordinary action**, while forbidding impossible actions, compelled marriage/kinship, and favour recursion.
2. SPEC §5.1 says **every incoming proposal whose semantics require target choice** activates a `ResponseDecisionContext(target, proposal)`.
3. The same section says response contexts do not consume or grant personal initiative and may activate multiple times for one actor in one cycle.
4. SPEC §9.1 fixes a responses phase before central resolution; `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §1 requires every immediate proposal to reach a terminal outcome in the same cycle.
5. VS-SFL-094 says a fulfilled called favour's requested action commits through **ordinary proposal/resolution semantics**.
6. VS-SFL-102 keeps the requested action subject to central revalidation and satisfies the favour only on successful commit.
7. VS-SFL-105 proves a substantive response-scoped help transfer can coexist with the same actor's already-selected personal initiative. The response neither consumes nor cancels that initiative.

Those clauses defeat two major branches of H-001:

- **initiative:** fulfilment is a response context, not a second voluntary personal initiative. Accepted response semantics already permit a response to cause substantive world effects in addition to the actor's personal initiative;
- **third-party response:** if the requested ordinary action itself produces an incoming proposal to C, the universal §5.1 response rule applies to C. Same-cycle terminality excludes silent deferral, and ordinary proposal semantics exclude bypassing C's autonomy. The coherent accepted composition is therefore a same-cycle additional response context followed by ordinary central revalidation.

The inherited trace is not enough to prove that the scheduler/queue mechanism itself is semantic. IMP-0001 §8 explicitly leaves internal proposal/transition structure local so long as accepted semantics are preserved.

### Smallest surviving counterexample

The surviving gap is not the existence of nested response handling; it is the **positive callable-action grammar**.

Take an outstanding B -> A favour and a Slice-1 implementation with the required action meanings:

- `Farm`;
- gift/help request/offer;
- loan request/offer / repayment;
- `OfferBenefitForFavor`;
- relationship-mediated reciprocal help;
- residence move/invite;
- favour cancellation operations.

SPEC §3.4 says only “one otherwise-feasible ordinary action” and supplies exclusions, but no accepted artifact normatively tags which of the above action variants are members of `ordinary action`.

Two implementations can therefore agree on all explicit exclusions yet disagree on, for example, whether a called favour may carry:

- `Farm`;
- `RepayDebt`;
- a third-party `RequestGiftOrHelp`;
- `OfferBenefitForFavor` (which would interact with the ban on favours creating/demanding another favour);
- reciprocal favour cancellation.

The mechanism-isolation card can pass using one simple payload while these other payloads remain observably divergent.

### Why authority does not fully close this narrower issue

The phrase `ordinary action` appears as a semantic category but is not defined as a closed Slice-1 action type/domain. The explicit exclusions do not uniquely determine the positive set.

This is smaller than H-001's original blocker claim because the accepted process rules already provide a coherent composition for initiative-independent response execution and third-party response activation **once a payload is established as legal**.

### Exact unresolved choice

Which in-scope Slice-1 action variants are legal values of a called-favour requested action, after applying the explicit impossibility/marriage/kinship/favour-recursion exclusions?

No experiment is needed. This is an authority/type-domain clarification before implementation.

### Scope

Slice 1: `CallFavor / fulfil / refuse / reciprocal cancellation` is explicitly in IMP-0001 §3.5.

### Confidence

**Medium-high.** The process-composition disconfirmation is strong; the remaining `ordinary action` membership boundary is genuinely not explicit.

---

## 4. E-F02 — general personal candidate generation versus transition semantics

### Verdict

**ALREADY_RESOLVED_BY_AUTHORITY**

The inherited counterexample compares two broad autonomous policies that IMP-0001 does not require the coding agent to invent.

### Inherited claim

Wave A proposed:

- implementation A generates gift/loan/request candidates toward every mechanically eligible actor;
- implementation B generates only narrow need/relationship-triggered candidates;

and argued that both satisfy transition cards while producing different autonomous simulations.

### Serious disconfirmation route

The accepted verification package explicitly separates **transition semantics** from **closed-loop actor policy**.

`plans/verification/SFL_V0/README.md` defines:

- **mechanism-isolation** cards: fixtures may submit valid proposals through the public proposal/resolution boundary;
- **closed-loop** cards: actual decision contexts must generate actions under a pinned deterministic profile.

IMP-0001 repeats that separation:

- §3.5 requires the lower-level **action/relation meanings**;
- §3.4 requires candidate generation/gates and the **in-scope personal scoring profiles**;
- §6 fixture discipline requires mechanism-isolation tests to enter through the public proposal/response/resolution boundary;
- §9 requires escalation rather than invented social semantics when a canonical scenario cannot be executed.

SPEC §5 likewise says the reference scorer is separable from action/world semantics and that coefficients are laboratory configuration. ADR-0002 leaves exact action repertoire/tier content open at the architectural level.

Therefore Slice 1 does not require a complete default autonomous generator for every transition meaning. It requires:

1. the transition semantics/public proposal boundary for mechanism-isolation meanings; and
2. real candidate generation/gating where a canonical closed-loop profile/card actually pins that behavior.

### Smallest reconstruction of the claimed counterexample

Suppose code implements `OfferLoan` transition semantics and public proposal handling but no general autonomous “offer loans to whom?” production policy because no assigned closed-loop profile requires one.

That implementation is not incomplete merely because a broad autonomous loan policy is absent. A mechanism-isolation card may submit the valid proposal through the public boundary.

Conversely, if the coder adds implementation A or B as a general policy without accepted/profile authority, that is **additional semantics**, not a forced choice.

### Why the inherited gap fails

The A-versus-B divergence occurs outside the commissioned/pinned policy surface. The verification package's card-level distinction is exactly the authority needed to prevent transition semantics from being mistaken for universal autonomous candidate-generation policy.

The packet could be more explicit in prose, but the accepted authority is sufficient to tell a coding agent not to invent either broad policy.

### Exact unresolved choice

None required for Slice 1. Future autonomous policy beyond pinned closed-loop profiles remains intentionally open.

### Scope

No surviving Slice-1 gap. This does not claim future general personal policy is complete.

### Confidence

**High.**

---

## 5. E-F05 — explicit benefit-for-favour at full ordered-pair favour capacity

### Verdict

**ALREADY_RESOLVED_BY_AUTHORITY**

The canonical Stage-3 transfer/favour cards already separate benefit commitment from favour creation.

### Inherited claim

State:

- B already owes A one favour;
- A offers B a material benefit explicitly for one new favour;
- B accepts.

Wave A identified two plausible implementations:

1. the bargain is infeasible and no benefit transfers;
2. the benefit commits but no second favour is created.

### Serious disconfirmation route

VS-SFL-091, **Explicit benefit-for-favour**, states for an accepted `OfferBenefitForFavor`:

- “the specified material/benefit effect commits”;
- “exactly one B -> A Favour is created **if pair-capacity permits**.”

VS-SFL-093 then states at the one-per-ordered-pair boundary:

- another favour-creating benefit cannot stack a second token;
- the underlying benefit may still commit if independently valid;
- favour cardinality remains one.

SPEC §3.4 supplies the invariant of at most one outstanding favour per ordered pair; it does not say pair saturation retroactively invalidates every beneficial effect associated with a favour-creating meaning.

### Smallest adjudicated trace

1. B -> A favour already exists.
2. A valid `OfferBenefitForFavor` proposal reaches acceptance with an otherwise valid benefit effect.
3. The benefit effect commits under VS-SFL-091.
4. Pair capacity does not permit a second B -> A favour, so no second token is created.
5. Cardinality remains one.

The “whole accepted bargain must fail solely because the favour slot is full” branch is not supported by the canonical card wording.

### Why authority closes it

The conditional phrase **“if pair-capacity permits”** is attached to favour creation, while benefit commitment is separately asserted. That is the exact distinction needed by the counterexample.

No new semantic choice is required.

### Exact unresolved choice

None for this finding.

### Scope

Slice 1; `OfferBenefitForFavor` and favour cardinality are explicitly required.

### Confidence

**High.**

---

## 6. B-002 — grain-valued action quantity validity domain

### Verdict

**CONFIRMED_REPAIR_BEFORE_SLICE1**

The disconfirmation attempt failed. The frozen authority constrains resulting stocks and some contextual capacities, but it does not define a general positive/nonzero action-amount domain or over-repayment rule.

### Inherited claim

Wave A argued that zero, negative, and over-repayment amounts can pass through action meanings because accepted authority specifies positive examples but not the normative numeric domain.

### Serious disconfirmation route

I searched the frozen authoritative/verification surface for a rule equivalent to:

- transfer/loan/dowry/repayment amount must be > 0;
- zero-valued action is invalid;
- repayment amount must be <= remaining debt;
- over-repayment must be rejected rather than clamped/credited;
- a shared `GrainAmount` type excludes zero/negative values.

No such normative rule appears.

What **is** present:

- SPEC §2.2 describes grain as fungible and gives positive example quantities;
- SPEC §3.3 says debt has original and remaining amounts and repayment may be partial/complete;
- repayment must leave debtor with at least 2 grain;
- SPEC §10 / IMP-0001 §5 require personal grain never negative and every grain change to have an explicit source/sink/zero-sum transfer;
- VS-SFL-091 uses 1-grain examples;
- VS-SFL-092 tests repayment amounts against the debtor's 2-grain reserve and later repays “all remaining balance”;
- the cross-cutting boundary matrix does not include zero/negative action amounts or repayment-above-balance boundaries.

Those are not equivalent to a positive action-amount domain.

### Smallest valid counterexamples

#### A. Zero gift

1. A submits `OfferGift(A -> B, 0)`.
2. No accepted gate says amount 0 is invalid.
3. Personal grain remains nonnegative and material accounting is trivially zero-sum.
4. If the proposal is otherwise accepted, the semantic event is still named Gift.
5. SPEC §3.1's accepted voluntary gift/help consequence can therefore yield B -> A attitude +10 unless implementation invents a zero-amount rejection.
6. The same event category is also used elsewhere as meaningful support evidence.

The key point is not that zero *should* count; it is that the current authority does not mechanically prevent it from reaching the social consequence.

#### B. Negative transfer

If actor stocks are large enough, `OfferGift(A -> B, -1)` can be implemented as arithmetic that increases A and decreases B while keeping both nonnegative and preserving a zero-sum delta. The always-on invariants therefore do not themselves reject the sign reversal.

Different reasonable implementations may reject, reverse, clamp, or accidentally accept it.

#### C. Over-repayment

For debt remaining 4, a `RepayDebt(5)` request is not given a normative disposition. Possible implementations can reject, clamp to 4, create remaining -1, or treat excess as a separate transfer. Only the first two might preserve sensible debt meaning, but the authority does not select between them.

### Why existing authority does not close it

Result-state invariants (`grain >= 0`, source/sink accounting, reserve) constrain outcomes, not the validity domain of the requested amount.

Positive examples are evidence of intent, not a categorical precondition.

A choice such as “use unsigned integers” would still admit zero and would be an implementation representation choice, not an accepted semantic answer to over-repayment.

### Exact unresolved choice

The canonical validity/failure domain for quantity-bearing Slice-1 actions, including at least:

- zero amount;
- negative amount;
- repayment greater than remaining debt.

The repair should be authoritative enough that all implementations classify the same proposal as valid/invalid and produce the same failure semantics. This report does not select a new domain rule.

### Scope

Slice 1: gift/help, loan, repayment, benefit-for-favour, marriage dowry state, grain accounting, and related social consequences are all in or adjacent to the lower-level kernel.

### Confidence

**High.**

---

## 7. Final prosecution disposition

Task 5 does not support a general “action closure blocks Slice 1” conclusion.

The surviving issues are narrower:

1. **CalledAction domain closure** — process composition is substantially already determined, but the positive set of legal called-favour payload action variants is not explicitly closed.  
   **Disposition:** `CONFIRMED_REPAIR_BEFORE_SLICE1`.

2. **Grain amount domain** — no accepted positive/nonzero/over-repayment validity rule was found.  
   **Disposition:** `CONFIRMED_REPAIR_BEFORE_SLICE1`.

The other challenged findings are closed by accepted authority:

- broad autonomous candidate generation is not required beyond pinned closed-loop policy; mechanism-isolation transitions can enter through the public proposal boundary;
- full ordered-pair favour capacity suppresses additional favour creation but does not, by itself, invalidate an otherwise valid underlying benefit under the canonical cards.

No B2 experiment is indicated by this prosecution report. The surviving questions are semantic/type-boundary clarifications, not uncertain platform behavior.

## 8. Independence statement

I did not read `tres-0010/wb-a-defense` or any opposing Wave-B return before finalizing this report. I did not read unrelated Wave-A returns. The only Wave-A reports consulted were the packet-assigned TRES-0010B, TRES-0010E, and TRES-0010H reports.
