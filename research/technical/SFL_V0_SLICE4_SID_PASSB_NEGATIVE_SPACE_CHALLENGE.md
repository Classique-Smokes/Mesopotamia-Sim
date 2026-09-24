# SFL v0 Slice 4 — SID Pass B Negative-Space Challenge

**Status:** PASS-B ADVISORY CHALLENGE / NO SEMANTIC DISPOSITION  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Pass-B dispatch:** `sfl-v0-slice4-sid-passb-dispatch-v1` @ `7162bea06ed87fb44db14940caf86dc9e20706c2`  
**Frozen Pass A:** `sfl-v0-slice4-sid-passa-v1` @ `6a15d40c2c8b9f54bba9c5f5e77a5806a9cee94e`, report blob `f42d3f1baec9d103462a95077038dd4032c09ae1`  
**Frozen MA frontier:** `sfl-v0-slice4-sid-ma-frontier-v1` @ `cd8c3ccf497bd8df928d5dee5f888188d98dd4ef`, report blob `029cd7a0d7d019ebbb1ccd75faddaa2760b199a4`  
**Frontier union:** `research/technical/SFL_V0_SLICE4_SID_FRONTIER_COMPARISON_AND_PASSB_UNION.md` @ blob `3432efb3be240c1171e9da77de83627ef6468072`

## 1. Preconditions / provenance check

The required Pass-A and Master Architect refs resolve to the exact commits named by the task, and the two report blobs match the pinned blobs above.

Pass A was therefore durably fixed before the MA frontier was revealed. No Pass-A provenance contamination was found.

The Pass-B union is present and internally consistent with those frozen inputs. I did not use the frozen pre-DEC-0011 Slice-4 acceptance manifest as semantic authority.

Controlling accepted semantic sources used here:

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` @ blob `038d5f1dde169d85d11bd05951199ef35777593f`;
- `decisions/DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md` @ blob `51e28b4945aea92416c3d3653b71cb12b6cb675a`;
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md` @ blob `06001ebe2c0eb3858eb439e5465a10097d36a54b`;
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` @ blob `5ff85234e91d3dbcb3779048e63ade1493105f02`;
- `plans/verification/SFL_V0/CONTINUITY_TURNOVER_FAMILY.md` @ blob `30e596a44df4eea868829c24b2fd4c3744d2a3c2`;
- `plans/verification/SFL_V0/HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` @ blob `adf73dd73f63e358964a19c4e7501e54e9d4db23`;
- `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md` @ blob `3ff34a61b3a1801d29980be53948cf1fc8bf1942`;
- `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md` @ blob `d8f87dea9569d41481850c7327a025c44d6c3358`;
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md` @ blob `d143c6c702096cb4b56024553a5a0a9ec371405f`.

No stop condition fired: the accepted sources are coherent enough to frame the challenges below without inventing a semantic rule.

## 2. Required frontier-comparison note

### Pass-A surfaces genuinely added or materially sharpened relative to MA

The reconciled comparison correctly retains several surfaces that were independently reviewer-added or more sharply isolated in Pass A:

- Household/private funding versus `RepayDebt` and the debt reserve/feasibility path (Pass-A F-07);
- the exact mediated-marriage favour-slot/cardinality seam (F-08);
- new Household/role action shapes against the older called-favour response-closed payload boundary (F-09);
- mediated marriage feeding the older residence/co-residence path without automatic residence mutation (F-11);
- provision reconsideration against attitude/time/head-change context (F-12);
- role-scoped failure against bounded direct-party failure knowledge/privacy (F-14);
- DEC-0010 authority-use precedence against the older continuity bridge-handoff precedence (F-16);
- succession/vacancy/lifecycle effects against reaction closure and stable publication (F-21);
- future-influencing Slice-4 state against the later checkpoint/restore seam (F-22).

These additions remain useful because they expose old-world paths that are not reducible to the six MA provisional unresolved aliases.

### MA-only surfaces that were useful surprises

The most useful MA-only additions were narrower than my Pass-A rows:

- the mandatory nominee/nominator/unanimity position overlaps, including self-nomination;
- current head as target of a persistent provision request/reconsideration;
- current head as Household-support recipient;
- appointment/succession while H is Inactive;
- a newcomer entering after an older role transition without automatically acquiring that transition's head-recognition evidence;
- the explicit hidden-derived-authority risk and the persistence of role state across Inactive reactivation.

The nomination-response cardinality cluster was the clearest surprise because the alias exists in every ordinary appointment, not only in an exotic edge case.

### REVIEWER PASS-B FRONTIER ADDITION — debt social-due reaction after shared-capacity collision

The justified union names Household/private funding versus debt repayment, but it does not separately name the accepted **debt social-due review and one-time creditor→debtor attitude consequence** that occurs after ordinary proposal resolution and repayment opportunities in the third subsequent full cycle.

That downstream surface is materially adjacent. If a new Household debit and an older `RepayDebt` attempt compete for the same person's grain in the due cycle, resolution can affect not only whether repayment commits but also whether the later automatic debt-due attitude consequence fires.

This addition introduces no new semantic rule. It only extends the challenge frontier to the already-accepted downstream reaction path in SPEC §§3.3, 9 and the lower-level/resolution verification families.

## 3. Pass-B challenge histories

### PB-01 — Full-private Household support with zero standing mobilizable capacity

#### Concrete history

1. H is Active with current sustaining participants P and B.
2. P is the valid current head.
3. No person has a persistent `HouseholdProvisionCommitment(* -> H)`, so `MobilizableCapacity(H) = 0`.
4. B is an eligible needy sustaining participant.
5. P has enough live disposable personal grain above the protected reserve.
6. P's Household context selects a 1-grain Household support action for B with total cost `C = 1`.
7. The action carries P's exact transaction-specific private term `X = 1`, so residual commitment-backed requirement `R = C - X = 0`.
8. At precommit, P still has disposable capacity for the exact X and every non-funding precondition remains valid.

#### Frontier sources

- Union U-B — material resource and claim competition.
- Union U-D — Household support.
- Union U-K — ordinary capability preservation / separation of authority channels.
- Pass-A F-05/F-06.
- MA F03–F05.

#### Why this could matter

DEC-0011 creates a transaction-funding path in which the current holder can carry the whole cost as exact private X while standing `MobilizableCapacity(H)` remains zero because that derived value is commitment-only.

An inherited gate phrased as “Household provision capacity must cover the action” could therefore suppress a transaction that the newer funding model represents differently. The semantic question is whether a zero standing mobilizable-capacity state is compatible with candidate/commit feasibility when `X = C` and `R = 0`, or whether some separate accepted gate still requires nonzero persistent backing.

This is especially worth reconciling because it is an ordinary boundary case of DEC-0011, not a new finance mechanism.

#### Existing authority that appears relevant

- DEC-0011: `X <= C`; `R = C - X`; examples explicitly include `X = C` with commitment requirement 0.
- DEC-0011: `MobilizableCapacity(H)` remains derived only from persistent commitments.
- SPEC §8.1.1: exact private term and residual commitment requirement.
- SPEC §8.5: Household action requires sufficient valid **transaction funding**, which may combine commitment-backed allocation and exact holder-private contribution.
- `PROVISION_GROUNDING_FAMILY.md`: standing capacity remains commitment-grounded while private-X verification is transaction-local.

#### Challenge classification

**possible missing affordance**

#### Confidence

**HIGH** that this deserves MA reconciliation.

---

### PB-02 — Household support and `RepayDebt` compete for the same head/debtor grain

#### Concrete history

1. H is Active. P is its current head and a sustaining participant.
2. P has personal grain = 5, is not `NeedsGrain`, and has a valid provision commitment to H.
3. P also owes creditor C a debt with remaining amount 3.
4. B is an eligible needy sustaining participant.
5. From the common decision snapshot:
   - P's one personal initiative selects `RepayDebt(3)`; at the snapshot this is materially feasible because it would leave P at the protected reserve of 2.
   - H's separate Household initiative through P selects 1-grain Household support to B, funded from P's live commitment-backed grain.
6. Each attempt is individually feasible from the snapshot, but both cannot debit P and still preserve the reserve:
   - if Household support commits first, P falls to 4 and `RepayDebt(3)` would then leave 1;
   - if repayment commits first, P falls to 2 and P exposes no remaining commitment-backed capacity.
7. Variant: make this C's debt social-due cycle, so unresolved repayment also feeds the later one-time debt-due attitude review.

#### Frontier sources

- Union U-A — dual personal / Household agency.
- Union U-B — Household/private funding + debt repayment.
- Union U-K — preservation of old personal capabilities under office.
- Pass-A F-01/F-05/F-07.
- REVIEWER PASS-B FRONTIER ADDITION — debt social-due reaction.

#### Why this could matter

SPEC §9.2 states that debt/favour do not automatically reserve grain and gives a material priority ordering of eligible Household support > other Household provision expenditure > ordinary voluntary personal transfer.

The question is whether `RepayDebt`, a typed debt-claim action with its own reserve rule, is included in “ordinary voluntary personal transfer” for this ordering or instead sits outside that row. The two readings can change which accepted effect survives revalidation. In the due-cycle variant they can also change whether the automatic creditor→debtor debt-due attitude consequence fires.

This is a possible narrowing of an old debt-repayment capability caused by a newly executable institutional spend, and the difference must not be chosen accidentally by proposal order or technical fallback.

#### Existing authority that appears relevant

- SPEC §3.3: repayment validity, reserve feasibility, debt social due.
- SPEC §8.5: separate Household initiative carried by the head.
- SPEC §9.2: live revalidation, non-reserving debt/favour, Household material priority.
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`: repayment reserve boundary.
- `RESOLUTION_REACTION_FAMILY.md` VS-SFL-072: support > other Household provision > ordinary personal transfer; no collection-order semantics.

#### Challenge classification

**possible accidental suppression/narrowing**

#### Confidence

**HIGH** that this deserves MA reconciliation.

---

### PB-03 — Bridge-dependent entry and succession both precede the same exit, but can change each other's live preconditions

#### Concrete history

1. H is Active with current sustaining participants A, B, and C; A is current head.
2. Outsider D has every participation prerequisite satisfied and an accepted bilateral participation proposal whose `ParticipationWarrant` explicitly depends on A as continuity bridge.
3. From the same committed snapshot:
   - D/A have accepted D's participation entry;
   - A has nominated B as successor;
   - B accepted, and current participants A/B/C accepted/recognized the succession;
   - A also has an accepted `EndHouseholdParticipation(H)` attempt.
4. The Slice-3 bridge-handoff rule requires D's bridge-dependent entry/continuity handoff to resolve before A's exit.
5. DEC-0010 can also protect the otherwise-valid A→B role transition from A's accepted status-destroying exit.
6. Neither narrow rule by itself orders **D entry versus A→B succession**.
7. If D entry commits first, D is now a current `SustainingParticipant` when the succession reaches precommit revalidation, but D never participated in the earlier unanimous acceptance.
8. If succession commits first, the accepted/unanimous cohort was A/B/C; D enters only afterward.
9. A's exit then resolves after the protected attempts.

#### Frontier sources

- Union U-E — appointment / nomination / succession.
- Union U-F — lifecycle / participation / continuity.
- Pass-A F-04/F-15/F-16/F-21.
- MA F13/F14/F24.

#### Why this could matter

SPEC §9.2 requires all action-relevant participant/status preconditions to revalidate immediately before commit. Appointment/succession requires unanimous acceptance/recognition by current sustaining participants.

The history therefore exposes a question about whether a just-committed bridge entry retargets the live unanimity set of an already-accepted succession, and whether any accepted semantic ordering governs the two separately protected effects.

Without semantic closure, generic ordering can become consequential: one ordering can leave the succession valid while another can introduce a newly missing acceptance from D. That is exactly the kind of interaction that neither narrow priority was written to decide in isolation.

#### Existing authority that appears relevant

- SPEC §7.4–7.5: `ParticipationWarrant`, continuity bridge, participation end.
- SPEC §8.4: succession requires nominee acceptance plus unanimous current sustaining-participant acceptance/recognition.
- SPEC §9.2: live participant/status revalidation.
- SPEC §9.2: narrow continuity bridge-handoff priority.
- DEC-0010 / SPEC §9.2: authority/status-dependent attempt before paired authority/status destruction.
- `CONTINUITY_TURNOVER_FAMILY.md` VS-SFL-013.
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` VS-SFL-061/063/067.
- `RESOLUTION_REACTION_FAMILY.md` VS-SFL-077.

#### Challenge classification

**possible causal retargeting/dependency gap**

#### Confidence

**HIGH** that this deserves MA reconciliation.

---

### PB-04 — Private-X invalidation may expose more private information than the older failure-knowledge contract permits

#### Concrete history

1. H is Active. P is head.
2. Groom G submits an otherwise-valid Household-mediated marriage proposal involving bride B and dowry cost `C`.
3. P accepts the mediated proposal through the role-scoped response path and explicitly authorizes private term `X > 0`; valid commitments cover residual `R = C - X`.
4. Independently, H's separate Household initiative selects an eligible `NeedsGrain` support action whose higher material priority consumes enough of P's live disposable grain that P can no longer fund the exact X when the dowry reaches precommit.
5. The mediated marriage attempt therefore fails central revalidation rather than being a voluntary rejection.
6. G is a direct participant in the failed interaction.
7. The authoritative trace is required to preserve the exact funding plan/provenance, including P's private X and the failing funding leg.

#### Frontier sources

- Union U-B — private X, shared grain, live revalidation.
- Union U-G — failure knowledge/privacy.
- Union U-H — mediated marriage/private X.
- Pass-A F-02/F-03/F-05/F-14.
- MA F03/F05/F21.

#### Why this could matter

The history distinguishes two different visibility layers:

- authoritative diagnostic/provenance history must retain exact X and the funding legs;
- direct participants learn `InvalidatedAtResolution(reason)`, but reasons are bounded to what the interaction makes knowable and resolver omniscience may not leak unrelated private state.

The semantic question is what failure reason G acquires when the decisive precommit failure is specifically P's private-owner capacity for X. A detailed reason can reveal a private-resource fact; a coarse reason can hide which agreed funding leg failed.

This is not a question about whether the transaction commits. It is a question about whether the new private-funding dependency retargets the older failed-attempt information boundary.

#### Existing authority that appears relevant

- DEC-0011: exact X, no reservation at deliberation, atomic failure when X loses live feasibility, and exact authoritative funding provenance.
- SPEC §6.7: direct-party failed-attempt knowledge with bounded interaction-relevant reasons and no resolver-omniscience leakage.
- SPEC §9.4: consequential history retains validation/conflict result, effects, causal predecessors and relevant role context.
- `RECOGNITION_INFORMATION_FAMILY.md`: actor-specific information/non-omniscience discipline.
- `RESOLUTION_REACTION_FAMILY.md`: accepted attempts can invalidate centrally without becoming refusal.

#### Challenge classification

**possible causal retargeting/dependency gap**

#### Confidence

**MEDIUM** that this deserves MA reconciliation.

---

### PB-05 — Does a refused provision request's cooldown survive head succession?

#### Concrete history

1. H is Active with head A and non-contributing sustaining participant C.
2. In cycle N, A requests a persistent provision commitment from C.
3. C voluntarily declines.
4. In cycle N+1, H validly succeeds from A to B. C remains a sustaining participant; H identity and the persistent head-role identity continue.
5. Before three full cycles have elapsed since C's refusal, B considers asking C for a provision commitment.
6. Later variant: after three full cycles, B considers the same request with no other relevant context change besides the earlier A→B occupant change.

#### Frontier sources

- Union U-C — provision acquisition/reconsideration, time/context baseline, succession.
- Union U-E — succession carryover.
- Union U-K — preservation of person-level state under office transition.
- Pass-A F-12/F-18.
- MA F13.

#### Why this could matter

SPEC §8.2 says that **after refusal, another request** requires both three full cycles and a relevant context change, and explicitly lists **head occupant** as one such context dimension.

The unresolved carryover question is the identity of the refusal/cooldown state across succession:

- is B's post-succession request another request in the continuing H/C reconsideration history, so the old cooldown continues and head change is merely the context-change limb; or
- is the request keyed to the former requester/occupant A, making B's request a fresh first request?

Those interpretations differ most sharply when succession occurs before the three-cycle cooldown expires.

#### Existing authority that appears relevant

- SPEC §8.2: reconsideration cooldown + relevant context change, including head occupant.
- SPEC §8.4: succession changes occupant while preserving H and the persistent role.
- `PROVISION_GROUNDING_FAMILY.md` VS-SFL-044: cooldown requires both time and a listed context change.
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` VS-SFL-063: succession preserves H/role identity and does not itself rewrite unrelated person-level state.

#### Challenge classification

**possible transition carryover hole**

#### Confidence

**MEDIUM** that this deserves MA reconciliation.

---

### PB-06 — Head is the needy Household-support recipient, with funding supplied entirely by someone else

#### Concrete history

1. H is Active with current sustaining participants P, A, and B.
2. P is current head.
3. P has grain 0 and `NeedsGrain = true`.
4. A has a valid provision commitment with enough exposed capacity to fund one 1-grain support action.
5. P contributes no private X and no commitment-backed grain to this transaction; the funding comes entirely from A.
6. All ordinary recipient eligibility facts for P hold because P is a current needy sustaining participant.
7. The Household support candidate names P as recipient while P is also the role carrier/authorizer.
8. Consider both existing route shapes:
   - P as head proactively proposes the support to recipient P;
   - P as needy participant requests support through the head position also occupied by P.

#### Frontier sources

- Union U-A — dual agency / response topology.
- Union U-D — Household support.
- Union U-E/U-K — role scope and ordinary person-position preservation.
- MA F10 / MA-U01.
- Pass-A F-01/F-02/F-23 broad aliasing surfaces.

#### Why this could matter

Current authority separately establishes that:

- a needy current sustaining participant is in the recipient class;
- the current head is necessarily a current sustaining participant;
- head may proactively propose support or resolve a support request;
- the model has some explicit anti-self topologies (for example groom=head in mediated marriage) but no general stated anti-self-authorization rule.

When beneficiary and institutional authorizer are the same person, the proactive and request/response topologies may no longer be equivalent. The question is whether either shape is semantically valid, and if so what response/authorization history exists when the same `PersonId` occupies both positions.

Using A as the sole funding source isolates the alias question from private supplementation and from P's inability to contribute while `NeedsGrain`.

#### Existing authority that appears relevant

- SPEC §8.3: only 1-grain support to a needy sustaining participant and mediated-marriage dowry are permitted collective material uses; support can be requested by the needy participant or proactively proposed by the head.
- SPEC §8.4–8.5: scoped head authority and separate Household decision context.
- SPEC §6 / response semantics: response meanings are type/scope bounded and responses are distinct from initiative.
- `PROVISION_GROUNDING_FAMILY.md` VS-SFL-041.
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`: role scope and separate contexts.

#### Challenge classification

**possible aliasing ambiguity**

#### Confidence

**HIGH** that this deserves MA reconciliation.

## 4. Coverage check

This challenge set covers all five SID lenses requested by the task:

- **NEW_AFFORDANCE** — PB-01;
- **SUPPRESSED_OR_NARROWED** — PB-02;
- **TRANSITION_CARRYOVER** — PB-05;
- **PARTICIPANT_ALIAS** — PB-06;
- **CAUSAL_RETARGETING / NEW_DEPENDENCY** — PB-03 and PB-04.

The set is deliberately not one challenge per union row. Four of the six histories are driven primarily by reviewer-added/reviewer-expanded Pass-A surfaces rather than MA-U01–U06, and PB-03 specifically composes two accepted narrow resolver precedences rather than reviewing an MA alias in isolation.

## 5. No semantic disposition

This report does **not** resolve any challenge.

Master Architect / Director authority remains responsible for consequential semantic closure.

A challenge can be classified as already-supported, prohibited, irrelevant, deferred, unresolved, or a genuine accidental gap only after authority-bearing reconciliation.
