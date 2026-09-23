# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Kima: sex=Male; grain=5; NeedsGrain=False; dwelling=D1
- P2 Bira: sex=Female; grain=7; NeedsGrain=False; dwelling=D3
- P3 Nadi: sex=Male; grain=5; NeedsGrain=False; dwelling=D2
- P4 Rima: sex=Male; grain=2; NeedsGrain=False; dwelling=D2

## Cycle 1

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=86 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=18 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=6 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Kima [P1]; Committed; reason=; event=E12
- Proposal P2: actor=Bira [P2]; Committed; reason=; event=E13
- Proposal P3: actor=Nadi [P3]; Committed; reason=; event=E14
- Proposal P4: actor=Rima [P4]; Committed; reason=; event=E15

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E5 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E6 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E7 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E8 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E9 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E10 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E11 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E12 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:4->5:Gift]
- E13 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:6->5:Gift; P4:1->2:Gift]
- E14 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:3->4:Gift]
- E15 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E16 r15: AttitudeComposition; participants=[P1,P3]; detail=43->53; fallback=False
- E17 r16: AttitudeComposition; participants=[P3,P1]; detail=3->13; fallback=False
- E18 r17: AttitudeComposition; participants=[P4,P2]; detail=-34->-24; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=6; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=18 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P5: actor=Kima [P1]; Committed; reason=; event=E29
- Proposal P6: actor=Bira [P2]; Committed; reason=; event=E30
- Proposal P7: actor=Nadi [P3]; Committed; reason=; event=E31
- Proposal P8: actor=Rima [P4]; Committed; reason=; event=E32

### Semantic events
- E19 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E20 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E21 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E22 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E23 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E24 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E25 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E26 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E27 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E28 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E29 r10: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E30 r11: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:5->6:Gift]
- E31 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:4->8:FarmSource]
- E32 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:6->10:FarmSource]
- E33 r14: AttitudeComposition; participants=[P3,P1]; detail=13->23; fallback=False
- E34 r15: AttitudeComposition; participants=[P4,P2]; detail=-24->-14; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=8; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=10; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=46 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True

### Outcomes
- Proposal P9: actor=Kima [P1]; Committed; reason=; event=E45
- Proposal P10: actor=Bira [P2]; Committed; reason=; event=E46
- Proposal P11: actor=Nadi [P3]; Committed; reason=; event=E47
- Proposal P12: actor=Rima [P4]; Committed; reason=; event=E48

### Semantic events
- E35 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E36 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E37 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:8->7:ConsumptionSink]
- E38 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:10->9:ConsumptionSink]
- E39 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E40 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E41 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E42 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E43 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E44 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E45 r10: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:7->8:Gift]
- E46 r11: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E47 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:8->7:Gift; P1:0->1:Gift]
- E48 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:9->13:FarmSource]
- E49 r14: AttitudeComposition; participants=[P1,P3]; detail=53->63; fallback=False
- E50 r15: AttitudeComposition; participants=[P3,P1]; detail=23->33; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=7; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=13; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=18 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=66 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P13: actor=Kima [P1]; Committed; reason=; event=E61
- Proposal P14: actor=Bira [P2]; Committed; reason=; event=E62
- Proposal P15: actor=Nadi [P3]; Committed; reason=; event=E63
- Proposal P16: actor=Rima [P4]; Committed; reason=; event=E64

### Semantic events
- E51 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E52 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E53 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E54 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:13->12:ConsumptionSink]
- E55 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E56 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E57 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E58 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E59 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E60 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E61 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E62 r11: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:5->4:Gift; P4:12->13:Gift]
- E63 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:6->5:Gift; P1:4->5:Gift]
- E64 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:13->17:FarmSource]
- E65 r14: AttitudeComposition; participants=[P1,P3]; detail=63->73; fallback=False
- E66 r15: AttitudeComposition; participants=[P4,P2]; detail=-14->-4; fallback=False

### Stable state
- Kima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=17; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=142 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=62 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True

### Outcomes
- Proposal P17: actor=Kima [P1]; Committed; reason=; event=E85
- Proposal P18: actor=Bira [P2]; Committed; reason=; event=E86
- Proposal P19: actor=Nadi [P3]; Committed; reason=; event=E87
- Proposal P20: actor=Rima [P4]; Committed; reason=; event=E88

### Semantic events
- E67 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E68 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E69 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E70 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:17->16:ConsumptionSink]
- E71 r4: AttitudeDecay; participants=[P1,P3]; detail=73->71; fallback=False
- E72 r5: AttitudeDecay; participants=[P1,P4]; detail=-2->-1; fallback=False
- E73 r6: AttitudeDecay; participants=[P2,P3]; detail=-22->-21; fallback=False
- E74 r7: AttitudeDecay; participants=[P2,P4]; detail=6->4; fallback=False
- E75 r8: AttitudeDecay; participants=[P3,P1]; detail=33->31; fallback=False
- E76 r9: AttitudeDecay; participants=[P3,P2]; detail=-32->-31; fallback=False
- E77 r10: AttitudeDecay; participants=[P4,P1]; detail=-36->-35; fallback=False
- E78 r11: AttitudeDecay; participants=[P4,P2]; detail=-4->-3; fallback=False
- E79 r12: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E80 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E81 r14: Proposal; participants=[P2]; detail=Farm; fallback=False
- E82 r15: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E83 r16: Response; participants=[P1]; detail=Accept; fallback=False
- E84 r17: Proposal; participants=[P4]; detail=Farm; fallback=False
- E85 r18: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:4->5:Gift]
- E86 r19: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E87 r20: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:3->4:Gift]
- E88 r21: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:16->20:FarmSource]
- E89 r22: AttitudeComposition; participants=[P1,P3]; detail=71->81; fallback=False
- E90 r23: AttitudeComposition; participants=[P3,P1]; detail=31->41; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=7; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=20; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=162 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=12 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Kima [P1]; Committed; reason=; event=E102
- Proposal P22: actor=Bira [P2]; Committed; reason=; event=E103
- Proposal P23: actor=Nadi [P3]; Committed; reason=; event=E104
- Proposal P24: actor=Rima [P4]; Committed; reason=; event=E105

### Semantic events
- E91 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E92 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E93 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E94 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:20->19:ConsumptionSink]
- E95 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E96 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E97 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E98 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E99 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E100 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E101 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E102 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E103 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:6->5:Gift; P4:19->20:Gift]
- E104 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E105 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:20->24:FarmSource]
- E106 r15: AttitudeComposition; participants=[P1,P3]; detail=81->91; fallback=False
- E107 r16: AttitudeComposition; participants=[P3,P1]; detail=41->51; fallback=False
- E108 r17: AttitudeComposition; participants=[P4,P2]; detail=-3->7; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=24; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=182 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=12 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=102 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=21 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P25: actor=Kima [P1]; Committed; reason=; event=E121
- Proposal P26: actor=Bira [P2]; Committed; reason=; event=E122
- Proposal P27: actor=Nadi [P3]; Committed; reason=; event=E123
- Proposal P28: actor=Rima [P4]; Committed; reason=; event=E124

### Semantic events
- E109 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E110 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E111 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E112 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:24->23:ConsumptionSink]
- E113 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E114 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E115 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E116 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E117 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E118 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E119 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E120 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E121 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E122 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:23->24:Gift]
- E123 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E124 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:24->23:Gift; P2:3->4:Gift]
- E125 r16: AttitudeComposition; participants=[P1,P3]; detail=91->100; fallback=False
- E126 r17: AttitudeComposition; participants=[P2,P4]; detail=4->14; fallback=False
- E127 r18: AttitudeComposition; participants=[P3,P1]; detail=51->61; fallback=False
- E128 r19: AttitudeComposition; participants=[P4,P2]; detail=7->17; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=23; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=51 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P29: actor=Kima [P1]; Committed; reason=; event=E140
- Proposal P30: actor=Bira [P2]; Committed; reason=; event=E141
- Proposal P31: actor=Nadi [P3]; Committed; reason=; event=E142
- Proposal P32: actor=Rima [P4]; Committed; reason=; event=E143

### Semantic events
- E129 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E130 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E131 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E132 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:23->22:ConsumptionSink]
- E133 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E134 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E135 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E136 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E137 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E138 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E139 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E140 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E141 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E142 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E143 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:22->21:Gift; P2:7->8:Gift]
- E144 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E145 r16: AttitudeComposition; participants=[P2,P4]; detail=14->24; fallback=False
- E146 r17: AttitudeComposition; participants=[P3,P1]; detail=61->71; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=8; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=21; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=72 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=51 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P33: actor=Kima [P1]; Committed; reason=; event=E157
- Proposal P34: actor=Bira [P2]; Committed; reason=; event=E158
- Proposal P35: actor=Nadi [P3]; Committed; reason=; event=E159
- Proposal P36: actor=Rima [P4]; Committed; reason=; event=E160

### Semantic events
- E147 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E148 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:8->7:ConsumptionSink]
- E149 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E150 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:21->20:ConsumptionSink]
- E151 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E152 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E153 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E154 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E155 r8: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E156 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E157 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E158 r11: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:7->6:Gift; P4:20->21:Gift]
- E159 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E160 r13: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:21->20:Gift; P2:6->7:Gift]
- E161 r14: AttitudeComposition; participants=[P2,P4]; detail=24->34; fallback=False
- E162 r15: AttitudeComposition; participants=[P4,P2]; detail=17->27; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=7; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=20; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=138 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=75 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P37: actor=Kima [P1]; Committed; reason=; event=E183
- Proposal P38: actor=Bira [P2]; Committed; reason=; event=E184
- Proposal P39: actor=Nadi [P3]; Committed; reason=; event=E185
- Proposal P40: actor=Rima [P4]; Committed; reason=; event=E186

### Semantic events
- E163 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E164 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E165 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E166 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:20->19:ConsumptionSink]
- E167 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E168 r5: AttitudeDecay; participants=[P1,P4]; detail=-1->0; fallback=False
- E169 r6: AttitudeDecay; participants=[P2,P3]; detail=-21->-20; fallback=False
- E170 r7: AttitudeDecay; participants=[P2,P4]; detail=34->32; fallback=False
- E171 r8: AttitudeDecay; participants=[P3,P1]; detail=71->69; fallback=False
- E172 r9: AttitudeDecay; participants=[P3,P2]; detail=-31->-30; fallback=False
- E173 r10: AttitudeDecay; participants=[P4,P1]; detail=-35->-34; fallback=False
- E174 r11: AttitudeDecay; participants=[P4,P2]; detail=27->25; fallback=False
- E175 r12: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E176 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E177 r14: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E178 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E179 r16: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E180 r17: Response; participants=[P1]; detail=Accept; fallback=False
- E181 r18: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E182 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E183 r20: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E184 r21: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:6->5:Gift; P4:19->20:Gift]
- E185 r22: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E186 r23: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:20->19:Gift; P2:5->6:Gift]
- E187 r24: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E188 r25: AttitudeComposition; participants=[P2,P4]; detail=32->42; fallback=False
- E189 r26: AttitudeComposition; participants=[P3,P1]; detail=69->79; fallback=False
- E190 r27: AttitudeComposition; participants=[P4,P2]; detail=25->35; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=19; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=126 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=158 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=105 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Kima [P1]; Committed; reason=; event=E203
- Proposal P42: actor=Bira [P2]; Committed; reason=; event=E204
- Proposal P43: actor=Nadi [P3]; Committed; reason=; event=E205
- Proposal P44: actor=Rima [P4]; Committed; reason=; event=E206

### Semantic events
- E191 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E192 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E193 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E194 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:19->18:ConsumptionSink]
- E195 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E196 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E197 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E198 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E199 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E200 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E201 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E202 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E203 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E204 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:5->4:Gift; P4:18->19:Gift]
- E205 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E206 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:19->18:Gift; P2:4->5:Gift]
- E207 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E208 r17: AttitudeComposition; participants=[P2,P4]; detail=42->52; fallback=False
- E209 r18: AttitudeComposition; participants=[P3,P1]; detail=79->89; fallback=False
- E210 r19: AttitudeComposition; participants=[P4,P2]; detail=35->45; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=18; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=178 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=135 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P45: actor=Kima [P1]; Committed; reason=; event=E223
- Proposal P46: actor=Bira [P2]; Committed; reason=; event=E224
- Proposal P47: actor=Nadi [P3]; Committed; reason=; event=E225
- Proposal P48: actor=Rima [P4]; Committed; reason=; event=E226

### Semantic events
- E211 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E212 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E213 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E214 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:18->17:ConsumptionSink]
- E215 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E216 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E217 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E218 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E219 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E220 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E221 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E222 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E223 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E224 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:17->18:Gift]
- E225 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E226 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:18->17:Gift; P2:3->4:Gift]
- E227 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E228 r17: AttitudeComposition; participants=[P2,P4]; detail=52->62; fallback=False
- E229 r18: AttitudeComposition; participants=[P3,P1]; detail=89->99; fallback=False
- E230 r19: AttitudeComposition; participants=[P4,P2]; detail=45->55; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=17; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=186 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=165 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P49: actor=Kima [P1]; Committed; reason=; event=E241
- Proposal P50: actor=Bira [P2]; Committed; reason=; event=E242
- Proposal P51: actor=Nadi [P3]; Committed; reason=; event=E243
- Proposal P52: actor=Rima [P4]; Committed; reason=; event=E244

### Semantic events
- E231 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E232 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E233 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E234 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:17->16:ConsumptionSink]
- E235 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E236 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E237 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E238 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E239 r8: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E240 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E241 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E242 r11: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:3->2:Gift; P4:16->17:Gift]
- E243 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E244 r13: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:17->16:Gift; P2:2->3:Gift]
- E245 r14: AttitudeComposition; participants=[P2,P4]; detail=62->72; fallback=False
- E246 r15: AttitudeComposition; participants=[P4,P2]; detail=55->65; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=16; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=216 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=198 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=195 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P53: actor=Kima [P1]; Committed; reason=; event=E259
- Proposal P54: actor=Bira [P2]; Committed; reason=; event=E260
- Proposal P55: actor=Nadi [P3]; Committed; reason=; event=E261
- Proposal P56: actor=Rima [P4]; Committed; reason=; event=E262

### Semantic events
- E247 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E248 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E249 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E250 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:16->15:ConsumptionSink]
- E251 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E252 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E253 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E254 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E255 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E256 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E257 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E258 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E259 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E260 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:15->16:Gift]
- E261 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E262 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:16->15:Gift; P2:1->2:Gift]
- E263 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E264 r17: AttitudeComposition; participants=[P2,P4]; detail=72->82; fallback=False
- E265 r18: AttitudeComposition; participants=[P3,P1]; detail=99->100; fallback=False
- E266 r19: AttitudeComposition; participants=[P4,P2]; detail=65->75; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=15; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=240 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=219 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P57: actor=Kima [P1]; Committed; reason=; event=E287
- Proposal P58: actor=Bira [P2]; Committed; reason=; event=E288
- Proposal P59: actor=Nadi [P3]; Committed; reason=; event=E289
- Proposal P60: actor=Rima [P4]; Committed; reason=; event=E290

### Semantic events
- E267 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E268 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E269 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E270 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:15->14:ConsumptionSink]
- E271 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E272 r5: AttitudeDecay; participants=[P1,P4]; detail=0->0; fallback=False
- E273 r6: AttitudeDecay; participants=[P2,P3]; detail=-20->-19; fallback=False
- E274 r7: AttitudeDecay; participants=[P2,P4]; detail=82->80; fallback=False
- E275 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E276 r9: AttitudeDecay; participants=[P3,P2]; detail=-30->-29; fallback=False
- E277 r10: AttitudeDecay; participants=[P4,P1]; detail=-34->-33; fallback=False
- E278 r11: AttitudeDecay; participants=[P4,P2]; detail=75->73; fallback=False
- E279 r12: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E280 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E281 r14: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E282 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E283 r16: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E284 r17: Response; participants=[P1]; detail=Accept; fallback=False
- E285 r18: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E286 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E287 r20: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E288 r21: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:14->15:Gift]
- E289 r22: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E290 r23: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:15->14:Gift; P2:0->1:Gift]
- E291 r24: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E292 r25: AttitudeComposition; participants=[P2,P4]; detail=80->90; fallback=False
- E293 r26: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E294 r27: AttitudeComposition; participants=[P4,P2]; detail=73->83; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=14; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=249 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Kima [P1]; Committed; reason=; event=E306
- Proposal P62: actor=Bira [P2]; Committed; reason=; event=E307
- Proposal P63: actor=Nadi [P3]; Committed; reason=; event=E308
- Proposal P64: actor=Rima [P4]; Committed; reason=; event=E309

### Semantic events
- E295 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E296 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E297 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E298 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:14->13:ConsumptionSink]
- E299 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E300 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E301 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E302 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E303 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E304 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E305 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E306 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E307 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E308 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E309 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:13->12:Gift; P2:4->5:Gift]
- E310 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E311 r16: AttitudeComposition; participants=[P2,P4]; detail=90->100; fallback=False
- E312 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=12; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=249 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P65: actor=Kima [P1]; Committed; reason=; event=E323
- Proposal P66: actor=Bira [P2]; Committed; reason=; event=E324
- Proposal P67: actor=Nadi [P3]; Committed; reason=; event=E325
- Proposal P68: actor=Rima [P4]; Committed; reason=; event=E326

### Semantic events
- E313 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E314 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E315 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E316 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:12->11:ConsumptionSink]
- E317 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E318 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E319 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E320 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E321 r8: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E322 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E323 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E324 r11: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:11->12:Gift]
- E325 r12: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E326 r13: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:12->11:Gift; P2:3->4:Gift]
- E327 r14: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E328 r15: AttitudeComposition; participants=[P4,P2]; detail=83->93; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=11; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=279 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P69: actor=Kima [P1]; Committed; reason=; event=E341
- Proposal P70: actor=Bira [P2]; Committed; reason=; event=E342
- Proposal P71: actor=Nadi [P3]; Committed; reason=; event=E343
- Proposal P72: actor=Rima [P4]; Committed; reason=; event=E344

### Semantic events
- E329 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E330 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E331 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E332 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:11->10:ConsumptionSink]
- E333 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E334 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E335 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E336 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E337 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E338 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E339 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E340 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E341 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E342 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:3->2:Gift; P4:10->11:Gift]
- E343 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E344 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:11->10:Gift; P2:2->3:Gift]
- E345 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E346 r17: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E347 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E348 r19: AttitudeComposition; participants=[P4,P2]; detail=93->100; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=10; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P73: actor=Kima [P1]; Committed; reason=; event=E361
- Proposal P74: actor=Bira [P2]; Committed; reason=; event=E362
- Proposal P75: actor=Nadi [P3]; Committed; reason=; event=E363
- Proposal P76: actor=Rima [P4]; Committed; reason=; event=E364

### Semantic events
- E349 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E350 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E351 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E352 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:10->9:ConsumptionSink]
- E353 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E354 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E355 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E356 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E357 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E358 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E359 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E360 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E361 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E362 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:9->10:Gift]
- E363 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E364 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:10->9:Gift; P2:1->2:Gift]
- E365 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E366 r17: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E367 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E368 r19: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=9; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P77: actor=Kima [P1]; Committed; reason=; event=E389
- Proposal P78: actor=Bira [P2]; Committed; reason=; event=E390
- Proposal P79: actor=Nadi [P3]; Committed; reason=; event=E391
- Proposal P80: actor=Rima [P4]; Committed; reason=; event=E392

### Semantic events
- E369 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E370 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E371 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E372 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:9->8:ConsumptionSink]
- E373 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E374 r5: AttitudeDecay; participants=[P1,P4]; detail=0->0; fallback=False
- E375 r6: AttitudeDecay; participants=[P2,P3]; detail=-19->-18; fallback=False
- E376 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E377 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E378 r9: AttitudeDecay; participants=[P3,P2]; detail=-29->-28; fallback=False
- E379 r10: AttitudeDecay; participants=[P4,P1]; detail=-33->-32; fallback=False
- E380 r11: AttitudeDecay; participants=[P4,P2]; detail=100->98; fallback=False
- E381 r12: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E382 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E383 r14: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E384 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E385 r16: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E386 r17: Response; participants=[P1]; detail=Accept; fallback=False
- E387 r18: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E388 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E389 r20: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E390 r21: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:8->9:Gift]
- E391 r22: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E392 r23: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:9->8:Gift; P2:0->1:Gift]
- E393 r24: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E394 r25: AttitudeComposition; participants=[P2,P4]; detail=98->100; fallback=False
- E395 r26: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E396 r27: AttitudeComposition; participants=[P4,P2]; detail=98->100; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=8; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Kima [P1]; Committed; reason=; event=E406
- Proposal P82: actor=Bira [P2]; Committed; reason=; event=E407
- Proposal P83: actor=Nadi [P3]; Committed; reason=; event=E408
- Proposal P84: actor=Rima [P4]; Committed; reason=; event=E409

### Semantic events
- E397 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E398 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E399 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E400 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:8->7:ConsumptionSink]
- E401 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E402 r5: Proposal; participants=[P2]; detail=Farm; fallback=False
- E403 r6: Proposal; participants=[P3]; detail=Farm; fallback=False
- E404 r7: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E405 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E406 r9: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E407 r10: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E408 r11: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E409 r12: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:7->6:Gift; P2:4->5:Gift]
- E410 r13: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=6; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P85: actor=Kima [P1]; Committed; reason=; event=E423
- Proposal P86: actor=Bira [P2]; Committed; reason=; event=E424
- Proposal P87: actor=Nadi [P3]; Committed; reason=; event=E425
- Proposal P88: actor=Rima [P4]; Committed; reason=; event=E426

### Semantic events
- E411 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E412 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E413 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E414 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E415 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E416 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E417 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E418 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E419 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E420 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E421 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E422 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E423 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E424 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:5->6:Gift]
- E425 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E426 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:6->5:Gift; P2:3->4:Gift]
- E427 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E428 r17: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E429 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E430 r19: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P89: actor=Kima [P1]; Committed; reason=; event=E443
- Proposal P90: actor=Bira [P2]; Committed; reason=; event=E444
- Proposal P91: actor=Nadi [P3]; Committed; reason=; event=E445
- Proposal P92: actor=Rima [P4]; Committed; reason=; event=E446

### Semantic events
- E431 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E432 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E433 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E434 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E435 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E436 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E437 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E438 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E439 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E440 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E441 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E442 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E443 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E444 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:3->2:Gift; P4:4->5:Gift]
- E445 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E446 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:2->3:Gift]
- E447 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E448 r17: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E449 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E450 r19: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P93: actor=Kima [P1]; Committed; reason=; event=E463
- Proposal P94: actor=Bira [P2]; Committed; reason=; event=E464
- Proposal P95: actor=Nadi [P3]; Committed; reason=; event=E465
- Proposal P96: actor=Rima [P4]; Committed; reason=; event=E466

### Semantic events
- E451 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E452 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E453 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E454 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E455 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E456 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E457 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E458 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E459 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E460 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E461 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E462 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E463 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E464 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:3->4:Gift]
- E465 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:0->1:Gift]
- E466 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:1->2:Gift]
- E467 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E468 r17: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E469 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E470 r19: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P97: actor=Kima [P1]; Committed; reason=; event=E489
- Proposal P98: actor=Bira [P2]; Committed; reason=; event=E490
- Proposal P99: actor=Nadi [P3]; Committed; reason=; event=E491
- Proposal P100: actor=Rima [P4]; Committed; reason=; event=E492

### Semantic events
- E471 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E472 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E473 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E474 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E475 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E476 r5: AttitudeDecay; participants=[P1,P4]; detail=0->0; fallback=False
- E477 r6: AttitudeDecay; participants=[P2,P3]; detail=-18->-17; fallback=False
- E478 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E479 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E480 r9: AttitudeDecay; participants=[P3,P2]; detail=-28->-27; fallback=False
- E481 r10: AttitudeDecay; participants=[P4,P1]; detail=-32->-31; fallback=False
- E482 r11: AttitudeDecay; participants=[P4,P2]; detail=100->98; fallback=False
- E483 r12: Proposal; participants=[P1]; detail=Farm; fallback=False
- E484 r13: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E485 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E486 r15: Proposal; participants=[P3]; detail=Farm; fallback=False
- E487 r16: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E488 r17: Response; participants=[P2]; detail=Accept; fallback=False
- E489 r18: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E490 r19: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:2->3:Gift]
- E491 r20: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E492 r21: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:3->2:Gift; P2:0->1:Gift]
- E493 r22: AttitudeComposition; participants=[P2,P4]; detail=98->100; fallback=False
- E494 r23: AttitudeComposition; participants=[P4,P2]; detail=98->100; fallback=False

### Stable state
- Kima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Kima [P1]; Committed; reason=; event=E506
- Proposal P102: actor=Bira [P2]; Committed; reason=; event=E507
- Proposal P103: actor=Nadi [P3]; Committed; reason=; event=E508
- Proposal P104: actor=Rima [P4]; Committed; reason=; event=E509

### Semantic events
- E495 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E496 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E497 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E498 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E499 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E500 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E501 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E502 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E503 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E504 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E505 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E506 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:3->4:Gift]
- E507 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E508 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:2->3:Gift]
- E509 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:1->0:Gift; P2:4->5:Gift]
- E510 r15: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E511 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E512 r17: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False

### Stable state
- Kima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P105: actor=Kima [P1]; Committed; reason=; event=E525
- Proposal P106: actor=Bira [P2]; Committed; reason=; event=E526
- Proposal P107: actor=Nadi [P3]; Committed; reason=; event=E527
- Proposal P108: actor=Rima [P4]; Committed; reason=; event=E528

### Semantic events
- E513 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E514 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E515 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E516 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E517 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E518 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E519 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E520 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E521 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E522 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E523 r10: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E524 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E525 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:2->3:Gift]
- E526 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:0->1:Gift]
- E527 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:1->2:Gift]
- E528 r15: Help; participants=[P1,P4]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:2->1:Help; P4:1->2:Help]
- E529 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E530 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E531 r18: AttitudeComposition; participants=[P4,P1]; detail=-31->-21; fallback=False
- E532 r19: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P109: actor=Kima [P1]; Committed; reason=; event=E544
- Proposal P110: actor=Bira [P2]; Committed; reason=; event=E545
- Proposal P111: actor=Nadi [P3]; Committed; reason=; event=E546
- Proposal P112: actor=Rima [P4]; Committed; reason=; event=E547

### Semantic events
- E533 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E534 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E535 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E536 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E537 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E538 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E539 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E540 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E541 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E542 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E543 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E544 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E545 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:1->2:Gift]
- E546 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:1->0:Gift; P1:4->5:Gift]
- E547 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:2->1:Gift; P2:1->2:Gift]
- E548 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E549 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E550 r17: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P113: actor=Kima [P1]; Committed; reason=; event=E562
- Proposal P114: actor=Bira [P2]; Committed; reason=; event=E563
- Proposal P115: actor=Nadi [P3]; Committed; reason=; event=E564
- Proposal P116: actor=Rima [P4]; Committed; reason=; event=E565

### Semantic events
- E551 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E552 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E553 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E554 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E555 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E556 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E557 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E558 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E559 r8: Proposal; participants=[P3]; detail=RequestGiftOrHelp(1,1); fallback=False
- E560 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E561 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E562 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:0->1:Gift]
- E563 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:0->1:Gift]
- E564 r13: Help; participants=[P1,P3]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:3->2:Help; P3:1->2:Help]
- E565 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E566 r15: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E567 r16: AttitudeComposition; participants=[P4,P2]; detail=100->100; fallback=False

### Stable state
- Kima [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=0; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Kima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bira [P2] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Bira [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P117: actor=Kima [P1]; Committed; reason=; event=E588
- Proposal P118: actor=Bira [P2]; Committed; reason=; event=E589
- Proposal P119: actor=Nadi [P3]; Committed; reason=; event=E590
- Proposal P120: actor=Rima [P4]; Committed; reason=; event=E591

### Semantic events
- E568 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E569 r1: MissedConsumption; participants=[P2]; detail=NeedsGrain; fallback=False
- E570 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E571 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E572 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E573 r5: AttitudeDecay; participants=[P1,P4]; detail=0->0; fallback=False
- E574 r6: AttitudeDecay; participants=[P2,P3]; detail=-17->-16; fallback=False
- E575 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E576 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E577 r9: AttitudeDecay; participants=[P3,P2]; detail=-27->-26; fallback=False
- E578 r10: AttitudeDecay; participants=[P4,P1]; detail=-21->-20; fallback=False
- E579 r11: AttitudeDecay; participants=[P4,P2]; detail=100->98; fallback=False
- E580 r12: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E581 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E582 r14: Proposal; participants=[P2]; detail=RequestGiftOrHelp(3,1); fallback=False
- E583 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E584 r16: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E585 r17: Response; participants=[P1]; detail=Accept; fallback=False
- E586 r18: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E587 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E588 r20: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=True material=[P1:1->0:Gift; P3:1->2:Gift]
- E589 r21: Help; participants=[P3,P2]; detail=RequestGiftOrHelp(3,1); fallback=True material=[P3:2->1:Help; P2:0->1:Help]
- E590 r22: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=True material=[P3:1->0:Gift; P1:0->1:Gift]
- E591 r23: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:1->2:Gift]
- E592 r24: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E593 r25: AttitudeComposition; participants=[P2,P3]; detail=-16->-6; fallback=False
- E594 r26: AttitudeComposition; participants=[P2,P4]; detail=98->100; fallback=False
- E595 r27: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False

### Stable state
- Kima [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bira [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Nadi [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Rima [P4]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Stop

- Horizon:30
