# TRES-0006 — Continuity / Lifecycle Scenario Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Narrow review of the proposed Stage-3 continuity/turnover scenario family and the proposed v0 lifecycle simplification `2+ SustainingParticipants = Active / 1 = Inactive / 0 = Dissolved`.

## 1. Baseline reviewed

Reviewed against:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- `research/technical/TRES-0001/returns/TRES-0001E_RESEARCH_REPORT.md`;
- `research/technical/TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`;
- Stage-3 verification workbench and proposed canonical turnover family.

## 2. Overall finding

The proposed lifecycle simplification is viable **only if it is explicitly scoped to operational activity state rather than numerical household identity**.

Recommended interpretation:

- household identity/continuity remains warranted historically by Formation/Participation/Continuation events;
- participant count only selects whether an already-existing household is currently operationally Active, dormant/Inactive, or permanently Dissolved in v0;
- no participant-count similarity or threshold may create/preserve identity by itself.

This preserves the project's process-first historical identity architecture.

The adversarial pass found four material issues that must be resolved before canonical continuity cards are authoritative:

1. current onboarding semantics make Inactive -> Active reactivation impossible;
2. lifecycle state must be evaluated at a stable resolution/reaction boundary, not after transient microsteps;
3. same-cycle bridge handoff needs an explicit causal ordering rule;
4. valid continuity/participation must take precedence over fresh-formation interpretation of the same evidence, or one social history can accidentally clone household identities.

It also found one restorative omission: the founding core minimum should be explicit as at least two distinct people.

## 3. Finding CLC-A — 2/1/0 can be a v0 activity rule, but not an identity rule

Project research already separates:

- current organization/activity;
- historical continuity;
- actor recognition.

TRES-0001E explicitly warns that identity is a historical relation rather than snapshot resemblance, and that dissolution means termination/loss of the relevant sustaining configuration rather than a mere missing observation.

External dynamic-group research similarly treats membership change and lifecycle as domain-dependent. Temporal-network work notes that community identity/lifecycle cannot be inferred from topology alone in general and may require domain-specific criteria. Organizational-identity work likewise shows continuity/change is not reducible to member turnover.

Therefore, the 2/1/0 count should be recorded as a **controlled v0 operational assumption**:

- **Active:** at least 2 current `SustainingParticipant` associations;
- **Inactive:** exactly 1 current `SustainingParticipant` association;
- **Dissolved:** 0 current `SustainingParticipant` associations.

Crucially:

- Formation/Continuation warrants, not this count, establish identity;
- the rule does not rerun the original formation predicate;
- Active does not mean every participant currently recognizes/likes/supports every other participant;
- Inactive preserves historical identity but disables household-mode capability;
- Dissolved is irreversible in v0.

The rule is simple enough for the first laboratory, but it must not be described as a universal household ontology.

## 4. Finding CLC-B — current participation entry contradicts Inactive reactivation

Current accepted text permits a nonparticipant to become `SustainingParticipant` only of an **active** H.

If Inactive is defined as one remaining participant, the proposed reactivation proof is impossible:

`H with A only -> Inactive -> D joins via ParticipationWarrant -> Active`

because D is prohibited from joining while H is Inactive.

### Recommended amendment

Participation invitation/request should be allowed for:

- Active H; or
- Inactive H with exactly one live continuity bearer.

For an Inactive H, that remaining bearer must be the bridging sustaining participant in the `ParticipationWarrant`.

A valid new association then moves H to Active at the stable lifecycle evaluation boundary.

This is a semantic amendment and requires Director approval together with the lifecycle rule.

## 5. Finding CLC-C — lifecycle status must be evaluated after stable resolution/reaction closure

### Risk

If lifecycle state is recomputed immediately after each low-level participation mutation, a same-cycle sequence can pass through transient counts:

`2 -> 1 -> 2`

or

`1 -> 2 -> 1`.

Treating the transient state as authoritative can:

- suspend capability spuriously;
- dissolve an identity before a causally linked entry is processed;
- make container/commit order decide continuity.

The accepted kernel already favors common-snapshot resolution and reaction closure. W3C SCXML provides a useful technical analogue: externally visible stable state is observed after a run-to-completion macrostep rather than at arbitrary intermediate microsteps.

### Recommendation

Participation commits remain individually recorded events, but `Active/Inactive/Dissolved` lifecycle reevaluation occurs only after the compatible participation-change resolution set and its required continuity reactions reach a stable same-cycle boundary.

Intermediate participant counts remain inspectable history but are not externally authoritative lifecycle states.

## 6. Finding CLC-D — same-cycle bridge handoff needs causal priority

Consider Inactive H with sole bearer A:

- D has a valid accepted participation entry using A as bridge;
- A has an accepted `EndHouseholdParticipation` in the same cycle.

Both were generated from the same snapshot.

If A's exit commits first, D's entry invalidates and H dissolves.
If D's entry commits first, the continuity bridge is real, then A may exit, leaving D as the new sole bearer of the same Inactive H.

Runtime iteration order must not decide this.

### Recommended v0 rule

Where an accepted `ParticipationWarrant` explicitly depends on participant P as its continuity bridge and P also has an accepted same-cycle participation end:

1. resolve/commit the valid participation entry first;
2. emit the corresponding continuity warrant/reaction;
3. then commit P's participation end if still valid.

This preserves an explicit historical handoff. Final lifecycle state is evaluated at stable closure.

This is a narrow domain-priority rule, not a general priority for entry over exit.

## 7. Finding CLC-E — continuity must outrank fresh formation over the same evidence

### Risk

An existing Active or Inactive H can accumulate exactly the same kinds of lower-level evidence used by initial formation when a newcomer arrives:

- co-residence;
- durable ties;
- support events;
- recognition.

Without an interpretation rule, the recognizer can simultaneously conclude:

- D is joining continuing H via `ParticipationWarrant`; and
- A+D (or A+B+D) satisfy a new `CandidateOrganization` and should form H2.

The same social development can therefore clone identities.

This is especially dangerous for Inactive reactivation: the sole bearer plus newcomer can look like a fresh founding core.

### Recommended rule

For one evidence bundle/history:

> **A valid recognized continuity/participation path to an existing non-Dissolved household takes precedence over interpreting that same evidence as formation of a new household identity.**

Consequences:

- onboarding/reactivation extends H rather than creating H2;
- household feedback/participation evidence cannot accidentally clone H;
- a genuinely new household involving the same person remains possible only after the relevant continuity path is explicitly broken, or from a distinct independently warranted organization not relying on the same evidence.

This rule does not prohibit future overlapping affiliations. It only prevents one causal history/evidence bundle from simultaneously establishing both continuation and fresh identity.

## 8. Finding CLC-F — founder minimum of two distinct people should be explicit

The accepted spec says “connected founding core” but does not explicitly state a minimum cardinality.

The approved Pass-D design intent was a founding organization of **two or more people**. The proposed lifecycle rule also assumes that one person is below Active household scale.

### Recommendation

Restore:

> A v0 household founding core contains at least two distinct people.

Stage-3 mechanical invariants should also prohibit self-targeting from satisfying interpersonal support/tie predicates used for household formation.

This is restorative clarification, not a new lifecycle theory.

## 9. Finding CLC-G — count-based activity does not require re-running formation evidence

A tempting alternative is to define Active by rechecking co-residence, durable ties, and repeated support continuously.

This would conflict with accepted continuity semantics:

- residence changes are explicitly allowed without ending household identity;
- formation and continuation were intentionally designed to use different warrants;
- a historically established organization may persist while its original means/configuration change.

The better v0 simplification is therefore to treat a valid `SustainingParticipant` association as durable authoritative participation state until an explicit ParticipationEnd or dissolution rule changes it.

This makes participant count a cheap operational status calculation over **warranted associations**, not a primitive membership detector.

## 10. Finding CLC-H — canonical founder-turnover sequence is sound with explicit warrant chaining

Recommended canonical sequence after the amendments:

1. A/B/C form H.
2. D enters through a `ParticipationWarrant` bridged by A; H emits/retains explicit continuation evidence.
3. A ends participation.
4. E enters through B; B exits.
5. F enters through C; C exits.
6. H remains the same identity with D/E/F and no original founder.

The independent checker should validate the historical chain:

`FormationWarrant -> ParticipationWarrant / ParticipationEnd -> ContinuationWarrant ...`

rather than infer continuity from final participant overlap.

A control run removes/breaks the required bridge before entry, so the later similar configuration cannot inherit H through the participation path.

## 11. Finding CLC-I — Inactive/role/provision interactions remain coherent

Under the recommended lifecycle interpretation:

- one remaining participant may still occupy the persistent head role;
- however household-mode action remains unavailable because collective capability requires Active H;
- existing provision commitment of that lone bearer may remain stored but unusable while Inactive;
- reactivation restores operational eligibility subject to ordinary role/capacity conditions;
- if the exiting participant was head, role vacancy still occurs as already specified.

No extra rule is needed here.

## 12. Finding CLC-J — multiple affiliations remain intentionally unclosed

The accepted architecture does not impose a universal one-household-per-person membership rule.

Stage 3 must therefore **not** add such an invariant.

The recommended continuity-precedence rule prevents duplicate identity from the same causal evidence, but does not decide whether one person may eventually sustain two genuinely distinct households. That question can remain outside v0 canonical scenarios unless an actual conflict requires it.

## 13. External/source basis

### Project evidence

- TRES-0001E: identity as historical relation; dissolution vs temporary inactivity; current activity distinct from continuity; membership overlap insufficient.
- SPEC-SFL-0001: provenance-bearing participation, explicit continuity warrants, residence change compatible with continuity.
- ADR-0004 / Pass F: staged resolution and stable reaction closure.

### External checks

- Palla, Barabási & Vicsek, *Quantifying social group evolution*, Nature 446 (2007): group membership changes dynamically and persistence is not reducible to a fixed roster.
- Fenn et al., *Community identity in a temporal network: A taxonomy proposal*, Ecological Complexity 45 (2021): community lifecycle/identity criteria are domain-dependent and topology alone does not universally settle continuation/death.
- Cloutier & Ravasi, *Identity Trajectories*, Academy of Management Journal 63(4) (2020): organizational identity continuity/change is not straightforwardly explained by member turnover.
- Li & van Knippenberg, *The Team Causes and Consequences of Team Membership Change*, Academy of Management Annals 15(2) (2021): membership change is common and alters team processes rather than automatically implying group death.
- W3C, *State Chart XML (SCXML) 1.0* Recommendation (2015): run-to-completion semantics reach stable configurations after internally triggered microsteps, providing a technical analogue for evaluating derived lifecycle state only at a stable causal boundary.

## 14. Recommended decision batch

Before committing the continuity family:

1. approve 2+/1/0 as **operational lifecycle state only**, with historical warrants retaining identity authority;
2. allow participation entry into Inactive H through its sole continuity bearer;
3. evaluate lifecycle status only at stable participation/reaction closure;
4. order a same-cycle dependent entry before the bridge's accepted exit;
5. give valid continuity/participation precedence over fresh formation using the same evidence;
6. restore the explicit two-distinct-person minimum founding core.

With these locks, no further blocker was found for the canonical continuity/turnover family.
