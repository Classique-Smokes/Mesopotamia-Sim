# RES-0001 — Dispatch Guide for the Project Director

## Recommended deployment

Run one independent auxiliary research agent per packet `A` through `H`. All eight may work in parallel.

Independence is useful: do not give later agents earlier agents' conclusions before they complete their own evidence review unless there is a practical need. The Master Architect will reconcile convergence and disagreement afterward.

## Instruction to give each agent

> Read every file in your assigned package before researching. Follow the specific `RES-0001X` task packet and the shared evidence/output protocol. Research broadly enough to answer the bounded question, prioritize recoverable primary evidence and specialist scholarship, preserve chronology/provenance and uncertainty, and return your report using `04_RESULT_RETURN_TEMPLATE.md`. You are an advisory research agent: do not create simulation mechanics, project requirements, or canonical decisions. Clearly distinguish Old Babylonian Nippur evidence from comparative evidence elsewhere.

No additional project history should be required. If the agent encounters an ambiguity that can be handled conservatively without changing task scope, it should record the ambiguity rather than stopping. If a missing fact would materially alter the research frame, it should flag it in the return report.

## What to return to the Master Architect

For each agent, preserve the packet ID (`RES-0001A`, etc.) in the result filename. Preferred filenames:

- `RES-0001A_RESULT.md`
- `RES-0001B_RESULT.md`
- …
- `RES-0001H_RESULT.md`

Supplementary source tables or bibliographies may accompany the main result, but the main result must include the evidence table and source ledger from the shared template.

## Do not merge the reports yourself

Return the independent reports to the Master Architect as-is. Reconciliation needs to see disagreements, duplicated sources, incompatible chronology, and different confidence judgments rather than a manually harmonized summary.

## Reconciliation stage — current next step

All eight A–H returns are now present under `research/historical/RES-0001/returns/`. Before any historical proposition is promoted, the Master Architect / RES-0001R reconciliation pass will:

1. verify scope/provenance compliance;
2. de-duplicate overlapping claims and primary texts;
3. compare conflicts in translation and scholarly interpretation;
4. apply the source-criticism findings from RES-0001A;
5. apply terminology cautions from RES-0001H;
6. identify robust, bounded historical propositions;
7. draft candidate `HE-` entries for the Historical Evidence Register;
8. identify genuine evidence gaps and follow-up research if necessary;
9. keep all design translation separate until the evidence synthesis is reviewed.


Current reconciliation task: `tasks/research/RES-0001_RECONCILIATION/RES-0001R_TASK_PACKET.md`. Current evidence intake status: `registers/HISTORICAL_EVIDENCE_REGISTER.md`.
