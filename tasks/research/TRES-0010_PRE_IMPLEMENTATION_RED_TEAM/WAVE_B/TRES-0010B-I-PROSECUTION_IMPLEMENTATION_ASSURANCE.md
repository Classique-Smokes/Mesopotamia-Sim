# Research Task Packet — Prosecution: Implementation Assurance / Handoff Integrity

**Task ID:** TRES-0010B-I-PROSECUTION  
**Role:** Prosecution / hostile implementer + future-slice adversary  
**Status:** OPEN

## Findings under challenge

Review the serious implementation-assurance findings from:

- TRES-0010D: D-001 through D-005;
- TRES-0010E: F01, F04, F06, F07;
- TRES-0010F: F01 through F04;
- TRES-0010I: F01 through F04;
- TRES-0010J: F01 through F03;
- TRES-0010G: implementation hazards, especially snapshot aliasing.

Assigned branches: `tres-0010/d,e,f,g,i,j`.

## Objective

Try to prove that IMP-0001 could still:

- self-certify a bad implementation;
- force out-of-scope household behavior;
- allow oracle circularity or profile/card overfit;
- leave future-slice seams unpreserved;
- hide subjective state in global history;
- misclassify authority/supporting context;
- admit C# representation choices that violate common-snapshot semantics.

For each confirmed issue, state whether the remedy is:

- protected verification infrastructure;
- exact task-packet applicability manifest;
- implementation guardrail;
- navigation/authority wording;
- later-slice deferral.

Do not propose social-semantic changes.

## Sources

Wave-B baseline plus assigned D/E/F/G/I/J reports. Do not read defense return.

## Return

Prioritized exploit/defect list with smallest cheating implementation or future-rewrite trace, and exact pre-code consequence.
