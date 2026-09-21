# C# / .NET Engineering Guardrails

**Status:** ACTIVE ENGINEERING CONTEXT NOTE  
**Applies to:** C# 14 / .NET 10 LTS host implementation.

Keep these risks visible during implementation:

1. **Memory shape matters.** Avoid unnecessary per-entity heap objects and allocations in hot paths; measure GC, allocations, and RSS as scale grows.
2. **Mutation stays narrow.** Behavioral code reads/query state and emits proposals; authoritative mutation remains in the commit path.
3. **Semantic ordering is explicit.** Never let collection iteration order determine simulation outcomes.
4. **Randomness is simulation-owned.** Do not use runtime-global or `System.Random` behavior as the reproducibility contract.
5. **Numeric determinism is deliberate.** Define the policy before floating-point scores can change irreversible branches.
6. **Persistence uses versioned data contracts.** Never treat CLR object-graph serialization as continuation authority; rebuild indexes/caches where practical.
7. **Toolchain is pinned.** Pin SDK, C# language version, and analyzer baseline; upgrade deliberately through regression tests.
8. **Builds enforce quality.** Enable nullable analysis and Roslyn analyzers; important warnings/analyzer findings should fail CI.
9. **AI-generated complexity is suspect by default.** Watch for unnecessary LINQ/allocation in hot paths, shared mutable objects, reflection/dynamic shortcuts, speculative abstractions, async/framework layers, unsafe/native code, and new dependencies without a measured need.
10. **Optimize from evidence.** Preserve readable reference behavior and specialize only measured bottlenecks behind stable semantic boundaries.

Supporting evidence: `research/technical/TRES-0002/CSHARP_DOTNET_ADVERSARIAL_REVIEW.md`.
