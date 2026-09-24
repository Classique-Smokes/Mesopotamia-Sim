# SFL v0 Slice 4 — Acceptance Candidate1 BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / CANDIDATE2 READY FOR FRESH REVIEW  
**Date:** 2026-09-24  
**Candidate1 ref:** `sfl-v0-slice4-acceptance-v1-candidate1`  
**Candidate1 commit:** `a1cd8c9848bb94ca3351d804964c070cc279aa3a`  
**Candidate1 blob:** `1600332fda22ed1215485bb432e570ff9c08d52f`  
**Independent review:** `research/technical/SFL_V0_SLICE4_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE1.md`  
**Verdict:** **BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT**

## 1. Judgment

Candidate1 is not freezeable unchanged.

The independent reviewer found exactly two candidate-level defects:

1. `S4-149-ISOMORPHIC-ID-RENAMING` omitted the already-accepted stable-ID fallback exception for exact contributor-capacity ties;
2. the newly executable mediated-marriage route lacked an omission-detectable Slice-4 row enforcing global grain-term validity on `proposedDowry` **before** the role-scoped head response.

No social-semantic or architectural escalation is required.

All other reviewed Slice-4 areas were cleared, including:

- DEC-0010 exactness;
- role identity / appointment / vacancy / succession;
- head Recognition;
- dual-mode agency;
- provision acquisition/spending;
- mediated-marriage topology;
- fixture/producer authority;
- oracle dependency + adequacy discipline;
- inherited adaptation discipline;
- deferral boundary.

## 2. Repair 1 — S4-149 fallback exception

Candidate2 changes S4-149 so isomorphic/nonsemantic ID renaming preserves semantic outcomes **except** where the scenario deliberately exercises an already-accepted disclosed stable-ID fallback domain.

In that accepted fallback domain:

- only the fallback-sensitive assignment may change;
- legitimacy/authority must not change;
- total material effect/invariants must not change;
- fallback use remains disclosed.

This aligns S4-149 with:

- SPEC §8.1;
- canonical fixed-rank exact-tie contributor semantics;
- S4-083;
- cross-cutting fallback quarantine.

No new rule is introduced.

## 3. Repair 2 — mediated dowry term validity

Candidate2 adds:

`S4-115-MEDIATED-DOWRY-TERM-VALIDITY`

The row requires the Household-mediated `ProposeMarriage` path to obey the already-accepted global grain-term domain rule before head response activation:

- zero dowry: categorically invalid;
- negative dowry: categorically invalid;
- non-integral / unrepresentable-without-coercion dowry: categorically invalid;
- invalid term produces no role-scoped response, material/social effect, or social failed-attempt outcome;
- valid positive integer may proceed to ordinary mediated-route gates.

This closes a route-specific omission-detectability gap. It does not amend marriage semantics.

## 4. Candidate2 identity

Candidate2:

- ref: `sfl-v0-slice4-acceptance-v1-candidate2`
- exact commit: `5aaf3c131e36a9139ddfa9d225c04f6fc6e86dce`
- manifest blob: `1ea19ec6c65f2031de920791334b32eaa10f398e`
- version: `SFL-V0-S4-ACCEPTANCE-v1-candidate2`
- census: **161 = 150 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**
- inherited exact REQUIRED: **270 = 128 S1 + 46 S2 + 96 S3**

Mechanical audit:

- 161 unique AcceptanceIds;
- no duplicates;
- candidate2 is exactly one commit ahead of candidate1;
- candidate1→candidate2 changes only the manifest;
- diff is 4 additions / 3 deletions.

Candidate1 remains immutable failed review evidence.

## 5. Next action

Commission a fresh whole-manifest pre-code review of exact candidate2.

The reviewer must:

- independently verify both repairs;
- re-audit whole-candidate completeness rather than rubber-stamp the two-line repair;
- remain independent of candidate authorship;
- preferably not be the candidate1 reviewer.

Freeze is permitted only on:

**PASS — MAY FREEZE UNCHANGED**

Otherwise preserve candidate2 and reconcile the new defect set.
