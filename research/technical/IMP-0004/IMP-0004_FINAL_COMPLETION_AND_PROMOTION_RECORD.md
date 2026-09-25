# IMP-0004 — Final Completion and Promotion Record

**Status:** VERIFIED COMPLETE / PROMOTED  
**Date:** 2026-09-25  
**Task:** `tasks/implementation/IMP-0004_SFL_V0_SLICE4_HOUSEHOLD_HEAD_AND_COLLECTIVE_ACTION.md`  
**Frozen acceptance authority:** `SFL-V0-S4-ACCEPTANCE-v2`  
**Frozen implementation candidate:** `imp-0004-slice4-conformance-candidate-v1`  
**Exact reviewed candidate SHA:** `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`  
**Independent conformance:** `research/technical/IMP-0004/IMP-0004_INDEPENDENT_CONFORMANCE_REVIEW_V1.md` — **PASS — PROMOTE**  
**Implementation PR:** #109  
**Canonical promotion merge:** `c72ae67dc76ac091331fcd5494c6657eec57f703`  
**Post-promotion CI:** run `36098636634` — **PASS**

## 1. Completion judgment

IMP-0004 / SFL v0 Slice 4 is **VERIFIED COMPLETE**.

The exact candidate reviewed by the fresh independent conformance reviewer was promoted without implementation/test drift. The reviewer found no blocking implementation/verification defect and no semantic escalation.

Post-promotion canonical verification then passed on the actual `main` merge commit.

Slice 4 therefore establishes the accepted bounded Household representative/collective-action layer on top of verified Slices 1–3.

## 2. Verified Slice-4 capability

The promoted slice includes, within the accepted bounded v0 model:

- one persistent Household head-role identity distinct from H and its occupant;
- vacancy, appointment and succession;
- snapshot-bound unanimity cohort semantics;
- self-nomination with all aliased capacities preserved;
- inert role filling while H is Inactive;
- actor-held head-role Recognition with stale/corrected/Contested behavior;
- one separate Household initiative through a valid current head while that person retains one ordinary personal initiative;
- endogenous provision solicitation, refusal, reconsideration and persistent commitments;
- current-head self-commitment through explicit dual-capacity private-resource authorization without fake self-response;
- one-grain Household support;
- mediated-marriage dowry;
- fixed-rank multi-contributor funding;
- transaction-specific current-head private contribution X under DEC-0011;
- current-head-as-support-recipient semantics;
- bounded Household provision priority over RepayDebt under DEC-0013;
- accepted authority-use-before-destruction ordering under DEC-0010;
- DEC-0014 historical material-need context for provision reconsideration;
- deterministic dependency/resolution/replay integration;
- typed provenance and independent corruption/oracle evidence.

This remains the synthetic SFL-v0 laboratory layer, not a mature Household economy, generic institution system, or historical-economic claim.

## 3. Frozen completion authority

Slice-4 completion authority remained unchanged:

- manifest: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`
- version: `SFL-V0-S4-ACCEPTANCE-v2`
- immutable ref: `sfl-v0-slice4-acceptance-v2`
- manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`
- census:
  - **165 REQUIRED**
  - **9 DEFERRED**
  - **2 UNEXERCISED**

The fresh review independently audited the frozen classification and accepted the exact candidate against it.

No frozen manifest was edited or reclassified to make implementation pass.

## 4. Inherited regression authority

The promoted candidate preserved the exact inherited REQUIRED chain:

- Slice 1: **128 / 128**
- Slice 2: **46 / 46**
- Slice 3: **96 / 96**

Total inherited REQUIRED: **270 / 270**.

## 5. Inherited-verification adaptations

The four approved adaptation mappings A–D all fired and were independently accepted as narrow/lossless:

1. formation headlessness;
2. exact structural authority / hidden-state enforcement;
3. bounded Household material-event verification;
4. closed commitment provenance.

Approved adaptation authority remained:

- ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`
- plan commit: `68fddec788b5cf41db5934c8719a6fd1ce474d32`
- plan blob: `00c3e64a128fa00e91b99117e321a0e379dd61c5`.

No fifth inherited witness weakening was introduced.

## 6. DEC-0014 escalation lineage

During implementation, escalation 01 correctly identified an under-specified meaning of `new Household material need` in the provision-reconsideration cooldown.

Accepted closure:

`decisions/DEC-0014_HISTORICAL_MATERIAL_NEED_RECONSIDERATION_CONTEXT.md`

The accepted v0 interpretation:

- the three-cycle rule is a deliberately crude anti-repeated-solicitation proxy;
- qualifying material-need context is historical since the latest refusal;
- an otherwise-valid unfunded dowry need can count;
- the need need not remain active through the later re-ask;
- a later refusal resets the baseline;
- no generic pending-demand/adoption subsystem is created.

Acceptance v2 remained sufficient and SID was revalidated with no frontier change.

## 7. Candidate / conformance identity

Candidate-v1:

- immutable ref: `imp-0004-slice4-conformance-candidate-v1`
- exact SHA: `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`
- exact-head CI: run `36094176584` — **PASS**
- evidence artifact: `10846019591`
- candidate artifact digest: `sha256:22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6`

Fresh independent review return:

- report: `IMP-0004_INDEPENDENT_CONFORMANCE_REVIEW_V1.md`
- review return commit: `490d4a3be1895f9a3ba2a436718a1e3c41388828`
- report blob: `42e314f11290de2bb0cb317c8a27a2c9cb21766c`
- verdict: **PASS — PROMOTE**
- recommendation: **PROMOTE exact candidate**

The return branch was exactly one commit ahead of candidate-v1 and added only the review report.

## 8. Independent review findings

The reviewer independently found:

- **165 / 165** Slice-4 REQUIRED conformant;
- **9 / 9** DEFERRED preserved;
- **2 / 2** UNEXERCISED preserved;
- **270 / 270** inherited REQUIRED preserved;
- all four inherited adaptations conformant;
- no role/holder identity collapse;
- actor-held head Recognition remains subjective/provenance-bearing;
- dual-mode initiative accounting is preserved;
- provision/self-commitment/reconsideration semantics conform;
- DEC-0011 private-X semantics conform;
- funding/dependency logic retains one authoritative funding seam;
- DEC-0010/0013 ordering and alias cases conform;
- fixture and oracle boundaries are sufficiently independent;
- no scope leakage into Slice 5 or mature economy/institution systems;
- no semantic escalation required.

Reviewer-owned external artifact probes reported **30 probe categories / 4,950 primitive assertions / zero failures**.

## 9. Promotion identity / no-drift check

Before promotion:

- candidate ref still resolved to `bac53de...`;
- PR #109 head still resolved to `bac53de...`;
- implementation branch and frozen candidate were identical;
- exact-head CI remained PASS.

PR #109 was then promoted with reviewed candidate SHA as its second merge parent.

Canonical promotion merge:

`c72ae67dc76ac091331fcd5494c6657eec57f703`

No implementation repair or test change was introduced between independent review and promotion.

## 10. Post-promotion canonical CI

GitHub Actions canonical push run:

- run: `36098636634`
- run number: `281`
- head branch: `main`
- exact head SHA: `c72ae67dc76ac091331fcd5494c6657eec57f703`
- conclusion: **success**

Canonical steps all passed:

- checkout exact promotion merge;
- .NET setup;
- restore;
- static quality / format verification;
- Release build;
- Release test;
- acceptance evidence generation/upload.

Test summary:

- **67 total**
- **67 succeeded**
- **0 failed**
- **0 skipped**

Post-promotion evidence artifact:

- artifact ID: `10848053474`
- name: `sfl-slice1-slice2-slice3-slice4-acceptance-evidence`
- size: `1,909,521 bytes`
- digest: `sha256:1345991365761c53d34e1e26a0bedd52ef74e95414cd9eaa43c8f7634559ef3e`
- exact artifact head SHA: `c72ae67dc76ac091331fcd5494c6657eec57f703`

## 11. Final state

Slices 1–4 of the SFL-v0 reference implementation are now **VERIFIED COMPLETE**.

The accepted later-slice boundary remains intact.

Still outside Slice 4 include, among other things:

- Slice-5 checkpoint/save-load exact continuation;
- richer delayed processes;
- mature/general Household economy or property system;
- general institutional sovereignty/administration;
- general contested succession/rival claimants;
- general nonparticipant perception;
- trust/rumor/reputation;
- strategic/stochastic policy redesign.

Any Slice-5 work requires its own preimplementation authority/discovery/acceptance path. Slice-4 completion does not authorize silent descent into Slice 5.
