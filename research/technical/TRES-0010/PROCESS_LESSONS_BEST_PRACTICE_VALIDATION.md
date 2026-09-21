# TRES-0010 — Best-Practice Validation of Provisional Process Lessons

**Status:** SUPPORTING RESEARCH / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Purpose:** Test the provisional Wave-A process lessons against broader software/systems engineering, verification, formal-methods, and AI-agent evaluation practice before any governance promotion.

## 1. Sources consulted

### Requirements / systems engineering

- NASA Systems Engineering Handbook, Appendix C: good requirements should be clear, complete, consistent, traceable, feasible, and verifiable; completeness review asks whether requirements or assumptions are missing and whether intended sequences are stated.
- NASA Software Engineering Handbook SWE-050 / SWE-051: requirements should be measurable, quantitative, finite/bounded where applicable, and complete with no undefined conditions.
- NASA Requirements Verification Matrix guidance: each requirement should have a unique identifier, source, and verification method.
- NASA requirements compliance matrices: applicability should be explicit; non-applicability should be justified.
- INCOSE Guide to Writing Requirements: requirement sets should be complete, consistent, feasible, comprehensible, and validatable.

### State / interaction analysis

- NASA Systems Engineering Handbook timing/state analysis: state diagrams and interaction/timing analysis exist to expose concurrency, overlap, sequencing, and multi-path behavior before implementation.
- NASA critical finite-state-machine guidance: every state should define behavior for every input; out-of-range/unexpected inputs require defined behavior; deterministic behavior should be demonstrated.
- NIST combinatorial testing research: many faults arise only from interactions among multiple factors; pairwise coverage is useful but not always sufficient.
- TLA+/TLC literature and AWS industrial experience: explicit state-machine specifications and model checking can expose subtle multi-step/interleaving defects that survive conventional design/code review and testing.

### Architecture / assurance

- SEI Architecture Tradeoff Analysis Method (ATAM): scenario-driven architecture evaluation before implementation is used to identify risks, sensitivity points, and tradeoff themes.
- NASA Software Assurance / IV&V: independent verification and validation uses technical independence from the developer to provide objective assurance evidence.

### AI-agent evaluation

- NIST CAISI, Cheating On AI Agent Evaluations: agent evaluations can be invalidated by grader gaming and solution contamination; recommended mitigations include closing task-design loopholes, clarifying affordances/restrictions, and reviewing how the task was solved rather than only whether it scored green.

## 2. Validation of provisional lessons

| Lesson | External-practice assessment | Strength | Qualification |
|---|---|---|---|
| PL-01 Semantic nouns need lifecycle closure | Strongly aligned with state-machine completeness, state analysis, requirements completeness, and explicit transition/error handling. | **STRONG** | “Semantic noun lifecycle” is our project-specific formulation; not every immutable/value object needs a lifecycle. Apply to stateful authoritative semantic objects. |
| PL-02 Action parameters need explicit validity domains | Directly supported by NASA guidance that requirements be measurable/quantitative/finite and that out-of-range/unexpected inputs have defined responses. | **VERY STRONG** | Avoid over-specifying harmless internal implementation values; focus on externally/semantically consequential parameters. |
| PL-03 Local transition rules do not guarantee composition closure | Strongly supported by NIST interaction-fault evidence, NASA timing/state analysis, and formal-methods practice around nondeterministic/interleaved actions. | **VERY STRONG** | Exhaustive all-pairs/all-triples review is not always economical; use risk-based interaction classes and model checking/combinatorial techniques where leverage is high. |
| PL-04 Nested-action semantics require an explicit completion unit | Supported by requirements/interface/state-transition completeness and formal action-composition/atomicity practice. | **STRONG** | “Completion unit” is project language; general principle is explicit transaction/action boundaries, success propagation, nested dependencies, and ownership of side effects. |
| PL-05 Stage closure needs systematic reachability/composition audit | Supported by formal inspection, requirements completeness analysis, state analysis, scenario-based architecture analysis, and model checking. | **VERY STRONG** | The audit should be risk-scaled; not every subsystem requires a full formal state-space proof. |
| PL-06 Verification authority should be independent from implementation authority | Directly supported by NASA IV&V technical independence; strongly reinforced for AI coding agents by NIST evidence of grader gaming. | **VERY STRONG** | Full organizational IV&V separation is disproportionate here; technical independence of protected acceptance/oracle surfaces is the appropriate lightweight adaptation. |
| PL-07 Implementation packets need a closed applicability manifest | Closely aligned with NASA requirements verification/compliance matrices: uniquely identify requirements, verification method, applicability, and justify N/A. | **VERY STRONG** | A machine-readable matrix is desirable but not mandatory if a concise exact table is enough. |
| PL-08 Preserve future seams without implementing future slices | Aligned with architecture evaluation, explicit interfaces, weak coupling, traceability, and progressive refinement. | **STRONG** | Avoid “future proofing” by speculative abstraction. Preserve only accepted seams/invariants likely to be expensive to retrofit. |
| PL-09 Authority taxonomy in task packets must be explicit | Supported by requirements source/traceability practice and NASA distinction between applicable/binding versus reference material. | **STRONG** | Primarily an AI/repository governance adaptation, not a universal systems-engineering law. |
| PL-10 Adversarial review should occur at integration boundaries | Supported by ATAM scenario analysis, formal inspections, IV&V through lifecycle, and NIST interaction-fault evidence. | **VERY STRONG** | Integration red teams should be consequence-scaled; use them where interacting semantics or architectural commitments create expensive downstream inertia. |

## 3. Additional candidate lessons suggested by external practice

### PL-11 — Undefined conditions must remain explicit until closure

NASA requirements guidance treats completeness as absence of omissions/undefined conditions and recommends tracking unresolved TBD/TBR items rather than letting them disappear into prose.

Project adaptation: before declaring a subsystem/specification stage closed, require one explicit pass for undefined input domains, invalid/error outcomes, event/state combinations, applicability, and assumptions not yet confirmed.

### PL-12 — Use risk-scaled formalization for composition hotspots

Formal methods do not need to become the project's general specification language. But TLA+/TLC literature and AWS experience show that small high-level state-machine models can expose interleaving/composition defects missed by extensive ordinary review.

Project adaptation: when a subsystem has same-cycle multi-action resolution, bounded non-commutative state updates, authority/precondition races, nested proposal/response chains, or checkpoint/replay exactness, consider a tiny formal/model-checking probe or exhaustively enumerated reference model before implementation.

This should be an escalation tool, not mandatory ceremony.

### PL-13 — Verification coverage should be traceable requirement-by-requirement

NASA verification-matrix practice is stronger than our current family-level “there is a scenario for this behavior.”

Project adaptation: for consequential implementation slices, maintain a compact matrix containing authoritative clause/assertion ID, slice applicability, executable acceptance check, independent oracle source, metamorphic/mutant companions, evidence artifact, and N/A rationale.

## 4. What the external research does not justify

It does not justify converting the whole project to formal methods, adding heavyweight systems-engineering bureaucracy, requiring independent human teams for every slice, exhaustive combinatorial testing over every semantic dimension, or building a generic verification framework before the first reference implementation.

The general best practice is systematic, traceable, independent-enough assurance scaled to consequence.

## 5. Provisional recommendation

Subject to Wave-B confirmation, PL-02, PL-03, PL-05, PL-06, PL-07/PL-13, and PL-10 currently have the strongest external-practice support.

PL-01, PL-04, PL-08, and PL-09 also look durable, but should be phrased narrowly to avoid over-generalization.

PL-11 and PL-12 are new candidates worth considering after Wave B.

Do not promote any item into governance/templates until TRES-0010 reconciliation distinguishes one-off SFL fixes, implementation guardrails, reusable task-template improvements, and durable Master Architect rules.