# IMP-0003 — Independent conformance review of candidate-v2

**Verdict: BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**

**Recommendation: DO NOT PROMOTE**

**Review date:** 2026-09-23

**Candidate:** `imp-0003-slice3-conformance-candidate-v2` at `69ae753da2e05450766a9042ac6958fa7aa0b3e7`

**Return branch:** `review/imp-0003-conformance-v2-independent-return`

**Commission:** `tasks/implementation/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V2_PACKET.md`, retrieved from canonical main before checking out the candidate.

## Decision and limits

The canonical commands and the requested 18 reviewer probe families pass. The three specifically targeted candidate-v2 repairs withstand independent checks. Nevertheless, the whole candidate cannot be promoted:

1. **B1 — Independent warrant verification remains materially incomplete outside participation entry.** Thirteen detached corruptions of formation, exit-continuation, and lineage warrants survive `HouseholdOracle.Verify`, including nonexistent supporting event references and lineage “fresh evidence” that is actually the successor formation event.
2. **B2 — Household resolution reports technical fallback for compatible ordinary loans.** A disconnected Household changes two independently feasible, compatible loans from `TechnicalFallback=false` to `true`. Counterfactual projection compares raw allocation identities as consequential state differences. This violates the inherited and Slice-3 fallback quarantine/evidence contract.

B1 establishes a verification defect, not a claim that production currently emits each corrupted warrant. B2 establishes a production diagnostic/resolution-analysis defect; the reproduced loan balances and commitments are correct. Neither finding requires a new social rule. The accepted requirements already determine the bounded repairs.

“Supported” below means the inspected source, assertions, and applicable probes substantiate that row's stated behavior within this review. It does not override the candidate-wide BLOCK, confer complete verification on a reused producer, or prove all possible histories. Generated PASS labels are reported separately from this judgment.

## Identity, immutable authority, and review boundary

| Authority | Frozen remote branch commit | Manifest Git blob at candidate |
|---|---|---|
| `SFL-V0-S1-ACCEPTANCE-v1` / `sfl-v0-slice1-acceptance-v1` | `55377cc34b8bc3ccbf9cdf5029e9791dae965987` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| `SFL-V0-S2-ACCEPTANCE-v1` / `sfl-v0-slice2-acceptance-v1` | `88f876298852553d6afca76e743a5a811ff9f0fd` | `e4872531cf780d51fa1863f2a0b87e2424a71b69` |
| `SFL-V0-S3-ACCEPTANCE-v1` / `sfl-v0-slice3-acceptance-v1` | `25160f33c994fd5f3e277ae98f03e55d37c878dd` | `1aae13dc27572361fe99c31ef8aee0444d39364a` |

`git ls-remote` resolved the candidate branch to the required exact SHA at the start and again after probing. These are remote branches, not local tags; the fresh clone exposes them under `origin/`. Each manifest is unchanged against its frozen branch. The whole-candidate diff from canonical implementation base `77f3d1dd9630401ff6bba0b38283a823e26d2a01` contains no changes to SPEC, accepted ADRs, or frozen verification files. The repair-only diff from `6b9d40e33b94d9094c02fe3d9f026914dd7986ec` was reviewed separately.

Authority retrieved: root guidance/current phase; accepted SPEC-SFL-0001, especially §§5–9; ADR-0001 through ADR-0005; implementation packet; Slice-3 manifest and all three freeze records; inherited manifests; formation, continuity/turnover, lineage, recognition/information, provision, no-self-confirmation, resolution/reaction, determinism/recovery/explainability, and cross-cutting verification families. Later-slice family requirements were applied only through frozen Slice-3 applicability.

All ten changed/new production files were inspected: `Decisions.cs`, `EpistemicExecution.cs`, `EpistemicState.cs`, `Execution.cs`, `HouseholdExecution.cs`, `HouseholdResolution.cs`, `HouseholdRules.cs`, `HouseholdState.cs`, `ResolutionDependencies.cs`, and `Simulation.cs`. Runtime/test documentation and CI changes were read. All new Household scenario partials, the repair scenarios, `HouseholdOracle`, and `Slice3AcceptanceTests` were inspected, with representative inherited scenarios and `InvariantOracle` inspected directly.

## B1 — Warrant checkers accept missing or fabricated mandatory evidence

**Priority:** blocking verification gap.

**Authority:** frozen manifest §4; S3-010, S3-011, S3-030, S3-050 and S3-064; SPEC §§6.3, 7.2, 7.5, 7.7, 9.4; cross-cutting §1 identity/reference and §9 independent-oracle rules.

The checker does not call prohibited production classifiers. That necessary property does not make its assertions sufficient. The formation loop checks the world's connectivity instead of validating the warrant's recorded ties, independently applies a predicate to each supplied recognition record without binding it to the corresponding founder's actual held basis, and checks support kinds in history without matching the warrant's support endpoints/kind to that history. It never resolves the formation stamp's event. The earliest-evidence assertion only tests “earlier than formation.” The exit-continuation loop checks array overlap and `Recognition.All(Recognized)`, allowing an empty array, without resolving its own stamped event or checking its rule version. The lineage loop checks temporal inequalities but does not establish that each fresh-evidence reference is a qualifying ordinary support event.

Exact candidate source locations:

- [Formation checker, lines 42–68](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/69ae753da2e05450766a9042ac6958fa7aa0b3e7/tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs#L42).
- [Continuation reconstruction, lines 79–106](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/69ae753da2e05450766a9042ac6958fa7aa0b3e7/tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs#L79).
- [Lineage checker, lines 108–140](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/69ae753da2e05450766a9042ac6958fa7aa0b3e7/tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs#L108).

Reviewer probes P19–P21 first obtain valid production results and run the existing checker through `Form`/`FormGroup`. Each corruption then changes one detached public snapshot record and invokes the unchanged checker directly. There is no production commit or production validation between mutation and checking. Each of the following returns normally:

| Producer | Detached corruption | Required rejection | Observed |
|---|---|---|---|
| Canonical three-founder formation | `FormationWarrant.Ties = []` | Missing recorded supporting ties | Survived |
| Same | Three copies of founder 1's recognition replace the three distinct founder bases | Missing founder-specific recognition provenance | Survived |
| Same | `Candidate = new(999999)` | Nonexistent candidate reference | Survived |
| Same | `EarliestEvidence = new(-100, 0)` | Invented earliest retained evidence | Survived |
| Same | `Stamp.Event = new(999999)` | Nonexistent formation event | Survived |
| Same | Both real gift support IDs retain their cycles, but each warrant fact becomes endpoints `(P1,P1)` and kind `Loan` | Facts disagree with the cited committed events | Survived |
| Produced H after P2 exits | `ContinuationWarrant.Recognition = []` | No recognizing bridge evidence | Survived |
| Same | `Stamp.Event = new(999999)` | Nonexistent continuation event | Survived |
| Same | `Stamp.RulesVersion = "invented-rule"` | False rule provenance | Survived |
| Same | Recognition array contains `Recognized` H with empty evidence | Unsupported bridge-recognition assertion | Survived |
| Controlled division descendant | `LineageWarrant.FreshEvidence = [successorFormation.Stamp.Event]` | Formation is not ordinary fresh support | Survived |
| Same | `Stamp.Event = new(999999)` | Nonexistent lineage event | Survived |
| Same | `Stamp.RulesVersion = "invented-rule"` | False rule provenance | Survived |

The last three probes use production H1 on founders 1/2/3; founders 1 and 2 exit, H1 remains Inactive, fresh ordinary support is produced, and a new H2 forms on 1/2. Substituting the H2 formation event satisfies the current checker's post-exit inequality despite being categorically wrong as fresh support.

Minimal reproduction pattern using the candidate's existing helper setup, linked into an external scratch assembly:

```csharp
var lab = Form();
var good = lab.Sim.HouseholdSnapshot;
var f = good.Formations.Values.Single();
var bad = f with { Stamp = f.Stamp with { Event = new(999999) } };
HouseholdOracle.Verify(lab.Initial, lab.Sim, lab.Cycles,
    good with { Formations = good.Formations.SetItem(f.Id, bad) });
// Returns normally. The referenced event does not exist.
```

**Bounded repair:** complete independent source/event/time/rule/configuration and actor-basis reconstruction for these three warrant families. Check recorded ties against the actual relations; bind every founder's candidate evidence to the correct actor and candidate; compare support event identity, kind, endpoints and order; derive the actual earliest retained evidence; validate founding association identities and references; resolve continuation transition/previous/stamp events and recognizing bridge evidence; validate lineage freshness as actual qualifying support, source mapping, successor association, event and version provenance. Add isolated detached corruption controls, with valid controls still accepted. Do not weaken frozen rows or use production classifiers as expected answers. Re-run the full suite and freeze a new candidate for independent review.

The repaired participation-entry checker at line 156 onward performs substantially stronger reconstruction and rejects the targeted P17/P18/P19-style corruptions. B1 does not reopen those repairs as failed; it identifies remaining whole-candidate coverage gaps.

## B2 — Compatible ordinary loans acquire false technical-fallback labels

**Priority:** blocking inherited/Slice-3 conformance defect.

**Authority:** S3-090 and S3-R06; inherited S1-081/S1-GLOBAL-FALLBACK; SPEC §9.2; VS-SFL-081's residual technical-symmetry contract.

P22 isolates a household on persons 1/2/3 at dwelling 1, with no ties to persons 4/5/6 at dwelling 2. The latter start with 100 grain each. The Household forms through the canonical four-cycle schedule. A paired run uses the same lower-level setup without a candidate and advances four empty cycles. The next cycle submits:

```csharp
new Proposal(new(100), P(4), new OfferLoan(P(6), 1));
new Proposal(new(101), P(5), new OfferLoan(P(6), 1));
```

Both proposals are accepted and commit in either order. Each donor has ample grain; the creditor/debtor pairs differ; no scarce slot, support recurrence, candidate, participation, or Household state depends on either loan. The run is repeated with the two proposal IDs exchanged. People/grain/need, debts by creditor/debtor/terms, and directed attitudes normalize identically in all four variants.

| Disconnected Household exists | Proposal IDs exchanged | Both loans commit | Fallback flags on loan outcomes |
|---|---|---|---|
| No | No | Yes | `false, false` |
| No | Yes | Yes | `false, false` |
| Yes | No | Yes | `true, true` |
| Yes | Yes | Yes | `true, true` |

This is not evidence of a balance error or an undisclosed winning proposal. It is a false declaration that compatible effects required consequential fallback. There is no competition to resolve. The detached runs differ in allocated event/relation provenance IDs, which should be matched by their causal proposal origins rather than treated as independent social state differences.

The source explains the result:

- [`ResolutionDependencies.cs:13`](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/69ae753da2e05450766a9042ac6958fa7aa0b3e7/src/Mesopotamia.Sim/ResolutionDependencies.cs#L13) routes all accepted components through the Household resolver whenever any Household exists, including disconnected ordinary-action components.
- [`HouseholdResolution.cs:149`](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/69ae753da2e05450766a9042ac6958fa7aa0b3e7/src/Mesopotamia.Sim/HouseholdResolution.cs#L149) passes actual detached state to inherited `ProjectionKey`; that function retains newly allocated debt origins in its keys/values (`ResolutionDependencies.cs:138–147`). The inherited resolver previously supplied synthetic proposal-bound origins.
- `HouseholdResolution.cs:139–144` normalizes only selected fact types; the default serialization of `DebtFact` also retains embedded allocation-dependent relation/event IDs. Consequently the adjacent-swap comparison sees unequal strings and marks both proposals.

**Bounded repair:** normalize all allocation-dependent relation and epistemic provenance identities in Household counterfactual state through their causal origins, or preserve the inherited resolver for components proved independent of Household effects. Do not simply suppress all flags when outcomes match: some equal-outcome orders can still change genuine authoritative evidence/state. Add the disconnected-Household compatible-loan regression and retain positive controls for genuine residence/admission, communication, capacity, and favour conflicts. Preserve narrow bridge-handoff semantic priority and live-ID isolation.

## Canonical execution and CI/artifact verification

Commands ran at the unchanged candidate root, before adding this report, using .NET SDK **10.0.401**. The ordinary PATH's `dotnet` had no SDK; the already-installed SDK at `C:/Users/victo/Documents/Codex/2026-09-22/github-plugin-github-openai-curated-remote/work/dotnet-sdk-10.0.401` was prepended to the process PATH. No repository/toolchain configuration changed.

| Exact command | Observed result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | Exit 0; all three projects restored |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | Exit 0; no reported findings |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | Exit 0; zero warnings, zero errors |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | Exit 0; 10 top-level tests passed, 0 failed, 0 skipped; approximately 30 seconds |

The top-level test count is not the count of semantic acceptance rows. The runner executes 28 Slice-3 scenario groups and records 82 fixture/world audits. Local output identifies the exact candidate SHA and clean working tree. All local/CI Slice-3 row classifications/states and all inherited ID/states matched.

Independently retrieved through the GitHub connector after provisional judgment:

- [Run 35926743064](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35926743064): completed/success, associated with exact candidate SHA.
- Verify job `107403530462`: checkout, SDK, restore, static quality, build, test and artifact steps completed successfully. The workflow invokes the same four canonical commands and explicitly checks out the PR head.
- Artifact `10778873189`, `sfl-slice1-slice2-slice3-acceptance-evidence`: unexpired; workflow metadata reports `head_sha=69ae753da2e05450766a9042ac6958fa7aa0b3e7`.
- Downloaded ZIP SHA-256 independently recomputed as `41b340e7f850b00c378a6fa585ad16776e73fe11fe26d0643a2c6de22b7faa9b`, matching the packet and GitHub metadata.
- Downloaded `slice3-results.json`: `ImplementationHead=69ae753da2e05450766a9042ac6958fa7aa0b3e7`, `WorkingTreeDirty=false`; exact 96 REQUIRED/11 DEFERRED/2 UNEXERCISED census; 128+46 inherited REQUIRED entries.
- Artifact contains `slice1-results.json`, inherited cases/fixture/oracle/fault outputs, all Slice-2 outputs, and `slice3-results.json`, `slice3-cases.json`, `slice3-fixtures.json`, `slice3-producers.json`.

These delivery checks pass. `CandidateReady=true` and 96 generated PASS rows are coder evidence; B1 and B2 prevent independent acceptance.

## Fixtures, producers, oracle independence, and scope

`World`/`WithKnowledge` seed declared people, grain, residence, kinship and lower-level evidence. `CanonicalFormation` runs actual Gift/Gift/Communication/Communication cycles. Founding recognition and warrants are production outputs. Participation helpers communicate H evidence and commit ordinary support before submitting Request/Invite. Lineage helpers produce predecessor and successor formations and explicit exits through the kernel; they do not fixture-write lineage results.

Two narrowly scoped additional fixture seams were inspected: `SupplyProvisionFixture` supplies explicitly marked pre-existing valid backing under manifest §3.1; `SupplyHouseholdEvidenceFixture` supplies held contrary evidence to a sender where acquisition is not under test. The recipient receives it through actual communication. Neither is a runtime headless commitment-acquisition action. No fixture-written final Household, warrants, lifecycle, derived capacity, or recipient recognition was found in the canonical witnesses. Scratch corruption probes alter detached checker inputs only.

`Form` and `FormGroup` record producer, pass, lower-level fixture audit, configuration and output digest. However, their verified-producer claim depends on the incomplete warrant checker. Metadata and production acquisition are present; **full assurance of reused producers remains qualified by B1**. The count/hash record is not an independent proof that all referenced evidence is valid.

The participation checker independently binds actual proposal/acceptance/commit, named counterpart, precommit residence/ties, support kind/endpoints/order, actual actor-held recognition and communication hops, output association and continuation. Both requested directions were challenged. It uses no production participation/continuity/recognition classifier as its answer. Existing candidate corruptions include real future support; scratch P18 independently adds 28 detached rejections across both directions. The broader oracle's dependency blacklist passes but cannot detect omitted assertions demonstrated in B1.

Household IDs and typed associations are explicit authority. `Participants` is a query over provenance-bearing associations, not a universal primitive Members set. Lifecycle uses counts only at stable closure; identity originates in formation and transmission warrants. Committed ordinary support resides in the explicit Household partition; actor reports and observer history do not recreate it as current authority. Lineage access is limited to derivation/inspection and counterfactual comparison, not agency/resource/recognition transfer. Read-only lineage projection removal does not remove the authoritative warrant.

**S1-084 trigger: UNFIRED.** `State.cs` (containing `WorldState`) and `CrossCuttingScenarios.cs` (containing `NoDerivedAuthorityStructuralAudit`) are unchanged from the canonical implementation base. The original exact field inventory remains eight typed dictionaries plus `nextRelation`. The separate Household partition exposes nine explicit authoritative dictionaries and four counters; new structural assertions preserve snapshot isolation. No behavior-affecting derived cache was found.

No head appointment/succession, head Recognition, Household decision mode/initiative, endogenous provision solicitation/reconsideration, spending/debit execution, mediated-marriage authority, checkpoint/restore, generic nonparticipant observation, trust/rumor, generalized fission/merger, candidate-equivalence algorithm, or stochastic/strategic policy was introduced. Repeated predecessor exit histories trigger the explicit LATER-03 exception rather than a new source-selection algorithm. Deferred/unexercised scope is preserved.

## Scheduler, closure, and inherited regression audit

Affected-person/Household/candidate grouping includes newcomers and communication payload H references. Entry through the named exiting bridge is explicitly ordered before that exit. Scratch handoffs with reversed IDs preserve one identity, end Inactive with the newcomer, and do not report fallback. Residence/admission races invalidate stale entries for fixed IDs regardless of input-array enumeration. The existing adverse-order case also changes IDs and obtains the expected alternate order with disclosed fallback.

Detached replay copies world, epistemic and Household partitions and their counters. It invokes actual commit/closure methods without allocating from live state. Read/observer probes compare full digests including history and IDs. Closure publication and cause-idempotence scenarios exercise duplicate causes and skipped closure. These parts are supported; B2 identifies a distinct normalization failure in deciding whether technical fallback occurred.

All **128 Slice-1** and **46 Slice-2** expected REQUIRED IDs were independently extracted from the frozen manifests and compared by set to the downloaded/local inherited inventories: no missing or extra IDs. Slice-2 parsing includes `S2-045`'s `REQUIRED structural/report` classification. The runner reexecutes the inherited suites, rather than depending on test order. Inspection of inherited code included communication provenance/initiative/no-reactivation, stale residence, direct-vs-report precedence, RG-01 contested evidence, observer replay, configuration traces, WorldState structural audit, and lower-level invariant replay.

The raw Slice-1 output properly leaves `S1-GLOBAL-CONFORMANCE` as `AWAITING INDEPENDENT REVIEW`. Slice-3's inherited table maps it to the prior accepted Slice-1 completion record. This preserves historical Slice-1 conformance; it cannot certify the new candidate. Thus “128 inherited PASS bindings” does not mean 128 newly executed standalone tests or a new independent PASS.

| Inherited surface | Independent assessment |
|---|---|
| Objective/subjective separation, no history omniscience, no passive synchronization | Source and inherited assertions retained; new remote-bearer probe passes |
| Communication provenance, initiative cost, no broadcast or same-cycle voluntary reactivation | Inherited assertions inspected and rerun; H communication routes use the same retained provenance rules |
| Residence distinct from participation/marriage, lower-level relation non-erasure | Source and direct scenarios support preservation; no residence-derived association mutation |
| No hidden pre-Slice3 Household behavior | Inert candidates cannot form H without real committed support and founder evidence; old lower-level fixtures continue to pass |
| Stable closure, observer noninterference, derived nonauthority | Existing checks retained; scratch full-digest observer pair and projection discard checks pass |
| Trace/configuration truth | Arbitrary-label mixed S2/S3 probe passes; no label-driven rule selection remains |
| Frozen authority integrity | Exact blobs, unchanged classifications, exact expected ID sets verified |
| Fallback quarantine | **BLOCK B2** in the new resolver; green inherited scenarios do not cover this disconnected-Household extension |

## Reviewer-owned scratch probes and reproducibility

Scratch work is outside the candidate at `C:/Users/victo/AppData/Local/Temp/imp0003-v2-independent-probes/`. `Probe.csproj` targets net10.0, references the unchanged candidate Release production DLL, links the unchanged candidate `Household*.cs` test helpers/oracle, and uses MSTest.TestFramework 4.4.1. Its assembly name uses the existing test friend boundary. A minimal `AcceptanceCatalog.Root` stub points to the candidate; no candidate source or test was edited. `Reviewer.cs` adds independently authored partial-class probe schedules/assertions. Existing fixture builders are reused transparently; no claim of wholly independent fixture implementation is made.

Run with SDK 10.0.401:

```text
dotnet run --project C:/Users/victo/AppData/Local/Temp/imp0003-v2-independent-probes/Probe.csproj --configuration Release
```

| Probe | Setup/assertion | Result |
|---|---|---|
| P01 | Two real distinct-cycle supports; communicate to only one of the two initially uninformed founders; exactly one founder still lacks recognition | No H; pass |
| P02 | Independently produced H and prepared newcomer for Request and Invite | Both commit; pass |
| P03 | Move newcomer to dwelling 2 before entry, fixed proposal IDs, reverse input array | Entry invalidated in both runs; pass |
| P04 | Prepare newcomer, remove all continuity bearers, request old H | Entry blocked; pass |
| P05 | Sole-bearer exit plus entry; exchange entry/exit IDs | Entry/continuation before exit; same Inactive H; pass |
| P06 | Dissolve H; later ordinary two-person organization | New identity; old H stays Dissolved; pass |
| P07 | Outsider receives no accepted H evidence | Remains Unknown; pass |
| P08 | Sender-held incomparable contrary H report delivered to prepared newcomer | Contested; entry Unable; pass |
| P09 | Predecessor fully dissolves before valid successor formation | Formation succeeds; no division lineage; pass |
| P10 | Additional unrelated current H4 participation | Consolidation predecessors exactly H1/H2; pass |
| P11 | Remove only detached lineage projection, reacquire query, continue paired runs | Lineage query changes only in detached view; future exact digest equal; pass |
| P12 | Grain 1/2/3/8, each with false/true NeedsGrain | Reserve arithmetic and forced zero; pass |
| P13 | Repeated inspection before admission and another cycle | Exact digest including IDs/history unchanged; pass |
| P14 | Consistent person/candidate ID offset on three-founder schedule | Isomorphic formation and time; pass |
| P15 | Reflect public action/type vocabulary | No head/office/provision-spend or Household decision context; pass |
| P16 | Request/Invite plus ordinary Gift in custom configuration | S3 Household response/events/warrant; S2 ordinary response; truthful configuration; pass |
| P17 | Move retained bearer away, admit via other bridge, then communicate | Prior basis retained until communication; pass |
| P18 | 14 detached corruptions for each direction, including empty/duplicated/fabricated recognition, nonexistent/future/wrong/unrelated support, unrelated acceptance, wrong actor/proposal/residence/tie/association | 28 rejected by checker; pass |
| P19 | Six detached FormationWarrant corruptions | **Six survivors — B1** |
| P20 | Four detached exit-side ContinuationWarrant corruptions | **Four survivors — B1** |
| P21 | Three detached LineageWarrant corruptions | **Three survivors — B1** |
| P22 | Compatible loans with/without disconnected H and exchanged proposal IDs | **False fallback labels with H — B2** |

Final scratch output: **22 probe groups; 104 explicit checks/observations = 91 assertions plus 13 detached-mutant observations**. Existing helper/oracle assertions are additional and not included in that count. Survey groups P19–P22 completing successfully means the survey executed; it does **not** mean candidate conformance passed. The thirteen mutants survived; no crash or timeout was credited as detection.

Scratch source SHA-256: `5103c307c076f2ad980aa224231d2c9490277c72637a99b4f07fbbdd9f3c0d141`. Final output SHA-256: `a8b3cf8aa2d2c67b2a06efe4be69279eaf0ca80cb1d0181d01673857c42d6689`. These identify local supporting material; the defect recipes and actual observations above remain in this sole tracked return. Scratch files and downloaded CI ZIP were not added to the candidate.

## Independence and contamination disclosure

This is a fresh reviewer context, not the implementation author, repair author, or candidate-v1 reviewer context. The workspace was initially empty. The preceding local review directory was inspected only to find the repository remote and root `AGENTS.md`; its review report, scratch probes and findings were not read. A fresh clone was made into this workspace.

The dispatch packet and required `CURRENT_PHASE.md` exposed the candidate-v1 BLOCK status and named repair targets; that unavoidable task context is disclosed. Before fixing the provisional BLOCK from source and P19, no implementation report, repair report, PR narrative, prior conformance report, or reconciliation was used as semantic proof. Afterward the implementation/repair report and CI metadata/output were consulted for corroboration. The candidate-v1 review and reconciliation and PR #56 prose were not needed/read. No sub-agent was used.

Repair-report corroboration: the participation checker changes, semantic-rule/configuration separation, and causal-party continuation update pass the corresponding independent probes. The earlier residence/admission grouping and terminal-exit dissolution update are visible and exercised. The wider implementation-report claim that the oracle verifies warrant provenance is incomplete in the specific ways reproduced by B1.

**Semantic escalation:** none established. B1 is incomplete independent verification of already-defined warrant semantics. B2 is incorrect counterfactual identity normalization/reporting under the existing fallback contract. Repair within current accepted semantics, preserve the frozen manifests and S1-084 evidence, freeze a new exact candidate, and obtain a fresh whole-candidate review before promotion.

## Individual Slice-3 REQUIRED audit

The following inventory contains every one of the **96** frozen REQUIRED IDs exactly once. All have generated execution bindings and green local/CI results. The independent assessment records the stronger result from source review and probes. **Qualified** identifies supported production behavior with incomplete supporting warrant/producer assurance under B1; it is not a row-level acceptance award. **Block** identifies a directly demonstrated requirement/evidence failure. Case binding names are preserved in the verified artifact; this table states what was actually assessed instead of copying its PASS column.

| AcceptanceId | Independent assessment | Evidence / limitation |
|---|---|---|
| S3-001-FORMATION-POSITIVE | Qualified | Canonical Gift/Gift/Inform/Inform production chain forms three-founder H at cycle 4; producer warrant assurance limited by B1. |
| S3-002-FOUNDING-CARDINALITY | Supported | One founder fails; two and three founders qualify with the remaining predicate. |
| S3-003-FORMATION-RESIDENCE-ABLATION | Supported | Residence ablation changes objective and held setup; production shared-residence gate fails. |
| S3-004-FORMATION-DURABLE-TIE-ABLATION | Supported | Durable-tie ablation removes kinship and does not recreate strong mutual ties in its short horizon. |
| S3-005-FORMATION-SUPPORT-COUNT-ORDER | Supported | One support and two same-cycle supports fail; distinct cycles succeed. |
| S3-006-FORMATION-RECOGNITION-ABLATION | Supported | Production checks every founder; P01 independently isolates exactly one missing founder basis. |
| S3-007-CANDIDATE-NONAUTHORITY | Supported | Candidate without support/evidence cannot create H; identifier is only an inert referent. |
| S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS | Supported | No initial Household/warrant field or privileged FormHousehold action exists. |
| S3-009-NO-HIDDEN-MEMBERS-AUTHORITY | Supported | Typed warrant-backed associations are authority; current-participant query is derived. |
| S3-010-FORMATION-WARRANT-PROVENANCE | Block B1 | P19 accepts missing ties, duplicated founder recognition, false candidate/event and forged support facts. |
| S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME | Block B1 | Separate production times exist, but independent reconstruction accepts invented earliest evidence at cycle -100. |
| S3-012-FOUNDING-PARTICIPATION-PROVENANCE | Qualified | Production binds each founder association to formation; checker principally counts associations rather than fully binding identities. |
| S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H | Supported | Formation event supplies direct H recognition to founders; canonical assertions and source inspected. |
| S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY | Supported | No occupied head or Household decision context/action capability is created. |
| S3-015-QUALIFYING-SUPPORT-KIND-CENSUS | Supported | Closed Gift/Help/Loan/FavourFulfilment census exercised; ordinary classifier excludes other meanings. |
| S3-020-PARTICIPATION-ENTRY-POSITIVE | Supported | Both directions and each prerequisite ablation inspected; P02/P18 confirm entry and independent rejection controls. |
| S3-021-PARTICIPATION-RECOGNITION-ABLATION | Supported | Missing newcomer recognition fails both directions; empty/fabricated detached evidence rejected. |
| S3-022-PARTICIPATION-BRIDGE-ABLATION | Supported | Exited bridge is unavailable; P04 cannot admit after terminal bridge loss. |
| S3-023-PARTICIPATION-BILATERAL-ABLATION | Supported | Named counterpart must accept; unrelated earlier Accept rejected by strengthened checker. |
| S3-024-PARTICIPATION-RESIDENCE-ABLATION | Supported | Missing residence fails; fixed-ID input reversal preserves move-before-entry invalidation in P03. |
| S3-025-PARTICIPATION-DURABLE-TIE-ABLATION | Supported | No newcomer durable tie fails both directions; detached false tie rejected. |
| S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION | Supported | Entry requires real post-formation support; unrelated/future/wrong support rejected. |
| S3-027-PARTICIPATION-END-WARRANT | Qualified | Production emits explicit end warrant and retains association history; broad warrant-event assurance remains under B1. |
| S3-028-PARTICIPATION-END-NONERASURE | Supported | Exit writes association end/commitment termination only; source preserves residence, marriage, kinship, claims and attitudes. |
| S3-029-RESIDENCE-NOT-PARTICIPATION | Supported | Residence transition does not add/end sustaining associations or change identity. |
| S3-030-EXIT-SIDE-CONTINUATION | Block B1 | P20 accepts empty bridge evidence and nonexistent exit-continuation event. |
| S3-031-COMPLETE-FOUNDER-TURNOVER | Qualified | Full founder replacement preserves H through explicit transition chain; exit-side checker evidence incomplete. |
| S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT | Supported | Broken bridge blocks old-H entry; P04/P06 and canonical negative control preserve no-resurrection boundary. |
| S3-033-INACTIVE-STATE | Supported | One bearer yields stable Inactive state without new identity or collective initiative. |
| S3-034-INACTIVE-REACTIVATION | Supported | Sole bearer admits valid newcomer to same H; no duplicate in canonical reactivation. |
| S3-035-SAME-CYCLE-BRIDGE-HANDOFF | Supported | P05 reverses entry/exit IDs; semantic handoff precedes exit without fallback. |
| S3-036-DISSOLUTION-STABLE-CLOSURE | Supported | Zero participants publishes Dissolved only after compatible transitions and closure. |
| S3-037-DISSOLVED-NO-RESURRECTION | Supported | P06 retains Dissolved H and forms later valid organization under new identity. |
| S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION | Supported | Consumed causal-support bundle suppresses duplicate formation in bounded canonical case; guard source inspected. |
| S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP | Supported | Additional distinct support allows separately warranted overlapping formation. |
| S3-040-HOUSEHOLD-RECOGNITION-DISTINCT | Supported | Objective Household, KnownFact, CandidateRecognition and HouseholdRecognition remain distinct records/queries. |
| S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION | Supported | Outsider P07 remains Unknown; earlier same-cycle leavers do not receive terminal dissolution evidence. |
| S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE | Supported | Otherwise valid newcomer with Unknown H cannot enter; Recognized positive control commits. |
| S3-043-H-RECOGNITION-STALE-RETENTION | Supported | P17 remote retained bearer keeps prior basis despite entry elsewhere. |
| S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE | Supported | Real held-H communication establishes recognition; subsequent communication adds newer continuation evidence. |
| S3-045-DISSOLUTION-RECOGNITION-ROUTE | Supported | Terminal exiter obtains decisive dissolution fact; outsider updates through actual communication only. |
| S3-046-H-RECOGNITION-NO-ID-WINNER | Supported | Evidence precedence does not compare H/person IDs; arrival permutation preserves conflict result. |
| S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE | Supported | Ordinary attitude-producing interaction does not erase held H evidence. |
| S3-048-H-RECOGNITION-CONTESTED | Supported | Incomparable contrary H evidence yields Contested; P08 confirms. |
| S3-049-H-RECOGNITION-CONTESTED-GATE | Supported | Contested fails participation gate while ordinary person action remains available. |
| S3-050-DIVISION-DESCENDANT | Block B1 | Production positive division works, but P21 checker accepts successor formation event as fresh support. |
| S3-051-DIVISION-FRESHNESS-ABLATION | Supported | No post-exit fresh support withholds division while ordinary formation succeeds. |
| S3-052-DIVISION-PREDECESSOR-CONTINUITY | Qualified | Predecessor identity persists through production continuity, whose exit-side evidence check is incomplete. |
| S3-053-CONSOLIDATION-DESCENDANT | Qualified | Two dissolved predecessors and fresh cross-source support produce consolidation; shared lineage checker incomplete under B1. |
| S3-054-CONSOLIDATION-SURVIVOR-ABLATION | Supported | One surviving predecessor suppresses consolidation without preventing ordinary successor formation. |
| S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION | Supported | Stale pre-dissolution cross support suppresses consolidation. |
| S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT | Supported | Enumeration of complete interpretations withholds ambiguous lineage; no first-ID selection. |
| S3-057-LINEAGE-SOURCE-PROVENANCE | Qualified | Explicit source exit/person/predecessor references checked; full lineage event provenance is incomplete. |
| S3-058-LINEAGE-ZERO-OR-ONE | Supported | Production allows zero/one warrant per formation; duplicate-cause guards inspected. |
| S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS | Supported | Earlier distinct predecessor formation and source-time order establish forward acyclic direct edges. |
| S3-060-LINEAGE-NONAUTHORITY | Supported | No lineage-driven resource, claim, role, residence, recognition or agency transfer found. |
| S3-061-DERIVEDFROM-REBUILD | Supported | DerivedFrom recomputes only from stored authoritative LineageWarrant; P11 detached projection check. |
| S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY | Supported | Direct H3-from-H2 differs from transitive H1 ancestry; independent edge reconstruction present. |
| S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC | Supported | Reversed predecessor formation/enumeration yields equivalent unordered predecessor set. |
| S3-064-LINEAGE-PERSISTENCE-HISTORY | Block B1 | Warrants persist, but P21 accepts false lineage rule version/nonexistent stamp event. |
| S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION | Supported | P09 valid successor from already-Dissolved predecessor has no division warrant. |
| S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION | Supported | P10 unrelated H4 current participation excluded from consolidation predecessor set. |
| S3-070-PROVISION-COMMITMENT-BACKING-STATE | Supported | Only declared pre-existing valid fixture commitments; no grain transfer or head state. |
| S3-071-PROVISION-EXPOSED-CAPACITY | Supported | P12 independently calculates grain 1/2/3/8 reserve results. |
| S3-072-PROVISION-NEEDSGRAIN-ZERO | Supported | Same-grain false/true NeedsGrain controls force zero capacity. |
| S3-073-NO-POOLED-HOUSEHOLD-TREASURY | Supported | No Household grain/treasury field; no pooling event or material effect. |
| S3-074-MOBILIZABLE-CAPACITY-DERIVED | Supported | Capacity recomputes from live valid associations/commitments/current people; no cached capacity authority. |
| S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT | Supported | Exit terminates actor backing without confiscation; consumption separately accounted. |
| S3-076-DISSOLUTION-TERMINATES-COMMITMENTS | Supported | Dissolution terminates remaining backing and capacity becomes zero. |
| S3-077-NO-SPENDING-AUTHORITY | Supported | P15 action census and source contain no Household spending/initiative path. |
| S3-080-FORMATION-REACTION-CHAIN | Qualified | Real formation reaction chain and causal events exist; complete recorded-warrant linkage assurance limited by B1. |
| S3-081-CAUSE-IDEMPOTENCE | Supported | Transition/formation/lineage guards make duplicate cause challenges idempotent. |
| S3-082-REACTIONINDEX-MONOTONE | Supported | History checker verifies unique increasing reaction indices and preceding causal references. |
| S3-083-DERIVED-REFRESH-CLOSURE | Supported | Closure reads current authoritative partitions and recomputes projections. |
| S3-084-NO-MID-CLOSURE-PUBLICATION | Supported | Stable snapshots publish only after closure; skipped closure fails without publishing completion. |
| S3-085-NONSEMANTIC-ITERATION-METAMORPHIC | Supported | Storage/inputs and representative independent histories permute; fixed-ID P03 confirms input-order control. |
| S3-086-ISOMORPHIC-ID-RENAMING | Supported | P14 and existing order-reversing turnover/lineage renaming preserve normalized results outside declared technical conflicts. |
| S3-087-LOCALITY | Supported | Representative disconnected-household continuity outcome remains equal; B2 separately limits diagnostic locality. |
| S3-088-OBSERVER-NONINTERFERENCE | Supported | P13 exact digest includes IDs/history and remains equal after repeated inspection. |
| S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE | Supported | No behavior-affecting Household derived cache; P11 discard/requery leaves exact future digest unchanged. |
| S3-090-FALLBACK-QUARANTINE | Block B2 | Disconnected H causes false fallback labels for compatible loans. |
| S3-091-VERIFIED-PRODUCER-PROVENANCE | Qualified | Producer/configuration/fixture/output records exist; producer PASS assurance relies on incomplete B1 checker. |
| S3-092-TRACE-CONFIGURATION-TRUTH | Supported | P16 custom-label Request/Invite plus ordinary action traces have correct S3/S2 rule and configuration provenance. |
| S3-093-STRUCTURAL-AUTHORITY-NONHIDING | Supported | WorldState inventory and inherited audit unchanged; new explicit Household partition structurally inspected. |
| S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION | Supported | Names and irrelevant attributes perturbed in formation/continuity/lineage scenarios without semantic change. |
| S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION | Supported | Retained subjective separation/provenance/conflict scenarios inspected and rerun. |
| S3-R02-COMMUNICATION-PROVENANCE-STALENESS | Supported | Communication, staleness, provenance and activated legacy bindings retained; no H broadcast path found. |
| S3-R03-INITIATIVE-RESPONSE-ACCOUNTING | Supported | One initiative constraint, independent responses, no receipt reactivation retained. |
| S3-R04-OBSERVER-NONINTERFERENCE | Supported | Inherited observer metamorphics and P13 exact digest pass. |
| S3-R05-LOCALITY | Supported | Inherited/new representative causal locality checks pass; false fallback diagnosis separately identified by B2. |
| S3-R06-FALLBACK-ID-QUARANTINE | Block B2 | Existing inherited tests green, but new Household resolver violates inherited fallback quarantine. |
| S3-R07-CACHE-DERIVED-NONAUTHORITY | Supported | S1-084/META-05/MUT-24 unchanged and exercised; new partition contains explicit authority only. |
| S3-R08-STABLE-CLOSURE | Supported | Stable closure, duplicate-cause and no voluntary reactivation evidence retained. |
| S3-R09-PERSON-LEVEL-SEMANTICS | Supported | Person-level action/claim/marriage/residence code and invariant assertions preserved. |
| S3-R10-TRACE-CONFIGURATION | Supported | Inherited trace checks rerun; separate arbitrary configuration/rule labels verified. |
| S3-R11-FROZEN-AUTHORITY-INTEGRITY | Supported | Exact immutable blobs and 128+46 required ID inventory preserved; this is integrity, not semantic certification of B2. |

The independent matrix totals **80 Supported / 9 Qualified / 7 Blocked** rows (five B1 and two B2). These are review dispositions, not edits to frozen classifications. Downstream qualified rows must be reassessed after the warrant checker repair.

## Deferred and unexercised audit

All classifications below are unchanged in the frozen manifest, local output, and downloaded exact-candidate artifact. Source/type inspection found no hidden implementation of the deferred capabilities.

| AcceptanceId | Preserved status | Audit finding |
|---|---|---|
| S3-065-NO-REPEATED-PREDECESSOR-SOURCE-GENERALIZATION | DEFERRED | Repeated predecessor participation is explicitly stopped with LATER-03; no source-selection generalization. |
| S3-D01-CANDIDATE-CONVERGENCE | DEFERRED | Bounded inert referents only; no equivalence/merge algorithm. |
| S3-D02-ACTOR-DEPARTURE | DEFERRED | Participation exit does not remove world actors. |
| S3-D03-REPEATED-PREDECESSOR-PARTICIPATION | DEFERRED | Same LATER-03 boundary as S3-065, without reclassifying either row. |
| S3-D04-HEAD-OFFICE | DEFERRED | No head role or succession API. |
| S3-D05-HOUSEHOLD-DECISION-MODE | DEFERRED | No separate Household initiative/context. |
| S3-D06-PROVISION-SOLICITATION-RECONSIDERATION | DEFERRED | Only narrowly authorized pre-existing commitment fixture; no acquisition action. |
| S3-D07-HOUSEHOLD-SPENDING | DEFERRED | No collective support/dowry/debit execution. |
| S3-D08-MEDIATED-MARRIAGE-AUTHORITY | DEFERRED | Existing ordinary marriage behavior does not add Household authority topology. |
| S3-D09-AUTHORITY-DESTROYING-RACE | DEFERRED | No executable head/authority-dependent action. |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED | No engine save/load; detached resolver copies and produced-fixture reuse are not checkpoints. |
| S3-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED | Deterministic hand-authored probes/scenarios only; no general generator/shrinker activated. |
| S3-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED | No rendered explanation surface introduced. |

## Delivery disposition

The review branch is based on exact candidate `69ae753da2e05450766a9042ac6958fa7aa0b3e7`. Its only intended tracked addition is this report. Production code, acceptance code, manifests and accepted semantics remain unchanged. The candidate branch and all three authority branches were rechecked against their original identities during the review.

**DO NOT PROMOTE candidate-v2.** Complete the bounded warrant-verification and fallback-normalization repairs, preserve the independently confirmed v2 fixes, and commission another independent exact-candidate review. No semantic escalation is required by the findings established here.
