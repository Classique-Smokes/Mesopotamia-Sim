# Implementation Plan — Semantic Interaction Delta Failsafe

**Status:** READY FOR GOVERNANCE REVIEW / NOT YET ACCEPTED POLICY  
**Date:** 2026-09-24  
**Owner:** Master Architect  
**Policy proposal:** `plans/GOVERNANCE_SEMANTIC_INTERACTION_DELTA_FAILSAFE_PLAN.md`  
**Policy candidate ref:** `governance-semantic-interaction-delta-failsafe-v1-candidate1`  
**Policy candidate commit:** `8c101d82efd781bca48b1222e4e9b7a4b274f6f0`  
**Policy candidate blob:** `634ca400c1827f02f24d7042754bc5beafe89e17`  
**Current project block:** Slice-4 implementation remains Director-BLOCKED  
**Implementation authority:** none until explicit Director approval after independent governance review

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
8. **Fresh-review independence** — can the negative-space reviewer discover omissions without being anchored by the action catalogue?
9. **Authority discipline** — do reviewer questions remain advisory, with consequential new meaning still routed to Director authority?
10. **Scalability** — do delta-based reopening rules keep cost bounded as the project grows?
11. **Failure containment** — does implementation stop rather than self-classify a newly discovered unclosed interaction?
12. **Sunset/evaluation** — can the mechanism be narrowed or retired if it becomes bureaucracy rather than protection?

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
6. one fresh negative-space challenge when the trigger fires for consequential scope.

Keep the protocol-level wording compact. Route detailed prompts/table format to the checklist.

#### Add under §10 Acceptance authority review

When trigger FIRED, verify before freeze:

- frontier/delta closure exists;
- fresh challenge exists;
- every finding is dispositioned;
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
2. confirm no unrelated existing assurance rule was weakened/deleted;
3. confirm the protocol remains consequence-scaled rather than mandatory for routine work;
4. confirm the checklist is clearly subordinate/non-authoritative;
5. confirm the implementation template adds only a conditional stop rule;
6. confirm no new global register/protocol was accidentally created;
7. confirm root retrieval remains valid.

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

## 10. Phase P3 — fresh Slice-4 negative-space challenge

Commission one INDEPENDENT-CONTEXT reviewer.

Recommended task:

`tasks/research/SFL_V0_SLICE4_SEMANTIC_DELTA_NEGATIVE_SPACE_CHALLENGE.md`

### Anti-anchoring bundle

Supply:

- high-level accepted Slice-4 objects/powers/transitions;
- relevant old-world capabilities at the frontier;
- genuine invariants/exclusions;
- the request for ordinary concrete histories.

Do **not** supply before initial return:

- Slice-4 acceptance row catalogue;
- the self-funding defect taxonomy as a suggested answer;
- the Master Architect's own delta table conclusions;
- prior negative-space challenge findings.

### Required output

Normally 3–7 concrete challenges, attempting coverage across:

- newly possible;
- lost/narrowed;
- transition hole;
- alias;
- causal retargeting.

No new semantics/recommendations.

Return on an isolated review branch and add only its report.

## 11. Phase P4 — Master Architect pilot reconciliation

Reconcile every reviewer challenge into the Slice-4 delta closure.

Every item receives:

- source narrative;
- delta type;
- canonical authority consulted;
- classification/disposition;
- whether semantic change is required;
- acceptance implication;
- deferred trigger if applicable.

Pilot gate:

- `Consequential unresolved: 0`;
- `Accidental gaps outstanding: 0`.

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
   - semantic-delta trigger/closure/challenge evidence exists;
   - no unresolved/gap markers remain;
   - acceptance did not invent semantic dispositions.
4. freeze successor only on fresh whole-candidate PASS;
5. reassess the inherited-verification adaptation plan against the successor boundary;
6. only then consider closing the Director implementation BLOCK.

## 13. Phase E — effectiveness / sunset review

After the policy has FIRED on **2–3 consequential slices** (including Slice 4), run one small governance-effectiveness review.

Record:

- genuine semantic gaps discovered;
- meaningful intended changes made visible;
- false positives/noise;
- items duplicated by existing assurance;
- MA effort;
- reviewer effort;
- ambiguity in trigger/frontier selection;
- evidence of premature semantic expansion;
- implementation escalations caught by the stop rule.

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
5. fresh negative-space challenge is reconciled;
6. pilot has zero consequential unresolved / accidental gaps;
7. successor Slice-4 acceptance may safely begin under the new policy.

The policy is **not** considered validated merely because the Markdown edits are merged. The Slice-4 pilot is part of implementation.

## 16. Current stop point

At present:

- policy concept: PROPOSED;
- rollout mapping: READY FOR REVIEW;
- accepted governance: UNCHANGED;
- Slice-4 implementation: BLOCKED;
- successor Slice-4 acceptance: MUST NOT START until the pilot runs under an accepted policy.

Immediate next action:

run the independent governance review task against the immutable rollout candidate.
