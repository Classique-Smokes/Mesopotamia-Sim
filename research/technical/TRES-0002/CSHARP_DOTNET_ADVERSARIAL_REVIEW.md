# TRES-0002 — Adversarial Review: C# / .NET 10 Host

**Status:** ADVISORY RESEARCH  
**Date:** 2026-09-20  
**Target:** C# 14 / .NET 10 LTS as host for the accepted Reference Simulation Kernel

## Finding

**No architecture-level blocker found.**

C# / .NET 10 remains the recommended host for final approval because the project-specific benchmark shows sufficient performance headroom while the platform offers a comparatively strong development-risk and verification profile.

This review does not approve the host/runtime.

## Evidence

Common-machine bake-off, exact target runtime:

- .NET SDK 10.0.401 / runtime 10.0.12;
- correctness fixture and fresh-process checkpoint continuation passed;
- P4: 300,000 actors / 4.8 million relations;
- warm median decision + commit + process execution: ~26 ms;
- process peak working set: ~497 MB;
- object-heavy P4 baseline allocated ~429 MB managed state and triggered Gen2 collections;
- 40,000 relation-churn operations: ~15.9 ms.

Official support policy lists .NET 10 as active LTS through 2028-11-14.

## Adversarial findings

### Managed memory / GC — real risk, not blocker

Millions of heap objects can create material memory and GC pressure. The P4 baseline already shows this.

Mitigation: keep semantic stores behind stable state/query boundaries, measure allocations/GC from the first scaling runs, and move only measured hot stores toward denser arrays/value layouts when justified. Simulated time must remain independent of GC/wall-clock timing.

### Mutation discipline — real risk, not blocker

C# does not enforce ownership like Rust. Carelessly exposed mutable records could bypass proposal/commit semantics.

Mitigation: behavioral code receives read/query surfaces; mutation APIs remain concentrated in the commit path; architecture/invariant tests detect bypasses. Do not expose general mutable collections as domain APIs.

### Determinism — requires explicit guardrails

Do not rely on:
- `Dictionary` / `HashSet` iteration order for semantic ordering;
- `System.Random` for cross-version reproducibility;
- unquantized floating-point behavior where tiny differences can change irreversible branches.

The accepted kernel already provides the required seams: explicit ordering, simulation-owned randomness, and deterministic verification. A numeric determinism policy remains a prototype-spec concern.

### Persistence / migration — manageable

Do not serialize CLR object graphs as continuation authority.

Use explicit versioned checkpoint schemas, rebuildable indexes, migration/compatibility tests, and semantic hashes. Runtime upgrades must not define save-file meaning.

### AI-assisted maintenance — favorable with enforced gates

C# cannot prevent poor AI-generated architecture. Likely failure modes include excess allocation/LINQ in hot paths, casual shared mutation, unnecessary async/framework layers, reflection/dynamic shortcuts, and speculative abstraction.

The platform provides strong mechanical containment:
- nullable flow analysis;
- built-in Roslyn analyzers;
- warnings/analyzer findings can fail builds;
- deterministic tests and runtime diagnostics are mature.

Project inference: C# offers a better balance than Rust's higher implementation friction and Julia's greater reliance on specialist performance discipline. This is supported by the bake-off and toolchain behavior, but is not a direct controlled benchmark of AI code-generation quality.

### Toolchain evolution — manageable

.NET 10 is LTS, but the project will outlive one runtime release.

Mitigation:
- pin the SDK and C# language version in-repo;
- use no preview language features;
- pin analyzer rule level rather than `latest`;
- upgrade runtime/LTS versions deliberately through the full deterministic regression suite.

### Optimization escape path — adequate

The accepted representation permits progressive movement from readable managed records toward arrays, value layouts, `Span<T>`/`Memory<T>`, batching, vectorization, or isolated native code without redefining domain semantics.

The benchmark does not justify native or unsafe code for the reference prototype.

## Required implementation guardrails if C# is approved

1. Target `net10.0` / C# 14; no preview features.
2. Pin SDK and analyzer rule level; update deliberately.
3. Enable nullable analysis and strict build diagnostics.
4. Semantic order must be explicit; unordered-container iteration is never causal ordering.
5. Use simulation-owned deterministic randomness, not `System.Random`.
6. Use explicit versioned checkpoints; never runtime object-graph serialization.
7. Keep mutation behind proposal/resolution/commit.
8. Keep runtime async/tasks/coroutines out of authoritative simulated process state.
9. Include deterministic scenario tests plus allocation/GC/memory measurements in scaling gates.
10. Add dependencies, unsafe/native code, concurrency, or heavyweight frameworks only when a measured problem justifies them.

## Residual uncertainty

The review did not run a controlled multi-agent code-maintenance experiment across C#, Rust, and Julia. The AI-maintainability judgment therefore combines project-specific implementation evidence with compiler/tooling characteristics rather than direct comparative AI-edit statistics.

## Recommendation

Advance **C# 14 / .NET 10 LTS** to final host/runtime approval.

Do not commission further language research unless new evidence exposes a blocker. After approval, define the minimal C# implementation guardrail/configuration files and proceed to Social Fabric Laboratory v0 specification.

## External references

- .NET support policy: https://dotnet.microsoft.com/en-us/platform/support/policy
- .NET code analysis: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview
- Nullable reference types: https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references
- EventPipe diagnostics: https://learn.microsoft.com/en-us/dotnet/core/diagnostics/eventpipe
- GC fundamentals: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/
- Memory and spans: https://learn.microsoft.com/en-us/dotnet/standard/memory-and-spans/
- System.Random stability note: https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-random
