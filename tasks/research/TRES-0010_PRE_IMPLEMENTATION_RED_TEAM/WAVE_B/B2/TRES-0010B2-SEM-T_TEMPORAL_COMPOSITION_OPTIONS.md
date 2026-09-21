# Research Task Packet — B2 Temporal Composition Options

**Task ID:** TRES-0010B2-SEM-T  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / decision support  
**Return:** `research/technical/TRES-0010/returns/TRES-0010B2-SEM-T_TEMPORAL_COMPOSITION_OPTIONS_REPORT.md`

## 1. Question

What is the smallest faithful semantic repair for:

- S1-SEM-01 — multiple distinct same-cycle automatic attitude effects on one bounded attitude;
- S1-SEM-02 — multiple accepted same-cycle Residence changes targeting one person?

## 2. Why it matters now

Both issues directly affect IMP-0001 and both prosecution/defense reviewers agreed existing authority permits multiple conforming outcomes.

Implementation must not choose ordering/conflict semantics accidentally.

## 3. Required context

Read:

- `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`;
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`, especially §§3.1, 3.6, 5.1, 9.1–9.4, 10;
- ADR-0004;
- `RESOLUTION_REACTION_FAMILY.md`;
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, especially VS-SFL-096/097;
- `RESPONSE_DECISION_FAMILY.md`, especially VS-SFL-103/105;
- Wave-B temporal prosecution and defense reports.

Do not read sibling B2 returns.

## 4. Objective

For **attitude reaction composition**, compare at minimum:

- canonical sequential semantic ordering of individual reaction causes;
- aggregation of commensurable attitude deltas followed by one clamp;
- any narrower conflict/closure rule that preserves individual causal history while making stable state deterministic.

For **Residence**, compare at minimum:

- one committed Residence transition per person/cycle, with accepted competing transitions forming a conflict set;
- canonical ordered multi-transition semantics;
- any narrower rule derived from existing proposal/precommit semantics.

Do not assume the example options are preferred. Reject them if they violate accepted authority.

## 5. Required analysis

For every option, analyze:

### Attitude
- stable final attitude near bounds;
- ReactionIndex/history semantics;
- attribution of individual causes;
- interaction with decay/due-review effects;
- whether order becomes social meaning or remains technical;
- verification/permutation behavior.

### Residence
- actor autonomy;
- response semantics;
- personal initiative + multiple incoming response combination;
- precommit revalidation;
- stable-ID fallback use;
- causal history;
- later co-residence consequences;
- whether multiple physical moves within one cycle are meaningful or merely mutation-order artifacts.

## 6. Required output

Return:

1. option matrix;
2. minimal counterexample under each option;
3. recommendation for each issue;
4. rationale translated into simulation consequences;
5. exact proposed semantic wording;
6. exact new/modified verification cards;
7. whether the recommendation needs a new assumption entry;
8. any knock-on effect on ADR-0004 or IMP-0001.

Do **not** modify the spec.

## 7. Director decision framing

End with a concise Director-facing choice for each issue:

- what actually changes in simulated behavior;
- recommended option;
- credible alternative(s);
- why the decision cannot safely remain local implementation detail.