# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Luma: sex=Female; grain=7; NeedsGrain=False; dwelling=D1
- P2 Hani: sex=Male; grain=7; NeedsGrain=False; dwelling=D2
- P3 Zami: sex=Female; grain=1; NeedsGrain=False; dwelling=D2
- P4 Aki: sex=Male; grain=5; NeedsGrain=False; dwelling=D2
- P5 Tari: sex=Female; grain=5; NeedsGrain=False; dwelling=D3

## Cycle 1

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=171 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=62 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=228 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Luma [P1]; Committed; reason=; event=E15
- Proposal P2: actor=Hani [P2]; Committed; reason=; event=E16
- Proposal P3: actor=Zami [P3]; Committed; reason=; event=E17
- Proposal P4: actor=Aki [P4]; Committed; reason=; event=E18
- Proposal P5: actor=Tari [P5]; Committed; reason=; event=E19

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:7->6:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E5 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E6 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E7 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E8 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E9 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E10 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E11 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E12 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E13 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E14 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E15 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:6->5:Gift; P4:4->5:Gift]
- E16 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:5->6:Gift]
- E17 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E18 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:5->4:Gift; P3:4->5:Gift]
- E19 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:5->6:Gift]
- E20 r19: AttitudeComposition; participants=[P1,P2]; detail=-13->-3; fallback=False
- E21 r20: AttitudeComposition; participants=[P3,P4]; detail=-32->-22; fallback=False
- E22 r21: AttitudeComposition; participants=[P3,P5]; detail=27->37; fallback=False
- E23 r22: AttitudeComposition; participants=[P4,P1]; detail=-34->-24; fallback=False

### Stable state
- Luma [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=171 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=62 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=111 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=228 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P6: actor=Luma [P1]; Committed; reason=; event=E38
- Proposal P7: actor=Hani [P2]; Committed; reason=; event=E39
- Proposal P8: actor=Zami [P3]; Committed; reason=; event=E40
- Proposal P9: actor=Aki [P4]; Committed; reason=; event=E41
- Proposal P10: actor=Tari [P5]; Committed; reason=; event=E42

### Semantic events
- E24 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E25 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E26 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E27 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E28 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E29 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E30 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E31 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E32 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E33 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E34 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E35 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E36 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E37 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E38 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:3->4:Gift]
- E39 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:4->5:Gift]
- E40 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:5->4:Gift; P5:2->3:Gift]
- E41 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:4->8:FarmSource]
- E42 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:3->2:Gift; P3:4->5:Gift]
- E43 r19: AttitudeComposition; participants=[P1,P2]; detail=-3->7; fallback=False
- E44 r20: AttitudeComposition; participants=[P3,P5]; detail=37->47; fallback=False
- E45 r21: AttitudeComposition; participants=[P4,P1]; detail=-24->-14; fallback=False
- E46 r22: AttitudeComposition; participants=[P5,P3]; detail=76->86; fallback=False

### Stable state
- Luma [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=8; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=171 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=62 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=141 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=258 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P11: actor=Luma [P1]; Committed; reason=; event=E62
- Proposal P12: actor=Hani [P2]; Committed; reason=; event=E63
- Proposal P13: actor=Zami [P3]; Committed; reason=; event=E64
- Proposal P14: actor=Aki [P4]; Committed; reason=; event=E65
- Proposal P15: actor=Tari [P5]; Committed; reason=; event=E66

### Semantic events
- E47 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E48 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E49 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E50 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:8->7:ConsumptionSink]
- E51 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E52 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E53 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E54 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E55 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E56 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E57 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E58 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E59 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E60 r13: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E61 r14: Response; participants=[P3]; detail=Accept; fallback=False
- E62 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:7->8:Gift]
- E63 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:3->4:Gift]
- E64 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:1->2:Gift]
- E65 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:8->7:Gift; P3:3->4:Gift]
- E66 r19: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:2->1:Gift; P3:4->5:Gift]
- E67 r20: AttitudeComposition; participants=[P1,P2]; detail=7->17; fallback=False
- E68 r21: AttitudeComposition; participants=[P3,P4]; detail=-22->-12; fallback=False
- E69 r22: AttitudeComposition; participants=[P3,P5]; detail=47->57; fallback=False
- E70 r23: AttitudeComposition; participants=[P4,P1]; detail=-14->-4; fallback=False
- E71 r24: AttitudeComposition; participants=[P5,P3]; detail=86->96; fallback=False

### Stable state
- Luma [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=7; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=171 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=171 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=10 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P16: actor=Luma [P1]; Committed; reason=; event=E85
- Proposal P17: actor=Hani [P2]; Committed; reason=; event=E86
- Proposal P18: actor=Zami [P3]; Committed; reason=; event=E87
- Proposal P19: actor=Aki [P4]; Committed; reason=; event=E88
- Proposal P20: actor=Tari [P5]; Committed; reason=; event=E89

### Semantic events
- E72 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E73 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E74 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E75 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E76 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E77 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E78 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E79 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E80 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E81 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E82 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E83 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E84 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E85 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:6->7:Gift]
- E86 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E87 r15: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:0->1:Gift]
- E88 r16: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:7->6:Gift; P3:3->4:Gift]
- E89 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E90 r18: AttitudeComposition; participants=[P3,P4]; detail=-12->-2; fallback=False
- E91 r19: AttitudeComposition; participants=[P4,P1]; detail=-4->6; fallback=False
- E92 r20: AttitudeComposition; participants=[P5,P3]; detail=96->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=165 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=165 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=12 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Luma [P1]; Committed; reason=; event=E123
- Proposal P22: actor=Hani [P2]; Committed; reason=; event=E124
- Proposal P23: actor=Zami [P3]; Committed; reason=; event=E125
- Proposal P24: actor=Aki [P4]; Committed; reason=; event=E126
- Proposal P25: actor=Tari [P5]; Committed; reason=; event=E127

### Semantic events
- E93 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E94 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E95 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E96 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E97 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E98 r5: AttitudeDecay; participants=[P1,P2]; detail=17->15; fallback=False
- E99 r6: AttitudeDecay; participants=[P1,P4]; detail=57->55; fallback=False
- E100 r7: AttitudeDecay; participants=[P1,P5]; detail=19->17; fallback=False
- E101 r8: AttitudeDecay; participants=[P2,P1]; detail=31->29; fallback=False
- E102 r9: AttitudeDecay; participants=[P2,P3]; detail=-15->-14; fallback=False
- E103 r10: AttitudeDecay; participants=[P2,P4]; detail=-34->-33; fallback=False
- E104 r11: AttitudeDecay; participants=[P2,P5]; detail=18->16; fallback=False
- E105 r12: AttitudeDecay; participants=[P3,P2]; detail=-3->-2; fallback=False
- E106 r13: AttitudeDecay; participants=[P3,P4]; detail=-2->-1; fallback=False
- E107 r14: AttitudeDecay; participants=[P3,P5]; detail=57->55; fallback=False
- E108 r15: AttitudeDecay; participants=[P4,P1]; detail=6->4; fallback=False
- E109 r16: AttitudeDecay; participants=[P4,P2]; detail=-50->-49; fallback=False
- E110 r17: AttitudeDecay; participants=[P4,P3]; detail=5->3; fallback=False
- E111 r18: AttitudeDecay; participants=[P5,P1]; detail=3->1; fallback=False
- E112 r19: AttitudeDecay; participants=[P5,P2]; detail=2->0; fallback=False
- E113 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E114 r21: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E115 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E116 r23: Proposal; participants=[P2]; detail=Farm; fallback=False
- E117 r24: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E118 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E119 r26: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E120 r27: Response; participants=[P1]; detail=Accept; fallback=False
- E121 r28: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E122 r29: Response; participants=[P3]; detail=Accept; fallback=False
- E123 r30: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:5->6:Gift]
- E124 r31: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E125 r32: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:3->2:Gift; P5:4->5:Gift]
- E126 r33: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:6->5:Gift; P1:0->1:Gift]
- E127 r34: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:5->4:Gift; P3:2->3:Gift]
- E128 r35: AttitudeComposition; participants=[P1,P4]; detail=55->65; fallback=False
- E129 r36: AttitudeComposition; participants=[P3,P5]; detail=55->65; fallback=False
- E130 r37: AttitudeComposition; participants=[P4,P1]; detail=4->14; fallback=False
- E131 r38: AttitudeComposition; participants=[P5,P3]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=58 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=195 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=42 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P26: actor=Luma [P1]; Committed; reason=; event=E146
- Proposal P27: actor=Hani [P2]; Committed; reason=; event=E147
- Proposal P28: actor=Zami [P3]; Committed; reason=; event=E148
- Proposal P29: actor=Aki [P4]; Committed; reason=; event=E149
- Proposal P30: actor=Tari [P5]; Committed; reason=; event=E150

### Semantic events
- E132 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E133 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E134 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E135 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E136 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E137 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E138 r6: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E139 r7: Response; participants=[P1]; detail=Accept; fallback=False
- E140 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E141 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E142 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E143 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E144 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E145 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E146 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E147 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:4->5:Gift]
- E148 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:2->1:Gift; P5:3->4:Gift]
- E149 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:5->6:Gift]
- E150 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:1->2:Gift]
- E151 r19: AttitudeComposition; participants=[P1,P2]; detail=15->25; fallback=False
- E152 r20: AttitudeComposition; participants=[P1,P4]; detail=65->75; fallback=False
- E153 r21: AttitudeComposition; participants=[P3,P5]; detail=65->75; fallback=False
- E154 r22: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=225 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=58 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=225 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P31: actor=Luma [P1]; Committed; reason=; event=E169
- Proposal P32: actor=Hani [P2]; Committed; reason=; event=E170
- Proposal P33: actor=Zami [P3]; Committed; reason=; event=E171
- Proposal P34: actor=Aki [P4]; Committed; reason=; event=E172
- Proposal P35: actor=Tari [P5]; Committed; reason=; event=E173

### Semantic events
- E155 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E156 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E157 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E158 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E159 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E160 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E161 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E162 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E163 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E164 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E165 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E166 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E167 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E168 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E169 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:2->3:Gift]
- E170 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:4->5:Gift]
- E171 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:2->3:Gift]
- E172 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:3->7:FarmSource]
- E173 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:3->2:Gift; P3:0->1:Gift]
- E174 r19: AttitudeComposition; participants=[P1,P2]; detail=25->35; fallback=False
- E175 r20: AttitudeComposition; participants=[P3,P5]; detail=75->85; fallback=False
- E176 r21: AttitudeComposition; participants=[P4,P1]; detail=14->24; fallback=False
- E177 r22: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=7; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=225 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=72 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P36: actor=Luma [P1]; Committed; reason=; event=E191
- Proposal P37: actor=Hani [P2]; Committed; reason=; event=E192
- Proposal P38: actor=Zami [P3]; Committed; reason=; event=E193
- Proposal P39: actor=Aki [P4]; Committed; reason=; event=E194
- Proposal P40: actor=Tari [P5]; Committed; reason=; event=E195

### Semantic events
- E178 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E179 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E180 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E181 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E182 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E183 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E184 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E185 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E186 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E187 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E188 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E189 r11: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E190 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E191 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:6->7:Gift]
- E192 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E193 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E194 r16: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:7->6:Gift; P1:3->4:Gift]
- E195 r17: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:1->0:Gift; P3:4->5:Gift]
- E196 r18: AttitudeComposition; participants=[P1,P4]; detail=75->85; fallback=False
- E197 r19: AttitudeComposition; participants=[P3,P5]; detail=85->95; fallback=False
- E198 r20: AttitudeComposition; participants=[P4,P1]; detail=24->34; fallback=False

### Stable state
- Luma [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=255 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=58 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=285 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=102 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Luma [P1]; Committed; reason=; event=E214
- Proposal P42: actor=Hani [P2]; Committed; reason=; event=E215
- Proposal P43: actor=Zami [P3]; Committed; reason=; event=E216
- Proposal P44: actor=Aki [P4]; Committed; reason=; event=E217
- Proposal P45: actor=Tari [P5]; Committed; reason=; event=E218

### Semantic events
- E199 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E200 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E201 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E202 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E203 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E204 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E205 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E206 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E207 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E208 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E209 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E210 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E211 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E212 r13: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E213 r14: Response; participants=[P1]; detail=Accept; fallback=False
- E214 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:5->6:Gift]
- E215 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:2->3:Gift]
- E216 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:0->1:Gift]
- E217 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:6->5:Gift; P1:3->4:Gift]
- E218 r19: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:4->3:Help; P5:1->2:Help]
- E219 r20: AttitudeComposition; participants=[P1,P2]; detail=35->45; fallback=False
- E220 r21: AttitudeComposition; participants=[P1,P4]; detail=85->95; fallback=False
- E221 r22: AttitudeComposition; participants=[P4,P1]; detail=34->44; fallback=False
- E222 r23: AttitudeComposition; participants=[P5,P1]; detail=1->11; fallback=False
- E223 r24: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=279 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=279 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=126 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P46: actor=Luma [P1]; Committed; reason=; event=E254
- Proposal P47: actor=Hani [P2]; Committed; reason=; event=E255
- Proposal P48: actor=Zami [P3]; Committed; reason=; event=E256
- Proposal P49: actor=Aki [P4]; Committed; reason=; event=E257
- Proposal P50: actor=Tari [P5]; Committed; reason=; event=E258

### Semantic events
- E224 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E225 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E226 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E227 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E228 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E229 r5: AttitudeDecay; participants=[P1,P2]; detail=45->43; fallback=False
- E230 r6: AttitudeDecay; participants=[P1,P4]; detail=95->93; fallback=False
- E231 r7: AttitudeDecay; participants=[P1,P5]; detail=17->15; fallback=False
- E232 r8: AttitudeDecay; participants=[P2,P1]; detail=29->27; fallback=False
- E233 r9: AttitudeDecay; participants=[P2,P3]; detail=-14->-13; fallback=False
- E234 r10: AttitudeDecay; participants=[P2,P4]; detail=-33->-32; fallback=False
- E235 r11: AttitudeDecay; participants=[P2,P5]; detail=16->14; fallback=False
- E236 r12: AttitudeDecay; participants=[P3,P2]; detail=-2->-1; fallback=False
- E237 r13: AttitudeDecay; participants=[P3,P4]; detail=-1->0; fallback=False
- E238 r14: AttitudeDecay; participants=[P3,P5]; detail=95->93; fallback=False
- E239 r15: AttitudeDecay; participants=[P4,P1]; detail=44->42; fallback=False
- E240 r16: AttitudeDecay; participants=[P4,P2]; detail=-49->-48; fallback=False
- E241 r17: AttitudeDecay; participants=[P4,P3]; detail=3->1; fallback=False
- E242 r18: AttitudeDecay; participants=[P5,P1]; detail=11->9; fallback=False
- E243 r19: AttitudeDecay; participants=[P5,P2]; detail=0->0; fallback=False
- E244 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E245 r21: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E246 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E247 r23: Proposal; participants=[P2]; detail=Farm; fallback=False
- E248 r24: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E249 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E250 r26: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E251 r27: Response; participants=[P1]; detail=Accept; fallback=False
- E252 r28: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E253 r29: Response; participants=[P3]; detail=Accept; fallback=False
- E254 r30: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:4->5:Gift]
- E255 r31: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E256 r32: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:2->1:Gift; P5:1->2:Gift]
- E257 r33: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:5->4:Gift; P1:1->2:Gift]
- E258 r34: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:2->1:Gift; P3:1->2:Gift]
- E259 r35: AttitudeComposition; participants=[P1,P4]; detail=93->100; fallback=False
- E260 r36: AttitudeComposition; participants=[P3,P5]; detail=93->100; fallback=False
- E261 r37: AttitudeComposition; participants=[P4,P1]; detail=42->52; fallback=False
- E262 r38: AttitudeComposition; participants=[P5,P3]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=54 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P51: actor=Luma [P1]; Committed; reason=; event=E277
- Proposal P52: actor=Hani [P2]; Committed; reason=; event=E278
- Proposal P53: actor=Zami [P3]; Committed; reason=; event=E279
- Proposal P54: actor=Aki [P4]; Committed; reason=; event=E280
- Proposal P55: actor=Tari [P5]; Committed; reason=; event=E281

### Semantic events
- E263 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E264 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E265 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E266 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E267 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E268 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E269 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E270 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E271 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E272 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E273 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E274 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E275 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E276 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E277 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:3->4:Gift]
- E278 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:0->1:Gift]
- E279 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:0->1:Gift]
- E280 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:1->2:Gift]
- E281 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E282 r19: AttitudeComposition; participants=[P1,P2]; detail=43->53; fallback=False
- E283 r20: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E284 r21: AttitudeComposition; participants=[P4,P1]; detail=52->62; fallback=False
- E285 r22: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=54 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=186 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P56: actor=Luma [P1]; Committed; reason=; event=E301
- Proposal P57: actor=Hani [P2]; Committed; reason=; event=E302
- Proposal P58: actor=Zami [P3]; Committed; reason=; event=E303
- Proposal P59: actor=Aki [P4]; Committed; reason=; event=E304
- Proposal P60: actor=Tari [P5]; Committed; reason=; event=E305

### Semantic events
- E286 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E287 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E288 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E289 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E290 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E291 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E292 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E293 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E294 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E295 r9: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E296 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E297 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E298 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E299 r13: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E300 r14: Response; participants=[P3]; detail=Accept; fallback=False
- E301 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:2->3:Gift]
- E302 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:0->1:Gift]
- E303 r17: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P3:0->1:Help]
- E304 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E305 r19: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:1->2:Gift]
- E306 r20: AttitudeComposition; participants=[P1,P2]; detail=53->63; fallback=False
- E307 r21: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E308 r22: AttitudeComposition; participants=[P3,P2]; detail=-1->9; fallback=False
- E309 r23: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E310 r24: AttitudeComposition; participants=[P4,P1]; detail=62->72; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=216 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Luma [P1]; Committed; reason=; event=E325
- Proposal P62: actor=Hani [P2]; Committed; reason=; event=E326
- Proposal P63: actor=Zami [P3]; Committed; reason=; event=E327
- Proposal P64: actor=Aki [P4]; Committed; reason=; event=E328
- Proposal P65: actor=Tari [P5]; Committed; reason=; event=E329

### Semantic events
- E311 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E312 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E313 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E314 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E315 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E316 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E317 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E318 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E319 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E320 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E321 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E322 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E323 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E324 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E325 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E326 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E327 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:2->3:Gift]
- E328 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:0->1:Gift]
- E329 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:3->2:Gift; P3:0->1:Gift]
- E330 r19: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E331 r20: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E332 r21: AttitudeComposition; participants=[P4,P1]; detail=72->82; fallback=False
- E333 r22: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=54 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P66: actor=Luma [P1]; Committed; reason=; event=E346
- Proposal P67: actor=Hani [P2]; Committed; reason=; event=E347
- Proposal P68: actor=Zami [P3]; Committed; reason=; event=E348
- Proposal P69: actor=Aki [P4]; Committed; reason=; event=E349
- Proposal P70: actor=Tari [P5]; Committed; reason=; event=E350

### Semantic events
- E334 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E335 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E336 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E337 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E338 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E339 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E340 r6: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E341 r7: Response; participants=[P1]; detail=Accept; fallback=False
- E342 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E343 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E344 r10: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E345 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E346 r12: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E347 r13: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:4->5:Gift]
- E348 r14: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E349 r15: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:0->4:FarmSource]
- E350 r16: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:1->0:Gift; P3:4->5:Gift]
- E351 r17: AttitudeComposition; participants=[P1,P2]; detail=63->73; fallback=False
- E352 r18: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=240 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P71: actor=Luma [P1]; Committed; reason=; event=E383
- Proposal P72: actor=Hani [P2]; Committed; reason=; event=E384
- Proposal P73: actor=Zami [P3]; Committed; reason=; event=E385
- Proposal P74: actor=Aki [P4]; Committed; reason=; event=E386
- Proposal P75: actor=Tari [P5]; Committed; reason=; event=E387

### Semantic events
- E353 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E354 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E355 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E356 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E357 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E358 r5: AttitudeDecay; participants=[P1,P2]; detail=73->71; fallback=False
- E359 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E360 r7: AttitudeDecay; participants=[P1,P5]; detail=15->13; fallback=False
- E361 r8: AttitudeDecay; participants=[P2,P1]; detail=27->25; fallback=False
- E362 r9: AttitudeDecay; participants=[P2,P3]; detail=-13->-12; fallback=False
- E363 r10: AttitudeDecay; participants=[P2,P4]; detail=-32->-31; fallback=False
- E364 r11: AttitudeDecay; participants=[P2,P5]; detail=14->12; fallback=False
- E365 r12: AttitudeDecay; participants=[P3,P2]; detail=9->7; fallback=False
- E366 r13: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E367 r14: AttitudeDecay; participants=[P3,P5]; detail=100->98; fallback=False
- E368 r15: AttitudeDecay; participants=[P4,P1]; detail=82->80; fallback=False
- E369 r16: AttitudeDecay; participants=[P4,P2]; detail=-48->-47; fallback=False
- E370 r17: AttitudeDecay; participants=[P4,P3]; detail=1->0; fallback=False
- E371 r18: AttitudeDecay; participants=[P5,P1]; detail=9->7; fallback=False
- E372 r19: AttitudeDecay; participants=[P5,P2]; detail=0->0; fallback=False
- E373 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E374 r21: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E375 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E376 r23: Proposal; participants=[P2]; detail=Farm; fallback=False
- E377 r24: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E378 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E379 r26: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E380 r27: Response; participants=[P1]; detail=Accept; fallback=False
- E381 r28: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E382 r29: Response; participants=[P1]; detail=Accept; fallback=False
- E383 r30: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:3->4:Gift]
- E384 r31: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E385 r32: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:0->1:Gift]
- E386 r33: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:3->4:Gift]
- E387 r34: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:4->3:Help; P5:1->2:Help]
- E388 r35: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E389 r36: AttitudeComposition; participants=[P4,P1]; detail=80->90; fallback=False
- E390 r37: AttitudeComposition; participants=[P5,P1]; detail=7->17; fallback=False
- E391 r38: AttitudeComposition; participants=[P5,P3]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=50 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=270 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P76: actor=Luma [P1]; Committed; reason=; event=E407
- Proposal P77: actor=Hani [P2]; Committed; reason=; event=E408
- Proposal P78: actor=Zami [P3]; Committed; reason=; event=E409
- Proposal P79: actor=Aki [P4]; Committed; reason=; event=E410
- Proposal P80: actor=Tari [P5]; Committed; reason=; event=E411

### Semantic events
- E392 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E393 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E394 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E395 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E396 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E397 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E398 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E399 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E400 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E401 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E402 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E403 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E404 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E405 r13: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E406 r14: Response; participants=[P3]; detail=Accept; fallback=False
- E407 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E408 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:1->2:Gift]
- E409 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:2->1:Gift; P5:1->2:Gift]
- E410 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:2->3:Gift]
- E411 r19: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:2->1:Gift; P3:1->2:Gift]
- E412 r20: AttitudeComposition; participants=[P1,P2]; detail=71->81; fallback=False
- E413 r21: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E414 r22: AttitudeComposition; participants=[P3,P5]; detail=98->100; fallback=False
- E415 r23: AttitudeComposition; participants=[P4,P1]; detail=90->100; fallback=False
- E416 r24: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Luma [P1]; Committed; reason=; event=E430
- Proposal P82: actor=Hani [P2]; Committed; reason=; event=E431
- Proposal P83: actor=Zami [P3]; Committed; reason=; event=E432
- Proposal P84: actor=Aki [P4]; Committed; reason=; event=E433
- Proposal P85: actor=Tari [P5]; Committed; reason=; event=E434

### Semantic events
- E417 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E418 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E419 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E420 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E421 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E422 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E423 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E424 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E425 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E426 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E427 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E428 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E429 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E430 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:1->2:Gift]
- E431 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E432 r15: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:0->1:Gift]
- E433 r16: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:1->2:Gift]
- E434 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E435 r18: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E436 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E437 r20: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=50 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P86: actor=Luma [P1]; Committed; reason=; event=E452
- Proposal P87: actor=Hani [P2]; Committed; reason=; event=E453
- Proposal P88: actor=Zami [P3]; Committed; reason=; event=E454
- Proposal P89: actor=Aki [P4]; Committed; reason=; event=E455
- Proposal P90: actor=Tari [P5]; Committed; reason=; event=E456

### Semantic events
- E438 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E439 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E440 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E441 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E442 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E443 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E444 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E445 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E446 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E447 r9: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E448 r10: Response; participants=[P2]; detail=Accept; fallback=False
- E449 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E450 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E451 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E452 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:0->1:Gift]
- E453 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:0->1:Gift]
- E454 r16: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:5->4:Help; P3:0->1:Help]
- E455 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E456 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:1->2:Gift]
- E457 r19: AttitudeComposition; participants=[P1,P2]; detail=81->91; fallback=False
- E458 r20: AttitudeComposition; participants=[P3,P2]; detail=7->17; fallback=False
- E459 r21: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E460 r22: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P91: actor=Luma [P1]; Committed; reason=; event=E474
- Proposal P92: actor=Hani [P2]; Committed; reason=; event=E475
- Proposal P93: actor=Zami [P3]; Committed; reason=; event=E476
- Proposal P94: actor=Aki [P4]; Committed; reason=; event=E477
- Proposal P95: actor=Tari [P5]; Committed; reason=; event=E478

### Semantic events
- E461 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E462 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E463 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E464 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E465 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E466 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E467 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E468 r7: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E469 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E470 r9: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E471 r10: Response; participants=[P1]; detail=Accept; fallback=False
- E472 r11: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E473 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E474 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E475 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E476 r15: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:2->3:Gift]
- E477 r16: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:4->5:Gift]
- E478 r17: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:3->2:Gift; P3:0->1:Gift]
- E479 r18: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E480 r19: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E481 r20: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=46 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P96: actor=Luma [P1]; Committed; reason=; event=E512
- Proposal P97: actor=Hani [P2]; Committed; reason=; event=E513
- Proposal P98: actor=Zami [P3]; Committed; reason=; event=E514
- Proposal P99: actor=Aki [P4]; Committed; reason=; event=E515
- Proposal P100: actor=Tari [P5]; Committed; reason=; event=E516

### Semantic events
- E482 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E483 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E484 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E485 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E486 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E487 r5: AttitudeDecay; participants=[P1,P2]; detail=91->89; fallback=False
- E488 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E489 r7: AttitudeDecay; participants=[P1,P5]; detail=13->11; fallback=False
- E490 r8: AttitudeDecay; participants=[P2,P1]; detail=25->23; fallback=False
- E491 r9: AttitudeDecay; participants=[P2,P3]; detail=-12->-11; fallback=False
- E492 r10: AttitudeDecay; participants=[P2,P4]; detail=-31->-30; fallback=False
- E493 r11: AttitudeDecay; participants=[P2,P5]; detail=12->10; fallback=False
- E494 r12: AttitudeDecay; participants=[P3,P2]; detail=17->15; fallback=False
- E495 r13: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E496 r14: AttitudeDecay; participants=[P3,P5]; detail=100->98; fallback=False
- E497 r15: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E498 r16: AttitudeDecay; participants=[P4,P2]; detail=-47->-46; fallback=False
- E499 r17: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E500 r18: AttitudeDecay; participants=[P5,P1]; detail=17->15; fallback=False
- E501 r19: AttitudeDecay; participants=[P5,P2]; detail=0->0; fallback=False
- E502 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E503 r21: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E504 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E505 r23: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E506 r24: Response; participants=[P1]; detail=Accept; fallback=False
- E507 r25: Proposal; participants=[P3]; detail=Farm; fallback=False
- E508 r26: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E509 r27: Response; participants=[P1]; detail=Accept; fallback=False
- E510 r28: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E511 r29: Response; participants=[P3]; detail=Accept; fallback=False
- E512 r30: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:2->3:Gift]
- E513 r31: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:3->4:Gift]
- E514 r32: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E515 r33: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:4->5:Gift]
- E516 r34: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:1->0:Gift; P3:4->5:Gift]
- E517 r35: AttitudeComposition; participants=[P1,P2]; detail=89->99; fallback=False
- E518 r36: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E519 r37: AttitudeComposition; participants=[P3,P5]; detail=98->100; fallback=False
- E520 r38: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=46 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Luma [P1]; Committed; reason=; event=E536
- Proposal P102: actor=Hani [P2]; Committed; reason=; event=E537
- Proposal P103: actor=Zami [P3]; Committed; reason=; event=E538
- Proposal P104: actor=Aki [P4]; Committed; reason=; event=E539
- Proposal P105: actor=Tari [P5]; Committed; reason=; event=E540

### Semantic events
- E521 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E522 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E523 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E524 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E525 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E526 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E527 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E528 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E529 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E530 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E531 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E532 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E533 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E534 r13: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E535 r14: Response; participants=[P1]; detail=Accept; fallback=False
- E536 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:4->3:Gift; P4:1->2:Gift]
- E537 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:3->4:Gift]
- E538 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:0->1:Gift]
- E539 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:4->5:Gift]
- E540 r19: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:5->4:Help; P5:1->2:Help]
- E541 r20: AttitudeComposition; participants=[P1,P2]; detail=99->100; fallback=False
- E542 r21: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E543 r22: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E544 r23: AttitudeComposition; participants=[P5,P1]; detail=15->25; fallback=False
- E545 r24: AttitudeComposition; participants=[P5,P3]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P106: actor=Luma [P1]; Committed; reason=; event=E559
- Proposal P107: actor=Hani [P2]; Committed; reason=; event=E560
- Proposal P108: actor=Zami [P3]; Committed; reason=; event=E561
- Proposal P109: actor=Aki [P4]; Committed; reason=; event=E562
- Proposal P110: actor=Tari [P5]; Committed; reason=; event=E563

### Semantic events
- E546 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E547 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E548 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E549 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E550 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E551 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E552 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E553 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E554 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E555 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E556 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E557 r11: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E558 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E559 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:0->1:Gift]
- E560 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E561 r15: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:2->1:Gift; P5:1->2:Gift]
- E562 r16: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E563 r17: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:2->1:Gift; P3:1->2:Gift]
- E564 r18: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E565 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E566 r20: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=46 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P111: actor=Luma [P1]; Committed; reason=; event=E581
- Proposal P112: actor=Hani [P2]; Committed; reason=; event=E582
- Proposal P113: actor=Zami [P3]; Committed; reason=; event=E583
- Proposal P114: actor=Aki [P4]; Committed; reason=; event=E584
- Proposal P115: actor=Tari [P5]; Committed; reason=; event=E585

### Semantic events
- E567 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E568 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E569 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E570 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E571 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E572 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E573 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E574 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E575 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E576 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E577 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E578 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E579 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E580 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E581 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:4->5:Gift]
- E582 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:0->1:Gift]
- E583 r16: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:0->1:Gift]
- E584 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:5->4:Gift; P1:1->2:Gift]
- E585 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E586 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E587 r20: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E588 r21: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E589 r22: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P116: actor=Luma [P1]; Committed; reason=; event=E604
- Proposal P117: actor=Hani [P2]; Committed; reason=; event=E605
- Proposal P118: actor=Zami [P3]; Committed; reason=; event=E606
- Proposal P119: actor=Aki [P4]; Committed; reason=; event=E607
- Proposal P120: actor=Tari [P5]; Committed; reason=; event=E608

### Semantic events
- E590 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E591 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E592 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E593 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E594 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E595 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E596 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E597 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E598 r8: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E599 r9: Response; participants=[P2]; detail=Accept; fallback=False
- E600 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E601 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E602 r12: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E603 r13: Response; participants=[P3]; detail=Accept; fallback=False
- E604 r14: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:3->4:Gift]
- E605 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E606 r16: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:7->6:Help; P3:0->1:Help]
- E607 r17: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:0->1:Gift]
- E608 r18: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:1->2:Gift]
- E609 r19: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E610 r20: AttitudeComposition; participants=[P3,P2]; detail=15->25; fallback=False
- E611 r21: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E612 r22: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=42 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P121: actor=Luma [P1]; Committed; reason=; event=E643
- Proposal P122: actor=Hani [P2]; Committed; reason=; event=E644
- Proposal P123: actor=Zami [P3]; Committed; reason=; event=E645
- Proposal P124: actor=Aki [P4]; Committed; reason=; event=E646
- Proposal P125: actor=Tari [P5]; Committed; reason=; event=E647

### Semantic events
- E613 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E614 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E615 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E616 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E617 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E618 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E619 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E620 r7: AttitudeDecay; participants=[P1,P5]; detail=11->9; fallback=False
- E621 r8: AttitudeDecay; participants=[P2,P1]; detail=23->21; fallback=False
- E622 r9: AttitudeDecay; participants=[P2,P3]; detail=-11->-10; fallback=False
- E623 r10: AttitudeDecay; participants=[P2,P4]; detail=-30->-29; fallback=False
- E624 r11: AttitudeDecay; participants=[P2,P5]; detail=10->8; fallback=False
- E625 r12: AttitudeDecay; participants=[P3,P2]; detail=25->23; fallback=False
- E626 r13: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E627 r14: AttitudeDecay; participants=[P3,P5]; detail=100->98; fallback=False
- E628 r15: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E629 r16: AttitudeDecay; participants=[P4,P2]; detail=-46->-45; fallback=False
- E630 r17: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E631 r18: AttitudeDecay; participants=[P5,P1]; detail=25->23; fallback=False
- E632 r19: AttitudeDecay; participants=[P5,P2]; detail=0->0; fallback=False
- E633 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E634 r21: Proposal; participants=[P1]; detail=Farm; fallback=False
- E635 r22: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E636 r23: Response; participants=[P1]; detail=Accept; fallback=False
- E637 r24: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E638 r25: Response; participants=[P5]; detail=Accept; fallback=False
- E639 r26: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E640 r27: Response; participants=[P1]; detail=Accept; fallback=False
- E641 r28: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E642 r29: Response; participants=[P3]; detail=Accept; fallback=False
- E643 r30: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E644 r31: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:4->5:Gift]
- E645 r32: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:2->3:Gift]
- E646 r33: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:5->6:Gift]
- E647 r34: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:3->2:Gift; P3:0->1:Gift]
- E648 r35: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E649 r36: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E650 r37: AttitudeComposition; participants=[P3,P5]; detail=98->100; fallback=False
- E651 r38: AttitudeComposition; participants=[P5,P3]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=6; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P126: actor=Luma [P1]; Committed; reason=; event=E664
- Proposal P127: actor=Hani [P2]; Committed; reason=; event=E665
- Proposal P128: actor=Zami [P3]; Committed; reason=; event=E666
- Proposal P129: actor=Aki [P4]; Committed; reason=; event=E667
- Proposal P130: actor=Tari [P5]; Committed; reason=; event=E668

### Semantic events
- E652 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E653 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E654 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E655 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E656 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E657 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E658 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E659 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E660 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E661 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E662 r10: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E663 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E664 r12: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:5->4:Gift; P4:0->1:Gift]
- E665 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:3->7:FarmSource]
- E666 r14: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E667 r15: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E668 r16: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:1->0:Gift; P3:4->5:Gift]
- E669 r17: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E670 r18: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=7; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=42 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P131: actor=Luma [P1]; Committed; reason=; event=E686
- Proposal P132: actor=Hani [P2]; Committed; reason=; event=E687
- Proposal P133: actor=Zami [P3]; Committed; reason=; event=E688
- Proposal P134: actor=Aki [P4]; Committed; reason=; event=E689
- Proposal P135: actor=Tari [P5]; Committed; reason=; event=E690

### Semantic events
- E671 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E672 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E673 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E674 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E675 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E676 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E677 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E678 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E679 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E680 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E681 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E682 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E683 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E684 r13: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E685 r14: Response; participants=[P1]; detail=Accept; fallback=False
- E686 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:3->2:Gift; P4:4->5:Gift]
- E687 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:6->5:Gift; P1:2->3:Gift]
- E688 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:4->3:Gift; P5:0->1:Gift]
- E689 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:5->4:Gift; P1:3->4:Gift]
- E690 r19: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:4->3:Help; P5:1->2:Help]
- E691 r20: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E692 r21: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E693 r22: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E694 r23: AttitudeComposition; participants=[P5,P1]; detail=23->33; fallback=False
- E695 r24: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=42 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P136: actor=Luma [P1]; Committed; reason=; event=E711
- Proposal P137: actor=Hani [P2]; Committed; reason=; event=E712
- Proposal P138: actor=Zami [P3]; Committed; reason=; event=E713
- Proposal P139: actor=Aki [P4]; Committed; reason=; event=E714
- Proposal P140: actor=Tari [P5]; Committed; reason=; event=E715

### Semantic events
- E696 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E697 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E698 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E699 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E700 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E701 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E702 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E703 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E704 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E705 r9: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E706 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E707 r11: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E708 r12: Response; participants=[P1]; detail=Accept; fallback=False
- E709 r13: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E710 r14: Response; participants=[P3]; detail=Accept; fallback=False
- E711 r15: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:3->4:Gift]
- E712 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:1->2:Gift]
- E713 r17: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:2->1:Gift; P5:1->2:Gift]
- E714 r18: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:4->3:Gift; P1:2->3:Gift]
- E715 r19: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:2->1:Gift; P3:1->2:Gift]
- E716 r20: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E717 r21: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E718 r22: AttitudeComposition; participants=[P3,P5]; detail=100->100; fallback=False
- E719 r23: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E720 r24: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P141: actor=Luma [P1]; Committed; reason=; event=E734
- Proposal P142: actor=Hani [P2]; Committed; reason=; event=E735
- Proposal P143: actor=Zami [P3]; Committed; reason=; event=E736
- Proposal P144: actor=Aki [P4]; Committed; reason=; event=E737
- Proposal P145: actor=Tari [P5]; Committed; reason=; event=E738

### Semantic events
- E721 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E722 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E723 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E724 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E725 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E726 r5: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E727 r6: Response; participants=[P4]; detail=Accept; fallback=False
- E728 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E729 r8: Proposal; participants=[P3]; detail=OfferGift(5,1); fallback=False
- E730 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E731 r10: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E732 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E733 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E734 r13: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:2->1:Gift; P4:2->3:Gift]
- E735 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:2->6:FarmSource]
- E736 r15: Gift; participants=[P3,P5]; detail=OfferGift(5,1); fallback=False material=[P3:1->0:Gift; P5:0->1:Gift]
- E737 r16: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:3->2:Gift; P1:1->2:Gift]
- E738 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E739 r18: AttitudeComposition; participants=[P1,P4]; detail=100->100; fallback=False
- E740 r19: AttitudeComposition; participants=[P4,P1]; detail=100->100; fallback=False
- E741 r20: AttitudeComposition; participants=[P5,P3]; detail=100->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Luma [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Luma [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Hani [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=38 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Hani [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Zami [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Zami [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aki [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Aki [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P146: actor=Luma [P1]; Committed; reason=; event=E773
- Proposal P147: actor=Hani [P2]; Committed; reason=; event=E774
- Proposal P148: actor=Zami [P3]; Committed; reason=; event=E775
- Proposal P149: actor=Aki [P4]; Committed; reason=; event=E776
- Proposal P150: actor=Tari [P5]; Committed; reason=; event=E777

### Semantic events
- E742 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E743 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E744 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E745 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E746 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E747 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E748 r6: AttitudeDecay; participants=[P1,P4]; detail=100->98; fallback=False
- E749 r7: AttitudeDecay; participants=[P1,P5]; detail=9->7; fallback=False
- E750 r8: AttitudeDecay; participants=[P2,P1]; detail=21->19; fallback=False
- E751 r9: AttitudeDecay; participants=[P2,P3]; detail=-10->-9; fallback=False
- E752 r10: AttitudeDecay; participants=[P2,P4]; detail=-29->-28; fallback=False
- E753 r11: AttitudeDecay; participants=[P2,P5]; detail=8->6; fallback=False
- E754 r12: AttitudeDecay; participants=[P3,P2]; detail=23->21; fallback=False
- E755 r13: AttitudeDecay; participants=[P3,P4]; detail=0->0; fallback=False
- E756 r14: AttitudeDecay; participants=[P3,P5]; detail=100->98; fallback=False
- E757 r15: AttitudeDecay; participants=[P4,P1]; detail=100->98; fallback=False
- E758 r16: AttitudeDecay; participants=[P4,P2]; detail=-45->-44; fallback=False
- E759 r17: AttitudeDecay; participants=[P4,P3]; detail=0->0; fallback=False
- E760 r18: AttitudeDecay; participants=[P5,P1]; detail=33->31; fallback=False
- E761 r19: AttitudeDecay; participants=[P5,P2]; detail=0->0; fallback=False
- E762 r20: AttitudeDecay; participants=[P5,P3]; detail=100->98; fallback=False
- E763 r21: Proposal; participants=[P1]; detail=OfferGift(4,1); fallback=False
- E764 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E765 r23: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E766 r24: Response; participants=[P1]; detail=Accept; fallback=False
- E767 r25: Proposal; participants=[P3]; detail=RequestGiftOrHelp(2,1); fallback=False
- E768 r26: Response; participants=[P2]; detail=Accept; fallback=False
- E769 r27: Proposal; participants=[P4]; detail=OfferGift(1,1); fallback=False
- E770 r28: Response; participants=[P1]; detail=Accept; fallback=False
- E771 r29: Proposal; participants=[P5]; detail=OfferGift(3,1); fallback=False
- E772 r30: Response; participants=[P3]; detail=Accept; fallback=False
- E773 r31: Gift; participants=[P1,P4]; detail=OfferGift(4,1); fallback=False material=[P1:1->0:Gift; P4:1->2:Gift]
- E774 r32: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:0->1:Gift]
- E775 r33: Help; participants=[P2,P3]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P3:0->1:Help]
- E776 r34: Gift; participants=[P4,P1]; detail=OfferGift(1,1); fallback=False material=[P4:2->1:Gift; P1:1->2:Gift]
- E777 r35: Gift; participants=[P5,P3]; detail=OfferGift(3,1); fallback=False material=[P5:4->3:Gift; P3:1->2:Gift]
- E778 r36: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E779 r37: AttitudeComposition; participants=[P1,P4]; detail=98->100; fallback=False
- E780 r38: AttitudeComposition; participants=[P3,P2]; detail=21->31; fallback=False
- E781 r39: AttitudeComposition; participants=[P3,P5]; detail=98->100; fallback=False
- E782 r40: AttitudeComposition; participants=[P4,P1]; detail=98->100; fallback=False

### Stable state
- Luma [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Hani [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Zami [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Aki [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D3
- MaterialDeadlock=False

## Stop

- Horizon:30
