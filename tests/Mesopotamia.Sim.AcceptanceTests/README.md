# Slice-1 and Slice-2 Acceptance Test Surface

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
