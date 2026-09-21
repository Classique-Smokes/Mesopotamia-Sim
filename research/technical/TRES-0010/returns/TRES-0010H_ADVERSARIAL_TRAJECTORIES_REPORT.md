# TRES-0010H — Adversarial State-Trajectory Report

## Run provenance

- **Task ID:** TRES-0010H
- **Frozen baseline:** `tres-0010-review-baseline`
- **Resolved baseline commit:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Model/configuration:** GPT-5.6 Sol
- **Dedicated branch/workspace:** `tres-0010/h`
- **Tools used:** GitHub repository connector only
- **External web research:** no
- **Initial source-restricted pass:** `SPEC-SFL-0001`; `registers/ASSUMPTIONS_REGISTER.md`; complete canonical Stage-3 SFL v0 verification package
- **Prior TRES-0003–0009 read:** yes, **only after the initial trace set and candidate findings were fixed**
- **Sibling Wave-A reports read before initial report:** **no**
- **Canonical project files modified:** no

## 1. Executive finding summary

The accepted SFL v0 rules successfully determine most of the adversarial trajectories exercised here. In particular, common-snapshot multiple responses, commit-time invalidation, NeedsGrain priority/clearing, strong-like threshold edges, formation recurrence, participation bridge handoff, stable lifecycle publication, lineage freshness, automatic-reaction idempotence, and disclosed stable-ID fallback all have explicit closure rules.

Two compositional seams remain material:

| Finding | Classification | Severity | Disposition |
|---|---|---|---|
| H-001 — Called-favour fulfilment can require a second ordinary action whose response/initiative semantics are undefined | missing semantic rule | **BLOCKER_BEFORE_CODE** | Escalate for explicit semantic decision before implementation |
| H-002 — Same-cycle head-authority destruction versus already-accepted role-scoped action lacks an ordering rule | missing semantic rule / implementation hazard | **HIGH_REPAIR_BEFORE_CODE** | Amend resolution semantics and add a canonical conflict card before implementation |

**Recommendation: `BLOCK IMPLEMENTATION` pending H-001 resolution and explicit repair/closure of H-002.**

This is not a claim that the overall SFL design is unsound. Both findings are narrow interaction defects that become visible only when otherwise-valid rules compose.

---

## 2. Detailed findings

### H-001 — Called-favour fulfilment can require an undefined response-generated action chain

- **Classification:** missing semantic rule
- **Severity:** `BLOCKER_BEFORE_CODE`
- **Confidence:** high

#### Governing evidence

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §3.4:
  - a favour may request one otherwise-feasible ordinary action;
  - fulfilment satisfies the favour;
  - the favour cannot make an impossible action possible and cannot compel marriage/kinship.
- SPEC §5 and §5.1:
  - each actor normally has one voluntary personal initiative per cycle;
  - responses do not consume or grant that initiative;
  - every incoming proposal requiring target choice activates a `ResponseDecisionContext`;
  - response contexts read the common committed snapshot and do not observe uncommitted effects of other responses;
  - multiple response contexts may activate in one cycle.
- SPEC §3.6 and ADR-0002:
  - interpersonal actions such as residence change are proposal-based and remain subject to the counterpart/world-resolution boundary.
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` VS-SFL-094:
  - called-favour fulfilment says the requested action commits through ordinary proposal/resolution semantics.
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md` VS-SFL-102:
  - on fulfil selection the requested action remains subject to central revalidation; favour satisfaction is asserted on successful commit.
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` §1:
  - all immediate proposals must reach a terminal outcome in the same cycle.

#### Smallest counterexample trace A — third-party response

**Initial state**

- B owes A one valid outstanding favour.
- C is a third actor.
- B can validly initiate a residence proposal to C's dwelling (or another ordinary interpersonal proposal requiring C's choice).
- No rule makes C subject to A's favour claim.
- A, B, C are otherwise in states that make all local preconditions valid.

**Sequence**

1. During personal deliberation A uses `CallFavor(A -> B)`, requesting the otherwise-feasible ordinary action `ProposeResidenceChange(B -> C's dwelling)`.
2. In the response phase B's `ResponseDecisionContext` validly selects `FulfilCalledFavor`.
3. Under VS-SFL-094, fulfilment is supposed to execute the requested action through ordinary proposal/resolution semantics.
4. That ordinary action itself requires C's acceptance.
5. The accepted cycle contract has already entered the response phase; no rule states whether B's fulfil response may generate a new proposal that recursively activates a new `ResponseDecisionContext(C, ...)`, whether that new response is deferred, or whether such a favour request was never eligible.

#### Competing plausible interpretations

1. **Recursive same-cycle response closure:** B's Fulfil response creates the residence proposal; C receives a new response context in the same cycle; C's decision then determines whether the favour action commits.
2. **No response recursion:** a response cannot generate another response-requiring proposal in the same cycle; therefore this requested action must be rejected as ineligible/Unable.
3. **Deferred secondary proposal:** B's fulfil creates pending work for a later cycle, but this conflicts with the current immediate-proposal terminality contract unless a new delayed-process meaning is explicitly introduced.
4. **Bundled execution:** B's Fulfil directly commits the requested effect, which would bypass C's accepted autonomy/response semantics and is therefore inconsistent with ADR-0002 and the residence proposal rule.

The accepted artifacts do not select among 1–3, and 4 is not acceptable under existing authority.

#### Smallest counterexample trace B — initiative-bearing ordinary action

A second edge exposes the same missing abstraction boundary.

**Initial state**

- B owes A a favour.
- B has already selected its one ordinary personal initiative for the cycle.
- A calls the favour requesting another otherwise-feasible ordinary action whose normal path uses the personal initiative, e.g. `Farm` or `CommunicateClaim/Inform`.

**Sequence**

1. B's personal context selects its ordinary initiative.
2. B's response context independently selects `FulfilCalledFavor`.
3. Response semantics say the response does not consume B's personal initiative.
4. Ordinary-action semantics normally account the requested action as an initiative-bearing action.

The artifacts do not state whether favour fulfilment:
- executes the requested ordinary action as a response-scoped exception to initiative accounting;
- becomes infeasible because B's personal initiative has already been used;
- displaces the already-selected personal action;
- or creates an additional action opportunity.

This matters even when no third party is involved.

#### Why existing authority does not answer it

TRES-0008/TRES-0009 repaired **how a target chooses Accept/Decline/Fulfil/Refuse**, but the promoted `ResponseDecisionContext` contract does not define a response-generated proposal graph or a special execution meaning for an ordinary action requested by a favour.

The Stage-3 cards prove:
- the target chooses Fulfil autonomously;
- the requested action still uses ordinary proposal/resolution semantics;
- responses do not consume initiative.

They do not define how those three statements compose when the requested action itself needs a new response or normally consumes the initiative.

#### Consequence if ignored

Stage-4 code must invent one of several socially different semantics. Different reasonable implementations can produce different:
- third-party autonomy outcomes;
- favour satisfaction state;
- attitude updates for fulfil/refusal;
- initiative counts;
- same-cycle material/residence history;
- causal trace shape.

This is exactly the kind of semantic invention the pre-implementation gate is intended to prevent.

#### Recommended disposition

Escalate for a narrow Director/Master-Architect semantic decision before code. The repair should explicitly define the **completion unit** of a called-favour action.

Two coherent families exist, but this review does not select one:

- restrict v0 favour calls to ordinary actions whose completion does not require a newly generated counterparty response, while defining initiative treatment; or
- permit response-generated proposal chains and define deterministic same-cycle response closure, initiative accounting, third-party autonomy, terminal failure meaning, and when the favour is considered satisfied.

Add at least one canonical Stage-3 card where fulfilment requests a third-party proposal and one where the requested action normally consumes personal initiative.

---

### H-002 — Same-cycle head-authority destruction versus accepted role-scoped action is order-sensitive

- **Classification:** missing semantic rule / implementation hazard
- **Severity:** `HIGH_REPAIR_BEFORE_CODE`
- **Confidence:** high, with one interpretive caveat noted below

#### Governing evidence

- SPEC §4.2:
  - household-mediated marriage requires a current recognized household/head route;
  - head acceptance is sufficient for the mediated route, subject to other preconditions.
- SPEC §7.4:
  - `EndHouseholdParticipation(H)` is a valid voluntary action;
  - if the exiting participant is current head, participation end vacates the head role.
- SPEC §8.4:
  - head authority is scoped;
  - outgoing head may nominate a successor before vacating.
- SPEC §9.2:
  - every proposal is revalidated immediately before commit against all action-relevant preconditions, including head validity;
  - accepted but incompatible proposals may become `InvalidatedAtResolution`;
  - explicit priorities cover scarce household provision uses;
  - there is one **narrow** special ordering rule for a participation entry that depends on a bridge who is also exiting.
- ADR-0004:
  - runtime iteration order cannot silently become simulation authority;
  - transient microstep order must not determine behavior merely because of mutation order.
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` VS-SFL-062/063 and `RESPONSE_DECISION_FAMILY.md` VS-SFL-104:
  - head loss, succession, and role-scoped response validity are covered separately, but not in the same accepted-conflict trajectory.

#### Smallest counterexample trace

**Initial state**

- Active household H.
- P is current valid head and SustainingParticipant.
- Bride B is a current SustainingParticipant.
- Provision backing is sufficient for a mediated-marriage dowry.
- Groom G is eligible, knows B's participation, recognizes H and P's current scope, does not already owe P a favour, and cannot use the mutual-strong-like bypass.
- P is otherwise free to end participation.

**Same common snapshot / decisions**

1. G selects a valid household-mediated marriage proposal through head P.
2. P's role-scoped response context selects **Accept**.
3. Independently, P uses the personal initiative to select `EndHouseholdParticipation(H)`.

Both are valid from the common snapshot. P's response does not consume the personal initiative.

#### Two locally valid resolution histories

**History A — mediated marriage first**

1. Revalidate mediated marriage while P is still head.
2. Commit dowry, marriage, and G -> P favour.
3. Commit P's participation end.
4. P ceases participation and the head role becomes vacant.

**History B — head exit first**

1. Commit P's participation end.
2. Head role becomes vacant.
3. Revalidate the previously accepted mediated marriage.
4. It fails as `InvalidatedAtResolution(HeadRoleNoLongerValid)`.
5. No dowry, marriage, or G -> P favour commits.

Both histories honor local revalidation rules. They produce different authoritative social histories.

#### Why existing authority does not answer it

The accepted conflict priorities are partial:

- provision support > other household provision expenditure > ordinary personal transfer;
- dependent participation entry > the specific bridge's same-cycle exit.

No rule orders an authority-destroying participation transition against an already-accepted action whose validity depends on that authority.

The stable-ID fallback does not clearly close this case. SPEC authorizes it for **equal-priority unresolved symmetry**. The two operations here are heterogeneous and causally asymmetric: one consumes authority; the other destroys the precondition that authority exists. Treating them as an arbitrary ID symmetry would itself be a new semantic decision.

TRES-0006 is relevant after the independent first pass because it demonstrates the project already recognized this class of issue for continuity and repaired it with a deliberately **narrow causal-handoff priority**, explicitly rejecting mutation-order authority. No analogous head-authority rule exists in the accepted baseline.

#### Consequence if ignored

Implementation order, proposal container order, or an overly broad technical-ID fallback can decide whether a marriage, dowry spend, and favour exist. That violates ADR-0004's authority boundary and can make semantically significant outcomes depend on local resolver structure.

The same structural issue can recur with:
- accepted head-mediated action versus same-cycle succession;
- accepted head action versus head participation end;
- succession proposal versus the nominating outgoing head's same-cycle exit.

#### Recommended disposition

Amend the accepted resolution contract before implementation with an explicit rule for **authority-transition conflicts**. The rule must say whether:
- an already-accepted role-scoped action has causal priority over the self-vacating transition;
- authority loss has priority and invalidates the dependent action;
- or a defined atomic/handoff transaction resolves the pair.

Do not leave this to collection order. Do not silently broaden the stable-ID fallback without explicitly declaring that semantic choice.

Add a canonical conflict card that combines VS-SFL-062/063 with VS-SFL-104.

---

## 3. Adversarial traces that resolved cleanly

The following attacks were constructed before reading TRES-0003–0009 and did **not** expose a new defect.

### T-01 — One target accepts multiple grain-help requests

- A and C both request 1 grain from B.
- B has capacity for exactly one of the two effects.
- Both response contexts may select Accept from the common snapshot.
- Central resolution commits one compatible transfer under the accepted equal-priority/fallback rule and marks the other `InvalidatedAtResolution`, not Declined.
- No refusal penalty applies to the loser.

**Result:** determined by SPEC §5.1/§9.2 and VS-SFL-103.

### T-02 — NeedsGrain clears during resolution but does not reopen voluntary agency

- N begins the decision snapshot with `NeedsGrain=true`.
- A valid household support effect commits and transfers 1 grain.
- N clears NeedsGrain by the accepted threshold.
- N does not Farm in the same cycle because voluntary deliberation does not reopen during resolution/reaction closure.

**Result:** surprising but determined by SPEC §2.2/§9.1 and VS-SFL-090/075.

### T-03 — Debt social-due boundary after a successful repayment

- Loan commits in cycle N.
- Full valid repayment commits during cycle N+3 before the due review.
- Due review sees no remaining balance and emits no -10 event.
- In the paired partial-repayment run, any remaining balance at that review produces exactly one -10 event.

**Result:** determined by SPEC §3.3/§9 and VS-SFL-092.

### T-04 — Gift/help meaning does not collapse into favour creation

- Genuine Gift remains a Gift even if recipient attitude is already strong-like; it does not create a favour merely because the transfer is beneficial.
- Relationship-mediated reciprocal help at stored +74 does not create a favour; at +75/+76 it may create one.
- Kinship amplification cannot make stored +74 satisfy the gate.
- If one favour already exists for the ordered pair, the benefit may still commit when independently valid but no second favour token stacks.

**Result:** determined by SPEC §§3.2–3.5, ASM-0001/0004, and VS-SFL-091/093.

### T-05 — Direct marriage, residence, and other relations remain orthogonal

- Eligible mutual-strong-like spouses may marry directly.
- Direct marriage creates neither dowry nor groom->head favour.
- Marriage alone does not move either spouse.
- A separately accepted residence proposal may change residence.
- Existing debt/favour remains governed by its own relation semantics.

**Result:** determined by SPEC §§3–4 and VS-SFL-095/096.

### T-06 — Formation threshold and reaction closure

- Two qualifying support events on distinct cycles plus shared residence, durable connected ties, and founder evidence can lead through CandidateRecognition -> FormationWarrant -> SustainingParticipant/recognition reactions in one closure chain.
- Two support events on the same cycle do not satisfy the recurrence predicate.
- Household-originated feedback cannot substitute as independent formation evidence.

**Result:** determined by SPEC §§6.3, 7.2, 9.3 and VS-SFL-001/050/075.

### T-07 — Same-cycle participation bridge handoff

- Inactive H has sole bearer A.
- D's accepted participation entry explicitly depends on A as bridge.
- A also has an accepted participation-end action.
- The accepted narrow rule commits D's entry/continuity handoff before A's exit.
- Final stable state: same H, D sole participant, H Inactive.

**Result:** explicitly determined by SPEC §9.2 and VS-SFL-013.

### T-08 — Stale head recognition does not magically synchronize

- Outsider X recognizes old head A.
- H validly succeeds to B without X observing.
- X retains stale recognition until newer evidence reaches X.
- Later event-backed communication of the succession corrects the route; later-arriving older evidence cannot overwrite newer event evidence.

**Result:** determined by SPEC §6.5 and VS-SFL-031/032.

### T-09 — Lifecycle and consolidation-lineage freshness do not collapse into same-cycle snapshots

- Participant count affects operational lifecycle only at stable closure.
- Controlled consolidation requires both predecessors already Dissolved and fresh post-dissolution cross-predecessor support before successor lineage classification.
- A transient within-cycle zero-participant microstate is not a published Dissolved lifecycle state and therefore is not a shortcut to same-cycle consolidation lineage.

**Result:** determined by SPEC §§7.6–7.7 and VS-SFL-023/024.

### T-10 — Multiple automatic reactions do not authorize duplicate application

- One event may legitimately cause several distinct automatic reactions.
- Each has a distinct cause key and monotone `ReactionIndex`.
- Re-encounter of the same `(rule, triggering event, subject)` cannot apply the same transition twice.
- No arbitrary microstep cap is permitted to masquerade as successful closure.

**Result:** determined by SPEC §9.3 and VS-SFL-074/075.

### T-11 — Stable-ID symmetry is intentionally arbitrary but bounded

- When all modeled semantic/domain priorities are exhausted, stable semantic ID may choose between otherwise symmetric alternatives.
- The fallback must be recorded.
- ID renaming is allowed to change the symmetric winner in the deliberately fallback-reaching case.
- Introducing a meaningful domain asymmetry must eliminate fallback use.

**Result:** weird but explicitly determined by ASM-0007, SPEC §9.2, and VS-SFL-081.

---

## 4. Places where accepted artifacts could not determine one authoritative result

Only the two substantive findings above survived the initial trace pass plus reconciliation:

1. **Called-favour fulfilment of an ordinary action that itself requires another response or ordinary initiative accounting** — no accepted response-chain/completion rule.
2. **Head-authority destruction racing an already-accepted authority-dependent effect** — no explicit cross-domain causal priority.

No additional unresolved result was found in the other attempted traces. Some outcomes are deliberately arbitrary (stable-ID fallback) or intentionally absorbing (MaterialDeadlock), but they are specified rather than ambiguous.

---

## 5. Prior TRES reconciliation

The initial trace set and the two candidate findings above were written/fixed **before** reading prior TRES-0003–0009.

After that point I read:

- `TRES-0003/PASS_F_TEMPORAL_RESOLUTION_ADVERSARIAL_REVIEW.md`
- `TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`
- `TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`
- `TRES-0006/CONTINUITY_LIFECYCLE_SCENARIO_ADVERSARIAL_REVIEW.md`
- `TRES-0007/LINEAGE_WARRANT_ADVERSARIAL_REVIEW.md`
- `TRES-0008/STAGE3_FINAL_VERIFICATION_PACKAGE_ADVERSARIAL_REVIEW.md`
- TRES-0008 closure-repair promotion reconciliation
- `TRES-0009/STAGE3_POST_REPAIR_CLOSURE_REVIEW.md`

Reconciliation result:

- prior reviews already explain why common-snapshot revalidation, bounded failures, cause-key closure, lifecycle stable boundaries, and the participation bridge priority exist;
- TRES-0008/0009 resolved deterministic response **selection**, but not the H-001 response-generated ordinary-action chain;
- TRES-0006's bridge-handoff repair supports H-002's diagnosis that causally asymmetric same-cycle transitions require explicit semantics rather than mutation order;
- neither surviving finding is a duplicate of a prior accepted repair found in TRES-0003–0009.

No sibling TRES-0010 Wave-A return was read.

---

## 6. Final recommendation

**`BLOCK IMPLEMENTATION`**

Reason:

- H-001 requires Stage 4 to invent a causal/agency rule to execute a valid accepted action composition.
- H-002 allows two different authoritative histories from one valid same-snapshot decision set unless a role-transition conflict rule is made explicit.

The smallest safe path is to resolve these two seams at the semantic/verification level, add focused regression cards, and then re-evaluate the TRES-0010 implementation gate. No broader redesign is indicated by this review.
