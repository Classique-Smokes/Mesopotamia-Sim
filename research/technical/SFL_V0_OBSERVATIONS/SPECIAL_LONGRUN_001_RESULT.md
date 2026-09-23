# Special Long Run 001 — Experimental Result

**Status:** COMPLETE / EXPERIMENTAL / NOT CANONICAL SEMANTICS  
**Branch:** `experiment/consumption-every-other-cycle-longrun`  
**Execution revision:** `5585ba34c7bdb24b2c704f436de7fcd03a661717`  
**Workflow run:** `35808736089` — SUCCESS  
**Artifact:** `10728279395`  
**Artifact digest:** `sha256:ca44fd276e90bdab015fcece1b2eb4c9f3f471c7fc7d4af4e2427983ccdab89d`

## Experimental rule

Canonical Slice-1 consumes one grain/person every cycle.

This isolated experiment consumes on odd-numbered cycles only:

- consumption: cycles 1, 3, 5, ...;
- no routine consumption: cycles 2, 4, 6, ...;
- Farm remains +4;
- all other inherited production behavior unchanged.

The experiment branch must not be promoted into canonical `main`.

## Mechanical execution

- declared horizon: 1,000 cycles;
- completed stable cycles: 1,000;
- stop reason: `Horizon:1000`;
- simulation faulted: false;
- material deadlock did not stop the run.

## Long-horizon structure

The full world never reaches an exact repeated state because one resource stock diverges.

However, an exact recurrence test over the stable-cycle summaries found:

- from **cycle 215 onward**;
- every bounded state component except Enna's grain stock repeats with exact **period 40**;
- personal decision meanings, fallback flags, outcome kinds/reasons and per-cycle event-kind counts also repeat with period 40;
- Enna's grain is the sole unbounded state dimension in that comparison;
- Enna gains exactly **+140 grain per 40-cycle period**, i.e. +3.5 grain/cycle on average.

This is therefore best described as an **affine limit cycle** rather than a fixed equilibrium: a 40-cycle behavioral orbit with secular grain accumulation.

## One 40-cycle steady-regime block (cycles 215–254)

Personal action counts:

- Samu: 35 OfferGift / 5 Farm;
- Rima: 25 RequestGiftOrHelp / 15 OfferGift;
- Hani: 35 OfferGift / 5 Farm;
- Kima: 35 OfferGift / 5 Farm;
- Enna: 40 Farm;
- Pala: 35 OfferGift / 5 Farm.

NeedsGrain during that period:

- Rima: 10 cycles;
- all others: 0 cycles.

Technical fallback during that period:

- Enna: 40/40 personal choices;
- Rima: 25/40 personal choices;
- all other actors: 0.

## Persistent relation structure

Across all 1,000 cycles:

- debts created: 0;
- favours created: 0;
- marriages created: 0;
- residence changes: 0.

The active interaction vocabulary in this world remained Farm, OfferGift and RequestGiftOrHelp/Help.

## Resource trajectory

Selected stable boundaries:

| Cycle | Total grain | Enna grain |
|---:|---:|---:|
| 1 | 26 | 5 |
| 10 | 59 | 37 |
| 50 | 188 | 177 |
| 100 | 367 | 352 |
| 200 | 709 | 702 |
| 215 | 761 | 754 |
| 255 | 901 | 894 |
| 500 | 1767 | 1752 |
| 750 | 2638 | 2627 |
| 1000 | 3509 | 3502 |

At cycle 1000 the other five actors held 2, 0, 2, 1 and 2 grain respectively.

## Causal note

Enna selected Farm in all 1,000 cycles.

After her initial grain rose above the default Farm concern threshold, Farm no longer had a positive policy score; instead, Farm tied with neutral-score alternatives and the stable candidate key selected it. The trace reports `TechnicalFallback=true` on 999 of Enna's 1,000 personal decisions.

Thus the unbounded grain accumulation is attributable to the deterministic reference-policy fallback interacting with the reduced consumption cadence, not to a new substrate rule.

## Interpretation limits

This run is useful evidence about parameter sensitivity and long-horizon reference-policy behavior only.

It is not evidence that every-other-cycle consumption is a better model, and it does not modify accepted Slice-1 semantics.
