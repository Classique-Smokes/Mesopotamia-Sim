# VS-SFL-10x — Counterparty Response Decision Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§5–6 and §9.  
**Configuration:** `REFERENCE_SCORING_PROFILES.md`.

These cards verify that counterparties remain autonomous: initiator selection cannot silently choose another actor's response, infeasibility is resolved before voluntary scoring, response decisions do not consume personal initiative, and accepted responses remain subject to central compatibility resolution.

## Family invariants

- one incoming proposal requiring a target choice creates one `ResponseDecisionContext(target, proposal)`;
- response context reads the common committed cycle snapshot, proposal terms, and target subjective state;
- infeasible requests produce `Unable(reason)` before voluntary response scoring;
- feasible response candidates use the same exact integer component-sum scorer as other reference decisions;
- response context cannot create a response meaning invalid for the proposal type or role scope;
- responses consume no personal initiative;
- multiple response contexts may activate for one target in the same cycle;
- selecting Accept/Fulfil does not guarantee commit; central revalidation/resolution remains authoritative;
- response decision traces retain candidates/gates/components/final score/selection/subjective inputs/profile version.

---

## VS-SFL-100 — Feasible Accept versus Decline is target policy

**Level:** closed-loop response

### Shared objective state

- requester A has genuine unmet need and submits `RequestGiftOrHelp(A -> B, 1)`;
- B has enough grain to transfer 1 without violating any applicable feasibility constraint;
- proposal terms and actor state are otherwise identical between runs.

### Run A — accept profile

B's response context uses `SCORE-RP-001`.

Assertions:

- production response generation includes valid Accept and Decline meanings;
- recorded scores are Accept=100, Decline=0;
- B selects Accept;
- if no later conflict invalidates it, the help transfer commits;
- accepted-help attitude consequence applies A -> B? **No:** the accepted voluntary help event's defined direction is recipient -> giver, so A -> B +10;
- B's personal initiative accounting is unchanged by the response.

### Run D — decline profile

B's response context uses `SCORE-RP-002`.

Assertions:

- recorded scores are Accept=0, Decline=100;
- B selects Decline;
- outcome is `Declined`;
- no grain moves;
- because A is in genuine unmet need, A -> B attitude -5;
- the initiator's proposal score cannot override B's selected response.

The paired run proves that counterparty response is a distinct target decision rather than an effect embedded in the initiator action.

---

## VS-SFL-101 — Infeasibility precedes accept preference

**Level:** closed-loop response / failure semantics

### Setup

A requests 1 grain of help from B.

B's response profile is `SCORE-RP-001` (strong Accept preference), but B is objectively unable to provide the requested grain under the interaction's feasibility rules.

### Assertions

- the interaction yields `Unable(reason)`;
- no voluntary Accept/Decline winner is allowed to override infeasibility;
- response trace records the feasibility gate/reason rather than pretending B voluntarily declined;
- no refusal attitude penalty fires;
- bounded reason does not leak unrelated private state.

### Mutation control

An implementation that scores Accept=100 and commits/labels acceptance despite infeasibility must fail.

---

## VS-SFL-102 — Called favour fulfil/refusal is response policy

**Level:** closed-loop response

### Shared setup

B owes A one favour. A validly `CallFavor`s B for one otherwise-feasible ordinary action.

### Fulfil run

B uses `SCORE-RP-003`.

Assertions:

- feasible response meanings include FulfilCalledFavor / RefuseCalledFavor;
- B selects fulfilment;
- requested action remains subject to central revalidation;
- on successful commit the favour is satisfied and A -> B attitude +10;
- fulfilment does not create another favour.

### Refusal run

B uses `SCORE-RP-004`.

Assertions:

- B selects refusal;
- favour remains outstanding;
- A -> B attitude -20;
- requested world effect does not commit;
- refusal does not consume B's personal initiative.

---

## VS-SFL-103 — Multiple accepted responses can later conflict

**Level:** closed-loop response / central resolution

### Common snapshot

- A and C each have genuine unmet need;
- both independently submit a 1-grain `RequestGiftOrHelp` to B;
- B has exactly 1 grain available to give across those two accepted ordinary transfers;
- both B response contexts use `SCORE-RP-001`;
- neither response sees the other's uncommitted effect.

### Response phase

Assertions:

- B may independently select Accept for both incoming proposals;
- both response traces are present;
- accepting the first does not consume B's personal initiative or suppress the second response context.

### Central resolution

Both accepted effects cannot commit.

Assertions:

- exactly one compatible transfer commits under the accepted equal-priority resolution/fallback rules;
- the other attempt becomes `InvalidatedAtResolution(reason)`, not a retroactive Decline;
- no refusal-attitude penalty applies to the invalidated attempt;
- B receives no extra personal initiative or response retry;
- history distinguishes "accepted by target" from "committed by resolver."

---

## VS-SFL-104 — Role-scoped response requires actual role authority

**Level:** closed-loop response / role gate

### Positive case

Active H has valid head P. A groom submits an otherwise-valid household-mediated marriage proposal through P.

P's role-scoped response context uses `SCORE-RP-005`.

Assertions:

- role/scope validity is checked categorically before response scoring;
- Accept/Decline response meanings are generated only because P is the valid mediation authority;
- P selects Accept under the profile;
- acceptance alone still does not bypass provision/marriage precommit revalidation.

### Negative case

Use otherwise identical objective proposal terms, but P is not the current valid head/authority for H.

Assertions:

- `SCORE-RP-005` cannot manufacture role authority;
- no valid role-scoped Accept response is generated through P;
- the mediated route fails with the appropriate bounded authority/feasibility outcome.

---

## VS-SFL-105 — Response does not consume personal initiative

**Level:** closed-loop process

### Setup

Target B has already generated one valid personal initiative from the common decision snapshot using an explicitly named personal scoring profile.

B also receives one or more incoming feasible proposals during the response phase and selects responses through response profiles.

### Assertions

- B's personal decision trace remains present;
- all response decision traces remain present;
- selecting responses neither cancels nor duplicates the one personal initiative;
- compatible personal and response effects may both commit;
- incompatible effects are resolved centrally rather than by deleting one decision context.

This card is satisfied by any concrete closed-loop fixture whose personal action is nonconflicting with the selected response effects; the implementation packet should bind one exact fixture/profile.

## Family semantic mutants that must be detected

- initiator's score directly determines target acceptance;
- infeasible proposal is voluntarily Declined instead of Unable;
- Accept preference bypasses feasibility;
- response consumes target personal initiative;
- only one response context is allowed per target/cycle;
- second response observes uncommitted effect of first response;
- accepted-but-conflicting proposal is rewritten as Declined;
- role response profile grants authority to a non-role actor;
- response decision trace omits candidates/components/selected response.
