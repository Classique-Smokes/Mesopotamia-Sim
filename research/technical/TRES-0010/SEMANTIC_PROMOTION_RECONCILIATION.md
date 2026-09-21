# TRES-0010 — Semantic Promotion Reconciliation

**Status:** PROMOTION CONTROL / SUPPORTING RECORD  
**Date:** 2026-09-21  
**Authority event:** Project Director approved the B2 semantic decision package and instructed the Master Architect to perform a lossless promotion.  
**Scope:** D1–D5 only. This record does not promote the B2 assurance mechanism, IMP-0001 repairs, later-slice gaps, or Master Architect rulebook changes.

## 1. Promotion rule

Every approved operative commitment below must be:

- preserved in accepted semantic authority;
- mirrored into assumptions only when it is explicitly a replaceable v0 laboratory assumption;
- reflected in canonical verification;
- not broadened into adjacent mechanics.

No B2 explanatory option, rejected alternative, or implementation suggestion becomes authority merely because it appeared in research.

## 2. Approved commitment inventory

### PR-D1 — Same-cycle direct attitude composition

Binding commitments:

1. Scope is the fixed §3.1 attitude consequences directly triggered by the current cycle's committed interaction, failure, or debt-social-due-review outcomes.
2. For one directed attitude, use the value after maintenance/decay and before those automatic direct attitude consequences as the base.
3. Every distinct currently due direct cause contributes its signed fixed delta exactly once.
4. Sum all such deltas and clamp once to [-100,+100]; do not clamp contribution-by-contribution.
5. Maintenance decay is outside this composition batch.
6. Every contributing cause key and signed delta remains explicit causal history.
7. Enumeration/order among independent member causes has no semantic effect.
8. Cause-key idempotence applies to contribution membership.
9. The batch is one authoritative attitude-state transition; ReactionIndex orders that transition relative to other consequential transitions, not the independent member causes among themselves.
10. Future attitude consequences causally downstream of another automatic reaction are not silently folded into this batch; their causal placement must be specified when introduced.

Targets:
- SPEC §§3.1, 9.3, 10
- ASM-0002
- VS-SFL-097, VS-SFL-074/075
- cross-cutting invariants/metamorphism

### PR-D2 — Same-cycle Residence conflict

Binding commitments:

1. A person may independently Accept multiple Residence proposals from the common snapshot.
2. Accept responses remain true history and are not rewritten as refusal.
3. At most one Residence transition for a given person may commit in one cycle.
4. After ordinary precommit revalidation, multiple valid accepted effects that would change the same person's Residence form one conflict set.
5. Existing accepted semantic/domain priority applies if one exists.
6. Otherwise contenders are equal-priority unresolved alternatives and use the already accepted disclosed stable-ID technical fallback.
7. Fallback use is logged.
8. Non-winning accepted contenders terminate as `InvalidatedAtResolution(CompetingResidenceTransition)`.
9. One committed Residence transition does not authorize another Residence transition for that person in the same cycle.
10. Do not add a snapshot-origin precondition or personal-over-response/proposer/destination priority.

Targets:
- SPEC §§3.6, 9.2, 10
- ASM-0007
- VS-SFL-096, VS-SFL-103, VS-SFL-081
- cross-cutting invariants/metamorphism

### PR-D3 — Response-closed called-favour payloads

Binding commitments:

1. A v0 called-favour payload is valid only when the called actor's Fulfil/Refuse choice is the last new voluntary actor choice required for the requested action to reach terminal commit/failure.
2. The holder's voluntary CallFavor initiation uses the holder's ordinary personal initiative when produced by personal agency.
3. Fulfil/Refuse is a response and consumes/grants no called-actor personal initiative.
4. Requested execution occurs inside that response scope and does not separately consume the called actor's personal initiative.
5. Slice 1 called-favour payloads may not open another ResponseDecisionContext or require a third actor's new voluntary choice.
6. They may not create/demand/transfer/cancel another favour, establish marriage/kinship, or require household/role authority.
7. The favour is consumed only when the requested action commits successfully.
8. Successful requested-action commit -> favour consumed and holder->fulfiller +10.
9. Voluntary RefuseCalledFavor -> Declined; favour remains; holder->refuser -20.
10. Unable(reason) -> favour remains; no called-favour +10/-20.
11. InvalidatedAtResolution(reason) -> favour remains; no called-favour +10/-20.
12. A categorically invalid/non-callable payload is rejected before target response, produces no material/social effect, and does not become a §6.7 social failed-attempt outcome.
13. Current Slice-1 action shapes must later be explicitly mapped against the response-closed predicate; implementation may not invent membership.

Targets:
- SPEC §§3.4, 5.1, 6.7, 10
- VS-SFL-094, VS-SFL-102
- cross-cutting invariants/boundaries
- later mechanical applicability table (not semantic promotion)

### PR-D4 — v0 grain-valued parameter domain

Binding commitments:

1. v0 personal grain stock is a nonnegative integer number of v0 grain units.
2. Every action parameter denominated in grain is a strictly positive integer.
3. Zero, negative, and non-integral grain action quantities are categorically invalid before any target response.
4. Invalid terms produce no material/social effect and are not Declined, Unable, or InvalidatedAtResolution.
5. `RepayDebt(amount)` is valid only when 1 <= amount <= remaining debt.
6. Over-repayment is invalid; never clamp it, credit it, or convert it to another transfer meaning.
7. A semantically valid amount may still exceed current material/reserve capacity.
8. If insufficient capacity exists at feasibility/response evaluation -> Unable(reason).
9. If capacity was sufficient when accepted but is lost before commit -> InvalidatedAtResolution(reason).
10. Dowry amount inherits the positive-integer domain when its later slice is implemented; funding/provision remains separate feasibility.
11. Integral granularity is a replaceable v0 lab assumption, not historical metrology.

Targets:
- SPEC §§2.2, 3.3, 5.1, 6.7, 10, known assumptions header
- new ASM-0014
- VS-SFL-091/092 and cross-cutting grain boundaries

### PR-D5 — Atomic explicit benefit-for-favour

Binding commitments:

1. `ExplicitBenefitForFavor` remains semantically distinct from Gift/Help and RelationshipMediatedReciprocalHelp.
2. Its promised material benefit and new favour are one atomic bargain.
3. Existing full ordered-pair favour capacity makes the explicit bargain world-state infeasible before target response.
4. A deliberately submitted otherwise-valid explicit bargain at full capacity yields `Unable(FavourCapacityFull)`; no scored Accept/Decline, no material benefit, no new favour.
5. If capacity is available at response selection, target accepts, but capacity is lost before commit -> `InvalidatedAtResolution(FavourCapacityFull)`; neither material benefit nor favour commits.
6. On successful commit, specified benefit and exactly one new favour commit atomically; history meaning remains ExplicitBenefitForFavor.
7. Never silently degrade a failed explicit bargain into Gift/Help.
8. RelationshipMediatedReciprocalHelp is independently meaningful: its help may commit at full favour capacity if otherwise valid/feasible/accepted, but no second favour is created.
9. Do not invent a new attitude increment for ExplicitBenefitForFavor merely because material transfer code is shared.

Targets:
- SPEC §§3.4–3.5, 5.1, 9.2, 10
- VS-SFL-091/093
- cross-cutting favour-cardinality boundary

## 3. Explicit non-promotions

Do not promote from B2 as semantics:

- generic recursive response/action graphs;
- a permanent named-action CallFavor whitelist;
- secret/hidden test requirements;
- a generalized mutation framework;
- generated-history/shrinking infrastructure;
- generalized multi-party transition infrastructure;
- historical fractional-grain claims;
- any new attitude effect for ExplicitBenefitForFavor;
- any new Residence preference priority;
- any new social meaning for stable-ID fallback.

## 4. Promotion order

1. Update SPEC-SFL-0001 and change history.
2. Update assumptions register (ASM-0002, ASM-0007, add ASM-0014).
3. Update verification families and cross-cutting contract to match promoted semantics.
4. Run a textual lossless reconciliation against PR-D1..PR-D5.
5. Only after semantics are clean may the separate Slice-1 acceptance manifest be authored/frozen.

## 5. Completion check

Promotion is semantically complete only when every numbered commitment PR-D1..PR-D5 is either:

- directly stated in the accepted SPEC;
- intentionally mirrored in the assumptions register where appropriate;
- exercised or guarded by canonical verification;
- and no rejected/non-promoted B2 option appears as accidental authority.
