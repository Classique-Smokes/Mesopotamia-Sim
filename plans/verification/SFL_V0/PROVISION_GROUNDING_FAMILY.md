# VS-SFL-04x — Grounded Provision / Support / Dowry Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§4.2, 8, 9.2.  
**Status:** CANONICAL EXCEPT multi-contributor debit-trace subcase, which is gated on an open semantic erratum.

These cards prove that household material capability is grounded in explicit personal backing rather than a pooled household treasury or label-only authority.

## Family invariants

- personal grain remains personal until a collective expenditure commits;
- a provision commitment exposes `max(0, grain - 2)`;
- a contributor with `NeedsGrain` exposes zero;
- `SustainingParticipant` alone grants no material access;
- household expenditure requires Active H + occupied valid head + in-scope authority + sufficient current provision capacity;
- one collective expenditure debits backing personal grain exactly once;
- no collective spend may make personal grain negative or penetrate the 2-grain reserve;
- household support and mediated-marriage dowry are the only v0 collective material uses;
- dissolution terminates provision commitments without transferring unspent grain.

---

## VS-SFL-040 — Commitment exposes capacity without pooling grain

**Level:** mechanism-isolation

### Initial state

Begin from a verified Active H with occupied recognized head P and sustaining participant A.

At the relevant decision snapshot:

- A grain = 7;
- A `NeedsGrain = false`;
- no provision commitment from A to H exists.

### Sequence

1. P requests a household provision commitment from A.
2. A accepts.
3. No collective expenditure occurs.

### Assertions

- A grain remains 7;
- one `HouseholdProvisionCommitment(A -> H)` exists;
- derived exposed capacity from A is 5;
- H has no independent/persistent pooled grain stock created by acceptance;
- history records request/acceptance/commitment creation separately from any later spend.

### Ablations

- same sustaining participation with no accepted commitment -> exposed capacity 0;
- A grain = 2 -> commitment may exist but exposed capacity 0;
- A grain = 1 -> exposed capacity 0;
- A has `NeedsGrain` with grain >2 -> exposed capacity still 0.

---

## VS-SFL-041 — One-grain household support is grounded and clears need

**Level:** mechanism-isolation

### Initial state

Verified Active H with:

- head P;
- contributor A, grain 7, valid provision commitment -> exposed capacity 5;
- recipient B, current SustainingParticipant, grain 0, `NeedsGrain = true`;
- B recognizes P.

### Sequence

P proactively proposes 1-grain household support to B, or B requests support and P accepts/authorizes it.

### Assertions

On valid commit:

- A grain decreases exactly once from 7 to 6;
- B grain increases exactly once from 0 to 1;
- no household treasury balance is debited/credited;
- B's `NeedsGrain` clears under the ordinary 1-grain clearing rule;
- A remains above the protected reserve;
- history identifies H/head context, backing commitment, contributor debit, recipient credit, and causal support event.

### Negative controls

- remove A's provision commitment -> support unavailable/unable;
- make A `NeedsGrain` -> A contributes zero and support unavailable if no other backing;
- H Inactive -> no household-mode support;
- head vacant -> no household-mode support;
- B not a current SustainingParticipant -> household support route unavailable.

---

## VS-SFL-042 — One-contributor mediated-marriage dowry

**Level:** mechanism-isolation

### Initial state

Verified Active H with head P, bride B, and contributor A.

At decision snapshot:

- A grain = 8; valid provision commitment -> capacity 6;
- proposed dowry = 3;
- groom G satisfies ordinary marriage eligibility;
- mutual-strong-like bypass is unavailable;
- G knows B's current SustainingParticipant relation to H;
- G recognizes H and P's current head/scope;
- G does not already owe P a favour;
- G != P;
- P accepts the mediated proposal.

### Assertions

On commit:

- A grain decreases exactly once by 3;
- G grain increases exactly once by 3;
- no intermediate household grain ownership appears;
- marriage B<->G is created;
- G receives exactly one favour owed to P;
- A's remaining provision capacity is derived from its new personal grain;
- all material and relation effects share causal references to the mediated-marriage commit.

### Negative controls

- proposed dowry > current capacity -> no marriage commit through this route;
- remove provision commitment -> no funded mediated commit;
- groom already owes P a favour -> mediated route invalid;
- remove groom's bride->H fact or H/head recognition -> mediated candidate unavailable;
- use mutual-strong-like bypass instead -> no dowry spend and no groom->head favour.

---

## VS-SFL-043 — Dissolution terminates backing without confiscation

**Level:** mechanism-isolation

### Initial state

H has valid provision commitments from A and B with unspent exposed capacity.

### Sequence

Ordinary participation ends lead H to Dissolved at stable cycle closure.

### Assertions

- all `HouseholdProvisionCommitment(* -> H)` relations terminate;
- no personal grain moves merely because H dissolves;
- former contributors retain their personal grain;
- H exposes zero future collective capacity;
- historical commitment/spend records remain queryable.

---

## VS-SFL-044 — Provision reconsideration cooldown

**Level:** boundary

### Initial state

Active H with head P and non-contributing sustaining participant A.

### Sequence

1. P requests provision commitment; A voluntarily declines.
2. Hold all relevant context unchanged.
3. Inspect request eligibility before three full cycles have elapsed.
4. Allow three full cycles to elapse but still hold relevant context unchanged.
5. Change exactly one accepted relevant context dimension:
   - A grain/NeedsGrain; or
   - A attitude toward P; or
   - head occupant; or
   - new household material need.

### Assertions

- before three full cycles: repeat request ineligible;
- after cooldown alone but no relevant context change: still ineligible;
- only after both cooldown completion and relevant context change: reconsideration becomes eligible when the head deliberates;
- refusal does not create a provision commitment.

### Metamorphic companion

Changing an irrelevant attribute not listed by the spec must not unlock reconsideration.

---

## VS-SFL-045 — Protected reserve boundary

**Level:** boundary

For a non-`NeedsGrain` committed contributor, assert exposed capacity at the decision snapshot:

| Personal grain | Capacity |
|---:|---:|
| 1 | 0 |
| 2 | 0 |
| 3 | 1 |
| 4 | 2 |

Repeat with `NeedsGrain = true`; capacity is 0 at every tested grain value.

No spend may push personal grain below 2.

---

## VS-SFL-046 — Multi-contributor expenditure

**Status:** BLOCKED ON SEMANTIC ERRATUM

Accepted semantics specify:

- contributors are debited "largest available surplus first";
- stable semantic ID breaks otherwise unresolved ties.

The authoritative material does **not** specify whether ranking is:

1. fixed once at the start of the expenditure and each contributor is exhausted in that order; or
2. recomputed as each unit is debited.

These strategies produce different contributor debit histories while both satisfy the current prose.

Stage 3 must not choose between them. Once resolved, this card must test:

- exact contributor debit vector;
- stable-ID tie behavior;
- ID-permutation sensitivity only when the tie fallback is reached;
- total spend conservation;
- protected reserve for every contributor;
- exactly-once debit history.
