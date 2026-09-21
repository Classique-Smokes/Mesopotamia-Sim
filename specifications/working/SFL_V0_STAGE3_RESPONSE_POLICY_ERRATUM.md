# SFL v0 — Response Decision Policy Erratum

**Status:** RESOLVED / HISTORICAL WORKING RECORD  
**Date:** 2026-09-21  
**Authority:** Working semantic erratum only.

## Gap

Accepted semantics require:

- interpersonal/collective actions are proposals;
- counterparties retain their own acceptance/refusal;
- responses do not consume the target's one personal initiative;
- cycle phase 6 collects proposal responses;
- actors may accept multiple incoming proposals, with central resolution committing only a compatible subset.

But no accepted artifact defines **how the deterministic reference actor chooses a feasible response**.

Mechanism-isolation cards may script a response through the public boundary, but Stage 4's autonomous reference simulation cannot leave all target responses to the fixture.

## Recommended v0 rule

Introduce a deterministic `ResponseDecisionContext(target, proposal)` for each incoming proposal that requires a target choice.

### Snapshot / visibility

A response context reads:

- the same committed cycle snapshot used for personal/household deliberation;
- the incoming proposal's explicit terms;
- the target's subjective state from that snapshot.

It does **not** see uncommitted effects of other proposals/responses.

### Feasibility first

If the requested response is not feasible from current target/world state, the interaction produces `Unable(reason)`; inability is not a scored voluntary refusal.

If feasible, generate the proposal-type's valid response meanings, e.g.:

- Accept / Decline;
- FulfilCalledFavor / RefuseCalledFavor;
- AcceptResidenceChange / DeclineResidenceChange;
- AcceptProvisionCommitment / DeclineProvisionCommitment;
- nominee/appointment acceptance where applicable.

### Selection

Feasible response candidates use the same accepted reference scoring infrastructure:

- named exact-integer components;
- `FinalScore = sum(components)`;
- highest score wins;
- declared domain tie key if one exists, otherwise logged stable-semantic-ID fallback.

Response-specific component coefficients are laboratory configuration.

### Initiative / central resolution

- response contexts do not consume or grant the target's personal initiative;
- multiple response contexts may activate in one cycle;
- an actor may accept multiple incoming proposals;
- central resolution/revalidation still decides which compatible accepted effects actually commit;
- later conflict failure is `InvalidatedAtResolution`, not retroactive refusal.

### Observability

For each response decision, diagnostic history records:

- proposal ID/terms;
- response candidates/gates;
- named components/final scores;
- selected response;
- relevant target subjective inputs;
- response profile/configuration version.

## Why this is recommended

It extends the already-approved deterministic component scorer without creating a second cognitive architecture, preserves counterparty agency, keeps inability distinct from refusal, and prevents response order from becoming hidden semantics.

## After approval

Stage 3 must pin a small set of response scoring profiles sufficient for closed-loop acceptance tests. Numeric response preferences remain laboratory configuration, not historical psychology.


## Resolution

Approved by the Project Director on 2026-09-21.

Promoted semantics:

- deterministic `ResponseDecisionContext(target, proposal)`;
- common committed snapshot + proposal terms + target subjective state;
- feasibility before voluntary response scoring;
- infeasible interaction -> `Unable(reason)`;
- feasible responses use the accepted named exact-integer component-sum scorer;
- responses consume no personal initiative;
- multiple responses may be selected in one cycle;
- central resolution remains authoritative and may later invalidate an accepted effect;
- full response decision trace is retained.

Canonical authority: `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §5.1.
Canonical verification/configuration: `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md` and `REFERENCE_SCORING_PROFILES.md`.
