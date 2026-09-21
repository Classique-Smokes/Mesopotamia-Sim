# SFL v0 — Reference Closed-Loop Scoring Profiles

**Status:** CANONICAL STAGE-3 VERIFICATION CONFIGURATION  
**Authority:** Verification/laboratory configuration, not independent social semantics.  
**Semantic contract:** `SPEC-SFL-0001` §5.

## 1. Common scoring contract

All profiles obey the accepted reference scorer:

1. generate contextually relevant/accessibly candidates;
2. apply categorical gates;
3. compute named exact-integer score components for each remaining candidate;
4. `FinalScore = sum(components)`;
5. highest FinalScore wins;
6. use an explicitly specified domain tie key where the domain defines one; otherwise use/log stable-semantic-ID technical fallback;
7. if no candidate remains, initiate nothing.

Profiles below exist to make closed-loop verification deterministic and mechanism-isolating. They are **not** historical calibration and are not a claim that these numerical preferences should survive model iteration.

## 2. Profile format

Each profile defines:

- `ProfileId`;
- decision context: Personal / Household;
- named component rules;
- any scenario-specific target bindings;
- expected tie behavior.

The fixture may bind semantic placeholders such as `TargetBride`, `GiftTarget`, or `NeedRecipient` to actor IDs. It may not inject final scores or bypass production candidate generation/gates.

---

## SCORE-VP-001 — Marriage-route gate isolation

**Used by:** `VS-SFL-030`  
**Context:** Personal

Component rules:

- `MarriageConcern`:
  - +100 for `ProposeMarriage(TargetBride,...)`;
  - 0 for all other generated candidates.
- `OtherConcern`: 0 for all candidates.

Purpose:

- if the mediated marriage route passes subjective/categorical gates, it receives FinalScore 100;
- removing bride->H fact, H recognition, or head recognition removes that candidate rather than merely lowering its score;
- other candidates may remain present at FinalScore 0.

No kinship multiplier is exercised in this profile.

---

## SCORE-VP-002 — Dual-mode personal gift

**Used by:** `VS-SFL-064`, `VS-SFL-065` personal context  
**Context:** Personal

Bindings:

- `GiftTarget`.

Component rules:

- `RelationConcern`:
  - +100 for `OfferGift(self -> GiftTarget, 1)`;
  - 0 otherwise.
- `OtherConcern`: 0.

The target gift wins whenever it remains generated and feasible.

---

## SCORE-VP-003 — Dual-mode household support

**Used by:** `VS-SFL-064`, `VS-SFL-065` household context  
**Context:** Household

Bindings:

- `NeedRecipient`.

Component rules:

- `NeedReliefConcern`:
  - +100 for valid 1-grain household support to `NeedRecipient`;
  - 0 otherwise.
- `MarriageConcern`: 0.
- `ProvisionBackingConcern`: 0.

The support proposal wins the household context whenever it remains valid/generated.

---

## SCORE-VP-004 — Exact kinship attitude amplification

**Used by:** hard-boundary / scorer verification  
**Context:** Personal ordinary interpersonal comparison

For a candidate directed toward person T:

- base `AttitudeComponent` for non-kin = `2 * StoredAttitude(self -> T)`;
- if T is parent/child or sibling, `AttitudeComponent = 3 * StoredAttitude(self -> T)`.

This is exactly the accepted 1.5x amplification of the attitude-derived component while keeping integer arithmetic:

`3*a = 1.5 * (2*a)`.

Other components are 0.

Required assertions:

- stored attitude is unchanged;
- categorical gates still use stored attitude, never the amplified score component;
- no floating-point rounding is required.

---

## SCORE-VP-005 — Technical tie-fallback probe

**Used by:** `VS-SFL-081` where applicable  
**Context:** Personal or Household as declared by the card

Component rules:

- every generated candidate in the deliberately symmetric comparison receives `SymmetryComponent = 0`;
- no domain tie key applies.

Required result:

- exact FinalScore tie reaches the disclosed stable-semantic-ID technical fallback;
- history records fallback use;
- nonsemantic ID permutation may change the winner and must be classified as expected fallback sensitivity.

---

## SCORE-VP-006 — Co-residence motivation ordering

**Used by:** `VS-SFL-099`  
**Context:** Personal

For a valid co-residence proposal candidate toward T:

- `CoResidenceRelationshipConcern = +20` when the motivation is strong mutual positive relation without marriage;
- `CoResidenceMarriageConcern = +40` when the proposer and T have an established marriage;
- other components = 0 for this isolated comparison.

If both conditions exist, use the marriage component for this verification profile rather than stacking both.

Required semantic assertion:

`marriage co-residence incentive > strong-mutual-positive co-residence incentive > 0`.

The magnitudes 20/40 are verification configuration only. This profile affects proposal scoring; it never forces residence change without counterpart acceptance.

---

## Response verification profiles

These profiles exercise the accepted `ResponseDecisionContext`. They are deterministic laboratory configuration, not universal social preferences.

### SCORE-RP-001 — Feasible accept preference

**Context:** ResponseDecisionContext  
**Valid for:** proposal types whose feasible voluntary response set is `Accept | Decline`.

- `ResponsePreference`:
  - Accept = +100;
  - Decline = 0.
- all other components = 0.

Purpose: verify that a feasible response is actually chosen by the production response scorer rather than scripted by the fixture.

---

### SCORE-RP-002 — Feasible decline preference

**Context:** ResponseDecisionContext  
**Valid for:** proposal types whose feasible voluntary response set is `Accept | Decline`.

- `ResponsePreference`:
  - Accept = 0;
  - Decline = +100.
- all other components = 0.

Purpose: produce a genuine voluntary `Declined` outcome through the reference response scorer.

---

### SCORE-RP-003 — Called-favour fulfil preference

**Context:** ResponseDecisionContext  
**Valid for:** feasible called-favour response.

- `ObligationResponse`:
  - FulfilCalledFavor = +100;
  - RefuseCalledFavor = 0.
- all other components = 0.

---

### SCORE-RP-004 — Called-favour refusal preference

**Context:** ResponseDecisionContext  
**Valid for:** feasible called-favour response.

- `ObligationResponse`:
  - FulfilCalledFavor = 0;
  - RefuseCalledFavor = +100.
- all other components = 0.

---

### SCORE-RP-005 — Role-scoped accept preference

**Context:** ResponseDecisionContext with explicit role/household scope  
**Valid for:** a feasible response whose authority derives from a recognized active role, such as head resolution of a mediated-marriage proposal.

- `ScopedAuthorityResponse`:
  - Accept = +100;
  - Decline = 0.
- all other components = 0.

The profile never creates authority; role validity/scope is a categorical gate.

---

## 3. Profile integrity rules

- Configuration cannot waive categorical semantic gates.
- Configuration cannot create an action meaning absent from the spec.
- A profile may change scores only through its declared components.
- Profiles are versioned and included in decision/history/checkpoint configuration state when active.
- The independent oracle may sum the recorded integer components itself; it must not call the production scorer.
- Closed-loop cards must name the exact profile/version they use.
- Response profiles never bypass feasibility; an infeasible proposal yields `Unable(reason)` before response scoring.
- A response profile cannot create a response meaning that is invalid for the proposal type or role scope.
