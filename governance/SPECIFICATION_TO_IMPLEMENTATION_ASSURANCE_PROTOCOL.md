# Specification-to-Implementation Assurance Protocol

**Status:** ACCEPTED — Master Architect operating protocol  
**Authority:** Subordinate to the Project Seed, Working Constitution, accepted semantics/architecture, and Master Architect Guide  
**Purpose:** Govern consequential transitions from accepted specification/design into delegated implementation without turning every coding task into a red-team program.

**Load when:** a subsystem/slice is about to cross a high-inertia specification→implementation boundary, when interacting semantics are complex enough that implementation discretion could create project meaning, or when a separately owned acceptance/completion authority is warranted.  
**Do not load merely because:** a routine/local implementation task already has bounded accepted contracts and low-cost reversibility.  
**Primary inputs:** accepted specification/ADRs, current verification design, unresolved/deferred registers, implementation task packet, relevant engineering guardrails.  
**Expected output:** a release/no-release judgment, exact implementation applicability where warranted, and explicit residual/deferred risks.  
**Stop/escalate when:** closure requires choosing new consequential semantics/architecture, accepted sources conflict materially, or evidence is insufficient for a consequential irreversible decision.

---

## 1. Principle: assurance scales with consequence

This protocol exists for implementation boundaries where mistakes would create expensive semantic or architectural inertia.

Do not reproduce TRES-0010 ceremony by default.

Use the smallest assurance depth that can make the handoff trustworthy:

- routine/local tasks may need only the implementation template and ordinary tests;
- consequential slices may need the structured closure checks below;
- unusually interactive/high-risk boundaries may justify independent review, bounded adversarial work, exhaustive enumeration, or a small formal/reference model.

The objective is not maximum process. It is to prevent lower-level implementation from silently deciding higher-level meaning.

## 2. First triage: classify the problem correctly

When a gap or risk is found, classify it before choosing a remedy.

### Missing semantic / architectural authority

The accepted project does not uniquely determine behavior/meaning/identity/ownership.

Response:

- stop implementation on that point;
- perform the needed design/research;
- obtain the required authority;
- promote it losslessly.

### Missing enforcement / verification

Accepted meaning exists, but the handoff allows omission, self-selection, grader gaming, circular oracles, or unverifiable completion.

Response:

- repair acceptance/applicability/verification authority;
- do not invent new social semantics.

### Implementation-local engineering risk

Accepted behavior and completion authority are sufficient, but a language/runtime/testing hazard could violate them.

Response:

- add a local guard, analyzer, test, checklist, or implementation constraint;
- do not convert it into architecture unless consequence/scale warrants.

This distinction is mandatory because solving every problem with architecture creates bloat and premature lock-in.

## 3. Semantic closure checklist

For consequential implementation scope, inspect only the semantic surfaces that can affect that scope.

### Stateful semantic object lifecycle

For each authoritative stateful object whose identity/history matters, answer where relevant:

- creation/founding;
- identity/equivalence;
- state transitions;
- duplication/cardinality;
- consumption/satisfaction/retirement/dissolution;
- historical references that survive state change.

Do not require lifecycle machinery for immutable/value objects that do not need it.

### Parameter validity

For every semantically consequential action/proposal parameter, define or confirm:

- type/domain;
- meaningful bounds/cardinality;
- zero/negative/out-of-range behavior;
- over-fulfilment/overpayment behavior where relevant;
- malformed/no-op classification;
- whether invalid terms can trigger responses, history, or social consequences.

Verification examples cannot create a missing parameter domain.

### Composition and conflict

Look for multiple valid effects touching:

- the same bounded scalar;
- a single-valued relation;
- scarce capacity/resource;
- the same authority/precondition;
- non-commutative same-cycle state;
- automatic reactions.

For each hotspot, accepted semantics must either:

- commute/converge;
- define a conflict set/priority;
- define semantic ordering;
- or forbid the combination.

Runtime/container order must not accidentally become social meaning.

### Nested action / transaction completion

For actions that request/cause other actions, close:

- initiative ownership;
- whether nested response is allowed;
- recursion/third-party choice limits;
- atomicity boundaries;
- when the outer action counts as fulfilled;
- how inner failure propagates;
- which side effects/history occur on each outcome.

### Authority/precondition races

If an accepted action depends on authority/role/precondition that another same-cycle transition can destroy/change, define or explicitly defer the interaction before both become executable.

When a slice later makes a **broad/global ordering or fallback claim**, do not infer that claim from a few representative conflict examples. Perform a bounded interaction-surface audit over the executable action shapes whose commits can alter one another's action-relevant preconditions/capacity. Structural reasoning may eliminate impossible/commuting pairs; test only the material remainder.

### Undefined conditions

Missing detail remains a visible gap. It is not implementation discretion.

Record unresolved items with a trigger when they can safely be deferred.

## 4. Preserve future seams without implementing future slices

Audit only future seams that are already accepted or expensive to retrofit.

Examples:

- objective vs subjective information boundaries;
- semantic identity/reference boundaries;
- addressable semantic history/provenance;
- deterministic ordering/configuration state;
- checkpoint/rebuild compatibility;
- authority/context separation.

For actor decision contexts that cross the objective/subjective seam, classify each behavior-affecting input by provenance: own state, automatically known direct-party fact, explicitly observed/communicated/supplied subjective fact, or objective-only world fact reserved for feasibility/resolution. Decision traces should expose the actual subjective inputs used. Do not implement later observation/communication systems merely to satisfy this audit.

Do not build later subsystems, generic frameworks, or speculative abstractions merely to “future-proof.”

A fixed earlier-slice population/input may be preferable to inventing unresolved later transitions.

## 5. Exact slice applicability

When omission/self-selection is a material risk, create an exact applicability surface for the implementation slice.

Use explicit statuses such as:

- REQUIRED;
- DEFERRED;
- N-A;
- UNEXERCISED.

Requirements:

- every completion-relevant assertion/subcase has a stable identity or omission-detectable membership;
- grouped rows are allowed only when all members share the same status/scope and the expected member set is frozen;
- “relevant,” “applicable,” broad ranges, or “where substrate exists” must not be completion-authoritative when they let the implementer self-select;
- deliberate deferrals remain visible and carry a reason/trigger.

The applicability artifact is verification/completion authority, subordinate to accepted semantic/architectural authority.

## 6. Independent-enough verification authority

For consequential implementation, the coding task should not be the sole author/editor of the standard that decides whether it passes.

Possible lightweight mechanisms include:

- frozen acceptance/applicability manifest;
- separately authored acceptance cases/oracles;
- independent pre-code acceptance review;
- protected evaluator/checker boundary;
- independent post-implementation conformance review.

Choose the smallest mechanism appropriate to consequence.

Do not default to secret tests, organizational IV&V, or a generalized grader service.

## 7. Verification cannot create semantics

Verification design may instantiate, observe, or challenge accepted meaning.

It may not resolve ambiguity by silently promoting:

- an example value into a permanent domain rule;
- a fixture shape into a semantic schema;
- a test helper into a domain action;
- an expected failure into a new social outcome;
- an implementation constraint into architecture.

If accepted sources do not uniquely support the expected result, return to semantic authority or use schema-neutral verification if the meaning can be tested without choosing representation.

## 8. Schema-neutral verification

When semantics constrain behavior but not API/data representation:

- verify semantic ingress/effect properties;
- permit structural evidence where a typed public boundary makes invalid representation impossible;
- do not require one raw field/signature unless the semantics actually require it;
- still make omission-detectable which semantic ingresses/effects are covered.

Representation freedom is an implementation/architecture benefit, not permission to weaken semantic evidence.

## 9. Oracle independence

An independent oracle/check must not simply call the production helper whose output is under judgment.

It may share:

- stable schemas/IDs;
- accepted constants/configuration;
- recorded semantic history/events;
- simple independently implemented arithmetic;
- frozen expected-case tables.

Be especially careful with:

- candidate recognizers/generators;
- scorers/selectors;
- validity classifiers;
- capacity calculators;
- transition helpers;
- derived-state classifiers.

Where full independence is disproportionate, document the dependency and use a different evidence form such as a metamorphic relation, structural audit, or reference recomputation.

## 10. Acceptance authority review

If an acceptance/applicability artifact itself becomes powerful enough to govern consequential implementation completion, review it before freeze.

Check for:

- missing applicability;
- over-broad wording that invents semantics;
- grouped rows hiding omission;
- contradictory status/scope;
- circular oracle rules;
- accidental later-slice requirements;
- representation overconstraint;
- broad wording such as "all", "every", "global", "complete", or "only" that is supported only by sampled examples rather than bounded-domain enumeration, structural closure, or another evidence form whose scope actually spans the claim.

A reviewer should re-derive from accepted sources rather than merely checking that a previous defect list was patched.

## 11. Optional formalization / exhaustive probe

Use a small reference model, state enumeration, model checker, or combinatorial probe when interaction risk is high and prose review is not discriminating enough.

Good triggers include:

- same-cycle non-commutative updates;
- multiple writes to single-valued state;
- nested proposals/responses;
- authority/precondition races;
- exact checkpoint/replay requirements;
- small but subtle state machines.

This is an escalation tool, not a project-wide formal-methods requirement.

## 12. Freeze mechanics

When freezing a consequential acceptance/governance artifact:

- identify the reviewed candidate version/SHA;
- ensure post-review edits are administrative only or re-review them;
- pin an immutable ref/commit where useful;
- do not make a file contain its own final content hash;
- if the artifact records the reviewed-candidate SHA internally, record the final frozen SHA/commit externally in a freeze record or immutable ref;
- require a new version/ref for later semantic/applicability changes.

For detailed mechanical use, follow `checklists/ARTIFACT_FREEZE_CHECKLIST.md`.

## 13. Implementation packet readiness

Before release, a consequential implementation packet should state:

- accepted semantic/architectural authority;
- verification/completion authority;
- required non-authoritative supporting/engineering context;
- explicit precedence among those classes;
- scope/out-of-scope;
- required invariants;
- exact completion applicability where warranted;
- local implementation discretion;
- escalation triggers;
- required completion evidence;
- residual/deferred gaps that implementation must not invent.

Implementation discovery remains evidence, not permission to redesign higher-level decisions.

## 14. Release / no-release gate

Release implementation only when all material preconditions for the chosen assurance depth are satisfied.

A **release** means:

- implementation may begin inside accepted contracts;
- no known unresolved issue forces the implementer to invent project meaning;
- required verification/completion authority is sufficiently independent and explicit;
- remaining uncertainty is either irrelevant to the slice or durably deferred with a trigger.

A **no-release** means the blocking gap is identified by class and owner; do not respond with a vague “needs more review.”

A release is not a claim that implementation is already correct.

## 15. Post-implementation conformance

For consequential work, completion should verify not only green tests but conformance to the acceptance authority:

- required rows actually have substantive evidence;
- expected results still trace to accepted semantics;
- forbidden oracle dependencies were not used;
- fixtures did not write results they claim to test;
- deferred semantics were not faked;
- acceptance authority was not weakened after dispatch;
- deterministic/recovery evidence is present where required.

Independent post-implementation review is warranted when the acceptance authority explicitly requires it.

A fresh conformance reviewer may use small reviewer-owned scratch probes against the unchanged public implementation boundary to seek counterexamples to broad claims, hidden input dependencies, or interaction assumptions. Such probes are adversarial evidence, not candidate modifications and not substitutes for required canonical evidence; disclose their setup and results.

## 16. Completion output

Leave a recoverable record of:

- release/no-release conclusion;
- accepted/frozen applicability identity where used;
- residual deferred items and triggers;
- evidence that the implementation packet matches the accepted authority;
- any local guardrails added;
- what must be re-opened if implementation discovers a genuine conflict.

Do not leave future agents to reconstruct assurance state from review chats or branch archaeology.

## 17. Related owners

- delegation/research/adversarial execution: `AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`
- authority/promotion/navigation: `AUTHORITY_AND_DECISION_PROMOTION.md`
- architecture choice: `ARCHITECTURE_DEVELOPMENT_POLICY.md`
- implementation architecture conflict: `ARCHITECTURE_ESCALATION_RULES.md`
- implementation packet construction: `../tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md`
- drift review: `REVIEW_AND_DRIFT_AUDIT.md`
