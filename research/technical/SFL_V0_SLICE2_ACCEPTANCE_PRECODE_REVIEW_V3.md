# SFL v0 Slice 2 — Acceptance Applicability Pre-Code Review V3

**Status:** RETURN / **BLOCK — VERIFICATION-AUTHORITY REPAIR**  
**Review authority:** fresh read-only pre-code acceptance review  
**Reviewed candidate:** `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_APPLICABILITY_CANDIDATE.md`  
**Reviewed candidate branch:** `verification/sfl-v0-slice2-acceptance-candidate-v3`  
**Reviewed candidate commit:** `190695d40cf6b12682aa9c5586fcb34aea99a80b`  
**Reviewed candidate blob:** `6996f27cb2abef0dd99b25dcaaaea08aef482a60`  
**Return branch:** `review/sfl-v0-slice2-acceptance-precode-v3-return`  
**Implementation authority exercised:** none  
**Semantic promotion authority exercised:** none

## 1. Judgment

**BLOCK — VERIFICATION-AUTHORITY REPAIR.**

Candidate v3 closes both remaining V2 blockers and does not introduce a new semantic question. The exact candidate bytes nevertheless contain one collateral authority defect that prevents the required **MAY FREEZE UNCHANGED** judgment:

- In §7, after the RG-01 oracle restrictions, the conditional failure sentence still says: `candidate v2 BLOCKS`.
- The document under review is candidate v3. Freezing these exact bytes would canonize a normative pre-code failure path that names the wrong candidate.
- This is not a social-semantic defect and does not require Director authority. Repair the candidate identity in that sentence (preferably `candidate v3 BLOCKS` or version-neutral `this candidate BLOCKS`) without changing the RG-01 semantics.

Because the packet permits PASS only as **PASS — MAY FREEZE UNCHANGED**, the exact reviewed blob cannot PASS unchanged.

**RG-01:** **SUPPORTED.**  
**Director decision:** **NO DIRECTOR DECISION REQUIRED.**  
**Freeze judgment:** **DO NOT FREEZE THIS BLOB UNCHANGED.**

## 2. Exact source set re-derived

Repository authority was re-derived from the exact candidate commit, with the fresh V3 task packet retrieved separately from the named candidate branch.

| Source | Blob |
|---|---|
| `AGENTS.md` | `ee9f27664b912e07eb0a8fedc819a6f5a05ed257` |
| `00_START_HERE.md` | `cf11d0ce07b72fbe97577575d419df8f3e3a8ccf` |
| `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` | `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52` |
| `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` | `66cfd55f8b960ff5664638c41c0e731257902be5` |
| `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` | `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229` |
| `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md` | `43eedd7eb49e1eae035010332883ed2d8726d451` |
| `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md` | `d8f87dea9569d41481850c7327a025c44d6c3358` |
| `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| `research/technical/SFL_V0_SLICE2_AUTHORITY_INVENTORY.md` | `a6f0bc8e6369b4cd854b42cf2042dc1052ec5b4d` |
| `research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md` | `3c15cb411fd08c5bfc64670cda47bf0b0b91efd6` |
| `research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md` | `40fdeaf2e8be7b5321a5d16662c5706d4a917a32` |
| `research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md` | `f6a6ffef1368836545e75aaa30ef77a0274538ef` |
| prior V1 review | `a4e44f74710223e4f7f97ee6ff278117eafe2ab2` |
| prior V2 review | `adf4c193fc55bed0619fb9414139e671a3bde5e6` |
| exact candidate v3 | `6996f27cb2abef0dd99b25dcaaaea08aef482a60` |

Conceptual tablet material was not used as semantic authority.

## 3. Accepted contract re-derived

Accepted authority fixes the Slice-2-relevant distinctions used in this review:

- objective execution truth remains distinct from actor subjective state;
- `KnownFact` is actor-held factual state with provenance;
- `Recognition` is provenance-bearing social interpretation, distinct from KnownFact, objective truth, scalar confidence, attitude, approval, and obedience;
- Recognition states are `Unknown / Recognized / Contested`; `CandidateRecognition(C)` is ephemeral and pre-Household;
- direct automatic acquisition covers own state, direct-party claims/relations, and direct participation; other acquisition needs accepted observation or communication;
- `CommunicateClaim/Inform` may transmit factual or Recognition propositions the sender currently holds and preserves sender plus underlying source/event provenance where available;
- ordinary communication uses the personal initiative rule rather than a free broadcast path;
- subjective state does not passively synchronize; underlying evidence/event order outranks message arrival;
- newer accepted direct evidence and newer event-backed reports have only the bounded precedence accepted by SPEC;
- unresolved incompatible Recognition evidence becomes `Contested`, not an arbitrary technical-ID/sender/arrival winner;
- Recognition does not decay because attitude becomes negative and does not imply approval or obedience/refusal;
- inaccessible candidates are gated before scoring, while objective commit-time revalidation remains authoritative;
- traces expose relevant subjective inputs, and observer/debug reads remain noninterfering.

No accepted source authorizes a universal KnownFact conflict algebra, universal evidence-strength order, generic nonparticipant perception rule, autonomous communication motivation, trust/lying/rumor/reputation system, or universal proposition ontology.

## 4. V2 R1 closure — Recognition communication parity

**PASS / CLOSED.**

V3 makes factual and Recognition communication independently mandatory across every ordinary communication invariant identified by V2:

| Invariant | Factual row | Recognition row | Fixture binding | Result |
|---|---|---|---|---|
| ordinary personal-action pipeline | `S2-020F` | `S2-020R` | `F-COMM-FACT` / `F-COMM-REC` | CLOSED |
| held proposition | `S2-021F` | `S2-021R` | fact / Recognition communication fixtures | CLOSED |
| no invention | `S2-022F` | `S2-022R` | gate fixtures | CLOSED |
| provenance | `S2-023F` | `S2-023R` | `O-PROV` with fact / Recognition fixtures | CLOSED |
| ordinary successful initiative cost | `S2-024F` | `S2-024R` | `F-GATE/F-COMM-FACT` / `F-GATE/F-COMM-REC` | CLOSED |
| recipient-only / no broadcast | `S2-025F` | `S2-025R` | fact / Recognition communication fixtures over the full declared population | CLOSED |
| receipt creates no fresh same-cycle personal activation and no `ResponseDecisionContext` | `S2-026F` | `S2-026R` | fact / Recognition communication fixtures | CLOSED |

The §14 bindings now specifically forbid a Recognition-only bypass from satisfying the factual path. The population-scope note also applies independently to factual and Recognition delivery. V2 R1 is fully repaired.

## 5. V2 R2 closure — refusal/compliance independence

**PASS / CLOSED.**

`S2-009` plus the §15 evidence note now requires **both mandatory paired perturbations independently** while holding C and its supporting evidence fixed:

1. move an unrelated directed Attitude into a negative band;
2. execute an otherwise independent ordinary voluntary `Decline`/refusal through an accepted lower-level request path.

Each comparison requires `Recognition(C)` to remain unchanged solely because of the attitude or refusal/compliance perturbation. The witness explicitly forbids Household/head authority and any new obedience/compliance state. This matches the accepted Recognition-versus-attitude/approval/obedience distinction without pulling later slices forward.

V2 R2 is fully repaired.

## 6. Collateral audit

### Previously closed V1/V2 items

**PASS except for the stale candidate-version sentence identified in §1.**

The V2→V3 diff is narrowly confined to version metadata, the R1 communication split/bindings, the R2 mandatory refusal witness, and corresponding cross-references. It does not weaken the previously closed semantic/applicability items.

Fresh checks found:

- RG-01 remains the exact one-C pre-Household witness; no second candidate label/equivalence, Household, FormationWarrant, head role, authority action, or checkpoint substrate is introduced.
- No hidden negative Recognition proposition is added; S- still supplies a lower-level incompatible Residence fact.
- CandidateRecognition remains explicitly ephemeral/lifetime-scoped.
- Direct-evidence precedence, event-backed report precedence, and arrival-order permutation remain separately mandatory as `S2-031A`, `S2-031B`, and `S2-032`.
- `S2-033` still requires unresolved Recognition conflict to produce `Contested` without actor/sender/stable-ID/arrival-order winner rules.
- The bounded KnownFact census remains KF-OWN / KF-DIRECT-CLAIM / KF-PARTICIPATION / KF-REPORT only.
- All 46 REQUIRED §8 rows have exactly one corresponding §14 fixture/oracle binding key; no REQUIRED row is missing or duplicated in the mapping.
- The exact Slice-1 regression set remains bound: `S1-070`, `S1-GLOBAL-KNOWLEDGE`, `S1-073`, `S1-098-CORE`, `S1-105`, `S1-085`, `S1-META-04`, `S1-MUT-26`, `S1-086`, `S1-MUT-29`, `S1-META-07`, `S1-084`, `S1-META-05`, `S1-MUT-24`, `S1-META-03`, `S1-META-02`, `S1-GLOBAL-FALLBACK`, and `S1-GLOBAL-MANIFEST-INTEGRITY`.
- Triggered prior obligations remain explicit: `S1-098-COMMUNICATION`, `S1-META-08`, `S1-MUT-27`, `S1-MUT-28`, and `S1-076`.
- Household/head/mediated-marriage/provision/lineage/checkpoint/trust/rumor/reputation/richer-agency mechanics remain outside Slice 2.
- Broad/global claims stay bounded by the explicit proposition census, declared fixture population, declared metamorphic perturbations, and isomorphic-ID scope.
- No new Director-level semantic decision is introduced.

### Collateral defect

Candidate v3 §7 retains the V2-era sentence:

> `If fresh review finds this concrete witness still requires an unaccepted semantic distinction, candidate v2 BLOCKS and that exact distinction is escalated.`

That sentence was correct in candidate v2 but became stale when the candidate version advanced. It is the only freeze-blocking defect found in the V3 collateral audit.

## 7. RG-01 status

**SUPPORTED.**

The exact RG-01 witness remains supported by accepted semantics:

- one inert pre-Household referent C only;
- S+ holds provenance-bearing evidence sufficient for `CandidateRecognition(C)=Recognized`; S- holds an incompatible lower-level `Residence(P,D2)` report against the D1 residence support;
- Residence is an accepted single-current-state person→dwelling relation, so D1/D2 are incompatible for the same current-state fact;
- neither controlled fixture provenance dominates under an accepted precedence rule; no new strength rule is introduced;
- recipient `Contested` is production-derived, not fixture-written;
- retained state is bounded to C remaining live with no accepted displacing evidence;
- sender order, delivery order, and consistent nonsemantic ID-renaming permutations may be checked independently;
- the oracle is restricted to public/read-only Recognition/provenance and paired-run relations and may not call the production conflict/precedence/CandidateRecognition derivation helper under judgment.

No negative/opposite Recognition proposition, general contradiction algebra, CandidateOrganization equivalence rule, or generic nonparticipant observation rule is required.

## 8. Director-decision status

**NO DIRECTOR DECISION REQUIRED.**

Both V2 repairs are verification-only and are now substantively complete. The remaining V3 blocker is also verification-authority only: correct the stale candidate identity in §7. No proposition meaning, knowledge entitlement, precedence rule, observation rule, or later-slice semantic boundary needs to change.

## 9. Required repair and freeze judgment

Required repair:

- change the §7 conditional from `candidate v2 BLOCKS` to `candidate v3 BLOCKS` or the version-neutral `this candidate BLOCKS`;
- make no other semantic/applicability change unless separately justified.

After that edit, submit the exact repaired bytes to a fresh independent pre-code review, consistent with the candidate's own freeze mechanics.

**Final disposition: BLOCK — VERIFICATION-AUTHORITY REPAIR.**

**The exact reviewed commit/blob `190695d40cf6b12682aa9c5586fcb34aea99a80b` / `6996f27cb2abef0dd99b25dcaaaea08aef482a60` MUST NOT FREEZE UNCHANGED.**