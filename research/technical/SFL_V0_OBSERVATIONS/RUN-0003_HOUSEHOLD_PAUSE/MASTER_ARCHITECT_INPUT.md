# IMP-0003 Slice-3 Post-Implementation Observation — Master Architect Input

**Task:** `IMP-0003-OBS-001`  
**Observed production revision:** `f7ca9525d17ed20758058df7aff97b2f47e5a01a`  
**Frozen raw archive:** `c37c20e8c5d7419cd90b55dcb9da31ad3891bdb3`  
**Observation disposition:** learning return only; no Slice-3 authority change and no new acceptance gate.

## 1. What surprised us?

Four things were materially useful.

First, autonomous reachability was narrower than the existence of the Slice-3 machinery might suggest. In the declared Mode-A world, all 72 personal decisions selected `Farm`; no qualifying support or communication occurred, so CandidateRecognition and Household formation never became reachable. The trace makes this a reference-policy result: many eligible actions had equal score 0 and the deterministic tie resolution selected `Farm`.

Second, actor knowledge boundaries were sharper than a structural narrative intuition. A current sustaining participant did not automatically observe every continuation. Exit-caused continuation evidence went to the direct transition participant, and terminal dissolution evidence went only to the terminal exiting participant. Explicit communication was needed to make later evidence current for another actor.

Third, stable H identity and warrant chaining were easier to explain than expected. H1 remained H1 through entry, founder turnover, `Inactive`, and final dissolution; the transition history carried the identity explanation rather than requiring endpoint reconstruction. Controlled lineage also remained cleanly separate from identity.

Fourth, the long assisted narrative exposed an observation-design coupling: ordinary consumption exhausted material stock before later intended controls. That blocked fresh support/reactivation and prevented one side of a planned connected-loan control from executing. This is valid lower-slice runtime behavior, not a Slice-3 defect.

## 2. What matters for Slice 4 or later?

The strongest forward constraints are implementation-facing:

- role or representative Recognition should retain actor-specific evidence provenance and accepted communication/update routes;
- current membership or current role possession should not be used as a proxy for having observed every authority transition;
- dependency grouping for role transitions must include prospective/non-holder people whose same-cycle state can affect admission, appointment, succession, or eligibility;
- stable Household identity is a good anchor for later role warrants, while lineage should remain a distinct relation;
- provision/resource backing should stay distinct from institutional authority; derived capacity should not silently become a treasury or spending right;
- authority narratives will need to expose evidence freshness/origin/hops, not only a final recognition enum;
- future role observations should use short episodes or explicitly budget material maintenance so resource exhaustion does not confound the authority mechanism.

The residence/admission conflict is the clearest concrete warning: P5 was not yet a Household participant, but its residence transition was already consequential to its admission in the same cycle.

## 3. What is only narrow reference-policy reachability?

Mode A.

The observed absence of CandidateRecognition and Household formation is not a statement that Slice-3 mechanisms are unreachable in the model. It says that, in this small declared world under `SFL-PERSONAL-REFERENCE-v1`, the reference scorer repeatedly tied eligible choices and selected `Farm`.

The missing voluntary behaviors were qualifying support across cycles and communication of that evidence. Assisted Mode B showed that once ordinary public actions and communications supplied those conditions, production formed H automatically.

This is therefore a **reference-policy limitation**, not an accepted-model issue and not a reason to require richer agency before Slice 4.

## 4. What implementation abstraction/interface became cleaner or harder than expected?

### Cleaner

**Stable Household identity + warrant chain.** Entry and exit changed associations while explicit continuations preserved the same H. Lifecycle and lineage were inspectable without hidden identity reconstruction.

**Derived provision interface.** One controlled backing commitment plus current personal state was enough to explain capacity. A personal gift reduced capacity without any Household spending action, and participation exit terminated the backing.

**Lineage provenance.** The controlled division descendant cited the successor formation, predecessor exits, and fresh evidence directly.

### Harder

**Recognition freshness.** `Recognized` alone is too coarse for causal explanation. The raw evidence identities and communication hops are what distinguish stale from updated recognition.

**Prospective-person dependencies.** Same-cycle consequences can involve someone who is not yet a participant. Dependency logic built only from current institutional membership would miss exactly the residence/admission class already repaired in Slice 3.

**Trace terminology.** Personal decision tie fallback and semantic counterfactual fallback both use a `TechnicalFallback` field on different trace types. Machine evidence is unambiguous, but compact human summaries can conflate them.

**Long integration narratives.** Ordinary maintenance can consume the resources needed by a later mechanism under observation.

## 5. Is any new research/verification trigger justified?

No new conceptual research stop is justified.

A narrow **future verification-design trigger** is justified if Slice 4 introduces representative-role transitions: acceptance planning should explicitly include cases where

1. a prospective role actor is affected before becoming a holder/member;
2. current structural status does not imply observation of an authority transition;
3. stale role/Household recognition requires an explicit accepted update route;
4. terminal revocation/dissolution knowledge is tested at its direct causal participant boundary;
5. technical fallback is distinguished from ordinary scoring ties and remains attached only to consequential resolution noncommutativity.

These are test-design prompts derived from the existing architecture, not new accepted role semantics.

The observation itself did **not** independently re-demonstrate the repaired allocation-ID/no-fallback connected-allocation case because one planned loan was infeasible after material depletion. That sub-question remains **insufficient evidence** here; the accepted repair-v4 verification remains the relevant evidence.

## 6. Is there any reason to pause before Slice 4?

**No.**

The observation found no implementation defect, no verification blind spot, no conformance regression, no Household identity/persistence inconsistency, and no new missing consequential Slice-3 rule.

The two limitations found are non-blocking:

- autonomous Slice-3 activation is narrow under the current reference policy;
- long observation narratives can be materially confounded by lower-slice maintenance.

Neither requires richer agency or a Slice-3 semantic change before representative-role work begins.

The useful carry-forward is architectural: preserve actor-specific provenance, use the stable H/warrant interfaces, include prospective-person dependencies in role resolution, keep resource backing separate from authority, and make role-transition explanations evidence-aware.
