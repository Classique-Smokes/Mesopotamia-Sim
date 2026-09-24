# Governance Plan — Compositional Affordance / Participant-Aliasing Failsafe

**Status:** PROPOSED / DIRECTOR REVIEW  
**Date:** 2026-09-24  
**Owner:** Master Architect  
**Authority:** planning only; no accepted-governance change until explicitly approved/promoted  
**Motivating failure:** Slice-4 office-holder private-resource supplementation omission  
**Primary owner if accepted:** `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

## 1. Problem class

The project already has strong assurance for:

- conformance to accepted semantics;
- parameter validity;
- same-cycle composition/conflict;
- nested action/transaction completion;
- authority/precondition races;
- exact acceptance applicability;
- independent verification/oracle adequacy.

Those mechanisms can still certify an incomplete semantic world if an ordinary causal affordance was never represented in the specification at all.

The missing Slice-4 private-supplement path demonstrated this failure class:

> independently valid capacities existed, but the model never asked what became possible when the same underlying person simultaneously carried several of them.

This is a **semantic expressibility / negative-space** problem.

The failsafe must help discover plausible missing meanings **before acceptance freeze** without pretending to guarantee completeness of human behavior.

## 2. Design goals

The failsafe must:

1. target semantic expressibility rather than duplicate conformance review;
2. focus on newly introduced or newly interacting semantic surfaces;
3. explicitly test same-PersonId role/capacity composition;
4. use fresh-context imagination without granting reviewers semantic authority;
5. block acceptance freeze only for genuine unresolved consequential meaning;
6. create almost no ceremony when the trigger does not fire;
7. scale by auditing deltas, not the full historical model;
8. leave durable closure evidence for future agents;
9. reuse existing protocols, task templates, registers, and freeze mechanics;
10. remain removable/revisable if experience shows it creates noise rather than discoveries.

## 3. No new governance layer

Do **not** create a new standing protocol, board, or register.

The durable owner remains:

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Detailed recurring mechanics should live in one compact checklist:

`governance/checklists/COMPOSITIONAL_AFFORDANCE_AND_ALIASING_CHECKLIST.md`

Existing artifacts remain responsible for:

- delegation / fresh review;
- decision promotion;
- deferred-gap registration;
- acceptance freeze;
- implementation dispatch.

The Master Architect Guide does not need substantive duplication because it already routes consequential specification→implementation work into the assurance protocol and instructs process improvement after repeated Director correction.

## 4. Trigger gate

Every consequential preimplementation reconciliation must record one line:

> **Compositional-affordance / aliasing trigger:** FIRED / NOT FIRED — [reason]

### Trigger FIRED when a slice introduces or materially changes at least one of:

1. office / representative / delegated mode alongside ordinary personal agency;
2. multiple authority sources one person may simultaneously carry;
3. ownership versus control distinctions;
4. institutional access to privately owned resources;
5. multi-position transactions where roles may alias;
6. higher-order actor action carried through a lower-level person;
7. nested consent / authorization;
8. succession / former-holder behavior;
9. a new resource contributor / claimant / counterparty position that can coincide with another existing position;
10. any design where one PersonId may plausibly occupy two newly interacting causal positions.

### Trigger NOT FIRED

No further artifact is required when:

- the change is local/routine;
- no new actor mode/position/authority/ownership interaction exists;
- the behavior stays entirely within already audited semantic positions.

The reconciliation records why and proceeds normally.

## 5. Audit A — compositional affordance

When the trigger fires, inspect only:

- newly introduced capacities/positions; and
- existing capacities that can now be jointly carried with them.

Do **not** enumerate the Cartesian product of all project actions.

### Required question

> Which independently valid capacities can the same underlying actor combine in one causal episode, and does the model accidentally forbid an ordinary combination merely because those capacities were designed separately?

### Compact output

Default location: a table embedded in the slice's normal preimplementation reconciliation.

Only create a separate audit file when the table is too large to remain readable.

Recommended columns:

| Surface | Capacity/position A | Capacity/position B | Plausible composition | Classification | Authority / trigger | Acceptance implication |
|---|---|---|---|---|---|---|

Classification vocabulary:

- **SUPPORTED** — existing accepted semantics can express it;
- **PROHIBITED** — accepted authority explicitly forbids it;
- **IRRELEVANT / COMMUTING** — alias/composition has no semantic consequence;
- **DEFERRED** — intentionally outside current slice, with an explicit trigger;
- **UNRESOLVED** — consequential meaning is missing and must be decided before freeze.

Absence from the current action catalogue is never sufficient evidence for PROHIBITED.

## 6. Audit B — participant aliasing

For each consequential multi-position action or transaction newly introduced / materially changed, list its semantic positions.

Examples of positions:

- initiator;
- target;
- role-holder;
- private resource owner;
- contributor;
- recipient;
- nominee;
- nominator;
- bride/groom;
- creditor/debtor;
- claimant/witness;
- former holder/current participant.

### Required question

> Which positions may legally be occupied by the same PersonId, and what happens when they alias?

Audit only meaningful pairs/triples; do not enumerate impossible or obviously irrelevant combinations.

For each material alias, classify:

- SUPPORTED;
- PROHIBITED;
- IRRELEVANT / COMMUTING;
- DEFERRED;
- UNRESOLVED.

### Mandatory alias-effect prompts

When two positions collapse to one PersonId, ask whether aliasing changes:

1. **independent cognition** — does a response context disappear because there is no independent counterparty?
2. **initiative accounting** — does the actor accidentally gain/lose an initiative?
3. **authority** — does self-authorization become possible or forbidden?
4. **resource identity** — can one stock/claim be double-counted?
5. **provenance** — are two causal roles still distinguishable in history?
6. **conflict/revalidation** — do two legs now compete for the same state/capacity?
7. **cardinality** — does one-person aliasing collapse a required multi-party condition?
8. **persistence/succession** — does a role-derived state incorrectly transfer with the office?
9. **subjective knowledge** — does direct participation in one capacity improperly grant knowledge in another?
10. **automatic consequences** — would treating one episode as two actions double-fire attitudes/favours/evidence?

This list is a prompt, not a new semantic doctrine.

## 7. Fresh negative-space challenge

If the trigger fires for a consequential slice, run one fresh-context challenge **before acceptance freeze**.

Purpose:

> seek ordinary actions/histories missing from the accepted vocabulary, not defects in already-named requirements.

### Independence design

Use a fresh reviewer not responsible for the slice's semantic design or implementation.

The first-stage challenge should receive:

- the newly introduced semantic objects/modes/powers;
- real project invariants and exclusions;
- the relevant social situation;
- enough accepted context to avoid impossible suggestions.

It should **not** be seeded with:

- the current action catalogue as a brainstorming list;
- acceptance-row IDs;
- prior negative-space findings;
- preferred missing affordances.

### Required return

Normally **3–7** ordinary concrete actions/histories that a person in the modeled situation might plausibly attempt.

For each:

- concrete narrative;
- involved capacities / semantic positions;
- why it is ordinary/plausible within the supplied model situation;
- no recommendation about what the project *should* allow.

The reviewer produces questions, not semantics.

### Reconciliation pass

The Master Architect then classifies each challenge against full canonical authority:

- SUPPORTED;
- PROHIBITED;
- DEFERRED;
- IRRELEVANT;
- UNRESOLVED.

Any consequential UNRESOLVED item blocks acceptance freeze until promoted or explicitly deferred with valid authority.

Do not count the number of reviewer ideas as a quality score.

## 8. Why the challenge is separated from acceptance review

Acceptance review asks:

> Is the acceptance authority complete and subordinate relative to accepted semantics?

The negative-space challenge asks:

> What ordinary possibility may never have entered accepted semantics?

These must remain distinct.

A reviewer cannot prove semantic completeness by checking an acceptance table derived from the same vocabulary.

Therefore:

- negative-space challenge occurs before final acceptance freeze;
- acceptance reviewer checks that any triggered challenge was performed and reconciled;
- acceptance reviewer does not inherit authority to create new semantics from a challenge.

## 9. Acceptance-freeze gate

Amend acceptance-authority review/freeze procedure so that, when the trigger FIRED, freeze requires:

1. compositional-affordance table completed;
2. material participant aliases classified;
3. fresh negative-space challenge returned;
4. every challenge dispositioned;
5. no consequential UNRESOLVED item remains;
6. any newly accepted meaning is present in the acceptance candidate;
7. any deliberate deferral has a visible trigger;
8. no reviewer question was silently converted into semantics by verification.

A freeze record records:

- trigger FIRED / NOT FIRED;
- audit location;
- negative-space challenge path or N/A;
- reconciliation/disposition path;
- unresolved count = 0 for freeze.

This should become one line in the existing artifact-freeze checklist, not a new freeze protocol.

## 10. Implementation-packet failsafe

When the trigger fired, the implementation packet must identify the closure record among its required inputs.

Add one escalation clause to the standard implementation template:

> If implementation reveals a consequential same-PersonId alias, cross-context capacity composition, or ordinary affordance not classified by the accepted closure record, STOP rather than treating absence as prohibition or implementation discretion.

This prevents a coder from “solving” a newly exposed negative-space question locally.

It does not require the coder to repeat the audit.

## 11. Scaling strategy

### Delta-based, not cumulative

Future slice N audits:

- capacities/positions added or materially changed by N;
- existing capacities newly connected to them.

It does **not** re-audit all prior slice combinations.

### Re-trigger on seam changes

A previously closed alias/composition is reopened only when:

- one of its participating semantic positions changes materially;
- a new authority/resource channel makes the old classification no longer obviously valid;
- implementation/observation produces a concrete counterexample.

### Bound the review surface

Defaults:

- one compact audit table;
- one fresh negative-space reviewer;
- 3–7 ordinary challenges;
- no parallel review swarm unless the surface is unusually large/novel.

### Existing registers only

- genuine unresolved semantics -> existing open/deferred gap mechanism;
- accepted consequential choice -> Decision Register;
- surprising implementation lesson -> existing future-lessons index;
- no separate “affordance register.”

## 12. Mechanical enforcement

Do not build a large tool initially.

Use stable textual markers first:

- `Compositional-affordance / aliasing trigger: FIRED|NOT FIRED`
- `Negative-space challenge: COMPLETE <path>|N/A`
- `Unresolved consequential affordances: 0|N`

Add them to the expected preimplementation/freeze structure.

After **2–3 consequential slices**, evaluate whether simple repository linting is worthwhile.

A future linter could check that an acceptance freeze record cannot claim readiness when:

- trigger = FIRED;
- challenge is missing;
- unresolved count != 0.

Do not automate semantic classification itself.

## 13. Pilot on the currently blocked Slice 4

Before producing the DEC-0011 successor acceptance candidate:

1. mark Slice 4 trigger **FIRED**;
2. perform the compositional-affordance audit over:
   - Person ordinary agency;
   - HouseholdDecisionContext carrier;
   - head role authority;
   - private resource ownership;
   - persistent provision contributor;
   - mediated-marriage responder/bride/groom positions;
   - nominator/nominee/current participant positions;
   - outgoing/former head;
   - support recipient;
3. perform the participant-aliasing table for the consequential Slice-4 transactions;
4. commission one fresh negative-space challenge;
5. reconcile every returned challenge;
6. if another genuine missing meaning appears, patch semantics before successor acceptance;
7. only then cut the successor Slice-4 acceptance candidate.

This is the first real field test of the failsafe.

The existing Director implementation BLOCK remains active throughout.

## 14. Proposed repository changes after Director approval

### Modify

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Add:

- trigger subsection inside §3 Semantic closure checklist;
- compositional-affordance / participant-aliasing audit requirements;
- negative-space challenge requirement;
- acceptance-freeze check in §10;
- implementation readiness/escalation link in §13–14.

### Add

`governance/checklists/COMPOSITIONAL_AFFORDANCE_AND_ALIASING_CHECKLIST.md`

Purpose:

- compact prompt/table template;
- trigger checklist;
- alias-effect prompts;
- disposition vocabulary;
- no new authority.

### Modify

`governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md`

Add one conditional check:

- if compositional-affordance trigger FIRED, require closed audit + negative-space challenge + zero consequential unresolved findings before acceptance freeze.

### Modify

`tasks/IMPLEMENTATION_TASK_PACKET_TEMPLATE.md`

Add one conditional required-input/escalation sentence for an accepted affordance/aliasing closure record.

### Do not modify initially

- Master Architect Guide;
- Working Constitution;
- general delegation protocol;
- Review and Drift Audit;
- ordinary implementation/test processes.

Avoid duplicated rules.

## 15. Governance-change verification

Before promoting these protocol changes, run one independent governance review asking:

1. does the failsafe actually target the failure class rather than duplicate existing review?
2. is the trigger narrow enough to avoid routine ceremony?
3. can a fresh reviewer still discover negative-space cases without being anchored by the action catalogue?
4. does the process preserve Director authority over new semantics?
5. is the alias classification useful without implying exhaustive human-world completeness?
6. can a future MA apply it from repository instructions alone?
7. can a low-value/noisy audit be recognized and revised later?

This is a process review, not another social-model review.

## 16. Evaluation after adoption

After the next **2–3 triggered consequential slices**, perform a small governance effectiveness check.

Record:

- number/type of material missing affordances found;
- number of false-positive/noise challenges;
- whether any issue would likely have been found by existing assurance anyway;
- MA effort / reviewer effort;
- whether the audit caused premature semantic expansion;
- whether trigger conditions were clear.

Possible outcomes:

- retain unchanged;
- narrow triggers;
- simplify checklist;
- add lightweight lint;
- retire the mechanism if it produces mostly ceremony.

The failsafe must earn continued existence.

## 17. Success criterion

The mechanism succeeds if future architecture has a durable habit of asking:

> when one person can inhabit several causal capacities at once, what combinations become possible?

and:

> which semantic positions can collapse onto the same person?

without asking the bureaucracy to imagine the entire human world or forcing the Project Director to remember every ordinary affordance manually.
