# SFL v0 Slice 2 — Acceptance Applicability Pre-Code Review

**Status:** READY FOR FRESH INDEPENDENT REVIEW  
**Candidate under review:** `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_APPLICABILITY_CANDIDATE.md`  
**Candidate branch:** `verification/sfl-v0-slice2-acceptance-candidate-v1`  
**Candidate commit:** `60df1089f9ad03eeccc361215e033aa6fde174fd`  
**Review authority:** read-only / PASS or BLOCK only  
**No implementation authority:** yes  
**No semantic promotion authority:** yes

## Purpose

Independently determine whether the proposed Slice-2 completion authority is:

- complete enough to prevent implementer self-selection;
- strictly subordinate to accepted SFL semantics;
- narrow enough not to pull later slices forward;
- strong enough to test subjective-state causality, provenance, communication, staleness and contestation;
- representation-neutral where semantics do not fix schema/API.

Do not repair production code. Do not redesign Slice 2.

## Required sources

Retrieve independently:

1. `AGENTS.md`
2. `00_START_HERE.md`
3. accepted `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
4. accepted ADRs, especially ADR-0001/0002/0004
5. `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`
6. frozen `SLICE1_ACCEPTANCE_MANIFEST.md`
7. `research/technical/SFL_V0_SLICE2_AUTHORITY_INVENTORY.md`
8. `research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md`
9. `research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md`
10. `research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md`
11. the exact candidate file/commit above.

The conceptual tablet material may be consulted only to verify that it has **not** become authority.

## Mandatory review questions

### A. Semantic subordination

For every REQUIRED row:

- is the expected property uniquely supported by accepted authority?
- does wording overclaim beyond the cited semantic scope?
- does any test concept invent trust, rumor, reputation, perception, household/head, richer planning, or new evidence ordering?

### B. Applicability completeness

Check whether any accepted Slice-2 behavior can be silently omitted.

Check the mapping from:

- objective/subjective separation;
- KnownFact;
- Recognition;
- communication;
- staleness;
- provenance ordering;
- Contested;
- subjective gating;
- trace/inspection;
- regression protection.

### C. Review Gate RG-01 — Contested Recognition

This is the highest-priority question.

Independently determine whether a **Slice-2-valid executable witness** can prove:

- persistent `Contested`;
- incomparable incompatible Recognition evidence;
- no arbitrary stable-ID/sender-ID/arrival-order winner;

without making Household/head/succession/mediated marriage executable and without inventing a new recognition proposition family.

Assess the candidate's preferred bounded `CandidateRecognition(C)` route.

Return one of:

1. **SUPPORTED** — explain the exact accepted source chain and safe fixture/witness boundary;
2. **NOT SUPPORTED** — explain which semantic distinction is missing;
3. **SUPPORTED ONLY WITH CANDIDATE REPAIR** — acceptance wording/fixture design needs change but no new simulation semantics.

Do not invent the missing rule yourself.

### D. Review Gate RG-02 — observation

Confirm that all REQUIRED completion rows can be evidenced using:

- own/direct knowledge;
- direct participation;
- communication;
- non-result-writing controlled epistemic fixtures where valid.

If any REQUIRED row actually depends on unspecified nonparticipant observation eligibility, BLOCK and identify the exact event/question.

### E. Autonomous communication

Confirm that pinned laboratory communication policy is sufficient for completion and that the candidate does not silently turn numeric communication preference into accepted social semantics.

### F. Fixture discipline

Audit whether allowed epistemic fixture ingress can accidentally write the result being tested.

Require explicit per-row write sets.

### G. Oracle independence

Check that production evidence-resolution / candidate-generation helpers cannot grade themselves.

### H. Later-slice leakage

Explicitly search for accidental requirements involving:

- Household identity/lifecycle;
- head/representative office;
- mediated marriage;
- household provision;
- lineage;
- checkpoint/restore.

### I. Broad/global wording

Challenge words such as:

- every;
- only;
- all;
- global;
- identical;
- complete;
- invariant.

Require bounded-domain enumeration, structural evidence or metamorphic evidence appropriate to the claim.

## Return

Create branch:

`review/sfl-v0-slice2-acceptance-precode-return`

from candidate commit `60df1089f9ad03eeccc361215e033aa6fde174fd`.

Add only:

`research/technical/SFL_V0_SLICE2_ACCEPTANCE_PRECODE_REVIEW.md`

The report must contain:

- exact reviewed candidate commit/blob;
- PASS or BLOCK;
- RG-01 classification;
- RG-02 classification;
- missing/over-broad/under-specified rows;
- any fixture/oracle defects;
- whether any issue truly requires Director-level semantic authority;
- exact repairs if they are verification-authority repairs rather than semantic decisions.

Do not edit the candidate.
