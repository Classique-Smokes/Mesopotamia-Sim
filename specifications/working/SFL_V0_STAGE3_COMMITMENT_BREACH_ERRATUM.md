# SFL v0 — Orphan Commitment-Breach Attitude Rule Erratum

**Status:** OPEN / REQUIRES DIRECTOR DECISION  
**Date:** 2026-09-21  
**Authority:** Working semantic erratum only.

## Gap

`SPEC-SFL-0001` currently includes:

> breach of accepted commitment: affected counterparty -> breacher -20

The current v0 action/state model has **no generic delayed AcceptedCommitment relation/process with a defined breach transition**.

Existing superficially similar cases already have separate semantics:

- called-favour refusal -> -20 and favour remains outstanding;
- unpaid debt social due -> -10 once;
- provision-commitment refusal/reconsideration has its own rule;
- central `InvalidatedAtResolution` is explicitly not refusal/breach;
- participation end is allowed and not defined as breach;
- marriage has no divorce/breach path in v0.

Therefore the generic breach attitude rule is not currently reachable without an implementation agent inventing a new commitment mechanic or double-counting an existing failure.

## Recommendation

Remove the generic `breach of accepted commitment -> -20` attitude update from SFL v0.

Do **not** add a generic commitment/breach subsystem solely to make this one attitude event reachable.

When a later subsystem introduces explicit future-performance commitments with defined fulfilment/breach semantics, it may reintroduce an appropriate attitude consequence through the normal design/authority process.

## Consequences

Removing the orphan rule does not change:

- called-favour refusal;
- debt nonpayment;
- proposal refusal/inability/invalidation;
- provision commitments;
- household participation;
- marriage.

It only prevents a dead rule from inviting invented implementation semantics.
