# The Uruk Accident — Institutional Persistence Seed

**Status:** DURABLE NON-AUTHORITATIVE CONCEPT SEED / OBSERVER-ARTIFACT COLLECTION  
**Authority:** Advisory / explanatory only. Not accepted simulation semantics, historical evidence, architecture, or implementation requirements.  
**Collection opened:** 2026-09-21

This directory preserves the original "Uruk Accident" observer note plus later companion tablets that emerged from the same accidental project-as-social-laboratory tradition.

The collection exists so future institutional-design work can recover complete observations and challenge cases from durable source artifacts rather than from summaries or conversational memory.

## Original preserved source

- Original filename: `THE_URUK_ACCIDENT_institutional_persistence_note.md`
- Archive: `archive/THE_URUK_ACCIDENT_institutional_persistence_note.md.br`
- Original size: **39,358 bytes**
- Original line count: **1,006**
- Original SHA-256: `cf336e5d3777321ff2252518871269d0c56e231f424be705263c87702a9f4abe`
- Brotli archive size: **10,889 bytes**
- Brotli archive SHA-256: `d8017336ff5c19b7a984468f8ba5e9573303f7062cd27153ffe660b96850aa63`

Restore locally:

```sh
brotli -d -c archive/THE_URUK_ACCIDENT_institutional_persistence_note.md.br > THE_URUK_ACCIDENT_institutional_persistence_note.md
sha256sum THE_URUK_ACCIDENT_institutional_persistence_note.md
```

The restored file must match the original SHA-256 above.

## Companion tablets

The files under `tablets/` are preserved as readable Markdown source artifacts.

| Tablet | Role in the collection | Bytes | Lines | SHA-256 |
|---|---|---:|---:|---|
| `MORTALITY_IS_OUTSIDE_TASK_SCOPE.md` | Observer tale about office succession, recognized authority forms, informal roles/culture, institutional clocks, continuity burden, and peripheral cognition | 16,122 | 654 | `c81351d0633e1c8755dea246b2d876dc363ac259a5086c9add139b3553ea801d` |
| `THE_MAN_RESPONSIBLE_FOR_TWO_LEDGERS_V2.md` | Causal challenge case about effective responsibility, learning, coordination scarcity, relationship resilience, motivation/capacity, and institutional improvement alongside individual depletion | 15,501 | 678 | `09dc36df88856960bb706a661982bbf98b0425b1cd658bb6970fc61957072677` |
| `THE_TRAGEDY_OF_THE_ANONYMOUS_ARTISTS_V2.md` | Observer tale about memory by consequence, attribution loss, artifact genealogy, copying/transformation, official vs causal genealogy, and anonymous causal contribution | 12,780 | 486 | `e12e8afc7c888d85f3ecd47d640023670f88a879128c0f4c085015167bb38a9f` |

Preservation verification on ingestion compared each committed Git blob SHA to the Git blob SHA calculated from the exact uploaded bytes; all three matched.

### Review-era correction tablet

The current institutional-dynamics draft branch also preserves:

- `tablets/THE_JESTERS_CORRECTION_INSTITUTIONAL_AGE_AND_LOST_BEGINNING.md` — correction distinguishing elapsed time from institutional age, documenting the project's lost pre-repository prehistory, and warning against treating the institutional-dynamics umbrella as a universal ontology.

This source is part of draft PR #10 and is not yet on canonical `main`.

## Derived interpretation

Current draft interpretation of this corpus is kept separately at:

`../INSTITUTIONAL_DYNAMICS/`

That package is **not** part of the source tablets and may change as project understanding evolves. Keeping it separate preserves the distinction between observer artifacts and later Master Architect synthesis.

## How to use this collection

These artifacts are **idea seeds and challenge material**, not a backlog of mechanics.

A useful future use may be:

- recovering a causal distinction that deserves research;
- defining a later challenge case for emergent institutional behavior;
- recognizing that two apparently similar concepts need to remain separate;
- motivating targeted historical or technical investigation;
- preserving an observation until lower-level simulation machinery is mature enough to make the question actionable.

A bad use would be:

- turning a memorable phrase into a mechanic;
- treating project roleplay as historical evidence;
- copying a proposed causal distinction directly into the simulation model;
- adding future systems merely because a tablet mentions them;
- treating the collection as authority over accepted specifications.

## Governance

Committing these artifacts does **not** promote their conclusions. They remain non-canonical.

If later work uses hypotheses about institutional persistence, office continuity, authority forms, archives, recognition, memory, labor, motivation, coordination, social roles, or competing genealogies, retrieve the relevant complete tablet, reconcile it against then-current project authority and relevant evidence, and use the normal research/design/decision process for any consequential promotion.

No root authority, decision register, current-phase record, accepted specification, or implementation packet is changed by this collection. Per the project's retrieval-closure rules, non-authoritative conceptual material does not require a root navigation update merely because it is committed.

The local collection index at `../README.md` exists for discoverability inside the conceptual library without elevating these artifacts into routine project context.
