# Slice-1, Slice-2 and Slice-3 reference kernel

The production library implements IMP-0001's fixed-population, single-threaded lower-level laboratory, IMP-0002's bounded actor-specific epistemic extension, and IMP-0003's persistent household substrate. Repository semantic authority remains the accepted specification and ADRs linked from the task packets.

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

The cycle applies scheduled inputs, consumption and due decay, materializes the common immutable decision snapshot, deliberates personal and response contexts, resolves accepted proposals with explicit household bridge precedence before residual stable-identity ordering, revalidates immediately before each commit, reviews due debts, and closes attitude and household reactions before publishing. Gift/help/loan/bargain meanings remain distinct even where material transfer code is shared. Only repayment has the two-grain reserve. Called Farm/RepayDebt runs within its fulfilment response scope.

Action commits prepare a complete copied state, check arithmetic and invariants, then replace authoritative state. Direct attitude causes retain individual provenance, deduplicate, sum, and clamp once per directed pair. Debt social-due review participates in the same batch. Accepted-proposal dependency analysis identifies residence owner/mover dependencies, marriage capacity, favour retirement/creation/provenance, aggregate debt balance, and aggregate grain/reserve contention including incoming transfer/Farm effects. Their consequential outcome records disclose stable-ID fallback. Analysis does not select winners; revalidation does, and compatible effects still commit. Response feasibility and higher candidate scores run before fallback.

`Snapshot`, `History`, `DecisionHistory`, and `KnowledgeOf(person)` return immutable views. Public history is an observer diagnostic surface; actor outcome knowledge is limited to direct participants with bounded reasons. Policies do not receive observer history. Snapshot dictionaries contain copied authoritative records; derived queries scan these records directly, without behavior-affecting caches.

Invalid terms remain diagnostic `InvalidTerms` and do not activate responses or social failure knowledge. Valid attempts distinguish `Declined`, `Unable`, and `InvalidatedAtResolution`. Arithmetic/runtime failure faults the simulation, preserves its previously published snapshot, and prevents continuation; partial diagnostic history may remain for inspection and is not a completed cycle. The internal verification-only reaction challenge seam is inaccessible from the public API and exercises duplicate/closure controls.

No checkpoint format, concurrency, stochastic policy, or head/office/spending authority is introduced. IDs and in-memory counters are explicit; future persistence needs its own accepted versioned contract.

## Subjective knowledge and communication

`EpistemicStateOf(person)` and `EpistemicSnapshot` expose immutable completed-cycle actor state. `CycleResult.Epistemic` is the matching cycle view. They are separate from objective `Snapshot` and from the retained Slice-1 participant-outcome `KnowledgeOf` API. Own-state, direct-party relation/claim, participation, and communicated facts retain acquisition route and original source/event order. Communication appends sender/recipient/delivery provenance without replacing the underlying evidence time. Observer history is not a policy input.

`InitialWorld.Knowledge` supplies explicitly fixture-originated inherited evidence, never an acquisition result under test. The bounded `InitialWorld.Candidates` supports separately declared inert referents, one fixed core per bounded formation episode. It neither discovers organizations nor creates households. Recognition is derived from held shared-residence, connecting durable-tie, and distinct-cycle support evidence. Candidate labels are not evidence. The frozen RG-01 single-valued Residence contradiction becomes `Contested`; IDs and delivery order never select its winner. The declared live flag limits this laboratory referent; no expiry clock or social lifecycle is inferred.

`CommunicateClaim(recipient, new HeldFact(evidenceId))` or `CommunicateClaim(recipient, new HeldRecognition(candidateId))` goes through the ordinary personal proposal/validation/commit path. It has a recipient but no response decision. It transmits the captured held evidence only to that recipient, costs the sender's personal initiative, and cannot activate fresh same-cycle voluntary behavior. The sender's captured evidence and Recognition are revalidated before commit. A same-cycle update that displaces them can invalidate the attempt; the existing detached dependency analysis discloses consequential stable-ID fallback for these interactions. This fallback never resolves Recognition conflict.

To exercise selection, use `PersonalPolicy("SFL-COMMUNICATION-LAB-v1") { Communication = ... }`. Its pinned 100-point communication preference is laboratory configuration, not accepted autonomous social motivation. The actor-specific gate precedes scoring and the trace carries the exact relevant evidence. Existing Slice-1 profiles retain their behavior and explicit observation inputs; those inputs do not become a generic nonparticipant perception system.

Current state retains stale facts until accepted evidence supersedes them. Precedence is limited to newer direct evidence and newer event-backed reports in the accepted cases. There is no universal factual-conflict algebra, trust model, invented claims, or behavior-affecting epistemic cache. `RulesVersion` on semantic events and decisions identifies `SFL-S2-v1` separately from a caller-supplied scenario configuration label.

## Household substrate (IMP-0003)

`Simulation.HouseholdSnapshot` and `CycleResult.Households` publish immutable, matching-cycle household views. A separate typed `HouseholdState` partition owns household identities, warrants, sustaining associations, provision commitments, and committed ordinary-support evidence. `WorldState` and its frozen S1-084 field audit are unchanged. Snapshot participant counts, mobilizable capacity, direct `DerivedFrom` and transitive `AncestorOf` recompute from explicit records.

Declare a bounded candidate in `InitialWorld.Candidates` or with `Simulation.DeclareCandidate` at a stable boundary. This supplies an inert referent, not a formation command, winner, recognition result, or equivalence rule. All founders must independently hold sufficient CandidateRecognition, and the objective residence, durable connectivity and distinct-cycle ordinary-support predicate must also hold. The automatic closure then commits the FormationWarrant, household, founding associations and direct founder recognition. General candidate convergence is unsupported.

`RequestHouseholdParticipation(household, bridge)` and `InviteHouseholdParticipation(household, newcomer)` use ordinary bilateral responses, one personal initiative, and immediate precommit revalidation. `EndHouseholdParticipation(household)` ends only that association and any corresponding provision commitment. Continuation warrants record prior/successor association references, recognizing bridges, transition evidence and preceding warrant. Compatible entry through an exiting bridge resolves first; lifecycle is published only after closure. Identity survives complete founder turnover through these warrants. A Dissolved household is retained and never resurrected.

`ActorEpistemicState.HouseholdRecognitionOf(household)` distinguishes actor recognition from objective state. `HeldHouseholdRecognition` communicates a sender-held positive proposition with its evidence. Dissolution can be communicated as a held factual proposition. Incompatible nondominated evidence is Contested; only Recognized satisfies the participation gate. Uninvolved actors do not synchronize from household state or observer history. Household evidence updates use the existing accepted provenance/order rules.

The closed ordinary-support classifier recognizes gift/help, loan provision and favour fulfilment. Formation and lineage consume committed ordinary evidence; actor reports do not create objective support. Lineage is downstream of ordinary formation and uses explicit ended predecessor participation, predecessor lifecycle timing and fresh support. All complete controlled interpretations are considered; ambiguity yields no lineage. Repeated predecessor source histories raise `LATER-03` rather than inventing a source selector.

Household dependency analysis partitions affected people, households and candidates, then uses detached copies of the same commit/closure implementation to identify consequential technical order conflicts. The explicit bridge-entry priority constrains admissible orders. Detached allocation cannot consume live IDs. As in the earlier reference resolver, permutation cost can grow with a tightly coupled proposal component; this is not a production-scale optimized resolver.

Provision commitments are authoritative backing, not grain ownership or spending permission. The internal verification-only prerequisite seam requires fixture and producer provenance. Runtime solicitation, household spending and head/office state are absent. Exposed capacity is zero for NeedsGrain and otherwise `max(0, grain - 2)`; participation end and dissolution terminate backing without confiscation.

Use `new Configuration("SFL-S3-v1")` for Slice-3 laboratory runs. Household warrants/events identify the S3 rule version independently of the scenario configuration label. The legacy S2 configuration/profile and its existing assertions are retained. Slice-3 mechanism scenarios submit typed household actions; this slice does not extend the autonomous policy with new social motivation.

## Verification

Run the four canonical commands in root `AGENTS.md`. The acceptance runners emit individual frozen-row evidence and fixture/oracle/fault supplements under ignored `artifacts/acceptance/`; CI uploads these as `sfl-slice1-slice2-slice3-acceptance-evidence`. Slice-2 evidence is separately prefixed `slice2-`; frozen Slice-1 classifications remain unchanged. Fresh conformance review of the exact candidate remains required.
