# SFL v0 Slice 4 — SID Pass-A / Master Architect Frontier Comparison

**Status:** PASS-B FRONTIER RECONCILIATION / NO SEMANTIC CLOSURE YET  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Semantic base:** `main@b8c80f2e7734543a4758809f872fd4cb6f1a6a4e`  
**Frozen reviewer Pass A:** `sfl-v0-slice4-sid-passa-v1` @ `6a15d40c2c8b9f54bba9c5f5e77a5806a9cee94e`, blob `f42d3f1baec9d103462a95077038dd4032c09ae1`  
**Frozen MA frontier:** `sfl-v0-slice4-sid-ma-frontier-v1` @ `cd8c3ccf497bd8df928d5dee5f888188d98dd4ef`, blob `029cd7a0d7d019ebbb1ccd75faddaa2760b199a4`  
**Purpose:** reconcile the independently produced reviewer frontier with the previously sealed Master Architect frontier, producing the justified union for Pass B. This document does not resolve semantics.

## 1. Independence result

The Pass-A return:

- began from exact dispatch commit `179e955e5398f954b56e73f93954a595f75d4653`;
- added exactly one file;
- disclosed no contamination;
- explicitly did not inspect either MA frontier branch/path;
- was frozen before MA reveal.

The two-pass independence requirement is therefore satisfied.

## 2. Frontier comparison judgment

The two maps strongly overlap on the major Slice-4 seams, but the reviewer independently added several materially useful surfaces that were not explicit in the MA map.

No reviewer-only surface is rejected as immaterial merely because the MA omitted it.

The justified Pass-B frontier is therefore the **union**, with exact checkpoint/restore behavior kept at the accepted Slice-5 boundary rather than silently promoted into Slice 4.

## 3. Reviewer-only / reviewer-expanded surfaces retained

| Reviewer surface | Disposition for Pass-B frontier | Reason |
|---|---|---|
| F-07 — Household/private funding vs `RepayDebt` | **RETAIN — reviewer-only expansion** | Debt repayment uses the same personal grain stock and has distinct feasibility/reserve semantics; same-cycle revalidation can expose a real shared-capacity interaction. |
| F-08 — mediated marriage favour creation vs favour-slot/cardinality/lifecycle | **RETAIN — reviewer-expanded** | MA had general lower-level favour interaction, but reviewer correctly isolates the exact ordered-pair favour-slot gate created/consumed by the mediated route. |
| F-09 — Household/role actions vs called-favour response-closed payload boundary | **RETAIN — reviewer-only** | New executable role/Household action shapes create a new temptation at an older categorical payload boundary. |
| F-11 — mediated marriage feeding residence/co-residence incentives | **RETAIN — reviewer-only** | New marriage route can causally feed an existing personal residence proposal path without changing residence/participation automatically. |
| F-12 — provision reconsideration vs attitude/time/context baselines | **RETAIN — reviewer-expanded** | MA covered provision response autonomy but did not separately foreground the older timed/context eligibility mechanism. |
| F-14 — role-scoped failure vs bounded direct-party failure knowledge/privacy | **RETAIN — reviewer-only** | New failure causes must compose with older failure-information boundaries without leaking unrelated private state. |
| F-16 — DEC-0010 authority-use precedence vs Slice-3 bridge-handoff precedence | **RETAIN — reviewer-expanded** | Both are narrow semantic precedences in the same resolver; a history can plausibly contain both structures. |
| F-21 — succession/vacancy/lifecycle effects vs reaction closure/stable publication | **RETAIN — reviewer-only** | New role/lifecycle transitions create intermediate microstates whose causal use must remain distinct from stable-cycle publication. |
| F-22 — new future-influencing role/funding state vs checkpoint/restore seam | **RETAIN AS FUTURE-SEAM FRONTIER** | Exact checkpoint/restore implementation is Slice 5, but Slice 4 must not introduce non-authoritative or unreconstructable future-influencing state that would make later continuation impossible. Current Slice-4 obligation is seam preservation, not implementing Slice-5 restore. |

## 4. MA-only / MA-more-specific surfaces retained

| MA surface | Disposition for Pass-B frontier | Reason |
|---|---|---|
| F08 / U02 — current head as target of new persistent provision commitment/reconsideration | **RETAIN** | Pass A covered broad multi-position aliasing but did not isolate this reusable-backing self-target case. |
| F10 / U01 — head as Household-support recipient | **RETAIN** | Pass A broad aliasing does not answer whether authorizer=beneficiary is legal in this institutional action. |
| F11–F12 / U03–U05 — nomination / nominee / unanimity / self-nomination aliasing | **RETAIN** | Mandatory role-position overlap can change response cardinality and self-response topology. |
| U06 — appointment/succession while H is Inactive | **RETAIN** | Reviewer covered lifecycle action availability generally but did not isolate whether role transitions themselves require Active status. |
| F18 — new participant enters after role appointment and lacks direct head-transition evidence | **RETAIN** | Reviewer covered head Recognition/staleness generally; this is a specific transition carryover/knowledge entitlement shape. |
| F25 — role/Household state vs hidden-derived-authority discipline | **RETAIN** | Reviewer covered persistence/continuity but not the exact risk that new authoritative role state hides in caches/derived indexes. |
| F26 — Inactive reactivation with persistent role state | **RETAIN** | Reviewer covered lifecycle gating generally; this isolates carryover of role occupancy/Recognition across suspension/reactivation. |

## 5. Major overlap clusters

These surfaces are materially shared across both maps and remain in Pass B:

1. **Dual personal / Household agency and response accounting**
   - MA F01–F02/F07
   - reviewer F-01/F-02/F-23

2. **Central revalidation, authority races, failure taxonomy and fallback**
   - MA F06/F24
   - reviewer F-03/F-04/F-14/F-16

3. **Private X / standing commitments / material conflicts**
   - MA F03–F06/F21
   - reviewer F-05/F-06/F-07

4. **Mediated marriage / favour / direct marriage route**
   - MA F19–F21/F23
   - reviewer F-08/F-10/F-11/F-23

5. **Head Recognition / information routing**
   - MA F17–F18
   - reviewer F-13/F-14/F-18

6. **Participation / succession / vacancy / lifecycle / continuity**
   - MA F13–F16/F24/F26
   - reviewer F-15–F18/F-21

7. **Formation / continuity / lineage evidence boundaries**
   - MA F22/F28
   - reviewer F-19/F-20

8. **Person-level state preservation under office**
   - MA F27
   - reviewer F-01/F-06/F-07/F-11/F-23

## 6. Justified Pass-B frontier union

Pass B should challenge the following union, not the original MA frontier alone:

### U-A — dual agency / cognition / initiative
- one person as ordinary actor + Household cognitive carrier;
- role-scoped response vs personal initiative;
- response meaning/funding-plan variants without nested self-response.

### U-B — material resource and claim competition
- private X + standing provision backing;
- Household spend + ordinary Gift/Help/Loan;
- Household/private funding + debt repayment;
- reserve / NeedsGrain / atomic revalidation;
- same actor through multiple funding provenance channels.

### U-C — provision acquisition/reconsideration
- target response autonomy;
- attitude/time/context-change baseline;
- requester=head and target=head possibility;
- succession changing reconsideration context.

### U-D — Household support
- institutional support vs personal support/NeedsGrain;
- head as support recipient;
- Household support as non-organizational evidence;
- failure knowledge/provenance.

### U-E — appointment / nomination / succession
- nominator/nominee/unanimity position overlap;
- self-nomination;
- nominee acceptance vs participant unanimity acceptance;
- nominator nomination vs participant acceptance;
- succession carryover of role identity, commitments, private property and Recognition;
- appointment/succession while Inactive.

### U-F — lifecycle / participation / continuity
- head participation end;
- Active↔Inactive;
- Inactive reactivation;
- dissolution;
- role/commitment state across complete participant turnover;
- DEC-0010 ordering vs Slice-3 continuity bridge-handoff;
- reaction closure/stable publication.

### U-G — subjective information / Recognition / failure privacy
- objective head occupancy vs actor-specific Recognition;
- newcomer entering after role transition;
- stale/Contested head evidence;
- role-scoped failure knowledge without private-state leakage.

### U-H — mediated marriage / favour / residence
- direct marriage bypass preserved;
- bride=head permitted;
- groom=head prohibited;
- favour-slot/cardinality;
- mediated marriage causing later residence incentive without automatic residence/participation mutation;
- private X funding on mediated route.

### U-I — formation / lineage / institutional-feedback nonauthority
- Household-originated support/spend cannot self-confirm formation/continuity/lineage;
- lineage cannot transfer role/resources/commitments/pending effects;
- private funding provenance cannot masquerade as old person-person organizational support evidence.

### U-J — structural authority / persistence seams
- explicit typed role authority vs derived/cache state;
- future-influencing new state must remain authoritative/provenance-bearing;
- checkpoint/restore exact behavior remains Slice 5, but Slice-4 state must preserve that seam.

### U-K — ordinary person-level capability preservation
- office status must not erase or commandeer residence, debt, favour, attitude, marriage, ordinary transfers or personal initiative except through explicit accepted interaction rules.

## 7. MA provisional unresolved questions revealed for Pass B

The sealed MA audit identified six provisional questions. They are now revealed because Pass A is frozen.

- **MA-U01:** head = Household support recipient.
- **MA-U02:** head = target of new/reconsidered persistent provision commitment.
- **MA-U03:** whether nominee acceptance also satisfies the nominee's unanimity-participant acceptance.
- **MA-U04:** whether nomination itself satisfies the nominator's unanimity-participant acceptance.
- **MA-U05:** whether self-nomination is permitted.
- **MA-U06:** whether appointment/succession can occur while H is Inactive.

These are **not decisions** and should not anchor Pass B as the only questions worth asking.

Pass B should seek ordinary concrete histories across the full union and is explicitly encouraged to surface reviewer-originated issues not represented by MA-U01–U06.

## 8. Frontier exclusions

The following remain outside the current union because accepted authority places them outside the current SFL v0/Slice-4 scope:

- divorce/widowhood/remarriage/plural marriage/reproduction;
- general treasury/reimbursement/prestige/coercive office claims;
- general contested succession/multiple claimants;
- markets/land/wages/prices;
- health/death/class/profession/personality;
- exact checkpoint/restore implementation and omission mutants (Slice 5).

Exclusion does not erase future seams already accepted for preservation.

## 9. Pass-B objective

The same fresh reviewer should now generate normally **3–7 ordinary concrete histories/questions** over the justified union.

The reviewer should not merely comment on MA-U01–U06.

The challenge should attempt meaningful coverage across:

- newly possible;
- lost/narrowed;
- transition carryover;
- participant aliasing;
- causal retargeting/new dependency.

The output remains advisory. Semantic disposition belongs to the Master Architect + accepted authority process.
