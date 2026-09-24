# SFL v0 Slice 4 — Preimplementation Discovery Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / BLOCKED PENDING ONE DIRECTOR SEMANTIC DECISION  
**Date:** 2026-09-24  
**Canonical discovery base:** `a7a9bbcdc86d4684762efd203b20225b64b001b7`  
**Authority:** reconciliation/planning record only; does not itself alter accepted simulation semantics.

## 1. Inputs reconciled

Fresh-context discovery returns:

1. `research/technical/SFL_V0_SLICE4_AUTHORITY_AND_GAP_INVENTORY.md`
2. `research/technical/SFL_V0_SLICE4_IMPLEMENTATION_SURFACE_MAP.md`
3. `research/technical/SFL_V0_SLICE4_VERIFICATION_TRIGGER_MAP.md`

Controlling accepted authority remains:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
- accepted ADRs;
- canonical Stage-3 verification families;
- frozen Slice-1/2/3 acceptance authority.

RUN-0003 and IMP-0003 future lessons are implementation-risk evidence only.

## 2. Executive judgment

The three returns converge on the main architectural conclusion:

**Slice 4 is a substantial kernel extension within the accepted architecture, not an architecture redesign.**

The promoted Slice-3 kernel already supplies the required anchors:

- stable Household identity and lifecycle independent of holder state;
- explicit current/historical SustainingParticipant associations;
- actor-specific provenance-bearing epistemic state;
- exact evidence identities and communication routes;
- deterministic proposal/response/revalidation/commit;
- stable closure;
- Household provision commitments + derived capacity;
- normalized detached counterfactual comparison;
- explicit typed Household authority partition and independent verification surfaces.

Slice 4 adds office/occupancy, multilateral appointment/succession, head Recognition, dual personal/Household initiative, endogenous provision acquisition/spending, and mediated-marriage authority.

No return establishes a need to replace ADR-0004 or redesign the kernel.

## 3. Accepted Slice-4 semantic boundary

Already accepted and therefore not open design questions:

### Persistent office

- every H has one persistent `HouseholdHeadRole(H)`;
- role identity is distinct from H identity and occupant PersonId;
- newly formed H begins headless;
- role may remain vacant without destroying H;
- succession changes occupant without changing H or role identity.

### Eligibility / appointment / succession

- only current `SustainingParticipant` may nominate;
- only current `SustainingParticipant` may be nominated;
- nominee acceptance is required;
- unanimous acceptance/recognition by current sustaining participants is required;
- no majority/autoelection/stable-ID legitimacy rule exists;
- outgoing head may nominate successor before vacating;
- head participation end vacates the same persistent role.

### Recognition

- objective occupancy and actor Recognition are distinct;
- role-transition participants directly acquire the resulting head-role evidence;
- outsiders do not passively synchronize;
- stale predecessor evidence may persist;
- newer accepted evidence/communication may correct it;
- unresolved incomparable authority evidence becomes Contested;
- current participation/occupancy is not information entitlement.

### Scoped authority

Head scope is closed to accepted v0 concerns:

- provision solicitation/reconsideration;
- permitted Household material uses;
- mediated-marriage handling;
- succession.

No general sovereignty, residence command, personal-action command, confiscation, arbitrary relation creation, or attitude write is permitted.

### Dual mode

With Active H + occupied valid role:

- head P retains one personal initiative;
- H receives one separate `HouseholdDecisionContext(H, head=P)`;
- both read the same committed snapshot;
- Household scoring remains distinct from P personal scoring;
- cognition/non-office subjective knowledge remain P's actor state;
- responses remain separate from voluntary initiative accounting.

Vacant or Inactive H emits no Household initiative.

### Provision / collective material effects

Slice 4 activates:

- endogenous head-requested provision commitments;
- reconsideration cooldown + accepted context-change baseline;
- 1-grain eligible NeedsGrain support;
- fixed-rank multi-contributor debit;
- mediated-marriage dowry;
- priority support > other Household provision expenditure > ordinary personal transfer.

Grain remains personal until spend. No Household treasury is created.

## 4. Discovery disagreement — LATER-05 mediated marriage

### Authority scribe

Concluded **LATER-05 is closed by accepted authority**.

### Verification scribe

Treated LATER-05 as still blocking freeze because it wanted the exact response/authority topology stated explicitly.

### Implementation scribe

Flagged LATER-05 as a stop **if** implementation still needed to invent topology.

### Master Architect adjudication

**LATER-05 is NOT a remaining semantic blocker.**

The accepted source set already fixes the bounded v0 topology sufficiently for implementation and acceptance:

1. SPEC §4.2: groom initiates the marriage proposal.
2. SPEC §4.2: groom must know bride participation and recognize H + current head/scope.
3. SPEC §4.2: **head acceptance is sufficient for the mediated route**.
4. SPEC §8.4: current head receives/resolves Household-mediated marriage proposals.
5. SPEC §5.1: role/Household authority context enters a response only where response meaning is role-scoped; marriage-route acceptance/refusal is an allowed response meaning.
6. VS-SFL-104 explicitly instantiates the mediated proposal through current head P as a **role-scoped response context**, and forbids the response when P lacks current authority.
7. SPEC/VS-SFL-042 explicitly allow a female head to mediate her own marriage while forbidding the groom from self-authorizing.

Therefore the bounded accepted route is:

`groom personal initiative -> mediated proposal addressed through H/current head -> one role-scoped current-head response -> central revalidation/commit`.

No additional bride response is required by accepted v0 semantics. Adding one would contradict “head acceptance is sufficient” and introduce a new voluntary choice not present in authority.

Female-head self-mediation is not groom self-authorization: the groom remains initiator and the bride/head responds in her role scope.

This adjudication does not add semantics; it retrieves and applies already accepted semantics.

**Ledger disposition:** LATER-05 may be closed as resolved by accepted SPEC + canonical verification.

## 5. Genuine remaining semantic blocker — LATER-04

All three returns agree that `LATER-04` is now fired.

Accepted authority determines **precommit revalidation**, but does not determine **semantic ordering** when the same committed decision snapshot yields both:

1. an accepted transition that would destroy a currently required authority/status precondition; and
2. an accepted action whose commit still depends on that authority/status.

Canonical examples:

- current head P has an accepted Household support/dowry/provision action while P also ends Household participation, causing vacancy;
- accepted A-authorized Household action coexists with valid A -> B succession;
- accepted Household action coexists with participation transitions that would make H Inactive or Dissolved;
- another accepted status transition removes nominator/nominee/current-participant eligibility before an appointment/succession commit.

If the authority-dependent action is resolved first, both effects may commit.

If the authority-destroying transition is resolved first, immediate revalidation invalidates the dependent action.

Both histories satisfy the current general revalidation rule locally. The missing semantic fact is **which class receives precedence**.

This is not safe implementation discretion:

- proposal/container order cannot choose;
- raw IDs cannot choose;
- central technical fallback cannot choose between semantically unequal current-authority states;
- detached replay cannot invent the priority.

A narrow v0 semantic decision is required before Slice-4 acceptance freeze and coding.

## 6. Exact Director decision needed

The smallest sufficient question is:

> When an accepted same-cycle transition would destroy the head/Household authority or status required by another already-accepted authority-dependent action, which resolves first in bounded SFL v0?

Two clean bounded choices exist.

### Option A — authority-use before authority destruction

For same-snapshot accepted attempts, an otherwise-valid authority-dependent action resolves before a same-cycle transition whose commit would destroy the authority/status it depends upon.

Consequences:

- valid “last act in office” may commit;
- old-head action may commit before A -> B succession;
- valid Household action may commit before the transition that would make H Inactive/Dissolved;
- after that action, destructive transition resolves normally;
- all non-authority preconditions still revalidate;
- no action is rebound to a successor.

### Option B — authority destruction before authority-dependent action

A transition that destroys the required current authority/status resolves before actions dependent on that authority/status.

Consequences:

- exit/vacancy preempts old-head Household action;
- succession preempts an old-head-authorized action;
- transition to Inactive/Dissolved preempts Household action requiring Active H;
- dependent action then fails precommit revalidation as `InvalidatedAtResolution`, not Declined;
- no action is rebound to the successor.

### Not an accepted choice — technical/ID ordering

Do not resolve this with stable ID, proposal order, container order, or generic technical fallback. Those would make social authority depend on technical identity.

### Scope of the decision

This decision is deliberately narrow.

It does not alter:

- Slice-3 bridge-handoff priority;
- provision support > dowry > personal transfer priority;
- Residence conflict;
- appointment unanimity;
- ordinary response semantics;
- checkpoint/restore;
- general contested succession/multiple claimants.

## 7. Verification consequences already established

Regardless of LATER-04 choice, Slice-4 acceptance must cover at minimum:

- persistent vacant role after H formation;
- initial appointment + nominee decline + missing unanimity + invalid nominator/nominee;
- role vacancy without H destruction;
- same-role succession;
- stale/corrected/Contested head Recognition;
- dual personal + Household initiative from same snapshot;
- compatible personal/Household commits;
- central conflict/revalidation;
- scoped-authority negative census;
- endogenous provision commitment acquisition;
- reconsideration cooldown/context change;
- support spend;
- fixed-rank multi-contributor debit;
- mediated marriage under the already-closed topology;
- provision priority;
- authority-dependent race cases using the Director-approved LATER-04 rule;
- vacant/Inactive/Dissolved no-initiative controls;
- no self-confirmation / Household-feedback nonauthority;
- fallback quarantine;
- truthful trace/configuration provenance;
- full inherited frozen REQUIRED sets.

Independent role/oracle checks must challenge exact:

- role identity;
- H-role links;
- occupant transition;
- nomination/acceptance/unanimity parties;
- participant eligibility;
- role Recognition EvidenceIds/provenance;
- debit vector;
- mediated effects;
- technical fallback domain.

## 8. Known inherited verification adaptations before coding

Slice 4 necessarily invalidates some **literal Slice-3 implementation-era witnesses** while preserving their semantic meaning.

Known cases include:

- S3-014 literal absence of HeadRole / HouseholdDecisionContext types;
- S3-093 exact HouseholdState private-field inventory if office authority is added to that partition;
- Slice-3 oracle assumptions that all Household events are non-material;
- Slice-3 fixture-only commitment provenance assumptions once endogenous acquisition exists.

These are **enforcement/adaptation tasks, not new social semantics**.

Do not delete or loosen frozen evidence.

Before coding, Slice-4 acceptance planning must specify lossless inherited regression adaptations that preserve:

- Slice 3 had no spending/head behavior in its own completion boundary;
- authority remains explicit/typed/non-derived;
- old frozen manifests remain immutable historical authority;
- current implementation can add accepted later-slice capability without being falsely rejected by literal type/field absence tests.

## 9. Slice-4 / Slice-5 boundary

Slice 5 retains:

- exact checkpoint/restore continuation;
- checkpoint omission mutants / causally active suffixes;
- delayed-process persistence.

Slice 4 must preserve checkpoint-safe stable-cycle boundaries and future-influencing role state as authoritative, but does not implement engine save/restore.

General candidate convergence, actor departure, repeated predecessor lineage source selection, general contested succession/multiple claimants, richer perception/trust, and generalized institutional authority remain outside bounded Slice 4.

## 10. Implementation architecture judgment

**SUBSTANTIAL KERNEL EXTENSION — NO ARCHITECTURE REDESIGN.**

High-pressure seams include:

- Household role state/occupancy;
- Epistemic head-role propositions;
- dual decision contexts;
- multi-party appointment responses;
- Household-aware resolution/dependencies;
- atomic cross-partition provision/marriage commits;
- normalized detached projection;
- independent acceptance oracles.

The existing deterministic reference-kernel architecture remains suitable.

## 11. Readiness

### Acceptance candidate drafting

Technically **READY TO DRAFT**, but drafting before the Director's LATER-04 choice would require explicit unresolved placeholders.

Preferred critical path: close LATER-04 first, then draft one complete candidate rather than authoring/fixing a knowingly incomplete acceptance table.

### Acceptance freeze

**BLOCKED pending LATER-04 Director decision.**

### Coding

**NOT AUTHORIZED.**

Coding begins only after:

1. Director resolves LATER-04;
2. accepted authority/verification are promoted losslessly;
3. Slice-4 acceptance candidate is drafted;
4. independent pre-code review PASS;
5. Slice-4 acceptance authority is frozen;
6. inherited structural/adaptation triggers are closed or explicitly gated.

## 12. Current critical path

**Director LATER-04 decision -> semantic promotion -> Slice-4 acceptance candidate -> independent pre-code review -> freeze -> implementation packet.**
