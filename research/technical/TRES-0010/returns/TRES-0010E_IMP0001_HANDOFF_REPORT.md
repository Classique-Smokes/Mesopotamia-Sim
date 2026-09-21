# TRES-0010E — IMP-0001 Handoff Ambiguity Audit

## Run provenance

- **Task ID:** TRES-0010E
- **Frozen baseline ref:** tres-0010-review-baseline
- **Resolved baseline commit:** 8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac
- **Assigned branch/workspace:** tres-0010/e
- **Assigned branch starting commit:** 8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac (identical to frozen baseline when review began)
- **Model/configuration:** GPT-5.6 Sol
- **Tools used:** GitHub repository connector only
- **External web research:** no
- **TRES-0010 method note read:** research/technical/TRES-0010/AI_AGENT_ADVERSARIAL_METHOD_REVIEW.md
- **Prior TRES-0003–TRES-0009 reports read:** no
- **Sibling Wave-A returns read before initial report:** no
- **Canonical project files modified:** no; this return is the only repository write

## Executive finding summary

IMP-0001 is substantially aligned with the accepted architecture, but it is not yet a sufficiently closed delegation contract for a coding agent. I found four high-repair handoff defects and three medium guard/clarity defects.

The most serious problem is not a contradiction in the foundational architecture. It is that the implementation packet sometimes asks the coder to implement or verify behavior more broadly than the accepted Stage-3 artifacts actually pin down. A competent coder can therefore make materially different social-policy choices and still plausibly claim to have followed the packet.

| ID | Classification | Severity | Short result |
|---|---|---|---|
| TRES-0010E-F01 | contradiction / verification weakness | HIGH_REPAIR_BEFORE_CODE | Card-range acceptance requirements include assertions that IMP-0001 explicitly places outside Slice 1. |
| TRES-0010E-F02 | missing semantic rule / implementation hazard | HIGH_REPAIR_BEFORE_CODE | General personal candidate generation/gating is required, but the accepted profiles mostly specify scoring after generation, not when/for whom actions are generated. |
| TRES-0010E-F03 | missing semantic rule / implementation hazard | HIGH_REPAIR_BEFORE_CODE | CallFavor can demand an “otherwise-feasible ordinary action,” but the callable action domain and nested-response/initiative semantics are not defined. |
| TRES-0010E-F04 | missing authoritative link / future-slice coupling | HIGH_REPAIR_BEFORE_CODE | Slice 1 requires direct participants to know proposal/failure outcomes, but IMP-0001 omits the minimal KnownFact boundary and can be read as history-only. |
| TRES-0010E-F05 | missing semantic rule | MEDIUM_AMEND_OR_GUARD | Favour-cardinality behavior is ambiguous for an explicit benefit-for-favour bargain when the ordered-pair favour slot is already occupied. |
| TRES-0010E-F06 | verification weakness | MEDIUM_AMEND_OR_GUARD | “Relevant/applicable/where substrate is available” lets the implementer self-select parts of the Stage-3 verification package and mutant set. |
| TRES-0010E-F07 | harmless ambiguity / verification weakness | MEDIUM_AMEND_OR_GUARD | Analyzer strictness and “stronger repository protection if available without disproportionate administration” are not mechanically decidable completion criteria. |

**Recommendation:** AMEND BEFORE IMPLEMENTATION.

No finding requires changing DEC-0001 or ADR-0001 through ADR-0005. F01, F04, F06, and F07 are packet-scope/wording repairs against already accepted authority. F02 and F03 require either an explicit narrowing of Slice-1 behavior to what Stage 3 actually pins down or a new authoritative policy decision before coding.

---

## Detailed findings

### TRES-0010E-F01 — Acceptance-card ranges cross the explicit Slice-1 boundary

**Classification:** contradiction / verification weakness  
**Severity:** HIGH_REPAIR_BEFORE_CODE  
**Confidence:** high

**Evidence**

IMP-0001 §4 explicitly excludes:

- CandidateOrganization / household formation;
- Household / SustainingParticipant / participation warrants;
- household recognition or head recognition;
- household provision/head role/household-mode action;
- household-mediated marriage;
- general subjective communication/claim propagation beyond lower-level state needed for this slice.

IMP-0001 §6 nevertheless requires executable acceptance coverage, “at minimum,” for:

- VS-SFL-090 through VS-SFL-099; and
- VS-SFL-100 through VS-SFL-105.

Two concrete collisions follow.

1. plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md, VS-SFL-104 requires an Active household H, a valid current head P, a household-mediated marriage proposal, role/scope validation, and head response authority. Those are explicitly out of scope in IMP-0001 §4.
2. plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md, VS-SFL-098 includes Communication among the substantive personal initiatives whose accounting is checked, while IMP-0001 explicitly defers general subjective communication/claim propagation.

IMP-0001 attempts to soften the first conflict with: “Cards that explicitly require household semantics remain unimplemented and must not be faked.” That sentence directly conflicts with the preceding “VS-SFL-100 through VS-SFL-105” minimum unless the implementer silently treats the range as containing exceptions.

**Smallest failure trace**

A coding agent reaches VS-SFL-104 and has three plausible choices:

- implement household/head/mediated-marriage semantics now, violating §4;
- omit VS-SFL-104, violating the literal minimum scenario range;
- fixture or stub household/head authority to make the card pass, violating the verification package’s fixture restrictions and the “must not be faked” rule.

Likewise, for VS-SFL-098 it must decide whether “Communication” is an assertion to implement now or a deferred example inside an otherwise required card.

**Why existing authority does or does not answer it**

Existing authority answers the *semantic* question: SPEC-SFL-0001 defines those later mechanisms, and plans/CURRENT_PHASE.md sequences subjective recognition after Slice 1 and household identity after that. The missing piece is the Slice-1 acceptance manifest. This is an IMP-0001 wording/scope defect, not a foundational semantic gap.

**Consequence if ignored**

Scope creep, fake fixtures, or a completion claim that quietly skips canonical assertions.

**Recommended disposition**

Amend IMP-0001 before dispatch with a card/subcase-level Slice-1 acceptance manifest. Explicitly mark VS-SFL-104 deferred. Explicitly state how VS-SFL-098 is applied to the Slice-1 action set and that communication-specific coverage is deferred rather than silently omitted.

---

### TRES-0010E-F02 — Production personal candidate generation is broader than the accepted policy actually specifies

**Classification:** missing semantic rule / implementation hazard  
**Severity:** HIGH_REPAIR_BEFORE_CODE  
**Confidence:** high

**Evidence**

IMP-0001 §3.4 requires:

- one personal voluntary initiative per person/cycle;
- context-sensitive candidate generation/gates;
- exact component scoring;
- the in-scope personal scoring profiles.

IMP-0001 §3.5 simultaneously requires a broad lower-level action repertoire: Farm, gift/help, loan/repayment, benefit-for-favour, reciprocal help, CallFavor, direct marriage, and residence change.

SPEC-SFL-0001 §5 defines the generic architecture—contextual candidate generation, categorical gates, exact component sums, and concern categories—but intentionally does not define a complete default candidate-generation policy for each action/target.

REFERENCE_SCORING_PROFILES.md predominantly defines score components *after a candidate exists*. For example SCORE-VP-004 says “for a candidate directed toward person T” how the attitude component is calculated; it does not define which ordinary interpersonal action is generated, when it is generated, or which targets are accessible. Most lower-level cards VS-SFL-090 through VS-SFL-098 are mechanism-isolation cards and therefore may submit valid proposals through the public proposal/response boundary without proving a general autonomous personal-generation policy.

**Smallest counterexample**

Two implementations can both satisfy the explicit transition semantics:

- Implementation A generates OfferGift/OfferLoan/RequestGift candidates toward every mechanically eligible actor whenever the actor has an initiative.
- Implementation B generates only need-triggered requests and only relationship-triggered offers toward a narrow target set.

Both can pass mechanism-isolation transition cards and the same component-sum scorer. They nevertheless produce materially different autonomous simulations.

The choice is not a record-layout or cache decision. It is actor policy.

**Why existing authority does or does not answer it**

Accepted authority intentionally specifies the agency architecture and selected closed-loop profiles, not a complete general personal policy. The packet currently turns that intentional incompleteness into an implementation requirement.

The coding agent therefore needs either:

1. an explicit Slice-1 narrowing: implement production candidate generation only where a canonical closed-loop profile/card actually pins the generator/gates, while other action meanings enter through mechanism-isolation/public proposal boundaries; or
2. additional authoritative/configuration rules for general personal candidate generation before coding.

**Consequence if ignored**

The first coding agent will create social-policy semantics by implementation accident. Later verification may then fossilize those choices because the code already exists.

**Recommended disposition**

Amend before dispatch. Prefer scope narrowing over inventing a broad default policy merely to make Slice 1 feel complete.

---

### TRES-0010E-F03 — CallFavor has no closed Slice-1 callable-action grammar

**Classification:** missing semantic rule / implementation hazard  
**Severity:** HIGH_REPAIR_BEFORE_CODE  
**Confidence:** high

**Evidence**

SPEC-SFL-0001 §3.4 says a favour “may request one otherwise-feasible ordinary action,” while excluding impossible actions, compelled marriage/kinship, and favour recursion.

IMP-0001 §3.5 requires CallFavor / fulfil / refuse / reciprocal cancellation.

LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md VS-SFL-094 repeats “one otherwise-feasible ordinary action” but does not name the action vocabulary used by the canonical fulfilment case.

RESPONSE_DECISION_FAMILY.md VS-SFL-102 verifies FulfilCalledFavor versus RefuseCalledFavor, but it likewise does not define the requested-action type or what happens when the requested action would itself normally open another response/proposal context.

**Smallest counterexample**

B owes A one favour. A calls it.

Plausible implementation 1: a called favour may request only a direct, non-nested lower-level act such as a 1-grain transfer.

Plausible implementation 2: a called favour may request any otherwise-feasible in-scope personal action, including Farm, OfferLoan, residence proposal, or another action that itself requires a third party to respond.

Both satisfy the literal phrase “ordinary action” except where explicitly excluded, but they create different initiative, proposal-nesting, feasibility, and causal-history behavior.

This becomes especially consequential because response contexts do not consume personal initiative. A broad callable-action domain can therefore let favour fulfilment perform substantive actions in addition to the fulfiller’s personal initiative, and possibly spawn further counterparty decisions.

**Why existing authority does or does not answer it**

The authority defines exclusions and response semantics but not the positive callable-action set or nesting rule. That is a genuine missing Slice-1 transition boundary.

**Consequence if ignored**

Either an overbuilt generic action-invocation subsystem or an underbuilt special case, with no authoritative basis for deciding which is correct.

**Recommended disposition**

Before implementation, define a bounded Slice-1 CalledAction whitelist and state whether called actions may create further proposal/response contexts. Do not solve this with a generic command framework unless authority explicitly requires it.

---

### TRES-0010E-F04 — The minimal subjective-knowledge substrate required by lower-level failure semantics is not named in the implementation state

**Classification:** missing authoritative link / future-slice coupling  
**Severity:** HIGH_REPAIR_BEFORE_CODE  
**Confidence:** high

**Evidence**

SPEC-SFL-0001 §6.1 defines KnownFact as a factual proposition held by an actor with provenance.

SPEC-SFL-0001 §6.4 says actors automatically know their own objective state, relations/claims in which they are direct parties, and proposals/events in which they directly participate.

SPEC-SFL-0001 §6.7 says direct participants learn Declined, Unable(reason), and InvalidatedAtResolution(reason), subject to bounded information.

The required Slice-1 verification cards make this observable:

- VS-SFL-070: A and B know the decline / inability;
- VS-SFL-071: direct participants learn the invalidation outcome and bounded reason;
- VS-SFL-073: the counterparty learns only the interaction-relevant failure proposition.

IMP-0001 §3.2’s authoritative lower-level state list does not mention KnownFact or a minimal subjective fact/provenance store. IMP-0001 §4 excludes “general subjective communication/claim propagation beyond lower-level state needed for this slice,” but it never states what that lower-level subjective state is. IMP-0001 §3.7 requires semantic history, which is not the same thing as actor-held knowledge.

**Smallest counterexample**

Implementation A records Declined/Unable/Invalidated only in global semantic history and exposes it to diagnostics.

Implementation B also persists a provenance-bearing actor fact that the direct participant knows the interaction outcome.

Both can render the same global trace. Only B satisfies the accepted subjective-state semantics.

**Why existing authority does or does not answer it**

Existing authority already answers the semantic question. Slice 1 needs the direct-participant subset of KnownFact/provenance even though communication, household recognition, and broader claim propagation are deferred. IMP-0001 needs to say this explicitly.

**Consequence if ignored**

History may be mistaken for subjective state, forcing a retrofit in Slice 2 and undermining the response/failure knowledge assertions already claimed in Slice 1.

**Recommended disposition**

Amend §3.2/§3.7/§4 to require the minimal direct-participant KnownFact/provenance substrate needed by in-scope cards while explicitly keeping communication and household/role recognition deferred.

---

### TRES-0010E-F05 — Explicit benefit-for-favour behavior at the one-favour cardinality limit is ambiguous

**Classification:** missing semantic rule  
**Severity:** MEDIUM_AMEND_OR_GUARD  
**Confidence:** medium-high

**Evidence**

SPEC-SFL-0001 §3.4 establishes at most one outstanding favour per ordered pair and says a favour may arise from an explicit benefit-for-favour bargain.

VS-SFL-093 says an explicit bargain creates one B -> A favour when accepted. The same card’s one-per-ordered-pair check says that, with one B -> A favour already outstanding, another favour-creating benefit cannot stack a second token and that “the underlying benefit may still commit if independently valid.”

That wording is clear for relationship-mediated reciprocal help: the help can exist independently and simply fails to create another favour. It is not clear for an explicitly bargained “benefit for one favour,” where the new favour is part of the stated exchange terms.

**Smallest counterexample**

B already owes A one favour. A offers B 1 grain explicitly in exchange for one new favour. B accepts.

Two reasonable implementations:

- treat the bargain as infeasible because the promised new favour cannot be created, so no benefit transfers;
- transfer the benefit but create no second favour because cardinality wins.

The latter effectively turns a failed bargain into a gift-like transfer; the former treats pair capacity as a feasibility gate. Accepted authority does not say which meaning is intended.

**Consequence if ignored**

Different material and social outcomes from the same proposal terms, with downstream attitude/history differences.

**Recommended disposition**

Clarify cardinality behavior separately for explicit bargain and relationship-mediated reciprocity. No implementation agent should decide whether an explicit exchange silently degrades into a unilateral benefit.

---

### TRES-0010E-F06 — Slice-1 verification applicability is self-selected rather than enumerated

**Classification:** verification weakness  
**Severity:** MEDIUM_AMEND_OR_GUARD  
**Confidence:** high

**Evidence**

IMP-0001 uses several open selectors:

- “relevant non-household cases” in RESOLUTION_REACTION_FAMILY.md;
- “relevant determinism/fallback/trace requirements” in DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md;
- “where their required substrate is available” for VS-SFL-070/071/073/074;
- “applicable boundary/metamorphic/mutant checks”;
- “no-surviving relevant semantic mutant where the slice claims coverage.”

CROSS_CUTTING_VERIFICATION_CONTRACT.md contains both clearly in-scope lower-level obligations and clearly out-of-scope household/recognition/checkpoint obligations. Its mutant set likewise mixes the two.

IMP-0001’s verification expectations make several 08x obligations clearly intended—stable-ID fallback sensitivity, observer/trace noninterference, trace evidence—but do not name the corresponding cards or the complete in-scope mutant/metamorphic subset.

**Smallest failure trace**

An implementation agent runs the named scenario ranges plus one easy stable-ID probe and a small hand-picked mutant set, labels all others “not relevant,” and reports “no surviving relevant mutant.” The packet has no machine-checkable manifest proving that the chosen subset was complete.

**Why existing authority does or does not answer it**

Stage-3 authority defines the checks. The missing artifact is merely the Slice-1 applicability map.

**Consequence if ignored**

A completion report can look fully evidenced while silently omitting hard in-scope adversarial checks.

**Recommended disposition**

Add a Slice-1 verification manifest to IMP-0001: card ID/subcase, required/deferred, reason, required profile, relevant metamorphic relation(s), relevant mutant(s), and expected evidence artifact.

---

### TRES-0010E-F07 — Two engineering completion criteria are subjective rather than mechanically auditable

**Classification:** harmless ambiguity / verification weakness  
**Severity:** MEDIUM_AMEND_OR_GUARD  
**Confidence:** high

**Evidence**

IMP-0001 §6 requires that the warnings/analyzer policy be “strict enough that accepted CI failures are not silently ignored.”

The protected-acceptance section says: “If a stronger repository protection mechanism is available without requiring disproportionate administration, use it.”

The C# guardrail note permits the exact analyzer package/configuration to remain an implementation choice, and SCF-002 intentionally allows repository instructions/test separation/CI when stronger protection is not warranted.

These are appropriate engineering goals but not objective pass/fail clauses as written.

**Smallest counterexample**

Two agents can choose materially different analyzer baselines or disagree about whether branch/CODEOWNERS-style protection is “available” or “disproportionate,” with no authoritative test deciding which completion claim is valid.

**Why existing authority does or does not answer it**

This is safely local engineering policy, not simulation semantics. The packet only needs a concrete minimum and evidence requirement.

**Consequence if ignored**

Review churn or a completion claim whose tooling/protection standard cannot be reproduced.

**Recommended disposition**

State a minimum mechanically checkable baseline and require the completion report to name the selected stricter options. Treat stronger repository-administration protection as optional unless the operator explicitly grants/configures it.

---

## Section-by-section handoff coverage

| IMP-0001 area | Audit result |
|---|---|
| Pre-dispatch gate / authority chain | Clear; no defect found. |
| §1 Objective | Clear at architectural level; later acceptance ranges need the F01 carve-outs. |
| §2 Authoritative inputs | Correct source family; “relevant” verification subsets need F06 manifesting. |
| §3.1 Tooling foundation | Semantically safe; completion strictness needs F07. |
| §3.2 Lower-level state | Identity/relation scope is coherent; minimal KnownFact substrate is omitted (F04). |
| §3.3 Time/maintenance | Debt +3-cycle ordering is resolved by SPEC §9 and VS-SFL-092; no generic delayed-process system is required. |
| §3.4 Personal/response agency | Response side is well pinned; general personal candidate generation is not (F02). |
| §3.5 Action/relation transitions | Most transition meanings are testable; CallFavor grammar and explicit bargain cardinality need F03/F05. |
| §3.6 Proposal/resolution/commit | Aligned with ADR-0004 and response/resolution cards; no additional contradiction found. |
| §3.7 History/observability | Required trace fields are clear; do not substitute history for actor KnownFact (F04). |
| §4 Explicitly out of scope | Sound boundary, but acceptance-card ranges cross it (F01). |
| §5 Invariants | Lower-level invariants are compatible with accepted authority. |
| §6 Acceptance criteria | Needs exact scope manifest (F01/F06) and objective engineering minima (F07). |
| §7 Verification expectations | Good evidence shape; “relevant/applicable” set must be enumerated (F06). |
| §8 Local decisions | Appropriate for record/layout/index/framework details; it does not authorize F02/F03 semantic choices. |
| §9 Escalation | Correctly catches the kinds of gaps found here, especially underspecified response/action transitions. |
| §10 Work-state discipline | No defect found. |
| §11 Completion report | Adequate once the acceptance manifest is made explicit. |

---

## Proposed handoff-diff list

These are proposed edits to the delegation packet, not edits made by this reviewer.

1. **Replace card-range ambiguity with a Slice-1 acceptance manifest.** Explicitly mark VS-SFL-104 deferred because it requires Active Household/head/mediated-marriage semantics. For VS-SFL-098, state which Slice-1 personal-action assertions are required and explicitly defer the communication-specific subcase rather than silently skipping it.
2. **Narrow personal candidate-generation authority.** State that IMP-0001 may implement production generation/gates only where accepted closed-loop configuration/cards pin the behavior. Other lower-level transitions may remain mechanism-isolation/public-boundary semantics. If a broader autonomous policy is desired, define it authoritatively before coding.
3. **Define the Slice-1 CallFavor action vocabulary.** Enumerate callable actions and whether a called action may open additional proposal/response contexts. Explicitly forbid the implementation agent from inventing a generic action-command framework to fill the gap.
4. **Clarify favour cardinality atomicity by transfer meaning.** State what happens to an explicit benefit-for-favour proposal when the recipient cannot create another favour for that ordered pair, and distinguish that from reciprocal help whose underlying help may independently remain valid.
5. **Name the minimal subjective-state substrate.** Add provenance-bearing direct-participant KnownFact/outcome state needed for in-scope proposal/failure knowledge; keep communication, household recognition, and general claim propagation deferred.
6. **Add a verification applicability table.** Map every required/deferred scenario/subcase, scoring profile, boundary matrix item, metamorphic relation, and semantic mutant relevant to Slice 1. The completion report should report against this manifest rather than the word “relevant.”
7. **Make engineering acceptance minima mechanical.** Define the minimum analyzer/warning policy and minimum protected-acceptance structure that count as completion; require the implementation agent to report any stronger optional repository protection it actually used.

---

## Attempted attacks that did not expose a defect

### A. Stable identity and lower-level record ownership

I tested whether IMP-0001 forces a primitive household-like container or mutable-content identity. It does not. DEC-0001 plus ADR-0001 and IMP-0001 §3.2/§4 keep Person, Dwelling, Attitude, Kinship, Marriage, Debt, Favour, and transfer/action records independently identified and explicitly prohibit a hidden household-membership container. Exact C# record/class/struct/index choices are safely local.

### B. Response autonomy and shared-snapshot semantics

I tested whether a coder must guess whether initiator policy can determine the target response, whether response feasibility happens before scoring, or whether acceptance guarantees commit. SPEC §5.1, RESPONSE_DECISION_FAMILY.md, and IMP-0001 §§3.4/3.6 answer all three: target response is a separate decision context, infeasibility precedes voluntary response scoring, and accepted responses remain subject to central revalidation/resolution. No defect found apart from the out-of-scope VS-SFL-104 case.

### C. Debt due timing

I tested the apparent ambiguity in IMP-0001’s compressed “debt social-due review” wording. SPEC §9 and VS-SFL-092 resolve it exactly: a loan committed in cycle N is reviewed after cycle N+3 decisions/commits, and the -10 relation consequence fires once if any balance remains. No additional timing decision is required here.

### D. Checkpoint deferral versus architectural compatibility

I tested whether excluding checkpoint/save-load continuation conflicts with ADR-0004/ADR-0001. plans/CURRENT_PHASE.md explicitly places delayed-process + checkpoint/restore continuation in a later slice, and IMP-0001 still requires future-influencing state to remain explicit/serializable in principle. No present requirement to build checkpoint infrastructure was found.

### E. Stable-ID fallback winner

I tested whether the packet must specify one socially preferred winner for exact symmetry. It does not. VS-SFL-081 explicitly makes the winner a nonclaim: deterministic repeatability, isolation from container order, explicit fallback marking, and expected sensitivity to nonsemantic ID renaming are what matter. The exact socially arbitrary winner need not be elevated into semantics.

### F. Direct marriage versus residence

I tested whether implementing the mutual-strong-like marriage bypass accidentally requires automatic co-residence. SPEC §3.6/§4 and VS-SFL-095/096 explicitly separate marriage from residence change. No ambiguity found.

---

## Places where accepted artifacts did not determine the answer

The unresolved items are already captured as findings F02, F03, and F05:

- the general personal action candidate-generation/target policy;
- the positive CallFavor callable-action domain and nesting behavior;
- explicit benefit-for-favour behavior when the ordered-pair favour slot is already occupied.

I deliberately did not use working specifications or prior TRES-0003–TRES-0009 conclusions to fill these gaps. A non-authoritative explanation would not close an implementation handoff defect.

## Prior TRES findings read

None from TRES-0003 through TRES-0009.

## Final recommendation

**AMEND BEFORE IMPLEMENTATION**

IMP-0001 should not be dispatched unchanged. The accepted architecture is not the problem; the handoff needs an exact Slice-1 acceptance/applicability manifest, a narrower boundary around unpinned personal policy, explicit CallFavor scope, and the direct-participant subjective-state requirement. Once those are repaired, the remaining lower-level kernel contract appears implementable without forcing the coder to invent major architecture or social semantics.
