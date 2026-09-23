# Repository Branch Hygiene Census

**Status:** READ-ONLY CENSUS COMPLETE / PROPOSAL ONLY — NOT EXECUTED  
**Census date:** 2026-09-22/23 transition  
**Canonical main at census:** `ce443e587aa59d842c7a99a962047fe4a96ee267`  
**Remote branch count:** 72  
**Open pull requests:** 0  
**Mutation performed:** none

## Summary

| Proposed class | Count |
|---|---:|
| AMBIGUOUS — MASTER ARCHITECT REVIEW | 2 |
| DELETE — MERGED/REDUNDANT | 23 |
| KEEP — FROZEN AUTHORITY/EVIDENCE | 45 |
| DELETE — ABANDONED/SUPERSEDED | 1 |
| ACTIVE | 1 |

The census deliberately does **not** equate “ahead of main” with “must keep” or “must delete.” Several squash-merged branches retain unique commit identities while their meaningful file content is durable on `main`. Conversely, TRES/GOV branches with unique review commits are retained when they are part of the project’s explicit frozen/reproducibility provenance.

## Complete branch table

| Branch | Head SHA | Relation to current main | Open PR | Canonical role/reference | Proposed class | Rationale |
|---|---|---|---|---|---|---|
| `archive/res0001-files` | `64e0c4856ec515e74de0ae9f4f58add087fdcecb` | diverged +153/-373 | No | RES-0001 source/recovery history; reconciliation still pending | **AMBIGUOUS — MASTER ARCHITECT REVIEW** | Large unique history; main says relevant returns are recovered but reconciliation is still pending. |
| `archive/res0001-ingest` | `95aefa537f7c1b58777509b12308a6a396d5f6df` | behind +0/-373 | No | No live branch dependency; recovered RES-0001 content is on main | **DELETE — MERGED/REDUNDANT** | No unique commits relative to main; ingestion result is durable on main. |
| `archive/uruk-accident-tablets` | `2d0ed9e9009101ebb1f95d5595e5277d73a4748b` | behind +0/-136 | No | Uruk Accident archive/tablets are durable on main | **DELETE — MERGED/REDUNDANT** | Merged archive working branch; no unique commits. |
| `benchmark/host-runtime-bakeoff` | `3799e78ecc2313c71e3da6395fdf41fe23eadccc` | diverged +32/-489 | No | ADR-0005/DEC-0008 rationale depends on project-specific bakeoff evidence | **AMBIGUOUS — MASTER ARCHITECT REVIEW** | Unique benchmark machinery/payload history is not present on main; deletion would reduce runtime-decision reproducibility. |
| `completion/imp-0001-slice1` | `63557a4ffc1dbc91e1a3f29888660b45a98d15be` | diverged +7/-1 | No | PR #27 merged; final completion record is on main | **DELETE — MERGED/REDUNDANT** | Squash-merged completion working branch; durable result is on main. |
| `dispatch/imp-0001-slice1` | `d9702b6fe8416d61c64a6cd633671390cd076a82` | behind +0/-143 | No | PR #6 merged; dispatch record durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits; dispatch branch no longer serves an active role. |
| `governance-eval/assurance-escalation` | `f9e15e09027bf45bab5fbec4a09932fa0a3d09e2` | diverged +21/-159 | No | GOV-0001 reconciliation explicitly records branch and return commit | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Fresh-agent evaluation provenance intentionally retained. |
| `governance-eval/delegation-research` | `39e9ca11a4e256591719e7e545b760736a7391bc` | diverged +20/-159 | No | GOV-0001 reconciliation explicitly records branch and return commit | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Fresh-agent evaluation provenance intentionally retained. |
| `governance-eval/root-routing` | `f467151ffedd8c822eb6bcfda1d473f81e8bcd77` | diverged +20/-159 | No | GOV-0001 reconciliation explicitly records branch and return commit | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Fresh-agent evaluation provenance intentionally retained. |
| `governance-rulebook-refactor-baseline` | `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b` | behind +0/-159 | No | GOV-0001 README/PROMOTION_RECORD explicitly names frozen baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Constitutional refactor reproducibility baseline. |
| `governance-rulebook-refactor-candidate` | `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679` | diverged +19/-159 | No | GOV-0001 README/PROMOTION_RECORD explicitly names evaluated candidate | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Exact evaluated constitutional candidate. |
| `governance-rulebook-refactor-eval-baseline` | `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679` | diverged +19/-159 | No | GOV-0001 reconciliation explicitly names frozen evaluation baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Named evaluation-control ref even though SHA equals candidate. |
| `governance/gov-0001-promotion` | `08ff5db5fc694b7afda9c9510c4708996f34dc22` | behind +0/-148 | No | GOV-0001 README/PROMOTION_RECORD says promotion branch retained as provenance | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Explicit constitutional promotion provenance. |
| `governance/imp0001-assurance-retrospective` | `0c1bf38f6fff458778b2039f6187292f16a047e6` | behind +0/-61 | No | PR #19 merged; protocol changes and retrospective durable on main | **DELETE — MERGED/REDUNDANT** | Merged governance working branch; no unique commits. |
| `handoff/master-architect-succession` | `536a8b3cc75590f5184ef3097591043b961ff59f` | behind +0/-31 | No | PR #24 merged; handoff file durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits; succession branch no longer needed. |
| `imp-0001-slice1-conformance-candidate-v1` | `7e11dab7697121eb0dbb169ba46210d81b80586e` | behind +0/-131 | No | Final completion record preserves candidate-v1 as BLOCK evidence | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Immutable failed conformance candidate. |
| `imp-0001-slice1-conformance-candidate-v2` | `ba16829e240950f1f3c648107cf3b8b36f996971` | behind +0/-122 | No | Final completion record preserves candidate-v2 as BLOCK evidence | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Immutable failed conformance candidate. |
| `imp-0001-slice1-conformance-candidate-v3` | `06e25644879dd8505e24fcaeb43256f69c29c15f` | behind +0/-115 | No | Final completion record preserves exact PASS candidate | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Immutable independently verified candidate. |
| `implementation/imp-0001-slice1` | `7e11dab7697121eb0dbb169ba46210d81b80586e` | behind +0/-131 | No | Historical working alias of candidate-v1; candidate ref remains | **DELETE — MERGED/REDUNDANT** | Exact SHA duplicated by frozen candidate-v1 ref. |
| `implementation/imp-0001-slice1-repair-v2` | `ba16829e240950f1f3c648107cf3b8b36f996971` | behind +0/-122 | No | Historical working alias of candidate-v2; candidate ref remains | **DELETE — MERGED/REDUNDANT** | Exact SHA duplicated by frozen candidate-v2 ref. |
| `implementation/imp-0001-slice1-repair-v3` | `06e25644879dd8505e24fcaeb43256f69c29c15f` | behind +0/-115 | No | PR #23 promoted; candidate-v3 ref remains | **DELETE — MERGED/REDUNDANT** | Exact SHA duplicated by frozen candidate-v3 ref. |
| `junior/uruk-accident-institutional-persistence-seed` | `86bf9de30674f162ffe6f4a9450cb876ca6a544b` | diverged +1/-196 | No | PR #1 abandoned; preserved Uruk source archive/README exist on main | **DELETE — ABANDONED/SUPERSEDED** | Unique branch commit carries content later preserved durably in the canonical conceptual archive. |
| `main` | `ce443e587aa59d842c7a99a962047fe4a96ee267` | identical +0/-0 | No | Canonical repository branch | **ACTIVE** | Current canonical project state. |
| `maintenance/imp0001-review-preservation-repair` | `97fe10dcea3dcb47eb00f89d198a5014143e1d1d` | behind +0/-48 | No | PR #20 merged; exact repaired report/blob durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits; preservation result is canonical. |
| `plan/post-imp0001-hygiene-assurance` | `c4b3efc20bc5036e36d8ff708bd838cf8ee361c8` | behind +0/-68 | No | PR #17 merged; plan durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `plan/slice1-birth-observation` | `e4a223e4d5fa4eb68ede2e2a7d9b9f3e6d0c2d85` | behind +0/-88 | No | PR #13 merged; Birth Run plan durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits; plan is canonical on main. |
| `research/institutional-dynamics-draft` | `14653d3b12d2b6e1bc734c4e22e6318a8920a5c9` | behind +0/-98 | No | Final conceptual package durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits; earlier draft branch superseded by merged package. |
| `research/post-v0-future-directions` | `3d066a85ab6b9d035d1261f95c78ed8588cdb2e6` | behind +0/-134 | No | PR #9 merged; provisional conceptual direction durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `research/sfl-v0-discovery-seams` | `152eea4e03b164c4b11757dc7141dd981244987c` | behind +0/-79 | No | PR #14 merged; discovery-seams artifact durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `review/imp-0001-block-reconciliation` | `d5b813248cbcfafa069f85548d414318c6a13ffc` | behind +0/-71 | No | PR #15 merged; reconciliation durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `review/imp-0001-conformance-dispatch` | `3247666e472f69e71c7ffa7fbfac94130914d261` | behind +0/-92 | No | PR #12 merged; dispatch packet durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `review/imp-0001-independent-conformance-v2-return` | `1e97d2a3b10ecab59408e42eb5464484e2066fd1` | behind +0/-46 | No | PR #21 merged; exact v2 report durable on main | **DELETE — MERGED/REDUNDANT** | Return artifact is canonical; frozen candidate-v2 preserves reviewed code identity. |
| `review/imp-0001-independent-conformance-v3-return` | `5255be7e757fce885dde105b41460590bac0e2cd` | diverged +1/-29 | No | PR #26 squash-merged; exact report bytes/hash durable on main | **DELETE — MERGED/REDUNDANT** | Unique commit identity is unnecessary because report content and SHA-256 are preserved canonically. |
| `review/imp-0001-v2-block-reconciliation` | `6352df975116a2cb31e828246a59e80b7d67d8aa` | behind +0/-40 | No | PR #22 merged; repair-v3 authority durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `review/imp-0001-v2-conformance-dispatch` | `d034925ea9266ba4335dddacba3e12d3e0842c8a` | behind +0/-62 | No | PR #18 merged; candidate-v2 dispatch record durable on main | **DELETE — MERGED/REDUNDANT** | No unique commits. |
| `review/imp-0001-v3-conformance-dispatch` | `3c037a91f2f4bc122beb9e8128a62fd218712dde` | diverged +7/-30 | No | PR #25 squash-merged; all dispatch/navigation artifacts durable on main | **DELETE — MERGED/REDUNDANT** | Squash-merged working branch; no unique authoritative content. |
| `sfl-v0-slice1-acceptance-v1` | `55377cc34b8bc3ccbf9cdf5029e9791dae965987` | behind +0/-178 | No | Frozen Slice-1 acceptance authority named throughout completion records | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Immutable acceptance authority/ref. |
| `tres-0010-b2-baseline` | `0729e460af35668e5b911fa561bf8cec53204142` | behind +0/-231 | No | TRES-0010 README explicitly names Wave B2 frozen baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Research baseline used by isolated B2 returns. |
| `tres-0010-closed` | `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b` | behind +0/-159 | No | No current canonical owner requires this ref; SHA duplicates GOV baseline | **DELETE — MERGED/REDUNDANT** | Exact commit is retained under governance-rulebook-refactor-baseline; redundant alias. |
| `tres-0010-manifest-repair-review-baseline` | `8a809a05276571fb15845f012dc7dae1c71380d8` | behind +0/-190 | No | TRES-0010 README/reconciliation explicitly names frozen MRR baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Blind review baseline. |
| `tres-0010-manifest-review-baseline` | `3c3b58d95ef479fcbe93eb08a406388c119feab6` | behind +0/-196 | No | Pre-code manifest review provenance | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Original manifest BLOCK review baseline. |
| `tres-0010-manifest-review-r2-baseline` | `7fe85af66723885fecc16c0222538265cbf693bc` | behind +0/-182 | No | TRES-0010 README explicitly names frozen R2 baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | R2 PASS review baseline. |
| `tres-0010-review-baseline` | `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac` | behind +0/-261 | No | TRES-0010 pre-implementation review baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Wave-A common baseline/provenance. |
| `tres-0010-wave-b-baseline` | `f25407a9cbf09e501601d52ad7a2df111fa5c491` | behind +0/-247 | No | TRES-0010 README/Wave-B synthesis explicitly names baseline | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Wave-B common baseline/provenance. |
| `tres-0010/a` | `58c756aa7ec84e12ae01f0778daf82151dae959a` | diverged +1/-261 | No | TRES-0010 README explicitly says Wave-A returns live on a–j branches | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return not otherwise fully preserved on main. |
| `tres-0010/b` | `8b1a3152e9fc67929ca99cd44d7016e37c1ad729` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/b2-asr` | `5dd3fef17abd5cb7cd669f1238756a89a9fff5f8` | diverged +1/-231 | No | TRES-0010 B2 isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique decision-support return. |
| `tres-0010/b2-sem-a` | `a8d36d3e20942d6344bac5853b36b258999c0333` | diverged +1/-231 | No | TRES-0010 B2 isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique decision-support return. |
| `tres-0010/b2-sem-t` | `881f2806dec0b9d7b50f39291fcaf1ca685c67b6` | diverged +1/-231 | No | TRES-0010 B2 isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique decision-support return. |
| `tres-0010/c` | `283730d8e91de9743195d9fd13c635baa2131cbb` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/d` | `c776891cd1a9d48bf9a06f08b2f3c6e66b98d0c8` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/e` | `6f2e3ab430d7e4c865f7514424d79d5f6657b41e` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/f` | `9563d785f341478df9015691d5167715f72c2883` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/g` | `10216f484ed13851be19f71af4036a781fa83b1f` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/h` | `138b69cf7d24765d757e33278f7d76daa4591bcb` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/i` | `8acdc5ad526fbff65f016ec899b0836c945bff56` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/j` | `8e983bd4dd200c2fbcd9153bc9a7df62f9e87256` | diverged +1/-261 | No | TRES-0010 Wave-A isolated return | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique advisory return provenance. |
| `tres-0010/manifest-precode-review` | `26ed3186d88b4bc7797ea096bf0b552a80232872` | diverged +1/-196 | No | TRES-0010 README explicitly retains first manifest BLOCK return branch | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique independent BLOCK review evidence. |
| `tres-0010/manifest-precode-review-r2` | `68446a26610c62af1e6e3cdfa9d521180233e1de` | diverged +1/-182 | No | TRES-0010 README explicitly names R2 PASS return branch | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Independent corrected-manifest PASS provenance. |
| `tres-0010/mrr-boundary` | `b3852a6c84ba30c715036116dff84519e93d235e` | diverged +1/-190 | No | TRES-0010 README explicitly names MRR return branch | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Blind source-grounded repair review return. |
| `tres-0010/mrr-grain-ingress` | `388531b86ca83fc4433e8672b73deb32fe7c1266` | diverged +1/-190 | No | TRES-0010 README explicitly names MRR return branch | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Blind source-grounded repair review return. |
| `tres-0010/mrr-semantic-scope` | `6270b3393901393779c0dfca5b91df01070737b0` | diverged +1/-190 | No | TRES-0010 README explicitly names MRR return branch | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Blind source-grounded repair review return. |
| `tres-0010/wb-a-defense` | `837940cc1d21c75e1b4c04e682a1a9f882107ac3` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-a-prosecution` | `45c34eaa7310b0ecad2c8ac39eadaa66825fdfce` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-f-defense` | `eacde9872a65ff20a1847967137e2894b2fb2be2` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-f-prosecution` | `d7890cf1f8a7c26d9117371be746495f7f11bbb9` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-i-defense` | `62c9d24a830fc97f27917ef81f79784ca5b0be02` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-i-prosecution` | `420efacd7acbf8b2f27f1c8c264eb6868d225672` | diverged +2/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return with two unique commits. |
| `tres-0010/wb-sentinel-b` | `a07abbe012748871c9c408157b9d3e5ba5cfce6c` | diverged +1/-247 | No | Wave-B synthesis records sentinel re-derivation methodology | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique sentinel return. |
| `tres-0010/wb-sentinel-d` | `fbf7eb86b2199d676e43596f052adac1026fe698` | diverged +1/-247 | No | Wave-B synthesis records sentinel re-derivation methodology | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique sentinel return. |
| `tres-0010/wb-t-defense` | `851e5368819f949bf3d56259a4b2481c107c67d7` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |
| `tres-0010/wb-t-prosecution` | `79b99cb1e57930c5bd930363ab5bb111e2fa9685` | diverged +1/-247 | No | Wave-B synthesis depends on isolated prosecution/defense returns | **KEEP — FROZEN AUTHORITY/EVIDENCE** | Unique Wave-B advisory return. |

## Ambiguous refs requiring Master Architect judgment

- `archive/res0001-files`
- `benchmark/host-runtime-bakeoff`

These are ambiguous for different reasons:

- `archive/res0001-files` contains substantial unique historical-research ingestion history while RES-0001R reconciliation remains pending, even though the recoverable A–H artifacts are now on `main`.
- `benchmark/host-runtime-bakeoff` contains unique benchmark workflow/payload/runner material not present on `main`, while ADR-0005 explicitly rests in part on a project-specific runtime bakeoff.

## Proposed deletion set — PROPOSAL ONLY / NOT EXECUTED

- `archive/res0001-ingest`
- `archive/uruk-accident-tablets`
- `completion/imp-0001-slice1`
- `dispatch/imp-0001-slice1`
- `governance/imp0001-assurance-retrospective`
- `handoff/master-architect-succession`
- `implementation/imp-0001-slice1`
- `implementation/imp-0001-slice1-repair-v2`
- `implementation/imp-0001-slice1-repair-v3`
- `junior/uruk-accident-institutional-persistence-seed`
- `maintenance/imp0001-review-preservation-repair`
- `plan/post-imp0001-hygiene-assurance`
- `plan/slice1-birth-observation`
- `research/institutional-dynamics-draft`
- `research/post-v0-future-directions`
- `research/sfl-v0-discovery-seams`
- `review/imp-0001-block-reconciliation`
- `review/imp-0001-conformance-dispatch`
- `review/imp-0001-independent-conformance-v2-return`
- `review/imp-0001-independent-conformance-v3-return`
- `review/imp-0001-v2-block-reconciliation`
- `review/imp-0001-v2-conformance-dispatch`
- `review/imp-0001-v3-conformance-dispatch`
- `tres-0010-closed`

## Protected refs

Regardless of later cleanup, this census treats the following as protected frozen authority/evidence:

- `sfl-v0-slice1-acceptance-v1`;
- `imp-0001-slice1-conformance-candidate-v1`;
- `imp-0001-slice1-conformance-candidate-v2`;
- `imp-0001-slice1-conformance-candidate-v3`;
- GOV-0001 frozen baseline/candidate/evaluation provenance;
- TRES-0010 baselines and isolated reviewer/research return refs that remain part of the canonical research record.

## Notes

- All pull requests are currently closed; no open PR blocks branch classification.
- The three historical IMP implementation working branches are exact-SHA aliases of the three frozen candidate refs and are therefore proposed for deletion while the candidate refs are kept.
- `tres-0010-closed` is proposed for deletion because its head SHA exactly duplicates `governance-rulebook-refactor-baseline`, whose name is the one explicitly retained by GOV-0001 provenance.
- This census does not authorize deletion. Master Architect reconciliation is required before any destructive execution.
