# TRES-0011C — External Simulation-Methodology Review of the V0 Resource Scaffold

**Status:** COMPLETE  
**Task:** `tasks/research/TRES-0011C_EXTERNAL_SIMULATION_METHODOLOGY.md`  
**Role:** independent simulation-methodology researcher  
**Context sequence:** external literature first, project application second  
**Project baseline reviewed:** `tres-0011-v0-resource-scaffold-wave-v1` @ `76660eaea3be5a6a4612cfd431f9f73fe69a0f0a`  
**Authority:** advisory only

## Verdict

**FIT ONLY WITH EXPLICIT INTERPRETATION / SENSITIVITY GUARDRAILS**

The current SFL v0 resource scaffold is methodologically defensible for the project's stated near-term purpose: a deterministic, inspectable reference laboratory for testing whether lower-level individual and relationship processes can generate and sustain a Household with a bounded collective capability. It does **not** need to be a mature historical economy before it can serve that purpose.

That conclusion is conditional. In SFL v0, resource rules are not merely decorative inputs: grain availability directly affects `NeedsGrain`, farming, transfers, debt repayment, provision commitments, Household support, mediated-marriage funding, private supplementation, and central conflict/revalidation. The scaffold can therefore create or suppress the very social opportunities being observed. Methodologically, observations are trustworthy as claims about the implemented mechanism only when their dependence on the provisional resource mechanism is exposed. General social or historical interpretation requires explicit sensitivity and later empirical grounding.

## 1. Independence and method

The review followed the task's required sequence.

### Phase 1 — external methodology

I first reviewed literature on model purpose, exploratory versus predictive use, KISS/KIDS, pattern-oriented modeling, iterative refinement, systematic simulation experiments, empirical validation, sensitivity/structural uncertainty, and cross-model comparison. I did not use detailed SFL resource semantics to select the verdict during this phase.

### Phase 2 — project application

I then reviewed:

- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- `plans/FIRST_PROTOTYPE_DEVELOPMENT_ROADMAP.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md`

Repository orientation and current-phase files were read only to establish authority/status and the required base branch.

The question assessed here is methodological fitness for the declared **v0 laboratory purpose**. It is not an assessment of historical correctness of Mesopotamian resource relations; that is delegated separately in the TRES-0011 wave.

## 2. External source table

| ID | Source | Type | Methodological use in this review |
|---|---|---|---|
| S1 | Edmonds, B. et al. (2019), “Different Modelling Purposes,” *Journal of Artificial Societies and Social Simulation* 22(3)6. https://doi.org/10.18564/jasss.3993 | Peer-reviewed methodology | Model adequacy is purpose-relative; distinguishes prediction, explanation, description, theoretical exposition/exploration, illustration, analogy, and social learning; stresses sensitivity and anti-overinterpretation for theoretical models. |
| S2 | Bankes, S. (1993), “Exploratory Modeling for Policy Analysis,” *Operations Research* 41(3):435–449. https://doi.org/10.1287/opre.41.3.435 | Peer-reviewed methodology | Separates exploratory computational experiments under uncertainty from models intended to consolidate knowledge for prediction. |
| S3 | Grimm, V. et al. (2005), “Pattern-Oriented Modeling of Agent-Based Complex Systems: Lessons from Ecology,” *Science* 310(5750):987–991. https://doi.org/10.1126/science.1116681 | Peer-reviewed ABM methodology | Uses multiple observed patterns to constrain mechanism choice and model complexity; provides a route between arbitrary minimalism and unconstrained realism. |
| S4 | Grimm, V. et al. (2010), “The ODD Protocol: A Review and First Update,” *Ecological Modelling* 221(23):2760–2768. https://doi.org/10.1016/j.ecolmodel.2010.08.019 | Peer-reviewed ABM methodology | Makes purpose, process, state, and assumptions explicit; supports reproducibility and exposes theoretical foundations of complex models. |
| S5 | Edmonds, B. & Moss, S. (2005), “From KISS to KIDS — An ‘Anti-simplistic’ Modelling Approach,” in *Multi-Agent and Multi-Agent-Based Simulation*, LNCS 3415:130–144. https://doi.org/10.1007/978-3-540-32243-6_11 | Peer-reviewed conference chapter | Critiques simplicity as an intrinsic virtue for descriptive social models; argues that descriptive richness can be methodologically preferable when evidence and purpose require it. |
| S6 | Epstein, J. M. (2008), “Why Model?”, *Journal of Artificial Societies and Social Simulation* 11(4)12. https://www.jasss.org/11/4/12.html | Peer-reviewed methodological essay | Explicitly separates explanation and many other modeling purposes from prediction; supports models as tools for making assumptions precise and exploring consequences. |
| S7 | Windrum, P., Fagiolo, G. & Moneta, A. (2007), “Empirical Validation of Agent-Based Models: Alternatives and Prospects,” *Journal of Artificial Societies and Social Simulation* 10(2)8. https://www.jasss.org/10/2/8.html | Peer-reviewed ABM methodology | Shows that empirically grounded ABMs require explicit choices about calibration, empirical targets, initial conditions, and validation; empirical adequacy is a separate methodological burden. |
| S8 | Lorscheid, I., Heine, B.-O. & Meyer, M. (2012), “Opening the ‘Black Box’ of Simulations: Increased Transparency and Effective Communication Through the Systematic Design of Experiments,” *Computational and Mathematical Organization Theory* 18:22–62. https://doi.org/10.1007/s10588-011-9097-3 | Peer-reviewed simulation methodology | Advocates systematic design of experiments, interaction tests, mechanism on/off benchmarks, and iterative expansion of complexity. |
| S9 | ten Broeke, G., van Voorn, G. & Ligtenberg, A. (2016), “Which Sensitivity Analysis Method Should I Use for My Agent-Based Model?”, *Journal of Artificial Societies and Social Simulation* 19(1)5. https://doi.org/10.18564/jasss.2857 | Peer-reviewed ABM methodology | Emphasizes that ABMs' nonlinear, multi-level interactions make sensitivity nontrivial; recommends extended one-at-a-time exploration as a useful starting point for mechanism/pattern analysis, supplemented where needed. |
| S10 | Axtell, R., Axelrod, R., Epstein, J. M. & Cohen, M. D. (1996), “Aligning Simulation Models: A Case Study and Results,” *Computational and Mathematical Organization Theory* 1(2):123–141. https://doi.org/10.1007/BF01299065 | Peer-reviewed computational-model methodology | “Docking”/alignment compares independently structured models to test whether results depend on one implementation/mechanism and to support critical experiments. |
| S11 | Railsback, S. F. & Grimm, V. (2019), *Agent-Based and Individual-Based Modeling: A Practical Introduction*, 2nd ed., Princeton University Press. https://doi.org/10.2307/jj.28274141 | Established ABM textbook | Treats ABM development as a modeling cycle and integrates pattern-oriented design, testing, sensitivity, uncertainty, robustness, and inference. |
| S12 | Saltelli, A. et al. (2020), “Five Ways to Ensure That Models Serve Society: A Manifesto,” *Nature* 582:482–484. https://doi.org/10.1038/d41586-020-01812-9 | Established cross-disciplinary modeling guidance | Reinforces transparency about assumptions, uncertainty, purpose, and limits when model outputs may be interpreted beyond their justified scope. |

The core conclusion does not depend on any one source. S1, S2, S3, S8, and S9 are the most directly controlling for this task; S5 is especially important as a warning against turning KISS into a universal rule.

## 3. Literature findings

### 3.1 Fitness is relative to purpose, not to realism in the abstract

The strongest common principle is that model adequacy cannot be decided by asking whether a model is “realistic enough” without first asking what it is for.

Edmonds et al. make this explicit: the same code can be adequate for one purpose and inadequate for another, and changing purpose requires re-justification. Their “theoretical exposition” category is particularly relevant here: a simulation may be used to establish and characterize hypotheses about how a set of mechanisms behaves without claiming a direct empirical mapping to an observed society. For that purpose, verification, systematic exploration, and sensitivity are central. By contrast, empirical explanation, description, or prediction require stronger evidence linkage and validation.

Bankes makes a parallel distinction between exploratory modeling and prediction-oriented consolidation of knowledge. Exploratory models are useful precisely where important uncertainty remains, but they must be treated as computational experiments over assumptions rather than as forecasts.

**Implication:** a subsystem does not have to be historically/economically mature merely because the long-term project is historically grounded. It has to be adequate to the current experiment. If the experiment is “can these social mechanisms operate coherently under a bounded resource constraint?”, a stylized resource scaffold can be sufficient. If the experiment is “did Mesopotamian households actually behave this way under historically plausible production and scarcity?”, it is not.

### 3.2 KISS is not a universal license for crude social mechanisms

The KISS/KIDS debate does not support a generic rule that simpler is always better.

Edmonds & Moss argue that for descriptive social simulation, aggressive simplification can omit socially relevant structure and produce unjustified abstraction. Edmonds et al. later frame this dispute through model purpose: KISS is especially useful for illustration and theoretical exposition, while KIDS can be important for explanation/description. The correct question is therefore not “is the resource subsystem simple?” but “does its simplicity preserve what matters for the current purpose while avoiding unsupported claims?”

For SFL v0's current use, simplicity has genuine advantages: fewer interacting assumptions, better inspectability, easier falsification of mechanism hypotheses, clearer traces, and lower risk that a complex economy hides whether Household semantics themselves work. But simplicity stops being an advantage when a placeholder is itself the dominant cause of the observed social outcome.

### 3.3 Progressive refinement is a recognized strategy, but only if early results remain scoped

Iterative development is normal in ABM methodology. The modeling cycle in Railsback & Grimm, pattern-oriented development, and systematic experimentation in Lorscheid et al. all support building a tractable model, testing it, learning from it, and refining complexity where evidence or failure demands it.

Edmonds et al. also discuss incremental strategies for theoretical work, while Lorscheid et al. explicitly describe simplified benchmark scenarios and later expansion in iterative experiments. This makes “build one grounded collective capability, observe it, then replace/refine the economic mechanism” methodologically recognizable.

However, refinement is defensible only if the early model is not allowed to acquire empirical authority by inertia. A provisional mechanism that survives several implementation slices is still provisional if its empirical basis has not changed. Later replacement must trigger re-checking of any conclusion that depended materially on that mechanism.

### 3.4 Pattern-oriented modeling argues for selective realism, not maximal realism

Pattern-oriented modeling offers a useful middle position. The purpose is not to reproduce every known detail, but to use multiple relevant patterns to constrain assumptions and eliminate mechanisms that get the right result for the wrong reason.

For a mature historical Social Fabric Laboratory, this suggests that the eventual resource/economic subsystem should be constrained by multiple historically meaningful patterns at different scales where evidence permits. But POM does **not** imply that all of those patterns must be represented before a pre-calibration theoretical laboratory can exist.

For v0, the analogous methodological requirement is weaker but still important: the social phenomena being studied should not appear only under one arbitrary resource parameterization. Multiple controlled resource regimes can act as filters against scaffold-specific artifacts even before historical pattern validation begins.

### 3.5 Structural uncertainty matters as much as parameter uncertainty

Sensitivity analysis is often treated as varying numbers while leaving the mechanism fixed. That is insufficient here.

The TRES-0011 question concerns **structural uncertainty**: whether “Farm yields 4, consume 1, reserve 2, integral grain, fixed available actions” is itself a consequential mechanism choice. If changing the resource-process structure changes whether Household support, provision commitments, debt repayment, marriage mediation, or continuity phenomena occur, then the social observation is conditional on the scaffold.

ten Broeke et al. show why ABM sensitivity is difficult: multi-level feedback and nonlinearity can make a single sensitivity method incomplete. Lorscheid et al. likewise warn that interactions among factors can be missed by naive testing and recommend systematic experimental design.

**Implication:** SFL should vary not only resource quantities but at least one plausible alternative resource-process structure before treating important social observations as robust.

### 3.6 Controlled experiments are part of explanation, not an optional afterthought

For theoretical mechanism models, one illustrative run is weak evidence. Edmonds et al. recommend sensitivity and attempted refutation; Lorscheid et al. recommend systematic simulation experiments; Axtell et al. show the value of aligning different model realizations to test whether conclusions are implementation-specific.

A useful v0 observation should therefore be stated in one of three forms:

1. **within-model result** — true under the current accepted scaffold;
2. **resource-robust model result** — survives declared resource parameter/structure perturbations;
3. **empirical/historical result** — supported by external evidence and validation.

At present, SFL v0 can legitimately produce categories 1 and, after the checks below, 2. It is not yet designed to produce category 3.

### 3.7 Provisional submodels become dangerous when they are allowed to explain what they hard-code

A model can appear to “discover” a causal relation that was effectively predetermined by an assumption.

Examples in the abstract include:

- a scarcity threshold that mechanically creates the social need later attributed to institutions;
- an allocation rule that guarantees one household type outperforms another;
- a timing rule that creates conflict and then makes a conflict-resolution mechanism appear important;
- a production rule that suppresses alternative behaviors so strongly that the social policy cannot actually be challenged.

The remedy is not necessarily immediate realism. It is explicit mechanism accounting, controlled ablation, sensitivity to alternatives, and strict interpretation.

## 4. Project application

### A. What kind of model is SFL v0?

SFL v0 fits several purposes, but they are not equal.

| Candidate purpose | Classification for v0 | Consequence |
|---|---|---|
| Illustration | **Secondary** | It can demonstrate that an individual → relationship → Household mechanism is possible and inspectable, but a demonstration alone supports little general inference. |
| Theoretical/explanatory mechanism model | **Primary, with an important qualification** | In ordinary project language it is explanatory/mechanistic. Under Edmonds et al.'s stricter categories it is primarily **theoretical exposition/exploration**, not yet an empirical explanation, because v0 explicitly lacks historical calibration/validation and is not fitted to observed outcomes. |
| Exploratory model | **Primary** | It is intended to run small controlled worlds, expose causal behavior, reveal problems, and generate the next bounded questions. |
| Descriptive/historical model | **No, not at v0** | The founding project is historically grounded, but v0 does not claim to partially represent a particular observed Mesopotamian case with validated economic detail. |
| Predictive/calibrated model | **No** | The specification explicitly places historical calibration/validation outside scope; no unknown historical data are being predicted. |
| Reference implementation / laboratory | **Primary project-internal role** | It is intended to be a deterministic, inspectable semantic reference path against which later model iteration and optimization can be checked. This is not one of Edmonds et al.'s purpose categories, but it is a coherent engineering/scientific role. |

This classification is supported strongly by the project itself:

- The Seed says to build meaningful lower layers, observe whether they behave coherently, and then use them as foundations for later layers.
- The Roadmap asks for the “smallest model” that can exercise one grounded collective capability, followed by a reference prototype, controlled worlds, causal inspection, and later iteration.
- The accepted specification calls SFL v0 a “small deterministic social-mechanism laboratory” and explicitly excludes historical calibration/validation and a full economy/agriculture/property-law model.
- The architecture policy prefers the simplest sufficient implementation and progressive specialization while keeping semantics inspectable and replaceable.

Thus the resource scaffold should be judged against a **theoretical/exploratory reference-laboratory purpose**, not against the standards of a mature historical-economic simulation.

### B. When is a crude subsystem acceptable?

A simplified subsystem is methodologically acceptable as scaffolding when all of the following hold:

1. **Purpose is explicit.** The model is being used to study another mechanism, not to make direct claims about the simplified subsystem.
2. **The placeholder supplies enabling conditions rather than the answer.** It creates resource constraints/opportunities needed to exercise the target social mechanism but does not mechanically encode the claimed social result.
3. **Its assumptions are visible and inspectable.** Inputs, thresholds, transitions, provenance, and failure paths are explicit enough to trace how the placeholder affects an outcome.
4. **The target mechanism is separable in analysis.** One can vary, switch, or replace the placeholder while keeping the social mechanism meaningfully fixed.
5. **Important observations survive reasonable perturbation.** The result is not confined to one narrow setting of arbitrary resource parameters.
6. **No empirical authority is borrowed from project context.** “Historically grounded project” is not used to make an unvalidated placeholder look historically grounded.
7. **Replacement has a revalidation plan.** When the subsystem is refined, conclusions known to depend on it are rerun rather than presumed to transfer.
8. **The scaffold is the smallest sufficient means of making the causal question testable.** Additional realism is deferred because it would add confounds or cost without improving the current inference.

SFL v0 already satisfies several of these conditions structurally: the provisional grain discretization is explicit; historical calibration is explicitly out of scope; permitted Household uses are narrowly bounded; causal history and funding provenance are required; and the architecture policy values stable semantic boundaries and replacement.

What remains insufficiently demonstrated is condition 5: robustness of social observations to the resource scaffold.

### C. When is crude dangerous?

A placeholder resource mechanism becomes methodologically dangerous when any of the following occur:

1. **Outcome sensitivity:** the phenomenon disappears, reverses, or changes category under modest resource changes.
2. **Causal pre-decision:** the resource rule effectively hard-codes the social mechanism supposedly being tested.
3. **Threshold domination:** arbitrary thresholds create most of the observed behavior.
4. **Coupled action suppression:** the placeholder makes alternative social actions infeasible so often that the tested mechanism faces no meaningful competition.
5. **Timing artifacts:** synchronized production/consumption or deterministic timing creates conflicts that would not survive a different resource schedule.
6. **Interpretive escalation:** within-model behavior is described as a claim about Mesopotamian society, historical frequency, economic efficiency, welfare, or likely institutional evolution.
7. **Replacement blast radius:** later resource refinement changes unrelated-looking social results, revealing that the subsystem was not actually modular in causal effect.
8. **One-parameter comfort:** parameter sweeps give apparent robustness while the result remains fragile to a different resource process.

SFL v0 is exposed to several of these risks because grain is deeply coupled to current social behavior:

- `NeedsGrain` is generated by consumption and blocks `Farm`;
- grain availability governs gifts/help, loans, repayment, and some failures;
- protected reserve determines disposable/exposed capacity;
- provision commitments create Household mobilizable capacity;
- Household support exists specifically to relieve `NeedsGrain`;
- mediated marriage requires material funding;
- transaction-specific head supplementation adds another resource route;
- central priority and revalidation decide conflicts over the same personal grain;
- `MaterialDeadlock` is itself defined through the resource mechanism.

Therefore the current scaffold cannot be treated as an irrelevant technical placeholder. It is an intentionally simple **causal environment** for the social mechanism. That is acceptable for v0, but only if conclusions remain conditional until robustness is shown.

### D. Is progressive refinement defensible here?

Yes, for the declared laboratory purpose, with a strict condition: each refinement stage must preserve a record of what earlier observations depended on and must rerun those observations when the resource mechanism changes.

The project sequence:

**one grounded collective capability → observe causal behavior → later refine/replace the resource mechanism**

is methodologically consistent with iterative ABM development and theoretical exposition. It has several advantages at this stage:

- it isolates the social mechanism before a full economy introduces many confounds;
- it keeps failures interpretable;
- it allows verification of causal provenance and Household authority before historical calibration;
- it produces a reference path for later comparison;
- it makes the eventual need for complexity evidence-driven rather than speculative.

But it ceases to be defensible if “later replace/refine” is treated as a promise that automatically validates conclusions made now. Methodology requires **re-justification after replacement**, not mere code substitution.

The project's own architecture policy is compatible with this: stable semantic/query boundaries and rebuildable derived state support software reversibility, but software reversibility is not the same as scientific robustness. The latter must be demonstrated experimentally.

## 5. Project-specific interpretation boundary

### Claims SFL v0 may safely make now

SFL v0 may make **within-model** claims such as:

- a Household-like collective can be represented as causally grounded in people, relationships, warrants, commitments, authority, and history rather than a primitive membership container;
- under the accepted v0 resource rules, a persistent provision commitment can make a bounded Household material action feasible when it otherwise would not be;
- under the accepted v0 rules, Household action can remain institutionally distinct from personal transfer while still debiting personal resources with explicit provenance;
- a head's transaction-specific private contribution and commitment-backed contribution can be represented as distinct authority/provenance channels without introducing a Household treasury;
- resource competition can trigger observable revalidation, invalidation, support, debt, or deadlock pathways;
- the model's social semantics and causal history can be executed deterministically and interrogated under controlled scenarios.

After the sensitivity checks below, SFL may additionally make bounded robustness claims of the form:

- a named social phenomenon persisted across the tested resource regimes;
- a result did not depend on the exact baseline Farm yield/starting grain/timing within the tested range;
- a social mechanism remained operative under a structurally different resource-input scaffold.

These are still claims about the model, not about ancient Mesopotamia.

### Claims SFL v0 must explicitly not make

Without later historical/economic grounding and validation, v0 must not claim:

- that its grain units correspond to historical quantities or metrology;
- that `Farm = 4`, consumption = 1, reserve = 2, or the baseline starting stocks are historically representative;
- that the frequency or severity of `NeedsGrain` resembles historical scarcity;
- that Household provision commitments model actual Mesopotamian provisioning institutions in prevalence, magnitude, or allocation;
- that the observed incidence of support, marriage mediation, debt repayment, refusal, conflict, or deadlock is historically realistic;
- that a Household mechanism is economically efficient, welfare-improving, resilience-enhancing, or distributionally realistic in the historical world;
- that one resource-allocation rule was historically dominant or causally necessary;
- that simulated outcomes establish why Mesopotamian households formed, persisted, or exercised authority;
- that relative outcomes between alternative social rules would survive a historically mature economy unless resource-structure robustness is demonstrated;
- any predictive claim about historical events, frequencies, or trajectories.

The founding historical ambition does not weaken these exclusions; it makes them more important.

## 6. Minimum sensitivity / falsification package before trusting v0 observations

The following package is the minimum methodological guardrail I recommend before using v0 observations to guide semantic promotion beyond narrowly local correctness.

It does **not** require designing the future economy.

### Experiment 1 — extended resource-regime sweep

Hold social semantics and initial social relationships constant. Vary, one at a time, the main provisional resource levers over deliberately broad but non-degenerate values:

- starting personal grain;
- per-cycle resource inflow/yield (currently represented by `Farm`);
- per-cycle consumption burden;
- protected reserve / exposed-capacity threshold;
- scheduled exogenous resource changes already permitted by the scenario harness.

For each variant, record at least:

- `NeedsGrain` incidence/duration;
- number and identity of viable personal actions;
- Household provision requests/acceptances/refusals;
- Household support attempts and commits;
- commitment-backed and private-supplement funding;
- debt repayment success/failure;
- mediated-marriage availability;
- material conflict invalidations;
- Household lifecycle/continuity events affected by resource-mediated social actions;
- `MaterialDeadlock`;
- any target observational claim under study.

Purpose: identify thresholds, monotonicity, reversals, and brittleness. This follows the mechanism-oriented sensitivity logic emphasized by ten Broeke et al.

### Experiment 2 — same-total, different-timing test

Construct at least two deterministic exogenous resource schedules with the same cumulative resource amount over the observation horizon but different timing/concentration.

Example structure:

- smoother regular inflow;
- lumpy inflow with temporary scarcity.

Keep social initial conditions unchanged.

If social conclusions change substantially despite the same cumulative resource amount, the result is timing-structure-dependent and should be labeled accordingly. This specifically probes whether the current synchronized Farm/consumption cycle is manufacturing social conflict or stability.

### Experiment 3 — structural scaffold substitution

Run the same social scenario under:

- the canonical v0 Farm/consumption scaffold; and
- a deliberately different simple resource-input mechanism, such as a fixed exogenous earning/endowment schedule that removes the `Farm` action while preserving broadly comparable total available grain.

Do **not** attempt to make the alternative historically “correct.” Its purpose is structural falsification: test whether the social observation requires the specific Farm mechanism.

Compare semantic outcomes rather than expecting event-by-event identity. If a claim survives both structures, confidence increases that it belongs to the social mechanism rather than to one resource implementation. This is analogous in spirit to model alignment/docking.

### Experiment 4 — small interaction design after screening

After the one-at-a-time sweep identifies the 2–4 strongest resource factors, run a small factorial or otherwise systematic design over those factors rather than varying each in isolation forever.

Purpose: detect interactions such as “starting grain matters only when reserve is high” or “Farm yield matters only under a particular consumption burden.” Lorscheid et al. are directly relevant here: simulation factors can interact, and naive one-factor tests leave blind spots.

### Pass condition for interpretation

For each substantive observational claim, record:

- exact claim;
- resource factors/structures tested;
- whether the claim persisted, weakened, reversed, or disappeared;
- known boundary conditions;
- whether it remains a within-model result or qualifies as resource-robust within the tested envelope.

A result that fails this package is not necessarily a defect. It may be a legitimate finding that the social mechanism is resource-contingent. The methodological failure would be hiding that contingency.

## 7. Recommendations

1. **Keep the current scaffold for v0 unless another TRES-0011 stream identifies a concrete semantic or reversibility blocker.** Methodology alone does not require a mature economy before the Household laboratory can be useful.
2. **Treat resource semantics as a declared experimental factor, not background plumbing.** They are causally upstream of several social outcomes.
3. **Attach interpretation labels to observation reports.** Distinguish `within current v0 scaffold` from `robust across tested resource variants`; reserve historical language for later validated work.
4. **Run the minimum sensitivity package before using observed social dynamics as evidence for further semantic hardening.** Verification that the code implements the accepted rule is not enough to show that the observed behavior is not scaffold-specific.
5. **When the economic/resource subsystem is later replaced, rerun the relevant social observation suite.** Do not grandfather conclusions merely because APIs or invariants remain compatible.
6. **Use historical patterns later to decide which added economic complexity earns its place.** Pattern-oriented modeling suggests selecting complexity to reproduce multiple relevant patterns, rather than replacing a simple scaffold with an unbounded “more realistic” economy.
7. **Preserve the current narrowness of v0 claims.** The accepted specification's explicit exclusion of full economy/agriculture/property law and historical calibration is methodologically sound for this stage and should remain visible in reports.
8. **Do not let provisional status become permanent by inertia.** The roadmap should eventually contain a clear trigger for when resource realism becomes necessary: for example, when a research question concerns scarcity prevalence, wealth dynamics, institutional redistribution, production specialization, or historical comparative outcomes.

## 8. Limitations and methodological disagreements

### KISS versus KIDS is genuinely contested

The literature does not establish a universal principle that simple models are scientifically superior. KIDS is a serious counterargument for descriptive and empirically explanatory social simulation. The more SFL moves toward historical description/explanation, the less defensible an intentionally crude economy becomes unless evidence shows that omitted detail is irrelevant to the target claim.

This report therefore does not endorse “simple now, simple forever.” It endorses **purpose-bounded simplicity now**.

### Theoretical robustness is not empirical validation

Sensitivity can show that a mechanism result is robust across model variants. It cannot show that the mechanism is historically true. Windrum et al. make clear that empirical validation raises separate questions about data, calibration, targets, and model-world linkage.

### Pattern-oriented modeling does not specify which Mesopotamian patterns matter

POM supplies a methodological strategy, not the historical evidence set. Selection of Mesopotamian resource/economic patterns must come from the historical-research stream and later project decisions.

### Sensitivity methods are incomplete

ten Broeke et al. explicitly find that different sensitivity methods reveal different aspects of ABM behavior. The proposed package therefore combines local/mechanistic sweeps, a timing intervention, a structural mechanism substitution, and a small interaction design rather than claiming one technique is sufficient.

### Software modularity is not causal modularity

The architecture may make a resource subsystem easy to replace in code while social conclusions remain highly dependent on it. TRES-0011B is the proper place to judge software blast radius. This report's point is narrower: replacement must be followed by scientific re-checking even if software replacement is clean.

## 9. Bottom line

SFL v0 does not need to wait for a historically mature economy to become a useful social-mechanism laboratory. Its current purpose is to make a bounded causal structure executable, inspectable, falsifiable, and replaceable. Established simulation methodology supports that kind of staged development.

But the resource scaffold already participates in the causal chain of the phenomena being observed. The methodologically defensible posture is therefore:

- use the crude scaffold to expose and test social mechanisms;
- state all resulting claims as conditional on the scaffold unless sensitivity shows otherwise;
- perturb both resource parameters and at least one resource-process structure;
- rerun social observations after later economic replacement;
- reserve empirical/historical interpretation for a separately grounded and validated model stage.

That boundary preserves the value of v0 as a laboratory without allowing provisional economics to masquerade as historical explanation.
