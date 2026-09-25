# Slice 1 Retrospective SID — Pass B Alias / Distinct-Party Challenge

**Task:** `tasks/research/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Scope:** Slice 1 only  
**Authority:** advisory challenge report only; no Slice-1 semantic rule is created or changed here  
**Dispatch ref:** `sfl-v0-slice1-retro-sid-passb-dispatch-v1` @ `93fd589a911a9c862702389dd0f817cca5de8621`  
**Frozen Slice-1 applicability boundary:** `sfl-v0-slice1-acceptance-v1` @ `55377cc34b8bc3ccbf9cdf5029e9791dae965987`

Historical authority below is read only through that frozen Slice-1 boundary. Later-slice semantics are excluded. Current implementation behavior is not used as semantic authority.

## 1. Required union check

**Result: no obvious Slice-1 PersonId-position alias is omitted from the reconciled Pass-B frontier.**

The union already covers the consequential within-action interpersonal aliases, relation diagonals, the three-position `CallFavor(RepayDebt)` topology, cross-action response/material/Residence/favour reuse, direct-attitude convergence, and the already-closed kinship / Residence / marriage cases. I found no additional Slice-1 PersonId-position pairing that is both materially distinct from those classes and supported by the frozen applicability boundary.

Accordingly, there is **no `REVIEWER PASS-B FRONTIER ADDITION`** in this return.

The histories below are challenge cases, not semantic dispositions. Where a history depends on an unresolved upstream diagonal relation, the setup says so explicitly rather than treating that relation as already valid.

## 2. Challenges

### PB-01 — One person offers a gift to themself

#### Concrete history

1. Person P has 4 grain and one ordinary personal initiative available.
2. P selects `OfferGift(P -> P, 1)`.
3. The proposal amount is otherwise a valid positive integer.
4. If the proposal is allowed to reach response activation, P is also the target whose `ResponseDecisionContext` must choose Accept or Decline.
5. If accepted and committed, the nominal transfer debits and credits the same PersonId and the fixed accepted-gift consequence `recipient -> giver +10` targets `P -> P`.

#### Positions that alias

- gift initiator = gift target;
- material giver/source = material recipient;
- proposal initiator = responder;
- recipient side of the fixed attitude consequence = giver side.

#### Why classification matters

This case tests whether the accepted proposal/response model carries an implicit distinct-party meaning or merely happens to be illustrated with two people.

If the alias is admitted, one person both spends personal initiative to create the proposal and independently supplies the target response to that same proposal. The material effect ceases to be an inter-person transfer and instead becomes a same-identity debit/credit. The accepted `recipient -> giver +10` consequence becomes a self-directed attitude cause. A Declined/Unable/Invalidated history would also have only one unique direct participant even though the semantic positions remain proposer and counterparty.

The important question is therefore not just whether a guard accepts the term. The classification changes independent cognition/response, initiative accounting, resource endpoint identity, attitude direction, participant-knowledge cardinality, and event provenance.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:

- §3.1 defines accepted voluntary gift/help as `recipient -> giver +10` and preserves each direct cause in causal history.
- §3.5 requires Gift to remain an explicit transfer meaning rather than collapsing into another transfer meaning.
- §5 says each person normally receives one voluntary personal initiative per cycle and responses to incoming proposals do not consume it.
- §5.1 defines `ResponseDecisionContext(target, proposal)`, reading the target's subjective state, and separates response decisions from personal initiative.
- §6.7 says direct participants learn social failed-attempt outcomes.

Frozen `ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` says interpersonal actions are attempts/proposals whose effects remain subject to other actors and world-resolution rules. That wording is relevant pressure toward a counterparty reading, but this challenge does not convert it into a final identity rule.

Frozen verification family `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-091 and VS-SFL-097, separately preserve Gift history meaning and the `recipient -> giver +10` consequence.

#### Challenge type

possible implicit distinct-party meaning

#### Confidence

HIGH

---

### PB-02 — A requested loan that would create creditor = debtor

#### Concrete history

1. Person P has enough grain that a 2-grain loan term is materially representable.
2. P submits `RequestLoan(P -> P, 2)`: the requester/borrower names P as the prospective lender.
3. If the same-person proposal is permitted to reach response activation, P is also the target/lender response actor.
4. If accepted and committed, the nominal loan transfer has one PersonId on both endpoints and the resulting debt would record creditor P and debtor P with remaining amount 2.
5. A later `RepayDebt(1)`, if such a debt is admitted, would debit the debtor and credit the creditor at the same PersonId; the fixed repayment attitude consequence would be `P -> P +5`.
6. If balance remained at the social due review, the fixed due consequence would be `P -> P -10`.

#### Positions that alias

- requester/borrower/recipient/debtor = target/lender/giver/creditor;
- debt creditor = debt debtor;
- later repayment source = repayment destination.

#### Why classification matters

This is more than a self-transfer question because acceptance would create a persistent typed claim whose two semantic endpoints collapse.

Debt authority requires creditor/debtor identity, a remaining amount, preserved repayment history, a debtor reserve rule, successful-repayment attitude direction, and a due-cycle attitude direction. With one PersonId on both ends, resource movement can become net-zero while debt state and social consequences remain nontrivial. The same actor would also both initiate the request and independently decide whether to lend to themself.

Classification therefore affects independent response, resource identity, debt identity/cardinality, reserve feasibility, attitude direction, direct-participant cardinality, and causal history. Current code rejection or representability cannot answer whether the accepted Slice-1 debt meaning itself permits the diagonal.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:

- §3.3 defines Debt as a quantitative grain claim with creditor/debtor, original/remaining amount, preserved repayment history, the two-grain debtor reserve, and `creditor -> debtor -10` at the social due review.
- §3.1 defines loan granted as `borrower -> lender +5` and successful repayment as `lender -> borrower +5`.
- §5–§5.1 separate personal initiative from target response.
- §6.7 preserves participant knowledge of failed attempts.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-092, makes the resource semantics concrete: repayment debits the debtor, credits the creditor, changes lender -> borrower attitude +5, and retains debt history.

Frozen `DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md` requires distinguishable relationships/claims and the histories that create, change, fulfill, or terminate them; it does not itself specify whether both endpoints may be the same PersonId.

#### Challenge type

possible unclassified diagonal/self case

#### Confidence

HIGH

---

### PB-03 — A favour holder calls the favour on themself

#### Concrete history

1. For this challenge only, assume an outstanding `Favour(holder=P, debtor=P)` is present. This setup is deliberately conditional and does **not** assume that a diagonal favour is valid or how it arose.
2. P uses the holder's ordinary personal initiative to issue `CallFavor` to P with a response-closed `Farm` payload.
3. If the call is admitted, P is also the called actor whose response context chooses `FulfilCalledFavor` or `RefuseCalledFavor`.
4. On successful fulfilment, the requested Farm effect commits, the favour is consumed, and the fixed called-favour attitude consequence becomes `P -> P +10`.
5. On voluntary refusal, the same P would decline P's call, the favour would remain outstanding, and the fixed consequence becomes `P -> P -20`.

#### Positions that alias

- favour holder/caller/initiator = favour debtor/called actor;
- holder = fulfiller or refuser;
- source and target of the fixed called-favour attitude consequence.

#### Why classification matters

The accepted called-favour process sharply separates the holder's voluntary initiative from the called actor's response choice. A self-call collapses those roles into one PersonId while retaining two different decision contexts unless distinct-party meaning forbids the topology.

The case therefore stresses independent cognition/response, initiative accounting, favour relation identity, consumption of the favour only on successful fulfilment, self-directed +10/-20 consequences, and participant/provenance cardinality. It also tests whether `at most one outstanding favour per ordered person-pair` merely caps a diagonal pair if one exists or whether the underlying favour meaning excludes the diagonal entirely.

This challenge isolates CallFavor topology from favour-creation semantics; it does not use the conditional setup as evidence that self-favours are allowed.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §3.4:

- at most one outstanding favour per ordered person-pair;
- voluntary `CallFavor` uses the holder's ordinary personal initiative;
- the called actor's Fulfil/Refuse choice is response-scoped and consumes/grants no second personal initiative;
- the favour is consumed only on successful requested-action commit;
- success applies `holder -> fulfiller +10`;
- voluntary refusal leaves the favour outstanding and applies `holder -> refuser -20`.

Frozen §5.1 says response contexts do not consume/grant personal initiative and may coexist with personal action.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-094, exercises the same initiative/response separation and favour-consumption rules for called favour.

#### Challenge type

possible unclassified diagonal/self case

#### Confidence

MEDIUM

---

### PB-04 — The favour holder is also the creditor in a called repayment

#### Concrete history

1. B owes A one outstanding favour.
2. Independently, B owes A a 2-grain debt.
3. A spends A's ordinary personal initiative to `CallFavor(B, RepayDebt(the B-owes-A debt, 1))`.
4. B selects `FulfilCalledFavor`.
5. If the repayment remains feasible and commits, one grain moves from debtor B to creditor A, the debt remaining amount decreases, and the favour is consumed.
6. The successful repayment contributes `A -> B +5`; the fulfilled called favour contributes `A -> B +10`. They are distinct direct causes aimed at the same directed attitude edge and therefore participate in the accepted sum-then-clamp composition with separate provenance.

#### Positions that alias

- outer CallFavor holder = inner debt creditor/lender;
- outer called actor/favour debtor = inner debt debtor/repayer.

The first identity is the challenge focus. The second is the ordinary execution alignment required by the repayment payload.

#### Why classification matters

This is the counterexample to a blanket repair that tries to make every named semantic position globally distinct.

A and B remain two genuinely distinct people. What repeats is A across two separate typed claims: A is the holder of one favour and the creditor of one debt. The same recurrence makes two independently defined attitude causes converge on `A -> B` while preserving two cause keys and two relation histories.

Prohibiting the alias merely because two role labels resolve to A would destroy a coherent cross-claim topology and would also erase the accepted direct-cause convergence case. Conversely, this history does not prove that unrelated within-action self-aliases are valid; it shows why position-specific classification is necessary.

#### Relevant historical authority

Frozen `SLICE1_ACCEPTANCE_MANIFEST.md` identifies `RepayDebt(debt, amount)` as a current Slice-1 **CALLABLE** payload and requires S1-094-REPAY-CALLABLE.

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:

- §3.3 defines debt repayment and its preserved debt/repayment history.
- §3.4 requires called-favour payload execution inside the response scope and consumes the favour only on successful requested-action commit.
- §3.1 defines successful repayment as `lender -> borrower +5`, fulfilled called favour as `holder -> fulfiller +10`, and requires independent direct causes on the same directed attitude to be summed then clamped once with every cause retained in history.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-092, VS-SFL-094, and VS-SFL-097, separately exercise those repayment, called-favour, and direct-cause-composition consequences.

#### Challenge type

possible over-broad implementation prohibition

#### Confidence

HIGH

---

### PB-05 — One person takes a personal action and also answers an incoming request

#### Concrete history

1. From the common committed cycle snapshot, B has one ordinary personal initiative.
2. B uses that initiative for a Residence proposal involving D.
3. Separately, A has genuine unmet need and submits `RequestGiftOrHelp(A -> B, 1)`.
4. D responds to B's Residence proposal.
5. B separately receives the response context for A's help request and selects Accept.
6. Under ordinary revalidation, both otherwise-compatible accepted effects may commit: B's Residence changes only through the accepted Residence proposal, and B gives 1 grain to A.

#### Positions that alias

Across **separate actions**:

- B as actor using B's one personal initiative;
- B as target/responder to A's incoming request;
- B as material giver/source in that response.

#### Why classification matters

This cross-action identity is explicitly part of accepted Slice-1 agency accounting. It demonstrates that “actor” and “target/responder” cannot be globally treated as disjoint PersonId classes.

The same B must retain one personal decision trace plus a separate response trace. The response must not consume, cancel, or duplicate B's personal initiative. The help result has its own resource transfer and `A -> B +10` attitude consequence, while the Residence result remains a separate relation transition with separate provenance.

A broad alias prohibition aimed at self-proposals could accidentally erase this valid same-person reuse across actions, weakening initiative semantics, response autonomy, history, and the separation of resource versus Residence effects.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:

- §5: one voluntary personal initiative per cycle; responses to incoming proposals do not consume it.
- §5.1: response contexts may coexist with personal action and do not consume/grant initiative.
- §3.6: Residence change has its own proposal/acceptance path and is distinct from other meanings.

Frozen `RESPONSE_DECISION_FAMILY.md`, **VS-SFL-105 — Response does not consume personal initiative**, gives this exact accepted Slice-1 shape: B uses one personal initiative for a Residence proposal and separately Accepts A's `RequestGiftOrHelp`; both decision traces remain distinct and no second initiative is created.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-098, independently requires that responses not consume initiative and that multiple responses remain possible.

#### Challenge type

valid cross-action alias that must remain supported

#### Confidence

HIGH

---

### PB-06 — One target accepts two requests backed by the same grain source

#### Concrete history

1. A and C each have genuine unmet need.
2. Both independently submit a 1-grain `RequestGiftOrHelp` to B from the common snapshot.
3. B has exactly 1 grain available across the two ordinary transfers.
4. B receives two separate response contexts. Neither sees the other's uncommitted effect.
5. B independently selects Accept in both contexts.
6. At central resolution, both accepted effects cannot commit against the same scarce source. Exactly one compatible transfer commits; the other becomes `InvalidatedAtResolution(reason)`, not retroactive Decline.
7. Both Accept decisions remain true history.

#### Positions that alias

Across **separate proposals**:

- B is target/responder in both response contexts;
- B is the material giver/source for both accepted transfer effects.

#### Why classification matters

This is a direct accepted counterexample to any uniqueness rule that says a PersonId may occupy a response-target or material-source position only once per cycle.

The alias is the reason a real conflict exists: both accepted responses rely on the same B grain source. Slice-1 semantics require multiple response contexts from the common snapshot, preserve both target choices, then let central revalidation distinguish accepted-by-target from committed-by-resolver. Participant knowledge and provenance therefore remain proposal-specific even though one responder/source is shared.

A repair that deduplicates or rejects the second B role would bypass the intended conflict semantics rather than classify a within-action self-counterparty case.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §5.1:

- response contexts do not observe uncommitted effects of other proposals/responses;
- may activate multiple times for one target in one cycle;
- may select multiple Accept/Fulfil responses from the common snapshot;
- do not bypass central resolution/revalidation;
- later capacity loss is `InvalidatedAtResolution`, not retroactive refusal.

Frozen `RESPONSE_DECISION_FAMILY.md`, **VS-SFL-103 — Multiple accepted responses can later conflict**, supplies this exact A/C -> B scarce-grain history and requires two B response traces, two Accepts, one commit, one invalidation, and no response retry/extra initiative.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-098, also requires multiple responses subject to central compatibility resolution.

#### Challenge type

valid cross-action alias that must remain supported

#### Confidence

HIGH

---

### PB-07 — A Residence proposal whose “other person” is the proposer themself

#### Concrete history

Consider either form:

**Move form**

1. P occupies dwelling D.
2. P proposes moving to P's dwelling D, so the mover/proposer and the named dwelling-side counterpart are both P.

**Invite form**

1. P occupies dwelling D.
2. P invites P into P's dwelling D, so inviter/dwelling-side proposer and invitee/mover are both P.

No implementation guard is needed to classify the semantic shape: the historical wording itself is the challenge evidence.

#### Positions that alias

- move proposal: mover/proposer = named counterpart whose dwelling is the destination;
- invite proposal: inviter/dwelling-side proposer = invitee/mover/responder.

#### Why classification matters

The accepted Residence meaning is explicitly bilateral: moving to **another person's** dwelling or inviting **another person** into one's dwelling, with the named counterpart's acceptance supplying the response path.

Collapsing the endpoints removes the “another person” relation and turns proposal plus acceptance into one person's self-addressed Residence operation. That would alter response independence, initiative/response separation, Residence-transition identity, participant cardinality, and history. Unlike PB-01 through PB-03, this case has direct frozen wording that already supplies the distinct-person constraint.

This challenge is included as a calibration case: Pass B must distinguish historically closed aliases from genuinely unclassified self/diagonal cases rather than treating every same-PersonId pairing alike.

#### Relevant historical authority

Frozen `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §3.6 states:

> A person may propose moving to another person's dwelling or inviting another person into their dwelling.

It also states that the named counterpart's acceptance is sufficient in v0 and that Residence change remains its own proposal/acceptance path.

Frozen `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-096, exercises the two-person forms as A moving to B's dwelling and A inviting B into A's dwelling.

#### Challenge type

structurally impossible alias

#### Confidence

HIGH

## 3. Cross-challenge observations for reconciliation

These observations organize the questions; they do not answer them.

1. **Within-action self-counterparty and relation-diagonal questions are not interchangeable.** PB-01 asks whether proposal/response meaning itself implies another actor. PB-02 adds the extra consequence of creating a persistent diagonal claim. PB-03 adds a persistent favour plus two decision roles.
2. **Cross-claim role recurrence is materially different from self-relations.** PB-04 keeps A and B distinct inside both Favour and Debt while allowing A to occupy two role labels across those claims.
3. **Cross-action reuse is already positively exercised by frozen Slice-1 verification.** PB-05 and PB-06 are not negative-space permissions inferred from silence; they are accepted process shapes that a broad repair must preserve.
4. **Direct attitude convergence is expected to preserve cause identity.** PB-04 produces two distinct direct causes on the same `A -> B` edge. PB-01 through PB-03 show how unresolved self-cases could instead create `P -> P` causes if admitted. Whether the latter edge is semantically meaningful remains a classification question; the batching rule cannot answer endpoint validity.
5. **Participant cardinality is part of the semantic fallout.** §6.7 says direct participants learn failed-attempt outcomes. A self-alias could reduce two named semantic positions to one unique knower; valid cross-action reuse instead preserves multiple event-specific participant sets sharing one PersonId.
6. **Implementation behavior is not closure.** A self-target guard may happen to reject an unresolved case, and a data structure may happen to represent it. Neither fact supplies the missing Slice-1 authority.

## 4. No semantic disposition

This report is a Pass-B challenge artifact only.

- **The report creates no Slice-1 rule.**
- **Code behavior cannot supply missing authority.**
- **Master Architect / Director reconciliation decides whether any successor semantic or acceptance repair is required.**
