# VS-SFL-09x — Lower-Level Social Fabric Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§2–5 and §9.  
**Purpose:** Give the lower-level substrate the same explicit acceptance coverage as household/continuity semantics.

Mechanism-isolation cards may submit proposal responses through the public response/resolution boundary; they do not define the general response-choice policy.

## Family invariants

- transfer meanings remain explicit even where material code paths are shared;
- relation histories survive satisfaction/termination where the spec requires historical queryability;
- no lower-level relation silently becomes household membership;
- grain-valued action terms obey the accepted positive-integer domain and invalid terms never reach target response;
- one personal voluntary initiative per cycle remains distinct from proposal responses;
- called-favour requested execution is response-scoped and consumes the favour only on successful commit;
- at most one Residence transition per person commits in one cycle;
- direct same-cycle attitude causes compose by net signed delta followed by one bound clamp;
- categorical gates use authoritative stored state, not amplified score components.

---

## VS-SFL-090 — Consumption, NeedsGrain, Farm, and clearing

**Level:** maintenance / mechanism-isolation

### A. Successful consumption

Actor A begins a cycle with grain 1 and `NeedsGrain = false`.

After maintenance:

- consumption debits 1;
- A grain = 0;
- A does not gain NeedsGrain merely because stock reached zero after successful consumption.

### B. Missed consumption

At a later maintenance step A has grain 0.

Assertions:

- required consumption cannot be paid;
- A gains persistent `NeedsGrain`;
- no negative grain appears.

### C. Farming gate

While `NeedsGrain = true`:

- `Farm` is not a feasible personal candidate;
- no Farm commit may generate grain.

### D. Need clearing

Transfer 1 grain validly to A.

Assertions:

- A holds at least the next 1-grain consumption unit;
- NeedsGrain clears;
- Farm may become candidate-feasible again on a later voluntary activation;
- no same-cycle voluntary reactivation is granted merely by clearing the need.

### E. Farm effect

For a non-needy actor whose Farm action commits:

- personal initiative is consumed;
- exactly +4 grain is produced;
- history identifies Farm as the source rather than an unexplained balance change.

---

## VS-SFL-091 — Explicit transfer meanings remain distinct

**Level:** mechanism-isolation / history

Use otherwise comparable 1-grain transfers between A and B.

### Gift/help

Exercise both an `OfferGift` and a `RequestGiftOrHelp` followed by accepted voluntary help, preserving the action's explicit meaning in history.

For the genuine Gift case, A offers Gift(1), B accepts.

- grain transfers A -> B;
- no Debt is created;
- no Favour is created merely by gift meaning;
- accepted-gift attitude consequence applies B -> A +10;
- history meaning = Gift.

### Loan

Exercise both accepted initiation forms in paired runs:

- A `OfferLoan(1)` to B and B accepts;
- B `RequestLoan(1)` from A and A accepts.

Both successful routes create the same Loan semantic effect with roles determined by actual creditor/debtor.

- grain transfers A -> B;
- Debt(A creditor, B debtor, original=1, remaining=1) is created;
- borrower -> lender attitude +5;
- no Favour is created merely by loan meaning;
- history meaning = Loan.

### Explicit benefit-for-favour

A uses `OfferBenefitForFavor`; B knowingly accepts the proposed benefit-for-one-favour bargain while B -> A favour capacity is available.

- the specified material/benefit effect and exactly one B -> A Favour commit atomically;
- history meaning = ExplicitBenefitForFavor;
- the event is not relabeled as Gift/Help and does not inherit Gift/Help attitude effects merely because transfer code is shared.

### Relationship-mediated reciprocal help

B already has stored attitude >= +75 toward A and knowingly accepts qualifying help from A under this meaning.

- benefit commits;
- one B -> A Favour may arise under the accepted reciprocal-help rule if pair capacity permits;
- if pair capacity is already full, otherwise-valid/feasible/accepted help may still commit but no second favour is created;
- history meaning remains RelationshipMediatedReciprocalHelp.

The material transfer implementation may be shared; semantic history/results may not collapse these meanings.

---

## VS-SFL-092 — Debt repayment and social due review

**Level:** mechanism-isolation / temporal boundary

### Setup

Loan committed in cycle N creates debt remaining 4.

### Partial repayment

Debtor has enough grain that RepayDebt(1) leaves at least 2.

Assertions:

- remaining becomes 3;
- debtor grain debits 1;
- creditor receives 1;
- successful repayment gives lender -> borrower +5;
- debt history remains.

### Amount validity boundary

Exercise categorical term validation before target response/world feasibility:

- `RepayDebt(0)` -> invalid term; no social failed-attempt outcome or material effect;
- negative/non-integral repayment -> invalid term;
- `RepayDebt(amount > remaining)` -> invalid term; no clamping/credit/meaning conversion;
- `RepayDebt(remaining)` remains semantically valid, subject to reserve/material feasibility.

### Reserve boundary

Attempt a semantically valid repayment amount that would leave debtor below 2.

- outcome is `Unable(reason)` when infeasibility is already present at feasibility evaluation;
- debt balance remains unchanged;
- no refusal attitude consequence;
- no negative grain.

### Full repayment

Later repay all remaining balance while reserve permits.

- remaining becomes 0;
- current claim is satisfied;
- debt/repayment history remains queryable.

### Due-cycle penalty

In a separate run leave any balance outstanding through the review after cycle N+3 decisions/commits.

Assertions:

- before that review: no social-due penalty;
- at that review: creditor -> debtor attitude -10 exactly once;
- penalty applies regardless of debtor material ability;
- later cycles do not repeat that due penalty;
- no interest, enforcement, automatic seizure, or grain reservation is created.

---

## VS-SFL-093 — Favour creation gates and cardinality

**Level:** boundary / mechanism-isolation

### Explicit bargain

A offers a benefit for one favour; B knowingly accepts while B -> A favour capacity is available.

- material benefit and one B -> A favour commit atomically;
- B must know the favour consequence before acceptance;
- history meaning remains ExplicitBenefitForFavor.

### Relationship-mediated reciprocity boundary

Run otherwise identical accepted reciprocal-help events with B's stored attitude toward A:

- +74 -> no favour through strong-like reciprocity;
- +75 -> favour may be created;
- +76 -> favour may be created.

Kinship amplification cannot turn stored +74 into gate-passing +75.

### Genuine gift control

Identical beneficial transfer explicitly meaning Gift:

- no favour is created.

### One-per-ordered-pair

With one B -> A favour already outstanding:

- a new `ExplicitBenefitForFavor(A -> B, benefit)` is world-state infeasible because its promised new favour cannot exist;
- if deliberately submitted through the public mechanism-isolation boundary, outcome is `Unable(FavourCapacityFull)`; no scored Accept/Decline, no material benefit, and no new favour;
- if the pair slot was available at acceptance but is filled before commit, outcome is `InvalidatedAtResolution(FavourCapacityFull)`; neither bargain leg commits;
- relationship-mediated reciprocal help remains independently meaningful: otherwise-valid/feasible/accepted help may commit, but favour cardinality remains one.

The suite must fail an implementation that silently degrades a failed explicit bargain into Gift/Help.

---

## VS-SFL-094 — Called favour fulfilment, refusal, and reciprocal cancellation

**Level:** mechanism-isolation

### Response-closed fulfilment

B owes A one favour. A uses `CallFavor` for a requested action that satisfies the v0 response-closed callable predicate: after B's Fulfil/Refuse choice, no further voluntary actor response is required for the requested action to reach terminal commit/failure.

Use a declared current action shape that satisfies that predicate. B may already have selected/executed its ordinary personal initiative in the same cycle.

Assertions:

- B's Fulfil/Refuse choice is a response and does not consume/grant B's personal initiative;
- requested execution occurs within that response scope and does not consume a second B personal initiative;
- requested action remains subject to ordinary world feasibility and central revalidation;
- on successful requested-action commit, the favour is satisfied/consumed and A -> B attitude +10;
- no nested `ResponseDecisionContext` is opened;
- fulfilled favour does not recursively create another favour.

### Non-callable payload

Construct a requested action that would require a new third-party voluntary response, establish marriage/kinship, manipulate another favour, or require household/role authority.

Assertions:

- the CallFavor term is categorically invalid before B response activation;
- no Fulfil/Refuse scoring occurs;
- favour remains outstanding;
- no material/relation/attitude effect occurs;
- the validation rejection is not `Declined`, `Unable`, or `InvalidatedAtResolution`.

### Unable

Use a semantically valid response-closed payload whose world-state feasibility is already false when evaluated.

Assertions:

- outcome is `Unable(reason)`;
- no voluntary Fulfil/Refuse scoring occurs;
- favour remains outstanding;
- requested world effect does not commit;
- no +10/-20 called-favour attitude effect fires.

### Voluntary refusal

Use a valid, feasible called-favour payload; B selects RefuseCalledFavor.

Assertions:

- outcome is `Declined`;
- favour remains outstanding;
- A -> B attitude -20;
- requested world effect does not commit;
- refusal does not consume B's personal initiative.

### Resolution invalidation

Use a valid, feasible payload; B selects FulfilCalledFavor, then another same-cycle effect removes an action-relevant precondition before commit.

Assertions:

- outcome is `InvalidatedAtResolution(reason)`;
- favour remains outstanding;
- requested world effect does not commit;
- no +10/-20 called-favour attitude effect fires.

### Reciprocal cancellation

A owes B one favour and B independently owes A one favour.

- either side may trigger atomic reciprocal cancellation;
- both outstanding favours become satisfied;
- no third favour is created;
- no partial favour balance exists.

---

## VS-SFL-095 — Direct mutual-strong-like marriage bypass

**Level:** mechanism-isolation / boundary

### Positive bypass

Eligible male groom G and female bride B:

- stored G -> B attitude >= +75;
- stored B -> G attitude >= +75;
- not parent/child or siblings;
- neither already has an established v0 marriage.

G proposes marriage.

Assertions on accepted commit:

- marriage relation is created directly;
- no household mediation is required;
- no dowry/provision expenditure occurs;
- no groom -> head favour is created;
- marriage does not automatically change either residence.

### Attitude boundary

Pair with one direction +74:

- direct strong-like bypass unavailable.

Kinship amplification never satisfies this stored-attitude gate.

### Kinship exclusion

Parent/child or siblings remain marriage-ineligible even if both stored attitudes are >= +75.

### Lifetime cardinality

Once either person has an established v0 marriage, a second establishment cannot commit in v0.

Rejected earlier proposals do not consume eligibility.

---

## VS-SFL-096 — Residence proposal semantics

**Level:** mechanism-isolation

### Move proposal

A proposes moving to B's current dwelling; B accepts.

- A's Residence relation changes to B's dwelling;
- named counterpart acceptance is sufficient in v0 even if other residents exist;
- no ownership right is created;
- no SustainingParticipant relation is created/removed solely by residence change;
- no Household identity is created/destroyed/split/merged solely by the move.

### Invite proposal

A invites B into A's current dwelling; B accepts.

Apply the same assertions symmetrically.

### Competing accepted Residence proposals

From one common snapshot, create two independently accepted proposals whose effects would change B's Residence to different dwellings and for which no semantic priority distinguishes the contenders.

Assertions:

- both Accept responses remain in history;
- exactly one Residence transition for B commits;
- the winner follows the ordinary conflict rules and, if still equal-priority, the disclosed stable-ID fallback with fallback marker;
- the non-winning accepted proposal becomes `InvalidatedAtResolution(CompetingResidenceTransition)`, not Declined;
- reversing nonsemantic proposal/container enumeration does not change the winner/history for fixed semantic IDs;
- B does not make two sequential Residence transitions in the cycle.

### Marriage control

Establish marriage without a separate accepted residence proposal.

- residence does not change automatically.

---

## VS-SFL-097 — Attitude event updates, bounds, and decay

**Level:** boundary / maintenance

### Event updates

Independently exercise:

- accepted gift/help: recipient -> giver +10;
- loan granted: borrower -> lender +5;
- successful repayment: lender -> borrower +5;
- fulfilled called favour: holder -> fulfiller +10;
- genuine-need ordinary refusal: requester -> refuser -5;
- ordinary refusal without genuine need/accepted obligation: 0;
- called-favour refusal: holder -> refuser -20;
- social due unpaid debt: creditor -> debtor -10 once;
- rejected marriage proposal: 0.

### Bounds

A single direct update that would exceed +100/-100 saturates at the bound.

### Same-cycle direct-cause composition

Start one directed attitude at +95 after due maintenance/decay. In the same cycle, produce two distinct valid direct §3.1 causes targeting that attitude:

- one +10;
- one -20.

Assertions:

- both cause keys/deltas appear in causal history exactly once;
- authoritative direct-attitude result is `clamp(+95 + 10 - 20) = +85`;
- contributions are not clamped one-by-one;
- reversing reaction/cause enumeration produces identical authoritative state/history modulo nonsemantic presentation;
- the batch is one bounded attitude-state transition with the full cause set as predecessors.

Repeat an equivalent negative-bound case.

### Decay cadence

At each due 5-cycle maintenance event:

- positive attitude moves exactly 2 toward zero;
- negative attitude moves exactly 1 toward zero;
- zero remains zero;
- decay never crosses zero.

Check immediately before, at, and after the due cadence.

---

## VS-SFL-098 — Personal initiative versus responses

**Level:** process boundary

### Assertions

- a person normally has at most one substantive voluntary personal initiative per cycle;
- successfully initiating Farm/Gift/Loan/Marriage/Residence/Communication/etc. consumes that initiative;
- responding to incoming proposals does not consume that initiative;
- multiple responses may occur subject to response semantics and central compatibility resolution;
- accepting/responding to proposals cannot grant a second voluntary initiative;
- no semantic Wait event is required merely because the person initiates nothing.

This card checks accounting of initiative opportunities, not the unresolved general response-choice policy.

---

## Family semantic mutants that must be detected

- NeedsGrain actor Farms;
- successful consumption at grain 1 creates NeedsGrain immediately;
- all beneficial transfers create the same relation/meaning;
- full debt repayment deletes historical debt provenance;
- unpaid-debt social penalty repeats every cycle;
- repayment penetrates the 2-grain reserve;
- kinship amplification satisfies +75 favour/marriage gates;
- gift creates favour automatically;
- zero/negative/non-integral grain terms reach response or social effects;
- over-repayment is silently clamped/credited;
- explicit benefit-for-favour partially commits material benefit when required favour capacity is unavailable;
- relationship-mediated reciprocal help stacks a second favour above pair capacity;
- favours stack above one per ordered pair;
- refused/Unable/invalidated called favour disappears;
- failed called-favour execution incorrectly consumes the favour or applies fulfil/refusal attitude effect;
- called favour opens a nested response context or compels marriage/impossible action;
- marriage automatically moves residence;
- more than one Residence transition for the same person commits in one cycle;
- residence change creates/destroys household participation;
- direct same-cycle attitude causes are clamped sequentially so cause enumeration changes the bounded result;
- attitude decay crosses zero or runs every cycle;
- proposal response consumes or grants an extra personal initiative.


---

## VS-SFL-099 — Scoring-domain relationship checks

**Level:** closed-loop / scorer boundary

### Kinship amplification

Use `SCORE-VP-004`.

Compare otherwise identical ordinary interpersonal candidates toward:

- non-kin target T1;
- kin target T2;

with equal stored attitudes.

Assertions:

- kin target's attitude-derived score component is exactly 1.5x the non-kin component using exact integer scaling;
- stored attitude remains unchanged;
- categorical +75 gates still read stored attitude.

### Co-residence motivation ordering

Use a verification-only scoring profile that isolates the accepted relative rule:

- strong mutual positive relationship contributes a positive co-residence component;
- established marriage contributes a strictly larger co-residence component.

The numeric magnitudes are laboratory configuration; only `marriage incentive > strong-mutual-positive incentive` is a semantic assertion.

This companion must not make marriage force residence change; it affects proposal motivation only.
