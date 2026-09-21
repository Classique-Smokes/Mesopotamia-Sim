# SFL v0 — Lineage Promotion Reconciliation

**Status:** COMPLETE / HISTORICAL WORKING RECORD  
**Date:** 2026-09-21  
**Purpose:** Semantic-preservation check for promotion of TRES-0007 into `SPEC-SFL-0001`.

## Approved operative inventory

| Approved commitment | Canonical disposition |
|---|---|
| LineageWarrant is behaviorally inert, rule-versioned historical derivation attached only to a new household formation | Preserved in §7.7 |
| Zero or one LineageWarrant per successor FormationWarrant | Preserved in §7.7.1 |
| Direct predecessor lineage only; transitive ancestry is distinct and derived | Preserved in §7.7.1 |
| No authoritative DivisionTransformation/ConsolidationTransformation objects | Preserved in §7.7.1 |
| Fresh organizational evidence required for controlled lineage | Preserved in §7.7.3 |
| Controlled consolidation requires both predecessors Dissolved | Preserved in §7.7.5 |
| All-founders-from-predecessor(s) is only a controlled-v0 lineage restriction | Preserved in §7.7.4–7.7.5 and ASM-0011 |
| Ambiguous/mixed-origin cases form normally but receive no v0 lineage classification | Preserved in §7.7.1–7.7.2 and ASM-0011 |
| Continuing H never derives from itself; only the new descendant receives direct lineage | Preserved in §7.7.4 |
| Lineage transfers no causal state or rights | Preserved in §7.7 opening and §7.7.6 |
| Founder predecessor mapping uses explicit ParticipationEndWarrant provenance without imposing global exclusive membership | Preserved in §7.7.2 |
| Direct lineage is irreflexive, acyclic and temporally forward | Preserved in §7.7.1 |
| Committed warrant is immutable in-run and rule-versioned | Preserved in §7.7.6 |
| No separate subjective RecognizesLineage state in v0 | Preserved in §7.7.6 |
| Lineage evaluation follows successor formation and stable-cycle publication rules | Preserved in §7.7.6 |

## Controlled assumptions

`ASM-0011` records the deliberately narrow v0 classification boundary: fresh evidence, predecessor-source clarity, predecessor dissolution for consolidation, and all-founders-from-predecessors restriction.

## Superseded working ideas

The following working-proposal ideas were explicitly rejected by TRES-0007 and are **not** canonical:

- global "no intervening household participation" rule;
- multiple lineage warrants for one successor formation;
- authoritative split/merge transformation objects;
- storing failed/ambiguous lineage diagnostics as partial warrants;
- generic transitivity of `DerivedFrom`.

## Result

All Director-approved lineage semantics are either preserved in `SPEC-SFL-0001` or explicitly isolated in `ASM-0011`. No operative commitment was removed as compression fluff.
