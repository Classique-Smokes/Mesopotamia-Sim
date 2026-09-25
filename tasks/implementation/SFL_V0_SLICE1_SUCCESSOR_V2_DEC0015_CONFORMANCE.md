# Implementation Task Packet — Slice 1 Successor v2 / DEC-0015 Conformance

**Task ID:** SFL-S1-V2-CONFORMANCE-DEC0015  
**Commissioned by:** Master Architect  
**Status:** ARCHITECT-DISPATCHED / IMPLEMENTATION AUTHORIZED FOR THIS BOUNDED REPAIR ONLY  
**Context mode:** CODING-BĀRÛ / PROJECT-CONTEXT — repository authority controls  
**Implementation agent:** Astra  
**Recommended effort:** **MEDIUM**  
**Implementation branch:** `implementation/slice1-v2-dec0015-conformance`  
**Frozen successor authority:** `SFL-V0-S1-ACCEPTANCE-v2`  
**Frozen ref:** `sfl-v0-slice1-acceptance-v2` @ `bf77bb38a8a7bc964159188b7359cb8e9af2b483`  
**Frozen manifest blob:** `174ccbae57a64f06bd88de233b11a011b4a2b115`

## 1. Objective

Bring the current promoted kernel into exact conformance with DEC-0015 and frozen Slice-1 successor acceptance v2, without reopening historical IMP-0001 or changing unrelated Slice-2/3/4 semantics.

The required production delta is expected to be narrow:

1. remove the generic relation-layer endpoint-inequality assumption that currently makes `Attitude(P,P)` invalid;
2. preserve type-specific distinct-endpoint validation for current Kinship, Marriage, Debt and Favour semantics;
3. preserve current bounded self-counterparty rejection before response for DEC-0015 D1 action meanings;
4. add omission-detectable executable/structural evidence for all six new `S1-107-*` rows;
5. rerun/report successor-v2 conformance without weakening any frozen-v1 obligation.

Do not implement Slice 5.

## 2. Controlling authority

Read and obey, in precedence order:

### Accepted semantics / governance

- `decisions/DEC-0015_RELATION_DIAGONAL_ADMISSIBILITY_AND_SELF_ALIAS_SEMANTICS.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md` §1.1
- `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`
- accepted ADRs/decisions already governing the promoted kernel

DEC-0015 controls the new meaning. In particular:

- relation diagonal admissibility is type-specific;
- `Attitude(P,P)` is valid current state;
- diagonal Debt/Favour are not enabled in current v0;
- current D1 self-counterparty proposal forms remain invalid before response;
- valid cross-action/cross-claim aliases remain supported;
- generic relation infrastructure must not impose universal endpoint inequality.

### Frozen completion authority

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST_V2.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_V2_FREEZE_RECORD.md`
- frozen ref/commit/blob above

Every **134 REQUIRED** row is mandatory current successor-conformance authority.

All **33 DEFERRED / 3 N-A / 3 UNEXERCISED** rows remain visibly classified and must not be reinterpreted.

Historical frozen v1 remains immutable:

- ref: `sfl-v0-slice1-acceptance-v1`
- blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`

## 3. Known implementation seam / required repair

Current `src/Mesopotamia.Sim/State.cs` has one shared validation helper:

`CheckPair(PersonId a, PersonId b)`

It currently rejects `a == b` and is called for:

- Attitude;
- Kinship;
- Marriage;
- Debt;
- Favour.

That is no longer semantically valid as a generic relation-layer rule because DEC-0015 allows `Attitude(P,P)`.

Repair the validation structure so endpoint existence and endpoint distinctness are not conflated.

Expected bounded shape, representation-local details left to the implementer:

- Attitude: endpoints must resolve to existing people; equality is allowed.
- Kinship: endpoints must resolve and be distinct.
- Marriage: endpoints must resolve and be distinct, plus existing sex/kinship/cardinality rules.
- Debt: endpoints must resolve and be distinct, plus existing balance rules.
- Favour: endpoints must resolve and be distinct, plus existing cardinality rules.

Do **not** create a global relation-type registry or diagonal-policy engine.

Do **not** add speculative future self-debt/self-favour behavior.

### Action validity

Current `ActionRules.Invalid(...)` already rejects the target-bearing bounded current self-counterparty proposal forms before response.

Preserve the required DEC-0015 D1 behavior.

Do not opportunistically reinterpret self-communication, later-slice aliasing, or other action meanings outside this frozen successor scope. If the repair appears to require choosing an unclassified semantic rule, **STOP / escalate** rather than generalizing.

## 4. Required S1-107 evidence

Implement substantive evidence for all six REQUIRED successor rows.

### S1-107-SELF-COUNTERPARTY

Table-driven boundary coverage for:

- `OfferGift(P -> P)`
- `RequestGiftOrHelp(P -> P)`
- `OfferLoan(P -> P)`
- `RequestLoan(P -> P)`
- explicit benefit-for-favour P -> P
- relationship-mediated reciprocal help P -> P
- `CallFavor` where holder == called actor

For each otherwise-valid term prove:

- `InvalidTerms` / categorical invalidity occurs before counterparty response;
- no response-decision trace for the self-counterparty interaction;
- no material debit/credit;
- no Debt/Favour creation;
- no success/refusal attitude consequence;
- no §6.7 social failed-attempt outcome.

Diagnostic proposal/rejection history may remain if already accepted.

### S1-107-ATTITUDE-DIAGONAL

Use a controlled valid initial `Attitude(P,P)` and prove:

- initialization/state validation accepts it;
- exact `AttitudeOf(P,P)` addressability;
- ordinary [-100,+100] bound behavior;
- positive and negative maintenance/decay toward zero at the ordinary cadence;
- unrelated attitude edges remain independent;
- allowing the diagonal state does not make the D1 self-counterparty proposals valid.

At least one control must fail if a generic relation-layer `a != b` guard is restored.

### S1-107-DEBT-DIAGONAL

Prove current diagonal Debt is semantically unavailable.

Evidence may combine public-boundary creation controls with bounded structural validation evidence, but must establish that:

- no authoritative `Debt(P,P)` becomes live;
- no due review / repayment / attitude / participant-knowledge consequences arise;
- the rejection is Debt-specific, not merely proof of one generic endpoint inequality.

Do not add a public production API merely for test injection.

### S1-107-FAVOUR-DIAGONAL

Equivalent current-v0 rejection evidence for `Favour(P,P)`:

- no authoritative diagonal favour;
- no CallFavor/consume/refuse/attitude consequences;
- type-specific rule rather than generic relation-layer inequality.

### S1-107-VALID-ALIAS-CONTROLS

Re-exercise accepted controls, including at minimum:

- personal initiative + separate incoming response for the same person;
- multiple response contexts / shared scarce material source;
- valid two-party `CallFavor(RepayDebt)` where outer holder is inner debt creditor;
- inherited direct-attitude multi-cause convergence.

The DEC-0015 repair must not create a global all-roles-distinct rule.

### S1-107-GENERIC-RELATION-SEAM

Provide structural + executable evidence that:

- no generic relation substrate/helper imposes universal endpoint inequality;
- Attitude equality is allowed;
- Debt/Favour/Kinship/Marriage distinctness is enforced by their owning semantic validation;
- no global registry/policy engine was introduced;
- relation-diagonal permission does not automatically authorize self-addressed action.

Include a critical mutant or equivalent fault-injection control that would fail if a generic endpoint-inequality guard were reintroduced.

## 5. Existing evidence / regression

The 128 frozen-v1 REQUIRED obligations remain required current evidence.

Do not rewrite the historical IMP-0001 completion record.

For successor conformance:

- rerun canonical root build/test/analyzer commands;
- rerun the current acceptance/conformance suite;
- produce a successor-v2 completion report that maps **all 134 REQUIRED AcceptanceIds** to substantive evidence;
- existing unchanged v1 evidence may be referenced where still valid, but current regression execution must demonstrate the repair did not weaken inherited behavior;
- all deliberate non-REQUIRED statuses remain visible.

Required successor report path:

`research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_CONFORMANCE_REPORT.md`

## 6. Frozen-authority integrity

Do not edit, move, replace, or reclassify:

- `sfl-v0-slice1-acceptance-v1`;
- `sfl-v0-slice1-acceptance-v2`;
- either frozen manifest;
- DEC-0015;
- canonical verification merely to make production pass.

If a required row appears impossible or semantically contradictory, stop and escalate.

## 7. Inherited-verification adaptation gate

This bounded repair is **not currently authorized** to change exact audited authoritative-state field inventories or weaken inherited structural-authority checks.

The expected validation refactor changes behavior of endpoint validation, not authority-field inventory.

If implementation discovers that satisfying DEC-0015 requires:

- changing an exact audited WorldState/HouseholdState authority-field inventory;
- weakening/replacing an inherited structural authority witness;
- creating a new hidden/stale authority seam;
- or altering another protected inherited verification form;

**STOP / escalate before that edit.**

Do not weaken an inherited witness ad hoc.

## 8. Allowed production scope

Expected production scope is narrow:

- `src/Mesopotamia.Sim/State.cs`;
- only additional production files if strictly necessary to implement the same bounded validation semantics.

Expected test/report scope may include:

- acceptance test files under `tests/Mesopotamia.Sim.AcceptanceTests/`;
- verification/fault controls;
- successor conformance report path above.

No Slice-5 persistence/checkpoint code is authorized.

## 9. Required completion state

When implementation is complete:

1. canonical root commands pass;
2. every 134 REQUIRED successor AcceptanceId has reportable substantive evidence;
3. all six S1-107 rows pass their required causal/structural/mutant controls;
4. no frozen authority changed;
5. no unrelated semantic change is introduced;
6. successor conformance report is complete;
7. provide exact implementation head SHA and changed-file list;
8. do **not** merge to `main`.

The Master Architect will then freeze an exact implementation candidate and commission fresh independent successor-conformance review.

## 10. Return / stop conditions

Return **COMPLETE CANDIDATE** only if all required evidence is green.

Return **BLOCKED / ESCALATION** if accepted authority does not determine a required result or if a protected inherited verification adaptation is needed.

Do not self-promote, self-approve, or start Slice-5 implementation.
