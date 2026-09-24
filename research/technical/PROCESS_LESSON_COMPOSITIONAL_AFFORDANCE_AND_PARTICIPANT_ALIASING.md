# Process Lesson — Compositional Affordance and Participant-Aliasing Audit
## A lightweight way to find semantic holes that verification cannot discover from an incomplete specification

**Status:** Advisory process proposal for Project Director / current Master Architect consideration.  
**Authority:** None. Prepared by the retired former Master Architect; no repository mutation performed.  
**Purpose:** Institutionalize the lesson from the missing office-holder self-funding capability without creating a new governance layer or assigning impossible omniscience to the Project Director.

---

## 1. What failed

The project’s assurance machinery did not fail at its normal job.

It correctly checked:

- whether implementation matches accepted semantics;
- whether authority/precondition races are closed;
- whether resources remain grounded;
- whether personal and Household decision contexts remain distinct;
- whether acceptance evidence is complete relative to the specification;
- whether verification invents semantics.

The missing self-funding capability existed **outside the accepted semantic vocabulary**.

Therefore a perfect conformance system could have frozen, implemented, and verified the omission.

The problem was not:

> “a requirement was forgotten by implementation.”

It was:

> **“a plausible causal affordance was never represented as a requirement at all.”**

Verification cannot prove completeness against possibilities the model never names.

---

## 2. The specific structural pattern

The hole arose because several capacities were each modeled correctly in isolation:

- Person P owns private grain.
- HeadRole grants scoped Household authority.
- Household backing comes from provision commitments.
- The head has both personal and Household decision contexts.

But the design did not ask:

> **What can happen because the same underlying person simultaneously occupies more than one of these causal positions?**

In the discovered case:

`office-holder`
+
`private resource owner`
+
`voluntary decision-maker`
=
`person may personally supplement an institutional action`

The model had the pieces but not the composition.

This is a recurring modeling risk whenever one actor can simultaneously be:

- office-holder and private owner;
- buyer and creditor;
- bride and head;
- representative and counterparty;
- supervisor and worker;
- participant and resource contributor;
- former holder and current social influencer;
- witness and claimant;
- institutional actor-carrier and ordinary person.

---

## 3. Two lightweight audit questions

The lesson can be institutionalized with **two questions**, not a new review bureaucracy.

### A. Compositional affordance question

Whenever a slice introduces a new actor mode, office, authority source, resource-control relation, or higher-order action path, ask:

> **Which independently valid capacities can the same underlying actor combine in one causal episode, and does the model accidentally forbid any ordinary combination merely because those capacities were designed separately?**

Do not enumerate the full Cartesian product of all actions.

Use bounded judgment around newly interacting semantic surfaces.

### B. Participant-aliasing question

For every consequential action/transaction with multiple semantic positions, ask:

> **Which positions may legally be occupied by the same PersonId, and what happens when they alias?**

Classify each meaningful alias as:

- explicitly allowed;
- explicitly prohibited;
- semantically irrelevant/commuting;
- deferred with trigger;
- genuine unresolved decision.

Absence of an action path is **not** evidence that aliasing is prohibited.

---

## 4. Why participant aliasing is especially valuable

Many specifications are unconsciously written as if semantic positions imply different people:

- head asks participant;
- groom asks household head;
- contributor funds recipient;
- nominator nominates nominee;
- office authorizes resource owner.

But real social worlds often permit one person to occupy multiple positions.

The current project already discovered one such case deliberately:

- female head may mediate her own marriage;
- bride = current head is legal;
- groom != head still prevents groom self-authorization.

The self-funding hole is another:

- head = private contributor / resource owner.

Making aliasing an explicit pre-freeze question converts these discoveries from lucky memory into a repeatable audit habit.

---

## 5. Negative-space / ordinary-affordance challenge

A second small technique can reduce dependence on the Project Director remembering every implication.

Before freezing acceptance authority for a consequential new social layer, assign a fresh-context reviewer a bounded **negative-space challenge**.

The reviewer is not asked:

> “Does this specification cover all human behavior?”

That is impossible and would create noise.

Instead ask:

> “Given the new semantic objects and powers introduced by this slice, propose a small number of ordinary, concrete actions a person in this situation might plausibly attempt that are not copied from the action catalogue. For each, determine whether the model supports it, intentionally forbids it, deliberately defers it, or simply never considered it.”

Examples for Slice 4 might have included:

- “Can the head personally cover a shortfall?”
- “Can the bride also be the head?”
- “Can an outgoing head perform one final valid act?”
- “Can a head retain a personal action unrelated to office?”
- “Can a former head remain a provision contributor after succession?”

The output is **questions**, not new semantics.

Only cases that expose a genuine missing meaning escalate to the Director.

This turns fresh human/world-model imagination into a delegated falsification activity instead of making the Director manually remember every possibility.

---

## 6. Where this fits in existing governance

No new protocol is needed.

The natural home is the existing:

`governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

under the semantic-closure section, near:

- Composition and conflict;
- Nested action / transaction completion;
- Authority/precondition races.

A minimal addition could be conceptually equivalent to:

> **Cross-context affordance / participant aliasing:** When a slice introduces multiple actor modes, roles, authority sources, ownership/resource controls, or transactional positions that one underlying actor may simultaneously occupy, perform a bounded composition/aliasing audit before acceptance freeze. Identify ordinary combinations made possible by the actor holding more than one capacity. For multi-position actions, explicitly classify meaningful same-PersonId aliases as allowed, prohibited, deferred, or unresolved. Do not treat absence from the current action catalogue as evidence of semantic prohibition.

The acceptance-authority review can then ask one additional question:

> Has a fresh reviewer challenged the **negative space** around newly introduced powers, rather than only checking completeness relative to the existing specification?

That is enough.

---

## 7. Trigger discipline

Do **not** run this audit for every small mechanic.

Trigger it when a slice introduces or materially changes one of:

- an office/representative mode alongside personal agency;
- multiple authority sources carried by one person;
- institutional access to privately owned resources;
- multi-party transactions where roles can alias;
- a higher-order actor acting through a lower-level person;
- delegation/representation;
- ownership versus control distinctions;
- succession/former-holder behavior;
- nested consent/authorization paths.

Slice 4 is a textbook trigger because it introduces personal + Household dual mode, office authority, private backing, succession, and role-scoped response.

---

## 8. The deeper distinction to preserve

There are at least three different completeness questions:

### 1. Semantic expressibility

Can the world represent the action/history at all?

The self-funding hole failed here.

### 2. Agency accessibility

Given that the action exists, can the reference policy actually discover/choose it?

Birth Run 001 and the Enna long-run expose problems here.

### 3. Endogenous reachability

Can ordinary world dynamics produce the preconditions under which the action becomes relevant, or does it exist only in fixtures/tests?

Later observational runs reveal this.

These should not be conflated.

A model can pass implementation conformance while failing agency accessibility.

It can expose an action to agency while never producing its prerequisites.

And it can fail earlier still by lacking the action entirely.

The proposed compositional-affordance audit targets **semantic expressibility**.

---

## 9. What this process cannot do

No procedure can guarantee that every meaningful human possibility has been imagined.

The Director remains important because project meaning is not mechanically derivable from consistency.

But the institution can reduce reliance on singular human memory by making omission discovery a first-class adversarial question.

The desired outcome is not:

> “bureaucracy knows the whole human world.”

It is:

> **“bureaucracy knows how to ask where its own clean categories may have accidentally cut through a real human capability.”**

That is achievable.

---

## 10. Compact institutional lesson

The durable lesson from the self-funding discovery is:

> **When one person can inhabit several causal capacities at once, review the combinations—not only the capacities.**

And for multi-role actions:

> **Always ask which semantic positions can collapse onto the same person.**

Those two habits would likely have surfaced this hole before the Director had to remember it spontaneously.

They are small enough to add to the existing assurance system without turning the project into another layer of ceremony.