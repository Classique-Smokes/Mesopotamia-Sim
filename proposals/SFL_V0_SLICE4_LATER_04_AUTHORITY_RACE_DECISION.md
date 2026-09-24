# Slice 4 / LATER-04 — Same-Cycle Authority-Destruction Decision

**Status:** DIRECTOR DECISION REQUIRED / PROPOSAL ONLY  
**Date:** 2026-09-24  
**Trigger:** Slice 4 representative/head-role implementation  
**Source reconciliation:** `research/technical/SFL_V0_SLICE4_PREIMPLEMENTATION_RECONCILIATION.md`  
**Authority:** none until explicitly accepted by the Project Director.

## Question

When two attempts are already accepted from the same committed decision snapshot, and one attempt would destroy the head/Household authority or status required by the other, which resolves first in bounded SFL v0?

Examples:

- head P has an accepted Household support/dowry/provision action and also ends Household participation;
- old head A has an accepted Household action while A -> B succession is also validly accepted;
- H has an accepted Household action while same-cycle participation changes would make H Inactive/Dissolved.

The existing SPEC requires immediate precommit revalidation, but does not determine which attempt receives semantic precedence.

Technical IDs/container/proposal ordering are not acceptable substitutes for the missing social rule.

## Option A — authority-use before authority destruction

Resolve an otherwise-valid authority-dependent action before the same-cycle accepted transition whose commit would destroy its required authority/status.

Meaning:

- a valid “last act in office” may commit;
- old-head Household action may commit before succession;
- valid H action may commit before H becomes Inactive/Dissolved;
- the destructive transition then resolves normally;
- all other preconditions still revalidate;
- no pending action rebinds to a successor.

Compact rule:

> An accepted authority-dependent action generated under valid current authority resolves before an accepted same-cycle transition that would destroy that authority, unless another accepted semantic priority independently prevents the action.

## Option B — authority destruction before authority-dependent action

Resolve the accepted authority/status-destroying transition before actions whose commit still depends on that authority/status.

Meaning:

- head exit/vacancy preempts pending old-head Household action;
- succession preempts pending old-head-authorized action;
- transition to Inactive/Dissolved preempts pending H action;
- the dependent action then fails precommit revalidation as `InvalidatedAtResolution`, not Declined;
- no pending action rebinds to the successor.

Compact rule:

> An accepted transition that destroys a currently required authority/status resolves before accepted actions that depend on that authority/status; those actions must then revalidate against the resulting state.

## Both options preserve

Whichever option is accepted:

- no technical-ID authority;
- no majority/autoelection rule;
- no action rebinding to a successor;
- existing bridge-handoff priority;
- existing provision priority;
- current response/failure taxonomy;
- actor-specific Recognition;
- stable H and role identity;
- central revalidation/commit architecture.

## Not decided here

This decision does not define:

- general contested succession;
- multiple simultaneous claimants;
- resignation while remaining participant;
- generic sovereignty;
- checkpoint/restore ordering;
- general transaction isolation.

It is only the bounded v0 precedence needed when authority destruction and authority use coexist in one resolution cycle.

## Master Architect assessment

Both A and B are implementable within the accepted architecture.

The current accepted source set does not uniquely entail either one.

Therefore selecting A or B is a genuine social-semantic choice for the Project Director, not engineering discretion.

After explicit approval, the Master Architect must promote the chosen rule losslessly into:

- accepted SPEC temporal/revalidation semantics;
- relevant canonical verification cards;
- LATER-04 ledger status;
- Slice-4 acceptance/applicability authority.

Only then may Slice-4 acceptance freeze proceed.
