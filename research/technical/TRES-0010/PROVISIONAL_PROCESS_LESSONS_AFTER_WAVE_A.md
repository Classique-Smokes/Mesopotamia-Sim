# TRES-0010 — Provisional Process Lessons After Wave A

**Status:** WORKING / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Do not promote before Wave B reconciliation.**

## 1. What Wave A appears to teach

Wave A did not expose a collapse of the founding architecture. It did expose several places where local semantic completeness was mistaken for compositional completeness.

The strongest provisional lessons are below.

### PL-01 — Semantic nouns need lifecycle closure

Any stateful semantic object used in accepted mechanics should eventually answer:

- how is it created?
- what gives it identity/equivalence?
- how can it change?
- what consumes/retires it?
- can duplicates exist?
- what historical references survive?

The CandidateOrganization finding is the clearest example.

### PL-02 — Every action parameter needs an explicit validity domain

Examples, prose defaults, and nonnegative-balance invariants are not enough.

For each action parameter that can alter semantics, define:

- type/domain;
- lower/upper bounds where material;
- zero/negative behavior;
- over-fulfilment/overpayment behavior;
- whether malformed/no-op events may trigger social consequences.

The grain-amount finding is the clearest example.

### PL-03 — Local transition rules do not guarantee composition closure

For any cycle where multiple individually valid effects can touch:

- the same bounded scalar;
- the same single-valued relation;
- an authority precondition;
- the same scarce capacity;
- nested proposal/response chains;

the specification must either:

- prove operations commute/converge;
- define a semantic conflict set/priority;
- define canonical ordering;
- or forbid the combination.

Cause-key idempotence alone is not confluence.

### PL-04 — Nested action semantics require an explicit completion unit

Any mechanic that requests/causes another action must say:

- whether the nested action consumes initiative;
- whether it may itself require counterpart response;
- whether response recursion is permitted;
- when the outer obligation is considered fulfilled;
- what failure outcome the outer relation receives.

Called-favour fulfilment exposed this class.

### PL-05 — Stage closure needs a systematic reachability/composition audit

Scenario-family coverage is not the same as semantic closure.

Before a consequential implementation boundary, consider requiring a structured audit of:

- state/object lifecycle reachability;
- parameter validity domains;
- pairwise/multi-effect composition;
- single-valued write conflicts;
- authority-destroying transitions;
- nested action graphs;
- automatic reaction confluence/order.

### PL-06 — Verification authority must be independent from implementation authority

A coding agent should not be the sole author/editor of the executable judge that decides whether its own implementation satisfies accepted semantics.

Possible durable mechanisms to evaluate after Wave B:

- frozen machine-readable acceptance manifest;
- evaluator-controlled tests/held-outs;
- protected oracle/checker project with dependency constraints;
- independent post-implementation verification task;
- explicit coverage/applicability matrix.

The exact mechanism should be consequence-scaled, not framework-heavy by default.

### PL-07 — Implementation packets need a closed applicability manifest

Phrases like "relevant", "applicable", or broad scenario ranges create discretion exactly where the acceptance boundary should be precise.

For consequential slices, a task packet may need an explicit table:

- scenario/subcase;
- required now / deferred;
- reason;
- required profiles;
- cross-cutting checks;
- mutants/metamorphic relations;
- evidence required.

### PL-08 — Preserve future seams without implementing future slices

Before first implementation of a foundational substrate, explicitly audit whether local choices preserve:

- objective vs subjective access boundaries;
- semantic decision-context identity;
- non-pairwise transaction capacity;
- first-class addressable semantic history;
- deterministic ID/order/configuration state;
- derived-state rebuilding and checkpoint compatibility.

This should prevent future rewrites without expanding current scope.

### PL-09 — Authority taxonomy in task packets must be explicit

Separate:

- accepted authority;
- required non-authoritative supporting context;
- verification requirements;
- working engineering notes.

Do not let "required input" imply equal authority.

### PL-10 — Adversarial review should occur at integration boundaries, not only rule-by-rule

Local Pass reviews were valuable, but Wave A found interactions crossing those pass boundaries.

For high-consequence foundational subsystems, one broad pre-code integration red team appears to be high leverage after local semantic/verification closure and before implementation.

## 2. Expected complexity gaps versus process misses

### Likely expected in a complex v0

These are common consequences of composing many valid local rules:

- simultaneous-update ordering;
- multiple writes to one single-valued relation;
- nested actions / response recursion;
- authority transitions racing authority-dependent actions;
- lifecycle provenance edge cases;
- late discovery of future-slice representation seams.

Finding these during pre-code adversarial review is evidence the gate works, not automatically evidence earlier work was poor.

### More clearly process-improvable

These suggest durable process improvements:

- declaring Stage 3 closed without a full semantic-reachability/object-lifecycle inventory;
- no explicit composition/confluence conflict matrix before implementation;
- allowing the implementation task to author most of its own executable acceptance authority;
- using open words such as "applicable/relevant" in a consequential implementation packet;
- authority/supporting-context taxonomy blur in IMP-0001;
- a scenario-range requirement that contradicted Slice-1 scope.

These are not catastrophic, but they are good candidates for governance/template improvements after Wave B confirms the diagnosis.

## 3. Promotion gate

Do not amend Master Architect governance/templates from this note alone.

After Wave B:

1. identify which lessons survive prosecution/defense;
2. separate one-off SFL details from general process rules;
3. promote only durable, repeated, high-leverage rules;
4. prefer checklists/templates/mechanical verification over adding prose to the Master Architect guide where possible.
