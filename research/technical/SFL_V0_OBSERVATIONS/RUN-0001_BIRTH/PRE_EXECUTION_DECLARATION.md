# Birth Run 001 — Pre-Execution Declaration

**Status:** DECLARED / NOT YET EXECUTED  
**Run:** `RUN-0001_BIRTH`  
**Horizon:** 30 cycles  
**Execution path:** production `Simulation.RunAutonomousCycle()` only  
**Initial world:** `INITIAL_WORLD.json`

This declaration fixes the first observational world before execution.

The world contains five people, two dwellings, asymmetric directed attitudes, one sibling relation, and no initial debt, favour, marriage, or scheduled exogenous grain input.

No per-cycle voluntary proposal, response, candidate winner, score, or hidden state mutation will be supplied.

The runner stops at the first of cycle 30 stable boundary, `MaterialDeadlock`, or simulation fault.

The initial world and horizon must not be tuned after observing the resulting history. Any later variant receives a distinct run identity.
