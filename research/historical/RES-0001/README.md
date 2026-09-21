# RES-0001 — Old Babylonian Nippur Household Foundations

**Status:** DURABLE ADVISORY RESEARCH ARCHIVE / NON-AUTHORITATIVE

This directory preserves the recoverable outputs of the eight independent RES-0001 research streams commissioned under `tasks/research/RES-0001_OLD_BABYLONIAN_NIPPUR/`.

## Authority

These files are research evidence, not mechanics and not accepted historical propositions. A claim becomes canonical historical evidence only after Master Architect review and promotion into `registers/HISTORICAL_EVIDENCE_REGISTER.md`. Simulation mechanics require a separate design/specification decision.

The research anchor is **Old Babylonian Nippur, approximately 1900–1600 BCE**, emphasizing private/legal archives and archaeologically contextualized residential evidence. It is not a claim that Nippur represents Mesopotamia generally.

## Streams

- A — evidence landscape and source criticism
- B — kinship, marriage, and household membership
- C — adoption, inheritance, and continuity
- D — property, resources, debt, and obligation
- E — labor, dependency, slavery, and service
- F — domestic archaeology, residence, and neighborhood
- G — household–institution interfaces
- H — terminology and historical categories

## Storage

The recovery was performed through the GitHub connector, whose text interface does not accept arbitrary local binary files. The corpus is preserved in the least-lossy form available:

- A, B, D, E — original return ZIP archives, byte-for-byte.
- C, F — primary result report preserved as gzip-compressed Markdown.
- G, H — primary result report preserved as Brotli-compressed bytes, base64 encoded and split into numbered text parts for connector-safe storage.

To restore G or H locally:

```sh
cat archive/RES-0001G_RESULT.md.br.b64.part* | base64 -d | brotli -d > RES-0001G_RESULT.md
cat archive/RES-0001H_RESULT.md.br.b64.part* | base64 -d | brotli -d > RES-0001H_RESULT.md
```

The original task/program packets remain under `tasks/research/RES-0001_OLD_BABYLONIAN_NIPPUR/`.

## Reconciliation status

The intended RES-0001R cross-stream reconciliation task is preserved in `RES-0001R_RECONCILIATION_PENDING.md`. No completed reconciliation result was found in the recovered workspace.

## Context discipline

Do not load this whole archive into normal working context. Retrieve the relevant stream for the live design question, reconcile shared provenance where needed, and promote only conclusions that earn it.
