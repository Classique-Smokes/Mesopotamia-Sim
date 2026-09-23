# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Rima: sex=Female; grain=5; NeedsGrain=False; dwelling=D1
- P2 Kima: sex=Female; grain=4; NeedsGrain=False; dwelling=D1
- P3 Aki: sex=Female; grain=2; NeedsGrain=False; dwelling=D2
- P4 Nadi: sex=Female; grain=3; NeedsGrain=False; dwelling=D2
- P5 Pala: sex=Male; grain=7; NeedsGrain=False; dwelling=D1

## Cycle 1

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=118 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=116 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=132 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Rima [P1]; Committed; reason=; event=E15
- Proposal P2: actor=Kima [P2]; Committed; reason=; event=E16
- Proposal P3: actor=Aki [P3]; Committed; reason=; event=E17
- Proposal P4: actor=Nadi [P4]; Committed; reason=; event=E18
- Proposal P5: actor=Pala [P5]; Committed; reason=; event=E19

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E5 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:7->6:ConsumptionSink]
- E6 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E7 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E8 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E9 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E10 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E11 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E12 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E13 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E14 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E15 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:2->3:Gift]
- E16 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E17 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E18 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:6->7:Gift]
- E19 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:7->6:Gift; P4:2->3:Gift]
- E20 r19: AttitudeComposition; participants=[P3,P2]; detail=28->38; fallback=False
- E21 r20: AttitudeComposition; participants=[P4,P1]; detail=-46->-36; fallback=False
- E22 r21: AttitudeComposition; participants=[P4,P5]; detail=58->68; fallback=False
- E23 r22: AttitudeComposition; participants=[P5,P4]; detail=66->76; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=6; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=118 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=76 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=136 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P6: actor=Rima [P1]; Committed; reason=; event=E38
- Proposal P7: actor=Kima [P2]; Committed; reason=; event=E39
- Proposal P8: actor=Aki [P3]; Committed; reason=; event=E40
- Proposal P9: actor=Nadi [P4]; Committed; reason=; event=E41
- Proposal P10: actor=Pala [P5]; Committed; reason=; event=E42

### Semantic events
- E24 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E25 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E26 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E27 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E28 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:6->5:ConsumptionSink]
- E29 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E30 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E31 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E32 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E33 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E34 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E35 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E36 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E37 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E38 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E39 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:1->0:Gift; P3:5->6:Gift]
- E40 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:6->5:Gift; P2:0->1:Gift]
- E41 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:5->6:Gift]
- E42 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:6->5:Gift; P4:1->2:Gift]
- E43 r19: AttitudeComposition; participants=[P2,P3]; detail=59->69; fallback=False
- E44 r20: AttitudeComposition; participants=[P3,P2]; detail=38->48; fallback=False
- E45 r21: AttitudeComposition; participants=[P4,P5]; detail=68->78; fallback=False
- E46 r22: AttitudeComposition; participants=[P5,P4]; detail=76->86; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=172 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P11: actor=Rima [P1]; Committed; reason=; event=E61
- Proposal P12: actor=Kima [P2]; Committed; reason=; event=E62
- Proposal P13: actor=Aki [P3]; Committed; reason=; event=E63
- Proposal P14: actor=Nadi [P4]; Committed; reason=; event=E64
- Proposal P15: actor=Pala [P5]; Committed; reason=; event=E65

### Semantic events
- E47 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E48 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E49 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E50 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E51 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E52 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E53 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E54 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E55 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E56 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E57 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E58 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E59 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E60 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E61 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:1->2:Gift]
- E62 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E63 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E64 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:4->5:Gift]
- E65 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:1->2:Gift]
- E66 r19: AttitudeComposition; participants=[P2,P3]; detail=69->79; fallback=False
- E67 r20: AttitudeComposition; participants=[P4,P1]; detail=-36->-26; fallback=False
- E68 r21: AttitudeComposition; participants=[P4,P5]; detail=78->88; fallback=False
- E69 r22: AttitudeComposition; participants=[P5,P4]; detail=86->96; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=158 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=176 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P16: actor=Rima [P1]; Committed; reason=; event=E84
- Proposal P17: actor=Kima [P2]; Committed; reason=; event=E85
- Proposal P18: actor=Aki [P3]; Committed; reason=; event=E86
- Proposal P19: actor=Nadi [P4]; Committed; reason=; event=E87
- Proposal P20: actor=Pala [P5]; Committed; reason=; event=E88

### Semantic events
- E70 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E71 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E72 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E73 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E74 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E75 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E76 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E77 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E78 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E79 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E80 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E81 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E82 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E83 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E84 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E85 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E86 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E87 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:3->4:Gift]
- E88 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:0->1:Gift]
- E89 r19: AttitudeComposition; participants=[P2,P3]; detail=79->89; fallback=False
- E90 r20: AttitudeComposition; participants=[P3,P2]; detail=48->58; fallback=False
- E91 r21: AttitudeComposition; participants=[P4,P5]; detail=88->98; fallback=False
- E92 r22: AttitudeComposition; participants=[P5,P4]; detail=96->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=174 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=112 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Rima [P1]; Committed; reason=; event=E119
- Proposal P22: actor=Kima [P2]; Committed; reason=; event=E120
- Proposal P23: actor=Aki [P3]; Committed; reason=; event=E121
- Proposal P24: actor=Nadi [P4]; Committed; reason=; event=E122
- Proposal P25: actor=Pala [P5]; Committed; reason=; event=E123

### Semantic events
- E93 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E94 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E95 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E96 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E97 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E98 r5: AttitudeDecay; participants=[P1,P3]; detail=-1->0; fallback=False
- E99 r6: AttitudeDecay; participants=[P1,P4]; detail=26->24; fallback=False
- E100 r7: AttitudeDecay; participants=[P1,P5]; detail=26->24; fallback=False
- E101 r8: AttitudeDecay; participants=[P2,P3]; detail=89->87; fallback=False
- E102 r9: AttitudeDecay; participants=[P2,P4]; detail=-21->-20; fallback=False
- E103 r10: AttitudeDecay; participants=[P3,P1]; detail=20->18; fallback=False
- E104 r11: AttitudeDecay; participants=[P3,P2]; detail=58->56; fallback=False
- E105 r12: AttitudeDecay; participants=[P4,P1]; detail=-26->-25; fallback=False
- E106 r13: AttitudeDecay; participants=[P4,P2]; detail=51->49; fallback=False
- E107 r14: AttitudeDecay; participants=[P4,P5]; detail=98->96; fallback=False
- E108 r15: AttitudeDecay; participants=[P5,P1]; detail=7->5; fallback=False
- E109 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E110 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E111 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E112 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E113 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E114 r21: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E115 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E116 r23: Proposal; participants=[P4]; detail=Farm; fallback=False
- E117 r24: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E118 r25: Response; participants=[P4]; detail=Accept; fallback=False
- E119 r26: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:0->1:Gift]
- E120 r27: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E121 r28: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E122 r29: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E123 r30: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:5->6:Gift]
- E124 r31: AttitudeComposition; participants=[P2,P3]; detail=87->97; fallback=False
- E125 r32: AttitudeComposition; participants=[P3,P2]; detail=56->66; fallback=False
- E126 r33: AttitudeComposition; participants=[P4,P1]; detail=-25->-15; fallback=False
- E127 r34: AttitudeComposition; participants=[P4,P5]; detail=96->100; fallback=False

### Stable state
- Rima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=194 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P26: actor=Rima [P1]; Committed; reason=; event=E141
- Proposal P27: actor=Kima [P2]; Committed; reason=; event=E142
- Proposal P28: actor=Aki [P3]; Committed; reason=; event=E143
- Proposal P29: actor=Nadi [P4]; Committed; reason=; event=E144
- Proposal P30: actor=Pala [P5]; Committed; reason=; event=E145

### Semantic events
- E128 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E129 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E130 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E131 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E132 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E133 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E134 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E135 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E136 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E137 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E138 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E139 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E140 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E141 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:5->6:Gift]
- E142 r14: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E143 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E144 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:6->5:Gift; P5:0->1:Gift]
- E145 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E146 r18: AttitudeComposition; participants=[P3,P2]; detail=66->76; fallback=False
- E147 r19: AttitudeComposition; participants=[P4,P1]; detail=-15->-5; fallback=False
- E148 r20: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P31: actor=Rima [P1]; Committed; reason=; event=E162
- Proposal P32: actor=Kima [P2]; Committed; reason=; event=E163
- Proposal P33: actor=Aki [P3]; Committed; reason=; event=E164
- Proposal P34: actor=Nadi [P4]; Committed; reason=; event=E165
- Proposal P35: actor=Pala [P5]; Committed; reason=; event=E166

### Semantic events
- E149 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E150 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E151 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E152 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E153 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E154 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E155 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E156 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E157 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E158 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E159 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E160 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E161 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E162 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E163 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E164 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E165 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:4->5:Gift]
- E166 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:3->4:Gift]
- E167 r18: AttitudeComposition; participants=[P2,P3]; detail=97->100; fallback=False
- E168 r19: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E169 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P36: actor=Rima [P1]; Committed; reason=; event=E185
- Proposal P37: actor=Kima [P2]; Committed; reason=; event=E186
- Proposal P38: actor=Aki [P3]; Committed; reason=; event=E187
- Proposal P39: actor=Nadi [P4]; Committed; reason=; event=E188
- Proposal P40: actor=Pala [P5]; Committed; reason=; event=E189

### Semantic events
- E170 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E171 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E172 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E173 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E174 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E175 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E176 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E177 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E178 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E179 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E180 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E181 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E182 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E183 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E184 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E185 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:3->4:Gift]
- E186 r16: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E187 r17: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E188 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:3->4:Gift]
- E189 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:3->4:Gift]
- E190 r20: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E191 r21: AttitudeComposition; participants=[P3,P2]; detail=76->86; fallback=False
- E192 r22: AttitudeComposition; participants=[P4,P1]; detail=-5->5; fallback=False
- E193 r23: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E194 r24: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=172 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Rima [P1]; Committed; reason=; event=E209
- Proposal P42: actor=Kima [P2]; Committed; reason=; event=E210
- Proposal P43: actor=Aki [P3]; Committed; reason=; event=E211
- Proposal P44: actor=Nadi [P4]; Committed; reason=; event=E212
- Proposal P45: actor=Pala [P5]; Committed; reason=; event=E213

### Semantic events
- E195 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E196 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E197 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E198 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E199 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E200 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E201 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E202 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E203 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E204 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E205 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E206 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E207 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E208 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E209 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E210 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E211 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E212 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:2->3:Gift]
- E213 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:2->3:Gift]
- E214 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E215 r20: AttitudeComposition; participants=[P3,P2]; detail=86->96; fallback=False
- E216 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E217 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P46: actor=Rima [P1]; Committed; reason=; event=E244
- Proposal P47: actor=Kima [P2]; Committed; reason=; event=E245
- Proposal P48: actor=Aki [P3]; Committed; reason=; event=E246
- Proposal P49: actor=Nadi [P4]; Committed; reason=; event=E247
- Proposal P50: actor=Pala [P5]; Committed; reason=; event=E248

### Semantic events
- E218 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E219 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E220 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E221 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E222 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E223 r5: AttitudeDecay; participants=[P1,P3]; detail=0->0; fallback=False
- E224 r6: AttitudeDecay; participants=[P1,P4]; detail=24->22; fallback=False
- E225 r7: AttitudeDecay; participants=[P1,P5]; detail=24->22; fallback=False
- E226 r8: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E227 r9: AttitudeDecay; participants=[P2,P4]; detail=-20->-19; fallback=False
- E228 r10: AttitudeDecay; participants=[P3,P1]; detail=18->16; fallback=False
- E229 r11: AttitudeDecay; participants=[P3,P2]; detail=96->94; fallback=False
- E230 r12: AttitudeDecay; participants=[P4,P1]; detail=5->3; fallback=False
- E231 r13: AttitudeDecay; participants=[P4,P2]; detail=49->47; fallback=False
- E232 r14: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E233 r15: AttitudeDecay; participants=[P5,P1]; detail=5->3; fallback=False
- E234 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E235 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E236 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E237 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E238 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E239 r21: Proposal; participants=[P3]; detail=Farm; fallback=False
- E240 r22: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E241 r23: Response; participants=[P5]; detail=Accept; fallback=False
- E242 r24: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E243 r25: Response; participants=[P4]; detail=Accept; fallback=False
- E244 r26: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:2->3:Gift]
- E245 r27: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E246 r28: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E247 r29: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:1->2:Gift]
- E248 r30: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:2->3:Gift]
- E249 r31: AttitudeComposition; participants=[P3,P2]; detail=94->100; fallback=False
- E250 r32: AttitudeComposition; participants=[P4,P1]; detail=3->13; fallback=False
- E251 r33: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E252 r34: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P51: actor=Rima [P1]; Committed; reason=; event=E266
- Proposal P52: actor=Kima [P2]; Committed; reason=; event=E267
- Proposal P53: actor=Aki [P3]; Committed; reason=; event=E268
- Proposal P54: actor=Nadi [P4]; Committed; reason=; event=E269
- Proposal P55: actor=Pala [P5]; Committed; reason=; event=E270

### Semantic events
- E253 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E254 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E255 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E256 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E257 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E258 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E259 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E260 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E261 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E262 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E263 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E264 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E265 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E266 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:2->3:Gift]
- E267 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E268 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E269 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:0->1:Gift]
- E270 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E271 r18: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E272 r19: AttitudeComposition; participants=[P4,P1]; detail=13->23; fallback=False
- E273 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P56: actor=Rima [P1]; Committed; reason=; event=E288
- Proposal P57: actor=Kima [P2]; Committed; reason=; event=E289
- Proposal P58: actor=Aki [P3]; Committed; reason=; event=E290
- Proposal P59: actor=Nadi [P4]; Committed; reason=; event=E291
- Proposal P60: actor=Pala [P5]; Committed; reason=; event=E292

### Semantic events
- E274 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E275 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E276 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E277 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E278 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E279 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E280 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E281 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E282 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E283 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E284 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E285 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E286 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E287 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E288 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E289 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E290 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E291 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:1->0:Gift; P5:4->5:Gift]
- E292 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:0->1:Gift]
- E293 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E294 r20: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E295 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E296 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=44 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Rima [P1]; Committed; reason=; event=E311
- Proposal P62: actor=Kima [P2]; Committed; reason=; event=E312
- Proposal P63: actor=Aki [P3]; Committed; reason=; event=E313
- Proposal P64: actor=Nadi [P4]; Committed; reason=; event=E314
- Proposal P65: actor=Pala [P5]; Committed; reason=; event=E315

### Semantic events
- E297 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E298 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E299 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E300 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E301 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E302 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E303 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E304 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E305 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E306 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E307 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E308 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E309 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E310 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E311 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:0->1:Gift]
- E312 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E313 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E314 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E315 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:5->6:Gift]
- E316 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E317 r20: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E318 r21: AttitudeComposition; participants=[P4,P1]; detail=23->33; fallback=False
- E319 r22: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P66: actor=Rima [P1]; Committed; reason=; event=E333
- Proposal P67: actor=Kima [P2]; Committed; reason=; event=E334
- Proposal P68: actor=Aki [P3]; Committed; reason=; event=E335
- Proposal P69: actor=Nadi [P4]; Committed; reason=; event=E336
- Proposal P70: actor=Pala [P5]; Committed; reason=; event=E337

### Semantic events
- E320 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E321 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E322 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E323 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E324 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E325 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E326 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E327 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E328 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E329 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E330 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E331 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E332 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E333 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E334 r14: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E335 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E336 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:1->2:Gift]
- E337 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:4->5:Gift]
- E338 r18: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E339 r19: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E340 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P71: actor=Rima [P1]; Committed; reason=; event=E366
- Proposal P72: actor=Kima [P2]; Committed; reason=; event=E367
- Proposal P73: actor=Aki [P3]; Committed; reason=; event=E368
- Proposal P74: actor=Nadi [P4]; Committed; reason=; event=E369
- Proposal P75: actor=Pala [P5]; Committed; reason=; event=E370

### Semantic events
- E341 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E342 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E343 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E344 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E345 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E346 r5: AttitudeDecay; participants=[P1,P3]; detail=0->0; fallback=False
- E347 r6: AttitudeDecay; participants=[P1,P4]; detail=22->20; fallback=False
- E348 r7: AttitudeDecay; participants=[P1,P5]; detail=22->20; fallback=False
- E349 r8: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E350 r9: AttitudeDecay; participants=[P2,P4]; detail=-19->-18; fallback=False
- E351 r10: AttitudeDecay; participants=[P3,P1]; detail=16->14; fallback=False
- E352 r11: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E353 r12: AttitudeDecay; participants=[P4,P1]; detail=33->31; fallback=False
- E354 r13: AttitudeDecay; participants=[P4,P2]; detail=47->45; fallback=False
- E355 r14: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E356 r15: AttitudeDecay; participants=[P5,P1]; detail=3->1; fallback=False
- E357 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E358 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E359 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E360 r19: Proposal; participants=[P2]; detail=Farm; fallback=False
- E361 r20: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E362 r21: Response; participants=[P2]; detail=Accept; fallback=False
- E363 r22: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E364 r23: Response; participants=[P5]; detail=Accept; fallback=False
- E365 r24: Proposal; participants=[P5]; detail=Farm; fallback=False
- E366 r25: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:4->5:Gift]
- E367 r26: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E368 r27: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E369 r28: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:0->1:Gift]
- E370 r29: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E371 r30: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E372 r31: AttitudeComposition; participants=[P4,P1]; detail=31->41; fallback=False
- E373 r32: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P76: actor=Rima [P1]; Committed; reason=; event=E389
- Proposal P77: actor=Kima [P2]; Committed; reason=; event=E390
- Proposal P78: actor=Aki [P3]; Committed; reason=; event=E391
- Proposal P79: actor=Nadi [P4]; Committed; reason=; event=E392
- Proposal P80: actor=Pala [P5]; Committed; reason=; event=E393

### Semantic events
- E374 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E375 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E376 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E377 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E378 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E379 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E380 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E381 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E382 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E383 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E384 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E385 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E386 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E387 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E388 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E389 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:3->4:Gift]
- E390 r16: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E391 r17: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E392 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:4->5:Gift]
- E393 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:3->4:Gift]
- E394 r20: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E395 r21: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E396 r22: AttitudeComposition; participants=[P4,P1]; detail=41->51; fallback=False
- E397 r23: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E398 r24: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Rima [P1]; Committed; reason=; event=E413
- Proposal P82: actor=Kima [P2]; Committed; reason=; event=E414
- Proposal P83: actor=Aki [P3]; Committed; reason=; event=E415
- Proposal P84: actor=Nadi [P4]; Committed; reason=; event=E416
- Proposal P85: actor=Pala [P5]; Committed; reason=; event=E417

### Semantic events
- E399 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E400 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E401 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E402 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E403 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E404 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E405 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E406 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E407 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E408 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E409 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E410 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E411 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E412 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E413 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E414 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E415 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E416 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E417 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E418 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E419 r20: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E420 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E421 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=40 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P86: actor=Rima [P1]; Committed; reason=; event=E436
- Proposal P87: actor=Kima [P2]; Committed; reason=; event=E437
- Proposal P88: actor=Aki [P3]; Committed; reason=; event=E438
- Proposal P89: actor=Nadi [P4]; Committed; reason=; event=E439
- Proposal P90: actor=Pala [P5]; Committed; reason=; event=E440

### Semantic events
- E422 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E423 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E424 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E425 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E426 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E427 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E428 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E429 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E430 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E431 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E432 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E433 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E434 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E435 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E436 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:2->3:Gift]
- E437 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E438 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E439 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:2->3:Gift]
- E440 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:2->3:Gift]
- E441 r19: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E442 r20: AttitudeComposition; participants=[P4,P1]; detail=51->61; fallback=False
- E443 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E444 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P91: actor=Rima [P1]; Committed; reason=; event=E458
- Proposal P92: actor=Kima [P2]; Committed; reason=; event=E459
- Proposal P93: actor=Aki [P3]; Committed; reason=; event=E460
- Proposal P94: actor=Nadi [P4]; Committed; reason=; event=E461
- Proposal P95: actor=Pala [P5]; Committed; reason=; event=E462

### Semantic events
- E445 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E446 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E447 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E448 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E449 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E450 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E451 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E452 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E453 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E454 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E455 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E456 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E457 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E458 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E459 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E460 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E461 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:1->2:Gift]
- E462 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:1->2:Gift]
- E463 r18: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E464 r19: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E465 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=36 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P96: actor=Rima [P1]; Committed; reason=; event=E492
- Proposal P97: actor=Kima [P2]; Committed; reason=; event=E493
- Proposal P98: actor=Aki [P3]; Committed; reason=; event=E494
- Proposal P99: actor=Nadi [P4]; Committed; reason=; event=E495
- Proposal P100: actor=Pala [P5]; Committed; reason=; event=E496

### Semantic events
- E466 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E467 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E468 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E469 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E470 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E471 r5: AttitudeDecay; participants=[P1,P3]; detail=0->0; fallback=False
- E472 r6: AttitudeDecay; participants=[P1,P4]; detail=20->18; fallback=False
- E473 r7: AttitudeDecay; participants=[P1,P5]; detail=20->18; fallback=False
- E474 r8: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E475 r9: AttitudeDecay; participants=[P2,P4]; detail=-18->-17; fallback=False
- E476 r10: AttitudeDecay; participants=[P3,P1]; detail=14->12; fallback=False
- E477 r11: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E478 r12: AttitudeDecay; participants=[P4,P1]; detail=61->59; fallback=False
- E479 r13: AttitudeDecay; participants=[P4,P2]; detail=45->43; fallback=False
- E480 r14: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E481 r15: AttitudeDecay; participants=[P5,P1]; detail=1->0; fallback=False
- E482 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E483 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E484 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E485 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E486 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E487 r21: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E488 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E489 r23: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E490 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E491 r25: Proposal; participants=[P5]; detail=Farm; fallback=False
- E492 r26: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:1->2:Gift]
- E493 r27: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E494 r28: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E495 r29: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:0->1:Gift]
- E496 r30: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E497 r31: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E498 r32: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E499 r33: AttitudeComposition; participants=[P4,P1]; detail=59->69; fallback=False
- E500 r34: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=36 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Rima [P1]; Committed; reason=; event=E515
- Proposal P102: actor=Kima [P2]; Committed; reason=; event=E516
- Proposal P103: actor=Aki [P3]; Committed; reason=; event=E517
- Proposal P104: actor=Nadi [P4]; Committed; reason=; event=E518
- Proposal P105: actor=Pala [P5]; Committed; reason=; event=E519

### Semantic events
- E501 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E502 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E503 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E504 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E505 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E506 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E507 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E508 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E509 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E510 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E511 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E512 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E513 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E514 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E515 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:0->1:Gift]
- E516 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E517 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E518 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E519 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:5->6:Gift]
- E520 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E521 r20: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E522 r21: AttitudeComposition; participants=[P4,P1]; detail=69->79; fallback=False
- E523 r22: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P106: actor=Rima [P1]; Committed; reason=; event=E537
- Proposal P107: actor=Kima [P2]; Committed; reason=; event=E538
- Proposal P108: actor=Aki [P3]; Committed; reason=; event=E539
- Proposal P109: actor=Nadi [P4]; Committed; reason=; event=E540
- Proposal P110: actor=Pala [P5]; Committed; reason=; event=E541

### Semantic events
- E524 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E525 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E526 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E527 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E528 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E529 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E530 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E531 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E532 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E533 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E534 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E535 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E536 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E537 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E538 r14: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E539 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E540 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:2->3:Gift]
- E541 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:4->5:Gift]
- E542 r18: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E543 r19: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E544 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=36 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P111: actor=Rima [P1]; Committed; reason=; event=E559
- Proposal P112: actor=Kima [P2]; Committed; reason=; event=E560
- Proposal P113: actor=Aki [P3]; Committed; reason=; event=E561
- Proposal P114: actor=Nadi [P4]; Committed; reason=; event=E562
- Proposal P115: actor=Pala [P5]; Committed; reason=; event=E563

### Semantic events
- E545 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E546 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E547 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E548 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E549 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E550 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E551 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E552 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E553 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E554 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E555 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E556 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E557 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E558 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E559 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:4->5:Gift]
- E560 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E561 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E562 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:1->2:Gift]
- E563 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:4->5:Gift]
- E564 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E565 r20: AttitudeComposition; participants=[P4,P1]; detail=79->89; fallback=False
- E566 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E567 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P116: actor=Rima [P1]; Committed; reason=; event=E581
- Proposal P117: actor=Kima [P2]; Committed; reason=; event=E582
- Proposal P118: actor=Aki [P3]; Committed; reason=; event=E583
- Proposal P119: actor=Nadi [P4]; Committed; reason=; event=E584
- Proposal P120: actor=Pala [P5]; Committed; reason=; event=E585

### Semantic events
- E568 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E569 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E570 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E571 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E572 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E573 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E574 r6: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E575 r7: Response; participants=[P3]; detail=Accept; fallback=False
- E576 r8: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E577 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E578 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E579 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E580 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E581 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:3->7:FarmSource]
- E582 r14: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E583 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E584 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:0->1:Gift]
- E585 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E586 r18: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E587 r19: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E588 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=5; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=32 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P121: actor=Rima [P1]; Committed; reason=; event=E616
- Proposal P122: actor=Kima [P2]; Committed; reason=; event=E617
- Proposal P123: actor=Aki [P3]; Committed; reason=; event=E618
- Proposal P124: actor=Nadi [P4]; Committed; reason=; event=E619
- Proposal P125: actor=Pala [P5]; Committed; reason=; event=E620

### Semantic events
- E589 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E590 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E591 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E592 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E593 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E594 r5: AttitudeDecay; participants=[P1,P3]; detail=0->0; fallback=False
- E595 r6: AttitudeDecay; participants=[P1,P4]; detail=18->16; fallback=False
- E596 r7: AttitudeDecay; participants=[P1,P5]; detail=18->16; fallback=False
- E597 r8: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E598 r9: AttitudeDecay; participants=[P2,P4]; detail=-17->-16; fallback=False
- E599 r10: AttitudeDecay; participants=[P3,P1]; detail=12->10; fallback=False
- E600 r11: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E601 r12: AttitudeDecay; participants=[P4,P1]; detail=89->87; fallback=False
- E602 r13: AttitudeDecay; participants=[P4,P2]; detail=43->41; fallback=False
- E603 r14: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E604 r15: AttitudeDecay; participants=[P5,P1]; detail=0->0; fallback=False
- E605 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E606 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E607 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E608 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E609 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E610 r21: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E611 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E612 r23: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E613 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E614 r25: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E615 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E616 r27: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:2->3:Gift]
- E617 r28: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E618 r29: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E619 r30: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:4->5:Gift]
- E620 r31: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:2->3:Gift]
- E621 r32: AttitudeComposition; participants=[P2,P3]; detail=98->100; fallback=False
- E622 r33: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E623 r34: AttitudeComposition; participants=[P4,P1]; detail=87->97; fallback=False
- E624 r35: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E625 r36: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=32 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Pala [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P126: actor=Rima [P1]; Committed; reason=; event=E640
- Proposal P127: actor=Kima [P2]; Committed; reason=; event=E641
- Proposal P128: actor=Aki [P3]; Committed; reason=; event=E642
- Proposal P129: actor=Nadi [P4]; Committed; reason=; event=E643
- Proposal P130: actor=Pala [P5]; Committed; reason=; event=E644

### Semantic events
- E626 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E627 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E628 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E629 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E630 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E631 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E632 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E633 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E634 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E635 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E636 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E637 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E638 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E639 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E640 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:2->3:Gift]
- E641 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E642 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E643 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E644 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E645 r19: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E646 r20: AttitudeComposition; participants=[P4,P1]; detail=97->100; fallback=False
- E647 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E648 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=3; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Rima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P131: actor=Rima [P1]; Committed; reason=; event=E662
- Proposal P132: actor=Kima [P2]; Committed; reason=; event=E663
- Proposal P133: actor=Aki [P3]; Committed; reason=; event=E664
- Proposal P134: actor=Nadi [P4]; Committed; reason=; event=E665
- Proposal P135: actor=Pala [P5]; Committed; reason=; event=E666

### Semantic events
- E649 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E650 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E651 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E652 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E653 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E654 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E655 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E656 r7: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E657 r8: Response; participants=[P2]; detail=Accept; fallback=False
- E658 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E659 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E660 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E661 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E662 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:2->6:FarmSource]
- E663 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E664 r15: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:4->3:Gift; P2:4->5:Gift]
- E665 r16: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:6->7:Gift]
- E666 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:1->2:Gift]
- E667 r18: AttitudeComposition; participants=[P1,P4]; detail=16->26; fallback=False
- E668 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E669 r20: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=7; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=1; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P136: actor=Rima [P1]; Committed; reason=; event=E684
- Proposal P137: actor=Kima [P2]; Committed; reason=; event=E685
- Proposal P138: actor=Aki [P3]; Committed; reason=; event=E686
- Proposal P139: actor=Nadi [P4]; Committed; reason=; event=E687
- Proposal P140: actor=Pala [P5]; Committed; reason=; event=E688

### Semantic events
- E670 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E671 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E672 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E673 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E674 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E675 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E676 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E677 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E678 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E679 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E680 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E681 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E682 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E683 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E684 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:1->2:Gift]
- E685 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:4->3:Gift; P3:2->3:Gift]
- E686 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:3->2:Gift; P2:3->4:Gift]
- E687 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:5->6:Gift]
- E688 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:0->4:FarmSource]
- E689 r19: AttitudeComposition; participants=[P1,P4]; detail=26->36; fallback=False
- E690 r20: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E691 r21: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E692 r22: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=4; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=72 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P141: actor=Rima [P1]; Committed; reason=; event=E707
- Proposal P142: actor=Kima [P2]; Committed; reason=; event=E708
- Proposal P143: actor=Aki [P3]; Committed; reason=; event=E709
- Proposal P144: actor=Nadi [P4]; Committed; reason=; event=E710
- Proposal P145: actor=Pala [P5]; Committed; reason=; event=E711

### Semantic events
- E693 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E694 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E695 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E696 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E697 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E698 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E699 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E700 r7: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E701 r8: Response; participants=[P3]; detail=Accept; fallback=False
- E702 r9: Proposal; participants=[P3]; detail=OfferGift(2,1); fallback=False
- E703 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E704 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E705 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E706 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E707 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:0->1:Gift]
- E708 r15: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:3->2:Gift; P3:1->2:Gift]
- E709 r16: Gift; participants=[P3,P2]; detail=OfferGift(2,1); fallback=False material=[P3:2->1:Gift; P2:2->3:Gift]
- E710 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E711 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:5->6:Gift]
- E712 r19: AttitudeComposition; participants=[P2,P3]; detail=100->100; fallback=False
- E713 r20: AttitudeComposition; participants=[P3,P2]; detail=100->100; fallback=False
- E714 r21: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E715 r22: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Rima [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=2; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Rima [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=68 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Rima [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Pala [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P146: actor=Rima [P1]; Committed; reason=; event=E742
- Proposal P147: actor=Kima [P2]; Committed; reason=; event=E743
- Proposal P148: actor=Aki [P3]; Committed; reason=; event=E744
- Proposal P149: actor=Nadi [P4]; Committed; reason=; event=E745
- Proposal P150: actor=Pala [P5]; Committed; reason=; event=E746

### Semantic events
- E716 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E717 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E718 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E719 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E720 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E721 r5: AttitudeDecay; participants=[P1,P3]; detail=0->0; fallback=False
- E722 r6: AttitudeDecay; participants=[P1,P4]; detail=36->34; fallback=False
- E723 r7: AttitudeDecay; participants=[P1,P5]; detail=16->14; fallback=False
- E724 r8: AttitudeDecay; participants=[P2,P3]; detail=100->98; fallback=False
- E725 r9: AttitudeDecay; participants=[P2,P4]; detail=-16->-15; fallback=False
- E726 r10: AttitudeDecay; participants=[P3,P1]; detail=10->8; fallback=False
- E727 r11: AttitudeDecay; participants=[P3,P2]; detail=100->98; fallback=False
- E728 r12: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E729 r13: AttitudeDecay; participants=[P4,P2]; detail=41->39; fallback=False
- E730 r14: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E731 r15: AttitudeDecay; participants=[P5,P1]; detail=0->0; fallback=False
- E732 r16: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E733 r17: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E734 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E735 r19: Proposal; participants=[P2]; detail=OfferGift(3,1); fallback=False
- E736 r20: Response; participants=[P3]; detail=Accept; fallback=False
- E737 r21: Proposal; participants=[P3]; detail=Farm; fallback=False
- E738 r22: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E739 r23: Response; participants=[P1]; detail=Accept; fallback=False
- E740 r24: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E741 r25: Response; participants=[P4]; detail=Accept; fallback=False
- E742 r26: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:5->6:Gift]
- E743 r27: Gift; participants=[P2,P3]; detail=OfferGift(3,1); fallback=False material=[P2:2->1:Gift; P3:0->1:Gift]
- E744 r28: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E745 r29: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:6->5:Gift; P1:2->3:Gift]
- E746 r30: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:5->6:Gift]
- E747 r31: AttitudeComposition; participants=[P1,P4]; detail=34->44; fallback=False
- E748 r32: AttitudeComposition; participants=[P3,P2]; detail=98->100; fallback=False
- E749 r33: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False
- E750 r34: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False

### Stable state
- Rima [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Aki [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Pala [P5]: grain=0; NeedsGrain=False; dwelling=D1
- MaterialDeadlock=False

## Stop

- Horizon:30
