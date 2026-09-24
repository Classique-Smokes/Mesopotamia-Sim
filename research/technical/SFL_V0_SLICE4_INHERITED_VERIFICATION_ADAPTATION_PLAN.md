# SFL v0 Slice 4 — Inherited Verification Adaptation Plan Candidate 1

**Status:** CANDIDATE / INDEPENDENT REVIEW REQUIRED  
**Plan version:** `SFL-V0-S4-INHERITED-ADAPTATION-v1-candidate1`  
**Owner:** Master Architect  
**Authority:** verification-enforcement adaptation only; no simulation-semantic authority  
**Frozen Slice-4 authority:** `SFL-V0-S4-ACCEPTANCE-v1` / `sfl-v0-slice4-acceptance-v1`  
**Freeze commit:** `c77131c1dda965521b6b756ec0e91c60e0800673`  
**Frozen manifest blob:** `7edff7a0507d68037979b3b5e458864f1f8d6518`  
**Trigger rows:** S4-170 through S4-175  
**Production coding:** NOT AUTHORIZED until this adaptation plan receives independent PASS

## 1. Purpose

Slice 4 adds accepted later-slice role, dual-mode, endogenous provision, and Household-material behavior. Some existing Slice-3 executable witnesses prove their narrower semantic claim using implementation-era literals that cannot remain literally true once the later accepted feature exists.

This plan authorizes only a **lossless change of verification form**.

It does not:

- edit or reclassify frozen Slice-1/2/3 manifest rows;
- weaken the semantic invariant those rows prove;
- require a particular production representation beyond existing accepted authority;
- authorize Slice-4 production behavior by itself;
- permit camouflage by renaming types/events/fields;
- create new social semantics.

## 2. Controlling authority

Primary:

- frozen `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST.md`;
- S4-170..S4-175;
- frozen Slice-3 S3-014 and S3-093;
- inherited Slice-1 S1-084;
- accepted SPEC/ADRs/DEC-0010.

Independent pre-code review of Slice-4 candidate2 already inspected the current executable witness forms and concluded these adaptations are lossless enforcement changes, not semantic amendments.

Current source surfaces confirmed at the freeze boundary:

- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdStructuralScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs`
- related Slice-3 acceptance runner/oracle surfaces where the same assumptions are consumed.

## 3. Adaptation A — S3-014 headless boundary

### Frozen semantic invariant

S3-014:

> Newly formed H has no occupied head and exposes no household-mode initiative or head-mediated effect merely because H exists.

The frozen claim is **not** permanent absence of head-role types from the codebase.

### Current literal witness

The canonical Slice-3 formation scenario currently obtains additional enforcement by scanning the simulation assembly and asserting no type name contains:

- `HeadRole`;
- `HouseholdDecisionContext`.

That was a valid implementation-era witness while Slice 3 deliberately excluded those concepts.

Slice 4 necessarily introduces them.

### Authorized adaptation

Replace the assembly-wide type-absence assertion with a scenario/state/history assertion that proves the unchanged semantic boundary.

The adapted Slice-3 witness must establish, on the canonical formation history:

1. H forms with the same accepted Slice-3 FormationWarrant / participant / Recognition chain.
2. No occupied head exists **as a result of formation alone**.
3. If the accepted Slice-4 representation creates the one persistent role together with H, that role is vacant at formation closure.
4. No `HouseholdDecisionContext` is generated merely by formation / H existence.
5. No head-scoped material, mediated-marriage, provision-solicitation, succession, or other head-mediated effect occurs absent the later accepted appointment/authority path.
6. Formation does not auto-elect a founder/current participant by ID, order, wealth, kinship, sex, or other implicit fallback.
7. Ordinary Slice-3 Household identity/participation semantics remain unchanged.

### Forbidden weakening

Do not replace the old assertion with only “a role object exists.”

Do not count vacancy as proof unless occupancy and Household-initiative surfaces are independently inspected.

Do not rewrite frozen S3-014 wording/status.

## 4. Adaptation B — S3-093 / S1-084 structural authority non-hiding

### Frozen semantic invariant

The inherited invariant is:

> no hidden behavior-affecting derived authority.

Slice 3 used exact private-field inventory checks as one implementation-local way to establish that the then-current authoritative state shape had no hidden cache/authority channel.

The frozen invariant does not mean legitimate later authoritative fields can never be added.

### Current literal witness

`HouseholdStructuralScenarios.cs` currently asserts exact private-field sets for:

- `WorldState`;
- `HouseholdState`.

The current HouseholdState expected inventory is the Slice-3 authoritative partition only.

### Trigger

This adaptation is required **only if** Slice-4 implementation changes one of those exact inventories or the inherited structural-audit path.

If implementation chooses a separate explicit authoritative role partition and preserves the exact existing inventories, the old inventory assertion need not be changed merely because Slice 4 exists.

### Authorized adaptation when triggered

The replacement structural witness must preserve stronger, representation-neutral evidence:

1. Every new behavior-affecting Slice-4 role/occupancy/provision-reconsideration authority state is explicit, typed, inspectable authoritative state.
2. No behavior-affecting current-head, role-eligibility, capacity, Recognition, candidate, or availability cache is allowed to become an untracked source of authority.
3. Any derived/cache/index representation used for performance is independently rebuildable/discardable at a safe stable boundary and cannot change behavior when stale.
4. Current authoritative role identity and occupancy must not be inferred solely from diagnostic history, container order, a derived participant snapshot, or current Person attributes.
5. Reflection/structural audit must enumerate the new authoritative surface rather than allow arbitrary undeclared fields.
6. If exact field allowlists remain the chosen enforcement method, update them only to the explicitly accepted authoritative fields introduced by Slice 4; do not add broad wildcard exemptions.
7. If a different structural enforcement method replaces exact inventory matching, it must be at least as strong at detecting hidden behavior-affecting state and must receive separate independent review before replacement.

### Required negative challenge

The adapted evidence must be capable of detecting at least one intentionally introduced hidden behavior-affecting cache/field or equivalent mutation, rather than merely documenting the new state layout.

### Forbidden weakening

- deleting S1-084/S3-093 coverage;
- broad “all new fields allowed” reflection logic;
- moving authority to opaque static/global/diagnostic state to dodge the inventory;
- using implementation comments as proof.

## 5. Adaptation C — Slice-3 no-Household-material-event oracle assumption

### Frozen semantic invariant

Slice 3 provision establishes backing/capacity only:

- no Household treasury;
- no Household-originated support/dowry/spending authority;
- no contributor debit execution.

That remains frozen Slice-3 truth.

Slice 4 legitimately adds accepted Household material effects.

### Current literal witness

`HouseholdOracle.Verify` currently performs a global history assertion:

- any event whose kind begins `Household` or `Sustaining` has an empty `Material` vector.

That global literal becomes false once accepted Slice-4 support/dowry events exist.

### Authorized adaptation

Scope the old prohibition to the semantic boundary it was intended to prove.

The adapted verification must establish both:

#### Historical Slice-3 boundary

For Slice-3 rule contexts / Slice-3 completion scenarios:

1. Household/participation/continuity/lineage events still produce no material effect.
2. controlled pre-existing provision commitments still move no grain merely by existing;
3. mobilizable capacity remains derived only;
4. no Slice-4 material event is generated.

#### Slice-4 allowance

For Slice-4 scenarios, Household-originated material changes are permitted **only** when:

1. the event is one of the accepted Slice-4 material-use meanings;
2. a valid occupied/scoped authority path exists;
3. exact contributor debits/recipient credit are independently accounted;
4. no treasury/hidden pool appears;
5. fixed-rank/live-capacity/atomicity rules hold;
6. the event carries truthful S4 rule/configuration provenance.

The adaptation may use rule-version/context/event-family distinctions, scenario-level oracle composition, or another explicit semantic boundary. It may not depend on cosmetic event renaming.

### Forbidden weakening

Do not simply remove the Household-material assertion globally.

Do not exempt all `Household*` events from material accounting.

## 6. Adaptation D — provision commitment provenance

### Frozen semantic invariant

Slice 3 permits only a declared controlled pre-existing valid `HouseholdProvisionCommitment` fixture when testing backing/capacity rather than acquisition.

Slice 4 adds an endogenous head-scoped request/response path that may produce commitments.

The new path must not retroactively change the meaning of Slice-3 fixture commitments.

### Current literal witness

`HouseholdOracle` currently requires every observed HouseholdProvisionCommitment to have nonempty `Provenance.Fixture`.

That is correct for the Slice-3 completion boundary but would reject legitimate Slice-4 endogenous commitments.

### Authorized adaptation

Commitment provenance becomes a **closed provenance-kind union**, not “anything goes.”

Independent verification must distinguish:

#### Slice-3 controlled prerequisite

A commitment used under frozen Slice-3 fixture authority must:

- retain explicit fixture provenance;
- match the declared controlled write;
- have no endogenous request/response chain falsely claimed;
- remain unsuitable as evidence of acquisition.

#### Slice-4 endogenous acquisition

An endogenous commitment must:

1. reference the actual provision-request proposal;
2. bind the current valid H/head/scoped authority at proposal and commit;
3. bind the actual target/current participant;
4. bind the target's accepted role/personal response as specified;
5. be causally downstream of that acceptance;
6. carry exact rule/configuration/time provenance;
7. have no fixture provenance substituted for the endogenous chain;
8. move no grain merely on commitment creation.

Fixture-origin and endogenous-origin commitments must both remain auditable and mutually distinguishable.

### Required corruption controls

The future checker must reject at least:

- endogenous commitment with fabricated fixture provenance and no valid request/acceptance;
- fixture commitment relabeled endogenous with nonexistent proposal/response;
- endogenous commitment bound to wrong H/head/participant;
- acceptance from wrong actor;
- commitment created before acceptance;
- commitment whose creation itself moves grain.

### Forbidden weakening

Do not change the oracle to accept commitments with “fixture OR anything non-null.”

Do not infer acquisition merely because a commitment exists.

## 7. Adaptation E — frozen-manifest integrity

No frozen prior manifest changes are authorized.

Specifically:

- `SFL-V0-S1-ACCEPTANCE-v1` remains immutable;
- `SFL-V0-S2-ACCEPTANCE-v1` remains immutable;
- `SFL-V0-S3-ACCEPTANCE-v1` remains immutable;
- S3-014/S3-093 statuses and wording remain historical frozen authority;
- later executable tests may change only under this lossless adaptation mapping.

Completion evidence must distinguish:

- frozen historical acceptance authority;
- current adapted executable witness;
- mapping between them.

## 8. Implementation sequencing

If this plan receives independent PASS:

1. the Slice-4 implementation task may cite this plan as pre-authorized verification adaptation authority;
2. the bārû may modify affected test/oracle surfaces **only together with** the production change that fires the relevant trigger;
3. each actual adaptation must be identified in the implementation report;
4. exact diffs must show the change is within this plan;
5. any newly discovered inherited literal witness outside this plan is a STOP / escalation before modifying it;
6. post-implementation conformance must explicitly audit that frozen prior semantics remain represented by the adapted evidence.

No need exists to pre-edit currently green tests before the corresponding Slice-4 production surface exists.

## 9. Independent review requirements

A fresh reviewer must verify:

- each current literal witness identified above actually exists at the frozen implementation base;
- the proposed replacement preserves the frozen semantic claim rather than merely deleting a failing assertion;
- adaptation A does not allow formation-time implicit appointment;
- adaptation B remains strong enough to detect hidden behavior-affecting authority;
- adaptation C preserves historical Slice-3 no-spending semantics while admitting only accepted S4 material effects;
- adaptation D retains strict provenance for both fixture and endogenous commitment paths;
- no frozen manifest is edited/reclassified;
- no representation requirement unsupported by accepted semantics is introduced;
- no production code change is required merely to satisfy the plan itself.

Verdicts:

- **PASS — ADAPTATION PLAN APPROVED**
- **BLOCK — LOSSLESSNESS / ENFORCEMENT DEFECT**
- **BLOCK — SEMANTIC ESCALATION**

## 10. Scope closure

This plan closes only the known S4-170..175 inherited-verification adaptation gate.

It does not:

- prove Slice-4 implementation;
- authorize new semantics;
- waive future newly-triggered inherited evidence issues;
- change historical Slice-3 completion.

After independent PASS, the Master Architect may issue the bounded Slice-4 implementation packet.
