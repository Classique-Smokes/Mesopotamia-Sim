# TRES-0010 — Semantic Promotion Lossless Audit

**Status:** COMPLETE / SUPPORTING PROMOTION RECORD  
**Date:** 2026-09-21  
**Scope:** Director-approved B2 semantics D1–D5 only.

## 1. Canonical artifacts after promotion

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
  - content SHA: `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`
- `registers/ASSUMPTIONS_REGISTER.md`
  - content SHA: `e4372789803e2ff200052c450517f3733f64f1e2`
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
  - content SHA: `5ff85234e91d3dbcb3779048e63ade1493105f02`
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
  - content SHA: `6aa88185027bdec2da553b37cfd53c10eeb15153`
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`
  - content SHA: `7d765988330146ddedd5e9849108eaf10831717d`
- `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
  - content SHA: `62aaa33774d9933d333d4a35763b0844e5a60437`
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
  - content SHA: `6781e17ef5dd7b3ce5c7f23df39d46ac59b2dc74`

Promotion inventory source:

- `research/technical/TRES-0010/SEMANTIC_PROMOTION_RECONCILIATION.md`

## 2. Lossless reconciliation result

Automated textual checks against the promoted artifacts: **30 / 30 passed**.

### D1 — same-cycle direct attitude composition

Preserved:

- narrow scope to current fixed direct §3.1 causes;
- post-maintenance/pre-reaction base;
- distinct cause contributes exactly once;
- signed deltas sum before one clamp;
- no contribution-by-contribution clamping;
- maintenance decay excluded from batch;
- cause keys/deltas retained as causal predecessors;
- enumeration order nonsemantic;
- cause-key idempotence applies to membership;
- one authoritative batch transition / ReactionIndex does not create member precedence;
- future causally downstream attitude effects require explicit causal placement.

Mirrored in ASM-0002 and direct verification/permutation checks.

### D2 — same-cycle Residence conflict

Preserved:

- multiple independent Accept responses remain true history;
- at most one committed Residence transition/person/cycle;
- same-person accepted effects form one central conflict set after revalidation;
- accepted semantic/domain priority precedes fallback;
- otherwise use existing disclosed stable-ID fallback;
- fallback is logged;
- losers are `InvalidatedAtResolution(CompetingResidenceTransition)`;
- winner does not authorize a second same-cycle Residence transition;
- no snapshot-origin or personal/proposer/destination preference was invented.

Mirrored in ASM-0007 and Residence/response/determinism/metamorphic checks.

### D3 — response-closed called-favour payloads

Preserved:

- voluntarily initiated CallFavor consumes holder personal initiative;
- Fulfil/Refuse is the last new voluntary actor choice for a valid payload;
- requested execution occurs in response scope;
- no second called-actor personal initiative is consumed/granted;
- no nested ResponseDecisionContext / third-actor new voluntary choice;
- no favour creation/demand/transfer/cancellation payload, marriage/kinship establishment, or household/role authority payload;
- categorically non-callable payload rejected before target response;
- requested action remains subject to ordinary feasibility/revalidation;
- favour consumed only on successful requested-action commit;
- success -> +10 and consume favour;
- voluntary refusal -> Declined, retain favour, -20;
- Unable -> retain favour, no +10/-20;
- InvalidatedAtResolution -> retain favour, no +10/-20;
- invalid payload is outside §6.7 social failed-attempt taxonomy.

No new assumption was created for these normative mechanics.

### D4 — v0 grain-valued parameter domain

Preserved:

- personal grain stock nonnegative integer;
- grain-valued action quantities strictly positive integer;
- zero/negative/non-integral terms categorically invalid before target response;
- invalid terms cause no material/social effect and are not Declined/Unable/Invalidated;
- repayment valid only for 1..remaining debt;
- no over-repayment clamping/credit/meaning conversion;
- valid amount may still be materially infeasible;
- present infeasibility -> Unable;
- post-acceptance capacity loss -> InvalidatedAtResolution under existing rules;
- later dowry inherits positive-integer amount domain without importing dowry authority/funding into Slice 1;
- integral granularity is explicitly v0-only, not historical metrology.

SPEC assumption range updated through ASM-0014; ASM-0014 added with replacement trigger.

### D5 — atomic explicit benefit-for-favour

Preserved:

- ExplicitBenefitForFavor remains distinct from Gift/Help and RelationshipMediatedReciprocalHelp;
- material benefit + new favour is atomic;
- pre-response full pair capacity -> Unable(FavourCapacityFull), no voluntary scoring/material/favour;
- post-acceptance capacity loss -> InvalidatedAtResolution(FavourCapacityFull), no partial commit;
- successful commit creates material effect + exactly one favour atomically;
- no silent downgrade/relabel to Gift/Help;
- no Gift/Help attitude effect inherited merely from shared transfer code;
- RelationshipMediatedReciprocalHelp remains independently meaningful and may commit at full pair capacity without stacking another favour.

## 3. Failure-taxonomy preservation

No fourth social failed-attempt outcome was added.

Categorically invalid terms are represented in accepted semantics as **pre-interaction validation rejection**, outside:

- `Declined`;
- `Unable(reason)`;
- `InvalidatedAtResolution(reason)`.

Diagnostic recording is permitted but does not itself create participant knowledge or social consequence.

This intentionally preserves the existing §6.7 ontology.

## 4. Explicit non-promotions confirmed

The canonical edits did **not** promote:

- recursive/generic response-action graphs;
- permanent named-action CallFavor whitelist;
- secret/hidden acceptance tests;
- general grader or mutation platform;
- generated-history/shrinking infrastructure as Slice-1 completion work;
- generalized multi-party effect framework;
- historical fractional/metrological claims;
- a new attitude effect for ExplicitBenefitForFavor;
- a new Residence social preference priority;
- any new social meaning for stable-ID fallback.

## 5. Verification-authority check

Verification artifacts remain explicitly subordinate to `SPEC-SFL-0001`.

Where pre-B2 verification wording could be read as creating semantics—especially “the underlying benefit may still commit if independently valid”—it was narrowed so:

- atomic behavior for ExplicitBenefitForFavor comes from SPEC;
- independent material continuation at full favour capacity applies to RelationshipMediatedReciprocalHelp.

No verification card is being used as an independent source of social semantics.

## 6. Navigation closure

No new semantic-authority path was added; `SPEC-SFL-0001` and the assumptions/verification package were already reachable from the root navigation path.

Required operational navigation update after this audit:

- mark B2 semantic decision/promotion complete in `plans/CURRENT_PHASE.md`;
- keep IMP-0001 blocked;
- make Slice-1 acceptance manifest materialization the next critical-path step.

## 7. Remaining non-semantic work

This audit does **not** release IMP-0001.

Still required:

1. mechanically enumerate current Slice-1 action shapes against the approved called-favour response-closed predicate;
2. author/freeze/independently review `SLICE1_ACCEPTANCE_MANIFEST.md`;
3. amend IMP-0001 authority taxonomy, applicability, completion evidence, and engineering guards;
4. record later-slice gaps/deferred assurance items durably;
5. run final TRES-0010 closure audit.

## 8. Audit conclusion

**LOSSLESS SEMANTIC PROMOTION: PASS**

All Director-approved D1–D5 commitments are preserved in accepted semantic authority, mirrored only where appropriate into controlled assumptions, and reflected in canonical verification without promoting rejected B2 alternatives or expanding architecture.
