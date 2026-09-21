# TRES-0005 — Stage-3 Guardrail / Scenario Architecture Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Narrow adversarial review of the first Stage-3 verification conventions and proposed formation scenario family. The purpose is to distinguish legitimate verification guardrails from accidental new simulation semantics.

## 1. Baseline reviewed

Reviewed against:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- closed working record `specifications/working/SFL_V0_WORKING_SPEC.md`;
- `plans/SFL_V0_VERIFICATION_SCENARIOS_WORKBENCH.md`;
- TRES-0004 verification-closure review.

Proposals reviewed:

1. a pre-household `CandidateRecognition` proposition derived from actor evidence;
2. automatic `SustainingParticipant` association for the founding core at household formation;
3. any sustaining participant may nominate a sustaining participant for head;
4. addition of `RequestRepayment`;
5. separation of mechanism-isolation cards from closed-loop policy cards;
6. a canonical scenario-card schema;
7. a three-founder formation fixture plus two-founder smoke test.

## 2. Overall finding

The verification architecture is sound, but the premise that all four proposed “locks” are merely guardrails is false.

The review classifies them as follows:

- **CandidateRecognition rule:** genuine semantic gap; Stage 3 must not invent it silently.
- **Founding core -> SustainingParticipant:** semantic omission/erratum; necessary for the accepted model to become operationally coherent.
- **Head nomination rule:** semantic detail accidentally lost during compression; the previously approved working record already contains it and it should be restored explicitly.
- **RequestRepayment:** new social action, not a guardrail; do not add it merely to make a test easy.

The review also found a larger blocker for the next continuity family:

> `SPEC-SFL-0001` does not define how a non-founder becomes or ceases to be a `SustainingParticipant` of an existing household.

Without that transition, full-founder turnover cannot be demonstrated endogenously without the fixture writing the desired association/continuity outcome. This requires a narrow semantic erratum before continuity scenario cards can be authoritative.

No broader architecture change is indicated.

## 3. Finding S3-A — Stage 3 must not silently refine underspecified domain semantics

Model-based testing derives tests from a specification/model; refining an abstract model into executable actions is a distinct step and can itself introduce errors. Conformance tooling also explicitly recognizes that a failing discrepancy may indicate an implementation defect, a test-model defect, or a specification ambiguity/error.

Therefore:

- Stage-3 conventions may define fixture syntax, observation format, independent oracles, test levels, and permitted harness interactions;
- Stage 3 must **escalate**, not silently decide, any missing trigger, actor permission, state transition, or social effect.

This is especially important because SFL v0 intentionally separates implementation discretion from social semantics.

## 4. Finding S3-B — CandidateRecognition is needed, but its derivation rule is semantic

### Gap

Formation requires “recognition of the candidate by every person required for that founding core,” while the accepted recognition vocabulary explicitly names only:

- household H exists/continues;
- P occupies H's head role.

No accepted rule states when an actor recognizes a pre-household candidate.

### Why the proposed solution is not merely representation

A persistent proposition such as `CandidateRecognition(C)` is harmless as a data shape, but this rule:

> actor recognizes candidate C when the actor's KnownFact set can reconstruct the full objective formation warrant

changes behavior. It decides how much evidence a person needs and therefore when households can form.

External belief-revision literature supports the broad architectural principle that agents may hold incomplete information and revise beliefs from sourced messages/evidence. It does not supply the project-specific sufficiency rule for “candidate household recognition.”

### Recommended narrow erratum

The cleanest v0 rule remains:

- add an ephemeral/provenance-bearing `CandidateRecognition(C)` recognition proposition;
- C is an evidence-bundle/candidate reference, not a household identity and grants no powers;
- actor recognition is derived only from that actor's subjective evidence;
- candidate label/existence itself is never evidence.

**But the exact sufficiency rule must receive Director approval.**

Recommended v0 sufficiency rule for discussion:

> A founder recognizes candidate C only when the actor's subjective state contains uncontested evidence sufficient to establish the same formation predicate that objectively warrants C: shared residence of the proposed core, a connected durable-tie structure, and the two qualifying support events.

The actor need not know that the other founders also recognize C. That avoids higher-order-belief recursion.

## 5. Finding S3-C — Founding-core association is a required semantic erratum

### Gap

Formation creates a household and FormationWarrant. The spec then says v0 “uses provenance-bearing `SustainingParticipant`,” but does not say which associations are created at formation.

Later mechanics require sustaining participants for:

- continuity bearer logic;
- head nomination/acceptance;
- provision commitments;
- mediated marriage;
- household support.

A newly formed household with no sustaining participants would therefore be semantically unusable or immediately ambiguous.

### Recommendation

Restore explicitly:

> Successful household formation creates a `SustainingParticipant` association for every person in the FormationWarrant's founding core, with provenance to that FormationWarrant.

This does not make the association a primitive membership cause; it is a consequence/interpretation of the already-established lower-level organization.

## 6. Finding S3-D — Head nomination was lost during compression

The closed working record says:

> Any sustaining participant may nominate a sustaining participant. Appointment requires nominee acceptance plus recognition/acceptance by all current sustaining participants.

The accepted spec retained the acceptance rule but omitted who can nominate and whether the nominee must be a sustaining participant.

That omission changes candidate-generation semantics and should not be left to implementation.

### Recommendation

Treat this as a clerical restoration, not a new design:

- nominator must be a current `SustainingParticipant`;
- nominee must be a current `SustainingParticipant`;
- outgoing head may nominate a successor before vacancy;
- appointment/succession still require nominee acceptance + unanimous sustaining-participant acceptance.

## 7. Finding S3-E — do not add RequestRepayment as a test convenience

`SPEC-SFL-0001` includes `RepayDebt` and a -10 creditor->debtor attitude effect for knowingly retaining repayable debt while able, but no `RequestRepayment` action.

Adding a creditor-initiated request would introduce:

- a new action opportunity;
- a new response path;
- potentially new initiative/response timing;
- additional knowledge exchange;
- a way for a creditor to prompt repayment that does not currently exist.

That is real model behavior.

### Recommended Stage-3 treatment

Do not add `RequestRepayment` unless separately approved as a model amendment.

For the existing -10 rule, first specify the missing epistemic trigger narrowly. The least expansive option is:

- creditor must have valid current subjective evidence that debtor had repayable surplus;
- creditor, as direct party to the debt, knows whether repayment occurred;
- the attitude penalty may fire only when those conditions establish a knowingly retained repayable debt event.

A mechanism-isolation fixture may construct the required knowledge through existing communication/observation mechanisms. If this proves too artificial during Stage 3, reopen the action repertoire explicitly rather than adding a hidden test-only request action.

## 8. Finding S3-F — a larger continuity gap: SustainingParticipant entry/exit

### Gap

The accepted spec defines:

- formation;
- `SustainingParticipant`;
- continuity through a bridging sustaining participant;
- complete founder turnover as required verification.

It does not define the transition by which:

- a new person becomes a sustaining participant of an existing household;
- an existing sustaining participant ceases to be one without household dissolution.

Therefore the continuity proof cannot currently be executed without the fixture directly editing the association, which would script the target mechanism and violate the Stage-3 write-set rule.

### Consequence

This is the only newly identified **blocking semantic gap** for the planned continuity scenario family.

### Recommendation

Resolve it before writing canonical turnover cards. The rule should be deliberately narrow and v0-specific; Stage 3 research should not select it on its own.

Candidate families for Director discussion later include:

- a household-specific onboarding warrant mirroring a subset of formation evidence;
- an explicit participant-recognition/coordination transition;
- a derived association from a defined continuing lower-level support configuration.

No option is accepted by this review.

## 9. Finding S3-G — two verification levels are strongly justified

Separating **mechanism-isolation** from **closed-loop policy** cards is a verification guardrail, not a domain decision.

### Mechanism-isolation card

The harness may submit a semantically valid proposal/response at the same public proposal/resolution boundary an actor would use, while pinning or bypassing the actor's choice scorer.

Purpose:

- verify transition/recognition/resource semantics independently of arbitrary scoring coefficients;
- isolate one causal mechanism;
- provide simple oracles.

It must not directly mutate endogenous outcome state.

### Closed-loop card

The actual personal/household decision contexts must generate the proposals from a pinned deterministic policy configuration.

Purpose:

- verify candidate generation, scoring, subjective-information use, role-mode integration, and end-to-end trajectory.

This separation mirrors the distinction in model-based development between verifying requirements/model behavior and testing conformance of an implementation to that model.

## 10. Finding S3-H — improve the scenario-card schema

The proposed card schema is good. Add four fields/constraints:

1. **Card level:** mechanism-isolation / closed-loop / metamorphic / boundary / mutant.
2. **Observation horizon:** explicit final cycle/condition, so absence claims are bounded.
3. **Semantic-order constraints:** expected trace should normally assert required causal/partial ordering, not incidental total microstep order.
4. **Nonclaims / allowed variation:** identify implementation details the card intentionally does not constrain.

Recommended card fields:

- ID / level / claim / spec clauses;
- initial authoritative state;
- subjective initial state;
- pinned decision profile if relevant;
- allowed fixture writes;
- scripted proposal/stimulus schedule;
- observation horizon;
- required semantic trace/partial-order constraints;
- terminal assertions;
- always-on invariants;
- independent oracle basis;
- adversarial companions;
- nonclaims/allowed variation.

## 11. Finding S3-I — strengthen the three-founder formation fixture

The three-founder idea is strong because it prevents the main positive case from collapsing into one dyad.

### Main risk

Qualifying support actions can change attitude and accidentally generate the durable tie that an ablation intended to remove.

### Recommendation

For the canonical formation proof, use **scenario-initialized kinship edges for the durable connected structure**, because those ties are stable under the support events:

- A-B: sibling;
- B-C: parent/child (or another valid kin connection that preserves the desired connected graph);
- no A-C durable tie required.

Use two qualifying support events on distinct cycles and on different pairs, so no two-person subset independently has both recurrence events.

Example pattern:

- cycle x: A gives/helps C;
- cycle y > x: C gives/helps B.

Keep initial attitudes safely away from strong-like thresholds unless attitude dynamics are themselves under test.

Use existing communication to distribute event/tie evidence if the eventual CandidateRecognition rule requires it.

### Required ablation discipline

Each formation ablation must prevent alternate paths from recreating the missing condition during the observation horizon.

## 12. Finding S3-J — two-person smoke test is useful but not acceptance evidence by itself

A two-person formation card is valuable for debugging transition plumbing and boundary behavior.

It should be marked **smoke/mechanism-isolation**, not the sole architectural proof of emergent household formation.

The three-person canonical card remains the stronger acceptance witness because it exercises connected multi-person evidence, distributed knowledge, and candidate recognition.

## 13. Research-based guardrails retained

External testing research supports the following Stage-3 discipline:

- model-based tests should remain traceable to an independent specification/model, not quietly replace it with hand-refined implementation semantics;
- test-model/action refinement is a distinct and error-prone activity when it adds concrete detail absent from the abstract spec;
- invariants are useful low-cost oracles in state-machine/model-based testing;
- metamorphic relations help when a complete expected-output oracle is difficult;
- simulation verification (conformance to specification) remains distinct from validation against the external historical target.

## 14. Recommended next action

Before canonical Stage-3 formation/continuity cards are committed:

### Clerical/restorative spec errata suitable for immediate confirmation

1. formation creates `SustainingParticipant` for every founder, provenance -> FormationWarrant;
2. any sustaining participant may nominate a sustaining participant for head; outgoing head may nominate successor.

### Small semantic decisions that require explicit approval

3. exact `CandidateRecognition` evidence sufficiency rule;
4. `SustainingParticipant` entry/exit rule for existing households;
5. exact epistemic trigger for “knowingly retained repayable debt,” unless the feature is deferred or the action repertoire is explicitly expanded.

### Stage-3 guardrails safe to adopt without model change

6. mechanism-isolation vs closed-loop card levels;
7. strengthened scenario-card schema;
8. three-founder canonical formation design with stable durable ties and alternate-path controls;
9. two-founder smoke card.

## 15. External source basis

- Utting, Pretschner & Legeard, *A Taxonomy of Model-Based Testing Approaches*, Software Testing, Verification and Reliability 22(5), 2012.
- Microsoft Research, *Model-Based Testing with Spec Explorer*: distinguishes implementation, model, specification, and design errors revealed by conformance testing.
- van der Bijl, Rensink & Tretmans, *Action Refinement in Conformance Testing*, 2005: refining abstract actions to executable test detail is a separate step and hand rewriting is error-prone.
- Li & Offutt, *Test Oracle Strategies for Model-Based Testing*, IEEE TSE 43(4), 2017: state invariants are an effective low-cost oracle strategy.
- Collins, Koehler & Lynch, *Methods That Support the Validation of Agent-Based Models*, JASSS 27(1), 2024: verification is consistency with specification; validation against a target system is distinct.
- Galliers, *Belief Revision and a Theory of Communication*, Cambridge Computer Laboratory TR-193, 1990: multi-agent knowledge revision should account for incomplete information and evidence/messages rather than assume global knowledge.
- Liu, Kuo, Towey & Chen, *How Effectively Does Metamorphic Testing Alleviate the Oracle Problem?*, IEEE TSE 40(1), 2014.
