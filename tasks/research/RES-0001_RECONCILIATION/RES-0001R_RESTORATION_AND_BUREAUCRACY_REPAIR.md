# RES-0001R — Re-Derived Reconciliation Restoration and Bureaucracy Repair

**Task ID:** RES-0001R-RESTORE  
**Commissioned by:** Master Architect  
**Status:** READY FOR JUNIOR-SCRIBE DISPATCH  
**Authority:** archival/research-maintenance only; no simulation/design authority  
**Canonical base:** `146a3596096dc87e34f4b61fb0ba29270871420d`  
**Return branch:** `research/res-0001r-restoration-return`  
**Source attachment required:** `RES-0001R_RECONCILIATION_RETURN.zip`

## 1. Objective

Restore the independently re-derived RES-0001R cross-stream reconciliation into the repository **losslessly**, then repair stale repository state that still says reconciliation is pending/unavailable.

Do not reinterpret the research. Do not improve the prose. Do not promote any historical proposition or simulation mechanic.

This is an institutional-restoration task.

## 2. Source identity

The junior scribe must be given the exact source attachment:

`RES-0001R_RECONCILIATION_RETURN.zip`

Expected ZIP SHA-256:

`77a8755c1a4545e17c4452cc2c0ef36e0e53bcc165c6db9de650335a405bdf54`

If the attachment is absent or its SHA-256 does not match, **STOP** and return without modifying the repository.

The ZIP contains exactly six durable outputs:

| Source file | Expected SHA-256 |
|---|---|
| `README.md` | `37b05accb3f2b43ceb8f867a6445bea83d431b6b831ebddd082953ccdadb13d0` |
| `01_MASTER_PROPOSITION_SET.md` | `2d6687f29ef60892f98d2b2fbe39ed239d3e25a686f14c8dfe24b181e048f725` |
| `02_EVIDENCE_CONCORDANCE.csv` | `b3c182616ef76e156f6778e8dfeb79d1c7b3c880be03f7c873caa49e19a2568b` |
| `03_DISPUTE_AND_QUARANTINE_REGISTER.md` | `aeb191fbfb6be7be578165867de221a74fb6defe8cb0657f302e47535c6e958b` |
| `04_CANDIDATE_CLAIM_CROSSWALK.csv` | `942b8ec373b05d66ac1a1d7d1137c5077103b4c7cd3720e450dbc1e375e40f16` |
| `05_RECONCILIATION_QA.md` | `755a7d4632847e97c1d9e0ca0609f47cf53b75127a0cb5b00eda59bec52a6b30` |

## 3. Exact target tree

Write the six extracted files as ordinary Git text/data files at:

`research/historical/RES-0001/reconciliation/`

Exact mapping:

- `README.md` -> `research/historical/RES-0001/reconciliation/README.md`
- `01_MASTER_PROPOSITION_SET.md` -> `research/historical/RES-0001/reconciliation/01_MASTER_PROPOSITION_SET.md`
- `02_EVIDENCE_CONCORDANCE.csv` -> `research/historical/RES-0001/reconciliation/02_EVIDENCE_CONCORDANCE.csv`
- `03_DISPUTE_AND_QUARANTINE_REGISTER.md` -> `research/historical/RES-0001/reconciliation/03_DISPUTE_AND_QUARANTINE_REGISTER.md`
- `04_CANDIDATE_CLAIM_CROSSWALK.csv` -> `research/historical/RES-0001/reconciliation/04_CANDIDATE_CLAIM_CROSSWALK.csv`
- `05_RECONCILIATION_QA.md` -> `research/historical/RES-0001/reconciliation/05_RECONCILIATION_QA.md`

### Preservation rules

- preserve exact extracted bytes;
- do **not** gzip, split, base64-wrap, normalize, reformat, “clean up”, rename columns, or rewrite content;
- upload the large files **one at a time** if needed;
- after upload, recompute SHA-256 from the repository checkout and prove all six match the table above.

## 4. Authority boundary that must remain explicit

The restored package is:

**COMPLETE / RE-DERIVED / ADVISORY**

It is **not** represented as byte-identical to the lost earlier reconciliation artifact.

Its role is to restore the missing reconciliation function and evidence synthesis over preserved RES-0001 A–H returns.

The package establishes:

- 8/8 research returns reconciled;
- 69 source candidates dispositioned;
- 43 consolidated `HEC-` proposition candidates;
- duplicate-source normalization;
- dispute/quarantine preservation;
- source-access/generalization controls;
- **NO DESIGN DECISION**.

### Critical distinction

`HEC-xxxx` = reconciliation candidate identifier.

`HE-xxxx` = canonical Historical Evidence Register entry.

**Do not rename or promote HEC candidates into HE entries in this task.**

No simulation specification, assumption, architecture decision, or implementation behavior changes as a result of archival restoration alone.

## 5. Add restoration/provenance record

Create:

`research/historical/RES-0001/RES-0001R_RECONCILIATION_RESTORATION_RECORD.md`

The record must state at minimum:

1. A–H survived but the old reconciliation artifact did not.
2. The Project Director supplied an independently re-derived reconciliation on 2026-09-24.
3. Exact source ZIP SHA-256 and all six output SHA-256 values.
4. Re-derived result summary:
   - 8/8 inputs;
   - 69 source candidates;
   - 43 HEC propositions;
   - 58 represented / 6 redundant / 2 quarantined / 3 not register-worthy.
5. The restored return is advisory and has **NO DESIGN DECISION**.
6. It restores reconciliation availability but does not prove literal identity to the lost artifact.
7. It does not retroactively authorize already accepted SFL decisions.
8. Historical-evidence promotion into canonical `HE-` entries is a separate later Master Architect act.
9. Canonical storage paths for A–H, reconciliation return, original task packet, and Historical Evidence Register.

Do not add interpretations not present in the returned package.

## 6. Repair stale repository bureaucracy

Update only the files below unless a stale-reference audit finds another **direct factual claim that reconciliation is still pending/unavailable**.

### 6.1 `research/historical/RES-0001/README.md`

Change program status to reflect:

**A–H RETURNS + RE-DERIVED RECONCILIATION INGESTED**

Replace the pending-reconciliation section with:

- RES-0001R COMPLETE / RE-DERIVED / ADVISORY;
- link to `reconciliation/`;
- link to restoration record;
- 43 HEC candidates;
- HEC != canonical HE;
- separate historical-evidence promotion still required.

Preserve the existing context-discipline warning.

### 6.2 `research/historical/RES-0001/MANIFEST.md`

Preserve the historical original RES-0001R package hash:

`74acf3a88625e9730defee95dc6ff66fd4f5f8c7e6afdebde64ad5c9dee6ef2b`

Do **not** relabel it as the recovered return.

Add separately:

- re-derived return ZIP SHA-256;
- COMPLETE / RE-DERIVED / ADVISORY status;
- target reconciliation path;
- restoration-record path;
- exact six output hashes;
- explicit statement that HEC identifiers are candidates, not HE register IDs.

### 6.3 `research/historical/RES-0001/RES-0001R_RECONCILIATION_PENDING.md`

Do not delete this path; old references may point to it.

Convert it into a short historical redirect:

- status: **SUPERSEDED / HISTORICAL PENDING MARKER**;
- say reconciliation was previously unavailable;
- say the function has now been independently re-derived;
- link to `reconciliation/` and restoration record;
- preserve authority warning: advisory only / no direct mechanics.

Do not duplicate the whole restored package here.

### 6.4 `tasks/research/RES-0001_RECONCILIATION/RES-0001R_TASK_PACKET.md`

Change:

- `READY FOR DISPATCH` -> **COMPLETE / RE-DERIVED RETURN PRESERVED**;
- input readiness -> all A–H plus reconciliation complete;
- link durable return and restoration record;
- retain original task purpose and authority boundary.

### 6.5 `tasks/research/RES-0001_OLD_BABYLONIAN_NIPPUR/00_PROGRAM_README.md`

Change status:

**RETURNS COMPLETE / RECONCILIATION COMPLETE**

Update return-process paragraph to point to restored RES-0001R output.

Do not change the historical research question or frame.

### 6.6 `tasks/research/RES-0001_OLD_BABYLONIAN_NIPPUR/07_PROGRAM_MANIFEST.md`

Change status:

**RETURNS COMPLETE / RECONCILIATION COMPLETE**

Update final return-location sentence to point to restored reconciliation.

### 6.7 `tasks/research/README.md`

Remove RES-0001 from live/ready pending work.

Add under closed/historical:

- RES-0001 A–H + RES-0001R reconciliation **COMPLETE / RE-DERIVED / ADVISORY**;
- durable path;
- no historical-evidence promotion yet.

Do not disturb active Slice-4 review state.

### 6.8 `registers/HISTORICAL_EVIDENCE_REGISTER.md`

Update **Active evidence intake**:

- RES-0001 A–H and RES-0001R reconciliation are complete;
- 43 reconciled HEC candidates now exist;
- reconciliation availability no longer blocks historical-evidence review;
- no HEC candidate is automatically a canonical HE entry.

Keep **Current register** accurate:

- unless separately promoted in another task, there are still **no accepted project-specific HE entries**;
- say RES-0001R makes 43 candidates available for a future Master Architect historical-evidence promotion review.

### 6.9 `registers/ASSUMPTIONS_REGISTER.md`

Do **not** change any assumption status.

Add a compact note near the current-register preamble:

- RES-0001R reconciliation is now available;
- this closes only the *availability* part of review triggers that mention reconciled research;
- it does not retire/validate any assumption;
- assumption change still requires targeted evidence promotion/adjudication against that assumption.

Do not rewrite each assumption entry.

## 7. Files that must NOT change

Unless necessary to repair a direct stale factual reference:

- all RES-0001 A–H return contents;
- `SPEC-SFL-0001`;
- accepted decisions/ADRs;
- frozen Slice-1/2/3 manifests;
- Slice-4 candidate/review branches or tasks;
- production code/tests;
- `plans/CURRENT_PHASE.md` (it does not currently depend on RES-0001R availability);
- `registers/OPEN_ISSUES_REGISTER.md` unless a literal stale pending claim is found.

Do not retroactively claim that previously accepted SFL semantics were authorized by this recovered reconciliation.

## 8. Stale-reference audit

After edits, search the repository for phrases/claims equivalent to:

- `RECONCILIATION PENDING`
- `reconciliation remains pending`
- `reconciliation has not yet been completed`
- `No completed RES-0001R reconciliation result was found`
- `no completed reconciliation return recovered`
- `RES-0001R is prepared` / `ready for dispatch` when used as current status

Any remaining occurrence must be either:

1. inside explicitly historical quoted/provenance text; or
2. the superseded redirect itself, clearly marked historical.

Do not mechanically erase valid history.

## 9. Validation checklist

Before return:

- ZIP SHA-256 matches;
- six target files exist in ordinary uncompressed form;
- six target file SHA-256 values match exactly;
- `01_MASTER_PROPOSITION_SET.md` contains 43 HEC candidates;
- crosswalk accounts for 69 source candidates;
- restored package still says `NO DESIGN DECISION`;
- no `HEC-` candidate was silently renamed to `HE-`;
- A–H return files unchanged;
- no SPEC/decision/acceptance/code changes;
- active Slice-4 files unchanged;
- stale-reference audit completed;
- `git diff --check` passes.

## 10. Return discipline

Work on:

`research/res-0001r-restoration-return`

created from exact canonical base:

`146a3596096dc87e34f4b61fb0ba29270871420d`

If main advances while you work, **do not rebase or absorb unrelated changes without instruction**. Return the exact branch/commit and report the base so the Master Architect can integrate safely.

Create:

`research/historical/RES-0001/RES-0001R_RESTORATION_COMPLETION_REPORT.md`

The report must include:

- exact branch/head;
- source ZIP SHA;
- six verified file hashes;
- files added/modified;
- stale-reference audit results;
- authority-boundary confirmation;
- confirmation A–H and active Slice-4 work were untouched;
- any unexpected repository reference requiring MA judgment.

## 11. Stop conditions

STOP and report rather than improvise if:

- source ZIP/hash differs;
- source package is missing one of the six expected outputs;
- exact output hashes do not match;
- completing the task appears to require changing accepted simulation semantics;
- a stale reference appears to imply actual historical-evidence promotion already occurred;
- another branch has independently restored RES-0001R and creates conflicting canonical state.

Do not create mechanics, design decisions, or canonical HE entries.
