# SFL v0 Slice 4 — Inherited Verification Adaptation Plan Candidate 2

**Status:** CANDIDATE / FRESH INDEPENDENT REVIEW REQUIRED  
**Plan version:** `SFL-V0-S4-INHERITED-ADAPTATION-v2-candidate2`  
**Owner:** Master Architect  
**Authority:** verification-enforcement adaptation only; no simulation-semantic authority  
**Frozen Slice-4 successor authority:** `SFL-V0-S4-ACCEPTANCE-v2` / `sfl-v0-slice4-acceptance-v2`  
**Frozen manifest:** `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md`  
**Freeze commit:** `66fe54c385f42eeb01308f19b63fff7c670b9bbe`  
**Frozen manifest blob:** `b0bc79e46f82630ab78cd2f0d0414b748212a411`  
**Freeze record:** `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_V2_FREEZE_RECORD.md`  
**Trigger rows:** S4-170 through S4-175  
**Reassessment:** `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REASSESSMENT.md`  
**Historical candidate:** `sfl-v0-slice4-inherited-verification-adaptation-v1-candidate1` @ `51981cb0ad993fe4529341f2862f50d90d72ec26`  
**Candidate1 ref:** `sfl-v0-slice4-inherited-verification-adaptation-v2-candidate1` @ `4f12c30b0f16531fd1e82ac08c2b71e53934ba28`  
**Candidate1 review:** `research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_REVIEW_V2.md` — **BLOCK — LOSSLESSNESS / ENFORCEMENT DEFECT**  
**Candidate1 defect:** the mandatory Adaptation-B negative challenge could be satisfied by an unrelated hidden-field mutant instead of proving detection on the new current-head/funding/dependency authority seam  
**Production coding:** NOT AUTHORIZED until this candidate receives **PASS — ADAPTATION PLAN APPROVED**

## 1. Purpose

Slice 4 adds accepted later-slice:

- persistent head-role state and occupancy;
- dual personal/Household decision mode;
- endogenous provision acquisition/reconsideration;
- Household support and mediated-marriage material effects;
- DEC-0011 exact transaction-specific current-head private contribution `X`;
- DEC-0013 self-commitment, self-nomination, snapshot-bound succession cohort, head-as-recipient and Inactive-role-fill behavior;
- explicit v0 resource-seam/provenance guardrails.

Some frozen Slice-1/3 executable witnesses prove narrower historical semantics using implementation-era literals that cannot remain literally true once these accepted later features exist.

This plan authorizes only a **lossless change of verification form**.

It does not:

- edit or reclassify any frozen Slice-1/2/3 manifest row;
- edit frozen Slice-4 v1 or v2 acceptance authority;
- weaken the semantic invariant an inherited row proves;
- create new social/resource semantics;
- authorize a particular production representation beyond accepted authority;
- authorize generic asset/property/ledger architecture;
- permit camouflage by renaming types/events/fields;
- authorize Slice-4 coding by itself.

## 2. Controlling authority

Primary:

- frozen `SFL-V0-S4-ACCEPTANCE-v2`;
- S4-170..S4-175;
- successor constraints S4-182..S4-190 where they bound adaptation safety;
- frozen Slice-3 S3-014 and S3-093;
- inherited Slice-1 S1-084;
- accepted SPEC-SFL-0001;
- DEC-0010, DEC-0011 and DEC-0013;
- canonical verification cards, especially:
  - `PROVISION_GROUNDING_FAMILY.md` / VS-SFL-047..051;
  - `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`;
  - `RESOLUTION_REACTION_FAMILY.md`;
  - `CROSS_CUTTING_VERIFICATION_CONTRACT.md`.

Frozen prior manifests remain historical authority; later executable adaptation maps those claims into a later implementation boundary without rewriting history.

## 3. Reassessment result / current literal witnesses

The current canonical Slice-3 implementation/test base still contains exactly the four known literal-witness breakpoints.

### 3.1 S3-014 headless-boundary literal

`HouseholdScenarios.cs` scans the simulation assembly and asserts no type name contains `HeadRole` or `HouseholdDecisionContext`.

### 3.2 S3-093 / S1-084 exact structural inventory

`HouseholdStructuralScenarios.cs` reflects nonpublic `WorldState` and `HouseholdState` fields and compares the Household-state inventory against an exact Slice-3 allowlist.

### 3.3 Slice-3 global no-Household-material-event literal

`HouseholdOracle.Verify` asserts that every event whose kind begins `Household` or `Sustaining` has an empty material vector.

### 3.4 Slice-3 fixture-only commitment provenance literal

The same oracle requires every observed `HouseholdProvisionCommitment` to have nonempty fixture provenance.

Current production likewise stores `ProvisionFixtureProvenance` on the Slice-3 commitment record.

### 3.5 Scope conclusion

No fifth pre-existing inherited literal witness is established by DEC-0011 or DEC-0013.

Any newly discovered inherited literal witness outside this plan is a **STOP / escalation** under S4-174 before modification.

## 4. Adaptation A — S3-014 headless boundary

### Frozen semantic invariant

S3-014 means:

> Newly formed H has no occupied head and exposes no Household-mode initiative or head-mediated effect merely because H exists.

The frozen claim is not permanent absence of head-role types from the codebase.

### Authorized adaptation

Replace assembly-wide type absence with scenario/state/history evidence proving the unchanged boundary.

The adapted Slice-3 formation witness must establish:

1. H forms through the same accepted Slice-3 FormationWarrant / participation / Recognition chain.
2. Formation alone does not install an occupant.
3. If Slice-4 representation creates the persistent role together with H, the role is vacant at formation closure.
4. No `HouseholdDecisionContext` or Household initiative is generated merely because H exists.
5. No head-scoped provision, spend, mediation, succession or other head-mediated effect occurs absent later accepted appointment/authority.
6. No founder/current participant is implicitly installed by stable ID, collection order, wealth, kinship, sex, founder status or another hidden fallback.
7. Accepted self-nomination does not transform formation into automatic self-installation.
8. Accepted Inactive-H role filling remains a later lifecycle operation and is not a formation side effect.
9. Ordinary Slice-3 Household identity/participation semantics remain unchanged.

### Required negative challenge

At minimum one mutant/fault must demonstrate that the adapted witness fails if formation silently assigns an occupant or generates Household initiative.

### Forbidden weakening

Do not replace the old assertion with only “a role object exists.”

Do not count vacancy as proof unless occupancy and Household-initiative surfaces are independently inspected.

Do not rewrite frozen S3-014 wording/status.

## 5. Adaptation B — S3-093 / S1-084 structural authority non-hiding

### Frozen semantic invariant

The inherited invariant is:

> no hidden behavior-affecting derived authority.

Exact private-field inventories were an implementation-local enforcement technique, not a permanent ban on later accepted authoritative fields.

### Trigger

This adaptation fires only if Slice-4 implementation changes one of the exact reflected inventories or replaces the inherited structural-audit path.

If a separate explicit authoritative partition preserves the exact inherited inventories, the old field allowlist need not be edited merely because Slice 4 exists.

### Authorized adaptation when triggered

Replacement evidence must remain at least as strong as exact inventory matching.

It must establish:

1. Every new behavior-affecting authoritative Slice-4 state is explicit, typed/inspectable and included in structural audit.
2. No current-head, role-eligibility, Recognition, candidate, availability, funding or dependency cache becomes an undeclared source of authority.
3. Any derived/cache/index representation remains independently rebuildable/discardable at a safe stable boundary and stale values cannot alter behavior.
4. Current role identity/occupancy is not inferred solely from diagnostic history, container order, derived participant snapshots or unrelated Person attributes.
5. Structural audit enumerates the authoritative surface rather than permitting broad wildcard “later fields allowed” exemptions.
6. If exact allowlists remain the enforcement method, add only specifically accepted authoritative fields.
7. If another enforcement method replaces exact inventory matching, it must separately prove equivalent-or-stronger hidden-state detection.

### DEC-0011 / DEC-0013 sharpening

The audit must treat as behavior-affecting if persisted across phases any state whose hidden/stale value could determine:

- captured appointment/succession consent cohort;
- provision refusal/reconsideration/cooldown state;
- explicit selected private-`X` term;
- selected exact funding plan;
- transaction-local commitment-side capacity after accounting for `X`;
- authoritative funding-resolution result;
- declared/evaluated material dependency participation.

A funding/dependency cache may not become a second source of truth alongside the single authoritative live funding evaluation required by S4-183..186.

### Required negative challenge

The adapted structural evidence must fail under at least one deliberately introduced fault/mutant in which **behavior actually depends on a hidden or stale authority source from the new Slice-4 authority/resource/dependency seam**.

The mandatory challenge must target at least one of:

- hidden/stale current-head or role-authority state;
- hidden/stale authoritative funding-resolution state, including selected funding participation/capacity relevant to the committed result;
- hidden/stale material-dependency participation state/cache that changes conflict grouping or resolution behavior.

The mutant must change or be capable of changing observable semantic behavior if the hidden/stale state is trusted, and the adapted structural enforcement must detect/reject that mutant.

A generic unrelated hidden-field/cache mutant is **not sufficient by itself** to satisfy this requirement.

Additional generic hidden-state mutants may be retained as corroborating coverage, but they do not replace this critical-seam negative proof.

### Forbidden weakening

- deleting S1-084/S3-093 coverage;
- broad wildcard reflection exemptions;
- moving authority to static/global/diagnostic state to evade structural audit;
- treating comments/documentation as proof;
- declaring a cache “derived” while allowing stale cache state to affect behavior.

## 6. Adaptation C — Slice-3 no-Household-material-event oracle assumption

### Frozen semantic invariant

Slice 3 provision establishes backing/capacity only:

- no Household treasury;
- no Household-originated support/dowry/spending authority;
- no contributor debit execution from Household action.

That remains frozen Slice-3 truth.

Slice 4 legitimately adds bounded Household material effects.

### Authorized adaptation

Scope the historical prohibition to the semantic boundary it was intended to prove, while positively constraining the new allowance.

#### Historical Slice-3 boundary

For Slice-3 rule contexts/completion scenarios:

1. Household/participation/continuity/lineage events still produce no material effect.
2. Pre-existing provision commitments move no grain merely by existing.
3. `MobilizableCapacity(H)` remains derived only.
4. No Slice-4 Household support/dowry material effect is generated.
5. No DEC-0011 private-`X` funding leg exists because the corresponding Slice-4 action does not exist.

#### Slice-4 allowance

Household-originated material change is permitted only when:

1. the effect is one of the accepted Slice-4 Household material uses;
2. valid Active-H/current-head/scoped authority exists where required;
3. the one authoritative funding-resolution result supports the effect;
4. contributor/private debits and recipient/effect accounting are exact and nonnegative;
5. protected reserve / `NeedsGrain` constraints hold;
6. no treasury/hidden pool appears;
7. semantic history carries truthful rule/configuration/source provenance;
8. malformed or unrelated `Household*` material events still fail.

### DEC-0011 private-X boundary

Transaction-specific `X` is a **funding leg inside one Household action**.

The adapted oracle must not:

- require a separate Gift/Help/Loan event for `X`;
- treat `X` as an independent Household spending meaning;
- permit `X` to become standing `MobilizableCapacity`;
- infer a persistent provision commitment from `X`.

Where material rows aggregate a Person's total delta, separate typed funding provenance must still make private and commitment-backed legs auditable under S4-184/S4-190.

### Allowed enforcement form

Rule-version/context/event-family distinctions, scenario-level oracle composition, or another explicit semantic boundary are allowed.

Cosmetic event renaming is not.

### Required corruption controls

Future verification must reject at least:

- arbitrary new Household material event outside accepted meanings;
- accepted-looking Household event with missing/invalid authority;
- wrong funding/debit arithmetic;
- private `X` represented as an ordinary personal transfer side event;
- hidden treasury/pool material source.

### Forbidden weakening

Do not simply remove the Household-material assertion globally.

Do not exempt all `Household*` events from material accounting.

## 7. Adaptation D — provision commitment provenance

### Frozen semantic invariant

Slice 3 permits only declared controlled pre-existing valid `HouseholdProvisionCommitment` fixtures when testing backing/capacity rather than acquisition.

Slice 4 adds endogenous acquisition.

Later acquisition forms must not retroactively change the meaning of Slice-3 fixture commitments.

### Current literal witness

`HouseholdOracle` requires every observed commitment to carry nonempty fixture provenance.

That remains correct for the frozen Slice-3 boundary and must become a strict closed provenance model once endogenous commitments exist.

### Authorized adaptation — closed semantic provenance union

The adapted checker must distinguish at least three semantic provenance shapes.

#### A. Slice-3 controlled fixture commitment

Must:

- retain explicit fixture/producer/output identity;
- match the declared controlled write;
- carry no fabricated endogenous acquisition chain;
- remain unsuitable as proof that endogenous acquisition occurred.

#### B. Slice-4 ordinary endogenous commitment

For a commitment from a non-head target/contributor, provenance must establish as applicable:

1. actual Household/head provision request or accepted institutional need context;
2. valid current H/head/scoped authority;
3. current target sustaining participant;
4. target's explicit voluntary acceptance/response;
5. causal order from request -> acceptance -> commitment creation;
6. exact rule/configuration/time provenance;
7. no substituted fixture provenance;
8. no grain movement merely from commitment creation.

#### C. Slice-4 current-head self-commitment

For accepted DEC-0013 D4, provenance must establish:

1. P is the current valid head and current sustaining participant.
2. H/head has the explicit institutional request/need predicate for standing provision access.
3. P separately and explicitly authorizes their own private resource capacity to enter the persistent v0 commitment relation.
4. The same PersonId occupying both capacities does not collapse the two predicates.
5. No P→P `ResponseDecisionContext` or fabricated self-response is required or created.
6. No extra personal initiative is consumed merely to represent the second capacity.
7. Ordinary eligibility, reconsideration/cooldown, termination and provenance rules still apply.
8. Office occupancy alone never creates the commitment.
9. Commitment creation itself moves no grain.

Exact record/enum/class layout remains implementation-local; the provenance kinds must nevertheless be closed/typed enough that a checker can reject cross-labeling and missing causal authority.

### Transaction-specific X is not commitment provenance

DEC-0011 transaction-specific private `X`:

- creates no persistent commitment;
- is not a fixture or endogenous commitment-acquisition kind;
- must remain transaction funding provenance under S4-188..190.

The checker must reject an implementation that materializes `X` by silently creating a persistent commitment or by using a fake commitment-acquisition provenance record.

### Required corruption controls

Reject at least:

- endogenous ordinary commitment with fabricated fixture provenance and no valid request/acceptance;
- fixture commitment relabeled endogenous with nonexistent causal chain;
- ordinary endogenous commitment bound to wrong H/head/participant;
- target acceptance from wrong actor or commitment creation before acceptance;
- self-commitment created from office occupancy alone;
- self-commitment that lacks explicit private-resource authorization;
- self-commitment that invents a P→P response and thereby changes accepted topology;
- one-transaction private `X` misclassified as a persistent commitment;
- any commitment creation that itself moves grain.

### Forbidden weakening

Do not change the oracle to accept “fixture OR anything non-null.”

Do not infer acquisition merely because a commitment exists.

Do not require the ordinary target-response shape for accepted head self-commitment.

## 8. Adaptation E — frozen-manifest integrity

No frozen prior manifest changes are authorized.

Specifically:

- `SFL-V0-S1-ACCEPTANCE-v1` remains immutable;
- `SFL-V0-S2-ACCEPTANCE-v1` remains immutable;
- `SFL-V0-S3-ACCEPTANCE-v1` remains immutable;
- frozen Slice-4 v1 remains immutable historical evidence;
- frozen successor Slice-4 v2 remains immutable current completion authority;
- S3-014/S3-093 statuses and wording remain historical frozen authority;
- later executable tests may change only under this lossless adaptation mapping.

Completion evidence must distinguish frozen historical acceptance authority, current adapted executable witness, and explicit mapping between them.

## 9. Cross-cutting successor constraints

Adaptation authority may not be used to bypass current successor obligations.

In particular:

- one authoritative funding-resolution result remains controlling;
- dependency discovery consumes declared/evaluated material participation rather than independently rediscovering allocation;
- typed funding/source/authority provenance remains reconstructable;
- `MobilizableCapacity(H)` remains derived/non-authoritative;
- resource state cannot define Household/role/Recognition identity;
- exact private-`X` arithmetic/nontransfer/side-effect rules remain enforceable.

If an inherited witness can remain green only by violating one of these accepted successor constraints, stop: that is not a verification adaptation.

## 10. Implementation sequencing if approved

If this plan receives independent PASS:

1. the bounded Slice-4 implementation task may cite it as pre-authorized verification-adaptation authority;
2. production/test changes fire an adaptation only when they actually touch the corresponding inherited literal witness;
3. each triggered adaptation must be identified explicitly in the implementation report;
4. exact diffs must remain inside this plan's mapped scope;
5. any newly discovered inherited literal witness outside this plan is a STOP / escalation before modification;
6. post-implementation conformance must audit that frozen prior semantics remain represented by the adapted evidence;
7. no currently green test needs pre-editing before the corresponding Slice-4 production change fires its trigger.

Approval of this plan does not by itself close the Director implementation block; the Master Architect must record the adaptation gate closed before coding dispatch.

## 11. Independent review requirements

A fresh reviewer must independently verify:

- all four identified current literal witnesses really exist at the current implementation base;
- no fifth inherited breakpoint was silently assumed away;
- Adaptation A preserves formation-time headlessness despite accepted self-nomination/Inactive role fill;
- Adaptation B remains strong enough to detect hidden behavior-affecting role/funding/dependency authority;
- Adaptation C preserves historical Slice-3 no-spending semantics while admitting only accepted Slice-4 Household material effects and exact private-`X` funding provenance;
- Adaptation D strictly distinguishes fixture, ordinary endogenous and current-head self-commitment provenance without forcing fake P→P responses;
- transaction-specific `X` cannot masquerade as persistent commitment acquisition;
- no frozen manifest is edited/reclassified;
- no unsupported representation requirement or future economy architecture is introduced;
- no production code change is required merely to satisfy the plan;
- any future inherited witness outside the plan remains STOP/escalation.

Use exactly one verdict:

- **PASS — ADAPTATION PLAN APPROVED**
- **BLOCK — LOSSLESSNESS / ENFORCEMENT DEFECT**
- **BLOCK — SEMANTIC ESCALATION**

## 12. Scope closure

This candidate closes only the known S4-170..175 inherited-verification adaptation gate if independently approved.

It does not:

- prove Slice-4 implementation;
- authorize new semantics;
- waive future newly triggered inherited evidence issues;
- change historical Slice-3 completion;
- authorize coding before explicit adaptation-gate closure.

After independent PASS and recorded gate closure, the Master Architect may proceed to close the remaining Director implementation block and issue the bounded Slice-4 implementation packet.
