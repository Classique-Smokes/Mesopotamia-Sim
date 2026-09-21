# TRES-0010B — Semantic Reachability / State-Machine Audit

## Run provenance

- **Task ID:** TRES-0010B
- **Frozen baseline ref:** `tres-0010-review-baseline`
- **Resolved baseline commit:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Model/configuration:** GPT-5.6 Sol
- **Dedicated branch/workspace:** `tres-0010/b` (verified identical to the frozen baseline before this return)
- **Tools used:** GitHub repository connector for branch discovery, baseline comparison, file/tree reads, and this isolated return write
- **External web research:** no
- **Prior TRES-0003–TRES-0009 reports read:** no. No prior report file was opened. The required repository orientation file mentions the TRES-0009 closure outcome, and several verification cards cite earlier TRES artifacts, but their reports were not consulted.
- **Sibling Wave-A returns read before initial report:** **no**

## Executive finding summary

**Recommendation: BLOCK IMPLEMENTATION**

The independent reachability inventory found one formation-path blocker, two high pre-code semantic gaps, and two medium repair/guard issues.

| ID | Severity | Summary |
|---|---|---|
| B-001 | **BLOCKER_BEFORE_CODE** | `CandidateOrganization` has no defined creation/identity/equivalence/consumption lifecycle, so household formation requires invented semantics and can duplicate from the same evidence. |
| B-002 | **HIGH_REPAIR_BEFORE_CODE** | Grain-valued actions do not define a positive/nonzero quantity domain; zero/invalid transfers can satisfy social consequences and formation-support rules unless implementation invents gates. |
| B-003 | **HIGH_REPAIR_BEFORE_CODE** | The accepted fixture boundary permits actor arrival/departure, but departure has no defined world/agency/relationship/household consequences. |
| B-004 | **MEDIUM_AMEND_OR_GUARD** | Continuity requires explicit `ContinuationWarrant` transmission, but the exit-side transition/warrant obligation is not directly nailed down or mechanically covered. |
| B-005 | **MEDIUM_AMEND_OR_GUARD** | Controlled-lineage freshness is underdetermined when a founder exits, rejoins the same predecessor, and exits again because no rule selects the relevant `ParticipationEndWarrant`. |

No finding depends on historical-realism interpretation.

## Compact reachability matrix

| Semantic object / transition | Create / enter | Mutate / progress | Satisfy / terminate | Automatic / visibility | Failure / stuck | Verification status |
|---|---|---|---|---|---|---|
| Person identity | fixture / arrival boundary | objective fields | no death in v0 | actor knows own objective state | departure semantics undefined | **Gap: B-003** |
| Grain | fixture, Farm, transfers, exogenous resource change | consume / transfer / spend | n/a | explicit source/sink history | no negative grain; quantity domain incomplete | **Gap: B-002** |
| `NeedsGrain` | missed consumption | persists | clears at >= next 1-grain unit | blocks Farm | `MaterialDeadlock` explicit | Strong |
| Attitude | fixture + listed event effects | event updates + 5-cycle decay | no terminal state | bounded [-100,+100] | can decay to 0 | Strong |
| Kinship | fixture | none in v0 | none in v0 | direct parties know relation | no generation/deletion by design | Strong |
| Debt | successful loan | partial repayment | remaining=0 satisfies claim; history retained | N+3 due review, one penalty | no enforcement/default state by design | Strong except B-002 quantity gate |
| Favour | explicit bargain / qualified reciprocal help | call/refuse | fulfil or reciprocal cancellation | listed attitude effects | refusal leaves outstanding; no expiry by design | Strong |
| Marriage | direct strong-like or mediated route | none | no divorce/remarriage in v0 | parties know relation | rejection does not consume eligibility | Strong |
| Residence | fixture or accepted move/invite | replace relation | no special terminal state | direct interaction knowledge | no household effect by itself | Strong |
| `KnownFact` / Recognition | direct state/participation, observation, communication | provenance ordering / contest | newer evidence can displace | causal action gates | stale/Contested can persist | Mostly strong |
| `CandidateOrganization` | **not defined** | “may collect evidence” only | **not defined/consumed** | no authority | can persist/reduplicate | **Blocker: B-001** |
| `CandidateRecognition` | evidence-backed inference | evidence may stale/contest | no explicit post-formation disposition | candidate label cannot self-confirm | depends on undefined candidate lifecycle | **Blocker-linked** |
| Household / `FormationWarrant` | formation predicate + founder recognition | identity persists via warrants | Dissolved cannot reactivate | founders directly recognize H | duplicate-formation prevention incomplete at candidate layer | **Blocker-linked** |
| `SustainingParticipant` | formation or ParticipationWarrant | explicit entry/exit | `ParticipationEndWarrant` | entry/exit affects lifecycle/head/provision | residence alone does not edit | Strong |
| `ContinuationWarrant` | transmission across sustaining configs | chained through turnover | stops at dissolution | identity evidence | exit-side obligation under-specified/test-light | **Gap: B-004** |
| Lifecycle Active/Inactive/Dissolved | stable-closure participant count | 2+ / 1 / 0 | Dissolved terminal for same H | no mid-cycle published reclassification | Inactive can reactivate through sole bearer | Strong |
| `LineageWarrant` | post-formation automatic classifier | immutable historical provenance | persists | no behavioral power | ambiguity suppresses classification | **Gap: B-005** |
| Provision commitment | head request + acceptance | derived capacity changes with grain/need | participant exit or dissolution | backs only scoped household spend | reconsideration after refusal is gated | Strong |
| Head role | H starts vacant; nomination/acceptance/unanimity | succession | vacancy via occupant exit/succession | direct participants recognize result | inactive/vacant H no household initiative | Strong |
| Personal/household/response contexts | stable committed snapshot | score/gate/select | proposal or no initiative | full decision traces | responses do not consume initiative | Strong |
| Proposal outcomes | submission + response | central revalidation | commit / Declined / Unable / Invalidated | bounded direct-participant knowledge | no same-cycle retry | Strong |
| Automatic reactions | committed causes | monotone ReactionIndex | semantic closure/no-op | cause-keyed/idempotent | loop is engine/spec error | Strong |
| `MaterialDeadlock` | deadlock predicate | report only | exogenous future input excludes classification | explicit diagnostic | no rescue grain | Strong |
| Checkpoint/restore | stable boundary only | exact continuation | n/a | all future-influencing state | mid-closure checkpoint forbidden | Strong |

## Detailed findings

### B-001 — CandidateOrganization lifecycle and equivalence are missing

- **Classification:** missing semantic rule / verification weakness
- **Severity:** **BLOCKER_BEFORE_CODE**
- **Evidence:**
  - `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §6.3 defines `CandidateRecognition(C)` for a pre-household candidate and says candidate existence/label cannot count as evidence for itself.
  - §7.1 says a `CandidateOrganization` “may collect formation evidence” but gives no creation trigger, semantic identity/equivalence rule, founder-core mutation rule, successful consumption/termination rule, or stale-candidate retirement rule.
  - §7.2 requires every required founder to recognize the same candidate before a `FormationWarrant` can create H.
  - The spec also forbids a privileged `FormHousehold` command, so an implementation cannot bypass this missing state transition without changing the accepted model.
  - ADR-0001 requires stable semantic identity not to be derived casually from mutable content.
  - `FORMATION_FAMILY.md` VS-SFL-001 refers to `CandidateABC` and asserts exactly one H, but never proves how that candidate came into existence or why an equivalent duplicate candidate cannot exist.
- **Smallest counterexample / failure trace:**
  1. A and B are co-resident, durably tied, and have two qualifying support commits on distinct cycles.
  2. Their subjective evidence is sufficient for formation recognition.
  3. There is no accepted rule that creates the `CandidateOrganization` to which `CandidateRecognition` must attach. Formation is therefore unreachable unless code/harness invents a candidate-construction rule.
  4. If implementation instead creates two candidate records C1 and C2 over the same A/B core and the same evidence, both can independently satisfy the written recognition predicate.
  5. Nothing in the accepted candidate semantics consumes/equates C1/C2 or forbids two FormationWarrants/H identities from the same causal bundle. Cause-key idempotence does not solve this if the candidate subject IDs differ.
  6. Even a single successful candidate has no explicit consumed/retired state, so a level-triggered formation detector risks retriggering in later closures unless implementation invents a terminal rule.
- **Why existing authority does not answer it:** the continuity-over-duplicate-formation precedence rule applies once a non-Dissolved H already has a valid continuation/participation interpretation. It does not define pre-household candidate equivalence or same-evidence duplicate suppression.
- **Consequence if ignored:** the first core architectural claim—household emergence from lower-level evidence—either cannot run autonomously or depends on hidden implementation choices about candidate identity. Different implementations can legitimately produce zero, one, or multiple households from the same accepted history.
- **Recommended disposition:** amend accepted semantics before code with a minimal candidate-hypothesis rule covering construction, semantic equivalence/deduplication, allowed founding-core/evidence scope, and terminal consumption/retirement after formation. Add a duplicate-candidate / repeated-closure verification card.
- **Confidence / uncertainty:** **high**.

### B-002 — Grain-valued action quantities lack a semantic validity domain

- **Classification:** missing semantic rule / verification weakness
- **Severity:** **HIGH_REPAIR_BEFORE_CODE**
- **Evidence:**
  - SPEC §3.3 creates debt from a loan amount and permits partial/complete repayment.
  - §4 uses a proposed dowry amount.
  - §5 requires Gift/Help, Loan, RepayDebt and other transfer meanings.
  - §7.2 counts accepted gift/help and loan provision as formation-support evidence.
  - §10 prevents negative personal grain but does not define transfer/dowry/repayment amounts as strictly positive integers or forbid zero-value effects.
  - `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` and `PROVISION_GROUNDING_FAMILY.md` exercise positive quantities only; the cross-cutting boundary matrix does not test transfer amount 0/negative or repayment > remaining claim.
- **Smallest counterexample / failure trace:**
  1. A submits `OfferGift(A -> B, 0)`; B accepts.
  2. No accepted categorical rule states that amount 0 is invalid.
  3. The accepted-gift relationship consequence can therefore apply B -> A +10.
  4. The event also matches the named qualifying support-event category for formation.
  5. Repeat on a distinct cycle and a candidate can satisfy the two-event formation gate without material support ever occurring.
  6. Analogous malformed loan/repayment/dowry amounts can create zero/negative claims or undefined overpayment behavior unless code invents validation.
- **Why existing authority does not answer it:** “grain claim”, “transfer”, “repayment”, and positive examples strongly suggest the intended domain, but no required artifact makes the gate normative.
- **Consequence if ignored:** formation, attitude, debt, favour, and material-accounting semantics can be satisfied by degenerate inputs; independent implementations may choose different hidden quantity guards.
- **Recommended disposition:** define a shared `GrainAmount` semantic domain and per-action constraints (at minimum strictly positive transfer/dowry/loan/repayment amount; repayment <= remaining claim; no zero-value event can count as social/material support). Add zero/negative/overpay boundary cards.
- **Confidence / uncertainty:** **high-medium**; a future concrete type could enforce this, but that rule is not present in the frozen accepted semantic baseline.

### B-003 — Actor departure is accepted as an input but has no state-machine consequences

- **Classification:** missing semantic rule / implementation hazard
- **Severity:** **HIGH_REPAIR_BEFORE_CODE**
- **Evidence:**
  - SPEC §1.1 explicitly permits scenario-harness actor arrival/departure as bounded exogenous input.
  - §2.1 defines persistent people but no present/absent/alive/active-in-world state.
  - §7.4 makes household participation exit an explicit endogenous `EndHouseholdParticipation(H)` commit with precise head/provision/lifecycle consequences.
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md` includes controlled exogenous arrival/departure in generated-history operation vocabulary.
- **Smallest counterexample / failure trace:**
  1. Active H has A/B; A is head and has a provision commitment.
  2. Harness injects the explicitly allowed exogenous event “A departs”.
  3. Accepted artifacts do not say whether A remains eligible for deliberation/responses, whether A's relationships/debts/favours remain live, whether `SustainingParticipant(A,H)` persists, whether head occupancy vacates, whether provision commitment terminates, or whether pending proposals are invalidated.
  4. Treating departure as an implicit household-participation end would bypass the explicit voluntary participation-end semantics; treating it as no semantic change leaves a departed actor causally active.
- **Why existing authority does not answer it:** no required context artifact defines departure as merely a residence move, scheduler deactivation, world-boundary removal, or explicit bundle of domain transitions.
- **Consequence if ignored:** generated histories and fixture behavior are not reproducible across implementations and can silently violate household/head/reference invariants.
- **Recommended disposition:** before code, either (a) define the minimal actor-presence/departure semantics and their interactions with pending work/relations/households, or (b) explicitly remove/forbid actor departure from SFL-v0 executable inputs until that semantic layer exists.
- **Confidence / uncertainty:** **high**.

### B-004 — Exit-side continuity can pass lifecycle tests without proving the required transmission warrant

- **Classification:** verification weakness / missing transition detail
- **Severity:** **MEDIUM_AMEND_OR_GUARD**
- **Evidence:**
  - SPEC §7.5 says household continuity **requires** an explicit historical transmission chain and a `ContinuationWarrant` linking prior state, transition evidence, and successor state.
  - §7.4 says participation end triggers lifecycle/continuity reevaluation.
  - §7.6 then publishes Active/Inactive/Dissolved from current sustaining-participant count at stable closure.
  - `CONTINUITY_TURNOVER_FAMILY.md` strongly checks entry-side `ParticipationWarrant -> SustainingParticipant -> ContinuationWarrant` in VS-SFL-010, but VS-SFL-012's 2-person Active -> 1-person Inactive transition asserts same H identity without explicitly requiring a new exit-side `ContinuationWarrant` for B's departure.
- **Smallest counterexample / failure trace:**
  1. H is Active with A/B.
  2. B validly ends participation.
  3. A remains, so count-based lifecycle publishes H Inactive.
  4. A defective implementation preserves the same H ID solely because the record still exists and emits no `ContinuationWarrant` for the A-bridged successor sustaining configuration.
  5. The core VS-SFL-012 terminal assertions can still be satisfied unless the oracle explicitly demands the exit-side warrant.
- **Why existing authority does or does not answer it:** the semantic requirement exists, so this is not a request for a new identity theory. What is missing is a crisp transition obligation and direct verification that count/lifecycle state cannot substitute for the warrant chain.
- **Consequence if ignored:** the implementation can reintroduce snapshot/record persistence as hidden identity authority while appearing to pass lifecycle tests.
- **Recommended disposition:** state explicitly that every participation configuration change that preserves a non-Dissolved H must close with the required ContinuationWarrant (or define narrower exact cases), then assert it in Active->Inactive and exit-only continuity cards.
- **Confidence / uncertainty:** **medium-high**.

### B-005 — Rejoin/re-exit histories make lineage freshness depend on an unstated ParticipationEndWarrant selection rule

- **Classification:** harmless-to-behavior semantic ambiguity / verification weakness
- **Severity:** **MEDIUM_AMEND_OR_GUARD**
- **Evidence:**
  - SPEC §7.4 allows any nonparticipant to re-enter a non-Dissolved household through a new valid ParticipationWarrant; it does not exclude former participants.
  - §7.7.2 requires a “relevant `ParticipationEndWarrant`” for each claimed founder -> predecessor source.
  - §7.7.3 defines fresh division evidence as support occurring after all ParticipationEndWarrant events **used as lineage sources**.
  - No rule requires the latest qualifying end from that predecessor or says how multiple same-founder/same-predecessor end warrants are disambiguated.
  - `LINEAGE_FAMILY.md` has ambiguity controls across predecessor mappings, but no exit -> rejoin -> exit case.
- **Smallest counterexample / failure trace:**
  1. C exits H, producing PE1.
  2. C validly rejoins H.
  3. A qualifying support event S occurs.
  4. C exits H again, producing PE2.
  5. C later helps found H2.
  6. If lineage cites PE1, S is post-exit fresh evidence; if it cites PE2, S is pre-exit and not fresh. Both warrants map C to the same predecessor H, so predecessor-set ambiguity alone does not choose between them.
- **Why existing authority does not answer it:** “relevant” is not operationalized, and the ambiguity-suppression rule is phrased around predecessor-source mapping rather than multiple warrant instances for the same source.
- **Consequence if ignored:** two conforming classifiers can disagree on DivisionDescendant for the same authoritative history. The effect is provenance/classification only in v0, not current behavior.
- **Recommended disposition:** specify a deterministic semantic rule such as latest ended participation before successor formation, or classify multiple qualifying same-source end warrants as ambiguity and withhold lineage. Add a re-entry lineage control.
- **Confidence / uncertainty:** **high-medium**.

## Attempted attacks that did not expose a defect

1. **Debt due-cycle / repayment race:** the accepted ordering is sufficiently explicit. A loan at N is reviewed only after N+3 decisions/commits; a repayment in that cycle can clear the claim before review; the unpaid-balance attitude effect is one-time. The lower-level family verifies the relevant boundaries.
2. **Favour lifecycle:** creation routes, one-per-ordered-pair cardinality, fulfilment, voluntary refusal persistence, impossibility handling, and reciprocal cancellation provide a coherent lifecycle. No expiry is an explicit v0 choice, not an orphan.
3. **Marriage versus residence/household identity:** direct strong-like and mediated routes remain distinct; rejection does not consume eligibility; marriage does not move residence automatically; mediated marriage is gated by subjective bride->H/H/head evidence and provision backing.
4. **Provision double-spend / dual-mode conflict:** fixed-rank provision allocation, protected reserve, central revalidation, and support > other household spend > personal transfer priority are mutually consistent and have direct cards.
5. **Failure semantics / reaction closure:** `Declined`, `Unable`, and `InvalidatedAtResolution` remain distinguishable; failed attempts do not leak unbounded state or trigger refusal penalties incorrectly; cause-key idempotence and stable-boundary closure are directly exercised.

These constitute more than three materially distinct falsification routes beyond the successful findings.

## Places the accepted artifacts did not let this review determine a unique answer

- **Generic event observation:** §6 permits “valid event-specific observation” but does not define a general observer-eligibility model. Canonical verification can currently proceed through direct participation/communication, so this was not promoted to a blocker.
- **Disconfirming collective recognition with no replacement occupant:** the three-state recognition model is enough to gate positive authority, but the exact state update when an actor receives decisive evidence of household dissolution or a head vacancy (as opposed to succession to a new head) is not explicitly illustrated. A targeted verification card would reduce ambiguity.

## Prior-review / independence disclosure

No TRES-0003–TRES-0009 report was opened before or after this inventory. No sibling Wave-A return was read. This report therefore remains independent of both earlier detailed adversarial conclusions and current Wave-A sibling conclusions.

## Recommendation

**BLOCK IMPLEMENTATION**

At minimum, B-001 must be resolved in accepted authority before IMP-0001 dispatch because otherwise the implementation must invent the identity and lifecycle of the very pre-household object that gates formation. B-002 and B-003 should also be repaired or explicitly guarded out before executable v0 semantics are treated as closed. B-004/B-005 can be resolved with narrow amendments/tests rather than architectural redesign.
