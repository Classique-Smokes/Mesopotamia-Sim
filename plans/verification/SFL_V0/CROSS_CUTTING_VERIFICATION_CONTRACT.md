# SFL v0 — Cross-Cutting Verification Contract

**Status:** ACTIVE / ROADMAP STAGE 3  
**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001`, accepted ADRs, TRES-0004 through TRES-0007.

This file collects verification obligations that apply across scenario families so they are not reimplemented inconsistently.

## 1. Always-on invariants

Check after every committed transition/reaction closure where applicable and at every stable cycle boundary.

### Identity/reference

- all live/historical references resolve;
- stable semantic IDs do not derive from mutable content/runtime slots;
- no universal hidden household-membership authority exists;
- at most one occupant per HouseholdHeadRole;
- no Dissolved H emits household-mode action;
- Formation/Participation/Continuation/Lineage warrants reference valid historical evidence;
- direct lineage is irreflexive, acyclic, and temporally forward;
- zero or one LineageWarrant per successor FormationWarrant.

### Material accounting

- personal grain is a nonnegative integer;
- every grain-valued action parameter is a strictly positive integer;
- categorically invalid grain terms never reach target response or social failed-attempt handling;
- repayment amount never exceeds remaining debt;
- every grain delta has an explicit source/sink/zero-sum transfer;
- household provision never creates a pooled treasury;
- collective expenditure debits every validated personal funding leg exactly once;
- transaction-specific holder supplementation requires explicit current-holder private consent and never follows from office occupancy alone;
- standing Household mobilizable capacity remains persistent-commitment-derived and excludes possible/authorized one-transaction private supplementation;
- the same person's grain cannot be double-counted through persistent commitment backing and transaction-specific supplementation in one expenditure;
- protected 2-grain reserve is never penetrated by provision/private-supplement spend;
- NeedsGrain contributor/holder exposes zero provision/private-supplement capacity;
- dissolution never confiscates unspent personal grain.

### Cardinality/domain

- attitude stays within [-100,+100];
- direct same-cycle attitude composition is independent of member-cause enumeration;
- at most one established v0 marriage per person;
- parent/child and sibling pairs never marry;
- at most one outstanding favour per ordered pair;
- explicit benefit-for-favour material/new-favour effects commit atomically;
- a called favour is consumed only on successful requested-action commit and v0 payloads do not open nested voluntary response contexts;
- at most one Residence transition per person commits in one cycle;
- lineage does not inherit causal state;
- participant count controls operational lifecycle only, never identity.

### Temporal/process

- all immediate proposals reach a terminal outcome in the same cycle;
- every proposal is revalidated immediately before commit;
- no same-cycle voluntary reactivation after commit;
- ReactionIndex is monotone within cycle;
- one cause key cannot apply the same automatic transition twice;
- automatic reaction closure terminates semantically;
- no completed cycle/checkpoint is published before stable closure;
- proposed-but-uncommitted effects never become objective facts.

## 2. Boundary matrices

Every hard threshold/cardinality rule receives below/at/above or equivalent boundary coverage.

### Attitude

- strong-like gate: +74 / +75 / +76;
- mixed-sign same-cycle direct attitude causes near +100/-100, verifying sum-then-clamp rather than contribution-order clamping;
- negative strong-dislike boundary: -76 / -75 / -74 where behavior uses the band;
- dislike/neutral: -27 / -26 / -25;
- neutral/like: +25 / +26 / +27;
- saturation: attempts to update beyond -100/+100 remain bounded.

Kinship multiplication must not change stored attitude or satisfy stored-attitude categorical gates.

### Grain / provision / need

- grain action-term validation: negative / 0 / 1 and representative non-integral input for every applicable Slice-1 grain-denominated semantic ingress;
- debt repayment amount: remaining-1 / remaining / remaining+1 where remaining > 1;
- **RepayDebt debtor reserve:** resulting debtor grain 1 / 2 / 3, verifying only the §3.3 requirement that repayment leave at least 2 grain;
- NeedsGrain clearing: grain 0 / 1;
- **household-provision contributor reserve:** contributor grain 1 / 2 / 3, verifying exposed capacity `max(0, grain-2)` without creating a generic interpersonal-transfer reserve;
- provision contributor NeedsGrain false/true at same grain;
- exact collective capacity insufficient / equal / greater than requested spend;
- transaction-specific private supplement term: absent / 1 / C / C+1 for representative cost C > 1;
- holder private disposable capacity: X-1 / X / X+1 for a fixed valid supplement X;
- same holder with both standing commitment and private X: verify commitment-side effective capacity is reduced by X before residual-cost allocation.

#### Slice-1 D4 ingress coverage

The global grain-term validity rule applies to every grain-denominated term that reaches a Slice-1 semantic action/proposal ingress. Verification must freeze each applicable ingress explicitly so one easy route cannot stand in for another.

Required current ingress classes:

- `OfferGift` grain-transfer term;
- `RequestGiftOrHelp` grain-transfer term;
- `OfferLoan` grain amount;
- `RequestLoan` grain amount;
- direct `RepayDebt(amount)`;
- `ProposeMarriage(..., proposedDowry)` term on the direct-bypass proposal shape;
- inner `CallFavor(RepayDebt(..., amount))`;
- the required Slice-1 **grain-transfer instantiation** of `OfferBenefitForFavor`;
- the required Slice-1 **grain-transfer instantiation** of relationship-mediated reciprocal help.

For BFF/RMRH, this verification requirement is **schema-neutral**. It does not require a raw scalar `amount` field on those actions. If the implementation represents the specified material benefit/help as a validated grain-transfer/material-benefit object, evidence may be structural or executable, but every grain quantity embedded in, referenced by, or required to construct that public semantic term must satisfy the same D4 validity rule before target response.

For every applicable ingress, verify:

- zero and negative terms are rejected;
- a representative non-integral term is rejected, or is structurally unrepresentable at the public semantic boundary without coercion/truncation;
- a valid positive integer reaches ordinary action-specific gates;
- invalid terms produce no material/social effect and are not `Declined`, `Unable`, or `InvalidatedAtResolution`;
- where a target response exists, invalid terms are rejected before that response context activates.

Do not infer a generic two-grain reserve from this matrix. Grain-term validity and action-specific feasibility remain separate.

### Formation / participation / lifecycle

- founding core cardinality 1 / 2 / 3;
- qualifying supports:
  - 1 event;
  - 2 events same cycle;
  - 2 events on distinct cycles;
- CandidateRecognition missing from 0/1/all required founders;
- lifecycle participant count 0 / 1 / 2;
- participation entry into Active / Inactive-with-sole-bearer / Dissolved H.

### Cooldowns / periodic timing

- provision reconsideration before three full cycles;
- exactly three full cycles with no relevant context change;
- exactly three full cycles plus relevant context change;
- attitude-decay cycle immediately before / at / after the 5-cycle cadence;
- debt social-due review before N+3 / after N+3 decisions / later cycles, ensuring one penalty only.

### Cardinality limits

- first versus second marriage attempt after establishment;
- first versus additional favour while one already exists for same ordered pair;
- full favour-slot behavior separately for ExplicitBenefitForFavor versus RelationshipMediatedReciprocalHelp;
- one versus multiple independently accepted same-person Residence transitions in one cycle.

### Lineage

- fresh division support before / after all cited exits;
- consolidation cross-predecessor support before / after both predecessor dissolutions;
- one predecessor survives versus both Dissolved;
- unambiguous versus ambiguous predecessor-source mapping.

## 3. Required metamorphic relations

Each relation states applicability conditions; do not permute inputs whose order is semantically meaningful.

1. **Storage/input iteration permutation**  
   Reorder nonsemantic collections/enumeration; semantic state/history remains equivalent.

2. **Nonsemantic ID renaming**  
   Rename IDs and compare isomorphic semantic output, except scenarios deliberately exercising the disclosed stable-ID fallback.

3. **Disconnected-population locality**  
   Add unrelated actors/households with no modeled causal connection; existing local result remains unchanged.

4. **Observer/diagnostic noninterference**  
   Enable/disable readers, tracing, rendering, explanation surfaces; semantic trajectory remains unchanged.

5. **Derived rebuild equivalence**  
   Discard/rebuild caches/indexes/projections at safe boundary; semantic result unchanged.

6. **Checkpoint metamorphism**  
   Uninterrupted versus safe-boundary restore/continue; exact authoritative suffix equality.

7. **Irrelevant-attribute perturbation**  
   Change a spec-declared irrelevant attribute while holding causal inputs fixed; decision/result unchanged.

8. **Message-arrival permutation**  
   Reorder delivery of reports while preserving underlying event provenance/order; final evidence resolution follows event order.

9. **Lineage predecessor-set ordering**  
   Reverse enumeration of {H1,H2}; consolidation warrant predecessor set remains semantically identical.

10. **Direct-attitude cause permutation**  
    Reorder nonsemantic enumeration of the same distinct direct attitude cause set for one directed pair; the contributing cause set/history and bounded final attitude remain semantically identical.

11. **Residence contender permutation**  
    Reorder nonsemantic proposal/container enumeration for the same accepted same-person Residence conflict set; with fixed semantic IDs/priorities, the committed winner, invalidated contenders, and fallback marker remain identical.

## 4. Semantic mutant set

The suite must detect or classify at least these project-specific faults:

1. form H from co-residence alone;
2. form H from one support event or two same-cycle events;
3. give all actors global household/head recognition;
4. let kinship multiplier satisfy stored-attitude gates;
5. preserve identity by overlap/similarity without valid continuity;
6. allow Inactive/Dissolved H household-mode action;
7. allow participation entry without bilateral acceptance/warrant;
8. clone H by treating its own feedback as new formation evidence;
9. inherit causal state through DerivedFrom;
10. count household support as fresh lineage evidence;
11. permit household expenditure without provision backing;
12. pool/duplicate grain or debit contributor twice;
13. penetrate reserve or draw from NeedsGrain contributor;
14. let head command out-of-scope personal action;
15. use majority instead of unanimous head appointment;
16. skip commit-time revalidation;
17. collapse Declined/Unable/Invalidated into one result;
18. penalize Unable/Invalidated as voluntary refusal;
19. leak exact/unrelated private state in failure reasons;
20. allow same-cycle retry after invalidation;
21. resolve material conflict by collection iteration order;
22. fire one reaction cause twice;
23. truncate a reaction loop and report success;
24. let stale derived cache influence behavior;
25. omit subjective/cooldown/pending/ID/config state from checkpoint;
26. let instrumentation mutate semantics;
27. let later-arriving older message overwrite newer event evidence;
28. resolve Contested recognition by arbitrary ID;
29. record only chosen action rather than complete decision trace;
30. let a rendered explanation cite a cause not supported by intervention;
31. clamp independent direct same-cycle attitude causes contribution-by-contribution so cause order changes the bounded result;
32. allow multiple same-person Residence transitions to commit in one cycle or choose the winner by container order;
33. let zero/negative/non-integral grain terms reach response/social effects or silently clamp over-repayment;
34. let a called-favour payload open a nested voluntary response, consume the favour on Unable/Invalidated, or apply fulfil/refusal attitude effects on non-voluntary failure;
35. partially commit ExplicitBenefitForFavor when required favour capacity is unavailable, or silently relabel the material leg as Gift/Help;
36. let head office authority expose private grain without explicit transaction-specific consent;
37. treat a transaction-specific private supplement as standing Household mobilizable capacity or as a persistent provision commitment;
38. double-count the same head grain through both a private supplement leg and unreduced commitment capacity in one transaction;
39. silently shrink/increase private supplement X or auto-rebalance the agreed funding split at precommit;
40. treat private supplementation as a separate Gift/Help/favour-bearing action or allow it to become formation/continuity/lineage evidence;
41. transfer/rebind an old head's private supplement authorization to a successor;
42. consume an extra personal initiative or create a self-response context for same-person private supplementation;
43. let `RepayDebt` preempt otherwise-valid higher Household provision in the bounded shared-grain conflict or treat debt acceptance as an automatic reservation;
44. let same-cycle newcomer entry retroactively expand an already-accepted appointment/succession consent cohort;
45. prohibit head-as-support-recipient solely because authorizer==beneficiary, or require a P->P support request/response;
46. create a head's persistent provision commitment from office occupancy alone, prohibit it solely because head==private owner, or manufacture P->P response theatre;
47. prohibit self-nomination categorically or drop one of nomination/nominee-willingness/participant-acceptance predicates when roles alias;
48. treat Inactive role filling as reactivation or grant Household-mode initiative merely because an Inactive role is occupied;
49. duplicate the Household funding allocator independently across resolver/dependency/commit/history surfaces so the same transaction can derive inconsistent funding participation;
50. collapse accepted funding-leg provenance into aggregate deltas/free-form detail so private and commitment-backed source authority cannot be reconstructed;
51. turn `MobilizableCapacity(H)` or another convenience cache into independent Household wealth authority;
52. make commitment/capacity/private-X state define Household identity, sustaining participation, role identity/occupancy, or Recognition identity.

Report mutant outcome as:

- detected;
- survived;
- unexercised;
- invalid/equivalent;
- crash;
- timeout.

Crash/timeout do not automatically count as semantic detection.

## 5. Bounded stateful/generated histories

Generated tests supplement canonical cards; they do not replace them.

### Operation vocabulary

Generate validity-aware bounded sequences from:

- Farm;
- gift/help request/offer;
- loan / repay;
- favour creation/call/refusal/cancellation using only semantically valid response-closed payloads unless intentionally testing invalid terms;
- residence proposal;
- communication;
- provision request/accept/refuse;
- household support;
- participation request/invite/end;
- head nomination/appointment/succession/vacancy through participation end;
- controlled exogenous arrival/departure/resource changes;
- checkpoint/reload at safe boundaries.

Lineage/division/consolidation is observed from valid generated lower-level histories; do not inject split/merge commands.

### Constraints

- generate from currently valid preconditions unless intentionally testing failure;
- generated validity classification must not silently treat production candidate/feasibility logic as the independent oracle for the rule being tested;
- bound population, cycles, outstanding proposals, and relation count;
- check always-on invariants after each stable closure;
- retain full deterministic seed/input sequence if generation tooling later uses randomness;
- shrink/minimize failures where tooling supports it;
- preserve every minimized failure as a deterministic regression fixture.

### Inherited card metadata

To avoid repetitive boilerplate, every card inherits this file's fixture-write restrictions and independent-oracle rules unless it explicitly narrows them further.

A family/card must explicitly state only:

- any additional fixture write it requires beyond the generally allowed set;
- any exception/narrowing;
- the specific hand-authored arithmetic/provenance/metamorphic oracle when that is material to understanding the claim.

This inheritance satisfies the scenario-card schema without copying the same guardrails into every card.

## 6. Fixture write-set audit

Every canonical card declares allowed fixture writes.

### Generally allowed as controlled setup/input

- person identities and basic initial objective fields;
- initial grain;
- initial kinship/marriage/residence/attitude where scenario declares them;
- subjective lower-level observations/facts when that subjective state is the controlled variable under test;
- scheduled exogenous arrivals/departures/resource changes;
- semantically valid proposal submission for mechanism-isolation cards.

### Never fixture-write when it is the outcome under test

- Household identity;
- FormationWarrant;
- ParticipationWarrant/ParticipationEndWarrant;
- ContinuationWarrant;
- LineageWarrant / DerivedFrom;
- lifecycle verdict;
- head appointment/succession result;
- provision spend result;
- final transaction-specific private-supplement authorization/result when endogenous holder choice is under test;
- actor recognition whose endogenous derivation is being tested.

Downstream cards may start from a previously verified checkpoint containing those facts.

Fixture-originated and endogenous facts/events must remain distinguishable in history.

## 7. Canonical / held-out / generated separation

Evidence reporting keeps separate:

- **canonical cards** — fully explained implementation-facing examples;
- **boundary variants** — hard comparator/cardinality tests;
- **metamorphic pairs** — relation between executions;
- **semantic mutants** — adequacy challenge;
- **generated histories** — unusual interaction sequences;
- **held-out variants** — small deterministic cases not used as the primary coding narrative.

A passing canonical set does not hide held-out/generated failures behind one aggregate percentage.

## 8. Held-out strategy

For each major family, define at least one held-out variant by changing:

- actor labels/IDs;
- nonessential relation topology;
- event ordering where semantically equivalent;
- which actor supplies the critical evidence/bridge/backing;
- threshold-adjacent values;
- irrelevant attributes.

Held-out variants must preserve the same semantic claim without copying the canonical narrative structure exactly.

### Concrete held-out recipes

Do not include these as the primary implementation narrative:

- **formation:** four-founder connected durable-tie graph with qualifying support on a different pair pattern than VS-SFL-001;
- **continuity:** turnover order reversed and bridge identities changed, ending with no original founders;
- **recognition:** stale outsider receives correction through a different participant/provenance chain;
- **provision:** same accounting claim with contributor identities/grain capacities permuted and a different needy recipient; include a held-out split-funding case where the head's X and commitment-backed remainder use different actors/capacities;
- **head/dual-mode:** different head and personal-action target with the same central conflict structure;
- **lineage:** different predecessor sizes/addresses with equivalent warrant provenance;
- **resolution:** equivalent capacity conflict produced by loan/gift/help actors rather than copying VS-SFL-065;
- **checkpoint:** checkpoint at a different stable cycle with a different combination of pending debt/cooldown/communication state;
- **lower-level fabric:** alternative actor labels and transfer meanings/order while preserving the same debt/favour/marriage/residence claim.

The implementation task packet should teach canonical cards first. Held-out instances may be materialized by the verification harness from these recipes after the implementation path exists; minimized failures become visible regression fixtures.

## 9. Independent oracle rules

Independent checkers may share:

- stable domain IDs/schema;
- recorded committed events;
- simple arithmetic;
- spec constants/configuration.

They must not call the production:

- candidate recognizer;
- continuity/lineage classifier;
- decision scorer/selector being judged;
- transition helper whose output is the assertion target;
- derived-capacity helper when capacity arithmetic itself is under test.

Prefer hand-authored expected facts, simple arithmetic, direct warrant-reference checks, and metamorphic relations.

## 10. Evidence report requirements

Stage-3/Stage-4 verification output must keep visible:

- scenario ID/configuration version;
- pass/fail;
- assertion failure with semantic cause;
- fixture-write audit result;
- invariant failures;
- mutant classification;
- fallback markers;
- checkpoint/rebuild comparison result;
- minimized generated regression ID where applicable.

## 11. Resolved Stage-3 configuration dependencies

The previously open semantic gates are resolved:

- multi-contributor provision allocation uses fixed precommit ranking / exhaust-in-order;
- reference scoring uses named exact-integer components summed to `FinalScore`;
- canonical closed-loop profiles are pinned in `REFERENCE_SCORING_PROFILES.md`.

Verification must continue to distinguish these controlled v0 choices from historical calibration or permanent cognition/accounting doctrine.


## Slice-4 resource-scaffold replaceability controls

DEC-0013 requires the current material subsystem to remain a synthetic v0 scaffold rather than a hidden future-economy commitment.

Acceptance evidence must therefore show:

1. one authoritative live funding-resolution point produces the transaction funding plan used by commit/history;
2. dependency discovery consumes declared/evaluated material participation instead of separately rediscovering funding policy;
3. funding history retains typed source/authority/debit provenance;
4. `MobilizableCapacity(H)` remains rebuildable/non-authoritative derived state;
5. changing current provision capacity to zero does not alter Household identity/role/Recognition identity;
6. no generic asset/property/ledger architecture is introduced solely to anticipate a future resource model.

Observation robustness/sensitivity work required by DEC-0013 is a later scientific-interpretation gate, not a substitute for these current executable conformance checks.
