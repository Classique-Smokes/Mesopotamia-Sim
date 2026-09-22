# Slice-1 Acceptance Test Surface

This project is the executable verification surface for IMP-0001.

Authority:

- semantic meaning: accepted SFL specification / ADRs listed by IMP-0001;
- completion applicability: frozen `SFL-V0-S1-ACCEPTANCE-v1`;
- frozen manifest SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`.

The production implementer may map executable evidence to AcceptanceIds but may not edit or reclassify the frozen manifest.

The dispatch-scaffold smoke test in this project proves only that the test runner executes. It is **not** mapped to any AcceptanceId and provides zero frozen-manifest coverage.

`AcceptanceTests.ExecuteFrozenManifestEvidence` deterministically runs the named cases in `Scenarios`, including parameterized boundary subcases. Every case enters the production boundary. `FixtureAudit` records actual initial fields, scheduled inputs, submitted terms, profiles, and provenance for each world. `InvariantOracle` independently reconstructs material, attitude, residence, debt and cause facts from the initial fixture and committed history; it never calls the production recognizer, scorer, validator, or transition helpers.

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
