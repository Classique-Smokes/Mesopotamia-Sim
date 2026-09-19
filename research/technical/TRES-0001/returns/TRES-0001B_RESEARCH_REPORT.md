# TRES-0001B — Persistent State, Identity, and Relationship Representation

**Advisory technical research for the Master Architect**  
**Scope:** Task 2 only · independent-context packet  
**Research and execution date:** 19 September 2026  
**Status:** Research completed; disposable representation experiments executed. No project decision, canonical specification, production implementation, language selection, or database selection is made by this report.

The supplied B package and its shared context are the only project inputs. References `[P…]` identify those inputs; `[S…]` identify external primary sources; `[EX…]` identify the accompanying reproducible experiments. Section 8 gives precise provenance. Findings from synthetic fixtures are not historical claims about Mesopotamian households.

## 1. Executive synthesis

### The architectural distinction that matters first

**The requirements call for a richly typed, historically legible social model—not necessarily a graph database, and not necessarily event sourcing.** Persistent people, material objects, relation instances, claims, obligations, and recognized household identities can be encoded in several storage families. What cannot be postponed safely is deciding how those identities, revisions, participant roles, and explanations are distinguished. This conclusion follows from the packet’s constraints and the encodability experiments, rather than from a preference for a product. [P1; P2; EX1]

The most useful provisional direction is **a current-state model with independently identifiable relation instances, explicit participant roles, retained historical revisions, and an atomically associated provenance journal**. An indexed in-memory representation and a normalized relational representation are both credible realizations. A property graph remains a credible alternative or projection. Use a relational implementation as a *reference comparator* in the next experiment, not as an accepted project platform.

A full event-sourced model also remains credible. Its distinguishing commitment is that recorded events, rather than stored current state, are authoritative. It becomes particularly attractive when rebuilding and reinterpreting projections is a central research activity. It also makes compatibility with old events part of ordinary maintenance. The appropriate choice depends on the intended recovery and replay contract, which the packet does not yet specify. [S8; S14; S15]

### Findings the Master Architect can use now

**Stable identity should not be derived from mutable content.** A person’s name, a claim’s current holder, a household’s present participants, and a runtime allocation slot are unsuitable foundations for long-lived identity. An application-controlled identifier, scoped to a simulation run or branch, is the portable option. Runtime handles can be mapped to it. Neo4j explicitly warns against depending on its internal identifiers, while EnTT documents identifier reuse and remapping during loading. [S2; S9]

**Promote a relation to an independently referenceable object when it has an independent life.** Multiple obligations between the same parties, succession from an old claim to a new one, contestation of a particular claim, and a multi-party allocation all require more than a unique pair of endpoints. A record with typed roles can express this in a relational model; an intermediate node can express it in a graph. These are established modeling techniques, not evidence that one storage family must be selected. [S3; S11]

**A persistent household handle is compatible with emergence, but is not evidence of emergence.** The handle should identify a historically sustained collective, with versioned references to its supporting lower-level configuration. It must not become an unexplained `members[]` object. Recognition, continuity adjudication, and storage of their results are separate problems. The experiments deliberately inject the first two as fixtures and test only the third. [P1; EX1]

**Historical state, recorded provenance, and causal explanation are different capabilities.** A revision archive can show what changed. A provenance record can identify the inputs and rule that produced a change. Neither automatically establishes why that rule was appropriate, whether an agent’s interpretation was true, or what would have happened otherwise. Generic provenance standards supply useful vocabulary, but do not supply this simulation’s causal model. [S4; analysis]

**Death should change participation eligibility, not erase identity.** Whether each relation terminates, persists, changes status, or gives rise to a successor is a domain result. The storage layer should retain the identity and relevant revisions, not run a generic cascade over “everything connected.” [P1; P2; EX1]

### What was actually executed

The accompanying standard-library probe implements three storage paths: an indexed Python map loaded from a current-state snapshot; SQLite tables with a transactionally associated journal; and an event-log-authoritative projection rebuilt by replay. The same 11-event fixture traverses all three. It ends with **34 objects, including 24 relation instances**, and identical canonical current-state content across the paths. A separate two-event branch exercises parallel obligations, overlapping household support evidence, and dissolution without historical erasure. **All 160 checks passed.** These are assertion counts, not 160 independent scenarios or architectural proofs. [EX1]

Both required examples are represented, including unequal claims over one resource, a single actual user, household continuity after death, selected terminations, explicit obligation succession, and continued obligations. The probe also tests save/load, historical SQL queries, causal-link traversal, rejected malformed transitions, and rollback after an injected exception. It does **not** validate household emergence, autonomous collective behavior, production concurrency, native graph-database performance, or operating-system crash durability. [EX1]

## 2. Problem decomposition

### 2.1 Identity, revision, and runtime location

Three questions should have separate answers:

- **Which continuing thing?** A stable identity, such as person `A`, resource `R`, or obligation `O1`.
- **Which state of that thing?** A revision identifier, such as `(O1, version 2)`.
- **Where is it currently stored?** A row location, runtime handle, component index, or graph element.

For the laboratory, a namespace plus an opaque local identifier is a sufficient candidate. UUIDs are another option; RFC 9562 specifies their formats, but using one does not decide the simulation’s temporal or causal ordering. Persist any allocator state required to prevent reuse after a restart. Branches need an explicit namespace or ancestry convention so two alternative futures do not silently share incompatible “current” states. These are proposed safeguards, not a selected identifier scheme. [S5; analysis]

Content hashes remain useful for integrity checks and deduplication of immutable data. They should not identify a mutable household: removing one person changes a membership hash even when continuity is supposed to survive. The negative control in the probe demonstrates exactly that narrow failure. [EX1]

### 2.2 Relations, claims, and their participants

A relation instance can have an identity, a type, named participant roles, lifecycle state, qualifying terms, an effective interval, and provenance. The roles convey direction: `provider` and `recipient` are not interchangeable; neither are `debtor` and `creditor`.

Not every relation is naturally binary. A claim may involve holder, resource, granting party, beneficiary, and guarantor. A challenge may refer to an existing claim rather than directly to its resource. A succession record can connect a predecessor obligation and a successor obligation. Introducing an independently identifiable relation instance avoids hiding these distinctions in an overloaded edge. W3C’s n-ary modeling note provides a formal precedent, including the distinction between a relation occurrence and a statement *about* that occurrence. [S3]

The proposed threshold for promoting a relation is functional: promote it when it must be separately referenced, revised, transmitted, contested, terminated, or distinguished from another occurrence with the same participants. Do not manufacture objects for every transient predicate or cached statistic.

A generic participant table is not permission to abandon types. A relation-type registry or explicit typed tables should define allowed roles, cardinalities, target categories, and term schemas. In the probe, Python validates these semantics; SQLite independently enforces selected reference and uniqueness constraints. The database does not independently understand the complete social vocabulary. [EX1]

### 2.3 Assertions, accepted entitlements, conditions, and observed behavior

“Someone claims a share,” “that share is recognized,” “the right is currently exercisable,” and “someone is using the resource” are distinct propositions.

A useful candidate model separates relation lifecycle from recognition status, conditional effectiveness, and actual behavior. A validly stored contested claim need not be a recognized entitlement. A retained conditional claim need not currently authorize use. A person can use a resource without owning it, or have an entitlement without exercising it. This follows directly from the packet’s separation requirements. [P1; P2]

Consequently, a rule such as “all shares over a resource must sum to one” cannot be a universal storage invariant. It may be an invariant for a specified set of accepted claims of a specified kind and scope. It should not sum title fractions, fractions of yield, contingent interests, and contested assertions together. The fixture keeps accepted title at one while a competing assertion raises the sum of *all asserted title fractions* to three-halves. No arithmetic inconsistency follows because those are different query populations. [EX1]

### 2.4 Resource identity, rights partition, and material transformation

Partitioning claims over `R` should not automatically create several material resources. Conversely, physically subdividing a field may justify new resource identities with a transformation record linking them to the predecessor. The persistence layer must be able to represent both without deriving one from the other.

Likewise, a change of user, resident, owner, or beneficiary must not itself redefine the place or asset. Resource partition must not automatically become household fission. These are independent dimensions whose actual interaction belongs to future domain rules. [P1; P2]

### 2.5 Household recognition, continuity, and collective state

Four elements can be kept distinct:

**Lower-level facts** include people, support, residence, claims, obligations, and other relevant relations.

**Recognition evidence** records which versions of those facts were used, by which recognizer or rule version, to identify a household-scale configuration.

**Continuity evidence** explains why a later configuration continues an earlier household identity, or instead supports dissolution, fission, or another lineage relation.

**Collective state** records commitments, coordinated outcomes, or path-dependent state attributed to an already recognized collective. It need not be reducible to a membership list or to a statistic of the *current* graph; its existence must remain historically explainable. [P1; analysis]

A household record can therefore exist without being a primitive membership container. Its identifier answers “which continuing collective?” A support-evidence record answers “on what lower-level basis is it currently recognized?” Typed relations answer who resides, owes, supports, uses, or benefits. No one of those views is automatically “the membership.”

Do not use the connected component of *all* social relations as household identity. An external creditor or a support relation can connect otherwise distinct structures. Nor should exact equality of constituent sets determine continuity. These are failure conditions derived from the packet, not criticisms of graph storage itself.

A recognition handle with one arbitrary witness is still not a household model. The probe checks that active evidence references exist, are current and lower-level, and are not directly self-grounding through the household. It does not decide whether the evidence is socially sufficient. This limitation is central to interpreting its positive results. [EX1]

### 2.6 Lifecycle, retention, and succession

A person’s death, a relation’s termination, a claim’s supersession, a household’s dissolution, and physical deletion from storage have different meanings. Historical referenceability and current eligibility should not share one Boolean flag.

The prototype should be able to retain an identity with a terminal or inactive state. Archived historical content may eventually move out of the hot working set, provided references still resolve. Hard deletion should normally be restricted for referenced identities in the research store; archival and deliberate erasure require explicit policy.

Changing the debtor of an existing obligation in place is not automatically wrong, provided historical revisions remain interpretable. Creating a successor obligation with explicit lineage is another valid option. The latter is used in the fixture because it exposes the transmission clearly. **Task 2 should preserve the ability to choose either semantic convention; it should not decide the project’s succession rules.**

### 2.7 Mutation, atomicity, and explanation

A death-disposition operation can touch a person, multiple relation instances, obligation lineage, and household evidence together. Its consistency boundary is not necessarily “one person” or “one household.” An event-stream design partitioned by those identities would still need a strategy for coordinated changes across them.

A candidate mutation envelope would identify the event or operation, expected revisions, inputs actually consulted, resolved changes, applicable rule/version, and explicit predecessor links. State changes and their explanatory record should become visible together. Failed validation should leave neither half installed.

The SQL probe demonstrates exception rollback of a journal insertion before state mutation. This is a limited transaction test. SQLite documents broader atomic-commit mechanisms, but this experiment does not reproduce power failure, filesystem faults, or all durability settings. [S7; EX1]

For explanation, distinguish a triggering event from enabling facts, the consulted versions of those facts, the applied rule, and the produced outcome. Negative information can matter too: a future recognizer may need to record which relevant ties were absent, or why alternatives were rejected. A causal predecessor list alone cannot express every such justification. PROV’s distinction among usage, generation, derivation, invalidation, and responsibility is useful conceptual guidance. [S4; analysis]

### 2.8 Temporal questions and save/load

The following questions are not interchangeable:

“What is active now?” asks about current simulation state. “What was effective at simulation time t?” asks about domain validity. “What had the system recorded by revision r?” asks about recording history. “What did agent A believe then?” asks about agent-specific information.

Bitemporal storage addresses the domain-validity and recording-history distinction; it does not automatically represent an agent’s beliefs. XTDB documents separate valid-time and system-time intervals. SQL Server’s system-versioned periods are based on database transaction time; those timestamps must not be mistaken for the simulated world’s clock. [S12; S13]

The probe uses integer fixture sequence points and reconstructs earlier committed states. It does not implement late-arriving facts, retroactive correction, interval joins, or a production time model.

A complete future simulation checkpoint would need more than the social records: pending operations, scheduler position, random-generator state, identity allocation state, relevant rule/code versions, and authoritative collective state may all affect continuation. Save/load should occur at a defined consistency boundary, then rebuild derived indexes and validate references before resuming. The present probe tests representation-level continuation only; it has no autonomous scheduler or random decision process. [EX1; proposed validation requirements]

## 3. Credible approaches discovered

### 3.1 Object or document model with stable-ID references

A dictionary of typed objects, with references stored as IDs and secondary indexes for relevant roles, is a viable small-laboratory representation. Relations can themselves be objects. A versioned neutral snapshot avoids making live memory addresses part of the save format.

The advantages for this task are inspectability and low infrastructure overhead. The costs are explicit index maintenance, application-managed validation, and a deliberately designed history layer. A nested `Household → people → assets` document is a poor *particular encoding* of the requirements, not evidence that all object or document models fail. Shared references and independent relation objects repair much of that problem.

The indexed-map path was executed. It is not a benchmark of an object database or document database product. Its whole-state copies and full index rebuilds deliberately favor simplicity over mutation efficiency. [EX1]

### 3.2 Normalized relational model with explicit relation instances

Persons, resources, households, relation instances, role bindings, revisions, and provenance can occupy separate tables. A conventional association table can be sufficient for a simple tie; a relation identity plus participant rows becomes useful when parallel occurrences, extra roles, or references to the relation itself are required.

Primary keys and foreign keys supply familiar identity and reference mechanisms. However, cross-row social rules are not automatically expressible as row-level checks. PostgreSQL explicitly cautions against using `CHECK` to enforce arbitrary conditions involving other rows, and notes that foreign keys do not automatically index referencing columns. [S1]

The SQL probe normalizes identities, participants, revisions, household witnesses, and causal links. Typed attribute payloads remain JSON for the disposable experiment. A future implementation could use explicit subtype columns or validated payload schemas. This is a deliberate compromise, not a claim that an unconstrained universal JSON table is adequate.

SQLite foreign-key enforcement was enabled on every connection, and a direct SQL bypass test verified rejection of a dangling reference. The implementation also restricts deletion of referenced identities. [S6; EX1]

### 3.3 Property graph with first-class relation nodes where needed

A graph representation makes neighborhood and path questions explicit. Simple typed edges can model simple ties. Rich or multi-party relations can become intermediate nodes, with role-specific edges to people, resources, other relations, and collectives.

Neo4j’s own modeling guidance uses intermediate nodes where an association needs more than two participating nodes. Its internal element identifiers should not be the application’s long-term identity scheme. [S2; S11]

This is a credible alternative, particularly if observed workloads center on variable-depth typed traversals. It does not eliminate validation, history, temporal qualification, or transaction-boundary design. An undifferentiated relationship graph is still semantically weak even when traversal is fast.

The report gives conceptual graph mappings of the examples, but **no native graph database was installed or benchmarked**. The executed map is an adjacency-indexed representation, not a Neo4j substitute for performance claims.

### 3.4 Entity-component or relationship-component runtime

A compositional runtime can separate persistent identity from changing components. Relation instances can be represented as entities carrying participant and state components. Common simulation queries can then operate over component collections.

EnTT documents reusable versioned runtime identifiers and distinct snapshot/continuous loading behavior. Its continuous loader remaps source identifiers to destination identifiers. Flecs provides explicit relationships and configurable cleanup behavior; its documentation also notes costs associated with relationship-driven table creation. [S9; S10]

These mechanisms make ECS-style runtimes credible, but not complete persistence architectures. Mapping runtime handles to durable identities, retaining historical relations, and controlling automatic cleanup remain separate responsibilities. In particular, a hierarchy primitive that deletes children when a parent is deleted should not be repurposed as an ordinary household-membership relation.

This family was assessed from primary documentation, not executed. No claim is made about its throughput relative to the other candidates.

### 3.5 Semantic graph / RDF representation

RDF offers an interoperable graph representation using identified resources and predicates. Independently named relation occurrences can express multi-party claims or obligations. RDF itself, however, does not supply this project’s mutation protocol or social invariants. SHACL provides a separate vocabulary for validating graph shapes. [S16; S17]

This family becomes more compelling if ontology interoperability, reusable semantic queries, or exchanging provenance with external knowledge systems is a major requirement. None is presently binding. For the small laboratory, a semantic stack should justify its additional vocabulary and validation burden against simpler typed representations.

An RDF implementation remains a credible research option, not a prerequisite for historically meaningful relationships. No triple store or inference engine was executed.

### 3.6 Event sourcing with current-state projections

Event sourcing is principally a decision about authority and reconstruction, not a rival to SQL or graph storage. A log can be authoritative while a relational, object, or graph structure serves current queries. Snapshots can bound reconstruction work. Microsoft’s architectural guidance describes this authority contract and the associated event versioning and snapshot concerns. [S8]

For this laboratory, resolved facts such as “these successor obligations were created” are safer replay material than instructions such as “run inheritance again under whatever rule is installed.” Replaying recorded outcomes and rerunning decisions under changed rules are different experiments. The latter requires deliberate branch and input handling.

Fowler’s original exposition discusses replay complications when processing reads external information or produces external effects. The analogous risk here is silently consulting changed rules, randomness, or unrecorded inputs while claiming to reconstruct the same past. [S18]

Schema evolution is not merely theoretical overhead: the primary study by Overeem and colleagues reports challenges from 19 event-sourced systems discussed with 25 engineers. Its abstract identifies evolution and projection rebuilding among the challenges. That evidence motivates caution; it is not a performance result for this simulation. [S15]

### 3.7 Temporal revisions and bitemporal storage

Revision history can be combined with any of the main representation families. Bitemporality adds an explicit distinction between when a fact holds in the modeled domain and when the system records it. [S12; S13]

This is useful when researchers need to correct or backdate facts while retaining the previous recorded interpretation. It is not automatically necessary for forward-only fixture simulation. Retain the conceptual distinction now; choose full bitemporal machinery only when a concrete query requires it.

Temporal history should also not replace explanatory metadata. Two equally complete row histories may record the same change while omitting entirely different underlying reasons.

## 4. Comparison

### 4.1 Representation families

The following is a task-specific assessment. Cells describe consequences of the candidate design, not measured vendor rankings.

| Candidate | Main strengths here | Main cost or weakness | Observability | Migration / reversibility |
|---|---|---|---|---|
| ID-referenced objects + indexes | Direct, inspectable laboratory state; simple custom operations | Integrity and index synchronization are application responsibilities | Excellent when explicit revisions and provenance are retained; otherwise weak | Neutral IDs and serialization preserve options; runtime-object dumps do not |
| Normalized relational relation model | Explicit references, transactional coordinated changes, ad hoc tabular queries | Typed role and cross-record invariants need deliberate enforcement; some traversals need recursive queries | Current state, revision tables, and causal-link queries can be inspected separately | Good conceptual portability with typed records and IDs; dialect-specific features increase coupling |
| Property graph + relation nodes | Natural role and neighborhood traversal; relations can be subjects of other relations | History and role constraints still require modeling; extra nodes increase representation volume | Clear typed pathways when current and historical structures are distinguishable | Application IDs help; native traversal and temporal idioms require translation |
| ECS / relationship-component runtime | Flexible changing component sets; credible runtime query organization | Durable IDs, archival state, and serialization need a separate contract | Usually needs explicit research-oriented history tools | Portable domain IDs help; component binary layout or native handles in saves create risk |
| Semantic graph + validation | Explicit vocabulary and external interoperability | More modeling and validation machinery than the packet currently requires | Strong potential for provenance queries, provided the semantics are supplied | Semantic exports can be portable; inference and validation choices remain consequential |

The object and relational mappings have executed evidence in this package. The native graph, ECS, and semantic-stack assessments remain documentation-based. [EX1; S1–S3; S9–S11; S16–S17]

### 4.2 History and authority are a separate comparison

| History strategy | What it can answer | Principal risk | Advisory position |
|---|---|---|---|
| Current snapshot only | What is stored now | Cannot recover omitted history or explanation | Insufficient as the only research record |
| Current state + revisions | What changed and earlier recorded values | Reasons, consulted inputs, and rule identity can still be absent | Useful substrate, not a complete causal record |
| Current state + revisions + synchronized provenance journal | Current queries plus recorded transitions and their declared basis | Unjournaled mutation or disagreement between state and journal | Preferred starting comparator for the next bounded prototype |
| Authoritative event log + projections + checkpoints | Reconstruction and alternative projections of retained events | Replay compatibility, incomplete event payloads, projection drift | Keep as a live alternative when replay is central |
| Bitemporal state + provenance | Domain-valid and recorded-time views plus explanations | Interval semantics and correction complexity | Add when retrospective corrections are a demonstrated requirement |

These designs overlap. A fully detailed journal can support replay, while an event-sourced application can persist current projections. Their difference must be specified by **which representation may repair the other**, not by file names. The probe intentionally retains complete resolved writes in every journal; it tests that these representations can agree, not that one recovery contract is intrinsically superior. [EX1; analysis]

### 4.3 Mutation complexity and scaling

Let N be stored objects, E relation instances, A participant bindings, d the relevant local degree, and H retained historical changes. A full scan for each neighborhood query visits work proportional to the searched population. An index on participant role and target can restrict work to matching candidates. A hash adjacency index and a database index have different implementation costs, but both avoid making an unrelated large population the default search space.

Variable-depth traversal is different: work depends on the reachable typed subgraph, and high-degree nodes can dominate. Recognition queries might also depend on absences, competing configurations, or historical windows. The simple one-hop benchmark cannot predict any of those costs.

History growth follows recorded mutations and payload size, not just active population. Replaying all relevant past changes for every current query needlessly couples hot-query cost to simulation age. Current projections, checkpoints, revision indexes, and bounded history windows are candidate remedies; their selection should follow observed workloads.

The executed mechanism probe uses 1,000, 10,000, and 100,000 synthetic relations, with exactly one match per query. At 100,000 relations, 100 full-scan queries took about 188 ms in the recorded run, compared with about 0.18 ms for indexed SQLite queries and 0.012 ms for direct map lookups. These numbers exclude index construction, writes, serialization, disk I/O, and realistic graph traversal. They show why indexing matters; **they do not rank production databases or establish a supported population size**. [EX2]

The replay sub-probe likewise demonstrates a mechanism only: a checkpoint reduces the replayed suffix from the full event count to 100 scalar updates. Its timings do not include domain validation, causal traversal, or loading the snapshot.

A major limitation of the semantic probe is deliberately expensive implementation: it deep-copies the current model and checks all state for each event, and rebuilds map indexes. The SQL adapter also uses this shared validator before writing. It should not be treated as an optimized mutation engine or as evidence of database overhead. [EX1]

### 4.4 Migration choices with disproportionate consequences

The safest early boundaries are between durable IDs and runtime handles, relation kinds and arbitrary strings, resource identity and claim identity, current state and retained history, and semantic record formats and storage-specific serialization.

Moving normalized role bindings into a graph is a mapping exercise only if role meaning, identity, and revision context are already explicit. A schema migration cannot reconstruct missing causal inputs, recover a second obligation overwritten by an endpoint-pair key, or undo years of household identity being equated to a membership hash.

Version the record envelope and event vocabulary. A rename-only upcast is different from changing the meaning of succession or household continuity. Marten documents concrete upcasting mechanisms; the relevant lesson is the need for an explicit compatibility path, not a recommendation to use Marten. A changed domain rule should not masquerade as a serialization repair. [S14; analysis]

## 5. Worked social-fabric examples

### 5.1 Example A — three heirs, distinct claims, one actual user

All quantities and norms below are controlled fixtures, not historical findings or proposed inheritance law.

**Initial material identity:** `R` is one field. `A`, `B`, and `C` are three distinct individuals. An injected allocation event creates the following records:

| ID | Kind / state | Participants and meaning |
|---|---|---|
| `CA` | Accepted title claim | A holds 1/2 of title over R |
| `CB` | Accepted title claim | B holds 1/3 of title over R |
| `CC` | Accepted title claim | C holds 1/6 of title over R |
| `UA` | Use permission | A has a separately recorded permission concerning R |
| `BB` | Benefit claim | B has a 1/4 share of yield from R; this is not a title fraction |
| `FC` | Conditional future-use claim | C has a conditional claim whose fixture condition is not yet satisfied |
| `USE` | Actual-use relation | A is the actual user of R |

The three title claims are unequal and separately identifiable. Additional claim kinds demonstrate that a title field is not a complete claim model. At this checkpoint, there is exactly one actual-use record. The implementation stores the future-use condition descriptively and its supplied truth state; it does not implement a condition language or evaluator. [EX1, E001–E003]

**Relational realization, executed.** `R` appears once in `objects`. Each claim has its own object row and typed participant rows. A current claim query starts with bindings whose role is `resource` and target is `R`, then filters relation kind, lifecycle, recognition, and condition as appropriate. An actual-use query selects `actual_use` and its `user` role instead. Historical revisions and the creating event retain the origin of each claim.

An illustrative query against the delivered schema is:

```sql
SELECT o.id, o.kind, p_holder.target_id AS holder, o.attrs
FROM objects AS o
JOIN participants AS p_resource
  ON p_resource.relation_id = o.id
 AND p_resource.role = 'resource'
JOIN participants AS p_holder
  ON p_holder.relation_id = o.id
 AND p_holder.role = 'holder'
WHERE p_resource.target_id = 'R'
  AND o.kind = 'title'
  AND o.status = 'active'
ORDER BY o.id;
```

This intentionally returns asserted active title claims; accepted-only entitlement queries must additionally filter recognition. The schema’s experimental attribute payload makes that distinction visible rather than silently implied.

**Indexed object realization, executed.** The same identities and records occupy an ID dictionary. An index keyed by `(role, target ID)` returns the candidate relation IDs. Saving records and their stable references, then rebuilding the index, reproduces the query results. The adjacency list is a derived access structure, not the source of claim identity.

**Event-sourced realization, executed.** `E002` records the resolved allocation, and `E003` records observed use while referencing the permission version it consulted. A projection creates the same current records. Replay installs the supplied outcomes; it does not re-execute an inheritance algorithm. To investigate a different allocation rule, create a distinct experimental branch rather than describe altered outcomes as replay of the same events.

**Property-graph mapping, conceptual only.** Each claim can be a node with role edges such as `HOLDER → A` and `RESOURCE → R`; `USE` is a different relation node with `USER → A`. Claim lineage, challenges, or witnesses can reference the claim nodes. Native graph execution was not needed to demonstrate the logical mapping. [S11; analysis]

**Subsequent stress transitions.** In `E010`, A’s title claim becomes superseded and a new title claim gives D the same half-share. A succession relation connects the two claim identities. A’s residence and actual use do not change. In `E011`, C asserts an additional contested half-share. Accepted title still sums to one; summing accepted and contested title gives three-halves. The model retains both rather than “repairing” the conflict by deleting an assertion. [EX1]

This example falsifies the adequacy of a single `resource.owner` field, a single undifferentiated `resource.claimants` set, and a unique endpoint-pair key for independently occurring claims. It does not falsify relational, graph, or object representations that distinguish these concepts.

### 5.2 Example B — household continuity after a central person’s death

At `E004`, the lower-level fixture includes support from A to B and separately from B to A; residence of P and A at dwelling L; a kinship record relating P and A; a personal service relation from P to Q; a personal obligation `O1` from P to Q; and a separate obligation `O2` from B to Q.

At `E005`, the fixture records recognition of household `H`, citing versions of the support and residence relations. It does not assign a canonical member array. At `E006`, H acquires a collective obligation `OH` to Q, and A receives an explicit delegation relation from H. These commitments are downstream of recognized collective identity, not evidence used circularly to establish H’s initial existence. [EX1]

At `E007`, an injected death-and-disposition outcome applies the following batch:

| Record or structure | Before | After | Representational consequence |
|---|---|---|---|
| Person P | Active person | Dead, still retained | Historical references continue to resolve |
| P’s residence `RP` | Active | Terminated | No automatic change to the dwelling identity |
| P’s personal service `V` | Active | Terminated | Selected personal activity ends |
| Kinship `K` | Retained kinship | Retained kinship | Death does not erase genealogy |
| Personal obligation `O1` | P owes Q | Superseded | Original debtor remains visible historically |
| Successor `O1A` and lineage `LIN` | Absent | A owes Q; explicit predecessor link | Transmission is represented, not hidden in an overwritten endpoint |
| `O2` and collective obligation `OH` | Active records | Unchanged | Unaffected obligations remain distinguishable |
| Household H | Recognized on four witness relations | Same H, renewed evidence without RP | Continuity does not depend on keeping P or a frozen participant list |

The storage layer does not deduce these outcomes from death. The disposition and continuity rules are fixture labels with outcomes supplied in the trace. A future rule engine could produce different, equally representable dispositions. [EX1]

**Relational realization, executed.** The batch changes seven object records, adds the needed relation/revision rows, and updates H’s witness references together with its event record. Current reference rows remain valid. SQL can recover the active and dead revisions of P; a recursive query over `causal_links` retrieves the declared predecessor chain of a later collective allocation. Hard deletion of the referenced person was separately rejected by the database.

**Indexed object realization, executed.** The batch is validated against a candidate state before it replaces the prior state. Identity P remains addressable while its status changes. The current role index excludes terminated relation records, but they remain in retained state and history. H’s ID stays the same while its evidence changes.

**Event-sourced realization, executed.** The resolved disposition event records the complete affected set. Replaying through `E006` returns pre-death state; replaying through `E007` returns the death disposition. A checkpoint at `E006` plus the remaining suffix reproduces the final state. Splitting this conceptual disposition into independent per-person streams would not itself guarantee coordinated visibility; that would require an additional design decision.

**Property-graph mapping, conceptual only.** P’s node is retained with its lifecycle change. Terminal relation nodes remain accessible to historical queries. `LIN` connects predecessor and successor obligation identities. H keeps its node and updates its versioned support evidence. Nothing requires deleting H’s node or replacing it with a new component identifier because P dies.

**Collective feedback and further turnover.** `E008` records a collective allocation to B, referencing H, its delegation, and a lower-level support input; H’s fixture counter changes. This proves that a collective outcome can be represented and linked back to its basis, not that the collective autonomously chose it. `E009` changes A’s residence to L2 without changing title; H continues on renewed evidence. [EX1]

A separate branch adds two obligations with identical debtor/creditor pairs and distinct identities, plus a second recognized configuration using one of H’s supporting relations. Both survive representation without forced exclusivity. The branch then terminates the remaining witness relations and explicitly records dissolution of both household identities. H and its historical commitments remain addressable. The collective obligation’s ultimate settlement or extinction is intentionally unresolved; retaining its record does not assert that a dissolved household can still act. [EX1, branch trace]

### 5.3 What the examples do not settle

They do not establish historical inheritance rules, an appropriate household-recognition threshold, the correct treatment of every obligation after death, or whether a given observed configuration should be one household or several. They establish that the candidate information models need not preclude those choices, collapse distinct facts, or erase the past while the rules are still being investigated.

## 6. Failure modes / falsification conditions

| Failure condition | Why it is a bad foundation here | Evidence or test status |
|---|---|---|
| Identity equals current member set, address, owner, or storage slot | Ordinary turnover changes “who the entity is” or redirects old references | Membership-hash control executed; native handle risks documented [EX1; S2; S9] |
| One endpoint pair is the identity of every relation occurrence | Parallel obligations overwrite or collapse each other | Pair-key negative control and parallel-obligation branch executed [EX1] |
| Resource ownership, use, residence, and benefit share one field | Required examples cannot be expressed independently | Required fixture and independent transfer/move transitions executed [EX1] |
| Any household-related association implies exclusive membership | Overlapping support or external relations become invalid by construction | Nonexclusive-evidence branch executed; broader recognition semantics untested [EX1] |
| An active household can have no lower-level support record | Persistent handle becomes an unexplained primitive | Empty, inactive, stale, and directly circular witness cases rejected; sufficiency not tested [EX1] |
| Generic deletion cascade implements death | Historically meaningful people, obligations, or ties vanish | Hard-delete restriction tested; domain disposition remains explicit [EX1] |
| Every asserted claim is forced into one accepted-share total | Contestation is erased or rejected as corrupt storage | Accepted total 1 versus asserted total 3/2 executed [EX1] |
| History records only updated values or event labels | No record of the actual inputs and rule basis | Analytical failure condition; no storage format alone repairs missing explanations |
| Current mutation succeeds but its provenance does not, or vice versa | Present state and explanation disagree | Exception injected between journal and state writes; SQL rollback verified [EX1] |
| Event replay reruns changing decisions or external reads | Reconstruction can silently become a different simulation | Analytical failure condition supported by replay literature [S18] |
| “Active record” automatically means “currently eligible actor/right” | Conditional, disputed, terminal, or unsettled states become conflated | Explicit modeling warning; full eligibility engine not implemented |
| System recording timestamp is used as simulation time | Earlier validity and later discovery/correction cannot be distinguished | Documented temporal semantics; no bitemporal engine tested [S12; S13] |
| Every hot query scans all relations or replays the whole past | Cost grows with unrelated population or accumulated history | Isolated mechanism probe executed [EX2] |
| Language-native memory layout or handle is the save contract | Refactoring or changing runtime can invalidate durable references | Migration analysis; no language migration executed |
| The only correct results come from the shared validator | Multiple adapters may reproduce the same semantic mistake | Explicit limitation: independent semantic implementation remains a next test [EX1] |

An approach should be rejected or revised when it can meet a proof obligation only by erasing a distinction, inventing exclusive membership, making a resource change imply social fission, or turning a temporary implementation convenience into a domain rule. Passing the present fixtures is necessary evidence of representational adequacy, not sufficient evidence of a complete social-fabric architecture.

## 7. Recommended next validation

### 7.1 First: an independently implemented semantic comparison

Use the supplied trace and add adversarial sequences generated independently of `candidate_state`. Implement one alternative validator or reducer without copying the current one. Compare current-state answers, identity continuity, historical revisions, and explanation dependencies after every committed batch.

Include complete witness turnover, temporarily ambiguous configurations, the same current participant set reached through different histories, resource partition without social fission, fission without resource partition, and a second relation occurrence with identical parties and terms. Inject recognition and continuity outcomes as explicit inputs until their algorithms are available; do not let the persistence experiment quietly select them.

**Discriminator:** an encoding that requires new primitives for every added case, or cannot preserve stable identity and distinguish histories without membership shortcuts, should not become the foundation.

### 7.2 Second: decide the recovery contract by an actual repair exercise

Create a current-state snapshot and explanatory journal, then separately corrupt or remove a projection, a snapshot, and a journal segment. Test the intended repair path for a state-authoritative design and an event-authoritative design.

Specify whether a complete event history must rebuild *all* authoritative state, whether checkpoints are sufficient recovery roots, which incomplete histories are admissible, and whether alternative projections must be regenerated routinely. Explicitly distinguish replaying recorded outcomes from rerunning decisions under alternative rules.

**Discriminator:** select the authority contract that supports the required recovery and research operations with fewer hidden exceptions—not whichever file is easiest to append to. No extra database product is required to perform this experiment.

### 7.3 Third: household evidence as a replaceable interface

Have a recognizer-facing fixture provide lower-level record revisions, a rule/version token, continuity lineage, and the permitted collective-state consequences. Change or withdraw that evidence and observe whether the store invalidates or refreshes the affected derived views without changing unrelated social structures.

Test shared evidence across overlapping collectives and reciprocal causal influence across time: lower-level facts support recognition; later collective outcomes alter later lower-level facts. Reject same-step self-justification, but do not ban all feedback cycles across history.

**Discriminator:** can the information model remain intelligible when the recognition algorithm changes, without renumbering every prior household or treating its old participant list as authoritative?

### 7.4 Fourth: a real mutation-and-query workload, with dense cases

After common queries are known, benchmark a workload combining relation creation, termination, assignment, conditional-effectiveness changes, multi-object death disposition, household evidence refresh, present-state neighborhoods, historical explanation, and save/load. Use a synthetic size ladder as an experiment, not as an accepted population target.

Vary degree distribution, retained history per live entity, overlap between collectives, and the share of queries requiring several typed hops. Measure index maintenance, mutation latency, state/journal size, explanation-query cost, checkpoint cost, and load-plus-validation cost. Keep runtime, serialization, and storage costs separately visible.

**Discriminator:** prefer the representation that meets an explicitly chosen laboratory responsiveness and inspectability budget under the actual query mix. The current one-hop timings cannot supply that budget or that choice.

### 7.5 Fifth: migration, restart, and hostile-input checks

Exercise at least an additive field change, a renamed relation kind, a new participant role, a rule change that is *not* a schema change, and loading records in a different order. Verify the same identities and semantic query results after migration. Test truncated journals, inconsistent snapshot watermarks, duplicate delivery, missing dependencies, and a crash at each persistence boundary.

The present probe rejects duplicates rather than treating them as idempotent retries; choose a production retry contract deliberately. In a future autonomous simulator, compare uninterrupted execution with checkpoint/restart including scheduler and random state. Do not claim deterministic continuation from a social-state snapshot alone.

**Discriminator:** migration must not silently change what old claims, recognition decisions, or causal records mean. Native-store crash guarantees must be tested under the intended configuration, not inferred from the exception rollback in this package.

## 8. Sources / experiments

### 8.1 Project provenance

Only the following project documents were read. They are included verbatim under `input/`, with original archive member paths and SHA-256 hashes in `input/input_manifest.json`.

| Reference | Input | Relevant scope |
|---|---|---|
| P0 | `00_READ_ME_FIRST.md` | Independent-context and advisory authority |
| P1 | `01_ACCEPTED_FOUNDATION_CONTEXT.md` | Persistent social fabric; nonprimitive households; explicit unresolved choices |
| P2 | `02_PROTOTYPE_OBJECTIVE_AND_BOUNDARIES.md` | Laboratory proof obligations, controlled fixtures, scale posture, exclusions |
| P3 | `03_SHARED_RESEARCH_PROTOCOL.md` | Anti-anchoring rule and required nine-part return |
| P4 | `04_TASK.md` | Task 2 question and the two required examples |

The standalone B task and the B package task were byte-identical on extraction. Other task package contents were not read. No unrelated project history was used as binding context.

### 8.2 External primary-source register

All external pages below were accessed on **19 September 2026**. Live documentation is evidence of the documented mechanism at access, not proof that a specific version is installed in this experiment. No native PostgreSQL, Neo4j, EnTT, Flecs, Marten, XTDB, SQL Server, or RDF engine was executed.

**S1 — PostgreSQL Global Development Group, PostgreSQL 18 documentation, “5.5. Constraints.”** Primary documentation. Relevant sections: primary keys, foreign keys, cross-row `CHECK` limitations, deletion actions, and indexes on referencing columns.  
<https://www.postgresql.org/docs/current/ddl-constraints.html>

**S2 — Neo4j, Cypher Manual, “Scalar functions,” `elementId()` section.** Primary documentation. Relevant passage: identifier guarantees and application-generated IDs; internal ID reuse.  
<https://neo4j.com/docs/cypher-manual/current/functions/scalar/>

**S3 — W3C, “Defining N-ary Relations on the Semantic Web,” Working Group Note.** Primary modeling guidance. Relevant sections: introducing a class for a relation; multi-party relations; relation occurrences versus statements about them.  
<https://www.w3.org/TR/swbp-n-aryRelations/>

**S4 — W3C, “PROV-DM: The PROV Data Model.”** Primary standard. Relevant sections: entities and activities; usage, generation, derivation, invalidation, and responsibility/influence. Used as provenance vocabulary, not as a simulation-causality engine.  
<https://www.w3.org/TR/prov-dm/>

**S5 — IETF, RFC 9562, “Universally Unique IDentifiers (UUIDs).”** Primary standard. Relevant sections: UUID formats, generator state and monotonicity considerations. No UUID version is selected for this project.  
<https://www.rfc-editor.org/rfc/rfc9562.html>

**S6 — SQLite, “SQLite Foreign Key Support.”** Primary documentation. Relevant sections: enabling enforcement, reference constraints, and deletion actions. Actual probe connections explicitly enable enforcement.  
<https://www.sqlite.org/foreignkeys.html>

**S7 — SQLite, “Atomic Commit In SQLite.”** Primary documentation. Used to distinguish documented durability mechanisms from the narrower exception-rollback experiment performed here.  
<https://www.sqlite.org/atomiccommit.html>

**S8 — Microsoft, Azure Architecture Center, “Event Sourcing pattern.”** Primary architectural guidance. Relevant sections: authoritative event store, reconstruction, snapshots, event ordering and event evolution. Recommendations in the source are not adopted as project decisions.  
<https://learn.microsoft.com/en-us/azure/architecture/patterns/event-sourcing>

**S9 — EnTT project, “Entity Component System” wiki.** Primary maintainer documentation; accessed page identifies an April 2026 revision. Relevant sections: identifier lifecycle, snapshots, continuous loader and ID remapping. No claim about an installed EnTT release.  
<https://github.com/skypjack/entt/wiki/Entity-Component-System>

**S10 — Flecs project, “Relationships.”** Primary maintainer documentation. Relevant sections: relationship primitives, hierarchy cleanup behavior and table-creation considerations. The older documentation URL redirects to this page.  
<https://www.flecs.dev/flecs/Relationships.html>

**S11 — Neo4j, Getting Started, “Modeling designs.”** Primary modeling documentation. Relevant section: intermediate nodes for associations involving several participating nodes.  
<https://neo4j.com/docs/getting-started/data-modeling/modeling-designs/>

**S12 — Microsoft, SQL Server documentation, temporal-table overview, `sql-server-ver17` view.** Primary documentation. Relevant passages: transaction-begin UTC periods and historical queries. This is database system time, not a selected simulation clock.  
<https://learn.microsoft.com/en-us/sql/relational-databases/tables/temporal/overview?view=sql-server-ver17>

**S13 — XTDB, “Key concepts,” Temporal Columns & Bitemporality.** Primary documentation. Relevant passage: `_system_from`, `_system_to`, `_valid_from`, `_valid_to`, and their meaning. Vendor comparative claims are not used.  
<https://docs.xtdb.com/concepts/key-concepts.html>

**S14 — Marten, “Events Versioning.”** Primary maintainer documentation. Relevant sections: transforming old event representations with upcasters and explicit type mappings. Live documentation only; no Marten implementation was tested.  
<https://martendb.io/events/versioning.html>

**S15 — Michiel Overeem, Marten Spoor, Slinger Jansen and Sjaak Brinkkemper, “An Empirical Characterization of Event Sourced Systems and Their Schema Evolution — Lessons from Industry,” Journal of Systems and Software 178 (2021), 110970; arXiv:2104.01146.** Primary empirical study. **Only the accessible abstract and bibliographic record were consulted**, supporting the reported sample and broad challenges, not detailed findings or quantitative performance claims.  
<https://arxiv.org/abs/2104.01146>

**S16 — W3C, “RDF 1.1 Concepts and Abstract Syntax.”** Primary standard. Used only for the RDF graph and identification model; not as a claim about all current semantic-web tooling.  
<https://www.w3.org/TR/rdf11-concepts/>

**S17 — W3C, “Shapes Constraint Language (SHACL).”** Primary standard. Relevant scope: describing and validating constraints on RDF graphs.  
<https://www.w3.org/TR/shacl/>

**S18 — Martin Fowler, “Event Sourcing.”** Original author’s technical exposition. Relevant sections: external updates, external queries, and code changes during replay. Used for conceptual replay hazards, not current product capabilities.  
<https://martinfowler.com/eaaDev/EventSourcing.html>

The comparison tables and provisional recommendation are the present report’s analysis of those mechanisms against the packet. They are not rankings reported by the sources. No external source establishes that this architecture will generate historically plausible households.

### 8.3 Executed experiment register

**EX1 — Representation equivalence and adversarial fixture probe.** Source: `experiments/probe.py`. Detailed output: `results/results.json` and `results/EXPERIMENT_RESULTS.md`. Input trace: `results/fixture_trace.json`, with the additional branch in `results/branch_trace.json`. The generated SQLite database, schema, neutral snapshot, event stream, and final state are included.

Environment of the recorded run: Python **3.13.5**, SQLite **3.46.1**, Linux x86-64 with glibc 2.41. No third-party Python dependency. Dates or current software versions are not used to decide fixture outcomes.

The probe checks equality after each of the 11 baseline events and equality of an indexed current-resource query. It tests both required cases, conditional/benefit separation, identity retention, succession, collective-outcome representation, independent residence/title changes, competing claims, historical reconstruction, explicit causal ancestry, snapshots and replay, database reopening, and continuation after reloading.

Sixteen malformed-transition variants are tested against all three adapters, with rejection and unchanged-state checks counted separately. They include duplicate IDs, ordering gaps, unsupported schemas, stale reads or writes, missing causes or rule provenance, invalid references/types/roles, invalid intervals, and invalid household evidence. These tests share a validator and therefore do not provide three independent confirmations of domain semantics.

Additional tests bypass Python to exercise SQL foreign keys and restrictive deletion, inject a failure after journal insertion, query SQL historical versions and recursive causal ancestry, and exercise the overlapping/parallel/dissolution branch. Three deliberately inadequate encoding controls demonstrate single-owner, pair-key and membership-hash limitations. All **160 checks** passed.

Final baseline canonical-state SHA-256:

```text
3a69107730b24cab59f9f0507278aaf4ae3c127780f0ce52510cd5603017f1cd
```

This is a content-equality check, not a tamper-proof audit system. The code file hash and all package file hashes are supplied in the delivery manifest.

**EX2 — Isolated indexing and replay-work mechanism probe.** Executed by the same script. Five trials per measurement; reported values are medians. It compares 100 sparse one-hop lookups at each of three sizes, then compares full folding of scalar outcomes with a fixed 100-outcome tail after a checkpoint. Full measurements and SQL query plans appear in the result files.

| Synthetic size | Full scan: 100 queries, ms | Map index: 100 queries, ms | SQLite index: 100 queries, ms | Full scalar replay, ms | Checkpoint + 100 scalar outcomes, ms |
|---:|---:|---:|---:|---:|---:|
| 1,000 | 1.8160 | 0.0122 | 0.1648 | 0.0074 | 0.0009 |
| 10,000 | 17.8274 | 0.0125 | 0.1700 | 0.0703 | 0.0009 |
| 100,000 | 188.4436 | 0.0121 | 0.1805 | 0.7254 | 0.0009 |

Index builds, mutations, full record validation, disk latency, serialization, native graph traversal, and realistic recognition work are excluded. Repeated runs will differ in timing. The results are suitable only for identifying mechanisms worth preserving in a more representative experiment.

## 9. Unresolved questions and assumptions

### Questions that affect the next information-model iteration

| Open question | Why it matters | What Task 2 can preserve without deciding it |
|---|---|---|
| Is current state or the complete event history authoritative? | Determines recovery, rebuild and compatibility obligations | Explicit events, snapshots, revisions, and replaceable projections |
| What continues the identity of a claim after reassignment? | Distinguishes revision from successor-object semantics | Stable claim IDs, historical participants and explicit lineage |
| Which claim states are asserted, recognized, conditional, effective or actionable? | Determines meaningful queries and consistency rules | Separate fields or typed state records rather than a universal active flag |
| What evidence is sufficient for household recognition and continuity? | Determines whether persistence is causally justified | Versioned lower-level evidence, continuity records and a replaceable recognizer interface |
| Which collective state is authoritative and which is derived? | Affects restart, replay and household influence | Explicit provenance and update ownership for collective state |
| Are retroactive correction and late discovery required? | Determines whether bitemporal querying earns its cost | Distinct domain-time and recording-order concepts |
| Must agent-specific beliefs or disputes be represented? | A system record is not an agent’s knowledge state | Separate assertions, observers and information provenance when introduced |
| What are the mutation concurrency and ordering rules? | Affects stale-read checks and multi-object atomicity | Batch boundaries, revision preconditions and causal references |
| How much history must remain readily queryable? | Drives retention, archival, checkpoints and explanation latency | Stable identities and resolvable historical references across tiers |
| Which workload and size budget are binding? | Necessary for a runtime/store decision | Portable data contracts and representative benchmarks before optimization |

### Assumptions specific to this research package

The fixtures use explicit labels, integer ordering, exact rational title shares, a small relation vocabulary, and a single-threaded execution path. They are deliberately not an accepted ontology, time model, psychology, inheritance system, or recognition algorithm. The branch’s recorded household dissolution does not resolve the fate of remaining collective obligations.

The journal records complete resolved object revisions to make equality and replay transparent. It is therefore more verbose than a possible future domain-event format. The map snapshot loader trusts the supplied journal after basic watermark checks; it is not a hostile-input validator. Schema migration, randomized histories, multi-writer conflicts, native graph performance, full simulation restart, and power-loss recovery were not executed.

**Advisory conclusion:** carry forward explicit identities, typed independently referenceable relations, separated material resources and claims, versioned household support evidence, and recorded transition provenance as the strongest representational safeguards. Use current-state-plus-journal and event-authoritative designs as competing recovery contracts in the next bounded test. Keep the runtime and database choices open until an independently checked model and representative workload discriminate between them.
