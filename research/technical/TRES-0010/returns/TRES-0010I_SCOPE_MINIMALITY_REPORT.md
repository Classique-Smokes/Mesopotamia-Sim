# TRES-0010I — Scope / Minimality Red-Team Report

- **Task ID:** TRES-0010I
- **Frozen baseline ref:** `tres-0010-review-baseline`
- **Resolved baseline commit SHA:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Model/configuration:** GPT-5.6 Sol; separate reasoning-effort setting not exposed
- **Dedicated branch/workspace:** `tres-0010/i`; verified identical to the frozen baseline before this return was written
- **Tools used:** GitHub repository connector for branch/ref resolution, frozen-ref file reads, branch comparison, and writing this return
- **External web research:** no
- **Prior TRES-0003–0009 read:** no. The required `plans/verification/SFL_V0/README.md` contains a one-line closure statement naming TRES-0009, but no TRES-0003–0009 report or conclusion file was opened.
- **Sibling Wave-A returns read before initial report:** no
- **Sibling Wave-A returns read at any time during this review:** no
- **Initial-draft discipline:** initial minimality findings were drafted from the packet's required first-pass set before targeted reads of implementation-referenced Stage-3 family/profile artifacts used only to validate proof obligations.

## 1. Executive finding summary

**Recommendation: `AMEND BEFORE IMPLEMENTATION`.**

No foundational semantic blocker was found. The accepted project direction is already unusually disciplined about excluding persistence, scaling, concurrency, generic frameworks, checkpointing, and household semantics from IMP-0001.

The main defect is a concrete Slice-1 scope collision in the acceptance list:

- IMP-0001 requires executable coverage for `VS-SFL-100` through `VS-SFL-105`,
- but `VS-SFL-104` explicitly requires an active Household and valid head role,
- while the same IMP-0001 packet explicitly places Household/head semantics out of scope and says household cards must remain unimplemented rather than faked.

That should be repaired before dispatch by excluding `VS-SFL-104` (and its role-scoped `SCORE-RP-005` profile) from Slice 1.

Three additional medium-severity scope guards would materially reduce the chance that the first coder builds framework infrastructure instead of the reference slice:

1. classify out-of-slice semantic mutants as `unexercised` rather than treating the full 30-mutant cross-cutting set as an IMP-0001 implementation requirement;
2. state explicitly that generated-history/shrinking machinery and held-out materialization are not IMP-0001 completion criteria;
3. keep Stage-3 scoring/profile configuration fixture-local/pinned for Slice 1 rather than requiring a general runtime configuration/persistence framework.

Several superficially "large" requirements should **not** be cut: typed persistent identity, central proposal/revalidation/commit semantics, exact response/personal scoring, semantic decision history, deterministic fallback disclosure, and the lower-level relation family `VS-SFL-090`–`099`. Under the currently accepted Stage-3 contract, those are proof obligations, not decorative complexity.

## 2. Detailed findings

### TRES-0010I-F01 — Slice-1 acceptance range includes a household/head-only card

- **Classification:** unnecessary scope / acceptance-criteria contradiction
- **Severity:** `HIGH_REPAIR_BEFORE_CODE`
- **Evidence:**
  - `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` §1 says Slice 1 executes lower-level acceptance cards **without implementing household identity/recognition yet**.
  - IMP-0001 §4 explicitly excludes CandidateOrganization, Household, participation warrants, household recognition, head recognition, head role, household-mode action, provision, and lineage.
  - IMP-0001 §6 nevertheless lists executable coverage for `VS-SFL-100` through `VS-SFL-105` "at minimum."
  - `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`, `VS-SFL-104`, requires an **Active H**, valid current head P, a household-mediated marriage proposal, and role-scoped head authority.
  - `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`, `SCORE-RP-005`, exists specifically for such role-scoped household/head response.
  - IMP-0001 §6 later says cards that explicitly require household semantics remain unimplemented and must not be faked.
- **Smallest failure trace:**
  1. An implementation agent follows the literal "VS-SFL-100 through 105" minimum.
  2. It reaches VS-SFL-104.
  3. To make that card executable it must either implement Household/head authority early, fixture-write/fake those endogenous results, or declare the acceptance list unsatisfied.
  4. The first two violate IMP-0001 §4 and fixture discipline; the third violates the literal minimum acceptance list.
- **Why existing authority does / does not answer it:** the later "household cards remain unimplemented" sentence reveals the intended answer and protects semantics, but it does not remove the contradictory scenario-range requirement. A careful coder can infer the intended exception; an exact packet follower should not have to.
- **Consequence if ignored:** premature Household/head scaffolding, fake acceptance setup, or needless escalation during the very first implementation slice.
- **Recommended disposition:** amend IMP-0001 §6 to require `VS-SFL-100`–`103` and `VS-SFL-105` for Slice 1, explicitly deferring `VS-SFL-104` and `SCORE-RP-005` to the slice that owns household/head semantics. This changes no accepted Stage-3 claim; it only assigns that existing claim to the correct implementation slice.
- **Confidence:** high.

### TRES-0010I-F02 — Full cross-cutting mutant ledger can be misread as an immediate Slice-1 build requirement

- **Classification:** unnecessary scope / verification weakness
- **Severity:** `MEDIUM_AMEND_OR_GUARD`
- **Evidence:**
  - `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` §4 defines a 30-item semantic mutant set spanning household formation, recognition, provision, head authority, lineage, checkpointing, information flow, tracing, and lower-level resolution.
  - The same section explicitly permits mutant outcomes including **`unexercised`**.
  - IMP-0001 §6 requires only **applicable** boundary/metamorphic/mutant checks.
  - IMP-0001 §7 asks for "no-surviving relevant semantic mutant where the slice claims coverage."
  - IMP-0001 §4 excludes the household, lineage, checkpoint/save-load, and broader recognition semantics covered by many cross-cutting mutants.
- **Smallest failure trace:**
  1. The implementer sees the canonical cross-cutting mutant set as an imported requirement.
  2. Instead of classifying household/checkpoint/recognition mutants as out-of-slice `unexercised`, it tries to make every mutant executable.
  3. That pressure creates either a general mutation framework or early semantic substrate solely to host tests for later slices.
- **Why existing authority does / does not answer it:** "applicable," "relevant," and the `unexercised` classification are enough to preserve the intended semantics, but the implementation packet never states the minimal Slice-1 interpretation explicitly.
- **Consequence if ignored:** verification infrastructure becomes a second project before the first reference kernel exists, and later-slice concepts leak into Slice 1.
- **Recommended disposition:** state in IMP-0001 that out-of-slice cross-cutting mutants are validly reported as `unexercised` and do not block Slice-1 completion; require only lower-level-family mutants plus cross-cutting mutants whose defect class is actually claimed by Slice 1. Do **not** make a general mutation-testing framework an implicit requirement.
- **Proof obligation preserved:** the cross-cutting contract still receives a classification for every mutant, and every semantic area actually claimed by Slice 1 remains challengeable.
- **Confidence:** high.

### TRES-0010I-F03 — Generated-history/shrinking and held-out materialization are safe to defer from IMP-0001

- **Classification:** unnecessary scope
- **Severity:** `MEDIUM_AMEND_OR_GUARD`
- **Evidence:**
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §5 says generated tests **supplement** canonical cards and says failures are shrunk/minimized **where tooling supports it**.
  - §8 says held-out variants "**may be materialized by the verification harness ... after the implementation path exists**."
  - IMP-0001 §6–§7 requires canonical scenario coverage, applicable boundary/metamorphic/mutant checks, deterministic repeated runs, one iteration-order permutation, one fallback-sensitivity check, fixture audit, and relevant mutant evidence. It does not name generated-history generation, shrinking, or held-out materialization as completion criteria.
- **Smallest failure trace:**
  1. A coder treats the whole cross-cutting contract as immediate harness scope.
  2. Before the first lower-level kernel is proven, it builds validity-aware sequence generation, seed retention, shrinking/minimization, held-out recipe expansion, and regression-fixture promotion.
  3. None of that is required to make the first canonical Slice-1 proof claims true.
- **Why existing authority does / does not answer it:** the cross-cutting contract already makes deferment safe; the implementation packet simply does not say so explicitly.
- **Consequence if ignored:** early framework-building and test-harness surface area that delays the first runnable semantic oracle.
- **Recommended disposition:** add an IMP-0001 note that generated histories/shrinking and held-out materialization are not Slice-1 completion criteria; preserve the canonical recipes/contracts for later verification hardening once the reference path exists.
- **Proof obligation preserved:** canonical cards, relevant invariants, metamorphic checks, and mutant challenges remain mandatory; only supplemental breadth is deferred.
- **Confidence:** high.

### TRES-0010I-F04 — Scoring/profile configuration can remain fixture-local/pinned in Slice 1

- **Classification:** unnecessary scope
- **Severity:** `MEDIUM_AMEND_OR_GUARD`
- **Evidence:**
  - `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md` identifies the profiles as **verification/laboratory configuration, not independent social semantics**, and says their numeric preferences are not historical calibration or a claim that they survive later iteration.
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §11 likewise treats exact reference scoring as a controlled v0 choice rather than permanent doctrine.
  - IMP-0001 requires exact named integer components, profile/version traceability, and the in-scope profiles, while explicitly excluding production persistence/storage architecture.
  - IMP-0001 §8 permits serialization representation for **test fixtures/config only** and says to prefer minimal dependencies.
- **Smallest failure trace:**
  1. The implementer sees "configuration/profile version" as a request for a general runtime configuration subsystem.
  2. It adds dynamic loading/registry machinery, persistence/version-migration concerns, or extensibility mechanisms before any current scenario requires them.
  3. Canonical tests still only need a pinned exact profile and a recorded identifier/version.
- **Why existing authority does / does not answer it:** the authority clearly separates verification configuration from social semantics, but the minimal allowed implementation shape is not made explicit.
- **Consequence if ignored:** framework generalization before evidence exists that runtime-configurability is needed.
- **Recommended disposition:** state that, for IMP-0001, the canonical scoring profiles may remain pinned/fixture-local configuration so long as production decision code consumes the real profile values, the exact `ProfileId`/version is recorded in history, gates cannot be waived, and the independent oracle still sums recorded components itself. Do not require runtime profile loading, persistence, migration, or plugin infrastructure in Slice 1.
- **Proof obligation preserved:** every closed-loop card still runs through the production scorer using the exact canonical profile; trace/version and independent-oracle requirements remain intact.
- **Confidence:** medium-high.

## 3. Complexity that appears large but must remain

### 3.1 Persistent typed identity and resolvable references

**Keep.** DEC-0001 makes persistent individuals, relationships/claims, and historical legibility foundational. IMP-0001 also needs stable identity to keep semantic history resolvable and to quarantine the deterministic technical-ID fallback. Replacing this with transient collection positions or content-derived identity would weaken both the architecture and determinism proof.

### 3.2 Central proposal → response → resolution → precommit revalidation → commit/reaction closure

**Keep.** This is the mechanism that makes `Declined`, `Unable`, and `InvalidatedAtResolution` observably distinct; prevents one actor from directly mutating another; supports same-snapshot response decisions; and proves that proposed-but-uncommitted effects do not become facts. It is not framework decoration.

### 3.3 Full decision/semantic history for the slice

**Keep.** DEC-0001 treats causal observability/historical legibility as architectural. Stage-3 cards also need to distinguish "not generated," "gated out," "scored and lost," "selected but invalidated," and "committed." A result-only event log would destroy accepted explainability claims.

### 3.4 Exact deterministic personal/response scorer

**Keep.** The response family specifically proves that a counterparty remains an autonomous decision-maker and that target response is not silently embedded in initiator logic. A fixture-scripted accept/decline shortcut would weaken a core accepted Stage-3 claim.

### 3.5 Lower-level mechanics in `VS-SFL-090`–`VS-SFL-099`

**Keep under the current accepted Stage-3 contract.** Grain/need, transfer meaning, debt, favour, direct marriage, residence, attitude maintenance, personal-initiative accounting, and scorer-boundary cases all have canonical accepted cards. Even where one mechanic is not strictly necessary to demonstrate the abstract phrase "individual → relationship → household," removing it from IMP-0001 would weaken the currently accepted lower-level Stage-3 verification surface, which this task is not authorized to do.

### 3.6 Canonical root commands, CI, and protected acceptance surface

**Keep.** These are modest engineering seams that make the proof repeatable and prevent later implementation agents from silently weakening expected semantics. The stronger administrative repository-protection mechanism is already optional when disproportionate, so the packet has an appropriate minimality escape hatch.

## 4. IMP-0001 scope cuts worth considering

The actionable cuts are narrow:

1. change the response-family acceptance list from `VS-SFL-100..105` to `VS-SFL-100..103` + `VS-SFL-105`; defer `VS-SFL-104`/`SCORE-RP-005`;
2. explicitly allow out-of-slice cross-cutting mutants to remain `unexercised`;
3. explicitly defer generated-history/shrinking and held-out materialization;
4. explicitly permit pinned fixture-local profile configuration rather than a general configuration framework.

No cut is recommended to the actual accepted lower-level social semantics, deterministic transition path, trace requirements, or canonical Slice-1 lower-level cards.

## 5. Attempted attacks that did not expose a defect

### Attack A — Premature checkpoint/persistence infrastructure

I tried to show that exact continuation requirements would force save/load architecture into Slice 1.

**Result:** no defect. IMP-0001 §3.3 explicitly says a full generic delayed-process/checkpoint system is not required; §4 excludes checkpoint/save-load and production persistence/storage. Requiring future-influencing state to be explicit/serializable **in principle** is a legitimate seam, not implementation scope.

### Attack B — Premature scaling/concurrency/general optimization

I tried to show that future-scale concerns had leaked into the first kernel.

**Result:** no defect. IMP-0001 explicitly excludes production storage architecture, parallelism/concurrency, stochastic behavior, optimization beyond local hygiene, and broad frameworks/dependencies. This matches the roadmap rule: smallest faithful next step; specialize only after evidence.

### Attack C — The lower-level relation set is broader than the household-emergence demonstration needs

I tested whether Debt, Favour, direct marriage, residence, attitude cadence, or personal/response distinctions could simply be removed from Slice 1.

**Result:** not a safe simplification under current authority. `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` gives those meanings explicit canonical Stage-3 acceptance claims (`VS-SFL-090`–`099`). Cutting them here would weaken accepted verification, violating this task's boundary.

### Attack D — `VS-SFL-070/071/073/074` force household/provision machinery

I checked the extra resolution/reaction cards imported by IMP-0001.

**Result:** no blocker. IMP-0001 already says "where their required substrate is available" and "relevant non-household cases." The cards have valid lower-level instantiations: material ability for `070`, conflicting personal capacity for `071`, bounded lower-level failure reasons for `073`, and accepted-gift attitude reaction for `074`. They do not require household semantics when scoped as written.

### Attack E — Deterministic fallback / observer noninterference are aesthetic over-verification

I tested whether stable-ID fallback disclosure and observer/trace noninterference could be deferred.

**Result:** no. They protect two accepted architectural seams: nonsemantic container order must not become causal order, and observability must not alter semantics. The tests are small and directly defend the reference oracle.

## 6. Undetermined / deliberately not assessed

- No implementation exists on the frozen baseline, so code-level abstraction excess cannot yet be measured.
- Exact .NET analyzer/package minimality was not assessed; the task's first-pass restriction did not call for the C# engineering guardrail document, and no identified finding required opening it.
- No prior TRES-0003–0009 report was opened to check whether these findings duplicate earlier adversarial work. This preserves the independent-context objective; deduplication can be performed during Master Architect reconciliation.
- No sibling TRES-0010 Wave-A return was opened.

## 7. Final recommendation

**`AMEND BEFORE IMPLEMENTATION`**

Repair F01 before dispatch because the current scenario-range wording can directly pull household/head semantics into Slice 1. Add the F02–F04 scope guards while touching the packet; they are cheap clarifications that preserve every accepted semantic claim while reducing the risk of verification/configuration framework-building.

After those amendments, this review found no scope/minimality reason to block the first lower-level implementation slice.
