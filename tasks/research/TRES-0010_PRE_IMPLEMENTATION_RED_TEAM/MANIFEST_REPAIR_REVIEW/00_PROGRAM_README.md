# TRES-0010 — Slice-1 Manifest Repair Review

**Status:** PREPARED / TARGETED ADVISORY REVIEW  
**Authority:** Advisory research only  
**Canonical mutation:** Forbidden  
**Implementation gate:** IMP-0001 remains blocked.

## 1. Purpose

The first independent pre-code review of the Slice-1 acceptance manifest returned BLOCK.

This targeted review does **not** ask agents to repair the manifest and does not treat the blocker report as authority.

Its job is to independently re-derive the three classes of concern that matter before any manifest edit:

1. **boundary completeness** — whether every cross-cutting boundary family has an explicit Slice-1 status and whether any other boundary is missing/misclassified;
2. **semantic subordination / wording scope** — whether manifest wording accidentally broadens, narrows, merges, or invents semantics relative to accepted SPEC;
3. **grain-ingress exhaustiveness** — exactly which grain-denominated semantic ingress routes must be covered by D4 invalid-term verification in Slice 1.

The Master Architect will reconcile these returns with the original blocker report. No agent decision becomes canonical by being returned.

## 2. Review design

Run exactly three fresh-chat tasks:

1. `TRES-0010-MRR-A_BOUNDARY_COMPLETENESS_AUDIT.md`
2. `TRES-0010-MRR-B_SEMANTIC_SUBORDINATION_AUDIT.md`
3. `TRES-0010-MRR-C_GRAIN_INGRESS_AUDIT.md`

Each task:

- uses the same frozen baseline;
- works on its own isolated return branch;
- may read only the assigned canonical/source artifacts;
- must not read sibling returns before finalizing;
- must not edit canonical project files;
- must not read the prior manifest BLOCK report unless its own packet explicitly says so (none do);
- must distinguish accepted semantic authority from verification design and task scope;
- must prefer exact source citation/path/section evidence over intuitive repair suggestions;
- must actively try to disconfirm the concern class it was assigned;
- may conclude that the original block was incomplete, overstated, or correct.

## 3. Source hierarchy

For all three tasks:

1. accepted SPEC / accepted ADRs control social and simulation semantics;
2. canonical verification artifacts describe verification obligations but do not create social semantics;
3. IMP-0001 defines current implementation scope/handoff but cannot override accepted semantics;
4. the candidate `SLICE1_ACCEPTANCE_MANIFEST.md` is the object under review and is not yet acceptance authority;
5. research summaries and prior blocker labels are not authority.

## 4. Common stop rules

Stop and report rather than inventing new semantics if:

- a classification cannot be derived uniquely from accepted sources;
- a proposed manifest wording would require changing SPEC;
- a test obligation would force implementation of explicitly deferred subsystem semantics;
- a concern depends on a missing artifact not supplied by the repository.

## 5. Required return metadata

Every return must record:

- task ID;
- frozen baseline ref and SHA;
- return branch;
- model/configuration if visible;
- tools used;
- external research: no (unless the task packet explicitly changes this; none do);
- sibling returns read before completion: must be no;
- prior BLOCK report read before completion: must be no;
- canonical files modified: must be no.

## 6. After returns

The Master Architect will consolidate:

- original independent BLOCK report;
- MRR-A boundary inventory;
- MRR-B semantic-scope audit;
- MRR-C grain-ingress matrix.

Only then will a corrected manifest candidate be drafted.

No second review baseline is created until the correction set is reconciled.
