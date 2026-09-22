# IMP-0001 — Slice-1 Dispatch and Release Record

**Status:** RELEASED / DISPATCHED  
**Date:** 2026-09-22  
**Task:** `IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`  
**Context mode:** PROJECT-CONTEXT  
**Implementation branch:** `implementation/imp-0001-slice1`

## 1. Release decision

**RELEASE.**

The consequential specification→implementation assurance gate is satisfied for Slice 1:

- TRES-0010: CLOSED / PASS;
- accepted semantic/architectural authority is explicitly listed by IMP-0001;
- frozen completion applicability exists independently of the coder;
- no known unresolved issue requires the implementer to invent project meaning;
- deliberate later-slice gaps remain explicit/deferred;
- local C# engineering risks have bounded guardrails;
- architecture/authority conflicts retain explicit escalation paths.

Release authorizes implementation **inside the accepted contracts**. It is not a claim that the implementation is already correct.

## 2. Frozen completion authority

- manifest: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- version: `SFL-V0-S1-ACCEPTANCE-v1`
- frozen ref: `sfl-v0-slice1-acceptance-v1`
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`
- final frozen manifest blob SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- independent pre-code review: PASS

Dispatch integrity check re-read the manifest from canonical `main`, the frozen ref, and the dispatch branch. All three resolved to the exact frozen blob SHA above.

IMP-0001 may not edit, weaken, delete, replace, or reclassify this authority.

## 3. SCF-001 — implemented

Canonical toolchain:

- C# 14;
- .NET 10 LTS;
- exact SDK: `10.0.401`;
- test runner: Microsoft Testing Platform;
- MSTest SDK: `4.4.1`;
- nullable + .NET analyzers + warnings-as-errors;
- deterministic build flag.

Canonical root verification sequence:

```bash
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

The same sequence is executed by `.github/workflows/ci.yml`.

Dispatch scaffold promotion:

- PR: #6 — `Dispatch IMP-0001 Slice 1 implementation`
- scaffold merge commit: `5aec618f188187cbe1286624e081760fca6d39ef`
- first PR run exposed a scaffold defect: MSTest analyzer `MSTEST0032` rejected trivial always-true smoke assertions;
- the assertions were repaired rather than suppressing/weaking the analyzer;
- repaired PR CI run: `35684174431` — PASS;
- canonical post-merge `main` CI run: `35684220185` — PASS.

The original SCF-001 reminder was retired from the Scaffolding Trigger Register; the actual files/CI are now durable authority for root verification.

## 4. SCF-002 — fired / active

The frozen acceptance authority was already protected before dispatch.

Dispatch created the executable acceptance project/CI surface, but **does not claim frozen-manifest coverage**. The bootstrap acceptance smoke test is deliberately unmapped to any AcceptanceId.

Active IMP-0001 obligation:

- map substantive executable/structural evidence to every REQUIRED AcceptanceId;
- zero REQUIRED rows missing or skipped;
- keep DEFERRED / N-A / UNEXERCISED visible;
- obey fixture-write and oracle-independence rules;
- emit manifest-indexed completion reporting in canonical CI;
- obtain fresh independent post-implementation conformance PASS.

SCF-002 remains in the trigger register until that completion evidence makes the executable acceptance configuration/report the durable authority.

## 5. Repository scaffold

The dispatch establishes only implementation infrastructure:

- `Mesopotamia.Sim.slnx`;
- `src/Mesopotamia.Sim/`;
- `tests/Mesopotamia.Sim.Tests/`;
- `tests/Mesopotamia.Sim.AcceptanceTests/`;
- `global.json`;
- `Directory.Build.props`;
- `.editorconfig`;
- canonical GitHub Actions verification workflow.

No Slice-1 social/domain behavior was implemented by the dispatch scaffold.

## 6. Implementation branch / work-state rule

Persistent Slice-1 domain work occurs on:

`implementation/imp-0001-slice1`

Implementation should proceed in recoverable increments following IMP-0001's milestone order.

The implementation agent may make the packet's listed local choices. It must stop/escalate rather than modifying accepted semantics, persistent identity/representation, execution model, frozen acceptance authority, or other higher-level commitments.

## 7. Completion boundary

IMP-0001 is not complete merely because CI is green.

`VERIFIED COMPLETE` still requires:

- substantive evidence for every REQUIRED AcceptanceId;
- complete manifest-indexed result reporting;
- invariants/metamorphic/fault-control evidence;
- fixture-write audit;
- oracle-independence audit;
- frozen manifest integrity;
- fresh independent post-implementation conformance-review PASS.

Until then, status remains **IN PROGRESS**.
