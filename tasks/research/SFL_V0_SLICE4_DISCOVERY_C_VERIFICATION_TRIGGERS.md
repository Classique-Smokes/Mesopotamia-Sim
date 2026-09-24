# SFL v0 Slice 4 Discovery C — Verification Trigger and Acceptance Applicability Map

**Task type:** fresh regular chat / clean context  
**Role:** verification authority mapper  
**Authority:** advisory return only; do not edit frozen manifests

## Purpose

Determine exactly which accepted Stage-3 verification obligations become live for Slice 4 and what a separate Slice-4 acceptance/applicability authority must make omission-detectable.

Do not modify frozen Slice-1/2/3 manifests.

## Required sources

Retrieve independently:

- accepted SPEC/ADRs;
- all canonical `plans/verification/SFL_V0/*` families;
- frozen Slice-1/2/3 manifests + freeze records;
- Slice-1/2/3 final completion records;
- current deferred-gap ledger;
- current promoted production/test boundary;
- `research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md`;
- RUN-0003 Master Architect reconciliation.

## Mandatory work

### A. Triggered canonical verification cards

Classify every relevant card/family as:

- REQUIRED for Slice 4;
- regression-protected inherited requirement;
- DEFERRED to Slice 5;
- still future/unexercised.

At minimum inspect:

- Head Role / Vacancy / Succession / Dual-Mode family;
- Provision Grounding family;
- Recognition / Information family;
- Resolution / Reaction family;
- Response Decision family;
- Determinism / Recovery / Explainability;
- cross-cutting locality/cache/fallback/authority-integrity obligations;
- Household continuity/lifecycle regressions from Slice 3.

### B. Completion witnesses

Identify the minimum independently observable Slice-4 witnesses needed for:

- newly formed H is headless;
- valid initial appointment;
- nominee decline;
- missing unanimity;
- invalid nonparticipant nominator/nominee;
- vacancy after head participation end without H destruction;
- succession A→B with same H and same role identity;
- stale outsider Recognition of predecessor;
- accepted correction route to successor;
- head personal + Household contexts both activate from same snapshot;
- compatible personal/Household actions both commit;
- personal/Household conflict resolves centrally;
- scoped-authority negative action census;
- provision solicitation/commitment acquisition;
- reconsideration cooldown/context-change;
- support expenditure;
- multi-contributor fixed-rank debit;
- mediated-marriage dowry;
- provision priority;
- authority-dependent invalidation/races;
- Inactive/vacant Household no initiative.

### C. Role identity / occupancy / Recognition oracle requirements

Specify what independent verification must reconstruct without using production role classifiers as expected answers.

At minimum make omission-detectable:

- role ID persistence;
- occupancy transitions;
- exact nomination/acceptance/unanimity evidence;
- current participant eligibility;
- direct transition-participant Recognition;
- outsider staleness;
- correction provenance;
- no global sync;
- no auto-election fallback;
- no role recreation on succession.

Identify detached corruptions/metamorphic controls appropriate for these claims.

### D. Fixture authority

For each major witness, identify what may be fixture-seeded and what must never be written directly.

The acceptance design must prevent direct fixture writes of:

- occupied head result;
- appointment/succession warrant/result;
- final head Recognition under test;
- HouseholdDecisionContext outcome under test;
- provision commitment when endogenous acquisition is under test;
- contributor debit/spend result;
- mediated-marriage result/favour under test.

Bounded lower-level facts and already-promoted Household states may be reused only with explicit producer provenance.

### E. Dual-mode / initiative accounting

Require evidence that:

- head retains one personal initiative;
- H receives one separate Household initiative;
- neither silently consumes the other;
- both deliberate from the same committed snapshot;
- responses remain separate from initiative accounting;
- Household scoring uses Household concerns/capability, not reused personal score;
- role does not create a separate omniscient subjective state.

Identify inherited Slice-1/2 initiative/response obligations at greatest regression risk.

### F. Same-cycle authority / dependency triggers

Use the Slice-3 observation only as a risk lens.

Require candidate Slice-4 acceptance to make omission-detectable for prospective/non-holder dependencies, including cases where:

- nominee eligibility/state changes before occupancy;
- head exits/vacates while an authority-dependent action is pending;
- succession changes current holder before another authority-dependent commit;
- H becomes Inactive/Dissolved before Household action commit;
- provision capacity changes;
- head Recognition becomes stale/Contested;
- personal and Household actions compete for shared backing.

Classify each as:

- already required by canonical card;
- new Slice-4 completion witness needed;
- semantic gap requiring authority decision.

### G. Fallback / ordering quarantine

Identify exact tests needed to prevent:

- proposal/container ID becoming social appointment priority;
- majority/autoelection fallback;
- allocation-ID noise creating false technical conflict;
- scoring-tie fallback being confused with central-resolution fallback;
- technical fallback selecting among semantically unequal authority states.

### H. Prior-slice regression protection

Identify exact inherited obligations most vulnerable to Slice-4 work, including:

- Household identity/continuity independent of role;
- actor-specific Recognition / no passive sync;
- communication provenance;
- personal initiative accounting;
- response accounting;
- observer noninterference;
- locality;
- fallback quarantine;
- stable closure;
- cache/derived nonauthority;
- provision capacity grounding;
- no pooled treasury;
- person-level actions remain independent of office.

### I. Acceptance-authority readiness

State what unresolved item, if any, prevents drafting/freeze of a Slice-4 acceptance manifest.

## Required return

Create:

`research/technical/SFL_V0_SLICE4_VERIFICATION_TRIGGER_MAP.md`

on branch:

`research/slice4-verification-trigger-return`

from canonical main and record exact base SHA.

End with:

- triggered requirements;
- deliberate deferrals;
- new Slice-4 completion witnesses;
- exact inherited regressions;
- oracle/corruption requirements;
- acceptance-manifest blocker status.
