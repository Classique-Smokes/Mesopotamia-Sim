# Governance Plan — Semantic Interaction Delta Failsafe

**Status:** PROPOSED / DIRECTOR REVIEW  
**Date:** 2026-09-24  
**Owner:** Master Architect  
**Authority:** planning only; no accepted-governance change until explicitly approved/promoted  
**Motivating failure:** Slice-4 office-holder private-resource supplementation omission  
**Primary owner if accepted:** `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

## 1. Protected failure class

The protected failure class is broader than participant aliasing or omitted compositional affordance.

> **A new semantic layer changes the possibility space of the already-existing world in a way nobody explicitly considered.**

That change may make something:

- newly possible;
- newly impossible;
- narrower;
- dependent on a new condition;
- newly coupled to another system;
- causally rerouted through a different authority/resource/knowledge path;
- stranded across a new transition;
- sensitive to two semantic positions collapsing onto one actor.

The project already has strong assurance for conformance to **named accepted semantics**. That machinery cannot discover every plausible history that never entered the semantic vocabulary.

The failsafe therefore targets **semantic interaction delta before acceptance freeze**.

It does not claim to prove completeness of human behavior.

## 2. Why the prior framing was too narrow

The Slice-4 hole happened through:

`head = private owner = voluntary actor`

so participant aliasing was the immediate symptom.

But future failures may not contain any same-person alias.

Examples of the broader class include:

- geography makes an older obligation infeasible or changes what fulfilment means;
- ownership/control alters an older residence capability;
- a new epistemic gate suppresses an old action path;
- inheritance changes the survival/meaning of an old claim through a transition;
- a new institutional layer accidentally erases an older personal capability;
- a new transition creates an unhandled intermediate/carryover case even though both endpoints are valid.

Participant aliasing remains a mandatory probe when relevant, but it is one subtype of semantic interaction delta.

## 3. Design goals

The failsafe must:

1. detect meaningful new↔old semantic interactions before implementation hardens them;
2. check both **new affordances** and **lost/narrowed old affordances**;
3. inspect transition carryover, not only stable endpoint behavior;
4. explicitly test participant aliasing when multiple positions may coincide;
5. use fresh-context negative-space challenge without granting reviewers semantic authority;
6. scale by auditing the **semantic delta/frontier**, not the whole accumulated project;
7. block acceptance freeze only for genuine consequential unresolved meaning;
8. create almost no ceremony when the trigger does not fire;
9. reuse existing protocols, task templates, registers, and freeze mechanics;
10. distinguish semantic expressibility from agency accessibility and endogenous reachability;
11. remain revisable/removable if experience shows it produces mostly noise.

## 4. No new governance layer

Do **not** create a new standing protocol, board, or semantic-interaction register.

The durable owner remains:

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Detailed recurring mechanics should live in one compact checklist:

`governance/checklists/SEMANTIC_INTERACTION_DELTA_CHECKLIST.md`

Existing owners remain responsible for:

- fresh review/delegation;
- decision promotion;
- deferred/open gaps;
- acceptance freeze;
- implementation dispatch;
- post-implementation conformance.

The Master Architect Guide and Constitution should not duplicate the mechanism.

## 5. Trigger gate — semantic interaction frontier

Every consequential preimplementation reconciliation records:

> **Semantic-interaction-delta trigger:** FIRED / NOT FIRED — [reason]

### FIRES when newly introduced semantics can materially interact with an existing capability/path through at least one of these mechanisms

The new layer:

1. **reads** existing authoritative/subjective state in a new way;
2. **writes** state that existing actions/relations depend upon;
3. adds a new **gate/precondition** to an existing action or capability;
4. adds/removes/reorders an **action candidate** or response path;
5. competes for or reallocates an existing **resource/capacity**;
6. changes **ownership, control, authority, legitimacy, or representation**;
7. changes **knowledge, observation, recognition, visibility, or information routing**;
8. introduces a new **identity/lifecycle/transition** that existing state must survive or cross;
9. introduces **space/geography/time/topology** that can affect old causal paths;
10. introduces **inheritance/succession/transfer** of claims, obligations, resources, roles, or identity;
11. introduces a higher-order actor/institution that can enable, suppress, mediate, or absorb older personal action;
12. introduces multi-position semantics where positions may alias onto one actor;
13. otherwise creates a plausible new↔old causal interaction on the slice's consequential path.

This is the **interaction frontier**: the bounded set of existing semantic surfaces the new layer can actually touch.

### NOT FIRED

Record NOT FIRED when the change is consequentially local and does not create a new interaction frontier with existing semantics.

No further audit artifact is required.

## 6. Frontier discovery — how to keep the audit bounded

When the trigger fires, first identify only the affected prior surfaces.

For the new semantic layer/transition, ask which existing things it can:

- enable;
- suppress;
- gate;
- invalidate;
- consume;
- transfer;
- inherit;
- expose/hide;
- reroute;
- reinterpret;
- cause to compete;
- carry across a transition.

Do not enumerate all historical actions/objects.

The output is a small **interaction-frontier list** used by the lenses below.

## 7. Lens A — newly possible / compositional affordance

For every material new↔old frontier:

> **What ordinary causal history becomes newly possible because the new layer combines with existing capacities, resources, relations, authority, knowledge, or actions?**

This includes same-actor capacity composition but is not limited to it.

Classify each material candidate.

Typical findings:

- existing semantics already support it;
- accepted authority explicitly prohibits it;
- it is intentionally deferred;
- it reveals a genuine missing meaning.

Absence from the current action catalogue is not evidence of prohibition.

## 8. Lens B — capability preservation / non-erasure / dependency shift

Do **not** impose a blanket rule that all old capabilities must survive every new layer.

New semantics may intentionally narrow or condition old behavior.

Instead ask:

> **What previously valid capabilities, relations, obligations, claims, or causal paths are affected by the new layer?**

Then:

> **Did anything that used to be possible become impossible, narrower, newly conditional, rerouted, or dependent on a new state without explicit authority?**

### Old-world projection test

Where meaningful, construct the **neutral embedding** of the old world into the new model:

- set the new layer to the neutral/inert/default condition representing the old scenario;
- preserve the old causal inputs;
- ask whether the previously valid history remains semantically equivalent.

If not, classify the delta.

This is a review principle, not a requirement that every layer possess a literal neutral value.

### Dispositions for old-capability changes

- **PRESERVED** — old capability remains equivalent on the relevant old-world projection;
- **INTENDED CHANGE** — accepted authority explicitly changes it;
- **DERIVED CONSEQUENCE** — the change follows necessarily from already accepted semantics without a new choice;
- **DEFERRED** — interaction intentionally not resolved yet, with trigger;
- **UNRESOLVED** — consequential meaning is missing;
- **ACCIDENTAL GAP / REGRESSION** — no authority supports the loss/narrowing and the intended world still needs the path.

`DERIVED CONSEQUENCE` requires a clear authority derivation; it may not be used as a label for implementation intuition.

## 9. Lens C — new dependency / coupling / causal retargeting

A new layer may leave an action technically possible while changing **why**, **through whom**, or **under which authority/state** it works.

Ask:

- did an old action gain a new required dependency?
- did its authority move from person to office/institution or vice versa?
- did its resource source change?
- did its subjective-information requirement change?
- did its provenance/identity meaning change?
- did an old independent subsystem become coupled to another?
- can the new layer shadow an older action even though that action still exists nominally?

Classify material changes using the same PRESERVED / INTENDED CHANGE / DERIVED CONSEQUENCE / DEFERRED / UNRESOLVED / ACCIDENTAL GAP vocabulary.

This lens catches “capability still exists in code” cases whose causal meaning silently changed.

## 10. Lens D — transition carryover / path closure

For each consequential **new or materially changed transition**, explicitly ask:

> **What existing causal state survives, transfers, suspends, terminates, or becomes invalid across this transition?**

Inspect where applicable:

- claims;
- obligations/debts/favours;
- ownership/control;
- residence/location;
- relationships;
- knowledge/recognition;
- permissions/authority;
- resource commitments;
- pending proposals/processes;
- role occupancy;
- identity/lineage;
- cooldown/timing state.

Then ask:

> **Can every intended valid pre-state reach the intended valid post-state without an undefined semantic hole, orphaned state, accidental reset, or impossible crossing?**

Endpoint validity alone is not sufficient.

A missing carryover rule that changes project meaning is UNRESOLVED, not implementation discretion.

## 11. Lens E — participant aliasing

When an action/transaction contains multiple semantic positions, ask:

> **Which positions may legally be occupied by the same PersonId, and what changes when they alias?**

Audit only meaningful aliases.

Classify each as:

- **SUPPORTED**;
- **PROHIBITED**;
- **IRRELEVANT / COMMUTING**;
- **DEFERRED**;
- **UNRESOLVED**.

### Alias-effect prompts

Check whether aliasing changes:

1. independent cognition / need for response context;
2. initiative accounting;
3. self-authorization;
4. resource identity / double counting;
5. causal provenance;
6. conflict/revalidation;
7. cardinality/multi-party conditions;
8. persistence/succession;
9. subjective knowledge entitlement;
10. automatic consequences / duplicate effects.

Aliasing is an important probe, not the definition of the overall failure class.

## 12. Compact semantic-delta table

Default location: inside the slice's existing preimplementation reconciliation.

Create a separate file only when readability demands it.

Recommended schema:

| New/changed surface | Existing affected capability/path | Delta lens/type | Before | After / question | Disposition | Authority / trigger | Acceptance implication |
|---|---|---|---|---|---|---|---|

Useful delta-type labels:

- `NEW_AFFORDANCE`
- `SUPPRESSED_OR_NARROWED`
- `NEW_DEPENDENCY`
- `CAUSAL_RETARGETING`
- `NEW_CONFLICT_OR_SHARED_CAPACITY`
- `TRANSITION_CARRYOVER`
- `PARTICIPANT_ALIAS`
- `NO_MATERIAL_DELTA`

Do not create a permanent global ledger.

## 13. Fresh negative-space challenge

If the trigger fires for a consequential slice, commission **one fresh-context reviewer before acceptance freeze**.

The reviewer is not asked to verify the specification.

The reviewer is asked to challenge the possibility-space delta.

### Supplied context

Give:

- the new semantic objects/modes/transitions;
- the relevant old capabilities/pathways at the interaction frontier;
- real accepted invariants/exclusions;
- enough domain situation to avoid nonsense.

Do **not** seed with:

- current acceptance-row IDs;
- existing action catalogue as the brainstorming list;
- prior negative-space findings;
- preferred missing affordances.

### Reviewer prompts

Return normally **3–7** concrete ordinary histories/questions spanning as relevant:

1. **new possibility** — what might now be possible because old and new semantics interact?
2. **lost/narrowed possibility** — what might now stop working or require a new condition?
3. **transition hole** — what might break while moving between new states?
4. **aliasing** — what apparently separate positions might be the same actor?
5. **causal retargeting** — what old behavior might still occur but through the wrong authority/resource/knowledge path?

The reviewer produces **questions/counterexamples**, not semantics.

## 14. Master Architect reconciliation of the challenge

The Master Architect classifies each reviewer return against full canonical authority.

Possible disposition:

- SUPPORTED / PRESERVED;
- PROHIBITED / INTENDED CHANGE;
- DERIVED CONSEQUENCE;
- IRRELEVANT;
- DEFERRED with trigger;
- UNRESOLVED;
- ACCIDENTAL GAP / REGRESSION.

Any consequential UNRESOLVED or ACCIDENTAL GAP blocks acceptance freeze until repaired or validly deferred.

Agreement/count of reviewer ideas is not evidence.

## 15. Why this remains separate from acceptance review

Acceptance review asks:

> **Is completion authority complete relative to accepted semantics?**

Semantic-interaction-delta review asks:

> **Did the new layer change the world's possibility space in a way our accepted semantics never classified?**

A perfect acceptance review cannot answer the second question if both specification and manifest omit the possibility.

Therefore:

**semantic-delta closure -> acceptance candidate/review -> freeze**

not the reverse.

The final acceptance reviewer verifies that required semantic-delta work was performed and reconciled; they do not create missing semantics themselves.

## 16. Acceptance-freeze gate

When trigger = FIRED, acceptance freeze requires:

1. interaction frontier identified;
2. relevant delta lenses completed;
3. meaningful same-person aliases classified where applicable;
4. transition carryover audited for new consequential transitions;
5. fresh negative-space challenge complete;
6. every challenge dispositioned;
7. consequential `UNRESOLVED = 0`;
8. consequential `ACCIDENTAL GAP / REGRESSION = 0` or repaired before freeze;
9. any accepted new/changed meaning present in the acceptance candidate;
10. deliberate deferrals retain explicit triggers;
11. no verification artifact silently creates the missing rule.

Freeze record fields:

- `Semantic-interaction-delta trigger: FIRED|NOT FIRED`
- `Delta-closure location: <path>|N/A`
- `Negative-space challenge: <path>|N/A`
- `Consequential unresolved: 0|N`
- `Accidental gaps outstanding: 0|N`

## 17. Implementation-packet stop rule

When the trigger fired, the implementation packet cites the semantic-delta closure among required inputs.

Add this standard escalation:

> **If implementation reveals a consequential new↔old semantic interaction, same-person alias, transition carryover, suppression/narrowing, or causal dependency not classified by the accepted semantic-delta closure, STOP. Do not infer that absence means prohibition, support, or implementation discretion.**

The bārû does not repeat the whole audit.

## 18. Scaling as the project grows

### Delta-based, not cumulative

Slice N audits:

- new/changed semantics in N;
- prior surfaces they can materially touch.

It does not re-audit the entire project.

### Reopen only on interaction change

A previously classified interaction reopens only when:

- one participating semantic surface changes materially;
- a new layer creates a new dependency/resource/authority/information path through it;
- a new transition crosses it;
- implementation/observation produces a concrete counterexample.

### One reviewer by default

Normally:

- one compact frontier/delta table;
- one fresh negative-space reviewer;
- 3–7 counterexamples/questions.

Use multiple reviewers only for unusually large/novel semantic frontiers.

### No new global register

Use existing decisions, open/deferred gaps, reconciliation, acceptance authority, and future-lessons artifacts.

## 19. Mechanical enforcement

Initially use stable textual markers only.

Expected markers in consequential preimplementation/freeze records:

- `Semantic-interaction-delta trigger: FIRED|NOT FIRED`
- `Delta-closure: COMPLETE <path>|N/A`
- `Negative-space challenge: COMPLETE <path>|N/A`
- `Consequential unresolved: 0|N`
- `Accidental gaps outstanding: 0|N`

After 2–3 triggered slices, consider a tiny repository lint that checks only marker completeness.

Do not automate semantic classification.

## 20. Pilot on currently blocked Slice 4

Run the full mechanism before producing the DEC-0011 successor acceptance candidate.

### Interaction frontier

At minimum include:

- personal agency ↔ HouseholdDecisionContext;
- head role authority ↔ private ownership;
- head ↔ persistent provision contributor;
- Household material action ↔ personal material action/shared grain;
- head/bride/groom mediated-marriage positions;
- nominator/nominee/head/current participant;
- support recipient/head/contributor;
- succession/vacancy ↔ commitments/private transaction terms;
- Active/Inactive/Dissolved transitions ↔ pending Household actions;
- objective occupancy ↔ subjective head Recognition;
- participation end ↔ head role/provision/continuity.

### Old-world projection

Verify that introducing the office layer does not accidentally erase, in otherwise equivalent old-world conditions:

- ordinary personal action;
- lower-level person-person transfer;
- standing provision commitment semantics;
- participation/continuity semantics;
- actor-specific knowledge/Recognition boundaries.

Any intended change must trace to accepted authority.

### Transition carryover

Audit at minimum:

- appointment;
- succession;
- head participation end/vacancy;
- Active -> Inactive;
- Inactive -> Active;
- Dissolution.

Classify survival/termination/transfer of existing commitments, pending actions, private transaction terms, Recognition, and personal capabilities.

### Participant aliasing

Classify material aliases including:

- head = private contributor;
- head = standing provision contributor;
- head = bride;
- head = groom;
- head = support recipient;
- nominator = nominee;
- outgoing head = continuing provision contributor after succession;
- current participant = other relevant transaction positions.

Do not presume each is legal; classify from authority.

### Fresh challenge

Commission one fresh reviewer using the semantic frontier, not the action catalogue.

If another missing semantic meaning appears, repair it before successor acceptance.

## 21. Proposed repository changes after Director approval

### Modify

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Add to §3 Semantic closure:

- semantic-interaction-delta trigger;
- interaction-frontier identification;
- delta lenses:
  - new affordance;
  - suppression/narrowing/old-world projection;
  - new dependency/causal retargeting;
  - transition carryover;
  - participant aliasing when relevant;
- fresh negative-space challenge.

Add to §10 Acceptance authority review:

- confirm triggered delta closure occurred before candidate freeze;
- confirm no consequential unresolved/accidental gaps remain.

Add to §13–14:

- implementation packet references closure;
- implementation stop rule for newly exposed unclassified semantic interactions.

### Add

`governance/checklists/SEMANTIC_INTERACTION_DELTA_CHECKLIST.md`

Contains:

- trigger prompts;
- frontier discovery prompts;
- compact delta table;
- old-world projection check;
- transition carryover prompts;
- alias prompts;
- negative-space challenge template;
- disposition vocabulary.

### Modify

`governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md`

Conditional check:

- if trigger FIRED, require completed semantic-delta closure + negative-space challenge + zero consequential unresolved/accidental gaps.

### Modify

`tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md`

Add the conditional semantic-delta closure input and stop rule.

### Do not modify initially

- Master Architect Guide;
- Working Constitution;
- delegation protocol;
- Review and Drift Audit;
- ordinary implementation/test workflow.

Avoid duplication.

## 22. Independent governance review before promotion

Before canonizing the governance change, commission one fresh governance reviewer.

Ask whether the proposed mechanism:

1. protects the broader new-layer↔old-world failure class rather than only aliasing;
2. catches both newly possible and newly suppressed/narrowed histories;
3. handles transition gaps;
4. remains bounded/delta-based;
5. avoids treating “conservative extension” as an absolute semantic law;
6. leaves new semantic choices with the Director;
7. does not duplicate existing composition/conflict/conformance review;
8. provides enough fresh-context negative-space challenge to buy imagination;
9. remains usable by a future Master Architect from repository instructions alone;
10. has a clear removal/narrowing path if it becomes ceremony.

## 23. Effectiveness review after adoption

After the next **2–3 triggered consequential slices**, review:

- material gaps found;
- false positives/noise;
- whether findings duplicated existing assurance;
- Master Architect effort;
- reviewer effort;
- whether old-world projection caught regressions;
- whether transition carryover found real holes;
- whether the mechanism caused premature semantic expansion;
- trigger clarity.

Then:

- retain;
- narrow;
- simplify;
- add tiny lint;
- or retire.

The failsafe must earn continued existence.

## 24. Success criterion

The durable habits become:

> **When adding a semantic layer, identify the old world it can touch.**

Then ask:

> **What became newly possible?**

> **What became newly impossible, narrower, or newly dependent?**

> **What causal state must survive or transform across the new transitions?**

> **Which apparently separate positions may actually be the same actor?**

And finally:

> **What ordinary possibility might still be missing from all of our categories?**

This protects the broad interaction-delta failure class without asking the project to model the entire human possibility space.
