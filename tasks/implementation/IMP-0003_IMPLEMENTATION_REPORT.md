# IMP-0003 — Household substrate implementation report

**Status:** COMPLETE CANDIDATE — fresh independent conformance remains required.

**Branch:** `implementation/imp-0003-slice3-household`

**Canonical base:** `77f3d1dd9630401ff6bba0b38283a823e26d2a01`

**Proposed immutable candidate:** `imp-0003-slice3-conformance-candidate-v1`; the Master Architect owns freezing and review dispatch.

The exact tested implementation SHA and working-tree cleanliness are emitted by `slice3-results.json`. Canonical CI checks out the PR head itself and uploads `sfl-slice1-slice2-slice3-acceptance-evidence`. The PR and delivery record identify the final exact-head run/artifact; this tracked report does not embed its own commit hash.

## Authority and boundaries

- Frozen Slice-3 version/ref: `SFL-V0-S3-ACCEPTANCE-v1` / `sfl-v0-slice3-acceptance-v1`.
- Freeze commit: `25160f33c994fd5f3e277ae98f03e55d37c878dd`.
- Manifest blob: `1aae13dc27572361fe99c31ef8aee0444d39364a`.
- All three frozen manifests are unchanged.
- S1-084 conditional adaptation trigger: **UNFIRED**. `WorldState` and `NoDerivedAuthorityStructuralAudit` are unchanged; a new exact structural audit covers the household partition.
- No head/office, household initiative, endogenous commitment acquisition, spending, mediated marriage, checkpoint format, general candidate convergence, or generalized lineage is implemented.

## Production changes

- `HouseholdState.cs`: identified household/association/warrant/commitment records, immutable snapshots, direct/transitive lineage queries and recomputed capacity. Ordinary-support evidence is a typed committed ledger, not actor reports or observer-history reconstruction.
- `HouseholdRules.cs`: formation connectivity, bilateral participation prerequisites, support freshness and explicit bridge-entry precedence.
- `HouseholdExecution.cs`: automatic formation, entry/exit continuity, stable lifecycle, actor-specific household evidence, controlled lineage and restricted fixture prerequisites. Every transition retains causal references and rule/configuration provenance.
- `HouseholdResolution.cs`: affected-person/household/candidate dependency partitioning and detached replay using the real commit/closure paths, without consuming live IDs. Semantic bridge precedence constrains admissible orders; residual consequential technical conflicts remain disclosed.
- Existing simulation, action and epistemic surfaces integrate the partition, additive household action types and held-claim route. The existing `RecognitionOf(CandidateId)` API remains unchanged; `HouseholdRecognitionOf(HouseholdId)` avoids target-typed-call ambiguity.
- Production/test READMEs document the new interfaces and limits. CI preserves the root command sequence, checks out the exact PR head and uploads all three slices' evidence.

## Verification and audits

The acceptance package runs 24 Slice-3 scenario groups and audits 71 worlds. It reports all 109 frozen Slice-3 rows: **96 REQUIRED PASS, 11 DEFERRED, two UNEXERCISED**. Inherited reporting contains **128 Slice-1 and 46 Slice-2 REQUIRED PASS** bindings.

The inherited `S1-GLOBAL-CONFORMANCE` binding cites the accepted Slice-1 candidate-v3 independent review/completion record. The original Slice-1 runner remains unchanged and continues to distinguish coder evidence from external review. This inherited provenance does not certify the new Slice-3 implementation.

Fixtures supply only lower-level inputs, inert candidate declarations, explicit held evidence where acquisition is not under test, and manifest-authorized pre-existing provision commitments. Household identities, warrants, participation results, lifecycle, final Recognition and derived capacity are production results. `slice3-fixtures.json` records actual inputs and additional controlled writes; `slice3-producers.json` records producer/pass/fixture/configuration/output provenance.

`HouseholdOracle` independently checks formation predicates, evidence sources, ordered warrant chains, bridge references, stable participant counts, lineage sources/freshness and grain continuity. It does not call production classifiers under judgment. Detached corrupt formation and continuation witnesses fail the same checker.

Coverage includes the canonical three-founder causal schedule; cardinality and prerequisite ablations; the closed support-kind census; both participation directions; full founder turnover; Inactive reactivation and same-cycle bridge handoff; dissolution/no resurrection; continuity precedence and distinct-evidence overlap; outsider/stale/contested recognition; division/consolidation positive and negative controls; unrelated predecessor exclusion; direct/transitive ancestry; reserve/NeedsGrain arithmetic and commitment termination; iteration, non-order-preserving ID renaming, disconnected-household locality, observer noninterference and irrelevant-name perturbations.

Actual internal challenges exercise duplicate automatic causes and skipped closure. Focused ablations and structural alternatives remain distinct from injected mutants; a general mutation/generation framework is not claimed. The same-grain NeedsGrain comparison exercises the pure capacity boundary without weakening the existing valid-world invariant.

One implementation defect was found and repaired by the new adverse-order case: a newcomer residence change initially escaped household dependency grouping because the newcomer was not yet a participant. Affected-person keys now group the residence/admission race, and the test verifies both immediate invalidation and technical-fallback disclosure.

## Root commands and delivery

Use SDK 10.0.401, C# 14 and the existing Microsoft Testing Platform. Run from the repository root:

1. `dotnet restore Mesopotamia.Sim.slnx`
2. `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
3. `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
4. `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Local verification is green with zero build warnings/errors and no skipped tests. The final delivery record and CI artifact carry exact-head execution identity and command evidence. Frozen/source-protection checks confirm no modification to the acceptance authorities or original S1-084 surface.

## Engineering decisions and unresolved work

- Separate household authority follows the existing Simulation-owned epistemic partition; derived queries use direct recomputation.
- Inert candidate declaration supports sequential bounded episodes without a candidate-convergence algorithm.
- Existing S2 profile/version assertions remain intact; Slice-3 runs use the explicit S3 configuration, and household warrants carry the S3 rule version separately.
- Household mechanism actions use the ordinary proposal/response boundary. Autonomous social motivation is not broadened.
- Dependency permutations are bounded by affected components; tightly coupled components can still be expensive in this reference kernel.
- No semantic escalation or S1-084 adaptation was required. No frozen applicability was changed.
- Outstanding: Master Architect candidate freeze, fresh independent exact-candidate conformance, and (only after PASS — PROMOTE) canonical promotion/post-merge verification.

## Individual completion evidence

The following tables are generated from the passing local acceptance output; exact-head CI regenerates the machine-readable evidence.

| Slice-3 AcceptanceId | Classification | Result |
|---|---|---|
| S3-001-FORMATION-POSITIVE | REQUIRED | PASS |
| S3-002-FOUNDING-CARDINALITY | REQUIRED | PASS |
| S3-003-FORMATION-RESIDENCE-ABLATION | REQUIRED | PASS |
| S3-004-FORMATION-DURABLE-TIE-ABLATION | REQUIRED | PASS |
| S3-005-FORMATION-SUPPORT-COUNT-ORDER | REQUIRED | PASS |
| S3-006-FORMATION-RECOGNITION-ABLATION | REQUIRED | PASS |
| S3-007-CANDIDATE-NONAUTHORITY | REQUIRED | PASS |
| S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS | REQUIRED | PASS |
| S3-009-NO-HIDDEN-MEMBERS-AUTHORITY | REQUIRED | PASS |
| S3-010-FORMATION-WARRANT-PROVENANCE | REQUIRED | PASS |
| S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME | REQUIRED | PASS |
| S3-012-FOUNDING-PARTICIPATION-PROVENANCE | REQUIRED | PASS |
| S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H | REQUIRED | PASS |
| S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY | REQUIRED | PASS |
| S3-015-QUALIFYING-SUPPORT-KIND-CENSUS | REQUIRED | PASS |
| S3-020-PARTICIPATION-ENTRY-POSITIVE | REQUIRED | PASS |
| S3-021-PARTICIPATION-RECOGNITION-ABLATION | REQUIRED | PASS |
| S3-022-PARTICIPATION-BRIDGE-ABLATION | REQUIRED | PASS |
| S3-023-PARTICIPATION-BILATERAL-ABLATION | REQUIRED | PASS |
| S3-024-PARTICIPATION-RESIDENCE-ABLATION | REQUIRED | PASS |
| S3-025-PARTICIPATION-DURABLE-TIE-ABLATION | REQUIRED | PASS |
| S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION | REQUIRED | PASS |
| S3-027-PARTICIPATION-END-WARRANT | REQUIRED | PASS |
| S3-028-PARTICIPATION-END-NONERASURE | REQUIRED | PASS |
| S3-029-RESIDENCE-NOT-PARTICIPATION | REQUIRED | PASS |
| S3-030-EXIT-SIDE-CONTINUATION | REQUIRED | PASS |
| S3-031-COMPLETE-FOUNDER-TURNOVER | REQUIRED | PASS |
| S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT | REQUIRED | PASS |
| S3-033-INACTIVE-STATE | REQUIRED | PASS |
| S3-034-INACTIVE-REACTIVATION | REQUIRED | PASS |
| S3-035-SAME-CYCLE-BRIDGE-HANDOFF | REQUIRED | PASS |
| S3-036-DISSOLUTION-STABLE-CLOSURE | REQUIRED | PASS |
| S3-037-DISSOLVED-NO-RESURRECTION | REQUIRED | PASS |
| S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION | REQUIRED | PASS |
| S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP | REQUIRED | PASS |
| S3-040-HOUSEHOLD-RECOGNITION-DISTINCT | REQUIRED | PASS |
| S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION | REQUIRED | PASS |
| S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE | REQUIRED | PASS |
| S3-043-H-RECOGNITION-STALE-RETENTION | REQUIRED | PASS |
| S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE | REQUIRED | PASS |
| S3-045-DISSOLUTION-RECOGNITION-ROUTE | REQUIRED | PASS |
| S3-046-H-RECOGNITION-NO-ID-WINNER | REQUIRED | PASS |
| S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE | REQUIRED | PASS |
| S3-048-H-RECOGNITION-CONTESTED | REQUIRED | PASS |
| S3-049-H-RECOGNITION-CONTESTED-GATE | REQUIRED | PASS |
| S3-050-DIVISION-DESCENDANT | REQUIRED | PASS |
| S3-051-DIVISION-FRESHNESS-ABLATION | REQUIRED | PASS |
| S3-052-DIVISION-PREDECESSOR-CONTINUITY | REQUIRED | PASS |
| S3-053-CONSOLIDATION-DESCENDANT | REQUIRED | PASS |
| S3-054-CONSOLIDATION-SURVIVOR-ABLATION | REQUIRED | PASS |
| S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION | REQUIRED | PASS |
| S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT | REQUIRED | PASS |
| S3-057-LINEAGE-SOURCE-PROVENANCE | REQUIRED | PASS |
| S3-058-LINEAGE-ZERO-OR-ONE | REQUIRED | PASS |
| S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS | REQUIRED | PASS |
| S3-060-LINEAGE-NONAUTHORITY | REQUIRED | PASS |
| S3-061-DERIVEDFROM-REBUILD | REQUIRED | PASS |
| S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY | REQUIRED | PASS |
| S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC | REQUIRED | PASS |
| S3-064-LINEAGE-PERSISTENCE-HISTORY | REQUIRED | PASS |
| S3-065-NO-REPEATED-PREDECESSOR-SOURCE-GENERALIZATION | DEFERRED | DEFERRED |
| S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION | REQUIRED | PASS |
| S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION | REQUIRED | PASS |
| S3-070-PROVISION-COMMITMENT-BACKING-STATE | REQUIRED | PASS |
| S3-071-PROVISION-EXPOSED-CAPACITY | REQUIRED | PASS |
| S3-072-PROVISION-NEEDSGRAIN-ZERO | REQUIRED | PASS |
| S3-073-NO-POOLED-HOUSEHOLD-TREASURY | REQUIRED | PASS |
| S3-074-MOBILIZABLE-CAPACITY-DERIVED | REQUIRED | PASS |
| S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT | REQUIRED | PASS |
| S3-076-DISSOLUTION-TERMINATES-COMMITMENTS | REQUIRED | PASS |
| S3-077-NO-SPENDING-AUTHORITY | REQUIRED | PASS |
| S3-080-FORMATION-REACTION-CHAIN | REQUIRED | PASS |
| S3-081-CAUSE-IDEMPOTENCE | REQUIRED | PASS |
| S3-082-REACTIONINDEX-MONOTONE | REQUIRED | PASS |
| S3-083-DERIVED-REFRESH-CLOSURE | REQUIRED | PASS |
| S3-084-NO-MID-CLOSURE-PUBLICATION | REQUIRED | PASS |
| S3-085-NONSEMANTIC-ITERATION-METAMORPHIC | REQUIRED | PASS |
| S3-086-ISOMORPHIC-ID-RENAMING | REQUIRED | PASS |
| S3-087-LOCALITY | REQUIRED | PASS |
| S3-088-OBSERVER-NONINTERFERENCE | REQUIRED | PASS |
| S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE | REQUIRED | PASS |
| S3-090-FALLBACK-QUARANTINE | REQUIRED | PASS |
| S3-091-VERIFIED-PRODUCER-PROVENANCE | REQUIRED | PASS |
| S3-092-TRACE-CONFIGURATION-TRUTH | REQUIRED | PASS |
| S3-093-STRUCTURAL-AUTHORITY-NONHIDING | REQUIRED | PASS |
| S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION | REQUIRED | PASS |
| S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION | REQUIRED | PASS |
| S3-R02-COMMUNICATION-PROVENANCE-STALENESS | REQUIRED | PASS |
| S3-R03-INITIATIVE-RESPONSE-ACCOUNTING | REQUIRED | PASS |
| S3-R04-OBSERVER-NONINTERFERENCE | REQUIRED | PASS |
| S3-R05-LOCALITY | REQUIRED | PASS |
| S3-R06-FALLBACK-ID-QUARANTINE | REQUIRED | PASS |
| S3-R07-CACHE-DERIVED-NONAUTHORITY | REQUIRED | PASS |
| S3-R08-STABLE-CLOSURE | REQUIRED | PASS |
| S3-R09-PERSON-LEVEL-SEMANTICS | REQUIRED | PASS |
| S3-R10-TRACE-CONFIGURATION | REQUIRED | PASS |
| S3-R11-FROZEN-AUTHORITY-INTEGRITY | REQUIRED | PASS |
| S3-D01-CANDIDATE-CONVERGENCE | DEFERRED | DEFERRED |
| S3-D02-ACTOR-DEPARTURE | DEFERRED | DEFERRED |
| S3-D03-REPEATED-PREDECESSOR-PARTICIPATION | DEFERRED | DEFERRED |
| S3-D04-HEAD-OFFICE | DEFERRED | DEFERRED |
| S3-D05-HOUSEHOLD-DECISION-MODE | DEFERRED | DEFERRED |
| S3-D06-PROVISION-SOLICITATION-RECONSIDERATION | DEFERRED | DEFERRED |
| S3-D07-HOUSEHOLD-SPENDING | DEFERRED | DEFERRED |
| S3-D08-MEDIATED-MARRIAGE-AUTHORITY | DEFERRED | DEFERRED |
| S3-D09-AUTHORITY-DESTROYING-RACE | DEFERRED | DEFERRED |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED | DEFERRED |
| S3-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED | UNEXERCISED |
| S3-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED | UNEXERCISED |

| Inherited AcceptanceId | Result |
|---|---|
| S1-090-A | PASS |
| S1-090-B | PASS |
| S1-090-C | PASS |
| S1-090-D | PASS |
| S1-090-E | PASS |
| S1-091-GIFT | PASS |
| S1-091-HELP | PASS |
| S1-091-LOAN-OFFER | PASS |
| S1-091-LOAN-REQUEST | PASS |
| S1-091-BFF-POS | PASS |
| S1-091-RMRH | PASS |
| S1-091-MEANING-SEPARATION | PASS |
| S1-092-PARTIAL | PASS |
| S1-092-AMOUNT-VALIDITY | PASS |
| S1-092-RESERVE | PASS |
| S1-092-FULL | PASS |
| S1-092-DUE | PASS |
| S1-093-BFF-POS | PASS |
| S1-093-RECIP-74 | PASS |
| S1-093-RECIP-75 | PASS |
| S1-093-RECIP-76 | PASS |
| S1-093-KIN-GATE | PASS |
| S1-093-GIFT-CONTROL | PASS |
| S1-093-BFF-FULL | PASS |
| S1-093-BFF-RACE | PASS |
| S1-093-RMRH-FULL | PASS |
| S1-094-FARM-CALLABLE | PASS |
| S1-094-REPAY-CALLABLE | PASS |
| S1-094-PERSONAL-COEXIST | PASS |
| S1-094-NONCALLABLE-MATRIX | PASS |
| S1-094-NONPAYLOAD-MATRIX | PASS |
| S1-094-UNABLE | PASS |
| S1-094-DECLINE | PASS |
| S1-094-INVALIDATED | PASS |
| S1-094-SUCCESS | PASS |
| S1-094-NESTED-GUARD | PASS |
| S1-094-RECIP-CANCEL | PASS |
| S1-095-POS | PASS |
| S1-095-74 | PASS |
| S1-095-KIN | PASS |
| S1-095-LIFETIME | PASS |
| S1-095-NO-RESIDENCE | PASS |
| S1-096-MOVE | PASS |
| S1-096-INVITE | PASS |
| S1-096-COMPETE | PASS |
| S1-096-NO-HH | PASS |
| S1-096-MARRIAGE-CONTROL | PASS |
| S1-097-EVENTS | PASS |
| S1-097-SAT | PASS |
| S1-097-DIRECT-BATCH-POS | PASS |
| S1-097-DIRECT-BATCH-NEG | PASS |
| S1-097-DECAY | PASS |
| S1-098-CORE | PASS |
| S1-098-CALLFAVOR-INIT | PASS |
| S1-099-KIN | PASS |
| S1-099-CORES | PASS |
| S1-100 | PASS |
| S1-101 | PASS |
| S1-102 | PASS |
| S1-103-GRAIN | PASS |
| S1-103-RESIDENCE | PASS |
| S1-105 | PASS |
| S1-070 | PASS |
| S1-071 | PASS |
| S1-073 | PASS |
| S1-074-IDEMP | PASS |
| S1-074-DIRECT-BATCH | PASS |
| S1-080 | PASS |
| S1-081 | PASS |
| S1-084 | PASS |
| S1-085 | PASS |
| S1-086 | PASS |
| S1-BND-ATT-STRONGLIKE | PASS |
| S1-BND-ATT-SAT | PASS |
| S1-BND-ATT-MIXED | PASS |
| S1-D4-GRAIN-GIFT-OFFER | PASS |
| S1-D4-GRAIN-GIFT-REQUEST | PASS |
| S1-D4-GRAIN-LOAN-OFFER | PASS |
| S1-D4-GRAIN-LOAN-REQUEST | PASS |
| S1-D4-GRAIN-REPAY-DIRECT | PASS |
| S1-D4-GRAIN-BFF-BENEFIT | PASS |
| S1-D4-GRAIN-RMRH-BENEFIT | PASS |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | PASS |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | PASS |
| S1-BND-REPAY-AMOUNT | PASS |
| S1-BND-RESERVE | PASS |
| S1-BND-NEED | PASS |
| S1-BND-DECAY | PASS |
| S1-BND-DEBT-DUE | PASS |
| S1-BND-MARRIAGE-CARD | PASS |
| S1-BND-FAVOUR-CARD | PASS |
| S1-BND-FAVOUR-MEANING | PASS |
| S1-BND-RESIDENCE-CARD | PASS |
| S1-META-01 | PASS |
| S1-META-02 | PASS |
| S1-META-03 | PASS |
| S1-META-04 | PASS |
| S1-META-05 | PASS |
| S1-META-07 | PASS |
| S1-META-10 | PASS |
| S1-META-11 | PASS |
| S1-MUT-04 | PASS |
| S1-MUT-13A | PASS |
| S1-MUT-16 | PASS |
| S1-MUT-17 | PASS |
| S1-MUT-18 | PASS |
| S1-MUT-19 | PASS |
| S1-MUT-20 | PASS |
| S1-MUT-21 | PASS |
| S1-MUT-22 | PASS |
| S1-MUT-23 | PASS |
| S1-MUT-24 | PASS |
| S1-MUT-26 | PASS |
| S1-MUT-29 | PASS |
| S1-MUT-31 | PASS |
| S1-MUT-32 | PASS |
| S1-MUT-33 | PASS |
| S1-MUT-34 | PASS |
| S1-MUT-35 | PASS |
| S1-GLOBAL-FIXTURE | PASS |
| S1-GLOBAL-KNOWLEDGE | PASS |
| S1-GLOBAL-ORACLE | PASS |
| S1-GLOBAL-FALLBACK | PASS |
| S1-GLOBAL-ITERATION | PASS |
| S1-GLOBAL-CALLFAVOR-MAP | PASS |
| S1-GLOBAL-REQUIRED-COVERAGE | PASS |
| S1-GLOBAL-MANIFEST-INTEGRITY | PASS |
| S1-GLOBAL-CONFORMANCE | PASS |
| S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION | PASS |
| S2-002-KNOWNFACT-RETENTION | PASS |
| S2-003-KNOWNFACT-PROVENANCE-CENSUS | PASS |
| S2-004-RECOGNITION-DISTINCT | PASS |
| S2-005-RECOGNITION-TRISTATE-LIFETIME | PASS |
| S2-006-NO-PASSIVE-SYNC | PASS |
| S2-007-NO-HISTORY-OMNISCIENCE | PASS |
| S2-008-LOCALITY | PASS |
| S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE | PASS |
| S2-010-OWN-STATE-KNOWLEDGE | PASS |
| S2-011-DIRECT-CLAIM-KNOWLEDGE | PASS |
| S2-012-DIRECT-PARTICIPATION-KNOWLEDGE | PASS |
| S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION | PASS |
| S2-020F-FACT-COMMUNICATION-ACTION | PASS |
| S2-020R-RECOGNITION-COMMUNICATION-ACTION | PASS |
| S2-021F-COMMUNICATE-HELD-FACT | PASS |
| S2-021R-COMMUNICATE-HELD-RECOGNITION | PASS |
| S2-022F-NO-INVENTED-FACT | PASS |
| S2-022R-NO-INVENTED-RECOGNITION | PASS |
| S2-023F-FACT-COMMUNICATION-PROVENANCE | PASS |
| S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE | PASS |
| S2-024F-FACT-COMMUNICATION-INITIATIVE-COST | PASS |
| S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST | PASS |
| S2-025F-FACT-NO-FREE-BROADCAST | PASS |
| S2-025R-RECOGNITION-NO-FREE-BROADCAST | PASS |
| S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS |
| S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE | PASS |
| S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE | PASS |
| S2-030-STALE-FACT-PERSISTS | PASS |
| S2-031A-DIRECT-EVIDENCE-PRECEDENCE | PASS |
| S2-031B-REPORT-EVENT-PRECEDENCE | PASS |
| S2-032-MESSAGE-ARRIVAL-PERMUTATION | PASS |
| S2-033-CANDIDATE-RECOGNITION-CONTESTED | PASS |
| S2-040F-KNOWNFACT-CANDIDATE-GATE | PASS |
| S2-040R-RECOGNITION-CANDIDATE-GATE | PASS |
| S2-041-GATES-BEFORE-SCORING | PASS |
| S2-042-SUBJECTIVE-TRACE | PASS |
| S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION | PASS |
| S2-044-OBJECTIVE-REVALIDATION-PRESERVED | PASS |
| S2-045-PINNED-POLICY-NONCLAIM | PASS |
| S2-050-EPISTEMIC-READ-NONINTERFERENCE | PASS |
| S2-051-DETERMINISTIC-REPLAY | PASS |
| S2-052-NONSEMANTIC-ITERATION-METAMORPHIC | PASS |
| S2-053-ISOMORPHIC-ID-RENAMING | PASS |
| S2-054-CACHE-NONAUTHORITY | PASS |
| S2-055-CONFIGURATION-PROVENANCE | PASS |
