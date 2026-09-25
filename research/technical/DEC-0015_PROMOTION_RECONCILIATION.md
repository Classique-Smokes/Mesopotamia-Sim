# DEC-0015 — Semantic-Preservation / Promotion Reconciliation

**Status:** COMPLETE / PASS  
**Date:** 2026-09-25  
**Accepted decision:** `decisions/DEC-0015_RELATION_DIAGONAL_ADMISSIBILITY_AND_SELF_ALIAS_SEMANTICS.md`  
**Director approval:** explicit, 2026-09-25  
**Source reconciliation:** `research/technical/SID_RETRO_SLICE1_PASSB_RECONCILIATION.md`

## Promotion test

The approved Director meaning was decomposed before canonical rewrite.

| Approved commitment | Disposition | Canonical target |
|---|---|---|
| no universal all-person-roles-distinct rule | PRESERVED | SPEC §3.0; DEC-0015 |
| current bounded Slice-1 self-counterparty transfer proposals unenabled | PRESERVED | SPEC §§3.5, 5.1; VS-SFL-107 |
| current CallFavor holder/called actor self-call unenabled | PRESERVED | SPEC §3.4; VS-SFL-107 |
| valid cross-action/cross-claim aliases remain supported | PRESERVED | DEC-0015; VS-SFL-107 controls; inherited response cards |
| relation diagonal admissibility owned by each relation type | PRESERVED | SPEC §3.0; Architecture Development Policy §1.1 |
| generic relation representation must not impose universal inequality | PRESERVED | SPEC §3.0; Architecture Development Policy §1.1; VS-SFL-107 mutant |
| Attitude(P,P) valid now | PRESERVED | SPEC §§3.0, 3.1; VS-SFL-107 |
| diagonal Debt not enabled in current v0 | PRESERVED | SPEC §§3.0, 3.3; VS-SFL-107 |
| diagonal Favour not enabled in current v0 | PRESERVED | SPEC §§3.0, 3.4; VS-SFL-107 |
| current kinship/marriage diagonal excluded; Residence diagonal N-A | PRESERVED | SPEC §§3.0, 3.2, 3.6, 4 |
| future typed relations classified at conceptualization | PRESERVED | Architecture Development Policy §1.1 |
| assurance rechecks endpoint identity before consequential implementation | PRESERVED | Specification-to-Implementation Assurance Protocol §3 |
| SID alias lens distinguishes relation diagonal from action-role alias | PRESERVED | Semantic Interaction Delta Checklist §3E |
| no generic self-relation framework/global registry/policy engine | PRESERVED | DEC-0015 explicit exclusions |
| frozen Slice-1 v1 remains historical immutable evidence | PRESERVED | DEC-0015 promotion consequence; successor process only |

## Losslessness result

**PASS.**

The promoted semantics preserve the Director's refinement rather than the earlier proposal's blanket no-diagonal recommendation.

In particular:

- `Attitude(P,P)` remains deliberately valid;
- Debt/Favour diagonal behavior is not invented now;
- generic representation is prevented from foreclosing future relation-specific diagonal semantics;
- current self-counterparty actions remain boundedly invalid without turning that into a universal future doctrine;
- valid same-person multi-capacity behavior from DEC-0013 and existing Slice-1 response/conflict semantics remains intact.

## Governance placement result

The recurring relation-classification instinct is stored at the earliest appropriate durable owner:

`governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`

That rule fires when the relation is conceptualized, not merely before coding.

The downstream assurance protocol rechecks that the classification was not lost or overridden by implementation structure. The SID checklist only handles materially triggered cross-semantic alias challenges; it is not the sole owner.

No new global registry or standing governance layer was created.

## Remaining non-semantic work

Promotion closes the semantic decision but does not retroactively change frozen Slice-1 v1 acceptance.

Required next steps:

1. successor Slice-1 acceptance candidate covering DEC-0015;
2. fresh independent whole-candidate review;
3. freeze successor authority only on PASS;
4. reconcile current implementation/conformance against the successor;
5. issue corrected Slice-5 acceptance candidate because inherited authority changed materially;
6. fresh whole-candidate Slice-5 review before freeze/coding.
