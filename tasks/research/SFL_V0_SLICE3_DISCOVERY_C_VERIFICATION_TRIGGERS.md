# SFL v0 Slice 3 Discovery C — Verification Trigger and Acceptance Applicability Map

**Task type:** fresh regular chat / clean context  
**Role:** verification authority mapper  
**Authority:** advisory return only; do not edit frozen manifests

## Purpose

Determine exactly which accepted Stage-3 verification obligations become live for Slice 3 and what a separate Slice-3 acceptance/applicability authority must make omission-detectable.

Do not modify frozen Slice-1 or Slice-2 manifests.

## Required sources

Retrieve independently:

- accepted SPEC/ADRs;
- all canonical `plans/verification/SFL_V0/*` families;
- frozen Slice-1 and Slice-2 manifests/freeze records;
- Slice-1 and Slice-2 completion records;
- current deferred-gap ledger;
- current production/test boundary;
- Slice-2 observation reconciliation.

## Mandatory work

### A. Triggered canonical verification cards

Classify every relevant card/family as:

- REQUIRED for Slice 3;
- regression-protected inherited requirement;
- DEFERRED to Slice 4;
- DEFERRED to Slice 5;
- still future/unexercised.

At minimum inspect:

- Formation family;
- Continuity / Turnover family;
- No-Self-Confirmation family;
- Recognition / Information family;
- Lineage family;
- Provision Grounding family;
- Resolution / Reaction family;
- Determinism / Recovery / Explainability;
- cross-cutting locality/cache/fallback/manifest integrity obligations.

### B. Completion witnesses

Identify the minimum independently observable Slice-3 witnesses needed for:

- formation from lower-level history;
- founder recognition causality;
- no primitive Household creation;
- warrant provenance;
- no hidden Members set;
- participation entry and end;
- complete founder turnover / stable identity;
- broken-bridge negative control;
- Inactive reactivation;
- same-cycle bridge handoff;
- Dissolution/no resurrection;
- duplicate-formation/continuity precedence;
- household existence/continuity subjective recognition;
- provision commitment / grounded capacity if within Slice-3 boundary;
- lineage if within Slice-3 boundary.

### C. Fixture authority

For each major witness identify what may be fixture-seeded and what must never be written directly.

The acceptance design must prevent:

- writing Household;
- writing FormationWarrant/ParticipationWarrant/ContinuationWarrant;
- writing lifecycle result;
- writing final household recognition;
- writing provision-spend result;
- using a Household ID as proof it already exists.

### D. Oracle independence

Identify where production formation/continuity/candidate-recognition helpers could otherwise grade themselves.

Require suitable independent predicates / metamorphic pairs.

### E. Deferred hardening triggers

Determine which VH items are now mandatory completion evidence, especially VH-01, VH-03, VH-05, VH-06.

### F. Prior-slice regression protection

Identify exact Slice-1 and Slice-2 obligations most vulnerable to household implementation, including:

- objective/subjective separation;
- no passive sync;
- communication/provenance;
- initiative accounting;
- observer noninterference;
- locality;
- fallback quarantine;
- cache nonauthority;
- stable cycle closure;
- current person-level relation semantics.

### G. Acceptance-authority readiness

State what unresolved item, if any, prevents drafting/freeze of a Slice-3 acceptance manifest.

## Required return

Create:

`research/technical/SFL_V0_SLICE3_VERIFICATION_TRIGGER_MAP.md`

on branch:

`research/slice3-verification-trigger-return`

from canonical main and record exact base SHA.

End with:

- triggered requirements;
- deliberate deferrals;
- new Slice-3 completion witnesses;
- exact inherited regressions;
- acceptance-manifest blocker status.
