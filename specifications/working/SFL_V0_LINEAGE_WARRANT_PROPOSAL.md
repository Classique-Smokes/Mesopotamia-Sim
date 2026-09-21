# SFL v0 — Lineage Warrant Working Proposal

**Status:** WORKING / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Purpose:** Flesh out the minimum v0 semantics needed to support the already-accepted controlled division and consolidation proof cases without turning lineage into identity, inheritance, or a scripted split/merge command.

## 1. Fixed constraints from accepted SFL v0

This proposal must preserve:

- household numerical identity is historical and distinct from similarity/descent;
- one division branch may retain H only through the existing continuity mechanism;
- the other division branch is a new household identity;
- consolidation of H1 and H2 produces a new H3 rather than choosing an arbitrary continuing predecessor;
- household formation must still arise through ordinary lower-level formation semantics;
- the fixture may not directly issue `SplitHousehold`, `MergeHouseholds`, or write `DerivedFrom`;
- residence/property/member-count similarity never establishes lineage;
- lineage must never duplicate grain, claims, obligations, authority, recognition, or other causal state.

## 2. Proposed distinction

### 2.1 Numerical identity

Answered by:

- `FormationWarrant`;
- `ParticipationWarrant`;
- `ParticipationEndWarrant`;
- `ContinuationWarrant`.

A household either is H or is not H.

### 2.2 Direct lineage

Answered by a new provenance record:

`LineageWarrant(successor, predecessors, kind, evidence)`

It establishes only:

> successor household S was historically generated from the dissolution/separation/reorganization histories of predecessor household(s) P.

It does **not** mean S is numerically identical to P.

### 2.3 Ancestry query

`DerivedFrom(S,P)` is a direct lineage edge backed by one `LineageWarrant`.

Transitive ancestry, if needed for inspection, is a derived query over direct edges:

`AncestorOf(P,S)`

Transitive ancestry is **not** automatically a new warrant and carries no additional rights/state.

## 3. Proposed LineageWarrant contents

Every warrant records:

- stable warrant ID;
- successor Household ID;
- lineage kind:
  - `DivisionDescendant`;
  - `ConsolidationDescendant`;
- one or more direct predecessor Household IDs;
- successor `FormationWarrant` reference;
- relevant predecessor `ParticipationEndWarrant` references for successor founders;
- founder -> predecessor-source mapping;
- predecessor household lifecycle/identity references;
- causal event ordering / cycle-reaction positions;
- rule/configuration version;
- any ambiguity/exclusion reason if the v0 lineage classifier declines to issue a warrant.

The warrant is objective historical state. v0 gives it no independent behavioral power.

## 4. General issuance rule

A `LineageWarrant` may be emitted only as an automatic consequence of a **new household FormationWarrant**.

It may never:

- create the successor household;
- substitute for ordinary formation requirements;
- preserve a predecessor's numerical identity;
- be fixture-injected as the cause of division/consolidation.

The new household must first satisfy the ordinary v0 formation rule from lower-level evidence and founder recognition.

The lineage evaluator then asks whether that already-valid formation is historically derived from one or more predecessor household participation histories.

## 5. Temporal / provenance rules

A direct lineage edge must point forward in committed history:

- predecessor H must already have existed before successor S forms;
- relevant predecessor participation-end events strictly precede S's FormationWarrant in semantic event order;
- S cannot be `DerivedFrom(S)`;
- the direct lineage graph must remain acyclic.

No minimum elapsed cycle is required: strict semantic event order is sufficient. Canonical scenarios may separate events across cycles for clarity.

## 6. Founder predecessor-source mapping

For each successor founder used to establish lineage, the warrant records which ended predecessor participation supplies lineage provenance.

For controlled v0 lineage, that mapping must be unambiguous:

- a founder must have a relevant ended `SustainingParticipant` association to the claimed predecessor;
- no later household-participation start may intervene between that relevant end and successor formation;
- if overlapping/recent household histories make the predecessor source ambiguous, v0 does **not** guess. Ordinary formation may still occur, but no v0 `LineageWarrant` is emitted for that ambiguous lineage claim.

This is a lineage-classification restriction, not a global rule prohibiting overlapping household participation.

## 7. Controlled division warrant

### 7.1 Preconditions

Start with Active H.

Lower-level events cause its sustaining organization to separate. One branch retains H only through the existing accepted continuity path.

A different branch's people:

- explicitly end their participation in H;
- later satisfy ordinary formation requirements for a new H2;
- receive a new `FormationWarrant(H2)`.

### 7.2 Proposed lineage condition

H2 receives:

`LineageWarrant(H2, [H], DivisionDescendant, ...)`

only when:

- every H2 founder has an unambiguous relevant ended participation in H;
- those `ParticipationEndWarrant` events precede H2 formation;
- no founder has an intervening household-participation start;
- H2 forms as a genuinely new household under ordinary formation semantics;
- H still has a valid continuing identity branch under the accepted representative/participation continuity mechanism.

### 7.3 Division record

The continuing branch remains numerical H and should **not** receive `DerivedFrom(H)` pointing to itself.

A descriptive division-history record may link:

`DivisionTransformation(predecessor=H, continuing=H, descendant=H2, lineageWarrant=W)`

This transformation record is explanatory/history only and is derived from the already-committed underlying events. It is not a `SplitHousehold` command.

### 7.4 Controlled scope

v0 demonstrates exactly one new descendant H2 while H continues.

General multiple descendants, disputed successor claims, simultaneous branch formation, absorption, and later reconsolidation remain deferred.

## 8. Controlled consolidation warrant

### 8.1 Preconditions

Start with two independent Active households H1 and H2.

For the controlled v0 case:

- all current sustaining participants who will become H3 founders explicitly end participation in H1/H2;
- the relevant predecessor households reach Dissolved before H3's FormationWarrant;
- the future H3 founders then satisfy ordinary formation requirements together;
- H3 receives a new numerical identity.

### 8.2 Proposed lineage condition

H3 receives:

`LineageWarrant(H3, [H1,H2], ConsolidationDescendant, ...)`

only when:

- every H3 founder has an unambiguous relevant ended participation in H1 or H2;
- at least one H3 founder maps to H1 and at least one maps to H2;
- all relevant predecessor participation-end events precede H3 formation;
- no founder has an intervening household-participation start;
- H1 and H2 are Dissolved before H3 forms;
- H3 independently satisfies ordinary formation semantics.

Neither H1 nor H2 is numerically continued by H3.

### 8.3 Consolidation record

A descriptive history record may link:

`ConsolidationTransformation(predecessors=[H1,H2], successor=H3, lineageWarrant=W)`

It is generated from the underlying dissolution/formation history and has no causal authority.

## 9. Evidence reuse and fresh organization

The current working proposal does **not** allow lineage itself to satisfy formation.

Open design point for adversarial review:

- whether H2/H3 may reuse qualifying support events that occurred while founders were still sustaining participants of predecessor household(s), or whether at least part of the successor's formation evidence must postdate separation/dissolution.

Working recommendation before adversarial review:

> Require at least **one** of the successor's two qualifying support events to occur after all relevant founders have ended the predecessor participation used by the lineage warrant.

Reason:

- prevents an old household's original support history from instantly generating a new household the moment participants exit;
- still allows durable ties/history to carry forward rather than pretending all prior social reality disappears;
- provides direct evidence that a newly independent sustaining organization actually operated after separation.

This would be a new v0 lineage/formation interaction rule and therefore requires Director approval if retained.

## 10. No inherited causal state

`DerivedFrom` / `LineageWarrant` transfers nothing automatically.

It does not inherit or duplicate:

- grain;
- provision commitments;
- debt/favour claims;
- marriage/kinship;
- residence;
- attitudes;
- `NeedsGrain`;
- head role or occupant;
- authority;
- household recognition;
- candidate recognition;
- pending proposals/processes;
- predecessor lifecycle status;
- predecessor numerical identity.

Any future inheritance/transmission mechanic requires its own explicit rule and causal transition.

Person-level relations that independently persist continue because **their own** semantics persist, not because lineage copied them.

## 11. Recognition / knowledge

Lineage is objective historical provenance in v0.

No action currently depends on an actor recognizing lineage, so v0 need not introduce a separate subjective `RecognizesLineage` proposition.

Actors may know predecessor/formation events through ordinary participation, observation, or communication. The inspector can query objective lineage without making every actor omniscient.

## 12. DerivedFrom semantics

Recommended v0 constraints:

- direct only in authoritative lineage records;
- irreflexive;
- acyclic;
- immutable once validly committed, because it records historical provenance;
- does not disappear if predecessor/successor later dissolve;
- may have one predecessor for controlled division;
- has exactly two predecessors for controlled consolidation;
- predecessor list is a set, not ordered priority.

A later ancestry view may compute transitive closure, but direct and transitive relations must remain distinguishable.

## 13. Stable-cycle behavior

Lineage evaluation occurs only after the successor `FormationWarrant` commits and its same-cycle automatic formation reactions are valid.

The `LineageWarrant` may be emitted as a causally downstream same-cycle reaction.

Cycle-level division/consolidation summaries are published only at stable closure under the accepted kernel rule.

## 14. Proposed verification obligations

### Division

- H remains H on one continuity branch;
- H2 is a new identity;
- H2 direct lineage points to H exactly once;
- no self-lineage edge H -> H;
- lineage derives from actual participation-end and H2 formation history;
- branch size/assets/residence do not decide lineage;
- removing predecessor participation history removes `DerivedFrom(H)` without blocking ordinary H2 formation if formation still independently qualifies.

### Consolidation

- H1/H2 are distinct predecessors;
- H3 is a new identity;
- H3 has one direct lineage warrant with predecessor set {H1,H2};
- each predecessor contributes at least one mapped founder;
- neither predecessor identity becomes H3;
- adding a third unrelated former household history must not enter the warrant.

### Causal-state ablation

Remove the `LineageWarrant`/derived lineage projection while preserving all ordinary person/resource/relation state:

- v0 behavioral trajectory should remain unchanged because lineage has no causal power.

### Provenance integrity

- no cycles;
- no future predecessor event;
- no missing Formation/ParticipationEnd reference;
- direct vs transitive ancestry remains distinguishable.

## 15. Open issues for adversarial review

1. Is the post-separation support-event requirement necessary, too strong, or insufficient?
2. Must predecessor household be Dissolved for consolidation, or is “all H3 founders ended predecessor participation” sufficient?
3. Can direct lineage be immutable if later provenance is discovered/corrected?
4. Does “all founders came from predecessor(s)” overconstrain cases where a new outsider joins the new branch?
5. Is an explicit `DivisionTransformation`/`ConsolidationTransformation` record useful, or redundant beside `LineageWarrant`?
6. Could the predecessor-source mapping accidentally imply exclusive household membership?
7. What prevents old distant participation from creating spurious lineage after a long gap?
8. Are lineage edges objective facts or interpretation records whose rule/version should remain explicit?
9. Can the same new household satisfy more than one lineage warrant under overlapping predecessor histories?
10. Which fields must be authoritative versus derived/indexed?
