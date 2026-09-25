# SFL v0 Slice 5 — Verification Trigger and Acceptance Applicability Map

**Status:** ADVISORY RETURN / PREIMPLEMENTATION VERIFICATION DISCOVERY  
**Commission:** tasks/research/SFL_V0_SLICE5_DISCOVERY_C_VERIFICATION_TRIGGERS.md  
**Role:** verification authority mapper  
**Return branch:** research/slice5-verification-trigger-return  
**Exact execution base SHA:** 664311fffbc4475e3924221f58633b3a4f63a8a9  
**Dispatch pre-discovery baseline:** 26277ed211baaaa9a1dcfaebf98c4fd00a9b4181  
**Current promoted Slice-4 implementation boundary:** c72ae67dc76ac091331fcd5494c6657eec57f703

The execution base contains the Slice-5 discovery dispatch. A direct comparison from the promoted IMP-0004 merge c72ae67dc76ac091331fcd5494c6657eec57f703 to this execution base contains no src/ or tests/ changes. The current production/test boundary is therefore still the promoted Slice-4 boundary for purposes of this return.

This document is advisory. It does not amend SPEC-SFL-0001, any ADR/decision, or any frozen Slice-1/2/3/4 acceptance manifest.

## 1. Executive conclusion

Slice 5 activates the checkpoint/continuation obligations that prior slices deliberately deferred. The core completion claim is stronger than "the file can be loaded":

> At a stable post-closure boundary, interruption and restoration under identical future inputs/configuration must preserve every future-causal authoritative distinction closely enough that subsequent authoritative semantic state and semantic history are exactly the same as uninterrupted execution.

That claim is already substantially fixed by accepted authority:

- SPEC-SFL-0001 §9.6 requires stable-boundary checkpoints, all future-influencing authoritative state, nonauthority of rebuildable caches/indexes, and exact restored state/history suffix under identical inputs/configuration.
- ADR-0004 requires safe-boundary continuation, serializable future process state where such state exists, deterministic ordering/revalidation, and forbids runtime stacks/caches/logs from silently becoming authority.
- VS-SFL-082 specifies the positive uninterrupted-versus-restored pair.
- VS-SFL-083 specifies omitted-state mutations.
- VS-SFL-084 specifies derived-state rebuild equivalence.
- the cross-cutting contract already defines checkpoint metamorphism and the checkpoint omission mutant class.
- VH-04 now fires and requires every omission mutant to have a continuation suffix that actually exercises the omitted state.

From the verification side, no new social-semantic decision is required merely to draft Slice-5 acceptance after the A/B/C discovery reconciliation. The current verification-side blocker classification is therefore:

**NO BLOCKER for acceptance-authority drafting after discovery reconciliation.**

Two qualifications remain mandatory:

1. A/B reconciliation may still expose a genuine semantic gap in the state/process census; Commission C does not pre-empt that result.
2. A separate inherited-verification adaptation review is conditionally required before coding if the chosen checkpoint implementation changes an exact inherited structural allowlist/audit path such as S1-084 / S3-093. Checkpoint work does not, by itself, necessarily force that adaptation.

The current kernel also exposes a concrete reason not to equate a public snapshot with a checkpoint: future-causal state is distributed outside the published snapshots, including allocation frontiers and the already-used ProposalId set. Exact continuation must prove these hidden future-causal surfaces rather than infer sufficiency from serialization coverage.

## 2. Controlling verification boundary

### 2.1 Accepted continuation contract

The acceptance authority should subordinate itself to the following already-accepted distinctions.

A valid checkpoint:

- exists only at a stable cycle boundary after resolution and automatic reaction closure;
- captures all future-influencing authoritative state;
- includes subjective knowledge/Recognition as well as objective state;
- includes Household/role/provision and cooldown/history baselines;
- includes pending future inputs/work that can still affect the run;
- preserves identifier/order state and configuration/rule identity;
- does not turn rebuildable caches/indexes/projections into recovery authority;
- when restored under identical inputs/configuration, yields the exact subsequent authoritative semantic state and history suffix.

A safe checkpoint is not:

- an intermediate resolution snapshot;
- a reaction-queue snapshot;
- a coroutine/task-stack capture;
- an event-log replay presented as current authority;
- a public snapshot plus "whatever can be guessed later";
- a serialized cache image whose stale value can override backing authority.

### 2.2 Exactness versus representation freedom

Acceptance must be exact about semantics and identities that accepted continuation makes consequential, while remaining representation-neutral.

It must not require:

- JSON, binary, database, DTO, event-sourcing, or any specific encoding;
- one monolithic checkpoint object;
- persistence of a cache that can be exactly rebuilt;
- a generic workflow/process engine when current accepted v0 needs only typed future state and scheduled input;
- byte-for-byte checkpoint-file equality.

It must require exact uninterrupted/restored equality of the authoritative continuation result. Comparator-only normalization is legitimate for serialization/property order, unordered container traversal, formatting, and deliberately rebuilt nonauthoritative projections. It is not legitimate for semantic IDs, Cycle/ReactionIndex, causal references, outcomes, fallback markers, rule/configuration identity, decision-trace linkage, or evidence provenance in the paired continuation run.

## 3. A — Fired deferred checkpoint obligations

### 3.1 Newly live rows

| Source | Prior disposition | Slice-5 disposition | Required consequence |
|---|---|---|---|
| S1-082 / VS-SFL-082 | DEFERRED | FIRED | Exact uninterrupted-versus-restored continuation becomes completion evidence. |
| S1-083 / VS-SFL-083 | DEFERRED | FIRED | Omission of a future-causal checkpoint class must be detected semantically. |
| S1-META-06 | DEFERRED | FIRED | Checkpoint metamorphism is now a required metamorphic relation. |
| S1-MUT-25 | DEFERRED | FIRED | "Omit future-influencing checkpoint state" becomes an executed mutant class. |
| S2-D07-CHECKPOINT-SUBJECTIVE-STATE | DEFERRED | FIRED | KnownFact, Recognition, evidence identity/provenance, staleness/Contested state must survive restore. |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED | FIRED | Household substrate exact continuation and omission testing become live. |
| S4-D01-CHECKPOINT-RESTORE | DEFERRED | FIRED | Role/head/provision/reconsideration exact continuation and omission testing become live. |
| VH-04 | DEFERRED HARDENING | FIRED | Each omission mutant needs a suffix that causally exercises what was omitted. A crash/parse failure alone is not the intended proof. |

### 3.2 Inherited rows that are not newly fired but must be re-exercised in the Slice-5 world

The following are already REQUIRED and stay REQUIRED:

- S1-084 / S1-META-05 / S1-MUT-24 — derived-state nonauthority and stale-cache protection;
- S2-054-CACHE-NONAUTHORITY;
- S3-083-DERIVED-REFRESH-CLOSURE;
- S3-084-NO-MID-CLOSURE-PUBLICATION;
- S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE;
- S3-090-FALLBACK-QUARANTINE;
- S3-091-VERIFIED-PRODUCER-PROVENANCE;
- S3-092-TRACE-CONFIGURATION-TRUTH;
- S4-144-LOCALITY;
- S4-145-OBSERVER-NONINTERFERENCE;
- S4-146-DERIVED-CACHE-NONAUTHORITY;
- S4-150-STRUCTURAL-AUTHORITY-EXPLICIT;
- S4-154-VERIFIED-PRODUCER-PROVENANCE;
- S4-155-TRACE-CONFIGURATION-TRUTH;
- S4-156-STABLE-CLOSURE;
- S4-159-FALLBACK-QUARANTINE;
- S4-186-MOBILIZABLE-CAPACITY-NONAUTHORITY;
- inherited regression bundles S4-R05 through S4-R11 where applicable.

Slice 5 must not claim checkpoint correctness while leaving those inherited properties tested only in pre-checkpoint execution.

### 3.3 No additional deferred social capability fires merely because checkpointing exists

No other still-deferred row is newly activated by Slice 5 on current accepted authority.

In particular:

- S4-D02 actor departure / LATER-02 remains deferred.
- S4-D03 candidate convergence / LATER-01 remains deferred.
- S4-D04 repeated-predecessor lineage / LATER-03 remains deferred.
- S4-D05 through S4-D09 remain outside the bounded v0 slice.
- general nonparticipant perception, trust/rumor/reputation, contested succession, resignation, and general institutional sovereignty remain out of scope.
- S1-087 / rendered causal explanation remains deferred.
- VH-02 does not fire unless generated histories become required completion evidence.

Several older deferred items involving communication, Household formation, provision and reconsideration already fired and were closed by Slices 2–4. They must be inherited as regressions; they must not be misreported as newly fired Slice-5 obligations.

The existing delayed phenomena — debt due review, provision reconsideration timing/history, and scheduled exogenous grain input — are already accepted executable semantics. Slice 5 makes their interruption/continuation preservation newly completion-critical; it does not reopen their meanings.

## 4. Verification-facing observations from the promoted kernel

This section is deliberately narrower than Commission B's implementation census. It records only facts needed to ensure that the future Slice-5 acceptance authority cannot be satisfied by snapshot-only persistence.

### 4.1 Public/published state is not the complete future-causal state

At the current promoted boundary:

- WorldState owns a private nextRelation frontier.
- EpistemicState owns a private nextEvidence frontier.
- Simulation owns nextEvent and nextProposal frontiers.
- HouseholdState owns nextHousehold, nextWarrant, nextAssociation, nextCommitment and nextHeadRole frontiers.
- Simulation owns usedProposals, which rejects reuse of ProposalIds already seen in earlier cycles.
- current cycle affects scheduled input execution, debt due timing, cooldown timing and all future semantic time.
- InitialWorld.Inputs is consulted in future cycles; already-consumed input must not be replayed.
- Configuration.Version and rule-version selection are emitted into semantic/decision provenance.
- EpistemicState carries actor-held facts/Recognition and CandidateReferents that are not reducible to objective WorldSnapshot state.
- HouseholdState carries provision refusal/material-need baseline state introduced under DEC-0014.
- WorldSnapshot does not expose the allocation frontiers or usedProposals.

Therefore "serialize WorldSnapshot + HouseholdSnapshot + EpistemicSnapshot" is not, by itself, a valid completion argument.

### 4.2 A concrete hidden-frontier risk already exists

EpistemicState increments nextEvidence before its precedence logic may discard an incoming fact that is already superseded. That means a verified runtime history can contain an EvidenceId allocation gap whose next frontier is not recoverable from the maximum currently held EvidenceId.

This is useful as a verification probe because it can distinguish true frontier preservation from an implementation that reconstructs "next evidence = max held evidence + 1".

The acceptance authority must preserve the semantic requirement — exact generated identities/order — rather than freezing "allocate then discard" as a social or permanent implementation rule. If implementation changes that local allocation technique, another runtime-produced gap witness must exercise the same frontier-preservation claim.

### 4.3 Proposal-use history is future-causal

usedProposals is not merely diagnostic. A future CycleInput containing a ProposalId already used before the checkpoint is invalid in uninterrupted execution.

A checkpoint that omits this set can accept a duplicate ProposalId after restore and diverge even if all public snapshots and counters look identical.

The Slice-5 acceptance authority should therefore include a duplicate-precheckpoint-ProposalId continuation probe under the general identifier/order/history class.

### 4.4 Current delayed state is typed rather than a generic process queue

The current promoted kernel exposes, at minimum:

- scheduled exogenous GrainInput records consulted by cycle;
- Debt.CommittedCycle and DueReviewed for future social-due review;
- ProvisionRefusal state, including latest-refusal baseline and DEC-0014 material-need occurrence;
- ordinary future action inputs supplied after checkpoint by the paired test schedule.

This return found no reason to make a generic process engine an acceptance prerequisite. If Commission A/B identifies another accepted pending-work object, the same preservation/revalidation rules apply to that type. If no such object exists, acceptance should not invent one just to satisfy the phrase "pending work/process".

## 5. B — Minimum exact-continuation witnesses

The smallest credible package is not one giant scenario. It is a bounded set of three positive pair families plus safe-boundary negatives. Each pair has Run A uninterrupted and Run B restored from a runtime-produced checkpoint, then applies the exact same future external inputs/configuration.

For every pair, compare at every subsequent stable boundary, not only at final state.

The witness labels below are planning labels, not proposed canonical AcceptanceIds.

### W1 — Cross-domain causal continuation

Produce a stable checkpoint containing:

- nontrivial people/grain/residence/attitude/relation state;
- at least one active Household with stable identity, current sustaining participation and a persistent head role;
- an occupied current head plus actor-held head Recognition;
- at least one actor with stale Household/head information;
- at least one genuinely Contested Recognition state;
- at least one persistent provision commitment;
- a latest provision refusal baseline;
- a qualifying DEC-0014 post-refusal material-need occurrence whose historical relevance must survive until reconsideration;
- one active debt whose social due review occurs after the checkpoint;
- one outstanding favour;
- one not-yet-due scheduled exogenous GrainInput;
- configuration identity deliberately made non-ambient/explicit for the test;
- pre-checkpoint provenance references that later suffix events will cite.

The suffix must actually exercise those states:

1. cross the debt due cycle and compare the one-time review/event/attitude consequence;
2. cross the scheduled GrainInput cycle and compare exact single execution;
3. cross the provision reconsideration eligibility point and exercise a reconsideration decision whose validity depends on the preserved latest-refusal + historical-material-need baseline;
4. exercise the outstanding favour or its capacity in a way that would differ if the favour were lost/duplicated;
5. communicate or otherwise use stale/Contested recognition so subjective candidate/action availability depends on the restored evidence;
6. execute at least one Household/head/provision action so role identity, occupancy, commitment backing and typed provenance are future-causal;
7. emit new events/evidence so pre-checkpoint causal references and rule/configuration labels are used in new suffix history.

Required comparison:

- objective world state;
- epistemic state including exact EvidenceIds/provenance;
- Household/role/provision state;
- lifecycle/participation identity;
- all consequential suffix events/outcomes/traces;
- Cycle/ReactionIndex;
- new IDs and causal predecessor references;
- rule/configuration versions;
- fallback markers if any.

### W2 — Identifier/order frontier and fallback continuation

Use a runtime-produced pre-checkpoint history that advances multiple ID domains independently and contains at least one intentional gap.

The current kernel's discarded-older-evidence path is a suitable candidate for an EvidenceId frontier gap because it can advance nextEvidence without leaving that EvidenceId in the held actor state. This is an implementation-local fixture technique, not a semantic requirement.

Also include:

- non-contiguous externally supplied ProposalIds before checkpoint;
- at least one pre-checkpoint ProposalId that will be deliberately re-submitted after checkpoint as a duplicate-proposal negative probe;
- independent advancement of event, relation, evidence, Household/role/warrant/association/commitment domains where the scenario naturally supports them.

After restore, drive actions that allocate as many independent ID domains as possible:

- autonomous/generated proposals;
- semantic events;
- new evidence;
- a new relation;
- new Household/warrant/association state where bounded formation is used;
- a new role associated with any newly formed Household;
- a new commitment.

Compare the exact generated identity sequence between uninterrupted/restored runs.

Add one post-checkpoint accepted technical-fallback exercise, preferably a bounded equal-priority Residence conflict or another already-accepted fallback domain, and require:

- same candidates;
- same semantic priority result;
- same generated ProposalIds where generated by the runtime;
- same winner/invalidated outcome;
- same technical-fallback marker.

A test that merely proves final isomorphism after renaming generated IDs does not satisfy checkpoint exactness.

#### Frontier-specific structural control

For every implementation-stored mutable frontier, the fixture/oracle evidence must show that the checkpoint captures that frontier rather than silently recomputing it from live-object maxima.

At minimum the current implementation suggests checking:

- nextRelation;
- nextEvidence;
- nextEvent;
- nextProposal;
- nextHousehold;
- nextWarrant;
- nextAssociation;
- nextCommitment;
- nextHeadRole;
- the pre-checkpoint used ProposalId set or an equivalent exact duplicate-prevention authority.

If a future implementation proves a listed frontier is no longer independent mutable state, acceptance may use the independently demonstrated derivation instead of requiring a field with that name. Field names/layout are not authority.

ReactionIndex is compared exactly in history. Whether a private terminal ReactionIndex value at a safe boundary is persisted or safely reinitialized is an implementation question; acceptance cares that next-cycle ordering and the exact semantic suffix are unchanged.

### W3 — Full-state derived rebuild continuation

At a stable checkpoint boundary:

1. capture authoritative state;
2. enumerate every declared derived cache/index/projection in the Slice-5 implementation;
3. discard/rebuild it from authoritative state;
4. compare the bounded query surface before/after rebuild;
5. continue the original and rebuilt runs under identical inputs and compare exact authoritative state/history suffix.

The inventory must include, where represented/materialized:

- candidate/neighborhood/feasible-action indexes;
- Household participant/lifecycle projections;
- lineage DerivedFrom / AncestorOf projections;
- current-head/action-availability projection;
- MobilizableCapacity and funding summaries;
- Recognition projections/indexes;
- dependency/overlap indexes;
- published/reporting projections that are declared nonauthoritative;
- any checkpoint-specific lookup/index introduced by Slice 5.

The suite must also challenge at least one critical stale-derived seam. A representative strong mutant is a stale serialized/current Household capacity, current-head, Recognition, or dependency projection that disagrees with its backing authority and would change behavior if trusted.

If no behavior-affecting cache exists for a category, structural absence plus deterministic projection rebuild is legitimate evidence. Do not force the implementation to create a cache just so it can be deleted.

### W4 — Safe-boundary controls

Positive:

- checkpoint immediately after a verified stable cycle closure succeeds;
- restored execution begins from exactly that completed boundary.

Negative:

- a checkpoint request during proposal resolution cannot yield a valid checkpoint;
- a checkpoint request while automatic reactions remain open cannot yield a valid checkpoint;
- a deliberately faulted/truncated cycle cannot be promoted into a valid checkpoint;
- restore cannot expose a partially closed cycle as a completed actor-visible state;
- restore cannot create a fresh same-cycle voluntary activation.

The test mechanism may use a verification-only hook/fault challenge to request capture at a specific engine phase. That hook is not simulation semantics and must not alter the ordinary run.

## 6. C — Omission-detectable mutants

Every semantic omission mutant should start from a valid runtime-produced checkpoint, produce a parseable/structurally usable corrupted variant where possible, restore far enough to execute the targeted suffix, and compare to the uninterrupted control.

Malformed bytes/parse failures may be tested separately as robustness. They are not credit for the semantic omission mutant.

| Mutant | Corruption | Required exercising suffix | Required detector |
|---|---|---|---|
| M-SUBJECTIVE | remove/replace selected KnownFact, stale head/H Recognition or one side of Contested evidence while leaving objective world equal | attempt a recognition-gated communication/Household-mediated route or correction whose candidate set depends on that evidence | exact epistemic/candidate/trace/suffix divergence; no passive objective-state repair |
| M-PROVISION-BASELINE | remove/reset latest provision refusal, eligible-support baseline or DEC-0014 MaterialNeedChange provenance | advance to the ordinary reconsideration cycle and ask again | eligibility/event/trace mismatch at the exact semantic cycle |
| M-HOUSEHOLD-ROLE | omit/corrupt H lifecycle/association, persistent role identity/occupant, head transition, commitment or role Recognition support while keeping unrelated world state valid | execute role-scoped Household action and/or succession/vacancy-sensitive action | authority/candidate/funding/provenance mismatch |
| M-PENDING-INPUT | remove one not-yet-due GrainInput, mark it consumed incorrectly, or make one consumed input due again | cross the scheduled cycle, preferably where material-deadlock classification also depends on future input | input occurs zero/twice/wrong time or deadlock classification differs |
| M-ID-ORDER | alter one allocation frontier or omit duplicate-ProposalId history/used set | allocate in that domain and re-submit one pre-checkpoint ProposalId | generated ID/order differs or duplicate validity differs |
| M-CONFIG | remove/replace checkpoint configuration identity using a non-default test Configuration.Version | execute a decision/event after restore | future event/decision ConfigurationVersion or compatibility result differs; parse failure alone not credit |
| M-DEBT | lose/corrupt debt CommittedCycle, DueReviewed, remaining balance or origin reference | cross exact due review point | one-time review timing/effect/cause differs or repeats |
| M-FAVOUR | lose/corrupt outstanding favour state/origin | call, consume, refuse, cancel, or exercise pair capacity after restore | action availability/material/social effect/history differs |
| M-PROVENANCE | sever a pre-checkpoint origin/warrant/evidence reference while retaining superficially similar current values | create a suffix event that must cite or reason from that authority | unresolved/wrong predecessor or independent oracle rejection |
| M-DERIVED | persist/trust a stale cache/index/projection inconsistent with backing authority | query and then execute behavior whose candidate/funding/dependency result would differ if stale value were authority | rebuild/query mismatch or semantic suffix divergence |

### Configuration/rules nuance

Accepted authority guarantees exact continuation under identical configuration and requires rule/configuration identity in checkpoint/history. It does not currently define a migration protocol for intentionally restoring under a different rule set.

Therefore:

- the positive completion pair uses identical configuration/rules;
- configuration omission can be causally exercised with a deliberately non-default Configuration.Version because subsequent history/traces must reproduce it exactly;
- rule-set identity must be present/verified, but Commission C does not invent "upgrade" behavior for a genuinely different rule implementation;
- if a missing/unknown rules identity is tested, classify an explicit incompatibility result separately from the semantic suffix pair rather than pretending a cross-version run has accepted expected social semantics.

## 7. D — Safe-boundary enforcement detail

Acceptance should bind "stable boundary" to observable engine facts rather than a serializer's own boolean.

A valid positive capture must demonstrate:

- the just-completed cycle's resolution finished;
- automatic reaction closure finished;
- all required stable lifecycle/Recognition/material updates are published;
- no open accepted proposal/response is waiting for same-cycle commit;
- no open reaction cause remains;
- the next voluntary actor activation has not started.

Negative captures should be requested at two distinct unsafe phases where practical:

1. after accepted proposals/responses exist but before central resolution/commit is complete;
2. after a consequential commit but before automatic reaction closure/stable publication.

A serializer that writes bytes in those phases but labels the artifact "unsafe/not restorable" has not created a valid checkpoint. Completion requires that such an artifact cannot be accepted by the ordinary restore path as a valid stable checkpoint.

## 8. E — Exact state/history suffix comparison

The independent continuation comparator must preserve and compare at least the following in the paired run.

### 8.1 Stable authoritative state

- Cycle;
- people/grain/NeedsGrain;
- residence, attitude, kinship, marriage;
- debts and favours including origin/timing/completion flags;
- actor-held KnownFacts and Recognition, including EvidenceIds and provenance;
- CandidateReferents if still future-causal;
- Household identities, warrants, sustaining associations and lifecycle;
- lineage warrants/direct predecessor authority;
- persistent head-role identity and current occupancy;
- head/Household Recognition evidence;
- provision commitments and termination/provenance;
- provision refusal/reconsideration/material-need baseline state;
- scheduled/pending future input/work;
- identifier/order/frontier state required for exact continuation;
- configuration/rule identity.

### 8.2 Consequential suffix history

Compare exact future:

- EventId;
- ProposalId;
- Cycle;
- ReactionIndex;
- event/action meaning;
- participant/role/Household context;
- response/failure/invalidation outcome and reason;
- committed material effects;
- causal predecessor EventIds;
- evidence/acquisition receipts and EvidenceIds;
- role/warrant/commitment references;
- funding/private-X source provenance;
- technical fallback marker and accepted fallback domain;
- decision-trace candidate/gate/component/selection linkage;
- RulesVersion and ConfigurationVersion.

### 8.3 Legitimate comparator normalization

Allowed only in comparison tooling:

- dictionary/property enumeration order;
- serialization whitespace/property order;
- filesystem/container metadata;
- representation of a declared derived projection after exact rebuild;
- set ordering where the semantic type is explicitly unordered.

Not allowed in the uninterrupted-versus-restored exact pair:

- renaming EventId/ProposalId/EvidenceId/RelationId/HouseholdId/role/warrant/association/commitment identities;
- replacing exact causal refs with "equivalent-looking" refs;
- sorting away ReactionIndex differences;
- dropping failure/invalidation records;
- suppressing fallback markers;
- replacing exact rule/config labels;
- comparing only final aggregate grain/participants/attitudes;
- stripping subjective evidence identity/provenance.

The separate inherited ID-renaming/isomorphism metamorphic tests remain valid tests of their own claims. They are not a normalization license for checkpoint exactness.

## 9. F — ID/order continuity requirements

### 9.1 Required positive checks

The acceptance package should make independent ID domains observable in evidence and verify that, after restore, the next generated identities are exactly the same as uninterrupted execution.

The current kernel has distributed mutable frontiers, so the acceptance manifest should not use one generic "IDs preserved" row without a census.

Current verification-relevant domains include:

- RelationId;
- ProposalId;
- EventId;
- EvidenceId;
- HouseholdId;
- HouseholdHeadRoleId;
- WarrantId;
- AssociationId;
- CommitmentId.

Any new Slice-5 process/checkpoint semantic identity introduced by accepted authority must be added to the same audit.

### 9.2 Gaps

At least one produced checkpoint must contain a domain with a real allocation gap/frontier that cannot be validated by looking only at current live object maxima.

The current nextEvidence/discarded-older-evidence behavior is a suitable candidate. The acceptance wording should state the invariant, not hard-code that implementation technique.

### 9.3 Independent advancement

Advance several domains on different causal paths before and after checkpoint. A correct restore must not:

- collapse them into one global counter;
- seed one domain from another's maximum;
- reconstruct every domain from a generic "max ID + 1";
- reuse an ID that was consumed historically but is not present in a current live collection.

### 9.4 Duplicate ProposalId history

Explicitly preserve the pre-checkpoint duplicate-prevention boundary.

Pair:

- before checkpoint, use ProposalId P and complete the cycle;
- after checkpoint, submit P again.

Uninterrupted and restored executions must agree that P is already used. This directly detects omission of current usedProposals-equivalent authority even when public semantic snapshots match.

### 9.5 Max+1 anti-cheat

For any frontier that is stored as independent authoritative continuation state, mutation of the stored frontier must be detected by the next allocation/suffix.

If a future implementation instead derives a frontier, it must independently demonstrate that the derivation is exact for every reachable state and does not lose consumed/historical gaps. "It worked on a contiguous fixture" is insufficient.

## 10. G — Scheduled input and delayed-process continuation

Slice-5 completion must exercise current accepted time-delayed causal mechanisms through interruption.

### 10.1 Scheduled exogenous input

Use at least one input before checkpoint and one after checkpoint.

Prove:

- the consumed pre-checkpoint input is not re-applied after restore;
- the not-yet-due input fires exactly once;
- it fires at the same Cycle and has the same EventId/ReactionIndex relative to the suffix;
- any MaterialDeadlock classification that depends on a future input remains the same.

Acceptance must remain representation-neutral: full original schedule + Cycle, remaining schedule, or another lossless representation can all be valid if exact continuation proves the semantics.

### 10.2 Debt due/review

Checkpoint with an active debt whose due review is still future.

Prove:

- same due-cycle review;
- same one-time DueReviewed transition;
- same balance-dependent attitude consequence;
- same origin/cause references;
- no replay of an already completed pre-checkpoint due review.

### 10.3 Provision reconsideration

Checkpoint after the latest refusal and after/before a qualifying material-need occurrence as needed to build paired boundary cases.

At minimum require:

- a positive case where the historical post-refusal material-need occurrence survives interruption and unlocks reconsideration once the three-full-cycle condition is also satisfied;
- a negative control where cooldown elapsed but no accepted post-refusal context change exists;
- a baseline-reset control where a later refusal makes an older material-need occurrence insufficient for the new baseline.

This preserves DEC-0014 rather than reconstructing "need changed" from observer history, current need, ProposalId, or checkpoint replay identity.

### 10.4 Any explicit new delayed-process state

If A/B reconciliation finds accepted pending work beyond the typed mechanisms above, completion evidence must prove:

- stable process identity/provenance if identity is semantically needed;
- due/ordering state;
- condition revalidation at execution;
- no duplicate pre-checkpoint side effect;
- same semantic execution time and suffix after restore.

If the meaning of such a process is not derivable from accepted authority, that specific process becomes a semantic acceptance blocker. Do not invent its lifecycle in a verification scenario.

## 11. H — Cache/derived rebuild equivalence and adaptation trigger

### 11.1 Slice-5 rebuild obligation

VS-SFL-084 is already canonical and must be exercised against the fully populated post-Slice-4 state plus whatever bounded checkpoint surface Slice 5 introduces.

The Slice-5 acceptance authority should require:

- an explicit declared derived-state inventory;
- discard/rebuild of each materialized derived cache/index/projection at a safe boundary;
- identical bounded query answers before/after rebuild;
- exact future state/history suffix under identical continuation;
- a stale-derived fault challenge on a consequential seam;
- proof that deleting a derived representation never deletes backing relation/warrant/evidence/provision authority.

MobilizableCapacity remains a particularly important negative-authority seam under DEC-0013/S4-186.

### 11.2 Does checkpoint work necessarily require an inherited S1-084 adaptation?

**No — not necessarily.**

The approved Slice-4 Adaptation B already records the correct trigger rule:

- exact private-field inventories are an implementation-local enforcement method;
- adaptation fires if implementation changes one of those exact reflected inventories or replaces the inherited structural-audit path;
- a separate explicit authoritative partition can preserve the old allowlists unchanged.

The current tests still include:

- CrossCuttingScenarios.NoDerivedAuthorityStructuralAudit for the exact WorldState private-field inventory;
- HouseholdStructuralScenarios exact HouseholdState authority inventory.

A bounded checkpoint capture/restore layer can, in principle, export/import existing authority plus counters without making a checkpoint DTO/cache into new live simulation authority and without editing those exact inventories.

Therefore there is **no unconditional inherited-adaptation blocker before acceptance drafting**.

### 11.3 Conditional hard stop before coding

A separately reviewed lossless inherited-verification adaptation is required before the triggering implementation change if the Slice-5 design:

- adds/removes behavior-affecting fields in an exact audited WorldState or HouseholdState inventory;
- edits/replaces NoDerivedAuthorityStructuralAudit or its Household counterpart;
- introduces a new mutable cache/index/frontier as live authority without equivalent explicit structural enforcement;
- makes serialized derived state a second source of truth;
- weakens S1-084/S1-META-05/S1-MUT-24, S3-093, S4-146/S4-150/S4-171/S4-186 enforcement.

If triggered, the adaptation must be at least as strong as Slice-4 Adaptation B and include a critical-seam hidden/stale authority mutant. A generic unrelated extra field is insufficient.

## 12. I — Checkpoint fixture / producer authority

### 12.1 Runtime-produced checkpoint fixture class

Define a dedicated Slice-5 checkpoint fixture class, conceptually F-S5-RUNTIME-CHECKPOINT.

Its checkpoint under judgment must be produced by the real runtime capture path from a verified stable execution.

Required fixture evidence:

- exact base scenario/initial fixture;
- lower-slice producer identity used to obtain Household/head/provision state;
- exact checkpoint Cycle;
- proof the boundary is stable/post-closure;
- exact declared fixture writes before runtime execution;
- zero direct writes of the final checkpoint's endogenous H/role/provision/refusal/debt/favour/epistemic postconditions under judgment;
- active rule/configuration identity;
- runtime checkpoint output identity/digest or equivalent immutable test identity;
- producer verification PASS;
- pre-checkpoint public semantic state/history identity used by the paired control.

A reused lower-slice produced Household/head/commitment state must keep the producer/pass/fixture-audit provenance already required by S3-091/S4-154.

### 12.2 Corruption fixture class

Direct editing of decoded checkpoint state/bytes is allowed only for explicit corruption/mutation tests.

For semantic omission mutants:

- begin from a valid runtime-produced checkpoint;
- make one declared corruption class;
- keep the artifact sufficiently valid to continue when possible;
- do not direct-write the expected post-restore result;
- record exact mutation and target state class.

Malformed/truncated/unknown-format files may be separate robustness tests, but they do not replace omission mutants.

## 13. J — Oracle independence

Checkpoint code must not verify itself.

### 13.1 What the continuation oracle may share

It may share:

- public semantic types/identifiers;
- frozen accepted constants/rules as documentary expected values;
- the exact declared future input schedule;
- read-only public snapshots/history/traces;
- independently captured test metadata about the valid producer checkpoint.

### 13.2 What it must not use as its sole oracle

For claims under judgment, do not use:

- production Restore() equality/helper as the comparator;
- production checkpoint serializer's own "complete" flag as proof of state coverage;
- production cache rebuild helper as the sole proof that rebuilt values are correct;
- production ID allocator to compute expected next IDs;
- production recognition/funding/dependency classifiers to validate their own restored result;
- a final-state serialization generated by the same code path on both sides without field-by-field semantic assertions.

### 13.3 Required independent checks

Use a combination of:

1. independent canonical projection of public authoritative state/history at each stable boundary;
2. direct exact Run A vs Run B identity comparisons for future generated IDs and history;
3. mutation/corruption rejection that would pass if the restore path silently ignored the omitted class;
4. independent arithmetic/timing checks for debt due, cooldown and provision funding;
5. independent provenance/reference resolution for evidence/warrants/roles/commitments;
6. structural inspection of checkpoint coverage/frontiers where a future-causal private value has no public semantic snapshot surface;
7. inherited independent oracles such as the lower-slice public-boundary oracles where their scope remains valid.

For the ID frontier specifically, the oracle should compare the live pre-checkpoint frontier captured through a verification-only structural/read-only path with the produced checkpoint representation, then prove the next uninterrupted/restored allocation is exact. This avoids "restore reconstructs from max and then compares to itself."

## 14. K — Exact inherited regressions most vulnerable to checkpoint work

The future Slice-5 manifest should bind exact prior IDs, not only thematic labels. At minimum preserve the following clusters.

### 14.1 Objective / subjective separation and no passive synchronization

- S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION;
- S2-004-RECOGNITION-DISTINCT;
- S2-006-NO-PASSIVE-SYNC;
- S2-007-NO-HISTORY-OMNISCIENCE;
- S2-008-LOCALITY;
- S2-030-STALE-FACT-PERSISTS;
- S2-033-CANDIDATE-RECOGNITION-CONTESTED;
- S2-042-SUBJECTIVE-TRACE;
- S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION;
- S3-R02-COMMUNICATION-PROVENANCE-STALENESS;
- S4-033-HEAD-RECOGNITION-CORRECTION;
- S4-039-VACANCY-EVIDENCE-LOCALITY;
- S4-040-HEAD-EVIDENCE-EXACT-ID-PROVENANCE.

Checkpoint restore must not "helpfully" regenerate actor knowledge from current objective state.

### 14.2 Household / role identity continuity

- S3-009-NO-HIDDEN-MEMBERS-AUTHORITY;
- S3-031-COMPLETE-FOUNDER-TURNOVER;
- S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT;
- S3-033-INACTIVE-STATE;
- S3-036-DISSOLUTION-STABLE-CLOSURE;
- S3-037-DISSOLVED-NO-RESURRECTION;
- S3-060-LINEAGE-NONAUTHORITY;
- S4-001-PERSISTENT-HEAD-ROLE;
- S4-012-VACANCY-PRESERVES-H;
- S4-017-SUCCESSION-PRESERVES-ROLE-ID;
- S4-022-ROLE-IDENTITY-NOT-HOLDER-IDENTITY;
- S4-R01-HOUSEHOLD-IDENTITY-CONTINUITY.

Restore must preserve identity; it may not reconstruct H/role identity from current participant/occupant similarity.

### 14.3 Provision, private-X and DEC-0014 provenance

- S3-070-PROVISION-COMMITMENT-BACKING-STATE;
- S3-073-NO-POOLED-HOUSEHOLD-TREASURY;
- S4-071-PROVISION-ACCEPTANCE-CREATES-COMMITMENT;
- S4-073-PROVISION-DECLINE-NO-COMMITMENT;
- S4-074-RECONSIDERATION-COOLDOWN;
- S4-075-RECONSIDERATION-CONTEXT-CHANGE;
- S4-076-RECONSIDERATION-IRRELEVANT-CHANGE;
- S4-090-NO-POOLED-TREASURY;
- S4-184-TYPED-FUNDING-PROVENANCE;
- S4-186-MOBILIZABLE-CAPACITY-NONAUTHORITY;
- S4-188-DEC0011-EXACT-PRIVATE-X-FUNDING-PLAN;
- S4-189-DEC0011-SAME-HEAD-COMMITMENT-X-ARITHMETIC;
- S4-190-DEC0011-EXACT-TERM-NONTRANSFER-PROVENANCE;
- DEC-0014 exact historical post-refusal material-need semantics as confirmed sufficient under the frozen Slice-4 acceptance authority.

Restore must not replace typed backing/provenance with aggregate balances or reconstruct DEC-0014 context from current need or diagnostic history.

### 14.4 Stable closure / ordering / fallback

- S1-081 and S1-GLOBAL-FALLBACK;
- S1-MUT-23;
- S3-081-CAUSE-IDEMPOTENCE;
- S3-084-NO-MID-CLOSURE-PUBLICATION;
- S3-090-FALLBACK-QUARANTINE;
- S4-128-NO-TECHNICAL-ID-AUTHORITY-PRECEDENCE;
- S4-156-STABLE-CLOSURE;
- S4-159-FALLBACK-QUARANTINE;
- S4-165-DECISION-SCORING-FALLBACK-VS-RESOLUTION-FALLBACK;
- S4-R06-FALLBACK-ID-QUARANTINE;
- S4-R08-STABLE-CLOSURE.

Restore cannot turn serialization/container ordering into semantic ordering or erase fallback disclosure.

### 14.5 Observer noninterference / locality

- S1-META-03;
- S1-085 / S1-META-04 / S1-MUT-26;
- S2-008-LOCALITY;
- S2-050-EPISTEMIC-READ-NONINTERFERENCE;
- S3-087-LOCALITY;
- S3-088-OBSERVER-NONINTERFERENCE;
- S4-144-LOCALITY;
- S4-145-OBSERVER-NONINTERFERENCE;
- S4-R05-LOCALITY-OBSERVER.

Checkpoint capture, checkpoint inspection and restore diagnostics must not alter the uninterrupted semantic trajectory.

### 14.6 Cache/derived nonauthority

- S1-084;
- S1-META-05;
- S1-MUT-24;
- S2-054-CACHE-NONAUTHORITY;
- S3-083-DERIVED-REFRESH-CLOSURE;
- S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE;
- S3-093-STRUCTURAL-AUTHORITY-NONHIDING;
- S4-146-DERIVED-CACHE-NONAUTHORITY;
- S4-150-STRUCTURAL-AUTHORITY-EXPLICIT;
- S4-171-S3-093-STRUCTURAL-AUTHORITY-ADAPTATION;
- S4-186-MOBILIZABLE-CAPACITY-NONAUTHORITY;
- S4-R07-CACHE-DERIVED-NONAUTHORITY.

Checkpoint convenience cannot promote a projection/cache into new authority.

### 14.7 Trace / configuration truth

- S1-086;
- S1-MUT-29;
- S2-042-SUBJECTIVE-TRACE;
- S2-055-CONFIGURATION-PROVENANCE;
- S3-092-TRACE-CONFIGURATION-TRUTH;
- S4-155-TRACE-CONFIGURATION-TRUTH;
- S4-R11-TRACE-CONFIGURATION.

Restore must not silently substitute current/default config labels for the exact configuration/rule identity of the continued run.

### 14.8 No treasury / general-economy leakage

- S3-073-NO-POOLED-HOUSEHOLD-TREASURY;
- S4-084-MULTI-CONTRIBUTOR-INSUFFICIENT-ATOMIC;
- S4-090-NO-POOLED-TREASURY;
- S4-182-V0-RESOURCE-SCAFFOLD-BOUNDARY;
- S4-186-MOBILIZABLE-CAPACITY-NONAUTHORITY;
- S4-187-RESOURCE-NONIDENTITY.

A persistence model must not manufacture a Household balance merely because that is easier to serialize.

## 15. Completion-evidence shape for a future Slice-5 manifest

A credible separate Slice-5 acceptance authority should require, at minimum:

1. immutable identity of the new Slice-5 manifest and all inherited frozen manifests;
2. a row-by-row fired-deferred census;
3. W1 cross-domain continuation pair;
4. W2 ID/frontier/fallback continuation pair;
5. W3 full derived-rebuild pair;
6. W4 safe-boundary positive/negative controls;
7. one independently executed mutant per minimum omission class in §6;
8. VH-04 evidence showing the targeted suffix actually exercised each omitted class;
9. exact stable-boundary state/history comparator evidence;
10. explicit private future-causal state/frontier coverage audit;
11. runtime checkpoint producer/fixture audit;
12. independent-oracle dependency + adequacy audit;
13. all inherited REQUIRED IDs individually green under the frozen manifest identities;
14. explicit classification of still-deferred/post-v0 rows;
15. any triggered inherited-verification adaptation approved before the corresponding coding/test edit;
16. exact candidate freeze and fresh independent post-implementation conformance before promotion.

The manifest should not simply inherit S1-083/S1-MUT-25 as one generic row and then execute a single "missing property" test. Omission-detectability is the architectural point of Slice 5 and needs class-specific continuation evidence.

## 16. L — Acceptance-authority readiness

### Semantic gap

**None identified by Commission C.**

Accepted verification authority already determines the checkpoint exactness claim, safe boundary, major future-causal classes, cache nonauthority, and required omission strategy.

This does not substitute for Commission A's semantic census. If A identifies an accepted delayed process whose lifecycle is genuinely unspecified, reconciliation must block that specific expectation rather than let verification invent it.

### Inherited-verification adaptation required

**Not currently required as a prerequisite to drafting Slice-5 acceptance. Conditional implementation trigger only.**

It becomes required before the triggering code/test edit if checkpoint implementation changes an exact inherited structural allowlist/audit path or creates a new live hidden/stale authority seam that invalidates the existing enforcement form.

### Implementation-local issues

The current implementation has no checkpoint/restore surface yet and distributes future-causal continuation state across several private partitions/counters plus used ProposalId history and initial scheduled-input/configuration state. Those are expected implementation problems, not new social semantics.

The acceptance authority must make them omission-detectable without dictating the serializer/DTO/file format.

### Commission-C readiness result

**NO BLOCKER — READY FOR SLICE-5 ACCEPTANCE PLANNING AFTER A/B/C RECONCILIATION.**

Before freeze/coding authorization, also reconcile any material inherited repair returned by the parallel Slice-1 retro-SID thread, per the active Slice-5 dispatch.

---

## 17. Required end-state summary

### Fired deferred rows

- S1-082;
- S1-083;
- S1-META-06;
- S1-MUT-25;
- S2-D07-CHECKPOINT-SUBJECTIVE-STATE;
- S3-D10-CHECKPOINT-RESTORE;
- S4-D01-CHECKPOINT-RESTORE;
- VS-SFL-082;
- VS-SFL-083;
- VH-04.

VS-SFL-084 / S1-084 / S1-META-05 / S1-MUT-24 are not newly deferred rows firing now; they are already-live inherited requirements that Slice 5 must re-exercise against the fully populated state.

### New Slice-5 completion witnesses

- W1 cross-domain exact continuation through subjective, Household/role/provision, debt, favour, scheduled-input and DEC-0014 timing state;
- W2 independent ID/frontier/gap + duplicate-ProposalId + technical-fallback exact continuation;
- W3 full derived cache/index/projection discard/rebuild + stale-derived challenge;
- W4 stable-boundary success plus mid-resolution/mid-reaction/faulted-cycle rejection.

### Omission mutants

At minimum:

- subjective knowledge/Recognition;
- provision/refusal/material-need baseline;
- Household/role/provision authority;
- pending future input/process;
- identifier/order/frontier and used-ProposalId state;
- configuration/rules identity;
- debt due state;
- favour state;
- causal/provenance references;
- stale derived state.

Each semantic mutant needs a continuation suffix that uses the corrupted class. Parse failure alone is separate evidence.

### Exact inherited regressions

Preserve exact prior IDs for:

- objective/subjective separation and no passive synchronization;
- stale/Contested evidence and provenance;
- Household/role identity continuity;
- provision/private-X/no-treasury provenance;
- DEC-0014 refusal/material-need baseline;
- stable closure/idempotence;
- fallback quarantine;
- observer noninterference;
- locality;
- cache/derived nonauthority;
- exact trace/rule/configuration truth;
- bounded v0 resource-scaffold non-generalization.

### Fixture/oracle rules

- checkpoints under judgment come from verified runtime production at a proven stable boundary;
- reused lower-slice produced state retains producer/pass/fixture/config/output provenance;
- direct checkpoint editing is mutation/corruption-only;
- semantic mutants should remain continuable when practical;
- Restore/checkpoint code cannot serve as its own omission, ID, cache or suffix oracle;
- independent checks use public semantic state/history, targeted structural inspection, independent arithmetic/timing/provenance checks, and mutation adequacy.

### Inherited-adaptation trigger

No unconditional trigger.

Trigger a separately reviewed lossless adaptation before coding only if the chosen Slice-5 implementation changes an exact inherited private-field/structural audit or otherwise invalidates its enforcement form. A clean capture/restore layer over existing authority can leave those inherited allowlists untouched while adding new Slice-5 continuation evidence.

### Acceptance-manifest blocker status

**NO BLOCKER from Commission C.**

**Recommendation: READY FOR SLICE-5 ACCEPTANCE PLANNING AFTER DISCOVERY RECONCILIATION.**
