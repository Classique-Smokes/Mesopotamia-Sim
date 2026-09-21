# Research Task Packet — Semantic Reachability / State-Machine Audit

**Task ID:** TRES-0010B  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT  
**Return:** `research/technical/TRES-0010/returns/TRES-0010B_SEMANTIC_REACHABILITY_REPORT.md`

## 1. Question

Is every accepted SFL v0 state, transition, event consequence, warrant, failure state, and lifecycle outcome actually reachable and well-defined without inventing semantics?

## 2. Why it matters now

Earlier adversarial review found orphan and missing transitions. This task systematically repeats that attack across the now-final specification.

## 3. Objective / success condition

Build a semantic reachability inventory for in-scope SFL v0. For each important state/relation/event:

- creation preconditions;
- mutation/update path;
- satisfaction/termination path;
- automatic reactions;
- actor visibility/knowledge effects;
- invalid/failure path;
- whether it can become permanently stuck;
- whether the transition requires its own result as evidence.

Flag:

- orphan rules;
- unreachable states;
- undefined terminal states;
- circular preconditions;
- duplicate meanings with conflicting consequences;
- transitions absent from verification;
- implicit deletion/history loss.

## 4. Required context

- `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `registers/ASSUMPTIONS_REGISTER.md`
- `plans/verification/SFL_V0/`
- accepted ADR-0001 / ADR-0002 / ADR-0004

Prior TRES reports may be consulted only after the independent inventory is drafted.

## 5. Evidence standards

Every blocker/high finding must identify the exact semantic object and a minimal path showing the gap.

## 6. Boundaries

Do not add mechanics merely to make an orphan rule reachable. Do not interpret historical realism. Do not modify artifacts.

## 7. Required output

Include a compact reachability matrix plus common-schema findings.

## 8. Authority reminder

Advisory only.
