# SFL v0 Slice 4 — Fresh Independent Inherited Verification Adaptation v2 Review

**Review role:** independent assurance reviewer  
**Review date:** 2026-09-24  
**Authority:** advisory verdict only; no candidate plan, frozen manifest, accepted semantic authority, canonical verification, test source, or production source was edited

## Exact review target

- candidate ref: `sfl-v0-slice4-inherited-verification-adaptation-v2-candidate1`
- candidate commit: `4f12c30b0f16531fd1e82ac08c2b71e53934ba28`
- plan: `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_PLAN.md`
- plan blob: `43e27cb6fed1086ffcc687002f7fffd494b528b5`
- plan version: `SFL-V0-S4-INHERITED-ADAPTATION-v2-candidate1`
- controlling frozen successor manifest: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`
- frozen successor blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`
- frozen successor freeze commit: `66fe54c385f42eeb01308f19b63fff7c670b9bbe`

# Verdict

**BLOCK — LOSSLESSNESS / ENFORCEMENT DEFECT**

The reassessed candidate is semantically aligned with accepted Slice-4 authority and correctly repairs the stale pre-DEC-0013 commitment-provenance model. The four known inherited literal breakpoints are real, and an independent census of the current acceptance-test surface did not establish a fifth breakpoint that accepted Slice 4 must necessarily invalidate.

One implementation-handoff defect remains in **Adaptation B / Required negative challenge**.

The review task requires a negative/fault control that demonstrably fails on hidden **current-head / funding / dependency authority**. Candidate v2 instead mandates only:

> “at least one intentionally introduced hidden behavior-affecting field/cache or equivalent mutation”

and then says only that a critical-seam mutation **may** target hidden current-head state, hidden funding participation, stale capacity, or an independent dependency cache.

That wording permits a future implementation to satisfy the plan with a generic hidden-field mutant unrelated to the new current-head/funding/dependency authority seam. The positive structural requirements are strong, but when exact private-field inventory enforcement is adapted or replaced, the required mutant is the proof that the replacement detector actually catches the new authority class rather than merely documenting it.

This is an enforcement-strength defect, not a semantic escalation.

## Smallest exact repair

Do not change accepted semantics or frozen manifests. Tighten only Adaptation B’s required negative challenge so that:

- at least one required fault/mutant causes behavior to depend on a hidden or stale **current-head authority, authoritative funding-resolution state, or material-dependency participation state/cache**; and
- the adapted structural evidence must fail under that mutant;
- a generic unrelated hidden-field mutant alone is not sufficient.

After that narrow repair, a fresh exact-candidate review is still required.

## 1. Source and identity audit

The review independently retrieved the required authority and implementation surfaces from exact candidate commit `4f12c30b0f16531fd1e82ac08c2b71e53934ba28`.

Key identity checks passed:

- candidate plan blob is exactly `43e27cb6fed1086ffcc687002f7fffd494b528b5`;
- frozen Slice-4 v2 manifest blob is exactly `b0bc79e46f82630ab78cd2f0d0414b748212a411`;
- `SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md` identifies reviewed candidate2, final `PASS — MAY FREEZE UNCHANGED`, 176 unique rows, and zero row changes at freeze;
- frozen Slice-1/2/3 and Slice-4-v1 freeze records retain their immutability rules;
- frozen Slice-3’s freeze record independently preserves the conditional S1-084 structural-adaptation trigger and forbids coder self-authorization of weakening.

Controlling semantic sources reviewed included accepted `SPEC-SFL-0001`, DEC-0010, DEC-0011, DEC-0012 and DEC-0013, plus the canonical provision, head/dual-mode, resolution and cross-cutting verification families.

The historical v1 adaptation candidate/review was not used as current authority or evidence.

## 2. A — Current-witness reality and breakpoint completeness

### Breakpoint 1 — S3-014 literal: CONFIRMED

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs` still performs an assembly-wide type-name census:

- line 143 obtains all simulation assembly type names;
- line 144 asserts no name contains `HeadRole` or `HouseholdDecisionContext`.

Accepted Slice 4 necessarily introduces the persistent role/context concepts, so literal type absence cannot remain the enforcement form.

### Breakpoint 2 — S3-093 / S1-084 exact structural inventory: CONFIRMED

Two inherited structural surfaces remain relevant:

- `tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs` `NoDerivedAuthorityStructuralAudit` compares the exact nonpublic `WorldState` field inventory for S1-084 / S1-META-05;
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdStructuralScenarios.cs` lines 19–24 compares exact nonpublic `WorldState` and `HouseholdState` inventories, including the Slice-3 Household authoritative allowlist.

This is one breakpoint family: exact inventory was the implementation-era enforcement technique for the frozen “no hidden behavior-affecting derived authority” invariant.

### Breakpoint 3 — Slice-3 global no-Household-material-event literal: CONFIRMED

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs` lines 37–38 asserts that every event whose kind starts with `Household` or `Sustaining` has an empty material vector.

Accepted Slice 4 adds bounded Household-originated material effects, so this global literal must be scoped losslessly.

### Breakpoint 4 — Slice-3 fixture-only commitment provenance literal: CONFIRMED

`HouseholdOracle.cs` lines 131–135 iterates every `HouseholdProvisionCommitment` and requires nonempty `commitment.Provenance.Fixture`.

Current production `src/Mesopotamia.Sim/HouseholdState.cs` still defines:

`ProvisionFixtureProvenance(string Fixture, string Producer, string OutputIdentity)`

inside the commitment record, so the stale fixture-only representation is also independently confirmed.

### Fifth-breakpoint challenge: NONE ESTABLISHED

I independently scanned the complete current `tests/Mesopotamia.Sim.AcceptanceTests/*.cs` surface at the exact candidate state for closed reflection inventories, type absence, Household/provision material negatives, commitment provenance assumptions, and comparable literal enforcement.

Additional literals found do not establish another necessary Slice-4 breakpoint:

- `HouseholdEpistemicScenarios.cs` has a scenario-local assertion that its Slice-3 fixture/termination history contains no material meaning containing “Household”. That remains valid because the scenario invokes no accepted Slice-4 Household material action; Slice 4 does not require unrelated historical scenarios to emit material effects.
- the same scenario asserts `Household` has no Grain/Treasury property. Accepted Slice 4 still forbids a Household treasury/pool.
- `MarriageResidenceScenarios.cs` keeps `WorldSnapshot` free of Household properties. Current Household authority already lives in the separate Household partition, and accepted Slice 4 does not require collapsing it into `WorldSnapshot`.
- `InvariantOracle.cs` requires `Unable` / `InvalidatedAtResolution` / `InvalidTerms` events to have empty material. Accepted Slice 4 does not authorize material side effects on those failed outcomes.

No fifth pre-existing inherited literal witness was found that accepted Slice 4 must necessarily invalidate.

**A result: PASS.**

## 3. B — S3-014 losslessness after D5/D6

Candidate Adaptation A preserves the frozen S3-014 claim rather than the obsolete implementation literal.

It requires the adapted formation witness to prove:

- formation alone installs no occupant;
- a persistent role created with H is vacant at formation closure;
- no `HouseholdDecisionContext` or Household initiative arises merely from H existence;
- no head-scoped spend/provision/mediation/succession effect arises without later accepted authority;
- no founder is silently selected by ID/order/wealth/kinship/sex/founder status;
- DEC-0013 D5 self-nomination remains a later explicit multi-capacity act;
- DEC-0013 D6 Inactive-H role fill remains a later lifecycle operation and not a formation side effect.

That matches SPEC `8.4–8.5, frozen S4-170, `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` VS-SFL-060, and DEC-0013 D5/D6.

The plan also requires a fault/mutant proving the adapted formation witness fails if formation silently installs an occupant or generates Household initiative.

**B result: PASS.**

## 4. C — S3-093 / S1-084 structural authority

### Positive structural requirements: PASS

Adaptation B correctly reframes exact field inventory as an enforcement technique rather than a permanent ban on later accepted state.

When triggered, it requires:

- every new behavior-affecting authoritative Slice-4 state to be explicit, typed/inspectable, and structurally audited;
- no current-head, role-eligibility, Recognition, candidate, availability, funding or dependency cache to become undeclared authority;
- derived/cache/index state to be rebuildable/discardable with stale values unable to alter behavior;
- role identity/occupancy not to be inferred from history, container order, derived participant snapshots, or unrelated Person attributes;
- no wildcard “later fields allowed” structural escape;
- equivalent-or-stronger hidden-state detection if exact inventory matching is replaced.

The DEC-0011 / DEC-0013 sharpening correctly treats persisted consent cohort, refusal/cooldown, exact X, selected funding plan, transaction-local residual capacity, authoritative funding resolution, and material dependency participation as behavior-affecting state when they cross phases.

It also explicitly forbids a funding/dependency cache becoming a second source of truth, consistent with frozen S4-146, S4-150 and S4-183..186.

The plan remains representation-neutral: a separate role partition is allowed where semantics permit, and accepted v2 separately requires new role/occupancy/cooldown/commitment authority to be explicit and derived caches to remain nonauthoritative.

### Required fault control: BLOCKING DEFECT

The mandatory fault-control clause is weaker than this review task requires.

Candidate text:

- mandates only one generic hidden behavior-affecting field/cache mutant;
- describes current-head/funding/dependency mutants as merely “useful” possibilities.

Therefore the plan can be followed literally without ever proving that the replacement structural enforcement catches hidden authority at the new role/resource/dependency seam.

This matters because accepted v2 explicitly introduces:

- current-head/role authority state;
- one authoritative live funding-resolution result;
- declared/evaluated material dependency participation;
- derived/non-authoritative `MobilizableCapacity(H)`.

The adaptation’s negative proof must be coupled to that new authority class, not left optional.

**C result: BLOCK.**

## 5. D — Household material-event adaptation

Adaptation C preserves the frozen Slice-3 no-spending meaning while allowing only accepted Slice-4 material meanings.

For historical Slice-3 contexts it retains:

- no Household/participation/continuity/lineage material effect;
- no grain movement from commitment existence;
- derived-only `MobilizableCapacity(H)`;
- no Slice-4 support/dowry material effect;
- no private-X leg where no Slice-4 action exists.

For Slice 4 it permits material change only when:

- the effect is an accepted Household material use;
- required Active-H/current-head/scoped authority is valid;
- the single authoritative funding result supports it;
- debits/effects are exact and nonnegative;
- reserve / `NeedsGrain` rules hold;
- no treasury/hidden pool exists;
- semantic history carries truthful provenance;
- malformed/unrelated `Household*` material events still fail.

The DEC-0011 treatment is also correct: X is a funding leg inside the Household action, not a separate Gift/Help/Loan side event or standing capacity. Typed provenance remains required even when a person’s material rows aggregate their final delta.

Required corruption controls cover arbitrary Household material meanings, missing authority, wrong arithmetic, X-as-personal-transfer, and hidden treasury/pool sources.

**D result: PASS.**

## 6. E — Commitment-provenance adaptation after DEC-0013 D4

Candidate v2 correctly repairs the stale two-way fixture-vs-generic-endogenous model.

The plan requires a closed semantic distinction among:

1. controlled Slice-3 fixture commitment;
2. ordinary Slice-4 endogenous commitment with actual target acceptance/response;
3. current-head self-commitment with separate institutional and private-resource predicates but no P→P response theatre.

The ordinary endogenous path requires target sustaining participation, explicit voluntary target acceptance, causal request → acceptance → creation ordering, rule/config/time provenance, and no grain move merely from commitment creation.

The self-commitment path correctly requires:

- current valid head and sustaining participant;
- explicit institutional request/need predicate;
- separate explicit private-resource authorization;
- preservation of the two semantic capacities even though the PersonId aliases;
- no P→P `ResponseDecisionContext`;
- no extra personal initiative merely to represent the second capacity;
- ordinary eligibility, reconsideration/cooldown, termination and provenance;
- no commitment from office occupancy alone;
- no grain movement on creation.

Corruption controls reject fixture/endogenous cross-labeling, wrong actor/H/head/participant, missing or misordered acceptance, office-only self-commitment, missing private-resource authorization, fabricated self-response, X-as-persistent-commitment, and material movement on commitment creation.

The candidate also forbids a generic “fixture OR anything non-null” escape and leaves exact enum/class/record representation implementation-local.

This matches DEC-0013 D4, SPEC `8.2, VS-SFL-051 and S4-179.

**E result: PASS.**

## 7. F — DEC-0011 private-X separation

The candidate keeps transaction-specific X strictly in transaction funding provenance.

It explicitly forbids:

- creating a persistent `HouseholdProvisionCommitment` from X;
- treating X as standing `MobilizableCapacity(H)`;
- representing X as a separate Gift/Help/Loan/favour-bearing action;
- using X as a generic split-tender/economy architecture;
- losing typed distinction between private and commitment-backed legs.

Cross-cutting constraints preserve the exact X/R funding plan, same-head double-counting protection, exact-term revalidation, nontransfer to successors, and distinct role/private authorization provenance required by frozen S4-188..190.

**F result: PASS.**

## 8. G — Frozen-authority integrity

The candidate authorizes no edits to frozen Slice-1/2/3 manifests or statuses.

It also keeps:

- frozen Slice-4 v1 as immutable historical evidence;
- frozen Slice-4 v2 as current completion authority;
- S3-014/S3-093 historical wording/status unchanged;
- later executable adaptation as an explicit mapping from frozen historical claim to current enforcement form;
- prior completion claims historical rather than retroactively rewritten as if Slice 4 existed earlier.

This matches the relevant freeze records and S4-175/S4-163.

**G result: PASS.**

## 9. H — Representation neutrality

No unsupported production layout is forced.

The candidate allows:

- separate role partition versus `HouseholdState` where semantics permit;
- implementation-local provenance enum/class/record shape;
- multiple enforcement forms for the material-oracle boundary;
- no pre-editing of still-green inherited tests before an actual production trigger fires.

It does not require a generic asset/property/ledger/economy architecture.

The only requirements are semantic: explicit typed/inspectable authority/provenance, nonauthority of derived state, and enforceable causal distinctions.

**H result: PASS.**

## 10. I — Implementation handoff safety

The candidate has the correct STOP/escalation rule for any newly discovered inherited literal witness outside the approved plan and correctly says approval alone does not close the Director implementation block.

However, the current Adaptation B mutant wording is not yet safe as a coding handoff because a compliant implementer could satisfy the mandatory mutation requirement with an unrelated hidden field and leave the critical current-head/funding/dependency detector unproven.

With the smallest repair above, the handoff shape becomes sound:

- frozen Slice-4 v2 acceptance remains controlling;
- only mapped inherited witness changes are pre-authorized;
- every newly discovered witness remains STOP/escalation;
- the structural replacement must prove it catches hidden authority on the newly introduced authority/resource/dependency seam.

**I result: BLOCK pending the exact Adaptation B fault-control tightening.**

## 11. Final disposition

The candidate is close and does **not** require semantic reopening.

The blocker is narrow and purely enforcement-level:

> make the critical current-head/funding/dependency hidden-authority mutant mandatory rather than optional.

No frozen manifest, accepted decision, SPEC text, canonical verification card, or production code should be changed to repair this review.

After the plan is revised and frozen as a new exact candidate, commission a fresh independent review of that exact candidate.
