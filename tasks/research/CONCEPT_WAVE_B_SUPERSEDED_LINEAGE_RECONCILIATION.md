# Research Task — Concept Wave B: Superseded Source-Lineage Reconciliation

**Task ID:** RES-CONCEPT-B  
**Status:** ARCHITECT-DISPATCHED / READY  
**Context mode:** PROJECT-CONTEXT  
**Source baseline:** `conceptual-archive-source-2026-09-24-v1` @ `76508f1f766451bdd5ea1a35a16c37adb0dfd682`  
**Return branch:** `research/concept-wave-b-lineage-return`

## Question

Do the newly restored pre-V2 versions of the Two Ledgers and Anonymous Artists tablets contain any conceptual payload not preserved in the V2 tablets or current derived Institutional Dynamics machinery?

## Required source set

Read:

- `research/conceptual/SUPERSEDED_BUT_UNCOMMITTED_SOURCE_LINEAGE/`
- matching V2 tablets under `research/conceptual/THE_URUK_ACCIDENT/tablets/`
- `research/conceptual/THE_URUK_ACCIDENT/README.md`
- directly relevant `INSTITUTIONAL_DYNAMICS/` files
- `TABLET_IDEA_RECONCILIATION.md` and `CONCEPT_FAMILY_CROSS_INDEX.md` where useful.

## Duties

For each restored older version:

1. establish exact lineage relative to V2;
2. identify ideas unchanged, sharpened, removed, reframed, or unique;
3. preserve only **meaningful conceptual delta**, not prose/style differences;
4. determine whether any removed material deserves a durable derived home;
5. distinguish:
   - superseded wording;
   - unique causal observation;
   - useful challenge case;
   - project/governance analogy;
   - already-absorbed core.

## Required output / allowed mutation

Create:

`research/conceptual/ingestion/2026-09-24/B_SUPERSEDED_SOURCE_LINEAGE_RECONCILIATION.md`

Also create a concise local:

`research/conceptual/SUPERSEDED_BUT_UNCOMMITTED_SOURCE_LINEAGE/README.md`

explaining why these sources are retained, which V2 descendants supersede them for ordinary reading, and where unique deltas are recorded.

Do not edit global cross-program files; Task D owns integration.

Do not edit source tales or V2 tablets.

## Repository/work discipline

Commit all work on `research/concept-wave-b-lineage-return`. Do not merge to main.

## Return

Return branch + head SHA + exact unique conceptual deltas (if any) + explicit statement if the older versions add no new family.
