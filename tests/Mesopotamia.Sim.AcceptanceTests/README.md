# Slice-1 through Slice-4 Acceptance Test Surface

## Slice-1 successor v2 / DEC-0015

`Slice1SuccessorV2AcceptanceTests` adds successor evidence without retargeting the historical catalog or the Slice-2/3/4 inherited bindings. It verifies both manifest blobs, byte-equivalent inherited status rows, and the exact six new IDs; reexecutes historical evidence; and emits every v2 row in `slice1-v2-results.json`. All 133 coder-owned REQUIRED rows must pass. `S1-GLOBAL-CONFORMANCE` remains awaiting fresh independent review. The historical 128/174/270 inheritance counts are unchanged.

The separate `slice1-v2-cases`, `-fixtures`, `-boundary-probes`, `-structural-audit`, `-oracle-audit`, and `-fault-controls` artifacts distinguish public execution from detached invalid-state probes. `Dec0015Oracle` uses observations and explicit expected arithmetic, not production validity classifiers. `WorldState.Validate` and `ActionRules.Invalid` are targets only in explicitly recorded detached probes. Valid live state cannot contain a diagonal Favour; the holder=debtor classifier probe is separate from the public debtor-self-call response-suppression control.

After canonical tests on a clean committed revision, run `tests/Run-Slice1V2Mutants.ps1` with absolute `-Dotnet`, new `-Checkout`, and `-Evidence` paths and `-Revision HEAD`. Use `artifacts/acceptance/slice1-v2-mutants` for evidence. The script requires exact-revision primary results, passes all six unmutated detectors, and builds/runs seven isolated production mutations. Each must fail its named semantic assertion; build failure, crash, timeout, and unrelated failures do not count. Patches, logs, TRX and classified results are retained. CI executes this step after the ordinary test sequence.

`slice1-v2-results.json` reports `ExecutableEvidenceReady`; it never infers executed mutations from passing scenarios. The script writes `slice1-v2-candidate-gate.json`, which alone combines executable evidence with the completed mutation campaign into `CandidateReady`. Both outputs retain `FullFrozenCompletionGate=false` until independent review. The ordinary full suite contains 75 MSTest cases; the six focused detector cases are also rerun in each mutation checkout.

## Slice-4 candidate evidence

`Slice4AcceptanceTests` verifies the exact frozen v2 manifest blob and approved adaptation-plan blob, executes the explicit case bindings in `Slice4Cases`, and writes all 176 rows individually: 165 REQUIRED, nine DEFERRED, two UNEXERCISED. It reruns the inherited chain and retains all 270 individual REQUIRED results. The results identify actual Git HEAD and dirty status. `slice4-cases.json` maps each full AcceptanceId to substantive methods; `slice4-fixtures.json` retains initial writes, every input, explicitly declared report prerequisites and internal boundary challenges, produced formation identities, causal history, decisions and final typed records. A green coder-owned report does not assert independent conformance.

`Slice4Lab` produces H with ordinary gifts and communicated evidence, then validates it with the inherited independent Household oracle before role work. Roles, consent, commitments, funding and marriages under test use real public actions. Explicit fixture head reports isolate conflicting/stale subjective prerequisites and are separately declared; they never replace transition acquisition witnesses. `Slice4Oracle` reconstructs role continuity and consent from raw snapshots/events, exact evidence receipts and association identities, and funding from initial grain and independent arithmetic. Its dependency audit forbids production role/Recognition/funding/resolution classifiers as expected-answer sources. Well-formed detached corruptions are passed to this checker for role identity/H links, consents/cohorts, evidence identity, funding rank/tie/source/debit, material effects, marriage/favour cardinality, and commitment-origin distinctions.

The four inherited adaptations are recorded in `research/technical/IMP-0004/IMP-0004_ADAPTATION_LEDGER.md`. Historical Slice-3 formation/material and fixture-origin claims remain enforced. Exact field inventories include new typed authority and phase-carried records; S1 WorldState inventory is unchanged. `tests/Run-Slice4Mutants.ps1` creates a new detached checkout of an explicit revision and records exact patches, build/test logs and TRX assertion failures for the behavior-affecting hidden eligibility field and DEC-0014 mutants 53–56. Pass absolute `-Dotnet`, `-Checkout`, and `-Evidence` paths, with optional `-Revision`; the script refuses an existing checkout and never mutates the candidate branch.

Run canonical restore, format verification, Release build and test from root. The existing CI workflow checks out exact PR HEAD and uploads all slice evidence as `sfl-slice1-slice2-slice3-slice4-acceptance-evidence`. The bounded material model and tests make no historical calibration claim, implement no treasury or general ledger, and do not implement deferred checkpoint, resignation, rival succession, general perception or richer personal planning.

## Slice-3 extension

`Slice3AcceptanceTests` verifies frozen `SFL-V0-S3-ACCEPTANCE-v1` (blob `1aae13dc27572361fe99c31ef8aee0444d39364a`) and emits all 109 rows individually: 96 REQUIRED, 11 DEFERRED and two UNEXERCISED. The runner reexecutes earlier acceptance runners rather than relying on method ordering. Its inherited table reports all 128 Slice-1 and 46 Slice-2 REQUIRED bindings. Slice-1's accepted independent conformance row is linked to its historical completion record; this is explicitly not independent conformance of the new candidate.

`HouseholdScenarios` and its partial files run canonical formation, ablations, both bilateral entry directions, full turnover, bridge handoff, lifecycle, recognition routes/conflict, controlled lineage, provision backing, structural checks and metamorphic controls through the real kernel. `HouseholdOracle` independently reconstructs warrant chains, lifecycle, lineage prerequisites and grain continuity from public evidence. Detached corrupt formation/continuation witnesses must fail that same checker. Actual duplicate-reaction and skipped-closure challenges remain separate from focused negative and structural evidence; a general mutation framework is not claimed.

The only additional controlled writes are inert candidate declarations, explicitly fixture-marked held household evidence where acquisition is not the assertion target, and pre-existing provision commitments under frozen §3.1. No fixture writes Household, formation/participation/continuation/lineage warrants, final Recognition, lifecycle or capacity results. Produced household reuse records the producer/pass/fixture/configuration/output identity. There is no engine save/restore API.

The Slice-3 output package contains `slice3-results.json` (implementation SHA, dirty-state flag, exact frozen identities, individual results and inherited evidence), `slice3-cases.json`, `slice3-fixtures.json`, and `slice3-producers.json`. CI checks out the exact PR head and uploads the combined `sfl-slice1-slice2-slice3-acceptance-evidence` artifact. Fresh independent exact-candidate conformance remains a separate mandatory gate.

`HouseholdRepairV2Scenarios` adds detached participation-warrant corruptions (P17/P18/P19 and isolated identity, timing, endpoint, residence, tie and provenance controls), custom-label/mixed-rule provenance, and remote-bearer staleness followed by accepted communication. The independent oracle binds participation to proposal/acceptance history, reconstructs current associations and the residence/tie precommit state, checks real support events, and validates both actors' held recognition bases and source/communication chains. It uses no production participation validator or continuity classifier.

## Retained Slice-1 and Slice-2 verification

This project is the executable verification surface for IMP-0001.

IMP-0002 adds `Slice2AcceptanceTests` and `Slice2Scenarios` alongside the unchanged Slice-1 runner. The Slice-2 runner verifies frozen manifest `SFL-V0-S2-ACCEPTANCE-v1`, blob `e4872531cf780d51fa1863f2a0b87e2424a71b69`, and the 46 REQUIRED / nine DEFERRED census. It emits each full ID, executes all 18 exact Slice-1 regression bindings independently of test-method ordering, and fails missing or unsuccessful REQUIRED evidence.

`slice2-results.json` records the manifest/ref/freeze identity, row results, deferrals, regression IDs, configuration, and explicit pending-conformance state. `slice2-cases.json`, `slice2-fixture-audit.json`, `slice2-regression-fixtures.json`, and `slice2-oracle-audit.json` retain actual case/subcase inputs and immutable outputs. Oracle assertions use public evidence, explicit expected values, and independently constructed paired comparisons. The dependency audit is coder-owned and does not substitute for fresh independent conformance.

The RG-01 fixture seeds only sender-held evidence and the single inert candidate. Production communication and recognition derive the recipient's Contested state. The support facts, fixture origin, absence of semantic-order dominance, complete six-person delivery population, retained state, and permutations are observable in the audit. No fixture writes a recipient acquisition, candidate winner, gate result, or final Recognition state. Communication selection uses the declared laboratory profile and makes no claim of autonomous social motivation.

Authority:

- semantic meaning: accepted SFL specification / ADRs listed by IMP-0001;
- completion applicability: frozen `SFL-V0-S1-ACCEPTANCE-v1`;
- frozen manifest SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`.

The production implementer may map executable evidence to AcceptanceIds but may not edit or reclassify the frozen manifest.

The dispatch-scaffold smoke test in this project proves only that the test runner executes. It is **not** mapped to any AcceptanceId and provides zero frozen-manifest coverage.

`AcceptanceTests.ExecuteFrozenManifestEvidence` deterministically runs the named cases in `Scenarios`, including parameterized boundary subcases. Every case enters the production boundary. `FixtureAudit` records actual initial fields, scheduled inputs, submitted terms, profiles, and provenance for each world. `InvariantOracle` independently reconstructs material, attitude, residence, debt and cause facts from the initial fixture and committed history; it never calls the production recognizer, scorer, validator, or transition helpers.

Repair-v2 adds public-API regressions in `RepairScenarios.cs`, `RepairResolutionScenarios.cs`, and `RepairKnowledgeScenarios.cs`. These reproduce F1-F3, exchange proposal IDs, reverse fixed-ID inputs, audit aggregate capacities and compatible controls, and hold personal inputs constant under hidden-world perturbations. Fixture evidence also records the actual personal input view and observation provenance. The attitude checker derives the complete mandatory cause set from initial need, maintenance and consequential outcomes before inspecting contributions; a detached witness that omits a cause and consistently adjusts final attitude must fail. This is a checker-adequacy control, not an injected production mutant or independent K4 review.

Canonical root testing writes these ignored artifacts, also published by canonical CI:

- `artifacts/acceptance/slice1-results.json` and `.md`: every frozen row, unchanged classification, assertion-backed status and evidence references;
- `cases.json`: per-case execution/failure, source clauses, evidence categories and oracle basis;
- `fixture-audit.json`: per-subcase actual writes, profiles, proposal terms, invariant result and fallback markers;
- `oracle-audit.json`: independent-checker dependencies and source audit;
- `fault-controls.json`: focused negative/structural controls separately from actual injections and their outcome classifications.

Unknown manifest IDs, duplicate manifest IDs/case names, missing or failed coder-owned REQUIRED evidence, or checker dependence on assertion-target production logic fail the runner. Reports preserve failures rather than silently dropping rows. The readiness check requires all 127 coder-owned REQUIRED rows to pass. The 128th REQUIRED row, `S1-GLOBAL-CONFORMANCE`, stays explicitly awaiting independent review; the full frozen completion gate remains unsatisfied. This distinction does not reclassify or waive that row.

Mutation-framework execution is not claimed. The frozen manifest Part G permits focused negative tests and structural evidence. Actual duplicate-cause and premature-closure challenges are internal test seams; corrupt material/attitude witnesses challenge the independent checker. Faults not actually injected remain visibly unexercised as mutations, even when their REQUIRED fault-control row passes through a focused negative scenario. No crash or timeout automatically counts as semantic detection.

Before IMP-0001 can be VERIFIED COMPLETE:

- every REQUIRED AcceptanceId must have substantive evidence;
- no REQUIRED row may be missing or skipped;
- DEFERRED / N-A / UNEXERCISED rows must remain separately visible;
- oracle independence and fixture-write rules must hold;
- CI must emit the manifest-indexed completion report;
- fresh independent post-implementation conformance review must PASS.

## IMP-0003 repair-v3 evidence

`HouseholdWarrantOracle.cs` completes the independent formation, exit-continuation and lineage checks alongside `HouseholdOracle.cs`. Both files are covered by the dependency audit. Candidate declarations are passed as laboratory inputs; expected Recognition predicates and historical warrant checks do not call production classifiers.

`HouseholdRepairV3Scenarios.cs` adds 63 detached corruptions with four valid controls, eight disconnected-Household compatible-loan permutations, and six positive capacity/communication/favour-debt fallback runs. `slice3-repair-v3-controls.json` records each named result and is included in the canonical CI acceptance artifact. All frozen manifests and the inherited S1-084 structural audit remain unchanged.


## IMP-0003 repair-v4 evidence

`HouseholdProjection.cs` compares Household-connected detached commits using boundary-preserving causal identities for newly allocated ordinary relations, events, evidence and embedded factual payloads. It retains Household/warrant/association identities, action outcomes, communication hops and subject-relevant evidence precedence. Own-state refreshes name the accumulated material causes, so the incidental last compatible transfer is not treated as their sole origin.

The independent Household oracle reconstructs stable lifecycle publications and verifies exact event/time, Household, state, causes, participants and rules/configuration. `SemanticEvent.AcquiredEvidence` contains observer-only receipts for direct Household evidence and retained communication acquisitions. The checker derives their content/provenance from actual causal events and delivery payloads, replays Household evidence retention, checks exact stable held IDs, and binds same-cycle warrant bases to those receipts. It does not call production classifiers or use another warrant's basis as the identity oracle.

`HouseholdRepairV4Scenarios.cs` adds eight connected-loan permutations, four ordinary favour/marriage allocation controls, six connected positive-fallback controls, 21 lifecycle corruptions with four valid lifecycle controls, and three fabricated Recognition ID corruptions including same-cycle handoff and communication. The canonical artifact includes every named outcome in `slice3-repair-v4-controls.json`. All earlier repairs, frozen manifests and S1-084 structural evidence remain unchanged.
