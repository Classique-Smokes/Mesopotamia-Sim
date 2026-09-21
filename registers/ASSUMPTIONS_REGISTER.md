# Assumptions Register

**Purpose:** Keep temporary assumptions visible so prototypes, tests, research, or incomplete systems do not fossilize into project truth.

## Statuses

`ACTIVE / UNDER_REVIEW / RETIRED`

## Required fields

| Field | Meaning |
|---|---|
| Assumption ID | Stable ID, e.g. `ASM-0001` |
| Status | ACTIVE / UNDER_REVIEW / RETIRED |
| Assumption | What is temporarily being assumed |
| Why needed | Why work cannot currently proceed without it |
| Scope / impact | Where it affects behavior, evidence interpretation, testing, or architecture |
| Authority boundary | What this assumption is explicitly **not** allowed to decide |
| Review / replacement trigger | Evidence, decision, experiment, or milestone that would allow replacement/review |
| Introduced by / date | Provenance |
| Related artifacts | Tasks, specs, evidence, or decisions |

## Current register

`SPEC-SFL-0001` currently uses the controlled laboratory assumptions below. They remain replaceable and do not become broader project truth merely by being active.

| Assumption ID | Status | Assumption | Scope / impact | Review trigger |
|---|---|---|---|---|
| ASM-0001 | ACTIVE | Relationship-mediated reciprocity may create a favour only when the recipient's directed attitude toward the benefactor is >= +75 (strong-like). | SFL v0 favour creation and actor evaluation. | Historical evidence, scenario testing, or Pass B/G verification showing the threshold is misleading or unnecessary. |
| ASM-0002 | ACTIVE | v0 attitude events use fixed increments and natural drift of +attitude by 2 toward zero versus -attitude by 1 toward zero per decay event. | SFL v0 relationship dynamics. | Verification or historical/behavioral evidence showing the magnitudes distort the laboratory. |
| ASM-0003 | ACTIVE | Farm yields 4 grain; consumption is 1 per cycle; typical initial stock is 4-8; debt repayment preserves a 2-grain reserve. | SFL v0 scarcity/debt behavior. | Verification, balance testing, or later economic subsystem. |
| ASM-0004 | ACTIVE | Parent/child and sibling kinship both multiply the attitude-derived component of ordinary interpersonal choice by 1.5x. | SFL v0 kinship effect. | Historical evidence or verification showing type-specific/different treatment is required. |
| ASM-0005 | ACTIVE | Initial v0 household formation requires at least two distinct people, shared residence, a durable tie, two qualifying support events on separate cycles, and founding-core recognition. | SFL v0 household formation recognizer. | Historical evidence, verification, or later household model showing the gate is too narrow/broad. |
| ASM-0006 | ACTIVE | Head appointment/succession requires unanimous sustaining-participant acceptance; provision spending uses a 2-grain contributor reserve and fixed-rank/exhaust-in-order allocation by precommit exposed capacity descending, stable semantic ID for exact ties. | SFL v0 collective authority/resource mobilization. | Verification, historical evidence, or richer governance/accounting rules. |
| ASM-0007 | ACTIVE | v0 temporal lab parameters: attitude decay every 5 cycles; provision reconsideration cooldown 3 full cycles plus relevant context change; stable semantic ID as last-resort equal-priority tie-break. | SFL v0 timing/conflict resolution. | Verification sensitivity or later social priority/timing rules. |
| ASM-0008 | ACTIVE | Loan social due review occurs after the third subsequent full cycle; any remaining balance causes one creditor->debtor -10 attitude event, regardless of ability to repay. | SFL v0 debt relationship dynamics. | Verification/model iteration or later debt/default institutions. |
| ASM-0009 | ACTIVE | Established-household participation entry requires bilateral invitation/request plus recognition of H, a continuity bridge, shared residence, durable tie, and one qualifying post-formation support event; entry may reactivate an Inactive H through its sole bearer; exit is explicit. | SFL v0 sustaining-participant turnover. | Verification or later household admission/exit norms. |
| ASM-0010 | ACTIVE | Household operational lifecycle uses 2+ sustaining participants = Active, 1 = Inactive, 0 = Dissolved; count does not establish identity. | SFL v0 operational lifecycle and continuity tests. | Verification/model iteration or richer household-activity semantics. |
| ASM-0011 | ACTIVE | Controlled v0 lineage classification requires fresh post-separation organizational evidence, predecessor-source clarity, and narrow all-founders-from-predecessor scope; ambiguous/mixed-origin cases receive no lineage classification. | SFL v0 division/consolidation proof cases only. | Verification/model iteration or richer lineage/inheritance/fission/merger model. |
| ASM-0012 | ACTIVE | Reference v0 actor scoring uses named exact-integer components summed to FinalScore; highest score wins; domain tie key if explicitly defined, otherwise disclosed stable-semantic-ID fallback. Exact component coefficients remain laboratory configuration. | SFL v0 deterministic reference agency and closed-loop verification. | Model iteration or replacement/extension of the v0 reference policy. |
| ASM-0013 | ACTIVE | Feasible counterparty responses use deterministic ResponseDecisionContext with the same exact component-sum scorer; infeasibility yields Unable before voluntary scoring; response coefficients remain laboratory configuration. | SFL v0 autonomous counterparty agency and response verification. | Model iteration or richer negotiation/norm/coercion response semantics. |

### ASM-0001 — Reciprocity attitude gate

- **Status:** ACTIVE
- **Assumption:** For SFL v0, an accepted beneficial action may create a relationship-mediated favour only when the recipient's directed attitude toward the benefactor is at least +75, corresponding to the current strong-like band.
- **Why temporarily needed:** The laboratory needs a simple, inspectable gate distinguishing ordinary accepted benefits from socially obligation-bearing reciprocity without yet implementing norms, reputation, or richer relational context.
- **Scope / impact:** Favour creation and the decision consequences of accepting beneficial actions.
- **Not authoritative for:** Old Babylonian reciprocity thresholds, historical psychology, universal social behavior, or later project-wide norm mechanics.
- **Review / replacement trigger:** Reconciliation/promotion of relevant RES-0001 evidence; a later norm/reputation/recognition model; or verification scenarios showing the threshold produces poor or degenerate behavior.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0002 — Attitude dynamics parameters

- **Status:** ACTIVE
- **Assumption:** v0 uses fixed attitude increments (+5/+10/-5/-10/-20 by event) and, on each later-scheduled decay event, positive attitude moves 2 toward zero while negative attitude moves 1 toward zero.
- **Why temporarily needed:** Deterministic inspectable relationship dynamics are required without claiming a psychological calibration.
- **Scope / impact:** Actor social evaluation and long-run relationship persistence.
- **Not authoritative for:** Historical psychology, real-world relationship rates, or later personality systems.
- **Review / replacement trigger:** Verification/balance testing or relevant research.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0003 — Grain laboratory parameters

- **Status:** ACTIVE
- **Assumption:** Farm yields 4 grain; consumption costs 1 per cycle; typical scenario start is 4-8 grain; debt repayment preserves 2 grain.
- **Why temporarily needed:** v0 needs renewable scarcity and material tradeoffs.
- **Scope / impact:** Farming, subsistence, lending, repayment, gifts, and later household resource coordination.
- **Not authoritative for:** Historical yields, rations, prices, household wealth, or economic calibration.
- **Review / replacement trigger:** Verification/balance testing or introduction of a historical economic subsystem.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0004 — Kinship attitude amplification

- **Status:** ACTIVE
- **Assumption:** Parent/child and sibling relations both multiply the attitude-derived component of ordinary interpersonal decision evaluation by 1.5x; marriage is excluded.
- **Why temporarily needed:** Kinship must matter behaviorally in v0 without becoming household membership or a second attitude variable.
- **Scope / impact:** Ordinary interpersonal action scoring.
- **Not authoritative for:** Historical kin obligations, marriage rules beyond the explicit v0 exclusion, or relative strengths of kin categories.
- **Review / replacement trigger:** Reconciled/promoted historical research or verification showing the factor/type uniformity is inadequate.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0005 — Household formation gate

- **Status:** ACTIVE
- **Assumption:** Initial v0 formation requires a founding core of at least two distinct people, shared residence, a kinship/marriage/mutual-strong-like durable tie, two qualifying support events on separate cycles, and recognition by every required founding-core actor.
- **Why temporarily needed:** v0 needs a falsifiable formation gate without claiming a universal or historical household definition.
- **Scope / impact:** Candidate-to-household formation only; later continuity uses a different historical rule.
- **Not authoritative for:** Old Babylonian household prevalence, universal household formation, later institutional or lifecycle models.
- **Review / replacement trigger:** Historical evidence, verification results, or expansion beyond the first household laboratory.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0006 — v0 household governance and allocation

- **Status:** ACTIVE
- **Assumption:** Head appointment/succession uses unanimous sustaining-participant acceptance. Provision commitments expose grain above the existing 2-grain personal reserve. For one expenditure, precommit capacities are ranked once descending; exact ties use stable semantic ID; contributors are exhausted in that fixed order without reranking.
- **Why temporarily needed:** v0 needs deterministic, inspectable authority and resource-allocation rules without a broader governance/accounting system.
- **Scope / impact:** Household head legitimacy, collective support, dowry funding, and double-spend prevention.
- **Not authoritative for:** Historical household governance, contribution shares, taxation, property, inheritance, or later office/accounting systems.
- **Review / replacement trigger:** Verification, reconciled/promoted historical evidence, or expansion to richer governance/resource systems.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`

### ASM-0007 — v0 timing and technical tie fallback

- **Status:** ACTIVE
- **Assumption:** Attitude decay occurs every 5 cycles; provision reconsideration requires 3 full cycles plus relevant context change; otherwise unresolved equal-priority symmetry uses stable semantic ID as a disclosed technical fallback.
- **Why temporarily needed:** v0 requires exact deterministic timing and conflict closure before richer social timing/priority norms exist.
- **Scope / impact:** Relationship fading, head reconsideration behavior, and rare equal-priority resolution.
- **Not authoritative for:** Historical time units, social priority norms, fairness, seniority, or later governance rules.
- **Review / replacement trigger:** Pass G permutation/sensitivity tests, model iteration, or introduction of richer social priority/timing rules.
- **Introduced by:** Director / Master Architect working specification discussion
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/working/SFL_V0_WORKING_SPEC.md`; `research/technical/TRES-0003/PASS_F_TEMPORAL_RESOLUTION_ADVERSARIAL_REVIEW.md`

### ASM-0008 — Debt social due cycle

- **Status:** ACTIVE
- **Assumption:** A loan's social due review occurs after the third subsequent full cycle after commitment. If any balance remains then, creditor -> debtor attitude changes -10 exactly once, regardless of ability to repay.
- **Why temporarily needed:** v0 needs a simple relationship consequence for prolonged nonpayment without adding interest, default, enforcement, or collection mechanics.
- **Scope / impact:** Debt-related attitude dynamics only.
- **Not authoritative for:** Historical loan terms, due dates, enforcement, default law, interest, or repayment schedules.
- **Review / replacement trigger:** Verification/model iteration or introduction of richer debt/institutional rules.
- **Introduced by:** Director / Master Architect Stage-3 semantic errata resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

### ASM-0009 — Established-household participation gate

- **Status:** ACTIVE
- **Assumption:** A nonparticipant joins an Active household, or reactivates an Inactive household through its sole continuity bearer, only through a bilateral invitation/request backed by a ParticipationWarrant: newcomer recognizes H; a current sustaining participant bridges the same H; shared residence; durable tie; one qualifying post-formation support event; and mutual acceptance. Exit is an explicit participation-end commit.
- **Why temporarily needed:** v0 must demonstrate real constituent turnover without a primitive membership write or arbitrary residence-based automatic admission/removal.
- **Scope / impact:** SustainingParticipant entry/exit and household continuity.
- **Not authoritative for:** Historical admission norms, dependency, slavery, marriage transfer, adoption, inheritance, or later institutional membership systems.
- **Review / replacement trigger:** Verification/model iteration or richer household-status research/modeling.
- **Introduced by:** Director / Master Architect Stage-3 semantic errata resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`; `research/technical/TRES-0005/STAGE3_GUARDRAIL_SCENARIO_ADVERSARIAL_REVIEW.md`

### ASM-0010 — v0 household operational lifecycle

- **Status:** ACTIVE
- **Assumption:** Operational household state is Active with 2+ current SustainingParticipants, Inactive with exactly 1, and Dissolved with 0. This count controls operational state only; household identity remains grounded in historical formation/continuity warrants.
- **Why temporarily needed:** v0 needs exact, testable activity/reactivation/dissolution behavior without re-running the formation predicate or introducing a richer organizational-capacity model.
- **Scope / impact:** Household-mode eligibility, inactivity/reactivation, dissolution, and continuity verification.
- **Not authoritative for:** Universal household ontology, historical household minimum size, later institutional activity criteria, or identity itself.
- **Review / replacement trigger:** Verification/model iteration or introduction of richer organizational activity/continuity semantics.
- **Introduced by:** Director / Master Architect continuity adversarial-review resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`; `research/technical/TRES-0006/CONTINUITY_LIFECYCLE_SCENARIO_ADVERSARIAL_REVIEW.md`

### ASM-0011 — Controlled v0 lineage classification

- **Status:** ACTIVE
- **Assumption:** v0 lineage is deliberately narrow. Division lineage requires every successor founder to map to the predecessor and at least one qualifying person-person support event after all cited predecessor exits. Consolidation lineage requires both predecessors dissolved, every successor founder mapped to one of the two predecessors with at least one from each, and at least one post-dissolution cross-predecessor qualifying support event. Ambiguous or mixed-origin cases form normally but receive no v0 lineage classification.
- **Why temporarily needed:** Stage-3 must test descent separately from identity without inventing a general theory of fission, consolidation, inheritance, or mixed-origin organizational ancestry.
- **Scope / impact:** `LineageWarrant`, direct `DerivedFrom` classification, and controlled division/consolidation scenarios.
- **Not authoritative for:** Historical lineage norms, inheritance, universal organizational descent, absorption, multiple descendants, contested succession, or future mixed-origin household formation.
- **Review / replacement trigger:** Verification/model iteration or introduction of richer lifecycle/lineage/inheritance semantics.
- **Introduced by:** Director / Master Architect lineage adversarial-review resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`; `research/technical/TRES-0007/LINEAGE_WARRANT_ADVERSARIAL_REVIEW.md`

### ASM-0012 — Reference v0 scoring aggregation

- **Status:** ACTIVE
- **Assumption:** After categorical candidate gates, each candidate receives named exact-integer score components; `FinalScore` is their sum; highest final score wins. An explicitly defined domain tie key resolves exact-score ties where available, otherwise the disclosed stable-semantic-ID technical fallback applies and is logged. Component coefficients are scenario/laboratory configuration.
- **Why temporarily needed:** The deterministic reference laboratory requires one exact, independently testable selector without making its numeric weights a permanent theory of human decision-making.
- **Scope / impact:** Reference personal/household decision selection, decision traces, and Stage-3 closed-loop scenarios.
- **Not authoritative for:** Historical psychology, final cognition architecture, personality heterogeneity, learned policies, stochastic choice, or later planners.
- **Review / replacement trigger:** Model iteration after the reference prototype, or acceptance of a richer agency policy.
- **Introduced by:** Director / Master Architect final Stage-3 semantic-gate resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`; `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`

### ASM-0013 — Reference response decision policy

- **Status:** ACTIVE
- **Assumption:** Incoming proposals that require a target choice activate a deterministic ResponseDecisionContext. Feasibility is checked before voluntary response scoring; infeasible requests yield Unable(reason). Feasible response meanings use the same named exact-integer component scorer as personal/household choices. Response contexts consume no personal initiative and remain subject to central revalidation/resolution.
- **Why temporarily needed:** The autonomous reference laboratory requires a deterministic counterparty policy without introducing a second cognition architecture or allowing initiators to control targets.
- **Scope / impact:** Proposal acceptance/refusal/fulfilment decisions and response traces.
- **Not authoritative for:** Historical bargaining psychology, coercion, persuasion, trust, reputation, negotiation, or final cognition architecture.
- **Review / replacement trigger:** Model iteration after the reference prototype or acceptance of richer response/negotiation semantics.
- **Introduced by:** Director / Master Architect TRES-0008 closure resolution
- **Date:** 2026-09-21
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`; `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`

## Entry template

### ASM-XXXX — [Short title]

- **Status:** ACTIVE
- **Assumption:**
- **Why temporarily needed:**
- **Scope / impact:**
- **Not authoritative for:**
- **Review / replacement trigger:**
- **Introduced by:**
- **Date:** YYYY-MM-DD
- **Related artifacts:**
