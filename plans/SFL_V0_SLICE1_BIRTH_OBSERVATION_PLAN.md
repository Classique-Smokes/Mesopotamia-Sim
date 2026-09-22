# SFL v0 Slice-1 Birth / Observational Run Plan

**Status:** OPERATIONAL PLAN / NOT SIMULATION AUTHORITY  
**Trigger:** IMP-0001 independent conformance PASS + Master Architect completion reconciliation  
**Purpose:** Observe the verified Slice-1 kernel as a running simulation before beginning Slice 2, preserving raw autonomous history for direct Project Director inspection.

## 1. Why this exists

IMP-0001 acceptance proves that the implementation conforms to the accepted Slice-1 model.

It does **not** prove that the resulting autonomous dynamics are interesting, legible, historically promising, well calibrated, or free of undesirable-but-spec-conformant patterns when the mechanisms interact over time.

Before adding subjective recognition or later household/institutional layers, the project should therefore pause and observe the lower-level reference world as an object of study.

This is an **inter-slice observational checkpoint**, not Roadmap Stage 5 model iteration. Stage 5 remains the later full-prototype experimental/iteration phase after all five slices execute together.

## 2. Trigger and gate

Do not conduct the canonical birth run against an implementation candidate that has not passed independent conformance.

The birth-run sequence begins only when:

1. fresh independent K4 conformance returns PASS for the exact frozen Slice-1 candidate;
2. the Master Architect reconciles that PASS and records IMP-0001 as verified complete;
3. the verified implementation content is merged/promoted to canonical `main` without semantic/test-content drift.

If conformance returns BLOCK, repair/review takes precedence and this plan remains pending.

### Inter-slice pause

After Slice 1 becomes canonical, **do not begin Slice-2 implementation before the first autonomous observational package has been produced and inspected by the Project Director**, unless the Director explicitly waives this pause.

The purpose is observation and project understanding, not a new acceptance gate for Slice 1.

## 3. Three classes of run

Keep these categories distinct.

### A. Verification worlds — already part of implementation assurance

Purpose: prove exact semantic obligations.

Characteristics:

- deliberately constructed cases;
- explicit mechanism-isolation proposals where required;
- pass/fail expectations;
- acceptance authority.

These are not the birth run.

### B. Birth / observational worlds — this plan

Purpose: observe what the existing autonomous reference policy actually generates.

Characteristics:

- no scripted intended outcome;
- no per-cycle externally supplied voluntary proposals;
- production public simulation path only;
- raw history preserved before interpretation;
- qualitative and quantitative inspection;
- no automatic model changes.

### C. Experimental worlds — later

Purpose: deliberately vary initial conditions/configurations to answer bounded questions about observed dynamics.

These begin only after the baseline observational run has been read and useful questions have been formulated.

## 4. Canonical Birth Run 001

### 4.1 Revision identity

Record:

- exact repository commit/tree used;
- accepted configuration/profile versions;
- .NET SDK/runtime identity;
- command/runner identity;
- date/time of execution.

The run must use the same verified production kernel semantics. A runner may be added as local tooling after IMP-0001 completion, but it must not modify simulation meaning.

### 4.2 Runner boundary

The birth runner should:

- construct one declared `InitialWorld`;
- use public production APIs only;
- call `RunAutonomousCycle()` repeatedly;
- stop on the declared cycle horizon, material deadlock, or simulation fault;
- read only public `Snapshot`, `History`, `DecisionHistory`, and actor knowledge surfaces needed for reporting;
- never use `ReactionChallenge` or other verification-only internals;
- never inject per-cycle voluntary proposals after initialization;
- never supply candidate winners, scores, responses, or hidden state mutations.

The runner is observation tooling, not a new simulation subsystem.

### 4.3 Initial world design

The first world should be deliberately small enough for human causal reading while avoiding an immediate trivial deadlock.

Target size: approximately **4–5 people** and a small number of dwellings.

The initial state may include declared Slice-1 facts already supported by the kernel:

- starting grain;
- residence;
- a modest attitude pattern;
- limited kinship where useful;
- no initial debt/favour unless there is a strong reason to establish it through prior simulated history;
- marriage only if explicitly chosen as initial prerequisite state.

The exact initial world should be written down **before execution** and should not be tuned after seeing the resulting history.

It is not a historical reconstruction or calibration claim.

### 4.4 Horizon

Use a predeclared finite primary horizon, initially **30 cycles**, unless the simulation reaches material deadlock or faults earlier.

If the world remains active and the first 30 cycles expose dynamics that clearly require a longer observation window, preserve Run 001 unchanged and conduct a separately identified extension/Run 002 rather than rewriting the first run's horizon after the fact.

## 5. Preserve raw output before interpretation

The first run should leave a durable observation package under:

`research/technical/SFL_V0_OBSERVATIONS/RUN-0001_BIRTH/`

Suggested artifacts:

- `README.md` — revision/configuration/runner/initial-state provenance and stop reason;
- `INITIAL_WORLD.json` — exact declared initial state;
- `CYCLE_SUMMARY.csv` or JSON — compact state summary at each stable boundary;
- `SEMANTIC_HISTORY.json` — complete production semantic history;
- `DECISION_HISTORY.json` — complete production decision traces;
- `FINAL_SNAPSHOT.json`;
- `HUMAN_TRANSCRIPT.md` — mechanically rendered readable chronology without interpretation;
- `DIRECTOR_OBSERVATIONS.md` — created only after raw outputs are frozen;
- `MASTER_ARCHITECT_ANALYSIS.md` — later analytical synthesis, distinct from raw facts.

If raw artifacts are too large for durable repository storage, preserve a lossless machine-readable run artifact externally/through CI and commit a cryptographic identity plus a sufficiently complete human-readable transcript and summary. For the first small run, prefer keeping the complete result if practical.

## 6. What we inspect

The first read should ask what happened before asking whether it was “good.”

### Causal legibility

- Can important actions be explained from retained candidate/score/gate traces?
- Can resource and relationship changes be traced to committed causes?
- Does the history remain readable over many cycles?

### Autonomous behavior

- Which actions are actually generated and selected?
- Do agents repeatedly choose one dominant action?
- Do proposal/response interactions arise without scripted mechanism fixtures?
- Do debts, favours, marriage, or residence changes arise at all under the reference policy?

### Social dynamics

- Are persistent interaction loops visible?
- Do dependencies or asymmetric relationships develop?
- Do attitudes reinforce, decay, oscillate, or saturate?
- Does kinship materially alter trajectories without becoming a hidden gate?
- Does co-residence behavior look voluntary rather than mechanically compelled?

### Material dynamics

- How often does scarcity dominate action?
- Does the system deadlock quickly?
- Do loans/help/farming create intelligible recovery or dependency patterns?
- Are grain flows explainable and conserved except for declared source/sink events?

### Resolver/determinism visibility

- How often is stable-ID fallback actually used?
- Are same-cycle invalidations common?
- Are outcomes dominated by technical symmetry in a way that would matter later?

### Reference-policy pathologies

- Does the deterministic v0 scorer create obvious loops, brittleness, or repetitive behavior?
- Are strange outcomes clearly attributable to temporary coefficients/reference policy rather than substrate semantics?

## 7. Classification of observations

Do not turn “that looks weird” directly into a code change.

Classify each material observation as one of:

- **implementation defect** — behavior violates accepted semantics;
- **verification blind spot** — accepted behavior lacked sufficient test/evidence;
- **model/semantic issue** — implementation faithfully exposes a questionable accepted rule;
- **laboratory parameter/calibration issue** — temporary v0 coefficient/timing assumption creates undesirable dynamics;
- **reference-policy limitation** — deterministic policy is doing what configured but is too simple for desired behavior;
- **missing later-slice capability** — behavior is naturally limited because recognition/household/roles/checkpoint machinery does not exist yet;
- **observability/tooling issue** — simulation may be coherent but difficult to inspect;
- **interesting emergent behavior** — worth preserving/investigating, not automatically changing;
- **insufficient evidence** — one run does not justify a conclusion.

Consequential model/architecture changes still follow normal authority procedure.

## 8. Interpretation limits

Run 001 must **not** be used to claim:

- historical realism or calibration;
- Mesopotamian representativeness;
- success/failure of household or institutional dynamics not yet implemented;
- adequacy of final individual cognition;
- scalability;
- stochastic robustness;
- demographic/economic realism.

It is evidence about **the current Slice-1 reference system under one declared initial condition**.

## 9. Director inspection

The Project Director should receive the raw/transcript package before a Master Architect synthesis is treated as the main interpretation.

Recommended order:

1. initial-state card;
2. readable chronological transcript;
3. compact cycle summaries;
4. selected decision traces for surprising events;
5. Director's own observations/questions;
6. only after the Director's first read, retrieve `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` as a secondary interpretive lens;
7. Master Architect causal analysis, clearly distinguishing raw run facts from the conceptual interpretation;
8. only then decide whether any bounded follow-up experiment is useful.

This preserves human project authority at the first moment the simulator becomes an object of observation rather than only implementation.

## 10. Next-step outcomes

After Birth Run 001 and Director inspection, one of several outcomes may follow:

- proceed to Slice 2 unchanged;
- run one or more bounded observational variants before Slice 2;
- repair a genuine implementation defect and re-establish conformance as required;
- open a model/calibration question without blocking Slice 2;
- add observation tooling that does not alter semantics;
- revise future planning if the actual behavior exposes an important substrate limitation.

The observational checkpoint does not require the first world to look impressive. Its purpose is to learn what the verified machinery actually does.
