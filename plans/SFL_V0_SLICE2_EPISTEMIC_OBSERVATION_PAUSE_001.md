# SFL v0 Slice 2 — Epistemic Observational Pause 001

**Status:** OPERATIONAL OBSERVATION PLAN / NOT SIMULATION AUTHORITY  
**Trigger:** IMP-0002 VERIFIED COMPLETE + canonical promotion + post-promotion CI PASS  
**Canonical starting revision:** `616c17864f5615ddccb7fb2e893dd14116fc1c79`  
**Purpose:** Observe the verified Slice-2 epistemic substrate before beginning detailed Slice-3 planning.

## 1. Boundary

This pause is:

- observational, not acceptance;
- raw-first;
- non-calibrating;
- non-historical;
- not permission to reopen Slice 2 because behavior is surprising.

No accepted SPEC/ADR/manifest semantics are changed.

The run must use public production APIs only.

## 2. Why two worlds

Slice 2 deliberately does **not** include socially meaningful autonomous communication motivation.

Therefore one fully autonomous world alone would mostly show direct acquisition and the absence of communication. That absence is itself useful evidence, but it would not exercise the new mediated epistemic machinery.

This pause uses two fixed worlds:

### World A — AUTONOMOUS-BASELINE

Purpose:

- observe knowledge divergence under ordinary autonomous lower-level behavior;
- see whether CandidateRecognition emerges without explicit communication;
- confirm that co-residence/support do not silently create shared knowledge.

No communication policy pulses. No scripted proposals.

Horizon: **12 cycles**.

### World B — RELAY-STALE-CONTEST

Purpose:

- observe mediated recognition;
- observe stale recognition after objective change;
- observe correction by newer event-backed communication;
- observe Contested recognition from incomparable stale evidence;
- observe Recognition gating suppressing a later communication candidate.

Horizon: **12 cycles**.

Most behavior remains autonomous default policy. Only the fixed pulse schedule below differs.

## 3. Shared objective world

Six people:

| Id | Name | Sex | Initial grain | Residence |
|---:|---|---|---:|---|
| 1 | Aru | Male | 18 | D1 |
| 2 | Bela | Female | 18 | D1 |
| 3 | Dagan | Male | 8 | D3 |
| 4 | Iltani | Female | 8 | D2 |
| 5 | Samu | Male | 8 | D2 |
| 6 | Enna | Female | 8 | D3 |

Dwellings: D1, D2, D3.

Aru and Bela:

- are siblings;
- have directed attitudes +80 each way;
- are the fixed core of inert `CandidateRecognition(C1)`.

No Household or formation result exists.

This world is intentionally not a historical reconstruction.

## 4. World A fixed rules

- no initial epistemic fixture reports;
- candidate C1 is live;
- every cycle calls ordinary autonomous policy for every actor;
- stop at cycle 12, material deadlock, or fault.

Pre-run expectation is **not** a pass/fail assertion:

Aru/Bela can accumulate support history through autonomous interaction while still lacking mediated knowledge of each other's Residence, so Recognition may remain Unknown. The raw run decides what actually occurs.

## 5. World B fixed epistemic prestate

World B uses the same objective world plus one truthful initial actor-held report:

Samu holds:

- `Residence(Bela,D1)`;
- fixture provenance label `predeclared-stale-report`;
- no underlying event/order.

The report is objectively true at cycle 0.

No other subjective facts are fixture-seeded.

## 6. World B fixed pulse schedule

This schedule is frozen **before execution**.

All unspecified actors on every cycle receive ordinary default autonomous policy.

### Cycle 1

Aru uses `SFL-COMMUNICATION-LAB-v1` to communicate his currently held own Residence fact to Bela.

### Cycle 2

Bela uses `SFL-COMMUNICATION-LAB-v1` to communicate her currently held own Residence fact to Aru.

### Cycle 3

Fully autonomous.

### Cycle 4

If Aru currently holds Recognized C1, his fixed laboratory communication policy targets Dagan with `HeldRecognition(C1)`.

The runner does not manufacture Recognition; it only submits the predeclared communication intent. If the production gate says the proposition is not held, that is recorded.

### Cycle 5

Fully autonomous.

### Cycle 6

One predeclared public lower-level event:

- Bela submits `MoveResidence(Iltani,D2)`.

Iltani's ordinary response profile is used.

Bela therefore has no separate autonomous personal initiative that cycle. All other actors remain autonomous.

Purpose: create a real objective Residence change through the production action pipeline, not by state mutation.

### Cycle 7

Fully autonomous.

Purpose: preserve at least one stable boundary in which uninformed actors may remain stale.

### Cycle 8

Bela uses `SFL-COMMUNICATION-LAB-v1` to communicate her currently held current own Residence fact to Dagan.

### Cycle 9

Samu uses `SFL-COMMUNICATION-LAB-v1` to communicate the original fixture-held `Residence(Bela,D1)` report to Dagan.

This report may now be stale. The production system determines the resulting Recognition state.

### Cycle 10

Dagan uses `SFL-COMMUNICATION-LAB-v1` with intent to communicate `HeldRecognition(C1)` to Enna.

The runner does not force candidate eligibility or a proposal. The production subjective gate determines whether communication is available.

### Cycle 11

Bela communicates her currently held current own Residence fact to Aru.

### Cycle 12

Fully autonomous.

## 7. Runner rules

The runner may:

- construct the two declared InitialWorld values;
- inspect public `EpistemicStateOf` only to resolve the evidence ID for a predeclared semantic communication pulse;
- supply the fixed PersonalPolicy/Proposal schedule above;
- call public `RunAutonomousCycle` / `RunCycle`;
- inspect public Snapshot, EpistemicSnapshot, History, DecisionHistory, KnowledgeOf;
- mechanically render raw outputs.

The runner may not:

- write subjective postconditions;
- invoke internal recognition/evidence helpers;
- alter scores/gates/results;
- adapt the schedule after seeing outcomes;
- create Household/head/checkpoint/trust/reputation machinery.

## 8. Raw package

CI uploads:

`artifacts/observation/SFL_V0_SLICE2_PAUSE_001/`

For each world:

- `INITIAL_WORLD.json`
- `CYCLES.json`
- `SEMANTIC_HISTORY.json`
- `DECISION_HISTORY.json`
- `FINAL_SNAPSHOT.json`
- `FINAL_EPISTEMIC.json`
- `HUMAN_TRANSCRIPT.md`

Root:

- `README.md`
- `RUN_METADATA.json`

No Director or Master Architect interpretation belongs in the raw package.

## 9. First-read questions

After raw output is frozen, inspect:

- which actors know different things about the same objective state;
- whether support/co-residence without communication leaves Recognition Unknown;
- whether mediated recognition appears legibly;
- how stale Recognition behaves after Bela moves;
- whether Dagan's state becomes Unknown or Contested when reports arrive;
- whether Contested/Unknown Recognition changes the cycle-10 communication candidate;
- whether provenance remains human-readable;
- whether technical fallback appears and why;
- whether any behavior looks like implementation defect versus accepted limitation.

## 10. Interpretation limits

Do not infer:

- historical realism;
- final cognition;
- trust/reputation;
- rumor dynamics;
- autonomous gossip motivation;
- household emergence;
- office/authority;
- population robustness.

## 11. Classification after Director first read

Classify material observations as:

- implementation defect;
- verification blind spot;
- accepted-model issue;
- temporary parameter/reference-policy issue;
- missing later-slice capability;
- conceptual research signal;
- interesting non-actionable emergence;
- insufficient evidence.

Only implementation defect / verification blind spot normally justify immediate engineering work.
