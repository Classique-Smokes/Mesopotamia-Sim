# TRES-0010 — Slice-1 CallFavor Action Applicability Reconciliation

**Status:** MECHANICAL DERIVATION / SUPPORTING RECORD  
**Date:** 2026-09-21  
**Semantic authority:** `SPEC-SFL-0001` after Director-approved TRES-0010 B2 promotion  
**Purpose:** Apply the accepted response-closed called-favour predicate to every current IMP-0001 action shape before the Slice-1 acceptance manifest is frozen.

## 1. Controlling predicate

A current v0 called-favour payload is valid only when:

1. the called actor's `FulfilCalledFavor` / `RefuseCalledFavor` choice is the **last new voluntary actor choice** required for the requested action to reach terminal commit/failure;
2. requested execution occurs inside that response scope and does not consume/grant a second called-actor personal initiative;
3. it does not open another `ResponseDecisionContext` or require a third actor's new voluntary choice;
4. it does not create/demand/transfer/cancel another favour;
5. it does not establish marriage/kinship;
6. it does not require household/role authority;
7. it still uses the requested action's ordinary world feasibility, central revalidation, and commit/failure semantics.

This document does not add semantic exceptions to that predicate.

## 2. Classification vocabulary

- **CALLABLE** — the action shape satisfies the predicate; current-state feasibility may still yield `Unable` and later revalidation may still yield `InvalidatedAtResolution`.
- **NON-CALLABLE** — the semantic action shape violates at least one controlling predicate clause; attempting to use it as a CallFavor payload is categorically rejected before the called actor's response.
- **RESPONSE-ONLY / NOT A PAYLOAD** — a response meaning or failure/result label rather than an ordinary requested action.
- **OUT OF SLICE 1** — not implemented by IMP-0001; no current payload classification is needed.
- **NOT A SEMANTIC ACTION** — an implementation helper/effect primitive must never be substituted for an accepted semantic action meaning.

## 3. Current Slice-1 action mapping

| Action shape | Status | Mechanical reason | If attempted as CallFavor payload |
|---|---|---|---|
| `Farm` | **CALLABLE** | Self-contained requested action. No new counterparty/third-party voluntary choice; creates no favour; establishes no excluded relation/authority. | If world-feasible, Fulfil/Refuse may be scored. Successful Farm commit consumes the favour and applies holder->fulfiller +10. `NeedsGrain` or another existing action-relevant inability yields ordinary `Unable(reason)`; later loss of a precondition yields ordinary `InvalidatedAtResolution(reason)`. |
| `RepayDebt(debt, amount)` | **CALLABLE** | Repayment is a unilateral ordinary action under accepted lower-level semantics; creditor acceptance is not a required response. It may affect a third party but requires no third-party voluntary choice. | Terms must already satisfy the positive-integer / amount<=remaining domain. Ordinary debt/reserve/material feasibility applies. Successful commit consumes the favour and retains ordinary repayment semantics/attitude effect. |
| `OfferGift` | **NON-CALLABLE** | Ordinary Gift is proposal/response based; recipient must make a new voluntary Accept/Decline choice. The outer CallFavor is not a substitute for the Gift response. | Reject payload before called-actor response; favour unchanged; no Gift/material/attitude effect. |
| `RequestGiftOrHelp` | **NON-CALLABLE** | Requires the requested helper/target to make a new voluntary response after the called actor's action. | Reject payload before called-actor response. |
| `OfferLoan` | **NON-CALLABLE** | Loan offer requires a new borrower Accept/Decline response. | Reject payload before called-actor response. |
| `RequestLoan` | **NON-CALLABLE** | Loan request requires a new lender Accept/Decline response. | Reject payload before called-actor response. |
| `OfferBenefitForFavor` | **NON-CALLABLE** | Requires a target response and successful meaning creates a new favour; both violate the predicate. Full pair capacity does not convert it into a callable action. | Reject payload before called-actor response; do not reach the explicit-bargain capacity/response path. |
| `RelationshipMediatedReciprocalHelp` | **NON-CALLABLE** | Ordinary meaning is knowingly accepted help and may create another favour. It therefore does not supply a stable response-closed, non-favour-manipulating payload shape. Pair-capacity suppression of a second favour does not turn the action meaning into a CallFavor exception. | Reject payload before called-actor response. |
| `CallFavor` | **NON-CALLABLE** | Would open another Fulfil/Refuse response and demand/use another favour; recursive favour action is explicitly excluded. | Reject payload before called-actor response. |
| reciprocal favour cancellation | **NON-CALLABLE** | Cancels another favour, explicitly excluded from called-favour payload effects even though no new counterparty response is required. | Reject payload before called-actor response. |
| direct mutual-strong-like `ProposeMarriage` | **NON-CALLABLE** | Establishes marriage, explicitly excluded; marriage proposal also preserves counterparty autonomy. | Reject payload before called-actor response. |
| Residence move proposal | **NON-CALLABLE** | Named counterpart acceptance is required, creating another voluntary response context. | Reject payload before called-actor response. |
| Residence invite proposal | **NON-CALLABLE** | Named counterpart acceptance is required, creating another voluntary response context. | Reject payload before called-actor response. |
| `FulfilCalledFavor`, `RefuseCalledFavor`, Accept/Decline meanings | **RESPONSE-ONLY / NOT A PAYLOAD** | These are response candidates of an already valid interaction, not ordinary requested-action meanings. | Must not be accepted as payload types. |
| `Declined`, `Unable`, `InvalidatedAtResolution` | **RESPONSE-ONLY / NOT A PAYLOAD** | These are result/failure classifications, not actions. | Must not be accepted as payload types. |
| internal `TransferGrain`, relation-write, transition/effect helper, or similar implementation primitive | **NOT A SEMANTIC ACTION** | Transfer meanings remain explicit semantic actions; implementation helpers cannot become a backdoor callable action. | Must not be exposed as CallFavor payloads. |
| `CommunicateClaim/Inform` | **OUT OF SLICE 1** | General communication/claim propagation is explicitly deferred by IMP-0001. | Do not implement or classify as a Slice-1 callable payload. Re-evaluate when communication enters an implementation slice. |
| household/participation/head/provision/mediated-marriage actions | **OUT OF SLICE 1** | Explicitly outside IMP-0001; many also require household/role authority or further responses. | Do not implement as Slice-1 payloads. |

## 4. Result

**Current Slice-1 callable payload set:**

1. `Farm`
2. `RepayDebt(debt, amount)`

No other currently commissioned Slice-1 semantic action shape satisfies the promoted response-closed predicate.

This is a mechanical consequence of the approved rule, not a new whitelist semantic. If a future action meaning satisfies the predicate, it may become callable without changing this v0 principle; if it does not, it remains non-callable unless the semantic rule itself is later amended.

## 5. Edge-case checks

### 5.1 Repayment to a third-party creditor

Allowed.

The predicate forbids a third actor's **new voluntary choice**, not all third-party effects. Canonical debt repayment does not require creditor acceptance. Central resolution may therefore transfer repayment to a creditor other than the favour holder if the requested RepayDebt action is otherwise valid/feasible.

### 5.2 Offer/Request action directed at the favour holder

Still non-callable.

The holder's earlier CallFavor initiative is not silently reinterpreted as the separate Accept response required by ordinary Gift/Loan/Residence semantics. Doing so would bypass the accepted action meaning and response boundary.

### 5.3 Relationship-mediated help at full favour capacity

Still non-callable in Slice 1.

Pair-capacity can suppress additional favour creation after independently meaningful relationship-mediated help, but that does not rewrite the action into a response-closed called-favour payload or create a state-dependent exception to the approved payload predicate.

### 5.4 Called actor also has a personal initiative

Permitted subject to ordinary compatibility/revalidation.

A called-favour requested action is response-scoped, so a successful callable payload may produce an additional substantive effect in the same cycle as the actor's ordinary personal initiative. This is an approved consequence of the response model, not a second personal initiative.

### 5.5 Two RepayDebt/Farm effects involving the same actor

No new generic per-action cap is invented here.

If a personal action and a called-favour action are both otherwise valid, central revalidation decides ordinary compatibility/capacity. Any new semantic conflict class beyond the already accepted rules requires separate authority rather than being inferred from this applicability mapping.

## 6. Acceptance-manifest implications

The Slice-1 acceptance manifest should contain stable REQUIRED rows for:

1. `Farm` accepted as a callable payload when feasible;
2. `RepayDebt` accepted as a callable payload when terms and world state are valid;
3. at least one callable payload coexisting with an already selected personal initiative, proving response-scoped execution;
4. a valid callable payload that is `Unable`, proving favour retention and no +/- called-favour attitude effect;
5. a valid callable payload selected for fulfilment then `InvalidatedAtResolution`, proving favour retention and no +/- called-favour attitude effect;
6. every NON-CALLABLE current Slice-1 action shape rejected before called-actor response;
7. response-only/result/internal-helper shapes rejected as payload types;
8. successful fulfilment consumes the favour only on requested-action commit;
9. no nested response context is created by any accepted callable payload.

A compact table-driven test is acceptable for the non-callable action-shape rows; no new action framework is required.

## 7. Audit conclusion

**APPLICABILITY DERIVATION: CLOSED**

Every current IMP-0001 action shape has a unique classification under the promoted response-closed predicate. No new semantic decision is required before constructing the Slice-1 acceptance manifest.
