# TRES-0010-MRR-B — Manifest Semantic-Subordination / Wording-Scope Audit

**Final verdict:** `MANIFEST_WORDING_REPAIR_REQUIRED`

## 1. Return metadata

- **Task ID:** TRES-0010-MRR-B
- **Frozen baseline ref:** `tres-0010-manifest-repair-review-baseline`
- **Frozen baseline SHA:** `8a809a05276571fb15845f012dc7dae1c71380d8`
- **Return branch:** `tres-0010/mrr-semantic-scope`
- **Model/configuration:** GPT-5.6 Sol; project-context reasoning configuration, exact internal effort setting not exposed
- **Tools used:** GitHub repository connector for branch/ref resolution, file reads, baseline comparison, and return-file creation
- **External research:** no
- **Sibling returns read before completion:** no
- **Prior manifest BLOCK report read before completion:** no
- **Canonical files modified:** no

## 2. Authority and review coverage

I treated accepted `SPEC-SFL-0001` as semantic authority, accepted ADRs as architectural authority only where the manifest invokes architectural invariants, canonical verification files as verification design only, and IMP-0001 only as the Slice-1 scope boundary.

Reviewed from the frozen baseline:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- the canonical SFL verification README, lower-level, response, resolution/reaction, determinism, provision, recognition, formation, continuity, head/dual-mode, lineage, no-self-confirmation, and cross-cutting verification files relevant to the manifest rows
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`

The manifest contains 158 AcceptanceId rows: 120 REQUIRED, 32 DEFERRED, 3 N-A, and 3 UNEXERCISED. I checked every REQUIRED row and every DEFERRED/N-A row for wording that could constrain implementation; the UNEXERCISED rows were also scanned for semantic leakage.

## 3. Controlling semantic distinction

The accepted SPEC contains **two distinct two-grain mechanics**, not one generic personal-transfer reserve:

1. **Debt repayment:** `SPEC-SFL-0001 §3.3` says `RepayDebt(amount)` must be within the remaining debt and that repayment must leave the debtor with at least 2 grain. A valid repayment can therefore be `Unable` for debt-specific material infeasibility.
2. **Household provision:** `SPEC-SFL-0001 §8.1` defines provision exposure as `max(0, grain - 2)` and gives a `NeedsGrain` contributor zero provision capacity. `§10` correspondingly says **provision** cannot penetrate the protected reserve.

By contrast, `SPEC-SFL-0001 §9.2` says only commitments whose semantics explicitly authorize/reserve capacity receive material commitment priority, and explicitly says debt/favour do not automatically reserve grain. No accepted SPEC clause imposes a general two-grain floor on ordinary Gift/Help, Loan, ExplicitBenefitForFavor, or RelationshipMediatedReciprocalHelp material transfers. Those actions remain subject to their own terms, ordinary nonnegative-grain accounting, feasibility, and revalidation.

IMP-0001 includes lower-level debt/transfers but explicitly excludes household provision. Therefore Slice 1 may enforce the debt-repayment floor, but it may not promote the household-provision reserve into a generic lower-level transfer rule.

## 4. Suspect manifest rows

| AcceptanceId | Manifest wording | Accepted source clause | Verdict | Consequence if implemented literally | Minimal source-faithful wording repair |
|---|---|---|---|---|---|
| `S1-BND-RESERVE` | Boundary `grain 1 / 2 / 3`; rationale `Debt/transfer reserve` | `SPEC §3.3`: debt repayment must leave debtor >=2. `SPEC §8.1`: household provision exposes `max(0, grain-2)`; `NeedsGrain` exposes 0. `SPEC §10`: protected-reserve invariant is stated for provision. No generic transfer reserve exists. | `MERGES_DISTINCT_SEMANTICS` | A fresh implementer can infer a shared “personal reserve” gate for all lower-level transfers, incorrectly rejecting otherwise valid Gift/Help/Loan/BFF/RMRH material effects or converting them to `Unable`. It also collapses a Slice-1 debt rule with a deferred household-provision rule. | Make the row debt-specific, e.g. **“RepayDebt post-payment 2-grain floor: below / at / above the required remaining debtor grain”** with rationale **“Debt repayment reserve only (§3.3)”**. Leave household provision capacity/reserve under deferred `S1-BND-HOUSEHOLD-PROVISION`. |
| `S1-MUT-13A` | `penetrate protected personal reserve in Slice-1 debt/transfer feasibility` | Same clauses as above. The accepted lower-level protected floor is repayment-specific; the other accepted protected-reserve rule belongs to household provision. | `MERGES_DISTINCT_SEMANTICS` | This wording directly invites a reusable generic `CanTransfer`/feasibility rule requiring every transferor to retain 2 grain. That adds an unaccepted negative precondition and can change response eligibility, failure class, material outcomes, and downstream attitude/favour history. | Restrict the mutant to debt: **“RepayDebt commits while leaving the debtor below the §3.3 two-grain floor.”** Do not label ordinary Slice-1 transfers as reserve-protected. Household-provision reserve mutants remain later-slice verification. |

These are substantive wording defects, not cosmetic terminology differences.

## 5. Challenged wording that is source-faithful

I specifically attempted to disconfirm other likely conflations named in the task packet:

- **`S1-092-RESERVE` — EXACT.** It is explicitly repayment-specific and matches `SPEC §3.3`.
- **`S1-093-BFF-FULL`, `S1-093-BFF-RACE`, `S1-093-RMRH-FULL` — EXACT.** They preserve the accepted distinction between atomic ExplicitBenefitForFavor and independently meaningful relationship-mediated reciprocal help at a full favour slot.
- **`S1-094-NONCALLABLE-MATRIX`, `S1-094-UNABLE`, `S1-094-DECLINE`, `S1-094-INVALIDATED`, `S1-094-SUCCESS` — EXACT.** They preserve pre-response categorical invalidity and keep it distinct from the social failed-attempt taxonomy in `SPEC §§3.4, 5.1, 6.7`.
- **`S1-096-COMPETE` and `S1-103-RESIDENCE` — EXACT.** They preserve multiple true Accept responses while allowing only one same-person Residence commit under central conflict resolution; they do not turn technical fallback into actor preference.
- **`S1-GLOBAL-KNOWLEDGE` — EXACT.** Its qualifier “where accepted semantics require it” is important: it does not convert a categorically invalid pre-response term into participant knowledge or a social failed attempt.
- **`S1-BND-HOUSEHOLD-PROVISION` — EXACT as DEFERRED.** This is the correct place to keep household provision capacity/`NeedsGrain` contributor boundaries outside IMP-0001.
- Stable-ID fallback, derived-state, iteration-order, observer/noninterference, and decision-trace rows remain architectural/verification obligations supported by the accepted SPEC/ADRs; I found no wording in those rows that creates a new social preference or action meaning.

I found no accepted semantic clause conflict requiring escalation.

## 6. Verification-artifact quality note

The canonical verification package consistently declares itself subordinate to the SPEC. The strongest source-faithful anchors are:

- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md / VS-SFL-092`, which scopes the two-grain floor to debt repayment;
- `PROVISION_GROUNDING_FAMILY.md`, which scopes `max(0, grain-2)` and the protected reserve to household provision;
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`, whose material-accounting section states the protected reserve in terms of **provision spend**.

Some resolution-card prose uses shorthand such as “applicable reserve rules” or describes a personal gift ending at grain 2 in a mixed personal/household conflict. That wording must not be promoted into a generic transfer reserve. I do not find an accepted verification clause that can override the SPEC or cure the two manifest rows above.

## 7. Required conclusions

### Would current manifest wording teach a fresh implementer semantics that the SPEC does not contain?

**Yes.** `S1-BND-RESERVE` and `S1-MUT-13A` teach or strongly imply a generic Slice-1 personal-transfer two-grain reserve. The accepted SPEC contains no such general rule.

### Is the defect set limited to manifest/wording repair, or does it require SPEC/Director action?

**Limited to manifest wording/verification clarification.** The accepted SPEC is sufficient and internally distinguishable on this issue. No new Director semantic decision is required.

### Final verdict

`MANIFEST_WORDING_REPAIR_REQUIRED`

The candidate manifest should not be frozen until the two rows above are rewritten so that the debt-repayment floor is debt-specific and household-provision reserve semantics remain explicitly deferred rather than generalized to ordinary lower-level transfers.
