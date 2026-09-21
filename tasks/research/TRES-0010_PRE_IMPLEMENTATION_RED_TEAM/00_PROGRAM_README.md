# TRES-0010 — Pre-Implementation Architecture / Semantics / Verification Red Team

**Status:** COMMISSION PACK PREPARED / IMPLEMENTATION GATE ACTIVE  
**Commissioned by:** Master Architect  
**Authority:** Advisory research only  
**Implementation effect:** `IMP-0001` dispatch is blocked until TRES-0010 is reconciled.

## 1. Purpose

Before the first persistent implementation begins, adversarially review the project's accepted foundation, SFL v0 semantics, verification design, and Slice-1 handoff.

The program asks:

> What important contradiction, missing rule, hidden coupling, verification weakness, implementation hazard, or unnecessary commitment have we collectively failed to notice before code creates inertia?

This is a falsification program, not an approval poll.

## 2. Wave A commissions

Run these tasks independently and, where practical, in parallel:

- `TRES-0010A_FOUNDATIONAL_ALIGNMENT_AUDIT.md`
- `TRES-0010B_SEMANTIC_REACHABILITY_AUDIT.md`
- `TRES-0010C_TEMPORAL_DETERMINISM_AUDIT.md`
- `TRES-0010D_VERIFICATION_CHEAT_RED_TEAM.md`
- `TRES-0010E_IMP0001_HANDOFF_AUDIT.md`
- `TRES-0010F_FUTURE_SLICE_COMPATIBILITY_AUDIT.md`
- `TRES-0010G_CSHARP_IMPLEMENTATION_HAZARD_REVIEW.md`
- `TRES-0010H_ADVERSARIAL_TRAJECTORY_DESIGN.md`
- `TRES-0010I_SCOPE_MINIMALITY_RED_TEAM.md`
- `TRES-0010J_FRESH_AGENT_RETRIEVAL_AUDIT.md`

Each task has a different falsification objective. Agreement count is not evidence.

## 3. Independence design

Two modes are used deliberately.

### PROJECT-CONTEXT reviewers

These tasks test internal consistency and therefore may inspect the relevant canonical repository chain. They should still retrieve only what their packet needs.

### INDEPENDENT-CONTEXT reviewers with repository access

These agents have repository access but are intentionally source-restricted for the first pass.

They must:

1. read only the artifacts explicitly listed in their packet plus higher-authority files those artifacts directly require;
2. write their initial findings before reading prior TRES-0003 through TRES-0009 conclusions;
3. only afterward may inspect earlier adversarial reviews to identify duplicate/already-resolved findings.

This prevents inherited conclusions from masquerading as independent review.

## 4. Mutation / repository rule

Wave-A agents are advisory.

- Do not modify accepted decisions, ADRs, specifications, verification cards, governance, implementation packets, source code, tests, or navigation.
- If the execution harness supports isolated branches/workspaces, an agent may write only its assigned return under:
  `research/technical/TRES-0010/returns/`.
- Otherwise return the report to the Master Architect without repository mutation.
- Concurrent repository writers must use isolated branches/workspaces and be reconciled explicitly.

## 5. Common finding schema

Every substantive finding should include:

- **Finding ID**
- **Classification:** contradiction / missing semantic rule / verification weakness / implementation hazard / future-slice coupling / unnecessary scope / retrieval-governance issue / harmless ambiguity / false positive
- **Severity:**
  - `BLOCKER_BEFORE_CODE`
  - `HIGH_REPAIR_BEFORE_CODE`
  - `MEDIUM_AMEND_OR_GUARD`
  - `DEFERRED_RISK`
  - `NO_ISSUE / FALSE_POSITIVE`
- exact artifact/path/section evidence;
- smallest counterexample, failure trace, or reasoning chain;
- why existing authority does or does not answer it;
- consequence if ignored;
- recommended disposition;
- confidence / uncertainty.

Do not inflate severity merely because a topic is interesting.

## 6. Required return behavior

Return a compact report with:

1. executive finding summary;
2. detailed findings in the common schema;
3. attempted attacks that *did not* expose a defect;
4. any places where the task could not determine the answer from accepted artifacts;
5. explicit list of prior TRES findings read, if any, and **when** they were read;
6. recommendation: `BLOCK IMPLEMENTATION`, `AMEND BEFORE IMPLEMENTATION`, or `NO BLOCKER FROM THIS REVIEW`.

Reports are evidence, not authority.

## 7. Wave B — contingent targeted challenge

Do **not** pre-run Wave B.

The Master Architect first:

1. collects Wave-A returns;
2. deduplicates shared provenance;
3. classifies findings against accepted authority;
4. rejects obvious false positives;
5. identifies serious unresolved findings.

For each serious finding only, commission targeted opposing reviews such as:

- **Prosecution:** demonstrate that the issue is a genuine blocker with a minimal counterexample.
- **Defense:** demonstrate that existing accepted semantics already resolve it, or that it is safely local/reversible.
- **Experiment:** where prose cannot discriminate, design/run the smallest relevant technical probe.

Wave-B agents receive the finding, not the Wave-A agent's preferred fix unless necessary.

## 8. Master Architect reconciliation

After Wave B where needed, the Master Architect produces the TRES-0010 reconciliation:

- unique findings;
- evidence/provenance;
- accepted / rejected / deferred dispositions;
- canonical repairs required;
- implementation-packet amendments required;
- newly discovered engineering guardrails;
- intentionally accepted residual risks;
- lossless promotion reconciliation for any approved semantic changes;
- final decision whether `IMP-0001` may dispatch.

No coding agent receives IMP-0001 before this gate closes.

## 9. Stop conditions

Immediately escalate a finding rather than proposing a silent fix when it would change:

- foundational simulation philosophy;
- persistent identity/representation;
- accepted causal semantics;
- concurrency/execution model;
- authority boundaries;
- major subsystem boundaries;
- verification contract meaning;
- significant abstraction fidelity.

## 10. Success condition

TRES-0010 succeeds when the project either:

- finds and repairs meaningful pre-code defects; or
- records credible adversarial evidence that no remaining issue found by these attacks warrants blocking Slice 1.

The goal is not consensus. The goal is to make implementation expensive to fool.
