# IMP-0004 Escalation 01 — Master Architect Closure

**Status:** CLOSED / IMPLEMENTATION MAY CONTINUE  
**Date:** 2026-09-25  
**Escalation source:** `research/technical/IMP-0004/IMP-0004_IMPLEMENTATION_ESCALATION_01.md` on `implementation/imp-0004-slice4-household-head-collective-action`  
**Accepted closure:** `decisions/DEC-0014_HISTORICAL_MATERIAL_NEED_RECONSIDERATION_CONTEXT.md`  
**Implementation agent for continuation:** Astra  
**Recommended continuation effort:** **HIGH**

## Plain-language closure

The provision-reconsideration cooldown remains a deliberately crude v0 proxy for:

> do not repeatedly ask someone who already refused unless enough time has passed and circumstances have meaningfully changed.

For the accepted `new Household material need` context dimension, **the relevant change is historical since the latest refusal**.

A qualifying support/dowry material-need occurrence after refusal can unlock the context-change limb even if that need later disappears before the three-cycle cooldown ends.

A new refusal resets the baseline.

## Exact distinguishing witness

For the bārû's witness:

- N: A refuses provision;
- N+1: otherwise-valid positive-dowry mediated request occurs but funding is infeasible, so the action is Unable;
- N+4: no other accepted context dimension changed and the particular marriage need may no longer be current;

expected eligibility:

> **A may be asked again at N+4.**

Why:

- three full cycles elapsed;
- the N+1 dowry demand is a qualifying post-refusal Household material-need occurrence;
- funding infeasibility does not erase the occurrence.

If A refuses again at N+4, that refusal becomes the new baseline; the N+1 need cannot unlock another later request.

## Implementation constraints

The coder may implement the smallest authoritative state/provenance needed to answer the existing cooldown predicate.

Do not introduce:

- head adoption/approval of a pending need as a new action;
- generic demand/obligation objects;
- Household budgets/treasury;
- general persistent need queues;
- future economy architecture.

The implementation must not infer behavior-affecting eligibility from observer history at deliberation time.

Technical ProposalId/container/replay identity alone cannot establish material-need change.

## Verification

Implement/complete evidence for:

- VS-SFL-044 historical dowry witness;
- support need onset/re-entry;
- persistent pre-refusal support need negative control;
- later-refusal reset;
- funding-infeasible dowry positive case;
- mutants 53–56.

Frozen v2 acceptance remains unchanged and sufficient under the dedicated freshness revalidation.

## Execution recommendation

Use **Astra at HIGH effort** for this continuation.

Reason: DEC-0014 removes the semantic-choice burden, so Extra High/maximal exploratory reasoning is unnecessary; the remaining task still spans role state, epistemic state, funding, replay/dependency behavior, inherited-verification adaptations, a 165-row Slice-4 completion surface, and 270 inherited REQUIRED regressions. High effort is the appropriate balance for implementation breadth and verification risk.

## Continuation

IMP-0004 remains incomplete, but escalation 01 is no longer a semantic blocker.

Continue from the preserved implementation branch and finish the remaining packet gates.

If implementation exposes a new consequential semantic interaction or a different under-specified acceptance expectation, stop and escalate again rather than generalizing DEC-0014.
