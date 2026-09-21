# Research Task Packet — Temporal / Determinism / Conflict Red Team

**Task ID:** TRES-0010C  
**Status:** OPEN  
**Context mode:** INDEPENDENT-CONTEXT with repository access / minimally anchored  
**Return:** `research/technical/TRES-0010/returns/TRES-0010C_TEMPORAL_DETERMINISM_REPORT.md`

## 1. Question

Can pathological same-cycle interactions break determinism, causal ordering, resource integrity, reaction closure, or stable-cycle publication under the accepted kernel?

## 2. Why it matters now

Slice 1 implements the first executable proposal/response/resolution loop; hidden ordering bugs here would contaminate every later slice.

## 3. Attack surface

Construct adversarial traces involving combinations of:

- personal initiative + multiple incoming responses;
- two accepted proposals competing for one resource;
- debt repayment and other transfers in one cycle;
- NeedsGrain maintenance/clearing plus proposals;
- response acceptance followed by precommit invalidation;
- equal-priority stable-ID fallback;
- automatic attitude reactions;
- debt N+3 review;
- same-cycle chained reactions;
- eventual household bridge-handoff semantics as a future compatibility check;
- checkpoint-safe boundary assumptions even though Slice 1 does not implement checkpointing.

Look for hidden dependence on:

- actor iteration order;
- proposal insertion order;
- response iteration order;
- dictionary/hash ordering;
- reaction scheduling order;
- cache refresh timing.

## 4. First-pass source restriction

Read:

- ADR-0004;
- SPEC §§5, 6.7, 9–10;
- response/scoring profiles;
- resolution/reaction and lower-level verification families;
- IMP-0001.

Do not read TRES-0003 before drafting initial findings.

## 5. Evidence standards

Blocker/high findings require an explicit event trace showing two plausible conforming executions diverging or violating an invariant.

## 6. Boundaries

Do not recommend parallelism, stochasticity, or a different kernel unless the accepted deterministic kernel is internally inconsistent.

## 7. Required output

Provide the smallest failing traces and identify whether the fix would be semantic, verification-only, or implementation guardrail.

## 8. Authority reminder

Advisory only.
