# SFL v0 Slice 2 Discovery C — Verification Trigger Map

**Status:** READY FOR PARALLEL LOW-AUTHORITY DELEGATION  
**Work class:** Read-only frozen-verification inventory  
**Implementation authority:** none  
**Semantic/design authority:** none  
**Reclassification authority:** none  
**Owner of synthesis:** Master Architect

## Question

Which already-frozen verification obligations become executable in Slice 2, and which remain deferred to later slices?

## Retrieve

1. `AGENTS.md`
2. `00_START_HERE.md`
3. `plans/CURRENT_PHASE.md`
4. `tasks/research/SFL_V0_SLICE2_PREIMPLEMENTATION_DISCOVERY.md`
5. frozen Slice-1 acceptance manifest and freeze record
6. canonical Stage-3 verification package under `plans/verification/SFL_V0/`
7. assumptions/deferred-gap registers cited by those sources
8. accepted spec only when needed to identify which slice owns an existing row

Do **not** use the new conceptual tablet collections as verification authority or systematize them.

## Produce

Inventory verification obligations involving or depending on:

- actor-specific knowledge;
- observation/participation provenance;
- communication provenance/cost;
- stale knowledge;
- recognition;
- contested recognition;
- subjective action availability;
- subjective decision-input explainability;
- anti-omniscience / objective-vs-subjective boundaries.

Separate them into:

1. **fires in Slice 2**;
2. **remains deferred beyond Slice 2**;
3. **depends on a semantic question that must be settled first**;
4. **already satisfied by Slice 1 infrastructure but must remain regression-protected**.

Preserve every existing AcceptanceId/classification exactly. This task has zero authority to relabel REQUIRED/DEFERRED/N-A/UNEXERCISED.

Identify missing executable coverage only as a planning gap; do not author new acceptance authority.

## Return

Create branch:

`research/slice2-verification-trigger-return`

from current `origin/main` at execution start.

Add only:

`research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md`

Record the exact base SHA used.

No other repository mutation.
