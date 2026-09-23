# IMP-0003 — Fresh independent conformance review

**Verdict: BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**

**Recommendation: DO NOT PROMOTE**

**Reviewed on:** 2026-09-23

**Candidate:** `imp-0003-slice3-conformance-candidate-v1` at `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`

**Canonical parent:** `77f3d1dd9630401ff6bba0b38283a823e26d2a01`

**Implementation PR:** [#51](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/51)

**Return branch:** `review/imp-0003-conformance-independent-return`, created from the exact candidate

**Authority:** read-only conformance judgment; no implementation or semantic changes authorized by this return.

The canonical commands and the candidate's acceptance scenarios pass. Reviewer-owned challenges nevertheless establish two bounded blockers: the independent participation-warrant checker accepts materially false evidence, and Slice-3 response/history rule provenance depends on the spelling of the scenario configuration label. Neither defect requires a new social rule. The original candidate must remain immutable; repair and fresh conformance belong on a successor candidate.

## 1. Independence, retrieval, and identity

This reviewer did not author IMP-0003 and started this task without implementation-session history. The supplied dispatch packet necessarily exposed the candidate identity, reported CI status, and two claimed repairs. Those statements were treated as claims to check. The implementation report, PR narrative, generated row summaries, and CI metadata were not used to form the provisional verdict. Authority, the parent-to-candidate diff, every modified production file, and every new acceptance source were read first. Canonical commands and independent probes were then run. A provisional BLOCK was recorded outside the repository before consulting the coder report and PR narrative. No other review of this implementation candidate was consulted. No subagents were used.

Retrieved authority included `AGENTS.md`, `00_START_HERE.md`, `plans/CURRENT_PHASE.md`, accepted SPEC-SFL-0001, ADR-0001 through ADR-0005, the IMP-0003 implementation packet, all three frozen manifests and freeze records, and the conditional S1-084 packet. The canonical formation, continuity/turnover, lineage, recognition/information, provision, no-self-confirmation, resolution/reaction, determinism/recovery/explainability families and Cross-Cutting Verification Contract were inspected. Later-slice examples in those families were subordinated to the frozen Slice-3 applicability boundary.

| Authority | Frozen ref | Freeze commit | Manifest Git blob at candidate and freeze |
|---|---|---|---|
| `SFL-V0-S1-ACCEPTANCE-v1` | `sfl-v0-slice1-acceptance-v1` | `55377cc34b8bc3ccbf9cdf5029e9791dae965987` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| `SFL-V0-S2-ACCEPTANCE-v1` | `sfl-v0-slice2-acceptance-v1` | `88f876298852553d6afca76e743a5a811ff9f0fd` | `e4872531cf780d51fa1863f2a0b87e2424a71b69` |
| `SFL-V0-S3-ACCEPTANCE-v1` | `sfl-v0-slice3-acceptance-v1` | `25160f33c994fd5f3e277ae98f03e55d37c878dd` | `1aae13dc27572361fe99c31ef8aee0444d39364a` |

The named refs are branches in this repository. Initial resolution and subsequent `git ls-remote` checks matched the packet, including the exact candidate SHA. The candidate did not move during review. Direct Git comparisons found no candidate edits to SPEC, accepted ADRs, or frozen manifests. Manifest REQUIRED member sets were independently parsed and compared with local execution output: 128, 46, and 96 respectively, with zero missing or extra IDs. The candidate diff has 21 files; only its implementation report was held back until after the provisional judgment.

## 2. Canonical execution

The host initially had no suitable SDK. Official SDK **10.0.401** was installed into `%TEMP%/imp0003-review/dotnet`, outside the repository. `global.json`, projects, source, and tests were unchanged. PATH/DOTNET_ROOT selected that SDK. Commands were executed from the candidate root before adding this report; generated evidence records candidate SHA `6b9d40e...` and `WorkingTreeDirty=false`.

| Exact command | Result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | Exit 0; all three projects restored; no warnings/errors emitted. |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | Exit 0; no formatting/analyzer diagnostics. |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | Exit 0; **0 warnings, 0 errors**. |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | Exit 0; **10 passed, 0 failed, 0 skipped**, approximately 30.46 seconds. |

Ten is the number of top-level test methods, not the number of acceptance obligations. The Slice-3 runner executes 25 scenario groups and audits 72 worlds. Its 96 green row labels do not override the defects below.

## 3. Blocking findings and bounded repairs

### B1 — The participation oracle accepts absent, fabricated, and unrelated evidence

**Class:** verification defect; independently reproduced.

**Affected completion obligations:** especially S3-020, S3-021, S3-023, S3-026; frozen manifest §4 and Cross-Cutting Verification Contract §§1, 9.

**Source:** [HouseholdOracle.cs, lines 69–84](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/6b9d40e33b94d9094c02fe3d9f026914dd7986ec/tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs#L69).

After producing an ordinary H and a valid newcomer entry through the unchanged production boundary, the reviewer supplied three separate detached `HouseholdSnapshot` corruptions to the candidate's actual, unchanged `HouseholdOracle.Verify(initial, simulation, cycles, evidence)`:

| Probe | Detached corruption | Required checker result | Actual result |
|---|---|---|---|
| P17 | Replace the entry's `Recognition` array with `[]`. | Reject missing newcomer/bridge recognition evidence. | Accepted; `All(...)` on an empty array is true. |
| P18 | Replace entry support with event 999999 at cycle 999, newcomer 4 ↔ nonparticipant 8, with `Order=(999,0)`. No such event exists. | Reject nonexistent/future support and wrong current-participant endpoint. | Accepted; checker tests only an alleged order after formation and one newcomer endpoint. |
| P19 | Point `Acceptance` at an earlier gift's ordinary `Response: Accept`. | Reject acceptance of a different proposal by an unrelated counterpart. | Accepted; checker tests only event kind and detail, not proposal/counterpart/causal binding. |

The uncorrupted witness passed first; the detached inputs leave the live simulation and its valid history intact. Thus these are **survived checker corruptions**, not fixtures manufacturing production Household state, and not exceptions caught at production validation before the oracle runs. P17–P19 fail the reviewer's rejection assertions because no `AssertFailedException` is raised by the checker.

Minimal corruption pattern, after valid production formation and admission:

```csharp
HouseholdSnapshot good = sim.HouseholdSnapshot;
ParticipationWarrant entry = good.Entries.Values.Single();
HouseholdSnapshot bad = good with {
    Entries = good.Entries.SetItem(entry.Id, entry with { Recognition = [] })
};
// Expected: assertion failure. Candidate: returns normally.
HouseholdOracle.Verify(initial, sim, cycles, bad);
```

Production prerequisite ablations do reject missing recognition, support, and acceptance in the ordinary scenarios. That is useful positive evidence, but it is not the independently reconstructed warrant evidence the frozen contract also requires. Absence of forbidden production-helper calls establishes dependency independence, not checker adequacy. The coder's corrupt controls cover formation support count and an empty continuation bridge only; they do not close these participation holes.

**Repair scope:** independently reconstruct the entry prestate from valid referenced transitions/history; bind the named request/invite proposal, actor, newcomer, bridge and accepting counterpart; require both actors' supported H-recognition bases; validate each cited support against a real qualifying committed event, its endpoints, and its position strictly after formation and before entry; verify residence/tie references against the applicable precommit state. Add detached corrupt-witness controls, including P17–P19, which must reach and fail the independent checker. Do not replace these checks with calls to `HouseholdRules` or weaken the manifest.

### B2 — Scenario configuration spelling mislabels active Slice-3 rules

**Class:** implementation/trace defect; independently reproduced.

**Affected completion obligation:** S3-092, with implications for the Slice-3 use of the inherited trace contract.

**Sources:** [Simulation.cs:30](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/6b9d40e33b94d9094c02fe3d9f026914dd7986ec/src/Mesopotamia.Sim/Simulation.cs#L30), [Execution.cs:201](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/6b9d40e33b94d9094c02fe3d9f026914dd7986ec/src/Mesopotamia.Sim/Execution.cs#L201), [Execution.cs:442](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/6b9d40e33b94d9094c02fe3d9f026914dd7986ec/src/Mesopotamia.Sim/Execution.cs#L442).

`ActiveRulesVersion` is `SFL-S3-v1` only when `initial.Configuration.Version` equals that exact string; otherwise it is the inherited `Configuration.RulesVersion` (`SFL-S2-v1`). No corresponding rule-selection gate disables Household formation/admission for other configuration labels.

P16 repeats production formation, H-recognition communication, post-formation support, and successful `RequestHouseholdParticipation` with `new Configuration("review-custom-config")`. The entry commits and its Household warrant is stamped `SFL-S3-v1`, but its response `DecisionTrace.RulesVersion` is `SFL-S2-v1`. Changing a scenario label has changed the claimed rule provenance without changing the executed Household semantics. The original S3 cases all use the magic label, so their assertions miss the mismatch.

SPEC §§5.1, 9.4 and S3-092 require truthful active rule/configuration provenance. The runtime's own documentation distinguishes the rule version from a caller-supplied scenario configuration. A README instruction to use the magic label does not make the accepted and successfully executed custom-label path truthful.

**Repair scope:** separate active semantic rule identity from the scenario configuration label and emit consistent provenance for the affected context/history. Preserve genuine inherited S2 behavior and tests; do not mechanically relabel every historical S2 scenario. Add a custom-label Household participation case and compare emitted response/event/warrant provenance with the rules actually exercised. No social-semantic decision is missing.

### C1 — Additional acquisition-route concern, not an independently adjudicated blocker

P20 produces H(A,B,C), moves B to another dwelling, and has newcomer D enter through A after the normal communication/support prerequisites. B submits no entry action, is not the named counterpart, and receives no communication. Nevertheless B's old H-recognition evidence is replaced with the new continuation evidence.

[HouseholdExecution.cs:74–78](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/6b9d40e33b94d9094c02fe3d9f026914dd7986ec/src/Mesopotamia.Sim/HouseholdExecution.cs#L74) labels **all current sustaining participants** as participants in `HouseholdContinued` and acquires evidence for all of them. The production entry itself lists only D/A. This establishes the behavior; its interpretation needs care because the implementation regards existing bearers as direct parties to the automatic continuation transition. The frozen contract explicitly forbids passive synchronization, but does not enumerate every direct-party entitlement for that automatic event.

This return therefore does **not** count P20 alone as a proven production violation or demand a newly invented observation rule. It qualifies S3-043/044: before promotion, explain the accepted source grounding for that entitlement or narrow acquisition and retain the remote-bearer regression. The confirmed B1/B2 already determine the verdict. No general nonparticipant-observation permission is granted here.

## 4. Production, fixture, and oracle audit

All modified production sources were inspected: `Decisions.cs`, `EpistemicExecution.cs`, `EpistemicState.cs`, `Execution.cs`, all four `Household*.cs` production files, `ResolutionDependencies.cs`, and `Simulation.cs`; both changed READMEs and `.github/workflows/ci.yml` were also inspected. All seven new acceptance files were read in full, including row bindings and concrete assertions. Inherited `AcceptanceTests`, `AcceptanceCatalog`, fixture auditing, independent invariant checker, and representative high-risk scenario bodies were inspected.

- Formation is automatic closure after committed ordinary support and every founder's actor-held CandidateRecognition. Objective co-residence, a durable graph, candidate presence, or subjective fixture supports alone do not write H. The three-founder canonical schedule is actual production behavior. P01 withholds exactly one founder's missing support report and forms H only after its delivery.
- `SustainingParticipant` associations are typed, separately identified authority. Current-participant enumeration is derived from active associations; lifecycle counts do not allocate or identify H. Formation, entry, exit, and continuation warrants retain their own identities. No primitive Members set or FormHousehold command was found.
- Both admission directions enforce recognition, named live bridge, residence, durable tie, post-formation ordinary support, and response acceptance, with immediate revalidation. Source review and positive/negative execution support these runtime gates. B1 concerns the additional independent evidence check.
- Exit mutates only the typed association and corresponding provision commitments. The code does not delete residence, marriage, kinship, debt, favour, attitude or history. The canonical turnover witness explicitly checks several of these; marriage preservation also follows the reviewed mutation write set, rather than an invented marriage fixture claim.
- Continuations reference previous warrants and prior/successor associations. Complete turnover is supported; P04 breaks the named bridge, P05 exercises sole-bearer handoff, and P06 establishes permanent dissolution plus new formation identity.
- Division/consolidation are downstream of ordinary formation, require explicit ended sources and fresh ordinary evidence, consider complete interpretations, and withhold ambiguous classification. The dissolved-division and unrelated-H4 controls succeed independently. No state inheritance through lineage was found in action validation/commit paths. `HouseholdProjectionKey` does read lineage when comparing counterfactual outputs; it is not a lineage-driven social action generator.
- Capacity directly recomputes from valid commitments and personal grain/need. P12 verifies committed-contributor 1/2/3/8 boundaries and same-grain NeedsGrain variants using detached input snapshots, plus real exit termination. Those detached capacity inputs are not claims that positive-grain NeedsGrain is a reachable stable world. No treasury, spend path, or headless runtime commitment-acquisition action exists.

The fixture write sets in `World`, `WithKnowledge`, `CanonicalFormation`, `FormGroup`, and the epistemic/provision cases were inspected. They seed people, personal grain, dwelling/residence, declared lower-level ties/facts, candidate referents, and ordinary proposals. The extra internal seams supply explicitly fixture-marked held H evidence where acquisition is not the assertion target, and pre-existing commitments under manifest §3.1. They do not write Household/warrant/participation/lifecycle/derived-capacity results. Contrary evidence is supplied to a sender; its recipient acquires it through production communication.

`Form`/`FormGroup` run the kernel and invoke the independent checker before recording producer PASS, fixture description, configuration and output digest. Global evidence supplies the frozen authority and implementation identity. This is in-run producer provenance, not engine checkpoint/save-load. The B1 inadequacy limits what a producer's checker PASS can certify; a JSON `EndogenousHouseholdWrites=0` label was not treated as proof by itself.

`HouseholdOracle` uses domain records, public history, hand-written graph/arithmetic checks and MSTest assertions. No prohibited production classifier/helper is used as the expected answer. Its formation-count and continuation-bridge corrupt controls genuinely reach the checker. The independent dependency audit passes, but overall oracle adequacy **does not pass** because of B1. Reviewer P17–P19 demonstrate the distinction directly.

## 5. Scheduler, closure, and S1-084

`HouseholdResolutionFallbacks` adds person scope, current association/H scope, candidate-core scope and communicated H scope to inherited dependencies. Person keys include the residence mover, so a newcomer who is not yet a participant is grouped with admission. P03 keeps proposal IDs fixed while reversing input enumeration, then separately swaps IDs: move-first invalidates admission; entry-first permits entry followed by residence change; consequential technical fallback is disclosed in both cases. Input enumeration alone does not decide the result.

`HouseholdRules.Before` encodes the named-bridge entry-before-exit partial order. Both live resolution and detached enumeration apply it. P05 checks four combinations of input order and relative proposal IDs, with same-H/newcomer-sole-bearer/Inactive results and no arbitrary fallback marker. Detached replay copies world, epistemic and Household partitions, including allocation counters. It uses production commit/closure for conflict analysis without consuming live IDs. Read-only trajectory/ID comparisons pass in P13. These bounded checks support the repaired grouping and handoff behavior; they are not a proof over all possible coupled components.

Lifecycle is closed after resolution and continuation reactions. Duplicate challenges and skipped-closure guards execute; no stable snapshot is published after the deliberate closure failure. The formation/lineage/continuation idempotence checks rely on committed causal identities. There is no fresh voluntary activation inside closure. Counterfactual order enumeration can grow factorially with a connected component; the runtime documents this reference-kernel limitation, and no new scalability claim is made.

**S1-084 adaptation trigger: UNFIRED.** Exact candidate/parent Git blobs agree:

| Surface | Parent and candidate blob |
|---|---|
| `src/Mesopotamia.Sim/State.cs` | `a55bd0e73292a9c96450e8dc74e3337b5587b28e` |
| `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` | `a2204947dc1c7704a90af1efa44170e0b39296e0` |

Consequently `WorldState`'s exact nine-field inventory and the original `NoDerivedAuthorityStructuralAudit` (S1-084/S1-META-05/S1-MUT-24) are unchanged. New `HouseholdState` has nine explicit dictionaries and four identity counters; its separate exact-field audit covers them. Support records are committed ordinary evidence, not a hidden derived graph/cache. Participant, capacity, direct-lineage and ancestry queries recompute. No weakening or bypass of the old structural route was found.

## 6. Reviewer-owned scratch probes

The external console project at `%TEMP%/imp0003-review/probes` references the unchanged Release production DLL. It uses the existing `InternalsVisibleTo("Mesopotamia.Sim.Tests")` test-access boundary for the two admitted fixture prerequisites, and compiles the unchanged `HouseholdOracle.cs` as a linked source for detached checker challenges. It does not load or call candidate scenario helpers. Its own lower-level setup and schedules produce every H through `RunCycle`; no live private-field mutation/reflection injection is used. The setup uses eight people, high personal grain, declared kinship/residence facts, and ordinary gift/communication/participation actions. The ID variant maps person n to 109−n and renames the candidate.

**20 probe groups; 109 reviewer assertion invocations: 104 passed, 5 failed.** Assertion counts include explicit producer checks, exclude assertions executed inside `HouseholdOracle`, and stop at the first failure within each group. P01–P15 cover all fifteen minimum probe categories. P16–P19 establish B2/B1; P20 is the qualified route concern C1.

| Probe | Setup / assertion target | Reviewer assertions | Result |
|---|---|---:|---|
| P01 | A→C, C→B support; only A receives missing report; B remains Unknown; final report enables H. | 4 | PASS |
| P02 | Separate normal request and invite worlds; entry and continuation warrants exist. | 6 | PASS |
| P03 | Newcomer residence/admission race; four ID/input combinations; revalidation and fallback. | 12 | PASS |
| P04 | Recognized newcomer with support, but named bridge exits before request. | 3 | PASS |
| P05 | Sole A exits while D enters; four ID/input combinations; entry precedes exit, same identity. | 24 | PASS |
| P06 | All founders exit; old-H request fails; valid later organization receives new H. | 4 | PASS |
| P07 | Every initially uninvolved actor remains Unknown, including after idle closure. | 7 | PASS |
| P08 | Communicate incompatible nondominated H evidence in permuted input; Contested blocks entry. | 6 | PASS |
| P09 | Predecessor dissolved before valid ordinary successor formation; no division lineage. | 3 | PASS |
| P10 | Consolidation founder currently also participates in H4; only ended H1/H2 enter predecessors. | 2 | PASS |
| P11 | Remove/rebuild detached lineage view; live warrant retained; compare exact subsequent trajectory. | 6 | PASS |
| P12 | Admitted pre-existing commitment; independent 1/2/3/8 arithmetic and NeedsGrain; exit termination. | 12 | PASS |
| P13 | Repeated observer/epistemic/participant/ancestry/capacity reads; exact later history/IDs/evidence comparison. | 3 | PASS |
| P14 | Non-order-preserving person-ID and candidate rename; normalize participation, lifecycle and recognition. | 3 | PASS |
| P15 | Actual ActionTerms subtype census: exactly three Household participation actions, no deferred actions. | 2 | PASS |
| P16 | Same Household chain under custom configuration label; response must identify S3 rules. | 3 | FAIL — B2 |
| P17 | Empty bilateral recognition in detached valid entry witness must be rejected. | 2 | FAIL — B1 |
| P18 | Nonexistent future newcomer/nonparticipant support must be rejected. | 2 | FAIL — B1 |
| P19 | Unrelated gift acceptance substituted into entry warrant must be rejected. | 2 | FAIL — B1 |
| P20 | Remote bearer uninvolved in bilateral entry retains old evidence under narrow participation interpretation. | 3 | FAIL — C1, qualified |

P11 is an analytical detached-view comparison, not deletion of authoritative lineage or a live cache-invalidation hook. Structural source review supplies the complementary evidence that these queries are not stored behavior-authoritative caches. The scratch program catches each group's failure to report all groups; process exit 0 is not an overall PASS claim.

Local reproducibility files, outside the candidate:

- `Program.cs` SHA-256: `fec9c89d14d9072caefbe985d5de9ab7338a7ec5a82403063773fa6b54c418f8`.
- `probe-results.json` SHA-256: `3f358c3e9543bfcf72f4bd71bc872fec41c896e729f7146dc1ac0954cc651582`.
- Run with the installed SDK: `dotnet run --project Review.csproj --configuration Release` from that scratch directory. The project references the candidate's compiled DLL and MSTest assembly, not a modified project/source tree.

## 7. Exact inherited regression audit

All 128 Slice-1 REQUIRED identities and all 46 Slice-2 REQUIRED identities are preserved and accounted for individually in Appendix B. The unchanged Slice-1 runner reports **127 executable/structural PASS plus `S1-GLOBAL-CONFORMANCE = AWAITING INDEPENDENT REVIEW`**. The Slice-3 wrapper maps that last ID to the preserved accepted IMP-0001 completion record, yielding its reported 128 inherited PASS. This review independently read that historical completion record for candidate-v3 `06e25644879dd8505e24fcaeb43256f69c29c15f`; it is valid inherited provenance, **not a fresh PASS for IMP-0003**. All 46 Slice-2 REQUIRED rows execute and pass.

High-risk inspection went beyond those labels: `Slice2Scenarios` covers own/direct acquisition, recipient-only communication, initiative accounting, staleness and underlying-event precedence, contested candidate recognition, subjective gates, replay and configuration; `PipelineScenarios` checks shared-snapshot failures and no reactivation; `MarriageResidenceScenarios` checks residence conflicts and relation separation; `CrossCuttingScenarios` checks exact state/observer comparisons, fallback/isomorphism and unchanged derived-authority inventory; the inherited invariant oracle reconstructs material and required attitude causes independently. The corresponding production `Execution`, epistemic acquisition/communication, action validation and resolution changes were inspected.

No failing inherited bounded S1/S2 execution was observed. Their original scenarios do not test the new custom-label Household trace or settle the all-bearer acquisition interpretation. The S3-R bundles must not be read as certifying every new Household interaction merely because the older suite remains green. No prior REQUIRED/DEFERRED/UNEXERCISED classification was edited.

## 8. Scope and delivery evidence

All **11 DEFERRED** and **2 UNEXERCISED** Slice-3 rows remain individually classified in Appendix A. Source/action census found no head role/appointment/succession, head recognition, HouseholdDecisionContext or separate initiative, endogenous provision acquisition/reconsideration, Household spending/support/dowry/debit ranking, mediated-marriage authority, checkpoint/save-load, actor departure, general observation, trust/rumor/reputation, stochastic/strategic policy redesign, or generalized fission/merger engine. Repeated predecessor participation explicitly raises `LATER-03` rather than choosing a source. Multiple separately declared inert candidates do not implement a convergence/equivalence algorithm; the one-referent-per-episode boundary remains a caller obligation.

The scope audit found no confirmed later-slice implementation leakage. C1 remains a specifically qualified acquisition-route concern; it is not presented as proof of a general observation subsystem.

Exact-head CI was independently fetched **after** the provisional result:

- [Run 35910481737](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35910481737): completed/success; head `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`; attempt 1.
- Job `107348751431` (`verify`): successful checkout, SDK, restore, static quality, build, test, and artifact steps. Job logs contain the four exact canonical commands, SDK 10.0.401, 0 build warnings/errors, and 10 tests with 0 failed/skipped.
- [Artifact 10772553766](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35910481737/artifacts/10772553766): `sfl-slice1-slice2-slice3-acceptance-evidence`; unexpired; expiry reported as 2026-12-22T19:36:44Z.
- The downloaded ZIP is 516,637 bytes. Its locally recomputed SHA-256 is **`b345696d803d25beeb574d5b261748d4c88776ea81a81d7a7a20ef7e64350029`**, matching both packet and GitHub artifact metadata.
- All 15 expected files are present: S1 results Markdown/JSON, cases, fault controls, fixture and oracle audits; S2 results/cases/fixture/oracle/regression-fixture evidence; S3 results/cases/fixtures/producers. S3 JSON identifies the exact candidate, clean working tree and frozen manifest, with 96 REQUIRED PASS, 11 DEFERRED, 2 UNEXERCISED and 174 inherited bindings. Those are faithfully reproduced coder claims, not the verdict of this review.

The reported residence/admission grouping repair is corroborated by source and P03. The terminal-exiter-only dissolution repair is corroborated by `CloseHouseholds` and its actual regression: earlier same-cycle leavers keep stale positive evidence. That narrower dissolution rule does not resolve C1's distinct continuation-acquisition question. The implementation report accurately says fresh conformance is still required; its broad independent-warrant-audit claim is contradicted by B1, and its label-based rule-version choice does not satisfy B2.

## 9. Disposition and return integrity

**BLOCK — IMPLEMENTATION / VERIFICATION DEFECT. DO NOT PROMOTE this exact candidate.** B1 and B2 have bounded source/test repairs under already accepted authority. A semantic escalation is not needed to fix them. C1 should be settled by source-grounded entitlement analysis or a narrow acquisition repair; if a new observation entitlement is desired, that would require separate authority rather than being silently granted by this review.

The return adds only this Markdown file relative to the exact candidate. No production/test/frozen-authority file was modified; scratch probes, the temporary SDK, downloaded CI evidence and build outputs are outside the committed return. The implementation PR was not approved or merged. A successor repair should preserve the immutable candidate ref and receive new exact-head CI and fresh independent conformance.

## Appendix A — Individual Slice-3 audit

Each REQUIRED row was checked against its frozen obligation, actual bound scenario assertions and relevant production/oracle source. The notes below are reviewer judgments, not copied PASS labels. **SUPPORTED** means no material defect established for that bounded obligation by the reviewed evidence; it does not waive B1/B2 or certify arbitrary histories. **BLOCKED** identifies a demonstrated implementation/evidence defect. **QUALIFIED** withholds an unqualified acquisition-route conclusion pending C1. There are 96 REQUIRED rows: 89 SUPPORTED, 5 BLOCKED, 2 QUALIFIED.

| AcceptanceId | Reviewer result | Evidence / scope |
|---|---|---|
| S3-001-FORMATION-POSITIVE | SUPPORTED | Canonical A→C/C→B plus two reports forms H at cycle 4; production chain and P01. |
| S3-002-FOUNDING-CARDINALITY | SUPPORTED | One founder rejected; two-person and canonical three-person formation execute. |
| S3-003-FORMATION-RESIDENCE-ABLATION | SUPPORTED | Residence ablation has no H; objective shared-dwelling gate inspected. |
| S3-004-FORMATION-DURABLE-TIE-ABLATION | SUPPORTED | Tie ablation has no H; connected durable-tie predicate independently checked. |
| S3-005-FORMATION-SUPPORT-COUNT-ORDER | SUPPORTED | One event and same-cycle pair fail; distinct-cycle ordinary support succeeds. |
| S3-006-FORMATION-RECOGNITION-ABLATION | SUPPORTED | P01 isolates exactly one missing founder; delivering its report enables H. |
| S3-007-CANDIDATE-NONAUTHORITY | SUPPORTED | Inert candidate without support does not form H; referent carries no resources/powers. |
| S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS | SUPPORTED | InitialWorld/public action census has no H/warrant ingress or FormHousehold action. |
| S3-009-NO-HIDDEN-MEMBERS-AUTHORITY | SUPPORTED | Typed associations are authority; no universal Members/graph-cluster identity. |
| S3-010-FORMATION-WARRANT-PROVENANCE | SUPPORTED | Formation provenance/source checks plus detached insufficient-support corruption detection. |
| S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME | SUPPORTED | Earliest retained evidence differs from formation stamp; both retained in warrant. |
| S3-012-FOUNDING-PARTICIPATION-PROVENANCE | SUPPORTED | Each founder has one association originating at the FormationWarrant. |
| S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H | SUPPORTED | Production formation acquires direct H evidence for all founders; outsiders remain Unknown. |
| S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY | SUPPORTED | Type/action census has no head or Household initiative. |
| S3-015-QUALIFYING-SUPPORT-KIND-CENSUS | SUPPORTED | Gift/help, loan and fulfilled favour exercised; shared ordinary-kind census excludes H feedback. |
| S3-020-PARTICIPATION-ENTRY-POSITIVE | BLOCKED | Runtime request/invite paths work (P02), but entry warrant reconstruction is inadequate (B1). |
| S3-021-PARTICIPATION-RECOGNITION-ABLATION | BLOCKED | Runtime recognition ablations pass; oracle accepts empty recognition evidence (P17/B1). |
| S3-022-PARTICIPATION-BRIDGE-ABLATION | SUPPORTED | Both direction ablations and P04 reject the absent named bridge. |
| S3-023-PARTICIPATION-BILATERAL-ABLATION | BLOCKED | Runtime decline control passes; unrelated gift acceptance survives checker (P19/B1). |
| S3-024-PARTICIPATION-RESIDENCE-ABLATION | SUPPORTED | Both ablations plus P03 precommit race; input enumeration does not change fixed-ID result. |
| S3-025-PARTICIPATION-DURABLE-TIE-ABLATION | SUPPORTED | Both direction tie ablations reject; runtime tie gate inspected. |
| S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION | BLOCKED | Runtime missing-support controls pass; invented future/nonparticipant support survives checker (P18/B1). |
| S3-027-PARTICIPATION-END-WARRANT | SUPPORTED | Explicit exit warrants reference ended association; no fixture-produced end result. |
| S3-028-PARTICIPATION-END-NONERASURE | SUPPORTED | Reviewed exit write set preserves lower-level relations/history; turnover checks debt/favour/residence/kin. |
| S3-029-RESIDENCE-NOT-PARTICIPATION | SUPPORTED | Real residence change leaves associations/lifecycle identity intact. |
| S3-030-EXIT-SIDE-CONTINUATION | SUPPORTED | Ordered previous/prior/successor warrant chain inspected; broken detached bridge rejected. |
| S3-031-COMPLETE-FOUNDER-TURNOVER | SUPPORTED | Six continuation transitions replace all A/B/C with D/E/F under one H. |
| S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT | SUPPORTED | Broken named bridge rejected; dissolved/similar organization cannot inherit H; P04/P06. |
| S3-033-INACTIVE-STATE | SUPPORTED | One bearer publishes Inactive at closure; no new identity or initiative. |
| S3-034-INACTIVE-REACTIVATION | SUPPORTED | Sole-bearer normal entry restores Active under the same H. |
| S3-035-SAME-CYCLE-BRIDGE-HANDOFF | SUPPORTED | P05: four proposal-ID/input permutations preserve same-H sole-newcomer handoff without fallback. |
| S3-036-DISSOLUTION-STABLE-CLOSURE | SUPPORTED | Zero-bearer dissolution is in CloseHouseholds after compatible transitions. |
| S3-037-DISSOLVED-NO-RESURRECTION | SUPPORTED | P06: old-H admission fails; separately formed organization has new identity. |
| S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION | SUPPORTED | Recorded participation-consumed support bundle blocks duplicate candidate formation. |
| S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP | SUPPORTED | Canonical distinct-support control admits separately warranted overlap. |
| S3-040-HOUSEHOLD-RECOGNITION-DISTINCT | SUPPORTED | Separate KnownFact, candidate and Household recognition schemas; no attitude/authority conflation. |
| S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION | SUPPORTED | P07 covers every uninvolved actor; canonical dissolution keeps earlier leavers stale. |
| S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE | SUPPORTED | Recognized/Unknown entry controls retain objective prerequisites and change eligibility. |
| S3-043-H-RECOGNITION-STALE-RETENTION | QUALIFIED | Outsider/leaver controls pass; remote current-bearer automatic refresh needs C1 entitlement analysis. |
| S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE | QUALIFIED | Communication and newer continuation evidence execute; all-bearer direct route remains qualified by C1. |
| S3-045-DISSOLUTION-RECOGNITION-ROUTE | SUPPORTED | Terminal exiter learns dissolution; outsider updates through held-fact communication. |
| S3-046-H-RECOGNITION-NO-ID-WINNER | SUPPORTED | Nondominated H reports do not get an ID/arrival-selected winner; source precedence inspected. |
| S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE | SUPPORTED | Ordinary gift/attitude change leaves held H recognition evidence unchanged. |
| S3-048-H-RECOGNITION-CONTESTED | SUPPORTED | P08 and canonical message permutations preserve Contested. |
| S3-049-H-RECOGNITION-CONTESTED-GATE | SUPPORTED | Contested entry fails; matched recognized positive control succeeds. |
| S3-050-DIVISION-DESCENDANT | SUPPORTED | Ordinary successor formation, explicit exits, live predecessor and fresh support produce division. |
| S3-051-DIVISION-FRESHNESS-ABLATION | SUPPORTED | Stale-support variant forms successor but withholds division lineage. |
| S3-052-DIVISION-PREDECESSOR-CONTINUITY | SUPPORTED | Live predecessor keeps its warranted identity; lineage cannot replace it. |
| S3-053-CONSOLIDATION-DESCENDANT | SUPPORTED | Two dissolved sources with fresh cross support form independent successor plus consolidation. |
| S3-054-CONSOLIDATION-SURVIVOR-ABLATION | SUPPORTED | Surviving predecessor control forms successor without consolidation. |
| S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION | SUPPORTED | Pre-dissolution cross-support control forms successor without consolidation. |
| S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT | SUPPORTED | Multiple valid source interpretations withhold lineage; no first/lowest-ID winner. |
| S3-057-LINEAGE-SOURCE-PROVENANCE | SUPPORTED | Oracle checks founder/predecessor/ParticipationEnd references and temporal ordering. |
| S3-058-LINEAGE-ZERO-OR-ONE | SUPPORTED | One lineage per formation; positive/negative cases and cause-key guard. |
| S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS | SUPPORTED | Forward predecessor formation/exit checks plus direct/transitive graph controls. |
| S3-060-LINEAGE-NONAUTHORITY | SUPPORTED | No causal-state inheritance found; source read set and detached-view trajectory P11. |
| S3-061-DERIVEDFROM-REBUILD | SUPPORTED | DerivedFrom recomputes from warrant edges; detached removal/rebuild P11. |
| S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY | SUPPORTED | H1→H2→H3 distinguishes direct edge from transitive ancestry. |
| S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC | SUPPORTED | Reversed predecessor production/enumeration preserves unordered predecessor meaning. |
| S3-064-LINEAGE-PERSISTENCE-HISTORY | SUPPORTED | Actual lineage warrants remain after predecessor/successor dissolution. |
| S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION | SUPPORTED | P09: dissolved predecessor excluded without blocking ordinary formation. |
| S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION | SUPPORTED | P10: unrelated current H4 association excluded from {H1,H2}. |
| S3-070-PROVISION-COMMITMENT-BACKING-STATE | SUPPORTED | Controlled fixture explicitly identified; no ownership transfer; P12. |
| S3-071-PROVISION-EXPOSED-CAPACITY | SUPPORTED | P12 independent committed-capacity arithmetic at grain 1/2/3/8. |
| S3-072-PROVISION-NEEDSGRAIN-ZERO | SUPPORTED | P12 same-grain false/true NeedsGrain comparison, including positive grain. |
| S3-073-NO-POOLED-HOUSEHOLD-TREASURY | SUPPORTED | No treasury property/state; fixture and Household events move no grain. |
| S3-074-MOBILIZABLE-CAPACITY-DERIVED | SUPPORTED | Capacity recomputes from valid associations/commitments/current person inputs. |
| S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT | SUPPORTED | P12 real exit terminates commitment and only normal consumption changes grain. |
| S3-076-DISSOLUTION-TERMINATES-COMMITMENTS | SUPPORTED | Full dissolution closes remaining commitments; no confiscation. |
| S3-077-NO-SPENDING-AUTHORITY | SUPPORTED | P15 and source census find no Household expenditure/initiative path. |
| S3-080-FORMATION-REACTION-CHAIN | SUPPORTED | Support/report → founder recognition → formation/association/H recognition before publication. |
| S3-081-CAUSE-IDEMPOTENCE | SUPPORTED | Duplicate challenge executes for formation, continuation and lineage; transitions remain single. |
| S3-082-REACTIONINDEX-MONOTONE | SUPPORTED | History checker verifies unique monotone per-cycle reaction indexes and earlier causes. |
| S3-083-DERIVED-REFRESH-CLOSURE | SUPPORTED | Fresh partitions/recomputation expose commits to subsequent revalidation/closure. |
| S3-084-NO-MID-CLOSURE-PUBLICATION | SUPPORTED | Stable publication follows all closure; deliberate skipped closure faults without publication. |
| S3-085-NONSEMANTIC-ITERATION-METAMORPHIC | SUPPORTED | Canonical storage permutations and P03/P05 fixed-ID input reversals preserve required outcomes. |
| S3-086-ISOMORPHIC-ID-RENAMING | SUPPORTED | Canonical formation/turnover/lineage renames plus P14 reverse person ordering. |
| S3-087-LOCALITY | SUPPORTED | Disconnected actor/H variants preserve local continuity/lifecycle result. |
| S3-088-OBSERVER-NONINTERFERENCE | SUPPORTED | P13 compares exact future history, identifiers and held evidence after repeated reads. |
| S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE | SUPPORTED | Exact state inventory plus immutable snapshots; direct queries have no hidden cache authority. |
| S3-090-FALLBACK-QUARANTINE | SUPPORTED | Semantic handoff precedes residual ordering; P03 discloses residence/admission fallback. |
| S3-091-VERIFIED-PRODUCER-PROVENANCE | SUPPORTED | Producer identity/PASS/fixture/config/output recorded after production formation; B1 limits certification. |
| S3-092-TRACE-CONFIGURATION-TRUTH | BLOCKED | Custom scenario configuration falsely stamps Household response as S2 (P16/B2). |
| S3-093-STRUCTURAL-AUTHORITY-NONHIDING | SUPPORTED | Parent/candidate WorldState and inherited audit blobs identical; separate Household inventory. |
| S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION | SUPPORTED | Canonical name perturbation and renamed turnover/lineage keep bounded result. |
| S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION | SUPPORTED | Exact inherited subjective separation bindings pass; C1 qualifies the new H continuation extension. |
| S3-R02-COMMUNICATION-PROVENANCE-STALENESS | SUPPORTED | Exact fact/recognition communication, provenance, staleness and activated old bindings inspected/passing. |
| S3-R03-INITIATIVE-RESPONSE-ACCOUNTING | SUPPORTED | Personal/response initiative accounting and no-receipt-reactivation bindings execute/passing. |
| S3-R04-OBSERVER-NONINTERFERENCE | SUPPORTED | Inherited observer controls execute; P13 adds Household exact-trajectory comparison. |
| S3-R05-LOCALITY | SUPPORTED | Inherited locality plus disconnected-H canonical case execute/passing. |
| S3-R06-FALLBACK-ID-QUARANTINE | SUPPORTED | Inherited fallback/contested/isomorphism controls execute; P05 confirms semantic handoff priority. |
| S3-R07-CACHE-DERIVED-NONAUTHORITY | SUPPORTED | Exact inherited structural audit unchanged; Household partition independently inspected. |
| S3-R08-STABLE-CLOSURE | SUPPORTED | Inherited idempotence/closure/need and receipt controls pass; new closure guard inspected. |
| S3-R09-PERSON-LEVEL-SEMANTICS | SUPPORTED | Inherited meaning/residence/marriage/failure controls pass; no old status rewriting. |
| S3-R10-TRACE-CONFIGURATION | SUPPORTED | Inherited bounded trace cases pass; S3 custom-label coverage is separately BLOCKED under S3-092. |
| S3-R11-FROZEN-AUTHORITY-INTEGRITY | SUPPORTED | Exact 128+46 member sets accounted for; 127 S1 executions plus one historical external PASS. |

The remaining thirteen rows retain their frozen classifications:

| AcceptanceId | Classification | Audit |
|---|---|---|
| S3-065-NO-REPEATED-PREDECESSOR-SOURCE-GENERALIZATION | DEFERRED | LATER-03 guard; no repeated-source selector implemented. |
| S3-D01-CANDIDATE-CONVERGENCE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D02-ACTOR-DEPARTURE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D03-REPEATED-PREDECESSOR-PARTICIPATION | DEFERRED | LATER-03 guard; no repeated-source selector implemented. |
| S3-D04-HEAD-OFFICE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D05-HOUSEHOLD-DECISION-MODE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D06-PROVISION-SOLICITATION-RECONSIDERATION | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D07-HOUSEHOLD-SPENDING | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D08-MEDIATED-MARRIAGE-AUTHORITY | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D09-AUTHORITY-DESTROYING-RACE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED | No corresponding runtime action/state mechanism found; boundary preserved. |
| S3-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED | No general framework/surface activated; focused reviewer probes do not change this status. |
| S3-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED | No general framework/surface activated; focused reviewer probes do not change this status. |

## Appendix B — Individual inherited accounting

These are results of reexecuting the unchanged bounded inherited evidence, reconciled against the frozen member sets. They are not 174 new independently authored scenarios. The high-risk source review and its limits are described in §7. The historical external conformance row is explicitly distinguished.

| AcceptanceId | Independently verified accounting |
|---|---|
| S1-090-A | Executed PASS; exact frozen identity present. |
| S1-090-B | Executed PASS; exact frozen identity present. |
| S1-090-C | Executed PASS; exact frozen identity present. |
| S1-090-D | Executed PASS; exact frozen identity present. |
| S1-090-E | Executed PASS; exact frozen identity present. |
| S1-091-GIFT | Executed PASS; exact frozen identity present. |
| S1-091-HELP | Executed PASS; exact frozen identity present. |
| S1-091-LOAN-OFFER | Executed PASS; exact frozen identity present. |
| S1-091-LOAN-REQUEST | Executed PASS; exact frozen identity present. |
| S1-091-BFF-POS | Executed PASS; exact frozen identity present. |
| S1-091-RMRH | Executed PASS; exact frozen identity present. |
| S1-091-MEANING-SEPARATION | Executed PASS; exact frozen identity present. |
| S1-092-PARTIAL | Executed PASS; exact frozen identity present. |
| S1-092-AMOUNT-VALIDITY | Executed PASS; exact frozen identity present. |
| S1-092-RESERVE | Executed PASS; exact frozen identity present. |
| S1-092-FULL | Executed PASS; exact frozen identity present. |
| S1-092-DUE | Executed PASS; exact frozen identity present. |
| S1-093-BFF-POS | Executed PASS; exact frozen identity present. |
| S1-093-RECIP-74 | Executed PASS; exact frozen identity present. |
| S1-093-RECIP-75 | Executed PASS; exact frozen identity present. |
| S1-093-RECIP-76 | Executed PASS; exact frozen identity present. |
| S1-093-KIN-GATE | Executed PASS; exact frozen identity present. |
| S1-093-GIFT-CONTROL | Executed PASS; exact frozen identity present. |
| S1-093-BFF-FULL | Executed PASS; exact frozen identity present. |
| S1-093-BFF-RACE | Executed PASS; exact frozen identity present. |
| S1-093-RMRH-FULL | Executed PASS; exact frozen identity present. |
| S1-094-FARM-CALLABLE | Executed PASS; exact frozen identity present. |
| S1-094-REPAY-CALLABLE | Executed PASS; exact frozen identity present. |
| S1-094-PERSONAL-COEXIST | Executed PASS; exact frozen identity present. |
| S1-094-NONCALLABLE-MATRIX | Executed PASS; exact frozen identity present. |
| S1-094-NONPAYLOAD-MATRIX | Executed PASS; exact frozen identity present. |
| S1-094-UNABLE | Executed PASS; exact frozen identity present. |
| S1-094-DECLINE | Executed PASS; exact frozen identity present. |
| S1-094-INVALIDATED | Executed PASS; exact frozen identity present. |
| S1-094-SUCCESS | Executed PASS; exact frozen identity present. |
| S1-094-NESTED-GUARD | Executed PASS; exact frozen identity present. |
| S1-094-RECIP-CANCEL | Executed PASS; exact frozen identity present. |
| S1-095-POS | Executed PASS; exact frozen identity present. |
| S1-095-74 | Executed PASS; exact frozen identity present. |
| S1-095-KIN | Executed PASS; exact frozen identity present. |
| S1-095-LIFETIME | Executed PASS; exact frozen identity present. |
| S1-095-NO-RESIDENCE | Executed PASS; exact frozen identity present. |
| S1-096-MOVE | Executed PASS; exact frozen identity present. |
| S1-096-INVITE | Executed PASS; exact frozen identity present. |
| S1-096-COMPETE | Executed PASS; exact frozen identity present. |
| S1-096-NO-HH | Executed PASS; exact frozen identity present. |
| S1-096-MARRIAGE-CONTROL | Executed PASS; exact frozen identity present. |
| S1-097-EVENTS | Executed PASS; exact frozen identity present. |
| S1-097-SAT | Executed PASS; exact frozen identity present. |
| S1-097-DIRECT-BATCH-POS | Executed PASS; exact frozen identity present. |
| S1-097-DIRECT-BATCH-NEG | Executed PASS; exact frozen identity present. |
| S1-097-DECAY | Executed PASS; exact frozen identity present. |
| S1-098-CORE | Executed PASS; exact frozen identity present. |
| S1-098-CALLFAVOR-INIT | Executed PASS; exact frozen identity present. |
| S1-099-KIN | Executed PASS; exact frozen identity present. |
| S1-099-CORES | Executed PASS; exact frozen identity present. |
| S1-100 | Executed PASS; exact frozen identity present. |
| S1-101 | Executed PASS; exact frozen identity present. |
| S1-102 | Executed PASS; exact frozen identity present. |
| S1-103-GRAIN | Executed PASS; exact frozen identity present. |
| S1-103-RESIDENCE | Executed PASS; exact frozen identity present. |
| S1-105 | Executed PASS; exact frozen identity present. |
| S1-070 | Executed PASS; exact frozen identity present. |
| S1-071 | Executed PASS; exact frozen identity present. |
| S1-073 | Executed PASS; exact frozen identity present. |
| S1-074-IDEMP | Executed PASS; exact frozen identity present. |
| S1-074-DIRECT-BATCH | Executed PASS; exact frozen identity present. |
| S1-080 | Executed PASS; exact frozen identity present. |
| S1-081 | Executed PASS; exact frozen identity present. |
| S1-084 | Executed PASS; exact frozen identity present. |
| S1-085 | Executed PASS; exact frozen identity present. |
| S1-086 | Executed PASS; exact frozen identity present. |
| S1-BND-ATT-STRONGLIKE | Executed PASS; exact frozen identity present. |
| S1-BND-ATT-SAT | Executed PASS; exact frozen identity present. |
| S1-BND-ATT-MIXED | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-GIFT-OFFER | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-GIFT-REQUEST | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-LOAN-OFFER | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-LOAN-REQUEST | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-REPAY-DIRECT | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-BFF-BENEFIT | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-RMRH-BENEFIT | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | Executed PASS; exact frozen identity present. |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | Executed PASS; exact frozen identity present. |
| S1-BND-REPAY-AMOUNT | Executed PASS; exact frozen identity present. |
| S1-BND-RESERVE | Executed PASS; exact frozen identity present. |
| S1-BND-NEED | Executed PASS; exact frozen identity present. |
| S1-BND-DECAY | Executed PASS; exact frozen identity present. |
| S1-BND-DEBT-DUE | Executed PASS; exact frozen identity present. |
| S1-BND-MARRIAGE-CARD | Executed PASS; exact frozen identity present. |
| S1-BND-FAVOUR-CARD | Executed PASS; exact frozen identity present. |
| S1-BND-FAVOUR-MEANING | Executed PASS; exact frozen identity present. |
| S1-BND-RESIDENCE-CARD | Executed PASS; exact frozen identity present. |
| S1-META-01 | Executed PASS; exact frozen identity present. |
| S1-META-02 | Executed PASS; exact frozen identity present. |
| S1-META-03 | Executed PASS; exact frozen identity present. |
| S1-META-04 | Executed PASS; exact frozen identity present. |
| S1-META-05 | Executed PASS; exact frozen identity present. |
| S1-META-07 | Executed PASS; exact frozen identity present. |
| S1-META-10 | Executed PASS; exact frozen identity present. |
| S1-META-11 | Executed PASS; exact frozen identity present. |
| S1-MUT-04 | Executed PASS; exact frozen identity present. |
| S1-MUT-13A | Executed PASS; exact frozen identity present. |
| S1-MUT-16 | Executed PASS; exact frozen identity present. |
| S1-MUT-17 | Executed PASS; exact frozen identity present. |
| S1-MUT-18 | Executed PASS; exact frozen identity present. |
| S1-MUT-19 | Executed PASS; exact frozen identity present. |
| S1-MUT-20 | Executed PASS; exact frozen identity present. |
| S1-MUT-21 | Executed PASS; exact frozen identity present. |
| S1-MUT-22 | Executed PASS; exact frozen identity present. |
| S1-MUT-23 | Executed PASS; exact frozen identity present. |
| S1-MUT-24 | Executed PASS; exact frozen identity present. |
| S1-MUT-26 | Executed PASS; exact frozen identity present. |
| S1-MUT-29 | Executed PASS; exact frozen identity present. |
| S1-MUT-31 | Executed PASS; exact frozen identity present. |
| S1-MUT-32 | Executed PASS; exact frozen identity present. |
| S1-MUT-33 | Executed PASS; exact frozen identity present. |
| S1-MUT-34 | Executed PASS; exact frozen identity present. |
| S1-MUT-35 | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-FIXTURE | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-KNOWLEDGE | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-ORACLE | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-FALLBACK | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-ITERATION | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-CALLFAVOR-MAP | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-REQUIRED-COVERAGE | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-MANIFEST-INTEGRITY | Executed PASS; exact frozen identity present. |
| S1-GLOBAL-CONFORMANCE | Preserved historical independent PASS; raw runner awaits independent review; does not certify IMP-0003. |
| S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION | Executed PASS; exact frozen identity present. |
| S2-002-KNOWNFACT-RETENTION | Executed PASS; exact frozen identity present. |
| S2-003-KNOWNFACT-PROVENANCE-CENSUS | Executed PASS; exact frozen identity present. |
| S2-004-RECOGNITION-DISTINCT | Executed PASS; exact frozen identity present. |
| S2-005-RECOGNITION-TRISTATE-LIFETIME | Executed PASS; exact frozen identity present. |
| S2-006-NO-PASSIVE-SYNC | Executed PASS; exact frozen identity present. |
| S2-007-NO-HISTORY-OMNISCIENCE | Executed PASS; exact frozen identity present. |
| S2-008-LOCALITY | Executed PASS; exact frozen identity present. |
| S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE | Executed PASS; exact frozen identity present. |
| S2-010-OWN-STATE-KNOWLEDGE | Executed PASS; exact frozen identity present. |
| S2-011-DIRECT-CLAIM-KNOWLEDGE | Executed PASS; exact frozen identity present. |
| S2-012-DIRECT-PARTICIPATION-KNOWLEDGE | Executed PASS; exact frozen identity present. |
| S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION | Executed PASS; exact frozen identity present. |
| S2-020F-FACT-COMMUNICATION-ACTION | Executed PASS; exact frozen identity present. |
| S2-020R-RECOGNITION-COMMUNICATION-ACTION | Executed PASS; exact frozen identity present. |
| S2-021F-COMMUNICATE-HELD-FACT | Executed PASS; exact frozen identity present. |
| S2-021R-COMMUNICATE-HELD-RECOGNITION | Executed PASS; exact frozen identity present. |
| S2-022F-NO-INVENTED-FACT | Executed PASS; exact frozen identity present. |
| S2-022R-NO-INVENTED-RECOGNITION | Executed PASS; exact frozen identity present. |
| S2-023F-FACT-COMMUNICATION-PROVENANCE | Executed PASS; exact frozen identity present. |
| S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE | Executed PASS; exact frozen identity present. |
| S2-024F-FACT-COMMUNICATION-INITIATIVE-COST | Executed PASS; exact frozen identity present. |
| S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST | Executed PASS; exact frozen identity present. |
| S2-025F-FACT-NO-FREE-BROADCAST | Executed PASS; exact frozen identity present. |
| S2-025R-RECOGNITION-NO-FREE-BROADCAST | Executed PASS; exact frozen identity present. |
| S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE | Executed PASS; exact frozen identity present. |
| S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE | Executed PASS; exact frozen identity present. |
| S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE | Executed PASS; exact frozen identity present. |
| S2-030-STALE-FACT-PERSISTS | Executed PASS; exact frozen identity present. |
| S2-031A-DIRECT-EVIDENCE-PRECEDENCE | Executed PASS; exact frozen identity present. |
| S2-031B-REPORT-EVENT-PRECEDENCE | Executed PASS; exact frozen identity present. |
| S2-032-MESSAGE-ARRIVAL-PERMUTATION | Executed PASS; exact frozen identity present. |
| S2-033-CANDIDATE-RECOGNITION-CONTESTED | Executed PASS; exact frozen identity present. |
| S2-040F-KNOWNFACT-CANDIDATE-GATE | Executed PASS; exact frozen identity present. |
| S2-040R-RECOGNITION-CANDIDATE-GATE | Executed PASS; exact frozen identity present. |
| S2-041-GATES-BEFORE-SCORING | Executed PASS; exact frozen identity present. |
| S2-042-SUBJECTIVE-TRACE | Executed PASS; exact frozen identity present. |
| S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION | Executed PASS; exact frozen identity present. |
| S2-044-OBJECTIVE-REVALIDATION-PRESERVED | Executed PASS; exact frozen identity present. |
| S2-045-PINNED-POLICY-NONCLAIM | Executed PASS; exact frozen identity present. |
| S2-050-EPISTEMIC-READ-NONINTERFERENCE | Executed PASS; exact frozen identity present. |
| S2-051-DETERMINISTIC-REPLAY | Executed PASS; exact frozen identity present. |
| S2-052-NONSEMANTIC-ITERATION-METAMORPHIC | Executed PASS; exact frozen identity present. |
| S2-053-ISOMORPHIC-ID-RENAMING | Executed PASS; exact frozen identity present. |
| S2-054-CACHE-NONAUTHORITY | Executed PASS; exact frozen identity present. |
| S2-055-CONFIGURATION-PROVENANCE | Executed PASS; exact frozen identity present. |
