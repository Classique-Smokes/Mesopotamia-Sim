# Slice 1 Retrospective SID — Master Architect Participant-Aliasing Frontier

**Status:** MA WORKING ARTIFACT / WITHHELD FROM PASS-A REVIEWER  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Historical scope:** Slice 1 lower-level social fabric only  
**Historical acceptance ref:** `sfl-v0-slice1-acceptance-v1`  
**Purpose:** sealed Master Architect side of the targeted Slice-1 retrospective SID audit opened after screening. This artifact must not be shown to Pass A before their independent frontier is frozen.

## 1. Audit scope

The retrospective screen did not justify reopening Slice-1 resource/conflict/nested-action semantics generally.

The targeted frontier is:

> **participant-position aliasing / distinct-party admissibility in Slice-1 action and relation meanings**

The question is not whether current code rejects self-targets. Implementation behavior is evidence, not semantic authority.

The audit asks which Slice-1 semantic positions:

- must be distinct by accepted meaning;
- may validly alias;
- are structurally impossible to alias;
- or remain genuinely unclassified in frozen authority.

## 2. Historical authority discipline

Use only Slice-1-era authority and the frozen Slice-1 applicability boundary.

Do not use Slice 2–4 semantics to decide what Slice 1 meant.

Later institutional/self-funding rules are irrelevant to this audit.

## 3. MA candidate frontier

| ID | Slice-1 meaning | Positions | Why alias matters | MA provisional status |
|---|---|---|---|---|
| A01 | Directed attitude | subject = object | Would create self-directed social attitude and make ordinary interaction consequences self-directed. | **UNRESOLVED** — “directed subjective/interpersonal attitude” suggests other-person semantics but no explicit general no-self rule found. |
| A02 | Parent/child kinship | parent = child | Collapses generational relation identity. | **LIKELY STRUCTURALLY IMPOSSIBLE / authority derivation to verify**. |
| A03 | Sibling kinship | sibling endpoint A = B | Turns sibling relation into self-relation. | **LIKELY STRUCTURALLY IMPOSSIBLE / authority derivation to verify**. |
| A04 | OfferGift | giver = recipient | Material transfer becomes same-owner no-op while accepted-gift attitude effect becomes self-directed; independent response disappears. | **UNRESOLVED**. |
| A05 | RequestGiftOrHelp | requester = target/giver | Request becomes self-request; target cognition/response and recipient→giver attitude collapse. | **UNRESOLVED**. |
| A06 | OfferLoan | lender = borrower | Creates self-debt claim, same-owner grain transfer and self-directed loan attitude effect. | **UNRESOLVED**. |
| A07 | RequestLoan | borrower/requester = lender/target | Self-request with self-debt and no independent response. | **UNRESOLVED**. |
| A08 | Debt relation / RepayDebt | creditor = debtor | Self-claim means repayment transfers grain to same owner, reserve semantics and due-cycle attitude consequence become self-directed. | **UNRESOLVED** unless debt meaning itself entails distinct parties. |
| A09 | ExplicitBenefitForFavor | benefactor/proposer = target/beneficiary | Atomic bargain becomes self-bargain; material leg, response and new favour pair collapse. | **UNRESOLVED**. |
| A10 | RelationshipMediatedReciprocalHelp | helper/benefactor = recipient | Help becomes self-transfer; recipient attitude toward benefactor becomes self-attitude; favour creation may become self-claim. | **UNRESOLVED**. |
| A11 | Favour relation | holder = debtor | Creates self-obligation; ordered-pair cardinality and call/refusal/fulfil attitude effects collapse. | **UNRESOLVED**. |
| A12 | CallFavor | holder/caller = called debtor | Self-call removes independent Fulfil/Refuse cognition and can create self-directed +/- attitude effects. | **UNRESOLVED** if self-favour is otherwise possible. |
| A13 | Reciprocal favour cancellation | A = B | “A owes B and B owes A” collapses two ordered pairs into one self-pair; atomic two-claim cancellation meaning changes. | **LIKELY STRUCTURALLY REQUIRES DISTINCT A/B / verify authority**. |
| A14 | Residence move proposal | mover/proposer = named dwelling counterpart | SPEC says moving to **another person's dwelling**, which appears to require distinct people. | **PROHIBITED / DERIVED from explicit wording**, subject to exact historical text. |
| A15 | Residence invite proposal | inviter/dwelling person = invitee | SPEC says inviting **another person** into their dwelling. | **PROHIBITED / DERIVED from explicit wording**. |
| A16 | Direct marriage | groom = bride | Slice-1 v0 assigns groom male and bride female; one person cannot simultaneously occupy both bounded sex roles. | **STRUCTURALLY IMPOSSIBLE** under accepted person sex state. |
| A17 | Generic proposal/response | initiator = target | Self-target destroys independent counterparty response and may affect initiative accounting. | **NOT A SINGLE RULE YET** — must be classified per action meaning, not assumed globally. |
| A18 | Failed-attempt knowledge | initiator = target/direct participant | Same person could receive both proposer/target knowledge roles, changing bounded knowledge/provenance cardinality. | **DEPENDENT ON A04–A15 outcomes**. |
| A19 | CallFavor outer vs inner RepayDebt | outer holder = inner creditor; called debtor = inner debtor | This alias pattern may be naturally valid: the favour holder calls the debtor to repay debt owed to that holder. | **PLAUSIBLY SUPPORTED composition**; must distinguish from prohibited self-counterparty aliasing. |
| A20 | CallFavor outer vs inner action third-party endpoint | outer holder or called actor aliases an inner non-response endpoint | Could be valid depending on requested action while preserving response-closed requirement; should not be swept into one no-self rule. | **POSITION-SPECIFIC classification needed**. |
| A21 | Residence accepted competing effects | proposer/target roles across two proposals alias | Same person can receive/accept multiple Residence proposals and at most one move commits; some cross-proposal aliasing is already intentionally supported. | **SUPPORTED cross-proposal aliasing**, distinct from within-proposal self-target. |
| A22 | Reciprocal favours | holder/debtor positions reverse across two claims | A owes B while B owes A is explicitly supported and shows that position reuse across distinct claims is legitimate even if within-claim self-pair may not be. | **SUPPORTED cross-claim aliasing**. |

## 4. Key structural distinction

The current implementation's broad `actor != target` validation may be correct for many action meanings.

But SID requires authority to distinguish three different reasons:

1. **semantic distinctness** — the meaning itself requires another person;
2. **structural impossibility** — type/cardinality makes alias impossible;
3. **implementation convenience/generalization** — code applies a broad check not independently established for every meaning.

The audit must not promote a single global no-self rule merely because many individual meanings happen to require distinct actors.

Likewise, valid cross-action/cross-claim aliases (A19/A21/A22) must not be accidentally prohibited by a broad “all roles distinct” conclusion.

## 5. Old-world consequences to inspect

If any within-action self-alias were valid, it could change:

- whether a ResponseDecisionContext exists;
- whether one personal initiative can initiate and respond;
- whether a material transfer has two resource owners or becomes a no-op;
- whether debt/favour ordered-pair identity remains meaningful;
- whether fixed attitude effects become self-directed;
- whether failed-attempt knowledge has one or two participant roles;
- whether causal history/provenance records a social interaction or degenerate self-event.

These are why omission from acceptance authority is consequential even when code consistently rejects the cases.

## 6. MA provisional audit state

- targeted SID trigger: **FIRED**
- historical frontier: **participant-position aliasing / distinct-party admissibility only**
- MA frontier: **DRAFT COMPLETE**
- Pass A: **NOT YET RETURNED**
- semantic dispositions: **NOT FINAL**
- frozen Slice-1 acceptance authority: **UNCHANGED**
- verified Slice-1 implementation: **UNCHANGED**

## 7. Independence requirement

Do not merge this artifact to `main` or expose it to the Pass-A reviewer before their report is durably frozen.

After Pass A freeze:

1. compare reviewer-only / MA-only / overlap;
2. form justified union;
3. run Pass B concrete-history challenge;
4. only then make authority-bearing dispositions.
