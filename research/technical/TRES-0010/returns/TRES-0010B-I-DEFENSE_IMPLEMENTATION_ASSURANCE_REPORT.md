# TRES-0010B-I-DEFENSE — Implementation Assurance / Handoff Integrity

## Run provenance

- **Task ID:** TRES-0010B-I-DEFENSE
- **Role:** Defense / minimality and existing-guard closure
- **Frozen canonical baseline ref:** tres-0010-wave-b-baseline
- **Resolved baseline SHA:** f25407a9cbf09e501601d52ad7a2df111fa5c491
- **Assigned return branch/workspace:** tres-0010/wb-i-defense
- **Return branch starting SHA:** f25407a9cbf09e501601d52ad7a2df111fa5c491; verified identical to the frozen Wave-B baseline before review
- **Model/configuration:** GPT-5.6 Sol; exact hidden reasoning-effort configuration not exposed
- **Tools used:** GitHub repository connector for branch/ref resolution, bounded file retrieval, and this isolated return write
- **External research:** no
- **Assigned Wave-A reports read:** TRES-0010D_VERIFICATION_CHEAT_REPORT.md; TRES-0010E_IMP0001_HANDOFF_REPORT.md; TRES-0010F_FUTURE_SLICE_COMPATIBILITY_REPORT.md; TRES-0010G_CSHARP_HAZARD_REPORT.md; TRES-0010I_SCOPE_MINIMALITY_REPORT.md; TRES-0010J_RETRIEVAL_GOVERNANCE_REPORT.md
- **Opposing Wave-B return read before completion:** no
- **Unrelated Wave-A returns read:** no
- **Canonical project files modified:** no; this report is the only intended repository mutation

## Scope control

This defense adjudicates only the implementation-assurance findings assigned by the Wave-B README:

- D-001 through D-005;
- E-F01, E-F04, E-F06, E-F07;
- F-F01 through F-F04;
- G implementation hazards, including snapshot aliasing;
- I-F01 through I-F04;
- J-F01 through J-F03.

E-F02, E-F03, and E-F05 are assigned to the Wave-B action/favour cluster and are not adjudicated here. D-006 is outside the Cluster-I finding list and is likewise not adjudicated here.

Inherited Wave-A claims were treated as allegations, not authority. Every disposition below was checked against accepted/canonical artifacts on tres-0010-wave-b-baseline.

## Executive disposition

The implementation-assurance cluster does **not** expose a missing architectural decision, a new social-semantic rule, or an experiment-dependent uncertainty.

No finding in this packet warrants CONFIRMED_BLOCKER_SLICE1, CONFIRMED_LATER_SLICE_GAP, or INCONCLUSIVE_NEEDS_EXPERIMENT.

Four unique pre-dispatch repairs survive defense:

1. **Initial acceptance self-certification:** IMP-0001 creates the first executable acceptance surface itself. SCF-002 and the repository rules prohibit weakening tests once present, but they do not independently prove that the first translation from Stage-3 prose captured the required assertions. A small protected/frozen acceptance manifest or equivalently independent acceptance check is warranted. This closes D-001 without creating a general grader platform.
2. **Open applicability selectors:** IMP-0001 uses relevant/applicable/where-substrate-exists language for cross-cutting verification. The canonical contract defines the relations and allows unexercised findings, but it does not freeze Slice-1 applicability. A bounded Slice-1 verification manifest is warranted. This jointly closes D-005 and E-F06.
3. **Literal Slice-1 scenario-range collision:** IMP-0001 requires VS-SFL-100 through VS-SFL-105 while also excluding household/head semantics; VS-SFL-104 requires an Active Household and valid head. The later sentence saying household cards remain unimplemented reveals the intended scope but does not remove the contradictory minimum. This is a task-wording repair and jointly closes E-F01 and I-F01.
4. **Required-input authority taxonomy:** IMP-0001 currently labels the assumptions register and a working engineering guardrail under an authoritative-input hierarchy even though governance distinguishes accepted authority from required non-authoritative supporting context. This is a task-wording repair for J-F01 only.

The remaining findings are either already uniquely resolved by accepted authority, false positives that import a stronger requirement than the project accepted, or ordinary local C# guards that can be handled without changing architecture.

A single small acceptance manifest can close both the self-certification and applicability problems. No generalized evaluator framework, runtime configuration framework, mutation framework, future household scaffolding, generalized effect system, or hidden-test infrastructure is justified by this review.

## Finding-by-finding adjudication

### D-001 — implementation task can author its own grader

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** verification manifest/protected evaluator  
**Confidence:** high

Independent check:

- IMP-0001 §3.1 assigns the implementation task creation of the canonical SFL acceptance tests and deterministic harness.
- IMP-0001 §6 protects the acceptance surface only once established.
- AGENTS.md forbids weakening acceptance tests/graders/invariants, but the frozen baseline has no pre-existing executable acceptance authority.
- SCF-002 fires on IMP-0001 dispatch and requires independent/protected checks where consequence warrants.
- MASTER_ARCHITECT_GUIDE §11 requires consequential correctness to be externalized and rejects agent confidence as verification.

**Disconfirmation attempted:** SCF-002, Master Architect review, the immutable Stage-3 prose cards, and the task rule against weakening tests substantially reduce the risk. They do not fully close the birth-of-the-grader case: an implementation can initially translate only a subset of a card's assertions while never editing or weakening an existing test.

**Narrowed conclusion:** the Wave-A demand for a large protected grader is unnecessary. The minimum is a frozen/protected Slice-1 acceptance manifest or equivalent independent acceptance check outside the implementation agent's sole control, against which the executable translation is checked.

**Residual risk:** the manifest itself can omit an assertion. That is ordinary review risk, not a reason for a general evaluator platform.

### D-002 — oracle independence is prose rather than a mechanical dependency boundary

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required; CI/dependency guard is optional local hardening  
**Confidence:** high

CROSS_CUTTING_VERIFICATION_CONTRACT §9 explicitly states what independent checkers may share and what they **must not** call, including the production candidate recognizer, decision scorer/selector, target transition helper, or derived-capacity helper when those are under test. REFERENCE_SCORING_PROFILES §3 separately requires the independent oracle to sum recorded components itself rather than call the production scorer.

**Smallest claimed counterexample reconstructed:** production and oracle both call one shared semantic helper and therefore agree on the same defect.

That implementation is not ambiguously permitted; it directly violates the accepted independent-oracle contract. A project/assembly dependency rule may be useful if the chosen code organization makes it cheap, but requiring a new dependency architecture before Slice 1 would confuse enforcement with missing authority.

**Residual risk:** a reviewer can fail to notice an illicit shared helper. That is an enforcement risk already covered by SCF-002/protected verification, not a missing semantic or architectural choice.

### D-003 — profile IDs / target bindings permit overfit or gate bypass

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** medium-high

REFERENCE_SCORING_PROFILES is intentionally a fixed canonical verification configuration. It explicitly says fixture bindings such as GiftTarget or NeedRecipient may not inject candidates or bypass production candidate generation/gates. Its profile-integrity rules say configuration cannot waive categorical gates or create absent action meanings.

**Smallest claimed counterexample reconstructed:** dispatch directly on ProfileId and synthesize the expected decision or target.

A switch or lookup keyed by a canonical profile ID is not itself a semantic defect; pinned profile configuration is permitted. The defect occurs only if the implementation bypasses candidate generation/gates, omits the required component trace, or violates the component-sum scorer, all of which existing authority already forbids. Renaming ProfileId while demanding invariant behavior is not an accepted project requirement.

**Residual risk:** scenario/test IDs must not become production semantic inputs. The protected acceptance review can check that without adding a new metamorphic requirement.

### D-004 — published held-outs are not secret and are not mandatory independent completion evidence

**Result state:** FALSE_POSITIVE  
**Minimum repair level:** none for Slice 1  
**Confidence:** high

CROSS_CUTTING_VERIFICATION_CONTRACT §§7–8 deliberately defines held-out variants as cases not used as the primary implementation narrative; it then publishes concrete recipes and says they may be materialized after the implementation path exists. The accepted contract never defines held-out to mean hidden from the implementer.

SPEC-SFL-0001 §11 requires canonical plus held-out/generated variants in the broader SFL verification program, but it does not impose evaluator secrecy, and IMP-0001 does not make hidden cases a Slice-1 completion criterion.

**Smallest claimed counterexample reconstructed:** special-case every visible canonical and published held-out recipe. That demonstrates why generated/adversarial verification is useful later; it does not show that the accepted use of the word held-out is contradictory or that IMP-0001 needs a secret-test service.

**Residual risk:** visible examples can be overfit. The project already addresses that with metamorphic relations, mutants, generated histories, and later materialization.

### D-005 — applicable cross-cutting checks have no closed Slice-1 map

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** verification manifest/protected evaluator  
**Confidence:** high

CROSS_CUTTING_VERIFICATION_CONTRACT defines nine metamorphic relations and a thirty-mutant ledger, including an explicit unexercised state. IMP-0001 nevertheless asks for applicable/relevant checks without freezing which Slice-1 checks are required versus deferred.

**Disconfirmation attempted:** many applicability decisions are obvious from scope; checkpoint, lineage, and household mutants are plainly later-slice. The contract also supplies applicability conditions and the unexercised category. Those facts narrow the problem substantially but do not prevent the implementer from self-selecting away a difficult in-scope relation such as disconnected-population locality or observer noninterference.

**Narrowed conclusion:** a small Slice-1 manifest marking each relevant cross-cutting item REQUIRED or N/A/deferred with a reason is enough. No mutation-testing framework is required.

**Residual risk:** a wrong applicability judgment can enter the manifest; that is bounded review risk.

### E-F01 — acceptance-card ranges cross explicit Slice-1 scope

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** task wording only  
**Confidence:** high

IMP-0001 §4 excludes Household/head/household-mediated marriage semantics. IMP-0001 §6 nevertheless names VS-SFL-100 through VS-SFL-105 as minimum executable coverage. RESPONSE_DECISION_FAMILY VS-SFL-104 requires an Active Household H, a valid current head P, and a household-mediated marriage proposal.

The later IMP sentence that household cards remain unimplemented and must not be faked is strong evidence of intended scope, but it does not make the literal minimum range internally exact.

**Minimum repair:** make the range explicit at card/subcase level, deferring VS-SFL-104 and any other clearly later-slice subcase rather than relying on an implied exception.

**Residual risk:** very low after wording/manifest closure.

### E-F04 — minimal direct-participant KnownFact substrate is not named in IMP state list

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required; task wording may improve discoverability  
**Confidence:** high

SPEC-SFL-0001 §§6.1, 6.4, and 6.7 uniquely require actor-held factual state/provenance and direct-participant knowledge of Declined, Unable(reason), and InvalidatedAtResolution(reason). IMP-0001 §4 defers only general subjective communication/claim propagation **beyond lower-level state needed for this slice**.

**Smallest claimed counterexample reconstructed:** record a failure only in global semantic history and expose no actor-held knowledge.

That is not a second permissible implementation. It violates the accepted specification. The §3.2 state list is introduced as including named types, not as an exhaustive replacement for the specification.

**Residual risk:** a coder may miss the requirement if reading the packet shallowly. That is retrieval clarity, not a semantic gap.

### E-F06 — verification applicability is self-selected

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** verification manifest/protected evaluator  
**Confidence:** high

This is the same root issue as D-005. The words relevant, applicable, and where substrate is available are legitimate scope tools but should not be the implementation agent's sole completion authority.

One bounded Slice-1 acceptance/applicability manifest closes both findings.

### E-F07 — analyzer strictness and stronger repository protection are not mechanically unique

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** engineering note  
**Confidence:** high

IMP-0001 §8 deliberately leaves the exact analyzer package/configuration local. CSHARP_DOTNET_ENGINEERING_GUARDRAILS requires nullable analysis, analyzers, and important warning/analyzer failures to fail CI. SCF-002 deliberately scales protection to consequence rather than mandating one repository-administration mechanism.

There is no missing simulation or architecture rule here. The implementation only needs to name the selected warning/analyzer policy and the actual acceptance-protection mechanism in completion evidence.

**Residual risk:** two reasonable implementations may choose different strictness. That is permitted local engineering variation unless one allows known important failures to pass.

### F-F01 — Slice-1 behavior may couple to omniscient objective state

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

SPEC-SFL-0001 §5.1 requires ResponseDecisionContext to read the target's subjective state from the common committed snapshot. SPEC §6 distinguishes objective world state from KnownFact/Recognition and makes recognition causally gate later household actions. ADR-0001 requires narrow domain operations instead of storage lookups scattered through behavioral logic. ADR-0004 separates state/query and agency as logical responsibilities.

**Smallest claimed counterexample reconstructed:** personal/response code reads raw WorldState.GetCurrentHead rather than actor-known head state.

Once that information changes behavior, the implementation directly violates accepted semantics. Accepted authority does not require one particular C# actor-view interface, and forcing one now would over-specify local structure.

**Residual risk:** a poor API can make later subjective-state integration costly, but that is ordinary implementation quality subject to escalation if it hardens into a public architectural boundary.

### F-F02 — PersonId can become synonymous with decision/proposal context identity

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** medium-high

SPEC-SFL-0001 already defines ResponseDecisionContext(target, proposal) and later HouseholdDecisionContext(H, head=P), where P retains a separate personal initiative. IMP-0001 §3.7 requires proposer/target/role context in history, and §9 requires escalation if a local representation makes the accepted future path impossible.

A Slice-1 dictionary keyed by PersonId for **personal initiative only** is a reversible internal choice. It becomes wrong only if PersonId is elevated into the universal semantic identity of every decision/proposal origin despite the accepted future contexts.

Requiring generalized role/context infrastructure before a household context exists would violate the project's simplicity policy.

**Residual risk:** avoid freezing PersonId-only source identity into a public/persistent contract. No new framework is warranted.

### F-F03 — pairwise lower-level transitions may force a future multi-contributor resolver rewrite

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** medium-high

SPEC-SFL-0001 §8.1 already defines future household provision as one atomic multi-contributor debit vector. ADR-0004 requires one central validation/resolution/commit responsibility. IMP-0001 explicitly keeps internal proposal/transition structure local while requiring escalation if the chosen representation makes the accepted future path impossible.

**Smallest claimed counterexample reconstructed:** implement every internal Slice-1 effect as source-person + target-person and later discover that household provision needs multiple contributors.

That can be a future refactor without semantic damage so long as the pairwise form was not promoted as a public architectural invariant. The Architecture Development Policy explicitly says to start with the simplest sufficient implementation and avoid stronger machinery until evidence warrants it.

A generalized effect-set framework before Slice 3 would therefore be premature unless the Slice-1 code proves otherwise.

**Residual risk:** moderate refactor cost is possible; no evidence shows an architectural dead end.

### F-F04 — semantic history may be implemented as diagnostic logging only

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

ADR-0004 says consequential commits emit semantic history/provenance as a separate logical responsibility. SPEC-SFL-0001 §9.4 requires consequential history records with IDs, causal predecessors, rule/config version, and direct supporting event references for later warrants. IMP-0001 §3.2 requires explicit semantic transfer/action records, and §3.7 requires causal predecessor references.

**Smallest claimed counterexample reconstructed:** emit only rendered JSON/text logs and keep no stable semantic event records addressable by later rules.

That fails accepted history/provenance requirements; it is not an allowed interpretation.

**Residual risk:** implementation should keep rendered diagnostics distinct from semantic records, but no extra architecture decision is needed.

### G-F01 — C# snapshot aliasing / deferred enumeration

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** engineering note  
**Confidence:** high on project consequence; platform details inherited from assigned G report

ADR-0004 and SPEC-SFL-0001 §5.1 already fix the semantic rule: deliberation and responses read the same committed snapshot and cannot observe later uncommitted/mutated state. IMP-0001 §3.6 repeats read committed snapshot.

The Wave-A G report identifies ordinary C# aliasing/deferred-enumeration ways to violate that rule accidentally. That is a real host-language implementation hazard, not missing architecture.

**Minimum guard:** make snapshot-facing data phase-stable/materialized as needed and add a focused regression that proves an already-created decision/response context cannot observe later legal commit mutations.

**Residual risk:** local API choices can reintroduce aliasing. Keep this in the C# implementation checklist/tests.

### G-F02 — ambient/nondeterministic ID generation

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

ADR-0001 rejects runtime allocation/container identity. IMP-0001 requires a deterministic semantic-ID concrete type, repeated-run identical semantic results/history, and explicit stable-ID fallback evidence. SPEC-SFL-0001 checkpoint semantics also make identifier/order state future-influencing authority.

An implementation whose IDs differ across identical runs is directly noncompliant and should fail the required repeated-run/history evidence.

### G-F03 — record value equality / mutable hash keys can corrupt semantic identity

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** engineering note  
**Confidence:** high

Accepted authority already says semantic identity is stable independent identity, not incidental current record content. The remaining risk is C# API misuse: generated value equality or mutable hash-key state can accidentally implement another rule.

A brief engineering rule to key authoritative entity/history indexes by stable typed IDs and a same-content/different-ID regression is sufficient. No architectural repair is needed.

### G-F04 — collection/sort behavior may become an undeclared tie-break

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

CSHARP_DOTNET_ENGINEERING_GUARDRAILS explicitly says semantic ordering is explicit and collection iteration order must never determine outcomes. IMP-0001 requires nonsemantic input/storage permutation and fallback sensitivity. CROSS_CUTTING_VERIFICATION_CONTRACT has both storage-permutation metamorphism and semantic mutant #21 for collection-order conflict resolution.

This risk is already unusually well fenced.

### G-F05 — culture-sensitive machine-text ordering

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** engineering note  
**Confidence:** medium-high

If the implementation chooses textual IDs/config/action keys for authoritative ordering, environment-sensitive comparison would violate the existing deterministic-order contract. The concrete representation is deliberately local.

Use explicit deterministic/ordinal semantics for machine-defined text if text participates in authoritative equality/order. No broader architecture or test framework is required.

### G-F06 — unchecked integer-score overflow

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** engineering note  
**Confidence:** medium

The accepted Slice-1 profiles use small fixed integer values, so Wave A did not demonstrate a current reachable overflow counterexample under canonical configuration. Still, exact integer scoring should not silently wrap if a configuration is malformed or later widened.

A local checked/validated aggregation rule is sufficient. This does not justify changing the score architecture or blocking on numeric-framework work.

### G-F07 — reflection/deserialization/exception shortcuts bypass invariants/outcomes

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

IMP-0001 requires central proposal/response/resolution/commit, explicit domain failure outcomes, fixture write-set auditing, and always-on invariants. CROSS_CUTTING_VERIFICATION_CONTRACT forbids fixture-writing endogenous results. The C# guardrail note already flags reflection/dynamic/deserialization shortcuts.

A fixture that injects impossible authoritative state without labeling a fault-injection test is simply noncompliant.

### I-F01 — household/head-only VS-SFL-104 is inside the literal Slice-1 minimum

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** task wording only  
**Confidence:** high

This is the same verified scope collision as E-F01. One packet edit/manifest entry closes both.

### I-F02 — the full cross-cutting mutant ledger can be misread as a Slice-1 build requirement

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

CROSS_CUTTING_VERIFICATION_CONTRACT explicitly permits mutant result unexercised. IMP-0001 asks only for applicable/relevant mutants and explicitly excludes household, lineage, checkpoint, and broader-recognition semantics.

**Smallest claimed failure trace reconstructed:** an implementer builds later-slice semantics merely to execute all thirty mutants.

That is a misread of the accepted contract, not a requirement. The D-005/E-F06 applicability manifest will make the already-correct interpretation mechanically obvious, but no separate repair or mutation framework is warranted.

### I-F03 — generated-history/shrinking/held-out tooling is safe to defer from Slice-1 completion

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

CROSS_CUTTING_VERIFICATION_CONTRACT says generated tests supplement canonical cards, shrinking occurs where tooling supports it, and held-out variants may be materialized after the implementation path exists. IMP-0001 does not list a generator, shrinker, or hidden held-out service as a completion criterion.

SPEC-SFL-0001 preserves generated/held-out verification as part of the broader SFL verification program. Deferring tooling breadth is therefore not deleting the obligation.

No generated-testing framework should be pulled into first-code scope merely to satisfy this finding.

### I-F04 — scoring/profile configuration can remain pinned/fixture-local

**Result state:** ALREADY_RESOLVED_BY_AUTHORITY  
**Minimum repair level:** none required  
**Confidence:** high

REFERENCE_SCORING_PROFILES labels itself verification/laboratory configuration rather than independent social semantics. IMP-0001 allows fixture/config serialization choices locally and directs minimal dependencies. The Architecture Development Policy rejects speculative framework generalization.

A general runtime configuration registry, persistence/migration subsystem, or plugin mechanism is not required for Slice 1. The production scorer still must consume the real pinned values and record profile/version as required.

### J-F01 — IMP-0001 conflates accepted authority with required non-authoritative context

**Result state:** CONFIRMED_REPAIR_BEFORE_SLICE1  
**Minimum repair level:** task wording only  
**Confidence:** high

AUTHORITY_AND_DECISION_PROMOTION explicitly distinguishes:

- authority;
- active operational context; and
- required supporting context, including assumptions, engineering guardrails, and verification rules.

IMP-0001 §2 currently places ASSUMPTIONS_REGISTER under Accepted simulation / architecture authority and keeps the working C# guardrail under the parent heading Authoritative inputs.

Higher-level governance lets a careful agent reconstruct the right precedence, so this is not an architectural ambiguity. But a bounded implementation packet should not mislabel its own inputs.

**Minimum repair:** rename/restructure the heading to distinguish accepted authority from required non-authoritative supporting context, with one precedence sentence.

### J-F02 — WORKING_CONSTITUTION filename conflicts with “working artifacts are not authority”

**Result state:** FALSE_POSITIVE  
**Minimum repair level:** none required for IMP-0001  
**Confidence:** high

00_START_HERE explicitly ranks governance/WORKING_CONSTITUTION.md in the authority hierarchy. Opening that file immediately states that it is a constitutional operational summary derived from the Project Seed, with the Seed controlling conflicts.

**Smallest claimed counterexample reconstructed:** a fresh agent sees the word WORKING and skips the file despite the repository's explicit entrypoint telling it that this exact path is authority.

That counterexample requires ignoring the documented retrieval sequence. The filename is imperfect naming hygiene, not an implementation-assurance gap.

### J-F03 — root-command bootstrap timing is one step too early

**Result state:** IMPLEMENTATION_LOCAL_GUARD  
**Minimum repair level:** task wording only  
**Confidence:** medium-high

AGENTS.md says exact root commands should replace the placeholder before persistent implementation begins. IMP-0001 §3.1 makes establishing the solution/commands/CI part of the first implementation task and requires the AGENTS update before completion. SCF-001 fires on IMP-0001 dispatch.

The intended sequence is recoverable: the first-code task begins with tooling/bootstrap, establishes commands, updates the root contract, then proceeds with substantive implementation and must not claim completion first.

A one-line wording cleanup would remove the sequencing hesitation, but it is not a semantic, verification, or architectural blocker.

## Consolidated minimum repair matrix

| Root issue | Challenged findings | Result | Minimum level | Why this is sufficient |
|---|---|---|---|---|
| First executable acceptance surface is self-authored | D-001 | CONFIRMED_REPAIR_BEFORE_SLICE1 | verification manifest/protected evaluator | Independently freezes what must be translated without creating a grading platform |
| Slice-1 cross-cutting applicability is open-ended | D-005, E-F06 | CONFIRMED_REPAIR_BEFORE_SLICE1 | verification manifest/protected evaluator | One REQUIRED/N-A/deferred map prevents selective omission |
| Literal scenario range includes household-only VS-SFL-104 | E-F01, I-F01 | CONFIRMED_REPAIR_BEFORE_SLICE1 | task wording only | Removes a direct packet contradiction without touching semantics |
| Required-input precedence taxonomy is mislabeled | J-F01 | CONFIRMED_REPAIR_BEFORE_SLICE1 | task wording only | Restores governance taxonomy; no authority changes |
| Analyzer/protection mechanism concreteness | E-F07 | IMPLEMENTATION_LOCAL_GUARD | engineering note | Exact tooling remains a local choice; completion evidence names it |
| C# snapshot stability | G-F01 | IMPLEMENTATION_LOCAL_GUARD | engineering note | Local ownership/materialization + focused test enforces already-fixed semantics |
| C# identity/equality discipline | G-F03 | IMPLEMENTATION_LOCAL_GUARD | engineering note | Stable typed ID is already authoritative; guard prevents language convenience from replacing it |
| Machine-text comparison | G-F05 | IMPLEMENTATION_LOCAL_GUARD | engineering note | Only relevant if text participates in authoritative order |
| Integer aggregation bounds | G-F06 | IMPLEMENTATION_LOCAL_GUARD | engineering note | Cheap local robustness; current canonical values are bounded |
| Root command bootstrap phrasing | J-F03 | IMPLEMENTATION_LOCAL_GUARD | task wording only | Clarifies sequencing only |

The first two rows can be satisfied by one bounded protected Slice-1 verification manifest. The local engineering guards may be carried in the implementation checklist/acceptance tests and do not justify a new framework.

## Serious disconfirmation routes attempted

Before confirming the surviving pre-dispatch repairs, this defense attempted the strongest closure routes available in existing authority:

1. **SCF-002 plus AGENTS.md test-protection rules against D-001.** These protect an established acceptance surface but do not independently validate the first translation from prose into executable tests. D-001 therefore survives in narrowed form.
2. **Cross-cutting applicability clauses plus the unexercised mutant state against D-005/E-F06.** They make later-slice exclusions clear but do not close every in-scope applicability judgment. A small manifest still earns its cost.
3. **IMP-0001's sentence that household cards must remain unimplemented against E-F01/I-F01.** It reveals the intended answer but leaves a literal VS-SFL-100..105 minimum that includes VS-SFL-104. A wording repair still survives.
4. **Higher-level authority/navigation policy against J-F01.** It resolves the precedence in principle, but the bounded implementation packet still labels supporting context incorrectly. A one-line taxonomy repair remains justified.

Conversely, before dismissing or localizing findings, the claimed counterexample was reconstructed and checked against accepted authority. The discarded routes either directly violated an existing must/must-not rule, depended on treating a deliberately local implementation choice as permanent architecture, or imported requirements the project never accepted (notably secret held-outs and preemptive generalized frameworks).

## Residual risk after minimum repair

After the four unique pre-dispatch repairs, the principal remaining risk is ordinary implementation quality: a C# agent can still write code that violates an explicit rule. The project already has the correct response to that risk: deterministic acceptance evidence, invariants, protected verification, focused engineering guards, and escalation on semantic/architectural conflict.

The defense found no evidence that additional social semantics, a generalized evaluator service, hidden-test infrastructure, runtime policy/plugin machinery, a mutation-testing platform, or future-slice domain scaffolding would improve the critical path enough to justify their complexity.

## Final defense conclusion

**IMP-0001 does not require architectural redesign.** It requires a narrow handoff hardening before release:

- one protected/frozen Slice-1 acceptance/applicability manifest or equivalent independent acceptance check;
- exact wording that excludes the household-only VS-SFL-104 from Slice 1;
- exact wording that separates accepted authority from required non-authoritative supporting context.

The remaining implementation-assurance findings are already answered by accepted authority or are local guards that can be enforced inside the first implementation task without changing project semantics or architecture.

This return is advisory Wave-B evidence only and does not promote or modify canonical project authority.
