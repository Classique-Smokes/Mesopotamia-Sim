# VS-SFL-07x — Resolution / Failure Knowledge / Priority / Reaction Closure Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§3.1, 6.7, 9.1–9.4.  
**Supporting review:** `TRES-0003`.

These cards verify that shared-snapshot proposals remain attempts until central resolution, failure meanings stay socially distinct, and automatic semantic consequences terminate deterministically.

## Family invariants

- every proposal is revalidated against all action-relevant preconditions immediately before commit;
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

- exactly one +10 attitude transition is committed;
- the same cause key cannot produce a second identical transition;
- repeated production is reported as an engine/specification error or rejected as already processed according to implementation diagnostics;
- semantic history contains one causal attitude transition, not two.

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

## Family semantic mutants that must be detected

- map every failed request to "rejected";
- leak exact authoritative target state in failure reasons;
- apply refusal attitude penalty to Unable/Invalidated;
- retry failed actor in the same cycle;
- let debt/favour reserve grain without explicit material commitment semantics;
- resolve scarce capacity by container iteration order;
- fire one automatic cause twice;
- publish/checkpoint completed cycle state before reaction closure.
