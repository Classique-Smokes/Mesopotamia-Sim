# IMP-0001 candidate-v3 — Amorite independent K4 conformance review

**Final verdict: PASS.** This verdict applies only to **`06e25644879dd8505e24fcaeb43256f69c29c15f`**, frozen as `imp-0001-slice1-conformance-candidate-v3`, against **SFL-V0-S1-ACCEPTANCE-v1**. All **128 REQUIRED** obligations are satisfied, including this review's award of `S1-GLOBAL-CONFORMANCE`. All **33 DEFERRED / 3 N-A / 3 UNEXERCISED** classifications remain unchanged. No conformance blocker or baseline invalidation was found.

This completes the commissioned independent K4 review. It does **not** merge PR #23, promote IMP-0001, retire SCF-002, authorize a Birth Run, or claim full SFL-v0 implementation. The Master Architect owns the final completion/promotion reconciliation and subsequent transition.

## 1. Independence and review boundary

Reviewer: **Amorite**, the fresh independent reviewer task commissioned by the Director. This task authored neither repair-v2 nor repair-v3 production code, acceptance harness, or implementation mapping. No repair author or subagent was used as reviewer. Candidate production/tests/configuration/authority were not edited. Reviewer code lives in a separate scratch project referencing the exact candidate's built assembly through public APIs.

The review followed the retrieval order in the [v3 packet](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/9f08fe2c52bbb8c83c1688db795e4632096b6700/tasks/implementation/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V3_PACKET.md): repository entrypoints and assurance protocol; v3 dispatch/task/repair packets; accepted decisions/SPEC/ADRs; frozen manifest and cited verification sources; candidate source/tests/evidence. The previous K4 report and v2 BLOCK reconciliation were retrieved only after independent source inspection and the first 7,332-world probe run were recorded in `evidence/independent-baseline.md`. Historical claims did not decide the current verdict. An additional exact-fixture historical replay was then run.

The inspected scope includes DEC-0001, ADR-0001–0005, applicable SPEC-SFL-0001 clauses, assumptions and engineering guardrails, all manifest rows and companion bundles, the canonical lower-level/response/resolution/determinism families, cross-cutting contract, scoring profiles and CallFavor mapping. Every production C# file, acceptance scenario/checker/fixture/catalog source, unit/bootstrap test, project setting and canonical workflow was inspected. Coder reports and green CI were evaluated as evidence, not authority.

## 2. Candidate and authority identities

Execution-start refs were captured before canonical verification. Finish verification was recorded at **2026-09-22T23:23:11.909739+00:00**. Both sets agree. The detached candidate's tracked tree is clean after all canonical commands and reviewer probes.

| Identity | Verified value at start and finish |
|---|---|
| Candidate-v3 / detached HEAD / PR #23 head | `06e25644879dd8505e24fcaeb43256f69c29c15f` |
| Candidate-v2 / PR #16 head | `ba16829e240950f1f3c648107cf3b8b36f996971` |
| Candidate-v1 / PR #7 head | `7e11dab7697121eb0dbb169ba46210d81b80586e` |
| PR #7 / #16 / #23 | Open, draft, unmerged |
| Acceptance freeze ref | `sfl-v0-slice1-acceptance-v1` → `55377cc34b8bc3ccbf9cdf5029e9791dae965987` |
| Manifest version/blob | `SFL-V0-S1-ACCEPTANCE-v1` / `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| Census | 167 distinct IDs: 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED |
| SPEC blob | `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52` |
| Cross-cutting contract blob | `7953a7f1c1cf3bd01cb8c08733618664e7a1504d` |
| Current origin/main and return-branch base | `9f08fe2c52bbb8c83c1688db795e4632096b6700` |

Manifest identity was independently calculated from raw Git blob bytes and the Git blob header, without calling the candidate catalogue. Candidate, freeze and current main yield identical bytes. Accepted SPEC/ADRs/substantive verification sources are unchanged from freeze; the verification README and external freeze record contain administrative updates only. All links to reviewed implementation/verification material below pin the candidate SHA.

## 3. Canonical run and CI/artifact comparison

The detached candidate ran with **SDK 10.0.401, C# 14, Microsoft Testing Platform, runtime 10.0.12, MSBuild 18.9.11**, Windows 10.0.19045, win-x64. SDK selection used process-local PATH/DOTNET_ROOT; CLI home and logs are outside candidate tracked state. Nullable/analyzer/warnings-as-errors configuration was retained.

| Exact command | UTC start → finish | Exit |
|---|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | 2026-09-22T23:01:38.1471551Z → 2026-09-22T23:01:47.1928988Z | 0 |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | 2026-09-22T23:01:47.2108518Z → 2026-09-22T23:02:00.7094685Z | 0 |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | 2026-09-22T23:02:00.7104649Z → 2026-09-22T23:02:08.8746228Z | 0 |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | 2026-09-22T23:02:08.8756205Z → 2026-09-22T23:02:19.7187288Z | 0 |

The build had **zero warnings/errors**. Tests reported **8 succeeded / 0 failed / 0 skipped**. The acceptance runner executed **62 named scenarios / 1,948 audited worlds**, reporting all **127 coder-owned REQUIRED** rows PASS and leaving the independent review row explicitly pending. The runner's pending row and false full-completion flag are preserved in the original evidence; this external report supplies the separate K4 decision.

One initial PowerShell logging wrapper stopped on native stderr under `ErrorActionPreference=Stop`. The wrapper was corrected outside the candidate, and the complete four-command sequence above was rerun successfully. This was a review orchestration issue, not a candidate failure.

[Canonical PR run 35787127702](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35787127702) has successful restore, static-quality, build and test steps. The downloaded job log confirms synthetic merge checkout **`1f3f54cb750696d0bab26d2de2811e181700aead`**, merging this candidate with main **`34989ee91d293971dcecf9837c76ddc3ad751424`**. It is head-associated integration evidence, not an exact-detached-head substitute.

[Artifact 10719823413](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35787127702/artifacts/10719823413) was downloaded and hashed independently. Its ZIP SHA-256 equals **`031f21dc553dcf0bfff4b73f3bff764ff5a8dc1856d20493b164cc164c1268ca`**. All six local files equal the remote files after **only CRLF→LF** normalization; the five JSON values also compare deeply equal. No status, reference, source clause, field, array order or scenario was discarded to obtain agreement.

| Evidence file | Fresh SHA-256 | Remote SHA-256 | Result |
|---|---|---|---|
| cases.json | `ef83cb8b531eb6635ee5749b17efb522548c5a4130850dfca56e7e7fe3dcb341` | `4e62dfa78985b357e0d75dff428e82a1bc4a5a70b128da94175cf830189d6b4e` | LF-identical; semantic match |
| fault-controls.json | `f6225185016c0b64548c223aa68ee4ba5de1f5ac2a9e5908c6b08d974b1d7b2c` | `6f18c64f1e1ff2b7a282b5499d515f0b38e52943bb35dfa2b1444a8992b8b9ee` | LF-identical; semantic match |
| fixture-audit.json | `47a5c8e2352f9c53054c7085f1a5870665c358173bfdebfe4ab9d61a98bcd261` | `65387828d012586420ebdc46db97bc72ccb59ed067f3937fb88e96f3b71dd9b3` | LF-identical; semantic match |
| oracle-audit.json | `8b6ef4088f594eb83a387d021f347c043e483b99b1cc30c6428032472c972b4d` | `12519b971e5bc90acd866a3c5c2734dff25a4aabcbd3cae043c9d94a388dbcc9` | LF-identical; semantic match |
| slice1-results.json | `1940517c4bcb2d61df4bedaef1ae4099c33b3a50fb22c60a43f2189b36b8de2a` | `ef5f78f9f27486baa187b34ca182dbd5033940546d2434698d20bd1454ce55f5` | LF-identical; semantic match |
| slice1-results.md | `9dce7c30e8b519cdf827fc695fe38321efad9bdca9163c0989ce14ea263d99ac` | `345108c17398031fc329e70dc270c0bec4b4e6a5304a42522d2b11ab322395f0` | LF-identical; semantic match |

The implementation report's earlier `d7e2847…` publication receipt is historical metadata. The reviewed identity and artifact are the final frozen candidate and run above, consistent with the current v3 dispatch packet.

## 4. Seven K4 conclusions and architectural inspection

| K4 obligation | Conclusion | Independent basis |
|---|---|---|
| 1. Manifest integrity | SATISFIED | Independent raw-blob identity, source comparison, unique-ID census, and start/finish ref/PR checks. |
| 2. Substantive evidence for every REQUIRED row | SATISFIED | All 128 rows have admissible evidence in the complete ledger; test bodies and companion controls were inspected, and K4 is awarded only here. |
| 3. Source-to-assertion fidelity | SATISFIED | Each canonical case was checked against its source clause; thresholds, failure distinctions, history and profiles remain faithful. Independent recovery and interaction models challenge broad claims beyond named examples. |
| 4. Oracle independence | SATISFIED | Actual source/dependency inspection, not merely the candidate's forbidden-token scan. Expected arithmetic, mandatory cause reconstruction, recorded provenance and metamorphic comparisons do not reuse assertion-target production logic. |
| 5. Fixture discipline | SATISFIED | All canonical subcases have recorded setup; debt/favour are created by committed public interactions. Initial relation facts are antecedents, not written transition results. Controlled internal challenges and detached corrupt witnesses are explicitly distinguished. |
| 6. Honest deferred/later-slice boundaries | SATISFIED | All 39 non-required rows retain their frozen classifications/reasons. No fabricated household, recognition, general communication, departure, checkpoint or rendered-explanation system supplies evidence. |
| 7. Absence of silently invented semantics | SATISFIED | Inspected behavior follows accepted SPEC/ADRs and v3 packet constraints. No new social priority, generic transfer reserve, rescue input, nested response or later-slice authority was introduced. |

**Architecture and invariant enforcement.** Typed independent IDs and immutable records remain authoritative in a single-threaded in-memory kernel. Actor policies receive a captured immutable personal view, emit proposals, and cannot mutate another actor's state. The common decision snapshot is materialized before deliberation/response. Each accepted proposal is immediately revalidated against current authoritative state and committed through a copied transaction. Automatic direct attitude contributions close before completed state is published; no fresh voluntary activation occurs inside the cycle. State validation, independent material/history replay and focused scenario assertions jointly cover references, grain, cardinalities, reserve, cause membership, reaction order and retained provenance.

**Subjective information and traces.** Own state, direct-party relations/claims and explicit observations are identifiable inputs. Unobserved counterpart grain, need, residence, sex and unrelated relations are not passed to personal generation/gates/scoring. Objective feasibility remains a separate world operation. Trace records preserve generated candidates, exclusions, named integer components, selection, profile and proposal linkage. The response trace/profile and linked proposal history preserve the response meaning and its terms. Failed-attempt knowledge is limited to direct participants and bounded reasons.

**Oracle and fixture limits.** Replaying history alone does not prove that the history is correct. Row-specific expected outcomes, hand-authored profile arithmetic, boundary matrices and adversarial controls supply the complementary semantic proof. The independent checker derives all mandatory direct attitude causes before comparing recorded contributions; coherently omitted causes are detected. Internal friend access in the candidate tests is used for declared duplicate/closure challenges, field/type checks and captured-view isolation, not to write a successful outcome. The separate Amorite runner uses only public APIs and never calls a production classifier, scorer, dependency analyzer, recovery projection or test oracle.

**Fault classifications.** Duplicate-cause and suppressed-closure cases are actual internal challenges with specific semantic detectors. Corrupt material/attitude witnesses challenge checker adequacy rather than pretending to mutate production. Focused negative/structural controls are admissible under manifest Part G and are not relabeled as executed mutants. Crashes/timeouts receive no automatic semantic credit. The no-cache rows use the explicitly permitted structural alternative, supported by the complete authoritative-field/query audit.

## 5. Adversarial findings and regression conclusions

### Recovery projection — conforming

SPEC §§2.2/9.1/9.5 imply a useful independent reduction at an all-zero NeedsGrain boundary: without voluntary action, an input-free gap preserves the block; a complete executable scheduled batch with positive surviving stock pays maintenance and creates a later unblocked decision boundary. Intermediate credits that are cancelled before maintenance do not suffice. The review's BigInteger model checks prefix validity and representable stock independently of the production helpers.

Named controls cover no input, +1 recovery, +1/-1 cancellation, +2/-1 survival, split-person cancellation, withdrawals, distant cycles including long.MaxValue, impossible debit, checked overflow, earlier recovery before a later bad schedule, and subsequent reblocking. The bounded matrix exhausts three input deltas from {-2,-1,0,1,2,3}, all eight assignments to two actors, and both collection enumerations, with input cycles 2/2/3. Projection neither changes authoritative people/history nor opens future decisions. Faults before recovery fail to demonstrate recovery; actual failure is deferred to the scheduled cycle and preserves the prior stable publication.

### Fallback attribution — conforming

The independent debt model enumerates remaining debts {3,5,6}, decision stocks {4,5,6,7,8}, and four enabler arrangements: Farm +4, incoming Gift +1, incoming Gift +4, and incoming Gift +2 with one direct repayment replacing a call. Each uses three 2-unit repayments, all 24 proposal orders, and both input enumerations. Expected participation is derived by comparing adjacent order exchanges of independently calculated terminal results and balances, not by invoking ResolutionDependencies. It detects both genuinely consequential enablers and credits that cannot overcome the tighter debt/reserve constraint.

The residence model independently enumerates **216 reachable pairs** drawn from four actors' Move/Invite shapes with different initiators, both ID orders and both input enumerations (**864 worlds**), plus all six orders of a three-move destination chain. Other probes cover conditional favour creation provenance, retirement/recreation, CallFavor/cancellation, competing marriage capacity, commuting marriage/residence, and opposing transfers.

The structural interaction audit closes the scope beyond those samples: all current action-relevant mutable reads/writes fall into material/need/debt, residence owner/mover plus the moved set, marriage participant capacity, or favour identity/directed-pair capacity. Wrapped actions use the called debtor and effective Farm/repayment terms, plus outer-claim retirement. Sex/kinship do not mutate in-slice; direct attitude reactions occur after resolution and cannot alter same-cycle feasibility. Already accepted proposals cannot reference a newly created debt. New favour creator provenance is consequential and is compared. Independent relation allocation order is normalized without hiding creator identity.

Within each potentially interacting component, the inspected implementation evaluates reachable prefixes and adjacent exchanges. Equal retained states cannot be distinguished by a remaining action's current preconditions; differing terminal outcomes or retained relation provenance are consequential. Material-overlap partitioning does not itself award a marker. This supports precision for the current action vocabulary without claiming verification of future actions or an arbitrary scale bound. Search cost remains combinatorial in a connected proposal component; the frozen Slice-1 contract specifies no production-scale performance threshold.

### Historical counterexamples and prior repairs — preserved

After the independent baseline was recorded, the v2 report/reconciliation were used as historical counterexample evidence. Reviewer H1 recreates the three-person +1/-1 and +2/-1 recovery cases, and the exact five-person debt/Farm setup: three public bargains and a 5-unit loan in cycle 1, empty cycle 2, then three called 2-unit repayments plus the debtor's Farm in cycle 3. All 24 ID orders and both input enumerations pass: two repayments commit, the last caller invalidates with RepaymentExceedsRemaining, remaining debt is 1, debtor grain is 6, caller markers are true, Farm's is false, and favour retirement matches the successful calls.

Independent regression probes also confirm needy request refusal for all three ordinary request forms; absence of refusal effects on inability; bounded participant knowledge; identical personal traces under hidden-world changes and different traces under changed observations; direct/nested grain validity; all non-callable shapes; mixed-sign attitude composition; called/personal initiative coexistence and rejection of duplicate personal initiatives; and full/racing explicit bargains. The original D1–D5 conjunctive bundles were checked in their entirety through the ledger and case audit.

No semantic ambiguity requiring a new expectation or authority decision was encountered in the tested cases. No candidate repair was made.

### Reviewer probe results

All **7,388 reviewer-owned world instances / 64,793 assertions** passed. These are supplemental adversarial cases, not a reclassification of frozen S1-SUP-GENERATED, S1-SUP-SHRINK or S1-SUP-HELDOUT.

| Reviewer case | Worlds | Assertions | Result |
|---|---:|---:|---|
| A1.NamedRecoveryAndFaultTiming | 13 | 57 | PASS |
| A2.BoundedSignedScheduleEnumeration | 3456 | 17280 | PASS |
| B1.DebtGrainEnablerPermutationMatrix | 2880 | 39600 | PASS |
| B2.ResidencePairInteractionEnumeration | 870 | 6954 | PASS |
| B3.FavourProvenanceAndRetirement | 24 | 108 | PASS |
| B4.MarriageResidenceAndMaterialCommutingControls | 12 | 40 | PASS |
| C1.NeedRefusalAndFailureKnowledge | 18 | 72 | PASS |
| C2.PersonalSubjectiveIsolation | 7 | 78 | PASS |
| C3.GrainIngressAndCallFavorClosure | 46 | 78 | PASS |
| C4.MixedAttitudeAndInitiative | 6 | 10 | PASS |
| C5.ExplicitBargainAtomicity | 6 | 26 | PASS |
| H1.ExactHistoricalCounterexamples | 50 | 490 | PASS |

## 6. Independent all-167-row evidence ledger

The row set and applicability come directly from the independently parsed frozen manifest. **PASS here means reviewer-adjudicated substantive evidence**, not merely a copied test-run label. E01–E62 resolve to the source-linked audit in Appendix A. The candidate's original row state remains available in the accompanying JSON ledger; in particular its K4 row stays awaiting review while this report awards PASS. All D1–D5 companion members are conjunctive and present. Non-required rows preserve their original reason.

| AcceptanceId | Frozen status | Reviewer disposition | Frozen clause | Admissible evidence / retained rationale |
|---|---|---|---|---|
| S1-090-A | REQUIRED | PASS | successful consumption | [E61](#e61) |
| S1-090-B | REQUIRED | PASS | missed consumption creates NeedsGrain | [E61](#e61) |
| S1-090-C | REQUIRED | PASS | NeedsGrain blocks Farm | [E61](#e61) |
| S1-090-D | REQUIRED | PASS | need clearing at next 1-grain unit; no same-cycle reactivation | [E01](#e01) |
| S1-090-E | REQUIRED | PASS | Farm commits +4 with explicit source/history | [E61](#e61) |
| S1-091-GIFT | REQUIRED | PASS | OfferGift accepted route | [E01](#e01) |
| S1-091-HELP | REQUIRED | PASS | RequestGiftOrHelp accepted route | [E01](#e01) |
| S1-091-LOAN-OFFER | REQUIRED | PASS | OfferLoan accepted route | [E05](#e05) |
| S1-091-LOAN-REQUEST | REQUIRED | PASS | RequestLoan accepted route | [E05](#e05) |
| S1-091-BFF-POS | REQUIRED | PASS | ExplicitBenefitForFavor positive-capacity atomic commit | [E09](#e09) |
| S1-091-RMRH | REQUIRED | PASS | RelationshipMediatedReciprocalHelp positive route and explicit history meaning | [E09](#e09) |
| S1-091-MEANING-SEPARATION | REQUIRED | PASS | material path sharing never collapses Gift/Loan/BFF/RMRH meanings | [E35](#e35) |
| S1-092-PARTIAL | REQUIRED | PASS | partial repayment | [E05](#e05), [E47](#e47), [E59](#e59), [E60](#e60) |
| S1-092-AMOUNT-VALIDITY | REQUIRED | PASS | repayment 0/negative/non-integral/over-remaining rejected before response; remaining amount valid | [E06](#e06) |
| S1-092-RESERVE | REQUIRED | PASS | semantically valid repayment that penetrates reserve is Unable and has no social refusal effect | [E06](#e06), [E49](#e49), [E59](#e59), [E60](#e60) |
| S1-092-FULL | REQUIRED | PASS | full repayment satisfies claim and retains history | [E05](#e05) |
| S1-092-DUE | REQUIRED | PASS | N+3 before/at/later social-due one-shot penalty | [E07](#e07) |
| S1-093-BFF-POS | REQUIRED | PASS | explicit bargain positive-capacity creation | [E09](#e09) |
| S1-093-RECIP-74 | REQUIRED | PASS | reciprocal-help stored attitude +74 no favour | [E09](#e09) |
| S1-093-RECIP-75 | REQUIRED | PASS | reciprocal-help stored attitude +75 may create favour | [E09](#e09) |
| S1-093-RECIP-76 | REQUIRED | PASS | reciprocal-help stored attitude +76 may create favour | [E09](#e09) |
| S1-093-KIN-GATE | REQUIRED | PASS | kinship amplification cannot satisfy +75 stored-attitude gate | [E09](#e09) |
| S1-093-GIFT-CONTROL | REQUIRED | PASS | genuine Gift creates no favour | [E01](#e01) |
| S1-093-BFF-FULL | REQUIRED | PASS | explicit BFF at already-full pair capacity -> Unable; no response/material/new favour | [E10](#e10) |
| S1-093-BFF-RACE | REQUIRED | PASS | BFF capacity free at acceptance then lost before commit -> Invalidated; no partial commit | [E11](#e11), [E45](#e45) |
| S1-093-RMRH-FULL | REQUIRED | PASS | RMRH may commit at full pair capacity while no second favour is created | [E10](#e10), [E45](#e45) |
| S1-094-FARM-CALLABLE | REQUIRED | PASS | Farm is a valid response-closed payload when otherwise feasible | [E12](#e12), [E54](#e54) |
| S1-094-REPAY-CALLABLE | REQUIRED | PASS | RepayDebt is a valid response-closed payload when terms/world state are valid | [E14](#e14), [E46](#e46), [E53](#e53), [E54](#e54) |
| S1-094-PERSONAL-COEXIST | REQUIRED | PASS | callable fulfilment coexists with already selected ordinary personal initiative without a second personal-initiative charge | [E13](#e13) |
| S1-094-NONCALLABLE-MATRIX | REQUIRED | PASS | every current NON-CALLABLE Slice-1 semantic action shape is rejected before called-actor response | [E21](#e21) |
| S1-094-NONPAYLOAD-MATRIX | REQUIRED | PASS | response/result/internal-effect helper shapes cannot be used as payload types | [E21](#e21) |
| S1-094-UNABLE | REQUIRED | PASS | valid callable payload world-infeasible -> Unable; favour remains; no +/- called-favour effect | [E12](#e12) |
| S1-094-DECLINE | REQUIRED | PASS | valid feasible payload voluntarily refused -> Declined; favour remains; -20 | [E12](#e12) |
| S1-094-INVALIDATED | REQUIRED | PASS | fulfil selected then action-relevant precondition lost -> Invalidated; favour remains; no +/- called-favour effect | [E14](#e14), [E47](#e47), [E49](#e49), [E59](#e59), [E60](#e60) |
| S1-094-SUCCESS | REQUIRED | PASS | requested action commit consumes favour and applies +10 exactly then | [E12](#e12) |
| S1-094-NESTED-GUARD | REQUIRED | PASS | no accepted callable payload opens another ResponseDecisionContext | [E12](#e12) |
| S1-094-RECIP-CANCEL | REQUIRED | PASS | reciprocal outstanding favours may cancel atomically | [E15](#e15), [E46](#e46) |
| S1-095-POS | REQUIRED | PASS | mutual strong-like direct marriage positive route | [E17](#e17) |
| S1-095-74 | REQUIRED | PASS | one direction +74 blocks bypass | [E17](#e17) |
| S1-095-KIN | REQUIRED | PASS | parent/child or siblings never marry | [E17](#e17) |
| S1-095-LIFETIME | REQUIRED | PASS | established v0 marriage blocks second establishment; rejection does not consume eligibility | [E18](#e18) |
| S1-095-NO-RESIDENCE | REQUIRED | PASS | direct marriage alone does not move residence | [E17](#e17) |
| S1-096-MOVE | REQUIRED | PASS | accepted move proposal changes only Residence relation as specified | [E19](#e19) |
| S1-096-INVITE | REQUIRED | PASS | accepted invite route | [E19](#e19) |
| S1-096-COMPETE | REQUIRED | PASS | two independently accepted same-person Residence changes -> exactly one commit + explicit invalidation | [E19](#e19) |
| S1-096-NO-HH | REQUIRED | PASS | residence change alone creates/removes no household participation/identity | [E19](#e19) |
| S1-096-MARRIAGE-CONTROL | REQUIRED | PASS | marriage alone does not move residence | [E17](#e17) |
| S1-097-EVENTS | REQUIRED | PASS | every fixed v0 event update independently exercised | [E36](#e36), [E40](#e40), [E41](#e41) |
| S1-097-SAT | REQUIRED | PASS | single direct update saturates at +/-100 | [E28](#e28) |
| S1-097-DIRECT-BATCH-POS | REQUIRED | PASS | +95 with +10 and -20 -> one sum-then-clamp result +85; both causes retained | [E28](#e28) |
| S1-097-DIRECT-BATCH-NEG | REQUIRED | PASS | equivalent mixed-sign negative-bound case | [E28](#e28) |
| S1-097-DECAY | REQUIRED | PASS | before/at/after 5-cycle decay; no zero crossing | [E62](#e62) |
| S1-098-CORE | REQUIRED | PASS | one personal voluntary initiative; responses do not consume/grant; multiple responses allowed | [E03](#e03) |
| S1-098-CALLFAVOR-INIT | REQUIRED | PASS | voluntary CallFavor initiation consumes holder's normal personal initiative | [E12](#e12) |
| S1-098-COMMUNICATION | DEFERRED | DEFERRED | Communication-specific initiative example | Frozen rationale retained: General communication/claim propagation explicitly outside IMP-0001 |
| S1-099-KIN | REQUIRED | PASS | exact 1.5x kin attitude-component amplification; stored attitude/gates unchanged | [E23](#e23), [E24](#e24) |
| S1-099-CORES | REQUIRED | PASS | marriage co-residence incentive > strong mutual positive incentive; no forced move | [E25](#e25), [E52](#e52) |
| S1-100 | REQUIRED | PASS | VS-SFL-100; feasible Accept vs Decline is target policy | [E02](#e02) |
| S1-101 | REQUIRED | PASS | VS-SFL-101; infeasibility precedes Accept preference | [E02](#e02) |
| S1-102 | REQUIRED | PASS | VS-SFL-102; called-favour fulfil/refusal + invalid payload + Unable/Invalidated controls | [E12](#e12) |
| S1-103-GRAIN | REQUIRED | PASS | VS-SFL-103; two accepted scarce-grain responses, one commit/one invalidation | [E03](#e03) |
| S1-103-RESIDENCE | REQUIRED | PASS | VS-SFL-103 companion; two accepted same-person Residence contenders | [E19](#e19) |
| S1-104 | DEFERRED | DEFERRED | VS-SFL-104; role-scoped household-mediated response | Frozen rationale retained: Requires Active Household/head/mediated-marriage substrate outside Slice 1 |
| S1-105 | REQUIRED | PASS | VS-SFL-105; personal initiative plus incoming response | [E26](#e26) |
| S1-070 | REQUIRED | PASS | VS-SFL-070; Declined vs Unable paired contrast + participant knowledge | [E02](#e02) |
| S1-071 | REQUIRED | PASS | VS-SFL-071; accepted then invalidated at central resolution | [E03](#e03) |
| S1-072 | DEFERRED | DEFERRED | VS-SFL-072; household provision priority | Frozen rationale retained: Household provision outside Slice 1 |
| S1-073 | REQUIRED | PASS | VS-SFL-073; bounded failure reason/no private-state leak | [E02](#e02) |
| S1-074-IDEMP | REQUIRED | PASS | VS-SFL-074; same automatic cause contributes exactly once | [E29](#e29) |
| S1-074-DIRECT-BATCH | REQUIRED | PASS | VS-SFL-074 companion; mixed direct attitude causes batch once / order-independent | [E28](#e28) |
| S1-075 | DEFERRED | DEFERRED | VS-SFL-075; household formation reaction chain | Frozen rationale retained: Card as written requires formation/recognition/Household substrate |
| S1-076 | DEFERRED | DEFERRED | VS-SFL-076; communication provenance regression | Frozen rationale retained: General communication/recognition propagation outside Slice 1 |
| S1-080 | REQUIRED | PASS | VS-SFL-080; MaterialDeadlock diagnosed, no rescue grain | [E30](#e30), [E56](#e56), [E57](#e57), [E58](#e58) |
| S1-081 | REQUIRED | PASS | VS-SFL-081; stable-ID fallback quarantined/disclosed, including Residence conflict exercise | [E31](#e31), [E38](#e38), [E39](#e39), [E43](#e43), [E44](#e44), [E45](#e45), [E46](#e46), [E47](#e47), [E48](#e48), [E49](#e49), [E50](#e50), [E59](#e59), [E60](#e60) |
| S1-082 | DEFERRED | DEFERRED | VS-SFL-082; checkpoint exact suffix | Frozen rationale retained: Checkpoint/save-load explicitly outside Slice 1 |
| S1-083 | DEFERRED | DEFERRED | VS-SFL-083; omitted checkpoint state detected | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-084 | REQUIRED | PASS | VS-SFL-084; derived rebuild equivalence / stale-cache authority | [E34](#e34) |
| S1-085 | REQUIRED | PASS | VS-SFL-085; observer/diagnostic noninterference | [E32](#e32), [E55](#e55) |
| S1-086 | REQUIRED | PASS | VS-SFL-086; decision trace completeness for personal/response contexts | [E23](#e23), [E24](#e24), [E42](#e42), [E51](#e51), [E52](#e52), [E53](#e53), [E54](#e54), [E55](#e55) |
| S1-087 | DEFERRED | DEFERRED | VS-SFL-087; rendered causal explanation surface | Frozen rationale retained: No rendered explanation surface required in Slice 1; causal predecessor truth remains required through history/086 |
| S1-BND-ATT-STRONGLIKE | REQUIRED | PASS | +74/+75/+76 | [E17](#e17) |
| S1-BND-ATT-STRONGDISLIKE | N-A | N-A | -76/-75/-74 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-DISLIKE-NEUTRAL | N-A | N-A | -27/-26/-25 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-NEUTRAL-LIKE | N-A | N-A | +25/+26/+27 | Frozen rationale retained: No named Slice-1 categorical action gate depends on this band |
| S1-BND-ATT-SAT | REQUIRED | PASS | beyond +/-100 | [E28](#e28) |
| S1-BND-ATT-MIXED | REQUIRED | PASS | mixed-sign direct causes near both bounds | [E28](#e28) |
| S1-D4-GRAIN-GIFT-OFFER | REQUIRED | PASS | OfferGift grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E04](#e04) |
| S1-D4-GRAIN-GIFT-REQUEST | REQUIRED | PASS | RequestGiftOrHelp grain-transfer term: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E04](#e04) |
| S1-D4-GRAIN-LOAN-OFFER | REQUIRED | PASS | OfferLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E08](#e08) |
| S1-D4-GRAIN-LOAN-REQUEST | REQUIRED | PASS | RequestLoan grain amount: zero/negative/non-integral invalid; positive integer reaches ordinary action gates | [E08](#e08) |
| S1-D4-GRAIN-REPAY-DIRECT | REQUIRED | PASS | direct RepayDebt amount: D4-invalid terms rejected before feasibility/commit; positive integer reaches repayment-specific gates | [E06](#e06) |
| S1-D4-GRAIN-BFF-BENEFIT | REQUIRED | PASS | required Slice-1 BFF grain-transfer instantiation: every grain quantity in/referenced by the specified material-benefit term obeys D4 before target response; raw scalar amount field not required | [E16](#e16) |
| S1-D4-GRAIN-RMRH-BENEFIT | REQUIRED | PASS | required Slice-1 RMRH grain-transfer instantiation: every grain quantity in/referenced by the help/material-benefit term obeys D4 before target response; raw scalar amount field not required | [E16](#e16) |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | REQUIRED | PASS | ProposeMarriage proposed-dowry term on direct-bypass proposal shape: invalid grain term rejected before bride response; positive integer may proceed; no dowry transfer on bypass | [E20](#e20) |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | REQUIRED | PASS | CallFavor(RepayDebt(...)) inner amount: zero/negative/non-integral/over-remaining rejects outer call before Fulfil/Refuse response; valid term may proceed | [E22](#e22) |
| S1-BND-REPAY-AMOUNT | REQUIRED | PASS | remaining-1 / remaining / remaining+1 (where remaining>1), evidenced for direct and nested called-favour repayment ingresses | [E22](#e22) |
| S1-BND-RESERVE | REQUIRED | PASS | RepayDebt debtor resulting grain 1 / 2 / 3 | [E06](#e06) |
| S1-BND-NEED | REQUIRED | PASS | NeedsGrain clearing grain 0 / 1 | [E01](#e01) |
| S1-BND-DECAY | REQUIRED | PASS | immediately before / at / after 5-cycle cadence | [E62](#e62) |
| S1-BND-DEBT-DUE | REQUIRED | PASS | before N+3 / after N+3 decisions / later | [E07](#e07) |
| S1-BND-MARRIAGE-CARD | REQUIRED | PASS | first establishment / second after establishment | [E18](#e18) |
| S1-BND-FAVOUR-CARD | REQUIRED | PASS | first favour / additional same ordered pair | [E10](#e10) |
| S1-BND-FAVOUR-MEANING | REQUIRED | PASS | full pair slot: ExplicitBenefitForFavor vs RMRH | [E10](#e10) |
| S1-BND-RESIDENCE-CARD | REQUIRED | PASS | one vs multiple accepted same-person Residence changes | [E19](#e19) |
| S1-BND-HOUSEHOLD-PROVISION | DEFERRED | DEFERRED | household-provision contributor reserve / NeedsGrain contributor / collective capacity boundaries | Frozen rationale retained: Household provision outside Slice 1 |
| S1-BND-PROVISION-RECONSIDERATION | DEFERRED | DEFERRED | before 3 full cycles / exactly 3 with no relevant context change / exactly 3 plus relevant context change | Frozen rationale retained: Household provision/head reconsideration outside Slice 1 |
| S1-BND-FORMATION | DEFERRED | DEFERRED | formation/participation/lifecycle boundaries | Frozen rationale retained: Household formation outside Slice 1 |
| S1-BND-LINEAGE | DEFERRED | DEFERRED | lineage freshness / predecessor lifecycle-state (one survives vs both Dissolved) / predecessor-source ambiguity boundaries | Frozen rationale retained: Lineage outside Slice 1 |
| S1-META-01 | REQUIRED | PASS | storage/input iteration permutation | [E32](#e32), [E58](#e58), [E59](#e59), [E60](#e60) |
| S1-META-02 | REQUIRED | PASS | nonsemantic ID renaming | [E33](#e33), [E38](#e38), [E39](#e39), [E43](#e43), [E44](#e44), [E45](#e45), [E46](#e46), [E47](#e47), [E48](#e48), [E49](#e49), [E50](#e50), [E59](#e59), [E60](#e60) |
| S1-META-03 | REQUIRED | PASS | disconnected-population locality | [E33](#e33) |
| S1-META-04 | REQUIRED | PASS | observer/diagnostic noninterference | [E32](#e32), [E56](#e56), [E57](#e57), [E58](#e58) |
| S1-META-05 | REQUIRED | PASS | derived rebuild equivalence | [E34](#e34) |
| S1-META-06 | DEFERRED | DEFERRED | checkpoint metamorphism | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-META-07 | REQUIRED | PASS | irrelevant-attribute perturbation | [E32](#e32), [E42](#e42), [E51](#e51), [E52](#e52), [E53](#e53), [E54](#e54) |
| S1-META-08 | DEFERRED | DEFERRED | message-arrival permutation | Frozen rationale retained: Communication/recognition outside Slice 1 |
| S1-META-09 | DEFERRED | DEFERRED | lineage predecessor-set ordering | Frozen rationale retained: Lineage outside Slice 1 |
| S1-META-10 | REQUIRED | PASS | direct-attitude cause permutation | [E28](#e28) |
| S1-META-11 | REQUIRED | PASS | Residence contender permutation | [E19](#e19) |
| S1-MUT-01 | DEFERRED | DEFERRED | form H from co-residence alone | Frozen rationale retained: Household formation absent |
| S1-MUT-02 | DEFERRED | DEFERRED | form H from insufficient/same-cycle support | Frozen rationale retained: Household formation absent |
| S1-MUT-03 | DEFERRED | DEFERRED | global household/head recognition | Frozen rationale retained: Household recognition absent |
| S1-MUT-04 | REQUIRED | PASS | kinship multiplier satisfies stored-attitude gate | [E09](#e09) |
| S1-MUT-05 | DEFERRED | DEFERRED | identity by overlap/similarity | Frozen rationale retained: Household continuity absent |
| S1-MUT-06 | DEFERRED | DEFERRED | Inactive/Dissolved H emits household action | Frozen rationale retained: Household action absent |
| S1-MUT-07 | DEFERRED | DEFERRED | participation entry without acceptance/warrant | Frozen rationale retained: Participation absent |
| S1-MUT-08 | DEFERRED | DEFERRED | household self-feedback clone | Frozen rationale retained: Formation absent |
| S1-MUT-09 | DEFERRED | DEFERRED | inherit causal state through lineage | Frozen rationale retained: Lineage absent |
| S1-MUT-10 | DEFERRED | DEFERRED | count household support as fresh lineage evidence | Frozen rationale retained: Lineage absent |
| S1-MUT-11 | DEFERRED | DEFERRED | household expenditure without backing | Frozen rationale retained: Provision absent |
| S1-MUT-12 | DEFERRED | DEFERRED | pool/duplicate provision grain or double-debit contributor | Frozen rationale retained: Household provision absent |
| S1-MUT-13A | REQUIRED | PASS | RepayDebt commits while leaving debtor below the accepted §3.3 two-grain floor | [E06](#e06) |
| S1-MUT-13B | DEFERRED | DEFERRED | household provision penetrates contributor protected reserve or draws from a NeedsGrain contributor | Frozen rationale retained: Household provision absent |
| S1-MUT-14 | DEFERRED | DEFERRED | head commands out-of-scope personal action | Frozen rationale retained: Head role absent |
| S1-MUT-15 | DEFERRED | DEFERRED | majority instead of unanimous head appointment | Frozen rationale retained: Head appointment absent |
| S1-MUT-16 | REQUIRED | PASS | skip commit-time revalidation | [E03](#e03), [E37](#e37) |
| S1-MUT-17 | REQUIRED | PASS | collapse Declined/Unable/Invalidated | [E02](#e02) |
| S1-MUT-18 | REQUIRED | PASS | penalize Unable/Invalidated as voluntary refusal | [E02](#e02), [E40](#e40) |
| S1-MUT-19 | REQUIRED | PASS | leak exact/unrelated private state in failure reason | [E02](#e02) |
| S1-MUT-20 | REQUIRED | PASS | same-cycle retry after invalidation | [E03](#e03) |
| S1-MUT-21 | REQUIRED | PASS | resolve scarce capacity by collection order | [E03](#e03), [E37](#e37) |
| S1-MUT-22 | REQUIRED | PASS | fire same reaction cause twice | [E29](#e29) |
| S1-MUT-23 | REQUIRED | PASS | truncate reaction closure and report success | [E29](#e29) |
| S1-MUT-24 | REQUIRED | PASS | stale derived cache influences behavior | [E34](#e34) |
| S1-MUT-25 | DEFERRED | DEFERRED | omit future-influencing checkpoint state | Frozen rationale retained: Checkpoint outside Slice 1 |
| S1-MUT-26 | REQUIRED | PASS | instrumentation mutates semantics | [E32](#e32) |
| S1-MUT-27 | DEFERRED | DEFERRED | later-arriving older message overwrites newer event evidence | Frozen rationale retained: Communication/recognition absent |
| S1-MUT-28 | DEFERRED | DEFERRED | Contested recognition resolved by arbitrary ID | Frozen rationale retained: Recognition absent |
| S1-MUT-29 | REQUIRED | PASS | record only chosen action instead of full decision trace | [E24](#e24) |
| S1-MUT-30 | DEFERRED | DEFERRED | rendered explanation cites unsupported cause | Frozen rationale retained: Rendered explanation surface outside Slice 1 |
| S1-MUT-31 | REQUIRED | PASS | clamp independent direct attitude causes contribution-by-contribution | [E28](#e28) |
| S1-MUT-32 | REQUIRED | PASS | multiple same-person Residence commits or container-order winner | [E19](#e19) |
| S1-MUT-33 | REQUIRED | PASS | invalid grain term reaches response/effects or over-repayment is clamped | [E22](#e22) |
| S1-MUT-34 | REQUIRED | PASS | called favour opens nested response, consumes favour on Unable/Invalidated, or fires +/- effect on non-voluntary failure | [E14](#e14) |
| S1-MUT-35 | REQUIRED | PASS | ExplicitBenefitForFavor partially commits when favour capacity unavailable / relabels as Gift/Help | [E10](#e10), [E11](#e11) |
| S1-SUP-GENERATED | UNEXERCISED | UNEXERCISED | bounded generated histories | Frozen rationale retained: Useful later for interaction breadth; B2 explicitly keeps generated-history infrastructure off the Slice-1 completion path |
| S1-SUP-SHRINK | UNEXERCISED | UNEXERCISED | generated-failure shrinking/minimization | Frozen rationale retained: Only relevant once generated histories are in use |
| S1-SUP-HELDOUT | UNEXERCISED | UNEXERCISED | concrete held-out variant materialization | Frozen rationale retained: Canonical/metamorphic/boundary evidence is sufficient for Slice 1; held-out materialization may occur after implementation path exists |
| S1-GLOBAL-FIXTURE | REQUIRED | PASS | fixture write-set audit for every executable canonical subcase | Sections 3–4: 1,948 fixture audits plus source inspection of every canonical setup and challenge route. |
| S1-GLOBAL-KNOWLEDGE | REQUIRED | PASS | direct-participant knowledge of Declined/Unable/Invalidated and bounded reasons where accepted semantics require it | [E02](#e02) |
| S1-GLOBAL-ORACLE | REQUIRED | PASS | independent-oracle restrictions are obeyed for every row using an independent checker | Section 4; E37 and E41; full checker/scenario dependency audit and corrupt-witness adequacy controls. |
| S1-GLOBAL-FALLBACK | REQUIRED | PASS | stable-ID fallback use is logged and sensitivity is confined to explicit fallback cases | [E27](#e27), [E31](#e31), [E38](#e38), [E39](#e39), [E43](#e43), [E44](#e44), [E48](#e48), [E50](#e50), [E59](#e59), [E60](#e60) |
| S1-GLOBAL-ITERATION | REQUIRED | PASS | nonsemantic collection/input iteration does not determine semantic outcome | [E32](#e32) |
| S1-GLOBAL-CALLFAVOR-MAP | REQUIRED | PASS | executable payload validation matches the frozen Slice-1 CallFavor action applicability table | [E21](#e21) |
| S1-GLOBAL-REQUIRED-COVERAGE | REQUIRED | PASS | zero REQUIRED manifest rows are missing or skipped | All 167 unique rows reconciled here; 127 implementation obligations plus this independently awarded K4 obligation, zero missing/skipped REQUIRED. |
| S1-GLOBAL-MANIFEST-INTEGRITY | REQUIRED | PASS | manifest bytes/version match the frozen dispatch baseline | Section 2: independent raw Git blob, freeze/current/candidate byte comparison and exact census. |
| S1-GLOBAL-CONFORMANCE | REQUIRED | PASS | fresh independent conformance review passes | This fresh Amorite report; all seven K4 conclusions, independent probes and final identity checks. |

## 7. Final disposition and return

**PASS for candidate-v3 `06e25644879dd8505e24fcaeb43256f69c29c15f` only.** No blockers remain in this K4 review. A later production/test/evidence-mapping or authority change is outside this verdict and requires the candidate/review treatment prescribed by the packet.

Return branch: `review/imp-0001-independent-conformance-v3-return`, based on current origin/main recorded above. Its sole repository addition is `research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`. The detached candidate remains unchanged. PR #7, #16 and #23 remain draft/unmerged; no merge, promotion, candidate ref movement or Birth Run was performed.

The task deliverables include this report, a Git return bundle, and a supporting evidence ZIP containing canonical logs/results, start/finish identities, remote ZIP/log/metadata and comparison, the independent ledger/baseline, and complete reviewer sources/results. The implementation's ignored acceptance files are preserved unchanged as evidence. The Master Architect can integrate the one-file report and perform the final completion/promotion reconciliation.

## Appendix A. Source-linked substantive evidence audit

Each entry states what the reviewer checked in the actual assertions/setup against accepted source clauses. The complete manifest ledger above identifies the rows each entry supports.

<a id="e01"></a>

**E01 — GiftHelpMeaningsAndNeedClearing** ([PipelineScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L10)). Both initiation directions reach the same recipient/giver roles, explicit Gift/Help histories and +10 consequence without Debt/Favour creation. The received unit clears need; Farm occurs only on the following cycle.

<a id="e02"></a>

**E02 — ResponseAutonomyAndBoundedFailureKnowledge** ([PipelineScenarios.cs:28](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L28)). Pinned accept/decline profiles change the target choice while holding the request fixed. Infeasibility bypasses scoring. Separate expected attitude values and participant-only bounded knowledge distinguish Committed, Declined and Unable.

<a id="e03"></a>

**E03 — SharedSnapshotScarceGrain** ([PipelineScenarios.cs:58](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L58)). Two accept decisions use one snapshot; immediate revalidation allows one transfer and invalidates the other without a refusal penalty or retry. Fixed-ID reversed inputs preserve the winner and both fallback markers.

<a id="e04"></a>

**E04 — GiftGrainIngress** ([PipelineScenarios.cs:82](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/PipelineScenarios.cs#L82)). Offer and request ingresses each exercise -1/0/1, with no response, participant knowledge or action effect for invalid terms. Public long fields make fractional terms unrepresentable without an external explicit conversion.

<a id="e05"></a>

**E05 — LoanRoutesAndRepaymentHistory** ([DebtScenarios.cs:9](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L9)). Offer/request loan roles and amounts are checked independently. Partial then full repayment conserves grain, produces the lender's +5 consequence, retains the original claim ID/origin and preserves repayment history.

<a id="e06"></a>

**E06 — RepaymentAmountAndReserve** ([DebtScenarios.cs:38](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L38)). Explicit expected outcomes cover invalid/remaining/over-remaining amounts and stocks that would finish below/at/above two. Only repayment has this reserve; invalid terms remain distinct from material inability.

<a id="e07"></a>

**E07 — DebtDueAfterThirdFullCycle** ([DebtScenarios.cs:64](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L64)). Both materially able and unable debtors retain the debt and receive one N+3 social consequence. A payment in N+3 precedes due review and avoids the unpaid penalty; subsequent cycles do not repeat it.

<a id="e08"></a>

**E08 — LoanGrainIngress** ([DebtScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/DebtScenarios.cs#L89)). Separate offer/request cases reject -1 and zero before response or debt creation and allow the unit positive control. The typed amount surface supplies the fractional structural evidence.

<a id="e09"></a>

**E09 — ExplicitBargainAndReciprocalHelp** ([FavourScenarios.cs:16](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L16)). Bargain creates one directed claim without Gift attitude semantics. Reciprocity tests 74/75/76 with and without kinship; stored attitude, rather than multiplied score, controls creation.

<a id="e10"></a>

**E10 — FullFavourSlotDistinguishesBargainFromHelp** ([FavourScenarios.cs:37](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L37)). An existing claim is built through a real bargain. A second bargain is Unable before scoring and transfers nothing; reciprocal help still commits, adds its own attitude cause, and leaves exactly one claim.

<a id="e11"></a>

**E11 — BargainCapacityRace** ([FavourScenarios.cs:52](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L52)). A reciprocal-help request fills the pair slot after both snapshot responses accept. The losing bargain invalidates atomically, preserving the first transfer only and producing no bargain-derived Gift consequence.

<a id="e12"></a>

**E12 — CalledFarmSuccessRefusalAndInability** ([FavourScenarios.cs:70](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L70)). Fulfil/refuse profiles independently select the expected response; only successful Farm consumes the claim and yields +10. Refusal retains it with -20; prior need yields Unable, no scored winner and no called consequence.

<a id="e13"></a>

**E13 — CalledFarmPersonalCoexistence** ([FavourScenarios.cs:96](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L96)). Called and ordinary Farm commit in one cycle with two +4 effects and only one response context. This is the approved response-scoped additional effect, not a second voluntary initiative.

<a id="e14"></a>

**E14 — CalledRepaymentThirdPartyAndInvalidation** ([FavourScenarios.cs:106](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L106)). Wrapped repayment pays the actual third-party creditor without requesting another choice. A competing spend can remove reserve before commit; the call then retains its favour and produces neither fulfilment nor refusal consequences.

<a id="e15"></a>

**E15 — ReciprocalCancellation** ([FavourScenarios.cs:126](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L126)). Both claims are created by committed bargains. One unilateral cancellation retires both atomically with no material transfer, response or replacement claim.

<a id="e16"></a>

**E16 — BenefitGrainIngress** ([FavourScenarios.cs:136](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/FavourScenarios.cs#L136)). BFF and reciprocal material terms independently exercise invalid and valid integer quantities. The same inspected public validator covers the reciprocal request form, additionally challenged by reviewer C3.

<a id="e17"></a>

**E17 — DirectMarriageBoundaries** ([MarriageResidenceScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L10)). All 74/75/76 combinations and both kinship exclusions are exercised. Success creates one marriage without dowry, favour or residence effects; eligibility failures preserve those states.

<a id="e18"></a>

**E18 — MarriageDeclineAndLifetime** ([MarriageResidenceScenarios.cs:31](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L31)). Declining preserves eligibility and attitude, so a later accepted proposal succeeds. Repeated establishment and a different groom are then blocked by existing marriage capacity.

<a id="e19"></a>

**E19 — ResidenceMoveInviteAndConflict** ([MarriageResidenceScenarios.cs:47](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L47)). Both public residence routes change only the intended residence. Competing invitations retain both accepts, commit once, invalidate the other with the prescribed reason and disclose fallback under fixed-ID input reversal.

<a id="e20"></a>

**E20 — MarriageDowryIngress** ([MarriageResidenceScenarios.cs:75](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L75)). The direct-bypass proposal still validates its grain term before bride response. Invalid quantities cause no marriage or social outcome; a valid term creates no dowry movement.

<a id="e21"></a>

**E21 — CompleteCallFavorPayloadMatrix** ([MarriageResidenceScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L89)). The expected non-callable set is transcribed from the frozen action table, not the production classifier. All eleven shapes reject before response; response/result/material/event types do not derive from ActionTerms.

<a id="e22"></a>

**E22 — NestedRepaymentIngress** ([MarriageResidenceScenarios.cs:111](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/MarriageResidenceScenarios.cs#L111)). Direct and wrapped repayments cover negative/zero, remaining-1, remaining and remaining+1. Invalid nested terms retain the outer claim, activate no response and do not clamp debt.

<a id="e23"></a>

**E23 — GeneratedActionVocabularyAndRepaymentTarget** ([AgencyScenarios.cs:10](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L10)). The recorded personal candidate set exposes every current action meaning, both callable shapes and a blocked bargain. The debtor's repayment target is the creditor and the known relation supplies the expected exact component.

<a id="e24"></a>

**E24 — ExactKinScoringAndFullTrace** ([AgencyScenarios.cs:30](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L30)). Independent 2a/3a arithmetic verifies kin amplification without altering stored attitude. The trace preserves excluded and scored alternatives, actual selection, input provenance, profile and proposal linkage across later cycles.

<a id="e25"></a>

**E25 — CoResidenceMotivationWithoutCompulsion** ([AgencyScenarios.cs:63](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L63)). The pinned 20/40 components establish marriage motivation above mutual strong-like motivation. Counterparty refusal leaves residence unchanged despite the selected high-scoring proposal.

<a id="e26"></a>

**E26 — PersonalResidenceAndIncomingResponse** ([AgencyScenarios.cs:85](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L85)). One personal residence decision and a separate incoming help response coexist for the same actor. Both compatible effects commit through central resolution with no duplicated initiative.

<a id="e27"></a>

**E27 — ReferenceProfilesAndAutonomousCycle** ([AgencyScenarios.cs:102](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AgencyScenarios.cs#L102)). A uniquely scored gift is unmarked; an exact candidate tie is marked. Autonomous activation produces one personal context per actor, while the declared profile coefficients remain laboratory configuration.

<a id="e28"></a>

**E28 — DirectAttitudeCompositionAndPermutation** ([CrossCuttingScenarios.cs:15](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L15)). Independent expected +85/-100 results and retained +10/-20 causes test one clamp after summation. Reversed cause processing preserves history; deliberately sequential-clamp witnesses fail independent replay.

<a id="e29"></a>

**E29 — DuplicateReactionAndPrematureClosure** ([CrossCuttingScenarios.cs:48](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L48)). Actual internal challenge seams inject duplicate causes and suppress closure. One contribution survives duplication; the specific pending-reaction guard prevents stable publication and continuation after suppressed closure. This is not generic crash credit.

<a id="e30"></a>

**E30 — MaterialDeadlockAndNegativeControls** ([CrossCuttingScenarios.cs:65](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L65)). All-zero need blocks Farm without rescue. Current transfer and scheduled positive input supply negative controls; reviewer A and the v3 cases extend these to complete signed schedules and ordinary fault timing.

<a id="e31"></a>

**E31 — StableFallbackSensitivityAndSemanticAsymmetry** ([CrossCuttingScenarios.cs:82](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L82)). Swapping competing invitation IDs changes only the disclosed arbitrary winner; fixed-ID execution is repeatable. Making one invitation infeasible removes the accepted competition and all fallback markers.

<a id="e32"></a>

**E32 — ReplayStorageInputObserverAndAttributePairs** ([CrossCuttingScenarios.cs:99](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L99)). Six-cycle runs compare complete canonical state/history/decisions/knowledge under storage/input reversal, observer reads, display-name changes and Turkish culture. Observer checks do not assert that a mutation was injected.

<a id="e33"></a>

**E33 — IdentityIsomorphismAndDisconnectedLocality** ([CrossCuttingScenarios.cs:130](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L130)). Renamed person IDs and an added disconnected actor preserve the named local semantic projection and knowledge. No fallback is present in the compared gift trajectory; incidental global event numbering is excluded from the isomorphism.

<a id="e34"></a>

**E34 — NoDerivedAuthorityStructuralAudit** ([CrossCuttingScenarios.cs:153](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L153)). The field inventory contains authoritative records and the relation-ID frontier, not a behavior cache. Queries recompute from immutable snapshots, and prior snapshots remain unchanged. Full production inspection supports the manifest's structural alternative.

<a id="e35"></a>

**E35 — DistinctTransferMeanings** ([CrossCuttingScenarios.cs:167](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/CrossCuttingScenarios.cs#L167)). Comparable transfers independently check event meaning, per-leg labels, material deltas, attitude deltas and distinct debt/favour creation. Shared transfer arithmetic does not erase social meaning.

<a id="e36"></a>

**E36 — FixedAttitudeEventMatrix** ([AttitudeEventScenarios.cs:11](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L11)). Every fixed event consequence is checked, including due review combined with a gift and zero-effect marriage refusal. Supplementary repair cases close all ordinary-request refusal shapes and mandatory-cause completeness.

<a id="e37"></a>

**E37 — AggregateCapacityAndIndependentLedgerFault** ([AttitudeEventScenarios.cs:54](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/AttitudeEventScenarios.cs#L54)). Three requests exceed one donor's total capacity even though individual requests fit. The last invalidates, every contender is marked, reversal preserves results, and a corrupt material witness fails replay.

<a id="e38"></a>

**E38 — RepairResidenceDestinationDependency** ([RepairScenarios.cs:12](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L12)). Moving a destination owner can invalidate an already accepted mover. ID exchange changes the dependent outcome, with both proposals marked; fixed-ID storage reversal cannot change it.

<a id="e39"></a>

**E39 — RepairCallCancellationDependency** ([RepairScenarios.cs:28](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L28)). Called Farm and reciprocal cancellation compete over the same existing claim. Either ordering leaves the correct residual claim set and bounded invalidation, and both actual order participants are marked.

<a id="e40"></a>

**E40 — RepairNeedyReciprocalRequestRefusal** ([RepairScenarios.cs:48](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L48)). Gift/help, loan and reciprocal requests all apply -5 only for genuine need and voluntary refusal. Unable, invalidated and offered-help controls do not acquire the request penalty.

<a id="e41"></a>

**E41 — RepairMissingMandatoryAttitudeCause** ([RepairScenarios.cs:72](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L72)). The oracle derives the mandatory cause set independently from outcomes and need. Removing a cause while coherently adjusting final attitude, or removing the whole composition, is rejected; self-consistent incompleteness cannot pass.

<a id="e42"></a>

**E42 — RepairHiddenCounterpartyGrain** ([RepairScenarios.cs:89](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairScenarios.cs#L89)). Changing unobserved counterparty stock changes objective feasibility but leaves the needy actor's complete personal trace and request choice identical.

<a id="e43"></a>

**E43 — RepairResidenceReadWriteMatrix** ([RepairResolutionScenarios.cs:25](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L25)). Reachable mover/destination-owner combinations distinguish dependency from shared destination alone. The latter commutes and stays unmarked; the two-initiative impossible combination is excluded structurally.

<a id="e44"></a>

**E44 — RepairMarriageCapacityPermutation** ([RepairResolutionScenarios.cs:52](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L52)). Two eligible grooms sharing a bride create one marriage and one eligibility invalidation with both contenders marked. ID changes choose the alternative; storage changes do not.

<a id="e45"></a>

**E45 — RepairFavourCreationProvenance** ([RepairResolutionScenarios.cs:71](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L71)). Two help forms can both commit yet compete over which event originates the one new claim. Empty and bargain cases are marked; full-slot and below-gate cases retain their genuinely commuting outcomes unmarked.

<a id="e46"></a>

**E46 — RepairFavourRetirementDependencies** ([RepairResolutionScenarios.cs:104](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L104)). Calls, reciprocal cancellation and conditional recreation are paired across Farm and repayment payloads. Outcomes retain concrete retired identities and creator provenance, including valid recreation only after retirement.

<a id="e47"></a>

**E47 — RepairAggregateDebtCapacity** ([RepairResolutionScenarios.cs:135](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L135)). Three payments jointly exceed remaining debt while pairs fit. The debt cap determines how many commit; the last payment invalidates and any corresponding called favour remains outstanding.

<a id="e48"></a>

**E48 — RepairAggregateGrainAndEnablers** ([RepairResolutionScenarios.cs:159](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L159)). Aggregate material contention is tested with insufficient and sufficient stocks, plus gift/Farm/called-Farm credits. Real enabling order changes are marked; sufficient compatible spending is not.

<a id="e49"></a>

**E49 — RepairTransferShapesAndReserve** ([RepairResolutionScenarios.cs:196](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L196)). All nine transfer forms, including wrapped repayment, share material contention tests. The effective debtor and two-unit repayment reserve are retained while ordinary transfers have no generic reserve.

<a id="e50"></a>

**E50 — RepairCommutingAndAsymmetricControls** ([RepairResolutionScenarios.cs:234](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairResolutionScenarios.cs#L234)). Opposing gifts, disjoint marriages and already-funded spending commute unmarked. A snapshot-infeasible request never becomes an accepted fallback participant.

<a id="e51"></a>

**E51 — RepairHiddenWorldFacts** ([RepairKnowledgeScenarios.cs:14](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L14)). Unobserved stock, need, sex, home, unrelated marriage, kinship and attitude perturbations preserve personal candidate/score/input traces. Explicitly known direct-party relations remain legitimate inputs.

<a id="e52"></a>

**E52 — RepairExplicitSexAndResidenceObservations** ([RepairKnowledgeScenarios.cs:34](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L34)). Identity bindings reveal no sex/home implicitly. Explicit observations enable their corresponding routes; stale home observations preserve deliberation while objective feasibility can differ.

<a id="e53"></a>

**E53 — RepairObservedDebtBoundary** ([RepairKnowledgeScenarios.cs:71](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L71)). Only directly held or explicitly observed claims enter called-repayment deliberation. An unrelated unobserved claim and changes to its quantity cannot affect the personal trace.

<a id="e54"></a>

**E54 — RepairCalledPayloadPrivateFeasibility** ([RepairKnowledgeScenarios.cs:94](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L94)). The holder's generated call uses known claim facts without reading the debtor's private stock/need. Later objective feasibility may return Unable and retains the claim; no new voluntary context appears.

<a id="e55"></a>

**E55 — RepairPersonalInputIsolationAndTrace** ([RepairKnowledgeScenarios.cs:115](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairKnowledgeScenarios.cs#L115)). Source and structural checks show only the capture boundary receives objective state. The immutable captured view preserves actual observed values and direct-claim provenance even after subsequent commits.

<a id="e56"></a>

**E56 — RepairV3FutureFaultTiming** ([RepairV3Scenarios.cs:106](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairV3Scenarios.cs#L106)). A future impossible debit or checked overflow does not fault the present diagnostic. Execution faults at the scheduled cycle and retains the previous published snapshot. This agrees with the v3 packet's explicit timing requirement.

<a id="e57"></a>

**E57 — RepairV3DistantInputBoundary** ([RepairV3Scenarios.cs:130](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairV3Scenarios.cs#L130)). Signed input batches at long.MaxValue discriminate cancellation from surviving recovery without iterating empty cycles, moving live time, emitting events or faulting now.

<a id="e58"></a>

**E58 — RepairV3FutureMaterialRecovery** ([RepairV3Scenarios.cs:145](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairV3Scenarios.cs#L145)). Whole batches, cross-person cancellation and recovery before later reblocking are checked against actual scheduled execution and storage reversal. Reviewer BigInteger enumeration supplies a separate expectation mechanism.

<a id="e59"></a>

**E59 — RepairV3DebtLimitedCommutingFarm** ([RepairV3Scenarios.cs:191](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairV3Scenarios.cs#L191)). All 24 orders and both input enumerations retain two repayments, one debt-cap invalidation, debt 1 and grain 6; the three callers are marked and Farm is not. Reviewer H1 independently reproduces the historical fixture exactly.

<a id="e60"></a>

**E60 — RepairV3IntersectingCapacities** ([RepairV3Scenarios.cs:22](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/RepairV3Scenarios.cs#L22)). Debt, grain and reserve caps are intersected with unequal payment amounts and ordinary-help alternatives. Farm/gift/loan/reciprocal credits exercise both consequential and irrelevant enablers over every order; independent reviewer arithmetic additionally covers small credits and direct repayment.

<a id="e61"></a>

**E61 — ConsumptionAndFarm** ([Scenarios.cs:36](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L36)). Paying the last unit does not itself cause need; the next missed maintenance does and blocks Farm. A valid Farm has exactly +4 and an explicit source; immutable earlier snapshots remain unchanged.

<a id="e62"></a>

**E62 — DecayBoundaries** ([Scenarios.cs:55](https://github.com/Classique-Smokes/Mesopotamia-Sim/blob/06e25644879dd8505e24fcaeb43256f69c29c15f/tests/Mesopotamia.Sim.AcceptanceTests/Scenarios.cs#L55)). Positive and negative near-zero/boundary values are checked before, at and after the five-cycle cadence. The accepted -2/+1 approach to zero neither crosses zero nor enters the direct-cause sum.


## Appendix B. Reproduction and retained evidence

Use SDK 10.0.401 and preserve this layout after extracting the supporting ZIP: `candidate-v3/`, `probes/`, `evidence/`. Clone the repository into candidate-v3 and detach exactly at the reviewed SHA. Run the four canonical commands from that root, then run `dotnet run --project probes/Amorite.Probes.csproj --configuration Release` from their shared parent. The probe project references the Release production DLL directly; no candidate project/test modification or friend access is needed. Its JSON is written to `evidence/reviewer-probes.json`; process exit 0 requires every probe case to pass.

The full source below is embedded so the one-file repository return retains reproducible reviewer evidence even if the task ZIP is unavailable. The runner records the first thrown assertion/exception within each case as a failure, continues with the remaining cases, and exits nonzero if any case failed. Exceptions and timeouts receive no semantic success credit. Supporting SHA-256 hashes are in the evidence inventory delivered with the ZIP.

### global.json

```json
{"sdk":{"version":"10.0.401","rollForward":"disable","allowPrerelease":false}}
```

### Amorite.Probes.csproj

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings><Nullable>enable</Nullable>
  </PropertyGroup>
  <ItemGroup><Reference Include="Mesopotamia.Sim"><HintPath>../candidate-v3/src/Mesopotamia.Sim/bin/Release/net10.0/Mesopotamia.Sim.dll</HintPath></Reference></ItemGroup>
</Project>
```

### Program.cs

```csharp
using System.Collections.Immutable;
using System.Numerics;
using System.Text.Json;
using Mesopotamia.Sim;

internal static partial class Program
{
    static readonly List<object> Evidence = [];
    static int worlds, assertions, failures;
    static void Check(bool condition, string detail)
    {
        assertions++;
        if (!condition) throw new Exception(detail);
    }
    static void Case(string name, Action action)
    {
        int before = worlds, checks = assertions;
        try { action(); Evidence.Add(new { name, state="PASS", worlds=worlds-before, assertions=assertions-checks }); }
        catch(Exception ex) { failures++; Evidence.Add(new { name, state="FAIL", worlds=worlds-before, assertions=assertions-checks, error=ex.ToString() }); }
        Console.WriteLine(name+" completed");
    }
    static InitialWorld World(params long[] grains) => new(
        grains.Select((g,i)=>new Person(new(i+1), "P"+(i+1), i%2==0?Sex.Male:Sex.Female,g)).ToImmutableArray(),
        grains.Select((_,i)=>new Dwelling(new(i+1))).ToImmutableArray(),
        grains.Select((_,i)=>new Residence(new(i+1),new(i+1),new(i+1))).ToImmutableArray(),[],[],[],[],new("AMORITE-K4-v1"));
    static Simulation Create(InitialWorld world) { worlds++; return new(world); }
    static Proposal P(long id,long actor,ActionTerms terms)=>new(new(id),new(actor),terms);
    static void Main()
    {
        Case("A1.NamedRecoveryAndFaultTiming", RecoveryNamed);
        Case("A2.BoundedSignedScheduleEnumeration", RecoveryEnumeration);
        Case("B1.DebtGrainEnablerPermutationMatrix", DebtMatrix);
        Additional();
        File.WriteAllText(Path.Combine(AppContext.BaseDirectory,"../../../../evidence/reviewer-probes.json"), JsonSerializer.Serialize(new { reviewer="Amorite",candidate="06e25644879dd8505e24fcaeb43256f69c29c15f",worlds,assertions,failures,cases=Evidence},new JsonSerializerOptions{WriteIndented=true}));
        Console.WriteLine($"TOTAL worlds={worlds} assertions={assertions} failures={failures}");
        Environment.ExitCode=failures==0?0:1;
    }
    static partial void Additional();

    // Independent reduction of SPEC 2.2/9.1/9.5 from an all-zero blocked boundary:
    // absent voluntary action, the first executable complete batch with a positive
    // surviving stock pays maintenance and opens a farming decision boundary.
    // BigInteger distinguishes arithmetic failure without production helpers.
    static bool RecoveryExpected(GrainInput[] inputs,int actors)
    {
        BigInteger[] balances=new BigInteger[actors];
        foreach(var group in inputs.OrderBy(x=>x.Cycle).GroupBy(x=>x.Cycle))
        {
            foreach(var x in group.OrderBy(x=>x.Id))
            {
                int i=(int)x.Person.Value-1;
                balances[i]+=x.Delta;
                if(balances[i]<0 || balances[i]>long.MaxValue) return false;
            }
            if(balances.Any(x=>x>0))return true;
        }
        return false;
    }
    static void Recovery(GrainInput[] inputs,int actors,bool? expected=null)
    {
        var initial=World(Enumerable.Repeat(0L,actors).ToArray()) with { Inputs=[..inputs] };
        var sim=Create(initial);
        var result=sim.RunCycle(CycleInput.Empty);
        bool expectedRecovery=expected??RecoveryExpected(inputs,actors);
        Check(result.MaterialDeadlock==!expectedRecovery,"Recovery classification: "+JsonSerializer.Serialize(inputs));
        Check(!sim.IsFaulted && result.State.Cycle==1,"Projection faulted current cycle");
        Check(result.State.People.Values.All(p=>p.Grain==0&&p.NeedsGrain),"Projection mutated people");
        Check(result.Events.Length==actors && result.Events.All(e=>e.Kind=="MissedConsumption"),"Projection emitted authoritative events");
        Check(result.Decisions.Length==0,"Projection activated future voluntary choice");
    }
    static void RecoveryNamed()
    {
        Recovery([],2,false);
        Recovery([new(1,2,new(1),1)],2,true);
        Recovery([new(1,2,new(1),1),new(2,2,new(1),-1)],2,false);
        Recovery([new(1,2,new(1),2),new(2,2,new(1),-1)],2,true);
        Recovery([new(1,2,new(1),1),new(2,2,new(2),1),new(3,2,new(1),-1),new(4,2,new(2),-1)],2,false);
        Recovery([new(1,2,new(1),-1),new(2,3,new(2),2)],2,false);
        Recovery([new(1,2,new(1),2),new(2,3,new(1),-100)],2,true);
        Recovery([new(1,long.MaxValue,new(1),1)],2,true);
        Recovery([new(1,long.MaxValue,new(1),1),new(2,long.MaxValue,new(1),-1)],2,false);
        Recovery([new(1,2,new(1),long.MaxValue),new(2,2,new(1),1)],2,false);
        foreach(bool overflow in new[]{false,true})
        {
            GrainInput[] schedule=overflow?[new(1,3,new(1),long.MaxValue),new(2,3,new(1),1)]:[new(1,3,new(1),-1),new(2,4,new(1),2)];
            var sim=Create(World(0) with{Inputs=[..schedule]});
            Check(sim.RunCycle(CycleInput.Empty).MaterialDeadlock,"Fault prefix incorrectly proves recovery");
            sim.RunCycle(CycleInput.Empty);
            bool thrown=false;
            try{sim.RunCycle(CycleInput.Empty);}catch(Exception e)when(e is OverflowException or InvalidOperationException){thrown=true;}
            Check(thrown&&sim.IsFaulted&&sim.Snapshot.Cycle==2,"Future fault timing or stable snapshot violated");
        }
        var recovered=Create(World(0) with{Inputs=[new(1,2,new(1),1)]});
        Check(!recovered.RunCycle(CycleInput.Empty).MaterialDeadlock,"Earlier recovery lost");
        var boundary=recovered.RunCycle(CycleInput.Empty);
        Check(!boundary.State.People[new(1)].NeedsGrain&&boundary.State.People[new(1)].Grain==0,"Recovery boundary wrong");
        Check(recovered.RunCycle(CycleInput.Empty).MaterialDeadlock,"Later reblocking not diagnosed");
    }
    static void RecoveryEnumeration()
    {
        foreach(long a in new[]{-2L,-1,0,1,2,3})
        foreach(long b in new[]{-2L,-1,0,1,2,3})
        foreach(long c in new[]{-2L,-1,0,1,2,3})
        for(int target=0;target<8;target++)
        {
            GrainInput[] schedule=[new(1,2,new((target&1)+1),a),new(2,2,new(((target>>1)&1)+1),b),new(3,3,new(((target>>2)&1)+1),c)];
            Recovery(schedule,2);
            Recovery(schedule.Reverse().ToArray(),2);
        }
    }
    static IEnumerable<int[]> Permutations(int[] items)
    {
        if(items.Length==0){yield return [];yield break;}
        foreach(int i in items)foreach(var tail in Permutations(items.Where(x=>x!=i).ToArray()))yield return [i,..tail];
    }
    static (string[] outcomes,long grain,long debt) ArithmeticOrder(int[] order,long grain,long debt,long credit)
    {
        string[] results=new string[4];
        foreach(int index in order)
        {
            if(index==3){grain+=credit;results[index]="Committed";}
            else if(debt<2) results[index]="RepaymentExceedsRemaining";
            else if(grain<4) results[index]="RepaymentReserveUnavailable";
            else {debt-=2;grain-=2;results[index]="Committed";}
        }
        return(results,grain,debt);
    }
    static string OrderSignature(int[] order,long grain,long debt,long credit)
    {
        var x=ArithmeticOrder(order,grain,debt,credit);
        return string.Join(';',x.outcomes)+":"+x.grain+":"+x.debt;
    }
    static void DebtMatrix()
    {
        int[][] orders=Permutations([0,1,2,3]).ToArray();
        foreach(long debt in new[]{3L,5,6})
        foreach(long grain in new[]{4L,5,6,7,8})
        foreach(var mode in new[]{("farm",4L,false),("credit1",1L,false),("credit4",4L,false),("credit2-ordinary",2L,true)})
        {
            HashSet<int> expectedMarked=[];
            foreach(var order in orders)for(int adjacent=0;adjacent<3;adjacent++)
            {
                int[] swap=[..order];(swap[adjacent],swap[adjacent+1])=(swap[adjacent+1],swap[adjacent]);
                if(OrderSignature(order,grain,debt,mode.Item2)!=OrderSignature(swap,grain,debt,mode.Item2))
                    expectedMarked.UnionWith([order[adjacent],order[adjacent+1]]);
            }
            foreach(var order in orders)foreach(bool reverse in new[]{false,true})
            {
                var sim=Create(World(0,50,50,50,50,50) with {Inputs=[new(1,2,new(1),grain-debt-2)]});
                var setup=sim.RunCycle(new([P(1,3,new OfferBenefitForFavor(new(1),1)),P(2,4,new OfferBenefitForFavor(new(1),1)),P(3,5,new OfferBenefitForFavor(new(1),1)),P(4,2,new OfferLoan(new(1),debt))]));
                Check(setup.Outcomes.All(o=>o.Kind==OutcomeKind.Committed),"Probe setup failed");
                var claim=sim.Snapshot.Debts.Values.Single();
                Proposal[] proposals=new Proposal[4];
                for(int position=0;position<4;position++)
                {
                    int index=order[position];long id=100+position;
                    if(index==3)proposals[index]=mode.Item1=="farm"?P(id,1,new Farm()):P(id,6,new OfferGift(new(1),mode.Item2));
                    else if(index==2&&mode.Item3)proposals[index]=P(id,1,new RepayDebt(claim.Id,2));
                    else {var f=sim.Snapshot.Favours.Values.Single(f=>f.Holder.Value==index+3);proposals[index]=P(id,index+3,new CallFavor(f.Id,new RepayDebt(claim.Id,2)));}
                }
                var result=sim.RunCycle(new([..reverse?proposals.Reverse():proposals]));
                var expected=ArithmeticOrder(order,grain,debt,mode.Item2);
                string context=$"mode={mode.Item1} debt={debt} grain={grain} order={string.Join(',',order)}";
                for(int i=0;i<4;i++)
                {
                    var outcome=result.Outcomes.Single(o=>o.Proposal==proposals[i].Id);
                    string actual=outcome.Kind==OutcomeKind.Committed?"Committed":outcome.Reason;
                    Check(expected.outcomes[i]==actual,"Outcome mismatch "+context);
                    var ev=result.Events.Single(e=>e.Id==outcome.Event);
                    Check(ev.TechnicalFallback==expectedMarked.Contains(i),$"Fallback mismatch i={i} expected={expectedMarked.Contains(i)} actual={ev.TechnicalFallback} "+context);
                    if(i<3&&!(i==2&&mode.Item3))Check(result.State.Favours.Values.Single(f=>f.Holder.Value==i+3).Outstanding==(actual!="Committed"),"Favour consumption "+context);
                }
                Check(result.State.People[new(1)].Grain==expected.grain&&result.State.Debts[claim.Id].Remaining==expected.debt,"Material/debt "+context);
                Check(result.Decisions.Count(d=>d.Context=="Response")== (mode.Item1=="farm"?3:mode.Item3?3:4),"Nested response "+context);
            }
        }
    }
}
```

### Additional.cs

```csharp
using System.Collections.Immutable;
using System.Text.Json;
using Mesopotamia.Sim;

internal static partial class Program
{
    static partial void Additional()
    {
        Case("B2.ResidencePairInteractionEnumeration", ResidencePairs);
        Case("B3.FavourProvenanceAndRetirement", FavourInteractions);
        Case("B4.MarriageResidenceAndMaterialCommutingControls", Commuting);
        Case("C1.NeedRefusalAndFailureKnowledge", Refusal);
        Case("C2.PersonalSubjectiveIsolation", Subjective);
        Case("C3.GrainIngressAndCallFavorClosure", GrainIngress);
        Case("C4.MixedAttitudeAndInitiative", AttitudeAndInitiative);
        Case("C5.ExplicitBargainAtomicity", Bargain);
        Case("H1.ExactHistoricalCounterexamples", Historical);
    }
    static bool Marked(CycleResult r,ProposalId id)=>r.Events.Single(e=>e.Id==r.Outcomes.Single(o=>o.Proposal==id).Event).TechnicalFallback;
    static InitialWorld Attitudes(InitialWorld initial,params (int from,int to,int value)[] facts)=>initial with
    {Attitudes=facts.Select((a,i)=>new Attitude(new(100+i),new(a.from),new(a.to),a.value)).ToImmutableArray()};
    static int Att(CycleResult r,int from,int to)=>r.State.Attitudes.Values.SingleOrDefault(a=>a.From.Value==from&&a.To.Value==to)?.Value??0;
    record Move(int Actor,int Target,bool Invite)
    {
        public int Mover=>Invite?Target:Actor;
        public int Owner=>Invite?Actor:Target;
        public ActionTerms Terms=>Invite?new InviteResidence(new(Target),new(Actor)):new MoveResidence(new(Target),new(Target));
    }
    static (string[] outcomes,int[] homes) ResidenceExpected(Move[] moves,int[] order)
    {
        int[] homes=[1,2,3,4];HashSet<int> moved=[];string[] outcomes=new string[moves.Length];
        foreach(int index in order)
        {
            var m=moves[index];string loss=moved.Contains(m.Mover)?"CompetingResidenceTransition":
                homes[m.Owner-1]!=m.Owner?"ResidenceDestinationChanged":homes[m.Mover-1]==m.Owner?"AlreadyAtDestination":"";
            outcomes[index]=loss;
            if(loss.Length==0){homes[m.Mover-1]=m.Owner;moved.Add(m.Mover);}
        }
        return(outcomes,homes);
    }
    static void ResidencePairs()
    {
        var moves=(from a in Enumerable.Range(1,4) from b in Enumerable.Range(1,4) where a!=b from invite in new[]{false,true} select new Move(a,b,invite)).ToArray();
        for(int i=0;i<moves.Length;i++)for(int j=i+1;j<moves.Length;j++)
        {
            if(moves[i].Actor==moves[j].Actor)continue;
            Move[] pair=[moves[i],moves[j]];
            var ab=ResidenceExpected(pair,[0,1]);var ba=ResidenceExpected(pair,[1,0]);
            bool marked=!ab.outcomes.SequenceEqual(ba.outcomes)||!ab.homes.SequenceEqual(ba.homes);
            foreach(bool rename in new[]{false,true})foreach(bool reverse in new[]{false,true})
            {
                Proposal[] proposals=[P(rename?20:10,pair[0].Actor,pair[0].Terms),P(rename?10:20,pair[1].Actor,pair[1].Terms)];
                var r=Create(World(20,20,20,20)).RunCycle(new([..reverse?proposals.Reverse():proposals]));
                var expected=rename?ba:ab;
                for(int k=0;k<2;k++)
                {
                    var outcome=r.Outcomes.Single(o=>o.Proposal==proposals[k].Id);
                    Check(outcome.Reason==expected.outcomes[k],"Residence outcome "+JsonSerializer.Serialize(pair));
                    Check(Marked(r,proposals[k].Id)==marked,"Residence attribution "+JsonSerializer.Serialize(pair));
                }
                foreach(var home in r.State.Residences.Values)Check(home.Dwelling.Value==expected.homes[home.Person.Value-1],"Residence final home");
            }
        }
        foreach(int[] order in Permutations([0,1,2]))
        {
            Move[] chain=[new(1,2,false),new(2,3,false),new(3,4,false)];
            var expected=ResidenceExpected(chain,order);
            var ps=order.Select((i,k)=>P(k+1,chain[i].Actor,chain[i].Terms)).ToArray();
            var r=Create(World(20,20,20,20)).RunCycle(new([..ps.Reverse()]));
            foreach(var p in ps)Check(Marked(r,p.Id),"Three-move chain missing participant");
            foreach(var home in r.State.Residences.Values)Check(home.Dwelling.Value==expected.homes[home.Person.Value-1],"Three-move chain final home");
        }
    }
    static void FavourInteractions()
    {
        foreach(string mode in new[]{"empty","below","full","call-create","cancel-create","call-cancel"})
        foreach(bool rename in new[]{false,true})foreach(bool reverse in new[]{false,true})
        {
            var s=Create(Attitudes(World(50,50,50),(2,1,mode=="below"?74:80)));
            if(mode is not("empty" or "below"))s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1))]));
            if(mode.StartsWith("cancel")||mode=="call-cancel")s.RunCycle(new([P(2,2,new OfferBenefitForFavor(new(1),1))]));
            var initial=s.Snapshot;var old=initial.Favours.Values.SingleOrDefault(f=>f.Holder.Value==1);
            ActionTerms left=mode.StartsWith("call")?new CallFavor(old!.Id,new Farm()):mode=="cancel-create"?new CancelReciprocalFavours(new(2)):new RelationshipMediatedReciprocalHelp(new(2),1);
            ActionTerms right=mode=="call-cancel"?new CancelReciprocalFavours(new(1)):new RelationshipMediatedReciprocalHelp(new(1),1,true);
            Proposal[] ps=[P(rename?20:10,1,left),P(rename?10:20,2,right)];
            var r=s.RunCycle(new([..reverse?ps.Reverse():ps]));
            bool expectedMark=mode is not("full" or "below");
            foreach(var p in ps)Check(Marked(r,p.Id)==expectedMark,"Favour marker "+mode);
            Check(r.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==(mode=="call-cancel"?1:2),"Favour commits "+mode);
            var held=r.State.Favours.Values.Where(f=>f.Holder.Value==1).ToArray();
            if(mode=="empty")
            {
                Check(held.Length==1&&held[0].Outstanding,"Initial reciprocal provenance");
                Check(r.Events.Single(e=>e.Id==held[0].Origin).Proposal!.Value.Value==10,"Creation origin must be first proposal");
            }
            if(mode=="below")Check(held.Length==0,"Below gate created favour");
            if(mode=="full")Check(held.Single().Origin==old!.Origin&&held.Single().Outstanding,"Full-slot help replaced provenance");
            if(mode is "call-create" or "cancel-create")
            {
                Check(!held.Single(f=>f.Id==old!.Id).Outstanding,"Retirement missing");
                Check(held.Length==(rename?1:2)&&held.Count(f=>f.Outstanding)==(rename?0:1),"Recreation depends on retirement order");
            }
            if(mode=="call-cancel")Check(r.State.Favours.Values.Count(f=>f.Outstanding)==(rename?0:1),"Call/cancel residual claim");
        }
    }
    static void Commuting()
    {
        foreach(bool rename in new[]{false,true})foreach(bool reverse in new[]{false,true})
        {
            var w=Attitudes(World(20,20,20,20),(1,2,80),(2,1,80),(3,2,80),(2,3,80));
            foreach(bool contend in new[]{false,true})
            {
                Proposal[] ps=[P(rename?20:10,1,new ProposeMarriage(new(2),1)),P(rename?10:20,3,contend?new ProposeMarriage(new(2),1):new InviteResidence(new(2),new(3)))];
                var r=Create(w).RunCycle(new([..reverse?ps.Reverse():ps]));
                Check(r.State.Marriages.Count==1,"Marriage cardinality");
                Check(r.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==(contend?1:2),"Marriage/residence result");
                foreach(var p in ps)Check(Marked(r,p.Id)==contend,"Marriage/residence false dependency");
            }
            Proposal[] gifts=[P(rename?20:10,1,new OfferGift(new(2),2)),P(rename?10:20,2,new OfferGift(new(1),1))];
            var g=Create(World(20,20)).RunCycle(new([..reverse?gifts.Reverse():gifts]));
            Check(g.State.People[new(1)].Grain==18&&g.State.People[new(2)].Grain==20,"Opposing gift arithmetic");
            Check(g.Events.All(e=>!e.TechnicalFallback),"Commuting gifts overmarked");
        }
    }
    static void Refusal()
    {
        ActionTerms[] terms=[new RequestGiftOrHelp(new(2),1),new RequestLoan(new(2),1),new RelationshipMediatedReciprocalHelp(new(2),1,true)];
        foreach(var term in terms)foreach(long own in new[]{0L,1,2})foreach(bool unable in new[]{false,true})
        {
            var s=Create(World(own,unable?0:20,20));
            var r=s.RunCycle(new([P(1,1,term)]){ResponseProfiles=ImmutableDictionary<PersonId,string>.Empty.Add(new(2),"SCORE-RP-002")});
            Check(r.Outcomes.Single().Kind==(unable?OutcomeKind.Unable:OutcomeKind.Declined),"Refusal outcome");
            Check(Att(r,1,2)==(!unable&&own==0?-5:0),"Need penalty must use missed-consumption state");
            Check(s.KnowledgeOf(new(1)).Length==1&&s.KnowledgeOf(new(2)).Length==1&&s.KnowledgeOf(new(3)).Length==0,"Participant knowledge");
            Check(s.KnowledgeOf(new(1))[0].Reason==(unable?"InsufficientAvailableGrain":"VoluntaryRefusal"),"Bounded reason");
        }
    }
    static void Subjective()
    {
        var baseline=Attitudes(World(30,30,30),(1,2,80),(2,1,80));
        InitialWorld[] variants=[baseline,
            baseline with{People=baseline.People.Select(p=>p.Id.Value==2?p with{Grain=0,NeedsGrain=true}:p).ToImmutableArray()},
            baseline with{People=baseline.People.Select(p=>p.Id.Value==2?p with{Sex=Sex.Male}:p).ToImmutableArray()},
            baseline with{Residences=baseline.Residences.Select(r=>r.Person.Value==2?r with{Dwelling=new(3)}:r).ToImmutableArray()},
            baseline with{Marriages=[new(new(200),new(3),new(2))]},
            baseline with{Attitudes=[..baseline.Attitudes,new(new(200),new(2),new(3),-100)]}];
        var policy=new PersonalPolicy("SCORE-VP-006"){ObservedResidences=ImmutableDictionary<PersonId,DwellingId>.Empty.Add(new(2),new(2)),ObservedSexes=ImmutableDictionary<PersonId,Sex>.Empty.Add(new(2),Sex.Female)};
        string? expected=null;
        foreach(var world in variants)
        {
            var r=Create(world).RunCycle(new([]){PersonalPolicies=ImmutableDictionary<PersonId,PersonalPolicy>.Empty.Add(new(1),policy)});
            var trace=r.Decisions.Single(d=>d.Context=="Personal");
            string serialized=JsonSerializer.Serialize(trace);
            if(expected is null)expected=serialized;else Check(serialized==expected,"Hidden objective input affected personal trace");
            Check(trace.Candidates.Count(c=>c.Eligible)>=2&&trace.SubjectiveInputs.Any(s=>s.StartsWith("ObservedResidence:")),"Trace evidence absent");
            foreach(var c in trace.Candidates.Where(c=>c.Eligible))Check(c.FinalScore==c.Components.Values.Sum(),"Score sum");
        }
        var changed=Create(baseline).RunCycle(new([]){PersonalPolicies=ImmutableDictionary<PersonId,PersonalPolicy>.Empty.Add(new(1),policy with{ObservedResidences=ImmutableDictionary<PersonId,DwellingId>.Empty.Add(new(2),new(3))})});
        Check(JsonSerializer.Serialize(changed.Decisions.Single(d=>d.Context=="Personal"))!=expected,"Observation intervention had no effect");
    }
    static void GrainIngress()
    {
        foreach(long amount in new[]{-1L,0,1})
        {
            ActionTerms[] terms=[new OfferGift(new(2),amount),new RequestGiftOrHelp(new(2),amount),new OfferLoan(new(2),amount),new RequestLoan(new(2),amount),new OfferBenefitForFavor(new(2),amount),new RelationshipMediatedReciprocalHelp(new(2),amount),new RelationshipMediatedReciprocalHelp(new(2),amount,true),new ProposeMarriage(new(2),amount)];
            foreach(var term in terms)
            {
                var s=Create(Attitudes(World(30,30),(1,2,80),(2,1,80)));
                var r=s.RunCycle(new([P(1,1,term)]));
                Check(r.Outcomes.Single().Kind==(amount<=0?OutcomeKind.InvalidTerms:OutcomeKind.Committed),"Term domain "+term);
                if(amount<=0)Check(r.Decisions.Length==0&&s.KnowledgeOf(new(1)).Length==0&&r.State.People.Values.All(p=>p.Grain==29)&&r.State.Favours.Count==0&&r.State.Debts.Count==0&&r.State.Marriages.Count==0,"Invalid ingress effects");
            }
        }
        foreach(long amount in new[]{-1L,0,3,4,5})foreach(bool nested in new[]{false,true})
        {
            var s=Create(World(30,30,30));
            s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1)),P(2,3,new OfferLoan(new(2),4))]));
            var debt=s.Snapshot.Debts.Values.Single();var f=s.Snapshot.Favours.Values.Single();
            var repay=new RepayDebt(debt.Id,amount);
            var r=s.RunCycle(new([P(3,nested?1:2,nested?new CallFavor(f.Id,repay):repay)]));
            bool valid=amount>0&&amount<=4;
            Check(r.Outcomes.Single().Kind==(valid?OutcomeKind.Committed:OutcomeKind.InvalidTerms),"Repayment domain");
            Check(r.State.Debts[debt.Id].Remaining==(valid?4-amount:4),"Repayment balance");
            if(!valid)Check(r.Decisions.Length==0&&r.State.Favours[f.Id].Outstanding,"Invalid called repayment response");
        }
        foreach(var payload in new ActionTerms[]{new OfferGift(new(1),1),new RequestGiftOrHelp(new(1),1),new OfferLoan(new(1),1),new RequestLoan(new(1),1),new OfferBenefitForFavor(new(1),1),new RelationshipMediatedReciprocalHelp(new(1),1),new RelationshipMediatedReciprocalHelp(new(1),1,true),new CancelReciprocalFavours(new(1)),new ProposeMarriage(new(1),1),new MoveResidence(new(1),new(1)),new InviteResidence(new(1),new(2)),new CallFavor(new(1),new Farm())})
        {
            var s=Create(World(30,30));s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1))]));var f=s.Snapshot.Favours.Values.Single();
            var r=s.RunCycle(new([P(2,1,new CallFavor(f.Id,payload))]));
            Check(r.Outcomes.Single().Kind==OutcomeKind.InvalidTerms&&r.Decisions.Length==0&&r.State.Favours[f.Id].Outstanding,"Noncallable payload activated");
        }
    }
    static void AttitudeAndInitiative()
    {
        foreach(int baseline in new[]{95,-95})foreach(bool reverse in new[]{false,true})
        {
            var s=Create(Attitudes(World(30,30),(1,2,baseline)));
            s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1))]));var f=s.Snapshot.Favours.Values.Single();
            Proposal[] ps=[P(2,1,new CallFavor(f.Id,new Farm())),P(3,2,new OfferGift(new(1),1))];
            var r=s.RunCycle(new([..reverse?ps.Reverse():ps]){ProposalResponseProfiles=ImmutableDictionary<ProposalId,string>.Empty.Add(new(2),"SCORE-RP-004")});
            Check(Att(r,1,2)==Math.Clamp(baseline-20+10,-100,100),"Sum then clamp");
            var e=r.Events.Single(e=>e.Kind=="AttitudeComposition");
            Check(e.Contributions.Length==2&&e.Contributions.Select(c=>c.Key).Distinct().Count()==2&&e.Causes.Length==2,"Cause completeness");
        }
        var coexist=Create(World(30,30));coexist.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1))]));var favour=coexist.Snapshot.Favours.Values.Single();
        var both=coexist.RunCycle(new([P(2,1,new CallFavor(favour.Id,new Farm())),P(3,2,new Farm())]));
        Check(both.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==2&&both.Events.Count(e=>e.Kind=="Farm")==2&&both.Decisions.Length==1,"Called and personal initiative");
        bool rejected=false;try{Create(World(30,30)).RunCycle(new([P(1,1,new Farm()),P(2,1,new OfferGift(new(2),1))]));}catch(ArgumentException){rejected=true;}
        Check(rejected,"Duplicate personal initiative accepted");
    }
    static void Bargain()
    {
        foreach(bool rename in new[]{false,true})foreach(bool reverse in new[]{false,true})
        {
            var s=Create(Attitudes(World(20,20),(2,1,80)));
            Proposal[] ps=[P(rename?20:10,2,new RelationshipMediatedReciprocalHelp(new(1),1,true)),P(rename?10:20,1,new OfferBenefitForFavor(new(2),1))];
            var r=s.RunCycle(new([..reverse?ps.Reverse():ps]));
            Check(r.Outcomes.Single(o=>o.Actor.Value==1).Kind==(rename?OutcomeKind.Committed:OutcomeKind.InvalidatedAtResolution),"Bargain slot race");
            Check(r.State.People[new(1)].Grain==(rename?17:18)&&r.State.People[new(2)].Grain==(rename?21:20),"Partial bargain leg");
            Check(r.State.Favours.Count==1&&Att(r,2,1)==90,"Bargain wrongly inherited help attitude");
            foreach(var p in ps)Check(Marked(r,p.Id),"Bargain provenance attribution");
        }
        foreach(bool help in new[]{false,true})
        {
            var s=Create(World(20,20));s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1))]));
            var r=s.RunCycle(new([P(2,1,help?new RelationshipMediatedReciprocalHelp(new(2),1):new OfferBenefitForFavor(new(2),1))]));
            Check(r.Outcomes.Single().Kind==(help?OutcomeKind.Committed:OutcomeKind.Unable),"Full-slot meaning distinction");
            Check(r.State.Favours.Count==1&&Att(r,2,1)==(help?10:0),"Full-slot partial effect");
            Check(r.Decisions.Count(d=>d.Candidates.Length>0)==(help?1:0),"Full-slot response scored");
        }
    }
    static void Historical()
    {
        Recovery([new(1,2,new(1),1),new(2,2,new(1),-1)],3,false);
        Recovery([new(1,2,new(1),2),new(2,2,new(1),-1)],3,true);
        foreach(int[] order in Permutations([1,2,3,4]))foreach(bool reverse in new[]{false,true})
        {
            var s=Create(World(20,0,20,20,20));
            s.RunCycle(new([P(1,1,new OfferBenefitForFavor(new(2),1)),P(2,3,new OfferBenefitForFavor(new(2),1)),P(3,4,new OfferBenefitForFavor(new(2),1)),P(4,5,new OfferLoan(new(2),5))]));
            s.RunCycle(CycleInput.Empty);
            var debt=s.Snapshot.Debts.Values.Single();
            var ps=order.Select((actor,rank)=>P(100+rank,actor,actor==2?new Farm():new CallFavor(s.Snapshot.Favours.Values.Single(f=>f.Holder.Value==actor).Id,new RepayDebt(debt.Id,2)))).ToArray();
            var r=s.RunCycle(new([..reverse?ps.Reverse():ps]));
            Check(r.Outcomes.Count(o=>o.Kind==OutcomeKind.Committed)==3,"Historical B2 commits");
            var lost=r.Outcomes.Single(o=>o.Kind==OutcomeKind.InvalidatedAtResolution);
            Check(lost.Reason=="RepaymentExceedsRemaining"&&lost.Actor.Value==order.Last(i=>i!=2),"Historical B2 loser");
            Check(r.State.Debts[debt.Id].Remaining==1&&r.State.People[new(2)].Grain==6,"Historical B2 final material");
            foreach(var p in ps)Check(Marked(r,p.Id)==(p.Actor.Value!=2),"Historical B2 commuting Farm falsely marked");
            foreach(var f in r.State.Favours.Values)Check(f.Outstanding==(f.Holder==lost.Actor),"Historical B2 favours");
        }
    }
}
```

### Observed reviewer console output

```text
A1.NamedRecoveryAndFaultTiming completed
A2.BoundedSignedScheduleEnumeration completed
B1.DebtGrainEnablerPermutationMatrix completed
B2.ResidencePairInteractionEnumeration completed
B3.FavourProvenanceAndRetirement completed
B4.MarriageResidenceAndMaterialCommutingControls completed
C1.NeedRefusalAndFailureKnowledge completed
C2.PersonalSubjectiveIsolation completed
C3.GrainIngressAndCallFavorClosure completed
C4.MixedAttitudeAndInitiative completed
C5.ExplicitBargainAtomicity completed
H1.ExactHistoricalCounterexamples completed
TOTAL worlds=7388 assertions=64793 failures=0
```
