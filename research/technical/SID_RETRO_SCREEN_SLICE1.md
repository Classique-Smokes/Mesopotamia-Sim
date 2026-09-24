# SID Retrospective Screen — Slice 1

**Status:** advisory retrospective triage  
**Policy lens:** `SID-ASSURANCE-v1` / DEC-0012  
**Historical acceptance ref:** `sfl-v0-slice1-acceptance-v1`  
**Verified implementation candidate:** `imp-0001-slice1-conformance-candidate-v3` @ `06e25644879dd8505e24fcaeb43256f69c29c15f`

## 1. Historical-boundary verification

This screen treats the Slice-1 specification→implementation boundary as a transition from the pre-existing person/material/world substrate and founding social-simulation commitments into the first executable lower-level social-fabric kernel.

The historical “old world” used here is limited to:

- the Project Seed;
- `DEC-0001` Foundational Social-Fabric Model;
- `ADR-0001` Active Social-State Representation;
- `ADR-0002` Hierarchical Individual Agency;
- the accepted reference-kernel/runtime architecture already in force before implementation (`ADR-0003`–`ADR-0005`);
- the accepted Slice-1 semantic and verification state frozen at `sfl-v0-slice1-acceptance-v1`.

Frozen identities were verified:

- Slice-1 acceptance freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- frozen acceptance-manifest blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- accepted `SPEC-SFL-0001` blob at that ref: `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`;
- final verified implementation candidate: `06e25644879dd8505e24fcaeb43256f69c29c15f`;
- final completion record: `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`.

No Slice-2, Slice-3, or Slice-4 semantics were used as requirements for Slice 1, and no later Slice-4 SID pilot material was used.

## 2. Reconstructed Slice-1 semantic delta

Slice 1 converted the founding lower-level social substrate into executable semantics for persistent people, grain, residence, typed social relations, one-person voluntary initiative, counterparty responses, proposal resolution, and causal history.

The consequential introduced interaction structure includes:

- transfers and debt/favour actions sharing personal grain while retaining distinct social meaning and provenance;
- debt and favour lifecycle state that can change future action feasibility;
- proposal responses that coexist with a person's own voluntary initiative;
- called-favour execution that nests a requested action inside a response scope;
- marriage and residence as independent relations despite possible behavioral coupling;
- same-cycle competition for grain, debt balances, favour capacity, marriage capacity, and a person's single-valued Residence;
- fixed direct social reactions whose multiple causes must compose deterministically;
- participant positions whose identity can affect cognition, response routing, initiative accounting, resource accounting, relation cardinality, and provenance.

This is materially more than a local implementation detail over the old world.

## 3. Retrospective SID trigger

**Semantic-interaction-delta trigger: FIRED —** Slice 1 introduced executable action/response, resource, relation-lifecycle, single-valued-state, and provenance semantics whose compositions materially changed the causal possibility space of the pre-existing person/material world. In particular, resource competition, nested response execution, same-cycle conflicts, and participant-position identity are all within the later DEC-0012 trigger definition.

This retrospective result does not imply that Slice 1 was incorrectly accepted. It means that, had `SID-ASSURANCE-v1` existed at the boundary, the boundary would have warranted a bounded semantic-interaction-delta closure.

## 4. Candidate interaction surfaces and existing closure

| Candidate surface | Retrospective risk question | Existing acceptance/conformance evidence | Screen disposition |
|---|---|---|---|
| Personal grain ↔ gift/help/loan/debt/favour actions | Can several socially distinct actions silently compete for or reserve the same grain, or acquire a generic reserve? | Frozen D4 ingress coverage, debt reserve cases, transfer-meaning contrasts, resolution family, global interaction review, and reviewer-owned debt/material permutations exercise this strongly. | Already substantially closed |
| Personal initiative ↔ incoming response | Can responding consume, grant, cancel, or duplicate the target's one voluntary initiative? | Response family and candidate tests explicitly exercise response/personal coexistence and duplicate-personal-initiative rejection. | Already substantially closed |
| CallFavor ↔ requested action | Can fulfilment open another response, consume an extra initiative, retire the favour on non-commit, or alter inner failure meaning? | Frozen called-favour rows, nested guards, direct/nested grain validation, and final K4 probes cover these cases. | Already substantially closed |
| Debt/favour lifecycle ↔ same-cycle material conflict | Can repayment, favour creation/retirement, or provenance depend on incidental execution order? | Frozen cardinality/atomicity rows plus final K4 structural interaction audit and reviewer-owned debt/favour permutations cover current executable shapes. | Already substantially closed |
| Marriage ↔ residence | Does marriage silently move residence, or does residence silently determine marriage? Can their independent effects spuriously conflict? | Frozen marriage/residence cards and reviewer-owned commuting controls preserve the explicit independence. | Already substantially closed |
| Multiple accepted Residence effects | Can more than one Residence transition commit, or can collection order select the winner? | Frozen D2/Residence conflict rules, metamorphic contender permutations, and independent residence enumeration cover this directly. | Already substantially closed |
| Shared transfer machinery ↔ social meaning/provenance | Can gift, loan, bargain, reciprocal help, repayment, or called action be silently relabeled by shared material code? | Transfer-meaning cards, debt/favour origin checks, atomic bargain evidence, history checks, and independent provenance probes cover the material current shapes. | Already substantially closed |
| Participant-position aliasing / distinct-party assumptions | Which Slice-1 semantic positions may share one `PersonId`, and what happens to response, initiative, material accounting, relation identity, and provenance when they do? | The implementation forbids broad classes of aliasing, but the frozen semantic/acceptance surface does not appear to classify that general rule or exercise self/aliased counterpart cases. | **Suspicious surface not closed by existing evidence** |

The final K4 review is unusually strong evidence for the surfaces it actually covers: all 128 REQUIRED rows passed, and the reviewer added 7,388 independently owned worlds / 64,793 assertions plus a structural audit of current action-relevant mutable dependencies. That evidence materially reduces the need to reopen already classified resource, response, residence, debt, favour, and provenance interactions.

It does not, however, by itself close a semantic possibility that never entered the frozen applicability vocabulary.

## 5. Concrete suspicious omission / regression candidate

The one concrete reason for a closer retrospective look is **participant-position aliasing / general distinct-party semantics**.

The verified implementation makes a broad semantic choice:

- `WorldState.CheckPair` rejects relation endpoints when `a == b`, affecting persisted attitude, kinship, marriage, debt, and favour records;
- `ActionRules.Invalid` returns `InvalidCounterparty` when a targeted action's resolved target equals its actor, affecting gift/help/loan, benefit-for-favour, reciprocal help, called-favour targeting, marriage, and residence proposal shapes;
- reciprocal-favour cancellation separately rejects a self target;
- decision-input construction excludes the actor from known counterparties, so autonomous generation also embodies distinct-party assumptions.

For many of these meanings, distinct people are intuitively consistent with terms such as “counterparty,” “interpersonal,” “another person,” creditor/debtor, holder/debtor, groom/bride, or proposer/invitee. But the frozen Slice-1 specification does not appear to contain one general authority-bearing rule saying that every applicable lower-level participant position must be distinct, nor does the frozen manifest contain an omission-detectable participant-alias row covering that implementation-wide choice.

The acceptance tests and the final independent conformance probes inspected for this screen likewise do not appear to exercise `actor == target` / self-counterparty histories as a semantic category.

That matters under DEC-0012 because aliasing can change more than input validation:

- a counterparty response may cease to be an independent cognitive choice;
- response versus personal-initiative accounting changes;
- a grain “transfer” may collapse to one resource owner;
- debt/favour ordered-pair cardinality and lifecycle meaning may collapse;
- social-reaction direction and cause provenance may become self-directed;
- residence proposer/mover/counterparty roles may coincide;
- failure and participant-knowledge routing may change.

Therefore the implementation's general prohibition cannot be treated retrospectively as automatically closed merely because the completed implementation and frozen tests consistently enforce it. Under the SID disposition rules, a prohibition or derived consequence needs controlling accepted authority; implementation consistency alone cannot supply that authority.

This screen does **not** establish that self/aliased interactions should be allowed, and it does not establish an accepted Slice-1 regression. It identifies a bounded semantic-authority question that the later SID process was specifically designed to force into the vocabulary before implementation could decide it.

## 6. Smallest frontier for closer review

A closer review should not reopen Slice-1 interaction mechanics generally. The smallest justified frontier is:

**Slice-1 participant-position aliasing and distinct-party admissibility only.**

The retro-SID should classify, from Slice-1-era authority, the meaningful positions in:

- gift/help/loan and explicit benefit-for-favour / reciprocal-help interactions;
- debt creditor/debtor and favour debtor/holder relations;
- `CallFavor`, including the relation between outer holder/debtor roles and an inner `RepayDebt`;
- Residence proposer, mover, named counterpart, and destination-owner roles;
- directed attitude and kinship endpoints;
- direct-marriage groom/bride positions where type/sex semantics already make aliasing structurally impossible.

For each position pair, the review only needs to determine one of the normal authority-bearing dispositions: distinctness follows from accepted meaning; aliasing is expressly prohibited/intended; aliasing is semantically irrelevant/impossible; or the historical authority is genuinely unresolved.

The already-verified D1–D5 repairs, general same-resource ordering, nested-response closure, marriage/residence independence, and later household/institution semantics need not be rerun unless this narrow alias analysis demonstrates a dependency on them.

## 7. Recommendation

There is no present evidence of a known semantic regression requiring immediate repair, and most interaction-heavy Slice-1 mechanics are already covered by unusually strong frozen acceptance and independent conformance evidence.

There is, however, one concrete negative-space omission worthy of the full SID method on a very small frontier: the implementation-wide distinct-party rule versus the absence of an explicit frozen semantic classification of participant aliasing.

**FULL RETRO-SID AUDIT RECOMMENDED**
