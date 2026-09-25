# IMP-0001 — Slice 1 Successor v2 / DEC-0015 Conformance Report

**Task:** SFL-S1-V2-CONFORMANCE-DEC0015
**Status:** COMPLETE CANDIDATE — fresh independent successor-conformance review required
**Branch:** implementation/slice1-v2-dec0015-conformance
**Historical implementation:** existing branch commits retained; current main merged without rewriting history.

## 1. Result and exact evidence identity

The production repair remains confined to State.cs. Endpoint existence is checked by CheckPeopleExist; distinctness is enforced separately by Kinship, Marriage, Debt and Favour. Attitude(P,P) is valid. Existing action validity, pre-response rejection, transaction publication, public schemas and authoritative field inventories are unchanged.

The historical acceptance harness and Slice-2/3/4 inheritance bindings now match current main exactly. Successor v2 is an additive runner. Historical independent conformance is not reused as successor conformance.

**Verified code/test/mutation revision:** `171bef0d55604a918c5de1a050c83830bf412ed0` (clean working tree).

This report is added by a subsequent documentation-only commit. The final implementation head is supplied in the PR and task return; CI checks out and verifies that exact PR head. This avoids a self-referential commit hash in the report.

Frozen identities:

- v2: SFL-V0-S1-ACCEPTANCE-v2; ref sfl-v0-slice1-acceptance-v2; freeze bf77bb38a8a7bc964159188b7359cb8e9af2b483; manifest blob 174ccbae57a64f06bd88de233b11a011b4a2b115.
- v1: SFL-V0-S1-ACCEPTANCE-v1; ref sfl-v0-slice1-acceptance-v1; freeze 55377cc34b8bc3ccbf9cdf5029e9791dae965987; manifest blob efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766.
- v2 census: 173 unique IDs = 134 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED.
- RulesVersion: SFL-S2-v1; SDK: 10.0.401; C# 14; Microsoft Testing Platform. Exact fixture configuration and profiles are emitted in the fixture artifacts.

## 2. Executed verification and limitations

At the verified revision above, all canonical root commands passed:

| Command | Result |
|---|---|
| dotnet restore Mesopotamia.Sim.slnx | PASS |
| dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore | PASS |
| dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore | PASS, zero warnings/errors |
| dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore | PASS, 75 tests, zero failures/skips |

The successor class also passed independently (eight cases). In a separate clean detached checkout with no historical result artifact, ExecuteSuccessorV2Evidence passed alone and regenerated slice1-results.json. This demonstrates that successor evidence does not depend on test ordering or stale prerequisite files.

The current evidence has 133 coder-owned REQUIRED rows PASS. S1-GLOBAL-CONFORMANCE remains REQUIRED and AWAITING FRESH INDEPENDENT REVIEW. Candidate readiness does not waive that row: FullFrozenCompletionGate remains false.

The historical runner still emits its 167 v1 rows and 128 REQUIRED obligations. Slice 3 retains 174 inherited REQUIRED bindings; Slice 4 retains 270. No inherited structural witness or inventory was adapted. The candidate does not implement Slice 5 or any new self-interaction meaning.

### Successor scenarios and admissible fixtures

| Row | Substantive evidence |
|---|---|
| S1-107-SELF-COUNTERPARTY | All seven direct term shapes (including both reciprocal-help directions), with/without diagonal Attitude and accepting/refusing profiles; InvalidTerms before response; empty-cycle material comparison; no claims, social outcome or participant/epistemic participation facts. Detached holder=debtor CallFavor validation plus public debtor-self-call controls on an endogenously created ordinary favour. |
| S1-107-ATTITUDE-DIAGONAL | Nine values spanning -100, -5, -2, -1, 0, 1, 2, 5, 100; exact pair and relation-ID addressability; ±101 rejection; cycles 1–6 including +5→+3 and -5→-4 at cycle 5, zero-crossing controls, unrelated directed edges and exact maintenance history. Zero edges retain ordinary 0→0 maintenance events. |
| S1-107-DEBT-DIAGONAL | Both self-loan routes rejected, empty-cycle controls through the would-be commitment+3 review boundary, no Debt/repayment/due/social/knowledge consequence, unavailable repayment rejected; detached type-specific rejection contrasted with ordinary Debt acceptance in a world containing diagonal Attitude. |
| S1-107-FAVOUR-DIAGONAL | Self-BFF and both reciprocal-help routes rejected, absent-claim call rejected, no Favour/consumption/refusal/social/knowledge consequence; detached diagonal rejection for outstanding and consumed state contrasted with ordinary Favour acceptance. |
| S1-107-VALID-ALIAS-CONTROLS | Reexecution of PersonalResidenceAndIncomingResponse, SharedSnapshotScarceGrain and DirectAttitudeCompositionAndPermutation; two-party holder=creditor CallFavor(RepayDebt), material arithmetic, debt satisfaction, favour consumption, separate causal +5/+10 contributions and one response. |
| S1-107-GENERIC-RELATION-SEAM | Valid diagonal Attitude; ParentChild/Sibling and Marriage self-pair rejection; ten endpoint-existence probes across all five relation types; duplicate directed Attitude rejection; Person→Dwelling typing with equal numeric IDs; residence self-counterparty rejection; shared-helper source audit plus unchanged inherited exact authority inventory. |

There are 98 audited public simulation fixtures and 17 separately recorded detached probes. Constructor-rejection boundaries declare their complete initial modifications in scenario source; successful worlds are recorded in the fixture audit. No Debt/Favour result is injected into a live simulation. Detached WorldState.Validate and ActionRules.Invalid calls are systems under test, using explicit expected rejection; they are not expected-value oracles.

A valid live diagonal Favour cannot be constructed under current authority. The synthetic holder=debtor snapshot therefore establishes only its classifier boundary. Actual response/consequence suppression is separately observed through the public debtor-self-call case. No unchanged, untouched simulation is presented as proof that a detached interaction executed.

Dec0015Oracle checks raw state/history/knowledge and explicit expected arithmetic. The unchanged InvariantOracle reconstructs material, attitude and provenance. The dependency audit forbids production validators/scorers/transition helpers in the new oracle. Preserved positive fixtures and contrast pairs accompany negative evidence.

## 3. Executed production mutation campaign

The previous predicate-only "detected" claim is replaced by actual compiled production changes in an isolated checkout of the verified revision. All six detector cases passed on the unmutated control. Each mutation compiled successfully, exited with test failure code 2, and failed its specified semantic assertion. Other exceptions are retained diagnostically but are not credited. Build failures, crashes, timeouts and unrelated failures cannot satisfy the gate.

| Executed mutation | Required detector | Outcome |
|---|---|---|
| generic-endpoint-inequality | Dec0015AttitudeDiagonal | DETECTED |
| self-gift-response | Dec0015SelfCounterpartyBoundary | DETECTED |
| self-loan-response | Dec0015SelfCounterpartyBoundary | DETECTED |
| diagonal-debt-enabled | Dec0015DebtDiagonal | DETECTED |
| diagonal-favour-enabled | Dec0015FavourDiagonal | DETECTED |
| broad-response-alias-prohibition | Dec0015InheritedSharedSnapshotScarceGrain | DETECTED |
| diagonal-attitude-authorizes-self-action | Dec0015SelfCounterpartyBoundary | DETECTED |

The campaign retains exact patches, build/test logs, control.trx, each mutant TRX and mutant-results.json under artifacts/acceptance/slice1-v2-mutants. The script checks the exact primary-evidence revision and a clean working tree before running. CI executes the same campaign after canonical tests and includes all receipts in the existing acceptance artifact.

The first development run conservatively failed to recognize the pinned MSTest assertion-message format. The parser was corrected; the complete campaign above was rerun. No failed or unexecuted campaign is credited.

Readiness is deliberately split: slice1-v2-results.json reports ExecutableEvidenceReady, while slice1-v2-candidate-gate.json combines that result with all seven executed mutations into CandidateReady. The former never infers mutation execution from a positive scenario.

## 4. Complete manifest mapping

The tables are generated from the executed successor results. Each JSON row also retains its complete frozen SourceClause. All 134 REQUIRED IDs are included; the sole external review obligation is visibly pending.

| AcceptanceId | State | Current evidence |
|---|---|---|
| S1-090-A | PASS | ConsumptionAndFarm |
| S1-090-B | PASS | ConsumptionAndFarm |
| S1-090-C | PASS | ConsumptionAndFarm |
| S1-090-D | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-090-E | PASS | ConsumptionAndFarm |
| S1-091-GIFT | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-091-HELP | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-091-LOAN-OFFER | PASS | LoanRoutesAndRepaymentHistory |
| S1-091-LOAN-REQUEST | PASS | LoanRoutesAndRepaymentHistory |
| S1-091-BFF-POS | PASS | ExplicitBargainAndReciprocalHelp |
| S1-091-RMRH | PASS | ExplicitBargainAndReciprocalHelp |
| S1-091-MEANING-SEPARATION | PASS | DistinctTransferMeanings |
| S1-092-PARTIAL | PASS | LoanRoutesAndRepaymentHistory; RepairAggregateDebtCapacity; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-092-AMOUNT-VALIDITY | PASS | RepaymentAmountAndReserve |
| S1-092-RESERVE | PASS | RepaymentAmountAndReserve; RepairTransferShapesAndReserve; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-092-FULL | PASS | LoanRoutesAndRepaymentHistory |
| S1-092-DUE | PASS | DebtDueAfterThirdFullCycle |
| S1-093-BFF-POS | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-74 | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-75 | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-RECIP-76 | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-KIN-GATE | PASS | ExplicitBargainAndReciprocalHelp |
| S1-093-GIFT-CONTROL | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-093-BFF-FULL | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-093-BFF-RACE | PASS | BargainCapacityRace; RepairFavourCreationProvenance |
| S1-093-RMRH-FULL | PASS | FullFavourSlotDistinguishesBargainFromHelp; RepairFavourCreationProvenance |
| S1-094-FARM-CALLABLE | PASS | CalledFarmSuccessRefusalAndInability; RepairCalledPayloadPrivateFeasibility |
| S1-094-REPAY-CALLABLE | PASS | CalledRepaymentThirdPartyAndInvalidation; RepairFavourRetirementDependencies; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility |
| S1-094-PERSONAL-COEXIST | PASS | CalledFarmPersonalCoexistence |
| S1-094-NONCALLABLE-MATRIX | PASS | CompleteCallFavorPayloadMatrix |
| S1-094-NONPAYLOAD-MATRIX | PASS | CompleteCallFavorPayloadMatrix |
| S1-094-UNABLE | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-DECLINE | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-INVALIDATED | PASS | CalledRepaymentThirdPartyAndInvalidation; RepairAggregateDebtCapacity; RepairTransferShapesAndReserve; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-094-SUCCESS | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-NESTED-GUARD | PASS | CalledFarmSuccessRefusalAndInability |
| S1-094-RECIP-CANCEL | PASS | ReciprocalCancellation; RepairFavourRetirementDependencies |
| S1-095-POS | PASS | DirectMarriageBoundaries |
| S1-095-74 | PASS | DirectMarriageBoundaries |
| S1-095-KIN | PASS | DirectMarriageBoundaries |
| S1-095-LIFETIME | PASS | MarriageDeclineAndLifetime |
| S1-095-NO-RESIDENCE | PASS | DirectMarriageBoundaries |
| S1-096-MOVE | PASS | ResidenceMoveInviteAndConflict |
| S1-096-INVITE | PASS | ResidenceMoveInviteAndConflict |
| S1-096-COMPETE | PASS | ResidenceMoveInviteAndConflict |
| S1-096-NO-HH | PASS | ResidenceMoveInviteAndConflict |
| S1-096-MARRIAGE-CONTROL | PASS | DirectMarriageBoundaries |
| S1-097-EVENTS | PASS | FixedAttitudeEventMatrix; RepairNeedyReciprocalRequestRefusal; RepairMissingMandatoryAttitudeCause |
| S1-097-SAT | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DIRECT-BATCH-POS | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DIRECT-BATCH-NEG | PASS | DirectAttitudeCompositionAndPermutation |
| S1-097-DECAY | PASS | DecayBoundaries |
| S1-098-CORE | PASS | SharedSnapshotScarceGrain |
| S1-098-CALLFAVOR-INIT | PASS | CalledFarmSuccessRefusalAndInability |
| S1-099-KIN | PASS | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace |
| S1-099-CORES | PASS | CoResidenceMotivationWithoutCompulsion; RepairExplicitSexAndResidenceObservations |
| S1-107-SELF-COUNTERPARTY | PASS | Dec0015SelfCounterpartyBoundary; executed mutant receipts: self-gift-response; self-loan-response; diagonal-attitude-authorizes-self-action |
| S1-107-ATTITUDE-DIAGONAL | PASS | Dec0015AttitudeDiagonal; executed mutant receipts: generic-endpoint-inequality |
| S1-107-DEBT-DIAGONAL | PASS | Dec0015DebtDiagonal; executed mutant receipts: diagonal-debt-enabled |
| S1-107-FAVOUR-DIAGONAL | PASS | Dec0015FavourDiagonal; executed mutant receipts: diagonal-favour-enabled |
| S1-107-VALID-ALIAS-CONTROLS | PASS | Dec0015ValidAliasControls; Dec0015InheritedPersonalResidenceAndIncomingResponse; Dec0015InheritedSharedSnapshotScarceGrain; Dec0015InheritedDirectAttitudeCompositionAndPermutation; executed mutant receipts: broad-response-alias-prohibition |
| S1-107-GENERIC-RELATION-SEAM | PASS | Dec0015GenericRelationSeam; executed mutant receipts: generic-endpoint-inequality |
| S1-100 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-101 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-102 | PASS | CalledFarmSuccessRefusalAndInability |
| S1-103-GRAIN | PASS | SharedSnapshotScarceGrain |
| S1-103-RESIDENCE | PASS | ResidenceMoveInviteAndConflict |
| S1-105 | PASS | PersonalResidenceAndIncomingResponse |
| S1-070 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-071 | PASS | SharedSnapshotScarceGrain |
| S1-073 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-074-IDEMP | PASS | DuplicateReactionAndPrematureClosure |
| S1-074-DIRECT-BATCH | PASS | DirectAttitudeCompositionAndPermutation |
| S1-080 | PASS | MaterialDeadlockAndNegativeControls; RepairV3FutureFaultTiming; RepairV3DistantInputBoundary; RepairV3FutureMaterialRecovery |
| S1-081 | PASS | StableFallbackSensitivityAndSemanticAsymmetry; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairFavourCreationProvenance; RepairFavourRetirementDependencies; RepairAggregateDebtCapacity; RepairAggregateGrainAndEnablers; RepairTransferShapesAndReserve; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-084 | PASS | NoDerivedAuthorityStructuralAudit |
| S1-085 | PASS | ReplayStorageInputObserverAndAttributePairs; RepairPersonalInputIsolationAndTrace |
| S1-086 | PASS | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace; RepairHiddenCounterpartyGrain; RepairHiddenWorldFacts; RepairExplicitSexAndResidenceObservations; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility; RepairPersonalInputIsolationAndTrace |
| S1-BND-ATT-STRONGLIKE | PASS | DirectMarriageBoundaries |
| S1-BND-ATT-SAT | PASS | DirectAttitudeCompositionAndPermutation |
| S1-BND-ATT-MIXED | PASS | DirectAttitudeCompositionAndPermutation |
| S1-D4-GRAIN-GIFT-OFFER | PASS | GiftGrainIngress |
| S1-D4-GRAIN-GIFT-REQUEST | PASS | GiftGrainIngress |
| S1-D4-GRAIN-LOAN-OFFER | PASS | LoanGrainIngress |
| S1-D4-GRAIN-LOAN-REQUEST | PASS | LoanGrainIngress |
| S1-D4-GRAIN-REPAY-DIRECT | PASS | RepaymentAmountAndReserve |
| S1-D4-GRAIN-BFF-BENEFIT | PASS | BenefitGrainIngress |
| S1-D4-GRAIN-RMRH-BENEFIT | PASS | BenefitGrainIngress |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | PASS | MarriageDowryIngress |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | PASS | NestedRepaymentIngress |
| S1-BND-REPAY-AMOUNT | PASS | NestedRepaymentIngress |
| S1-BND-RESERVE | PASS | RepaymentAmountAndReserve |
| S1-BND-NEED | PASS | GiftHelpMeaningsAndNeedClearing |
| S1-BND-DECAY | PASS | DecayBoundaries |
| S1-BND-DEBT-DUE | PASS | DebtDueAfterThirdFullCycle |
| S1-BND-MARRIAGE-CARD | PASS | MarriageDeclineAndLifetime |
| S1-BND-FAVOUR-CARD | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-BND-FAVOUR-MEANING | PASS | FullFavourSlotDistinguishesBargainFromHelp |
| S1-BND-RESIDENCE-CARD | PASS | ResidenceMoveInviteAndConflict |
| S1-META-01 | PASS | ReplayStorageInputObserverAndAttributePairs; RepairV3FutureMaterialRecovery; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-META-02 | PASS | IdentityIsomorphismAndDisconnectedLocality; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairFavourCreationProvenance; RepairFavourRetirementDependencies; RepairAggregateDebtCapacity; RepairAggregateGrainAndEnablers; RepairTransferShapesAndReserve; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-META-03 | PASS | IdentityIsomorphismAndDisconnectedLocality |
| S1-META-04 | PASS | ReplayStorageInputObserverAndAttributePairs; RepairV3FutureFaultTiming; RepairV3DistantInputBoundary; RepairV3FutureMaterialRecovery |
| S1-META-05 | PASS | NoDerivedAuthorityStructuralAudit |
| S1-META-07 | PASS | ReplayStorageInputObserverAndAttributePairs; RepairHiddenCounterpartyGrain; RepairHiddenWorldFacts; RepairExplicitSexAndResidenceObservations; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility |
| S1-META-10 | PASS | DirectAttitudeCompositionAndPermutation |
| S1-META-11 | PASS | ResidenceMoveInviteAndConflict |
| S1-MUT-04 | PASS | ExplicitBargainAndReciprocalHelp |
| S1-MUT-13A | PASS | RepaymentAmountAndReserve |
| S1-MUT-16 | PASS | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault |
| S1-MUT-17 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-MUT-18 | PASS | ResponseAutonomyAndBoundedFailureKnowledge; RepairNeedyReciprocalRequestRefusal |
| S1-MUT-19 | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-MUT-20 | PASS | SharedSnapshotScarceGrain |
| S1-MUT-21 | PASS | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault |
| S1-MUT-22 | PASS | DuplicateReactionAndPrematureClosure |
| S1-MUT-23 | PASS | DuplicateReactionAndPrematureClosure |
| S1-MUT-24 | PASS | NoDerivedAuthorityStructuralAudit |
| S1-MUT-26 | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-MUT-29 | PASS | ExactKinScoringAndFullTrace |
| S1-MUT-31 | PASS | DirectAttitudeCompositionAndPermutation |
| S1-MUT-32 | PASS | ResidenceMoveInviteAndConflict |
| S1-MUT-33 | PASS | NestedRepaymentIngress |
| S1-MUT-34 | PASS | CalledRepaymentThirdPartyAndInvalidation |
| S1-MUT-35 | PASS | FullFavourSlotDistinguishesBargainFromHelp; BargainCapacityRace |
| S1-GLOBAL-FIXTURE | PASS | fixture-audit.json; slice1-v2-fixtures.json; slice1-v2-boundary-probes.json |
| S1-GLOBAL-KNOWLEDGE | PASS | ResponseAutonomyAndBoundedFailureKnowledge |
| S1-GLOBAL-ORACLE | PASS | oracle-audit.json; slice1-v2-oracle-audit.json; InvariantOracle.cs; Dec0015Oracle.cs |
| S1-GLOBAL-FALLBACK | PASS | ReferenceProfilesAndAutonomousCycle; StableFallbackSensitivityAndSemanticAsymmetry; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairAggregateGrainAndEnablers; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities |
| S1-GLOBAL-ITERATION | PASS | ReplayStorageInputObserverAndAttributePairs |
| S1-GLOBAL-CALLFAVOR-MAP | PASS | CompleteCallFavorPayloadMatrix |
| S1-GLOBAL-REQUIRED-COVERAGE | PASS | All 173 rows; 133 coder-owned REQUIRED; external review remains pending |
| S1-GLOBAL-MANIFEST-INTEGRITY | PASS | v1 and v2 Git blobs, exact census and inherited row equality |
| S1-GLOBAL-CONFORMANCE | AWAITING FRESH INDEPENDENT REVIEW | Fresh independent successor review, to be commissioned by the Master Architect; not self-awarded or inherited from v1 |

### All deliberate non-REQUIRED classifications

These 39 rows retain their frozen v2 classification and rationale. Later-slice execution does not silently reclassify them as Slice-1 successor passes.

| AcceptanceId | Frozen classification | Reported state |
|---|---|---|
| S1-098-COMMUNICATION | DEFERRED | DEFERRED |
| S1-104 | DEFERRED | DEFERRED |
| S1-072 | DEFERRED | DEFERRED |
| S1-075 | DEFERRED | DEFERRED |
| S1-076 | DEFERRED | DEFERRED |
| S1-082 | DEFERRED | DEFERRED |
| S1-083 | DEFERRED | DEFERRED |
| S1-087 | DEFERRED | DEFERRED |
| S1-BND-ATT-STRONGDISLIKE | N-A | N-A |
| S1-BND-ATT-DISLIKE-NEUTRAL | N-A | N-A |
| S1-BND-ATT-NEUTRAL-LIKE | N-A | N-A |
| S1-BND-HOUSEHOLD-PROVISION | DEFERRED | DEFERRED |
| S1-BND-PROVISION-RECONSIDERATION | DEFERRED | DEFERRED |
| S1-BND-FORMATION | DEFERRED | DEFERRED |
| S1-BND-LINEAGE | DEFERRED | DEFERRED |
| S1-META-06 | DEFERRED | DEFERRED |
| S1-META-08 | DEFERRED | DEFERRED |
| S1-META-09 | DEFERRED | DEFERRED |
| S1-MUT-01 | DEFERRED | DEFERRED |
| S1-MUT-02 | DEFERRED | DEFERRED |
| S1-MUT-03 | DEFERRED | DEFERRED |
| S1-MUT-05 | DEFERRED | DEFERRED |
| S1-MUT-06 | DEFERRED | DEFERRED |
| S1-MUT-07 | DEFERRED | DEFERRED |
| S1-MUT-08 | DEFERRED | DEFERRED |
| S1-MUT-09 | DEFERRED | DEFERRED |
| S1-MUT-10 | DEFERRED | DEFERRED |
| S1-MUT-11 | DEFERRED | DEFERRED |
| S1-MUT-12 | DEFERRED | DEFERRED |
| S1-MUT-13B | DEFERRED | DEFERRED |
| S1-MUT-14 | DEFERRED | DEFERRED |
| S1-MUT-15 | DEFERRED | DEFERRED |
| S1-MUT-25 | DEFERRED | DEFERRED |
| S1-MUT-27 | DEFERRED | DEFERRED |
| S1-MUT-28 | DEFERRED | DEFERRED |
| S1-MUT-30 | DEFERRED | DEFERRED |
| S1-SUP-GENERATED | UNEXERCISED | UNEXERCISED |
| S1-SUP-SHRINK | UNEXERCISED | UNEXERCISED |
| S1-SUP-HELDOUT | UNEXERCISED | UNEXERCISED |

## 5. Integrity, artifacts and handoff

Both frozen refs and manifest blobs were verified. The full decisions/specifications/canonical-verification tree is unchanged from current main. Historical completion records are untouched. The only production-file delta is State.cs; the existing WorldState/HouseholdState authority inventories and inherited structural witnesses are unchanged. No hidden authority, registry, policy engine, public injection API or speculative self-Debt/Favour support was added.

Artifacts under artifacts/acceptance:

- slice1-v2-results.json — all 173 rows, exact code head, clean/dirty state, manifest identity and executable readiness;
- slice1-v2-cases.json and slice1-v2-fixtures.json — scenario/subcase mappings and actual public fixtures;
- slice1-v2-boundary-probes.json — separately declared detached invalid-state probes;
- slice1-v2-oracle-audit.json and slice1-v2-structural-audit.json — dependency and structural evidence;
- slice1-v2-fault-controls.json — separates inherited checker challenges from executed successor production mutations;
- slice1-v2-mutants/ — exact patches, logs, TRX and classified results;
- slice1-v2-candidate-gate.json — combined exact-revision candidate readiness, with external review still pending;
- unchanged historical slice1/slice2/slice3/slice4 result and supporting artifact families.

The canonical workflow uploads these together as sfl-slice1-slice2-slice3-slice4-acceptance-evidence. Local root-command logs and the standalone regeneration check are retained in this task's outputs directory; CI supplies reproducible exact-final-head verification after publication.

Final changed-file scope relative to current main:

- .github/workflows/ci.yml
- research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_CONFORMANCE_REPORT.md
- src/Mesopotamia.Sim/State.cs
- tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Oracle.cs
- tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Scenarios.cs
- tests/Mesopotamia.Sim.AcceptanceTests/README.md
- tests/Mesopotamia.Sim.AcceptanceTests/Slice1SuccessorV2AcceptanceTests.cs
- tests/Run-Slice1V2Mutants.ps1

Return: COMPLETE CANDIDATE. PR #125 remains a draft and unmerged. The Master Architect must freeze the exact returned implementation head and commission fresh independent successor-conformance review. No promotion or Slice-5 work is claimed.
