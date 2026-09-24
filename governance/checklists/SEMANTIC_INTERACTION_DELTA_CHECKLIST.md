# Semantic Interaction Delta Checklist

**Status:** ACCEPTED supporting checklist under DEC-0012 / `SID-ASSURANCE-v1`  
**Authority:** Operational checklist subordinate to `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`; it does not create simulation or governance semantics.  
**Load when:** a consequential preimplementation reconciliation records `Semantic-interaction-delta trigger: FIRED`.  
**Do not load merely because:** a local/routine implementation or verification task has no material new↔old semantic interaction frontier.

## 1. Trigger

Record exactly one:

- `Semantic-interaction-delta trigger: FIRED — <reason>`
- `Semantic-interaction-delta trigger: NOT FIRED — <reason>`

FIRES when newly introduced or materially changed semantics can materially interact with an existing capability/path through one or more of:

- reads/writes of existing authoritative or subjective state;
- new gates/preconditions;
- new/removed/reordered action or response paths;
- resource/capacity competition or reallocation;
- ownership/control/authority/legitimacy/representation;
- knowledge/observation/recognition/information routing;
- identity/lifecycle/transition;
- space/geography/time/topology;
- inheritance/succession/transfer;
- higher-order actor/institution mediation;
- participant aliasing;
- another consequential new↔old causal interaction.

If NOT FIRED, stop this checklist.

## 2. Interaction frontier

Identify only the existing semantic surfaces the new layer can materially:

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

Do not enumerate the full project or all action pairs.

Recommended frontier table:

| New/changed surface | Existing affected capability/path | Why interaction is plausible |
|---|---|---|

## 3. Delta lenses

For each material frontier surface, use only the lenses that apply.

### A. Newly possible / compositional affordance

Ask:

> What ordinary causal history becomes newly possible because the new layer combines with existing capacities, resources, relations, authority, knowledge, or actions?

Absence from the current action catalogue is not evidence of prohibition.

### B. Suppressed / narrowed / newly conditional old capability

Ask:

> What previously valid capability, relation, obligation, claim, or causal path becomes impossible, narrower, rerouted, or newly dependent on state introduced by the new layer?

Where meaningful, perform an **old-world projection**:

- embed the old scenario in a neutral/inert/default use of the new layer;
- preserve the old causal inputs;
- ask whether the old history remains semantically equivalent.

This is a diagnostic only. It is not a rule that every new semantic layer must conservatively preserve every old behavior.

### C. New dependency / coupling / causal retargeting

Ask whether an old action still exists but now:

- depends on new authority;
- consults different knowledge;
- draws from a different resource;
- becomes institution-mediated;
- loses an independent route;
- changes provenance/identity meaning;
- becomes coupled to a formerly independent subsystem.

### D. Transition carryover / path closure

For each consequential new or changed transition, ask:

> What existing causal state survives, transfers, suspends, terminates, or becomes invalid across this transition?

Inspect where applicable:

- claims;
- obligations/debts/favours;
- ownership/control;
- residence/location;
- relationships;
- knowledge/Recognition;
- permissions/authority;
- resource commitments;
- pending proposals/processes;
- role occupancy;
- identity/lineage;
- cooldown/timing state.

Endpoint validity alone is not sufficient.

### E. Participant aliasing

For meaningful multi-position actions/transactions ask:

> Which semantic positions may legally share one PersonId, and what changes when they alias?

Check whether aliasing changes:

1. independent cognition / need for response context;
2. initiative accounting;
3. self-authorization;
4. resource identity / double counting;
5. causal provenance;
6. conflict/revalidation;
7. cardinality / required distinct parties;
8. persistence/succession;
9. subjective knowledge entitlement;
10. automatic consequences / duplicate effects.

Aliasing is a subtype of semantic interaction delta, not the umbrella definition.

## 4. Delta table

Recommended schema:

| New/changed surface | Existing affected capability/path | Delta type | Before | After / question | Disposition | Authority / trigger | Acceptance implication |
|---|---|---|---|---|---|---|---|

Useful delta types:

- `NEW_AFFORDANCE`
- `SUPPRESSED_OR_NARROWED`
- `NEW_DEPENDENCY`
- `CAUSAL_RETARGETING`
- `NEW_CONFLICT_OR_SHARED_CAPACITY`
- `TRANSITION_CARRYOVER`
- `PARTICIPANT_ALIAS`
- `NO_MATERIAL_DELTA`

## 5. Fresh challenge — two-pass frontier independence

Use one fresh reviewer by default.

### Pass A — independent frontier discovery

Before the reviewer sees the Master Architect frontier/delta table, provide:

- the new semantic layer / objects / modes / transitions;
- a **domain/subsystem-oriented** compact canonical map of adjacent existing semantics and retrieval entrypoints;
- real accepted invariants/exclusions.

The Pass-A context map must not be mechanically generated by pruning the Master Architect frontier.

Do not provide yet:

- MA frontier rows;
- MA delta classifications;
- acceptance-row IDs;
- action catalogue as a brainstorming list;
- prior negative-space findings;
- preferred missing affordances.

Ask the reviewer:

> Independently identify which prior semantic surfaces this new layer might materially interact with, suppress, reroute, inherit from, compete with, or have to cross.

Pass A returns a compact candidate frontier with reasons.

**Durably freeze Pass A before reveal** using an exact commit/blob/ref or equivalent strong identity.

### Pass B — compare frontier + negative-space histories

After Pass A is fixed:

1. reveal the MA frontier;
2. compare:
   - reviewer-only surfaces;
   - MA-only surfaces;
   - overlapping surfaces;
3. reconcile the justified union;
4. record reasons for excluding any reviewer-only surface as immaterial;
5. ask for normally **3–7** concrete ordinary histories/questions across the reconciled frontier, attempting relevant coverage of:
   - newly possible;
   - lost/narrowed;
   - transition hole;
   - aliasing;
   - causal retargeting.

The reviewer returns questions/counterexamples only. They do not create semantics.

## 6. Dispositions and authority-bearing closure

Possible dispositions include:

- `SUPPORTED / PRESERVED`
- `PROHIBITED / INTENDED CHANGE`
- `DERIVED CONSEQUENCE`
- `IRRELEVANT / COMMUTING`
- `DEFERRED`
- `UNRESOLVED`
- `ACCIDENTAL GAP / REGRESSION`

**Classification is not closure by itself.**

### DERIVED CONSEQUENCE

Must identify controlling accepted authority showing the consequence follows without a new semantic choice.

### DEFERRED

Clears the current freeze gate only if all are true:

1. the deferral itself is authorized at the required authority level;
2. a durable owner/trigger exists;
3. the current slice remains semantically complete and implementable without deciding it;
4. implementation cannot accidentally choose the deferred meaning.

### PROHIBITED / INTENDED CHANGE

Must trace to authority that actually prohibits/changes the behavior. Absence from the action catalogue is insufficient.

### IRRELEVANT / COMMUTING

Must state why the interaction has no consequential effect for the current frontier.

### Blocking dispositions

Consequential:

- `UNRESOLVED`
- `ACCIDENTAL GAP / REGRESSION`

block acceptance freeze until repaired or validly narrowed/deferred by authority.

## 7. Closure freshness / staleness

Bind the closure to an exact accepted semantic base/ref/commit or equivalent durable authority identity.

Any **material semantic change after closure** makes the closure stale for acceptance freeze until the trigger/frontier is explicitly re-evaluated.

Record one:

- `REVALIDATED — NO FRONTIER CHANGE`
- `REOPENED — AFFECTED FRONTIER`

Revalidation must identify:

- semantic change reviewed;
- old closure identity;
- new semantic base;
- no-impact rationale or affected frontier.

Do not rerun unaffected scope merely for ceremony.

## 8. Required closure markers

When FIRED, record:

- `Semantic-interaction-delta trigger: FIRED`
- `Delta semantic base: <ref/commit/authority identity>`
- `Delta-closure: COMPLETE <path>`
- `Independent frontier Pass A: COMPLETE <path/ref/hash>`
- `Negative-space challenge Pass B: COMPLETE <path>`
- `Closure freshness: CURRENT`
- `Consequential unresolved: 0`
- `Accidental gaps outstanding: 0`

When NOT FIRED, record only the NOT-FIRED reason unless local context requires more.

## 9. Pilot / effectiveness evidence labels

When reporting policy performance, use these exact labels together:

- `KNOWN CASE PROCESSED`
- `PREVIOUSLY UNKNOWN MATERIAL FINDING`
- `DUPLICATE FINDING`
- `NOISE / FALSE POSITIVE`
- `NO NEW FINDING`

Do not count a motivating known defect as prospective discovery evidence.

## 10. Acceptance-freeze test

Before freezing a consequential acceptance artifact whose trigger FIRED, verify:

- interaction frontier reconciled;
- Pass A frozen before MA-frontier reveal;
- Pass B complete over justified union;
- relevant delta lenses completed;
- transition carryover audited where applicable;
- meaningful aliases classified where applicable;
- every disposition has authority-bearing closure rationale;
- every DEFERRED item passes the authorized-deferral test;
- `Consequential unresolved: 0`;
- `Accidental gaps outstanding: 0`;
- closure semantic base matches the acceptance candidate's accepted semantic base, or an explicit no-frontier-change revalidation exists;
- all accepted semantic repairs are promoted before the acceptance candidate;
- verification did not invent the missing rule.

## 11. Implementation stop rule

If implementation exposes a **consequential** new↔old semantic interaction, suppression/narrowing, transition carryover case, causal dependency/retargeting, shared-capacity interaction, or participant alias not classified by the accepted closure:

**STOP and escalate.**

Do not infer that absence means:

- supported;
- prohibited;
- deferred;
- implementation discretion.

The implementation agent does not repeat this entire audit.

## 12. Scaling

Audit the semantic **delta/frontier**, not the entire historical project.

A previously classified interaction reopens when materially affected.

Any later material semantic change still requires closure-freshness re-evaluation, which may conclude no frontier change.

Use multiple reviewers only when one reviewer's breadth is clearly insufficient for an unusually large/novel frontier.

## 13. Effectiveness / sunset review

After `SID-ASSURANCE-v1` FIRES on 2–3 consequential slices, review:

- known cases processed;
- previously unknown findings;
- duplicate findings;
- noise/false positives;
- whether Pass A added surfaces the MA omitted;
- old-world projection value;
- transition-carryover value;
- closure-revalidation cost/value;
- deferral-classification discipline;
- MA/reviewer effort;
- trigger clarity;
- premature semantic expansion;
- implementation escalations caught.

Permitted outcomes:

- RETAIN;
- NARROW;
- SIMPLIFY;
- ADD LIGHTWEIGHT LINT;
- RETIRE.

The failsafe must earn continued existence.
