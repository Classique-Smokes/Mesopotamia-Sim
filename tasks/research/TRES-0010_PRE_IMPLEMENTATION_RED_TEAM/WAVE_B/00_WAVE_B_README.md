# TRES-0010 Wave B — Targeted Adjudication

**Status:** PREPARED / TARGETED CHALLENGE  
**Authority:** Advisory research only  
**Implementation gate:** IMP-0001 remains blocked.

## 1. Purpose

Wave A found several serious-looking issues. Wave B does **not** repeat the broad review and does not vote on Wave-A severity labels.

Its job is to determine, for each serious finding cluster:

1. whether the claimed gap actually exists in accepted authority;
2. whether it blocks IMP-0001, a later slice, or neither;
3. whether the issue is semantic/architectural, verification-only, or implementation-local;
4. what exact uncertainty remains after adversarial challenge.

Do not design fixes until a gap survives prosecution/defense challenge.

## 2. AI-use design

Wave B follows the project method review plus current multi-agent/evaluation practice:

- one fresh chat per task;
- frozen canonical baseline;
- narrow issue bundles;
- prosecution and defense use **separate contexts**;
- neither side reads the other's return before finalizing;
- same evidence bundle, different burden of proof;
- no majority voting;
- explicit counterexamples and source citations;
- inconclusive is allowed;
- solution-design/experiment tasks are contingent on adjudication;
- Master Architect synthesizes evidence; agents do not promote authority.

Same-model agents have correlated errors. Where practical, assign prosecution and defense within one cluster to different capable model families/providers or reasoning configurations. This is desirable, not mandatory.

## 3. Stage B0 — blind sentinel replication

Run these before using Wave-A consensus as evidence:

1. `TRES-0010B-SENTINEL_SEMANTIC_REACHABILITY.md`
2. `TRES-0010D-SENTINEL_VERIFICATION_CHEAT.md`

Sentinels:

- use the original frozen Wave-A baseline `tres-0010-review-baseline`;
- do not read any Wave-A report;
- independently rerun the original B/D falsification objectives;
- report overlaps and novel findings only after the independent report is locked.

## 4. Stage B1 — prosecution / defense clusters

Run eight tasks, preferably in parallel after B0 launch:

### Cluster T — temporal / conflict composition

Evidence under challenge:

- TRES-0010C-F01 — mixed bounded attitude reactions may be order-sensitive;
- TRES-0010C-F02 — multiple accepted residence changes may be order-sensitive;
- TRES-0010H-H002 — accepted role-scoped action versus same-cycle authority destruction.

Tasks:

- `TRES-0010B-T-PROSECUTION_TEMPORAL_CONFLICT.md`
- `TRES-0010B-T-DEFENSE_TEMPORAL_CONFLICT.md`

### Cluster A — lower-level action / favour closure

Evidence under challenge:

- TRES-0010H-H001 — called-favour fulfilment can spawn undefined nested action/response semantics;
- TRES-0010E-F02 — general personal candidate generation is broader than pinned policy;
- TRES-0010E-F03 — called-favour callable-action grammar is open;
- TRES-0010E-F05 — explicit benefit-for-favour at favour-capacity limit is ambiguous;
- TRES-0010B-B002 — grain-valued action quantities lack an explicit validity domain.

Tasks:

- `TRES-0010B-A-PROSECUTION_ACTION_CLOSURE.md`
- `TRES-0010B-A-DEFENSE_ACTION_CLOSURE.md`

### Cluster F — formation / lifecycle reachability

Evidence under challenge:

- TRES-0010B-B001 — CandidateOrganization lifecycle/equivalence;
- TRES-0010B-B003 — exogenous actor departure semantics;
- TRES-0010B-B004 — exit-side continuity warrant coverage;
- TRES-0010B-B005 — rejoin/re-exit lineage-source selection.

Tasks:

- `TRES-0010B-F-PROSECUTION_FORMATION_LIFECYCLE.md`
- `TRES-0010B-F-DEFENSE_FORMATION_LIFECYCLE.md`

### Cluster I — implementation assurance / handoff integrity

Evidence under challenge:

- TRES-0010D-001..005 — grader authorship, oracle circularity, profile overfit, held-outs, applicability;
- TRES-0010E-F01/F04/F06/F07 — Slice-1 scope, KnownFact handoff, applicability, auditable criteria;
- TRES-0010F-F01..F04 — future-slice seams;
- TRES-0010I-F01..F04 — scope/minimality;
- TRES-0010J-F01..F03 — authority/navigation handoff;
- TRES-0010G implementation hazards, especially snapshot aliasing.

Tasks:

- `TRES-0010B-I-PROSECUTION_IMPLEMENTATION_ASSURANCE.md`
- `TRES-0010B-I-DEFENSE_IMPLEMENTATION_ASSURANCE.md`

## 5. Evidence access rule

Each B1 task may read:

- accepted/canonical artifacts from the frozen Wave-B baseline declared in the dispatch guide;
- only the Wave-A reports explicitly named by its packet;
- the original Wave-A task packet for those reports if useful.

It must not read:

- the opposing Wave-B return;
- unrelated Wave-A returns;
- proposed Master Architect fixes;
- future Wave-B design/experiment outputs.

The task should distinguish evidence inherited from Wave A from independently verified evidence.

## 6. Burdens of proof

### Prosecution

Must show:

- an exact accepted-artifact gap or contradiction;
- the smallest valid counterexample/cheating implementation;
- why existing authority cannot resolve it without invention;
- whether it blocks Slice 1 or only a later slice.

It should actively try to falsify the finding as part of the analysis. Advocacy without self-attack is weak evidence.

### Defense

Must try to show one of:

- existing accepted authority already uniquely resolves the case;
- the allegedly missing choice is safely local/reversible implementation discretion;
- the finding is real but cannot affect IMP-0001 and can be formally deferred;
- the counterexample relies on an invalid state/action.

If defense cannot close the issue, it must state the exact unresolved semantic or verification choice. It must not invent a convenient implicit rule.

## 7. Required result state

For each challenged finding, return one of:

- `CONFIRMED_BLOCKER_SLICE1`
- `CONFIRMED_REPAIR_BEFORE_SLICE1`
- `CONFIRMED_LATER_SLICE_GAP`
- `IMPLEMENTATION_LOCAL_GUARD`
- `ALREADY_RESOLVED_BY_AUTHORITY`
- `FALSE_POSITIVE`
- `INCONCLUSIVE_NEEDS_EXPERIMENT`

Include exact evidence and confidence. Do not collapse these into pass/fail.

## 8. Stage B2 — contingent resolution design

Do **not** pre-run solution designers.

After B0/B1, the Master Architect creates a finding matrix. Only findings that remain:

- confirmed blocker/repair;
- or inconclusive needing experiment

receive a B2 task.

B2 forms:

- **semantic options analysis** — compare minimal rule choices without importing Wave-A preferred fix;
- **verification design** — construct a protected evaluator/manifest or independent oracle boundary;
- **technical experiment** — smallest probe where platform behavior or execution semantics are uncertain;
- **scope repair** — exact IMP/task diff where authority already answers the issue.

Every B2 proposal is still advisory.

## 9. Closure condition

Wave B closes when every high/blocker Wave-A finding has:

- sentinel/prosecution/defense evidence as applicable;
- a Master Architect disposition;
- a targeted B2 follow-up where evidence still cannot decide;
- explicit Slice-1 versus later-slice classification.

Only then may canonical repairs be proposed to the Director or made under existing delegated authority.


## 10. B2 status

Wave B0/B1 are complete and reconciled in:

- `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`

Targeted B2 decision-support is now prepared under:

- `B2/00_B2_README.md`
- `B2/01_B2_DISPATCH_GUIDE.md`

Frozen B2 baseline:

- ref: `tres-0010-b2-baseline`
- SHA: `0729e460af35668e5b911fa561bf8cec53204142`

Only the three B2 tasks should run. No further broad review is authorized before their reconciliation.
