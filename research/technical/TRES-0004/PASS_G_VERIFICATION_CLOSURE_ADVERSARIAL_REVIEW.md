# TRES-0004 — Pass G Verification-Closure Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Narrow review of the proposed SFL v0 Pass G falsifiability contract. This review tests whether the proposed verification obligations are capable of detecting plausible implementation/model-integration defects rather than merely restating expected narratives.

## 1. Baseline reviewed

The review assumes:

- working-converged SFL v0 semantics from Passes A–F;
- the 24 proposed Pass G obligations covering formation, continuity, recognition, collective grounding, role succession, conflict/invalidation, reaction closure, communication provenance, material deadlock, deterministic fallback, continuation, derived-state rebuild, and explainability;
- prior project verification research in TRES-0001F;
- prior Pass F adversarial review in TRES-0003.

## 2. Overall finding

The proposed Pass G scenario set is strong but **not yet sufficient as the entire verification contract**.

No missing foundational social mechanism was found. The main risk is verification circularity: a coherent implementation defect could pass hand-authored narrative scenarios if the test oracle uses the same recognizer, transition helpers, derived projections, or causal explanations as the implementation under test.

The verification contract should therefore combine four evidence forms:

1. explicit canonical scenario cards;
2. independent/mechanically simple oracles and invariants;
3. metamorphic relations across paired executions;
4. semantic mutation/fault-injection challenges.

Bounded generated stateful sequences should supplement, not replace, the canonical scenarios.

## 3. Finding G-A — passing Pass G is verification, not historical validation

The Stage-2/Stage-3 contract can establish that the implementation faithfully realizes the accepted SFL v0 semantics and that those semantics have the intended synthetic consequences.

It does **not** establish that the chosen thresholds, marriage rules, household formation gate, governance rule, or behavior frequencies are historically accurate for Old Babylonian Nippur.

The final acceptance language should say this explicitly.

Agent-based-model validation literature distinguishes implementation/model verification from validation against the target system and intended use. Current project evidence also retains several v0 values as controlled laboratory assumptions.

## 4. Finding G-B — expected outcomes need oracle independence

### Risk

A test can be tautological if it asks the same code that formed a household whether a household should have formed, uses the same derived-capacity helper to assert capacity, or reconstructs the expected causal reason from the implementation's own explanation object.

### Requirement

Canonical scenario expected results must come from:

- accepted specification predicates expressed independently of production transition/recognizer functions;
- simple arithmetic/invariants;
- explicitly hand-authored expected event/state facts;
- or metamorphic relations between executions.

A small independent checker may share domain identifiers/schema but must not call the same decision, recognition, transition, or mutation code whose correctness it is judging.

For difficult emergent assertions, verify supporting lower-level facts and warrants directly rather than treating a rendered household label as the oracle.

## 5. Finding G-C — add metamorphic relations to the contract

The oracle problem is unavoidable for some emergent histories: a complete exact expected trace can overfit one hand-authored story.

Metamorphic testing checks required relations between executions and is specifically useful where exact test oracles are difficult.

Required v0 metamorphic checks should include:

1. **storage/input iteration permutation:** reordering nonsemantic storage/iteration must not change semantic results;
2. **nonsemantic identifier renaming:** semantic results must be isomorphic under ID renaming except in scenarios deliberately reaching the disclosed stable-ID fallback;
3. **disconnected-population locality:** adding an unrelated disconnected group must not rewrite an existing household/recognition result without a modeled causal connection;
4. **observer/diagnostic noninterference:** enabling/disabling inspection, tracing, readers, or derived reporting must not change semantic trajectories;
5. **derived-state rebuild equivalence:** deleting/rebuilding caches/indexes must not change semantic results;
6. **checkpoint metamorphism:** uninterrupted execution and restore/continue from a safe boundary must have identical semantic suffixes;
7. **irrelevant-attribute perturbation:** changing an attribute that the spec declares irrelevant to a decision must not change that decision.

These relations should state explicit applicability conditions; not every permutation is valid when the model intentionally gives order or identity semantic meaning.

## 6. Finding G-D — hard thresholds need boundary matrices

Several v0 semantics depend on exact boundaries. Narrative scenarios are unlikely to expose off-by-one or wrong-comparator defects.

Stage 3 should include just-below / at / just-above checks for at least:

- strong-like gate: +74 / +75 / +76;
- attitude band negative/neutral boundaries where behavior uses them;
- 2-grain protected reserve;
- 1-grain NeedsGrain clearing threshold;
- formation recurrence requirement: 1 qualifying event / 2 on distinct cycles;
- provision reconsideration cooldown boundary;
- attitude-decay cycle boundary;
- marriage once-only and favour one-per-ordered-pair cardinality limits.

Where the threshold is only a controlled assumption, testing proves exact implementation of the assumption, not historical truth.

## 7. Finding G-E — formation/causal ablations must control alternate pathways

### Risk

Removing one formation ingredient from a dynamic scenario does not necessarily isolate that ingredient.

Example: removing an initial strong-like tie may fail to prevent formation because the support events themselves raise attitude enough to recreate strong-like. Removing recognition may fail if the same event sequence communicates or directly exposes the candidate to the actor.

A null result can also hide redundancy: removing one cause may leave another sufficient cause active.

### Requirement

Each causal ablation must declare:

- which mechanism is removed;
- which competing mechanisms are disabled, held fixed, or monitored;
- the exact observation horizon;
- why the contrast isolates the claimed cause.

Where multiple mechanisms can compensate, use crossed/factorial contrasts rather than interpreting a one-factor null effect as evidence of irrelevance.

## 8. Finding G-F — add always-on mechanical invariants

Canonical scenarios should be accompanied by invariants checked after every committed transition / stable reaction closure where applicable.

Minimum v0 invariant families:

### Identity / reference integrity
- all live references resolve to stable entities/relations or retained historical identities;
- no dissolved household produces household-mode actions;
- at most one occupant of a household head role;
- formation/continuation/lineage warrants reference existing historical events.

### Material accounting
- personal grain never becomes negative;
- every grain change is explained by Farm/exogenous source, consumption sink, or a zero-sum transfer;
- household provision never creates duplicate grain;
- protected reserve and NeedsGrain contribution restrictions hold at commit;
- one collective expenditure debits backing grain exactly once.

### Bounded/cardinality rules
- attitude remains within [-100,+100];
- at most one established marriage per person in v0;
- parent/child and sibling pairs never establish marriage;
- at most one outstanding favour per ordered pair;
- fulfilled reciprocal-favour cancellation cannot leave an orphan duplicate favour.

### Temporal / process integrity
- no proposal remains unresolved across a safe cycle boundary unless the spec explicitly defines it as persistent;
- one cause key cannot apply the same automatic reaction twice;
- ReactionIndex is monotone within a cycle;
- safe checkpoint cannot occur mid-reaction closure.

These are mechanical assertions, not historical-social assumptions.

## 9. Finding G-G — supplement canonical cards with bounded stateful sequence generation

Hand-picked stories can miss interaction bugs that arise only after unusual sequences.

Rule/state-machine-based property testing can generate sequences of primitive operations and check invariants after each step. Hypothesis documentation describes this pattern explicitly; equivalent tooling can be selected for C# later.

For SFL v0, generated histories should be **bounded and validity-aware**, using operations such as:

- farm;
- gift/loan/repay;
- favour creation/call/refusal/cancellation;
- residence proposal;
- provision acceptance/refusal;
- head appointment/vacancy/succession;
- communication;
- controlled exogenous arrival/departure/resource change.

Generated tests are not an oracle for historical plausibility. Their purpose is to expose broken invariants and unexpected interaction sequences.

Any minimized/shrunk failing history should be preserved as a deterministic regression fixture.

## 10. Finding G-H — add semantic mutation/fault-injection adequacy

Code coverage or many passing scenarios do not demonstrate that the suite would catch meaningful defects. Mutation testing explicitly evaluates whether deliberately altered behavior is detected.

Pass G should require a small project-specific **semantic mutant set**, regardless of whether generic mutation tooling is also used.

At minimum the verification suite should detect mutants that:

1. form a household from co-residence alone;
2. give all actors engine-global household recognition;
3. preserve household identity by participant overlap without a ContinuationWarrant;
4. allow household expenditure without backing provision capacity;
5. debit collective grain without debiting contributors, or debit twice;
6. let the head command an out-of-scope personal action;
7. skip commit-time revalidation;
8. treat Unable/Invalidated as voluntary refusal and apply attitude penalty;
9. allow the same reaction cause key to fire twice;
10. let a derived cache survive after its backing fact changes and influence behavior;
11. restore a checkpoint while omitting subjective knowledge/cooldown state;
12. allow instrumentation/reader code to mutate semantic state.

Report mutants as detected, survived, unexercised, invalid/equivalent, crash, or timeout. A crash should not automatically count as evidence that the intended semantic assertion caught the fault.

## 11. Finding G-I — audit scenario-fixture write sets

A formation/fission/continuity test can accidentally script the desired outcome through setup or intervention.

For every canonical scenario, the harness should declare its allowed external write set.

Formation scenarios may initialize/inject lower-level people, relations, residence, attitudes, grain, and allowed exogenous changes, but must not directly write:

- Household identity;
- FormationWarrant;
- ContinuationWarrant;
- DerivedFrom lineage;
- head appointment/succession outcome;
- actor recognition of the household except where recognition itself is the controlled input under test.

The evidence report should make fixture-originated facts distinguishable from endogenous commits.

## 12. Finding G-J — causal-history presence is weaker than causal-history truth

A trace can be complete and still give the wrong reason.

Decision explainability tests should therefore include **causal intervention pairs** where practical:

- preserve the irrelevant facts;
- remove/change the claimed critical cause;
- check whether the outcome changes in the diagnostic condition.

Examples:

- remove provision backing but preserve the household/head label -> spending disappears;
- preserve co-residence but remove required recurrent support -> formation does not occur;
- preserve all objective household state but remove one actor's recognition -> household-specific candidate disappears;
- preserve a household label but invalidate the head role -> mediated action disappears.

When causes are redundant, use crossed controls instead of expecting one-factor removal always to change the outcome.

## 13. Finding G-K — verify both safety and bounded progress/closure

Most proposed obligations are safety properties ("this bad/unearned transition must not occur") or finite positive witnesses.

Add structural progress checks appropriate to v0:

- every immediate proposal reaches a terminal result within the same cycle;
- automatic reaction closure reaches a stable boundary without repeated cause keys;
- a stable cycle boundary has no unresolved immediate work;
- a provision reconsideration that has both expired cooldown and relevant context change becomes eligible when the head deliberates;
- MaterialDeadlock is detected rather than producing an infinite inert execution.

These are bounded v0 progress obligations, not claims of fairness or eventual success in arbitrary worlds.

## 14. Finding G-L — separate canonical cards from held-out/generated variants

The canonical cards will guide implementation and therefore risk becoming overfit examples.

Stage 3 should define:

- a small canonical, fully explained acceptance set;
- parameter/boundary variants;
- metamorphic paired executions;
- bounded generated histories;
- a small held-out variant set not used as the primary coding narrative.

A passing canonical set plus failing held-out variants must remain visible rather than being summarized into one success percentage.

## 15. Recommended amendments to Pass G

Retain the previously proposed 24 proof obligations, but organize Stage-3 verification around these additional closure requirements:

1. explicit statement that passing verifies SFL v0 semantics, not historical validity;
2. independent oracle/checker discipline;
3. required metamorphic relations;
4. boundary-value matrices for all hard gates;
5. causal ablation isolation rules;
6. always-on mechanical invariants;
7. bounded stateful generated sequences with minimized failures;
8. semantic mutation/fault-injection challenge set;
9. scenario harness write-set audit;
10. causal reason truth through intervention, not trace presence alone;
11. bounded progress/reaction-closure assertions;
12. canonical vs held-out/generated evidence separation.

With these amendments, the Pass G contract is sufficiently adversarial for Stage-2 specification closure. No new social-semantic blocker was found.

## 16. Source basis

### Project sources

- `specifications/working/SFL_V0_WORKING_SPEC.md`
- `plans/SFL_V0_SPECIFICATION_WORKBENCH.md`
- `research/technical/TRES-0001/returns/TRES-0001F_RESEARCH_REPORT.md`
- `research/technical/TRES-0003/PASS_F_TEMPORAL_RESOLUTION_ADVERSARIAL_REVIEW.md`

### External checks

- Collins, Koehler & Lynch (2024), *Methods That Support the Validation of Agent-Based Models*, JASSS 27(1): https://jasss.soc.surrey.ac.uk/27/1/11.html
- Belfrage et al. (2024), *[In]Credible Models – Verification, Validation & Accreditation of Agent-Based Models to Support Policy-Making*, JASSS 27(4): https://jasss.soc.surrey.ac.uk/27/4/4.html
- Chen, Cheung & Yiu, *Metamorphic Testing: A New Approach for Generating Next Test Cases*: https://arxiv.org/abs/2002.12543
- Liu, Kuo, Towey & Chen (2014), *How Effectively Does Metamorphic Testing Alleviate the Oracle Problem?*, IEEE TSE 40(1): https://doi.org/10.1109/TSE.2013.46
- Hypothesis, *Stateful tests* documentation: https://hypothesis.readthedocs.io/en/latest/stateful.html
- Papadakis et al. (2019), *Mutation Testing Advances: An Analysis and Survey*: https://discovery.ucl.ac.uk/id/eprint/10056704/
- Stryker Mutator documentation, *Mutant states and metrics*: https://stryker-mutator.io/docs/mutation-testing-elements/mutant-states-and-metrics/
- ten Broeke, van Voorn & Ligtenberg (2016), *Which Sensitivity Analysis Method Should I Use for My Agent-Based Model?*, JASSS 19(1): https://jasss.soc.surrey.ac.uk/19/1/5.html
