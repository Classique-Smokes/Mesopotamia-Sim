# TRES-0011C — External Simulation-Methodology Review of the V0 Resource Scaffold

**Task type:** independent external research  
**Context mode:** INDEPENDENT-CONTEXT + project application after literature review  
**Role:** simulation-methodology researcher  
**Authority:** advisory only

## Question

From the perspective of established agent-based/social-simulation methodology, is it methodologically defensible for SFL v0 to use an intentionally crude, explicitly provisional Household resource mechanism to test social/institutional causality — or should a resource subsystem be historically/economically mature before the laboratory can support useful conclusions?

The answer must be tied to the model's stated purpose, not generic pro-simplicity slogans.

## Independence sequence

### Phase 1 — external literature first

Before reading detailed project resource semantics, research authoritative literature on:

- model purpose / fitness for purpose;
- exploratory/theoretical versus predictive/calibrated simulation;
- KISS/KIDS and appropriate model complexity;
- progressive/additive refinement;
- pattern-oriented modeling;
- reference/stylized models and controlled experiments;
- structural uncertainty and sensitivity to mechanism choice;
- dangers of overinterpreting outputs from provisional submodels;
- modularity/replacement in evolving ABMs where relevant.

Prefer:

- peer-reviewed methodology;
- recognized ABM/social-simulation sources;
- established textbooks/handbooks or institutional publications.

Use at least 6 substantive sources, preferably 8–12.

Useful starting points, not mandatory limits:

- Grimm et al., ODD protocol / purpose and patterns;
- Edmonds on different modelling purposes;
- KISS/KIDS literature;
- simulation-modeling pitfall/refinement literature.

### Phase 2 — apply to project

Then read:

- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`
- `plans/FIRST_PROTOTYPE_DEVELOPMENT_ROADMAP.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md`

## Required analysis

### A. What kind of model is v0?

Classify its purpose using the literature:

- illustration;
- theoretical/explanatory mechanism model;
- exploratory model;
- descriptive/historical model;
- predictive/calibrated model;
- reference implementation/laboratory.

It may fit more than one category. Explain consequences.

### B. When is crude acceptable?

Give criteria under which a simplified subsystem is methodologically acceptable because it merely makes another causal mechanism testable.

### C. When is crude dangerous?

Give criteria where a placeholder mechanism contaminates the model's conclusions, e.g.:

- the observed phenomenon is highly sensitive to the placeholder;
- the placeholder pre-decides the causal mechanism being studied;
- outputs are interpreted as empirical/historical claims;
- coupling makes later replacement invalidate unrelated conclusions.

### D. Progressive refinement

Assess whether "build one grounded collective capability, observe, later replace/refine the economic mechanism" is a recognized defensible development strategy for a mechanism laboratory.

Do not assume the answer is yes.

### E. Project-specific recommendation

State what claims SFL v0 may safely make with the current resource scaffold and what claims it must explicitly **not** make.

Identify any experiment/sensitivity check that should be run before trusting v0 observations.

## Required output

Create:

`research/technical/TRES-0011/TRES-0011C_EXTERNAL_SIMULATION_METHODOLOGY.md`

Include:

- source table with links/citations;
- literature findings;
- project application clearly separated from source claims;
- limitations/disagreements in methodology;
- recommendations.

Use exactly one verdict:

- **METHODOLOGICALLY FIT FOR STATED LAB PURPOSE**
- **FIT ONLY WITH EXPLICIT INTERPRETATION / SENSITIVITY GUARDRAILS**
- **PLACEHOLDER MECHANISM UNDERMINES THE LAB PURPOSE**

## Return discipline

Return branch:

`research/tres-0011c-external-simulation-methodology-return`

Begin from:

`tres-0011-v0-resource-scaffold-wave-v1`

Add only the report.
