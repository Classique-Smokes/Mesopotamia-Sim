# TRES-0001F — Observability, Verification, and Laboratory Design

**Advisory research return · 19 September 2026 · Version 1.0**  
**Recipient:** Master Architect  
**Scope:** Task F and its own five-file context packet only  
**Status:** research and instrument-calibration experiments completed; Social Fabric prototype evaluation **not run**.

This return proposes ways to obtain evidence. It does not establish project decisions, select a simulation architecture, or supply production implementation. References `[P0]–[P4]` identify the supplied packet; `[S01]–[S15]` identify primary literature/documentation in `SOURCES.md`; `[X1]–[X4]` identify executed research experiments in this bundle. All specific social situations below are proposed tests, not historical reconstructions or observed simulation results.

## 1. Executive synthesis

The laboratory needs to answer two questions that can otherwise become confused: **did the program implement its declared mechanisms correctly, and do those mechanisms actually account for the household behavior being claimed?** A good-looking household history answers neither by itself. Simulation verification and purpose-specific validation are distinct activities in the established methodology; success under particular conditions does not establish validity everywhere. [S01]

The most consequential recommendation is to organize evaluation around **causal contrasts**, not exemplary stories. For each household capability, construct a witness with its sustaining conditions present, then intervene on a relevant condition while preserving the others as far as the declared model permits. Add an irrelevant-change control. Inspect both the local transition and the later social consequences. A scenario is useful because it can expose a particular failure, not because its ending is appealing.

The recommended initial observation arrangement is a complete, structured record of **semantic changes**, periodic state checkpoints, a reproducible input manifest, and a small independently written checker. This is the lowest-commitment candidate investigated here, not a requirement for event sourcing. A transition-first replayable architecture is also credible and may be preferable if it fits the eventual state/time model. An independent small reference model is valuable for narrow operations, but should not become a second full simulation.

Three protections deserve special attention. First, **trace validity is not causal truth**: a well-formed reason can name the wrong cause. Second, **quiet identity is not good identity**: never recognizing a household or never allowing one to dissolve also eliminates flicker. Third, **event playback is not decision replay**: applying saved changes does not establish that the current engine would generate those changes.

These are not merely hypothetical warnings. Four research-only experiments were executed against synthetic records, classifiers and transfers. The atomic independence checker detected four deliberate couplings. A false causal reason survived structural ledger checks but was exposed by a controlled intervention. Two defective classifiers achieved zero marginal flicker. A logger that consumed the simulation's random stream changed every one of 128 tested trajectories. These results calibrate proposed instruments; they do not validate a household model. [X1–X4]

The concrete return is a ten-situation **Prototype Evaluation Suite**, five cross-cutting diagnostic overlays, an observation/evidence proposal, and a portable reader showing the actual calibration results. The strongest defensible future success claim would identify the implementation, scenarios, conditions, observations and limits. It would not simply say “emergence is proven.”

## 2. Problem decomposition

### 2.1 Five different claims

| Claim | What could support it | What would not suffice |
|---|---|---|
| Representational independence | Distinct relationship/claim states can coexist and change separately | Different field names that write the same hidden membership variable |
| Implementation conformance | Transition checks, invariants, replay and independently checked deltas | A plausible final snapshot |
| Mechanism adequacy | Formation/persistence/feedback witnesses plus interventions on their supporting mechanisms | A household label or a prearranged family story |
| Robustness within a declared domain | Generated cases, boundary/schedule/seed exploration, held-out contrasts | Repeated presentation of a favorable seed |
| Historical adequacy | Appropriate external historical evidence and empirical evaluation | Passing this engineering laboratory |

The first four belong in this wave's technical evaluation. The fifth is not established here. The packet leaves historical frequencies and complete upstream systems out of scope. [P1–P2]

The accepted foundation requires distinguishable relations and intelligible continuity, but it does not say that kinship must never influence support or that relocation must never damage a household. **Independence of representation is not independence of all causal effects.** A kinship-mediated support decision can be legitimate if the rule is declared and observable; a setter that silently makes the two concepts identical is a different matter.

### 2.2 Recognition, identity and collective effect

Household recognition asks whether an organization is currently evidenced. Identity asks how this organization relates to earlier organizations. Collective effect asks whether its accumulated organization, commitments or coordination alter individual opportunities or actions. A recognition score, a persistent identifier and a transfer decision answer different questions. None should stand in for the others.

The test suite should therefore expose the implementation's own recognition result, its continuity/lineage decisions, and the lower-level evidence it cites. A second view should show behavior without relying on those labels. This makes it possible to notice a household identifier persisting after all its declared supports disappear, or meaningful coordination continuing while identifiers repeatedly change.

### 2.3 What “not scripted” can mean operationally

No finite black-box suite can logically exclude every hidden script: a lookup implementation could match all tested inputs and differ elsewhere. The practical objective is narrower and achievable: prohibit outcome-writing fixtures, test new variants, inspect causal paths for critical capabilities, and demonstrate response to interventions not encoded as desired household outcomes.

Ordinary behavioral rules are not objectionable merely because they are programmed. The defect is an unexplained shortcut from scenario identity, person name, asset identifier, elapsed test time, or fixture command to the intended household story. A developer audit remains necessary for stronger assurance against such shortcuts. The Project Director should not need to conduct that audit personally.

### 2.4 Oracles without inventing a social theory

An oracle is the rule for judging a test. Three kinds are proposed. **Safety oracles** reject contradictory bookkeeping or forbidden primitive coupling. **Conditional capability oracles** ask whether a specified mechanism produces a witness under explicitly favorable conditions. **Characterization experiments** expose behavior whose correct shape is still open, such as an identity boundary.

Before implementation testing, each card needs a short hypothesis entry: mechanism/version, assumptions, allowed fixture changes, relevant observation horizon, focal outputs, acceptable numerical tolerances and the reason for each expectation. An unspecified threshold cannot quietly become a test's default truth. An unimplemented capability is a gap, not a pass.

The ODD work offers a useful documentation precedent: readable descriptions should identify actual low-level processes and distinguish imposed rules from emergent outcomes. [S02] A compact hypothesis/model card can borrow that discipline without requiring the entire protocol or choosing a particular agent architecture.

## 3. Credible approaches discovered

### 3.1 Candidate A: state checkpoints with a semantic change ledger

A model maintains state in its chosen form. At each meaningful mutation boundary it emits a record identifying the changed entities, before/after values or deltas, triggering input, applied rule and available provenance. Checkpoints allow independent reconstruction and inspection. A small checker verifies declared invariants and reconciles state with changes.

This does not require every internal calculation to be an event, a graph database, or a message broker. It does require a trustworthy relationship between actual state writes and exported changes. If logging is an unrelated afterthought, silent writes can escape. An atomic mutation wrapper, transaction comparison, or another independently checkable mechanism is therefore an important experiment for this candidate.

W3C PROV supplies a useful distinction between entities, activities, agents and relationships such as usage, generation and derivation. That vocabulary can inform an export without adopting RDF or the entire standard. Its generic influence relation should not be treated as a counterfactual causal test. [S03]

### 3.2 Candidate B: transition-first execution with explicit replay inputs

A transition-first model makes accepted changes the result of explicit commands, conditions and state transitions. It can naturally attach the evaluated conditions to the transition that consumed them. Re-execution starts from an initial state and the same exogenous inputs; playback instead applies already accepted events. Both are useful, but test different things.

This candidate may reduce the distance between execution and explanation. Its risks are early commitment to event semantics, incomplete capture of hidden state, and migration of old event histories after rules change. A replayable event stream is not enough when the decision layer reads uncaptured caches, wall time or shared random state.

The strongest case for this candidate would be an implementation experiment showing that transition records remain complete without making everyday social-rule changes cumbersome. That comparison has not yet been run against a Social Fabric implementation.

### 3.3 Candidate C: an independent executable reference for narrow behavior

A deliberately small reference can describe a few operations such as creating an obligation, fulfilling part of it, terminating it and retaining its history. Generated action sequences can compare implementation state against that reference and check invariants after each operation. Hypothesis's stateful testing documentation demonstrates generated action sequences, dependent values and invariants; it is an example of available technique, not a project-language selection. [S06]

The reference should share concepts with the implementation, not call the same transition functions. Otherwise both can reproduce one bug. Conversely, duplicating the entire household simulation creates a second maintenance burden and an uncertain oracle. Keep the reference close to a few agreed operations.

For a particularly troublesome bounded transition protocol, formal exploration is another candidate. TLC can check invariants/properties and produce an error trace. [S12] That does not justify formalizing all household behavior now. Any conclusion would have to name the model bounds and assumptions, and the mapping from formal states to implementation states.

### 3.4 Metamorphic testing and generative exploration

Metamorphic testing checks a specified relationship between executions when a complete expected output is unavailable. The original technical report emphasizes related test cases and the role of known problem properties; it is not a correctness proof. [S08]

For this laboratory, promising transformations include renaming nonsemantic identifiers, permuting storage order, changing an irrelevant attribute, or preserving resources while removing a particular support mechanism. These require explicit applicability conditions. Reversing two noncommuting events, changing a socially meaningful name, or erasing meaningful history is not a valid invariance test.

Generation should vary both states and histories: create, contest, partially fulfill, leave, return, lose an asset, acquire an alternative, and terminate an obligation. Generation must respect necessary preconditions while retaining cases that are inconvenient but legitimate, such as disputed claims. A minimized failing history should be stored explicitly. Hypothesis supports replay through saved examples and explicit reproduction mechanisms; the portable failure artifact should not depend only on a tool database. [S07]

### 3.5 Reproducible randomness and observation

A seed is only part of a reproducibility record. NumPy's compatibility policy conditions stream reproduction on the generator, call sequence and arguments, build, environment and machine. [S04] Its parallel-generation documentation supplies reproducible stream-spawning mechanisms; those mechanisms are examples, not a requirement to use NumPy. [S05]

The laboratory proposal is to separate scenario generation, simulation decisions and diagnostics. Record the generator implementation, stream identity, relevant state and scheduling rules. A checkpoint must contain the state needed for continuation, including pending actions and meaningful collective memory—not merely the visible individuals and a seed. Python's `getstate`/`setstate` methods illustrate explicit RNG-state restoration and are the methods used in the calibration experiment. [S15, X3]

Equal seed numbers in different architectures do not imply corresponding draws. Even named streams can desynchronize when interventions alter draw counts. Use common random inputs only where the matching is well defined; otherwise compare independently replicated distributions or isolated deterministic mechanisms.

### 3.6 Engineering telemetry is a separate layer

OpenTelemetry traces organize spans with attributes, events and links. [S13] Those are useful for engineering performance and execution inspection, but they do not by themselves supply household concepts or truthful decision reasons. Sampling deliberately omits observations; the documentation discusses circumstances where sampling is unnecessary and the costs of sampling strategies. [S14]

For the small laboratory, the proposal is to retain the full semantic evidence needed by each declared test. Performance telemetry can be optional and separately sampled. Turning it on must not change the semantic trajectory. A lost semantic record should invalidate evidence completeness rather than quietly lower a coverage percentage.

## 4. Comparison

The following judgments are advisory engineering assessments, not measured benchmark results.

| Dimension | A — State + semantic ledger | B — Transition-first execution | C — Small independent reference |
|---|---|---|---|
| Main strength | Can wrap different internal architectures with limited initial commitment | Conditions, accepted changes and replay inputs can be closely aligned | Supplies an oracle independent of implementation code |
| Main weakness | Logging can drift from actual mutation | Event meanings and replay semantics become early commitments | Reference can be wrong, incomplete or too similar to implementation |
| Initial complexity | Low to moderate if mutations have clear boundaries | Moderate; higher if retrofitted into hidden mutable state | Low for a few operations, high for a second full model |
| Causal inspection | Strong only if records link actual evaluated conditions | Often easier to capture at transition boundary, still needs interventions | Strong for local rules; does not automatically explain collective emergence |
| Scaling concern | Snapshot volume; wide dependency records; history indexing | Long histories, event-version migration, reconstruction cost | Generated state-space growth and duplicated maintenance |
| Reversibility | Export can survive replacement of internal storage | Historical event semantics can constrain later changes | Narrow references are replaceable; broad ones become competing specifications |
| Useful first discriminator | Detect an unlogged mutation and reconstruct selected state independently | Rerun decisions after a checkpoint and distinguish them from playback | Catch an injected defect the implementation's own assertions miss |

A combination of A with a small part of C is the recommended first trial because it can discriminate failures before the project commits to a large execution framework. B remains a credible alternative, particularly where the eventual design already has explicit transitions. The evidence does not justify mandating one internal architecture.

For a transparent storage estimate, let state size be `S`, transition count `E`, mean exported delta size `d`, and checkpoint interval `k` transitions. A straightforward ledger/checkpoint arrangement stores roughly `E*d + ceil(E/k)*S`, excluding indexes and dependency fan-out. Snapshotting at every observation adds state-sized cost each time. This arithmetic identifies what to measure; it is not a performance prediction or population target.

### Behavioral comparison between implementations

First declare whether two candidates implement **the same conceptual mechanisms** or explore **different mechanisms**. In the first case, divergences may indicate defects. In the second, they may be the subject of the experiment. Replication work distinguishes numerical identity, distributional equivalence and relational alignment, and emphasizes choosing focal outputs and observation granularity. [S09]

The proposed adapter exports a common observational vocabulary, not identical internal objects. It maps units, relationship meanings, exogenous interventions and identity-lineage events. It preserves the implementation's own recognition decision rather than replacing it with a shared recognizer that could hide differences.

Compare hard safety properties exactly where appropriate; compare meaningful event ordering through dependency relations when internal microsteps differ; compare trajectories or distributions only at declared observation points. Do not treat internal event count as a universal behavioral metric. Do not force different time models into an unexplained shared tick length.

A statistical “no significant difference” result does not logically establish equivalence: a weak experiment can also fail to detect a large difference. Predeclare a meaningful difference margin and report uncertainty around estimated differences. Treat runs, rather than repeated ticks within one run, as the independent units when runs are actually independently generated. Test-set size should follow the required uncertainty, not a magic seed count.

## 5. Worked social-fabric examples

These are hypothetical diagnostic traces. The numbers and local rules are transparent illustrations, not executed Social Fabric results or historical assumptions.

### 5.1 Support across separate residences

Suppose A resides at D1 and B at D2. C holds the declared ownership claim over D2. A has an explicit support obligation to B; no kinship is required for this example. A has 10 units of transferable stock. For this isolated diagnostic, a candidate rule fulfills a due obligation of 2 units when sufficient unreserved stock is available; unrelated gifts and alternative support causes are disabled. This rule is an example oracle requiring agreement before use.

| Step | Expected conceptual observation under the example rule | Candidate A | Candidate B |
|---|---|---|---|
| Initial state | Two residence records; distinct dwelling claim; support obligation; no primitive household assignment | Snapshot includes separate records and their setup provenance | Initialization events or a declared starting checkpoint establish the same state |
| Obligation becomes due | A due condition is evaluated with available stock | Mutation boundary records the evaluated inputs and rule version | Command evaluation captures due condition and stock precondition |
| Fulfillment | A's stock changes 10→8; B receives 2; obligation balance changes appropriately | Independent checker reconciles stock and obligation deltas | Accepted fulfillment transition produces corresponding events |
| Unchanged facts | A and B remain at different residences; C's dwelling claim is unchanged | Before/after projection checks these exact facts | Event effects and rebuilt state are checked for unintended writes |
| Causal contrast | Removing the only enabled support mechanism blocks this transfer | Paired rerun plus logged preconditions; not merely a new narrative | Paired command evaluation fails or changes as prescribed |

Ownership of the transferred stock can legitimately change; **dwelling ownership** is the unchanged control. Without this distinction, a supposedly careful independence test could reject correct behavior.

The Director inspects separate residence, dwelling-claim and obligation tables, then opens the transfer record and the paired contrast. The developer also checks that the actual decision used the obligation and did not test “same household.” A claim that support necessarily ends after moving would not follow from this fixture. Conversely, a failed transfer with a competing gift mechanism enabled would not isolate support causality.

This example does not by itself demonstrate household emergence. It demonstrates a lower-level capability that must remain available without collapsing concepts into a household container.

### 5.2 Partition of resources, then social rupture

Start from a checkpoint whose household recognition has already been derived from lower-level history. Four people A–D have continuing support, labor coordination and commitments; the recognizer reports organization H. The starting provenance must show whether those ties arose endogenously or were initialized. The latter is legitimate for a persistence experiment, not evidence of genesis.

The first intervention partitions a stock of 20 units into two holdings of 10, with claims/use rights represented explicitly. It does not cancel commitments, change residences, or command a household split. Under a candidate whose sustaining criteria remain satisfied, H should be able to continue. A split may nevertheless be legitimate if the chosen mechanism actually depends on now-lost access; that dependence must be stated rather than concealed.

The second intervention, in a separate branch from an equivalent checkpoint, terminates the identified cross-subgroup commitments and opportunities for coordination. Other mechanisms capable of sustaining H must either remain visibly active or be deliberately controlled. The relevant claim is not “any broken tie causes fission”; it is that H must not retain unexplained effective coordination after all mechanisms claimed to sustain that coordination are removed.

| Observation | Candidate A | Candidate B |
|---|---|---|
| Resource partition | Ledger records source holding, successor holdings, quantities and separate claim changes | Partition input produces material/claim transitions, not a desired household result |
| Continuity witness | Recognition record cites continuing lower-level supports; checker shows no forced split write | Recognition transition is produced from the updated lower-level state/history |
| Social-rupture branch | Relationship termination records precede any changed identity or coordination | Termination inputs lead to reevaluation through explicit transitions |
| Division/dissolution | Lineage/history records explain changed organization; actual coordinated actions are inspected | Accepted transitions retain predecessors and reasons without assuming a particular identity policy |
| Recombination variant | New interactions/commitments can later create another recognizable configuration | New lower-level transitions, not `merge_household` fixture commands, precede recognition |

The Director sees two timelines with the same material partition but different surviving social relations. The useful contrast is the sequence of supporting changes, not whether both implementations reuse the string `H`. A purely numeric membership-overlap rule might return different labels; that is an exposed identity-policy issue, not automatically a social-behavior failure.

### 5.3 Collective feedback without circular proof

An additional diagnostic can use an organization-derived coordination commitment, such as reserving a shared work opportunity according to previously accumulated commitments. Compare an individual decision with this commitment enabled, with its specific coordination mechanism disabled, and with a nonbinding coordination condition. Preserve physical stocks and baseline individual constraints.

Support for collective feedback requires a trace from lower-level history to the commitment, from the commitment to the individual's feasible choices or decision, and an intervention that changes the claimed contribution in a suitable diagnostic situation. Merely reading a household identifier is insufficient. Disabling all resources along with the coordination mechanism is an invalid contrast. No claim of metaphysical irreducibility is needed: a causally useful collective mechanism can remain fully explainable through its constituent history.

## 6. Failure modes / falsification conditions

### 6.1 Failures worth actively injecting

| Deliberate defect | Diagnostic that should expose it | Important limitation |
|---|---|---|
| Support assignment writes residence | Atomic independence test; separate-residence witness | Does not prohibit explicitly modeled later migration |
| Occupation silently writes dwelling ownership | Residence/use/claim contrast | Must distinguish dwelling from transferred consumables |
| A second affiliation deletes the first | Multi-affiliation test with compatible and conflicting obligations | Conflict can legitimately constrain action, not erase history |
| Household exists only for a named person/address | Rename and carrier-turnover tests | Semantic roles must be preserved during renaming |
| Fixture writes desired recognition/fission | Fixture write-set inspection and lineage provenance | Setup of lower-level relations is permitted but not genesis proof |
| Recognizer always returns no household | Positive capability witness | Low flicker or no errors would be vacuous |
| Identity never ends | Sustained-loss control with behavioral inspection | Need declared opportunities and response horizon |
| Pretty but false causal reason | Intervention plus critical-path audit | Redundant causes require more than single-factor removal |
| Event ledger omits a mutation | Checkpoint reconciliation | A checker using the same faulty delta generator may miss it |
| Replay applies old results after decision logic changes | Decision re-execution compared separately with event playback | Both forms of replay are useful when correctly labeled |
| Instrumentation changes random draws | Same-input observer-on/off semantic comparison | Concurrency may need separate scheduling controls |

Mutation testing distinguishes detected, surviving, uncovered and invalid mutants; tools can count timeout outcomes as detections. [S11] For this laboratory, report **semantic detection**, crash, timeout, unexercised, equivalent/not applicable and survivor separately. A crashed run is not evidence that the intended assertion understood the defect. Do not present a single mutation percentage as proof of emergence.

### 6.2 Invariants must not smuggle in social assumptions

Useful candidate invariants include resolvable references, coherent effective times, independent entity and claim identities, replay/checkpoint agreement, and quantity balances with declared sources and sinks. Historical references to deceased or departed people should resolve to retained historical identities, not be destroyed to satisfy a simplistic “all actors alive” check.

Avoid blanket rules such as one owner per asset, one household per person, all kin co-reside, all debts are material stock, all relationship graphs are acyclic, or death erases obligations. Contested claims, multiple affiliations and historical obligations may be legitimate. Applicable restrictions need a declared rule, not a convenient data structure.

### 6.3 Identity instability and arbitrary boundaries

Expose recognition status, persistent identity, lineage and sustaining evidence separately over time. Perturb candidate criteria just below and above a boundary, through temporary absences and through sustained loss. Compare fixed conditions with changing observation cadence. For a hysteretic candidate, vary entry/exit gap jointly with any persistence delay; a one-factor-at-a-time analysis can miss interactions, motivating sensitivity designs beyond local sweeps. [S10]

A membership-overlap measure can help describe turnover but cannot decide continuity alone. Gradual replacement can preserve meaningful commitments or merely create a chain of accidental overlaps. Require the recognizer's continuity rationale and test an otherwise similar chain with those commitments removed.

Low flicker must be paired with nonvacuity and responsiveness. Report the raw timeline and onset/loss delays before choosing acceptance limits. The four synthetic classifiers in X2 establish only that these diagnostics distinguish specific toy defects; they do not select a household-recognition rule.

### 6.4 Limits on causal inference

A null effect from removing one support does not refute its relevance if other causes compensate. Similarly, changing a claimed cause may have no visible effect because the action is blocked elsewhere. Use favorable diagnostic conditions, factorial combinations where relevant, and a reasoned account of mediation and redundancy. The simple X4 intervention has no competing mechanisms; its clarity must not be generalized without those qualifications.

## 7. Recommended next validation

### 7.1 A staged experiment, not a framework build

The first implementation experiment should export observations for SF-02 and SF-03, demonstrate complete mutation capture, and catch injected coupling and missing-ledger defects. These two situations isolate lower-level semantics without requiring a household-recognition policy. Then test SF-01 and SF-09 together: upward formation and downward influence. A design that can label groups but cannot show either causal direction has not met the central objective.

Next, run partition, turnover, dissolution/recombination and identity-boundary cases. Introduce generated histories only after hand-checked cases have reliable oracles. Use minimized failures as explicit regressions. Keep development examples separate from a later declared held-out variant set, and preserve every failure in the evidence index.

A small exploratory seed set can identify gross problems; it is not a universal confidence standard. Under a deliberately simple assumption of independent runs drawn from a fixed distribution, zero observed failures in `N` runs gives an exact one-sided 95% binomial upper bound `1 - 0.05^(1/N)` on that distribution's failure probability. This follows by solving `(1-p)^N = 0.05`. It says nothing about unsampled classes of fixtures or adversarial cases. The 128 seeds in X3 are a calibration budget, not a prescribed prototype-validation count.

### 7.2 Proposed minimum evidence for an implementation return

| Evidence gate | Proposed minimum | Claim prevented when missing |
|---|---|---|
| Reproduction | Versioned implementation, environment, commands, inputs, schedules, RNG details and checkpoints | A strange run can be independently reproduced |
| Evidence integrity | Complete relevant semantic records, reconciled state and independently checked invariants | The reported history matches executed state |
| Lower-level independence | SF-02–04 and mutation controls; separate residence, claims, support, labor and affiliations | A household association is not a disguised universal relation |
| Organization and feedback | SF-01 and SF-09 witnesses plus valid causal contrasts | Organization arises and has an evidenced effect |
| Continuity and change | SF-05–08 with identity diagnostics and SF-10 history reconstruction | Persistence is not tied to one person, asset or label |
| Robustness and limitations | Generated/held-out cases, declared parameter/seed domain, failures and uncertainty | The demonstrated behavior extends beyond hand-picked stories |
| Director inspection | A readable evidence view plus a recorded human inspection exercise | A non-programmer can understand and challenge the claim |

These gates are proposed review criteria, not newly accepted project requirements. A partial milestone can be accepted as partial without claiming the entire laboratory works. “Not implemented” and “inconclusive” must remain visible.

### 7.3 Reader validation

The proposed reader shows what was initialized, what was externally injected, what the model did, and what the checker concluded. Each assertion links to events and a paired contrast. A Director should be able to answer: who used versus owned a dwelling; which change sustained or ended coordination; and which experiment distinguishes a claimed reason from an irrelevant fact.

A future human test should present an unannounced defect among otherwise valid cases and record whether the Director finds it using only the evidence view. That user study has **not** been conducted. The included HTML reader is an executed-data example of inspection, not proof of usability and not a design for the eventual game interface.

## 8. Sources / experiments

### 8.1 Provenance and research coverage

`SOURCES.md` records 15 primary references, URLs, publication or retrieved documentation versions, relevant sections and use limits. This is targeted research, not an exhaustive or preregistered systematic review. Current documentation was inspected on 19 September 2026. Historical papers support methodological ideas; their example technologies and historical software versions are not recommended as current defaults.

The supplied five-file Task F packet is preserved under `packet/`. Its inner ZIP checksum was verified against the dispatch checksum manifest. The ZIP's text was not available through the file retrieval interface, so the attached bytes were inspected directly. Only F's packet and the shared checksum metadata were used; other task contents were not inspected.

### 8.2 Executed calibration experiments

| Experiment | Actual result | Interpretation and limit |
|---|---|---|
| X1: atomic relation independence | 64 Boolean configurations × 6 toggles = 384 checks per version; baseline 0 violations; each of 4 coupling mutants 32 violations | Checker detects these deliberate setter defects; not an integrated social mechanism test |
| X2: identity diagnostic calibration | Single threshold: 20 flips in the marginal window. Three alternatives: 0. Overwide hysteresis never recognizes; immortal latch never ends | Flicker alone is inadequate; this scalar signal is not a household model |
| X3: replay and observer isolation | Across seeds 0–127, repeated runs, pure observers, isolated observer RNG and full RNG-state continuation each match in 128/128 cases. Shared RNG observation and seed-only midpoint restart each diverge in 128/128 | Demonstrates these controlled defects on one pinned runtime; not a cross-platform or concurrent-engine guarantee |
| X4: ledger and reason truth | Five structural corruption mutants detected. One false causal reason survives the structural checker; a 2×2 intervention grid exposes the mismatch | Structural evidence integrity and causal explanation are separate tests |

A changed decision function also diverged in 128/128 X3 runs while recorded baseline events still passed independent playback. Three fresh Python processes with `PYTHONHASHSEED` values 0, 1 and 123 produced byte-identical `results.json` and `example_run.json`. These are limited same-environment reproducibility checks.

The runner uses only the Python standard library. Recorded environment: CPython 3.13.5, Linux x86_64; complete platform/compiler details are in `experiments/results/environment.json`. The online Python documentation inspected was labeled 3.14.7; that was **not** the execution version. NumPy, Hypothesis, Stryker, TLC and OpenTelemetry were researched, not installed or executed as part of these experiments.

All expected calibration diagnostics were confirmed. This includes an intentionally surviving false-reason mutant; “expected diagnostics confirmed” must not be read as “every flawed implementation passed.” Machine-readable results, exemplar events, checkpoint contents, source hashes and fresh-process comparisons are included. The ten Social Fabric cards remain **NOT RUN**.

## 9. Unresolved questions and assumptions

The Master Architect still needs to reconcile a few matters before the proposed tests become executable social-model judgments: what minimal motives and interaction opportunities are present; which lower-level relations count as sustaining a candidate organization; how recognition differs from persistent identity; what collective coordination mechanism is being claimed; and which histories or memories are state-bearing rather than merely explanatory.

Time semantics, simultaneity, numeric representation and cross-platform reproducibility targets remain open. Test applicability depends on them. Death, resource pressure and arrivals can be controlled fixtures without implying complete lifecycle or economic systems. A death test need not invent inheritance rules; it must preserve unresolved claims/history honestly until such rules exist.

No historical frequencies, universal persistence windows, acceptable flicker thresholds, performance targets or final interface choices are inferred. None of the small classifier constants or Boolean toy dimensions should become project parameters by accident.

The remaining uncertainty is substantive rather than administrative: a real candidate implementation may expose new causes, redundancy and state dependencies that these examples do not anticipate. The next useful step is therefore an instrumented, limited candidate tested against the named falsification conditions—not acceptance of this report as proof that the social mechanism already works.
