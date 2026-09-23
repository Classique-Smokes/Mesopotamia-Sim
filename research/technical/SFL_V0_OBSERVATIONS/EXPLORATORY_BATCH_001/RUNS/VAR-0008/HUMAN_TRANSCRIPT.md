# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Enna: sex=Male; grain=2; NeedsGrain=False; dwelling=D2
- P2 Hani: sex=Female; grain=2; NeedsGrain=False; dwelling=D3
- P3 Pala: sex=Female; grain=7; NeedsGrain=False; dwelling=D2
- P4 Saba: sex=Male; grain=4; NeedsGrain=False; dwelling=D3
- P5 Rima: sex=Male; grain=5; NeedsGrain=False; dwelling=D3
- P6 Dumu: sex=Male; grain=8; NeedsGrain=False; dwelling=D1

## Cycle 1

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=126 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=132 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=84 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=0 terms=Farm { }; TechnicalFallback=True
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Enna [P1]; Committed; reason=; event=E18
- Proposal P2: actor=Hani [P2]; Committed; reason=; event=E19
- Proposal P3: actor=Pala [P3]; Committed; reason=; event=E20
- Proposal P4: actor=Saba [P4]; Committed; reason=; event=E21
- Proposal P5: actor=Rima [P5]; Committed; reason=; event=E22
- Proposal P6: actor=Dumu [P6]; Committed; reason=; event=E23

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E5 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E6 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:8->7:ConsumptionSink]
- E7 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E8 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E9 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E10 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E11 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E12 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E13 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E14 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E15 r14: Proposal; participants=[P5]; detail=Farm; fallback=False
- E16 r15: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E17 r16: Response; participants=[P4]; detail=Accept; fallback=False
- E18 r17: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E19 r18: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:6->7:Gift]
- E20 r19: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:7->6:Gift; P2:1->2:Gift]
- E21 r20: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:4->5:Gift]
- E22 r21: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:5->9:FarmSource]
- E23 r22: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:7->6:Gift; P4:2->3:Gift]
- E24 r23: AttitudeComposition; participants=[P2,P1]; detail=-4->6; fallback=False
- E25 r24: AttitudeComposition; participants=[P2,P3]; detail=66->76; fallback=False
- E26 r25: AttitudeComposition; participants=[P3,P2]; detail=22->32; fallback=False
- E27 r26: AttitudeComposition; participants=[P4,P6]; detail=25->35; fallback=False
- E28 r27: AttitudeComposition; participants=[P5,P4]; detail=-5->5; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=9; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=64 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=84 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=15 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P7: actor=Enna [P1]; Committed; reason=; event=E47
- Proposal P8: actor=Hani [P2]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E48
- Proposal P9: actor=Pala [P3]; Committed; reason=; event=E49
- Proposal P10: actor=Saba [P4]; Committed; reason=; event=E50
- Proposal P11: actor=Rima [P5]; Committed; reason=; event=E51
- Proposal P12: actor=Dumu [P6]; Committed; reason=; event=E52

### Semantic events
- E29 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E30 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E31 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E32 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E33 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:9->8:ConsumptionSink]
- E34 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:6->5:ConsumptionSink]
- E35 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E36 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E37 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E38 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E39 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E40 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E41 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E42 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E43 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E44 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E45 r16: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E46 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E47 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=True material=[P2:1->0:Help; P1:0->1:Help]
- E48 r19: InvalidatedAtResolution; participants=[P2,P3]; detail=InsufficientAvailableGrain; fallback=True
- E49 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=True material=[P3:5->4:Gift; P2:0->1:Gift]
- E50 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:8->9:Gift]
- E51 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:9->8:Gift; P4:1->2:Gift]
- E52 r23: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:5->4:Gift; P4:2->3:Gift]
- E53 r24: AttitudeComposition; participants=[P1,P2]; detail=63->73; fallback=False
- E54 r25: AttitudeComposition; participants=[P2,P3]; detail=76->86; fallback=False
- E55 r26: AttitudeComposition; participants=[P4,P5]; detail=28->38; fallback=False
- E56 r27: AttitudeComposition; participants=[P4,P6]; detail=35->45; fallback=False
- E57 r28: AttitudeComposition; participants=[P5,P4]; detail=5->15; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=8; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=64 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=45 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P13: actor=Enna [P1]; Committed; reason=; event=E74
- Proposal P14: actor=Hani [P2]; Committed; reason=; event=E75
- Proposal P15: actor=Pala [P3]; Committed; reason=; event=E76
- Proposal P16: actor=Saba [P4]; Committed; reason=; event=E77
- Proposal P17: actor=Rima [P5]; Committed; reason=; event=E78
- Proposal P18: actor=Dumu [P6]; Committed; reason=; event=E79

### Semantic events
- E58 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E59 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E60 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E61 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E62 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:8->7:ConsumptionSink]
- E63 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:4->3:ConsumptionSink]
- E64 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E65 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E66 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E67 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E68 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E69 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E70 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E71 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E72 r14: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E73 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E74 r16: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E75 r17: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E76 r18: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:4->5:Gift]
- E77 r19: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:7->8:Gift]
- E78 r20: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:8->7:Gift; P4:1->2:Gift]
- E79 r21: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:3->2:Gift; P4:2->3:Gift]
- E80 r22: AttitudeComposition; participants=[P2,P3]; detail=86->96; fallback=False
- E81 r23: AttitudeComposition; participants=[P4,P5]; detail=38->48; fallback=False
- E82 r24: AttitudeComposition; participants=[P4,P6]; detail=45->55; fallback=False
- E83 r25: AttitudeComposition; participants=[P5,P4]; detail=15->25; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=7; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=146 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=64 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=144 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=75 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P19: actor=Enna [P1]; Committed; reason=; event=E102
- Proposal P20: actor=Hani [P2]; Committed; reason=; event=E103
- Proposal P21: actor=Pala [P3]; Committed; reason=; event=E104
- Proposal P22: actor=Saba [P4]; Committed; reason=; event=E105
- Proposal P23: actor=Rima [P5]; Committed; reason=; event=E106
- Proposal P24: actor=Dumu [P6]; Committed; reason=; event=E107

### Semantic events
- E84 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E85 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E86 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E87 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E88 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:7->6:ConsumptionSink]
- E89 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:2->1:ConsumptionSink]
- E90 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E91 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E92 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E93 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E94 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E95 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E96 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E97 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E98 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E99 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E100 r16: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E101 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E102 r18: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:4->5:Gift]
- E103 r19: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:1->2:Gift]
- E104 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:4->5:Gift]
- E105 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:6->7:Gift]
- E106 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:7->6:Gift; P4:1->2:Gift]
- E107 r23: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:1->0:Gift; P4:2->3:Gift]
- E108 r24: AttitudeComposition; participants=[P2,P1]; detail=6->16; fallback=False
- E109 r25: AttitudeComposition; participants=[P2,P3]; detail=96->100; fallback=False
- E110 r26: AttitudeComposition; participants=[P3,P2]; detail=32->42; fallback=False
- E111 r27: AttitudeComposition; participants=[P4,P5]; detail=48->58; fallback=False
- E112 r28: AttitudeComposition; participants=[P4,P6]; detail=55->65; fallback=False
- E113 r29: AttitudeComposition; participants=[P5,P4]; detail=25->35; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=6; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=142 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=168 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=99 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P25: actor=Enna [P1]; Committed; reason=; event=E143
- Proposal P26: actor=Hani [P2]; Committed; reason=; event=E144
- Proposal P27: actor=Pala [P3]; Committed; reason=; event=E145
- Proposal P28: actor=Saba [P4]; Committed; reason=; event=E146
- Proposal P29: actor=Rima [P5]; Committed; reason=; event=E147
- Proposal P30: actor=Dumu [P6]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E148

### Semantic events
- E114 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E115 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E116 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E117 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E118 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:6->5:ConsumptionSink]
- E119 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E120 r6: AttitudeDecay; participants=[P1,P2]; detail=73->71; fallback=False
- E121 r7: AttitudeDecay; participants=[P1,P6]; detail=-29->-28; fallback=False
- E122 r8: AttitudeDecay; participants=[P2,P1]; detail=16->14; fallback=False
- E123 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E124 r10: AttitudeDecay; participants=[P3,P2]; detail=42->40; fallback=False
- E125 r11: AttitudeDecay; participants=[P3,P5]; detail=-30->-29; fallback=False
- E126 r12: AttitudeDecay; participants=[P4,P5]; detail=58->56; fallback=False
- E127 r13: AttitudeDecay; participants=[P4,P6]; detail=65->63; fallback=False
- E128 r14: AttitudeDecay; participants=[P5,P3]; detail=-40->-39; fallback=False
- E129 r15: AttitudeDecay; participants=[P5,P4]; detail=35->33; fallback=False
- E130 r16: AttitudeDecay; participants=[P6,P1]; detail=-21->-20; fallback=False
- E131 r17: AttitudeDecay; participants=[P6,P4]; detail=65->63; fallback=False
- E132 r18: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E133 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E134 r20: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E135 r21: Response; participants=[P3]; detail=Accept; fallback=False
- E136 r22: Proposal; participants=[P3]; detail=Farm; fallback=False
- E137 r23: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E138 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E139 r25: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E140 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E141 r27: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E142 r28: Response; participants=[P1]; detail=Accept; fallback=False
- E143 r29: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=True material=[P1:1->0:Gift; P2:4->5:Gift]
- E144 r30: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:0->1:Gift]
- E145 r31: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E146 r32: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:5->6:Gift]
- E147 r33: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:6->5:Gift; P4:1->2:Gift]
- E148 r34: InvalidatedAtResolution; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=True
- E149 r35: AttitudeComposition; participants=[P2,P1]; detail=14->24; fallback=False
- E150 r36: AttitudeComposition; participants=[P3,P2]; detail=40->50; fallback=False
- E151 r37: AttitudeComposition; participants=[P4,P5]; detail=56->66; fallback=False
- E152 r38: AttitudeComposition; participants=[P5,P4]; detail=33->43; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=5; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=100 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=198 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=129 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P31: actor=Enna [P1]; Committed; reason=; event=E171
- Proposal P32: actor=Hani [P2]; Committed; reason=; event=E172
- Proposal P33: actor=Pala [P3]; Committed; reason=; event=E173
- Proposal P34: actor=Saba [P4]; Committed; reason=; event=E174
- Proposal P35: actor=Rima [P5]; Committed; reason=; event=E175
- Proposal P36: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E170

### Semantic events
- E153 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E154 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E155 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E156 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E157 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E158 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E159 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E160 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E161 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E162 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E163 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E164 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E165 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E166 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E167 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E168 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E169 r16: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E170 r17: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E171 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E172 r19: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:4->5:Gift]
- E173 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:1->2:Gift]
- E174 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:4->5:Gift]
- E175 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:0->1:Gift]
- E176 r23: AttitudeComposition; participants=[P1,P2]; detail=71->81; fallback=False
- E177 r24: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E178 r25: AttitudeComposition; participants=[P3,P2]; detail=50->60; fallback=False
- E179 r26: AttitudeComposition; participants=[P4,P5]; detail=66->76; fallback=False
- E180 r27: AttitudeComposition; participants=[P5,P4]; detail=43->53; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=4; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=120 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=159 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P37: actor=Enna [P1]; Committed; reason=; event=E197
- Proposal P38: actor=Hani [P2]; Committed; reason=; event=E198
- Proposal P39: actor=Pala [P3]; Committed; reason=; event=E199
- Proposal P40: actor=Saba [P4]; Committed; reason=; event=E200
- Proposal P41: actor=Rima [P5]; Committed; reason=; event=E201
- Proposal P42: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E196

### Semantic events
- E181 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E182 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E183 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E184 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E185 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E186 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E187 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E188 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E189 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E190 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E191 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E192 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E193 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E194 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E195 r14: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E196 r15: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E197 r16: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E198 r17: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:3->4:Gift]
- E199 r18: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:0->1:Gift]
- E200 r19: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E201 r20: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:4->5:Gift]
- E202 r21: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E203 r22: AttitudeComposition; participants=[P3,P2]; detail=60->70; fallback=False
- E204 r23: AttitudeComposition; participants=[P4,P5]; detail=76->86; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=2; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=162 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=140 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=258 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=159 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P43: actor=Enna [P1]; Committed; reason=; event=E222
- Proposal P44: actor=Hani [P2]; Committed; reason=; event=E223
- Proposal P45: actor=Pala [P3]; Committed; reason=; event=E224
- Proposal P46: actor=Saba [P4]; Committed; reason=; event=E225
- Proposal P47: actor=Rima [P5]; Committed; reason=; event=E226
- Proposal P48: actor=Dumu [P6]; Committed; reason=; event=E227

### Semantic events
- E205 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E206 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E207 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E208 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E209 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E210 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E211 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E212 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E213 r8: Proposal; participants=[P2]; detail=Farm; fallback=False
- E214 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E215 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E216 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E217 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E218 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E219 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E220 r15: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E221 r16: Response; participants=[P1]; detail=Accept; fallback=False
- E222 r17: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:0->1:Gift]
- E223 r18: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E224 r19: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:5->6:Gift]
- E225 r20: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:1->2:Gift]
- E226 r21: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:3->4:Gift]
- E227 r22: Help; participants=[P1,P6]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:2->1:Help; P6:0->1:Help]
- E228 r23: AttitudeComposition; participants=[P2,P1]; detail=24->34; fallback=False
- E229 r24: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E230 r25: AttitudeComposition; participants=[P4,P5]; detail=86->96; fallback=False
- E231 r26: AttitudeComposition; participants=[P5,P4]; detail=53->63; fallback=False
- E232 r27: AttitudeComposition; participants=[P6,P1]; detail=-20->-10; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=1; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=288 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P49: actor=Enna [P1]; Committed; reason=; event=E247
- Proposal P50: actor=Hani [P2]; Committed; reason=; event=E248
- Proposal P51: actor=Pala [P3]; Committed; reason=; event=E249
- Proposal P52: actor=Saba [P4]; Committed; reason=; event=E250
- Proposal P53: actor=Rima [P5]; Committed; reason=; event=E251
- Proposal P54: actor=Dumu [P6]; Committed; reason=; event=E252

### Semantic events
- E233 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E234 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E235 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E236 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E237 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E238 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:1->0:ConsumptionSink]
- E239 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E240 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E241 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E242 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E243 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E244 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E245 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E246 r13: Proposal; participants=[P6]; detail=Farm; fallback=False
- E247 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E248 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:0->1:Gift]
- E249 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E250 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:0->1:Gift]
- E251 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E252 r19: Farm; participants=[P6]; detail=Farm; fallback=False material=[P6:0->4:FarmSource]
- E253 r20: AttitudeComposition; participants=[P3,P2]; detail=70->80; fallback=False
- E254 r21: AttitudeComposition; participants=[P5,P4]; detail=63->73; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=5; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=158 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=282 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=213 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P55: actor=Enna [P1]; Committed; reason=; event=E285
- Proposal P56: actor=Hani [P2]; Committed; reason=; event=E286
- Proposal P57: actor=Pala [P3]; Committed; reason=; event=E287
- Proposal P58: actor=Saba [P4]; Committed; reason=; event=E288
- Proposal P59: actor=Rima [P5]; Committed; reason=; event=E289
- Proposal P60: actor=Dumu [P6]; Committed; reason=; event=E290

### Semantic events
- E255 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E256 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E257 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E258 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E259 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E260 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:4->3:ConsumptionSink]
- E261 r6: AttitudeDecay; participants=[P1,P2]; detail=81->79; fallback=False
- E262 r7: AttitudeDecay; participants=[P1,P6]; detail=-28->-27; fallback=False
- E263 r8: AttitudeDecay; participants=[P2,P1]; detail=34->32; fallback=False
- E264 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E265 r10: AttitudeDecay; participants=[P3,P2]; detail=80->78; fallback=False
- E266 r11: AttitudeDecay; participants=[P3,P5]; detail=-29->-28; fallback=False
- E267 r12: AttitudeDecay; participants=[P4,P5]; detail=96->94; fallback=False
- E268 r13: AttitudeDecay; participants=[P4,P6]; detail=63->61; fallback=False
- E269 r14: AttitudeDecay; participants=[P5,P3]; detail=-39->-38; fallback=False
- E270 r15: AttitudeDecay; participants=[P5,P4]; detail=73->71; fallback=False
- E271 r16: AttitudeDecay; participants=[P6,P1]; detail=-10->-9; fallback=False
- E272 r17: AttitudeDecay; participants=[P6,P4]; detail=63->61; fallback=False
- E273 r18: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E274 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E275 r20: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E276 r21: Response; participants=[P3]; detail=Accept; fallback=False
- E277 r22: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E278 r23: Response; participants=[P2]; detail=Accept; fallback=False
- E279 r24: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E280 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E281 r26: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E282 r27: Response; participants=[P4]; detail=Accept; fallback=False
- E283 r28: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E284 r29: Response; participants=[P4]; detail=Accept; fallback=False
- E285 r30: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E286 r31: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:4->5:Gift]
- E287 r32: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:3->4:Gift]
- E288 r33: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:4->5:Gift]
- E289 r34: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:0->1:Gift]
- E290 r35: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:3->2:Gift; P4:1->2:Gift]
- E291 r36: AttitudeComposition; participants=[P2,P1]; detail=32->42; fallback=False
- E292 r37: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E293 r38: AttitudeComposition; participants=[P3,P2]; detail=78->88; fallback=False
- E294 r39: AttitudeComposition; participants=[P4,P5]; detail=94->100; fallback=False
- E295 r40: AttitudeComposition; participants=[P4,P6]; detail=61->71; fallback=False
- E296 r41: AttitudeComposition; participants=[P5,P4]; detail=71->81; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=4; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=158 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=176 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=243 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=122 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Enna [P1]; Committed; reason=; event=E315
- Proposal P62: actor=Hani [P2]; Committed; reason=; event=E316
- Proposal P63: actor=Pala [P3]; Committed; reason=; event=E317
- Proposal P64: actor=Saba [P4]; Committed; reason=; event=E318
- Proposal P65: actor=Rima [P5]; Committed; reason=; event=E319
- Proposal P66: actor=Dumu [P6]; Committed; reason=; event=E320

### Semantic events
- E297 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E298 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E299 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E300 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E301 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E302 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:2->1:ConsumptionSink]
- E303 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E304 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E305 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E306 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E307 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E308 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E309 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E310 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E311 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E312 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E313 r16: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E314 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E315 r18: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:3->4:Gift]
- E316 r19: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:3->4:Gift]
- E317 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:3->4:Gift]
- E318 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:3->4:Gift]
- E319 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:0->1:Gift]
- E320 r23: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:1->0:Gift; P4:1->2:Gift]
- E321 r24: AttitudeComposition; participants=[P2,P1]; detail=42->52; fallback=False
- E322 r25: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E323 r26: AttitudeComposition; participants=[P3,P2]; detail=88->98; fallback=False
- E324 r27: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E325 r28: AttitudeComposition; participants=[P4,P6]; detail=71->81; fallback=False
- E326 r29: AttitudeComposition; participants=[P5,P4]; detail=81->91; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=3; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=273 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P67: actor=Enna [P1]; Committed; reason=; event=E345
- Proposal P68: actor=Hani [P2]; Committed; reason=; event=E346
- Proposal P69: actor=Pala [P3]; Committed; reason=; event=E347
- Proposal P70: actor=Saba [P4]; Committed; reason=; event=E348
- Proposal P71: actor=Rima [P5]; Committed; reason=; event=E349
- Proposal P72: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E344

### Semantic events
- E327 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E328 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E329 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E330 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E331 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E332 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E333 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E334 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E335 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E336 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E337 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E338 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E339 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E340 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E341 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E342 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E343 r16: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E344 r17: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E345 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E346 r19: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:2->3:Gift]
- E347 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:1->2:Gift]
- E348 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:2->3:Gift]
- E349 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:0->1:Gift]
- E350 r23: AttitudeComposition; participants=[P1,P2]; detail=79->89; fallback=False
- E351 r24: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E352 r25: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E353 r26: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E354 r27: AttitudeComposition; participants=[P5,P4]; detail=91->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=2; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P73: actor=Enna [P1]; Committed; reason=; event=E371
- Proposal P74: actor=Hani [P2]; Committed; reason=; event=E372
- Proposal P75: actor=Pala [P3]; Committed; reason=; event=E373
- Proposal P76: actor=Saba [P4]; Committed; reason=; event=E374
- Proposal P77: actor=Rima [P5]; Committed; reason=; event=E375
- Proposal P78: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E370

### Semantic events
- E355 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E356 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E357 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E358 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E359 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E360 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E361 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E362 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E363 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E364 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E365 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E366 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E367 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E368 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E369 r14: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E370 r15: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E371 r16: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E372 r17: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:1->2:Gift]
- E373 r18: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:0->1:Gift]
- E374 r19: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E375 r20: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:4->5:Gift]
- E376 r21: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E377 r22: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E378 r23: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=0; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=178 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/Feasibility: none; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P79: actor=Enna [P1]; Committed; reason=; event=E395
- Proposal P80: actor=Hani [P2]; Committed; reason=; event=E396
- Proposal P81: actor=Pala [P3]; Committed; reason=; event=E397
- Proposal P82: actor=Saba [P4]; Committed; reason=; event=E398
- Proposal P83: actor=Rima [P5]; Unable; reason=InsufficientAvailableGrain; event=E392
- Proposal P84: actor=Dumu [P6]; Committed; reason=; event=E399

### Semantic events
- E379 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E380 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E381 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E382 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E383 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E384 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E385 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E386 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E387 r8: Proposal; participants=[P2]; detail=Farm; fallback=False
- E388 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E389 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E390 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E391 r12: Proposal; participants=[P5]; detail=RequestGiftOrHelp(3,1); fallback=False
- E392 r13: Unable; participants=[P5,P3]; detail=InsufficientAvailableGrain; fallback=False
- E393 r14: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E394 r15: Response; participants=[P1]; detail=Accept; fallback=False
- E395 r16: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:0->1:Gift]
- E396 r17: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E397 r18: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E398 r19: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:0->1:Gift]
- E399 r20: Help; participants=[P1,P6]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:2->1:Help; P6:0->1:Help]
- E400 r21: AttitudeComposition; participants=[P2,P1]; detail=52->62; fallback=False
- E401 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False
- E402 r23: AttitudeComposition; participants=[P6,P1]; detail=-9->1; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=1; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P85: actor=Enna [P1]; Committed; reason=; event=E430
- Proposal P86: actor=Hani [P2]; Committed; reason=; event=E431
- Proposal P87: actor=Pala [P3]; Committed; reason=; event=E432
- Proposal P88: actor=Saba [P4]; Committed; reason=; event=E433
- Proposal P89: actor=Rima [P5]; Committed; reason=; event=E434
- Proposal P90: actor=Dumu [P6]; Committed; reason=; event=E435

### Semantic events
- E403 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E404 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E405 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E406 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E407 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E408 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:1->0:ConsumptionSink]
- E409 r6: AttitudeDecay; participants=[P1,P2]; detail=89->87; fallback=False
- E410 r7: AttitudeDecay; participants=[P1,P6]; detail=-27->-26; fallback=False
- E411 r8: AttitudeDecay; participants=[P2,P1]; detail=62->60; fallback=False
- E412 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E413 r10: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E414 r11: AttitudeDecay; participants=[P3,P5]; detail=-28->-27; fallback=False
- E415 r12: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E416 r13: AttitudeDecay; participants=[P4,P6]; detail=81->79; fallback=False
- E417 r14: AttitudeDecay; participants=[P5,P3]; detail=-38->-37; fallback=False
- E418 r15: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E419 r16: AttitudeDecay; participants=[P6,P1]; detail=1->0; fallback=False
- E420 r17: AttitudeDecay; participants=[P6,P4]; detail=61->59; fallback=False
- E421 r18: Proposal; participants=[P1]; detail=Farm; fallback=False
- E422 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E423 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E424 r21: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E425 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E426 r23: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E427 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E428 r25: Proposal; participants=[P5]; detail=Farm; fallback=False
- E429 r26: Proposal; participants=[P6]; detail=Farm; fallback=False
- E430 r27: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E431 r28: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:3->4:Gift]
- E432 r29: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:3->4:Gift]
- E433 r30: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:0->1:Gift]
- E434 r31: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E435 r32: Farm; participants=[P6]; detail=Farm; fallback=False material=[P6:0->4:FarmSource]
- E436 r33: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E437 r34: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E438 r35: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=5; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=174 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=118 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P91: actor=Enna [P1]; Committed; reason=; event=E456
- Proposal P92: actor=Hani [P2]; Committed; reason=; event=E457
- Proposal P93: actor=Pala [P3]; Committed; reason=; event=E458
- Proposal P94: actor=Saba [P4]; Committed; reason=; event=E459
- Proposal P95: actor=Rima [P5]; Committed; reason=; event=E460
- Proposal P96: actor=Dumu [P6]; Committed; reason=; event=E461

### Semantic events
- E439 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E440 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E441 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E442 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E443 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E444 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:4->3:ConsumptionSink]
- E445 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E446 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E447 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E448 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E449 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E450 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E451 r12: Proposal; participants=[P4]; detail=Farm; fallback=False
- E452 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E453 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E454 r15: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E455 r16: Response; participants=[P4]; detail=Accept; fallback=False
- E456 r17: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E457 r18: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E458 r19: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E459 r20: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E460 r21: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:4->5:Gift]
- E461 r22: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:3->2:Gift; P4:5->6:Gift]
- E462 r23: AttitudeComposition; participants=[P2,P1]; detail=60->70; fallback=False
- E463 r24: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E464 r25: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E465 r26: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E466 r27: AttitudeComposition; participants=[P4,P6]; detail=79->89; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=6; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=3; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=174 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=118 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P97: actor=Enna [P1]; Committed; reason=; event=E485
- Proposal P98: actor=Hani [P2]; Committed; reason=; event=E486
- Proposal P99: actor=Pala [P3]; Committed; reason=; event=E487
- Proposal P100: actor=Saba [P4]; Committed; reason=; event=E488
- Proposal P101: actor=Rima [P5]; Committed; reason=; event=E489
- Proposal P102: actor=Dumu [P6]; Committed; reason=; event=E490

### Semantic events
- E467 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E468 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E469 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E470 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E471 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E472 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:2->1:ConsumptionSink]
- E473 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E474 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E475 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E476 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E477 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E478 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E479 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E480 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E481 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E482 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E483 r16: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E484 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E485 r18: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:3->4:Gift]
- E486 r19: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:1->2:Gift]
- E487 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:3->4:Gift]
- E488 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:2->3:Gift]
- E489 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:4->5:Gift]
- E490 r23: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:1->0:Gift; P4:5->6:Gift]
- E491 r24: AttitudeComposition; participants=[P2,P1]; detail=70->80; fallback=False
- E492 r25: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E493 r26: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E494 r27: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E495 r28: AttitudeComposition; participants=[P4,P6]; detail=89->99; fallback=False
- E496 r29: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=6; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=2; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P103: actor=Enna [P1]; Committed; reason=; event=E514
- Proposal P104: actor=Hani [P2]; Committed; reason=; event=E515
- Proposal P105: actor=Pala [P3]; Committed; reason=; event=E516
- Proposal P106: actor=Saba [P4]; Committed; reason=; event=E517
- Proposal P107: actor=Rima [P5]; Committed; reason=; event=E518
- Proposal P108: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E513

### Semantic events
- E497 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E498 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E499 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E500 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E501 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E502 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E503 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E504 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E505 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E506 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E507 r10: Proposal; participants=[P3]; detail=Farm; fallback=False
- E508 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E509 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E510 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E511 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E512 r15: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E513 r16: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E514 r17: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E515 r18: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E516 r19: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E517 r20: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:1->2:Gift]
- E518 r21: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:4->5:Gift]
- E519 r22: AttitudeComposition; participants=[P1,P2]; detail=87->97; fallback=False
- E520 r23: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E521 r24: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E522 r25: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=1; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P109: actor=Enna [P1]; Committed; reason=; event=E538
- Proposal P110: actor=Hani [P2]; Committed; reason=; event=E539
- Proposal P111: actor=Pala [P3]; Committed; reason=; event=E540
- Proposal P112: actor=Saba [P4]; Committed; reason=; event=E541
- Proposal P113: actor=Rima [P5]; Committed; reason=; event=E542
- Proposal P114: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E537

### Semantic events
- E523 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E524 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E525 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E526 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E527 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E528 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E529 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E530 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E531 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E532 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E533 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E534 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E535 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E536 r13: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E537 r14: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E538 r15: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E539 r16: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E540 r17: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E541 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:0->1:Gift]
- E542 r19: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E543 r20: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E544 r21: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=5; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=190 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P115: actor=Enna [P1]; Committed; reason=; event=E575
- Proposal P116: actor=Hani [P2]; Committed; reason=; event=E576
- Proposal P117: actor=Pala [P3]; Committed; reason=; event=E577
- Proposal P118: actor=Saba [P4]; Committed; reason=; event=E578
- Proposal P119: actor=Rima [P5]; Committed; reason=; event=E579
- Proposal P120: actor=Dumu [P6]; Committed; reason=; event=E580

### Semantic events
- E545 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E546 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E547 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E548 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E549 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E550 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E551 r6: AttitudeDecay; participants=[P1,P2]; detail=97->95; fallback=False
- E552 r7: AttitudeDecay; participants=[P1,P6]; detail=-26->-25; fallback=False
- E553 r8: AttitudeDecay; participants=[P2,P1]; detail=80->78; fallback=False
- E554 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E555 r10: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E556 r11: AttitudeDecay; participants=[P3,P5]; detail=-27->-26; fallback=False
- E557 r12: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E558 r13: AttitudeDecay; participants=[P4,P6]; detail=99->97; fallback=False
- E559 r14: AttitudeDecay; participants=[P5,P3]; detail=-37->-36; fallback=False
- E560 r15: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E561 r16: AttitudeDecay; participants=[P6,P1]; detail=0->0; fallback=False
- E562 r17: AttitudeDecay; participants=[P6,P4]; detail=59->57; fallback=False
- E563 r18: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E564 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E565 r20: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E566 r21: Response; participants=[P3]; detail=Accept; fallback=False
- E567 r22: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E568 r23: Response; participants=[P2]; detail=Accept; fallback=False
- E569 r24: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E570 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E571 r26: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E572 r27: Response; participants=[P4]; detail=Accept; fallback=False
- E573 r28: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E574 r29: Response; participants=[P1]; detail=Accept; fallback=False
- E575 r30: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:4->5:Gift]
- E576 r31: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:2->3:Gift]
- E577 r32: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:4->5:Gift]
- E578 r33: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:4->5:Gift]
- E579 r34: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:1->2:Gift]
- E580 r35: Help; participants=[P1,P6]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:2->1:Help; P6:0->1:Help]
- E581 r36: AttitudeComposition; participants=[P2,P1]; detail=78->88; fallback=False
- E582 r37: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E583 r38: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E584 r39: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E585 r40: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False
- E586 r41: AttitudeComposition; participants=[P6,P1]; detail=0->10; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=4; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P121: actor=Enna [P1]; Committed; reason=; event=E603
- Proposal P122: actor=Hani [P2]; Committed; reason=; event=E604
- Proposal P123: actor=Pala [P3]; Committed; reason=; event=E605
- Proposal P124: actor=Saba [P4]; Committed; reason=; event=E606
- Proposal P125: actor=Rima [P5]; Committed; reason=; event=E607
- Proposal P126: actor=Dumu [P6]; Committed; reason=; event=E608

### Semantic events
- E587 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E588 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E589 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E590 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E591 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E592 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:1->0:ConsumptionSink]
- E593 r6: Proposal; participants=[P1]; detail=Farm; fallback=False
- E594 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E595 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E596 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E597 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E598 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E599 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E600 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E601 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E602 r15: Proposal; participants=[P6]; detail=Farm; fallback=False
- E603 r16: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E604 r17: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:1->2:Gift]
- E605 r18: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:3->4:Gift]
- E606 r19: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:3->4:Gift]
- E607 r20: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:0->1:Gift]
- E608 r21: Farm; participants=[P6]; detail=Farm; fallback=False material=[P6:0->4:FarmSource]
- E609 r22: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E610 r23: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E611 r24: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E612 r25: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=3; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=190 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P127: actor=Enna [P1]; Committed; reason=; event=E629
- Proposal P128: actor=Hani [P2]; Committed; reason=; event=E630
- Proposal P129: actor=Pala [P3]; Committed; reason=; event=E631
- Proposal P130: actor=Saba [P4]; Committed; reason=; event=E632
- Proposal P131: actor=Rima [P5]; Committed; reason=; event=E633
- Proposal P132: actor=Dumu [P6]; Committed; reason=; event=E634

### Semantic events
- E613 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E614 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E615 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E616 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E617 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E618 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:4->3:ConsumptionSink]
- E619 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E620 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E621 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E622 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E623 r10: Proposal; participants=[P3]; detail=Farm; fallback=False
- E624 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E625 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E626 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E627 r14: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E628 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E629 r16: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E630 r17: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:0->1:Gift]
- E631 r18: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E632 r19: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E633 r20: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:4->5:Gift]
- E634 r21: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:3->2:Gift; P4:5->6:Gift]
- E635 r22: AttitudeComposition; participants=[P2,P1]; detail=88->98; fallback=False
- E636 r23: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E637 r24: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E638 r25: AttitudeComposition; participants=[P4,P6]; detail=97->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=6; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=1; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=190 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Pala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P133: actor=Enna [P1]; Committed; reason=; event=E656
- Proposal P134: actor=Hani [P2]; Committed; reason=; event=E657
- Proposal P135: actor=Pala [P3]; Committed; reason=; event=E658
- Proposal P136: actor=Saba [P4]; Committed; reason=; event=E659
- Proposal P137: actor=Rima [P5]; Committed; reason=; event=E660
- Proposal P138: actor=Dumu [P6]; Committed; reason=; event=E661

### Semantic events
- E639 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E640 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E641 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E642 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E643 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E644 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:2->1:ConsumptionSink]
- E645 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E646 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E647 r8: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E648 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E649 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E650 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E651 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E652 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E653 r14: Proposal; participants=[P5]; detail=Farm; fallback=False
- E654 r15: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E655 r16: Response; participants=[P4]; detail=Accept; fallback=False
- E656 r17: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:2->3:Gift]
- E657 r18: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:4->5:Gift]
- E658 r19: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:2->3:Gift]
- E659 r20: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:0->1:Gift]
- E660 r21: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E661 r22: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:1->0:Gift; P4:4->5:Gift]
- E662 r23: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E663 r24: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E664 r25: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E665 r26: AttitudeComposition; participants=[P4,P6]; detail=100->100; fallback=False
- E666 r27: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=5; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P139: actor=Enna [P1]; Committed; reason=; event=E685
- Proposal P140: actor=Hani [P2]; Committed; reason=; event=E686
- Proposal P141: actor=Pala [P3]; Committed; reason=; event=E687
- Proposal P142: actor=Saba [P4]; Committed; reason=; event=E688
- Proposal P143: actor=Rima [P5]; Committed; reason=; event=E689
- Proposal P144: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E684

### Semantic events
- E667 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E668 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E669 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E670 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E671 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E672 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E673 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E674 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E675 r8: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E676 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E677 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E678 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E679 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E680 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E681 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E682 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E683 r16: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E684 r17: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E685 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:2->1:Help; P1:0->1:Help]
- E686 r19: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:1->0:Gift; P1:1->2:Gift]
- E687 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:0->1:Gift]
- E688 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:4->5:Gift]
- E689 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:3->4:Gift]
- E690 r23: AttitudeComposition; participants=[P1,P2]; detail=95->100; fallback=False
- E691 r24: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E692 r25: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E693 r26: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=4; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P145: actor=Enna [P1]; Committed; reason=; event=E723
- Proposal P146: actor=Hani [P2]; Committed; reason=; event=E724
- Proposal P147: actor=Pala [P3]; Committed; reason=; event=E725
- Proposal P148: actor=Saba [P4]; Committed; reason=; event=E726
- Proposal P149: actor=Rima [P5]; Committed; reason=; event=E727
- Proposal P150: actor=Dumu [P6]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E728

### Semantic events
- E694 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E695 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E696 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E697 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E698 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E699 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E700 r6: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E701 r7: AttitudeDecay; participants=[P1,P6]; detail=-25->-24; fallback=False
- E702 r8: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E703 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E704 r10: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E705 r11: AttitudeDecay; participants=[P3,P5]; detail=-26->-25; fallback=False
- E706 r12: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E707 r13: AttitudeDecay; participants=[P4,P6]; detail=100->98; fallback=False
- E708 r14: AttitudeDecay; participants=[P5,P3]; detail=-36->-35; fallback=False
- E709 r15: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E710 r16: AttitudeDecay; participants=[P6,P1]; detail=10->8; fallback=False
- E711 r17: AttitudeDecay; participants=[P6,P4]; detail=57->55; fallback=False
- E712 r18: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E713 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E714 r20: Proposal; participants=[P2]; detail=Farm; fallback=False
- E715 r21: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E716 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E717 r23: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E718 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E719 r25: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E720 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E721 r27: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E722 r28: Response; participants=[P1]; detail=Accept; fallback=False
- E723 r29: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=True material=[P1:1->0:Gift; P2:0->1:Gift]
- E724 r30: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E725 r31: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:1->0:Gift; P2:5->6:Gift]
- E726 r32: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E727 r33: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E728 r34: InvalidatedAtResolution; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=True
- E729 r35: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E730 r36: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E731 r37: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E732 r38: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=3; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P151: actor=Enna [P1]; Committed; reason=; event=E751
- Proposal P152: actor=Hani [P2]; Committed; reason=; event=E752
- Proposal P153: actor=Pala [P3]; Committed; reason=; event=E753
- Proposal P154: actor=Saba [P4]; Committed; reason=; event=E754
- Proposal P155: actor=Rima [P5]; Committed; reason=; event=E755
- Proposal P156: actor=Dumu [P6]; Unable; reason=InsufficientAvailableGrain; event=E750

### Semantic events
- E733 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E734 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E735 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E736 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E737 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E738 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E739 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E740 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E741 r8: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E742 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E743 r10: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E744 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E745 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E746 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E747 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E748 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E749 r16: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E750 r17: Unable; participants=[P6,P1]; detail=InsufficientAvailableGrain; fallback=False
- E751 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:5->4:Help; P1:0->1:Help]
- E752 r19: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:1->2:Gift]
- E753 r20: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P3:0->1:Help]
- E754 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:2->3:Gift]
- E755 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:1->2:Gift]
- E756 r23: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E757 r24: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E758 r25: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E759 r26: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=2; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=True; dwelling=D1
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P157: actor=Enna [P1]; Committed; reason=; event=E777
- Proposal P158: actor=Hani [P2]; Committed; reason=; event=E778
- Proposal P159: actor=Pala [P3]; Committed; reason=; event=E779
- Proposal P160: actor=Saba [P4]; Committed; reason=; event=E780
- Proposal P161: actor=Rima [P5]; Committed; reason=; event=E781
- Proposal P162: actor=Dumu [P6]; Committed; reason=; event=E782

### Semantic events
- E760 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E761 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E762 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E763 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E764 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E765 r5: MissedConsumption; participants=[P6]; detail=NeedsGrain; fallback=False
- E766 r6: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E767 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E768 r8: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E769 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E770 r10: Proposal; participants=[P3]; detail=Farm; fallback=False
- E771 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E772 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E773 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E774 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E775 r15: Proposal; participants=[P6]; detail=RequestGiftOrHelp(1,1); fallback=False
- E776 r16: Response; participants=[P1]; detail=Accept; fallback=False
- E777 r17: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=True material=[P1:1->0:Gift; P2:1->2:Gift]
- E778 r18: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=True material=[P2:2->1:Gift; P1:0->1:Gift]
- E779 r19: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E780 r20: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:1->2:Gift]
- E781 r21: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:0->1:Gift]
- E782 r22: Help; participants=[P1,P6]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P6:0->1:Help]
- E783 r23: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E784 r24: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E785 r25: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E786 r26: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False
- E787 r27: AttitudeComposition; participants=[P6,P1]; detail=8->18; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=1; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/Feasibility: none; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P163: actor=Enna [P1]; Unable; reason=InsufficientAvailableGrain; event=E795
- Proposal P164: actor=Hani [P2]; Committed; reason=; event=E802
- Proposal P165: actor=Pala [P3]; Committed; reason=; event=E803
- Proposal P166: actor=Saba [P4]; Committed; reason=; event=E804
- Proposal P167: actor=Rima [P5]; Committed; reason=; event=E805
- Proposal P168: actor=Dumu [P6]; Committed; reason=; event=E806

### Semantic events
- E788 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E789 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E790 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E791 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E792 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E793 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:1->0:ConsumptionSink]
- E794 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E795 r7: Unable; participants=[P1,P2]; detail=InsufficientAvailableGrain; fallback=False
- E796 r8: Proposal; participants=[P2]; detail=Farm; fallback=False
- E797 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E798 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E799 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E800 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E801 r13: Proposal; participants=[P6]; detail=Farm; fallback=False
- E802 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E803 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:4->5:Gift]
- E804 r16: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E805 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:0->4:FarmSource]
- E806 r18: Farm; participants=[P6]; detail=Farm; fallback=False material=[P6:0->4:FarmSource]
- E807 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=True; dwelling=D2
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=4; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=110 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P169: actor=Enna [P1]; Committed; reason=; event=E826
- Proposal P170: actor=Hani [P2]; Committed; reason=; event=E827
- Proposal P171: actor=Pala [P3]; Committed; reason=; event=E828
- Proposal P172: actor=Saba [P4]; Committed; reason=; event=E829
- Proposal P173: actor=Rima [P5]; Committed; reason=; event=E830
- Proposal P174: actor=Dumu [P6]; Committed; reason=; event=E831

### Semantic events
- E808 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E809 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E810 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E811 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E812 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E813 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:4->3:ConsumptionSink]
- E814 r6: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E815 r7: Response; participants=[P2]; detail=Accept; fallback=False
- E816 r8: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E817 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E818 r10: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E819 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E820 r12: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E821 r13: Response; participants=[P5]; detail=Accept; fallback=False
- E822 r14: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E823 r15: Response; participants=[P4]; detail=Accept; fallback=False
- E824 r16: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E825 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E826 r18: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P1:0->1:Help]
- E827 r19: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E828 r20: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:1->0:Gift; P2:2->3:Gift]
- E829 r21: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E830 r22: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E831 r23: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:3->2:Gift; P4:3->4:Gift]
- E832 r24: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E833 r25: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E834 r26: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E835 r27: AttitudeComposition; participants=[P4,P6]; detail=98->100; fallback=False
- E836 r28: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=3; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Rima [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dumu [P6] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P175: actor=Enna [P1]; Committed; reason=; event=E867
- Proposal P176: actor=Hani [P2]; Committed; reason=; event=E868
- Proposal P177: actor=Pala [P3]; Committed; reason=; event=E869
- Proposal P178: actor=Saba [P4]; Committed; reason=; event=E870
- Proposal P179: actor=Rima [P5]; Committed; reason=; event=E871
- Proposal P180: actor=Dumu [P6]; Committed; reason=; event=E872

### Semantic events
- E837 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E838 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E839 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E840 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E841 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E842 r5: Consumption; participants=[P6]; detail=Paid; fallback=False material=[P6:2->1:ConsumptionSink]
- E843 r6: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E844 r7: AttitudeDecay; participants=[P1,P6]; detail=-24->-23; fallback=False
- E845 r8: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E846 r9: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E847 r10: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E848 r11: AttitudeDecay; participants=[P3,P5]; detail=-25->-24; fallback=False
- E849 r12: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E850 r13: AttitudeDecay; participants=[P4,P6]; detail=100->98; fallback=False
- E851 r14: AttitudeDecay; participants=[P5,P3]; detail=-35->-34; fallback=False
- E852 r15: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E853 r16: AttitudeDecay; participants=[P6,P1]; detail=18->16; fallback=False
- E854 r17: AttitudeDecay; participants=[P6,P4]; detail=55->53; fallback=False
- E855 r18: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E856 r19: Response; participants=[P2]; detail=Accept; fallback=False
- E857 r20: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E858 r21: Response; participants=[P1]; detail=Accept; fallback=False
- E859 r22: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E860 r23: Response; participants=[P2]; detail=Accept; fallback=False
- E861 r24: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E862 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E863 r26: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E864 r27: Response; participants=[P4]; detail=Accept; fallback=False
- E865 r28: Proposal; participants=[P6]; detail=OfferGift(4,1); fallback=False
- E866 r29: Response; participants=[P4]; detail=Accept; fallback=False
- E867 r30: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:2->3:Gift]
- E868 r31: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:0->1:Gift]
- E869 r32: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:2->1:Help; P3:0->1:Help]
- E870 r33: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:2->3:Gift]
- E871 r34: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:2->3:Gift]
- E872 r35: Gift; participants=[P6,P4]; detail=OfferGift(4,1); fallback=False material=[P6:1->0:Gift; P4:3->4:Gift]
- E873 r36: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E874 r37: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E875 r38: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E876 r39: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E877 r40: AttitudeComposition; participants=[P4,P6]; detail=98->100; fallback=False
- E878 r41: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Pala [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D3
- Rima [P5]: grain=2; NeedsGrain=False; dwelling=D3
- Dumu [P6]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Stop

- Horizon:30
