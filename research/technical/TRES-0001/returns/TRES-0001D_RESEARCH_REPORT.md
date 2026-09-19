# TRES-0001D — Minimal Individual Agency and Interaction

**Task 4 research return · 19 September 2026 · Independent-context · Advisory only**

This return addresses Task D and the shared foundation supplied with it. It does not decide a project architecture, language, storage model, time model, household-recognition algorithm or household-identity rule. All implemented material is disposable research code. Source identifiers [S1]–[S11] resolve in `02_SOURCES_AND_EVIDENCE.md`; experimental evidence resolves to the named files under `results/`.

## 1. Executive synthesis

### What the Master Architect most needs to know

**A small, relational, stateful reactive agent is a credible starting point. The present evidence does not discriminate decisively between ordered priorities and explicit component scoring.** Both generated recurrent support and later relationship change without a household action. Neither required a complete cognitive architecture, a learned policy, a household container, or a scenario script specifying who must help whom.

The useful minimum is not a particular selector. It is a separation of responsibilities: a person has a current situation and distinct relationships; context offers concrete interpersonal actions; the person chooses an intention; counterparties retain their own responses; a resolver checks what can actually occur; and the resulting changes affect later opportunities and choices. A tiny selector without these semantics is not an adequate answer to Task D.

My advisory preference is to carry forward **two interchangeable baselines** over the same action meanings: an ordered-rule policy and a deterministic, decomposable score policy. Add stochastic choice as an explicitly controlled variant, not as the definition of agency. Maintain individual observation/memory separately from durable claims. Introduce goal persistence or bounded planning only when an actual fixture requires a costly or delayed sequence that reactive choice cannot produce.

This is a recommendation about the next discriminating prototype, not an assertion that the mathematically smallest model has been found. The tested score has five authored preference weights and several thresholds. Only selected ablations were run; the necessity of each state variable or coefficient is not established.

### What was actually established

The executed suite contains **1,740 synthetic episodes**, six predetermined seed-0 explanatory traces and **22 passing semantic tests**. Three selectors were compared: ordered rules, deterministic current-score maximization, and softmax sampling of that same score. Passive and uniformly random policies supplied controls. These are **two selector families**, not implementations of three published cognitive architectures.

In the formation fixture, both deterministic candidates met all 120 one-unit person-round requirements in every one of 50 seeds. Both produced two recurrent reciprocal pairings. Their transaction meanings differed: the rule baseline began with three gifts, whereas the score baseline began with one. Under pressure and loss of an actor, both incurred four unmet units out of 112 person-round requirements; interaction order nevertheless changed some claim and withdrawal outcomes. Softmax broadened the interaction network but also introduced avoidable refusals, stale proposals and shortfalls. These results discriminate behavior, not historical credibility.

Two counterexamples prevent a blanket endorsement of reactive scoring. First, a due obligation and another person's acute need can yield opposite choices under noncompensatory rules and compensatory scores. Second, an action costing one unit now to enable three units later is never started by the specified myopic maximum, while depth-two lookahead selects it. The latter establishes an actual scope boundary, not a speculative objection.

**No household was classified or assigned a persistent identity.** The experiments demonstrate lower-level support configurations and their change, which an independently designed household process could inspect. They do not validate household formation, continuity, fission or feedback end to end. The distinctions between co-residence, assets, obligations and support were preserved in the tested semantics, rather than solved by importing another task's rules.

## 2. Problem decomposition

### 2.1 State that must not be collapsed

The accepted foundation requires persistent people and historically meaningful relations and claims. For Task D, the important question is which of these a decision needs to observe, not how they are stored. Four distinctions are immediately useful.

A **pressure** is a current shortfall or exposure. A **preference** determines how this person weighs or prioritizes competing considerations. A **belief** is the person's assessment of another actor or a possible outcome. A **claim or obligation** records a relationship with a meaning that does not disappear merely because a person dislikes it. Reducing all four to a single “relationship strength” would erase distinctions the prototype is supposed to explore.

The toy separates stock/shortfall, five preference weights, fixed affinity, directed reliability belief, named repayment claims, voluntary-support suspension, contact, residence and asset claims. It has no comprehensive psychology. In a later implementation, distinct forms of care, service, dependency, membership and authority would need their own meanings rather than being silently translated into loans or affection.

A plausible conceptual grouping is material security, valued relationships, commitments, and autonomy/exposure. This grouping is **not** the tested dimensionality: the experiment exposes material, care, reciprocity, commitment and autonomy as five weights. Reciprocity is represented as a rough anticipated-return term; it could instead belong to consequence estimation. There is no evidence here that five is a universal or irreducible number.

### 2.2 Opportunity generation is already behavioral modeling

An agent cannot choose an action that the generator never offers. Consequently, a flexible selector sitting over a narrow action menu can still hardcode the outcome.

A proposal should identify an actor, an action meaning, counterparties, and relevant resources or claims. The meanings determine whether it is physically possible, whether another person's authorization is involved, what is contested, and which effects follow success. Normative prohibition must not automatically be equated with physical impossibility: a person may fail to fulfil a duty or violate a norm, and that possibility can be important to social dynamics.

In the experiment, giving one's last token is physically available. The rule policy declines it as a priority decision, and the score penalizes it strongly. This distinction permits testing the policy instead of hiding self-preservation inside an alleged law of the world. Conversely, sending a token that no longer exists is genuinely infeasible and the resolver rejects it.

The repertoire is deliberately small: gift, consensual loan, repayment of a named claim, request for extension, withdrawal of one's voluntary support, restoration of that support, and wait. It does not contain “form household,” “split household,” or a privileged household target.

### 2.3 Selection, persistence and adaptation are different decisions

The choice problem is selecting among present possibilities. The persistence problem is carrying an intention across intermediate steps. The adaptation problem is changing beliefs or dispositions after experience. They need not arrive as one package.

Ordered priorities can choose a due obligation before an attractive alternative. A component score makes trade-offs explicit. A softmax rule changes how often lower-scored alternatives are selected. None of these, by itself, supplies a plan that persists through several initially costly actions.

A bounded reliability update provides history sensitivity without training a policy. The experiment changes a directed reliability belief after gifts, repayments and some unfulfilled claims, while the claims themselves remain explicit. A memory-off variant leaves bookkeeping intact and only disables those belief updates. It therefore tests that update mechanism, not the absence of all history.

### 2.4 Interpersonal resolution cannot use the initiator's preference alone

A's desire to lend to B cannot establish that B accepted a debt. A's desire to extend a deadline cannot establish that a creditor agreed. A person's withdrawal of discretionary support does not necessarily discharge existing claims or dissolve unrelated relations.

For the local experiment, each initiative slot has a common proposal snapshot. Proposed actions are then ordered, revalidated against current conditions, and resolved with counterparty acceptance where their meaning requires it. Effects are atomic, conserve tokens and cannot overdraw resources. A later proposal can become stale because an earlier one already changed the recipient's situation.

This is a bounded implementation choice, not a global time recommendation. Simultaneous compatible transactions, explicit reservations, priority by a represented right, or staged bargaining remain alternatives. The important architectural requirement is that contested interests and execution conflicts remain visible, not that one arbitrary resolver order be adopted.

### 2.5 Explanation needs both decision and outcome evidence

A useful explanation answers: what did this person observe; what alternatives were offered; which were physically excluded; what rule or score selected the proposal; did a counterparty agree; what changed before execution; and what finally happened?

The saved traces include snapshots, candidate action keys, named score terms, rule priorities, chosen actions, probabilities and draws where applicable, recipient responses, and pre/post transaction state. The snapshots include affinity and contact as well as changing beliefs and claims. Rule traces include scores only for comparison: those scores were not the rule policy's cause of choice.

For stochastic selection the honest explanation is, for example, “this candidate had probability p and the recorded draw selected it,” accompanied by the preference terms. It must not be rewritten as “this was the strongest motive” when another candidate had a higher score. Exact replay is evidence about execution, not proof that the encoded explanation captures human motivation. The traces do not contain a complete rejection ledger for unoffered actions or a causal dependency graph; generic stale-action reasons must be reconstructed from recorded state and predicates. This remains an instrumentation limitation.

### 2.6 Household feedback is an interface requirement, not permission to invent recognition

If another workstream supplies a recognized collective actor, Task D should be able to consume a specific constraint or opportunity with an explanation: access to a shared resource, an accepted care commitment, a coordinated task, or a represented claim on effort. It should not receive an unexplained bonus merely for “being in a household.”

This gives a possible feedback loop: individual actions alter specific relations; a separate process interprets a collective configuration; an explicitly grounded collective condition changes an individual's opportunities or burdens. The present harness tests only the first part and selected distinctions among relations. A live collective-feedback interface remains a next validation task; no household-dependent feasibility or utility callback is claimed to have been implemented.

## 3. Credible approaches discovered

### Ordered rules and production-style selection

A small rule interpreter matches a situation, selects among applicable rules and produces an action. Production-rule systems and cognitive architectures appear as distinct families in the social-simulation survey [S1]. The Task D version makes conflicting priorities inspectable: fulfil a due commitment before discretionary assistance, subject to the person's configured threshold and self-maintenance priority.

**Research judgment:** this is a credible minimal contender when the important behavioral differences are categorical or priority-based. Its danger is accretion: adding a separate exception for each scenario can disguise a story script as general agency. Rules should be expressed over reusable action meanings and relationship facts, not actor names, fixture labels or desired household outcomes.

### Explicit component scores, deterministic or probabilistic

The local prototype computes a sum of named contributions for each current action: own material cost, relief to a valued other, expected reciprocity, fulfilment of a commitment, exposure and action-specific costs. Deterministic selection chooses the highest present score. Softmax uses the same score with an exposed temperature and seeded draw.

These are fully specified experimental mechanisms, not an imported claim that people maximize utility. They permit direct inspection of trade-offs but introduce scale choices: enough of one consideration may compensate for any finite amount of another. A nonnegotiable prohibition or priority cannot be represented faithfully by indefinitely increasing a coefficient. A staged or lexicographic rule may be the more faithful extension.

### Reusable social practices and social interaction models

Comme il Faut provides an authoring precedent for reusable social interactions rather than isolated situations [S2]. Versu provides a particularly relevant separation: social practices offer possibilities, while individual agents retain the decision to act [S3]. Neither publication establishes the correct household or agency model for this project.

**Research judgment:** borrow the separation of opportunity from individual choice, not either entire architecture. A generic “offer support” practice could identify roles, admissible responses and consequences while leaving why A offers and why B accepts to individual policy. This is an orthogonal composition layer, not a competing selector that must replace rules or scoring.

### BDI and explicit commitment/plan models

Belief–desire–intention approaches provide an established route for representing beliefs, goals and persistent intentions [S6]. Recent work explicitly separates BDI reasoning/control flow from how it is embedded in a simulator [S11]. The potential benefit here is maintaining a purpose through intermediate steps or recovering after a plan is interrupted.

**Research judgment:** retain this as an enrichment path, not a required initial package. The present recurrent-support fixtures do not discriminate its benefits. A failed delayed-benefit fixture would justify trying a bounded goal/plan layer. Choosing “BDI” alone would not solve action semantics, conflicting commitments or counterparty consent.

### BOID and norm-sensitive conflict resolution

BOID explicitly distinguishes beliefs, obligations, intentions and desires and addresses their conflicts [S5]. That makes it relevant where a promise is not just another soft preference.

**Research judgment:** the useful question is whether the prototype needs categorical precedence, defeasible norms or compensatory trade-offs in a given situation. The obligation microprobe supplies an immediate discriminating example. A complete BOID implementation was not tested; a transparent priority rule can investigate the narrower question first.

### Consumat-style switching between decision modes

Janssen and Jager's model distinguishes deliberation, social comparison, repetition and imitation under different conditions, relating needs to opportunities and abilities [S4]. This is materially different from always applying one selector.

**Research judgment:** this becomes attractive when habits, copied practices or responses to uncertainty are themselves research targets. For this prototype it adds a second modeling problem—why the person switches modes—before the need for that machinery has been established. Nothing in the experiments tests imitation or the empirical validity of those switching conditions.

### Behavior trees and bounded planning

Behavior trees organize execution hierarchically and are discussed as modular control structures in the robotics/AI literature [S7]. A bounded planner instead searches action sequences toward an outcome.

**Research judgment:** a behavior tree could implement an interaction's stages without supplying the motive for entering it. A planner can cross the delayed-benefit obstacle but needs a consequence model and an account of others' cooperation. Neither should commit other actors merely because a planned sequence assumes their participation. The depth-two probe is an actual sequence search, not a full implementation of a published planner or behavior-tree system.

### Learned policies and language-model agents

Reinforcement learning is a separate commitment to learning through interaction and reward [S8]. Generative Agents combines language-model memory retrieval, reflection and planning in a small simulated environment [S9]. These are legitimate different approaches, not merely more elaborate rule lists.

**Research judgment:** neither is required by the present evidence. A learned policy would add questions about the training objective, distribution and attribution. A language-model agent would add model/prompt/version dependencies and a gap between narrated reasons and the exact state transition. Either could later serve a bounded experimental role; neither should be presumed the smallest auditable runtime mechanism. No learning or language-model benchmark was conducted.

## 4. Comparison

The table expresses **project-specific research judgments**, not published benchmark rankings. A published precedent is not evidence that a particular package meets the accepted foundation.

| Approach | Main contribution | Main complexity or failure risk | Observation and scaling implications | Migration / reversibility |
|---|---|---|---|---|
| Ordered rules | Explicit priorities and exceptions | Priority conflicts; scenario-specific rule growth | Rule matches and precedence can be traced; testing combinations becomes the burden as rules grow | Easy to swap when actions/effects remain separate; hard if effects are embedded in rule bodies |
| Decomposed current score | Transparent trade-offs across heterogeneous people | Arbitrary scales; compensation where it is not intended; myopia | Every term can be logged; local evaluation is inexpensive for a bounded menu | Weights/features can change without altering claims; normative or sequential additions may require a different selector |
| Softmax over score | Controlled variation with explicit probabilities | Temperature, menu multiplicity and response noise alter outcomes | Requires draws and full candidate probabilities; more stochastic repetitions are needed | Can be disabled at temperature zero; changing the action menu changes the effective policy |
| Social practices | Reusable interaction roles and possibilities | May become a concealed collective controller | Trace which practice offered an action and who accepted; multi-role combinations can grow | Useful over either rule/score choice if not tied to storage or household recognition |
| BDI / bounded goal-plan layer | Intention persistence and intermediate steps | Plan library, replanning and interaction assumptions | Must expose adopted/abandoned plans as well as final action; search or competing intentions add cost | Can be layered over existing operators; difficult if a planner assumes unilateral world effects |
| BOID / norm-sensitive priorities | Explicit conflicts among different reasons | Norm precedence and exceptions still need specification | Norm and conflict-resolution trace required | Can begin with narrow priorities; avoid encoding all obligations as untyped coefficients |
| Consumat-like mode switching | Habit, imitation and selective deliberation | Switching criteria and social information model | Explain both chosen mode and chosen action | Add only for a tested need; imitation changes the observation interface |
| Behavior-tree execution | Modular staged behavior | Trees can encode complete desired stories | Trace control path and interruption; no automatic interpersonal conflict solution | Replaceable executor if motive selection remains separate |
| Learned / language-model policy | Adaptive or open-ended behavior | Training/prompt objectives, provenance, reproducibility, inference burden | State-action logs alone may not explain learned internal causes | Requires explicit version boundaries and a preserved deterministic reference |

### What complexity can and cannot be inferred

For a proposed bounded local design with h relevant contacts, a action templates per contact and k constant-cost features, enumerating and scoring candidates is approximately O(hak), before claim lookup and explanation storage. This is a derivation under stated assumptions, **not a measured performance result**. The disposable code scans claims directly, so it does not satisfy constant-cost lookup as population and history grow.

A naive depth-d sequence search with branching b can explore order b^d candidates. A plan library changes that trade-off but introduces authoring and plan-selection costs. Multi-party consent, competing resource reservations and long histories may dominate either selector. Four-person tests cannot establish population-scale performance; neither Python nor the JSON representation is proposed for production.

### What remains genuinely undecided

The baseline fixture cannot choose between priorities and scores because both produce the same selective support pattern. The conflict microprobe distinguishes their semantics, not a universal winner. Softmax creates variation but does not establish a need for randomness. Likewise, memory updates matter to some trajectories, but the baseline does not prove that the particular reliability variable is necessary. The return therefore preserves multiple credible candidates rather than forcing one architecture.

## 5. Worked social-fabric examples

### 5.1 Experimental setup shared by the strongest candidates

Four adults have differing preferences and prior familiarity. A and B reside at P; C at Q; D at R. A/B have an initial joint asset claim, but that claim does not imply a household or permission to control anyone's actions. No initial household or repayment claim exists.

In even-numbered rounds A receives three fixture tokens and D two; in odd rounds B receives three and C two. Each live person requires one token. Unspent tokens expire. These exogenous opportunities make reciprocal support possible without implementing a production or subsistence system. Each actor has two initiative slots per round. The same action generator and resolver serve all candidate policies.

The score weights are: A=(1.0,1.6,.8,1.6,.7), B=(1.1,1.2,1.3,1.4,1.0), C=(1.0,1.5,1.0,1.2,1.0), D=(1.7,.2,2.0,.05,2.0), ordered as material/care/reciprocity/commitment/autonomy. D's authored profile makes an expected return attractive but gives little independent weight to fulfilling an obligation. These are explanatory fixture choices, not psychological findings.

### 5.2 Example one — A recurrent domestic support arrangement forms

**Ordered rules, predetermined seed 0.** At round 0, A gives to B, while D offers a loan to C and C accepts. At round 1, B gives to A, and C repays D's named claim. A gives again at round 2. Subsequently B's reciprocal lending and A's repayment recur, alongside the C/D loan–repayment cycle.

**Deterministic scoring, the same seed and initial situation.** A again gives to B at round 0, and D lends to C. At round 1, B chooses a loan to A rather than a gift; C repays D. A subsequently repays B, and the cycle continues. No condition in the selector names A/B as a desired group or instructs a household to form.

Across the 30-round seed-0 runs, both policies produce A→B, B→A, C→D and D→C, with 15 completed token transfers along each directed edge. Rules produce three gifts, 29 loans and 28 repayments; scoring produces one gift, 30 loans and 29 repayments. A newly created last-round claim remains open rather than being declared a default at the cutoff.

**Household-level interpretation, explicitly conditional.** A/B now have recurrent support coupled with existing co-residence; their domestic organization is more than a residence label alone. C/D support one another despite separate residences. A separate household process could assess whether either arrangement warrants a collective identity and why. Task D provides the causal substrate; it does not count these pairs as two households or equate reciprocal credit with householdhood.

This example is narrow. The deterministic fixture produces dyads, not a validated three-or-more-person household, and the people already know one another. New contact formation, moving residence and emergent division of labor are not demonstrated. Those limits matter: stable dyads in a complementary resource schedule are easier to generate than richer domestic organization.

**Softmax variant.** At seed 0, D's accepted round-0 loan to C makes A's independently selected gift to C stale. A then gives to B in the next slot. Across the complete run, nine directed support edges appear and two units remain unmet. Across 50 seeds the mean is 9.58 edges, with a range of 7–12, rather than the deterministic four. This shows a less concentrated interaction network, not a more realistic household system.

### 5.3 Example two — Partition, pressure and loss change the arrangement

The `pressure_loss` fixture begins identically. At round 12, a joint store claim is partitioned into separate claims for A and B, with access unchanged. From round 16, B's odd-round allocation falls from three to two. At round 22, A becomes unavailable. The fixture does not instruct anyone to split, create a successor or inherit A's claims.

**Partition alone.** In a separate metamorphic test, the `partition_only` and baseline fixtures produce identical choices and metrics for three candidate policies over five seeds each. Their final asset claims differ. This checks that a title change with explicitly unchanged opportunities does not accidentally sever support. It does **not** establish that real resource partition is socially irrelevant; changed access, beliefs or authority would require a different experiment.

**Rules and scores under loss, seed 0.** D and C continue their support cycle after A is unavailable. B cannot continue A/B exchanges and sometimes offers a loan to D instead. At rounds 23 and 25, C's earlier repayment leaves D no longer needy, so B's proposal becomes stale. At round 27, B's loan resolves first and is accepted; C's separate repayment also occurs. This creates a new B→D support/claim relation without a household-transition instruction.

At round 28, D lends to C rather than repaying B. D later requests an extension from B, who is then in shortfall and refuses. At round 29, B accepts a renewed extension when its own situation permits waiting. C repays D. Under scoring, B also withdraws its discretionary support to D; under the seed-0 rule policy it does not, because its withdrawal priority needs more missed rounds. The extension and withdrawal affect different meanings: postponing an existing claim does not force future voluntary lending.

This sequence is the clearest demonstration of conflicting interests in the fixture. D's current-score choice favors another prospective return; B responds to its own situation rather than to D's motive. The code records an unfulfilled claim after some observed surplus. That is **not proof of deliberate exploitation**: with several obligations, some surplus may be insufficient to meet all of them. The recorded belief update is a contestable hypothesis, not a diagnosis of intent.

At the end of both seed-0 deterministic runs, there are 53 completed transfers and four unmet units. Rules have two open claims, one accepted extension and no withdrawal; scoring has two open claims, one accepted extension and one withdrawal. Existing relations involving A are not reassigned to an inferred heir. The continuation of C/D and the new, contested B/D relation are lower-level evidence of reconfiguration—not proof of household continuity or fission.

### 5.4 Baseline results over seeds, rather than selected anecdotes

Each row below contains 50 seeds, 0–49. Unmet units are summed one-unit person-round deficits, not historical welfare or a household-quality measure. The formation denominator is 120; pressure/loss has 112 because A is unavailable in the final eight rounds.

| Fixture | Policy | Unmet units: mean [observed range] | Completed transfers: mean | Withdrawals: mean | Distinct choice fingerprints |
|---|---|---:|---:|---:|---:|
| Formation | Rules | 0 [0–0] | 60.00 | 0.00 | 1 |
| Formation | Deterministic score | 0 [0–0] | 60.00 | 0.00 | 1 |
| Formation | Softmax, τ=.35 | 2.50 [0–7] | 62.70 | 2.28 | 50 |
| Formation | Passive control | 60 [60–60] | 0.00 | 0.00 | 1 |
| Formation | Uniform control | 28.58 [21–38] | 42.70 | 6.14 | 50 |
| Pressure/loss | Rules | 4 [4–4] | 52.96 | 0.72 | 4 |
| Pressure/loss | Deterministic score | 4 [4–4] | 52.96 | 0.92 | 4 |
| Pressure/loss | Softmax, τ=.35 | 6.16 [4–15] | 54.22 | 2.42 | 50 |
| Pressure/loss | Passive control | 56 [56–56] | 0.00 | 0.00 | 1 |
| Pressure/loss | Uniform control | 27.80 [21–36] | 38.42 | 5.22 | 50 |

Evidence: `results/summary.json`, baseline groups. A fingerprint describes a sequence of chosen action keys, not every event or a household trajectory. Mean transfers can exceed the unmet-need reduction because a repayment can go to a person already provisioned; gift, loan and repayment are not interchangeable outcome counts. None of these metrics is used to optimize a group-wide objective.

### 5.5 What perturbations actually discriminate

The robustness groups use seeds 0–19, so comparisons below refer to those groups, not an unreported population estimate.

**Remove commitment preference.** Formation unmet units rise to a mean of 11.45 under rules, 15.10 under deterministic scoring and 12.25 under softmax. In pressure/loss they become 15.50, 21.05 and 14.35 respectively. In this authored environment, repayment motivation materially supports recurrent exchange. This does not prove that an independent commitment coefficient, rather than another representation of obligation, is necessary.

**Remove relational valuation.** Both deterministic candidates make no transfers and reproduce passive-control shortfalls. Softmax still transfers because it assigns positive probability to otherwise unattractive actions. The finding exposes the model's mechanism and the distinction between noise and motivated support; it is not a general empirical claim that all support requires these particular terms.

**Disable reliability updates.** Formation remains at zero shortfall for both deterministic policies. In pressure/loss, rule-based withdrawals disappear in this 20-seed group, while score-based withdrawals remain. Claim-miss records still exist, so “memory off” is not “history erased.” The scalar update is consequential for some sanctions but is not proven essential for the initial support arrangement.

**Change resolution order.** With fixed actor order, both deterministic policies average one withdrawal in pressure/loss; with reversed order, both average zero. Both still have four unmet units. Aggregate provisioning therefore conceals a socially meaningful order effect. The default keyed-order runs already produce four different deterministic choice fingerprints in this fixture.

**Reduce initiative capacity.** One slot rather than two leaves deterministic formation shortfall at zero but raises softmax's mean to 18.40. Some stochastic errors or refusals can no longer be repaired within the round. Randomness cannot be assessed independently of response opportunities and action costs.

**Change temperature.** Formation mean shortfalls at τ=0, .15, .75 and 1.5 are respectively 0, .35, 7.65 and 12.80. Pressure/loss means are 4, 4.40, 10.55 and 16.00. Zero temperature reproduces deterministic choices; larger temperatures are not automatically more plausible behavior. The tested values are uncalibrated sensitivity settings.

### 5.6 Two small falsifying probes

**Competing obligation and immediate care.** A has two tokens, owes a due unit to B, and C is currently needy. The rule policy selects repayment by priority. With A's care weight 3, commitment .6 and affinity toward C .9, the score policy chooses a gift to C: 2.5325 against repayment's .5225. Raising commitment to 6 changes repayment's score to 6.4625 and reverses the choice. The two candidates embody different normative semantics; neither is validated by meeting more needs in an unrelated fixture.

**Delayed benefit.** Initially, wait returns zero. Prepare costs one and enables complete, which returns three on the next step. The specified immediate maximum chooses wait. Enumerating two steps finds prepare→complete with total return two. This is a counterexample to unrestricted myopic sufficiency. It is not a household experiment, evidence about human planning, or a full BDI/GOAP benchmark.

An additional menu probe shows that softmax over three equal-score options gives support-to-B probability 1/3; adding a second effect-equivalent support-to-B option changes its aggregate probability to 1/2. Candidate-order invariance does not solve candidate-duplication bias. An enriched action repertoire therefore needs an explicit semantic-duplicate or hierarchical-choice treatment.

## 6. Failure modes and falsification conditions

**Apparent emergence that is authored into the menu.** Reject a candidate if household-like patterns appear only because the generator names favored pairs, deletes all competing actions, or invokes an aggregate transition. The current generator uses general predicates, but complementary supplies and initial affinity still heavily shape the result. Successful variation across different fixture families is needed.

**Loans mistaken for all social obligation.** This research uses credit-like promises because their conservation and fulfilment are easy to inspect. It would be a bad foundation if kinship duty, care, service, affiliation and dependency could only be represented as loans. Test distinct obligation meanings before promoting the toy representation.

**An aggregate score erases categorical distinctions.** A compensatory score fails its intended purpose when a represented nonnegotiable priority can always be outweighed by enough unrelated benefit. Conversely, a hard rule fails when it prevents the very norm conflict, refusal or violation being investigated. The obligation probe requires a deliberate modeling choice, not a generic “utility versus rules” verdict.

**A person's intention becomes somebody else's action.** Any implementation that transfers another person's resources, commits their future work or creates their accepted obligation using only the initiator's score fails agency separation. The loan/refusal and extension tests cover this narrow issue; multi-party commitments and coercive actions remain unimplemented.

**Timing becomes an invisible social theory.** A candidate is unsuitable if unexamined iteration order determines durable relationships. Our own order perturbation demonstrates this risk. Revalidation prevents inconsistent transfers but does not establish that the priority mechanism is behaviorally appropriate.

**Noise masquerades as motive.** Uniform choice produces varied ties without a credible account of individual reasons. Softmax can do the same at a high temperature or with duplicated options. More network edges or more narrative surprises are not validation criteria.

**Misfortune becomes automatically inferred betrayal.** The reliability rule observes some surplus, not full capacity to satisfy all competing claims. An overburdened debtor can therefore be treated as unreliable without sufficient evidence. Future work must distinguish what happened, what each person knew, and how they interpreted it.

**The agent cannot begin necessary intermediate action.** When a target scenario requires costly preparation, travel, negotiation or continuing commitment with no immediate positive score, the demonstrated myopic policy can fail. Add a bounded persistent goal or sequence mechanism and rerun the same discriminating case; do not hide the goal in a special action bonus named after the desired outcome.

**Successful software tests are confused with social validation.** Conservation, replay and consent tests establish properties of this code under specified inputs. They do not validate ancient motives, household membership, demographic patterns or institutional rules. No historical claim is warranted by the 1,740 episodes.

## 7. Recommended next validation

The next work should discriminate among surviving choices, not broaden the model indiscriminately.

**First, build a richer three-or-four-person domestic fixture with multiple relation meanings.** Keep the people constant but vary co-residence, caregiving, use rights and a non-credit obligation independently. Include support without co-residence and residence without support. Acceptance condition: both selectors can explain the choices without collapsing these relations or adding named-person rules. Household recognition should remain outside the agency test and be supplied only through an agreed interface.

**Second, make obligation conflict the central test rather than an incidental event.** Compare categorical priority, defeasible priority and compensatory trade-offs over the same mutually incompatible commitments. Introduce overload, inability and refusal as distinct observable situations. Acceptance condition: a reviewer can identify which assumption changes the outcome and why; reliability should not silently treat every shortfall as unwillingness.

**Third, add one costly multistep social action.** A bounded invitation/negotiation/coordination sequence should require preparation and survive one interruption. Compare reactive choice, a minimal persistent intention and bounded lookahead with the same operators. Acceptance condition: sequence machinery supplies an actual missing capability and does not control counterparties by assumption.

**Fourth, compare resolution semantics independently of the selector.** Vary keyed priority, explicit reservations, and compatible simultaneous execution. Measure which relationships and claims change, not just aggregate unmet needs. Separate initiative-selection noise from response noise; the present softmax policy applies one temperature to both. Acceptance condition: order-dependent outcomes are either explained as modeled features or reduced by a justified mechanism.

**Fifth, test household feedback with an externally supplied, inspectable collective condition.** For example, expose a represented shared-use opportunity or accepted care schedule, with named underlying claims. Change that condition while holding individual dispositions fixed. Acceptance condition: individual choices respond through the stated opportunity or burden, without an unexplained household bonus or membership-derived ownership.

Only after these tests should scaling or learning be prioritized. Scale by relevant contacts and claims before increasing population indiscriminately. Demand a causal benefit from adaptation beyond scalar reliability; compare it against frozen parameters and preserved histories. These are advisory validation priorities, not project tasks or approved specifications.

## 8. Sources and experiments — precise provenance

### Input and reading scope

The only dispatch contents read were the five Markdown files within the TRES-0001D pack: read-me, accepted foundation, prototype boundaries, shared research protocol and Task D. Exact copies, archive-member paths, sizes and SHA-256 values are in `input_context/manifest.json`. Other task contents were not used. Input scope establishes constraints; the recommendations and experiments do not acquire the same authority.

### Literature evidence

Eleven primary-source records support the targeted review. Their exact bibliography, URLs, publication dates, inspected access level and claim limitations are in `02_SOURCES_AND_EVIDENCE.md`. The review includes an April 2026 paper on BDI testing/granularity [S11], rather than treating all tooling assumptions as fixed at older publication dates. Older foundational sources are used for their concepts, not as current-software recommendations.

The model documentation follows the rationale of making purpose, state, scheduling, initialization and submodels explicit, emphasized by the ODD update [S10]. It does not claim full ODD certification. Some sources were available only as official abstracts; no inaccessible full paper or source implementation is represented as inspected.

### What was executed

`experiments/agency_lab.py` contains the small world, action generator, selectors, counterparty decisions, resolver and traces. `PARAMETERS_AND_ASSUMPTIONS.md` explains every score family, threshold, preference table and scheduling assumption. `EXPERIMENT_DESIGN.md` records the exploratory design, including its non-preregistered status and negative controls.

`run_experiments.py` generated 500 baseline episodes (2 fixtures × 5 policies × 50 seeds), 1,080 robustness episodes (9 variants × 2 fixtures × 3 candidates × 20 seeds) and 160 temperature episodes (4 temperatures × 2 fixtures × 20 seeds). The total is **1,740**, excluding the six additional seed-0 trace runs, separate microprobes and unit-test invocations. The code is Python standard library only. The tested environment is Python 3.13.5 on the Linux environment recorded in `results/run_receipt.json`; this is an experiment implementation choice, not a proposed project stack.

All episode summaries are retained in `results/episodes.jsonl`; grouped means and observed ranges are in `summary.json` and `SUMMARY.md`. The six traces were chosen by seed 0 in advance, not selected for successful narrative outcomes. `micro_probes.json` retains all alternatives and terms for the obligation comparison, the enumerated two-step plans and the option-multiplicity calculation.

### Verification and limits

All **22 unittest methods passed**. Checks cover exact replay; logging not affecting outcomes; complete relation fields in decision snapshots; candidate permutation and unrelated random-draw independence; temperature-zero equivalence; partition with unchanged access; gift/loan distinctions; refusal without side effects; no double spending; creditor-controlled extension; support withdrawal preserving debt and other relations; residence/ownership separation; no inferred heir; passive/disconnected/self-sufficient controls; token/claim accounting; a disconnected observer's noninterference; relational-valuation ablation; conflict choice; and finite normalized probabilities. The full test names and output are in `results/test_results.txt`.

No cross-platform bitwise floating-point guarantee, extensive performance benchmark, historical calibration, empirical population estimate, complete plan architecture or end-to-end household validation is claimed. Exact replay was tested in the recorded environment. The receipt records source hashes and the episode-file hash; the return manifest additionally binds the report and supporting files.

Reproduction from the unpacked return:

```text
cd experiments
python -m unittest -v
python run_experiments.py --out ../reproduced_results
python agency_lab.py --policy greedy --scenario pressure_loss --seed 0 --out ../single_trace.json
```

Runtime timestamps and elapsed time in a reproduced receipt will differ. In the same recorded environment, compare episode content, source hashes and policy/trace fingerprints rather than expecting byte-identical receipt metadata.

## 9. Unresolved questions and assumptions

**What makes the lower-level configuration household-relevant?** Recurrent exchange and co-residence are observed independently here. Their sufficiency for a persistent collective actor is deliberately unresolved. The deterministic result is two dyads, and the experiment does not demonstrate collective agency or fission.

**Which motives are independent?** The five preference weights are authored and partly overlapping. Whether reciprocity is a disposition, expectation, obligation or learned relation-specific forecast is not settled. No minimum-dimensional model was proved; most thresholds were not subjected to removal tests.

**Which obligations can be violated, renegotiated or enforced?** The code has a consensual one-token claim with a due date, not a general normative ontology. A duty of care, a right of use and a promise of repayment may require different response and change semantics. No enforcement or coercion is modeled.

**What can a person know?** Agents use accurate local world state, with fixed known contacts and no communication delay. Reliability is an internal assessment, but recipients' resource situations and claims are not hidden. Partial observation, deception, mistaken beliefs and discovery of new relationships remain open.

**When is a proposal reconsidered?** Refused and stale proposals use a slot; immediate responses cost no slot. More or fewer opportunities change stochastic outcomes substantially. The relationship between perception, decision, execution and reassessment has not been selected for the project.

**How does intention persist?** No deliberate multistep household action exists. The separate preparation counterexample indicates where a memory of intended purpose may be necessary, but it does not establish the appropriate planning formalism.

**How should reliability respond to overload?** The present some-surplus rule can misattribute unfulfilled claims. It also uses a single scalar for beliefs that could differ by task, resource or relation. The model's simple updates are hypotheses to test, not facts to preserve.

**How would history-specific enrichment enter?** Historically grounded roles, duties, allowed actions, interpretive beliefs and consequences should be introduced as explicit evidence-backed content, not a generic “culture weight.” Many additions can reuse the action/resolution boundary; some will require a new selector or representation. “Extensible” does not mean every enrichment is safely expressible as another coefficient.

**Which results would justify keeping stochasticity or learning?** Variation alone does not. The next fixtures need an explicit reason to represent uncertainty, habit, imperfect choice or adaptation, together with a way to falsify the mechanism. The current results favor a deterministic reference for diagnosis, while keeping stochastic and adaptive variants available for controlled investigation.

**Bottom line:** preserve individual initiative, distinct relational meanings, counterparty response and inspectable consequences before committing to a richer mind model. The evidence supports a small comparative reactive prototype, with ordered priorities and explicit scores both still credible. It does not support an automatic household algorithm, a universal utility theory, or a canonical architecture decision.
