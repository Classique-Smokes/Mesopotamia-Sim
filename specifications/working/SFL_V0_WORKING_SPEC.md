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

SFL v0 does **not** model grain production, prices, markets, agriculture, wages, or a historical economy.

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
- Exists independently of objective contracts such as debt, marriage, or kinship.
- May change as a consequence of social experience.
- Exact scale/update rule is **OPEN**.

**Forbidden shortcut:** do not convert attitude into a generic all-purpose “relationship strength” that also represents debt, kinship, marriage, obligation, or household affiliation.

## 4.2 Marriage

- Explicit continuing relation/status between people.
- Distinct from attitude, kinship, residence, and household affiliation.
- Creation/dissolution mechanics need not be a complete marriage system in v0.
- Whether marriage formation itself is an endogenous v0 action or a scenario-supplied transition is **OPEN**.

## 4.3 Kinship / family

- Present as explicit historical relations rather than inferred household membership.
- Full genealogy/reproduction is out of scope.
- A very small initial kinship vocabulary is sufficient for v0.
- Exact included relation types are **OPEN**; parent/child and sibling are current candidates.

## 4.4 Lending / repayment / debt

- Lending grain can create a persistent debtor-creditor relation/claim.
- Repayment changes or completes that relation rather than erasing its history.
- Debt is not equivalent to dislike, dependence, household membership, or kinship.
- Exact proposal/acceptance/default semantics are **OPEN**.

## 4.5 Favour / obligation

- Represents a socially meaningful obligation distinct from quantified grain debt.
- May connect people inside or across households.
- The content can remain abstract in v0 if its meaning and lifecycle are explicit.
- Exact creation, fulfilment, refusal, transfer, and expiry semantics are **OPEN**.

## 4.6 Residence

- Explicit relation between a person and a dwelling/place.
- Changing residence does not by itself create, destroy, split, or merge a household.
- Residence is not ownership.

## 4.7 Deliberate omissions at this stage

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
5. how attitudes change, if they change in v0;
6. whether marriage can form/end endogenously in v0 or is scenario-controlled;
7. which minimal kinship types are represented;
8. how debt and favour/obligation differ operationally;
9. what motivates a person to request/give/lend/repay/fulfil/refuse;
10. whether v0 needs any stochastic choice at all.

These questions must be resolved before an implementation packet is issued.

---

# 7. Implementation autonomy boundary

Until this draft is complete, an implementation agent has **no authority** to decide any open item above.

Once the final spec is accepted, implementation discretion may cover ordinary C# representation, naming, local helper decomposition, collection choices, and similar reversible engineering details **only where those choices do not alter specified semantics or observability**.
