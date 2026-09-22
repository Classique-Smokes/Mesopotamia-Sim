# IMP-0001 — Independent Conformance BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION — BLOCK ACCEPTED / REPAIR REQUIRED  
**Reviewed candidate:** `imp-0001-slice1-conformance-candidate-v1` @ `7e11dab7697121eb0dbb169ba46210d81b80586e`  
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1` / manifest blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`  
**Consequence:** IMP-0001 remains INCOMPLETE; PR #7 remains draft/unmerged; SCF-002 remains active.

## 1. Review return provenance

The Project Director supplied the completed independent K4 review directly after the reviewer could not push the requested return branch.

The complete reviewer artifact is preserved losslessly at:

`research/technical/IMP-0001/archive/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md.br`

Archive identity:

- original filename: `IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md`
- original bytes: **127,757**
- original lines: **636**
- original SHA-256: `09fb414448000784866c2e8d172ed576d8180ad9d5db9e7d38ed4bb61a3ab91d`
- Brotli bytes: **23,974**
- Brotli SHA-256: `eb7d69df87bc0b77056c3d03090fcd1f1ecbdc3c0eeeb53bcae4aa6e431585a7`
- Git blob: `29530edb80671f3d57aa869ec1cc24afc2fbbaf9`

The report declares itself a fresh independent review and records canonical execution PASS but substantive conformance BLOCK.

## 2. Independent result

The reviewer returned **BLOCK** for candidate-v1 on three findings:

1. **F1 — undisclosed proposal-ID ordering sensitivity**
2. **F2 — missing -5 needy ordinary-request refusal consequence for recipient-request reciprocal help**
3. **F3 — personal agency reads unobserved counterparty grain**

The reviewer independently reproduced all three using public candidate APIs, without changing production/test code.

The Master Architect accepts all three findings as material.

## 3. F1 reconciliation — ordering/fallback enforcement defect

### Accepted authority

Relevant accepted constraints already exist:

- SPEC §9.1: resolution includes priority/conflict resolution + immediate revalidation;
- SPEC §9.2: every proposal revalidates all action-relevant preconditions;
- accepted but incompatible proposals may terminate as `InvalidatedAtResolution`;
- where an accepted conflict remains equal-priority/unresolved and technical stable-ID fallback is used, fallback use must be disclosed;
- IMP-0001 requires stable-ID sensitivity to appear only in explicit marked fallback cases;
- manifest `S1-081`, `S1-META-02`, and `S1-GLOBAL-FALLBACK` make that quarantine/disclosure completion-relevant.

### Observed defect

Candidate-v1 sorts proposals by ProposalId before resolution. In at least two public-path interactions, changing only proposal IDs changes material/social outcome while producing no technical-fallback marker:

- a residence action whose action-relevant destination precondition is destroyed by another person's accepted residence move;
- a called favour racing reciprocal-favour cancellation.

This means nonsemantic proposal identity is functioning as undisclosed causal priority.

### Classification

**Missing enforcement / verification of accepted determinism/conflict semantics.**

No new social priority is authorized.

The repair may:

- make resolution order-invariant where feasible; or
- treat order-sensitive accepted alternatives as an explicit unresolved conflict and use the already-accepted disclosed technical fallback.

The repair may **not** invent a new domain priority such as “cancellation always precedes calls” or “target movement always precedes follower movement” without architecture/semantic escalation.

Because the global claim is broader than the two discovered examples, repair requires a bounded audit of Slice-1 action-pair interactions whose commits can alter another accepted proposal's action-relevant precondition/capacity.

If that audit finds a case for which accepted authority does not determine whether the actions are a conflict set or requires a social/domain priority, stop and escalate rather than choose locally.

## 4. F2 reconciliation — missing accepted attitude consequence

### Accepted authority

SPEC §3.1 requires:

> refusal of ordinary request while requester is in genuine unmet need: requester -> refuser -5

Candidate-v1 exposes and autonomously generates `RelationshipMediatedReciprocalHelp(..., Request: true)` as a real request meaning.

No accepted clause exempts that request from the generic needy ordinary-request refusal rule.

### Observed defect

A feasible voluntary refusal of `RequestGiftOrHelp` correctly produces -5.

The otherwise equivalent recipient-request reciprocal-help meaning produces voluntary `Declined` with no -5 contribution.

The candidate's “complete fixed event update” scenario does not exercise this ingress, and the invariant replay validates only contributions that already exist rather than deriving the missing mandatory consequence.

### Classification

**Implementation semantic defect + verification coverage gap.**

No semantic decision is required.

Repair must:

- apply the accepted -5 requester -> refuser consequence to qualifying `RelationshipMediatedReciprocalHelp(Request: true)` refusal;
- preserve 0 for ordinary refusal without genuine need;
- preserve no refusal penalty for `Unable` / `InvalidatedAtResolution`;
- avoid changing donor-offer reciprocal-help meaning;
- add executable matrix coverage for this request ingress;
- strengthen evidence so omission of a required fixed event consequence is detectable rather than merely self-consistent in replay.

## 5. F3 reconciliation — subjective-information boundary defect

### Accepted authority

SPEC §6.4 states actors automatically know:

- their own objective state;
- relations/claims in which they are direct parties;
- proposals/events in which they directly participate.

Other facts require valid event-specific observation or communication.

SPEC §5 / §9.4 requires relevant subjective inputs used by decision contexts to remain inspectable.

### Observed defect

`PersonalAgency.Decide` uses the complete objective world snapshot when applying candidate infeasibility.

For `RequestGiftOrHelp`, target grain is therefore used to exclude/allow the initiator's personal candidate even though that counterparty stock is not present in the recorded subjective inputs and no observation/communication supplied it.

The reviewer held the recorded subjective inputs constant and changed only the unobserved target stock:

- target stock 0: request candidate excluded, no proposal;
- target stock 8: request candidate selected and response activated.

### Classification

**Implementation semantic/architecture-boundary defect + trace-completeness coverage gap.**

No new observation system is authorized and Slice 2 must not be pulled forward.

Repair must audit **all objective counterparty/world facts read by Slice-1 personal agency**, not only grain.

For every read used in candidate generation/gating/scoring:

- show that it is the actor's own state, a fact automatically known under accepted §6.4 semantics, or an explicitly supplied/observable Slice-1 input; or
- remove it from personal subjective decision logic and leave objective feasibility/revalidation to the appropriate response/resolution stage.

The personal decision trace must expose every actual subjective input used.

If an input's actor-knowledge status is not determined by accepted authority, stop and escalate rather than assuming omniscience or inventing a new observation mechanism.

## 6. K4 disposition

The reviewer found:

- manifest integrity: SATISFIED;
- oracle independence: SATISFIED;
- fixture discipline: SATISFIED;
- deferred/later-slice boundaries: SATISFIED;
- substantive REQUIRED coverage: BLOCK because F1-F3 defeat several claims;
- source-to-assertion fidelity: BLOCK where F1-F3 were omitted/overclaimed;
- no silently invented semantics: BLOCK.

The Master Architect agrees.

`S1-GLOBAL-CONFORMANCE` is therefore **BLOCK / UNSATISFIED for candidate-v1**.

## 7. Repair boundary

Candidate-v1 remains immutable historical evidence.

Do not amend or move:

`imp-0001-slice1-conformance-candidate-v1`

Repairs must occur on a new implementation repair branch from candidate-v1.

After repair:

1. all existing canonical commands must pass;
2. all 127 coder-owned REQUIRED obligations must still have evidence;
3. F1-F3 regression evidence must pass;
4. the frozen manifest must remain unchanged;
5. a new candidate-v2 SHA/ref must be created;
6. fresh independent K4 conformance must review candidate-v2.

Birth Run 001 remains pending until IMP-0001 achieves verified completion.

## 8. Authority state

This reconciliation does **not**:

- change SPEC-SFL-0001;
- weaken/reclassify the frozen manifest;
- create a new social priority;
- authorize Slice-2 recognition/communication implementation;
- retire SCF-002;
- authorize merge of PR #7.

It classifies implementation evidence and issues a bounded repair under already accepted semantics.
