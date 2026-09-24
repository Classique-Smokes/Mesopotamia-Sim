# Director Clarification — Office-Holder Voluntary Private Resource Supplementation
## Slice 4 course-correction note

**Status:** Director intent clarification for current Master Architect review and promotion through the project’s normal authority process.  
**Authorship context:** Prepared for the Project Director by the retired former Master Architect. The retired author has no repository or project mutation authority.  
**Purpose:** Explain a missing causal capability discovered before Slice-4 acceptance freeze/coding.

---

## 1. The hole

Current SFL v0 household provision semantics correctly distinguish:

- Household authority;
- personally owned grain;
- `HouseholdProvisionCommitment(Person -> Household)`;
- derived Household mobilizable capacity;
- actual collective expenditure.

A person’s grain remains personal until an authorized collective expenditure commits. Merely being a `SustainingParticipant` or the current head does not expose that person’s grain.

This is correct and should remain true.

However, the current semantics appear to allow Household spending only from **already-existing valid provision commitments**.

That leaves an important human action either absent or unclear:

> A current office-holder authorizes an otherwise-valid institutional action, sees that available institutional backing is insufficient (or chooses personally to bear part of the cost), and voluntarily supplies some of their own privately owned resources to that particular institutional act at the time of action.

Example:

- Household H has an authorized expenditure requiring 3 grain.
- Existing valid Household backing can supply only 2.
- Current head P personally owns enough disposable grain.
- P chooses: **“Use one of mine.”**
- The action should be able to commit using:
  - 2 grain from ordinary institutional backing; and
  - 1 grain voluntarily supplied from P’s personal property.

The present model should not accidentally make that history impossible merely because P did not previously create a persistent provision commitment.

---

## 2. Core Director requirement

The intended semantic capability is:

> **A current office-holder may voluntarily supplement the resources available to an authorized institutional action with privately owned resources under that person’s control at the time of the action.**

This capability must preserve the distinction between the two sources of power:

1. **Office authority** determines whether the institutional action itself is in scope and may be authorized.
2. **Personal ownership/consent** determines whether the office-holder’s private resources may be used.

Holding office alone must **not** expose private resources.

The institution may not seize the holder’s grain.

The holder’s private resource becomes available because the holder personally and voluntarily contributes it.

The same underlying person is simultaneously:

- the cognitive carrier / occupant of the office exercising institutional authority; and
- the private owner consenting to use of personally owned resources.

Those capacities may combine without being collapsed into one authority source.

---

## 3. Two distinct capabilities should remain possible

### A. Persistent personal backing

A person who is or later becomes head may have an ordinary persistent:

`HouseholdProvisionCommitment(P -> H)`

This remains the existing reusable backing relationship.

Appointment/succession should not automatically create it, erase it, or convert it into office property.

### B. Transaction-specific personal supplementation

Separately, the current office-holder must be able to make a **transaction-specific voluntary contribution** from private resources to an otherwise-valid Household action even when no sufficient prior commitment exists.

This contribution:

- is explicit;
- is attributable to the person;
- applies to the relevant institutional transaction;
- does not automatically create a new persistent `HouseholdProvisionCommitment` unless a distinct persistent-commitment action occurs;
- does not imply that the office or Household owns the person’s remaining resources.

The implementation should not force an artificial ceremony such as:

`Head P requests provision from Person P -> P opens a response context -> P accepts P`

merely because the same person occupies both semantic positions.

There is no independent counterparty cognition in that case.

The semantic requirement is voluntary personal consent plus institutional authority, not self-negotiation theatre.

---

## 4. Personal initiative / office initiative

The intended capability should not disappear merely because the office-holder has already used the ordinary personal initiative for the cycle.

A head who has spent their personal initiative should not thereby become incapable of saying:

> “I will cover the missing grain for the Household action I am currently authorizing.”

The cleaner semantic interpretation is that transaction-specific self-backing is part of the authorized Household action’s explicit terms / funding authorization, while preserving the fact that the resource consent is personal.

This does **not** grant an extra generic personal action.

It permits one institutional act to depend on two authority sources carried by the same person:

- role authority for the institutional act;
- personal authority over the contributed resource.

Exact representation is implementation-local only after the semantic distinction is preserved and verifiable.

---

## 5. Grounding and history requirements

A committed action using personal supplementation should remain fully grounded.

The history must be able to distinguish:

- resources mobilized through pre-existing Household provision commitments;
- resources voluntarily supplied transactionally by the current holder from private property;
- the office/Household authority that made the institutional action valid;
- the person whose private property was debited.

A macro-description such as:

> “Household H paid 3 grain.”

must remain reconstructable into the lower-level causal path, for example:

> H acted through HeadRole(P); 2 grain came from previously committed Household backing; P voluntarily supplied 1 additional privately owned grain; the combined funding allowed the authorized effect to commit.

Do not create an unexplained Household treasury or silently convert the holder’s remaining grain into collective property.

---

## 6. Existing personal-resource constraints

This clarification does **not by itself** reopen the existing protected-reserve / `NeedsGrain` semantics.

The minimum required correction can preserve the current rule that only currently disposable personal capacity may be used.

If the Director later wants heads or other actors to be capable of deliberate sacrifice below the current protected reserve, that is a separate agency/material-semantics question and should not be inferred from this note.

---

## 7. Funding-order question

One implementation-relevant semantic detail may require explicit confirmation if current authority does not already entail it:

> When ordinary committed backing exists and the head also offers transaction-specific private supplementation, in what order should those sources be consumed?

The least disruptive interpretation of “supplement” is:

1. compute and allocate ordinary valid institutional backing under the existing accepted contributor rules;
2. use the holder’s explicitly offered transaction-specific amount only to cover some or all remaining shortfall, up to the offered amount and current personal disposable capacity.

This is a recommendation for the narrow v0 correction, not an attempt by the retired author to create project authority.

If the Project Director instead intends the holder to be able to choose to bear cost before / instead of other committed contributors, that should be made explicit because it changes who actually pays.

---

## 8. Why this matters beyond the grain example

This is not merely a convenience for Household dowry/support.

It preserves a deeper causal possibility:

> **An office-holder can combine capabilities derived from the office with capabilities/resources derived from the person, without treating those sources as identical.**

That creates histories where:

- a wealthy holder personally strengthens an otherwise weak institution;
- a poor holder cannot;
- a wealthy holder chooses not to;
- an institution appears capable partly because a particular holder privately subsidizes it;
- a successor inherits the same office but not the predecessor’s transaction-specific private subsidy;
- institutional performance and holder welfare can diverge.

The current slice need not implement later consequences such as prestige, reimbursement, precedent, coercion, political leverage, or expectations created by repeated private subsidy.

It should merely avoid making the foundational causal path impossible.

---

## 9. Suggested bounded acceptance witnesses

Before Slice-4 acceptance freezes, the current Master Architect should ensure the accepted semantics and completion authority can distinguish at least the following:

1. **Existing commitment case**  
   Head P already has a valid `ProvisionCommitment(P -> H)`; P’s grain may fund a Household action under ordinary allocation.

2. **Transactional self-supplement case**  
   Existing institutional backing is insufficient; P has no sufficient prior self-commitment; P explicitly offers disposable private grain for this transaction; combined funding permits commit.

3. **No-consent control**  
   Same world, but P does not offer personal supplementation -> Household cannot seize P’s grain; action remains unfunded if ordinary backing is insufficient.

4. **Bounded offer**  
   P offers at most X personal grain -> no more than X may be debited through this path.

5. **No persistent side effect**  
   One transaction-specific supplement does not silently create a continuing `ProvisionCommitment(P -> H)`.

6. **Initiative independence**  
   P’s ordinary personal initiative being used elsewhere does not by itself forbid explicit self-supplement inside P’s valid Household action.

7. **Provenance / debit history**  
   History distinguishes ordinary committed contributors from the holder’s transaction-specific private contribution.

8. **Personal safety constraints preserved**  
   Existing reserve / `NeedsGrain` boundaries remain enforced unless separately changed by accepted authority.

9. **Succession control**  
   A successor receives office authority, not the predecessor’s transaction-specific private contribution or private property.

---

## 10. Course-correction request

Because Slice 4 is still in acceptance/pre-code work, this should be handled as a **missing semantic capability discovered before freeze**, not as an implementation patch.

The current Master Architect should:

1. reconcile this Director clarification against accepted Slice-4 semantics;
2. identify the minimal semantic amendment required;
3. explicitly resolve any remaining funding-order question that changes who pays;
4. promote the approved rule into the controlling Slice-4 semantic/verification authority;
5. ensure the Slice-4 acceptance candidate contains omission-detectable witnesses;
6. subject the revised acceptance candidate to the already planned independent pre-code review;
7. only then freeze and release coding.

The objective is not to broaden Slice 4 into general institutional finance.

The objective is simply to preserve a basic human causal possibility before the office model hardens:

> **the holder can use the office’s legitimate resources and may also voluntarily put their own resources behind the act.**