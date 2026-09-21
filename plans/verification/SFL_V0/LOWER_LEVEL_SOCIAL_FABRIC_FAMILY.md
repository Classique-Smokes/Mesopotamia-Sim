# VS-SFL-09x — Lower-Level Social Fabric Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§2–5 and §9.  
**Purpose:** Give the lower-level substrate the same explicit acceptance coverage as household/continuity semantics.

Mechanism-isolation cards may submit proposal responses through the public response/resolution boundary; they do not define the general response-choice policy.

## Family invariants

- transfer meanings remain explicit even where material code paths are shared;
- relation histories survive satisfaction/termination where the spec requires historical queryability;
- no lower-level relation silently becomes household membership;
- one personal voluntary initiative per cycle remains distinct from proposal responses;
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

### Gift

A offers genuine Gift(1), B accepts.

- grain transfers A -> B;
- no Debt is created;
- no Favour is created merely by gift meaning;
- accepted-gift attitude consequence applies B -> A +10;
- history meaning = Gift.

### Loan

A grants Loan(1) to B.

- grain transfers A -> B;
- Debt(A creditor, B debtor, original=1, remaining=1) is created;
- borrower -> lender attitude +5;
- no Favour is created merely by loan meaning;
- history meaning = Loan.

### Explicit benefit-for-favour

A offers a benefit in exchange for one favour; B knowingly accepts.

- the specified material/benefit effect commits;
- exactly one B -> A Favour is created if pair-capacity permits;
- history meaning = ExplicitBenefitForFavor.

### Relationship-mediated reciprocal help

B already has stored attitude >= +75 toward A and knowingly accepts qualifying help from A under this meaning.

- benefit commits;
- one B -> A Favour may arise under the accepted reciprocal-help rule;
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

### Reserve boundary

Attempt repayment that would leave debtor below 2.

- repayment cannot commit for that amount;
- debt balance remains unchanged;
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

A offers a benefit for one favour; B knowingly accepts.

- one B -> A favour is created;
- B must know the favour consequence before acceptance.

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

With one B -> A favour already outstanding, another favour-creating benefit cannot stack a second favour token for the same ordered pair.

The underlying benefit may still commit if independently valid; favour cardinality remains one.

---

## VS-SFL-094 — Called favour fulfilment, refusal, and reciprocal cancellation

**Level:** mechanism-isolation

### Fulfilment

B owes A one favour. A calls it for one otherwise-feasible ordinary action; B fulfils.

Assertions:

- requested action commits through ordinary proposal/resolution semantics;
- favour is satisfied/consumed;
- A -> B attitude +10;
- fulfilled favour does not recursively create another favour.

### Voluntary refusal

Same valid called favour; B refuses.

Assertions:

- favour remains outstanding;
- A -> B attitude -20;
- requested world effect does not commit.

### Impossible requested action

Call favour for an action that is physically/semantically infeasible or intrinsically excluded, including marriage.

- favour does not make it feasible;
- marriage cannot be compelled;
- feasibility failure remains distinguishable from voluntary refusal under ordinary failure rules.

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
- breach accepted commitment: affected counterparty -> breacher -20;
- rejected marriage proposal: 0.

### Bounds

Updates that would exceed +100/-100 saturate at the bound.

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
- favours stack above one per ordered pair;
- refused called favour disappears;
- favour compels marriage/impossible action;
- marriage automatically moves residence;
- residence change creates/destroys household participation;
- attitude decay crosses zero or runs every cycle;
- proposal response consumes or grants an extra personal initiative.
