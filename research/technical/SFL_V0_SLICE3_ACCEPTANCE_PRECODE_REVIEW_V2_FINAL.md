# Slice 3 Acceptance Authority Candidate 2 — Fresh Pre-Code Review

**Review artifact:** SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_V2_FINAL  
**Date:** 2026-09-23  
**Reviewer workspace:** review/sfl-v0-slice3-acceptance-precode-v2-final-return  
**Review target:** SFL-V0-S3-ACCEPTANCE-v1-candidate2  
**Candidate path:** plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md  
**Exact candidate commit:** cb1bf676b2265d3522fe855095b8e2275656508d  
**Exact candidate blob:** 294e10a28b6b116b6f2549dd7325b4e07ccf43d3  
**Canonical authority base:** main@221e579ba8805ff6de23a73f73b2e4d2431011a8

# Verdict

**BLOCK**

Candidate 2 is substantially aligned with accepted Slice-3 semantics and its census and inherited-regression expansion are mechanically correct, but it is not yet omission-detectable for two accepted controlled-lineage negative controls. A conforming-looking implementation could violate either accepted lineage rule while satisfying every current REQUIRED Slice-3 row.

Because both repairs change operative applicability/verification wording, the frozen candidate may not be frozen unchanged.

No candidate file, SPEC, ADR, or frozen prior manifest was edited by this review.

# 1. Independently derived Slice-3 boundary

The accepted Slice-3 boundary is the Household substrate, not Household office/action execution.

Slice 3 must make executable and completion-visible:

- one bounded inert CandidateOrganization referent per formation witness and actor-held CandidateRecognition as a real founder gate;
- ordinary Household formation from lower-level residence, connected durable ties, qualifying support on distinct cycles, and founder-specific evidence;
- FormationWarrant provenance, persistent Household numerical identity, founding SustainingParticipant provenance, and founder Household Recognition;
- bilateral post-formation participation through both RequestHouseholdParticipation(H) and InviteHouseholdParticipation(P), explicit ParticipationWarrant and ParticipationEndWarrant, and non-erasure of unrelated person-level state;
- continuity through explicit bridge/history transmission rather than endpoint similarity, complete founder turnover, Inactive/reactivation, same-cycle handoff, stable-closure Dissolved, no resurrection, and continuity-over-duplicate-formation precedence;
- Household existence/continuity Recognition as actor-specific, provenance-bearing subjective state over the already-frozen Slice-2 information substrate, including communication acquisition, stale-state behavior, accepted precedence, Contested, and the participation gate;
- controlled v0 division/consolidation lineage as historical provenance only, with explicit predecessor participation-end sources, freshness, predecessor lifecycle gates, ambiguity withholding, zero-or-one warrant, direct DerivedFrom versus transitive AncestorOf, persistence, rebuildability, and no inherited causal state;
- HouseholdProvisionCommitment state and derived mobilizable capacity as a grounded substrate, without pooled grain or Household spending;
- stable reaction closure, idempotence, nonsemantic-order protections, independent oracles, fixture auditing, derived-state nonauthority, trace/configuration truth, and exact prior-slice regression visibility.

Slice 3 must not pull forward:

- HouseholdHeadRole appointment/succession or head Recognition;
- HouseholdDecisionContext or separate household initiative;
- endogenous head-scoped provision solicitation/reconsideration;
- Household support, dowry spending, contributor debit execution, or provision priority;
- mediated-marriage authority topology;
- head/authority-destroying races;
- checkpoint/restore continuation;
- general CandidateOrganization multi-label convergence;
- general fission/merger/reconsolidation or repeated predecessor rejoin/re-exit source selection;
- generic nonparticipant perception;
- generated-history infrastructure as a completion gate;
- rendered causal-explanation UI/surface.

This boundary follows SPEC-SFL-0001 §§6–9, accepted ADRs, the frozen Slice-1/Slice-2 completion authorities, and the canonical Stage-3 verification families/contracts.

# 2. Candidate census

Mechanical parse of the exact candidate produced:

| Status | Count |
|---|---:|
| REQUIRED | 94 |
| DEFERRED | 11 |
| UNEXERCISED | 2 |
| **Unique AcceptanceIds** | **107** |

No duplicate AcceptanceId was found.

The candidate self-census of 107 = 94 / 11 / 2 is correct.

# 3. Exact inherited REQUIRED expansion audit

The frozen manifests were read from their immutable refs, not inferred from aggregate suite status.

| Frozen authority | Frozen blob | REQUIRED in frozen manifest | Candidate G.1 expansion | Missing | Extra |
|---|---|---:|---:|---:|---:|
| SFL-V0-S1-ACCEPTANCE-v1 | efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766 | 128 | 128 | 0 | 0 |
| SFL-V0-S2-ACCEPTANCE-v1 | e4872531cf780d51fa1863f2a0b87e2424a71b69 | 46 | 46 | 0 | 0 |

The set comparison found no missing, extra, duplicate, or reclassified REQUIRED member in the candidate's exact inherited expansion.

For Slice 2, S2-045-PINNED-POLICY-NONCLAIM is correctly counted as REQUIRED even though its frozen status cell is written as "REQUIRED structural/report".

This dimension passes.

# 4. Findings

| ID | Finding | Accepted source anchor | Candidate anchor | Consequence | Smallest faithful repair |
|---|---|---|---|---|---|
| F-01 | **Division predecessor lifecycle rejection is not omission-detectable.** Candidate S3-050 positively constructs division only while H remains non-Dissolved, but there is no REQUIRED negative companion proving that a predecessor which becomes Dissolved before H2 forms cannot receive DivisionDescendant classification. | SPEC-SFL-0001 §7.7.4: predecessor H must remain non-Dissolved when descendant H2 forms. Canonical LINEAGE_FAMILY.md, VS-SFL-022 A "Predecessor dissolves": H2 may form, but no controlled DivisionDescendant warrant from H may issue. | S3-050-DIVISION-DESCENDANT; S3-051 tests freshness only; S3-052 tests continuing-branch identity/proxies only. S3-054 is the opposite lifecycle ablation for consolidation, not division. | An implementation can ignore the non-Dissolved division gate, classify a new H2 as DivisionDescendant of an already-Dissolved H, and still pass the current positive division witness plus every listed division ablation. S3-037 does not close this: the defect gives H2 a new identity and erroneous lineage rather than resurrecting H. | Strengthen an existing division row or add one REQUIRED companion: hold ordinary H2 formation valid, make H Dissolved before H2 forms, and require no DivisionDescendant LineageWarrant while H2 remains validly formed. |
| F-02 | **Irrelevant predecessor-history exclusion is absent.** The canonical consolidation family requires a founder's unrelated H4 history, when it does not satisfy the controlled founder-lineage-source conditions, not to contaminate the predecessor set. Candidate 2 has no such negative witness. | SPEC-SFL-0001 §7.7.2 limits lineage provenance to explicit ended predecessor participation used by the classifier and treats other/overlapping histories as non-exclusive unless they create actual ambiguity. Canonical LINEAGE_FAMILY.md, VS-SFL-024 C "Unrelated H4 history": H4 must not enter the predecessor set. CROSS_CUTTING_VERIFICATION_CONTRACT.md relation 3 also requires locality against unrelated actors/households where applicable. | S3-053 fixes the positive set {H1,H2}; S3-056 covers genuinely ambiguous/equally valid predecessor interpretations; S3-057 requires source provenance; S3-087 scopes disconnected-population locality only to formation/continuity/lifecycle and therefore does not supply a lineage control. | A classifier can over-collect an irrelevant ended household from a founder's history and emit an enlarged/contaminated predecessor set in a history containing H4, while passing the current H1/H2 positive fixture, ambiguity control, provenance field checks, and predecessor-order metamorphic. | Strengthen S3-057 or add a REQUIRED lineage control matching VS-SFL-024 C: add unrelated H4 founder history that does not satisfy the current controlled predecessor-source conditions and require H4 to be absent from the warrant's direct predecessor set. |

These are verification/completion-authority defects, not missing Director-level social semantics. The accepted sources already determine the expected results.

# 5. Explicit determinations

## 5.1 Controlled provision fixture authority

**Permitted as bounded verification setup. No finding.**

SPEC-SFL-0001 §1.1 permits declared bounded fixture inputs while prohibiting direct fixture-writing of endogenous results the scenario is meant to prove. The Cross-Cutting Verification Contract's inherited-card metadata explicitly permits a family/card to declare an additional fixture write beyond the generally allowed set, and its fixture audit bans fixture-written outcomes under test rather than every non-lower-level prerequisite.

Candidate §3.1 stays within that boundary:

- acquisition is expressly not claimed;
- the commitment is marked controlled/pre-existing with fixture provenance;
- derived capacity is not fixture-written;
- no head/office state is injected;
- no grain moves;
- the commitment is excluded from formation/continuity evidence;
- participation-end and dissolution termination remain endogenous assertions.

This does not create a headless acquisition semantic. It creates only a controlled pre-state for testing commitment state/capacity. The accepted SPEC also permits a headless current state with an already-existing commitment because vacancy preserves provision commitments while suspending household-mode action.

S3-071 and S3-072 correctly freeze the 1/2/3 reserve boundary and same-grain NeedsGrain false/true contrast. S3-073 through S3-077 preserve non-pooling, rebuildability, termination, and the no-spending boundary.

## 5.2 CandidateOrganization one-referent boundary

**Acceptable bounded instantiation. No finding.**

SPEC requires CandidateRecognition of the same prospective founding organization but does not require Slice 3 to solve general multi-label candidate equivalence. Candidate §2.3 uses exactly one inert candidate referent per bounded formation episode, gives it no causal authority/self-evidence, and requires escalation before any two-referent reconciliation is admitted.

This preserves LATER-01 rather than silently resolving it.

## 5.3 Household Recognition closure

**Acceptable. No finding.**

Candidate 2 closes the Household proposition over the accepted Slice-2 information model without inventing a new epistemic theory:

- founders directly recognize H from formation;
- outsiders do not passively synchronize;
- communication from a sender who actually holds the proposition can move Unknown to Recognized with provenance;
- newer valid same-H continuation evidence can refresh positive provenance;
- decisive dissolution evidence can invalidate safe reliance on an older positive basis under the existing precedence/Contested rules;
- incomparable evidence produces Contested;
- Contested does not safely satisfy the participation Recognition gate;
- IDs, arrival order, engine-side H state, and diagnostic state do not choose a winner;
- no negative Recognition enum or generic observation entitlement is invented.

The inherited frozen Slice-2 precedence, communication, non-omniscience, locality, and ID-renaming rows remain exact regressions.

## 5.4 Controlled lineage scope

**BLOCKED only by F-01 and F-02 above.**

The candidate otherwise correctly preserves:

- successor ordinary formation independent of lineage;
- explicit ParticipationEndWarrant founder sources;
- division/consolidation freshness;
- consolidation predecessor lifecycle rejection;
- ambiguity withholding rather than ID/order selection;
- zero-or-one warrant;
- direct versus transitive lineage distinction;
- rebuildable DerivedFrom/AncestorOf;
- persistence after dissolution;
- no transfer of identity/resources/claims/roles/Recognition/pending causal state;
- predecessor enumeration order invariance;
- repeated predecessor rejoin/re-exit source selection as deferred.

The two missing canonical negative controls are material because omission-detectability, not merely prose statement of a positive precondition, is the purpose of this authority.

## 5.5 S1-084 adaptation

**Candidate treatment is acceptable in principle. No finding.**

Frozen S1-084 requires derived-state rebuild equivalence / stale-cache nonauthority and expressly permits either a rebuild challenge when behavior-affecting derived caches exist or structural evidence when they do not.

At the canonical base, the current S1-084 executable evidence is an exact private-field inventory in tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs ("NoDerivedAuthorityStructuralAudit"): it enumerates WorldState private fields and requires exact equality with the Slice-1 inventory.

Slice 3 necessarily adds new authoritative Household/warrant state, so that exact implementation-local inventory can require a lossless adaptation without changing the frozen semantic invariant. Candidate S3-093 handles this correctly: it preserves the no-hidden-derived-authority invariant, requires any exact-structure adaptation to be separately reviewed before coding, and forbids the coder from deleting or loosening the regression for convenience.

The frozen S1-084 AcceptanceId/status remains unchanged and must still be reported green under S3-R11.

# 6. Required adversarial attempts

| # | Attempt | Outcome |
|---:|---|---|
| 1 | Find a REQUIRED obligation supported only by research/review prose. | **Resisted.** No REQUIRED row was accepted on research/reconciliation authority; the two blockers are instead missing controls already fixed by SPEC/canonical verification design. |
| 2 | Find an accepted Slice-3 obligation absent from the candidate. | **Falsified candidate.** F-01 and F-02 are accepted canonical lineage controls absent from omission-detectable REQUIRED coverage. |
| 3 | Find a broad claim whose evidence domain is narrower than its wording. | **Falsified candidate.** S3-050 states the non-Dissolved division condition only inside the positive witness; without its canonical negative companion, evidence can be narrower than the lifecycle claim. |
| 4 | Make formation pass without the integrated three-founder architectural witness. | **Resisted.** S3-001 explicitly preserves VS-SFL-001 (or reviewer-approved semantically equivalent three-founder evidence) and rejects two-founder smoke as a substitute. |
| 5 | Omit one participation direction. | **Resisted.** S3-020 explicitly requires independent execution of both RequestHouseholdParticipation(H) and InviteHouseholdParticipation(P). |
| 6 | Omit one accepted qualifying support kind. | **Resisted.** S3-015 closes accepted gift/help, loan provision, and favour fulfilment and excludes Household-originated support. |
| 7 | Let Household Recognition remain boolean/global or ignore Contested. | **Resisted.** S3-040 through S3-049 require actor-specific provenance, no passive sync/global winner, H-specific Contested, and the Contested participation-gate failure. |
| 8 | Fake continuity by endpoint similarity. | **Resisted.** S3-030 through S3-032 and S3-038 require explicit warrant/bridge history and include broken-bridge/similar-endpoint control. |
| 9 | Let lineage inherit causal state or choose true ambiguity by ID/order. | **Resisted for those faults.** S3-056, S3-060, S3-063, S3-086, and S3-090 close them. Separate lineage faults remain under F-01/F-02. |
| 10 | Pass provision with reserve off-by-one or NeedsGrain defect. | **Resisted.** S3-071 binds 1/2/3 -> 0/0/1; S3-072 binds same-grain false/true NeedsGrain. |
| 11 | Smuggle a headless endogenous provision-acquisition semantic through fixture setup. | **Resisted.** §3.1 explicitly declares a pre-existing valid controlled fixture, claims no acquisition, injects no head/office/grain movement, and gives the coder no acquisition discretion. |
| 12 | Drop a prior REQUIRED AcceptanceId from exact regression expansion. | **Resisted.** Mechanical set equality: S1 128/128 and S2 46/46, no missing/extra IDs. |
| 13 | Pull Slice-4 or Slice-5 behavior forward. | **Resisted.** Head/office, household initiative, provision acquisition/reconsideration, spending/dowry/debit execution, mediated-marriage authority, authority races, and checkpoint/restore remain explicitly outside/deferred. |
| 14 | Dissolve the claimed division predecessor before successor formation while preserving ordinary successor formation. | **Falsified candidate.** No REQUIRED negative row detects erroneous DivisionDescendant classification; F-01. |
| 15 | Give a consolidation founder unrelated H4 history that is not a valid current predecessor source. | **Falsified candidate.** No REQUIRED row forces H4 exclusion from the predecessor set; F-02. |

# 7. Source set and methods

Authoritative/canonical material read before verdict:

- AGENTS.md
- 00_START_HERE.md
- founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md
- governance/MASTER_ARCHITECT_GUIDE.md
- governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md
- decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md
- specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md
- architecture/accepted/ADR-0001 through ADR-0005
- plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md and SLICE1_ACCEPTANCE_FREEZE_RECORD.md
- plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md and SLICE2_ACCEPTANCE_FREEZE_RECORD.md
- FORMATION_FAMILY.md
- CONTINUITY_TURNOVER_FAMILY.md
- LINEAGE_FAMILY.md
- RECOGNITION_INFORMATION_FAMILY.md
- PROVISION_GROUNDING_FAMILY.md
- NO_SELF_CONFIRMATION_FAMILY.md
- RESOLUTION_REACTION_FAMILY.md
- DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md
- CROSS_CUTTING_VERIFICATION_CONTRACT.md
- exact candidate at commit/blob above

Additional implementation evidence read only for the concrete S1-084 adaptation question:

- tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs at canonical base, specifically the NoDerivedAuthorityStructuralAudit private-field inventory.

Methods:

- GitHub repository/branch/file retrieval through the connected GitHub integration;
- exact blob verification for candidate and frozen manifests;
- mechanical AcceptanceId/status parsing and set comparison in the tool runtime;
- source-to-candidate semantic mapping and adversarial omission analysis;
- isolated review branch created directly from the frozen candidate commit.

No runtime implementation tests were needed for this pre-code authority review because the object under review is the frozen acceptance artifact, not IMP-0003 code.

# 8. Provenance, independence, and contamination disclosure

This review used a fresh review workspace created from the exact candidate commit and did not edit the candidate.

Before fixing the initial finding set, I did **not** read:

- either candidate-1 review report;
- either prior review branch artifact;
- the Master Architect review reconciliation;
- the prohibited Slice-3 discovery/research returns listed by the commission;
- prior PR prose summarizing defects/repairs.

The commission itself disclosed that candidate 1 had previously been BLOCKed; that fact was known from the task packet but no prior defect list was used.

The initial independent finding set was fixed as F-01 and F-02 above. **Only after that** I consulted research/technical/SFL_V0_SLICE3_ACCEPTANCE_REVIEW_RECONCILIATION.md on planning/sfl-v0-slice3-acceptance-v2-reconciled, solely to determine whether either lineage discrepancy had been deliberately bounded. The reconciliation did not identify either exception and explicitly described controlled-lineage semantics as unchanged. It was not used as semantic authority.

No candidate-1 review artifact was authored or consulted in this review context. GitHub account/commit identity is not treated as evidence of model-context authorship; the substantive independence control is the source restriction above. In any case this return does not award PASS.

# 9. Return

**BLOCK**

The exact candidate at commit cb1bf676b2265d3522fe855095b8e2275656508d / blob 294e10a28b6b116b6f2549dd7325b4e07ccf43d3 must not freeze unchanged.

Required operative repairs are limited to the two lineage controls in F-01 and F-02. The review branch does not repair candidate 2. Any repaired candidate requires a new exact commit/blob and fresh review before freeze/promotion.
