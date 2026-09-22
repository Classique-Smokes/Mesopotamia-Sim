# Research → Design → Promotion Procedure for Institutional Dynamics

**Status:** DURABLE NON-AUTHORITATIVE / PROVISIONAL GUIDING FRAMEWORK  
**Role:** Proposed process for turning conceptual material into project authority without skipping evidence or letting memorable stories become mechanics.

## 1. Trigger

Do not launch this process merely because the conceptual package exists.

Reasonable triggers include:

- SFL v0 reaches a verified state that exposes a concrete generalization question;
- an inter-slice observation surfaces a repeated pattern or distinction identified in `07_SFL_V0_DISCOVERY_SEAMS.md` that now matters to a concrete design decision;
- a later roadmap decision requires institutional persistence/office/artifact/task machinery;
- a specific historical target requires these mechanisms;
- household challenge cases reveal an architectural seam that must be generalized.

## 2. Stage A — conceptual proposition extraction

For the relevant question:

- identify exact source tablets/sections;
- record source status: surviving direct artifact, later copy/transformation, reconstruction from memory, or inferred missing source;
- never present a reconstruction as equivalent to a lost original;
- extract causal propositions, distinctions, and challenge cases;
- distinguish observation from inference;
- list alternative interpretations;
- explicitly identify what is only project analogy.

Output should remain under `research/conceptual/`.

## 3. Stage B — existing-substrate audit

Ask:

- what accepted SFL mechanisms already express this phenomenon;
- what can be represented by composition rather than new primitives;
- which apparent gap is semantic versus verification versus implementation-local;
- which v0 mechanism is merely household-specific and should not be generalized.

Output: a mechanism-gap map, not code.

## 4. Stage C — bounded historical research

Choose a period/place/archive/social context appropriate to the mechanism.

Research should examine historically real forms relevant to the question, including cases where surviving archives are partial, retrospective, copied, or later than the underlying institution.

Examples include:

- office succession and authority;
- temple/palace administrative continuity;
- documentary practices;
- delegation/accountability;
- collective identity/lineage claims.

Do not use the Uruk stories as historical evidence.

Outputs should preserve direct evidence, scholarly interpretation, uncertainty, and context limits.

## 5. Stage D — technical/design research

Independently investigate candidate simulation representations.

Prefer multiple alternatives where the design is consequential.

Questions may include:

- what is primitive versus derived;
- identity/lifecycle representation;
- subjective/objective separation;
- provenance/history representation;
- performance/scaling implications;
- migration path from reference implementation;
- whether one mechanism works across multiple institutional forms.

## 6. Stage E — candidate semantic model

The Master Architect synthesizes evidence into a proposed semantic model.

It should state:

- entity/relation/process meanings;
- identity and lifecycle;
- authority and recognition boundaries;
- subjective versus objective state;
- causality/history requirements;
- unresolved matters;
- explicit exclusions;
- relationship to existing SFL semantics.

No implementation architecture should fill missing social meaning.

## 7. Stage F — challenge-case falsification

Run the proposed semantics against selected Uruk-derived cases and historically grounded countercases.

A candidate should be revised or rejected if it only handles the intended happy-path institution.

Require the model to explain the separable states of:

- identity;
- continuity;
- authority;
- capability;
- recognition;
- genealogy;
- memory/provenance.

## 8. Stage G — authority decision

Consequential changes to foundational social/institutional semantics require explicit Project Director approval at the appropriate authority level.

The proposal should explain:

- what new primitive or rule is being added;
- why existing mechanisms are insufficient;
- alternatives;
- tradeoffs;
- reversibility;
- historical evidence limits;
- which conceptual distinctions remain unresolved.

## 9. Stage H — specification and verification

Only after approval:

- promote concise accepted semantics;
- design exact verification/challenge scenarios;
- distinguish acceptance authority from implementation;
- freeze consequential applicability where omission/self-selection risk warrants it;
- preserve deferred cases visibly.

## 10. Stage I — implementation

Implementation agents receive bounded authority.

They may choose local representation inside accepted semantics but must escalate if coding pressure would:

- collapse objective and subjective state;
- make current composition determine identity;
- convert recognition into objective truth;
- give higher-order actors unexplained powers;
- erase provenance;
- universalize one institution's mechanics;
- introduce an irreversible abstraction or scaling strategy.

## 11. Stage J — post-implementation conformance

Verify that implementation still expresses the accepted semantics and challenge-case distinctions.

For institutional systems, green unit tests alone are insufficient if the model's causal genealogy cannot be reconstructed.

## 12. Repository placement

Suggested placement by maturity:

- observer/source tales → `research/conceptual/THE_URUK_ACCIDENT/`
- derived conceptual synthesis → `research/conceptual/INSTITUTIONAL_DYNAMICS/`
- historical evidence → `research/historical/<bounded-program>/`
- technical/design research → `research/technical/<program>/`
- proposals → `proposals/`
- accepted decisions → `decisions/` / `architecture/accepted/`
- accepted semantics → `specifications/`
- verification → `plans/verification/`
- implementation packet → `tasks/implementation/`

Do not move conceptual drafts into accepted directories for convenience.
