# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Enna: sex=Male; grain=3; NeedsGrain=False; dwelling=D3
- P2 Kima: sex=Female; grain=7; NeedsGrain=False; dwelling=D2
- P3 Nadi: sex=Male; grain=5; NeedsGrain=False; dwelling=D2
- P4 Saba: sex=Female; grain=1; NeedsGrain=False; dwelling=D1
- P5 Tari: sex=Male; grain=5; NeedsGrain=False; dwelling=D2

## Cycle 1

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=86 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=128 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=108 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=56 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Enna [P1]; Committed; reason=; event=E15
- Proposal P2: actor=Kima [P2]; Committed; reason=; event=E16
- Proposal P3: actor=Nadi [P3]; Committed; reason=; event=E17
- Proposal P4: actor=Saba [P4]; Committed; reason=; event=E18
- Proposal P5: actor=Tari [P5]; Committed; reason=; event=E19

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:7->6:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E5 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E6 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E7 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E8 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E9 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E10 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E11 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E12 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E13 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E14 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E15 r14: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:2->1:Gift; P3:4->5:Gift]
- E16 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:6->5:Gift; P5:4->5:Gift]
- E17 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:5->4:Gift; P4:0->1:Gift]
- E18 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E19 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:5->6:Gift]
- E20 r19: AttitudeComposition; participants=[P2,P5]; detail=64->74; fallback=False
- E21 r20: AttitudeComposition; participants=[P3,P1]; detail=-32->-22; fallback=False
- E22 r21: AttitudeComposition; participants=[P4,P3]; detail=1->11; fallback=False
- E23 r22: AttitudeComposition; participants=[P5,P2]; detail=28->38; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=148 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=108 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=76 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P6: actor=Enna [P1]; Committed; reason=; event=E38
- Proposal P7: actor=Kima [P2]; Committed; reason=; event=E39
- Proposal P8: actor=Nadi [P3]; Committed; reason=; event=E40
- Proposal P9: actor=Saba [P4]; Committed; reason=; event=E41
- Proposal P10: actor=Tari [P5]; Committed; reason=; event=E42

### Semantic events
- E24 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E25 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E26 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E27 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E28 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E29 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E30 r6: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E31 r7: Response; participants=[P5]; detail=Accept; fallback=False
- E32 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E33 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E34 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E35 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E36 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E37 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E38 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E39 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:5->4:Gift; P5:3->4:Gift]
- E40 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:4->5:Gift]
- E41 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:4->5:Gift]
- E42 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:4->5:Gift]
- E43 r19: AttitudeComposition; participants=[P2,P5]; detail=74->84; fallback=False
- E44 r20: AttitudeComposition; participants=[P4,P3]; detail=11->21; fallback=False
- E45 r21: AttitudeComposition; participants=[P5,P2]; detail=38->48; fallback=False
- E46 r22: AttitudeComposition; participants=[P5,P4]; detail=-25->-15; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=86 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=168 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=108 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P11: actor=Enna [P1]; Committed; reason=; event=E62
- Proposal P12: actor=Kima [P2]; Committed; reason=; event=E63
- Proposal P13: actor=Nadi [P3]; Committed; reason=; event=E64
- Proposal P14: actor=Saba [P4]; Committed; reason=; event=E65
- Proposal P15: actor=Tari [P5]; Committed; reason=; event=E66

### Semantic events
- E47 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E48 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E49 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E50 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E51 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E52 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E53 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E54 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E55 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E56 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E57 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E58 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E59 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E60 r13: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E61 r14: Response; participants=[P2]; detail=Accept; fallback=False
- E62 r15: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:1->2:Gift]
- E63 r16: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:4->3:Gift; P5:3->4:Gift]
- E64 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:3->4:Gift]
- E65 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:4->5:Gift]
- E66 r19: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:3->4:Gift]
- E67 r20: AttitudeComposition; participants=[P2,P5]; detail=84->94; fallback=False
- E68 r21: AttitudeComposition; participants=[P3,P1]; detail=-22->-12; fallback=False
- E69 r22: AttitudeComposition; participants=[P4,P3]; detail=21->31; fallback=False
- E70 r23: AttitudeComposition; participants=[P5,P2]; detail=48->58; fallback=False
- E71 r24: AttitudeComposition; participants=[P5,P4]; detail=-15->-5; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=86 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=188 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=96 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=116 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P16: actor=Enna [P1]; Committed; reason=; event=E86
- Proposal P17: actor=Kima [P2]; Committed; reason=; event=E87
- Proposal P18: actor=Nadi [P3]; Committed; reason=; event=E88
- Proposal P19: actor=Saba [P4]; Committed; reason=; event=E89
- Proposal P20: actor=Tari [P5]; Committed; reason=; event=E90

### Semantic events
- E72 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E73 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E74 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E75 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E76 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E77 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E78 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E79 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E80 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E81 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E82 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E83 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E84 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E85 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E86 r14: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:0->1:Gift]
- E87 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:3->2:Gift; P5:3->4:Gift]
- E88 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E89 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:4->5:Gift]
- E90 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:2->3:Gift]
- E91 r19: AttitudeComposition; participants=[P2,P5]; detail=94->100; fallback=False
- E92 r20: AttitudeComposition; participants=[P3,P1]; detail=-12->-2; fallback=False
- E93 r21: AttitudeComposition; participants=[P5,P2]; detail=58->68; fallback=False
- E94 r22: AttitudeComposition; participants=[P5,P4]; detail=-5->5; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=104 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=132 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Enna [P1]; Committed; reason=; event=E125
- Proposal P22: actor=Kima [P2]; Committed; reason=; event=E126
- Proposal P23: actor=Nadi [P3]; Committed; reason=; event=E127
- Proposal P24: actor=Saba [P4]; Committed; reason=; event=E128
- Proposal P25: actor=Tari [P5]; Committed; reason=; event=E129

### Semantic events
- E95 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E96 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E97 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E98 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E99 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E100 r5: AttitudeDecay; participants=[P1,P2]; detail=17->15; fallback=False
- E101 r6: AttitudeDecay; participants=[P1,P3]; detail=43->41; fallback=False
- E102 r7: AttitudeDecay; participants=[P1,P4]; detail=12->10; fallback=False
- E103 r8: AttitudeDecay; participants=[P2,P1]; detail=18->16; fallback=False
- E104 r9: AttitudeDecay; participants=[P2,P4]; detail=44->42; fallback=False
- E105 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E106 r11: AttitudeDecay; participants=[P3,P1]; detail=-2->-1; fallback=False
- E107 r12: AttitudeDecay; participants=[P3,P4]; detail=54->52; fallback=False
- E108 r13: AttitudeDecay; participants=[P3,P5]; detail=17->15; fallback=False
- E109 r14: AttitudeDecay; participants=[P4,P1]; detail=33->31; fallback=False
- E110 r15: AttitudeDecay; participants=[P4,P2]; detail=-47->-46; fallback=False
- E111 r16: AttitudeDecay; participants=[P4,P3]; detail=31->29; fallback=False
- E112 r17: AttitudeDecay; participants=[P4,P5]; detail=48->46; fallback=False
- E113 r18: AttitudeDecay; participants=[P5,P2]; detail=68->66; fallback=False
- E114 r19: AttitudeDecay; participants=[P5,P3]; detail=-34->-33; fallback=False
- E115 r20: AttitudeDecay; participants=[P5,P4]; detail=5->3; fallback=False
- E116 r21: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E117 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E118 r23: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E119 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E120 r25: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E121 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E122 r27: Proposal; participants=[P4]; detail=Farm; fallback=False
- E123 r28: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E124 r29: Response; participants=[P2]; detail=Accept; fallback=False
- E125 r30: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:2->1:Help; P1:0->1:Help]
- E126 r31: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:1->0:Gift; P5:3->4:Gift]
- E127 r32: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:0->1:Gift]
- E128 r33: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E129 r34: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:4->3:Gift; P2:0->1:Gift]
- E130 r35: AttitudeComposition; participants=[P1,P2]; detail=15->25; fallback=False
- E131 r36: AttitudeComposition; participants=[P2,P5]; detail=98->100; fallback=False
- E132 r37: AttitudeComposition; participants=[P4,P3]; detail=29->39; fallback=False
- E133 r38: AttitudeComposition; participants=[P5,P2]; detail=66->76; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=104 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=92 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P26: actor=Enna [P1]; Committed; reason=; event=E147
- Proposal P27: actor=Kima [P2]; Committed; reason=; event=E148
- Proposal P28: actor=Nadi [P3]; Committed; reason=; event=E149
- Proposal P29: actor=Saba [P4]; Committed; reason=; event=E150
- Proposal P30: actor=Tari [P5]; Committed; reason=; event=E151

### Semantic events
- E134 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E135 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E136 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E137 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E138 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E139 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E140 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E141 r7: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E142 r8: Response; participants=[P4]; detail=Accept; fallback=False
- E143 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E144 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E145 r11: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E146 r12: Response; participants=[P2]; detail=Accept; fallback=False
- E147 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E148 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E149 r15: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:4->5:Gift]
- E150 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:2->3:Gift]
- E151 r17: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:3->2:Gift; P2:4->5:Gift]
- E152 r18: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E153 r19: AttitudeComposition; participants=[P4,P3]; detail=39->49; fallback=False
- E154 r20: AttitudeComposition; participants=[P5,P4]; detail=3->13; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=152 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P31: actor=Enna [P1]; Committed; reason=; event=E169
- Proposal P32: actor=Kima [P2]; Committed; reason=; event=E170
- Proposal P33: actor=Nadi [P3]; Committed; reason=; event=E171
- Proposal P34: actor=Saba [P4]; Committed; reason=; event=E172
- Proposal P35: actor=Tari [P5]; Committed; reason=; event=E173

### Semantic events
- E155 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E156 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E157 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E158 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E159 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E160 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E161 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E162 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E163 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E164 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E165 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E166 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E167 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E168 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E169 r14: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:0->1:Gift]
- E170 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:4->3:Gift; P5:1->2:Gift]
- E171 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:1->5:FarmSource]
- E172 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:5->6:Gift]
- E173 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:3->4:Gift]
- E174 r19: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E175 r20: AttitudeComposition; participants=[P3,P1]; detail=-1->9; fallback=False
- E176 r21: AttitudeComposition; participants=[P3,P4]; detail=52->62; fallback=False
- E177 r22: AttitudeComposition; participants=[P5,P2]; detail=76->86; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=124 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P36: actor=Enna [P1]; Committed; reason=; event=E192
- Proposal P37: actor=Kima [P2]; Committed; reason=; event=E193
- Proposal P38: actor=Nadi [P3]; Committed; reason=; event=E194
- Proposal P39: actor=Saba [P4]; Committed; reason=; event=E195
- Proposal P40: actor=Tari [P5]; Committed; reason=; event=E196

### Semantic events
- E178 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E179 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E180 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E181 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E182 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E183 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E184 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E185 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E186 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E187 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E188 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E189 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E190 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E191 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E192 r14: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:5->6:Gift]
- E193 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:3->2:Gift; P5:0->1:Gift]
- E194 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:6->5:Gift; P4:1->2:Gift]
- E195 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:5->6:Gift]
- E196 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E197 r19: AttitudeComposition; participants=[P3,P1]; detail=9->19; fallback=False
- E198 r20: AttitudeComposition; participants=[P3,P4]; detail=62->72; fallback=False
- E199 r21: AttitudeComposition; participants=[P4,P3]; detail=49->59; fallback=False
- E200 r22: AttitudeComposition; participants=[P5,P2]; detail=86->96; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=144 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Enna [P1]; Committed; reason=; event=E215
- Proposal P42: actor=Kima [P2]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E216
- Proposal P43: actor=Nadi [P3]; Committed; reason=; event=E217
- Proposal P44: actor=Saba [P4]; Committed; reason=; event=E218
- Proposal P45: actor=Tari [P5]; Committed; reason=; event=E219

### Semantic events
- E201 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E202 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E203 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E204 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E205 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E206 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E207 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E208 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E209 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E210 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E211 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E212 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E213 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E214 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E215 r14: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=True material=[P2:1->0:Help; P1:0->1:Help]
- E216 r15: InvalidatedAtResolution; participants=[P2,P5]; detail=InsufficientAvailableGrain; fallback=True
- E217 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:5->4:Gift; P4:0->1:Gift]
- E218 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E219 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=True material=[P5:4->3:Gift; P2:0->1:Gift]
- E220 r19: AttitudeComposition; participants=[P1,P2]; detail=25->35; fallback=False
- E221 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E222 r21: AttitudeComposition; participants=[P4,P3]; detail=59->69; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=140 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=134 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=188 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P46: actor=Enna [P1]; Committed; reason=; event=E252
- Proposal P47: actor=Kima [P2]; Committed; reason=; event=E253
- Proposal P48: actor=Nadi [P3]; Committed; reason=; event=E254
- Proposal P49: actor=Saba [P4]; Committed; reason=; event=E255
- Proposal P50: actor=Tari [P5]; Committed; reason=; event=E256

### Semantic events
- E223 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E224 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E225 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E226 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E227 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E228 r5: AttitudeDecay; participants=[P1,P2]; detail=35->33; fallback=False
- E229 r6: AttitudeDecay; participants=[P1,P3]; detail=41->39; fallback=False
- E230 r7: AttitudeDecay; participants=[P1,P4]; detail=10->8; fallback=False
- E231 r8: AttitudeDecay; participants=[P2,P1]; detail=16->14; fallback=False
- E232 r9: AttitudeDecay; participants=[P2,P4]; detail=42->40; fallback=False
- E233 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E234 r11: AttitudeDecay; participants=[P3,P1]; detail=19->17; fallback=False
- E235 r12: AttitudeDecay; participants=[P3,P4]; detail=72->70; fallback=False
- E236 r13: AttitudeDecay; participants=[P3,P5]; detail=15->13; fallback=False
- E237 r14: AttitudeDecay; participants=[P4,P1]; detail=31->29; fallback=False
- E238 r15: AttitudeDecay; participants=[P4,P2]; detail=-46->-45; fallback=False
- E239 r16: AttitudeDecay; participants=[P4,P3]; detail=69->67; fallback=False
- E240 r17: AttitudeDecay; participants=[P4,P5]; detail=46->44; fallback=False
- E241 r18: AttitudeDecay; participants=[P5,P2]; detail=96->94; fallback=False
- E242 r19: AttitudeDecay; participants=[P5,P3]; detail=-33->-32; fallback=False
- E243 r20: AttitudeDecay; participants=[P5,P4]; detail=13->11; fallback=False
- E244 r21: Proposal; participants=[P1]; detail=Farm; fallback=False
- E245 r22: Proposal; participants=[P2]; detail=Farm; fallback=False
- E246 r23: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E247 r24: Response; participants=[P4]; detail=Accept; fallback=False
- E248 r25: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E249 r26: Response; participants=[P3]; detail=Accept; fallback=False
- E250 r27: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E251 r28: Response; participants=[P2]; detail=Accept; fallback=False
- E252 r29: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E253 r30: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E254 r31: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:4->5:Gift]
- E255 r32: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:5->4:Gift; P3:2->3:Gift]
- E256 r33: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:4->5:Gift]
- E257 r34: AttitudeComposition; participants=[P2,P5]; detail=98->100; fallback=False
- E258 r35: AttitudeComposition; participants=[P3,P4]; detail=70->80; fallback=False
- E259 r36: AttitudeComposition; participants=[P4,P3]; detail=67->77; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=4; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=78 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=154 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P51: actor=Enna [P1]; Committed; reason=; event=E274
- Proposal P52: actor=Kima [P2]; Committed; reason=; event=E275
- Proposal P53: actor=Nadi [P3]; Committed; reason=; event=E276
- Proposal P54: actor=Saba [P4]; Committed; reason=; event=E277
- Proposal P55: actor=Tari [P5]; Committed; reason=; event=E278

### Semantic events
- E260 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E261 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E262 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E263 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E264 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E265 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E266 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E267 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E268 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E269 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E270 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E271 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E272 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E273 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E274 r14: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:3->2:Gift; P3:2->3:Gift]
- E275 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:4->3:Gift; P5:0->1:Gift]
- E276 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:3->4:Gift]
- E277 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:2->3:Gift]
- E278 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E279 r19: AttitudeComposition; participants=[P3,P1]; detail=17->27; fallback=False
- E280 r20: AttitudeComposition; participants=[P3,P4]; detail=80->90; fallback=False
- E281 r21: AttitudeComposition; participants=[P4,P3]; detail=77->87; fallback=False
- E282 r22: AttitudeComposition; participants=[P5,P2]; detail=94->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=78 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=180 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=174 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P56: actor=Enna [P1]; Committed; reason=; event=E298
- Proposal P57: actor=Kima [P2]; Committed; reason=; event=E299
- Proposal P58: actor=Nadi [P3]; Committed; reason=; event=E300
- Proposal P59: actor=Saba [P4]; Committed; reason=; event=E301
- Proposal P60: actor=Tari [P5]; Committed; reason=; event=E302

### Semantic events
- E283 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E284 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E285 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E286 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E287 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E288 r5: Proposal; participants=[P1]; detail=OfferGift(3,1); fallback=False
- E289 r6: Response; participants=[P3]; detail=Accept; fallback=False
- E290 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E291 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E292 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E293 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E294 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E295 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E296 r13: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E297 r14: Response; participants=[P2]; detail=Accept; fallback=False
- E298 r15: Gift; participants=[P1,P3]; detail=OfferGift(3,1); fallback=False material=[P1:1->0:Gift; P3:2->3:Gift]
- E299 r16: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:2->1:Gift; P5:4->5:Gift]
- E300 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:2->3:Gift]
- E301 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:2->3:Gift]
- E302 r19: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:1->2:Gift]
- E303 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E304 r21: AttitudeComposition; participants=[P3,P1]; detail=27->37; fallback=False
- E305 r22: AttitudeComposition; participants=[P3,P4]; detail=90->100; fallback=False
- E306 r23: AttitudeComposition; participants=[P4,P3]; detail=87->97; fallback=False
- E307 r24: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=194 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Enna [P1]; Committed; reason=; event=E323
- Proposal P62: actor=Kima [P2]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E324
- Proposal P63: actor=Nadi [P3]; Committed; reason=; event=E325
- Proposal P64: actor=Saba [P4]; Committed; reason=; event=E326
- Proposal P65: actor=Tari [P5]; Committed; reason=; event=E327

### Semantic events
- E308 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E309 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E310 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E311 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E312 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E313 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E314 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E315 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E316 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E317 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E318 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E319 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E320 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E321 r13: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E322 r14: Response; participants=[P2]; detail=Accept; fallback=False
- E323 r15: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=True material=[P2:1->0:Help; P1:0->1:Help]
- E324 r16: InvalidatedAtResolution; participants=[P2,P5]; detail=InsufficientAvailableGrain; fallback=True
- E325 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:1->2:Gift]
- E326 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:1->2:Gift]
- E327 r19: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=True material=[P5:3->2:Gift; P2:0->1:Gift]
- E328 r20: AttitudeComposition; participants=[P1,P2]; detail=33->43; fallback=False
- E329 r21: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E330 r22: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E331 r23: AttitudeComposition; participants=[P4,P3]; detail=97->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P66: actor=Enna [P1]; Committed; reason=; event=E344
- Proposal P67: actor=Kima [P2]; Committed; reason=; event=E345
- Proposal P68: actor=Nadi [P3]; Committed; reason=; event=E346
- Proposal P69: actor=Saba [P4]; Committed; reason=; event=E347
- Proposal P70: actor=Tari [P5]; Committed; reason=; event=E348

### Semantic events
- E332 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E333 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E334 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E335 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E336 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E337 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E338 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E339 r7: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E340 r8: Response; participants=[P4]; detail=Accept; fallback=False
- E341 r9: Proposal; participants=[P4]; detail=Farm; fallback=False
- E342 r10: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E343 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E344 r12: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E345 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E346 r14: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:1->0:Gift; P4:0->1:Gift]
- E347 r15: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E348 r16: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:1->0:Gift; P2:4->5:Gift]
- E349 r17: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E350 r18: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=0; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P71: actor=Enna [P1]; Committed; reason=; event=E382
- Proposal P72: actor=Kima [P2]; Committed; reason=; event=E383
- Proposal P73: actor=Nadi [P3]; Committed; reason=; event=E384
- Proposal P74: actor=Saba [P4]; Committed; reason=; event=E385
- Proposal P75: actor=Tari [P5]; Committed; reason=; event=E386

### Semantic events
- E351 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E352 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E353 r2: MissedConsumption; participants=[P3]; detail=NeedsGrain; fallback=False
- E354 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E355 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E356 r5: AttitudeDecay; participants=[P1,P2]; detail=43->41; fallback=False
- E357 r6: AttitudeDecay; participants=[P1,P3]; detail=39->37; fallback=False
- E358 r7: AttitudeDecay; participants=[P1,P4]; detail=8->6; fallback=False
- E359 r8: AttitudeDecay; participants=[P2,P1]; detail=14->12; fallback=False
- E360 r9: AttitudeDecay; participants=[P2,P4]; detail=40->38; fallback=False
- E361 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E362 r11: AttitudeDecay; participants=[P3,P1]; detail=37->35; fallback=False
- E363 r12: AttitudeDecay; participants=[P3,P4]; detail=100->98; fallback=False
- E364 r13: AttitudeDecay; participants=[P3,P5]; detail=13->11; fallback=False
- E365 r14: AttitudeDecay; participants=[P4,P1]; detail=29->27; fallback=False
- E366 r15: AttitudeDecay; participants=[P4,P2]; detail=-45->-44; fallback=False
- E367 r16: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E368 r17: AttitudeDecay; participants=[P4,P5]; detail=44->42; fallback=False
- E369 r18: AttitudeDecay; participants=[P5,P2]; detail=100->98; fallback=False
- E370 r19: AttitudeDecay; participants=[P5,P3]; detail=-32->-31; fallback=False
- E371 r20: AttitudeDecay; participants=[P5,P4]; detail=11->9; fallback=False
- E372 r21: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E373 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E374 r23: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E375 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E376 r25: Proposal; participants=[P3]; detail=RequestGiftOrHelp(1,1); fallback=False
- E377 r26: Response; participants=[P1]; detail=Accept; fallback=False
- E378 r27: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E379 r28: Response; participants=[P3]; detail=Accept; fallback=False
- E380 r29: Proposal; participants=[P5]; detail=RequestGiftOrHelp(2,1); fallback=False
- E381 r30: Response; participants=[P2]; detail=Accept; fallback=False
- E382 r31: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:4->5:Gift]
- E383 r32: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:5->4:Gift; P5:0->1:Gift]
- E384 r33: Help; participants=[P1,P3]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:2->1:Help; P3:0->1:Help]
- E385 r34: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:1->2:Gift]
- E386 r35: Help; participants=[P2,P5]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P5:1->2:Help]
- E387 r36: AttitudeComposition; participants=[P2,P1]; detail=12->22; fallback=False
- E388 r37: AttitudeComposition; participants=[P3,P1]; detail=35->45; fallback=False
- E389 r38: AttitudeComposition; participants=[P3,P4]; detail=98->100; fallback=False
- E390 r39: AttitudeComposition; participants=[P5,P2]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P76: actor=Enna [P1]; Committed; reason=; event=E405
- Proposal P77: actor=Kima [P2]; Committed; reason=; event=E406
- Proposal P78: actor=Nadi [P3]; Committed; reason=; event=E407
- Proposal P79: actor=Saba [P4]; Committed; reason=; event=E408
- Proposal P80: actor=Tari [P5]; Committed; reason=; event=E409

### Semantic events
- E391 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E392 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E393 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E394 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E395 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E396 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E397 r6: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E398 r7: Response; participants=[P5]; detail=Accept; fallback=False
- E399 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E400 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E401 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E402 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E403 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E404 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E405 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E406 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:2->1:Gift; P5:1->2:Gift]
- E407 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:1->0:Gift; P4:2->3:Gift]
- E408 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:0->1:Gift]
- E409 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:1->2:Gift]
- E410 r19: AttitudeComposition; participants=[P2,P5]; detail=98->100; fallback=False
- E411 r20: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E412 r21: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E413 r22: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Enna [P1]; Committed; reason=; event=E427
- Proposal P82: actor=Kima [P2]; Committed; reason=; event=E428
- Proposal P83: actor=Nadi [P3]; Committed; reason=; event=E429
- Proposal P84: actor=Saba [P4]; Committed; reason=; event=E430
- Proposal P85: actor=Tari [P5]; Committed; reason=; event=E431

### Semantic events
- E414 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E415 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E416 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E417 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E418 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E419 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E420 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E421 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E422 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E423 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E424 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E425 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E426 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E427 r13: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:1->2:Gift]
- E428 r14: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:2->1:Gift; P5:0->1:Gift]
- E429 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E430 r16: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:1->0:Gift; P3:4->5:Gift]
- E431 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E432 r18: AttitudeComposition; participants=[P2,P1]; detail=22->32; fallback=False
- E433 r19: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E434 r20: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=0; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=82 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Enna [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P86: actor=Enna [P1]; Committed; reason=; event=E449
- Proposal P87: actor=Kima [P2]; Committed; reason=; event=E450
- Proposal P88: actor=Nadi [P3]; Committed; reason=; event=E451
- Proposal P89: actor=Saba [P4]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E452
- Proposal P90: actor=Tari [P5]; Committed; reason=; event=E453

### Semantic events
- E435 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E436 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E437 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E438 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E439 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E440 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E441 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E442 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E443 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E444 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E445 r10: Proposal; participants=[P4]; detail=RequestGiftOrHelp(1,1); fallback=False
- E446 r11: Response; participants=[P1]; detail=Accept; fallback=False
- E447 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E448 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E449 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=True material=[P1:1->0:Gift; P2:0->1:Gift]
- E450 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E451 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:0->1:Gift]
- E452 r17: InvalidatedAtResolution; participants=[P4,P1]; detail=InsufficientAvailableGrain; fallback=True
- E453 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:4->3:Gift; P2:5->6:Gift]
- E454 r19: AttitudeComposition; participants=[P2,P1]; detail=32->42; fallback=False
- E455 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E456 r21: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P91: actor=Enna [P1]; Committed; reason=; event=E471
- Proposal P92: actor=Kima [P2]; Committed; reason=; event=E472
- Proposal P93: actor=Nadi [P3]; Committed; reason=; event=E473
- Proposal P94: actor=Saba [P4]; Committed; reason=; event=E474
- Proposal P95: actor=Tari [P5]; Committed; reason=; event=E475

### Semantic events
- E457 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E458 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E459 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E460 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E461 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E462 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E463 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E464 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E465 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E466 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E467 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E468 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E469 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E470 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E471 r14: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:5->4:Help; P1:0->1:Help]
- E472 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:4->3:Gift; P5:2->3:Gift]
- E473 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:0->1:Gift]
- E474 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E475 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:3->2:Gift; P2:3->4:Gift]
- E476 r19: AttitudeComposition; participants=[P1,P2]; detail=41->51; fallback=False
- E477 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E478 r21: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E479 r22: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=4; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P96: actor=Enna [P1]; Committed; reason=; event=E509
- Proposal P97: actor=Kima [P2]; Committed; reason=; event=E510
- Proposal P98: actor=Nadi [P3]; Committed; reason=; event=E511
- Proposal P99: actor=Saba [P4]; Committed; reason=; event=E512
- Proposal P100: actor=Tari [P5]; Committed; reason=; event=E513

### Semantic events
- E480 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E481 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E482 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E483 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E484 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E485 r5: AttitudeDecay; participants=[P1,P2]; detail=51->49; fallback=False
- E486 r6: AttitudeDecay; participants=[P1,P3]; detail=37->35; fallback=False
- E487 r7: AttitudeDecay; participants=[P1,P4]; detail=6->4; fallback=False
- E488 r8: AttitudeDecay; participants=[P2,P1]; detail=42->40; fallback=False
- E489 r9: AttitudeDecay; participants=[P2,P4]; detail=38->36; fallback=False
- E490 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E491 r11: AttitudeDecay; participants=[P3,P1]; detail=45->43; fallback=False
- E492 r12: AttitudeDecay; participants=[P3,P4]; detail=100->98; fallback=False
- E493 r13: AttitudeDecay; participants=[P3,P5]; detail=11->9; fallback=False
- E494 r14: AttitudeDecay; participants=[P4,P1]; detail=27->25; fallback=False
- E495 r15: AttitudeDecay; participants=[P4,P2]; detail=-44->-43; fallback=False
- E496 r16: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E497 r17: AttitudeDecay; participants=[P4,P5]; detail=42->40; fallback=False
- E498 r18: AttitudeDecay; participants=[P5,P2]; detail=100->98; fallback=False
- E499 r19: AttitudeDecay; participants=[P5,P3]; detail=-31->-30; fallback=False
- E500 r20: AttitudeDecay; participants=[P5,P4]; detail=9->7; fallback=False
- E501 r21: Proposal; participants=[P1]; detail=Farm; fallback=False
- E502 r22: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E503 r23: Response; participants=[P5]; detail=Accept; fallback=False
- E504 r24: Proposal; participants=[P3]; detail=Farm; fallback=False
- E505 r25: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E506 r26: Response; participants=[P3]; detail=Accept; fallback=False
- E507 r27: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E508 r28: Response; participants=[P2]; detail=Accept; fallback=False
- E509 r29: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E510 r30: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:3->2:Gift; P5:1->2:Gift]
- E511 r31: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E512 r32: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:4->5:Gift]
- E513 r33: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:2->3:Gift]
- E514 r34: AttitudeComposition; participants=[P2,P5]; detail=98->100; fallback=False
- E515 r35: AttitudeComposition; participants=[P3,P4]; detail=98->100; fallback=False
- E516 r36: AttitudeComposition; participants=[P5,P2]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P101: actor=Enna [P1]; Committed; reason=; event=E531
- Proposal P102: actor=Kima [P2]; Committed; reason=; event=E532
- Proposal P103: actor=Nadi [P3]; Committed; reason=; event=E533
- Proposal P104: actor=Saba [P4]; Committed; reason=; event=E534
- Proposal P105: actor=Tari [P5]; Committed; reason=; event=E535

### Semantic events
- E517 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E518 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E519 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E520 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E521 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E522 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E523 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E524 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E525 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E526 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E527 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E528 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E529 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E530 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E531 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:2->3:Gift]
- E532 r15: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:3->2:Gift; P5:0->1:Gift]
- E533 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:2->3:Gift]
- E534 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:3->4:Gift]
- E535 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E536 r19: AttitudeComposition; participants=[P2,P1]; detail=40->50; fallback=False
- E537 r20: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E538 r21: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E539 r22: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=98 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P106: actor=Enna [P1]; Committed; reason=; event=E555
- Proposal P107: actor=Kima [P2]; Committed; reason=; event=E556
- Proposal P108: actor=Nadi [P3]; Committed; reason=; event=E557
- Proposal P109: actor=Saba [P4]; Committed; reason=; event=E558
- Proposal P110: actor=Tari [P5]; Committed; reason=; event=E559

### Semantic events
- E540 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E541 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E542 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E543 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E544 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E545 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E546 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E547 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E548 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E549 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E550 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E551 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E552 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E553 r13: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E554 r14: Response; participants=[P2]; detail=Accept; fallback=False
- E555 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E556 r16: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:2->1:Gift; P5:4->5:Gift]
- E557 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:1->2:Gift]
- E558 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:2->3:Gift]
- E559 r19: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:5->4:Gift; P2:1->2:Gift]
- E560 r20: AttitudeComposition; participants=[P2,P1]; detail=50->60; fallback=False
- E561 r21: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E562 r22: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E563 r23: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E564 r24: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=2; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P111: actor=Enna [P1]; Committed; reason=; event=E579
- Proposal P112: actor=Kima [P2]; InvalidatedAtResolution; reason=InsufficientAvailableGrain; event=E580
- Proposal P113: actor=Nadi [P3]; Committed; reason=; event=E581
- Proposal P114: actor=Saba [P4]; Committed; reason=; event=E582
- Proposal P115: actor=Tari [P5]; Committed; reason=; event=E583

### Semantic events
- E565 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E566 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E567 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E568 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E569 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E570 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E571 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E572 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E573 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E574 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E575 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E576 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E577 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E578 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E579 r14: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=True material=[P2:1->0:Help; P1:0->1:Help]
- E580 r15: InvalidatedAtResolution; participants=[P2,P5]; detail=InsufficientAvailableGrain; fallback=True
- E581 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:0->1:Gift]
- E582 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E583 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=True material=[P5:3->2:Gift; P2:0->1:Gift]
- E584 r19: AttitudeComposition; participants=[P1,P2]; detail=49->59; fallback=False
- E585 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E586 r21: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P116: actor=Enna [P1]; Committed; reason=; event=E599
- Proposal P117: actor=Kima [P2]; Committed; reason=; event=E600
- Proposal P118: actor=Nadi [P3]; Committed; reason=; event=E601
- Proposal P119: actor=Saba [P4]; Committed; reason=; event=E602
- Proposal P120: actor=Tari [P5]; Committed; reason=; event=E603

### Semantic events
- E587 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E588 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E589 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E590 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E591 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E592 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E593 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E594 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E595 r8: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E596 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E597 r10: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E598 r11: Response; participants=[P2]; detail=Accept; fallback=False
- E599 r12: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E600 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E601 r14: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E602 r15: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:4->5:Gift]
- E603 r16: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:1->0:Gift; P2:4->5:Gift]
- E604 r17: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E605 r18: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P121: actor=Enna [P1]; Committed; reason=; event=E637
- Proposal P122: actor=Kima [P2]; Committed; reason=; event=E638
- Proposal P123: actor=Nadi [P3]; Committed; reason=; event=E639
- Proposal P124: actor=Saba [P4]; Committed; reason=; event=E640
- Proposal P125: actor=Tari [P5]; Committed; reason=; event=E641

### Semantic events
- E606 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E607 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E608 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E609 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E610 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E611 r5: AttitudeDecay; participants=[P1,P2]; detail=59->57; fallback=False
- E612 r6: AttitudeDecay; participants=[P1,P3]; detail=35->33; fallback=False
- E613 r7: AttitudeDecay; participants=[P1,P4]; detail=4->2; fallback=False
- E614 r8: AttitudeDecay; participants=[P2,P1]; detail=60->58; fallback=False
- E615 r9: AttitudeDecay; participants=[P2,P4]; detail=36->34; fallback=False
- E616 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E617 r11: AttitudeDecay; participants=[P3,P1]; detail=43->41; fallback=False
- E618 r12: AttitudeDecay; participants=[P3,P4]; detail=100->98; fallback=False
- E619 r13: AttitudeDecay; participants=[P3,P5]; detail=9->7; fallback=False
- E620 r14: AttitudeDecay; participants=[P4,P1]; detail=25->23; fallback=False
- E621 r15: AttitudeDecay; participants=[P4,P2]; detail=-43->-42; fallback=False
- E622 r16: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E623 r17: AttitudeDecay; participants=[P4,P5]; detail=40->38; fallback=False
- E624 r18: AttitudeDecay; participants=[P5,P2]; detail=100->98; fallback=False
- E625 r19: AttitudeDecay; participants=[P5,P3]; detail=-30->-29; fallback=False
- E626 r20: AttitudeDecay; participants=[P5,P4]; detail=7->5; fallback=False
- E627 r21: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E628 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E629 r23: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E630 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E631 r25: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E632 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E633 r27: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E634 r28: Response; participants=[P3]; detail=Accept; fallback=False
- E635 r29: Proposal; participants=[P5]; detail=RequestGiftOrHelp(2,1); fallback=False
- E636 r30: Response; participants=[P2]; detail=Accept; fallback=False
- E637 r31: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:4->5:Gift]
- E638 r32: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:5->4:Gift; P5:0->1:Gift]
- E639 r33: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:2->3:Gift]
- E640 r34: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:3->4:Gift]
- E641 r35: Help; participants=[P2,P5]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P5:1->2:Help]
- E642 r36: AttitudeComposition; participants=[P2,P1]; detail=58->68; fallback=False
- E643 r37: AttitudeComposition; participants=[P3,P4]; detail=98->100; fallback=False
- E644 r38: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E645 r39: AttitudeComposition; participants=[P5,P2]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=114 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P126: actor=Enna [P1]; Committed; reason=; event=E661
- Proposal P127: actor=Kima [P2]; Committed; reason=; event=E662
- Proposal P128: actor=Nadi [P3]; Committed; reason=; event=E663
- Proposal P129: actor=Saba [P4]; Committed; reason=; event=E664
- Proposal P130: actor=Tari [P5]; Committed; reason=; event=E665

### Semantic events
- E646 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E647 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E648 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E649 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E650 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E651 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E652 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E653 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E654 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E655 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E656 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E657 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E658 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E659 r13: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E660 r14: Response; participants=[P2]; detail=Accept; fallback=False
- E661 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:2->3:Gift]
- E662 r16: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:3->2:Gift; P5:1->2:Gift]
- E663 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:1->2:Gift]
- E664 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:2->3:Gift]
- E665 r19: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:2->3:Gift]
- E666 r20: AttitudeComposition; participants=[P2,P1]; detail=68->78; fallback=False
- E667 r21: AttitudeComposition; participants=[P2,P5]; detail=98->100; fallback=False
- E668 r22: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E669 r23: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E670 r24: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=3; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P131: actor=Enna [P1]; Committed; reason=; event=E684
- Proposal P132: actor=Kima [P2]; Committed; reason=; event=E685
- Proposal P133: actor=Nadi [P3]; Committed; reason=; event=E686
- Proposal P134: actor=Saba [P4]; Committed; reason=; event=E687
- Proposal P135: actor=Tari [P5]; Committed; reason=; event=E688

### Semantic events
- E671 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E672 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E673 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E674 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E675 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E676 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E677 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E678 r7: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E679 r8: Response; participants=[P5]; detail=Accept; fallback=False
- E680 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E681 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E682 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E683 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E684 r13: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:2->1:Help; P1:0->1:Help]
- E685 r14: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:1->0:Gift; P5:0->1:Gift]
- E686 r15: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:0->1:Gift]
- E687 r16: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E688 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E689 r18: AttitudeComposition; participants=[P1,P2]; detail=57->67; fallback=False
- E690 r19: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E691 r20: AttitudeComposition; participants=[P5,P2]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=1; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=0; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=5; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Enna [P1] Response/Feasibility: none; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P136: actor=Enna [P1]; Committed; reason=; event=E705
- Proposal P137: actor=Kima [P2]; Unable; reason=InsufficientAvailableGrain; event=E699
- Proposal P138: actor=Nadi [P3]; Committed; reason=; event=E706
- Proposal P139: actor=Saba [P4]; Committed; reason=; event=E707
- Proposal P140: actor=Tari [P5]; Committed; reason=; event=E708

### Semantic events
- E692 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E693 r1: MissedConsumption; participants=[P2]; detail=NeedsGrain; fallback=False
- E694 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E695 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E696 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E697 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E698 r6: Proposal; participants=[P2]; detail=RequestGiftOrHelp(1,1); fallback=False
- E699 r7: Unable; participants=[P2,P1]; detail=InsufficientAvailableGrain; fallback=False
- E700 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E701 r9: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E702 r10: Response; participants=[P3]; detail=Accept; fallback=False
- E703 r11: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E704 r12: Response; participants=[P2]; detail=Accept; fallback=False
- E705 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E706 r14: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E707 r15: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:4->5:Gift]
- E708 r16: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:4->3:Gift; P2:0->1:Gift]
- E709 r17: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E710 r18: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=4; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=1; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=3; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=134 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P141: actor=Enna [P1]; Committed; reason=; event=E725
- Proposal P142: actor=Kima [P2]; Committed; reason=; event=E726
- Proposal P143: actor=Nadi [P3]; Committed; reason=; event=E727
- Proposal P144: actor=Saba [P4]; Committed; reason=; event=E728
- Proposal P145: actor=Tari [P5]; Committed; reason=; event=E729

### Semantic events
- E711 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E712 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E713 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E714 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E715 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E716 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E717 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E718 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E719 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E720 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E721 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E722 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E723 r12: Proposal; participants=[P5]; detail=OfferGift(2,1); fallback=False
- E724 r13: Response; participants=[P2]; detail=Accept; fallback=False
- E725 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:0->1:Gift]
- E726 r15: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E727 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:2->3:Gift]
- E728 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:3->4:Gift]
- E729 r18: Gift; participants=[P5,P2]; detail=OfferGift(2,1); fallback=False material=[P5:2->1:Gift; P2:5->6:Gift]
- E730 r19: AttitudeComposition; participants=[P2,P1]; detail=78->88; fallback=False
- E731 r20: AttitudeComposition; participants=[P2,P5]; detail=100->100; fallback=False
- E732 r21: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E733 r22: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Enna [P1]: grain=2; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=6; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=2; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Enna [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=130 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Kima [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Nadi [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Nadi [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Saba [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=False
- Saba [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Tari [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Tari [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P146: actor=Enna [P1]; Committed; reason=; event=E764
- Proposal P147: actor=Kima [P2]; Committed; reason=; event=E765
- Proposal P148: actor=Nadi [P3]; Committed; reason=; event=E766
- Proposal P149: actor=Saba [P4]; Committed; reason=; event=E767
- Proposal P150: actor=Tari [P5]; Committed; reason=; event=E768

### Semantic events
- E734 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E735 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:6->5:ConsumptionSink]
- E736 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E737 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E738 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E739 r5: AttitudeDecay; participants=[P1,P2]; detail=67->65; fallback=False
- E740 r6: AttitudeDecay; participants=[P1,P3]; detail=33->31; fallback=False
- E741 r7: AttitudeDecay; participants=[P1,P4]; detail=2->0; fallback=False
- E742 r8: AttitudeDecay; participants=[P2,P1]; detail=88->86; fallback=False
- E743 r9: AttitudeDecay; participants=[P2,P4]; detail=34->32; fallback=False
- E744 r10: AttitudeDecay; participants=[P2,P5]; detail=100->98; fallback=False
- E745 r11: AttitudeDecay; participants=[P3,P1]; detail=41->39; fallback=False
- E746 r12: AttitudeDecay; participants=[P3,P4]; detail=100->98; fallback=False
- E747 r13: AttitudeDecay; participants=[P3,P5]; detail=7->5; fallback=False
- E748 r14: AttitudeDecay; participants=[P4,P1]; detail=23->21; fallback=False
- E749 r15: AttitudeDecay; participants=[P4,P2]; detail=-42->-41; fallback=False
- E750 r16: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E751 r17: AttitudeDecay; participants=[P4,P5]; detail=38->36; fallback=False
- E752 r18: AttitudeDecay; participants=[P5,P2]; detail=100->98; fallback=False
- E753 r19: AttitudeDecay; participants=[P5,P3]; detail=-29->-28; fallback=False
- E754 r20: AttitudeDecay; participants=[P5,P4]; detail=5->3; fallback=False
- E755 r21: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E756 r22: Response; participants=[P2]; detail=Accept; fallback=False
- E757 r23: Proposal; participants=[P2]; detail=OfferGift(5,1); fallback=False
- E758 r24: Response; participants=[P5]; detail=Accept; fallback=False
- E759 r25: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E760 r26: Response; participants=[P4]; detail=Accept; fallback=False
- E761 r27: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E762 r28: Response; participants=[P3]; detail=Accept; fallback=False
- E763 r29: Proposal; participants=[P5]; detail=Farm; fallback=False
- E764 r30: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:5->6:Gift]
- E765 r31: Gift; participants=[P2,P5]; detail=OfferGift(5,1); fallback=False material=[P2:6->5:Gift; P5:0->1:Gift]
- E766 r32: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:1->2:Gift]
- E767 r33: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:2->3:Gift]
- E768 r34: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E769 r35: AttitudeComposition; participants=[P2,P1]; detail=86->96; fallback=False
- E770 r36: AttitudeComposition; participants=[P3,P4]; detail=98->100; fallback=False
- E771 r37: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E772 r38: AttitudeComposition; participants=[P5,P2]; detail=98->100; fallback=False

### Stable state
- Enna [P1]: grain=0; NeedsGrain=False; dwelling=D3
- Kima [P2]: grain=5; NeedsGrain=False; dwelling=D2
- Nadi [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Saba [P4]: grain=1; NeedsGrain=False; dwelling=D1
- Tari [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Stop

- Horizon:30
