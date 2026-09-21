# TRES-0007 — Lineage Warrant Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Narrow adversarial review of `specifications/working/SFL_V0_LINEAGE_WARRANT_PROPOSAL.md`. No accepted specification is amended by this review.

## 1. Baseline reviewed

The proposal attempts to support only the already-accepted controlled v0 lineage proofs:

- one division case where H continues on one branch and a new H2 descends from H;
- one consolidation case where dissolved H1/H2 precede a new H3;
- no general fission/merger/inheritance theory.

Fixed project constraints:

- numerical identity != descent;
- ordinary formation remains independently required;
- lineage carries no resources/rights/authority;
- no fixture-level SplitHousehold/MergeHouseholds command;
- historical/provenance explanation must remain inspectable.

## 2. Overall finding

The `LineageWarrant` concept is sound and materially better than encoding split/merge as primitive lifecycle commands.

However, the draft should **not** be promoted as written. The adversarial pass identified several overconstraints and duplication risks.

The strongest revised v0 design is:

1. one authoritative, rule-versioned `LineageWarrant` at most per successor `FormationWarrant`;
2. direct predecessor set stored in that warrant;
3. direct `DerivedFrom` edges are projections of the warrant rather than independent authority;
4. transitive ancestry is a separate derived query and is not assumed to have the semantics of direct derivation;
5. no authoritative `DivisionTransformation` or `ConsolidationTransformation` object is needed;
6. controlled lineage requires fresh post-separation/reorganization evidence so former participation alone cannot manufacture descent;
7. ambiguous predecessor provenance yields **no v0 lineage classification**, not a guessed one;
8. lineage remains behaviorally inert in v0.

No architecture-level blocker was found after these corrections.

## 3. Finding LW-A — lineage should be an interpretive provenance record, not a primitive social fact

A `LineageWarrant` is neither:

- household identity;
- a lower-level person relation;
- nor a resource/authority relation.

It is the model's explicit, versioned historical interpretation that a newly formed household was generated from specified predecessor household histories.

Recommended status:

- authoritative **record of the model's committed lineage determination for that run**;
- evidence-backed and rule-versioned;
- raw predecessor participation/formation/dissolution events remain independently authoritative;
- later offline/research reinterpretation may disagree without rewriting what the run originally determined.

This parallels the project's existing distinction between underlying events and interpretations/warrants.

## 4. Finding LW-B — use one lineage warrant per successor formation

The draft allows the conceptual possibility of multiple lineage warrants for one successor.

That creates avoidable ambiguity:

- H3 could receive separate warrants from H1 and H2 rather than one consolidation provenance set;
- overlapping histories could create duplicate edges;
- later code could accidentally treat two warrants as two independent sources of inherited authority.

### Recommendation

For v0:

> A successor `FormationWarrant` has **zero or one** `LineageWarrant`.

That warrant contains one unordered direct-predecessor set:

- division descendant: exactly `{H}`;
- consolidation descendant: exactly `{H1,H2}`.

If more than one predecessor-set interpretation satisfies the v0 classifier, lineage is ambiguous/out of scope and no lineage warrant is committed.

The household itself still forms normally.

## 5. Finding LW-C — direct derivation must remain distinct from ancestry

The proposal correctly separates direct lineage and transitive ancestry; this should become a hard requirement.

External provenance standards provide a useful analogy:

- W3C PROV requires derivation to respect generation ordering and prohibits cyclic derivation histories;
- the PROV working group explicitly declined to define generic derivation as transitive because transitivity is not valid for every derivation semantics.

### Recommendation

Authoritative state:

- `LineageWarrant(successor, directPredecessors, ...)`.

Derived/indexed views:

- `DerivedFrom(successor, predecessor)` for each direct predecessor in the warrant;
- `AncestorOf(ancestor, descendant)` only as an explicitly named transitive graph query.

Never silently substitute `AncestorOf` for direct `DerivedFrom`.

Required invariants:

- irreflexive;
- direct lineage DAG;
- predecessor household existed before successor formation;
- relevant source events precede successor FormationWarrant.

## 6. Finding LW-D — remove authoritative split/merge transformation records

A separate authoritative:

- `DivisionTransformation`;
- `ConsolidationTransformation`

duplicates information already contained in:

- predecessor identities;
- ParticipationEnd events;
- successor FormationWarrant;
- LineageWarrant kind/predecessor set.

It also risks letting a convenient lifecycle label become causal authority.

### Recommendation

Do not add those records as authoritative state.

If the inspector/UI wants a summary such as:

- "division: H -> H + H2";
- "consolidation: H1 + H2 -> H3";

generate it as a derived report/view from the lineage warrant and underlying history.

This matches both project research and current temporal-group research cautioning that split/merge labels are often lossy classifications of more detailed change.

## 7. Finding LW-E — the draft's intervening-participation rule is too strong

The draft proposes:

> no later household-participation start may intervene between predecessor exit and successor formation.

Because the architecture deliberately does not impose exclusive household membership, this can accidentally make unrelated/overlapping affiliation block lineage.

### Recommendation

Delete that global recency/exclusivity condition.

Instead, each lineage warrant contains explicit:

`FounderLineageSource(founder, predecessor, participationEndWarrant)`.

For controlled v0 cases, the predecessor-source mapping must be unambiguous **within the claimed lineage case**.

If a founder's overlapping/recent participation histories permit multiple equally valid predecessor mappings under the v0 rule, the lineage classifier declines to issue a warrant.

This is not a one-household-per-person rule.

## 8. Finding LW-F — former participation alone is insufficient; require fresh organizational evidence

Without a freshness requirement:

1. C/D participate in H for a long time;
2. they end participation;
3. their old residence/ties/support history still satisfies formation;
4. H2 appears immediately;
5. lineage is inferred solely because they used to be in H.

That reduces lineage toward "former members formed another group" rather than demonstrating a derived branch/reorganization.

Project research explicitly distinguishes a new sustained organization from mere participant flow, and says consolidation requires newly sustained coordination rather than one resource-pooling event.

### Recommended v0 rule

Keep ordinary formation unchanged, but add a **lineage-classification freshness condition**.

#### Division descendant

At least one of the successor FormationWarrant's qualifying support events must:

- involve successor founders;
- occur **after all ParticipationEndWarrants used as H-lineage sources**;
- be an ordinary qualifying person-person support event, not household-originated support feedback.

#### Consolidation descendant

At least one qualifying support event used by H3's FormationWarrant must:

- occur **after both predecessor households are Dissolved**;
- be **cross-predecessor**: one participant maps to H1 and the other to H2;
- be an ordinary qualifying person-person support event.

This does not add another formation requirement; the successor may form normally without it. It determines whether the already-valid new household receives the v0 lineage classification.

No arbitrary maximum time-gap is recommended. Fresh post-separation action gives the relevant causal evidence without inventing a decay window.

## 9. Finding LW-G — controlled consolidation should require predecessor dissolution

If H1 or H2 remains Active/Inactive after H3 forms, the history is better described as:

- partial spin-out;
- overlapping reorganization;
- or another future case,

not the narrow v0 proof that two households consolidated into one new household.

### Recommendation

For `ConsolidationDescendant` in v0:

- H1 and H2 must both be Dissolved before H3's FormationWarrant;
- H3 must still satisfy ordinary formation independently;
- the fresh cross-predecessor support condition in LW-F applies.

This is intentionally narrow and does not claim all real consolidation must behave this way.

## 10. Finding LW-H — controlled division should require a genuinely continuing H

For the controlled division proof:

- predecessor H must still exist as a non-Dissolved continuing identity when H2 forms;
- H's continuing branch must be supported by the already-accepted continuity mechanism;
- H2 founders must have ended their own participation in H before H2 forms;
- H2 is a new numerical identity.

The continuing H does **not** receive `DerivedFrom(H)`; self-lineage would collapse identity and descent.

Current accepted wording that "both branches may record DerivedFrom(H)" should therefore be amended if this model is approved.

## 11. Finding LW-I — all-successor-founders-from-predecessors is acceptable only as controlled-v0 scope

The draft requires every successor founder to map to claimed predecessor(s).

That is too strong as a universal lineage theory: a descendant/reorganized institution can plausibly include an outsider.

But v0 explicitly needs only one controlled division and one controlled consolidation proof.

### Recommendation

For the v0 lineage classifier only:

- DivisionDescendant: every H2 founder maps to H.
- ConsolidationDescendant: every H3 founder maps to H1 or H2, with at least one founder mapped to each.

If an outsider is part of the founding core, ordinary formation still works, but v0 does not automatically issue a lineage warrant. Richer mixed-origin lineage is deferred.

Record this as a controlled scope limit, not a project-wide principle.

## 12. Finding LW-J — lineage should not inherit recognition or causal state

The draft is correct here and the adversarial review strengthens it.

No lineage effect may automatically transfer:

- grain or material claims;
- provision commitments;
- debt/favour;
- residence;
- marriage/kinship;
- attitude;
- head role/authority;
- household recognition;
- candidate recognition;
- pending proposals/processes;
- predecessor lifecycle state.

Person-level relations survive only through their own semantics.

New founders recognize the successor household through the normal FormationEvent rule, not through lineage.

Outsiders do not learn lineage or successor identity unless ordinary observation/communication rules provide that knowledge.

## 13. Finding LW-K — lineage can be immutable within one run

The draft asks whether later provenance discovery/correction requires mutation.

For SFL v0:

- objective event history is complete at the engine level;
- stale/incomplete information exists in actor subjective state, not in authoritative world history;
- lineage is evaluated from authoritative history after successor formation.

Therefore a committed LineageWarrant can be immutable within one run.

If a future rule version reinterprets an archived history, that should produce a separate analysis/reclassification result, not silently rewrite the original run's warrant.

The warrant must retain rule/configuration version.

## 14. Finding LW-L — do not store declined-classification diagnostics inside the warrant

The draft suggests recording ambiguity/exclusion reason in a lineage warrant.

If no lineage warrant is issued, there is no warrant in which to store this.

### Recommendation

Keep:

- successful warrant as authoritative lineage record;
- optional lineage-evaluation diagnostic in verification/history tooling.

A failed/ambiguous lineage evaluation must not create a partial authoritative lineage object.

## 15. Revised minimal LineageWarrant

Recommended authoritative fields:

- WarrantId;
- SuccessorHouseholdId;
- SuccessorFormationWarrantId;
- Kind: `DivisionDescendant | ConsolidationDescendant`;
- DirectPredecessorHouseholdIds as an unordered set;
- FounderLineageSources:
  - FounderId;
  - PredecessorHouseholdId;
  - ParticipationEndWarrantId;
- FreshOrganizationEvidenceEventId(s) satisfying LW-F;
- Commit `Cycle, ReactionIndex`;
- Rule/ConfigurationVersion.

Everything else should be obtained through referenced records or derived views unless implementation evidence shows a need to duplicate it.

## 16. Revised issuance algorithm

After a new household FormationWarrant commits:

1. collect lineage-source candidates only from explicit predecessor ParticipationEndWarrants of successor founders;
2. evaluate supported v0 kinds:
   - one predecessor + continuing non-Dissolved predecessor H -> possible DivisionDescendant;
   - exactly two predecessors, both Dissolved -> possible ConsolidationDescendant;
3. require unambiguous founder -> predecessor mapping under the controlled-v0 scope;
4. require fresh organizational evidence:
   - division: post-source-end qualifying person-person support;
   - consolidation: post-dissolution cross-predecessor qualifying person-person support;
5. reject self/cyclic/future lineage;
6. if exactly one predecessor-set/kind interpretation qualifies, emit one LineageWarrant;
7. otherwise emit no warrant and optionally record a diagnostic evaluation result.

The household remains valid regardless of whether lineage classification succeeds.

## 17. Recommended Stage-3 adversarial cases

### Division controls

- positive: H continues; former participants form H2 with fresh post-exit support -> H2 DerivedFrom H;
- remove fresh post-exit support while keeping H2 ordinary formation valid -> H2 forms, no lineage warrant;
- make H dissolve before H2 forms -> no controlled DivisionDescendant warrant;
- change branch sizes/assets/residence -> lineage unchanged where source history is unchanged;
- give founder ambiguous overlapping predecessor sources -> H2 forms, lineage classification withheld.

### Consolidation controls

- positive: H1/H2 dissolve; former participants interact cross-predecessor after dissolution; H3 forms -> one warrant with set {H1,H2};
- leave H2 non-Dissolved -> H3 may form, no controlled ConsolidationDescendant warrant;
- remove cross-predecessor fresh support -> H3 may form, no consolidation lineage;
- add former H4 history unrelated to H3 formation -> H4 must not enter predecessor set;
- reorder predecessor set -> semantically identical warrant.

### Provenance/metamorphic controls

- no self-edge/cycle;
- direct predecessor edge and transitive AncestorOf remain distinguishable;
- deleting the derived lineage index and rebuilding from warrant changes nothing;
- removing lineage projection while preserving ordinary state changes no v0 behavior;
- diagnostic observer on/off changes no warrant result.

## 18. External/source reconciliation

External sources do **not** supply the project's lineage semantics; they support guardrails:

- W3C PROV treats derivation as provenance of generation/evolution, requires sensible event ordering, and rules out cyclic derivation histories.
- W3C deliberately does not make generic derivation transitive; direct derivation and transitive ancestry should remain distinct.
- temporal-group research demonstrates membership change and group evolution but does not justify equating identity/descent with roster overlap.
- recent temporal-group work specifically cautions that split/merge event taxonomies can be arbitrary/overly rigid descriptions of underlying change.

These findings support provenance-first lineage rather than primitive split/merge commands.

## 19. Director decisions required before promotion

If the revised design is adopted, the meaningful semantic approvals are:

1. approve `LineageWarrant` as a behaviorally inert, rule-versioned historical derivation record attached only to newly formed households;
2. approve zero-or-one lineage warrant per successor FormationWarrant;
3. approve direct predecessor edges only; transitive ancestry is a distinct derived query;
4. approve fresh organizational evidence rule:
   - division: >=1 qualifying person-person support event after all lineage-source exits;
   - consolidation: >=1 cross-predecessor qualifying person-person support event after both predecessors dissolve;
5. approve predecessor dissolution as required for the controlled consolidation classification;
6. approve all-founders-from-predecessor(s) only as a controlled-v0 lineage scope limit;
7. approve that ambiguous/mixed-origin cases simply receive no v0 lineage classification;
8. approve no authoritative DivisionTransformation/ConsolidationTransformation object;
9. approve correction of the current "both branches may DerivedFrom(H)" wording so only the new descendant H2 has direct lineage to H while continuing H remains H.

No accepted artifact has been changed by TRES-0007.
