# IMP-0002 — Future Lessons Index

**Status:** MAINTENANCE SYNTHESIS / NON-AUTHORITATIVE  
**Scope:** Durable future-facing lessons from SFL v0 Slice 2 implementation, fresh conformance, and epistemic observation  
**Purpose:** Make the surprising/reusable lessons of IMP-0002 retrievable without requiring future architects to reconstruct them from implementation, review, and observation records.  
**Does not:** reopen Slice 2, change accepted semantics, create new requirements, or promote deferred ideas.

## Source record

This index is derived from:

- `tasks/implementation/IMP-0002_IMPLEMENTATION_REPORT.md`;
- `research/technical/IMP-0002/IMP-0002_INDEPENDENT_CONFORMANCE_REVIEW_FRESH.md`;
- `research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`;
- `research/technical/SFL_V0_OBSERVATIONS/RUN-0002_EPISTEMIC_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md`;
- `research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md`.

When this index conflicts with any accepted/frozen authority or the source records above, the higher-authority/source record controls.

## 1. Sparse actor-specific epistemic state was enough

Slice 2 did not need a global actor world-view, generic perception layer, or omniscient policy input.

The implemented actor-indexed epistemic partition remained explicit, immutable at the public boundary, and separate from objective state. Slice 3 could later extend that same pattern to Household Recognition rather than redesigning the epistemic architecture.

**Future implication:** prefer explicit sparse acquisition routes over broad objective-state exposure. A later system should add a new acquisition route only when accepted semantics require one.

## 2. Provenance mattered more than a richer belief scalar

The important implementation structure was not merely `Unknown / Recognized / Contested`.

Useful behavior depended on retaining:

- proposition identity;
- original source/event;
- underlying semantic order;
- communication/delivery hops;
- sender/recipient provenance.

That structure made stale state, correction, incompatible reports, and actor divergence causally inspectable.

**Future implication:** later recognition/authority systems should preserve provenance rather than replace it with a scalar confidence shortcut.

## 3. Message arrival is not semantic time

The implementation and fresh review confirmed that evidence precedence must follow accepted underlying event/provenance order, not:

- delivery time;
- sender ID;
- evidence ID;
- collection position;
- stable-ID fallback.

Late old information must not overwrite newer accepted evidence merely because it arrived later.

**Future implication:** later communication, succession, authority, and institutional-memory work should treat transport order and semantic event order as distinct dimensions.

## 4. Decision and commit validity must remain separate

Slice 2 exposed a concrete same-cycle case:

- an actor legitimately selected communication from the common decision snapshot;
- another accepted action could change the underlying fact before commit;
- the captured communication then became invalid because the sender no longer held the proposition.

The correct result was commit-time invalidation, not rewriting the earlier decision trace as though the actor had chosen differently.

**Future implication:** later action systems should preserve the distinction between:
- what an actor decided from its snapshot;
- whether that intended action still satisfies objective/subjective preconditions at commit.

## 5. Detached dependency projection scaled without becoming social authority

`ResolutionDependencies` was extended to account for epistemic interactions through detached projection rather than by replacing the existing scheduler.

The fresh reviewer found that:

- projection used copied state;
- it did not allocate live semantic IDs;
- it did not publish hypothetical state;
- it did not rerun policy;
- it disclosed consequential noncommutativity without inventing a Recognition winner rule.

**Future implication:** extending the existing deterministic dependency/revalidation machinery is preferable to creating subsystem-specific schedulers, provided technical ordering remains quarantined from social meaning.

## 6. Bounded typed semantics beat premature universal frameworks

Slice 2 deliberately avoided solving:

- universal factual-conflict algebra;
- general proposition ontology;
- generic nonparticipant observation;
- trust/reliability;
- lying/rumor/reputation;
- generic evidence-strength ranking.

A finite typed proposition vocabulary plus bounded accepted precedence was sufficient for the slice and remained extensible into Slice 3.

**Future implication:** do not generalize epistemic machinery merely because a future model could use a universal framework. Add abstractions only when multiple real semantics force them.

## 7. Recognition is not attitude, approval, or obedience

Implementation and conformance independently exercised:

- negative unrelated Attitude;
- voluntary refusal/Decline;

while Recognition evidence remained unchanged.

Recognition therefore remained intact.

**Future implication:** Slice 4 office/head Recognition must not silently become liking, legitimacy approval, loyalty, or obedience. Those are separable future dimensions.

## 8. Epistemic mechanics were richer than autonomous epistemic behavior

The observational pause showed a strong asymmetry:

- the engine could represent divergent knowledge, stale information, correction, communication provenance, and Contested Recognition;
- the autonomous reference policy overwhelmingly selected `Farm` and `OfferGift`;
- autonomous communication motivation did not emerge.

World A therefore stayed `Unknown` despite objective co-residence, durable ties, and repeated support.

**Future implication:** do not use autonomous reachability alone as evidence that a newly implemented substrate is absent or broken. Reference-policy reachability and mechanism correctness are separate questions.

## 9. Activation-assisted laboratory observation is legitimate when causal results remain endogenous

World B used a controlled communication pulse schedule to exercise the real epistemic machinery.

The important states—Recognized, stale, corrected, Unknown, Contested, and action gating—were produced by the engine through ordinary accepted routes rather than fixture-written as outcomes.

**Future implication:** when the reference policy cannot naturally reach a mechanism, controlled public-path activation may be used for understanding, provided:
- the causal result under study is not directly fixture-written;
- provenance remains visible;
- the run does not claim autonomous motivation that is not implemented.

This method directly informs later inter-slice observation design.

## 10. Anti-omniscience became an institutional-design constraint

The Slice-2 observation made a future Household lesson vivid before Household identity existed:

> objective social structure does not imply actor recognition of that structure.

Aru and Bela could objectively satisfy much of the lower-level formation situation while still lacking the actor-held evidence required for CandidateRecognition.

**Future implication:** higher-order entities must remain downstream of actor-held evidence where accepted semantics require recognition. Engine-global structure must not silently substitute for social knowledge.

## 11. CandidateRecognition exposed the first unresolved organization-equivalence seam

Slice 2 intentionally used one inert bounded candidate referent and did not solve general candidate equivalence/convergence.

That restraint exposed the real future question rather than hiding it behind implementation convenience. The issue became `LATER-01` and was explicitly bounded during Slice-3 planning.

**Future implication:** when a bounded laboratory referent starts needing reconciliation with multiple independently arising referents, treat that as a semantic trigger—not a reason to choose equivalence by stable ID, label, or graph similarity.

## 12. What did not become a lesson

The following remained explicitly unresolved/deferred rather than being inferred from Slice 2:

- realistic autonomous communication motivation;
- trust, lying, rumor, reputation;
- general nonparticipant observation;
- general contradiction/evidence-strength theory;
- rich memory decay;
- role-conditioned salience;
- Household/head/office semantics;
- checkpoint persistence.

Their continued absence is not a Slice-2 defect.

## Retrieval value

Future slice planning should retrieve this file when work touches:

- actor-specific information/Recognition;
- communication provenance;
- same-cycle epistemic dependencies;
- authority/role Recognition;
- autonomous reachability versus controlled mechanism activation;
- CandidateOrganization convergence.

The detailed evidence remains in the source records listed at the top.
