# SFL v0 Slice 2 — Acceptance Applicability Pre-Code Review

**Status:** RETURN / **BLOCK**  
**Review authority:** read-only pre-code acceptance review  
**Reviewed candidate:** \`plans/verification/SFL_V0/SLICE2_ACCEPTANCE_APPLICABILITY_CANDIDATE.md\`  
**Reviewed candidate commit:** \`60df1089f9ad03eeccc361215e033aa6fde174fd\`  
**Reviewed candidate blob:** \`cc9ec48fc844645bcf8b7c44cc3660074b512245\`  
**Review branch:** \`review/sfl-v0-slice2-acceptance-precode-return\`  
**Implementation authority exercised:** none  
**Semantic promotion authority exercised:** none

## 1. Judgment

**BLOCK.**

The candidate is substantially subordinate to accepted SFL semantics and correctly keeps Household identity/lifecycle, head/representative office, mediated marriage, provision, lineage, checkpoint/restore, generic perception, trust, rumor, reputation, and richer agency outside Slice 2.

The block is narrower: the acceptance authority is not yet omission-detectable enough to prevent an implementation from self-selecting easier evidence while missing accepted Slice-2 semantics. The blocking defects are candidate/verification-authority defects, not demonstrated gaps in accepted social semantics.

### Review gates

- **RG-01 — Contested Recognition:** **SUPPORTED ONLY WITH CANDIDATE REPAIR.**
- **RG-02 — observation:** **SUPPORTED / no observation escalation required**, provided the RG-01 repair below is used and the required rows are witnessed through direct acquisition/participation, communication, or declared non-result-writing epistemic starting state.
- **Director-level semantic authority required now:** **NO.**
- **Conditional Director escalation:** only if the repaired candidate cannot instantiate the accepted RG-01 witness without inventing a new recognition proposition meaning, a general contradiction/evidence-strength algebra, or an event-specific observation rule.

The candidate **must not freeze at the reviewed blob**.

## 2. Exact source set reviewed

All sources were retrieved at candidate commit \`60df1089f9ad03eeccc361215e033aa6fde174fd\` unless noted.

| Source | Blob |
|---|---|
| \`AGENTS.md\` | \`ee9f27664b912e07eb0a8fedc819a6f5a05ed257\` |
| \`00_START_HERE.md\` | \`cf11d0ce07b72fbe97577575d419df8f3e3a8ccf\` |
| \`specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md\` | \`a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52\` |
| \`architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md\` | \`66cfd55f8b960ff5664638c41c0e731257902be5\` |
| \`architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md\` | \`aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229\` |
| \`architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md\` | \`43eedd7eb49e1eae035010332883ed2d8726d451\` |
| \`plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md\` | \`d8f87dea9569d41481850c7327a025c44d6c3358\` |
| \`plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md\` | \`efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766\` |
| \`research/technical/SFL_V0_SLICE2_AUTHORITY_INVENTORY.md\` | \`a6f0bc8e6369b4cd854b42cf2042dc1052ec5b4d\` |
| \`research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md\` | \`40fdeaf2e8be7b5321a5d16662c5706d4a917a32\` |
| \`research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md\` | \`3c15cb411fd08c5bfc64670cda47bf0b0b91efd6\` |
| \`research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md\` | \`f6a6ffef1368836545e75aaa30ef77a0274538ef\` |
| reviewed candidate | \`cc9ec48fc844645bcf8b7c44cc3660074b512245\` |

I also checked \`plans/CURRENT_PHASE.md\` and the deferred-gap ledger only as repository planning/trigger context. No conceptual tablet material was used as semantic authority.

## 3. Independent semantic re-derivation

Accepted authority fixes the following relevant distinctions.

1. **Objective truth is not actor knowledge.** Current typed execution state is authoritative engine truth; actor subjective state is separate.
2. **KnownFact** is an actor-held factual proposition with provenance. The accepted specification does not give KnownFact a universal \`Unknown / Recognized / Contested\` algebra.
3. **Recognition** is a provenance-bearing social interpretation of a collective/authority proposition and is explicitly distinct from factual knowledge, scalar confidence, attitude, approval, and obedience.
4. Recognition has \`Unknown / Recognized / Contested\`. Unresolved incompatible evidence that accepted provenance/order rules do not resolve becomes \`Contested\`, not an arbitrary winner.
5. \`CandidateRecognition(C)\` is an accepted, **ephemeral**, provenance-bearing pre-Household recognition proposition. It grants no Household power, is not Household identity, and the candidate label cannot count as evidence for itself.
6. Automatic acquisition covers own objective state, direct-party relations/claims, and directly participated proposals/events. Other acquisition requires valid event-specific observation or communication; co-residence is not omniscience.
7. \`CommunicateClaim/Inform\` may transmit a **factual or recognition proposition** the sender currently holds, retaining sender and underlying source/event provenance where available. It normally consumes the sender's voluntary personal initiative.
8. Subjective state does not passively synchronize. Underlying semantic event/observation order outranks message arrival; newer accepted direct evidence and newer event-backed reports have only the precedence that SPEC explicitly grants. There is no accepted universal evidence-strength total order.
9. Recognition does not decay merely with attitude. Dislike/refusal is not nonrecognition.
10. ADR-0002 requires inaccessible candidates to be excluded before scoring. SPEC preserves authoritative commit-time revalidation and complete traces of relevant subjective inputs.
11. ADR-0004 keeps stable closure, iteration/container order, caches, and technical identifiers from silently becoming semantic authority.

The candidate is generally aligned with those rules. The defects below are places where its REQUIRED rows are incomplete, over-broad, or insufficiently bound to evidence.

## 4. RG-01 — Contested Recognition

### Classification

**SUPPORTED ONLY WITH CANDIDATE REPAIR.**

Accepted authority supplies the needed semantic chain:

\`Recognition.Contested\`  
→ incompatible evidence prevents safe reliance  
→ provenance/order is used where accepted  
→ unresolved incompatibility becomes \`Contested\` rather than selecting one claim  
→ \`CandidateRecognition(C)\` is already an accepted Slice-2-addressable Recognition proposition  
→ communication can carry proposition/evidence provenance  
→ no Household/head/office identity is required merely to represent the Recognition state.

The old \`VS-SFL-033\` fixture is not itself usable as written because its continuity/authority transition is later-slice-shaped. Its verification principle is valid, but Slice 2 needs a bounded replacement.

### Safe executable witness boundary

The candidate should normatively pin the following boundary before freeze.

- Use **one and only one** inert pre-Household referent \`C\` for an accepted \`CandidateRecognition(C)\` proposition.
- Do **not** create a persistent Household, HouseholdHeadRole, succession, mediated marriage, FormationWarrant, or household action.
- Do **not** create/reconcile multiple candidate labels and do not exercise candidate-equivalence/convergence; that would trigger the separately deferred \`LATER-01\` question.
- \`C\` is only the referent of the accepted Recognition proposition. Its label/identity is never evidence for its own recognition.
- Hold the rest of the candidate-formation evidence fixed and uncontested. Use an already accepted lower-level functional fact, such as the person→dwelling Residence fact, to supply the incompatible evidence dimension.
- Establish two provenance-bearing actor-held reports/evidence bundles about that same lower-level fact that are incompatible but **not ordered by any precedence relation already fixed by SPEC**. The candidate must declare the exact bounded provenance shape; the implementation may not invent a general evidence-strength rule to manufacture or resolve the tie.
- Those actor-held starting reports may be controlled epistemic fixture inputs because this row is not claiming to prove their acquisition. They must be tagged as fixture-originated and must not write the recipient's final Recognition state.
- Transmit the evidence through ordinary \`CommunicateClaim/Inform\`, or otherwise feed it through the candidate's accepted non-result-writing epistemic ingress. The recipient's production Recognition update must derive \`Contested\`.
- Advance at least one stable cycle with no accepted displacing evidence while \`C\` remains within its valid pre-Household lifetime. \`Contested\` must remain retained during that interval.
- Repeat metamorphically with sender order, delivery order, and nonsemantic ID renaming permuted. The result remains \`Contested\`.
- The independent oracle compares public/read-only Recognition state and provenance. It must not call the production Recognition conflict-resolution or evidence-precedence helper under judgment.

This proves only the accepted Recognition conflict law. It does **not** prove CandidateOrganization identity/equivalence, formation, Household authority, or a universal KnownFact conflict algebra.

### Required RG-01 candidate repair

Replace the current preferred-route sentence with a frozen witness contract at least as specific as the boundary above, including its fixture write set and independent oracle basis.

Also narrow the word **persistent**. \`CandidateRecognition(C)\` is explicitly ephemeral in SPEC. The required claim is retention of \`Contested\` across stable cycles **while the same pre-Household recognition proposition remains live and no accepted evidence displaces it**. The candidate must not imply perpetual persistence of CandidateRecognition beyond its accepted lifetime.

If no concrete pair of valid, incomparable evidence bundles can be specified without adding a new evidence-strength/contradiction rule, then RG-01 changes from this classification to **NOT SUPPORTED** and requires semantic escalation. Nothing reviewed demonstrates that escalation is currently necessary.

## 5. RG-02 — observation

### Classification

**SUPPORTED / no observation semantic gap is required for current Slice-2 completion.**

All required behavior can be evidenced without generic nonparticipant perception:

- own-state/direct-claim/direct-participation acquisition rows use their accepted automatic routes;
- communication rows use explicit sender-held state and ordinary communication;
- stale-state rows can first communicate a lower-level fact to X, then change objective truth through an event in which X is not a participant and send no update to X;
- late-old/newer-evidence rows can use direct participation for the newer evidence and communication for the older report;
- conflict/Contested uses the repaired RG-01 controlled epistemic/communication witness;
- inspection/determinism/cache rows are structural or metamorphic;
- non-acquisition-specific rows may use declared starting epistemic state without writing the result being tested.

Therefore no REQUIRED row needs an unspecified "nearby observer sees event" rule.

**Repair:** keep \`S2-D01-GENERAL-NONPARTICIPANT-OBSERVATION\` deferred and state in the evidence matrix that no REQUIRED witness may use nonparticipant observation unless an event-specific rule is separately accepted.

## 6. Blocking missing / under-specified completion rows

### 6.1 Recognition communication is not omission-detectable

SPEC explicitly permits \`CommunicateClaim/Inform\` to transmit a **factual or recognition proposition**. Candidate prose says this too, but the REQUIRED rows can all pass without ever communicating Recognition:

- \`S2-021\` requires only a **factual** proposition;
- \`S2-023\` requires provenance only for a communicated **fact**;
- \`S2-040\` can be satisfied entirely by KnownFact-based communication candidate availability.

That leaves an implementation free to implement factual communication while leaving Recognition noncommunicable or behaviorally decorative.

**Required verification-authority repair:**

- make communication of a held **Recognition proposition** an explicit mandatory subcase, not an optional representation;
- make communicated-Recognition provenance explicit;
- make no-invention apply to factual **and** Recognition propositions;
- require at least one Recognition-based subjective candidate-availability witness, using the RG-01-safe \`CandidateRecognition(C)\` boundary, in addition to a KnownFact-based witness;
- require \`S2-042\` to record the actual Recognition/provenance basis for that causal subcase.

No new social meaning is needed.

### 6.2 Accepted Recognition-vs-attitude/compliance independence is absent

SPEC explicitly says Recognition does not decay with attitude, and the canonical verification family includes this as a family invariant / \`VS-SFL-035\`. The trigger map warns that the old Household/head-shaped card cannot simply be pulled forward; it does **not** authorize omission of the accepted lower-level distinction.

The current candidate has no REQUIRED row that would detect an implementation that erases or changes Recognition solely because attitude becomes negative or an otherwise independent request is refused.

**Required verification-authority repair:**

Add an explicit Slice-2 REQUIRED row stating that, with Recognition evidence/referent held fixed, changing an unrelated attitude/compliance input does not by itself change Recognition. Use a Slice-2-valid \`CandidateRecognition(C)\` or structural/metamorphic witness; do not instantiate Household/head mechanics.

Also strengthen \`S2-004\` so the checked distinction includes scalar confidence, approval, and obedience, not only separate inspectability from KnownFact/Attitude/objective state.

### 6.3 Evidence-order rows permit self-selection of the easier accepted relation

Candidate §6 accurately lists multiple accepted precedence relations, but \`S2-031/032\` do not force all Slice-2-relevant ones to be exercised. An implementation could demonstrate only arrival-order independence while omitting direct-evidence precedence or report-vs-report precedence.

**Required verification-authority repair:** freeze explicit mandatory subcases:

1. a newer **direct-participation** fact/evidence item is not overwritten by a later-delivered older incompatible report;
2. where SPEC's event-backed report precedence applies, a newer event-backed communication supersedes an older report independently of arrival order;
3. delivery-order permutation with underlying semantic evidence order fixed preserves the accepted final result.

Do not require nonparticipant observation. Do not generalize these into a universal evidence algebra.

### 6.4 Recognition persistence wording overclaims CandidateRecognition

Candidate §3 requires "persistent Recognition state" and \`S2-005\` says all three states are "representable persistent Recognition states." That is too broad when the only Slice-2-native recognition proposition proposed for RG-01 is explicitly **ephemeral** \`CandidateRecognition(C)\`.

**Required verification-authority repair:** use lifetime-scoped wording: actor-specific Recognition state must be retained across stable cycles while the relevant accepted proposition/referent remains live and until accepted evidence changes it. Preserve the explicit ephemerality of CandidateRecognition.

### 6.5 Communication initiative wording should preserve SPEC's scope

SPEC says communication **normally** consumes one voluntary personal initiative. Candidate prose narrows this appropriately to successful ordinary initiation, but \`S2-024\` reads as an unconditional universal statement.

**Required verification-authority repair:** scope the row to a successful ordinary Slice-2 \`CommunicateClaim/Inform\` initiation under the pinned laboratory action path. Do not turn "normally" into a broader social rule.

### 6.6 Communication receipt must not silently create a response context

Candidate prose says communication "does not create a response initiative," but \`S2-026\` only forbids a fresh same-cycle **personal** initiative/decision snapshot. The row does not detect an implementation that wrongly manufactures a response decision context merely because a message was received.

**Required verification-authority repair:** expand \`S2-026\` so communication receipt by itself creates neither a fresh same-cycle personal voluntary activation nor a response decision context unless a separately accepted action meaning requires one.

### 6.7 Regression protection is categorical rather than exact

The trigger map identifies exact already-passed Slice-1 contracts made consequential by Slice 2. Candidate §7H gives only prose categories. That permits an implementation/completion report to choose a convenient subset.

**Required verification-authority repair:** bind the regression section to the exact frozen IDs at minimum:

- \`S1-070\`, \`S1-GLOBAL-KNOWLEDGE\`;
- \`S1-073\`;
- \`S1-098-CORE\`, \`S1-105\`;
- \`S1-085\`, \`S1-META-04\`, \`S1-MUT-26\`;
- \`S1-086\`, \`S1-MUT-29\`;
- \`S1-META-07\`;
- \`S1-084\`, \`S1-META-05\`, \`S1-MUT-24\`;
- \`S1-META-03\`;
- \`S1-META-02\`, \`S1-GLOBAL-FALLBACK\`;
- frozen-manifest integrity.

This is a reference to existing frozen authority, not a reclassification of it.

## 7. Fixture discipline

The candidate's global fixture principles are directionally correct, especially:

- no recipient postcondition write for communication;
- no final Recognition write for conflict derivation;
- no fake Household/head/office state;
- declared starting epistemic state only when the row is not proving acquisition;
- every executable row declares a write set.

The remaining defect is that the candidate does not itself bind those write sets per REQUIRED row. Because fixture ingress is the main place an acceptance implementation could accidentally write the answer, a generic promise is not strong enough for freeze.

**Required repair:** add or normatively bind a per-row fixture matrix before freeze. At minimum it must state:

| Row family | Allowed pre-state | Forbidden result write |
|---|---|---|
| acquisition | ordinary objective setup; unrelated epistemic state | the specific KnownFact/Recognition acquisition being claimed |
| communication | sender-held proposition/provenance; recipient absent | recipient's communicated postcondition |
| stale/persistence | starting actor-held fact allowed when acquisition is not under test | stale retained postcondition or corrective update |
| RG-01 | sender/evidence starting state only, exact single-C boundary | recipient final \`Contested\`, Household/head/formation result |
| candidate gating/trace | declared held/absent subjective inputs | production candidate set, chosen action, or trace output |
| metamorphic/read-only | baseline state plus the one declared perturbation | hidden semantic changes between paired runs |

The acceptance completion output should expose the resolved per-row write set so a fresh reviewer can audit it.

## 8. Oracle independence

The candidate's §10 prohibition against production helpers grading their own proposition availability, communication candidate generation, Recognition conflict resolution, evidence precedence, subjective gating, and cache classification is sound.

No semantic blocker was found here. The under-specification is row-level binding.

**Required repair:** for every REQUIRED executable row, record:

- the independent \`OracleBasis\`;
- the production helper/classifier output forbidden to the checker where applicable;
- the public state/history/provenance evidence used;
- any metamorphic relation used instead of full recomputation.

For RG-01 specifically, the oracle may compare public Recognition/provenance and paired-run equality; it may not call the production conflict resolver or precedence helper.

## 9. Later-slice leakage audit

**PASS on boundary intent, subject to the RG-01 repair.**

No candidate REQUIRED row inherently requires:

- persistent Household identity/lifecycle;
- head/representative office occupancy or succession;
- mediated marriage;
- Household provision;
- lineage;
- checkpoint/restore.

Those remain explicitly deferred.

The repaired RG-01 witness must also avoid \`LATER-01\`: do not create/reconcile multiple CandidateOrganization labels/evidence paths. A single inert \`C\` referent for the already accepted \`CandidateRecognition(C)\` proposition is the safe boundary.

No trust, lying, rumor, reputation, brokerage, rich-memory, role-salience, multi-step planning, stochastic choice, universal proposition ontology, or universal evidence algebra is required by these repairs.

## 10. Autonomous communication

**Candidate position is adequate.**

The accepted action meaning, held-proposition constraint, provenance, and ordinary initiative cost are semantic. The rule for socially meaningful autonomous choice of when/whom/what to tell is not fixed.

Pinned laboratory policy may select communication action/recipient/proposition for acceptance evidence, provided:

- the policy cannot bypass sender-held-state eligibility;
- numeric coefficients are reported as test configuration, not social semantics;
- the resulting candidate still enters the normal personal-action pipeline;
- objective validity/revalidation and initiative accounting remain authoritative.

No Director decision is needed unless the project changes Slice-2 scope to demand historically meaningful autonomous communication motivation.

## 11. Broad/global wording audit

The following wording needs bounded evidence discipline.

- **\`S2-003\` "Every completion-relevant KnownFact":** acceptance evidence should enumerate the candidate's bounded completion proposition categories rather than sample one and infer universal coverage.
- **\`S2-051\` deterministic replay:** define equality over the same declared initial objective/epistemic state, rule/configuration, exogenous inputs, communication schedule, and deterministic randomness boundary/seed. Compare bounded authoritative objective state, subjective state, and semantic history.
- **\`S2-052\` iteration invariance:** use explicit metamorphic permutations of nonsemantic collection/input order; do not claim arbitrary global permutation.
- **\`S2-053\` ID renaming:** use consistent isomorphic renaming of nonsemantic IDs. Do not interpret arbitrary inconsistent ID substitution as a semantic invariant.
- **\`S2-054\` cache nonauthority:** if no behavior-affecting cache exists, structural absence is valid; if one exists, require stale/rebuild metamorphic evidence rather than a blanket assertion.
- **"persistent Recognition":** scope to the accepted proposition lifetime as described above.
- **communication "consumes":** preserve the accepted ordinary/successful initiation scope rather than broadening "normally" into a universal rule.

These are verification-strength repairs, not new semantics.

## 12. Candidate repair set required before freeze

A repair candidate can remain within existing authority if it does all of the following:

1. Freeze the exact RG-01 single-\`CandidateRecognition(C)\` witness boundary and its fixture/oracle rules.
2. Make Recognition communication/provenance/no-invention a mandatory completion subcase.
3. Require a Recognition-based subjective candidate-availability + trace witness, not only KnownFact gating.
4. Add Recognition independence from attitude/compliance as explicit Slice-2 completion coverage.
5. Split/pin evidence-order subcases so direct-evidence precedence and event-backed report precedence cannot be silently omitted.
6. Scope Recognition persistence to proposition lifetime and communication initiative cost to ordinary successful initiation.
7. Make receipt-no-reactivation cover both fresh personal activation and invented response context.
8. Bind regression protection to the exact frozen Slice-1 IDs listed above.
9. Add/bind per-row fixture write sets and per-row independent oracle bases/forbidden helpers.
10. Tighten global wording with bounded enumeration or metamorphic evidence as described above.
11. Keep general nonparticipant observation, general KnownFact conflict algebra, universal evidence ordering, Household/head/formation execution, and checkpoint/restore deferred.

None of these repairs changes what a proposition means, who may know it, or which accepted evidence outranks which. They make the completion authority harder to game.

## 13. Director semantic escalation

**No Director-level semantic decision is currently required.**

The reviewed source chain is sufficient to define a bounded Slice-2 completion authority after the verification repairs above.

Escalate only if a repaired RG-01 fixture cannot produce a valid incomparable evidence pair without inventing one of the following:

- a new negative/opposite Recognition proposition not already accepted;
- a new CandidateOrganization identity/equivalence rule;
- a universal contradiction/proposition ontology;
- a new evidence-strength precedence rule;
- a nonparticipant observation eligibility rule.

That would be a genuine semantic distinction. The current candidate does not yet demonstrate such a need.

## 14. Final disposition

**BLOCK the reviewed candidate from freeze and implementation dispatch.**

This is a **candidate-repair block**, not a reopening of accepted SFL semantics.

After the repairs are authored, the repaired candidate should receive a fresh independent pre-code review against its exact new commit/blob before any freeze or implementation packet is authorized.
