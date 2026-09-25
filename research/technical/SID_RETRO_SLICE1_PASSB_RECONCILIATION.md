# Slice 1 Retrospective SID — Pass-B Master Architect Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / DIRECTOR SEMANTIC DECISION REQUIRED  
**Date:** 2026-09-25  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Historical authority boundary:** frozen Slice-1 authority at `sfl-v0-slice1-acceptance-v1`  
**Pass-B return:** `research/technical/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`  
**Pass-B return blob:** `400af240b8f4f5669531b03f4a82f2055d40070d`

## 1. Return integrity

The Pass-B return branch is exactly one commit ahead of immutable dispatch `93fd589a911a9c862702389dd0f817cca5de8621`, zero behind, with the exact dispatch commit as merge base.

The only added file is the required Pass-B report.

The reviewer found no missing frontier class and added no new frontier item.

## 2. Authority-bearing reconciliation

Pass B confirms that the frontier divides into three materially different classes.

### A. Already closed by historical Slice-1 authority

No Director decision is required for:

- Residence mover = named counterpart / inviter = invitee: prohibited by the explicit phrase **another person**;
- direct-marriage groom = bride: structurally impossible under the bounded male-groom/female-bride roles;
- parent/child and sibling endpoint collapse: structurally incompatible with the accepted relation meanings;
- reciprocal-favour cancellation with A=B: cannot satisfy the two-opposite-claim precondition under one-per-ordered-pair cardinality.

### B. Already positively supported aliases that must remain legal

No Director decision is required for:

- outer CallFavor holder = inner RepayDebt creditor where the underlying favour and debt are ordinary two-party claims;
- the called actor = the inner debtor for that repayment payload;
- one person using personal initiative while also answering an incoming proposal in the same cycle;
- one target receiving/responding to multiple proposal contexts from the common snapshot;
- one material source participating in multiple accepted attempts that later conflict at central resolution;
- same-person role reuse across separate claims/actions where each individual claim/action remains semantically valid;
- multiple distinct direct causes converging on the same directed attitude edge.

These are not exceptions to be removed. Any repair must preserve them.

### C. Consequentially unresolved

Historical Slice-1 authority does not explicitly and unambiguously settle:

1. **within-action self-counterparty identity** for the current lower-level interpersonal action meanings, including Gift/Help/Loan/explicit benefit-for-favour/relationship-mediated reciprocal help and CallFavor;
2. **diagonal typed social state**, especially `Attitude(P,P)`, `Debt(creditor=P, debtor=P)`, and `Favour(holder=P, debtor=P)`.

ADR-0002's statement that interpersonal actions are attempts/proposals whose effects remain subject to **other actors** is meaningful evidence toward distinct-party interpretation. The accepted SPEC also relies on proposer/target, giver/recipient, lender/borrower, holder/called-actor and independent response roles.

However, unlike Residence, the accepted Slice-1 text does not state a general `PersonId A != PersonId B` invariant for these meanings. The frozen acceptance manifest likewise does not contain a direct diagonal/self-counterparty boundary row.

Current implementation rejection is not semantic authority.

## 3. Why this is consequential

Silently choosing either side changes:

- whether a response context can be self-addressed;
- personal-initiative versus response accounting;
- whether transfer endpoints may collapse into one resource owner;
- debt/favour relation identity and cardinality;
- whether fixed social consequences may target a self-directed attitude edge;
- direct-participant knowledge cardinality;
- causal history/provenance of the interaction;
- the validity domain of persistent Slice-1 state.

This is therefore a real inherited semantic/acceptance gap, not merely a missing test name.

## 4. Escalation

The exact Director packet is:

`proposals/SFL_V0_SLICE1_RETRO_SID_OPEN_SEMANTIC_DECISIONS.md`

The Master Architect does not choose these social-semantic rules by implementation convenience.

## 5. Slice-5 consequence

The independent Slice-5 R2 review returned:

**PASS — MAY FREEZE UNCHANGED**

at exact candidate1 identity.

That PASS is preserved, but the candidate's own retro-SID gate remains open.

Do **not** freeze Slice-5 candidate1 while the Director decision is unresolved.

If the Director approves a new explicit Slice-1 identity rule, the resulting current inherited authority must be promoted without rewriting frozen Slice-1 v1 historical evidence. A successor Slice-1 acceptance authority and conformance reconciliation are then required.

Because Slice-5 candidate1 currently inherits the old frozen Slice-1 REQUIRED set, such a successor authority is a material inherited-authority change. Candidate1 must then remain immutable historical review evidence and a corrected Slice-5 candidate must receive a fresh whole-candidate review.

## 6. Current gate state

- Slice-5 candidate1 R2: **PASS — MAY FREEZE UNCHANGED**
- retro-SID Pass-B: **COMPLETE / PRESERVED**
- consequential retro-SID semantic gap: **OPEN**
- Director decision required: **YES**
- Slice-5 freeze: **BLOCKED**
- Slice-5 coding: **NOT AUTHORIZED**
