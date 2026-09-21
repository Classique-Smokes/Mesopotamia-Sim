# TRES-0010B-F-DEFENSE — Formation / Lifecycle Reachability Defense

## Run metadata

- **Task ID / role:** TRES-0010B-F-DEFENSE — defense / closure attempt for formation and lifecycle reachability
- **Frozen Wave-B baseline:** `tres-0010-wave-b-baseline`
- **Resolved baseline commit:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Return branch/workspace:** `tres-0010/wb-f-defense`
- **Model/configuration:** GPT-5.6 Sol
- **Tools used:** GitHub repository connector for frozen-ref file retrieval, branch/baseline comparison, and isolated return write
- **External research:** no
- **Assigned Wave-A report read:** `TRES-0010B_SEMANTIC_REACHABILITY_REPORT.md` only
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**

## Scope and evidence discipline

This return adjudicates only B-001, B-003, B-004, and B-005 from the assigned TRES-0010B report. The Wave-A report is treated as inherited evidence, not authority. Each disposition below was independently rechecked against the frozen accepted specification/ADRs and the relevant canonical verification cards.

For Slice-1 impact, `plans/CURRENT_PHASE.md` is used only as the implementation staging plan: Slice 1 is lower-level individuals/relationships plus proposal-resolution-history; subjective recognition is Slice 2 and persistent household identity begins in Slice 3.

## Executive disposition

None of the four challenged findings requires a semantic repair before IMP-0001 / Slice 1 **provided actor departure is not enabled as a Slice-1 executable stimulus**.

| Finding | Defense result | Slice-1 impact | Confidence |
|---|---|---|---|
| B-001 CandidateOrganization lifecycle/equivalence | `CONFIRMED_LATER_SLICE_GAP` — **narrowed**: a persistent candidate lifecycle is not required, but same-candidate semantic equivalence is not fully operationalized | none; household formation starts later | high-medium |
| B-003 actor departure | `CONFIRMED_LATER_SLICE_GAP` — full-v0 semantics remain undefined; a temporary input guard is sufficient for Slice 1 | none if departure is excluded from Slice-1 fixtures/generation | high |
| B-004 exit-side continuity warrant | `ALREADY_RESOLVED_BY_AUTHORITY` — the semantic obligation already exists; verification wording can be made more explicit later | none | high |
| B-005 repeated same-source participation-end lineage | `CONFIRMED_LATER_SLICE_GAP` — ambiguity suppression does not uniquely settle which end-warrant instance anchors freshness | none; lineage has no v0 behavioral power and is later household work | high-medium |

---

## B-001 — CandidateOrganization lifecycle / equivalence

### Inherited claim

The Wave-A report argued that formation is unreachable or duplicable because `CandidateOrganization` has no explicit create/mutate/consume lifecycle or equivalence rule.

### Defense / serious disconfirmation

The strongest part of that claim does **not** survive the accepted authority.

- SPEC §6.3 explicitly defines `CandidateRecognition(C)` as **ephemeral** and provenance-bearing.
- SPEC §7.1 gives `CandidateOrganization` no causal authority, resources, household actions, or self-supporting evidence.
- SPEC §7.2 makes formation depend on the objective founding-core predicate plus every required founder recognizing the same candidate; it does not require an authoritative “create candidate” command.
- ADR-0003 permits derived values to be recomputed/cached with non-authoritative maintenance strategies behind stable semantic/query boundaries.
- ADR-0004 states that rebuildable indexes/caches are not simulation authority.
- ADR-0001 forbids deriving **stable semantic identity** casually from mutable content, but the accepted spec does not require CandidateOrganization itself to be promoted into a stable persistent entity before formation.

Therefore the smallest “no candidate-creation transition, so zero households can ever form” trace is not compelling. A conforming implementation may treat candidate organizations as derived/ephemeral hypotheses and persist only the recognition proposition/provenance required by the semantic gate.

The canonical formation card supports this reading: VS-SFL-001 forbids fixture-writing CandidateRecognition, then expects production to derive `CandidateRecognition(CandidateABC)` from lower-level evidence before the FormationWarrant commits.

### What remains unresolved

A narrower issue survives. SPEC §6.2 requires actors to recognize **the same** prospective candidate, but accepted authority does not fully define the semantic equivalence/key that makes two independently derived candidate hypotheses “the same C”.

The Wave-A duplicate trace must therefore be refined:

1. A/B(/C) satisfy a valid founding-core predicate and acquire sufficient evidence.
2. Production independently derives candidate hypotheses from that evidence.
3. If two internal rows are merely duplicate cache representations of one semantic hypothesis, ADR-0003/0004 make them non-authoritative and they cannot legitimately create two households.
4. But the accepted artifacts do not state the exact equivalence boundary for candidate hypotheses, especially when candidate derivation could enumerate overlapping/proximate founding cores or multiple representations of one core.
5. §7.5 and VS-SFL-051 suppress reuse of one causal bundle when a valid continuity path to an already non-Dissolved H exists, but they do not by themselves define pre-formation candidate equivalence.

So the missing **persistent lifecycle** is not a blocker; the surviving issue is the semantic identity/equivalence of the ephemeral candidate subject used across founder recognitions.

### Source clauses

- `SPEC-SFL-0001` §§6.2, 6.3, 7.1, 7.2, 7.5
- ADR-0001 — independently identified semantic records / stable-identity constraint
- ADR-0003 — progressive derived-state specialization
- ADR-0004 — authoritative state vs rebuildable cache/index
- `FORMATION_FAMILY.md` VS-SFL-001
- `NO_SELF_CONFIRMATION_FAMILY.md` VS-SFL-051

### Closure state

**`CONFIRMED_LATER_SLICE_GAP` (narrowed).**

The surviving gap is candidate-subject equivalence, not a required persistent CandidateOrganization lifecycle.

### Slice-1 impact

**None.** Current staging places subjective recognition in Slice 2 and persistent household identity/formation in Slice 3. IMP-0001 can proceed without inventing candidate semantics.

### Confidence

**High-medium.** Authority clearly permits the ephemeral/derived reading; it does not clearly fix the remaining equivalence key.

---

## B-003 — Exogenous actor departure

### Inherited claim

The Wave-A report argued that the harness is allowed to inject actor departure, but the accepted model does not define its consequences for world presence, agency, relationships, household participation, head/provision state, or pending work.

### Defense / serious disconfirmation

The finding can be narrowed substantially for current implementation staging.

- SPEC §1.1 says the scenario harness **may** inject bounded exogenous actor arrival/departure. This is fixture authority, not an endogenous personal/household action.
- The cross-cutting verification contract lists controlled exogenous arrival/departure both as generated-history vocabulary and as generally allowed fixture setup.
- No Slice-1 objective in `CURRENT_PHASE.md` requires actor arrival/departure.
- No accepted clause says a verifier must enable every permitted exogenous stimulus in every implementation slice.

Therefore actor departure can be **guarded out of Slice-1 executable fixtures/generated histories** without inventing semantics or blocking the lower-level kernel.

### Counterexample reconstruction

The semantic gap still survives if departure is actually enabled:

1. H is Active with A/B; A may also be head and have a provision commitment.
2. The harness injects “A departs”.
3. SPEC §2.1 has no present/absent/active-in-world state.
4. SPEC §7.4 separately defines voluntary `EndHouseholdParticipation(H)` and its exact consequences; §1.1 never equates exogenous departure with that action.
5. Accepted authority does not decide whether departure merely disables scheduling, removes objective presence, ends residence, ends household participation, vacates head/provision state, affects pending proposals, or leaves lower-level claims/relations live.

Treating departure as an implicit participation end would invent a domain rule; treating it as no semantic change would also be a substantive interpretation once departure is used.

### Source clauses

- `SPEC-SFL-0001` §§1.1, 2.1, 7.4
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md` generated-history operation vocabulary and fixture write-set audit
- `CURRENT_PHASE.md` Slice-1 objective/stage order

### Closure state

**`CONFIRMED_LATER_SLICE_GAP`.**

A local exclusion guard is sufficient for Slice 1, but does not resolve the meaning of departure for a later/full-v0 harness that enables it.

### Slice-1 impact

**No blocker**, conditional on not enabling actor departure in Slice-1 scenarios/generation.

### Confidence

**High.** The permission to inject departure is explicit; its state-machine meaning is not.

---

## B-004 — Exit-side continuity warrant

### Inherited claim

The Wave-A report proposed that an implementation could let B exit an Active A/B household, publish the same H as Inactive from participant count alone, emit no exit-side `ContinuationWarrant`, and still pass the visible lifecycle assertions.

### Defense / counterexample invalidation

As a semantic counterexample, that implementation is invalid under already accepted authority.

- SPEC §7.4 says participation end triggers household lifecycle/**continuity reevaluation** from the remaining sustaining organization.
- SPEC §7.5 states that household continuity **requires** an explicit historical transmission chain, a surviving bridge, bridge recognition of the successor as the same H, and a `ContinuationWarrant` linking prior state, transition evidence, and successor state.
- SPEC §7.6 says lifecycle is published only at stable closure after compatible participation changes **and their required continuity reactions have resolved**. Participant count controls operational lifecycle only; it does not establish identity.
- VS-SFL-010 explicitly checks `ParticipationWarrant -> SustainingParticipant -> ContinuationWarrant` before turnover and its independent oracle checks a historical chain containing `ParticipationWarrant/ParticipationEnd -> ContinuationWarrant`.
- The continuity family invariant forbids participant-count/snapshot similarity from becoming the identity oracle.

So the minimal defective trace:

1. Active H(A,B).
2. B ends participation.
3. Implementation keeps H's identity and publishes Inactive from count=1.
4. No ContinuationWarrant is emitted.

fails the normative continuity requirement at step 3. The fact that VS-SFL-012 does not spell the exit-side warrant out as a separate terminal assertion is a verification-explicitness issue, not an unresolved semantic choice.

### Source clauses

- `SPEC-SFL-0001` §§7.4, 7.5, 7.6
- `CONTINUITY_TURNOVER_FAMILY.md` VS-SFL-010 and VS-SFL-012

### Closure state

**`ALREADY_RESOLVED_BY_AUTHORITY`.**

A future card may make the exit-only assertion more direct, but no new semantic rule is required to know the correct result.

### Slice-1 impact

**None.** Household continuity is later-slice work.

### Confidence

**High.**

---

## B-005 — Rejoin / re-exit lineage-source selection

### Inherited claim

The Wave-A report argued that a founder can have two `ParticipationEndWarrant` events for the same predecessor, and lineage freshness can change depending on which end-warrant instance is selected as the founder-lineage source.

### Defense / attempted closure through existing ambiguity suppression

Accepted authority comes close to closing this, but not uniquely enough to dismiss the finding.

- SPEC §7.7.1 says each founder-lineage source records founder ID, predecessor Household ID, and the supporting `ParticipationEndWarrant` ID.
- §7.7.1 suppresses lineage when more than one predecessor-set/kind interpretation is equally valid.
- §7.7.2 requires a **relevant** `ParticipationEndWarrant` and suppresses lineage when predecessor-source mapping is ambiguous.
- §7.7.3 defines fresh division evidence relative to all `ParticipationEndWarrant` events **used as lineage sources**.
- VS-SFL-022C directly tests ambiguous founder source, but its stated condition is “more than one predecessor-source mapping”; it does not exercise exit -> rejoin -> exit against the same predecessor.

Reconstruct the smallest trace:

1. C exits H -> PE1.
2. C validly rejoins H.
3. Qualifying person-person support event S occurs.
4. C exits H again -> PE2.
5. C later helps found H2.
6. If PE1 is the cited source, S is post-exit and can be fresh; if PE2 is the cited source, S is pre-exit and cannot be fresh.

The defense route is to say “two possible supporting PE IDs means ambiguous source, therefore no lineage warrant.” That reading is plausible because the source record includes the PE ID. But it is not uniquely compelled: predecessor set and lineage kind are identical, and §7.7.2 phrases the suppression rule as ambiguity in predecessor-source **mapping**. The text never says whether multiple ended-participation instances to the same predecessor automatically count as classifier ambiguity, nor does it select latest/earliest/relevant-by-some-other-rule.

Because the chosen PE ID is itself authoritative warrant provenance and changes the freshness predicate, this cannot be left to arbitrary iteration order or implementation convenience.

### Precise unresolved choice

For one founder with multiple qualifying ended participations in the **same** predecessor before successor formation, accepted authority does not uniquely decide whether the classifier must:

- select a particular end-warrant instance by a deterministic semantic rule; or
- treat multiple qualifying same-predecessor source warrants as ambiguity and withhold lineage.

This return does not choose between them.

### Source clauses

- `SPEC-SFL-0001` §§7.7.1, 7.7.2, 7.7.3
- `LINEAGE_FAMILY.md` VS-SFL-022C
- ASM-0011 (controlled lineage / ambiguous-origin suppression)

### Closure state

**`CONFIRMED_LATER_SLICE_GAP`.**

### Slice-1 impact

**None.** Lineage is causally downstream of household formation, has no independent behavioral power in v0, and is outside Slice 1.

### Confidence

**High-medium.**

---

## Defense conclusion

The cluster does **not** support holding IMP-0001 on formation/lifecycle grounds:

- B-001 survives only as a later candidate-equivalence question; the claimed need for a persistent candidate lifecycle is not established.
- B-003 is a real full-v0 harness semantic gap but can remain disabled for Slice 1.
- B-004 is already normatively resolved by the accepted continuity clauses.
- B-005 is a real but later, behavior-neutral lineage provenance ambiguity.

No fix design is proposed here; this return stops at adjudication as required by Wave B.
