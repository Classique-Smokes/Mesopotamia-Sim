# SFL v0 Slice 4 — SID Pass-B Master Architect Reconciliation

**Status:** PILOT RECONCILIATION / SEMANTIC DECISIONS REQUIRED  
**Date:** 2026-09-24  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Semantic-interaction-delta trigger:** **FIRED**  
**Delta semantic base:** `main@3fd94b4000df176e3bf7e4a4a93eb8ccdaf14747` plus later nonsemantic governance/navigation/review records only  
**Frozen MA frontier:** `sfl-v0-slice4-sid-ma-frontier-v1` @ `cd8c3ccf497bd8df928d5dee5f888188d98dd4ef`  
**Frozen Pass A:** `sfl-v0-slice4-sid-passa-v1` @ `6a15d40c2c8b9f54bba9c5f5e77a5806a9cee94e`, blob `f42d3f1baec9d103462a95077038dd4032c09ae1`  
**Frozen Pass B:** `sfl-v0-slice4-sid-passb-v1` @ `77f0f7c64d3ac85f933e6f7c39ee2cd70cf5d7ec`, blob `a63ab9252365f10c6c33ee7c59267b632de281cf`  
**Frontier union:** `research/technical/SFL_V0_SLICE4_SID_FRONTIER_COMPARISON_AND_PASSB_UNION.md`

## 1. Pilot integrity

The first SID pilot satisfied the designed two-pass independence:

- Pass A began from the exact blind dispatch ref;
- Pass A added one report only;
- Pass A disclosed no contamination;
- Pass A was durably frozen before MA-frontier reveal;
- Pass B began from the exact union dispatch ref;
- Pass B added one report only;
- Pass B verified the pinned Pass-A / MA frontier identities before challenge;
- Pass B did not use frozen Slice-4 acceptance v1 as semantic authority.

The fresh reviewer independently added/sharpened material frontier surfaces that were absent or less explicit in the MA map, including:

- debt-repayment competition;
- mediated-marriage favour-slot interaction;
- called-favour payload boundary;
- marriage -> residence incentive;
- failure-knowledge privacy;
- continuity-priority composition;
- reaction-closure/stable-publication;
- checkpoint/continuation seam.

Therefore the two-pass frontier-independence mechanism produced real additional coverage.

## 2. Pass-B challenge dispositions

### PB-01 — full-private Household support with zero standing mobilizable capacity

**Disposition:** **SUPPORTED / ACCEPTANCE GAP ONLY**

DEC-0011 explicitly allows `X = C` and residual commitment requirement `R = 0`.

SPEC §8.5 now requires sufficient valid **transaction funding**, which may consist of commitment-backed allocation plus optional exact current-holder X. Standing `MobilizableCapacity(H)` remains commitment-only and may be zero.

Therefore:

- zero standing mobilizable capacity does **not** prohibit the action when valid private X covers the full cost;
- no persistent provision commitment is created;
- standing capacity remains zero after the transaction except for independent commitment changes.

This is accepted semantics that successor Slice-4 acceptance must make omission-detectable.

**Pilot evidence label:** `KNOWN CASE PROCESSED` with a new boundary witness derived from DEC-0011.

---

### PB-02 — Household support versus RepayDebt on the same grain

**Disposition:** **UNRESOLVED**

Accepted authority establishes:

- debt/favour do not automatically reserve grain;
- eligible Household support outranks other Household provision expenditure;
- Household provision expenditure outranks “ordinary voluntary personal transfer”;
- RepayDebt is a voluntary personal action transferring grain but also has a distinct debt-claim meaning and due-cycle consequence.

Current authority does **not** explicitly classify RepayDebt inside or outside the third priority class.

That distinction is consequential because:

- one order may preserve repayment;
- the other may invalidate repayment;
- in the debt social-due cycle, the result can determine whether the one-time creditor -> debtor attitude consequence fires.

Technical/container fallback may not choose this social consequence.

**Required Director decision:** classify RepayDebt for conflicts with Household material expenditure.

---

### PB-03 — bridge-dependent participation entry + succession + same bridge/head exit

**Disposition:** **UNRESOLVED**

Two accepted narrow rules apply relative to A's exit:

- Slice-3 continuity bridge-handoff protects D's accepted bridge-dependent entry before A's exit;
- DEC-0010 protects the otherwise-valid A->B succession before A's accepted status-destroying exit.

Neither rule orders **entry versus succession**.

The order is consequential:

- succession first -> accepted unanimity set is A/B/C; succession may commit, then D enters;
- entry first -> D becomes a current SustainingParticipant before succession precommit; live unanimity revalidation can now require D's acceptance and invalidate the succession.

Current authority does not define whether:

- succession precedes entry;
- entry precedes succession;
- the succession's consent cohort is snapshot-bound rather than live;
- another explicit composition rule applies.

Generic technical fallback cannot decide.

**Required Director decision:** close the composition of bridge-handoff and succession when both are protected relative to the same exit.

**Pilot evidence label:** `PREVIOUSLY UNKNOWN MATERIAL FINDING`.

---

### PB-04 — private-X failure knowledge / privacy

**Disposition:** **DERIVED CONSEQUENCE / ACCEPTANCE GAP ONLY**

Accepted authority is sufficient.

- DEC-0011 requires authoritative history to retain exact X and funding provenance.
- SPEC §6.4 gives direct participants knowledge of proposals/events in which they directly participate.
- SPEC §6.7 limits failed-attempt reasons to interaction-relevant propositions and forbids resolver-omniscience leakage.
- VS-SFL-073 requires no exact private grain balance disclosure where not interaction-required.

Therefore a direct counterparty may learn that the **agreed funding plan / private funding leg is no longer feasible** when that fact is necessary to explain the failure.

They do not automatically learn:

- P's exact live grain balance;
- unrelated debt/favour;
- unrelated recognition/private state.

Authoritative history may remain richer than actor knowledge.

The exact diagnostic enum/string is implementation-local if it preserves this information boundary.

Successor acceptance should exercise the private-X failure case explicitly.

---

### PB-05 — provision-request cooldown across head succession

**Disposition:** **DERIVED CONSEQUENCE / ACCEPTANCE GAP ONLY**

SPEC §8.2 says:

> after refusal, another request requires 3 full cycles elapsed **and** relevant context change since refusal,

and lists **head occupant** as one accepted relevant context dimension.

SPEC §8.4 makes succession an occupant change under the same persistent H/role.

Therefore:

- a refusal/reconsideration history belongs to the continuing H/target provision-reconsideration process rather than being erased by head succession;
- new head B's request before the three full cycles remains ineligible;
- head change satisfies the **context-change** limb only;
- after three full cycles, the prior A->B head change may satisfy the context-change limb if no later rule resets it.

If succession reset the refusal/cooldown as a new “first request,” “head occupant” could not coherently serve as a listed context-change trigger for reconsideration.

Successor acceptance should make the pre-three-cycle succession case explicit.

---

### PB-06 — head as needy Household-support recipient

**Disposition:** **UNRESOLVED**

Current authority separately establishes:

- the recipient class = eligible needy current SustainingParticipant;
- current head must be a current SustainingParticipant;
- head may proactively propose Household support;
- eligible needy participant may request support through the head.

No accepted rule says:

- head cannot be recipient;
- head can authorize support to self;
- which topology applies if requester/recipient/head are the same PersonId;
- whether the self-request response collapses into Household deliberation or remains invalid.

This cannot be inferred from the groom=head prohibition because that prohibition is route-specific and explicitly stated.

**Required Director decision:** classify head=Household-support-recipient and the resulting request/proactive topology.

**Pilot evidence label:** `PREVIOUSLY UNKNOWN MATERIAL FINDING`.

## 3. MA provisional unresolved questions not independently duplicated by Pass B

The MA frontier contained additional alias/lifecycle questions that remain part of SID closure even though Pass B did not choose them as its six histories.

### MA-U02 — current head as target of persistent provision acquisition/reconsideration

**Disposition:** **UNRESOLVED**

SPEC §8.2 permits the head to ask a non-contributing sustaining participant.

A current head is a sustaining participant and may be non-contributing.

No accepted rule classifies requester=head and target=head.

DEC-0011 only settles transaction-specific private X and explicitly avoids creating a persistent commitment; it does not settle reusable self-commitment.

The semantics must determine whether:

- a current head may voluntarily create/reconsider their own persistent `HouseholdProvisionCommitment(P -> H)`;
- if so, whether this is direct dual-capacity consent without self-proposal/response;
- or whether persistent self-commitment is prohibited while transaction-specific X remains available.

**Required Director decision.**

---

### MA-U03 — nominee consent versus nominee's unanimity-participant acceptance

**Disposition:** **DERIVED CONSEQUENCE / REPRESENTATION-LOCAL AFTER SEMANTIC PREDICATES ARE PRESERVED**

SPEC §8.4 conjunctively requires:

1. nominee acceptance; and
2. unanimous acceptance/recognition by current sustaining participants.

Because the nominee must be a current sustaining participant, the nominee belongs to the unanimity set.

Therefore nominee consent does not eliminate the second semantic predicate.

The implementation may represent the same person's two explicit consents as:

- distinct response records; or
- one compound explicit response/event that omission-detectably satisfies both semantic predicates,

provided history/oracles can distinguish that both requirements were met.

The project does not require artificial duplicate cognition merely to create two technical events.

No Director decision is required for representation shape.

---

### MA-U04 — nominator's nomination versus nominator's unanimity acceptance

**Disposition:** **DERIVED CONSEQUENCE**

Nomination is not named as an exception to the separate unanimous-acceptance precondition.

The nominator is a current sustaining participant and therefore belongs to the unanimity set.

Accordingly:

- nomination alone does not waive the nominator's participant-acceptance predicate;
- the nominator must be represented as accepting/recognizing the appointment before commit.

As above, representation may combine explicit semantic predicates in one event only if both remain omission-detectable.

No new Director semantic choice is required.

---

### MA-U05 — self-nomination (nominator = nominee)

**Disposition:** **UNRESOLVED**

SPEC says any current SustainingParticipant may nominate a current SustainingParticipant but does not state an inequality.

Existing verification checks participant eligibility, consent and unanimity but does not classify self-nomination.

If allowed, nomination/nominee/unanimity positions collapse and the response topology must avoid fake self-negotiation while still preserving the distinct semantic predicates.

If prohibited, the distinctness rule must be explicit rather than inferred from examples.

**Required Director decision.**

---

### MA-U06 — appointment / succession while H is Inactive

**Disposition:** **UNRESOLVED, linked to self-nomination**

SPEC §8.5 says Inactive H has no Household-mode initiative.

SPEC §8.4 does not explicitly state that head-role appointment/succession requires Active H.

Because Inactive H has exactly one sustaining participant:

- a headless Inactive H can appoint anyone only if the sole bearer may nominate/appoint themself or if some later participant first reactivates H;
- an occupied Inactive role has no distinct current participant available as successor.

The semantic question is whether role-maintenance/appointment is:

- a participant/role transition permitted while H is Inactive even though the office has no Household-mode initiative; or
- suspended until H becomes Active.

**Required Director decision.**

## 4. Other frontier-union surfaces

The remaining union surfaces are currently classifiable from accepted authority and do not establish additional semantic blockers:

- ordinary personal agency remains available independently of office;
- direct mutual-strong-like marriage remains independent of mediated route;
- groom=head mediated self-authorization is prohibited;
- bride=head self-mediation is supported;
- same holder standing commitment + private X uses one residual grain stock;
- Household support/spend/private X cannot become formation/continuity/lineage evidence;
- mediated marriage creates only the accepted groom->head favour;
- lineage transfers no role/resources/commitments/pending process;
- head Recognition remains actor-specific and non-passively synchronized;
- participation end vacates the head and ends only that person's commitment;
- role succession preserves H/role identity and does not transfer private X;
- Inactive suppresses Household-mode initiative without destroying H identity;
- stable reaction closure remains controlling;
- exact checkpoint/restore implementation remains Slice 5, while Slice 4 must preserve authoritative future-influencing state/provenance.

No new global framework is required.

## 5. Pilot efficacy accounting

### KNOWN CASE PROCESSED

- DEC-0011 transaction-specific private supplementation / standing-capacity distinction.
- Existing known bride=head / groom=head mediated-marriage aliases.
- Existing DEC-0010 authority-use race.

### PREVIOUSLY UNKNOWN MATERIAL FINDING

At minimum:

1. bridge-dependent entry versus succession can change the live unanimity set before the same exit;
2. head=Household-support-recipient is unclassified;
3. Household expenditure versus RepayDebt priority is underclassified;
4. current-head persistent self-provision commitment is unclassified;
5. self-nomination is unclassified;
6. Inactive-H appointment semantics are unclassified.

### DUPLICATE FINDING

- Several Pass-A additions map to already-accepted generic controls (failure privacy, no Household self-confirmation, role/Recognition separation) but were still useful as frontier confirmation.

### NOISE / FALSE POSITIVE

- None currently classified as noise; reviewer-added checkpoint surface is a valid future seam but not a Slice-4 implementation requirement.

### NO NEW FINDING

- Not applicable. The pilot surfaced previously unclassified material semantics.

The first pilot therefore provides prospective evidence that SID-ASSURANCE-v1 finds interactions beyond its motivating DEC-0011 incident.

## 6. Current closure state

- `Semantic-interaction-delta trigger: FIRED`
- MA frontier: COMPLETE
- Independent frontier Pass A: COMPLETE / FROZEN
- Pass B challenge: COMPLETE / FROZEN
- Frontier comparison/union: COMPLETE
- Master Architect reconciliation: COMPLETE
- Closure freshness: **CURRENT** relative to the accepted Slice-4 semantic base; repository changes since that base are governance/review/navigation only
- `Consequential unresolved: 6`
- `Accidental gaps outstanding: 0` pending Director dispositions

The six unresolved decision clusters are:

1. Household support versus RepayDebt priority;
2. bridge-entry versus succession composition before same exit;
3. head as Household-support recipient;
4. head persistent self-provision commitment;
5. self-nomination;
6. role appointment while Inactive.

## 7. Freeze / implementation consequence

SID closure is **NOT COMPLETE**.

Do not:

- draft/freeze successor Slice-4 acceptance yet;
- reactivate inherited-verification adaptation as a forward gate;
- dispatch Slice-4 coding bārû;
- close the Director BLOCK.

Next required step:

Project Director resolves the six bounded semantic decision clusters.

After promotion:

1. reopen only affected frontier rows;
2. update closure dispositions;
3. revalidate closure freshness;
4. require `Consequential unresolved: 0`;
5. then draft successor Slice-4 acceptance.
