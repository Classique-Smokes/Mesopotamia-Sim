# IMP-0002 — Independent Post-Implementation Conformance Review V1

**Review type:** fresh regular chat / clean context  
**Authority:** read-only PASS/BLOCK conformance review  
**Implementation candidate:** `imp-0002-slice2-conformance-candidate-v1`  
**Exact candidate SHA:** `5a452078c845b8aa4cc2756f5638517dce87e6e8`  
**Implementation PR:** #38  
**Frozen Slice-2 acceptance:** `SFL-V0-S2-ACCEPTANCE-v1`  
**Frozen Slice-2 ref:** `sfl-v0-slice2-acceptance-v1`  
**Frozen Slice-2 manifest SHA:** `e4872531cf780d51fa1863f2a0b87e2424a71b69`

## 1. Purpose

Independently determine whether exact candidate `5a452078c845b8aa4cc2756f5638517dce87e6e8` conforms to accepted SFL semantics, accepted architecture, the frozen Slice-2 acceptance manifest, and the exact Slice-1 regression obligations.

This review is a **fresh independent judgment**.

Do not modify the candidate.

Do not accept coder claims, generated PASS labels, or the existing conformance report as proof.

### Independence rule

Before forming your own provisional judgment, **do not rely on**:

- `tasks/implementation/IMP-0002_IMPLEMENTATION_REPORT.md`;
- `research/technical/IMP-0002/IMP-0002_INDEPENDENT_CONFORMANCE_REVIEW_V1.md`;
- `research/technical/IMP-0002/IMP-0002_EXECUTION_RECORD_V1.json`;
- PR #38 narrative claims.

You may inspect those only **after** independently checking the candidate, and then only as claims/evidence to corroborate or challenge.

## 2. Required authority to retrieve

Retrieve independently:

1. `AGENTS.md`
2. `00_START_HERE.md`
3. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
4. accepted ADRs under `architecture/accepted/`, especially ADR-0001, ADR-0002, ADR-0004, ADR-0005
5. `tasks/implementation/IMP-0002_SFL_V0_SLICE2_SUBJECTIVE_KNOWLEDGE.md`
6. `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md`
7. `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_FREEZE_RECORD.md`
8. frozen Slice-1 manifest + freeze record
9. relevant canonical verification families, especially `RECOGNITION_INFORMATION_FAMILY.md`
10. exact candidate diff against canonical parent `71bddc045fb2079b4b10b97649c639b4ee20d0ba`

Supporting discovery/reconciliation material may be consulted, but it is not semantic authority.

Conceptual tablet material is not implementation authority.

## 3. Candidate identity / immutability

Before semantic review:

- verify `imp-0002-slice2-conformance-candidate-v1` resolves to exact SHA `5a452078c845b8aa4cc2756f5638517dce87e6e8`;
- verify the implementation branch head used for judgment is the same SHA;
- verify both frozen manifests match their frozen refs/content SHAs;
- do not review a moving branch;
- do not modify candidate files.

If identity differs, BLOCK and report the mismatch.

## 4. Canonical commands

Run exactly from the unchanged candidate root:

- `dotnet restore Mesopotamia.Sim.slnx`
- `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
- `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
- `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Record SDK version, results, warnings/errors, failures/skips.

Green commands are necessary but not sufficient.

## 5. Mandatory source review

Inspect every modified production file and the Slice-2 acceptance implementation.

At minimum inspect:

- `src/Mesopotamia.Sim/EpistemicState.cs`
- `src/Mesopotamia.Sim/EpistemicExecution.cs`
- `src/Mesopotamia.Sim/State.cs`
- `src/Mesopotamia.Sim/PersonalDecisionInputs.cs`
- `src/Mesopotamia.Sim/Agency.cs`
- `src/Mesopotamia.Sim/Decisions.cs`
- `src/Mesopotamia.Sim/Execution.cs`
- `src/Mesopotamia.Sim/ResolutionDependencies.cs`
- `src/Mesopotamia.Sim/Simulation.cs`
- `src/Mesopotamia.Sim/VerificationAccess.cs` if changed/present
- modified runtime documentation/configuration surfaces
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice2AcceptanceTests.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice2Scenarios.cs`
- any acceptance helper/oracle touched by IMP-0002
- CI changes

## 6. Frozen manifest conformance

Independently audit all **46 REQUIRED Slice-2 AcceptanceIds**.

For every REQUIRED row verify:

- substantive evidence exists;
- fixture writes obey the frozen fixture class/write-set boundary;
- oracle basis is independent enough;
- no REQUIRED row is merely label-covered;
- grouped scenarios do not hide omitted subcases;
- no frozen requirement was weakened, bypassed, or silently reinterpreted.

Also verify all **9 explicit Slice-2 deferrals** remain deferred and no later-slice semantics were faked.

Audit the **18 exact Slice-1 regression bindings** required by the Slice-2 manifest.

Do not accept coder-generated row tables without checking the underlying assertions/source.

## 7. High-priority semantic probes

### A. Objective truth vs actor knowledge

Seek any path where actor policy can read:

- `WorldSnapshot`;
- global `History`;
- another actor's epistemic state;

as if it were subjective knowledge without an accepted acquisition route.

### B. KnownFact / Recognition separation

Verify:

- factual state is separate from Recognition;
- Recognition is not scalar confidence, attitude, approval, or obedience;
- CandidateRecognition remains bounded/ephemeral;
- no hidden universal proposition ontology was introduced.

### C. Automatic acquisition

Confirm only accepted direct routes are automatic:

- own state;
- direct-party relations/claims;
- direct participation.

No generic nonparticipant observation, co-residence omniscience, or global synchronization.

### D. Communication

Independently test factual and Recognition communication for:

- sender-held gate;
- no invention;
- provenance;
- ordinary personal initiative cost;
- intended-recipient-only delivery;
- no broadcast;
- no fresh same-cycle personal activation on receipt;
- no ResponseDecisionContext created merely by receipt;
- normal objective revalidation.

### E. Staleness / precedence

Challenge:

- stale state after unwitnessed objective change;
- newer direct evidence vs later old report;
- newer event-backed report vs older report;
- delivery-order permutation;
- stable IDs/sender IDs/container order not becoming semantic precedence.

### F. RG-01 Contested Recognition

Re-derive the one-C witness from frozen authority.

Check:

- no Household/head/formation implementation is smuggled in;
- Residence D1/D2 conflict is the bounded lower-level incompatible fact;
- recipient Contested is production-derived, not fixture-written;
- no new negative Recognition proposition;
- no universal conflict/evidence-strength algebra;
- sender order / delivery order / isomorphic ID renaming do not select a winner;
- CandidateRecognition lifetime remains bounded.

### G. Recognition vs attitude/refusal

Verify both mandatory perturbations independently:

- negative unrelated Attitude;
- independent ordinary voluntary refusal/Decline;

must not change Recognition when recognition evidence is unchanged.

### H. Candidate gating and traces

Verify inaccessible communication candidates are gated before scoring.

Verify decision traces expose the actual factual/Recognition/provenance basis used.

### I. Objective revalidation

Seek cases where subjective eligibility becomes stale before commit.

Confirm commit-time objective/held-proposition revalidation prevents invalid commit without retroactively rewriting prior decision history.

## 8. ResolutionDependencies / scheduler audit

This is a high-priority code-review point.

The implementation changes `ResolutionDependencies.cs`.

Determine whether it:

- only detects/handles real same-cycle epistemic dependencies;
- uses detached projection as technical resolution machinery;
- preserves the existing scheduler/resolver architecture;
- does **not** introduce a new social precedence/evidence rule;
- does **not** let stable IDs choose Recognition winners;
- preserves commutativity where accepted;
- discloses technical fallback where noncommutativity remains.

Use reviewer-owned scratch probes if useful.

Any new semantic precedence hidden in scheduler logic is a BLOCK.

## 9. Fixture audit

For each executable scenario family verify concrete write sets, not class labels alone.

Particularly challenge:

- acquisition scenarios starting with the fact already present;
- communication scenarios fixture-writing recipient postconditions;
- RG-01 fixture-writing final Contested;
- candidate-gating fixtures injecting production candidates/scores;
- metamorphic pairs with hidden semantic differences.

## 10. Oracle independence audit

Independent checks must not use the production helper under judgment as the expected answer.

Pay special attention to:

- candidate generation/gates;
- Recognition derivation/conflict;
- evidence precedence;
- provenance classification;
- cache/index classification;
- trace construction.

Where the acceptance code uses structural/string checks, independently source-review the claim rather than accepting the string check alone.

## 11. Public-boundary reviewer probes

Create reviewer-owned scratch probes **outside the candidate** against unchanged public boundaries.

At minimum probe:

1. one absent held fact cannot be communicated;
2. one absent Recognition cannot be communicated;
3. a nonrecipient does not learn a message;
4. receipt does not create response context or second voluntary action;
5. later old report cannot overwrite newer direct evidence;
6. reversed report delivery preserves newer event-backed result;
7. RG-01 remains Contested under sender/delivery permutation;
8. consistent nonsemantic ID renaming preserves RG-01 result;
9. unrelated negative Attitude leaves Recognition unchanged;
10. unrelated voluntary refusal leaves Recognition unchanged;
11. read-only epistemic inspection is behaviorally noninterfering;
12. same-cycle sender fact invalidation cannot commit stale communication;
13. no household/head/checkpoint/trust/reputation machinery is needed by public Slice-2 behavior.

Document setup and assertion counts.

Do not commit probes to candidate.

## 12. Later-slice / scope audit

BLOCK if candidate introduces or depends on:

- persistent Household identity/lifecycle;
- office/head/succession;
- mediated marriage;
- household provision/lineage;
- checkpoint/restore;
- generic nonparticipant perception;
- trust/lying/rumor/reputation;
- brokerage;
- richer memory decay;
- strategic communication/planning;
- stochastic choice;
- universal proposition/conflict framework.

## 13. Review of coder claims — only after independent judgment

After completing your own source/command/probe review, you may inspect:

- `tasks/implementation/IMP-0002_IMPLEMENTATION_REPORT.md`;
- PR #38 narrative;
- existing review report/execution record on `review/imp-0002-conformance-v1`;
- CI run `35828653126` and evidence artifact metadata.

Use them only to corroborate or identify discrepancies.

Do not let the existing “PASS” substitute for your review.

## 14. Result classification

Return one of:

### PASS

No material semantic, architectural, acceptance-coverage, fixture, oracle, regression, or scope defect established.

### BLOCK — IMPLEMENTATION / VERIFICATION DEFECT

Accepted semantics are clear, but candidate fails them or evidence is insufficient.

Identify exact defect and repair scope. Do not redesign semantics.

### BLOCK — SEMANTIC ESCALATION

Candidate cannot satisfy frozen acceptance without a genuinely missing consequential semantic/architectural rule.

State the exact missing decision. Do not invent it.

## 15. Return artifact

Create branch:

`review/imp-0002-conformance-independent-return`

from exact candidate SHA `5a452078c845b8aa4cc2756f5638517dce87e6e8`.

Add only:

`research/technical/IMP-0002/IMP-0002_INDEPENDENT_CONFORMANCE_REVIEW_FRESH.md`

The report must include:

- exact candidate SHA/ref;
- frozen authority identities;
- PASS/BLOCK;
- canonical command results;
- REQUIRED-row census;
- Slice-1 regression census;
- deferral census;
- fixture/oracle findings;
- ResolutionDependencies/scheduler finding;
- reviewer scratch-probe summary;
- later-slice leakage finding;
- semantic-escalation status;
- explicit promotion recommendation: **PROMOTE / DO NOT PROMOTE**.

Do not modify the candidate.
