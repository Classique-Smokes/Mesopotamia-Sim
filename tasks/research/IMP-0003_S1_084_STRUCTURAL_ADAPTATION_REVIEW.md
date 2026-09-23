# IMP-0003 — S1-084 Structural Evidence Adaptation Review

**Task ID:** IMP-0003-S1-084-ADAPT  
**Commissioned by:** Master Architect  
**Status:** CONDITIONAL TRIGGER TASK / DO NOT RUN UNLESS FIRED  
**Context mode:** PROJECT-CONTEXT / independent verification review  
**Authority level:** engineering/verification only; no semantic authority  
**Required return path:** `research/technical/IMP-0003/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

## 1. Trigger

Run this task **before** any IMP-0003 change that would:

- change the exact private-field inventory of `WorldState`; or
- edit, replace, loosen, bypass, or reinterpret the existing `NoDerivedAuthorityStructuralAudit` evidence route for frozen `S1-084`.

If IMP-0003 preserves both the exact `WorldState` private-field inventory and the existing S1-084 structural audit unchanged, this task remains unfired.

The implementation author may inspect this packet in advance, but may not self-authorize an adaptation.

## 2. Question

Does the proposed S1-084 test/evidence adaptation preserve the frozen semantic invariant **without weakening detection of hidden behavior-affecting derived authority**, while allowing only the newly authorized Slice-3 authoritative state required by accepted semantics?

## 3. Why this exists

Frozen Slice-1 `S1-084` is still REQUIRED.

Its current executable evidence is implementation-local: `NoDerivedAuthorityStructuralAudit` reflects the exact private-field inventory of `WorldState` and compares it to the Slice-1 field set.

Slice 3 introduces legitimate new authoritative Household/warrant state. The frozen invariant is not “WorldState may never gain authoritative fields.” It is:

> no hidden behavior-affecting derived/cache authority may exist.

The final Slice-3 pre-code review explicitly approved a **separately reviewed lossless adaptation** if the current exact private-field inventory must change. It did not authorize the coder to weaken the regression locally.

## 4. Required inputs

### Accepted / frozen authority

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- accepted ADRs under `architecture/accepted/`, especially ADR-0001, ADR-0003, ADR-0004
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`
- `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_FREEZE_RECORD.md`
- frozen Slice-3 ref `sfl-v0-slice3-acceptance-v1`

### Current executable evidence

- `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs`
- specifically `NoDerivedAuthorityStructuralAudit` and its bindings:
  - `S1-084`
  - `S1-META-05`
  - `S1-MUT-24`

### Proposed implementation change

The implementer must supply an exact branch/head SHA and the proposed test/evidence adaptation diff.

Do not review a prose-only intention if the trigger has fired. Review the concrete proposed evidence path.

## 5. Review obligations

The reviewer must determine:

1. which newly introduced fields/partitions are **authoritative semantic state** versus derived/cache/index/reporting state;
2. whether every new authoritative field is actually required by accepted Slice-3 semantics or is merely an implementation convenience;
3. whether the proposed structural/rebuild evidence still detects an unauthorized behavior-affecting derived cache;
4. whether immutable snapshot isolation / stale-cache nonauthority remains observable;
5. whether the adaptation silently permits arbitrary new private fields without classification;
6. whether the adaptation changes frozen S1-084 meaning rather than only its implementation-local evidence mechanism;
7. whether any production helper under judgment is being allowed to certify its own nonauthority.

## 6. Acceptable adaptation shapes

The review may accept any implementation-local evidence shape that faithfully preserves frozen meaning, for example:

- an exact whitelist that explicitly distinguishes authorized authoritative Slice-3 fields from forbidden derived authority;
- a structural classification of state partitions plus independent rebuild/stale-cache challenge for any derived projections;
- preserving `WorldState` exact inventory while placing newly authorized authoritative state in a separately explicit authoritative partition, provided that partition itself is audited and immutable/publication semantics remain correct;
- another evidence form whose coverage is demonstrably at least as strong as the frozen invariant.

These are examples, not prescribed architecture.

## 7. Unacceptable adaptations

BLOCK if the proposal:

- deletes S1-084;
- changes REQUIRED to skipped/deferred;
- replaces exact checking with “tests pass, therefore no hidden authority”;
- permits arbitrary private fields with no authoritative/derived classification;
- treats a production cache rebuild helper as its own independent oracle;
- exempts Household/lineage/provision state from audit merely because Slice 3 needs it;
- converts history into event-sourced current authority;
- changes accepted semantic ownership to make the old test convenient;
- weakens S1-META-05 or S1-MUT-24 coverage.

## 8. Required adversarial probes

At minimum try to show that the proposed adapted evidence would fail to detect:

1. a stale participant-count cache influencing lifecycle;
2. a stale continuity lookup influencing identity;
3. a stale `DerivedFrom`/ancestry cache influencing behavior;
4. a stale provision-capacity cache influencing behavior;
5. an unauthorized hidden “Members” collection becoming causal authority;
6. a private derived field added without being audited.

If the implementation has no such cache, structural evidence must make that absence credible.

## 9. Verdict

Return exactly one:

- **PASS — LOSSLESS S1-084 ADAPTATION AUTHORIZED FOR THIS EXACT DIFF**
- **BLOCK**

A PASS applies only to the exact implementation/test diff and head SHA reviewed. If the adaptation changes later, review again.

## 10. Mutation rules

This task is review-only by default.

The reviewer must not edit accepted manifests, SPEC, ADRs, or implementation candidate code.

If a dedicated review branch is used, the only required durable mutation is the return artifact:

`research/technical/IMP-0003/IMP-0003_S1_084_STRUCTURAL_ADAPTATION_REVIEW.md`

## 11. Return contents

Record:

- implementation branch/head SHA reviewed;
- exact files/diff reviewed;
- whether the trigger genuinely fired;
- authoritative vs derived/cache classification;
- comparison to frozen S1-084 meaning;
- adversarial probe outcomes;
- verdict;
- contamination/provenance disclosure.

This review does not authorize any new simulation semantics.
