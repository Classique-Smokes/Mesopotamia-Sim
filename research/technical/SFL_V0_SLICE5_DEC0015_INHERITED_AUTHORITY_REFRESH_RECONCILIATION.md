# SFL v0 Slice 5 — DEC-0015 Inherited-Authority Refresh Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / CANDIDATE2 AUTHORED / FRESH REVIEW REQUIRED  
**Date:** 2026-09-25  
**Prior candidate:** `sfl-v0-slice5-acceptance-v1-candidate1` @ `1dcfdac9a27679496b1484d5bf183a3f77ba9afc`  
**Prior candidate blob:** `97b53dcc6f0e03b7c405b79e6fbc1c885662f8ea`  
**Prior R2 review:** `research/technical/SFL_V0_SLICE5_ACCEPTANCE_PRECODE_REVIEW_CANDIDATE1_R2.md` — **PASS — MAY FREEZE UNCHANGED** at its then-current inherited authority  
**New inherited authority:** `SFL-V0-S1-ACCEPTANCE-v2` / `sfl-v0-slice1-acceptance-v2`  
**Slice-1 v2 freeze commit/blob:** `bf77bb38a8a7bc964159188b7359cb8e9af2b483` / `174ccbae57a64f06bd88de233b11a011b4a2b115`  
**Slice-1 v2 implementation conformance:** CLOSED / PASS; final record `research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`

## 1. Why candidate1 cannot freeze

Candidate1 was correctly reviewed against the authority that existed at the time, but its own retro-SID gate required re-evaluation if that process produced a material inherited semantic/acceptance repair.

That happened:

- DEC-0015 was approved and promoted;
- frozen Slice-1 successor v2 now has **134 REQUIRED** rows instead of the historical v1 set of 128;
- current implementation is independently verified conformant to v2;
- candidate1 therefore no longer names or expands the complete current inherited authority.

Candidate1 and its reviews remain immutable historical evidence. They are not edited or retroactively reinterpreted.

## 2. Native Slice-5 semantic impact

DEC-0015 adds one new valid current state shape that crosses the checkpoint boundary:

`Attitude(P,P)`.

Existing candidate1 row `S5-010-WORLD-STATE-EXACT` already requires all attitudes to continue exactly, but omission-detectable acceptance should not rely on a reviewer/implementer choosing a diagonal fixture implicitly.

Candidate2 therefore adds exactly one new native REQUIRED row:

`S5-021-DEC0015-DIAGONAL-ATTITUDE-CONTINUATION`

It requires a runtime-produced stable-boundary checkpoint carrying a valid diagonal Attitude through restore and later ordinary evolution, while preventing checkpoint/restore representation from reintroducing generic endpoint inequality.

No new Debt/Favour/self-counterparty semantics are created. Their current DEC-0015 rules are inherited through Slice-1 v2.

## 3. Existing Slice-5 row delta

Candidate1 had 95 Slice-5 status-bearing rows.

Candidate2 has 96:

- **94 candidate1 rows byte-for-byte unchanged**;
- `S5-R00-ALL-PRIOR-REQUIRED` changes only its exact inherited count from **128+46+96+165=435** to **134+46+96+165=441**;
- exactly one new row is added: `S5-021-DEC0015-DIAGONAL-ATTITUDE-CONTINUATION`.

Candidate2 native census:

- **96 unique**
- **82 REQUIRED**
- **12 DEFERRED**
- **2 UNEXERCISED**

No candidate1 REQUIRED row was dropped or weakened.

## 4. Inherited expansion refresh

Candidate2 inherits exact frozen REQUIRED sets:

- Slice 1 v2: **134**
- Slice 2 v1: **46**
- Slice 3 v1: **96**
- Slice 4 v2: **165**
- total: **441**

The Slice-1 v2 set equals the historical v1 REQUIRED set plus exactly six DEC-0015 rows:

- `S1-107-SELF-COUNTERPARTY`
- `S1-107-ATTITUDE-DIAGONAL`
- `S1-107-DEBT-DIAGONAL`
- `S1-107-FAVOUR-DIAGONAL`
- `S1-107-VALID-ALIAS-CONTROLS`
- `S1-107-GENERIC-RELATION-SEAM`

No lower frozen status is reclassified.

## 5. Other Slice-5 semantics remain current

The R2 findings remain useful corroboration, but cannot substitute for a fresh candidate2 review.

No other native Slice-5 acceptance change is currently justified:

- stable-boundary semantics unchanged;
- exact same-version suffix contract unchanged;
- future-causal completeness classes unchanged except for the now-explicit diagonal Attitude shape;
- ID/frontier/timing/provenance obligations unchanged;
- derived/cache nonauthority unchanged;
- conditional inherited-verification adaptation gate unchanged;
- fixture/oracle independence unchanged;
- deliberate deferrals unchanged.

No new Director semantic decision is required.

## 6. Gate consequence

Candidate2 requires a fresh independent **whole-candidate** review.

Do not freeze or commission Slice-5 coding until:

1. candidate2 whole-candidate review returns **PASS — MAY FREEZE UNCHANGED**;
2. candidate2 is frozen at exact reviewed identity;
3. the conditional inherited-verification adaptation gate is evaluated against the actual proposed implementation design.

No Slice-5 coding bārû is authorized by this reconciliation.
