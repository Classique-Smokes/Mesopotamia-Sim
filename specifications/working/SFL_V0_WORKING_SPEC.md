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
- **Pass B — Lower-level social fabric + minimal agency:** ACTIVE.
- Passes C–G: not yet specified.

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
- Exact event-by-event update magnitudes remain **OPEN**.

**Forbidden shortcut:** do not convert attitude into a generic all-purpose “relationship strength” that also represents debt, kinship, marriage, obligation, or household affiliation.

## 4.2 Marriage

- Explicit continuing relation/status between people.
- Distinct from attitude, kinship, residence, and household affiliation.
- Marriage formation is **endogenous in v0** and the proposal carries its settlement terms rather than triggering an unspecified automatic settlement.
- An established marriage is at-most-once per person in v0. Rejected proposals do not consume this lifetime allowance.
- Divorce, widowhood, remarriage, plural marriage, reproduction, and a general marriage market are out of scope for v0.
- Working v0 has two formation routes:
  1. **Household-mediated route:** where the prospective bride is attached to a recognized household, marriage is mediated through that household rather than gated by the couple's attitude. The working intended effect is that the bride's household supplies the proposal-specified grain dowry/settlement and the groom incurs one favour obligation to that household's recognized head/representative. Exact household authority, recognition, and who commits acceptance are deferred to the household/representative passes.
  2. **Mutual strong-like bypass:** if the prospective spouses' stored directed attitudes toward one another are both in the strong-like band, they may form the marriage directly without the household-mediated dowry/favour package.
- The direct bypass uses **stored attitude**, not kinship-amplified decision weight.
- Until household semantics are specified, the mediated route is a declared cross-pass dependency rather than implementation authority.
- Scenarios may still initialize an existing marriage when required for a specific fixture.
- Exact bride/groom eligibility representation, proposal initiator rules, dowry recipient, and behavior when the prospective bride has no recognized household remain **OPEN**.

## 4.3 Kinship / family

- v0 represents only **parent/child** and **sibling** kinship, initialized as scenario state rather than generated through reproduction.
- Parent/child has inverse directed roles; sibling is symmetric.
- Kinship remains distinct from attitude, residence, marriage, obligation, and household affiliation.
- Kinship influences **decision evaluation** by amplifying the behavioral weight of existing attitude toward that person: positive attitude matters more for kin and negative attitude also matters more for kin.
- Kinship does **not** modify the stored attitude value itself.
- Kinship amplification does not by itself satisfy explicit categorical gates defined on stored attitude, including the strong-like reciprocity gate and mutual-strong-like marriage bypass.
- Exact amplification factor remains **OPEN**.
- Parent/child and sibling marriage are mechanically ineligible in v0; this is a bounded laboratory rule, not a complete historical marriage-law model.

## 4.4 Lending / repayment / debt

- Debt is a **quantitative, grain-specific material claim**.
- Lending grain can create a persistent debtor-creditor relation recording creditor, debtor, original quantity, and remaining quantity.
- Repayment may be partial or complete; completion satisfies the claim without erasing its history.
- Debt does not directly compel unrelated social action and is not equivalent to dislike, dependence, household membership, kinship, or favour.
- v0 debt has **no interest, due date, or automatic default penalty**.
- Repayment is nevertheless a persistent actor concern when the debtor has sufficient material surplus; knowingly retaining repayable debt may create a negative attitude consequence.
- Exact definition of repayable surplus and exact attitude consequence remain **OPEN**.

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
- Favours may connect people inside or across households.
- Exact numerical attitude effects of fulfilment/refusal and whether favour-created actions may themselves create new favour claims remain **OPEN**.

## 4.6 Material-help / transfer meanings

The v0 action vocabulary must preserve four distinct social meanings even where implementation reuses lower-level grain-transfer code:

1. **Gift** — voluntary grain transfer that creates neither debt nor favour.
2. **Loan** — grain transfer that creates a quantified grain debt.
3. **Explicit favour bargain** — a benefit/action offered in exchange for one favour, knowingly accepted before commitment.
4. **Relationship-mediated reciprocal help** — a knowingly accepted beneficial action that creates one favour only when the recipient already strongly likes the benefactor.

A generic hidden transfer mode must not erase these meanings from actor reasoning or semantic history.

## 4.7 Attitude dynamics

- Committed social experience may change directed attitude using a small set of fixed laboratory magnitudes rather than a psychological model.
- Positive candidates include receiving voluntary help/gift, receiving a loan, successful repayment, and fulfilment of a called favour.
- Negative candidates include refusal of a request, refusal of a called favour, failure to repay while materially capable, and breach/failure of an explicitly accepted commitment.
- Ordinary rejection need not carry the same penalty as violation of an established obligation; called-favour refusal should be among the strongest negative events in v0.
- To prevent permanent positive accumulation and represent fading social salience, nonzero attitudes **drift toward neutral (0)** over time in the absence of reinforcement. Positive values fall toward zero and negative values rise toward zero; decay never reverses sign by itself.
- Exact event increments and decay cadence/magnitude remain **OPEN**.

## 4.8 Grain production / consumption

- A person may spend an available action opportunity on an abstract **farm/produce grain** action.
- The action has fixed laboratory yield for the active scenario/configuration.
- Grain is periodically consumed according to a fixed laboratory rule.
- Failure to meet consumption does **not** create death, health, or demographic mechanics in v0. It creates a persistent unmet-subsistence/need condition that strongly motivates grain acquisition/production until resolved.
- These mechanics exist only to create renewable scarcity and opportunity cost for the social laboratory; they do not constitute an agricultural subsystem.
- An actor need not emit a semantic **wait** action merely to do nothing. Producing no optional social proposal in a cycle is sufficient unless later temporal semantics require an explicit idle process.

## 4.9 Residence

- Residence is an explicit relation between a person and a dwelling/place.
- Residence change is endogenous in v0 but remains separate from ownership and household identity.
- People may propose **co-residence / residence change** rather than automatically teleporting because of a relationship.
- Strong mutual positive relations create a **weaker** incentive to seek co-residence; established marriage creates a **stronger** incentive.
- Acceptance/refusal remains socially mediated; marriage does not automatically force co-residence.
- Changing residence does not by itself create, destroy, split, or merge a household.
- Exact consent rule for moving into an already occupied dwelling and handling multiple existing residents remains **OPEN**.

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

## 5.1 Action opportunity

- Each actor may normally initiate **one substantive voluntary action per decision cycle**.
- Responding to incoming proposals does not consume that initiative.
- An actor may initiate nothing; no semantic `Wait` action is required merely to represent inactivity.

## 5.2 Reference v0 choice policy

- The reference laboratory uses **deterministic scored choice** rather than random action selection or a rigid scripted if/else priority chain.
- The actor generates feasible candidate actions, evaluates them from current objective state, directed attitude, kinship amplification, obligations/debts, subsistence need, marriage/residence incentives, and other explicitly specified concerns, then chooses the highest-scoring candidate.
- Tie-breaking must be deterministic and semantically declared rather than dependent on collection/insertion order.
- This is a **reference policy, not a permanent architecture lock**. Action semantics and world transition rules must remain separable from actor policy so later planning, heterogeneous personalities, learned policies, or stochastic choice can replace/extend the v0 scorer without rewriting the social substrate.

## 5.3 Minimal persistent concerns

Every v0 person shares the same basic concern categories:

- maintain enough grain / resolve unmet subsistence need;
- maintain or improve positively valued relations and react to negatively valued ones;
- discharge repayable grain debt;
- respond to and discharge called favour obligations;
- seek marriage when eligible under v0 rules;
- seek co-residence where marriage or strong positive relationship supplies motivation.

Individualized personality weights and strategic multi-step planning are deferred.

## 5.4 Working action/meaning repertoire

The final names may change, but v0 needs semantic actions sufficient to:

- farm/produce grain;
- make a gift;
- offer/request a loan and repay debt;
- offer/accept an explicit benefit-for-favour bargain;
- provide/accept relationship-mediated reciprocal help;
- call in and fulfil/refuse a favour;
- propose/respond to marriage with explicit settlement terms;
- propose/respond to co-residence/residence change.

Response mechanics may be represented as proposal resolutions rather than independent initiative actions.

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

# 7. Still open in Pass B

Before Pass B can close we must specify:

1. exact fixed **attitude event magnitudes** and natural-decay cadence/magnitude;
2. the v0 **kinship amplification factor** and whether parent/child and sibling use the same factor;
3. exact grain **farm yield, consumption amount/cadence, initial reserve conventions**, and definition of repayable surplus;
4. the exact deterministic **action-scoring concerns/weights** and deterministic tie-break rule;
5. marriage-role details needed before implementation: bride/groom eligibility representation, who may initiate, dowry recipient, and what happens when the prospective bride lacks a recognized household;
6. household-mediated marriage authority remains dependent on later household/representative semantics and must be reconciled there;
7. exact **residence consent** semantics for occupied/multi-resident dwellings;
8. whether ordinary request refusal always changes attitude or only under contextual conditions such as unmet need / prior commitment;
9. whether an action performed to fulfil a favour may itself generate a new favour or other obligation;
10. exact proposal forms for requesting gift/help versus requesting a loan, so actor reasoning remains explicit without duplicating implementation unnecessarily;
11. whether any subjective state beyond directed attitude is needed in Pass B, or whether recognition/knowledge should remain entirely for Pass C.

These questions must be resolved before an implementation packet is issued.

---

# 8. Implementation autonomy boundary

Until this draft is complete, an implementation agent has **no authority** to decide any open item above.

Once the final spec is accepted, implementation discretion may cover ordinary C# representation, naming, local helper decomposition, collection choices, and similar reversible engineering details **only where those choices do not alter specified semantics or observability**.
