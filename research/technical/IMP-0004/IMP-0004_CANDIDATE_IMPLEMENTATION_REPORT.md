# IMP-0004 candidate implementation report

Status: **COMPLETE CANDIDATE**, subject to the exact-head engineering evidence delivered alongside this record. This is the coding return, not VERIFIED COMPLETE or PASS — PROMOTE. The Master Architect owns candidate freeze and commissioning a fresh independent conformance review.

## Authority and closure

The implementation branch is `implementation/imp-0004-slice4-household-head-collective-action`, created from released canonical commit `683183c1b58f82dccdcc776644759fe1c04fe109`. Recovery commits `5616aac` and `1de66c3` remain preserved. Closure ref `imp-0004-escalation-01-closure-v2` at `6704d25b800bcb4f16d974a867a7fa8c1332ace9` was merged at `4470169`. DEC-0014 closes the historical-material-need ambiguity; no further semantic choice was introduced. Semantic/frozen authority files were not rewritten by the implementation.

Frozen Slice-4 v2 manifest blob: `b0bc79e46f82630ab78cd2f0d0414b748212a411`. Approved inherited-adaptation commit/blob: `68fddec788b5cf41db5934c8719a6fd1ce474d32` / `00c3e64a128fa00e91b99117e321a0e379dd61c5`. The acceptance runner verifies these blobs and reruns the entire inherited chain. Delivered evidence binds the final implementation SHA, branch, tree status, exact frozen refs and remote CI. Keeping that binding outside this committed file avoids a self-referential commit hash.

## Implementation and local engineering choices

- The existing explicit HouseholdState partition owns persistent vacant-at-formation roles, transitions and per-H/target refusal baselines. Typed records distinguish H, role, occupant, captured association, consent capacity, head Recognition, standing commitment and exact private authorization. Copying and immutable publication retain them; queries recompute rather than maintain authority caches.
- Head nomination captures the common-snapshot cohort and explicit multi-capacity predicates. Live validation retains association identities and predecessor occupancy. Vacancy is local and cause-bound. Head/participation facts extend the accepted direct and communication evidence routes with exact acquisition receipts; no participant-wide head broadcast is added.
- Personal and Household initiatives retain separate slots on the same decision boundary. Explicit Household policies use named integer components and person-held cognition. Reference personal motivation is unchanged. Invalid scope and malformed numeric terms fail before response/social effects.
- Accepted internal envelopes freeze consent and exact X. One bounded funding evaluator declares possible participants and calculates private/residual legs, effective capacities and fixed rank. Commit stages world/Household/epistemic effects, aggregates deltas by person, and consumes that result without independently reallocating. Material recipient/contributor aliasing and checked-arithmetic failure are covered.
- Role responses compare feasible no-private, configured-X, shortfall and full-private plans before declaring Unable. The default no-private preference is policy, not a new funding-source priority. Optional private wealth never compels acceptance.
- Central ordering preserves bridge precedence, exact accepted authority-use/destruction constraints and bounded shared-grain material priority, including repayment/called repayment. Unrelated eligibility and capacity revalidate; detached replay uses the same envelopes/evaluator and causal identity normalization.
- DEC-0014 adds a historical qualifying need occurrence inside the latest refusal record. Support eligibility edges and legitimate dowry requests retain causal provenance even after need clears or funding fails. Later refusals reset the baseline; technical retries do not create semantic need. No generic demand lifecycle is introduced.

The main production additions are `HouseholdHeadState`, `HouseholdHeadExecution`, `HouseholdAgency`, `HouseholdFunding`, `HouseholdCollectiveRules`, `HouseholdCollectiveExecution`, `HouseholdPriorities`, and `ProvisionReconsideration`, integrated into existing execution, epistemic, dependency and projection paths. Public API and synthetic-v0 boundaries are documented in `src/Mesopotamia.Sim/README.md`.

## Evidence and checks

`Slice4AcceptanceTests` emits **165/165 REQUIRED** individually, plus **9 DEFERRED / 2 UNEXERCISED** individually, and the inherited **128 S1 + 46 S2 + 96 S3 = 270 REQUIRED** individually. Case bindings, full obligations, fixture writes, producer histories, exact event/evidence identities and final records accompany results. A green historical S1 conformance row preserves its historical meaning and does not assert this candidate's independent conformance.

`Slice4Oracle` independently reconstructs roles/consents, evidence receipts, grain/capacity/rank/debits and mediated effects from initial records and public causal evidence. Its source dependency audit prohibits the production classifiers under test. Actual detached corruptions reach this checker. Metamorphic cases cover reversed enumeration, isomorphic PersonId renaming, disconnected actors/Households, repeated observers, detached identical-state rebuild and duplicate closure. Explicit scenarios cover consent ablations, stale/Contested/current role information, inert Inactive appointment/reactivation, simultaneous personal/Household/response contexts, support/dowry/private-X boundaries, aliasing, overflow atomicity, repayment/favour races and authority loss.

The four approved inherited adaptations and original triggers are detailed in `IMP-0004_ADAPTATION_LEDGER.md`; exact historical witness diffs accompany the package. The structural mutation supplies a hidden behavior-affecting eligibility field and changes actual outsider-appointment behavior; both semantic and structural checks reject it. DEC-0014 mutants 53–56 separately force current-only need, funding-dependent need, old-need reuse across refusal and illegitimate retry-based need. Each mutant compiles, executes the real kernel, and fails an assertion; mutation evidence is not a compiler-error substitute.

Canonical engineering verification uses SDK **10.0.401** and the prescribed restore → format verification → Release build → test sequence. The existing CI uses exact PR head and uploads all acceptance artifacts. Final command logs and CI/artifact identity are delivered separately with the SHA binding.

## Scope and handoff

The synthetic personal-grain/reserve/fixed-rank/commitment/private-X mechanisms are bounded laboratory scaffolding, not generic or historical economics. The arbitrary cooldown remains the accepted crude anti-repeated-solicitation proxy. No checkpoint, treasury, general ledger, richer personal planning, general perception, rival claimant resolution, resignation or generalized institutional power was added. No new unresolved semantic issue or additional inherited-witness adaptation was found after DEC-0014.

Proposed immutable ref: `imp-0004-slice4-conformance-candidate-v1`, pointing to the exact final SHA in the delivered evidence. The coding agent does not create or move that freeze ref, merge the candidate, or self-promote. Only the separate fresh review's **PASS — PROMOTE** permits promotion.
