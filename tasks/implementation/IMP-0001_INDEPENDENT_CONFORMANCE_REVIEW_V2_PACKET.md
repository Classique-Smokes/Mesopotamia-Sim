# IMP-0001 — Candidate-v2 Fresh Independent Conformance Review Packet

**Review class:** K4 fresh independent post-implementation conformance
**Decision:** PASS or BLOCK
**Reviewed candidate:** `imp-0001-slice1-conformance-candidate-v2` @ exactly `ba16829e240950f1f3c648107cf3b8b36f996971`
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1`

## Independence

The reviewer must be fresh with respect to candidate-v2 repair implementation and acceptance-harness edits.

Do **not** use the repair author/current Akkadian as the reviewer: that agent authored the F1–F3 repair and is contaminated for independent conformance.

Treat all coder reports, green CI, Master Architect reconciliation, candidate-v1 BLOCK findings, and repair narratives as claims to test—not as conclusions to adopt.

The reviewer may know that candidate-v1 previously BLOCKED, but must not reduce the task to checking whether those three named defects were patched. Re-derive conformance against the frozen authority.

## Required identity checks

At execution start and finish:

- fetch `origin`;
- verify candidate-v2 ref = `ba16829e240950f1f3c648107cf3b8b36f996971`;
- verify PR #16 head = candidate-v2 SHA and remains draft/unmerged;
- verify PR #7 still points to candidate-v1 and remains draft/unmerged;
- verify frozen manifest blob = `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- verify freeze ref `sfl-v0-slice1-acceptance-v1` remains `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- verify census remains 167 unique IDs: 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED.

Any candidate/authority drift => `BLOCK — REVIEW BASELINE INVALIDATED`.

## Retrieval order

Retrieve in order:

1. `AGENTS.md`, `00_START_HERE.md`;
2. `governance/MASTER_ARCHITECT_GUIDE.md` and `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`;
3. this packet and `IMP-0001_CANDIDATE_V2_RECONCILIATION_AND_DISPATCH.md`;
4. original IMP-0001 task + BLOCK repair packet;
5. accepted SPEC + ADRs;
6. frozen manifest and cited verification sources;
7. candidate-v2 production/tests/evidence;
8. candidate-v1 BLOCK reconciliation/full review only as historical counterexample evidence, not as present authority.

## Canonical execution

Run from an exact detached candidate-v2 checkout using SDK 10.0.401:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Preserve outputs/exit codes/toolchain identity.

Compare fresh evidence with exact-head CI run `35772625856` and artifact `10714762656` (digest `sha256:6e0f87e00005b0bc946eec02684955616964b192c4b2ba4f6fcf3c5d5f8ab0f7`). Matching evidence proves reproducibility only.

## Full K4 obligations

Return separate conclusions for:

1. manifest integrity;
2. substantive evidence for every REQUIRED row;
3. source-to-assertion fidelity;
4. oracle independence;
5. fixture discipline;
6. honest deferred/later-slice boundaries;
7. absence of silently invented semantics.

Review architecture/scope, deterministic ordering, verification seams, decision traces, subjective/objective boundaries, same-cycle resolution, history completeness and fault-control classifications.

## Candidate-v2 adversarial priorities

### A. Do not merely replay F1 regression examples

Independently inspect `ResolutionDependencies` and derive the current executable action/dependency domain from source/accepted semantics.

Try to falsify the global fallback/quarantine claim with reviewer-owned public-API probes. Especially examine:

- interactions not explicitly named in the repair report;
- three-or-more proposal sets where pairwise relations look harmless but aggregate capacity/order matters;
- credits/enablers mixed with spending;
- CallFavor effective-actor/effective-terms interactions;
- relation creation/retirement provenance;
- cases where fallback may be over-marked even though semantic outcome is actually asymmetric/commuting;
- proposal-ID renaming versus participant/relation-ID renaming.

PASS requires that technical-ID sensitivity be confined to disclosed accepted fallback cases—not merely that the original two R1/R2 counterexamples now carry flags.

### B. Re-derive F2 completeness

Independently verify the full fixed attitude-event domain, including recipient-request reciprocal help, no-need refusal, Unable/Invalidated controls, called-favour refusal, debt due and mixed same-cycle cause composition.

Inspect whether the strengthened oracle truly detects omitted mandatory causes without depending on production consequence classifiers.

### C. Attack F3 as an information-boundary problem

Independently inspect every behavior-affecting input to personal generation/gating/scoring.

Verify:

- no personal decision helper retains/receives the objective world snapshot;
- direct-party facts match accepted automatic-knowledge scope;
- explicit observation bindings do not silently expose unbound private facts;
- identity binding alone does not disclose sex/residence/grain/debt;
- traces expose all actual personal inputs;
- unobserved world perturbations cannot change personal choice;
- objective feasibility is still correctly enforced later;
- the repair did not accidentally implement a hidden Slice-2 knowledge/recognition subsystem.

Use reviewer-owned public-API scratch probes where they help distinguish these claims.

### D. Regression breadth

Check that the expanded repair harness did not weaken or accidentally alter prior D1–D5 semantics, scoring profiles, initiative accounting, failure knowledge, material conservation, marriage/residence cardinality or CallFavor closure.

## Evidence ledger

Build/retain an independent ledger for all 167 manifest rows. Every REQUIRED row must have admissible substantive evidence. Preserve all frozen non-required classifications.

`S1-GLOBAL-CONFORMANCE` is awarded only by this review.

## Review return

Create branch:

`review/imp-0001-independent-conformance-v2-return`

from current `origin/main`.

Add only:

`research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`

Report must include:

- independence statement;
- candidate/authority identities;
- commands/results and exact-head CI/artifact comparison;
- K4 item conclusions;
- AcceptanceId evidence ledger;
- reviewer-owned probes and outcomes;
- precise blockers with source/implementation/evidence references;
- final **PASS** or **BLOCK** applying only to candidate-v2 SHA.

If BLOCK: do not repair the candidate.

If PASS: do not merge PR #16; Master Architect performs final completion/promotion reconciliation.
