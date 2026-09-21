# TRES-0010 — Manifest Repair Review Reconciliation

**Status:** MASTER ARCHITECT SYNTHESIS / NON-AUTHORITATIVE REPAIR CONTROL  
**Date:** 2026-09-21  
**Inputs:** original manifest pre-code BLOCK + MRR-A/B/C independent returns  
**Implementation gate:** IMP-0001 remains blocked until corrected manifest passes fresh pre-code review.

## 1. Review integrity

All three Manifest Repair Review branches were checked against frozen baseline `8a809a05276571fb15845f012dc7dae1c71380d8`.

Each branch added only its assigned return file. No reviewer modified canonical project state.

All three reviewers recorded:
- no sibling-return reading;
- no prior BLOCK-report reading;
- no external research;
- no canonical edits.

## 2. Reconciled findings

### R1 — provision-reconsideration boundary missing

**Confirmed.**

The cross-cutting verification contract contains a materially distinct timing matrix:
- before three full cycles;
- exactly three full cycles without relevant context change;
- exactly three full cycles plus relevant context change.

The candidate manifest has no explicit status for this boundary. It must receive one explicit **DEFERRED** row because household provision/head reconsideration is outside IMP-0001.

### R2 — reserve wording merges distinct mechanics

**Confirmed independently by original reviewer, MRR-A, and MRR-B.**

Accepted semantics contain:
- a lower-level **RepayDebt-specific** rule: repayment must leave debtor with at least 2 grain;
- a later household-provision rule: exposed contributor capacity is `max(0, grain-2)`, with NeedsGrain contributor capacity 0.

There is no generic two-grain reserve for ordinary Gift/Help/Loan/BFF/RMRH transfers.

Required repair:
- clarify the cross-cutting verification boundary wording itself;
- narrow manifest `S1-BND-RESERVE` and `S1-MUT-13A` to RepayDebt;
- keep household provision reserve/NeedsGrain contributor faults explicitly DEFERRED.

No SPEC change.

### R3 — deferred lineage boundary label incomplete

**Confirmed by independent MRR-A.**

The candidate `S1-BND-LINEAGE` names freshness/ambiguity but omits the separate canonical axis:
- one predecessor survives versus both predecessors Dissolved.

Status remains DEFERRED; only the manifest boundary description needs to become exhaustive.

### R4 — D4 grain validation must be ingress-explicit

**Confirmed by original reviewer and MRR-C.**

The generic `S1-BND-GRAIN-ACTION` row permits omission: one easy action route can pass while another malformed grain term reaches response/effects.

Uniquely source-closed current Slice-1 ingresses requiring explicit D4 evidence:

1. `OfferGift` grain transfer term;
2. `RequestGiftOrHelp` grain transfer term;
3. `OfferLoan` grain amount;
4. `RequestLoan` grain amount;
5. direct `RepayDebt(amount)`;
6. `ProposeMarriage(..., proposedDowry)` term on the direct-bypass proposal shape;
7. inner `CallFavor(RepayDebt(..., amount))`.

Offer/request variants and direct/nested repayment must remain separately visible completion IDs even if one parameterized executable test covers them.

### R5 — BFF / RMRH parameter-shape ambiguity

**MRR-C correctly identifies that accepted semantic authority does not require a particular raw scalar action/API signature.**

However, this does **not** require a new Director social-semantic decision.

Accepted project state already establishes:
- Grain is the only v0 material resource;
- BFF has a `specified material benefit`;
- RMRH has an independently meaningful accepted material help/benefit;
- canonical VS-SFL-091 requires comparable **1-grain transfer instantiations** of Gift, Loan, BFF, and RMRH;
- every grain-denominated action parameter/term obeys D4;
- implementation representation/schema remains local unless semantically consequential.

Therefore the acceptance rule should be **schema-neutral**:

> For the required Slice-1 grain-transfer instantiation of BFF or RMRH, every grain quantity embedded in, referenced by, or required to construct the proposal's material-benefit term must satisfy D4 before target response. The manifest does not require that `OfferBenefitForFavor` or RMRH expose a raw scalar `amount` parameter. A validated typed material-benefit/grain-transfer object is acceptable if the public semantic ingress cannot admit/coerce malformed grain quantity.

This tests the accepted grain semantics without promoting a C# API/data-schema choice into social semantics.

Add explicit D4 completion IDs for the BFF and RMRH **grain-transfer instantiations**, with structural-or-executable evidence permitted depending on representation.

## 3. Proposed-dowry treatment

MRR-C's source chain is accepted.

The common `ProposeMarriage` action shape names a proposed dowry before route selection. The dowry is a grain-backed term in v0. The direct bypass removes the dowry **effect**, not the proposal term or global term-validity rule.

Therefore a malformed proposed dowry is rejected before bride response even when the strong-like bypass would otherwise apply.

This does not implement household-mediated marriage or provision; it tests only proposal-term validity.

## 4. CallFavor nested repayment

MRR-C is accepted.

`CallFavor(RepayDebt(...))` is a distinct semantic ingress because a nested/wrapped proposal constructor could admit malformed repayment terms even if direct RepayDebt is correct.

Invalid inner amount:
- rejects the CallFavor term before Fulfil/Refuse response;
- leaves favour outstanding;
- creates no repayment/material/attitude effect;
- is not Declined/Unable/Invalidated.

Positive term-valid inner repayment proceeds to ordinary CallFavor and RepayDebt feasibility/revalidation.

## 5. Exact correction set

Correct canonical verification/manifest only:

1. Cross-cutting contract:
   - split generic protected-reserve boundary wording into RepayDebt debtor reserve and household-provision contributor reserve;
   - freeze D4 ingress categories/schema-neutral BFF/RMRH grain-transfer instantiations.
2. Manifest:
   - add DEFERRED provision-reconsideration timing row;
   - expand deferred lineage boundary label with predecessor lifecycle state;
   - narrow reserve row and mutant wording;
   - add stable D4 IDs per ingress:
     - Gift offer
     - Gift/help request
     - Loan offer
     - Loan request
     - Repay direct
     - BFF grain-transfer instantiation
     - RMRH grain-transfer instantiation
     - direct-marriage proposed dowry
     - CallFavor nested RepayDebt
   - retain repayment-specific remaining-amount companion boundary and apply it to direct+nested repayment evidence;
   - update D4 companion bundle.
3. Do not edit SPEC, ADRs, assumptions, or social semantics.
4. Do not yet harden IMP-0001.
5. Freeze a new corrected manifest-review baseline and rerun the independent pre-code manifest review.

## 6. Non-promotions

This reconciliation does not:
- create a generic transfer reserve;
- define BFF/RMRH raw parameter signatures;
- make all benefits permanently grain-only;
- implement household-mediated marriage/provision;
- add a new failure outcome;
- expand CallFavor payloads;
- create a generic validation framework.

## 7. Reconciliation conclusion

**REPAIR SET CLOSED.**

The first BLOCK plus MRR-A/B/C provide sufficient independent evidence for a bounded verification/manifest correction. No further research wave or Director semantic decision is required before corrected-manifest review.
