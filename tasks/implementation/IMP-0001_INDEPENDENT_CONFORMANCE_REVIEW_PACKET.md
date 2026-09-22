# IMP-0001 — Fresh Independent Post-Implementation Conformance Review

**Review class:** K4 independent post-implementation conformance  
**Reviewer requirement:** FRESH / INDEPENDENT — reviewer did not author IMP-0001 production code or its acceptance harness  
**Candidate:** `imp-0001-slice1-conformance-candidate-v1` @ `7e11dab7697121eb0dbb169ba46210d81b80586e`  
**Decision output:** PASS or BLOCK  
**No production edits:** reviewer evaluates; reviewer does not repair candidate-v1

## 1. Independence boundary

Treat all prior implementation and Master Architect conclusions as untrusted claims.

Do **not** use:

- prior conversational knowledge of how the code was written;
- the coding agent's confidence as evidence;
- the Master Architect's release-to-review conclusion as evidence;
- aggregate PASS percentages without examining the underlying obligations.

You may read the implementation report because K4 requires checking its claims, but independently verify them.

If you were the coding agent for IMP-0001 or materially participated in its test/evidence construction, you are not eligible for this review.

## 2. Retrieval order

Read current repository entry/governance first:

1. `AGENTS.md`
2. `00_START_HERE.md`
3. `governance/MASTER_ARCHITECT_GUIDE.md`
4. `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`
5. `tasks/implementation/IMP-0001_CONFORMANCE_DISPATCH_RECORD.md`
6. this packet

Then retrieve accepted / frozen authority:

7. `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
8. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
9. accepted ADRs cited by IMP-0001
10. `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
11. verification sources cited by the manifest
12. `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`

Only then inspect candidate-v1 production/tests/report/evidence.

## 3. Candidate integrity

Before substantive review:

- fetch `origin`;
- verify `imp-0001-slice1-conformance-candidate-v1` resolves exactly to `7e11dab7697121eb0dbb169ba46210d81b80586e`;
- verify candidate manifest blob is exactly `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- verify the frozen ref resolves to freeze commit `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- verify manifest census is 167 / 128 / 33 / 3 / 3;
- verify PR #7 has not advanced beyond the frozen candidate during the review.

If candidate code/test/evidence mapping changes, stop and return BLOCK / REVIEW BASELINE INVALIDATED.

## 4. Required K4 review

Independently verify all items required by manifest Part K4:

1. manifest unchanged from dispatch baseline;
2. every REQUIRED row has substantive evidence, not label-only coverage;
3. executable assertions match the cited accepted source clauses;
4. oracle dependencies obey manifest Part I;
5. fixture writes obey manifest Part J;
6. deferred/later-slice cards were not faked;
7. no unresolved semantic choice was silently made by test or production code.

Also verify:

- accepted architecture and IMP-0001 scope were not changed for implementation convenience;
- no hidden household/recognition/checkpoint semantics entered Slice 1;
- deterministic ordering does not derive social meaning from collection iteration;
- stable-ID fallback occurs only where accepted and is disclosed;
- verification/test seams cannot become normal public simulation mutation paths;
- coder fault-control classifications accurately distinguish actual injection, focused control, structural alternative, and unexercised mutation.

## 5. Reproducible execution

On the exact candidate, run from repository root:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Compare generated acceptance evidence with exact-candidate CI run `35692449925` and artifact `10678977680`.

Do not assume matching output proves semantic adequacy; it proves reproducibility only.

## 6. Review strategy

You are not required to mechanically rewrite all 167 tests, but you must inspect enough source/evidence to justify every K4 conclusion.

Prioritize:

- all global REQUIRED obligations;
- all five conjunctive D1–D5 repair bundles;
- rows sharing broad scenario mappings;
- oracle/fixture/fault-control infrastructure;
- autonomous candidate generation and response policy;
- determinism/metamorphic claims;
- accepted-vs-deferred scope boundaries.

Sample aggressively where risk is low; inspect exhaustively where one helper/mapping could falsely satisfy many rows.

## 7. Return format

Create a review-only branch from current `origin/main` named:

`review/imp-0001-independent-conformance-return`

Do not merge or modify PR #7.

Write:

`research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md`

The report must include:

- reviewer independence statement;
- candidate ref/SHA reviewed;
- manifest version/blob/freeze commit;
- canonical command results;
- evidence artifact identity used;
- K4 item-by-item findings;
- important source/test samples inspected;
- any architecture/scope findings;
- any BLOCK findings with exact file/row/source references;
- final result: **PASS** or **BLOCK**;
- explicit statement that PASS applies only to candidate `7e11dab7697121eb0dbb169ba46210d81b80586e`.

If BLOCK, do not repair production code in the review branch. Return findings for reconciliation.

## 8. Decision standard

PASS only if the frozen completion authority is substantively satisfied and no material semantic/architecture drift is found.

A plausible implementation, green CI, or 127 coder-reported PASS rows is insufficient by itself.

When uncertain about a material requirement, BLOCK with a precise finding rather than silently filling the gap.
