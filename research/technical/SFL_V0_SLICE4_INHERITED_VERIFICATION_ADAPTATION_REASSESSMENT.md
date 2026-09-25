# Slice 4 — Inherited Verification Adaptation Reassessment after DEC-0011 / DEC-0013 / Acceptance v2

**Status:** COMPLETE / MASTER ARCHITECT REASSESSMENT  
**Date:** 2026-09-24  
**Authority:** verification-planning synthesis only; does not create simulation semantics  
**Frozen successor acceptance:** `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`  
**Frozen manifest:** `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`  
**Frozen manifest blob:** `b0bc79e46f82630ab78cd2f0d0414b748212a411`  
**Freeze record:** `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`  
**Historical adaptation candidate:** `sfl-v0-slice4-inherited-verification-adaptation-v1-candidate1` @ `51981cb0ad993fe4529341f2862f50d90d72ec26`

## 1. Question

Can the pre-DEC-0013 inherited-verification adaptation plan still be reviewed and used unchanged after:

- accepted DEC-0011 transaction-specific current-head private supplementation;
- accepted DEC-0013 D1–D6 SID closure;
- frozen successor Slice-4 acceptance v2;
- the new implementation-facing v0 resource-scaffold guardrails?

## 2. Result

**NO — the old candidate must not be dispatched unchanged.**

The four original inherited literal-witness breakpoints remain the correct breakpoint set, but the old candidate's authorized mapping is stale in one material way and incomplete in several cross-cutting ways.

Most importantly, old Adaptation D assumes that every endogenous `HouseholdProvisionCommitment` is created through a head request to another participant plus that target's response/acceptance chain.

Accepted DEC-0013 D4 now also permits the **current head to explicitly create/reconsider their own persistent v0 provision commitment through direct dual-capacity consent with no P→P response context**.

Therefore an unchanged review of candidate1 would force the reviewer to choose between:

- incorrectly rejecting an accepted D4 self-commitment because it lacks a target-response chain; or
- weakening commitment provenance so far that fixture and endogenous acquisition become insufficiently distinguished.

A reassessed candidate is required.

## 3. Current-witness reality

The existing Slice-3 implementation/test base still contains all four originally identified literal witnesses.

### A. S3-014 headless-boundary literal

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs` still scans the simulation assembly and asserts that no type name contains:

- `HeadRole`;
- `HouseholdDecisionContext`.

This remains a real implementation-era literal that cannot survive accepted Slice-4 role/context types.

### B. S3-093 / S1-084 exact structural inventory

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdStructuralScenarios.cs` still:

- reflects nonpublic `WorldState` fields;
- reflects nonpublic `HouseholdState` fields;
- compares the Household-state inventory against an exact Slice-3 allowlist.

This remains a real trigger if Slice-4 implementation changes those inventories or replaces that enforcement path.

### C. global no-Household-material oracle literal

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs` still asserts that every history event whose kind begins `Household` or `Sustaining` has an empty material vector.

That remains correct for the frozen Slice-3 boundary and incompatible with accepted Slice-4 Household support/dowry effects.

### D. fixture-only commitment provenance literal

The same oracle still requires every observed `HouseholdProvisionCommitment` to carry nonempty `Provenance.Fixture`.

The current production record still stores:

`ProvisionFixtureProvenance(string Fixture, string Producer, string OutputIdentity)`

inside `HouseholdProvisionCommitment`.

That remains correct for current Slice-3 fixture-only acquisition and must be adapted when Slice 4 adds endogenous acquisition.

## 4. No fifth inherited literal breakpoint established

DEC-0011 / DEC-0013 add important Slice-4 obligations, but they do not currently create an additional **pre-existing Slice-1/2/3 literal verification witness** that must be rewritten before Slice-4 code can exist.

The inherited breakpoint set therefore remains:

1. S3-014 assembly/type-absence witness;
2. S3-093 / S1-084 exact structural inventory witness;
3. Slice-3 global no-Household-material-event oracle;
4. Slice-3 fixture-only provision-commitment provenance oracle.

Any newly discovered inherited literal witness during implementation remains a STOP/escalation under S4-174 rather than being silently folded into this plan.

## 5. Required strengthening of the reassessed plan

### A — headless boundary

The original mapping remains sound, but the reassessed plan must explicitly preserve that:

- accepted self-nomination does not imply formation-time self-installation;
- accepted Inactive-H role filling is a later lifecycle operation, not a formation side effect;
- formation alone still creates no occupied head and no Household initiative.

### B — structural authority non-hiding

The original mapping remains sound, but DEC-0011 / DEC-0013 sharpen what counts as behavior-affecting authority.

The adapted structural evidence must cover not only role/occupancy state but also any persisted state whose stale or hidden value could influence:

- captured appointment/succession consent cohort;
- provision refusal/reconsideration history;
- exact private-`X` term or selected funding plan after deliberation;
- commitment-side capacity after accounting for `X`;
- authoritative funding-resolution result;
- material dependency/conflict participation.

A derived dependency set, capacity query, or funding cache may exist only if it remains rebuildable/nonauthoritative and cannot diverge behaviorally from the single authoritative live funding evaluation required by frozen S4-183..186.

### C — material-event oracle

The old historical Slice-3 prohibition remains valid.

For Slice 4 the adaptation must allow material changes only through accepted Household material meanings and must preserve exact funding provenance.

DEC-0011 private `X` is a **funding leg inside one Household action**, not a separate Gift/Help/Loan or generic Household material meaning.

The adapted oracle must therefore be able to distinguish:

- accepted Household support/dowry effect;
- private-`X` funding leg;
- commitment-backed funding legs;
- unrelated/malformed Household material events that must still fail.

No generic `Household*` material exemption is permitted.

### D — commitment provenance

Candidate1's two-way model — fixture versus generic request/response endogenous commitment — is no longer sufficient.

The reassessed plan must require a **closed, representation-neutral provenance union** with at least these semantic shapes:

1. **Slice-3 controlled fixture commitment**
   - explicit fixture/producer/output identity;
   - no fake endogenous acquisition chain.

2. **Slice-4 ordinary endogenous commitment**
   - actual Household/head provision request/need context;
   - current target sustaining participant;
   - target's explicit voluntary acceptance/response;
   - valid H/head/participant authority at the required points;
   - causal order request -> acceptance -> commitment creation.

3. **Slice-4 current-head self-commitment**
   - current head P is also the private resource owner/contributor;
   - explicit institutional Household/head request/need predicate;
   - explicit P private-resource authorization;
   - no P→P ResponseDecisionContext or fabricated self-response;
   - all ordinary eligibility/cooldown/termination/provenance rules remain;
   - office occupancy alone is never sufficient.

The exact data type/class/file layout remains implementation-local.

Transaction-specific private `X` under DEC-0011 is **not** a fourth commitment-acquisition provenance kind because `X` creates no persistent commitment. Adapted verification must reject any implementation/history that misclassifies a one-transaction private supplement as a persistent commitment.

## 6. Resource-seam guardrails are constraints, not new inherited adaptations

Frozen S4-182..190 do not authorize extra inherited-test weakening.

The adaptation plan must remain subordinate to:

- one authoritative live funding-resolution result;
- typed funding/source/authority provenance;
- dependency discovery consuming declared/evaluated material participation rather than reimplementing allocation policy;
- `MobilizableCapacity(H)` remaining rebuildable/non-authoritative;
- resource state not defining Household/role/Recognition identity;
- exact DEC-0011 private-`X` arithmetic/nontransfer/side-effect rules.

If implementation would satisfy an old inherited test only by violating one of those successor requirements, that is not a valid “adaptation”; it is an implementation defect or semantic escalation.

## 7. Representation neutrality

Nothing in the reassessment requires:

- a particular `HeadRole` class/record layout;
- role state to live inside `HouseholdState` rather than a separate partition;
- a particular provenance enum/class hierarchy;
- a generic asset/ledger architecture;
- pre-editing currently green tests before a production change actually fires the literal trigger.

The requirement is semantic: accepted authority and provenance must remain explicit, typed/closed enough to audit, and resistant to hidden behavior-affecting state.

## 8. Decision

Prepare a new adaptation candidate against frozen Slice-4 v2.

The prior candidate/ref remains historical and must not be moved or reviewed as the current forward gate.

The fresh candidate must preserve the original four-breakpoint scope while incorporating the tightened B/C/D constraints above.

Only a fresh independent verdict of:

**PASS — ADAPTATION PLAN APPROVED**

may close the inherited-verification adaptation gate.
