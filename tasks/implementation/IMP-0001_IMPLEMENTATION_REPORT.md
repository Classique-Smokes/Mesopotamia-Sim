# IMP-0001 — Implementation return

**IMPLEMENTATION CANDIDATE COMPLETE / AWAITING INDEPENDENT CONFORMANCE**

Coder-owned implementation and verification obligations are complete. This is not VERIFIED COMPLETE. The packet's full-completion status remains **INCOMPLETE pending fresh independent conformance**, with REQUIRED `S1-GLOBAL-CONFORMANCE` explicitly awaiting that review. No independent PASS is awarded here. SCF-002 remains active.

## Repository and frozen authority

- Context: PROJECT-CONTEXT; repository authority retrieved through `AGENTS.md`, `00_START_HERE.md`, `plans/CURRENT_PHASE.md`, dispatch, execution handoff, and IMP-0001, then the accepted decisions/ADRs/specification and verification/engineering inputs listed by that packet.
- Repository: `Classique-Smokes/Mesopotamia-Sim`; local checkout `C:\Users\victo\Documents\GitHub\MESOPOTAMIA_SIMULATION`.
- Branch: `implementation/imp-0001-slice1`; upstream `origin/implementation/imp-0001-slice1`.
- Origin: `https://github.com/Classique-Smokes/Mesopotamia-Sim.git`.
- Existing [PR #7](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/7) remains draft. No competing branch, main edit, merge, or ready-for-review action.
- Manifest: `SFL-V0-S1-ACCEPTANCE-v1`, file `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`.
- Frozen ref: `origin/sfl-v0-slice1-acceptance-v1`.
- Freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`.
- Manifest blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`.

The initial checkout was clean and synchronized before domain work. At final source verification, a fresh `git fetch origin` confirmed the branch upstream at the previous milestone; the frozen ref still resolves to the stated commit. HEAD, frozen-ref, and working-tree content under Git filters all return the exact manifest blob above. The manifest is unchanged, with 167 IDs: 128 REQUIRED, 33 DEFERRED, 3 N-A, 3 UNEXERCISED. The original bootstrap smoke test maps to zero AcceptanceIds.

The candidate revision is the implementation-branch commit containing this report. Source identity is listed below to avoid a self-referential report commit hash. The final handoff records the exact pushed commit and its canonical CI run after that run completes. Final handoff requires a clean tree and zero ahead/behind divergence.

## Implemented system and changed surfaces

- `src/Mesopotamia.Sim/State.cs`: distinct immutable IDs and records, authoritative typed dictionaries, reference/cardinality validation, immutable materialized snapshots, explicit identifier state and current-state queries without derived caches.
- `Simulation.cs`, `Execution.cs`: fixed-population deterministic cycles, declared exogenous inputs, consumption/need, Farm, decay, common snapshot, personal proposals and responses, precommit revalidation, complete transactional action effects, debt social-due review, deduplicated sum-then-clamp attitude closure, stable publication, explicit deadlock and terminal failure handling.
- `Decisions.cs`: typed explicit transfer/loan/debt/favour/marriage/residence action meanings; integral positive terms; response/result separation; bounded participant outcomes; causal event and component trace records. Only Farm and RepayDebt are callable.
- `Agency.cs`: production context-sensitive candidate generation, exact checked integer component scoring, canonical personal and response profiles, stable fallback disclosure, closed-loop autonomous entry. Repayment's creditor is a scoring target without requiring a new response context. Default concerns include need, grain, debt, relations, marriage, and co-residence.
- `VerificationAccess.cs`: narrowly internal reaction challenge access for test assemblies; no public state mutation API.
- `tests/Mesopotamia.Sim.Tests/`: identity, snapshot, reference, maintenance and need tests; existing tooling smoke retained.
- `tests/Mesopotamia.Sim.AcceptanceTests/`: manifest catalog, deterministic named cases, all nine grain ingress matrices, independent invariant replay, fixture/oracle audits, fault controls and complete result reporting. Source and test README files document entry points and evidence interpretation.
- `.gitattributes`: C# LF checkout policy matching the existing formatter. `.github/workflows/ci.yml`: uploads ignored generated acceptance evidence even when tests fail. Existing strict analyzers, nullable checks and canonical commands remain enabled.
- This required implementation report is the durable evidence index. Generated reports, SDK binaries, installer/log files and toolchain payloads are not tracked.

The cycle order is scheduled inputs → maintenance/decay → common decision snapshot → personal deliberation → responses → central resolution/revalidation/atomic commit or failure → debt due review → direct attitude closure → stable publication. Earlier voluntary decisions never reopen after commits. Fulfilment is response-scoped and coexists with the called actor's selected personal initiative. Residence is limited to one committed transition per person/cycle. Technical IDs do not supply social priorities.

## Toolchain and exact command results

SDK **10.0.401** was installed using the official Microsoft install script with explicit `-InstallDir` and `-NoPath`, outside the repository at:

`C:\Users\victo\Documents\Codex\2026-09-22\github-plugin-github-openai-curated-remote\work\dotnet-sdk-10.0.401`

Installer and logs are in the same external task workspace. SDK discovery is process-local (`DOTNET_ROOT` and process PATH); no persistent environment or repository environment files were created. Local logs are `work/milestone1.log` through the milestone logs in that external task workspace; final source verification is `work/milestone9.log`. Reproducible remote command logs and generated evidence are available through the CI links below.

Every coherent milestone used this exact root sequence:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Final local results: restore PASS (exit 0), format verification PASS (exit 0), Release build PASS (exit 0, zero warnings/errors), test PASS (exit 0). Eight MSTest methods passed, zero failed/skipped. The acceptance aggregate executes **39 named scenarios / 167 audited world instances**, with explicit parameterized subcase evidence; eight runner methods must not be confused with eight semantic cases. All **127 coder-owned REQUIRED rows PASS**. The remaining REQUIRED external review row is pending. All 39 non-required rows retain their frozen classifications separately.

Tested source/configuration identity (SHA-256 over ordinal-path-ordered `path + space + Git-filtered blob SHA`, newline joined, covering tracked `src`, `tests`, `.github`, `.gitattributes`, `Directory.Build.props`, `global.json`, and solution):

`ec67edbf2ec93e6e446fced68edf2fbc8ceae43664396ab62ec6a638c3f79b02`

| Milestone | Commit | Canonical local result | Observed canonical CI |
|---|---|---|---|
| 1. State/evidence | `c5b6bd8` | PASS, 5 tests | [PASS 35689425927](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35689425927) |
| 2. Maintenance/Farm | `f0271b9` | PASS, 8 tests | [PASS 35689473407](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35689473407) |
| 3. Proposal/response/commit | `82516f1` | PASS, 28 required rows | [PASS 35689766352](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35689766352) |
| 4. Gift/help/loan/debt | `f559c81` | PASS, 41 required rows | [PASS 35689966056](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35689966056) |
| 5. Favours/bargains | `5ae8c70` | PASS, 69 required rows | [PASS 35690260519](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35690260519) |
| 6. Marriage/residence | `1d54187` | PASS, 92 required rows | [PASS 35690505528](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35690505528) |
| 7. Autonomous agency | `e35f967` | PASS, 98 required rows | [PASS 35690930667](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35690930667) |
| 8. Cross-cutting evidence | `4249b48` | PASS, 127 coder-owned required rows | [PASS 35691944162](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35691944162) |
| 9. Candidate/source audit | commit containing this report | PASS, 127 coder-owned required rows | final exact-revision run checked at handoff; see PR #7 |

## Invariants, metamorphic evidence and fault controls

Production reference/cardinality validation runs at maintenance and commit boundaries. `InvariantOracle` independently replays each stable history from its declared initial state: per-event material continuity, no unexplained source/sink, nonnegative grain, repayment reserve and remaining balance, origin references, monotone reaction positions, resolved predecessor IDs, unique attitude causes, signed cause sums and one clamp, periodic decay, one residence commit per person/cycle, relation cardinality and score sums/selection. Corrupted grain and attitude witnesses must fail this checker.

Metamorphic comparisons cover repeated runs, reversed storage/input enumeration, identity isomorphism, disconnected actors, enabled/disabled and reversed observer reads, irrelevant display-name changes, direct-cause permutation, and residence-contender permutation. Full state/history/decision/knowledge comparison is used where IDs are fixed; ID-renamed and disconnected comparisons normalize only presentation/renaming differences and assert local semantic facts. The +95 case yields +85 from +10/-20; the negative case yields -100 from -95/+10/-20. Each contribution appears once with the full predecessor set. Debt-due and gift consequences also compose in one batch. Stable-ID sensitivity is deliberately demonstrated for symmetric residence contenders; a feasibility asymmetry removes fallback. Meaningful score asymmetry selects VP-002's gift without fallback. Three-way aggregate scarcity also discloses fallback.

MaterialDeadlock has an all-needy/no-grain case, a valid transferable-grain negative control, and a future-input negative control. The kernel creates no rescue grain. Snapshot isolation is tested by retaining prior immutable views across real commits. No behavior-affecting derived cache exists: the structural field inventory contains only authoritative collections and the identifier counter; queries scan current snapshots. There is no household identity/membership field.

Frozen manifest Part G expressly permits focused negative tests, fault injection, or structural evidence. These routes remain distinct:

| Fault control | Route and observed result |
|---|---|
| MUT-04 / MUT-13A | Kinship cannot waive stored +75 gates; repayment resulting stock 1/2/3 rejects only the below-reserve case. Focused negative tests PASS. |
| MUT-16/17/18/19/20/21 | Shared-snapshot scarce-grain conflicts, distinct terminal outcomes, no false refusal penalty, bounded direct-participant knowledge, no retry, reversed contender enumeration and three-way scarcity. Focused negative tests PASS. |
| MUT-22 | Actual duplicate automatic-cause injection: **detected**, one contribution and explicit duplicate-rejected diagnostic. |
| MUT-23 | Actual closure suppression: **detected** by exact `PendingAutomaticReactions` guard, unchanged published cycle and prohibited continuation. This specifically asserted semantic guard is not arbitrary crash credit. |
| MUT-24 | **invalid/equivalent** for stale-cache injection because no behavior-affecting cache exists; authorized structural alternative PASS. |
| MUT-26 | Optional-reader enabled/disabled comparison PASS. Production mutant injection **unexercised**; no claim of an injected mutant being killed. |
| MUT-29 | Generated eligible/excluded alternatives, exact components and chosen candidate all retained; full vocabulary and repayment-target checks. Focused negative control PASS. |
| MUT-31 | Sequential-clamp result witnesses (+80/-90) are **detected** by independent replay; production cause-order permutation and +85/-100 expectations PASS. This is a witness challenge, not a claim of patching the production clamp. |
| MUT-32/33/34/35 | Residence double-commit conflicts; all invalid grain ingress/over-repayment controls; non-callable/nested response and failure-consumption controls; full/racing BFF slot atomicity. Focused negative tests PASS. |

For fault classes covered only by focused scenarios, mutation-framework execution remains **unexercised**. `fault-controls.json` records that distinction for every MUT row and retains the vocabulary detected/survived/unexercised/invalid-equivalent/crash/timeout. No observed crash or timeout was credited as semantic detection. No generated-history, shrinking or held-out result is claimed.

## Fixture audit

`FixtureAudit.Create` records each actual world setup; `AuditCase` independently verifies its completed history and emits `fixture-audit.json`. Each of the 167 instances identifies the scenario/subcase, exact initial people/grain/need/sex, dwellings/residence, directed attitudes, initial kinship/marriage, scheduled grain inputs, configuration/profiles, submitted proposal terms, and fallback markers. Fixture facts are explicitly distinguished from endogenous committed-event provenance.

Prerequisite debt/favour histories are established through earlier legal Loan/BFF/RMRH commits, not direct setters. Mechanism fixtures submit typed proposals and valid responses through the public pipeline. Autonomous scenarios bind profiles and permitted observations, not generated candidates, scores or winners. The corrupt result witnesses are detached immutable copies passed only to the checker; they never enter the simulation as authoritative state. No tested marriage/residence/attitude/material result is fixture-written. Initial kinship/marriage in scoring controls is declared prerequisite state, not an asserted endogenous result.

## Oracle-independence audit

- `InvariantOracle.cs` depends on immutable schemas, recorded history, MSTest assertions, explicit fixed deltas and ordinary arithmetic/LINQ. The executable dependency audit rejects references to `ActionRules`, `PersonalAgency`, `ReferenceScorer`, `WorldState`, simulation execution or transition helpers inside this checker.
- `*Scenarios.cs` invokes `Simulation` only as the target. Expected stocks, balances, event counts, outcomes, thresholds, response scores and kinship/co-residence components are hand-authored. Convenience snapshot queries are cross-checked by raw-record ledger replay, rather than used to certify their own implementation.
- `CompleteCallFavorPayloadMatrix` transcribes the frozen two-callable/eleven-non-callable table. It does not invoke the production applicability classifier as an oracle. Non-integral public terms are structurally unrepresentable because each relevant quantity property is `long`, with no coercing semantic ingress.
- `CrossCuttingScenarios` compares paired runs and explicit independent arithmetic. Wrong ledger/result witnesses demonstrate that the independent checker can reject semantically incorrect evidence.
- `AcceptanceCatalog` reads and hashes the immutable external manifest; it does not author expected social results. Reporting cannot convert a missing REQUIRED row into PASS. Scenario failures combine conservatively across every ID they cover.

This is an implementation-owned dependency/source audit, not the fresh external conformance review required by K4.

## Assumptions, discretion, deviations and remaining authority

Applied accepted laboratory assumptions: ASM-0001 reciprocity threshold; ASM-0002 fixed attitude deltas/composition/decay; ASM-0003 grain/repayment reserve; ASM-0004 exact kin amplification; applicable ASM-0007 timing/residence/fallback; ASM-0008 debt due; ASM-0012/0013 exact personal/response scoring; ASM-0014 integral positive action terms. Coefficients and default preferences are explicitly versioned laboratory configuration, not historical calibration. Household assumptions remain unused.

Local engineering choices: immutable records and typed IDs; copied transactional dictionaries; `long` grain with checked arithmetic; deterministic ordinal candidate keys; one MSTest manifest runner with per-case/per-ID output. Reciprocal-help terms explicitly distinguish donor offer versus recipient request while preserving accepted donor/recipient meaning and response autonomy. This allows the canonical BFF race with one initiative per actor. No general negotiation or new favour mechanism is introduced.

Dependency ordering deviations: the minimal commit primitive entered milestone 2 for Farm/maintenance; gift/help entered milestone 3 to substantively exercise the proposal pipeline before debt. The initial scaffold's Windows CRLF checkout violated its existing LF formatter policy; a C#-only `.gitattributes` repair restored canonical verification without changing frozen Markdown. Final audit added aggregate scarce-grain fallback disclosure and repayment scoring-target coverage. These are implementation repairs, not changed authority.

No semantic/architectural escalation was required and no accepted authority was changed. No unresolved coder-owned Slice-1 issue is known from the executed evidence. Arithmetic/runtime faults stop the affected simulation and retain the previous published state; there is no recovery/checkpoint promise. Full generated histories, shrinking and held-out tests remain visibly UNEXERCISED. Independent review may identify further defects; this report does not preempt that result.

Required next authority step: the Master Architect commissions a fresh reviewer who did not author this code, verifies K4 and the frozen rows, and records the independent conformance result. Only then may `S1-GLOBAL-CONFORMANCE` pass and SCF-002's retirement condition be considered. Later household/recognition/communication/checkpoint work requires its own scoped packet; no particular Slice-2 design is decided or implemented here.

## Durable acceptance index

The following tables are derived from actual final local assertion results. Exact frozen source clauses are retained in `slice1-results.json` and each case's `cases.json` entry. Scenario names below locate executable assertions in the acceptance project; the case-to-file index follows. CI publishes `slice1-acceptance-evidence` with all reports even on available failing runs. Generated artifacts stay outside tracked source.

### REQUIRED

| AcceptanceId | Frozen classification | Execution state | Evidence / retained rationale |
|---|---|---|---|
| S1-090-A | REQUIRED | PASS | ConsumptionAndFarm |
| S1-090-B | REQUIRED | PASS | ConsumptionAndFarm |
| S1-090-C | REQUIRED | PASS | ConsumptionAndFarm |
| S1-090-D | REQUIRED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-090-E | REQUIRED | PASS | ConsumptionAndFarm |
| S1-091-GIFT | REQUIRED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-091-HELP | REQUIRED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-091-LOAN-OFFER | REQUIRED | PASS | LoanRoutesAndRepaymentHistory |
| S1-091-LOAN-REQUEST | REQUIRED | PASS | LoanRoutesAndRepaymentHistory |
| S1-091-BFF-POS | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-091-RMRH | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-091-MEANING-SEPARATION | REQUIRED | PASS | DistinctTransferMeanings |
| S1-092-PARTIAL | REQUIRED | PASS | LoanRoutesAndRepaymentHistory |
| S1-092-AMOUNT-VALIDITY | REQUIRED | PASS | RepaymentAmountAndReserve |
| S1-092-RESERVE | REQUIRED | PASS | RepaymentAmountAndReserve |
| S1-092-FULL | REQUIRED | PASS | LoanRoutesAndRepaymentHistory |
| S1-092-DUE | REQUIRED | PASS | DebtDueAfterThirdFullCycle |
| S1-093-BFF-POS | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-74 | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-75 | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-76 | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-KIN-GATE | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-GIFT-CONTROL | REQUIRED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-093-BFF-FULL | REQUIRED | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-093-BFF-RACE | REQUIRED | PASS | BargainCapacityRace |
| S1-093-RMRH-FULL | REQUIRED | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-094-FARM-CALLABLE | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-REPAY-CALLABLE | REQUIRED | PASS | CalledRepaymentThirdPartyAndInvalidation |
| S1-094-PERSONAL-COEXIST | REQUIRED | PASS | CalledFarmPersonalCoexistence |
| S1-094-NONCALLABLE-MATRIX | REQUIRED | PASS | CompleteCallFavorPayloadMatrix |
| S1-094-NONPAYLOAD-MATRIX | REQUIRED | PASS | CompleteCallFavorPayloadMatrix |
| S1-094-UNABLE | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-DECLINE | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-INVALIDATED | REQUIRED | PASS | CalledRepaymentThirdPartyAndInvalidation |
| S1-094-SUCCESS | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-NESTED-GUARD | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-RECIP-CANCEL | REQUIRED | PASS | ReciprocalCancellation |
| S1-095-POS | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-095-74 | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-095-KIN | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-095-LIFETIME | REQUIRED | PASS | MarriageDeclineAndLifetime |
| S1-095-NO-RESIDENCE | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-096-MOVE | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-096-INVITE | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-096-COMPETE | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-096-NO-HH | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-096-MARRIAGE-CONTROL | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-097-EVENTS | REQUIRED | PASS | FixedAttitudeEventMatrix |
| S1-097-SAT | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DIRECT-BATCH-POS | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DIRECT-BATCH-NEG | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DECAY | REQUIRED | PASS | DecayBoundaries |
| S1-098-CORE | REQUIRED | PASS | SharedSnapshotScarceGrain |
| S1-098-CALLFAVOR-INIT | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-099-KIN | REQUIRED | PASS | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace |
| S1-099-CORES | REQUIRED | PASS | CoResidenceMotivationWithoutCompulsion |
| S1-100 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-101 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-102 | REQUIRED | PASS | CalledFarmSuccessRefusalAndInability |
| S1-103-GRAIN | REQUIRED | PASS | SharedSnapshotScarceGrain |
| S1-103-RESIDENCE | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-105 | REQUIRED | PASS | PersonalResidenceAndIncomingResponse |
| S1-070 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-071 | REQUIRED | PASS | SharedSnapshotScarceGrain |
| S1-073 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-074-IDEMP | REQUIRED | PASS | DuplicateReactionAndPrematureClosure |
| S1-074-DIRECT-BATCH | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-080 | REQUIRED | PASS | MaterialDeadlockAndNegativeControls |
| S1-081 | REQUIRED | PASS | StableFallbackSensitivityAndSemanticAsymmetry |
| S1-084 | REQUIRED | PASS | NoDerivedAuthorityStructuralAudit |
| S1-085 | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-086 | REQUIRED | PASS | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace |
| S1-BND-ATT-STRONGLIKE | REQUIRED | PASS | DirectMarriageBoundaries |
| S1-BND-ATT-SAT | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-BND-ATT-MIXED | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-D4-GRAIN-GIFT-OFFER | REQUIRED | PASS | GiftGrainIngress |
| S1-D4-GRAIN-GIFT-REQUEST | REQUIRED | PASS | GiftGrainIngress |
| S1-D4-GRAIN-LOAN-OFFER | REQUIRED | PASS | LoanGrainIngress |
| S1-D4-GRAIN-LOAN-REQUEST | REQUIRED | PASS | LoanGrainIngress |
| S1-D4-GRAIN-REPAY-DIRECT | REQUIRED | PASS | RepaymentAmountAndReserve |
| S1-D4-GRAIN-BFF-BENEFIT | REQUIRED | PASS | BenefitGrainIngress |
| S1-D4-GRAIN-RMRH-BENEFIT | REQUIRED | PASS | BenefitGrainIngress |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | REQUIRED | PASS | MarriageDowryIngress |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | REQUIRED | PASS | NestedRepaymentIngress |
| S1-BND-REPAY-AMOUNT | REQUIRED | PASS | NestedRepaymentIngress |
| S1-BND-RESERVE | REQUIRED | PASS | RepaymentAmountAndReserve |
| S1-BND-NEED | REQUIRED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-BND-DECAY | REQUIRED | PASS | DecayBoundaries |
| S1-BND-DEBT-DUE | REQUIRED | PASS | DebtDueAfterThirdFullCycle |
| S1-BND-MARRIAGE-CARD | REQUIRED | PASS | MarriageDeclineAndLifetime |
| S1-BND-FAVOUR-CARD | REQUIRED | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-BND-FAVOUR-MEANING | REQUIRED | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-BND-RESIDENCE-CARD | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-META-01 | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-META-02 | REQUIRED | PASS | IdentityIsomorphismAndDisconnectedLocality |
| S1-META-03 | REQUIRED | PASS | IdentityIsomorphismAndDisconnectedLocality |
| S1-META-04 | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-META-05 | REQUIRED | PASS | NoDerivedAuthorityStructuralAudit |
| S1-META-07 | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-META-10 | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-META-11 | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-MUT-04 | REQUIRED | PASS | ExplicitBargainAndReciprocalHelp |
| S1-MUT-13A | REQUIRED | PASS | RepaymentAmountAndReserve |
| S1-MUT-16 | REQUIRED | PASS | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault |
| S1-MUT-17 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-MUT-18 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-MUT-19 | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-MUT-20 | REQUIRED | PASS | SharedSnapshotScarceGrain |
| S1-MUT-21 | REQUIRED | PASS | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault |
| S1-MUT-22 | REQUIRED | PASS | DuplicateReactionAndPrematureClosure |
| S1-MUT-23 | REQUIRED | PASS | DuplicateReactionAndPrematureClosure |
| S1-MUT-24 | REQUIRED | PASS | NoDerivedAuthorityStructuralAudit |
| S1-MUT-26 | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-MUT-29 | REQUIRED | PASS | ExactKinScoringAndFullTrace |
| S1-MUT-31 | REQUIRED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-MUT-32 | REQUIRED | PASS | ResidenceMoveInviteAndConflict |
| S1-MUT-33 | REQUIRED | PASS | NestedRepaymentIngress |
| S1-MUT-34 | REQUIRED | PASS | CalledRepaymentThirdPartyAndInvalidation |
| S1-MUT-35 | REQUIRED | PASS | FullFavourSlotDistinguishesBargainFromHelp; BargainCapacityRace |
| S1-GLOBAL-FIXTURE | REQUIRED | PASS | fixture-audit.json: exact initial fields/inputs, endogenous provenance, profiles and proposal terms for every subcase |
| S1-GLOBAL-KNOWLEDGE | REQUIRED | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-GLOBAL-ORACLE | REQUIRED | PASS | oracle-audit.json; InvariantOracle.cs and explicit expected arithmetic in scenario source |
| S1-GLOBAL-FALLBACK | REQUIRED | PASS | ReferenceProfilesAndAutonomousCycle; StableFallbackSensitivityAndSemanticAsymmetry |
| S1-GLOBAL-ITERATION | REQUIRED | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-GLOBAL-CALLFAVOR-MAP | REQUIRED | PASS | CompleteCallFavorPayloadMatrix |
| S1-GLOBAL-REQUIRED-COVERAGE | REQUIRED | PASS | All 167 rows individually emitted; 127 coder-owned REQUIRED must pass; REQUIRED external conformance explicitly awaiting review |
| S1-GLOBAL-MANIFEST-INTEGRITY | REQUIRED | PASS | AcceptanceCatalog.Read: Git blob and census |
| S1-GLOBAL-CONFORMANCE | REQUIRED | AWAITING INDEPENDENT REVIEW | Fresh independent reviewer required; full completion gate unsatisfied |

### DEFERRED

| AcceptanceId | Frozen classification | Execution state | Evidence / retained rationale |
|---|---|---|---|
| S1-098-COMMUNICATION | DEFERRED | DEFERRED | General communication/claim propagation explicitly outside IMP-0001 |
| S1-104 | DEFERRED | DEFERRED | Requires Active Household/head/mediated-marriage substrate outside Slice 1 |
| S1-072 | DEFERRED | DEFERRED | Household provision outside Slice 1 |
| S1-075 | DEFERRED | DEFERRED | Card as written requires formation/recognition/Household substrate |
| S1-076 | DEFERRED | DEFERRED | General communication/recognition propagation outside Slice 1 |
| S1-082 | DEFERRED | DEFERRED | Checkpoint/save-load explicitly outside Slice 1 |
| S1-083 | DEFERRED | DEFERRED | Checkpoint outside Slice 1 |
| S1-087 | DEFERRED | DEFERRED | No rendered explanation surface required in Slice 1; causal predecessor truth remains required through history/086 |
| S1-BND-HOUSEHOLD-PROVISION | DEFERRED | DEFERRED | Household provision outside Slice 1 |
| S1-BND-PROVISION-RECONSIDERATION | DEFERRED | DEFERRED | Household provision/head reconsideration outside Slice 1 |
| S1-BND-FORMATION | DEFERRED | DEFERRED | Household formation outside Slice 1 |
| S1-BND-LINEAGE | DEFERRED | DEFERRED | Lineage outside Slice 1 |
| S1-META-06 | DEFERRED | DEFERRED | Checkpoint outside Slice 1 |
| S1-META-08 | DEFERRED | DEFERRED | Communication/recognition outside Slice 1 |
| S1-META-09 | DEFERRED | DEFERRED | Lineage outside Slice 1 |
| S1-MUT-01 | DEFERRED | DEFERRED | Household formation absent |
| S1-MUT-02 | DEFERRED | DEFERRED | Household formation absent |
| S1-MUT-03 | DEFERRED | DEFERRED | Household recognition absent |
| S1-MUT-05 | DEFERRED | DEFERRED | Household continuity absent |
| S1-MUT-06 | DEFERRED | DEFERRED | Household action absent |
| S1-MUT-07 | DEFERRED | DEFERRED | Participation absent |
| S1-MUT-08 | DEFERRED | DEFERRED | Formation absent |
| S1-MUT-09 | DEFERRED | DEFERRED | Lineage absent |
| S1-MUT-10 | DEFERRED | DEFERRED | Lineage absent |
| S1-MUT-11 | DEFERRED | DEFERRED | Provision absent |
| S1-MUT-12 | DEFERRED | DEFERRED | Household provision absent |
| S1-MUT-13B | DEFERRED | DEFERRED | Household provision absent |
| S1-MUT-14 | DEFERRED | DEFERRED | Head role absent |
| S1-MUT-15 | DEFERRED | DEFERRED | Head appointment absent |
| S1-MUT-25 | DEFERRED | DEFERRED | Checkpoint outside Slice 1 |
| S1-MUT-27 | DEFERRED | DEFERRED | Communication/recognition absent |
| S1-MUT-28 | DEFERRED | DEFERRED | Recognition absent |
| S1-MUT-30 | DEFERRED | DEFERRED | Rendered explanation surface outside Slice 1 |

### N-A

| AcceptanceId | Frozen classification | Execution state | Evidence / retained rationale |
|---|---|---|---|
| S1-BND-ATT-STRONGDISLIKE | N-A | N-A | No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-DISLIKE-NEUTRAL | N-A | N-A | No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-NEUTRAL-LIKE | N-A | N-A | No named Slice-1 categorical action gate depends on this band |

### UNEXERCISED

| AcceptanceId | Frozen classification | Execution state | Evidence / retained rationale |
|---|---|---|---|
| S1-SUP-GENERATED | UNEXERCISED | UNEXERCISED | Useful later for interaction breadth; B2 explicitly keeps generated-history infrastructure off the Slice-1 completion path |
| S1-SUP-SHRINK | UNEXERCISED | UNEXERCISED | Only relevant once generated histories are in use |
| S1-SUP-HELDOUT | UNEXERCISED | UNEXERCISED | Canonical/metamorphic/boundary evidence is sufficient for Slice 1; held-out materialization may occur after implementation path exists |

### Executable case source index

| Case | Source | Result |
|---|---|---|
| GiftHelpMeaningsAndNeedClearing | [PipelineScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs) | PASS |
| ResponseAutonomyAndBoundedFailureKnowledge | [PipelineScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs) | PASS |
| SharedSnapshotScarceGrain | [PipelineScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs) | PASS |
| GiftGrainIngress | [PipelineScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs) | PASS |
| LoanRoutesAndRepaymentHistory | [DebtScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs) | PASS |
| RepaymentAmountAndReserve | [DebtScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs) | PASS |
| DebtDueAfterThirdFullCycle | [DebtScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs) | PASS |
| LoanGrainIngress | [DebtScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs) | PASS |
| ExplicitBargainAndReciprocalHelp | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| FullFavourSlotDistinguishesBargainFromHelp | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| BargainCapacityRace | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| CalledFarmSuccessRefusalAndInability | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| CalledFarmPersonalCoexistence | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| CalledRepaymentThirdPartyAndInvalidation | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| ReciprocalCancellation | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| BenefitGrainIngress | [FavourScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs) | PASS |
| DirectMarriageBoundaries | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| MarriageDeclineAndLifetime | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| ResidenceMoveInviteAndConflict | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| MarriageDowryIngress | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| CompleteCallFavorPayloadMatrix | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| NestedRepaymentIngress | [MarriageResidenceScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs) | PASS |
| GeneratedActionVocabularyAndRepaymentTarget | [AgencyScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs) | PASS |
| ExactKinScoringAndFullTrace | [AgencyScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs) | PASS |
| CoResidenceMotivationWithoutCompulsion | [AgencyScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs) | PASS |
| PersonalResidenceAndIncomingResponse | [AgencyScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs) | PASS |
| ReferenceProfilesAndAutonomousCycle | [AgencyScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs) | PASS |
| DirectAttitudeCompositionAndPermutation | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| DuplicateReactionAndPrematureClosure | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| MaterialDeadlockAndNegativeControls | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| StableFallbackSensitivityAndSemanticAsymmetry | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| ReplayStorageInputObserverAndAttributePairs | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| IdentityIsomorphismAndDisconnectedLocality | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| NoDerivedAuthorityStructuralAudit | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| DistinctTransferMeanings | [CrossCuttingScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs) | PASS |
| FixedAttitudeEventMatrix | [AttitudeEventScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs) | PASS |
| AggregateCapacityAndIndependentLedgerFault | [AttitudeEventScenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs) | PASS |
| ConsumptionAndFarm | [Scenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs) | PASS |
| DecayBoundaries | [Scenarios.cs](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs) | PASS |
