# IMP-0001 — Slice 1 Successor v2 / DEC-0015 Conformance Report

**Task:** SFL-S1-V2-CONFORMANCE-DEC0015  
**Status:** IMPLEMENTATION CANDIDATE READY — fresh independent successor-conformance review still required  
**Implementation branch:** `implementation/slice1-v2-dec0015-conformance`  
**Verified code/test head before this report-only commit:** `f84db45fcfc9de8892853884c6aa3773a6f601cb`  
**Verification workflow:** `canonical-verification` run `36122073015` / run number `322` — **SUCCESS**  
**Acceptance artifact:** `sfl-slice1-slice2-slice3-slice4-acceptance-evidence`, artifact `10858557304`, SHA-256 digest `69d08c2465fc4893fea723110aa482027af5a5d5d6a26a09094a0734d2c85c82`  
**Frozen successor authority:** `SFL-V0-S1-ACCEPTANCE-v2`  
**Frozen ref:** `sfl-v0-slice1-acceptance-v2` @ `bf77bb38a8a7bc964159188b7359cb8e9af2b483`  
**Frozen v2 manifest blob:** `174ccbae57a64f06bd88de233b11a011b4a2b115`  
**Historical v1 manifest blob:** `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`

## 1. Result

The bounded DEC-0015 implementation repair is complete at the code/test layer.

The production change is confined to `src/Mesopotamia.Sim/State.cs`. The former generic `CheckPair` rule has been removed. A shared helper now checks only endpoint existence, while endpoint distinctness is owned by the semantic relation blocks that require it:

- Attitude resolves both people and permits equal endpoints.
- Kinship resolves both people and rejects equal endpoints.
- Marriage resolves both people and rejects equal endpoints before retaining its existing sex/kinship/cardinality semantics.
- Debt resolves both people and rejects equal endpoints before retaining its existing balance rules.
- Favour resolves both people and rejects equal endpoints before retaining its existing capacity rules.

`ActionRules.Invalid(...)` was not broadened or reinterpreted. Its existing target-bearing self-counterparty rejection remains before response. No global relation-type registry, diagonal-policy engine, public injection API, Slice-5 persistence/checkpoint behavior, or speculative self-debt/self-favour semantics were added.

## 2. DEC-0015 successor evidence

| AcceptanceId | Current evidence | What is omission-detectable |
|---|---|---|
| S1-107-SELF-COUNTERPARTY | `Dec0015SelfCounterpartyBoundary` | Table-driven Gift/Help/Loan/BFF/RMRH self-target rejection plus isolated CallFavor holder==called-actor validator control; InvalidTerms occurs before response, with no material/relation/social consequence. |
| S1-107-ATTITUDE-DIAGONAL | `Dec0015AttitudeDiagonal` | Valid `Attitude(P,P)` initialization/addressability, ±100 bounds, positive/negative cadence decay, unrelated-edge independence, and self-action negative control. Restoring generic endpoint inequality breaks construction. |
| S1-107-DEBT-DIAGONAL | `Dec0015DebtDiagonal` | Public self-loan is rejected with no live Debt/effects; bounded internal `WorldState.Validate` probe proves a Debt-owned distinctness rule while a normal Debt validates. |
| S1-107-FAVOUR-DIAGONAL | `Dec0015FavourDiagonal` | Public self-BFF is rejected with no live Favour/call/refusal/attitude effects; bounded internal validation proves a Favour-owned distinctness rule while a normal Favour validates. |
| S1-107-VALID-ALIAS-CONTROLS | `Dec0015ValidAliasControls` | Re-exercises personal initiative+incoming response, multiple responses over one scarce source, two-party CallFavor(RepayDebt) with holder==creditor, and same-edge +5/+10 attitude convergence. |
| S1-107-GENERIC-RELATION-SEAM | `Dec0015GenericRelationSeam` | Structural source audit proves the generic helper checks existence only; Kinship/Marriage/Debt/Favour own distinctness; no registry exists; a universal-distinct mutant predicate is explicitly detected by a valid diagonal Attitude. |

The focused fault evidence records the generic-endpoint-inequality challenge as `detected`; it cannot be silently reintroduced without failing current acceptance.

## 3. Inherited verification adaptation

No authoritative runtime-state field inventory changed, and no inherited structural authority witness was weakened or replaced.

The only inherited adaptations were exact acceptance-census bindings that necessarily changed because successor v2 adds six REQUIRED Slice-1 rows:

- Slice 2 regression integrity now binds to `SFL-V0-S1-ACCEPTANCE-v2`, exact blob `174ccbae57a64f06bd88de233b11a011b4a2b115`, and exact 173-row census instead of the historical 167-row count.
- Slice 3's exact inherited REQUIRED census changes from 174 to 180 = 134 Slice-1 REQUIRED + 46 Slice-2 REQUIRED.
- Slice 4's exact inherited REQUIRED census changes from 270 to 276 = 180 inherited Slice-1/2 REQUIRED + 96 Slice-3 REQUIRED.

The first two canonical runs exposed those stale count bindings in order. After exact adaptation, run 322 passed the full Slice 1–4 suite.

## 4. Frozen-authority integrity

The working branch retains the frozen manifest bytes unchanged:

- v2 manifest Git blob: `174ccbae57a64f06bd88de233b11a011b4a2b115`;
- historical v1 manifest Git blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`.

No frozen manifest, DEC-0015, specification authority, historical IMP-0001 completion record, or frozen ref was edited. All non-REQUIRED successor classifications remain visible and unchanged: **33 DEFERRED / 3 N-A / 3 UNEXERCISED**.

## 5. Canonical verification

Run `36122073015` (`canonical-verification` #322) passed on exact code/test head `f84db45fcfc9de8892853884c6aa3773a6f601cb`:

- restore — PASS;
- static quality / `dotnet format --verify-no-changes` — PASS;
- Release build — PASS;
- full test suite — PASS;
- acceptance-evidence upload — PASS.

The generated Slice-1 v2 result set is candidate-ready when **133 coder-owned REQUIRED** rows are PASS and `S1-GLOBAL-CONFORMANCE` is explicitly `AWAITING INDEPENDENT REVIEW`. This report does not self-award that external row.

## 6. All 134 REQUIRED successor AcceptanceIds

The table below is generated from the current executable scenario registry plus explicit global harness obligations. It maps every REQUIRED v2 row to current evidence.

| AcceptanceId | State | Substantive current evidence |
|---|---|---|
| S1-090-A | PASS | `ConsumptionAndFarm` |
| S1-090-B | PASS | `ConsumptionAndFarm` |
| S1-090-C | PASS | `ConsumptionAndFarm` |
| S1-090-D | PASS | `GiftHelpMeaningsAndNeedClearing` |
| S1-090-E | PASS | `ConsumptionAndFarm` |
| S1-091-GIFT | PASS | `GiftHelpMeaningsAndNeedClearing` |
| S1-091-HELP | PASS | `GiftHelpMeaningsAndNeedClearing` |
| S1-091-LOAN-OFFER | PASS | `LoanRoutesAndRepaymentHistory` |
| S1-091-LOAN-REQUEST | PASS | `LoanRoutesAndRepaymentHistory` |
| S1-091-BFF-POS | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-091-RMRH | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-091-MEANING-SEPARATION | PASS | `DistinctTransferMeanings` |
| S1-092-PARTIAL | PASS | `LoanRoutesAndRepaymentHistory`<br>`RepairAggregateDebtCapacity`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-092-AMOUNT-VALIDITY | PASS | `RepaymentAmountAndReserve` |
| S1-092-RESERVE | PASS | `RepaymentAmountAndReserve`<br>`RepairTransferShapesAndReserve`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-092-FULL | PASS | `LoanRoutesAndRepaymentHistory` |
| S1-092-DUE | PASS | `DebtDueAfterThirdFullCycle` |
| S1-093-BFF-POS | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-093-RECIP-74 | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-093-RECIP-75 | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-093-RECIP-76 | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-093-KIN-GATE | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-093-GIFT-CONTROL | PASS | `GiftHelpMeaningsAndNeedClearing` |
| S1-093-BFF-FULL | PASS | `FullFavourSlotDistinguishesBargainFromHelp` |
| S1-093-BFF-RACE | PASS | `BargainCapacityRace`<br>`RepairFavourCreationProvenance` |
| S1-093-RMRH-FULL | PASS | `FullFavourSlotDistinguishesBargainFromHelp`<br>`RepairFavourCreationProvenance` |
| S1-094-FARM-CALLABLE | PASS | `CalledFarmSuccessRefusalAndInability`<br>`RepairCalledPayloadPrivateFeasibility` |
| S1-094-REPAY-CALLABLE | PASS | `CalledRepaymentThirdPartyAndInvalidation`<br>`RepairFavourRetirementDependencies`<br>`RepairObservedDebtBoundary`<br>`RepairCalledPayloadPrivateFeasibility` |
| S1-094-PERSONAL-COEXIST | PASS | `CalledFarmPersonalCoexistence` |
| S1-094-NONCALLABLE-MATRIX | PASS | `CompleteCallFavorPayloadMatrix` |
| S1-094-NONPAYLOAD-MATRIX | PASS | `CompleteCallFavorPayloadMatrix` |
| S1-094-UNABLE | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-094-DECLINE | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-094-INVALIDATED | PASS | `CalledRepaymentThirdPartyAndInvalidation`<br>`RepairAggregateDebtCapacity`<br>`RepairTransferShapesAndReserve`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-094-SUCCESS | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-094-NESTED-GUARD | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-094-RECIP-CANCEL | PASS | `ReciprocalCancellation`<br>`RepairFavourRetirementDependencies` |
| S1-095-POS | PASS | `DirectMarriageBoundaries` |
| S1-095-74 | PASS | `DirectMarriageBoundaries` |
| S1-095-KIN | PASS | `DirectMarriageBoundaries` |
| S1-095-LIFETIME | PASS | `MarriageDeclineAndLifetime` |
| S1-095-NO-RESIDENCE | PASS | `DirectMarriageBoundaries` |
| S1-096-MOVE | PASS | `ResidenceMoveInviteAndConflict` |
| S1-096-INVITE | PASS | `ResidenceMoveInviteAndConflict` |
| S1-096-COMPETE | PASS | `ResidenceMoveInviteAndConflict` |
| S1-096-NO-HH | PASS | `ResidenceMoveInviteAndConflict` |
| S1-096-MARRIAGE-CONTROL | PASS | `DirectMarriageBoundaries` |
| S1-097-EVENTS | PASS | `FixedAttitudeEventMatrix`<br>`RepairNeedyReciprocalRequestRefusal`<br>`RepairMissingMandatoryAttitudeCause` |
| S1-097-SAT | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-097-DIRECT-BATCH-POS | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-097-DIRECT-BATCH-NEG | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-097-DECAY | PASS | `DecayBoundaries` |
| S1-098-CORE | PASS | `SharedSnapshotScarceGrain` |
| S1-098-CALLFAVOR-INIT | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-099-KIN | PASS | `GeneratedActionVocabularyAndRepaymentTarget`<br>`ExactKinScoringAndFullTrace` |
| S1-099-CORES | PASS | `CoResidenceMotivationWithoutCompulsion`<br>`RepairExplicitSexAndResidenceObservations` |
| S1-107-SELF-COUNTERPARTY | PASS | `Dec0015SelfCounterpartyBoundary` |
| S1-107-ATTITUDE-DIAGONAL | PASS | `Dec0015AttitudeDiagonal` |
| S1-107-DEBT-DIAGONAL | PASS | `Dec0015DebtDiagonal` |
| S1-107-FAVOUR-DIAGONAL | PASS | `Dec0015FavourDiagonal` |
| S1-107-VALID-ALIAS-CONTROLS | PASS | `Dec0015ValidAliasControls` |
| S1-107-GENERIC-RELATION-SEAM | PASS | `Dec0015GenericRelationSeam` |
| S1-100 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-101 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-102 | PASS | `CalledFarmSuccessRefusalAndInability` |
| S1-103-GRAIN | PASS | `SharedSnapshotScarceGrain` |
| S1-103-RESIDENCE | PASS | `ResidenceMoveInviteAndConflict` |
| S1-105 | PASS | `PersonalResidenceAndIncomingResponse` |
| S1-070 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-071 | PASS | `SharedSnapshotScarceGrain` |
| S1-073 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-074-IDEMP | PASS | `DuplicateReactionAndPrematureClosure` |
| S1-074-DIRECT-BATCH | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-080 | PASS | `MaterialDeadlockAndNegativeControls`<br>`RepairV3FutureFaultTiming`<br>`RepairV3DistantInputBoundary`<br>`RepairV3FutureMaterialRecovery` |
| S1-081 | PASS | `StableFallbackSensitivityAndSemanticAsymmetry`<br>`RepairResidenceDestinationDependency`<br>`RepairCallCancellationDependency`<br>`RepairResidenceReadWriteMatrix`<br>`RepairMarriageCapacityPermutation`<br>`RepairFavourCreationProvenance`<br>`RepairFavourRetirementDependencies`<br>`RepairAggregateDebtCapacity`<br>`RepairAggregateGrainAndEnablers`<br>`RepairTransferShapesAndReserve`<br>`RepairCommutingAndAsymmetricControls`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-084 | PASS | `NoDerivedAuthorityStructuralAudit` |
| S1-085 | PASS | `ReplayStorageInputObserverAndAttributePairs`<br>`RepairPersonalInputIsolationAndTrace` |
| S1-086 | PASS | `GeneratedActionVocabularyAndRepaymentTarget`<br>`ExactKinScoringAndFullTrace`<br>`RepairHiddenCounterpartyGrain`<br>`RepairHiddenWorldFacts`<br>`RepairExplicitSexAndResidenceObservations`<br>`RepairObservedDebtBoundary`<br>`RepairCalledPayloadPrivateFeasibility`<br>`RepairPersonalInputIsolationAndTrace` |
| S1-BND-ATT-STRONGLIKE | PASS | `DirectMarriageBoundaries` |
| S1-BND-ATT-SAT | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-BND-ATT-MIXED | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-D4-GRAIN-GIFT-OFFER | PASS | `GiftGrainIngress` |
| S1-D4-GRAIN-GIFT-REQUEST | PASS | `GiftGrainIngress` |
| S1-D4-GRAIN-LOAN-OFFER | PASS | `LoanGrainIngress` |
| S1-D4-GRAIN-LOAN-REQUEST | PASS | `LoanGrainIngress` |
| S1-D4-GRAIN-REPAY-DIRECT | PASS | `RepaymentAmountAndReserve` |
| S1-D4-GRAIN-BFF-BENEFIT | PASS | `BenefitGrainIngress` |
| S1-D4-GRAIN-RMRH-BENEFIT | PASS | `BenefitGrainIngress` |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | PASS | `MarriageDowryIngress` |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | PASS | `NestedRepaymentIngress` |
| S1-BND-REPAY-AMOUNT | PASS | `NestedRepaymentIngress` |
| S1-BND-RESERVE | PASS | `RepaymentAmountAndReserve` |
| S1-BND-NEED | PASS | `GiftHelpMeaningsAndNeedClearing` |
| S1-BND-DECAY | PASS | `DecayBoundaries` |
| S1-BND-DEBT-DUE | PASS | `DebtDueAfterThirdFullCycle` |
| S1-BND-MARRIAGE-CARD | PASS | `MarriageDeclineAndLifetime` |
| S1-BND-FAVOUR-CARD | PASS | `FullFavourSlotDistinguishesBargainFromHelp` |
| S1-BND-FAVOUR-MEANING | PASS | `FullFavourSlotDistinguishesBargainFromHelp` |
| S1-BND-RESIDENCE-CARD | PASS | `ResidenceMoveInviteAndConflict` |
| S1-META-01 | PASS | `ReplayStorageInputObserverAndAttributePairs`<br>`RepairV3IntersectingCapacities`<br>`RepairV3FutureMaterialRecovery`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-META-02 | PASS | `IdentityIsomorphismAndDisconnectedLocality`<br>`RepairResidenceDestinationDependency`<br>`RepairCallCancellationDependency`<br>`RepairResidenceReadWriteMatrix`<br>`RepairMarriageCapacityPermutation`<br>`RepairFavourCreationProvenance`<br>`RepairFavourRetirementDependencies`<br>`RepairAggregateDebtCapacity`<br>`RepairAggregateGrainAndEnablers`<br>`RepairTransferShapesAndReserve`<br>`RepairCommutingAndAsymmetricControls`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-META-03 | PASS | `IdentityIsomorphismAndDisconnectedLocality` |
| S1-META-04 | PASS | `ReplayStorageInputObserverAndAttributePairs`<br>`RepairV3FutureFaultTiming`<br>`RepairV3DistantInputBoundary`<br>`RepairV3FutureMaterialRecovery` |
| S1-META-05 | PASS | `NoDerivedAuthorityStructuralAudit` |
| S1-META-07 | PASS | `ReplayStorageInputObserverAndAttributePairs`<br>`RepairHiddenCounterpartyGrain`<br>`RepairHiddenWorldFacts`<br>`RepairExplicitSexAndResidenceObservations`<br>`RepairObservedDebtBoundary`<br>`RepairCalledPayloadPrivateFeasibility` |
| S1-META-10 | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-META-11 | PASS | `ResidenceMoveInviteAndConflict` |
| S1-MUT-04 | PASS | `ExplicitBargainAndReciprocalHelp` |
| S1-MUT-13A | PASS | `RepaymentAmountAndReserve` |
| S1-MUT-16 | PASS | `SharedSnapshotScarceGrain`<br>`AggregateCapacityAndIndependentLedgerFault` |
| S1-MUT-17 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-MUT-18 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge`<br>`RepairNeedyReciprocalRequestRefusal` |
| S1-MUT-19 | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-MUT-20 | PASS | `SharedSnapshotScarceGrain` |
| S1-MUT-21 | PASS | `SharedSnapshotScarceGrain`<br>`AggregateCapacityAndIndependentLedgerFault` |
| S1-MUT-22 | PASS | `DuplicateReactionAndPrematureClosure` |
| S1-MUT-23 | PASS | `DuplicateReactionAndPrematureClosure` |
| S1-MUT-24 | PASS | `NoDerivedAuthorityStructuralAudit` |
| S1-MUT-26 | PASS | `ReplayStorageInputObserverAndAttributePairs` |
| S1-MUT-29 | PASS | `ExactKinScoringAndFullTrace` |
| S1-MUT-31 | PASS | `DirectAttitudeCompositionAndPermutation` |
| S1-MUT-32 | PASS | `ResidenceMoveInviteAndConflict` |
| S1-MUT-33 | PASS | `NestedRepaymentIngress` |
| S1-MUT-34 | PASS | `CalledRepaymentThirdPartyAndInvalidation` |
| S1-MUT-35 | PASS | `FullFavourSlotDistinguishesBargainFromHelp`<br>`BargainCapacityRace` |
| S1-GLOBAL-FIXTURE | PASS | `AcceptanceTests.ExecuteFrozenManifestEvidence` + `artifacts/acceptance/fixture-audit.json` audit every executable scenario fixture and invariant replay. |
| S1-GLOBAL-KNOWLEDGE | PASS | `ResponseAutonomyAndBoundedFailureKnowledge` |
| S1-GLOBAL-ORACLE | PASS | `AcceptanceTests.ExecuteFrozenManifestEvidence` + `artifacts/acceptance/oracle-audit.json`; forbidden production-oracle dependency audit remains green. |
| S1-GLOBAL-FALLBACK | PASS | `ReferenceProfilesAndAutonomousCycle`<br>`StableFallbackSensitivityAndSemanticAsymmetry`<br>`RepairResidenceDestinationDependency`<br>`RepairCallCancellationDependency`<br>`RepairResidenceReadWriteMatrix`<br>`RepairMarriageCapacityPermutation`<br>`RepairAggregateGrainAndEnablers`<br>`RepairCommutingAndAsymmetricControls`<br>`RepairV3IntersectingCapacities`<br>`RepairV3DebtLimitedCommutingFarm` |
| S1-GLOBAL-ITERATION | PASS | `ReplayStorageInputObserverAndAttributePairs` |
| S1-GLOBAL-CALLFAVOR-MAP | PASS | `CompleteCallFavorPayloadMatrix` |
| S1-GLOBAL-REQUIRED-COVERAGE | PASS | Current v2 coverage predicate requires every coder-owned REQUIRED row to execute/pass with at least one evidence reference; run 322 passed. |
| S1-GLOBAL-MANIFEST-INTEGRITY | PASS | `AcceptanceCatalog.Read` verifies v2 version/blob plus 173-row / 134-REQUIRED census on the frozen manifest. |
| S1-GLOBAL-CONFORMANCE | AWAITING FRESH INDEPENDENT REVIEW | External gate by frozen authority. Historical IMP-0001 v1 independent PASS is preserved but is not reused as successor-v2 conformance. Master Architect must commission a fresh exact-candidate review. |

## 7. Changed-file scope

The completed candidate intentionally changes only the following code/test/report surfaces:

- `src/Mesopotamia.Sim/State.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceCatalog.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceTests.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice2AcceptanceTests.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice4AcceptanceTests.cs`
- `research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_CONFORMANCE_REPORT.md`

Only `State.cs` is production code.

## 8. Candidate boundary and next gate

This branch is an implementation candidate only. It is not merged or promoted.

`S1-GLOBAL-CONFORMANCE` remains an external frozen gate. The historical v1 independent PASS is preserved as inherited evidence, but a **fresh independent successor-v2 conformance review must be run against the exact final candidate head** before any promotion decision.

The report records the verified code/test head because adding this report necessarily creates a later report-only commit. The exact final branch head and report-inclusive canonical run must be supplied with the implementation return/freeze handoff.
