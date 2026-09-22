# IMP-0001 — Implementation Agent Execution Handoff

**Status:** ACTIVE BRANCH-LOCAL EXECUTION NOTE  
**Authority:** Operational handoff subordinate to IMP-0001, accepted decisions/ADRs/SPEC, and frozen acceptance authority  
**Branch:** `implementation/imp-0001-slice1`  
**Branch base:** canonical `main` @ `794b9a04a0d93494cae6c5e3a2236ee0a22cc3fb`  
**Date:** 2026-09-22

## Start sequence

Begin from repository artifacts, not chat memory:

1. `AGENTS.md`
2. `plans/CURRENT_PHASE.md`
3. `tasks/implementation/IMP-0001_DISPATCH_RECORD.md`
4. `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
5. retrieve the task packet's listed accepted decisions/ADRs/SPEC, frozen verification sources, assumptions, and engineering guardrails.

This is **PROJECT-CONTEXT** implementation work.

## Frozen completion authority

Before domain changes, confirm:

- manifest: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- version: `SFL-V0-S1-ACCEPTANCE-v1`
- required blob SHA: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`

Do not edit, weaken, delete, replace, or reclassify the manifest.

The existing acceptance bootstrap smoke test is tooling evidence only. It maps to **zero** AcceptanceIds.

## Execution discipline

Implement IMP-0001 in recoverable increments, following the packet's milestone order unless a concrete dependency justifies a different internal ordering.

Commit meaningful milestones to this branch. Keep canonical root commands green:

```bash
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Do not:

- change accepted semantics/architecture to simplify coding;
- weaken tests, analyzers, CI, or frozen completion authority;
- fake DEFERRED/later-slice semantics;
- use runtime/container iteration order as semantic order;
- reuse assertion-target production logic as its own independent oracle;
- add broad frameworks/dependencies without demonstrated Slice-1 need;
- merge this branch to `main`.

If a packet escalation condition occurs, stop the affected work, preserve the recoverable branch state, and return an escalation rather than inventing a resolution.

## Acceptance-surface requirement

Build substantive executable/structural evidence for every REQUIRED AcceptanceId.

Completion-candidate reporting must expose:

- every REQUIRED AcceptanceId separately;
- zero missing/skipped REQUIRED rows;
- DEFERRED / N-A / UNEXERCISED separately;
- invariant, determinism/metamorphic, fixture, oracle-independence, and mutant/fault-control evidence required by the frozen manifest.

## Required branch return artifact

Create and maintain:

`tasks/implementation/IMP-0001_IMPLEMENTATION_REPORT.md`

The report must satisfy IMP-0001 §11 and identify exact commands/results and frozen manifest identity.

## End state

The coding agent must **not** award itself the independent post-implementation conformance PASS.

When all coder-owned implementation and verification obligations are complete, return the branch as:

**IMPLEMENTATION CANDIDATE COMPLETE / AWAITING INDEPENDENT CONFORMANCE**

with the implementation report committed.

Only a fresh independent reviewer can supply the conformance evidence required before the Master Architect may accept `VERIFIED COMPLETE`.
