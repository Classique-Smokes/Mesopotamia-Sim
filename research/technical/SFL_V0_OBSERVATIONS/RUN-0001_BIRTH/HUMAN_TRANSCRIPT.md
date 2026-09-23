# Birth Run 001 — Mechanical Transcript

Generated mechanically from production public simulation surfaces. No interpretation is included.

## Declared initial state
- P1 Aru: sex=Male; grain=6; NeedsGrain=False; dwelling=D1
- P2 Bela: sex=Female; grain=5; NeedsGrain=False; dwelling=D1
- P3 Dagan: sex=Male; grain=4; NeedsGrain=False; dwelling=D2
- P4 Iltani: sex=Female; grain=3; NeedsGrain=False; dwelling=D2
- P5 Samu: sex=Male; grain=2; NeedsGrain=False; dwelling=D2

## Cycle 1

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=105 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=60 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=True
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=80 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P1: actor=Aru [P1]; Committed; reason=; event=E14
- Proposal P2: actor=Bela [P2]; Committed; reason=; event=E15
- Proposal P3: actor=Dagan [P3]; Committed; reason=; event=E16
- Proposal P4: actor=Iltani [P4]; Committed; reason=; event=E17
- Proposal P5: actor=Samu [P5]; Committed; reason=; event=E18

### Semantic events
- E1 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:6->5:ConsumptionSink]
- E2 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E3 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E4 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E5 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E6 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E7 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E8 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E9 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E10 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E11 r10: Proposal; participants=[P4]; detail=Farm; fallback=False
- E12 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E13 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E14 r13: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:5->4:Gift; P2:4->5:Gift]
- E15 r14: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:5->4:Gift; P1:4->5:Gift]
- E16 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:3->7:FarmSource]
- E17 r16: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:2->6:FarmSource]
- E18 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:6->7:Gift]
- E19 r18: AttitudeComposition; participants=[P1,P2]; detail=35->45; fallback=False
- E20 r19: AttitudeComposition; participants=[P2,P1]; detail=20->30; fallback=False
- E21 r20: AttitudeComposition; participants=[P4,P5]; detail=25->35; fallback=False

### Stable state
- Aru [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=7; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=7; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 2

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=135 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=60 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=70 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P6: actor=Aru [P1]; Committed; reason=; event=E37
- Proposal P7: actor=Bela [P2]; Committed; reason=; event=E38
- Proposal P8: actor=Dagan [P3]; Committed; reason=; event=E39
- Proposal P9: actor=Iltani [P4]; Committed; reason=; event=E40
- Proposal P10: actor=Samu [P5]; Committed; reason=; event=E41

### Semantic events
- E22 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E23 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E24 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E25 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:7->6:ConsumptionSink]
- E26 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E27 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E28 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E29 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E30 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E31 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E32 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E33 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E34 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E35 r13: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E36 r14: Response; participants=[P1]; detail=Accept; fallback=False
- E37 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:4->3:Gift; P2:3->4:Gift]
- E38 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:3->4:Gift]
- E39 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:6->5:Gift; P4:6->7:Gift]
- E40 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:7->6:Gift; P5:0->1:Gift]
- E41 r19: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:4->3:Help; P5:1->2:Help]
- E42 r20: AttitudeComposition; participants=[P1,P2]; detail=45->55; fallback=False
- E43 r21: AttitudeComposition; participants=[P2,P1]; detail=30->40; fallback=False
- E44 r22: AttitudeComposition; participants=[P4,P3]; detail=10->20; fallback=False
- E45 r23: AttitudeComposition; participants=[P5,P1]; detail=-20->-10; fallback=False
- E46 r24: AttitudeComposition; participants=[P5,P4]; detail=40->50; fallback=False

### Stable state
- Aru [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 3

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=165 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=120 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=60 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=70 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=100 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P11: actor=Aru [P1]; Committed; reason=; event=E62
- Proposal P12: actor=Bela [P2]; Committed; reason=; event=E63
- Proposal P13: actor=Dagan [P3]; Committed; reason=; event=E64
- Proposal P14: actor=Iltani [P4]; Committed; reason=; event=E65
- Proposal P15: actor=Samu [P5]; Committed; reason=; event=E66

### Semantic events
- E47 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E48 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E49 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E50 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E51 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E52 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E53 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E54 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E55 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E56 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E57 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E58 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E59 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E60 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E61 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E62 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:2->1:Gift; P2:2->3:Gift]
- E63 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E64 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:5->6:Gift]
- E65 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:6->5:Gift; P5:1->2:Gift]
- E66 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:5->6:Gift]
- E67 r20: AttitudeComposition; participants=[P1,P2]; detail=55->65; fallback=False
- E68 r21: AttitudeComposition; participants=[P2,P1]; detail=40->50; fallback=False
- E69 r22: AttitudeComposition; participants=[P4,P3]; detail=20->30; fallback=False
- E70 r23: AttitudeComposition; participants=[P4,P5]; detail=35->45; fallback=False
- E71 r24: AttitudeComposition; participants=[P5,P4]; detail=50->60; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 4

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=195 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=150 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=True
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=90 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P16: actor=Aru [P1]; Committed; reason=; event=E85
- Proposal P17: actor=Bela [P2]; Committed; reason=; event=E86
- Proposal P18: actor=Dagan [P3]; Committed; reason=; event=E87
- Proposal P19: actor=Iltani [P4]; Committed; reason=; event=E88
- Proposal P20: actor=Samu [P5]; Committed; reason=; event=E89

### Semantic events
- E72 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E73 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E74 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E75 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E76 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E77 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E78 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E79 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E80 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E81 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E82 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E83 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E84 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E85 r13: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E86 r14: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:0->1:Gift]
- E87 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E88 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:0->1:Gift]
- E89 r17: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E90 r18: AttitudeComposition; participants=[P1,P2]; detail=65->75; fallback=False
- E91 r19: AttitudeComposition; participants=[P2,P1]; detail=50->60; fallback=False
- E92 r20: AttitudeComposition; participants=[P5,P4]; detail=60->70; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 5

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=56 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=86 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=136 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P21: actor=Aru [P1]; Committed; reason=; event=E116
- Proposal P22: actor=Bela [P2]; Committed; reason=; event=E117
- Proposal P23: actor=Dagan [P3]; Committed; reason=; event=E118
- Proposal P24: actor=Iltani [P4]; Committed; reason=; event=E119
- Proposal P25: actor=Samu [P5]; Committed; reason=; event=E120

### Semantic events
- E93 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E94 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E95 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E96 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E97 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E98 r5: AttitudeDecay; participants=[P1,P2]; detail=75->73; fallback=False
- E99 r6: AttitudeDecay; participants=[P2,P1]; detail=60->58; fallback=False
- E100 r7: AttitudeDecay; participants=[P2,P3]; detail=15->13; fallback=False
- E101 r8: AttitudeDecay; participants=[P3,P2]; detail=-5->-4; fallback=False
- E102 r9: AttitudeDecay; participants=[P3,P4]; detail=30->28; fallback=False
- E103 r10: AttitudeDecay; participants=[P4,P3]; detail=30->28; fallback=False
- E104 r11: AttitudeDecay; participants=[P4,P5]; detail=45->43; fallback=False
- E105 r12: AttitudeDecay; participants=[P5,P4]; detail=70->68; fallback=False
- E106 r13: AttitudeDecay; participants=[P5,P1]; detail=-10->-9; fallback=False
- E107 r14: AttitudeDecay; participants=[P1,P5]; detail=5->3; fallback=False
- E108 r15: Proposal; participants=[P1]; detail=Farm; fallback=False
- E109 r16: Proposal; participants=[P2]; detail=Farm; fallback=False
- E110 r17: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E111 r18: Response; participants=[P4]; detail=Accept; fallback=False
- E112 r19: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E113 r20: Response; participants=[P5]; detail=Accept; fallback=False
- E114 r21: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E115 r22: Response; participants=[P4]; detail=Accept; fallback=False
- E116 r23: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E117 r24: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E118 r25: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:5->4:Gift; P4:3->4:Gift]
- E119 r26: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:4->3:Gift; P5:4->5:Gift]
- E120 r27: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:3->4:Gift]
- E121 r28: AttitudeComposition; participants=[P4,P3]; detail=28->38; fallback=False
- E122 r29: AttitudeComposition; participants=[P4,P5]; detail=43->53; fallback=False
- E123 r30: AttitudeComposition; participants=[P5,P4]; detail=68->78; fallback=False

### Stable state
- Aru [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 6

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=219 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=174 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=106 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=156 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P26: actor=Aru [P1]; Committed; reason=; event=E138
- Proposal P27: actor=Bela [P2]; Committed; reason=; event=E139
- Proposal P28: actor=Dagan [P3]; Committed; reason=; event=E140
- Proposal P29: actor=Iltani [P4]; Committed; reason=; event=E141
- Proposal P30: actor=Samu [P5]; Committed; reason=; event=E142

### Semantic events
- E124 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E125 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E126 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E127 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E128 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E129 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E130 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E131 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E132 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E133 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E134 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E135 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E136 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E137 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E138 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E139 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:2->3:Gift]
- E140 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:3->7:FarmSource]
- E141 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E142 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E143 r19: AttitudeComposition; participants=[P1,P2]; detail=73->83; fallback=False
- E144 r20: AttitudeComposition; participants=[P2,P1]; detail=58->68; fallback=False
- E145 r21: AttitudeComposition; participants=[P4,P5]; detail=53->63; fallback=False
- E146 r22: AttitudeComposition; participants=[P5,P4]; detail=78->88; fallback=False

### Stable state
- Aru [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=7; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 7

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=249 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=204 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=56 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=126 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=176 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P31: actor=Aru [P1]; Committed; reason=; event=E162
- Proposal P32: actor=Bela [P2]; Committed; reason=; event=E163
- Proposal P33: actor=Dagan [P3]; Committed; reason=; event=E164
- Proposal P34: actor=Iltani [P4]; Committed; reason=; event=E165
- Proposal P35: actor=Samu [P5]; Committed; reason=; event=E166

### Semantic events
- E147 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E148 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E149 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E150 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E151 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E152 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E153 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E154 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E155 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E156 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E157 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E158 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E159 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E160 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E161 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E162 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:2->1:Gift; P2:2->3:Gift]
- E163 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E164 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:6->5:Gift; P4:2->3:Gift]
- E165 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:2->3:Gift]
- E166 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:2->3:Gift]
- E167 r20: AttitudeComposition; participants=[P1,P2]; detail=83->93; fallback=False
- E168 r21: AttitudeComposition; participants=[P2,P1]; detail=68->78; fallback=False
- E169 r22: AttitudeComposition; participants=[P4,P3]; detail=38->48; fallback=False
- E170 r23: AttitudeComposition; participants=[P4,P5]; detail=63->73; fallback=False
- E171 r24: AttitudeComposition; participants=[P5,P4]; detail=88->98; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 8

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=279 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=234 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=56 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=146 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P36: actor=Aru [P1]; Committed; reason=; event=E187
- Proposal P37: actor=Bela [P2]; Committed; reason=; event=E188
- Proposal P38: actor=Dagan [P3]; Committed; reason=; event=E189
- Proposal P39: actor=Iltani [P4]; Committed; reason=; event=E190
- Proposal P40: actor=Samu [P5]; Committed; reason=; event=E191

### Semantic events
- E172 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E173 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E174 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E175 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E176 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E177 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E178 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E179 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E180 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E181 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E182 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E183 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E184 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E185 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E186 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E187 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E188 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:0->1:Gift]
- E189 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:2->3:Gift]
- E190 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:1->2:Gift]
- E191 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:2->3:Gift]
- E192 r20: AttitudeComposition; participants=[P1,P2]; detail=93->100; fallback=False
- E193 r21: AttitudeComposition; participants=[P2,P1]; detail=78->88; fallback=False
- E194 r22: AttitudeComposition; participants=[P4,P3]; detail=48->58; fallback=False
- E195 r23: AttitudeComposition; participants=[P4,P5]; detail=73->83; fallback=False
- E196 r24: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 9

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=166 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P41: actor=Aru [P1]; Committed; reason=; event=E208
- Proposal P42: actor=Bela [P2]; Committed; reason=; event=E209
- Proposal P43: actor=Dagan [P3]; Committed; reason=; event=E210
- Proposal P44: actor=Iltani [P4]; Committed; reason=; event=E211
- Proposal P45: actor=Samu [P5]; Committed; reason=; event=E212

### Semantic events
- E197 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E198 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E199 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E200 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E201 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E202 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E203 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E204 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E205 r8: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E206 r9: Response; participants=[P5]; detail=Accept; fallback=False
- E207 r10: Proposal; participants=[P5]; detail=Farm; fallback=False
- E208 r11: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E209 r12: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E210 r13: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E211 r14: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:0->1:Gift]
- E212 r15: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E213 r16: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 10

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=258 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P46: actor=Aru [P1]; Committed; reason=; event=E238
- Proposal P47: actor=Bela [P2]; Committed; reason=; event=E239
- Proposal P48: actor=Dagan [P3]; Committed; reason=; event=E240
- Proposal P49: actor=Iltani [P4]; Committed; reason=; event=E241
- Proposal P50: actor=Samu [P5]; Committed; reason=; event=E242

### Semantic events
- E214 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E215 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E216 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E217 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E218 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E219 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E220 r6: AttitudeDecay; participants=[P2,P1]; detail=88->86; fallback=False
- E221 r7: AttitudeDecay; participants=[P2,P3]; detail=13->11; fallback=False
- E222 r8: AttitudeDecay; participants=[P3,P2]; detail=-4->-3; fallback=False
- E223 r9: AttitudeDecay; participants=[P3,P4]; detail=28->26; fallback=False
- E224 r10: AttitudeDecay; participants=[P4,P3]; detail=58->56; fallback=False
- E225 r11: AttitudeDecay; participants=[P4,P5]; detail=83->81; fallback=False
- E226 r12: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E227 r13: AttitudeDecay; participants=[P5,P1]; detail=-9->-8; fallback=False
- E228 r14: AttitudeDecay; participants=[P1,P5]; detail=3->1; fallback=False
- E229 r15: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E230 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E231 r17: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E232 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E233 r19: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E234 r20: Response; participants=[P4]; detail=Accept; fallback=False
- E235 r21: Proposal; participants=[P4]; detail=Farm; fallback=False
- E236 r22: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E237 r23: Response; participants=[P4]; detail=Accept; fallback=False
- E238 r24: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E239 r25: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:2->3:Gift]
- E240 r26: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:5->4:Gift; P4:0->1:Gift]
- E241 r27: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E242 r28: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:5->6:Gift]
- E243 r29: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E244 r30: AttitudeComposition; participants=[P2,P1]; detail=86->96; fallback=False
- E245 r31: AttitudeComposition; participants=[P4,P3]; detail=56->66; fallback=False
- E246 r32: AttitudeComposition; participants=[P4,P5]; detail=81->91; fallback=False

### Stable state
- Aru [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 11

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=288 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=182 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P51: actor=Aru [P1]; Committed; reason=; event=E261
- Proposal P52: actor=Bela [P2]; Committed; reason=; event=E262
- Proposal P53: actor=Dagan [P3]; Committed; reason=; event=E263
- Proposal P54: actor=Iltani [P4]; Committed; reason=; event=E264
- Proposal P55: actor=Samu [P5]; Committed; reason=; event=E265

### Semantic events
- E247 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E248 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E249 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E250 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E251 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E252 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E253 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E254 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E255 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E256 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E257 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E258 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E259 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E260 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E261 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:2->1:Gift; P2:2->3:Gift]
- E262 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E263 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:3->7:FarmSource]
- E264 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:2->3:Gift]
- E265 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:4->5:Gift]
- E266 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E267 r20: AttitudeComposition; participants=[P2,P1]; detail=96->100; fallback=False
- E268 r21: AttitudeComposition; participants=[P4,P5]; detail=91->100; fallback=False
- E269 r22: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=7; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 12

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P56: actor=Aru [P1]; Committed; reason=; event=E285
- Proposal P57: actor=Bela [P2]; Committed; reason=; event=E286
- Proposal P58: actor=Dagan [P3]; Committed; reason=; event=E287
- Proposal P59: actor=Iltani [P4]; Committed; reason=; event=E288
- Proposal P60: actor=Samu [P5]; Committed; reason=; event=E289

### Semantic events
- E270 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E271 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E272 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E273 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E274 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E275 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E276 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E277 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E278 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E279 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E280 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E281 r11: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E282 r12: Response; participants=[P5]; detail=Accept; fallback=False
- E283 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E284 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E285 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E286 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:0->1:Gift]
- E287 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:6->5:Gift; P4:4->5:Gift]
- E288 r18: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:1->2:Gift]
- E289 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:4->5:Gift]
- E290 r20: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E291 r21: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E292 r22: AttitudeComposition; participants=[P4,P3]; detail=66->76; fallback=False
- E293 r23: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E294 r24: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 13

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=52 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P61: actor=Aru [P1]; Committed; reason=; event=E307
- Proposal P62: actor=Bela [P2]; Committed; reason=; event=E308
- Proposal P63: actor=Dagan [P3]; Committed; reason=; event=E309
- Proposal P64: actor=Iltani [P4]; Committed; reason=; event=E310
- Proposal P65: actor=Samu [P5]; Committed; reason=; event=E311

### Semantic events
- E295 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E296 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E297 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E298 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:5->4:ConsumptionSink]
- E299 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E300 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E301 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E302 r7: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E303 r8: Response; participants=[P4]; detail=Accept; fallback=False
- E304 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E305 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E306 r11: Proposal; participants=[P5]; detail=Farm; fallback=False
- E307 r12: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E308 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E309 r14: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:4->5:Gift]
- E310 r15: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:5->4:Gift; P5:0->1:Gift]
- E311 r16: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:1->5:FarmSource]
- E312 r17: AttitudeComposition; participants=[P4,P3]; detail=76->86; fallback=False
- E313 r18: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=5; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 14

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P66: actor=Aru [P1]; Committed; reason=; event=E328
- Proposal P67: actor=Bela [P2]; Committed; reason=; event=E329
- Proposal P68: actor=Dagan [P3]; Committed; reason=; event=E330
- Proposal P69: actor=Iltani [P4]; Committed; reason=; event=E331
- Proposal P70: actor=Samu [P5]; Committed; reason=; event=E332

### Semantic events
- E314 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E315 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E316 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E317 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E318 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:5->4:ConsumptionSink]
- E319 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E320 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E321 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E322 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E323 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E324 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E325 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E326 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E327 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E328 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E329 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:2->3:Gift]
- E330 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:2->6:FarmSource]
- E331 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:4->5:Gift]
- E332 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:5->4:Gift; P4:2->3:Gift]
- E333 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E334 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E335 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E336 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=6; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 15

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P71: actor=Aru [P1]; Committed; reason=; event=E362
- Proposal P72: actor=Bela [P2]; Committed; reason=; event=E363
- Proposal P73: actor=Dagan [P3]; Committed; reason=; event=E364
- Proposal P74: actor=Iltani [P4]; Committed; reason=; event=E365
- Proposal P75: actor=Samu [P5]; Committed; reason=; event=E366

### Semantic events
- E337 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E338 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E339 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:6->5:ConsumptionSink]
- E340 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E341 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E342 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E343 r6: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E344 r7: AttitudeDecay; participants=[P2,P3]; detail=11->9; fallback=False
- E345 r8: AttitudeDecay; participants=[P3,P2]; detail=-3->-2; fallback=False
- E346 r9: AttitudeDecay; participants=[P3,P4]; detail=26->24; fallback=False
- E347 r10: AttitudeDecay; participants=[P4,P3]; detail=86->84; fallback=False
- E348 r11: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E349 r12: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E350 r13: AttitudeDecay; participants=[P5,P1]; detail=-8->-7; fallback=False
- E351 r14: AttitudeDecay; participants=[P1,P5]; detail=1->0; fallback=False
- E352 r15: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E353 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E354 r17: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E355 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E356 r19: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E357 r20: Response; participants=[P4]; detail=Accept; fallback=False
- E358 r21: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E359 r22: Response; participants=[P5]; detail=Accept; fallback=False
- E360 r23: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E361 r24: Response; participants=[P4]; detail=Accept; fallback=False
- E362 r25: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:2->1:Gift; P2:2->3:Gift]
- E363 r26: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E364 r27: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:5->4:Gift; P4:2->3:Gift]
- E365 r28: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:3->2:Gift; P5:3->4:Gift]
- E366 r29: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:4->3:Gift; P4:2->3:Gift]
- E367 r30: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E368 r31: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E369 r32: AttitudeComposition; participants=[P4,P3]; detail=84->94; fallback=False
- E370 r33: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False
- E371 r34: AttitudeComposition; participants=[P5,P4]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=3; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 16

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P76: actor=Aru [P1]; Committed; reason=; event=E386
- Proposal P77: actor=Bela [P2]; Committed; reason=; event=E387
- Proposal P78: actor=Dagan [P3]; Committed; reason=; event=E388
- Proposal P79: actor=Iltani [P4]; Committed; reason=; event=E389
- Proposal P80: actor=Samu [P5]; Committed; reason=; event=E390

### Semantic events
- E372 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E373 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E374 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E375 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E376 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:3->2:ConsumptionSink]
- E377 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E378 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E379 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E380 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E381 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E382 r10: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E383 r11: Response; participants=[P5]; detail=Accept; fallback=False
- E384 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E385 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E386 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E387 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:0->1:Gift]
- E388 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:3->7:FarmSource]
- E389 r17: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:2->3:Gift]
- E390 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:1->2:Gift]
- E391 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E392 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E393 r21: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E394 r22: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=7; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 17

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 5 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Samu [P5] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False

### Outcomes
- Proposal P81: actor=Aru [P1]; Committed; reason=; event=E408
- Proposal P82: actor=Bela [P2]; Committed; reason=; event=E409
- Proposal P83: actor=Dagan [P3]; Committed; reason=; event=E410
- Proposal P84: actor=Iltani [P4]; Committed; reason=; event=E411
- Proposal P85: actor=Samu [P5]; Committed; reason=; event=E412

### Semantic events
- E395 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E396 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E397 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:7->6:ConsumptionSink]
- E398 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E399 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E400 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E401 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E402 r7: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E403 r8: Response; participants=[P4]; detail=Accept; fallback=False
- E404 r9: Proposal; participants=[P4]; detail=OfferGift(5,1); fallback=False
- E405 r10: Response; participants=[P5]; detail=Accept; fallback=False
- E406 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E407 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E408 r13: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E409 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E410 r15: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:6->5:Gift; P4:1->2:Gift]
- E411 r16: Gift; participants=[P4,P5]; detail=OfferGift(5,1); fallback=False material=[P4:2->1:Gift; P5:1->2:Gift]
- E412 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:2->1:Gift; P4:1->2:Gift]
- E413 r18: AttitudeComposition; participants=[P4,P3]; detail=94->100; fallback=False
- E414 r19: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False
- E415 r20: AttitudeComposition; participants=[P5,P4]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 18

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=48 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P86: actor=Aru [P1]; Committed; reason=; event=E430
- Proposal P87: actor=Bela [P2]; Committed; reason=; event=E431
- Proposal P88: actor=Dagan [P3]; Committed; reason=; event=E432
- Proposal P89: actor=Iltani [P4]; Committed; reason=; event=E433
- Proposal P90: actor=Samu [P5]; Committed; reason=; event=E434

### Semantic events
- E416 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E417 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E418 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E419 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E420 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E421 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E422 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E423 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E424 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E425 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E426 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E427 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E428 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E429 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E430 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E431 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:2->3:Gift]
- E432 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:1->2:Gift]
- E433 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:3->4:Gift]
- E434 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:0->4:FarmSource]
- E435 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E436 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E437 r21: AttitudeComposition; participants=[P3,P4]; detail=24->34; fallback=False
- E438 r22: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=3; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 19

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=68 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P91: actor=Aru [P1]; Committed; reason=; event=E453
- Proposal P92: actor=Bela [P2]; Committed; reason=; event=E454
- Proposal P93: actor=Dagan [P3]; Committed; reason=; event=E455
- Proposal P94: actor=Iltani [P4]; Committed; reason=; event=E456
- Proposal P95: actor=Samu [P5]; Committed; reason=; event=E457

### Semantic events
- E439 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:3->2:ConsumptionSink]
- E440 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E441 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E442 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E443 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E444 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E445 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E446 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E447 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E448 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E449 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E450 r11: Proposal; participants=[P4]; detail=Farm; fallback=False
- E451 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E452 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E453 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:2->1:Gift; P2:2->3:Gift]
- E454 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E455 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:0->1:Gift]
- E456 r17: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E457 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:5->6:Gift]
- E458 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E459 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E460 r21: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E461 r22: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 20

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=64 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P96: actor=Aru [P1]; Committed; reason=; event=E487
- Proposal P97: actor=Bela [P2]; Committed; reason=; event=E488
- Proposal P98: actor=Dagan [P3]; Committed; reason=; event=E489
- Proposal P99: actor=Iltani [P4]; Committed; reason=; event=E490
- Proposal P100: actor=Samu [P5]; Committed; reason=; event=E491

### Semantic events
- E462 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E463 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E464 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E465 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E466 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E467 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E468 r6: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E469 r7: AttitudeDecay; participants=[P2,P3]; detail=9->7; fallback=False
- E470 r8: AttitudeDecay; participants=[P3,P2]; detail=-2->-1; fallback=False
- E471 r9: AttitudeDecay; participants=[P3,P4]; detail=34->32; fallback=False
- E472 r10: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E473 r11: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E474 r12: AttitudeDecay; participants=[P5,P4]; detail=100->98; fallback=False
- E475 r13: AttitudeDecay; participants=[P5,P1]; detail=-7->-6; fallback=False
- E476 r14: AttitudeDecay; participants=[P1,P5]; detail=0->0; fallback=False
- E477 r15: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E478 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E479 r17: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E480 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E481 r19: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E482 r20: Response; participants=[P4]; detail=Accept; fallback=False
- E483 r21: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E484 r22: Response; participants=[P3]; detail=Accept; fallback=False
- E485 r23: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E486 r24: Response; participants=[P4]; detail=Accept; fallback=False
- E487 r25: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:1->2:Gift]
- E488 r26: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:0->1:Gift]
- E489 r27: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:1->0:Gift; P4:5->6:Gift]
- E490 r28: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:6->5:Gift; P3:0->1:Gift]
- E491 r29: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:5->6:Gift]
- E492 r30: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E493 r31: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E494 r32: AttitudeComposition; participants=[P3,P4]; detail=32->42; fallback=False
- E495 r33: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E496 r34: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=6; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 21

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aru [P1] Response/Feasibility: none; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P101: actor=Aru [P1]; Committed; reason=; event=E509
- Proposal P102: actor=Bela [P2]; Committed; reason=; event=E510
- Proposal P103: actor=Dagan [P3]; Committed; reason=; event=E511
- Proposal P104: actor=Iltani [P4]; Committed; reason=; event=E512
- Proposal P105: actor=Samu [P5]; Unable; reason=InsufficientAvailableGrain; event=E508

### Semantic events
- E497 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E498 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E499 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E500 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:6->5:ConsumptionSink]
- E501 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E502 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E503 r6: Proposal; participants=[P2]; detail=Farm; fallback=False
- E504 r7: Proposal; participants=[P3]; detail=Farm; fallback=False
- E505 r8: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E506 r9: Response; participants=[P3]; detail=Accept; fallback=False
- E507 r10: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E508 r11: Unable; participants=[P5,P1]; detail=InsufficientAvailableGrain; fallback=False
- E509 r12: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E510 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E511 r14: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E512 r15: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:5->4:Gift; P3:4->5:Gift]
- E513 r16: AttitudeComposition; participants=[P3,P4]; detail=42->52; fallback=False

### Stable state
- Aru [P1]: grain=4; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=4; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=True; dwelling=D2
- MaterialDeadlock=False

## Cycle 22

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=104 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P106: actor=Aru [P1]; Committed; reason=; event=E529
- Proposal P107: actor=Bela [P2]; Committed; reason=; event=E530
- Proposal P108: actor=Dagan [P3]; Committed; reason=; event=E531
- Proposal P109: actor=Iltani [P4]; Committed; reason=; event=E532
- Proposal P110: actor=Samu [P5]; Committed; reason=; event=E533

### Semantic events
- E514 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:4->3:ConsumptionSink]
- E515 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E516 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E517 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:4->3:ConsumptionSink]
- E518 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E519 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E520 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E521 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E522 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E523 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E524 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E525 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E526 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E527 r13: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E528 r14: Response; participants=[P1]; detail=Accept; fallback=False
- E529 r15: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:3->2:Gift; P2:3->4:Gift]
- E530 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:4->3:Gift; P1:2->3:Gift]
- E531 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:3->4:Gift]
- E532 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:4->3:Gift; P3:3->4:Gift]
- E533 r19: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:3->2:Help; P5:0->1:Help]
- E534 r20: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E535 r21: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E536 r22: AttitudeComposition; participants=[P3,P4]; detail=52->62; fallback=False
- E537 r23: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E538 r24: AttitudeComposition; participants=[P5,P1]; detail=-6->4; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=3; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=4; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=3; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 23

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=124 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P111: actor=Aru [P1]; Committed; reason=; event=E553
- Proposal P112: actor=Bela [P2]; Committed; reason=; event=E554
- Proposal P113: actor=Dagan [P3]; Committed; reason=; event=E555
- Proposal P114: actor=Iltani [P4]; Committed; reason=; event=E556
- Proposal P115: actor=Samu [P5]; Committed; reason=; event=E557

### Semantic events
- E539 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E540 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:3->2:ConsumptionSink]
- E541 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:4->3:ConsumptionSink]
- E542 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:3->2:ConsumptionSink]
- E543 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E544 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E545 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E546 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E547 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E548 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E549 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E550 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E551 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E552 r13: Proposal; participants=[P5]; detail=Farm; fallback=False
- E553 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:2->3:Gift]
- E554 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:0->1:Gift]
- E555 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:3->2:Gift; P4:2->3:Gift]
- E556 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:3->2:Gift; P3:2->3:Gift]
- E557 r18: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:0->4:FarmSource]
- E558 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E559 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E560 r21: AttitudeComposition; participants=[P3,P4]; detail=62->72; fallback=False
- E561 r22: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=1; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 24

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=144 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P116: actor=Aru [P1]; Committed; reason=; event=E576
- Proposal P117: actor=Bela [P2]; Committed; reason=; event=E577
- Proposal P118: actor=Dagan [P3]; Committed; reason=; event=E578
- Proposal P119: actor=Iltani [P4]; Committed; reason=; event=E579
- Proposal P120: actor=Samu [P5]; Committed; reason=; event=E580

### Semantic events
- E562 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:1->0:ConsumptionSink]
- E563 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E564 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:3->2:ConsumptionSink]
- E565 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E566 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E567 r5: Proposal; participants=[P1]; detail=Farm; fallback=False
- E568 r6: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E569 r7: Response; participants=[P1]; detail=Accept; fallback=False
- E570 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E571 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E572 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E573 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E574 r12: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E575 r13: Response; participants=[P4]; detail=Accept; fallback=False
- E576 r14: Farm; participants=[P1]; detail=Farm; fallback=False material=[P1:0->4:FarmSource]
- E577 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:1->0:Gift; P1:4->5:Gift]
- E578 r16: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:2->1:Gift; P4:1->2:Gift]
- E579 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:1->2:Gift]
- E580 r18: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:1->2:Gift]
- E581 r19: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E582 r20: AttitudeComposition; participants=[P3,P4]; detail=72->82; fallback=False
- E583 r21: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E584 r22: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=5; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=0; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 25

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=160 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P121: actor=Aru [P1]; Committed; reason=; event=E610
- Proposal P122: actor=Bela [P2]; Committed; reason=; event=E611
- Proposal P123: actor=Dagan [P3]; Committed; reason=; event=E612
- Proposal P124: actor=Iltani [P4]; Committed; reason=; event=E613
- Proposal P125: actor=Samu [P5]; Committed; reason=; event=E614

### Semantic events
- E585 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:5->4:ConsumptionSink]
- E586 r1: MissedConsumption; participants=[P2]; detail=NeedsGrain; fallback=False
- E587 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E588 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E589 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E590 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E591 r6: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E592 r7: AttitudeDecay; participants=[P2,P3]; detail=7->5; fallback=False
- E593 r8: AttitudeDecay; participants=[P3,P2]; detail=-1->0; fallback=False
- E594 r9: AttitudeDecay; participants=[P3,P4]; detail=82->80; fallback=False
- E595 r10: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E596 r11: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E597 r12: AttitudeDecay; participants=[P5,P4]; detail=98->96; fallback=False
- E598 r13: AttitudeDecay; participants=[P5,P1]; detail=4->2; fallback=False
- E599 r14: AttitudeDecay; participants=[P1,P5]; detail=0->0; fallback=False
- E600 r15: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E601 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E602 r17: Proposal; participants=[P2]; detail=RequestGiftOrHelp(1,1); fallback=False
- E603 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E604 r19: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E605 r20: Response; participants=[P4]; detail=Accept; fallback=False
- E606 r21: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E607 r22: Response; participants=[P3]; detail=Accept; fallback=False
- E608 r23: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E609 r24: Response; participants=[P4]; detail=Accept; fallback=False
- E610 r25: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:4->3:Gift; P2:0->1:Gift]
- E611 r26: Help; participants=[P1,P2]; detail=RequestGiftOrHelp(1,1); fallback=False material=[P1:3->2:Help; P2:1->2:Help]
- E612 r27: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:1->0:Gift; P4:1->2:Gift]
- E613 r28: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:0->1:Gift]
- E614 r29: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:1->2:Gift]
- E615 r30: AttitudeComposition; participants=[P2,P1]; detail=98->100; fallback=False
- E616 r31: AttitudeComposition; participants=[P3,P4]; detail=80->90; fallback=False
- E617 r32: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False
- E618 r33: AttitudeComposition; participants=[P4,P5]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 26

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P126: actor=Aru [P1]; Committed; reason=; event=E633
- Proposal P127: actor=Bela [P2]; Committed; reason=; event=E634
- Proposal P128: actor=Dagan [P3]; Committed; reason=; event=E635
- Proposal P129: actor=Iltani [P4]; Committed; reason=; event=E636
- Proposal P130: actor=Samu [P5]; Committed; reason=; event=E637

### Semantic events
- E619 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E620 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:2->1:ConsumptionSink]
- E621 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E622 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E623 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E624 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E625 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E626 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E627 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E628 r9: Proposal; participants=[P3]; detail=Farm; fallback=False
- E629 r10: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E630 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E631 r12: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E632 r13: Response; participants=[P1]; detail=Accept; fallback=False
- E633 r14: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=True material=[P1:1->0:Gift; P2:1->2:Gift]
- E634 r15: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=True material=[P2:2->1:Gift; P1:0->1:Gift]
- E635 r16: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E636 r17: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:1->0:Gift; P3:4->5:Gift]
- E637 r18: Help; participants=[P1,P5]; detail=RequestGiftOrHelp(1,1); fallback=True material=[P1:1->0:Help; P5:0->1:Help]
- E638 r19: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E639 r20: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E640 r21: AttitudeComposition; participants=[P3,P4]; detail=90->100; fallback=False
- E641 r22: AttitudeComposition; participants=[P5,P1]; detail=2->12; fallback=False

### Stable state
- Aru [P1]: grain=0; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=0; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=1; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 27

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Response/Feasibility: none; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False

### Outcomes
- Proposal P131: actor=Aru [P1]; Unable; reason=InsufficientAvailableGrain; event=E648
- Proposal P132: actor=Bela [P2]; Committed; reason=; event=E655
- Proposal P133: actor=Dagan [P3]; Committed; reason=; event=E656
- Proposal P134: actor=Iltani [P4]; Committed; reason=; event=E657
- Proposal P135: actor=Samu [P5]; Committed; reason=; event=E658

### Semantic events
- E642 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E643 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E644 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E645 r3: MissedConsumption; participants=[P4]; detail=NeedsGrain; fallback=False
- E646 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:1->0:ConsumptionSink]
- E647 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E648 r6: Unable; participants=[P1,P2]; detail=InsufficientAvailableGrain; fallback=False
- E649 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E650 r8: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E651 r9: Response; participants=[P4]; detail=Accept; fallback=False
- E652 r10: Proposal; participants=[P4]; detail=RequestGiftOrHelp(3,1); fallback=False
- E653 r11: Response; participants=[P3]; detail=Accept; fallback=False
- E654 r12: Proposal; participants=[P5]; detail=Farm; fallback=False
- E655 r13: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:0->4:FarmSource]
- E656 r14: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:0->1:Gift]
- E657 r15: Help; participants=[P3,P4]; detail=RequestGiftOrHelp(3,1); fallback=False material=[P3:3->2:Help; P4:1->2:Help]
- E658 r16: Farm; participants=[P5]; detail=Farm; fallback=False material=[P5:0->4:FarmSource]
- E659 r17: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=0; NeedsGrain=True; dwelling=D1
- Bela [P2]: grain=4; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=2; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=4; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 28

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P136: actor=Aru [P1]; Committed; reason=; event=E675
- Proposal P137: actor=Bela [P2]; Committed; reason=; event=E676
- Proposal P138: actor=Dagan [P3]; Committed; reason=; event=E677
- Proposal P139: actor=Iltani [P4]; Committed; reason=; event=E678
- Proposal P140: actor=Samu [P5]; Committed; reason=; event=E679

### Semantic events
- E660 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E661 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:4->3:ConsumptionSink]
- E662 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:2->1:ConsumptionSink]
- E663 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E664 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:4->3:ConsumptionSink]
- E665 r5: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E666 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E667 r7: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E668 r8: Response; participants=[P1]; detail=Accept; fallback=False
- E669 r9: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E670 r10: Response; participants=[P4]; detail=Accept; fallback=False
- E671 r11: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E672 r12: Response; participants=[P3]; detail=Accept; fallback=False
- E673 r13: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E674 r14: Response; participants=[P4]; detail=Accept; fallback=False
- E675 r15: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:3->2:Help; P1:0->1:Help]
- E676 r16: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:2->1:Gift; P1:1->2:Gift]
- E677 r17: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:1->0:Gift; P4:1->2:Gift]
- E678 r18: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:2->1:Gift; P3:0->1:Gift]
- E679 r19: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:3->2:Gift; P4:1->2:Gift]
- E680 r20: AttitudeComposition; participants=[P1,P2]; detail=100->100; fallback=False
- E681 r21: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E682 r22: AttitudeComposition; participants=[P4,P3]; detail=100->100; fallback=False
- E683 r23: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=1; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=1; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=2; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=2; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 29

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=300 terms=OfferGift { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Dagan [P3] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=200 terms=OfferGift { Target = PersonId { Value = 3 }, Amount = 1 }; TechnicalFallback=True
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=192 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False

### Outcomes
- Proposal P141: actor=Aru [P1]; Committed; reason=; event=E697
- Proposal P142: actor=Bela [P2]; Committed; reason=; event=E698
- Proposal P143: actor=Dagan [P3]; Committed; reason=; event=E699
- Proposal P144: actor=Iltani [P4]; Committed; reason=; event=E700
- Proposal P145: actor=Samu [P5]; Committed; reason=; event=E701

### Semantic events
- E684 r0: Consumption; participants=[P1]; detail=Paid; fallback=False material=[P1:2->1:ConsumptionSink]
- E685 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:1->0:ConsumptionSink]
- E686 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:1->0:ConsumptionSink]
- E687 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:2->1:ConsumptionSink]
- E688 r4: Consumption; participants=[P5]; detail=Paid; fallback=False material=[P5:2->1:ConsumptionSink]
- E689 r5: Proposal; participants=[P1]; detail=OfferGift(2,1); fallback=False
- E690 r6: Response; participants=[P2]; detail=Accept; fallback=False
- E691 r7: Proposal; participants=[P2]; detail=Farm; fallback=False
- E692 r8: Proposal; participants=[P3]; detail=Farm; fallback=False
- E693 r9: Proposal; participants=[P4]; detail=OfferGift(3,1); fallback=False
- E694 r10: Response; participants=[P3]; detail=Accept; fallback=False
- E695 r11: Proposal; participants=[P5]; detail=OfferGift(4,1); fallback=False
- E696 r12: Response; participants=[P4]; detail=Accept; fallback=False
- E697 r13: Gift; participants=[P1,P2]; detail=OfferGift(2,1); fallback=False material=[P1:1->0:Gift; P2:0->1:Gift]
- E698 r14: Farm; participants=[P2]; detail=Farm; fallback=False material=[P2:1->5:FarmSource]
- E699 r15: Farm; participants=[P3]; detail=Farm; fallback=False material=[P3:0->4:FarmSource]
- E700 r16: Gift; participants=[P4,P3]; detail=OfferGift(3,1); fallback=False material=[P4:1->0:Gift; P3:4->5:Gift]
- E701 r17: Gift; participants=[P5,P4]; detail=OfferGift(4,1); fallback=False material=[P5:1->0:Gift; P4:0->1:Gift]
- E702 r18: AttitudeComposition; participants=[P2,P1]; detail=100->100; fallback=False
- E703 r19: AttitudeComposition; participants=[P3,P4]; detail=100->100; fallback=False
- E704 r20: AttitudeComposition; participants=[P4,P5]; detail=100->100; fallback=False

### Stable state
- Aru [P1]: grain=0; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=5; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=5; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=1; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=False; dwelling=D2
- MaterialDeadlock=False

## Cycle 30

### Decisions
- Aru [P1] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 2 }, Amount = 1 }; TechnicalFallback=True
- Aru [P1] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Aru [P1] Response/Feasibility: none; TechnicalFallback=False
- Bela [P2] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=294 terms=OfferGift { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=False
- Bela [P2] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Dagan [P3] Personal/SFL-PERSONAL-REFERENCE-v1: OfferGift score=196 terms=OfferGift { Target = PersonId { Value = 4 }, Amount = 1 }; TechnicalFallback=False
- Iltani [P4] Personal/SFL-PERSONAL-REFERENCE-v1: Farm score=60 terms=Farm { }; TechnicalFallback=False
- Iltani [P4] Response/SCORE-RP-001: Accept score=100 terms=; TechnicalFallback=False
- Samu [P5] Personal/SFL-PERSONAL-REFERENCE-v1: RequestGiftOrHelp score=100 terms=RequestGiftOrHelp { Target = PersonId { Value = 1 }, Amount = 1 }; TechnicalFallback=True

### Outcomes
- Proposal P146: actor=Aru [P1]; Committed; reason=; event=E729
- Proposal P147: actor=Bela [P2]; Committed; reason=; event=E730
- Proposal P148: actor=Dagan [P3]; Committed; reason=; event=E731
- Proposal P149: actor=Iltani [P4]; Committed; reason=; event=E732
- Proposal P150: actor=Samu [P5]; Unable; reason=InsufficientAvailableGrain; event=E728

### Semantic events
- E705 r0: MissedConsumption; participants=[P1]; detail=NeedsGrain; fallback=False
- E706 r1: Consumption; participants=[P2]; detail=Paid; fallback=False material=[P2:5->4:ConsumptionSink]
- E707 r2: Consumption; participants=[P3]; detail=Paid; fallback=False material=[P3:5->4:ConsumptionSink]
- E708 r3: Consumption; participants=[P4]; detail=Paid; fallback=False material=[P4:1->0:ConsumptionSink]
- E709 r4: MissedConsumption; participants=[P5]; detail=NeedsGrain; fallback=False
- E710 r5: AttitudeDecay; participants=[P1,P2]; detail=100->98; fallback=False
- E711 r6: AttitudeDecay; participants=[P2,P1]; detail=100->98; fallback=False
- E712 r7: AttitudeDecay; participants=[P2,P3]; detail=5->3; fallback=False
- E713 r8: AttitudeDecay; participants=[P3,P2]; detail=0->0; fallback=False
- E714 r9: AttitudeDecay; participants=[P3,P4]; detail=100->98; fallback=False
- E715 r10: AttitudeDecay; participants=[P4,P3]; detail=100->98; fallback=False
- E716 r11: AttitudeDecay; participants=[P4,P5]; detail=100->98; fallback=False
- E717 r12: AttitudeDecay; participants=[P5,P4]; detail=96->94; fallback=False
- E718 r13: AttitudeDecay; participants=[P5,P1]; detail=12->10; fallback=False
- E719 r14: AttitudeDecay; participants=[P1,P5]; detail=0->0; fallback=False
- E720 r15: Proposal; participants=[P1]; detail=RequestGiftOrHelp(2,1); fallback=False
- E721 r16: Response; participants=[P2]; detail=Accept; fallback=False
- E722 r17: Proposal; participants=[P2]; detail=OfferGift(1,1); fallback=False
- E723 r18: Response; participants=[P1]; detail=Accept; fallback=False
- E724 r19: Proposal; participants=[P3]; detail=OfferGift(4,1); fallback=False
- E725 r20: Response; participants=[P4]; detail=Accept; fallback=False
- E726 r21: Proposal; participants=[P4]; detail=Farm; fallback=False
- E727 r22: Proposal; participants=[P5]; detail=RequestGiftOrHelp(1,1); fallback=False
- E728 r23: Unable; participants=[P5,P1]; detail=InsufficientAvailableGrain; fallback=False
- E729 r24: Help; participants=[P2,P1]; detail=RequestGiftOrHelp(2,1); fallback=False material=[P2:4->3:Help; P1:0->1:Help]
- E730 r25: Gift; participants=[P2,P1]; detail=OfferGift(1,1); fallback=False material=[P2:3->2:Gift; P1:1->2:Gift]
- E731 r26: Gift; participants=[P3,P4]; detail=OfferGift(4,1); fallback=False material=[P3:4->3:Gift; P4:0->1:Gift]
- E732 r27: Farm; participants=[P4]; detail=Farm; fallback=False material=[P4:1->5:FarmSource]
- E733 r28: AttitudeComposition; participants=[P1,P2]; detail=98->100; fallback=False
- E734 r29: AttitudeComposition; participants=[P4,P3]; detail=98->100; fallback=False

### Stable state
- Aru [P1]: grain=2; NeedsGrain=False; dwelling=D1
- Bela [P2]: grain=2; NeedsGrain=False; dwelling=D1
- Dagan [P3]: grain=3; NeedsGrain=False; dwelling=D2
- Iltani [P4]: grain=5; NeedsGrain=False; dwelling=D2
- Samu [P5]: grain=0; NeedsGrain=True; dwelling=D2
- MaterialDeadlock=False

## Stop

- Horizon:30
