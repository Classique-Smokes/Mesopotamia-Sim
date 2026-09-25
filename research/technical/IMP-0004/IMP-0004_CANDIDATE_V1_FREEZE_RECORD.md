# IMP-0004 — Slice-4 Conformance Candidate v1 Freeze Record

**Status:** FROZEN IMPLEMENTATION CANDIDATE / FRESH INDEPENDENT CONFORMANCE REQUIRED  
**Date:** 2026-09-25  
**Task:** `tasks/implementation/IMP-0004_SFL_V0_SLICE4_HOUSEHOLD_HEAD_AND_COLLECTIVE_ACTION.md`  
**Implementation candidate ref:** `imp-0004-slice4-conformance-candidate-v1`  
**Exact candidate SHA:** `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`  
**Implementation branch:** `implementation/imp-0004-slice4-household-head-collective-action`  
**Implementation PR:** #109 — draft / not merged  
**Candidate report:** `research/technical/IMP-0004/IMP-0004_CANDIDATE_IMPLEMENTATION_REPORT.md`

## 1. Candidate disposition

The coding bārû returned terminal status:

> **COMPLETE CANDIDATE**

This is not VERIFIED COMPLETE and not authority to promote.

The exact implementation head above is frozen for independent whole-candidate conformance. Do not move the candidate ref.

PR #109 remains unmerged until fresh independent review returns **PASS — PROMOTE** on this exact candidate.

## 2. Controlling semantic / architectural authority

The candidate is reviewed against current accepted authority, including:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted architecture / ADRs;
- DEC-0010 — authority use before destruction;
- DEC-0011 — transaction-specific current-head private supplementation;
- DEC-0013 — Slice-4 SID closure / v0 resource-scaffold boundaries;
- DEC-0014 — historical material-need context for provision reconsideration.

DEC-0014 escalation-closure records:

- `research/technical/IMP-0004/IMP-0004_IMPLEMENTATION_ESCALATION_01_CLOSURE.md`;
- `research/technical/IMP-0004/DEC-0014_ACCEPTANCE_AND_SID_FRESHNESS_REVALIDATION.md`.

## 3. Frozen completion authority

Slice-4 completion authority remains unchanged:

- manifest: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`;
- version/ref: `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`;
- frozen manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`;
- census: **176 = 165 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.

Exact inherited REQUIRED sets remain:

- Slice 1: **128**
- Slice 2: **46**
- Slice 3: **96**
- inherited REQUIRED total: **270**

## 4. Approved inherited-verification adaptation authority

- approved ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`;
- exact approved plan commit: `68fddec788b5cf41db5934c8719a6fd1ce474d32`;
- exact plan blob: `00c3e64a128fa00e91b99117e321a0e379dd61c5`;
- approval record: `plans/verification/SFL_V0/SLICE4_INHERITED_VERIFICATION_ADAPTATION_V2_APPROVAL_RECORD.md`.

Coder-owned execution ledger:

`research/technical/IMP-0004/IMP-0004_ADAPTATION_LEDGER.md`

All four approved mappings A–D are reported as fired. This claim requires fresh reviewer verification.

## 5. Exact-head omens / CI

Exact candidate SHA:

`bac53decaafb5edf4c5879be0f695f6a52ccc1ce`

GitHub Actions:

- workflow: `canonical-verification`
- run: **36094176584**
- conclusion: **success**
- job: **107942793791 / verify**
- checkout in CI: exact candidate SHA above

Canonical CI steps completed successfully:

1. checkout exact candidate;
2. .NET setup / SDK information;
3. `dotnet restore Mesopotamia.Sim.slnx`;
4. `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`;
5. `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`;
6. `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`;
7. acceptance evidence generation/upload.

CI test summary:

- total test entries: **67**
- succeeded: **67**
- failed: **0**
- skipped: **0**

These test-entry counts are harness counts, not AcceptanceId counts.

## 6. Evidence artifact

Exact-head workflow artifact:

- artifact ID: **10846019591**
- name: `sfl-slice1-slice2-slice3-slice4-acceptance-evidence`
- size: **1,909,514 bytes**
- digest: `sha256:22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6`
- workflow run: **36094176584**
- artifact head branch: `implementation/imp-0004-slice4-household-head-collective-action`
- artifact head SHA: `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`

The artifact is corroborating evidence only. Independent conformance must inspect source, assertions, oracles, fixtures, mappings and reviewer-owned probes rather than awarding PASS from generated PASS tables.

## 7. Coder claims requiring independent confirmation

The candidate report claims:

- **165 / 165** Slice-4 REQUIRED rows individually evidenced;
- **9 DEFERRED / 2 UNEXERCISED** individually retained;
- **270 / 270** inherited REQUIRED rows individually green;
- all four approved inherited adaptations applied losslessly;
- exact critical-seam hidden/stale-authority mutant evidence;
- DEC-0014 mutants 53–56 execute the real kernel and are detected;
- independent reconstruction/corruption checks for role, funding, material effects and provenance;
- no semantic scope beyond accepted Slice 4;
- no new unresolved semantic issue after DEC-0014.

These are review targets, not accepted conclusions.

## 8. Main / candidate ancestry note

Current canonical `main` contains later non-authoritative conceptual-library integration commits that are not ancestors of the frozen implementation candidate.

The candidate and `main` share semantic/process base:

`6704d25b800bcb4f16d974a867a7fa8c1332ace9`

The candidate is five implementation commits ahead of that merge base.

This does not invalidate conformance because the later main-only changes are conceptual-library systematization/navigation and do not alter implementation semantic authority or the implementation code under review.

Promotion must occur through PR #109 onto then-current `main`, with a final implementation-diff/no-drift verification.

Do not rebase/move candidate-v1 merely to absorb unrelated conceptual commits: doing so would create a new unreviewed candidate SHA and invalidate the exact-head omens above.

## 9. Promotion gate

Only fresh independent verdict:

> **PASS — PROMOTE**

on exact `imp-0004-slice4-conformance-candidate-v1` may authorize promotion.

BLOCK verdicts preserve this immutable candidate/ref and require a new repair/candidate lineage.

After PASS, Master Architect must:

1. verify candidate/ref/CI identities remain unchanged;
2. verify PR #109 implementation diff matches the reviewed candidate;
3. promote through PR #109 without implementation/test drift;
4. run canonical post-promotion CI;
5. record final IMP-0004 completion/promotion.
