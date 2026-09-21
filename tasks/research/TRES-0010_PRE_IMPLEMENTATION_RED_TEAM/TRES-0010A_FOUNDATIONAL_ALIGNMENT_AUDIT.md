# Research Task Packet — Foundational Alignment Red Team

**Task ID:** TRES-0010A  
**Status:** OPEN  
**Context mode:** INDEPENDENT-CONTEXT with repository access / minimally anchored  
**Return:** `research/technical/TRES-0010/returns/TRES-0010A_FOUNDATIONAL_ALIGNMENT_REPORT.md`

## 1. Question

Does the accepted SFL v0 model or implementation plan violate the project's founding causal philosophy in a subtle way?

## 2. Why it matters now

The first implementation will harden assumptions. A lower-level shortcut that contradicts the Seed/DEC-0001 is much cheaper to catch before code.

## 3. Objective / success condition

Find concrete cases where accepted SFL semantics or IMP-0001 accidentally:

- reintroduce primitive aggregate/container thinking;
- collapse distinguishable relations into one variable;
- make macro labels self-causal;
- infer identity from snapshots;
- hide causal genealogy;
- turn multidimensional social position into one scalar;
- erase persistent individual agency.

Success is a set of specific contradictions/counterexamples—or a credible no-blocker result after trying these attacks.

## 4. First-pass source restriction

Read first:

- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- `governance/WORKING_CONSTITUTION.md`
- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`

Before writing initial findings, **do not read TRES-0003 through TRES-0009**.

After initial findings are written, prior reviews may be checked only to classify duplicates/already-resolved issues.

## 5. Evidence standards

Use exact repository citations/path+section. Separate actual conflict from personal preference. Construct minimal counterexamples where possible.

## 6. Boundaries

Do not redesign SFL, propose historical calibration, choose implementation structures, or edit repository authority.

## 7. Required output

Use the common TRES-0010 finding schema. Include attacks that failed to expose a problem.

## 8. Authority reminder

Advisory only. Do not mutate canonical artifacts.
