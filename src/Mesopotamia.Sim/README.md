# Slice-1 reference kernel

The production library implements IMP-0001's fixed-population, single-threaded lower-level laboratory. Repository semantic authority remains the accepted specification and ADRs linked from the task packet.

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

No checkpoint format, concurrency, stochastic policy, general communication, household, recognition, or later-slice authority is introduced. IDs and in-memory counters are explicit; future persistence needs its own accepted versioned contract.

## Verification

Run the four canonical commands in root `AGENTS.md`. The acceptance runner emits individual frozen-row evidence and fixture/oracle/fault supplements under ignored `artifacts/acceptance/`; CI uploads these as `slice1-acceptance-evidence`. See the required [implementation report](../../tasks/implementation/IMP-0001_IMPLEMENTATION_REPORT.md) for the durable per-ID index and independent-review status.
