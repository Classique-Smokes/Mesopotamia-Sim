# Implementation Plan — Semantic Interaction Delta Failsafe

**Status:** CANONICAL PROMOTION COMPLETE / SLICE-4 PILOT NEXT  
**Date:** 2026-09-24  
**Owner:** Master Architect  
**Policy proposal:** `plans/GOVERNANCE_SEMANTIC_INTERACTION_DELTA_FAILSAFE_PLAN.md`  
**Prior policy-only candidate ref:** `governance-semantic-interaction-delta-failsafe-v1-candidate1` @ `8c101d82efd781bca48b1222e4e9b7a4b274f6f0` — valid historical provenance  
**Current rollout candidate:** superseded candidate1; candidate2 identity pinned after hostile pre-review repair  
**Current project block:** Slice-4 implementation remains Director-BLOCKED  
**Implementation authority:** accepted under DEC-0012. Canonical policy edits promoted; Slice-4 pilot remains required before successor Slice-4 acceptance.

## 1. Objective

Turn the proposed Semantic Interaction Delta Failsafe into a small, durable extension of the existing specification-to-implementation assurance path.

The implemented policy must cause consequential new semantic layers to receive a bounded review of the **new↔old interaction frontier** before acceptance freeze, covering where relevant:

- newly possible histories;
- old capabilities that become suppressed/narrowed/newly conditional;
- new dependency/coupling/causal retargeting;
- transition carryover/path closure;
- participant aliasing;
- fresh negative-space challenge.

The mechanism must remain delta-based and trigger-based so governance cost does not scale with total project history.

## 2. Non-goals

This rollout must not create:

- a new constitutional layer;
- a new standing governance protocol;
- a permanent global interaction register;
- an exhaustive action-pair matrix;
- an obligation to preserve every old capability unchanged;
- automated semantic classification;
- a recurring multi-agent review swarm;
- a new requirement that every routine mechanic run the audit.

The mechanism should add one habit to the existing assurance protocol, one compact checklist, one conditional freeze check, and one implementation stop rule.

## 3. Authority / approval sequence

Because this changes accepted project governance, implementation proceeds in this order:

1. freeze the proposal/rollout candidate for review;
2. run one fresh independent governance review;
3. Master Architect reconciles any findings;
4. if the reviewed policy remains sound, present the exact promoted-policy meaning to the Project Director;
5. obtain explicit Director approval;
6. apply the canonical governance edits;
7. mechanically verify the promoted edits preserve the approved policy;
8. pilot the accepted mechanism on blocked Slice 4;
9. only after pilot semantic-delta closure may the DEC-0011 successor Slice-4 acceptance candidate be cut.

Silence or a passing pilot does not create governance authority. Director approval is the promotion gate.

## 4. Phase G1 — freeze and independently review the governance candidate

### Exact review bundle

The reviewer must inspect:

- `plans/GOVERNANCE_SEMANTIC_INTERACTION_DELTA_FAILSAFE_PLAN.md`;
- this implementation plan;
- current `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`;
- current `governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md`;
- current `tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md`;
- `governance/MASTER_ARCHITECT_GUIDE.md`;
- the advisory failure-analysis provenance:
  `research/technical/PROCESS_LESSON_COMPOSITIONAL_AFFORDANCE_AND_PARTICIPANT_ALIASING.md`.

### Required governance-review questions

The reviewer must challenge:

1. **Failure-class fit** — does the policy protect the broad new-layer↔old-world interaction problem rather than merely the Slice-4 self-funding incident?
2. **Non-duplication** — does it add a distinct semantic-expressibility check rather than repackage composition/conflict, conformance, or ordinary acceptance review?
3. **Trigger precision** — can routine/local work cheaply return NOT FIRED?
4. **Frontier bounding** — is the affected old-world surface discoverable without whole-project Cartesian enumeration?
5. **Capability preservation semantics** — does old-world projection expose silent losses without imposing an invalid universal conservative-extension law?
6. **Transition coverage** — does path/carryover auditing catch holes that endpoint checks miss?
7. **Aliasing as subtype** — is same-PersonId aliasing retained as a strong probe without defining the whole policy?
8. **Fresh-review independence** — can the same negative-space reviewer independently challenge the MA frontier in a frozen Pass A before seeing it, then use the reconciled union in Pass B?
9. **Closure freshness** — does any later material semantic change force explicit closure revalidation before freeze?
10. **Deferral integrity** — can DEFERRED/DERIVED labels clear the gate only with authority-bearing justification rather than classification convenience?
11. **Pilot evidence discipline** — does the rollout distinguish known-case processing from previously unknown prospective findings?
12. **Authority discipline** — do reviewer questions remain advisory, with consequential new meaning still routed to Director authority?
13. **Scalability** — do delta-based reopening/revalidation rules keep cost bounded as the project grows?
14. **Failure containment** — does implementation stop rather than self-classify a newly discovered unclosed interaction?
15. **Sunset/evaluation** — can the mechanism be narrowed or retired if it becomes bureaucracy rather than protection?

### Verdicts

Use exactly:

- **PASS — POLICY READY FOR DIRECTOR PROMOTION**
- **BLOCK — POLICY SCOPE / CEREMONY DEFECT**
- **BLOCK — GOVERNANCE AUTHORITY / STRUCTURE DEFECT**

If BLOCK, identify the smallest repair. The reviewer does not edit the policy.

## 5. Phase G2 — Director promotion decision

After PASS, the Master Architect returns to the Project Director with a compact promotion summary containing:

- protected failure class;
- trigger rule;
- five semantic-delta lenses;
- negative-space challenge role;
- acceptance-freeze condition;
- implementation stop rule;
- scaling/reopen rule;
- pilot plan;
- 2–3-slice effectiveness review / possible retirement.

The Director approves/rejects the policy meaning, not line-by-line Markdown.

If the Director materially changes policy meaning, revise the policy candidate and rerun only the affected governance review.

## 6. Phase G3 — canonical protocol promotion

After explicit Director approval, modify exactly these owners.

### 6.1 `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Primary normative owner.

#### Add under §3 Semantic closure checklist

Add a subsection **Semantic interaction delta** with:

1. conditional trigger:
   `Semantic-interaction-delta trigger: FIRED / NOT FIRED — reason`;
2. interaction-frontier discovery;
3. five bounded lenses:
   - newly possible / compositional affordance;
   - suppressed/narrowed/new dependency old capability;
   - dependency/coupling/causal retargeting;
   - transition carryover/path closure;
   - participant aliasing when relevant;
4. old-world projection as a diagnostic where meaningful;
5. disposition vocabulary and authority rule;
6. one two-pass fresh negative-space challenge when the trigger fires for consequential scope:
   - Pass A independently discovers candidate frontier surfaces before seeing the MA frontier;
   - Pass A is durably fixed;
   - Pass B reveals/compares the MA frontier, reconciles the union, then challenges the possibility-space delta.

Keep the protocol-level wording compact. Route detailed prompts/table format to the checklist.

#### Add under §10 Acceptance authority review

When trigger FIRED, verify before freeze:

- frontier/delta closure exists;
- independent frontier Pass A exists and predates MA-frontier reveal;
- Pass-B challenge exists over the reconciled frontier union;
- every finding is dispositioned with authority-bearing closure rationale;
- every DEFERRED item is itself authorized, has owner/trigger, and leaves the current slice semantically complete;
- DERIVED CONSEQUENCE items cite controlling authority;
- closure is current against the exact semantic base used by the acceptance candidate;
- consequential UNRESOLVED = 0;
- accidental gaps outstanding = 0;
- newly accepted meanings are present in semantic/acceptance authority;
- verification did not invent closure.

#### Add under §13 Implementation packet readiness

Require the implementation packet to cite the accepted semantic-delta closure when trigger FIRED.

#### Add under §14 Release / no-release gate

A consequential unresolved interaction delta is a no-release condition.

#### Add under §15 Post-implementation conformance

If implementation exposes a material interaction absent from the closure, classify it as an escalation / governance miss; do not normalize it as local implementation behavior.

Do not duplicate the full checklist in the protocol.

### 6.2 Add `governance/checklists/SEMANTIC_INTERACTION_DELTA_CHECKLIST.md`

This is the operational prompt surface, not independent authority.

The checklist should contain:

- trigger decision prompts;
- interaction-frontier discovery prompts;
- compact delta table schema;
- delta-type vocabulary:
  - NEW_AFFORDANCE
  - SUPPRESSED_OR_NARROWED
  - NEW_DEPENDENCY
  - CAUSAL_RETARGETING
  - NEW_CONFLICT_OR_SHARED_CAPACITY
  - TRANSITION_CARRYOVER
  - PARTICIPANT_ALIAS
  - NO_MATERIAL_DELTA
- disposition vocabulary:
  - PRESERVED / SUPPORTED
  - INTENDED CHANGE / PROHIBITED
  - DERIVED CONSEQUENCE
  - IRRELEVANT / COMMUTING
  - DEFERRED
  - UNRESOLVED
  - ACCIDENTAL GAP / REGRESSION
- old-world projection prompt;
- transition carryover categories;
- alias-effect prompts;
- fresh negative-space challenge dispatch template;
- closure markers.

It must explicitly state:

- the checklist cannot create project semantics;
- no full Cartesian product is required;
- DERIVED CONSEQUENCE requires a traceable authority derivation;
- absence from the action catalogue is not prohibition;
- a neutral old-world projection is a diagnostic where meaningful, not a universal requirement that all new layers be conservative extensions.

### 6.3 Modify `governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md`

Add one conditional step before freezing a consequential acceptance artifact:

> If the owning preimplementation reconciliation records `Semantic-interaction-delta trigger: FIRED`, verify a completed delta closure, completed fresh negative-space challenge, `Consequential unresolved: 0`, and `Accidental gaps outstanding: 0`. Confirm any resulting semantic repairs were promoted before the acceptance candidate under review.

Do not make this requirement apply to unrelated artifact freezes.

### 6.4 Modify `tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md`

Add two small conditional clauses.

#### Required inputs

If a semantic-interaction-delta closure was required for the slice, list its accepted path/ref among supporting implementation inputs.

#### Escalation

Add:

> If implementation exposes a consequential new↔old semantic interaction, suppression/narrowing, transition carryover case, causal dependency/retargeting, shared-capacity interaction, or participant alias not classified by the accepted semantic-delta closure, STOP. Do not infer that absence means prohibition, support, or implementation discretion.

The implementation agent does not repeat the entire audit.

### 6.5 Navigation

Update only the smallest navigation surface that already points to the assurance protocol/checklists if needed.

Do not add policy text to:

- Working Constitution;
- Master Architect Guide;
- delegation protocol;
- Review and Drift Audit;

unless later experience proves routing is insufficient.

## 7. Phase G4 — promotion verification

After the four canonical edits:

1. compare every normative addition to the Director-approved policy;
2. verify two-pass frontier independence is preserved operationally, not merely mentioned;
3. verify closure staleness/revalidation markers are present;
4. verify DEFERRED cannot clear the gate without authorized deferral semantics;
5. verify pilot/effectiveness reporting separates known cases from previously unknown findings;
6. confirm no unrelated existing assurance rule was weakened/deleted;
7. confirm the protocol remains consequence-scaled rather than mandatory for routine work;
8. confirm the checklist is clearly subordinate/non-authoritative;
9. confirm the implementation template adds only a conditional stop rule;
10. confirm no new global register/protocol was accidentally created;
11. confirm root retrieval remains valid.

If the canonical wording materially changes approved policy meaning, stop and re-review rather than calling it clerical promotion.

## 8. Phase P1 — Slice-4 pilot setup

The first field use is mandatory before cutting the DEC-0011 successor acceptance candidate.

Create a Slice-4 delta-closure artifact, recommended path:

`research/technical/SFL_V0_SLICE4_SEMANTIC_INTERACTION_DELTA_CLOSURE.md`

It begins with:

- trigger: **FIRED**;
- policy/version governing the audit;
- exact blocked baseline;
- exact current accepted Slice-4 semantic base including DEC-0011;
- interaction frontier.

### Minimum Slice-4 interaction frontier

Audit at least:

- personal agency ↔ HouseholdDecisionContext;
- head authority ↔ private ownership;
- head ↔ standing provision contributor;
- Household material action ↔ personal material action/shared grain;
- head/bride/groom mediated-marriage positions;
- nominator/nominee/head/current participant;
- support recipient/head/contributor;
- succession/vacancy ↔ commitments/private transaction terms;
- Active/Inactive/Dissolved transitions ↔ pending Household actions;
- objective head occupancy ↔ subjective Recognition;
- participation end ↔ head role/provision/continuity;
- persistent commitment capacity ↔ exact transaction-specific X under DEC-0011.

The Master Architect owns this frontier/reconciliation synthesis.

## 9. Phase P2 — Slice-4 structured delta audit

Use the checklist against the frontier.

### A. Newly possible

Seek ordinary histories newly enabled by office/Household/private-supplement semantics.

### B. Suppression/narrowing

Check old person-level actions, commitments, participation, marriage, residence, knowledge, and support paths for accidental new gates.

### C. Dependency/retargeting

Check whether any old personal capability silently moved under Household/head authority or whether objective state leaks into subjective action gates.

### D. Transition carryover

At minimum inspect:

- head appointment;
- succession;
- participation-end vacancy;
- Active -> Inactive;
- Inactive -> Active;
- Dissolution.

Classify what happens to:

- provision commitments;
- transaction-specific X;
- pending Household actions;
- personal action;
- head Recognition;
- role identity;
- personal property;
- lower-level relations/claims.

### E. Aliasing

At minimum classify:

- head = private contributor;
- head = standing provision contributor;
- head = bride;
- head = groom;
- head = support recipient;
- nominator = nominee;
- outgoing head = continuing contributor after succession.

Add other material aliases discovered from the frontier.

## 10. Phase P3 — fresh Slice-4 two-pass frontier / negative-space challenge

Commission **one** INDEPENDENT-CONTEXT reviewer.

Recommended task:

`tasks/research/SFL_V0_SLICE4_SEMANTIC_DELTA_NEGATIVE_SPACE_CHALLENGE.md`

The same reviewer performs two sequential passes.

### Pass A — independent frontier discovery

Before seeing the Master Architect's frontier/delta table, supply only:

- high-level accepted Slice-4 objects/powers/transitions;
- a compact canonical map of adjacent existing semantics / retrieval entrypoints;
- genuine invariants/exclusions;
- instruction to identify prior surfaces that might interact with, be suppressed by, be crossed by, or be causally retargeted by the new layer.

Do **not** supply yet:

- MA frontier list;
- MA delta classifications;
- Slice-4 acceptance row catalogue;
- self-funding defect taxonomy as a suggested answer;
- prior negative-space findings.

Required Pass-A output:

- compact candidate frontier;
- reason each surface might interact;
- no semantic recommendations.

**Freeze Pass A before reveal** on the review branch with an exact commit/blob or equivalent immutable identity.

### Pass B — frontier comparison + ordinary histories

After Pass A is fixed:

1. reveal the MA frontier/delta table;
2. compare MA-only / reviewer-only / overlapping surfaces;
3. challenge the justified union;
4. normally return 3–7 concrete histories/questions across:
   - newly possible;
   - lost/narrowed;
   - transition hole;
   - alias;
   - causal retargeting.

The reviewer still creates no semantics.

The final return must preserve both Pass A and Pass B provenance.

## 11. Phase P4 — Master Architect pilot reconciliation

Reconcile every reviewer challenge into the Slice-4 delta closure.

First reconcile the **frontier**:

- every reviewer-only surface receives an inclusion/exclusion judgment with reason;
- final closure frontier is the justified MA/reviewer union after exclusions.

Every challenge item then receives:

- source narrative;
- delta type;
- canonical authority consulted;
- classification/disposition;
- authority-bearing closure rationale;
- whether semantic change is required;
- acceptance implication;
- for DEFERRED: approving authority, owner/trigger, proof current Slice 4 remains semantically complete, and proof implementation cannot choose the deferred meaning.

Pilot gate:

- `Closure freshness: CURRENT`;
- `Consequential unresolved: 0`;
- `Accidental gaps outstanding: 0`.

If any material semantic change lands after closure but before successor acceptance freeze, explicitly re-evaluate trigger/frontier and record either:

- `REVALIDATED — NO FRONTIER CHANGE`; or
- `REOPENED — AFFECTED FRONTIER`.

Do not rely on a stale closure.

If another real gap is found:

1. keep Director BLOCK active;
2. promote/decide the gap normally;
3. rerun only the affected delta frontier;
4. do not cut successor acceptance until closure is clean.

If no new gap is found, record the negative result; do not manufacture findings to justify the policy.

## 12. Phase P5 — successor Slice-4 acceptance

Only after pilot closure:

1. derive successor Slice-4 acceptance candidate from frozen v1 + DEC-0011 + all pilot semantic repairs;
2. create a new version/ref; frozen v1 remains immutable;
3. acceptance reviewer must verify:
   - exact inherited prior requirements;
   - DEC-0011 omission-detectable coverage;
   - semantic-delta trigger/closure evidence exists;
   - independent Pass-A frontier discovery was frozen before MA-frontier reveal;
   - closure semantic base matches the candidate's accepted semantic base or has explicit no-frontier-change revalidation;
   - all DEFERRED/DERIVED closures are authority-bearing;
   - no unresolved/gap markers remain;
   - acceptance did not invent semantic dispositions.
4. freeze successor only on fresh whole-candidate PASS;
5. reassess the inherited-verification adaptation plan against the successor boundary;
6. only then consider closing the Director implementation BLOCK.

## 13. Phase E — effectiveness / sunset review

After the policy has FIRED on **2–3 consequential slices** (including Slice 4), run one small governance-effectiveness review.

Record findings separately as:

- **KNOWN CASE PROCESSED**;
- **PREVIOUSLY UNKNOWN MATERIAL FINDING**;
- **DUPLICATE FINDING**;
- **NOISE / FALSE POSITIVE**.

Also record:

- whether independent Pass-A frontier discovery found surfaces the MA omitted;
- meaningful intended changes made visible;
- MA effort;
- reviewer effort;
- ambiguity in trigger/frontier selection;
- closure revalidations caused by late semantic changes;
- whether authorized-deferral discipline prevented classification gaming;
- evidence of premature semantic expansion;
- implementation escalations caught by the stop rule.

Do not count the founding Slice-4 self-funding incident as prospective efficacy evidence.

Decision:

- RETAIN;
- NARROW;
- SIMPLIFY;
- ADD LIGHTWEIGHT LINT;
- RETIRE.

Do not add automated semantic classification.

A future linter, if justified, may check only required closure markers.

## 14. Repository identities / versioning

If promoted, assign the policy a compact governance version label, recommended:

`SID-ASSURANCE-v1`

Record the adopted version in the assurance protocol/checklist header and in triggered closure artifacts.

Do not create a moving “latest policy” ref unless downstream automation actually needs one.

The accepted protocol files themselves remain canonical through ordinary repository authority; immutable refs are useful for the pilot/freeze evidence, not necessary for every future use.

## 15. Rollout completion definition

The governance policy implementation is complete when:

1. independent governance review PASSes the exact proposal/rollout candidate;
2. Director explicitly approves the policy;
3. protocol/checklist/freeze/template edits are promoted and mechanically verified;
4. Slice-4 pilot trigger/frontier/audit is complete;
5. fresh reviewer Pass A independently challenged the frontier and was durably frozen before reveal;
6. Pass B negative-space challenge is reconciled over the justified union;
7. closure is current against the successor-acceptance semantic base;
8. pilot has zero consequential unresolved / accidental gaps and no unjustified deferrals;
9. successor Slice-4 acceptance may safely begin under the new policy.

The policy is **not** considered validated merely because the Markdown edits are merged. The Slice-4 pilot is part of implementation.

## 16. Current stop point

At present:

- policy concept: ACCEPTED under DEC-0012;
- independent governance review: PASS — POLICY READY FOR DIRECTOR PROMOTION;
- canonical governance promotion: COMPLETE;
- Slice-4 implementation: BLOCKED;
- successor Slice-4 acceptance: MUST NOT START until the mandatory Slice-4 pilot closes cleanly under SID-ASSURANCE-v1.

Immediate next action:

run the Slice-4 Semantic Interaction Delta pilot, including independent frozen Pass A, Pass B negative-space challenge, Master Architect reconciliation, and closure-freshness verification.
