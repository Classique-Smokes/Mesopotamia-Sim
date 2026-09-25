# IMP-0001 — Slice 1 Successor v2 / DEC-0015 Independent Conformance Review v1

**Review status:** COMPLETE  
**Review type:** fresh independent post-implementation successor-conformance review  
**Reviewed candidate ref:** `imp-0001-slice1-successor-v2-dec0015-conformance-candidate-v1`  
**Reviewed candidate commit:** `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`  
**Implementation PR:** #125 — draft / unmerged at review time  
**Frozen authority:** `SFL-V0-S1-ACCEPTANCE-v2` / `sfl-v0-slice1-acceptance-v2`  
**Frozen manifest blob:** `174ccbae57a64f06bd88de233b11a011b4a2b115`  
**Review date:** 2026-09-25

## 1. Review basis and method

I reviewed the exact pinned candidate independently against DEC-0015, the current promoted SPEC, the DEC-0015 promotion reconciliation, retrospective SID closure, canonical `VS-SFL-107`, the frozen successor-v2 manifest/freeze record, candidate source, acceptance/oracle source, the executed mutation script, raw final-head CI logs, and the uploaded final-head evidence artifact.

The implementation report was used only as an index after the candidate and authority were inspected directly.

Final-head evidence independently checked:

- workflow run `36124403519` / canonical verification #325;
- workflow head `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`;
- artifact ID `10859307017`;
- downloaded artifact SHA-256 `ac879968976bbb7e87b6dcd6edd7b7e93b03e0d37681d29d286c5cb02bfc92d5`, exactly matching the dispatch digest;
- canonical test run: 75 total, 75 succeeded, 0 failed, 0 skipped;
- Release build: 0 warnings, 0 errors.

## 2. Candidate / scope integrity

**PASS.**

The immutable candidate ref resolves exactly to `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`. PR #125 is open, draft, unmerged, and its head is that same commit.

The PR contains exactly the eight dispatched changed paths:

- `.github/workflows/ci.yml`;
- `research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_CONFORMANCE_REPORT.md`;
- `src/Mesopotamia.Sim/State.cs`;
- `tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Oracle.cs`;
- `tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Scenarios.cs`;
- `tests/Mesopotamia.Sim.AcceptanceTests/README.md`;
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice1SuccessorV2AcceptanceTests.cs`;
- `tests/Run-Slice1V2Mutants.ps1`.

The only production-code delta is `State.cs`. No decision, SPEC, frozen manifest, freeze record, or inherited acceptance authority is edited by the candidate.

The PR base / semantic merge base is `749033bcec8811d055f86ba5ead0ca5c4060e718`; the candidate is 15 commits ahead of that baseline. During this review, canonical `main` advanced three commits beyond that merge base to route the review itself. Those main-only changes are limited to `00_START_HERE.md`, `plans/CURRENT_PHASE.md`, and the review task file. They contain no production or acceptance-authority change. Thus current Git topology is candidate 15 ahead / 3 behind current main, but the three behind commits are post-candidate review-routing administration and do not alter the semantic review baseline or candidate scope.

The return branch `review/slice1-v2-dec0015-conformance-v1-return` was pinned to the exact candidate before this report was added.

## 3. Production semantic result

**PASS.**

The `WorldState.Validate()` repair implements the DEC-0015 separation directly:

- generic relation endpoint handling is now `CheckPeopleExist(a,b)`, which checks existence only;
- Attitude calls that helper and has no endpoint-inequality test;
- Kinship checks existence, then locally requires distinct people;
- Marriage checks existence, then locally requires distinct people, while preserving the prior sex, kinship, and cardinality rules;
- Debt checks existence, then locally requires distinct creditor/debtor, while preserving balance validation;
- Favour checks existence, then locally requires distinct debtor/holder, while preserving outstanding-pair capacity validation.

The old generic `CheckPair` inequality was removed. No relation registry, diagonal-policy table, global self-relation abstraction, or speculative self-Debt/self-Favour behavior was introduced.

A direct inventory comparison between the candidate and its PR base shows the authoritative `WorldState` dictionaries and `nextRelation` field are unchanged: People, Dwellings, Residences, Attitudes, Kinships, Marriages, Debts, Favours, and `nextRelation` remain the same authoritative state inventory.

The patch is therefore the bounded DEC-0015 validation repair, not an architectural expansion.

## 4. D1 self-counterparty result

**PASS.**

The current production path rejects self-counterparty terms before response activation. `ActionRules.Invalid` resolves the semantic target and returns `InvalidCounterparty` when target equals proposal actor. `Simulation.RunCycle` calls that validity boundary before its response branch; invalid terms are finished as `InvalidTerms` and the loop continues without creating a response decision.

The successor evidence challenges:

- `OfferGift`;
- `RequestGiftOrHelp`;
- `OfferLoan`;
- `RequestLoan`;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help in both material directions;
- `CallFavor` self-target boundary.

For the direct transfer forms the test crosses self-use with both an absent/present diagonal Attitude and accepting/refusing response profiles, so rejection cannot be explained by response preference.

The independent observation checks require:

- `InvalidTerms / InvalidCounterparty`;
- zero decision traces for the proposal;
- only Proposal + InvalidTerms events for that proposal;
- no material changes or attitude contributions;
- no Debt or Favour creation;
- no participant knowledge / participation fact;
- no Declined, Unable, InvalidatedAtResolution, AttitudeComposition, loan/repayment, favour fulfilment, or due-review consequence.

For `CallFavor`, a true holder==called-actor live state would require an already-invalid diagonal Favour. The candidate therefore uses a detached invalid snapshot only to challenge `ActionRules.Invalid` at that classifier boundary, and separately uses a public ordinary Favour path where the debtor attempts to call themselves to verify pre-response suppression. The detached snapshot is explicitly recorded as non-live and is not presented as executed social behavior.

This satisfies the current bounded D1 rule without manufacturing a live diagonal Favour.

## 5. Allowed Attitude diagonal result

**PASS.**

The candidate accepts and independently observes `Attitude(P,P)` at values `-100, -5, -2, -1, 0, 1, 2, 5, 100`, and rejects `-101` / `101`.

The evidence confirms:

- exact directed-pair addressability;
- ordinary [-100,+100] bounds;
- ordinary cycle-five maintenance;
- `+5 -> +3` and `-5 -> -4` at the due maintenance point;
- zero-crossing behavior remains ordinary;
- unrelated P->Q and Q->P edges evolve independently;
- the diagonal edge has its own maintenance history;
- a diagonal Attitude does not authorize a self-counterparty Gift.

The generic endpoint helper contains no equality predicate. The executed `generic-endpoint-inequality` production mutant adds such a predicate and is detected by the Attitude-diagonal semantic detector.

## 6. Debt / Favour diagonal result

**PASS.**

Current diagonal Debt and Favour remain invalid authoritative claims, but the rejection is type-specific.

Debt evidence includes both self-loan routes, empty-cycle controls through the would-be social-due boundary, unavailable repayment of a nonexistent claim, and a detached validator contrast:

- ordinary Debt(P,Q) validates in a world that also contains diagonal Attitude;
- Debt(P,P) reaches the Debt-owned distinctness check and is rejected as `Debt requires distinct people.`.

Favour evidence includes explicit benefit-for-favour and both reciprocal-help self routes, absent-claim CallFavor, and detached validator contrasts for both outstanding and consumed states:

- ordinary Favour validates;
- Favour(P,P) reaches the Favour-owned distinctness check and is rejected as `Favour requires distinct people.`.

No public state-injection API was added. The detached WorldState writes are boundary probes and are reported as such; live transition claims are not inferred from them.

The `diagonal-debt-enabled` and `diagonal-favour-enabled` compiled production mutants are each detected by their respective semantic detectors.

## 7. Valid-alias preservation result

**PASS.**

The candidate re-executes the required positive aliases rather than solving D1 with a broad all-roles-distinct rule.

Observed controls include:

- personal initiative plus a separate incoming response for the same person;
- multiple response contexts / shared scarce source from the common snapshot;
- valid two-party `CallFavor(RepayDebt)` with outer favour holder equal to the inner Debt creditor;
- inherited same-directed-edge attitude-cause convergence.

The two-party CallFavor/RepayDebt control commits successfully, consumes the Favour, satisfies the Debt, records one response for the called actor, and preserves separate +5 repayment and +10 called-favour causal contributions into the same directed Attitude edge.

The executed `broad-response-alias-prohibition` mutant is compiled successfully and is detected by `Dec0015InheritedSharedSnapshotScarceGrain`, demonstrating that the evidence would reject a broad response-alias ban.

## 8. Executed mutation result

**PASS.**

I inspected the mutation script, final-head job log, downloaded patches, TRX receipts, and `mutant-results.json`.

The unmutated control executes all six named detector cases and all six pass.

All seven required production mutations are tied to exact base head `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`; every mutation has:

- format exit 0;
- build exit 0;
- test exit 2;
- `Outcome = detected`;
- `Detected = true`;
- a failed TRX result whose test name contains the intended semantic detector.

Executed mutations:

1. generic-endpoint-inequality — detected by `Dec0015AttitudeDiagonal`;
2. self-gift-response — detected by `Dec0015SelfCounterpartyBoundary`;
3. self-loan-response — detected by `Dec0015SelfCounterpartyBoundary`;
4. diagonal-debt-enabled — detected by `Dec0015DebtDiagonal`;
5. diagonal-favour-enabled — detected by `Dec0015FavourDiagonal`;
6. broad-response-alias-prohibition — detected by `Dec0015InheritedSharedSnapshotScarceGrain`;
7. diagonal-attitude-authorizes-self-action — detected by `Dec0015SelfCounterpartyBoundary`.

The self-loan mutant is not credited because a raw runtime exception happened to occur: the intended self-counterparty test converts reaching execution instead of returning InvalidTerms into an explicit assertion failure. The campaign script in general refuses to credit build failure, timeout, crash/unrelated failure, or parser coincidence.

The candidate gate records `ExecutedMutants = 7`, `CandidateReady = true`, and keeps independent conformance external.

## 9. Full 134-row successor evidence result

**PASS, with this report supplying the sole external row.**

The downloaded `slice1-v2-results.json` identifies:

- exact implementation head `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d`;
- clean working tree;
- manifest version `SFL-V0-S1-ACCEPTANCE-v2`;
- manifest blob `174ccbae57a64f06bd88de233b11a011b4a2b115`;
- `ExecutableEvidenceReady = true`.

The generated row census is exactly:

- 173 total unique rows;
- 134 REQUIRED;
- 33 DEFERRED;
- 3 N-A;
- 3 UNEXERCISED.

Of the 134 REQUIRED rows:

- 133 coder-owned rows are PASS;
- all 133 have non-empty evidence references;
- the sole non-PASS REQUIRED row is `S1-GLOBAL-CONFORMANCE`, with state `AWAITING FRESH INDEPENDENT REVIEW`.

All 39 non-REQUIRED rows retain exactly their frozen classification/state.

I compared the v1 and v2 generated rows by AcceptanceId. No inherited v1 ID is missing, and no inherited classification or frozen SourceClause changes. The exact six added IDs are the six `S1-107-*` DEC-0015 rows.

The successor runner regenerates the historical v1 evidence in the same execution rather than trusting a stale artifact. Its historical case bundle contains 62 PASS cases, and all 127 historical coder-owned REQUIRED rows other than the historical independent-review row retain non-empty references. The six successor rows point to executed successor scenarios, with the valid-alias row additionally binding the three inherited positive alias controls.

This independent PASS report is the external evidence intended for `S1-GLOBAL-CONFORMANCE`. The candidate correctly did not self-award that row.

## 10. Oracle / fixture / structural result

**PASS.**

The successor artifact contains:

- 9 successor cases, all PASS;
- 98 recorded public simulation fixture entries;
- 17 separately recorded detached boundary probes;
- successor oracle audit `State = PASS`;
- successor structural audit `State = PASS`.

`Dec0015Oracle.cs` uses explicit accepted outcomes, raw state/history/knowledge observations, and direct arithmetic. The candidate's dependency audit additionally verifies the new oracle does not call production ActionRules, WorldState, ReferenceScorer, PersonalAgency, RunCycle, EvaluateTransaction, Validate, or EpistemicRules.

The unchanged `InvariantOracle` remains the inherited independent reconstruction layer.

The boundary between detached and live evidence is explicit:

- detached WorldState / ActionRules probes are systems under test at validation boundaries;
- detached writes are not claimed as successful live execution;
- public simulation paths independently establish response/material/knowledge suppression;
- no Debt/Favour transition result is fixture-written into a live simulation;
- positive diagonal Attitude is exercised through ordinary initialization and maintenance.

No synthetic public injection API was introduced.

## 11. Regression / inheritance / architecture result

**PASS.**

At the exact candidate head, final-head CI #325 records successful restore, format verification, Release build, 75/75 tests, and the seven-mutation campaign.

Inherited artifact results remain green:

- Slice 2: 46/46 REQUIRED PASS, 9 DEFERRED;
- Slice 3: 96/96 REQUIRED PASS, 11 DEFERRED, 2 UNEXERCISED;
- Slice 4 v2: 165/165 REQUIRED PASS, 9 DEFERRED, 2 UNEXERCISED.

No Slice-2/3/4 acceptance source is changed by the candidate. The historical Slice-1 runner is also re-executed.

The candidate does not change the WorldState authoritative field inventory, add a registry/policy engine, weaken an inherited structural witness, or introduce Slice-5 checkpoint/persistence code. The only production file changed is the bounded `State.cs` validator repair.

Manifest identity is pinned both in source and generated evidence, and the final artifact is bound to the exact clean candidate revision; I found no stale-authority seam.

## 12. Reviewer-owned challenge — same identity tuple, three semantic owners

I performed a compact read-only call-path challenge that is not taken from the candidate report's scenario table: use the same logical tuple `(P,P)` and ask which semantic owner is allowed to decide equality.

### Path A — generic relation endpoint substrate

For `Attitude(P,P)`, `WorldState.Validate` calls `CheckPeopleExist(P,P)`. With P present, both existence predicates pass. The helper contains no equality branch. Attitude then owns only its ordinary bound check.

**Result:** equality is not rejected generically.

### Path B — typed current relation semantics

For `Debt(P,P)` and `Favour(P,P)`, the same `CheckPeopleExist(P,P)` first succeeds. Control then returns to the owning Debt/Favour validator, where the local equality rule rejects the relation.

**Result:** current diagonal rejection is owned by the relation type, not generic storage.

### Path C — interaction-role semantics

For `OfferGift(P,P)` in a world where `Attitude(P,P)` is valid, `ActionRules.Target` returns P and `ActionRules.Invalid` rejects target==actor before response activation. `Simulation.RunCycle` never reaches the response branch.

**Result:** allowing relation diagonal state does not authorize a self-counterparty interaction.

These three paths put the same identity collapse through three different semantic owners and produce three intentionally different outcomes. A disguised global endpoint-inequality implementation would fail Path A; an over-broad diagonal permission would fail Path C; missing type-local current rules would fail Path B. The executed successor evidence and mutants independently exercise each side of this call-path reasoning.

Challenge result: **PASS**.

## 13. Semantic-escalation status

**No semantic escalation required.**

DEC-0015, the promoted current SPEC, the promotion reconciliation, SID closure, VS-SFL-107, and frozen successor-v2 manifest agree on the relevant expected results. I found no required outcome whose meaning is left unresolved by accepted authority.

## 14. Final verdict

### PASS — PROMOTE

Exact candidate v1 at `a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d` conforms to frozen Slice-1 successor v2 authority.

The candidate implements DEC-0015 without semantic overreach, preserves inherited valid aliases and relation-specific future seams, supplies substantive evidence for all 133 coder-owned REQUIRED rows, leaves the independent review row external as required, passes the executed production-mutation campaign, and introduces no blocking production, verification, inheritance, or architectural regression.

## 15. Promotion recommendation

Promote the exact PR #125 candidate semantics to canonical `main`.

Because `main` gained three review-routing/documentation commits after the candidate's PR base, promotion should use the ordinary merge path that preserves those main-only administrative changes; no semantic adaptation of the candidate is required by this review.

This report may serve as the fresh external evidence for `S1-GLOBAL-CONFORMANCE`. Do not rewrite frozen v1/v2 acceptance authority to record the result.
