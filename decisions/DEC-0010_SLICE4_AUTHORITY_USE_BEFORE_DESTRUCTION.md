# DEC-0010 — Slice-4 Authority Use Before Authority Destruction

**Status:** ACCEPTED  
**Authority:** Architectural / social-semantic  
**Opened:** 2026-09-24  
**Resolved:** 2026-09-24  
**Accepted by:** Project Director  
**Source proposal:** `../proposals/SFL_V0_SLICE4_LATER_04_AUTHORITY_RACE_DECISION.md`

## Problem / question

Slice 4 makes head/Household authority transitions and authority-dependent actions executable in the same resolution cycle.

The accepted specification already requires immediate precommit revalidation, but before this decision it did not determine semantic precedence when the same committed decision snapshot produced both:

1. an otherwise-valid accepted action or role transition whose commit still depends on current head/Household authority or current institutional status; and
2. an accepted same-cycle transition whose commit would destroy that required authority/status.

Depending on resolution order, the dependent action might commit or be invalidated. Proposal IDs, container order, or generic technical fallback may not invent this social rule.

## Decision

Adopt **authority-use before authority destruction** for bounded SFL v0.

If two accepted same-cycle attempts arise from the same committed snapshot, and one otherwise-valid attempt depends on current head/Household authority or current institutional status that the other accepted transition would destroy, resolve the authority/status-dependent attempt first.

Then resolve the authority/status-destroying transition normally.

This permits a valid **last act in office/status** before departure, vacancy, succession, or operational-status loss.

## Binding semantics

1. The protected earlier attempt must already be semantically valid and accepted from the common committed snapshot.
2. Immediately before its commit, every action-relevant precondition **other than the specifically protected same-cycle authority/status that the destructive transition would remove** still revalidates normally.
3. Existing explicit semantic/domain priorities continue to apply. This rule does not outrank a more specific accepted priority that independently prevents the attempt.
4. After the protected attempt resolves, the authority/status-destroying transition resolves under ordinary rules.
5. A pending old-head action never rebinds to a successor. It either commits under the old valid authority according to this rule or fails for another ordinary precondition.
6. Technical IDs, proposal enumeration, container order, and generic technical fallback do not decide authority validity.
7. Failure elsewhere remains in the existing taxonomy; this decision does not convert inability/invalidation into voluntary refusal.

## Canonical examples

- An accepted valid Household support/dowry/provision action by current head P may resolve before P's accepted participation end vacates the role.
- An accepted valid old-head Household action may resolve before an accepted A→B succession changes the occupant.
- An accepted valid Household action may resolve before accepted same-cycle participation/status transitions that would make H Inactive/Dissolved and thereby destroy the required Household-mode authority.
- A role/authority transition that depends on a person's current institutional status may complete before an accepted same-cycle transition whose commit would remove that exact required status, provided all other preconditions remain valid.

## Explicitly unaffected

This decision does not change:

- the Slice-3 same-cycle continuity bridge-handoff priority;
- provision priority: eligible NeedsGrain support > other valid Household provision expenditure > ordinary personal transfer;
- Residence conflict semantics;
- appointment/succession unanimity or nominee consent;
- actor-specific Recognition / no passive synchronization;
- scoped head authority;
- Household or role identity;
- general contested succession / multiple simultaneous claimants;
- checkpoint/restore ordering;
- general transaction-isolation semantics.

## Rationale

The Project Director explicitly chose the interpretation that a valid current authority may perform its last valid act before the same-cycle transition that removes that authority.

This keeps already-accepted deliberation meaningful without granting persistence of authority after departure: the authority-dependent effect resolves while the authority/status is still valid under this narrow precedence, then the destructive transition takes effect.

The rule remains bounded to same-cycle accepted attempts generated from the same committed snapshot and does not create general office sovereignty.

## Promotion obligations

Promote losslessly into:

- `SPEC-SFL-0001` temporal/revalidation semantics;
- canonical head/dual-mode and resolution verification;
- the TRES-0010 deferred-gap ledger;
- Slice-4 acceptance/applicability authority.

## Approval state

**ACCEPTED by explicit Project Director approval on 2026-09-24: “Let them perform the last valid act before leaving. For sure.”**
