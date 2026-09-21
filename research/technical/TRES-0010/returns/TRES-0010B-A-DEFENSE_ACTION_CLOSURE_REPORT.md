# TRES-0010 Wave B — Action / Favour Defense Adjudication

## Run provenance

- **Task ID / role:** `TRES-0010B-A-DEFENSE` — Defense / lower-level action and favour closure
- **Wave-B task number:** 6
- **Canonical baseline ref:** `tres-0010-wave-b-baseline`
- **Resolved canonical baseline SHA:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Return branch/workspace:** `tres-0010/wb-a-defense`
- **Return-branch starting SHA:** `f25407a9cbf09e501601d52ad7a2df111fa5c491` (identical to frozen baseline before this return)
- **Model/configuration:** GPT-5.6 Sol
- **Tools used:** GitHub repository connector for branch discovery, frozen-ref file retrieval, assigned Wave-A report retrieval, and isolated return write
- **External research:** no
- **Assigned Wave-A reports read:** TRES-0010B, TRES-0010E, TRES-0010H
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**
- **Canonical project files modified:** no; this advisory return is the only repository write

## Scope and evidence discipline

This review adjudicates only the four findings assigned by the Wave-B packet:

1. TRES-0010H-H001 / TRES-0010E-F03 — called-favour action composition;
2. TRES-0010E-F02 — general personal candidate generation;
3. TRES-0010E-F05 — explicit benefit-for-favour at favour-capacity limit;
4. TRES-0010B-B002 — grain-valued action quantity validity.

Wave-A reports are treated as inherited allegations, not authority. Conclusions below were checked against the frozen accepted/canonical artifacts, principally:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`;
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`;
- `registers/ASSUMPTIONS_REGISTER.md`;
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`;
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`;
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`;
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`;
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`.

No opposing Wave-B argument was consulted.

## Result matrix

| Challenged finding | Wave-B defense result | Slice-1 effect | Confidence |
|---|---|---|---|
| H-001 / E-F03 — called-favour callable action / nested response and initiative composition | **CONFIRMED_BLOCKER_SLICE1** | Current IMP-0001 requires CallFavor plus VS-SFL-094/102, but accepted authority does not determine how an ordinary requested action composes with response and initiative semantics. | High |
| E-F02 — general personal candidate generation broader than pinned policy | **ALREADY_RESOLVED_BY_AUTHORITY** | No general autonomous action-generation policy is required for Slice 1 beyond the explicitly configured closed-loop contexts; transition cards may use the public mechanism-isolation boundary. | High-medium |
| E-F05 — explicit benefit-for-favour when the ordered-pair favour slot is occupied | **CONFIRMED_REPAIR_BEFORE_SLICE1** | The edge is in the Slice-1 action/cardinality domain and accepted semantic authority does not select whether pair capacity defeats the bargain or only suppresses the new favour effect. | Medium-high |
| B-002 — grain-valued action amount validity | **CONFIRMED_REPAIR_BEFORE_SLICE1** | Zero-valued lower-level transfers/loans are not rejected by any explicit accepted amount-domain rule and can change Slice-1 social state. | High |

---

## 1. H-001 / E-F03 — Called-favour ordinary-action composition

**Result:** `CONFIRMED_BLOCKER_SLICE1`  
**Confidence:** high

### Strongest defense attempted

The strongest closure route is to read `SPEC-SFL-0001` §3.4 narrowly:

- a favour may request only an “otherwise-feasible ordinary action”;
- impossible actions remain impossible;
- marriage/kinship cannot be compelled;
- favours cannot create/demand/transfer another favour.

One might then argue that any action which would require an unavailable initiative or a further response is simply not “otherwise feasible.” A second possible defense is that `ResponseDecisionContext` itself is explicit: fulfilment is a response, and responses do not consume the target’s personal initiative.

That defense does not fully close the finding.

### Reconstructed smallest counterexample A — third-party response

1. B owes A one outstanding favour.
2. C is a third actor.
3. A uses `CallFavor(A -> B)` requesting an otherwise ordinary residence proposal by B toward C’s dwelling.
4. B’s response context selects `FulfilCalledFavor`.
5. Residence change is proposal-based under SPEC §3.6; C’s acceptance is required.
6. SPEC §9.1 places ordinary deliberation before the response phase, while §5.1 says every incoming proposal requiring target choice activates a response context.
7. No accepted clause states whether the action produced by B’s fulfil response:
   - may activate a new C response context in the same response phase;
   - is ineligible because it would require another response;
   - is deferred;
   - or has some other terminal treatment.

Directly committing the residence effect is not available as a defense because SPEC §3.6 and ADR-0002 preserve the named counterpart’s response boundary.

### Reconstructed smallest counterexample B — ordinary initiative accounting

1. B owes A one favour.
2. B has already selected its one ordinary personal initiative in the cycle.
3. A calls the favour requesting an otherwise ordinary initiative-bearing action such as Farm.
4. B’s response context selects fulfilment.
5. SPEC §5.1 says the response itself does not consume or grant personal initiative.
6. But VS-SFL-090 states that a committed Farm consumes personal initiative, and VS-SFL-098 treats Farm/Gift/Loan/Marriage/Residence/Communication initiation as the one substantive voluntary initiative.

The accepted artifacts do not say whether the requested ordinary action is:
- response-scoped and exempt from its ordinary initiative accounting;
- infeasible once the ordinary initiative is already selected/used;
- a replacement for the personal selection;
- or an additional action opportunity.

Treating one of these as implicit would invent the exact semantic rule under challenge.

### Why the defense fails

`SPEC-SFL-0001` §5.1 resolves **who chooses Fulfil/Refuse**, the snapshot used, and the fact that a response does not consume personal initiative. It does not define a response-generated proposal graph or a special completion unit for the ordinary action requested by a favour.

`SPEC-SFL-0001` §9.3 automatic-reaction closure does not close the gap: a new counterparty decision is voluntary response agency, not an automatic semantic reaction.

VS-SFL-094 and VS-SFL-102 require the requested action to remain subject to ordinary proposal/resolution semantics, but neither names a requested-action class that avoids the composition problem.

### Exact remaining undefined choice

Accepted authority does not determine:

- the positive callable ordinary-action domain for `CallFavor`;
- whether fulfilment-generated ordinary actions retain their ordinary personal-initiative accounting;
- whether a fulfilment-generated proposal may activate another `ResponseDecisionContext` in the same cycle and, if so, what the response-closure rule is;
- how favour satisfaction relates to a requested action that is subsequently Declined, Unable, or Invalidated.

No callable-action whitelist or recursive response rule is supplied by this defense.

### Slice-1 impact

This affects current IMP-0001 directly:

- §3.5 explicitly requires `CallFavor / fulfil / refuse / reciprocal cancellation`;
- §6 requires VS-SFL-094 and VS-SFL-102 within the mandatory lower-level/response coverage;
- §9 explicitly requires escalation when a response/action transition is underspecified or a canonical card cannot be made executable without adding social semantics.

Therefore the current Slice-1 packet cannot implement this feature faithfully without an additional semantic or scope decision. If a later authority were to remove the whole feature from Slice 1, the gap could be deferred, but that is not the current frozen packet and this return does not design such a change.

---

## 2. E-F02 — General personal candidate generation

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high-medium

### Strongest Wave-A counterexample reconstructed

Wave A contrasts two plausible autonomous policies:

- one implementation generates broad OfferGift/OfferLoan/RequestGift candidates toward every mechanically eligible actor;
- another generates a much narrower need/relationship-triggered set.

Those policies can lead to different long-run trajectories while sharing the same transition semantics and scorer.

That observation is true, but it does not establish a missing Slice-1 requirement.

### Where the defense succeeds

The accepted architecture and verification contract deliberately do **not** require one complete general personal candidate-generation policy here.

1. **ADR-0002** fixes the architecture — contextually relevant/accessibly generated candidates, then gating and scoring — while explicitly leaving tier content, exact soft-gate semantics, action repertoire, and related policy details undecided.
2. **SPEC-SFL-0001 §5** calls the v0 scorer a reference policy, keeps action/world semantics separable from actor policy, and says coefficients/configuration are laboratory choices.
3. **REFERENCE_SCORING_PROFILES.md** is explicitly a canonical Stage-3 verification configuration, permits scenario-specific target bindings, and requires production generation/gating only for the closed-loop profile being exercised.
4. **LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md** explicitly permits mechanism-isolation cards to submit proposals through the public proposal/response/resolution boundary.
5. **CROSS_CUTTING_VERIFICATION_CONTRACT.md §6** likewise permits semantically valid proposal submission for mechanism-isolation cards.
6. **IMP-0001 §1** requires enough agency to execute the in-scope cards, §3.4 requires the **in-scope** scoring profiles, while §3.5 separately requires the lower-level action/relation **transition meanings**. The packet does not state that every §3.5 transition must also receive a unique general autonomous generator in Slice 1.

The two Wave-A policies therefore differ in behavior outside the policy/configuration coverage actually claimed by Slice 1. They do not show two incompatible implementations of a required general generator, because no such general generator is part of the accepted completion claim.

### Smallest alleged counterexample and where it becomes invalid

Take a mechanism-isolation gift card and ask whether the production actor should spontaneously generate OfferGift toward every eligible person or only toward a relationship-selected target.

The card does not ask that question: its fixture may submit the semantically valid proposal through the public boundary. Conversely, a closed-loop profile such as SCORE-VP-006/VS-SFL-105 does require production candidate generation for its declared context and target conditions; there the implementation must obey that profile/card rather than invent a global policy.

The counterexample becomes invalid when it treats “implement the transition meaning” as equivalent to “define a universal autonomous generation policy for that transition.”

### Exact remaining undefined choice

A full unconfigured autonomous personal candidate-generation policy remains intentionally unspecified. That is a real open modeling choice, but it is outside the Slice-1 claim being verified here.

### Slice-1 impact

No semantic repair is required for this finding. The implementation must avoid presenting a locally invented broad generator as accepted project policy and must implement the generator/gates actually required by the configured closed-loop cards. That is scope discipline already established by authority, not a missing simulation rule.

---

## 3. E-F05 — Explicit benefit-for-favour at favour-capacity limit

**Result:** `CONFIRMED_REPAIR_BEFORE_SLICE1`  
**Confidence:** medium-high

### Strongest defense attempted

There are two pieces of text that almost close the issue:

- SPEC §3.4 gives an absolute maximum of one outstanding favour per ordered pair.
- VS-SFL-091 says that an accepted explicit benefit-for-favour commits its specified benefit and creates exactly one favour “if pair-capacity permits.”
- VS-SFL-093 says another favour-creating benefit cannot stack a second token and that the underlying benefit may still commit “if independently valid.”

A defense can therefore argue that capacity simply suppresses creation of a second favour while leaving the material benefit intact.

That reading is plausible but not uniquely authoritative.

### Reconstructed smallest counterexample

1. B already owes A one favour.
2. A submits `OfferBenefitForFavor` to B for a new specified benefit in exchange for one new B -> A favour.
3. B knowingly accepts the stated bargain.

The one-favour invariant forbids creation of the promised new token. Two results remain compatible with the frozen semantic text:

- pair capacity is an action-relevant feasibility/precommit condition for the explicit bargain, so the bargain cannot commit as stated; or
- the benefit commits but no second favour is created.

### Why the defense cannot close it

SPEC §3.5 requires **explicit benefit-for-favour** to remain a distinct transfer meaning. It never says that, when its bargained-for favour cannot be created, the transfer either must fail atomically or may remain as a unilateral material effect.

SPEC §5.1 says infeasibility precedes voluntary response scoring, while §9.2 requires revalidation against action-relevant relations/claims. Those clauses make the “whole bargain is infeasible” reading viable.

The verification wording makes the “benefit can survive” reading viable, but the same verification files declare themselves verification design with SPEC as their semantic source. The phrase “if independently valid” does not define whether the benefit leg of this explicit bargain is independently valid when its stated consideration cannot be produced.

Choosing either outcome would therefore add semantic atomicity/feasibility meaning not present in the accepted specification.

### Exact remaining undefined choice

For an explicit benefit-for-favour proposal when the ordered-pair favour slot is already occupied, accepted semantics do not determine whether pair capacity:

- makes the explicit bargain infeasible / prevents its material commit; or
- only prevents creation of the additional favour while allowing the material benefit to commit.

The corresponding failure/commit classification is therefore also not uniquely determined.

### Slice-1 impact

IMP-0001 §3.5 includes `OfferBenefitForFavor`; §5 requires the one-favour cardinality invariant; the cross-cutting contract requires first-versus-additional-favour boundary coverage. This is a bounded Slice-1 semantic edge, not a later household concern.

---

## 4. B-002 — Grain-valued action quantity validity

**Result:** `CONFIRMED_REPAIR_BEFORE_SLICE1`  
**Confidence:** high

### Strongest defense attempted

The strongest defense is semantic-domain inference:

- SPEC §2.2 consistently describes grain in positive integer-like units;
- the accepted cards use positive amounts;
- SPEC §10 requires nonnegative personal grain and explicit source/sink or zero-sum accounting;
- debt repayment is described as partial or complete, which strongly disfavors overpayment.

Those constraints can reject some malformed cases by ordinary meaning — for example, an amount greater than a remaining debt is difficult to characterize as either partial or complete repayment.

They do not supply a general accepted amount-validity domain.

### Reconstructed smallest surviving counterexample

Use a zero-valued gift rather than a negative amount:

1. A submits `OfferGift(A -> B, 0)`.
2. B accepts.
3. No personal grain becomes negative.
4. The material-accounting invariant is not violated: the zero delta is trivially balanced.
5. No accepted rule states that amount 0 makes the proposal invalid.
6. If treated as a committed Gift under §3.1/§3.5, the event can still trigger the accepted-gift attitude consequence B -> A +10.

The same structural problem appears for a zero-value loan: the specification says a successful loan creates a Debt and applies borrower -> lender +5, but no explicit amount gate says that zero cannot instantiate that action.

The later household-formation consequence identified by Wave A is not needed to make this a Slice-1 issue; the lower-level relationship/attitude result already differs.

### Why the defense fails

- SPEC §10 constrains resulting balances and accounting, not proposal-amount validity.
- ASM-0003 fixes Farm yield, consumption, typical stocks, and repayment reserve; it does not define a shared positive amount domain.
- CROSS_CUTTING_VERIFICATION_CONTRACT.md tests grain-stock/reserve/need thresholds but does not define or test zero/negative transfer amount or excess repayment as a general action-domain rule.
- No accepted concrete type such as a positive-only `GrainAmount` is declared.
- Treating a future C# type/constructor guard as the answer would make an implementation choice decide whether a zero-value event can create social consequences, which is not safely local/reversible.

The defense therefore cannot reject the zero-value trace without supplying the amount-validation rule the task packet expressly forbids it to invent.

### Exact remaining undefined choice

Accepted authority does not define the validity domain and per-action bounds for grain-valued proposal amounts: at minimum, whether zero is a valid Gift/Help/Loan/Benefit amount and how amount validity is classified before response/commit. Repayment text constrains “partial or complete” semantics but does not establish a shared lower-level amount domain.

### Slice-1 impact

This is directly in IMP-0001 §3.5 and in Slice-1 attitude/debt semantics. Canonical positive examples remain executable, but the production transition boundary cannot claim a closed accepted action domain while this input class is left to implementation invention.

---

## Overall defense conclusion

The cluster does **not** support a blanket “action/favour semantics are underspecified” conclusion.

- The E-F02 candidate-generation allegation is closed at Slice 1 by the existing distinction between configured closed-loop agency and mechanism-isolation transition verification.
- The called-favour composition allegation survives defense and is the only assigned finding that currently prevents faithful execution of an explicitly required Slice-1 feature/card family without a new semantic or scope decision.
- The explicit benefit-for-favour capacity edge and grain-amount domain are narrower but still affect observable Slice-1 semantics and therefore require authoritative clarification before the corresponding production boundaries are treated as closed.

This return does not select repair semantics, design a callable-action whitelist, define recursive response closure, invent candidate-generation heuristics, or invent amount-validation rules. Those choices remain outside this defense task.
