# SFL v0 Slice 4 — SID-ASSURANCE-v1 Master Architect Frontier and Delta Audit

**Status:** MA PILOT WORKING ARTIFACT / WITHHELD FROM PASS-A REVIEWER  
**Date:** 2026-09-24  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Semantic-interaction-delta trigger:** **FIRED**  
**Delta semantic base:** canonical `main` @ `3fd94b4000df176e3bf7e4a4a93eb8ccdaf14747`  
**Blocked implementation boundary:** `sfl-v0-slice4-implementation-boundary-blocked-v1` @ `7ce569456c87297e7349b3ca7d7917c5e30b1b88`  
**Purpose:** Master Architect side of the first SID pilot. This artifact MUST NOT be shown to the fresh Pass-A reviewer before their independent frontier is durably frozen.

## 1. Trigger judgment

**FIRED.**

Slice 4 introduces/materially changes multiple semantic layers that interact with established Slices 1–3:

- persistent Household head role/occupancy;
- actor-specific Recognition of head/scope;
- separate HouseholdDecisionContext carried by one person who retains personal agency;
- endogenous provision acquisition/reconsideration;
- actual Household material spending;
- mediated marriage through role authority;
- DEC-0010 authority-use before authority destruction;
- DEC-0011 exact transaction-specific private supplementation;
- succession/vacancy/lifecycle effects over existing participation, commitments, knowledge, resources and personal relations.

This is a textbook new↔old interaction frontier under SID-ASSURANCE-v1.

## 2. Controlling accepted semantic base

Primary:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` @ blob `038d5f1dde169d85d11bd05951199ef35777593f`;
- `decisions/DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md` @ blob `51e28b4945aea92416c3d3653b71cb12b6cb675a`;
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md` @ blob `06001ebe2c0eb3858eb439e5465a10097d36a54b`;
- accepted ADRs and frozen Slice-1/2/3 authority.

Canonical verification owners used as subordinate semantic-instantiation evidence:

- head/dual mode: `adf73dd73f63e358964a19c4e7501e54e9d4db23`;
- provision: `3ff34a61b3a1801d29980be53948cf1fc8bf1942`;
- response: `bff2dbba9e86609023a3f47c88509def87906ca1`;
- resolution/reaction: `d143c6c702096cb4b56024553a5a0a9ec371405f`;
- recognition/information: `d8f87dea9569d41481850c7327a025c44d6c3358`;
- cross-cutting contract: `37124a9963162b7f64c406ec230d0f3fe7eadd0f`.

Historical frozen Slice-4 acceptance v1 is evidence of the pre-DEC-0011 boundary only; it is operationally blocked and is not allowed to close newly discovered semantic questions.

## 3. MA interaction frontier

| Frontier ID | New/changed Slice-4 surface | Existing affected capability/path | Why interaction is plausible |
|---|---|---|---|
| F01 | Head role occupancy | Person ordinary personal agency | Same person carries role and personal initiative simultaneously. |
| F02 | HouseholdDecisionContext | Personal decision context / response accounting | Same cognitive carrier gets separate initiative/context from same snapshot. |
| F03 | Head authority | Personal grain ownership/control | Office act may combine with holder private resource authority under DEC-0011. |
| F04 | Actual Household expenditure | Persistent provision commitments | Existing backing now becomes executable debit rather than derived capacity only. |
| F05 | DEC-0011 private X | Head's persistent provision commitment | Same grain stock may appear through two distinct funding provenance channels. |
| F06 | Household material action | Head's ordinary personal material action | Same-cycle competition for personal grain/capacity. |
| F07 | Provision request/reconsideration | Target personal response autonomy | Institutional request must not turn target response into head choice. |
| F08 | Provision request/reconsideration | Head as possible current SustainingParticipant / private owner | Requester and target positions may alias. |
| F09 | Household support | Existing NeedsGrain / personal support semantics | New institutional route clears an old personal need state and may overlap participant/head positions. |
| F10 | Household support | Head as possible recipient | Recipient and institutional authorizer positions may alias. |
| F11 | Head nomination/appointment | Current-participant response/unanimity | Nominator and nominee are themselves current participants in the unanimity set. |
| F12 | Head nomination/appointment | Nominee response | Nominee necessarily aliases one required current participant; self-nomination may collapse nominator/nominee too. |
| F13 | Succession | Existing role identity / participation / commitments | Occupant changes while H/role and personal relations/backing may persist. |
| F14 | Head participation end/vacancy | Participation end / commitment termination / continuity | One transition changes participant, role, backing and possibly H lifecycle. |
| F15 | Active↔Inactive | Existing occupied role and commitments | Institutional action availability changes while H identity and some role/backing state may persist. |
| F16 | Dissolution | Role occupancy / commitments / pending Household effects | Last participation transitions terminate capability while history persists. |
| F17 | Head Recognition | Existing subjective H Recognition/KnownFact | Objective office state must not become passive subjective synchronization. |
| F18 | Participation entry after role appointment | New participant subjective head Recognition | Existing participation route can create a person who belongs to H but did not witness the role transition. |
| F19 | Mediated marriage | Existing direct marriage route | New institutional route must not shadow or rewrite mutual-strong-like direct route. |
| F20 | Mediated marriage | Bride/head/groom semantic positions | Explicit legal/prohibited aliases already exist and interact with authority/favour. |
| F21 | Mediated marriage funding | Existing commitment/private grain | Dowry combines institutional authority, personal contributors and DEC-0011 X. |
| F22 | Household-originated support/spend | Formation/continuity/lineage evidence | New support must not self-confirm H or satisfy old organizational evidence gates. |
| F23 | Household actions | Existing lower-level attitudes/favours | New institutional material effects must not silently masquerade as personal Gift/Help/favour consequences. |
| F24 | DEC-0010 last-act priority | Existing participation/status transitions | Old valid transitions now receive a narrow semantic ordering when authority/status would be destroyed. |
| F25 | Role/Household caches/state | Existing derived-state/nonauthority discipline | New authority must remain explicit and cannot hide in derived indexes. |
| F26 | Inactive reactivation | Persisting role occupancy/Recognition | H may regain Household action capability without recreating identity/role. |
| F27 | Role changes | Ordinary personal relations/residence/debt/favour | Appointment/succession must not erase or commandeer person-level state. |
| F28 | Lineage | New role/provision state | Existing lineage explicitly transfers no authority/resources/pending process. |

## 4. Old-world projection / preservation checks

These are not universal conservative-extension demands; each is grounded in accepted authority.

| ID | Prior capability/path | Neutral / relevant projection | MA disposition | Authority basis |
|---|---|---|---|---|
| P01 | Ordinary personal gift/loan/favour/residence actions | Same person happens to be head but no role action is selected | **PRESERVED** | SPEC §6.6 ordinary person-person actions independent of Household Recognition; §8.4 role cannot command ordinary actions; S4-061/S4-162 verification. |
| P02 | Direct mutual-strong-like marriage | Bride happens to be in H/head exists | **PRESERVED** | SPEC §4.1/4.2 direct bypass independent of mediation; S4-111/S4-114. |
| P03 | Personal grain ownership | Person becomes head | **PRESERVED** | SPEC §8.1/8.4 + DEC-0011: office does not expose/seize grain. |
| P04 | Existing provision commitment | Contributor becomes/is replaced as head without ending participation | **PRESERVED** | Appointment/succession does not create/delete backing; participation end/dissolution own termination rules. |
| P05 | H numerical identity / continuity | Representative changes | **PRESERVED** | SPEC §7.5: representative succession does not itself break H identity. |
| P06 | Participation/admission semantics | H gains a head | **PRESERVED** | SPEC §7.4: head has no general admission authority. |
| P07 | H/actor Recognition separation | Objective head role exists | **PRESERVED** | SPEC §6 + S4-030/S4-038/S4-141: structural status does not grant information entitlement. |
| P08 | Slice-3 backing-only state | Slice-4 types exist but no valid active/occupied authority action path fires | **PRESERVED through adapted enforcement** | Frozen S3 semantics + S4-170..175 adaptation requirement. |
| P09 | Lineage nonauthority | Successor/predecessor H later gains heads/resources | **PRESERVED** | SPEC §7.7 explicitly transfers no resources/authority/roles/pending processes. |

## 5. Delta classification — currently closed / authority-supported

| ID | Frontier | Delta type | Before | Slice-4 delta | Disposition / authority |
|---|---|---|---|---|---|
| D01 | F01/F02 | NEW_AFFORDANCE | One personal initiative only | Head carries one personal + one H initiative from same snapshot | **SUPPORTED** — SPEC §8.5; responses consume neither. |
| D02 | F03 | NEW_AFFORDANCE | Office absent | Holder may combine role authority with exact private X | **SUPPORTED** — DEC-0011. |
| D03 | F05 | NEW_CONFLICT_OR_SHARED_CAPACITY | Commitment capacity only | Same P may have standing commitment + private X | **SUPPORTED** — DEC-0011 residual capacity/no double count. |
| D04 | F06 | NEW_CONFLICT_OR_SHARED_CAPACITY | Personal action consumes personal grain | H action may consume same person's grain/backing | **SUPPORTED** — SPEC §9.2 provision priority + live revalidation. |
| D05 | F07 | NEW_DEPENDENCY | Ordinary person response autonomy | Provision acquisition adds institutional request | **SUPPORTED** — target ResponseDecisionContext remains autonomous; head cannot choose response. |
| D06 | F13 | TRANSITION_CARRYOVER | No office occupant transition | A→B changes occupant under same role/H | **SUPPORTED** — same role identity; commitments/person-level state not role property. |
| D07 | F14 | TRANSITION_CARRYOVER | Participation end affects H substrate | Head exit also vacates role and terminates own commitment | **SUPPORTED** — SPEC §7.4 + §8.4; others preserved. |
| D08 | F15/F26 | SUPPRESSED_OR_NARROWED | Active H substrate existed without head mode | Inactive H suspends H initiative even if role occupancy persists; reactivation may restore capability | **INTENDED CHANGE** — SPEC §7.6/§8.5. |
| D09 | F17 | NEW_DEPENDENCY | H Recognition existed | Authority-channel use requires head/scope Recognition | **INTENDED CHANGE** — SPEC §6.6/§8.4; no passive sync. |
| D10 | F18 | NO_MATERIAL_DELTA to knowledge entitlement | New participant enters existing H | Participation status alone does not grant historical head-transition knowledge | **DERIVED CONSEQUENCE** — SPEC §6.4 own/direct-party knowledge + S4-038. |
| D11 | F19 | NEW_AFFORDANCE without erasure | Direct marriage only | Mediated route added | **SUPPORTED**, direct bypass preserved — SPEC §4. |
| D12 | F20 bride=head | PARTICIPANT_ALIAS | Bride and mediator assumed distinct in ordinary narrative | Female head may mediate own marriage | **SUPPORTED** — SPEC §4.2; S4-110. |
| D13 | F20 groom=head | PARTICIPANT_ALIAS | Groom and mediator assumed distinct | Same groom/head would self-authorize | **PROHIBITED** — SPEC §4.2; S4-109. |
| D14 | F21 | NEW_CONFLICT_OR_SHARED_CAPACITY | Dowry uses commitment backing | Dowry may combine commitment backing + exact holder X | **SUPPORTED** — DEC-0011. |
| D15 | F22 | CAUSAL_RETARGETING control | Person-person support can help form/continue H | H-originated support cannot prove its own organization | **PROHIBITED as evidence route** — SPEC §8.3/§7.7 + S4-091/S4-140. |
| D16 | F24 | NEW_DEPENDENCY / semantic ordering | Authority destruction could invalidate action | Otherwise-valid accepted last act resolves before paired destruction | **INTENDED CHANGE** — DEC-0010. |
| D17 | F27 | SUPPRESSED_OR_NARROWED control | Personal relations exist independently | Office transition must not erase/command them | **PRESERVED** — SPEC §7.4/§8.4. |
| D18 | F28 | TRANSITION_CARRYOVER control | Lineage stores ancestry only | Later role/resources do not transfer through lineage | **PRESERVED** — SPEC §7.7. |
| D19 | F23 | CAUSAL_RETARGETING control | Gift/Help/favour have person-level effects | DEC-0011 private funding leg is not separate Gift/Help/favour | **PROHIBITED as retargeting** — DEC-0011. |
| D20 | F14 + F24 + private X | TRANSITION_CARRYOVER / shared capacity | Head may exit | Accepted supplemented last act may commit before exit if all private/material preconditions still revalidate | **DERIVED CONSEQUENCE** — DEC-0010 + DEC-0011. |

## 6. Transition carryover table

| Transition | State that must be classified | MA current classification |
|---|---|---|
| Head appointment | H identity, role identity, person grain/residence/relations, commitments | H/role stable; ordinary personal state/backing unchanged; occupancy + direct transition-participant head Recognition added. |
| Succession A→B | H/role, A/B private property, commitments, pending old-head act, Recognition | H/role stable; commitments unchanged unless independent participation rule fires; no private X rebind; DEC-0010 governs accepted old-head last act; transition participants recognize B, outsiders may remain stale. |
| Head participation end | role occupancy, head's commitment, other commitments, H lifecycle, ordinary relations | role vacant; exiting person's commitment ends; others remain; H lifecycle/continuity reevaluates; ordinary person-level state not erased. |
| Active→Inactive | role occupancy, commitments, initiative/action availability | H identity persists; valid remaining commitments persist; no Household initiative; role may remain represented if holder is sole bearer. |
| Inactive→Active | role occupancy, commitments, H identity, newcomer head Recognition | H identity persists; valid existing role/commitment state persists; H initiative resumes only if role occupied; newcomer gets no passive historical head Recognition solely from participation. |
| Dissolution | H identity/history, role occupancy, commitments, pending H capability | historical H persists as Dissolved; commitments terminate; no future H initiative; role cannot have a current participating occupant after all participation ends; no resurrection. |

## 7. Material aliasing audit

### Already classified

| Alias | Classification | Authority |
|---|---|---|
| head = private transaction contributor | **SUPPORTED** | DEC-0011 |
| head = standing provision contributor (existing commitment) | **SUPPORTED** | SPEC §8.1 + role change does not alter commitments |
| head = bride | **SUPPORTED** | SPEC §4.2 / S4-110 |
| head = groom | **PROHIBITED** | SPEC §4.2 / S4-109 |
| outgoing/former head = continuing provision contributor after succession while still participant | **SUPPORTED** | commitments are participation/person relations, not office property |
| bride=head=private supplementer for her own mediated marriage dowry | **DERIVED CONSEQUENCE** | allowed bride=head + DEC-0011; no rule forbids X on this permitted H material use |

### MA-identified unresolved aliases / compositions

These are **not closed by frozen Slice-4 acceptance v1** and must remain visible through Pass A/Pass B.

#### U01 — head = Household support recipient

Current authority says:

- eligible needy current SustainingParticipant may receive H support;
- current head is necessarily a current SustainingParticipant;
- head may authorize/proactively propose support;
- no explicit rule says the head may or may not be the support recipient.

If head = recipient, the same person carries:

- beneficiary/private person position;
- institutional cognitive carrier/authorizer position.

Questions include whether this is valid institutional self-support, whether a request/response topology changes, and whether any anti-self-authorization principle applies beyond the explicitly groom-specific rule.

**MA classification:** `UNRESOLVED`.

#### U02 — current head = target of persistent provision-commitment acquisition/reconsideration

Current authority permits head to request commitment from a noncontributing current SustainingParticipant. It does not explicitly classify requester=head and target=head.

DEC-0011 removed self-negotiation theatre only for **transaction-specific private X**, not necessarily for creating a reusable persistent commitment.

A person may already possess a commitment and later become head, but current authority does not clearly state whether an already-appointed head can newly create/reconsider their own persistent commitment or what consent topology applies.

**MA classification:** `UNRESOLVED`.

#### U03 — nominee acceptance versus unanimity-participant acceptance

Every nominee is a current SustainingParticipant, and every current SustainingParticipant belongs to the unanimity set.

Current authority separately requires:

- nominee acceptance; and
- unanimous current-participant acceptance/recognition.

It does not clearly state whether the nominee's acceptance simultaneously satisfies their member-of-unanimity acceptance, or whether the same person must produce two semantically distinct acceptances/response events.

This alias is mandatory in every appointment, not an exotic edge case.

**MA classification:** `UNRESOLVED`.

#### U04 — nominator's nomination versus nominator's unanimity acceptance

Every nominator is also a current SustainingParticipant in the unanimity set.

Current authority does not clearly state whether:

- nomination itself constitutes the nominator's appointment acceptance; or
- the nominator must separately accept/recognize the resulting appointment as a participant.

**MA classification:** `UNRESOLVED`.

#### U05 — self-nomination (nominator = nominee)

SPEC says any current SustainingParticipant may nominate a current SustainingParticipant and does not explicitly require distinct IDs.

If self-nomination is permitted, U03/U04 collapse further and may otherwise create self-proposal/response theatre.

If prohibited, that inequality is not currently explicit.

**MA classification:** `UNRESOLVED`.

#### U06 — appointment/succession while H is Inactive

SPEC makes Household action capability require Active H, but role occupancy can remain represented while H is Inactive and the appointment text itself does not explicitly state an Active-only gate.

Questions:

- may a headless Inactive H's sole continuity bearer appoint a head?
- may an Inactive occupied role undergo succession?
- or are role transitions themselves suspended until H becomes Active?

Current canonical verification exercises appointment on Active H but that example cannot create the missing semantic gate.

**MA classification:** `UNRESOLVED`.

## 8. Current MA pilot status

- `Semantic-interaction-delta trigger: FIRED`
- `Delta semantic base: main@3fd94b4000df176e3bf7e4a4a93eb8ccdaf14747`
- MA frontier: **DRAFT COMPLETE**
- MA delta lenses: **DRAFT COMPLETE**
- transition carryover: **DRAFT COMPLETE**
- alias audit: **DRAFT COMPLETE**
- MA unresolved: **6**
- Independent frontier Pass A: **NOT YET RUN**
- Pass B negative-space challenge: **NOT YET RUN**
- Closure freshness: **CURRENT as of this working branch's semantic base**, but no pilot closure may be claimed before independent passes and reconciliation.
- `Consequential unresolved: 6` (MA provisional)
- `Accidental gaps outstanding: 0` (not yet independently challenged)

## 9. Independence rule

Do not merge this artifact to `main` or expose it to the Pass-A reviewer before their independent candidate frontier is durably frozen.

The Pass-A dispatch must not name U01–U06 or otherwise leak this MA frontier.

After Pass A is frozen, this artifact may be revealed in Pass B and reconciled against the reviewer frontier union.
