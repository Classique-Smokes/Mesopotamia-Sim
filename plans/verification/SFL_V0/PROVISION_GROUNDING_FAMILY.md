# VS-SFL-04x — Grounded Provision / Support / Dowry Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§4.2, 8, 9.2.  
**Status:** CANONICAL.

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
- groom == mediating head -> mediated route invalid;
- remove groom's bride->H fact or H/head recognition -> mediated candidate unavailable;
- use mutual-strong-like bypass instead -> no dowry spend and no groom->head favour.

### Female-head self-mediation companion

Use a female bride B who is also the valid head of H, with groom G distinct from B and every other mediated-route condition satisfied.

- B may receive/resolve G's mediated proposal in her head role;
- the route is not rejected merely because the bride is the head;
- provision/dowry/favour accounting remains otherwise identical.

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

### Interpretation boundary

The three-cycle rule is a deliberately crude v0 anti-repeated-solicitation proxy:

> do not repeatedly ask someone who already refused unless enough time has passed and circumstances have meaningfully changed.

It is not a historical/psychological bargaining model and should remain replaceable by later richer behavior/negotiation machinery.

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
   - new Household material need.

### Assertions

- before three full cycles: repeat request ineligible;
- after cooldown alone but no relevant context change: still ineligible;
- only after both cooldown completion and relevant context change: reconsideration becomes eligible when the head deliberates;
- refusal does not create a provision commitment;
- a later refusal establishes a fresh reconsideration baseline.

### Material-need historical witness

Use a target A who refuses at cycle N.

Hold A's grain/`NeedsGrain`, attitude toward P, head occupant, and all other accepted context dimensions unchanged.

At N+1, introduce an otherwise-valid mediated-marriage route with positive dowry through the recognized current H/head, but make every funding plan infeasible.

Assertions:

- the dowry material-need occurrence is recorded even though the action is `Unable` for lack of funding;
- the need does not have to remain current through N+4;
- before the three full cycles elapse, A remains ineligible;
- at N+4, A is eligible because cooldown + historical material-need context change are both satisfied;
- if A refuses again at N+4, the N+1 need cannot satisfy a later reconsideration after that new refusal.

### Support-need companion

After refusal, make an eligible current sustaining participant newly enter or re-enter the accepted Household-support need state.

Assertions:

- the new support-need occurrence satisfies the context-change limb;
- an uninterrupted support need already present at the refusal does not become “new” merely because time passes;
- clearing and later re-entering the eligible need state is a new occurrence.

### Identity / provenance controls

- ProposalId, container order, replay allocation identity, or retry-object identity alone cannot create context change;
- qualifying material-need occurrence must have authoritative causal provenance;
- once one qualifying need occurrence has satisfied the context-change limb for a refusal baseline, duplicate/repeated occurrences do not add further eligibility for that same baseline;
- no generic pending-demand/adoption subsystem is required.

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

## VS-SFL-046 — Multi-contributor fixed-rank expenditure

**Level:** mechanism-isolation / boundary  
**Claim:** one collective expenditure computes contributor rank once at precommit and exhausts contributors in that fixed order.

### Positive allocation

At precommit:

- contributor A personal grain = 7 -> exposed capacity 5;
- contributor B personal grain = 5 -> exposed capacity 3;
- both have valid provision commitments and are not NeedsGrain;
- requested collective expenditure = 6.

Expected fixed ranking: A(5) before B(3).

### Assertions

- total validated capacity = 8;
- expenditure commits;
- A debit = 5, ending grain 2;
- B debit = 1, ending grain 4;
- total contributor debit = 6 exactly;
- no contributor falls below reserve 2;
- rank is **not recomputed** after A's first debit;
- semantic history records the exact debit vector and backing commitments.

### Exact-tie companion

At precommit:

- A exposed capacity = 3;
- B exposed capacity = 3;
- requested expenditure = 4.

Stable semantic person ID orders the initial exact tie.

Assertions:

- lower fallback ID contributor is ranked first and pays 3;
- second contributor pays 1;
- history explicitly marks technical-ID fallback use;
- permuting only the nonsemantic stable IDs may swap the debit vector across actors;
- total material effect remains 4 and reserve invariants remain satisfied.

### Insufficient-capacity control

If validated capacities sum to less than requested spend:

- expenditure does not commit;
- no partial contributor debit becomes authoritative;
- failure is explicit;
- no household treasury/negative balance is created.

### Mutation controls

Must fail if implementation:

- reranks contributors after each grain/unit debit;
- splits the expenditure into independent mini-spends;
- uses collection order before surplus ranking;
- penetrates a contributor's reserve;
- debits any backing grain twice.


---

## VS-SFL-047 — Transaction-specific holder funding plan

**Level:** mechanism-isolation / funding-plan semantics  
**Semantic source:** SPEC §8.1.1 + DEC-0011.

Use an otherwise-valid permitted Household material action with total cost `C = 3`, current head P, and a separate committed contributor A.

### Variant A — no private term

- no holder-private supplement term is present;
- ordinary valid commitment backing must fund all 3.

If ordinary backing can fund 3, the action may commit with no P private debit.

### Variant B — explicit partial contribution despite sufficient backing

Use the same Household action and a world where ordinary commitments could fund all 3.

P explicitly authorizes exact private contribution `X = 1`.

Assertions:

- P privately funds exactly 1;
- commitment-backed allocation funds exactly `R = 2`;
- the allocator does not ignore X merely because standing backing was sufficient;
- P's contribution is causally identified as private-owner authorization, not office seizure;
- no persistent provision commitment is created by X.

### Variant C — shortfall supplementation

Ordinary commitment backing can fund only 2.

P explicitly authorizes `X = 1`.

- combined funding permits the action;
- without X, the otherwise identical action remains unfunded;
- the Household does not seize P's grain in the no-X control.

### Variant D — full private funding

P authorizes `X = C = 3`.

- commitment-backed funding requirement is 0;
- the action may commit entirely from P's private disposable grain;
- standing `MobilizableCapacity(H)` is unchanged by the authorization.

### Quantity controls

- absent term represents no contribution;
- present X = 0, negative, non-integral/unrepresentable-without-coercion, or X > C is categorically invalid;
- invalid X does not reach downstream role response/social-failure processing.

### Persistence controls

After one successful X-funded action:

- no new persistent `HouseholdProvisionCommitment(P -> H)` exists unless independently created by the accepted provision-request path;
- a later Household action receives no private capacity from the earlier X.

---

## VS-SFL-048 — Same holder commitment plus private contribution cannot double-count grain

**Level:** mechanism-isolation / arithmetic oracle  
**Semantic source:** SPEC §8.1.1 + DEC-0011.

At precommit:

- P is current head;
- P grain = 7 -> ordinary disposable/exposed capacity 5;
- P also has a valid persistent provision commitment to H;
- A grain = 3 -> committed capacity 1;
- total Household material cost C = 6;
- P explicitly authorizes private X = 2;
- residual commitment requirement R = 4.

Expected transaction-local capacities:

- P private leg = exactly 2;
- P effective commitment-side capacity = 3, not 5;
- A commitment-side capacity = 1.

Expected funding:

- P private debit = 2;
- commitment allocation funds R = 4 using P(3) + A(1);
- P aggregate personal debit = 5, ending grain 2;
- A debit = 1;
- no grain unit is counted through both provenance channels.

### Insufficient combined-capacity companion

Raise C so that, after fixing X and reducing P's commitment-side capacity by X, R exceeds actual commitment capacity.

The action must fail atomically even if a naive checker using P's unreduced commitment capacity would appear to make the total sufficient.

### Ranking control

The fixed-rank commitment allocator ranks contributors using their **transaction-local effective commitment capacities after accounting for P's exact X**.

This is arithmetic implied by the fixed funding plan, not a global private-first social priority.

---

## VS-SFL-049 — Private supplementation provenance is not a second personal transfer

**Level:** provenance / nonauthority / causal-legibility

Run both permitted Household material-use meanings with an explicit valid X where applicable:

1. 1-grain Household support;
2. mediated-marriage dowry.

Assertions:

- history distinguishes role authority, P private authorization, P private debit, commitment-backed debits, recipient/effect, and total cost;
- the supplement creates no ordinary Gift/Help/Loan event;
- the supplement creates no ordinary-transfer attitude consequence;
- the supplement creates no independent favour;
- the supplement cannot satisfy formation/participation/continuity/fresh-lineage support evidence;
- Household-originated support remains non-self-confirming;
- mediated marriage creates exactly the already-accepted groom -> mediating-head favour and no additional favour from X;
- successor occupancy never inherits or reuses a predecessor's prior X.


---

## VS-SFL-050 — Current head may receive Household support

**Level:** alias / institutional-authorizer = beneficiary  
**Semantic source:** SPEC §8.3 + DEC-0013 D3.

### Initial state

Active H with current head P.

- P is a current `SustainingParticipant`;
- P is `NeedsGrain` and otherwise eligible for the ordinary 1-grain Household support effect;
- valid transaction funding exists from other permitted sources;
- P's current head-role authority is valid.

### Action topology

H proactively proposes support to P through `HouseholdDecisionContext(H, head=P)`.

Do **not** create:

- a P->P support request;
- a P->P response context;
- an extra personal initiative.

### Required result

If all ordinary live preconditions remain valid:

- H may commit the 1-grain Household support to P;
- P's role-authorizer capacity and beneficiary capacity remain distinct in trace/history;
- the support remains Household-originated;
- because P is `NeedsGrain`, P exposes neither private-X capacity nor commitment-side exposed capacity under the current scaffold;
- the support cannot become formation/continuity/fresh-lineage evidence.

### Negative controls

Must fail if implementation:

- rejects P solely because head==recipient;
- creates self-request/self-response theatre as a precondition;
- lets office authority expose P's protected/private grain;
- relabels the Household support as an ordinary personal Help/Gift.

---

## VS-SFL-051 — Current head may explicitly create own persistent v0 provision commitment

**Level:** alias / dual-capacity standing-resource consent  
**Semantic source:** SPEC §8.2 + DEC-0013 D4.

### Initial state

Active H with current head P.

- P is a current non-contributing `SustainingParticipant`;
- P is otherwise eligible to expose standing v0 provision capacity;
- no `HouseholdProvisionCommitment(P -> H)` currently exists.

### Required topology

P may explicitly authorize the persistent commitment in the distinct private-resource capacity while also being the current head.

The trace must preserve separately:

1. H/head institutional request/need authority;
2. P's private-resource authorization of the standing relation.

No P->P `ResponseDecisionContext` is opened and no second personal initiative is consumed merely to represent the second capacity.

### Required result

- exactly one provenance-bearing `HouseholdProvisionCommitment(P -> H)` is created;
- office occupancy alone would not have created it;
- ordinary exposed-capacity, termination, reconsideration and cooldown semantics apply thereafter;
- the relation remains the synthetic v0 standing-access mechanism and creates no Household-owned treasury/property.

### Refusal / reconsideration companion

Exercise a prior explicit non-consent/refusal by P and verify that the ordinary three-full-cycle + relevant-context-change reconsideration gate still applies. Head occupancy does not erase the refusal history or manufacture a new first request.

### Negative controls

Must fail if implementation:

- creates the commitment merely because P holds office;
- forbids the relation solely because requester/head and private owner are the same PersonId;
- uses a self-directed response loop;
- treats the relation as historical/general Household property rather than current v0 access state.
