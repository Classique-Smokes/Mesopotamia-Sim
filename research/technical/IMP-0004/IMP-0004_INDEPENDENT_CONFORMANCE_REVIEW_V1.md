# IMP-0004 Independent Conformance Review V1

**Review type:** fresh independent whole-candidate conformance review  
**Repository:** `Classique-Smokes/Mesopotamia-Sim`  
**Review date:** 2026-09-25  
**Final verdict:** **PASS — PROMOTE**

## 1. Exact candidate and frozen authority identity

I reviewed the exact frozen candidate requested by the independent-review packet:

- candidate ref: `imp-0004-slice4-conformance-candidate-v1`
- candidate SHA: `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`
- implementation PR: #109, still draft, open, and unmerged at that exact SHA
- return branch before this report: `review/imp-0004-conformance-v1-independent-return`, identical to the candidate SHA with zero commits ahead/behind
- frozen Slice-4 acceptance ref: `sfl-v0-slice4-acceptance-v2`
- frozen manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`
- approved inherited-adaptation ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`
- approved inherited-adaptation commit: `68fddec788b5cf41db5934c8719a6fd1ce474d32`
- approved inherited-adaptation-plan blob: `00c3e64a128fa00e91b99117e321a0e379dd61c5`
- exact candidate CI run: `36094176584`
- exact CI artifact: `10846019591`
- expected artifact digest: `sha256:22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6`

I independently downloaded the exact CI artifact and recomputed SHA-256. It matched `22c05163d0f119c5ff04c5a1c3d86b1739bf56f15ed406ba8a7acec4706461f6` exactly.

The candidate changes no accepted specification, ADR, decision, frozen verification-manifest, or approved-adaptation authority file.

## 2. Independence / anti-anchoring procedure

I followed the packet's anti-anchoring order.

Before fixing a provisional verdict I read the accepted authority, frozen manifest, approved adaptation plan, candidate production source, substantive acceptance tests, independent oracle, resolver/dependency paths, fixture construction, and exact-head CI/raw artifact. I did **not** use the coder implementation report, adaptation ledger, PR prose, or generated PASS summaries as semantic authority before that provisional judgment.

My provisional judgment was **PASS — PROMOTE** based on that independent read. Only afterward did I inspect the coder report, adaptation ledger, and PR prose for discrepancy/corroboration. They did not change the judgment.

## 3. Canonical verification and environment disclosure

The exact-head CI run `36094176584` checked out candidate SHA `bac53de...` and used SDK 10.0.401. Its canonical sequence succeeded:

1. `dotnet restore Mesopotamia.Sim.slnx`
2. `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
3. Release build with `--no-restore`
4. Release test with `--no-build --no-restore`

Observed exact-head results: build succeeded with zero warnings/errors; the test job completed with 67/67 tests passing; the acceptance artifact was uploaded with the exact frozen digest above.

My review environment did not provide a local .NET SDK and direct repository network checkout was unavailable, so I did **not** represent those commands as locally rerun. Instead I independently verified their exact-head CI logs and then independently interrogated the emitted raw artifact outside the candidate code.

## 4. Frozen acceptance classifications and inherited chain

The exact artifact binds:

- implementation head: `bac53decaafb5edf4c5879be0f695f6a52ccc1ce`
- clean working tree: true
- exact frozen Slice-4 manifest blob: `b0bc79e...`

Slice-4 frozen classifications are preserved exactly:

- **165 REQUIRED: 165 PASS**
- **9 DEFERRED: 9 remain DEFERRED**
- **2 UNEXERCISED: 2 remain UNEXERCISED**

The inherited REQUIRED census is exactly **270/270 PASS**, composed by the frozen chain rather than by relabeling current Slice-4 results.

I did not treat the historical Slice-1 global-conformance placeholder as this candidate's independent-conformance decision; this report is the fresh gate requested by the packet.

## 5. Approved inherited adaptations A–D

I found all four approved adaptations implemented narrowly and losslessly, with no fifth inherited-witness weakening.

### A — formation headlessness

The old literal type-absence boundary is replaced only by the semantic boundary required after role types exist: each produced Household gets one persistent role, it is vacant at formation, no transition installs a head, and formation creates no Household-mode initiative/effect. A well-formed occupied-role corruption is rejected by the Slice-4 oracle.

**Conforms.**

### B — explicit structural authority

The historical exact `HouseholdState` field inventory remains exact and adds only the explicitly approved role/transition/refusal/role-counter authority. `WorldState` is not expanded into a hidden office/resource authority. New accepted-attempt/funding/role records are typed and phase-carried rather than hidden in a cache.

The behavior-affecting hidden-eligibility mutant in `tests/Run-Slice4Mutants.ps1` adds `CachedNomineeEligible` and makes outsider eligibility trust it; this is a genuine authority mutant, not an inert field.

**Conforms.**

### C — bounded Household material events

The historical Slice-3 oracle remains strict in its historical producer scope. Slice-4 has a separate independent material oracle that permits the two accepted Slice-4 material meanings and rejects arbitrary Household payments, bad authority/arithmetic/provenance, private-X ordinary-transfer meaning, and fabricated aggregate effects.

**Conforms.**

### D — closed commitment provenance union

Historical fixture commitments remain explicitly `ProvisionFixtureProvenance`. Ordinary endogenous solicitation and head self-authorization have distinct typed origins carrying the required request/acceptance/authorization/authority causality. Transaction-specific private X is not promoted into a persistent commitment origin.

**Conforms.**

## 6. Role, consent, lifecycle, and identity review

The implementation preserves one persistent `HouseholdHeadRoleId` per H, distinct from occupant identity. New H begins vacant. Appointment/succession captures the common-snapshot sustaining-participant cohort and exact association identities.

I verified:

- nominator and nominee must be current sustaining participants;
- nominee willingness and participant acceptance remain separate semantic capacities;
- self-nomination retains both aliased predicates without manufacturing a self-response;
- all captured participant consents are required;
- captured associations and predecessor role are revalidated at commit;
- same-cycle newcomers do not retroactively join the accepted cohort;
- simultaneous/stale appointment authority cannot silently overwrite the role;
- head exit vacates the persistent role without changing role identity;
- an Inactive sole-bearer role fill is inert and does not reactivate H or create Household-mode initiative;
- vacancy/inactivity/dissolution suppress the correct Household capability without erasing unrelated person-level behavior.

No role/holder identity collapse or hidden automatic head selection was found.

## 7. Recognition and information review

Head Recognition is actor-held and derived from retained `HeadRoleFact` evidence, not from objective role occupancy. Household Recognition remains a separate subjective gate.

I verified:

- appointment participants acquire exact head evidence through participation;
- outsiders do not passively synchronize to objective succession/vacancy;
- explicit communication is required for outsider correction;
- late older evidence cannot overwrite newer underlying event evidence;
- incomparable head reports produce `Contested`, not an ID-selected authority winner;
- known vacancy, unknown head state, and contested head evidence remain distinct;
- negative attitude/refusal does not erase head Recognition;
- mediated marriage independently requires groom-held bride participation evidence, Household Recognition, and current head/scope Recognition;
- live revalidation can invalidate an accepted mediated attempt after a same-cycle evidence change.

The three mediated subjective gates are independently ablated and return distinct reasons; they are not collapsed into one omniscient lookup.

## 8. Dual-mode initiative and scoped authority

An occupied role enables one Household decision context only while H is Active. The head still retains one personal initiative; response handling remains separate. A person may simultaneously act personally and through H, and may head multiple distinct H contexts without those contexts collapsing.

Ordinary gift/move/debt/favour/marriage actions cannot be made office-valid by attaching a Household context. Role scope does not create general sovereignty.

No extra personal initiative or fabricated self-response is used merely to carry same-person private-resource consent.

**Conforms to ADR-0002 and the Slice-4 dual-mode contract.**

## 9. Provision acquisition and reconsideration

I found the two accepted persistent-provision acquisition routes intact:

1. ordinary head request -> contributor response -> endogenous commitment provenance;
2. head self-commitment -> explicit institutional-request and private-resource predicates -> direct self-consent provenance, no P->P response theatre.

Standing commitment creation moves no grain.

Refusal/reconsideration behavior is keyed to H and contributor and survives succession. Cooldown and changed context are separate gates. DEC-0014 historical need behavior is implemented as an occurrence after the latest refusal, not a current-only demand:

- support onset/reentry can create the historical change;
- uninterrupted need present at refusal does not become new merely by persisting;
- an otherwise-valid positive mediated dowry can create the occurrence even when funding is unavailable;
- a later refusal resets the baseline;
- proposal/replay identity alone cannot manufacture need.

No generic pending-demand/obligation subsystem was introduced.

## 10. DEC-0011 private X and material funding

The transaction-specific private contribution X remains exact, current-holder-owned, positive, bounded by cost and reserve/NeedsGrain restrictions, and separate from standing commitment capacity.

The live funding evaluator:

- subtracts X from the current head's effective commitment capacity;
- ranks remaining commitments by effective capacity descending then semantic PersonId for exact ties;
- fixes the rank rather than reranking after partial debit;
- requires the exact accepted split at live precommit;
- does not shrink, increase, rebalance, renegotiate, or rebind accepted X;
- records typed private and commitment-backed legs even when final material deltas aggregate by person;
- preserves contributor/recipient aliasing without losing the source leg;
- atomically publishes mediated marriage, groom credit, and exactly one groom->head favour.

Private X creates no Gift/Help/Loan attitude meaning, no extra favour, and no formation/continuity/lineage evidence.

## 11. DEC-0010 / DEC-0013 ordering, dependency, and replay

The bounded semantic order preserves accepted authority use before its paired destructive transition while still revalidating unrelated gates. Shared-grain Household support/material use precedes lower personal-material use where the accepted contract requires it, including repayment/called repayment.

The dependency path does **not** contain a second funding allocator. For cost-bearing collective attempts it consumes `HouseholdFunding.Participants(...)` as declared possible material participation; it does not recompute exposed capacity/rank/X policy. Detached resolution calls the same `EvaluateFunding` seam used by live resolution. Commit consumes `proposal.LiveFunding` rather than reallocating.

Detached projection normalizes newly allocated event/relation/role/commitment/evidence identities by causal content, preventing allocation identity alone from manufacturing a fallback.

I found no stale derived resource cache functioning as current authority.

## 12. Fixture integrity and oracle independence

Slice-4 fixtures start from the lower-level allowed world/knowledge surface. Household formation is produced through ordinary support plus communicated evidence and is independently checked before role work. Explicit fixture head reports are confined to declared adversarial knowledge prerequisites; they do not directly write appointment/funding/marriage outcomes.

The Slice-4 oracle independently reconstructs role transitions/consents, evidence receipts, commitment origin, funding arithmetic/rank/debits, material conservation, and mediated effects. Candidate assurance checks explicitly forbid the oracle from calling production Household/head Recognition/funding/collective classifiers, `ReferenceScorer`, `ResolutionFallbacks`, `RunCycle`, `new Simulation`, or `MobilizableCapacity` as expected-answer authority.

Well-formed corruptions are actually passed to the checker: role/cohort/consent/evidence identity, funding cost/residual/tie/private/legs/possible participants, material effects, marriage/favour cardinality, and fixture/endogenous/self provenance cross-labels.

I found no production-as-oracle shortcut.

## 13. Reviewer-owned scratch probes

I created an external reviewer probe harness over the **raw exact-head CI artifact**, not over its PASS summary and not through candidate production helpers. The harness parsed `slice4-fixtures.json` histories/final typed records and independently asserted semantic properties.

**Result: 30 probes, 4,950 primitive assertions, 0 failures.**

The 30 probe topics were:

1. formation creates a vacant role and no Household initiative;
2. appointment unanimity ablations decline;
3. same-cycle newcomer is excluded from captured succession cohort;
4. self-nomination retains participant + nominee capacities;
5. Inactive sole-bearer role fill is inert;
6. outsider head knowledge remains local until communication;
7. Contested head evidence blocks authority;
8. one person can commit personal + Household acts without double personal initiative;
9. ordinary provision commitment has endogenous-response provenance;
10. head self-commitment has direct dual-capacity provenance and no self-response;
11. cooldown and context change are both required;
12. a later refusal resets historical need;
13. support onset/reentry differs from uninterrupted need;
14. fixed-rank multi-contributor debit/tie behavior;
15. same-head private X cannot double-count unreduced commitment capacity;
16. accepted X cannot be rebalanced/rebound;
17. current head can receive proactive support without P->P response;
18. mediated dowry/material/favour effects are atomic and conserved;
19. Household support priority beats lower repayment/ordinary transfer while preserving ordinary failure semantics;
20. valid last act precedes head exit/vacancy;
21. old-head attempt never rebinds to successor;
22. female head/bride dual-capacity mediation remains valid;
23. one person can carry two distinct Household contexts plus personal initiative;
24. declared material-participant set changes when private X is present;
25. mediated Household/head/bride subjective gates remain independent;
26. isomorphic PersonId renaming preserves normalized role/material semantics;
27. all 94 fixture histories have monotone unique reaction indices and causes strictly preceding effects;
28. every material-bearing Household event is within the accepted bounded material meaning set;
29. every emitted funding result explains exactly C by private + commitment legs, conserves event material, and declares the recipient;
30. head-transition evidence acquisition never broadcasts beyond transition participants.

The higher-order multi-H/shared-contributor and dependency-grouping challenge was also traced against the exact source: two H actions sharing a possible funding person intersect through `HouseholdFunding.Participants` in dependency analysis, while the funding rank itself remains owned by the live evaluator.

## 14. Mutation / fault-control review

The frozen cross-cutting contract's private-X / DEC-0013 fault classes 36–52 are substantively exercised by concrete negative, race, provenance, corruption, and source-seam checks. In particular:

- 36–42: explicit private consent, non-standing X, no double count, exact split/no rebalance, no ordinary-transfer/evidence relabel, no successor rebind, no extra initiative/self-response;
- 43–48: support-vs-repayment priority, snapshot-bound cohort, head recipient, self commitment, self nomination, inert Inactive role fill;
- 49–52: single funding authority seam, typed source provenance, derived `MobilizableCapacity` nonauthority, and resource state not defining Household/participation/role/Recognition identity.

The candidate also contains an executable detached mutation runner with:

- one behavior-affecting hidden-eligibility authority mutant;
- 53 current-need-only;
- 54 funding-required-for-need;
- 55 pre-latest-refusal need reuse;
- 56 proposal/retry identity manufacturing need.

The runner requires a fresh detached worktree, exact patch capture, successful restore/build, a real acceptance-test execution, and at least one assertion failure with test exit code 2 before it classifies a mutant as detected.

**Evidence limitation:** the exact CI acceptance artifact does not contain the mutation runner's separate build/TRX logs, and this review environment could not independently execute .NET. I therefore did not use the coder's statement that those external mutation runs passed as a premise for the verdict. The mutation seams themselves are exact and behavior-affecting, their targeted semantic scenarios are green at exact head, and the corresponding failure modes are independently exercised by the raw-artifact/source review above. I found no verification defect requiring a block on that basis.

## 15. Scope audit

The implementation stays inside the released synthetic v0 Slice-4 boundary. I found no new:

- pooled Household treasury/general ledger;
- generic payment/accounting architecture;
- checkpoint/save-load contract;
- resignation/rival-claimant subsystem;
- general perception/global Recognition sync;
- generic demand lifecycle;
- stochastic/concurrent/distributed kernel;
- general office sovereignty or command over ordinary personal action;
- historical economic calibration claim.

The grain/reserve/commitment/private-X mechanisms remain explicit bounded laboratory scaffolding.

## 16. Findings

### Blocking implementation / verification defects

**None established.**

### Semantic escalations

**None.** I found no material question that requires a new decision record or authority rewrite.

### Non-blocking evidence note

The reviewer did not locally rerun .NET or the separate mutation runner; exact-head canonical CI, exact artifact identity, raw artifact interrogation, source-level mutation seams, and reviewer-owned independent probes are documented above. This limitation does not change the semantic/conformance conclusion.

## 17. Final verdict

**PASS — PROMOTE**

Promotion disposition: **PROMOTE** the exact candidate `bac53decaafb5edf4c5879be0f695f6a52ccc1ce` through the architect-controlled path. Do not infer approval for any later commit, moved ref, or changed artifact identity from this report.
