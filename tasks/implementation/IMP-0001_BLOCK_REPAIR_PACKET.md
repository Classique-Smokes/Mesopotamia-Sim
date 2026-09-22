# IMP-0001 — Candidate-v1 BLOCK Repair Packet

**Task:** IMP-0001 Slice-1 conformance repair  
**Status:** READY FOR IMPLEMENTATION AFTER RECONCILIATION MERGE  
**Base:** frozen failed candidate `7e11dab7697121eb0dbb169ba46210d81b80586e`  
**Required repair branch:** `implementation/imp-0001-slice1-repair-v2`  
**Authority:** Existing accepted SFL v0 semantics + frozen `SFL-V0-S1-ACCEPTANCE-v1` + Master Architect reconciliation  
**Forbidden:** editing/reclassifying frozen acceptance authority; inventing new social/domain priority; implementing Slice-2 systems.

## Objective

Repair the three independently reproduced candidate-v1 conformance defects while preserving every previously satisfied Slice-1 obligation.

Read first:

- `research/technical/IMP-0001/IMP-0001_CONFORMANCE_BLOCK_RECONCILIATION.md`
- archived full independent review referenced there;
- original IMP-0001 packet and execution handoff;
- accepted SPEC/ADRs;
- frozen Slice-1 manifest and verification sources.

## Repair R1 — eliminate undisclosed proposal-ID causal ordering

Candidate-v1 must no longer permit nonsemantic ProposalId ordering to change social/material outcomes without an explicit accepted technical-fallback marker.

Required work:

1. reproduce the reviewer's residence-destination dependency race and called-favour-vs-reciprocal-cancellation race using public APIs;
2. audit all executable Slice-1 action-pair interactions where committing one accepted proposal can change another's action-relevant precondition, relation/capacity, or feasibility before commit;
3. ensure every order-sensitive unresolved interaction is either:
   - semantically/order invariant; or
   - represented as an explicit conflict whose technical stable-ID fallback is disclosed exactly as accepted authority requires;
4. add proposal-ID-renaming metamorphic regressions covering discovered order-sensitive cases;
5. retain fixed-ID determinism and explicit `InvalidatedAtResolution` outcomes.

Do **not** create a new domain priority to make the tests pass.

If accepted authority does not determine how a discovered interaction may be closed without choosing new social priority, STOP and escalate with the exact interaction.

## Repair R2 — restore needy reciprocal-request refusal consequence

For a feasible voluntary refusal of:

`RelationshipMediatedReciprocalHelp(Target, Amount, Request: true)`

when the requester is in genuine unmet need, apply the accepted requester -> refuser **-5** direct attitude cause.

Required regressions:

- needy RMRH request + voluntary decline => -5;
- ordinary `RequestGiftOrHelp` control remains -5;
- no genuine need => 0;
- `Unable` => 0;
- `InvalidatedAtResolution` => 0;
- donor-offer RMRH meaning remains unchanged.

Extend the fixed-event completeness evidence/oracle path so a mandatory fixed update cannot pass merely because an omitted contribution never entered recorded history.

## Repair R3 — enforce subjective personal-agency inputs

Audit every objective-world read used by `PersonalAgency.Decide` for candidate generation, gating, and scoring.

Produce a small source/evidence table classifying each used fact as:

- own objective state;
- automatically known direct-party fact under SPEC §6.4;
- explicitly supplied/observed Slice-1 policy input;
- objective-only fact that must not control personal choice.

Remove objective-only facts from personal decision gating/scoring. Objective world feasibility may still be checked at accepted response/resolution/revalidation stages.

At minimum, reproduce the reviewer pair where only an unobserved target's grain changes. With identical actor subjective inputs, private target stock must not silently determine whether the initiator generates/selects a request candidate.

Required evidence:

- personal trace lists every subjective input actually used;
- hidden counterparty grain perturbation cannot change personal choice unless the actor has an accepted observation route to that fact;
- audit other counterparty facts used by personal policy for the same issue;
- do not implement general communication/recognition or a new observation subsystem in this repair.

If accepted authority is unclear on whether a specific counterparty fact is known, STOP and escalate rather than assuming.

## Verification

Keep the frozen manifest byte-identical.

Run the canonical root sequence:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Completion requires:

- all previously coder-owned REQUIRED rows still pass;
- no DEFERRED/N-A/UNEXERCISED reclassification;
- explicit F1/F2/F3 regression evidence;
- implementation report amended with repair evidence and any discovered interaction audit;
- no new architecture/semantic authority silently chosen.

## Return / candidate-v2

Do not move candidate-v1.

When coder-owned repair obligations are complete:

1. push the repair branch;
2. leave PR #7 unmerged unless the Master Architect deliberately retargets/replaces it;
3. report exact repair head SHA and CI run;
4. Master Architect will freeze a new `imp-0001-slice1-conformance-candidate-v2` only after reconciliation;
5. candidate-v2 requires a **fresh independent K4 review**.

A green repair branch is not VERIFIED COMPLETE until that fresh review passes.
