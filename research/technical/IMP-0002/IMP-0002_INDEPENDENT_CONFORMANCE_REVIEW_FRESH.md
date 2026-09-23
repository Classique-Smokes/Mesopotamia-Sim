# IMP-0002 — Fresh independent conformance review

**Verdict: PASS. Promotion recommendation: PROMOTE.**

No material semantic, architectural, acceptance-coverage, fixture, oracle, regression, or scope defect was established for candidate `5a452078c845b8aa4cc2756f5638517dce87e6e8`. No semantic escalation is required. This recommendation applies to that exact candidate; it is not a merge or canonical-promotion record.

- Review date: 2026-09-23.
- Commission: `tasks/implementation/IMP-0002_INDEPENDENT_CONFORMANCE_REVIEW_FRESH_PACKET.md` on `tasks/imp-0002-independent-conformance-review-v1`.
- Candidate ref: `imp-0002-slice2-conformance-candidate-v1`.
- Candidate SHA: `5a452078c845b8aa4cc2756f5638517dce87e6e8`.
- Canonical parent: `71bddc045fb2079b4b10b97649c639b4ee20d0ba`, also the candidate's actual first parent.
- Implementation branch: `implementation/imp-0002-slice2-epistemic`, resolving to the same candidate SHA.
- Implementation PR: [#38](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/38).
- Return branch: `review/imp-0002-conformance-independent-return`, created directly from the candidate SHA. Its only added tracked file is this report.

## Independence and immutable review boundary

The workspace initially contained no repository. The reviewer cloned the requested task branch, read the review packet and repository instructions, verified the named remote refs, and detached HEAD at the exact candidate before executing any semantic tests. The review did not use a moving implementation checkout.

The implementation report, previous conformance report, previous execution record, and PR #38 narrative were not opened until after the reviewer completed the source/authority review, canonical commands, acceptance census, and independently authored public-boundary probes and recorded a provisional **PASS / PROMOTE** outside the repository. Those claims were then read only for corroboration. Generated row labels were checked against their actual scenario assertions and production source.

The tracked candidate tree was clean before and after all execution. No production file, test, accepted authority, or candidate documentation was edited. The canonical commands produced only ignored build and acceptance artifacts. The SDK installation and reviewer executable are outside the repository. No delegation or prior reviewer scratch code was used.

## Frozen authority identities

Git object identities were independently resolved from the candidate and frozen refs. A final `git ls-remote origin` repeated the candidate, implementation-head, and freeze-ref checks without moving any ref.

| Authority | Frozen ref | Freeze commit | Manifest Git blob at both freeze and candidate |
|---|---|---|---|
| `SFL-V0-S2-ACCEPTANCE-v1` | `sfl-v0-slice2-acceptance-v1` | `88f876298852553d6afca76e743a5a811ff9f0fd` | `e4872531cf780d51fa1863f2a0b87e2424a71b69` |
| `SFL-V0-S1-ACCEPTANCE-v1` | `sfl-v0-slice1-acceptance-v1` | `55377cc34b8bc3ccbf9cdf5029e9791dae965987` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |

Both freeze records were read and matched these identities. Neither manifest nor freeze record is changed by the candidate diff or this return. The executable catalog independently recomputes Git blob hashes, including the Slice-1 hash before its regression census.

Controlling material inspected: `AGENTS.md`, `00_START_HERE.md`, `plans/CURRENT_PHASE.md`, accepted `SPEC-SFL-0001` (especially §§5–7 and 9), all five accepted ADRs, the IMP-0002 implementation packet, both frozen manifests and freeze records, and the relevant canonical Recognition/Information, Response Decision, Determinism/Explainability and cross-cutting verification requirements. The Slice-2 manifest's bounded applicability takes precedence over importing later-slice fixture shapes from broader verification cards. Conceptual tablet material was not used as implementation authority.

## Canonical command execution

The machine initially had no .NET SDK. The reviewer installed the exact required SDK in `C:/Users/victo/AppData/Local/Temp/imp0002-review-tools/dotnet`, set the process PATH/DOTNET_ROOT, and left `global.json` unchanged. `dotnet --version` returned **10.0.401**. Host: Windows x64; C# 14; Microsoft Testing Platform as configured by the repository.

All four commands ran in order from the unchanged candidate root:

| Exact command | Observed result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | Exit 0; all three projects restored; no reported warning/error. |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | Exit 0; no findings and no edits. |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | Exit 0; **0 warnings, 0 errors**. |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | Exit 0; **9 passed, 0 failed, 0 skipped**; reported duration 16.370 seconds. |

Nine is the test-method count, not the obligation count. The locally regenerated acceptance output contains **13 executed/PASS Slice-2 scenario families**, **53 concrete world/subcase fixture records**, **46 REQUIRED rows executed/PASS**, **9 explicit DEFERRED rows**, and **18 exact Slice-1 regression bindings PASS**. The full Slice-1 runner separately reports 127 implementation-owned REQUIRED rows PASS; its external-conformance row remains explicitly outside coder self-certification. Its 33 DEFERRED, 3 N-A and 3 UNEXERCISED statuses remain intact.

Generated evidence was inspected under `artifacts/acceptance/`, particularly `slice2-results.json`, `slice2-cases.json`, `slice2-fixture-audit.json`, `slice2-regression-fixtures.json`, `slice2-oracle-audit.json`, and `slice1-results.json`. These are execution evidence, not semantic authority.

## Production and architecture findings

The exact parent-to-candidate diff changes 15 files: nine production C# files, runtime/test README files, two Slice-2 acceptance files, the CI artifact label, and the implementation report. Every modified production file and acceptance implementation was inspected. The report was inspected only after the independent provisional judgment. `VerificationAccess.cs` is unchanged; reviewer probes used neither of its friend-assembly names.

| Surface | Independent finding |
|---|---|
| `EpistemicState.cs` | Actor-indexed persistent facts, immutable DTOs, finite typed propositions, original evidence order, and appended delivery hops are explicit. Recognition is a separate discrete evidence-derived value. Initial evidence must have fixture provenance. No behavior-affecting recognition cache or event-sourced reconstruction exists. |
| `EpistemicExecution.cs` | Automatic acquisition is limited to own state, direct-party relations/claims and committed participation. Communication uses captured sender-held evidence and updates only its recipient on a detached copy. Provenance is preserved rather than inferred from global history. |
| `State.cs`, `Simulation.cs` | Objective and subjective snapshots remain separate. Public epistemic views are immutable and published at stable closure. The candidate referent is inert and explicitly live/nonlive; it creates no collective object or lifecycle. |
| `PersonalDecisionInputs.cs`, `Agency.cs` | Policy receives a bounded actor view, not `WorldSnapshot`, global History or another actor's epistemic store. Existing explicit Slice-1 laboratory observation inputs remain declared inputs. Communication accessibility is evaluated before score components. |
| `Decisions.cs`, `Execution.cs` | Positive claim references and valid counterparties are checked; absent held claims cannot bypass the gate through scripted proposals. Both communication kinds use the ordinary one-initiative pipeline. Receipt creates no response context or additional voluntary activation. Objective and held-evidence revalidation occurs immediately before commit. |
| `ResolutionDependencies.cs` | Detached epistemic projection extends existing dependency/fallback analysis. It does not replace the scheduler or introduce a social evidence winner rule. Detailed finding below. |
| Runtime documentation/configuration | `SFL-COMMUNICATION-LAB-v1` is explicitly a pinned laboratory preference. Actual semantic and decision records identify `SFL-S2-v1` separately from scenario configuration labels. No historical communication motivation is claimed. |
| CI | The only workflow change renames the uploaded evidence artifact. The canonical restore → format → build → test commands and pinned SDK remain unchanged. |

### Knowledge, ordering, and bounded Recognition

`AcquireInitialFacts` and `AcquireCommittedFacts` route direct updates through participant/direct-party boundaries. `Learn` adds accepted committed or failed participant outcomes while rejecting InvalidTerms as social knowledge. The bounded failure reasons do not expose unrelated resolver-private state. Co-residence, cycle closure, the existence of a world record, or an observer History entry does not broadcast that record to nonparticipants.

`Supersedes` compares underlying `EvidenceOrigin.Order`; delivery hop time, sender identity, evidence ID and collection position are not precedence inputs. The accepted newer-direct/older-information and newer-event-backed-report/older-report cases are separate. Incomparable Residence evidence remains held. The direct-debt and report-report scenarios exercise genuinely different provenance cases rather than relabeling a single test.

The one-C RG-01 witness was re-derived from SPEC §§6.3–6.5 and frozen manifest §7: fixed core, shared-residence evidence, connecting durable ties, support on two distinct cycles, and a second incomparable `Residence(P,D2)` report contradicting `Residence(P,D1)`. Recipient Recognition is production-derived after ordinary messages. No negative Recognition proposition, second-candidate equivalence, Household, formation result, or general conflict algebra is required. A nonlive C yields Unknown; live Recognized/Contested state retains while its evidence is unchanged. The static live flag is the bounded laboratory lifetime boundary, not a newly invented expiry/lifecycle rule.

Unrelated negative attitude and voluntary Decline are separately checked with unchanged C/evidence. They do not erase Recognition or create approval/obedience semantics. The reviewer also advanced the negative-attitude pair through the cycle-five decay boundary.

### ResolutionDependencies / scheduler finding

**PASS for the required bounded cases; no hidden semantic escalation found.** The original proposal-ID execution order, common decision snapshot, immediate revalidation, copied transactions and stable-cycle publication remain in place. `SharesEpistemicDependency` adds potential edges for recipient/sender interactions and direct-party state updates. Potential overlap alone does not authorize a fallback marker: detached alternative-order projection compares outcomes and resulting state before marking an actual consequential dependency.

Projection uses copied `WorldState`/`EpistemicState` and private synthetic event origins; it does not allocate live history IDs, publish hypothetical state, rerun personal policy, or change what an actor knows by inspection. Its result is a fallback disclosure set, not an evidence-precedence rule. `ProjectionKey` excludes technical evidence allocation/delivery ordinals while retaining factual propositions, source/route/event lineage, sender/recipient chains and Recognition status. The actual production evidence-order rule remains in `EpistemicRules.Supersedes`.

Two required contrasts were independently executed:

1. The RG-01 Recognition and incompatible Residence messages commute. Both proposal orders, reversed input enumeration, delivery in different cycles, and non-monotone isomorphic ID renaming yield **Contested**. Same-cycle outcomes have **no technical fallback marker**. IDs do not select a Recognition winner.
2. Repayment can invalidate a creditor's captured outgoing debt fact. If the message commits first, it may deliver the then-held fact; if repayment commits first, communication terminates as `InvalidatedAtResolution(PropositionNoLongerHeld)`. Both operations disclose the existing technical fallback. The original personal decision trace still records the communication selected from the common snapshot and is not rewritten as a refusal or a different choice.

The second case is real causal noncommutativity handled by the inherited resolution boundary, not a rule that later-arriving or smaller-ID Recognition evidence wins. The existing Slice-1 aggregate-capacity, enabler, residence, marriage and favour dependency controls also pass, including the multi-operation permutation cases. This review does not claim an exhaustive mathematical proof for arbitrary new action domains or unbounded populations.

## Fixture and oracle audit

**PASS.** The 53 serialized subcases expose concrete `InitialWorld`, epistemic prestate, candidate referents, proposals, policy inputs and final public outputs. Source inspection confirms that the writes are constructor inputs plus public execution. The generic `Writes` sentence in the output was not accepted in place of inspecting those actual values and scenario bodies.

| Executable family | Resolved setup/write boundary and independent oracle finding |
|---|---|
| AutomaticAcquisition | Ordinary six-person objective world with no initial epistemic seeds. Own state is read after construction; loan, communication, refusal, inability and malformed terms execute publicly. Debt/participation acquisition is not fixture-written. Literal balances, routes, event identities and bounded outcomes supply expectations. Covers KF-OWN, KF-DIRECT-CLAIM, KF-PARTICIPATION and KF-REPORT. |
| CommunicationF / CommunicationR | Seed only provenance-tagged sender evidence. Recipient starts without communicated evidence/Recognition. Separate F/R ordinary-policy executions assert selection, delivery provenance, whole-population privacy and one initiation; no recipient postcondition is supplied. |
| StaleResidenceAndLocality | Initial residences are objective setup. The initial report is acquired through communication; a public MoveResidence changes the actual home. Stale report equality and a disconnected control are independently compared. |
| DebtDirectPrecedence | Loan, old-report delivery, debt review and repayment execute through public boundaries. The delayed old report is compared against the genuinely newer direct debt fact. No expected-value call to the precedence helper. |
| ReportEventPrecedence | Explicit sender-held old/new debt reports with declared E1<E2 are allowed inherited prestate; sender acquisition is not claimed. Both delivery orders independently expect balance 6 and the E2 origin. |
| ExactRG01 | Positive sender's shared-residence/tie/two-cycle support bundle and negative sender's single incompatible Residence report are fixture inputs. Recipient final Contested is never initialized. Orders, later retention, inactive-C control and ID mapping are inspected. |
| RecognitionIndependentAttitudeAndRefusal | The independent attitude and Accept/Decline axes vary outside the fixed core/evidence. Both ordinary response outcomes execute. Recognition/evidence is compared before/after; no updater supplies the expected answer. |
| SubjectiveGatesAndTraces | Held/absent sender evidence and one irrelevant fact vary while objective setup stays equal. Tests do not inject generated candidates, scores or selections. Public candidate traces expose eligibility, absent scores and factual/Recognition provenance. Scripted absent claims and invalid recipient controls test world validation. |
| ReplayReadAndEnumeration | Declared input/evidence enumeration and observer reads are the only perturbations. Public state, epistemic state, history and decisions are compared; no production normalizer grades the result. Reviewer P11 additionally compares every objective collection. |
| StructuralBoundaryAndConfiguration | Ordinary objective setup only. Source review independently confirms the membrane, type separation, absence of an authoritative cache and truthful rules/profile labels; the acceptance string/reflection checks are supporting checks only. |
| SameCycleCommunicationBoundary | Scripted proposal order and ordinary-policy inputs drive delivery, no-reactivation and debt invalidation. Captured evidence comes from a real loan. Expected commutativity/fallback and invalidation are hand-authored, not obtained from the dependency classifier. |
| RecognitionEvidenceAdequacy | Removes one supporting input at a time; separately puts support on the same cycle; then obtains Contested through actual messages and inspects the unsafe communication gate and both Residence trace inputs. No positive result is fixture-written. |

The reviewed assertions never call the production recognition derivation, conflict/precedence helper, candidate generator, scorer, provenance classifier or trace builder as their expected-result oracle. `InvariantOracle` independently reconstructs material and reaction expectations from recorded effects and accepted constants. The checker source-string scan alone is insufficient proof, but manual dependency review confirms its claim. Test helpers that inspect public properties are observations, not surrogate semantic classifiers.

The candidate's ID-renaming witness adds an offset and therefore does not itself reverse relative ID order. The reviewer supplied a non-monotone mapping, including actor, dwelling, relation, evidence, candidate and fixture-event IDs, and independently varied sender/proposal order. The candidate's replay helper lists the objective collections exercised by that scenario; reviewer P11 compares all objective collections as an additional check. Neither limited comparison was mistaken for a universal invariance claim.

## REQUIRED Slice-2 row census

Each of the following **46/46** rows executed and passed, has substantive inspected assertions under its frozen fixture/oracle binding, and receives an independent PASS. F/R denotes separately executed factual and Recognition subcases, not one shared coverage label. The finding column records what was checked beyond the row label.

| Exact AcceptanceId | Result | Independent evidence assessment |
|---|---|---|
| S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION | PASS | Same objective setup, held/absent evidence pairs produce different communication accessibility. |
| S2-002-KNOWNFACT-RETENTION | PASS | Acquired Residence report remains across subsequent public cycles. |
| S2-003-KNOWNFACT-PROVENANCE-CENSUS | PASS | All four bounded categories observed; loan event, acquisition routes and communicated origin inspected. |
| S2-004-RECOGNITION-DISTINCT | PASS | Separate discrete Recognition DTO/evidence derivation; no confidence/attitude field substituting for status. |
| S2-005-RECOGNITION-TRISTATE-LIFETIME | PASS | Unknown/Recognized/Contested, missing-evidence ablations, nonlive C and live-state retention checked; P07–P09. |
| S2-006-NO-PASSIVE-SYNC | PASS | Public move changes objective home while uninformed holder retains the old report. |
| S2-007-NO-HISTORY-OMNISCIENCE | PASS | Policy membrane and direct acquisition paths source-reviewed; no policy History access. |
| S2-008-LOCALITY | PASS | Disconnected control actor retains equivalent fact meanings/routes after unrelated activity. |
| S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE | PASS | Both independent perturbations execute; P09 checks negative attitude/decay, P10 ordinary refusal. |
| S2-010-OWN-STATE-KNOWLEDGE | PASS | Own stock acquired from objective setup with OwnState route, no seeded result. |
| S2-011-DIRECT-CLAIM-KNOWLEDGE | PASS | Loan creates debt known to both direct parties and no bystanders. |
| S2-012-DIRECT-PARTICIPATION-KNOWLEDGE | PASS | Public commit/refusal/inability facts and same-cycle invalidation recorded for participants. |
| S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION | PASS | Literal bounded reasons, no invalid-term knowledge, no third-party leak; exact inherited privacy binding passes. |
| S2-020F-FACT-COMMUNICATION-ACTION | PASS | Ordinary pinned policy selects and commits factual communication; reviewer F case. |
| S2-020R-RECOGNITION-COMMUNICATION-ACTION | PASS | Same production action pipeline selects and commits Recognition; reviewer R case. |
| S2-021F-COMMUNICATE-HELD-FACT | PASS | Captured held fact delivered, with public outcome/evidence checks. |
| S2-021R-COMMUNICATE-HELD-RECOGNITION | PASS | Held Recognized bundle delivered and recipient interpretation derived. |
| S2-022F-NO-INVENTED-FACT | PASS | Missing evidence ID has no score or transmission; scripted bypass rejected; P01. |
| S2-022R-NO-INVENTED-RECOGNITION | PASS | Unknown Recognition has no score or transmission; scripted bypass rejected; P02. |
| S2-023F-FACT-COMMUNICATION-PROVENANCE | PASS | Original fixture/event evidence plus sender/recipient/delivery hop inspected; P03-F, P05/P06. |
| S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE | PASS | Supporting evidence retains origins and appended hops; full payload/source path inspected; P03-R. |
| S2-024F-FACT-COMMUNICATION-INITIATIVE-COST | PASS | One policy decision/proposal; a second scripted sender initiative is rejected independently. |
| S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST | PASS | Same independent initiative assertions for Recognition. |
| S2-025F-FACT-NO-FREE-BROADCAST | PASS | Every nonrecipient in six-person acceptance and eight-person reviewer populations checked. |
| S2-025R-RECOGNITION-NO-FREE-BROADCAST | PASS | Separate Recognition delivery checks every nonrecipient in both declared populations. |
| S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS | No response; already-active recipient does not activate again or use just-received evidence; P04-F. |
| S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS | Independent R receipt/common-snapshot checks; P04-R. |
| S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE | PASS | Same original Residence has distinguishable direct/communication routes and retained origin. |
| S2-030-STALE-FACT-PERSISTS | PASS | Old Residence remains after an unwitnessed move and another stable cycle. |
| S2-031A-DIRECT-EVIDENCE-PRECEDENCE | PASS | Genuine newer repayment evidence survives later old report; reviewer P05 isolates debt-review timing. |
| S2-031B-REPORT-EVENT-PRECEDENCE | PASS | Both orders end with the E2 debt balance/origin; P06 uses independent amounts/fixture. |
| S2-032-MESSAGE-ARRIVAL-PERMUTATION | PASS | Underlying order fixed while old/new report arrival reverses; accepted result unchanged. |
| S2-033-CANDIDATE-RECOGNITION-CONTESTED | PASS | Exact single-C Residence contradiction derives retained Contested; order-changing P07/P08 checks. |
| S2-040F-KNOWNFACT-CANDIDATE-GATE | PASS | Held/absent factual pair changes production eligibility with equal world; no injected candidates. |
| S2-040R-RECOGNITION-CANDIDATE-GATE | PASS | Recognized/Unknown pair plus Contested negative control changes production eligibility. |
| S2-041-GATES-BEFORE-SCORING | PASS | Inaccessible candidate has empty components and null FinalScore despite pinned 100 preference; P01/P02. |
| S2-042-SUBJECTIVE-TRACE | PASS | Separate factual and Recognition inputs; source serializes actual basis/provenance, including Contested residences. |
| S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION | PASS | Unrelated seeded Residence does not alter the eligible/chosen communication candidate. |
| S2-044-OBJECTIVE-REVALIDATION-PRESERVED | PASS | Invalid recipient rejected; same-cycle repayment invalidates captured sender evidence with prior decision intact; P12. |
| S2-045-PINNED-POLICY-NONCLAIM | PASS | README and profile source explicitly limit coefficients to laboratory selection. |
| S2-050-EPISTEMIC-READ-NONINTERFERENCE | PASS | Repeated observer reads preserve state/history; independent full-state P11 comparison. |
| S2-051-DETERMINISTIC-REPLAY | PASS | Same declared world/evidence/schedule yields identical objective, subjective, history and decisions; P11. |
| S2-052-NONSEMANTIC-ITERATION-METAMORPHIC | PASS | Declared collection/evidence/input reversals checked; RG-01 and same-cycle controls converge. |
| S2-053-ISOMORPHIC-ID-RENAMING | PASS | Offset acceptance pair supplemented by consistent non-monotone reviewer mapping; Contested retained. |
| S2-054-CACHE-NONAUTHORITY | PASS | Source inventory: facts/candidates/ID frontier are state; Recognition recomputes; no authoritative epistemic cache. |
| S2-055-CONFIGURATION-PROVENANCE | PASS | Active Slice-2 rules/profile are emitted and separately distinguished from caller scenario configuration. |

No REQUIRED row is missing, skipped, label-only, silently reclassified, or satisfied by a fixture-written result.

## Exact Slice-1 regression census

**18/18 exact bindings PASS.** Counts below are mapped scenario-family executions within the Slice-2 regression pass, not assertion or parameterized-subcase counts. Existing Slice-1 test/oracle source is unchanged in the candidate diff.

| Exact AcceptanceId | Executions | Result | Inspected basis |
|---|---:|---|---|
| S1-070 | 1 | PASS | Declined versus Unable with participant knowledge. |
| S1-GLOBAL-KNOWLEDGE | 1 | PASS | Direct-party outcomes, bounded reasons, nonparticipant exclusion. |
| S1-073 | 1 | PASS | No unrelated private stock in failure reason. |
| S1-098-CORE | 1 | PASS | Common snapshot, multiple responses, one personal initiative. |
| S1-105 | 1 | PASS | Personal Residence choice coexists with incoming response. |
| S1-085 | 2 | PASS | Observer equality and captured personal-input isolation. |
| S1-META-04 | 4 | PASS | Observer pairs and future-input/fault/recovery inspection. |
| S1-MUT-26 | 1 | PASS | Focused enabled/disabled observer control; no claim of an executed mutation. |
| S1-086 | 8 | PASS | Full generated candidate/score/subjective traces and hidden-world membrane controls. |
| S1-MUT-29 | 1 | PASS | Unselected and gated candidates remain in full trace. |
| S1-META-07 | 6 | PASS | Irrelevant display/private-world attributes and explicit observation boundaries. |
| S1-084 | 1 | PASS | Authorized structural no-derived-authority alternative plus immutable snapshot isolation. |
| S1-META-05 | 1 | PASS | Same authorized structural/rebuild alternative. |
| S1-MUT-24 | 1 | PASS | No behavior-affecting cache; stale-cache injection is not falsely claimed. |
| S1-META-03 | 1 | PASS | Disconnected actor addition preserves the relevant semantic projection. |
| S1-META-02 | 13 | PASS | Identity isomorphism plus declared fallback sensitivity/capacity permutations. |
| S1-GLOBAL-FALLBACK | 10 | PASS | Residence, marriage, material/favour/debt/enabler conflicts and commuting controls disclose appropriate fallback. |
| S1-GLOBAL-MANIFEST-INTEGRITY | 1 | PASS | Git blob hash, version, unique IDs and full 167-row classification census validated. |

The bodies checked include `PipelineScenarios`, `AgencyScenarios`, `CrossCuttingScenarios`, `RepairScenarios`, `RepairKnowledgeScenarios`, `RepairResolutionScenarios` and `RepairV3Scenarios`. The inherited structural and focused-control alternatives retain their frozen meanings; they are not relabeled as new mutation execution.

## Deferral census and scope

**9/9 remain DEFERRED**, with their frozen triggers preserved. Source inspection and public reviewer P13 found no implementation dependency on later-slice machinery.

| Exact AcceptanceId | Status and retained trigger | Scope finding |
|---|---|---|
| S2-D01-GENERAL-NONPARTICIPANT-OBSERVATION | DEFERRED; concrete accepted event-specific indirect-observation need. | No generic perception or co-residence synchronization; all required fixtures use allowed routes. |
| S2-D02-GENERAL-KNOWNFACT-CONFLICT-ALGEBRA | DEFERRED; future general incompatible factual-belief reconciliation. | Finite subject slots and frozen Residence witness do not create a universal algebra. |
| S2-D03-AUTONOMOUS-COMMUNICATION-MOTIVATION | DEFERRED; richer agency work. | Pinned policy only, explicitly documented. |
| S2-D04-TRUST-LYING-RUMOR-REPUTATION | DEFERRED; later Social Epistemic Dynamics/post-v0. | No trust, invented payload, rumor mutation or reputation state. |
| S2-D05-HOUSEHOLD-RECOGNITION-ACTION-GATES | DEFERRED; Slice 3/4 household/head substrate. | One inert C; no Household, warrants or mediated authority route. |
| S2-D06-ROLE-SUCCESSION-RECOGNITION | DEFERRED; Slice 4. | No head role, office occupancy or succession. |
| S2-D07-CHECKPOINT-SUBJECTIVE-STATE | DEFERRED; Slice 5. | Read-only snapshots are not a save/load/checkpoint implementation. |
| S2-D08-RICH-MEMORY-DECAY | DEFERRED; future epistemic/agency research. | Retention/order rules only; no invented memory-decay mechanism. |
| S2-D09-ROLE-CONDITIONED-SALIENCE | DEFERRED; future richer agency/attention work. | No role salience, planning or strategic communication. |

No household provision, lineage, brokerage, stochastic choice, generic graph/ontology framework, concurrent execution or persistent collective lifecycle was introduced or needed for public Slice-2 behavior.

## Reviewer-owned scratch probes

Separate executable: `C:/Users/victo/AppData/Local/Temp/imp0002-fresh-review/FreshReview.csproj`; source: `Program.cs` in that directory. It directly references the candidate's already-built Release DLL, has its own assembly name, and uses only public constructors, public `RunCycle` and immutable observations. It imports no acceptance project or internal helper. Nothing from this probe project is committed to the candidate/return branch.

Command: `dotnet run --project C:/Users/victo/AppData/Local/Temp/imp0002-fresh-review/FreshReview.csproj --configuration Release` with the same SDK environment. Final exit code: **0**. Result: **143 assertions PASS in 12 executable cases**, covering all **13 mandatory probe areas** (some related areas are combined and F/R are independent cases).

The independent recognition fixture uses eight people and a three-person core, seven positive evidence items and one incomparable Residence contradiction. The non-monotone actor mapping is `1→810, 2→120, 3→730, 4→240, 5→650, 6→360, 7→570, 8→480`; all relevant references and other identifier domains are renamed consistently. The paired case also reverses positive evidence/core enumeration. Same-cycle proposal-ID swaps independently reverse sender order. No renaming changes semantic event cycles or evidence dominance.

| Reviewer case | Assertions | Setup and substantive checks |
|---|---:|---|
| P01 — absent fact | 5 | No held evidence; gate/score/selection/transmission checks plus scripted bypass and response rejection. |
| P02 — absent Recognition | 5 | Live C without supporting evidence; independent Recognition version of P01. |
| P03/P04 — factual delivery/initiative | 17 | Held Residence; sender and recipient both have policy contexts; eight-person recipient-only check, origin/hop, actual trace basis, no response/second activation, double-initiation rejection. |
| P03/P04 — Recognition delivery/initiative | 17 | Seven-item held bundle; same independent R assertions, including common-snapshot recipient gate. |
| P05 — later old report/new direct | 4 | Real 9-grain loan, old report retained by third actor, later repayment to balance 6, then delayed old report; balance and real event provenance retained. |
| P06 — report event precedence | 6 | Independent 9→4 debt reports with E1<E2; both delivery orders preserve E2 balance, origin/order and sender. |
| P07/P08 — RG-01 order/rename/enumeration | 65 | Eight combinations of ID mapping, order/enumeration and same/different-cycle delivery; recipient initially Unknown, final retained Contested, both Residence reports kept, no artificial dominance/fallback, Contested gate and nonlive-C control. |
| P09 — negative unrelated attitude | 5 | Separate baseline/−88 attitude pair through five cycles; unchanged Recognized evidence including decay boundary. |
| P10 — unrelated ordinary refusal | 5 | Accepted lower-level request with independent Accept/Decline policies; both actual outcomes checked and identical Recognition evidence. |
| P11 — inspection noninterference/replay | 3 | Four runs varying reads/enumeration; exact equality across all objective collections, epistemic state, history, decisions and participant outcomes. |
| P12 — same-cycle sender invalidation | 8 | Both repayment/message orders; stale send invalidates, real dependency is marked, original subjective selection/history remains, recipient receives no invalid debt fact. |
| P13 — no later substrate | 3 | Public one-C behavior executes; exported type and actual event inspection reveals no household/head/checkpoint/trust/reputation/formation/lineage substrate. |

One initial P05 assertion incorrectly required exactly unchanged provenance while delivery coincided with the legitimate cycle-N+3 debt due review. The balance assertion already passed; the review event legitimately refreshed the direct fact. The reviewer moved the due review before repayment so the isolated delayed-report case has no independent concurrent provenance update. The corrected setup passes all four assertions. This was a reviewer-fixture confound, not a candidate repair or a removed semantic requirement. No other probe failed.

Reproducibility identities (SHA-256):

- Final `Program.cs`: `bb51e2bc9f9d3d5810de2f5da90274274a39223b3744f57eb2f0a4de7ad37b7b`.
- `FreshReview.csproj`: `fd7dfa2c3fbfc44028fe4f4ed016c3e881dafd77fd07c2ab6aead216197ce155`.
- Final `bin/Release/net10.0/fresh-probe-results.json`: `8704ee215d09fd8494cfe5b7dafa95d30eea3248deeed994f7749c2b84c4b50a`.

The scratch source/results and pre-corroboration provisional note remain outside the repository at the stated local paths. This report deliberately does not claim that uncommitted local scratch files are a downloadable GitHub artifact. The setup, commands, assertion counts, findings and file hashes above identify the reviewer execution.

## Post-judgment corroboration of prior claims

Only after recording the provisional independent PASS, the reviewer inspected the implementation report at the candidate and the prior conformance report/execution record on `review/imp-0002-conformance-v1`. Their command results, row census, deferrals and bounded-scope claims agree with this review's independent findings. The previous 51-assertion review was not counted among this review's 143 assertions and was not used to substitute for any mandatory probe.

GitHub API inspection independently confirmed:

- PR #38 remains open/draft and unmerged, with head `5a452078c845b8aa4cc2756f5638517dce87e6e8` and base `71bddc045fb2079b4b10b97649c639b4ee20d0ba`.
- Candidate-associated [canonical CI run 35828653126](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35828653126) is completed/success.
- Its unexpired `sfl-slice1-slice2-acceptance-evidence` artifact is ID `10736450597`, 370,778 bytes, reported digest `sha256:d45240304b46df405fe2406124f3af5ad5145a66c2e95ad32e7c4f920d54a1f3`; artifact metadata identifies the exact candidate SHA.

This verifies remote run/artifact metadata. The reviewer did not download that archive or claim to recompute its digest. Local independent execution is the primary command evidence. No discrepancy requiring repair was established by the comparison.

## Final classification and promotion recommendation

**PASS — PROMOTE `5a452078c845b8aa4cc2756f5638517dce87e6e8`.**

The exact identities, all four canonical commands, all 46 REQUIRED Slice-2 obligations, all 18 exact Slice-1 regression bindings, nine preserved deferrals, concrete fixture/oracle boundaries, scheduler/dependency constraints and all 13 requested public probe areas were checked. No implementation/verification blocker or missing consequential semantic decision was established. **Semantic escalation: none. Repair scope: none required by this review.**

This is a bounded conformance judgment for the frozen candidate, not authorization for later-slice behavior or a guarantee about arbitrary future extensions. Promotion/merge is a separate action; this return changes only this report.
