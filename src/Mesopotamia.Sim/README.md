# Slice-1 and Slice-2 reference kernel

The production library implements IMP-0001's fixed-population, single-threaded lower-level laboratory and IMP-0002's bounded actor-specific epistemic extension. Repository semantic authority remains the accepted specification and ADRs linked from the task packets.

## Running a world

Construct `InitialWorld` from immutable arrays of typed people, dwellings, residence, attitudes, kinship, and optional initial marriage. Declare exogenous grain inputs by identity and future cycle. Initial debts and favours are deliberately absent from this setup interface: create them through committed interactions when their provenance matters.

`Simulation.RunAutonomousCycle()` gives each person one personal context under `SFL-PERSONAL-REFERENCE-v1`. To pin canonical profiles and observations, call `RunCycle` with `CycleInput.PersonalPolicies`. Repeated calls provide bounded multi-cycle execution through exactly the same cycle path:

```csharp
Simulation simulation = new(initialWorld);
for (int i = 0; i < cycleLimit; i++)
{
    CycleResult result = simulation.RunAutonomousCycle();
    if (result.MaterialDeadlock) break;
}
```

For mechanism isolation, `CycleInput.Proposals` accepts explicit typed proposals. Each actor may submit only one personal proposal per cycle. A person cannot receive both an explicit proposal and an autonomous personal policy in that cycle. `Responses` supplies valid response choices through the same validation, resolution, and commit boundary. Response profiles otherwise select automatically; incoming responses coexist with the person's own initiative. Fixtures cannot supply a candidate winner, final score, authoritative result, or direct state mutation.

The canonical personal profiles are `SCORE-VP-002/004/005/006`; response profiles are `SCORE-RP-001/002/003/004`. Their meanings are pinned by the frozen verification material. Default preferences are laboratory configuration, not historical calibration. Personal generation, gates and scoring share an immutable `PersonalDecisionInputs` view across profiles. It contains own state, direct-party relations/claims, and explicit policy observations. Objective feasibility is checked separately at response and immediate commit-time revalidation. Exact integer components and ordinal stable candidate keys determine selection, with explicit tie markers.

`PersonalPolicy.ObservedPeople` and `GiftTarget` bind identities only. They do not reveal counterpart grain, need, sex, residence or unrelated relations. Optional immutable `ObservedSexes` and `ObservedResidences` maps provide the specific observed facts needed for marriage and destination construction; both are empty by default. `ObservedDebts` explicitly binds observed claim facts at decision capture. No unrelated debts enter the personal view. These inputs are supplied observations for the bounded laboratory, not a persistent observation or communication system. `DecisionTrace.SubjectiveInputs` records the captured facts, policy parameters and their provenance. A stale supplied destination may produce the same personal choice and a different objective `Unable` result.

## Execution and observation

The cycle applies scheduled inputs, consumption and due decay, materializes the common immutable decision snapshot, deliberates personal and response contexts, resolves accepted proposals by stable identity, revalidates immediately before each commit, reviews due debts, and closes direct attitude reactions before publishing. Gift/help/loan/bargain meanings remain distinct even where material transfer code is shared. Only repayment has the two-grain reserve. Called Farm/RepayDebt runs within its fulfilment response scope.

Action commits prepare a complete copied state, check arithmetic and invariants, then replace authoritative state. Direct attitude causes retain individual provenance, deduplicate, sum, and clamp once per directed pair. Debt social-due review participates in the same batch. Accepted-proposal dependency analysis identifies residence owner/mover dependencies, marriage capacity, favour retirement/creation/provenance, aggregate debt balance, and aggregate grain/reserve contention including incoming transfer/Farm effects. Their consequential outcome records disclose stable-ID fallback. Analysis does not select winners; revalidation does, and compatible effects still commit. Response feasibility and higher candidate scores run before fallback.

`Snapshot`, `History`, `DecisionHistory`, and `KnowledgeOf(person)` return immutable views. Public history is an observer diagnostic surface; actor outcome knowledge is limited to direct participants with bounded reasons. Policies do not receive observer history. Snapshot dictionaries contain copied authoritative records; derived queries scan these records directly, without behavior-affecting caches or household authority.

Invalid terms remain diagnostic `InvalidTerms` and do not activate responses or social failure knowledge. Valid attempts distinguish `Declined`, `Unable`, and `InvalidatedAtResolution`. Arithmetic/runtime failure faults the simulation, preserves its previously published snapshot, and prevents continuation; partial diagnostic history may remain for inspection and is not a completed cycle. The internal verification-only reaction challenge seam is inaccessible from the public API and exercises duplicate/closure controls.

No checkpoint format, concurrency, stochastic policy, household lifecycle, or later-slice authority is introduced. IDs and in-memory counters are explicit; future persistence needs its own accepted versioned contract.

## Subjective knowledge and communication

`EpistemicStateOf(person)` and `EpistemicSnapshot` expose immutable completed-cycle actor state. `CycleResult.Epistemic` is the matching cycle view. They are separate from objective `Snapshot` and from the retained Slice-1 participant-outcome `KnowledgeOf` API. Own-state, direct-party relation/claim, participation, and communicated facts retain acquisition route and original source/event order. Communication appends sender/recipient/delivery provenance without replacing the underlying evidence time. Observer history is not a policy input.

`InitialWorld.Knowledge` supplies explicitly fixture-originated inherited evidence, never an acquisition result under test. The bounded `InitialWorld.Candidates` supports one inert referent with a fixed core and declared live status. It neither discovers organizations nor creates households. Recognition is derived from held shared-residence, connecting durable-tie, and distinct-cycle support evidence. Candidate labels are not evidence. The frozen RG-01 single-valued Residence contradiction becomes `Contested`; IDs and delivery order never select its winner. The declared live flag limits this laboratory referent; no expiry clock or social lifecycle is inferred.

`CommunicateClaim(recipient, new HeldFact(evidenceId))` or `CommunicateClaim(recipient, new HeldRecognition(candidateId))` goes through the ordinary personal proposal/validation/commit path. It has a recipient but no response decision. It transmits the captured held evidence only to that recipient, costs the sender's personal initiative, and cannot activate fresh same-cycle voluntary behavior. The sender's captured evidence and Recognition are revalidated before commit. A same-cycle update that displaces them can invalidate the attempt; the existing detached dependency analysis discloses consequential stable-ID fallback for these interactions. This fallback never resolves Recognition conflict.

To exercise selection, use `PersonalPolicy("SFL-COMMUNICATION-LAB-v1") { Communication = ... }`. Its pinned 100-point communication preference is laboratory configuration, not accepted autonomous social motivation. The actor-specific gate precedes scoring and the trace carries the exact relevant evidence. Existing Slice-1 profiles retain their behavior and explicit observation inputs; those inputs do not become a generic nonparticipant perception system.

Current state retains stale facts until accepted evidence supersedes them. Precedence is limited to newer direct evidence and newer event-backed reports in the accepted cases. There is no universal factual-conflict algebra, trust model, invented claims, or behavior-affecting epistemic cache. `RulesVersion` on semantic events and decisions identifies `SFL-S2-v1` separately from a caller-supplied scenario configuration label.

## Verification

Run the four canonical commands in root `AGENTS.md`. The acceptance runners emit individual frozen-row evidence and fixture/oracle/fault supplements under ignored `artifacts/acceptance/`; CI uploads these as `sfl-slice1-slice2-acceptance-evidence`. Slice-2 evidence is separately prefixed `slice2-`; frozen Slice-1 classifications remain unchanged. Fresh conformance review of the exact candidate remains required.
