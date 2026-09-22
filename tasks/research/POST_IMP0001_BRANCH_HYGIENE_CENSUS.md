# Delegated Task — Remote Branch Hygiene Census

**Status:** READY FOR LOW-AUTHORITY DELEGATION
**Context mode:** PROJECT-CONTEXT
**Mutation authority:** READ-ONLY. Do not delete, rename, move, force-update, merge, or create branches.
**Trigger:** May run now as read-only work; destructive cleanup remains deferred until the active repair-v3 / candidate-v3 conformance lineage is settled.

## Objective

Inventory every remote branch in `Classique-Smokes/Mesopotamia-Sim` and return a concise classification so the Master Architect can approve a deletion set without personally performing high-volume branch archaeology.

## Required retrieval

Read:

- `AGENTS.md`;
- `00_START_HERE.md`;
- `plans/CURRENT_PHASE.md`;
- `plans/POST_IMP0001_ASSURANCE_RETROSPECTIVE_AND_BRANCH_HYGIENE.md`;
- current open PR metadata;
- canonical records that explicitly name frozen candidate, acceptance, review, research or governance refs.

Do not load unrelated simulation theory merely to classify Git refs.

## Census fields

Return one row per remote branch with:

- branch name;
- head SHA;
- whether an open PR uses it;
- ahead/behind/reachability relative to current `main`;
- whether it contains unique commits not reachable from `main`;
- whether canonical project text explicitly names the ref;
- known role/purpose where recoverable from repository records;
- proposed class:
  - `ACTIVE`;
  - `KEEP — FROZEN AUTHORITY/EVIDENCE`;
  - `KEEP — TEMPORARILY NEEDED`;
  - `DELETE — MERGED/REDUNDANT`;
  - `DELETE — ABANDONED/SUPERSEDED`;
  - `AMBIGUOUS — MASTER ARCHITECT REVIEW`;
- one-sentence rationale.

## Classification rules

Never recommend deletion merely because a branch is old.

Prefer KEEP when:

- an open PR uses the branch;
- current implementation/review work depends on it;
- it is an intentionally frozen acceptance/conformance/review baseline;
- canonical text names the ref as evidence/authority and replacement provenance is not clearly durable elsewhere;
- it contains unique commits whose disposition is unclear.

Prefer DELETE when:

- its meaningful content is already merged/reachable from `main` and no canonical record requires the branch ref itself;
- it is an abandoned/superseded working branch with no unique authoritative/evidentiary content;
- a newer canonical/frozen ref explicitly supersedes it and the old working branch adds no required provenance.

Use AMBIGUOUS rather than guessing.

## Special protected lineage during this census

Do not recommend deletion of refs needed for the active IMP-0001 repair/conformance lineage, including:

- `main`;
- `sfl-v0-slice1-acceptance-v1`;
- `imp-0001-slice1-conformance-candidate-v1`;
- `imp-0001-slice1-conformance-candidate-v2`;
- `implementation/imp-0001-slice1` while PR #7 remains an unreconciled historical draft lineage;
- `implementation/imp-0001-slice1-repair-v2` while PR #16 remains an unreconciled historical draft lineage;
- `implementation/imp-0001-slice1-repair-v3` / PR #23 while repair-v3 is active;
- any later candidate-v3 ref or fresh-v3 review return branch once created;
- any branch tied to an open PR unless the Master Architect has explicitly reconciled its deletion.

## Output

Add one report only:

`research/technical/REPOSITORY_BRANCH_HYGIENE_CENSUS.md`

on a dedicated return branch:

`maintenance/branch-hygiene-census-return`

Do not mutate any other repository path.

Include:

- census timestamp/current main SHA;
- branch count;
- counts by proposed class;
- complete branch table;
- short list of AMBIGUOUS refs requiring Master Architect judgment;
- proposed deletion set, clearly marked **PROPOSAL ONLY — NOT EXECUTED**.

## Stop condition

If repository permissions/tools do not expose enough information to determine reachability or canonical reference use, return the incomplete census with exact missing evidence. Do not compensate by deleting or assuming.
