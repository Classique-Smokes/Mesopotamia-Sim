# SFL v0 Slice 4 — Office-Holder Private Resource Supplementation Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / LOCAL SEMANTIC PATCH IDENTIFIED / ONE DIRECTOR FUNDING-ORDER DECISION PENDING  
**Date:** 2026-09-24  
**Blocked implementation boundary:** `sfl-v0-slice4-implementation-boundary-blocked-v1` @ `7ce569456c87297e7349b3ca7d7917c5e30b1b88`  
**Source:** Director clarification “Office-Holder Voluntary Private Resource Supplementation” supplied 2026-09-24  
**Authority:** reconciliation record only; no semantic promotion until the remaining funding-order question is explicitly resolved.

## 1. Judgment

The Director clarification identifies a **real missing Slice-4 semantic capability**.

Current accepted SFL v0 correctly preserves:

- personal ownership of grain;
- persistent `HouseholdProvisionCommitment(Person -> H)` as conditional reusable backing;
- derived commitment-backed Household mobilizable capacity;
- explicit scoped head authority;
- no general office power to seize private grain;
- one personal initiative plus one separate Household initiative.

However, the current §8.1 material-use path is closed over **pre-existing provision commitments**. If those commitments cannot fund the action, current semantics say the expenditure cannot commit.

Therefore current authority does not represent the following legitimate causal history:

> current head P validly authorizes an otherwise-valid Household material action and, in P's separate capacity as private owner, explicitly authorizes a bounded one-transaction debit of P's own disposable grain to help fund that same Household action.

This is not merely missing test coverage. It changes the set of valid committed histories.

The Director BLOCK is justified.

## 2. Minimal semantic amendment

For bounded SFL v0, add **transaction-specific holder private supplementation** for permitted Household material uses.

### 2.1 Current Slice-4 scope

The capability applies only to the current valid occupant P of `HouseholdHeadRole(H)`.

It does not generalize in Slice 4 to:

- arbitrary participants;
- arbitrary office types;
- general institutional finance;
- generic donations;
- treasury funding;
- reimbursement;
- political leverage/prestige;
- sacrifice below current reserve/NeedsGrain safety.

### 2.2 Dual authority

A valid supplemented Household action depends on two distinct authority sources carried by the same person P:

1. **role authority** — P is the valid current head and the Household action is in accepted role scope;
2. **personal property authority** — P explicitly authorizes use of some of P's privately owned disposable grain for this transaction.

Neither source substitutes for the other.

Consequences:

- office occupancy alone exposes no private grain;
- private ownership alone creates no Household action authority;
- the institution cannot seize P's grain;
- the fact that one PersonId carries both capacities does not collapse them into one authority channel.

### 2.3 Transaction term, not persistent backing

The private supplement is tied to one specific Household material-use attempt.

It:

- is explicit;
- is attributable to P as private owner;
- identifies the target Household transaction;
- contains a bounded positive-integer authorization amount/cap;
- creates no persistent `HouseholdProvisionCommitment`;
- does not alter H's standing commitment-derived `MobilizableCapacity(H)`;
- does not transfer ownership before commit;
- has no effect if the Household action does not commit.

No-consent is represented by absence of this private-supplement authorization, not by a zero-valued grain term.

### 2.4 No self-negotiation / no extra initiative

A same-person private supplement does **not** create:

`Head P requests provision from P -> P receives a response context -> P accepts`.

There is no independent counterparty cognition.

The supplement authorization is an explicit term/authorization within P's valid Household action deliberation.

Its selection constitutes P's personal consent over P's property while P simultaneously acts as the cognitive carrier of the Household context.

This:

- consumes no second personal initiative;
- is not a ResponseDecisionContext;
- does not create a generic extra personal action;
- does not let Household authority choose another person's private resources.

Reference closed-loop verification may use deterministic Household policy configuration to exercise offer/no-offer variants, but such profile configuration does not create semantic authority.

## 3. Standing capacity versus transaction funding

The current query:

`MobilizableCapacity(H)`

remains derived only from valid persistent provision commitments.

Potential private wealth of the current head is **not** standing Household capacity.

For one specifically supplemented action, use a distinct transaction-funding analysis:

- ordinary commitment-backed funding;
- plus at most the valid transaction-specific amount personally authorized by P;
- subject to live personal disposable capacity and the funding-order rule still awaiting Director decision.

This distinction is necessary so:

- a wealthy head does not make H globally/continuously wealthy merely by holding office;
- succession does not transfer predecessor private capacity;
- a later Household action receives no benefit from an earlier one-transaction supplement unless a separate valid authorization exists.

## 4. Personal safety / quantity domain

The clarification does not reopen reserve/NeedsGrain rules.

For Slice 4:

- P's private supplement may use only currently disposable personal capacity;
- protected reserve 2 remains intact;
- if P is `NeedsGrain`, supplement capacity is 0;
- offered supplement amount/cap is a grain-valued semantic term and therefore, when present, must be a strictly positive integer;
- zero/negative/non-integral terms are categorically invalid before downstream response/social-failure processing;
- actual committed private debit may never exceed both the authorized cap and P's live disposable personal capacity.

Deliberate below-reserve sacrifice is a separate future semantic question.

## 5. Atomicity and revalidation

The private supplement does not reserve grain at deliberation.

Immediately before commit, the Household action must revalidate:

- Active H;
- current occupied/scoped head authority;
- every action-specific gate;
- all persistent provision commitments/capacities;
- P's private-supplement authorization identity/amount;
- P's live personal grain;
- P's `NeedsGrain` state;
- protected reserve;
- any same-cycle competing material effects.

If combined valid funding is insufficient under the accepted funding-order rule:

- the Household action cannot partially commit;
- no committed contributor debit persists;
- no private-supplement debit persists;
- no Household effect persists.

If another precondition invalidates the action, the supplement likewise produces no standalone material/social effect.

DEC-0010 remains applicable: an otherwise-valid accepted old-head Household action may perform its valid last act before the paired authority-destroying transition, but all non-authority material preconditions above still revalidate.

## 6. Same-person double-count protection

A head P may independently have:

- a persistent `HouseholdProvisionCommitment(P -> H)`; and
- a transaction-specific private supplement authorization for the same Household action.

These are distinct funding provenance channels but draw from **one personal grain stock**.

The implementation must never count the same exposed grain unit twice.

The final funding computation must ensure that any committed debit of P through ordinary commitment allocation reduces the personal disposable capacity available for transactional supplementation, or vice versa according to the Director-approved funding order.

History must retain both source classifications even if the final material ledger contains one aggregate debit to P.

## 7. Effect identity: funding is not a second personal Gift/Help

A transaction-specific private supplement is the funding provenance of the Household effect.

It is not a separate ordinary person-person `Gift`, `Help`, `Loan`, or favour-creating benefit merely because P's grain is debited.

Therefore the supplement itself:

- creates no second voluntary personal action;
- creates no automatic attitude consequence as an ordinary personal transfer;
- creates no independent favour unless the underlying Household action already has its own accepted favour semantics;
- cannot count as fresh person-person support for Household formation, participation, continuity, or lineage;
- does not convert Household-originated support into independent self-confirming organizational evidence.

For mediated marriage, the accepted groom -> mediating-head favour remains exactly the route-specific favour; private supplementation does not create an additional favour.

## 8. History / causal provenance

For a committed supplemented action, semantic history must distinguish at least:

- H;
- persistent head role;
- current occupant P;
- underlying Household action and role authority;
- ordinary commitment-backed contributor allocations and exact debit amounts;
- P's transaction-specific private authorization cap;
- actual private-supplement amount consumed;
- P as owner/debited person;
- final recipient/material effect;
- rule/configuration version;
- causal predecessors.

A macro account such as “H paid 3 grain” must be reconstructable into the distinct lower-level funding sources.

No Household treasury or unowned pooled balance is introduced.

## 9. Initiative / central-resolution implications

The clarification composes cleanly with existing dual-mode semantics.

- P still receives exactly one ordinary personal initiative.
- H still receives exactly one separate Household initiative through P.
- supplement authorization is a term of the Household action, not another personal initiative.

Because it is part of the Household material action, existing §9.2 central resolution still governs conflicts with P's separate personal material action.

In particular, the existing accepted priority:

`eligible NeedsGrain Household support > other valid Household provision expenditure > ordinary voluntary personal transfer`

still applies.

Therefore a supplemented Household action does not reserve P's grain early. It resolves in the Household material-use priority class, commits its actual debits atomically if still valid, and then lower-priority personal transfers revalidate against the resulting grain.

This is a consequence of existing authority once supplementation is defined as part of the Household action; no new Director choice is required for that race.

## 10. Succession / holder change

Transaction-specific private supplementation is not role property.

Therefore:

- appointment/succession does not create a supplement;
- successor B receives the role, not predecessor A's private authorization;
- an uncommitted A-specific supplement cannot rebind to B;
- after succession, any B-funded later transaction requires B's own explicit authorization;
- standing persistent provision commitments continue/terminate only under their own existing semantics.

DEC-0010 may permit A's otherwise-valid accepted supplemented last act to commit before same-cycle succession/exit if every other precondition remains valid.

## 11. Current authority defects created by the missing capability

Frozen Slice-4 acceptance v1 is now known to be incomplete for implementation authorization.

At minimum, current v1 assumes/permits implementation shapes where:

- `S4-077` Household support requires “sufficient current backing” only through commitments;
- `S4-084` treats commitment capacity insufficiency as terminal without a holder-supplement path;
- `S4-085` records debit vector/backing commitments but not distinct transactional private funding;
- `S4-086` revalidates backing/capacity without private-supplement authorization/capacity;
- `S4-090` correctly forbids treasury but does not distinguish standing backing from transaction funding;
- `S4-100/106/112/113` mediated marriage similarly assume dowry funding from commitment-backed contributors;
- `S4-057` shared-resource conflict does not explicitly include the same head grain being available through transaction supplementation;
- `S4-160` material invariants do not yet require no-double-count across persistent and transactional funding channels.

These rows remain immutable historical frozen v1 evidence. They must not be edited in place.

A successor Slice-4 acceptance version is required after semantic promotion.

## 12. Required new omission-detectable acceptance witnesses

A successor acceptance candidate must add or strengthen explicit witnesses for:

1. **persistent backing unchanged** — head may have ordinary commitment; office change alone creates/deletes none;
2. **transaction-specific supplement positive** — committed backing shortfall + explicit valid P authorization allows combined commit under approved funding order;
3. **no-consent control** — same world without authorization cannot debit P;
4. **bounded authorization** — actual private debit <= authorized cap;
5. **positive-integer term validity** — invalid supplement terms never activate action processing;
6. **no persistent side effect** — supplement creates no provision commitment;
7. **initiative independence** — P may supplement inside H action even after P's personal initiative is used;
8. **explicit provenance** — history distinguishes commitment-backed and private-supplement funding;
9. **reserve/NeedsGrain safety** — P private supplementation preserves existing safety rules;
10. **standing-capacity noninflation** — offered/possible supplement does not change `MobilizableCapacity(H)`;
11. **same-person no-double-count** — P committed backing + P private supplement cannot spend the same disposable grain twice;
12. **atomic failure** — if combined funding/preconditions fail, neither funding source partially commits;
13. **not-personal-support evidence** — supplement is not Gift/Help/formation/continuity/lineage evidence;
14. **no extra favour** — supplemented mediated marriage creates only the already-accepted groom->head favour;
15. **personal-action conflict** — H supplement and P personal transfer revalidate under existing central priority;
16. **succession control** — predecessor supplement does not transfer/rebind to successor;
17. **DEC-0010 last-act companion** — valid supplemented old-head action may commit before authority destruction while live private capacity still revalidates.

## 13. Verification-family changes required after Director funding-order resolution

At minimum revise/extend:

- `PROVISION_GROUNDING_FAMILY.md`;
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`;
- `RESOLUTION_REACTION_FAMILY.md`;
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`;
- `REFERENCE_SCORING_PROFILES.md` with deterministic laboratory offer/no-offer coverage;
- successor Slice-4 acceptance authority.

The reference profile is verification configuration only. It must not imply that Household concern is itself ownership consent; the action trace/terms must record P's explicit private authorization separately from role authority.

## 14. One genuine Director semantic choice remains

Current authority does **not** determine funding order between:

- ordinary valid commitment-backed allocation; and
- P's explicit transaction-specific private supplement.

This changes who pays and therefore is not engineering discretion.

Decision packet:

`proposals/SFL_V0_SLICE4_PRIVATE_SUPPLEMENT_FUNDING_ORDER_DECISION.md`

No other new Director-level choice is presently established by this reconciliation.

## 15. Unblock sequence

1. Project Director resolves the funding-order question.
2. Promote the complete private-supplement semantics into SPEC and canonical verification.
3. Create a successor Slice-4 acceptance candidate/version; do not modify frozen v1.
4. Run fresh independent whole-candidate pre-code review.
5. Freeze the successor acceptance authority only on PASS.
6. Reassess the inherited-verification adaptation plan against the repaired semantics.
7. Close the existing Director BLOCK only after those gates are complete.
8. Then issue the Slice-4 implementation packet / coding bārû commission.
