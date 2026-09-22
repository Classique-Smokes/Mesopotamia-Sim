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


## Slice-1 TRES-0010 implementation-local safeguards

These are local implementation safeguards confirmed by the TRES-0010 pre-code review. They do not change accepted simulation architecture or social semantics.

1. **Snapshot isolation is real, not nominal.** The common committed decision snapshot must not alias mutable authoritative collections/records in a way that lets later commits change what an earlier personal/response context observes. Avoid deferred LINQ/enumeration over live mutable sources where snapshot semantics are required; materialize or otherwise guarantee stable snapshot reads.
2. **Stable identity and equality are explicit.** Domain identity/equality must follow stable semantic IDs, not mutable record contents, current container position, runtime object identity, or default equality behavior that accidentally includes mutable fields.
3. **Authoritative text ordering is deliberate.** If strings/text ever participate in authoritative ordering, keys, or tie-breaking, use an explicitly chosen deterministic ordinal/comparer policy. Do not inherit culture/current-process comparison semantics accidentally.
4. **Integer scoring/arithmetic is bounded deliberately.** Use checked arithmetic or explicit validated bounds wherever component sums/deltas could overflow. Silent integer overflow must never alter a decision branch.
5. **Acceptance/oracle separation is preserved.** Production classifiers/validators/scorers whose output is under judgment must not be reused as the independent oracle that certifies that result. The frozen Slice-1 manifest is not editable from IMP-0001.
6. **Tests are isolated from shared mutable process state.** Avoid shared mutable statics/singletons that can make test order, parallel test execution, or prior runs influence semantic results. Where unavoidable tooling state exists, reset/isolate it explicitly and prove observer/test ordering does not affect simulation state.

These safeguards should be reflected in implementation review and completion evidence where applicable rather than expanded into speculative framework abstractions.
