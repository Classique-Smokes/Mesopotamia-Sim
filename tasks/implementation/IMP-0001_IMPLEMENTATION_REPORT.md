# IMP-0001 — Repair-v2 implementation return

**IMPLEMENTATION CANDIDATE COMPLETE / AWAITING INDEPENDENT CONFORMANCE**

This return repairs the accepted F1–F3 blockers against candidate-v1. All 127 coder-owned REQUIRED obligations pass locally. This is an implementation return, not an independent K4 PASS. `S1-GLOBAL-CONFORMANCE` remains REQUIRED and awaiting independent review; the full frozen completion gate remains false. This agent implemented the repairs and cannot provide their independent conformance review. The Master Architect retains reconciliation and candidate-v2 freezing.

## Baseline and authority

- Repository: `Classique-Smokes/Mesopotamia-Sim`.
- Repair branch: `implementation/imp-0001-slice1-repair-v2`, starting at **7e11dab7697121eb0dbb169ba46210d81b80586e**.
- Preserved failed candidate: `imp-0001-slice1-conformance-candidate-v1` at that same SHA.
- Isolated implementation checkout: `C:\Users\victo\Documents\Codex\2026-09-22\act-as-the-fresh-independent-post\work\repair-v2`. This separate clone has its own writable Git metadata; both review worktrees remain untouched.
- Entry instructions and repair authority retrieved from freshly fetched `origin/main` at **a414e0f40615113db783538d2c7b8b0a384f5c87**. Main was not merged into this branch.
- Repair packet: `tasks/implementation/IMP-0001_BLOCK_REPAIR_PACKET.md`, blob **b89be34036197c294882adbbb30079848b08adc8** at that main revision.
- Reconciliation: `research/technical/IMP-0001/IMP-0001_CONFORMANCE_BLOCK_RECONCILIATION.md`, blob **9faaf0fa9518e46235fc1ca747191ec666aa2233** at that main revision.
- Manifest: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`, version **SFL-V0-S1-ACCEPTANCE-v1**, blob **efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766**.
- Freeze ref `sfl-v0-slice1-acceptance-v1` remains at **55377cc34b8bc3ccbf9cdf5029e9791dae965987**. All 167 unique IDs retain exactly **128 REQUIRED, 33 DEFERRED, 3 N-A, 3 UNEXERCISED**.
- Original review regression reference: reviewer commit **8e56d6b2d4abe95febf7f0ccb37ccc316b879482**, `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md`; original 127,757 bytes, SHA-256 **09fb414448000784866c2e8d172ed576d8180ad9d5db9e7d38ed4bb61a3ab91d**.
- Original review baseline `7fe85af66723885fecc16c0222538265cbf693bc` remains a historical review reference, not this repair branch's base.

The reconciliation's compressed `.md.br` archive does not validate: its actual blob `29530edb80671f3d57aa869ec1cc24afc2fbbaf9` is 14,997 bytes with SHA-256 `fb3c2972b1a75927176250d2324f6480da4a6169b42f02cdfc2fd1dd3e01d40f`; Brotli decompression fails. Those bytes differ from the reconciliation's recorded archive metadata. The verified original review supplies the regression reference. Archive repair is outside this implementation and was not attempted.

Accepted SPEC, ADRs, manifest and verification authority are unchanged. PR #7 remains draft, unmerged and at v1. No new PR, main update, release ref, candidate-v2 ref or independent review was created.

## Regression-first execution and canonical verification

Local commit `9f82f77` added five regressions before production changes. At that commit, production was byte-identical to v1. Restore and build passed; testing failed with precisely those five new scenarios:

| Regression | V1 observation | Repaired expectation |
|---|---|---|
| `RepairResidenceDestinationDependency` | Zero fallback records despite different residence outcomes under ID exchange | Both consequential outcomes disclose fallback; revalidation determines one versus two commits |
| `RepairCallCancellationDependency` | Zero fallback records despite different grain/favour outcomes | Call and cancellation outcomes disclose fallback; one commits and the other explicitly invalidates |
| `RepairNeedyReciprocalRequestRefusal` | Attitude remained 75 | Exactly one −5 cause and attitude 70 for feasible voluntary needy refusal |
| `RepairMissingMandatoryAttitudeCause` | Oracle accepted a witness with the cause removed and final attitude consistently restored | Oracle rejects empty-contribution and whole-composition omission witnesses |
| `RepairHiddenCounterpartyGrain` | Hidden stock 0 suppressed every choice; stock 8 allowed the request | Identical personal traces and request choice; later world result may be Unable or Committed |

The fifth failure was a missing selected candidate in the assertion, not a production crash credited as semantic detection. Original red logs/reports are retained in the task's `work/repair-evidence/red/`. Extended-test development corrected a new test's manifest-ID reference and a hand-calculated fixture total; no existing acceptance obligation, semantic rule, scoring coefficient or quality gate was weakened.

Core repair milestone: `5f94f7d`. Extended evidence/workflow milestone: **dedf0137ff5d337fd36677f9fee2a44fdaaef7af**. These are recoverable local commits, followed by the report/handoff commit.

SDK **10.0.401** was used from the existing external installation. Only session-local SDK/PATH, CLI home, temporary-directory and NuGet-cache settings were supplied. Native NuGet HTTPS failed in this restricted Windows session; Node's verified HTTPS transport retrieved the real NuGet service/vulnerability index and referenced base/update data into the workspace-local HTTP cache. No audit suppression, warning suppression, package-source change, certificate bypass or repository NuGet configuration was introduced. URLs, timestamps and hashes are recorded in `work/repair-evidence/nuget-transport.jsonl`.

Final local sequence from the repair repository root, 2026-09-22 18:16:44–18:17:02 UTC:

| Exact command | Result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | Exit 0 |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | Exit 0 |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | Exit 0; zero warnings/errors |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | Exit 0; 8 methods passed, 0 failed/skipped |

The acceptance method executes **57 named scenarios / 344 audited worlds**, not eight semantic cases. All **127 coder-owned REQUIRED rows PASS**. External conformance remains pending. All D1–D5 companion obligations and prior scenarios run through the same harness/invariant audit. Logs, exit codes and generated files are in `work/repair-evidence/canonical/` outside Git.

## F1 — explicit dependency and capacity disclosure

Authority: SPEC §§9.2/9.4, IMP-0001 stable-ID quarantine, `S1-081`, `S1-META-02`, `S1-GLOBAL-FALLBACK`, and repair packet R1.

`ResolutionDependencies.cs` analyzes accepted proposals from the common snapshot **once, before resolution**, identifying proposals requiring technical fallback. `Execution.cs` retains stable ProposalId order, immediate full current-state revalidation, atomic commits and explicit invalidation. Only the existing residence rule enforces one transition per mover. Dependency membership does not force a single winner: compatible effects still commit.

| Dependency | Analysis and retained behavior | Executable evidence |
|---|---|---|
| Residence write/write | Same mover; one transition and explicit loser invalidation | Existing D2 scenarios and `StableFallbackSensitivityAndSemanticAsymmetry` |
| Residence owner read/write | Move reads target's home; Invite reads inviter's home; another transition changes that owner | Original race and three reachable Move/Invite chain shapes in `RepairResidenceReadWriteMatrix` |
| Marriage capacity | Intersecting participants; existing eligibility/cardinality revalidated | `RepairMarriageCapacityPermutation`; distinct-pair commuting control |
| Favour retirement | Call consumes its claim; cancellation consumes the reciprocal pair; overlapping retirement conflicts | Both callable payloads and cancellation/cancellation in `RepairFavourRetirementDependencies` |
| Creation after retirement | Strong-like reciprocal help creates only in an empty directed slot; consuming/cancelling changes creation/provenance | Call Farm/Create, Call Repay/Create, Cancel/Create ID permutations |
| Competing creation/provenance | BFF requires capacity; help can transfer without a new claim. Same-direction help meanings may both transfer but only the earlier origin creates the claim | `RepairFavourCreationProvenance`: empty, full, below-gate and bargain cases |
| Remaining debt | Aggregate direct/called repayments exceed one claim's remaining amount | `RepairAggregateDebtCapacity`: three payments of 2 against 5; every pair fits; each actor made the loser |
| Grain and reserve | Aggregate spends versus grain, with the two-grain floor when a contender is repayment | `RepairTransferShapesAndReserve`: every transfer shape, both reciprocal directions and called repayment |
| Credits/Farm enabling spends | Insufficient aggregate initial capacity flags spenders and incoming transfer, personal Farm or called Farm enablers | `RepairAggregateGrainAndEnablers`: three-way contention and early/late enablers |
| Independent/commuting/asymmetric | Sufficient stock, distinct movers/shared unchanged owner, full slots, below-gate help, opposite transfers, independent marriages, pre-response inability | `RepairCommutingAndAsymmetricControls`, creation controls, existing asymmetry tests; no indiscriminate fallback |

Extended cases exchange IDs with semantic inputs fixed and reverse input enumeration with IDs fixed. Fixed-ID comparisons cover canonical state, full history, decisions and participant knowledge. Material totals, claim lifecycle and originating events are asserted. The original two races retain their original results and now disclose the causal technical choice.

### Complete action-pair audit

The matrix audits all 15 executable shapes: 13 action record types expanded into both reciprocal-help directions and both callable payloads. Entries cover distinct, snapshot-accepted initiatives; same-actor duplicates are rejected before a cycle. The matrix is symmetric.

- **I**: independent effect/precondition domains.
- **C**: potentially shared state but commuting when these are the only two accepted proposals; disjoint instances are independent.
- **G**: potentially competing grain/reserve capacity; explicit fallback at the aggregate threshold.
- **D**: potentially competing remaining balance on the same debt; explicit fallback.
- **V**: potentially competing favour lifecycle, slot creation or provenance; explicit fallback.
- **M**: potentially shared marriage cardinality; explicit fallback.
- **R**: potentially shared residence mover or destination-owner dependency; explicit fallback.

Multiple letters denote conditional alternatives, not mandatory conflict for every instance. **C does not waive larger sets**: if three or more spends exhaust a stock, aggregate analysis also marks otherwise commuting credits/Farm that can restore it. Debt and grain are checked separately. Pairwise residence/marriage/favour edges cover their larger sets; a directed favour pair admits at most its two parties as relevant creators/cancellers under one-initiative rules.

| Code | Executable shape |
|---|---|
| FA | Farm |
| GO | OfferGift |
| QH | RequestGiftOrHelp |
| LO | OfferLoan |
| QL | RequestLoan |
| RP | RepayDebt |
| BF | OfferBenefitForFavor |
| RO | ReciprocalHelp offer |
| RQ | ReciprocalHelp request |
| CF | CallFavor(Farm) |
| CR | CallFavor(RepayDebt) |
| CA | CancelReciprocalFavours |
| MA | ProposeMarriage |
| MV | MoveResidence |
| IV | InviteResidence |

| Pair | FA | GO | QH | LO | QL | RP | BF | RO | RQ | CF | CR | CA | MA | MV | IV |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
| FA | C | C | C | C | C | C | C | C | C | C | C | I | I | I | I |
| GO | C | C | G | C | G | C | C | C | G | C | G | I | I | I | I |
| QH | C | G | G | G | G | G | G | G | G | C | G | I | I | I | I |
| LO | C | C | G | C | G | C | C | C | G | C | G | I | I | I | I |
| QL | C | G | G | G | G | G | G | G | G | C | G | I | I | I | I |
| RP | C | C | G | C | G | C | C | C | G | C | G/D | I | I | I | I |
| BF | C | C | G | C | G | C | C | C | G/V | C | G | I | I | I | I |
| RO | C | C | G | C | G | C | C | C | G/V | C | G | V | I | I | I |
| RQ | C | G | G | G | G | G | G/V | G/V | G | V | G/V | V | I | I | I |
| CF | C | C | C | C | C | C | C | C | V | C | C | V | I | I | I |
| CR | C | G | G | G | G | G/D | G | G | G/V | C | G/D | V | I | I | I |
| CA | I | I | I | I | I | I | I | V | V | V | V | V | I | I | I |
| MA | I | I | I | I | I | I | I | I | I | I | I | I | M | I | I |
| MV | I | I | I | I | I | I | I | I | I | I | I | I | I | R | R |
| IV | I | I | I | I | I | I | I | I | I | I | I | I | I | R | R |

Impossible branches were explicitly considered: two direct actions by one actor; two calls of one favour by its sole holder; two direct repayments of one debt by its sole debtor; two BFF creations of one directed slot by its sole giver; same-groom competing marriages; a BFF accepted while its required slot is already full for a same-slot call/cancellation; and the Invite/Move chain requiring two initiatives from its middle person. Sex eligibility prevents one person being groom in one valid accepted marriage and bride in another. Reachable combinations through requests, invitations, different favour holders or conditional help are covered above. None requires a new social priority.

Committing a new loan/relation cannot activate a same-cycle proposal against that new relation: validation already occurred at the common snapshot. Independent new relations may receive different allocator IDs after proposal-ID exchange; that is identifier renaming, not a changed social relation or origin action. Shared-slot help changes which semantic proposal originates the single claim, so it is flagged and tested. Direct attitude causes close after ordinary commits, retaining distinct causes and sum-before-clamp; they do not alter another accepted proposal's attitude gate during resolution. No marriage/residence, kinship/attitude or household substitution was introduced.

## F2 — refusal consequence and independent cause completeness

Authority: SPEC §3.1, `S1-097-EVENTS`, `S1-MUT-18`, and repair packet R2.

`Execution.cs` includes reciprocal help with `Request: true` in genuine-need voluntary refusal: requester → refuser −5. Donor-offer refusal has no such cause. Ordinary help/loan requests remain controls; no need, Unable and resolution invalidation remain zero-effect cases.

`InvariantOracle.cs` reconstructs need from initial facts, exogenous inputs, missed consumption and committed transfers. Paying the last grain does not create unmet need. Consequential outcomes independently determine each required cause key, direction and delta for gift/help, loan, repayment, called fulfilment/refusal, needy ordinary/RMRH refusal and unpaid due review. Expected and recorded memberships are compared **before** independent summing/clamping. Extras/duplicates fail, and every mandatory cause must be accounted for at completed-cycle boundaries. No production consequence, feasibility, scoring or transition helper supplies expectations.

`RepairMissingMandatoryAttitudeCause` corrupts a detached immutable witness by removing −5 and consistently restoring final attitude. Empty-composition and whole-composition omissions both fail semantic assertions. Existing signed-bound, cause-order, duplicate, decay and due-timing controls remain. This is an executed checker-adequacy control, not a claimed production mutation injection.

## F3 — personal input classification and trace completeness

Authority: SPEC §§6.4/9.4, `S1-086`, `S1-META-07`, and repair packet R3. `PersonalInputCapture` alone reads the objective snapshot. Candidate construction, personal gating, scoring and tracing receive an internal immutable `PersonalDecisionInputs` value. Neither the personal agency nor that value retains a world snapshot/mutable-world reference.

| Fact previously reachable from world | Classification / permitted source | Use and trace after repair |
|---|---|---|
| Actor ID, sex, grain, need, own home | Own objective state | Farm/offer/repayment gates, need/grain concerns, own-home invitation; `OwnState` |
| Directed attitudes involving actor | Automatically known direct-party relation, SPEC §6.4 | Kin-weighted score, strong-like gates, co-residence concern; exact directed values/IDs |
| Kinship involving actor | Automatically known direct-party relation | Marriage prohibition and exact 2×/3× score; endpoints/kind/ID |
| Marriage involving actor / own unmarried state | Automatically known own/direct-party state | Own availability and marriage concern; complete direct-party set/absence convention |
| Own creditor/debtor claims and remaining amounts | Automatically known direct-party claim | Repayment candidates/bounds and permitted called repayment; parties/amounts/date/status/origin |
| Own holder/debtor favours | Automatically known direct-party claim | Call/cancel candidates, BFF slot; directed parties/status/origin |
| `ObservedPeople`, `GiftTarget` | Explicit policy identity binding only | Known identities and pinned gift profile; no private facts implied |
| Counterparty sex | Explicit optional `ObservedSexes`, empty by default | Construct marriage candidate with observed female counterpart; observation provenance |
| Counterparty residence | Explicit optional `ObservedResidences`, empty by default | Construct Move; only observed home can exclude already-at-home Invite; observation provenance |
| Third-party debt bound by `ObservedDebts` | Explicit policy observation of that claim at capture | Copy only bound claim facts; permit the relevant debtor's called repayment; exclude unrelated claims |
| Counterparty grain/need, unrelated marriage/kinship/attitude, unobserved home/sex/debts | Objective-only; excluded from personal view | Legitimate response/resolution/revalidation checks, never personal selection inputs |
| Profile, amount, gift target, bindings, absence interpretation | Policy configuration | Every parameter/binding and provenance recorded; all existing coefficients unchanged |

The view records complete direct-party sets and absence interpretation (missing directed attitude 0; no corresponding direct-party relation; unobserved counterparty fact unknown), making negative gates and candidate absence inspectable. Identity alone reveals no sex/home. Observed-debt provenance distinguishes direct-party from supplied facts. These are bounded policy inputs, not a persistent observation store, communication system, recognition engine or license to invent facts.

`RepairHiddenCounterpartyGrain` produces identical full personal traces for hidden stocks 0/8, while subsequent world outcomes differ. `RepairHiddenWorldFacts` perturbs hidden need, sex/name, residence, unrelated marriage/kinship/attitude. `RepairObservedDebtBoundary` changes unobserved debt amounts and verifies only observed claims enter the view. `RepairCalledPayloadPrivateFeasibility` covers both payloads with equal personal traces and different world feasibility. Positive explicit sex/home observations preserve profile expectations; supplied prior home remains the input when current world home differs. `RepairPersonalInputIsolationAndTrace` verifies captured immutability, provenance, and absence of a full-world parameter/reference.

Four existing agency fixtures now explicitly supply the sex/home observations needed for their original vocabulary/co-residence assertions. Their assertions and pinned profiles remain intact. `FixtureAudit` emits actual personal input traces and provenance for every autonomous context.

## Architecture, evidence and scope

Public objective rules and central transactional commit remain authoritative for feasibility. Snapshot publication, deterministic iteration, participant failure knowledge, closure, origin history, debt timing, one initiative and the narrow reaction-challenge seam remain intact. The new internal view gives no mutation route; public policy maps/captured collections are immutable. No general framework, package, derived cache, social priority, later-slice semantics or public verification mutation seam was introduced.

The existing `canonical-verification` workflow changed only by adding the repair branch to `push.branches`. Its canonical commands, analyzer/warning gates, SDK, permissions and evidence upload are unchanged. SCF-002 remains active; concurrent-worker, interoperability and learning triggers do not apply to this single-agent repair.

Evidence classifications distinguish actual duplicate/closure challenges, detached material/attitude/cause-omission witnesses, focused negative/boundary scenarios, permitted structural alternatives and mutations not executed. No crash/timeout is automatically credited. Frozen UNEXERCISED rows remain so. Generated evidence is ignored in Git and uploaded by CI, never hand-edited into PASS.

Source/configuration identity: SHA-256 over ordinal-path-ordered `path + space + Git blob SHA`, LF joined without a trailing LF, for tracked `src`, `tests`, `.github`, `.gitattributes`, `Directory.Build.props`, `global.json`, and `Mesopotamia.Sim.slnx`:

**dda7edcbbf1951ac14dec1fb4d842a69da0c6bc4f201693e0941b3ffc5c8e573**

The report/handoff are outside this identity set, avoiding a self-referential hash. The implementation revision is the repair commit containing this report. The publication receipt identifies the remotely verified source run; final delivery identifies the exact pushed head/run/archive.

| Local generated file | SHA-256 |
|---|---|
| cases.json | `efd99a27507e702584e3445f0a0907073f3d6c300a2a6a2a1c8efe7f6de1c319` |
| fault-controls.json | `f6225185016c0b64548c223aa68ee4ba5de1f5ac2a9e5908c6b08d974b1d7b2c` |
| fixture-audit.json | `f6d732a4ce46734d02e5dbaa1d9377a091c6080c44c5e5887175dd9e6e310c6c` |
| oracle-audit.json | `e4f20c559f12c2ccfd278c58751f2a4485b624c32fc36ba0b19f01474aeb8dc6` |
| slice1-results.json | `8c8a4d7b58b15d2e6609a450f883d4ae5af2693a5b1345de0da4d21cb94e9f35` |
| slice1-results.md | `93f7b6cc1e265aeb858d503a34f1b9531436f47f91e67aebee5c4ad7dcbac8ed` |

## Publication receipt

Remote publication verification is pending at this report checkpoint. Delivery is not complete until the exact pushed head's canonical CI succeeds and its acceptance artifact is inspected. Pushes are fast-forward only; no new PR is requested or created.

## Frozen AcceptanceId evidence index

This index comes from the locally executed manifest-indexed report. It is a navigation aid; assertions reside in named scenario sources and per-world fixture/oracle evidence. Non-required classifications remain separate. This implementation cannot supply the pending independent review.

| AcceptanceId | Frozen classification | Observed state | Evidence references |
|---|---|---|---|
| S1-090-A | REQUIRED | PASS | [ConsumptionAndFarm](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L34) |
| S1-090-B | REQUIRED | PASS | [ConsumptionAndFarm](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L34) |
| S1-090-C | REQUIRED | PASS | [ConsumptionAndFarm](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L34) |
| S1-090-D | REQUIRED | PASS | [GiftHelpMeaningsAndNeedClearing](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10) |
| S1-090-E | REQUIRED | PASS | [ConsumptionAndFarm](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L34) |
| S1-091-GIFT | REQUIRED | PASS | [GiftHelpMeaningsAndNeedClearing](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10) |
| S1-091-HELP | REQUIRED | PASS | [GiftHelpMeaningsAndNeedClearing](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10) |
| S1-091-LOAN-OFFER | REQUIRED | PASS | [LoanRoutesAndRepaymentHistory](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9) |
| S1-091-LOAN-REQUEST | REQUIRED | PASS | [LoanRoutesAndRepaymentHistory](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9) |
| S1-091-BFF-POS | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-091-RMRH | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-091-MEANING-SEPARATION | REQUIRED | PASS | [DistinctTransferMeanings](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L167) |
| S1-092-PARTIAL | REQUIRED | PASS | [LoanRoutesAndRepaymentHistory](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9); [RepairAggregateDebtCapacity](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135) |
| S1-092-AMOUNT-VALIDITY | REQUIRED | PASS | [RepaymentAmountAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38) |
| S1-092-RESERVE | REQUIRED | PASS | [RepaymentAmountAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38); [RepairTransferShapesAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196) |
| S1-092-FULL | REQUIRED | PASS | [LoanRoutesAndRepaymentHistory](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9) |
| S1-092-DUE | REQUIRED | PASS | [DebtDueAfterThirdFullCycle](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L64) |
| S1-093-BFF-POS | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-093-RECIP-74 | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-093-RECIP-75 | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-093-RECIP-76 | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-093-KIN-GATE | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-093-GIFT-CONTROL | REQUIRED | PASS | [GiftHelpMeaningsAndNeedClearing](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10) |
| S1-093-BFF-FULL | REQUIRED | PASS | [FullFavourSlotDistinguishesBargainFromHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37) |
| S1-093-BFF-RACE | REQUIRED | PASS | [BargainCapacityRace](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L52); [RepairFavourCreationProvenance](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71) |
| S1-093-RMRH-FULL | REQUIRED | PASS | [FullFavourSlotDistinguishesBargainFromHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37); [RepairFavourCreationProvenance](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71) |
| S1-094-FARM-CALLABLE | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70); [RepairCalledPayloadPrivateFeasibility](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94) |
| S1-094-REPAY-CALLABLE | REQUIRED | PASS | [CalledRepaymentThirdPartyAndInvalidation](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L106); [RepairFavourRetirementDependencies](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104); [RepairObservedDebtBoundary](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L71); [RepairCalledPayloadPrivateFeasibility](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94) |
| S1-094-PERSONAL-COEXIST | REQUIRED | PASS | [CalledFarmPersonalCoexistence](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L96) |
| S1-094-NONCALLABLE-MATRIX | REQUIRED | PASS | [CompleteCallFavorPayloadMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L89) |
| S1-094-NONPAYLOAD-MATRIX | REQUIRED | PASS | [CompleteCallFavorPayloadMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L89) |
| S1-094-UNABLE | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-094-DECLINE | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-094-INVALIDATED | REQUIRED | PASS | [CalledRepaymentThirdPartyAndInvalidation](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L106); [RepairAggregateDebtCapacity](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135); [RepairTransferShapesAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196) |
| S1-094-SUCCESS | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-094-NESTED-GUARD | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-094-RECIP-CANCEL | REQUIRED | PASS | [ReciprocalCancellation](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L126); [RepairFavourRetirementDependencies](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104) |
| S1-095-POS | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-095-74 | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-095-KIN | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-095-LIFETIME | REQUIRED | PASS | [MarriageDeclineAndLifetime](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L31) |
| S1-095-NO-RESIDENCE | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-096-MOVE | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-096-INVITE | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-096-COMPETE | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-096-NO-HH | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-096-MARRIAGE-CONTROL | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-097-EVENTS | REQUIRED | PASS | [FixedAttitudeEventMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L11); [RepairNeedyReciprocalRequestRefusal](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L48); [RepairMissingMandatoryAttitudeCause](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L72) |
| S1-097-SAT | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-097-DIRECT-BATCH-POS | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-097-DIRECT-BATCH-NEG | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-097-DECAY | REQUIRED | PASS | [DecayBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L53) |
| S1-098-CORE | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58) |
| S1-098-CALLFAVOR-INIT | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-098-COMMUNICATION | DEFERRED | DEFERRED |  |
| S1-099-KIN | REQUIRED | PASS | [GeneratedActionVocabularyAndRepaymentTarget](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L10); [ExactKinScoringAndFullTrace](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L30) |
| S1-099-CORES | REQUIRED | PASS | [CoResidenceMotivationWithoutCompulsion](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L63); [RepairExplicitSexAndResidenceObservations](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L34) |
| S1-100 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-101 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-102 | REQUIRED | PASS | [CalledFarmSuccessRefusalAndInability](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70) |
| S1-103-GRAIN | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58) |
| S1-103-RESIDENCE | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-104 | DEFERRED | DEFERRED |  |
| S1-105 | REQUIRED | PASS | [PersonalResidenceAndIncomingResponse](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L85) |
| S1-070 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-071 | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58) |
| S1-072 | DEFERRED | DEFERRED |  |
| S1-073 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-074-IDEMP | REQUIRED | PASS | [DuplicateReactionAndPrematureClosure](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L48) |
| S1-074-DIRECT-BATCH | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-075 | DEFERRED | DEFERRED |  |
| S1-076 | DEFERRED | DEFERRED |  |
| S1-080 | REQUIRED | PASS | [MaterialDeadlockAndNegativeControls](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L65) |
| S1-081 | REQUIRED | PASS | [StableFallbackSensitivityAndSemanticAsymmetry](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L82); [RepairResidenceDestinationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L12); [RepairCallCancellationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L28); [RepairResidenceReadWriteMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L25); [RepairMarriageCapacityPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L52); [RepairFavourCreationProvenance](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71); [RepairFavourRetirementDependencies](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104); [RepairAggregateDebtCapacity](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135); [RepairAggregateGrainAndEnablers](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159); [RepairTransferShapesAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196); [RepairCommutingAndAsymmetricControls](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234) |
| S1-082 | DEFERRED | DEFERRED |  |
| S1-083 | DEFERRED | DEFERRED |  |
| S1-084 | REQUIRED | PASS | [NoDerivedAuthorityStructuralAudit](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L153) |
| S1-085 | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99); [RepairPersonalInputIsolationAndTrace](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L115) |
| S1-086 | REQUIRED | PASS | [GeneratedActionVocabularyAndRepaymentTarget](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L10); [ExactKinScoringAndFullTrace](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L30); [RepairHiddenCounterpartyGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L89); [RepairHiddenWorldFacts](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L14); [RepairExplicitSexAndResidenceObservations](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L34); [RepairObservedDebtBoundary](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L71); [RepairCalledPayloadPrivateFeasibility](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94); [RepairPersonalInputIsolationAndTrace](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L115) |
| S1-087 | DEFERRED | DEFERRED |  |
| S1-BND-ATT-STRONGLIKE | REQUIRED | PASS | [DirectMarriageBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10) |
| S1-BND-ATT-STRONGDISLIKE | N-A | N-A |  |
| S1-BND-ATT-DISLIKE-NEUTRAL | N-A | N-A |  |
| S1-BND-ATT-NEUTRAL-LIKE | N-A | N-A |  |
| S1-BND-ATT-SAT | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-BND-ATT-MIXED | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-D4-GRAIN-GIFT-OFFER | REQUIRED | PASS | [GiftGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L82) |
| S1-D4-GRAIN-GIFT-REQUEST | REQUIRED | PASS | [GiftGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L82) |
| S1-D4-GRAIN-LOAN-OFFER | REQUIRED | PASS | [LoanGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L89) |
| S1-D4-GRAIN-LOAN-REQUEST | REQUIRED | PASS | [LoanGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L89) |
| S1-D4-GRAIN-REPAY-DIRECT | REQUIRED | PASS | [RepaymentAmountAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38) |
| S1-D4-GRAIN-BFF-BENEFIT | REQUIRED | PASS | [BenefitGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L136) |
| S1-D4-GRAIN-RMRH-BENEFIT | REQUIRED | PASS | [BenefitGrainIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L136) |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | REQUIRED | PASS | [MarriageDowryIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L75) |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | REQUIRED | PASS | [NestedRepaymentIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L111) |
| S1-BND-REPAY-AMOUNT | REQUIRED | PASS | [NestedRepaymentIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L111) |
| S1-BND-RESERVE | REQUIRED | PASS | [RepaymentAmountAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38) |
| S1-BND-NEED | REQUIRED | PASS | [GiftHelpMeaningsAndNeedClearing](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10) |
| S1-BND-DECAY | REQUIRED | PASS | [DecayBoundaries](../../tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L53) |
| S1-BND-DEBT-DUE | REQUIRED | PASS | [DebtDueAfterThirdFullCycle](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L64) |
| S1-BND-MARRIAGE-CARD | REQUIRED | PASS | [MarriageDeclineAndLifetime](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L31) |
| S1-BND-FAVOUR-CARD | REQUIRED | PASS | [FullFavourSlotDistinguishesBargainFromHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37) |
| S1-BND-FAVOUR-MEANING | REQUIRED | PASS | [FullFavourSlotDistinguishesBargainFromHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37) |
| S1-BND-RESIDENCE-CARD | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-BND-HOUSEHOLD-PROVISION | DEFERRED | DEFERRED |  |
| S1-BND-PROVISION-RECONSIDERATION | DEFERRED | DEFERRED |  |
| S1-BND-FORMATION | DEFERRED | DEFERRED |  |
| S1-BND-LINEAGE | DEFERRED | DEFERRED |  |
| S1-META-01 | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99) |
| S1-META-02 | REQUIRED | PASS | [IdentityIsomorphismAndDisconnectedLocality](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L130); [RepairResidenceDestinationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L12); [RepairCallCancellationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L28); [RepairResidenceReadWriteMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L25); [RepairMarriageCapacityPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L52); [RepairFavourCreationProvenance](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71); [RepairFavourRetirementDependencies](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104); [RepairAggregateDebtCapacity](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135); [RepairAggregateGrainAndEnablers](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159); [RepairTransferShapesAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196); [RepairCommutingAndAsymmetricControls](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234) |
| S1-META-03 | REQUIRED | PASS | [IdentityIsomorphismAndDisconnectedLocality](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L130) |
| S1-META-04 | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99) |
| S1-META-05 | REQUIRED | PASS | [NoDerivedAuthorityStructuralAudit](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L153) |
| S1-META-06 | DEFERRED | DEFERRED |  |
| S1-META-07 | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99); [RepairHiddenCounterpartyGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L89); [RepairHiddenWorldFacts](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L14); [RepairExplicitSexAndResidenceObservations](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L34); [RepairObservedDebtBoundary](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L71); [RepairCalledPayloadPrivateFeasibility](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94) |
| S1-META-08 | DEFERRED | DEFERRED |  |
| S1-META-09 | DEFERRED | DEFERRED |  |
| S1-META-10 | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-META-11 | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-MUT-01 | DEFERRED | DEFERRED |  |
| S1-MUT-02 | DEFERRED | DEFERRED |  |
| S1-MUT-03 | DEFERRED | DEFERRED |  |
| S1-MUT-04 | REQUIRED | PASS | [ExplicitBargainAndReciprocalHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16) |
| S1-MUT-05 | DEFERRED | DEFERRED |  |
| S1-MUT-06 | DEFERRED | DEFERRED |  |
| S1-MUT-07 | DEFERRED | DEFERRED |  |
| S1-MUT-08 | DEFERRED | DEFERRED |  |
| S1-MUT-09 | DEFERRED | DEFERRED |  |
| S1-MUT-10 | DEFERRED | DEFERRED |  |
| S1-MUT-11 | DEFERRED | DEFERRED |  |
| S1-MUT-12 | DEFERRED | DEFERRED |  |
| S1-MUT-13A | REQUIRED | PASS | [RepaymentAmountAndReserve](../../tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38) |
| S1-MUT-13B | DEFERRED | DEFERRED |  |
| S1-MUT-14 | DEFERRED | DEFERRED |  |
| S1-MUT-15 | DEFERRED | DEFERRED |  |
| S1-MUT-16 | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58); [AggregateCapacityAndIndependentLedgerFault](../../tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L54) |
| S1-MUT-17 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-MUT-18 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28); [RepairNeedyReciprocalRequestRefusal](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L48) |
| S1-MUT-19 | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-MUT-20 | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58) |
| S1-MUT-21 | REQUIRED | PASS | [SharedSnapshotScarceGrain](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58); [AggregateCapacityAndIndependentLedgerFault](../../tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L54) |
| S1-MUT-22 | REQUIRED | PASS | [DuplicateReactionAndPrematureClosure](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L48) |
| S1-MUT-23 | REQUIRED | PASS | [DuplicateReactionAndPrematureClosure](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L48) |
| S1-MUT-24 | REQUIRED | PASS | [NoDerivedAuthorityStructuralAudit](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L153) |
| S1-MUT-25 | DEFERRED | DEFERRED |  |
| S1-MUT-26 | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99) |
| S1-MUT-27 | DEFERRED | DEFERRED |  |
| S1-MUT-28 | DEFERRED | DEFERRED |  |
| S1-MUT-29 | REQUIRED | PASS | [ExactKinScoringAndFullTrace](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L30) |
| S1-MUT-30 | DEFERRED | DEFERRED |  |
| S1-MUT-31 | REQUIRED | PASS | [DirectAttitudeCompositionAndPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15) |
| S1-MUT-32 | REQUIRED | PASS | [ResidenceMoveInviteAndConflict](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47) |
| S1-MUT-33 | REQUIRED | PASS | [NestedRepaymentIngress](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L111) |
| S1-MUT-34 | REQUIRED | PASS | [CalledRepaymentThirdPartyAndInvalidation](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L106) |
| S1-MUT-35 | REQUIRED | PASS | [FullFavourSlotDistinguishesBargainFromHelp](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37); [BargainCapacityRace](../../tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L52) |
| S1-SUP-GENERATED | UNEXERCISED | UNEXERCISED |  |
| S1-SUP-SHRINK | UNEXERCISED | UNEXERCISED |  |
| S1-SUP-HELDOUT | UNEXERCISED | UNEXERCISED |  |
| S1-GLOBAL-FIXTURE | REQUIRED | PASS | fixture-audit.json: exact initial fields/inputs, endogenous provenance, profiles and proposal terms for every subcase |
| S1-GLOBAL-KNOWLEDGE | REQUIRED | PASS | [ResponseAutonomyAndBoundedFailureKnowledge](../../tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28) |
| S1-GLOBAL-ORACLE | REQUIRED | PASS | oracle-audit.json; InvariantOracle.cs and explicit expected arithmetic in scenario source |
| S1-GLOBAL-FALLBACK | REQUIRED | PASS | [ReferenceProfilesAndAutonomousCycle](../../tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L102); [StableFallbackSensitivityAndSemanticAsymmetry](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L82); [RepairResidenceDestinationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L12); [RepairCallCancellationDependency](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L28); [RepairResidenceReadWriteMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L25); [RepairMarriageCapacityPermutation](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L52); [RepairAggregateGrainAndEnablers](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159); [RepairCommutingAndAsymmetricControls](../../tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234) |
| S1-GLOBAL-ITERATION | REQUIRED | PASS | [ReplayStorageInputObserverAndAttributePairs](../../tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99) |
| S1-GLOBAL-CALLFAVOR-MAP | REQUIRED | PASS | [CompleteCallFavorPayloadMatrix](../../tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L89) |
| S1-GLOBAL-REQUIRED-COVERAGE | REQUIRED | PASS | All 167 rows individually emitted; 127 coder-owned REQUIRED must pass; REQUIRED external conformance explicitly awaiting review |
| S1-GLOBAL-MANIFEST-INTEGRITY | REQUIRED | PASS | AcceptanceCatalog.Read: Git blob and census |
| S1-GLOBAL-CONFORMANCE | REQUIRED | AWAITING INDEPENDENT REVIEW |  |
