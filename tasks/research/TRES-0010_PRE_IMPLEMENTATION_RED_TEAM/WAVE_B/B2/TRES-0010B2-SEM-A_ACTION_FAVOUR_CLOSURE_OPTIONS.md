# Research Task Packet — B2 Lower-Level Action / Favour Closure Options

**Task ID:** TRES-0010B2-SEM-A  
**Status:** OPEN  
**Context mode:** PROJECT-CONTEXT / decision support  
**Return:** `research/technical/TRES-0010/returns/TRES-0010B2-SEM-A_ACTION_FAVOUR_CLOSURE_OPTIONS_REPORT.md`

## 1. Question

What is the smallest coherent v0 semantic repair for:

- S1-SEM-03 — called-favour requested-action domain/completion;
- S1-SEM-04 — admissible grain-valued action quantities;
- S1-SEM-05 — explicit benefit-for-favour when the ordered-pair favour slot is already full?

## 2. Why it matters now

All three affect Slice-1 lower-level actions. Wave B confirms they cannot safely be left to coding-agent interpretation.

## 3. Required context

Read:

- `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`;
- SPEC §§2.2, 3.3–3.6, 5, 5.1, 9.1–9.3, 10;
- ADR-0002 and ADR-0004;
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, especially VS-SFL-091–094;
- `RESPONSE_DECISION_FAMILY.md`, especially VS-SFL-102/105;
- Wave-B action prosecution and defense reports;
- semantic sentinel only for the assigned F02/F04/F05 findings.

Do not read sibling B2 returns.

## 4. Called-favour objective

Determine the minimum positive callable-action grammar for v0.

Compare at least:

- a narrow whitelist of direct lower-level actions that do not generate a new counterpart response;
- a broader domain that allows ordinary actions requiring further response contexts;
- a semantic-class rule based on action completion properties rather than named action types.

For each, decide:

- whether requested action consumes personal initiative;
- whether fulfilment is response-scoped;
- whether nested response contexts are allowed;
- whether action failure leaves the favour outstanding;
- when the favour is consumed;
- how attitude effects apply;
- how Unable, Declined, and InvalidatedAtResolution propagate.

Prefer the smallest rule that proves the v0 favour mechanism without inventing a generic command/action framework.

## 5. Grain-amount objective

Define the semantic domain for all in-scope grain-valued action parameters.

At minimum examine:

- integer vs any numeric quantity;
- strict positivity;
- zero;
- negative values;
- repayment greater than remaining debt;
- transfer greater than available permissible capacity;
- dowry amount validity even though mediated dowry is later-slice.

Distinguish:
- categorical invalid proposal;
- feasible proposal later invalidated by changing capacity;
- Unable(reason);
- ordinary decline.

Do not let invalid parameter meaning be confused with voluntary refusal.

## 6. Benefit-for-favour capacity objective

Compare:

- atomic bargain: no new favour capacity => proposal infeasible/no material benefit commit;
- non-atomic conditional effect: material benefit may commit but favour creation is suppressed;
- any third interpretation supported by accepted causal meaning.

Analyze:

- semantic distinctness of OfferBenefitForFavor from Gift;
- target understanding/acceptance of explicit terms;
- pair-cardinality invariant;
- whether verification prose can legitimately narrow SPEC meaning;
- downstream attitude/history effects.

## 7. Required output

Return:

1. option matrix for all three issues;
2. recommended minimal rules;
3. exact proposed SPEC wording;
4. exact verification additions/changes;
5. response/failure classifications;
6. whether new assumption entries are appropriate;
7. effect on IMP-0001 action scope;
8. Director-facing decision summary.

Do not modify canonical artifacts.