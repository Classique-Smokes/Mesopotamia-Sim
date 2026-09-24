# IMP-0003 Candidate-v3 — Independent Conformance Review

**Verdict: BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**

**Recommendation: DO NOT PROMOTE**

**Reviewed candidate:** `imp-0003-slice3-conformance-candidate-v3` @ `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`

**Canonical implementation base:** `77f3d1dd9630401ff6bba0b38283a823e26d2a01`

**Review branch:** `review/imp-0003-conformance-v3-independent-return`

**Review date:** 2026-09-23, America/Sao_Paulo

**Implementation PR:** [#59](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/59)

The canonical commands and all mandated P01–P20 behavioral probes pass. Promotion is nevertheless blocked by false technical-fallback attribution in Household-connected compatible ordinary transactions, and incomplete independent validation of lifecycle/evidence reference identities. No new social or architectural decision is needed for these bounded repairs. This review changes no implementation, test or frozen authority.

## 1. Independence, retrieval and candidate integrity

This was a fresh reviewer context, with no IMP-0003 implementation/repair authorship or prior conformance-review turn history. No subagents or prior reviewer threads were used. The empty task directory was not a repository; the existing repository at `C:/Users/victo/Documents/GitHub/MESOPOTAMIA_SIMULATION` was located and `git fetch origin` run. The canonical main checkout was not modified. A detached `candidate/` worktree was created at the exact SHA, and a separate `review-return/` worktree/branch was subsequently based on that SHA.

Retrieved AGENTS, START_HERE, CURRENT_PHASE, accepted SPEC, ADR-0001–0005, the implementation packet, all three manifests/freeze records and the nine specified verification contracts/families. Inspected every changed production file, both oracle partials, all Household scenario partials and Slice3AcceptanceTests, runtime/test documentation and CI workflow. Reviewed whole implementation changes against the canonical base and both repair-only change sets, including the specifically requested v1→v2 diff. Existing WorldState, inherited structural audit and representative inherited epistemic, closure, fallback, observer, trace and person-level evidence were checked directly.

CURRENT_PHASE necessarily exposed administrative prior BLOCK/CI statuses, but no prior findings were used as an oracle. The dispatch packet itself enumerates prior defect targets. Implementation/repair reports, prior v2 review findings and CI-generated row summaries were first consulted only after reviewer-owned probes and the independent provisional BLOCK were saved at 21:11 America/Sao_Paulo. That later material corroborated the repaired disconnected path and exposed no reason to withdraw the new connected-path finding.

Frozen identity verification:

| Authority | Remote frozen ref commit | Candidate manifest blob |
|---|---|---|
| SFL-V0-S1-ACCEPTANCE-v1 | `55377cc34b8bc3ccbf9cdf5029e9791dae965987` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| SFL-V0-S2-ACCEPTANCE-v1 | `88f876298852553d6afca76e743a5a811ff9f0fd` | `e4872531cf780d51fa1863f2a0b87e2424a71b69` |
| SFL-V0-S3-ACCEPTANCE-v1 | `25160f33c994fd5f3e277ae98f03e55d37c878dd` | `1aae13dc27572361fe99c31ef8aee0444d39364a` |

Remote refs were checked again during review with `git ls-remote`; candidate and authority refs were unchanged. The candidate diff contains no SPEC, accepted ADR, frozen manifest or verification-family edits. Candidate tracked working tree remained clean throughout canonical commands and scratch execution.

## 2. Blocking findings and bounded repairs

### B1 — Compatible ordinary loans still acquire false fallback labels through the Household resolver

**Location:** `src/Mesopotamia.Sim/HouseholdResolution.cs:38` and `:137`–`:173`, especially `:157`; inherited key construction in `ResolutionDependencies.cs:127`–`:172`.

After canonical three-founder formation, let current participants A and B independently lend 2 and 3 grain to C in the same cycle, with ample grain. Both proposals are accepted and both commit. There is no scarce capacity, Household participation/lifecycle/lineage transition, or alternative social winner. Swap the two proposal IDs, reverse input enumeration, and reverse initial-world enumeration: **all eight runs label both loan outcomes TechnicalFallback=true (16/16)**. Reviewer X03 compares normalized people, residence, kinship, debt terms, attitudes, actor-held factual contents/provenance routes/source/cycle/hops, candidate/Household Recognition and Household state: all endpoints are equal. Only allocation identities and exchanged within-cycle ordinals are normalized; normalization is not used to suppress any production fallback.

Root cause: contact with a candidate/Household association routes the component to detached real-commit replay. The world part of `HouseholdProjectionKey` passes ordinary relation/event allocations into the older `ProjectionKey`, whose new-relation origin keys assume proposal-bound synthetic origins. Real replay allocates origins by execution order. The key therefore mistakes allocation order for consequential noncommutativity. Its generic factual serialization also retains allocated IDs in ordinary fact payloads. Routing disconnected components back to the old resolver repairs the disconnected reproducer, but leaves the underlying Household-path comparison incomplete.

**Authority/impact:** SPEC §9.2, the determinism/fallback family, S3-090, S3-R06 and inherited S1-081/S1-GLOBAL-FALLBACK require truthful, quarantined technical fallback. False labels make technical symmetry appear where compatible effects have no conflict. This is a diagnostic/provenance defect, not an observed wrong loan balance or Household identity in this reproducer. It is material to the explicitly frozen acceptance contract.

**Repair:** normalize allocated relation, event and evidence references through semantic causal origins throughout the Household projection comparison, while preserving all action-relevant distinctions, or establish another sound bounded comparison. Merely routing all ordinary-looking actions away from Household closure is insufficient: real entry/residence, communication and support/lineage dependencies must remain observable. Add connected compatible-loan permutations alongside disconnected controls and retain genuine capacity, communication, favour/debt and residence/admission fallback positives. No blanket label suppression.

### B2 — The independent checker accepts false lifecycle and Recognition reference identities

**Location:** `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs:64`–`:91`, `:303`–`:341`.

Two detached public snapshots reach `HouseholdOracle.Verify` successfully and are incorrectly accepted:

1. **X04, lifecycle:** produce a real Dissolved H through ordinary exits, then replace only its published `LifecycleEvent` with nonexistent `EventId(888888)` and `LifecycleTime` with `EvidenceOrder(-17,0)`. Keep lifecycle enum, all warrants, history and cycles unchanged. The valid control passes; the false snapshot also passes. The checker reconstructs participant count and compares the enum, but never binds the Household lifecycle event/time to its real stable-closure cause. `LifecycleTime` is consequential provenance used by production consolidation freshness, not decorative text.
2. **X01, Recognition:** after a real newcomer admission, change the newcomer's retained `KnownFact.Id` in the ParticipationWarrant Recognition basis to nonexistent `EvidenceId(888888)`, retaining its proposition/provenance. The valid control passes; the corrupt witness also passes. `SameEvidence` ignores ID and `VerifyRecognition` never separately validates it. For the reproducer, the original basis already existed at the preceding stable boundary, so its exact actor-held identity is available to the checker. The production `HeldFact` and precommit held-payload checks use this identity.

**Authority/impact:** frozen manifest §4, Cross-Cutting identity/reference and stable-cycle invariants, packet §13, S3-036 and the provenance-bearing participation/continuation/producer obligations. Independent semantic predicate checks and dependency independence are substantial improvements, but do not certify these false references. These are verification defects; no claim is made that normal production generated the corrupted records.

**Repair:** independently bind lifecycle state/event/time to the correct H and stable closure event, including initial Active formation and subsequent Inactive/Active/Dissolved changes. Validate retained Recognition evidence identities against the correct actor's historical held facts; handle same-cycle acquired evidence by actual provenance/event identity rather than weakening all ID checks. Add these exact detached corruptions plus controls for entry/exit continuations. Keep valid old/stale retained Recognition admissible. No production classifier should become the expected-answer oracle.

## 3. Canonical commands

Executed in the unchanged candidate root with **SDK 10.0.401**, C# 14, Microsoft Testing Platform. The default system `dotnet` initially had no SDK; the existing 10.0.401 installation outside the repository was placed first on PATH. No global.json/toolchain change was made.

| Exact command | Local result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | PASS, exit 0 |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | PASS, exit 0, no findings |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | PASS, exit 0; 0 warnings, 0 errors |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | PASS, exit 0; 10 tests passed, 0 failed, 0 skipped |

The ten framework test methods include manifest-driven suites; they are not ten acceptance obligations. Local and downloaded evidence report all 96 S3 REQUIRED rows green and 128+46 inherited IDs green. The independent findings below supersede an inference of conformance from those generated counts.

## 4. Source, fixture, scheduler and scope audit

- **Formation/fixture:** actual support ledger populated only by committed ordinary support; each founder must have their own CandidateRecognition. Initial lower-level subjective fixtures are explicitly marked; no fixture writes H, warrants, final recipient Recognition or capacity. Candidate declarations are inert. Canonical A/B/C formation and exactly-one-founder-missing control are production paths.
- **Participation/continuity:** both directions require named counterpart acceptance and revalidate H, Recognition, current bridge, residence, ties and post-formation support. Explicit warrant/association history carries complete founder turnover. Exit does not delete unrelated typed world relations. Recognition refresh is limited to transition parties; retained remote bridges do not gain new observation entitlement.
- **Resolution:** dependency grouping covers people, current/historical Household associations, candidate cores, explicit H targets and H communication payloads. Same-cycle sole-bearer entry precedes exit by an explicit semantic partial order, independent of IDs. Residence/admission races invalidate only when residence has actually changed before admission. Detached state/counters prevent projection from consuming live IDs. B1 remains in the order-equivalence comparison.
- **Lifecycle/lineage:** stable closure publishes 2+/1/0 lifecycle; Dissolved cannot reactivate. Division/consolidation use explicit exited founder sources, predecessor lifecycle and fresh ordinary support, enumerate ambiguity, and do not inherit causal state. Queries recompute direct/transitive lineage. Repeated predecessor source histories explicitly raise LATER-03 rather than inventing a selector. B2 limits independent published lifecycle-provenance assurance.
- **Provision:** only declared pre-existing valid commitments; no runtime acquisition path, treasury or spend. Reserve and NeedsGrain are computed from personal state, and exits/dissolution terminate commitment without confiscation.
- **Oracle independence:** both oracle partials inspected; no production formation/entry/continuity/lifecycle/Recognition/lineage/capacity classifier is used as expected answer. Detached corruption construction precedes the checker. Reviewer matrix rejects 24 false witnesses across formation, participation, exit-continuation and lineage; X01/X04 identify two additional accepted false witnesses. Dependency independence alone does not establish checker adequacy.
- **S1-084:** conditional trigger **UNFIRED**. `State.cs` and `CrossCuttingScenarios.cs` are unchanged from canonical base. Existing exact WorldState inventory remains eight typed dictionaries plus nextRelation. New Household authority is separately explicit: H/warrant/association/commitment/support dictionaries and four identity counters. Published immutable snapshots and recomputed queries do not hide behavior-affecting caches.
- **Later-slice scope:** no general candidate equivalence, universal membership, head/office, Household initiative, endogenous provision acquisition, collective spending/debit ranking, mediated-marriage authority, save/load, general perception, trust/rumor, strategic/stochastic policy, or general merger engine found. Detached resolver copying is not engine checkpointing. Bounded inert-candidate setup remains a laboratory surface.

## 5. Reviewer-owned scratch evidence

Scratch project and probe sources live outside both candidate and return worktrees in the task's `scratch/` directory. `Review.csproj` references the already-built unchanged production DLL and links unchanged candidate Household scenario/oracle sources. Its assembly name uses the existing acceptance-test friend boundary. The reviewer authored new schedules, mutations and assertions in `Reviewer.cs`, `ReviewerMutations.cs`, and `ReviewerConfirmations.cs`; no production private-field mutation is used. Existing `Form`/`Lab` helpers are reused as disclosed producers, not as proof of the challenged answer. Their concrete fixture writes and real formation/communication schedules were inspected. Oracle controls use the candidate checker as the target under test.

Final instrumented run: **217 explicit reviewer checks attempted: 213 passed, 4 failed; 22 groups: 18 passed and 4 failed.** All 20 numbered mandatory probe topics are covered in the 18 passing groups (P04/P06 and P07/P08 are paired). X02 is the initial B1 reproducer; X03 broadens the same finding, so four failed groups do not mean four distinct blocking findings. Nested assertions inside reused producer/checker calls are additional and are not counted in 217. The scratch runner catches failures to finish all probes; its process exit 0 is not a PASS claim.

| Probe | Setup / independent observation |
|---|---|
| P01 | Two supports/ties/residence, exactly one founder missing support knowledge: no H; final real communication permits H. |
| P02 | Request and Invite each create one warranted newcomer association. |
| P03 | Both directions × proposal-ID swap × input reversal: residence change invalidates stale admission; genuine race fallback disclosed. |
| P04/P06 | Final bearer exits before newcomer entry; old identity rejects entry; later organization receives new H. |
| P05 | Sole-bearer handoff across four ID/input permutations: entry/continuity then exit, same H, no fallback. |
| P07/P08 | Outsider Unknown; two fixture-marked sender-held incomparable reports delivered in both orders make recipient Contested and block both entry directions. |
| P09 | Already-Dissolved predecessor permits ordinary successor formation but no division. |
| P10 | Unrelated H4 current participation excluded from exact consolidation predecessors. |
| P11 | Remove only detached lineage inspection projection, retain authoritative warrant; future exact digest unchanged and original query rebuilds. |
| P12 | Controlled pre-existing commitment, detached personal grain 1/2/3/9 with NeedsGrain false/true; independent capacity arithmetic and exit nonconfiscation. |
| P13 | Repeated observer reads before entry/exit leave exact state/history/evidence/ID digest unchanged. |
| P14 | Order-reversing person IDs and changed candidate ID preserve normalized formation result. |
| P15 | Reflection over action types and H fields finds no later head/office/provision/spending route or treasury. |
| P16 | Custom scenario label, both entry directions plus ordinary gift: correct S3/S2 per-context rule provenance. |
| P17 | Remote current bearer remains stale through entry and another actor's exit, then updates through accepted communication. |
| P18 | 24 detached false witnesses rejected; valid formation/entry/exit-continuation/lineage controls pass. |
| P19 | Eight disconnected compatible-loan ID/input/world permutations commit without fallback. |
| P20 | Capacity, captured-communication/repayment, and favour/debt conflicts each retain fallback in both orders. |
| X01 | Nonexistent retained Recognition EvidenceId accepted by checker — B2. |
| X02/X03 | Connected compatible loans mislabeled; X03 validates equivalent normalized endpoints over all eight permutations — B1. |
| X04 | Nonexistent lifecycle event and negative lifecycle time accepted by checker — B2. |

## 6. CI/artifact identity and prior-claim reconciliation

Independently fetched [run 35935734998](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35935734998), job `107432228359`, artifact metadata, decoded job logs and ZIP bytes. Verified success, exact candidate checkout, SDK 10.0.401, all four canonical commands, build 0 warnings/errors and tests 10/0/0. All job steps completed successfully.

Artifact `10781904631`, `sfl-slice1-slice2-slice3-acceptance-evidence`, is unexpired (expires 2026-12-22). SHA-256 of downloaded bytes independently equals metadata/packet:

`75df9d8d266c5e81fd3a1c87bcfa7a6e955628d29298a1f59b301256234786f8`.

ZIP contains all 16 expected evidence surfaces: Slice-1 results/cases/fixture/oracle/fault files, Slice-2 results/cases/fixture/oracle/regression fixtures, and Slice-3 results/cases/fixtures/producers/repair controls. `slice3-results.json` records exact ImplementationHead, WorkingTreeDirty=false, frozen manifest identity, 96 REQUIRED/11 DEFERRED/2 UNEXERCISED, and exact inherited 128+46 sets. Local generated evidence matches those identities/classifications.

After provisional judgment, inspected repair reports and prior v2 findings for corroboration. Candidate-v2 entry-corruption, custom-rule-label and remote-bearer fixes remain working. Candidate-v3 formation/continuation/lineage controls are substantive: 23+14+13+13 detached corruptions and four positive controls, plus eight disconnected-loan and six positive-fallback controls. Source/assertions and independent P18/P19/P20 were checked, not merely their generated counts. The bounded disconnected routing repair works. Its report does not establish correctness of connected compatible actions; B1 supplies that missing challenge. X01/X04 concern references not covered by the repaired corruption set.

## 7. All 96 REQUIRED Slice-3 rows

Dispositions below are this review's completion assessment, not edits to frozen classification. **Supported** means no defect established in the inspected executable/source evidence for that obligation; it is not a claim of exhaustive proof. **Qualified B2** identifies narrower production success whose broad verification assurance depends on repairing B2. Every row was matched to executable scenario bindings and actual assertions, including grouped mandatory subcases.

| AcceptanceId | Review disposition | Evidence / finding |
|---|---|---|
| S3-001-FORMATION-POSITIVE | Supported | Canonical three-founder A→C, C→B and two real communications produce H at cycle 4; P01 withholds exactly one founder basis. |
| S3-002-FOUNDING-CARDINALITY | Supported | One/two/three founder boundary assertions inspected; no one-person formation path. |
| S3-003-FORMATION-RESIDENCE-ABLATION | Supported | Residence ablation updates both objective fixture and held facts; no alternate move path restores it. |
| S3-004-FORMATION-DURABLE-TIE-ABLATION | Supported | Tie removal blocks connected founding predicate; recorded tie relation references checked independently. |
| S3-005-FORMATION-SUPPORT-COUNT-ORDER | Supported | One support and two same-cycle supports fail; distinct-cycle positive works. |
| S3-006-FORMATION-RECOGNITION-ABLATION | Supported | P01 independently holds two founders Recognized and one unrecognized; no H until final communication. |
| S3-007-CANDIDATE-NONAUTHORITY | Supported | Inert candidate declaration supplies no supports, evidence, resources or authority. |
| S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS | Supported | No constructor/command creates H or warrants; formation is private automatic closure. |
| S3-009-NO-HIDDEN-MEMBERS-AUTHORITY | Supported | Typed warranted associations are current authority; participant lists/counts are derived and not numerical identity. |
| S3-010-FORMATION-WARRANT-PROVENANCE | Supported | Formation checker binds actual candidate, founder-specific evidence IDs, ties, support kind/endpoints/time and stamp; detached controls reject corruptions. |
| S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME | Supported | Earliest retained evidence and reification time remain separate; checker recomputes earliest time. |
| S3-012-FOUNDING-PARTICIPATION-PROVENANCE | Supported | Founder associations and causal start events bind person/H/origin independently. |
| S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H | Supported | Formation creates direct positive H evidence for founders only. |
| S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY | Supported | No head, office or Household-mode initiative appears in action/type census. |
| S3-015-QUALIFYING-SUPPORT-KIND-CENSUS | Supported | Gift/help, loan and favour fulfilment are the closed ordinary support census; other event kinds excluded. |
| S3-020-PARTICIPATION-ENTRY-POSITIVE | Qualified B2 | Both production entry directions and all prerequisite controls work; detached checker does not bind retained KnownFact identity in Recognition. |
| S3-021-PARTICIPATION-RECOGNITION-ABLATION | Supported | Unknown newcomer prevents entry in each direction; explicit positive control succeeds. |
| S3-022-PARTICIPATION-BRIDGE-ABLATION | Supported | Absent/exited named bridge fails; sole bearer is used for Inactive H. |
| S3-023-PARTICIPATION-BILATERAL-ABLATION | Supported | Named counterpart Accept and real proposal/event binding checked; unrelated acceptance rejected. |
| S3-024-PARTICIPATION-RESIDENCE-ABLATION | Supported | Shared-residence ablation and P03 immediate revalidation across eight permutations pass. |
| S3-025-PARTICIPATION-DURABLE-TIE-ABLATION | Supported | Missing newcomer durable tie blocks both directions; fabricated tie references rejected. |
| S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION | Supported | Real qualifying post-formation support required; empty, unrelated, future and wrong-kind evidence rejected. |
| S3-027-PARTICIPATION-END-WARRANT | Supported | Explicit end warrant binds actor, association, proposal and historical event; records retained. |
| S3-028-PARTICIPATION-END-NONERASURE | Supported | Exit changes sustaining association and commitment only; world residence/marriage/kinship/claims/attitudes are not deleted. |
| S3-029-RESIDENCE-NOT-PARTICIPATION | Supported | Residence movement changes residence only; sustaining association and H remain. |
| S3-030-EXIT-SIDE-CONTINUATION | Qualified B2 | Exit continuations have valid production chains and broad checker controls; shared Recognition identity comparison remains incomplete. |
| S3-031-COMPLETE-FOUNDER-TURNOVER | Qualified B2 | Full founder turnover works via explicit entry/exit continuations; assurance inherits B2 Recognition identity limitation. |
| S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT | Supported | P04 breaks final bridge before entry; old-H participation fails despite otherwise qualified newcomer. |
| S3-033-INACTIVE-STATE | Qualified B2 | Count one publishes Inactive correctly; checker does not validate lifecycle event/time provenance. |
| S3-034-INACTIVE-REACTIVATION | Supported | Inactive valid entry returns same H Active; no separate formation required. |
| S3-035-SAME-CYCLE-BRIDGE-HANDOFF | Supported | P05 reverses IDs and input order; entry/continuity precede sole-bearer exit with no fallback. |
| S3-036-DISSOLUTION-STABLE-CLOSURE | Blocked B2 | Production stable dissolution works, but X04 checker accepts nonexistent LifecycleEvent and negative LifecycleTime for Dissolved H. |
| S3-037-DISSOLVED-NO-RESURRECTION | Supported | Dissolved H retained and cannot reactivate; P04/P06 create later valid organization with a distinct identity. |
| S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION | Supported | Recorded support bundle consumed by continuing participation suppresses bounded duplicate formation. |
| S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP | Supported | Distinct later support permits separately warranted overlap in inspected positive control. |
| S3-040-HOUSEHOLD-RECOGNITION-DISTINCT | Supported | Objective H, candidate Recognition, Household Recognition, KnownFact and attitude remain distinct. |
| S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION | Supported | P07 outsiders remain Unknown; earlier leavers are not informed of later same-cycle dissolution. |
| S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE | Supported | Objective conditions alone cannot satisfy Recognition gate; P02/P07/P08 contrast positive and blocked entry. |
| S3-043-H-RECOGNITION-STALE-RETENTION | Supported | P17 remote current bearer retains exact old evidence through unrelated entry and exit. |
| S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE | Supported | Real sender-held communication establishes and refreshes H basis; direct transition parties acquire continuation evidence. |
| S3-045-DISSOLUTION-RECOGNITION-ROUTE | Supported | Terminal exiter learns dissolution; outsiders require accepted communication; earlier leavers remain stale. |
| S3-046-H-RECOGNITION-NO-ID-WINNER | Supported | No ID/arrival resolver selects H Recognition winner; arrival reversal preserves Contested. |
| S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE | Supported | Ordinary gift/attitude changes leave positive H evidence unchanged. |
| S3-048-H-RECOGNITION-CONTESTED | Supported | P08 nondominated positive/negative communicated evidence yields Contested in both arrival orders. |
| S3-049-H-RECOGNITION-CONTESTED-GATE | Supported | P08 Contested suppresses both Request and Invite; ordinary actions remain independent. |
| S3-050-DIVISION-DESCENDANT | Supported | Independent successor formation, explicit exits, non-Dissolved predecessor and fresh post-exit support produce division. |
| S3-051-DIVISION-FRESHNESS-ABLATION | Supported | No post-exit fresh support withholds lineage without blocking otherwise valid formation. |
| S3-052-DIVISION-PREDECESSOR-CONTINUITY | Supported | Continuing predecessor retains identity through ordinary warrants; lineage never selects continuation by branch size/assets. |
| S3-053-CONSOLIDATION-DESCENDANT | Qualified B2 | Consolidation positive and fresh cross-source controls pass; independently validating published predecessor lifecycle stamp remains incomplete. |
| S3-054-CONSOLIDATION-SURVIVOR-ABLATION | Supported | Surviving predecessor prevents consolidation while successor forms normally. |
| S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION | Supported | No fresh post-dissolution cross support prevents consolidation classification. |
| S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT | Supported | All controlled interpretations enumerated; true ambiguity yields no warrant, no first-ID choice. |
| S3-057-LINEAGE-SOURCE-PROVENANCE | Supported | Each founder source binds explicit ended participation, actor and predecessor; corrupt source controls fail. |
| S3-058-LINEAGE-ZERO-OR-ONE | Supported | Zero or one lineage per successor formation; duplicate cause guard and checker census inspected. |
| S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS | Supported | Strict earlier distinct predecessors/source events imply forward acyclic direct edges. |
| S3-060-LINEAGE-NONAUTHORITY | Supported | Lineage writes only provenance and events; P11 inspection removal preserves exact future digest. |
| S3-061-DERIVEDFROM-REBUILD | Supported | DerivedFrom recomputes from warrant predecessor sets; no separate index authority. |
| S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY | Supported | Independent direct-edge reconstruction and three-H chain distinguish direct and transitive ancestry. |
| S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC | Supported | Reversed predecessor formation/enumeration preserves unordered consolidation set. |
| S3-064-LINEAGE-PERSISTENCE-HISTORY | Supported | Lineage retained after dissolution and stamp kind/time/rule/configuration verified against real events. |
| S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION | Supported | P09 already-Dissolved predecessor yields ordinary new H without division classification. |
| S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION | Supported | P10 unrelated H4 current participation does not contaminate exact consolidation predecessor set. |
| S3-070-PROVISION-COMMITMENT-BACKING-STATE | Supported | Explicit pre-existing commitment fixture only; no personal grain ownership transfer or office state. |
| S3-071-PROVISION-EXPOSED-CAPACITY | Supported | P12 independent capacity arithmetic at grain 1/2/3/9 produces 0/0/1/7 when not needy. |
| S3-072-PROVISION-NEEDSGRAIN-ZERO | Supported | P12 same-grain NeedsGrain toggle forces zero at every tested boundary. |
| S3-073-NO-POOLED-HOUSEHOLD-TREASURY | Supported | No pooled treasury field or Household material movement. |
| S3-074-MOBILIZABLE-CAPACITY-DERIVED | Supported | Current commitments/associations and personal state recompute capacity; no retained capacity cache. |
| S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT | Supported | P12 ends contributor commitment; grain changes only by ordinary cycle consumption. |
| S3-076-DISSOLUTION-TERMINATES-COMMITMENTS | Supported | Dissolution terminates remaining commitments; no confiscation; capacity zero. |
| S3-077-NO-SPENDING-AUTHORITY | Supported | P15 and production action census contain no Household spending/initiative path. |
| S3-080-FORMATION-REACTION-CHAIN | Supported | Real causal formation chain with support/communication causes, founder Recognition, warrant, associations and stable publication. |
| S3-081-CAUSE-IDEMPOTENCE | Supported | Formation, transition, lineage and lifecycle guards make duplicate automatic calls no-ops. |
| S3-082-REACTIONINDEX-MONOTONE | Supported | Independent checker verifies unique increasing ReactionIndex and earlier causal references. |
| S3-083-DERIVED-REFRESH-CLOSURE | Supported | Closure reads current authoritative typed partitions; projections recomputed directly. |
| S3-084-NO-MID-CLOSURE-PUBLICATION | Supported | No completed snapshot before closure; SkipClosure faults without new stable publication; no fresh voluntary activation. |
| S3-085-NONSEMANTIC-ITERATION-METAMORPHIC | Supported | Storage/input order metamorphics and fixed-ID P03/P05 permutations pass for representative Household behavior. |
| S3-086-ISOMORPHIC-ID-RENAMING | Supported | P14 order-reversing ID map plus inspected turnover/lineage isomorphisms preserve bounded semantic results. |
| S3-087-LOCALITY | Supported | Disconnected Household continuity/locality controls and P19 ordinary disconnected loans pass; B1 concerns connected compatible actions. |
| S3-088-OBSERVER-NONINTERFERENCE | Supported | P13 exact state/history/evidence/ID digest unchanged by repeated observer queries. |
| S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE | Supported | Structural absence of behavior-affecting caches plus detached query rebuild/inspection controls. |
| S3-090-FALLBACK-QUARANTINE | Blocked B1 | X03 gives 16 false fallback outcome labels in eight compatible connected-loan permutations. |
| S3-091-VERIFIED-PRODUCER-PROVENANCE | Qualified B2 | Producer, fixture, configuration and output identity recorded; claimed producer verification remains limited by B2 checker gaps. |
| S3-092-TRACE-CONFIGURATION-TRUTH | Supported | P16 custom-label Request/Invite traces/events/warrants report S3 while same-run ordinary action reports S2. |
| S3-093-STRUCTURAL-AUTHORITY-NONHIDING | Supported | WorldState exact field inventory and inherited structural test unchanged; explicit Household partition inspected. |
| S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION | Supported | Name perturbations and nonsemantic identity/storage variants preserve representative formation/continuity/lineage results. |
| S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION | Supported | Objective/subjective separation and source-specific acquisition preserved; representative inherited assertions/source inspected. |
| S3-R02-COMMUNICATION-PROVENANCE-STALENESS | Supported | Sender-held communication, provenance, stale retention and conflict rules preserved; no global Household sync found. |
| S3-R03-INITIATIVE-RESPONSE-ACCOUNTING | Supported | One personal initiative, independent target response and no receipt reactivation remain enforced. |
| S3-R04-OBSERVER-NONINTERFERENCE | Supported | Inherited observer tests plus P13 exact digest pass. |
| S3-R05-LOCALITY | Supported | Inherited locality and representative disconnected Household checks pass. |
| S3-R06-FALLBACK-ID-QUARANTINE | Blocked B1 | Inherited suite green, but extended Household resolver violates truthful fallback quarantine for compatible loans. |
| S3-R07-CACHE-DERIVED-NONAUTHORITY | Supported | S1-084/META-05/MUT-24 unchanged; new explicit partition adds no derived cache authority. |
| S3-R08-STABLE-CLOSURE | Supported | Inherited duplicate/skip closure and no same-cycle voluntary reactivation assertions/source inspected. |
| S3-R09-PERSON-LEVEL-SEMANTICS | Supported | Person-level transfer/marriage/residence/claims preserved; no pre-Slice3 Household effect in inherited fixtures. |
| S3-R10-TRACE-CONFIGURATION | Supported | Inherited trace checks and mixed custom-configuration probe pass. |
| S3-R11-FROZEN-AUTHORITY-INTEGRITY | Supported | All immutable manifests/ref identities and exact 128+46 required ID sets verified against local and downloaded evidence. |

Independent row dispositions: 2 Blocked B1; 1 Blocked B2; 6 Qualified B2; 87 Supported.

## 8. Deferred / unexercised audit

All 11 DEFERRED and two UNEXERCISED statuses match frozen authority, local output and downloaded CI evidence. Source/type audit found no hidden later-slice implementation. S3-065 and D03 both preserve the repeated-predecessor-source boundary; these are distinct frozen rows.

| AcceptanceId | Status retained |
|---|---|
| S3-065-NO-REPEATED-PREDECESSOR-SOURCE-GENERALIZATION | DEFERRED |
| S3-D01-CANDIDATE-CONVERGENCE | DEFERRED |
| S3-D02-ACTOR-DEPARTURE | DEFERRED |
| S3-D03-REPEATED-PREDECESSOR-PARTICIPATION | DEFERRED |
| S3-D04-HEAD-OFFICE | DEFERRED |
| S3-D05-HOUSEHOLD-DECISION-MODE | DEFERRED |
| S3-D06-PROVISION-SOLICITATION-RECONSIDERATION | DEFERRED |
| S3-D07-HOUSEHOLD-SPENDING | DEFERRED |
| S3-D08-MEDIATED-MARRIAGE-AUTHORITY | DEFERRED |
| S3-D09-AUTHORITY-DESTROYING-RACE | DEFERRED |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED |
| S3-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED |
| S3-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED |

## 9. Exact inherited regression audit

The exact 128 Slice-1 and 46 Slice-2 REQUIRED IDs were independently extracted from their frozen manifests and compared against local and downloaded S3 inherited reporting, with no missing/extra IDs. All executable inherited evidence ran successfully. S1-GLOBAL-CONFORMANCE is a preserved historical independent Slice-1 completion record, not a new conformance certification; the S1 report deliberately does not self-award the current external gate, while S3's inherited binding checks the accepted historical record.

Representative high-risk source review covered objective/subjective separation, own/direct/communicated provenance, no passive knowledge/history sync, communication initiative and response accounting, stale/conflicting evidence, stable closure and duplicate reactions, person-level residence/no-Household semantics, observer noninterference, structural derived-state nonauthority and truthful rules/configuration. The original ordinary resolver is retained for truly disconnected ordinary components. B1 shows that passing these old fixtures does not preserve fallback truth in every new Household context; inherited S1-081/S1-GLOBAL-FALLBACK and S3-R06 therefore remain blocked for whole-candidate promotion.

The following inventory records the exact inherited IDs and observed local/CI execution status. It is an omission check, not a replacement for the semantic findings above.

| AcceptanceId | Local / CI inherited evidence |
|---|---|
| S1-090-A | PASS / PASS |
| S1-090-B | PASS / PASS |
| S1-090-C | PASS / PASS |
| S1-090-D | PASS / PASS |
| S1-090-E | PASS / PASS |
| S1-091-GIFT | PASS / PASS |
| S1-091-HELP | PASS / PASS |
| S1-091-LOAN-OFFER | PASS / PASS |
| S1-091-LOAN-REQUEST | PASS / PASS |
| S1-091-BFF-POS | PASS / PASS |
| S1-091-RMRH | PASS / PASS |
| S1-091-MEANING-SEPARATION | PASS / PASS |
| S1-092-PARTIAL | PASS / PASS |
| S1-092-AMOUNT-VALIDITY | PASS / PASS |
| S1-092-RESERVE | PASS / PASS |
| S1-092-FULL | PASS / PASS |
| S1-092-DUE | PASS / PASS |
| S1-093-BFF-POS | PASS / PASS |
| S1-093-RECIP-74 | PASS / PASS |
| S1-093-RECIP-75 | PASS / PASS |
| S1-093-RECIP-76 | PASS / PASS |
| S1-093-KIN-GATE | PASS / PASS |
| S1-093-GIFT-CONTROL | PASS / PASS |
| S1-093-BFF-FULL | PASS / PASS |
| S1-093-BFF-RACE | PASS / PASS |
| S1-093-RMRH-FULL | PASS / PASS |
| S1-094-FARM-CALLABLE | PASS / PASS |
| S1-094-REPAY-CALLABLE | PASS / PASS |
| S1-094-PERSONAL-COEXIST | PASS / PASS |
| S1-094-NONCALLABLE-MATRIX | PASS / PASS |
| S1-094-NONPAYLOAD-MATRIX | PASS / PASS |
| S1-094-UNABLE | PASS / PASS |
| S1-094-DECLINE | PASS / PASS |
| S1-094-INVALIDATED | PASS / PASS |
| S1-094-SUCCESS | PASS / PASS |
| S1-094-NESTED-GUARD | PASS / PASS |
| S1-094-RECIP-CANCEL | PASS / PASS |
| S1-095-POS | PASS / PASS |
| S1-095-74 | PASS / PASS |
| S1-095-KIN | PASS / PASS |
| S1-095-LIFETIME | PASS / PASS |
| S1-095-NO-RESIDENCE | PASS / PASS |
| S1-096-MOVE | PASS / PASS |
| S1-096-INVITE | PASS / PASS |
| S1-096-COMPETE | PASS / PASS |
| S1-096-NO-HH | PASS / PASS |
| S1-096-MARRIAGE-CONTROL | PASS / PASS |
| S1-097-EVENTS | PASS / PASS |
| S1-097-SAT | PASS / PASS |
| S1-097-DIRECT-BATCH-POS | PASS / PASS |
| S1-097-DIRECT-BATCH-NEG | PASS / PASS |
| S1-097-DECAY | PASS / PASS |
| S1-098-CORE | PASS / PASS |
| S1-098-CALLFAVOR-INIT | PASS / PASS |
| S1-099-KIN | PASS / PASS |
| S1-099-CORES | PASS / PASS |
| S1-100 | PASS / PASS |
| S1-101 | PASS / PASS |
| S1-102 | PASS / PASS |
| S1-103-GRAIN | PASS / PASS |
| S1-103-RESIDENCE | PASS / PASS |
| S1-105 | PASS / PASS |
| S1-070 | PASS / PASS |
| S1-071 | PASS / PASS |
| S1-073 | PASS / PASS |
| S1-074-IDEMP | PASS / PASS |
| S1-074-DIRECT-BATCH | PASS / PASS |
| S1-080 | PASS / PASS |
| S1-081 | PASS / PASS in inherited fixtures; new-context B1 limitation |
| S1-084 | PASS / PASS |
| S1-085 | PASS / PASS |
| S1-086 | PASS / PASS |
| S1-BND-ATT-STRONGLIKE | PASS / PASS |
| S1-BND-ATT-SAT | PASS / PASS |
| S1-BND-ATT-MIXED | PASS / PASS |
| S1-D4-GRAIN-GIFT-OFFER | PASS / PASS |
| S1-D4-GRAIN-GIFT-REQUEST | PASS / PASS |
| S1-D4-GRAIN-LOAN-OFFER | PASS / PASS |
| S1-D4-GRAIN-LOAN-REQUEST | PASS / PASS |
| S1-D4-GRAIN-REPAY-DIRECT | PASS / PASS |
| S1-D4-GRAIN-BFF-BENEFIT | PASS / PASS |
| S1-D4-GRAIN-RMRH-BENEFIT | PASS / PASS |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | PASS / PASS |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | PASS / PASS |
| S1-BND-REPAY-AMOUNT | PASS / PASS |
| S1-BND-RESERVE | PASS / PASS |
| S1-BND-NEED | PASS / PASS |
| S1-BND-DECAY | PASS / PASS |
| S1-BND-DEBT-DUE | PASS / PASS |
| S1-BND-MARRIAGE-CARD | PASS / PASS |
| S1-BND-FAVOUR-CARD | PASS / PASS |
| S1-BND-FAVOUR-MEANING | PASS / PASS |
| S1-BND-RESIDENCE-CARD | PASS / PASS |
| S1-META-01 | PASS / PASS |
| S1-META-02 | PASS / PASS |
| S1-META-03 | PASS / PASS |
| S1-META-04 | PASS / PASS |
| S1-META-05 | PASS / PASS |
| S1-META-07 | PASS / PASS |
| S1-META-10 | PASS / PASS |
| S1-META-11 | PASS / PASS |
| S1-MUT-04 | PASS / PASS |
| S1-MUT-13A | PASS / PASS |
| S1-MUT-16 | PASS / PASS |
| S1-MUT-17 | PASS / PASS |
| S1-MUT-18 | PASS / PASS |
| S1-MUT-19 | PASS / PASS |
| S1-MUT-20 | PASS / PASS |
| S1-MUT-21 | PASS / PASS |
| S1-MUT-22 | PASS / PASS |
| S1-MUT-23 | PASS / PASS |
| S1-MUT-24 | PASS / PASS |
| S1-MUT-26 | PASS / PASS |
| S1-MUT-29 | PASS / PASS |
| S1-MUT-31 | PASS / PASS |
| S1-MUT-32 | PASS / PASS |
| S1-MUT-33 | PASS / PASS |
| S1-MUT-34 | PASS / PASS |
| S1-MUT-35 | PASS / PASS |
| S1-GLOBAL-FIXTURE | PASS / PASS |
| S1-GLOBAL-KNOWLEDGE | PASS / PASS |
| S1-GLOBAL-ORACLE | PASS / PASS |
| S1-GLOBAL-FALLBACK | PASS / PASS in inherited fixtures; new-context B1 limitation |
| S1-GLOBAL-ITERATION | PASS / PASS |
| S1-GLOBAL-CALLFAVOR-MAP | PASS / PASS |
| S1-GLOBAL-REQUIRED-COVERAGE | PASS / PASS |
| S1-GLOBAL-MANIFEST-INTEGRITY | PASS / PASS |
| S1-GLOBAL-CONFORMANCE | Historical accepted S1 record preserved; not current conformance |
| S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION | PASS / PASS |
| S2-002-KNOWNFACT-RETENTION | PASS / PASS |
| S2-003-KNOWNFACT-PROVENANCE-CENSUS | PASS / PASS |
| S2-004-RECOGNITION-DISTINCT | PASS / PASS |
| S2-005-RECOGNITION-TRISTATE-LIFETIME | PASS / PASS |
| S2-006-NO-PASSIVE-SYNC | PASS / PASS |
| S2-007-NO-HISTORY-OMNISCIENCE | PASS / PASS |
| S2-008-LOCALITY | PASS / PASS |
| S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE | PASS / PASS |
| S2-010-OWN-STATE-KNOWLEDGE | PASS / PASS |
| S2-011-DIRECT-CLAIM-KNOWLEDGE | PASS / PASS |
| S2-012-DIRECT-PARTICIPATION-KNOWLEDGE | PASS / PASS |
| S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION | PASS / PASS |
| S2-020F-FACT-COMMUNICATION-ACTION | PASS / PASS |
| S2-020R-RECOGNITION-COMMUNICATION-ACTION | PASS / PASS |
| S2-021F-COMMUNICATE-HELD-FACT | PASS / PASS |
| S2-021R-COMMUNICATE-HELD-RECOGNITION | PASS / PASS |
| S2-022F-NO-INVENTED-FACT | PASS / PASS |
| S2-022R-NO-INVENTED-RECOGNITION | PASS / PASS |
| S2-023F-FACT-COMMUNICATION-PROVENANCE | PASS / PASS |
| S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE | PASS / PASS |
| S2-024F-FACT-COMMUNICATION-INITIATIVE-COST | PASS / PASS |
| S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST | PASS / PASS |
| S2-025F-FACT-NO-FREE-BROADCAST | PASS / PASS |
| S2-025R-RECOGNITION-NO-FREE-BROADCAST | PASS / PASS |
| S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS / PASS |
| S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS / PASS |
| S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE | PASS / PASS |
| S2-030-STALE-FACT-PERSISTS | PASS / PASS |
| S2-031A-DIRECT-EVIDENCE-PRECEDENCE | PASS / PASS |
| S2-031B-REPORT-EVENT-PRECEDENCE | PASS / PASS |
| S2-032-MESSAGE-ARRIVAL-PERMUTATION | PASS / PASS |
| S2-033-CANDIDATE-RECOGNITION-CONTESTED | PASS / PASS |
| S2-040F-KNOWNFACT-CANDIDATE-GATE | PASS / PASS |
| S2-040R-RECOGNITION-CANDIDATE-GATE | PASS / PASS |
| S2-041-GATES-BEFORE-SCORING | PASS / PASS |
| S2-042-SUBJECTIVE-TRACE | PASS / PASS |
| S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION | PASS / PASS |
| S2-044-OBJECTIVE-REVALIDATION-PRESERVED | PASS / PASS |
| S2-045-PINNED-POLICY-NONCLAIM | PASS / PASS |
| S2-050-EPISTEMIC-READ-NONINTERFERENCE | PASS / PASS |
| S2-051-DETERMINISTIC-REPLAY | PASS / PASS |
| S2-052-NONSEMANTIC-ITERATION-METAMORPHIC | PASS / PASS |
| S2-053-ISOMORPHIC-ID-RENAMING | PASS / PASS |
| S2-054-CACHE-NONAUTHORITY | PASS / PASS |
| S2-055-CONFIGURATION-PROVENANCE | PASS / PASS |

## 10. Minimal reproductions for the next reviewer

These snippets run outside the candidate by linking the unchanged `Household*.cs` acceptance sources into a net10.0 console project named `Mesopotamia.Sim.AcceptanceTests`, referencing the built candidate production DLL and `MSTest.TestFramework` 4.4.1. Supply a minimal `AcceptanceCatalog.Root` pointing at the candidate root. Place the following methods in the same `internal sealed partial class HouseholdScenarios` as the linked sources; invoke from the console. This uses the already-existing acceptance friend boundary. It does not modify the candidate.

```csharp
// B1: normal production, no corrupted input.
internal void ReproduceConnectedLoans()
{
    Lab lab = Form();
    CycleResult result = lab.Step(
        (1, new OfferLoan(P(3), 2)),
        (2, new OfferLoan(P(3), 3)));
    Assert.IsTrue(result.Outcomes.All(o => o.Kind == OutcomeKind.Committed));
    // Fails on candidate-v3: both committed Loan events carry fallback=true.
    Assert.IsFalse(result.Events.Any(e => e.TechnicalFallback));
}

// B2a: construct a detached public snapshot, then challenge checker itself.
internal void ReproduceFalseLifecycleReference()
{
    Lab lab = Form(); HouseholdId h = H(lab);
    SoleBearer(lab, h); Exit(lab, h, 1);
    HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
    HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
    HouseholdSnapshot bad = good with
    {
        Households = good.Households.SetItem(h, good.Households[h] with
        { LifecycleEvent = new(888888), LifecycleTime = new(-17, 0) })
    };
    // Fails: checker returns successfully on the false reference/time.
    Assert.Throws<AssertFailedException>(() =>
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, bad));
}

// B2b: existing actor-held positive basis has a fabricated stable identity.
internal void ReproduceFalseRecognitionIdentity()
{
    Lab lab = Form(); HouseholdId h = H(lab);
    PrepareEntry(lab, h); Entry(lab, h, false);
    HouseholdSnapshot good = lab.Sim.HouseholdSnapshot;
    ParticipationWarrant entry = good.Entries.Values.Single();
    HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, good);
    ParticipationWarrant badEntry = entry with
    {
        Recognition = [entry.Recognition[0] with
        { Evidence = [.. entry.Recognition[0].Evidence.Select(f =>
            f with { Id = new(888888) })] }, entry.Recognition[1]]
    };
    HouseholdSnapshot bad = good with
    { Entries = good.Entries.SetItem(entry.Id, badEntry) };
    // Fails: checker accepts the nonexistent KnownFact identity.
    Assert.Throws<AssertFailedException>(() =>
        HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles, bad));
}
```

Full local probe source/output is retained in this task's scratch directory; it is intentionally not committed to the candidate or report-only return branch. `reviewer-results.json` records all groups; `connected-loans.json` preserves all eight normalized comparisons. Future repair verification should reproduce the failures first, then show their rejection/no-fallback counterparts and rerun the required positive controls.

## 11. Disposition

**DO NOT PROMOTE candidate-v3.** Preserve the exact candidate and frozen authorities. Repair B1's causal normalization and B2's independent reference/provenance validation, retaining all confirmed formation, participation, staleness, handoff, lineage and positive-fallback behavior. Commission a fresh exact-candidate review after bounded repair. **Semantic escalation: not required by any established finding.**

The return branch is based directly on the reviewed SHA and adds only this report. No candidate production/test/authority file is changed. CI success and reported acceptance coverage are verified delivery facts, not grounds to override the independent BLOCK.
