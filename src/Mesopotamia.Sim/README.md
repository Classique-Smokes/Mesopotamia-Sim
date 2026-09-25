# Slice-1 through Slice-4 reference kernel

The production library implements the fixed-population deterministic laboratory, actor-specific evidence, persistent Households, and IMP-0004's bounded head role and collective actions. Repository semantic authority remains the accepted specification and ADRs linked from the task packets.

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

No checkpoint format, concurrency or stochastic policy is introduced. IDs and in-memory counters are explicit; future persistence needs its own accepted versioned contract.

## Subjective knowledge and communication

`EpistemicStateOf(person)` and `EpistemicSnapshot` expose immutable completed-cycle actor state. `CycleResult.Epistemic` is the matching cycle view. They are separate from objective `Snapshot` and from the retained Slice-1 participant-outcome `KnowledgeOf` API. Own-state, direct-party relation/claim, participation, and communicated facts retain acquisition route and original source/event order. Communication appends sender/recipient/delivery provenance without replacing the underlying evidence time. Observer history is not a policy input.

`InitialWorld.Knowledge` supplies explicitly fixture-originated inherited evidence, never an acquisition result under test. The bounded `InitialWorld.Candidates` supports separately declared inert referents, one fixed core per bounded formation episode. It neither discovers organizations nor creates households. Recognition is derived from held shared-residence, connecting durable-tie, and distinct-cycle support evidence. Candidate labels are not evidence. The frozen RG-01 single-valued Residence contradiction becomes `Contested`; IDs and delivery order never select its winner. The declared live flag limits this laboratory referent; no expiry clock or social lifecycle is inferred.

`CommunicateClaim(recipient, new HeldFact(evidenceId))` or `CommunicateClaim(recipient, new HeldRecognition(candidateId))` goes through the ordinary personal proposal/validation/commit path. It has a recipient but no response decision. It transmits the captured held evidence only to that recipient, costs the sender's personal initiative, and cannot activate fresh same-cycle voluntary behavior. The sender's captured evidence and Recognition are revalidated before commit. A same-cycle update that displaces them can invalidate the attempt; the existing detached dependency analysis discloses consequential stable-ID fallback for these interactions. This fallback never resolves Recognition conflict.

To exercise selection, use `PersonalPolicy("SFL-COMMUNICATION-LAB-v1") { Communication = ... }`. Its pinned 100-point communication preference is laboratory configuration, not accepted autonomous social motivation. The actor-specific gate precedes scoring and the trace carries the exact relevant evidence. Existing Slice-1 profiles retain their behavior and explicit observation inputs; those inputs do not become a generic nonparticipant perception system.

Current state retains stale facts until accepted evidence supersedes them. Precedence is limited to newer direct evidence and newer event-backed reports in the accepted cases. There is no universal factual-conflict algebra, trust model, invented claims, or behavior-affecting epistemic cache. `RulesVersion` on semantic events and decisions identifies the rules exercised separately from the caller-supplied `ConfigurationVersion` label. Ordinary inherited actions retain `SFL-S2-v1` even in a cycle that also exercises household actions.

## Household substrate (IMP-0003)

`Simulation.HouseholdSnapshot` and `CycleResult.Households` publish immutable, matching-cycle household views. A separate typed `HouseholdState` partition owns household identities, warrants, sustaining associations, provision commitments, and committed ordinary-support evidence. `WorldState` and its frozen S1-084 field audit are unchanged. Snapshot participant counts, mobilizable capacity, direct `DerivedFrom` and transitive `AncestorOf` recompute from explicit records.

Declare a bounded candidate in `InitialWorld.Candidates` or with `Simulation.DeclareCandidate` at a stable boundary. This supplies an inert referent, not a formation command, winner, recognition result, or equivalence rule. All founders must independently hold sufficient CandidateRecognition, and the objective residence, durable connectivity and distinct-cycle ordinary-support predicate must also hold. The automatic closure then commits the FormationWarrant, household, founding associations and direct founder recognition. General candidate convergence is unsupported.

`RequestHouseholdParticipation(household, bridge)` and `InviteHouseholdParticipation(household, newcomer)` use ordinary bilateral responses, one personal initiative, and immediate precommit revalidation. `EndHouseholdParticipation(household)` ends only that association and any corresponding provision commitment. Continuation warrants record prior/successor association references, recognizing bridges, transition evidence and preceding warrant. Compatible entry through an exiting bridge resolves first; lifecycle is published only after closure. Identity survives complete founder turnover through these warrants. A Dissolved household is retained and never resurrected.

`ActorEpistemicState.HouseholdRecognitionOf(household)` distinguishes actor recognition from objective state. `HeldHouseholdRecognition` communicates a sender-held positive proposition with its evidence. Dissolution can be communicated as a held factual proposition. Incompatible nondominated evidence is Contested; only Recognized satisfies the participation gate. Uninvolved actors do not synchronize from household state or observer history. Household evidence updates use the existing accepted provenance/order rules.

The closed ordinary-support classifier recognizes gift/help, loan provision and favour fulfilment. Formation and lineage consume committed ordinary evidence; actor reports do not create objective support. Lineage is downstream of ordinary formation and uses explicit ended predecessor participation, predecessor lifecycle timing and fresh support. All complete controlled interpretations are considered; ambiguity yields no lineage. Repeated predecessor source histories raise `LATER-03` rather than inventing a source selector.

Household dependency analysis partitions affected people, households and candidates, then uses detached copies of the same commit/closure implementation to identify consequential technical order conflicts. The explicit bridge-entry priority constrains admissible orders. Detached allocation cannot consume live IDs. As in the earlier reference resolver, permutation cost can grow with a tightly coupled proposal component; this is not a production-scale optimized resolver.

Provision commitments are authoritative backing, not grain ownership. The internal verification-only prerequisite seam retains fixture and producer provenance for historical Slice-3 witnesses; Slice 4 adds the separately typed endogenous routes below. Exposed capacity is zero for NeedsGrain and otherwise `max(0, grain - 2)`; participation end and dissolution terminate backing without confiscation.

Scenario configuration labels are arbitrary and do not select rule semantics. Household participation/exit proposals, responses and outcomes, household fact/Recognition communication, and household warrants/events identify `SFL-S3-v1`. Mixed cycles retain S2 provenance for ordinary inherited actions. Decision traces retain the scenario label separately as `ConfigurationVersion`. Slice-3 mechanism scenarios submit typed household actions; this slice does not extend the autonomous policy with new social motivation.

Continuation evidence is acquired only by direct parties to its causal entry/exit transition. Other current sustaining participants retain their prior Recognition and provenance until accepted communication or direct participation supplies new evidence. Their retained, explicit bridge evidence can support a ContinuationWarrant without granting them automatic knowledge of the new transition.

## Verification

Run the four canonical commands in root `AGENTS.md`. The acceptance runners emit individual frozen-row evidence and fixture/oracle/fault supplements under ignored `artifacts/acceptance/`; CI uploads these as `sfl-slice1-slice2-slice3-slice4-acceptance-evidence`. Each slice has its own prefix; frozen classifications remain unchanged. Fresh conformance review of the exact candidate remains required.

## Household head and collective action (IMP-0004)

Formation allocates one vacant `HouseholdHeadRoleId` per H. `NominateHouseholdHead` fills that persistent role through explicit nominator participant acceptance, nominee willingness, and acceptance by every participant captured at the common decision snapshot. `CycleInput.HeadConsents` addresses each proposal, actor and semantic consent capacity independently. A self-nomination carries that person's predicates in its terms and creates no self-response. The accepted attempt retains exact association identities and the predecessor role record for live revalidation. Participation end vacates the office only when the departing person is its occupant; Inactive appointment is inert and does not reactivate H.

`HeadRoleFact`, `SustainingParticipationFact`, and `HeldHeadRecognition` use the existing evidence acquisition and communication routes. Head Recognition belongs to the person. Later entrants and uninvolved people learn no current head merely by being participants or reading objective state. A recognized vacancy, missing knowledge, and Contested evidence remain distinct. Immutable head transitions retain the cohort, consent predicates, exact evidence receipts, and rule/time provenance.

An explicit Household proposal sets `Proposal.HouseholdContext = new(household, role, head)`. It occupies H's one initiative slot; the head can still take one personal initiative and respond to incoming interactions. A person heading multiple Active Households can act once for each H. `CycleInput.HouseholdPolicies` provides autonomous Household selection: canonical `SCORE-VP-003` gives eligible bound need relief 100 and its other declared components zero; `SFL-HOUSEHOLD-REFERENCE-v1` supplies the bounded support/provision vocabulary. Policies do not infer appointments or redesign inherited personal motivation. Vacant and Inactive H produce no Household context. Tagging an ordinary gift, move, debt or other personal action with H does not grant office authority.

`RequestProvisionCommitment` asks the contributor through that person's response policy; acceptance creates backing without moving grain. `AuthorizeOwnProvisionCommitment` requires separate institutional-request and private-resource predicates in one head act. Refusals are keyed by H and contributor, preserving the baseline across succession. N+1, N+2 and N+3 are blocked after refusal at N; N+4 also requires an accepted context change. Under DEC-0014, a qualifying support onset/reentry or otherwise-valid positive mediated dowry demand is retained historically against the latest refusal even if it clears or lacks funding. A subsequent refusal resets this bounded record. Repeated technical proposal IDs create no need, and there is no pending-demand subsystem.

`HouseholdSupport` is proactive one-grain support; `RequestHouseholdSupport` opens one role-scoped head response. A needy head may receive proactive support. `ProposeMediatedMarriage` requires groom-held bride participation, H Recognition and current head/scope Recognition, and opens one head response. Female-head self-mediation is permitted; groom=head is not. Direct strong-like marriage remains the inherited personal route.

`HouseholdFundingPolicy` exposes no-private, exact configured X, shortfall and full-private plans before a role response is classified Unable. Default laboratory policy prefers feasible no-private funding; the holder may prefer a private plan or decline. Accepted X is immutable: present X is a positive integer no greater than cost C, owned by the current authorizing head, and subject to NeedsGrain/reserve restrictions. Commitments fund exactly C-X. The head's commitment-side exposure subtracts X before ranking by effective capacity descending, then semantic PersonId for exact ties. One live evaluator supplies commit and history. Personal deltas aggregate by person while typed private and commitment legs remain separate, including contributor/recipient overlaps. Mediated marriage, direct dowry credit to groom and one groom-to-head favour publish atomically. X carries no gift/help/loan attitude, extra favour or organizational-support meaning.

Semantic ordering preserves bridge entry before its exit, accepted authority use before its paired destruction, and the accepted shared-grain support/expenditure priority over personal material actions, including repayment and called repayment. Other eligibility, knowledge, capacity and favour-slot gates still revalidate. Detached replay uses the same accepted envelopes and evaluator; causal normalization prevents allocation identity from manufacturing fallback. No new initiative starts after same-cycle appointment or reactivation.

These grain stocks, reserve 2, provision commitments, fixed rank, private X and material priorities are a synthetic v0 grounding scaffold. They are not historical economic claims or a general property, treasury, accounting or payment architecture. The three-cycle reconsideration interval is the deliberately crude anti-repeated-solicitation proxy accepted by DEC-0014, not a psychological or historical model. Future resource and institutional redesign remains a separate accepted work boundary.
# Exact checkpoint continuation (Slice 5)

After a successful runtime cycle, call `simulation.CaptureCheckpoint()` to obtain
UTF-8 JSON bytes. Restore with
`Simulation.RestoreCheckpoint(bytes, expectedConfiguration)`. The caller owns
storage. The configuration identity and the S2/S3/S4 rule identities must match;
format migration is unsupported.

Capture rejects cycle zero, unfinished/faulted cycles and verification challenge
modes. Restore publishes the captured boundary immediately; the next RunCycle
advances once. Owner-local transport includes every typed authority partition,
all exact allocators, consumed proposal IDs, the input schedule and causal
history. Restore assigns state directly and rebuilds published views without
replaying events or acquiring initial facts.

The original InitialWorld is retained for existing detached-projection bootstrap,
the schedule and configuration. It never replaces restored current authority.
DecisionHistory and KnowledgeOf retain observer continuity and do not select
future behavior. CycleInput policies remain caller-supplied inputs.

Checkpoint bytes are not required to be canonical. IDs and semantic event,
evidence and provenance order are exact; JSON property and map enumeration are
not semantic priority. Checkpoints are bounded transport, not editable scenario
authoring, time travel, a generic workflow engine or a database.
