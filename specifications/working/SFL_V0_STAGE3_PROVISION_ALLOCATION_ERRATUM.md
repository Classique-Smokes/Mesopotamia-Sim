# SFL v0 — Provision Allocation Erratum

**Status:** RESOLVED / HISTORICAL WORKING RECORD  
**Date:** 2026-09-21  
**Authority:** Working semantic erratum only.

## Gap

`SPEC-SFL-0001` says that for one collective expenditure:

> contributors are debited largest available surplus first; stable semantic ID breaks otherwise unresolved ties.

This does not uniquely determine the debit trace when more than one contributor is required.

Example capacities A=5, B=3, spend=6:

### Interpretation A — fixed rank / exhaust in order

- rank contributors by surplus at expenditure start;
- A pays 5;
- B pays 1.

Debit vector: A=5, B=1.

### Interpretation B — dynamic largest-surplus

After every unit debit, recompute who currently has the largest available surplus.

The debit vector can differ materially and stable-ID ties may be encountered mid-spend.

## Why this is semantic

Both personal end-state distribution and semantic history/provenance differ. Stage-3 verification therefore cannot treat this as an ordinary implementation choice.

## Recommendation

Use **fixed-rank / exhaust-in-order** for v0:

1. at precommit revalidation, compute each valid contributor's exposed capacity;
2. sort contributors by exposed capacity descending;
3. stable semantic ID orders exact ties;
4. debit each contributor up to their available capacity in that fixed order until the expenditure is funded;
5. if the total validated capacity is insufficient, the expenditure cannot commit;
6. do not rerank while executing the same expenditure.

### Rationale

- simplest inspectable deterministic rule;
- matches the ordinary reading of "largest surplus first";
- makes one expenditure an atomic allocation decision rather than a sequence of artificial one-grain mini-decisions;
- stable-ID fallback appears only where the initial social/material state is actually symmetric;
- independent oracle is straightforward.

## Verification after approval

`VS-SFL-046` should pin exact debit vectors, reserve preservation, conservation, and ID-permutation sensitivity.


## Resolution

Approved by the Project Director on 2026-09-21.

Promoted rule:

- compute valid exposed capacities at precommit;
- rank once by exposed capacity descending;
- stable semantic person ID orders exact ties;
- exhaust contributors in that fixed order until funded;
- do not rerank within the expenditure;
- insufficient total validated capacity prevents commit.

Canonical authority: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §8.1.
Canonical verification: `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md` VS-SFL-046.
