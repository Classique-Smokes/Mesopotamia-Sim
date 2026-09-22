# Post-IMP-0001 Assurance Retrospective + Branch Hygiene

**Status:** ASSURANCE RETROSPECTIVE COMPLETE / BRANCH CENSUS PENDING  
**Role:** One combined lightweight maintenance/learning task  
**Purpose:** Capture the durable process lessons from the first independent implementation BLOCK and reduce branch clutter without turning either concern into a new bureaucracy.

## 1. Current state

The assurance-retrospective workstream is complete and has already been promoted into the existing assurance protocol without adding a new governance layer.

The remaining workstream is repository branch hygiene:

1. delegate the read-only census;
2. reconcile only ambiguous/evidence-sensitive refs;
3. perform destructive cleanup only after the **active IMP-0001 conformance lineage** no longer needs the affected refs.

At present IMP-0001 is in repair-v3 after candidate-v2 K4 BLOCK. The census may run now, but cleanup must not interfere with repair-v3, candidate-v3 freezing, or fresh candidate-v3 review.

## 2. Guiding principle

Do not respond to one implementation BLOCK by making the whole project heavier.

The default interpretation of the candidate-v1 result is:

- the assurance stack worked because a fresh independent reviewer found defects the implementation harness missed;
- the defects justify a few sharper handoff/review habits;
- they do **not** justify a new protocol, standing review panel, generalized formal-methods requirement, or larger pre-code ceremony.

Prefer one-line or one-bullet improvements to existing owning protocols over new governance artifacts.

## 3. Workstream A — institutionalize only the demonstrated lessons

### A1. Interaction-surface audit for same-cycle dependency races

Existing authority already says that if one same-cycle transition can destroy another action's authority/precondition, the interaction must be defined or deferred before both become executable.

The v1 BLOCK showed that representative known conflict tests were not enough to establish a **global** fallback/quarantine claim.

When implementation has several stateful actions sharing mutable preconditions/capacity, future consequential slice handoffs should explicitly ask:

- which accepted action commits can alter another accepted action's action-relevant preconditions;
- whether those pairs are order-invariant, semantically prioritized, or unresolved conflicts requiring disclosed technical fallback;
- whether a broad/global claim is supported by a domain-spanning audit rather than a few representative examples.

Do not require exhaustive pairwise testing when structural reasoning safely eliminates interaction.

### A2. Subjective-input provenance audit for actor decisions

Existing governance already protects objective-vs-subjective boundaries.

The v1 BLOCK showed that passing a broad objective snapshot into personal policy can silently bypass that boundary.

For actor decision contexts, consequential slice assurance should classify each behavior-affecting input as one of:

- own objective state;
- automatically known direct-party fact under accepted semantics;
- explicitly observed/communicated/supplied subjective fact;
- objective-only world fact that may be used by feasibility/resolution but not by the actor's personal deliberation.

The trace should expose every actual subjective input that affects actor choice.

This is a boundary audit, **not** an instruction to implement future observation/communication systems early.

### A3. Evidence burden for global/universal claims

A test suite of examples may establish those examples.

It does not by itself establish wording such as:

- every;
- all;
- global;
- complete;
- confined only to;
- no other case.

For broad claims, require at least one of:

- an exhaustive/omission-detectable enumeration of the bounded domain;
- structural/source reasoning that closes the remaining domain;
- a metamorphic/combinatorial probe whose scope actually spans the claim;
- a clearly documented decomposition showing why the sampled cases are representative of all remaining cases.

Do not turn this into a universal demand for formal proof.

### A4. Reviewer-owned public-boundary counterexamples

Fresh K4 review should remain free to construct small scratch probes against unchanged public APIs when existing tests appear self-consistent but a broad semantic claim remains questionable.

These probes:

- are reviewer-owned;
- do not patch the candidate;
- do not replace required canonical evidence;
- are especially useful for metamorphic relations, hidden input dependencies, and cross-action interactions.

This is already compatible with the existing optional-experiment/exhaustive-probe rules; institutionalization should clarify preference, not add a new review stage.

## 4. Governance change result

Completed result:

- **no new protocol** was added;
- the existing specification→implementation assurance protocol was sharpened for interaction-surface/global-claim evidence, subjective-input provenance, and reviewer-owned public-boundary probes;
- the delegation protocol already covered counterexample/experiment behavior sufficiently, so **NO CHANGE NEEDED** there;
- the Master Architect Guide was not expanded.

## 5. Workstream B — delegated branch census

Branch cleanup is clerical/provenance-heavy and should be delegated.

Dispatch packet: `tasks/research/POST_IMP0001_BRANCH_HYGIENE_CENSUS.md`.

The Master Architect should commission a bounded, **read-only first pass** that inventories every remote branch and returns one row per branch with:

- branch name;
- head SHA;
- open PR association, if any;
- whether head/unique commits are reachable from `main`;
- canonical files that explicitly reference the branch/ref;
- whether the branch is part of an active implementation/review lineage;
- whether it functions as a frozen authority/evidence baseline;
- whether equivalent provenance is already durable on `main` or an immutable retained ref;
- proposed class:
  - ACTIVE;
  - KEEP — FROZEN AUTHORITY/EVIDENCE;
  - KEEP — TEMPORARILY NEEDED;
  - DELETE — MERGED/REDUNDANT;
  - DELETE — ABANDONED/SUPERSEDED;
  - AMBIGUOUS — MASTER ARCHITECT REVIEW.

The census agent does **not** delete branches.

## 6. Branch-cleanup reconciliation

The Master Architect reconciles only:

- AMBIGUOUS cases;
- frozen/evidence refs;
- branches with unique unreachable commits;
- branches named in canonical authority/review records;
- branches tied to open PRs or the active v2 lineage.

Default cleanup preference after provenance is safe:

- keep `main`;
- keep currently active implementation/review branches;
- keep intentionally frozen acceptance/conformance refs that canonical records still name;
- delete merged working branches whose meaningful content is already on `main`;
- delete abandoned/superseded work branches whose unique content is neither authoritative nor intentionally preserved evidence.

Do not delete a branch merely because its commits are old.

## 7. Timing of destructive cleanup

Read-only census may begin immediately after repair-v2 return.

Actual branch deletion should wait until:

- repair-v3 has returned;
- candidate-v3 (or any later candidate) has been frozen;
- its fresh K4 disposition is known;
- the disposition of PR #7, PR #16 and active repair PR #23 is clear;
- no branch scheduled for deletion is still required to reproduce the active repair/conformance lineage.

Because v2 BLOCKed, preserve all refs needed for the v3 repair/review lineage and clean only unrelated branches until that lineage settles.

## 8. Cleanup executor

Use a separate low-authority executor for approved branch deletion.

Reason:

- deletion is high-volume clerical work;
- the Master Architect should preserve context for reconciliation and simulation work;
- the current GitHub connector may not expose branch deletion directly.

The executor receives the exact approved deletion set and may not expand it.

After deletion, it must return:

- deleted refs;
- failed deletions;
- final remote branch list;
- any discrepancy from the approved set.

## 9. Durable outputs

Expected outputs from this combined task:

1. one branch-census report under `research/technical/`;
2. one short Master Architect reconciliation identifying KEEP/DELETE decisions;
3. minimal edits, if warranted, to existing assurance/delegation protocols;
4. one cleanup execution record;
5. a leaner remote branch list with active/frozen provenance preserved.

Do not create a standing branch-cleanup bureaucracy or recurring ceremony unless branch sprawl demonstrably recurs after this pass.

## 10. Completion test

Complete when:

- the four candidate-v1 lessons are either minimally institutionalized or explicitly judged already covered;
- no new unnecessary governance layer was added;
- remote branches have been classified and the approved disposable set removed;
- every retained frozen/evidence branch has a clear reason to exist;
- a fresh Master Architect can understand both the assurance lesson and branch state without chat archaeology.
