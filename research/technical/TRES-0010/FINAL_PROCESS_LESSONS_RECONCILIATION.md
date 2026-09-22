# TRES-0010 — Final Process Lessons Reconciliation

**Status:** FINAL TRES-0010 PROCESS SYNTHESIS / NON-CONSTITUTIONAL  
**Date:** 2026-09-21  
**Purpose:** Classify durable process lessons after Wave B, B2, manifest BLOCK/repair review, and R2 PASS.  
**Governance effect:** None by itself. Constitutional/process doctrine is promoted only through the planned rulebook refactor and Director approval.

## 1. Overall conclusion

The strongest durable lesson is not “use more reviewers.”

It is:

> At consequential specification-to-implementation boundaries, explicitly close semantic reachability/composition, separate semantic authority from verification authority and implementation discretion, freeze exact slice applicability independently of the coder, and verify the verification surface itself before dispatch.

TRES-0010 also showed the cost of overreaction. Several Wave-A findings were correctly rejected or narrowed by prosecution/defense and minimality review. Future assurance must therefore be **risk-scaled and adversarial, but anti-bureaucratic**.

## 2. Reconciled provisional lessons

| Lesson | Final disposition | Future primary owner |
|---|---|---|
| PL-01 Stateful semantic nouns need lifecycle closure | **KEEP, narrowed.** Apply to authoritative stateful semantic objects whose identity/history/transitions matter; not every immutable/value object. | Specification-to-Implementation Assurance Protocol |
| PL-02 Consequential action parameters need explicit validity domains | **KEEP strongly.** Include malformed/out-of-range/no-op classification and social-effect consequences. | Assurance Protocol + specification checklist |
| PL-03 Local transition rules do not guarantee composition closure | **KEEP strongly.** Audit shared bounded scalars, single-valued relations, scarce capacity, authority preconditions, and non-commutative same-cycle effects. | Assurance Protocol |
| PL-04 Nested action semantics need explicit completion/failure propagation | **KEEP strongly.** Initiative ownership, response recursion, outer success/failure, and side-effect ownership must be closed. | Assurance Protocol |
| PL-05 Stage closure needs systematic reachability/composition audit | **KEEP, consequence-scaled.** Use before high-inertia implementation boundaries, not every small subsystem edit. | Assurance Protocol |
| PL-06 Verification authority should be independent-enough from implementation authority | **KEEP strongly.** Lightweight technical independence is sufficient; do not require organization-scale IV&V. | Assurance Protocol + task template + mechanical freeze/CI where mature |
| PL-07 Consequential implementation packets need closed applicability | **KEEP strongly.** Exact REQUIRED/DEFERRED/N-A/UNEXERCISED classification where omission/self-selection is a real risk. | Assurance Protocol + implementation template |
| PL-08 Preserve accepted future seams without implementing future slices | **KEEP, narrowed.** Preserve only accepted/high-cost seams; reject speculative framework future-proofing. | Core Guide principle + Assurance Protocol |
| PL-09 Required-input authority taxonomy must be explicit | **KEEP.** Separate accepted meaning/architecture, verification authority, and supporting/engineering context. | Implementation task template; short core principle |
| PL-10 Adversarial review belongs at consequential integration boundaries | **KEEP, consequence-scaled.** One broad pre-code integration red team was high leverage here; not universal ceremony. | Assurance Protocol / work-mode trigger map |
| PL-11 Undefined conditions must remain visible until closure | **KEEP.** Treat unresolved domain/state/applicability conditions as explicit gaps, not silent defaults. | Assurance Protocol |
| PL-12 Risk-scaled formalization for composition hotspots | **KEEP as optional escalation tool.** Tiny state enumeration/model checking/reference model may be high leverage; never mandatory project-wide. | Assurance Protocol |
| PL-13 Verification should be traceable requirement-by-requirement | **KEEP strongly for consequential slices.** Stable IDs + applicability + oracle/evidence + completion status. | Assurance Protocol + acceptance-manifest/checklist template |

## 3. Additional durable lessons confirmed by Wave B

### PL-14 — Distinguish missing semantics, missing enforcement, and implementation-local risk

These require different responses:

- missing semantics -> authority/design closure;
- missing enforcement -> verification/handoff repair;
- implementation-local risk -> engineering guard/test.

Do not solve all three with architecture.

**Destination:** Assurance Protocol.

### PL-15 — Verification cannot create missing social semantics

A verification card/example may reveal an intended case but cannot resolve semantic ambiguity when the accepted specification is silent.

TRES-0010 encountered this repeatedly, including ExplicitBenefitForFavor and BFF/RMRH parameter-shape concerns.

**Destination:** Assurance Protocol + verification-authority metadata.

### PL-16 — Adversarial findings require adjudication, not direct promotion

Prosecution/defense/minimality checks prevented:
- hidden-test infrastructure;
- generic mutation platform;
- generated-history framework;
- generalized multi-party effect framework;
- overbroad candidate-policy work.

**Destination:** Agent Delegation and Research Protocol.

### PL-17 — Blindness must include the control plane

A “blind” reviewer that must read coordinator text containing prior finding labels is source-independent but not perfectly topic-blind.

Future replication/sentinel packets should be self-contained and avoid prior finding taxonomy.

**Destination:** Agent Delegation and Research Protocol + research packet template.

### PL-18 — Exact acceptance surfaces need their own adversarial review

The first Slice-1 manifest was independently authored but still contained:
- a missing deferred boundary;
- semantic over-broadening;
- an omission-prone generic D4 row.

Independent pre-code review of the acceptance authority itself caught these before code.

**Destination:** Assurance Protocol. Trigger only when the acceptance surface is consequential enough to serve as implementation completion authority.

### PL-19 — Grouped applicability rows must not hide omission

A compact grouped row is acceptable only if:
- all grouped members have the same status/scope; and
- the expected membership set is frozen and omission-detectable.

Otherwise use stable per-ingress/per-subcase IDs.

**Destination:** Acceptance-manifest/template guidance.

### PL-20 — Preserve representation freedom with schema-neutral verification

When accepted semantics constrain meaning but not API/schema representation, verification should test semantic ingress/effect properties without promoting one raw field/signature.

The BFF/RMRH grain-transfer repair is the reference example.

**Destination:** Assurance Protocol + implementation template.

### PL-21 — Freeze identity must avoid self-referential hashing

If a document records its own content hash, editing the hash changes the hash.

Use:
- reviewed-candidate SHA inside the artifact if useful;
- final frozen SHA/commit in an external freeze record or immutable ref.

**Destination:** Mechanical artifact-freeze checklist, not Master Architect core doctrine.

## 4. Lessons intentionally *not* promoted

TRES-0010 does not justify:

- maximum adversarial ceremony for every task;
- multi-agent voting/consensus as evidence;
- secret held-out tests as a default prerequisite;
- a general mutation-testing platform;
- a general formal-methods requirement;
- a generic action/effect framework;
- generated histories/shrinking as universal completion evidence;
- pre-building future subsystem abstractions;
- organization-scale repository permission bureaucracy.

## 5. Already materialized before closure

Without waiting for the constitutional refactor, the following task/environment repairs were safe engineering/governance-template improvements and are already in place:

- frozen independently reviewed Slice-1 acceptance authority;
- exact Slice-1 applicability manifest;
- IMP-0001 authority-class taxonomy;
- conditional frozen-acceptance controls in the generic implementation task template;
- TRES-confirmed C# local safeguards;
- explicit deferred-gap ledger.

These do not amend the Master Architect constitutional role.

## 6. Rulebook refactor inputs

The planned rulebook restructuring should use this reconciliation as its TRES-0010 input.

Primary future destinations:

- **AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md**
  - context modes;
  - anti-anchoring;
  - blind replication/control-plane hygiene;
  - prosecution/defense/sentinel patterns;
  - provenance;
  - adjudication/minimality;
  - agent count is not evidence.

- **SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md**
  - PL-01..PL-15 as applicable;
  - exact slice applicability;
  - protected verification authority;
  - oracle independence;
  - schema-neutral semantic verification;
  - risk-scaled formalization;
  - release/no-release gate.

- **Task templates / mechanical checks**
  - authority taxonomy;
  - manifest identity;
  - stable AcceptanceIds;
  - freeze record;
  - completion report coverage;
  - branch/baseline provenance.

## 7. Closure assessment

The provisional process-lesson phase is complete.

No remaining process lesson requires changing Slice-1 social semantics, architecture, or IMP-0001 scope before dispatch.

The constitutional Master Architect Guide remains unchanged until the separately planned lossless rulebook refactor and Director approval.
