# SFL v0 Slice 4 — SID Pass A Independent Frontier

## A. Independence statement

**Pass:** A — independent frontier discovery only  
**Dispatch ref:** `sfl-v0-slice4-sid-passa-dispatch-v1`  
**Exact baseline commit:** `179e955e5398f954b56e73f93954a595f75d4653`

This report was produced from the exact dispatch baseline above before inspecting any Master Architect frontier or Pass-B reconciliation material.

I did **not** read:

- branch `sfl-v0-slice4-sid-ma-frontier-v1`;
- branch `planning/slice4-sid-ma-frontier-v1`;
- `research/technical/SFL_V0_SLICE4_SID_MA_FRONTIER_AND_DELTA_AUDIT.md`;
- any future Pass-B task or MA/reviewer frontier reconciliation;
- frozen/current Slice-4 acceptance manifests or acceptance-row catalogues;
- Slice-4 acceptance pre-code review reports;
- the Director's private-supplement clarification/reconciliation or historical defect discussion;
- GOV-0002 hostile challenge/reconciliation or policy-development debate.

**Contamination disclosure:** none.

Allowed/current authority consulted for adjacency discovery included the dispatch task packet, `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`, the formation/continuity/lineage/recognition verification families, the response-decision and resolution/reaction families, the cross-cutting verification contract, and accepted DEC-0010 / DEC-0011.

## B. Candidate frontier table

| ID | New Slice-4 surface | Prior semantic surface/path | Interaction mechanism | Why plausibly adjacent | Confidence |
|---|---|---|---|---|---|
| F-01 | Separate `HouseholdDecisionContext(H, head=P)` while P keeps ordinary agency | One voluntary personal initiative; ordinary candidate generation/scoring | participant alias; authority/control; topology/path | The same `PersonId` can simultaneously be the ordinary actor and the carrier of a Household decision context. Their deliberations are separate but can produce same-cycle effects whose feasibility or resources intersect later. | HIGH |
| F-02 | Role-scoped Household acceptance, including funding-plan variants | `ResponseDecisionContext(target, proposal)` autonomy and initiative accounting | gate/precondition; authority/control; participant alias | A current head can be a counterparty responder without the response consuming personal initiative, while role validity determines which response meanings exist. The same response path can also carry explicit holder-private funding consent, creating a direct junction between prior response semantics and the new role layer. | HIGH |
| F-03 | Household actions whose authority/capacity may change before commit | Central revalidation; `Declined` / `Unable` / `InvalidatedAtResolution` distinction | gate/precondition; resource/capacity; causal/provenance | Slice-4 attempts remain proposals until central commit, so head validity, lifecycle, grain, commitments, and other prerequisites can change after deliberation. The prior failure taxonomy and bounded retry semantics therefore sit directly on the execution path. | HIGH |
| F-04 | Authority-use-before-authority-destruction | Generic conflict ordering and stable-ID technical fallback | authority/control; lifecycle/transition; topology/path | Slice 4 adds a semantic precedence for a valid last act when a same-cycle transition would destroy required authority/status. That precedence shares the same resolver with prior domain priorities and the generic equal-priority fallback, so their ordering boundaries are materially adjacent. | HIGH |
| F-05 | Transaction-specific private supplementation plus commitment-backed residual funding | Personal grain, protected reserve, `NeedsGrain`, and personal ownership | resource/capacity; participant alias; causal/provenance | Both funding legs ultimately debit personal grain while preserving distinct authority/provenance. The head can also be a standing contributor, so the same stock may appear through two semantic channels and must meet prior reserve/`NeedsGrain` boundaries. | HIGH |
| F-06 | Actual Household material expenditure | Ordinary personal Gift/Help/Loan-style material actions from the same scarce grain stock | resource/capacity; topology/path | A head or contributor may have accepted personal material effects in the same cycle as Household spending. The prior central scarce-capacity machinery and material-priority path can therefore change which accepted effects remain commit-feasible. | HIGH |
| F-07 | Household/private funding by an actor who may also owe debt | `RepayDebt` feasibility and debt's non-reserving claim semantics | resource/capacity; gate/precondition | Debt repayment draws from the same personal grain stock but has its own amount/reserve semantics and does not itself reserve grain. Same-cycle Household funding can therefore alter repayment feasibility, or vice versa, through ordinary revalidation. | MEDIUM |
| F-08 | Household-mediated marriage creates a groom-to-head favour | Existing favour-slot cardinality, favour identity, and later favour lifecycle | relationships/claims; gate/precondition; participant alias | The mediated route introduces a new transaction that depends on and creates an ordered person-pair claim. Existing favour occupancy and the identity of the head/groom positions can therefore materially affect reachability and downstream claim history. | HIGH |
| F-09 | Household/role-authorized actions become new tempting requested actions | Called-favour response-closed payload boundary | authority/control; topology/path; gate/precondition | Prior favour semantics categorically constrain payloads that require household/role authority or further voluntary responses. The addition of executable Household actions creates a new adjacency at that payload-validity boundary even though the favour mechanism itself is older. | HIGH |
| F-10 | Household-mediated marriage route | Existing mutual-strong-like marriage bypass, kinship exclusion, and at-most-once marriage state | gate/precondition; relationships/claims; topology/path | Both routes converge on the same persistent marriage relation and eligibility/cardinality state while using different gates and side effects. A newly available mediated path can therefore interact with prior direct-route reachability and marriage-state constraints. | HIGH |
| F-11 | Mediated marriage and Household participation/head state | Residence-change proposal path and marriage-driven co-residence incentive | relationships/claims; lifecycle/transition; topology/path | Marriage can change later residence incentives, while residence itself remains distinct from Household participation and does not automatically move spouses or edit participation. The new mediated route therefore feeds an older proposal path without collapsing the two state dimensions. | MEDIUM |
| F-12 | Provision-commitment request/reconsideration by the current head | Directed attitude and time/context-sensitive reconsideration inputs | gate/precondition; knowledge/Recognition; lifecycle/transition | Reconsideration eligibility explicitly depends on elapsed cycles plus context that includes attitude toward the head and head-occupant change. Succession or attitude evolution can therefore retarget or reopen the older timed decision boundary. | HIGH |
| F-13 | Actor-specific Recognition of current head/scope | `KnownFact`, Recognition, communication, staleness, and `Contested` evidence | knowledge/Recognition; gate/precondition; causal/provenance | Objective succession/vacancy does not passively synchronize outsiders. Household-specific action routing can therefore differ across actors until newer observation/communication changes their evidence state. | HIGH |
| F-14 | Slice-4 action failure caused by head/lifecycle/funding changes | Direct-party failed-attempt knowledge with bounded reasons | knowledge/Recognition; causal/provenance; gate/precondition | A role-scoped attempt can fail for authority, eligibility, or capacity reasons after participants have already acted. The prior information contract determines what participants learn from that failure without exposing unrelated private state. | HIGH |
| F-15 | Head occupancy, provision commitments, and Household action scope | `SustainingParticipant` entry/end plus Participation/ParticipationEnd warrants | lifecycle/transition; authority/control; read/write | Participation is the prior typed association on which head eligibility and several Household actions depend. Ending participation can also terminate that person's provision commitment, vacate the role, and trigger lifecycle reevaluation, creating a dense transition boundary. | HIGH |
| F-16 | Same-cycle authority-use-before-destruction | Existing same-cycle continuity bridge-handoff precedence | lifecycle/transition; authority/control; topology/path | Slice 3 already contains a narrow semantic order for an entry that depends on a bridge who also exits. Slice 4 adds a different narrow precedence around authority/status destruction, so histories containing both causal structures are a plausible interaction frontier. | HIGH |
| F-17 | Lifecycle-sensitive Household action availability | Prior Active / Inactive / Dissolved lifecycle semantics | lifecycle/transition; gate/precondition | Household-mode initiative and mediated/material capability depend on operational lifecycle, while lifecycle is only authoritative at stable closure. Participant-count transitions can therefore enable, suspend, or terminate access to the new action layer across cycle boundaries. | HIGH |
| F-18 | Persistent head/provision state attached to H | Household numerical continuity across participant turnover | lifecycle/transition; causal/provenance; authority/control | Prior continuity allows the same Household identity to survive complete founder turnover. Persistent role/provision/recognition state attached to that identity may therefore cross participant replacement boundaries and interact with who currently carries authority or backing. | HIGH |
| F-19 | Household-originated support and holder-private supplementation | Formation/participation/continuity qualifying-support evidence | causal/provenance retargeting; gate/precondition | Prior Household identity mechanics rely on specific lower-level person-person support evidence and guard against organizational self-confirmation. New Household material effects and private funding provenance are close enough to those support histories that evidence classification belongs in the frontier. | HIGH |
| F-20 | Persistent roles, commitments, claims, Recognition, and pending Household effects | Controlled lineage / `DerivedFrom` historical derivation | lifecycle/transition; causal/provenance retargeting | Lineage creates links between distinct Household identities while prior lineage semantics separately track what is historical derivation versus causal state. The new persistent institutional surfaces make transfer, termination, or non-transfer across that boundary materially relevant to inspect. | HIGH |
| F-21 | Succession, vacancy, lifecycle change, and Household effects in one cycle | Automatic reaction closure and stable-cycle publication | lifecycle/transition; topology/path; causal/provenance | Several Slice-4 transitions can trigger downstream reevaluation while the prior temporal contract forbids a new actor-visible completed state until reaction closure. Intermediate role/participant states may therefore affect resolver/reaction causality without becoming stable-cycle state. | HIGH |
| F-22 | New head/Recognition/provision/funding state and histories | Stable-boundary checkpoint/restore and exact continuation | causal/provenance; lifecycle/transition; read/write | The prior continuation contract persists all future-influencing authoritative state and reproduces later history exactly. Slice 4 adds future-influencing role occupancy, recognition, funding provenance, cooldown/context baselines, and possibly pending effects that can enlarge that state boundary. | HIGH |
| F-23 | Same `PersonId` occupying multiple Slice-4 and prior positions | Existing person-role/relationship positions: sustaining participant, contributor, responder, bride/groom, creditor/debtor, favour holder/debtor | participant alias; authority/control; resource/capacity | A head can also be an ordinary actor, contributor, responder, relationship endpoint, and in some cases a marriage participant. Alias-sensitive histories can change self-authorization, claim cardinality, resource double-counting, or which authority channel a single person's act is using. | HIGH |

## C. Surfaces considered but excluded

- **Divorce, widowhood, remarriage, plural marriage, reproduction:** explicitly outside SFL v0; they do not form a current prior surface for Slice-4 adjacency.
- **General institutional treasury, reimbursement, credit, prestige, coercive office claims, or arbitrary participant supplementation:** these are broader finance/power models rather than existing v0 semantic paths.
- **General disputed succession, multiple simultaneous claimants, political contest, or office legitimacy beyond current Recognition:** broader governance semantics are deferred and are not required to identify the current frontier.
- **Markets, land, wages, prices, or general economic allocation:** grain is the bounded material substrate here; those wider systems are outside the current model.
- **Health, death, class/status, profession, personality, and demographic dynamics:** not current SFL v0 semantic surfaces, so they were not promoted into the frontier merely because they could eventually affect Household roles.

## D. Coverage self-check

The candidate frontier includes all requested coverage categories:

- **personal agency:** F-01, F-02, F-06;
- **resources/material accounting:** F-05, F-06, F-07;
- **subjective knowledge/Recognition:** F-13, F-14;
- **Household participation/lifecycle:** F-15, F-16, F-17, F-18;
- **relationships/claims:** F-08, F-09, F-10, F-11, F-12;
- **transition carryover:** F-16, F-18, F-20, F-21, F-22;
- **participant-position aliasing:** F-01, F-02, F-05, F-08, F-23.

## E. No semantic conclusions

This Pass-A report identifies candidate semantic-interaction frontier surfaces only.

It does **not** classify any candidate interaction as allowed, prohibited, deferred, or unresolved; it does not recommend a semantic rule; and it does not attempt the later negative-space-history or MA/reviewer frontier reconciliation work.
