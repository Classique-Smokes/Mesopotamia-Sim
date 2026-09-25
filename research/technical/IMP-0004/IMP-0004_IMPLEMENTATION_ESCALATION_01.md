# IMP-0004 implementation escalation 01

Status: **ESCALATED / implementation incomplete; not a conformance candidate.**

## Decision required

Define the executable origin and lifetime of a **new Household material need** for provision reconsideration, particularly a mediated-marriage dowry need.

SPEC-SFL-0001 §8.2 lists this as a permitted context-change dimension. §8.3 limits material uses to needy-participant support and mediated dowry. VS-SFL-044 repeats the context-change requirement. The implementation surface map §F3 permits a local baseline record shape but requires authoritative provenance and forbids reconstructing the baseline from observer history. Those instructions do not identify which mediated-route event makes a new material need exist or how it ceases to be current.

Concrete distinguishing witness:

1. In cycle N, a target refuses H's provision request.
2. Keep that target's grain/NeedsGrain and attitude toward the head, H's occupant, and all participant support needs unchanged through N+4, compensating maintenance with declared fixture inputs.
3. In N+1, an otherwise eligible groom requests a positive dowry through the recognized current head, but every funding plan is infeasible. The interaction is Unable before response scoring.
4. In N+4, H asks the same target for provision again.

The expected eligibility differs depending on whether the valid but unfunded request itself establishes a new Household material need or whether an additional head decision/adoption is necessary. The latter is not currently a defined action or transition. A declined feasible request poses the corresponding lifetime/adoption question. Repeated identical requests, a subsequently ineligible marriage, and a recurring support need also require a stable notion of newness so a new proposal identity cannot manufacture a context change.

This is an eligibility outcome, not merely a choice of record field names. No new trigger, pending-demand lifecycle, or history-derived authority has been added to resolve it. The implementation currently compares the captured set of needy participants for the support limb; that is provisional and does not implement the dowry limb or distinguish recurring episodes for the same participant. It must not be presented as complete S4-075/S4-076 evidence.

Requested authority closure: identify the qualifying support/dowry need event or predicate, the retained identity/baseline, persistence/termination rules, and the expected result of the distinguishing witness. No frozen manifest change is requested. Task §9 requires escalation rather than choosing an unsupported semantic outcome.

## Preserved implementation

Isolated branch: `implementation/imp-0004-slice4-household-head-collective-action`, based on released commit `683183c1b58f82dccdcc776644759fe1c04fe109`. Canonical main was not modified.

Implemented paths include persistent vacant head roles, explicit appointment/succession predicates and captured cohorts, local head/participation evidence, dual initiative contexts, provision acquisition, exact private funding with one live allocator, support, mediated marriage, authority/material ordering, and detached replay integration. New tests exercise public formation producers, consent ablations, stale and incomparable evidence, funding boundaries, repayment priority, old-head last acts, private-amount non-rebinding, isomorphic renaming, and detached record corruptions.

These are coder-owned implementation and mechanism tests. They do not establish the full 165-row Slice-4 acceptance gate or fresh independent conformance.

## Outstanding delivery gates

- Resolve the material-need context boundary above.
- Complete the Slice-4 manifest runner and substantive per-obligation bindings; retain all 9 DEFERRED and 2 UNEXERCISED rows.
- Complete the requested fixture/producer audits, full structural and phase-carried-authority audits, and remaining counterfactual/corruption scenarios.
- Complete the remaining interaction witnesses, including multi-Household carriers, reactivation, called-favour repayment/due-cycle composition, overflow atomicity, and the full closed context-change matrix.
- Finish the adaptation ledger and critical-seam mutant evidence.
- Produce the complete evidence package, exact-head CI, and proposed immutable conformance-candidate ref only when all candidate gates are established.

No candidate ref is frozen or proposed from this incomplete state. Independent review and promotion remain separate gates.
