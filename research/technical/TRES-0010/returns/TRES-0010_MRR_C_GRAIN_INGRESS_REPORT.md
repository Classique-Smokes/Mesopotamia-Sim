# TRES-0010-MRR-C — Slice-1 Grain-Ingress Exhaustiveness Audit

## Return metadata

- **Task ID:** TRES-0010-MRR-C
- **Frozen baseline ref:** `tres-0010-manifest-repair-review-baseline`
- **Frozen baseline SHA:** `8a809a05276571fb15845f012dc7dae1c71380d8`
- **Return branch:** `tres-0010/mrr-grain-ingress`
- **Model/configuration:** GPT-5.6 Sol; no additional model configuration was exposed
- **Tools used:** GitHub repository/branch search, ref comparison, and frozen-ref file reads; GitHub contents write for this return only
- **External research:** no
- **Sibling returns read before completion:** no
- **Prior manifest BLOCK report read before completion:** no
- **Canonical files modified:** no

## 1. Executive result

The current Slice-1 manifest does **not** close the D4 grain-ingress surface.

There is a source-supported core set of distinct grain-denominated ingresses that cannot safely be represented by one generic, unenumerated `S1-BND-GRAIN-ACTION` obligation:

1. `OfferGift(..., grainAmount)`;
2. `RequestGiftOrHelp(..., grainAmount)`;
3. `OfferLoan(..., grainAmount)`;
4. `RequestLoan(..., grainAmount)`;
5. direct `RepayDebt(..., amount)`;
6. `ProposeMarriage(..., proposedDowry)` even on the direct mutual-strong-like bypass;
7. `CallFavor(..., RepayDebt(..., amount))` as a distinct nested ingress.

Two additional Slice-1 meanings — `OfferBenefitForFavor` and relationship-mediated reciprocal help — are **not uniquely classifiable from accepted semantic authority as having their own grain-denominated actor-supplied parameter**. The accepted SPEC says “specified material benefit” / “help”; the verification family exercises 1-grain examples, but the program source hierarchy forbids turning verification examples into new social/action schema. IMP-0001 also names the meanings without fixing those parameter schemas. Under the task stop rule, this ambiguity must be surfaced rather than resolved by assumption.

The manifest therefore needs repair both because its currently generic D4 row can silently omit a real ingress and because accepted authority must settle the BFF/RMRH parameter-shape question before those meanings can be included or excluded from the grain-ingress matrix with confidence.

**Final verdict: `GRAIN_INGRESS_REPAIR_REQUIRED`.**

---

## 2. Authority and derivation rules used

Controlling sources, in order:

1. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` — accepted semantics;
2. canonical verification artifacts — verification obligations/configuration, not semantic invention;
3. `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` — Slice-1 scope;
4. `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` — candidate under review;
5. `research/technical/TRES-0010/CALLFAVOR_SLICE1_APPLICABILITY_RECONCILIATION.md` — mechanical supporting derivation.

The central semantic rule is SPEC §2.2:

- every action parameter denominated in grain is a strictly positive integer;
- zero, negative, and non-integral grain action quantities are categorically invalid;
- such invalid terms are rejected before any counterparty response is activated;
- invalid grain terms create no material/social effect and are not `Declined`, `Unable`, or `InvalidatedAtResolution`.

SPEC §5.1 separately makes categorical proposal-term validity precede response activation.

This review does **not** infer a grain parameter merely because a verification card happens to use 1 grain.

---

## 3. Exhaustive Slice-1 action/proposal inventory

The inventory starts from IMP-0001 §3.5 and the SPEC §5.1 required-action list.

| Slice-1 meaning | Grain relationship | D4 ingress classification | Source reasoning |
|---|---|---|---|
| `Farm` | Fixed semantic grain effect: +4 | **N-A as grain-parameter ingress** | SPEC §2.2 fixes the yield. There is no actor-supplied grain quantity to validate. |
| `OfferGift` | Current Slice-1 executable gift is a grain transfer with an amount term | **REQUIRED executable ingress** | SPEC §3.5 defines Gift as an explicit transfer meaning inside the v0 grain material substrate. LOWER_LEVEL §VS-SFL-091 and SCORE-VP-002 exercise the current Slice-1 grain-bearing offer shape. |
| `RequestGiftOrHelp` | Current Slice-1 executable help request carries a grain quantity | **REQUIRED executable ingress** | LOWER_LEVEL §VS-SFL-091 and RESPONSE §VS-SFL-100/103 exercise a 1-grain request/help shape; SPEC §2.2 controls any grain-denominated term of that action. |
| `OfferLoan` | Loan amount creates a quantitative grain debt claim | **REQUIRED executable ingress** | SPEC §3.3: Debt is a quantitative grain claim; LOWER_LEVEL §VS-SFL-091 exercises `OfferLoan(1)`. |
| `RequestLoan` | Loan amount creates a quantitative grain debt claim | **REQUIRED executable ingress** | SPEC §3.3 plus LOWER_LEVEL §VS-SFL-091 request-loan route. Offer and Request are distinct proposal ingresses even when they converge on the same successful Loan effect. |
| `RepayDebt(amount)` | Explicit grain-denominated amount | **REQUIRED executable ingress** | SPEC §3.3 explicitly defines the amount and adds `1 <= amount <= remaining debt`; LOWER_LEVEL §VS-SFL-092 freezes zero/negative/non-integral/over-remaining treatment. |
| `OfferBenefitForFavor` | “Specified material benefit”; 1-grain verification instance exists | **AMBIGUOUS — do not invent parameter schema** | SPEC §3.5 does not uniquely state that the actor-supplied benefit parameter itself is a grain quantity. LOWER_LEVEL §VS-SFL-091’s 1-grain comparison is verification design, not semantic promotion. IMP-0001 names the meaning but not the parameter schema. |
| Relationship-mediated reciprocal help | “Help” may produce material benefit; 1-grain verification instance exists | **AMBIGUOUS — do not invent parameter schema** | Same authority problem as BFF. SPEC §3.5 preserves the meaning but does not uniquely type an actor-supplied grain quantity. |
| `CallFavor(Farm)` | Payload has fixed +4 Farm effect, no grain amount parameter | **N-A as grain-parameter ingress** | CALLFAVOR reconciliation §§3–4: Farm is callable. SPEC §2.2 Farm yield is fixed. |
| `CallFavor(RepayDebt(..., amount))` | Inner callable action carries RepayDebt grain amount | **REQUIRED nested ingress** | CALLFAVOR reconciliation §§3, 5.1, 6: RepayDebt is callable only when its terms already satisfy the positive-integer and amount<=remaining domain. |
| `CallFavor` with other current Slice-1 semantic actions | Some direct actions may themselves be grain-bearing, but those payload shapes are NON-CALLABLE | **N-A as nested D4 ingress; direct ingress remains separately required** | CALLFAVOR reconciliation §§3–4 rejects Gift/Help/Loan/BFF/RMRH/Marriage/Residence/etc. before the called actor response. Their direct action routes are not excused from D4. |
| `FulfilCalledFavor` / `RefuseCalledFavor` | No grain term | **N-A** | Response meanings, not grain-quantity actions. |
| Reciprocal favour cancellation | No grain term | **N-A** | Favour relation operation only. |
| `ProposeMarriage(bride, proposedDowry)` on direct strong-like route | Proposal contains proposed dowry; direct route performs no dowry transfer | **REQUIRED syntax/term validation; dowry effect deferred on this route** | SPEC §4 says every proposal names a proposed dowry. §4.2 establishes dowry as grain-backed provision/expenditure. §4.1 bypasses the dowry effect, not the proposal term or global §2.2 validity rule. |
| Residence move proposal / invite proposal | No grain term | **N-A** | SPEC §3.6 residence semantics have no grain parameter. |
| Residence response meanings | No grain term | **N-A** | Response-only. |

### Inventory conclusion

The exact **uniquely source-closed** D4 ingress set is:

- `OfferGift.grainAmount`
- `RequestGiftOrHelp.grainAmount`
- `OfferLoan.grainAmount`
- `RequestLoan.grainAmount`
- direct `RepayDebt.amount`
- direct-route `ProposeMarriage.proposedDowry`
- inner `CallFavor(RepayDebt.amount)`

BFF and RMRH are unresolved candidate ingresses. They must not be silently added to or silently omitted from a frozen manifest until accepted authority fixes their actual parameter shape.

---

## 4. Grain-parameter matrix and minimum evidence

The same table-driven executable test may service multiple rows, but the manifest/evidence must expose each route as an explicit case key so omission is mechanically visible.

| Ingress | Slice-1 status | Zero | Negative | Representative non-integral | Valid positive integer | Required pre-response / failure-semantic proof |
|---|---|---|---|---|---|---|
| `OfferGift.amount` | REQUIRED executable | reject | reject | reject, or prove structurally unrepresentable at public typed boundary | reaches ordinary Gift feasibility and target Accept/Decline path | invalid term creates no target response and no Declined/Unable/Invalidated/material/social effect |
| `RequestGiftOrHelp.amount` | REQUIRED executable | reject | reject | same | reaches ordinary help-request feasibility and target response | invalid term rejected before requested helper response |
| `OfferLoan.amount` | REQUIRED executable | reject | reject | same | reaches ordinary Loan feasibility and borrower response | invalid term rejected before borrower response; no Debt is created |
| `RequestLoan.amount` | REQUIRED executable | reject | reject | same | reaches ordinary Loan feasibility and lender response | invalid term rejected before lender response; no Debt is created |
| direct `RepayDebt.amount` | REQUIRED executable | reject | reject | same | then apply repayment-specific validity/feasibility | there is no counterparty response to wait for; invalid term must terminate before feasibility/commit and must not become a social failed attempt |
| `ProposeMarriage.proposedDowry` on direct bypass | REQUIRED term validation; household dowry effect deferred | reject | reject | same | continues to ordinary direct-marriage eligibility/response; no dowry transfer on bypass | malformed dowry rejected before bride response even though direct bypass would later perform no dowry expenditure |
| `CallFavor(RepayDebt.amount)` | REQUIRED nested ingress | reject whole call | reject whole call | same | if positive and otherwise term-valid, may reach called actor Fulfil/Refuse response | malformed inner repayment term rejects the outer CallFavor before called-actor response; favour unchanged; no +/- called-favour effect |

### Non-integral typed-boundary evidence

If implementation uses a type that cannot represent fractions, “non-integral rejected” may be satisfied structurally, but only if evidence proves the **public semantic ingress** cannot coerce, truncate, round, or otherwise construct a fractional grain quantity before the typed boundary. A production validator cannot serve as the independent oracle for its own correctness.

### Repayment-specific companion boundary

For both direct `RepayDebt` and nested `CallFavor(RepayDebt(...))`, positive-integer D4 validity is not the complete term-validity story. SPEC §3.3 also makes `amount > remaining debt` categorically invalid. At minimum:

- `remaining - 1` (where remaining > 1): term-valid;
- `remaining`: term-valid;
- `remaining + 1`: term-invalid, no clamp/credit/meaning conversion.

For the nested route, `remaining + 1` must reject the CallFavor before the called actor's Fulfil/Refuse response.

### No generic reserve inference

This D4 matrix does not invent a generic “transfer reserve.” The explicit 2-grain leave-behind rule belongs to RepayDebt in SPEC §3.3. Grain-domain validity must remain separate from later action-specific feasibility.

---

## 5. Proposed dowry on the direct bypass — explicit verdict

**Verdict: malformed proposed dowry must be rejected even when the mutual-strong-like direct bypass applies.**

Source chain:

1. SPEC §4 defines one marriage proposal shape before the route split: groom initiates and the proposal names the bride **and proposed dowry**.
2. SPEC §4.2 establishes what that dowry means materially: household provision capacity must cover it and the dowry transfers to the groom. That establishes the proposed dowry as a grain-denominated term in the v0 material system.
3. SPEC §2.2 globally requires every grain-denominated action parameter to be a strictly positive integer and makes malformed grain quantities categorically invalid terms.
4. SPEC §5.1 requires categorical proposal-term validity before response activation.
5. SPEC §4.1 says the direct route “bypasses” household mediation, dowry, and groom->head favour. That removes the **dowry transfer/effect** from the direct route. It does not say that the proposal ceases to carry its proposed-dowry term, nor does it create an exception to §2.2/§5.1.

Therefore:

- `ProposeMarriage(B, dowry=0)`, negative dowry, and non-integral dowry are invalid before B's marriage response even if both stored attitudes are >= +75.
- A valid positive dowry term may continue through the direct-route gates.
- On direct bypass commit, no dowry grain transfer occurs.
- No household/provision implementation is required merely to test this term-validity rule.

The current manifest’s `S1-095-*` rows do not freeze this validation obligation.

---

## 6. Exact treatment of `CallFavor(RepayDebt(...))`

`CallFavor(RepayDebt(...))` is a **distinct required D4 ingress**, not merely duplicate coverage of direct RepayDebt.

The supporting reconciliation says RepayDebt is CALLABLE because creditor acceptance is not required, but its terms must already satisfy:

- positive integer grain amount; and
- `amount <= remaining debt`.

Required behavior:

1. validate the inner RepayDebt term before activating the called actor's `FulfilCalledFavor | RefuseCalledFavor` response;
2. if amount is 0, negative, non-integral, or over remaining debt:
   - reject the CallFavor term categorically;
   - do not activate the called actor response;
   - do not consume the favour;
   - create no repayment, grain movement, repayment attitude effect, or called-favour +/- attitude effect;
   - do not label the result Declined/Unable/Invalidated;
3. if the amount is term-valid:
   - ordinary CallFavor callable-payload processing may proceed;
   - ordinary RepayDebt world feasibility still applies;
   - reserve/material infeasibility may yield `Unable(reason)` before voluntary fulfil/refusal scoring where applicable;
   - later loss of an action-relevant precondition may yield `InvalidatedAtResolution(reason)`;
   - only successful requested-action commit consumes the favour.

Why separate evidence is necessary: a codebase can correctly validate the direct RepayDebt constructor/path while a payload wrapper, deserializer, copied DTO, or CallFavor-specific constructor admits malformed inner amounts. One direct test cannot prove the nested ingress closed.

The current `S1-094-REPAY-CALLABLE` row proves the positive callable case when terms are valid; it does not itself force zero/negative/non-integral/over-remaining invalid-inner-term coverage.

---

## 7. BFF and relationship-mediated reciprocal help ambiguity

### OfferBenefitForFavor

Accepted SPEC §3.5 establishes:

- an explicit benefit-for-favour bargain;
- a “specified material benefit”;
- atomic commit with exactly one new favour;
- capacity-full failure behavior.

It does **not** uniquely state that the action’s actor-supplied benefit term is a scalar grain amount. LOWER_LEVEL §VS-SFL-091 begins with “otherwise comparable 1-grain transfers,” but that is a verification instance. Program authority says verification design cannot create social semantics.

### Relationship-mediated reciprocal help

Accepted SPEC §3.5 establishes qualifying accepted help and favour-creation conditions, including the full-slot distinction. It likewise does not uniquely freeze a grain-quantity parameter schema for the action meaning.

### Required handling

Do not:

- assume BFF/RMRH have a grain amount parameter because VS-SFL-091 uses 1-grain examples;
- assume they do not have one merely because the SPEC omits a concrete signature;
- let IMP-0001 production code make this semantic choice.

Before the corrected manifest is frozen, accepted semantic/schema authority must make the current Slice-1 parameter shape explicit. Then:

- if a BFF/RMRH action parameter is grain-denominated, it joins D4 and needs the same per-ingress invalid-term matrix;
- if the action schema contains no grain-denominated actor-supplied parameter, D4 is N-A for that meaning, even if its successful effect can involve a grain transfer selected through another already-valid semantic object.

This ambiguity independently prevents declaring the ingress surface fully closed.

---

## 8. Current manifest audit

### 8.1 Source-supported ingresses the manifest fails to freeze explicitly

The candidate manifest has:

- `S1-092-AMOUNT-VALIDITY` for direct RepayDebt;
- generic `S1-BND-GRAIN-ACTION` for negative / 0 / 1 / non-integral “grain action amount”;
- `S1-BND-REPAY-AMOUNT`;
- generic mutant `S1-MUT-33`;
- `S1-094-REPAY-CALLABLE` for valid called-favour repayment;
- D4 companion bundle tying those generic rows together.

That structure does **not** freeze the exact ingress membership.

At minimum it leaves the following omission risks:

- OfferGift vs RequestGiftOrHelp can be collapsed into one route and the other silently untested;
- OfferLoan vs RequestLoan can be collapsed into one route and the other silently untested;
- the direct-marriage proposed-dowry term can be omitted entirely;
- nested `CallFavor(RepayDebt(...))` invalid inner terms can be omitted while the positive callable row still passes;
- a table-driven D4 test can accidentally drop one route and still satisfy a generic row label unless the expected route key set is itself frozen.

### 8.2 Ingresses appearing in the manifest that are not source-supported

No **explicitly named** grain ingress in the current manifest is contradicted by source authority.

The overreach risk is latent: the generic `S1-BND-GRAIN-ACTION` row must not be interpreted as authority to give BFF or RMRH a grain parameter solely because their verification examples use 1 grain.

### 8.3 Manifest wording that should remain subordinate

The manifest should not convert the D4 test design into a permanent claim that every beneficial/social transfer meaning has the same amount schema. It must name the current source-supported ingress routes and preserve BFF/RMRH ambiguity until semantic authority resolves it.

---

## 9. Recommended manifest row structure

**Recommendation: separate stable AcceptanceIds per ingress, with permission for one shared table-driven executable test.**

Suggested structure:

- `S1-D4-GRAIN-GIFT-OFFER`
- `S1-D4-GRAIN-GIFT-REQUEST`
- `S1-D4-GRAIN-LOAN-OFFER`
- `S1-D4-GRAIN-LOAN-REQUEST`
- `S1-D4-GRAIN-REPAY-DIRECT`
- `S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT`
- `S1-D4-GRAIN-CALLFAVOR-REPAY-INNER`

Keep `S1-BND-REPAY-AMOUNT` (or a renamed companion row) for the repayment-specific `<= remaining` boundary, and require it for both direct and called-favour repayment ingresses.

Do **not** add BFF/RMRH D4 IDs until accepted authority resolves whether those meanings expose a grain-denominated parameter. Once resolved, add explicit stable IDs if applicable; otherwise record a source-grounded N-A rationale.

### Why separate IDs are preferable here

A single row with a frozen per-ingress matrix could be made adequate, but separate stable IDs fit the manifest’s own completion rule better:

- every REQUIRED `AcceptanceId` must report executed/pass/fail/skip;
- omission of one Offer/Request variant becomes a missing REQUIRED row rather than an invisible missing table case;
- direct vs nested RepayDebt cannot be conflated;
- dowry term validity cannot disappear behind the direct-marriage positive-route card;
- one executable parameterized test may still populate evidence for all IDs, so separate manifest identity does not require duplicated test code.

If the Master Architect prefers a single row, it must include an immutable **exact expected ingress-key set** and completion evidence must fail on missing or extra keys. A generic prose label such as “all grain action amounts” is not sufficient.

---

## 10. Minimum acceptance evidence contract for each stable ingress row

Each required ingress row should require evidence for:

1. zero rejected;
2. negative rejected;
3. one representative non-integral rejected, **or** structural proof that the public semantic boundary makes such a value unrepresentable without coercion/truncation;
4. valid positive integer reaches ordinary action-specific gates rather than being rejected by the D4 gate;
5. invalid term produces no material/social effect;
6. invalid term is not reported as `Declined`, `Unable`, or `InvalidatedAtResolution`;
7. where a target response exists, invalid term is rejected before that response context activates;
8. an independent oracle/expected-case table does not call production validation/classification code under judgment.

For proposal routes, response-trace absence is useful direct evidence of pre-response rejection. For direct RepayDebt, where no counterparty response is required, evidence must instead show termination before ordinary feasibility/commit and absence of social failed-attempt semantics.

---

## 11. Final verdict

**`GRAIN_INGRESS_REPAIR_REQUIRED`**

Reasons:

1. the candidate manifest does not freeze an exhaustive per-ingress D4 set;
2. direct marriage proposed-dowry validity is source-required but absent from the direct-marriage/D4 manifest rows;
3. `CallFavor(RepayDebt(...))` needs distinct malformed-inner-term coverage;
4. Offer vs Request variants for Gift/Help and Loan need explicit, omission-proof coverage;
5. BFF/RMRH grain-parameter status is not uniquely derivable from accepted sources and must be resolved by accepted authority rather than by implementation or verification inference.
