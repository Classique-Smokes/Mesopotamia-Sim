# SFL v0 — Working Specification

**Status:** DRAFT / WORKING / NON-AUTHORITATIVE  
**Owner:** Master Architect  
**Purpose:** Accumulate converged SFL v0 semantics in implementation-oriented form while the seven-pass design process is still underway.

This is **not yet implementation authority**. It exists so decisions do not remain trapped in conversation. At the end of the pass sequence it will be compressed into the accepted SFL specification.

## 1. Implementation-contract rule

For every mechanism, the final specification must make four things explicit:

1. **Required semantics** — behavior the implementation must preserve.
2. **Forbidden shortcuts** — behavior the implementation must not infer or invent.
3. **Implementation discretion** — local representation/code choices that do not alter semantics.
4. **Observable proof** — what a test/scenario must be able to demonstrate.

An implementation agent may choose ordinary code structure inside these boundaries. It may not invent missing social rules.

---

# 2. Pass status

- **Pass A — Laboratory boundary:** WORKING-CONVERGED.
- **Pass B — Lower-level social fabric + minimal agency:** WORKING-CONVERGED.
- **Pass C — Subjective recognition + information:** WORKING-CONVERGED.
- **Pass D — Household formation + continuity:** WORKING-CONVERGED.
- **Pass E — Grounded collective capability + representative role:** ACTIVE.
- Passes F–G: not yet specified.

---

# 3. Pass A — Working-converged world boundary

## 3.1 Purpose of the laboratory

SFL v0 is a **small synthetic social-mechanism laboratory**, historically informed in its distinctions but not a miniature reconstruction of Old Babylonian Nippur.

Its foundational question is:

> Can persistent people create and alter meaningful relationships; can those histories ground a recognized household with persistent identity; and can that household persist, undergo representative succession, divide, and consolidate without becoming a primitive container or engine-only label?

## 3.2 Population

- The model has no semantic rule that a household or laboratory requires a fixed actor count.
- Initial verification fixtures should remain deliberately small; roughly **6–8 people** is the present working scale because it is large enough for overlapping/cross-cutting relations and small enough for causal inspection.
- The exact fixture count is a test choice, not a historical population claim.

## 3.3 Material layer

### Grain

**Working meaning:** fungible consumable material resource used to give lending, repayment, transfer, contribution, and scarcity concrete effects.

SFL v0 does **not** model an agricultural economy, land, seasons, prices, markets, wages, or historically calibrated yields. It does include a deliberately abstract individual **produce/farm** action that converts an action opportunity into a fixed grain increment, plus periodic grain consumption, so scarcity can be regenerated rather than only depleted.

Exact production and consumption quantities remain controlled laboratory parameters rather than historical claims.

The name **grain** intentionally points toward a later historical subsystem while the current mechanic remains minimal.

### Dwelling / place

**Working meaning:** persistent identifiable place that people may reside in.

Its purpose in v0 is to keep **residence distinct from household identity**.

SFL v0 does not yet require a full property/real-estate system. Ownership/use/claim mechanics for dwellings are not implied merely by residence and remain out of scope unless a later pass proves they are necessary.

## 3.4 Future systems represented as controlled inputs

The scenario harness may directly initialize or inject facts/events that future subsystems would eventually generate, including:

- initial kinship;
- initial marriage;
- initial attitudes;
- initial residence;
- starting grain stocks;
- initial marriages where a scenario specifically requires them, even though marriage formation is also endogenous in v0;
- actor arrival/departure;
- externally imposed resource changes;
- other bounded stimuli explicitly declared by a scenario.

This is intentional. SFL v0 tests the **social foundation**, not demography, marriage generation, production, or a complete economy.

## 3.5 Household lifecycle in scope

The common rule set must eventually support controlled scenarios for:

- formation;
- persistence through limited constituent change;
- representative-role succession;
- basic household division;
- basic household consolidation.

For v0, division/consolidation are proof cases for identity/lineage semantics, **not** a general theory of fission, absorption, merger, contested succession, or dynasty.

## 3.6 Required distinctions

The laboratory must permit these structures to disagree:

- who likes/dislikes whom;
- who is kin;
- who is married;
- who owes whom;
- who owes/holds a favour or obligation;
- who resides where;
- who is eventually recognized as connected to a household.

No one dimension automatically defines the others.

## 3.7 Forbidden shortcuts

Implementation must not:

- initialize a hidden household membership set and derive the social fabric from it;
- equate a dwelling with a household;
- equate kinship with household membership;
- equate marriage with household membership;
- equate co-residence with household membership;
- force all socially relevant ties to remain inside household boundaries;
- prevent people from maintaining relations across households;
- create household identity merely because a graph cluster or constituent list exists.

---

# 4. Pass B — Lower-level relation palette

The following is the **starting v0 social substrate**. Exact transition/action semantics are still being specified.

## 4.1 Attitude — like / dislike

- Directed and subjective: A's attitude toward B is independent of B's attitude toward A.
- Stored as a bounded integer from **-100 to +100**.
- Derived qualitative bands:
  - **-100 to -75:** strong dislike;
  - **-74 to -26:** dislike;
  - **-25 to +25:** neutral;
  - **+26 to +74:** like;
  - **+75 to +100:** strong like.
- Exists independently of objective contracts such as debt, marriage, or kinship.
- May change as a consequence of social experience.
- Rules should normally reason from broad bands/thresholds rather than inventing significance for every adjacent integer.
- Event updates use fixed v0 magnitudes defined below; they are controlled laboratory parameters rather than psychological claims.

**Forbidden shortcut:** do not convert attitude into a generic all-purpose “relationship strength” that also represents debt, kinship, marriage, obligation, or household affiliation.

## 4.2 Marriage

- Explicit continuing relation/status between people.
- Distinct from attitude, kinship, residence, and household affiliation.
- Marriage formation is **endogenous in v0** and the proposal carries its settlement terms rather than triggering an unspecified automatic settlement.
- Persons have an objective v0 sex field: **male** or **female**. Marriage uses male=groom and female=bride roles.
- An established marriage is at-most-once per person in v0. Rejected proposals do not consume this lifetime allowance.
- Divorce, widowhood, remarriage, plural marriage, reproduction, and a general marriage market are out of scope for v0.
- Working v0 has two formation routes:
  1. **Household-mediated route:** where the prospective bride is attached to a recognized household, marriage is mediated through that household rather than gated by the couple's attitude. The working intended effect is that the bride's household supplies the proposal-specified grain dowry/settlement and the groom incurs one favour obligation to that household's recognized head/representative. Exact household authority, recognition, and who commits acceptance are deferred to the household/representative passes.
  2. **Mutual strong-like bypass:** if the prospective spouses' stored directed attitudes toward one another are both in the strong-like band, they may form the marriage directly without the household-mediated dowry/favour package.
- The groom initiates a marriage proposal and names the bride plus the proposed dowry amount.
- In the household-mediated route the dowry is paid by the bride's household and lands **directly with the groom**; successful formation also creates one groom -> household-head favour.
- If the bride has no recognized household and the mutual-strong-like bypass does not apply, marriage is unavailable in v0 rather than inventing a substitute guardian rule.
- The direct bypass uses **stored attitude** only. Kinship is excluded from marriage evaluation entirely.
- Parent/child and sibling pairs are mechanically ineligible for marriage.
- Until household semantics are specified, the mediated route is a declared cross-pass dependency rather than implementation authority; collective payment must later be grounded in real constituent-backed grain rather than a fictional household stock.
- Scenarios may still initialize an existing marriage when required for a specific fixture.

## 4.3 Kinship / family

- v0 represents only **parent/child** and **sibling** kinship, initialized as scenario state rather than generated through reproduction.
- Parent/child has inverse directed roles; sibling is symmetric.
- Kinship remains distinct from attitude, residence, marriage, obligation, and household affiliation.
- Kinship influences **decision evaluation** by amplifying the behavioral weight of existing attitude toward that person: positive attitude matters more for kin and negative attitude also matters more for kin.
- Kinship does **not** modify the stored attitude value itself.
- Kinship amplification does not by itself satisfy explicit categorical gates defined on stored attitude.
- v0 uses a **1.5x multiplier** on the attitude-derived component of ordinary interpersonal decision evaluation for both parent/child and sibling relations.
- Kinship is **excluded from marriage**: it does not alter marriage proposal/acceptance scoring, cannot satisfy the mutual-strong-like bypass, and parent/child or sibling pairs are ineligible.
- The same factor is used for parent/child and sibling in v0; richer kin-type effects are deferred.

## 4.4 Lending / repayment / debt

- Debt is a **quantitative, grain-specific material claim**.
- Lending grain can create a persistent debtor-creditor relation recording creditor, debtor, original quantity, and remaining quantity.
- Repayment may be partial or complete; completion satisfies the claim without erasing its history.
- Debt does not directly compel unrelated social action and is not equivalent to dislike, dependence, household membership, kinship, or favour.
- v0 debt has **no interest, due date, or automatic default penalty**.
- Repayment is nevertheless a persistent actor concern when the debtor has sufficient material surplus.
- Grain is repayable surplus only to the extent that repayment leaves the debtor with at least **2 grain** reserved for near-term consumption.
- Knowingly retaining repayable debt produces a -10 attitude change from creditor toward debtor when the relevant failure-to-repay event is evaluated.

## 4.5 Favour / obligation

- A favour is a **qualitative, action-oriented social claim**, deliberately distinct from quantified grain debt.
- The holder may later **call in** one outstanding favour by attaching it to a specific requested action.
- A favour never bypasses physical feasibility or the proposal/resolution architecture. It creates strong social pressure/claim over a feasible choice rather than magical capability.
- A refusal must remain representable. Calling in a favour does **not** consume it merely because the debtor refuses; fulfilment satisfies it. Refusal leaves the favour outstanding and produces a substantial negative attitude consequence from holder toward debtor.
- v0 favours are discrete rather than point-valued: one favour is one outstanding claim. No exchange rate, trading, inheritance, partial favour balance, or generic social currency is implied.
- v0 permits at most **one outstanding favour per ordered person-pair**. Additional favour-creating benefits do not stack further favour tokens while one is already outstanding.
- Favours do not expire in v0.
- A favour may arise through either of two v0 paths:
  1. **Explicit bargain:** a person offers a benefit/action in exchange for one favour; the target knowingly accepts or refuses the bargain before it commits.
  2. **Relationship-mediated reciprocity:** a person accepts a beneficial action from someone toward whom they already have a sufficiently positive attitude; the accepted benefit can create one favour owed to the benefactor even though the favour was not demanded as contractual consideration. The recipient must be able to evaluate the obligation consequence before accepting the benefit.
- A genuine **gift** remains possible and creates no favour; implementation must not silently convert every beneficial transfer into leverage.
- For the working v0, “sufficiently positive” means the recipient's stored directed attitude toward the benefactor is in the **strong-like** band (currently >= +75); this threshold is a controlled laboratory assumption, not a historical claim.
- A called favour may request an ordinary action that the debtor could otherwise perform, including material or social-help actions, but it cannot make an impossible action possible or directly compel creation of an intrinsic/status relation such as kinship or marriage. **AcceptMarriage is explicitly excluded** from favour enforcement in v0.
- **Favours exclude favours:** fulfilling/calling a favour cannot generate, demand, transfer, or recursively create another favour.
- Reciprocal obligations may cancel: if A owes B one favour and B independently owes A one favour, either side may spend the favour they hold to settle the favour they owe, atomically satisfying both.
- Favours may connect people inside or across households.
- Fulfilment of a called favour gives the holder +10 attitude toward the fulfiller; refusal leaves the favour outstanding and gives the holder -20 attitude toward the refuser.

## 4.6 Material-help / transfer meanings

The v0 action vocabulary must preserve four distinct social meanings even where implementation reuses lower-level grain-transfer code:

1. **Gift** — voluntary grain transfer that creates neither debt nor favour.
2. **Loan** — grain transfer that creates a quantified grain debt.
3. **Explicit favour bargain** — a benefit/action offered in exchange for one favour, knowingly accepted before commitment.
4. **Relationship-mediated reciprocal help** — a knowingly accepted beneficial action that creates one favour only when the recipient already strongly likes the benefactor.

A generic hidden transfer mode must not erase these meanings from actor reasoning or semantic history.

## 4.7 Attitude dynamics

Committed social experience changes directed attitude using fixed v0 increments:

- accepted voluntary gift/help: recipient -> giver **+10**;
- loan granted: borrower -> lender **+5**;
- successful repayment: lender -> borrower **+5**;
- fulfilment of a called favour: holder -> fulfiller **+10**;
- refusal of an ordinary request while the requester is in genuine unmet need: requester -> refuser **-5**;
- ordinary refusal when no genuine need/accepted obligation is involved: **0** automatic change;
- refusal of a called favour: holder -> refuser **-20**;
- knowingly failing to repay while materially able: creditor -> debtor **-10**;
- breach/failure of an explicitly accepted commitment: affected counterparty -> breacher **-20**;
- rejected marriage proposal: **0** automatic change.

Natural social fading occurs on the attitude-decay event defined later by Pass F:

- positive attitude moves **2 points toward 0**;
- negative attitude moves **1 point toward 0**;
- decay never crosses 0.

Thus positive relations fade twice as fast as negative relations repair naturally. New events can reinforce or reverse direction normally.

## 4.8 Grain production / consumption

- A person may spend an available action opportunity on an abstract **farm/produce grain** action yielding **4 grain**.
- Every person consumes **1 grain per consumption cycle**.
- Typical verification fixtures begin actors with **4-8 grain**; exact starting value is scenario configuration.
- Missing required consumption creates persistent **NeedsGrain** state rather than death/health mechanics.
- While **NeedsGrain** is active, the actor **cannot Farm**. They must escape immediate need through social/resource transfer such as gift, loan, favour-backed help, or later household support.
- NeedsGrain clears once the actor again possesses at least the next required 1 grain consumption unit.
- These mechanics exist only to create renewable scarcity, dependence, and opportunity cost; they are not an agricultural subsystem.
- An actor need not emit a semantic `Wait` action merely to do nothing.

## 4.9 Residence

- Residence is an explicit relation between a person and a dwelling/place.
- Residence change is endogenous in v0 but remains separate from ownership and household identity.
- A person may propose moving to another person's current dwelling, or invite another person into their own current dwelling; the named counterpart's acceptance is sufficient in v0 even if other residents exist.
- Strong mutual positive relations create a **weaker** incentive to seek co-residence; established marriage creates a **stronger** incentive.
- Acceptance/refusal remains socially mediated; marriage does not automatically force co-residence.
- Changing residence does not by itself create, destroy, split, or merge a household.
- Property/collective consent rules are deferred.

## 4.10 Deliberate omissions at this stage

Do not add without a demonstrated need:

- generic friendship relation;
- generic “relationship strength” relation;
- primitive household membership relation used as causal ground truth;
- generic household-support relation that simply encodes the desired household in advance;
- broad status/class/office systems;
- full property-rights system.

---

# 5. Pass B — working actor/action model

## 5.1 Objective person state

The minimal v0 person state includes:

- stable person identity;
- sex: male/female;
- grain stock;
- NeedsGrain state;
- current residence;
- marriage status/history;
- explicit kinship, debt, favour, and other relation references relevant to that person.

Ageing, reproduction, health, death, class/status, profession, and personality traits are out of scope.

## 5.2 Action opportunity

- Each actor may normally initiate **one substantive voluntary action per decision cycle**.
- Responding to incoming proposals does not consume that initiative.
- An actor may initiate nothing; no semantic `Wait` action is required merely to represent inactivity.

## 5.3 Reference v0 choice policy

- The reference laboratory uses **deterministic scored choice** rather than random action selection or a rigid scripted if/else priority chain.
- The actor generates feasible candidate actions, evaluates them from current objective state, directed attitude, kinship amplification, obligations/debts, subsistence need, marriage/residence incentives, and other explicitly specified concerns, then chooses the highest-scoring candidate.
- Tie-breaking must be deterministic and semantically declared rather than dependent on collection/insertion order.
- This is a **reference policy, not a permanent architecture lock**. Action semantics and world transition rules must remain separable from actor policy so later planning, heterogeneous personalities, learned policies, or stochastic choice can replace/extend the v0 scorer without rewriting the social substrate.

## 5.4 Minimal persistent concerns

Every v0 person shares the same basic concern categories:

- maintain enough grain / resolve unmet subsistence need, while respecting the rule that NeedsGrain actors cannot farm themselves out of immediate need;
- maintain or improve positively valued relations and react to negatively valued ones;
- discharge repayable grain debt;
- respond to and discharge called favour obligations;
- seek marriage when eligible under v0 rules;
- seek co-residence where marriage or strong positive relationship supplies motivation.

Individualized personality weights and strategic multi-step planning are deferred.

## 5.5 Working action/meaning repertoire

v0 requires semantic actions sufficient to:

- `Farm`;
- `OfferGift` / `RequestGiftOrHelp`;
- `OfferLoan` / `RequestLoan` / `RepayDebt`;
- `OfferBenefitForFavor` and accept/refuse it;
- offer/accept relationship-mediated reciprocal help;
- `CallFavor`, fulfil/refuse it, or mutually cancel reciprocal favours;
- `ProposeMarriage` with explicit dowry terms and resolve it through the applicable marriage route;
- propose/respond to co-residence/residence change.

The underlying transfer/resolution code may be shared, but actor reasoning and semantic history must preserve these different social meanings. Response mechanics may be represented as proposal resolutions rather than independent initiative actions.

No subjective state beyond directed attitude is introduced in Pass B. Knowledge, observation, and household/role recognition are Pass C concerns.

---

# 6. Pass B — constraints already established

The eventual action system must satisfy:

- relationships/actions may cross household boundaries;
- actors retain individual agency after household formation;
- there is no privileged **form household**, **join household**, or **become household** action that directly produces the aggregate;
- social actions involving another actor are proposals/attempts and must respect the accepted proposal/resolution/commit architecture;
- physically impossible actions must remain distinguishable from socially unattractive, disfavoured, norm-breaking, or refused actions;
- relation history must be preserved where later state/identity depends on it.

---

# 7. Pass B closure

Pass B is **WORKING-CONVERGED**.

Remaining dependencies are assigned to later passes rather than left as Pass B ambiguity:

- attitude-decay **timing cadence** -> Pass F temporal semantics;
- exact household authority/backing for mediated marriage and dowry payment -> Passes D/E;
- objective-versus-subjective knowledge and recognition -> Pass C;
- reference-policy numeric scoring coefficients may remain explicit laboratory configuration so long as ADR-0002's soft-gate/candidate/scoring semantics and all action meanings above are preserved.

No random choice is required for v0.

---

# 9. Pass C — subjective recognition and information

## 9.1 Subjective-state layers

v0 keeps **factual knowledge** separate from **social recognition**.

- **KnownFact**: a proposition the actor currently holds about objective/social state, with provenance to the observation/event/report that supports it.
- **Recognition**: an actor's social interpretation that a continuing collective or authority relation exists.

Knowing a fact does not imply recognizing a household; recognizing a household does not imply liking, approving, or obeying it.

## 9.2 Recognition propositions

The minimal v0 recognition vocabulary is:

- recognition that a persistent household identity **H** exists/continues;
- recognition that person **P** occupies a representative/head role for household **H** within a specified authority scope.

v0 does **not** introduce a universal subjective proposition equivalent to "X is a member of H." Any typed person-household associations required later are defined by Pass D/E rather than smuggling primitive membership back into the model.

## 9.3 Recognition state

Each recognition proposition is discrete and evidence-backed:

- **Unknown** — actor has no accepted recognition basis;
- **Recognized** — actor has sufficient currently accepted evidence for the proposition;
- **Contested** — actor holds incompatible evidence that prevents the proposition from being safely relied upon for authority-dependent action.

Recognition retains references to the evidence/events/reports that support its current state. It is not a scalar confidence score.

## 9.4 Direct knowledge and observation

Actors automatically know:

- their own objective personal state;
- relations/claims in which they are a direct party;
- proposals and committed events in which they directly participate.

Other committed events become known only when the actor is an explicitly valid witness/affected observer under the later event-specific observation rules, or when information is communicated to them.

Co-residence alone does not create omniscient observation.

## 9.5 Communication

v0 includes a voluntary **CommunicateClaim / Inform** action.

- The sender may transmit a factual or recognition proposition that exists in the sender's own current subjective state.
- The communication carries source/provenance: who communicated it and the underlying observation/event/evidence reference where available.
- Deliberate lying, invented claims, rumor mutation, probabilistic trust, and reputation are out of scope.
- Communication normally consumes the sender's one voluntary initiative for the cycle.
- A communicated event-backed proposition may provide sufficient evidence for recognition when no stronger/newer contradiction exists.

## 9.6 Staleness and contradiction

Subjective state does not passively synchronize with objective world state and does not naturally decay merely with time.

- stale information persists until displaced or contested by later evidence;
- evidence ordering follows the **time/order of the underlying event or observation**, not the later time at which a message happens to arrive;
- newer direct participation/observation supersedes older incompatible information;
- newer event-backed communication may supersede older reports;
- incompatible evidence that cannot be resolved by provenance/order yields **Contested** rather than silently selecting one claim.

Exact temporal comparison and event-order representation are finalized in Pass F.

## 9.7 Causal effect of recognition

Recognition is causally required for household-specific action generation.

- An engine-side household record does not by itself expose household actions to every actor.
- To intentionally act toward a household as a household, an actor must recognize that household identity.
- To use a representative/head as an authority channel, the actor must recognize that person in the relevant role/scope.
- Ordinary person-to-person actions remain available independently of household recognition.

For household-mediated marriage, the groom must recognize the relevant bride-household connection/route and the representative authorized to receive/resolve that proposal. Without that recognition, the mediated candidate is unavailable; the mutual-strong-like bypass remains independently available.

## 9.8 Recognition evidence versus formation

Kinship, co-residence, marriage, gifts, repeated coordination, fulfilled obligations, and similar lower-level facts may become **evidence**, but none individually and no engine-only cluster automatically creates Recognized Household.

Pass D defines the lower-level configuration/history that can create or sustain household identity and what evidence that formation/continuity emits.

## 9.9 Persistence and attitude independence

- Recognition does not decay because attitude decays.
- An actor may recognize a household/head while disliking them.
- An actor may fail to comply with a recognized authority.
- Recognition changes through evidence about formation, continuity, dissolution, succession, contradiction, or communicated claims.

## 9.10 Required negative control

Verification must include two actors facing the same objective household state but different subjective evidence:

- one recognizes the household/representative and therefore generates the relevant household-mediated candidate action;
- the other does not and therefore cannot generate that household-specific route.

This proves that subjective recognition is causal rather than decorative.

## 9.11 Pass C closure

Pass C is **WORKING-CONVERGED at the semantic level**.

The following exact locks are intentionally delegated, not forgotten:

- which committed events make which nonparticipants valid witnesses -> event-specific rules in D/E/F;
- exact proposition/data representation -> implementation contract after semantics are complete;
- exact household-formation and continuity evidence -> Pass D;
- representative authority scope and succession evidence -> Pass E;
- total event/order comparison and same-time conflict behavior -> Pass F.

These must be explicit before implementation authority is issued.

---

# 10. Pass D — household formation and continuity

## 10.1 Candidate organization

A `CandidateOrganization` may collect lower-level formation evidence before a household exists.

- it has no causal powers;
- it grants no resources, authority, actions, or household status;
- it cannot count as evidence for itself.

## 10.2 Formation warrant

A v0 household forms only when a connected founding core has all of:

- shared residence;
- at least one durable tie connecting the core: kinship, marriage, or mutual strong-like attitude;
- recurring material-support history: at least **two qualifying committed support events on different decision cycles**;
- recognition of the candidate organization by every person whose ties are required for that founding core.

Qualifying support events are accepted gift/help, loan provision, or favour fulfilment. Debt/favour existence alone is not sufficient.

When satisfied, one persistent `Household` identity is created with a `FormationWarrant` retaining founding-core people, dwelling, supporting ties/events, recognition evidence, and formation time.

The household record itself does not create resources, membership rights, or authority.

## 10.3 Household association

There is no authoritative universal `Members` set.

v0 uses a provenance-bearing `SustainingParticipant` association for people currently participating in the lower-level organization that sustains the household. Additional association types are added only if later v0 mechanics require them.

## 10.4 Continuity

Household identity persists only through an explicit historical transmission chain.

- at least one existing `SustainingParticipant` must bridge the prior and successor sustaining configuration;
- that bridge must recognize the successor configuration as the same continuing household;
- the transition creates a `ContinuationWarrant` linking prior state, transition evidence, and successor state;
- snapshot similarity, residence, assets, kinship, or participant overlap alone never preserve identity.

Sequential transmission may eventually replace every original founder while preserving the same household identity.

## 10.5 Lifecycle state

- **Active:** viable sustaining organization exists.
- **Inactive:** no currently viable sustaining organization, but at least one live continuity bearer remains.
- **Dissolved:** no live continuity bearer remains.

Inactive households may reactivate through a valid continuation chain. Dissolved households cannot reactivate as the same identity; a later similar organization receives a new identity.

Residence, resources, attitudes, marriage changes, representative succession, and one-by-one participant replacement do not by themselves break identity when a valid continuation chain exists.

## 10.6 Controlled division

For the v0 proof case, one household separates into two sustainable descendant organizations.

- both may record `DerivedFrom(H)`;
- only one may retain numerical identity `H`, and only through an explicit continuity warrant;
- the controlled v0 continuation branch is the branch carrying both the valid representative-role chain (defined in Pass E) and sustaining-participant transmission;
- the other branch receives a new household identity.

Largest branch, asset share, residence, or graph overlap never decide continuity.

This division/descendant case is a **scenario-controlled verification case**, not an expected naturally arising lifecycle in the first v0 runs. Because mortality and broader lifecycle systems are absent, descendant behavior must be revisited explicitly when those systems are introduced.

## 10.7 Controlled consolidation

For the v0 proof case, consolidation of two independent active households creates a new household identity `H3` with `DerivedFrom(H1,H2)`.

Neither predecessor is automatically treated as the continuing identity of the consolidated household. General absorption/reconsolidation rules are deferred.

## 10.8 Recognition and history

Founding-core actors who directly participate in formation recognize the resulting household from that event. Outsiders do not automatically gain recognition.

History preserves both:

- when the lower-level sustaining organization began developing;
- when sufficient evidence caused household formation/reification.

## 10.9 Pass D closure

Pass D is **WORKING-CONVERGED**.

Deferred dependencies:

- representative-role validity and succession -> Pass E;
- exact witness/event-order mechanics -> Pass F;
- general fission, absorption, reconsolidation, contested continuity, mortality-driven succession/descendant behavior -> future systems beyond the controlled v0 proof cases.

---

# 11. Implementation autonomy boundary

Until this draft is complete, an implementation agent has **no authority** to decide any open item above.

Once the final spec is accepted, implementation discretion may cover ordinary C# representation, naming, local helper decomposition, collection choices, and similar reversible engineering details **only where those choices do not alter specified semantics or observability**.
