# TRES-0010D-SENTINEL — Blind Verification-Cheat Replication

## Run provenance

- **Task ID / role:** TRES-0010D-SENTINEL / D-SENTINEL blind verification-cheat replication
- **Canonical baseline:** tres-0010-review-baseline
- **Resolved canonical baseline SHA:** 8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac
- **Wave-B dispatch baseline:** tres-0010-wave-b-baseline
- **Return branch/workspace:** tres-0010/wb-sentinel-d
- **Model/configuration:** GPT-5.6 Sol; reasoning configuration not otherwise exposed
- **Tools used:** GitHub repository connector for repository discovery, branch lookup, exact-ref file retrieval, baseline/return-branch comparison, and return-file creation
- **External web research:** no
- **Prior TRES-0003–0009 reports read:** no
- **Assigned Wave-A reports read:** none; sentinel packet assigns none
- **Original TRES-0010D report read:** no
- **Any other Wave-A report/return read:** no
- **Opposing Wave-B return read before completion:** no
- **Unrelated Wave-A returns read:** no
- **Master Architect Wave-A synthesis read:** no

This report was produced from scratch from the required frozen inputs. Findings were locked before any comparison with an earlier D review; no such comparison was performed.

## Executive finding summary

The Stage-3 verification design is strong at the semantic-card level. It explicitly blocks direct fixture writes of the main endogenous results, forbids obvious production-oracle reuse, separates response feasibility from voluntary choice, requires causal history rather than terminal snapshots alone, classifies mutant crash/timeout separately from semantic detection, and contains useful metamorphic checks for ID/order/observer/cache behavior.

The remaining attack surface is concentrated at the boundary where the prose verification authority becomes executable acceptance authority.

I found one blocker and three additional pre-code verification weaknesses:

1. **D-SENT-001 — first-author oracle problem:** the same implementation agent is authorized to create the initial executable acceptance surface and test helpers. The written independence rules prohibit calling production helpers, but they do not make the first executable translation independent of the implementation. A wrong production rule and a separately copied wrong test rule can agree and pass.
2. **D-SENT-002 — no frozen execution-completeness manifest:** IMP-0001 asks for scenario IDs and passing tests, but does not mechanically bind each required card to all of its subcases, companions, metamorphic applications, and mutant obligations. A hostile implementer can create a test bearing a canonical scenario ID while omitting the difficult assertions/subcases.
3. **D-SENT-003 — held-outs are visible recipes, not protected evaluation cases:** the “held-out” strategy is disclosed to the implementation agent and may be materialized by the same harness after implementation exists. This substantially limits its value against deliberate canonical-card/profile overfitting.
4. **D-SENT-004 — generated-history validity may be circular:** generated histories must be validity-aware, but the contract does not prohibit the generator from asking production candidate/feasibility logic what is valid. An over-restrictive production gate can therefore erase its own counterexamples from generated testing.
5. **D-SENT-005 — downstream verified-checkpoint provenance is asserted, not mechanically chained:** later Stage-3 cards may begin from “previously verified” checkpoints containing endogenous facts, but the package does not require the consuming harness to prove that the checkpoint came from a passing producer run with a clean fixture-write audit. This is a later-slice guard, not an IMP-0001 blocker.

**Recommendation: BLOCK IMPLEMENTATION** until D-SENT-001 and D-SENT-002 are closed at the executable acceptance boundary. D-SENT-003 and D-SENT-004 should also be repaired before IMP-0001 is dispatched because they are specifically meant to prevent an implementation from coding to known fixtures. D-SENT-005 can be guarded before the first household/continuity slice consumes verified checkpoints.

---

## Detailed findings

### D-SENT-001 — Initial executable acceptance translation is not independent

- **Classification:** verification weakness
- **Severity:** BLOCKER_BEFORE_CODE
- **Confidence:** high

#### Exact evidence

- plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md §9, “Independent oracle rules,” correctly forbids independent checkers from calling production candidate recognition, continuity/lineage classification, the scorer/selector under judgment, the transition helper whose output is asserted, or the derived-capacity helper when capacity arithmetic is under test.
- The same section nevertheless defines independence primarily as a call/dependency boundary; it does not require independent authorship or an already-frozen executable expectation layer.
- tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md §1 requires the implementer to leave a protected acceptance-test surface.
- IMP-0001 §3.1 explicitly commissions the implementation work to create the canonical SFL acceptance tests and deterministic fixture/harness.
- IMP-0001 §6 says that **once established**, implementation tasks may not weaken/delete/rewrite expected semantics. That protects the surface after first creation, but does not independently constrain the first translation.
- IMP-0001 §8 leaves the test framework and test-helper APIs to the implementation agent.

#### Smallest cheating implementation

Implement debt social-due timing incorrectly as N+2 rather than the semantic N+3 rule.

Then, while creating the first executable translation of VS-SFL-092, implement a test-side expected-state helper that independently but incorrectly computes the same N+2 deadline. The checker never calls the production debt scheduler or transition helper, so it can satisfy the literal non-reuse rule. The test is named for the canonical scenario, the production and oracle agree, CI is green, and the completion report can list VS-SFL-092 as implemented.

The same pattern works for a comparator error, such as a copied wrong reserve boundary, without direct production-helper reuse.

#### Serious disconfirmation attempt

The textual card itself is not ambiguous: LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md VS-SFL-092 states the N+3 due review, and SPEC-SFL-0001 §3.3/§9 states the same semantic rule. An honest independent reviewer comparing executable assertions with the prose authority would catch the mistranslation.

That does not close the hostile-implementer hole because the accepted artifacts do not require such a reviewer or a separately controlled executable expectation layer before the implementation agent establishes the surface.

#### Why existing authority does not answer it

The package prohibits **runtime oracle circularity**, but not **translation circularity**. Two separately written functions can embody the same wrong interpretation. The “protected acceptance surface” becomes protected only after the potentially self-confirming first author has created it.

#### Consequence if ignored

A semantically wrong implementation can become the de facto executable oracle while apparently complying with:
- independent-helper non-reuse;
- canonical scenario naming;
- CI;
- protected-surface rules;
- passing acceptance tests.

That defeats the purpose of Stage-3 as implementation acceptance authority.

#### Minimum additional guard

Before IMP-0001 production code is dispatched, freeze an implementation-independent executable expectation/acceptance layer for the Slice-1 semantic claims, or require independent review/ownership of the expected semantic assertions and oracle code. The implementation agent may build adapters/harness plumbing, but must not be the sole author/approver of both the production behavior and the expected semantic result.

---

### D-SENT-002 — No frozen execution-completeness manifest prevents partial/trivial “coverage”

- **Classification:** verification weakness
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Confidence:** high

#### Exact evidence

- IMP-0001 §6 requires executable coverage “at minimum” for VS-SFL-090..099, VS-SFL-100..105, selected VS-SFL-07x cards, and applicable cross-cutting checks.
- IMP-0001 §7 requires a completion report listing implemented scenario IDs and several categories of evidence.
- IMP-0001 §6 also requires CI to run the acceptance surface.
- CROSS_CUTTING_VERIFICATION_CONTRACT.md §7 requires reporting canonical cards, boundary variants, metamorphic pairs, semantic mutants, generated histories, and held-out variants separately.
- None of those sections establishes a frozen machine-readable manifest binding each required scenario ID to every mandatory subcase/assertion/companion, nor a zero-missing/zero-skipped rule for the acceptance runner.

#### Smallest cheating implementation

Create one test named VS-SFL-094 and exercise only the successful called-favour fulfilment path. Omit:
- voluntary refusal;
- impossible requested action;
- reciprocal cancellation;
- one or more required causal/history assertions.

The implementation can still:
- report “VS-SFL-094 implemented”;
- run all discovered tests;
- show a green CI result;
- preserve the test name and protected surface.

A still simpler version marks an uncomfortable companion skipped/not-discovered while leaving the scenario ID present elsewhere.

#### Serious disconfirmation attempt

The prose card is detailed enough that a careful human can identify the omission, and IMP-0001’s phrase “coverage exists” should normatively mean the whole card, not merely the label.

However, the requested completion evidence is ID-oriented and test-run-oriented. It does not provide an acceptance mechanism that proves that every mandatory subcase and cross-cutting obligation actually executed. A hostile completion report can therefore be green while semantically incomplete.

#### Why existing authority does not answer it

A canonical prose card defines what **should** be covered; it does not itself prove executable discovery/completeness. CI only proves that discovered tests passed. The current package has no frozen execution ledger against which missing or skipped required cases automatically fail.

#### Consequence if ignored

Selective under-testing can masquerade as full canonical coverage. This makes every other verification rule easier to evade because the hostile implementer can simply decline to instantiate the subcase that would expose the defect.

#### Minimum additional guard

Freeze a required-case manifest before code:
- canonical card IDs;
- mandatory subcases/companions;
- required applicable metamorphic relations;
- required semantic mutant checks;
- required held-out/generated categories where applicable.

The acceptance runner must fail on missing, duplicate-substituted, skipped, or unexecuted required entries, and completion evidence should report manifest coverage rather than only scenario labels.

---

### D-SENT-003 — “Held-out” cases are disclosed recipes controlled by the implementation context

- **Classification:** verification weakness
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Confidence:** medium-high

#### Exact evidence

- CROSS_CUTTING_VERIFICATION_CONTRACT.md §7 distinguishes held-out variants from canonical cards.
- §8 openly gives concrete held-out recipes for formation, continuity, recognition, provision, head/dual-mode, lineage, resolution, checkpoint, and lower-level fabric.
- §8 says held-out instances may be materialized by the verification harness after the implementation path exists.
- IMP-0001 §2 requires the implementation agent to retrieve the cross-cutting contract, so the held-out recipes are in the implementation context.
- IMP-0001 does not require that any concrete held-out materialization be created or controlled outside the implementation agent/harness.

#### Smallest cheating implementation

Implement the canonical Slice-1 lower-level cases correctly for the known actor/value/topology patterns and the disclosed held-out recipe dimensions, but leave a semantically equivalent unadvertised combination wrong.

Example: make called-favour fulfilment work for the ordinary action type used in the canonical VS-SFL-094 executable test and for the known variant chosen by the same harness, while incorrectly rejecting another otherwise-feasible ordinary action type (for example, a residence-change proposal) that is permitted by SPEC-SFL-0001 §3.4.

A hostile implementation does not need literal scenario-ID branching. It can specialize on visible profile IDs, actor counts, amounts, relation topology, or the exact action families selected by the disclosed recipes.

#### Serious disconfirmation attempt

The package makes simple fixture overfit materially harder:
- CROSS_CUTTING §3 requires nonsemantic ID renaming;
- storage/input iteration permutation is required;
- disconnected-population locality is required;
- irrelevant-attribute perturbation exists;
- held-out recipes vary topology/critical actors/threshold-adjacent values.

Those are real protections against naïve hard-coding.

They do not create an actually independent held-out evaluation because the implementer knows the recipe family and may control materialization.

#### Why existing authority does not answer it

“Not the primary implementation narrative” is weaker than “not available to the implementation under test.” The current artifacts protect semantic meaning but do not protect at least one concrete evaluation instance or seed from fixture-specific coding.

#### Consequence if ignored

Canonical/held-out success provides weaker evidence against deliberate overfitting than the terminology implies. This is especially important because Stage-3 is explicitly intended to be hard to satisfy by coding to fixtures.

#### Minimum additional guard

Keep at least some concrete held-out materializations (or deterministic seeds plus expected classifications) outside the implementation agent’s context and run them independently after the implementation path is frozen. Their semantics need not be secret; only the exact evaluation instances need to be unavailable during implementation.

---

### D-SENT-004 — Validity-aware generated histories can inherit production gating defects

- **Classification:** verification weakness
- **Severity:** HIGH_REPAIR_BEFORE_CODE
- **Confidence:** high

#### Exact evidence

- CROSS_CUTTING_VERIFICATION_CONTRACT.md §5 requires bounded generated histories and says to “generate from currently valid preconditions unless intentionally testing failure.”
- The same section does not define where the generator’s validity judgment must come from.
- CROSS_CUTTING §9 places explicit non-reuse restrictions on **independent checkers**, but does not separately prohibit the history generator from using production candidate-generation/feasibility APIs.
- IMP-0001 §8 permits the implementation agent to choose test-helper APIs.
- SPEC-SFL-0001 §3.4 permits a favour to request one otherwise-feasible ordinary action, subject to the explicit impossibility/compulsion limits.

#### Smallest cheating implementation

Suppose production incorrectly treats residence-change proposals as never eligible to satisfy a called favour, while correctly supporting a gift/help action through CallFavor.

The canonical executable VS-SFL-094 can use the gift/help action and pass.

Now let the generated-history helper obtain its operation vocabulary by asking production for currently valid operations/candidates. Because the production defect suppresses the valid CallFavor→residence path, the generator never emits the missing path. Generated histories remain “validity-aware,” all generated runs pass, and the very gate defect that should be discovered controls whether its counterexample can be generated.

This does not require the generator to reuse an assertion-target transition helper, so the current checker prohibition does not clearly exclude it.

#### Serious disconfirmation attempt

Canonical cards are not generated from production validity and can independently force known proposal paths. The cross-cutting operation vocabulary also explicitly includes favour creation/call/refusal/cancellation and residence proposals.

That reduces the exposure, but the vocabulary list does not require cross-product instantiation of valid action meanings. Generated histories are precisely the mechanism expected to explore unusual combinations, so production-filtered generation remains a meaningful blind spot.

#### Why existing authority does not answer it

Independent **checking** and independent **test-input validity generation** are separate problems. The current contract addresses the first much more explicitly than the second.

#### Consequence if ignored

Over-restrictive candidate/gate defects can remove their own witnesses from the generated test space. Stateful/generated testing then provides false confidence exactly where it is supposed to find unusual combinations.

#### Minimum additional guard

Require generated-history input selection/validity classification to be independent of the production candidate/feasibility logic under test, or require a spec-derived operation grammar that deliberately attempts both expected-valid and expected-invalid operations with independently classified expectations.

---

### D-SENT-005 — “Previously verified checkpoint” consumption lacks a mechanical provenance chain

- **Classification:** verification weakness / future-slice coupling
- **Severity:** MEDIUM_AMEND_OR_GUARD
- **Confidence:** medium-high
- **Slice impact:** later household/continuity slices; not required to unblock IMP-0001 by itself

#### Exact evidence

- CROSS_CUTTING_VERIFICATION_CONTRACT.md §6 allows downstream cards to start from a previously verified checkpoint containing endogenous facts.
- CONTINUITY_TURNOVER_FAMILY.md states that its cards begin from a verified checkpoint produced by VS-SFL-001 or an equivalent independently verified formation result.
- The package requires fixture-origin and endogenous facts to remain distinguishable, but does not require a consuming test to validate an immutable provenance link to the exact producer run, producer pass status, or producer fixture-write audit.

#### Smallest cheating implementation

Hand-build or deserialize a checkpoint that already contains:
- Household H;
- FormationWarrant;
- founding SustainingParticipant associations;
- recognition/head history as needed;

then label it as an “equivalent independently verified formation result” and use it as the start state for continuity tests.

The downstream continuity implementation can pass even though the state was not produced through the legal formation path in the run being relied upon.

#### Serious disconfirmation attempt

Formation itself has strong independent canonical tests (VS-SFL-001/002), and the cross-cutting fixture rules explicitly forbid fixture-writing Household/warrants when formation is the outcome under test. So the package does not permit using the hand-built state to pass the formation card itself.

The remaining gap is provenance between separately staged producer and consumer scenarios, not absence of formation verification.

#### Why existing authority does not answer it

“Previously verified” is a semantic requirement, but no accepted artifact defines how the consuming harness proves that statement rather than trusting fixture metadata or developer convention.

#### Consequence if ignored

Later-slice tests can accidentally or deliberately validate transitions from a state that no compliant execution can actually produce, weakening end-to-end evidence and permitting fixture laundering.

#### Minimum additional guard

Require any downstream checkpoint containing endogenous results to carry verifiable provenance to:
- the exact producer scenario/run;
- producer baseline/configuration;
- successful producer assertions;
- producer fixture-write audit;
- checkpoint content identity.

Consumption should fail if that provenance cannot be validated.

---

## Attacks attempted that did not expose a defect

### A. Direct fixture writing of endogenous outcomes

**Result: substantially robust.**

SPEC-SFL-0001 §1.1 forbids fixture writes of the endogenous results a scenario is intended to prove. CROSS_CUTTING §6 repeats the restriction for Household, warrants, lifecycle verdict, head results, provision-spend results, and endogenous recognition. Individual family cards restate the rule. A straightforward “preload the answer and assert it” attack is explicitly disallowed.

Residual downstream-checkpoint provenance is reported separately as D-SENT-005.

### B. Direct production-oracle reuse

**Result: substantially robust against literal helper reuse.**

CROSS_CUTTING §9 explicitly forbids independent checkers from calling the production candidate recognizer, continuity/lineage classifier, scorer/selector being judged, transition helper whose output is the assertion target, or derived-capacity helper when that arithmetic is under test. It encourages hand-authored facts, simple arithmetic, warrant references, and metamorphic checks.

The surviving issue is not direct reuse; it is first-author/copy-of-the-same-misinterpretation risk (D-SENT-001).

### C. Profile configuration bypassing categorical gates

**Result: robust in the stated design.**

REFERENCE_SCORING_PROFILES.md §3 says configuration cannot waive categorical semantic gates or create an action meaning absent from the spec. Closed-loop cards require production candidate generation/gates to expose candidates and prohibit the fixture from injecting candidates or final scores. RESPONSE_DECISION_FAMILY.md also requires infeasibility before scoring.

### D. Final-snapshot-only tests that ignore causal history

**Result: robust in the stated design.**

The verification README requires causal ordering and intermediate history inspection where relevant. Family cards repeatedly assert warrant/event provenance. SPEC-SFL-0001 §9.4 and IMP-0001 §3.7 require complete decision and consequential history, including causal predecessor references, failure semantics, ReactionIndex, and fallback markers.

### E. Mutants that “pass” by crashing or timing out

**Result: explicitly closed.**

CROSS_CUTTING §4 requires mutant outcomes to distinguish detected, survived, unexercised, invalid/equivalent, crash, and timeout, and states that crash/timeout do not automatically count as semantic detection.

### F. Hidden collection order / raw actor-ID choice

**Result: materially hardened.**

CROSS_CUTTING §3 requires storage/input iteration permutation and nonsemantic ID renaming, with explicit exception only for disclosed technical fallback sensitivity. DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md VS-SFL-081 isolates and records the fallback rather than presenting it as social preference.

This does not by itself solve fixture/profile overfit, addressed in D-SENT-003.

### G. Observer/instrumentation changing semantics

**Result: robustly targeted.**

CROSS_CUTTING §3 requires observer/diagnostic noninterference. DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md VS-SFL-085 requires equivalent state/history with diagnostics enabled and disabled and explicitly forbids query/rendering side effects on recognition, IDs, caches, or scheduling.

### H. Checkpoint/rebuild self-comparison as the only recovery evidence

**Result: stronger than a simple self-comparison.**

VS-SFL-082 requires exact authoritative suffix equality; VS-SFL-083 deliberately omits future-influencing state classes one at a time and requires semantic mismatch detection; VS-SFL-084 separately rebuilds derived state and challenges stale-cache influence. This is materially stronger than only serializing and deserializing through the same code and comparing the result.

The remaining checkpoint concern found here is producer/consumer provenance (D-SENT-005), not the suffix/rebuild design itself.

---

## Undetermined / bounded conclusions

1. This sentinel did not inspect any executable test code because IMP-0001 is not yet dispatched on the frozen review baseline. Findings concern whether the **accepted verification design and implementation packet** can prevent a hostile future translation from self-confirming.
2. No conclusion is made about repository- or organization-level branch protection beyond what IMP-0001 states. The task’s required context is the Stage-3 package, semantic spec, and IMP-0001.
3. No social-model change is proposed. All surviving findings are verification/acceptance-boundary issues.

## Recommendation

**BLOCK IMPLEMENTATION**

Before dispatching IMP-0001, close at least:

- D-SENT-001 by making the initial executable expectation/oracle surface independent of the production implementer; and
- D-SENT-002 by freezing an execution-completeness manifest that makes omitted/skipped/trivialized canonical obligations visible.

D-SENT-003 and D-SENT-004 should be repaired in the same pre-code hardening pass because they directly address canonical-card overfit and self-filtered generated testing. D-SENT-005 may be scheduled before the first later slice that consumes endogenous verified checkpoints.

**Advisory only.**
