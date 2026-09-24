# VS-SFL-07x — Resolution / Failure Knowledge / Priority / Reaction Closure Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§3.1, 6.7, 9.1–9.4.  
**Supporting review:** `TRES-0003`.

These cards verify that shared-snapshot proposals remain attempts until central resolution, failure meanings stay socially distinct, and automatic semantic consequences terminate deterministically.

## Family invariants

- categorically invalid proposal terms are rejected before the social failed-attempt taxonomy applies;
- every semantically valid proposal is revalidated against all action-relevant preconditions immediately before commit;
- `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)` remain distinct;
- feasibility failure is not social refusal;
- direct participants learn the outcome plus only a bounded interaction-relevant reason;
- no failed proposal grants same-cycle re-deliberation or an extra initiative;
- only explicit capacity-authorizing commitments receive scarce-material priority;
- debt/favour do not silently reserve grain;
- `ReactionIndex` is monotone within a cycle;
- one cause key cannot apply the same automatic transition twice;
- automatic reactions consume/change their enabling state or become no-ops;
- no completed cycle/checkpoint exists before reaction closure.

---

## VS-SFL-070 — Declined versus Unable

**Level:** mechanism-isolation / causal contrast

### Shared setup

Requester A has genuine unmet grain need and submits the same ordinary request for 1 grain to B.

### Run D — voluntary decline

At resolution:

- B is materially able to provide the requested transfer while respecting applicable reserve rules;
- B voluntarily declines.

Assertions:

- outcome = `Declined`;
- A and B know the decline;
- ordinary genuine-need refusal rule applies A -> B attitude -5;
- no grain moves.

### Run U — inability

Hold A/request meaning fixed, but make B unable to provide the requested grain.

Assertions:

- outcome = `Unable(reason)`;
- A/B learn a bounded reason such as `InsufficientAvailableGrainFor(1)`;
- the reason need not reveal B's exact grain balance or unrelated obligations;
- no refusal attitude penalty fires;
- no grain moves.

The two histories must remain distinguishable.

---

## VS-SFL-071 — Accepted proposal invalidated at central resolution

**Level:** conflict / causal contrast

### Initial snapshot

Construct two accepted proposals that are each individually feasible against the common decision snapshot but cannot both commit because they depend on the same scarce personal capacity.

Use a controlled one-contributor setup to avoid the open multi-contributor allocation erratum.

### Assertions

For the losing proposal:

- outcome = `InvalidatedAtResolution(reason)`;
- it is not rewritten as `Declined` or `Unable`;
- direct participants learn a bounded conflict/capacity reason;
- requested world effect does not become objective fact;
- no refusal-based attitude penalty fires;
- proposer/target receive no same-cycle retry or extra initiative.

The winning proposal's state change is fully recorded and becomes authoritative before the loser is finally revalidated.

---

## VS-SFL-072 — Provision priority: support > dowry > personal transfer

**Level:** conflict / priority

### Common decision snapshot

Active H with head/contributor P and valid provision commitment.

- P grain = 4 -> exposed household capacity 2;
- needy sustaining participant N qualifies for 1-grain household support;
- a valid mediated-marriage proposal requires dowry 2;
- P's personal context has an accepted ordinary 1-grain gift to outsider X.

All three attempts are generated/accepted from the same snapshot.

### Resolution

Apply priority:

1. NeedsGrain household support;
2. other valid household provision expenditure (dowry);
3. ordinary personal transfer.

### Required result

1. support commits first:
   - P 4 -> 3;
   - N receives 1;
2. dowry is revalidated:
   - only 1 grain remains exposable above reserve;
   - dowry 2 becomes `InvalidatedAtResolution(ProvisionCapacityNoLongerAvailable)`;
3. personal gift is revalidated:
   - P may still transfer 1 while ending at reserve 2;
   - gift commits if all other preconditions remain valid.

### Assertions

- priority is semantic, not collection order;
- invalidated dowry does not create marriage or groom->head favour;
- support debit occurs exactly once;
- personal gift is not blocked merely because an invalid higher-priority attempt existed;
- no proposal is retried/replanned in the same cycle.

### Mutation controls

Must fail if:

- dowry commits before eligible support;
- personal gift commits first and destroys support capacity;
- debt/favour is treated as an automatic grain reservation.

---

## VS-SFL-073 — Bounded failure reason does not leak private state

**Level:** information safety

Create an `Unable` or `InvalidatedAtResolution` outcome whose authoritative cause depends on private material state plus unrelated private facts.

### Assertions

The direct counterparty may learn only the interaction-relevant proposition required to explain failure, e.g.:

- `InsufficientAvailableGrainFor(amount)`;
- `NoLongerEligibleForMarriage`;
- `HeadRoleNoLongerValid`;
- `ProvisionCapacityNoLongerAvailable`.

They do **not** automatically learn:

- exact private grain balance where not interaction-required;
- unrelated debt/favour;
- unrelated household recognition;
- hidden third-party state.

Production resolver access is not actor omniscience.

---

## VS-SFL-074 — One automatic cause applies once

**Level:** reaction-idempotence / mutant-kill

### Trigger

Commit one event with an automatic semantic consequence, e.g. an accepted voluntary gift that should produce recipient -> giver attitude +10.

### Fault challenge

Cause the reaction queue/dispatcher to encounter the same semantic cause key twice:

`(AttitudeFromAcceptedGift, GiftEventId, RecipientId)`.

### Assertions

- exactly one +10 contribution from that cause key reaches the authoritative attitude transition;
- the same cause key cannot contribute a second identical delta;
- repeated production is reported as an engine/specification error or rejected as already processed according to implementation diagnostics;
- semantic history shows the accepted cause exactly once.

### Mixed direct-cause companion

Start one directed attitude at +95 after due maintenance/decay. In one cycle produce two distinct valid direct §3.1 attitude causes targeting it: +10 and -20.

Assertions:

- both distinct cause keys contribute once;
- one authoritative direct-attitude composition transition applies `clamp(+95 + 10 - 20) = +85`;
- the batch retains both cause keys/deltas as predecessors;
- changing nonsemantic queue/enumeration order does not change the result;
- no contribution-by-contribution clamping creates +80 merely from cause order.

---

## VS-SFL-075 — Multi-reaction closure reaches stable boundary

**Level:** closure / progress

Use a history whose commit legitimately causes several automatic consequences, for example:

1. lower-level qualifying support commit;
2. actor knowledge update;
3. CandidateRecognition becomes satisfied;
4. FormationWarrant/H creation;
5. founding SustainingParticipant associations;
6. founders directly recognize H.

### Assertions

- every automatic transition has a distinct valid cause key;
- `ReactionIndex` increases monotonically for causally ordered same-cycle transitions;
- no voluntary personal/household deliberation reopens during closure;
- closure terminates because rules consume/change their enabling conditions or become no-ops;
- stable cycle state is published only after the chain closes;
- checkpoint request before closure is rejected/not safe;
- checkpoint at stable boundary is permitted.

### Fault challenges

The suite must detect:

- a reaction that re-enables itself forever;
- repeated same-cause production;
- arbitrary microstep-count truncation reported as successful closure;
- same-cycle voluntary reactivation after an automatic consequence.

---

## VS-SFL-076 — Communication provenance regression link

**Level:** cross-family reference

The following accepted provenance properties are already canonically exercised in `RECOGNITION_INFORMATION_FAMILY.md`:

- `VS-SFL-032`: underlying event order beats later message arrival;
- `VS-SFL-033`: unresolved incomparable contradictions become `Contested`;
- `VS-SFL-034`: communication consumes sender personal initiative.

This card requires those tests to remain part of the Stage-3 resolution/information acceptance set; do not duplicate their oracle using production recognition code.


---

## VS-SFL-077 — Authority-use precedence before authority destruction

**Level:** cross-family resolution precedence  
**Semantic source:** SPEC §9.2 + DEC-0010.  
**Primary detailed witness:** `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md#VS-SFL-067`.

### Claim

When an otherwise-valid accepted action/role transition and an accepted same-cycle transition arise from the same committed snapshot, and the latter would destroy the exact head/Household authority or institutional status the former still requires, the authority/status-dependent attempt resolves first.

### Assertions

- the protected attempt still undergoes immediate precommit revalidation for all other preconditions;
- more-specific semantic/domain priorities remain controlling;
- after the protected attempt resolves, the authority/status-destroying transition resolves normally;
- no pending action is rebound to a successor;
- an invalid-at-snapshot action is not revived;
- technical IDs, proposal order, collection order, and generic fallback do not select the precedence;
- nonsemantic enumeration permutations preserve the same semantic history modulo technical identities.

### Regression boundary

This precedence is distinct from:

- Slice-3 continuity bridge-handoff priority;
- provision support > other Household provision > ordinary personal transfer;
- Residence conflict;
- generic equal-priority technical fallback.

---

## VS-SFL-078 — Exact funding plan revalidation without silent rebalance

**Level:** cross-family material resolution  
**Semantic source:** SPEC §§8.1.1, 9.2 + DEC-0011.

### Claim

A transaction-specific private contribution X is an exact accepted funding-plan term. It does not reserve grain at deliberation and is not silently renegotiated at commit.

### Positive case

At the common committed snapshot:

- Household action total cost C = 3;
- current head P explicitly authorizes X = 1;
- residual commitment requirement R = 2;
- live private/commitment capacities can satisfy the exact split.

The action may commit atomically with that exact plan.

### Private-capacity-loss challenge

After deliberation/acceptance but before this action commits, let a higher-priority accepted effect legitimately reduce P's live disposable capacity below X.

Assertions:

- the Household action fails ordinary revalidation;
- no private debit partially persists;
- no commitment-backed debit partially persists;
- X is not silently reduced;
- R is not silently increased/reallocated;
- there is no same-cycle retry/renegotiation.

### Commitment-capacity-loss challenge

Keep P's private X valid but reduce current valid commitment capacity below R before commit.

Assertions:

- the whole action fails atomically;
- X is not increased to cover the new shortfall even if P could afford more;
- no partial material/social effect commits.

### Capacity-gain companion

If commitment capacity increases after the funding plan was selected:

- P still contributes exactly X if the action commits;
- the engine does not silently reduce X merely because commitments could now cover more.

### Central-priority companion

Pair a supplemented Household action with P's separate ordinary personal transfer from the same snapshot.

- apply the existing Household provision priority class;
- revalidate live grain after higher-priority commits;
- supplementation is part of the Household effect, not a separate personal transfer.

## Family semantic mutants that must be detected

- map every failed request to "rejected";
- leak exact authoritative target state in failure reasons;
- apply refusal attitude penalty to Unable/Invalidated;
- retry failed actor in the same cycle;
- let debt/favour reserve grain without explicit material commitment semantics;
- resolve scarce capacity by container iteration order;
- resolve same-person Residence conflicts by container/proposal iteration order or allow multiple Residence commits;
- fire one automatic cause twice;
- clamp independent direct attitude causes one-by-one so queue order changes bounded result;
- publish/checkpoint completed cycle state before reaction closure;
- resolve an authority-destroying transition before the valid accepted authority-dependent last act protected by DEC-0010;
- rebind an old-head action to a successor;
- use technical ID/order as an authority-precedence rule;
- silently shrink/increase private supplement X at commit;
- automatically rebalance C-X when one funding leg loses feasibility;
- reserve private supplement grain during deliberation so central revalidation cannot see competing effects.


---

## VS-SFL-079 — Household provision outranks RepayDebt in bounded v0 conflict

**Level:** conflict / v0 material priority  
**Semantic source:** SPEC §9.2 + DEC-0013 D1.

### Common decision snapshot

Use one debtor/head-or-contributor P whose same live personal grain can support:

- an otherwise-valid accepted `RepayDebt` attempt; and
- an otherwise-valid accepted Household material expenditure.

Choose quantities so both are individually feasible from the common committed snapshot but cannot both commit after preserving the applicable reserve/live-capacity rules.

Exercise at minimum:

1. eligible NeedsGrain Household support versus `RepayDebt`;
2. other valid Household provision expenditure versus `RepayDebt`.

### Required result

- valid Household provision resolves in its accepted class before `RepayDebt`;
- `RepayDebt` then revalidates against the changed live grain state;
- if no longer feasible, repayment becomes the ordinary non-refusal resolution failure;
- the debt claim remains and the existing due-cycle one-time social consequence still applies later if balance remains;
- no debt reservation preempts Household provision merely because repayment was accepted earlier in deliberation.

### Boundary assertions

This witness establishes only the current v0 same-cycle conflict policy.

It must not encode or report the result as:

- a historical priority of Household claims over debt;
- a moral/legal hierarchy of obligations;
- a generic future-economy debt rule.

### Mutation controls

Must fail if:

- `RepayDebt` commits first and destroys otherwise-valid higher Household provision capacity;
- debt acceptance automatically reserves grain;
- repayment invalidation erases the debt claim or suppresses the ordinary due-cycle consequence.
