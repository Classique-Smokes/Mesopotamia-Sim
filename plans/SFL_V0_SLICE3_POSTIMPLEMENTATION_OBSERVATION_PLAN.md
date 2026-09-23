# SFL v0 Slice 3 — Post-Implementation Learning Observation Plan

**Status:** PREPARED / RUN ONLY AFTER IMP-0003 PROMOTION  
**Authority:** observational project-learning plan; not simulation authority and not an acceptance gate  
**Trigger:** IMP-0003 fresh conformance `PASS — PROMOTE` + canonical promotion + post-merge CI PASS  
**Purpose:** learn only the surprising implementation/runtime facts that should inform later slices, especially Slice 4 planning.

## 1. Principle

This observation is not another verification phase.

Frozen acceptance answers:

> Does the Slice-3 machinery implement the accepted semantics correctly when exercised?

This observation asks:

> Now that the machinery exists together in one runnable kernel, what did we learn that we could not confidently know before implementing it?

Only preserve findings that materially change:

- future implementation expectations;
- future risk maps;
- observability needs;
- likely interaction seams;
- later research questions;
- confidence about which abstractions are actually useful.

Do not manufacture lessons merely because the checkpoint exists.

## 2. Source before running

Retrieve:

- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
- the IMP-0003 final completion/promotion record;
- the frozen Slice-3 authority;
- the promoted implementation report;
- only then, if useful, `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md`.

The conceptual source is a question generator, not an answer key.

## 3. Two lightweight observation modes

### A. Autonomous reachability run

Purpose: measure what the current narrow personal policy actually reaches without scripting Slice-3 social outcomes.

Use:

- public production autonomous-cycle path only;
- a small declared world;
- no per-cycle forced Household outcomes;
- no verification-only mutation/challenge hooks.

Record:

- whether any CandidateRecognition emerges autonomously;
- whether any Household forms;
- whether participation change, lifecycle change, lineage, or provision backing become reachable at all;
- which missing voluntary behaviors prevent reachability when they do not occur;
- whether the new Household substrate changes lower-level autonomous behavior even when higher-order transitions do not activate.

A result of “almost nothing happens” is useful evidence about the reference policy, not a Slice-3 failure.

### B. Activation-assisted causal narrative

Purpose: observe the implemented Slice-3 machinery as one continuous comprehensible history rather than as isolated acceptance rows.

Use only legitimate public inputs/actions/communications and manifest-authorized controlled prerequisites.

Construct one bounded narrative that, where practical, visibly includes:

1. lower-level support/evidence accumulation;
2. founder CandidateRecognition;
3. automatic Household formation;
4. founder Household Recognition;
5. one participation entry;
6. one participation exit;
7. continuity across turnover;
8. Inactive and reactivation or dissolution;
9. one Household Recognition stale/update episode;
10. one controlled lineage event if the narrative remains readable;
11. provision backing/capacity changing with personal state without spending.

Do not force every feature into one unreadable mega-scenario. Split into two small narratives if causal legibility would improve.

## 4. What to look for

### Causal legibility

Can a human explain Household existence and identity from the retained history without reading implementation code?

Can we narrate:

- why H formed;
- why it remained the same H;
- why an actor recognized or did not recognize it;
- why lineage did or did not classify;
- where provision capacity came from?

### Unexpected interaction pressure

Look specifically for surprises around:

- action/state dependencies not obvious from the frozen semantics;
- reaction ordering;
- recognition propagation;
- participation/residence interaction;
- continuity/lifecycle interaction;
- lineage source history;
- derived-state refresh;
- technical fallback frequency;
- observability gaps.

### Reference-policy reachability

Distinguish:

- machinery that exists but autonomous policy never invokes;
- machinery that autonomous behavior can actually reach;
- exact voluntary motivations that are missing and therefore prevent activation.

This should inform future agency work without pulling that work into Slice 4 by accident.

### Future Slice-4 implications

Record only implementation-grounded surprises relevant to office/representative mechanics, such as:

- which Household state transitions make authority races likely;
- which Recognition paths will matter for head Recognition;
- whether role actions will need dependency surfaces not previously obvious;
- whether Household identity/lifecycle interfaces are clean enough for an office layer.

Do not decide Slice-4 semantics from this run.

## 5. Already-known implementation surprises to revisit observationally

The coding candidate reported two implementation discoveries worth checking in a running history if IMP-0003 is promoted:

1. newcomer residence/admission can create a same-cycle dependency even before the newcomer is a participant;
2. direct dissolution knowledge must be restricted to the actor who actually participates in the terminal exit rather than leaking cycle-wide to earlier leavers.

The observation should ask whether these repaired distinctions remain causally understandable in ordinary histories.

Do not reopen them solely because they were surprising during coding.

## 6. Raw-first discipline

Preserve raw outputs before interpretation.

Recommended location:

`research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/`

Keep:

- exact promoted revision/configuration;
- declared initial states;
- input schedule where activation-assisted;
- semantic history;
- decision history;
- relevant epistemic/Household snapshots;
- readable mechanical transcript;
- compact reachability summary.

Interpretive notes come after raw freeze.

## 7. Finding classification

For every material surprise classify it as:

- implementation defect;
- verification blind spot;
- accepted-model issue;
- reference-policy limitation;
- missing later-slice capability;
- implementation/architecture lesson for later slices;
- conceptual research signal;
- observability/tooling issue;
- interesting but non-actionable;
- insufficient evidence.

Only defects/blind spots normally interrupt the roadmap immediately.

## 8. Required reconciliation output

After observation, write one compact Master Architect reconciliation answering:

1. What surprised us?
2. Which surprises matter for Slice 4 or later implementation?
3. Which are merely consequences of the intentionally narrow current policy?
4. Did the implementation reveal any abstraction/interface that is harder or cleaner than expected?
5. Is any new research/verification trigger justified?
6. Is there any reason to pause before Slice 4?

“No material new lesson” is an acceptable result.

## 9. Boundary

This plan:

- does not alter IMP-0003 completion;
- does not block promotion;
- does not create new accepted semantics;
- does not require richer agency before Slice 4;
- does not claim historical realism;
- does not substitute runtime observation for conformance review.

Its purpose is simply to avoid throwing away the information gained by actually building and running the slice.
