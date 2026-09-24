# Governance Plan — Semantic Interaction Delta Failsafe

**Status:** PROMOTED / ACCEPTED UNDER DEC-0012  
**Date:** 2026-09-24  
**Owner:** Master Architect  
**Authority:** historical/promotional rationale only. Binding governance now lives in DEC-0012, `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`, and `governance/checklists/SEMANTIC_INTERACTION_DELTA_CHECKLIST.md`.  
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

## 13. Fresh negative-space challenge — two-pass frontier independence

If the trigger fires for a consequential slice, commission **one fresh-context reviewer before acceptance freeze**.

The reviewer is not asked to verify the specification and is not granted semantic authority.

The challenge has **two sequential passes using the same reviewer** so the reviewer can challenge both:

- the Master Architect's proposed interaction frontier; and
- the possibility-space delta inside the reconciled frontier.

### Pass A — independent frontier discovery

Before the reviewer may inspect the Master Architect's frontier/delta table, give only:

- the new semantic layer / objects / modes / transitions;
- a compact canonical map of adjacent existing semantics sufficient to orient the domain;
- real accepted invariants/exclusions;
- the local subsystem/retrieval entrypoints needed to inspect those existing semantics.

Do **not** reveal yet:

- the Master Architect's interaction-frontier list;
- the Master Architect's delta classifications;
- current acceptance-row IDs;
- the existing action catalogue as a brainstorming list;
- prior negative-space findings;
- preferred missing affordances.

Pass A asks:

> **Independently identify which prior semantic surfaces this new layer might materially interact with, suppress, reroute, inherit from, compete with, or have to cross.**

The reviewer should return a compact candidate-frontier list with reasons.

**Freeze Pass A before reveal.** Persist the Pass-A result with an immutable commit/ref, content hash, or equivalently strong durable identity before the reviewer sees the Master Architect frontier. The purpose is to prevent hindsight from rewriting the supposedly independent frontier discovery.

### Pass B — frontier comparison + negative-space histories

After Pass A is durably fixed:

1. reveal the Master Architect's frontier;
2. compare reviewer frontier versus MA frontier;
3. reconcile the **union** of both frontier sets for the challenge;
4. explicitly flag:
   - reviewer-only surfaces;
   - MA-only surfaces;
   - overlapping surfaces;
   - any surface rejected as immaterial, with reason.

Then return normally **3–7** concrete ordinary histories/questions over the reconciled frontier, spanning as relevant:

1. **new possibility** — what might now be possible because old and new semantics interact?
2. **lost/narrowed possibility** — what might now stop working or require a new condition?
3. **transition hole** — what might break while moving between new states?
4. **aliasing** — what apparently separate positions might be the same actor?
5. **causal retargeting** — what old behavior might still occur but through the wrong authority/resource/knowledge path?

The reviewer produces **questions/counterexamples**, not semantics.

One reviewer remains the default. The extra protection is **frontier independence**, not another review layer.

## 14. Master Architect reconciliation of the challenge

The Master Architect first reconciles the **frontier itself**:

- every reviewer-only frontier surface receives an inclusion/exclusion judgment with canonical rationale;
- every MA-only surface remains visible;
- the final challenge/closure frontier is the justified union after exclusions, not automatically the original MA list.

Then the Master Architect classifies each reviewer history/question against full canonical authority.

Possible disposition:

- SUPPORTED / PRESERVED;
- PROHIBITED / INTENDED CHANGE;
- DERIVED CONSEQUENCE;
- IRRELEVANT;
- DEFERRED;
- UNRESOLVED;
- ACCIDENTAL GAP / REGRESSION.

### Classification is not closure by itself

A disposition clears the freeze gate only when its justification is authority-bearing.

- **DERIVED CONSEQUENCE** must identify the accepted authority from which the consequence follows without a new semantic choice.
- **DEFERRED** clears the current freeze gate only when:
  1. the deferral itself is authorized at the required authority level;
  2. an owner/trigger for reopening is durable;
  3. the current slice remains semantically complete and implementable without deciding the deferred meaning;
  4. current implementation cannot accidentally choose the deferred meaning.
- **IRRELEVANT** must state why the interaction has no consequence for the current semantic frontier.
- **PROHIBITED / INTENDED CHANGE** must trace to authority that actually prohibits/changes it; absence from the action catalogue is insufficient.

A consequential UNRESOLVED or ACCIDENTAL GAP blocks acceptance freeze.

A tempting label is never evidence. Agreement/count of reviewer ideas is not evidence.

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

1. MA interaction frontier identified;
2. fresh reviewer Pass-A independent frontier durably fixed;
3. MA/reviewer frontier comparison reconciled;
4. relevant delta lenses completed over the justified closure frontier;
5. meaningful same-person aliases classified where applicable;
6. transition carryover audited for new consequential transitions;
7. Pass-B negative-space challenge complete;
8. every challenge dispositioned with authority-bearing closure rationale;
9. consequential `UNRESOLVED = 0`;
10. consequential `ACCIDENTAL GAP / REGRESSION = 0` or repaired before freeze;
11. any accepted new/changed meaning present in the acceptance candidate;
12. every DEFERRED item satisfies the authorized-deferral test in §14;
13. no verification artifact silently creates the missing rule;
14. the closure is **current against the semantic base used by the acceptance candidate**.

### Closure freshness / staleness rule

A semantic-delta closure is bound to an exact accepted semantic base/ref or equivalent durable authority identity.

Any **material semantic change after closure** makes that closure stale for acceptance freeze until the trigger/frontier is explicitly re-evaluated.

Re-evaluation need not automatically rerun the full audit. It may conclude:

- **REVALIDATED — NO FRONTIER CHANGE** — the semantic change does not alter the trigger/frontier/findings; or
- **REOPENED — AFFECTED FRONTIER** — rerun only the affected frontier/lenses/challenge material.

The revalidation result must identify:

- the semantic change reviewed;
- old closure identity;
- new semantic base;
- why the frontier is unchanged or which portion reopened.

Acceptance freeze may not rely on a closure whose semantic base predates an unreconciled material semantic change.

Freeze record fields:

- `Semantic-interaction-delta trigger: FIRED|NOT FIRED`
- `Delta semantic base: <ref/commit/authority identity>|N/A`
- `Delta-closure location: <path>|N/A`
- `Independent frontier Pass A: <path/ref/hash>|N/A`
- `Negative-space challenge Pass B: <path>|N/A`
- `Closure freshness: CURRENT|STALE|N/A`
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

### Reopen / revalidate on semantic change

A previously classified interaction **reopens** when:

- one participating semantic surface changes materially;
- a new layer creates a new dependency/resource/authority/information path through it;
- a new transition crosses it;
- implementation/observation produces a concrete counterexample.

Separately, **any material semantic change after a closure requires an explicit freshness re-evaluation before acceptance freeze**, even when the likely result is no frontier change.

This makes stale closure mechanically visible without forcing unnecessary full reruns.

A valid no-impact result is:

`REVALIDATED — NO FRONTIER CHANGE`

with the reviewed semantic change and authority identities recorded.

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
- `Delta semantic base: <ref/commit/authority identity>|N/A`
- `Delta-closure: COMPLETE <path>|N/A`
- `Independent frontier Pass A: COMPLETE <path/ref/hash>|N/A`
- `Negative-space challenge Pass B: COMPLETE <path>|N/A`
- `Closure freshness: CURRENT|STALE|N/A`
- `Consequential unresolved: 0|N`
- `Accidental gaps outstanding: 0|N`

After 2–3 triggered slices, consider a tiny repository lint that checks only marker completeness.

Do not automate semantic classification.

## 20. Pilot on currently blocked Slice 4

Run the full mechanism before producing the DEC-0011 successor acceptance candidate.

### Pilot purpose — wiring/adequacy, not prospective efficacy

Slice 4 is an excellent test of whether the mechanism can be executed correctly against a real high-interaction slice.

It is **not** unbiased evidence that the failsafe prospectively discovers unknown omissions because the project already knows the founding self-funding defect and why this policy exists.

Pilot reporting must distinguish:

- **KNOWN CASE PROCESSED** — an already-known defect/risk is correctly represented/classified by the mechanism;
- **PREVIOUSLY UNKNOWN FINDING** — the failsafe surfaces a material interaction/omission not supplied as part of the motivating case;
- **NO NEW FINDING** — the mechanism executes correctly but discovers nothing previously unknown.

Do not count rediscovery of DEC-0011/self-funding as prospective efficacy evidence.

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

After the next **2–3 triggered consequential slices**, review findings in separate evidence classes:

- **KNOWN CASE PROCESSED** — already-known risks/defects the mechanism handled correctly;
- **PREVIOUSLY UNKNOWN MATERIAL FINDING** — a new omission/interaction the mechanism surfaced prospectively;
- **DUPLICATE FINDING** — useful but would clearly have been found by an existing assurance step;
- **NOISE / FALSE POSITIVE** — challenge with no material semantic value.

Also review:

- Master Architect effort;
- reviewer effort;
- whether independent Pass-A frontier discovery added surfaces the MA missed;
- whether old-world projection caught regressions;
- whether transition carryover found real holes;
- whether closure staleness/revalidation caught late semantic changes;
- whether authorized-deferral rules prevented classification gaming;
- whether the mechanism caused premature semantic expansion;
- trigger clarity.

The founding Slice-4 self-funding incident is motivating evidence, **not prospective efficacy evidence**.

A policy may still be worth retaining even if it finds no previously unknown omission, but that conclusion must rest on the observed prevention/clarification value rather than counting known cases as discoveries.

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
