# Special Long Run 001 — Every-Other-Cycle Consumption

**Status:** DECLARED / EXPERIMENTAL / NOT CANONICAL SEMANTICS  
**Branch:** `experiment/consumption-every-other-cycle-longrun`  
**Seed:** `2026092301`  
**Horizon:** 1,000 cycles  
**Initial-world SHA-256:** `f9fd023dadb9d02a732f5a0d2a940431b1774f6859df81802096297574201f6f`

## Parameter deviation

Canonical Slice-1 semantics consume one grain per person **every cycle**.

This experiment changes only routine consumption cadence:

- consumption occurs on cycles 1, 3, 5, ...;
- cycles 2, 4, 6, ... have no routine consumption;
- Farm remains +4 grain;
- all other production semantics are inherited from the verified Slice-1 kernel.

The future-material-recovery diagnostic is aligned to the same alternate-cycle maintenance cadence for internal consistency.

This branch is an experimental fork and must not be promoted into canonical `main`.

## World

One seeded pseudo-random world is fixed before execution:

- 6 people;
- 3 dwellings;
- connected asymmetric attitude graph;
- 2 kinship links;
- starting grain between 2 and 7;
- no initial marriage;
- no initial debt;
- no initial favour;
- no exogenous grain inputs.

No per-cycle proposal or response is scripted.

## Purpose

Observe whether a much longer deterministic run under lower routine consumption pressure exhibits recurrence, stabilization, saturation, deadlock, or continuing drift.

This is a parameter-sensitivity experiment, not evidence of historical realism, calibration, or implementation conformance.
