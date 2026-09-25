# SFL v0 Slice 5 — Fresh Independent Acceptance Candidate2 Pre-Code Review

**Review role:** fresh independent acceptance reviewer  
**Review date:** 2026-09-25  
**Review type:** whole-candidate pre-code acceptance review  
**Authority:** advisory review only; this report creates no simulation semantics and does not itself freeze or authorize implementation  
**Exact candidate ref:** sfl-v0-slice5-acceptance-v1-candidate2  
**Exact candidate commit:** 946e95f87721d4c84af10a81e261ddc5fce77636  
**Manifest:** plans/verification/SFL_V0/SLICE5_ACCEPTANCE_MANIFEST_CANDIDATE2.md  
**Manifest blob:** 948118a655e002b4af0929e6c563a90608fb9456  
**Candidate version:** SFL-V0-S5-ACCEPTANCE-v1-candidate2

# Final verdict

## PASS — MAY FREEZE UNCHANGED

Candidate2 is mechanically exact, complete for the bounded Slice-5 checkpoint/continuation authority visible in the promoted kernel, omission-detectable, and semantically subordinate to accepted SPEC/ADR/decision authority through DEC-0015.

The DEC-0015 refresh is correctly bounded. Candidate2 changes the historical Candidate1 surface only where current authority requires it: the inherited REQUIRED census moves from 435 to 441 and one native Slice-5 witness is added for valid diagonal Attitude continuation. The candidate neither weakens Candidate1 nor imports new self-relation, workflow, migration, event-sourcing, economy, or institutional semantics.

A concrete DEC-0015-adjacent implementation seam exists in the current pinned kernel: fixture-proposition validation inside EpistemicState still contains a generic distinct-person helper used for AttitudeFact validation, even though WorldState correctly permits Attitude(P,P). This does not create a Candidate2 wording defect. Runtime direct-fact acquisition can produce the valid diagonal AttitudeFact, and Candidate2's S5-021 together with S5-011, exact continuation, runtime-produced-fixture, and omission/oracle requirements is strong enough to catch a checkpoint/restore path that filters or rejects the valid diagonal merely because endpoints are equal. The seam is therefore a concrete implementation challenge already covered by the candidate, not a new semantic decision.

## 1. Review basis and discipline

I reviewed Candidate2 as a whole rather than treating the DEC-0015 refresh as a patch-only exercise.

The controlling corpus checked at the exact candidate commit included:

- accepted SPEC-SFL-0001, especially relation endpoint identity, subjective-information acquisition, stable-cycle publication, and checkpoint/continuation rules;
- accepted ADR-0004 reference-kernel authority;
- accepted DEC-0014 provision-reconsideration historical context;
- accepted DEC-0015 relation-diagonal and self-alias semantics plus its promotion reconciliation;
- frozen Slice-1 successor v2, Slice-2 v1, Slice-3 v1, and Slice-4 v2 manifests;
- the Slice-1 successor-v2 DEC-0015 final completion/promotion record;
- Slice-5 discovery A/B/C returns and the preimplementation reconciliation;
- the DEC-0015 inherited-authority refresh reconciliation;
- representative current implementation surfaces that own future-causal state, generated-ID frontiers, history, scheduled input, and structural-authority audits.

Candidate1 and its R2 review were used only after independent checks as historical corroboration. Candidate1's old inherited authority was not treated as current authority.

## 2. Exact identity and native census result

### 2.1 Candidate identity

The exact candidate ref resolves to:

946e95f87721d4c84af10a81e261ddc5fce77636

At that commit, the Candidate2 manifest blob is exactly:

948118a655e002b4af0929e6c563a90608fb9456

Both match the dispatch.

### 2.2 Native Slice-5 census

Mechanical parsing of status-bearing native Slice-5 rows gives exactly:

- 96 total status-bearing AcceptanceIds;
- 96 unique AcceptanceIds;
- 82 REQUIRED;
- 12 DEFERRED;
- 2 UNEXERCISED;
- 0 duplicate AcceptanceIds.

The candidate self-census and dispatch therefore match the actual manifest.

### 2.3 Frozen inherited identities

The current frozen refs and manifest blobs checked are:

| Authority | Frozen ref target | Manifest blob | REQUIRED |
|---|---|---|---:|
| Slice 1 successor v2 | bf77bb38a8a7bc964159188b7359cb8e9af2b483 | 174ccbae57a64f06bd88de233b11a011b4a2b115 | 134 |
| Slice 2 v1 | 88f876298852553d6afca76e743a5a811ff9f0fd | e4872531cf780d51fa1863f2a0b87e2424a71b69 | 46 |
| Slice 3 v1 | 25160f33c994fd5f3e277ae98f03e55d37c878dd | 1aae13dc27572361fe99c31ef8aee0444d39364a | 96 |
| Slice 4 successor v2 | 66fe54c385f42eeb01308f19b63fff7c670b9bbe | b0bc79e46f82630ab78cd2f0d0414b748212a411 | 165 |

No inherited identity drift was found.

## 3. Candidate1 lineage and exact delta result

Historical Candidate1 resolves exactly to commit:

1dcfdac9a27679496b1484d5bf183a3f77ba9afc

Its manifest blob is exactly:

97b53dcc6f0e03b7c405b79e6fbc1c885662f8ea

Mechanical comparison of Candidate1's 95 native status-bearing rows with Candidate2's 96 rows establishes:

- every Candidate1 Slice-5 AcceptanceId remains present;
- 94 Candidate1 rows are byte-for-byte unchanged;
- exactly one existing row changes: S5-R00-ALL-PRIOR-REQUIRED;
- that row changes solely from 128 + 46 + 96 + 165 = 435 to 134 + 46 + 96 + 165 = 441;
- exactly one new native row exists: S5-021-DEC0015-DIAGONAL-ATTITUDE-CONTINUATION;
- no Candidate1 REQUIRED obligation is dropped, weakened, or reclassified.

This is the exact lineage shape required by the dispatch.

## 4. Exact inherited expansion result

I mechanically compared each Candidate2 inherited subsection against the REQUIRED rows in the corresponding exact frozen lower-slice manifest.

Results:

- Slice 1 v2: 134 / 134 REQUIRED, 0 missing, 0 extra, 0 duplicate;
- Slice 2 v1: 46 / 46 REQUIRED, 0 missing, 0 extra, 0 duplicate;
- Slice 3 v1: 96 / 96 REQUIRED, 0 missing, 0 extra, 0 duplicate;
- Slice 4 v2: 165 / 165 REQUIRED, 0 missing, 0 extra, 0 duplicate;
- total: 441 / 441.

The six DEC-0015 Slice-1 successor additions are all present exactly:

- S1-107-SELF-COUNTERPARTY;
- S1-107-ATTITUDE-DIAGONAL;
- S1-107-DEBT-DIAGONAL;
- S1-107-FAVOUR-DIAGONAL;
- S1-107-VALID-ALIAS-CONTROLS;
- S1-107-GENERIC-RELATION-SEAM.

Because the appendix is exact set equality against the lower frozen REQUIRED sets, no lower-slice DEFERRED, N-A, or UNEXERCISED row is promoted through the inherited expansion.

## 5. DEC-0015 checkpoint intersection result

S5-021 is necessary, sufficient for the bounded checkpoint intersection, and semantically subordinate.

### 5.1 Necessity

S5-010 already says that all Attitudes continue exactly, but that aggregate obligation does not force a positive fixture to contain the newly valid diagonal shape. Without a dedicated row, checkpoint code could accidentally preserve only distinct-endpoint relations while the acceptance suite happened to choose ordinary off-diagonal Attitudes.

S5-021 closes that omission-detection gap by requiring an actual runtime-produced stable-boundary checkpoint carrying valid Attitude(P,P).

### 5.2 Sufficiency for the current DEC-0015 intersection

The row requires all of the material properties DEC-0015 introduces at the checkpoint boundary:

- the diagonal Attitude exists as valid current typed state;
- its directed relation identity and value restore exactly;
- ordinary later maintenance/causal evolution remains valid;
- checkpoint/restore representation may not reintroduce generic endpoint inequality;
- current Debt/Favour diagonal invalidity remains unchanged;
- current self-counterparty action rules remain unchanged.

The broader exact-state, epistemic-state, exact-suffix, frontier, fixture, and oracle rows supply the surrounding continuation proof.

### 5.3 No semantic expansion

The row does not define a psychological interpretation of self-attitude, a new scorer, a self-addressed action, diagonal Debt, diagonal Favour, or a general self-relation framework. That matches DEC-0015's explicit exclusions.

### 5.4 Concrete current implementation seam

At the candidate commit:

- WorldState.Validate permits Attitude endpoints to be equal and enforces distinctness separately for Kinship, Marriage, Debt, and Favour;
- runtime AcquireInitialFacts acquires an AttitudeFact for any Attitude in which the actor is a direct party, including Attitude(P,P);
- EpistemicState's fixture-seed validation still uses a local generic Pair predicate requiring a != b for AttitudeFact and several other proposition types.

This is a real stale generic validation seam, but it does not require Candidate2 repair. A positive S5-021 runtime-produced witness can contain both the valid objective diagonal Attitude and its runtime-acquired subjective AttitudeFact. S5-011 and the exact continuation/oracle obligations then prevent a restore representation from silently applying the fixture-only generic inequality as checkpoint authority.

Candidate2 therefore catches the relevant persistence failure without freezing that local implementation form or inventing new semantics.

## 6. Whole-candidate semantic-subordination result

The whole Candidate2 remains subordinate to accepted authority.

It does not require or imply:

- a generic PendingProcess/workflow ontology;
- event-sourced current authority;
- byte-identical checkpoint serialization;
- one DTO, serializer, codec, file format, database, or persistence architecture;
- cross-version migration;
- distributed or concurrent snapshot semantics;
- rollback, time travel, or branching histories;
- new multi-cycle Household/head transitions;
- actor departure;
- mature Household economy/property/accounting;
- generic self-relation machinery.

S5-124 explicitly preserves representation freedom, S5-125 keeps current typed state authoritative rather than history replay, S5-055 rejects a generic process ontology, and the deliberate deferrals preserve later semantic surfaces rather than pulling them into v0.

No candidate row converts an engineering representation choice into a social rule.

## 7. Future-causal completeness result

The current promoted kernel distributes continuation authority across several owners rather than one public snapshot. Candidate2 covers the current future-causal classes with omission-detectable rows.

### 7.1 World/objective state

Covered by S5-010 and related omissions:

- People/objective state;
- dwellings;
- residence;
- Attitudes, now including the allowed diagonal shape;
- kinship;
- marriage;
- Debt state, timing, review flag, and origin;
- Favour state and origin;
- RelationId frontier.

WorldSnapshot does not expose nextRelation, so the frontier coverage is materially necessary.

### 7.2 Subjective/epistemic state

Covered by S5-011, S5-018, S5-035, S5-060, and frontier rows:

- actor-held KnownFacts;
- EvidenceId identities/frontier;
- evidence order and provenance;
- communication hops;
- underlying evidence required for Recognition;
- CandidateReferents including post-initial declarations.

EpistemicSnapshot does not expose the CandidateReferent collection or nextEvidence frontier. Candidate2 does not confuse reconstructed Recognition projections with independent authority.

### 7.3 Household/lifecycle/provision/head state

Covered by S5-012 through S5-014 and omission rows:

- Household identities/lifecycle;
- formation, participation, end, continuation, and lineage warrants;
- sustaining associations;
- future-causal ordinary support history;
- provision commitments and typed provenance;
- persistent HouseholdHeadRole state;
- head-transition provenance;
- provision refusal/reconsideration baseline;
- eligible-support cohort baseline;
- DEC-0014 historical material-need occurrence/provenance;
- HouseholdId, WarrantId, AssociationId, CommitmentId, and HouseholdHeadRoleId frontiers.

The current Household snapshot omits at least support history and allocation frontiers, making the hidden-state census meaningful rather than decorative.

### 7.4 Kernel/time/history/configuration

Covered by S5-019, S5-020, S5-030 through S5-046, and S5-093:

- current Cycle;
- consequential semantic history/provenance needed by live references and exact suffix;
- EventId frontier;
- ProposalId frontier;
- used-ProposalId duplicate-prevention authority;
- not-yet-consumed scheduled future GrainInput state/order;
- active configuration/rule identity.

The current Simulation owns nextEvent, nextProposal, usedProposals, cycle, and semantic history outside the public world snapshot.

### 7.5 Additional-frontier check

I found no additional current runtime-generated semantic ID frontier beyond:

- RelationId;
- EvidenceId;
- EventId;
- ProposalId plus used-ProposalId history;
- HouseholdId;
- WarrantId;
- AssociationId;
- CommitmentId;
- HouseholdHeadRoleId.

CandidateReferent and GrainInput identities are current preserved semantic/input identities, but the inspected kernel does not expose an additional runtime allocator for them requiring a new frontier row.

The Candidate2 hidden-future-state census remains open-ended enough to catch any additional frontier actually present in the eventual implementation candidate.

## 8. Stable-boundary result

S5-001 through S5-006 match the accepted stable-cycle contract.

They require:

- positive checkpoint production only after stable publication and reaction closure;
- rejection while proposal/response/central resolution remains open;
- rejection while automatic reactions remain open;
- no normalization of a faulted, truncated, or partially closed cycle into a valid checkpoint;
- restore to the same published completed boundary;
- no same-cycle voluntary reactivation or replay.

This matches SPEC §9 and ADR-0004. Future-timed accepted state remains allowed because stable closure forbids unfinished current-cycle interaction machinery, not valid scheduled future causality.

No stable-boundary row invents a cross-cycle Household/head workflow.

## 9. Exact suffix and history result

S5-030 through S5-037 require exact uninterrupted/restored continuation under identical future inputs/configuration at each compared stable boundary.

The covered comparison surface includes:

- exact authoritative semantic state;
- existing semantic identities;
- newly generated identities;
- exact consequential history suffix;
- Cycle and consequential ReactionIndex ordering;
- commit/failure/invalidation classifications and reasons;
- causal predecessor references;
- subjective evidence identities/provenance/order;
- fallback candidate set, winner/invalidations, and marker.

S5-036 correctly permits an in-cycle terminal counter field to be reconstructable at a safe next-cycle frontier while still requiring the observable consequential suffix ordering to be exact.

The candidate does not substitute ID-normalized semantic isomorphism for checkpoint exactness.

## 10. Identifier/frontier result

The candidate covers every current generated frontier identified above and includes the two strongest anti-shortcut controls:

- S5-043 requires a runtime-produced consumed/discarded gap;
- S5-045 forbids max-live-ID+1 reconstruction unless exact derivability for every reachable state is independently demonstrated.

This matters concretely for EvidenceId because nextEvidence can advance before an incoming fact is discarded as already superseded, leaving a gap not inferable from the currently held fact set.

S5-044 separately preserves used-ProposalId duplicate-prevention authority. In the current kernel, usedProposals changes future validity directly, so it is not a diagnostic cache.

Independent allocation domains are kept independent by S5-042. Container/serialization enumeration order is explicitly prevented from acquiring semantic authority by S5-046.

## 11. Delayed and future-timed state result

Candidate2 correctly covers the bounded current mechanisms without generalizing them into a workflow engine:

- scheduled future GrainInput: S5-017, S5-050, S5-051, S5-063;
- Debt due/review timing: S5-015, S5-052, S5-066;
- provision reconsideration cooldown/context/eligible-support/DEC-0014 history: S5-014, S5-053, S5-061;
- ordinary recurring maintenance such as consumption/attitude decay: S5-054.

The current kernel's Debt CommittedCycle + DueReviewed, ProvisionRefusal baseline/history, Cycle-driven maintenance, and scheduled input are already typed causal forms. Nothing in accepted authority requires a generic pending-work engine for them.

S5-055 and S5-126 correctly prevent checkpoint engineering from inventing one.

## 12. Omission, cache, and hidden-authority result

S5-060 through S5-074, S5-085, and S5-090 through S5-093 form an adequate omission-detection boundary.

The important properties are:

- omission mutants must remain semantically continuable where practical and reach a suffix that actually depends on the omitted class;
- malformed/parse-failure-only cases are classified separately;
- derived caches/indexes/projections remain rebuildable and non-authoritative;
- checkpoint DTOs cannot become a second live authority;
- discard/rebuild must preserve both query results and exact later continuation;
- at least one behavior-changing stale-derived seam must be negatively challenged;
- completion must census private future-causal fields/frontiers, not only public snapshots.

DEC-0015 does create a reason to challenge generic endpoint filtering, but Candidate2 does not infer a new hidden authority merely from the existence of changed validation code. The concrete EpistemicState fixture validator described above is enough to show that the concern is real. S5-021's explicit no-generic-endpoint-inequality continuation rule is the correct bounded acceptance response.

No new cache or projection becomes authoritative under Candidate2.

## 13. Conditional inherited-verification adaptation result

The Candidate2 formulation is correct: no inherited-verification adaptation is automatically authorized or necessarily required before Slice-5 coding.

Current inherited structural enforcement includes exact field inventories for WorldState and HouseholdState. The current tests explicitly audit those authoritative partitions.

A checkpoint implementation can in principle add bounded capture/restore through transport DTOs, constructors/factories, methods, or other representation-local machinery without changing those exact live-state field inventories, weakening structural enforcement, or making serialized derived state authoritative.

Therefore no specific adaptation is already inevitably triggered by Candidate2.

If an implementation design does change an exact audited authority inventory/checker or otherwise invalidates the inherited witness form, S5-091 correctly requires coding to stop for a separately reviewed lossless adaptation. That conditional path preserves the inherited semantic protection without prematurely choosing an implementation architecture.

## 14. Fixture, producer, and oracle result

S5-080 through S5-085 are sufficient and correctly bounded.

Positive checkpoint evidence must be:

- produced by actual runtime execution;
- captured at a verified stable boundary;
- traceable to source fixture/scenario, cycle, producer state, fixture audit, rule/config identity, and checkpoint identity.

Direct serialized editing is confined to corruption/mutation cases.

Production checkpoint/restore code may execute the system under test, but it cannot be its own sole expected-answer oracle for omissions, frontiers, cache rebuild equivalence, or exact suffix correctness.

The new S5-021 diagonal witness is subject to the same producer/oracle requirements. This is important because it prevents a hand-edited diagonal payload from bypassing the real runtime state/epistemic path and falsely certifying compatibility.

## 15. Deferral and unexercised result

All 12 DEFERRED rows remain properly non-gating and outside the accepted bounded Slice-5 requirement:

1. actor departure;
2. CandidateOrganization convergence;
3. repeated-predecessor lineage selection;
4. contested succession;
5. separate resign-while-participant action;
6. generic nonparticipant perception;
7. general institutional sovereignty;
8. trust/lying/rumor/reputation;
9. cross-version migration;
10. distributed/concurrent snapshot semantics;
11. generic workflow/process engine;
12. rollback/time-travel/branching.

The 2 UNEXERCISED rows also remain properly non-gating:

- general generated-history/shrinking infrastructure;
- rendered human causal-explanation UI.

None hides a current accepted checkpoint requirement. Machine-readable semantic history/provenance remains REQUIRED elsewhere.

## 16. Semantic-escalation status

No semantic escalation is required.

The results demanded by Candidate2 are uniquely determined at the level needed for acceptance by current accepted authority through DEC-0015:

- stable boundary;
- exact same-version continuation;
- future-causal state criterion;
- current subjective/Household/head/provision/debt/favour/scheduled-input semantics;
- exact semantic identity/order/provenance continuity;
- derived-state nonauthority;
- DEC-0015 relation-specific diagonal boundary.

Engineering freedom remains where authority intentionally leaves it: serialization format, DTO decomposition, storage medium, constructor/factory shape, exact compatibility-report representation, and other nonsemantic persistence mechanics.

The current EpistemicState generic fixture-predicate seam does not need a new Director rule because DEC-0015 already determines the semantic answer: Attitude diagonal is allowed, Debt/Favour diagonals are not, and generic representation may not impose universal inequality.

## 17. Freeze recommendation

Freeze Candidate2 unchanged at the exact reviewed identity:

- ref: sfl-v0-slice5-acceptance-v1-candidate2;
- commit: 946e95f87721d4c84af10a81e261ddc5fce77636;
- manifest blob: 948118a655e002b4af0929e6c563a90608fb9456;
- version: SFL-V0-S5-ACCEPTANCE-v1-candidate2.

This review does not itself perform the freeze and does not authorize implementation. Subsequent coding remains subject to the frozen-identity gate and to S5-091 if the selected checkpoint implementation actually changes an inherited exact structural enforcement surface.
