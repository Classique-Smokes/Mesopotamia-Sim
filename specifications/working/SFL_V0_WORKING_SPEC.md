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
- Marriage formation is **endogenous in v0**: one eligible person may propose marriage to another and the target may accept or refuse through the normal proposal/resolution path.
- An established marriage is at-most-once per person in v0. Rejected proposals do not consume this lifetime allowance.
- Divorce, widowhood, remarriage, plural marriage, reproduction, and a general marriage market are out of scope for v0.
- Marriage may trigger an explicit settlement effect using grain and/or obligation so the laboratory can exercise transfer and social-claim machinery. Exact direction/amount is scenario-defined or otherwise controlled until historical evidence supports a stronger rule.
- Scenarios may still initialize an existing marriage when required for a specific fixture.

## 4.3 Kinship / family

- Present as explicit historical relations rather than inferred household membership.
- Full genealogy/reproduction is out of scope.
- A very small initial kinship vocabulary is sufficient for v0.
- Exact included relation types are **OPEN**; parent/child and sibling are current candidates.

## 4.4 Lending / repayment / debt

- Debt is a **quantitative, grain-specific material claim**.
- Lending grain can create a persistent debtor-creditor relation recording creditor, debtor, original quantity, and remaining quantity.
- Repayment may be partial or complete; completion satisfies the claim without erasing its history.
- Debt does not directly compel unrelated social action and is not equivalent to dislike, dependence, household membership, kinship, or favour.
- Exact default and overdue semantics remain **OPEN**.

## 4.5 Favour / obligation

- A favour is a **qualitative, action-oriented social claim**, deliberately distinct from quantified grain debt.
- The holder may later **call in** one outstanding favour by attaching it to a specific requested action.
- A favour never bypasses physical feasibility or the proposal/resolution architecture. It creates strong social pressure/claim over a feasible choice rather than magical capability.
- A refusal must remain representable; its exact consequence is still **OPEN**.
- v0 favours are discrete rather than point-valued: one favour is one outstanding claim. No exchange rate, trading, inheritance, partial favour balance, or generic social currency is implied.
- A favour may arise through either of two v0 paths:
  1. **Explicit bargain:** a person offers a benefit/action in exchange for one favour; the target knowingly accepts or refuses the bargain before it commits.
  2. **Relationship-mediated reciprocity:** a person accepts a beneficial action from someone toward whom they already have a sufficiently positive attitude; the accepted benefit can create one favour owed to the benefactor even though the favour was not demanded as contractual consideration. The recipient must be able to evaluate the obligation consequence before accepting the benefit.
- A genuine **gift** remains possible and creates no favour; implementation must not silently convert every beneficial transfer into leverage.
- For the working v0, “sufficiently positive” means the recipient's attitude toward the benefactor is in the **like or strong-like** bands (currently >= +26); this threshold is a controlled laboratory assumption, not a historical claim.
- Favours may connect people inside or across households.
- Exact call-in eligibility, fulfilment/refusal consequence, expiry, and whether multiple simultaneous favours may exist between the same ordered pair remain **OPEN**.

## 4.6 Grain production / consumption

- A person may spend an available action opportunity on an abstract **farm/produce grain** action.
- The action has fixed laboratory yield for the active scenario/configuration.
- Grain is periodically consumed according to a fixed laboratory rule.
- These mechanics exist only to create renewable scarcity and opportunity cost for the social laboratory; they do not constitute an agricultural subsystem.
- An actor need not emit a semantic **wait** action merely to do nothing. Producing no optional social proposal in a cycle is sufficient unless later temporal semantics require an explicit idle process.

## 4.7 Residence

- Explicit relation between a person and a dwelling/place.
- Changing residence does not by itself create, destroy, split, or merge a household.
- Residence is not ownership.

## 4.8 Deliberate omissions at this stage

Do not add without a demonstrated need:

- generic friendship relation;
- generic “relationship strength” relation;
- primitive household membership relation used as causal ground truth;
- generic household-support relation that simply encodes the desired household in advance;
- broad status/class/office systems;
- full property-rights system.

---

# 5. Pass B — constraints already established

The eventual action system must satisfy:

- relationships/actions may cross household boundaries;
- actors retain individual agency after household formation;
- there is no privileged **form household**, **join household**, or **become household** action that directly produces the aggregate;
- social actions involving another actor are proposals/attempts and must respect the accepted proposal/resolution/commit architecture;
- physically impossible actions must remain distinguishable from socially unattractive, disfavoured, norm-breaking, or refused actions;
- relation history must be preserved where later state/identity depends on it.

---

# 6. Still open in Pass B

Before Pass B can close we must specify:

1. the minimal **action/proposal repertoire**;
2. which actions create, alter, fulfil, refuse, or terminate each relation;
3. the minimal objective person state needed for those actions;
4. the minimal subjective state beyond attitude;
5. exact attitude update magnitudes for relevant committed events;
6. which minimal kinship types are represented;
7. the exact favour call-in / fulfil / refusal lifecycle and multiplicity rule;
8. the exact minimal action repertoire and how gift/help/loan/favour-bearing benefit are represented without semantic duplication;
9. what motivates a person to request/give/lend/repay/fulfil/refuse/marry/farm;
10. grain production and consumption quantities/cadence for verification fixtures;
11. whether residence change is endogenous in v0 or only scenario-controlled;
12. whether v0 needs any stochastic choice at all.

These questions must be resolved before an implementation packet is issued.

---

# 7. Implementation autonomy boundary

Until this draft is complete, an implementation agent has **no authority** to decide any open item above.

Once the final spec is accepted, implementation discretion may cover ordinary C# representation, naming, local helper decomposition, collection choices, and similar reversible engineering details **only where those choices do not alter specified semantics or observability**.
