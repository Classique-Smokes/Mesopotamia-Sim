# TRES-0001C — Temporal Dynamics, Events, and Causal History

**Social Fabric Laboratory · Advisory research return · 19 September 2026**  
**Status:** Evidence, alternatives, and recommendations for the Master Architect; not an accepted architecture or implementation specification.  
**Project authority:** The five documents in the supplied `TRES-0001C_AGENT_PACKAGE`.  
**Research basis:** Sixteen primary technical references and twelve executed synthetic experiment groups.  
**Companion material:** Reproducible code, full results, scenario traces, source register, input copies, and checksums in `TRES-0001C_RESEARCH_RETURN.zip`.

Source references `[S01]`–`[S16]` resolve in section 8. Experiment references `[E01]`–`[E12]` resolve to named functions and output files in `experiments/`. `[P01]`–`[P05]` identify the supplied packet documents. Unless attributed to a source or experiment, architectural comparisons and proposals below are this researcher's analysis of the packet's objective.

## 1. Executive synthesis

### 1.1 The central finding

**The laboratory does not have one “time-model decision.” It has several separable decisions about time, activation, visibility, conflict resolution, process persistence, historical evidence, and recovery.** Treating them as a single choice between “ticks” and “events” would conceal the commitments that most affect social interpretation.

A fixed-step driver can produce causally legible records. A discrete-event driver can maintain ordinary current state rather than an event-sourced database. A process-oriented model can run on an event calendar. A hybrid can combine periodic and irregular activation without requiring every relationship to be numerically integrated. These are distinct combinations, not contradictory labels. Existing implementations illustrate these separations, but do not choose the appropriate combination for this project. [S01–S03, S07, S14]

The executed death and accumulated-breakdown fixtures produced identical semantic traces under a tick-driven agenda and a next-event agenda when their domain rules, ordering conventions, and integer-aligned times were held fixed. This is evidence that driver and domain semantics can be separated in a small fixture. It is **not** evidence that arbitrary tick and event implementations are equivalent, or that the fixture's household observation is a valid household-recognition model. [E08, E09]

### 1.2 What the architect most needs to retain

**Reproducible does not mean causally appropriate.** In a two-claim resource conflict, both FIFO executions were deterministic, but reversing insertion order changed the fulfilled claim. Independently validating both claims against the same unchanged balance and then combining them overdrew the resource. The missing element was an explicit resolution rule, not another seed or timestamp. [E01]

**A seed is only one part of an experiment identity.** Six actors received 720 distinct assignments of draws across 720 activation permutations from the same global stream. Stable semantic draw addresses produced one assignment across those permutations. The experiment demonstrates address stability, not statistical independence or cross-version compatibility. [E02; S10–S13]

**Scheduled future work is not an accomplished social fact.** A deadline usually makes a transition eligible for reconsideration. Whether its original conditions must still hold, have held continuously, or were irrevocably satisfied at creation is a substantive process rule. A Boolean guard alone failed the uninterrupted-duration test: an obsolete deadline fired at time 15 instead of the valid completion at 21. [E05]

**A state save is not necessarily a continuation save.** The checkpoint experiment reproduced its full continuation in fresh processes when it preserved pending work, generator state, ordering state, and process-condition state. Omitting the queue, resetting randomness, or resetting the interval generation each changed the continuation. [E03]

**History needs explicit explanatory links.** A list of changes can identify what was last written, but does not automatically identify the relationships, contested claims, conditions, rules, and prior developments that justified it. Provenance vocabulary helps organize that evidence; it does not supply the underlying social causal model. [S08; E12]

**Exact indefinite historical detail cannot have bounded total storage in general.** Two different ordered histories can have the same final state and the same net-change summary. Compression can be lossless; summarization generally cannot preserve every historical query. The viable objective is bounded active working state and controlled archive/query costs, with explicit statements of retained detail. [E07; reasoning in section 4.6]

### 1.3 Advisory direction

The strongest next foundation to validate is a **small, deterministic transition boundary with inspectable process state and provenance-bearing change records**, while retaining two implementation candidates: a staged fixed-step driver and a next-event driver. Introduce local analytical or numerical processes only where an actual rule requires them. Do not build a general-purpose hybrid federation merely to keep future possibilities open.

This recommendation is about separation of responsibilities, not acceptance of a queue, tick duration, database, class hierarchy, engine, or final schema. The implemented research fixtures deliberately stop short of selecting household recognition, individual motives, collective identity, or historical frequencies. The packet leaves those open. [P02–P05]

## 2. Problem decomposition

### 2.1 Distinct temporal questions

| Question | What must be distinguished | Failure when conflated |
|---|---|---|
| Time representation | Units, epoch, precision, range, elapsed duration | A “day” becomes an accidental update count; fine events disappear on long horizons. |
| Activation | Periodic review, known deadline, condition change, autonomous action opportunity | Nothing notices a time-only condition, or every entity is scanned unnecessarily. |
| Ordering | Earlier time, same-time causal reaction, arbitrary serialization | Container order becomes a hidden allocation or social priority rule. |
| Visibility | Pre-state, intermediate state, committed state, information available to an actor | Agents act on inconsistent snapshots or know changes instantly without a stated assumption. |
| Transition semantics | Proposal, eligibility, validation, conflict resolution, accepted effect | A scheduled intention is recorded as an outcome before it succeeds. |
| Process lifecycle | Waiting, accumulating, interrupted, resumed, completed, invalidated | Save/load loses unfinished obligations or executes stale completions. |
| Randomness | Generator, state/address, decision purpose, opportunity identity | Unrelated code changes alter who gets which draw. |
| Causal evidence | Trigger, enabling facts, contributing process, rule, rejection, effect | Chronological adjacency is presented as an explanation. |
| Recovery | Re-execution, historical fact replay, exact continuation, branching | A reconstructed present cannot actually resume its former future. |
| Retention | Active state, checkpoints, detailed archive, summary, index | A compact display is mistaken for a complete historical archive. |
| Mixed rhythms | Local update rate, valid-through time, synchronization boundary | A fast subsystem consumes a slow subsystem's obsolete value. |

These questions can share machinery, but each needs a stated meaning. The source literature offers examples of explicit boundaries rather than a universal answer. [S04–S09]

### 2.2 Simulated time is not wall-clock time or record order

For an experiment, simulated time locates changes in the modeled world. Wall-clock time measures execution cost. A record sequence provides an unambiguous commit order. A causal dependency explains which earlier facts support an effect. None is automatically interchangeable with another.

A useful candidate representation is `(elapsed_time, reaction_index)` for same-time reactions, with a separate record identifier. Ptolemy's superdense time provides a concrete precedent. The reaction index distinguishes successive computations at one instant; it does not imply that one minute, day, or social deliberation period has elapsed. [S04]

Integer or fixed-point timestamps are credible for discrete commitments; floating-point time is credible where numerical models need it. The former requires a declared quantum, rounding policy, and overflow policy; the latter requires careful treatment of equality, boundary detection, and long-horizon precision. OMNeT++ demonstrates fixed-point time, while hybrid co-simulation research examines interactions among representations. Neither establishes the correct social time unit here. [S05, S06]

The precision experiment makes the issue concrete: `0.1 + 0.2` was not identical to `0.3`, and adding one to a binary floating-point timestamp of `2**53` did not advance it. Exact integer arithmetic advanced. These are representation counterexamples, not evidence that every floating-point simulation is unsuitable. [E10]

### 2.3 Occurrence, awareness, eligibility, and commitment

For the death example, at least four times could be different: death occurs; another person learns of it; a claim becomes eligible under its terms; a resource transfer or support arrangement is actually completed. The fixture may deliberately make awareness immediate, but that assumption should be named rather than hidden in a global event broadcast.

Similarly, a deadline can represent a guaranteed completion, the end of a waiting period, a review opportunity, an expiry, or an earliest permissible action. These have different behavior under interruption. The temporal mechanism should carry the relevant process state without deciding which interpretation applies to every domain.

The packet permits external scenario inputs because upstream systems do not yet exist. An injected death should therefore enter through a versioned, identifiable input and produce the same kind of accepted domain transition as a future lifecycle subsystem could request. It should not directly instruct the household to split, merge, replace members, or transfer every association. [P03, P05]

### 2.4 Current truth, persistence, and historical support

“Why is this true now?” can mean several different things:

- Which operation most recently changed this value?
- Which earlier commitments and circumstances support its current validity?
- Which lower-level histories accumulated into this collective condition?
- Why did an apparently possible alternative fail?

The first can often be answered from a mutation log. The others require additional evidence or re-execution. A long-lived claim may remain true because its creation remains valid and no terminating condition has been met; its latest write may be ancient. The relevant explanation is not necessarily the most recent nearby event.

A household projection and persistent household state are also different. A current coordination-capacity calculation may be derived from current lower-level commitments. A collective's accumulated memory, commitments, or path-dependent identity may require preserved state and history. Task C should support both without deciding which household attributes belong to either category. [P02]

## 3. Credible approaches discovered

### 3.1 Staged fixed-step execution

Advance through a regular grid. At each boundary, update time-dependent processes, gather eligible actions, resolve incompatible proposals, commit accepted changes, and refresh relevant derived observations. Sequential, shuffled, and multi-stage activation are established patterns; which produces the intended model is a separate question. [S03]

This is a credible laboratory baseline because inspection and reproduction can be straightforward. Its strongest form is not “call every person's mutation method in list order.” It makes explicit whether participants observe a common pre-state, whether accepted changes become visible within a step, and when follow-up reactions run.

Its cost depends on how much is examined at each boundary. A simple full scan is proportional to entities and steps even when nothing changes. Active sets, batched arrays, staged relationship passes, or periodic subgroups can reduce waste. Conversely, a dense workload may favor batched stepping over maintaining a large heap. The small scheduler benchmark exhibited both patterns. [E11]

**Principal migration risk:** domain logic written as “subtract one each tick” or “wait five updates” changes meaning when the step changes. Durations and rates should be expressed in declared simulated units, even in a fixed-step implementation. This is an advisory portability measure, not a selected unit.

### 3.2 Discrete-event / next-event execution

Advance to the next known activation time rather than through every empty interval. The pending item may be an action opportunity, expiry, process completion, review, external input, or predicted threshold crossing. SimPy is one established example of sequential discrete-event processing. [S01]

This is attractive when relevant changes are sparse and delays are important. It does not eliminate the need to find newly enabled conditions: each accepted change must identify what should be reconsidered, or the model must poll those conditions. Dependency maintenance and invalidation can dominate the cost of queue operations.

There is no rule that an event calendar must be a binary heap. A sorted agenda, time buckets, a calendar queue, or a simple ordered list may be suitable at different scales. This study benchmarked only a heap and a full scan; it did not evaluate specialized queues.

**Principal migration risk:** serializing anonymous callbacks, closures, or implementation-specific suspended computation can tie history and saves to one runtime. An explicit operation/process identity with inspectable waiting state is easier to reason about and migrate. That is a design argument, not a claim that every process library lacks extension mechanisms.

### 3.3 Process-oriented execution and explicit state machines

A process is a useful unit for a commitment that persists across time: initiated, waiting, interrupted, re-evaluated, fulfilled, contested, or terminated. A process-oriented implementation can suspend and resume code; an explicit state-machine implementation can store its current state and remaining conditions as data. Either can be activated by ticks, deadlines, or condition changes. [S02, S09]

For the laboratory, the important distinction is between **process identity** and **one scheduled wake-up**. A single support arrangement may reschedule several reviews without becoming several distinct commitments. Conversely, two parallel claims about one resource should not be collapsed merely because one handler processes both.

State machines help make waiting conditions and transitions inspectable. Their costs are state/transition proliferation and the risk of encoding a complete household story as a predetermined sequence. Use them to represent the lifecycle of a local obligation or process, not to prescribe an inevitable death-to-fission narrative.

### 3.4 Reactive dependency evaluation and rule closure

An accepted change marks relevant predicates, calculations, or rules for reconsideration. A worklist evaluates affected dependents and continues until a stable state, a boundary, or a diagnostic stop is reached. This can support immediate effects without repeatedly polling the whole world.

It is not a complete time model. A rule that becomes true solely because time passes needs a deadline, a periodic check, or an event-detection mechanism. A dependency index that watches only writes will not notice an unmaterialized continuous decay crossing.

Closure is especially simple for monotone accumulation of derived facts. Social changes can also retract, invalidate, or contest facts, so monotonicity cannot be assumed for the entire domain. An explicit microstep/run-to-completion model is a credible reference, but even SCXML distinguishes finite microsteps from a potentially nonterminating macrostep. [S09]

**Principal migration risk:** an initially convenient callback graph becomes opaque, cyclic, and order-dependent. The remedy is inspectable dependencies and explicit resolution/termination semantics, not merely replacing callbacks with an event bus.

### 3.5 Hybrid or multirate execution

Combine local periodic work, irregular deadlines, condition-triggered reactions, and—where justified—analytical or numerical processes. The common element is a coordination boundary, not necessarily a common update frequency. FMI and original hybrid co-simulation research demonstrate why activation, state exchange, and time advancement must be separate capabilities. [S06, S07]

A modest laboratory hybrid might be only a deadline agenda plus one periodic action-review pass. It need not contain numerical solvers, distributed services, or a standard-compliant co-simulation importer. Preserve that modest option before investing in general infrastructure.

A subsystem that updates every season cannot simply publish a stale value to another acting daily. It must offer a value valid for the read time, declare that its output is intentionally held constant, or expose an approximation/error policy. Early interruption and re-evaluation may be necessary when another subsystem changes its inputs.

**Principal migration risk:** “hybrid” becomes a promise to integrate any future subsystem without specifying coupling semantics. Strong instantaneous feedback or discontinuities may require synchronization, iteration, or smaller communication intervals. A wrapper alone cannot make incompatible assumptions consistent.

### 3.6 Analytical, numerical, and stochastic time-dependent processes

Gradual change is not synonymous with tick-by-tick mutation. Three credible cases are:

**Accumulated discrete developments.** Each interaction changes a relationship or process state. Gradual breakdown is the history of many distinct lower-level effects. No continuous decay equation is necessary.

**A known between-event evolution law.** Store a reference value, its reference time, and relevant parameters. Evaluate the value when needed and predict a threshold time when possible. If parameters or inputs change, invalidate the old prediction and recompute. The linear experiment demonstrated this case without numerical integration. [E04]

**A numerical or stochastic process.** A numerical solver may locate events while integrating continuous state, subject to error and event-detection limitations. A stochastic hazard process may represent opportunities through accumulated intensity and delayed outcomes. SciPy documents missed-crossing risks; Anderson's original research establishes a family based on integrated propensities, but this study reviewed only its abstract and did not reproduce its algorithm. [S15, S16]

These options should remain subordinate to the meaning of a future rule. Assuming that all relationship weakening is exponential decay, a Markov process, or repeated Bernoulli trials would already be substantive model selection.

### 3.7 History and recovery alternatives are a separate axis

**Current state plus explanatory records.** Current state is authoritative for execution. Accepted transitions append records containing causes and effects. Checkpoints preserve continuation state. This is simple to inspect, but the state update and record update must not silently diverge.

**Full event sourcing.** An authoritative sequence of committed facts reconstructs state through fact-application logic; current views are projections. This can support historical reconstruction, but introduces event-schema evolution, replay compatibility, ordering, duplicate-handling, and projection consistency responsibilities. A scheduled command is not automatically an authoritative fact. [S14]

**Initial state plus deterministic re-execution.** Preserve the initial fixture, admitted inputs, model/build/configuration, randomness contract, and ordering semantics. Regenerate the trajectory. This can be compact, but rebuilding a long history can be expensive, and exact reproducibility depends on preserving the execution environment and behavior. [S11–S13; E03, E12]

**Checkpoints plus a retained tail.** Start from a saved boundary and replay subsequent facts or rerun subsequent inputs, depending on the recovery contract. This can accompany either of the first two alternatives. Restoring visible world values is weaker than restoring an executable future. [E03, E07]

**Provenance records and historical summaries.** These can accompany any execution/persistence model. They improve explanation and navigation, but are not themselves proof that every past state is recoverable.

## 4. Comparison

### 4.1 Coherent candidates for this laboratory

| Candidate | Execution composition | History/recovery composition | Strong case here | Main risk |
|---|---|---|---|---|
| A: staged-step laboratory | Fixed steps; explicit proposals/commit; local same-time reactions where justified | Current state, causal records, full continuation checkpoints | Small, densely interacting fixture; easy inspection of stages | Step-dependent semantics; periodic global scans; artificial visibility lag |
| B: next-event laboratory | Irregular agenda; explicit process states; revalidated deadlines; affected-condition evaluation | Current state, causal records, full continuation checkpoints | Sparse developments, long waits, many distinct claims | Invalidation complexity; hidden callback state; accidental priority by insertion order |
| C: restrained hybrid | B or A plus independently scheduled periodic/analytical processes | Same historical boundary; process-specific continuation state | Demonstrated need for multiple rhythms or gradual between-event evolution | Coupling errors; generalized framework complexity before need is established |
| D: event-sourced variant | Any of A–C | Authoritative committed-fact log, projections, checkpoints | Strong demand for fact-based reconstruction and alternate historical views | Schema/reducer compatibility and total history obligations become foundational |

Candidate D is deliberately not a rival time driver. Reactive evaluation and explicit state machines are likewise components that can appear in more than one candidate. The evidence does not justify voting for one name as the entire architecture.

### 4.2 Complexity and scaling implications

Let `N` denote the active state examined by a full pass, `T/Δ` the number of fixed steps, `E` the number of actual activations/changes, `Q` pending work, `D` dependency-evaluation work, and `G` recorded provenance links.

A simple step loop does approximately `O(N × T/Δ)` eligibility work, plus actual transition work. A heap-based event driver does approximately `O(E log Q + D)`, plus transition work. These are descriptions of the named implementations, not universal bounds on all tick or event systems. Active sets, vectorized batches, event buckets, forecast invalidation, and dense contention can materially change practical results.

Historical recording costs depend on the number of committed records and relevant input links. A compact record should reference prior records rather than copy its complete ancestry. Otherwise long causal chains can cause repeated storage of the same explanation. Even with references, a broad ancestry query may legitimately visit many records; an index cannot guarantee constant-time answers to arbitrarily large explanations.

Checkpoint cost includes world state **and** pending process/scheduler state. If a checkpoint has size proportional to `N + Q`, producing one after every `K` changes adds roughly `(N + Q)/K` units of serialization work per change, ignoring compression and incremental techniques. This is a planning relation, not a calibrated performance forecast.

The experiment with 200 entities and 500 time units processed identical final states under both drivers. In the sparse case, the heap processed 200 items while the scan made 100,000 eligibility checks. In the dense case, the heap processed 80,000 items and was slower than the simple scan on this machine. **There is no evidence here for a universal event-queue advantage.** [E11]

### 4.3 Ordering, visibility, and conflicts

A candidate transition cycle is: identify eligible proposals; determine the state versions they observed; resolve incompatible effects; validate the accepted set; commit effects and their evidence; activate justified consequences. This is an analytical decomposition, not a required sequence for every operation.

Three resolution families remain credible:

**Explicit serial semantics.** Actions occur in a defined order and later ones observe earlier accepted effects. Appropriate when the model intends this asymmetry. An arbitrary stable identifier may make a run repeatable, but can systematically privilege some actors. The model must justify or test that choice.

**Snapshot proposals with joint resolution.** All participants propose against a common pre-state, and a resolver chooses a feasible accepted set. This can represent simultaneous competition. Read/write versions and an atomic update boundary are insufficient by themselves: a social/resource allocation rule is still necessary.

**Commutative or conflict-free batches.** Independent effects can be combined when their meaning permits it. Addition is not sufficient evidence of safety: two individually valid withdrawals can jointly exceed a balance. Also, an effect that writes one resource may invalidate a precondition another action read elsewhere.

In the claim test, a pool of 10 faced requests of 7 and 6. FIFO yielded two possible winners. Combining independently validated proposals yielded −3. An explicit fixture priority, applied to the batch, yielded one reproducible outcome. The priority is intentionally arbitrary and is not proposed as the project's rule for claims. [E01]

A single deterministic writer is a credible small-laboratory reference implementation. It reduces scheduling nondeterminism but does not solve fairness, simultaneity, or social validity. Distributed execution, optimistic rollback, and parallel conflict resolution should be reconsidered only after a measured need; this study supplies no production concurrency recommendation.

### 4.4 Delays, condition changes, and cascades

Every delayed process needs a stated relationship between its past and current conditions. Useful distinctions include: an irrevocable scheduled completion; an action requiring validity at execution; a condition that must remain true continuously; or a process with accumulated progress that survives interruptions.

For uninterrupted duration, track the identity of the qualifying interval—not merely a Boolean and not necessarily every revision of the whole relationship. Further deterioration while already below the threshold should not automatically reset a continuous weak interval. Recovery followed by renewed weakness should. The breakdown fixture implements that distinction. [E05, E09]

Cancellation can remove pending items eagerly, or leave a token/version that causes obsolete items to be rejected when reached. Lazy invalidation is simple but can accumulate stale work; eager cancellation requires an index and maintenance. Both still need protection against executing a completion whose meaning has changed.

Immediate reactions require their own semantics. Recomputing a derived capacity from accepted lower-level facts can be immediate. Deliberation, negotiation, transmission of information, and action performance should not become instantaneous merely because callbacks can run immediately.

The finite cascade test reached closure in three microsteps. A deliberately alternating pair remained active after sixteen and produced a stop diagnostic without advancing simulated time. A budget is an operational safeguard, not a proof of a cycle or a resolution of one. Silently inserting an epsilon delay would change the model while concealing the problem. [E06; S09]

### 4.5 Reproducibility, random decisions, and experiment identity

There are at least four different goals:

**Repeat the same pinned experiment.** Same initial state, rules, parameters, admitted inputs, ordering, and runtime produce the same trace.

**Resume it.** Save/load preserves the future, including waiting processes and generator state.

**Preserve unaffected decisions under a harmless refactor.** Reordering independent entities or adding unrelated instrumentation should not reassign their random draws.

**Run across environments or model versions.** This is stronger and may require pinned arithmetic, generators, distribution transforms, serialization, and execution environments. It should not be inferred from success on one machine. [S11–S13]

A global generator can satisfy the first goal while failing the third. Independent named streams or semantic draw addresses can improve isolation. A candidate address might include the experiment seed, purpose/version, stable participant or interaction identity, opportunity identity, and draw index. The exact scheme remains open.

Do not key draws merely by current time: two distinct opportunities can share a timestamp. Do not key only by a global event counter: an unrelated new event then renumbers later draws. A pair interaction needs a stable convention for participant roles and opportunity identity; sorting IDs is appropriate only if the interaction is genuinely symmetric.

Conditional branches and rejected proposals also need a policy. A retry may be the same opportunity and reuse its draw, or a new opportunity and receive another. Repeatedly redrawing until success changes the probability model. The experiment's scoped scheme shows isolation only; it does not establish a scientifically appropriate random-opportunity model. [E02; S10, S12]

For a constant hazard `λ`, the probability of at least one arrival over duration `Δt` is `1 − exp(−λΔt)` under the assumed Poisson model. Keeping a fixed “probability per tick” while changing tick duration does not preserve that model. Conversely, converting probabilities does not guarantee identical sample paths across different drivers. Stable coupling of random opportunities is a further question. This is a mathematical illustration, not adoption of a social hazard model. [S16 for the process family]

An experiment manifest should identify the initial fixture, inputs, rule/configuration version, time units and boundary conventions, randomness scheme, code/build/environment, and relevant dependency versions. Record input-admission order or target simulated time for interventions made during an interactive session; wall-clock arrival alone is not a replay contract.

### 4.6 Historical legibility, retention, and query cost

A compact causal record can identify the accepted effect; prior and resulting fact versions; process/action and origin; simulated time and commit position; rule and relevant parameters; material contributing or enabling facts; and any random decision reference. Rejected alternatives may need records too, particularly when a contested claim matters to the resulting household history.

This is a content checklist, not a schema proposal. W3C PROV supplies useful distinctions among generation, use, invalidation, and derivation. It explicitly cautions that an input's use does not automatically establish derivation of an output. The same discipline applies here: a debugging read set is not automatically the explanation of a social result. [S08]

A versioned history can represent feedback without creating backward causal links: household state at one boundary affects individuals; their subsequent actions change the relationships sustaining a later household state. Persistent entity identities may recur, while individual fact/transition occurrences remain distinct. A single mutable graph node without versioned occurrences can obscure that distinction.

For retention, distinguish:

| Layer | Purpose | Retention implication |
|---|---|---|
| Active world and unfinished processes | Execute the present and future | Keep what current rules actually require, even if historically old. |
| Recent detailed records | Debug and inspect nearby causes | A bounded hot window is plausible. |
| Checkpoints and segment indexes | Bound reconstruction/search work | Preserve compatibility, segment identity, and required continuation state. |
| Detailed cold archive | Exact historical events and explanations | Grows with retained information; compression does not promise constant size. |
| Historical summaries | Navigation and selected aggregate questions | Must declare lost ordering, omitted details, and source coverage. |

The 100,000-record experiment produced 9,154,631 bytes of compact JSONL and 1,142,032 bytes after lossless gzip compression. A checkpoint after record 98,000 plus a 2,000-record tail reconstructed the same values. A 200-row net summary was much smaller conceptually, but could not identify each ordered path. [E07]

A simple impossibility example is enough: changes `[+2, −1]` and `[−1, +2]` end at the same value, but differ after the first change. Any summary that retains only the net change maps both to the same representation. It cannot answer that intermediate-state query exactly. For arbitrary-length histories with continually arriving information, bounded storage cannot retain every distinction without additional assumptions or an external archive.

Do not compact away an old cause that remains necessary to a live claim's interpretation. A current relation may depend on its founding terms, amendments, disputes, and fulfillment history. Nor should an aggregate household summary silently become authoritative state and overwrite the lower-level evidence that supports it. The actual admissible compaction policy remains a model- and query-specific decision.

### 4.7 Recovery contracts and migration/reversibility

**Fact replay** reapplies recorded accepted effects. It should not rerun action selection or emit the side effects again. **Input re-execution** reruns the old rules and random decisions. **Checkpoint continuation** restores an unfinished execution. **Branching** changes an assumption/input from a known boundary and produces a new trajectory. These should have distinct names in any eventual tooling.

The fact-replay experiment reconstructed an old result while a changed rule produced a different re-execution result. Both are legitimate operations, but they answer different questions. A migrated historical fact record should not silently pretend that a new social rule governed the old run. [E12; S14]

For a continuation checkpoint, investigate preserving time and microstep; pending work and ordering identifiers; process state/progress; condition-interval generations; random state or counters; identity allocation; admitted/processed input identities; and the code/configuration contract. Derived caches may be rebuilt only when they are truly derivable and reconstruction does not change activation or draw order. The toy checkpoint validates a subset of these needs, not a general save format. [E03]

Migration is easier when domain operations name duration and intent rather than a specific scheduler API; process identity is separate from queue-entry identity; persistence does not depend on private callback frames; and explanatory records name rule versions and fact versions. It becomes expensive when every relationship has a tick method, household identity is inferred from storage grouping, or history depends on unversioned executable behavior.

## 5. Worked social-fabric examples

All names, numbers, thresholds, durations, priorities, and behavior in this section are **synthetic test assumptions**, not historical findings or accepted social mechanics. The examples demonstrate temporal execution and explanation. They do not validate a recognition, continuity, fission, motive, or demographic algorithm. [P02–P05]

### 5.1 Example 1 — Externally injected death with several existing claims

#### Initial lower-level fixture

Individuals P0, P1, P2, and P3 exist. An active support commitment from P0 contributes six units to a shared routine; a distinct commitment contributes four. P3 has a contingent reserve arrangement contributing three if its guard becomes valid and P3 remains available. These arrangements are separate from residence and ownership.

A tool has P0 as its current user and P2 as its title holder. An existing return claim becomes reviewable after P0's death. A separate resource pool contains ten units and faces existing claims A for seven and B for six, both activated for review by the same death. The fixture's explicit arbitration gives A precedence; this exists only to exercise conflict resolution.

An already-observed household reference `H_observed` has a derived routine-capacity observation based on those commitments. A routine requiring six units is feasible initially. The reference is a boundary placeholder—not a primitive membership container and not an implemented household-recognition algorithm. Keeping this placeholder unchanged proves nothing about genuine household identity continuity.

#### Actual traced sequence

| Time / boundary | Lower-level development | Explanation and subsequent work | Household-scale observation |
|---|---|---|---|
| 0 | Fixture establishes separate people, commitments, tool use/title, residence, and claims. | Initial facts are explicit roots of later explanation. | Capacity 10; fixture routine feasible. |
| 10, input/commit | Injected death of P0 is admitted and recorded with `scenario_injection` origin. | The life guard ends P0's support commitment; separate claim reviews become eligible. No household outcome is commanded. | At the following observation microstep, capacity is 4; routine infeasible. |
| 11 | Return claim completes under its fixture rule. | Tool user becomes P2; title remains P2. The death and original claim context support the transition. | No automatic change to residence, kinship, or household identity. |
| 12 | Reserve-support process is reconsidered after its delay. | It checks P3's current availability before activation. | Capacity rises to 7; routine feasible again. |
| 13 | Claims A and B reach joint resolution. | Against the shared pool of 10, the fixture policy fulfills A for 7 and leaves B unfulfilled; pool becomes 3. The rejection is part of the record. | Any additional household consequences must follow the changed claims and applicable collective rules, not a death script. |

The actual trace contains ten records. Source artifacts are `E08_death_calendar_trace.jsonl`, `E08_death_state.json`, and the E08 result object. Tool title and P1's residence remained unchanged. [E08]

The household change demonstrated here is a change in grounded coordination capacity and feasible collective activity, not an asserted split or dissolution. To test those latter outcomes, a separately authorized recognition/identity mechanism must consume the resulting lower-level changes. Temporal execution must allow it to do so; it should not contain the answer in a death handler.

#### Candidate A: staged fixed-step behavior

With one-unit steps and the stated integer-aligned inputs, admit the death at boundary 10. Commit its immediate lower-level consequences before the observation stage. At boundaries 11–13, reconsider the waiting return, reserve, and competing-claim processes. The same explicit claim resolver is used; scanning order does not determine ownership or priority.

A coarser step requires an explicit boundary policy. Rounding all developments to the end of a long interval could defer support loss or allow already invalid commitments to influence other actions. Substep processing can avoid that, but then the implementation is deliberately combining a step driver with finer temporal events. That is acceptable if stated.

#### Candidate B: next-event behavior

Place the death input at time 10. Its accepted transition activates the relevant local processes, which schedule reconsideration at 11, 12, and 13. Jump over empty intervals. At 12, check the guard again; at 13, resolve the joint claims against one consistent pool state. Same-time observation is ordered after the accepted lower-level effects.

The agenda contains pending work, not predetermined final outcomes. Cancellation, competing changes, or new facts may alter what succeeds. The timeline record must distinguish scheduling a review from fulfilling the claim.

#### Candidate C: restrained hybrid behavior

Use the same irregular transitions while a local routine-review mechanism runs at its own cadence. Any between-event capacity or resource process is synchronized to the read time. A slow review cycle must not justify using a dead provider's active commitment as though nothing had changed; either the life guard invalidates it immediately or the model must explicitly distinguish world truth from another actor's delayed awareness.

This variant was analyzed, not implemented as a general hybrid kernel. The actual E08 comparison used a tick-driven agenda and a next-event agenda sharing the same fixture transition functions.

#### Falsifying branch

Inject P3's unavailability at time 11. At time 12, the reserve process rejects completion; capacity remains four. The nominal delay reaching its endpoint does not override current invalidity. This branch was executed and is included as `E08_death_departure_branch_trace.jsonl`. It demonstrates why the death should activate a process rather than schedule an unconditional future support fact. [E08]

### 5.2 Example 2 — Accumulated relationship breakdown

#### Initial lower-level fixture and local process

A relationship-associated score starts at 100. Recorded developments change it by specified increments; a score at or below 65 starts a weak interval. The fixture withdraws one support commitment only after **five uninterrupted time units** of weakness. Withdrawal changes the capacity of the same illustrative shared routine from ten to four.

The score is only a controlled substitute for richer relationship developments. Neither that scalar nor the threshold is a proposed definition of a relationship or household. In particular, “score below 65” is not a household-fission command.

#### Actual traced sequence

| Time | Development | Accumulated state | Temporal consequence |
|---|---|---|---|
| 3 | First negative development, −12 | 88 | No weak interval. |
| 6 | Second negative development, −12 | 76 | No weak interval. |
| 9 | Third negative development, −12 | 64 | Weak interval starts; reconsideration due at 14. |
| 11 | Repair development, +10 | 74 | Weak interval ends; its scheduled completion is obsolete. |
| 12 | Further negative development, −12 | 62 | New weak interval starts; reconsideration due at 17. |
| 14 | Old deadline reached | Current state is weak, but from a different interval. | Reject the stale deadline; a Boolean-only guard would be wrong. |
| 15 | Further negative development, −12 | 50 | Weakness continues. This does not restart the existing weak interval. |
| 17 | Valid interval reaches five units | Weak interval from 12 remains valid. | Withdraw the specific commitment; next observation shows capacity four and routine infeasible. |

No calendar instruction says “household breaks down at 17.” The local commitment changes only after accumulated developments and the process's temporal condition. A future household mechanism may interpret the changed sustaining configuration as adaptation, continuity under strain, separation, or another outcome; that substantive mechanism remains open. The present fixture demonstrates a grounded collective consequence without claiming a validated household-fission result. [E09]

#### Candidate A: staged fixed-step behavior

Record each development when admitted; evaluate the weak predicate and retain the start/identity of its qualifying interval. At each relevant boundary, validate the elapsed duration and unchanged interval identity before committing withdrawal. A full scan can detect this, or the step driver can carry a due-work agenda. Both need the same condition semantics.

Do not count “five weak update calls.” Step refinement would then change the duration, and repeated callbacks within one physical instant could complete the process immediately. Elapsed simulated time is the relevant quantity under this fixture's assumption.

#### Candidate B: next-event behavior

Each development updates the local process. The first qualifying transition schedules a reconsideration at 14. Repair invalidates its interval generation. Renewed weakness schedules another at 17. At 14, the stale token is rejected even though the current Boolean condition is again true. The extra deterioration at 15 leaves the current interval intact.

This can avoid checking the relationship at every empty time boundary. It requires the relationship's relevant changes to notify the process; missing an invalidation is a correctness error, not simply a missed optimization.

#### Candidate C: analytical/hybrid extension

The actual example accumulates discrete developments and does not need continuous decay. If a later rule instead specifies a between-event law, a local process can retain a reference state and predict its next threshold or review time. External interactions interrupt that evolution and force synchronization/recalculation.

For the separate analytical fixture `x(t) = 1 − 0.013t`, the threshold 0.37 occurs at `630/13 ≈ 48.461538`. One-unit checks detect it at 49; quarter-unit checks at 48.5; hundredth-unit checks at 48.47. Those differences are grid detection delays under an exact linear law, not numerical integration error. After a rate change at time 20 to 0.006, the recalculated crossing is `245/3 ≈ 81.666667`; the original predicted deadline would be obsolete. [E04]

Numerical processes need an additional accuracy contract. A solver that examines sign changes can miss multiple crossings within one step. This is why a generic claim that “events solve temporal precision” is insufficient. [S15]

#### Falsifying branches

An additional repair of +30 at time 16 prevents withdrawal by the fixture horizon of 18. Removing the negative developments also prevents withdrawal. Both branches were executed. The household-capacity consequence is therefore contingent on its lower-level history, not merely on elapsed time or a predetermined scenario endpoint. [E09]

### 5.3 What an explanation should return in these cases

For the death case, a useful explanation of the restored shared routine would identify the original commitments, P0's death and lost support, the reserve arrangement, the guard evaluation at 12, and the resulting capacity—not simply “an event at 12 changed the household.”

For the breakdown case, it would identify the chain of contributing developments, interruption at 11, new interval at 12, continued weakness, rejection of the obsolete deadline, and commitment withdrawal at 17. The complete explanation can traverse the version chain; every record need not copy the whole chain.

The supplied toy records retain direct predecessor references and rule identifiers, but they are not a complete production provenance implementation. Initial facts are bundled in a fixture root rather than normalized into independently versioned claims, and not every negative predicate or read dependency is recorded. These are explicit limits of the experiment, not omissions to silently carry into the project.

## 6. Failure modes / falsification conditions

The following are discriminating failure tests, not accepted project specifications.

| Proposed approach or claim | Observation that would make it a poor foundation here | Consequence for further work |
|---|---|---|
| Deterministic serial ordering is enough | Renumbering unrelated entities changes who obtains a contested claim. | Separate incidental order from domain arbitration; test explicit alternatives. |
| Fixed-step logic is semantically stable | Step refinement changes a duration-based outcome beyond a declared detection tolerance. | Rewrite per-step rules in elapsed-time terms or admit step size is part of the model. |
| Event-driven conditions are complete | A condition becomes true through elapsed time but nothing wakes it. | Add an appropriate time-based detector/review, not an unrelated trigger. |
| Delayed completions are safe | An old timer succeeds after recovery and renewed qualification. | Track the relevant interval/process identity and revalidate. |
| Reactive closure is safe | An immediate cycle never reaches a stable boundary. | Stop with a trace; decide whether to revise logic, batch semantics, or real modeled delay. |
| Logs provide explanation | Only the latest setter can be found; prior supporting claims or rejected alternatives are unavailable. | Add justified provenance or state the explanatory limitation. |
| A fixed seed is enough | Harmless iteration changes or observer instrumentation reassign random decisions. | Isolate streams/opportunities and define the intended reproducibility level. |
| A world snapshot resumes the experiment | Restored future diverges despite equal visible state at load. | Inventory pending work, process state, random state, identifiers, and ordering. |
| Fact replay equals model replay | New rules alter what “replaying history” displays without an explicit branch. | Separate recorded-fact reconstruction from re-execution and migration. |
| Local rhythms are independent | A fast process reads a slow process at the wrong effective time. | Specify synchronization, held-value semantics, or bounded approximation. |
| Compaction preserves all history | Two distinct pasts share a summary but an exact requested query distinguishes them. | Retain detailed archive or explicitly narrow the supported query contract. |
| Scheduler efficiency establishes scalability | Dependency invalidation, global household refreshes, or causal queries dominate the run. | Profile complete transition paths, not only queue operations. |
| Household emergence was demonstrated | A death handler writes a split/merge, or a toy fixed household ID is presented as a continuity result. | Reject that validation claim; test the separately authorized collective mechanism. |

Additional failure risks deserve explicit attention: duplicated input admission; time-unit conversion at subsystem boundaries; committing the log without its corresponding state or vice versa; same-time birth/death/expiry precedence; changing a probability-per-tick without recalibration; and treating absence of a record as proof that an event could not have occurred. These follow from the distinctions above and remain targets for integration tests.

## 7. Recommended next validation

### 7.1 First: discriminate semantics, not frameworks

Use the actual authorized relationship and collective logic, once available, under both a staged driver and a next-event driver. Hold the same-time visibility and resolution rules fixed initially. Compare fact traces, causal supports, accepted/rejected proposals, and reconstructed state at agreed boundaries.

Then deliberately vary one semantic decision at a time: serial versus joint resolution; awareness delay; exact deadline versus periodic review; uninterrupted duration versus accumulated progress. A difference is not automatically an implementation bug: it may expose a substantive model choice that needs architectural reconciliation.

**Discriminating evidence:** a small fixture in which the two drivers cannot express the same intended process without distorting it, or in which one requires significantly more model-specific machinery. The present shared-handler equivalence tests cannot supply that evidence alone.

### 7.2 Second: test the failure surfaces exposed here

| Validation | Controlled variation | Evidence to collect | Rejection criterion for the tested implementation |
|---|---|---|---|
| Schedule independence | Input insertion, map order, entity storage order | Accepted effects and rule-resolver outputs | Unintended differences in independent or explicitly jointly resolved actions |
| Temporal sensitivity | Several step sizes; off-grid deaths, repairs, and expiries | Detection lag and downstream outcome changes | Effects exceed declared temporal semantics/tolerance |
| Guard coverage | Cancel, recover, requalify, contest, replace a dependency | Valid/obsolete pending work and its explanations | Stale process produces an accepted effect |
| Checkpoint completeness | Save at many waiting states and allowed boundaries | Full continuation trace/hash; unfinished work | Continuation differs under a pinned environment |
| Observer isolation | Add/remove tracing and queries | Same domain decisions and random addresses | Observation changes execution except for measured wall-clock cost |
| Provenance adequacy | Ask why a claim remains active and why its competitor failed | Minimal supporting paths and relevant rejected alternatives | Answer needs an invented narrative or unsupported causal link |
| Collective feedback | Lower-level change → collective state → later individual action | Versioned chain in both directions | Direct household commands substitute for grounded consequences |

No statistical household-success threshold is proposed here. These are structural and reproducibility tests of candidate mechanisms.

### 7.3 Third: measure workload shapes that could reverse the choice

Use sparse, dense, and clustered social changes; many long-lived waiting processes; frequently invalidated forecasts; high-degree relationships; and simultaneous claims over common resources. Record transition work, affected-state evaluations, queue size, stale-item fraction, active memory, history bytes per accepted effect, and explanation-query effort.

Do not impose a final population target: the packet explicitly leaves it unbound. Vary scale to locate trends and failure modes, and report the model/workload conditions alongside measurements. The 200-entity scheduler microbenchmark is useful only as a counterexample to universal queue-performance claims. [P03; E11]

### 7.4 Fourth: decide a historical service level

Run a long synthetic history containing both repetitive processes and rare changes with lasting significance. Compare full detail, lossless archival compression, checkpoints with bounded replay tails, and summaries with explicit coverage. Ask whether old live claims and household continuity explanations still have their supporting evidence.

A useful acceptance statement would specify which past states and explanations remain exactly recoverable, which are summarized, and what a missing archived segment means. Choose checkpoint intervals and indexes from measured recovery/query behavior. Do not label a lossy summary “complete causal history.”

### 7.5 Matters to resolve before accepting an implementation

The architect should explicitly resolve the intended same-time observation boundary; conflict-policy responsibility; time units and off-grid behavior; delay/interrupt semantics; the required level of reproducibility; the distinction between historical replay and new branches; and historical retention/query expectations.

These are consequential semantics. The choice of heap versus another agenda, a particular serialization library, a production datastore, or a generalized co-simulation framework can remain deferred until evidence requires it.

## 8. Sources / experiments

### 8.1 Supplied project sources

Only the following five packet documents supply project authority. Byte-identical copies and SHA-256 hashes are included in `input_packet/` and `evidence/INPUT_MANIFEST.json`.

| Reference | Supplied file | Role |
|---|---|---|
| P01 | `00_READ_ME_FIRST.md` | Independent-context, advisory role and scope |
| P02 | `01_ACCEPTED_FOUNDATION_CONTEXT.md` | Social-fabric foundation and explicitly unresolved decisions |
| P03 | `02_PROTOTYPE_OBJECTIVE_AND_BOUNDARIES.md` | Laboratory objective, permissible inputs, scale posture, exclusions |
| P04 | `03_SHARED_RESEARCH_PROTOCOL.md` | Evidence standards and required return structure |
| P05 | `04_TASK.md` | Task C question, investigative topics, two required examples |

The dispatch README was read to identify C and return handling. Contents of the other workstream packets were not used. Archive extraction was necessary because the attachment reader returned no readable text for the ZIP.

### 8.2 Executed experiments and findings

**Environment:** CPython 3.13.5, Linux x86_64; Python standard library only. Exact build/platform details and script hash are in `experiments/results/environment.json`. All twelve experiment groups passed their stated assertions, including expected detection of deliberately defective negative controls.

| ID / function | Executed investigation | Actual finding | Important limit |
|---|---|---|---|
| E01 `e01_conflicts` | Two competing claims, both insertion permutations, explicit batch rule, naive combined validation | Two FIFO outcomes; one explicit-policy outcome; naive balance −3 | Does not validate the arbitrary claim priority |
| E02 `e02_randomness` | 100 repeats; 720 actor orders; unrelated draw/scope | One repeat hash; 720 global assignments vs one addressed assignment; extra global draw changed all six actors | No statistical or cross-version RNG test |
| E03 `e03_checkpoint` | JSON checkpoint and fresh-process resume under two hash seeds; omitted-state controls | Matching full continuation; queue/RNG/generation omissions diverged; corruption/version mismatch rejected | No OS-crash or different-runtime test |
| E04 `e04_gradual_process` | Exact linear threshold with three step sizes and a changed rate | Exact crossing 48.461538; grid detections 49, 48.5, 48.47; changed-rate crossing 81.666667 | Arithmetic illustration, not a numerical or hybrid solver |
| E05 `e05_stale_timers` | Weak/recover/weak uninterrupted-duration test | Boolean guard first completes at 15; interval-aware completion at 21 | One explicit delay semantics |
| E06 `e06_cascades` | Monotone closure and a deliberately nonconvergent alternating reaction | Closure in three microsteps; diagnostic after 16 without time advance | Budget is not proof of general termination or cycle detection |
| E07 `e07_history` | 100,000 facts; compression; checkpoint/tail replay; lossy-summary counterexample | Same restored values; 9.155 MB raw, 1.142 MB gzip; 2,000-record replay tail | Warm in-memory JSON timing; not a storage engine |
| E08 `e08_death` | Death fixture under two drivers; six insertion orders; 100 repeats; unavailable-provider branch | Matching semantic hash; capacity 10 → 4 → 7; branch stays at 4 | Shared transition functions; household observation is a test double |
| E09 `e09_breakdown` | Accumulated developments under two drivers; repaired/no-negative branches | Matching semantic hash; stale deadline rejected at 14; commitment withdrawn at 17; branches prevent withdrawal by 18 | No household-recognition/fission/motive model |
| E10 `e10_multirate_precision` | Three activation rhythms; synchronized-value arithmetic; floating-point probes | 751 due callbacks vs 2,160 adapter checks; stale reads differ; finite precision counterexamples | Not a coupled solver or FMI implementation |
| E11 `e11_scheduler_workload` | Sparse/dense known-event workloads under full scan and heap | Equal final states; heap faster in sparse case, scan faster in dense case on this machine | Neither framework ranking nor capacity forecast |
| E12 `e12_replay_provenance` | Recorded-fact application, changed-rule re-execution, duplicate admission, explicit supports | Historical reconstruction preserved; changed rules differed; duplicate applied once | Minimal illustration, not a provenance engine/event store |

The first saved timing run gave median full-history reconstruction of **196.85 ms**, versus **3.79 ms** for checkpoint plus tail, over three repetitions. The scheduler medians over five repetitions were **3.36 ms scan / 0.040 ms heap** for 200 events, and **15.68 ms scan / 58.48 ms heap** for 80,000 events. These timings are diagnostic measurements of the supplied simple code on one machine. They are not general speedup promises. Raw values, event counts, and limitations are preserved in `results.json`.

**Validation rerun:** The twelve groups were rerun under the same code/runtime with parent `PYTHONHASHSEED=123`. All non-timing result fields and eighteen non-timing output artifacts matched. Input hashes, historical predecessor links, scenario cause references, and checkpoint/tail reconstruction were also checked. See `evidence/VALIDATION.md` and its supporting JSON files. This is a same-machine rerun, not independent implementation validation.

**Experiment coverage limitation:** The study implemented two time-advancement loops over shared fixture handlers, a separate checkpoint machine, and targeted arithmetic/algorithmic probes. It did not implement a complete Social Fabric Laboratory, a general hybrid kernel, adaptive ODE integration, distributed replay, a production event store, or a complete causal-query system. Shared-handler agreement cannot detect a domain bug common to both drivers; the explicit expected times and negative controls provide only limited independent checks.

### 8.3 External primary references

The expanded register `evidence/SOURCE_REGISTER.md` records inspection depth, locator, version/banner, evidence used, and limitations for each source. URLs are included as literal reference strings for portability.

**S01.** SimPy maintainers. *Time and Scheduling*, versioned 4.1.2 route.  
`https://simpy.readthedocs.io/en/4.1.2/topical_guides/time_and_scheduling.html`

**S02.** SimPy maintainers. *Overview*, moving documentation root, inspected banner 4.1.2.dev16+gf43816490.  
`https://simpy.readthedocs.io/`

**S03.** Mesa maintainers. *Overview of the MESA library*, stable route; activation and event-scheduling sections. A complete reliable release banner was not exposed.  
`https://mesa.readthedocs.io/stable/overview.html`

**S04.** Ptolemy Project, UC Berkeley. *SuperdenseTime*, Ptolemy II 11.0.1 documentation.  
`https://ptolemy.berkeley.edu/ptolemyII/ptII11.0/ptII11.0.1/doc/codeDoc/ptolemy/actor/util/SuperdenseTime.html`

**S05.** OMNeT++ maintainers. *SimTime Class Reference*, inspected API banner 6.2.0.  
`https://doc.omnetpp.org/omnetpp/api/classomnetpp_1_1SimTime.html`

**S06.** Cremona, F., Lohstroh, M., Broman, D., Lee, E. A., Masin, M., and Tripakis, S. *Hybrid co-simulation: it's about time*. Software and Systems Modeling 18, 1655–1679 (2019); online publication 2017. DOI 10.1007/s10270-017-0633-6.  
`https://link.springer.com/article/10.1007/s10270-017-0633-6`

**S07.** Modelica Association Project FMI. *Functional Mock-up Interface Specification*, version 3.0.2, 27 November 2024.  
`https://fmi-standard.org/docs/3.0.2/`

**S08.** Moreau, L., and Missier, P., eds. *PROV-DM: The PROV Data Model*. W3C Recommendation, 30 April 2013.  
`https://www.w3.org/TR/prov-dm/`

**S09.** W3C. *State Chart XML (SCXML): State Machine Notation for Control Abstraction*. Recommendation, 1 September 2015.  
`https://www.w3.org/TR/scxml/`

**S10.** Salmon, J. K., Moraes, M. A., Dror, R. O., and Shaw, D. E. *Parallel Random Numbers: As Easy as 1, 2, 3*. SC11 (2011), especially section 2.  
`https://www.thesalmons.org/john/random123/papers/random123sc11.pdf`

**S11.** NumPy maintainers. *Compatibility policy*, random-number documentation; inspected v2.5 Manual banner.  
`https://numpy.org/doc/stable/reference/random/compatibility.html`

**S12.** NumPy maintainers. *Parallel random number generation*; inspected v2.5 Manual banner.  
`https://numpy.org/doc/stable/reference/random/parallel.html`

**S13.** Python Software Foundation. *random — Generate pseudo-random numbers*, inspected documentation banner 3.14.7. Actual experiment runtime: 3.13.5.  
`https://docs.python.org/3/library/random.html`

**S14.** Microsoft Azure Architecture Center. *Event Sourcing pattern*, live documentation inspected 19 September 2026.  
`https://learn.microsoft.com/en-us/azure/architecture/patterns/event-sourcing`

**S15.** SciPy maintainers. *solve_ivp*, inspected SciPy v1.18.0 Manual banner, event-detection section.  
`https://docs.scipy.org/doc/scipy/reference/generated/scipy.integrate.solve_ivp.html`

**S16.** Anderson, D. F. *A modified Next Reaction Method for simulating chemical systems with time dependent propensities and delays*. arXiv:0708.0370 (2007). Abstract/landing-page review only.  
`https://arxiv.org/abs/0708.0370`

No source's popularity, product positioning, or deployment model was treated as evidence that the corresponding architecture is appropriate for the laboratory. Documentation banners above are retrieval observations, not a proposed software stack.

## 9. Unresolved questions and assumptions

### 9.1 Questions that remain for architectural reconciliation

**What does simultaneity mean in the social model?** Serial visibility, common-pre-state proposals, and joint resolution express different worlds. The temporal layer can implement several; it cannot determine the intended one without substantive rules.

**Which consequences are immediate, which require awareness, and which require action over time?** The examples assume certain immediate invalidations and short delays only to exercise the machinery.

**What is the required reproducibility level?** Same-run repetition and same-environment continuation are demonstrated narrowly. Invariance under model refactors, identical cross-platform trajectories, and cross-version preservation require further decisions and evidence.

**What historical questions must remain exact, and for how long?** Exact fact playback, the validity of old claims, household continuity explanations, counterfactual experimentation, and aggregate history impose different retention and computation requirements.

**Which parts of collective state are derived, and which are path-dependent?** This affects both checkpoint contents and provenance obligations. Task C does not settle household identity or recognition.

**What are the actual process laws?** Discrete interactions, accumulated exposure, continuous evolution, stochastic hazards, and periodic deliberation have different temporal needs. None is selected universally.

**How will cross-subsystem reads and writes be coordinated?** A shared time coordinate is compatible with multiple rhythms, but synchronization, valid-through information, boundary events, and strong feedback still need defined behavior.

**When may a past experiment be changed?** A correction to a display, a migration of an event format, re-execution under new rules, and a counterfactual branch should not be conflated.

### 9.2 Assumptions confined to the research experiments

The code uses one serial writer, a small finite fixture, explicit identifiers, integer-aligned social-example times, deterministic fixture arbitration, immediate awareness where not otherwise represented, and an arbitrary derived household-capacity observation. It uses synthetic scalar changes and durations solely to create testable temporal conditions. Its household reference is not an implemented persistent-identity mechanism.

The random-address test assumes stable semantic opportunity names supplied by the fixture. The continuation test assumes the same code and runtime. History timing assumes warm in-memory parsing. The analytical process has an exact linear solution. The multirate example counts callbacks and illustrates synchronized arithmetic; it does not validate arbitrary coupled dynamics.

### 9.3 Confidence and advisory conclusion

**High confidence within the demonstrated bounds:** execution and history choices are separable; deterministic serialization does not choose a valid conflict policy; a seed alone does not isolate decisions; qualifying-interval state matters for some delays; continuation can require more than world values; lossy summaries do not preserve arbitrary historical distinctions. These are supported by explicit counterexamples and primary sources.

**Moderate confidence as a project recommendation:** a small deterministic transition boundary, explicit resumable processes, and versioned explanatory records offer a useful way to preserve choices while starting laboratory validation. Its practical advantage depends on the actual social rules and explanation workload.

**Not established:** a preferred final driver, a final time quantum, a scalable production architecture, cross-platform bitwise reproducibility, historical realism, or a validated emergent-household mechanism.

**The useful decision is therefore not “events win” or “ticks win.” It is to make temporal meaning, unfinished processes, conflict resolution, and historical evidence explicit enough that choosing—or later replacing—the driver does not silently redefine the social world.**
