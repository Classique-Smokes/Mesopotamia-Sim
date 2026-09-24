# Slice 4 — Transaction-Specific Private Supplement Funding Order

**Status:** DIRECTOR DECISION REQUIRED / PROPOSAL ONLY  
**Date:** 2026-09-24  
**Source reconciliation:** `research/technical/SFL_V0_SLICE4_PRIVATE_RESOURCE_SUPPLEMENTATION_RECONCILIATION.md`  
**Authority:** none until explicit Project Director approval.

## Question

When a valid Household material action has both:

- ordinary valid commitment-backed funding; and
- an explicit transaction-specific private supplement authorized by current head P,

which source is consumed first?

The Director clarification establishes the supplementation capability itself. This packet isolates only the remaining ordering choice because it changes **who actually pays**.

## Option A — committed backing first, private supplement only for shortfall

1. Revalidate all ordinary provision commitments/capacities.
2. Allocate ordinary commitment-backed funding under the existing fixed-rank contributor rule.
3. Compute any remaining shortfall.
4. Debit P's transaction-specific private supplement only for that shortfall, bounded by:
   - P's explicit authorization cap;
   - P's residual live disposable capacity after any ordinary committed debit from P;
   - the remaining transaction cost.
5. If total combined funding remains insufficient, the whole Household action fails atomically.

### Meaning

The private term is literally a **supplement**.

If existing committed backing can fully fund the transaction, P's private authorization consumes 0 grain.

If P is also a committed contributor, P may first pay through the existing commitment allocation and may additionally pay transactionally only from residual disposable grain.

### Effects

- least disruption to current §8.1 allocation;
- existing contributor ranking remains the primary funding route;
- no new ranking rule is needed;
- “P chooses to bear part of the cost” is limited to cases where ordinary backing leaves a shortfall.

## Option B — explicit holder contribution first, committed backing funds the remainder

1. Revalidate P's explicit private authorization and live disposable capacity.
2. Debit an amount from P up to the explicit transaction-specific authorization/cost boundary.
3. Recompute ordinary valid commitment-backed capacities after that private debit.
4. Allocate remaining transaction cost under the existing fixed-rank contributor rule.
5. If combined funding remains insufficient, the whole Household action fails atomically.

### Meaning

P may voluntarily choose to bear some cost even if existing institutional backing could have fully funded the action.

The private contribution is therefore not merely a shortfall backstop; it is an explicit cost-bearing choice.

### Effects

- changes who pays even when ordinary backing is sufficient;
- if P also has a standing provision commitment, P's supplement may reduce P's later exposed commitment capacity/ranking for the same transaction;
- accepted contributor allocation remains deterministic but occurs after the explicit private contribution.

## Both options preserve

Whichever option is accepted:

- office authority does not expose private grain;
- P's explicit personal consent is required;
- no self-response / self-negotiation context;
- no extra personal initiative;
- no persistent provision commitment is created;
- standing `MobilizableCapacity(H)` remains commitment-derived;
- reserve/NeedsGrain safety remains;
- no double debit;
- no treasury;
- supplement has no standalone Gift/Help/favour/attitude/formation/continuity/lineage effect;
- uncommitted supplement does not survive/rebind across succession;
- ordinary precommit revalidation/atomicity still applies.

## Master Architect assessment

Both options satisfy the Director's core supplementation requirement.

**Option A** is narrower and preserves the current institutional contributor allocation as primary.

**Option B** preserves the broader possibility in the Director note that a holder may choose personally to bear part of the cost even when ordinary backing would suffice.

Current accepted authority does not uniquely choose between them.

A Project Director decision is required before semantic promotion and successor Slice-4 acceptance drafting.
