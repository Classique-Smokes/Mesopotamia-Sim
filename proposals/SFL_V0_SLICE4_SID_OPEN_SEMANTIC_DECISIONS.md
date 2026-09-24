# Slice 4 SID Pilot — Open Semantic Decisions

**Status:** DIRECTOR DECISION REQUIRED  
**Date:** 2026-09-24  
**Source:** `research/technical/SFL_V0_SLICE4_SID_PASSB_RECONCILIATION.md`  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Authority:** proposal only until explicit Project Director approval.

## Purpose

The Slice-4 SID pilot is complete through:

- MA frontier;
- independent frozen Pass A;
- frontier union;
- independent Pass B;
- MA authority reconciliation.

Six bounded semantic questions remain genuinely unresolved.

This packet isolates them. They are not implementation discretion.

## D1 — Household provision priority versus RepayDebt

### Question

When a Household material action and an accepted `RepayDebt` attempt compete for the same personal grain, does the accepted Household provision priority apply to repayment?

### Option A — RepayDebt is in the lower personal-material priority class

For this conflict only:

`eligible NeedsGrain Household support > other valid Household provision expenditure > RepayDebt`

Repayment remains a distinct debt action and social meaning; this only classifies material conflict priority.

Consequences:

- debt does not reserve grain;
- Household action may invalidate repayment at resolution;
- if debt remains at its due review, the ordinary one-time due attitude consequence may fire;
- direct and called-favour RepayDebt use the same material priority while retaining their distinct initiative/response provenance.

### Option B — RepayDebt is not covered by Household provision priority

A separate conflict rule would still be needed:

- debt repayment before Household provision; or
- equal-priority semantic conflict/fallback.

This creates a new debt-specific priority/fallback choice.

### Master Architect recommendation

**Approve Option A.**

It is the smallest closure consistent with:

- debt not reserving grain;
- repayment remaining voluntary;
- the existing provision priority's intent to protect eligible Household need/material expenditure from competing personal grain use.

It changes no debt meaning except relative material ordering.

---

## D2 — Same-snapshot bridge entry and succession before the same exit

### Question

A, B, C are current participants. D has an accepted bridge-dependent entry through A. A->B succession has already received the required A/B/C consents. A also has an accepted exit.

Both entry and succession must occur before A's exit, but if D enters first, live revalidation could make D a newly required unanimity participant for the succession.

### Option A — snapshot-bound consent cohort for accepted role transition

When an appointment/succession is validly proposed/accepted from the common committed decision snapshot:

- its required unanimity cohort is the set of current sustaining participants at that decision snapshot;
- every member of that captured cohort must still satisfy action-relevant eligibility/revalidation at commit;
- a person who becomes a sustaining participant later in the same cycle does **not** retroactively join the already-accepted consent cohort;
- a later entrant acquires no head Recognition merely from entering; ordinary information rules still apply.

This makes D entry and succession commute with respect to consent cardinality.

### Option B — live participant set expands the consent cohort

If D's entry commits first, D becomes a required succession acceptor. Without D's prior acceptance, succession invalidates.

This makes entry/succession ordering socially consequential and therefore also requires an explicit ordering between the two protected attempts.

### Option C — explicit succession-before-entry priority

Resolve succession first, then bridge entry, then A exit.

This preserves both accepted effects but adds another narrow resolver priority.

### Master Architect recommendation

**Approve Option A.**

The role transition was socially accepted by the complete constituency that existed at the common decision snapshot. A same-cycle newcomer should not retroactively gain veto power over an already-accepted transition.

This also avoids inventing a new technical/social ordering rule merely to make the actions commute.

---

## D3 — current head as needy Household-support recipient

### Question

May the current head P be the eligible needy sustaining participant who receives H's 1-grain Household support?

### Option A — allowed, with no self-request theatre

- head remains in the ordinary eligible recipient class;
- H's HouseholdDecisionContext may select support to P;
- P as head authorizes the institutional action while P as person is beneficiary;
- funding must come from valid transaction funding under ordinary rules;
- P being `NeedsGrain` means P cannot personally supplement X or expose commitment capacity;
- no P->P support request/response context is created;
- if P is recipient, use the proactive Household-support topology rather than a self-request path;
- support remains Household-originated and cannot become formation/continuity/lineage evidence.

### Option B — prohibit head as recipient

Add explicit distinctness between current head/authorizer and support recipient.

### Master Architect recommendation

**Approve Option A.**

Office authority does not erase the office-holder's ordinary eligibility as a needy sustaining participant. The conflict is solved by preserving separate institutional-authority and beneficiary capacities, not by inventing an exclusion.

The no-self-request rule avoids fake cognition while keeping the ordinary social affordance.

---

## D4 — current head creating/reconsidering their own persistent provision commitment

### Question

May head P, when P is a non-contributing sustaining participant, voluntarily create a persistent `HouseholdProvisionCommitment(P -> H)` while carrying the head role?

### Option A — allowed as explicit direct dual-capacity consent

- H/head authority identifies the institutional request/need;
- P separately authorizes their own private property to become persistently conditionally accessible;
- no P->P request/ResponseDecisionContext is created;
- no second personal initiative is consumed;
- the result is an ordinary persistent provision commitment, unlike transaction-specific X;
- reconsideration/cooldown applies to this commitment history in the same way after a prior refusal/termination where relevant;
- office occupancy alone never creates the commitment.

### Option B — prohibit self-acquisition while head

P may retain a commitment created before becoming head and may use transaction-specific X, but cannot newly create/reconsider a persistent commitment while occupying the office.

### Master Architect recommendation

**Approve Option A.**

A standing self-commitment is a plausible distinct social act from DEC-0011's one-transaction supplement. Prohibiting it solely because requester and private owner are one person would reproduce the same categorical separation error that motivated the SID policy.

The explicit personal-property consent must remain visible.

---

## D5 — self-nomination for Household head

### Question

May a current sustaining participant nominate themself for a vacant head role?

### Option A — allow self-nomination with collapsed self-consent

A self-nomination event explicitly carries:

1. nomination;
2. nominee willingness/acceptance;
3. that same person's own participant acceptance of the appointment.

Other current sustaining participants must still separately accept/recognize the appointment.

No self-directed nomination response context is opened.

For nomination of another person, nomination does not replace the nominator's separate participant acceptance.

### Option B — allow self-nomination but require separate technical/semantic self-responses

The same person nominates themself and then separately responds as nominee and participant.

### Option C — prohibit self-nomination

Require nominator != nominee.

### Master Architect recommendation

**Approve Option A.**

Self-nomination is socially ordinary enough that an implicit inequality would be artificial. The semantic positions are preserved while redundant self-negotiation is collapsed into one explicit multi-capacity act.

---

## D6 — head-role appointment while H is Inactive

### Question

May an Inactive H (exactly one sustaining participant) fill a vacant head role before reactivation?

### Option A — allow inert role appointment while Inactive

- role governance is distinct from Household-mode material/mediation initiative;
- the sole continuity bearer may use the accepted self-nomination semantics from D5 to fill a vacant role;
- unanimity over the current participant set is therefore the sole bearer;
- the role may be occupied while H remains Inactive;
- H still receives **no HouseholdDecisionContext / Household initiative** until H becomes Active;
- reactivation preserves the occupied persistent role;
- nontrivial succession to a different current participant is impossible while Inactive because only one current sustaining participant exists.

### Option B — prohibit appointment while Inactive

A headless Inactive H must first reactivate through participation entry before any head can be appointed.

### Master Architect recommendation

**Approve Option A**, conditional on D5 Option A.

The persistent role already survives Inactive state when occupied. Allowing the sole continuity bearer to fill a vacancy preserves role continuity without granting any Household action power during Inactive status.

This keeps lifecycle capability and role occupancy distinct.

## Already closed by accepted authority

No Director decision is needed for:

- full-private funding with `X=C` and standing `MobilizableCapacity(H)=0`;
- private-X failure privacy: actor gets bounded interaction-relevant failure knowledge, not exact private balance;
- provision-reconsideration cooldown surviving succession;
- nominee belonging to both nominee-consent and unanimity predicates;
- nominator still belonging to the unanimity predicate;
- direct marriage bypass preservation;
- bride=head allowed / groom=head prohibited;
- Household-originated support/private X not becoming organizational evidence.

## Combined recommended package

The Master Architect recommends:

- **D1 A** — RepayDebt in lower personal-material priority class;
- **D2 A** — snapshot-bound consent cohort for already-accepted appointment/succession;
- **D3 A** — head may receive Household support, no self-request theatre;
- **D4 A** — head may explicitly create own persistent provision commitment, no self-response theatre;
- **D5 A** — self-nomination allowed as one explicit multi-capacity consent act;
- **D6 A** — Inactive H may fill vacant role, but office remains inert until Active.

This package follows one consistent principle:

> **When one person occupies several valid semantic capacities, preserve each authority/consent predicate but do not manufacture redundant self-negotiation contexts merely because the capacities were modeled separately.**

It also avoids adding new global ordering rules where a snapshot-bound participant cohort can make accepted transitions commute.

## Consequence of approval

If approved:

1. promote the six bounded semantics into SPEC + canonical verification;
2. update the SID reconciliation;
3. reopen only affected frontier rows;
4. set `Consequential unresolved: 0` if no new conflict appears;
5. revalidate closure freshness;
6. then draft successor Slice-4 acceptance authority.

Frozen Slice-4 acceptance v1 remains immutable historical evidence.
