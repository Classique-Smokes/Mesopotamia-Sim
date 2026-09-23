# Birth Run 001 — Master Architect Reconciliation

**Status:** OBSERVATIONAL CHECKPOINT COMPLETE / NO SLICE-1 REOPENING  
**Canonical run:** `RUN-0001_BIRTH`  
**Raw freeze:** `research/technical/SFL_V0_OBSERVATIONS/RUN-0001_BIRTH/RAW_FREEZE_RECORD.md`  
**Exploratory variants:** `research/technical/SFL_V0_OBSERVATIONS/EXPLORATORY_BATCH_001/`

## 1. Director observation

The Project Director's first-read identified a central pattern:

> The autonomous actors do not appear to value most of the available decision repertoire.

This is recorded as an observation about the reference policy's autonomous behavior, not as a change to accepted simulation semantics.

## 2. Cross-run confirmation

The eight predeclared exploratory worlds strengthen that observation.

Across 1,110 autonomous personal decisions in the eight 30-cycle variants, selected actions were:

- `OfferGift`: 801
- `Farm`: 241
- `RequestGiftOrHelp`: 68

No other personal action type was selected.

Across those same variants:

- debts created: 0;
- favours created: 0;
- marriages created: 0;
- residence transitions: 0.

This pattern is therefore not peculiar to the canonical Birth Run 001 initial state.

## 3. Architectural explanation

The accepted agency architecture in ADR-0002 deliberately separates:

- accessible candidate generation;
- transparent component scoring;
- persistent goals/intentions;
- later planning;
- interpersonal proposals and world resolution.

ADR-0002 explicitly leaves exact tier content, scoring formula, subjective-information model, planner algorithm, reconsideration timing, and historical parameters open.

The current default `PersonalAgency` scorer identifies itself as **replaceable laboratory preferences, not additional social rules**.

Its default positive concerns are narrow:

- urgent NeedRelief through `RequestGiftOrHelp`;
- `Farm` while grain is below 4;
- `RepayDebt`;
- `OfferGift` weighted by attitude/kinship;
- marriage;
- co-residence.

Several otherwise-valid actions have no positive default concern. When candidate scores tie, the disclosed stable candidate key resolves the tie.

Therefore the narrow autonomous action vocabulary is best understood as a **reference-policy limitation**, not absence of substrate capability.

## 4. Classification

### Implementation defect

**No demonstrated Slice-1 defect.**

Independent K4 already established conformance for the exact promoted candidate, and the observations do not contradict accepted Slice-1 semantics.

### Verification blind spot

**No immediate verification repair required.**

Verification deliberately exercises mechanisms through controlled worlds and does not claim that the default autonomous policy will spontaneously visit every valid action/state region.

The observational result is informative about autonomous exploration breadth, not acceptance completeness.

### Accepted-model issue

**Not established.**

The runs do not demonstrate that debt, favour, marriage, residence, or other accepted mechanisms are semantically wrong.

### Temporary parameter/reference-policy issue

**YES — primary classification.**

The default policy is too low-dimensional to serve as a rich autonomous social model. Its stable tie-breaking can also become behaviorally consequential when many candidates have equal neutral scores.

### Missing later-slice capability

**YES, but narrowly.**

Slice 2 is the accepted point for actor-specific knowledge/recognition and minimal individual-agency integration. It should make subjective differences causally observable.

However Slice 2 should not be treated as permission to invent a complete motivation system, strategic planning, historical calibration, or arbitrary new preference weights.

### Conceptual research signal

**YES.**

Slice 1 demonstrates that an expressive causal substrate can remain behaviorally dormant when the agent policy does not value routes into those states. Later design should continue separating:

- legal/possible action;
- known/recognized action context;
- motivation/preference;
- planning;
- resolution;
- durable consequence.

## 5. Special long-run experiment

The isolated every-other-cycle-consumption 1,000-cycle experiment is secondary evidence only.

It showed a 40-cycle affine limit cycle under a noncanonical consumption cadence, with one actor's grain diverging because stable fallback repeatedly selected `Farm` among neutral-scoring alternatives.

This reinforces the reference-policy sensitivity finding, but it does not modify canonical SFL semantics.

The experimental branch remains isolated and must not be promoted.

## 6. Completion of Birth Run checkpoint

The Slice-1 observational pause has served its purpose:

- raw autonomous history was preserved before interpretation;
- the Project Director performed first-read;
- additional initial-state variants tested whether the central observation was world-specific;
- findings were classified before any model change;
- no Slice-1 repair is justified by the evidence.

**Birth Run 001 checkpoint: COMPLETE.**

## 7. Next architectural problem

The highest-leverage unresolved problem is now:

> What exact accepted Slice-2 subjective-knowledge/recognition machinery must become executable, and what minimal agency integration is required so those subjective differences can causally affect action without inventing richer motivation or global omniscience?

Before implementation, perform a bounded Slice-2 discovery/inventory against:

- accepted SFL v0 semantics;
- Slice-2-deferred verification authority;
- current Slice-1 implementation surfaces;
- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
- `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` as question generator only.

Any consequential unanswered semantic choice must be escalated through the normal research/design/promotion path rather than decided by implementation.
