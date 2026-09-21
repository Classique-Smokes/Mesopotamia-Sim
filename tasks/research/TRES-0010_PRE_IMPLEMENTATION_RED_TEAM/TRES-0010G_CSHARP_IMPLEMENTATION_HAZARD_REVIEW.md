# Research Task Packet — C# / .NET Semantic Hazard Review

**Task ID:** TRES-0010G  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT  
**Return:** `research/technical/TRES-0010/returns/TRES-0010G_CSHARP_HAZARD_REPORT.md`

## 1. Question

What concrete C#/.NET implementation patterns could make a seemingly idiomatic Slice-1 implementation violate accepted SFL semantics or determinism?

## 2. Why it matters now

The coding agent will be optimizing for readable, idiomatic C#. Some ordinary platform patterns are harmless; others can silently turn representation details into simulation semantics.

## 3. Attack surface

Review likely hazards involving:

- `Dictionary` / `HashSet` iteration order;
- mutable keys / value equality confused with semantic identity;
- reference aliasing/shared mutable records;
- LINQ ordering and hidden allocations in hot/reference paths;
- floating point or implicit numeric conversions in scoring;
- `System.Random` / runtime-global randomness;
- test parallelism and shared static state;
- DateTime/wall-clock leakage into simulated time;
- task/async scheduling accidentally becoming causal order;
- CLR object-graph serialization becoming persistence authority;
- non-versioned config/profile loading;
- hash codes used as persistent IDs/order keys;
- reflection/dynamic/deserialization shortcuts that bypass invariants;
- exceptions used as domain outcomes;
- record equality silently substituting for historical identity.

## 4. Required context

- ADR-0001, ADR-0003, ADR-0004, ADR-0005;
- C# engineering guardrails;
- SPEC §§5, 9, 10;
- IMP-0001.

Current external documentation may be consulted if needed; state exact .NET/C# version assumptions.

## 5. Evidence standards

Distinguish:

- actual platform behavior / documented constraint;
- plausible AI-coding failure mode;
- project recommendation.

Do not elevate a style preference into architecture.

## 6. Boundaries

Host/runtime choice is accepted. Do not reopen C# vs Rust/Java/etc unless a previously unknown blocker exists.

## 7. Required output

Return a prioritized hazard checklist suitable for incorporation into IMP-0001 or executable verification where justified.

## 8. Authority reminder

Advisory only.
