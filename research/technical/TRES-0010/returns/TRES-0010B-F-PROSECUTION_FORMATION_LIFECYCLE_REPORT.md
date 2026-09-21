# TRES-0010B-F-PROSECUTION — Formation / Lifecycle Reachability Adjudication

## Run provenance

- **Task ID / role:** TRES-0010B-F-PROSECUTION / prosecution-falsification
- **Wave:** TRES-0010 Wave B, task 7
- **Frozen canonical baseline:** `tres-0010-wave-b-baseline`
- **Resolved baseline commit:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Return branch/workspace:** `tres-0010/wb-f-prosecution`
- **Model/configuration:** GPT-5.6 Sol
- **Tools used:** GitHub repository connector for branch comparison, commit/file retrieval, and isolated return write
- **External research:** no
- **Assigned Wave-A report read:** `research/technical/TRES-0010/returns/TRES-0010B_SEMANTIC_REACHABILITY_REPORT.md` from `tres-0010/b`
- **Original Wave-A reports otherwise read:** none
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**

## Scope and burden

This return adjudicates only the four formation/lifecycle findings assigned by the Wave-B packet:

- B-001 CandidateOrganization creation/equivalence/retirement;
- B-003 actor departure semantics;
- B-004 exit-side ContinuationWarrant obligation;
- B-005 repeat exit/rejoin lineage-source selection.

For each finding I reconstructed the smallest claimed failure, checked accepted semantic authority and the relevant verification cards on the frozen baseline, and attempted a serious disconfirmation route before assigning a Wave-B result state.

No replacement household semantics are designed here.

## Executive adjudication

| Finding | Wave-B result | Whole-v0 impact | IMP-0001 / Slice-1 impact | Confidence |
|---|---|---|---|---|
| B-001 | **CONFIRMED_LATER_SLICE_GAP** | Household formation is not semantically closed because candidate identity/equivalence/lifecycle is not uniquely defined. | **Does not block Slice 1.** IMP-0001 explicitly excludes CandidateOrganization and household formation. | High |
| B-003 | **CONFIRMED_LATER_SLICE_GAP** | Actor departure is an accepted exogenous input but its world/agency/relation/household consequences are undefined. | **Does not require Slice-1 semantics if explicitly deferred.** Slice-1 canonical lower-level cards do not exercise departure; generated-history departure must be treated as non-applicable to Slice 1 until defined. | High |
| B-004 | **ALREADY_RESOLVED_BY_AUTHORITY** | No accepted-semantic gap. Existing continuity authority already requires a ContinuationWarrant for preserved identity across participation-configuration change. There is still a later verification-hardening opportunity. | No Slice-1 impact; household continuity is explicitly out of scope. | High |
| B-005 | **CONFIRMED_LATER_SLICE_GAP** | Controlled lineage classification is underdetermined for repeated exit/rejoin/re-exit from the same predecessor because the supporting ParticipationEndWarrant instance is not selected uniquely. | No Slice-1 impact; lineage is explicitly out of scope and has no v0 causal power. | High-medium |

**Prosecution bottom line:** none of these four findings independently requires blocking IMP-0001's lower-level Slice 1. B-001, B-003, and B-005 are real whole-v0 gaps that must be closed before the later slices that execute those semantics. B-004 should not be carried forward as a missing semantic rule.

---

## B-001 — CandidateOrganization creation/equivalence/retirement

### Verdict

**CONFIRMED_LATER_SLICE_GAP**

### Inherited Wave-A claim

The assigned TRES-0010B report argued that formation is under-specified because accepted authority defines `CandidateRecognition(C)` and requires all founders to recognize the same candidate, but never defines how a `CandidateOrganization` is created, when two candidate hypotheses are equivalent, or when a successful/stale candidate ceases to be eligible for formation.

### Independently verified accepted authority

1. `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` §6.3:
   - defines `CandidateRecognition(C)` as an ephemeral recognition proposition;
   - requires each founder's own uncontested evidence to establish the formation predicate for the proposed founding core;
   - says candidate existence/label cannot count as evidence for itself.

2. SPEC §7.1:
   - says only that a `CandidateOrganization` “may collect formation evidence” and has no causal authority/resources/actions/self-supporting evidence.

3. SPEC §7.2:
   - requires recognition of the candidate by every required founder;
   - creates a persistent Household plus FormationWarrant after successful formation.

4. `plans/verification/SFL_V0/FORMATION_FAMILY.md`, VS-SFL-001:
   - expects all founders to derive `CandidateRecognition(CandidateABC)`;
   - requires exactly one newly formed H;
   - forbids fixture-writing CandidateRecognition/Household/FormationWarrant/SustainingParticipant;
   - does not specify the semantic rule that makes `CandidateABC` the unique candidate hypothesis.

5. `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`:
   - forbids deriving stable semantic identity casually from mutable content/current participants/runtime positions.

6. `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`:
   - permits derived values to be recomputed/cached/etc., but explicitly preserves their semantic meaning behind a stable query boundary. It chooses maintenance strategy, not candidate equivalence semantics.

7. `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`:
   - requires households to emerge from lower-level social reality rather than a primitive container, but deliberately leaves the concrete household-recognition algorithm unresolved except where later accepted artifacts specify it.

### Minimal counterexample

Take founders A and B with one dwelling, a durable tie, two qualifying support events on distinct cycles, and sufficient subjective evidence for both to recognize the formation predicate.

The accepted artifacts allow materially different implementations:

1. **No candidate constructor:** no `CandidateOrganization` is ever produced, so no `CandidateRecognition(C)` can attach to a subject and formation never fires.
2. **Founding-core-derived candidate:** implementation invents one candidate keyed by {A,B}; formation fires once.
3. **Evidence-bundle-derived candidates:** implementation invents C1 and C2 over the same {A,B} core using different qualifying evidence subsets; both may independently become recognized.
4. Nothing in accepted candidate authority states whether C1/C2 are the same prospective organization, distinct candidates, or one stale/consumed hypothesis after H forms.

The continuity precedence rule in SPEC §7.5 does not close the pre-household equivalence problem. It says one causal evidence bundle cannot simultaneously continue an existing non-Dissolved H and found duplicate H2; it does not define candidate equivalence before a household/continuity interpretation exists.

### Serious disconfirmation attempted

**Route:** treat CandidateOrganization as a purely derived hypothesis, not persistent state, and argue that ADR-0003 makes creation/lifecycle unnecessary.

**Result:** this removes a storage-lifecycle requirement but not the semantic one. A derived query still needs a unique meaning for candidate subject C: which founding core/evidence/time combinations denote the same prospective organization, and which candidate(s) may trigger the “exactly one H” assertion. ADR-0003 explicitly leaves derived semantic meaning unchanged while allowing maintenance strategies to vary. Therefore the ambiguity survives the strongest plausible “candidate is only derived” defense.

### Whole-v0 impact

Real semantic gap. Later household-formation code or oracle logic must invent candidate equivalence/selection/deduplication behavior to execute VS-SFL-001 deterministically.

The gap is narrower than “household formation is impossible”: a developer can invent a coherent local convention. The problem is that multiple materially different conventions are currently consistent with accepted authority.

### Slice-1 impact

None.

`tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` explicitly places all of the following out of scope:

- CandidateOrganization / household formation;
- Household / SustainingParticipant / participation warrants;
- household recognition/head recognition;
- lineage and household-mode semantics.

Slice 1 therefore need not create candidate state, candidate queries, or any household-formation shortcut.

### Safe deferral / exclusion

**Yes, already substantially present.** Keeping CandidateOrganization and formation completely absent from IMP-0001 is a safe Slice-1 deferral. This finding must be re-opened before the first implementation slice that claims VS-SFL-001/002 or household formation.

### Confidence

**High.**

---

## B-003 — Actor departure semantics

### Verdict

**CONFIRMED_LATER_SLICE_GAP**

### Inherited Wave-A claim

The assigned report argued that actor departure is admitted as an executable exogenous input but no accepted semantic rule says what “departed” means for world presence, agency, persistent relations, household participation, head role, provision, or pending proposals.

### Independently verified accepted authority

1. SPEC §1.1 explicitly allows the scenario harness to initialize/inject bounded exogenous events including **actor arrival/departure**.

2. SPEC §2.1 defines stable Person identity and objective state (grain, NeedsGrain, residence, marriage/history, explicit relation references) but does not define a present/absent/in-world/scheduler-active field or transition.

3. SPEC §7.4 separately defines the endogenous `EndHouseholdParticipation(H)` transition and its exact consequences:
   - create `ParticipationEndWarrant`;
   - end only SustainingParticipant;
   - terminate provision commitment;
   - vacate head role if applicable;
   - trigger lifecycle/continuity reevaluation;
   - retain other person-level relations/history.

4. `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` §5 includes **controlled exogenous arrival/departure/resource changes** in the validity-aware generated-history operation vocabulary.

5. The Slice-1 canonical lower-level family (`LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-090 onward) exercises consumption/need/farm, transfers, debt, favour, direct marriage, residence, attitudes, and initiative/response mechanics. It does not require an actor-departure transition.

6. IMP-0001 defines an affirmative lower-level action set and explicitly says it implements enough substrate to execute the lower-level Stage-3 cards rather than all v0 semantics.

### Minimal counterexample

Start with person A who:

- has live debt/favour/person relations;
- can deliberate/respond;
- may also be a sustaining participant/head in a later household-enabled slice.

Inject the allowed exogenous event “A departs.”

Accepted authority does not uniquely answer even the lower-level subset:

- Does A receive a personal activation next cycle?
- Can another actor target A with a request or repayment?
- Does A continue consuming grain?
- Does residence remain unchanged, clear, or become an off-world state?
- Can outstanding proposal responses involving A resolve?
- Do debt/favour/marriage relations stay live, become dormant, or terminate?

For household-enabled slices it additionally does not say whether departure implies participation end, head vacancy, provision termination, or anything else.

### Serious disconfirmation attempted

**Route:** interpret actor departure as a harness/scheduler concern only: the Person record and all domain relations remain, but the harness simply stops activating the actor.

**Result:** that is a coherent implementation convention but not accepted semantics. The cross-cutting contract treats departure as a generated-history operation, and SPEC §1.1 lists it alongside exogenous facts/events that future systems may generate. No authority states that departure is scheduler-only, residence-only, world removal, or a bundle of typed domain transitions. Any of those choices changes later behavior and therefore cannot be inferred as an implementation detail.

### Whole-v0 impact

Real semantic gap wherever actor departure is executable.

Unlike B-001, this gap spans lower-level and household-capable worlds because even lower-level agency/maintenance behavior is undefined after departure.

### Slice-1 impact

**Not a required Slice-1 semantic if explicitly excluded from Slice-1 execution.**

Reasons:

- IMP-0001's required action/transition list does not include arrival/departure.
- Its required canonical lower-level cards do not exercise departure.
- Household consequences are also explicitly outside Slice 1.

There is one scope seam: the cross-cutting verification contract's generated-history vocabulary names actor departure. A Slice-1 implementation must not therefore silently “support” generated departure histories by inventing semantics.

### Safe deferral / exclusion

**Yes.** The Slice-1 gate can remain closed to this gap if task/verification applicability records actor arrival/departure as non-applicable to IMP-0001 generated histories/harness semantics. No replacement departure semantics are needed for Slice 1.

This is a deferral guard, not a proposal for what departure should mean later.

### Confidence

**High.**

---

## B-004 — Exit-side ContinuationWarrant obligation

### Verdict

**ALREADY_RESOLVED_BY_AUTHORITY**

### Inherited Wave-A claim

The assigned report correctly noticed that VS-SFL-012 can be read narrowly as asserting Active -> Inactive -> Active identity/lifecycle without an explicit terminal assertion that B's initial exit produced a new `ContinuationWarrant`. It therefore characterized the exit-side obligation as under-specified/test-light.

### Independently verified accepted authority

The **semantic** obligation is already explicit:

1. SPEC §7.4:
   - `EndHouseholdParticipation(H)` creates a `ParticipationEndWarrant`;
   - participation end “triggers household lifecycle/continuity reevaluation from the remaining sustaining organization.”

2. SPEC §7.5:
   - “Household continuity requires an explicit historical transmission chain”;
   - at least one existing SustainingParticipant must bridge prior/successor configurations;
   - the bridge recognizes the successor as the same household;
   - **a `ContinuationWarrant` links prior state, transition evidence, and successor state**;
   - snapshot similarity or participant overlap alone never preserves identity.

3. SPEC §7.6:
   - lifecycle state (Active/Inactive/Dissolved) is operational only;
   - numerical identity remains grounded in historical warrants.

4. `CONTINUITY_TURNOVER_FAMILY.md`, VS-SFL-010:
   - requires every association change to have provenance;
   - its independent oracle explicitly checks:
     `FormationWarrant -> ParticipationWarrant/ParticipationEnd -> ContinuationWarrant ...`
   - explicitly forbids identity inference from final participant similarity.

5. VS-SFL-012 does omit a standalone “exit ContinuationWarrant exists” bullet for its first B-exit step, but that card does not override the semantic source or family-wide continuity contract.

### Minimal claimed counterexample reconstructed

1. H is Active with A/B.
2. B ends participation.
3. Implementation keeps the same H ID and publishes H Inactive because one participant remains.
4. Implementation emits no `ContinuationWarrant` for the A-bridged successor configuration.
5. VS-SFL-012's narrow listed terminal assertions might still appear to pass.

### Why the counterexample is invalid under accepted authority

Step 3 cannot lawfully preserve H identity solely from participant count/record persistence. SPEC §§7.5-7.6 expressly forbid that: lifecycle count does not ground identity, and preserved identity requires the explicit transmission chain with `ContinuationWarrant`.

Thus the counterexample demonstrates a **test-coverage weakness**, not missing semantics.

### Serious disconfirmation attempted

Here the prosecution obligation was to self-attack the inherited finding by reconstructing exactly the defective implementation Wave A feared. That attack succeeds: existing authority already rejects it before any new rule is invented.

### Whole-v0 impact

No accepted-semantic gap.

There is still a useful later verification-hardening opportunity: make VS-SFL-012 directly assert the exit-side warrant so a narrowly implemented oracle cannot accidentally omit an already-required condition. That is not a new semantic choice and does not justify carrying B-004 as a semantic blocker.

### Slice-1 impact

None. Household participation and continuity are explicitly out of IMP-0001 scope.

### Safe deferral / exclusion

No semantic deferral is needed. The requirement already exists; enforcement belongs with the later household-continuity verification surface.

### Confidence

**High.**

---

## B-005 — Repeat exit/rejoin lineage-source selection

### Verdict

**CONFIRMED_LATER_SLICE_GAP**

### Inherited Wave-A claim

The assigned report argued that a founder who exits H, rejoins H, and later exits H again can have two `ParticipationEndWarrant` instances for the same predecessor. The lineage rules require a “relevant” end warrant and use cited end-warrant time to decide whether lineage evidence is fresh, but they do not uniquely select between same-founder/same-predecessor warrants.

### Independently verified accepted authority

1. SPEC §7.4 allows a former participant to become a SustainingParticipant again so long as they are currently a nonparticipant and satisfy the ordinary bilateral ParticipationWarrant route. No rule forbids re-entry by a former participant.

2. SPEC §7.7.1 requires every founder-lineage source in a `LineageWarrant` to record:
   - founder ID;
   - predecessor Household ID;
   - supporting `ParticipationEndWarrant` ID.

3. SPEC §7.7.2 says:
   - the founder must have a **relevant** `ParticipationEndWarrant` for the claimed predecessor;
   - the warrant records that specific founder -> predecessor source;
   - if histories make the predecessor-source mapping ambiguous for the controlled classifier, no lineage warrant is issued.

4. SPEC §7.7.3 defines division freshness relative to **all ParticipationEndWarrant events used as lineage sources**.

5. `LINEAGE_FAMILY.md`, VS-SFL-020:
   - captures the founders' ParticipationEndWarrants and expects those explicit ended participations to back lineage.

6. VS-SFL-022C suppresses lineage when a founder has overlapping/recent ended predecessor histories such that more than one predecessor-source mapping satisfies the classifier. It does not exercise exit -> rejoin -> exit from the **same** predecessor.

7. SPEC §7.7 makes lineage provenance-only in v0 and explicitly gives it no independent behavioral power.

### Minimal counterexample

1. C is a SustainingParticipant of H.
2. C exits H -> `PE1`.
3. C later validly rejoins the same H.
4. Support event S occurs.
5. C exits H again -> `PE2`.
6. C later helps found H2 and all ordinary H2 formation conditions are satisfied.
7. H remains the candidate predecessor for controlled division lineage.

Now evaluate freshness:

- If the lineage source uses PE1, S occurred after the cited end and can count as fresh.
- If the lineage source uses PE2, S occurred before the cited end and cannot count as fresh.

Both candidate lineage sources point from the same founder C to the same predecessor H. The accepted rules do not say which warrant instance is “relevant.”

### Serious disconfirmation attempted

**Route:** treat SPEC §7.7.2's ambiguity suppression as already covering multiple ParticipationEndWarrants.

**Result:** not enough for a unique answer.

The accepted ambiguity language is framed as **predecessor-source mapping** ambiguity, and §7.7.1 separately suppresses when more than one predecessor-set/kind interpretation is valid. In this trace:

- predecessor set is still {H};
- lineage kind is still DivisionDescendant;
- founder -> predecessor mapping is still C -> H.

What differs is the supporting `ParticipationEndWarrant` instance, and that exact instance changes the §7.7.3 freshness result. The spec does not state that multiple same-predecessor end-warrant instances automatically count as ambiguous, nor does it state a deterministic selection rule. A conforming implementation must therefore invent one of those choices.

### Whole-v0 impact

Real but narrow semantic gap in controlled lineage classification/provenance.

It does **not** threaten current v0 behavior because lineage has no independent causal power; it threatens deterministic classification, warrant contents, and verification agreement.

### Slice-1 impact

None.

IMP-0001 explicitly excludes:

- Household/SustainingParticipant/participation warrants;
- household lineage/division/consolidation.

### Safe deferral / exclusion

**Yes, already explicit.** No lineage classifier or lineage warrant belongs in Slice 1. Re-open this gap before the later slice that implements controlled lineage or claims VS-SFL-020..026.

### Confidence

**High-medium.** The only plausible closing interpretation is to read “predecessor-source mapping ambiguous” broadly enough to include supporting warrant-instance ambiguity. The accepted wording and current cards do not make that reading uniquely binding, so the prosecution burden is met.

---

## Cross-finding Slice-1 gate assessment

### What IMP-0001 can safely implement without resolving these findings

IMP-0001 can remain a lower-level kernel implementing its enumerated:

- person/dwelling/lower-level relation state;
- maintenance/time;
- lower-level personal and response agency;
- gift/help/loan/repay/favour/direct-marriage/residence transitions;
- resolution/revalidation/commit/reaction/history.

It must continue to avoid:

- CandidateOrganization or household-formation helpers;
- Household/SustainingParticipant/warrant state;
- continuity/lifecycle logic;
- lineage classifiers;
- hidden household membership “for later convenience.”

### One explicit applicability guard still needed for clean dispatch

Because the cross-cutting generated-history vocabulary includes controlled exogenous actor arrival/departure, the Master Architect should record that **actor departure histories are non-applicable to IMP-0001** unless/until departure semantics are separately accepted.

This does not require deciding what departure means. It only prevents Slice 1 from silently inventing that meaning.

### Prosecution disposition to the Master Architect

- Carry **B-001**, **B-003**, and **B-005** forward as confirmed **later-slice semantic gaps**.
- Do **not** carry **B-004** forward as a missing semantic rule; treat any follow-up as verification hardening of already-accepted authority.
- None of these four findings, as bounded above, independently requires reopening the lower-level semantics that IMP-0001 actually implements.
