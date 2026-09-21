# VS-SFL-02x — Controlled Lineage Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §7.7.  
**Research basis:** `TRES-0007`.

These cards verify that lineage is historical derivation rather than numerical identity or inherited causal state.

## Family invariants

- zero or one `LineageWarrant` per successor `FormationWarrant`;
- direct lineage is irreflexive, acyclic, and temporally forward;
- `DerivedFrom` is rebuilt from direct predecessor IDs in the warrant;
- `AncestorOf` is a separate transitive query and never substituted for direct lineage;
- lineage creates no grain, relation, claim, authority, role, recognition, or pending process;
- ordinary household formation succeeds or fails independently of lineage classification;
- no authoritative Split/Merge/Division/Consolidation command or transformation object exists.

---

## VS-SFL-020 — Controlled division descendant

**Level:** mechanism-isolation  
**Claim:** one branch may continue H while a newly formed branch H2 receives direct lineage from H without inheriting H's identity.

### Initial state

Begin from a verified Active H with SustainingParticipants A, B, C, D.

- H has valid continuity/head history.
- A/B will remain on the continuing branch.
- C/D will become the possible descendant founders.
- C/D possess stable lower-level ties and enough controlled subjective evidence to support later ordinary formation once all formation requirements are met.
- No H2 exists.

### Schedule

1. Commit one ordinary qualifying C<->D person-person support event while C/D still participate in H.
2. C and D each commit `EndHouseholdParticipation(H)`; capture their ParticipationEndWarrants.
3. H remains Active through A/B and therefore non-Dissolved.
4. After both cited exits, commit a second ordinary qualifying C<->D support event on a later cycle.
5. Ensure C/D satisfy ordinary H2 formation requirements, including shared residence and CandidateRecognition.
6. Let ordinary formation create H2.
7. Run automatic lineage evaluation.

### Required causal order

- cited C/D participation ends;
- fresh post-exit support event;
- H2 FormationWarrant;
- LineageWarrant(H2, kind=DivisionDescendant, predecessors={H});
- stable-cycle lineage projection.

### Terminal assertions

- numerical H is unchanged and remains distinct from H2;
- H2 has exactly one LineageWarrant;
- direct predecessor set is exactly {H};
- founder-lineage sources map C and D to their explicit ended participation in H;
- H2 has `DerivedFrom(H)`;
- H does not have a self-edge `DerivedFrom(H)`;
- H2 founders recognize H2 through ordinary formation, not through lineage;
- no H resource/claim/authority/provision state is copied to H2.

### Independent oracle

Check only referenced FormationWarrant, ParticipationEndWarrants, fresh support event ordering, continuing non-Dissolved H state, and the LineageWarrant fields. Do not ask production lineage code whether the history is a division.

---

## VS-SFL-021 — Division freshness ablation

**Level:** causal ablation  
**Claim:** former participation alone is insufficient for controlled-v0 division lineage.

Use a history where H2 independently satisfies ordinary formation, but both support events used for H2 formation occur before the cited exits from H.

### Assertions

- H2 forms normally;
- no `DivisionDescendant` LineageWarrant is issued;
- failure to classify lineage does not invalidate H2.

---

## VS-SFL-022 — Division predecessor/branch controls

**Level:** adversarial controls

### A. Predecessor dissolves

Make H Dissolved before H2 forms.

- H2 may form;
- no controlled `DivisionDescendant` warrant from H is issued.

### B. Structural proxies change

Vary continuing/descendant branch size, grain, dwelling, and graph overlap while preserving the qualifying lineage history.

- lineage verdict remains unchanged.

### C. Ambiguous founder source

Give at least one H2 founder overlapping/recent ended predecessor histories such that more than one predecessor-source mapping satisfies the v0 classifier.

- H2 may form;
- no lineage warrant is issued;
- no arbitrary predecessor is selected by ID/order.

---

## VS-SFL-023 — Controlled consolidation descendant

**Level:** mechanism-isolation  
**Claim:** two dissolved predecessor households may be direct predecessors of one newly formed H3 without either retaining numerical identity.

### Initial state

Begin from independently verified Active H1 and H2.

- H1 current participants include A/B.
- H2 current participants include C/D.
- Future H3 founding core is A/B/C/D.
- No H3 exists.

### Schedule

1. A/B explicitly end participation in H1; C/D explicitly end participation in H2.
2. At stable closure, both H1 and H2 are Dissolved.
3. Arrange ordinary shared residence/durable-tie conditions for A/B/C/D.
4. After both predecessor dissolutions, commit at least one qualifying **cross-predecessor** person-person support event, e.g. B -> C.
5. Supply a second qualifying support event on a distinct cycle as needed for ordinary formation.
6. All H3 founders reach CandidateRecognition under ordinary rules.
7. Ordinary formation creates H3.
8. Run automatic lineage evaluation.

### Terminal assertions

- H3 is a new numerical identity distinct from H1/H2;
- exactly one LineageWarrant exists for H3;
- kind = `ConsolidationDescendant`;
- unordered direct predecessor set = {H1,H2};
- each H3 founder maps unambiguously to H1 or H2;
- at least one founder maps to each predecessor;
- fresh lineage evidence includes a post-dissolution cross-predecessor event;
- neither H1 nor H2 is numerically continued as H3;
- no predecessor causal state is automatically inherited.

---

## VS-SFL-024 — Consolidation controls

**Level:** causal ablation / adversarial

### A. One predecessor survives

Leave H2 Active or Inactive when H3 forms.

- H3 may form normally;
- no controlled-v0 `ConsolidationDescendant` warrant is issued.

### B. No fresh cross-predecessor support

Let H3 ordinary formation succeed without a qualifying support event after both predecessor dissolutions that crosses H1/H2 source groups.

- H3 forms;
- no consolidation lineage classification.

### C. Unrelated H4 history

Give one founder historical contact with unrelated H4 that does not satisfy founder-lineage-source conditions for H3.

- H4 must not enter the predecessor set.

### D. Predecessor order permutation

Run identical history with H1/H2 enumeration reversed.

- warrant predecessor set is semantically identical.

---

## VS-SFL-025 — Lineage has no v0 causal power

**Level:** metamorphic / causal-state ablation  
**Claim:** lineage is historical provenance only.

From the same valid post-formation state, compare:

- run A with authoritative LineageWarrant plus rebuilt `DerivedFrom` projection;
- analytical comparison B in which the lineage projection is removed from decision/query surfaces while all ordinary authoritative social/material state is preserved.

### Assertions

- personal and household candidate generation is unchanged;
- resource state and future commits are unchanged;
- role/recognition behavior is unchanged;
- only lineage/ancestry inspection output differs.

The authoritative run still retains its warrant; this comparison tests behavioral non-use, not destructive mutation of run history.

---

## VS-SFL-026 — Direct versus transitive ancestry

**Level:** derived-state / provenance

Create a valid direct lineage chain:

`H1 -> H2 -> H3`

where each arrow is separately backed by a valid LineageWarrant in its own controlled scenario.

### Assertions

- H2 directly `DerivedFrom(H1)`;
- H3 directly `DerivedFrom(H2)`;
- H3 is **not** directly `DerivedFrom(H1)`;
- `AncestorOf(H1,H3)` is true as a derived transitive query;
- deleting/rebuilding the lineage index from warrants reproduces the same direct and transitive query results.
