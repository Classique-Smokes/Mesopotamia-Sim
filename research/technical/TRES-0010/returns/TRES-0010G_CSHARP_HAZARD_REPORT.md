# TRES-0010G — C# / .NET Semantic Hazard Report

## Run provenance

- **Task ID:** TRES-0010G
- **Frozen baseline ref:** `tres-0010-review-baseline`
- **Resolved baseline commit SHA:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Assigned return branch:** `tres-0010/g`
- **Branch starting SHA:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac` (identical to frozen baseline)
- **Model/configuration:** GPT-5.6 Sol; no additional operator-visible reasoning configuration
- **Workspace mode:** isolated GitHub branch
- **Tools used:** GitHub repository connector; web search for current Microsoft Learn platform documentation
- **Runtime assumption reviewed:** C# 14 on .NET 10 LTS, no preview features
- **External web research:** yes; official Microsoft Learn only (listed below)
- **Prior TRES-0003–TRES-0009 returns/conclusions read:** no. Current canonical artifacts that cite earlier TRES work were read as required project authority; no earlier TRES return file was opened.
- **Sibling Wave-A returns read before initial report:** **no**

## Executive finding summary

**Recommendation: AMEND BEFORE IMPLEMENTATION.**

No previously unknown defect warrants reopening the accepted C# 14 / .NET 10 LTS host choice. The accepted semantics, IMP-0001, engineering guardrails, and Stage-3 verification already reject most obvious runtime leakage: nonsemantic collection order, stochastic/global randomness, wall-clock time, concurrency, CLR-object-graph persistence, and floating-point scoring are either explicitly forbidden or strongly fenced.

One implementation-specific gap should be made explicit before Slice 1 coding begins:

1. **HIGH_REPAIR_BEFORE_CODE — false committed snapshots through aliasing or deferred enumeration.** Ordinary C# record copying and LINQ can preserve references or defer reads into mutable authoritative collections. A response/decision trace can therefore observe post-snapshot mutations even in a single-threaded kernel unless snapshot ownership/materialization is made explicit.

Additional concrete hazards are real but are already substantially constrained by current authority and verification. They should be converted into a short implementation checklist and focused tests rather than new social semantics:

2. deterministic ID allocation and order-frontier ownership;
3. identity equality and dictionary-key discipline;
4. complete semantic comparers rather than collection/source-order leakage;
5. explicit ordinal comparison for machine-defined textual keys;
6. checked/validated integer-score aggregation;
7. no exception/reflection/deserialization shortcut around domain outcomes and invariants.

No finding requires an architectural change. The recommended repairs belong in IMP-0001 / engineering guardrails / executable Slice-1 verification.

## Prioritized hazard checklist

| Priority | Hazard | Required guard |
|---|---|---|
| P0 | Snapshot aliases mutable authoritative state or crosses a phase boundary as deferred `IEnumerable<T>` | Snapshot data used by deliberation/responses must be phase-stable; materialize queries at the boundary and avoid mutable shared references |
| P1 | `Guid.NewGuid()`, `GetHashCode()`, allocation position, or ambient state becomes semantic ID/order | Simulation-owned deterministic ID allocator/frontier; persist/trace the order frontier as future-influencing state |
| P1 | Record/value equality silently substitutes for semantic identity; mutable object used as hash key | Key indexes by stable typed IDs; identity comparisons use IDs; key hash/equality inputs are immutable |
| P1 | `Dictionary` iteration, stable LINQ sorting, or unstable `List.Sort` becomes an undeclared tie-break | Every outcome-relevant ordering has a complete explicit comparer ending in the allowed semantic/domain key or logged stable-ID fallback |
| P2 | Machine identifiers/config/action keys use culture-sensitive textual comparison | Use explicit ordinal equality/order for machine-defined text; add culture-permutation test if strings can participate in semantic ordering |
| P2 | Exact integer score sum overflows silently | Validate score/component ranges and aggregate in a checked context (or wider validated type); overflow is an explicit failure, never a wrapped ranking |
| P2 | Exceptions or direct deserialization/reflection encode domain failure or bypass central transitions | Domain outcomes remain explicit typed results; fixture/config deserialization cannot instantiate impossible authoritative state behind invariants |
| P2 | Shared static state, wall clock, `Random`, `Task`/PLINQ affects semantics | Keep these outside authoritative simulation behavior; tests must remain isolated even if the test runner itself executes tests concurrently |

---

## Detailed findings

### TRES-0010G-F01 — A C# “snapshot” can remain live through reference aliasing or deferred LINQ

- **Classification:** implementation hazard
- **Severity:** **HIGH_REPAIR_BEFORE_CODE**

**Project evidence**

- ADR-0004 requires a common committed-state read phase before deliberation/proposal and says authoritative mutation occurs only later through resolution/commit.
- SPEC-SFL-0001 §5.1 requires every `ResponseDecisionContext` to read the same committed cycle snapshot used by deliberation and not observe uncommitted effects.
- IMP-0001 §3.6 explicitly requires “read committed snapshot” before personal proposals/responses/resolution/commit.
- The C# guardrails already warn against shared mutable objects and unnecessary LINQ, but do not state the phase-stability rule concretely.

**Platform behavior / documented constraint**

C# records provide value-oriented syntax, but copying a record does not deep-copy nested reference-type state. Microsoft’s record documentation demonstrates that nondestructive mutation via `with` performs a shallow copy: referenced arrays/objects remain shared unless explicitly copied.

LINQ uses deferred execution extensively. A stored `IEnumerable<T>` query can read its source when later enumerated rather than when the query variable was created.

**Smallest failure trace**

1. At the common decision snapshot, code stores `snapshot.Relations = world.Relations` or `var candidates = world.Relations.Where(...)`.
2. Deliberation produces proposals.
3. During central commit/reaction processing, `world.Relations` changes.
4. A later response decision, diagnostic trace, or candidate enumeration reads the aliased/deferred sequence.
5. The result reflects post-snapshot state even though the code never used threads, wall clock, or explicit global mutation from behavioral code.

This violates the accepted visibility contract while looking idiomatic and testable in ordinary unit tests.

**Does existing authority answer it?**

The semantic answer is clear: later phases must not see a mutated “snapshot.” What is missing is a C#-specific implementation guard/probe that prevents a shallow/deferred representation from accidentally defeating that rule.

**Consequence if ignored**

- response choices can depend on commit order;
- traces can disagree with the state actually used for selection;
- observer code can perturb when enumeration happens;
- storage/insertion permutation tests may pass while phase visibility is still wrong;
- later checkpoint work inherits an ambiguous boundary between authoritative and derived/live views.

**Recommended disposition**

Amend IMP-0001 or the engineering guardrails before dispatch:

- snapshot-facing collections/records must be immutable or otherwise guaranteed phase-stable;
- no deferred `IEnumerable<T>` whose source is mutable authoritative state may cross a semantic phase boundary;
- materialize outcome-relevant queries at the declared snapshot boundary;
- do not expose mutable collection references through snapshot/domain read APIs.

Add a focused test: capture the decision snapshot, mutate authoritative backing state only through the later legal commit path, and prove that already-created personal/response contexts and their traces still observe the original snapshot.

**Confidence:** high.

---

### TRES-0010G-F02 — ID generation can import ambient nondeterminism even when the ID type itself is stable

- **Classification:** implementation hazard
- **Severity:** **MEDIUM_AMEND_OR_GUARD**

**Project evidence**

- ADR-0001 forbids semantic identity derived from mutable content, runtime allocation/container position, or similar representation details.
- ADR-0004 requires reproducible continuation and says runtime details must not become authority.
- SPEC-SFL-0001 §9.6 explicitly includes identifier/order state in checkpointed future-influencing state.
- IMP-0001 permits the implementation agent to choose the concrete deterministic semantic-ID type while requiring repeated-run identity/history determinism and stable-ID fallback tests.

**Platform behavior / documented constraint**

- `Guid.NewGuid()` returns a newly generated version-4 UUID using OS randomness; it is not a deterministic replay allocator.
- `Object.GetHashCode()` is not a permanent identifier. Microsoft explicitly warns not to persist hash codes or use them outside the application domain in which they were created.

**Smallest failure trace**

Two identical runs allocate proposal/person IDs with `Guid.NewGuid()`. Social decisions are otherwise deterministic. History IDs differ; if a symmetric tie uses those IDs, the winning candidate may differ as well.

A similar failure occurs if `GetHashCode()` is used as an order key or persisted ID: process/runtime differences can change the value.

**Does existing authority answer it?**

Yes at the semantic level, and IMP-0001’s repeated-run/fallback tests should expose obvious violations. The concrete C# trap is still worth an explicit “never use for semantic identity/order” checklist item.

**Consequence if ignored**

Replay/history equality fails and stable-ID fallback can become covert randomness.

**Recommended disposition**

Use a simulation-owned deterministic allocator/frontier whose state is explicit future-influencing state. Prohibit `Guid.NewGuid()`, runtime hash codes, reference hashes, allocation order, and object addresses as semantic IDs/order keys. Add a repeated-run assertion over the generated ID sequence, not only final domain state.

**Confidence:** high.

---

### TRES-0010G-F03 — Record/value equality and mutable dictionary keys can collapse historical identity or corrupt indexes

- **Classification:** implementation hazard
- **Severity:** **MEDIUM_AMEND_OR_GUARD**

**Project evidence**

ADR-0001 requires independently identified records and stable semantic identity. IMP-0001 nevertheless correctly leaves ordinary `record`/`class`/`struct` choices local, which means the coding agent must not confuse a C# convenience with the identity model.

**Platform behavior / documented constraint**

- C# records implement value equality. Distinct record instances with equal component values compare as equal unless identity is explicitly represented in that equality.
- `Dictionary<TKey,TValue>` requires a key’s hash-code-relevant state to remain stable while it is used as a key; Microsoft warns that mutation affecting the hash can make the entry effectively unreachable.

**Smallest counterexamples**

- Two distinct historical `Debt` or transfer records with identical fields are inserted into a `HashSet<Record>`; default record value equality deduplicates them although the simulation requires distinct historical identities.
- A mutable entity object itself is a dictionary key. A property participating in equality/hash changes, and later lookup by the same semantic entity fails.

**Does existing authority answer it?**

Yes: semantic identity is independent and stable. The hazard is that idiomatic C# generated equality can silently implement a different rule.

**Consequence if ignored**

Independent events/entities merge, indexes lose entries, or history/reference resolution ceases to be faithful.

**Recommended disposition**

- index authoritative entities by explicit typed stable ID;
- compare historical/entity identity by that ID, not by incidental record-value equality;
- use value records for values/terms where value equality is genuinely semantic;
- do not use mutable domain objects as hash keys unless equality/hash inputs are immutable by construction.

Add a regression with two same-content/different-ID records and a key-stability test.

**Confidence:** high.

---

### TRES-0010G-F04 — Sorting APIs do not supply the project’s semantic tie contract

- **Classification:** implementation hazard
- **Severity:** **MEDIUM_AMEND_OR_GUARD**

**Project evidence**

- ADR-0004 and the C# guardrails require semantic ordering to be explicit.
- SPEC-SFL-0001 §§5 and 9 require declared domain tie keys or logged stable-semantic-ID fallback.
- IMP-0001 and the verification contract already require storage/input permutation invariance and include a mutant for iteration-order tie-breaking.

**Platform behavior / documented constraint**

- Microsoft documents `Dictionary<TKey,TValue>` enumeration order as undefined.
- `List<T>.Sort` is documented as an unstable sort: equal-key elements may not retain their original order.
- LINQ `OrderBy` is stable: equal-key elements retain source order. That is useful behavior, but **source order is not a semantic tie-break** when the source itself came from a nonsemantic collection.

**Smallest failure traces**

- `dictionary.Values.OrderBy(x => x.Priority).First()` appears sorted, but exact priority ties inherit the dictionary/source enumeration order.
- `list.Sort((a,b) => a.Priority.CompareTo(b.Priority))` has no complete tie comparer, so equal priorities can reorder arbitrarily.

**Does existing authority answer it?**

Yes. This is not a missing semantic rule. Existing metamorphic permutation verification is strong evidence against the defect, but the implementation checklist should make the API-level failure mode explicit.

**Consequence if ignored**

An invisible container/source order becomes causal order or fallback without being logged.

**Recommended disposition**

Require every outcome-relevant comparer to define the full accepted order through the declared domain key and, only when permitted, stable-ID fallback. Do not treat sorting stability as a substitute for a semantic tie key. Exercise tests by rebuilding dictionaries/sets with different insertion orders, not merely shuffling an already materialized list.

**Confidence:** high.

---

### TRES-0010G-F05 — Culture-sensitive text comparison can make a “stable” textual key environmentally unstable

- **Classification:** implementation hazard
- **Severity:** **MEDIUM_AMEND_OR_GUARD**

**Project evidence**

The spec permits stable semantic IDs as technical fallback and requires deterministic repeated execution. IMP-0001 leaves the concrete ID type and internal configuration representation local.

**Platform behavior / documented constraint**

Microsoft’s string-comparison guidance distinguishes culture-sensitive comparison from ordinal comparison and recommends explicit ordinal semantics for non-linguistic identifiers. Culture-sensitive sorting can produce different orderings under different culture settings.

**Smallest failure trace**

The implementation chooses string IDs or textual action/profile keys and orders them through a culture-sensitive default comparison. Two otherwise identical runs under different `CurrentCulture` values can produce different fallback/order results.

**Does existing authority answer it?**

The semantic requirement is already deterministic; the concrete comparer rule is not stated.

**Consequence if ignored**

Environment locale leaks into causal order, trace ordering, or technical fallback.

**Recommended disposition**

Use explicit ordinal equality/order for machine-defined strings (`StringComparer.Ordinal` or an equivalent explicit comparer). Prefer a semantic-ID representation with an explicit total comparer. Add a culture-permutation metatest if any textual value participates in authoritative ordering.

**Confidence:** medium-high.

---

### TRES-0010G-F06 — Exact integer scoring removes floating-point drift but not unchecked integer overflow

- **Classification:** implementation hazard
- **Severity:** **DEFERRED_RISK**

**Project evidence**

SPEC-SFL-0001 §5 and `REFERENCE_SCORING_PROFILES.md` deliberately require exact integer components and exact summation; the accepted kinship 1.5x effect is encoded as integer `2*a` versus `3*a`. This successfully avoids floating-point rounding as a current Slice-1 semantic problem.

**Platform behavior / documented constraint**

C# integral arithmetic outside a checked context can overflow without throwing; unchecked overflow wraps/truncates according to the integral operation.

**Smallest failure trace**

A future or malformed profile introduces sufficiently large components that `int FinalScore = components.Sum(...)` overflows. A genuinely highest-score candidate becomes negative and loses.

**Does existing authority answer it?**

The current canonical profiles appear far from overflow, so this does not expose a present semantic contradiction. It is a cheap robustness guard because configuration is intentionally replaceable/versioned.

**Consequence if ignored**

A configuration-range error silently becomes a different decision rather than an explicit invalid configuration/run.

**Recommended disposition**

Validate component/range bounds and aggregate in a checked context or a sufficiently wide validated integral type. Include one mechanism test proving overflow/range violation fails explicitly rather than changing ranking.

**Confidence:** medium-high.

---

### TRES-0010G-F07 — Reflection/deserialization/exception shortcuts can bypass typed domain outcomes and invariants

- **Classification:** implementation hazard
- **Severity:** **MEDIUM_AMEND_OR_GUARD**

**Project evidence**

- IMP-0001 requires central proposal/response/resolution/commit and explicit `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)`.
- Fixture rules prohibit writing transition results that are under test.
- Guardrails already flag reflection/dynamic/deserialization shortcuts.
- Always-on invariants require invalid material/cardinality states never to become authoritative.

**Plausible AI-coding failure mode**

A coding agent may:
- deserialize fixture/config JSON directly into mutable authoritative entities with public setters;
- use reflection to populate private/init-only state in tests;
- throw/catch exceptions for ordinary infeasibility and then map all failures into one generic outcome.

No unusual CLR behavior is required; the risk is bypassing the project’s semantic boundary for convenience.

**Smallest failure trace**

A fixture deserializes a `Person` with negative grain or a duplicate outstanding favour directly into the authoritative store. The transition path and semantic history never see the illegal construction, yet later tests exercise the corrupted state.

**Does existing authority answer it?**

Yes in principle. The verification write-set and invariant contract are already strong. This is mainly an implementation/test-harness discipline item.

**Consequence if ignored**

Tests can “prove” behavior from states the public semantics could never produce, or collapse distinct domain outcomes into technical exceptions.

**Recommended disposition**

Use DTO/config parsing followed by validated construction/import boundaries. Reserve exceptions for programmer/invariant/technical faults; ordinary domain outcomes remain explicit typed results and are recorded semantically. Do not let fixture helpers bypass the same state validity rules unless a test is explicitly injecting a fault and labels it as such.

**Confidence:** medium-high.

---

## Attempted attacks that did not expose a current blocker

### A. Runtime-global randomness

The platform offers `System.Random` / `Random.Shared`, and Microsoft does not promise a fixed random sequence implementation across major .NET versions. However, Slice 1 explicitly excludes stochastic behavior, ADR-0004 places randomness behind a simulation boundary, and the engineering guardrails explicitly prohibit treating `System.Random` behavior as the reproducibility contract.

**Result:** no missing Slice-1 semantic rule. Keep `Random` out of authoritative behavior.

### B. Wall-clock leakage

`DateTime.Now` reads the current local system time. That would be nondeterministic if used for semantic scheduling, IDs, history order, or due dates. But the accepted model already defines integer `Cycle` + `ReactionIndex`, and IMP-0001 requires those semantics.

**Result:** no semantic gap. Treat `DateTime.Now`, `UtcNow`, timestamps, stopwatch time, etc. as diagnostics only, never simulation time/order.

### C. Async/task scheduling as causal order

Task scheduling would be an obvious way to accidentally turn runtime scheduling into proposal/commit order. ADR-0004 accepts a single-process, single-threaded reference kernel and IMP-0001 explicitly excludes parallelism/concurrency.

**Result:** no missing rule. Do not introduce `Task.Run`, PLINQ, parallel loops, channels, or background mutation into the reference kernel.

### D. Floating-point scoring drift

The review explicitly attacked the accepted scoring path for `double`/implicit conversion dependence. SPEC §5 and the canonical profiles close that route by using named exact-integer components and integer encodings of the 1.5x kinship multiplier.

**Result:** no current floating-point defect found. The residual numeric hazard is unchecked integer overflow (F06), not floating-point reproducibility.

### E. CLR object-graph serialization as persistence authority

The engineering guardrails already say persistence uses versioned data contracts and that CLR object-graph serialization must not become continuation authority. IMP-0001 keeps checkpoint/save-load continuation out of Slice 1 while requiring current state choices to remain compatible with the future checkpoint path.

**Result:** no current persistence blocker. Preserve explicit IDs/references and avoid object-reference topology that would make later versioned checkpointing impossible.

### F. Collection iteration as hidden tie-break

This is a real platform hazard, but it is already unusually well-covered by current project authority: IMP-0001 requires nonsemantic iteration-order permutation; the cross-cutting verification contract names the exact semantic mutant; VS-SFL-081 requires stable-ID fallback isolation/disclosure.

**Result:** no missing semantic decision. Retain the test and add the API-level checklist in F04.

## Could not determine from accepted artifacts

1. **Test framework and runner parallelism are not yet chosen.** Therefore this review cannot determine whether tests will execute concurrently by default. Whatever framework is selected, simulation state/config/ID allocators must not be shared mutable statics across tests.
2. **The concrete semantic-ID representation is intentionally not chosen.** This review therefore cannot assess its comparer/equality implementation; F02/F03/F05 are constraints on that future choice.
3. **No Slice-1 production implementation exists yet.** Findings are pre-code hazards, not defects observed in code.
4. **Analyzer package/baseline is not chosen.** Some hazards can be made lintable (ambient randomness/time, mutable statics, culture-sensitive comparer use), but this report does not prescribe a package.

## Suggested minimal pre-dispatch amendments

These are implementation guards; they do **not** change accepted SFL semantics.

1. Add a **snapshot ownership rule** to IMP-0001 / C# guardrails: no mutable shared backing data or deferred enumeration may cross the committed-snapshot boundary.
2. Add an explicit **semantic-ID rule**: simulation-owned deterministic allocation/frontier; never `Guid.NewGuid()`, `GetHashCode()`, allocation position, or runtime reference identity for semantic IDs/order.
3. Add an **identity/equality rule**: domain entity/history identity is stable-ID identity; generated record value equality is not a substitute.
4. Add an **ordering rule**: outcome-relevant comparisons must form the complete accepted order, including allowed/logged fallback; sort stability/source order is never the missing tie key.
5. Add **ordinal machine-text comparison** where strings participate in identity/order/config selection.
6. Add **checked/validated integer score aggregation**.
7. Add one executable **snapshot-alias/deferred-enumeration adversarial test** before claiming Slice-1 determinism.

## External documentation consulted

Official Microsoft Learn, targeting .NET 10/C# documentation where versioned APIs apply:

- `Dictionary<TKey,TValue>`: enumeration order is undefined; mutable keys must not change their hash while stored  
  https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0
- `List<T>.Sort`: unstable sort  
  https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-10.0
- LINQ `OrderBy`: stable ordering for equal keys  
  https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-10.0
- LINQ deferred execution  
  https://learn.microsoft.com/en-us/dotnet/standard/linq/deferred-execution-lazy-evaluation
- C# records: value equality and shallow copying behavior of record copies / `with` expressions  
  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records
- `Object.GetHashCode()`: hash codes are not permanent/persistent identifiers  
  https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-10.0
- `Guid.NewGuid()`: generated version-4 UUID  
  https://learn.microsoft.com/en-us/dotnet/api/system.guid.newguid?view=net-10.0
- `System.Random`: implementation/reproducibility caveats across .NET versions  
  https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-random
- checked/unchecked integral arithmetic  
  https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/checked-and-unchecked
- string comparison guidance / ordinal comparison for non-linguistic identifiers  
  https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
- `DateTime.Now`: current local system date/time  
  https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-10.0

## Final recommendation

**AMEND BEFORE IMPLEMENTATION.**

The accepted architecture and SFL semantics are sufficiently precise for C# 14 / .NET 10 LTS. No host-runtime blocker was found. Before IMP-0001 dispatch, make the P0 snapshot-stability guard explicit and fold the P1/P2 items into the implementation checklist/tests. These changes should be treated as C# engineering protections around already-accepted semantics, not as new social or architectural rules.
