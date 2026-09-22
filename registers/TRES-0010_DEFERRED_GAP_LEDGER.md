# TRES-0010 Deferred Gap Ledger

**Status:** ACTIVE / DURABLE DEFERRED TRACKING  
**Created:** 2026-09-21  
**Source:** TRES-0010 Wave A, Wave B adjudication, B2 synthesis, and final pre-code reconciliation  
**Authority:** Tracking only. This ledger does not create simulation semantics.

## Purpose

Preserve confirmed later-slice semantic gaps and verification-hardening items that TRES-0010 intentionally kept off the Slice-1 critical path.

A deferred item must be resolved before the trigger named below. Deferral is not permission for an implementation agent to invent the missing rule.

## Semantic / model gaps

| ID | Gap | Current disposition | Trigger for resolution | Slice-1 impact |
|---|---|---|---|---|
| LATER-01 | CandidateOrganization same-candidate equivalence / convergence before formation | DEFERRED | Before household-formation implementation can create/reconcile multiple candidate labels/evidence paths | None; CandidateOrganization/household formation absent from IMP-0001 |
| LATER-02 | Actor departure transition semantics if departure becomes executable | DEFERRED | Before any implementation slice enables actor departure as fixture/generated/runtime input | IMP-0001 explicitly excludes executable departure; fixed Slice-1 population |
| LATER-03 | Rejoin / re-exit lineage-source selection when one founder has repeated predecessor-participation history | DEFERRED | Before lineage classification accepts such histories | None; lineage absent from IMP-0001 |
| LATER-04 | Authority-destroying transition versus already accepted authority-dependent action in same cycle | DEFERRED | Before head/household authority transitions and authority-dependent actions coexist executably | None; household/head actions absent from IMP-0001 |
| LATER-05 | Mediated-marriage nested response / authority topology beyond the current accepted route wording | DEFERRED | Before household-mediated marriage becomes executable | Direct mutual-strong-like route only in IMP-0001 |

## Verification-hardening items

| ID | Item | Current disposition | Trigger for resolution | Slice-1 impact |
|---|---|---|---|---|
| VH-01 | Exit-side ContinuationWarrant verification should explicitly prove the semantic requirement from both entry/exit directions | DEFERRED HARDENING | Before continuity becomes implementation-completion evidence | None |
| VH-02 | Generated-history validity must not be circularly filtered by the production gate under test | DEFERRED HARDENING | If generated histories become required completion evidence | Generated histories are UNEXERCISED for Slice 1 |
| VH-03 | “Verified checkpoint” reuse should carry verifiable producer/pass/fixture-audit provenance | DEFERRED HARDENING | Before downstream cards rely on produced checkpoints as accepted fixtures | Checkpoint/save-load deferred from Slice 1 |
| VH-04 | Checkpoint omission mutants need a continuation suffix that causally exercises the omitted state | DEFERRED HARDENING | Before checkpoint omission mutation becomes completion evidence | Checkpoint/save-load deferred from Slice 1 |
| VH-05 | Event-observer eligibility and recognition updates after decisive dissolution/head-vacancy evidence need explicit verification | DEFERRED HARDENING | Before recognition + lifecycle/head vacancy are implemented together | Household recognition/head absent from Slice 1 |
| VH-06 | Household/reaction-chain derived-state refresh timing needs targeted verification | DEFERRED HARDENING | Before later household reactions depend on derived/cache refresh within closure | Slice-1 cache authority still covered by frozen manifest structural/rebuild checks |

## Closed / non-deferred TRES-0010 concerns

The following were resolved before Slice 1 and must not be reopened as “deferred” implementation discretion:

- D1 same-cycle direct attitude composition;
- D2 same-person Residence conflict;
- D3 response-closed called-favour payload semantics;
- D4 grain term domain and invalid-term classification;
- D5 explicit Benefit-for-Favour atomicity;
- current Slice-1 CallFavor applicability;
- Slice-1 verification applicability/completeness;
- independent-enough frozen acceptance authority;
- required input authority taxonomy;
- implementation-local C# safeguards.

## Maintenance rule

When a trigger becomes near-term:

1. retrieve the accepted authority current at that time;
2. commission/perform only the bounded work needed to close that item;
3. promote any consequential semantic decision through normal authority;
4. update or retire the ledger entry;
5. do not infer the missing rule from current implementation convenience.
