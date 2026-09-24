# SFL v0 Slice 4 — Fresh Independent Acceptance Pre-Code Review (Candidate 1)

**Review date:** 2026-09-24  
**Review role:** fresh independent conformance / applicability reviewer  
**Authority:** advisory verdict only; candidate and accepted semantics were not edited

## Exact review target

- candidate ref: `sfl-v0-slice4-acceptance-v1-candidate1`
- exact candidate commit: `a1cd8c9848bb94ca3351d804964c070cc279aa3a`
- exact candidate path: `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_CANDIDATE.md`
- exact candidate blob: `1600332fda22ed1215485bb432e570ff9c08d52f`
- canonical semantic base: `5396b41f3b23e2833ad223d7e4eb93ed37c0eb64`
- manifest version: `SFL-V0-S4-ACCEPTANCE-v1-candidate1`

The immutable candidate ref resolves identically to the exact candidate commit. Comparison from the canonical semantic base to the exact candidate shows only the candidate manifest added; no accepted semantic artifact was changed by the candidate.

## Independence

This review was formed from the exact candidate and the independently retrieved accepted/frozen authority listed below. I was not an author of DEC-0010 promotion, the Slice-4 candidate, or a future Slice-4 implementation, and I did not rely on a later candidate repair/reconciliation before forming the verdict.

## Sources reviewed

Controlling / accepted sources independently retrieved at the exact candidate commit included:

- `AGENTS.md`
- `00_START_HERE.md`
- `decisions/DECISION_REGISTER.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0010_SLICE4_AUTHORITY_USE_BEFORE_DESTRUCTION.md`
- accepted ADR-0001 through ADR-0005
- `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md`
- `PROVISION_GROUNDING_FAMILY.md`
- `RECOGNITION_INFORMATION_FAMILY.md`
- `RESOLUTION_REACTION_FAMILY.md`
- `RESPONSE_DECISION_FAMILY.md`
- `NO_SELF_CONFIRMATION_FAMILY.md`
- `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
- `CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- frozen Slice-1/2/3 manifests and freeze records
- Slice-1/2/3 final completion/promotion records
- `research/technical/SFL_V0_SLICE4_PREIMPLEMENTATION_RECONCILIATION.md`
- the exact candidate itself

Discovery/reconciliation material was treated as planning evidence only, never as authority over the accepted SPEC/ADRs/DEC-0010/frozen manifests.

# Verdict

**BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT**

Candidate1 is substantially semantically subordinate and I found no need to reopen accepted Slice-4 social semantics. However, it is not safe to freeze unchanged because:

1. `S4-149-ISOMORPHIC-ID-RENAMING` states an ID-renaming invariant without the accepted stable-ID-fallback exception and therefore conflicts with the accepted exact-tie contributor-allocation semantics already preserved by `S4-083`; and
2. the newly executable household-mediated marriage route has no omission-detectable Slice-4 acceptance row enforcing the global grain-term validity rule on `proposedDowry` before the role-scoped head response. The inherited Slice-1 dowry row is explicitly scoped to the direct-bypass proposal shape.

Both are candidate coverage/wording repairs. Neither requires a new Director semantic decision.

# Mandatory-check results

## A. Identity and census — PASS

Mechanical audit of the exact candidate found:

- exact ref/commit identity: PASS;
- exact candidate blob: `1600332fda22ed1215485bb432e570ff9c08d52f`;
- **160 unique AcceptanceIds**;
- **149 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**;
- no duplicate AcceptanceIds;
- no hidden/duplicate aliases found in the manifest tables.

Frozen inherited manifest bytes at the candidate commit are still exactly:

- Slice 1 blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- Slice 2 blob `e4872531cf780d51fa1863f2a0b87e2424a71b69`;
- Slice 3 blob `1aae13dc27572361fe99c31ef8aee0444d39364a`.

Appendix A matches the frozen REQUIRED member sets exactly:

- Slice 1: 128 / 128;
- Slice 2: 46 / 46;
- Slice 3: 96 / 96;
- total: **270**.

The candidate does not rewrite prior manifest status or content.

## B. Semantic subordination — PASS except the two acceptance defects below

I found no candidate row that creates a new office power, creates general sovereignty, invents resignation/claimant semantics, changes provision ownership, changes mediated-marriage topology, invents a generic observation route, or broadens DEC-0010 into a general head-first rule.

The blocking issues are not semantic escalations; they are an overbroad verification statement and a missing verification ingress.

## C. DEC-0010 exactness — PASS

`S4-120..134` preserve the accepted bounded precedence:

- protected attempt valid/accepted from the common snapshot;
- all other preconditions still revalidate;
- more-specific semantic priorities remain controlling;
- destructive transition resolves afterward;
- old-head action does not rebind;
- invalid-at-snapshot attempt is not revived;
- technical ID/order/fallback does not create authority precedence.

### S4-123 challenge

`S4-123-STATUS-DEPENDENT-ROLE-TRANSITION-LAST-ACT` is within accepted Option-A scope.

DEC-0010's canonical examples explicitly include a role/authority transition that depends on a person's current institutional status completing before a paired accepted transition removes that exact required status, provided all other preconditions remain valid. The candidate also fences the rule with `S4-124`, `S4-125`, `S4-127`, and `S4-134`.

Therefore S4-123 is not an unsupported general office-priority rule.

## D. Role / appointment / succession completeness — PASS

The candidate is omission-detectable for:

- persistent role identity distinct from H and occupant;
- initial vacancy;
- no auto-election;
- current-participant nominator and nominee;
- nominee consent;
- unanimity of distinct current sustaining participants;
- precommit eligibility and current-participant-set revalidation;
- vacancy on head participation end;
- same-role succession;
- H/role identity preservation;
- no majority/ID fallback.

`S4-010`, `S4-152`, and `S4-153` provide the necessary independent-oracle path, subject to the concrete corruption probes recorded below.

## E. Head Recognition completeness — PASS

The candidate preserves:

- objective occupancy versus actor Recognition;
- direct acquisition by appointment/succession participants;
- stale outsider predecessor Recognition;
- accepted correction route;
- underlying event order over message arrival;
- Contested state;
- no participant/head/co-resident omniscience;
- exact EvidenceId/provenance checking;
- head/scope gate.

`S4-D07` explicitly keeps generic nonparticipant perception outside Slice 4. The wording in `S4-039` must therefore be read as accepted event-specific direct observation/participation/communication only, not as a new generic observer entitlement.

## F. Dual-mode agency / response accounting — PASS

Coverage is complete for:

- one personal initiative;
- one separate Household initiative;
- same committed snapshot;
- separate Household scoring concerns/profile;
- person as cognitive carrier;
- response contexts consuming neither initiative;
- compatible personal + Household commits;
- central conflict/revalidation;
- no Household mind;
- no Household initiative while vacant, Inactive, or Dissolved.

## G. Provision and spending — PASS

The candidate covers:

- endogenous solicitation;
- acceptance/decline;
- no grain movement on commitment creation;
- three-full-cycle cooldown plus relevant-context-change conjunction;
- irrelevant-change negative;
- Household support positive/negative gates;
- reserve and NeedsGrain;
- fixed-rank multi-contributor debit;
- exact capacity-tie fallback domain;
- atomic insufficient-capacity failure;
- exact debit vector;
- live capacity revalidation;
- no treasury;
- accepted provision priority.

The accepted reconsideration context list remains supplied by SPEC §8.2; the candidate does not invent a broader list.

## H. Mediated marriage — BLOCK only for missing grain-term ingress coverage

The candidate correctly preserves the accepted topology:

- groom initiates;
- bride is current female SustainingParticipant;
- groom holds bride→H fact;
- groom recognizes H and current head/scope;
- current head is the role-scoped responder;
- head acceptance is sufficient;
- no extra bride response is introduced;
- dowry is direct to groom through backing debit;
- groom→head favour;
- existing groom→head favour blocks;
- groom cannot self-authorize;
- female head self-mediation is allowed;
- mutual-strong-like bypass remains independent;
- effects are atomic and centrally revalidated.

LATER-05 is not reopened.

### Blocking omission H1 — mediated proposed-dowry categorical validity

Accepted SPEC §2.2 is global: every grain-denominated action parameter must be a strictly positive integer; zero, negative, or non-integral terms are categorically invalid and are rejected before any counterparty response. SPEC §5.1 repeats that categorical term validity precedes response activation.

The frozen Slice-1 row `S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT` deliberately covers the `ProposeMarriage(..., proposedDowry)` term on the **direct-bypass proposal shape**, because Slice 1 did not implement household mediation.

Candidate1's `S4-100..114` make the mediated route executable but do not require the same categorical dowry-term validation before the **head's role-scoped response**.

A materially wrong implementation could therefore keep the inherited direct-bypass D4 test green while allowing, for example, a zero-dowry mediated proposal to reach the head response and commit marriage/favour effects with zero material movement. That would violate accepted SPEC semantics while escaping every route-specific Slice-4 row.

This is an omission-detectability defect.

## I. Fixture / producer authority — PASS

The candidate prohibits direct fixture writing of the major result classes under judgment:

- role/occupancy;
- appointment/succession/vacancy;
- final head Recognition;
- Household decision result;
- endogenous commitment acquisition;
- spend/debit result;
- mediated marriage/favour result;
- DEC-0010 race result.

Controlled prerequisite reuse is bounded by producer/pass/fixture-audit/rule/output identity and does not itself prove the downstream result.

## J. Oracle independence and adequacy — PASS with concrete corruption set recorded

The candidate separately requires:

1. dependency independence (`S4-152`); and
2. adequate rejection strength through detached/public-boundary corruptions (`S4-153`).

The eventual independent checker should include at minimum these reviewer-owned corruptions:

1. **Role recreation:** keep H and occupant constant but substitute a freshly allocated role ID on succession; reject.
2. **Wrong H↔role link:** attach a valid role/occupant history to the wrong H; reject.
3. **Unanimity corruption:** omit one required acceptance, duplicate another participant's acceptance in its place, and substitute an outsider/wrong-party acceptance; reject all.
4. **Participant-set/time corruption:** compute unanimity from a pre-entry or post-exit participant set rather than the immediately revalidated current set; reject.
5. **Fabricated Recognition EvidenceId:** copy correct proposition/provenance content under a false held EvidenceId; reject.
6. **Passive outsider synchronization:** after unwitnessed A→B succession, inject B Recognition into outsider X without accepted acquisition; reject.
7. **False debit vector:** preserve the correct total spend but rerank contributors, debit the wrong contributor, or debit one contributor twice; reject.
8. **Broken mediated linkage:** credit dowry to H/bride instead of groom, or create the favour against the wrong/predecessor/successor head; reject.
9. **False DEC-0010 ordering:** produce the same eventual authority-destruction state but record/execute vacancy/succession/status destruction before the protected last act; reject.
10. **Allocation-ID false fallback:** use allocation/container IDs rather than the accepted semantic PersonId exact-capacity tie fallback, or claim fallback when capacities were unequal; reject.

These are within the candidate's existing oracle/corruption/metamorphic obligations and do not require new semantics.

## K. Inherited adaptation discipline — PASS

### S4-170 / S3-014

Frozen S3-014 already states the semantic invariant: newly formed H has no occupied head and exposes no Household-mode initiative/head-mediated effect merely because H exists.

If the old executable witness happened to prove that using literal type absence, adapting the executable witness to the unchanged semantic invariant is lossless. Slice-4 type existence does not retroactively make Slice-3 formation install a head.

### S4-171 / S3-093 / S1-084

This is correctly conditional. If explicit Slice-4 authoritative role state changes an exact private-field inventory used as an older structural witness, the replacement must continue to prove **no hidden behavior-affecting derived authority** and must be separately reviewed before the code/test change. Frozen rows remain unchanged.

### S4-172 / Slice-3 no-material-Household-event oracle assumptions

This is lossless only if the adapted oracle remains version/scope aware:

- historical Slice-3 Household events remain non-material as originally claimed;
- accepted Slice-4 Household material events are admitted only under the new Slice-4 rules;
- no event is renamed/camouflaged to evade the old check.

The candidate states that boundary adequately.

### S4-173 / Slice-3 fixture-only commitment provenance

The Slice-3 claim remains provable for its declared controlled pre-existing commitment setup while Slice 4 adds a distinct endogenous commitment-acquisition producer. The adaptation can be enforcement-only and does not require reclassifying the frozen Slice-3 row.

### S4-174 / S4-175

Independent review-before-change and no frozen-manifest reclassification are the correct gates.

No adaptation above requires a semantic amendment.

## L. Deferrals — PASS

The candidate correctly leaves checkpoint/restore for Slice 5 and does not accidentally require:

- world-level actor departure;
- general CandidateOrganization convergence;
- repeated-predecessor lineage source selection;
- contested succession/multiple claimants/usurpation;
- resignation while remaining participant;
- generic perception;
- trust/rumor/reputation;
- general institutional sovereignty/deep administration.

## M. Broad-claim evidence burden — BLOCK on S4-149; otherwise adequate if scope-matched evidence is enforced

Universal/exact wording such as **every**, **no**, **exact**, **persistent**, **never**, **atomic**, **independent**, **derived**, and **invariant** cannot be discharged by one happy path.

The candidate has enough cross-cutting hooks to demand the appropriate evidence classes:

- structural/negative-census audits for no-power/no-hidden-authority claims;
- boundary matrices for reserve/capacity and timing claims;
- independent set/vector reconstruction plus corruptions for exact unanimity, EvidenceIds, and debit vectors;
- paired stale/no-sync and locality metamorphics;
- fault injection for atomicity/partial-commit rejection;
- full fixture-write audit for every witness;
- mechanical frozen-ID/ref/blob comparison for inherited authority;
- enumeration and causal-intervention metamorphics for ordering/priority claims.

### Blocking wording defect M1 — S4-149 conflicts with accepted fallback semantics

Candidate row:

`S4-149-ISOMORPHIC-ID-RENAMING`

states:

> Consistent nonsemantic ID renaming preserves role/Recognition/material outcomes; IDs do not create legitimacy or authority.

That wording omits the accepted exception for deliberately exercised stable-ID fallback domains.

Accepted SPEC §8.1 requires stable semantic PersonId to order exact exposed-capacity ties during one collective expenditure. Canonical `VS-SFL-046` explicitly requires an exact-tie companion where permuting the stable IDs may swap the actor-specific debit vector while preserving the total material effect/reserve invariants and disclosing fallback use. The cross-cutting ID-renaming metamorphic likewise expressly excludes scenarios deliberately exercising disclosed stable-ID fallback.

Candidate1 itself correctly preserves this exception in:

- `S4-083-MULTI-CONTRIBUTOR-EXACT-TIE`; and
- `S4-148-NONSEMANTIC-ITERATION-METAMORPHIC` ("except explicitly accepted fallback domains").

As written, `S4-149` can therefore demand an invariant actor-specific material outcome where the accepted fallback is allowed to change it. A frozen acceptance authority must not rely on a charitable implicit exception when the adjacent rows explicitly know that exception exists.

# Smallest exact repairs required

No semantic question needs escalation. Repair the candidate only.

## Repair 1 — qualify S4-149 with the accepted fallback exception

Replace the `S4-149` obligation with wording equivalent to:

> **Consistent nonsemantic ID renaming preserves role/Recognition/material outcomes modulo isomorphism except in scenarios deliberately exercising an accepted disclosed stable-ID fallback domain. In such a fallback domain, only the accepted fallback-sensitive assignment may change; legitimacy, authority, total material effect, invariants, and fallback disclosure remain unchanged.**

This preserves the accepted exact-capacity-tie contributor fallback without allowing IDs to create office legitimacy or authority.

## Repair 2 — add omission-detectable mediated-dowry grain-term validity before head response

Add one REQUIRED row in the mediated-marriage section, e.g.:

> **S4-115-MEDIATED-DOWRY-TERM-VALIDITY — REQUIRED — On the household-mediated `ProposeMarriage` route, `proposedDowry` obeys the global grain-term validity rule: zero/negative/non-integral terms are categorically rejected before the head's `ResponseDecisionContext`, produce no material/social effect and no Declined/Unable/InvalidatedAtResolution outcome; a valid positive integer may proceed to ordinary route-specific gates.**

The evidence must exercise at least zero, negative, representative non-integral/unrepresentable-without-coercion, and valid positive-integer cases at the public semantic boundary.

If this is added as a new AcceptanceId, mechanically update every candidate census claim from:

- **160 = 149 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**

to:

- **161 = 150 REQUIRED / 9 DEFERRED / 2 UNEXERCISED**.

Do not edit any frozen Slice-1/2/3 manifest.

# Final judgment

Candidate1 is close to freeze quality and is semantically aligned on the major Slice-4 questions, including DEC-0010 and mediated-marriage authority topology. But the two defects above mean a conforming implementation could either be asked to violate an accepted fallback semantic (`S4-149`) or could violate accepted grain-term validity on the newly executable mediated route without an omission-detectable Slice-4 failure.

**BLOCK — ACCEPTANCE COVERAGE / WORDING DEFECT**
