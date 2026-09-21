# SFL v0 Verification Package

**Status:** ACTIVE / ROADMAP STAGE 3  
**Authority:** Verification design only. Scenario cards test `SPEC-SFL-0001`; they do not redefine it.

## Card levels

- `mechanism-isolation` — fixture may submit valid proposals through the public proposal/resolution boundary; it may not write endogenous results.
- `closed-loop` — actual decision contexts must generate the actions under a pinned deterministic decision profile.
- `boundary`, `metamorphic`, `mutant` — adversarial companions.

## Card requirements

Every canonical card states:

- claim and authoritative clauses;
- initial objective/subjective state;
- allowed fixture writes;
- stimulus/proposal schedule;
- observation horizon;
- required semantic/causal ordering;
- terminal assertions;
- always-on invariants;
- independent oracle basis;
- adversarial companions;
- nonclaims/allowed variation.

Completed-cycle assertions are made only at stable cycle closure. Intermediate commits/reactions may be inspected as causal history.

## Current families

- `FORMATION_FAMILY.md`
- `CONTINUITY_TURNOVER_FAMILY.md`
