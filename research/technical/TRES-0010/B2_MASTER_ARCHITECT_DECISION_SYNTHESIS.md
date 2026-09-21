# TRES-0010 — B2 Master Architect Decision Synthesis

**Status:** MASTER ARCHITECT SYNTHESIS / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Implementation gate:** IMP-0001 remains blocked pending Director decisions, promotion, acceptance-manifest materialization, and final closure audit.

## 1. Review integrity

All three B2 branches were checked against frozen B2 baseline `0729e460af35668e5b911fa561bf8cec53204142`.

Each branch added only its assigned return file under `research/technical/TRES-0010/returns/`. No canonical project artifact was modified.

## 2. Overall assessment

The three B2 reports are high quality and mutually compatible.

They do not recommend architectural redesign or broad new infrastructure.

They reduce the remaining pre-code work to:

- five narrow Director-level Slice-1 semantic choices;
- one minimal verification-governance mechanism;
- mechanical application of the approved rules into verification/IMP artifacts.

No further broad research wave is justified.

## 3. Semantic recommendations ready for Director decision

### D1 — same-cycle direct attitude composition

**B2 recommendation:** for the currently defined fixed direct attitude consequences, sum all distinct signed deltas targeting the same directed attitude from the same cycle and clamp once against the post-maintenance/pre-reaction value. Preserve every cause/delta as causal history. Do not impose a semantic order among independent member causes.

Example: +95 with +10 and -20 becomes +85, not +80/+85 depending on queue order.

**Master Architect assessment:** recommend approval.

Why:
- removes technical enumeration order from social meaning;
- preserves individual causal provenance;
- stays narrow to current direct causes rather than generalizing all future reaction chains;
- simple to test.

### D2 — same-cycle Residence competition

**B2 recommendation:** at most one Residence transition per person may commit per cycle. Multiple independent Accept responses remain true decisions. Accepted still-feasible contenders form a central-resolution conflict set; absent semantic priority, the existing disclosed stable-ID fallback selects one and losers become `InvalidatedAtResolution(CompetingResidenceTransition)`.

**Master Architect assessment:** recommend approval.

Why:
- preserves response autonomy;
- prevents arbitrary sequential double-moves;
- uses the existing conflict/fallback model rather than creating new preference semantics;
- leaves room for later social priorities.

### D3 — called-favour response-closed payload class

**B2 recommendation:** a called favour may request only an ordinary action for which the called actor's Fulfil/Refuse response is the last new voluntary actor choice needed for the requested action to reach terminal commit/failure. Requested execution is response-scoped and does not separately consume/grant the called actor's personal initiative. Slice 1 does not allow the payload to open another `ResponseDecisionContext`. The favour is consumed only when the requested action commits successfully.

Outcomes:
- voluntary refusal -> Declined; favour remains; -20;
- Unable -> favour remains; no fulfil/refusal attitude effect;
- InvalidatedAtResolution -> favour remains; no fulfil/refusal attitude effect;
- successful requested-action commit -> favour consumed; +10.

**Master Architect assessment:** recommend approval, with one mandatory follow-up before IMP dispatch:

- enumerate every currently in-scope action shape against the response-closed predicate so membership is not left to the coding agent.

This is a mechanical application table, not another semantic research task.

### D4 — grain-valued parameter domain

**B2 recommendation:**

- v0 personal grain stock: nonnegative integer units;
- every grain-valued action parameter: strictly positive integer;
- zero, negative, and non-integral terms are categorically invalid before target response;
- `RepayDebt(amount)` only valid for `1 <= amount <= remaining debt`;
- no clamping/normalization of invalid terms;
- valid terms exceeding current material capacity are `Unable`;
- valid accepted terms whose capacity disappears before commit become `InvalidatedAtResolution`.

The integer granularity should be recorded as a replaceable v0 assumption (proposed ASM-0014), not historical metrology.

**Master Architect assessment:** recommend approval.

One wording refinement:

- treat `InvalidProposal(reason)` as a **pre-interaction validation rejection / diagnostic classification**, not as a new fourth social failed-attempt outcome alongside Declined/Unable/InvalidatedAtResolution.

The report already intends this distinction; promotion should preserve it explicitly.

### D5 — explicit benefit-for-favour at full pair capacity

**B2 recommendation:** the explicit bargain is atomic.

If the promised new favour cannot exist because the ordered-pair slot is already occupied:
- proposal is infeasible;
- no material benefit commits;
- no new favour;
- do not relabel it as Gift/Help.

If capacity exists at acceptance but is lost before commit:
- whole bargain becomes InvalidatedAtResolution;
- no material effect/favour.

On success:
- benefit and exactly one new favour commit atomically.

Relationship-mediated reciprocal help remains different: independently meaningful help may commit at full favour capacity while suppressing additional favour creation.

**Master Architect assessment:** recommend approval.

This best preserves the semantic distinction between an explicit exchange and unilateral/help meanings.

## 4. Assumption treatment

If D1/D2 are approved:
- extend ASM-0002 with the direct same-cycle attitude composition rule;
- extend ASM-0007 with the one-Residence-transition conflict rule.

If D4 is approved:
- add ASM-0014 for integral v0 grain granularity.

D3/D5 and the validation/failure distinctions are normative action semantics and should not be hidden as assumptions.

## 5. Acceptance-authority design

### Recommended mechanism

Approve B2-ASR Option D:

1. after semantic promotion, author one canonical `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`;
2. manifest is authored outside IMP-0001 and independently reviewed before code;
3. manifest freezes exact Slice-1 REQUIRED / DEFERRED / N-A / UNEXERCISED obligations and required evidence;
4. IMP-0001 implementation agent authors ordinary tests/harnesses against the frozen manifest but may not edit/reclassify it;
5. ordinary CI runs the executable suite and reports every REQUIRED AcceptanceId;
6. one fresh independent conformance reviewer compares executable tests/oracles against the frozen manifest and canonical cards;
7. IMP-0001 can be VERIFIED COMPLETE only with zero missing/skipped REQUIRED rows and a passing conformance review.

### Why this is the right scale

It directly closes the demonstrated first-author/completeness risk without requiring:
- secret tests;
- separate prebuilt acceptance executable/project;
- general grader service;
- general mutation platform;
- generated-history/shrinking infrastructure;
- organization-scale branch protection.

### Manifest authority

The manifest is verification/completion authority subordinate to accepted semantics. It must identify obligations, not restate or invent social behavior.

## 6. Important applicability decisions from B2-ASR

The proposed manifest correctly:

- requires VS-SFL-090..099 lower-level subcases as applicable;
- defers VS-SFL-104 because it requires Household/head/mediated-marriage substrate;
- requires VS-SFL-070/071/073/074 lower-level failure/reaction coverage;
- defers household-only 072/075/076 where written;
- requires determinism/observer/decision-trace Slice-1 cases while deferring checkpoint and rendered-explanation surfaces outside the slice;
- enumerates boundary/metamorphic obligations instead of saying merely “applicable”;
- permits semantic mutants to be proven by targeted negative tests/audits rather than requiring a mutation-testing framework;
- makes fixture write-set audit, direct-participant knowledge, stable-ID fallback sensitivity, and iteration-order assurance explicit.

The five approved semantic repairs must become REQUIRED manifest rows before freeze.

## 7. IMP-0001 repairs implied by B2

After Director semantic approval and manifest creation:

- rename §2 into required inputs by authority class;
- separate accepted semantic/architecture authority, canonical verification authority, and non-authoritative supporting/engineering context;
- make the frozen Slice-1 manifest the completion applicability authority;
- replace broad scenario ranges/open “relevant/applicable” selectors with manifest rows;
- explicitly defer VS-SFL-104 and communication-specific portions outside Slice 1;
- require manifest SHA/version and full REQUIRED-row result table;
- preserve test-framework/helper choice as implementation-local;
- prohibit IMP-0001 from editing/reclassifying the manifest;
- add escalation when a REQUIRED row cannot be implemented without inventing semantics;
- add implementation-local C# guards from Wave B (snapshot stability, ID/equality discipline, deterministic comparison, checked scoring, test isolation).

## 8. Later-slice ledger remains unchanged

Carry forward but do not solve now:

- CandidateOrganization same-candidate equivalence/convergence;
- actor departure semantics before any executable use;
- repeat exit/rejoin lineage source selection;
- authority-destroying transition vs accepted authority-dependent action;
- future mediated-marriage response topology;
- event-observer eligibility / recognition update on dissolution or head vacancy;
- generated-history validity independence when generated testing becomes completion evidence;
- verified-checkpoint provenance;
- checkpoint omission tests with causally active suffixes;
- later reaction-chain derived-refresh timing.

## 9. What remains before implementation

No further broad research is needed.

Required sequence:

1. Director decides D1-D5.
2. Master Architect promotes approved semantic changes losslessly into SPEC/assumptions/verification.
3. Master Architect mechanically enumerates current CallFavor action applicability.
4. Author/freeze/review the Slice-1 acceptance manifest.
5. Amend IMP-0001 and implementation task template/engineering guards.
6. Record later-slice gaps/deferred assurance items in durable tracking.
7. Run final TRES-0010 closure audit.
8. If closure passes, release IMP-0001 to a coding agent.

## 10. Governance restructuring relationship

The Master Architect rulebook restructuring still comes **after TRES-0010 closure**, as planned.

B2 strengthens the future assurance-protocol content:

- distinguish missing semantics from missing enforcement and local implementation risk;
- require exact applicability at consequential implementation boundaries;
- preserve independent-enough acceptance authority;
- subject adversarial findings to minimality/defense before creating infrastructure;
- use consequence-triggered closure checklists rather than bloating the always-loaded core Guide.

No constitutional restructuring should be performed before the final TRES-0010 process lessons are reconciled.
