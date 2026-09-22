# IMP-0001 candidate-v2 — Fresh independent K4 conformance review

**Final verdict: BLOCK.** This verdict applies only to `imp-0001-slice1-conformance-candidate-v2` at exactly **`ba16829e240950f1f3c648107cf3b8b36f996971`**, against **`SFL-V0-S1-ACCEPTANCE-v1`**. The baseline is valid; this is a substantive conformance BLOCK, not `REVIEW BASELINE INVALIDATED`.

Two reviewer-owned public-API counterexamples establish an incorrect material-deadlock result and an over-broad technical-fallback disclosure. The canonical build and tests pass and reproduce the exact-head CI evidence. That reproducibility does not establish the two failed semantic claims. The independent disposition is **124 REQUIRED obligations satisfied, 4 REQUIRED obligations unsatisfied**, with all **33 DEFERRED / 3 N-A / 3 UNEXERCISED** classifications preserved. `S1-GLOBAL-CONFORMANCE` is **BLOCK**.

No candidate production code, tests, manifest, configuration or semantic authority was edited. No repair was attempted. The review return adds only this report on `review/imp-0001-independent-conformance-v2-return`, based on freshly fetched `origin/main` at `afa3edbe76b27dc4e9678124ae37ba9e0b9e3c8f`. Neither PR #16 nor PR #7 was merged or changed.

## 1. Independence, scope and immutable identities

This fresh reviewer task did not author repair-v2, candidate production code, acceptance-harness changes or the implementation evidence mapping. No repair author was used as reviewer and no subagents were used. The coder reports, green CI, dispatch/reconciliation conclusions and prior candidate-v1 findings were treated as claims to inspect. They did not supply expected results for the reviewer probes or decide the verdict.

The canonical retrieval order was followed during preparation and execution: repository entry/governance; the v2 packet and reconciliation; original implementation task and BLOCK repair packet; accepted SPEC/ADRs; frozen manifest and cited verification sources; exact-v2 production/tests/evidence; then candidate-v1 reconciliation/full report as historical counterexample material. Present conformance was re-derived from the accepted authority. The prior report's ledger and verdict were not used as v2 authority.

The inspected scope includes DEC-0001, ADR-0001 through ADR-0005, SPEC-SFL-0001, the lower-level/response/resolution/determinism verification families, cross-cutting contract, frozen scoring profiles, CallFavor applicability record, and manifest Parts A–L. Every production source file, every acceptance scenario/checker/audit source, unit/bootstrap tests, project settings and canonical CI workflow was inspected. Later-slice semantics were assessed only as scope boundaries.

The execution-start checks were recorded at **2026-09-22 19:45:44 UTC**. The execution-finish checks were recorded at **2026-09-22 20:14:25 UTC**. Both included `git fetch origin`, ref/PR inspection and independent manifest verification; the values below agreed at both ends.

| Identity | Verified value |
| --- | --- |
| Repository | [Classique-Smokes/Mesopotamia-Sim](https://github.com/Classique-Smokes/Mesopotamia-Sim) |
| Detached HEAD and candidate-v2 ref | `ba16829e240950f1f3c648107cf3b8b36f996971` |
| PR #16 | [PR #16](https://github.com/Classique-Smokes/Mesopotamia-Sim/pull/16), exact head `ba16829e240950f1f3c648107cf3b8b36f996971`, open, draft, unmerged |
| Candidate-v1 ref and PR #7 | `7e11dab7697121eb0dbb169ba46210d81b80586e`; PR #7 open, draft, unmerged |
| Freeze ref | `sfl-v0-slice1-acceptance-v1` → `55377cc34b8bc3ccbf9cdf5029e9791dae965987` |
| Manifest version and blob | `SFL-V0-S1-ACCEPTANCE-v1`; `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| Manifest census | 167 distinct IDs: 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED |
| SPEC blob | `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52` |
| Cross-cutting contract blob | `7953a7f1c1cf3bd01cb8c08733618664e7a1504d` |
| Canonical v2 packet blob | `21d1067e553821daff045dfd9ed877e62d545dad` |
| Current-main / return-branch base | `afa3edbe76b27dc4e9678124ae37ba9e0b9e3c8f` |

Manifest bytes were independently hashed using Git's blob header (type, length and NUL separator) plus raw file bytes, and parsed without relying on the candidate's catalogue. Candidate, frozen ref and current main have the same manifest blob. The SPEC, accepted ADRs and cited substantive verification sources agree with the acceptance freeze. The verification README's administrative freeze/navigation update does not alter accepted semantics. `git status --porcelain=v1 --untracked-files=normal` remained empty in the detached candidate after the canonical run and reviewer probes.

The controlling packet is [IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2_PACKET.md](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/afa3edbe76b27dc4e9678124ae37ba9e0b9e3c8f/tasks/implementation/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2_PACKET.md). All production, test and authority links below pin the reviewed v2 SHA rather than a moving branch.

## 2. Canonical execution and exact-head evidence comparison

The exact four commands ran sequentially from the detached candidate root with **.NET SDK 10.0.401**, **C# 14**, Microsoft Testing Platform, **runtime 10.0.12**, **MSBuild 18.9.11**, Windows **10.0.19045**, `win-x64`. SDK selection used process-local `DOTNET_ROOT`/PATH only. Nullable analysis, analyzers and warnings-as-errors stayed enabled.

| Exact command | UTC start → finish | Exit |
| --- | --- | --- |
| `dotnet restore Mesopotamia.Sim.slnx` | 2026-09-22T19:46:12.4519184Z → 2026-09-22T19:46:15.2260350Z | 0 |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | 2026-09-22T19:46:15.2483728Z → 2026-09-22T19:46:26.5226921Z | 0 |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | 2026-09-22T19:46:26.5261384Z → 2026-09-22T19:46:33.4214233Z | 0 |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | 2026-09-22T19:46:33.4252349Z → 2026-09-22T19:46:36.2215617Z | 0 |

The Release build reported **0 warnings / 0 errors**. The test runner reported **8 succeeded / 0 failed / 0 skipped**. The acceptance test method executed **57 named scenarios**, with **344 audited world instances**. Its emitted inventory contains 127 coder-owned REQUIRED PASS entries and an explicitly pending independent-conformance row; it does not award itself K4 PASS. These counts distinguish runner test methods, scenario names, fixture worlds and manifest obligations.

The raw stdout/stderr, command timestamps/exit codes and SDK identity were retained locally. The format command emitted no output; its retained log is empty and its recorded exit is 0. Selected runner output:

```text
Test run summary: Passed!
  total: 8
  failed: 0
  succeeded: 8
  skipped: 0
```

The exact-head [CI run 35772625856](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35772625856) succeeded for `ba16829e240950f1f3c648107cf3b8b36f996971`. Artifact **10714762656**, `slice1-acceptance-evidence`, was downloaded and independently hashed. Its ZIP SHA-256 is **`6e0f87e00005b0bc946eec02684955616964b192c4b2ba4f6fcf3c5d5f8ab0f7`**, matching the packet's digest.

All six fresh evidence files equal the artifact files after **only CRLF → LF** normalization. The five JSON values also compare deeply equal, with **zero differing fields or elements**. Raw byte hashes differ because of line endings. No timestamps, statuses, ordering, source clauses or references were discarded to obtain the match.

| File | CI raw SHA-256 | Fresh raw SHA-256 | Comparison |
| --- | --- | --- | --- |
| cases.json | `4bc18aabb1b339930afcdf3fec9570d5d8ac9836eeccce075d19afcac1221462` | `efd99a27507e702584e3445f0a0907073f3d6c300a2a6a2a1c8efe7f6de1c319` | LF-normalized bytes identical; JSON identical |
| fault-controls.json | `6f18c64f1e1ff2b7a282b5499d515f0b38e52943bb35dfa2b1444a8992b8b9ee` | `f6225185016c0b64548c223aa68ee4ba5de1f5ac2a9e5908c6b08d974b1d7b2c` | LF-normalized bytes identical; JSON identical |
| fixture-audit.json | `e655d7cfc56937c02e2b46dcde0efbd6b3bc09be70239d0f06d094d46aca9ad4` | `f6d732a4ce46734d02e5dbaa1d9377a091c6080c44c5e5887175dd9e6e310c6c` | LF-normalized bytes identical; JSON identical |
| oracle-audit.json | `31e7027c6397e1919d499d4e23688204f5eb398fa30b91bff71731f81a43966f` | `e4f20c559f12c2ccfd278c58751f2a4485b624c32fc36ba0b19f01474aeb8dc6` | LF-normalized bytes identical; JSON identical |
| slice1-results.json | `12521a6f3fc8f7054c54cb32475d2b1dfc14e6577f1930f1a1fa6a7781e90d97` | `8c8a4d7b58b15d2e6609a450f883d4ae5af2693a5b1345de0da4d21cb94e9f35` | LF-normalized bytes identical; JSON identical |
| slice1-results.md | `8115bd71ff3f3c10cf87b87143b76673b44b169f819cc20e8d33a8bc40c5c49a` | `93f7b6cc1e265aeb858d503a34f1b9531436f47f91e67aebee5c4ad7dcbac8ed` | LF-normalized bytes identical |

## 3. Blocking findings

### B1 — A cancelling future input batch incorrectly suppresses MaterialDeadlock

**Disposition: BLOCK. Affected rows: `S1-080`, `S1-GLOBAL-CONFORMANCE`.**

**Authority.** SPEC §9.5 requires MaterialDeadlock when all producers are blocked by need, no available transfer can clear need, and no scheduled exogenous input **can resolve the condition** ([SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md:784](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md#L784)). External resource changes are valid declared fixtures under §1.1 ([SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md:27](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md#L27)); the positive-quantity restriction on voluntary action terms does not prohibit an explicitly scheduled external withdrawal. The cycle phases place exogenous inputs and maintenance before voluntary decision contexts. VS-SFL-080's future-input negative control must be read under that accepted definition ([DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md:24](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md#L24)).

**Public-API reproduction.** Three people start with grain `[0,0,0]`, separate dwellings, no relations and no voluntary proposals. Two declared inputs target person 1 at cycle 2, in this order: input 1 adds one grain; input 2 removes one grain. The stock path is `0 → 1 → 0`; neither input is invalid and no stock goes negative. Both occur before maintenance and before any Farm/transfer decision. Cycle 1 already has all producers blocked and no transferable grain. The future batch offers no opportunity to act with cleared need.

**Expected:** cycle-1 `MaterialDeadlock = true`. **Observed:** `false`. At cycle 2 the same candidate applies both inputs, misses consumption for all three people and reports `true`; all stocks are still zero and all actors have NeedsGrain. No resolving opportunity ever existed. A control with `+2, -1` correctly reports false: the surviving unit pays consumption, leaving person 1 at zero grain but without NeedsGrain, so Farm can occur.

**Cause.** [Execution.cs:181](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/Execution.cs#L181) suppresses the diagnostic whenever `initial.Inputs.Any(i => i.Cycle > cycle && i.Delta > 0)`. It checks the existence of an individual positive entry, not whether the accepted scheduled input sequence can resolve the material block. [Execution.cs:362](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/Execution.cs#L362) confirms the whole input batch executes before consumption. The public `GrainInput` schema is signed ([State.cs:21](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/State.cs#L21)), and the run completes normally with both valid inputs recorded.

**Evidence gap.** [CrossCuttingScenarios.cs:65](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L65) covers no future input, a valid transfer and one unopposed future positive input. Those controls all pass; they never distinguish an actual future recovery from a cancelling batch. Reviewer probe `R4-NET-ZERO-FUTURE-INPUT-DEADLOCK` makes that distinction without any candidate changes. The accepted condition is already definite; no new social rule or rescue mechanism is required to judge this result.

### B2 — A debt-limited conflict falsely attributes technical fallback to a commuting Farm

**Disposition: BLOCK. Affected rows: `S1-081`, `S1-GLOBAL-FALLBACK`, `S1-GLOBAL-CONFORMANCE`.**

**Authority.** SPEC §9.2 confines technical fallback to unresolved alternatives after semantic/domain constraints, and §9.4 records its use in history ([SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md:738](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md#L738), [SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md:778](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md#L778)). VS-SFL-081 requires isolated, inspectable fallback and removal of the marker when domain asymmetry decides ([DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md:50](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md#L50)). The v2 packet expressly requires examination of over-marked asymmetric/commuting cases. A terminal event's `TechnicalFallback` field is a disclosure of fallback use, not a separately specified conservative 'might share a resource' diagnostic.

**Public-API reproduction.** Five people start with grain `[20,0,20,20,20]`. In cycle 1, people 1, 3 and 4 each commit a one-grain BFF to person 2, creating three distinct favours. Person 5 commits a five-grain loan to person 2. No debt/favour is fixture-written. An empty cycle 2 follows. After cycle-3 maintenance the debtor has grain **6**, a remaining debt of **5**, and all three favours.

In cycle 3 each holder calls its own favour for `RepayDebt(theSameDebt, 2)`, while the debtor's ordinary initiative is Farm. All four proposals are individually feasible from the common snapshot. Reviewer code exhausts **all 24 proposal-ID orderings** of these four actions.

In every ordering the first two calls commit two units each, the last call invalidates with `RepaymentExceedsRemaining`, and Farm commits. Remaining debt is **1** and final debtor grain is **6**. The debt conflict properly needs a disclosed technical order between the three callers. **Farm is marked `TechnicalFallback = true` in all 24 runs**, although its position cannot change any call's success or the final material/relation result when the relative caller order is held fixed. For each of the six caller orders, all four placements of Farm have the same winners, consumed/retained favours, debt balance and final grain.

This independence also follows directly from the bounds: the debt permits at most four units of repayment; the debtor already has six units, enough for those payments while retaining the required two-grain reserve. Farm cannot make the third two-unit repayment fit the one remaining unit of debt. The repayments commute with Farm's +4 effect; ordinary event sequencing/intermediate balances are not a new competing alternative for the Farm outcome.

**Cause.** [ResolutionDependencies.cs:24](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/ResolutionDependencies.cs#L24) detects the real aggregate debt conflict. The subsequent grain pass at [ResolutionDependencies.cs:32](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/ResolutionDependencies.cs#L32) sums all nominal transfers as six, compares against `6 - 2`, and marks every potential incoming credit/Farm at lines 40–43. It does not account for the debt bound that prevents six units ever being paid. [Execution.cs:151](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/src/Mesopotamia.Sim/Execution.cs#L151) copies that over-approximation directly into consequential terminal-event markers.

**Evidence gap and limit of the finding.** Aggregate-debt, aggregate-grain/enabler and commuting controls are each tested separately ([RepairResolutionScenarios.cs:135](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135), [RepairResolutionScenarios.cs:159](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159), [RepairResolutionScenarios.cs:234](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234)). Their intersection exposes the false attribution. This finding does not demand a particular debt winner, claim that the calls should be unmarked, or claim a missing marker in this probe. It rejects the false disclosure on the independent Farm. B1 independently requires BLOCK even without this separate history-precision defect.

## 4. Seven K4 conclusions

| K4 obligation | Conclusion | Independent basis |
| --- | --- | --- |
| 1. Manifest integrity | SATISFIED | Exact blob/version/census and candidate/freeze/PR identities verified at start and finish; substantive accepted sources match the freeze. |
| 2. Substantive evidence for every REQUIRED row | BLOCK | The complete ledger identifies 124 satisfied and 4 unsatisfied obligations. Passing mapped examples do not defeat B1/B2; independent conformance remains unsatisfied. |
| 3. Source-to-assertion fidelity | BLOCK | The mapped deadlock assertion is too narrow for scheduled inputs that cannot resolve need; fallback tests do not establish precision when two capacity constraints intersect. Other source/assertion translations were inspected individually. |
| 4. Oracle independence (Part I) | SATISFIED | Full source inspection, not just a token scan: independent material/attitude/relation/history replay, explicit source constants and arithmetic; no assertion-target production classifier/scorer/transition is reused as the expected oracle. |
| 5. Fixture discipline (Part J) | SATISFIED | All 344 canonical world instances map to declared initial facts, profiles, exogenous inputs and public proposals. Endogenous debt/favour preconditions are committed; detached corrupt witnesses are checker challenges, not fabricated scenario outcomes. |
| 6. Honest deferral and slice boundaries | SATISFIED | All 39 non-required classifications preserved; no fake household/recognition/communication/checkpoint/departure implementation supplies later-slice evidence. |
| 7. No silently invented semantic choice | BLOCK | The positive-entry shortcut substitutes for the accepted can-resolve deadlock predicate. Treating an approximate dependency mark as actual fallback use is not an accepted alternate history meaning. Neither is authorized by a passing narrow test. |

Independence of an oracle does not prove its completeness. The repaired attitude oracle is independent and successfully detects missing mandatory causes; that does not make it a deadlock or fallback oracle. Likewise, the candidate's [AcceptanceTests.cs:51](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AcceptanceTests.cs#L51) token scan is a useful narrow check, but the review conclusion also depends on inspecting all scenario code. `S1-GLOBAL-REQUIRED-COVERAGE` is accepted as the inventory obligation (no missing/skipped IDs), not misused as proof that every emitted PASS is semantically true.

## 5. Adversarial domain and regression review

### A. Current action/dependency domain

The executable action vocabulary was derived from `ActionTerms`, validation, transfer/commit semantics and accepted CallFavor closure: Farm; Gift offer/request; Loan offer/request; RepayDebt; BFF; RMRH offer/request; CallFavor; reciprocal cancellation; direct marriage; residence move/invite. Farm and RepayDebt are the only called payloads. Wrapped repayment/Farm use the **called debtor's effective actor and terms**, not the outer holder, for material dependencies.

The following dependency classes were inspected in production and against the actual assertions. This is not a claim that all arbitrary histories were exhaustively searched.

| State/condition read or written | Dependency analysis and evidence |
| --- | --- |
| Residence | Same mover permits at most one transition; a moving destination owner can invalidate another move/invite. Matrix tests and the independent six-order three-person cycle cover both read/write and shared-write cases. |
| Marriage | Shared participants compete for one permanent establishment. Sex/kin/stored-attitude gates are applied before response and revalidated; no new same-cycle kin/sex writer exists. |
| Favour identity/capacity/provenance | Call/cancel retire concrete IDs; creation/retirement overlap on ordered pairs; competing creation can change origin provenance even when final existence looks equal. Existing repair cases were source-inspected rather than accepted by name. |
| Debt remaining | Aggregate direct/wrapped repayment exceeds one claim even if every pair fits. Revalidation rejects over-remaining terms instead of clamping, consuming a favour or converting meaning. |
| Grain and reserve | Aggregate spending is compared to current stock; repayment alone preserves two grains. Incoming gift/loan/help or effective Farm can enable additional commits. Independent 72-order controls confirm real sensitivity is marked; B2 shows the debt intersection over-marks. |
| Need/attitude and cycle phases | Need can clear on receipt but no same-cycle personal reactivation occurs. Direct attitude consequences close after accepted resolution; they cannot change another proposal gate mid-resolution. Decay is maintenance, and due review follows current-cycle decisions. |

Proposal-ID renaming, participant/relation-ID renaming, container iteration and observer reads were kept as different interventions. A changed arbitrary debt/residence winner is permitted only in the disclosed fallback exercise. Commuting identity relabelling is compared through isomorphic semantic state, relation origins, causes and participant knowledge. Fixed-ID storage/observer variants retain exact serialized history. B2 is a marker-precision failure; the independent probes did not establish a remaining undisclosed winner-sensitivity example.

### B. Full attitude-event domain and missing-cause detection

The complete fixed update domain was re-derived: gift/help +10 to giver; loan +5 to lender; repayment +5 to borrower; fulfilled call +10 to fulfiller; genuinely needy ordinary-request refusal -5; no-need ordinary refusal zero; called refusal -20; unpaid due review -10 once; rejected marriage zero. All offer/request shapes were traced through their actual transfer or refusal meaning. Unable/Invalidated do not become voluntary refusals.

The strengthened checker derives the mandatory cause set from consequential events/action terms and its own need/material replay. It does not merely sum whichever contribution entries production supplied. At each composition and cycle end, missing/extra cause membership is checked. Removing a mandatory contribution while coherently adjusting the final attitude, and removing the entire composition, both produce semantic assertion failures in the candidate's explicit checker challenges. No production consequence classifier supplies those expected causes.

Independent R2 adds 27 request/stock combinations and four three-cause due-cycle cases. Recipient-request RMRH, no-need stock-at-one controls, infeasible donors, called refusal and unpaid debt due all behave as required. Mixed +10/-20/-10 causes give +75 from +95 and -100 from -95, retaining all three distinct causes in one transition. These passing results are evidence for the current repair, not adoption of its narrative.

### C. Personal information boundary

The source boundary is explicit: `PersonalInputCapture.Capture` receives the objective snapshot and builds immutable `PersonalDecisionInputs`; personal generation/gating/scoring helpers receive that bounded value only. Its fields were traced to every branch/component and to `TraceInputs`. Own state, own residence, incoming/outgoing direct attitudes, kinship, marriage, direct debt/favour claims and explicitly observed facts are separately represented. Identity-only binding does not provide target grain, sex, residence or unrelated debt. Explicit sex/home bindings supply their declared values, including stale values, rather than reading unbound current world fields. Naming an observed debt grants only that selected claim, not unrelated claims.

The public response/world feasibility and precommit validator still use objective state later, as required. A personal request can remain unchanged while the later result differs between feasible Help and Unable. The narrow observation binding is a current-cycle laboratory input, not an invented persistent Slice-2 recognition or communication engine.

Independent R3 executes 48 variations across identity-only, partial sex/home bindings and unrelated-debt perturbations. Personal traces are equal within each fixed information set; the candidate only generates marriage/move routes when the relevant binding is supplied. Later objective feasibility remains correct. No hidden personal world input was found in this inspected executable domain.

### D. D1–D5 and architectural seams

| Bundle / seam | Conclusion |
| --- | --- |
| D1 direct attitude composition | Sum then clamp, distinct causes, positive/negative saturation, permutation and missing-cause controls hold. The independent third-cause probe adds coverage without editing the harness. |
| D2 residence conflict | Core one-transition rule, genuine two Accepts, exact loser reason and fixed-ID contender permutation hold. The conjunctive bundle cannot pass globally because S1-081 fails through B2, not because two residence transitions committed. |
| D3 CallFavor closure | Two callable / eleven non-callable action shapes, non-payload types, one response scope, personal coexistence, successful consumption and retention on refusal/inability/invalidation all have substantive evidence. No third-party new voluntary choice is smuggled into repayment. |
| D4 grain domain | All nine required ingresses cover nonpositive and positive terms; the public long boundary is structurally non-fractional. Direct and wrapped repayment check remaining-1/remaining/remaining+1; invalid terms are rejected before response/social failure. |
| D5 BFF atomicity | Positive/free slot, initially full slot and lost-capacity-at-commit cases hold. Failed BFF cannot partly transfer, create a favour or silently become Gift. RMRH retains its independent help meaning at full capacity. |
| Kernel / transactions | Common post-maintenance snapshot, explicit proposal order, target autonomy, immediate precommit revalidation, copy/validate/commit and complete reaction closure before publication are present. Failed cycles cannot resume as successful completed cycles. |
| State / IDs / caches | Typed stable IDs do not derive from mutable content; checked integer arithmetic and explicit counters are used. Immutable snapshots do not alias writes. No behavior-affecting derived cache exists; the manifest expressly permits structural evidence instead of a fake rebuild test. |
| Scope / policy | No universal household-membership container, hidden later-slice authority, save/load framework or concurrent kernel was added. Policy/profile scoring remains separate from action/world semantics; all frozen profile constants were inspected. |

Fault-control classification was inspected separately from ordinary test success. Actual duplicate-cause and closure-suppression injections exercise production guards. Detached material/attitude corruption and coherent omitted-cause witnesses challenge checker adequacy. Other MUT rows use the frozen permitted focused negative/structural routes and explicitly report source-mutation execution as unexercised where appropriate. No arbitrary crash, timeout or unrun source mutant was credited as a detected semantic mutation. The three supplemental UNEXERCISED manifest rows retain their frozen status; reviewer scratch enumeration does not reclassify them.

## 6. Reviewer-owned public-API probes

The scratch console is external to the candidate, references only its built public DLL, uses a separate assembly name and has no friend access, reflection, internal state writes or copied production classifiers. Expected results use explicit accepted arithmetic, action outcomes and independent history projections. Debt/favour setup goes through ordinary public commits. Complete source and project file are embedded in Appendix B so the counterexamples remain reproducible from this sole permitted return file.

The run exercised **187 fresh world instances** across **10 assertion groups**: **8 PASS, 2 FAIL**, plus two retained observation records. The console catches each assertion exception and continues to preserve later controls; therefore its process exit 0 means the harness completed, not that the candidate passed every probe. Assertion statuses and the observations below are the semantic result.

| Probe | Worlds | Result | Independent assertion / observation |
| --- | --- | --- | --- |
| R1-AGGREGATE-GRAIN-CREDIT-ALL-PERMUTATIONS | 72 | PASS | Gift/loan/RMRH incoming credit × all 24 orders with three requests. Credit last permits two request commits; earlier credit permits three. All real dependencies marked; total grain conserved. |
| R1-DEBT-BOTTLENECK-COMMUTING-FARM | 24 | FAIL — B2 | All six relative caller orders × four Farm positions: two repayments, last call invalidated, Farm commits, final grain 6/debt 1; false Farm marker in 24/24. |
| R1-RESIDENCE-THREE-CYCLE | 6 | PASS | All permutations of a three-person destination cycle; independently replayed mutable homes match outcomes and dependency markers. |
| R2-REQUEST-REFUSAL-CONTROLS | 27 | PASS | Three ordinary request forms × own stock 0/1/9 × donor stock 0/1/9. Only a feasible voluntary decline with genuine need yields -5. |
| R2-THREE-MIXED-CAUSES | 4 | PASS | Initial attitude ±95 × reversed proposal IDs. Gift +10, called refusal -20 and due -10 compose once with all three causes. |
| R3-IDENTITY-ONLY-HIDDEN-FACT-CROSS-PRODUCT | 12 | PASS | Target grain 0/1/20 × sex × home; identity-only personal traces equal; later objective Help/Unable differs correctly. |
| R3-PARTIAL-OBSERVATION-ISOLATION | 32 | PASS | Four sex/home binding sets × eight hidden-world variants. Only bound facts enable their routes; no unbound fact affects trace. |
| R3-UNBOUND-DEBT-ISOLATION | 4 | PASS | Observed selected third-party debt on/off × unrelated claim amount 1/7. Unbound claim absent from candidates/inputs. |
| R5-IDENTITY-STORAGE-OBSERVER-ISOMORPHISM | 4 | PASS | Baseline, nonmonotonic person/dwelling/relation ID mapping, storage/input reversal, added/reordered readers; semantic causes/origins match and fixed-ID history exactly matches. |
| R4-NET-ZERO-FUTURE-INPUT-DEADLOCK | 2 | FAIL — B1 | Cycle-2 +1/-1 batch falsely suppresses cycle-1 deadlock; +2/-1 recovery control correctly suppresses it. |

| Scheduled cycle-2 inputs | Expected cycle-1 deadlock | Observed cycle-1 deadlock | Cycle-2 result |
| --- | --- | --- | --- |
| +1 then -1 | true | false | Deadlock true; all grain 0 and all NeedsGrain true |
| +2 then -1 | false | false | Deadlock false; all grain 0; recipient NeedsGrain false after paid consumption |

| Relative call order (holder IDs) | Farm positions exhausted | Committed calls | Invalidated call | Farm fallback / final grain / debt |
| --- | --- | --- | --- | --- |
| 1,3,4 | 4 | 1,3 | 4 | true in all 4 / 6 / 1 |
| 1,4,3 | 4 | 1,4 | 3 | true in all 4 / 6 / 1 |
| 3,1,4 | 4 | 3,1 | 4 | true in all 4 / 6 / 1 |
| 3,4,1 | 4 | 3,4 | 1 | true in all 4 / 6 / 1 |
| 4,1,3 | 4 | 4,1 | 3 | true in all 4 / 6 / 1 |
| 4,3,1 | 4 | 4,3 | 1 | true in all 4 / 6 / 1 |

## 7. Independent evidence register and all-167-row ledger

The register below records what the reviewer actually found in each scenario source, including limitations. Its E-numbers are report-local evidence references, not new acceptance IDs. These findings were written after inspecting expected assertions and production paths; they are not the candidate's generic `Oracle`/`FixtureWrites` strings. The row ledger starts from the independently parsed frozen inventory; coder PASS labels do not determine its dispositions.

Every executable E-entry ran in the fresh canonical suite and has exact fixture/profile/input records among the 344 `fixture-audit.json` instances. Common independent ledger replay checks explicit sources/sinks, references, relations, cause membership, score sums and terminal history. The passing result is qualified by the stated assertion scope, especially B1/B2.

<a id="e01"></a>
**E01 — GiftHelpMeaningsAndNeedClearing** ([PipelineScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10)). Both public offer and request routes move one grain with explicit Gift/Help meaning and +10 recipient-to-giver effect; genuine Gift creates no favour. The missed-consumption actor clears need on receipt but receives no second personal activation. The independent material/event replay checks the resulting ledger.

<a id="e02"></a>
**E02 — ResponseAutonomyAndBoundedFailureKnowledge** ([PipelineScenarios.cs:28](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28)). Accept/Decline profile pairs and infeasibility-before-response controls distinguish voluntary refusal from Unable. Both direct participants learn bounded terminal reasons; unrelated private values and proposed-but-uncommitted effects do not become knowledge. Read with the accepted-then-invalidated scarce-grain companion for the full three-way classification.

<a id="e03"></a>
**E03 — SharedSnapshotScarceGrain** ([PipelineScenarios.cs:58](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58)). Two targets/requests are accepted from one snapshot, then limited donor grain allows only one commit. The loser is explicitly invalidated at precommit; both genuine Accepts, one initiative per holder, multiple incoming responses and no retry are asserted. Permuting collection order preserves the fixed-ID result.

<a id="e04"></a>
**E04 — GiftGrainIngress** ([PipelineScenarios.cs:82](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L82)). OfferGift and RequestGiftOrHelp each receive negative/zero and valid-positive ingress controls. Invalid terms never activate a response or move grain/attitude. Public quantity properties are integral long values with no fractional/coercing overload, providing the frozen permitted structural non-integral route.

<a id="e05"></a>
**E05 — LoanRoutesAndRepaymentHistory** ([DebtScenarios.cs:9](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9)). Offer and request loans create claims through real commits. Independently expected original/remaining values, partial and full repayment, +5 effects and retained provenance distinguish a satisfied claim from erased debt history.

<a id="e06"></a>
**E06 — RepaymentAmountAndReserve** ([DebtScenarios.cs:38](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38)). Invalid direct repayment quantities and over-remaining terms are separated from materially infeasible valid terms. Resulting debtor stocks 1/2/3 test the repayment-only reserve. No generic two-grain floor is imposed on Gift/help; long boundary structure covers non-integral values.

<a id="e07"></a>
**E07 — DebtDueAfterThirdFullCycle** ([DebtScenarios.cs:64](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L64)). A committed loan is followed through before, at and after N+3. Review occurs after due-cycle decisions, unpaid balance yields one -10 cause only, and timely full repayment suppresses it without automatic collection. R2-THREE-MIXED-CAUSES independently combines due review with two other signed causes.

<a id="e08"></a>
**E08 — LoanGrainIngress** ([DebtScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L89)). Both loan ingresses reject zero/negative terms before response and admit a positive integer. Integral public amount types have no truncating adapter. Material/debt provenance is checked independently rather than using production feasibility to predict validity.

<a id="e09"></a>
**E09 — ExplicitBargainAndReciprocalHelp** ([FavourScenarios.cs:16](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16)). BFF creates exactly one ordered-pair favour atomically with its benefit. RMRH stored attitude 74/75/76 controls exercise the threshold; kin scoring cannot substitute for the stored +75 gate. The distinct relation/transfer meanings and +10 cause remain explicit.

<a id="e10"></a>
**E10 — FullFavourSlotDistinguishesBargainFromHelp** ([FavourScenarios.cs:37](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37)). A prior public bargain fills the slot. Further BFF is Unable before response and cannot transfer or partially create a favour; RMRH still performs meaningful help while suppressing a second favour. RepairFavourCreationProvenance supplies the strong-attitude same-pair contrast as well.

<a id="e11"></a>
**E11 — BargainCapacityRace** ([FavourScenarios.cs:52](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L52)). The slot is free at snapshot acceptance, another accepted effect fills it, and BFF revalidation invalidates the entire bargain with FavourCapacityFull. Grain and favour writes cannot partially survive or be relabelled Gift. The transaction copy/validate/swap path supports the assertion.

<a id="e12"></a>
**E12 — CalledFarmSuccessRefusalAndInability** ([FavourScenarios.cs:70](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70)). Publicly created favours exercise feasible Fulfil/Refuse and NeedsGrain Unable. Only committed Farm consumes the favour and gives +10; refusal retains it with -20; inability retains it without either consequence. The holder pays one initiative and the called actor has one response scope, with no nested response.

<a id="e13"></a>
**E13 — CalledFarmPersonalCoexistence** ([FavourScenarios.cs:96](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L96)). The called actor already has an ordinary Farm initiative, yet a valid called Farm can also commit within response scope. Both +4 sources are accounted for without inventing a generic one-effect cap or charging/granting an extra personal initiative.

<a id="e14"></a>
**E14 — CalledRepaymentThirdPartyAndInvalidation** ([FavourScenarios.cs:106](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L106)). A real debt and favour permit repayment to a third-party creditor without asking that creditor for a new response. A separate competing commit removes an action precondition; the accepted fulfilment then invalidates, leaves its favour outstanding and produces no called-favour reward/penalty.

<a id="e15"></a>
**E15 — ReciprocalCancellation** ([FavourScenarios.cs:126](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L126)). Both opposite favours are created by actual bargains. Cancellation retires the pair together and retains origin history; no material transfer or attitude consequence is substituted. Read with the retirement-dependency probes for competing calls/cancellations.

<a id="e16"></a>
**E16 — BenefitGrainIngress** ([FavourScenarios.cs:136](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L136)). BFF and both applicable RMRH benefit routes validate their grain quantities before responses. Negative/zero controls leave material/social state unchanged and a positive control reaches ordinary gates. Typed long construction closes the fractional boundary without inventing a coercion rule.

<a id="e17"></a>
**E17 — DirectMarriageBoundaries** ([MarriageResidenceScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10)). Mutual stored +75/+76 enables the direct route while one direction +74 blocks it. Parent/child and sibling controls cannot marry; kin multiplication does not open the gate. Marriage commits no dowry transfer and causes no automatic residence or household change.

<a id="e18"></a>
**E18 — MarriageDeclineAndLifetime** ([MarriageResidenceScenarios.cs:31](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L31)). A declined direct proposal has zero attitude effect and does not consume lifetime eligibility. After one real establishment, another marriage attempt is excluded by the permanent v0 cardinality rule.

<a id="e19"></a>
**E19 — ResidenceMoveInviteAndConflict** ([MarriageResidenceScenarios.cs:47](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47)). Move and invite routes preserve counterpart acceptance. Two independently accepted effects targeting one mover yield one transition and one CompetingResidenceTransition invalidation. Reversed input containers preserve winner/history/markers; residence writes do not invent household participation or marriage effects.

<a id="e20"></a>
**E20 — MarriageDowryIngress** ([MarriageResidenceScenarios.cs:75](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L75)). The public direct-bypass proposal still validates its proposed grain term: nonpositive values fail before bride response and a positive integer proceeds. The direct route performs no dowry transfer. Long property structure supplies fractional-input exclusion.

<a id="e21"></a>
**E21 — CompleteCallFavorPayloadMatrix** ([MarriageResidenceScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L89)). The source-derived table admits exactly Farm and RepayDebt. All eleven current non-callable action shapes are challenged before called-actor response. Response/outcome/internal-effect types are not public ActionTerms payloads. Expected membership is written independently, not delegated to ActionRules.

<a id="e22"></a>
**E22 — NestedRepaymentIngress** ([MarriageResidenceScenarios.cs:111](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L111)). Wrapped CallFavor repayment receives its own zero/negative/remaining-1/remaining/remaining+1 controls before Fulfil/Refuse. Invalid inner terms reject the outer call without consumption or social failure effects; positive in-range terms reach normal reserve/capacity checks. Direct companion evidence closes the two-ingress boundary.

<a id="e23"></a>
**E23 — GeneratedActionVocabularyAndRepaymentTarget** ([AgencyScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L10)). Closed-loop personal generation is inspected across Farm, gift/request, loan, favour, repayment, marriage and residence vocabulary. The selected repayment targets the actual known creditor/claim. Candidates, gates, integer components and chosen-outcome links are retained; no production scorer is used as the expected arithmetic.

<a id="e24"></a>
**E24 — ExactKinScoringAndFullTrace** ([AgencyScenarios.cs:30](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L30)). Named integer components sum independently to FinalScore, kin amplification is exactly 1.5 using integer-scaled components, and stored attitude is unchanged. The trace contains losing and excluded candidates as well as the selected one. Candidate selection remains a replaceable policy layer.

<a id="e25"></a>
**E25 — CoResidenceMotivationWithoutCompulsion** ([AgencyScenarios.cs:63](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L63)). Pinned profile controls give marriage co-residence a stronger incentive than mutual liking, while target refusal still prevents movement. Motivation is a score component, not forced residence or a replacement for categorical/subjective eligibility.

<a id="e26"></a>
**E26 — PersonalResidenceAndIncomingResponse** ([AgencyScenarios.cs:85](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L85)). An actor's normal personal residence initiative coexists with an incoming response. The response neither consumes nor grants a personal initiative; common-snapshot choice still passes through central revalidation.

<a id="e27"></a>
**E27 — ReferenceProfilesAndAutonomousCycle** ([AgencyScenarios.cs:102](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L102)). All frozen personal/response profile constants are checked and an autonomous cycle runs the exact sum/highest-score rule. Exact ties carry a disclosed technical marker; eligible candidates are not selected by unordered containers. Profile coefficients remain laboratory configuration.

<a id="e28"></a>
**E28 — DirectAttitudeCompositionAndPermutation** ([CrossCuttingScenarios.cs:15](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15)). Mixed +10/-20 causes near both bounds are summed once before clamping; cause keys and signed deltas remain explicit. Reversed cause insertion preserves fixed-ID history. Deliberately incorrect sequential-clamp witnesses are rejected by the independent replay, and single-cause saturation is covered.

<a id="e29"></a>
**E29 — DuplicateReactionAndPrematureClosure** ([CrossCuttingScenarios.cs:48](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L48)). Actual internal duplicate injection is idempotently rejected with one contribution and a diagnostic. Suppressing closure raises the specific PendingAutomaticReactions guard; no completed boundary or resumption is allowed. The guard failure is not credited as an arbitrary crash detecting a semantic mutant.

<a id="e30"></a>
**E30 — MaterialDeadlockAndNegativeControls** ([CrossCuttingScenarios.cs:65](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L65)). The ordinary all-zero/NeedsGrain case, a real transfer and an isolated future positive input are valid passing controls. They omit interacting scheduled credits/debits. Reviewer probe R4-NET-ZERO-FUTURE-INPUT-DEADLOCK falsifies the full accepted condition; these controls cannot establish S1-080 (B1).

<a id="e31"></a>
**E31 — StableFallbackSensitivityAndSemanticAsymmetry** ([CrossCuttingScenarios.cs:82](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L82)). The same-person residence conflict repeats deterministically, permits proposal-ID winner changes, discloses fallback and removes the marker when one contender is infeasible. This narrow control passes; it does not establish precision across the full dependency domain. B2 supplies a commuting-effect counterexample.

<a id="e32"></a>
**E32 — ReplayStorageInputObserverAndAttributePairs** ([CrossCuttingScenarios.cs:99](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99)). Six-cycle runs reverse storage/input enumeration, add/reorder immutable readers, perturb display names and use Turkish culture. Independent canonical state/history/decision/knowledge comparisons remain equal. A focused noninterference control is not mislabelled as executed source mutation.

<a id="e33"></a>
**E33 — IdentityIsomorphismAndDisconnectedLocality** ([CrossCuttingScenarios.cs:130](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L130)). Nonmonotonic person-ID relabelling and addition of a disconnected actor preserve the normalized local material/relation/history outcome, without fallback. R5 extends this to dwelling/relation IDs, called payloads, debt provenance and due review; proposal-ID interventions are separately tested by R1.

<a id="e34"></a>
**E34 — NoDerivedAuthorityStructuralAudit** ([CrossCuttingScenarios.cs:153](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L153)). The authoritative dictionaries and nextRelation counter match the state inventory; published snapshots contain immutable data and are not aliased by later commits. Full source inspection found no behavior-affecting cache/index to rebuild. The frozen structural alternative applies; no stale-cache injection is claimed.

<a id="e35"></a>
**E35 — DistinctTransferMeanings** ([CrossCuttingScenarios.cs:167](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L167)). Gift, Loan, BFF and RMRH share material plumbing but retain distinct event/action meanings and their own debt/favour consequences. History and independent material replay prevent a transfer helper from replacing semantic action identity.

<a id="e36"></a>
**E36 — FixedAttitudeEventMatrix** ([AttitudeEventScenarios.cs:11](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L11)). The fixed SPEC event list is checked through gift/help +10, loan +5, repayment +5, called fulfilment +10, needy refusal -5, no-need refusal zero, called refusal -20, one-time unpaid due -10 and rejected marriage zero. Read with repaired recipient-request controls and independent R2 cross-products for completeness.

<a id="e37"></a>
**E37 — AggregateCapacityAndIndependentLedgerFault** ([AttitudeEventScenarios.cs:54](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L54)). Three accepted one-grain requests compete for two grains despite pairwise fit. Exactly two commit, the third invalidates, all dependency outcomes are marked and input reversal is invariant. A detached final-stock corruption is caught by the independently replayed ledger.

<a id="e38"></a>
**E38 — RepairResidenceDestinationDependency** ([RepairScenarios.cs:12](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L12)). Moving a destination owner can invalidate a different mover's accepted destination. Swapped proposal IDs expose both possible orders and mark the dependency; fixed-ID input permutations preserve the result. R1-RESIDENCE-THREE-CYCLE independently extends the chain to three movers.

<a id="e39"></a>
**E39 — RepairCallCancellationDependency** ([RepairScenarios.cs:28](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L28)). A called Farm competes with reciprocal cancellation over the same outstanding favour. Both ID orders are executed; consumption/retirement, material result and invalidation follow precommit state with disclosure. The source uses effective payload and favour references rather than only matching outer actors.

<a id="e40"></a>
**E40 — RepairNeedyReciprocalRequestRefusal** ([RepairScenarios.cs:48](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L48)). Recipient-request RMRH now yields mandatory -5 when genuinely needy and voluntarily refused. No-need, Unable and Invalidated controls carry no refusal penalty. Independent R2 includes all three ordinary request forms and stock/need boundaries.

<a id="e41"></a>
**E41 — RepairMissingMandatoryAttitudeCause** ([RepairScenarios.cs:72](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L72)). The oracle rejects both a history with a mandatory cause removed and coherently adjusted final attitude, and one with the whole composition removed. Expected causes are independently derived from qualifying interaction/failure/due events and need replay, so self-consistent omission is detected.

<a id="e42"></a>
**E42 — RepairHiddenCounterpartyGrain** ([RepairScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L89)). Changing only unobserved target stock leaves personal generation/gates/components/choice/recorded inputs unchanged; objective response feasibility can still differ later. R3 expands the pair to identity-only and partial-observation cross-products.

<a id="e43"></a>
**E43 — RepairResidenceReadWriteMatrix** ([RepairResolutionScenarios.cs:25](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L25)). Move/invite combinations test both same-mover write conflicts and destination-owner read/write dependencies under container and proposal-ID permutations. Immediate revalidation and one-transition cardinality are preserved. These are real dependencies; no broad conclusion is drawn from their flags alone.

<a id="e44"></a>
**E44 — RepairMarriageCapacityPermutation** ([RepairResolutionScenarios.cs:52](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L52)). Overlapping marriage participants create a one-marriage capacity conflict, with two genuine acceptances before resolution. Proposal-ID order chooses a disclosed unresolved alternative; storage order does not. Stored gates/kin exclusions remain separate.

<a id="e45"></a>
**E45 — RepairFavourCreationProvenance** ([RepairResolutionScenarios.cs:71](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71)). BFF versus strong-attitude RMRH creation at a free ordered pair is order-sensitive in which real event owns the favour origin. The opposite order preserves each action's own full-slot behavior. Creating help at an already full pair cannot create a duplicate favour.

<a id="e46"></a>
**E46 — RepairFavourRetirementDependencies** ([RepairResolutionScenarios.cs:104](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104)). Called payloads and reciprocal cancellation overlap concrete retired favour IDs; creation/retirement of an ordered pair is separately inspected. Swapped proposal IDs change only disclosed dependency outcomes, and successful relation provenance remains resolvable.

<a id="e47"></a>
**E47 — RepairAggregateDebtCapacity** ([RepairResolutionScenarios.cs:135](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135)). Three wrapped repayments whose pairs fit can exceed one debt's remaining balance in aggregate. Revalidation commits only valid amounts and invalidates the last over-remaining call without consuming its favour. R1's independent debt-plus-Farm probe preserves this passing behavior while exposing marker overreach.

<a id="e48"></a>
**E48 — RepairAggregateGrainAndEnablers** ([RepairResolutionScenarios.cs:159](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159)). Three-or-more spending proposals and incoming credits/Farm test aggregate donor capacity and enabling order. Reviewer R1 separately exhausts 72 gift/loan/RMRH credit permutations. Both find proper disclosure for real capacity sensitivity; the debt-limited false-enabler case is missing (B2).

<a id="e49"></a>
**E49 — RepairTransferShapesAndReserve** ([RepairResolutionScenarios.cs:196](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196)). Gift/help, loan and called/direct repayment material paths are checked together. Effective called debtor/amount and repayment-specific reserve are used at revalidation; reserve semantics are not generalized to unrelated transfers.

<a id="e50"></a>
**E50 — RepairCommutingAndAsymmetricControls** ([RepairResolutionScenarios.cs:234](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234)). Existing controls exclude obvious commuting transfers, sufficient aggregate capacity, full-slot no-creation help and infeasible contenders from fallback. They pass, but do not intersect debt capacity with grain capacity. The all-24-order commuting Farm counterexample defeats the global precision claim (B2).

<a id="e51"></a>
**E51 — RepairHiddenWorldFacts** ([RepairKnowledgeScenarios.cs:14](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L14)). Hidden sex, residence, kin/marriage and unrelated relation facts are perturbed without adding their observations to personal inputs. Traces/choices retain the expected isolation while later world feasibility remains authoritative. Direct-party facts are separately admitted by the frozen automatic-knowledge rule.

<a id="e52"></a>
**E52 — RepairExplicitSexAndResidenceObservations** ([RepairKnowledgeScenarios.cs:34](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L34)). Explicit bindings expose only their declared sex/home values, enabling the matching personal route. Identity alone does not disclose either. R3's partial-observation matrix holds bindings constant while changing the objective world to check that unbound facts stay out.

<a id="e53"></a>
**E53 — RepairObservedDebtBoundary** ([RepairKnowledgeScenarios.cs:71](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L71)). Third-party debt can enter personal called-repayment deliberation only through the named debt observation. Other claims remain absent. Independent R3 varies an unrelated debt's amount while preserving the binding and verifies candidate/input equality.

<a id="e54"></a>
**E54 — RepairCalledPayloadPrivateFeasibility** ([RepairKnowledgeScenarios.cs:94](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94)). Generation of a called Farm or repayment uses bounded known claim/observation data rather than peeking at the called actor's private grain/need. The later response/world validator can legitimately return Unable. No nested context or new general knowledge engine is introduced.

<a id="e55"></a>
**E55 — RepairPersonalInputIsolationAndTrace** ([RepairKnowledgeScenarios.cs:115](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L115)). The capture boundary alone receives WorldSnapshot; personal generator/gates/components accept only immutable PersonalDecisionInputs. Every behavior-affecting field is accounted for in TraceInputs, including explicit binding values and direct claims. Reflection/source checks are supplemented by R3 perturbations and R5 observer reads.

<a id="e56"></a>
**E56 — ConsumptionAndFarm** ([Scenarios.cs:34](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L34)). Paid maintenance consumes exactly one; a later miss sets NeedsGrain. Consuming the last grain does not itself create need. NeedsGrain excludes Farm; a valid Farm has an explicit +4 source event and no unexplained material change.

<a id="e57"></a>
**E57 — DecayBoundaries** ([Scenarios.cs:53](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/ba16829e240950f1f3c648107cf3b8b36f996971/tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L53)). Positive/negative attitudes are observed before, at and after the five-cycle cadence, including small values near zero. Decay uses -2/+1 toward zero without crossing and is kept outside the direct-cause batch. Material maintenance remains independently accounted for.

<a id="ga"></a>
**GA — Global review evidence.** The report's identity/census checks establish manifest integrity; the complete scenario/source audit plus all 344 declared world records establishes fixture discipline; Part-I dependency inspection and actual omitted-cause/corrupt-witness challenges establish oracle independence. The frozen CallFavor applicability table was mechanically compared with the full public action domain. Every required ID is represented below, including the independently adjudicated conformance row. No coverage/integrity result overrides a semantic counterexample.

**Ledger vocabulary:** SATISFIED means the scoped row has admissible substantive evidence after this review. UNSATISFIED means the cited counterexample defeats it or the required independent PASS is not awarded. DEFERRED, N-A and UNEXERCISED retain exactly the frozen classifications and rationale. Required classifications are not downgraded when their review disposition is UNSATISFIED.

| AcceptanceId | Frozen class | Reviewer disposition | Frozen obligation | Substantive evidence / limitation |
| --- | --- | --- | --- | --- |
| S1-090-A | REQUIRED | SATISFIED | successful consumption | [E56](#e56) |
| S1-090-B | REQUIRED | SATISFIED | missed consumption creates NeedsGrain | [E56](#e56) |
| S1-090-C | REQUIRED | SATISFIED | NeedsGrain blocks Farm | [E56](#e56) |
| S1-090-D | REQUIRED | SATISFIED | need clearing at next 1-grain unit; no same-cycle reactivation | [E01](#e01) |
| S1-090-E | REQUIRED | SATISFIED | Farm commits +4 with explicit source/history | [E56](#e56) |
| S1-091-GIFT | REQUIRED | SATISFIED | OfferGift accepted route | [E01](#e01) |
| S1-091-HELP | REQUIRED | SATISFIED | RequestGiftOrHelp accepted route | [E01](#e01) |
| S1-091-LOAN-OFFER | REQUIRED | SATISFIED | OfferLoan accepted route | [E05](#e05) |
| S1-091-LOAN-REQUEST | REQUIRED | SATISFIED | RequestLoan accepted route | [E05](#e05) |
| S1-091-BFF-POS | REQUIRED | SATISFIED | ExplicitBenefitForFavor positive-capacity atomic commit | [E09](#e09) |
| S1-091-RMRH | REQUIRED | SATISFIED | RelationshipMediatedReciprocalHelp positive route and explicit history meaning | [E09](#e09) |
| S1-091-MEANING-SEPARATION | REQUIRED | SATISFIED | material path sharing never collapses Gift/Loan/BFF/RMRH meanings | [E35](#e35) |
| S1-092-PARTIAL | REQUIRED | SATISFIED | partial repayment | [E05](#e05); [E47](#e47) |
| S1-092-AMOUNT-VALIDITY | REQUIRED | SATISFIED | repayment 0/negative/non-integral/over-remaining rejected before response; remaining amount valid | [E06](#e06) |
| S1-092-RESERVE | REQUIRED | SATISFIED | semantically valid repayment that penetrates reserve is Unable and has no social refusal effect | [E06](#e06); [E49](#e49) |
| S1-092-FULL | REQUIRED | SATISFIED | full repayment satisfies claim and retains history | [E05](#e05) |
| S1-092-DUE | REQUIRED | SATISFIED | N+3 before/at/later social-due one-shot penalty | [E07](#e07) |
| S1-093-BFF-POS | REQUIRED | SATISFIED | explicit bargain positive-capacity creation | [E09](#e09) |
| S1-093-RECIP-74 | REQUIRED | SATISFIED | reciprocal-help stored attitude +74 no favour | [E09](#e09) |
| S1-093-RECIP-75 | REQUIRED | SATISFIED | reciprocal-help stored attitude +75 may create favour | [E09](#e09) |
| S1-093-RECIP-76 | REQUIRED | SATISFIED | reciprocal-help stored attitude +76 may create favour | [E09](#e09) |
| S1-093-KIN-GATE | REQUIRED | SATISFIED | kinship amplification cannot satisfy +75 stored-attitude gate | [E09](#e09) |
| S1-093-GIFT-CONTROL | REQUIRED | SATISFIED | genuine Gift creates no favour | [E01](#e01) |
| S1-093-BFF-FULL | REQUIRED | SATISFIED | explicit BFF at already-full pair capacity -> Unable; no response/material/new favour | [E10](#e10) |
| S1-093-BFF-RACE | REQUIRED | SATISFIED | BFF capacity free at acceptance then lost before commit -> Invalidated; no partial commit | [E11](#e11); [E45](#e45) |
| S1-093-RMRH-FULL | REQUIRED | SATISFIED | RMRH may commit at full pair capacity while no second favour is created | [E10](#e10); [E45](#e45) |
| S1-094-FARM-CALLABLE | REQUIRED | SATISFIED | Farm is a valid response-closed payload when otherwise feasible | [E12](#e12); [E54](#e54) |
| S1-094-REPAY-CALLABLE | REQUIRED | SATISFIED | RepayDebt is a valid response-closed payload when terms/world state are valid | [E14](#e14); [E46](#e46); [E53](#e53); [E54](#e54) |
| S1-094-PERSONAL-COEXIST | REQUIRED | SATISFIED | callable fulfilment coexists with already selected ordinary personal initiative without a second personal-initiative charge | [E13](#e13) |
| S1-094-NONCALLABLE-MATRIX | REQUIRED | SATISFIED | every current NON-CALLABLE Slice-1 semantic action shape is rejected before called-actor response | [E21](#e21) |
| S1-094-NONPAYLOAD-MATRIX | REQUIRED | SATISFIED | response/result/internal-effect helper shapes cannot be used as payload types | [E21](#e21) |
| S1-094-UNABLE | REQUIRED | SATISFIED | valid callable payload world-infeasible -> Unable; favour remains; no +/- called-favour effect | [E12](#e12) |
| S1-094-DECLINE | REQUIRED | SATISFIED | valid feasible payload voluntarily refused -> Declined; favour remains; -20 | [E12](#e12) |
| S1-094-INVALIDATED | REQUIRED | SATISFIED | fulfil selected then action-relevant precondition lost -> Invalidated; favour remains; no +/- called-favour effect | [E14](#e14); [E47](#e47); [E49](#e49) |
| S1-094-SUCCESS | REQUIRED | SATISFIED | requested action commit consumes favour and applies +10 exactly then | [E12](#e12) |
| S1-094-NESTED-GUARD | REQUIRED | SATISFIED | no accepted callable payload opens another ResponseDecisionContext | [E12](#e12) |
| S1-094-RECIP-CANCEL | REQUIRED | SATISFIED | reciprocal outstanding favours may cancel atomically | [E15](#e15); [E46](#e46) |
| S1-095-POS | REQUIRED | SATISFIED | mutual strong-like direct marriage positive route | [E17](#e17) |
| S1-095-74 | REQUIRED | SATISFIED | one direction +74 blocks bypass | [E17](#e17) |
| S1-095-KIN | REQUIRED | SATISFIED | parent/child or siblings never marry | [E17](#e17) |
| S1-095-LIFETIME | REQUIRED | SATISFIED | established v0 marriage blocks second establishment; rejection does not consume eligibility | [E18](#e18) |
| S1-095-NO-RESIDENCE | REQUIRED | SATISFIED | direct marriage alone does not move residence | [E17](#e17) |
| S1-096-MOVE | REQUIRED | SATISFIED | accepted move proposal changes only Residence relation as specified | [E19](#e19) |
| S1-096-INVITE | REQUIRED | SATISFIED | accepted invite route | [E19](#e19) |
| S1-096-COMPETE | REQUIRED | SATISFIED | two independently accepted same-person Residence changes -> exactly one commit + explicit invalidation | [E19](#e19) |
| S1-096-NO-HH | REQUIRED | SATISFIED | residence change alone creates/removes no household participation/identity | [E19](#e19) |
| S1-096-MARRIAGE-CONTROL | REQUIRED | SATISFIED | marriage alone does not move residence | [E17](#e17) |
| S1-097-EVENTS | REQUIRED | SATISFIED | every fixed v0 event update independently exercised | [E36](#e36); [E40](#e40); [E41](#e41); Independent R2: 27 refusal combinations and four mixed-cause runs. |
| S1-097-SAT | REQUIRED | SATISFIED | single direct update saturates at +/-100 | [E28](#e28) |
| S1-097-DIRECT-BATCH-POS | REQUIRED | SATISFIED | +95 with +10 and -20 -> one sum-then-clamp result +85; both causes retained | [E28](#e28) |
| S1-097-DIRECT-BATCH-NEG | REQUIRED | SATISFIED | equivalent mixed-sign negative-bound case | [E28](#e28) |
| S1-097-DECAY | REQUIRED | SATISFIED | before/at/after 5-cycle decay; no zero crossing | [E57](#e57) |
| S1-098-CORE | REQUIRED | SATISFIED | one personal voluntary initiative; responses do not consume/grant; multiple responses allowed | [E03](#e03) |
| S1-098-CALLFAVOR-INIT | REQUIRED | SATISFIED | voluntary CallFavor initiation consumes holder's normal personal initiative | [E12](#e12) |
| S1-098-COMMUNICATION | DEFERRED | DEFERRED | Communication-specific initiative example | Frozen rationale retained: General communication/claim propagation explicitly outside IMP-0001 |
| S1-099-KIN | REQUIRED | SATISFIED | exact 1.5x kin attitude-component amplification; stored attitude/gates unchanged | [E23](#e23); [E24](#e24) |
| S1-099-CORES | REQUIRED | SATISFIED | marriage co-residence incentive > strong mutual positive incentive; no forced move | [E25](#e25); [E52](#e52) |
| S1-100 | REQUIRED | SATISFIED | VS-SFL-100; feasible Accept vs Decline is target policy | [E02](#e02) |
| S1-101 | REQUIRED | SATISFIED | VS-SFL-101; infeasibility precedes Accept preference | [E02](#e02) |
| S1-102 | REQUIRED | SATISFIED | VS-SFL-102; called-favour fulfil/refusal + invalid payload + Unable/Invalidated controls | [E12](#e12) |
| S1-103-GRAIN | REQUIRED | SATISFIED | VS-SFL-103; two accepted scarce-grain responses, one commit/one invalidation | [E03](#e03) |
| S1-103-RESIDENCE | REQUIRED | SATISFIED | VS-SFL-103 companion; two accepted same-person Residence contenders | [E19](#e19) |
| S1-104 | DEFERRED | DEFERRED | VS-SFL-104; role-scoped household-mediated response | Frozen rationale retained: Requires Active Household/head/mediated-marriage substrate outside Slice 1 |
| S1-105 | REQUIRED | SATISFIED | VS-SFL-105; personal initiative plus incoming response | [E26](#e26) |
| S1-070 | REQUIRED | SATISFIED | VS-SFL-070; Declined vs Unable paired contrast + participant knowledge | [E02](#e02) |
| S1-071 | REQUIRED | SATISFIED | VS-SFL-071; accepted then invalidated at central resolution | [E03](#e03) |
| S1-072 | DEFERRED | DEFERRED | VS-SFL-072; household provision priority | Frozen rationale retained: Household provision outside Slice 1 |
| S1-073 | REQUIRED | SATISFIED | VS-SFL-073; bounded failure reason/no private-state leak | [E02](#e02) |
| S1-074-IDEMP | REQUIRED | SATISFIED | VS-SFL-074; same automatic cause contributes exactly once | [E29](#e29) |
| S1-074-DIRECT-BATCH | REQUIRED | SATISFIED | VS-SFL-074 companion; mixed direct attitude causes batch once / order-independent | [E28](#e28) |
| S1-075 | DEFERRED | DEFERRED | VS-SFL-075; household formation reaction chain | Frozen rationale retained: Card as written requires formation/recognition/Household substrate |
| S1-076 | DEFERRED | DEFERRED | VS-SFL-076; communication provenance regression | Frozen rationale retained: General communication/recognition propagation outside Slice 1 |
| S1-080 | REQUIRED | UNSATISFIED | VS-SFL-080; MaterialDeadlock diagnosed, no rescue grain | [E30](#e30); **B1; R4-NET-ZERO-FUTURE-INPUT-DEADLOCK** |
| S1-081 | REQUIRED | UNSATISFIED | VS-SFL-081; stable-ID fallback quarantined/disclosed, including Residence conflict exercise | [E31](#e31); [E38](#e38); [E39](#e39); [E43](#e43); [E44](#e44); [E45](#e45); [E46](#e46); [E47](#e47); [E48](#e48); [E49](#e49); [E50](#e50); **B2; R1-DEBT-BOTTLENECK-COMMUTING-FARM** |
| S1-082 | DEFERRED | DEFERRED | VS-SFL-082; checkpoint exact suffix | Frozen rationale retained: Checkpoint/save-load explicitly outside Slice 1 |
| S1-083 | DEFERRED | DEFERRED | VS-SFL-083; omitted checkpoint state detected | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-084 | REQUIRED | SATISFIED | VS-SFL-084; derived rebuild equivalence / stale-cache authority | [E34](#e34) |
| S1-085 | REQUIRED | SATISFIED | VS-SFL-085; observer/diagnostic noninterference | [E32](#e32); [E55](#e55); Independent R5 immutable reader variations. |
| S1-086 | REQUIRED | SATISFIED | VS-SFL-086; decision trace completeness for personal/response contexts | [E23](#e23); [E24](#e24); [E42](#e42); [E51](#e51); [E52](#e52); [E53](#e53); [E54](#e54); [E55](#e55); Independent R3: 48 hidden-fact/binding variations; personal-input source audit. |
| S1-087 | DEFERRED | DEFERRED | VS-SFL-087; rendered causal explanation surface | Frozen rationale retained: No rendered explanation surface required in Slice 1; causal predecessor truth remains required through history/086 |
| S1-BND-ATT-STRONGLIKE | REQUIRED | SATISFIED | +74/+75/+76 | [E17](#e17); [E09](#e09) |
| S1-BND-ATT-STRONGDISLIKE | N-A | N-A | -76/-75/-74 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-DISLIKE-NEUTRAL | N-A | N-A | -27/-26/-25 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-NEUTRAL-LIKE | N-A | N-A | +25/+26/+27 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-SAT | REQUIRED | SATISFIED | beyond +/-100 | [E28](#e28) |
| S1-BND-ATT-MIXED | REQUIRED | SATISFIED | mixed-sign direct causes near both bounds | [E28](#e28) |
| S1-D4-GRAIN-GIFT-OFFER | REQUIRED | SATISFIED | OfferGift grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E04](#e04) |
| S1-D4-GRAIN-GIFT-REQUEST | REQUIRED | SATISFIED | RequestGiftOrHelp grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E04](#e04) |
| S1-D4-GRAIN-LOAN-OFFER | REQUIRED | SATISFIED | OfferLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E08](#e08) |
| S1-D4-GRAIN-LOAN-REQUEST | REQUIRED | SATISFIED | RequestLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E08](#e08) |
| S1-D4-GRAIN-REPAY-DIRECT | REQUIRED | SATISFIED | direct RepayDebt amount: D4-invalid terms rejected before feasibility/commit; positive integer reaches repayment-specific gates | [E06](#e06) |
| S1-D4-GRAIN-BFF-BENEFIT | REQUIRED | SATISFIED | required Slice-1 BFF grain-transfer instantiation: every grain quantity in/referenced by the specified material-benefit term obeys D4 before target response; raw scalar amount field not required | [E16](#e16) |
| S1-D4-GRAIN-RMRH-BENEFIT | REQUIRED | SATISFIED | required Slice-1 RMRH grain-transfer instantiation: every grain quantity in/referenced by the help/material-benefit term obeys D4 before target response; raw scalar amount field not required | [E16](#e16) |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | REQUIRED | SATISFIED | ProposeMarriage proposed-dowry term on direct-bypass proposal shape: invalid grain term rejected before bride response; positive integer may proceed; no dowry transfer on bypass | [E20](#e20) |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | REQUIRED | SATISFIED | CallFavor(RepayDebt(...)) inner amount: zero/negative/non-integral/over-remaining rejects outer call before Fulfil/Refuse response; valid term may proceed | [E22](#e22) |
| S1-BND-REPAY-AMOUNT | REQUIRED | SATISFIED | remaining-1 / remaining / remaining+1 (where remaining>1), evidenced for direct and nested called-favour repayment ingresses | [E22](#e22); [E06](#e06) |
| S1-BND-RESERVE | REQUIRED | SATISFIED | RepayDebt debtor resulting grain 1 / 2 / 3 | [E06](#e06) |
| S1-BND-NEED | REQUIRED | SATISFIED | NeedsGrain clearing grain 0 / 1 | [E01](#e01) |
| S1-BND-DECAY | REQUIRED | SATISFIED | immediately before / at / after 5-cycle cadence | [E57](#e57) |
| S1-BND-DEBT-DUE | REQUIRED | SATISFIED | before N+3 / after N+3 decisions / later | [E07](#e07) |
| S1-BND-MARRIAGE-CARD | REQUIRED | SATISFIED | first establishment / second after establishment | [E18](#e18) |
| S1-BND-FAVOUR-CARD | REQUIRED | SATISFIED | first favour / additional same ordered pair | [E10](#e10) |
| S1-BND-FAVOUR-MEANING | REQUIRED | SATISFIED | full pair slot: ExplicitBenefitForFavor vs RMRH | [E10](#e10) |
| S1-BND-RESIDENCE-CARD | REQUIRED | SATISFIED | one vs multiple accepted same-person Residence changes | [E19](#e19) |
| S1-BND-HOUSEHOLD-PROVISION | DEFERRED | DEFERRED | household-provision contributor reserve / NeedsGrain contributor / collective capacity boundaries | Frozen rationale retained: Household provision outside Slice 1 |
| S1-BND-PROVISION-RECONSIDERATION | DEFERRED | DEFERRED | before 3 full cycles / exactly 3 with no relevant context change / exactly 3 plus relevant context change | Frozen rationale retained: Household provision/head reconsideration outside Slice 1 |
| S1-BND-FORMATION | DEFERRED | DEFERRED | formation/participation/lifecycle boundaries | Frozen rationale retained: Household formation outside Slice 1 |
| S1-BND-LINEAGE | DEFERRED | DEFERRED | lineage freshness / predecessor lifecycle-state (one survives vs both Dissolved) / predecessor-source ambiguity boundaries | Frozen rationale retained: Lineage outside Slice 1 |
| S1-META-01 | REQUIRED | SATISFIED | storage/input iteration permutation | [E32](#e32) |
| S1-META-02 | REQUIRED | SATISFIED | nonsemantic ID renaming | [E33](#e33); [E38](#e38); [E39](#e39); [E43](#e43); [E44](#e44); [E45](#e45); [E46](#e46); [E47](#e47); [E48](#e48); [E49](#e49); [E50](#e50); Independent R5 participant/dwelling/relation mapping; R1 separately changes proposal IDs. |
| S1-META-03 | REQUIRED | SATISFIED | disconnected-population locality | [E33](#e33) |
| S1-META-04 | REQUIRED | SATISFIED | observer/diagnostic noninterference | [E32](#e32) |
| S1-META-05 | REQUIRED | SATISFIED | derived rebuild equivalence | [E34](#e34) |
| S1-META-06 | DEFERRED | DEFERRED | checkpoint metamorphism | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-META-07 | REQUIRED | SATISFIED | irrelevant-attribute perturbation | [E32](#e32); [E42](#e42); [E51](#e51); [E52](#e52); [E53](#e53); [E54](#e54); Independent R3 private-world interventions. |
| S1-META-08 | DEFERRED | DEFERRED | message-arrival permutation | Frozen rationale retained: Communication/recognition outside Slice 1 |
| S1-META-09 | DEFERRED | DEFERRED | lineage predecessor-set ordering | Frozen rationale retained: Lineage outside Slice 1 |
| S1-META-10 | REQUIRED | SATISFIED | direct-attitude cause permutation | [E28](#e28) |
| S1-META-11 | REQUIRED | SATISFIED | Residence contender permutation | [E19](#e19) |
| S1-MUT-01 | DEFERRED | DEFERRED | form H from co-residence alone | Frozen rationale retained: Household formation absent |
| S1-MUT-02 | DEFERRED | DEFERRED | form H from insufficient/same-cycle support | Frozen rationale retained: Household formation absent |
| S1-MUT-03 | DEFERRED | DEFERRED | global household/head recognition | Frozen rationale retained: Household recognition absent |
| S1-MUT-04 | REQUIRED | SATISFIED | kinship multiplier satisfies stored-attitude gate | [E09](#e09) |
| S1-MUT-05 | DEFERRED | DEFERRED | identity by overlap/similarity | Frozen rationale retained: Household continuity absent |
| S1-MUT-06 | DEFERRED | DEFERRED | Inactive/Dissolved H emits household action | Frozen rationale retained: Household action absent |
| S1-MUT-07 | DEFERRED | DEFERRED | participation entry without acceptance/warrant | Frozen rationale retained: Participation absent |
| S1-MUT-08 | DEFERRED | DEFERRED | household self-feedback clone | Frozen rationale retained: Formation absent |
| S1-MUT-09 | DEFERRED | DEFERRED | inherit causal state through lineage | Frozen rationale retained: Lineage absent |
| S1-MUT-10 | DEFERRED | DEFERRED | count household support as fresh lineage evidence | Frozen rationale retained: Lineage absent |
| S1-MUT-11 | DEFERRED | DEFERRED | household expenditure without backing | Frozen rationale retained: Provision absent |
| S1-MUT-12 | DEFERRED | DEFERRED | pool/duplicate provision grain or double-debit contributor | Frozen rationale retained: Household provision absent |
| S1-MUT-13A | REQUIRED | SATISFIED | RepayDebt commits while leaving debtor below the accepted §3.3 two-grain floor | [E06](#e06) |
| S1-MUT-13B | DEFERRED | DEFERRED | household provision penetrates contributor protected reserve or draws from a NeedsGrain contributor | Frozen rationale retained: Household provision absent |
| S1-MUT-14 | DEFERRED | DEFERRED | head commands out-of-scope personal action | Frozen rationale retained: Head role absent |
| S1-MUT-15 | DEFERRED | DEFERRED | majority instead of unanimous head appointment | Frozen rationale retained: Head appointment absent |
| S1-MUT-16 | REQUIRED | SATISFIED | skip commit-time revalidation | [E03](#e03); [E37](#e37) |
| S1-MUT-17 | REQUIRED | SATISFIED | collapse Declined/Unable/Invalidated | [E02](#e02); [E03](#e03) |
| S1-MUT-18 | REQUIRED | SATISFIED | penalize Unable/Invalidated as voluntary refusal | [E02](#e02); [E40](#e40); [E14](#e14) |
| S1-MUT-19 | REQUIRED | SATISFIED | leak exact/unrelated private state in failure reason | [E02](#e02) |
| S1-MUT-20 | REQUIRED | SATISFIED | same-cycle retry after invalidation | [E03](#e03) |
| S1-MUT-21 | REQUIRED | SATISFIED | resolve scarce capacity by collection order | [E03](#e03); [E37](#e37) |
| S1-MUT-22 | REQUIRED | SATISFIED | fire same reaction cause twice | [E29](#e29) |
| S1-MUT-23 | REQUIRED | SATISFIED | truncate reaction closure and report success | [E29](#e29) |
| S1-MUT-24 | REQUIRED | SATISFIED | stale derived cache influences behavior | [E34](#e34) |
| S1-MUT-25 | DEFERRED | DEFERRED | omit future-influencing checkpoint state | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-MUT-26 | REQUIRED | SATISFIED | instrumentation mutates semantics | [E32](#e32) |
| S1-MUT-27 | DEFERRED | DEFERRED | later-arriving older message overwrites newer event evidence | Frozen rationale retained: Communication/recognition absent |
| S1-MUT-28 | DEFERRED | DEFERRED | Contested recognition resolved by arbitrary ID | Frozen rationale retained: Recognition absent |
| S1-MUT-29 | REQUIRED | SATISFIED | record only chosen action instead of full decision trace | [E24](#e24) |
| S1-MUT-30 | DEFERRED | DEFERRED | rendered explanation cites unsupported cause | Frozen rationale retained: Rendered explanation surface outside Slice 1 |
| S1-MUT-31 | REQUIRED | SATISFIED | clamp independent direct attitude causes contribution-by-contribution | [E28](#e28) |
| S1-MUT-32 | REQUIRED | SATISFIED | multiple same-person Residence commits or container-order winner | [E19](#e19) |
| S1-MUT-33 | REQUIRED | SATISFIED | invalid grain term reaches response/effects or over-repayment is clamped | [E22](#e22) |
| S1-MUT-34 | REQUIRED | SATISFIED | called favour opens nested response, consumes favour on Unable/Invalidated, or fires +/- effect on non-voluntary failure | [E14](#e14); [E21](#e21); [E12](#e12) |
| S1-MUT-35 | REQUIRED | SATISFIED | ExplicitBenefitForFavor partially commits when favour capacity unavailable / relabels as Gift/Help | [E10](#e10); [E11](#e11) |
| S1-SUP-GENERATED | UNEXERCISED | UNEXERCISED | bounded generated histories | Frozen rationale retained: Useful later for interaction breadth; B2 explicitly keeps generated-history infrastructure off the Slice-1 completion path |
| S1-SUP-SHRINK | UNEXERCISED | UNEXERCISED | generated-failure shrinking/minimization | Frozen rationale retained: Only relevant once generated histories are in use |
| S1-SUP-HELDOUT | UNEXERCISED | UNEXERCISED | concrete held-out variant materialization | Frozen rationale retained: Canonical/metamorphic/boundary evidence is sufficient for Slice 1; held-out materialization may occur after implementation path exists |
| S1-GLOBAL-FIXTURE | REQUIRED | SATISFIED | fixture write-set audit for every executable canonical subcase | GA; all 344 audited world instances and source write-set inspection. |
| S1-GLOBAL-KNOWLEDGE | REQUIRED | SATISFIED | direct-participant knowledge of Declined/Unable/Invalidated and bounded reasons where accepted semantics require it | [E02](#e02) |
| S1-GLOBAL-ORACLE | REQUIRED | SATISFIED | independent-oracle restrictions are obeyed for every row using an independent checker | GA; independent checker/scenario dependency audit, including omitted mandatory cause challenges. |
| S1-GLOBAL-FALLBACK | REQUIRED | UNSATISFIED | stable-ID fallback use is logged and sensitivity is confined to explicit fallback cases | [E27](#e27); [E31](#e31); [E38](#e38); [E39](#e39); [E43](#e43); [E44](#e44); [E48](#e48); [E50](#e50); [E47](#e47); **B2; R1-DEBT-BOTTLENECK-COMMUTING-FARM** |
| S1-GLOBAL-ITERATION | REQUIRED | SATISFIED | nonsemantic collection/input iteration does not determine semantic outcome | [E32](#e32); Independent R5 fixed-ID storage/input and observer variants. |
| S1-GLOBAL-CALLFAVOR-MAP | REQUIRED | SATISFIED | executable payload validation matches the frozen Slice-1 CallFavor action applicability table | [E21](#e21); [E14](#e14); [E12](#e12) |
| S1-GLOBAL-REQUIRED-COVERAGE | REQUIRED | SATISFIED | zero REQUIRED manifest rows are missing or skipped | GA; enumeration only: all 128 required rows present, none skipped; semantic failures remain visible. |
| S1-GLOBAL-MANIFEST-INTEGRITY | REQUIRED | SATISFIED | manifest bytes/version match the frozen dispatch baseline | GA; start/finish exact Git blob, version and independent census. |
| S1-GLOBAL-CONFORMANCE | REQUIRED | UNSATISFIED | fresh independent conformance review passes | **This review: BLOCK from B1 and B2** |

The ledger contains **167 distinct rows**: **124 SATISFIED + 4 UNSATISFIED** within the unchanged **128 REQUIRED**, plus **33 DEFERRED / 3 N-A / 3 UNEXERCISED**. No missing/skipped obligation is concealed by a bundle-level result. `S1-GLOBAL-CONFORMANCE` has been adjudicated only here and is not awarded.

## 8. Final boundary and return

**BLOCK for candidate-v2 at `ba16829e240950f1f3c648107cf3b8b36f996971`.** The candidate cannot be declared VERIFIED COMPLETE under the frozen completion rule. B1 independently defeats material-deadlock conformance; B2 defeats precision of the history's fallback disclosure. The passing F2/F3 controls and broad D1–D5 evidence do not cancel those requirements.

Execution-start and execution-finish checks found no candidate or authority drift. The return branch derives from current `origin/main`, not from the implementation branch, and its sole tracked addition is `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`. The candidate checkout remains detached and clean. PR #16 and PR #7 remain draft/unmerged. This report authorizes no candidate repair, semantic amendment, merge or promotion.

## Appendix A. Retained evidence and reproduction commands

Local evidence is retained under the review task's `work/evidence/`: start/finish identity JSON, SDK info, all four command logs/results, downloaded CI ZIP and six extracted files, deep/newline comparison, independent ledger seed/case index, reviewer probe stdout and detailed JSON. These local scratch files are not additions to the return branch. The decisive probe source, results and evidence hashes are included below so the report does not rely on uncommitted scratch files for its counterexamples.

| Retained artifact | SHA-256 |
| --- | --- |
| evidence/start-identity.json | `7a1ac8faeca13d392ccc73e934c45ad90d32b20ce85cc2e4290f5ff1d04615a0` |
| evidence/finish-identity.json | `84c606bd37a150f407de775a038a308c96200f7d56c3a91d6143ac2ee1b67034` |
| evidence/sdk-info.txt | `1c5c915faca4c55adcf89043f3db9432af040d3019d0ddfbacd9d098dac32a3a` |
| evidence/restore.log | `72ce25190714eb7133aa5d4ad9f65c1219534bf1d911b7d1f63aaaf33e2630b0` |
| evidence/format.log | `e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855` |
| evidence/build.log | `8a612d9e785492e4df2331ce7bd3119f6ce99f37fa114dbad59f1f3adf0ef07c` |
| evidence/test.log | `81d63adefebbf5ba2f00cac58bc40637e9946e48dd48a71623ae6585df94cb52` |
| evidence/canonical-results.json | `37d49a6d74ba2d7e8a3e2954701c874a46893bac9538ff3b68c0630a0838d0d3` |
| evidence/ci-comparison.json | `71c58bf88dcc0f5347ddfff322b694a8c75005a9e00e6d017407e5868985fd50` |
| probes/Program.cs | `5e3029e43bbb5f6278f860445ff6890c5085b2badc44c56f1d4cc328b50cd42c` |
| probes/ReviewerProbes.csproj | `1e198b034831f896899c5584e7535d0fee2a9b5b0df4a586c451f86dd37d9205` |
| evidence/reviewer-probes.json | `9f3d6f085b2af86d367d9828a3b9c85716f480b12b65dc222c7721c89ca6df4e` |
| evidence/reviewer-probes.log | `5e8c3a52f3ff9200378f5cac65cc3768917a42ae6710f10ec71fff0e17e3d2ee` |

Canonical commands (exact detached candidate, SDK 10.0.401):

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

For the reviewer console, place the project/source below in a sibling `probes` directory beside `candidate-v2`, after building the exact candidate. Its DLL HintPath refers to that build and does not compile or modify candidate source. Run from `probes` with the same SDK:

```text
dotnet run --project ReviewerProbes.csproj --configuration Release
```

Read the emitted PASS/FAIL entries and `../evidence/reviewer-probes.json`; the console's deliberate per-case exception capture retains all controls and returns normally even when an assertion records FAIL.

## Appendix B. Complete reviewer-owned probe source

### ReviewerProbes.csproj

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Mesopotamia.Sim">
      <HintPath>../candidate-v2/src/Mesopotamia.Sim/bin/Release/net10.0/Mesopotamia.Sim.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

### Program.cs

```csharp
using System.Collections.Immutable;
using System.Text.Json;
using Mesopotamia.Sim;

static class Review
{
    static readonly List<object> Results = [];
    static PersonId P(int n) => new(n);
    static Proposal Q(long id, int actor, ActionTerms terms) => new(new(id), P(actor), terms);
    static InitialWorld World(long[] grain, (int from, int to, int value)[]? attitudes = null) => new(
        [.. grain.Select((g,i) => new Person(P(i+1), $"P{i+1}", i % 2 == 0 ? Sex.Male : Sex.Female, g))],
        [.. grain.Select((g,i) => new Dwelling(new(i+1)))],
        [.. grain.Select((g,i) => new Residence(new(i+1), P(i+1), new(i+1)))],
        [.. (attitudes ?? []).Select((a,i) => new Attitude(new(100+i), P(a.from), P(a.to), a.value))], [], [], [], new("K4-REVIEW-PROBES-v1"));
    static long Grain(WorldSnapshot s,int p) => s.People[P(p)].Grain;
    static int Att(WorldSnapshot s,int from,int to) => s.Attitudes.Values.SingleOrDefault(a => a.From==P(from)&&a.To==P(to))?.Value ?? 0;
    static long Home(WorldSnapshot s,int p) => s.Residences.Values.Single(r=>r.Person==P(p)).Dwelling.Value;
    static bool Flag(CycleResult r, int actor) => r.Events.Single(e=>e.Id==r.Outcomes.Single(o=>o.Actor==P(actor)).Event).TechnicalFallback;
    static void Check(bool condition,string message) { if(!condition) throw new Exception(message); }
    static void Case(string id,Func<object> body)
    {
        try { Results.Add(new { Id=id, Status="PASS", Observation=body() }); }
        catch(Exception e) { Results.Add(new { Id=id, Status="FAIL", Error=e.ToString() }); }
    }
    static IEnumerable<int[]> Permute(int[] source)
    {
        if(source.Length==0) { yield return []; yield break; }
        for(int i=0;i<source.Length;i++) foreach(var rest in Permute([.. source.Where((_,j)=>i!=j)])) yield return [source[i],..rest];
    }
    static object OutcomeView(CycleResult r) => r.Outcomes.OrderBy(o=>o.Actor.Value).Select(o=>new { Actor=o.Actor.Value,Proposal=o.Proposal.Value,Kind=o.Kind.ToString(),o.Reason,Fallback=r.Events.Single(e=>e.Id==o.Event).TechnicalFallback }).ToArray();
    static DecisionTrace Personal(Simulation s, PersonalPolicy p) => s.RunCycle(new([]) { PersonalPolicies=ImmutableDictionary<PersonId,PersonalPolicy>.Empty.Add(P(1),p) }).Decisions.Single(d=>d.Context=="Personal");
    static string Trace(DecisionTrace t) => JsonSerializer.Serialize(new { t.Profile,t.TechnicalFallback,t.SubjectiveInputs,Candidates=t.Candidates.Select(c=>new { c.Key,c.Meaning,c.Eligible,c.Gate,c.FinalScore,c.Selected,Components=c.Components.OrderBy(k=>k.Key),Terms=c.Terms?.ToString() }) });

    public static void Main()
    {
        Case("R1-AGGREGATE-GRAIN-CREDIT-ALL-PERMUTATIONS",()=>
        {
            var runs=new List<object>();
            foreach(string kind in new[]{"gift","loan","reciprocal"})
            foreach(int[] order in Permute([0,1,2,3]))
            {
                Simulation s=new(World([0,3,0,0,20]));
                (int actor,ActionTerms terms)[] ops=[(1,new RequestGiftOrHelp(P(2),1)),(3,new RequestLoan(P(2),1)),(4,new RelationshipMediatedReciprocalHelp(P(2),1,true)),(5,kind switch { "gift"=>new OfferGift(P(2),2),"loan"=>new OfferLoan(P(2),2),_=>new RelationshipMediatedReciprocalHelp(P(2),2) })];
                var proposals=order.Select((i,n)=>Q(100+n,ops[i].actor,ops[i].terms)).Reverse().ToImmutableArray();
                var r=s.RunCycle(new(proposals));
                int creditRank=Array.IndexOf(order,3);
                int expected=creditRank==3?3:4;
                Check(r.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==expected,"Credit ordering result mismatch.");
                Check(r.Outcomes.All(o=>Flag(r,(int)o.Actor.Value)),"Undisclosed aggregate/credit dependency.");
                Check(Grain(r.State,2)==(expected==4?1:2),"Donor ledger mismatch.");
                Check(r.State.People.Values.Sum(p=>p.Grain)==23-2,"Material sum must equal initial 23 minus consumption 2.");
                runs.Add(new {kind,order,Outcomes=OutcomeView(r)});
            }
            return new {Runs=runs.Count,Details=runs};
        });
        Case("R1-DEBT-BOTTLENECK-COMMUTING-FARM",()=>
        {
            var runs=new List<object>(); int falseMarkers=0;
            foreach(int[] order in Permute([1,2,3,4]))
            {
                Simulation s=new(World([20,0,20,20,20]));
                s.RunCycle(new([Q(1,1,new OfferBenefitForFavor(P(2),1)),Q(2,3,new OfferBenefitForFavor(P(2),1)),Q(3,4,new OfferBenefitForFavor(P(2),1)),Q(4,5,new OfferLoan(P(2),5))]));
                s.RunCycle(CycleInput.Empty);
                RelationId debt=s.Snapshot.Debts.Values.Single().Id;
                var proposals=order.Select((a,i)=>Q(100+i,a,a==2?new Farm():new CallFavor(s.Snapshot.Favours.Values.Single(f=>f.Holder==P(a)).Id,new RepayDebt(debt,2)))).ToImmutableArray();
                var r=s.RunCycle(new(proposals));
                int lastCaller=order.Last(a=>a!=2);
                Check(r.Outcomes.Single(o=>o.Actor==P(lastCaller)).Kind==OutcomeKind.InvalidatedAtResolution,"Last caller should exceed debt remaining.");
                Check(r.Outcomes.Single(o=>o.Actor==P(lastCaller)).Reason=="RepaymentExceedsRemaining","Wrong bottleneck.");
                Check(r.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==3,"Two repayments and Farm must commit.");
                Check(Grain(r.State,2)==6&&r.State.Debts[debt].Remaining==1,"Debt/Farm final state mismatch.");
                Check(order.Where(a=>a!=2).All(a=>Flag(r,a)),"Debt competition must be marked.");
                if(Flag(r,2)) falseMarkers++;
                runs.Add(new {order,Outcomes=OutcomeView(r),DebtorGrain=Grain(r.State,2),Remaining=r.State.Debts[debt].Remaining});
            }
            // Retain the observation even when the independently expected non-fallback check fails.
            Results.Add(new { Id="R1-DEBT-BOTTLENECK-OBSERVATION",Status="OBSERVATION",FalseFarmMarkers=falseMarkers,Runs=runs });
            Check(falseMarkers==0,"Farm was marked as a technical fallback despite commuting with every feasible debt-resolution ordering.");
            return new {Runs=runs.Count};
        });
        Case("R1-RESIDENCE-THREE-CYCLE",()=>
        {
            var runs=new List<object>();
            foreach(int[] order in Permute([1,2,3]))
            {
                Simulation s=new(World([10,10,10]));
                var r=s.RunCycle(new([.. order.Select((a,i)=>Q(100+i,a,new MoveResidence(P(a%3+1),new(a%3+1))))]));
                var homes=new Dictionary<int,long>{{1,1},{2,2},{3,3}};
                foreach(int actor in order)
                {
                    int target=actor%3+1; bool feasible=homes[target]==target&&homes[actor]!=target;
                    Check(r.Outcomes.Single(o=>o.Actor==P(actor)).Kind==(feasible?OutcomeKind.Committed:OutcomeKind.InvalidatedAtResolution),"Residence revalidation differed from independent state replay.");
                    if(feasible) homes[actor]=target;
                    Check(Flag(r,actor),"Unmarked residence dependency.");
                }
                Check(homes.All(h=>Home(r.State,h.Key)==h.Value),"Residence final replay mismatch.");
                runs.Add(new {order,Outcomes=OutcomeView(r)});
            }
            return runs;
        });
        Case("R2-REQUEST-REFUSAL-CONTROLS",()=>
        {
            var runs=new List<object>();
            foreach(int shape in new[]{0,1,2}) foreach(long own in new[]{0L,1L,9L}) foreach(long donor in new[]{0L,1L,9L})
            {
                Simulation s=new(World([own,donor,10],[(1,2,75)]));
                ActionTerms terms=shape switch {0=>new RequestGiftOrHelp(P(2),1),1=>new RequestLoan(P(2),1),_=>new RelationshipMediatedReciprocalHelp(P(2),1,true)};
                var r=s.RunCycle(new([Q(1,1,terms)]) {ResponseProfiles=ImmutableDictionary<PersonId,string>.Empty.Add(P(2),"SCORE-RP-002")});
                bool able=donor>=2; int delta=able&&own==0?-5:0;
                Check(r.Outcomes.Single().Kind==(able?OutcomeKind.Declined:OutcomeKind.Unable),"Refusal/Unable distinction.");
                Check(Att(r.State,1,2)==75+delta,"Mandatory refusal cause incorrect.");
                Check(r.Events.SelectMany(e=>e.Contributions).Count()==(delta==0?0:1),"Wrong contribution membership.");
                runs.Add(new {shape,own,donor,ExpectedDelta=delta,Outcomes=OutcomeView(r)});
            }
            return new {Runs=runs.Count,Details=runs};
        });
        Case("R2-THREE-MIXED-CAUSES",()=>
        {
            var runs=new List<object>();
            foreach(int baseline in new[]{-95,95}) foreach(bool reversed in new[]{false,true})
            {
                Simulation s=new(World([30,30,30],[(1,2,baseline)]));
                s.RunCycle(new([Q(1,1,new OfferBenefitForFavor(P(2),1)),Q(2,2,new RequestLoan(P(1),2))]));
                s.RunCycle(CycleInput.Empty);s.RunCycle(CycleInput.Empty);
                var favour=s.Snapshot.Favours.Values.Single();
                var proposals=new[]{Q(reversed?101:100,1,new CallFavor(favour.Id,new Farm())),Q(reversed?100:101,2,new OfferGift(P(1),1))};
                var r=s.RunCycle(new([..proposals]) {ResponseProfiles=ImmutableDictionary<PersonId,string>.Empty.Add(P(2),"SCORE-RP-004")});
                int expected=Math.Clamp(baseline+10-20-10,-100,100);
                Check(Att(r.State,1,2)==expected,"Three signed causes must sum before clamp.");
                var causes=r.Events.SelectMany(e=>e.Contributions).Where(c=>c.Key.From==P(1)&&c.Key.To==P(2)).ToArray();
                Check(causes.Select(c=>c.Delta).Order().SequenceEqual(new[]{-20,-10,10}),"Three-cause membership incomplete.");
                Check(r.Events.Count(e=>e.Kind=="AttitudeComposition"&&e.Participants.SequenceEqual(new[]{P(1),P(2)}))==1,"Direct causes must compose once.");
                runs.Add(new {baseline,reversed,expected,Actual=Att(r.State,1,2),Deltas=causes.Select(c=>c.Delta)});
            }
            return runs;
        });
        Case("R3-IDENTITY-ONLY-HIDDEN-FACT-CROSS-PRODUCT",()=>
        {
            string? reference=null; int count=0;
            foreach(long grain in new[]{0L,1L,20L}) foreach(Sex sex in new[]{Sex.Male,Sex.Female}) foreach(int home in new[]{2,3})
            {
                InitialWorld w=World([0,grain,20]);
                w=w with {People=[..w.People.Select(p=>p.Id==P(2)?p with {Sex=sex}:p)],Residences=[..w.Residences.Select(r=>r.Person==P(2)?r with {Dwelling=new(home)}:r)]};
                Simulation s=new(w); var t=Personal(s,new(){ObservedPeople=[P(2)]});
                string actual=Trace(t); reference??=actual; Check(actual==reference,"Unobserved target fact changed personal trace.");
                Check(t.Candidates.Single(c=>c.Selected).Terms is RequestGiftOrHelp,"Needy personal request missing.");
                Check(t.Candidates.All(c=>c.Terms is not ProposeMarriage and not MoveResidence),"Identity alone exposed sex or residence.");
                var terminal=s.History.Last(e=>e.Kind is "Unable" or "Help");
                Check(terminal.Kind==(grain>=2?"Help":"Unable"),"Later objective feasibility incorrect.");count++;
            }
            return new {Runs=count,IdenticalPersonalTrace=reference};
        });
        Case("R3-PARTIAL-OBSERVATION-ISOLATION",()=>
        {
            var runs=new List<object>();
            foreach(bool suppliedSex in new[]{false,true}) foreach(bool suppliedHome in new[]{false,true})
            {
                string? reference=null;
                foreach(long grain in new[]{0L,20L}) foreach(Sex sex in new[]{Sex.Male,Sex.Female}) foreach(int home in new[]{2,3})
                {
                    InitialWorld w=World([20,grain,20],[(1,2,80),(2,1,80)]);
                    w=w with {People=[..w.People.Select(p=>p.Id==P(2)?p with{Sex=sex}:p)],Residences=[..w.Residences.Select(r=>r.Person==P(2)?r with{Dwelling=new(home)}:r)]};
                    PersonalPolicy policy=new("SCORE-VP-006"){ObservedPeople=[P(2)],ObservedSexes=suppliedSex?ImmutableDictionary<PersonId,Sex>.Empty.Add(P(2),Sex.Female):ImmutableDictionary<PersonId,Sex>.Empty,ObservedResidences=suppliedHome?ImmutableDictionary<PersonId,DwellingId>.Empty.Add(P(2),new(2)):ImmutableDictionary<PersonId,DwellingId>.Empty};
                    var t=Personal(new(w),policy); string actual=Trace(t);reference??=actual;Check(actual==reference,"Supplied observation leaked an unbound world fact.");
                    Check(t.Candidates.Any(c=>c.Terms is ProposeMarriage)==suppliedSex,"Sex binding scope mismatch.");
                    Check(t.Candidates.Any(c=>c.Terms is MoveResidence)==suppliedHome,"Residence binding scope mismatch.");
                    runs.Add(new{suppliedSex,suppliedHome,grain,sex,home});
                }
            }
            return new{Runs=runs.Count,Details=runs};
        });
        Case("R3-UNBOUND-DEBT-ISOLATION",()=>
        {
            var traces=new List<object>();
            foreach(bool observe in new[]{false,true})
            {
                string? reference=null;
                foreach(long privateAmount in new[]{1L,7L})
                {
                    Simulation s=new(World([20,20,20,20]));
                    s.RunCycle(new([Q(1,1,new OfferBenefitForFavor(P(2),1)),Q(2,3,new OfferLoan(P(2),2)),Q(3,4,new OfferLoan(P(2),privateAmount))]));
                    Debt visible=s.Snapshot.Debts.Values.Single(d=>d.Creditor==P(3));
                    Debt hidden=s.Snapshot.Debts.Values.Single(d=>d.Creditor==P(4));
                    var t=Personal(s,new("SCORE-VP-005"){ObservedPeople=[P(2)],ObservedDebts=observe?[visible.Id]:[]});
                    string actual=Trace(t);reference??=actual;Check(actual==reference,"Unbound debt changed personal deliberation.");
                    Check(t.Candidates.Count(c=>c.Terms is CallFavor {Requested:RepayDebt})==(observe?1:0),"Debt binding was broadened.");
                    Check(!t.SubjectiveInputs.Any(i=>i.StartsWith($"Debt:{hidden.Id.Value};",StringComparison.Ordinal)),"Unbound debt disclosed in trace.");
                    traces.Add(new{observe,privateAmount,DebtCandidates=t.Candidates.Count(c=>c.Terms is CallFavor {Requested:RepayDebt})});
                }
            }
            return traces;
        });
        Case("R5-IDENTITY-STORAGE-OBSERVER-ISOMORPHISM",()=>
        {
            string? reference=null; string? exactReference=null;var observations=new List<object>();
            foreach(int variant in new[]{0,1,2,3})
            {
                PersonId Map(int n)=>variant==1?new(n switch{1=>41,2=>11,3=>31,_=>21}):P(n);
                DwellingId Dw(int n)=>variant==1?new(n switch{1=>400,2=>100,3=>300,_=>200}):new(n);
                InitialWorld w=World([20,20,20,20],[(1,2,76),(2,1,76)]);
                w=w with {People=[..w.People.Select(p=>p with{Id=Map((int)p.Id.Value)})],Dwellings=[..w.Dwellings.Select(d=>new Dwelling(Dw((int)d.Id.Value)))],Residences=[..w.Residences.Select(r=>r with{Id=new(variant==1?2000-r.Id.Value:r.Id.Value),Person=Map((int)r.Person.Value),Dwelling=Dw((int)r.Dwelling.Value)})],Attitudes=[..w.Attitudes.Select(a=>a with{Id=new(variant==1?3000-a.Id.Value:a.Id.Value),From=Map((int)a.From.Value),To=Map((int)a.To.Value)})]};
                if(variant==2)w=w with{People=[..w.People.Reverse()],Dwellings=[..w.Dwellings.Reverse()],Residences=[..w.Residences.Reverse()],Attitudes=[..w.Attitudes.Reverse()]};
                Simulation s=new(w);
                CycleResult Run(params Proposal[] ps)
                {
                    if(variant==3){_=s.History;_=s.DecisionHistory;foreach(var p in s.Snapshot.People.Keys.Reverse()){_=s.KnowledgeOf(p);_=s.Snapshot.People[p];}}
                    return s.RunCycle(new([..variant==2?ps.Reverse():ps]));
                }
                Proposal Make(long id,int actor,ActionTerms terms)=>new(new(id),Map(actor),terms);
                Run(Make(1,1,new OfferBenefitForFavor(Map(2),1)),Make(2,3,new OfferLoan(Map(2),2)));
                Debt debt=s.Snapshot.Debts.Values.Single();Favour favour=s.Snapshot.Favours.Values.Single();
                Run(Make(10,1,new CallFavor(favour.Id,new Farm())),Make(20,2,new RepayDebt(debt.Id,1)),Make(30,3,new MoveResidence(Map(4),Dw(4))));
                Run();Run();
                string Name(PersonId p)=>s.Snapshot.People[p].Name;
                int House(DwellingId d)=>Enumerable.Range(1,4).Single(n=>Dw(n)==d);
                string Cause(EventId id){var e=s.History.Single(e=>e.Id==id);return $"{e.Cycle}:{e.Kind}:{e.Proposal?.Value}:{string.Join(',',e.Participants.Select(Name))}";}
                string projection=JsonSerializer.Serialize(new{
                    People=s.Snapshot.People.Values.OrderBy(p=>p.Name).Select(p=>new{p.Name,p.Grain,p.NeedsGrain,Home=House(s.Snapshot.Residences.Values.Single(r=>r.Person==p.Id).Dwelling)}),
                    Attitudes=s.Snapshot.Attitudes.Values.Select(a=>new{From=Name(a.From),To=Name(a.To),a.Value}).OrderBy(a=>a.From).ThenBy(a=>a.To),
                    Debts=s.Snapshot.Debts.Values.Select(d=>new{Creditor=Name(d.Creditor),Debtor=Name(d.Debtor),d.Original,d.Remaining,d.CommittedCycle,d.DueReviewed,Origin=Cause(d.Origin)}),
                    Favours=s.Snapshot.Favours.Values.Select(f=>new{Debtor=Name(f.Debtor),Holder=Name(f.Holder),f.Outstanding,Origin=Cause(f.Origin)}),
                    Events=s.History.Select(e=>JsonSerializer.Serialize(new{e.Cycle,e.Kind,Proposal=e.Proposal?.Value,Participants=e.Participants.Select(Name),Causes=e.Causes.Select(Cause).Order(),Material=e.Material.Select(m=>new{Person=Name(m.Person),m.Before,m.After,m.Meaning}),Contributions=e.Contributions.Select(c=>new{c.Key.Rule,Trigger=Cause(c.Key.Trigger),From=Name(c.Key.From),To=Name(c.Key.To),c.Delta}).OrderBy(c=>c.From).ThenBy(c=>c.To),e.TechnicalFallback})).Order(),
                    Knowledge=s.Snapshot.People.Values.OrderBy(p=>p.Name).Select(p=>new{p.Name,Events=s.KnowledgeOf(p.Id).Select(k=>new{Event=Cause(k.Event),k.Proposal,k.Kind,k.Reason})})});
                Check(s.History.All(e=>!e.TechnicalFallback),"Commuting run over-marked fallback.");
                reference??=projection;Check(reference==projection,"Semantic identity/permutation projection differed.");
                string exact=JsonSerializer.Serialize(s.History);if(variant==0)exactReference=exact;else if(variant!=1)Check(exact==exactReference,"Fixed-ID history changed under storage/observer variant.");
                observations.Add(new{variant,SemanticEquivalent=true,FixedIdExactHistory=variant!=1});
            }
            return observations;
        });
        Case("R4-NET-ZERO-FUTURE-INPUT-DEADLOCK",()=>
        {
            var observations=new List<object>(); bool failed=false;
            foreach(long credit in new[]{1L,2L})
            {
                InitialWorld w=World([0,0,0]) with {Inputs=[new(1,2,P(1),credit),new(2,2,P(1),-1)]};
                Simulation s=new(w);var first=s.RunCycle(CycleInput.Empty);var second=s.RunCycle(CycleInput.Empty);
                bool expectedFirst=credit==1;
                observations.Add(new{credit,ExpectedCycle1Deadlock=expectedFirst,ActualCycle1Deadlock=first.MaterialDeadlock,Cycle2Deadlock=second.MaterialDeadlock,Cycle2People=second.State.People.Values.OrderBy(p=>p.Id.Value).Select(p=>new{Id=p.Id.Value,p.Grain,p.NeedsGrain}),ExogenousEvents=second.Events.Where(e=>e.Kind=="ExogenousGrain").Select(e=>new{e.Detail,Changes=e.Material.Select(m=>new{m.Before,m.After})})});
                Check(second.MaterialDeadlock==(credit==1),"Control batch's actual stable outcome differs.");
                Check(second.State.People.Values.All(p=>p.Grain==0),"Net-zero or one consumed unit must leave zero stocks.");
                if(first.MaterialDeadlock!=expectedFirst) failed=true;
            }
            Results.Add(new{Id="R4-NET-ZERO-OBSERVATION",Status="OBSERVATION",Details=observations});
            Check(!failed,"A future positive input that is withdrawn before maintenance suppressed MaterialDeadlock although no scheduled input can make voluntary production possible.");
            return observations;
        });
        Directory.CreateDirectory("../evidence");
        File.WriteAllText("../evidence/reviewer-probes.json",JsonSerializer.Serialize(Results,new JsonSerializerOptions{WriteIndented=true}));
        foreach(var result in Results)
        {
            var item=JsonSerializer.SerializeToElement(result);
            Console.WriteLine(item.GetProperty("Id").GetString()+": "+item.GetProperty("Status").GetString()+
                (item.TryGetProperty("Error",out var error)?" -- "+error.GetString()!.Split('\n')[0]:""));
        }
    }
}
```

### Observed console output

```text
R1-AGGREGATE-GRAIN-CREDIT-ALL-PERMUTATIONS: PASS
R1-DEBT-BOTTLENECK-OBSERVATION: OBSERVATION
R1-DEBT-BOTTLENECK-COMMUTING-FARM: FAIL -- System.Exception: Farm was marked as a technical fallback despite commuting with every feasible debt-resolution ordering.

R1-RESIDENCE-THREE-CYCLE: PASS
R2-REQUEST-REFUSAL-CONTROLS: PASS
R2-THREE-MIXED-CAUSES: PASS
R3-IDENTITY-ONLY-HIDDEN-FACT-CROSS-PRODUCT: PASS
R3-PARTIAL-OBSERVATION-ISOLATION: PASS
R3-UNBOUND-DEBT-ISOLATION: PASS
R5-IDENTITY-STORAGE-OBSERVER-ISOMORPHISM: PASS
R4-NET-ZERO-OBSERVATION: OBSERVATION
R4-NET-ZERO-FUTURE-INPUT-DEADLOCK: FAIL -- System.Exception: A future positive input that is withdrawn before maintenance suppressed MaterialDeadlock although no scheduled input can make voluntary production possible.
```
