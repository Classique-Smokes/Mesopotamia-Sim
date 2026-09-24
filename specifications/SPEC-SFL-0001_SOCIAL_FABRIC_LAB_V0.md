# SPEC-SFL-0001 — Social Fabric Laboratory v0

- **Status:** ACCEPTED
- **Owner:** Master Architect
- **Date:** 2026-09-21
- **Depends on accepted decisions:** DEC-0001, ADR-0001, ADR-0002, ADR-0003, ADR-0004, ADR-0005
- **Known assumptions:** ASM-0001 through ASM-0014

## 1. Purpose and scope

SFL v0 is a small deterministic social-mechanism laboratory for the individual -> relationship -> household foundation.

It must demonstrate:

- persistent individuals and typed social relations;
- subjective knowledge/recognition distinct from objective state;
- household formation from lower-level history without a primitive household-membership container;
- persistent household identity through limited turnover;
- one grounded collective material capability;
- one scoped representative/head role;
- explicit proposal/resolution, causal history, and exact continuation.

Historical calibration/validation is outside this specification. v0 supplies the foundation to be refined later.

### 1.1 Laboratory boundary and fixture authority

- SFL v0 has **no semantic fixed actor count**. Fixture population size is a verification choice.
- The scenario harness may explicitly initialize/inject bounded lower-level facts or exogenous events that future subsystems would eventually generate, including kinship, pre-existing marriage where a fixture needs it, attitudes, residence, starting grain, actor arrival/departure, and external resource changes.
- Such fixture inputs must be declared and must not directly write endogenous Household identity, warrants, role outcomes, or other results the scenario is meant to prove.
- People may retain socially relevant relationships/actions across household boundaries.
- No one dimension—attitude, kinship, marriage, debt/favour, residence, or household association—automatically defines the others.

Forbidden shortcuts include:

- household = dwelling, kinship, marriage, co-residence, or graph cluster;
- a hidden primitive household-membership set used as causal ground truth;
- forcing all socially relevant ties inside household boundaries;
- a privileged `FormHousehold` command that directly creates the aggregate.

## 2. World boundary

### 2.1 People

A person has stable identity and v0 objective state sufficient for:

- sex: male/female;
- grain stock;
- `NeedsGrain`;
- residence;
- marriage status/history;
- explicit kinship, debt, favour, household-association, and other relation references.

Ageing, reproduction, health, death, class/status, profession, and personality traits are out of scope.

### 2.2 Grain

Grain is a fungible resource counted in integral v0 units.

- personal grain stock is a nonnegative integer;
- every action parameter denominated in grain is a strictly positive integer;
- zero, negative, and non-integral grain action quantities are categorically invalid terms and are rejected before any counterparty response is activated;
- an invalid grain term produces no material or social effect and is not a `Declined`, `Unable`, or `InvalidatedAtResolution` failed attempt;
- `Farm` yields 4 grain.
- Consumption is 1 grain per person per cycle.
- Typical verification starts use 4-8 grain per actor.
- Missing consumption creates `NeedsGrain`.
- A `NeedsGrain` actor cannot Farm.
- `NeedsGrain` clears once the actor again holds at least the next 1-grain consumption unit.
- No agriculture/land/market/wage/price system is implied.

Integral grain units are a replaceable v0 laboratory discretization, not a claim about historical metrology or later economic quantity representation.

### 2.3 Dwelling

Residence is an explicit person -> dwelling relation.

Residence is not ownership and does not by itself create, preserve, split, or merge a household.

## 3. Lower-level social fabric

### 3.1 Attitude

Directed subjective attitude is an integer in [-100,+100]. It is not a generic relationship-strength variable and must not substitute for kinship, marriage, debt, favour, obligation, or household association.

- -100..-75: strong dislike
- -74..-26: dislike
- -25..+25: neutral
- +26..+74: like
- +75..+100: strong like

Fixed v0 updates:

- accepted voluntary gift/help: recipient -> giver +10;
- loan granted: borrower -> lender +5;
- successful repayment: lender -> borrower +5;
- fulfilled called favour: holder -> fulfiller +10;
- refusal of ordinary request while requester is in genuine unmet need: requester -> refuser -5;
- ordinary refusal without genuine need/accepted obligation: 0;
- refusal of called favour: holder -> refuser -20;
- debt remaining unpaid at its social due cycle: creditor -> debtor -10 once;
- rejected marriage proposal: 0.

Every 5 cycles, positive attitude moves 2 toward 0 and negative attitude moves 1 toward 0; decay never crosses 0.

**Same-cycle direct attitude composition.** The fixed attitude consequences above that are directly triggered by the current cycle's committed interaction, failure, or debt-social-due-review outcomes compose order-independently per directed attitude. Starting from that directed attitude's value after maintenance/decay and before those automatic direct attitude consequences, collect every distinct currently due direct cause, sum its signed fixed delta exactly once, and clamp the resulting total once to [-100,+100]. Do not clamp contribution-by-contribution. Maintenance decay is not part of this sum.

Each contributing cause key and signed delta remains explicit causal history for the resulting attitude transition; enumeration order among those independent causes has no semantic effect. A future rule that creates an attitude consequence causally downstream of another automatic reaction must define its causal placement explicitly and is not silently folded into this direct-cause batch.

### 3.2 Kinship

v0 supports only:

- parent/child;
- sibling.

Kinship is initialized rather than generated by reproduction.

For ordinary interpersonal decision evaluation, kinship multiplies the attitude-derived component by 1.5x.

This multiplier affects scoring only; it does **not** change stored attitude and cannot satisfy a categorical gate defined on stored attitude.

Kinship is excluded from marriage evaluation. Parent/child and sibling pairs are marriage-ineligible.

### 3.3 Debt

Debt is a quantitative grain claim.

- loan creates creditor/debtor, original amount, remaining amount;
- repayment may be partial or complete; completion satisfies the current claim without erasing the debt/repayment history;
- `RepayDebt(amount)` is semantically valid only when `1 <= amount <= remaining debt`; over-repayment is invalid rather than clamped, credited, or converted into another transfer meaning;
- a semantically valid repayment amount may still be materially infeasible because of current grain/reserve state, in which case ordinary `Unable` / precommit-revalidation rules apply;
- no interest, collection/default process, or automatic enforcement;
- each loan has a **social due cycle 3 full cycles after loan commitment**;
- if any balance remains at that due-cycle review, creditor -> debtor attitude changes -10 once, regardless of whether the debtor could materially repay;
- the due cycle exists only for this relationship consequence; it does not reserve grain or force repayment;
- repayment must leave the debtor with at least 2 grain;
- debt does not compel unrelated action and is distinct from favour.

### 3.4 Favour / obligation

A favour is one qualitative action-oriented claim.

- at most one outstanding favour per ordered person-pair;
- no expiry in v0;
- no point value, exchange rate, trading, inheritance, partial favour balance, or generic social-currency interpretation;
- it may arise from an explicit benefit-for-favour bargain;
- it may arise from knowingly accepted reciprocal help only when recipient attitude toward benefactor is >= +75;
- genuine gifts create no favour;
- a voluntarily initiated `CallFavor` uses the holder's ordinary personal initiative under §5;
- a called-favour payload is valid only when the called actor's `FulfilCalledFavor` / `RefuseCalledFavor` choice is the last new voluntary actor choice required for the requested action to reach a terminal commit/failure;
- the requested action executes within that response scope: it does not separately consume or grant the called actor's personal initiative and remains subject to ordinary world feasibility, central revalidation, and commit/failure;
- a v0 called-favour payload may not open another `ResponseDecisionContext`, require a third actor's new voluntary choice, create/demand/transfer/cancel another favour, establish marriage/kinship, or require household/role authority;
- a categorically non-callable payload is rejected before target response and produces no material or social effect;
- an impossible or currently infeasible requested action remains impossible/infeasible;
- the favour is consumed only when the requested action commits successfully; successful fulfilment applies holder -> fulfiller +10;
- voluntary refusal yields `Declined`, leaves the favour outstanding, and applies holder -> refuser -20;
- `Unable(reason)` or `InvalidatedAtResolution(reason)` leaves the favour outstanding and applies neither called-favour fulfilment nor refusal attitude effect;
- favours cannot create/demand/transfer another favour;
- if A owes B one favour and B independently owes A one favour, either may cancel both atomically.

### 3.5 Transfer meanings

These meanings must remain explicit to actors/history even if implementation shares transfer code:

- gift;
- loan;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help.

**Explicit benefit-for-favour is an atomic bargain.** Its specified material benefit and exactly one new favour commit together or not at all. If the required ordered-pair favour slot is already occupied when feasibility is evaluated, the interaction is `Unable(FavourCapacityFull)`: no voluntary Accept/Decline scoring occurs, no material benefit commits, and no new favour is created. If the slot was available when the target accepted but becomes unavailable before commit, the interaction is `InvalidatedAtResolution(FavourCapacityFull)` and neither leg commits. A failed explicit bargain is never silently relabeled as Gift/Help and does not acquire Gift/Help attitude consequences merely because material transfer code is shared.

**Relationship-mediated reciprocal help remains independently meaningful.** If otherwise valid, feasible, and accepted, the help may still commit when the relevant favour slot is already occupied; no second favour is created.

### 3.6 Residence change

Residence change is endogenous and proposal-based.

A person may propose moving to another person's dwelling or inviting another person into their dwelling. The named counterpart's acceptance is sufficient in v0.

Strong mutual positive relations create a weaker co-residence incentive; marriage creates a stronger one. Marriage does not automatically move either spouse; residence change still requires its own proposal/acceptance path.

At most one Residence transition for a given person may commit in one cycle. A person may nevertheless independently Accept multiple Residence proposals from the common snapshot; those Accept responses remain true history and are not rewritten as refusals. Multiple accepted, still-feasible effects that would change the same person's Residence in that cycle are centrally resolved as one conflict set under §9.2.

## 4. Marriage

Marriage is a persistent relation distinct from attitude, kinship, residence, and household association.

- male = groom; female = bride;
- groom initiates;
- proposal names bride and proposed dowry;
- established marriage is at-most-once per person;
- rejected proposals do not consume eligibility;
- divorce, widowhood, remarriage, plural marriage, reproduction, and a marriage market are out of scope.

Two routes exist:

### 4.1 Mutual-strong-like bypass

If both prospective spouses hold stored attitude >= +75 toward one another, they may form marriage directly.

This route bypasses household mediation, dowry, and groom -> head favour.

### 4.2 Household-mediated route

If bypass does not apply:

- bride must be a female `SustainingParticipant` of H;
- groom must hold sufficient subjective factual evidence of the bride's current `SustainingParticipant` association to H;
- groom must recognize H and its current head/scope;
- head acceptance is sufficient for the mediated route;
- household provision capacity must cover the proposed dowry;
- dowry transfers directly to groom;
- groom receives one favour owed to head;
- groom cannot already owe head a favour;
- groom cannot self-authorize as the mediating head;
- a female head may mediate her own marriage;
- if bride has no recognized household, mediated marriage is unavailable.

## 5. Individual agency

Each person normally receives one voluntary personal initiative per cycle. Responses to incoming proposals do not consume it. No `Wait` action is required.

Reference v0 policy:

- deterministic, with no random choice;
- ADR-0002 hierarchical/context-sensitive candidate generation;
- categorical eligibility/accessibility gates run before scoring;
- every remaining candidate receives a finite set of **named integer score components** supplied by the active rule/configuration profile;
- `FinalScore = sum(all named component values)`;
- the candidate with the highest `FinalScore` is selected;
- exact-score ties use an explicitly declared domain tie key where the relevant action domain defines one; otherwise the disclosed stable-semantic-ID technical fallback applies and is logged;
- v0 soft concern/tier effects are represented through named score components and candidate-generation/gating rules rather than a second hidden aggregation layer;
- if no candidate remains after generation/gating, the actor initiates nothing; no semantic `Wait` action is required.

Component-producing rules/configuration must yield exact integer values. Numeric coefficients remain laboratory configuration rather than social semantics. The canonical Stage-3 closed-loop profiles use exact integer scaling so accepted domain multipliers such as the 1.5x kinship attitude-component amplification require no floating-point rounding.

The complete decision trace records every candidate, gate result, named component values, `FinalScore`, tie-break use, chosen candidate, and relevant subjective inputs.

This is a **reference policy, not a permanent architecture lock**. Action/world semantics remain separable from actor policy so later planning, heterogeneous personalities, learned policies, or stochastic choice can replace/extend the v0 scorer without rewriting the social substrate.

Persistent concern categories are:

- maintain grain / escape `NeedsGrain`;
- maintain/react to interpersonal relations;
- discharge repayable debt;
- respond to called favour;
- seek marriage when eligible;
- seek co-residence when motivated.

Exact scoring coefficients are laboratory configuration, not independent social semantics; Stage-3 scenarios must pin the values they rely upon.

### 5.1 Response decision contexts

For every incoming proposal whose semantics require a target choice, v0 activates a deterministic `ResponseDecisionContext(target, proposal)`.

A response context reads:

- the same committed cycle snapshot used by personal/household deliberation;
- the incoming proposal's explicit terms;
- the target's subjective state from that snapshot;
- role/household authority context only where the response meaning itself is role-scoped.

It does not observe uncommitted effects of other proposals or responses.

**Categorical proposal-term validity precedes response activation.** A malformed grain amount or other categorically invalid term, including a called-favour payload outside the v0 response-closed callable domain, is rejected before target response. Such a rejection may be retained diagnostically but creates no valid social interaction, material effect, participant response, or §6.7 failed-attempt outcome.

**Feasibility precedes voluntary response scoring.** If a semantically valid interaction is infeasible from the target/world state, the interaction produces `Unable(reason)` under §6.7 rather than a scored voluntary refusal.

If feasible, generate only response meanings valid for that proposal type, such as:

- Accept / Decline;
- FulfilCalledFavor / RefuseCalledFavor;
- AcceptResidenceChange / DeclineResidenceChange;
- AcceptProvisionCommitment / DeclineProvisionCommitment;
- invitation/participation acceptance or refusal;
- nomination/appointment/succession acceptance where applicable;
- marriage-route acceptance/refusal where applicable.

Feasible response candidates use the same reference scorer defined above: named exact-integer components, summed `FinalScore`, highest score wins, then any explicitly declared domain tie key or the logged stable-semantic-ID technical fallback.

Response-specific coefficients are laboratory configuration, not independent social semantics.

Response contexts:

- do not consume or grant the target's personal initiative;
- for a valid called favour, execute the approved response-closed requested action within the fulfilment response scope without granting/consuming a second personal initiative and without opening another response context in v0;
- may activate multiple times for one target in one cycle;
- may select multiple Accept/Fulfil responses from the common snapshot;
- do not bypass central resolution/revalidation;
- do not turn a later capacity conflict into retroactive refusal: such a loss is `InvalidatedAtResolution`.

Diagnostic history for each response decision records proposal ID/terms, response candidates/gates, named components/final scores, selected response, relevant target subjective inputs, and response profile/configuration version.

Required action meanings include:

- Farm;
- OfferGift / RequestGiftOrHelp;
- OfferLoan / RequestLoan / RepayDebt;
- OfferBenefitForFavor;
- relationship-mediated reciprocal help;
- CallFavor / fulfil / refuse / reciprocal cancellation;
- ProposeMarriage;
- propose/respond to residence change;
- RequestHouseholdParticipation / InviteHouseholdParticipation / EndHouseholdParticipation;
- CommunicateClaim/Inform;
- household-role actions defined below.

## 6. Subjective information and recognition

### 6.1 Layers

- `KnownFact`: factual proposition held by an actor, with provenance.
- `Recognition`: social interpretation of a collective/authority proposition.

Recognition state is discrete and evidence-backed:

- **Unknown** — actor has no accepted recognition basis for the proposition;
- **Recognized** — actor has sufficient currently accepted evidence for the proposition;
- **Contested** — actor holds incompatible evidence that prevents the proposition from being safely relied upon for authority-dependent action.

Recognition retains provenance to supporting evidence/reports. It is not a scalar confidence score, attitude, approval, or obedience.

### 6.2 Recognition propositions

v0 requires:

- candidate organization C is recognized as the same prospective founding organization;
- household H exists/continues;
- person P occupies head/representative role for H within scope.

There is no universal subjective or objective primitive `MemberOf(H)` relation.

### 6.3 Candidate recognition

`CandidateRecognition(C)` is an ephemeral, provenance-bearing recognition proposition for a pre-household candidate. It grants no household powers and is not household identity.

A required founder recognizes candidate C only when that actor's own subjective state contains uncontested evidence sufficient to establish the objective formation predicate for the proposed founding core:

- shared residence of that core;
- a connected durable-tie structure for that core;
- two qualifying committed support events on distinct cycles.

The actor need not know that the other founders also recognize C. Candidate existence/label cannot count as evidence for itself.

### 6.4 Knowledge acquisition

Actors automatically know:

- their own objective state;
- relations/claims in which they are direct parties;
- proposals/events in which they directly participate.

Other facts require valid event-specific observation or communication. Co-residence does not imply omniscience.

`CommunicateClaim/Inform` transmits a factual or recognition proposition the sender currently holds and carries sender plus underlying source/event provenance where available. Communication normally consumes the sender's one voluntary personal initiative for the cycle.

A communicated event-backed proposition may provide sufficient evidence for recognition when no stronger/newer contradiction exists.

No deliberate lying, invented claims, trust score, rumor mutation, or reputation system exists in v0.

### 6.5 Staleness and conflict

Subjective state does not passively synchronize.

- stale information persists until displaced or contested;
- underlying event/observation order outranks later message-arrival time;
- newer direct participation/observation supersedes older incompatible information;
- newer event-backed communication may supersede older reports;
- incompatible evidence that cannot be resolved by provenance/order becomes Contested rather than selecting one claim.

Recognition does not decay with attitude.

### 6.6 Recognition as an action gate

Recognition is causal rather than decorative.

- an engine-side Household record does not expose household-specific actions globally;
- to intentionally act toward H as a household, an actor must recognize H;
- to use person P as H's authority channel, the actor must recognize P in the relevant head/representative role and scope;
- ordinary person-person actions remain available independently of household recognition;
- an actor may recognize H/head while disliking them or refusing a request.

For household-mediated marriage, the groom must know the relevant bride-to-H participation fact and recognize H plus its current head/scope. Without that subjective route the mediated candidate is unavailable; the mutual-strong-like bypass remains independent.

### 6.7 Failed attempts

This section applies to semantically valid proposals/interactions. A categorically invalid proposal term rejected before response activation is not a social failed attempt under this section; diagnostic recording of that validation rejection does not by itself create participant knowledge or a social consequence.

Direct participants learn failed-attempt outcomes:

- `Declined`;
- `Unable(reason)`;
- `InvalidatedAtResolution(reason)`.

Reasons are bounded to what the interaction makes knowable; resolver omniscience must not leak unrelated private state.

Feasibility failures are not voluntary refusal and do not trigger refusal-attitude penalties.

A proposed-but-uncommitted world effect never becomes an objective fact. The proposal/refusal/failure event itself may still be known to its direct participants.

## 7. Household formation and identity

### 7.1 Candidate organization

A `CandidateOrganization` may collect formation evidence but has no causal authority, resources, household actions, or self-supporting evidence.

### 7.2 Formation

A household founding core contains at least **two distinct people**. A household forms only when that connected founding core has:

- shared residence;
- a connecting durable tie: kinship, marriage, or mutual strong-like attitude;
- at least two qualifying committed support events on different cycles;
- recognition of the candidate by every person required for that founding core.

Qualifying support events:

- accepted gift/help;
- loan provision;
- favour fulfilment.

Debt/favour existence alone is insufficient.

Formation creates one persistent household identity plus a `FormationWarrant` recording founding core, dwelling, supporting ties/events, recognition evidence, the earliest retained sustaining-organization evidence used by the warrant, and formation/reification time.

The history must therefore distinguish when the lower-level sustaining organization began developing from when sufficient evidence caused H to be recognized/reified.

Successful formation also creates a provenance-bearing `SustainingParticipant` association for every person in the founding core, supported by that `FormationWarrant`.

The founding-core participants directly recognize the resulting household from the formation event. Outsiders do not automatically recognize H; they require valid observation/communication evidence.

### 7.3 Household association

There is no authoritative universal Members set.

v0 uses provenance-bearing `SustainingParticipant`.

### 7.4 Participation change after formation

A nonparticipant may become a `SustainingParticipant` of an **Active** household H, or an **Inactive** H with exactly one live continuity bearer, only through an explicit bilateral participation proposal:

- a nonparticipant may `RequestHouseholdParticipation(H)` through a current sustaining participant; or
- a current sustaining participant may `InviteHouseholdParticipation(P)`.

The named counterpart must accept. The head has no general admission authority.

At commit, a provenance-bearing `ParticipationWarrant` is required. It must establish that:

- the newcomer recognizes H;
- at least one current sustaining participant recognizes the same continuing H and serves as the continuity bridge; for an Inactive H, its sole remaining sustaining participant must be that bridge;
- newcomer and at least one current sustaining participant share residence;
- newcomer has a durable tie (kinship, marriage, or mutual strong-like) to at least one current sustaining participant;
- at least one qualifying committed support event occurred between the newcomer and a current sustaining participant after H already existed;
- newcomer and the bridging participant both recognize/accept the newcomer's participation in H's sustaining organization.

A valid `ParticipationWarrant` creates the `SustainingParticipant` association. It does not recreate or replace H.

A current sustaining participant may voluntarily `EndHouseholdParticipation(H)`. The commit creates a `ParticipationEndWarrant` and ends only that typed association.

Participation end:

- does not erase residence, kinship, marriage, debt, favour, attitude, or historical records;
- terminates that person's provision commitment to H, if any;
- vacates H's head role if that person was the current head;
- triggers household lifecycle/continuity reevaluation from the remaining sustaining organization;
- remains historically queryable.

Residence change alone does not automatically end participation.

### 7.5 Continuity

Household continuity requires an explicit historical transmission chain:

- at least one existing `SustainingParticipant` bridges prior and successor sustaining configurations;
- that bridge recognizes the successor as the same household;
- a `ContinuationWarrant` links prior state, transition evidence, and successor state.

Snapshot similarity, residence, assets, kinship, or participant overlap alone never preserve identity.

Sequential transmission may replace every founder while preserving household identity.

When the same evidence/history supports both a valid participation/continuity path to an existing non-Dissolved household and fresh formation of a new household, the valid continuity/participation interpretation takes precedence for that evidence. The same causal evidence bundle cannot simultaneously continue H and found a duplicate H2. This does not prohibit a separately warranted overlapping organization based on distinct evidence.

Residence, resources, attitudes, marriage changes, representative succession, and one-by-one participant replacement do not by themselves break identity when a valid continuity chain exists.

### 7.6 Lifecycle

For v0, participant count determines **operational lifecycle state only**. Household numerical identity remains grounded in its historical warrants.

- **Active:** 2 or more current `SustainingParticipant` associations.
- **Inactive:** exactly 1 current `SustainingParticipant`, who is the live continuity bearer.
- **Dissolved:** 0 current `SustainingParticipant` associations.

Inactive may reactivate through a valid `ParticipationWarrant` bridged by its sole bearer. Dissolved cannot reactivate as the same identity.

Lifecycle state is evaluated/published only at stable cycle closure after compatible participation changes and their required continuity reactions have resolved. Transient within-cycle participant counts are historical microstate, not authoritative lifecycle state.

### 7.7 Controlled lineage and derivation

Lineage is historical derivation, not numerical identity.

A newly formed household may receive at most one authoritative, rule-versioned `LineageWarrant` as an automatic consequence of its already-valid `FormationWarrant`.

A `LineageWarrant`:

- never creates the successor household;
- never substitutes for ordinary formation;
- never preserves a predecessor's numerical identity;
- has no independent behavioral power in v0;
- transfers no resources, claims, obligations, authority, recognition, roles, residence, attitudes, pending processes, or lifecycle state.

Person-level relations persist only through their own semantics.

#### 7.7.1 Warrant contents and direct lineage

A successful warrant records:

- stable warrant ID;
- successor Household ID;
- successor FormationWarrant ID;
- lineage kind: `DivisionDescendant` or `ConsolidationDescendant`;
- unordered set of direct predecessor Household IDs;
- founder-lineage sources, each containing founder ID, predecessor Household ID, and supporting `ParticipationEndWarrant` ID;
- fresh organizational-evidence event reference(s);
- commit `Cycle, ReactionIndex`;
- rule/configuration version.

There is zero or one `LineageWarrant` per successor FormationWarrant.

For every direct predecessor in the warrant, `DerivedFrom(successor, predecessor)` is a rebuildable projection of that warrant rather than separate semantic authority.

A separately named `AncestorOf(ancestor, descendant)` query may compute transitive ancestry over direct lineage edges. Direct derivation and transitive ancestry must remain distinguishable.

Direct lineage must be:

- irreflexive;
- acyclic;
- temporally forward: predecessor household and cited predecessor events must precede successor formation.

If more than one predecessor-set/kind interpretation is equally valid under the v0 classifier, no lineage warrant is issued. The household still forms normally.

No authoritative `DivisionTransformation` or `ConsolidationTransformation` object exists in v0. Such labels may be generated as derived historical summaries only.

#### 7.7.2 Founder lineage sources

Lineage provenance comes only from explicit ended predecessor participation.

For each successor founder used by the lineage classifier:

- the founder must have a relevant `ParticipationEndWarrant` for the claimed predecessor;
- the warrant records that specific founder -> predecessor source;
- overlapping or other household histories do not create a global exclusivity rule;
- if those histories make the predecessor-source mapping ambiguous for the controlled v0 classifier, no lineage warrant is issued.

#### 7.7.3 Fresh organizational evidence

Former participation alone is insufficient for controlled v0 lineage.

**Division descendant:** at least one qualifying ordinary person-person support event used as fresh lineage evidence must occur after all `ParticipationEndWarrant` events used as lineage sources for the successor founders.

**Consolidation descendant:** at least one qualifying ordinary person-person support event must occur after both predecessor households are Dissolved and must be cross-predecessor: one participant maps to each predecessor.

Household-originated support feedback cannot satisfy this fresh-lineage condition.

This freshness rule affects only the v0 lineage classification. A household that independently satisfies ordinary formation may still form even when no lineage warrant is issued.

#### 7.7.4 Controlled division

For the v0 division proof:

- predecessor H remains the same numerical H on one branch only through the existing continuity mechanism;
- H must remain non-Dissolved when descendant H2 forms;
- every H2 founder must map unambiguously to ended participation in H;
- H2 must independently satisfy ordinary formation;
- the fresh division evidence rule above must hold;
- H2 receives one `LineageWarrant` of kind `DivisionDescendant` with direct predecessor set `{H}`;
- only H2 has `DerivedFrom(H)`; continuing H does not derive from itself;
- branch size, assets, residence, or graph overlap never determine continuation or lineage.

The controlled v0 case covers one continuing H and one new descendant H2. Multiple descendants, disputed successor claims, absorption, and general reconsolidation remain deferred.

#### 7.7.5 Controlled consolidation

For the v0 consolidation proof:

- H1 and H2 are independent predecessor households;
- both H1 and H2 must be Dissolved before H3 forms;
- every H3 founder must map unambiguously to ended participation in H1 or H2;
- at least one H3 founder must map to each predecessor;
- H3 must independently satisfy ordinary formation;
- the fresh cross-predecessor evidence rule above must hold;
- H3 receives one `LineageWarrant` of kind `ConsolidationDescendant` with unordered direct predecessor set `{H1,H2}`;
- H3 is a new numerical identity; neither H1 nor H2 continues as H3.

If a predecessor remains Active/Inactive, if founders have mixed/ambiguous origins outside this controlled scope, or if fresh cross-predecessor evidence is absent, H3 may still form normally but receives no controlled-v0 consolidation lineage classification.

#### 7.7.6 Lineage persistence and observation

A committed `LineageWarrant` is immutable historical provenance within one simulation run and remains queryable even if predecessor or successor households later dissolve.

The warrant is evaluated from authoritative world history after successor formation and retains the rule/configuration version used. A later offline reinterpretation under a different model version is a separate analysis result, not a rewrite of the original run.

v0 introduces no separate subjective `RecognizesLineage` state because no current action depends on lineage recognition. Actors learn relevant predecessor/formation events only through ordinary participation, observation, or communication.

Lineage is evaluated as a causally downstream reaction to successor formation. Cycle-level division/consolidation summaries are published only at stable cycle closure.

These are controlled v0 proof semantics, not a general theory of inheritance, fission, merger, absorption, or organizational ancestry.

## 8. Grounded household capability and head role

### 8.1 Provision commitment

`HouseholdProvisionCommitment(Person -> Household)` gives conditional access to personal grain without transferring ownership before spend.

- person's grain remains personal until a collective effect commits;
- exposed capacity = `max(0, grain - 2)`;
- `NeedsGrain` exposes 0;
- `SustainingParticipant` alone grants no grain access;
- commitment is explicitly accepted;
- dissolution terminates commitments; unspent grain remains personal.

Household mobilizable capacity is derived from current commitments.

For one expenditure, allocation is determined atomically at precommit revalidation:

1. compute every currently valid contributor's exposed capacity;
2. sort contributors once by exposed capacity descending;
3. stable semantic person ID orders exact capacity ties;
4. debit each contributor up to that validated capacity in the fixed order until the expenditure is fully funded;
5. if total validated capacity is insufficient, the expenditure cannot commit;
6. do not rerank contributors while executing the same expenditure.

The resulting debit vector is part of semantic history. The stable-ID step is a disclosed technical fallback, not a social priority.

#### 8.1.1 Transaction-specific office-holder private supplementation

A permitted Household material action with total material cost `C` may carry an optional transaction-specific private contribution personally authorized by the current valid head P.

Let that exact private contribution be `X`.

- absence of the private-supplement term means no private contribution;
- when present, `X` is a strictly positive integer and `X <= C`;
- P must separately have valid role authority for the Household action and personal authority over the contributed grain;
- P's current disposable private capacity for this purpose is bounded by the existing protected-reserve / `NeedsGrain` rules;
- the remaining commitment-backed funding requirement is exactly `R = C - X`;
- `R` is funded through currently valid `HouseholdProvisionCommitment` relations under the existing fixed-rank allocation rule.

The private contribution is a transaction term, not a second funding source competing under a global priority rule.

`MobilizableCapacity(H)` remains derived only from persistent provision commitments. P's wealth, possible willingness to contribute, or a transaction-specific `X` does not become standing Household capacity.

The private contribution:

- creates no persistent `HouseholdProvisionCommitment`;
- creates no Household-owned balance;
- transfers no ownership before the Household effect commits;
- consumes no extra personal initiative;
- opens no self-directed response context;
- is not a separate Gift, Help, Loan, or favour-bearing personal action.

If P also has a persistent provision commitment to H, the same grain may not be counted twice. For this transaction, P's effective commitment-side exposed capacity is the ordinary exposed capacity remaining after accounting for `X`. The fixed-rank commitment allocator applies to `R` using that residual capacity for P and ordinary live capacities for other contributors.

The funding split is exact. If P's live disposable capacity falls below `X`, if valid commitments cannot fund `R`, or if another action-relevant precondition fails before commit, the whole Household action fails ordinary revalidation/atomicity. The engine does not silently shrink/increase `X`, substitute a successor, or renegotiate the split in the same cycle.

For a successful commit, history must preserve distinct provenance for:

- total cost `C`;
- P's explicit private authorization `X`;
- P's actual private debit;
- residual requirement `R`;
- each commitment-backed contributor/debit, including any separate commitment-backed debit from P;
- the Household/head authority that made the action valid.

A single material delta for P may aggregate the final personal-grain change, but funding provenance must still distinguish the private and commitment-backed legs.

Transaction-specific private supplementation cannot serve as independent person-person support evidence for Household formation, participation, continuity, or lineage. It creates no extra ordinary-transfer attitude/favour consequence. For mediated marriage, the already accepted groom->mediating-head favour remains the only route-specific favour created by the transaction.

### 8.2 Provision reconsideration

Head may ask a non-contributing sustaining participant to reconsider.

After refusal, another request requires:

- 3 full cycles elapsed; and
- relevant context change since refusal: person's grain/NeedsGrain, attitude toward head, head occupant, or new household material need.

### 8.3 Permitted collective material uses

Only:

- 1-grain support to a needy `SustainingParticipant`;
- mediated-marriage dowry.

A needy sustaining participant who recognizes the current head may request household support; the head may also proactively propose such support.

No generic household spending authority exists.

Household-originated support cannot serve as independent proof of household formation/continuity.

### 8.4 Household head role

Each household has one persistent `HouseholdHeadRole`, vacant or occupied by one person.

New household begins headless.

- any current `SustainingParticipant` may nominate a current `SustainingParticipant`;
- an outgoing head may nominate a successor before vacating.

Appointment/succession requires:

- nominee acceptance;
- unanimous acceptance/recognition by current sustaining participants.

Role scope:

- request provision commitment/reconsideration;
- authorize permitted household material uses;
- receive/resolve household-mediated marriage proposals;
- participate in succession.

For an otherwise-valid permitted Household material use, the current holder may additionally act in their distinct private-owner capacity to attach the transaction-specific private contribution defined in §8.1.1. This is personal property consent carried by the same person, not an office power over private grain.

The role cannot seize personal grain, command residence or ordinary personal actions, arbitrarily create kinship/debt/favour, alter attitude, or exercise general sovereignty.

Appointment/succession participants directly recognize the resulting head-role state. Outsiders update head recognition only through valid observation/communication.

### 8.5 Household decision mode

Occupied role activates `HouseholdDecisionContext(H, head=P)`.

- P keeps one personal initiative;
- H gets one separate household initiative through P;
- household concerns score separately from P's personal concerns;
- role/household provide authority and household-scoped records;
- cognition and non-office subjective knowledge remain tied to P;
- an optional §8.1.1 private-supplement term is P's explicit personal-property authorization inside that one Household action, not a second personal initiative or response context;
- the decision/history trace must distinguish institutional action authority from P's private-resource consent;
- vacant role produces no household initiative.

v0 household-mode concerns:

- relieve eligible NeedsGrain;
- evaluate/fund mediated marriage;
- request provision backing/reconsideration.

Household collective action requires an **Active** H, an occupied head role, authority in scope, and sufficient valid transaction funding. Transaction funding may consist of persistent commitment-backed allocation plus an optional exact current-holder private contribution under §8.1.1. Household existence alone is not capability.

Vacancy preserves household identity and provision commitments but suspends household-mode spending/marriage mediation. An Inactive household likewise has no household-mode initiative until it becomes Active again.

## 9. Temporal / resolution / history contract

Debt social-due review occurs after ordinary proposal resolution and repayment opportunities in the **third subsequent full cycle** after the loan commits. Thus a loan committed in cycle N is reviewed after cycle N+3 decisions/commits. If any balance remains, the one-time relationship effect in §3.3 fires. No additional default/enforcement state is created.

### 9.1 Time

Use integer `Cycle` plus same-cycle `ReactionIndex`.

Cycle order:

1. exogenous inputs;
2. maintenance: consumption, due attitude decay, cooldown eligibility;
3. derived refresh;
4. common committed decision snapshot;
5. personal/household deliberation;
6. responses;
7. priority/conflict resolution + revalidation;
8. commit/failure;
9. automatic semantic reactions to closure;
10. publish/evaluate stable cycle-level state, record/refresh, and advance.

**Stable-cycle rule:** authoritative commits inside the cycle are immediately usable by central revalidation and automatic causal reactions, but they do not create a new actor-visible completed cycle state. Cycle-level classifications/summaries and next-cycle actor-visible state are evaluated/published only after resolution/reaction closure. Intermediate microsteps remain inspectable history. No same-cycle voluntary reactivation or checkpoint occurs before stable closure.

### 9.2 Revalidation and conflicts

Every proposal is revalidated immediately before commit against **all action-relevant preconditions**, including applicable participant/status eligibility, relations/claims, household/head validity, provision/capacity, grain, and cooldown state.

Only commitments whose semantics explicitly authorize/reserve current capacity receive material commitment priority. Debt/favour do not automatically reserve grain.

For competing household provision use:

1. eligible NeedsGrain support;
2. other valid household provision expenditure;
3. ordinary voluntary personal transfer.

A transaction-specific private supplement does not reserve grain at deliberation. The explicit amount `X`, P's live disposable capacity, the residual commitment requirement `R = C - X`, and all commitment allocations are revalidated together at precommit. The private term is part of the Household action in the same provision-priority class as that action; it is not a separate personal transfer. No global “commitment first” or “private first” priority exists because the agreed `X` partitions the transaction cost before commitment allocation.

Equal-priority unresolved symmetry uses disclosed stable-ID technical fallback.

Accepted but incompatible proposals may fail as `InvalidatedAtResolution`; this is not social refusal.

**Residence conflict.** After ordinary revalidation, all valid accepted effects that would change the same person's Residence in the same cycle form one conflict set. At most one may commit. Apply any accepted semantic/domain priority first; if none distinguishes the contenders, treat them as equal-priority unresolved alternatives and use the existing disclosed stable-ID technical fallback, recording fallback use. Every non-winning accepted contender terminates as `InvalidatedAtResolution(CompetingResidenceTransition)`. A committed Residence transition does not authorize a second Residence transition for that person in the same cycle.

**Atomic explicit bargain revalidation.** Favour-slot availability is an action-relevant precondition of `ExplicitBenefitForFavor`. If that capacity is lost after acceptance but before commit, the whole bargain is `InvalidatedAtResolution(FavourCapacityFull)`; neither the material benefit nor the new favour partially commits.

If a valid same-cycle `ParticipationWarrant` explicitly depends on sustaining participant P as its continuity bridge and P also has an accepted participation-end proposal, resolve the bridged entry and its continuity reaction before P's exit. This is a narrow causal-handoff priority, not a general rule that entry outranks exit.

**Authority-use before authority destruction.** If two accepted same-cycle attempts arise from the same committed decision snapshot, and one otherwise-valid attempt depends on current head/Household authority or current institutional status that the other accepted transition would destroy, resolve the authority/status-dependent attempt first. Then resolve the authority/status-destroying transition normally.

This is a narrow v0 causal precedence permitting a valid last act before departure, vacancy, succession, or operational-status loss. Immediately before the protected attempt commits, every other action-relevant precondition still revalidates normally, and any more-specific accepted semantic/domain priority still applies. A pending old-head action does not rebind to a successor. Proposal/container order, technical IDs, and generic technical fallback do not decide authority validity.

### 9.3 Automatic reactions

Same-cycle automatic reactions are cause-keyed/idempotent.

One cause key `(rule, triggering event, subject)` cannot produce the same transition twice.

For the direct attitude-composition rule in §3.1, cause-key idempotence applies to contribution membership: one cause key contributes its signed delta at most once. The composition batch commits one bounded attitude-state transition for that directed attitude and retains the full contributing cause-key/delta set as causal predecessors. `ReactionIndex` orders that authoritative transition relative to other consequential transitions; it does not impose a social precedence among independent member causes.

Each automatic reaction must consume/change its enabling condition or establish state that makes repeated application a no-op. Repeated production from an already-processed cause is a specification/engine error.

### 9.4 History

For each activated decision context, v0 diagnostic history retains:

- candidate actions;
- gates/exclusion reasons;
- score components/final scores;
- selected candidate;
- relevant subjective inputs.

Consequential proposal/history records retain:

- IDs;
- Cycle/ReactionIndex;
- proposer/target/role context;
- response/failure reason;
- validation/conflict result;
- committed effects;
- causal predecessors;
- rule/configuration version;
- technical-fallback marker when used.

Formation/continuation warrants, role events, provision commitments, transaction-specific private-supplement authorizations/funding legs, and lineage retain direct supporting event references.

### 9.5 Material deadlock

Report `MaterialDeadlock` when all grain producers are blocked by NeedsGrain, no available transfer can clear need, and no scheduled exogenous grain input can resolve the condition.

Do not inject rescue grain.

### 9.6 Checkpoint / continuation

Checkpoint only at stable cycle boundaries after reaction closure.

Checkpoint all future-influencing authoritative state, including subjective knowledge/recognition, household/role/provision state, cooldown baselines, pending inputs/work, identifier/order state, and rule/configuration version.

Rebuildable caches/indexes are non-authoritative.

Restore under identical inputs/configuration must reproduce subsequent authoritative semantic state and history suffix exactly.

## 10. Invariants

Mechanical verification must enforce where applicable:

- stable/resolvable live and historical references;
- no universal hidden household-membership authority;
- at most one head-role occupant;
- no dissolved household emits household-mode action;
- attitude remains within [-100,+100];
- same-cycle direct attitude-composition result is independent of member-cause enumeration;
- personal grain is a nonnegative integer;
- every grain-valued action parameter is a strictly positive integer and categorical invalid terms never reach target response;
- repayment amount never exceeds remaining debt;
- every grain change has an explicit source/sink/zero-sum transfer;
- collective expenditure debits every validated personal funding leg exactly once;
- one person's grain cannot be double-counted through both persistent commitment backing and transaction-specific private supplementation in the same expenditure;
- transaction-specific private supplementation creates no persistent commitment or Household treasury;
- provision/private supplementation cannot penetrate protected reserve or draw from a NeedsGrain holder/contributor;
- at most one established v0 marriage per person;
- parent/child and siblings never marry;
- at most one outstanding favour per ordered pair;
- an explicit benefit-for-favour material effect and its new favour commit atomically;
- a called favour is consumed only on successful requested-action commit and a v0 called-favour payload never opens another voluntary response context;
- at most one Residence transition per person commits in one cycle;
- one automatic cause key cannot apply the same reaction twice;
- `ReactionIndex` is monotone within cycle;
- no safe checkpoint occurs mid-resolution/reaction closure.

## 11. Verification / observability expectations

Roadmap Stage 3 must translate this specification into executable scenarios covering at minimum:

- formation and each formation ablation;
- proxy-only non-formation;
- continuity with complete founder turnover;
- similarity without continuity history;
- Active/Inactive/reactivation/Dissolved;
- controlled division/consolidation;
- recognition and stale-knowledge causality;
- grounded provision/support/dowry accounting;
- no household self-confirmation;
- head appointment/vacancy/succession;
- personal vs household-mode central resolution;
- invalidation/failure knowledge;
- provision priority;
- reaction closure/idempotence, including order-independent same-cycle direct attitude composition;
- same-cycle competing Residence transitions;
- called-favour response-closed payload/commit/refusal/inability/invalidation behavior;
- grain-parameter validity and over-repayment boundaries;
- explicit benefit-for-favour full-capacity atomicity;
- communication provenance;
- MaterialDeadlock;
- stable-ID fallback sensitivity;
- exact checkpoint continuation;
- derived-state rebuild equivalence;
- decision explainability.

Stage-3 verification must additionally use:

- independent oracle/checker logic;
- metamorphic paired executions;
- threshold/cardinality boundary matrices;
- controlled causal ablations;
- always-on invariants;
- bounded valid stateful/generated histories;
- semantic mutation/fault-injection;
- scenario fixture write-set auditing;
- causal intervention checks;
- bounded progress/closure checks;
- canonical and held-out/generated variants.

Historical validation/calibration is outside this verification contract.

## 12. Explicit exclusions

SFL v0 does not decide:

- historical calibration/frequencies;
- full demographics, mortality, reproduction, inheritance;
- full economy/agriculture/property law;
- divorce/remarriage/plural marriage;
- generic friendship/reputation/trust/lying;
- general household membership;
- general fission/merger/reconsolidation/contested succession;
- deep organizations/administrative specialization;
- generic household sovereignty/spending;
- strategic multi-step planning;
- stochastic behavior;
- production persistence/storage architecture;
- scaling optimizations.

## 13. Evidence and dependencies

Relevant:

- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `architecture/accepted/ADR-0005_HOST_RUNTIME.md`
- `research/technical/TRES-0001/`
- `research/technical/TRES-0003/PASS_F_TEMPORAL_RESOLUTION_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0004/PASS_G_VERIFICATION_CLOSURE_ADVERSARIAL_REVIEW.md`
- `research/technical/TRES-0007/LINEAGE_WARRANT_ADVERSARIAL_REVIEW.md`
- `registers/ASSUMPTIONS_REGISTER.md`
- working design record: `specifications/working/SFL_V0_WORKING_SPEC.md`

## 14. Change history

- 2026-09-21 — Accepted SFL v0 semantic specification after Passes A-G and targeted adversarial reviews TRES-0003/TRES-0004.
- 2026-09-21 — Restorative Stage-3 errata: founding-core `SustainingParticipant` creation made explicit; previously approved head-nomination eligibility restored from the closed working record. No new social rule introduced.
- 2026-09-21 — Director-approved Stage-3 semantic amendments: evidence-backed `CandidateRecognition`; bilateral invitation/request plus `ParticipationWarrant` and explicit participation end; loan social due cycle at +3 full cycles with one-time unpaid-balance attitude penalty.
- 2026-09-21 — Director-approved continuity cleanup after TRES-0006: operational lifecycle state (2+/1/0), Inactive reactivation through sole bearer, stable-cycle lifecycle evaluation, bridge-handoff priority, continuity-over-duplicate-formation precedence, and explicit two-person founding minimum. Restored compressed household authority/history details.
- 2026-09-21 — Director-approved lineage semantics after TRES-0007: one behaviorally inert LineageWarrant per successor formation at most; direct predecessor provenance distinct from ancestry; fresh organizational evidence; narrow division/consolidation classifications; ambiguity withholds lineage rather than formation; no inherited causal state.
- 2026-09-21 — Restored previously approved Pass-C information semantics lost during compression: communication initiative cost, event-provenance precedence, Contested handling, general household/role recognition action gating, outsider non-omniscience, and the mediated-marriage bride-to-household subjective route requirement.
- 2026-09-21 — Pre-rule compression-audit restorations: fixture authority/no fixed actor count; cross-boundary/anti-shortcut constraints; attitude/kinship gate separation; debt-history retention; favour non-currency limits; residence independence from marriage; exact reference-scorer/separability semantics; recognition-state meanings; head-role prohibitions; reaction-closure termination condition; all action-relevant preconditions and uncommitted-effect knowledge semantics.
- 2026-09-21 — Director-approved final Stage-3 semantic gates: fixed-rank/exhaust-in-order multi-contributor provision allocation and exact reference scorer aggregation (`FinalScore = sum(named integer components)`) with explicit semantic/domain tie handling and disclosed technical-ID fallback.
- 2026-09-21 — Director-approved TRES-0008 closure repairs: deterministic `ResponseDecisionContext` using the same exact component scorer; response feasibility precedes voluntary scoring; responses do not consume personal initiative and remain centrally resolved; removed the orphan generic commitment-breach attitude row rather than inventing a generic commitment subsystem.
- 2026-09-21 — Director-approved TRES-0010 B2 Slice-1 semantic closure: order-independent direct same-cycle attitude composition; one committed Residence transition per person/cycle with explicit conflict invalidation; response-closed called-favour payloads and commit-tied favour consumption; positive integral v0 grain action quantities with explicit validation/repayment bounds; atomic explicit benefit-for-favour under pair-capacity constraints.
- 2026-09-24 — Director-approved DEC-0010 Slice-4 authority-race closure: an otherwise-valid accepted authority/status-dependent action or role transition resolves before the accepted same-cycle transition that would destroy its required current authority/status; all other preconditions still revalidate, no pending action rebinds to a successor, and technical IDs/fallback cannot create authority precedence.
- 2026-09-24 — Director-approved DEC-0011 private-resource supplementation closure: a current valid Household head may explicitly authorize an exact transaction-specific private contribution `X` to one permitted Household material action; the residual cost `C-X` uses ordinary commitment-backed fixed-rank allocation, with standing capacity unchanged, no extra initiative/response, no double counting, and exact funding provenance.
