# Repository Branch Hygiene — Master Architect Reconciliation

**Status:** FINAL / CLEANUP EXECUTED / VERIFIED  
**Census:** `REPOSITORY_BRANCH_HYGIENE_CENSUS.md`  
**Decision owner:** Master Architect  
**Deletion authority:** only the exact approved set below; executor may not expand it

## 1. Result

The read-only census found 72 pre-existing remote branches. Since the census itself, two temporary maintenance branches were created for the census and this reconciliation.

Master Architect disposition:

- preserve `main`;
- preserve all intentionally frozen Slice-1 acceptance/conformance refs;
- preserve GOV-0001 frozen/evaluation provenance explicitly retained by its canonical promotion record;
- preserve TRES-0010 baselines and isolated reviewer/research return refs because canonical TRES records still rely on those branches as reproducibility/advisory evidence;
- preserve `benchmark/host-runtime-bakeoff` as reproducibility evidence for the project-specific bakeoff underlying ADR-0005 / DEC-0008;
- preserve `archive/res0001-files` **temporarily** until RES-0001R reconciliation/source-preservation review closes; it carries substantial unique ingestion history and RES-0001 remains unreconciled;
- approve deletion of merged/redundant working branches and the one abandoned/superseded Uruk seed branch listed below.

After the approved deletion set is executed, the expected remote branch count is **48**.

## 2. Ambiguous census cases resolved

### `benchmark/host-runtime-bakeoff`

**Disposition: KEEP — FROZEN AUTHORITY/EVIDENCE.**

Reason: the branch contains unique benchmark workflow/payload/runner material that is not present on `main`. ADR-0005 states that the accepted runtime choice rests on a project-specific bakeoff and adversarial review. Deleting the branch would reduce reproducibility of an accepted architectural decision for no meaningful maintenance benefit.

This does not make benchmark code authoritative simulation code.

### `archive/res0001-files`

**Disposition: KEEP — TEMPORARILY NEEDED.**

Reason: `research/historical/RES-0001/README.md` and `MANIFEST.md` say the relevant A–H return artifacts are durable on `main`, but RES-0001R reconciliation remains pending. The branch carries substantial unique ingestion history. Preserve it until reconciliation/source-preservation review explicitly confirms the branch adds no provenance value beyond the canonical return tree and recorded source-package hashes.

`archive/res0001-ingest`, by contrast, has no unique commits relative to main and is approved for deletion.

## 3. Protected frozen refs

The following classes are explicitly retained:

### Slice-1 verification/conformance

- `sfl-v0-slice1-acceptance-v1`
- `imp-0001-slice1-conformance-candidate-v1`
- `imp-0001-slice1-conformance-candidate-v2`
- `imp-0001-slice1-conformance-candidate-v3`

The three `implementation/...` branches point to the same SHAs as the three candidate refs and are redundant working aliases; they are approved for deletion.

### GOV-0001

Keep the named baseline, candidate, evaluation-baseline, three isolated evaluation returns, and promotion branch. Canonical GOV-0001 records explicitly describe these refs as historical/reproducibility evidence.

### TRES-0010

Keep the frozen review baselines and isolated Wave-A / Wave-B / B2 / manifest / MRR return branches. Many carry unique advisory return commits not otherwise fully preserved on `main`, and TRES-0010 canonical records still use those branch identities as research provenance.

The one exception is `tres-0010-closed`: it points to the exact same SHA as `governance-rulebook-refactor-baseline`, is not required by the current TRES navigation record, and is therefore a redundant alias.

## 4. Exact approved deletion set

The cleanup executor is authorized to delete **only** these refs:

- `archive/res0001-ingest`
- `archive/uruk-accident-tablets`
- `completion/imp-0001-slice1`
- `dispatch/imp-0001-slice1`
- `governance/imp0001-assurance-retrospective`
- `handoff/master-architect-succession`
- `implementation/imp-0001-slice1`
- `implementation/imp-0001-slice1-repair-v2`
- `implementation/imp-0001-slice1-repair-v3`
- `junior/uruk-accident-institutional-persistence-seed`
- `maintenance/imp0001-review-preservation-repair`
- `plan/post-imp0001-hygiene-assurance`
- `plan/slice1-birth-observation`
- `research/institutional-dynamics-draft`
- `research/post-v0-future-directions`
- `research/sfl-v0-discovery-seams`
- `review/imp-0001-block-reconciliation`
- `review/imp-0001-conformance-dispatch`
- `review/imp-0001-independent-conformance-v2-return`
- `review/imp-0001-independent-conformance-v3-return`
- `review/imp-0001-v2-block-reconciliation`
- `review/imp-0001-v2-conformance-dispatch`
- `review/imp-0001-v3-conformance-dispatch`
- `tres-0010-closed`
- `maintenance/branch-hygiene-census-return`
- `maintenance/branch-hygiene-reconciliation`

The final two maintenance branches are included because their contents will be durable on `main` after their PRs merge.

## 5. Non-deletion rules

The executor must not:

- delete `main`;
- delete any ref not listed above;
- delete or move any frozen candidate/acceptance ref;
- delete GOV-0001 or TRES-0010 retained provenance;
- delete `archive/res0001-files`;
- force-update a kept ref as a substitute for deletion;
- reinterpret branch age as evidence of redundancy.

If any approved branch head changes after this reconciliation, stop on that ref and report the discrepancy rather than deleting it automatically.

## 6. Execution limitation in the present environment

The connected GitHub toolset available to the Master Architect exposes branch creation and ref movement but **does not expose ref deletion**.

Therefore destructive cleanup is intentionally not simulated by force-moving refs. A separate low-authority Git-capable executor should receive the exact approved set above, delete those refs, and return:

- successfully deleted refs;
- failed/refused deletions;
- final remote branch list;
- any head mismatch from this approval.

Execution is complete. Independent post-execution remote verification is recorded in `REPOSITORY_BRANCH_HYGIENE_EXECUTION_RECORD.md`; the remote now contains exactly 48 intended survivor refs.

## 7. Assurance-learning workstream

The second half of the predecessor's housekeeping plan is already complete.

Candidate-v1 demonstrated four durable process lessons:

1. broad same-cycle ordering/fallback claims need interaction-surface coverage rather than a few representative examples;
2. actor decision inputs crossing objective/subjective boundaries need provenance classification;
3. global/universal wording needs evidence whose scope actually spans the claim;
4. fresh reviewers may build reviewer-owned public-boundary counterexample probes.

Those lessons were incorporated minimally into the existing specification→implementation assurance protocol. No new protocol, standing review tier, or blanket formal-methods requirement was created.

Candidate-v2 and candidate-v3 then exercised those stronger practices successfully: the second BLOCK was found by them, and candidate-v3 received a defensible independent PASS.

**No additional governance expansion is warranted from IMP-0001.**

## 8. Completion condition

This housekeeping workstream is complete at both the decision/governance and physical-ref levels. The approved deletion set was executed exactly, retained evidence refs were independently reverified, and branch hygiene no longer gates Birth Run 001.
