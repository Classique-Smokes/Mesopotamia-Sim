# Slice 1 Retrospective SID — Pass A Independent Participant-Position Frontier

**Task:** `tasks/research/SID_RETRO_SLICE1_PASSA_ALIAS_FRONTIER.md`  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Scope:** Slice-1 lower-level social fabric only  
**Authority:** advisory frontier map only; no Slice-1 semantic rule is created or changed here

## A. Independence statement

### Dispatch and historical baseline

- Exact dispatch ref: `sfl-v0-slice1-retro-sid-passa-dispatch-v1`
- Exact dispatch commit: `6f62e9a0a43c0c9e7722bf2e9ff53825469572de`
- Primary historical acceptance ref: `sfl-v0-slice1-acceptance-v1`
- Historical acceptance commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`

Historical authority used:

- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` at the frozen acceptance ref, blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` at the frozen acceptance ref, blob `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`, restricted to Slice-1-applicable lower-level semantics, direct-marriage bypass, individual/response agency, failed-attempt knowledge, and the resolver consequences required by the Slice-1 manifest;
- `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`, blob `67f091f6a382dd47e8377f351d13822c91d1c30a`;
- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`, blob `c57a1efaa3deb93d2dcdab17e61541d68d2b1502`;
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`, blob `66cfd55f8b960ff5664638c41c0e731257902be5`;
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`, blob `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229`;
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`, blob `9ce78a311f006215a2afe3575065005e74c4e916`;
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`, blob `43eedd7eb49e1eae035010332883ed2d8726d451`;
- `architecture/accepted/ADR-0005_HOST_RUNTIME.md`, blob `7e6732a928656da28d299a4d78bf27d1ffc139f5`.

The candidate position inventory was formed from semantic authority before implementation was used as evidence. After that frontier was fixed, I inspected the dispatch implementation only to identify additional role/position shapes worth naming. In particular, the current implementation exposes both giver-first and requester-first shapes for relationship-mediated reciprocal help, a three-person-capable outer-`CallFavor` / inner-`RepayDebt` topology, and cross-proposal dependency shapes for material, Residence, marriage, and favour resolution. Current implementation self-target or same-party rejection behavior was **not** treated as semantic authority and did not remove candidates from this frontier.

### Blindness / contamination disclosure

I did **not** read:

- `research/technical/SID_RETRO_SCREEN_SLICE1.md`;
- branch `review/sid-retro-screen-slice1-return`;
- any Master Architect Slice-1 retrospective SID frontier/audit artifact;
- any Pass-B task or reconciliation;
- current Slice-4 SID pilot materials.

The historical SPEC is a whole-v0 document and contains later household material. A bounded fetch used to reach the Slice-1 response/failure clauses also exposed later household text in the same file; that material was excluded from this analysis and was not used as a Slice-1 requirement. I then revalidated the frontier against the exact frozen `sfl-v0-slice1-acceptance-v1` snapshot and its manifest applicability boundary. No prohibited retrospective screen/MA material was encountered.

## B. Candidate position / alias frontier

Classification language here is deliberately non-prescriptive:

- **Plausibly meaningful** — the same PersonId occupancy produces a coherent semantic shape whose consequences need explicit classification.
- **Worth classification** — accepted Slice-1 authority does not itself settle the identity question, but aliasing would change a material semantic dimension.
- **Structurally impossible** — already accepted type/cardinality/role semantics make the alias incoherent; this is recorded so absence is not confused with an unexamined case.

| ID | Slice-1 meaning | Position A | Position B / other position | Classification | Why alias matters | Confidence |
|---|---|---|---|---|---|---|
| AF-01 | Directed attitude | attitude `From` | attitude `To` | Worth classification | A self-directed edge would change relation identity/cardinality, direct-attitude batching, event participant cardinality, and any later use of the stored directed value. Accepted Slice-1 text defines direction and bounds but does not itself state a distinct-person endpoint rule. | HIGH |
| AF-02 | Kinship | first kin endpoint | second kin endpoint | Structurally impossible | Parent/child and sibling are two-person kinship meanings. Collapsing them to one person would destroy the accepted kinship meaning and would contaminate kin scoring and marriage-ineligibility gates. | HIGH |
| AF-03 | OfferGift | initiator / giver | target / recipient / responder | Worth classification | Alias would collapse independent proposer and responder cognition, combine personal initiative with a response in one person, turn the material debit/credit into one-person accounting, direct recipient→giver +10 onto a self edge, and reduce participant/provenance cardinality. | HIGH |
| AF-04 | RequestGiftOrHelp | requester / recipient | target / giver / responder | Worth classification | Alias would make the requester also decide whether to give to themself, combine initiative and response, collapse transfer endpoints, and make accepted-help +10 or genuine-need refusal -5 potentially self-directed. | HIGH |
| AF-05 | OfferLoan | initiator / lender / giver / creditor | target / borrower / recipient / responder / debtor | Worth classification | Alias could create a self-debt from a self-transfer, collapse loan-granted +5 onto a self attitude edge, and propagate into repayment, due-cycle penalty, debt identity, history, and reserve accounting. | HIGH |
| AF-06 | RequestLoan | requester / borrower / recipient / debtor | target / lender / giver / responder / creditor | Worth classification | Same consequences as AF-05 with actor/material roles reversed: self-response, self-transfer, creditor=debtor relation identity, future repayment/due effects, and participant knowledge all change. | HIGH |
| AF-07 | Debt / repayment / due review | debt creditor | debt debtor | Worth classification | This is the relation-level version of the loan question. If endpoints alias, repayment material source/destination, the debtor reserve rule, lender→borrower +5, creditor→debtor -10 due consequence, direct-participant knowledge, and debt history all collapse onto one PersonId. | HIGH |
| AF-08 | ExplicitBenefitForFavor | initiator / material benefactor / prospective favour holder | target / material recipient / prospective favour debtor / responder | Worth classification | Alias would make both legs of the atomic bargain self-referential: material transfer identity, one ordered-pair favour slot `(P,P)`, response autonomy, favour provenance, and later CallFavor topology all change together. | HIGH |
| AF-09 | RelationshipMediatedReciprocalHelp | material giver / benefactor | material recipient / prospective favour debtor | Worth classification | Alias would turn help into a self-transfer, make the recipient-attitude-toward-benefactor favour gate self-directed, and potentially create a self-favour. The current implementation also has offer-form and request-form action shapes that reverse which of actor/target is giver, so both role alignments belong in classification. | HIGH |
| AF-10 | Favour relation | favour holder | favour debtor | Worth classification | A self-favour would occupy ordered-pair capacity `(P,P)`, make holder/debtor provenance coincide, and feed directly into CallFavor initiative/response topology and reciprocal-cancellation preconditions. The accepted “ordered person-pair” capacity rule does not itself state whether diagonal pairs exist. | HIGH |
| AF-11 | CallFavor | holder / initiator | favour debtor / called actor / fulfiller-or-refuser | Worth classification | If holder and called actor alias, one person spends the ordinary personal initiative to call the favour and also receives the response decision context. Fulfilment/refusal cognition, favour consumption, +10/-20 direction, failed-attempt knowledge, and requested-action execution all become self-referential. | HIGH |
| AF-12 | CallFavor(RepayDebt) | outer favour holder | inner debt creditor | Plausibly meaningful | The callable repayment can involve a passive debt creditor distinct from the called debtor. If holder=creditor, successful repayment contributes creditor→debtor +5 and called-favour holder→fulfiller +10 to the same directed pair, changing direct-cause batching/provenance from two edges to one edge with two causes. If distinct, history has a genuine third participant position. | HIGH |
| AF-13 | CallFavor(RepayDebt) | called actor / favour debtor / repayment actor | inner debt creditor | Worth classification | This is the nested form of AF-07. If the inner debt itself is diagonal, the called actor is also the creditor; material transfer identity, repayment attitude direction, response participant cardinality, and three-role CallFavor topology all collapse. | MEDIUM |
| AF-14 | Reciprocal favour cancellation | A in “A owes B” | B in “B owes A” | Structurally impossible | With A=B the two required independent reciprocal outstanding favours address the same ordered pair, while accepted Slice-1 cardinality permits at most one outstanding favour per ordered pair. The cancellation’s two-relation precondition therefore cannot retain its accepted reciprocal meaning on a one-person collapse. | HIGH |
| AF-15 | Residence move proposal | proposer / mover | named dwelling counterpart / responder | Structurally impossible | Slice-1 semantics say a person proposes moving to **another person's** dwelling. Collapsing mover and counterpart removes the accepted bilateral proposal/acceptance structure and changes residence-transition identity. | HIGH |
| AF-16 | Residence invite proposal | inviter / dwelling-side proposer | invitee / mover / responder | Structurally impossible | Slice-1 semantics say a person invites **another person** into their dwelling. A one-person collapse removes the bilateral response and changes who owns the personal initiative versus whose Residence would transition. | HIGH |
| AF-17 | Same-cycle Residence competition | person whose Residence changes in one accepted effect | mover/invitee position in another independently accepted Residence effect | Plausibly meaningful | Accepted Slice-1 semantics explicitly anticipate multiple independently accepted Residence changes for the same person. The same PersonId can therefore sit in different action positions across contenders; this changes response history, initiative-versus-response accounting, conflict-set identity, winner/invalidation provenance, and stable fallback sensitivity. | HIGH |
| AF-18 | Direct marriage bypass | groom / initiator | bride / response counterparty | Structurally impossible | Accepted roles require groom=male and bride=female in a two-party marriage relation. With the v0 sex type, one PersonId cannot occupy both direct-marriage endpoints. | HIGH |
| AF-19 | Direct marriage cardinality across proposals | bride in one incoming proposal | bride in another incoming proposal | Plausibly meaningful | Response contexts may activate multiple times for one target from the common snapshot, while established marriage is at-most-once per person. Multiple accepted proposals sharing one bride would therefore test cardinality, commit-time revalidation, invalidation history, and whether accepted responses remain true history. | MEDIUM |
| AF-20 | Personal initiative + response | actor using their one voluntary personal initiative | response target on another proposal in the same cycle | Plausibly meaningful | This identity is central to Slice-1 agency accounting: responses do not consume/grant initiative and may coexist with personal action. Alias affects decision traces, subjective inputs, proposal chronology, and any scarce-resource conflict between the person's own action and accepted incoming responses. | HIGH |
| AF-21 | Multiple ResponseDecisionContexts | target of one incoming proposal | target of another incoming proposal | Plausibly meaningful | Slice-1 explicitly permits multiple response contexts and multiple Accept/Fulfil selections for one target from a common snapshot. Same-target alias can concentrate material obligations, Residence effects, marriage capacity, or other commit-time conflicts without turning later invalidation into retroactive refusal. | HIGH |
| AF-22 | Same-cycle material conflict | material source in one accepted transfer | material source in another accepted transfer | Plausibly meaningful | A single person's grain can back multiple independently accepted interactions from the common snapshot. Alias changes the scarce-resource conflict set, revalidation/invalidation topology, outcome provenance, and deterministic-order sensitivity. | HIGH |
| AF-23 | Same-cycle material role inversion | giver/source in one accepted interaction | recipient in another accepted interaction | Worth classification | Cyclic or chained transfers can make one PersonId both debit and credit endpoint in the same cycle. Because uncommitted effects are not visible during response decisions but commits revalidate current state, role inversion can change material dependency/order sensitivity and semantic history. | HIGH |
| AF-24 | Favour capacity / lifecycle across concurrent interactions | debtor/holder pair created by BFF or qualifying reciprocal help | debtor/holder/caller/cancellation positions in another accepted interaction | Worth classification | Reusing the same ordered pair across accepted interactions can turn two otherwise separate proposals into a capacity, creation-versus-retirement, or consume-versus-cancel conflict. Person-position aliasing therefore changes favour relation identity and atomic invalidation topology. | HIGH |
| AF-25 | Failed-attempt knowledge/provenance | initiator direct-participant position | counterparty/called-actor direct-participant position | Worth classification | Any within-action self-alias above would reduce a nominal two-party failed attempt to one unique PersonId. That changes participant-set cardinality, acquisition/provenance duplication questions, and what “direct participants learn” means without changing the objective non-commit rule. | HIGH |
| AF-26 | Same-cycle direct attitude composition | source/target pair produced by one fixed consequence | source/target pair produced by another consequence | Plausibly meaningful | Role aliases can make otherwise different semantic causes land on the same directed attitude edge. The accepted sum-then-clamp rule groups by directed pair while preserving each cause. Holder=creditor in called repayment is a concrete topology; self-target candidates can also collapse a cause onto `P→P`. | HIGH |

### Implementation-observed position shapes added after the independent semantic inventory

These observations are included only because the dispatch explicitly permits post-inventory implementation inspection for additional shapes:

1. Relationship-mediated reciprocal help currently has both a giver-first and requester-first form; therefore actor/target cannot be assumed to map permanently to giver/recipient in only one direction.
2. `CallFavor(Favour, RepayDebt(Debt, amount))` exposes three potentially relevant person positions: outer holder, called actor/favour debtor/repayer, and inner debt creditor.
3. Same-cycle dependency logic recognizes overlapping material participants, shared Residence movers/destination-side people, shared marriage capacity, and shared favour create/retire pairs. These are implementation evidence that the cross-action position shapes exist, not authority for how aliasing should be semantically classified.
4. Generic implementation guards currently reject same-person relation/action parties. Per dispatch instruction, that behavior is deliberately **not** used as evidence that AF-01/03-13 are semantically prohibited.

## C. Structurally impossible aliases

### C1. Impossible from already accepted Slice-1 type/cardinality/role meaning

The following are not merely “not shown in examples”:

- **Kinship endpoint collapse (AF-02):** parent/child and sibling are two-person kinship meanings; a person cannot occupy both endpoints of one such relation without destroying the accepted relation type.
- **Reciprocal-favour cancellation A=B (AF-14):** the accepted operation requires two independent opposite-direction outstanding favours, while at most one outstanding favour may exist per ordered pair. If A=B, the two ordered pairs coincide.
- **Residence move mover=counterpart (AF-15):** the accepted text says moving to **another person's** dwelling.
- **Residence invite inviter=invitee (AF-16):** the accepted text says inviting **another person**.
- **Direct-marriage groom=bride (AF-18):** groom and bride are sex-typed male/female roles in v0.
- **PersonId versus DwellingId:** Residence itself is a typed person→dwelling relation, so the person endpoint cannot alias the dwelling endpoint as a PersonId question.

### C2. Not established impossible merely because examples or current code use distinct people

Pass A does **not** infer a semantic prohibition for any of the following solely from current guards, fixtures, or ordinary examples:

- directed attitude `From=To`;
- gift/help actor=counterparty;
- lender/borrower or creditor/debtor identity;
- explicit-benefit benefactor=favour debtor;
- reciprocal-help benefactor=recipient;
- favour holder=debtor;
- CallFavor holder=called actor;
- outer CallFavor holder=inner debt creditor;
- one person's repeated appearance across multiple response contexts;
- one person's repeated or inverted material roles across independently accepted same-cycle interactions;
- repeated person positions that make different direct attitude causes converge on the same directed pair.

Those remain frontier items unless and until the authoritative reconciliation classifies them.

## D. Areas considered with no additional meaningful alias issue

The following Slice-1 areas were considered but add no independent person-position alias question beyond rows already listed:

- **Consumption, NeedsGrain maintenance, and ordinary Farm:** each is unary in person identity. A called Farm adds only the outer holder/called-actor topology already covered by AF-11.
- **Grain amount validity and the repayment two-grain reserve:** these are numeric/domain constraints; their person-role consequences are already captured by transfer/debt rows.
- **Attitude saturation/decay arithmetic:** no new person roles beyond the directed `From/To` edge and multi-cause convergence already covered by AF-01/AF-26.
- **Meaning separation among Gift/Loan/BFF/RMRH:** important semantically, but its alias surface is the giver/recipient/debt/favour role mapping already enumerated.
- **Marriage-versus-Residence causal separation:** important, but it creates no new within-action PersonId role pair beyond AF-15/16/18 and the cross-proposal Residence row.
- **ProposalId, EventId, RelationId, and DwellingId identity:** these are distinct typed identities, not PersonId-position aliases.
- **Stable-ID fallback, observer noninterference, derived-state rebuild concerns, and reaction idempotence:** they can expose ordering bugs caused by aliasing but do not introduce additional social PersonId roles.
- **General communication, household formation/participation/role semantics, household-mediated marriage, and other later-slice collective meanings:** excluded by the frozen Slice-1 applicability manifest and not imported into this frontier.

## E. No semantic conclusions

This Pass A report maps the **classification frontier only**.

It does **not** decide that any AF row is allowed, prohibited, required, or impossible except where Section C records an impossibility already entailed by accepted Slice-1 type/cardinality/role semantics. It does not recommend validation rules, change current code, reinterpret frozen acceptance, or promote implementation behavior into semantic authority.

In particular, the presence of a current self-party guard is not a conclusion about Slice-1 semantics, and the presence of a technically representable alias is not a conclusion that Slice-1 should allow it. Those decisions belong to the later SID reconciliation/authority process.
