# TRES-0001A — Whole-System Architecture Discovery

**Research return · 19 September 2026**  
**Context:** INDEPENDENT-CONTEXT · **Authority:** advisory research only  
**Scope:** Task 1 / TRES-0001A and its five supplied context files. No contents from Tasks B–F were read.  
**Evidence:** primary technical documentation and research; four end-to-end candidate designs; disposable executable probes. No production architecture, language, engine, or household-recognition policy is selected.

## 1. Executive synthesis

### The architectural question is not “agents or graphs?”

The laboratory needs an account of how social facts become valid, change, acquire history, support collective continuity, and affect later action. A graph can represent connections; an agent runtime can execute choices; a database can retain records. None, by itself, establishes that account.

Four coherent organizing approaches survived this reconnaissance:

| Candidate | Organizing principle | Principal attraction here | Principal burden here |
|---|---|---|---|
| **C1. Event-authoritative social transition system** | Accepted, historically ordered transitions are authoritative; current and collective states are reconstructed from them. | Historical reconstruction is part of normal operation. | Events, replay semantics, multi-entity changes, and version compatibility become lasting commitments. |
| **C2. State-authoritative temporal transaction system** | A committed world-state version is authoritative; changes, explanations, and historical versions are committed atomically with it. | Direct state inspection and multi-fact consistency without requiring all queries to start from event replay. | History, causal records, and restart state must be impossible to bypass. |
| **C3. Provenance-bearing rule/graph-transition system** | Explicit rules transform a typed fact/graph state; derivations and rule applications carry evidence. | Makes admissibility, relation patterns, and explanation structurally visible. | Retraction, temporal continuity, conflict selection, and rule interactions can become a substantial language/runtime problem. |
| **C4. Multilevel influence–reaction simulation** | Individuals and emergent collective controllers propose influences; a reaction stage determines consistent consequences. | Treats upward emergence and downward influence as central simulation concerns. | Collective grounding, persistence, cross-level timing, and coherent checkpoints require deliberate additions. |

These are competing **whole-system designs**, not disjoint technologies. C4 can persist through C1 or C2; C3 can supply selected derivations within either. The distinction is what organizes the design and where its difficult responsibilities live.

### Advisory conclusion

**Compare C1 and C2 in the next executable vertical slice, using identical social semantics and an explicit transition/conflict boundary. Keep C3 and C4 as serious challengers and sources of organizing ideas.** A small single-process realization is a useful experimental baseline, not a permanent scaling decision. No evidence here justifies distributed infrastructure, nor does it establish a persistence winner.

The most consequential finding is that **a derived household need not be a stateless household**. Recognition, continuity, lineage, and coordinated action are different responsibilities. A historically supported collective may legitimately have persistent identity and control state; what must not happen is making its roster the primitive source of all lower-level relationships. Its actions must continue to identify their supporting facts and their effect on individual possibilities.

The second finding is that **history is necessary but not sufficient for causal inspection**. Recording a changed relationship can answer what happened. It does not automatically answer which facts made an action available, what an individual perceived, why one option was chosen, or what would happen under a different intervention.

### What the experiments establish—and do not

The attached standard-library probes passed **21 checks**, with identical logical results in **three separate processes on the same host/build**. Two persistence paths agreed at all **11 fixture-history prefixes**. The probes retained continuity through turnover and resource partition, recorded split/recombination lineage, distinguished relation types, and exposed incomplete checkpoint and counterfactual-replay errors.

This is **mechanism evidence, not social-model validation**. Both persistence paths deliberately share transition semantics. Relationships in the main history are injected fixtures. The recognition rule is an intentionally inadequate test double. No emergent behavioral theory, production event-store durability, cross-platform determinism, framework performance, or scaling result has been demonstrated. Sections 5 and 8 separate executed results from proposed designs.

## 2. Problem decomposition

### 2.1 What is binding, and what is inferred

The binding material is reproduced unchanged in `input_context/`. In particular, `01_ACCEPTED_FOUNDATION_CONTEXT.md` supplies the causal foundation; `02_PROTOTYPE_OBJECTIVE_AND_BOUNDARIES.md` supplies the laboratory proof situations; `03_SHARED_RESEARCH_PROTOCOL.md` and `04_TASK.md` define this return. File checksums and original archive-member paths are in `input_context/input_manifest.json`.

The following obligations are derived from those supplied requirements, rather than imposed by a favored implementation:

| Obligation | What an architecture must make possible | What remains open |
|---|---|---|
| **O1. Persistent referents** | A person, place, or resource remains addressable through relevant changes and after its active participation ends. | Identifier format, persistence representation, retirement policy. |
| **O2. Distinguishable social facts** | Residence, support, use, ownership, service, and other relationships do not collapse into a household-membership field. | Relation vocabulary, cardinalities, schemas, rule content. |
| **O3. Historical change** | Creation, alteration, transmission, contestation, fulfillment, and termination have inspectable histories. | Event authority versus temporal-state authority; temporal granularity. |
| **O4. Individual action** | Minimal interests/drives lead to proposals and interactions that can change the social fabric. | Motives, information limits, selection algorithm. |
| **O5. Collective emergence and continuity** | Collective organization arises from lower-level configurations and can persist through turnover. | Recognition criteria, persistence thresholds, lineage conventions. |
| **O6. Grounded collective influence** | Collective circumstances or coordination can change individual opportunities and choices without becoming unexplained primitive power. | How individuals perceive/respond; coordination mechanism and timing. |
| **O7. Controlled investigation** | Runs, interventions, restoration, and explanations can be compared on an explicit reproducibility basis. | Exact replay versus statistical replication targets; experiment interface. |
| **O8. Non-household future extension** | Later collectives need not inherit household-specific semantics. | Their types, authority, memberships, or substantive behavior. |

### 2.2 Identity is not association, and association is not authority

A useful architecture must be able to represent a resource independently of who uses, occupies, benefits from, or claims it. An obligation may involve a debtor, beneficiary, guarantor, object, and condition. Representing that as an identifiable relation/claim with typed participants is an architectural possibility; restricting every fact to an anonymous binary edge would be an unnecessary constraint.

Likewise, an asserted claim and an operative permission are not interchangeable. Two incompatible claims may need to coexist as contested social facts. A resource-conservation check may reject two actual allocations exceeding a physical stock without rejecting the existence of two disputing claims. The applicable resolution rules remain part of the model, not a database default.

A derived household participation view must not silently impose exclusivity. One person can be connected through different support, residence, work, and other structures simultaneously. The architecture should retain those distinctions even when a particular recognition experiment chooses a narrow definition of household organization.

### 2.3 A household has at least three distinguishable computational roles

**Observation:** identifying a currently supported configuration.  
**Historical identity:** deciding how observations relate across time—continuation, uncertainty, succession, dissolution, split, or recombination.  
**Causal operation:** coordination, commitments, opportunities, or constraints that subsequently affect action.

These are analytical distinctions, not a requirement for three software services. Combining them in one component may be entirely adequate. Failing to distinguish them conceptually is dangerous: a connectivity query can become an identity policy by accident, while a household object can begin generating ungrounded authority merely because it exists.

A general representation of the issue is:

`collective_state(t) = recognize(current_facts(t), prior_collective_state, relevant_history, policy_version)`

This is not a selected algorithm. It states that history-dependent recognition cannot necessarily be reconstructed from the current set of people alone. When a collective makes commitments or retains coordination memory, those influences must also be recoverable. “Derived” means explainable from the model’s causal history; it does not mean safe to discard at an arbitrary checkpoint.

### 2.4 Four different explanation questions

A useful inspector should distinguish these questions:

| Question | Required evidence |
|---|---|
| **What changed?** | Before/after fact versions, transition identity, effective point in the simulation. |
| **What supported this result?** | Input fact versions, applicable rule/model version, accepted interaction and dependencies. |
| **Why this choice rather than another?** | Available actions, perceived information, relevant drives or priorities, rejected alternatives where recorded, and randomness when material. |
| **What changes under an intervention?** | A branch from a defined state/history, altered input, and recomputation of subsequent endogenous choices. |

W3C PROV-DM supplies a vocabulary for entities, activities, derivation, usage, generation, invalidation, and responsibility. It is a useful reference for lineage records, not an automatic account of motives or counterfactual causation. Using its conceptual distinctions does not require adopting RDF or a particular storage system. [S05]

The proposed application is to connect stable world identities to versioned facts and transition activities. Decision explanations should report only evidence actually retained. A retrospective plausible story must not be presented as the actor’s recorded reason.

### 2.5 Time, order, and causality are different choices

A transition can have a simulation time, a deterministic commit order, and a dependency relation. These need not be represented by one timestamp. Distinguishing them prevents accidental claims that two same-time operations were socially simultaneous merely because they shared a clock value.

SimPy’s documented scheduling processes events sequentially and resolves equal-time events by insertion order. This demonstrates one concrete execution convention, not the appropriate social convention for this laboratory. [S10] Similarly, SQL serializability guarantees equivalence to some serial order, not the particular order needed for reproducible model behavior. [S13]

For comparison, a useful candidate execution contract is: perceive a defined world version; produce proposals; resolve conflicts; commit accepted consequences and explanations; update collective state; expose the result to later perceptions. A sequential action model or an explicit multi-phase model can both implement this. Whether collective feedback occurs in a later tick, the next event, or a defined subphase is unresolved. Uncontrolled circular reactions are not an acceptable substitute for a chosen convention.

### 2.6 “Save the world” needs a definition of the whole world

A resumable experiment can depend on more than public facts. Relevant state may include private individual memory, collective continuity/coordination memory, future events, pending proposals, random-generator state, identifier allocation, conflict-resolution order, committed history position, and versions of rules and inputs.

Four objectives should be tested separately: reconstructing recorded outcomes; rerunning the decisions that generated them; continuing an interrupted execution; and obtaining statistically comparable independent runs. A seed is not a checkpoint. NumPy documents stringent conditions on stream compatibility, while Python exposes generator state capture and restoration. [S15, S16]

The laboratory need not promise cross-machine bitwise identity immediately. It should state the guarantee it actually tests. Changes to rule versions or recognition policies may produce a new interpretation or a new experiment; they must not silently replace the explanation of an already recorded run.

## 3. Credible approaches discovered

### 3.1 C1 — Event-authoritative social transition system

**Published foothold.** Event sourcing treats a retained event history as the source from which state can be reconstructed. Microsoft’s pattern guidance also identifies schema evolution, projection, idempotency, and cross-entity conflict costs. Fowler’s original exposition highlights rebuilding and replay-related handling of external interactions. [S01, S02]

**Proposed whole-system realization.** Individuals, resources, places, and first-class social facts have stable identities. A choice produces a proposal, not an unrestricted mutation. A transition processor evaluates relevant facts and competing proposals, then accepts a semantic change with its affected identities, outcomes, supporting versions, and rule version. A logical run journal is authoritative. Indexed current-state and historical-query views serve simulation reads and inspection.

An accepted event should distinguish the modeled occurrence from its storage delta. For example, terminating a particular service obligation after fulfillment is not adequately explained by “row deleted.” The record needs the relevant obligation, fulfillment occurrence, and rule application. This does not imply recording every transient calculation or inventing a universal event vocabulary before the laboratory exists.

A household recognizer consumes the evolving facts and history. Its outputs retain supporting versions and continuity lineage. A collective controller, when the experiment calls for one, proposes grounded actions through the same transition boundary as individuals. An observed household does not acquire all its participants’ resources or automatically become the transaction owner for their relationships.

**Time and consistency.** The journal may order accepted reaction batches or individual accepted actions, depending on the chosen social execution semantics. For an initial local design, one coherent commit boundary avoids fragmented histories of a change involving several people and a shared resource. Independent per-household streams are a particularly poor initial partition because households can overlap in relationships, divide, and recombine.

**Inspection and recovery.** Queries use views indexed by person, claim, resource, event, and collective lineage. Reconstruction applies recorded outcomes without rerunning choice algorithms. Resimulation deliberately does rerun choices and checks whether their outputs agree. Restart uses a validated complete checkpoint plus the necessary suffix; the journal alone suffices only if it also contains everything required to reconstruct execution-control state, not merely visible social facts.

**Interventions and extensions.** A branch retains its parent position and changes a declared input. Endogenous outcomes after that point are newly computed. Future collective types can introduce different recognition and behavior policies over shared lower-level facts rather than subclassing household membership semantics.

**Main burden.** Historic transitions must remain interpretable after code and schema changes. New diagnostic views cannot recover information that old events never recorded. The design also needs one answer to the boundary between recorded fact outcomes, recorded agent/controller state, and reconstructible caches.

The candidate does **not** require a message broker, asynchronous projections, microservices, or a specialized event database. Those are implementation choices. The synchronous local variant proposed here deliberately does not inherit the eventual-consistency assumptions of common distributed examples.

### 3.2 C2 — State-authoritative temporal transaction system

**Published foothold.** Transactional databases provide a basis for atomic changes and defined isolation. Datomic demonstrates another relevant arrangement: immutable database values built from asserted/retracted facts, with temporal views. These are evidence for available mechanisms, not an assertion that Datomic and conventional mutable SQL have identical authority models. [S03, S04, S13]

**Proposed whole-system realization.** The authoritative world at a commit consists of current entity/fact state plus causally relevant individual and collective control state. One mandatory transaction path writes the new world version, old/new fact versions, semantic transition record, dependencies, and any changed execution state atomically. Direct updates bypassing that path are prohibited within the design.

Individuals read a specified committed snapshot and submit actions. The transaction processor handles shared constraints and writes the accepted result. Residence, claims, support, and other facts remain separate records with their own histories. A household tracker evaluates supported configurations and stores its continuity state at the same coherent boundary, or as a version-bound derivation whose completion is required before the next dependent action.

The architectural claim is not “ordinary CRUD is enough.” It is that **state plus inseparable temporal/causal recording can meet the research obligations without making domain-event replay the primary operational contract**. Temporal fact history is a real source of evidence, but it does not replace reasons for changes or decision evidence.

**Time and consistency.** Simulation order is supplied by the model’s scheduler/reaction policy. Database concurrency control protects consistency; it must not determine social priority by whichever transaction happens to win. If transactions are retried, random choices and externally visible effects need a defined relationship to the retry boundary.

**Inspection and recovery.** Current-state queries are direct. Historical queries read versioned facts at a specified commit or valid time. Explanations join those versions to transition and decision records. Checkpoints retain a coherent database/world version plus execution state outside that database, if any. Reopening a database is not enough when queues or agent memory remain only in process memory.

**Interventions and extensions.** A branch can use a copied logical checkpoint, a versioned state, or a branch-aware fact store. The mechanism is open; its requirement is that the parent run is unchanged and histories are distinguishable. New collective types introduce new grounded state and policies without changing old resources into household-owned objects.

**Main burden.** This approach is vulnerable to accidental incompleteness: a new write path, migration, or administrative edit may update current state without recording its reason or history. It also needs explicit reconstruction tests. If the stored versions and metadata cannot reconstruct a required historical state, the design is deficient even when current queries are convenient.

A history-complete C2 implementation may look very similar on disk to C1. The meaningful difference is the recovery/evolution contract and operational authority, not whether a table happens to be called `events`.

### 3.3 C3 — Provenance-bearing rule/typed-graph-transition system

**Published foothold.** GROOVE models changes using graph-transformation rules and explores resulting labeled transition systems. Soufflé documents proof-tree explanations of derived tuples and guided explanations of failed derivations. Its rules require stratifiable negation rather than unrestricted cyclic negation. [S06–S08]

**Proposed whole-system realization.** The world is an explicit typed set of entities, relationships, claims, and state facts. Social occurrences are rule-governed transformations with matched inputs, guards, and outcomes. Individual drives generate alternative proposals or enabled choices; a separate policy chooses or resolves them. Pure recognition rules derive supported configurations. Temporal identity rules or a history-aware tracking relation connect successive configurations.

This becomes an end-to-end architecture only when it includes an agenda/scheduler, interaction selection, persistent transition trace, checkpoint semantics, and an inspection interface. A Datalog query calculating connected components is not that architecture. Nor should a deductive conclusion silently mutate resources merely because a rule matched.

A useful distinction is between **deduction within a world version** and **transition to a new world version**. Deduction can establish a candidate opportunity or support certificate. A transition can accept an action, consume a resource, terminate an obligation, or update memory. The boundary prevents an inference engine from repeatedly performing the same social action while computing closure.

**Collective continuity and influence.** Recognition predicates can be tied to explicit fact versions. Historical identity requires time-indexed facts, lineage, or equivalent retained state; simple current-pattern matching cannot settle continuity. A collective’s supported state may enable proposals in a later phase. Its influence must resolve into identifiable consequences and evidence, not remain a circular rule that “the household exists because it acts, and acts because it exists.”

**Inspection and recovery.** Rule applications retain their identifiers, bindings, premises, and outcomes. An inspector can trace a conclusion into a proof or an accepted transition. A shortest proof is not necessarily all relevant support, and a failed derivation is not automatically a complete explanation of why an individual declined an action. Checkpoints include the base facts, history-sensitive state, rule versions, clock/agenda, and any pending bindings whose preservation matters.

**Interventions and extensions.** Branches alter declared facts or rule parameters and continue transitions. Additional collective types can have different predicates and rules while sharing entity identities and provenance conventions.

**Main burden.** Removing a sustaining relation is nonmonotone at the social-observation level: conclusions may cease to hold, and their past truth must still remain inspectable. Recursive rules, negation, agenda priorities, large joins, and state-space growth can make the architecture difficult to reason about. The source tools establish relevant capabilities; this research did not build a combined GROOVE/Soufflé runtime or demonstrate that such a combination is necessary.

### 3.4 C4 — Multilevel influence–reaction simulation

**Published foothold.** IRM4MLS explicitly distinguishes perceptions and influences across levels. Agents propose influences rather than directly determining the next global state; reaction computes consequences. Its framework allows participation in multiple levels and explicitly treats cross-level temporal organization. [S09]

**Proposed whole-system realization.** Persistent individuals operate within a shared environment containing material entities and first-class social facts. Their interactions accumulate durable configurations. A history-aware observation/reification mechanism can recognize a collective and activate a controller representing supported coordination. Individuals and controllers issue influences; a reaction mechanism resolves the joint result and records it.

The controller is not a replacement for its grounding. A proposed household action identifies the participating relationships, commitments, resources, and relevant perceived circumstances. The environment retains authoritative shared facts instead of burying every relationship in a private person object or treating resources as children of a household object.

**Time and consistency.** Perception/influence connections specify which level may observe or affect which state. A coordinator defines when a reaction is complete and when the next perceptions become available. A single-process version can use explicit phases; different level clocks should be introduced only for a demonstrated modeling purpose. A multi-level model does not imply one operating-system thread or remote actor per simulated entity.

**History, inspection, and recovery.** Each completed reaction records proposals, applicable conflict decisions, fact changes, and evidence links. C1 or C2 can implement its persistence. Checkpoints must cover all relevant levels, controller memory, pending influences, and future reactions at one coherent frontier. Restoring every agent object independently does not demonstrate that their restored combination ever formed a valid world state.

**Interventions and extensions.** Scenario inputs enter through the same explicit temporal/reaction rules as ordinary modeled occurrences, with their exogenous origin marked. New collective forms can have distinct perception, coordination, and influence policies rather than being forced into a household inheritance hierarchy.

**Main burden.** The modeler must say what permits a collective controller to act, how its powers disappear or change when support ends, and how overlapping commitments avoid double use of resources. IRM4MLS is an organizing model, not a ready-made solution for the project’s recognition or historical semantics.

An actor implementation is optional. Pekko’s documented default delivery and ordering guarantees are local to defined messaging relationships, not a universal global experiment order. Thus a messaging runtime cannot substitute for this candidate’s reaction/checkpoint semantics. [S12]

### 3.5 Other discovered approaches and their role

**Agent-based frameworks** remain useful implementations of individual activation, spaces, and data collection. Mesa exposes multiple activation and execution facilities. Its availability does not determine the laboratory’s causal ontology or household semantics. [S11]

**Discrete-event/process simulation** can provide the clock, pending-event queue, and lifecycle of interactions in any candidate. It was not retained as a separate complete architecture because those facilities alone do not decide social-fact authority, historical collective identity, or explanation. [S10]

**Entity-component-system/data-oriented designs** can organize fast state access. Flecs, for example, represents relationships using pairs attached to entities. That is an implementation foothold, not a history policy; two distinct claims with the same participants may still require separately identifiable records. [S18]

**Coloured Petri nets** offer a credible alternative emphasis on executable interaction/resource protocols and state-space validation. The cited book’s overview and contents cover simulation, timed nets, and state-space analysis. It was surveyed as a possible validation formalism, not dismissed as incapable of a whole social model. A separate end-to-end design with durable social identity and historical explanation was not developed in this return. [S19]

A graph database, a provenance vocabulary, and a message broker are similarly useful possible components, not standalone answers to Task 1. No conclusion about their suitability should be inferred from their popularity or from their presence in this list.

## 4. Comparison

### 4.1 Qualitative comparison against the actual obligations

The entries below are design analysis, not measured framework rankings.

| Dimension | C1: event authority | C2: temporal-state authority | C3: rules/graph transitions | C4: multilevel influence–reaction |
|---|---|---|---|---|
| **Authoritative boundary** | Accepted journal frontier and all state reconstructible from it. | Coherent world-state commit plus inseparable history and causal records. | Base state and accepted rule-transition/agenda state; derived closure clearly distinguished. | Completed reaction across the relevant levels; persisted using an explicit policy. |
| **Individual interaction** | Proposals validated into accepted events. | Proposals validated into atomic state changes. | Enabled alternatives plus explicit choice/conflict policy. | Influences combined by reaction rather than unrestricted actor mutation. |
| **Relationships and claims** | Stable fact identities changed by semantic events. | Stable fact identities with versions and transition links. | Typed relation/claim objects with rule-visible participants. | Shared environment facts, not only private agent fields. |
| **Household continuity** | History-aware projection/controller state. | Versioned tracker/controller state with historical support. | Temporal identity/lineage facts beyond instantaneous matching. | Supported reification and controller succession beyond current agents. |
| **Downward influence** | Collective proposals pass through the same acceptance boundary. | Collective circumstances appear in reads/guards and committed reasons. | Supported predicates enable explicit action transitions. | First-class cross-level perception and influence. |
| **Present-state inspection** | Requires maintained indexes/views. | Direct queries; temporal/causal joins added. | Natural for facts and rule proofs; choice trace still separate. | Natural for agent/level state; cross-agent provenance requires additional records. |
| **Historical reconstruction** | Primary operating contract. | Must be explicitly preserved and tested. | Depends on retained transitions, versions, and rule semantics. | Depends on persistence and coherent cross-level frontier. |
| **Initial complexity** | Modest local kernel possible; long-lived event compatibility is consequential. | Modest transactional kernel possible; completeness discipline is consequential. | Potentially compact rules; custom language/agenda complexity can expand rapidly. | Clear feedback semantics; controller grounding and level synchronization add work. |
| **Structural scaling pressure** | Journal growth, replay length, projection updates, cross-entity commits. | History growth, temporal joins, write contention, branch storage. | Pattern matching, derivation maintenance, retractions, reachable-state explosion. | Message/proposal volume, cross-level synchronization, shared-resource conflicts. |
| **Principal migration risk** | Old events omit needed semantics or depend on old reducers. | Unrecorded edits/history gaps cannot be repaired retrospectively. | Important behavior becomes tied to engine-specific rule and agenda semantics. | Behavior depends on delivery order or household-specific controller hierarchy. |

### 4.2 What is realistically reversible

Storage technology is not always the hardest decision to reverse. A well-identified fact history can potentially move between a journal and temporal tables. Conversely, a missing distinction between residence and ownership cannot be recovered simply by migrating databases.

Relatively reversible choices include read indexes, serialization format with supported conversions, batching, ordinary cache layouts, and initially using one process. Reversibility still requires adapters and tests; it is not free.

Potentially expensive commitments include event vocabulary, meaning of fact identifiers, which relationships are first-class, household continuity/lineage semantics, conflict resolution, and whether individuals perceive the same world state. A change in those meanings may be a new model rather than a software refactor.

**C1 ↔ C2 migration** is plausible when accepted transitions have precise outcomes, stable identifiers, before/after or equivalent historical information, and execution-state provenance. It becomes difficult when C1 stores underspecified commands that require obsolete code or C2 stores only current values. Keeping both representations forever is not automatically desirable: two independently mutable sources of truth create another failure mode.

**C3 ↔ procedural realization** is easier when rules have explicit inputs, outputs, versions, and conformance histories. It is harder when behavior depends on undocumented firing order or side effects during deduction.

**C4 ↔ simpler execution** is easier when proposal/reaction semantics are independent of transport and level controllers expose their support. It is harder when the runtime’s arrival order becomes the social model or when each household owns the truth of its participants’ relationships.

### 4.3 Scaling without premature optimization

The packet supplies no binding population target. Therefore this report does not claim a winning throughput or maximum population.

For all candidates, relationship density and change propagation can matter more than person count. A small number of highly connected actors can create large recognition and conflict scopes. Overlapping collectives can make a household-based partition unstable. Maintaining history-dependent derivations may cost more than updating a current adjacency index.

The disposable code fully copies facts and recomputes recognition frequently. That is useful for transparent correctness checks and unsuitable evidence for production performance. A later benchmark should separately measure transition validation, history writes, recognition maintenance, explanation queries, branch creation, restart, and memory/storage growth. Otherwise a faster datastore can appear to solve a bottleneck actually caused by recognition semantics.

### 4.4 Why no forced winner

The central uncertainty is not whether either C1 or C2 can store an adequate history; the probes show both can in a tiny controlled case. It is which contract makes a growing, changeable social model easier to implement **without losing causally relevant information or creating excessive infrastructure**.

C3 deserves promotion if explicit rule/proof handling makes the laboratory substantially easier to explain and change. C4 deserves promotion if grounded coordination across levels proves awkward or misleading under a simpler proposal/transition design. These are discriminating empirical questions, not reasons to average four architectures into an oversized framework.

## 5. Worked social-fabric examples

### 5.1 Common complete history used for every serious candidate

This is a synthetic architectural fixture, not a historical reconstruction. People are labeled `a`, `b`, `c`, `d`, `e`, and `x`. The fixture’s numeric use shares are arbitrary allocation units, not a theory of ownership or inheritance.

| Stage / recorded event | Lower-level occurrence | Collective observation in the disposable fixture |
|---|---|---|
| **0 / e00: separate individuals** | `a,b,c,d,x` exist. The plot and dwelling have independent IDs. `d` owns the dwelling; `b` resides there. `a` supports nonresident `x`. `a` holds a plot-use allocation of 12. | No household label. Residence, support, ownership, and use are separate facts. |
| **1 / e01: relational accumulation** | Cooperation relations `a–b`, `b–c`, and `c–d` are established. | A candidate configuration appears, not yet an active collective. |
| **2 / e02: persistence** | A further observation occurs without a new substantive relationship. | Fixture observer recognizes `H001` over `a,b,c,d`. |
| **3 / e03: resource partition** | The plot-use allocation changes to 7 for `a` and 5 for `c`. The plot and social relations remain. | `H001` continues. Allocation division does not itself mean social fission. |
| **4 / e04: sustaining relationship change** | `a–c` cooperation is established before `b` dies. | `H001` continues on changed support. |
| **5 / e05: death/turnover** | `b` becomes deceased; selected cooperation relations end. The person and past facts are not erased. | `H001` continues through the surviving `a–c–d` configuration. |
| **6 / e06: arrival** | `e` arrives and cooperates with `d`. | `H001` continues over `a,c,d,e`. A test choice by `d` can now use its supported collective opportunity. |
| **7 / e07: sustaining break** | `c–d` cooperation ends. Neither the plot nor all interpersonal relations disappear. | The prior collective is archived; two configurations become pending. |
| **8 / e08: distinct persistence** | A further observation occurs. | `H002` and `H003` are recognized, each with `H001` as predecessor. |
| **9 / e09: renewed cooperation** | `c–d` cooperation resumes. | A recombined configuration is pending; predecessor identities remain in history. |
| **10 / e10: recombination** | A further observation occurs. | `H004` is recognized with predecessors `H002,H003`; `H001` is not silently resurrected. |

The **two-observation delay, cooperation-only connectivity, overlap matching, and new-ID-on-split/merge convention are test doubles only**. They intentionally leave out nearly everything that would make household recognition socially adequate. In particular, disjoint connected components do not validate support for overlapping household organizations. Observation count is not a chosen duration model. The grouping/lineage outcomes above are facts about this fixture, not accepted project behavior.

### 5.2 Complete history through C1

At stage 0, initialization records create stable people, resources, and distinguishable claims/relations. State views expose `b` as a resident without inventing ownership. At stages 1–2, accepted cooperation occurrences become recorded facts; the history-sensitive observer first records support and later a collective identity. No initial household record supplies the cooperation.

At stage 3, one coherent accepted allocation change produces the new claim versions and links to the previous allocation. The plot identity and sustaining cooperation are unchanged, so the fixture observer retains `H001`. At stages 4–6, new cooperation, death, termination, and arrival occurrences accumulate. Replay preserves `b` as a historically addressable person and reproduces continuity using the retained policy and support history.

When `d` considers joint work, its proposal references the supported collective opportunity at a particular frontier. A subsequent accepted action would record its decision evidence and consequences rather than treating `H001` as an unrestricted resource owner.

At stages 7–8, ending the bridging relation invalidates the current support configuration. The observer records lineage and cessation of the previous active identity; subsequent persistence supports successors. At stages 9–10, renewed cooperation supports a new observed configuration and lineage. There is no lower-level `split_household` or `merge_household` command. A trace query for `H004` follows its recognition, the renewed relation, successor identities, the earlier break, and the original supporting history.

**Recovery:** replay the accepted history under its recorded interpretation, or use a compatible complete checkpoint and suffix. A newer recognition policy can be evaluated as another versioned interpretation, but it must not masquerade as the policy that caused past decisions.

**Executed coverage:** the event-authoritative probe replays all 11 prefixes; it is an in-memory semantic log subsequently exported to JSONL, not a crash-tested durable journal.

### 5.3 Complete history through C2

Stage 0 commits people, place/resource rows, and separate fact rows. At stages 1–2, transactions insert cooperation facts and their versions, semantic transition records, and observation/tracker changes. An otherwise unchanged observation can still change history-sensitive tracker state. Current-state authority therefore includes more than rows for visible relations.

Stage 3 atomically changes the use allocations and retains their previous versions and cause links. A current query sees 7 and 5; a historical query at the earlier frontier sees 12. A household query continues to identify `H001` under the fixture policy because resource partition is not a household-membership update.

Stages 4–6 update sustaining relations, mark `b` deceased, terminate selected relations, and add `e`. The transaction preserves old facts while updating current ones. The tracker and relevant controller state belong to the same coherent commit. A decision query can read the supported joint-work opportunity at that commit and retain the input versions used.

Stages 7–8 close the bridging relation and update active/pending/archived collective state without deleting historical identity. Stages 9–10 create a renewed relation version and successor observations. Present queries and as-of queries therefore answer different, explicitly versioned questions. Explanation joins connect `H004`’s support and lineage to the relevant transaction records rather than guessing from the current roster.

**Recovery:** reopen a coherent persisted world/control state and restore any execution state outside it. Historical reconstruction uses retained versions and transition records; it is a required test, not an assumption about all relational databases.

**Executed coverage:** the SQLite probe agrees with C1’s current facts and tracker after all 11 commits, reconstructs historical facts at every prefix, reopens its final state, and rolls back an injected exception between state and history writes. Historical tracker queries at every prefix are not separately implemented in SQL; current tracker parity is checked during execution.

### 5.4 Complete history through C3

At stage 0, the typed graph/fact state contains separate people, plot, dwelling, and relation/claim instances. At stage 1, an interaction rule matches the participating people and explicit conditions, producing cooperation facts and a record of the accepted rule application. The choice of which enabled interaction occurs must be governed by a declared selection policy; an arbitrary rule agenda is not an explanation of personal motivation.

At stage 2, a temporally defined recognition process derives a supported collective observation and links it to an identity record. At stage 3, an allocation rule changes use-claim instances, not the underlying plot or household membership. Because the sustaining social premises remain, the continuity rule retains the current identity in this fixture.

Stages 4–6 apply relationship, death, and arrival transitions. Rules refer to historical person identity while current participation predicates change. Terminating a relation retracts its current validity without erasing earlier rule applications. The surviving configuration supplies an updated proof/support certificate. A collective opportunity can then enable an individual action rule, but resource effects occur only in an accepted transition.

Stages 7–8 withdraw the bridging premise. Recognition conclusions depending on that premise must be recomputed or maintained with correct retraction handling. Temporal identity rules record predecessors rather than treating new pattern matches as timeless truths. Stages 9–10 add a renewed relation and derive recombination with explicit lineage. The inspector can trace the accepted rule bindings and fact versions at every stage.

**Recovery:** persist a defined transition frontier, base facts, temporal identity state, rule versions, and required agenda/random state; recompute only genuinely derivable closure. Merely saving the current graph is inadequate if an unfinished rule agenda or continuity history affects the next result.

**Evidence status:** this is a designed trace grounded in published capabilities, not an executed rule-engine implementation. Probe X8 exercises withdrawal and versioned support in ordinary code; it does not establish incremental Datalog or graph-rewriting correctness.

### 5.5 Complete history through C4

Stage 0 has individual agents and shared environment facts, but no primordial household controller. During stage 1, compatible interaction proposals become accepted influences at a reaction boundary; cooperation facts appear in the environment. At stage 2, durable support can justify reifying a collective identity/controller. Its activation records the evidence that makes it a supported collective rather than a container into which people are placed.

At stage 3, allocation-related influences are resolved against the same resource while the social configuration continues. The controller does not split merely because two people now hold different use allocations. At stages 4–6, a new sustaining relationship precedes death, selected relations cease, and an arrival adds support. The controller’s grounding and participant views update; `b` remains in history, not in current action execution.

Collective feedback is explicit: a supported coordination opportunity affects what `d` perceives or can propose. The ensuing reaction resolves individual and collective influences without consuming the same resource twice. A controller can lose an action’s support even if its historical identity remains relevant.

At stages 7–8, the break in sustaining cooperation forces reassessment of the controller’s scope and powers. Two persistent successor configurations may acquire separate controllers with lineage. At stages 9–10, renewed lower-level cooperation can support recombination; reaction/recognition machinery does not execute a scripted merger of household containers.

**Recovery:** a checkpoint represents a completed reaction or a fully captured in-progress reaction. Saving different agents at unrelated message frontiers would not establish a coherent social history. Persistence still needs the C1/C2-style records or another equally explicit mechanism.

**Evidence status:** a reasoned complete trace, not a tested multilevel runtime. The conflict probe is a minimal proposal/resolution demonstration, not a parallel agent or actor-system benchmark.

### 5.6 Awkward case A — a resident, an external dependent, and resource division

**Situation.** `b` resides in `d`’s dwelling, while `a` supports `x` elsewhere. Cooperation involving `a,b,c,d` sustains an observed household. The plot-use allocation is divided between `a` and `c`.

**C1 trace.** Read the specific dwelling-ownership fact, the residence fact, the external-support fact, and the prior plot-use claim. Accept the allocation change with the previous claim as a dependency. Produce two current allocation facts while keeping the same resource ID. The recognizer evaluates its declared social premises; it must not infer that ownership followed residence, that `x` relocated, or that every resource beneficiary became an exclusive household member. An inspector answers each association from its own occurrence and fact version.

**C2 trace.** The same operation is one transaction affecting the use-claim rows and associated versions/history. Residence, support, and dwelling ownership remain separate unchanged rows. The household view is evaluated at the new commit using its own support evidence, rather than using claim holders as a replacement membership roster. An as-of query proves what changed and what did not.

**Discriminating checks.** Query residence without ownership; query support without co-residence; compare resource identity and household continuity before/after division. X2 executes a narrow version of these checks. It does not prove an adequate classifier for all overlapping social structures. An explicit overlapping-collective case remains necessary in the next validation.

### 5.7 Awkward case B — death, surviving obligations, and contested transmission

**Situation.** Extend the fixture with a continuing support obligation, a surviving beneficiary, and two assertions about who should assume performance after a death. The facts of an obligation’s existence, its fulfillment, and its alleged transmission must remain distinguishable. No substantive inheritance rule is assumed here.

**C1 trace.** Record the death without erasing the person’s history. Record each transmission assertion as an identifiable claim tied to the original obligation and asserting actor. Do not silently choose a successor because one person happens to share an observed household. A later accepted fulfillment or resolution records the rule/input used and its effects. Household continuity is separately assessed from surviving support, coordination, resources, and history. It may continue even while one obligation is contested.

**C2 trace.** Keep the person and obligation IDs; version their current statuses. Insert the two claims and their provenance rather than overwriting one with the other. Atomically commit an accepted resolution and any operative reassignment when the model supplies a resolution mechanism. An inspector can retrieve both the current operative relation and the competing past assertions. Current constraints may prevent impossible resource expenditure without prohibiting disputed social claims from existing.

**Discriminating checks.** Ask who asserted each transmission, what evidence an acting person perceived, why an obligation currently applies, and whether continuity survived independently. Destroying one asserted claim by overwriting another, or assigning all obligations to a household by default, falsifies the design’s fit.

**Evidence status.** This is a worked design case, not part of the executable obligation model. The code tests death/history retention and cooperation continuity, not contested inheritance, obligation fulfillment, or normative resolution.

### 5.8 Awkward case C — collective feedback and a counterfactual branch

**Situation.** At stage 6, a toy opportunity rule lets `d` propose joint work when a recognized supporting configuration has at least three people. Removing the bridging relation changes the available opportunity.

**C1 trace.** Restore the parent frontier; inject the relation withdrawal; derive the new collective state; rerun the opportunity decision. Retain both branches. Do not append the old branch’s already chosen joint-work outcome as though it were a fresh choice. Replay of an old outcome and recomputation under changed conditions answer different questions.

**C2 trace.** Create an independent logical branch from the same committed state and tracker state. Commit the withdrawal with its cause. Evaluate the decision against the branch’s new supported opportunities and write new decision evidence. The parent’s transition and choice records remain unchanged. The design needs a branch mechanism; ordinary update-in-place would destroy the comparator.

**Executed result.** X7’s decision changes from `offer_joint_work` to `retain_effort`. Its deliberately forced old-outcome replay still says `offer_joint_work`, demonstrating why outcome replay is not a counterfactual engine. This probe runs on the event-kernel branch; C2’s corresponding trace is a design description, not a separately executed branching implementation. The opportunity rule is an artificial guard, not validated collective behavior.

## 6. Failure modes / falsification conditions

### 6.1 Cross-cutting failure tests

| Failure mode | Concrete falsifier | Consequence for the recommendation |
|---|---|---|
| **Household becomes the primitive container** | Removing a household association automatically destroys distinct residence, support, or claim facts. | Reject that realization regardless of datastore or runtime. |
| **Connectivity substitutes for the social theory** | One external support relation necessarily merges otherwise distinguishable organizations. | Replace the recognition policy; reject an architecture that cannot represent alternatives or overlap. |
| **Stateless collective identity** | Identical current people/relations force identical collective history after distinct trajectories. | Add explicit historical identity support; reject disposable-query-only continuity. |
| **Ghost collective power** | A controller keeps allocating resources after the supporting facts have ended, without an explicit surviving commitment. | Add evidence validity and action guards; question whether reification is adequately grounded. |
| **Only state deltas, no social reasons** | The inspector can show that a claim changed but cannot identify the modeled occurrence or applicable rule. | Redesign transition/decision records before expanding the model. |
| **Circular feedback** | One recognition/action update produces unbounded same-time self-reinforcement without a modeled stopping rule. | Change scheduling or causal phases; do not hide it in queue limits. |
| **History silently rewritten** | A new policy retroactively changes the explanation attached to an old action without a new interpretation/run version. | Introduce explicit versioned interpretation and resimulation semantics. |
| **Order-dependent resource violation** | Two accepted actions consume one remaining physical unit, or changing container iteration changes outcomes without declared model randomness. | Add explicit conflict semantics; storage atomicity alone is not the answer. |
| **Incomplete restart** | Visible facts match after load, but future queues, continuity, random state, or private memory produce an unexplained divergence. | Expand checkpoint closure and test continuation, not just serialization. |
| **Unfounded counterfactual** | A branch reuses endogenous outcomes produced under its parent’s now-changed conditions. | Recompute decisions and distinguish replay from intervention. |

### 6.2 Candidate-specific reasons to change course

**C1 would lose its current candidacy** if useful prototype changes repeatedly demand reinterpretation of old event meanings, if complete restart depends on unrecorded side state, or if meaningful inspection requires an increasingly elaborate projection infrastructure before any social hypothesis can be tested. A failed atomic multi-entity acceptance/recovery test would also be decisive. It remains viable if these responsibilities stay explicit and proportionate.

**C2 would lose its current candidacy** if audit/history omissions recur as features are added, if historical explanations cannot be reconstructed from retained versions, or if branches and recovery require fragile manual synchronization of database and runtime state. It remains viable if one enforced transaction boundary and conformance tests make completeness routine.

**C3 would become more attractive** if a small rule formulation provides clearer, correct explanations and easier relation-policy changes than procedural alternatives. It would become less attractive if retraction and historical continuity require extensive opaque procedural sidecars, or if rule-order dependencies dominate behavior. Bounded model checking can help expose counterexamples but cannot by itself validate the unbounded social model.

**C4 would become more attractive** if a clear influence–reaction model materially improves grounded coordination and prevents update-order artifacts. It would become less attractive if most early complexity is spent on level synchronization, controller bookkeeping, or message delivery rather than the laboratory’s proof situations. Failure to explain a controller’s continuing powers after fission is a particularly relevant falsifier.

### 6.3 Interpretation limits of the present probes

Passing checks is meaningful only relative to what they actually exercise. The two storage paths share their fact reducer and recognition function, so they can agree on the same mistake. The fixture observer uses disjoint cooperation components and a crude continuity rule; it is intentionally not fit as the project’s household recognizer. The same-facts/different-history result is a counterexample under that path-dependent policy, not proof of a uniquely correct social identity theory.

The conflict probe is sequential enumeration of a tiny case, not concurrent stress testing. SQLite rollback is tested with a handled exception, not process death or power loss. Source documentation on durable transactions should not be conflated with a measured durability result in this environment. [S14]

Most importantly, the main history injects cooperation formation and withdrawal. It demonstrates representation, lineage handling, and recovery mechanics **without household split/merge commands**, not endogenous household formation from a validated individual decision process.

## 7. Recommended next validation

### V1 — One endogenous vertical slice, two authority contracts

Build one small scenario in which minimal explicit individual interests generate offers, acceptance/refusal, and sustained cooperation; do not inject household formation. Retain the same scenarios, decision rules, fact semantics, and inspector questions in C1 and C2. Keep the persistence adapter boundary narrow enough that it does not become a generic framework project.

The discriminator is engineering and explanatory completeness: how much special machinery is required to add a new relation, record its history, explain decisions, restore a run, and branch an intervention? Record missing evidence and implementation-specific exceptions, not just final household counts. The slice should also expose where C3-style rule proofs or C4-style reaction phases simplify the design.

### V2 — Recovery that includes execution, not only storage

Interrupt runs before and after accepted transitions, during checkpoint creation, and while future events are pending. Test actual process termination separately from handled exceptions. Compare uninterrupted and resumed histories at every subsequent accepted frontier, including private memories, tracker/controller state, queue contents, identifier allocation, and random-state manifests.

For C1, test durable append acknowledgment, partial-record handling, snapshot consistency, and suffix recovery. For C2, test transaction/history completeness and synchronization with any non-database execution state. An accepted transition must be present once or absent coherently; it must not survive only in a current-state cache. Add duplicated-delivery and changed-content/same-ID cases.

### V3 — Recognition and controller substitution without data-model surgery

Use at least two deliberately different recognition/continuity policies against the same lower-level history. Include total participant turnover over time, replacement of particular assets and places, simultaneous overlapping social structures, transient breaks, division of assets without division of relations, persistent division, and later recombination. Include a case where an old commitment survives a change of active organization.

The architecture passes if it preserves the underlying facts and supports versioned alternative observations while keeping past decision explanations faithful to the policy actually used. It fails if changing a recognizer requires rewriting all person memberships or erasing lineage. No policy should be accepted merely because it reproduces the fixture’s labels.

### V4 — A small, auditable explanation challenge

For each candidate implementation, ask the same questions: Why does this claim apply now? Why is this collective treated as a continuation? Why was this action available? Why did the actor choose it? Why did a competing proposal fail? What changes when one supporting relation is withdrawn?

Answers must point to actual retained fact versions, transitions, perceived information, and rule identifiers. Mark “not recorded” where evidence is absent. Add a counterfactual run rather than deriving an intervention answer from a historical explanation graph alone. Compare explanation construction effort and missing evidence before comparing UI quality.

### V5 — Focused rule and multilevel challengers

Implement one small C3 transition/derivation fragment with termination and retraction, and one C4 coordination/conflict fragment with more than one influence affecting the same resource. Preserve the same input/output histories and inspector questions used by the main slice.

Promote a challenger only if it solves a demonstrated difficulty more clearly. Do not build four general engines. A rule engine might become a targeted proof-producing recognizer, and influence–reaction might become the shared execution convention rather than a competing full stack.

### V6 — Measure scaling after semantic conformance

Use a declared sweep of population, relationship density, active-change fraction, and history length. No particular numbers are binding here; choose ranges that fit the first laboratory and extend them until a bottleneck is observable. Keep invariant tests active during measurement.

Report transition throughput, explanation/query latency distributions, recognition update cost, restart/branch time, memory use, and stored bytes per fact/change. Separate cold replay from warm current-state reads. Test shared-resource hot spots and overlapping relation structures, not only isolated households. Record software versions, machine characteristics, and randomness configuration. Such results, unlike the present smoke tests, could discriminate storage and execution choices.

These validations are proposals for the Master Architect to prioritize. They are not new accepted tasks or specifications. The present research return is complete without promoting any of them into project authority.

## 8. Sources / experiments

### 8.1 Research provenance and source discipline

Source identifiers below are resolved in `evidence/SOURCE_LEDGER.md`, including exact URLs, document/version assumptions, inspected sections, and limits. All web sources were accessed on **19 September 2026**. The research used primary technical documentation, original research, and a book publisher’s overview; it did not rely on a product-comparison ranking or on another task’s conclusions.

Discovery covered event/history architectures, temporal fact stores, rule and graph transformations, multilevel agent simulation, discrete-event scheduling, actor execution, data-oriented relationship storage, provenance, reproducibility, and formal interaction models. Sources establish mechanisms; the four end-to-end applications and comparisons are this report’s advisory synthesis. This was a targeted reconnaissance, not an exhaustive systematic literature review.

| ID | Source / version or date | Specific use |
|---|---|---|
| **S01** | Microsoft, *Event Sourcing pattern*, updated 28 March 2026. | Authority, projections, evolution and conflict considerations. |
| **S02** | Martin Fowler, *Event Sourcing*, 12 December 2005, draft exposition. | Reconstruction and replay/external-interaction distinction. |
| **S03** | Datomic, *Transaction Model*, live documentation. | Immutable database values, assertions/retractions, transaction records. |
| **S04** | Datomic, *Database Filters*, live documentation. | History and as-of views. |
| **S05** | W3C, *PROV-DM*, Recommendation, 30 April 2013. | Provenance vocabulary and versioned fact lineage. |
| **S06** | University of Twente, *GROOVE home page*, live documentation. | Graph-rule transitions and state-space exploration. |
| **S07** | Soufflé, *Provenance*, live documentation. | Proof trees and guided why-not inspection. |
| **S08** | Soufflé, *Rules*, live documentation. | Negation and rule constraints. |
| **S09** | Morvan, Veremme & Dupont, *IRM4MLS*, LNCS 6532 (2011); consulted arXiv:1310.7951v1 (2013). | Explicit influence/reaction and multilevel organization. |
| **S10** | SimPy 4.1.1, *Time and Scheduling*. | Sequential event scheduling and equal-time order. |
| **S11** | Mesa, *Overview*, live stable documentation. | ABM activation and execution facilities; no installed-version claim. |
| **S12** | Apache Pekko, *Message Delivery Reliability*, displayed documentation 1.7.0. | Delivery/ordering scope; not a global causal order. |
| **S13** | PostgreSQL 18, §13.2 *Transaction Isolation*. | Serializable consistency and its distinction from selected model order. |
| **S14** | SQLite, *Atomic Commit*, official documentation. | Transaction/recovery mechanism and assumptions. |
| **S15** | NumPy, *Compatibility policy*, displayed manual 2.5. | Conditions on random-stream compatibility. |
| **S16** | Python 3.13, *random* documentation. | Generator state capture/restoration; runtime version recorded separately. |
| **S17** | Grimm et al., *ODD Protocol: A Second Update*, JASSS 23(2), 2020. | Model description, process scheduling, rationale and replication discipline. |
| **S18** | Flecs, *Relationships*, live documentation. | Data-oriented relationship pairs; not historical semantics. |
| **S19** | Jensen & Kristensen, *Coloured Petri Nets*, Springer, 2009. | Surveyed protocol/state-space alternative; overview/contents only. |

The ODD literature’s emphasis on explicit model description and scheduling supports keeping execution assumptions inspectable. It does not supply this project’s social mechanisms. [S17] No package other than the standard-library components named below was installed or benchmarked for this return. Live documentation version labels are not evidence that those versions were used by the probes.

### 8.2 Actual execution environment

| Item | Observed value |
|---|---|
| Interpreter | CPython 3.13.5; GCC 14.2.0 build |
| Database library | SQLite 3.46.1 via Python standard library |
| Platform | Linux 6.18.44 x86_64; glibc 2.41 |
| External Python dependencies | None |
| Probe version | `TRES-0001A-probes-1.0` |
| SQLite test configuration | `journal_mode=DELETE`; `synchronous=FULL` |
| Repetition | Three separate processes on the same host/build; default hash seed and explicit `PYTHONHASHSEED=17` and `733` |
| Database integrity check | `PRAGMA integrity_check` returned `ok` |

`experiments/probes.py` is fully included. It writes only to its specified output directory; it replaces an existing `probe.sqlite` there. The main outputs are `results.json`, `fixture_events.jsonl`, `history_trace.jsonl`, `final_state.json`, `probe.sqlite`, and `repeatability.json`.

### 8.3 Executed checks

| Experiment group | Checks | Observed result | Limitation |
|---|---:|---|---|
| **X1 — persistence representations** | 4 | State parity at 11 prefixes; event replay at 11 prefixes; SQL historical facts at 11 prefixes; successful final database reopen. | Shared semantics, tiny history; no independent implementation oracle. |
| **X2 — fixture history** | 5 | Resource partition preserves `H001`; death preserves history and continuity; relation types remain distinct; split and recombination retain predecessor lineage. | Injected relations and deliberately inadequate recognition. |
| **X3 — historical identity memory** | 2 | Fixture continuity survives complete original-person turnover; identical final facts differ under continuous versus fresh observation history. | Demonstrates path dependence under the fixture policy, not household-theory validity. |
| **X4 — checkpoint closure** | 2 | Complete continuation matched for 50/50 seeds; seed-only and missing-queue negative controls each matched 0/50. | Separate toy scheduler, not the whole social kernel; same environment only. |
| **X5 — resource conflict** | 1 | Naive proposals both claim one unit; explicit resolution accepts one under both input permutations. | Lexicographic fixture priority, not fairness or a selected social rule; no real concurrency. |
| **X6 — consistency and duplication** | 3 | Injected exception rolls back state/history changes; duplicate event is a no-op; changed content under the same ID is rejected by both paths. | Handled exception, not power loss; event path is in memory. |
| **X7 — feedback and intervention** | 2 | Supported opportunity changes the toy action; replaying the old outcome disagrees with reevaluating the intervened branch. | Event-kernel branch and artificial action guard only. |
| **X8 — support validity** | 2 | Relation withdrawal changes the derived configurations; explanation witnesses point to exact current supporting fact versions. | Full recomputation; no incremental rule engine or complete choice explanation. |
| **Total** | **21** | **21 passed in each of the three process runs.** | Counts are checks, not 21 independent scientific experiments. |

The complete logical-results SHA-256 is:

`106ffff6687495b23986ef98d57892b314930a81809c12d89b4e5f93041b09ed`

The final fixture-state SHA-256 is:

`494bb21255589a5d99f3f34346fb547e8f9e7e2e75920143f4b99aa09b94517f`

These identify the included serialized results; they are not evidence of cross-platform reproducibility. The code checksum and process comparison are in `experiments/results/repeatability.json`.

### 8.4 Reproduction

From the return directory:

```sh
python experiments/probes.py --out ./local_probe_results
```

No database server, network access, package install, or project repository is required. Use a new output directory to preserve the supplied evidence. See `experiments/README.md` for separate-process comparison and interpretation notes.

### 8.5 What was not executed

No production event store, concurrent database workload, physical crash recovery, Mesa model, Soufflé program, GROOVE graph system, Pekko actor system, or IRM4MLS implementation was tested. No realistic motive system, obligation-resolution model, household recognizer, demographic calibration, large-population benchmark, or full end-to-end scenario branching framework was implemented. The research establishes design plausibility and narrow mechanical counterexamples, not a finished Social Fabric Laboratory.

### 8.6 Source locators

These URLs identify the sources listed in §8.1; inspected sections and limitations are expanded in the source ledger.

**S01:** `https://learn.microsoft.com/en-us/azure/architecture/patterns/event-sourcing`  
**S02:** `https://martinfowler.com/eaaDev/EventSourcing.html`  
**S03:** `https://docs.datomic.com/transactions/model.html`  
**S04:** `https://docs.datomic.com/reference/filters.html`  
**S05:** `https://www.w3.org/TR/prov-dm/`  
**S06:** `https://groove.cs.utwente.nl/`  
**S07:** `https://souffle-lang.github.io/provenance`  
**S08:** `https://souffle-lang.github.io/rules`  
**S09:** `https://arxiv.org/html/1310.7951`  
**S10:** `https://simpy.readthedocs.io/en/4.1.1/topical_guides/time_and_scheduling.html`  
**S11:** `https://mesa.readthedocs.io/stable/overview.html`  
**S12:** `https://pekko.apache.org/docs/pekko/current/general/message-delivery-reliability.html`  
**S13:** `https://www.postgresql.org/docs/18/transaction-iso.html`  
**S14:** `https://www.sqlite.org/atomiccommit.html`  
**S15:** `https://numpy.org/doc/stable/reference/random/compatibility.html`  
**S16:** `https://docs.python.org/3.13/library/random.html`  
**S17:** `https://www.jasss.org/23/2/7.html`  
**S18:** `https://www.flecs.dev/flecs/Relationships.html`  
**S19:** `https://link.springer.com/book/10.1007/b95112`  

## 9. Unresolved questions and assumptions

**Social semantics remain open.** The meaning and evidence of household organization; multiple/overlapping participation; how persistence is judged; what survives fission; how obligations are transmitted or contested; and what permits collective coordination all require model choices not settled by this architecture reconnaissance.

**Execution semantics remain open.** The laboratory must choose how conflicting proposals are resolved, which perceptions are contemporaneous, how collective feedback is phased, and whether some ordering is part of the modeled process or only an implementation convention. Deterministic execution is an attractive test target, not a claim that all future investigation must be bitwise deterministic.

**Historical interpretation remains open.** Stable IDs, versioned observations, and lineage are recommended mechanisms, but no rule selects which successor inherits an identity or whether old labels can be reused. The fixture’s new identifiers on split/recombination must not leak into accepted semantics. The need for both valid time and recording time depends on whether late information or retrospective corrections become part of the laboratory.

**Persistence authority remains open.** The evidence does not select between event authority and atomic temporal-state authority. A complete checkpoint must capture the model’s actual state, but its format and storage technology are unresolved. Whether certain collective/controller state is reconstructed or stored directly must be specified when that state is defined.

**Performance and software choices remain open.** No final population, language, engine, data store, parallelism strategy, or UI is assumed. Python and SQLite here are disposable experimental instruments. The first useful laboratory should not inherit their selection from this return.

**Scope remains ordinary social fabric.** Future collective extensibility is evaluated as preservation of distinct semantics, not as an invitation to design institutions now. No additional mechanisms for temples, palaces, states, markets, warfare, cities, demography, or a complete economy are introduced.

**Final advisory position:** preserve causal distinctions and experiment closure first; compare two small, historically complete authority contracts; promote more elaborate rule or multilevel machinery only when a worked failure shows what it solves. The strongest outcome of Task 1 is not a stack choice, but a falsifiable way to distinguish architectures without sacrificing the project’s causal foundation.
