# TRES-0010 — Wave B Adjudication Synthesis

**Status:** MASTER ARCHITECT SYNTHESIS / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Implementation gate:** IMP-0001 remains blocked pending B2 resolution and final TRES-0010 reconciliation.

## 1. Review integrity

All ten Wave-B branches were checked against the frozen Wave-B baseline `f25407a9cbf09e501601d52ad7a2df111fa5c491`.

Each branch changed only its assigned return file under `research/technical/TRES-0010/returns/`. No canonical project artifact was modified by reviewers.

One methodological caveat:

- the two “blind” sentinels did not read Wave-A returns, but the required Wave-B README exposed short labels/categories for the challenged findings;
- therefore sentinel results are useful independent re-derivations from canonical sources, but are not perfectly blind to topic identity;
- do not treat them as statistically independent confirmation.

## 2. High-level result

Wave B substantially narrows Wave A.

It does **not** support reopening the foundational architecture, host/runtime, deterministic staged kernel, household-emergence philosophy, or accepted identity/recognition architecture.

It confirms a small set of real pre-Slice-1 semantic gaps, a small set of pre-dispatch assurance/handoff repairs, several implementation-local guards, and a separate ledger of real later-slice gaps.

It also rejects several Wave-A overreaches that would have created premature framework work.

## 3. Confirmed Slice-1 semantic repairs

### S1-SEM-01 — Mixed same-cycle automatic attitude reactions

Sources:
- Wave A C-F01;
- Wave B temporal prosecution and defense.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

The accepted semantics permit multiple distinct same-cycle attitude causes to affect one bounded attitude, but do not define confluence/ordering. Sequential clamp order can change the stable result (e.g. +95 with +10 and -20 can end at +80 or +85).

This is a genuine semantic choice and cannot be delegated to implementation order.

### S1-SEM-02 — Multiple accepted same-cycle Residence changes

Sources:
- Wave A C-F02;
- Wave B temporal prosecution and defense.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

One target can accept multiple proposals from the common snapshot. Residence is single-valued, but accepted authority does not state whether competing accepted moves form a conflict set, whether one invalidates the others, or whether multiple sequential moves are legal.

This is a genuine semantic choice.

### S1-SEM-03 — Called-favour requested-action closure

Sources:
- Wave A H-001 / E-F03;
- Wave B action prosecution and defense;
- Wave-B semantic sentinel F04.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

Both Wave-B sides agree that accepted authority does not fully close the CallFavor action domain.

They differ on how much is already implied:
- prosecution argues universal response semantics and same-cycle terminality already imply nested same-cycle response handling and response-scoped initiative treatment;
- defense argues the spec does not explicitly define response-generated proposal closure or initiative composition.

The minimum uncontested gap is the positive semantic membership of the callable “ordinary action” domain. Because different action classes imply materially different nested-response/initiative behavior, the Slice-1 contract needs an explicit bounded rule before implementation.

B2 should adjudicate the narrowest sufficient rule rather than building a generic recursive action framework.

### S1-SEM-04 — Grain-valued action parameter domain

Sources:
- Wave A B-002;
- Wave B action prosecution and defense;
- Wave-B semantic sentinel F02.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

Accepted authority does not explicitly define the admissible domain for gift/help/loan/repayment/dowry grain amounts. Zero-valued actions can satisfy material invariants while still triggering social consequences, and negative/over-repayment behavior is not normatively closed.

A shared semantic amount-domain rule is required.

### S1-SEM-05 — Explicit benefit-for-favour at full favour capacity

Sources:
- Wave A E-F05;
- Wave B action prosecution and defense disagree;
- Wave-B semantic sentinel F05 independently re-derived the ambiguity.

Master Architect provisional disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

Prosecution argues canonical verification cards close the issue by separating material benefit commit from additional favour creation.

Defense correctly notes that verification artifacts are explicitly non-semantic and subordinate to SPEC-SFL-0001, while the specification itself does not define whether an explicit bargain remains valid when its bargained-for new favour cannot be created.

The phrase “underlying benefit may still commit if independently valid” does not define whether the benefit leg of the explicit bargain is independently valid in that situation.

Therefore implementation should not infer bargain atomicity/non-atomicity from verification prose. This requires a narrow semantic clarification.

## 4. Confirmed pre-dispatch assurance / handoff repairs

### S1-ASR-01 — Independent first executable acceptance authority

Sources:
- Wave A D-001;
- Wave-B D sentinel D-SENT-001;
- Wave-B implementation prosecution/defense.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

IMP-0001 currently commissions the candidate implementation task to create the first executable acceptance translation.

The smallest justified repair is **not** a general hidden-eval/grader platform. It is a protected/frozen Slice-1 acceptance manifest or equivalent independently controlled acceptance check that prevents the implementation task from being the sole author/editor of the completion authority.

### S1-ASR-02 — Closed Slice-1 verification applicability/completeness manifest

Sources:
- Wave A D-005, E-F01, E-F06, I-F01;
- Wave-B D sentinel D-SENT-002;
- Wave-B implementation prosecution/defense.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

The task must explicitly enumerate required/deferred/N-A Slice-1 canonical cards/subcases and relevant cross-cutting checks.

This also fixes:
- the literal VS-SFL-100..105 conflict with out-of-scope VS-SFL-104;
- open-ended “relevant/applicable/where substrate exists” self-selection.

No general mutation-testing platform is required.

### S1-ASR-03 — Required-input authority taxonomy

Source:
- Wave A J-F01;
- Wave-B implementation prosecution/defense.

Disposition: **CONFIRMED_REPAIR_BEFORE_SLICE1**

IMP-0001 should distinguish:
- accepted authority;
- required non-authoritative supporting context;
- verification authority;
- working engineering guidance.

This is a task/governance wording repair, not a semantic change.

## 5. Implementation-local guards, not architecture decisions

Wave B narrows the following to local engineering safeguards:

- C# snapshot aliasing/deferred enumeration must not violate the already-accepted common-snapshot contract;
- stable-ID based identity/equality discipline;
- deterministic text comparison if machine text enters authoritative ordering;
- checked/validated integer scoring bounds;
- concrete analyzer/static-quality policy and acceptance-protection mechanism;
- test isolation from shared mutable static state.

These belong in the C# implementation checklist/IMP completion evidence rather than new social or architectural authority.

Wave B also finds that several Wave-A “future seam” concerns are already closed by accepted authority and should not trigger preemptive framework design:
- subjective state vs objective state;
- decision-context identity vs PersonId;
- semantic history as addressable causal evidence.

## 6. Wave-A findings rejected or narrowed

### Candidate generation

E-F02 is **ALREADY_RESOLVED_BY_AUTHORITY** for Slice 1.

The project does not require a broad general autonomous policy beyond the explicitly pinned closed-loop contexts. Mechanism-isolation cards may enter through the public proposal boundary.

### Profile-ID overfitting

D-003 is not a separate semantic gap. Existing profile/gate authority already forbids candidate/gate bypass.

Do not add generic profile-extensibility machinery merely to prove profile-ID renaming invariance.

### Secret held-outs

Wave-B implementation prosecution/defense reject the claim that the project already requires hidden held-out tests.

The current contract uses “held-out” to mean non-primary narrative variants, not secret evaluator cases.

Secret/evaluator-controlled variants may later improve assurance but are not an IMP-0001 prerequisite.

### Pre-generalized multi-party effect framework

F-F03 is rejected as premature future-proofing.

Slice 1 may use the simplest sufficient internal transition representation so long as it does not harden a pairwise shape into an accepted/public boundary or make later accepted semantics impossible.

### Generated histories / shrinking / general config framework

Wave B supports deferring these broader harness/configuration mechanisms from Slice-1 completion unless a later verification task explicitly requires them.

## 7. Confirmed later-slice semantic gaps

These should be carried forward explicitly but do not independently block IMP-0001 once the Slice-1 repairs are complete.

### LATER-01 — CandidateOrganization equivalence / formation entry

B-001 is confirmed as a later formation-slice gap, narrowed:

- a persistent candidate lifecycle is not necessarily required;
- but “same candidate” equivalence/convergence is not operationally closed.

### LATER-02 — Actor departure

B-003 is confirmed if actor departure is an executable v0 input.

For Slice 1, explicitly exclude departure from valid fixtures/generated operations.

Resolve the semantic transition before any later slice uses it.

### LATER-03 — Rejoin/re-exit lineage source selection

B-005 is confirmed for later lineage work.

### LATER-04 — Authority-destroying transition vs accepted authority-dependent action

H-002 is confirmed for later household/head work.

It does not block Slice 1.

## 8. Later verification-hardening items

The following are worth preserving but not using to expand the Slice-1 critical path:

- B-004 exit-side ContinuationWarrant: semantics already require it; add stronger explicit verification later.
- D-SENT-004: when generated histories become completion evidence, input validity/generation must not be circularly filtered by the production gate under test.
- D-SENT-005: later downstream “verified checkpoints” should have verifiable producer/pass/fixture-audit provenance.
- D-006: checkpoint omission mutants need continuations that causally exercise the omitted state.
- future mediated-marriage response topology should be made explicit before that route is implemented.
- generic event-observer eligibility / recognition update after decisive dissolution or head-vacancy evidence should be revisited with recognition implementation.
- later household/reaction-chain derived-refresh timing deserves a targeted check.

## 9. Sentinel-method caveat and process lesson

The B0 sentinels were source-independent from Wave-A reports but were not perfectly topic-blind because the Wave-B README they were required to read contained short finding labels.

Future sentinel/replication tasks should receive a self-contained packet that does **not** require reading a coordinator document containing prior finding taxonomy.

This is a durable multi-agent research-process lesson.

## 10. B2 work still justified

No technical platform experiment is currently necessary.

Three bounded B2 work products are justified:

### B2-SEM-T — Temporal composition options

For S1-SEM-01 and S1-SEM-02:

- compare minimal semantic rules;
- expose simulation consequences;
- recommend one rule for Director approval;
- draft exact verification cases.

### B2-SEM-A — Lower-level action/favour closure

For S1-SEM-03, S1-SEM-04, S1-SEM-05:

- define minimal options;
- avoid generic action frameworks;
- recommend the smallest v0 rule set;
- draft exact spec/verification changes.

### B2-ASR — Slice-1 acceptance authority design

For S1-ASR-01/02:

- design the smallest protected/frozen manifest/evaluator boundary;
- state who owns/authors it;
- enumerate exact Slice-1 applicability;
- make oracle-independence audit visible;
- avoid hidden-eval/general grader infrastructure.

S1-ASR-03 can be repaired directly in IMP/task-template wording after final reconciliation.

## 11. Process lessons strengthened by Wave B

Wave B strengthens several provisional long-term lessons:

1. distinguish **missing semantic authority** from **missing enforcement** and from **implementation-local risk**;
2. verification artifacts cannot silently create missing social semantics when the specification is ambiguous;
3. every adversarial finding should face a minimality/defense pass before becoming new infrastructure;
4. broad future-proofing should lose to the simplest sufficient current implementation unless a real architectural dead end is demonstrated;
5. true blind replication requires blindness in control-plane instructions as well as blindness to detailed reports;
6. exact applicability manifests are a reusable remedy for autonomous implementation handoffs;
7. pre-code integration review is high leverage, but its output must be adjudicated rather than directly promoted.

## 12. Current gate recommendation

Do not release IMP-0001 yet.

The project does **not** need another broad red-team wave.

Complete the three bounded B2 tasks above, reconcile/approve the five narrow Slice-1 semantic repairs, materialize the small protected acceptance/applicability surface, amend IMP-0001/task taxonomy, then perform one final TRES-0010 closure review.

That is the shortest evidence-based path from the current state to safe coding dispatch.
