# IMP-0003 — Future Lessons Index

**Status:** MAINTENANCE SYNTHESIS / NON-AUTHORITATIVE  
**Scope:** Future-facing lessons from Slice-3 implementation, four independent conformance cycles, promotion, and RUN-0003 observation  
**Purpose:** Compress the reusable implementation/assurance lessons so later slices do not require reconstruction from repair history and raw observation packages.  
**Does not:** reopen Slice 3, alter frozen semantics, create new requirements, or promote conceptual generalizations.

## Source record

Derived from:

- `research/technical/IMP-0003/IMP-0003_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`;
- `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_FRESH.md`;
- `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`;
- `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`;
- `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V4.md`;
- `research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/OBSERVATION_SUMMARY.md`;
- `research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md`.

Higher accepted authority and the detailed source records control if this index is ever inconsistent.

## 1. Independent verification must test assertion adequacy, not only oracle dependency independence

Candidate-v1 showed that an oracle can avoid calling production classifiers and still be too weak to certify the claim.

Detached corrupt witnesses exposed missing checks for:

- participation Recognition;
- acceptance identity;
- support identity/endpoints;
- later formation/continuation/lineage evidence references;
- lifecycle publication references;
- exact retained EvidenceIds.

**Future implication:** independent oracle review must ask both:
- “does the checker depend on production answers?” and
- “would materially false public evidence still pass?”

## 2. Provenance-bearing institutional state must be checked down to exact references

Warrant shape alone was insufficient.

Formation, participation, continuation, lineage, lifecycle, and Recognition evidence needed exact binding to:

- real events;
- actual actors;
- semantic order;
- correct support kind/endpoints;
- rule/configuration identity;
- exact held evidence identity.

**Future implication:** Slice-4 role and succession warrants should be independently reconstructable from exact event/evidence references rather than merely satisfying plausible field predicates.

## 3. Technical identities must not leak into social commutativity

Candidate-v2/v3 revealed that detached counterfactual replay could report false `TechnicalFallback` because semantically equivalent execution orders allocated different relation/event/evidence IDs.

The durable repair normalized new technical identities through semantic causal origins while preserving meaningful differences.

**Future implication:** any later role/household counterfactual resolver must distinguish:
- identity that is semantically authoritative;
- identity that is merely an allocation artifact.

Never use raw allocated IDs as evidence that two compatible histories are socially different.

## 4. Current institutional status is not information entitlement

Candidate-v1 and RUN-0003 both reinforced this.

A current sustaining participant did not automatically receive every continuation update. Terminal dissolution evidence belonged to the actor directly participating in the terminal exit. Other actors needed accepted evidence routes.

**Future implication:** membership, role occupancy, authority, and Recognition must remain separate. Slice-4 must not infer “knows current head” from “is current participant” or “is head.”

## 5. Stable Household identity is a good office anchor

Slice 3 made identity persistence mechanically legible through explicit warrants rather than endpoint similarity.

RUN-0003 found the same H easy to explain through turnover, Inactive state, and dissolution.

**Future implication:** a persistent `HouseholdHeadRole(H)` can attach to stable H without redefining H identity. Role identity, holder identity, Household identity, and lineage should remain distinct.

## 6. Prospective actors can create dependencies before acquiring institutional status

The residence/admission defect and observation showed that a newcomer can participate in an institutionally consequential same-cycle dependency before becoming a current participant.

**Future implication:** role appointment/succession dependency grouping must include prospective nominees/holders and actors whose state affects eligibility, not only current role holders or participants.

## 7. Rule/configuration provenance should describe the rule actually exercised

Candidate-v1 used scenario configuration-label spelling as a proxy for active semantic rule identity.

The repair separated scenario configuration from rule attribution.

**Future implication:** Slice-4 traces must report actual head/household rule context independently of arbitrary scenario labels. Mixed personal and representative actions in one run may truthfully carry different rule contexts.

## 8. Resource backing is not institutional authority

Provision capacity remained derived from explicit personal commitments and live personal state. No treasury emerged.

RUN-0003 showed capacity changing through a personal gift and participation exit without any collective spend.

**Future implication:** an occupied head role should authorize only accepted scoped actions. It must not convert Household backing into ownership, general spending power, or personal command.

## 9. Recognition status alone is too coarse for causal explanation

A final `Recognized` value could represent old stale evidence or a newly corrected basis.

RUN-0003 required evidence identity/origin/hops to explain the difference.

**Future implication:** head/succession verification and observation should retain provenance/freshness surfaces, especially for stale predecessor Recognition and correction.

## 10. Whole-candidate review after every bounded repair was necessary

Each candidate repaired the previous review's defects correctly, but the next whole-candidate review discovered a deeper gap elsewhere.

The sequence was:

- v1: participation oracle / rule provenance / continuation broadcast;
- v2: broader warrant oracle / disconnected fallback;
- v3: connected fallback / lifecycle + EvidenceId verification;
- v4: PASS.

**Future implication:** consequential repairs should not receive repair-only signoff. Freeze a new exact candidate and rerun a whole-candidate conformance review when the repaired subsystem interacts broadly with verification or resolution machinery.

## 11. Autonomous policy remains a weak exploration mechanism

RUN-0003 Mode A selected `Farm` for all 72 personal initiatives; no support, communication, CandidateRecognition, or Household formation occurred.

This is a reference-policy limitation, not a Household defect.

**Future implication:** Slice-4 correctness cannot depend on autonomous office/succession activation. Use accepted public-path activation and adversarial acceptance to exercise representative-role semantics. Richer agency remains later model work.

## 12. Long observation narratives can lose the mechanism under study

Ordinary consumption exhausted grain in the long Slice-3 narrative and made later planned steps infeasible.

**Future implication:** keep role/succession observations short or explicitly budget material maintenance. Always distinguish “authority route unavailable” from “lower-level prerequisite disappeared.”

## 13. Human-facing fallback terminology needs care

RUN-0003 exposed two different `TechnicalFallback` meanings on different trace surfaces:

- deterministic personal scorer tie fallback;
- central-resolution technical symmetry fallback.

Machine evidence remained unambiguous, but compact human summaries can conflate them.

**Future implication:** Slice-4 explanatory output should label fallback domain explicitly.

## 14. Slice-4 retrieval triggers

Retrieve this index when work touches:

- head-role state/occupancy;
- nomination/appointment/succession;
- head Recognition;
- personal versus Household initiative;
- authority-dependent revalidation;
- role vacancy;
- provision solicitation/spending;
- mediated marriage authority;
- same-cycle role/precondition races;
- institutional counterfactual dependency/fallback analysis.

## 15. What remains unresolved by Slice 3

Slice 3 did not decide:

- general CandidateOrganization convergence;
- general institutional identity beyond Household;
- head appointment/succession mechanics beyond already accepted Slice-4 authority;
- multiple simultaneous authority claimants;
- rich legitimacy/trust/reputation;
- general observation/perception;
- richer autonomous social motivation;
- checkpoint continuation.

These remain governed by their later slice/authority processes.
