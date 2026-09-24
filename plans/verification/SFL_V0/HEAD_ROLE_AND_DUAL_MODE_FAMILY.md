# VS-SFL-06x — Head Role / Vacancy / Succession / Dual-Mode Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§8.4–8.5 and §9.

These cards verify that household authority is a scoped persistent role, not generic sovereignty, and that one person may simultaneously act in personal mode and serve as the cognitive carrier of a separate household decision context.

## Family invariants

- each H has at most one current head-role occupant;
- a newly formed H begins headless;
- only current `SustainingParticipant`s may nominate or be nominated;
- appointment/succession requires nominee consent and unanimous current sustaining-participant acceptance/recognition;
- role scope does not include seizing grain, commanding residence/personal actions, arbitrarily creating relations, or altering attitude;
- vacant or Inactive H has no household-mode initiative;
- head vacancy does not itself destroy H or provision commitments;
- occupied head P retains one personal initiative while H receives one separate household initiative;
- personal and household contexts deliberate from the same committed snapshot and resolve centrally.

---

## VS-SFL-060 — Newly formed household is headless

**Level:** mechanism-isolation

Start from the successful terminal state of `VS-SFL-001`.

### Assertions

- H contains one persistent `HouseholdHeadRole(H)`;
- role is vacant;
- no household-mode initiative is generated while vacant;
- H identity and founding participants exist independently of head occupancy;
- no founder is silently selected by age, sex, ID, grain, kinship, or fixture order.

---

## VS-SFL-061 — Unanimous head appointment

**Level:** mechanism-isolation

### Initial state

Active headless H with current SustainingParticipants A/B/C.

### Sequence

1. A nominates B.
2. B accepts nomination.
3. Every current sustaining participant accepts/recognizes B's appointment.

### Assertions

- B becomes the sole occupant of H's persistent head role;
- H identity does not change;
- A/B/C directly recognize the resulting head-role state through participation in appointment;
- outsiders do not automatically recognize B as head;
- no personal grain, residence, relation, or attitude is altered merely by appointment.

### Unanimity controls

Run paired variants where:

- nominee B declines -> no appointment;
- one current sustaining participant does not accept -> no appointment;
- nominee is not a current SustainingParticipant -> invalid nomination;
- nominator is not a current SustainingParticipant -> invalid nomination.

No stable-ID or majority fallback may install a head.

---

## VS-SFL-062 — Vacancy suspends collective action without destroying H

**Level:** mechanism-isolation

### Initial state

Active H with head B and valid provision commitments.

### Sequence

B ends household participation, triggering role vacancy.

Assume at least two other sustaining participants remain so H stays Active.

### Assertions

At stable closure:

- H remains the same Active household;
- head role is vacant;
- B is no longer SustainingParticipant;
- B's own provision commitment terminates;
- other valid provision commitments remain;
- H has no household-mode initiative while headless;
- stored provision backing does not spend itself;
- ordinary personal actions of remaining people continue.

---

## VS-SFL-063 — Succession preserves household and role identity

**Level:** mechanism-isolation

### Initial state

Active H with head A and sustaining participants A/B/C.

### Sequence

1. A nominates B as successor before vacating.
2. B accepts.
3. all current sustaining participants accept/recognize the succession.
4. succession commits under the same persistent `HouseholdHeadRole(H)`.

### Assertions

- H ID is unchanged;
- head-role ID is unchanged;
- occupant changes A -> B;
- valid succession event/history directly links old and new occupancy;
- participating A/B/C recognize B's new role state;
- outsiders remain dependent on later valid observation/communication;
- no provision commitment is automatically transferred, created, or deleted merely because occupant changes.

### Negative control

If unanimity or nominee consent is missing, B is not installed.

---

## VS-SFL-064 — Head personal and household contexts are separate

**Level:** closed-loop

### Initial state

Active H with head P.

Pinned profiles:

- P personal context uses `SCORE-VP-002` with the declared `GiftTarget`;
- H household context uses `SCORE-VP-003` with the declared `NeedRecipient`.

The fixture may bind semantic targets but may not inject candidates/final scores. Production generation/gates and scorer must produce the proposals.

### Assertions at deliberation

- P receives one personal decision trace;
- H receives one separate `HouseholdDecisionContext(H, head=P)` trace;
- both read the same committed snapshot;
- household score components use household concerns/capabilities, not P's personal-action score;
- P's non-office knowledge remains P's knowledge; the role does not create a separate omniscient mind.

### Nonconflicting companion

Choose compatible personal and household actions.

- both may commit;
- P having a household initiative does not consume P's personal initiative.

---

## VS-SFL-065 — Same-snapshot personal/household conflict resolves centrally

**Level:** closed-loop / conflict

### Initial decision snapshot

Active H with head P.

- P grain = 3;
- P has a valid provision commitment to H, exposing 1 grain;
- needy sustaining participant B qualifies for 1-grain household support;
- outsider C can receive an ordinary 1-grain personal gift from P.

Pinned scoring:

- P personal context uses `SCORE-VP-002`, `GiftTarget = C`;
- H household context uses `SCORE-VP-003`, `NeedRecipient = B`.

Production generation/gates must produce the accepted Gift(P -> C,1) and household support(B,1) proposals from the common snapshot.

Both are individually feasible against the common snapshot, but both cannot consume P's same last exposed grain while preserving the protected reserve.

### Assertions

Central resolution must:

1. revalidate both against the common committed state;
2. apply accepted priority: eligible NeedsGrain household support before ordinary personal transfer;
3. commit the household support;
4. debit P exactly once to grain 2;
5. credit B exactly once;
6. mark P->C gift `InvalidatedAtResolution`, not `Declined`;
7. give direct participants bounded failure knowledge;
8. apply no refusal-attitude penalty to the invalidated gift;
9. grant P no same-cycle retry or extra personal initiative.

This card also serves as one canonical witness for provision-priority and invalidation semantics.

---

## VS-SFL-066 — Head authority is scoped, not general sovereignty

**Level:** candidate-generation / mutant-kill

With valid H/head recognition, attempt to generate household-role candidates that would:

- seize a participant's personal grain outside valid provision spend;
- command a participant to move residence;
- command an ordinary personal gift/loan/favour;
- create kinship/debt/favour by office fiat;
- directly modify attitude.

### Assertions

None are valid household-role actions.

Equivalent person-person proposals may still be available through ordinary personal agency where independently permitted.


---

## VS-SFL-067 — Valid last act before authority destruction

**Level:** closed-loop / same-cycle authority race  
**Semantic source:** SPEC §9.2 + DEC-0010.

### Initial state

Active H with current head A and sufficient valid backing for one in-scope Household action.

From the same committed decision snapshot, construct paired accepted attempts such that:

- one is an otherwise-valid authority-dependent Household action under A; and
- the other would destroy the exact current authority/status required by that action.

Exercise at minimum:

1. A's accepted participation end -> head vacancy;
2. valid A -> B succession;
3. accepted participation/status transition that would make H Inactive/Dissolved;
4. a role/appointment transition whose required current participant/status would otherwise be removed by the paired destructive transition.

### Assertions

For each pair:

1. resolve the authority/status-dependent attempt before the paired authority/status-destroying transition;
2. immediately revalidate every other action-relevant precondition normally;
3. preserve any more-specific accepted semantic/domain priority;
4. if the protected attempt remains otherwise valid, it commits under the still-current authority/status;
5. the destructive transition then resolves normally;
6. a pending old-head action never rebinds to successor B;
7. technical ID, proposal/container order, and generic technical fallback do not determine the authority result;
8. reversing nonsemantic input/proposal enumeration does not change the semantic result.

### Negative controls

- make one independent non-authority precondition fail before commit -> the protected attempt must still fail ordinary revalidation;
- make the attempt authority-invalid already at the committed decision snapshot -> DEC-0010 does not revive it;
- introduce a more-specific accepted semantic priority that blocks the attempt -> DEC-0010 does not override that priority.

### Scope note

This card proves the narrow v0 precedence only. It does not create general resignation, contested succession, multiple claimants, or office sovereignty.

---

## VS-SFL-068 — Private supplement consent inside one Household action

**Level:** closed-loop / dual-capacity holder behavior  
**Semantic source:** SPEC §§8.1.1, 8.4, 8.5 + DEC-0011.

### Initial state

Active H with current head P and a permitted Household material action available.

Use a world where:

- P has sufficient disposable grain for a private supplement;
- standing Household commitment backing alone is insufficient for the selected action;
- P's ordinary personal initiative is independently consumed by a compatible personal action;
- the Household action remains otherwise valid.

### Deliberation assertions

- P has exactly one personal decision trace;
- H has exactly one HouseholdDecisionContext through P;
- the Household action carries one explicit private-supplement term X authorized by P as private owner;
- no second personal initiative is created;
- no self-directed provision proposal/response context is created;
- the trace distinguishes:
  - Household/role authority for the institutional act;
  - P's private-property consent for X.

### Commit assertions

If all live preconditions remain valid:

- the Household action commits with the exact funding plan;
- P's personal initiative count remains one;
- no persistent provision commitment is created by the transaction-specific supplement;
- P's remaining private grain stays private.

### No-consent companion

Keep the same H/action/capacity but remove P's private-supplement authorization.

- office authority alone cannot debit P's uncommitted private grain;
- if standing commitment backing remains insufficient, the Household action cannot commit.

### Compatible personal-action companion

Give P enough grain that both the selected personal action and the supplemented Household action remain feasible after accepted priority/revalidation.

- both may commit;
- the supplement does not consume or cancel the personal initiative merely because P is the same person in both capacities.

## Family semantic mutants that must be detected

- auto-elect lowest/highest stable ID when headless;
- majority vote instead of unanimity;
- nonparticipant may nominate or occupy role;
- head vacancy dissolves H;
- vacant H still gets household initiative;
- household context consumes P's personal initiative;
- personal context sees effects proposed by H in the same cycle before central resolution;
- household score reuses P's personal score;
- head directly mutates participant grain/residence/relations outside scoped actions;
- office occupancy silently exposes the holder's private grain without explicit transaction-specific consent;
- private supplementation consumes a second personal initiative or opens a self-response context;
- one transaction-specific supplement silently creates a persistent provision commitment;
- a successor inherits/reuses the predecessor's private supplement;
- same-cycle authority-destroying transition preempts an otherwise-valid accepted authority-dependent last act contrary to DEC-0010;
- old-head action is rebound to the successor;
- proposal/container/stable-ID order silently decides the authority race;
- same-cycle newcomer retroactively expands an already-accepted appointment/succession unanimity cohort;
- self-nomination is categorically rejected or represented through redundant self-response contexts that erase the explicit semantic predicates;
- an Inactive sole-bearer cannot fill the persistent role, or role occupancy incorrectly grants Household-mode initiative while Inactive.


---

## VS-SFL-069 — Snapshot-bound succession consent cohort

**Level:** same-cycle composition / consent cohort  
**Semantic source:** SPEC §§8.4, 9.2 + DEC-0013 D2.

### Initial decision snapshot

Active H has current sustaining participants A/B/C and current head A.

From the same committed decision snapshot:

- A->B succession has nominee acceptance and unanimous A/B/C participant acceptance;
- D has a valid bridge-dependent participation entry through A;
- A has an accepted participation end.

### Required result

- the succession consent cohort is exactly A/B/C from the common decision snapshot;
- D's later same-cycle accepted entry does not retroactively become a required succession acceptor;
- captured cohort members still revalidate live action-relevant eligibility;
- both the bridge-protected entry and otherwise-valid accepted succession may complete without resolution order manufacturing a new veto;
- D does not acquire head Recognition merely by entering.

### Mutation controls

Must fail if:

- entry-first resolution silently expands the accepted succession cohort to include D;
- a captured A/B/C member becomes ineligible and the implementation ignores live revalidation;
- technical/container order decides whether D has veto power.

---

## VS-SFL-069A — Self-nomination preserves predicates without self-negotiation theatre

**Level:** role alias / nomination = nominee  
**Semantic source:** SPEC §8.4 + DEC-0013 D5.

Use Active headless H with current participants A/B/C.

A self-nominates.

The explicit act must omission-detectably satisfy:

1. A's nomination;
2. A's nominee willingness/acceptance;
3. A's own participant-acceptance predicate.

B and C must still separately accept/recognize the appointment.

No A->A nomination response context is opened.

### Controls

- remove A's nominee willingness -> appointment fails;
- remove A's participant-acceptance predicate -> appointment fails;
- remove B or C acceptance -> appointment fails;
- require redundant technical self-responses despite the explicit multi-capacity act -> fail representation/subordination review;
- prohibit self-nomination solely because nominator==nominee -> fail.

For nomination of B by A, A's nomination still does not substitute for A's separate participant acceptance.

---

## VS-SFL-069B — Inactive Household may fill an inert head role

**Level:** lifecycle / role occupancy distinct from Household initiative  
**Semantic source:** SPEC §§8.4–8.5 + DEC-0013 D6.

### Initial state

Inactive H has exactly one current sustaining participant A and a vacant persistent `HouseholdHeadRole(H)`.

A uses the accepted self-nomination/multi-capacity consent path.

### Required result

- A may become occupant of the existing persistent role;
- H remains Inactive;
- no `HouseholdDecisionContext` or Household-mode initiative is produced while Inactive;
- filling the role does not create provision/spend/mediation authority-in-use;
- later valid reactivation preserves the occupied role identity/occupant;
- no different-person succession is possible while A is the sole current participant.

### Negative controls

Must fail if implementation:

- requires H to become Active merely to fill the persistent role;
- treats role filling as reactivation;
- grants Household-mode initiative to occupied-but-Inactive H;
- allocates a new role identity on reactivation.
