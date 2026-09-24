# IMP-0003 Candidate-v3 — Independent Conformance BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / REPAIR-v4 REQUIRED  
**Date:** 2026-09-23  
**Failed candidate ref:** `imp-0003-slice3-conformance-candidate-v3`  
**Exact failed candidate SHA:** `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`  
**Independent review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`  
**Verdict:** **BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**  
**Recommendation:** **DO NOT PROMOTE**

## 1. Bottom line

Candidate-v3 successfully repaired candidate-v2's remaining warrant-oracle gaps for formation, exit-continuation and lineage, and repaired the disconnected-compatible-loan false fallback case.

Fresh whole-candidate review then found two narrower remaining defects:

1. Household-connected compatible ordinary loans still receive false `TechnicalFallback` because Household projection comparison retains allocation-sensitive identities.
2. The independent checker does not fully bind Household lifecycle event/time provenance or exact retained Recognition `KnownFact.Id` identities.

No new social or architectural decision is required.

Candidate-v3 remains immutable failed evidence. Repair belongs on a successor branch and must return through a new exact candidate + fresh independent whole-candidate conformance review.

## 2. B1 — Household-connected compatible ordinary loans still falsely fall back

**Accepted.**

Candidate-v3 correctly routes structurally Household-independent ordinary components back through the inherited resolver. That fixes the disconnected reproducer.

However, when the ordinary loan actors themselves have Household/candidate contact, the component remains on the Household resolver. There, detached real-commit replay allocates new relation/event/evidence identities according to execution order. `HouseholdProjectionKey` delegates its World portion to inherited `ProjectionKey`, whose normalization assumes synthetic proposal-bound origins. Generic epistemic fact serialization also retains allocation-sensitive IDs.

Therefore two semantically compatible loans can end in equal material/social state but still compare unequal solely because internal allocation identities differ.

### Required repair

Normalize allocation-sensitive relation/event/evidence identities throughout **Household-connected** counterfactual projection by semantic causal origin, while preserving genuinely meaningful distinctions.

At minimum:

- newly created debts/favours/marriages/other ordinary relations must compare by semantic contents + causal proposal origin rather than allocated ID;
- epistemic facts about those relations must normalize their embedded allocated relation/event IDs consistently;
- communication hops and accepted event provenance must remain semantically distinguishable where they affect evidence order/meaning;
- Household identity/warrant/association provenance must remain intact;
- do not suppress fallback merely because final grain balances match.

Retain positive detection for genuinely noncommuting cases:

- residence/admission;
- captured communication invalidation;
- scarce material capacity;
- favour/debt interaction;
- Household participation/lifecycle/continuity.

### Required regression

Add Household-connected compatible-loan controls in which the lenders/borrower are current/relevant Household actors.

Exercise:

- swapped proposal IDs;
- reversed proposal input order;
- relevant initial-world enumeration permutations.

Require:

- both loans commit;
- normalized semantic endpoints remain equal;
- `TechnicalFallback=false`.

Also retain the already-green disconnected compatible-loan controls and all positive fallback controls.

## 3. B2 — lifecycle and Recognition evidence reference identities are under-verified

**Accepted.**

### B2a. Household lifecycle provenance

The oracle reconstructs lifecycle enum from current participant count, but does not independently bind published:

- `LifecycleEvent`;
- `LifecycleTime`;

to the actual stable-closure lifecycle transition.

A detached Dissolved Household with a nonexistent lifecycle event ID and impossible negative time can pass.

### Required repair

For each Household lifecycle publication, independently validate:

- current enum matches stable participant count;
- lifecycle event exists;
- event refers to the correct Household and lifecycle value;
- lifecycle time equals the event's actual cycle/reaction index;
- initial Active publication is grounded in the appropriate formation closure;
- subsequent Active/Inactive/Dissolved changes are grounded in the correct transition/closure cause;
- no stale/fabricated lifecycle reference can pass;
- rule/configuration provenance is truthful if stored on the lifecycle event/path.

Add exact detached corruptions for:

- nonexistent lifecycle event ID;
- fabricated lifecycle time;
- mismatched lifecycle event/H/state.

### B2b. Retained Recognition evidence identity

`SameEvidence` currently compares proposition/provenance but not `KnownFact.Id`.

A ParticipationWarrant Recognition basis can therefore substitute a nonexistent evidence ID while retaining identical proposition/provenance and still pass.

Stable evidence identity matters because public held-fact actions and commit-time held-payload checks reference exact `EvidenceId`.

### Required repair

For Recognition bases used by formation/participation/continuity verification:

- bind each retained `KnownFact.Id` to an actual actor-held fact identity at the applicable precommit/stable boundary;
- preserve support for valid stale retained Recognition;
- handle same-cycle acquired evidence by reconstructing the actual acquisition event/hop and resulting evidence identity rather than weakening identity checks;
- keep proposition/provenance checks in addition to identity checks.

Add detached corruption with a fabricated `EvidenceId` and require checker rejection.

## 4. What candidate-v3 independently cleared

The fresh review confirmed that the following earlier repairs now hold:

- participation-entry oracle hardening;
- truthful per-context S2/S3 rule provenance under custom scenario labels;
- remote-bearer continuation staleness;
- formation/continuation/lineage warrant reconstruction and 63 corruption controls;
- disconnected compatible-loan false-fallback repair;
- all required positive fallback controls;
- formation, participation, continuity, turnover, lifecycle state semantics, lineage, recognition, provision and closure behavior otherwise remain supported;
- S1-084 remains unfired;
- later-slice scope remains deferred.

These findings constrain repair-v4 to the two remaining defect families above.

## 5. No semantic escalation

Do not reopen:

- Household identity or lifecycle semantics;
- Recognition acquisition semantics;
- fallback semantics;
- candidate convergence;
- head/office;
- provision spending;
- checkpointing;
- lineage meaning.

If repair would require a new social rule, stop and escalate rather than inventing one.

## 6. Candidate-v3 status

Keep immutable:

`imp-0003-slice3-conformance-candidate-v3` @ `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`.

Do not move or rewrite the ref.

## 7. Next action

Dispatch:

`tasks/implementation/IMP-0003_CANDIDATE_V3_BLOCK_REPAIR_PACKET.md`

on:

`implementation/imp-0003-slice3-repair-v4`.

After bounded repair:

1. run canonical root commands and exact-head CI;
2. freeze candidate-v4;
3. commission a fresh whole-candidate independent conformance review;
4. promote only on **PASS — PROMOTE**.
