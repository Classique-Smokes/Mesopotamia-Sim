# SFL v0 Slice 3 — Acceptance Review Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / CANDIDATE-2 PREPARED / FRESH REVIEW REQUIRED  
**Date:** 2026-09-23  
**Canonical authority base:** `main@221e579ba8805ff6de23a73f73b2e4d2431011a8`  
**Blocked candidate:** `SFL-V0-S3-ACCEPTANCE-v1-candidate1`  
**Blocked candidate commit:** `f2a55f875024e5b341b12a3577799ce200f39ec9`  
**Blocked candidate blob:** `6045a330bf267a3189752b98ec990f1b5d6956a9`  
**Repaired candidate:** `SFL-V0-S3-ACCEPTANCE-v1-candidate2`  
**Repaired candidate commit:** `cb1bf676b2265d3522fe855095b8e2275656508d`  
**Repaired candidate blob:** `294e10a28b6b116b6f2549dd7325b4e07ccf43d3`  
**Authority:** reconciliation only; does not freeze acceptance authority or change SFL semantics

## 1. Review lineage recovered

Two distinct independent review runs evaluated the exact same candidate-1 commit/blob and both returned **BLOCK**.

### Review R1

- branch: `review/sfl-v0-slice3-acceptance-precode-20260923-r1`
- original artifact path: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW.md`
- original artifact blob: `d41ed1692da8eac9d69219689290562e201e5435`
- durable preserved copy: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_R1.md`
- target integrity: exact candidate-1 commit/blob matched
- verdict: **BLOCK**
- independence claim: clean initial derivation from accepted/canonical sources before opening candidate; prohibited Slice-3 discovery/reconciliation material not used for derivation/verdict.

R1 findings:

1. provision-commitment prerequisite fixture not uniquely authorized;
2. Household Recognition acquisition/conflict surface incomplete;
3. qualifying support meaning set not omission-detectable;
4. exact inherited regression bundle not actually exact.

### Review R2

- branch: `review/sfl-v0-slice3-acceptance-precode-independent-return`
- original artifact path: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW.md`
- original artifact blob: `8bf3308c7190866a862c27696c5f826f9feb8c34`
- durable preserved copy: `research/technical/SFL_V0_SLICE3_ACCEPTANCE_PRECODE_REVIEW_R2.md`
- target integrity: exact candidate-1 commit/blob matched
- verdict: **BLOCK**
- independence disclosure: task discovery exposed some target/parallel-branch metadata before exact packet confirmation; the reviewer explicitly disclosed this and re-derived findings from accepted authority. Because the return is BLOCK rather than PASS, this contamination cannot create false freeze authorization.

R2 findings:

1. canonical three-founder architectural formation witness not pinned;
2. both accepted participation proposal directions not independently omission-detectable;
3. Household Recognition tri-state/conflict/lifecycle closure incomplete;
4. irrelevant-attribute metamorphic missing;
5. provision reserve / NeedsGrain boundary matrix not frozen.

The reviews are not duplicate votes. Their source-grounded findings overlap on Household Recognition and otherwise cover complementary omission surfaces.

## 2. Master Architect adjudication

### 2.1 Accepted repair findings

The following findings are accepted and repaired in candidate 2.

#### A. Canonical three-founder formation witness

**Accepted.**

The canonical verification package explicitly states that `VS-SFL-001` remains the architectural formation witness and that `VS-SFL-002` is only smoke/debug evidence.

Candidate 2 binds `S3-001-FORMATION-POSITIVE` to `VS-SFL-001` or a fresh-reviewer-approved semantically equivalent three-founder witness preserving its causal schedule, fixture restrictions, multi-founder evidence acquisition/communication, CandidateRecognition, automatic formation chain, and stable closure.

#### B. Both participation proposal directions

**Accepted.**

SPEC §7.4 contains two distinct accepted action meanings:

- `RequestHouseholdParticipation(H)`;
- `InviteHouseholdParticipation(P)`.

Candidate 2 requires both directions to be independently exercised under `S3-020-PARTICIPATION-ENTRY-POSITIVE`.

#### C. Household Recognition closure

**Accepted and repaired to the union of both reviews.**

Candidate 2 now requires:

- outsider/newcomer Unknown -> Recognized acquisition through provenance-bearing `CommunicateClaim/Inform`;
- newer valid continuation evidence refreshing current positive Household-recognition provenance;
- decisive dissolution evidence arriving through accepted participation/communication provenance and making stale positive continuation evidence no longer safely usable;
- Household-specific incompatible evidence with no accepted dominance producing/retaining `Contested`;
- `Contested` not satisfying the participation Household-recognition gate;
- no new negative Recognition enum;
- no generic nonparticipant observation entitlement;
- no ID/global-state/history winner rule.

This preserves the accepted generic `Unknown / Recognized / Contested` model rather than inventing a Household-specific epistemic theory.

#### D. Qualifying support meaning census

**Accepted.**

SPEC closes the qualifying ordinary person-person support set as:

- accepted gift/help;
- loan provision;
- favour fulfilment.

Candidate 2 adds `S3-015-QUALIFYING-SUPPORT-KIND-CENSUS`, requiring omission-detectable coverage of all three meanings wherever the shared predicate is used and excluding Household-originated support as independent formation/continuity/fresh-lineage evidence.

#### E. Irrelevant-attribute metamorphic

**Accepted.**

The Cross-Cutting Verification Contract lists irrelevant-attribute perturbation as a required metamorphic relation. Candidate 2 adds `S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION`.

#### F. Provision reserve / NeedsGrain boundary matrix

**Accepted.**

Candidate 2 strengthens:

- `S3-071` to bind contributor grain 1 / 2 / 3 -> capacity 0 / 0 / 1 for a non-`NeedsGrain` committed contributor;
- `S3-072` to bind false/true `NeedsGrain` at the same otherwise-positive grain.

No household spending action is pulled into Slice 3.

#### G. Exact inherited REQUIRED regression expansion

**Accepted.**

Candidate-1's `S3-R11` phrase “all prior REQUIRED suites remain green” was not omission-detectable enough for a section claiming exact inherited bindings.

Candidate 2 carries an exact candidate-resident expansion of:

- all **128** frozen Slice-1 REQUIRED AcceptanceIds;
- all **46** frozen Slice-2 REQUIRED AcceptanceIds.

Completion must report those members individually rather than hide them behind one aggregate suite result.

### 2.2 Rejected finding: provision prerequisite fixture prohibition

R1 F-01 is **not accepted**.

The accepted semantic SPEC and canonical verification contract together permit the bounded prerequisite used here:

1. SPEC §1.1 permits declared bounded fixture inputs and forbids fixture writes of endogenous results **the scenario is meant to prove**. It does not create a universal ban on every non-lower-level state that is not the assertion target.
2. The Cross-Cutting Verification Contract's inherited-card metadata explicitly says a family/card states **any additional fixture write it requires beyond the generally allowed set**.
3. The same contract's fixture audit says facts must never be fixture-written **when they are the outcome under test**, and allows downstream cards to begin from previously verified facts/states.
4. Slice-3 provision rows test commitment-state grounding, capacity arithmetic, reserve/NeedsGrain behavior, non-pooling, rebuildability, and termination. They explicitly do **not** test commitment acquisition.
5. Candidate 2 therefore declares the pre-existing valid `HouseholdProvisionCommitment` as an additional controlled fixture write, preserves fixture provenance, forbids writing derived capacity, creates no head/office state, moves no grain, contributes no formation/continuity evidence, and claims no headless acquisition path.

This is a verification-fixture boundary, not new social semantics. Endogenous provision solicitation/reconsideration remains Slice 4.

R2 independently reached the same conclusion.

## 3. Candidate-2 repair census

Candidate 2 now contains:

- **107 unique AcceptanceIds**;
- **94 REQUIRED**;
- **11 DEFERRED**;
- **2 UNEXERCISED**;
- no duplicate Slice-3 AcceptanceIds.

The four additional REQUIRED rows are:

- `S3-015-QUALIFYING-SUPPORT-KIND-CENSUS`;
- `S3-048-H-RECOGNITION-CONTESTED`;
- `S3-049-H-RECOGNITION-CONTESTED-GATE`;
- `S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION`.

Other accepted findings were repaired by strengthening existing rows rather than multiplying AcceptanceIds.

## 4. No semantic / Director escalation

Neither review established a missing Director-level social-semantic or architectural decision.

Candidate 2 does not change:

- Household formation/continuity/lifecycle semantics;
- Recognition state model;
- controlled lineage semantics;
- provision acquisition/spending semantics;
- head/office boundary;
- CandidateOrganization convergence semantics;
- checkpoint/restore boundary.

The repairs are verification/completion-authority hardening only.

## 5. Fresh-review requirement

Candidate 2 is **not frozen** and is **not implementation authority**.

A new reviewer who authored neither R1 nor R2 must independently derive the expected Slice-3 boundary from accepted authority, evaluate the exact candidate-2 commit/blob, and return exactly one of:

- **PASS — MAY FREEZE UNCHANGED**
- **BLOCK**

The reviewer must not treat this reconciliation or either prior review as authority. For anti-anchoring, the new review packet forbids reading R1, R2, discovery returns, or this reconciliation until the reviewer has fixed its own initial derivation/finding set.

Any operative candidate-2 change after review requires another candidate and re-review.

## 6. Competing working lineages

Earlier unmerged branches using `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_APPLICABILITY_CANDIDATE.md` are separate parallel working history and are not the selected acceptance-authority lineage.

Current selected line:

`main@221e579...` -> candidate1 `f2a55f8...` BLOCKed by R1/R2 -> candidate2 `cb1bf67...` -> fresh review required.

No earlier candidate/review branch is promoted merely because it exists or has a favorable local result.
