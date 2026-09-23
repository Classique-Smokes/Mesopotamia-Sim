# IMP-0003 Candidate-v2 — Independent Conformance BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / REPAIR-v3 REQUIRED  
**Date:** 2026-09-23  
**Failed candidate ref:** `imp-0003-slice3-conformance-candidate-v2`  
**Exact failed candidate SHA:** `69ae753da2e05450766a9042ac6958fa7aa0b3e7`  
**Independent review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`  
**Verdict:** **BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**  
**Recommendation:** **DO NOT PROMOTE**

## 1. Bottom line

Candidate-v2 successfully repaired all three candidate-v1 defects:

- participation-entry warrant checker adequacy;
- rule/configuration provenance separation;
- continuation-recognition broadcast overreach.

Fresh whole-candidate review then found two additional bounded defects:

1. incomplete independent verification for formation, exit-continuation, and lineage warrant families;
2. false technical-fallback labeling for compatible ordinary loans when an unrelated Household exists.

Neither finding requires a new Director-level semantic or architectural decision.

Candidate-v2 remains immutable historical evidence. Repair belongs on a successor branch and must return through a new exact candidate + fresh independent conformance.

## 2. B1 — remaining warrant-oracle coverage gaps

**Accepted.**

The strengthened participation-entry oracle is materially better and independently passed the reviewer’s P17/P18/P19-style attacks.

However, the broader `HouseholdOracle` still does not fully reconstruct several other warrant claims.

Fresh reviewer corruptions survived for:

### FormationWarrant

- empty/missing recorded supporting ties;
- duplicated founder-1 Recognition substituted for all founders;
- nonexistent Candidate ID;
- invented `EarliestEvidence`;
- nonexistent formation stamp event;
- warrant support fact whose endpoints/kind disagree with the real cited committed event.

### Exit-side ContinuationWarrant

- empty Recognition evidence;
- nonexistent stamp event;
- invented RulesVersion;
- Recognized bridge record with empty underlying evidence.

### LineageWarrant

- successor formation event substituted as “fresh support”;
- nonexistent lineage stamp event;
- invented RulesVersion.

These corruptions alter only detached public snapshots and then call the independent checker. They are not production-validation failures.

### Required repair

Complete independent reconstruction for the three affected warrant families without using production classifiers/validators as expected answers.

For **FormationWarrant**, at minimum verify:

- stamp event exists and is the actual formation event;
- candidate reference exists and matches the formation episode;
- recorded founders, dwelling and supporting ties correspond to actual accepted state/history;
- every recorded tie reference is real and actually connects the cited founder pair;
- every support fact matches the cited committed event identity, kind, endpoints and semantic order;
- each founder Recognition basis belongs to that founder, the same candidate, and valid underlying evidence;
- `EarliestEvidence` is the actual earliest retained sustaining evidence used by the warrant rather than merely “some earlier time”;
- founding associations are correctly bound to the FormationWarrant;
- rule/configuration provenance is truthful.

For **ContinuationWarrant**, at minimum verify:

- stamp event exists and is the correct Household continuation event;
- `Previous` references the correct preceding Formation/Continuation warrant;
- `Transition` references the actual participation entry/exit transition;
- Prior/Successor association sets are reconstructed from the transition history;
- every bridge is genuinely in prior ∩ successor and its Recognition basis is present and valid;
- Recognition cannot be empty/vacuously true;
- rule/configuration provenance is truthful;
- causal predecessor event references are real.

For **LineageWarrant**, at minimum verify:

- stamp event exists and is the actual lineage event;
- successor/forming warrant identity is correct;
- predecessor/source mappings bind actual ParticipationEndWarrants;
- every fresh-evidence reference is a real qualifying ordinary person-person support event;
- division/consolidation freshness timing and cross-predecessor requirements are reconstructed;
- successor formation itself or another nonqualifying event cannot satisfy fresh evidence;
- rule/configuration provenance is truthful;
- direct predecessor set/kind remains consistent with the controlled classifier without calling the production classifier.

Add detached corruption controls covering the reviewer’s exact surviving cases.

## 3. B2 — false fallback on compatible ordinary loans

**Accepted.**

Candidate-v2 routes all accepted components through the Household-aware counterfactual resolver whenever any Household exists.

For a disconnected Household plus two compatible ordinary loans among unrelated actors, the actual semantic results commute, but the resolver reports `TechnicalFallback=true` for both loans.

The reviewer isolated the cause:

- Household-aware projection compares state that still contains allocation-dependent identities;
- two semantically equivalent execution orders allocate different debt/event/provenance IDs;
- those raw identity differences are treated as consequential differences even though normalized social/material outcome is the same.

This violates the accepted fallback quarantine contract.

### Required repair

Preserve genuine fallback detection while normalizing allocation identities that are nonsemantic in detached counterfactual comparison.

A valid repair may:

- normalize newly allocated relation/event/evidence identities through causal proposal origins; or
- bypass the Household resolver for components structurally proven independent of Household effects.

Do not simply suppress fallback whenever final material balances match.

The projection still has to detect real consequential differences in:

- residence/admission races;
- captured communication invalidation;
- limited capacity conflicts;
- favour/debt/other action-relevant state;
- Household participation/lifecycle/continuity;
- any evidence/provenance difference that is semantically meaningful.

### Required regression

Create a paired case with:

- unrelated Household on one disconnected component;
- two independently feasible compatible ordinary loans in another component;
- both proposal-ID assignments / relevant input permutations.

Expected:

- both loans commit;
- normalized semantic state is equal;
- no technical fallback flags solely because Household state exists.

Retain positive fallback controls for genuinely noncommuting cases.

## 4. What candidate-v2 independently cleared

The fresh candidate-v2 review specifically confirmed:

- all three candidate-v1 repair targets now behave correctly;
- participation-entry oracle rejects the original corruptions;
- arbitrary scenario labels no longer falsify S2/S3 rule provenance;
- remote sustaining participants do not receive continuation evidence merely by status;
- formation production behavior remains downstream of founder Recognition;
- no primitive Household membership authority;
- participation gates and revalidation;
- continuity, founder turnover, bridge handoff, dissolution/no resurrection;
- Household Recognition staleness/communication/Contested;
- provision backing/capacity/no treasury/no spending;
- S1-084 remains unfired;
- later-slice scope remains deferred;
- all frozen manifest identities/classifications remain unchanged.

These findings constrain repair-v3 to the two new defect families above.

## 5. No semantic escalation

The accepted requirements already determine both repairs.

Do not reopen:

- Household identity semantics;
- Recognition acquisition rules;
- lineage meaning;
- proposal ordering;
- fallback semantics;
- candidate convergence;
- head/office;
- provision spending;
- checkpointing.

If repair unexpectedly requires a new social rule, stop and escalate instead of expanding scope.

## 6. Candidate-v2 status

Keep immutable:

`imp-0003-slice3-conformance-candidate-v2` @ `69ae753da2e05450766a9042ac6958fa7aa0b3e7`.

Do not move or rewrite the ref.

## 7. Next action

Dispatch:

`tasks/implementation/IMP-0003_CANDIDATE_V2_BLOCK_REPAIR_PACKET.md`

on:

`implementation/imp-0003-slice3-repair-v3`.

After bounded repair:

1. run canonical root commands and exact-head CI;
2. freeze a new immutable candidate-v3;
3. commission another fresh whole-candidate independent conformance review;
4. promote only on **PASS — PROMOTE**.
