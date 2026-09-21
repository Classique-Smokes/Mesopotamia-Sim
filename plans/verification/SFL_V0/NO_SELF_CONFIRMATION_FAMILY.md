# VS-SFL-05x — No Household Self-Confirmation Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§6–8.

These cards prove that effects produced by an already-recognized household cannot become independent evidence that retroactively creates, duplicates, or self-validates the household.

## VS-SFL-050 — Household support cannot become formation evidence

**Level:** causal ablation

### Initial state

- existing Active H provides valid household-originated 1-grain support to C;
- C later participates in a separate pre-household candidate with outsider D;
- C/D share residence and have a durable tie;
- the candidate has exactly one ordinary qualifying person-person support event;
- the only potential "second support" is the earlier H-originated household support to C.

### Assertions

- H-originated support is tagged/provenanced as household feedback;
- it does not count as an independent qualifying support event for the C/D candidate;
- with only one ordinary qualifying event, no new H2 FormationWarrant may issue;
- replacing the H-originated support with a valid ordinary qualifying person-person event on another cycle makes the recurrence gate satisfiable, holding other facts fixed.

---

## VS-SFL-051 — Household feedback cannot clone existing identity

**Level:** causal intervention

### Initial state

Active H with sustaining participants and ordinary household support history.

Construct a candidate interpretation over people already connected to H such that residence/ties/recognition resemble a formation pattern.

### Assertions

- H's own household-mode actions/support are not independent evidence for a duplicate candidate household;
- when the same causal evidence has a valid continuity/participation interpretation to non-Dissolved H, that path takes precedence over fresh formation;
- no H2 may be created merely because H's own effects make H look more organized.

---

## VS-SFL-052 — Household feedback cannot satisfy fresh-lineage evidence

**Level:** causal ablation

Use otherwise-valid controlled division/consolidation setup from `LINEAGE_FAMILY.md`, but replace the required fresh ordinary person-person support evidence with household-originated support from a predecessor or already-existing household.

### Assertions

- successor household may still form if ordinary formation independently qualifies;
- household-originated support does not satisfy the fresh-lineage condition;
- no controlled-v0 LineageWarrant issues solely from household feedback.

---

## VS-SFL-053 — Label/diagnostic ablation

**Level:** metamorphic

Run a valid history twice with identical authoritative lower-level state/events:

- normal household/recognition diagnostic projections enabled;
- non-authoritative household reporting/index projections rebuilt/disabled.

### Assertions

- authoritative formation/continuity results and material effects are unchanged;
- diagnostic/reporting presence is not causal evidence;
- only recognized/warranted semantic state may influence household-specific behavior.

## Family mutants that must be detected

- household support counted as an ordinary qualifying formation event;
- household support counted as fresh lineage evidence;
- engine household label added as evidence for CandidateRecognition;
- household effects automatically cause universal household recognition;
- a derived/reporting projection mutates authoritative recognition or continuity.
