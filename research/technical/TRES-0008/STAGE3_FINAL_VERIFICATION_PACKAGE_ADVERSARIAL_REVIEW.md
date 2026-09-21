# TRES-0008 — Final Stage-3 Verification Package Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Full closure review of SFL v0 Stage-3 verification design after the semantic-compression audit, lineage review, provision/scoring gate resolution, and canonical scenario-family construction.

## 1. Materials reviewed

Authoritative/architectural:

- `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- ADR-0001 through ADR-0005;
- DEC-0001;
- active assumptions register.

Verification package:

- formation;
- continuity/turnover;
- controlled lineage;
- recognition/information;
- grounded provision/support/dowry;
- no-self-confirmation;
- head-role/dual-mode;
- resolution/failure/reaction closure;
- deadlock/determinism/recovery/explainability;
- lower-level social fabric;
- reference closed-loop scoring profiles;
- cross-cutting verification contract.

Prior adversarial basis:

- TRES-0003 through TRES-0007;
- pre-rule semantic-compression audit.

## 2. Overall finding

The Stage-3 verification architecture is strong and substantially complete.

The package now has:

- independent-oracle discipline;
- canonical mechanism-isolation and closed-loop cards;
- full lower-level plus household-layer coverage;
- hard-boundary matrices;
- metamorphic relations;
- stateful/generated-history strategy;
- concrete held-out recipes;
- semantic mutation set;
- fixture-write auditing;
- checkpoint/rebuild equivalence;
- causal explanation interventions;
- explicit technical-fallback sensitivity.

The final review found **two remaining semantic blockers** that prevent clean Stage-3 closure:

1. no deterministic reference policy for proposal responses;
2. an orphan `breach accepted commitment -> -20` attitude rule with no defined v0 breach transition.

No other architecture-level blocker was found.

## 3. Finding CLOS-A — lower-level social substrate was under-tested; repaired

Initial Stage-3 work heavily covered household emergence/continuity but relied on cross-cutting prose rather than canonical transition cards for several Pass-A/B mechanics.

This review added `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, covering:

- consumption / NeedsGrain / Farm / clearing;
- Gift, Loan, RequestGiftOrHelp, RequestLoan/OfferLoan, explicit benefit-for-favour, reciprocal help;
- debt partial/full repayment, reserve, social due review;
- favour creation thresholds/cardinality, call/refusal/fulfilment/cancellation;
- direct strong-like marriage bypass and kin exclusion;
- residence proposals and no automatic marriage move;
- fixed attitude updates/decay;
- personal initiative versus responses;
- kinship score amplification and co-residence motivation ordering.

This was a verification-coverage repair, not a new social rule.

## 4. Finding CLOS-B — reference scorer is now exact enough

The final scoring gate is resolved:

- categorical gates before scoring;
- named exact-integer components;
- `FinalScore = sum(components)`;
- highest score wins;
- explicit domain tie key if defined, otherwise logged stable-ID fallback;
- no hidden second aggregation layer;
- exact-integer scaling for kinship;
- pinned closed-loop profiles.

Independent oracles can now recompute component sums without calling production selector code.

No further scorer-semantic blocker was found.

## 5. Finding CLOS-C — multi-contributor provision allocation is now exact

The final allocation gate is resolved:

- compute capacities at precommit;
- rank once descending;
- stable ID orders exact ties;
- exhaust contributors in fixed order;
- never rerank during one expenditure;
- insufficient total capacity prevents commit;
- exact debit vector is semantic history.

VS-SFL-046 now distinguishes this rule from dynamic reranking.

No further provision-allocation blocker was found.

## 6. Finding CLOS-D — response choice is still undefined

### Evidence

Accepted architecture says counterparties retain their own responses. The working Pass-B design says response mechanics may be proposal resolutions and explicitly says provision acceptance/refusal remains the person's decision. TRES-0001D repeatedly separates initiator intention from counterparty response.

But neither ADR-0002 nor SPEC-SFL-0001 defines how a deterministic v0 actor chooses a feasible response.

### Why mechanism-isolation does not solve it

Mechanism-isolation may script:

- accept;
- decline;
- fulfil;
- refuse.

That correctly tests transition semantics.

But Stage 4 is meant to be an autonomous reference simulation. If the implementation must decide whether B accepts A's gift/loan/residence/participation/provision/marriage-related proposal, it currently has to invent a policy.

### Recommendation

Adopt the narrow `ResponseDecisionContext` design recorded in:

`specifications/working/SFL_V0_STAGE3_RESPONSE_POLICY_ERRATUM.md`.

Key properties:

- same committed snapshot + proposal terms + target subjective state;
- infeasible -> `Unable(reason)` before voluntary scoring;
- feasible response meanings use the existing exact component-sum scorer;
- responses do not consume personal initiative;
- multiple responses may be selected; central resolver commits compatible effects;
- full response decision trace is retained.

This is the smallest extension consistent with the accepted agency architecture.

## 7. Finding CLOS-E — generic commitment-breach attitude effect is orphaned

The fixed attitude table includes a -20 event for breach of an accepted commitment.

No current v0 relation/process defines such a generic commitment or its breach.

Treating:

- called-favour refusal;
- debt nonpayment;
- provision failure;
- resolution invalidation;
- participation exit

as generic breach would either double-count or contradict their explicit semantics.

### Recommendation

Remove the generic breach attitude rule from v0 now.

Do not add a generic commitment subsystem merely to make one attitude row executable.

Recorded in:

`specifications/working/SFL_V0_STAGE3_COMMITMENT_BREACH_ERRATUM.md`.

## 8. Finding CLOS-F — card schema duplication risk repaired

The workbench originally said every card must restate fixture-write/oracle rules, while many cards relied on package conventions.

This is now explicit inheritance:

- every card inherits cross-cutting fixture-write restrictions and oracle rules;
- cards state only additional/narrower fixture permissions and claim-specific oracle details.

This keeps cards AI-readable without repetitive drift-prone boilerplate.

## 9. Finding CLOS-G — held-out evidence is now operationally distinct

The cross-cutting contract now defines concrete held-out recipes per major family.

Implementation tasks should lead with canonical cards; held-out instances can be materialized by the verification harness from the recipes rather than becoming the primary coding narrative.

This supports overfit resistance while keeping the repository transparent.

## 10. Finding CLOS-H — external verification-method recheck supports the package structure

A targeted 2026 recheck did not expose a better verification architecture.

Relevant evidence:

- Li & Offutt, *Test Oracle Strategies for Model-Based Testing*, IEEE TSE 43(4): richer state assertions reveal more faults than exception-only oracles; invariants are a useful low-cost oracle strategy.
- Recent industrial MBT research continues to treat model/test-code review and independent verification as important QA practices.
- Recent empirical property-based-testing work supports using generated inputs to exercise invariants while also showing that useful properties/generators generally require domain-specific design rather than fully automatic generation.
- Property-based mutation testing literature supports measuring whether tests actually exercise stated requirements, not merely whether arbitrary mutants crash.
- Recent trace-based metamorphic testing work on multi-agent systems reinforces the usefulness of behavior-preserving perturbations and structured trace comparison when conventional exact-output oracles are incomplete.

These sources support the project's combination of independent oracles, invariants, stateful generation, mutants, metamorphic pairs, and semantic traces. They do not supply SFL social semantics.

## 11. Coverage assessment

| Semantic area | Canonical coverage | Status |
|---|---|---|
| material maintenance / NeedsGrain / Farm | VS-SFL-090, 080 | Covered |
| attitude events / bounds / decay | VS-SFL-097 + boundary matrix | Covered except orphan breach row |
| gift/loan/transfer meaning | VS-SFL-091 | Covered |
| debt repayment/due review | VS-SFL-092 | Covered |
| favour creation/use/cancellation | VS-SFL-093/094 | Covered |
| direct marriage / kin exclusion | VS-SFL-095 | Covered |
| residence | VS-SFL-096/099 | Covered |
| personal initiative/scoring | scoring profiles, 098/099, 030/064/065 | Covered |
| counterparty response selection | mechanism cards can inject response | **Semantic blocker** |
| recognition/communication/staleness | VS-SFL-030–035 | Covered |
| formation | VS-SFL-001/002 + ablations | Covered |
| participation/continuity/lifecycle | VS-SFL-010–014 | Covered |
| lineage | VS-SFL-020–026 | Covered |
| provision/support/dowry | VS-SFL-040–046 | Covered |
| no self-confirmation | VS-SFL-050–053 | Covered |
| head role/succession/dual mode | VS-SFL-060–066 | Covered |
| failure/invalidation/priority/reactions | VS-SFL-070–076 | Covered |
| deadlock/fallback/checkpoint/rebuild/explainability | VS-SFL-080–087 | Covered |
| invariants/metamorphic/mutants/generated/held-out/fixtures | cross-cutting contract | Covered |

## 12. External sources checked

- Li & Offutt, *Test Oracle Strategies for Model-Based Testing*, IEEE Transactions on Software Engineering, DOI 10.1109/TSE.2016.2597136.
- *Practitioners' best practices to Adopt, Use or Abandon Model-based Testing with Graphical models for Software-intensive Systems*, Empirical Software Engineering (2022).
- *A Model-Based Test Script Generation Framework and Industrial Insight*, SN Computer Science (2025).
- Bartocci et al., *Property-Based Mutation Testing*, arXiv:2301.13615.
- de Oliveira et al., *Property-based testing in Python: empirical insights*, Empirical Software Engineering, published 2026.
- *Metamorphic Testing of Multi-Agent LLM Systems: A Trace-Based Behavioral Oracle Framework*, IEEE AITest 2026.

## 13. Closure decision

**Stage 3 should not close yet.**

Required Director decisions:

1. approve the recommended deterministic response-decision contract;
2. remove the orphan generic commitment-breach attitude row from v0, or explicitly choose to add a genuine commitment/breach mechanism instead.

If the recommended narrow resolutions are accepted, remaining work is clerical/verification closure:

- promote those semantics losslessly;
- pin response scoring profiles;
- add closed-loop response cards;
- update package/navigation;
- rerun the final coverage check;
- close Stage 3 and prepare the Stage-4 implementation packet.
