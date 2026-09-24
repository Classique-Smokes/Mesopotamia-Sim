# Slice 1 Retrospective SID — Pass B Alias / Distinct-Party Challenge

**Task type:** fresh negative-space challenge over reconciled Slice-1 alias frontier  
**Policy:** `SID-ASSURANCE-v1` / DEC-0012  
**Historical scope:** Slice 1 only  
**Authority:** advisory only; do not create or change Slice-1 semantics

## Preconditions

Pass A is frozen:

- ref: `sfl-v0-slice1-retro-sid-passa-v1`
- commit: `b6d0321ffa95053aba295cb8f4b5f8338c61c3cb`
- report blob: `67940ebcb4023a75f9ba13cd92272cb6f359ebfa`

Master Architect frontier is now revealed:

- ref: `sfl-v0-slice1-retro-sid-ma-frontier-v1`
- commit: `e7550e81c31235c48f2941d1cb3c8b6e2fa599f9`
- MA blob: `818f28152745b63950ef9c8a60fd87f28f127c79`

Use the union:

`research/technical/SID_RETRO_SLICE1_FRONTIER_COMPARISON_AND_PASSB_UNION.md`

## Objective

Return normally **3–7 concrete histories/questions** that help classify Slice-1 participant-position distinctness without assuming that:

- current code guards are authority;
- all same-PersonId aliases are valid;
- all semantic positions must always be distinct.

The challenge should specifically help separate:

1. structurally impossible aliases;
2. meanings that intrinsically require another person;
3. genuinely unclassified diagonal/self cases;
4. valid same-person reuse across separate actions/claims that a broad repair must not prohibit.

## Historical authority

Use only Slice-1-era accepted authority and the frozen Slice-1 applicability boundary.

Do not use Slice 2–4 semantics as evidence for what Slice 1 meant.

You may inspect current implementation only as evidence of existing shapes/guards, never as semantic authority.

## Suggested challenge families

These are prompts, not expected answers:

- P offers a gift to P;
- P requests help/loan from P;
- a loan would create creditor=debtor;
- a favour would create holder=debtor;
- P calls a favour on P;
- A calls B to repay debt owed to A (outer holder = inner creditor);
- one person is material source in one action and recipient in another;
- one target accepts multiple proposals from the common snapshot;
- multiple independent causes hit the same directed attitude edge.

Prefer histories that expose semantic consequences, not merely validation flags.

## Required format for each challenge

### ID / title

### Concrete history

Small explicit sequence.

### Positions that alias

Name the semantic positions.

### Why classification matters

Discuss any effect on:

- independent cognition / response;
- initiative;
- resource identity;
- debt/favour identity;
- cardinality;
- attitude direction;
- participant knowledge;
- provenance/history.

### Relevant historical authority

Cite Slice-1-era accepted text.

### Challenge type

Choose one:

- possible implicit distinct-party meaning;
- possible unclassified diagonal/self case;
- possible over-broad implementation prohibition;
- valid cross-action alias that must remain supported;
- structurally impossible alias.

### Confidence

HIGH / MEDIUM / LOW.

Do not state the substantive final rule.

## Required union check

Before the histories, state whether the reconciled frontier still omits any obvious Slice-1 PersonId-position alias.

If yes, add it as:

`REVIEWER PASS-B FRONTIER ADDITION`

with reason.

## Required output

Create exactly:

`research/technical/SID_RETRO_SLICE1_PASSB_ALIAS_CHALLENGE.md`

Return branch:

`review/slice1-retro-sid-passb-return`

Begin from immutable dispatch ref:

`sfl-v0-slice1-retro-sid-passb-dispatch-v1`

Add only the report.

## No semantic disposition

End by stating that:

- the report creates no Slice-1 rule;
- code behavior cannot supply missing authority;
- MA/Director reconciliation decides whether any successor semantic/acceptance repair is required.
