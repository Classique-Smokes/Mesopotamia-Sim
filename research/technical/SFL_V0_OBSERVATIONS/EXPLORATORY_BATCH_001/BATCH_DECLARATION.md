# SFL v0 Exploratory Observation Batch 001 — Pre-Execution Declaration

**Status:** DECLARED / NOT YET EXECUTED  
**Class:** EXPLORATORY OBSERVATIONAL VARIANTS — NOT ACCEPTANCE / NOT CALIBRATION  
**Master seed:** `20260923`  
**Scenario count:** 8  
**Horizon:** 30 cycles each  
**Execution path:** production `Simulation.RunAutonomousCycle()` only

## Purpose

Broaden the observational dataset around Birth Run 001 while the Project Director performs the first-read.

These runs test sensitivity to different valid starting conditions. They do not establish correctness, historical realism, calibration, or stochastic robustness.

The simulation is deterministic. Randomness is used only to generate the fixed initial conditions below; once committed, every world is immutable and reproducible.

## Generation envelope

Each world was generated under these constraints:

- population: 4–6 people;
- dwellings: 2–3;
- starting grain: 1–8, with at least one low-stock and one high-stock actor;
- connected direct-party social graph through bidirectional attitude edges;
- initial directed attitudes sampled across positive and negative values;
- 0–2 kinship links;
- no initial marriage;
- no initial debt;
- no initial favour;
- no scheduled exogenous grain input;
- no per-cycle scripted voluntary proposals or responses.

The eight concrete world files under `WORLDS/` are the authoritative batch inputs. They must not be tuned after observing outcomes.

## Seeds and declared world hashes

- VAR-0001: seed `741772126`; SHA-256 `33afc82e3e928f64d2ad3d872dcae88160dcd521d5a4b6e14d159c9cfa50d911`
- VAR-0002: seed `529577928`; SHA-256 `f385577b350474af0e7b410fef4a1fe1b3dbc0bfcfbec6f81d6be78f530ffab4`
- VAR-0003: seed `629102900`; SHA-256 `884f165a5eda498d0c0d62ababb48724ab20dbcb280df5a437c4d202dd614325`
- VAR-0004: seed `794998562`; SHA-256 `12fdfe7f1997fe9cbabef03038e2b8c1ddf2f8b5379c2f42dfbaea876e332c79`
- VAR-0005: seed `1687309476`; SHA-256 `514be67310856f89b41c4cd64187118f868326dc297e993a128d2957b1b99a0a`
- VAR-0006: seed `2072757730`; SHA-256 `0642a853fb736e0bf91783f4abed9bf94ec554352a651cc00734ec396cb01201`
- VAR-0007: seed `527901100`; SHA-256 `54882b0b873bebab2e767276787ef570976faf719c2fb198e609cb1474f12b6b`
- VAR-0008: seed `904807500`; SHA-256 `274b394516d0edaba6849df64c17fcc6c35444975d5c7c343901f099355248af`

## Interpretation boundary

Raw outputs must be frozen before any cross-run Master Architect synthesis.

Any later follow-up experiment receives a new batch identity rather than modifying these worlds.
