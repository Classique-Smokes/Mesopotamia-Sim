# Slice-1 Acceptance Test Surface

This project is the executable verification surface for IMP-0001.

Authority:

- semantic meaning: accepted SFL specification / ADRs listed by IMP-0001;
- completion applicability: frozen `SFL-V0-S1-ACCEPTANCE-v1`;
- frozen manifest SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`.

The production implementer may map executable evidence to AcceptanceIds but may not edit or reclassify the frozen manifest.

The dispatch-scaffold smoke test in this project proves only that the test runner executes. It is **not** mapped to any AcceptanceId and provides zero frozen-manifest coverage.

Before IMP-0001 can be VERIFIED COMPLETE:

- every REQUIRED AcceptanceId must have substantive evidence;
- no REQUIRED row may be missing or skipped;
- DEFERRED / N-A / UNEXERCISED rows must remain separately visible;
- oracle independence and fixture-write rules must hold;
- CI must emit the manifest-indexed completion report;
- fresh independent post-implementation conformance review must PASS.
