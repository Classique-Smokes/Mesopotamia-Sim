# DEC-0011 — Transaction-Specific Office-Holder Private Resource Supplementation

**Status:** ACCEPTED  
**Authority:** Architectural / social-semantic  
**Opened:** 2026-09-24  
**Resolved:** 2026-09-24  
**Accepted by:** Project Director  
**Scope:** bounded SFL v0 Slice 4 Household material actions

## Problem

Existing Slice-4 semantics correctly separate:

- Household/head authority;
- private ownership of personal grain;
- persistent HouseholdProvisionCommitment backing;
- derived Household mobilizable capacity;
- actual collective expenditure.

But the accepted model lacked a valid history in which the current office-holder voluntarily places some privately owned disposable grain behind one authorized Household material action without first creating a persistent provision commitment.

A first reconciliation incorrectly reduced the remaining question to a global source-order choice:

- commitment backing first; or
- holder private resources first.

The Project Director clarified that **both social behaviors are valid** and that no global source-priority rule should select between them.

## Decision

A permitted Household material action with total material cost `C` may carry an **optional transaction-specific private contribution term** personally authorized by the current valid head P.

Let the explicit private contribution be `X`.

- absence of the term means no private supplement;
- when present, `X` is an exact strictly positive integer;
- `X <= C`;
- P must be the current valid holder exercising the relevant Household authority and separately the private owner authorizing the contribution;
- P's live disposable personal capacity must be at least `X` at precommit;
- the remaining institutional funding requirement is exactly `R = C - X`;
- `R` is funded through valid persistent Household provision commitments under the existing fixed-rank allocation semantics.

This is a transaction funding plan, not a priority contest between funding sources.

## Dual authority

The Household action requires two distinct authority sources when `X` is present:

1. role authority makes the institutional act valid/in scope;
2. P's personal-property authority makes exactly `X` of P's disposable grain available to that transaction.

Office occupancy alone does not expose private grain.

Personal ownership alone does not authorize the Household action.

The fact that one person carries both capacities does not collapse them.

## No extra action / response / initiative

The private term is part of the existing Household action's explicit funding plan.

It does not create:

- another personal voluntary initiative;
- a self-directed provision request;
- a ResponseDecisionContext from P to P;
- a generic donation action.

P may authorize the private term even if P's ordinary personal initiative for that cycle was used elsewhere.

The action trace must make P's personal consent to `X` explicit and distinct from role authority.

Exact internal representation remains implementation-local.

## Standing capacity remains commitment-derived

`MobilizableCapacity(H)` remains derived only from valid persistent HouseholdProvisionCommitment relations.

P's wealth, possible willingness to contribute, or one transaction-specific `X` does not become reusable Household capacity.

The private term creates no persistent provision commitment and no Household-owned balance.

## Same-person commitment + supplement

P may simultaneously:

- have a persistent HouseholdProvisionCommitment(P -> H); and
- authorize private contribution `X` for the same transaction.

Both provenance channels draw from the same personal grain stock.

For commitment allocation of the remaining cost `R`, P's effective commitment-side exposed capacity for that transaction is reduced by the exact private amount `X`.

Conceptually:

`effectiveCommittedCapacity(P) = max(0, ordinaryExposedCapacity(P) - X)`

when P has a valid commitment.

Other contributors retain their ordinary live exposed capacities.

The existing fixed-rank allocation is then applied to `R` using these effective capacities.

This is not a global “private-first” social priority. `X` is already a fixed transaction term; the commitment allocator funds only the residual requirement and may not reuse the same grain.

## Exact-term semantics

The funding plan is not silently renegotiated at commit.

If, after deliberation but before commit:

- P's live disposable capacity falls below `X`; or
- valid commitment backing cannot fund `R`; or
- another action-relevant precondition fails,

the Household action fails ordinary precommit revalidation/atomic commit rules.

The engine does not:

- shrink `X`;
- increase `X`;
- substitute a successor's grain;
- ask P again in the same cycle;
- automatically shift the agreed private/commitment split.

A later attempt may choose a different funding plan through ordinary future deliberation.

## Personal safety

This decision does not reopen protected-reserve / NeedsGrain semantics.

- private supplement capacity uses the same currently disposable personal boundary;
- protected reserve 2 remains intact;
- NeedsGrain exposes no private supplement capacity;
- deliberate below-reserve sacrifice is a separate future question.

## Material effect and provenance

A successful supplemented Household action commits atomically.

History must distinguish:

- total cost C;
- P's exact private term X;
- actual private debit X;
- residual requirement R;
- each commitment-backed contributor and debit;
- any separate commitment-backed debit from P;
- H/head/role authority;
- P's private-owner authorization;
- recipient/effect;
- rule/configuration/time/causal predecessors.

The material ledger may aggregate P's final personal grain delta, but funding provenance must preserve the separate private and commitment-backed legs.

No Household treasury is introduced.

## Not an ordinary person-person transfer

The private supplement is funding provenance for the Household effect, not a second Gift, Help, Loan, or favour-bearing personal act.

The supplement itself therefore:

- creates no separate ordinary transfer attitude effect;
- creates no independent favour;
- cannot qualify as person-person support evidence for formation, participation, continuity, or lineage;
- cannot make Household-originated support self-confirming organizational evidence.

For mediated marriage, the already-accepted groom -> mediating-head favour remains the only route-specific favour created by that transaction.

## Dual-mode / central resolution

The supplemented action remains one Household action.

Existing material priority remains applicable:

eligible NeedsGrain Household support > other valid Household provision expenditure > ordinary voluntary personal transfer.

The private term does not reserve P's grain at deliberation. Live grain is revalidated at commit.

Thus a competing same-cycle personal material action remains subject to the existing central priority/revalidation semantics.

## Succession and DEC-0010

A transaction-specific private term belongs to the authorizing person, not to the office.

- it does not transfer to a successor;
- it never rebinds from old head A to new head B;
- B must separately authorize B's own private contribution for a later transaction.

Under DEC-0010, an otherwise-valid accepted old-head supplemented Household action may perform its valid last act before the paired authority-destroying transition, while all live private-capacity and other non-authority preconditions still revalidate.

## Examples

For total cost `C=3`:

- no private term -> commitments must fund 3;
- `X=1` -> P privately funds exactly 1; commitments fund exactly 2;
- `X=2` -> P privately funds exactly 2; commitments fund exactly 1;
- `X=3` -> P privately funds the whole material cost; commitment funding requirement is 0.

These remain distinct histories even when commitments could have funded more.

## Explicit nonclaims

This decision does not introduce:

- general institutional finance;
- arbitrary participant supplementation;
- other office types;
- reimbursement;
- prestige/political leverage;
- future expectation or precedent;
- coercive office claims over private property;
- sacrifice below protected reserve;
- generic split-tender mechanics outside the accepted Household material-use scope.

## Director disposition

The Project Director explicitly rejected a global source-priority rule and clarified that the holder chooses an explicit transaction-specific private amount `X`, with the remaining `C-X` funded through ordinary Household provision backing.

This decision supersedes the unresolved A/B framing in:

`proposals/SFL_V0_SLICE4_PRIVATE_SUPPLEMENT_FUNDING_ORDER_DECISION.md`.
