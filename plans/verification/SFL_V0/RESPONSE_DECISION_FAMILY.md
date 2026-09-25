# VS-SFL-10x — Counterparty Response Decision Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§5–6 and §9.  
**Configuration:** `REFERENCE_SCORING_PROFILES.md`.

These cards verify that counterparties remain autonomous: initiator selection cannot silently choose another actor's response, infeasibility is resolved before voluntary scoring, response decisions do not consume personal initiative, and accepted responses remain subject to central compatibility resolution.

## Family invariants

- categorically invalid proposal terms are rejected before any target response context and do not become social failed attempts;
- one semantically valid incoming proposal requiring a target choice creates one `ResponseDecisionContext(target, proposal)`;
- response context reads the common committed cycle snapshot, proposal terms, and target subjective state;
- infeasible valid requests produce `Unable(reason)` before voluntary response scoring;
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
- accepted-help attitude consequence applies recipient A -> giver B +10;
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

### Shared valid setup

B owes A one favour. A validly `CallFavor`s B for a response-closed requested action: B's Fulfil/Refuse choice is the last new voluntary actor choice required for that requested action to reach terminal commit/failure.

### Fulfil run

B uses `SCORE-RP-003`.

Assertions:

- feasible response meanings include FulfilCalledFavor / RefuseCalledFavor;
- B selects fulfilment;
- requested execution is response-scoped and does not consume/grant another B personal initiative;
- requested action remains subject to central revalidation;
- no nested `ResponseDecisionContext` is opened;
- on successful requested-action commit the favour is satisfied and A -> B attitude +10;
- fulfilment does not create another favour.

### Refusal run

B uses `SCORE-RP-004`.

Assertions:

- B selects refusal;
- outcome is `Declined`;
- favour remains outstanding;
- A -> B attitude -20;
- requested world effect does not commit;
- refusal does not consume B's personal initiative.

### Invalid payload control

Use an attempted CallFavor payload outside the response-closed domain, such as an action that would require a third actor's new response.

Assertions:

- categorical validation rejects the term before B response activation;
- no response profile is scored;
- favour remains;
- no requested world effect or called-favour attitude effect occurs;
- the rejection is not labeled Declined/Unable/InvalidatedAtResolution.

### Unable / invalidated controls

For a valid response-closed payload:

- if already world-state infeasible at feasibility evaluation -> `Unable(reason)`, favour remains, no +10/-20;
- if B selected Fulfil but an action-relevant precondition is lost before commit -> `InvalidatedAtResolution(reason)`, favour remains, no +10/-20.

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

### Residence companion

Construct two independently accepted Residence proposals that would move the same person to different dwellings in the same cycle.

Assertions:

- both target Accept decisions remain in history;
- the valid accepted Residence effects form one same-person conflict set;
- at most one Residence transition commits;
- if no semantic priority distinguishes them, the disclosed stable-ID fallback selects the winner and is marked;
- every non-winner becomes `InvalidatedAtResolution(CompetingResidenceTransition)`;
- no second same-person Residence move commits later in the cycle.

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

### Common snapshot

- B and D have an established marriage and reside in different dwellings;
- no other co-residence target is eligible for B;
- B personal context uses `SCORE-VP-006`, making the marriage-motivated residence proposal toward D the highest generated personal candidate;
- D's response context to B's residence proposal uses `SCORE-RP-001`;
- A has genuine unmet need and submits `RequestGiftOrHelp(A -> B, 1)`;
- B has grain 5 and its response context to A uses `SCORE-RP-001`.

### Expected decisions

From the same committed cycle snapshot:

1. B uses its one personal initiative to select a residence proposal involving D;
2. D selects Accept for that incoming residence proposal;
3. B separately selects Accept for A's help request during the response phase.

### Assertions

- B has exactly one personal decision trace and one response-decision trace;
- B's response does not consume, cancel, or duplicate its personal initiative;
- D's response likewise consumes no D personal initiative;
- both accepted effects are compatible and may commit under ordinary revalidation;
- B residence changes only through the accepted residence proposal;
- A receives the accepted help transfer and recipient A -> giver B attitude +10;
- no actor receives a same-cycle second voluntary initiative.

### Mutation controls

Fail if:

- B's response causes its already-selected personal proposal to disappear solely because responses consume initiative;
- B is given another voluntary initiative because it responded;
- response-phase processing overwrites the personal decision trace.

---

## VS-SFL-106 — Role-scoped Accept variants may carry distinct private funding plans

**Level:** closed-loop response / DEC-0011 funding-plan consent

### Initial state

Use an otherwise-valid Household-mediated marriage proposal with total dowry cost C where current head P is the valid role-scoped responder.

Construct a world in which:

- ordinary provision backing can fund the action;
- P also has disposable private capacity;
- both `Accept(no private term)` and at least one `Accept(X)` funding-plan variant are semantically feasible.

### Assertions

- there is one `ResponseDecisionContext(P, proposal)`;
- Accept/Decline remain the response meanings;
- feasible Accept candidates may differ by explicit funding-plan term X;
- selecting `Accept(X)` records P's private-property consent separately from role authority;
- no nested/self response context is opened;
- no additional personal initiative is consumed;
- changing only the holder-private funding preference may change X while keeping the proposal, role authority and social Accept meaning unchanged.

### Insufficient-backing companion

Make ordinary backing insufficient but P capable of supplying enough private X.

- at least one feasible `Accept(X)` candidate remains available;
- the interaction is not classified Unable merely because standing commitment backing alone is insufficient.

Then reduce P's disposable private capacity so no funding plan can cover C.

- no valid Accept funding plan remains;
- ordinary feasibility semantics may produce `Unable(reason)` before voluntary response scoring.

### No-consent / no-seizure companion

Where backing alone is insufficient but an X-bearing Accept plan would be feasible, use a response policy that chooses Decline.

- no private grain is debited;
- office authority does not compel supplementation.

## Family semantic mutants that must be detected

- initiator's score directly determines target acceptance;
- a current self-counterparty proposal reaches target response activation instead of categorical rejection;
- categorically invalid term reaches response scoring or is mislabeled as a social failed attempt;
- infeasible proposal is voluntarily Declined instead of Unable;
- Accept preference bypasses feasibility;
- response consumes target personal initiative;
- only one response context is allowed per target/cycle;
- second response observes uncommitted effect of first response;
- accepted-but-conflicting proposal is rewritten as Declined;
- called-favour fulfilment opens a nested response context or consumes another personal initiative;
- called-favour Unable/Invalidated outcome consumes the favour or fires +10/-20;
- two accepted same-person Residence transitions both commit in one cycle;
- role response profile grants authority to a non-role actor;
- response decision trace omits candidates/components/selected response;
- role-scoped material response treats insufficient standing backing as Unable even though a valid X-bearing Accept funding plan exists;
- Accept with private supplementation opens a second self-response or consumes another personal initiative;
- response trace fails to distinguish role authority from holder-private consent.
