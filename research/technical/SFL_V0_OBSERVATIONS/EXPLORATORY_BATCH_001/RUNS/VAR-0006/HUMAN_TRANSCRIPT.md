# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Bira: sex=Female; grain=6; NeedsGrain=False; dwelling=D2
- P2 Luma: sex=Female; grain=7; NeedsGrain=False; dwelling=D3
- P3 Gala: sex=Male; grain=2; NeedsGrain=False; dwelling=D3
- P4 Tari: sex=Female; grain=5; NeedsGrain=False; dwelling=D1

## Cycle 1

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=8 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=128 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Bira [P1]; Committed; reason=; event=E13
- Proposal P2: actor=Luma [P2]; Committed; reason=; event=E14
- Proposal P3: actor=Gala [P3]; Committed; reason=; event=E15
- Proposal P4: actor=Tari [P4]; Committed; reason=; event=E16

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E5 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E6 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E7 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E8 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E9 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E10 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E11 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E12 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E13 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:5->4:Gift; P3:1->2:Gift]
- E14 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:2->3:Gift]
- E15 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:5->6:Gift]
- E16 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:6->7:Gift]
- E17 r16: AttitudeComposition; participants=[P2,P3]; detail=4->14; fallback=False
- E18 r17: AttitudeComposition; participants=[P2,P4]; detail=0->10; fallback=False
- E19 r18: AttitudeComposition; participants=[P3,P1]; detail=47->57; fallback=False
- E20 r19: AttitudeComposition; participants=[P3,P2]; detail=64->74; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=7; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=28 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=148 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P5: actor=Bira [P1]; Committed; reason=; event=E32
- Proposal P6: actor=Luma [P2]; Committed; reason=; event=E33
- Proposal P7: actor=Gala [P3]; Committed; reason=; event=E34
- Proposal P8: actor=Tari [P4]; Committed; reason=; event=E35

### Semantic events
- E21 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E22 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E23 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E24 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E25 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E26 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E27 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E28 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E29 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E30 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E31 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E32 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E33 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:6->5:Gift; P3:2->3:Gift]
- E34 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:5->6:Gift]
- E35 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E36 r15: AttitudeComposition; participants=[P2,P3]; detail=14->24; fallback=False
- E37 r16: AttitudeComposition; participants=[P3,P1]; detail=57->67; fallback=False
- E38 r17: AttitudeComposition; participants=[P3,P2]; detail=74->84; fallback=False

### Stable state
- Bira [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=168 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P9: actor=Bira [P1]; Committed; reason=; event=E51
- Proposal P10: actor=Luma [P2]; Committed; reason=; event=E52
- Proposal P11: actor=Gala [P3]; Committed; reason=; event=E53
- Proposal P12: actor=Tari [P4]; Committed; reason=; event=E54

### Semantic events
- E39 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E40 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E41 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E42 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E43 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E44 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E45 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E46 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E47 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E48 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E49 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E50 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E51 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E52 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:2->3:Gift]
- E53 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:4->5:Gift]
- E54 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:5->6:Gift]
- E55 r16: AttitudeComposition; participants=[P2,P3]; detail=24->34; fallback=False
- E56 r17: AttitudeComposition; participants=[P2,P4]; detail=10->20; fallback=False
- E57 r18: AttitudeComposition; participants=[P3,P1]; detail=67->77; fallback=False
- E58 r19: AttitudeComposition; participants=[P3,P2]; detail=84->94; fallback=False

### Stable state
- Bira [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=68 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=188 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P13: actor=Bira [P1]; Committed; reason=; event=E70
- Proposal P14: actor=Luma [P2]; Committed; reason=; event=E71
- Proposal P15: actor=Gala [P3]; Committed; reason=; event=E72
- Proposal P16: actor=Tari [P4]; Committed; reason=; event=E73

### Semantic events
- E59 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E60 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E61 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E62 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E63 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(3,1); fallback=False
- E64 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E65 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E66 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E67 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E68 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E69 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E70 r11: Help; participants=[P3,P1]; detail=RequestGiftOrHelp(3,1); fallback=True material=[P3:1->0:Help; P1:0->1:Help]
- E71 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=True material=[P2:5->4:Gift; P3:0->1:Gift]
- E72 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=True material=[P3:1->0:Gift; P2:4->5:Gift]
- E73 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:3->7:FarmSource]
- E74 r15: AttitudeComposition; participants=[P1,P3]; detail=49->59; fallback=False
- E75 r16: AttitudeComposition; participants=[P2,P3]; detail=34->44; fallback=False
- E76 r17: AttitudeComposition; participants=[P3,P2]; detail=94->100; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=0; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=7; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/Feasibility: none; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=84 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P17: actor=Bira [P1]; Committed; reason=; event=E98
- Proposal P18: actor=Luma [P2]; Committed; reason=; event=E99
- Proposal P19: actor=Gala [P3]; Unable; reason=InsufficientAvailableGrain; event=E95
- Proposal P20: actor=Tari [P4]; Committed; reason=; event=E100

### Semantic events
- E77 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E78 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E79 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E80 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E81 r4: AttitudeDecay; participants=[P1,P3]; detail=59->57; fallback=False
- E82 r5: AttitudeDecay; participants=[P1,P4]; detail=40->38; fallback=False
- E83 r6: AttitudeDecay; participants=[P2,P3]; detail=44->42; fallback=False
- E84 r7: AttitudeDecay; participants=[P2,P4]; detail=20->18; fallback=False
- E85 r8: AttitudeDecay; participants=[P3,P1]; detail=77->75; fallback=False
- E86 r9: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E87 r10: AttitudeDecay; participants=[P3,P4]; detail=59->57; fallback=False
- E88 r11: AttitudeDecay; participants=[P4,P1]; detail=-29->-28; fallback=False
- E89 r12: AttitudeDecay; participants=[P4,P2]; detail=26->24; fallback=False
- E90 r13: AttitudeDecay; participants=[P4,P3]; detail=-2->-1; fallback=False
- E91 r14: Proposal; participants=[P1]; detail=Farm; fallback=False
- E92 r15: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E93 r16: Response; participants=[P3]; detail=Accept; fallback=False
- E94 r17: Proposal; participants=[P3]; detail=RequestGiftOrHelp(1,1); fallback=False
- E95 r18: Unable; participants=[P3,P1]; detail=InsufficientAvailableGrain; fallback=False
- E96 r19: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E97 r20: Response; participants=[P2]; detail=Accept; fallback=False
- E98 r21: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E99 r22: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:0->1:Gift]
- E100 r23: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:6->5:Gift; P2:3->4:Gift]
- E101 r24: AttitudeComposition; participants=[P2,P4]; detail=18->28; fallback=False
- E102 r25: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=84 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Bira [P1]; Committed; reason=; event=E114
- Proposal P22: actor=Luma [P2]; Committed; reason=; event=E115
- Proposal P23: actor=Gala [P3]; Committed; reason=; event=E116
- Proposal P24: actor=Tari [P4]; Committed; reason=; event=E117

### Semantic events
- E103 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E104 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E105 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E106 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E107 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E108 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E109 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E110 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E111 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E112 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E113 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E114 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:0->1:Gift]
- E115 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E116 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E117 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:2->3:Gift]
- E118 r15: AttitudeComposition; participants=[P2,P4]; detail=28->38; fallback=False
- E119 r16: AttitudeComposition; participants=[P3,P1]; detail=75->85; fallback=False
- E120 r17: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=6; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=84 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P25: actor=Bira [P1]; Committed; reason=; event=E132
- Proposal P26: actor=Luma [P2]; Committed; reason=; event=E133
- Proposal P27: actor=Gala [P3]; Committed; reason=; event=E134
- Proposal P28: actor=Tari [P4]; Committed; reason=; event=E135

### Semantic events
- E121 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E122 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E123 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E124 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E125 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E126 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E127 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E128 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E129 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E130 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E131 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E132 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:5->6:Gift]
- E133 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:6->7:Gift]
- E134 r13: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:7->6:Gift; P2:1->2:Gift]
- E135 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E136 r15: AttitudeComposition; participants=[P2,P3]; detail=42->52; fallback=False
- E137 r16: AttitudeComposition; participants=[P3,P1]; detail=85->95; fallback=False
- E138 r17: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=0; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=6; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=104 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P29: actor=Bira [P1]; Committed; reason=; event=E151
- Proposal P30: actor=Luma [P2]; Committed; reason=; event=E152
- Proposal P31: actor=Gala [P3]; Committed; reason=; event=E153
- Proposal P32: actor=Tari [P4]; Committed; reason=; event=E154

### Semantic events
- E139 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E140 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E141 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E142 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E143 r4: Proposal; participants=[P1]; detail=RequestGiftOrHelp(3,1); fallback=False
- E144 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E145 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E146 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E147 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E148 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E149 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E150 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E151 r12: Help; participants=[P3,P1]; detail=RequestGiftOrHelp(3,1); fallback=False material=[P3:5->4:Help; P1:0->1:Help]
- E152 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:4->5:Gift]
- E153 r14: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:5->4:Gift; P2:0->1:Gift]
- E154 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:1->2:Gift]
- E155 r16: AttitudeComposition; participants=[P1,P3]; detail=57->67; fallback=False
- E156 r17: AttitudeComposition; participants=[P2,P3]; detail=52->62; fallback=False
- E157 r18: AttitudeComposition; participants=[P2,P4]; detail=38->48; fallback=False
- E158 r19: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=4; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=124 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P33: actor=Bira [P1]; Committed; reason=; event=E169
- Proposal P34: actor=Luma [P2]; Committed; reason=; event=E170
- Proposal P35: actor=Gala [P3]; Committed; reason=; event=E171
- Proposal P36: actor=Tari [P4]; Committed; reason=; event=E172

### Semantic events
- E159 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E160 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E161 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E162 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E163 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E164 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E165 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E166 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E167 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E168 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E169 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E170 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:3->4:Gift]
- E171 r12: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:0->1:Gift]
- E172 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:3->7:FarmSource]
- E173 r14: AttitudeComposition; participants=[P2,P3]; detail=62->72; fallback=False
- E174 r15: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=3; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=7; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P37: actor=Bira [P1]; Committed; reason=; event=E196
- Proposal P38: actor=Luma [P2]; Committed; reason=; event=E197
- Proposal P39: actor=Gala [P3]; Committed; reason=; event=E198
- Proposal P40: actor=Tari [P4]; Committed; reason=; event=E199

### Semantic events
- E175 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E176 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E177 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E178 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E179 r4: AttitudeDecay; participants=[P1,P3]; detail=67->65; fallback=False
- E180 r5: AttitudeDecay; participants=[P1,P4]; detail=38->36; fallback=False
- E181 r6: AttitudeDecay; participants=[P2,P3]; detail=72->70; fallback=False
- E182 r7: AttitudeDecay; participants=[P2,P4]; detail=48->46; fallback=False
- E183 r8: AttitudeDecay; participants=[P3,P1]; detail=95->93; fallback=False
- E184 r9: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E185 r10: AttitudeDecay; participants=[P3,P4]; detail=57->55; fallback=False
- E186 r11: AttitudeDecay; participants=[P4,P1]; detail=-28->-27; fallback=False
- E187 r12: AttitudeDecay; participants=[P4,P2]; detail=24->22; fallback=False
- E188 r13: AttitudeDecay; participants=[P4,P3]; detail=-1->0; fallback=False
- E189 r14: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E190 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E191 r16: Proposal; participants=[P2]; detail=Farm; fallback=False
- E192 r17: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E193 r18: Response; participants=[P2]; detail=Accept; fallback=False
- E194 r19: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E195 r20: Response; participants=[P2]; detail=Accept; fallback=False
- E196 r21: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:2->3:Gift]
- E197 r22: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E198 r23: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:4->5:Gift]
- E199 r24: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:6->5:Gift; P2:5->6:Gift]
- E200 r25: AttitudeComposition; participants=[P2,P3]; detail=70->80; fallback=False
- E201 r26: AttitudeComposition; participants=[P2,P4]; detail=46->56; fallback=False
- E202 r27: AttitudeComposition; participants=[P3,P1]; detail=93->100; fallback=False

### Stable state
- Bira [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=6; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Bira [P1]; Committed; reason=; event=E215
- Proposal P42: actor=Luma [P2]; Committed; reason=; event=E216
- Proposal P43: actor=Gala [P3]; Committed; reason=; event=E217
- Proposal P44: actor=Tari [P4]; Committed; reason=; event=E218

### Semantic events
- E203 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E204 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E205 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E206 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E207 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E208 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E209 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E210 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E211 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E212 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E213 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E214 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E215 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:1->2:Gift]
- E216 r13: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:5->4:Gift; P3:2->3:Gift]
- E217 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:0->1:Gift]
- E218 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:4->5:Gift]
- E219 r16: AttitudeComposition; participants=[P1,P3]; detail=65->75; fallback=False
- E220 r17: AttitudeComposition; participants=[P2,P4]; detail=56->66; fallback=False
- E221 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E222 r19: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P45: actor=Bira [P1]; Committed; reason=; event=E233
- Proposal P46: actor=Luma [P2]; Committed; reason=; event=E234
- Proposal P47: actor=Gala [P3]; Committed; reason=; event=E235
- Proposal P48: actor=Tari [P4]; Committed; reason=; event=E236

### Semantic events
- E223 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E224 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E225 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E226 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E227 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E228 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E229 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E230 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E231 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E232 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E233 r10: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E234 r11: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:1->2:Gift]
- E235 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:4->5:Gift]
- E236 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E237 r14: AttitudeComposition; participants=[P1,P3]; detail=75->85; fallback=False
- E238 r15: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=170 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P49: actor=Bira [P1]; Committed; reason=; event=E250
- Proposal P50: actor=Luma [P2]; Committed; reason=; event=E251
- Proposal P51: actor=Gala [P3]; Committed; reason=; event=E252
- Proposal P52: actor=Tari [P4]; Committed; reason=; event=E253

### Semantic events
- E239 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E240 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E241 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E242 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E243 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E244 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E245 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E246 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E247 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E248 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E249 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E250 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:0->1:Gift]
- E251 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:1->2:Gift]
- E252 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E253 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:1->2:Gift]
- E254 r15: AttitudeComposition; participants=[P2,P4]; detail=66->76; fallback=False
- E255 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E256 r17: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=6; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=170 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P53: actor=Bira [P1]; Committed; reason=; event=E268
- Proposal P54: actor=Luma [P2]; Committed; reason=; event=E269
- Proposal P55: actor=Gala [P3]; Committed; reason=; event=E270
- Proposal P56: actor=Tari [P4]; Committed; reason=; event=E271

### Semantic events
- E257 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E258 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E259 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E260 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E261 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E262 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E263 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E264 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E265 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E266 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E267 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E268 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:5->6:Gift]
- E269 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:6->7:Gift]
- E270 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:7->6:Gift; P1:1->2:Gift]
- E271 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:3->7:FarmSource]
- E272 r15: AttitudeComposition; participants=[P1,P3]; detail=85->95; fallback=False
- E273 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E274 r17: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=2; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=0; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=6; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=7; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=186 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P57: actor=Bira [P1]; Committed; reason=; event=E297
- Proposal P58: actor=Luma [P2]; Committed; reason=; event=E298
- Proposal P59: actor=Gala [P3]; Committed; reason=; event=E299
- Proposal P60: actor=Tari [P4]; Committed; reason=; event=E300

### Semantic events
- E275 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E276 r1: MissedConsumption; participants=[P2]; detail=NeedsGrain; fallback=False
- E277 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E278 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E279 r4: AttitudeDecay; participants=[P1,P3]; detail=95->93; fallback=False
- E280 r5: AttitudeDecay; participants=[P1,P4]; detail=36->34; fallback=False
- E281 r6: AttitudeDecay; participants=[P2,P3]; detail=80->78; fallback=False
- E282 r7: AttitudeDecay; participants=[P2,P4]; detail=76->74; fallback=False
- E283 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E284 r9: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E285 r10: AttitudeDecay; participants=[P3,P4]; detail=55->53; fallback=False
- E286 r11: AttitudeDecay; participants=[P4,P1]; detail=-27->-26; fallback=False
- E287 r12: AttitudeDecay; participants=[P4,P2]; detail=22->20; fallback=False
- E288 r13: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E289 r14: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E290 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E291 r16: Proposal; participants=[P2]; detail=RequestGiftOrHelp(3,1); fallback=False
- E292 r17: Response; participants=[P3]; detail=Accept; fallback=False
- E293 r18: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E294 r19: Response; participants=[P1]; detail=Accept; fallback=False
- E295 r20: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E296 r21: Response; participants=[P2]; detail=Accept; fallback=False
- E297 r22: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:5->6:Gift]
- E298 r23: Help; participants=[P3,P2]; detail=RequestGiftOrHelp(3,1); fallback=False material=[P3:6->5:Help; P2:0->1:Help]
- E299 r24: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:5->4:Gift; P1:0->1:Gift]
- E300 r25: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:6->5:Gift; P2:1->2:Gift]
- E301 r26: AttitudeComposition; participants=[P1,P3]; detail=93->100; fallback=False
- E302 r27: AttitudeComposition; participants=[P2,P3]; detail=78->88; fallback=False
- E303 r28: AttitudeComposition; participants=[P2,P4]; detail=74->84; fallback=False
- E304 r29: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=4; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=176 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Bira [P1]; Committed; reason=; event=E316
- Proposal P62: actor=Luma [P2]; Committed; reason=; event=E317
- Proposal P63: actor=Gala [P3]; Committed; reason=; event=E318
- Proposal P64: actor=Tari [P4]; Committed; reason=; event=E319

### Semantic events
- E305 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E306 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E307 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E308 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E309 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E310 r5: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E311 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E312 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E313 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E314 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E315 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E316 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E317 r12: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:3->4:Gift]
- E318 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E319 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:0->1:Gift]
- E320 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E321 r16: AttitudeComposition; participants=[P2,P4]; detail=84->94; fallback=False
- E322 r17: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=3; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P65: actor=Bira [P1]; Committed; reason=; event=E333
- Proposal P66: actor=Luma [P2]; Committed; reason=; event=E334
- Proposal P67: actor=Gala [P3]; Committed; reason=; event=E335
- Proposal P68: actor=Tari [P4]; Committed; reason=; event=E336

### Semantic events
- E323 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E324 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E325 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E326 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E327 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E328 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E329 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E330 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E331 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E332 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E333 r10: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:2->3:Gift]
- E334 r11: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E335 r12: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:3->4:Gift]
- E336 r13: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E337 r14: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E338 r15: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=4; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=188 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P69: actor=Bira [P1]; Committed; reason=; event=E351
- Proposal P70: actor=Luma [P2]; Committed; reason=; event=E352
- Proposal P71: actor=Gala [P3]; Committed; reason=; event=E353
- Proposal P72: actor=Tari [P4]; Committed; reason=; event=E354

### Semantic events
- E339 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E340 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E341 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E342 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E343 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E344 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E345 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E346 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E347 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E348 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E349 r10: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E350 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E351 r12: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E352 r13: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:3->2:Gift; P4:5->6:Gift]
- E353 r14: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:2->3:Gift]
- E354 r15: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:6->5:Gift; P2:2->3:Gift]
- E355 r16: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E356 r17: AttitudeComposition; participants=[P2,P4]; detail=94->100; fallback=False
- E357 r18: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E358 r19: AttitudeComposition; participants=[P4,P2]; detail=20->30; fallback=False

### Stable state
- Bira [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=60 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P73: actor=Bira [P1]; Committed; reason=; event=E370
- Proposal P74: actor=Luma [P2]; Committed; reason=; event=E371
- Proposal P75: actor=Gala [P3]; Committed; reason=; event=E372
- Proposal P76: actor=Tari [P4]; Committed; reason=; event=E373

### Semantic events
- E359 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E360 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E361 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E362 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E363 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E364 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E365 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E366 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E367 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E368 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E369 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E370 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:0->1:Gift]
- E371 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:4->5:Gift]
- E372 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E373 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:1->2:Gift]
- E374 r15: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E375 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E376 r17: AttitudeComposition; participants=[P4,P2]; detail=30->40; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=5; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=76 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P77: actor=Bira [P1]; Committed; reason=; event=E398
- Proposal P78: actor=Luma [P2]; Committed; reason=; event=E399
- Proposal P79: actor=Gala [P3]; Committed; reason=; event=E400
- Proposal P80: actor=Tari [P4]; Committed; reason=; event=E401

### Semantic events
- E377 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E378 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E379 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E380 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E381 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E382 r5: AttitudeDecay; participants=[P1,P4]; detail=34->32; fallback=False
- E383 r6: AttitudeDecay; participants=[P2,P3]; detail=88->86; fallback=False
- E384 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E385 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E386 r9: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E387 r10: AttitudeDecay; participants=[P3,P4]; detail=53->51; fallback=False
- E388 r11: AttitudeDecay; participants=[P4,P1]; detail=-26->-25; fallback=False
- E389 r12: AttitudeDecay; participants=[P4,P2]; detail=40->38; fallback=False
- E390 r13: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E391 r14: Proposal; participants=[P1]; detail=Farm; fallback=False
- E392 r15: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E393 r16: Response; participants=[P4]; detail=Accept; fallback=False
- E394 r17: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E395 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E396 r19: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E397 r20: Response; participants=[P2]; detail=Accept; fallback=False
- E398 r21: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E399 r22: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:3->4:Gift]
- E400 r23: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E401 r24: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:0->1:Gift]
- E402 r25: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E403 r26: AttitudeComposition; participants=[P2,P4]; detail=98->100; fallback=False
- E404 r27: AttitudeComposition; participants=[P4,P2]; detail=38->48; fallback=False

### Stable state
- Bira [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=3; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Bira [P1]; Committed; reason=; event=E416
- Proposal P82: actor=Luma [P2]; Committed; reason=; event=E417
- Proposal P83: actor=Gala [P3]; Committed; reason=; event=E418
- Proposal P84: actor=Tari [P4]; Committed; reason=; event=E419

### Semantic events
- E405 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E406 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E407 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E408 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E409 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E410 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E411 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E412 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E413 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E414 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E415 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E416 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:2->3:Gift]
- E417 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E418 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:3->4:Gift]
- E419 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:2->1:Gift; P2:4->5:Gift]
- E420 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E421 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E422 r17: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P85: actor=Bira [P1]; Committed; reason=; event=E434
- Proposal P86: actor=Luma [P2]; Committed; reason=; event=E435
- Proposal P87: actor=Gala [P3]; Committed; reason=; event=E436
- Proposal P88: actor=Tari [P4]; Committed; reason=; event=E437

### Semantic events
- E423 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E424 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E425 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E426 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E427 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E428 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E429 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E430 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E431 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E432 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E433 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E434 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E435 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:0->1:Gift]
- E436 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:2->3:Gift]
- E437 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E438 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E439 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E440 r17: AttitudeComposition; participants=[P4,P2]; detail=48->58; fallback=False

### Stable state
- Bira [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=116 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P89: actor=Bira [P1]; Committed; reason=; event=E452
- Proposal P90: actor=Luma [P2]; Committed; reason=; event=E453
- Proposal P91: actor=Gala [P3]; Committed; reason=; event=E454
- Proposal P92: actor=Tari [P4]; Committed; reason=; event=E455

### Semantic events
- E441 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E442 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E443 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E444 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E445 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E446 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E447 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E448 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E449 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E450 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E451 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E452 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:0->1:Gift]
- E453 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:4->5:Gift]
- E454 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E455 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:1->2:Gift]
- E456 r15: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E457 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E458 r17: AttitudeComposition; participants=[P4,P2]; detail=58->68; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=5; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=136 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P93: actor=Bira [P1]; Committed; reason=; event=E470
- Proposal P94: actor=Luma [P2]; Committed; reason=; event=E471
- Proposal P95: actor=Gala [P3]; Committed; reason=; event=E472
- Proposal P96: actor=Tari [P4]; Committed; reason=; event=E473

### Semantic events
- E459 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E460 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E461 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E462 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E463 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E464 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E465 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E466 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E467 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E468 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E469 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E470 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E471 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:3->4:Gift]
- E472 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E473 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:0->1:Gift]
- E474 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E475 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E476 r17: AttitudeComposition; participants=[P4,P2]; detail=68->78; fallback=False

### Stable state
- Bira [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=3; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P97: actor=Bira [P1]; Committed; reason=; event=E498
- Proposal P98: actor=Luma [P2]; Committed; reason=; event=E499
- Proposal P99: actor=Gala [P3]; Committed; reason=; event=E500
- Proposal P100: actor=Tari [P4]; Committed; reason=; event=E501

### Semantic events
- E477 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E478 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E479 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E480 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E481 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E482 r5: AttitudeDecay; participants=[P1,P4]; detail=32->30; fallback=False
- E483 r6: AttitudeDecay; participants=[P2,P3]; detail=86->84; fallback=False
- E484 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E485 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E486 r9: AttitudeDecay; participants=[P3,P2]; detail=98->96; fallback=False
- E487 r10: AttitudeDecay; participants=[P3,P4]; detail=51->49; fallback=False
- E488 r11: AttitudeDecay; participants=[P4,P1]; detail=-25->-24; fallback=False
- E489 r12: AttitudeDecay; participants=[P4,P2]; detail=78->76; fallback=False
- E490 r13: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E491 r14: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E492 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E493 r16: Proposal; participants=[P2]; detail=Farm; fallback=False
- E494 r17: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E495 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E496 r19: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E497 r20: Response; participants=[P2]; detail=Accept; fallback=False
- E498 r21: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:2->3:Gift]
- E499 r22: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E500 r23: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:3->4:Gift]
- E501 r24: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:2->1:Gift; P2:4->5:Gift]
- E502 r25: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E503 r26: AttitudeComposition; participants=[P2,P4]; detail=98->100; fallback=False
- E504 r27: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Bira [P1]; Committed; reason=; event=E516
- Proposal P102: actor=Luma [P2]; Committed; reason=; event=E517
- Proposal P103: actor=Gala [P3]; Committed; reason=; event=E518
- Proposal P104: actor=Tari [P4]; Committed; reason=; event=E519

### Semantic events
- E505 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E506 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E507 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E508 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E509 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E510 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E511 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E512 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E513 r8: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E514 r9: Response; participants=[P1]; detail=Accept; fallback=False
- E515 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E516 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E517 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:0->1:Gift]
- E518 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:2->3:Gift]
- E519 r14: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E520 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E521 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E522 r17: AttitudeComposition; participants=[P4,P2]; detail=76->86; fallback=False

### Stable state
- Bira [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=172 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P105: actor=Bira [P1]; Committed; reason=; event=E534
- Proposal P106: actor=Luma [P2]; Committed; reason=; event=E535
- Proposal P107: actor=Gala [P3]; Committed; reason=; event=E536
- Proposal P108: actor=Tari [P4]; Committed; reason=; event=E537

### Semantic events
- E523 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E524 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E525 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E526 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E527 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E528 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E529 r6: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E530 r7: Response; participants=[P4]; detail=Accept; fallback=False
- E531 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E532 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E533 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E534 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:0->1:Gift]
- E535 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:2->1:Gift; P4:4->5:Gift]
- E536 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E537 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:5->4:Gift; P2:1->2:Gift]
- E538 r15: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E539 r16: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False
- E540 r17: AttitudeComposition; participants=[P4,P2]; detail=86->96; fallback=False

### Stable state
- Bira [P1]: grain=1; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=2; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=5; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P109: actor=Bira [P1]; Committed; reason=; event=E552
- Proposal P110: actor=Luma [P2]; Committed; reason=; event=E553
- Proposal P111: actor=Gala [P3]; Committed; reason=; event=E554
- Proposal P112: actor=Tari [P4]; Committed; reason=; event=E555

### Semantic events
- E541 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E542 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E543 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E544 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E545 r4: Proposal; participants=[P1]; detail=Farm; fallback=False
- E546 r5: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E547 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E548 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E549 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E550 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E551 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E552 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E553 r12: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:1->0:Gift; P4:3->4:Gift]
- E554 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:4->3:Gift; P1:4->5:Gift]
- E555 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:4->3:Gift; P2:0->1:Gift]
- E556 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E557 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E558 r17: AttitudeComposition; participants=[P4,P2]; detail=96->100; fallback=False

### Stable state
- Bira [P1]: grain=5; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=1; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=3; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P113: actor=Bira [P1]; Committed; reason=; event=E570
- Proposal P114: actor=Luma [P2]; Committed; reason=; event=E571
- Proposal P115: actor=Gala [P3]; Committed; reason=; event=E572
- Proposal P116: actor=Tari [P4]; Committed; reason=; event=E573

### Semantic events
- E559 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E560 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E561 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E562 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E563 r4: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E564 r5: Response; participants=[P3]; detail=Accept; fallback=False
- E565 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E566 r7: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E567 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E568 r9: Proposal; participants=[P4]; detail=OfferGift(2,1); fallback=False
- E569 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E570 r11: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:4->3:Gift; P3:2->3:Gift]
- E571 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E572 r13: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:3->2:Gift; P1:3->4:Gift]
- E573 r14: Gift; participants=[P4,P2]; detail=OfferGift(2,1); fallback=False material=[P4:2->1:Gift; P2:4->5:Gift]
- E574 r15: AttitudeComposition; participants=[P1,P3]; detail=100->100; fallback=False
- E575 r16: AttitudeComposition; participants=[P2,P4]; detail=100->100; fallback=False
- E576 r17: AttitudeComposition; participants=[P3,P1]; detail=100->100; fallback=False

### Stable state
- Bira [P1]: grain=4; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=5; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=2; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Bira [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Bira [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Gala [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P117: actor=Bira [P1]; Committed; reason=; event=E598
- Proposal P118: actor=Luma [P2]; Committed; reason=; event=E599
- Proposal P119: actor=Gala [P3]; Committed; reason=; event=E600
- Proposal P120: actor=Tari [P4]; Committed; reason=; event=E601

### Semantic events
- E577 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E578 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E579 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E580 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E581 r4: AttitudeDecay; participants=[P1,P3]; detail=100->98; fallback=False
- E582 r5: AttitudeDecay; participants=[P1,P4]; detail=30->28; fallback=False
- E583 r6: AttitudeDecay; participants=[P2,P3]; detail=84->82; fallback=False
- E584 r7: AttitudeDecay; participants=[P2,P4]; detail=100->98; fallback=False
- E585 r8: AttitudeDecay; participants=[P3,P1]; detail=100->98; fallback=False
- E586 r9: AttitudeDecay; participants=[P3,P2]; detail=96->94; fallback=False
- E587 r10: AttitudeDecay; participants=[P3,P4]; detail=49->47; fallback=False
- E588 r11: AttitudeDecay; participants=[P4,P1]; detail=-24->-23; fallback=False
- E589 r12: AttitudeDecay; participants=[P4,P2]; detail=100->98; fallback=False
- E590 r13: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E591 r14: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E592 r15: Response; participants=[P3]; detail=Accept; fallback=False
- E593 r16: Proposal; participants=[P2]; detail=OfferGift(4,1); fallback=False
- E594 r17: Response; participants=[P4]; detail=Accept; fallback=False
- E595 r18: Proposal; participants=[P3]; detail=OfferGift(1,1); fallback=False
- E596 r19: Response; participants=[P1]; detail=Accept; fallback=False
- E597 r20: Proposal; participants=[P4]; detail=Farm; fallback=False
- E598 r21: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E599 r22: Gift; participants=[P2,P4]; detail=OfferGift(4,1); fallback=False material=[P2:4->3:Gift; P4:0->1:Gift]
- E600 r23: Gift; participants=[P3,P1]; detail=OfferGift(1,1); fallback=False material=[P3:2->1:Gift; P1:2->3:Gift]
- E601 r24: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E602 r25: AttitudeComposition; participants=[P1,P3]; detail=98->100; fallback=False
- E603 r26: AttitudeComposition; participants=[P3,P1]; detail=98->100; fallback=False
- E604 r27: AttitudeComposition; participants=[P4,P2]; detail=98->100; fallback=False

### Stable state
- Bira [P1]: grain=3; NeedsGrain=False; dwelling=D2
- Luma [P2]: grain=3; NeedsGrain=False; dwelling=D3
- Gala [P3]: grain=1; NeedsGrain=False; dwelling=D3
- Tari [P4]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Stop

- Horizon:30
