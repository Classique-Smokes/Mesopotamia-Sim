# SFL v0 Slice 2 Discovery B — Implementation Surface Map

**Status:** READY FOR PARALLEL LOW-AUTHORITY DELEGATION  
**Work class:** Read-only code/architecture inventory  
**Implementation authority:** none  
**Semantic/design authority:** none  
**Owner of synthesis:** Master Architect

## Question

What supporting machinery from Slice 1 already exists for Slice 2, and what implementation surfaces are absent or must be extended?

## Retrieve

1. `AGENTS.md`
2. `00_START_HERE.md`
3. `plans/CURRENT_PHASE.md`
4. `tasks/research/SFL_V0_SLICE2_PREIMPLEMENTATION_DISCOVERY.md`
5. accepted spec/ADRs only enough to avoid misclassifying an implementation seam
6. current production source under `src/Mesopotamia.Sim/`
7. Slice-1 implementation completion/reconciliation records as provenance

Do **not** use the new conceptual tablet collections as requirements or systematize them.

## Inspect at minimum

- authoritative state types and snapshot boundaries;
- `PersonalDecisionInputs`;
- subjective-input tracing already present;
- `PersonalAgency` and response agency;
- semantic and decision history representations;
- event/provenance identifiers;
- execution cycle order;
- actor-visible completed-state boundary;
- configuration/version plumbing;
- deterministic ordering;
- any existing communication/recognition/knowledge types or placeholders;
- checkpoint-related seams only if they are already present and directly constrain Slice 2.

## Produce

Map each likely Slice-2 implementation need into:

- **already present/reusable**;
- **present but needs bounded extension**;
- **absent implementation surface**;
- **cannot classify without semantic decision**.

For every item, cite concrete files/types/methods.

Identify engineering risks such as accidental global knowledge, hidden objective-state reads, provenance loss, same-cycle visibility leaks, or unstable ordering.

Do not design the missing semantics and do not write code.

## Return

Create branch:

`research/slice2-implementation-surface-return`

from current `origin/main` at execution start.

Add only:

`research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md`

Record the exact base SHA used.

No other repository mutation.
