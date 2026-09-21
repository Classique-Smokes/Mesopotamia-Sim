# TRES-0010D — Verification-System Cheat Red Team Report

## Run provenance

- **Task ID:** TRES-0010D
- **Frozen baseline ref:** `tres-0010-review-baseline`
- **Resolved baseline commit SHA:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Model/configuration:** GPT-5.6 Sol; exact hidden reasoning-effort configuration not exposed
- **Dedicated branch/workspace:** `tres-0010/d`; branch was verified identical to the frozen baseline before review
- **Tools used:** GitHub repository connector for branch comparison, canonical file reads, and this isolated return write
- **External web research:** no
- **Prior TRES-0003–0009 findings read:** no
- **Sibling Wave-A returns read before initial report:** no
- **Canonical project files modified:** no

## 1. Executive finding summary

**Recommendation: BLOCK IMPLEMENTATION.**

The Stage-3 verification design is substantially stronger than an ordinary example-based suite: it has explicit fixture-write restrictions, independent-oracle rules, metamorphic relations, semantic mutants, boundary matrices, causal history, response/failure distinctions, observer noninterference, and checkpoint/rebuild checks.

However, the current pre-code handoff still contains a blocker-level verification-governance hole: **IMP-0001 asks the implementation task itself to create the first executable acceptance surface and harness, while no protected executable grader or mechanically complete assertion manifest exists on the frozen baseline.** SCF-002 says that protected acceptance verification must fire, but the accepted artifacts do not yet specify a concrete mechanism that prevents the implementation agent from under-translating the prose cards into weak tests. A semantically defective implementation can therefore make its own acceptance suite green without literally editing an already-protected test.

Five additional weaknesses make that self-certification path easier: oracle independence is normative rather than mechanically enforced; profile IDs/target bindings can become an overfitting channel; the published "held-out" recipes are neither hidden nor required as independent completion evidence; cross-cutting checks lack a closed applicability/coverage matrix; and later checkpoint omission tests can pass when an omitted field is not causally exercised by the chosen suffix.

The blocker is not that the Stage-3 cards are weak. It is that the **translation from accepted prose to executable authority is still under the control of the candidate implementation task**.

## 2. Detailed findings

### T10D-001 — The implementation task can author its own grader

- **Classification:** verification weakness
- **Severity:** `BLOCKER_BEFORE_CODE`
- **Evidence:**
  - frozen baseline `tests/` contains only `.gitkeep`; no executable acceptance authority exists yet;
  - `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` §3.1 requires the implementation task to create unit/mechanism tests, canonical SFL acceptance tests, and the deterministic harness;
  - IMP-0001 §6 requires executable coverage, but its protected-surface fallback explicitly permits enforcement by repository instructions, task scope, test separation, and CI if stronger protection is unavailable;
  - `registers/SCAFFOLDING_TRIGGER_REGISTER.md` SCF-002 is only **ARMED** and says to prevent weakening with independent/protected checks "where consequence warrants"; it does not define the concrete protected evaluator that will judge IMP-0001;
  - `AGENTS.md` forbids weakening acceptance tests, but there are no executable acceptance tests to weaken yet.
- **Smallest cheating implementation / failure trace:**
  1. create tests named for every required scenario ID;
  2. faithfully exercise the public kernel boundary but assert only a subset of each card, e.g. for `VS-SFL-093` assert only "at most one favour per ordered pair" and omit the +74/+75 gate and genuine-gift negative control;
  3. implement a defective transfer rule that creates a favour after every accepted beneficial transfer;
  4. all authored tests and CI pass; completion report truthfully lists the scenario IDs as "implemented".
- **Why existing authority does not answer it:** the prose specification says what a valid test should prove, but nothing on the frozen baseline independently verifies that the newly authored executable test contains every required assertion, ablation, mutant, and causal-order check. The same task creates both candidate and executable judge.
- **Consequence if ignored:** a green Stage-4 acceptance signal is not strong evidence that the implementation satisfies the Stage-3 verification contract.
- **Minimum repair / disposition:** before IMP-0001 dispatch, materialize a protected evaluator or at minimum a frozen machine-checkable acceptance manifest outside the implementation task's editable surface. It should enumerate card assertion IDs, negative controls, required metamorphic companions, and relevant mutants, and the completion check should run that frozen evaluator/manifest against the candidate branch. The implementation task may add tests, but must not be the sole author of the authority that decides completion.
- **Confidence:** high.

### T10D-002 — Oracle independence is a prose rule, not an enforced dependency boundary

- **Classification:** verification weakness
- **Severity:** `HIGH_REPAIR_BEFORE_CODE`
- **Evidence:**
  - `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` §9 correctly forbids independent checkers from calling production candidate recognizers, continuity/lineage classifiers, decision scorers/selectors, target transition helpers, or derived-capacity helpers;
  - IMP-0001 §8 leaves test-helper APIs and internal proposal/transition structure to the implementation agent;
  - IMP-0001 §7 requires fixture audit and mutant evidence but does not require an **oracle dependency audit** or prove that oracle code has no production semantic dependency.
- **Smallest cheating implementation / failure trace:**
  1. place a faulty eligibility/scoring/transition calculation in a shared "semantics helper" assembly;
  2. production calls it;
  3. the acceptance checker or generated-history oracle also calls it to derive expected eligibility/result;
  4. both agree on the same wrong answer, so the assertion passes.
  
  Renaming the helper or placing it in a neutral/shared namespace does not change the circularity.
- **Why existing authority does not answer it:** the rule is semantically clear, but no accepted artifact requires a one-way project dependency, a forbidden-reference check, or completion evidence showing that oracle code is structurally independent.
- **Consequence if ignored:** generated/held-out checks can become self-confirming even when canonical hand-authored examples look correct.
- **Minimum repair / disposition:** require the protected oracle/checker project to depend only on stable test DTO/history/schema plus simple constants/arithmetic, not on the production kernel or a shared semantic-rule library. Add a CI/dependency check and include its result in IMP completion evidence.
- **Confidence:** high.

### T10D-003 — Profile IDs and target bindings can become an overfitting/gate-bypass channel

- **Classification:** verification weakness
- **Severity:** `HIGH_REPAIR_BEFORE_CODE`
- **Evidence:**
  - `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md` defines a small fixed set of named `ProfileId` values and allows bindings such as `TargetBride`, `GiftTarget`, and `NeedRecipient`;
  - the same file states that bindings may not inject candidates or bypass production generation/gates, and `SPEC-SFL-0001` §5 requires candidate generation/gates before scoring;
  - current metamorphic requirements rename domain IDs and collections, but no required test renames a profile ID while preserving identical component rules, nor proves that candidate generation is invariant to scoring-profile identity/weights;
  - IMP-0001 §3.4 asks the implementation task to implement both candidate generation and these exact profiles.
- **Smallest cheating implementation / failure trace:**
  - response scorer:
    - if `ProfileId == SCORE-RP-001`, return Accept and emit the expected 100/0 trace;
    - if `SCORE-RP-002`, return Decline;
    - if `SCORE-RP-003`, return Fulfil;
    - if `SCORE-RP-004`, return Refuse;
    - otherwise use a broken/non-generic scorer.
  - personal candidate generation similarly reads `GiftTarget` or `NeedRecipient` and emits the configured target candidate directly instead of discovering it through the ordinary candidate-generation path.
  
  The canonical profile cards can all pass while the required generic component-sum policy or ordinary candidate discovery is wrong.
- **Why existing authority does not answer it:** the text forbids bypass, but no current adversarial companion proves profile-identity independence or freezes the generated candidate set before score configuration is applied.
- **Consequence if ignored:** an implementation can code to the finite Stage-3 profile catalog rather than implement the reference decision mechanism.
- **Minimum repair / disposition:** add at least:
  1. **profile-ID metamorphism:** clone identical component rules under a fresh/renamed profile ID and require identical candidate/gate/selection semantics;
  2. **generation/scoring separation check:** changing score weights/profile identity must not add or remove candidates whose semantic generation inputs are unchanged;
  3. where practical, keep scenario/card IDs entirely harness-side and outside the kernel API.
- **Confidence:** high.

### T10D-004 — Published "held-outs" are visible recipes and are not mandatory independent completion evidence

- **Classification:** verification weakness
- **Severity:** `HIGH_REPAIR_BEFORE_CODE`
- **Evidence:**
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §§7–8 distinguishes canonical, generated, and held-out evidence, but publishes the concrete held-out recipes in the same repository visible to the implementation task;
  - §8 says held-out instances **may** be materialized by the verification harness after the implementation path exists;
  - `SPEC-SFL-0001` §11 requires bounded generated histories and canonical plus held-out/generated variants;
  - IMP-0001 §§6–7 does not explicitly require an evaluator-selected held-out/generated run as completion evidence.
- **Smallest cheating implementation / failure trace:**
  1. special-case the canonical narratives and the fully published held-out recipes;
  2. keep a semantic bug for a novel but valid interaction combination;
  3. run only the canonical suite plus self-selected deterministic examples;
  4. report all required canonical IDs green and no known mutant survivors.
- **Why existing authority does not answer it:** "held-out" currently means "not primary narrative", not "unknown to the implementer". Generated histories are required at the specification level but are not closed as a mandatory IMP-0001 evidence item with evaluator-controlled seeds/cases.
- **Consequence if ignored:** canonical-card overfitting remains viable even after the visible held-out recipes are added.
- **Minimum repair / disposition:** require at least one independently materialized post-implementation variant per major in-scope family plus bounded generated histories selected by the evaluator after the candidate implementation is frozen. Seeds/input sequences should be recorded after execution for reproducibility; minimized failures become public regressions afterward.
- **Confidence:** high.

### T10D-005 — "Applicable" cross-cutting checks have no closed coverage matrix

- **Classification:** verification weakness
- **Severity:** `MEDIUM_AMEND_OR_GUARD`
- **Evidence:**
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §3 defines eight required metamorphic relations and §4 defines thirty semantic mutants;
  - IMP-0001 §6 requires "applicable boundary/metamorphic/mutant checks";
  - IMP-0001 §7 explicitly demands only **at least one** nonsemantic iteration-order permutation and one stable-ID fallback sensitivity check;
  - no accepted file maps every in-scope card/family to required / not-applicable cross-cutting relations and mutants.
- **Smallest cheating implementation / failure trace:** candidate generation wrongly depends on the total disconnected population count. All canonical Slice-1 cards use their expected populations. The implementer runs storage-order permutation as its one metamorphic witness and labels disconnected-population locality "not applicable". Acceptance remains green.
- **Why existing authority does not answer it:** relation definitions are strong, but the implementation handoff does not close the interpretation of "applicable" for the in-scope slice.
- **Consequence if ignored:** a hostile or merely optimistic implementation report can selectively omit the cross-cutting relation most likely to expose its bug.
- **Minimum repair / disposition:** add a Slice-1 coverage matrix listing each cross-cutting metamorphic relation and relevant mutant as REQUIRED or N/A with a reason. Completion evidence must report every REQUIRED item individually.
- **Confidence:** medium-high.

### T10D-006 — Checkpoint omission tests can pass when the omitted state is dormant

- **Classification:** verification weakness
- **Severity:** `DEFERRED_RISK`
- **Evidence:**
  - `SPEC-SFL-0001` §9.6 requires **all** future-influencing authoritative state in checkpoints;
  - `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md` `VS-SFL-082` compares uninterrupted vs restored suffixes;
  - `VS-SFL-083` mutates omission classes but only states that a defective restore **that changes the future** must be detected;
  - the card does not require a continuation that necessarily exercises each omitted class.
- **Smallest cheating implementation / failure trace:**
  - omit identifier/order frontier from serialization;
  - choose a `VS-SFL-083` continuation that creates no new IDs after restore;
  - uninterrupted and restored suffixes remain equal, so the omission is not exposed even though the checkpoint violates §9.6.
  
  The same pattern applies to a rule/profile version that is not consulted again, or a cooldown baseline whose boundary is never crossed in the suffix.
- **Why existing authority does not answer it:** suffix equivalence is necessary but not sufficient when a required field remains causally dormant.
- **Consequence if ignored:** later Slice-5 checkpoint implementation can omit future-influencing state without the intended mutation test proving completeness.
- **Minimum repair / disposition:** for every `VS-SFL-083` omission class, pair the mutant with a continuation that must causally consume that class (new ID allocation, cooldown boundary, pending input, recognition-dependent action, profile/config use, etc.), and add an independent checkpoint-state manifest/field-coverage audit.
- **Confidence:** high.
- **Immediate Slice-1 effect:** none; checkpoint/save-load is explicitly out of scope for IMP-0001. Repair before checkpoint implementation becomes acceptance authority.

## 3. Already-robust areas

The following attacks did **not** expose a defect in the Stage-3 semantics themselves:

1. **Fixture writes endogenous outcomes.** `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §6 and individual cards explicitly prohibit fixture-writing Household identity, warrants, role outcomes, provision results, and other target outcomes. Mechanism-isolation entry is through public proposal/resolution boundaries.
2. **Hard-coded actor IDs / collection order.** Required storage permutation, nonsemantic-ID renaming, disconnected-locality checks, and explicit stable-ID fallback markers make simple actor-ID or container-order cheating difficult when those metamorphic relations are actually executed.
3. **Count a crash/timeout as a mutant kill.** Cross-cutting §4 explicitly separates `detected`, `survived`, `unexercised`, `invalid/equivalent`, `crash`, and `timeout`, and states that crash/timeout do not automatically count as semantic detection.
4. **Assert only final snapshots.** Many core cards require explicit causal ordering, warrant/event references, response-vs-commit distinction, reaction indices, and exact history suffixes; a broad "right endpoint, wrong causal path" implementation should fail a faithful translation.
5. **Collapse failed attempts into one result.** The response/resolution families strongly separate `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)`, including attitude consequences and bounded failure knowledge.

These strengths are why the main recommendation is to protect and independently execute the existing contract, not to redesign its social semantics.

## 4. Falsification routes attempted

At least six materially distinct attack routes were attempted:

- oracle reuse/circularity -> **real enforcement gap found** (T10D-002);
- fixture writes endogenous outcomes -> **blocked by current design**;
- hard-coded actor IDs/container order -> **substantially blocked if required metamorphic relations run**;
- profile/scenario overfitting and candidate-gate bypass -> **real gap found** (T10D-003);
- fake held-outs/canonical overfitting -> **real gap found** (T10D-004);
- crash-only semantic mutants -> **explicitly rejected by current cross-cutting contract**;
- selective omission of cross-cutting attacks -> **real coverage-governance gap found** (T10D-005);
- checkpoint/rebuild self-confirmation -> **future-slice gap found** (T10D-006);
- final-snapshot-only cheating -> **generally blocked by causal-history requirements**, though that protection still depends on faithful executable translation.

## 5. Could not determine from accepted artifacts

The frozen accepted artifacts do not determine:

- the concrete SCF-002 protection mechanism that will exist before/at IMP-0001 dispatch;
- whether acceptance tests will live in a separately protected project/branch or remain editable by the implementation task;
- whether CI will enforce oracle-to-production dependency bans;
- whether scenario/card IDs are guaranteed to remain harness-only and absent from kernel inputs;
- who selects/materializes generated and genuinely held-out cases after candidate implementation is frozen;
- the exact mutation-injection mechanism and who verifies that each mutant was actually activated.

These are verification-governance unknowns, not requests for new social-model semantics.

## 6. Prior TRES / Wave-A independence disclosure

- Prior TRES-0003 through TRES-0009 conclusions read: **none**.
- Some accepted verification files contain references to earlier TRES documents; those references were not followed.
- Sibling TRES-0010 Wave-A returns read before finalizing this report: **none**.

## 7. Recommendation

**BLOCK IMPLEMENTATION.**

Minimum gate-closing condition for this review:

1. concretize SCF-002 **before** IMP-0001 can earn acceptance, so the implementation task is not the sole author/editor of its grader;
2. enforce oracle dependency independence;
3. add profile-ID/generation-separation adversarial checks;
4. make generated/independently materialized held-out evidence mandatory for the in-scope slice;
5. close cross-cutting applicability with an explicit coverage matrix.

T10D-006 may remain deferred to the checkpoint slice if it is recorded now and repaired before checkpoint acceptance is implemented.

This report is advisory evidence only and does not itself modify specification or implementation authority.
