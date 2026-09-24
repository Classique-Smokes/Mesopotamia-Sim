# Slice 1 Retrospective SID — Pass A Independent Participant-Position Frontier

**Task type:** fresh independent frontier discovery for a targeted retrospective SID audit  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Historical scope:** Slice 1 lower-level social fabric only  
**Context mode:** PROJECT-CONTEXT with strict blindness  
**Authority:** advisory only; do not change Slice-1 semantics or frozen authority

## 1. Purpose

A retrospective screen has caused the Master Architect to open a **targeted** full SID audit of Slice 1.

You are not told the screen's finding.

Your Pass-A task is independently to identify:

> **Which Slice-1 semantic positions/actions/relations have meaningful same-PersonId alias questions or distinct-party assumptions that could change cognition, initiative accounting, resource accounting, relation identity, cardinality, provenance, or response topology?**

Do not decide whether any alias is allowed or prohibited yet.

Do not recommend semantic rules.

## 2. Historical semantic boundary

Use Slice-1-era authority only.

Primary historical acceptance ref:

`sfl-v0-slice1-acceptance-v1`

Frozen acceptance authority:

`plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`

Foundational/architectural authority in force for Slice 1 includes:

- Project Seed / founding simulation philosophy;
- `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`;
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`;
- `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md`;
- accepted reference-kernel/runtime architecture existing before Slice-1 implementation.

Use the Slice-1 applicability boundary to avoid importing later-slice semantics merely because the full SPEC file contains later sections.

## 3. Semantic areas to inspect

Inspect the Slice-1 meanings actually in scope, including as applicable:

- directed attitude;
- kinship;
- gift/help;
- loan/debt/repayment;
- explicit benefit-for-favour;
- relationship-mediated reciprocal help;
- favour holder/debtor and CallFavor;
- reciprocal favour cancellation;
- Residence move/invite;
- direct marriage;
- personal initiative;
- ResponseDecisionContext;
- failed-attempt knowledge/provenance;
- same-cycle material/conflict resolution.

This list is domain orientation, not the expected alias frontier.

## 4. Strict blindness

Before your Pass-A report is durably fixed, do **not** inspect:

- `research/technical/SID_RETRO_SCREEN_SLICE1.md`;
- branches `review/sid-retro-screen-slice1-return` or any future reconciliation of it;
- any Master Architect Slice-1 retrospective SID frontier/audit artifact;
- any Pass-B task/reconciliation;
- Slice-2, Slice-3, or Slice-4 semantics as requirements;
- current Slice-4 SID pilot materials.

If you accidentally encounter the prohibited screen/MA frontier, disclose and stop.

## 5. Required method

Independently list semantic positions that may plausibly alias, for example roles such as:

- actor/initiator;
- target/counterparty;
- giver/recipient;
- lender/borrower;
- creditor/debtor;
- favour holder/debtor/fulfiller;
- proposer/mover/invitee/dwelling counterpart;
- groom/bride;
- response target;
- outer CallFavor roles versus inner requested-action roles;
- relation endpoints.

Do not assume examples above must all be distinct or may alias. They are orientation only.

For each candidate alias/frontier item:

1. identify the semantic meaning/action/relation;
2. identify the two or more positions;
3. state whether same-PersonId is structurally impossible, plausibly meaningful, or merely worth classification;
4. explain what could change if positions alias:
   - independent cognition / response;
   - initiative accounting;
   - material transfer identity;
   - debt/favour relation identity;
   - cardinality;
   - provenance/history;
   - attitude consequence direction;
   - residence transition identity;
   - nested CallFavor topology;
5. give HIGH / MEDIUM / LOW confidence that this belongs in the targeted frontier.

Do **not** resolve the result.

## 6. Important distinction

You are mapping **semantic position aliasing**, not testing whether current code rejects self-targets.

Do not treat implementation behavior as semantic authority.

You may inspect implementation only after independently listing the semantic positions, and only to note additional position shapes that need classification.

## 7. Required output

Create exactly:

`research/technical/SID_RETRO_SLICE1_PASSA_ALIAS_FRONTIER.md`

Include:

### A. Independence statement

- exact dispatch ref/commit;
- historical authority used;
- confirmation prohibited screen/MA material was not read;
- contamination disclosure.

### B. Candidate position/alias table

Recommended columns:

| ID | Slice-1 meaning | Position A | Position B / other position | Why alias matters | Confidence |
|---|---|---|---|---|---|

### C. Structurally impossible aliases

Separate aliases impossible by already accepted type/cardinality semantics from those merely absent in examples.

### D. Areas with no meaningful alias issue

List domains you considered and excluded.

### E. No semantic conclusions

State explicitly that Pass A maps the frontier only.

## 8. Return discipline

Exact dispatch ref:

`sfl-v0-slice1-retro-sid-passa-dispatch-v1`

Return branch:

`review/slice1-retro-sid-passa-return`

Begin from the exact dispatch ref and add only the report.

## 9. Stop conditions

Stop rather than guessing if:

- historical authority materially conflicts;
- determining whether a position belongs to Slice 1 requires later-slice semantics;
- you encounter the prohibited prior screen/MA frontier before freezing Pass A.
