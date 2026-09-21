# VS-SFL-03x — Recognition / Subjective Information Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §6 and mediated-marriage requirements.

These cards verify that objective world state, actor knowledge, social recognition, and action availability remain distinct.

## Family invariants

- engine-side Household/head state never becomes global actor knowledge automatically;
- `KnownFact` and `Recognition` remain distinct;
- recognition is not attitude, approval, or obedience;
- household-specific candidate generation requires the specified subjective route;
- ordinary person-person actions remain independent of household recognition;
- evidence ordering follows underlying event/observation order, not message arrival;
- communication never invents a claim the sender does not hold;
- communication normally consumes one personal voluntary initiative;
- stale information persists until displaced/contested by valid evidence.

---

## VS-SFL-030 — Recognition causality under identical objective state

**Level:** closed-loop candidate-generation  
**Claim:** two otherwise equivalent actors facing the same objective H may receive different household-specific candidate sets solely because their subjective recognition differs.

### Initial objective state

- Active household H exists.
- Female bride B is a current `SustainingParticipant` of H.
- P is current recognized-scope head of H.
- Two male outsiders G1 and G2 are otherwise equivalent for marriage eligibility.
- Mutual-strong-like bypass is unavailable for both.
- Neither outsider is kin to B.
- Provision capacity exists so objective household mediation is feasible.

### Subjective state

Both G1 and G2 know the objective person-level fact identifying B.

Both receive the same specific factual evidence that B is a current `SustainingParticipant` of H.

Only G1:

- recognizes H;
- recognizes P as current head in the relevant mediation scope.

G2 does not.

### Pinned decision profile

Activate the marriage concern and hold all non-recognition scoring inputs equal. The profile must make the mediated-marriage candidate worth generating/evaluating if its subjective gates are satisfied.

### Assertions

- G1's generated candidate set contains the household-mediated marriage route through H/P;
- G2's does not;
- G2 does not gain the route merely because H objectively exists;
- both retain ordinary person-person actions;
- neither receives the direct strong-like bypass.

### Gate-isolation companions

Run paired variants where only one subjective prerequisite is removed from G1:

1. bride->H participation fact missing;
2. H recognition missing;
3. head/scope recognition missing.

Each removal suppresses only the mediated route and does not rewrite objective state.

---

## VS-SFL-031 — Stale head recognition survives unwitnessed succession

**Level:** mechanism-isolation + closed-loop candidate inspection  
**Claim:** objective succession does not passively synchronize an outsider's subjective recognition.

### Initial state

- Active H.
- A is current head.
- outsider X recognizes H and A's head role from valid older evidence.

### Schedule

1. H validly succeeds from A to B.
2. X is neither participant nor valid witness and receives no communication.
3. Advance through stable cycle closure.
4. Inspect X's subjective state and candidate routes.

### Assertions before new evidence

- objective head is B;
- X still holds stale recognition based on A;
- X does not magically recognize B;
- H's engine state did not globally synchronize X.

### Correction step

A participant/witness later communicates the B-succession proposition with provenance to the actual newer succession event.

### Assertions after correction

- X may update to the B head-role proposition under ordinary evidence rules;
- household-specific authority routing uses B, not A;
- the correction is traceable to the communicated underlying event.

---

## VS-SFL-032 — Late old message cannot overwrite newer evidence

**Level:** provenance-order metamorphic  
**Claim:** message-arrival time is not evidence time.

### Sequence

1. underlying event E1 establishes A as head.
2. later underlying event E2 establishes B as head.
3. X receives an event-backed report of E2.
4. only afterward, X receives a delayed report of E1.

### Assertions

- X does not revert to A merely because the E1 message arrived later;
- E2 remains newer by underlying semantic event order;
- reversing the network/message arrival schedule while preserving E1<E2 produces the same final recognition state.

### Direct-observation companion

If X directly participates/observes a still newer E3 succession, that newer direct evidence supersedes older incompatible information.

---

## VS-SFL-033 — Incomparable recognition evidence becomes Contested

**Level:** mechanism-isolation  
**Claim:** incompatible evidence with no provenance/order dominance does not silently select one recognition proposition.

### Fixture

Use two truthful senders who hold incompatible recognition interpretations of the same underlying continuity/authority transition.

- both messages reference evidence at the same underlying semantic transition such that neither evidence set is newer/stronger under the accepted ordering rule;
- each sender transmits only the recognition proposition they actually hold;
- recipient X initially holds neither proposition.

### Assertions

- X receives both provenance chains;
- X's relevant recognition state becomes `Contested`;
- authority-dependent candidate generation that requires safely recognized authority is unavailable while contested;
- no stable-ID, sender-ID, or arrival-order fallback selects a winner.

### Nonclaim

This card proves representability of unresolved subjective disagreement. It does not assert a historical frequency for such disputes.

---

## VS-SFL-034 — Communication consumes the sender's personal initiative

**Level:** boundary / process  
**Claim:** ordinary communication is a voluntary personal action, not a free broadcast channel.

### Sequence

- sender S has one personal initiative available;
- S chooses `CommunicateClaim/Inform`;
- communication commits successfully;
- another ordinary voluntary personal action is otherwise feasible in the same cycle.

### Assertions

- S does not initiate the second ordinary personal action that cycle;
- responses to incoming proposals remain governed by the separate response rule and are not confused with personal initiative consumption;
- household initiative, if S separately occupies a head role, remains a different decision context under the accepted role-mode rule.

---

## VS-SFL-035 — Recognition is independent of attitude and compliance

**Level:** mechanism-isolation  
**Claim:** dislike/refusal does not erase correctly evidenced recognition.

### Initial state

Actor X recognizes H and P's current head role from valid evidence.

### Perturbations

- change X's attitude toward P into a negative band through ordinary accepted attitude mechanics;
- allow X to decline an ordinary request from P where refusal is permitted.

### Assertions

- X's recognition of H/P does not disappear solely because attitude is negative;
- recognition does not imply approval or obedience;
- any later recognition change requires evidence about formation/continuity/dissolution/succession/contradiction or communicated claims, not attitude decay alone.

---

## Family semantic mutants that must be detected

- engine broadcasts H/head recognition to all actors;
- co-residence automatically gives household recognition;
- objective succession rewrites every actor's head belief;
- later-arriving older report overwrites newer evidence;
- household-mediated marriage ignores one of bride-route/H/head subjective gates;
- communication is free and does not consume initiative;
- negative attitude automatically deletes recognition;
- Contested evidence is resolved by stable actor/message ID.
